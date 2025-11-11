using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace DllToLLMDoc
{
    // Class to hold XML documentation
    class XmlDocumentation
    {
        private Dictionary<string, XElement> _members = new Dictionary<string, XElement>();

        public static XmlDocumentation Load(string xmlPath)
        {
            var doc = new XmlDocumentation();
            if (File.Exists(xmlPath))
            {
                try
                {
                    var xml = XDocument.Load(xmlPath);
                    var members = xml.Descendants("member");
                    foreach (var member in members)
                    {
                        var name = member.Attribute("name")?.Value;
                        if (!string.IsNullOrEmpty(name))
                        {
                            doc._members[name] = member;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Warning: Could not load XML documentation from {xmlPath}: {ex.Message}");
                }
            }
            return doc;
        }

        public string GetSummary(string memberName)
        {
            if (_members.TryGetValue(memberName, out var member))
            {
                var summary = member.Element("summary")?.Value?.Trim();
                if (!string.IsNullOrEmpty(summary))
                {
                    // Clean up the summary text
                    summary = System.Text.RegularExpressions.Regex.Replace(summary, @"\s+", " ");
                    return summary;
                }
            }
            return null;
        }

        public string GetRemarks(string memberName)
        {
            if (_members.TryGetValue(memberName, out var member))
            {
                var remarks = member.Element("remarks")?.Value?.Trim();
                if (!string.IsNullOrEmpty(remarks))
                {
                    remarks = System.Text.RegularExpressions.Regex.Replace(remarks, @"\s+", " ");
                    return remarks;
                }
            }
            return null;
        }

        public Dictionary<string, string> GetParameterDescriptions(string memberName)
        {
            var result = new Dictionary<string, string>();
            if (_members.TryGetValue(memberName, out var member))
            {
                var paramElements = member.Elements("param");
                foreach (var param in paramElements)
                {
                    var name = param.Attribute("name")?.Value;
                    var desc = param.Value?.Trim();
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(desc))
                    {
                        desc = System.Text.RegularExpressions.Regex.Replace(desc, @"\s+", " ");
                        result[name] = desc;
                    }
                }
            }
            return result;
        }

        public string GetReturns(string memberName)
        {
            if (_members.TryGetValue(memberName, out var member))
            {
                var returns = member.Element("returns")?.Value?.Trim();
                if (!string.IsNullOrEmpty(returns))
                {
                    returns = System.Text.RegularExpressions.Regex.Replace(returns, @"\s+", " ");
                    return returns;
                }
            }
            return null;
        }
    }

    class Program
    {
        private static XmlDocumentation _xmlDoc;
        static void Main(string[] args)
        {
            string dllPath;
            string outputPath;

            if (args.Length == 0)
            {
                Console.WriteLine("DLL to LLM Documentation Generator");
                Console.WriteLine("==================================");
                Console.WriteLine();
                
                // Prompt for DLL path
                Console.Write("Enter the path to the DLL file: ");
                dllPath = Console.ReadLine()?.Trim();
                
                if (string.IsNullOrWhiteSpace(dllPath))
                {
                    Console.WriteLine("Error: No DLL path provided. Exiting.");
                    return;
                }
                
                // Remove quotes if present
                dllPath = dllPath.Trim('"');
                
                // Check if file exists
                if (!File.Exists(dllPath))
                {
                    Console.WriteLine($"Error: File not found: {dllPath}");
                    return;
                }
                
                // Prompt for output path (optional)
                Console.Write($"Enter output file path (press Enter for default '{Path.GetFileNameWithoutExtension(dllPath)}.llm.txt'): ");
                string userOutput = Console.ReadLine()?.Trim();
                
                if (string.IsNullOrWhiteSpace(userOutput))
                {
                    outputPath = Path.ChangeExtension(dllPath, ".llm.txt");
                }
                else
                {
                    
                    outputPath = userOutput.Trim('"');
                }
            }
            else
            {
                dllPath = args[0];
                outputPath = args.Length > 1 ? args[1] : Path.ChangeExtension(dllPath, ".llm.txt");
            }

            try
            {
                // Set up assembly resolver for dependencies
                string dllDirectory = Path.GetDirectoryName(Path.GetFullPath(dllPath));
                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    string assemblyName = args.Name.Split(',')[0];
                    string assemblyPath = Path.Combine(dllDirectory, assemblyName + ".dll");
                    
                    if (File.Exists(assemblyPath))
                    {
                        try
                        {
                            return Assembly.LoadFrom(assemblyPath);
                        }
                        catch
                        {
                            // Continue to next resolution attempt
                        }
                    }
                    
                    // Try common .NET assemblies
                    try
                    {
                        return Assembly.Load(args.Name);
                    }
                    catch
                    {
                        Console.WriteLine($"Warning: Could not resolve dependency: {assemblyName}");
                        return null;
                    }
                };

                var doc = GenerateLLMDocumentation(dllPath);
                File.WriteAllText(outputPath, doc);
                Console.WriteLine($"Documentation generated successfully: {outputPath}");
                Console.WriteLine($"File size: {new FileInfo(outputPath).Length / 1024} KB");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        static string GenerateLLMDocumentation(string dllPath)
        {
            var assembly = Assembly.LoadFrom(dllPath);
            var sb = new StringBuilder();

            // Try to load XML documentation
            string xmlPath = Path.ChangeExtension(dllPath, ".xml");
            _xmlDoc = XmlDocumentation.Load(xmlPath);
            if (File.Exists(xmlPath))
            {
                Console.WriteLine($"Loaded XML documentation from: {xmlPath}");
            }
            else
            {
                Console.WriteLine($"No XML documentation found at: {xmlPath}");
            }

            // Header
            sb.AppendLine("# LLM-FRIENDLY LIBRARY DOCUMENTATION");
            sb.AppendLine($"# Generated from: {Path.GetFileName(dllPath)}");
            sb.AppendLine($"# Assembly: {assembly.FullName}");
            sb.AppendLine($"# Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine();
            sb.AppendLine("=" .PadRight(80, '='));
            sb.AppendLine("OVERVIEW");
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine();

            var types = assembly.GetTypes()
                .Where(t => t.IsPublic)
                .OrderBy(t => t.Namespace)
                .ThenBy(t => t.Name)
                .ToList();

            // Summary statistics
            sb.AppendLine($"Total Public Types: {types.Count}");
            sb.AppendLine($"  - Classes: {types.Count(t => t.IsClass && !t.IsAbstract)}");
            sb.AppendLine($"  - Abstract Classes: {types.Count(t => t.IsClass && t.IsAbstract)}");
            sb.AppendLine($"  - Interfaces: {types.Count(t => t.IsInterface)}");
            sb.AppendLine($"  - Enums: {types.Count(t => t.IsEnum)}");
            sb.AppendLine($"  - Structs: {types.Count(t => t.IsValueType && !t.IsEnum)}");
            sb.AppendLine();

            // Namespaces overview
            var namespaces = types.GroupBy(t => t.Namespace ?? "(Global)").OrderBy(g => g.Key);
            sb.AppendLine("NAMESPACES:");
            foreach (var ns in namespaces)
            {
                sb.AppendLine($"  - {ns.Key} ({ns.Count()} types)");
            }
            sb.AppendLine();

            // Detailed type documentation
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine("DETAILED TYPE DOCUMENTATION");
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine();

            foreach (var ns in namespaces)
            {
                sb.AppendLine();
                sb.AppendLine($"NAMESPACE: {ns.Key}");
                sb.AppendLine(new string('-', 80));
                sb.AppendLine();

                foreach (var type in ns.OrderBy(t => t.Name))
                {
                    try
                    {
                        DocumentType(type, sb);
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine($"[ERROR DOCUMENTING TYPE] {type.Name}");
                        sb.AppendLine($"Error: {ex.Message}");
                        sb.AppendLine();
                    }
                }
            }

            // Usage examples section
            sb.AppendLine();
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine("COMMON USAGE PATTERNS");
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine();
            sb.AppendLine("When using this library, follow these patterns:");
            sb.AppendLine();
            sb.AppendLine("1. Import the necessary namespaces:");
            foreach (var ns in namespaces.Take(5))
            {
                sb.AppendLine($"   using {ns.Key};");
            }
            sb.AppendLine();
            sb.AppendLine("2. Most common types to start with:");
            var mainTypes = types.Where(t => t.IsClass && !t.IsAbstract).Take(10);
            foreach (var type in mainTypes)
            {
                sb.AppendLine($"   - {type.Name}");
            }

            return sb.ToString();
        }

        // Helper method to get XML documentation member name
        static string GetXmlMemberName(MemberInfo member)
        {
            char prefix = member.MemberType switch
            {
                MemberTypes.Constructor => 'M',
                MemberTypes.Method => 'M',
                MemberTypes.Property => 'P',
                MemberTypes.Field => 'F',
                MemberTypes.Event => 'E',
                MemberTypes.TypeInfo or MemberTypes.NestedType => 'T',
                _ => 'M'
            };

            if (member is Type t)
            {
                return $"T:{t.FullName}";
            }
            else if (member is MethodBase method)
            {
                var parameters = method.GetParameters()
                    .Select(p => GetFullTypeName(p.ParameterType))
                    .ToList();
                
                var memberName = $"M:{member.DeclaringType.FullName}.{member.Name}";
                if (parameters.Any())
                {
                    memberName += $"({string.Join(",", parameters)})";
                }
                return memberName;
            }
            else
            {
                return $"{prefix}:{member.DeclaringType.FullName}.{member.Name}";
            }
        }

        static string GetFullTypeName(Type type)
        {
            if (type.IsGenericType)
            {
                var genericType = type.GetGenericTypeDefinition();
                var name = genericType.FullName.Split('`')[0];
                var genericArgs = type.GetGenericArguments()
                    .Select(GetFullTypeName);
                return $"{name}{{{string.Join(",", genericArgs)}}}";
            }
            return type.FullName;
        }

        static void DocumentType(Type type, StringBuilder sb)
        {
            // Type header
            string typeKind = type.IsInterface ? "INTERFACE" :
                             type.IsEnum ? "ENUM" :
                             type.IsValueType ? "STRUCT" :
                             type.IsAbstract ? "ABSTRACT CLASS" : "CLASS";

            sb.AppendLine($"[{typeKind}] {type.Name}");
            sb.AppendLine($"Full Name: {type.FullName}");

            // Add type description from XML documentation
            if (_xmlDoc != null)
            {
                var typeXmlName = GetXmlMemberName(type);
                var summary = _xmlDoc.GetSummary(typeXmlName);
                if (!string.IsNullOrEmpty(summary))
                {
                    sb.AppendLine();
                    sb.AppendLine($"Description: {summary}");
                }
                var remarks = _xmlDoc.GetRemarks(typeXmlName);
                if (!string.IsNullOrEmpty(remarks))
                {
                    sb.AppendLine($"Remarks: {remarks}");
                }
            }

            // Inheritance
            if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
            {
                sb.AppendLine($"Inherits: {type.BaseType.Name}");
            }

            var interfaces = type.GetInterfaces().Where(i => i.IsPublic).ToList();
            if (interfaces.Any())
            {
                sb.AppendLine($"Implements: {string.Join(", ", interfaces.Select(i => i.Name))}");
            }

            // Generic parameters
            if (type.IsGenericType)
            {
                var genericArgs = type.GetGenericArguments();
                sb.AppendLine($"Generic Parameters: <{string.Join(", ", genericArgs.Select(g => g.Name))}>");
            }

            sb.AppendLine();

            // Enums
            if (type.IsEnum)
            {
                sb.AppendLine("  Values:");
                foreach (var value in Enum.GetValues(type))
                {
                    sb.AppendLine($"    - {value} = {Convert.ToInt32(value)}");
                }
                sb.AppendLine();
                return;
            }

            // Constructors
            var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                .Where(c => !c.IsPrivate)
                .ToList();

            if (constructors.Any())
            {
                sb.AppendLine("  CONSTRUCTORS:");
                foreach (var ctor in constructors)
                {
                    sb.AppendLine($"    new {type.Name}({GetParameterList(ctor.GetParameters())})");
                    
                    // Add constructor documentation
                    if (_xmlDoc != null)
                    {
                        var ctorXmlName = GetXmlMemberName(ctor);
                        var summary = _xmlDoc.GetSummary(ctorXmlName);
                        if (!string.IsNullOrEmpty(summary))
                        {
                            sb.AppendLine($"      Description: {summary}");
                        }
                        
                        // Add parameter descriptions
                        var paramDescs = _xmlDoc.GetParameterDescriptions(ctorXmlName);
                        if (paramDescs.Any())
                        {
                            foreach (var param in ctor.GetParameters())
                            {
                                if (paramDescs.TryGetValue(param.Name, out var desc))
                                {
                                    sb.AppendLine($"      @{param.Name}: {desc}");
                                }
                            }
                        }
                    }
                }
                sb.AppendLine();
            }

            // Properties
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(p => p.DeclaringType == type)
                .OrderBy(p => p.Name)
                .ToList();

            if (properties.Any())
            {
                sb.AppendLine("  PROPERTIES:");
                foreach (var prop in properties)
                {
                    string access = "";
                    if (prop.CanRead && prop.CanWrite) access = "get; set;";
                    else if (prop.CanRead) access = "get;";
                    else if (prop.CanWrite) access = "set;";

                    string staticMod = prop.GetMethod?.IsStatic == true ? "static " : "";
                    sb.AppendLine($"    {staticMod}{GetFriendlyTypeName(prop.PropertyType)} {prop.Name} {{ {access} }}");
                    
                    // Add property description
                    if (_xmlDoc != null)
                    {
                        var propXmlName = GetXmlMemberName(prop);
                        var summary = _xmlDoc.GetSummary(propXmlName);
                        if (!string.IsNullOrEmpty(summary))
                        {
                            sb.AppendLine($"      Description: {summary}");
                        }
                    }
                }
                sb.AppendLine();
            }

            // Methods
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(m => !m.IsSpecialName && m.DeclaringType == type)
                .OrderBy(m => m.Name)
                .ToList();

            if (methods.Any())
            {
                sb.AppendLine("  METHODS:");
                foreach (var method in methods)
                {
                    string staticMod = method.IsStatic ? "static " : "";
                    string returnType = GetFriendlyTypeName(method.ReturnType);
                    string genericParams = method.IsGenericMethod ?
                        $"<{string.Join(", ", method.GetGenericArguments().Select(g => g.Name))}>" : "";

                    sb.AppendLine($"    {staticMod}{returnType} {method.Name}{genericParams}({GetParameterList(method.GetParameters())})");
                    
                    // Add method documentation
                    if (_xmlDoc != null)
                    {
                        var methodXmlName = GetXmlMemberName(method);
                        var summary = _xmlDoc.GetSummary(methodXmlName);
                        if (!string.IsNullOrEmpty(summary))
                        {
                            sb.AppendLine($"      Description: {summary}");
                        }
                        
                        // Add parameter descriptions
                        var paramDescs = _xmlDoc.GetParameterDescriptions(methodXmlName);
                        if (paramDescs.Any())
                        {
                            foreach (var param in method.GetParameters())
                            {
                                if (paramDescs.TryGetValue(param.Name, out var desc))
                                {
                                    sb.AppendLine($"      @{param.Name}: {desc}");
                                }
                            }
                        }
                        
                        // Add return value description
                        var returns = _xmlDoc.GetReturns(methodXmlName);
                        if (!string.IsNullOrEmpty(returns))
                        {
                            sb.AppendLine($"      Returns: {returns}");
                        }
                    }
                }
                sb.AppendLine();
            }

            // Events
            var events = type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(e => e.DeclaringType == type)
                .ToList();

            if (events.Any())
            {
                sb.AppendLine("  EVENTS:");
                foreach (var evt in events)
                {
                    sb.AppendLine($"    event {GetFriendlyTypeName(evt.EventHandlerType)} {evt.Name}");
                    
                    // Add event description
                    if (_xmlDoc != null)
                    {
                        var evtXmlName = GetXmlMemberName(evt);
                        var summary = _xmlDoc.GetSummary(evtXmlName);
                        if (!string.IsNullOrEmpty(summary))
                        {
                            sb.AppendLine($"      Description: {summary}");
                        }
                    }
                }
                sb.AppendLine();
            }

            // Fields (typically for constants)
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.IsLiteral || f.IsStatic)
                .ToList();

            if (fields.Any())
            {
                sb.AppendLine("  CONSTANTS/STATIC FIELDS:");
                foreach (var field in fields)
                {
                    string value = "";
                    if (field.IsLiteral)
                    {
                        try { value = $" = {field.GetRawConstantValue()}"; }
                        catch { }
                    }
                    sb.AppendLine($"    const {GetFriendlyTypeName(field.FieldType)} {field.Name}{value}");
                }
                sb.AppendLine();
            }

            sb.AppendLine(new string('-', 80));
            sb.AppendLine();
        }

        static string GetParameterList(ParameterInfo[] parameters)
        {
            if (parameters.Length == 0) return "";

            return string.Join(", ", parameters.Select(p =>
            {
                string modifier = "";
                if (p.IsOut) modifier = "out ";
                else if (p.ParameterType.IsByRef) modifier = "ref ";
                else if (p.GetCustomAttributes(typeof(ParamArrayAttribute), false).Any()) modifier = "params ";

                string defaultValue = "";
                if (p.HasDefaultValue && p.DefaultValue != null)
                {
                    defaultValue = $" = {p.DefaultValue}";
                }

                return $"{modifier}{GetFriendlyTypeName(p.ParameterType)} {p.Name}{defaultValue}";
            }));
        }

        static string GetFriendlyTypeName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (type == typeof(int)) return "int";
            if (type == typeof(string)) return "string";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(double)) return "double";
            if (type == typeof(float)) return "float";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(long)) return "long";
            if (type == typeof(object)) return "object";

            if (type.IsByRef)
            {
                return GetFriendlyTypeName(type.GetElementType());
            }

            if (type.IsArray)
            {
                return GetFriendlyTypeName(type.GetElementType()) + "[]";
            }

            if (type.IsGenericType)
            {
                var genericType = type.GetGenericTypeDefinition();
                string baseName = genericType.Name.Split('`')[0];
                var genericArgs = type.GetGenericArguments();
                return $"{baseName}<{string.Join(", ", genericArgs.Select(GetFriendlyTypeName))}>";
            }

            return type.Name;
        }
    }
}