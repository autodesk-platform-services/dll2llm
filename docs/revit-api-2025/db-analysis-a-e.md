# Autodesk.Revit.DB.Analysis

NAMESPACE: Autodesk.Revit.DB.Analysis
--------------------------------------------------------------------------------

[ENUM] AllowLargeGeometry
Full Name: Autodesk.Revit.DB.Analysis.AllowLargeGeometry
Description: An enumerated type containing settings information related to handling of large geometries.
Inherits: Enum

  Values:
    - DisAllow = 0
    - Allow = 1
    - Prompt = 2

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayColoredSurfaceSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings
Description: Contains colored surface settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayColoredSurfaceSettings()
      Description: Constructs a default instance of colored surface settings.
    new AnalysisDisplayColoredSurfaceSettings(AnalysisDisplayColoredSurfaceSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayColoredSurfaceSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    Color GridColor { get; set; }
      Description: Color of grid lines.
    int GridLineWeight { get; set; }
      Description: Line weight of grid lines.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ShowContourLines { get; set; }
      Description: If true, show contour lines in the analysis display.
    bool ShowGridLines { get; set; }
      Description: If true, show grid lines in the analysis display.
    int Transparency { get; set; }
      Description: Transparency percentage of colored surface

  METHODS:
    void Dispose()
    bool IsEqual(AnalysisDisplayColoredSurfaceSettings other)
      Description: Compares two colored surface settings objects.
      @other: Colored surface settings object to compare with.
      Returns: True if objects are equal, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayColorEntry
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry
Description: Contains one entry of intermediate colors in color settings for analysis display style.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayColorEntry(Color color)
      Description: Constructs a color entry with no value assigned.
      @color: Color assigned to the entry.
      Throws ArgumentNullException: A non-optional argument was null
    new AnalysisDisplayColorEntry(Color color, double value)
      Description: Constructs a color entry with a specific value assigned.
      @color: Color assigned to the entry.
      @value: Value assigned to the entry.
      Throws ArgumentNullException: A non-optional argument was null
    new AnalysisDisplayColorEntry()
      Description: Constructs a new AnalysisDisplayColorEntry with default settings.

  PROPERTIES:
    Color Color { get; }
      Description: Color associated with color entry.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Value { get; }
      Description: Value associated with color entry.

  METHODS:
    void Dispose()
    bool HasValue()
      Description: Check if color entry has associated value.
      Returns: True if entry has a value associated with it, false otherwise.
    bool IsEqual(AnalysisDisplayColorEntry other)
      Description: Compare color entries.
      @other: Color entry to compare to.
      Returns: True if color entries are equal, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayColorSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings
Description: Contains color settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayColorSettings()
      Description: Constructs a default instance of color settings.
    new AnalysisDisplayColorSettings(AnalysisDisplayColorSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayColorSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    AnalysisDisplayStyleColorSettingsType ColorSettingsType { get; set; }
      Description: Stores type of color settings
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color MaxColor { get; set; }
      Description: Color assigned to the maximum value.
    Color MinColor { get; set; }
      Description: Color assigned to the minimum value.

  METHODS:
    bool AreIntermediateColorsValid(IList<AnalysisDisplayColorEntry> map)
      Description: Verify intermediate color entries
      @map: Array of intermediate color entries.
      Returns: True if intermediate colors are valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    int Colors()
      Description: Get number of colors, including min, max and intermediate.
      Returns: Number of colors, including min, max and intermediate.
    void Dispose()
    IList<AnalysisDisplayColorEntry> GetIntermediateColors()
      Description: Get intermediate color entries (other than the minimum and maximum settings).
      Returns: Array of intermediate color entries.
    bool IsEqual(AnalysisDisplayColorSettings other)
      Description: Compares two color settings objects.
      @other: Color settings object to compare to.
      Returns: True if objects are equal, false otherwise.
    void SetIntermediateColors(IList<AnalysisDisplayColorEntry> map)
      Description: Set intermediate color entries (other than the minimum and maximum settings).
      @map: Array of intermediate color entries.
      Throws ArgumentException: intermediate color entries with specific values are not ordered by value (min to max) or too many intermediate colors (>100).
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayDeformedShapeSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings
Description: Contains deformed shape settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayDeformedShapeSettings()
      Description: Constructs a default instance of deformed shape settings.
    new AnalysisDisplayDeformedShapeSettings(AnalysisDisplayDeformedShapeSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayDeformedShapeSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    Color GridColor { get; set; }
      Description: Color of grid lines.
    int GridLineWeight { get; set; }
      Description: Line weight of grid lines.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Rounding { get; set; }
      Description: Increment to which numeric values of analysis results are rounded in deformed shape.
    bool ShowContourLines { get; set; }
      Description: If true, show contour lines in the analysis display.
    bool ShowGridLines { get; set; }
      Description: If true, show grid lines in the analysis display.
    AnalysisDisplayStyleDeformedShapeTextLabelType TextLabelType { get; set; }
      Description: Type of deformed shape text visualization.
    ElementId TextTypeId { get; set; }
      Description: Element id of text associated with the settings.
    int Transparency { get; set; }
      Description: Transparency percentage of deformed shape color fill on surfaces

  METHODS:
    void Dispose()
    bool IsEqual(AnalysisDisplayDeformedShapeSettings other)
      Description: Compares two deformed shape settings objects.
      @other: Deformed shape settings object to compare with.
      Returns: True if objects are equal, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayDiagramSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings
Description: Contains diagram settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayDiagramSettings()
      Description: Constructs a default instance of diagram settings.
    new AnalysisDisplayDiagramSettings(AnalysisDisplayDiagramSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayDiagramSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    AnalysisDisplayStyleDiagramFenceType FenceType { get; set; }
      Description: Type of diagram fence visualization.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color OutlineColor { get; set; }
      Description: Color of outline and fence lines in the diagram.
    int OutlineLineWeight { get; set; }
      Description: Line weight of outline and fence lines in the diagram.
    double Rounding { get; set; }
      Description: Increment to which numeric values of analysis results are rounded in diagram.
    AnalysisDisplayStyleDiagramTextLabelType TextLabelType { get; set; }
      Description: Type of diagram text label visualization.
    ElementId TextTypeId { get; set; }
      Description: Element id of text associated with the settings.
    int Transparency { get; set; }
      Description: Transparency percentage of diagram color fill

  METHODS:
    void Dispose()
    bool IsEqual(AnalysisDisplayDiagramSettings other)
      Description: Compares two diagram settings objects.
      @other: Diagram settings object to compare with.
      Returns: True if objects are equal, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayLegend
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayLegend
Description: The legend that describes an Analysis Visualization.
Inherits: Element

  PROPERTIES:
    double Height { get; set; }
      Description: The height, in sheet size, of the legend's rectangle

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayLegendSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings
Description: Contains legend settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayLegendSettings()
      Description: Constructs a default instance of legend settings.
    new AnalysisDisplayLegendSettings(AnalysisDisplayLegendSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayLegendSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    int ColorRangeHeight { get; set; }
      Description: Height of color range (for Colored Surface, Markers and Text, and Vector display). Measured in paperspace units.
    int ColorRangeWidth { get; set; }
      Description: Width of color range (for Colored Surface, Markers and Text, and Vector display). Measured in paperspace units.
    ElementId HeadingTextTypeId { get; set; }
      Description: Element id of text associated with legend heading.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double NumberForScale { get; set; }
      Description: A fixed value to display on the legend scale (0 by default; 0 means width of legend scale is calculated dynamically).
    int NumberOfSteps { get; set; }
      Description: Number of steps (values between minimum and maximum) to be shown in legend.
    double Rounding { get; set; }
      Description: Rounding increment for numeric values of analysis results.
    int ScaleHeight { get; set; }
      Description: Height of scale (for Diagram display). Measured in paperspace units.
    bool ShowDataDescription { get; set; }
      Description: If true, data description is shown in the legend.
    bool ShowDataName { get; set; }
      Description: If true, data name is shown in the legend.
    bool ShowLegend { get; set; }
      Description: If true, legend is shown in the view.
    bool ShowUnits { get; set; }
      Description: If true, units are shown in the legend.
    ElementId TextTypeId { get; set; }
      Description: Element id of text associated with legend body.

  METHODS:
    void Dispose()
    bool IsEqual(AnalysisDisplayLegendSettings other)
      Description: Compares two legend settings objects.
      @other: Legend settings object to compare to.
      Returns: True if objects are equal, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayMarkersAndTextSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings
Description: Contains markers and text settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayMarkersAndTextSettings()
      Description: Constructs a default instance of markers and text settings.
    new AnalysisDisplayMarkersAndTextSettings(AnalysisDisplayMarkersAndTextSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayMarkersAndTextSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MarkerSize { get; set; }
      Description: Size of marker.
    AnalysisDisplayStyleMarkerType MarkerType { get; set; }
      Description: Type of marker.
    double Rounding { get; set; }
      Description: Increment to which numeric values of analysis results are rounded in markers.
    AnalysisDisplayStyleMarkerTextLabelType TextLabelType { get; set; }
      Description: Type of diagram text label visualization.
    ElementId TextTypeId { get; set; }
      Description: Element id of text associated with the settings.

  METHODS:
    void Dispose()
    bool IsEqual(AnalysisDisplayMarkersAndTextSettings other)
      Description: Compares two colored surface settings objects.
      @other: Markers and text settings object to compare with.
      Returns: True if objects are equal, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayStyle
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle
Description: Exposes API for manipulation of analysis display style.
Inherits: Element

  METHODS:
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayDeformedShapeSettings deformedShapeSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Deformed Shape for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @deformedShapeSettings: Deformed Shape settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: document is a family. -or- name is not unique in document.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayVectorSettings vectorSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Vectors for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @vectorSettings: Vector settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: document is a family. -or- name is not unique in document.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayDiagramSettings diagramSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Diagram for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @diagramSettings: Diagram settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: document is a family. -or- name is not unique in document.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayMarkersAndTextSettings markersAndTextSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Markers and Text for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @markersAndTextSettings: Markers and text settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: document is a family. -or- name is not unique in document.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayColoredSurfaceSettings coloredSurfaceSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Colored Surface for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @coloredSurfaceSettings: Colored surface settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: document is a family. -or- name is not unique in document.
    static ElementId FindByName(Document document, string name)
      Description: Finds analysis display style by name.
      @document: Document in which to look for analysis display style element.
      @name: Name of analysis display style to look for.
      Returns: Element id of the found analysis display style, invalidElementId if not found.
      Throws ArgumentNullException: A non-optional argument was null
    AnalysisDisplayColoredSurfaceSettings GetColoredSurfaceSettings()
      Description: Get colored surface settings object from the style.
      Throws InvalidOperationException: colored surface settings were not created with the object.
    AnalysisDisplayColorSettings GetColorSettings()
      Description: Get color settings object from the style.
    AnalysisDisplayDeformedShapeSettings GetDeformedShapeSettings()
      Description: Get deformed shape settings object from the style.
      Throws InvalidOperationException: deformed shape settings were not created with the object.
    AnalysisDisplayDiagramSettings GetDiagramSettings()
      Description: Get diagram settings object from the style.
      Throws InvalidOperationException: diagram settings were not created with the object.
    static ICollection<ElementId> GetElements(Document document)
      Description: Returns set of all analysis display styles elements in the given document.
      @document: Document from which analysis display style elements are retrieved.
      Returns: All analysis display style elements existing in the document.
      Throws ArgumentNullException: A non-optional argument was null
    AnalysisDisplayLegendSettings GetLegendSettings()
      Description: Get legend settings object from the style.
    AnalysisDisplayMarkersAndTextSettings GetMarkersAndTextSettings()
      Description: Get markers and text settings object from the style.
      Throws InvalidOperationException: markers and text settings were not created with the object.
    AnalysisDisplayVectorSettings GetVectorSettings()
      Description: Get vector settings object from the style.
      Throws InvalidOperationException: vector settings were not created with the object.
    bool HasColoredSurfaceSettings()
      Description: If true style has colored surface settings.
    bool HasDeformedShapeSettings()
      Description: If true style has deformed shape settings.
    bool HasDiagramSettings()
      Description: If true style has diagram settings.
    bool HasMarkersAndTextSettings()
      Description: If true style has markers and text settings.
    bool HasVectorSettings()
      Description: If true style has vector settings.
    static bool IsNameUnique(Document document, string name, AnalysisDisplayStyle excludedElement)
      Description: Verify the uniqueness of the name among all analysis display style elements of the document.
      @document: Document in which name uniqueness is verified.
      @name: Name to verify uniqueness of.
      @excludedElement: Element to be excluded from uniqueness verification (for renaming of an existing element).
      Returns: True if name is unique, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsTextTypeIdValid(ElementId textTypeId, Document doc)
      Description: Verify if text type id is valid.
      @textTypeId: Text type id to be validated.
      @doc: Document for which %textTypeId% is validated.
      Returns: True if text type id is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetColoredSurfaceSettings(AnalysisDisplayColoredSurfaceSettings coloredSurfaceSettings)
      Description: Set colored surface settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: colored surface settings were not created with the object.
    void SetColorSettings(AnalysisDisplayColorSettings colorSettings)
      Description: Set color settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: for Diagram display style, colorSettings must have type SolidColorRanges and exactly one intermediate entry with zero value
    void SetDeformedShapeSettings(AnalysisDisplayDeformedShapeSettings deformedShapeSettings)
      Description: Set deformed shape settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Deformed shape settings were not created with the object.
    void SetDiagramSettings(AnalysisDisplayDiagramSettings diagramSettings)
      Description: Set diagram settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: diagram settings were not created with the object.
    void SetLegendSettings(AnalysisDisplayLegendSettings legendSettings)
      Description: Set legend settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMarkersAndTextSettings(AnalysisDisplayMarkersAndTextSettings markersAndTextSettings)
      Description: Set markers and text settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: markers and text settings were not created with the object.
    void SetName(string name)
      Description: Set name of analysis display style element.
      @name: Analysis display style element name to be set.
      Throws ArgumentException: name is not unique in document.
      Throws ArgumentNullException: A non-optional argument was null
    void SetVectorSettings(AnalysisDisplayVectorSettings vectorSettings)
      Description: Set vector settings object for the style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Vector settings were not created with the object.

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleColorSettingsType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType
Description: Defines types for color settings of analysis display style.
Inherits: Enum

  Values:
    - GradientColor = 0
    - SolidColorRanges = 1

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleDeformedShapeTextLabelType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType
Description: Defines text visualization types for deformed shape settings of analysis display style.
Inherits: Enum

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleDiagramFenceType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType
Description: Defines fence visualization types for diagram settings of analysis display style.
Inherits: Enum

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleDiagramTextLabelType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType
Description: Defines text label visualization types for diagram settings of analysis display style.
Inherits: Enum

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleMarkerTextLabelType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType
Description: Text label visualization types for Markers and Text settings of analysis display style.
Inherits: Enum

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleMarkerType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerType
Description: Marker types for Markers and Text settings of analysis display style.
Inherits: Enum

  Values:
    - Circle = 0
    - Square = 1
    - Triangle = 2

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleVectorArrowheadScale
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorArrowheadScale
Description: Defines arrow head scaling for vector settings of analysis display style.
Inherits: Enum

  Values:
    - NoScaling = 0
    - Length5Percent = 1
    - Length10Percent = 2
    - Length15Percent = 3
    - Length20Percent = 4
    - NoArrow = 5

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleVectorOrientation
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorOrientation
Description: Defines vector orientation for vector settings of analysis display style.
Inherits: Enum

  Values:
    - Linear = 0
    - ArcAroundVectorAxis = 1

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleVectorPosition
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorPosition
Description: Defines vector position for vector settings of analysis display style.
Inherits: Enum

  Values:
    - ToDataPoint = 0
    - FromDataPoint = 1

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleVectorTextType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType
Description: Defines text visualization types for vector settings of analysis display style.
Inherits: Enum

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayVectorSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings
Description: Contains vector settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayVectorSettings()
      Description: Constructs a default instance of vector settings.
    new AnalysisDisplayVectorSettings(AnalysisDisplayVectorSettings other)
      Description: Constructs a new copy of the input AnalysisDisplayVectorSettings object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    AnalysisDisplayStyleVectorArrowheadScale ArrowheadScale { get; set; }
      Description: Type of arrow head scaling.
    int ArrowLineWeight { get; set; }
      Description: Line weight assigned to arrow lines for vectors.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Rounding { get; set; }
      Description: Increment to which numeric values of analysis results are rounded in vectors.
    ElementId TextTypeId { get; set; }
      Description: Element id of text associated with the settings.
    AnalysisDisplayStyleVectorOrientation VectorOrientation { get; set; }
      Description: Vector orientation.
    AnalysisDisplayStyleVectorPosition VectorPosition { get; set; }
      Description: Vector position.
    AnalysisDisplayStyleVectorTextType VectorTextType { get; set; }
      Description: Type of vector text visualization.

  METHODS:
    void Dispose()
    bool IsEqual(AnalysisDisplayVectorSettings other)
      Description: Compares two vector settings objects.
      @other: Vector settings object to compare with.
      Returns: True if objects are equal, false otherwise.

--------------------------------------------------------------------------------

[ENUM] AnalysisMode
Full Name: Autodesk.Revit.DB.Analysis.AnalysisMode
Description: This enum is used to define the Energy Analysis Model.
Inherits: Enum

  Values:
    - BuildingElements = 0
    - ConceptualMassesAndBuildingElements = 2
    - RoomsOrSpaces = 3

--------------------------------------------------------------------------------

[CLASS] AnalysisResultSchema
Full Name: Autodesk.Revit.DB.Analysis.AnalysisResultSchema
Description: Contains all information about one analysis result. Each result may contain several measurements.
Remarks: In order to take effect, the AnalysisResultSchema object has to be registered by calling SpatialFieldManager::RegisterResult, which returns result index for future references; to make changes to the properties of an already registered object, use method SpatialFieldManager::SetResultSchema and supply result index and replacing object.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisResultSchema(string name, string description)
      Description: Creates object and assigns name and description
      @name: Name of the result schema
      @description: Description of the result schema
      Throws ArgumentNullException: A non-optional argument was null
    new AnalysisResultSchema(AnalysisResultSchema other)
      Description: Constructs a new copy of the input AnalysisResultSchema object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    ElementId AnalysisDisplayStyleId { get; set; }
      Description: ElementId of analysis display style overriding the style set for view; -1 if the style is not overridden
    int CurrentUnits { get; set; }
      Description: Stores the index in the array of applicable units
    string Description { get; set; }
      Description: Description of analysis result in view
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVisible { get; set; }
      Description: If true analysis result is visible in view
    string Name { get; set; }
      Description: Name of analysis result in view
    double Scale { get; set; }
      Description: Multiplier used for displaying diagram or vector values in view.

  METHODS:
    void Dispose()
    int GetNumberOfUnits()
      Description: returns number of possible units
    double GetUnitsMultiplier(int index)
      Description: returns units multiplier by index
      @index: index of unit in the list
    string GetUnitsName(int index)
      Description: returns units name by index
      @index: index of unit in the list
    bool IsEqual(AnalysisResultSchema other)
      Description: Determines if the input object is equivalent to this AnalysisResultSchema.
      Throws ArgumentNullException: A non-optional argument was null
    void SetUnits(IList<string> names, IList<double> multipliers)
      Description: Sets names and multipliers of all units for result visualization
      @names: Unit names for all units (e.g., "Lb" and "Kg")
      @multipliers: Numerical coefficients mapped to unit names. They adjust measurement values shown in the legend and display (e.g., 1.0 and 0.451 - if actual measurements are in Lb)
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: names is zero-length or contains duplicate or empty names -or- multipliers contains non-positive numbers, or its length is not equal to the length of names

--------------------------------------------------------------------------------

[CLASS] BuildingEnvelopeAnalyzer
Full Name: Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer
Description: Analyzes which elements are part of the building envelope, the building elements exposed to the outside.
Remarks: This class uses a combination of ray-casting and flood-fill algorithms in order to find the building elements that are exposed to the outside of the building. This method can also look for the bounding building elements for enclosed space volumes inside the building.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static BuildingEnvelopeAnalyzer Create(Document document, BuildingEnvelopeAnalyzerOptions options)
      Description: Creates a new analyzer.
      @document: The document that contains the physical model of the building.
      @options: Options for the method analyzing the building elements for the building envelope.
      Returns: The created analyzer.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    IList<LinkElementId> GetBoundingElements()
      Description: Returns the collection of building elements exposed to the outside forming the building envelope.
      Returns: The ids of the building elements in the envelope.
    IList<LinkElementId> GetBoundingElementsForSpaceVolume(int spaceVolume)
      Description: Returns the collection of bounding building elements for an enclosed space volume.
      Returns: The ids of the bounding building elements for the enclosed space volume.
    IList<XYZ> GetCenterPointsForConnectedGridCellsInSpaceVolume(int spaceVolume)
      Description: Returns the collection of connected cells in an enclosed space volume.
      Returns: The center points for the connected analytical grid cells in the enclosed space volume.

--------------------------------------------------------------------------------

[CLASS] BuildingEnvelopeAnalyzerOptions
Full Name: Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions
Description: Specific options for the method analyzing the building elements for the building envelope.
Remarks: The analyze method uses a combination of ray-casting and flood-fill algorithms in order to find the building elements that are exposed to the outside of the building. The analyze method can also look for the bounding building elements for enclosed space volumes inside the building.
Implements: IDisposable

  CONSTRUCTORS:
    new BuildingEnvelopeAnalyzerOptions()
      Description: Constructs a new instance of BuildingEnvelopeAnalyzerOptions, using default values.

  PROPERTIES:
    bool AnalyzeEnclosedSpaceVolumes { get; set; }
      Description: Whether or not to analyze interior connected regions inside the building forming enclosed space volumes.
    double GridCellSize { get; set; }
      Description: The cell size for the uniform cubical grid used when analyzing the building envelope.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool OptimizeGridCellSize { get; set; }
      Description: Whether or not to use the exact value for the cell size or let the analyzer optimize the cell size based on the specified grid size

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] BuildingOperatingDaySchedule
Full Name: Autodesk.Revit.DB.Analysis.BuildingOperatingDaySchedule
Description: Represents the operating schedule of a 24 hour day.
Inherits: Element

  PROPERTIES:
    string ScheduleName { get; set; }
      Description: The name of the schedule.

  METHODS:
    static BuildingOperatingDaySchedule Create(Document document, string name)
      Description: Creates a new instance of a BuildingOperatingDaySchedule.
      @document: The document to create the new BuildingOperatingDaySchedule element.
      @name: The intended name of the newly created BuildingOperatingDaySchedule, may be modified to disambiguate with existing element.
      Returns: The newly created BuildingOperatingDaySchedule.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name must be trimmed. -or- name is an empty string or contains only whitespace.
      Throws ArgumentNullException: A non-optional argument was null
    double GetValueForHour(int hour)
      Description: Gets the usage value for an hour.
      @hour: The hour in the day, as an integer. For example: 0 is 12:00 midnight to 1:00 am, 6 is 6:00 am to 7:00 am, 12 is 12:00 noon to 1:00 pm, and 23 is 11:00 pm to midnight. To avoid issues around daylight savings times, these hours represent 1/24 of an earth rotation, and will not be exactly 60 minutes.
      Returns: The usage as a fraction between 0 and 1 inclusive. For example: 0 in a lighting schedule means all lights are off, .5 means half of lights are on, 1 means all lights are on.
      Throws ArgumentException: hour must be from 0 to 23 inclusive.
    void SetValueForHour(int hour, double usage)
      Description: Sets the usage value for an hour.
      @hour: The hour in the day, as an integer. For example: 0 is 12:00 midnight to 1:00 am, 6 is 6:00 am to 7:00 am, 12 is 12:00 noon to 1:00 pm, and 23 is 11:00 pm to midnight. To avoid issues around daylight savings times, these hours represent 1/24 of an earth rotation, and will not be exactly 60 minutes.
      @usage: The usage as a fraction between 0 and 1 inclusive. For example: 0 in a lighting schedule means all lights are off, .5 means half of lights are on, 1 means all lights are on.
      Throws ArgumentException: hour must be from 0 to 23 inclusive. -or- usage should be less than or equal to 1.
      Throws ArgumentOutOfRangeException: The given value for usage must be non-negative.

--------------------------------------------------------------------------------

[CLASS] BuildingOperatingYearSchedule
Full Name: Autodesk.Revit.DB.Analysis.BuildingOperatingYearSchedule
Description: Represents an operating schedule that contains 365 daily usage BuildingOperatingDaySchedules.
Inherits: Element

  PROPERTIES:
    string ScheduleName { get; set; }
      Description: The name of the schedule.

  METHODS:
    static BuildingOperatingYearSchedule Create(Document document, BuildingOperatingDaySchedule daySchedule, string name)
      Description: Creates a valid BuildingOperatingYearSchedule with the given name, where every day has the schedule daySchedule.
      @document: The document to create this BuildingOperatingYearSchedule for.
      @daySchedule: A schedule to assign to every day.
      @name: The intended schedule name, may be modified to disambiguate with existing elements.
      Returns: The newly created BuildingOperatingYearSchedule.
      Throws ArgumentException: daySchedule must be in the same document. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name must be trimmed. -or- name is an empty string or contains only whitespace.
      Throws ArgumentNullException: A non-optional argument was null
    BuildingOperatingDaySchedule GetScheduleForDay(DateTime day)
      Description: Gets the BuildingOperatingDaySchedule for this day of the year.
      @day: The day of the year. The value must be in 2023 (the template year) and have the time zone set to gmt/utc. Time values will be ignored.
      Returns: The schedule used on that day.
      Throws ArgumentException: day must be in the year 2023.
    void SetScheduleForDay(DateTime day, BuildingOperatingDaySchedule daySchedule)
      Description: Sets the BuildingOperatingDaySchedule for this day of the year.
      @day: The day of the year. The value must be in 2023 (the template year) and have the time zone set to gmt/utc. Time values will be ignored.
      @daySchedule: The schedule used on that day.
      Throws ArgumentException: day must be in the year 2023. -or- daySchedule must be in the same document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionFloorSlabType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType
Description: ConceptualConstructionType values for Floors.
Inherits: Enum

  Values:
    - LightweightConstructionHighInsulation = 0
    - LightweightConstructionTypicalInsulation = 1
    - LightweightConstructionLowInsulation = 2
    - LightweightConstructionNoInsulationInterior = 3
    - HighMassConstructionFrigidClimateSlabInsulation = 4
    - HighMassConstructionColdClimateSlabInsulation = 5
    - HighMassConstructionTypicalNoInsulation = 6
    - NumFloorSlabTypeConstruction = 7
    - InvalidFloorSlabTypeConstruction = -1

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionOpeningType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType
Description: ConceptualConstructionType values for Openings.
Inherits: Enum

  Values:
    - Air = 0
    - NumOpeningTypeConstruction = 1
    - InvalidOpeningTypeConstruction = -1

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionRoofType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType
Description: ConceptualConstructionType values for Roofs.
Inherits: Enum

  Values:
    - HighInsulationCoolRoof = 0
    - HighInsulationDarkRoof = 1
    - TypicalInsulationCoolRoof = 2
    - TypicalInsulationDarkRoof = 3
    - LowInsulationCoolRoof = 4
    - LowInsulationDarkRoof = 5
    - NoInsulationDarkRoof = 6
    - NumRoofTypeConstruction = 7
    - InvalidRoofTypeConstruction = -1

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionShadeType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType
Description: ConceptualConstructionType values for Shades.
Inherits: Enum

  Values:
    - BasicShade = 0
    - NumShadeTypeConstruction = 1
    - InvalidShadeTypeConstruction = -1

--------------------------------------------------------------------------------

[CLASS] ConceptualConstructionType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionType
Description: This element is used to describe the conceptual physical, construction, and energy properties in a manner that can be understood by both the Revit BIM model and Green Building Studio/Green Building XML. For serialization
Inherits: ElementType

  PROPERTIES:
    ElementId MassSurfaceSubCategoryId { get; }
      Description: The surface type subcategory element id associated with the ConceptualConstructionType.
    ElementId MaterialId { get; set; }
      Description: Material used for visualization of this construction.

  METHODS:
    static ICollection<ElementId> GetAllConceptualConstructionsForCategory(Document ccda, ElementId massSubCategoryId)
      Description: Get all the ids of constructions applicable to the input massSubCategory
      @ccda: The document.
      @massSubCategoryId: The ElementId of the mass subcategory.
      Returns: Returns a set of ElementIds that for the ConceptualConstructionTypes that are appropriate for the subcategory.
      Throws ArgumentException: The mass sub-category is none of the OST_MassInteriorWall, OST_MassExteriorWall, OST_MassExteriorWallUnderground, OST_MassWallsAll, OST_MassRoof, OST_MassFloor, OST_MassSlab, OST_MassFloorsAll, OST_MassShade, OST_MassGlazing, OST_MassSkylights, OST_MassGlazingAll or OST_MassOpening.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetFloorOrSlabConstructionType(Document ccda, ConceptualConstructionFloorSlabType typeEnum)
      Description: Get a Floor or Slab ConceptualConstructionType by its ConceptualConstructionFloorSlabType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionFloorSlabType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The enum is invalid for ConceptualConstructionFloorSlabType. -or- A value passed for an enumeration argument is not a member of that enumeration
    int GetGBSId(ElementId massSurfaceSubCategoryId)
      Description: Gets the Green Building Studio identifier associated with the construction.
      @massSurfaceSubCategoryId: The ElementId of a valid Mass subcategory of a MassSurfaceData.
      Returns: Returns the integer id used to represent the ConceptualConstructionType.
      Throws ArgumentException: The input Element massSurfaceSubCategoryId is not a valid subcategory value for MassSurfaceData. -or- The ElementId massSurfaceSubCategoryId is not appropriate for this ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetOpeningConstructionType(Document ccda, ConceptualConstructionOpeningType typeEnum)
      Description: Get an Opening ConceptualConstructionType by its ConceptualConstructionOpeningType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionOpeningType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The enum is invalid for ConceptualConstructionOpeningType. -or- A value passed for an enumeration argument is not a member of that enumeration
    static ElementId GetRoofConstructionType(Document ccda, ConceptualConstructionRoofType typeEnum)
      Description: Get a Roof ConceptualConstructionType by its ConceptualConstructionRoofType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionRoofType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The enum is invalid for ConceptualConstructionRoofType. -or- A value passed for an enumeration argument is not a member of that enumeration
    static ElementId GetShadeConstructionType(Document ccda, ConceptualConstructionShadeType typeEnum)
      Description: Get a Shade ConceptualConstructionType by its ConceptualConstructionShadeType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionShadeType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The enum is invalid for ConceptualConstructionShadeType. -or- A value passed for an enumeration argument is not a member of that enumeration
    static ElementId GetWallConstructionType(Document ccda, ConceptualConstructionWallType typeEnum)
      Description: Get a Wall ConceptualConstructionType by its ConceptualConstructionWallType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionWallType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The enum is invalid for ConceptualConstructionWallType. -or- A value passed for an enumeration argument is not a member of that enumeration
    static ElementId GetWindowOrSkylightConstructionType(Document ccda, ConceptualConstructionWindowSkylightType typeEnum)
      Description: Get a Window or Skylight ConceptualConstructionType by its ConceptualConstructionWindowSkylightType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionWindowSkylightType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The enum is invalid for ConceptualConstructionWindowSkylightType. -or- A value passed for an enumeration argument is not a member of that enumeration
    static bool IsValidConceptualConstructionId(Document ccda, ElementId constructionTypeId)
      Description: Indicates if the ElementId is an id of a ConceptualConstructionType.
      @ccda: The document.
      @constructionTypeId: The ElementId of the ConceptualConstructionType.
      Returns: Returns true if is an id of a ConceptualConstructionType, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidConceptualConstructionIdForCategory(Document ccda, ElementId constructionTypeId, ElementId massSubcategoryId)
      Description: Indicate if a ConceptualConstruction is appropriate to assign to a MassSurfaceData of a particular Mass subcategory.
      @ccda: The document.
      @constructionTypeId: The ElementId of the ConceptualConstructionType.
      @massSubcategoryId: The ElementId of the Mass subcategory.
      Returns: Returns true if valid, false otherwise
      Throws ArgumentException: The ElementId constructionTypeId is not an id of a ConceptualConstructionType. -or- The mass sub-category is none of the OST_MassInteriorWall, OST_MassExteriorWall, OST_MassExteriorWallUnderground, OST_MassWallsAll, OST_MassRoof, OST_MassFloor, OST_MassSlab, OST_MassFloorsAll, OST_MassShade, OST_MassGlazing, OST_MassSkylights, OST_MassGlazingAll or OST_MassOpening.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidSubcategoryForMassSurfaceDatas(ElementId massSubCategoryId)
      Description: Validate if a subcategory is appropriate for assignment to Massing surfaces (MassSurfaceData). This is the list of acceptable values: OST_MassInteriorWallOST_MassExteriorWallOST_MassExteriorWallUndergroundOST_MassRoofOST_MassFloorOST_MassSlabOST_MassShadeOST_MassGlazingOST_MassSkylightsOST_MassOpening
      @massSubCategoryId: The mass sub-category to be checked.
      Returns: True if the mass sub-category falls within the list, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidSurfaceSubcategoryForConstruction(ElementId massSurfaceSubcategoryId)
      Description: Indicates if this ConceptualConstructionType is appropriate for the input MassSurfaceData subcategory.
      @massSurfaceSubcategoryId: The ElementId of a Mass subcategory of a MassSurfaceData.
      Returns: Returns true if appropriate for the input subcategory, false otherwise.
      Throws ArgumentException: The input Element massSurfaceSubcategoryId is not a valid subcategory value for MassSurfaceData.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionWallType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType
Description: ConceptualConstructionType values for Walls.
Inherits: Enum

  Values:
    - LightweightConstructionHighInsulation = 0
    - LightweightConstructionTypicalColdClimateInsulation = 1
    - LightweightConstructionTypicalMildClimateInsulation = 2
    - LightweightConstructionLowInsulation = 3
    - LightweightConstructionNoInsulationInterior = 4
    - HighMassConstructionHighInsulation = 5
    - HighMassConstructionTypicalColdClimateInsulation = 6
    - HighMassConstructionTypicalMildClimateInsulation = 7
    - HighMassConstructionNoInsulationInterior = 8
    - NumWallTypeConstruction = 9
    - InvalidExteriorWallTypeConstruction = -1

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionWindowSkylightType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType
Description: ConceptualConstructionType values for Windows and Skylights
Inherits: Enum

  Values:
    - SinglePaneClearNoCoating = 0
    - SinglePaneTinted = 1
    - SinglePaneReflective = 2
    - DoublePaneClearNoCoating = 3
    - DoublePaneTinted = 4
    - DoublePaneReflective = 5
    - DoublePaneClearLowEColdClimateHighSHGC = 6
    - DoublePaneClearLowEHotClimateLowSHGC = 7
    - DoublePaneClearHighestPerformanceLowEHighVisTransLowSHGC = 8
    - TriplePaneClearLowEHotOrColdClimate = 9
    - QuadPaneClearLowEHotOrColdClimate = 10
    - NumWindowSkylightTypeConstruction = 11
    - InvalidWindowSkylightTypeConstruction = -1

--------------------------------------------------------------------------------

[CLASS] ConceptualSurfaceType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualSurfaceType
Description: This element represents a conceptual BIM object category to assign to faces in Mass geometries. There is one ConceptualSurfaceType element for each of the Mass Surface Subcategories. for serialization
Remarks: When Conceptual Energy Analysis is enabled in Revit Projects, massing faces will be assigned to the subcategories of Mass category that these ConceptualSurfaceType's are associated with. A default ConceptualConstructionType is associated with the ConceptualSurfaceType. This default ConceptualConstructionType is assigned to Mass faces with the corresponding subcategory. Changing the default ConceptualConstructionType associated with the ConceptualSurfaceType will update the ConceptualConstruction type for all Mass faces of that subcategory which the user has not specifically provided an override value for.
Inherits: Element

  PROPERTIES:
    ElementId DefaultConstructionTypeId { get; set; }
      Description: The element id of the user specified ConceptualConstructionType to be used by default on creation for mass faces of this mass subcategory.
    ElementId MassSubCategoryId { get; }
      Description: The mass subcategory id of the ConceptualSurfaceType.

  METHODS:
    static IList<ElementId> GetAllMassSubCategoryIds()
      Description: Get all the mass subcategory ids for which there are ConceptualSurfaceType's.
      Returns: Returns an array of element id of mass subcategories for which there are ConceptualSurfaceType's.
    static ConceptualSurfaceType GetByMassSubCategoryId(Document cda, ElementId massSubCategoryId)
      Description: Get the ConceptualSurfaceType by its mass subcategory id.
      @cda: The document.
      @massSubCategoryId: The mass subcategory id to get the ConceptualSurfaceType for.
      Returns: Returns ConceptualSurfaceType associated with input id or NULL.
      Throws ArgumentException: The mass sub-category is none of the OST_MassInteriorWall, OST_MassExteriorWall, OST_MassExteriorWallUnderground, OST_MassRoof, OST_MassFloor, OST_MassSlab, OST_MassShade, OST_MassGlazing, OST_MassSkylights, or OST_MassOpening.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<ElementId> GetConstructionTypeIds()
      Description: The element ids of the ConceptualConstructionType's associated with this ConceptualSurfaceType.

--------------------------------------------------------------------------------

[ENUM] ConstructionType
Full Name: Autodesk.Revit.DB.Analysis.ConstructionType
Description: This enumeration specifies the available analytical construction types like external walls, windows etc. for use in the detailed analytical energy model.
Inherits: Enum

  Values:
    - ExteriorWall = 0
    - InteriorWall = 1
    - Slab = 2
    - Roof = 3
    - Ceiling = 4
    - Floor = 5
    - Door = 6
    - ExteriorWindow = 7
    - InteriorWindow = 8
    - Skylight = 9
    - UndergroundWall = 10

--------------------------------------------------------------------------------

[CLASS] CriticalPathCollector
Full Name: Autodesk.Revit.DB.Analysis.CriticalPathCollector
Description: This class is used to search and traverse the network analytical segments on the critical path.
Remarks: The critcal path is a connected flow path that has the maximum pressure loss value on the network. The associated flow and pressure loss values are often used to select the equipment size. When this collector is constructed, the network is identified by one analytical segment seed. User may get the CriticalPathIterator from the collector to traverse the analytical segment on the critical path, in the sequence of their flow direction. Note that If the network contains multiple hydraulically separated levels, the critical path traversal is focused on the same hydraulic separation level as the seed segment.
Implements: IEnumerable<MEPNetworkSegmentId>, IEnumerable, IDisposable

  CONSTRUCTORS:
    new CriticalPathCollector(Document doc, MEPNetworkSegmentId segmentId)
      Description: Creates a new CriticalPathCollector that visits the analytical segments on the network critical path.
      @doc: The document of the analytical network.
      @segmentId: The analytical segment to identify the network. Note that this segment is not required to be on the critical path.
      Throws ArgumentException: The network segment id is invalid.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    double GetCalculatedFlow()
      Description: Gets the calculated flow of the network.
      Returns: The flow value in the internal Revit unit ft^3/second.
    double GetCalculatedPressureDrop()
      Description: Gets the calculated pressure drop of the network.
      Returns: The pressure drop value in the internal Revit unit kg/(ft*s^2).
    CriticalPathIterator GetCriticalPathCollectorIterator()
      Description: Gets the critical path iterator to traverse individual segment.
      Returns: The iterator that traverses the critical path.
    IEnumerator<MEPNetworkSegmentId> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    IList<MEPNetworkSegmentId> ToNetworkSegmentIds()
      Description: Returns the list of analytical segment ids on the network critical path.
      Returns: The array of all analytical segment ids on the critical path.

--------------------------------------------------------------------------------

[CLASS] CriticalPathIterator
Full Name: Autodesk.Revit.DB.Analysis.CriticalPathIterator
Description: An iterator to traverse the critical path in the CriticalPathCollector.
Implements: IEnumerator<MEPNetworkSegmentId>, IDisposable, IEnumerator

  PROPERTIES:
    MEPNetworkSegmentId Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    MEPNetworkSegmentId GetCurrent()
      Description: Gets the analytical segment id at the current iterating position.
      Returns: The segment id of the current iterating position.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if all segments have been visited on the critical path. False if there are more segments to be visited.
    bool MoveNext()
      Description: Increments the iterator to the next downstream segment on the critical path.
      Returns: True if there is another segment available on the critical path that is not visited by this iterator, False if there is no next segment left.
    void Reset()
      Description: Resets the iterator to the beginning segment.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisConstruction
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction
Description: Represent an analytical construction as a composite of layered materials.
Inherits: Element

  PROPERTIES:
    double Absorptance { get; }
      Description: The absorptance value of the construction.
    string ConstructionName { get; }
      Description: The name of the construction
    string Description { get; }
      Description: The description of the construction.
    double HeatTransferCoefficient { get; }
      Description: The heat transfer coefficient value (U-value) of the construction, in W/(m^2*K) (equivalent to kg/(k*s^3)).
    bool IsSchematic { get; }
      Description: Indicates if this originates from a schematic or analytical construction.
    int Roughness { get; }
      Description: The roughness value of the construction, from 1 (Very Rough) to 6 (Very Smooth) and -1 when unset.
    double ThermalMass { get; }
      Description: The thermal mass value (Cth-value) of the construction, in J/(m^2*k) (equivalent to kg/(k*s^2)).
    double ThermalResistance { get; }
      Description: The thermal resistance value (R-value) of the construction, in K*s^3/kg.

  METHODS:
    IList<ElementId> GetMaterialIds()
      Description: Returns a list of ids of the associated materials to analytical construction.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisDetailModel
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel
Description: Manage the analytical thermal model.
Remarks: The Export to gbXML and the Heating and Cooling Loads features produces an analytical thermal model from the physical model of a building. The analytical thermal model is composed of spaces, zones and planar surfaces that represent the actual volumetric elements of the building. If there are currently no EnergyAnalysisDetailModel elements in the document, when the first one is generated it will be considered the persistent energy model (and maybe removed and recreated by actions the user takes in the UI). If there is already a persistent EnergyAnalysisDetailModel element in the document, the API can generate other independent energy models, but they will not be affected by the actions the user takes in the UI. The EnergyAnalysisDetailModel will remain in the document until it is discarded (either by the actions of the user, or by a call to Document.Delete() ).
Inherits: Element

  PROPERTIES:
    ElementId BuildingTypeId { get; set; }
      Description: The building type element.
    ElementId ExportCategory { get; set; }
      Description: Export elements of this category in energy analysis.
    bool ExportMullions { get; }
      Description: Indicates if to specify the setting for exporting mullions.
    bool IncludeShadingSurfaces { get; }
      Description: Indicates if to set and get the setting for if shading surfaces should be included.
    bool SimplifyCurtainSystems { get; }
      Description: Indicates if to specify the setting for simplified curtain systems.
    EnergyAnalysisDetailModelTier Tier { get; }
      Description: Level of computation for energy analysis model.

  METHODS:
    static EnergyAnalysisDetailModel Create(Document document, EnergyAnalysisDetailModelOptions options)
      Description: Creates a new energy analysis detailed model.
      @document: The document that contains the physical model of the building.
      @options: The options to control the calculation rules.
      Returns: The created model instance.
      Throws ArgumentException: An EnergyAnalysisDetailModel cannot be created if EnergyModelType.BuildingElement is input and AnalysisMode.ConceptualMasses is set in EnergyDataSettings (these values are incompatible). -or- Throws if there are no valid spatial bounding elements, or no valid spatial elements in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the energy analysis detail model.
      Throws OperationCanceledException: Throws if user aborted the energy analysis detail model creation.
    IList<EnergyAnalysisOpening> GetAnalyticalOpenings()
      Description: The collection of analytical openings.
      Returns: Returns the analytical openings after model calculation.
    IList<EnergyAnalysisSurface> GetAnalyticalShadingSurfaces()
      Description: The collection of analytical shading surfaces.
      Returns: Returns the analytical shading surfaces after model calculation.
    IList<EnergyAnalysisSpace> GetAnalyticalSpaces()
      Description: The collection of analytical spaces.
      Returns: Returns the analytical spaces after model calculation.
    IList<EnergyAnalysisSurface> GetAnalyticalSurfaces()
      Description: The collection of analytical surfaces.
      Returns: Returns the analytical surfaces after model calculation.
    static EnergyAnalysisDetailModel GetMainEnergyAnalysisDetailModel(Document document)
      Description: Gets the EnergyAnalysisDetailModel in given document.
      @document: The document that contains the physical model of the building.
      Returns: Returns the EnergyAnalysisDetailModel contained in the document, if it exists. If it does not exist, this returns .
      Throws ArgumentNullException: A non-optional argument was null
    void TransformModel()
      Description: Transforms all surfaces in the model according to the document's active ground plane, shared coordinates and true north.
      Throws InvalidOperationException: This operation failed.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisDetailModelOptions
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions
Description: Options that govern the calculations for the generation of the energy analysis detail model.
Implements: IDisposable

  CONSTRUCTORS:
    new EnergyAnalysisDetailModelOptions()
      Description: Constructs default options for energy analysis detailed model creation.

  PROPERTIES:
    EnergyModelType EnergyModelType { get; set; }
      Description: It indicates whether the energy model is based on rooms/spaces or building elements.
    bool ExportMullions { get; set; }
      Description: Indicates if to specify the setting for exporting mullions.
    bool IncludeShadingSurfaces { get; set; }
      Description: Indicates if to set and get the setting for if shading surfaces should be included.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool SimplifyCurtainSystems { get; set; }
      Description: Indicates if to specify the setting for simplified curtain systems.
    EnergyAnalysisDetailModelTier Tier { get; set; }
      Description: Level of computation for energy analysis model.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] EnergyAnalysisDetailModelTier
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier
Description: Level of computation for energy analysis model.
Inherits: Enum

  Values:
    - NotComputed = 0
    - FirstLevelBoundaries = 1
    - SecondLevelBoundaries = 2
    - Final = 3

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisMaterial
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial
Description: A description of a material with thermal properties in a composite construction.
Inherits: Element

  PROPERTIES:
    double Density { get; }
      Description: The density of the material, in kg/(ft^3).
    string Description { get; }
      Description: The description of the material.
    string MaterialName { get; }
      Description: The name of the material.
    double SpecificHeatCapacity { get; }
      Description: The specific heat capacity of the material, in ft^2/(k*s^2).
    double ThermalConductivity { get; }
      Description: The thermal conductivity of the material, kg*ft/(k*s^3).
    double ThermalResistance { get; }
      Description: The thermal resistance (R-value) of the material, in m^2*K/W (eqivelent to K*s^3/kg).
    double Thickness { get; }
      Description: The thickness of the material, in ft.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisOpening
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening
Description: Analytical opening.
Inherits: Element

  PROPERTIES:
    string CADLinkUniqueId { get; }
      Description: The unique id of the originating CAD object's link (linked document) associated with this opening.
    string CADObjectUniqueId { get; }
      Description: The unique id of the originating CAD object (model element) associated with this opening.
    XYZ Corner { get; }
      Description: The lower-left coordinate for the analytical rectangular geometry viewed from outside.
    double Height { get; }
      Description: The height of the analytical rectangular geometry.
    string OpeningId { get; }
      Description: The unique identifier for the opening.
    string OpeningName { get; }
      Description: The unique name identifier for the opening.
    EnergyAnalysisOpeningType OpeningType { get; }
      Description: The analytical opening type.
    string OriginatingElementDescription { get; }
      Description: The description for the originating Revit element.
    LinkElementId OriginatingElementId { get; }
      Description: The element id for the originating Revit element.
    string OriginatingElementName { get; }
      Description: The name for the originating Revit element.
    gbXMLOpeningType Type { get; }
      Description: The gbXML opening type attribute.
    double Width { get; }
      Description: The width of the analytical rectangular geometry.

  METHODS:
    EnergyAnalysisSurface GetAnalyticalSurface()
      Description: Gets the associative analytical parent surface element.
      Returns: The associative analytical parent surface element.
    EnergyAnalysisConstruction GetConstruction()
      Description: Gets the analytic construction this surface is associated with. Null when this surface is a window.
      Returns: The analytic construction.
    Polyloop GetPolyloop()
      Description: Gets the planar polygon describing the opening geometry.
    IList<Polyloop> GetPolyloops()
      Description: Gets the collection of planar polygons describing the opening geometry.
      Returns: The collection of polygons describing the opening geometry.
    EnergyAnalysisWindowType GetWindowType()
      Description: Gets the analytic window type this surface is associated with. Null when this surface is not a window.
      Returns: The analytic window type.

--------------------------------------------------------------------------------

[ENUM] EnergyAnalysisOpeningType
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType
Description: Energy analysis opening type.
Inherits: Enum

  Values:
    - Door = 0
    - Window = 1
    - Skylight = 2
    - Air = 3

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisSpace
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace
Description: Analytical space.
Inherits: Element

  PROPERTIES:
    double Area { get; }
      Description: The area for this space.
    string CADObjectUniqueId { get; }
      Description: The unique id of the originating CAD object (model element) associated with this space.
    string ComposedName { get; }
      Description: The composed name for this space.
    string Description { get; }
      Description: The description.
    string Number { get; }
      Description: The number to identify the space.
    string SpaceName { get; }
      Description: The name.
    double Volume { get; }
      Description: The volume for this space.

  METHODS:
    IList<EnergyAnalysisSurface> GetAnalyticalSurfaces()
      Description: Provides a way to access the collection of analytical surfaces for a space. Geometry data defining an analytical space volume. Through an analytical surface you can connect a source element with each polygon in a space. The analytical surfaces defines an enclosed volume bounded by the center plane of walls and the top plane of roofs and floors.
      Returns: the collection of analytical surfaces for a space.
    IList<Polyloop> GetBoundary()
      Description: Gets the collection of polygons that form the 2D boundary. This method returns a collection of polyloops (planar polygons) that defines an enclosed area measured by interior bounding surfaces.
      Returns: The collection of polygons that form the 2D boundary.
    IList<Polyloop> GetClosedShell()
      Description: Gets the collection of polygons that form a closed shell. This method returns a collection of polyloops (planar polygons) that defines an enclosed volume measured by interior bounding surfaces.
      Returns: the collection of polygons that form a closed shell.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisSurface
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface
Description: Analytical surface. The collection of analytic openings belonging to this analytical parent surface
Inherits: Element

  PROPERTIES:
    double Azimuth { get; }
      Description: The azimuth angle for this surface.
    string CADLinkUniqueId { get; }
      Description: The unique id of the originating CAD object's link (linked document) associated with this surface.
    string CADObjectUniqueId { get; }
      Description: The unique id of the originating CAD object (model element) associated with this surface.
    XYZ Corner { get; }
      Description: The lower-left coordinate for the analytical rectangular geometry viewed from outside.
    double Height { get; }
      Description: The height of the analytical rectangular geometry.
    XYZ Normal { get; }
      Description: The outward normal for this surface.
    string OriginatingElementDescription { get; }
      Description: The description for the originating Revit element.
    LinkElementId OriginatingElementId { get; }
      Description: The element id for the originating Revit element.
    string OriginatingElementName { get; }
      Description: The name for the originating Revit element.
    string SurfaceId { get; }
      Description: The unique identifier for the surface.
    string SurfaceName { get; }
      Description: The unique name identifier for this surface.
    EnergyAnalysisSurfaceType SurfaceType { get; }
      Description: The analytical surface type.
    double Tilt { get; }
      Description: The tilt angle for this surface.
    gbXMLSurfaceType Type { get; }
      Description: The gbXML surface type attribute.
    double Width { get; }
      Description: The width of the analytical rectangular geometry.

  METHODS:
    EnergyAnalysisSpace GetAdjacentAnalyticalSpace()
      Description: Gets the secondary adjacent analytical space this surface is associated with.
      Returns: The secondary analytical space.
    IList<EnergyAnalysisOpening> GetAnalyticalOpenings()
      Description: Returns the analytical openings of the analytical surface.
      Returns: The collection of analytical openings.
    EnergyAnalysisSpace GetAnalyticalSpace()
      Description: Gets the primary analytical space this surface is associated with.
      Returns: The primary analytical space.
    EnergyAnalysisConstruction GetConstruction()
      Description: Gets the analytic construction this surface is associated with.
      Returns: The analytic construction.
    Polyloop GetPolyloop()
      Description: Gets the planar polygon describing the surface geometry.
      Returns: The planar polygon describing the surface geometry.
    IList<Polyloop> GetPolyloops()
      Description: Gets the collection of planar polygons describing the surface geometry.
      Returns: The collection of polygons describing the surface geometry.

--------------------------------------------------------------------------------

[ENUM] EnergyAnalysisSurfaceType
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType
Description: Analytical surface types.
Inherits: Enum

  Values:
    - Roof = 0
    - ExteriorWall = 1
    - InteriorWall = 2
    - Ceiling = 3
    - InteriorFloor = 4
    - ExteriorFloor = 5
    - Shading = 6
    - Air = 7
    - Underground = 8

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisWindowType
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType
Description: The EnergyAnalysisWindowType class contains the thermal properties (e.g., heat transfer coefficient) of the window-type analytical openings.
Inherits: Element

  PROPERTIES:
    string Description { get; }
      Description: The description of the window type.
    double HeatTransferCoefficient { get; }
      Description: The heat transfer coefficient value (U-value) of the window type, in W/(m^2*K) (equivalent to kg/(k*s^3)).
    bool IsSchematic { get; }
      Description: Indicates if this originates from a schematic or analytical construction.
    double SolarHeatGainCoefficient { get; }
      Description: The solar heat gain coefficient (SHGC-value) for the window type, from 0.0 to 1.0.
    double Transmittance { get; }
      Description: The visual light transmittance value (VLT-value) for the window type, from 0.0 to 1.0.
    string WindowTypeName { get; }
      Description: The name of the window type.

  METHODS:
    IDictionary<double, double> GetSolarHeatGainCoefficientsForSolarIndicientAngles()
      Description: Returns a map with solar heat gain coefficients (SHGC-values) for specific incident angles for the window type.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisZone
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisZone
Description: Analytical zone.
Inherits: Element

--------------------------------------------------------------------------------

[CLASS] EnergyDataSettings
Full Name: Autodesk.Revit.DB.Analysis.EnergyDataSettings
Description: This element contains settings for gbXML Export and Heating and Cooling Load Calculations and project level settings for Conceptual Energy Analysis. for serialization
Inherits: Element

  PROPERTIES:
    AnalysisMode AnalysisType { get; set; }
      Description: The type of analysis mode.
    double AnalyticalGridCellSize { get; set; }
      Description: The cell size for the uniform cubical grid used when computing the building envelope
    HVACLoadConstructionClass BuildingConstructionClass { get; set; }
      Description: Used for both the detailed and conceptual energy model Construction class of building as defined by: loose, medium, tight, or none.
    gbXMLExportBuildingEnvelope BuildingEnvelopeDeterminationMethod { get; set; }
      Description: Indicates if an analysis should be perform to find the model elements that are part of the building envelope
    gbXMLBuildingHVACSystem BuildingHVACSystem { get; set; }
      Description: The type of HVAC system used by the building for conceptual model energy calculations.
    gbXMLBuildingOperatingSchedule BuildingOperatingSchedule { get; set; }
      Description: The operating schedule of the building used for conceptual model energy calculations.
    gbXMLBuildingType BuildingType { get; set; }
      Description: The type of building.
    ElementId BuildingTypeId { get; set; }
      Description: The building type element.
    double CoreOffset { get; set; }
      Description: The default offset used to determine the outer perimeter to be divided into zones.
    bool CreateAnalyticalModel { get; }
      Description: If this is true, data, features, and geometry related to the Energy Analytical Model will be created, allowing the energy performance to be analyzed through GreenBuilidingXML.
    bool DividePerimeter { get; set; }
      Description: If this is true, zones with exterior boundaries on each floor of the building will be divided based on geometric criteria.
    bool EnergyModel { get; set; }
      Description: if this is on there should be an energy model dependent on the current AnalysisType if it is off the conceptual energy model should be turned off but setting this datum does not do the work, just reflects the state.
    ElementId ExportCategory { get; set; }
      Description: Value is a category indicating which discipline model will be used for GreenBuildingXML export.
    gbXMLExportComplexity ExportComplexity { get; set; }
      Description: Value determines Export Complexity for GreenBuildingXML detailed model export.
    bool ExportDefaults { get; set; }
      Description: Use for detailed model GreenBuildingXML export. When this setting is true, all building and space defaults, schedules, and constructions will be exported to GreenBuildingXML. When this setting is false, only values that are specified on the zone or space will be exported to GreenBuildingXML.
    ElementId GroundPlane { get; set; }
      Description: Id of level which represents ground level.
    bool IncludeThermalProperties { get; set; }
      Description: Indicates if thermal information from model assemblies and components is included in GreenBuildingXML export of the detailed model.
    bool IsExportMullionsEnabled { get; }
      Description: Indicates if mullions are included in GreenBuildingXML export of the detailed model.
    bool IsExportShadingSurfacesEnabled { get; }
      Description: Indicates if "shading surfaces" are included in GreenBuildingXML export of the detailed model.
    bool IsExportSimplifiedCurtainSystemsEnabled { get; }
      Description: Indicates if curtain system geometry is being simplified for GreenBuildingXML export of the detailed model.
    bool IsGlazingShaded { get; set; }
      Description: If this is true, glazing/windows that are auto-created on exterior walls will automatically have a shading device created on their top edge.
    double OutsideAirChangesRatePerHour { get; set; }
      Description: The number of times the volume of air interchanges in the room in one hour.
    double OutsideAirPerArea { get; set; }
      Description: The rate of flow of outside air available per unit area.
    double OutsideAirPerPerson { get; set; }
      Description: The rate of flow of outside air available per person.
    double PercentageGlazing { get; set; }
      Description: Used for the conceptual energy model. The approximate percentage of the building exterior wall surfaces which are covered by windows or other glazing.
    double PercentageSkylights { get; set; }
      Description: Used for the conceptual energy model. The approximate percentage of the building roof surfaces in massing instances for the Conceptual Energy Analytical Model.
    ElementId ProjectPhase { get; set; }
      Description: The project phase of the EnergyData information.
    HVACLoadLoadsReportType ProjectReportType { get; set; }
      Description: Report type: None, simple, standard, detailed
    string ReportsFolder { get; }
      Description: The folder path where all systems analysis reports are stored. It may include special label and relative path.
    gbXMLServiceType ServiceType { get; set; }
      Description: The type of heating or cooling system.
    double ShadeDepth { get; set; }
      Description: Used for the conceptual energy model. Amount that auto-generated shading will extend from auto-generated windows.
    double SillHeight { get; set; }
      Description: Used for the conceptual energy model. The height from the nearest lower level used for auto-glazing created on walls.
    double SkylightWidth { get; set; }
      Description: Used for the conceptual energy model. The approximate width used for the skylights in massing instances when the Energy Analytical model is being created.
    double SliverSpaceTolerance { get; set; }
      Description: Used for Detailed GreenBuildingXML export. This value is used to identify sliver spaces, i.e. spaces bounded by parallel surfaces belonging to different rooms.
    bool UseAirChangesPerHour { get; set; }
      Description: True if user is specifying air changes per hour, false otherwise.
    bool UseCurrentViewOnly { get; set; }
      Description: True if only elements visible in the currently active view are used for generation of Energy Model.
    bool UseHeatingCredits { get; set; }
      Description: If true, Revit will use heating credits in the final load sum calculations. If false, Revit will ignore heating credits in the final load sum calculations.
    bool UseOutsideAirPerArea { get; set; }
      Description: True is user is specifying outside air per area, false otherwise.
    bool UseOutsideAirPerPerson { get; set; }
      Description: True if user is specifying outside air per person, false otherwise.

  METHODS:
    static bool CheckAnalysisType(AnalysisMode analysisType)
      Description: Checks that the analysis type falls within an appropriate range.
      @analysisType: The analysis type to be checked.
      Returns: True if the analysis type falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckBuildingConstructionClass(HVACLoadConstructionClass buildingConstructionClass)
      Description: Checks that the building construction class falls within an appropriate range.
      @buildingConstructionClass: The building construction class to be checked.
      Returns: True if the building construction class falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckBuildingEnvelope(gbXMLExportBuildingEnvelope determinationMethod)
      Description: Checks that the building envelope determination method falls within an appropriate range.
      @determinationMethod: The building envelope determination method to be checked.
      Returns: True if the building envelope determination method falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckBuildingHVACSystem(gbXMLBuildingHVACSystem buildingHVACSystem)
      Description: Checks that the building HVAC system falls within an appropriate range.
      @buildingHVACSystem: The building HVAC system to be checked.
      Returns: True if the building HVAC system falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckBuildingOperatingSchedule(gbXMLBuildingOperatingSchedule buildingOperatingSchedule)
      Description: Checks that the building operating schedule falls within an appropriate range.
      @buildingOperatingSchedule: The building operating schedule to be checked.
      Returns: True if the building operating schedule falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckBuildingType(gbXMLBuildingType buildingType)
      Description: Checks that the building type falls within an appropriate range.
      @buildingType: The building type to be checked.
      Returns: True if the building type falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool CheckConstructionSetElement(ElementId constructionSetElementId)
      Description: Checks that the construction set ElementId is acceptable.
      @constructionSetElementId: The construction set ElementId to be checked.
      Returns: True if the construction set ElementId is a valid construction set element, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CheckExportCategory(ElementId exportCategoryId)
      Description: Checks whether the export category falls within the list: OST_RoomsOST_MEPSpaces
      @exportCategoryId: The export category to be checked.
      Returns: True if the export category falls within the list, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CheckExportComplexity(gbXMLExportComplexity exportComplexity)
      Description: Checks that the export complexity falls within an appropriate range.
      @exportComplexity: The export complexity to be checked.
      Returns: True if the export complexity falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckGroundPlane(Document ccda, ElementId groundPlaneId)
      Description: The ground plane should be an Element of type Level. This method checks to confirm that an ElementId is for a Level element.
      @ccda: The Document.
      @groundPlaneId: The element id to be checked to confirm that it is suitable to be a ground plane (i.e., that it is a level) or that it is invalidElementId. Setting ground plane with invalidElementId will lead to the ground plane being "reset".
      Returns: True if the input element is a level or invalidElementId, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CheckGroundPlane(ElementId groundPlaneId)
      Description: The ground plane should be an Element of type Level. This method checks to confirm that an ElementId is for a Level element.
      @groundPlaneId: The element id to be checked to confirm that it is suitable to be a ground plane (i.e., that it is a level) or that it is invalidElementId. Setting ground plane with invalidElementId will lead to the ground plane being "reset".
      Returns: True if the input element is a level or invalidElementId, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CheckProjectPhase(ElementId projectPhaseId)
      Description: Checks that the input element is a project phase.
      @projectPhaseId: The element to be checked.
      Returns: True if the input element is a project phase, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CheckProjectReportType(HVACLoadLoadsReportType projectReportType)
      Description: Checks that the project report type falls within an appropriate range.
      @projectReportType: The project report type to be checked.
      Returns: True if the project report type falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CheckRangeOfPercentageGlazing(double percentageGlazing)
      Description: Checks that the percentage glazing value is between 0.00 and 0.95.
      @percentageGlazing: The percentage glazing to be checked.
      Returns: True if the percentage glazing value is between 0.00 and 0.95, false otherwise.
    static bool CheckRangeOfPercentageSkylights(double percentageSkylights)
      Description: Checks that the percentage skylights value is between 0.00 and 0.95.
      @percentageSkylights: The percentage skylights to be checked.
      Returns: True if the percentage skylights value is between 0.00 and 0.95, false otherwise.
    static bool CheckRangeOfShadeDepth(double shadeDepth)
      Description: Checks that the shade depth is greater than or equal to zero.
      @shadeDepth: The shade depth to be checked.
      Returns: True if the shade depth is greater than or equal to zero, false otherwise.
    static bool CheckRangeOfSillHeight(double sillHeight)
      Description: Checks that the sill height is greater than or equal to zero.
      @sillHeight: The sill height to be checked.
      Returns: True if the sill height falls is greater than or equal to zero, false otherwise.
    static bool CheckRangeOfSkylightWidth(double skylightWidth)
      Description: Checks that the skylight width is greater than or equal to eight inches.
      @skylightWidth: The skylight width to be checked. Should be greater than or equal to eight inches.
      Returns: True if the skylight width is greater than or equal to eight inches, false otherwise.
    static bool CheckRangeOfSliverSpaceTolerance(double silverSpaceTolerance)
      Description: Checks that the sliver space tolerance is greater than or equal to zero.
      @silverSpaceTolerance: The sliver space tolerance to be checked.
      Returns: Returns true if the sliver space tolerance is greater than or equal to zero, false otherwise.
    static bool CheckServiceType(gbXMLServiceType serviceType)
      Description: Checks that the service type falls within an appropriate range.
      @serviceType: The service type to be checked.
      Returns: True if the service type falls within an appropriate range, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static ElementId GetBuildingConstructionSetElementId(Document ccda)
      Description: Id of the building construction set.
      Returns: Returns the id of the building construction set.
      Throws ArgumentNullException: A non-optional argument was null
    static EnergyDataSettings GetFromDocument(Document cda)
      Description: Every project document has a EnergyDataSettings element. Family documents do not have EnergyDataSettings elements.
      @cda: The document.
      Returns: Returns the EnergyDataSettings element or NULL.
      Throws ArgumentNullException: A non-optional argument was null
    string GetReportsFolderParsed()
      Description: Gets the absolute reports folder path that is parsed from the original input.
      Returns: The reports folder path after parsing the input string.
    static bool IsDocumentUsingEnergyDataAnalyticalModel(Document ccda)
      Description: Get EnergyDataSettings element and if it exists, return result from getCreateAnalyticalModel.
      @ccda: The document.
      Returns: Returns true if the Conceptual Energy Analytical Model is enabled, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetReportsFolder(string folderPath)
      Description: Sets the reports folder path.
      @folderPath: The string to specify the path. It may include the special label for project name.
      Throws ArgumentException: A folder path cannot contain special characters.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] EnergyModelType
Full Name: Autodesk.Revit.DB.Analysis.EnergyModelType
Description: This enum is used to define if the energy model is based on rooms/spaces, building elements or analysis mode in EnergyDataSettings.
Inherits: Enum

  Values:
    - SpatialElement = 0
    - BuildingElement = 1
    - AnalysisMode = 2

--------------------------------------------------------------------------------

