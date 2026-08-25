# dll2llm

## This is a work in progress

A command-line tool that generates ready-to-use **Cursor Agent Skills** directly from any .NET assembly.

## Overview

dll2llm reflects .NET assemblies and extracts public types, constructors, methods, properties, events, and constants — formatting them into a Cursor skill folder with `SKILL.md` (including YAML frontmatter), `INDEX.md`, and topic Markdown files, optimized for LLM consumption.

This repository includes pre-built examples under **`docs/revit-api-2025/`** and **`docs/revit-api-2026/`**, generated from the Revit API for those releases.

## Prerequisites

- .NET 8 SDK
- Windows (required for most Autodesk desktop APIs due to native dependencies)
- The target product must be **installed on the machine running dll2llm**, so its native and managed dependencies can be resolved

## Building

```bash
dotnet build -c Release
```

The executable is emitted under `bin/Release/net8.0/` (or `bin/Debug/net8.0/` after a Debug build).

## Quick start — generate and install a skill in one command

Adjust the year and install path to match your Revit version.

```bash
# Revit API — generate skill and install to %USERPROFILE%\.cursor\skills\
dll2llm.exe "C:\Program Files\Autodesk\Revit 2026\RevitAPI.dll" --install

# Revit API — merge DB + UI layers
dll2llm.exe "C:\Program Files\Autodesk\Revit 2026\RevitAPI.dll" ^
            "C:\Program Files\Autodesk\Revit 2026\RevitAPIUI.dll" ^
            --install

# AutoCAD .NET API (adjust year to your install)
dll2llm.exe "C:\Program Files\Autodesk\AutoCAD 2026\AcDbMgd.dll" ^
            "C:\Program Files\Autodesk\AutoCAD 2026\AcMgd.dll" ^
            "C:\Program Files\Autodesk\AutoCAD 2026\AcCoreMgd.dll" ^
            --install
```

`--install` copies the generated skill folder to `%USERPROFILE%\.cursor\skills\<folder-name>\`, where `<folder-name>` is the basename of your `--output` directory (see below). Restart Cursor after running.

## CLI usage

```bash
dll2llm.exe RevitAPI.dll RevitAPIUI.dll --output ./revit-api-skill
```

If you omit `--output`, the default is **`<directory-of-first-dll>\<first-assembly-name-lower>-skill`** (for example, pointing at `RevitAPI.dll` yields `revitapi-skill` next to that DLL).

Produces:

```
revit-api-skill/
├── SKILL.md       ← Cursor skill (YAML frontmatter + links to topics)
├── INDEX.md       ← Topic table + per-type file lookup
├── db-architecture-b-s.md
├── db-mechanical-a-r.md
└── ...            ← one or more files per namespace; large namespaces are split alphabetically
```

### All options

| Option | Description |
|--------|-------------|
| `<dll> [dll2] ...` | One or more DLL paths to process |
| `--install` | Copy the generated skill folder to `%USERPROFILE%\.cursor\skills\<output-folder-name>\` |
| `--output <path>` | Output directory for the skill folder |
| `--xml <path>` | Load an additional XML documentation file (useful when XML is not co-located with the DLL) |

### Interactive mode

Run without arguments for a guided prompt:

```bash
dll2llm.exe
```

## Output format

### Skill folder

Large namespaces are split into multiple topic files when they exceed **50 public types**, using consecutive letter ranges in the filename (for example `db-b-c.md`, `db-architecture-t-w.md`). Small namespaces still get a single file (for example `creation.md`).

Each topic file groups types with the same header pattern: namespace title, `NAMESPACE:` line, separator, then per-type blocks.

### Per-type sections

Documentation includes, when applicable:

- Kind, full name, summary and remarks from XML, base type (`Inherits`), directly implemented interfaces
- Generic type parameter descriptions
- For enums: numeric values (best-effort for non-`int`/`long` underlying types)
- **CONSTRUCTORS**, **PROPERTIES**, **METHODS** (with parameter/return/exception text from XML), **EVENTS**, **CONSTANTS/STATIC FIELDS**

## Why a skill folder for large APIs

A full Revit API export is on the order of tens of thousands of lines and millions of tokens. The skill folder approach keeps token usage predictable:

- `SKILL.md` stays small; the agent loads it first
- `INDEX.md` lists every type and which topic file contains it (this file grows with API size)
- Only the relevant topic file(s) need to be read for a given question

## Using the generated skill

### Cursor IDE

The easiest way is `--install`, which copies to your user skills directory automatically.

Or copy manually:

```powershell
# Windows
xcopy /E /I ".\revit-api-skill" "%USERPROFILE%\.cursor\skills\revit-api-skill"
```

```bash
# macOS/Linux
cp -r ./revit-api-skill ~/.cursor/skills/revit-api-skill
```

Restart Cursor. The skill appears in the agent's skill list.

### Claude Desktop (MCP filesystem)

```bash
npm install -g @anthropic/mcp-server-filesystem
```

Add to `claude_desktop_config.json`:

**Windows** (`%APPDATA%\Claude\claude_desktop_config.json`):

```json
{
  "mcpServers": {
    "revit-api": {
      "command": "npx",
      "args": ["@anthropic/mcp-server-filesystem", "C:\\path\\to\\revit-api-skill"]
    }
  }
}
```

**macOS** (`~/Library/Application Support/Claude/claude_desktop_config.json`):

```json
{
  "mcpServers": {
    "revit-api": {
      "command": "npx",
      "args": ["@anthropic/mcp-server-filesystem", "/path/to/revit-api-skill"]
    }
  }
}
```

Restart Claude Desktop and the docs are available as a resource.

---

## Known limitations

### Must run on a machine with the product installed

Autodesk desktop APIs depend on native and managed binaries that ship with the product (for example `RevitNative.dll`, AutoCAD runtime DLLs). The tool resolves dependencies from the DLL's directory; if you copy the DLL elsewhere without its sibling binaries, type loading will fail silently or throw. **Always point the tool at the product's install directory.**

### Inherited members are not repeated on subclasses

Properties, methods, and events are only documented on the type where they are declared (`DeclaringType == type`). Inherited members from base classes (for example `Element.get_Id()` on every Revit element subclass) are not repeated. When writing code, check the base class documentation as well.

### No XML = no descriptions

If the API does not ship an XML documentation file alongside the DLL (common for Inventor's COM interop assembly, some Navisworks assemblies, and older ObjectARX wrappers), the tool produces complete structural documentation (types, signatures, enums) but every description field will be empty.

### Native (unmanaged) DLLs are not supported

The tool uses .NET reflection and only works with managed assemblies. Native C++ DLLs (ObjectARX `.arx` / `.dll`) cannot be processed and will fail immediately.

### COM interop assemblies load but have limited value

Inventor's primary API is COM-based. The .NET interop assembly (`Autodesk.Inventor.Interop.dll`) can be reflected but ships without XML documentation, so the output contains signatures only with no descriptions.

### Large enum values may not convert cleanly

Enum underlying types other than `int` or `long` are handled with a best-effort `Convert.ToInt64` and may be skipped silently on overflow.

### Generic XML key matching — edge cases

The tool generates standard XML doc member keys (backtick arity notation for type definitions, `{curly}` braces for generic type arguments in signatures). Complex generic scenarios (nested generics, generic methods with constraints) may still produce key mismatches and missing descriptions.

---

## Troubleshooting

| Error | Likely cause | Fix |
|-------|-------------|-----|
| `Could not load file or assembly` | Missing dependency DLLs | Point the tool at the product's install folder, not a copy of the DLL |
| `Warning: Could not resolve dependency` | A transitive dependency is missing | Safe to ignore if types load; re-run from the install directory for best results |
| `Warning: No XML documentation found` | No `.xml` file alongside the DLL | Expected for APIs that don't ship XML; use `--xml` to provide one if available separately |
| Many `[ERROR DOCUMENTING TYPE]` entries | Incompatible .NET target or native dependency issues | Ensure you are targeting the correct .NET version and running on a machine with the product installed |
| Access denied on output path | Insufficient permissions | Run from a directory where you have write access, or specify `--output` pointing to a writable location |

---

## Contributing

Contributions welcome. Please open an issue or pull request.

## License

MIT License — see [LICENSE](LICENSE) for details.

## Written by

Joao Martins [in/jpornelas](https://linkedin.com/in/jpornelas), [Developer Advocate](http://aps.autodesk.com)
