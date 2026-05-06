# dll2llm

A command-line tool that generates LLM-friendly documentation from .NET DLL files, with built-in support for generating ready-to-use **Cursor Agent Skills** directly from any .NET assembly.

## Overview

dll2llm reflects .NET assemblies and extracts all public types, methods, properties, constructors, events, and constants — formatting them into structured documentation optimized for LLM consumption. It supports two output modes:

- **Monolithic mode** — single `.llm.txt` file (good for small APIs, <~20k lines)
- **Split skill mode** — a complete Cursor skill folder with `SKILL.md`, `INDEX.md`, and per-namespace topic files (required for large APIs like Revit, AutoCAD)

The `docs/revit-api/` folder in this repository is a pre-built example generated from the Revit API 2025.

## Prerequisites

- .NET 8 SDK
- Windows (required for most Autodesk desktop APIs due to native dependencies)
- The target product must be **installed on the machine running dll2llm**, so its native and managed dependencies can be resolved

## Building

```bash
dotnet build -c Release
```

## Quick start — generate and install a skill in one command

```bash
# Revit API — generate skill and install to ~/.cursor/skills/
dll2llm.exe "C:\Program Files\Autodesk\Revit 2025\RevitAPI.dll" --install

# Revit API — merge DB + UI layers
dll2llm.exe "C:\Program Files\Autodesk\Revit 2025\RevitAPI.dll" ^
            "C:\Program Files\Autodesk\Revit 2025\RevitAPIUI.dll" ^
            --install

# AutoCAD .NET API
dll2llm.exe "C:\Program Files\Autodesk\AutoCAD 2025\AcDbMgd.dll" ^
            "C:\Program Files\Autodesk\AutoCAD 2025\AcMgd.dll" ^
            "C:\Program Files\Autodesk\AutoCAD 2025\AcCoreMgd.dll" ^
            --install
```

`--install` implies `--split` and copies the generated skill folder directly to `~/.cursor/skills/`. Restart Cursor after running.

## CLI usage

### Split mode (recommended for large APIs)

```bash
dll2llm.exe RevitAPI.dll RevitAPIUI.dll --split --output ./revit-api-skill
```

Produces:

```
revit-api-skill/
├── SKILL.md       ← Cursor skill definition (auto-generated)
├── INDEX.md       ← Type-to-file lookup table (auto-generated)
├── db-architecture.md
├── db-mechanical.md
└── ...            ← one file per namespace group
```

### Monolithic mode

```bash
# Default output filename (<DllName>.llm.txt)
dll2llm.exe MyLibrary.dll

# Custom output path
dll2llm.exe MyLibrary.dll MyLibrary_docs.txt

# Multiple DLLs merged into one file
dll2llm.exe RevitAPI.dll RevitAPIUI.dll --output RevitAPI_full.llm.txt
```

### All options

| Option | Description |
|--------|-------------|
| `<dll> [dll2] ...` | One or more DLL paths to process |
| `--split` | Generate split skill folder instead of a single file |
| `--install` | Generate split skill folder and install it to `~/.cursor/skills/` (implies `--split`) |
| `--output <path>` | Output file (monolithic) or directory (split) |
| `--xml <path>` | Load an additional XML documentation file (useful when XML is not co-located with the DLL) |

### Interactive mode

Run without arguments for a guided prompt:

```bash
dll2llm.exe
```

## Output format

### Split skill folder

Each topic file (`namespace-group.md`) follows this structure:

```
# Autodesk.Revit.DB.Architecture

NAMESPACE: Autodesk.Revit.DB.Architecture
--------------------------------------------------------------------------------

[CLASS] AreaBoundaryLocation
Full Name: Autodesk.Revit.DB.Architecture.AreaBoundaryLocation
Description: Indicates the location used to compute the area boundary.

  PROPERTIES:
    AreaBoundaryLocation Center { get; }
      Description: The boundary is computed at the center of the wall.
    ...

  METHODS:
    static bool Equals(object objA, object objB)
      Description: Determines whether the specified object instances are equal.
      @objA: The first object to compare.
      @objB: The second object to compare.
      Returns: true if the objects are equal.
```

### Monolithic `.llm.txt`

Same content, written as a single file with a header, overview section, and all namespaces in sequence.

## Why split mode for large APIs

A full Revit API export is ~80,000 lines (~5 MB, ~1.5M tokens). No model's context window can hold that. The split skill approach keeps token usage predictable:

- `SKILL.md` (~100 lines) + `INDEX.md` (~500 lines) load first
- The agent reads the index to identify the relevant namespace
- Only the matching topic file (~500–1,500 lines) loads into context

Total in-context at any time: well under 5,000 lines regardless of API size.

## Using the generated skill

### Cursor IDE

The easiest way is to use `--install` which handles this automatically:

```bash
dll2llm.exe RevitAPI.dll --install
```

Or copy manually:

```powershell
# Windows
xcopy /E /I ".\revit-api-skill" "%USERPROFILE%\.cursor\skills\revit-api-skill"

# macOS/Linux
cp -r ./revit-api-skill ~/.cursor/skills/revit-api-skill
```

Restart Cursor. The skill appears automatically in the agent's skill list.

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

Autodesk desktop APIs depend on native and managed binaries that ship with the product (e.g. `RevitNative.dll`, AutoCAD runtime DLLs). The tool resolves dependencies from the DLL's directory; if you copy the DLL elsewhere without its sibling binaries, type loading will fail silently or throw. **Always point the tool at the product's install directory.**

### Inherited members are not repeated on subclasses

Properties, methods, and events are only documented on the type where they are declared (`DeclaringType == type`). Inherited members from base classes (e.g. `Element.get_Id()` on every Revit element subclass) are not repeated. When writing code, check the base class documentation as well.

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
