# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[CLASS] Wall
Full Name: Autodesk.Revit.DB.Wall
Description: Represents a wall in Autodesk Revit.
Remarks: The wall object represents all the different kinds of walls in Revit.
Inherits: HostObject

  PROPERTIES:
    WallCrossSection CrossSection { get; set; }
      Description: Gets or sets the Cross-section for this wall.
    CurtainGrid CurtainGrid { get; }
      Description: Get the grid object of a curtain wall
    bool Flipped { get; }
      Description: Property to test whether the wall orientation is flipped.
    bool IsStackedWall { get; }
      Description: Identifies if the wall is a stacked wall.
    bool IsStackedWallMember { get; }
      Description: Identifies if the wall is a member of a stacked wall.
    XYZ Orientation { get; }
      Description: The outward-facing normal vector of the exterior side face at the starting point of the wall.
    ElementId SketchId { get; }
      Description: Returns id of the profile sketch, or invalidElementId if sketch does not exist.
    ElementId StackedWallOwnerId { get; }
      Description: Gets the stacked wall which contains this stacked wall member.
    StructuralWallUsage StructuralUsage { get; set; }
      Description: Retrieves or changes the wall's designated structural usage.
    WallType WallType { get; set; }
      Description: Retrieves or changes the type of the wall.
    double Width { get; }
      Description: Get the overall thickness of the wall.

  METHODS:
    void AddAttachment(ElementId targetId, AttachmentLocation attachmentLocation)
      Description: Attaches the wall to the target. If an attachment already exists with the same "attachmentLocation" value, an exception is thrown. The target should be a roof, floor, ceiling, toposolid, or other wall.
      @targetId: Target element id.
      @attachmentLocation: The attachment location.
      Throws ArgumentException: -or- wall already has an attachment to targetId.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void AllowWrappingAtLocation(int locationIndex)
      Description: Allow end wrapping at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Throws ArgumentException: This location is invalid for wrapping.
      Throws InvalidOperationException: End wrapping is disabled in wall type.
    bool CanHaveProfileSketch()
      Description: Checks whether this wall has or can have a profile sketch.
      Returns: True if wall supports profile sketch, false otherwise.
    static Wall Create(Document document, IList<Curve> profile, ElementId wallTypeId, ElementId levelId, bool structural, XYZ normal)
      Description: Creates a non rectangular profile wall within the project using the specified wall type and normal vector.
      @document: The document in which the new wall is created.
      @profile: An array of planar curves that represent the vertical profile of the wall.
      @wallTypeId: Id of the wall type to be used by the new wall instead of the default type.
      @levelId: Id of the level on which the wall is to be placed.
      @structural: If set, specifies that the wall is structural in nature.
      @normal: A vector that must be perpendicular to the profile which dictates which side of the wall is considered to be inside and outside.
      Returns: If successful a new wall object within the project.
      Throws ArgumentException: The input profile contains at least one helical curve and is not supported for this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the wall.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Wall Create(Document document, IList<Curve> profile, ElementId wallTypeId, ElementId levelId, bool structural)
      Description: Creates a non rectangular profile wall within the project using the specified wall type.
      @document: The document in which the new wall is created.
      @profile: An array of planar curves that represent the vertical profile of the wall.
      @wallTypeId: Id of the wall type to be used by the new wall instead of the default type.
      @levelId: Id of the level on which the wall is to be placed.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
      Throws ArgumentException: The input profile contains at least one helical curve and is not supported for this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the wall.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Wall Create(Document document, IList<Curve> profile, bool structural)
      Description: Creates a non rectangular profile wall within the project using the default wall type.
      @document: The document in which the new wall is created.
      @profile: An array of planar curves that represent the vertical profile of the wall.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
      Throws ArgumentException: The input profile contains at least one helical curve and is not supported for this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the wall.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Wall Create(Document document, Curve curve, ElementId wallTypeId, ElementId levelId, double height, double offset, bool flip, bool structural)
      Description: Creates a new rectangular profile wall within the project using the specified wall type, height, and offset.
      @document: The document in which the new wall is created.
      @curve: A curve representing the base line of the wall.
      @wallTypeId: Id of the wall type to be used by the new wall instead of the default type.
      @levelId: Id of the level on which the wall is to be placed.
      @height: The height of the wall other than the default height.
      @offset: Modifies the wall's Base Offset parameter to determine its vertical placement.
      @flip: Change which side of the wall is considered to be the inside and outside of the wall.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
      Throws ArgumentException: The curve argument is not valid for wall creation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for height must be greater than 0 and no more than 30000 feet. -or- The given value for offset must be no more than 30000 feet in absolute value.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Wall Create(Document document, Curve curve, ElementId levelId, bool structural)
      Description: Creates a new rectangular profile wall within the project using the default wall style.
      @document: The document in which the new wall is created.
      @curve: A curve representing the base line of the wall.
      @levelId: Id of the level on which the wall is to be placed.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
      Throws ArgumentException: The curve argument is not valid for wall creation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    Sketch CreateProfileSketch()
      Description: Creates a new Wall profile Sketch.
      Returns: Created profile Sketch of the Wall.
      Throws InvalidOperationException: Wall does not support profile Sketch as it is not a straight wall; or is tapered; or it is an old curtain wall; or it is an infill wall; or it is a replacement curtain panel. -or- Wall already has a sketch.
    void DisallowWrappingAtLocation(int locationIndex)
      Description: Disallow end wrapping at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Throws ArgumentException: This location is invalid for wrapping.
    void Flip()
      Description: The wall orientation will be flipped.
    IList<ElementId> GetAttachmentIds(AttachmentLocation attachmentLocation)
      Description: Gets the ids of the target elements that are attached to the Wall.
      @attachmentLocation: The attachment location.
      Returns: Returns the elements ids that are attached to this wall at the specified "attachmentLocation".
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<ElementId> GetStackedWallMemberIds()
      Description: Get the sub walls which belongs to the wall.
      Returns: If the wall is a stacked wall, the Ids of the sub will be returned in bottom-top order.
      Throws InvalidOperationException: This wall isn't a consistent stacked wall.
    IList<int> GetValidWrappingLocationIndices()
      Description: Gets all valid locations for end wrapping.
      Returns: The list of valid wrapping locations.
    double GetWrappingLocationAsCurveParameter(int locationIndex)
      Description: Gets the non-normalized (actual) curve parameter of the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Returns: The non-normalized (actual) curve parameter value on the curve.
      Throws ArgumentException: This location is invalid for wrapping.
    IList<Reference> GetWrappingLocationAsReferences(int locationIndex)
      Description: Gets an array of references to faces at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Returns: All faces' references at the location.
      Throws ArgumentException: This location is invalid for wrapping.
    static bool IsValidTargetAttachment(Document doc, ElementId targetId)
      Description: Says whether the element id can be used as a target for a new attachment.
      @doc: Current Revit document.
      @targetId: A proposed target element id for a wall attachment.
      Returns: Returns true if the element id can be used as a target for a new attachment, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsWallCrossSectionValid(WallCrossSection wallCrossSection)
      Description: Checks whether the desired cross section is valid for the current wall.
      @wallCrossSection: The desired cross section.
      Returns: True if the wall can be set to the desired cross section.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsWrappingAtLocationAllowed(int locationIndex)
      Description: If end wrapping is allowed at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Returns: true if it is allowed, false if it is disallowed.
    void RemoveAttachment(ElementId targetId)
      Description: Removes any attachment of the wall to the specified target.
      @targetId: Target element id.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveAttachment(ElementId targetId, AttachmentLocation attachmentLocation)
      Description: Removes an attachment at the top or base of a wall, if there is one.
      @targetId: Target element id.
      @attachmentLocation: The attachment location.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void RemoveProfileSketch()
      Description: Reverts an edited wall to its original shape.

--------------------------------------------------------------------------------

[ENUM] WallCrossSection
Full Name: Autodesk.Revit.DB.WallCrossSection
Description: The allowed values for the WALL_CROSS_SECTION parameter.
Inherits: Enum

  Values:
    - SingleSlanted = 0
    - Vertical = 1
    - Tapered = 2

--------------------------------------------------------------------------------

[CLASS] WallFoundation
Full Name: Autodesk.Revit.DB.WallFoundation
Description: An object that represents a wall foundation element.
Inherits: HostObject

  PROPERTIES:
    ElementId WallId { get; }
      Description: Returns the id of the host wall.

  METHODS:
    static WallFoundation Create(Document document, ElementId typeId, ElementId wallId)
      Description: Creates a new wall foundation within the project.
      @document: The document.
      @typeId: The id of the wall foundation type of the newly created wall foundation.
      @wallId: The id of the host wall of the newly created wall foundation.
      Returns: If successful, returns the newly created wall foundation, otherwise.
      Throws ArgumentException: typeId is not a valid WallFoundationType id. -or- wallId does not refer to a valid wall.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] WallFoundationType
Full Name: Autodesk.Revit.DB.WallFoundationType
Description: An object that represents the type of a wall foundation in Autodesk Revit.
Inherits: HostObjAttributes

--------------------------------------------------------------------------------

[ENUM] WallFunction
Full Name: Autodesk.Revit.DB.WallFunction
Description: Indicates the function of a specified WallType, as specified in the parameter FUNCTION_PARAM on the WallType.
Inherits: Enum

  Values:
    - Interior = 0
    - Exterior = 1
    - Foundation = 2
    - Retaining = 3
    - Soffit = 4
    - Coreshaft = 5

--------------------------------------------------------------------------------

[ENUM] WallKind
Full Name: Autodesk.Revit.DB.WallKind
Description: Describes the fundamental type of wall, such as curtain wall or stacked wall.
Inherits: Enum

  Values:
    - Basic = 0
    - Curtain = 1
    - Stacked = 2
    - Unknown = -1

--------------------------------------------------------------------------------

[ENUM] WallLocationLine
Full Name: Autodesk.Revit.DB.WallLocationLine
Description: This enumerated type represents the options for alignment of a wall's location line.
Inherits: Enum

  Values:
    - WallCenterline = 0
    - CoreCenterline = 1
    - FinishFaceExterior = 2
    - FinishFaceInterior = 3
    - CoreExterior = 4
    - CoreInterior = 5

--------------------------------------------------------------------------------

[ENUM] WallSide
Full Name: Autodesk.Revit.DB.WallSide
Description: Represents the possible sides of a wall where a sweep or reveal may be attached.
Inherits: Enum

  Values:
    - Exterior = 0
    - Interior = 1

--------------------------------------------------------------------------------

[CLASS] WallSweep
Full Name: Autodesk.Revit.DB.WallSweep
Description: Represents a wall sweep or reveal.
Remarks: This element may represent either a standalone sweep or reveal element created by the Revit user interface or API, or a "fixed" wall sweep or reveal that was created by the contents of a wall's compound structure.
Inherits: HostObject

  METHODS:
    static WallSweep Create(Wall wall, ElementId wallSweepType, WallSweepInfo wallSweepInfo)
      Description: Creates a new wall sweep or reveal.
      @wall: The wall upon which to create the new sweep or reveal.
      @wallSweepType: The wall sweep or reveal type.
      @wallSweepInfo: The information that describes the new wall sweep or reveal.
      Returns: The new wall sweep.
      Throws ArgumentException: The wall sweep info represents a fixed wall sweep. Fixed wall sweeps may not be assigned to standalone wall sweep elements. -or- The WallSweepInfo id must be set to -1 for a non-fixed wall sweep. -or- wall may not host a wall sweep or reveal.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ElementId> GetHostIds()
      Description: Gets a list of all host walls on which the sweep resides.
      Returns: The list of wall ids.
    WallSweepInfo GetWallSweepInfo()
      Description: Gets the information of the wall sweep or reveal.
      Returns: The information that describes the wall sweep or reveal.
    static bool WallAllowsWallSweep(Wall wall)
      Description: Validates that the wall is of a type that may be a host for a wall sweep or reveal.
      @wall: The wall.
      Returns: True if the wall may host a wall sweep, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] WallSweepInfo
Full Name: Autodesk.Revit.DB.WallSweepInfo
Description: Represents a wall sweep or reveal of a vertically compound structure.
Implements: IDisposable

  CONSTRUCTORS:
    new WallSweepInfo(WallSweepType type, bool vertical)
      Description: Constructs a new WallSweepInfo instance.
      @type: The type of the WallSweepInfo instance.
      @vertical: True to construct a vertical wall sweep, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new WallSweepInfo(bool fixed, WallSweepType type)
      Description: Constructs a new WallSweepInfo instance.
      @fixed: True if the WallSweepInfo should be fixed (suitable for use in CompoundStructure.AddWallSweep()). False if the WallSweepInfo should be suitable for use in standalone wall sweep or reveal elements.
      @type: The type of the WallSweepInfo instance.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    bool CutsWall { get; set; }
      Description: Indicates if you want the sweep to cut geometry out of the host wall.
    double DefaultSetback { get; set; }
      Description: The sweep setback distance from inserts, such as windows and doors.
    double Distance { get; set; }
      Description: Represents the distance from either the top or base of the wall for horizontal sweeps, or the parameter along the wall's path curve for vertical ones.
    DistanceMeasuredFrom DistanceMeasuredFrom { get; set; }
      Description: Indicates if Distance is measured from the top or bottom of the wall.
    int Id { get; set; }
      Description: The id of the sweep or reveal.
    bool IsCutByInserts { get; set; }
      Description: Indicates if the sweep is cut by wall inserts.
    bool IsFixed { get; }
      Description: Indicates if the described wall sweep is fixed. A sweep is fixed if it is a part of a vertical compound structure.
    bool IsProfileFlipped { get; set; }
      Description: Indicates if the profile is applied upside-down.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVertical { get; }
      Description: Indicates whether the sweep or reveal is swept vertically or horizontally.
    ElementId MaterialId { get; set; }
      Description: The element id of the material used to create the sweep or reveal.
    ElementId ProfileId { get; set; }
      Description: The element id of the profile family used to create the sweep or reveal.
    double WallOffset { get; set; }
      Description: The offset from the sweep or reveal to the wall.
    WallSide WallSide { get; set; }
      Description: The side of the wall to which the sweep or reveal is attached.
    WallSweepOrientation WallSweepOrientation { get; set; }
      Description: Indicates how the profile of a horiztonal sweep is oriented with repect to the wall side face.
    WallSweepType WallSweepType { get; set; }
      Description: The type (either a wall sweep or a reveal).

  METHODS:
    void Dispose()
    bool IsEqual(WallSweepInfo toCompare)
      Description: Determines if the input object is equivalent to this WallSweepInfo.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] WallSweepOrientation
Full Name: Autodesk.Revit.DB.WallSweepOrientation
Description: Represents the orientation of horizonally placed sweep's profile relative to the wall side face.
Inherits: Enum

  Values:
    - Horizontal = 0
    - Perpendicular = 1

--------------------------------------------------------------------------------

[ENUM] WallSweepType
Full Name: Autodesk.Revit.DB.WallSweepType
Description: Represents the possible types for methods affecting wall sweeps or reveals.
Inherits: Enum

  Values:
    - Sweep = 0
    - Reveal = 1

--------------------------------------------------------------------------------

[CLASS] WallType
Full Name: Autodesk.Revit.DB.WallType
Description: Represents a specific type of wall, such as 'Generic - 8"'.
Remarks: All wall type objects available in the project can be retrieved from the Document object via the WallTypes property. Every Wall object has a WallType property that returns the a WallType object representing the type. This same WallType property can also be used to change the type of the wall by setting it to a different type.
Inherits: HostObjAttributes

  PROPERTIES:
    WallFunction Function { get; set; }
      Description: The wall function.
    WallKind Kind { get; }
      Description: The nature of the wall.
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the WallType
    double Width { get; }
      Description: The overall thickness of this type of wall.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WallUtils
Full Name: Autodesk.Revit.DB.WallUtils
Description: General Wall utility methods

  METHODS:
    static void AllowWallJoinAtEnd(Wall wall, int end)
      Description: Allows the wall's end to join to other walls. If that end is near other walls it will become joined as a result.
      @wall: The wall in question
      @end: 0 or 1 for the beginning or end of the wall's curve
      Throws ArgumentNullException: A non-optional argument was null
    static void DisallowWallJoinAtEnd(Wall wall, int end)
      Description: Sets the wall's end not to join to other walls.
      @wall: The wall in question
      @end: 0 or 1 for the beginning or end of the wall's curve
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsWallJoinAllowedAtEnd(Wall wall, int end)
      Description: Identifies if the indicated end of the wall allows joins or not.
      @wall: The wall in question
      @end: 0 or 1 for the beginning or end of the wall's curve
      Returns: true if it is allowed to join. false if it is disallowed.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] WidthMeasuredAt
Full Name: Autodesk.Revit.DB.WidthMeasuredAt
Description: The allowed values for the WALL_TYPE_WIDTH_MEASURED_AT parameter.
Inherits: Enum

  Values:
    - Top = 0
    - Base = 1
    - Bottom = 2

--------------------------------------------------------------------------------

[CLASS] WireframeBuilder
Full Name: Autodesk.Revit.DB.WireframeBuilder
Description: Constructs a shape representation consisting of points and curves. That shape would typically be stored in a DirectShape or a DirectShapeType object.
Inherits: ShapeBuilder

  CONSTRUCTORS:
    new WireframeBuilder()
      Description: Default constructor.

  METHODS:
    void AddCurve(Curve GCurve)
      Description: Add a curve to the shape representation stored in this WireframeBuilder.
      @GCurve: The curve to be added.
      Throws ArgumentException: GCurve is not acceptable for a wireframe shape representation.
      Throws ArgumentNullException: A non-optional argument was null
    void AddPoint(Point GPoint)
      Description: Add a point to the shape representation stored in this WireframeBuilder.
      @GPoint: The point to be added.
      Throws ArgumentException: GPoint is not acceptable for a wireframe shape representation.
      Throws ArgumentNullException: A non-optional argument was null
    void Reset()
      Description: Clears the accumulated geometry.
    static bool ValidateCurve(Curve GCurve)
      Description: Validates curve to be added to the wireframe shape being constructed. Used by addCurve to validate input. This function may be used to pre-validate the geometry being added to avoid an exception from AddCurve().
      @GCurve: Curve object to be validated.
      Returns: True is %GCurve% is acceptable as a part of a wireframe shape representation being built.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ValidatePoint(Point GPoint)
      Description: Validates the point object to be added to the wireframe shape being constructed. Used by AddPoint() to validate input.
      @GPoint: Point object to be validated.
      Returns: True is %GPoint% is acceptable as a part of a wireframe shape representation being built.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Workset
Full Name: Autodesk.Revit.DB.Workset
Description: Represents a workset in the document.
Remarks: Worksets are a way to divide a set of elements in the Revit document into subsets for worksharing. There may be one or many worksets in a document. Each element in the document must belong to one and only one workset.
Inherits: WorksetPreview

  PROPERTIES:
    bool IsEditable { get; }
      Description: Whether the workset is editable.
    bool IsOpen { get; }
      Description: Whether the workset is open (rather than closed).
    bool IsVisibleByDefault { get; }
      Description: Whether the workset is visible by default.
    WorksetKind Kind { get; }
      Description: Kind of the workset.

  METHODS:
    static Workset Create(Document document, string name)
      Description: Creates a new workset.
      @document: The document in which the new instance is created.
      @name: The workset name.
      Returns: Returns the newly created workset.
      Throws ArgumentException: document is not a workshared document. -or- name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given workset name is already in use.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] WorksetConfiguration
Full Name: Autodesk.Revit.DB.WorksetConfiguration
Description: A configuration class that is passed in to methods that open Revit documents to specify which user-created worksets are opened/closed.
Remarks: Once an instance of this class is created, it can be further modified by calling any of the other methods in any order. It is a specification of a setting for model open; the methods of this class just adjust the specification, and do not themselves open or close worksets.Only user-created worksets can be specified to be opened or closed. All system worksets are automatically open. An open workset allows its elements can be expanded and displayed. For a closed workset, Revit tries to not expand its elements, and to that end, does not display them. This is intended to help with performance by reducing Revit's memory footprint.
Implements: IDisposable

  CONSTRUCTORS:
    new WorksetConfiguration(WorksetConfigurationOption option)
      Description: Constructs a new workset configuration with an initial setting to open or close all user-created worksets, or to open last viewed worksets.
      @option: The option to open or close all user created worksets by default.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new WorksetConfiguration()
      Description: Constructs a new workset configuration with an initial setting to open all user-created worksets.
    new WorksetConfiguration(WorksetConfiguration other)
      Description: Constructs a new copy of the input WorksetConfiguration object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Close(IList<WorksetId> worksetsToClose)
      Description: Sets a group of user-created worksets to close.
      @worksetsToClose: The group of user-created worksets to close. Non-user-created worksets and invalid workset ids will be ignored.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    void Open(IList<WorksetId> worksetsToOpen)
      Description: Sets a group of user-created worksets to open.
      @worksetsToOpen: The group of user-created worksets to open. Non-user-created worksets and invalid workset ids will be ignored.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] WorksetConfigurationOption
Full Name: Autodesk.Revit.DB.WorksetConfigurationOption
Description: A collection of options used to initialize a WorksetConfiguration.
Inherits: Enum

  Values:
    - OpenAllWorksets = 0
    - CloseAllWorksets = 1
    - OpenLastViewed = 2

--------------------------------------------------------------------------------

[CLASS] WorksetDefaultVisibilitySettings
Full Name: Autodesk.Revit.DB.WorksetDefaultVisibilitySettings
Description: An object that manages default visibility of worksets in a document.
Remarks: WorksetDefaultVisibilitySettings does not exist for family documents. In case worksharing is disabled in a document, all elements are moved into a single workset; that workset, and any worksets (re)created if worksharing is re-enabled, is visible by default regardless of any current settings.
Inherits: Element

  METHODS:
    static WorksetDefaultVisibilitySettings GetWorksetDefaultVisibilitySettings(Document aDoc)
      Description: Get the WorksetDefaultVisibilitySettings of the document.
      @aDoc: The document.
      Returns: The WorksetDefaultVisibilitySettings of the document.
      Throws ArgumentException: WorksetDefaultVisibilitySettings is not applicable to family documents.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsWorksetVisible(WorksetId worksetId)
      Description: Indicates whether the workset is visible by default.
      @worksetId: Id of the workset.
      Returns: Whether the workset is visible by default.
      Throws ArgumentException: There is no workset with this Id in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: WorksetDefaultVisibilitySettings is not applicable to family documents.
    void SetWorksetVisibility(WorksetId worksetId, bool visible)
      Description: Set the default visibility of a workset.
      @worksetId: Id of the workset.
      @visible: Whether the workset should be visible by default or not.
      Throws ArgumentException: There is no workset with this Id in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: WorksetDefaultVisibilitySettings is not applicable to family documents.

--------------------------------------------------------------------------------

[CLASS] WorksetFilter
Full Name: Autodesk.Revit.DB.WorksetFilter
Description: A base class for a type of filter that accepts or rejects worksets based upon criteria.
Implements: IDisposable

  PROPERTIES:
    bool IncludeStandaloneWorksetsOnly { get; set; }
      Description: True if the results of the filter only match stand-alone worksets; worksets that are not stand-alone will be rejected.
    bool Inverted { get; }
      Description: True if the results of the filter are inverted; worksets that would normally be accepted by this filter will be rejected, and worksets that would normally be rejected will be accepted.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] WorksetId
Full Name: Autodesk.Revit.DB.WorksetId
Description: WorksetId identifies a workset within a single document.
Remarks: WorksetId is not guaranteed to be unique. It is only valid within one model and its value may change when the model is synchronized with central. If unique identification of a workset is needed, the workset's GUID should be used instead.

  CONSTRUCTORS:
    new WorksetId(int id)
      Description: Create an WorksetId handle with the given integer id.
      @id: The id.

  PROPERTIES:
    int IntegerValue { get; }
      Description: Provides the value of the WorksetId as an integer.
    static WorksetId InvalidWorksetId { get; }
      Description: Get the invalid WorksetId whose IntegerValue is -1.

  METHODS:
    int Compare(WorksetId id)
      Description: Compares two WorksetIds.
      @id: The WorksetId to be compared with this WorksetId.
      Returns: -1 if this WorksetId is less than id, 0 if equal, 1 if greater.
    bool Equals(object obj)
      Description: Determines whether the specified Object is equal to the current Object.
      @obj: Another object.
    int GetHashCode()
      Description: Gets the integer value of the id as hash code
    string ToString()
      Description: Gets a String representation of the integer value of the id.

--------------------------------------------------------------------------------

[ENUM] WorksetKind
Full Name: Autodesk.Revit.DB.WorksetKind
Description: Indicates one of the standard kinds of workset (as available in the UI).
Inherits: Enum

  Values:
    - OtherWorkset = 0
    - FamilyWorkset = 1
    - ViewWorkset = 2
    - StandardWorkset = 3
    - UserWorkset = 4

--------------------------------------------------------------------------------

[CLASS] WorksetKindFilter
Full Name: Autodesk.Revit.DB.WorksetKindFilter
Description: A filter used to match worksets of the given WorksetKind.
Remarks: This filter is a quick filter.
Inherits: WorksetFilter

  CONSTRUCTORS:
    new WorksetKindFilter(WorksetKind worksetKind, bool inverted)
      Description: Constructs a new instance of WorksetKindFilter filter to match worksets of the given WorksetKind.
      @worksetKind: The WorksetKind to match.
      @inverted: True if the filter should match all worksets which are not of the given WorksetKind.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new WorksetKindFilter(WorksetKind worksetKind)
      Description: Constructs a new instance of WorksetKindFilter filter to match worksets of the given WorksetKind.
      @worksetKind: The WorksetKind to match.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    WorksetKind WorksetKind { get; }
      Description: The WorksetKind.

--------------------------------------------------------------------------------

[CLASS] WorksetPreview
Full Name: Autodesk.Revit.DB.WorksetPreview
Description: Represents an accessor for workset data which can be obtained from an unopened document.
Remarks: As a base class of Workset, this class has limited access to data. WorksetPreviews are obtained from WorksharingUtils.GetUserWorksetInfo() from an unopened document.
Implements: IDisposable

  PROPERTIES:
    WorksetId Id { get; }
      Description: Id of the workset.
    bool IsDefaultWorkset { get; }
      Description: Whether the workset is the default one.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: Name of the workset.
    string Owner { get; }
      Description: User name of the workset.
    Guid UniqueId { get; }
      Description: UniqueId of the workset.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] WorksetTable
Full Name: Autodesk.Revit.DB.WorksetTable
Description: A table containing references to all the worksets contained in a document.
Remarks: There is one WorksetTable for each document. There will be at least one default workset in the table, even if worksharing has not been enabled in the document.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static bool CanDeleteWorkset(Document document, WorksetId worksetId, DeleteWorksetSettings deleteWorksetSettings)
      Description: Indicates if a workset can be deleted.
      @document: The document containing the worksets.
      @worksetId: The id of the workset to delete.
      @deleteWorksetSettings: The settings to delete a workset.
      Returns: True if the workset can be deleted, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static void DeleteWorkset(Document document, WorksetId worksetId, DeleteWorksetSettings deleteWorksetSettings)
      Description: Delete the specific workset.
      @document: The document containing the worksets.
      @worksetId: The id of the workset to delete.
      @deleteWorksetSettings: The settings to delete a workset.
      Throws ArgumentException: document is not a workshared document. -or- document is not a primary document, it is a linked document. -or- document is read-only: It cannot be modified. -or- There is no workset in the document with this id. -or- Workset cannot be deleted.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The document regeneration fails during the DeleteWorkset operation.
    void Dispose()
    WorksetId GetActiveWorksetId()
      Description: Returns the active workset's WorksetId.
      Returns: WorksetId of the active workset.
    Workset GetWorkset(Guid guid)
      Description: Returns the workset from a input Guid.
      @guid: Guid of the workset.
      Returns: The returned workset. if there is no workset in this table with this Id.
    Workset GetWorkset(WorksetId id)
      Description: Returns the workset from a input WorksetId.
      @id: Id of a workset.
      Returns: The returned workset. if there is no workset in this table with this Id.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsWorksetNameUnique(Document aDoc, string name)
      Description: Checks if the given workset name is unique in the document.
      @aDoc: The document in which the workset is accessed.
      @name: The workset name.
      Returns: True if this given workset name is unique in the document, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static void RenameWorkset(Document aDoc, WorksetId worksetId, string name)
      Description: Renames the workset.
      @aDoc: The document in which the workset is accessed.
      @worksetId: The workset Id.
      @name: The workset name.
      Throws ArgumentException: aDoc is not a workshared document. -or- name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given workset name is already in use. -or- There is no workset in the document with this id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void SetActiveWorksetId(WorksetId worksetId)
      Description: Sets the active workset.
      @worksetId: The workset Id.
      Throws ArgumentException: There is no workset in the document with this id.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] WorksetVisibility
Full Name: Autodesk.Revit.DB.WorksetVisibility
Description: Indicates the visibility settings of a workset in a particular view.
Inherits: Enum

  Values:
    - Visible = 0
    - Hidden = 1
    - UseGlobalSetting = 2

--------------------------------------------------------------------------------

[CLASS] WorksharingDisplayGraphicSettings
Full Name: Autodesk.Revit.DB.WorksharingDisplayGraphicSettings
Description: Represents the graphical settings that can be assigned to elements in the worksharing display modes.
Implements: IDisposable

  CONSTRUCTORS:
    new WorksharingDisplayGraphicSettings(bool shouldApply, Color lineColor)
      Description: Creates a new instance.
      @shouldApply: True if the settings should be applied, False if they should be set but not applied.
      @lineColor: The desired line color, which must be a valid color. Note that the fill color is calculated automatically from the line color so it is not advisable to use white, black, or shades of grey.
      Throws ArgumentException: The lineColor argument does not represent a valid color.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    Color FillColor { get; }
      Description: The fill color that will be applied to elements when these settings are applied. Note that this is automatically set by increasing the luma of the specified line color by 65%.
    bool IsApplied { get; }
      Description: Indicates whether this set of graphic overrides will be applied.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color LineColor { get; }
      Description: The line color that will be applied to elements when these settings are applied.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] WorksharingDisplayMode
Full Name: Autodesk.Revit.DB.WorksharingDisplayMode
Description: Indicates which worksharing display mode a view is in.
Inherits: Enum

  Values:
    - Off = 0
    - CheckoutStatus = 1
    - Owners = 2
    - ModelUpdates = 3
    - Worksets = 4

--------------------------------------------------------------------------------

[CLASS] WorksharingDisplaySettings
Full Name: Autodesk.Revit.DB.WorksharingDisplaySettings
Description: WorksharingDisplaySettings controls how elements will appear when they are displayed in any of the worksharing display modes.
Remarks: The colors stored in these settings are a common setting and are shared by all users in the model. Whether a given color is applied or not is specific to the current user and will not be shared by other users.
Inherits: Element

  METHODS:
    bool CanUserHaveOverrides(string username)
      Description: Checks whether a single username can have customized graphic overrides.
      @username: The username to check.
      Returns: False if the username is on the list of removed users, True otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<string> GetAllUsersWithGraphicOverrides()
      Description: Returns all usernames that have graphic overrides. This list consists of all users included in the user table + all users who have explicitly been assigned overrides.
      Returns: All usernames that have been assigned graphic overrides.
    WorksharingDisplayGraphicSettings GetGraphicOverrides(WorksetId worksetId)
      Description: Returns the graphic overrides assigned to elements in a particular workset.
      @worksetId: The workset id of interest. This must be a user workset.
      Returns: Returns the graphic overrides assigned to the workset.
      Throws ArgumentException: worksetId does not correspond to a user workset in the document containing this WorksharingDisplaySettings.
      Throws ArgumentNullException: A non-optional argument was null
    WorksharingDisplayGraphicSettings GetGraphicOverrides(string username)
      Description: Returns the graphic overrides assigned for elements owned by a particular user.
      @username: The username of a particular user.
      Returns: The graphic overrides assigned to this user.
      Throws ArgumentException: This WorksharingDisplaySettings does not contain graphic overrides for the specified value of username.
      Throws ArgumentNullException: A non-optional argument was null
    WorksharingDisplayGraphicSettings GetGraphicOverrides(ModelUpdatesStatus statusInCentral)
      Description: Returns the graphic overrides assigned to a particular model update status.
      @statusInCentral: The model update status of interest.
      Returns: Returns the graphic overrides assigned to the model update status.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    WorksharingDisplayGraphicSettings GetGraphicOverrides(CheckoutStatus ownershipStatus)
      Description: Returns the graphic overrides associated with a particular ownership status.
      @ownershipStatus: The ownership status of interest.
      Returns: Returns the graphic overrides assigned to a particular ownership status.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static WorksharingDisplaySettings GetOrCreateWorksharingDisplaySettings(Document doc)
      Description: Returns the worksharing display settings for the document, creating new settings for the current user if necessary.
      @doc: The document of interest.
      Returns: The worksharing display settings for the document.
      Throws ArgumentException: doc is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<string> GetRemovedUsers()
      Description: Returns the set of users who have been explicitly removed from the settings.
      Returns: Users who have been explicitly removed from the list.
    void RemoveUsers(Document document, ICollection<string> usersToRemove, out ICollection<string> usersActuallyRemoved)
      Description: Removes users from the list of displayed users and permanently discards any customization of the graphics. Note that a user cannot be removed if he or she owns any elements.
      @document: The document containing this.
      @usersToRemove: The usernames of the users to remove.
      @usersActuallyRemoved: The users that were successfully removed. Note that you cannot remove users who currently own any elements.
      Throws ArgumentNullException: A non-optional argument was null
    int RestoreUsers(ICollection<string> usersToRestore)
      Description: Adds users back to the list of displayed users and permits customization of the graphics. Any usernames that are not currently removed will be ignored. Returns the number of users who were actually restored.
      @usersToRestore: The usernames of the users to restore. Any usernames that are not currently removed will be ignored.
      Returns: The number of usernames that were actually restored.
      Throws ArgumentNullException: A non-optional argument was null
    void SetGraphicOverrides(WorksetId worksetId, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements in a particular user workset.
      @worksetId: The workset of interest, which must be a user workset.
      @overrides: The desired graphic overrides for this workset.
      Throws ArgumentException: worksetId does not correspond to a user workset in the document containing this WorksharingDisplaySettings.
      Throws ArgumentNullException: A non-optional argument was null
    void SetGraphicOverrides(CheckoutStatus status, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements with a particular ownership status.
      @status: The ownership status of interest.
      @overrides: The desired graphic overrides for this ownership status.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetGraphicOverrides(ModelUpdatesStatus status, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements with a particular status in the central model.
      @status: The status in the central model.
      @overrides: The desired graphic overrides for this status.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetGraphicOverrides(string username, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements owned by a particular user. The username cannot be on the list of removed usernames.
      @username: The username of the desired user.
      @overrides: The desired graphic overrides for this user.
      Throws ArgumentException: The username is on the list of removed users.
      Throws ArgumentNullException: A non-optional argument was null
    bool UserHasGraphicOverrides(string username)
      Description: Checks whether there are graphic overrides that would apply to elements owned by the given user in the "Individual Owners" display mode.
      @username: The username to check
      Returns: True if there are graphic overrides assigned to the username, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] WorksharingSaveAsOptions
Full Name: Autodesk.Revit.DB.WorksharingSaveAsOptions
Description: This class contains options specific to worksharing SaveAs.
Implements: IDisposable

  CONSTRUCTORS:
    new WorksharingSaveAsOptions()
      Description: Constructs a new WorksharingSaveAsOptions with default settings.

  PROPERTIES:
    bool ClearTransmitted { get; set; }
      Description: For a transmitted model opened with DetachAndPreserveWorksets, clear its transmitted flag in the Save/SaveAs operation.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SimpleWorksetConfiguration OpenWorksetsDefault { get; set; }
      Description: The default set of user-worksets to open when opening the model in the UI. Default is AskUserToSpecify.
    bool SaveAsCentral { get; set; }
      Description: Whether to save the new model as a central instead of local model. True: save as a central model. Default is false: save as a local model.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] WorksharingTooltipInfo
Full Name: Autodesk.Revit.DB.WorksharingTooltipInfo
Description: Worksharing information about a single element suitable for display in an in-canvas tooltip.
Remarks: Some or all of the strings may be empty.
Implements: IDisposable

  PROPERTIES:
    string Creator { get; }
      Description: The user name of the user who created the element.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string LastChangedBy { get; }
      Description: The user name of the most recent user who saved a user change of this element to the central model.
    string Owner { get; }
      Description: The current owner of the element or empty string if no one owns the element.

  METHODS:
    void Dispose()
    IList<string> GetRequesters()
      Description: The ordered list of unique user names of users who have outstanding editing requests for the specified element.
      Returns: The ordered list of unique user names.

--------------------------------------------------------------------------------

[CLASS] WorksharingUtils
Full Name: Autodesk.Revit.DB.WorksharingUtils
Description: A static class that contains utility functions related to worksharing.
Remarks: Return values from inquiries about the worksharing status of elements or worksets rely on local caching of information from the central model so it is possible that the information is out of date. Because of this, the return value is suitable for reporting to an interactive user (e.g. via a mechanism similar to Worksharing display mode), but cannot be considered a reliable indication of whether the element can be immediately edited by the application. To make an immediate attempt to edit elements, use CheckoutElements and check the return status, then confirm if the elements are up to date.In addition, information about the current user may not be reliable while Revit is in the middle of an editing transaction. For example, if you move an unowned wall from an unowned workset to a workset you own, then before you explicitly or Revit automatically checks out the wall for you, GetCheckoutStatus() might erroneously tell you CheckoutStatus.OwnedByCurrentUser because although the official (as seen in central and by other users) owner is no one, locally it looks like you already own it since it belongs to a workset you own.For operations that interact with central (as opposed to use only cached values), Revit might opportunistically refresh some editing permissions or check the status of editing requests.Some useful definitions to keep in mind follow: The owner of a workset: the user who has the Workset checked out; this could be nobody (the empty string).The borrower of an element: the user who has explicitly checked out ("borrowed") the Element; this could be nobody.The owner of an element: If element is borrowed (i.e. explicitly checked out), then the element's owner is the borrower, otherwise it is the owner or the workset containing the element.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static ISet<ElementId> CheckoutElements(Document document, ISet<ElementId> elementsToCheckout, TransactWithCentralOptions options)
      Description: Obtains ownership for the current user of as many specified elements as possible.
      @document: The document containing the elements.
      @elementsToCheckout: The ids of the elements to attempt to check out.
      @options: Options to customize access to the central model. is allowed and means no customization.
      Returns: The ids of all specified elements that are now owned (but possibly out of date), including all that were owned prior to the function call.
      Throws ArgumentException: document is not a workshared document. -or- document is not a primary document, it is a linked document. -or- One or more elements in elementsToCheckout do not exist in the document. -or- Saving is not allowed in the current application mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: Editing permissions for the file-based central model could not be accessed for write, e.g. the network is down, central is missing, or central is read-only.
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: Editing permissions for the central model are locked and the last attempt to lock was canceled. -or- The central model is being accessed by another client.
      Throws CentralModelException: An error has occurred while checking out worksets or elements. -or- The central model is overwritten by other user. -or- The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws CentralModelVersionArchivedException: Last central version merged into the local model has been archived in the central model. This exception could only be thrown from cloud models.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    static ICollection<ElementId> CheckoutElements(Document document, ICollection<ElementId> elementsToCheckout)
      Description: Obtains ownership for the current user of as many specified elements as possible.
      @document: The document containing the elements.
      @elementsToCheckout: The ids of the elements to attempt to check out.
      Returns: The ids of all specified elements that are now owned (but possibly out of date), including all that were owned prior to the function call.
      Throws ArgumentException: document is not a workshared document. -or- document is not a primary document, it is a linked document. -or- One or more elements in elementsToCheckout do not exist in the document. -or- Saving is not allowed in the current application mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: Editing permissions for the file-based central model could not be accessed for write, e.g. the network is down, central is missing, or central is read-only.
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: Editing permissions for the central model are locked and the last attempt to lock was canceled. -or- The central model is being accessed by another client.
      Throws CentralModelException: An error has occurred while checking out worksets or elements. -or- The central model is overwritten by other user. -or- The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws CentralModelVersionArchivedException: Last central version merged into the local model has been archived in the central model. This exception could only be thrown from cloud models.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    static ISet<WorksetId> CheckoutWorksets(Document document, ISet<WorksetId> worksetsToCheckout, TransactWithCentralOptions options)
      Description: Obtains ownership for the current user of as many specified worksets as possible.
      @document: The document containing the worksets.
      @worksetsToCheckout: The ids of the worksets to attempt to check out.
      @options: Options to customize access to the central model. is allowed and means no customization.
      Returns: The ids of all specified worksets that are now owned, including all that were owned prior to the function call.
      Throws ArgumentException: document is not a workshared document. -or- document is not a primary document, it is a linked document. -or- document is read-only: It cannot be modified. -or- document has an open editing transaction and is accepting changes. -or- There are one or more ids with no corresponding workset. -or- Saving is not allowed in the current application mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: The file-based central model could not be reached, e.g. the network is down or the file server is down.
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model are locked by another client.
      Throws CentralModelException: The central model is overwritten by other user. -or- The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws CentralModelVersionArchivedException: Last central version merged into the local model has been archived in the central model. This exception could only be thrown from cloud models.
      Throws InvalidOperationException: Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    static ICollection<WorksetId> CheckoutWorksets(Document document, ICollection<WorksetId> worksetsToCheckout)
      Description: Obtains ownership for the current user of as many specified worksets as possible.
      @document: The document containing the worksets.
      @worksetsToCheckout: The ids of the worksets to attempt to check out.
      Returns: The ids of all specified worksets that are now owned, including all that were owned prior to the function call.
      Throws ArgumentException: document is not a workshared document. -or- document is not a primary document, it is a linked document. -or- document is read-only: It cannot be modified. -or- document has an open editing transaction and is accepting changes. -or- There are one or more ids with no corresponding workset. -or- Saving is not allowed in the current application mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: The file-based central model could not be reached, e.g. the network is down or the file server is down.
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model are locked by another client.
      Throws CentralModelException: The central model is overwritten by other user. -or- The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws CentralModelVersionArchivedException: Last central version merged into the local model has been archived in the central model. This exception could only be thrown from cloud models.
      Throws InvalidOperationException: Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    static void CreateNewLocal(ModelPath sourcePath, ModelPath targetPath)
      Description: Takes a path to a central model and copies the model into a new local file for the current user.
      @sourcePath: The path to the central model.
      @targetPath: The path to put the new local file.
      Throws ArgumentException: The given path sourcePath is a cloud path which is not supported in this method. -or- The model is not workshared. -or- The central model has not fully enabled worksharing. It must be opened and resaved to finish enabling worksharing. -or- The model is a local file. -or- The central model is not saved in the current Revit version. -or- The model is transmitted. -or- -or- The specified filepath is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is locked by another user. -or- The central model is being accessed by another client.
      Throws CentralModelException: The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws FileArgumentAlreadyExistsException: The file or folder already exists and cannot be overwritten.
      Throws InvalidOperationException: This functionality is not available in Revit LT. -or- File already exists! -or- Revit Server does not support local models.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    void Dispose()
    static CheckoutStatus GetCheckoutStatus(Document document, ElementId elementId)
      Description: Gets the ownership status of an element.
      @document: The document containing the element.
      @elementId: The id of the element.
      Returns: A summary of whether the element is unowned, owned by the current user, or owned by another user.
      Throws ArgumentNullException: A non-optional argument was null
    static CheckoutStatus GetCheckoutStatus(Document document, ElementId elementId, out string owner)
      Description: Gets the ownership status and outputs the owner of an element.
      @document: The document containing the element.
      @elementId: The id of the element.
      @owner: The owner of the element, or an empty string if no one owns it.
      Returns: An indication of whether the element is unowned, owned by the current user, or owned by another user.
      Throws ArgumentNullException: A non-optional argument was null
    static ModelUpdatesStatus GetModelUpdatesStatus(Document document, ElementId elementId)
      Description: Gets the status of a single element in the central model.
      @document: The document containing the element.
      @elementId: The id of the element.
      Returns: The status of the element in the local session versus the central model.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<WorksetPreview> GetUserWorksetInfo(ModelPath path)
      Description: Gets information about user worksets in a workshared model file, without fully opening the file.
      @path: The path to the workshared model.
      Returns: Information about all the user worksets in the model. The list is sorted by workset id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model are locked by another client.
      Throws CentralModelException: The central model is missing. -or- The central model is corrupt or not an RVT file. -or- The model is not workshared. -or- The central model is overwritten by other user. -or- An internal error happened on the central model, please contact the server administrator.
      Throws FileAccessException: The model could not be accessed due to lack of access privileges.
      Throws FileArgumentNotFoundException: The Revit model specified by path doesn't exist.
      Throws FileNotFoundException: The model could not be found at the specified path.
      Throws InvalidOperationException: This functionality is not available in Revit LT.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    static WorksharingTooltipInfo GetWorksharingTooltipInfo(Document document, ElementId elementId)
      Description: Gets worksharing information about an element to display in an in-canvas tooltip.
      @document: The document containing the element
      @elementId: The id of the element in question
      Returns: Worksharing information about the specified element.
      Throws ArgumentNullException: A non-optional argument was null
    static RelinquishedItems RelinquishOwnership(Document document, RelinquishOptions generalCategories, TransactWithCentralOptions options)
      Description: Relinquishes ownership by the current user of as many specified elements and worksets as possible, and grants element ownership requested by other users on a first-come, first-served basis.
      @document: The document containing the elements and worksets.
      @generalCategories: General categories of items to relinquish. See RelinquishOptions for details.
      @options: Options to customize access to the central model. is allowed and means no customization.
      Returns: The elements and worksets that were relinquished.
      Throws ArgumentException: document is not a workshared document. -or- document is not a primary document, it is a linked document. -or- document is read-only: It cannot be modified. -or- document has an open editing transaction and is accepting changes. -or- Saving is not allowed in the current application mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: The file-based central model could not be reached, e.g. the network is down or the file server is down.
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is locked by another client.
      Throws CentralModelException: The central model is overwritten by other user. -or- The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws InvalidOperationException: Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.

--------------------------------------------------------------------------------

[CLASS] XYZ
Full Name: Autodesk.Revit.DB.XYZ
Description: Object representing coordinates in 3-dimensional space.
Remarks: Usually this means a point or a vector in 3-dimensional space, depending on the actual use.

  CONSTRUCTORS:
    new XYZ(double x, double y, double z)
      Description: Creates an XYZ with the supplied coordinates.
      @x: The first coordinate.
      @y: The second coordinate.
      @z: The third coordinate.
      Throws ArgumentException: Thrown when setting an infinite number to the X, Y or Z property.
    new XYZ()
      Description: Creates a default XYZ with the values (0, 0, 0).

  PROPERTIES:
    static XYZ BasisX { get; }
      Description: The basis of the X axis.
    static XYZ BasisY { get; }
      Description: The basis of the Y axis.
    static XYZ BasisZ { get; }
      Description: The basis of the Z axis.
    double Item { get; }
    double X { get; }
      Description: Gets the first coordinate.
    double Y { get; }
      Description: Gets the second coordinate.
    double Z { get; }
      Description: Gets the third coordinate.
    static XYZ Zero { get; }
      Description: The coordinate origin or zero vector.

  METHODS:
    XYZ Add(XYZ source)
      Description: Adds the specified vector to this vector and returns the result.
      @source: The vector to add to this vector.
      Returns: The vector equal to the sum of the two vectors.
      Throws ArgumentNullException: Thrown when source is .
    double AngleOnPlaneTo(XYZ right, XYZ normal)
      Description: Returns the angle between this vector and the specified vector projected to the specified plane.
      @right: The specified vector.
      @normal: The normal vector that defines the plane.
      Returns: The real number between 0 and 2*PI equal to the projected angle between the two vectors.
      Throws ArgumentNullException: Thrown when right or normal is .
    double AngleTo(XYZ source)
      Description: Returns the angle between this vector and the specified vector.
      @source: The specified vector.
      Returns: The real number between 0 and PI equal to the angle between the two vectors in radians..
      Throws ArgumentNullException: Thrown when source is .
    XYZ CrossProduct(XYZ source)
      Description: The cross product of this vector and the specified vector.
      @source: The vector to multiply with this vector.
      Returns: The vector equal to the cross product.
      Throws ArgumentNullException: Thrown when source is .
    double DistanceTo(XYZ source)
      Description: Returns the distance from this point to the specified point.
      @source: The specified point.
      Returns: The real number equal to the distance between the two points.
      Throws ArgumentNullException: Thrown when source is .
    XYZ Divide(double value)
      Description: Divides this vector by the specified value and returns the result.
      @value: The value to divide this vector by.
      Returns: The divided vector.
      Throws ArgumentException: Thrown when the specified value is an infinite number or zero.
    double DotProduct(XYZ source)
      Description: The dot product of this vector and the specified vector.
      @source: The vector to multiply with this vector.
      Returns: The real number equal to the dot product.
      Throws ArgumentNullException: Thrown when source is .
    double GetLength()
      Description: Gets the length of this vector.
    bool IsAlmostEqualTo(XYZ source, double tolerance)
      Description: Determines whether 2 vectors are the same within the given tolerance.
      @source: The vector to compare with this vector.
      @tolerance: The tolerance for equality check.
      Returns: True if the vectors are the same; otherwise, false.
      Throws ArgumentNullException: Thrown when source is .
      Throws ArgumentException: Thrown when tolerance is less than 0.
    bool IsAlmostEqualTo(XYZ source)
      Description: Determines whether this vector and the specified vector are the same within the tolerance (1.0e-09).
      @source: The vector to compare with this vector.
      Returns: True if the vectors are the same; otherwise, false.
      Throws ArgumentNullException: Thrown when source is .
    bool IsUnitLength()
      Description: The boolean value that indicates whether this vector is of unit length.
    static bool IsWithinLengthLimits(XYZ point)
      Description: Validates that the input point is within Revit design limits.
      @point: The point to test.
      Returns: True if the input point is within Revit design limits, false otherwise.
    bool IsZeroLength()
      Description: The boolean value that indicates whether this vector is a zero vector.
    XYZ Multiply(double value)
      Description: Multiplies this vector by the specified value and returns the result.
      @value: The value to multiply with this vector.
      Returns: The multiplied vector.
      Throws ArgumentException: Thrown when the specified value is an infinite number.
    XYZ Negate()
      Description: Negates this vector.
      Returns: The vector opposite to this vector.
    XYZ Normalize()
      Description: Returns a new XYZ whose coordinates are the normalized values from this vector.
      Returns: The normalized XYZ or zero if the vector is almost Zero.
    XYZ Subtract(XYZ source)
      Description: Subtracts the specified vector from this vector and returns the result.
      @source: The vector to subtract from this vector.
      Returns: The vector equal to the difference between the two vectors.
      Throws ArgumentNullException: Thrown when source is .
    string ToString()
      Description: Gets formatted string showing (X, Y, Z) with values formatted to 9 decimal places.
    double TripleProduct(XYZ middle, XYZ right)
      Description: The triple product of this vector and the two specified vectors.
      @middle: The second vector.
      @right: The third vector.
      Returns: The real number equal to the triple product.
      Throws ArgumentNullException: Thrown when middle or right is .

--------------------------------------------------------------------------------

[ENUM] ZoomFitType
Full Name: Autodesk.Revit.DB.ZoomFitType
Description: This enum is used to define type of zoom.
Inherits: Enum

  Values:
    - FitToPage = 0
    - Zoom = 1

--------------------------------------------------------------------------------

[ENUM] ZoomType
Full Name: Autodesk.Revit.DB.ZoomType
Description: An enumerated type listing all Zoom types of Print Setting.
Inherits: Enum

  Values:
    - FitToPage = 0
    - Zoom = 1

--------------------------------------------------------------------------------

