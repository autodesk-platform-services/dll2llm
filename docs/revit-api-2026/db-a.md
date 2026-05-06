# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[CLASS] ACADExportOptions
Full Name: Autodesk.Revit.DB.ACADExportOptions
Description: The base class for options used to export DWG and DXF format files.
Inherits: BaseExportOptions

  PROPERTIES:
    ACAObjectPreference ACAPreference { get; set; }
      Description: The preferred way to generate geometry of ACA objects. Default value is ACAObjectPreference.Object.
    bool ExportingAreas { get; set; }
      Description: True to export area and room geometry, false otherwise. Default value is false.
    SolidGeometry ExportOfSolids { get; set; }
      Description: The mode used to export solids in 3D views. Default value is SolidGeometry.Polymesh.
    ACADVersion FileVersion { get; set; }
      Description: ACADVersion::Default Default value is ACADVersion.Default.
    Color HatchBackgroundColor { get; set; }
      Description: The color that will be set as hatch backgound color on the exported hatch. This color will be used only if useHatchBackgroundColor is true. default value is white
    LineScaling LineScaling { get; set; }
      Description: The scaling mode for the line type. Default value is LineScaling.ViewScale.
    string LinetypesFileName { get; set; }
      Description: The custom linetype file name (*.lin). Default value is empty.
    bool MarkNonplotLayers { get; set; }
      Description: If true and the nonplot layer suffix is not empty, all layers whose names contain that suffix will be marked as non-plot.
    string NonplotSuffix { get; set; }
      Description: If the MarkNonplotLayers attribute is set to true, all layers with names containing this suffix will be marked as non-plot. No action will be performed if the suffix is empty.
    bool SharedCoords { get; set; }
      Description: True to use the shared coordinate system's origin, false to use the project origin. Default value is false.
    ExportUnit TargetUnit { get; set; }
      Description: The target unit type. Default value is ExportUnit.Default.
    TextTreatment TextTreatment { get; set; }
      Description: The text treatment. Deault value is TextTreatment.Exact.
    bool UseHatchBackgroundColor { get; set; }
      Description: Indicates if hatch background color will be used or not. default value is false.

--------------------------------------------------------------------------------

[ENUM] ACADVersion
Full Name: Autodesk.Revit.DB.ACADVersion
Description: An enumerated type listing available AutoCAD versions, into which a file may be exported.
Inherits: Enum

  Values:
    - R2007 = 3
    - R2010 = 16
    - R2013 = 22
    - Default = 28
    - Default = 28

--------------------------------------------------------------------------------

[ENUM] ACAObjectPreference
Full Name: Autodesk.Revit.DB.ACAObjectPreference
Description: An enumerated type listing possible ways to generate geometry of an ACA object Revit object parameters used to generate geometry of the exported ACA object. Revit object geometry is used to generate geometry of the exported ACA object. That may produce better geometric fidelity in some cases.
Inherits: Enum

  Values:
    - Object = 0
    - Geometry = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] AdaptiveComponentFamilyUtils
Full Name: Autodesk.Revit.DB.AdaptiveComponentFamilyUtils
Description: An interface for Adaptive Component Instances.

  METHODS:
    static int GetNumberOfAdaptivePoints(Family family)
      Description: Gets number of Adaptive Point Elements in Adaptive Component Family.
      @family: The Family
      Returns: Number of Adaptive Point Element References in Adaptive Component Family.
      Throws ArgumentException: The Family family is not an Adaptive Component Family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static int GetNumberOfPlacementPoints(Family family)
      Description: Gets number of Placement Point Elements in Adaptive Component Family.
      @family: The Family
      Returns: Number of Adaptive Placement Point Element References in Adaptive Component Family.
      Throws ArgumentException: The Family family is not an Adaptive Component Family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static int GetNumberOfShapeHandlePoints(Family family)
      Description: Gets number of Shape Handle Point Elements in Adaptive Component Family.
      @family: The Family
      Returns: Number of Adaptive Shape Handle Point Element References in the Adaptive Component Family.
      Throws ArgumentException: The Family family is not an Adaptive Component Family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static int GetPlacementNumber(Document doc, ElementId refPointId)
      Description: Gets Placement number of an Adaptive Placement Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      Returns: Placement number of the Adaptive Placement Point.
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family. -or- The ElementId refPointId does not correspond to an Adaptive Placement Point.
      Throws ArgumentNullException: A non-optional argument was null
    static AdaptivePointConstraintType GetPointConstraintType(Document doc, ElementId refPointId)
      Description: Gets constrain type of an Adaptive Shape Handle Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      Returns: Constraint type of the Adaptive Shape Handle Point.
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family. -or- The ElementId refPointId does not correspond to a Shape Handle Point.
      Throws ArgumentNullException: A non-optional argument was null
    static AdaptivePointOrientationType GetPointOrientationType(Document doc, ElementId refPointId)
      Description: Gets orientation type of an Adaptive Placement Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      Returns: Orientation type of Adaptive Placement Point.
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family. -or- The ElementId refPointId does not correspond to an Adaptive Placement Point.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAdaptiveComponentFamily(Family family)
      Description: Verifies if the Family is an Adaptive Component Family.
      @family: The Family
      Returns: True if the Family is an Adaptive Component Family.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAdaptivePlacementPoint(Document doc, ElementId refPointId)
      Description: Verifies if the Reference Point is an Adaptive Placement Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      Returns: True if the Point is an Adaptive Placement Point.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAdaptivePoint(Document doc, ElementId refPointId)
      Description: Verifies if the Reference Point is an Adaptive Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      Returns: True if the Point is an Adaptive Point (Placement Point or Shape Handle Point).
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAdaptiveShapeHandlePoint(Document doc, ElementId refPointId)
      Description: Verifies if the Reference Point is an Adaptive Shape Handle Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      Returns: True if the Point is an Adaptive Shape Handle Point.
      Throws ArgumentNullException: A non-optional argument was null
    static void MakeAdaptivePoint(Document doc, ElementId refPointId, AdaptivePointType type)
      Description: Makes Reference Point an Adaptive Point or makes an Adaptive Point a Reference Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      @type: The Adaptive Point Type
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation failed.
    static void SetPlacementNumber(Document doc, ElementId refPointId, int placementNumber)
      Description: Sets Placement Number of an Adaptive Placement Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      @placementNumber: Placement number of the Adaptive Placement Point.
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family. -or- The ElementId refPointId does not correspond to an Adaptive Placement Point. -or- The number placementNumber is out of range.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static void SetPointConstraintType(Document doc, ElementId refPointId, AdaptivePointConstraintType constraintType)
      Description: Sets constrain type of an Adaptive Shape Handle Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      @constraintType: Constraint type of the Adaptive Shape Handle Point.
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family. -or- The ElementId refPointId does not correspond to a Shape Handle Point.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation failed.
    static void SetPointOrientationType(Document doc, ElementId refPointId, AdaptivePointOrientationType orientationType)
      Description: Sets orientation type of an Adaptive Placement Point.
      @doc: The Document
      @refPointId: The ReferencePoint id
      @orientationType: Orientation type of the Adaptive Placement Point.
      Throws ArgumentException: The ElementId refPointId does not correspond to a valid ReferencePoint. -or- The Element corresponding to ElementId refPointId does not belong to an Adaptive Family. -or- The ElementId refPointId does not correspond to an Adaptive Placement Point.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation failed.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] AdaptiveComponentInstanceUtils
Full Name: Autodesk.Revit.DB.AdaptiveComponentInstanceUtils
Description: An interface for Adaptive Component Instances.

  METHODS:
    static FamilyInstance CreateAdaptiveComponentInstance(Document doc, FamilySymbol famSymb)
      Description: Creates a FamilyInstance of Adaptive Component Family.
      @doc: The Document
      @famSymb: The FamilySymbol
      Returns: The Family Instance
      Throws ArgumentException: The element famSymb was not found in the given document. -or- The Symbol famSymb is not an Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Unable to create adaptive component instance.
    static IList<ElementId> GetInstancePlacementPointElementRefIds(FamilyInstance famInst)
      Description: Gets Placement Adaptive Point Element Ref ids to which the instance geometry adapts.
      @famInst: The FamilyInstance.
      Returns: The Placement Adaptive Point Element Ref ids to which the instance geometry adapts.
      Throws ArgumentException: The FamilyInstance famInst is not an Adaptive Family Instance. -or- The FamilyInstance famInst does not have an Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static IList<ElementId> GetInstancePointElementRefIds(FamilyInstance famInst)
      Description: Gets Adaptive Point Element Ref ids to which the instance geometry adapts.
      @famInst: The FamilyInstance.
      Returns: The Adaptive Point Element Ref ids to which the instance geometry adapts.
      Throws ArgumentException: The FamilyInstance famInst is not an Adaptive Family Instance. -or- The FamilyInstance famInst does not have an Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static IList<ElementId> GetInstanceShapeHandlePointElementRefIds(FamilyInstance famInst)
      Description: Gets Shape Handle Adaptive Point Element Ref ids to which the instance geometry adapts.
      @famInst: The FamilyInstance
      Returns: The Shape Handle Adaptive Point Element Ref ids to which the instance geometry adapts.
      Throws ArgumentException: The FamilyInstance famInst is not an Adaptive Family Instance. -or- The FamilyInstance famInst does not have an Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.
    static bool HasAdaptiveFamilySymbol(FamilyInstance famInst)
      Description: Verifies if a FamilyInstance has an Adaptive Family Symbol.
      @famInst: The FamilyInstance
      Returns: True if the FamilyInstance has an Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAdaptiveComponentInstance(FamilyInstance famInst)
      Description: Verifies if a FamilyInstance is an Adaptive Component Instance.
      @famInst: The FamilyInstance
      Returns: True if the FamilyInstance has an Adaptive Component Instances.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAdaptiveFamilySymbol(FamilySymbol famSymb)
      Description: Verifies if a FamilySymbol is a valid Adaptive Family Symbol.
      @famSymb: The FamilySymbol
      Returns: True if the FamilySymbol is a valid Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsInstanceFlipped(FamilyInstance famInst)
      Description: Gets the value of the flip parameter on the adaptive instance.
      @famInst: The FamilyInstance
      Returns: True if the instance is flipped.
      Throws ArgumentException: The FamilyInstance famInst is not an Adaptive Family Instance. -or- The FamilyInstance famInst does not have an Adaptive Family Symbol.
      Throws ArgumentNullException: A non-optional argument was null
    static void MoveAdaptiveComponentInstance(FamilyInstance famInst, Transform trf, bool unHost)
      Description: Moves Adaptive Component Instance by the specified transformation.
      @famInst: The FamilyInstance
      @trf: The Transformation
      @unHost: True if the move should disassociate the Point Element Refs from their hosts. False if the Point Element Refs remain hosted.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: trf is not a rigid body transformation.
      Throws InvalidOperationException: Unable to move the adaptive component instance.
    static void SetInstanceFlipped(FamilyInstance famInst, bool flip)
      Description: Sets the value of the flip parameter on the adaptive instance.
      @famInst: The FamilyInstance
      @flip: The flip flag
      Throws ArgumentException: The FamilyInstance famInst is not an Adaptive Family Instance. -or- The FamilyInstance famInst does not have an Adaptive Family Symbol. -or- The FamilyInstance famInst cannot be flipped or unflipped.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation failed.

--------------------------------------------------------------------------------

[ENUM] AdaptivePointConstraintType
Full Name: Autodesk.Revit.DB.AdaptivePointConstraintType
Description: An enumerated type containing possible constraint types for Adaptive Points.
Inherits: Enum

  Values:
    - None = 0
    - Plane_YZ = 1
    - Plane_ZX = 2
    - Plane_XY = 3
    - Axis_X = 4
    - Axis_Y = 5
    - Axis_Z = 6

--------------------------------------------------------------------------------

[ENUM] AdaptivePointOrientationType
Full Name: Autodesk.Revit.DB.AdaptivePointOrientationType
Description: An enumerated type containing possible orientation types for Adaptive Points.
Remarks: The default orientation of adaptive points is AdaptivePointOrientationType.ToInstance.All the items of this enumerated type were renamed for Revit 2016 to better align the names with the corresponding text in the Revit UI. The numeric values of the items weren't modified, allowing existing applications to work. However, to be able to rebuild an application, all point orientations need to be changed to their respective new names.
Inherits: Enum

  Values:
    - ToHost = 2
    - ToHostAndLoopSystem = 3
    - ToGlobalZthenHost = 6
    - ToGlobalXYZ = 7
    - ToInstanceZthenHost = 8
    - ToInstance = 9

--------------------------------------------------------------------------------

[ENUM] AdaptivePointType
Full Name: Autodesk.Revit.DB.AdaptivePointType
Description: An enumerated type containing possible types for Adaptive Points.
Inherits: Enum

  Values:
    - ReferencePoint = 0
    - PlacementPoint = 1
    - ShapeHandlePoint = 2

--------------------------------------------------------------------------------

[CLASS] AddInId
Full Name: Autodesk.Revit.DB.AddInId
Description: Identifies an AddIn registered with Revit
Implements: IDisposable

  CONSTRUCTORS:
    new AddInId(Guid val)
      Description: creates an AddInId object with a given GUID
      @val: GUID value

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    string GetAddInName()
      Description: name of addin associated with this AddInId Attempts to obtain the name from loaded Third Party AddIns
      Returns: name of addin
    string GetAddInNameFromDocument(Document aDoc)
      Description: name of application associated with this ApplicationId First attempts to obtain the name from AddInIds stored in the document. If unsuccessful, attempts to obtain the name from loaded Third Party AddIns.
      @aDoc: target document
      Returns: name of application
      Throws ArgumentNullException: A non-optional argument was NULL
    Guid GetGUID()
      Description: value of the AddInId as a GUID
      Returns: GUID value of the AddInId

--------------------------------------------------------------------------------

[ENUM] AllowedValues
Full Name: Autodesk.Revit.DB.AllowedValues
Description: A range of allowed values.
Inherits: Enum

  Values:
    - NonNegative = 0
    - All = 1
    - Positive = 2

--------------------------------------------------------------------------------

[CLASS] AlphanumericRevisionSettings
Full Name: Autodesk.Revit.DB.AlphanumericRevisionSettings
Description: Contains settings that apply to Revisions with the Alphanumeric RevisionNumberType.
Implements: IDisposable

  CONSTRUCTORS:
    new AlphanumericRevisionSettings(IList<string> sequence, string prefix, string suffix)
      Description: Constructs an AlphanumericRevisionSettings object.
      @sequence: The custom sequence to be used as numbers for revisions with the Alphanumeric RevisionNumberType.If there are more alphanumeric revisions than there are strings in the sequence, subsequent alphanumeric revisions will be assigned duplicated characters. For example, if the sequence provided were ["X", "Y"], the first alphanumeric revision would be shown as "X", the second as "Y", the third as "XX", then "YY", "XXX", etc.
      @prefix: The prefix string for each revision number in the sequence.
      @suffix: The suffix string for each revision number in the sequence.
      Throws ArgumentException: Input sequence contains invalid entries.
      Throws ArgumentNullException: A non-optional argument was null
    new AlphanumericRevisionSettings()
      Description: Constructs an AlphanumericRevisionSettings with a simple, default sequence.
    new AlphanumericRevisionSettings(AlphanumericRevisionSettings other)
      Description: Constructs a new copy of the input AlphanumericRevisionSettings object.
      Throws ArgumentException: other is not a valid AlphanumericRevisionSettings.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Prefix { get; set; }
      Description: The prefix string that will be prepended to the number of each revision with Alphanumeric RevisionNumberingType.
    string Suffix { get; set; }
      Description: The suffix string that will be appended to the number of each revision with Alphanumeric RevisionNumberingType.

  METHODS:
    void Dispose()
    IList<string> GetSequence()
      Description: Gets a list containing the strings to be used as the numbering sequence for revisions with the Alphanumeric RevisionNumberType.
    bool IsEqual(AlphanumericRevisionSettings other)
      Description: Determines whether a specified AlphanumericRevisionSettings is the same as 'this'.
      @other: The AlphanumericRevisionSettings object to be compared with 'this'.
      Returns: True, if two AlphanumericRevisionSettings are the same.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValid()
      Description: Determines whether the AlphanumericRevisionSettings object is in a valid state.
      Returns: True if the settings are valid.
    void SetSequence(IList<string> sequence)
      Description: Sets the sequence of strings to be used as numbers for revisions with the Alphanumeric RevisionNumberType.
      @sequence: The sequence. The sequence strings cannot contain commas.
      Throws ArgumentException: Input sequence contains invalid entries.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] AlternateUnits
Full Name: Autodesk.Revit.DB.AlternateUnits
Description: An enumerated type listing the locations where Alternate units may be displayed in dimensions.
Inherits: Enum

  Values:
    - None = 0
    - Right = 1
    - Below = 2

--------------------------------------------------------------------------------

[ENUM] AnalyzesAsType
Full Name: Autodesk.Revit.DB.AnalyzesAsType
Description: This enum class is used for the BuiltInParameter STRUCTURAL_ANALYZES_AS.
Inherits: Enum

  Values:
    - AA_Hanger = 0
    - AA_Gravity = 1
    - AA_Lateral = 2
    - AA_SlabOneWay = 3
    - AA_Mat = 4
    - AA_SlabOnGrade = 5
    - AA_Not_For_Analysis = 6
    - AA_SlabTwoWay = 7
    - AA_GravityLateral = 8

--------------------------------------------------------------------------------

[CLASS] AngularDimension
Full Name: Autodesk.Revit.DB.AngularDimension
Description: An object that represents an Angular Dimension within the Revit project.
Inherits: Dimension

  METHODS:
    static AngularDimension Create(Document document, View dbView, Arc arc, IList<Reference> references, DimensionType dimensionStyle)
      Description: Creates a new instance of an Angular Dimension element within the project.
      @document: The document where new Angular Dimension is created.
      @dbView: The view in which the Angular Dimension will appear.
      @arc: Arc for the Angular Dimension.
      @references: The references which the Angular Dimension will witness.
      @dimensionStyle: Dimension Style.
      Returns: The newly created Angular Dimension instance, or if the operation fails.
      Throws ArgumentException: References should be: at least two, non parallel and rays of the arc passed.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void SetAngularRadius(double radius)
      Description: Set radius of an Angular Dimension arc. The new radius of the arc.
      Throws ArgumentOutOfRangeException: The given value for radius must be non-negative.

--------------------------------------------------------------------------------

[CLASS] AnnotationMultipleAlignmentUtils
Full Name: Autodesk.Revit.DB.AnnotationMultipleAlignmentUtils
Description: A helper providing functionality related to elements that can be aligned to one another. An element that wants to be able to align to other alignable elements using the Multiple Alignment buttons should implement this helper class.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static bool ElementSupportsMultiAlign(Element element)
      Description: Returns true if element can be aligned to other similar elements.
      @element: The element to align.
      Returns: True if the element can be aligned using the multiple alignment commands, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<XYZ> GetAnnotationOutlineWithoutLeaders(Element element)
      Description: Gets the four corners of the alignable element in model space without its leaders.
      @element: The element for which we are retrieving the outline corners.
      Returns: The array of the four corner points for the alignable element.
      Throws ArgumentException: The element element does not support multiple alignment behavior. -or-
      Throws ArgumentNullException: A non-optional argument was null
    static void MoveWithAnchoredLeaders(Element element, XYZ moveVec)
      Description: Moves the element while keeping the leader end points anchored.
      @element: The element to be moved.
      @moveVec: The move vector for translating the element.
      Throws ArgumentException: The element element does not support multiple alignment behavior.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to move element.

--------------------------------------------------------------------------------

[CLASS] AnnotationSymbol
Full Name: Autodesk.Revit.DB.AnnotationSymbol
Description: This object represents a symbol of the Generic Annotation.
Inherits: FamilyInstance

  PROPERTIES:
    AnnotationSymbolType AnnotationSymbolType { get; set; }
      Description: The AnnotationSymbol style of this AnnotationSymbol.

  METHODS:
    void addLeader()
      Description: add a leader to this annotation symbol.
    AnnotationSymbol duplicate()
      Description: Duplicate this annotation symbol.
      Returns: Pointer to the new annotation symbol.
    IList<Leader> GetLeaders()
      Description: Returns a collection of leaders currently attached to the annotation.
    void removeLeader()
      Description: remove a leader of this annotation symbol.

--------------------------------------------------------------------------------

[CLASS] AnnotationSymbolType
Full Name: Autodesk.Revit.DB.AnnotationSymbolType
Description: An object that represents an annotation style.
Inherits: FamilySymbol

--------------------------------------------------------------------------------

[CLASS] APIObject
Full Name: Autodesk.Revit.DB.APIObject
Description: Supports all objects in the Autodesk Revit API hierarchy.
Implements: IDisposable

  PROPERTIES:
    bool IsReadOnly { get; }
      Description: Identifies if the object is read-only or modifiable.

  METHODS:
    void Dispose()
      Description: Causes the object to release immediately any resources it may be utilizing.

--------------------------------------------------------------------------------

[CLASS] AppearanceAssetElement
Full Name: Autodesk.Revit.DB.AppearanceAssetElement
Description: An element that contains a rendering asset used as a portion of a material definition.
Inherits: Element

  METHODS:
    static AppearanceAssetElement Create(Document document, string name, Asset asset)
      Description: Creates a new AppearanceAssetElement from an existing rendering asset.
      @document: The document in which to create the AppearanceAssetElement.
      @name: The name of the AppearanceAssetElement.
      @asset: The rendering asset of the element.
      Returns: The new AppearanceAssetElement.
      Throws ArgumentException: name is an empty string. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as an appearance asset name.
      Throws ArgumentNullException: A non-optional argument was null
    AppearanceAssetElement Duplicate(string name)
      Description: Duplicates the appearance asset element.
      @name: Name of the new appearance asset element - this name must be correctly structured for Revit use and not duplicate the name of another appearance asset in the document.
      Returns: The new AppearanceAssetElement.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as an appearance asset name.
      Throws ArgumentNullException: A non-optional argument was null
    static AppearanceAssetElement GetAppearanceAssetElementByName(Document doc, string name)
      Description: Gets an AppearanceAssetElement by name.
      @doc: Document containing the AppearanceAssetElement.
      @name: Name of the AppearanceAssetElement.
      Returns: The AppearanceAssetElement with the given name, or if this element does not exist.
      Throws ArgumentNullException: A non-optional argument was null
    Asset GetRenderingAsset()
      Description: Gets the rendering asset for the appearance asset element.
      Returns: The rendering asset held by this appearance asset element.
    void SetRenderingAsset(Asset asset)
      Description: Sets the rendering asset for the appearance asset element.
      @asset: The new rendering asset. It should be an appearance asset.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The asset is not an appearance asset.

--------------------------------------------------------------------------------

[CLASS] Arc
Full Name: Autodesk.Revit.DB.Arc
Description: A circular arc.
Remarks: The arc lies in the plane defined by center and normal.
Inherits: Curve

  PROPERTIES:
    XYZ Center { get; }
      Description: Returns the center of the arc.
    XYZ Normal { get; }
      Description: Returns the normal to the plane in which the arc is defined.
    double Radius { get; }
      Description: Returns the radius of the arc.
    XYZ XDirection { get; }
      Description: Returns the X direction.
    XYZ YDirection { get; }
      Description: Returns the Y direction.

  METHODS:
    static Arc Create(XYZ end0, XYZ end1, XYZ pointOnArc)
      Description: Creates a new geometric arc object based on three points.
      @end0: The start point of the arc.
      @end1: The end point of the arc.
      @pointOnArc: A point on the arc.
      Returns: The new arc.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentsInconsistentException: The vectors end0 and end1 are coincident. -or- The vectors end0 and pointOnArc are coincident. -or- The vectors end1 and pointOnArc are coincident. -or- Cannot create an arc. -or- Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).
    static Arc Create(Plane plane, double radius, double startAngle, double endAngle)
      Description: Creates a new geometric arc object based on plane, radius, and angles.
      @plane: The plane which the arc resides. The plane's origin is the center of the arc.
      @radius: The radius of the arc.
      @startAngle: The start angle of the arc (in radians).
      @endAngle: The end angle of the arc (in radians).
      Returns: The new arc.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentOutOfRangeException: The given value for radius must be greater than 0 and no more than 30000 feet.
      Throws ArgumentsInconsistentException: Start angle must be less than end angle. -or- Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).
    static Arc Create(XYZ center, double radius, double startAngle, double endAngle, XYZ xAxis, XYZ yAxis)
      Description: Creates a new geometric arc object based on center, radius, unit vectors, and angles.
      @center: The center of the arc.
      @radius: The radius of the arc.
      @startAngle: The start angle of the arc (in radians).
      @endAngle: The end angle of the arc (in radians).
      @xAxis: The x axis to define the arc plane. Must be normalized.
      @yAxis: The y axis to define the arc plane. Must be normalized.
      Returns: The new arc.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentOutOfRangeException: xAxis is not length 1.0. -or- yAxis is not length 1.0. -or- The given value for radius must be between 0 and 30000 feet.
      Throws ArgumentsInconsistentException: The vectors xAxis and yAxis are not perpendicular. -or- Start angle must be less than end angle. -or- Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).

--------------------------------------------------------------------------------

[CLASS] ArcLengthDimension
Full Name: Autodesk.Revit.DB.ArcLengthDimension
Description: An object that represents an ArcLengthDimension within the Revit Project.
Inherits: AngularDimension

  METHODS:
    static ArcLengthDimension Create(Document document, View dbView, Arc arc, Reference ArcRef, IList<Reference> references)
      Description: Creates a new instance of an Arc Length Dimension element within the project.
      @document: The document where the new Arc Length Dimension is created.
      @dbView: The view in which the Arc Length Dimension will appear.
      @arc: The Arc of the annotation itself
      @ArcRef: Reference for the arc to be measured
      @references: The segments which the Arc Length Dimension will witness.
      Returns: The newly created Arc Length Dimension instance, or if the operation fails.
      Throws ArgumentException: References should be: at least two and intersecting the ends of the arc passed.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] Area
Full Name: Autodesk.Revit.DB.Area
Description: Provides access to the area topology in Autodesk Revit.
Remarks: The area object can be queried for its boundary for use in space planning tools.
Inherits: SpatialElement

  PROPERTIES:
    AreaScheme AreaScheme { get; }
      Description: The area scheme.
    bool IsGrossInterior { get; }
      Description: The boolean value that indicates whether the area is gross interior.

--------------------------------------------------------------------------------

[ENUM] AreaElemType
Full Name: Autodesk.Revit.DB.AreaElemType
Description: An enumerated type to store type of AreaElement.
Inherits: Enum

  Values:
    - GrossArea = 0
    - BOMAArea = 1

--------------------------------------------------------------------------------

[CLASS] AreaFilter
Full Name: Autodesk.Revit.DB.AreaFilter
Description: A filter used to match areas.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new AreaFilter()
      Description: Constructs a filter which matches only areas.

--------------------------------------------------------------------------------

[CLASS] AreaScheme
Full Name: Autodesk.Revit.DB.AreaScheme
Description: The area scheme associated with a particular area plan.
Inherits: Element

  PROPERTIES:
    bool IsGrossBuildingArea { get; }
      Description: Indicates if the area scheme is a Gross Building Area scheme.

--------------------------------------------------------------------------------

[CLASS] AreaTag
Full Name: Autodesk.Revit.DB.AreaTag
Description: Provides access to the area topology in Autodesk Revit.
Remarks: The areaTag object can be queried for its boundary for use in space planning tools.
Inherits: SpatialElementTag

  PROPERTIES:
    Area Area { get; }
      Description: The area that the tag is associated with.
    AreaTagType AreaTagType { get; set; }
      Description: The tag type.

--------------------------------------------------------------------------------

[CLASS] AreaTagFilter
Full Name: Autodesk.Revit.DB.AreaTagFilter
Description: A filter used to match area tags.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new AreaTagFilter()
      Description: Constructs a filter which matches only areas.

--------------------------------------------------------------------------------

[CLASS] AreaTagType
Full Name: Autodesk.Revit.DB.AreaTagType
Description: An object that represents an Area Tag style.
Inherits: FamilySymbol

--------------------------------------------------------------------------------

[CLASS] AreaVolumeSettings
Full Name: Autodesk.Revit.DB.AreaVolumeSettings
Description: This class provides access to settings related to volume and area computations.
Inherits: Element

  PROPERTIES:
    bool ComputeVolumes { get; set; }
      Description: True to enable volume computation. False to disable it.

  METHODS:
    static AreaVolumeSettings GetAreaVolumeSettings(Document aDoc)
      Description: Get the area and volume settings of the project.
      @aDoc: The document.
      Returns: The area and volume settings of the project.
      Throws ArgumentNullException: A non-optional argument was null
    SpatialElementBoundaryLocation GetSpatialElementBoundaryLocation(SpatialElementType spType)
      Description: Gets the spatial element boundary location based on spatial element type.
      @spType: The spatial element type.
      Returns: The boundary location.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetSpatialElementBoundaryLocation(SpatialElementBoundaryLocation spatialElementBoundaryLocation, SpatialElementType spType)
      Description: Sets the spatial element boundary location of a spatial element type.
      @spatialElementBoundaryLocation: The boundary location.
      @spType: The spatial element type.
      Throws ArgumentException: Currently only SpatialElementType.Room is permitted when setting the boundary location.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] ArrayAnchorMember
Full Name: Autodesk.Revit.DB.ArrayAnchorMember
Description: Represents the possible choices for how the translation or rotation is used to place each member of the array.
Inherits: Enum

  Values:
    - Second = 0
    - Last = 1

--------------------------------------------------------------------------------

[CLASS] AssemblyCodeTable
Full Name: Autodesk.Revit.DB.AssemblyCodeTable
Description: AssemblyCodeTable represents the collection of ClassificationEntries for a document.
Inherits: KeyBasedTreeEntryTable

  METHODS:
    static AssemblyCodeTable GetAssemblyCodeTable(Document doc)
      Description: Returns the AssemblyCodeTable for the specified document.
      @doc: The document owns the AssemblyCodeTable.
      Returns: The AssemblyCodeTable for the document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] AssemblyDetailViewOrientation
Full Name: Autodesk.Revit.DB.AssemblyDetailViewOrientation
Description: Orientation of the Assembly Detail View.
Remarks: The orientation can be specified during creation but not modified for existing views.
Inherits: Enum

  Values:
    - HorizontalDetail = 0
    - DetailSectionA = 1
    - DetailSectionB = 2
    - ElevationTop = 3
    - ElevationBottom = 4
    - ElevationLeft = 5
    - ElevationRight = 6
    - ElevationFront = 7
    - ElevationBack = 8

--------------------------------------------------------------------------------

[CLASS] AssemblyDifference
Full Name: Autodesk.Revit.DB.AssemblyDifference
Description: Class that describes difference between two assemblies.
Remarks: The assembly comparison function returns a sub-class of this class. Different sub-classes represent different kinds of differences and contain additional data for each particular kind of difference.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] AssemblyDifferenceConfiguration
Full Name: Autodesk.Revit.DB.AssemblyDifferenceConfiguration
Description: The two assemblies being compared have different spatial configuration
Remarks: Assemblies resulting in this difference might be made up of identical elements, but the elements are not arranged in space relative to each other in the same way.
Inherits: AssemblyDifference

--------------------------------------------------------------------------------

[CLASS] AssemblyDifferenceMemberCount
Full Name: Autodesk.Revit.DB.AssemblyDifferenceMemberCount
Description: The two assemblies being compared have different number of members
Inherits: AssemblyDifference

  PROPERTIES:
    int Count1 { get; }
      Description: Number of members in the first assembly
    int Count2 { get; }
      Description: Number of members in the second assembly

--------------------------------------------------------------------------------

[CLASS] AssemblyDifferenceMemberDifference
Full Name: Autodesk.Revit.DB.AssemblyDifferenceMemberDifference
Description: The two assemblies being compared have different members
Remarks: This difference means that there is a member of the first assembly which is different from the corresponding member of the second assembly. Details about the difference are in memberDifference.
Inherits: AssemblyDifference

  PROPERTIES:
    AssemblyMemberDifference MemberDifference { get; }
      Description: Difference between the assembly members
    ElementId MemberId1 { get; }
      Description: Id of the member in the first assembly
    ElementId MemberId2 { get; }
      Description: Id of the member in the second assembly

--------------------------------------------------------------------------------

[CLASS] AssemblyDifferenceNamingCategory
Full Name: Autodesk.Revit.DB.AssemblyDifferenceNamingCategory
Description: The two assemblies being compared have different naming categories
Inherits: AssemblyDifference

  PROPERTIES:
    ElementId NamingCategoryId1 { get; }
      Description: Naming category id of the first assembly
    ElementId NamingCategoryId2 { get; }
      Description: Naming category id of the second assembly

--------------------------------------------------------------------------------

[CLASS] AssemblyDifferenceNone
Full Name: Autodesk.Revit.DB.AssemblyDifferenceNone
Description: The two assemblies being compared are identical
Inherits: AssemblyDifference

--------------------------------------------------------------------------------

[CLASS] AssemblyInstance
Full Name: Autodesk.Revit.DB.AssemblyInstance
Description: Combines multiple elements for tagging, filtering, scheduling and creating isolated assembly views.
Inherits: Element

  PROPERTIES:
    string AssemblyTypeName { get; set; }
      Description: The name for the assembly type. All matching assembly instances share this name. Unique assembly instances are named automatically based on their naming category.
    Location Location { get; }
      Description: This property is used to find the physical location of the assembly instance within project.
    ElementId NamingCategoryId { get; set; }
      Description: Id of the category that drives the default naming scheme for the assembly instance.

  METHODS:
    void AddMemberIds(ICollection<ElementId> memberIds)
      Description: Adds member element ids for the assembly instance.
      @memberIds: Element ids to be added to the assembly instance.
      Throws ArgumentException: One or more element ids was not permitted for membership in the assembly instance. Elements should be of a valid category and should not be a member of an existing assembly. -or- The provided set includes one or more element ids that cannot be added to or removed from the assembly on their own.
      Throws ArgumentNullException: A non-optional argument was null
    bool AllowsAssemblyViewCreation()
      Description: Returns true if assembly views can be created for this Assembly Instance.
    static bool AreElementsValidForAssembly(Document document, ICollection<ElementId> assemblyMemberIds, ElementId assemblyId)
      Description: Identifies if provided assembly members are valid.
      @document: The document.
      @assemblyMemberIds: Element ids to be tested for validity for membership of an assembly instance.
      @assemblyId: Id of the existing assembly to add components to. If invalid, the method return whether the components can be added to a new assembly
      Returns: True if all member ids are valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CanRemoveElementsFromAssembly(AssemblyInstance assemblyInstance, ICollection<ElementId> memberIds)
      Description: Identifies if provided assembly members can be removed from the assembly instance.
      @assemblyInstance: The assembly instance to remove elements from.
      @memberIds: Element ids to be tested for validity to remove from the assembly instance.
      Returns: True if all member ids are valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static AssemblyDifference CompareAssemblyInstances(AssemblyInstance instance1, AssemblyInstance instance2)
      Description: Compares two assembly instances and returns a result with details about the differences
      @instance1: The first assembly instance to compare
      @instance2: the second assembly instance to compare
      Returns: An object describing the difference between the two instances
      Throws ArgumentNullException: A non-optional argument was null
    static AssemblyInstance Create(Document document, ICollection<ElementId> assemblyMemberIds, ElementId namingCategoryId)
      Description: Creates a new assembly instance.
      @document: The document containing the elements.
      @assemblyMemberIds: The elements that comprise the assembly.
      @namingCategoryId: The naming category for the assembly instance.
      Returns: The newly created assembly instance.
      Throws ArgumentException: One or more element ids was not permitted for membership in the assembly instance. Elements should be of a valid category and should not be a member of an existing assembly. -or- This naming category was not valid for an assembly instance containing the proposed members. The naming category should match one of the member element categories.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ICollection<ElementId> Disassemble()
      Description: Removes the assembly instance and releases the member elements.
      Returns: ids of elements previously under the assembly instance.
    XYZ GetCenter()
      Description: Returns the center of the bounding box for the assembly instance. This is the default position for placed assembly instances.
      Returns: The position for the center of the assembly instance.
    ICollection<ElementId> GetMemberIds()
      Description: Gets member element ids for the assembly instance.
      Returns: Element ids for the members of the assembly instance.
    Transform GetTransform()
      Description: Gets the origin of the assembly instance.
      Returns: The origin of the assembly instance.
    bool IsMember(ElementId id)
      Description: Determines whether the given ElementId is a member of this assembly
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidNamingCategory(Document document, ElementId namingCategoryId, ICollection<ElementId> assemblyMemberIds)
      Description: Identifies if the naming category is valid for an assembly instance.
      @document: The document for the assembly instance.
      @namingCategoryId: The id of the naming category for the assembly instance.
      @assemblyMemberIds: Member ids to check validity of naming category
      Returns: True if the naming category is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static AssemblyInstance PlaceInstance(Document document, ElementId assemblyTypeId, XYZ location)
      Description: Places an assembly instance of a given assembly type at the specified location.
      @document: The document for the new assembly instance.
      @assemblyTypeId: The id of the assembly type to be used for the instance.
      @location: The placement location for the instance in project coordinates.
      Returns: The newly created assembly instance.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveMemberIds(ICollection<ElementId> memberIds)
      Description: Removes member element ids from the assembly instance.
      @memberIds: Element ids to be removed from the assembly instance.
      Throws ArgumentException: One or more element ids was not permitted to be removed from the assembly instance. Provided set should not be empty and all elements should be a member of the assembly instance. -or- The provided set includes one or more element ids that cannot be added to or removed from the assembly on their own.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMemberIds(ICollection<ElementId> memberIds)
      Description: Sets member element ids for the assembly instance. All existing members are cleared.
      @memberIds: Element ids to set for the assembly instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
    void SetTransform(Transform trf)
      Description: Sets the origin of the assembly instance.
      @trf: Transform to be set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: trf is not a rigid body transformation.

--------------------------------------------------------------------------------

[CLASS] AssemblyMemberDifference
Full Name: Autodesk.Revit.DB.AssemblyMemberDifference
Description: Class that describes difference between two assembly members
Remarks: Different sub-classes of this class represent different kinds of differences between assembly members and contain additional data for each particular kind of difference.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] AssemblyMemberDifferentCategory
Full Name: Autodesk.Revit.DB.AssemblyMemberDifferentCategory
Description: The two assembly members being compared have different category
Inherits: AssemblyMemberDifference

  PROPERTIES:
    ElementId CategoryId1 { get; }
      Description: Category id of the first assembly member
    ElementId CategoryId2 { get; }
      Description: Category id of the second assembly member

--------------------------------------------------------------------------------

[CLASS] AssemblyMemberDifferentGeometry
Full Name: Autodesk.Revit.DB.AssemblyMemberDifferentGeometry
Description: The two assembly members being compared have different geometry
Inherits: AssemblyMemberDifference

--------------------------------------------------------------------------------

[CLASS] AssemblyMemberDifferentParameters
Full Name: Autodesk.Revit.DB.AssemblyMemberDifferentParameters
Description: The two assembly members being compared have different parameters
Inherits: AssemblyMemberDifference

--------------------------------------------------------------------------------

[CLASS] AssemblyMemberDifferentType
Full Name: Autodesk.Revit.DB.AssemblyMemberDifferentType
Description: The two assembly members being compared have different type
Inherits: AssemblyMemberDifference

  PROPERTIES:
    ElementId TypeId1 { get; }
      Description: Type id of the first assembly member
    ElementId TypeId2 { get; }
      Description: Type id of the second assembly member

--------------------------------------------------------------------------------

[CLASS] AssemblyType
Full Name: Autodesk.Revit.DB.AssemblyType
Description: Type for construction assembly elements.
Inherits: ElementType

--------------------------------------------------------------------------------

[ABSTRACT CLASS] AssemblyViewUtils
Full Name: Autodesk.Revit.DB.AssemblyViewUtils
Description: Utilities that provide capabilities related to assembly view creation and validation.

  METHODS:
    static void AcquireAssemblyViews(Document document, ElementId sourceAssemblyInstanceId, ElementId targetAssemblyInstanceId)
      Description: Transfers the assembly views owned by a source assembly instance to a target sibling assembly instance of the same assembly type.
      @document: The document in which the assembly instances live.
      @sourceAssemblyInstanceId: Id of the assembly instance that currently owns the assembly views.
      @targetAssemblyInstanceId: Id of the assembly instance which will become the new owner of the assembly views.
      Throws ArgumentException: sourceAssemblyInstanceId is not an AssemblyInstance with assembly views. -or- targetAssemblyInstanceId is not an AssemblyInstance. -or- sourceAssemblyInstanceId and targetAssemblyInstanceId are not AssemblyInstances from the same assembly type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static View3D Create3DOrthographic(Document document, ElementId assemblyInstanceId, ElementId viewTemplateId, bool isAssigned)
      Description: Creates a new orthographic 3D assembly view for the assembly instance. The view will have the same orientation as the Default 3D view. The document must be regenerated before using the 3D view.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @viewTemplateId: Id of the view template that is used to create the view; if invalidElementId, the view will be created with the default settings.
      @isAssigned: If true, the template will be assigned, if false, the template will be applied.
      Returns: A new orthographic 3D assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- viewTemplateId is not a correct view template for the geom view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static View3D Create3DOrthographic(Document document, ElementId assemblyInstanceId)
      Description: Creates a new orthographic 3D assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      Returns: A new orthographic 3D assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSection CreateDetailSection(Document document, ElementId assemblyInstanceId, AssemblyDetailViewOrientation direction, ElementId viewTemplateId, bool isAssigned)
      Description: Creates a new detail section assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @direction: The direction for the new view.
      @viewTemplateId: Id of the view template that is used to create the view; if invalidElementId, the view will be created with the default settings.
      @isAssigned: If true, the template will be assigned; if false, the template will be applied.
      Returns: A new detail section assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- viewTemplateId is not a correct view template for the geom view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSection CreateDetailSection(Document document, ElementId assemblyInstanceId, AssemblyDetailViewOrientation direction)
      Description: Creates a new detail section assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @direction: The direction for the new view.
      Returns: A new detail section assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateMaterialTakeoff(Document document, ElementId assemblyInstanceId, ElementId viewTemplateId, bool isAssigned)
      Description: Creates a new material takeoff multicategory schedule assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @viewTemplateId: Id of the view template that is used to create the view; if invalidElementId, the view will be created with the default settings.
      @isAssigned: If true, the template will be assigned, if false, the template will be applied.
      Returns: A new material takeoff multicategory schedule assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- viewTemplateId is not a correct view template for the schedule view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateMaterialTakeoff(Document document, ElementId assemblyInstanceId)
      Description: Creates a new material takeoff multicategory schedule assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      Returns: A new material takeoff multicategory schedule assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreatePartList(Document document, ElementId assemblyInstanceId, ElementId viewTemplateId, bool isAssigned)
      Description: Creates a new part list multicategory schedule assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @viewTemplateId: Id of the view template that is used to create the view; if invalidElementId, the view will be created with the default settings.
      @isAssigned: If true, the template will be assigned, if false, the template will be applied.
      Returns: A new part list multicategory schedule assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- viewTemplateId is not a correct view template for the schedule view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreatePartList(Document document, ElementId assemblyInstanceId)
      Description: Creates a new part list multicategory schedule assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      Returns: A new part list multicategory schedule assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSheet CreateSheet(Document document, ElementId assemblyInstanceId, ElementId titleBlockId)
      Description: Creates a new sheet assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @titleBlockId: Id of the titleblock family to use. For no titleblock, pass invalidElementId.
      Returns: A new sheet assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- titleBlockId is not a TitleBlock.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateSingleCategorySchedule(Document document, ElementId assemblyInstanceId, ElementId scheduleCategoryId, ElementId viewTemplateId, bool isAssigned)
      Description: Creates a new single-category schedule assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @scheduleCategoryId: Id of the category for which the schedule will be created. Use ViewSchedule.IsValidCategoryForSchedule() to check if a category can be scheduled.
      @viewTemplateId: Id of the view template that is used to create the view; if invalidElementId, the view will be created with the default settings.
      @isAssigned: If true, the template will be assigned, if false, the template will be applied.
      Returns: A new single-category schedule assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- scheduleCategoryId is not a valid category for a regular schedule. -or- viewTemplateId is not a correct view template for the schedule view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateSingleCategorySchedule(Document document, ElementId assemblyInstanceId, ElementId scheduleCategoryId)
      Description: Creates a new single-category schedule assembly view for the assembly instance.
      @document: The document to which the view will be added.
      @assemblyInstanceId: Id of the assembly instance that owns the new view.
      @scheduleCategoryId: Id of the category for which the schedule will be created. Use ViewSchedule.IsValidCategoryForSchedule() to check if a category can be scheduled.
      Returns: A new single-category schedule assembly view.
      Throws ArgumentException: assemblyInstanceId is not an AssemblyInstance. -or- scheduleCategoryId is not a valid category for a regular schedule.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[ENUM] AttachmentLocation
Full Name: Autodesk.Revit.DB.AttachmentLocation
Description: Represents the attachment location of the element.
Inherits: Enum

  Values:
    - Base = 0
    - Top = 1

--------------------------------------------------------------------------------

[ENUM] AttachmentType
Full Name: Autodesk.Revit.DB.AttachmentType
Description: Enum determining whether a link is an attachment or an overlay
Inherits: Enum

  Values:
    - Overlay = 2
    - Attachment = 3

--------------------------------------------------------------------------------

[ENUM] AutomaticConnectionBehaviorType
Full Name: Autodesk.Revit.DB.AutomaticConnectionBehaviorType
Description: Defines behavior of connector with respect to automatic creation of connections
Inherits: Enum

  Values:
    - Exclude = 0
    - Active = 1
    - Forced = 2
    - Accepting = 3
    - Full = 4

--------------------------------------------------------------------------------

[CLASS] AXMImportOptions
Full Name: Autodesk.Revit.DB.AXMImportOptions
Description: The import options used to import AXM format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new AXMImportOptions(AXMImportOptions option)
      Description: Constructs a new instance of AXMImportOptions as a copy of the provided import options.
      @option: The AXM import options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new AXMImportOptions()
      Description: Constructs a new instance of AXMImportOptions with default values of all properties.

  PROPERTIES:
    bool ImportLevels { get; set; }
      Description: Indicate if levels are to be imported. False by default.

--------------------------------------------------------------------------------

