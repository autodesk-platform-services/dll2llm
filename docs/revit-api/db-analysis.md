# Autodesk.Revit.DB.Analysis


NAMESPACE: Autodesk.Revit.DB.Analysis
--------------------------------------------------------------------------------

[ENUM] AllowLargeGeometry
Full Name: Autodesk.Revit.DB.Analysis.AllowLargeGeometry

Description: An enumerated type containing settings information related to handling of large geometries.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - DisAllow = 0
    - Allow = 1
    - Prompt = 2

[CLASS] AnalysisDisplayColoredSurfaceSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings

Description: Contains colored surface settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayColoredSurfaceSettings()
    new AnalysisDisplayColoredSurfaceSettings(AnalysisDisplayColoredSurfaceSettings other)

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
    new AnalysisDisplayColorEntry(Color color, double value)
    new AnalysisDisplayColorEntry()

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
    new AnalysisDisplayColorSettings(AnalysisDisplayColorSettings other)

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

--------------------------------------------------------------------------------

[CLASS] AnalysisDisplayDeformedShapeSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings

Description: Contains deformed shape settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayDeformedShapeSettings()
    new AnalysisDisplayDeformedShapeSettings(AnalysisDisplayDeformedShapeSettings other)

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
    new AnalysisDisplayDiagramSettings(AnalysisDisplayDiagramSettings other)

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
Implements: IDisposable

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
    new AnalysisDisplayLegendSettings(AnalysisDisplayLegendSettings other)

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
    new AnalysisDisplayMarkersAndTextSettings(AnalysisDisplayMarkersAndTextSettings other)

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
Implements: IDisposable

  METHODS:
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayDeformedShapeSettings deformedShapeSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Deformed Shape for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @deformedShapeSettings: Deformed Shape settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayVectorSettings vectorSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Vectors for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @vectorSettings: Vector settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayDiagramSettings diagramSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Diagram for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @diagramSettings: Diagram settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayMarkersAndTextSettings markersAndTextSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Markers and Text for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @markersAndTextSettings: Markers and text settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
    static AnalysisDisplayStyle CreateAnalysisDisplayStyle(Document document, string name, AnalysisDisplayColoredSurfaceSettings coloredSurfaceSettings, AnalysisDisplayColorSettings colorSettings, AnalysisDisplayLegendSettings legendSettings)
      Description: Factory method - creates analysis display style object of type Colored Surface for the given document.
      @document: Document for which analysis display style object is created.
      @name: Name of the analysis display style within the %document%.
      @coloredSurfaceSettings: Colored surface settings for the style.
      @colorSettings: Color settings for the style.
      @legendSettings: Legend settings for the style.
      Returns: New analysis display style object.
    static ElementId FindByName(Document document, string name)
      Description: Finds analysis display style by name.
      @document: Document in which to look for analysis display style element.
      @name: Name of analysis display style to look for.
      Returns: Element id of the found analysis display style, invalidElementId if not found.
    AnalysisDisplayColoredSurfaceSettings GetColoredSurfaceSettings()
      Description: Get colored surface settings object from the style.
    AnalysisDisplayColorSettings GetColorSettings()
      Description: Get color settings object from the style.
    AnalysisDisplayDeformedShapeSettings GetDeformedShapeSettings()
      Description: Get deformed shape settings object from the style.
    AnalysisDisplayDiagramSettings GetDiagramSettings()
      Description: Get diagram settings object from the style.
    static ICollection<ElementId> GetElements(Document document)
      Description: Returns set of all analysis display styles elements in the given document.
      @document: Document from which analysis display style elements are retrieved.
      Returns: All analysis display style elements existing in the document.
    AnalysisDisplayLegendSettings GetLegendSettings()
      Description: Get legend settings object from the style.
    AnalysisDisplayMarkersAndTextSettings GetMarkersAndTextSettings()
      Description: Get markers and text settings object from the style.
    AnalysisDisplayVectorSettings GetVectorSettings()
      Description: Get vector settings object from the style.
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
    static bool IsTextTypeIdValid(ElementId textTypeId, Document doc)
      Description: Verify if text type id is valid.
      @textTypeId: Text type id to be validated.
      @doc: Document for which %textTypeId% is validated.
      Returns: True if text type id is valid, false otherwise.
    void SetColoredSurfaceSettings(AnalysisDisplayColoredSurfaceSettings coloredSurfaceSettings)
      Description: Set colored surface settings object for the style.
    void SetColorSettings(AnalysisDisplayColorSettings colorSettings)
      Description: Set color settings object for the style.
    void SetDeformedShapeSettings(AnalysisDisplayDeformedShapeSettings deformedShapeSettings)
      Description: Set deformed shape settings object for the style.
    void SetDiagramSettings(AnalysisDisplayDiagramSettings diagramSettings)
      Description: Set diagram settings object for the style.
    void SetLegendSettings(AnalysisDisplayLegendSettings legendSettings)
      Description: Set legend settings object for the style.
    void SetMarkersAndTextSettings(AnalysisDisplayMarkersAndTextSettings markersAndTextSettings)
      Description: Set markers and text settings object for the style.
    void SetName(string name)
      Description: Set name of analysis display style element.
      @name: Analysis display style element name to be set.
    void SetVectorSettings(AnalysisDisplayVectorSettings vectorSettings)
      Description: Set vector settings object for the style.

--------------------------------------------------------------------------------

[ENUM] AnalysisDisplayStyleColorSettingsType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType

Description: Defines types for color settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - GradientColor = 0
    - SolidColorRanges = 1

[ENUM] AnalysisDisplayStyleDeformedShapeTextLabelType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDeformedShapeTextLabelType

Description: Defines text visualization types for deformed shape settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

[ENUM] AnalysisDisplayStyleDiagramFenceType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramFenceType

Description: Defines fence visualization types for diagram settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

[ENUM] AnalysisDisplayStyleDiagramTextLabelType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleDiagramTextLabelType

Description: Defines text label visualization types for diagram settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

[ENUM] AnalysisDisplayStyleMarkerTextLabelType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerTextLabelType

Description: Text label visualization types for Markers and Text settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

[ENUM] AnalysisDisplayStyleMarkerType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleMarkerType

Description: Marker types for Markers and Text settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Circle = 0
    - Square = 1
    - Triangle = 2

[ENUM] AnalysisDisplayStyleVectorArrowheadScale
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorArrowheadScale

Description: Defines arrow head scaling for vector settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoScaling = 0
    - Length5Percent = 1
    - Length10Percent = 2
    - Length15Percent = 3
    - Length20Percent = 4
    - NoArrow = 5

[ENUM] AnalysisDisplayStyleVectorOrientation
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorOrientation

Description: Defines vector orientation for vector settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Linear = 0
    - ArcAroundVectorAxis = 1

[ENUM] AnalysisDisplayStyleVectorPosition
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorPosition

Description: Defines vector position for vector settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ToDataPoint = 0
    - FromDataPoint = 1

[ENUM] AnalysisDisplayStyleVectorTextType
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleVectorTextType

Description: Defines text visualization types for vector settings of analysis display style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowAll = 0
    - ShowNone = 1
    - ShowPredefined = 2

[CLASS] AnalysisDisplayVectorSettings
Full Name: Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings

Description: Contains vector settings for analysis display style element.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisDisplayVectorSettings()
    new AnalysisDisplayVectorSettings(AnalysisDisplayVectorSettings other)

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BuildingElements = 0
    - ConceptualMassesAndBuildingElements = 2
    - RoomsOrSpaces = 3

[CLASS] AnalysisResultSchema
Full Name: Autodesk.Revit.DB.Analysis.AnalysisResultSchema

Description: Contains all information about one analysis result. Each result may contain several measurements.
Remarks: In order to take effect, the AnalysisResultSchema object has to be registered by calling SpatialFieldManager::RegisterResult, which returns result index for future references; to make changes to the properties of an already registered object, use method SpatialFieldManager::SetResultSchema and supply result index and replacing object.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalysisResultSchema(string name, string description)
    new AnalysisResultSchema(AnalysisResultSchema other)

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
    void SetUnits(IList<string> names, IList<double> multipliers)
      Description: Sets names and multipliers of all units for result visualization
      @names: Unit names for all units (e.g., "Lb" and "Kg")
      @multipliers: Numerical coefficients mapped to unit names. They adjust measurement values shown in the legend and display (e.g., 1.0 and 0.451 - if actual measurements are in Lb)

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
Implements: IDisposable

  PROPERTIES:
    string ScheduleName { get; set; }
      Description: The name of the schedule.

  METHODS:
    static BuildingOperatingDaySchedule Create(Document document, string name)
      Description: Creates a new instance of a BuildingOperatingDaySchedule.
      @document: The document to create the new BuildingOperatingDaySchedule element.
      @name: The intended name of the newly created BuildingOperatingDaySchedule, may be modified to disambiguate with existing element.
      Returns: The newly created BuildingOperatingDaySchedule.
    double GetValueForHour(int hour)
      Description: Gets the usage value for an hour.
      @hour: The hour in the day, as an integer. For example: 0 is 12:00 midnight to 1:00 am, 6 is 6:00 am to 7:00 am, 12 is 12:00 noon to 1:00 pm, and 23 is 11:00 pm to midnight. To avoid issues around daylight savings times, these hours represent 1/24 of an earth rotation, and will not be exactly 60 minutes.
      Returns: The usage as a fraction between 0 and 1 inclusive. For example: 0 in a lighting schedule means all lights are off, .5 means half of lights are on, 1 means all lights are on.
    void SetValueForHour(int hour, double usage)
      Description: Sets the usage value for an hour.
      @hour: The hour in the day, as an integer. For example: 0 is 12:00 midnight to 1:00 am, 6 is 6:00 am to 7:00 am, 12 is 12:00 noon to 1:00 pm, and 23 is 11:00 pm to midnight. To avoid issues around daylight savings times, these hours represent 1/24 of an earth rotation, and will not be exactly 60 minutes.
      @usage: The usage as a fraction between 0 and 1 inclusive. For example: 0 in a lighting schedule means all lights are off, .5 means half of lights are on, 1 means all lights are on.

--------------------------------------------------------------------------------

[CLASS] BuildingOperatingYearSchedule
Full Name: Autodesk.Revit.DB.Analysis.BuildingOperatingYearSchedule

Description: Represents an operating schedule that contains 365 daily usage BuildingOperatingDaySchedules.
Inherits: Element
Implements: IDisposable

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
    BuildingOperatingDaySchedule GetScheduleForDay(DateTime day)
      Description: Gets the BuildingOperatingDaySchedule for this day of the year.
      @day: The day of the year. The value must be in 2023 (the template year) and have the time zone set to gmt/utc. Time values will be ignored.
      Returns: The schedule used on that day.
    void SetScheduleForDay(DateTime day, BuildingOperatingDaySchedule daySchedule)
      Description: Sets the BuildingOperatingDaySchedule for this day of the year.
      @day: The day of the year. The value must be in 2023 (the template year) and have the time zone set to gmt/utc. Time values will be ignored.
      @daySchedule: The schedule used on that day.

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionFloorSlabType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType

Description: ConceptualConstructionType values for Floors.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[ENUM] ConceptualConstructionOpeningType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType

Description: ConceptualConstructionType values for Openings.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Air = 0
    - NumOpeningTypeConstruction = 1
    - InvalidOpeningTypeConstruction = -1

[ENUM] ConceptualConstructionRoofType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType

Description: ConceptualConstructionType values for Roofs.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[ENUM] ConceptualConstructionShadeType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType

Description: ConceptualConstructionType values for Shades.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BasicShade = 0
    - NumShadeTypeConstruction = 1
    - InvalidShadeTypeConstruction = -1

[CLASS] ConceptualConstructionType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionType

Description: This element is used to describe the conceptual physical, construction, and energy properties in a manner that can be understood by both the Revit BIM model and Green Building Studio/Green Building XML. For serialization
Inherits: ElementType
Implements: IDisposable

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
    static ElementId GetFloorOrSlabConstructionType(Document ccda, ConceptualConstructionFloorSlabType typeEnum)
      Description: Get a Floor or Slab ConceptualConstructionType by its ConceptualConstructionFloorSlabType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionFloorSlabType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
    int GetGBSId(ElementId massSurfaceSubCategoryId)
      Description: Gets the Green Building Studio identifier associated with the construction.
      @massSurfaceSubCategoryId: The ElementId of a valid Mass subcategory of a MassSurfaceData.
      Returns: Returns the integer id used to represent the ConceptualConstructionType.
    static ElementId GetOpeningConstructionType(Document ccda, ConceptualConstructionOpeningType typeEnum)
      Description: Get an Opening ConceptualConstructionType by its ConceptualConstructionOpeningType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionOpeningType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
    static ElementId GetRoofConstructionType(Document ccda, ConceptualConstructionRoofType typeEnum)
      Description: Get a Roof ConceptualConstructionType by its ConceptualConstructionRoofType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionRoofType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
    static ElementId GetShadeConstructionType(Document ccda, ConceptualConstructionShadeType typeEnum)
      Description: Get a Shade ConceptualConstructionType by its ConceptualConstructionShadeType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionShadeType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
    static ElementId GetWallConstructionType(Document ccda, ConceptualConstructionWallType typeEnum)
      Description: Get a Wall ConceptualConstructionType by its ConceptualConstructionWallType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionWallType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
    static ElementId GetWindowOrSkylightConstructionType(Document ccda, ConceptualConstructionWindowSkylightType typeEnum)
      Description: Get a Window or Skylight ConceptualConstructionType by its ConceptualConstructionWindowSkylightType.
      @ccda: The Document.
      @typeEnum: The ConceptualConstructionWindowSkylightType to get the ConceptualConstructionType for.
      Returns: Returns ElementId of a ConceptualConstructionType.
    static bool IsValidConceptualConstructionId(Document ccda, ElementId constructionTypeId)
      Description: Indicates if the ElementId is an id of a ConceptualConstructionType.
      @ccda: The document.
      @constructionTypeId: The ElementId of the ConceptualConstructionType.
      Returns: Returns true if is an id of a ConceptualConstructionType, false otherwise.
    static bool IsValidConceptualConstructionIdForCategory(Document ccda, ElementId constructionTypeId, ElementId massSubcategoryId)
      Description: Indicate if a ConceptualConstruction is appropriate to assign to a MassSurfaceData of a particular Mass subcategory.
      @ccda: The document.
      @constructionTypeId: The ElementId of the ConceptualConstructionType.
      @massSubcategoryId: The ElementId of the Mass subcategory.
      Returns: Returns true if valid, false otherwise
    static bool IsValidSubcategoryForMassSurfaceDatas(ElementId massSubCategoryId)
      Description: Validate if a subcategory is appropriate for assignment to Massing surfaces (MassSurfaceData). This is the list of acceptable values: OST_MassInteriorWallOST_MassExteriorWallOST_MassExteriorWallUndergroundOST_MassRoofOST_MassFloorOST_MassSlabOST_MassShadeOST_MassGlazingOST_MassSkylightsOST_MassOpening
      @massSubCategoryId: The mass sub-category to be checked.
      Returns: True if the mass sub-category falls within the list, false otherwise.
    bool IsValidSurfaceSubcategoryForConstruction(ElementId massSurfaceSubcategoryId)
      Description: Indicates if this ConceptualConstructionType is appropriate for the input MassSurfaceData subcategory.
      @massSurfaceSubcategoryId: The ElementId of a Mass subcategory of a MassSurfaceData.
      Returns: Returns true if appropriate for the input subcategory, false otherwise.

--------------------------------------------------------------------------------

[ENUM] ConceptualConstructionWallType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType

Description: ConceptualConstructionType values for Walls.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[ENUM] ConceptualConstructionWindowSkylightType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType

Description: ConceptualConstructionType values for Windows and Skylights
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[CLASS] ConceptualSurfaceType
Full Name: Autodesk.Revit.DB.Analysis.ConceptualSurfaceType

Description: This element represents a conceptual BIM object category to assign to faces in Mass geometries. There is one ConceptualSurfaceType element for each of the Mass Surface Subcategories. for serialization
Remarks: When Conceptual Energy Analysis is enabled in Revit Projects, massing faces will be assigned to the subcategories of Mass category that these ConceptualSurfaceType's are associated with. A default ConceptualConstructionType is associated with the ConceptualSurfaceType. This default ConceptualConstructionType is assigned to Mass faces with the corresponding subcategory. Changing the default ConceptualConstructionType associated with the ConceptualSurfaceType will update the ConceptualConstruction type for all Mass faces of that subcategory which the user has not specifically provided an override value for.
Inherits: Element
Implements: IDisposable

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
    ICollection<ElementId> GetConstructionTypeIds()
      Description: The element ids of the ConceptualConstructionType's associated with this ConceptualSurfaceType.

--------------------------------------------------------------------------------

[ENUM] ConstructionType
Full Name: Autodesk.Revit.DB.Analysis.ConstructionType

Description: This enumeration specifies the available analytical construction types like external walls, windows etc. for use in the detailed analytical energy model.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[CLASS] CriticalPathCollector
Full Name: Autodesk.Revit.DB.Analysis.CriticalPathCollector

Description: This class is used to search and traverse the network analytical segments on the critical path.
Remarks: The critcal path is a connected flow path that has the maximum pressure loss value on the network. The associated flow and pressure loss values are often used to select the equipment size. When this collector is constructed, the network is identified by one analytical segment seed. User may get the CriticalPathIterator from the collector to traverse the analytical segment on the critical path, in the sequence of their flow direction. Note that If the network contains multiple hydraulically separated levels, the critical path traversal is focused on the same hydraulic separation level as the seed segment.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new CriticalPathCollector(Document doc, MEPNetworkSegmentId segmentId)

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
Implements: IEnumerator`1, IDisposable, IEnumerator

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
Implements: IDisposable

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
Implements: IDisposable

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
    void TransformModel()
      Description: Transforms all surfaces in the model according to the document's active ground plane, shared coordinates and true north.

--------------------------------------------------------------------------------

[CLASS] EnergyAnalysisDetailModelOptions
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions

Description: Options that govern the calculations for the generation of the energy analysis detail model.
Implements: IDisposable

  CONSTRUCTORS:
    new EnergyAnalysisDetailModelOptions()

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotComputed = 0
    - FirstLevelBoundaries = 1
    - SecondLevelBoundaries = 2
    - Final = 3

[CLASS] EnergyAnalysisMaterial
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisMaterial

Description: A description of a material with thermal properties in a composite construction.
Inherits: Element
Implements: IDisposable

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
Implements: IDisposable

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Door = 0
    - Window = 1
    - Skylight = 2
    - Air = 3

[CLASS] EnergyAnalysisSpace
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace

Description: Analytical space.
Inherits: Element
Implements: IDisposable

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
Implements: IDisposable

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[CLASS] EnergyAnalysisWindowType
Full Name: Autodesk.Revit.DB.Analysis.EnergyAnalysisWindowType

Description: The EnergyAnalysisWindowType class contains the thermal properties (e.g., heat transfer coefficient) of the window-type analytical openings.
Inherits: Element
Implements: IDisposable

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
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] EnergyDataSettings
Full Name: Autodesk.Revit.DB.Analysis.EnergyDataSettings

Description: This element contains settings for gbXML Export and Heating and Cooling Load Calculations and project level settings for Conceptual Energy Analysis. for serialization
Inherits: Element
Implements: IDisposable

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
    static bool CheckBuildingConstructionClass(HVACLoadConstructionClass buildingConstructionClass)
      Description: Checks that the building construction class falls within an appropriate range.
      @buildingConstructionClass: The building construction class to be checked.
      Returns: True if the building construction class falls within an appropriate range, false otherwise.
    static bool CheckBuildingEnvelope(gbXMLExportBuildingEnvelope determinationMethod)
      Description: Checks that the building envelope determination method falls within an appropriate range.
      @determinationMethod: The building envelope determination method to be checked.
      Returns: True if the building envelope determination method falls within an appropriate range, false otherwise.
    static bool CheckBuildingHVACSystem(gbXMLBuildingHVACSystem buildingHVACSystem)
      Description: Checks that the building HVAC system falls within an appropriate range.
      @buildingHVACSystem: The building HVAC system to be checked.
      Returns: True if the building HVAC system falls within an appropriate range, false otherwise.
    static bool CheckBuildingOperatingSchedule(gbXMLBuildingOperatingSchedule buildingOperatingSchedule)
      Description: Checks that the building operating schedule falls within an appropriate range.
      @buildingOperatingSchedule: The building operating schedule to be checked.
      Returns: True if the building operating schedule falls within an appropriate range, false otherwise.
    static bool CheckBuildingType(gbXMLBuildingType buildingType)
      Description: Checks that the building type falls within an appropriate range.
      @buildingType: The building type to be checked.
      Returns: True if the building type falls within an appropriate range, false otherwise.
    bool CheckConstructionSetElement(ElementId constructionSetElementId)
      Description: Checks that the construction set ElementId is acceptable.
      @constructionSetElementId: The construction set ElementId to be checked.
      Returns: True if the construction set ElementId is a valid construction set element, false otherwise.
    static bool CheckExportCategory(ElementId exportCategoryId)
      Description: Checks whether the export category falls within the list: OST_RoomsOST_MEPSpaces
      @exportCategoryId: The export category to be checked.
      Returns: True if the export category falls within the list, false otherwise.
    static bool CheckExportComplexity(gbXMLExportComplexity exportComplexity)
      Description: Checks that the export complexity falls within an appropriate range.
      @exportComplexity: The export complexity to be checked.
      Returns: True if the export complexity falls within an appropriate range, false otherwise.
    static bool CheckGroundPlane(Document ccda, ElementId groundPlaneId)
      Description: The ground plane should be an Element of type Level. This method checks to confirm that an ElementId is for a Level element.
      @ccda: The Document.
      @groundPlaneId: The element id to be checked to confirm that it is suitable to be a ground plane (i.e., that it is a level) or that it is invalidElementId. Setting ground plane with invalidElementId will lead to the ground plane being "reset".
      Returns: True if the input element is a level or invalidElementId, false otherwise.
    bool CheckGroundPlane(ElementId groundPlaneId)
      Description: The ground plane should be an Element of type Level. This method checks to confirm that an ElementId is for a Level element.
      @groundPlaneId: The element id to be checked to confirm that it is suitable to be a ground plane (i.e., that it is a level) or that it is invalidElementId. Setting ground plane with invalidElementId will lead to the ground plane being "reset".
      Returns: True if the input element is a level or invalidElementId, false otherwise.
    bool CheckProjectPhase(ElementId projectPhaseId)
      Description: Checks that the input element is a project phase.
      @projectPhaseId: The element to be checked.
      Returns: True if the input element is a project phase, false otherwise.
    static bool CheckProjectReportType(HVACLoadLoadsReportType projectReportType)
      Description: Checks that the project report type falls within an appropriate range.
      @projectReportType: The project report type to be checked.
      Returns: True if the project report type falls within an appropriate range, false otherwise.
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
    static ElementId GetBuildingConstructionSetElementId(Document ccda)
      Description: Id of the building construction set.
      Returns: Returns the id of the building construction set.
    static EnergyDataSettings GetFromDocument(Document cda)
      Description: Every project document has a EnergyDataSettings element. Family documents do not have EnergyDataSettings elements.
      @cda: The document.
      Returns: Returns the EnergyDataSettings element or NULL.
    string GetReportsFolderParsed()
      Description: Gets the absolute reports folder path that is parsed from the original input.
      Returns: The reports folder path after parsing the input string.
    static bool IsDocumentUsingEnergyDataAnalyticalModel(Document ccda)
      Description: Get EnergyDataSettings element and if it exists, return result from getCreateAnalyticalModel.
      @ccda: The document.
      Returns: Returns true if the Conceptual Energy Analytical Model is enabled, false otherwise.
    void SetReportsFolder(string folderPath)
      Description: Sets the reports folder path.
      @folderPath: The string to specify the path. It may include the special label for project name.

--------------------------------------------------------------------------------

[ENUM] EnergyModelType
Full Name: Autodesk.Revit.DB.Analysis.EnergyModelType

Description: This enum is used to define if the energy model is based on rooms/spaces, building elements or analysis mode in EnergyDataSettings.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SpatialElement = 0
    - BuildingElement = 1
    - AnalysisMode = 2

[CLASS] FieldDomainPoints
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPoints

Description: Abstract base class for various classes of field domain points
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] FieldDomainPointsByParameter
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPointsByParameter

Description: Represents a set of one-dimensional point coordinates (defined usually on curve)
Inherits: FieldDomainPoints
Implements: IDisposable

  CONSTRUCTORS:
    new FieldDomainPointsByParameter(IList<double> points)

--------------------------------------------------------------------------------

[CLASS] FieldDomainPointsByUV
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV

Description: Represents a set of two-dimensional point coordinates (defined usually on surface)
Inherits: FieldDomainPoints
Implements: IDisposable

  CONSTRUCTORS:
    new FieldDomainPointsByUV(IList<UV> points, ICollection<double> uCoordinates, ICollection<double> vCoordinates)
    new FieldDomainPointsByUV(IList<UV> points)

  METHODS:
    void SetGridCoordinates(ICollection<double> uCoordinates, ICollection<double> vCoordinates)
      Description: Set u and v coordinates that specify a grid on the surface. The display of the grid is controlled by AnalysisDisplayColoredSurfaceSettings::getShowGridLines(). If AnalysisDisplayColoredSurfaceSettings::getShowGridLines() returns true and both sets are empty then a grid will be displayed using a default spacing; if only one of the sets is non-empty, then only the corresponding set of grid lines will be displayed, i.e. the grid will consist solely of parallel lines at the specified coordinates.
      @uCoordinates: Set of u coordinates at which to draw grid lines
      @vCoordinates: Set of v coordinates at which to draw grid lines

--------------------------------------------------------------------------------

[CLASS] FieldDomainPointsByXYZ
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPointsByXYZ

Description: Represents a set of three-dimensional point coordinates
Inherits: FieldDomainPoints
Implements: IDisposable

  CONSTRUCTORS:
    new FieldDomainPointsByXYZ(IList<XYZ> points)

--------------------------------------------------------------------------------

[CLASS] FieldValues
Full Name: Autodesk.Revit.DB.Analysis.FieldValues

Description: Contains values corresponding to domain points. Each domain point may have an array of values, each corresponding to a separate "measurement" for which this value was calculated.
Implements: IDisposable

  CONSTRUCTORS:
    new FieldValues(FieldValues otherObject)
    new FieldValues(IList<VectorAtPoint> vectorAtPoint)
    new FieldValues(IList<ValueAtPoint> valueAtPoint, XYZ unitDirection)
    new FieldValues(IList<ValueAtPoint> valueAtPoint)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] gbXMLBuildingHVACSystem
Full Name: Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem

Description: Enumerations for gbXML (Green Building XML) format, used for energy analysis, schema version 0.34.
Remarks: This enumeration corresponds to the HVAC System attribute in gbXML and is used to specify the Building HVAC System.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TwelveSEERSPointNineAFUESplitPackagedGasFiveToElevenTon = 0
    - ElevenPointThreeEERPackagedVAVEightyFourPointFourPercentBoilerHeating = 1
    - CentralVAVHWHeatChillerFivePointNinetySixCOPBoilersEightyFourPoint5Eff = 2
    - FourPipeFanCoilSystemChillerFivePointNinetySixCOPBoilersEightFourPointFiveEff = 3
    - CentralVAVElectricResistanceHeatChillerFivePointNinetySixCOP = 4
    - TwelveSEERSevenPointSevenHSPFSplitPackagedHeatPump = 5
    - TwoPipeFanCoilSystemChillerFivePointNinetySixCOPBoilersEightyFourPointFiveEff = 6
    - TwelveSEEREightPointThreeHSPFPackagedTerminalHeatPumpPTAC = 7
    - ResidentialSeventeenSEERNinePointSixHSPFSplitHPLessThanFivePointFiveTon = 8
    - UnderfloorAirDistribution = 9
    - ResidentialFourteenSEERPointNineAFUESplitPackagedGasLessThanFivePointFiveTon = 10
    - ResidentialFourteenSEEREightPointThreeHSPFSplitPackagedHeatPump = 11
    - NoOfHVACSystemEnums = 12

[ENUM] gbXMLBuildingOperatingSchedule
Full Name: Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule

Description: Enumerations for gbXML (Green Building XML) format, used for energy analysis, schema version 0.34.
Remarks: This enumeration corresponds to the buildingType attribute in gbXML and is used to specify the building operating schedule.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - DefaultOperatingSchedule = 0
    - TwentyFourHourSevenDayFacility = 1
    - TwentyFourHourHourSixDayFacility = 2
    - TwentyFourHourHourFiveDayFacility = 3
    - TwelveHourSevenDayFacility = 4
    - TwelveHourSixDayFacility = 5
    - TwelveHourFiveDayFacility = 6
    - KindergartenThruTwelveGradeSchool = 7
    - YearRoundSchool = 8
    - TheaterPerformingArts = 9
    - Worship = 10
    - NoOfOperatingScheduleEnums = 11

[ENUM] gbXMLBuildingType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLBuildingType

Description: Enumerations for gbXML (Green Building XML) format, used for energy analysis, schema version 0.34.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AutomotiveFacility = 0
    - ConventionCenter = 1
    - Courthouse = 2
    - DiningBarLoungeOrLeisure = 3
    - DiningCafeteriaFastFood = 4
    - DiningFamily = 5
    - Dormitory = 6
    - ExerciseCenter = 7
    - FireStation = 8
    - Gymnasium = 9
    - HospitalOrHealthcare = 10
    - Hotel = 11
    - Library = 12
    - Manufacturing = 13
    - Motel = 14
    - MotionPictureTheatre = 15
    - MultiFamily = 16
    - Museum = 17
    - Office = 18
    - ParkingGarage = 19
    - Penitentiary = 20
    - PerformingArtsTheater = 21
    - PoliceStation = 22
    - PostOffice = 23
    - ReligiousBuilding = 24
    - Retail = 25
    - SchoolOrUniversity = 26
    - SingleFamily = 27
    - SportsArena = 28
    - TownHall = 29
    - Transportation = 30
    - Warehouse = 31
    - Workshop = 32
    - NoOfBuildingTypes = 33
    - CustomizeBuildingType = -2
    - NoBuildingType = -1

[ENUM] gbXMLConditionType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLConditionType

Description: This enumeration corresponds to the conditionType attribute in gbXML. The enumerated attribute identifies the type of heating, cooling, or ventilation the space has.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Heated = 0
    - Cooled = 1
    - HeatedAndCooled = 2
    - Unconditioned = 3
    - Vented = 4
    - NaturallyVentedOnly = 5
    - NoOfConditionTypes = 6
    - NoConditionType = -1

[ENUM] gbXMLExportBuildingEnvelope
Full Name: Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope

Description: Indicates the determination method for the building envelope
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UseFunctionParameter = 0
    - IdentifyExteriorElements = 1

[ENUM] gbXMLExportComplexity
Full Name: Autodesk.Revit.DB.Analysis.gbXMLExportComplexity

Description: This enumeration specifies the level of detail of the exported analytical energy model in gbXML. Complex means that Curtain Walls and Curtain Systems are exported as several openings, panel by panel; a curtain wall with 50 panels gets exported as 50 openings. Simple means that one "huge" opening with the total opening area equal to the 50 panels is exported. This is more appropriate for most energy analysis. Mullions mean that Mullions in Curtain Walls and Systems are exported as shading surfaces. A "simplified" analytical shading surface is produced from a mullion based on its centerline, thickness and offset.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Simple = 0
    - SimpleWithShadingSurfaces = 1
    - Complex = 2
    - ComplexWithShadingSurfaces = 3
    - ComplexWithMullionsAndShadingSurfaces = 4

[ENUM] gbXMLOpeningType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLOpeningType

Description: This enumeration corresponds to the openingType attribute in gbXML and identifies the type of opening defined.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FixedWindow = 0
    - OperableWindow = 1
    - FixedSkylight = 2
    - OperableSkylight = 3
    - SlidingDoor = 4
    - NonSlidingDoor = 5
    - OpeningAir = 6
    - NoOfOpeningTypes = 7

[ENUM] gbXMLServiceType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLServiceType

Description: This enumeration corresponds to the systemType attribute in gbXML and is used for specifying the service for the building or space.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - CentralHeatingRadiators = 0
    - CentralHeatingConvectors = 1
    - CentralHeatingRadiantFloor = 2
    - CentralHeatingHotAir = 3
    - OtherRoomHeater = 4
    - RadiantHeaterFlue = 5
    - RadiantHeaterNoFlue = 6
    - RadiantHeaterMultiburner = 7
    - ForcedConvectionHeaterFlue = 8
    - ForcedConvectionHeaterNoFlue = 9
    - VAVSingleDuct = 10
    - VAVDualDuct = 11
    - VAVIndoorPackagedCabinet = 12
    - VAVTerminalReheat = 13
    - FanCoilSystem = 14
    - InductionSystem = 15
    - ConstantVolumeFixedOA = 16
    - ConstantVolumeVariableOA = 17
    - ConstantVolumeTerminalReheat = 18
    - MultizoneHotDeckColdDeck = 19
    - ConstantVolumeDualDuct = 20
    - RadiantCooledCeilings = 21
    - ActiveChilledBeams = 22
    - WaterLoopHeatPump = 23
    - VariableRefrigerantFlow = 24
    - SplitSystemsWithNaturalVentilation = 25
    - SplitSystemsWithMechanicalVentilation = 26
    - SplitSystemsWithMechanicalVentilationWithCooling = 27
    - NoOfServiceTypes = 28
    - NoServiceType = -1

[ENUM] gbXMLSpaceType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLSpaceType

Description: This enumeration corresponds to the spaceType attribute in gbXML. The enumerated attribute identifies the type of space defined and allows to better approximate the actual internal loads and schedules associated with the defined space type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ActiveStorage = 0
    - ActiveStorageHospitalOrHealthcare = 1
    - AirOrTrainOrBusBaggageArea = 2
    - AirportConcourse = 3
    - AtriumEachAdditionalFloor = 4
    - AtriumFirstThreeFloors = 5
    - AudienceOrSeatingAreaPenitentiary = 6
    - AudienceOrSeatingAreaExerciseCenter = 7
    - AudienceOrSeatingAreaGymnasium = 8
    - AudienceOrSeatingAreaSportsArena = 9
    - AudienceOrSeatingAreaConventionCenter = 10
    - AudienceOrSeatingAreaMotionPictureTheatre = 11
    - AudienceOrSeatingAreaPerformingArtsTheatre = 12
    - AudienceOrSeatingAreaReligious = 13
    - AudienceOrSeatingAreaPoliceOrFireStations = 14
    - AudienceOrSeatingAreaCourtHouse = 15
    - AudienceOrSeatingAreaAuditorium = 16
    - BankCustomerArea = 17
    - BankingActivityAreaOffice = 18
    - BarberAndBeautyParlor = 19
    - CardFileAndCataloguingLibrary = 20
    - ClassroomOrLectureOrTrainingPenitentiary = 21
    - ClassroomOrLectureOrTraining = 22
    - ConfinementCellsPenitentiary = 23
    - ConfinementCellsCourtHouse = 24
    - ConferenceMeetingOrMultipurpose = 25
    - CorridorOrTransition = 26
    - CorridorOrTransitionManufacturingFacility = 27
    - CorridorsWithPatientWaitingExamHospitalOrHealthcare = 28
    - CourtSportsAreaSportsArena = 29
    - CourtroomCourtHouse = 30
    - DepartmentStoreSalesAreaRetail = 31
    - DetailedManufacturingFacility = 32
    - DiningArea = 33
    - DiningAreaHotel = 34
    - DiningAreaFamilyDining = 35
    - DiningAreaLoungeOrLeisureDining = 36
    - DiningAreaMotel = 37
    - DiningAreaTransportation = 38
    - DiningAreaPenitentiary = 39
    - DiningAreaCivilServices = 40
    - DormitoryBedroom = 41
    - DormitoryStudyHall = 42
    - DressingOrLockerOrFittingRoomGymnasium = 43
    - DressingOrLockerOrFittingRoomCourtHouse = 44
    - DressingOrLockerOrFittingRoomPerformingArtsTheatre = 45
    - DressingOrLockerOrFittingRoomAuditorium = 46
    - DressingOrLockerOrFittingRoomExerciseCenter = 47
    - ElectricalOrMechanical = 48
    - ElevatorLobbies = 49
    - EmergencyHospitalOrHealthcare = 50
    - EquipmentRoomManufacturingFacility = 51
    - ExamOrTreatmentHospitalOrHealthcare = 52
    - ExerciseAreaExerciseCenter = 53
    - ExerciseAreaGymnasium = 54
    - ExhibitSpaceConventionCenter = 55
    - FellowshipHallReligiousBuildings = 56
    - FineMaterialWarehouse = 57
    - FineMerchandiseSalesAreaRetail = 58
    - FireStationEngineRoomPoliceOrFireStation = 59
    - FoodPreparation = 60
    - GarageServiceOrRepairAutomotiveFacility = 61
    - GeneralHighBayManufacturingFacility = 62
    - GeneralLowBayManufacturingFacility = 63
    - GeneralExhibitionMuseum = 64
    - HospitalNurseryHospitalOrHealthcare = 65
    - HospitalOrMedicalSuppliesHospitalOrHealthcare = 66
    - HospitalOrRadiologyHospitalOrHealthcare = 67
    - HotelOrConferenceCenterConferenceOrMeeting = 68
    - InactiveStorage = 69
    - JudgesChambersCourtHouse = 70
    - LaboratoryOffice = 71
    - LaundryIroningAndSorting = 72
    - LaundryWashingHospitalOrHealthcare = 73
    - LibraryAudioVisualLibraryAudioVisual = 74
    - LivingQuartersDormitory = 75
    - LivingQuartersMotel = 76
    - LivingQuartersHotel = 77
    - Lobby = 78
    - LobbyReligiousBuildings = 79
    - LobbyMotionPictureTheatre = 80
    - LobbyAuditorium = 81
    - LobbyPerformingArtsTheatre = 82
    - LobbyPostOffice = 83
    - LobbyHotel = 84
    - LoungeOrRecreation = 85
    - MallConcourseSalesAreaRetail = 86
    - MassMerchandisingSalesAreaRetail = 87
    - MediumOrBulkyMaterialWarehouse = 88
    - MerchandisingSalesAreaRetail = 89
    - MuseumAndGalleryStorage = 90
    - NurseStationHospitalOrHealthcare = 91
    - OfficeEnclosed = 92
    - OfficeOpenPlan = 93
    - OfficeCommonActivityAreasInactiveStorage = 94
    - OperatingRoomHospitalOrHealthcare = 95
    - OtherTelevisedPlayingAreaSportsArena = 96
    - ParkingAreaAttendantOnlyParkingGarage = 97
    - ParkingAreaPedestrianParkingGarage = 98
    - PatientRoomHospitalOrHealthcare = 99
    - PersonalServicesSalesAreaRetail = 100
    - PharmacyHospitalOrHealthcare = 101
    - PhysicalTherapyHospitalOrHealthcare = 102
    - PlayingAreaGymnasium = 103
    - Plenum = 104
    - PoliceStationLaboratoryPoliceOrFireStations = 105
    - PublicAndStaffLoungeHospitalOrHealthcare = 106
    - ReadingAreaLibrary = 107
    - ReceptionOrWaitingTransportation = 108
    - ReceptionOrWaitingMotel = 109
    - ReceptionOrWaitingHotel = 110
    - RecoveryHospitalOrHealthcare = 111
    - RestorationMuseum = 112
    - Restrooms = 113
    - RingSportsAreaSportsArena = 114
    - SleepingQuartersPoliceOrFireStation = 115
    - SortingAreaPostOffice = 116
    - SpecialtyStoreSalesAreaRetail = 117
    - StacksLibrary = 118
    - StairsInactive = 119
    - Stairway = 120
    - SupermarketSalesAreaRetail = 121
    - TerminalTicketCounterTransportation = 122
    - WorkshopWorkshop = 123
    - WorshipPulpitChoirReligious = 124
    - NoOfSpaceTypes = 125
    - CustomizeSpaceType = -2
    - NoSpaceType = -1

[ENUM] gbXMLSurfaceType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLSurfaceType

Description: This enumeration corresponds to the surfaceType attribute in gbXML and identifies the type of surface defined.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - InteriorWall = 0
    - ExteriorWall = 1
    - Roof = 2
    - InteriorFloor = 3
    - ExposedFloor = 4
    - Shade = 5
    - UndergroundWall = 6
    - UndergroundSlab = 7
    - Ceiling = 8
    - SurfaceAir = 9
    - UndergroundCeiling = 10
    - RaisedFloor = 11
    - SlabOnGrade = 12
    - NoOfSurfaceTypes = 13

[CLASS] GenericZone
Full Name: Autodesk.Revit.DB.Analysis.GenericZone

Description: Provides access to the GenericZone Element in Autodesk Revit.
Remarks: A generic zone is a tool that provides for a method of selecting elements that somehow come in contact with the zone object. A zone is a non-hierarchical structure of geometric information, area or volume definitions for the purpose of analysis. A generic zone will contain specific domain requirements provided at creation of the element.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double LevelOffset { get; set; }
      Description: The offset distance from this zone to the associated level.

  METHODS:
    static GenericZone Create(Document doc, string name, GenericZoneDomainData domainData, ElementId levelId, IList<CurveLoop> curveLoops)
      Description: Creates a new instance of a generic zone and adds it to the document.
      @doc: The document where the element will be created and added.
      @name: The name of the generic zone to be created.
      @domainData: The specific domain requirements for the generic zone.
      @levelId: The base level on which the generic zone will be created.
      @curveLoops: The loops that define the lines, curves and areas that overlap or crosses the elements you want to belong to the zone. Multiple loops are allowed, they can be open or closed, but they should be on the same horizontal plane.
      Returns: The newly created generic zone.
    IList<CurveLoop> GetBoundaries()
      Description: Gets the boundaries for the generic zone.
      Returns: The generic zone boundaries.
    GenericZoneDomainData GetDomainData()
      Description: Gets the domain data for the generic zone.
      Returns: Returns a pointer to the base class for specific domain requirements for the generic zone.

--------------------------------------------------------------------------------

[CLASS] GenericZoneDomainData
Full Name: Autodesk.Revit.DB.Analysis.GenericZoneDomainData

Description: A base class for specific domain requirements for a generic zone.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] HVACLoadBuildingType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadBuildingType

Description: The type element of building.
Inherits: HVACLoadType
Implements: IDisposable

  PROPERTIES:
    string BuildingTypeName { get; set; }
      Description: The building type name.
    string ClosingTime { get; set; }
      Description: The closing time of the building type.
    string OpeningTime { get; set; }
      Description: The opening time of the building type.
    double UnoccupiedCoolingSetPoint { get; set; }
      Description: The unoccupied cooling set point of the building type with unit kelvin (K).

  METHODS:
    static HVACLoadBuildingType Create(Document document, string name)
      Description: Creates a building type element.
      @document: The document.
      @name: The building type name.
      Returns: The new building type.
    bool IsNameUnique(string name)
      Description: Determines whether a potential building type name is unique.
      @name: The candidate name.
    static bool IsNameUnique(Document document, string name)
      Description: Determines whether a potential building type name is unique.
      @document: The document.
      @name: The candidate name.
    static bool IsValidTime(string hourMinute)
      Description: Check if the string can be parsed to a valid time for opening time and closing time. A valid string can be "16:30" or "4:30 PM";

--------------------------------------------------------------------------------

[ENUM] HVACLoadConstructionClass
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass

Description: Enumerated type listing options for construction class for HVAC analysis.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - LooseConstruction = 0
    - MediumConstruction = 1
    - TightConstruction = 2
    - NoneConstruction = 3

[ENUM] HVACLoadLoadsReportType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType

Description: Enumerated type listing possible types of reports generated for HVAC loads.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoReport = 0
    - SimpleReport = 1
    - StandardReport = 2
    - DetailedReport = 3

[CLASS] HVACLoadSpaceType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadSpaceType

Description: The type element of space.
Inherits: HVACLoadType
Implements: IDisposable

  PROPERTIES:
    bool IsPlenum { get; }
      Description: True if the space type is plenum.
    string SpaceTypeName { get; set; }
      Description: The space type name.

  METHODS:
    static HVACLoadSpaceType Create(Document document, string name)
      Description: Creates a space type.
      @document: The document.
      @name: The space type name.
      Returns: The new space type.
    bool IsNameUnique(string name)
      Description: Determines whether a potential space type name is unique.
      @name: The candidate name.
    static bool IsNameUnique(Document document, string name)
      Description: Determines whether a potential space type name is unique.
      @document: The document.
      @name: The candidate name.

--------------------------------------------------------------------------------

[CLASS] HVACLoadType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadType

Description: The base class for building type and space type.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double AirChangesPerHour { get; set; }
      Description: The air changes per hour.
    double AreaPerPerson { get; set; }
      Description: The area per person.
    double CoolingSetPoint { get; set; }
      Description: The cooling temperature set point in unit Kelvin (K).
    double DehumidificationSetPoint { get; set; }
      Description: The dehumidification set point as a number between 0 and 1.
    double HeatingSetPoint { get; set; }
      Description: The heating temperature set point in unit Kelvin (K).
    double HumidificationSetPoint { get; set; }
      Description: The humidification set point as a number between 0 and 1.
    double LatentHeatGainPerPerson { get; set; }
      Description: The latent heat gain per person.
    double LightingLoadDensity { get; set; }
      Description: The lighting load density.
    OutdoorAirFlowStandard OutdoorAirFlowStandard { get; set; }
      Description: The outdoor airflow standard.
    double OutdoorAirPerArea { get; set; }
      Description: The outdoor air per area.
    double OutdoorAirPerPerson { get; set; }
      Description: The outdoor air per person.
    double PlenumLighting { get; set; }
      Description: The percentage of plenum lighting contribution.
    double PowerLoadDensity { get; set; }
      Description: The power load density.
    double SensibleHeatGainPerPerson { get; set; }
      Description: The sensible heat gain per person.

--------------------------------------------------------------------------------

[CLASS] MassLevelData
Full Name: Autodesk.Revit.DB.Analysis.MassLevelData

Description: MassLevelData is a conceptual representation of an occupiable floor (Mass Floor) in a conceptual building model. It is defined by associating a particular level with a particular mass element in a Revit project.
Remarks: MassLevelData reports metrics, such as floor areas, related to conceptual space planning. MassLevelData contains information, such as ConceptualConstructionType, used as part of the Conceptual Energy Analytical model. The MassLevel data geometry is determined by combining all the geometry of a mass into a single geometry, and then taking the area of intersection with the level of the MassLevelData.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId ConceptualConstructionId { get; set; }
      Description: The ElementId of the conceptual construction associated with the MassLevelData (Mass Floor).
    bool ConceptualConstructionIsByEnergyData { get; set; }
      Description: Indicates if the ConceptualConstructionType of the MassLevelData (Mass Floor) is synchronized with the EnergyDataSettings or if it overrides those settings.
    ElementId MaterialId { get; set; }
      Description: The ElementId of the visualization material used for the MassLevelData (Mass Floor)
    MassSurfaceDataMaterialType MaterialType { get; set; }
      Description: Indicates if the material used for the graphical appearance is by category or a specific material, or if the material to be used should be taken from the ConceptualConstructionType of the MassLevelData.
    double NExteriorSurfaceArea { get; }
      Description: The exterior surface area of the volume of the mass between the level of this MassLevelData (Mass Floor) to the next in the mass.
    double NLevelFafArea { get; }
      Description: The surface area of the intersection of the MassLevelData's level with the mass geometry.
    double NLevelPerimeter { get; }
      Description: The perimeter of the intersection of the MassLevelData's level with the mass geometry.
    double NVolume { get; }
      Description: The volume of from the level of this MassLevelData (Mass Floor) to the next in the mass.
    ElementId OwningMassId { get; }
      Description: The ElementId of the mass that the MassLevelData (Mass Floor) is associated with.
    string StrUsage { get; set; }
      Description: A String which describes the usage or occupancy type of the level of the MassLevelData.

  METHODS:
    bool IsEmpty()
      Description: Indicates if the MassLevelData (Mass Floor) has a geometrical representation. May not if the level does not intersect the mass geometry.
      Returns: Returns True if MassLevelData is dimensionless, False otherwise.
    static bool IsMassFamilyInstance(Document document, ElementId id)
      Description: Checks if the ElementId is a mass family instance.
      @document: The document.
      @id: The ElementId to be checked.
      Returns: True if the ElementId is a mass family instance, false otherwise.
    bool IsValidConceptualConstructionTypeElement(ElementId id)
      Description: Checks if the ElementId is an acceptable conceptual construction type ElementId for the MassLevelData (Mass Floor).
      @id: The ElementId to be checked.
      Returns: True if the ElementId is an acceptable conceptual construction type ElementId, false otherwise.

--------------------------------------------------------------------------------

[CLASS] MassSurfaceData
Full Name: Autodesk.Revit.DB.Analysis.MassSurfaceData

Description: Holds properties and other data about a face in the MassEnergyAnalyticalModel element.
Remarks: Properties stored in the MassSurfaceData can be used in regeneration by the MassEnergyAnalyticalModel. For example, faces of the MassEnergyAnalyticalModel take their material values from the settings in the MassSurfaceData.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: Area of the references that the MassSurfaceData provides properties for.
    ElementId CategoryIdForConceptualSurfaceType { get; }
      Description: Returns the mass subcategory ElementId used for ConceptualSurfaceType for this MassSurfaceData.
    ElementId ConceptualConstructionId { get; set; }
      Description: The id of the conceptual construction associated with the reference surface.
    bool IsConceptualConstructionByEnergyData { get; set; }
      Description: True when the ConceptualConstructionType id is synchronized to the EnergyDataSettings. False when the ConceptualConstructionType id is overridden for this MassSurfaceData.
    bool IsGlazingShaded { get; set; }
      Description: Indicates if shade geometry is auto-generated on the top edge of auto-generated glazing.
    bool IsSlab { get; }
      Description: Indicates if a floor is a slab.
    bool IsUnderground { get; set; }
      Description: Indicates if the roof, floor, slab, or wall surface reference is underground.
    ElementId MassLevelDataId { get; }
      Description: The MassLevelData used when the surface is horizontal, planar, and at the same height as a MassLevelData related to the same mass as the referenced face.
    ElementId MaterialId { get; set; }
      Description: The visualization material used for the surface for displaying the energy analytical model.
    MassSurfaceDataMaterialType MaterialType { get; set; }
      Description: material type of mass zone
    double PercentageGlazing { get; set; }
      Description: The target percentage of the reference wall surface that is to be covered with automatically generated windows. Revit will use this number when determining the size, shape, and location of automatically generated windows.
    double PercentageSkylights { get; set; }
      Description: The target percentage of the reference roof surface that is to be covered with automatically generated skylights. Revit will use this number when determining the size, shape, and location of automatically generated skylights.
    ElementId ReferenceElementId { get; }
      Description: The ElementId of the element whose face the MassSurfaceData primarily refers to.
    double ShadeDepth { get; set; }
      Description: How far any auto-generated shades should extend from the wall surface.
    double SillHeight { get; set; }
      Description: The height above the level where the bottoms of auto-generated windows will be located.
    double SkylightWidth { get; set; }
      Description: The length dimension to be used for the sides of each individual square skylight produced in the grid of auto-generated skylights.
    MassSurfaceDataSource SurfaceDataSource { get; set; }
      Description: Indicates whether the MassSurfaceData properties are driven by the EnergyDataSettings of the Document or are overridden for the surface.

  METHODS:
    IList<Reference> GetFaceReferences()
      Description: Gets References to the faces that the MassSurfaceData provides properties for.
      Returns: Returns an array of References to Faces that the MassSurfaceData provides properties for.

--------------------------------------------------------------------------------

[ENUM] MassSurfaceDataMaterialType
Full Name: Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType

Description: Indicates how the visualization material for the MassSurfaceData is calculated.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NormalMaterial = 0
    - MaterialByConstruction = -2

[ENUM] MassSurfaceDataSource
Full Name: Autodesk.Revit.DB.Analysis.MassSurfaceDataSource

Description: Indicates whether values for the properties of the MassSurfaceData are synchronized with the EnergyDataSettings of the document or instead, serve as overrides of those settings.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - EnergyData = 0
    - Surface = 1
    - Invalid = -1

[CLASS] MEPAnalyticalModelData
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData

Description: Represents the MEP analytical model data attached to individual element.
Remarks: The MEP analytical model is composed of generic analytical segments and nodes. Each Revit element may have one or more analytical segments. Connected together, these data form a network that is used in the flow and pressure drop calculation.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static MEPAnalyticalModelData GetMEPAnalyticalModelData(Element pElement)
      Description: Gets the MEP analytical model data of the specified element.
      @pElement: The element that owns the MEP analytical model data.
      Returns: The MEP analytical model data of this element, null if not available.
    MEPAnalyticalNode GetNodeById(int nodeId)
      Description: Gets the analytical node with the specified id.
      @nodeId: The node identifier, be aware that this identifier may not be sequentially ordered for all analytical nodes.
      Returns: The returned analytical node.
    MEPAnalyticalNode GetNodeByIndex(int index)
      Description: Gets the specified analytical node.
      @index: The node index number by their storing sequence, starting from 0.
      Returns: The returned analytical node.
    int GetNumberOfNodes()
      Description: Returns the number of analytical nodes.
    int GetNumberOfSegments()
      Description: Returns the number of analytical segments.
      Returns: The total number of
    MEPAnalyticalSegment GetSegmentById(int segmentId)
      Description: Gets the analytical segment with the specified id.
      @segmentId: The segment id to be retrieved. This id is not 0 based.
      Returns: The returned analytical segment.
    MEPAnalyticalSegment GetSegmentByIndex(int index)
      Description: Gets the analytical segment at the specified position.
      @index: The index where the segment is stored. This index is 0 based.
      Returns: The returned analytical segment.
    MEPNetworkSegmentData GetSegmentData(int segmentId)
      Description: Gets the analysis data on the specified segment.
      @segmentId: The segment id to be retrieved.
      Returns: The calculated data of this segment. Be aware that the segment data may be invalid if the calculation failed.
    bool IsValidNodeId(int nodeId)
      Description: Verifies if a valid analytical node id.
      @nodeId: The node id to be verified.
      Returns: True if valid, otherwise false.
    bool IsValidSegmentId(int segmentId)
      Description: Verifies if a valid segment id.
      @segmentId: The segment id to be verified.
      Returns: True if the id is a valid segment id, otherwise false.

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalNode
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalNode

Description: Represents an analytical node of the MEP analytical model.
Implements: IDisposable

  PROPERTIES:
    int Id { get; }
      Description: The identity used in the MEPAnalyticalSegment
    bool IsFlowBlocked { get; }
      Description: Is the flow blocked at this analytical node?
    bool IsFocalNode { get; }
      Description: Is this node a focal point of multiple branches?
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Location { get; }
      Description: The location of this node.

  METHODS:
    void Dispose()
    bool IsSameNode(MEPAnalyticalNode other)
      Description: Verify if this node is connected to the other node and thus represents the same analytical node in the network.
      @other: The other node to be compared.
      Returns: True if two nodes represent the same node of the network. Otherwise false.

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalSegment
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment

Description: Represents an analytical segment of the MEP analytical model.
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: The area of the segment profile.
    double DemandFlow { get; }
      Description: The designed flow value, in ft^3/s.
    ConnectorDomainType DomainType { get; }
      Description: The connector domain type of this segment.
    int EndNode { get; }
      Description: The id of the end analytical node.
    int Id { get; }
      Description: The identity of this segment.
    double InnerDiameter { get; }
      Description: The inner diameter of this segment, in ft. For rectangular or oval profile, this may be the hydraulic diameter.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId RevitElementId { get; }
      Description: The id of the owning Revit element.
    double Roughness { get; }
      Description: The roughness of this segment, in ft.
    MEPAnalyticalSegmentType SegmentType { get; }
      Description: The analytical segment type.
    int StartNode { get; }
      Description: The id of the start analytical node.

  METHODS:
    void Dispose()
    MEPNetworkSegmentId GetNetworkSegmentId()
      Description: Gets the NetworkSegmentId.

--------------------------------------------------------------------------------

[ENUM] MEPAnalyticalSegmentType
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType

Description: The type of analytical segment.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Segment = 1
    - Fitting = 2
    - Pump = 3
    - Loss = 4
    - SourceEquipment = 5

[CLASS] MEPNetworkIterator
Full Name: Autodesk.Revit.DB.Analysis.MEPNetworkIterator

Description: An iterator to traverse the MEP analytical network.
Remarks: The iterator will visit the entire MEP analytical network in the depth-first order. For evert next step, one analytical node and one analytical segment are typically visited. Sometimes an extra node is provided if the iteration reaches the end on one side and restarts at the previous intersect node. Also note that the start step may not contain any segment.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPNetworkIterator(Document pADoc, MEPAnalyticalSegment startSegment)
    new MEPNetworkIterator(Document pADoc, MEPAnalyticalNode startNode, MEPAnalyticalSegment startSegment)
    new MEPNetworkIterator(Document pADoc, MEPAnalyticalModelData seed, ConnectorDomainType eDomain)

  PROPERTIES:
    ElementId CurrentElementId { get; }
      Description: The element id at the current iteration step.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    MEPSystemClassification SystemClassification { get; set; }
      Description: The optional MEP system classification where the iterations are restricted.
    ElementId SystemId { get; set; }
      Description: The optional MEP system element id where the iterations are restricted.

  METHODS:
    void Dispose()
    bool End()
      Description: Checks if the network iteration has completed.
      Returns: True if all analytical segments and nodes have been visited, otherwise false.
    MEPAnalyticalModelData GetAnalyticalModelData()
      Description: Gets the analytical model data at the current iteration step.
      Returns: The retrieved model data.
    MEPAnalyticalNode GetAnalyticalNode()
      Description: Gets the analytical node at the current iteration step.
      Returns: The retrieved node.
    MEPAnalyticalSegment GetAnalyticalSegment()
      Description: Gets the analytical segment at the current iteration step.
      Returns: The retrieved segment, may be null for the first step.
    MEPAnalyticalNode GetOtherAnalyticalNode()
      Description: Gets the other analytical node at the current iteration step.
      Returns: The retrieved analytical node, null if the current iteration step does not have additional analytical node.
    void Next()
      Description: Moves this iterator to the next step of network iteration.
    void Start()
      Description: Gets the first step of network iteration.

--------------------------------------------------------------------------------

[CLASS] MEPNetworkSegmentData
Full Name: Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData

Description: Represents the analysis data for one network segment.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPNetworkSegmentData(MEPNetworkSegmentData other)
    new MEPNetworkSegmentData()

  PROPERTIES:
    double Coefficient { get; }
      Description: The calculated coefficient of this segment, dimensionless.
    double Flow { get; }
      Description: The calculated flow of this segment, in ft^3/s. The positive value means the flow is from the start to the end node, the negative value means opposite direction.
    PipeFlowState FlowState { get; }
      Description: The calculated flow state of this segment.
    double FrictionFactor { get; }
      Description: The calculated friction factor of this segment, dimensionless.
    bool IsCriticalPath { get; }
      Description: Verifies if the segment is on the critical path.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double PressureDrop { get; }
      Description: The calculated pressure drop of this segment, in kg/(ft*s^2).
    double RelativeRoughness { get; }
      Description: The relative roughness of this segment, dimensionless.
    double ReynoldsNumber { get; }
      Description: The Reynolds number of this segment, dimensionless.
    int SectionNumber { get; }
      Description: The section this segment belongs to.
    double Velocity { get; }
      Description: The calculated velocity of this segment, in ft/s.
    double VelocityPressure { get; }
      Description: The calculated velocity pressure of this segment, in kg/(ft*s^2).

  METHODS:
    void Dispose()
    IList<MEPNetworkSegmentId> GetDownstreamSegments()
      Description: Gets all downstream network segments.
      Returns: The list of segments that flow out of this segment.
    IList<MEPNetworkSegmentId> GetUpstreamSegments()
      Description: Gets all upstream network segments.
      Returns: The list of segments that flow into this segment.
    bool IsValid()
      Description: Verified if this segment data has been assigned some valid values afer calculation.
      Returns: True if the segment was assigned valid values, otherwise false.

--------------------------------------------------------------------------------

[CLASS] MEPNetworkSegmentId
Full Name: Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId

Description: Represents a unique identifier for one analytical segment in the network.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPNetworkSegmentId(ElementId idElem, int segment)
    new MEPNetworkSegmentId()

  PROPERTIES:
    ElementId ElementId { get; set; }
      Description: The element id where this analytical segment belongs.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int SegmentId { get; set; }
      Description: The segment identifier.

  METHODS:
    void Dispose()
    bool IsValid()
      Description: Verifies if this is a valid segment id.
      Returns: True if this is a valid segment id, otherwise false.

--------------------------------------------------------------------------------

[ENUM] OutdoorAirFlowStandard
Full Name: Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard

Description: An enumerated type listing all the possible outdoor airflow standard for a space type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ByPeopleAndByArea = 0
    - ByACH = 1
    - MaxByPeople_ByArea = 2
    - MaxByACH_ByPeopleByArea = 3
    - MaxByACH_ByArea_ByPeople = 4

[CLASS] PathOfTravel
Full Name: Autodesk.Revit.DB.Analysis.PathOfTravel

Description: An element which holds a graphical representation of the shortest route between two points in the plane of a floor plan view. The shortest route is calculated to go around model geometry visible in the view. Route calculation is affected by properties of the RouteAnalysisSettings element.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId LineStyle { get; set; }
      Description: The line style of the path.
    XYZ PathEnd { get; set; }
      Description: The end point of the path. The Z coordinate will equal the view's level elevation. To update path calculations, call update.
    XYZ PathMidpoint { get; }
      Description: The midpoint of the path. The Z coordinate will equal the view's level elevation.
    XYZ PathStart { get; set; }
      Description: The start point of the path. The Z coordinate will equal the view's level elevation. To update path calculations, call update.

  METHODS:
    static PathOfTravel Create(View DBView, XYZ pathStart, XYZ pathEnd)
      Description: Creates a new path of travel between two points.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStart: The start point of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnd: The end point of the path. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: The newly created path of travel element, or if no path between the two points is found.
    static PathOfTravel Create(View DBView, XYZ pathStart, XYZ pathEnd, out PathOfTravelCalculationStatus resultStatus)
    static IList<PathOfTravel> CreateMapped(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds)
      Description: Creates multiple new paths of travel by mapping each of a set of start points to each of a set of end points.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStarts: The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnds: The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: The array of newly created path of travel elements, or if no path between the two points is found. The number of elements is the number of start points multiplied by the number of end points. The order of elements corresponds to the order of end and then start points in the argument arrays: s0->e0, s1->e0, ... , s0->e1, s1->e1... etc. There are some additional conditions that are checked and if any condition is true the value is returned: View has crop box active and start or end point lies outside of the crop Start and end points are too close
    static IList<PathOfTravel> CreateMapped(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds, out IList<PathOfTravelCalculationStatus> resultStatus)
    static IList<PathOfTravel> CreateMultiple(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds, out IList<PathOfTravelCalculationStatus> resultStatus)
    static IList<PathOfTravel> CreateMultiple(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds)
      Description: Creates multiple new paths of travel between same size sets of start and end points.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStarts: The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnds: The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: The array of newly created path of travel elements, or if no path between the two points is found. The order of elements corresponds to the order of start/end points in the argument arrays. There are some additional conditions that are checked and if any condition is true the value is returned: View has crop box active and start or end point lies outside of the crop Start and end points are too close
    static IList<XYZ> FindEndsOfShortestPaths(View DBView, IList<XYZ> destinationPoints, IList<XYZ> startPoints)
      Description: For a floor plan view, calculates the paths from each start point to its closest destination and return the path end points.
      @DBView: The floor plan view to use when computing the points.
      @destinationPoints: Destination points. The input Z coordinates are ignored and set to the view's level elevation.
      @startPoints: Start points for which shortest path end points are calculated.
      Returns: End points of paths calculated from each start point to its corresponding closest destination. If a path cannot be calculated the corresponsing end point is set to the corresponding start point.
    static IList<IList<XYZ>> FindShortestPaths(View DBView, IList<XYZ> destinationPoints, IList<XYZ> startPoints)
      Description: For a floor plan view, calculates paths from each start point to its closest destinations. Returns the path, represented by an array of XYZ points.
      @DBView: The floor plan view to use when computing the points.
      @destinationPoints: Destination points. The input Z coordinates are ignored and set to the view's level elevation.
      @startPoints: Start points for which shortest paths are calculated.
      Returns: Array of paths calculated from each start point to its corresponding closest destination. If a path cannot be caculated the corresponsing sub-array is set to an empty array.
    static IList<XYZ> FindStartsOfLongestPathsFromRooms(View DBView, IList<XYZ> destinationPoints)
      Description: For a floor plan view, calculates paths from points inside rooms to the closests of the destinations. Returns the start points of the longest path(s). If multiple paths have the same longest length, returns multiple start points.
      @DBView: The floor plan view to use when computing the points.
      @destinationPoints: Destination points. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: Start points of the paths with longest lengths. The array is empty if there are no valid paths from any points in rooms to any of the destination points.
    IList<Curve> GetCurves()
      Description: Gets the array of curves representing the path of travel.
      Returns: The array of curves.
    IList<XYZ> GetWaypoints()
      Description: return the waypoints set for the Path of Travel
    void InsertWaypoint(XYZ waypoint, int index)
      Description: Insert a waypoint at the specified index
      @waypoint: The waypoint to insert.
      @index: The index to insert the waypoint at.
    static bool IsInRevealObstaclesMode(View DBView)
      Description: Returns current state of Reveal Obstacles mode for the given view.
      @DBView: The view to determine current state of Reveal Obstacles mode for.
      Returns: True if Reveal Obstacles mode is ON for the view, false otherwise.
    void RemoveWaypoint(int index)
      Description: Remove a waypoint.
      @index: The index of the waypoint to remove.
    static PathOfTravelCalculationStatus SetRevealObstaclesMode(View DBView, bool newState)
      Description: Sets Reveal Obstacles mode for the given view.
      @DBView: The view to set Reveal Obstacles mode for.
      @newState: New state of Reveal Obstacles mode to be set for the view.
      Returns: Result status of the operation.
    void SetWaypoint(XYZ waypoint, int index)
      Description: Updates the specified waypoint.
      @waypoint: The new point for the waypoint.
      @index: The index of the waypoint to update.
    PathOfTravelCalculationStatus Update()
      Description: Updates the path of travel by recalculating the path between the original start and end points.
      Returns: The status result of the recalculation.
    static int UpdateMultiple(Document adoc, IList<ElementId> elementsToUpdate, out IList<PathOfTravelCalculationStatus> resultStatus)
    static int UpdateMultiple(Document adoc, IList<ElementId> elementsToUpdate)
      Description: Updates the specified paths of travel by recalculating each path using their original start and end points.
      @adoc: Document of elements to be updated.
      @elementsToUpdate: The list of ElementIdof the paths to update.
      Returns: number of successfully updated elements

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PathOfTravelCalculationServerIds
Full Name: Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServerIds

Description: Ids for external servers implementing path of travel calculations.

  PROPERTIES:
    static Guid DefaultPathOfTravelCalculationGUID { get; }
      Description: GUID to represent the default calculation server id.

--------------------------------------------------------------------------------

[ENUM] PathOfTravelCalculationStatus
Full Name: Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus

Description: An enumerated type containing possible results of the Path of Travel calculation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Success = 0
    - NoPathOfTravel = 1
    - AreaTooLarge = 2
    - SplitView = 3
    - ResultAffectedByCrop = 4
    - StartAndEndPointsTooClose = 5
    - PointOutsideActiveCrop = 6
    - TooMuchGeometry = 7
    - RevealObstaclesModeFailureDataExist = 8
    - RevealObstaclesModeFailureWireframe = 9
    - TemporaryModeFailureDataExist = 10
    - TemporaryModeFailureWireframe = 11

[CLASS] Polyloop
Full Name: Autodesk.Revit.DB.Analysis.Polyloop

Description: A Polyloop represent a planar polygon with ordered points.
Remarks: This class is a loop with straight edges bounding a planar region in space. The loop is represented by an ordered coplanar collection of points forming the vertices of the loop. The loop is composed of straight line segments joining a point in the collection to the succeeding point in the collection. The closing segment is from the last to the first point in the collection. The direction of the loop is in the direction of the line segments. All the points in the polygon defining the poly loop shall be coplanar.
Implements: IDisposable

  PROPERTIES:
    XYZ Centroid { get; }
      Description: The polygon centroid.
    XYZ Direction { get; }
      Description: The direction for the outward normal for this polygon.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    double ComputeArea()
      Description: Gets the area for this polygon.
      Returns: The area for this polygon.
    void Dispose()
    IList<XYZ> GetPoints()
      Description: Gets the array of points in the polygon.
      Returns: The array of points in the polygon.

--------------------------------------------------------------------------------

[CLASS] RouteAnalysisSettings
Full Name: Autodesk.Revit.DB.Analysis.RouteAnalysisSettings

Description: RouteAnalysisSettings is an element which contains project-wide settings for route calculations. The PathOfTravel element uses these settings to calculate a route between two points in a plan view.By default, the route will go around the geometry of all visible model elements which have model geometry in the Route Analysis Zone.The Route Analysis Zone, determined per view, is the space between these two horizontal planes: a top plane vertically offset by AnalysisZoneTopOffset above the view's level and a bottom plane vertically offset by AnalysisZoneBottomOffset ft above the view's level. By default, the route will ignore the following elements: elements outside of the crop region of the view;elements without any model geometry (annotations or view-specific elements);model lines (category OST_Lines);demolished elements;elements displayed in the underlay of the view. There are a few ways to customize Route Analysis on a project-wide basis. You can adjust the Route Analysis Zone using AnalysisZoneTopOffset and AnalysisZoneBottomOffset.You can specify a set of model categories you would like ignored during route calculation. To enable ignoring the set of specified categories, set EnableIgnoredCategoryIds to true. To change the set of ignored categories, use SetIgnoredCategoryIds method and IgnoreImports and IgnorePointClouds properties. To query the set of ignored categories, use GetIgnoredCategoryIds.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double AnalysisZoneBottomOffset { get; set; }
      Description: The bottom plane offset, in ft, of the zone used in route calculation. Default value is 8".
    double AnalysisZoneTopOffset { get; set; }
      Description: The top plane offset, in ft, for the zone used in route calculation. Default value is 6'8".
    bool EnableIgnoredCategoryIds { get; set; }
      Description: When this setting is true, elements with category ids returned by GetIgnoredCategoryIds will be ignored in route calculation. default is true as all elements with the Door Category Id are ignored by default.
    bool IgnoreImports { get; set; }
      Description: If true, import instances are ignored by route calculation. For imports to be ignored, also must be set to true.
    double MinimumLength { get; }
      Description: The constant storing minimum allowed length of path of travel

  METHODS:
    ICollection<ElementId> GetExcludedCategoryIds()
      Description: Returns ElementIds for Category elements which are excluded (not taken into account) by route calculation. These categories are always excluded, regardless of the value. If an excluded category has sub-categories, then the sub-categories will be excluded as well.
      Returns: The ids of Categories which are excluded by route calculation.
    ICollection<ElementId> GetIgnoredCategoryIds()
      Description: Returns ElementIds for Category elements which are ignored (not taken into account) route calculation. To enable ignoring of these categories, must be set to true. If an ignored category has sub-categories, then the sub-categories will be ignored as well.
      Returns: The ids of Categories which are ignored by route calculation. By default, the set contains the Doors Category.
    static RouteAnalysisSettings GetRouteAnalysisSettings(Document cda)
      Description: Returns the RouteAnalysisSettings element for a given document.
      @cda: The document for which to get the RouteAnalysisSettings element.
      Returns: Returns the RouteAnalysisSettings element in project documents or for family documents.
    bool IsLargeGeometryAllowed()
      Description: Returns if large geometry is allowed for path of travel creation or not.
    void SetIgnoredCategoryIds(ICollection<ElementId> categoryIds)
      Description: Sets the ElementIds for Category elements which are ignored by route calculation.
      @categoryIds: The ids of Categories to be ignored by route calculation.

--------------------------------------------------------------------------------

[CLASS] SpatialFieldManager
Full Name: Autodesk.Revit.DB.Analysis.SpatialFieldManager

Description: Exposes all API for an external analysis application. Its primary role is creation, deletion and modification of SpatialFieldElement elements.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool AllowInteractiveSettings { get; set; }
      Description: If true interactive settings dialog and pick deletion are allowed.
    int CurrentMeasurement { get; set; }
      Description: Stores the currently displayed measurement
    XYZ LegendPosition { get; set; }
      Description: Stores current position of analysis results legend element in view
    bool LegendShowConfigurationName { get; set; }
      Description: If true legend contains analysis configuration name.
    bool LegendShowDescription { get; set; }
      Description: If true legend contains analysis description.
    ElementId LegendTextTypeId { get; set; }
      Description: Stores element id of text associated with common (result-independent) part of legend in view.
    int NumberOfMeasurements { get; }
      Description: Stores the total number of measurements
    bool ResultsVisibleInView { get; set; }
      Description: Enables analysis results visibility in the view.
    bool UseRangeForAllMeasurements { get; set; }
      Description: Governs how minimum and maximum values (the data range) are calculated.

  METHODS:
    int AddSpatialFieldPrimitive(Curve curve, Transform trf)
      Description: Creates empty analysis results primitive associated with a curve and a transform.
      @curve: Curve to be associated with the primitive. %curve% does NOT correspond to actual Revit geometry, i.e. it cannot be associated with reference; otherwise the other overload of the method must be used (taking "reference" as the input)
      @trf: Conformal Transform to be applied to %curve%.
      Returns: Unique index of primitive for future references
    int AddSpatialFieldPrimitive(Face face, Transform trf)
      Description: Creates empty analysis results primitive associated with a face and a transform.
      @face: Face to be associated with the primitive
      @trf: Conformal Transform to be applied to %face%
      Returns: Unique index of primitive for future references
    int AddSpatialFieldPrimitive(Reference reference, SpatialFieldPrimitiveHideMode hidingMode)
      Description: Creates an empty analysis results primitive associated with a reference, with the option to control how the reference element is hidden.
      @reference: Reference pointing to the curve or face to be associated with the primitive
      @hidingMode: The mode used to hide the original model element
      Returns: Unique index of primitive for future references
    int AddSpatialFieldPrimitive(Reference reference)
      Description: Creates an empty analysis results primitive associated with a reference.
      @reference: Reference pointing to the curve or face to be associated with the primitive
      Returns: Unique index of primitive for future references
    int AddSpatialFieldPrimitive()
      Description: Creates empty analysis results primitive not associated with any geometry element
      Returns: Unique index of primitive for future references
    void Clear()
      Description: Clear all analysis results managed by this manager object
    static SpatialFieldManager CreateSpatialFieldManager(View view, int numberOfMeasurements)
      Description: Factory method - creates manager object for the given view
      @view: View for which manager object is created or retrieved
      @numberOfMeasurements: Total number of measurements in the calculated results. This number defines the length of value arrays in ValueAtPoint objects
      Returns: Manager object for the view passed in the argument
    AnalysisDisplayLegend GetLegend()
      Description: Returns legend element or NULL
      Returns: The legend element or NULL
    double GetMaximum(int resultIndex, bool rawValue)
      Description: Calculates the maximum value for all primitives
      @resultIndex: Index of result schema
      @rawValue: If true returned value is NOT multiplied by the current result's units multiplier, otherwise it IS
      Returns: Resulting maximum value
    double GetMinimum(int resultIndex, bool rawValue)
      Description: Calculates the minimum value for all primitives
      @resultIndex: Index of result schema
      @rawValue: If true returned value is NOT multiplied by the current result's units multiplier, otherwise it IS
      Returns: Resulting minimum value
    IList<int> GetRegisteredResults()
      Description: Returns an array of indices of all registered results
    AnalysisResultSchema GetResultSchema(int idx)
      Description: Returns result schema by index
      @idx: Index of registered result schema
    static SpatialFieldManager GetSpatialFieldManager(View view)
      Description: Retrieves manager object for the given view or returns NULL
      @view: View for which manager object is retrieved
      Returns: Manager object for the view passed in the argument
    bool IsResultSchemaNameUnique(string name, int resultIndexToSkip)
      Description: Verify the uniqueness of the name among all registered result schemas.
      @name: Name to verify uniqueness of.
      @resultIndexToSkip: Index of result (e.g. to be replaced) which names should not count for uniqueness; negative number means nothing is excluded from comparison.
      Returns: True if name is unique, false otherwise.
    static bool IsTextTypeIdValid(ElementId textTypeId, Document doc)
      Description: Verify if text type id is valid.
      @textTypeId: Text type id to be validated.
      @doc: Document for which %textTypeId% is validated.
      Returns: True if text type id is valid, false otherwise.
    int RegisterResult(AnalysisResultSchema resultSchema)
      Description: Registers result and assigns it a unique result index
      @resultSchema: Result schema to be registered
      Returns: Unique index assigned to the result
    void RemoveSpatialFieldPrimitive(int idx)
      Description: Removes analysis results primitive identified by the unique index
      @idx: Unique index identifying the primitive
    void SetMeasurementDescriptions(IList<string> measurementDescriptions)
      Description: Sets Descriptions for all measurements
      @measurementDescriptions: Array of measurement descriptions. The lengths of the array must be equal to the number of measurements set during creation of SpatialFieldManager.
    void SetMeasurementNames(IList<string> measurementNames)
      Description: Sets Names for all measurements
      @measurementNames: Array of measurement names. All names in the array must be unique. The lengths of the array must be equal to the number of measurements set during creation of SpatialFieldManager.
    void SetResultSchema(int idx, AnalysisResultSchema resultSchema)
      Description: Sets a new value for an existing result schema in the result registry
      @idx: Index of registered result schema
      @resultSchema: Result schema replacing the existent one
    void UpdateSpatialFieldPrimitive(int idx, FieldDomainPoints fieldDomainPoints, FieldValues fieldValues, int resultIndex)
      Description: Populates analysis results data (or replaces the existing data) in the existing primitive identified by the unique index
      @idx: Unique index identifying the primitive
      @fieldDomainPoints: Set of domain points. If the new set of domain points is supplied, all previously supplied domain points and field values for all results are removed from the primitive. If %fieldDomainPoints% is only fieldValues are updated
      @fieldValues: Set of data values. Number of values in fieldValues must coincide with the number of points in fieldDomainPoints
      @resultIndex: Unique index identifying the result schema

--------------------------------------------------------------------------------

[ENUM] SpatialFieldPrimitiveHideMode
Full Name: Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode

Description: Defines modes which can be used by a SpatialFieldPrimitive to hide the original referenced element.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - HideNone = 1
    - HideOnlyReference = 2
    - HideWholeElement = 3

[CLASS] SystemsAnalysisOptions
Full Name: Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions

Description: Contains the options for systems analysis.
Implements: IDisposable

  CONSTRUCTORS:
    new SystemsAnalysisOptions()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string OutputFolder { get; set; }
      Description: The path of the output folder for systems analysis.
    string WeatherFile { get; set; }
      Description: The file name of the EnergyPlus weather (*.epw).
    string WorkflowFile { get; set; }
      Description: The file name of the EnergyPlus workflow script.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] SystemsAnalysisReportStyle
Full Name: Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle

Description: The report style of systems analysis.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Detailed = 0
    - Loads = 1

[CLASS] ValueAtPoint
Full Name: Autodesk.Revit.DB.Analysis.ValueAtPoint

Description: Stores values at one domain point. Each value corresponds to a "measurement" for which this value was calculated.
Inherits: ValueAtPointBase
Implements: IDisposable

  CONSTRUCTORS:
    new ValueAtPoint(ValueAtPoint otherObject)
    new ValueAtPoint(IList<double> values)

--------------------------------------------------------------------------------

[CLASS] VectorAtPoint
Full Name: Autodesk.Revit.DB.Analysis.VectorAtPoint

Description: Stores vectors at one domain point. Each vector corresponds to a "measurement" for which this vector was calculated.
Inherits: ValueAtPointBase
Implements: IDisposable

  CONSTRUCTORS:
    new VectorAtPoint(VectorAtPoint otherObject)
    new VectorAtPoint(IList<XYZ> vectors)

--------------------------------------------------------------------------------

[CLASS] ViewSystemsAnalysisReport
Full Name: Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport

Description: Represents a report instance of the systems analysis.
Inherits: View
Implements: IDisposable

  PROPERTIES:
    DateTime AnalysisDateAndTime { get; }
      Description: Identifies the analysis date and time when it was requested.
    SystemsAnalysisReportStyle ReportStyle { get; set; }
      Description: The report style that specifies the display content.
    string SystemsAnalysisOutputFolder { get; }
      Description: The full path of the output folder for systems analysis
    string SystemsAnalysisWorkflowFile { get; }
      Description: The full path name of the original system analysis workflow file.
    string WeatherFile { get; }
      Description: The full path name of the weather file used for the systems analysis.

  METHODS:
    static void CancelSystemsAnalysis(Document document, ElementId reportElement)
      Description: Cancels the systems analysis based on the report element id.
      @document: The document where the report element existed.
      @reportElement: The report element that identifies the analysis.
    static ViewSystemsAnalysisReport Create(Document document, string viewName)
      Description: Creates a new view for the systems analysis report.
      @document: The document where the view is to be created.
      @viewName: The name of the new report view.
      Returns: The newly created view instance, or if the operation fails.
    static ElementId GetLatestSystemsAnalysisReport(Document document)
      Description: Gets the latest report of systems analysis.
    string GetReportContent()
      Description: Gets the report content in this view.
      Returns: The content of the report as displayed in the view, or the referenced file name.
    bool IsAnalysisCompleted()
      Description: Indicates if the background systems analysis has completed or not.
      Returns: True if completed, otherwise false.
    void RequestSystemsAnalysis(SystemsAnalysisOptions options)
      Description: Requests a new systems analysis in the background.
      @options: The additional options to run systems analysis. If empty, use the default value in the view element. The request may download the weather file at current site location if not specified in the options.

--------------------------------------------------------------------------------


