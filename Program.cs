using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DllToLLMDoc
{
    class XmlDocumentation
    {
        private readonly Dictionary<string, XElement> _members = new();

        public static XmlDocumentation Load(string xmlPath)
        {
            var doc = new XmlDocumentation();
            if (!File.Exists(xmlPath)) return doc;
            try
            {
                var xml = XDocument.Load(xmlPath);
                foreach (var member in xml.Descendants("member"))
                {
                    var name = member.Attribute("name")?.Value;
                    if (!string.IsNullOrEmpty(name))
                        doc._members[name] = member;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: Could not load XML from {xmlPath}: {ex.Message}");
            }
            return doc;
        }

        public void Merge(XmlDocumentation other)
        {
            foreach (var kv in other._members)
                _members.TryAdd(kv.Key, kv.Value);
        }

        // Resolves XML doc tags to readable text.
        // Handles <see cref>, <paramref>, <typeparamref>, <para>, <c>, <code>.
        static string GetXmlText(XElement element)
        {
            if (element == null) return null;
            var sb = new StringBuilder();
            foreach (var node in element.Nodes())
            {
                if (node is XText text)
                {
                    sb.Append(text.Value);
                }
                else if (node is XElement child)
                {
                    switch (child.Name.LocalName)
                    {
                        case "see":
                        case "seealso":
                            var cref = child.Attribute("cref")?.Value ?? child.Attribute("href")?.Value;
                            if (!string.IsNullOrEmpty(cref))
                            {
                                var memberPath = cref.Contains(':') ? cref.Substring(2) : cref;
                                var shortName = memberPath.Split('.').Last().Split('(').First();
                                sb.Append(shortName);
                            }
                            break;
                        case "paramref":
                        case "typeparamref":
                            sb.Append(child.Attribute("name")?.Value ?? "");
                            break;
                        case "c":
                        case "code":
                            sb.Append(child.Value);
                            break;
                        case "para":
                            sb.Append(GetXmlText(child));
                            sb.Append(' ');
                            break;
                        default:
                            sb.Append(GetXmlText(child));
                            break;
                    }
                }
            }
            var result = Regex.Replace(sb.ToString().Trim(), @"\s+", " ");
            return string.IsNullOrWhiteSpace(result) ? null : result;
        }

        string ResolveTag(string memberName, string tag)
        {
            if (!_members.TryGetValue(memberName, out var member)) return null;
            return GetXmlText(member.Element(tag));
        }

        public string GetSummary(string memberName) => ResolveTag(memberName, "summary");
        public string GetRemarks(string memberName) => ResolveTag(memberName, "remarks");
        public string GetValue(string memberName) => ResolveTag(memberName, "value");
        public string GetReturns(string memberName) => ResolveTag(memberName, "returns");

        public Dictionary<string, string> GetParameterDescriptions(string memberName)
        {
            var result = new Dictionary<string, string>();
            if (!_members.TryGetValue(memberName, out var member)) return result;
            foreach (var param in member.Elements("param"))
            {
                var name = param.Attribute("name")?.Value;
                var desc = GetXmlText(param);
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(desc))
                    result[name] = desc;
            }
            return result;
        }

        public Dictionary<string, string> GetTypeParamDescriptions(string memberName)
        {
            var result = new Dictionary<string, string>();
            if (!_members.TryGetValue(memberName, out var member)) return result;
            foreach (var tp in member.Elements("typeparam"))
            {
                var name = tp.Attribute("name")?.Value;
                var desc = GetXmlText(tp);
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(desc))
                    result[name] = desc;
            }
            return result;
        }

        public List<(string ExceptionType, string Description)> GetExceptions(string memberName)
        {
            var result = new List<(string, string)>();
            if (!_members.TryGetValue(memberName, out var member)) return result;
            foreach (var ex in member.Elements("exception"))
            {
                var cref = ex.Attribute("cref")?.Value ?? "";
                var exType = cref.Contains(':') ? cref.Substring(2).Split('.').Last() : cref;
                var desc = GetXmlText(ex) ?? "";
                result.Add((exType, desc));
            }
            return result;
        }
    }

    class Program
    {
        static XmlDocumentation _xmlDoc = new XmlDocumentation();

        // Maximum types per split topic file before alphabetical sub-splitting kicks in.
        const int MaxTypesPerFile = 50;

        static void Main(string[] args)
        {
            var dllPaths = new List<string>();
            bool splitMode = false;
            bool install = false;
            string outputPath = null;
            string extraXmlPath = null;

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--split":
                        splitMode = true;
                        break;
                    case "--install":
                        install = true;
                        splitMode = true; // --install implies --split
                        break;
                    case "--output":
                        if (i + 1 < args.Length) outputPath = args[++i].Trim('"');
                        break;
                    case "--xml":
                        if (i + 1 < args.Length) extraXmlPath = args[++i].Trim('"');
                        break;
                    default:
                        if (args[i].EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                            dllPaths.Add(args[i].Trim('"'));
                        break;
                }
            }

            if (dllPaths.Count == 0)
                RunInteractive(ref dllPaths, ref splitMode, ref install, ref outputPath, ref extraXmlPath);

            if (dllPaths.Count == 0)
            {
                Console.WriteLine("Error: No DLL paths provided. Exiting.");
                return;
            }

            foreach (var dll in dllPaths)
            {
                if (!File.Exists(dll))
                {
                    Console.WriteLine($"Error: File not found: {dll}");
                    return;
                }
            }

            if (outputPath == null)
            {
                outputPath = splitMode
                    ? Path.Combine(
                        Path.GetDirectoryName(Path.GetFullPath(dllPaths[0])),
                        Path.GetFileNameWithoutExtension(dllPaths[0]).ToLower() + "-skill")
                    : Path.ChangeExtension(dllPaths[0], ".llm.txt");
            }

            try
            {
                RegisterAssemblyResolver(dllPaths);
                LoadXmlDocs(dllPaths, extraXmlPath);

                if (splitMode)
                {
                    GenerateSplitSkill(dllPaths, outputPath);
                    if (install)
                        InstallSkill(outputPath);
                }
                else
                {
                    var doc = GenerateLLMDocumentation(dllPaths);
                    File.WriteAllText(outputPath, doc, Encoding.UTF8);
                    Console.WriteLine($"Documentation generated: {outputPath}");
                    Console.WriteLine($"File size: {new FileInfo(outputPath).Length / 1024} KB");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void RunInteractive(
            ref List<string> dllPaths,
            ref bool splitMode,
            ref bool install,
            ref string outputPath,
            ref string extraXmlPath)
        {
            Console.WriteLine("DLL to LLM Documentation Generator");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.Write("DLL path(s) — comma-separated for multiple: ");
            var input = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                foreach (var p in input.Split(','))
                {
                    var path = p.Trim().Trim('"');
                    if (!string.IsNullOrEmpty(path)) dllPaths.Add(path);
                }
            }

            if (dllPaths.Count == 0) return;

            Console.Write("Generate split skill folder? (y/N): ");
            var ans = Console.ReadLine()?.Trim().ToLower();
            splitMode = ans == "y" || ans == "yes";

            if (splitMode)
            {
                Console.Write("Install to ~/.cursor/skills/ when done? (y/N): ");
                var installAns = Console.ReadLine()?.Trim().ToLower();
                install = installAns == "y" || installAns == "yes";
            }

            string defaultOutput = splitMode
                ? Path.Combine(
                    Path.GetDirectoryName(Path.GetFullPath(dllPaths[0])),
                    Path.GetFileNameWithoutExtension(dllPaths[0]).ToLower() + "-skill")
                : Path.ChangeExtension(dllPaths[0], ".llm.txt");

            Console.Write($"Output path [{defaultOutput}]: ");
            var userOut = Console.ReadLine()?.Trim().Trim('"');
            outputPath = string.IsNullOrWhiteSpace(userOut) ? defaultOutput : userOut;
        }

        // ── Assembly + XML loading ────────────────────────────────────────────

        static void RegisterAssemblyResolver(List<string> dllPaths)
        {
            var dllDirs = dllPaths
                .Select(p => Path.GetDirectoryName(Path.GetFullPath(p)))
                .Distinct()
                .ToList();

            // Tracks assembly names currently being resolved to prevent infinite re-entrancy.
            // Assembly.Load() inside the handler can re-fire AssemblyResolve for the same name
            // when the assembly is not found, causing a stack overflow without this guard.
            var resolving = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            AppDomain.CurrentDomain.AssemblyResolve += (_, resolveArgs) =>
            {
                var assemblyName = resolveArgs.Name.Split(',')[0];

                if (!resolving.Add(assemblyName))
                    return null; // already in-progress for this name — break the cycle

                try
                {
                    foreach (var dir in dllDirs)
                    {
                        var candidate = Path.Combine(dir, assemblyName + ".dll");
                        if (File.Exists(candidate))
                        {
                            try { return Assembly.LoadFrom(candidate); } catch { }
                        }
                    }
                    try { return Assembly.Load(resolveArgs.Name); }
                    catch
                    {
                        Console.WriteLine($"Warning: Could not resolve dependency: {assemblyName}");
                        return null;
                    }
                }
                finally
                {
                    resolving.Remove(assemblyName);
                }
            };
        }

        static void LoadXmlDocs(List<string> dllPaths, string extraXmlPath)
        {
            foreach (var dll in dllPaths)
            {
                var xmlPath = Path.ChangeExtension(dll, ".xml");
                if (File.Exists(xmlPath))
                {
                    _xmlDoc.Merge(XmlDocumentation.Load(xmlPath));
                    Console.WriteLine($"Loaded XML: {Path.GetFileName(xmlPath)}");
                }
                else
                {
                    Console.WriteLine($"Warning: No XML documentation found for {Path.GetFileName(dll)} — descriptions will be empty.");
                }
            }

            if (!string.IsNullOrEmpty(extraXmlPath) && File.Exists(extraXmlPath))
            {
                _xmlDoc.Merge(XmlDocumentation.Load(extraXmlPath));
                Console.WriteLine($"Loaded extra XML: {Path.GetFileName(extraXmlPath)}");
            }
        }

        // ── Type loading ──────────────────────────────────────────────────────

        static List<Type> LoadTypes(IEnumerable<string> dllPaths)
        {
            var types = new List<Type>();
            foreach (var dllPath in dllPaths)
            {
                try
                {
                    var assembly = Assembly.LoadFrom(dllPath);
                    Console.WriteLine($"Loaded assembly: {assembly.GetName().Name} {assembly.GetName().Version}");
                    try
                    {
                        types.AddRange(assembly.GetTypes().Where(t => t.IsPublic));
                    }
                    catch (ReflectionTypeLoadException rtle)
                    {
                        var loaded = rtle.Types.Where(t => t != null && t.IsPublic).ToList();
                        types.AddRange(loaded);
                        Console.WriteLine($"Warning: {rtle.LoaderExceptions.Length} type(s) failed to load from {Path.GetFileName(dllPath)} — skipped.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading {Path.GetFileName(dllPath)}: {ex.Message}");
                }
            }
            return types.OrderBy(t => t.Namespace).ThenBy(t => t.Name).ToList();
        }

        // ── Monolithic .llm.txt generation ───────────────────────────────────

        static string GenerateLLMDocumentation(IEnumerable<string> dllPaths)
        {
            var dllList = dllPaths.ToList();
            var types = LoadTypes(dllList);
            var sb = new StringBuilder();

            sb.AppendLine("# LLM-FRIENDLY LIBRARY DOCUMENTATION");
            sb.AppendLine($"# Generated from: {string.Join(", ", dllList.Select(Path.GetFileName))}");
            sb.AppendLine($"# Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine();

            AppendOverview(sb, types);
            AppendDetailedDocs(sb, types);

            return sb.ToString();
        }

        static void AppendOverview(StringBuilder sb, List<Type> types)
        {
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine("OVERVIEW");
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine();
            sb.AppendLine($"Total Public Types: {types.Count}");
            sb.AppendLine($"  - Classes: {types.Count(t => t.IsClass && !t.IsAbstract)}");
            sb.AppendLine($"  - Abstract Classes: {types.Count(t => t.IsClass && t.IsAbstract)}");
            sb.AppendLine($"  - Interfaces: {types.Count(t => t.IsInterface)}");
            sb.AppendLine($"  - Enums: {types.Count(t => t.IsEnum)}");
            sb.AppendLine($"  - Structs: {types.Count(t => t.IsValueType && !t.IsEnum)}");
            sb.AppendLine();
            sb.AppendLine("NAMESPACES:");
            foreach (var ns in types.GroupBy(t => t.Namespace ?? "(Global)").OrderBy(g => g.Key))
                sb.AppendLine($"  - {ns.Key} ({ns.Count()} types)");
            sb.AppendLine();
        }

        static void AppendDetailedDocs(StringBuilder sb, List<Type> types)
        {
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine("DETAILED TYPE DOCUMENTATION");
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine();
            foreach (var ns in types.GroupBy(t => t.Namespace ?? "(Global)").OrderBy(g => g.Key))
            {
                sb.AppendLine($"NAMESPACE: {ns.Key}");
                sb.AppendLine(new string('-', 80));
                sb.AppendLine();
                foreach (var type in ns.OrderBy(t => t.Name))
                {
                    try { DocumentType(type, sb); }
                    catch (Exception ex)
                    {
                        sb.AppendLine($"[ERROR DOCUMENTING TYPE] {type.Name}: {ex.Message}");
                        sb.AppendLine();
                    }
                }
            }
        }

        // ── Split skill generation ────────────────────────────────────────────

        static void GenerateSplitSkill(List<string> dllPaths, string outputDir)
        {
            Directory.CreateDirectory(outputDir);
            var types = LoadTypes(dllPaths);
            var assemblyNames = dllPaths.Select(p => Path.GetFileNameWithoutExtension(p)).ToList();
            string skillName = assemblyNames[0].ToLower().Replace(' ', '-');

            var byNamespace = types
                .GroupBy(t => t.Namespace ?? "(Global)")
                .OrderBy(g => g.Key)
                .ToList();

            string commonPrefix = FindCommonPrefix(byNamespace.Select(g => g.Key));

            // Build topic buckets — split large namespaces alphabetically
            var buckets = new List<(string Label, string Filename, List<Type> Types)>();
            foreach (var nsGroup in byNamespace)
            {
                var ordered = nsGroup.OrderBy(t => t.Name).ToList();
                if (ordered.Count <= MaxTypesPerFile)
                {
                    buckets.Add((nsGroup.Key, NamespaceToFilename(nsGroup.Key, commonPrefix), ordered));
                }
                else
                {
                    var baseFilename = NamespaceToFilename(nsGroup.Key, commonPrefix);
                    var chunk = new List<Type>();
                    char chunkStart = '\0', chunkEnd = '\0';

                    foreach (var ag in ordered.GroupBy(t => char.ToUpper(t.Name[0])).OrderBy(g => g.Key))
                    {
                        if (chunkStart == '\0') chunkStart = ag.Key;
                        chunk.AddRange(ag);
                        chunkEnd = ag.Key;

                        if (chunk.Count >= MaxTypesPerFile)
                        {
                            var suffix = chunkStart == chunkEnd
                                ? chunkStart.ToString().ToLower()
                                : $"{char.ToLower(chunkStart)}-{char.ToLower(chunkEnd)}";
                            var filename = baseFilename.Replace(".md", $"-{suffix}.md");
                            buckets.Add(($"{nsGroup.Key} [{suffix.ToUpper()}]", filename, new List<Type>(chunk)));
                            chunk.Clear();
                            chunkStart = '\0';
                        }
                    }
                    if (chunk.Count > 0)
                    {
                        var suffix = chunkStart == chunkEnd
                            ? chunkStart.ToString().ToLower()
                            : $"{char.ToLower(chunkStart)}-{char.ToLower(chunkEnd)}";
                        var filename = baseFilename.Replace(".md", $"-{suffix}.md");
                        buckets.Add(($"{nsGroup.Key} [{suffix.ToUpper()}]", filename, new List<Type>(chunk)));
                    }
                }
            }

            Console.WriteLine();
            foreach (var (label, filename, bucketTypes) in buckets)
            {
                var sb = new StringBuilder();
                var nsDisplay = label.Split('[')[0].Trim();
                sb.AppendLine($"# {nsDisplay}");
                sb.AppendLine();
                sb.AppendLine($"NAMESPACE: {nsDisplay}");
                sb.AppendLine(new string('-', 80));
                sb.AppendLine();
                foreach (var type in bucketTypes.OrderBy(t => t.Name))
                {
                    try { DocumentType(type, sb); }
                    catch (Exception ex)
                    {
                        sb.AppendLine($"[ERROR DOCUMENTING TYPE] {type.Name}: {ex.Message}");
                        sb.AppendLine();
                    }
                }
                File.WriteAllText(Path.Combine(outputDir, filename), sb.ToString(), Encoding.UTF8);
                Console.WriteLine($"  Written: {filename} ({bucketTypes.Count} types)");
            }

            WriteIndexFile(outputDir, types, buckets);
            WriteSkillFile(outputDir, skillName, assemblyNames, buckets);

            Console.WriteLine();
            Console.WriteLine($"Skill generated: {outputDir}");
            Console.WriteLine($"  {buckets.Count} topic files, {types.Count} total public types");
            Console.WriteLine();
            Console.WriteLine("To install as a personal Cursor skill:");
            Console.WriteLine($"  xcopy /E /I \"{outputDir}\" \"%USERPROFILE%\\.cursor\\skills\\{Path.GetFileName(outputDir)}\"");
        }

        static void InstallSkill(string skillDir)
        {
            var skillName = Path.GetFileName(skillDir.TrimEnd(Path.DirectorySeparatorChar));
            var cursorSkillsRoot = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".cursor", "skills");
            var dest = Path.Combine(cursorSkillsRoot, skillName);

            Directory.CreateDirectory(cursorSkillsRoot);

            foreach (var file in Directory.GetFiles(skillDir, "*", SearchOption.AllDirectories))
            {
                var relative = Path.GetRelativePath(skillDir, file);
                var target = Path.Combine(dest, relative);
                Directory.CreateDirectory(Path.GetDirectoryName(target));
                File.Copy(file, target, overwrite: true);
            }

            Console.WriteLine();
            Console.WriteLine($"Installed to: {dest}");
            Console.WriteLine("Restart Cursor to pick up the new skill.");
        }

        static void WriteIndexFile(
            string outputDir,
            List<Type> types,
            List<(string Label, string Filename, List<Type> Types)> buckets)
        {
            var sb = new StringBuilder();
            sb.AppendLine("# API Index");
            sb.AppendLine();
            sb.AppendLine("## Topic Files");
            sb.AppendLine();
            sb.AppendLine("| File | Namespace | Types |");
            sb.AppendLine("|------|-----------|-------|");
            foreach (var (label, filename, bucketTypes) in buckets)
                sb.AppendLine($"| [{filename}]({filename}) | {label} | {bucketTypes.Count} |");
            sb.AppendLine();
            sb.AppendLine("## Type Lookup");
            sb.AppendLine();
            sb.AppendLine("| Type | Kind | File |");
            sb.AppendLine("|------|------|------|");
            foreach (var (_, filename, bucketTypes) in buckets)
            {
                foreach (var type in bucketTypes.OrderBy(t => t.Name))
                {
                    var kind = type.IsInterface ? "Interface" :
                               type.IsEnum ? "Enum" :
                               type.IsValueType ? "Struct" :
                               type.IsAbstract ? "Abstract" : "Class";
                    sb.AppendLine($"| {type.Name} | {kind} | [{filename}]({filename}) |");
                }
            }
            File.WriteAllText(Path.Combine(outputDir, "INDEX.md"), sb.ToString(), Encoding.UTF8);
            Console.WriteLine($"  Written: INDEX.md ({types.Count} types indexed)");
        }

        static void WriteSkillFile(
            string outputDir,
            string skillName,
            List<string> assemblyNames,
            List<(string Label, string Filename, List<Type> Types)> buckets)
        {
            var displayName = string.Join(" + ", assemblyNames);
            var firstAssembly = assemblyNames[0];
            var sb = new StringBuilder();

            sb.AppendLine("---");
            sb.AppendLine($"name: {skillName}");
            sb.AppendLine($"description: >-");
            sb.AppendLine($"  {displayName} API reference for writing plugins, add-ins, and automation code.");
            sb.AppendLine($"  Provides classes, methods, properties, events, and enums.");
            sb.AppendLine($"  Use when writing {firstAssembly} code, implementing {firstAssembly} workflows,");
            sb.AppendLine($"  or asking about {displayName} API types, methods, or namespaces.");
            sb.AppendLine("---");
            sb.AppendLine();
            sb.AppendLine($"# {displayName} API");
            sb.AppendLine();
            sb.AppendLine("## How to use this skill");
            sb.AppendLine();
            sb.AppendLine("1. Read [INDEX.md](INDEX.md) to find the type or namespace you need.");
            sb.AppendLine("2. Open the relevant topic file listed in the index.");
            sb.AppendLine("3. Each topic file covers one namespace group with full type documentation.");
            sb.AppendLine();
            sb.AppendLine("## Topic files");
            sb.AppendLine();
            foreach (var (label, filename, bucketTypes) in buckets)
                sb.AppendLine($"- [{filename}]({filename}) — {label} ({bucketTypes.Count} types)");

            File.WriteAllText(Path.Combine(outputDir, "SKILL.md"), sb.ToString(), Encoding.UTF8);
            Console.WriteLine($"  Written: SKILL.md");
        }

        // ── Namespace helpers ─────────────────────────────────────────────────

        static string FindCommonPrefix(IEnumerable<string> namespaces)
        {
            var valid = namespaces.Where(ns => ns != "(Global)").ToList();
            if (!valid.Any()) return "";
            var parts = valid.Select(ns => ns.Split('.')).ToList();
            var result = new List<string>();
            int minLen = parts.Min(p => p.Length);
            for (int i = 0; i < minLen - 1; i++)
            {
                var part = parts[0][i];
                if (parts.All(p => p[i] == part)) result.Add(part);
                else break;
            }
            return string.Join(".", result);
        }

        static string NamespaceToFilename(string ns, string commonPrefix)
        {
            var suffix = !string.IsNullOrEmpty(commonPrefix) && ns.StartsWith(commonPrefix + ".")
                ? ns.Substring(commonPrefix.Length + 1)
                : ns;
            if (string.IsNullOrEmpty(suffix)) suffix = ns;
            var safe = Regex.Replace(suffix.ToLower(), @"[^a-z0-9\-]", "-");
            return safe.Trim('-') + ".md";
        }

        // ── XML member name helpers ───────────────────────────────────────────

        // Builds the XML doc member name key (e.g. "M:Namespace.Class.Method(param)")
        // following the standard documented at:
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/
        static string GetXmlMemberName(MemberInfo member)
        {
            if (member is Type t)
            {
                // Always use the generic type definition FullName to match XML keys
                var fullName = t.IsGenericType ? t.GetGenericTypeDefinition().FullName : t.FullName;
                return $"T:{fullName}";
            }

            var declType = member.DeclaringType;
            var declTypeName = declType.IsGenericType
                ? declType.GetGenericTypeDefinition().FullName
                : declType.FullName;

            if (member is MethodBase method)
            {
                var methodName = method is ConstructorInfo ? "#ctor" : method.Name;
                string genericArity = method is MethodInfo mi && mi.IsGenericMethodDefinition
                    ? $"``{mi.GetGenericArguments().Length}"
                    : "";
                var parameters = method.GetParameters()
                    .Select(p => GetXmlTypeName(p.ParameterType, method))
                    .ToList();
                var key = $"M:{declTypeName}.{methodName}{genericArity}";
                if (parameters.Any()) key += $"({string.Join(",", parameters)})";
                return key;
            }

            char prefix = member.MemberType switch
            {
                MemberTypes.Property => 'P',
                MemberTypes.Field => 'F',
                MemberTypes.Event => 'E',
                _ => 'M'
            };
            return $"{prefix}:{declTypeName}.{member.Name}";
        }

        // Converts a parameter Type to its XML doc string representation.
        // Generic type arguments use {curly} braces; generic parameters use `N / ``N notation.
        static string GetXmlTypeName(Type type, MethodBase context = null)
        {
            if (type.IsByRef)
                return GetXmlTypeName(type.GetElementType(), context) + "@";
            if (type.IsArray)
                return GetXmlTypeName(type.GetElementType(), context) + "[]";

            if (type.IsGenericParameter)
            {
                if (context is MethodInfo mi && mi.IsGenericMethodDefinition)
                {
                    int idx = Array.IndexOf(mi.GetGenericArguments(), type);
                    if (idx >= 0) return $"``{idx}";
                }
                return $"`{type.GenericParameterPosition}";
            }

            if (type.IsGenericType)
            {
                var baseName = (type.GetGenericTypeDefinition().FullName ?? type.Name).Split('`')[0];
                var args = type.GetGenericArguments().Select(a => GetXmlTypeName(a, context));
                return $"{baseName}{{{string.Join(",", args)}}}";
            }

            return type.FullName ?? type.Name;
        }

        // ── Type documentation ────────────────────────────────────────────────

        static void DocumentType(Type type, StringBuilder sb)
        {
            string typeKind = type.IsInterface ? "INTERFACE" :
                              type.IsEnum ? "ENUM" :
                              type.IsValueType ? "STRUCT" :
                              type.IsAbstract ? "ABSTRACT CLASS" : "CLASS";

            sb.AppendLine($"[{typeKind}] {type.Name}");
            sb.AppendLine($"Full Name: {type.FullName}");

            var typeXmlName = GetXmlMemberName(type);
            var summary = _xmlDoc.GetSummary(typeXmlName);
            var remarks = _xmlDoc.GetRemarks(typeXmlName);
            if (!string.IsNullOrEmpty(summary)) sb.AppendLine($"Description: {summary}");
            if (!string.IsNullOrEmpty(remarks)) sb.AppendLine($"Remarks: {remarks}");

            if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
                sb.AppendLine($"Inherits: {type.BaseType.Name}");

            // Only show interfaces declared directly on this type (not inherited ones)
            var baseInterfaces = type.BaseType?.GetInterfaces() ?? Array.Empty<Type>();
            var directInterfaces = type.GetInterfaces()
                .Where(i => i.IsPublic && !baseInterfaces.Contains(i))
                .ToList();
            if (directInterfaces.Any())
                sb.AppendLine($"Implements: {string.Join(", ", directInterfaces.Select(i => GetFriendlyTypeName(i)))}");

            if (type.IsGenericTypeDefinition)
            {
                var typeParams = type.GetGenericArguments();
                var typeParamDescs = _xmlDoc.GetTypeParamDescriptions(typeXmlName);
                var paramStrs = typeParams.Select(tp =>
                {
                    typeParamDescs.TryGetValue(tp.Name, out var desc);
                    return string.IsNullOrEmpty(desc) ? tp.Name : $"{tp.Name}: {desc}";
                });
                sb.AppendLine($"Type Parameters: <{string.Join(", ", paramStrs)}>");
            }

            sb.AppendLine();

            if (type.IsEnum)
            {
                sb.AppendLine("  Values:");
                foreach (var value in Enum.GetValues(type))
                {
                    try { sb.AppendLine($"    - {value} = {Convert.ToInt64(value)}"); }
                    catch { sb.AppendLine($"    - {value}"); }
                }
                sb.AppendLine();
                sb.AppendLine(new string('-', 80));
                sb.AppendLine();
                return;
            }

            // Constructors
            var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance).ToList();
            if (constructors.Any())
            {
                sb.AppendLine("  CONSTRUCTORS:");
                foreach (var ctor in constructors)
                {
                    try
                    {
                        sb.AppendLine($"    new {type.Name}({GetParameterList(ctor.GetParameters())})");
                        AppendMemberDocs(sb, GetXmlMemberName(ctor), ctor.GetParameters(), false);
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine($"    [SKIPPED CONSTRUCTOR]: {ex.Message}");
                    }
                }
                sb.AppendLine();
            }

            // Properties declared on this type only
            var properties = type
                .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(p => p.DeclaringType == type)
                .OrderBy(p => p.Name)
                .ToList();
            if (properties.Any())
            {
                sb.AppendLine("  PROPERTIES:");
                foreach (var prop in properties)
                {
                    try
                    {
                        var access = prop.CanRead && prop.CanWrite ? "get; set;" :
                                     prop.CanRead ? "get;" : "set;";
                        var staticMod = prop.GetMethod?.IsStatic == true ? "static " : "";
                        sb.AppendLine($"    {staticMod}{GetFriendlyTypeName(prop.PropertyType)} {prop.Name} {{ {access} }}");
                        var propXml = GetXmlMemberName(prop);
                        var propDesc = _xmlDoc.GetSummary(propXml) ?? _xmlDoc.GetValue(propXml);
                        if (!string.IsNullOrEmpty(propDesc)) sb.AppendLine($"      Description: {propDesc}");
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine($"    [SKIPPED PROPERTY] {prop.Name}: {ex.Message}");
                    }
                }
                sb.AppendLine();
            }

            // Methods declared on this type only
            var methods = type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(m => !m.IsSpecialName && m.DeclaringType == type)
                .OrderBy(m => m.Name)
                .ToList();
            if (methods.Any())
            {
                sb.AppendLine("  METHODS:");
                foreach (var method in methods)
                {
                    try
                    {
                        var staticMod = method.IsStatic ? "static " : "";
                        var returnType = GetFriendlyTypeName(method.ReturnType);
                        var genericParams = method.IsGenericMethodDefinition
                            ? $"<{string.Join(", ", method.GetGenericArguments().Select(g => g.Name))}>"
                            : "";
                        sb.AppendLine($"    {staticMod}{returnType} {method.Name}{genericParams}({GetParameterList(method.GetParameters())})");
                        AppendMemberDocs(sb, GetXmlMemberName(method), method.GetParameters(), method.ReturnType != typeof(void));
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine($"    [SKIPPED METHOD] {method.Name}: {ex.Message}");
                    }
                }
                sb.AppendLine();
            }

            // Events declared on this type only
            var events = type
                .GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(e => e.DeclaringType == type)
                .ToList();
            if (events.Any())
            {
                sb.AppendLine("  EVENTS:");
                foreach (var evt in events)
                {
                    sb.AppendLine($"    event {GetFriendlyTypeName(evt.EventHandlerType)} {evt.Name}");
                    var evtDesc = _xmlDoc.GetSummary(GetXmlMemberName(evt));
                    if (!string.IsNullOrEmpty(evtDesc)) sb.AppendLine($"      Description: {evtDesc}");
                }
                sb.AppendLine();
            }

            // Constants and static fields
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.IsLiteral || f.IsStatic)
                .ToList();
            if (fields.Any())
            {
                sb.AppendLine("  CONSTANTS/STATIC FIELDS:");
                foreach (var field in fields)
                {
                    var value = "";
                    if (field.IsLiteral)
                    {
                        try { value = $" = {field.GetRawConstantValue()}"; } catch { }
                    }
                    sb.AppendLine($"    const {GetFriendlyTypeName(field.FieldType)} {field.Name}{value}");
                    var fieldDesc = _xmlDoc.GetSummary(GetXmlMemberName(field));
                    if (!string.IsNullOrEmpty(fieldDesc)) sb.AppendLine($"      Description: {fieldDesc}");
                }
                sb.AppendLine();
            }

            sb.AppendLine(new string('-', 80));
            sb.AppendLine();
        }

        static void AppendMemberDocs(StringBuilder sb, string xmlKey, ParameterInfo[] parameters, bool showReturns)
        {
            var summary = _xmlDoc.GetSummary(xmlKey);
            if (!string.IsNullOrEmpty(summary)) sb.AppendLine($"      Description: {summary}");

            var paramDescs = _xmlDoc.GetParameterDescriptions(xmlKey);
            foreach (var param in parameters)
            {
                if (paramDescs.TryGetValue(param.Name, out var desc))
                    sb.AppendLine($"      @{param.Name}: {desc}");
            }

            if (showReturns)
            {
                var returns = _xmlDoc.GetReturns(xmlKey);
                if (!string.IsNullOrEmpty(returns)) sb.AppendLine($"      Returns: {returns}");
            }

            foreach (var (exType, exDesc) in _xmlDoc.GetExceptions(xmlKey))
            {
                sb.AppendLine(string.IsNullOrEmpty(exDesc)
                    ? $"      Throws {exType}"
                    : $"      Throws {exType}: {exDesc}");
            }
        }

        // ── Type name helpers ─────────────────────────────────────────────────

        static string GetParameterList(ParameterInfo[] parameters)
        {
            if (parameters.Length == 0) return "";
            return string.Join(", ", parameters.Select(p =>
            {
                var modifier = p.IsOut ? "out " :
                               p.ParameterType.IsByRef ? "ref " :
                               p.GetCustomAttributes(typeof(ParamArrayAttribute), false).Any() ? "params " : "";
                var defaultValue = p.HasDefaultValue && p.DefaultValue != null
                    ? $" = {p.DefaultValue}" : "";
                return $"{modifier}{GetFriendlyTypeName(p.ParameterType)} {p.Name}{defaultValue}";
            }));
        }

        static string GetFriendlyTypeName(Type type)
        {
            if (type == null) return "void";
            if (type == typeof(void)) return "void";
            if (type == typeof(int)) return "int";
            if (type == typeof(string)) return "string";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(double)) return "double";
            if (type == typeof(float)) return "float";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(long)) return "long";
            if (type == typeof(uint)) return "uint";
            if (type == typeof(ulong)) return "ulong";
            if (type == typeof(byte)) return "byte";
            if (type == typeof(short)) return "short";
            if (type == typeof(char)) return "char";
            if (type == typeof(object)) return "object";
            if (type == typeof(IntPtr)) return "IntPtr";
            if (type.IsByRef) return GetFriendlyTypeName(type.GetElementType());
            if (type.IsArray) return GetFriendlyTypeName(type.GetElementType()) + "[]";
            if (type.IsGenericType)
            {
                var baseName = type.GetGenericTypeDefinition().Name.Split('`')[0];
                var args = type.GetGenericArguments().Select(GetFriendlyTypeName);
                return $"{baseName}<{string.Join(", ", args)}>";
            }
            return type.Name;
        }
    }
}
