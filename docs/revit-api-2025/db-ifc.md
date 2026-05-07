# Autodesk.Revit.DB.IFC

NAMESPACE: Autodesk.Revit.DB.IFC
--------------------------------------------------------------------------------

[ENUM] IFCImportAction
Full Name: Autodesk.Revit.DB.IFC.IFCImportAction
Description: The action of the IFC import.
Inherits: Enum

  Values:
    - Open = 0
    - Link = 1

--------------------------------------------------------------------------------

[ENUM] IFCImportIntent
Full Name: Autodesk.Revit.DB.IFC.IFCImportIntent
Description: The intent of the IFC import.
Inherits: Enum

  Values:
    - Parametric = 0
    - Reference = 1

--------------------------------------------------------------------------------

[CLASS] IFCImportOptions
Full Name: Autodesk.Revit.DB.IFC.IFCImportOptions
Description: IFC Import options.
Implements: IDisposable

  CONSTRUCTORS:
    new IFCImportOptions()
      Description: Constructs a new IFCImportOptions using default settings.

  PROPERTIES:
    IFCImportAction Action { get; set; }
      Description: The action of the import.
    bool AutocorrectOffAxisLines { get; set; }
      Description: Enable or disable correcting lines that are slight off-axis.
    bool AutoJoin { get; set; }
      Description: Enable or disable auto-join at the end of import.
    bool CreateLinkInstanceOnly { get; set; }
      Description: Determines whether to create a linked symbol element or not.
    bool ForceImport { get; set; }
      Description: Force the IFC file to be imported regardless of an existing corresponding Revit file.
    IFCImportIntent Intent { get; set; }
      Description: The intent of the import.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string RevitLinkFileName { get; set; }
      Description: The full path of the intermediate Revit file created during a previous link action. This is used during "Reload From" to determine the path to the previous generated Revit file.

  METHODS:
    void Dispose()
    LinkConversionData GetConversionData()
      Description: Get the data used in the creation of the associated Revit file for an IFC link operation, if it exists.
    IDictionary<string, string> GetExtraOptions()
      Description: Get the list of extra options to be passed into the importer. Each entry in the map is a pair of option name and value.
      Returns: The list of options.
    void SetExtraOptions(IDictionary<string, string> options)
      Description: Set the list of extra options to be passed into the importer. Each entry in the map is a pair of option name and value. Note that any value here will overwrite the other values in the IFCImportOptions, if it has the same name.
      @options: The list of options.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

