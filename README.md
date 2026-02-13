# dll2llm

A command-line tool that generates LLM-friendly documentation from .NET DLL files. This tool helps you create comprehensive text documentation that Large Language Models can easily understand and use to provide accurate information about your .NET libraries.

## Overview

dll2llm analyzes .NET assemblies (DLL files) and extracts all public types, methods, properties, constructors, events, and other members, formatting them into a structured text document optimized for LLM consumption.

## Features

- Extracts complete public API documentation from any .NET DLL
- Generates human and LLM-readable text format
- **Includes XML documentation** (descriptions for types, methods, properties, parameters, and return values)
- Documents all public types including:
  - Classes (concrete and abstract)
  - Interfaces
  - Enums (with values)
  - Structs
  - Generic types
- Provides assembly overview with statistics
- Includes constructors, properties, methods, events, and constants
- Groups documentation by namespace
- Adds usage pattern suggestions
- Automatically resolves assembly dependencies

## Prerequisites

- .NET Framework or .NET Core/5+ runtime
- Windows, macOS, or Linux

## Building from Source

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/dll2llm.git
   cd dll2llm
   ```

2. Build the project:
   ```bash
   dotnet build -c Release
   ```

3. The executable will be in:
   ```
   bin\Release\net[version]\dll2llm.exe (Windows)
   bin/Release/net[version]/dll2llm (Linux/macOS)
   ```

## Quick Start Example

Let's say you have a DLL called `MyCompany.Utils.dll`:

```bash
# Generate documentation with default name (MyCompany.Utils.llm.txt)
dll2llm.exe MyCompany.Utils.dll

# Generate with custom output name
dll2llm.exe MyCompany.Utils.dll MyCompany_Utils_Documentation.txt

# View the generated documentation
type MyCompany.Utils.llm.txt
```

The tool will analyze the DLL and create comprehensive documentation of all public APIs.

### Windows Batch Script

For Windows users, a convenient `generate-docs.bat` script is included:
- Simply drag and drop any DLL file onto `generate-docs.bat`
- Or run: `generate-docs.bat YourLibrary.dll`
- The script will generate the documentation and offer to open it

## Usage

### Basic Usage

Generate documentation with default output filename:
```bash
dll2llm.exe MyLibrary.dll
```
This creates `MyLibrary.llm.txt` in the same directory as the DLL.

### Custom Output File

Specify a custom output filename:
```bash
dll2llm.exe MyLibrary.dll CustomDocumentation.txt
```

### Full Path Examples

Windows:
```bash
C:\Tools\dll2llm.exe "C:\Projects\MyApp\bin\Release\MyLibrary.dll" "C:\Docs\MyLibrary_API.txt"
```

Linux/macOS:
```bash
./dll2llm /usr/local/lib/MyLibrary.dll ~/docs/MyLibrary_API.txt
```

## Output Format

The generated documentation includes:

1. **Header Section**
   - Source DLL filename
   - Assembly full name
   - Generation timestamp

2. **Overview Section**
   - Total type counts (classes, interfaces, enums, etc.)
   - Namespace listing with type counts

3. **Detailed Documentation**
   - Organized by namespace
   - For each type:
     - Type kind (CLASS, INTERFACE, ENUM, etc.)
     - Full name
     - Inheritance hierarchy
     - Implemented interfaces
     - Generic parameters
     - Constructors with parameters
     - Properties with access modifiers
     - Methods with return types and parameters
     - Events
     - Constants and static fields

4. **Usage Patterns**
   - Common namespace imports
   - Most frequently used types

## Example Output

```
# LLM-FRIENDLY LIBRARY DOCUMENTATION
# Generated from: MyLibrary.dll
# Assembly: MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
# Generated: 2023-11-12 14:30:45

================================================================================
OVERVIEW
================================================================================

Total Public Types: 25
  - Classes: 15
  - Abstract Classes: 2
  - Interfaces: 5
  - Enums: 2
  - Structs: 1

NAMESPACES:
  - MyLibrary.Core (10 types)
  - MyLibrary.Utils (8 types)
  - MyLibrary.Models (7 types)

================================================================================
DETAILED TYPE DOCUMENTATION
================================================================================

NAMESPACE: MyLibrary.Core
--------------------------------------------------------------------------------

[CLASS] Calculator
Full Name: MyLibrary.Core.Calculator

Description: Provides basic arithmetic operations.

  CONSTRUCTORS:
    new Calculator()
      Description: Initializes a new instance of the Calculator class.

  METHODS:
    int Add(int a, int b)
      Description: Adds two integers and returns the result.
      @a: The first number to add.
      @b: The second number to add.
      Returns: The sum of a and b.
    int Subtract(int a, int b)
      Description: Subtracts b from a.
      @a: The number to subtract from.
      @b: The number to subtract.
      Returns: The difference between a and b.
    double Divide(double a, double b)
      Description: Divides a by b.
      @a: The dividend.
      @b: The divisor.
      Returns: The quotient of a divided by b.

[INTERFACE] IProcessor
Full Name: MyLibrary.Core.IProcessor

Description: Defines methods for processing data.

  METHODS:
    void Process(string data)
      Description: Processes the provided data synchronously.
      @data: The data to process.
    Task ProcessAsync(string data)
      Description: Processes the provided data asynchronously.
      @data: The data to process.
      Returns: A task representing the asynchronous operation.
```

## Tips for Best Results

1. **Ensure DLL Dependencies**: Make sure all dependencies of the target DLL are available in the same directory or in the GAC.

2. **Include XML Documentation**: For best results, ensure the XML documentation file (`.xml`) is in the same directory as the DLL. This file contains descriptions for types, methods, parameters, etc.

3. **Target Public APIs**: The tool only extracts public types and members, so ensure your library exposes the appropriate public API surface.

4. **Use with LLMs**: The generated documentation is optimized for LLM consumption. You can:
   - Include it in your prompts when asking about the library
   - Use it to train or fine-tune models
   - Create embeddings for semantic search

5. **Version Control**: Consider generating and committing the LLM documentation alongside your releases for historical reference.

## Using Generated Docs as an AI Agent Skill

After generating documentation, you can split large files into smaller, token-efficient chunks and use them as an AI agent skill. The `docs/revit-api/` folder contains a pre-built example for the Revit API 2025.

### Skill Structure

```
docs/revit-api/
├── SKILL.md              # Agent skill definition
├── INDEX.md              # LLM navigation index
├── application-services.md
├── db-a-b.md through db-v-z.md
└── ... (35 topic-specific files)
```

### Cursor IDE

1. **Project-level skill** (shared with repository):
   ```powershell
   # Copy to your project's .cursor/skills/ folder
   mkdir -p .cursor/skills
   cp -r docs/revit-api .cursor/skills/revit-api-docs
   ```

2. **Personal skill** (available across all projects):
   ```powershell
   # Windows
   xcopy /E /I docs\revit-api %USERPROFILE%\.cursor\skills\revit-api-docs
   
   # macOS/Linux
   cp -r docs/revit-api ~/.cursor/skills/revit-api-docs
   ```

3. The skill will automatically appear in Cursor's agent skills. When you ask about Revit API, the agent will:
   - Read `INDEX.md` to find the right file
   - Load only the specific documentation needed
   - Minimize token consumption

### VS Code with Continue or Cody

For VS Code extensions like Continue or Cody that support context providers:

1. **Continue**: Add to your `.continue/config.json`:
   ```json
   {
     "contextProviders": [
       {
         "name": "folder",
         "params": {
           "path": "docs/revit-api",
           "description": "Revit API 2025 documentation"
         }
       }
     ]
   }
   ```

2. **Cody**: Add the docs folder to your workspace and use `@docs/revit-api` mentions.

### Claude Desktop (MCP)

For Claude Desktop, use the Model Context Protocol (MCP) filesystem server:

1. **Install the MCP filesystem server**:
   ```bash
   npm install -g @anthropic/mcp-server-filesystem
   ```

2. **Configure Claude Desktop** (`claude_desktop_config.json`):
   
   **Windows** (`%APPDATA%\Claude\claude_desktop_config.json`):
   ```json
   {
     "mcpServers": {
       "revit-api-docs": {
         "command": "npx",
         "args": [
           "@anthropic/mcp-server-filesystem",
           "C:\\path\\to\\dll2llm\\docs\\revit-api"
         ]
       }
     }
   }
   ```
   
   **macOS** (`~/Library/Application Support/Claude/claude_desktop_config.json`):
   ```json
   {
     "mcpServers": {
       "revit-api-docs": {
         "command": "npx",
         "args": [
           "@anthropic/mcp-server-filesystem",
           "/path/to/dll2llm/docs/revit-api"
         ]
       }
     }
   }
   ```

3. **Restart Claude Desktop** and the docs will be available as a resource.

### Alternative: Direct Context

For any LLM interface, you can directly provide files as context:

1. Start with `INDEX.md` to understand the structure
2. Add specific files based on your query (e.g., `db-e.md` for Element-related questions)
3. Use `SKILL.md` as a system prompt for navigation guidance

## Troubleshooting

### Common Issues

1. **"Could not load file or assembly" error**
   - Ensure all dependency DLLs are in the same directory
   - Check that you're using the correct .NET version

2. **"Access denied" error**
   - Run with appropriate permissions
   - Check output directory write permissions

3. **Large output files**
   - For very large libraries, the output can be several MB
   - Consider documenting specific namespaces separately

### Error Messages

- `Usage: DllToLLMDoc.exe <path-to-dll> [output-file.txt]` - No arguments provided
- `Error: Could not load file or assembly` - DLL not found or dependencies missing
- `Error: Access to the path '...' is denied` - Insufficient permissions

## Contributing

Contributions are welcome! Please feel free to submit issues or pull requests.

## License

[Your License Here]

## Acknowledgments

This tool helps bridge the gap between traditional .NET documentation and the needs of modern AI/LLM systems.
