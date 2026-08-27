# Autodesk.Revit.DB.Architecture

NAMESPACE: Autodesk.Revit.DB.Architecture
--------------------------------------------------------------------------------

[CLASS] BalusterInfo
Full Name: Autodesk.Revit.DB.Architecture.BalusterInfo
Description: The class represents an instance of a railing baluster or post.
Implements: IDisposable

  PROPERTIES:
    ElementId BalusterFamilyId { get; set; }
      Description: The id of the family used for the baluster or post.
    double BaseOffset { get; set; }
      Description: The offset from the base reference.
    string BaseReferenceName { get; set; }
      Description: Represents the name of the reference for the bottom of this baluster or post.
    double DistanceFromPreviousOrSpace { get; set; }
      Description: The length, in case of balusters, it is a distance from a previous one. For a post, it is a space from the original position of the post.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: The name of the baluster.
    double Offset { get; set; }
      Description: The side offset of the baluster/post from the railing path.
    double TopOffset { get; set; }
      Description: The offset from the top reference.
    string TopReferenceName { get; set; }
      Description: Represents the name of the reference for the top of this baluster or post.

  METHODS:
    void Dispose()
    static string GetReferenceNameForHost()
      Description: Gets the name string to be used as a reference to Host in the current language.
      Returns: The name string to be used as a reference to Host.
    static string GetReferenceNameForTopRail()
      Description: Gets the name string to be used as a reference to Top Rail in the current language.
      Returns: The name string to be used as a reference to Top Rail.

--------------------------------------------------------------------------------

[CLASS] BalusterPattern
Full Name: Autodesk.Revit.DB.Architecture.BalusterPattern
Description: Baluster pattern class.
Implements: IDisposable

  PROPERTIES:
    BreakPatternCondition BreakPattern { get; set; }
      Description: The condition which controls breaking baluster patterns distribution.
    PatternJustification DistributionJustification { get; set; }
      Description: Determines how baluster pattern distribution is justified.
    double EndSpace { get; set; }
      Description: The extra space added after a whole baluster pattern.
    ElementId ExcessLengthFillBalusterId { get; set; }
      Description: The id of a Baluster family used to fill excess length, which is the extra space along the railing segment that cannot be filled with a pattern. If set to InvalidElementId, it will be the default - the id of the BaseRailingAttr containing the Baluster pattern.
    double ExcessLengthFillSpacing { get; set; }
      Description: The value defines the spacing between each baluster instance inserted in the excess length.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Length { get; }
      Description: The length of the main baluster pattern.
    double PatternAngle { get; set; }
      Description: The angle between neighboring railing segments which conditions breaking patterns distribution along a railing path.

  METHODS:
    void Dispose()
    BalusterInfo DuplicateBaluster(int index)
      Description: Duplicates the baluster pointed by given index in the main baluster pattern.
      @index: Baluster index.
      Returns: The duplicated baluster.
      Throws ArgumentOutOfRangeException: The index index is out of range.
    BalusterInfo GetBaluster(int index)
      Description: Gets information about the given baluster from the main baluster pattern.
      @index: The baluster index.
      Returns: The requested baluster or if index is out of range.
    int GetBalusterCount()
      Description: Gets the number of balusters in the main baluster pattern definition.
      Returns: The number of balusters in the main baluster pattern.
    void RemoveBaluster(int index)
      Description: Removes a baluster from the main baluster pattern.
      @index: Baluster index.
      Throws ArgumentOutOfRangeException: The index index is out of range.

--------------------------------------------------------------------------------

[CLASS] BalusterPlacement
Full Name: Autodesk.Revit.DB.Architecture.BalusterPlacement
Description: A class which contains information regarding baluster and post placement for a given railing type.
Implements: IDisposable

  PROPERTIES:
    BalusterPattern BalusterPattern { get; }
      Description: Accesses the object containing properties related to the baluster pattern.
    ElementId BalusterPerTreadFamilyId { get; set; }
      Description: The id of baluster per tread family.
    int BalusterPerTreadNumber { get; set; }
      Description: The number of balusters per tread.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    PostPattern PostPattern { get; }
      Description: Accesses the object containing properties related to the post pattern.
    bool UseBalusterPerTreadOnStairs { get; set; }
      Description: If true, one or more balusters will be included on each tread of an associated stair. If false, this is not guaranteed to happen.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] BreakCornerCondition
Full Name: Autodesk.Revit.DB.Architecture.BreakCornerCondition
Description: Condition on which the corner post is inserted.
Inherits: Enum

  Values:
    - EachSegmentEnd = 0
    - AnglesGreaterThan = 1
    - Never = 2

--------------------------------------------------------------------------------

[ENUM] BreakPatternCondition
Full Name: Autodesk.Revit.DB.Architecture.BreakPatternCondition
Description: Condition on which patterns distribution will be broken.
Inherits: Enum

  Values:
    - EachSegmentEnd = 0
    - AnglesGreaterThan = 1
    - Never = 2

--------------------------------------------------------------------------------

[CLASS] BuildingPad
Full Name: Autodesk.Revit.DB.Architecture.BuildingPad
Description: Represents a BuildingPad element.
Inherits: CeilingAndFloor

  PROPERTIES:
    ElementId AssociatedTopographySurfaceId { get; }
      Description: The element id of a topography surface created by the introduction of this building pad.
    ElementId HostId { get; }
      Description: The element id of the topography surface hosting this BuidlingPad.

  METHODS:
    static BuildingPad Create(Document document, ElementId buildingPadTypeId, ElementId levelId, IList<CurveLoop> curveLoops)
      Description: Creates a new BuildingPad element and adds it to the document.
      @document: The document to be modified.
      @buildingPadTypeId: The type id set to the BuildingPad.
      @levelId: The level id set to the BuildingPad.
      @curveLoops: The boundary of the BuildingPad.
      Returns: The new BuildingPad element.
      Throws ArgumentException: The buildingPadTypeId is not a valid type id for a BuildingPad. -or- The ElementId levelId is not a Level. -or- The input curve loops cannot compose a valid boundary, that means: no curve loop is contained in the given collection; these curve loops intersect with each other for some of them; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the Sketch for the boundary of new created BuildingPad. -or- Cannot find an appropriate hosting topography surface for this BuildingPad. -or- This topography surface cannot be the host of this BuildingPad. -or- The given curve loops intersect with curve loops of existing BuildingPads hosted on the same TopographySurface. -or- There is at least one existing SubRegion which is completely inside or overlap the boundary of current BuildingPad hosted on the same TopographySurface. This behavior is not allowed.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    IList<CurveLoop> GetBoundary()
      Description: Gets the boundary of current BuildingPad element.
      Returns: The curve loops that represent the boundary of the BuildingPad.
    void SetBoundary(IList<CurveLoop> curveLoops)
      Description: Set a given curve loops as the boundary of the current BuildingPad element.
      @curveLoops: A collection of curve loops to be added.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: no curve loop is contained in the given collection; these curve loops intersect with each other for some of them; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the Sketch for the boundary of current BuildingPad. -or- Cannot find an appropriate hosting topography surface for this BuildingPad. -or- This topography surface cannot be the host of this BuildingPad. -or- The given curve loops intersect with curve loops of existing BuildingPads hosted on the same TopographySurface. -or- There is at least one existing SubRegion which is completely inside or overlap the boundary of current BuildingPad hosted on the same TopographySurface. This behavior is not allowed.
      Throws ModificationForbiddenException: The document containing this BuildingPad is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this BuildingPad is being loaded, or is in the midst of another
      Throws ModificationOutsideTransactionException: The document containing this BuildingPad has no open transaction.

--------------------------------------------------------------------------------

[CLASS] ContinuousRail
Full Name: Autodesk.Revit.DB.Architecture.ContinuousRail
Description: Represents a continuous rail element in Autodesk Revit.
Inherits: Element

  PROPERTIES:
    ElementId HostRailingId { get; }
      Description: The id of the host Railing that contains this rail.
    double Length { get; }
      Description: The length of the rail.

  METHODS:
    IList<Curve> GetEndExtensionPath()
      Description: Retrieves the start extension path.
      Returns: The start extension path of the rail.
    IList<Curve> GetPath()
      Description: Retrieves the rail path.
      Returns: The path of the rail.
    IList<Curve> GetStartExtensionPath()
      Description: Retrieves the start extension path.
      Returns: The start extension path of the rail.
    IList<ElementId> GetSupports()
      Description: Returns all the railing supports attached to the rail.

--------------------------------------------------------------------------------

[CLASS] ContinuousRailType
Full Name: Autodesk.Revit.DB.Architecture.ContinuousRailType
Description: A type element containing the properties of a continuous rail.
Inherits: ElementType

  PROPERTIES:
    RailTypeDefaultJoinOption DefaultJoinOption { get; set; }
      Description: The default join option between two rails.
    double EndOrTopExtensionLength { get; set; }
      Description: The extension length of the rail termination at the end or top.
    RailExtensionStyle EndOrTopExtensionStyle { get; set; }
      Description: The extension style of the rail termination at the end or top.
    ElementId EndOrTopTermination { get; set; }
      Description: The termination of the rail at the end or top.
    double FilletRadius { get; set; }
      Description: The fillet radius of the rail join.
    double HandClearance { get; set; }
      Description: The horizontal distance between the inner boundary of the rail and the path.
    ElementId ProfileId { get; set; }
      Description: The id of the profile of the rail
    double Projection { get; }
      Description: The horizontal distance between the outer boundary of the rail and the path.
    double StartOrBottomExtensionLength { get; set; }
      Description: The extension length of the rail termination at the beginning or bottom.
    RailExtensionStyle StartOrBottomExtensionStyle { get; set; }
      Description: The extension style of the rail termination at the beginning or bottom.
    ElementId StartOrBottomTermination { get; set; }
      Description: The termination of the rail at the beginning or bottom.
    RailTransitionOption Transition { get; set; }
      Description: The transition option of the rail.

--------------------------------------------------------------------------------

[ENUM] CutLineType
Full Name: Autodesk.Revit.DB.Architecture.CutLineType
Description: The available line types for a stairs cut line.
Inherits: Enum

  Values:
    - SingleLine = 0
    - DoubleLine = 1

--------------------------------------------------------------------------------

[ENUM] CutMarkSymbol
Full Name: Autodesk.Revit.DB.Architecture.CutMarkSymbol
Description: The available shapes for the cut mark symbol.
Inherits: Enum

  Values:
    - None = 0
    - Zigzag = 1
    - Curve = 2

--------------------------------------------------------------------------------

[CLASS] CutMarkType
Full Name: Autodesk.Revit.DB.Architecture.CutMarkType
Description: An object represents the cut mark type in Autodesk Revit.
Inherits: ElementType

  PROPERTIES:
    double CutLineAngle { get; set; }
      Description: The rotation angle of the cut mark.
    double CutLineDistance { get; set; }
      Description: The distance between 2 cut lines.
    double CutLineExtension { get; set; }
      Description: The extension distance to the boundary.
    CutLineType CutLineType { get; set; }
      Description: The cut line type of the cut mark.
    CutMarkSymbol CutMarkSymbol { get; set; }
      Description: The symbol type of the cut mark.
    double CutMarkSymbolSize { get; set; }
      Description: The size of the cut mark symbol.

--------------------------------------------------------------------------------

[CLASS] Fascia
Full Name: Autodesk.Revit.DB.Architecture.Fascia
Description: An object that represents a fascia within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object.
Inherits: HostedSweep

  PROPERTIES:
    FasciaType FasciaType { get; set; }
      Description: Retrieves/set an object that represents the type of the Fascia.

  METHODS:
    void AddSegment(Reference targetRef)
      Description: Add segments to the fascia.
      @targetRef: Segment's reference on which want to be added.
      Throws ArgumentNullException: This exception will be thrown in following cases: 1. Input targetRef is . 2. Input targetRef is not but contains nothing.
      Throws InvalidOperationException: This exception will be thrown in following cases: 1. Input targetRef has already been added into the fascia. 2. Internal code fails to create the segment object. 3. Regeneration fails.
      Throws ArgumentOutOfRangeException: This exception will be thrown if the reference is suitable for creating a fascia as required. The reference allowed is : 1. Model Line 2. Roof's horizontal edges 3. Soffit's horizontal edges 4. Other fascia's horizontal edges

--------------------------------------------------------------------------------

[CLASS] FasciaType
Full Name: Autodesk.Revit.DB.Architecture.FasciaType
Description: An object that represents the fascia type in Autodesk Revit.
Inherits: HostedSweepType

--------------------------------------------------------------------------------

[CLASS] Gutter
Full Name: Autodesk.Revit.DB.Architecture.Gutter
Description: An object that represents a gutter within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object.
Inherits: HostedSweep

  PROPERTIES:
    GutterType GutterType { get; set; }
      Description: Retrieves/set an object that represents the type of the Gutter.

  METHODS:
    void AddSegment(Reference targetRef)
      Description: Add segments to the gutter.
      @targetRef: Segment's reference on which want to be added.
      Throws ArgumentNullException: This exception will be thrown in following cases: 1. Input targetRef is null. 2. Input targetRef is not null but contains nothing.
      Throws InvalidOperationException: This exception will be thrown in following cases: 1. Input targetRef has already been added into the gutter. 2. Internal code fails to create the segment object. 3. Regeneration fails.
      Throws ArgumentOutOfRangeException: This exception will be thrown if the reference is not suitable for creating a gutter as required. The reference allowed is : 1. Model Line 2. Roof's horizontal edges 3. Soffit's horizontal edges 4. Fascia's horizontal edges

--------------------------------------------------------------------------------

[CLASS] GutterType
Full Name: Autodesk.Revit.DB.Architecture.GutterType
Description: An object that represents the gutter type in Autodesk Revit.
Inherits: HostedSweepType

--------------------------------------------------------------------------------

[CLASS] HandRail
Full Name: Autodesk.Revit.DB.Architecture.HandRail
Description: Represents a hand rail element in Autodesk Revit.
Inherits: ContinuousRail

--------------------------------------------------------------------------------

[ENUM] HandRailPosition
Full Name: Autodesk.Revit.DB.Architecture.HandRailPosition
Description: The position of the hand rail.
Inherits: Enum

  Values:
    - None = 0
    - Left = 1
    - Right = 2
    - LeftAndRight = 3

--------------------------------------------------------------------------------

[CLASS] HandRailType
Full Name: Autodesk.Revit.DB.Architecture.HandRailType
Description: A rail type object that is used in the generation of hand rail.
Inherits: ContinuousRailType

  PROPERTIES:
    double Height { get; set; }
      Description: The height of the handrail.
    RailSupportJustification SupportJustification { get; set; }
      Description: The support justification method of the handrail.
    RailSupportsLayout SupportLayout { get; set; }
      Description: The support layout method of the handrail.
    int SupportNumber { get; set; }
      Description: The number of supports of the handrail.
    double SupportSpacing { get; set; }
      Description: The support spacing of the handrail.
    ElementId SupportTypeId { get; set; }
      Description: The support type of the handrail.

--------------------------------------------------------------------------------

[CLASS] MultistoryStairs
Full Name: Autodesk.Revit.DB.Architecture.MultistoryStairs
Description: Represents a multistory stairs element in Autodesk Revit.
Remarks: A multistory stairs element may contain multiple stairs whose extents are governed by base and top levels. Use ElementId}) and ElementId}) to add and remove connected levels to a multistory stairs element.This element will contain one or more Stairs elements. These can be obtained via GetAllStairsIds and ElementId). Stairs elements are either a reference instance which is copied to each level covered by groups of identical stairs instances which share the same level height, or individual Stairs instances which are not connected to a group with the same level height. By default, when adding new levels to the multistory stair, new stairs will be added to the group (shown in the Revit user interface with a 'Pin' icon).For groups of duplicate stairs at different levels, the instances can be found as Subelements of the Stairs element (see GetSubelements.Stairs in a connected group can be edited together by modifying the associated Stairs instance. For specific floors that need special designs, stairs can be separated from a group by unpinning the element, changes made to this Stairs will not affect other any other instance in the element. Use ElementId) for this.You can add the stairs back into the group via ElementId) if needed. However, any changes made to the stair will be lost since the stair's properties will be overridden by the group specifications.
Inherits: Element

  PROPERTIES:
    double ActualTreadDepth { get; set; }
      Description: The actual depth of the stairs treads in the stairs, actual tread depth is equal to minimum tread depth by default.
    ElementId StandardStairsId { get; }
      Description: Id of the stair associated with the Reference Level for the multistory stairs. The standard stair is regarded as a definition to generate new stairs when extending multistory stairs to a different level height.

  METHODS:
    bool CanConnectLevel(ElementId levelId)
      Description: Checks if the given level can be connected into multistory stairs. You cannot connect levels between standard stairs top and bottom or already connected.
      @levelId: The id of the level.
      Returns: True if the level can be connected to this multistory stairs, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanDisconnectLevel(ElementId levelId)
      Description: Checks if the given level can be disconnected from multistory stairs. You cannot disconnect the levels of standard stair (the stair associated with the Reference Level for the multistory stairs) or already disconnected.
      @levelId: The id of the level.
      Returns: True if the level id can be used to remove stairs.
      Throws ArgumentNullException: A non-optional argument was null
    void ConnectLevels(ISet<ElementId> levelIds)
      Description: Extends the multistory stairs by connecting input levels.
      @levelIds: The level ids.
      Throws ArgumentException: This multistory stairs cannot connect to one or more members of levelIds.
      Throws ArgumentNullException: A non-optional argument was null
    static MultistoryStairs Create(Stairs stairs)
      Description: Creates a multistory stairs from an existing component-based stairs.
      @stairs: A component-based stairs.
      Returns: The newly created element. Use ElementId}) to extend this to multiple stories and generate stairs groups for each level height.
      Throws ArgumentNullException: A non-optional argument was null
    void DisconnectLevels(ISet<ElementId> levelIds)
      Description: Shrinks the multistory stairs by disconnecting input levels.
      @levelIds: The level ids.
      Throws ArgumentException: This multistory stairs cannot disconnect from one or more members of levelIds.
      Throws ArgumentNullException: A non-optional argument was null
    ISet<ElementId> GetAllConnectedLevels()
      Description: Gets all connected level ids of this multistory stairs.
      Returns: The ids of connected levels.
    ISet<ElementId> GetAllStairsIds()
      Description: Gets the ids of all the stairs in this multistory stairs.
      Returns: The ids of the stairs elements that govern groups of stairs, and the stairs elements that represent individual stairs.
    Stairs GetStairsOnLevel(ElementId levelId)
      Description: Gets the individual stairs or stairs group on the given base level.
      @levelId: The base level id.
      Returns: The id of stairs element on the given level.
      Throws ArgumentNullException: A non-optional argument was null
    ISet<ElementId> GetStairsPlacementLevels(Stairs stairs)
      Description: Gets all the levels the given stairs group placed on.
      @stairs: A stairs element in this multistory stairs element.
      Returns: The ids of base levels of the given stairs in this multistory stairs.
      Throws ArgumentException: The input stairs is not a member of this multistory stairs.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAcceptableForMultistoryStairs(Stairs stairs)
      Description: Checks if the given stairs can be used to create a multistory stairs.
      @stairs: The given stairs to check.
      Returns: Returns true if the stairs can be used to create a multistory stairs; otherwise returns false.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsPinned(Stairs stairs)
      Description: Checks if a stair is pinned.
      @stairs: A stairs element in this multistory stairs element.
      Returns: Returns true if the stairs is pinned; otherwise returns false.
      Throws ArgumentException: The input stairs is not a member of this multistory stairs.
      Throws ArgumentNullException: A non-optional argument was null
    Stairs Pin(ElementId levelId)
      Description: Restores an unpinned stairs element back into the group of stairs governed by level height.
      @levelId: The base level id. If the level id belongs to the base level of an individual pinned stairs, it returns the stairs id directly.
      Returns: The stairs element which the pinned story belongs to.
      Throws ArgumentException: There is no stairs instance at the given base levelId.
      Throws ArgumentNullException: A non-optional argument was null
    Stairs Unpin(ElementId levelId)
      Description: Removes a particular story of the stairs (identified by its base level id) from a stairs group.
      @levelId: The base level id. If the level id belongs to the base level of a unpinned stairs element, it returns the stairs id directly.
      Returns: The unpinned stairs element.
      Throws ArgumentException: There is no stairs instance at the given base levelId.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] NonContinuousRailInfo
Full Name: Autodesk.Revit.DB.Architecture.NonContinuousRailInfo
Description: A class which contains information needed to define a single non-continuous rail in a Autodesk::Revit::DB::Architecture::RailingType.
Implements: IDisposable

  PROPERTIES:
    double Height { get; set; }
      Description: The height at which the non-continuous rail will be placed.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId MaterialId { get; set; }
      Description: The material id associated with the non-continuous rail, or invalidElementId if none.
    string Name { get; set; }
      Description: The name of the non-continuous rail.
    double Offset { get; set; }
      Description: The side offset of the non-continuous rail from a Autodesk::Revit::DB::Architecture::Railing from the railing center.
    ElementId ProfileId { get; set; }
      Description: The profile id of the non-continuous rail, or invalidElementId if none.

  METHODS:
    void Dispose()
    bool IsValidNonContinuousRailHeight(double height)
      Description: Checks whether the input height is valid for a non-continuous rail in its associated railing type.
      @height: The height to be checked.
      Returns: True if the height is smaller than the height of Autodesk::Revit::DB::Architecture::RailingType, false otherwise.
    bool IsValidNonContinuousRailMaterial(ElementId materialId)
      Description: Checks whether an ElementId is a valid material Id of a non-continuous rail.
      @materialId: The material Id to be checked.
      Returns: True if the ElementId refers to a valid material or it is invalidElementId, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidNonContinuousRailName(string name)
      Description: Checks whether the input name is valid for a non-continuous rail in its associated railing type.
      @name: The name to be checked.
      Returns: True if the name is unique for the Autodesk::Revit::DB::Architecture::RailingType, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidNonContinuousRailProfile(ElementId profileId)
      Description: Checks whether the input id represents a profile which can be used as the profile of this non-continuous rail.
      @profileId: The profile Id to be checked.
      Returns: True if the ElementId refers to a valid NonContinuousRail profile, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] NonContinuousRailStructure
Full Name: Autodesk.Revit.DB.Architecture.NonContinuousRailStructure
Description: A class that represents a collection of Non-Continuous Rails being a part of Railing Type.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    NonContinuousRailInfo AddNonContinuousRail(string name, double height, double offset)
      Description: Creates and appends a new Non-Continuous Rail to the Rail Structure. The new Non-Continuous Rail will have the given name, height and offset. It will have default profile and material ElementIds.
      @name: The name of the non-continuous rail.
      @height: The height on which the non-continuous rail will be placed.
      @offset: The offset of the non-continuous rail from a Railing center.
      Returns: Handle to the new Non-Continuous Rail.
      Throws ArgumentException: name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The name is a duplicate of an existing non-continuous rail. -or- The height height is not valid for the non-continuous rail because it is greater than the height of the RailingType to which it belongs.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for height must be no more than 30000 feet in absolute value. -or- The given value for offset must be no more than 30000 feet in absolute value.
    void Dispose()
    NonContinuousRailInfo GetNonContinuousRail(int index)
      Description: Gets the Non-Continuous Rail object of specified index from the Rail Structure.
      @index: Non-Continuous Rail index.
      Returns: The requested object handle.
      Throws ArgumentOutOfRangeException: The index index is out of range.
    int GetNonContinuousRailCount()
      Description: Gets number of Non-Continuous Rails.
      Returns: Count of Non-Continuous Rails.
    bool IsValidNonContinuousRailProfile(ElementId profileId)
      Description: Checks whether the input id represents a profile which can be used as the profile of this non-continuous rail.
      @profileId: The profile Id to be checked.
      Returns: True if the ElementId refers to a valid NonContinuousRail profile, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveNonContinuousRail(int index)
      Description: Removes Non-Continuous Rail from the Rail Structure.
      @index: Non-Continuous Rail index.
      Throws ArgumentOutOfRangeException: The index index is out of range.

--------------------------------------------------------------------------------

[CLASS] NumberSystemType
Full Name: Autodesk.Revit.DB.Architecture.NumberSystemType
Description: An object represents the stairs treads/risers numbering type. for serialization
Inherits: ElementType

--------------------------------------------------------------------------------

[ENUM] PatternJustification
Full Name: Autodesk.Revit.DB.Architecture.PatternJustification
Description: Justification of patterns distribution.
Inherits: Enum

  Values:
    - Beginning = 0
    - End = 1
    - Center = 2
    - SpreadPatternToFit = 3

--------------------------------------------------------------------------------

[CLASS] PostPattern
Full Name: Autodesk.Revit.DB.Architecture.PostPattern
Description: Post pattern class.
Implements: IDisposable

  PROPERTIES:
    BalusterInfo CornerPost { get; }
      Description: Accesses the object containing properties related to the corner post.
    double CornerPostAngle { get; set; }
      Description: The angle between neighboring railing segments which conditions inserting post along a railing path.
    BreakCornerCondition CornerPostCondition { get; set; }
      Description: The condition which controls the insertion of corner posts.
    BalusterInfo EndPost { get; }
      Description: Accesses the object containing properties related to the end post.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    BalusterInfo StartPost { get; }
      Description: Accesses the object containing properties related to the start post.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] RailAngledJoinOption
Full Name: Autodesk.Revit.DB.Architecture.RailAngledJoinOption
Description: The angled joins of the rails.
Inherits: Enum

  Values:
    - AddVerticalOrHorizontalSegments = 0
    - NoConnector = 1

--------------------------------------------------------------------------------

[ENUM] RailConnectionOption
Full Name: Autodesk.Revit.DB.Architecture.RailConnectionOption
Description: The connections between rails.
Inherits: Enum

  Values:
    - Trim = 0
    - Weld = 1

--------------------------------------------------------------------------------

[ENUM] RailExtensionStyle
Full Name: Autodesk.Revit.DB.Architecture.RailExtensionStyle
Description: The extension style of the rail.
Inherits: Enum

  Values:
    - None = 0
    - Wall = 1
    - Floor = 2
    - Post = 3

--------------------------------------------------------------------------------

[ENUM] RailIndex
Full Name: Autodesk.Revit.DB.Architecture.RailIndex
Description: The continuous rail position index.
Inherits: Enum

  Values:
    - Top = 0
    - LeftPrimary = 1
    - RightPrimary = 2
    - LeftSecondary = 3
    - RightSecondary = 4

--------------------------------------------------------------------------------

[CLASS] Railing
Full Name: Autodesk.Revit.DB.Architecture.Railing
Description: Represents a railing element in Autodesk Revit.
Inherits: Element

  PROPERTIES:
    bool CanReset { get; }
      Description: True if the railing can be reset, False otherwise.
    bool Flipped { get; }
      Description: Indicates if the railing is flipped.
    bool HasHost { get; }
      Description: Indicates if the railing has a host.
    ElementId HostId { get; set; }
      Description: The host of the railing.
    bool IsDefault { get; }
      Description: Indicates if the railing is the default one that system generates.
    ElementId TopRail { get; }
      Description: The top rail of the railing.

  METHODS:
    static ISet<ElementId> Create(Document document, ElementId multistoryStairsId, ElementId levelId, ElementId railingTypeId, RailingPlacementPosition placePosition)
      Description: Creates new railings with the specified railing type on all sides of a stairs instance in a MultistoryStairs element.
      @document: The document.
      @multistoryStairsId: The id of the MultistoryStairs that contains the stairs which will be the host of this railing. The stairs should have no associated railings yet.
      @levelId: The level of stairs on which the new railing will be created. The level should be one of levels defining the MultistoryStairs element.
      @railingTypeId: The railing type of the new railing to be created.
      @placePosition: The placement position of the new railing.
      Returns: The new railing instances successfully created on the stairs.
      Throws ArgumentException: The railingTypeId is not a railing type. -or- The ElementId levelId is not a Level. -or- The levelId is not a level of MultistoryStairs stairs element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The multistoryStairsId already has associated railings or is in editing mode so association of railings is not permitted.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Railing Create(Document document, CurveLoop curveLoop, ElementId railingTypeId, ElementId baseLevelId)
      Description: Creates a new railing by specifying the railing path in the project document.
      @document: The document.
      @curveLoop: The railing path along which the new railing will be created. The curveLoop should be continuous with curves which are only bounded lines and arcs on the same horizontal plane. It also has to have maximum two curves meet in one end point.
      @railingTypeId: The railing type of the new railing to be created.
      @baseLevelId: The base level on which the new railing will be created.
      Returns: The new railing instance if creation was successful, otherwise .
      Throws ArgumentException: The curveLoop must be a single connected path, located on the same horizontal plane and defined using lines or arcs only. It also has to have maximum two curves meet in one end point. -or- The railingTypeId is not a railing type. -or- The ElementId baseLevelId is not a Level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ICollection<ElementId> Create(Document document, ElementId stairsOrRampId, ElementId railingTypeId, RailingPlacementPosition placePosition)
      Description: Automatically creates new railings with the specified railing type on all sides of a stairs or ramp element.
      @document: The document.
      @stairsOrRampId: The stairs or ramp to which the new railing will host. The stairs or ramp should have no associated railings yet. If the stairs are a part of MultistoryStairs element railings will be populated on all levels.
      @railingTypeId: The railing type of the new railing to be created.
      @placePosition: The placement position of the new railing.
      Returns: The new railing instances successfully created on the stairs.
      Throws ArgumentException: The stairsOrRampId is not a stairs or ramp element. -or- The railingTypeId is not a railing type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The stairsOrRampId already has associated railings or is in editing mode so association of railings is not permitted.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Flip()
      Description: Flips the railing.
      Throws InapplicableDataException: The railing has incorrect internal data.
    IList<ElementId> GetHandRails()
      Description: Get all the handrails of the railing.
      Returns: All handrails of the railing.
    ISet<ElementId> GetMultistoryStairsPlacementLevels()
      Description: Gets the ids of the base levels of the stairs upon which this railing is placed.
      Returns: The ids of levels the railing is placed on. The returned set consists of a subset of the base level ids of the corresponding stairs in the MultistoryStairs.
      Throws InvalidOperationException: The railing is not hosted by stairs in MultistoryStairs.
    IList<Curve> GetPath()
      Description: Gets the railing path.
      Returns: The curve array of the railing path.
      Throws InapplicableDataException: The railing has incorrect internal data.
    Subelement GetSubelementOnLevel(ElementId levelId)
      Description: Gets the subelement on given level.
      @levelId: The id of the level the railing subelement is placed on.
      Returns: The subelement in given level. will be returned if railing has no subelements on given level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The railing is not hosted by stairs in MultistoryStairs.
    static bool IsValidHostForNewRailing(Document document, ElementId elementId)
      Description: Checks whether new railing can be created and placed on the specified host.
      @document: The document.
      @elementId: The element to check.
      Returns: True if new railing can be created and placed on the host, False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidPathForRailing(CurveLoop curveLoop)
      Description: Checks whether a railing can be created along a railing path.
      @curveLoop: The railing path along which the new railing will be created.
      Returns: True if the new railing path can be used in a railing definition, False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool RailingCanBeHostedByElement(ElementId hostId)
      Description: Checks whether the specified element can be used as a host for the railing. The host can be: stairsstairs componentrampfloorslab edgewallroof
      @hostId: Element id to check.
      Returns: True if the element can be used as host for the railing.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveHost()
      Description: Removes the association between the railing and its host.
    void Reset()
      Description: Resets the railing to the default one that the system generates.
      Throws InvalidOperationException: Cannot reset the railing.
    void ResetSupportPosition()
      Description: Resets the continuous rails support subelements position data.
    void SetMultistoryStairsPlacementLevels(ISet<ElementId> levelIds)
      Description: Sets the ids of the base levels of the stairs upon which this railing is placed.
      @levelIds: The ids of levels the railing is placed on. If input level id set is empty, railings will placed on all levels of the hosting stairs.
      Throws ArgumentException: All of the level ids in levelIds must be placement levels of stairs.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The railing is not hosted by stairs in MultistoryStairs.
    void SetPath(CurveLoop curveLoop)
      Description: Sets the railing path.
      @curveLoop: The railing path along which the new railing will be created. The curveLoop should be continuous with curves which are only bounded lines and arcs on the same horizontal plane. It also has to have maximum two curves meet in one end point.
      Throws ArgumentException: The curveLoop must be a single connected path, located on the same horizontal plane and defined using lines or arcs only. It also has to have maximum two curves meet in one end point.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InapplicableDataException: The railing has incorrect internal data.

--------------------------------------------------------------------------------

[ENUM] RailingHeightCorrectionOption
Full Name: Autodesk.Revit.DB.Architecture.RailingHeightCorrectionOption
Description: Railing height correction option.
Inherits: Enum

  Values:
    - ByType = 0
    - Custom = 1

--------------------------------------------------------------------------------

[ENUM] RailingPathCurveJoinOption
Full Name: Autodesk.Revit.DB.Architecture.RailingPathCurveJoinOption
Description: The join type of the railing path.
Inherits: Enum

  Values:
    - ByType = 0
    - ExtendRailsToMeet = 1
    - AddVerticalOrHorizontalSegments = 2
    - NoConnector = 3

--------------------------------------------------------------------------------

[ENUM] RailingPlacementPosition
Full Name: Autodesk.Revit.DB.Architecture.RailingPlacementPosition
Description: Railing placement position.
Inherits: Enum

  Values:
    - Treads = 0
    - Stringer = 1
    - Undefined = -1

--------------------------------------------------------------------------------

[ENUM] RailingSlopeOption
Full Name: Autodesk.Revit.DB.Architecture.RailingSlopeOption
Description: The option determines the slope of the railing.
Inherits: Enum

  Values:
    - ByHost = 0
    - Flat = 1
    - Sloped = 2

--------------------------------------------------------------------------------

[CLASS] RailingType
Full Name: Autodesk.Revit.DB.Architecture.RailingType
Description: An object supporting management of baluster and post placement within the railing type.
Inherits: ElementType

  PROPERTIES:
    BalusterPlacement BalusterPlacement { get; }
      Description: Accesses the object containing properties related to the baluster placement.
    double PrimaryHandrailHeight { get; }
      Description: The height of the primary handrail.
    double PrimaryHandrailLateralOffset { get; }
      Description: The lateral offset of the primary handrail.
    HandRailPosition PrimaryHandRailPosition { get; set; }
      Description: The position of the primary handrail.
    ElementId PrimaryHandrailType { get; set; }
      Description: The type of the primary handrail.
    NonContinuousRailStructure RailStructure { get; }
      Description: The NonContinuousRailStructure.
    double SecondaryHandrailHeight { get; }
      Description: The height of the secondary handrail.
    double SecondaryHandrailLateralOffset { get; }
      Description: The lateral offset of the secondary handrail.
    HandRailPosition SecondaryHandRailPosition { get; set; }
      Description: The position of the secondary handrail.
    ElementId SecondaryHandrailType { get; set; }
      Description: The type of the secondary handrail.
    double TopRailHeight { get; set; }
      Description: The height of the top rail in the railing system.
    ElementId TopRailType { get; set; }
      Description: The type of the top rail in the railing system.

--------------------------------------------------------------------------------

[ENUM] RailJoinOption
Full Name: Autodesk.Revit.DB.Architecture.RailJoinOption
Description: The join type of the system rails.
Inherits: Enum

  Values:
    - Miter = 0
    - Fillet = 1
    - ByType = -1

--------------------------------------------------------------------------------

[ENUM] RailSupportJustification
Full Name: Autodesk.Revit.DB.Architecture.RailSupportJustification
Description: The justification of the rail supports.
Inherits: Enum

  Values:
    - Begin = 0
    - Center = 1
    - End = 2

--------------------------------------------------------------------------------

[ENUM] RailSupportsLayout
Full Name: Autodesk.Revit.DB.Architecture.RailSupportsLayout
Description: The layout of the rail supports.
Inherits: Enum

  Values:
    - None = 0
    - FixedDistance = 1
    - AlignWithRailingPosts = 2
    - FixedNumber = 3
    - MaxSpacing = 4
    - MinSpacing = 5

--------------------------------------------------------------------------------

[ENUM] RailTagentJoinOption
Full Name: Autodesk.Revit.DB.Architecture.RailTagentJoinOption
Description: The tangent joins of the rails.
Inherits: Enum

  Values:
    - AddVerticalOrHorizontalSegments = 0
    - NoConnector = 1
    - ExtendRailsToMeet = 2

--------------------------------------------------------------------------------

[ENUM] RailTransitionOption
Full Name: Autodesk.Revit.DB.Architecture.RailTransitionOption
Description: The transition type of the continuous rail.
Inherits: Enum

  Values:
    - None = 0
    - Gooseneck = 1
    - Simple = 2

--------------------------------------------------------------------------------

[ENUM] RailTypeDefaultJoinOption
Full Name: Autodesk.Revit.DB.Architecture.RailTypeDefaultJoinOption
Description: The default join type of the rail.
Inherits: Enum

  Values:
    - Miter = 0
    - Fillet = 1

--------------------------------------------------------------------------------

[ENUM] RiserToTreadConnectionOption
Full Name: Autodesk.Revit.DB.Architecture.RiserToTreadConnectionOption
Description: Represents the connection style of the riser and tread in relation to each other.
Inherits: Enum

  Values:
    - RiserBehindTread = 0
    - TreadUnderRiser = 1
    - JoinAll = 2

--------------------------------------------------------------------------------

[CLASS] Room
Full Name: Autodesk.Revit.DB.Architecture.Room
Description: Provides access to the room topology in Autodesk Revit.
Remarks: The room object can be queried for its boundary for use in space planning tools.
Inherits: SpatialElement

  PROPERTIES:
    double BaseOffset { get; set; }
      Description: Get or Set the Base Offset of the Room.
    GeometryElement ClosedShell { get; }
      Description: Return the closedShell of the Room.
    double LimitOffset { get; set; }
      Description: Get or Set the Limit Offset of the Room.
    double UnboundedHeight { get; }
      Description: Get the Unbounded Height of the Room.
    Level UpperLimit { get; set; }
      Description: Get or Set the Upper Limit of the Room.
    double Volume { get; }
      Description: Get the Volume of the Room.

  METHODS:
    bool IsPointInRoom(XYZ point)
      Description: Determines if a point lies within the volume of the room.
      @point: Point to be checked.
      Throws ArgumentNullException: Thrown when the point is .
      Throws ArgumentException: The coordinates of the point is not a number.
    void Unplace()
      Description: Remove the room from its location, but the project still contains the room. The room can be placed in another location after unplaced.

--------------------------------------------------------------------------------

[CLASS] RoomFilter
Full Name: Autodesk.Revit.DB.Architecture.RoomFilter
Description: A filter used to match rooms.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new RoomFilter()
      Description: Constructs a filter which matches only rooms.

--------------------------------------------------------------------------------

[CLASS] RoomTag
Full Name: Autodesk.Revit.DB.Architecture.RoomTag
Description: Provides access to the room tag in Autodesk Revit.
Inherits: SpatialElementTag

  PROPERTIES:
    bool IsInRoom { get; }
      Description: Identifies if the tag is located in a room.
    Room Room { get; }
      Description: The room that the tag is associated with.
    RoomTagType RoomTagType { get; set; }
      Description: The tag type.
    ElementId TaggedLocalRoomId { get; }
      Description: The ElementId of the tagged room.
    LinkElementId TaggedRoomId { get; }
      Description: The LinkElementId of the tagged room.

--------------------------------------------------------------------------------

[CLASS] RoomTagFilter
Full Name: Autodesk.Revit.DB.Architecture.RoomTagFilter
Description: A filter used to match room tags.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new RoomTagFilter()
      Description: Constructs a filter which matches only rooms.

--------------------------------------------------------------------------------

[CLASS] RoomTagType
Full Name: Autodesk.Revit.DB.Architecture.RoomTagType
Description: An object that represents a Room Tag type.
Inherits: FamilySymbol

--------------------------------------------------------------------------------

[CLASS] SiteSubRegion
Full Name: Autodesk.Revit.DB.Architecture.SiteSubRegion
Description: Represents a proxy class exposing the interfaces needed to access details of a subregion.
Remarks: In the Revit database, both TopographySurface elements and subregion elements are represented by the same TopographySurface element subclass. In the Revit API, this SiteSubRegion class exists to separate the interfaces for subregions from those of topography surfaces.
Implements: IDisposable

  PROPERTIES:
    ElementId HostId { get; }
      Description: The element id of the topography surface hosting this SiteSubRegion.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    TopographySurface TopographySurface { get; }
      Description: The TopographySurface element which this SiteSubRegion represents.

  METHODS:
    static SiteSubRegion Create(Document document, IList<CurveLoop> curveLoops, ElementId hostTopoSurfaceId)
      Description: Creates a new SiteSubRegion element with assigned TopographySurface to be hosted and adds it to the document.
      @document: The document to be modified.
      @curveLoops: The boundary of the subregion.
      @hostTopoSurfaceId: The element id of a TopographySurface assigned to be a host of new created SiteSubRegion.
      Returns: The new SubRegion surface.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: no curve loop is contained in the given collection; these curve loops intersect with each other for some of them; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane. -or- The ElementId hostTopoSurfaceId does not represent a TopographySurface.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the Sketch for the boundary of the current Subregion. -or- Cannot associate the new subregion with the assigned host because there is no geometric overlap, or they have mismatched design options. -or- The given curve loops intersect with curve loops of existing SiteSubRegions hosted on the same TopographySurface. -or- The boundary of SubRegion is entirely inside or overlaps at least one existing BuildingPad hosted on the same TopographySurface. This behavior is not allowed.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static SiteSubRegion Create(Document document, IList<CurveLoop> curveLoops)
      Description: Creates a new SiteSubRegion element and adds it to the document.
      @document: The document to be modified.
      @curveLoops: The boundary of the subregion.
      Returns: The new SubRegion surface.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: no curve loop is contained in the given collection; these curve loops intersect with each other for some of them; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the Sketch for the boundary of the current Subregion. -or- Cannot find an appropriate host TopographySurface for the Subregion. -or- The given curve loops intersect with curve loops of existing SiteSubRegions hosted on the same TopographySurface. -or- The boundary of SubRegion is entirely inside or overlaps at least one existing BuildingPad hosted on the same TopographySurface. This behavior is not allowed.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Dispose()
    IList<CurveLoop> GetBoundary()
      Description: Gets the boundary of current subregion.
      Returns: The curve loops that represent the boundary.
    static bool IsValidBoundary(IList<CurveLoop> curveLoops)
      Description: Identifies whether the given curve loops compose a valid boundary.
      @curveLoops: The curve loops to be checked.
      Returns: True if the given curve loops don't intersect with each other; each curve loop is closed; and each loop is planar and lies on a plane parallel to the horizontal(XY) plane. Any requirement above is not satisfied or no curve loops contained, returns false.
      Throws ArgumentNullException: A non-optional argument was null
    void SetBoundary(IList<CurveLoop> curveLoops)
      Description: Set the given curve loops as the boundary of an existing SiteSubRegion.
      @curveLoops: A collection of curve loops to be added.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: no curve loop is contained in the given collection; these curve loops intersect with each other for some of them; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the Sketch for the boundary of the current Subregion. -or- Cannot find an appropriate host topography surface for the SubRegion. -or- The given curve loops intersect with curve loops of existing SiteSubRegions hosted on the same TopographySurface. -or- The boundary of SubRegion is entirely inside or overlaps at least one existing BuildingPad hosted on the same TopographySurface. This behavior is not allowed.
      Throws ModificationForbiddenException: The document containing this SiteSubRegion is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this SiteSubRegion is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this SiteSubRegion has no open transaction.

--------------------------------------------------------------------------------

[ENUM] SketchedCurveSlopeOption
Full Name: Autodesk.Revit.DB.Architecture.SketchedCurveSlopeOption
Description: The option determines the slop of the sketched run/landing.
Inherits: Enum

  Values:
    - Auto = 0
    - Flat = 1
    - Sloped = 2

--------------------------------------------------------------------------------

[CLASS] Stairs
Full Name: Autodesk.Revit.DB.Architecture.Stairs
Description: Represents a stairs element in Autodesk Revit.
Remarks: This element may represent a standalone Stairs element, or a member of a MultistoryStairs element. Use MultistoryStairsId to identify if this Stairs element is a part of a MultistoryStairs.
Inherits: Element

  PROPERTIES:
    double ActualRiserHeight { get; }
      Description: The actual height of the stairs risers in the stairs.
    int ActualRisersNumber { get; }
      Description: The total number of actually created risers in model.
    double ActualTreadDepth { get; set; }
      Description: The actual depth of the stairs treads in the stairs, actual tread depth is equal to minimum tread depth by default.
    int ActualTreadsNumber { get; }
      Description: The number of treads actually created in the stairs.
    double BaseElevation { get; }
      Description: The base elevation of the stairs.
    int DesiredRisersNumber { get; set; }
      Description: The number of risers is calculated based on the height between levels.
    double Height { get; set; }
      Description: The height of the stair between the base and top levels.
    ElementId MultistoryStairsId { get; }
      Description: The id of the MultistoryStairs element to which this element belongs. If this stairs element is not a member of a MultistoryStairs element, this will be InvalidElementId.
    int NumberOfStories { get; }
      Description: The number of stories of a multi-story stair, or 1 for a single-story stair.
    double TopElevation { get; }
      Description: The top elevation of the stairs.

  METHODS:
    ICollection<ElementId> GetAssociatedRailings()
      Description: Gets a list of the Railing elements which are associated to the boundaries of the stairs.
      Returns: The ids of the Railing elements.
    ICollection<ElementId> GetStairsLandings()
      Description: Returns all the stairs landing components in the stairs.
      Returns: The stairs landing components in the stairs.
    ICollection<ElementId> GetStairsRuns()
      Description: Returns all the stairs run components in the stairs.
      Returns: The stairs run components in the stairs.
    ICollection<ElementId> GetStairsSupports()
      Description: Returns all the stairs support components in the stairs.
    static bool IsByComponent(Document document, ElementId stairsId)
      Description: Indicates if the stairs is created by stairs components(runs, landings and supports).
      @document: The document.
      @stairsId: The stairs element to check.
      Returns: True if the stairs is created by components, False otherwise.
      Throws ArgumentException: The element stairsId does not exist in the document
      Throws ArgumentNullException: A non-optional argument was null
    bool IsInEditMode()
      Description: Indicates whether the stairs is in edit mode or not.

--------------------------------------------------------------------------------

[CLASS] StairsComponentConnection
Full Name: Autodesk.Revit.DB.Architecture.StairsComponentConnection
Description: Represents information about a connection among stairs components(run to landing).
Implements: IDisposable

  PROPERTIES:
    StairsComponentConnectionEndType ConnectionType { get; }
      Description: The connection type of the connected stairs component.
    ElementId ElementId { get; }
      Description: The element Id of connected stairs component in the stairs connection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    StairsComponentConnectionEndType PeerConnectionType { get; }
      Description: The connection type of the peer connected stairs component.
    ElementId PeerElementId { get; }
      Description: The element Id of peer connected stairs component in the stairs connection.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] StairsComponentConnectionEndType
Full Name: Autodesk.Revit.DB.Architecture.StairsComponentConnectionEndType
Description: The end type identifying the connection type among stairs runs and landings.
Inherits: Enum

  Values:
    - ET_Landing = 0
    - ET_RunStart = 1
    - ET_RunEnd = 2

--------------------------------------------------------------------------------

[ENUM] StairsConstructionMethod
Full Name: Autodesk.Revit.DB.Architecture.StairsConstructionMethod
Description: Represents the construction method of the stairs.
Inherits: Enum

  Values:
    - Assembled = 0
    - CastInPlace = 1
    - Precast = 2

--------------------------------------------------------------------------------

[ENUM] StairsEndConnectionType
Full Name: Autodesk.Revit.DB.Architecture.StairsEndConnectionType
Description: The join style between a run and landing.
Inherits: Enum

  Values:
    - StraightCut = 0
    - Notch = 1

--------------------------------------------------------------------------------

[ENUM] StairsEndNotchOption
Full Name: Autodesk.Revit.DB.Architecture.StairsEndNotchOption
Description: The style of notch width for the stairs.
Inherits: Enum

  Values:
    - FullRunWidth = 0
    - Custom = 1

--------------------------------------------------------------------------------

[CLASS] StairsLanding
Full Name: Autodesk.Revit.DB.Architecture.StairsLanding
Description: An object that represents a stairs landing in Autodesk Revit.
Inherits: Element

  PROPERTIES:
    double BaseElevation { get; set; }
      Description: The base elevation of the landing.
    bool IsAutomaticLanding { get; }
      Description: True if the landing is an automatic landing, False otherwise.
    double Thickness { get; }
      Description: The thickness of the landing.

  METHODS:
    static bool CanCreateAutomaticLanding(Document document, ElementId firstRunId, ElementId secondRunId)
      Description: Checks whether automatic landing(s) can be created between the given two stairs runs and logically join(s) with the stairs runs.
      @document: The document that owns the stairs runs.
      @firstRunId: The first stairs run.
      @secondRunId: The second stairs run.
      Returns: True if automatic landing(s) can be created between the two stairs runs, False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> CreateAutomaticLanding(Document document, ElementId firstRunId, ElementId secondRunId)
      Description: Creates automatic landing(s) between two stairs runs.
      @document: The document that owns the stairs runs and new landing(s).
      @firstRunId: The first stairs run.
      @secondRunId: The second stairs run.
      Returns: The created landing(s) between the two stairs runs.
      Throws ArgumentException: The firstRunId is not a valid stairs run. -or- The secondRunId is not a valid stairs run. -or- The stairs runs firstRunId and secondRunId belong to different stairs host.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The stairs element to which the stairs component firstRunId belong is not in an active StairsEditScope. -or- Cannot create automatic landing(s) between stairs runs of firstRunId and secondRunId.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: Failed to create automatic landing(s) due to document regeneration failures.
    static StairsLanding CreateSketchedLanding(Document document, ElementId stairsId, CurveLoop curveLoop, double baseElevation)
      Description: Creates a customized landing between two runs by providing the closed boundary curves of the landing.
      @document: The document that owns the landing.
      @stairsId: The stairs that the new sketched landing belongs to.
      @curveLoop: The closed boundary curves of the new landing.
      @baseElevation: Base elevation of the new stairs run. The elevation has following restriction: The base elevation is relative to the base elevation of the stairs.The base elevation will be rounded automatically to a multiple of the riser height.The base elevation should be equal to or greater than half of the riser height.
      Returns: The new sketched landing.
      Throws ArgumentException: The element stairsId does not exist in the document -or- The stairsId is not a valid stairs element. -or- The stairs stairsId has no valid landing type. -or- The curveLoop is not closed. -or- The input curveLoop contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- Failed to create curve element by the curveLoop.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for baseElevation must be no more than 30000 feet in absolute value. -or- The baseElevation is less than half of the riser height of the stairs.
      Throws InvalidOperationException: The stairs element represented by stairsId is not in an active StairsEditScope. New components cannot be added to it.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The curveLoop doesn't satisfy restrictions to generate sketched landing.
    static StairsLanding CreateSketchedLandingWithSlopeData(Document document, ElementId stairsId, IList<SketchedStairsCurveData> curveLoop, double baseElevation)
      Description: Creates a customized landing between two runs by providing the closed boundary curves of the landing, specifying slope type and height.
      @document: The document that owns the landing.
      @stairsId: The stairs that the new sketched landing belongs to.
      @curveLoop: The closed boundary curves of the new landing, specifying slope type and height.
      @baseElevation: Base elevation of the new stairs run. The elevation has following restriction: The base elevation is relative to the base elevation of the stairs.The base elevation will be rounded automatically to a multiple of the riser height.The base elevation should be equal to or greater than half of the riser height.
      Returns: The new sketched landing.
      Throws ArgumentException: The element stairsId does not exist in the document -or- The stairsId is not a valid stairs element. -or- The stairs stairsId has no valid landing type. -or- The curveLoop is not closed. The input curveLoop contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- Failed to create curve element by the curveLoop.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for baseElevation must be no more than 30000 feet in absolute value. -or- The baseElevation is less than half of the riser height of the stairs.
      Throws InvalidOperationException: The stairs element represented by stairsId is not in an active StairsEditScope. New components cannot be added to it.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The curveLoop doesn't satisfy restrictions to generate sketched landing.
    IList<ElementId> GetAllSupports()
      Description: Returns all the supports hosting the stairs landing.
      Returns: All the supports hosting the stairs landings.
    IList<StairsComponentConnection> GetConnections()
      Description: Returns information about the connections in which the stairs landing participates.
      Returns: The connections in which the stairs landing participates.
    CurveLoop GetFootprintBoundary()
      Description: Returns the landing's boundary curves which are projected on the stairs base level.
      Returns: The boundary curves of the landing.
    Stairs GetStairs()
      Description: Returns the stairs to which the landing belongs.
      Returns: The stairs to which the landing belongs.
    CurveLoop GetStairsPath()
      Description: Returns the stairs path curves on the landing. The curves are projected on the stairs base level.
      Returns: The stairs path curves of the landing.
    void SetSketchedLandingBoundaryAndPath(Document document, CurveLoop boundaryCurveLoop, CurveLoop pathCurveLoop)
      Description: Sets the boundary and path curves of the sketched landing.
      @document: The document that owns the landing.
      @boundaryCurveLoop: The closed boundary curves of the landing.
      @pathCurveLoop: The path curves of the landing, can be an empty CurveLoop.
      Throws ArgumentException: The boundaryCurveLoop is not closed. -or- The input boundaryCurveLoop contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The input pathCurveLoop contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- Failed to create curve element by the boundaryCurveLoop or pathCurveLoop.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] StairsLandingType
Full Name: Autodesk.Revit.DB.Architecture.StairsLandingType
Description: Represents a stairs landing type in Autodesk Revit.
Inherits: ElementType

  PROPERTIES:
    bool IsMonolithic { get; }
      Description: True if the stairs landing is monolithic, false otherwise.
    double Thickness { get; set; }
      Description: Thickness of the stairs landing.

--------------------------------------------------------------------------------

[ENUM] StairsNumberSystemReferenceOption
Full Name: Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption
Description: The reference types permitted for a number system to refer to the geometry of a stairs run.
Inherits: Enum

  Values:
    - Center = 0
    - Left = 1
    - Right = 2
    - LeftQuarter = 3
    - RightQuarter = 4

--------------------------------------------------------------------------------

[CLASS] StairsPath
Full Name: Autodesk.Revit.DB.Architecture.StairsPath
Description: An object that represents the stairs path.
Inherits: Element

  PROPERTIES:
    string DownText { get; set; }
      Description: The stairs down text.
    XYZ DownTextOffset { get; set; }
      Description: The offset of stairs down text.
    bool ShowDownText { get; set; }
      Description: Represents whether show stairs down text or not.
    bool ShowUpText { get; set; }
      Description: Represents whether show stairs up text or not.
    LinkElementId StairsId { get; }
      Description: The host stairs element id.
    double StairsPathOffset { get; set; }
      Description: The offset of stairs path to center line of stairs.
    StairsTextOrientation TextOrientation { get; set; }
      Description: The orientation of stair up and down text.
    string UpText { get; set; }
      Description: The stairs up text.
    XYZ UpTextOffset { get; set; }
      Description: The offset of stairs up text.

  METHODS:
    static bool CanCreateOnMultistoryStairs(Document document, LinkElementId multistoryStairsId)
      Description: Checks if more stairs paths can be added on the plan views of a multistory stairs.
      @multistoryStairsId: The multistory stairs id.
      Throws ArgumentNullException: A non-optional argument was null
    static StairsPath Create(Document document, LinkElementId stairsId, ElementId typeId, ElementId planViewId)
      Description: Creates a new stairs path for the specified stairs with the specified stairs path type only in the plan view.
      @document: The document.
      @stairsId: The id of the stairs element either in the host document or in a linked document.
      @typeId: The type of stairs path.
      @planViewId: The plan view in which the stairs path will be shown.
      Returns: The new stairs path.
      Throws ArgumentException: The stairsId is not a valid stairs. -or- The typeId is not a valid stairs path type. -or- The planViewId is not a valid plan view. -or- The stairsId already has a stairs path. -or- The stairsId is not visible in planViewId.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<StairsPath> CreateOnMultistoryStairs(Document document, LinkElementId multistoryStairsId, ElementId typeId)
      Description: Creates a new stairs path for the stairs in a multistory stairs with the specified stairs path type only in the plan view.
      @document: The document.
      @multistoryStairsId: The id of the multistory stairs element either in the host document or in a linked document.
      @typeId: The type of stairs path.
      Returns: The new stairs paths.
      Throws ArgumentException: Cannot add more stairs paths on multistoryStairsId. -or- The typeId is not a valid stairs path type.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] StairsPathDirection
Full Name: Autodesk.Revit.DB.Architecture.StairsPathDirection
Description: The direction style of stairs path.
Inherits: Enum

  Values:
    - AlwaysUp = 0
    - AutomaticUpDown = 1

--------------------------------------------------------------------------------

[ENUM] StairsPathLineShapeAtCorner
Full Name: Autodesk.Revit.DB.Architecture.StairsPathLineShapeAtCorner
Description: The options for the line shape of a stairs path at a corner.
Inherits: Enum

  Values:
    - Straight = 0
    - Curved = 1

--------------------------------------------------------------------------------

[CLASS] StairsPathType
Full Name: Autodesk.Revit.DB.Architecture.StairsPathType
Description: An object represents the stairs path type.
Inherits: ElementType

  PROPERTIES:
    ElementId ArrowheadTypeId { get; set; }
      Description: The arrow head type of the stairs path.
    double DistanceToCutMark { get; set; }
      Description: The distance from the stairs path arrow to cut mark.
    bool DrawForEachRun { get; set; }
      Description: True if stairs paths should be drawn for each run, false if it should be drawn for the whole stairs.
    bool EndAtRiser { get; set; }
      Description: Represents whether the stairs path ends at the riser.
    bool FullStepArrow { get; set; }
      Description: True if the arrow fills the full step width, false if it fills by the specified arrow size.
    StairsPathLineShapeAtCorner LineShapeAtCorner { get; set; }
      Description: The line shape of stairs path at the corner.
    bool ShowArrowheadToCutMark { get; set; }
      Description: True if the stairs path arrowhead should be shown to the cutmark, false if the arrow head is not shown.
    StairsPathDirection StairsPathDirection { get; }
      Description: The style of the stairs path.
    double StartExtension { get; set; }
      Description: The start extension length of the stairs path.
    bool StartFromRiser { get; set; }
      Description: True if the stairs path starts from the riser, false if it starts from the tread.
    ElementId StartSymbolTypeId { get; set; }
      Description: The start symbol type of stairs path.

--------------------------------------------------------------------------------

[CLASS] StairsRun
Full Name: Autodesk.Revit.DB.Architecture.StairsRun
Description: Represents a stairs run element in Autodesk Revit.
Inherits: Element

  PROPERTIES:
    int ActualRisersNumber { get; }
      Description: The actual number of stairs risers in the stairs run.
    double ActualRunWidth { get; set; }
      Description: Specifies the value of the tread width excluding the width of independent side supports.
    int ActualTreadsNumber { get; }
      Description: The actual number of stairs treads in the stairs run.
    double BaseElevation { get; set; }
      Description: The base elevation of the stairs run.
    bool BeginsWithRiser { get; set; }
      Description: True if the stairs run begins with a riser, false otherwise.
    bool EndsWithRiser { get; set; }
      Description: True if the stairs run ends with a riser, false otherwise.
    double ExtensionBelowRiserBase { get; set; }
      Description: Specifies a value to extend/trim the run's first step against base elevation of the stairs if the stairs begins with a riser.
    double ExtensionBelowTreadBase { get; set; }
      Description: Specifies a value to extend/trim the run's first step against base elevation of the stairs if the stairs begins with a tread.
    double Height { get; }
      Description: The calculated height of the stairs run.
    StairsRunJustification LocationLineJustification { get; set; }
      Description: The position of the run relative to the Up-direction path used to create the run.
    StairsRunStyle StairsRunStyle { get; }
      Description: The style of the stairs run such as straight, winder, etc.
    double TopElevation { get; set; }
      Description: The top elevation of the stairs run.

  METHODS:
    static StairsRun CreateSketchedRun(Document document, ElementId stairsId, double baseElevation, IList<Curve> boundaryCurves, IList<Curve> riserCurves, IList<Curve> stairsPath)
      Description: Creates a sketched run in the project document by providing a group of boundary curves and riser curves.
      @document: The document.
      @stairsId: The stairs that the new stairs run will belong to.
      @baseElevation: Base elevation of the new stairs run. It has following restrictions: The base elevation is relative to the base elevation of the stairs.The base elevation will be rounded automatically to a multiple of the riser height.
      @boundaryCurves: The boundary curves of the new stairs run. The curves have following restriction: The curves should consist of bound Line or Arc curves only.The curves should be a pair of curve chains(two sets of curves which connect end-to-end to form the left and right boundaries).The left and right boundary chain curves should not connect to each other.They can be single curves or multi-segmented curves(for example, straight lines and arcs connected).
      @riserCurves: The riser curves of the new stairs run. The curves have following restriction: The curves should consist of bound Line or Arc curves only.The curves should be able to make at least two curve chains.The curves in each chain should connect between the left and right boundaries.
      @stairsPath: The stair path curves of the new stairs run. The curves have following restriction: The curves should consist of bound Line or Arc curves only.The curves should be able to make one curve chain.The curve chain should have intersection with all riser curve chains.The curves should connect between the first and last riser chain curves.
      Returns: The new stairs run.
      Throws ArgumentException: The stairsId is not a valid stairs element. -or- The input boundaryCurves is empty. -or- The input riserCurves is empty. -or- The input stairsPath is empty. -or- The input boundaryCurves contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The input riserCurves contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The input stairsPath contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The riserCurves or boundaryCurves or stairsPath don't meet restrictions to create sketch run. -or- The boundaryCurves has invalid curve used as sketch boundary curve. -or- The riserCurves has invalid curve used as sketch riser curve. -or- The stairsPath has invalid curve used as sketch stairspath curve.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for baseElevation must be no more than 30000 feet in absolute value. -or- The baseElevation doesn't meet the restriction that bottom of run should not be lower than bottom of stairs.
      Throws InvalidOperationException: The stairs element represented by stairsId is not in an active StairsEditScope. New components cannot be added to it.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The boundaryCurves, riserCurves, stairsPath don't meet restrictions to generate sketch run.
    static StairsRun CreateSketchedRunWithSlopeData(Document document, ElementId stairsId, double baseElevation, IList<SketchedStairsCurveData> boundaryCurves, IList<Curve> riserCurves, IList<Curve> stairsPath)
      Description: Creates a sketched run in the project document by providing a group of boundary curves and riser curves, specifying slope type and height for boundary curves.
      @document: The document.
      @stairsId: The stairs that the new stairs run will belong to.
      @baseElevation: Base elevation of the new stairs run. It has following restrictions: The base elevation is relative to the base elevation of the stairs.The base elevation will be rounded automatically to a multiple of the riser height.
      @boundaryCurves: The boundary curves of the new stairs run, specifying slope type and height. The curves have following restriction: The curves should consist of bound Line or Arc curves only.The curves should be a pair of curve chains(two sets of curves which connect end-to-end to form the left and right boundaries).The left and right boundary chain curves should not connect to each other.They can be single curves or multi-segmented curves(for example, straight lines and arcs connected).
      @riserCurves: The riser curves of the new stairs run. The curves have following restriction: The curves should consist of bound Line or Arc curves only.The curves should be able to make at least two curve chains.The curves in each chain should connect between the left and right boundaries.
      @stairsPath: The stair path curves of the new stairs run. The curves have following restriction: The curves should consist of bound Line or Arc curves only.The curves should be able to make one curve chain.The curve chain should have intersection with all riser curve chains.The curves should connect between the first and last riser chain curves.
      Returns: The new stairs run.
      Throws ArgumentException: The stairsId is not a valid stairs element. -or- The input riserCurves is empty. -or- The input stairsPath is empty. -or- The input boundaryCurves is empty. The input boundaryCurves contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The input riserCurves contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The input stairsPath contains at least one curve which is not a bound Line or bound Arc and is not supported for this operation. -or- The riserCurves or boundaryCurves or stairsPath don't meet restrictions to create sketch run. -or- The boundaryCurves has invalid curve used as sketch boundary curve. -or- The riserCurves has invalid curve used as sketch riser curve. -or- The stairsPath has invalid curve used as sketch stairspath curve.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for baseElevation must be no more than 30000 feet in absolute value. -or- The baseElevation doesn't meet the restriction that bottom of run should not be lower than bottom of stairs.
      Throws InvalidOperationException: The stairs element represented by stairsId is not in an active StairsEditScope. New components cannot be added to it.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The boundaryCurves, riserCurves, stairsPath don't meet restrictions to generate sketch run.
    static StairsRun CreateSpiralRun(Document document, ElementId stairsId, XYZ center, double radius, double startAngle, double includedAngle, bool clockwise, StairsRunJustification justification)
      Description: Creates a spiral run in the project document by providing the center, start angle and included angle.
      @document: The document.
      @stairsId: The stairs that the new stairs run will belong to.
      @center: The center of the location arc of the spiral run. The Z coordinate of the center is the base elevation for the new run (in model coordinates). It must be greater than or equal to the stairs base elevation.
      @radius: The radius of the location arc of the spiral run.
      @startAngle: The start angle of the location arc of the spiral run. The angle's coordinate system is world coordinate system which always is XYZ.BasisX and XYZ.BasisY.
      @includedAngle: The total angle covered by the spiral run. Must be a positive value (direction is determined by the clockwise flag).
      @clockwise: True if the spiral run will be created along clockwise direction, False otherwise.
      @justification: The location path justification of the new stairs run.
      Returns: The new stairs run.
      Throws ArgumentException: The stairsId is not a valid stairs element. -or- The given value for startAngle is not finite -or- The input center is not a valid center for spiral run (probably the Z coordinate doesn't meet the restrictions) -or- The includedAngle doesn't satisfy riser restriction to generate spiral run (probably it's too small).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for radius must be greater than 0 and no more than 30000 feet. -or- The given value for includedAngle must be positive. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws ArgumentsInconsistentException: The radius is too small to generate a spiral run at the given justification.
      Throws InvalidOperationException: The stairs element represented by stairsId is not in an active StairsEditScope. New components cannot be added to it.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The center, radius, startAngle, includedAngle don't satisfy restrictions to generate spiral run.
    static StairsRun CreateStraightRun(Document document, ElementId stairsId, Line locationPath, StairsRunJustification justification)
      Description: Creates a straight run in the project document.
      @document: The document.
      @stairsId: The stairs that the new stairs run will belong to.
      @locationPath: The line for location path of the new stairs run. The line has following restriction: The line should be bound line which is parallel to the XY plane.The Z coordinate of the line is the base elevation for the new run (in model coordinates). It must be greater than or equal to the stairs base elevation.The number of created risers will be calculated by rounding the length of the location path to a multiple of the tread depth.
      @justification: The location path justification of the new stairs run.
      Returns: The new stairs run.
      Throws ArgumentException: The stairsId is not a valid stairs element. -or- The input locationPath is not a bound line. -or- The input locationPath is not a valid location path line for straight run. -or- The locationPath is not valid line used as stairs path(probably it's too short).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The stairs element represented by stairsId is not in an active StairsEditScope. New components cannot be added to it.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: The locationPath doesn't satisfy restrictions to generate straight run.
    IList<ElementId> GetAllSupports()
      Description: Retrieves all supports hosted by the stair's run.
      Returns: All supports hosted by the stair's run.
    IList<StairsComponentConnection> GetConnections()
      Description: Returns information about the connections in which the stairs run participates. The stairs run may have no connection, or have at maximum two connections at the lower and upper ends.
      Returns: The connections in which the stairs run participates.
    CurveLoop GetFootprintBoundary()
      Description: Returns the run's boundary curves which are projected on the stairs base level.
      Returns: The boundary curves of the stairs run.
    IList<ElementId> GetLeftSupports()
      Description: Retrieves all supports on the left side of run boundaries.
      Returns: The supports on the left side of run boundaries.
    Reference GetNumberSystemReference(StairsNumberSystemReferenceOption referenceOption)
      Description: Gets the number system reference corresponding to the given reference options.
      @referenceOption: The reference option.
      Returns: The reference.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<ElementId> GetRightSupports()
      Description: Retrieves all supports on the right side of run boundaries.
      Returns: The supports on the right side of run boundaries.
    Stairs GetStairs()
      Description: Returns the stairs to which the stairs run belongs.
      Returns: The stairs to which the stairs run belongs.
    CurveLoop GetStairsPath()
      Description: Returns the stairs path curves on the run. The curves are projected on base level of the stairs.
      Returns: The stairs path curves.
      Throws InvalidOperationException: The stairs run has no stairs path it probably because the run was not generated yet.
    static bool SetLocationPathForSpiralRun(StairsRun stairsRun, XYZ center, double radius, double startAngle, double includedAngle, bool clockwise, StairsRunJustification justification)
      Description: Set Location path for a spiral run.
      @stairsRun: The run whose location path will be set.
      @center: The center of the location arc of the spiral run. The Z coordinate of the center is the base elevation for the new run (in model coordinates). It must be greater than or equal to the stairs base elevation.
      @radius: The radius of the location arc of the spiral run.
      @startAngle: The start angle of the location arc of the spiral run. The angle's coordinate system is world coordinate system which always is XYZ.BasisX and XYZ.BasisY.
      @includedAngle: The total angle covered by the spiral run. Must be a positive value (direction is determined by the clockwise flag).
      @clockwise: True if the spiral run will be created along clockwise direction, False otherwise.
      @justification: The location path justification of the new stairs run.
      Returns: Indicate if set is success or not.
      Throws ArgumentException: The given value for startAngle is not finite -or- The input center is not a valid center for spiral run (probably the Z coordinate doesn't meet the restrictions) -or- The includedAngle doesn't satisfy riser restriction to generate spiral run (probably it's too small).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for radius must be greater than 0 and no more than 30000 feet. -or- The given value for includedAngle must be positive. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws ArgumentsInconsistentException: The radius is too small to generate a spiral run at the given justification.
      Throws InvalidOperationException: The stairs element represented by stairsRun is not in an active StairsEditScope. The run cannot be modified.
      Throws RegenerationFailedException: The center, radius, startAngle, includedAngle don't satisfy restrictions to generate spiral run.
    static bool SetLocationPathForStraightRun(StairsRun stairsRun, Line locationPath)
      Description: Set location path for a straight run by giving a line.
      @stairsRun: The run whose location path will be set.
      @locationPath: The location path.
      Returns: Indicate if set is success or not.
      Throws ArgumentException: The input locationPath is not a bound line. -or- The input locationPath is not a valid location path line for straight run. -or- The locationPath is not valid line used as stairs path(probably it's too short).
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The stairs element represented by stairsRun is not in an active StairsEditScope. The run cannot be modified.
      Throws RegenerationFailedException: The locationPath doesn't satisfy restrictions to generate straight run.

--------------------------------------------------------------------------------

[ENUM] StairsRunJustification
Full Name: Autodesk.Revit.DB.Architecture.StairsRunJustification
Description: The position of the run relative to the Up-direction path used to create the run.
Inherits: Enum

  Values:
    - Left = 0
    - Center = 1
    - Right = 2
    - LeftExterior = 3
    - RightExterior = 4

--------------------------------------------------------------------------------

[ENUM] StairsRunStyle
Full Name: Autodesk.Revit.DB.Architecture.StairsRunStyle
Description: The shape of a run. Different shape has different ways of manipulation.
Inherits: Enum

  Values:
    - Winder = 1
    - Sketched = 2
    - Straight = 3
    - Spiral = 4

--------------------------------------------------------------------------------

[CLASS] StairsRunType
Full Name: Autodesk.Revit.DB.Architecture.StairsRunType
Description: A stairs run type object that is used in the generation of stairs run.
Inherits: ElementType

  PROPERTIES:
    bool HasRisers { get; set; }
      Description: True if the stairs run will include risers on steps, false otherwise.
    bool HasTreads { get; set; }
      Description: True if the stairs run will include treads on steps, false otherwise.
    bool IsMonolithic { get; }
      Description: True if the stairs run is monolithic, false otherwise.
    bool IsSlanted { get; set; }
      Description: True if risers will be slanted, false if they will be straight.
    ElementId MaterialId { get; set; }
      Description: The material of the stairs run, only available for monolithic stairs run.
    double NosingLength { get; set; }
      Description: The amount of the tread depth that overhangs the next tread.
    ElementId NosingProfile { get; set; }
      Description: The id of the nosing profile of the treads.
    ElementId RiserProfile { get; set; }
      Description: The id of the profile of the risers.
    double RiserThickness { get; set; }
      Description: The thickness of the risers.
    RiserToTreadConnectionOption RiserToTreadConnect { get; set; }
      Description: The connection of the riser to tread in relation to each other.
    double StructuralDepth { get; set; }
      Description: The structural depth of the stairs run, only available for monolithic stairs run.
    double TotalDepth { get; }
      Description: The total depth of the stairs run, only available for monolithic stairs run.
    TreadNosingPosition TreadNosingPosition { get; set; }
      Description: Represents on which edges of the nosing to apply the nosing profile.
    ElementId TreadProfile { get; set; }
      Description: The id of the profile of the treads.
    double TreadThickness { get; set; }
      Description: The thickness of the treads.
    StairsUndersideSurfaceStyle UndersideSurfaceStyle { get; set; }
      Description: The underside surface style of the stairs run, only available for monolithic stairs run.

--------------------------------------------------------------------------------

[ENUM] StairsSupportTopsideSurfaceType
Full Name: Autodesk.Revit.DB.Architecture.StairsSupportTopsideSurfaceType
Description: The style of the topside surface of the support.
Inherits: Enum

  Values:
    - Closed = 0
    - Open = 1

--------------------------------------------------------------------------------

[ENUM] StairsTextOrientation
Full Name: Autodesk.Revit.DB.Architecture.StairsTextOrientation
Description: The options to be used when orienting text annotations relative to stairs.
Inherits: Enum

  Values:
    - Horizontal = 0
    - Vertical = 1

--------------------------------------------------------------------------------

[CLASS] StairsType
Full Name: Autodesk.Revit.DB.Architecture.StairsType
Description: A type element containing the properties for a component-based stair.
Inherits: ElementType

  PROPERTIES:
    StairsConstructionMethod ConstructionMethod { get; }
      Description: The construction method of the stairs.
    StairsEndConnectionType EndConnectionType { get; set; }
      Description: The join style between a run and landing.
    bool HasMiddleSupports { get; set; }
      Description: True if the stairs type has middle supports, False otherwise.
    ElementId LandingType { get; set; }
      Description: The type for all landings in the stair element.
    double LeftLateralOffset { get; set; }
      Description: The offset for the left support from the edge of the run in a horizontal direction.
    ElementId LeftSideSupportType { get; set; }
      Description: The type of left support used in the stair.
    double MaxRiserHeight { get; set; }
      Description: The maximum height of each riser on the stair element.
    int MiddleSupportsNumber { get; set; }
      Description: The number of middle supports used in the stair.
    ElementId MiddleSupportType { get; set; }
      Description: The type of middle supports used in the stair.
    double MinRunWidth { get; set; }
      Description: The initial value for the width of a common run.
    double MinTreadDepth { get; set; }
      Description: The minimum tread width along the center path for all common runs (winder, arc, and straight).
    double NotchExtension { get; set; }
      Description: The horizontal length of the notch profile.
    double NotchHorizontalGap { get; set; }
      Description: The width of the horizontal gap in the stairs notch.
    double NotchThickness { get; set; }
      Description: The vertical length of the notch profile from the top.
    double NotchVerticalGap { get; set; }
      Description: The width of the vertical gap in the stairs notch.
    double RightLateralOffset { get; set; }
      Description: The offset for the right support from the edge of the run in a horizontal direction.
    ElementId RightSideSupportType { get; set; }
      Description: The type of right support used in the stair.
    ElementId RunType { get; set; }
      Description: The type for all runs in the stair element.

--------------------------------------------------------------------------------

[ENUM] StairsUndersideSurfaceStyle
Full Name: Autodesk.Revit.DB.Architecture.StairsUndersideSurfaceStyle
Description: The style of the underside surface of the run.
Inherits: Enum

  Values:
    - Stepped = 0
    - Smooth = 1

--------------------------------------------------------------------------------

[ENUM] StairsWinderStyle
Full Name: Autodesk.Revit.DB.Architecture.StairsWinderStyle
Description: The calculation method for the layout of the winder run steps.
Inherits: Enum

  Values:
    - Balanced = 0
    - SinglePoint = 2

--------------------------------------------------------------------------------

