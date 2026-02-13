---
name: revit-api-docs
description: Revit API 2025 documentation lookup. Use when writing Revit plugins, add-ins, or macros in C#. Helps find classes, methods, properties, and enums in the Autodesk.Revit namespace for Revit automation and customization.
---

# Revit API 2025 Documentation

This skill provides access to the Revit API 2025 documentation for developing Revit add-ins, plugins, and macros.

## How to Use This Documentation

### Step 1: Consult the Index First

Always start by reading `INDEX.md` to find the correct documentation file:

1. **Quick Lookup by Topic** - Find files by functional area (Elements, Geometry, MEP, etc.)
2. **File Structure Table** - See all files with namespace scope and type counts
3. **Type Directory** - Full listing of all types per file

### Step 2: Load the Specific File

Once you identify the relevant file from the index, read that file to get:
- Full class/interface/enum definitions
- Property descriptions and types
- Method signatures with parameter descriptions
- Inheritance and interface information

## File Organization

| Category | Files |
|----------|-------|
| **Core DB Types (A-Z)** | `db-a-b.md`, `db-c.md`, `db-d.md`, `db-e.md`, `db-f-g.md`, `db-h-i.md`, `db-j-l.md`, `db-m-o.md`, `db-p.md`, `db-r.md`, `db-s.md`, `db-t-u.md`, `db-v-z.md` |
| **Application** | `application-services.md`, `attributes.md`, `creation.md` |
| **MEP** | `db-mechanical.md`, `db-electrical.md`, `db-plumbing.md` |
| **Structure** | `db-structure.md`, `db-structure-sections.md` |
| **Architecture** | `db-architecture.md`, `db-analysis.md` |
| **Specialized** | `db-visual.md`, `db-events.md`, `db-fabrication.md`, `db-directcontext3d.md` |
| **Support** | `exceptions.md`, `db-extensiblestorage.md`, `db-externalservice.md` |

## Common Lookups

### Creating Elements
- **Document** class: `db-d.md`
- **Element**, **ElementId**: `db-e.md`
- **FamilyInstance**, **FamilySymbol**: `db-f-g.md`
- **Transaction**: `db-t-u.md`

### Geometry Operations
- **XYZ**, **Vector**: `db-v-z.md`
- **Curve**, **CurveLoop**: `db-c.md`
- **Solid**, **Surface**: `db-s.md`
- **Face**, **Geometry**: `db-f-g.md`

### Filtering Elements
- **FilteredElementCollector**: `db-f-g.md`
- **ElementFilter**, **ElementCategoryFilter**: `db-e.md`
- **BuiltInCategory**, **BuiltInParameter**: `db-a-b.md`

### Parameters
- **Parameter**, **ParameterFilter**: `db-p.md`
- **Definition**, **DefinitionFile**: `db-d.md`

### Views
- **View**, **ViewPlan**, **ViewSection**: `db-v-z.md`
- **GraphicsStyle**: `db-f-g.md`

### Events & Transactions
- **Transaction**, **TransactionGroup**: `db-t-u.md`
- **DocumentChanged**, event args: `db-events.md`
- **IExternalCommand**: `db-h-i.md`

## Search Strategy

If you don't know which file contains a type:

1. **By first letter**: Core DB types are split alphabetically (e.g., `Wall` → `db-v-z.md`)
2. **By namespace**: Sub-namespaces have dedicated files (e.g., `Autodesk.Revit.DB.Structure` → `db-structure.md`)
3. **By topic**: Use the Quick Lookup section in `INDEX.md`
4. **Type Directory**: Scan the comma-separated type lists in `INDEX.md`

## Documentation Format

Each type entry includes:
- **Type tag**: `[CLASS]`, `[ENUM]`, `[INTERFACE]`, `[ABSTRACT CLASS]`, `[STRUCT]`
- **Full Name**: Complete namespace path
- **Description**: What the type does
- **Inherits/Implements**: Base class and interfaces
- **Properties**: With types and descriptions
- **Methods**: With signatures, parameter descriptions, and return values
- **Events**: For event-enabled classes
