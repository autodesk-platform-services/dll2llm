# Autodesk.Revit.DB.Structure


NAMESPACE: Autodesk.Revit.DB.Structure
--------------------------------------------------------------------------------

[ENUM] AlignedFreeFormSetOrientationOptions
Full Name: Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions

Description: Orientation options for Aligned Free Form Rebar set.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AlignedToDistributionPath = 0
    - Vertical = 1
    - ParallelToFace = 2
    - PerpendicularToFace = 3

[ENUM] AnalyticalCurveSelector
Full Name: Autodesk.Revit.DB.Structure.AnalyticalCurveSelector

Description: Specifies which portion of an Analytical Curve is of interest.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - StartPoint = 0
    - EndPoint = 1
    - WholeCurve = 2

[CLASS] AnalyticalElement
Full Name: Autodesk.Revit.DB.Structure.AnalyticalElement

Description: Base class for a structural analytical elements. AnalyticalElement represents the analytical portion of a given Structural Element.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    AnalyzeAs AnalyzeAs { get; set; }
      Description: This represents the Analyze As parameter assigned to Analytical Element.
    ElementId MaterialId { get; set; }
      Description: Defines the Material Id for the Analytical Element.
    AnalyticalStructuralRole StructuralRole { get; set; }
      Description: The enum value depicting structural role asigned to the Analytical Element.

  METHODS:
    Curve GetCurve()
      Description: Returns the curve of the Analytical Element.
      Returns: The curve of the Analytical Element.
    Reference GetReference(AnalyticalModelSelector selector)
      Description: Returns a reference to a given curve within the Analytical Element.
      @selector: Specifies where in the Analytical Element the reference lies.
      Returns: Requested reference.
    Transform GetTransform()
      Description: Returns the transform which reflects Analytical Element orientation.
      Returns: The orientation of the Analytical Element.
    bool IsSingleCurve()
      Description: Indicates if the Analytical Element can be expressed as a single curve.
      Returns: True if Analytical Element can be expressed as a single curve, false otherwise.
    bool IsValidAnalyzeAs(AnalyzeAs analyzeAs)
      Description: Checks whether the value set for Analyze As is valid for an Analytical Element.
      @analyzeAs: The value set to be verified.
    bool IsValidSelector(AnalyticalModelSelector selector)
      Description: Indicates if the input selector is valid for the Analytical Element.
      @selector: Portion of the Analytical Element geometry.
      Returns: True if selector is valid for this Analytical Element, false otherwise.
    bool IsValidStructuralRole(AnalyticalStructuralRole structuralRole)
      Description: Checks whether the value set for Analytical Structural Role is valid for an Analytical Element.
      @structuralRole: The value set to be verified.
    bool IsValidTransform(Transform trf)
      Description: Checks whether the value set for Local Coordinate System is valid for an Analytical Element.
      @trf: The value set to be verified.
    void SetTransform(Transform trf)
      Description: Sets the transform of Analytical Element Local Coordinate System.

--------------------------------------------------------------------------------

[ENUM] AnalyticalElementSelector
Full Name: Autodesk.Revit.DB.Structure.AnalyticalElementSelector

Description: Specifies a portion of an Analytical Element or the whole element.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - StartOrBase = 0
    - EndOrTop = 1
    - Whole = 2

[ENUM] AnalyticalFixityState
Full Name: Autodesk.Revit.DB.Structure.AnalyticalFixityState

Description: Specifies the fixity setting of individual degrees of freedom in analytical release conditions.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Fixed = 0
    - Released = 1
    - Spring = 2

[CLASS] AnalyticalLink
Full Name: Autodesk.Revit.DB.Structure.AnalyticalLink

Description: An analytical link element that is used to create connections between other Analytical Elements.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    XYZ End { get; }
      Description: The point at the end of the AnalyticalLink.
    ElementId EndHubId { get; }
      Description: Hub ID at end of AnalyticalLink.
    ElementId OwnerId { get; }
      Description: ElementId of Analytical Element which created the AnalyticalLink (if any) invalidElementId if this Analytical Link was created by the User or API
    XYZ Start { get; }
      Description: The point at the start of the AnalyticalLink.
    ElementId StartHubId { get; }
      Description: Hub ID at start of AnalyticalLink.

  METHODS:
    static AnalyticalLink Create(Document doc, ElementId type, ElementId startHubId, ElementId endHubId)
      Description: Creates a new instance of a AnalyticalLink element between two Hubs.
      @doc: Document to which new AnalyticalLink should be added.
      @type: AnalyticalLinkType for the new AnalyticalLink.
      @startHubId: Hub at start of AnalyticalLink.
      @endHubId: Hub at end of AnalyticalLink.
      Returns: The newly created AnalyticalLink instance.
    bool IsAutoGenerated()
      Description: Specifies whether or not an AnalyticalLink was created by an Analytical Element.
      Returns: True if AnalyticalLink was created by an Analytical Element, false otherwise.
    static bool IsValidHub(Document doc, ElementId hubId)
      Description: Checks whether input hub is valid for an AnalyticalLink.
      @doc: Hubs's document.
      @hubId: Hub to test for validity.
      Returns: True is returned when provided hubId points hub that is valid for AnalyticalLink, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalyticalLinkType
Full Name: Autodesk.Revit.DB.Structure.AnalyticalLinkType

Description: An object that specifies the analysis properties for an AnalyticalLink element.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    AnalyticalFixityState RotationX { get; set; }
      Description: Fixity of rotation around X.
    AnalyticalFixityState RotationY { get; set; }
      Description: Fixity of rotation around Y.
    AnalyticalFixityState RotationZ { get; set; }
      Description: Fixity of rotation around Z.
    AnalyticalFixityState TranslationX { get; set; }
      Description: Fixity of translation along X.
    AnalyticalFixityState TranslationY { get; set; }
      Description: Fixity of translation along Y.
    AnalyticalFixityState TranslationZ { get; set; }
      Description: Fixity of translation along Z.

  METHODS:
    static bool IsValidAnalyticalFixityState(AnalyticalFixityState fixityState)
      Description: Returns whether the input fixity state is valid for Analytical Link Type parameters.
      @fixityState: The fixity state value to check.
      Returns: True if valid.

--------------------------------------------------------------------------------

[ENUM] AnalyticalLoopType
Full Name: Autodesk.Revit.DB.Structure.AnalyticalLoopType

Description: Specifies kind of analytical model loop.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - All = 0
    - External = 1
    - Internal = 2
    - Filled = 3
    - Void = 4

[CLASS] AnalyticalMember
Full Name: Autodesk.Revit.DB.Structure.AnalyticalMember

Description: Represents a linear element in the structural analytical model.
Inherits: AnalyticalElement
Implements: IDisposable

  PROPERTIES:
    double CrossSectionRotation { get; set; }
      Description: This represents the cross-section rotation, in radians.
    ElementId SectionTypeId { get; set; }
      Description: The id of the type from the structural Family assigned to the Analytical Member.
    StructuralSectionShape StructuralSectionShape { get; }
      Description: The structural section shape of the Analytical Member.

  METHODS:
    bool CanSplit()
      Description: Identifies whether a particular analytical member can be split at a point on it's defining curve (by ).
      Returns: True if the analytical member can be split, otherwise false.
    static AnalyticalMember Create(Document aDoc, Curve curve)
      Description: Creates a new instance of an Analytical Member within the project.
      @aDoc: A Revit document.
      @curve: Curve of the analytical member.
      Returns: The newly created Analytical Member instance.
    void FlipCurve()
      Description: Flip the Analytical Member
    IList<MemberForces> GetMemberForces()
      Description: Gets the member forces associated with this Analytical Member.
      Returns: Returns a collection of Member Forces associated with this Analytical Member. Empty collection will be returned if Analytical Member doesn't have any Member Forces. To find out with which end member forces are associated use property to obtain a position of Member Forces on element.
    IList<ReleaseConditions> GetReleaseConditions()
      Description: Gets the release conditions associated with this Analytical Member.
      Returns: Returns a collection of Release Conditions associated with this Analytical Member. Empty collection will be returned if Analytical Member doesn't have any Release Conditions. End to which release conditions will be added is defined by setting property in provided release conditions object.
    ReleaseType GetReleaseType(bool start)
      Description: Gets the release type.
      @start: The position on Analytical Member element. True for start, false for end.
      Returns: The type of release.
    static bool IsValidCurve(Curve curve)
      Description: Verifies if the curve is valid for an Analytical Member.
      @curve: The curve to be verified.
    bool IsValidSectionTypeId(ElementId familySymbolId)
      Description: Checks whether the family symbol id is allowed for Analytical Member as Section Type property.
      @familySymbolId: Family symbol id which has to be checked.
      Returns: True if %familySymbolId% is invalidElementId; or if it is the id of a FamilySymbol of category "Structural Framing" (OST_StructuralFraming) or "Structural Columns" (OST_StructuralColumns) Returns false otherwise.
    void SetCurve(Curve curve)
      Description: Sets the curve for the Analytical Member.
    void SetMemberForces(MemberForces memberForces)
      Description: Sets Member Forces to Analytical Member.
      @memberForces: End to which member forces will be added is defined by setting property in provided Member Forces object.
    void SetMemberForces(bool start, XYZ force, XYZ moment)
      Description: Sets Member Forces to Analytical Member.
      @start: Member Forces position on Analytical Member. True for start, false for end.
      @force: The translational forces at specified position of the element. The x value of XYZ object represents force along x-axis of the Analytical Member coordinate system, y along y-axis, z along z-axis respectively.
      @moment: The rotational forces at specified position of the element. The x value of XYZ object represents moment about x-axis of the Analytical Member coordinate system, y about y-axis, z about z-axis respectively.
    void SetReleaseConditions(ReleaseConditions releaseConditions)
      Description: Sets Release Conditions to Analytical Member.
      @releaseConditions: End to which release conditions will be added is defined by setting property in provided release conditions object.
    void SetReleaseType(bool start, ReleaseType releaseType)
      Description: Sets the release type.
      @start: The position on Analytical Member element. True for start, false for end.
      @releaseType: The type of release.
    ElementId Split(double parameter)
      Description: Splits the analytical member at a point on its defining curve.
      @parameter: The normalized parameter value along the element (should be greater than 0 and less than 1).
      Returns: The newly created analytical member id.

--------------------------------------------------------------------------------

[CLASS] AnalyticalModelSelector
Full Name: Autodesk.Revit.DB.Structure.AnalyticalModelSelector

Description: Defines a portion of an Analytical Model for an Element.
Remarks: This is used to identify the portion of an analytical model of interest to a client. To identify the portion of the analytical model, the client must identify the curve in question, by using one of the following: The specific curve within the analytical model.The index of the curve within the analytical model. If a specific part of that curve is of interest, the client needs to identify that by specifying one of the following: The start of the curve.The end of the curve.The entire curve. This is the default behavior, so this does not need specifying.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalyticalModelSelector(Curve curve)
    new AnalyticalModelSelector(Curve curve, AnalyticalCurveSelector inCurveSelector)
    new AnalyticalModelSelector()
    new AnalyticalModelSelector(AnalyticalCurveSelector inCurveSelector)

  PROPERTIES:
    AnalyticalCurveSelector CurveSelector { get; set; }
      Description: The portion of the curve to be selected.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] AnalyticalNodeConnectionStatus
Full Name: Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus

Description: Indicates the Connections Status for an Analytical Node.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Unconnected = 0
    - Connected = 1

[CLASS] AnalyticalNodeData
Full Name: Autodesk.Revit.DB.Structure.AnalyticalNodeData

Description: This class holds information related to analytical model.
Remarks: This class is attached to a ReferencePoint.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static AnalyticalNodeData GetAnalyticalNodeData(Element element)
      Description: Returns AnalyticalNodeData associated with this element, if it exists.
      @element: The element from which we try to obtain AnalyticalNodeData.
    AnalyticalNodeConnectionStatus GetConnectionStatus()
      Description: Returns the Connection Status for this Analytical Node.

--------------------------------------------------------------------------------

[CLASS] AnalyticalOpening
Full Name: Autodesk.Revit.DB.Structure.AnalyticalOpening

Description: An element that represents an Opening in an Analytical Panel element.
Remarks: It can cut only one Analytical Panel at a time.
Inherits: AnalyticalSurfaceBase
Implements: IDisposable

  PROPERTIES:
    ElementId PanelId { get; }
      Description: ElementId of the AnalyticalPanel parent.

  METHODS:
    static AnalyticalOpening Create(Document aDoc, CurveLoop curveLoop, ElementId panelId)
      Description: Creates a new instance of an Analytical Opening within the project.
      @aDoc: Revit document.
      @curveLoop: CurveLoop for the Analytical Opening.
      @panelId: ElementId of the AnalyticalPanel on which we create the Opening.
      Returns: The newly created AnalyticalOpening instance.
    static bool IsCurveLoopValidForAnalyticalOpening(CurveLoop loop, Document aDoc, ElementId panelId)
      Description: Checks if curve loop is valid for Analytical Opening.
      @loop: The curve loop to be checked.
      @aDoc: Revit document.
      @panelId: ElementId of the AnalyticalPanel on which we create the Opening.
      Returns: Returns true if curve loop is ok, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AnalyticalPanel
Full Name: Autodesk.Revit.DB.Structure.AnalyticalPanel

Description: An element that represents a surface in the Structural Analytical Model.
Inherits: AnalyticalSurfaceBase
Implements: IDisposable

  PROPERTIES:
    double Thickness { get; set; }
      Description: Panel thickness, in the Revit default units.

  METHODS:
    static AnalyticalPanel Create(Document document, Curve profile, XYZ normal)
      Description: Creates a new instance of an Analytical Panel within the project.
      @document: Revit document.
      @profile: Curve which represents the profile of the Analytical Panel.
      @normal: Normal used for the extrusion of the profile.
      Returns: The newly created AnalyticalPanel instance.
    static AnalyticalPanel Create(Document aDoc, CurveLoop curveLoop)
      Description: Creates a new instance of an Analytical Panel within the project.
      @aDoc: Revit document.
      @curveLoop: CurveLoop for the Analytical Panel.
      Returns: The newly created AnalyticalPanel instance.
    ISet<ElementId> GetAnalyticalOpeningsIds()
      Description: Returns the Analytical Openings ids of the Analytical Panel.
      Returns: Set of ElementId.

--------------------------------------------------------------------------------

[ENUM] AnalyticalRigidLinksOption
Full Name: Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption

Description: Specifies how Rigid Links will be made for the Analytical Model.
Remarks: Rigid Links are curves connecting neighboring Structural Beams and Structural Columns.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Enabled = 0
    - Disabled = 1
    - FromColumn = 2

[ENUM] AnalyticalStructuralRole
Full Name: Autodesk.Revit.DB.Structure.AnalyticalStructuralRole

Description: Indicates the structural role for the analytical elements.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - StructuralRoleBeam = 0
    - StructuralRoleColumn = 1
    - StructuralRoleMember = 3
    - StructuralRoleGirder = 4
    - StructuralRoleFloor = 5
    - StructuralRoleWall = 6
    - StructuralRolePanel = 7
    - Unset = -1

[ENUM] AnalyticalSupportPriority
Full Name: Autodesk.Revit.DB.Structure.AnalyticalSupportPriority

Description: Defines how "highly" another Element is giving support for one Element.
Remarks: For instance, a Column may be a higher priority for a Beam than another Beam. This is useful to find the best supports for a given Element.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UnknownPriority = 0
    - HighestPriority = 1
    - SecondHighestPriority = 2
    - ThirdHighestPriority = 3
    - FourthHigestPriority = 4

[ENUM] AnalyticalSupportType
Full Name: Autodesk.Revit.DB.Structure.AnalyticalSupportType

Description: Indicates what kind of support another Element provides -- Point, Surface, or Curve.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UnknownSupport = 0
    - PointSupport = 1
    - CurveSupport = 2
    - SurfaceSupport = 3

[CLASS] AnalyticalSurfaceBase
Full Name: Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase

Description: This is the base class for analytical surface elements.
Inherits: AnalyticalElement
Implements: IDisposable

  PROPERTIES:
    ElementId SketchId { get; }
      Description: Sketch associated to this Revit element.

  METHODS:
    CurveLoop GetOuterContour()
      Description: Returns the Curve Loop that defines the geometry of the Analytical Surface element.
      Returns: CurveLoop associated with Analytical Surface element.
    static bool IsCurveLoopValid(CurveLoop profile)
      Description: Checks if curve loop is valid for Analytical Surface.
      @profile: The curve loop to be checked.
      Returns: Returns true if curve loop is ok, false otherwise.
    bool IsOuterContourValid(CurveLoop contour)
      Description: Checks if contour is valid for this Analytical Surface.
      @contour: The curve loop to be checked.
      Returns: Returns true if curve loop is ok, false otherwise.
    void SetOuterContour(CurveLoop outerContour)
      Description: Sets the Curve Loop that defines the geometry of the Analytical Surface element.
      @outerContour: New Curve Loop for the Analytical Surface element.

--------------------------------------------------------------------------------

[CLASS] AnalyticalToPhysicalAssociationManager
Full Name: Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager

Description: Class which manages the associations between analytical elements and physical elements.
Remarks: An element can be part of only one association at a time. Physical elements can have one of these categories: Columns Curtain Wall Panels Floors Generic Models Mass Parts Railings Ramps Roofs Stairs Structural Columns Structural Foundation Structural Framing Structural Trusses Structural Beam System Walls Analytical elements can have one of these categories: Analytical Member Analytical Panel
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    static bool EnableAssistedAssociation { get; set; }
      Description: Indicates if associations between Analytical and Physical Elements should be created automatically.

  METHODS:
    void AddAssociation(ISet<ElementId> analyticalElementIds, ISet<ElementId> physicalElementIds)
      Description: Adds a new association between a group of analytical elements and a group of physical elements.
      @analyticalElementIds: Ids of the analytical elements.
      @physicalElementIds: Ids of the physical elements.
    void AddAssociation(ElementId analyticalElementId, ElementId physicalElementId)
      Description: Adds a new association between an analytical element and a physical element.
      @analyticalElementId: Id of the analytical element.
      @physicalElementId: Id of the physical element.
    static AnalyticalToPhysicalAssociationManager GetAnalyticalToPhysicalAssociationManager(Document doc)
      Description: Returns the AnalyticalToPhysicalAssociationManager for this document.
      @doc: Revit document.
    ElementId GetAssociatedElementId(ElementId elementId)
      Description: Returns id of the element which is in association with the element with the given ElementId.
      @elementId: Element id for which we want to get the associated element.
      Returns: Id of the associated element.
    ISet<ElementId> GetAssociatedElementIds(ElementId elementId)
      Description: Returns ids of the elements which are in association with the element with the given ElementId.
      @elementId: Element id for which we want to get the associated elements.
      Returns: Ids of the associated elements.
    bool HasAssociation(ElementId id)
      Description: Verifies if the element has already defined an association.
      @id: Id of the element to check.
      Returns: Returns true if an association has been found, false otherwise.
    static bool IsAnalyticalElement(Document doc, ElementId id)
      Description: Returns true if the element is an analytical element.
      @doc: Revit document.
      @id: The element to be checked.
    static bool IsPhysicalElement(Document doc, ElementId id)
      Description: Returns true if the element is a physical element.
      @doc: Revit document.
      @id: The element to be checked.
    void RemoveAssociation(ElementId id)
      Description: This method will remove the association for the element with the given ElementId.
      @id: Id of the element for which we want to remove the association.

--------------------------------------------------------------------------------

[ENUM] AnalyzeAs
Full Name: Autodesk.Revit.DB.Structure.AnalyzeAs

Description: Analyze As has various functions within the Analytical Model, and is Element-dependent. "Not for Analysis" usually means that there will not be an Analytical Model generated. The others indicate how the Analytical Model behavior will treat the Element in question. For instance "Hanger" columns have different support expectations than "Gravity" columns.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Hanger = 0
    - Gravity = 1
    - Lateral = 2
    - SlabOneWay = 3
    - Mat = 4
    - SlabOnGrade = 5
    - NotForAnalysis = 7
    - NotApplicable = 8
    - SlabTwoWay = 9
    - GravityLateral = 10

[CLASS] AreaLoad
Full Name: Autodesk.Revit.DB.Structure.AreaLoad

Description: An object that represents a force applied across an area.
Inherits: LoadBase
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: Returns area of the area load.
    XYZ ForceVector1 { get; set; }
      Description: The force vector applied to the 1st reference point of the area load, oriented according to OrientTo setting.
    XYZ ForceVector2 { get; set; }
      Description: The force vector applied to the 2nd reference point of the area load, oriented according to OrientTo setting.
    XYZ ForceVector3 { get; set; }
      Description: The force vector applied to the 3rd reference point of the area load, oriented according to OrientTo setting.
    bool IsProjected { get; set; }
      Description: Indicates if the load is projected.
    int NumRefPoints { get; }
      Description: Returns the total number of reference points for the area load.

  METHODS:
    static bool AreCurveLoopsValid(IList<CurveLoop> loops)
      Description: Checks if curve loops are valid for creating an area load.
      @loops: The curve loops to be checked.
      Returns: Returns true if curve loops are ok, false otherwise.
    static AreaLoad Create(Document document, ElementId hostElemId, IList<CurveLoop> loops, IList<XYZ> forceVectors, IList<int> refPointCurveIndexes, IList<int> refPointCurveEnds, AreaLoadType symbol)
      Description: Creates a new custom area load within the project.
      @document: Document to which new area load will be added.
      @hostElemId: The analytical surface host element id for the area Load.
      @loops: The loops that define geometry of the area load. The curve loop collection should contains a closed loops consisting of lines.
      @forceVectors: The array of force vectors applied to the maximum three reference point of the area load.
      @refPointCurveIndexes: The array of maximum three curve indexes on which reference points should be placed on.
      @refPointCurveEnds: The array of maximum three curve ends indicating where reference points should be placed on. The array can have only 0 or 1 values, which means 0 - curve start point, 1 - curve end point.
      @symbol: The symbol of the AreaLoad. Set to use default type.
      Returns: If successful, returns an object of the newly created AreaLoad. is returned if the operation fails.
    static AreaLoad Create(Document document, ElementId hostElemId, IList<CurveLoop> loops, XYZ forceVector, AreaLoadType symbol)
      Description: Creates a new custom area load within the project.
      @document: Document to which new area load will be added.
      @hostElemId: The analytical surface host element id for the area Load.
      @loops: The loops that define geometry of the area load. The curve loop collection should contains a closed loops consisting of lines.
      @forceVector: The force vector applied to the 1st reference point of the area load.
      @symbol: The symbol of the AreaLoad. Set to use default type.
      Returns: If successful, returns an object of the newly created AreaLoad. is returned if the operation fails.
    static AreaLoad Create(Document document, ElementId hostElemId, XYZ forceVector, AreaLoadType symbol)
      Description: Creates a new hosted area load within the project.
      @document: Document to which new area load will be added.
      @hostElemId: The analytical surface host element id for the area Load.
      @forceVector: The force vector applied to the 1st reference point of the area load.
      @symbol: The symbol of the AreaLoad. Set to use default type.
      Returns: If successful, returns an object of the newly created AreaLoad. is returned if the operation fails.
    IList<CurveLoop> GetLoops()
      Description: Returns curve loops that define geometry of the area load.
    XYZ GetRefPoint(int index)
      Description: Returns the physical location of the reference point.
      @index: The index of the point to return.
    static bool IsCurveLoopsInsideHostBoundaries(Document doc, ElementId hostId, IList<CurveLoop> loops)
      Description: Checks if contour loops is inside host boundaries.
      @doc: Document.
      @hostId: The id of the analytical element that is about to host a load
      @loops: CurveLoops to be checked.
      Returns: Returns true if area load is positioned with entire distribution over the host, false otherwise.
    static bool IsValidHostId(Document pDoc, ElementId hostId)
      Description: Indicates if the provided host id can host area loads The document containing both the host and the load The id of the analytical element that is about to host an area load True if an area load can be placed on the input host id
    bool SetLoops(Document doc, IList<CurveLoop> newLoops)
      Description: Sets curve loops that define geometry of the area load.
      @doc: The document that contains the area load.
      @newLoops: Loops that define new geometry of the area load. The curve loop collection should contains a closed loops consisting of lines.
      Returns: Returns true if successful, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AreaLoadType
Full Name: Autodesk.Revit.DB.Structure.AreaLoadType

Description: AreaLoadType class
Inherits: LoadTypeBase
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] AreaReinforcement
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcement

Description: An object that represents an Area Reinforcement within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object. The Area Reinforcement element is available only in the Autodesk Revit Structure product.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double AdditionalBottomCoverOffset { get; set; }
      Description: Additional offset from the bottom or interior cover reference.
    double AdditionalTopCoverOffset { get; set; }
      Description: Additional offset from the top or exterior cover reference.
    AreaReinforcementType AreaReinforcementType { get; }
      Description: Retrieves the type of the Area Reinforcement.
    XYZ Direction { get; }
      Description: Retrieve the Major Direction of the Area Reinforcement.

  METHODS:
    static IList<ElementId> ConvertRebarInSystemToRebars(Document doc, AreaReinforcement system)
      Description: Converts all RebarInSystem elements owned by the input AreaReinforcement to equivalent Rebar elements.
      @doc: The document.
      @system: An AreaReinforcement element in the document.
      Returns: The ids of the newly created Rebar elements.
    static AreaReinforcement Create(Document document, Element hostElement, XYZ majorDirection, ElementId areaReinforcementTypeId, ElementId rebarBarTypeId, ElementId rebarHookTypeId)
      Description: Creates a new AreaReinforcement object based on a host boundary.
      @document: The document.
      @hostElement: The element that will host the AreaReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @majorDirection: A vector to define the major direction of the AreaReinforcement.
      @areaReinforcementTypeId: The id of the AreaReinforcementType.
      @rebarBarTypeId: The id of the RebarBarType.
      @rebarHookTypeId: The id of the RebarHookType. If this parameter is InvalidElementId, it means to create a rebar with no hooks.
      Returns: The newly created AreaReinforcement.
    static AreaReinforcement Create(Document document, Element hostElement, IList<Curve> curveArray, XYZ majorDirection, ElementId areaReinforcementTypeId, ElementId rebarBarTypeId, ElementId rebarHookTypeId)
      Description: Creates a new AreaReinforcement object from an array of curves. This method replaces the NewAreaReinforcement method, which has been deprecated.
      @document: The document.
      @hostElement: The element that will host the AreaReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @curveArray: An array of curves that will define the outline of the AreaReinforcement.
      @majorDirection: A vector to define the major direction of the AreaReinforcement.
      @areaReinforcementTypeId: The id of the AreaReinforcementType.
      @rebarBarTypeId: The id of the RebarBarType.
      @rebarHookTypeId: The id of the RebarHookType. If this parameter is InvalidElementId, it means to create a rebar with no hooks.
      Returns: The newly created AreaReinforcement.
    IList<ElementId> GetBoundaryCurveIds()
      Description: Retrieves the set of curves forming the boundary of the Area Reinforcement.
      Returns: A collection of ElementIds of AreaReinforcementCurve elements.
    ElementId GetHostId()
      Description: The element that contains the Area Reinforcement.
      Returns: The element that the Area Reinforcement object belongs to, such as a structural wall, floor or foundation.
    XYZ GetLayerDirection(AreaReinforcementLayerType layer)
      Description: Gets the direction of the layer. The lines are distributed along this direction.
      @layer: The layer type.
      Returns: Returns the direction of the desired layer.
    Line GetLineFromLayerAtIndex(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Gets the line from the desired layer at the specified index.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Returns: Returns the line from the desired layer at the specified index.
    Transform GetMovedLineTransform(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Returns a transform representing the movement of the line relative to its default position along the direction of the desired layer.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Returns: The transform representing the movement of the line relative to its default position along the direction of the desired layer.
    int GetNumberOfLines(AreaReinforcementLayerType layer)
      Description: Gets the number of lines on the specified layer. It also counts the excluded ones.
      @layer: The layer type for which will return the number of lines.
      Returns: Returns the number of lines on the specified layer.
    IList<ElementId> GetRebarInSystemIds()
      Description: Returns the ids of the RebarInSystem elements owned by the AreaReinforcement element.
    bool IsLayerActive(AreaReinforcementLayerType layer)
      Description: Identifies if the layer is active or not.
      @layer: The layer that will be tested.
      Returns: Returns true if the input layer is active, false otherwise
    bool IsLineIncluded(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Checks whether the line from the desired layer at the specified position is included or not.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Returns: Returns true if the line from the desired layer at the specified position is included, false otherwise.
    bool IsUnobscuredInView(View view)
      Description: Checks if Area Reinforcement is shown unobscured in a view.
      @view: The view element
      Returns: True if Area Reinforcement is shown unobscured, false otherwise.
    void MoveLine(XYZ translation, AreaReinforcementLayerType layer, int linePositionIndex)
      Description: This method applies the translation to the line from the desired layer, at the specified position. If the line was already moved, the method will concatenate the translation with the existing movement. The line will be translated only along the direction of the specified layer.
      @translation: The translation vector.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
    static IList<ElementId> RemoveAreaReinforcementSystem(Document doc, AreaReinforcement system)
      Description: Deletes the specified AreaReinforcement, and converts its RebarInSystem elements to equivalent Rebar elements.
      @doc: The document.
      @system: An AreaReinforcement element in the document.
      Returns: The ids of the newly created Rebar elements.
    void ResetMovedLineTransform(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Reset the transformation representing the movement of the line relative to its default position along the direction of the specified layer. The moved line transform will be set to Identity.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
    void SetLayerActive(bool active, AreaReinforcementLayerType layer)
      Description: Sets if the desired layer is active or not.
      @active: True to set the layer to be active, false otherwise.
      @layer: The layer type.
    void SetLineIncluded(bool include, AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Sets if the line from desired layer at the specified position is included or not.
      @include: True to include the line, false to exclude the line.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets Area Reinforcement to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if Area Reinforcement is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AreaReinforcementCurve
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcementCurve

Description: An object that specifies the type of a floor in Autodesk Revit.
Remarks: The structural layers of the floor can be accessed via this object.
Inherits: CurveElement
Implements: IDisposable

  PROPERTIES:
    Curve Curve { get; }
      Description: Returns the 3D curve forming part of the boundary of an Area Reinforcement element.

--------------------------------------------------------------------------------

[ENUM] AreaReinforcementLayerType
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcementLayerType

Description: Describes the layers of an Area Reinforcement
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TopOrFrontMajor = 0
    - TopOrFrontMinor = 1
    - BottomOrBackMajor = 2
    - BottomOrBackMinor = 3

[CLASS] AreaReinforcementType
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcementType

Description: An object that specifies the type of a Structural Area Reinforcement element in Autodesk Revit.
Remarks: The clear cover settings can be accessed via this object.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static ElementId CreateDefaultAreaReinforcementType(Document aDoc)
      Description: Creates a new AreaReinforcementType object with a default name.
      @aDoc: The document.
      Returns: The newly created type id.

--------------------------------------------------------------------------------

[ENUM] BendingDetailAngularDimensionsDisplayOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions

Description: Describes the angular dimensions display options.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AllAngles = 0
    - Exclude90Degrees = 1

[ENUM] BendingDetailAngularDimensionsMeasurementOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions

Description: Describes the angular dimension measurement options.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Inside = 0
    - Outside = 1

[ENUM] BendingDetailBendDiameterDimensionType
Full Name: Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType

Description: Describes the dimension type for bend diameter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Radial = 0
    - Diameter = 1

[ENUM] BendingDetailCustomFieldMultipleValuesIndicatorOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions

Description: Describes how the parameters with multiple values will be represented.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Varying = 0
    - MinimumMaximum = 1

[CLASS] BendingDetailCustomFieldProperties
Full Name: Autodesk.Revit.DB.Structure.BendingDetailCustomFieldProperties

Description: Represents the properties of a Bending Detail Custom Field.
Implements: ICustomFieldProperties, IDisposable

  PROPERTIES:
    BendingDetailAngularDimensionsDisplayOptions AngularDimensionsDisplayOption { get; set; }
      Description: Identifies the angular dimensions display options.
    bool AngularDimensionsEnabled { get; set; }
      Description: Identifies if any angular dimensions will be shown or not.
    bool AngularDimensionsForHooksEnabled { get; set; }
      Description: Identifies if the angular dimensions which has a reference set on a hook will be shown or not.
    BendingDetailAngularDimensionsMeasurementOptions AngularDimensionsMeasurementOptions { get; set; }
      Description: Identifies the measurement option for angular dimensions.
    double AngularDimensionsOffset { get; set; }
      Description: Identifies the offset of the angular dimensions.
    BendingDetailDimensionTextPosition AngularDimensionTextPosition { get; set; }
      Description: Identifies the text position with respect to dimension line.
    ElementId AngularDimensionTypeId { get; set; }
      Description: Identifies the Id of the angular dimension type which is used to show dimensions.
    bool BendDiameterDimensionsEnabled { get; set; }
      Description: Identifies if any radial or diameter dimensions will be shown or not.
    bool BendDiameterDimensionsForHooksEnabled { get; set; }
      Description: Identifies if radial or diameter dimensions will be shown for hook fillets This property has a meaning only if is set to true.
    bool BendDiameterDimensionsForSegmentsEnabled { get; set; }
      Description: Identifies if radial or diameter dimensions will be shown for the bends between segments. Radial or diameter dimesions for arc segments will be shown by default. This property has a menaning only if is set to true.
    BendingDetailBendDiameterDimensionType BendDiameterDimensionType { get; set; }
      Description: Identifies what type of bend diameter dimensions will be shown (radial or diameter).
    ElementId DiameterDimensionTypeId { get; set; }
      Description: Identifies the Id of the diameter dimension type which is used to show dimensions.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId LineStyleId { get; set; }
      Description: Identifies the line style that is used for drawing Bending Detail curves.
    BendingDetailCustomFieldMultipleValuesIndicatorOptions MultipleValuesIndicatorOption { get; set; }
      Description: Identifies how the Bending Detail will represent the varying rebar dimensions.
    bool OrthogonalAndOverallDimesionsEnabled { get; set; }
      Description: Identifies if orthogonal and overall dimensions are displayed.
    BendingDetailDisplayParametersOptions ParametersDisplayOption { get; set; }
      Description: Identifies how the parameters will be represented.
    ElementId RadialDimensionTypeId { get; set; }
      Description: Identifies the Id of the radial dimension type which is used to show dimensions.
    BendingDetailFor3DShapesOptions RepresentaionOf3DShapes { get; set; }
      Description: Identifies how the Bending Detail will represent the 3D shapes.
    bool SegmentLengthDimensionsEnabled { get; set; }
      Description: Identifies if any segment length dimensions will be shown or not.
    bool SegmentLengthDimensionsForHooksEnabled { get; set; }
      Description: Identifies if segment length dimensions for hooks will be shown or not. If this property is true, the should also be true to see segment length dimensions for hooks.
    double SegmentLengthDimensionsOffset { get; set; }
      Description: Identifies the offset of the segment length dimensions.
    BendingDetailDimensionTextPosition SegmentLengthDimensionTextPosition { get; set; }
      Description: Identifies the text position with respect to dimension line.
    ElementId SegmentLengthDimensionTypeId { get; set; }
      Description: Identifies the Id of the linear dimension type which is used to show segments length.
    BendingDetailSegmentLengthsDisplayOptions SegmentLengthsDisplayOption { get; set; }
      Description: Identifies if the segment lengths are represented using dimensions or just as text.
    BendingDetailSegmentLengthsDisplayOptions SegmentLengthsForArcsDisplayOption { get; set; }
      Description: Identifies if the arc segment lengths are represented using dimensions or just as text. Only RebarShapes whose definition is RebarShapeDefinitionByArc are considered that have arc segments.
    BendingDetailSegmentsRepresentation SegmentsRepresentation { get; set; }
      Description: Identifies how the bending detail will represent the segments of the bar.

  METHODS:
    bool AreEqualTo(ICustomFieldProperties otherProperties)
      Description: Identifies if the custom field properties are equal or not.
      @otherProperties: The other properties.
      Returns: Returns true if the custom field properties are equal, false otherwise.
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] BendingDetailDimensionTextPosition
Full Name: Autodesk.Revit.DB.Structure.BendingDetailDimensionTextPosition

Description: Describes how the text will be positioned with respect to dimension line.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - OutsideOfDimensionLine = 1

[ENUM] BendingDetailDisplayMode
Full Name: Autodesk.Revit.DB.Structure.BendingDetailDisplayMode

Description: Describes the mode in which the Bending Detail will be represented.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Realistic = 0
    - Schematic = 1

[ENUM] BendingDetailDisplayParametersOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions

Description: Describes how the parameters will be represented.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ByValue = 0
    - ByName = 1

[ENUM] BendingDetailFor3DShapesOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions

Description: Describes how the Bending Detail will be represented for 3D shapes.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - IsometricView = 0
    - PlanView = 1

[ENUM] BendingDetailLevelOfDetail
Full Name: Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail

Description: Describes the level of detail in which the Bending Detail will be represented.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ByView = 0
    - Coarse = 1
    - Fine = 2

[ENUM] BendingDetailSegmentLengthsDisplayOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions

Description: Describes if the segment lengths are represented using dimensions or just as text.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Text = 0
    - Dimension = 1

[ENUM] BendingDetailSegmentsRepresentation
Full Name: Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation

Description: Describes how the Bending Detail will represent the bar segments.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Standard = 0
    - Unfold = 1
    - Offset = 2

[ENUM] BendingDetailTypeMultipleValuesIndicatorOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions

Description: Describes how the parameters with multiple values will be represented.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FromOneBar = 0
    - MinimumMaximum = 1

[ENUM] BentFabricBendDirection
Full Name: Autodesk.Revit.DB.Structure.BentFabricBendDirection

Description: Direction in which FabricSheet is bent.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Major = 0
    - Minor = 1

[ENUM] BentFabricStraightWiresLocation
Full Name: Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation

Description: Bent Fabric straight wires location. The side on wich straight wires will be loacted is determined by the start and end point of the first bent profile segment that specifies the direction of the curve loop on plane.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Right = 0
    - Left = 1

[CLASS] BoundaryConditions
Full Name: Autodesk.Revit.DB.Structure.BoundaryConditions

Description: An object that represents a force applied across an area.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId AssociatedLoadId { get; set; }
      Description: The Id of the internal load element associated with a boundary conditions.
    ElementId HostElementId { get; }
      Description: The host element Id for the boundary conditions.
    XYZ Point { get; }
      Description: Returns the position of point boundary conditions.

  METHODS:
    BoundaryConditionsType GetBoundaryConditionsType()
      Description: Returns the boundary conditions type.
      Returns: The boundary conditions type.
    Curve GetCurve()
      Description: Returns curve that define geometry of the line boundary conditions.
    Transform GetDegreesOfFreedomCoordinateSystem()
      Description: Gets the origin and rotation of coordinate system that is used by translation and rotation parameters, like X Translation or Z Rotation.
      Returns: The coordinate system. Origin contains the position of the start of the boundary conditions. BasisX, BasisY and BasisZ contain the directions of the axes in the global coordinate system.
    IList<CurveLoop> GetLoops()
      Description: Returns curve loops that define geometry of the area boundary conditions.
      Returns: The curve loop collection.
    BoundaryConditionsOrientTo GetOrientTo()
      Description: Returns the boundary conditions orientation option.
      Returns: The orientation option.
    void SetOrientTo(BoundaryConditionsOrientTo orientTo)
      Description: Sets the boundary condition orientation option.
      @orientTo: The new orientation option.

--------------------------------------------------------------------------------

[ENUM] BoundaryConditionsOrientTo
Full Name: Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo

Description: Specifies boundary condition orientation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Project = 0
    - HostLocalCoordinateSystem = 1

[ENUM] BoundaryConditionsType
Full Name: Autodesk.Revit.DB.Structure.BoundaryConditionsType

Description: This enum declares type of BoundaryConditions.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Point = 0
    - Line = 1
    - Area = 2

[ENUM] BracePlanRepresentation
Full Name: Autodesk.Revit.DB.Structure.BracePlanRepresentation

Description: The possible representations for braces in plan views.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ParallelLine = 1
    - LineWithAngle = 2

[CLASS] CodeCheckingParameterServiceData
Full Name: Autodesk.Revit.DB.Structure.CodeCheckingParameterServiceData

Description: The data needed by code checking server to perform code checking.
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The current document.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<ElementId> GetCurrentElements()
      Description: Returns the list of Ids of the current elements.
      Returns: Ids of the current elements. Contains the analytical model element to which the code checking parameter belongs.

--------------------------------------------------------------------------------

[CLASS] ConnectionInputPoint
Full Name: Autodesk.Revit.DB.Structure.ConnectionInputPoint

Description: An object that holds information about a connection input point
Implements: IDisposable

  CONSTRUCTORS:
    new ConnectionInputPoint(XYZ pt)
    new ConnectionInputPoint(XYZ pt, Guid uid)
    new ConnectionInputPoint()

  PROPERTIES:
    Guid Id { get; set; }
      Description: Unique id of this input point.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Point { get; set; }
      Description: 3d position of this input point.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ConnectionInputPointInfo
Full Name: Autodesk.Revit.DB.Structure.ConnectionInputPointInfo

Description: An object that holds description information about a connection input point
Implements: IDisposable

  CONSTRUCTORS:
    new ConnectionInputPointInfo(string ptSelectionText, int inputMemberIndex, string restrictionType)
    new ConnectionInputPointInfo()

  PROPERTIES:
    int InputMemberIndex { get; set; }
      Description: A index of the input member to which the restriction applies.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string PointSelectionText { get; set; }
      Description: A string used to select input point by some connections.
    string RestrictionType { get; set; }
      Description: A type of input point restriction.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] DistributionType
Full Name: Autodesk.Revit.DB.Structure.DistributionType

Description: The type of the distribution
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Uniform = 0
    - VaryingLength = 1

[CLASS] EndTreatmentType
Full Name: Autodesk.Revit.DB.Structure.EndTreatmentType

Description: An end treatment type object that is used to hold information about the end treatment applied to bars that are connected to a coupler.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    string EndTreatment { get; set; }
      Description: String describing the end treatment

  METHODS:
    static EndTreatmentType Create(Document doc, string strTreatment)
      Description: Creates a new EndTreatmentType in a document and adds the input string to the endTreatment parameter.
    static EndTreatmentType Create(Document doc)
      Description: Creates a new EndTreatmentType in a document.
    static ElementId CreateDefaultEndTreatmentType(Document ADoc)
      Description: Creates a new EndTreatmentType object with a default name.
      @ADoc: The document.
      Returns: The newly created type id.

--------------------------------------------------------------------------------

[CLASS] ExtElemChangeBeamSectionRegistry
Full Name: Autodesk.Revit.DB.Structure.ExtElemChangeBeamSectionRegistry

Description: An object that stores IExtElemChangeBeamSection
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static void RegisterInterface(IExtElemChangeBeamSection provider)
      Description: Registers a IExtElemChangeBeamSection
      @provider: IExtElemChangeBeamSection to be registered.
    static void Unregister()
      Description: Unregisters IExtElemChangeBeamSection.

--------------------------------------------------------------------------------

[CLASS] FabricArea
Full Name: Autodesk.Revit.DB.Structure.FabricArea

Description: An object that represents an Fabric Area Distribution within the Autodesk Revit project. It is container for Fabric Sheet elements.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object. The Fabric Area element is available only in the Autodesk Revit Structure product.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double CoverOffset { get; set; }
      Description: The additional cover offset of the fabric distribution.
    XYZ Direction { get; }
      Description: The Major Direction of the Fabric Area.
    XYZ DirectionOrigin { get; }
      Description: The Origin Point of the Major Direction of the Fabric Area.
    FabricAreaType FabricAreaType { get; }
      Description: The type of the Fabric Area.
    FabricLocation FabricLocation { get; set; }
      Description: The Fabric location in the host.
    ElementId FabricSheetTypeId { get; set; }
      Description: The id of the Fabric Sheet Type for this element.
    ElementId HostId { get; }
      Description: The id of the Host element for the fabric area.
    FabricLapSplicePosition LapSplicePosition { get; set; }
      Description: The fabric lap splice position in the fabric distribution.
    double MajorLapSpliceLength { get; set; }
      Description: The fabric lap splice length in the fabric distribution in the major direction.
    FabricSheetAlignment MajorSheetAlignment { get; set; }
      Description: The fabric sheet alignment in the fabric distribution in the major direction.
    double MinorLapSpliceLength { get; set; }
      Description: The fabric lap splice length in the fabric distribution in the minor direction.
    FabricSheetAlignment MinorSheetAlignment { get; set; }
      Description: The fabric sheet alignment in the fabric distribution in the minor direction.
    ElementId SketchId { get; }
      Description: The id of the Sketch element for this element.
    ElementId TagViewId { get; set; }
      Description: The element of the view in which to tag new members of this element.

  METHODS:
    IList<CurveLoop> CopyCurveLoopsInSketch()
      Description: Creates copies of the CurveLoops in the FabricArea sketch.
      Returns: The copy of the curve loops.
    static FabricArea Create(Document aDoc, Element hostElement, XYZ majorDirection, ElementId fabricAreaTypeId, ElementId fabricSheetTypeId)
      Description: Creates a FabricArea based on a host boundary.
      @aDoc: The document.
      @hostElement: The element that will host the FabricArea. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @majorDirection: A vector to define the major direction of the FabricArea.
      @fabricAreaTypeId: The id of the FabricAreaType.
      @fabricSheetTypeId: The id of the FabricSheetType.
      Returns: The newly created FabricArea.
    static FabricArea Create(Document aDoc, Element hostElement, IList<CurveLoop> curveLoops, XYZ majorDirection, XYZ majorDirectionOrigin, ElementId fabricAreaTypeId, ElementId fabricSheetTypeId)
      Description: Creates a FabricArea from an array of curves.
      @aDoc: The document.
      @hostElement: The element that will host the FabricArea. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @curveLoops: An array of curves that will define the outline of the FabricArea. This includes curves defining openings in the interior of the area.
      @majorDirection: A vector to define the major direction of the FabricArea.
      @majorDirectionOrigin: An origin point of the major direction line
      @fabricAreaTypeId: The id of the FabricAreaType.
      @fabricSheetTypeId: The id of the FabricSheetType.
      Returns: The newly created FabricArea.
    IList<ElementId> GetBoundaryCurveIds()
      Description: Retrieves the identifiers of the set of curves forming the boundary of the Fabric Area.
      Returns: A collection of ElementIds of FabricAreaCurve elements.
    IList<ElementId> GetFabricSheetElementIds()
      Description: Retrieves the identifiers of all the FabricSheet Elements in the FabricArea.
      Returns: A collection of ElementIds of FabricSheet elements.
    FabricRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    double GetTotalSheetMass()
      Description: Calculates the total sheet mass: Volume of Wire * Unit Weight.
      Returns: The total sheet mass.
    IList<ElementId> GetValidViewsForTags()
      Description: Gets ids of the views where tags and symbols can be placed for the FabricArea and/or FabricSheets
      Returns: The collection of View ElementIds.
    bool IsCoverOffsetValid(double coverOffset)
      Description: Identifies if the specified value is valid for use as a cover offset.
      @coverOffset: The cover offset value.
      Returns: True if the value is valid, false if the value is invalid.
    bool IsValidMajorLapSplice(double majorLapSplice)
      Description: Identifies if the specified value is valid for use as a major lap splice.
      @majorLapSplice: The major lap splice value.
      Returns: True if the value is valid, false if the value is invalid.
    bool IsValidMinorLapSplice(double minorLapSplice)
      Description: Identifies if the specified value is valid for use as a minor lap splice.
      @minorLapSplice: The minor lap splice value.
      Returns: True if the value is valid, false if the value is invalid.
    static IList<ElementId> RemoveFabricReinforcementSystem(Document doc, FabricArea system)
      Description: Deletes the specified FabricArea, and converts its FabricSheet elements to equivalent Single Fabric Sheet elements.
      @doc: The document.
      @system: An FabricArea Reinforcement element in the document.
      Returns: The ids of the newly created Single Fabric Sheet elements.

--------------------------------------------------------------------------------

[CLASS] FabricAreaType
Full Name: Autodesk.Revit.DB.Structure.FabricAreaType

Description: A FabricAreaType object is used in FabricArea object generation.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static ElementId CreateDefaultFabricAreaType(Document aDoc)
      Description: Creates a new FabricAreaType object with a default name.
      @aDoc: The document.
      Returns: The newly created type id.

--------------------------------------------------------------------------------

[ENUM] FabricHostReference
Full Name: Autodesk.Revit.DB.Structure.FabricHostReference

Description: Controls if Single Fabric Sheet should be cut by the Host Cover.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotCutByCover = 0
    - CutByCover = 1

[ENUM] FabricLapSplicePosition
Full Name: Autodesk.Revit.DB.Structure.FabricLapSplicePosition

Description: Fabric lap splice position in the fabric distribution
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Aligned = 0
    - MajorHalfwayStagger = 1
    - MajorPassingStagger = 2
    - MinorHalfwayStagger = 3
    - MinorPassingStagger = 4

[ENUM] FabricLocation
Full Name: Autodesk.Revit.DB.Structure.FabricLocation

Description: Fabric location in the host
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TopOrExternal = 0
    - BottomOrInternal = 1

[CLASS] FabricReinSpanSymbol
Full Name: Autodesk.Revit.DB.Structure.FabricReinSpanSymbol

Description: Represents an instance of a Structural Fabric Reinforcement Symbol in Autodesk Revit.
Inherits: IndependentTag
Implements: IDisposable

  METHODS:
    static FabricReinSpanSymbol Create(Document document, ElementId viewId, LinkElementId hostId, XYZ point, ElementId symbolId)
      Description: Places a new instance of the Structural Fabric Reinforcement Symbol into the project relative to a particular FabricSheet and View.
      @document: The document.
      @viewId: The id of the view in which the symbol should appear.
      @hostId: The ElementId of FabricSheet (either in the document, or linked from another document).
      @point: The span symbol's head position.
      @symbolId: The id of the family symbol of this symbol.
      Returns: A reference to the newly-created symbol.

--------------------------------------------------------------------------------

[CLASS] FabricRoundingManager
Full Name: Autodesk.Revit.DB.Structure.FabricRoundingManager

Description: Provides access to element reinforcement roundings overrides.
Remarks: An instance of this class can be obtained from specific FabricSheetType or individual FabricSheet or FabricArea elements to apply overrides different from the global settings for the project.
Inherits: ReinforcementRoundingManager
Implements: IDisposable

  PROPERTIES:
    ReinforcementRoundingSource ApplicableReinforcementRoundingSource { get; }
      Description: Identifies the source of the rounding settings for this element.
    double ApplicableSegmentLengthRounding { get; }
      Description: The applicable rounding for fabric segments.
    RoundingMethod ApplicableSegmentLengthRoundingMethod { get; }
      Description: The applicable rounding method for fabric segments.
    double ApplicableTotalLengthRounding { get; }
      Description: The applicable rounding for Cut Overall Length and Cut Overall Width parameters.
    RoundingMethod ApplicableTotalLengthRoundingMethod { get; }
      Description: The applicable rounding method for Cut Overall Length and Cut Overall Width parameters.
    double SegmentLengthRounding { get; set; }
      Description: The rounding for fabric segments.
    RoundingMethod SegmentLengthRoundingMethod { get; set; }
      Description: Identifies the segment length rounding method
    double TotalLengthRounding { get; set; }
      Description: The rounding for Cut Overall Length and Cut Overall Width parameters.
    RoundingMethod TotalLengthRoundingMethod { get; set; }
      Description: Identifies the total length rounding method

--------------------------------------------------------------------------------

[CLASS] FabricSheet
Full Name: Autodesk.Revit.DB.Structure.FabricSheet

Description: An object that represents an Fabric Sheet Element within the Autodesk Revit project.
Remarks: Beginning with Revit 2016, fabric sheets can be either flat or bent. Both kinds of fabric sheets are implemented by this FabricSheet class. Fabric sheets are created as either flat or bent. Once created, the kind of a fabric sheet cannot be changed. The Fabric Sheet element is available only in the Autodesk Revit Structure product.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    XYZ BendFinalLoopOrientationVector { get; }
      Description: Direction of local Fabric Sheet Y axis in bending polyline LCS.
    BentFabricBendDirection BentFabricBendDirection { get; set; }
      Description: Specifies which wire direction of the fabric sheet is bent.
    double BentFabricLongitudinalCutLength { get; set; }
      Description: Specifies the cut length of the fabric sheet perpendicular to the bend edge.
    BentFabricStraightWiresLocation BentFabricStraightWiresLocation { get; set; }
      Description: Specifies the location of straight bars with respect to bent bars in the fabric sheet.
    double CoverOffset { get; set; }
      Description: The additional cover offset of the Fabric Sheet.
    double CutOverallLength { get; }
      Description: The sheet length after cutting has taken place.
    double CutOverallWidth { get; }
      Description: The sheet length after cutting has taken place.
    double CutSheetMass { get; }
      Description: The sheet mass after cutting has taken place.
    ElementId FabricAreaOwnerId { get; }
      Description: The Fabric Area Id.
    FabricHostReference FabricHostReference { get; set; }
      Description: Controls if Single Fabric Sheet should be cut by the Host Cover
    FabricLocation FabricLocation { get; set; }
      Description: The Fabric Sheet location in the host.
    string FabricNumber { get; }
      Description: Specifies the numerical parameter assigned to the fabric sheet and any sheet of the same type, dimension, material, shape, and partition.
    ElementId HostId { get; }
      Description: The structure element that contains the Fabric Sheet.
    bool IsBent { get; }
      Description: The type of fabric sheet. True for bent fabric sheet, false for flat fabric sheet.
    ElementId SketchId { get; }
      Description: The id of the Sketch element for this element.

  METHODS:
    static FabricSheet Create(Document document, ElementId concreteHostElementId, ElementId fabricSheetTypeId, CurveLoop bendProfile)
      Description: Creates a new instance of a single bent Fabric Sheet element within the project.
      @document: The document in which the fabric sheet is to be created.
      @concreteHostElementId: The element that will host the FabricSheet. The host can be a Structural Floor, Structural Wall, Structural Slab, Structural Floor Edge, Structural Slab Edge, Structural Column, Beam and Brace. Also, host can be a created from a structural layer of Structural Floor, Structural Wall or Structural Slab.
      @fabricSheetTypeId: The id of the FabricSheetType.
      @bendProfile: A profile that defines the bending shape of the fabric sheet. The profile can be provided without fillets (eg. for L shape, only two lines not two lines and one arc), if so, then fillets (in example one arc) will be automatically generated basing on the Bend Diameter parameter defined in the Fabric Wire system family. If the provided profile has no corners (has a tangent defined at each point except the ends), no fillets will be generated. The provided profile defines the center-curve of a wire.
      Returns: The instance of the newly created bent fabric sheet.
    static FabricSheet Create(Document document, Element hostElement, ElementId fabricSheetTypeId)
      Description: Creates a new instance of a single flat Fabric Sheet element within the project.
      @document: The document in which the fabric sheet is to be created.
      @hostElement: The element that will host the FabricSheet. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @fabricSheetTypeId: The id of the FabricSheetType.
      Returns: The newly created single Fabric Sheet instance.
    CurveLoop GetBendProfile()
      Description: Returns the profile (not including generated fillets) that defines the shape of the Fabric Sheet bending.
      Returns: The profile that defines the shape of the fabric sheet bending for bent fabric sheet, for flat fabric sheet will be returned.
    CurveLoop GetBendProfileWithFillets()
      Description: Returns the profile with generated fillets that defines the shape of the Fabric Sheet bending.
      Returns: The bend profile with generated fillets that defines the shape of the fabric sheet bending for bent fabric sheet, for flat fabric sheet will be returned.
    FabricRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    IDictionary<ElementId, double> GetSegmentParameterIdsAndLengths(bool rounded)
      Description: Returns the array of pairs [parameter ID, length] that correspond to segments of a bent fabric sheet (like A, B, C, D etc.).
      @rounded: Set to true to return rounded values for segments lengths.
      Returns: Array of pairs [parameter ID, length] that correspond to segments of a bent fabric sheet (like A, B, C, D etc.) is returned for bend fabric sheet. For flat fabric sheet (not bent) empty array is returned.
    Transform GetSheetLocation()
      Description: Gets the position and the orientation of the Fabric Sheet instance.
      Returns: The location of the Fabric Sheet instance.
    IList<Curve> GetWireCenterlines()
      Description: Gets a list of curves representing the wires centerlines of the Fabric Sheet in the both distribution directions.
      Returns: The centerline curves.
    IList<Curve> GetWireCenterlines(WireDistributionDirection wireDirection)
      Description: Gets a list of curves representing the wires centerlines of the Fabric Sheet.
      @wireDirection: The direction of wire distribution in the Fabric Sheet.
      Returns: The centerline curves.
    bool IsCoverOffsetValid(double coverOffset)
      Description: Identifies if the specified value is valid for use as a cover offset.
      @coverOffset: The cover offset value.
      Returns: True if the value is valid, false if the value is invalid.
    bool IsSingleFabricSheetWithinHost(Element hostElement, Transform transform)
      Description: Identifies if the specified single Fabric Sheet position is within the host.
      @hostElement: A structural element that will host the Fabric Sheet.
      @transform: The transform that defines the placement of the instance single Fabric Sheet.
      Returns: True if the single Fabric Sheet instance is within the host, false if the single Fabric Sheet instance is out of host.
    bool IsUnobscuredInView(View view)
      Description: Checks if this fabric sheet is shown unobscured in a view.
      @view: The view element
      Returns: True if fabric sheet is shown unobscured, false otherwise.
    static bool IsValidHost(Element host)
      Description: Checks whether an element is a valid host for fabric sheet.
      @host: The element to check.
      Returns: True if the element is a valid host for fabric sheet, false otherwise.
    static bool IsValidHost(Document document, ElementId concreteHostElementId)
      Description: Checks whether an element is a valid host for fabric sheet.
      @document: The document.
      @concreteHostElementId: The elementId to check.
      Returns: True if the element is a valid host for fabric sheet, false otherwise.
    void PlaceInHost(Element hostElement, Transform transform)
      Description: Inserts the single Fabric Sheet instance into the host element.
      @hostElement: A structural element that will host the Fabric Sheet. The element must support fabric hosting.
      @transform: The transform that defines the placement of the instance single Fabric Sheet.
    void SetBendProfile(CurveLoop bendProfile)
      Description: Sets new profile that defines the shape of the Fabric Sheet bending.
      @bendProfile: A profile that defines the bending shape of the fabric sheet. The profile can be provided without fillets (eg. for L shape, only two lines not two lines and one arc), if so, then fillets (in example one arc) will be automatically generated basing on the Bend Diameter parameter defined in the Fabric Wire system family. If the provided profile has no corners (has a tangent defined at each point except the ends), no fillets will be generated. The provided profile defines the center-curve of a wire.
    void SetSegmentLength(ElementId segmentParameterId, double value)
      Description: Sets the value of the bent fabric sheet segment(like A, B, C, D etc.)
      @segmentParameterId: The segment ID of the bent fabric sheet.
      @value: The length value to set
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets this fabric sheet to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if fabric sheet is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[ENUM] FabricSheetAlignment
Full Name: Autodesk.Revit.DB.Structure.FabricSheetAlignment

Description: Fabric Sheet alignment in the fabric distribution
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Null = 0
    - StartingEdge = 1
    - EndingEdge = 2
    - BothEdges = 3

[ENUM] FabricSheetLayoutPattern
Full Name: Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern

Description: The pattern for how the wires in Fabric Sheet are laid out.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ActualSpacing = 0
    - FixedNumber = 1
    - MaximumSpacing = 2
    - NumberWithSpacing = 3
    - QuantitativeSpacing = 4

[CLASS] FabricSheetType
Full Name: Autodesk.Revit.DB.Structure.FabricSheetType

Description: Represents a fabric sheet type, used in the generation of fabric wires.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    ElementId MajorDirectionWireType { get; set; }
      Description: The id of the FabricWireType to be used in the major direction.
    double MajorEndOverhang { get; }
      Description: The distance from the edge of the sheet to the last wire (measured in the major direction).
    double MajorLapSpliceLength { get; set; }
      Description: The lap splice length in the major direction.
    FabricSheetLayoutPattern MajorLayoutPattern { get; }
      Description: The layout pattern in the major direction.
    int MajorNumberOfWires { get; }
      Description: The number of wires used in the major direction (includes the first and last wires).
    double MajorReinforcementArea { get; }
      Description: The area of fabric divided by the spacing of the wire in the major direction. This method does not apply to custom fabric sheet
    double MajorSpacing { get; }
      Description: The spacing between the wires in the major direction (not including the overhangs).
    double MajorStartOverhang { get; }
      Description: The distance from the edge of the sheet to the first wire (measured in the major direction).
    ElementId Material { get; set; }
      Description: The id of the material assigned to wires.
    ElementId MinorDirectionWireType { get; set; }
      Description: The id of the FabricWireType to be used in the minor direction.
    double MinorEndOverhang { get; }
      Description: The distance from the edge of the sheet to the last wire (measured in the minor direction).
    double MinorLapSpliceLength { get; set; }
      Description: The lap splice length in the minor direction.
    FabricSheetLayoutPattern MinorLayoutPattern { get; }
      Description: The layout pattern in the minor direction.
    int MinorNumberOfWires { get; }
      Description: The number of wires used in the minor direction (includes the 1st and last wires).
    double MinorReinforcementArea { get; }
      Description: The area of fabric divided by the spacing of the wire in the minor direction. This method does not apply to custom fabric sheet
    double MinorSpacing { get; }
      Description: The spacing between the wires in the minor direction (not including the overhangs).
    double MinorStartOverhang { get; }
      Description: The distance from the edge of the sheet to the first wire (measured in the minor direction).
    double OverallLength { get; }
      Description: The length of the wire sheet (including overhangs) in the major direction.
    double OverallWidth { get; }
      Description: The length of the wire sheet (including overhangs) in the minor direction.
    double SheetMass { get; set; }
      Description: The sheet mass.
    double SheetMassUnit { get; }
      Description: The sheet mass per area unit.

  METHODS:
    static ElementId CreateDefaultFabricSheetType(Document ADoc)
      Description: Creates a new FabricSheetType object with a default name.
      @ADoc: The document.
      Returns: The newly created type id.
    FabricRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    FabricWireItem GetWireItem(int wireIndex, WireDistributionDirection direction)
      Description: Gets the Wire stored in the FabricSheetType at the associated index.
      @wireIndex: Item index in the Fabric Sheet
      @direction: Wire distribution direction of the inquired item
      Returns: Fabric wire Item
    bool IsCustom()
      Description: Verifies if the type is Custom Fabric Sheet
      Returns: True if Layout is set on Custom and if the wireArr is not null
    bool IsValidMajorLapSplice(double majorLapSplice)
      Description: Identifies if the input value is valid to be applied as the major lap splice value for this FabricSheetType.
    bool IsValidMinorLapSplice(double minorLapSplice)
      Description: Identifies if the input value is valid to be applied as the minor lap splice value for this FabricSheetType.
    void SetLayoutAsCustomPattern(double minorStartOverhang, double majorStartOverhang, IList<FabricWireItem> minorFabricWireItems, IList<FabricWireItem> majorFabricWireItems)
      Description: Sets the minor and major layout patterns as Custom, while specifying the needed parameters for this pattern.
      @minorStartOverhang: The distance from the edge of the sheet to the first wire in the minor direction.
      @majorStartOverhang: The distance from the edge of the sheet to the first wire in the major direction.
      @minorFabricWireItems: The fabric wire items in the minor direction.
      @majorFabricWireItems: The fabric wire items in the major direction.
    void SetMajorLayoutAsActualSpacing(double overallWidth, double minorStartOverhang, double spacing)
      Description: Sets the major layout pattern as ActualSpacing, while specifying the needed parameters for this pattern.
      @overallWidth: The entire width of the wire sheet in the minor direction.
      @minorStartOverhang: The distance from the edge of the sheet to the first wire in the minor direction.
      @spacing: The distance between the wires in the major direction.
    void SetMajorLayoutAsFixedNumber(double overallWidth, double minorStartOverhang, double minorEndOverhang, int numberOfWires)
      Description: Sets the major layout pattern as FixedNumber, while specifying the needed parameters for this pattern.
      @overallWidth: The entire width of the wire sheet in the minor direction.
      @minorStartOverhang: The distance from the edge of the sheet to the first wire in the minor direction.
      @minorEndOverhang: The distance from the last wire to the edge of the sheet in the minor direction.
      @numberOfWires: The number of the wires to set in the major direction.
    void SetMajorLayoutAsMaximumSpacing(double overallWidth, double minorStartOverhang, double minorEndOverhang, double spacing)
      Description: Sets the major layout pattern as MaximumSpacing, while specifying the needed parameters for this pattern.
      @overallWidth: The entire width of the wire sheet in the minor direction.
      @minorStartOverhang: The distance from the edge of the sheet to the first wire in the minor direction.
      @minorEndOverhang: The distance from the last wire to the edge of the sheet in the minor direction.
      @spacing: The distance between the wires in the major direction.
    void SetMajorLayoutAsNumberWithSpacing(double overallWidth, double minorStartOverhang, int numberOfWires, double spacing)
      Description: Sets the major layout pattern as NumberWithSpacing, while specifying the needed parameters for this pattern.
      @overallWidth: The entire width of the wire sheet in the minor direction.
      @minorStartOverhang: The distance from the edge of the sheet to the first wire in the minor direction.
      @numberOfWires: The number of the wires to set in the major direction.
      @spacing: The distance between the wires in the major direction.
    void SetMinorLayoutAsActualSpacing(double overallLength, double majorStartOverhang, double spacing)
      Description: Sets the minor layout pattern as ActualSpacing, while specifying the needed parameters for this pattern.
      @overallLength: The entire length of the wire sheet in the major direction.
      @majorStartOverhang: The distance from the edge of the sheet to the first wire in the major direction.
      @spacing: The distance between the wires in the minor direction.
    void SetMinorLayoutAsFixedNumber(double overallLength, double majorStartOverhang, double majorEndOverhang, int numberOfWires)
      Description: Sets the major layout pattern as FixedNumber, while specifying the needed parameters for this pattern.
      @overallLength: The entire length of the wire sheet in the major direction.
      @majorStartOverhang: The distance from the edge of the sheet to the first wire in the major direction.
      @majorEndOverhang: The distance from the last wire to the edge of the sheet in the major direction.
      @numberOfWires: The number of the wires to set in the minor direction.
    void SetMinorLayoutAsMaximumSpacing(double overallLength, double majorStartOverhang, double majorEndOverhang, double spacing)
      Description: Sets the major layout pattern as MaximumSpacing, while specifying the needed parameters for this pattern.
      @overallLength: The entire length of the wire sheet in the major direction.
      @majorStartOverhang: The distance from the edge of the sheet to the first wire in the major direction.
      @majorEndOverhang: The distance from the last wire to the edge of the sheet in the major direction.
      @spacing: The distance between the wires in the minor direction.
    void SetMinorLayoutAsNumberWithSpacing(double overallLength, double majorStartOverhang, int numberOfWires, double spacing)
      Description: Sets the major layout pattern as NumberWithSpacing, while specifying the needed parameters for this pattern.
      @overallLength: The entire length of the wire sheet in the major direction.
      @majorStartOverhang: The distance from the edge of the sheet to the first wire in the major direction.
      @numberOfWires: The number of wires in the minor direction.
      @spacing: The distance between the wires in the minor direction.

--------------------------------------------------------------------------------

[ENUM] FabricTagComponentReference
Full Name: Autodesk.Revit.DB.Structure.FabricTagComponentReference

Description: How FabricSheet tag text will be aligned to the FabricSheet symbol.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - MajorAxis = 0
    - MinorAxis = 1
    - Diagonal = 2
    - Intersection = 3

[CLASS] FabricWireItem
Full Name: Autodesk.Revit.DB.Structure.FabricWireItem

Description: Provides implementation for FabricWires stored in a Custom Fabric Sheet
Implements: IDisposable

  PROPERTIES:
    double Distance { get; set; }
      Description: Distance to the next fabric wire item Can be 0 to be used with offset along wire.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double OffsetAlongWire { get; set; }
      Description: Offset along wire direction Wire distance should be 0 if we want to be along the same wire
    double WireLength { get; set; }
      Description: Wire length for this wire item
    ElementId WireType { get; set; }
      Description: The wire type of this wire item

  METHODS:
    static FabricWireItem Create(double distance, double wireLength, ElementId wireType, double wireOffset)
      Description: Creates a new instance of a single Fabric wire.
      @distance: The distance between this wire and the next wire in the Custom Fabric Sheet
      @wireLength: Length of this wire
      @wireType: The wire type of this wire
      @wireOffset: The offset between two wires in the same line
      Returns: The newly created Fabric wire instance.
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] FabricWireType
Full Name: Autodesk.Revit.DB.Structure.FabricWireType

Description: A Fabric Wire Type object that is used in the generation of Fabric Wire.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    double BendDiameter { get; set; }
      Description: Determines the bending diameter of the wire.
    double WireDiameter { get; set; }
      Description: Determines the diameter of the wire.

  METHODS:
    static ElementId CreateDefaultFabricWireType(Document ADoc)
      Description: Creates a new FabricWireType object with a default name.
      @ADoc: The document.
      Returns: The newly created type id.

--------------------------------------------------------------------------------

[CLASS] FamilyStructuralMaterialTypeFilter
Full Name: Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter

Description: A filter used to match families that have the given structural material type.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new FamilyStructuralMaterialTypeFilter(StructuralMaterialType structuralMaterialType, bool inverted)
    new FamilyStructuralMaterialTypeFilter(StructuralMaterialType structuralMaterialType)

  PROPERTIES:
    StructuralMaterialType StructuralMaterialType { get; }
      Description: The family structural material type.

--------------------------------------------------------------------------------

[CLASS] Hub
Full Name: Autodesk.Revit.DB.Structure.Hub

Description: Represents a connection between two or more Autodesk Revit Elements.
Remarks: Elements connected via a Hub do not refer directly to each other - they each refer to the Hub that keeps all the connectivity information.Hubs connect only structural Analytical Model Elements.
Inherits: Element
Implements: IDisposable

  METHODS:
    ConnectorManager GetHubConnectorManager()
      Description: Retrieves the ConnectorManager of the Hub.
      Returns: The ConnectorManager.
    XYZ GetOrigin()
      Description: Retrieves position of a Hub if such position is a 3D point.
      Returns: The origin.
    bool HasOrigin()
      Description: Provides information if Hub has a specific location at point in 3D space.
      Returns: True if the Hub has a specific location at point in 3D space.

--------------------------------------------------------------------------------

[INTERFACE] ICodeCheckingParameterServer
Full Name: Autodesk.Revit.DB.Structure.ICodeCheckingParameterServer

Description: Interface for the code checking parameter server to implement.
Implements: IExternalServer

  METHODS:
    bool PerformCodeChecking(CodeCheckingParameterServiceData data)
      Description: The server's method that will be called when Revit User clicks the Code Checking parameter's button from the properties palette.
      @data: The Code Checking data.
      Returns: Indicates whether the code checking parameter server is executed successfully.

--------------------------------------------------------------------------------

[INTERFACE] IExtElemChangeBeamSection
Full Name: Autodesk.Revit.DB.Structure.IExtElemChangeBeamSection

Description: Interface Change Beam section functionality to be implemented in add-ins

  METHODS:
    bool ChangeSection(Document doc, ElementId idElem)
      Description: The method that will be called when user wants to change beam section
      @doc: Revit document
      @idElem: id of the selected element
      Returns: Indicates whether the operation succeeded or not

--------------------------------------------------------------------------------

[INTERFACE] IMemberForcesServer
Full Name: Autodesk.Revit.DB.Structure.IMemberForcesServer

Description: Interface for the Member Forces server to implement.
Implements: IExternalServer

  METHODS:
    bool MemberForcesUpdate(MemberForcesServiceData data)
      Description: The server's method that will be called when Revit User clicks Member Forces button in the MPP.
      @data: The Moment Forces data.
      Returns: Indicates whether themember forces parameter server is executed successfully.

--------------------------------------------------------------------------------

[INTERFACE] IRebarUpdateServer
Full Name: Autodesk.Revit.DB.Structure.IRebarUpdateServer

Description: Represents an interface that should be overridden to allow the generation and update of free form rebar geometry.
Remarks: This interface should be overridden in order to create a free form rebar with constraints and to allow generation and update of its geometry. Once a rebar is created with a server, it will be called function. In the execution on this function should be defined the handles of the rebar. Based on these handles rebar constraints can be defined. Once the constraints are defined a regeneration should be triggered in order to generate the bar geometry. During the regeneration the functions and will be called. For GenerateCurves() it is supposed to calculate bars in set based on constraints. For TrimExtendCurves() it is supposed to trim or extend curves that were obtained from GenerateCurves(). Also in this function new constraints for start and end bar handles can be created. After the execution of these two functions the bar should appear on screen. Every time when a constraint is modified a new regeneration is triggered and the functions GenerateCurves() and TrimExtendCurves() are called again.We also can edit constraints for this rebar. When user starts to do this, the function will be called and it is supposed to return positions of handles defined in GetCustomHandles(). This positions will be shown on screen. While editing constraints if the mouse is over a position that was specified, the function will be called in order to obtain the name of that handle.While editing constraints an user will modify constraints (e.g. add a new reference or remove one) a regeneration will be triggered and the functions GenerateCurves() and TrimExtendCurves() will be called again.
Implements: IExternalServer

  METHODS:
    bool GenerateCurves(RebarCurvesData curvesData)
      Description: This function is supposed to calculate the bars in set based on data received in curvesData parameter.
      @curvesData: Use the members of this class to access the inputs and define the output curves that make up the free form rebar.
      Returns: Returns true if the curve generation was successful, false otherwise.
    bool GetCustomHandleName(RebarHandleNameData handleNameData)
      Description: This function should return the name of the handle.
      @handleNameData: The class used to output the rebarHandle name.
      Returns: Returns true if the handle name is defined successfully, false otherwise.
    bool GetCustomHandles(RebarHandlesData handlesInfoData)
      Description: This function should define all handles that the Rebar has. This function is called when the Rebar is created.
      @handlesInfoData: Use the methods on this class to define the handles for the free form rebar. Revit will use these handles to create appropriate RebarConstraints.
      Returns: Returns true if the handles were defined successfully, false otherwise.
    bool GetHandlesPosition(RebarHandlePositionData handlePositionData)
      Description: This function is supposed to provide the positions of handles defined in GetCustomHandles(). These positions will be shown on screen when the bar constraints are edited. If a position for a handle isn't provided, that handle will not be represented on screen while edit constraints.This function is called when edit constraints command is lunched or during edit constraints after a constraint was changed and the curve calculation was done.
      @handlePositionData: Use the members of this class to access the inputs and define the handle positions for this free form rebar.
      Returns: Returns true if calculation of handle positions was successful, false otherwise.
    bool TrimExtendCurves(RebarTrimExtendData trimExtendData)
      Description: This function is supposed to trim or extend curves that were obtained from calling GenerateCurves(). Also in this function can be set new constraints for start and end handles.
      @trimExtendData: Use the members of this class to access the inputs and define any trim/extend actions to be taken for bars in the free form rebar.
      Returns: Returns true if the trim/extend was successful, false otherwise.

--------------------------------------------------------------------------------

[INTERFACE] IStructuralSectionsServer
Full Name: Autodesk.Revit.DB.Structure.IStructuralSectionsServer

Description: Interface for the section type parameter server to implement.
Implements: IExternalServer

  METHODS:
    bool StructuralSectionsUpdate(StructuralSectionsServiceData data)
      Description: The server's method that will be called when Revit User clicks the Section Type parameter's button in the family dialog.
      @data: The Section Type data.
      Returns: Indicates whether the section type parameter server is executed successfully.

--------------------------------------------------------------------------------

[CLASS] LineLoad
Full Name: Autodesk.Revit.DB.Structure.LineLoad

Description: An object that represents a force/moment applied in a linear manner.
Remarks: The load/moment may be uniform or it may vary between the two ends of the line.
Inherits: LoadBase
Implements: IDisposable

  PROPERTIES:
    XYZ EndPoint { get; }
      Description: Returns the three dimensional location of the end point for the line load.
    XYZ ForceVector1 { get; set; }
      Description: The force vector applied to the start point of the line load, oriented according to OrientTo setting.
    XYZ ForceVector2 { get; set; }
      Description: The force vector applied to the end point of the line load, oriented according to OrientTo setting.
    bool IsProjected { get; set; }
      Description: Indicates if the load is projected.
    bool IsUniform { get; }
      Description: Indicates if the load is uniform.
    XYZ MomentVector1 { get; set; }
      Description: The moment vector applied to the start point of the line load, oriented according to OrientTo setting.
    XYZ MomentVector2 { get; set; }
      Description: The moment vector applied to the end point of the line load, oriented according to OrientTo setting.
    XYZ StartPoint { get; }
      Description: Returns the three dimensional location of the start point for the line load.

  METHODS:
    static LineLoad Create(Document document, ElementId hostElemId, Curve curve, XYZ forceVector1, XYZ momentVector1, LineLoadType symbol)
      Description: Creates a new custom line load within the project.
      @document: Document to which new line load will be added.
      @hostElemId: The analytical host element for the line Load.
      @curve: Curve of the line load.
      @forceVector1: The applied 3d force vector.
      @momentVector1: The applied 3d moment vector.
      @symbol: The symbol of the LineLoad. Set to use default type.
      Returns: If successful, returns the newly created LineLoad, otherwise.
    static LineLoad Create(Document document, ElementId hostElemId, int curveIndex, XYZ forceVector1, XYZ momentVector1, LineLoadType symbol)
      Description: Creates a new hosted line load within the project.
      @document: Document to which new line load will be added.
      @hostElemId: The analytical host element for the line Load.
      @curveIndex: The index of a curve in analytical surface element starting from 0. Use method to obtain appropriate curve index. Curve index has a unique value in analytical element. The index should be obtain by iteration through all curves in all loops.
      @forceVector1: The applied 3d force vector.
      @momentVector1: The applied 3d moment vector.
      @symbol: The symbol of the LineLoad. Set to use default type.
      Returns: If successful, returns the newly created LineLoad, otherwise.
    static LineLoad Create(Document document, ElementId hostElemId, XYZ forceVector1, XYZ momentVector1, LineLoadType symbol)
      Description: Creates a new hosted line load within the project.
      @document: Document to which new line load will be added.
      @hostElemId: The analytical host element for the line Load.
      @forceVector1: The applied 3d force vector.
      @momentVector1: The applied 3d moment vector.
      @symbol: The symbol of the LineLoad. Set to use default type.
      Returns: If successful, returns the newly created LineLoad, otherwise.
    Curve GetCurve()
      Description: Returns curve that define geometry of the line load.
    static bool IsCurveInsideHostBoundaries(Document doc, ElementId hostId, Curve curve)
      Description: Indicates if the curve is inside panel's boundaries or on panel's edges or if the curve is on the member's curve.
      @doc: The document containing both the host and the line load.
      @hostId: The id of the analytical element that is about to host a line load.
      @curve: Curve to be checked.
      Returns: True if a line load can be placed on the input host id
    static bool IsValidHostId(Document pDoc, ElementId hostId)
      Description: Indicates if the provided host id can host line loads The document containing both the host and the load The id of the analytical element that is about to host a line load True if a line load can be placed on the input host id
    void SetCurve(Curve curve)
      Description: Sets the curve for the line load.
    bool SetPoints(XYZ startPoint, XYZ endPoint)
      Description: Sets start and end point of the line load.
      @startPoint: The start point.
      @endPoint: The end point.
      Returns: Returns true if successful, false otherwise.

--------------------------------------------------------------------------------

[CLASS] LineLoadType
Full Name: Autodesk.Revit.DB.Structure.LineLoadType

Description: LineLoadType class
Inherits: LoadTypeBase
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] LoadBase
Full Name: Autodesk.Revit.DB.Structure.LoadBase

Description: The LoadBase object is the base class for all load objects within the Autodesk Revit API. Data members
Remarks: Load objects are only available in Autodesk Revit Structure. This object contains methods that are common to all other load objects.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId HostElementId { get; }
      Description: The host element ID for the load.
    bool IsConstrainedOnHost { get; }
      Description: The load is constrained to host or not.
    bool IsHosted { get; }
      Description: Indicates if the Load is hosted or non-hosted.
    bool IsReaction { get; set; }
      Description: The load is reaction option.
    LoadCase LoadCase { get; }
      Description: The load case for the load.
    ElementId LoadCaseId { get; set; }
      Description: The load case ID for the load.
    string LoadCaseName { get; }
      Description: The name of the load case to which this load belongs.
    string LoadCategoryName { get; }
      Description: The name of the category to which this load belongs.
    string LoadNatureName { get; }
      Description: A string representing the nature of the load.
    LoadOrientTo OrientTo { get; set; }
      Description: The load orientation option.
    ElementId WorkPlaneId { get; }
      Description: Id of the work plane which may determine the orientation of the load.

  METHODS:
    bool IsOrientToPermitted(LoadOrientTo orientTo)
      Description: Indicates if the provided orientation is permitted for this load.
      @orientTo: Load orientation to check.
      Returns: True if provided orientation type is permitted for this load, false if not.
    void RemoveHostConstraint()
      Description: Removes constraint from host for this load.

--------------------------------------------------------------------------------

[CLASS] LoadCase
Full Name: Autodesk.Revit.DB.Structure.LoadCase

Description: An object that represents a load usage.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId NatureId { get; set; }
      Description: The nature ID of the load case.
    int Number { get; set; }
      Description: Returns unique load case number.
    ElementId SubcategoryId { get; set; }
      Description: Build-in or user defined subcategory of Structural Load Cases () category.

  METHODS:
    static LoadCase Create(Document document, string name, ElementId natureId, ElementId subcategoryId)
      Description: Creates a new LoadCase.
      @document: The Document to which new load case element will be added.
      @name: The name of the load case.
      @natureId: The load nature ID.
      @subcategoryId: The load case subcategory ID. Could be one of predefined or user defined load case category. Built-in structural Load Cases () subcategories are:
      Returns: The newly created load case element if successful, otherwise.
    static LoadCase Create(Document document, string name, ElementId natureId, LoadCaseCategory loadCaseCategory)
      Description: Creates a new LoadCase.
      @document: The Document to which new load case element will be added.
      @name: The name of the load case.
      @natureId: The load nature ID.
      @loadCaseCategory: The predefined load case category.
      Returns: The newly created load case element if successful, otherwise.
    bool IsLoadCaseSubcategoryId(ElementId loadCaseSubcategoryId)
      Description: Checks whether provided element ID refer to subcategory of Structural Load Cases () category - one of built-in or user defined.
      @loadCaseSubcategoryId: The ID to check.
      Returns: True if the ID refers to load case category element, false otherwise.
    bool IsLoadNatureId(ElementId natureId)
      Description: Checks whether provided element ID refer to LoadNature element.
      @natureId: The ID to check.
      Returns: True if the ID refers to LoadNature element, false otherwise.
    static bool IsNumberUnique(Document document, int number)
      Description: Checks that a given number is unique among all load cases.
      @number: The number to check.
      Returns: True if the given number is unique among all load cases, false otherwise.

--------------------------------------------------------------------------------

[ENUM] LoadCaseCategory
Full Name: Autodesk.Revit.DB.Structure.LoadCaseCategory

Description: Specifies load case category.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Dead = 0
    - Live = 1
    - Wind = 2
    - Snow = 3
    - RoofLive = 4
    - Accidental = 5
    - Temperature = 6
    - Seismic = 7

[CLASS] LoadCombination
Full Name: Autodesk.Revit.DB.Structure.LoadCombination

Description: An object that represents a load combination.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool IsThirdPartyGenerated { get; }
      Description: Indicates if the load combination was created by API.
    LoadCombinationState State { get; set; }
      Description: The state of the load combination.
    LoadCombinationType Type { get; set; }
      Description: The type of the load combination.

  METHODS:
    static LoadCombination Create(Document document, string name, LoadCombinationType type, LoadCombinationState state)
      Description: Creates a new LoadCombination.
      @document: The Document to which new load combination element will be added.
      @name: The name of the load combination.
      @type: The type of the load combination.
      @state: The state of the load combination.
      Returns: The newly created load combination element if successful, otherwise.
    static LoadCombination Create(Document document, string name)
      Description: Creates a new default LoadCombination.
      @document: The Document to which new load combination element will be added.
      @name: The name of the load combination.
      Returns: The newly created load combination element if successful, otherwise.
    IList<ElementId> GetCaseAndCombinationIds()
      Description: Returns collection of the load combination case and combination IDs.
      Returns: A collection of the load combination case and combination IDs.
    IList<LoadComponent> GetComponents()
      Description: Returns collection of the load combination components.
      Returns: A collection of the load combination components.
    IList<ElementId> GetUsageIds()
      Description: Returns collection of the load combination usage IDs.
      Returns: A collection of the load combination usage IDs.
    void SetComponents(IList<LoadComponent> components)
      Description: Sets a collection of the load combination components.
      @components: A collection of the load combination components.
    void SetUsageIds(IList<ElementId> usageIds)
      Description: Sets a collection of the load combination usage IDs.
      @usageIds: A collection of the load combination usage IDs.

--------------------------------------------------------------------------------

[ENUM] LoadCombinationState
Full Name: Autodesk.Revit.DB.Structure.LoadCombinationState

Description: Specifies load combination state.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Serviceability = 0
    - Ultimate = 1

[ENUM] LoadCombinationType
Full Name: Autodesk.Revit.DB.Structure.LoadCombinationType

Description: Specifies load combination type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Combination = 0
    - Envelope = 1

[CLASS] LoadComponent
Full Name: Autodesk.Revit.DB.Structure.LoadComponent

Description: An object that represents a load combination component.
Implements: IDisposable

  CONSTRUCTORS:
    new LoadComponent(ElementId loadCaseOrCombinationId, double factor)

  PROPERTIES:
    double Factor { get; set; }
      Description: Load component factor.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId LoadCaseOrCombinationId { get; set; }
      Description: Load case or combination id.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] LoadNature
Full Name: Autodesk.Revit.DB.Structure.LoadNature

Description: An object that represents a load nature.
Inherits: Element
Implements: IDisposable

  METHODS:
    static LoadNature Create(Document document, string name)
      Description: Creates a new LoadNature.
      @document: The Document to which new load nature element will be added.
      @name: The name of the load nature.
      Returns: The newly created load nature element if successful, otherwise.

--------------------------------------------------------------------------------

[ENUM] LoadOrientTo
Full Name: Autodesk.Revit.DB.Structure.LoadOrientTo

Description: Specifies load orientation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Project = 0
    - WorkPlane = 1
    - HostLocalCoordinateSystem = 2

[ENUM] LoadType
Full Name: Autodesk.Revit.DB.Structure.LoadType

Description: This enum declares types of Loads.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Point = 0
    - Line = 1
    - Area = 2

[CLASS] LoadTypeBase
Full Name: Autodesk.Revit.DB.Structure.LoadTypeBase

Description: The base class for LoadTypes
Inherits: ElementType
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] LoadUsage
Full Name: Autodesk.Revit.DB.Structure.LoadUsage

Description: An object that represents a load usage.
Inherits: Element
Implements: IDisposable

  METHODS:
    static LoadUsage Create(Document document, string name)
      Description: Creates a new LoadUsage.
      @document: The Document to which new load usage element will be added.
      @name: The name of the load usage.
      Returns: The newly created load usage element if successful, otherwise.

--------------------------------------------------------------------------------

[CLASS] MemberForces
Full Name: Autodesk.Revit.DB.Structure.MemberForces

Description: An object that represents a member forces on analytical element.
Implements: IDisposable

  CONSTRUCTORS:
    new MemberForces(bool start, XYZ force, XYZ moment)

  PROPERTIES:
    XYZ Force { get; set; }
      Description: The translational forces at relative point position of the element.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Moment { get; set; }
      Description: The rotational forces at relative point position of the element.
    bool Start { get; set; }
      Description: Member Forces position on analytical element. True for start, false for end.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] MemberForcesServiceData
Full Name: Autodesk.Revit.DB.Structure.MemberForcesServiceData

Description: The data needed by member forces server to perform type definition.
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The current document.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<ElementId> GetCurrentElements()
      Description: Returns the list of Ids of the current elements.
      Returns: Ids of the current elements. Contains the family base element to which the Member Forces parameters belongs.

--------------------------------------------------------------------------------

[ENUM] MultiplanarOption
Full Name: Autodesk.Revit.DB.Structure.MultiplanarOption

Description: Input argument type for Rebar.GetCenterlineCurves method. Controls whether all curves of a multi-planar Rebar element are returned by GetCenterlineCurves, or only the curves in the primary plane.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - IncludeAllMultiplanarCurves = 0
    - IncludeOnlyPlanarCurves = 1

[CLASS] PathReinforcement
Full Name: Autodesk.Revit.DB.Structure.PathReinforcement

Description: An object that represents an Path Reinforcement within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double AdditionalOffset { get; set; }
      Description: Additional offset of rebars in the Path Reinforcement.
    ReinforcementBarOrientation AlternatingBarOrientation { get; set; }
      Description: Orientation of alternating bars of Path Reinforcement.
    ElementId AlternatingBarShapeId { get; set; }
      Description: The RebarShape element that defines the shape of the alternating bars of the Path Reinforcement.
    PathReinforcementType PathReinforcementType { get; }
      Description: Retrieves the type of the Path Reinforcement.
    ReinforcementBarOrientation PrimaryBarOrientation { get; set; }
      Description: Orientation of primary bars of Path Reinforcement.
    ElementId PrimaryBarShapeId { get; set; }
      Description: The RebarShape element that defines the shape of the primary bars of the Path Reinforcement.

  METHODS:
    static IList<ElementId> ConvertRebarInSystemToRebars(Document doc, PathReinforcement system)
      Description: Converts all RebarInSystem elements owned by the input PathReinforcement to equivalent Rebar elements.
      @doc: The document.
      @system: A PathReinforcement element in the document.
      Returns: The ids of the newly created Rebar elements.
    static PathReinforcement Create(Document document, Element hostElement, IList<Curve> curveArray, bool flip, ElementId pathReinforcementTypeId, ElementId rebarBarTypeId, ElementId startRebarHookTypeId, ElementId endRebarHookTypeId, ElementId rebarShapeId)
      Description: Creates a new PathReinforcement object from an array of curves and given Rebar Shape id.
      @document: The document.
      @hostElement: The element that will host the PathReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @curveArray: An array of curves that will define the outline of the PathReinforcement.
      @flip: A flag controlling the bars relative to the curves.
      @pathReinforcementTypeId: The id of the PathReinforcementType.
      @rebarBarTypeId: The id of the RebarBarType.
      @startRebarHookTypeId: The id of the RebarHookType for the start of the bar. If this parameter is InvalidElementId, it means to create a rebar with no start hook.
      @endRebarHookTypeId: The id of the RebarHookType for the end of the bar. If this parameter is InvalidElementId, it means to create a rebar with no end hook.
      @rebarShapeId: The id of the RebarShape element that defines the shape of the rebars in the object.
      Returns: The newly created PathReinforcement.
    static PathReinforcement Create(Document document, Element hostElement, IList<Curve> curveArray, bool flip, ElementId pathReinforcementTypeId, ElementId rebarBarTypeId, ElementId startRebarHookTypeId, ElementId endRebarHookTypeId)
      Description: Creates a new PathReinforcement object from an array of curves. The newly created object will use a default Rebar Shape.
      @document: The document.
      @hostElement: The element that will host the PathReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @curveArray: An array of curves that will define the outline of the PathReinforcement.
      @flip: A flag controlling the bars relative to the curves.
      @pathReinforcementTypeId: The id of the PathReinforcementType.
      @rebarBarTypeId: The id of the RebarBarType.
      @startRebarHookTypeId: The id of the RebarHookType for the start of the bar. If this parameter is InvalidElementId, it means to create a rebar with no start hook.
      @endRebarHookTypeId: The id of the RebarHookType for the end of the bar. If this parameter is InvalidElementId, it means to create a rebar with no end hook.
      Returns: The newly created PathReinforcement.
    IList<ElementId> GetCurveElementIds()
      Description: Retrieves the set of ElementIds of curves forming the boundary of the Path Reinforcement.
      Returns: A collection of ElementIds of ModelCurve elements.
    ElementId GetHostId()
      Description: The element that contains the Path Reinforcement.
      Returns: The element that the Path Reinforcement object belongs to, such as a structural wall, floor or foundation.
    static ElementId GetOrCreateDefaultRebarShape(Document document, ElementId rebarBarTypeId, ElementId startRebarHookTypeId, ElementId endRebarHookTypeId)
      Description: Creates a new RebarShape object with a default name or returns existing one which fulfills Path Reinforcement bending data requirements.
      @document: The document.
      @rebarBarTypeId: The id of the RebarBarType.
      @startRebarHookTypeId: The id of the RebarHookType for the start of the bar. If this parameter is InvalidElementId, it means to create a rebar with no start hook.
      @endRebarHookTypeId: The id of the RebarHookType for the end of the bar. If this parameter is InvalidElementId, it means to create a rebar with no end hook.
      Returns: Rebar Shape id.
    IList<ElementId> GetRebarInSystemIds()
      Description: Returns the ids of the RebarInSystem elements owned by the PathReinforcement element.
    bool IsAlternatingLayerEnabled()
      Description: Checks if alternating bars are present in Path Reinforcement.
      Returns: True if the alternating bars exist in Path Reinforcement instance.
    bool IsUnobscuredInView(View view)
      Description: Checks if Path Reinforcement is shown unobscured in a view.
      @view: The view element
      Returns: True if Path Reinforcement is shown unobscured, false otherwise.
    bool IsValidAlternatingBarOrientation(ReinforcementBarOrientation orientation)
      Description: Checks if orientation for alternating bars is valid.
      @orientation: An orientation.
      Returns: True if orientation for alternating bars are valid.
    bool IsValidPrimaryBarOrientation(ReinforcementBarOrientation orientation)
      Description: Checks if orientation for primary bars is valid.
      @orientation: An orientation.
      Returns: True if orientation for primary bars are valid.
    static bool IsValidRebarShapeId(Document aDoc, ElementId elementId)
      Description: Identifies whether an element id corresponds to a Rebar Shape element which can be used in Path Reinforcement.
      @aDoc: The document.
      @elementId: An element id.
      Returns: True if the specified element id corresponds to a Rebar Shape element.
    static IList<ElementId> RemovePathReinforcementSystem(Document doc, PathReinforcement system)
      Description: Deletes the specified PathReinforcement, and converts its RebarInSystem elements to equivalent Rebar elements.
      @doc: The document.
      @system: A PathReinforcement element in the document.
      Returns: The ids of the newly created Rebar elements.
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets Path Reinforcement to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if Path Reinforcement is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[CLASS] PathReinforcementType
Full Name: Autodesk.Revit.DB.Structure.PathReinforcementType

Description: An object that specifies the type of a Structural Path Reinforcement element in Autodesk Revit.
Remarks: The clear cover settings can be accessed via this object.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static ElementId CreateDefaultPathReinforcementType(Document ADoc)
      Description: Creates a new PathReinforcementType object with a default name.
      @ADoc: The document.
      Returns: The newly created type id.

--------------------------------------------------------------------------------

[CLASS] PathReinSpanSymbol
Full Name: Autodesk.Revit.DB.Structure.PathReinSpanSymbol

Description: Represents a Path Reinforcement Span Symbol element in Autodesk Revit.
Inherits: IndependentTag
Implements: IDisposable

  METHODS:
    static PathReinSpanSymbol Create(Document document, ElementId viewId, LinkElementId hostId, XYZ point, ElementId symbolId)
      Description: Creates a new instance of PathReinSpanSymbol in the project.
      @document: The document.
      @viewId: The id of the view in which the symbol should appear.
      @hostId: The ElementId of PathReinforcement (either in the document, or linked from another document).
      @point: The span symbol's head position.
      @symbolId: The family symbol id of this element.
      Returns: A reference to newly created span symbol.

--------------------------------------------------------------------------------

[CLASS] PointLoad
Full Name: Autodesk.Revit.DB.Structure.PointLoad

Description: An object that represents a force/moment applied to a single point. Data members
Inherits: LoadBase
Implements: IDisposable

  PROPERTIES:
    XYZ ForceVector { get; set; }
      Description: The force vector applied to the point load, oriented according to OrientTo setting.
    XYZ MomentVector { get; set; }
      Description: The moment vector applied to the point load, oriented according to OrientTo setting.
    XYZ Point { get; set; }
      Description: Returns the position of point load, measured in decimal feet.

  METHODS:
    static PointLoad Create(Document document, ElementId hostElemId, XYZ point, XYZ forceVector, XYZ momentVector, PointLoadType symbol)
      Description: Creates a new custom hosted point load within the project using data at point.
      @document: Document to which new point load will be added.
      @hostElemId: The AnalyticalElement host element for the point Load.
      @point: The position of point load, measured in decimal feet.
      @forceVector: The applied 3d force vector.
      @momentVector: The applied 3d moment vector.
      @symbol: The symbol of the PointLoad. Set to use default type.
      Returns: If successful, returns the newly created PointLoad, otherwise.
    static PointLoad Create(Document document, ElementId hostElemId, AnalyticalElementSelector selector, XYZ forceVector, XYZ momentVector, PointLoadType symbol)
      Description: Creates a new hosted point load within the project.
      @document: Document to which new point load will be added.
      @hostElemId: The AnalyticalMember host element for the point Load.
      @selector: The start or end point of the Analytical Member element.
      @forceVector: The applied 3d force vector.
      @momentVector: The applied 3d moment vector.
      @symbol: The symbol of the PointLoad. Set to use default type.
      Returns: If successful, returns the newly created PointLoad, otherwise.
    static bool IsPointInsideHostBoundaries(Document pDoc, ElementId hostId, XYZ point)
      Description: Indicates if the point is inside panel's boundaries or if the point is on the member's curve..
      @pDoc: The document containing both the host and the load.
      @hostId: The id of the analytical element that is about to host a point load.
      @point: The position of point load, measured in decimal feet.
      Returns: True if a point load can be placed on the input host id
    static bool IsValidHostId(Document pDoc, ElementId hostId)
      Description: Indicates if the provided host id can host point loads The document containing both the host and the load The id of the analytical element that is about to host a point load True if a point load can be placed on the input host id

--------------------------------------------------------------------------------

[CLASS] PointLoadType
Full Name: Autodesk.Revit.DB.Structure.PointLoadType

Description: PointLoadType class
Inherits: LoadTypeBase
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] Rebar
Full Name: Autodesk.Revit.DB.Structure.Rebar

Description: Represents a rebar element in Autodesk Revit.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool CanHaveVaryingLengthBars { get; }
      Description: Identifies if a set can have varying length bars or not.
    DistributionType DistributionType { get; set; }
      Description: The type of rebar distribution(also known as Rebar Set Type).
    bool HasVariableLengthBars { get; }
      Description: Identifies if a set has varying length bars or not.
    bool IncludeFirstBar { get; set; }
      Description: Identifies if the first bar in rebar set is shown.
    bool IncludeLastBar { get; set; }
      Description: Identifies if the last bar in rebar set is shown.
    RebarLayoutRule LayoutRule { get; }
      Description: Identifies the layout rule of rebar set.
    double MaxSpacing { get; set; }
      Description: Identifies the maximum spacing between rebar in rebar set.
    int NumberOfBarPositions { get; set; }
      Description: The number of potential bars in the set.
    int Quantity { get; }
      Description: Identifies the number of bars in rebar set.
    bool ReadOnlyParameters { get; set; }
      Description: When set to true, Rebar will report all its parameters as read only. For example, the method Parameter::IsReadOnly() for all Rebar Parameters will return true. When set to false, the return value of Parameter::IsReadOnly() will not be affected.
    string ScheduleMark { get; set; }
      Description: The Schedule Mark parameter. On creation, the Schedule Mark is set to a value that is unique to the host, but it can be set to any value.
    double TotalLength { get; }
      Description: The length of an individual bar multiplied by Quantity.
    double Volume { get; }
      Description: The volume of an individual bar multiplied by Quantity.

  METHODS:
    bool CanApplyPresentationMode(View dBView)
      Description: Checks if a presentation mode can be applied for this rebar in the given view.
      @dBView: The view in which presentation mode will be applied.
      Returns: True if presentation mode can be applied for this view, false otherwise.
    bool CanBeMatchedWithMultipleShapes()
      Description: Checks if this Rebar can be matched with multiple Rebar Shapes.
      Returns: Returns true if this Rebar can be matched with multiple Rebar Shapes, false otherwise.
    bool CanSuppressFirstOrLastBar(View dBView, int end)
      Description: Checks if the first or last bar in rebar set can be hidden in the given view.
      @dBView: The view in which presentation mode will be applied.
      @end: 0 for the first bar in rebar set, 1 for the last bar.
      Returns: True the first or last bar in rebar set can be hidden for this view, false otherwise.
    bool CanUseHookType(ElementId proposedHookId)
      Description: Checks if the specified RebarHookType id is of a valid RebarHookType for the Rebar's RebarBarType
      @proposedHookId: The Id of the RebarHookType
      Returns: Returns true if the id is of a valid RebarHookType for the Rebar element.
    void ClearPresentationMode(View dBView)
      Description: Sets the presentation mode for this rebar set to the default (either for a single view, or for all views).
      @dBView: The view where the presentation mode will be cleared. NULL for all views
    bool ConstraintsCanBeEdited()
      Description: For ShapeDriven Rebar: returns true, if the Rebar element's external constraints are available for editing using the RebarConstraintsManager class. It will return false if Rebar is in GroupFor FreeForm rebar: constraints can be edited if there is a valid external server Guid assigned to that Rebar
    static bool ContainsValidArcRadiiForStyleAndBarType(IList<Curve> curves, RebarStyle style, RebarBarType barType)
      Description: Checks that all arcs in the chain of curves have radii that are not less than minimum bend radius for bar type and style
      @curves: An array of curves intended to define the shape of the rebar curves. Bends and hooks should not be included in the array of curves.
      @style: The usage of the bar, "standard" or "stirrup/tie".
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      Returns: Returns true if all arc bend radii are not less than minimum bend radius for bar type and style
    static Rebar CreateFreeForm(Document doc, RebarBarType barType, Element host, IList<CurveLoop> curves, out RebarFreeFormValidationResult error)
    static Rebar CreateFreeForm(Document doc, RebarBarType barType, Element host, IList<IList<Curve>> curves, out RebarFreeFormValidationResult error)
    static Rebar CreateFreeForm(Document doc, Guid serverGUID, RebarBarType barType, Element host)
      Description: Creates a free form rebar that can have constraints.
      @doc: A Document.
      @serverGUID: The API server GUID. Should be the same that the function GetServerId() from class derived from returns. This server has the responsibility to calculate the bars of Rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @host: The element to which the rebar belongs. The element must support rebar hosting.
      Returns: The newly created free form Rebar Instance.
    static Rebar CreateFromCurves(Document doc, RebarStyle style, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, Element host, XYZ norm, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, double hookRotationAngleAtStart, double hookRotationAngleAtEnd, ElementId endTreatmentTypeIdAtStart, ElementId endTreatmentTypeIdAtEnd, bool useExistingShapeIfPossible, bool createNewShape)
      Description: Creates a new instance of a shape driven Rebar element within the project.
      @doc: A document.
      @style: The usage of the bar, "standard" or "stirrup/tie".
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @host: The element to which the rebar belongs. The element must support rebar hosting; .
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @hookRotationAngleAtStart: The out of plane hook rotation angle at the start of the bar.
      @hookRotationAngleAtEnd: The out of plane hook rotation angle at the end of the bar.
      @endTreatmentTypeIdAtStart: The end treatment type id at the start of the bar.
      @endTreatmentTypeIdAtEnd: The end treatment type id at the end of the bar.
      @useExistingShapeIfPossible: Attempts to assign a RebarShape from those existing in the document. If no shape matches, this function returns if createNewShape is false or it will create a new shape if createNewShape is true. When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true". If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks, then this method will perform a second search, ignoring hook information.
      @createNewShape: Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance. Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes have enough shape parameters to define a shape for these curves.
      Returns: The newly created Rebar instance, or if the operation fails.
    static Rebar CreateFromCurves(Document doc, RebarStyle style, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, Element host, XYZ norm, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, bool useExistingShapeIfPossible, bool createNewShape)
      Description: Creates a new instance of a shape driven Rebar element within the project.
      @doc: A document.
      @style: The usage of the bar, "standard" or "stirrup/tie".
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @host: The element to which the rebar belongs. The element must support rebar hosting; .
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @useExistingShapeIfPossible: Attempts to assign a RebarShape from those existing in the document. If no shape matches, this function returns null if createNewShape is false or it will create a new shape if createNewShape is true. When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true". If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks, then this method will perform a second search, ignoring hook information.
      @createNewShape: Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance. Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes have enough shape parameters to define a shape for these curves.
      Returns: The newly created Rebar instance, or if the operation fails.
    static Rebar CreateFromCurvesAndShape(Document doc, RebarShape rebarShape, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, Element host, XYZ norm, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, double hookRotationAngleAtStart, double hookRotationAngleAtEnd, ElementId endTreatmentTypeIdAtStart, ElementId endTreatmentTypeIdAtEnd)
      Description: Creates a new instance of a shape driven Rebar element within the project. The instance will have the default shape parameters from the RebarShape. If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to true, then curves, hook types and hook rotation angles should match the rebar shape definition. Otherwise, the hooks can be different than the defaults specified in the RebarShape. If the RebarShapeDefinesEndTreatment flag in ReinforcementSettings has been set to true, then curves and end treatment types should match the rebar shape definition. Otherwise, the end treatment types can be different than the defaults specified in the RebarShape.
      @doc: A document.
      @rebarShape: A RebarShape element that defines the shape of the rebar. A RebarShape element that matches curves, hooks, hook rotation angles and End Treatment. A RebarShape element that provides the RebarStyle of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @host: The element to which the rebar belongs. The element must support rebar hosting; .
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @hookRotationAngleAtStart: The out of plane hook rotation angle at the start of the bar.
      @hookRotationAngleAtEnd: The out of plane hook rotation angle at the end of the bar.
      @endTreatmentTypeIdAtStart: The end treatment type id at the start of the bar.
      @endTreatmentTypeIdAtEnd: The end treatment type id at the end of the bar.
      Returns: The newly created Rebar instance, or if the operation fails.
    static Rebar CreateFromCurvesAndShape(Document doc, RebarShape rebarShape, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, Element host, XYZ norm, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient)
      Description: Creates a new instance of a shape driven Rebar element within the project. The instance will have the default shape parameters from the RebarShape. If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to true, then both the curves and hooks must match the RebarShape definition. Otherwise, the hooks can be different than the defaults specified in the RebarShape
      @doc: A document.
      @rebarShape: A RebarShape element that defines the shape of the rebar. A RebarShape element matches curves and hooks. A RebarShape element provides RebarStyle of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @host: The element to which the rebar belongs. The element must support rebar hosting; .
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      Returns: The newly created Rebar instance, or if the operation fails.
    static Rebar CreateFromRebarShape(Document doc, RebarShape rebarShape, RebarBarType barType, Element host, XYZ origin, XYZ xVec, XYZ yVec)
      Description: Creates a new shape driven Rebar, as an instance of a RebarShape. The instance will have the default shape parameters from the RebarShape, and its location is based on the bounding box of the shape in the shape definition. Hooks are removed from the shape before computing its bounding box. If appropriate hooks can be found in the document, they will be assigned arbitrarily.
      @doc: A document.
      @rebarShape: A RebarShape element that defines the shape of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @host: The element to which the rebar belongs. The element must support rebar hosting; .
      @origin: The lower-left corner of the shape's bounding box will be placed at this point in the project.
      @xVec: The x-axis in the shape definition will be mapped to this direction in the project.
      @yVec: The y-axis in the shape definition will be mapped to this direction in the project.
      Returns: The newly created Rebar instance, or if the operation fails.
    bool DoesBarExistAtPosition(int barPosition)
      Description: Checks whether a bar is included at the specified position.
      @barPosition: A bar position index between 0 and NumberOfBarPositions-1.
      Returns: Returns true if the bar at the specified position is included, false otherwise.
    void EnableHookLengthOverride(bool enable)
      Description: Enables or disables the ability to override hook lengths for this rebar instance.
      @enable: True to enable, False to disable.
    RebarPresentationMode FindMatchingPredefinedPresentationMode(View dBView)
      Description: Determines if there is a matching RebarPresentationMode for the current set of selected hidden and unhidden bars assigned to the given view.
      @dBView: The view.
      Returns: The presentation mode that matches the current set of selected hidden and unhidden bars. If there is no better match, this returns RebarPresentationMode.Select.
    IList<ElementId> GetAllRebarShapeIds()
      Description: Gets the ids of the RebarShapes elements that defines the shapes of the rebar.
      Returns: Returns the ids of the RebarShapes elements that defines the shapes of the rebar.
    int GetBarIndexFromReference(Reference barReference)
      Description: Given a reference that represents a part of a bar, this method will return the bar index.
      @barReference: The Reference of the Rebar element.
      Returns: The bar index the reference refers to.
    RebarBendData GetBendData()
      Description: Gets the RebarBendData, containing bar and hook information, of the instance.
    IList<Curve> GetCenterlineCurves(bool adjustForSelfIntersection, bool suppressHooks, bool suppressBendRadius, MultiplanarOption multiplanarOption, int barPositionIndex)
      Description: A chain of curves representing the centerline of the rebar.
      @adjustForSelfIntersection: If the curves overlap, as in a planar stirrup, this parameter controls whether they should be adjusted to avoid intersection (as in fine views), or kept in a single plane for simplicity (as in coarse views).
      @suppressHooks: Identifies if the chain will include hooks curves.
      @suppressBendRadius: Identifies if the connected chain will include unfilleted curves.
      @multiplanarOption: If the Rebar is a multi-planar shape, this parameter controls whether to generate only the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves, (IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as multi-planar copies of the primary plane curves. This argument is ignored for planar shapes.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1). Use the barPositionIndex to obtain all the curves at a specific index in the distribution. You can use GetNumberOfBarPositions() to verify if a specific rebar has more than one bar positions. This is useful for rebar sets that have varying length bars. In this case you can retrieve the centerline curve geometry of that particular bar, by passing the appropriate index If the rebar set don't have varying bars, the form of the bars does not vary from one index to another.
      Returns: The centerline curves or empty array if the curves cannot be computed because the parameters values are inconsistent with the constraints of the RebarShape definition.
    ElementId GetCouplerId(int end)
      Description: Get the id of the Rebar Coupler that is applied to the rebar at the specified end.
      @end: 0 for the start Rebar Coupler, 1 for the end Rebar Coupler.
      Returns: The id of a Rebar Coupler, or invalidElementId if the rebar has no Rebar Coupler at the specified end.
    ElementId GetEndTreatmentTypeId(int end)
      Description: Get the id of the EndTreatmentType to be applied to the rebar.
      @end: 0 for the start end treatment, 1 for the end end treatment.
      Returns: The id of a EndTreatmentType, or invalidElementId if the rebar has no end treatment at the specified end.
    RebarFreeFormAccessor GetFreeFormAccessor()
      Description: Returns an interface providing access to free-form properties and methods for this Rebar element.
      Returns: The interface providing access to free-form properties and methods for this Rebar element.
    GeometryElement GetFullGeometryForView(View view)
      Description: Generates full geometry for the Rebar for a specific view.
      @view: The view in which the geometry is generated.
      Returns: The generated geometry of the Rebar before cutting is applied.
    RebarHookOrientation GetHookOrientation(int iEnd)
      Description: Returns the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.
      @iEnd: 0 for the start hook, 1 for the end hook.
      Returns: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
    double GetHookRotationAngle(int iEnd)
      Description: Gets the out of plane hook rotation angle at the specified end.
      @iEnd: 0 for the start , 1 for the end.
      Returns: Returns the out of plane hook rotation angle at the specified end.
    ElementId GetHookTypeId(int end)
      Description: Get the id of the RebarHookType to be applied to the rebar.
      @end: 0 for the start hook, 1 for the end hook.
      Returns: The id of a RebarHookType, or invalidElementId if the rebar has no hook at the specified end.
    ElementId GetHostId()
      Description: The element that contains the rebar.
      Returns: The element that the rebar object belongs to, such as a structural wall, floor, foundation, beam, brace or column.
    double GetLapLength(int barEnd)
      Description: Gets the lap length that is used for the specified end - 0 for start, 1 for end.
      @barEnd: The end where the splice is - 0 for start, 1 for end.
      Returns: Returns the lap length that is used for the specified end - 0 for start, 1 for end.
    Transform GetMovedBarTransform(int barPositionIndex)
      Description: Returns a transform representing the movement of the bar relative to its default position along the distribution path.
      @barPositionIndex: The bar index.
      Returns: The transform representing the movement of the bar relative to its default position along the distribution path.
    void GetOverridableHookParameters(out ISet<ElementId> startHookLengthPrameters, out ISet<ElementId> startHookTangentLengthParameters, out ISet<ElementId> endHookLengthParameters, out ISet<ElementId> endHookTangentLengthParameters)
    ParameterValue GetParameterValueAtIndex(ElementId paramId, int barPositionIndex)
      Description: Get the parameter value for a bar at the specified index.
      @paramId: The parameter Id.
      @barPositionIndex: The bar index in the rebar distribution. Accepts only values between 0 and NumberOfBarPositions-1.
      Returns: The ParameterValue for given parameterId and barPositionIndex.
    RebarPresentationMode GetPresentationMode(View dBView)
      Description: Gets the presentation mode for this rebar set when displayed in the given view.
      @dBView: The view.
      Returns: The presentation mode.
    RebarConstraintsManager GetRebarConstraintsManager()
      Description: Returns an object for managing the external constraints on the Rebar element
    RebarSplice GetRebarSplice(int barEnd)
      Description: Gets the rebar splice at the specified bar end - 0 for start, 1 for end.
      @barEnd: The bar end for which the rebar splice is needed - 0 for start, 1 for end.
      Returns: Returns the rebar splice at the specified bar end - 0 for start, 1 for end.
    RebarRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    RebarShapeDrivenAccessor GetShapeDrivenAccessor()
      Description: Returns an interface providing access to shape-driven properties and methods for this Rebar element.
      Returns: The interface providing access to shape-driven properties and methods for this Rebar element.
    ElementId GetShapeId()
      Description: Returns the id of the RebarShape element that defines the shape of the rebar.
    double GetSpliceStaggerLength(int barEnd)
      Description: Gets the stagger length that is used for the specified end - 0 for start, 1 for end.
      @barEnd: The end where the splice is - 0 for start, 1 for end.
      Returns: Returns the stagger length that is used for the specified end - 0 for start, 1 for end.
    IList<Curve> GetTransformedCenterlineCurves(bool adjustForSelfIntersection, bool suppressHooks, bool suppressBendRadius, MultiplanarOption multiplanarOption, int barPositionIndex)
      Description: A chain of curves representing the centerline of the rebar.
      @adjustForSelfIntersection: If the curves overlap, as in a planar stirrup, this parameter controls whether they should be adjusted to avoid intersection (as in fine views), or kept in a single plane for simplicity (as in coarse views).
      @suppressHooks: Identifies if the chain will include hooks curves.
      @suppressBendRadius: Identifies if the connected chain will include unfilleted curves.
      @multiplanarOption: If the Rebar is a multi-planar shape, this parameter controls whether to generate only the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves, (IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as multi-planar copies of the primary plane curves. This argument is ignored for planar shapes.
      @barPositionIndex: The bar index.
      Returns: The centerline curves or empty array if the curves cannot be computed because the parameters values are inconsistent with the constraints of the RebarShape definition.
    bool HasPresentationOverrides(View dBView)
      Description: Identifies if this Rebar has overridden default presentation settings for the given view.
      @dBView: The view.
      Returns: True if this Rebar has overriden default presentation settings, false otherwise.
    bool HookAngleMatchesRebarShapeDefinition(int iEnd, ElementId proposedHookId)
      Description: Checks that the hook angle of the specified RebarHookType matches the hook angle used in the Rebar's RebarShape at the specified end of the bar.
      @iEnd: 0 for the start hook, 1 for the end hook.
      @proposedHookId: The Id of the RebarHookType
      Returns: Returns true if the hook angle of the RebarHookType matches the angle used in the RebarShape at the specified end of the bar.
    bool IsBarHidden(View view, int barIndex)
      Description: Identifies if a given bar in this rebar set is hidden in this view.
      @view: The view.
      @barIndex: The index of the bar from this rebar set.
      Returns: True if the bar is hidden in this view, false otherwise.
    bool IsHookLengthOverrideEnabled()
      Description: Returns True if the ability to override hook lengths is enabled for this rebar instance, False otherwise.
    bool IsRebarFreeForm()
      Description: Returns true if the rebar is free form and false if shape driven.
      Returns: Returns true if the rebar is free form and false if shape driven.
    bool IsRebarInSection(View dBView)
      Description: Identifies if this Rebar is cut by the view plane of the given view.
      @dBView: The view.
      Returns: True if this Rebar is cut by the view plane, false otherwise.
    bool IsRebarShapeDriven()
      Description: Returns true if the rebar is shape driven and false if free form.
      Returns: Returns true if the rebar is shape driven and false if free form.
    bool IsUnobscuredInView(View view)
      Description: Checks if this rebar element is shown unobscured in a view.
      @view: The view element
      Returns: True if rebar is shown unobscured, false otherwise.
    void MoveBarInSet(int barPositionIndex, Transform moveTransform)
      Description: This method applies the transformation matrix to the rebar bar at the desired position in the rebar set. If the bar was already moved, the method will concatenate the transformation matrix with the existing movement.
      @barPositionIndex: The bar index of the rebar to apply the transformation.
      @moveTransform: The transformation matrix to apply to the specified rebar bar.
    static bool RebarShapeMatchesCurvesAndHooks(RebarShape rebarShape, RebarBarType barType, XYZ norm, IList<Curve> curves, RebarHookType startHook, RebarHookType endHook, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient)
      Description: Checks if rebarShape matches curves and hooks. If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, then this method will ignore the hook information.
      @rebarShape: A RebarShape element that defines the shape of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHook: A RebarHookType element that defines the hook for the start of the bar.
      @endHook: A RebarHookType element that defines the hook for the end of the bar.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      Returns: True if rebarShape matches curves and hooks.
    static bool RebarShapeMatchesCurvesHooksAndEndTreatment(RebarShape rebarShape, RebarBarType barType, XYZ norm, IList<Curve> curves, RebarHookType startHook, RebarHookType endHook, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, double hookRotationAngleAtStart, double hookRotationAngleAtEnd, ElementId endTreatmentTypeIdAtStart, ElementId endTreatmentTypeIdAtEnd)
      Description: Checks if rebarShape matches curves, hooks and end treatment. If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, then this method will ignore the hook information. If the RebarShapeDefinesEndTreatment flag in ReinforcementSettings has been set to false, then this method will ignore the end treatment information.
      @rebarShape: A RebarShape element that defines the shape of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHook: A RebarHookType element that defines the hook for the start of the bar.
      @endHook: A RebarHookType element that defines the hook for the end of the bar.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @hookRotationAngleAtStart: The out of plane hook rotation angle at the start of the bar.
      @hookRotationAngleAtEnd: The out of plane hook rotation angle at the end of the bar.
      @endTreatmentTypeIdAtStart: The end treatment type id at the start of the bar.
      @endTreatmentTypeIdAtEnd: The end treatment type id at the end of the bar.
      Returns: True if rebarShape matches curves and hooks.
    void RemoveSplice(int barEnd)
      Description: Removes the splice relation at the specified end and all the Rebar Constraints involved in splice.
      @barEnd: The end where the splice is to be removed - 0 for start, 1 for end.
    void ResetMovedBarTransform(int barPositionIndex)
      Description: Reset the transformation representing the movement of the bar relative to its default position along the distribution path. The moved bar transform will be set to Identity.
      @barPositionIndex: The bar index.
    void SetBarHiddenStatus(View view, int barIndex, bool hide)
      Description: Sets the bar in this rebar set to be hidden or unhidden in the given view.
      @view: The view.
      @barIndex: The index of the bar from this set.
      @hide: True to hide this bar in the view, false to unhide the bar.
    void SetBarIncluded(bool include, int barPositionIndex)
      Description: Sets if the bar at the desired index is included or not.
      @include: True to include the bar, false to exclude the bar.
      @barPositionIndex: The bar index.
    void SetEndTreatmentTypeId(int end, ElementId endTreatmentTypeId)
      Description: Sets the id of the EndTreatmentType to be applied to the rebar. This can be done if and only if the end of the bar on which the end treatment is applied has no RebarCoupler on it, otherwise will throw an exception. If a RebarHookType is present at the rebar end, it will automatically set to invalidElementId.
      @end: 0 for the start end treatment, 1 for the end end treatment.
      @endTreatmentTypeId: The id of a EndTreatmentType element, or invalidElementId if the rebar should have no end treatment at the specified end.
    void SetHookOrientation(int iEnd, RebarHookOrientation hookOrientation)
      Description: Defines the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.
      @iEnd: 0 for the start hook, 1 for the end hook.
      @hookOrientation: Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
    void SetHookRotationAngle(double hookRotationAngle, int iEnd)
      Description: Sets the out of plane hook rotation angle at the specified end.
      @hookRotationAngle: The out of plane hook rotation angle at the specified end.
      @iEnd: 0 for the start , 1 for the end.
    void SetHookTypeId(int end, ElementId hookTypeId)
      Description: Set the id of the RebarHookType to be applied to the rebar. If an EndTreatmentType is present at the rebar end, it will automatically set to invalidElementId.
      @end: 0 for the start hook, 1 for the end hook.
      @hookTypeId: The id of a RebarHookType element, or invalidElementId if the rebar should have no hook at the specified end.
    void SetHostId(Document doc, ElementId hostId)
      Description: The element that contains the rebar.
      @doc: The document containing both this element and the host element.
      @hostId: The element that the rebar object belongs to, such as a structural wall, floor, foundation, beam, brace or column. The rebar does not need to be strictly inside the host, but it must be assigned to one host element.
    void SetPresentationMode(View dBView, RebarPresentationMode presentationMode)
      Description: Sets the presentation mode for this rebar set when displayed in the given view.
      @dBView: The view.
      @presentationMode: The presentation mode.
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets this rebar element to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if rebar is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[CLASS] RebarBarType
Full Name: Autodesk.Revit.DB.Structure.RebarBarType

Description: A Rebar type object that is used in the generation of Rebar
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    double BarModelDiameter { get; set; }
      Description: Defines bar model diameter of rebar
    double BarNominalDiameter { get; set; }
      Description: Defines bar nominal diameter of rebar
    RebarDeformationType DeformationType { get; set; }
      Description: Defines bar deformation type.
    double MaximumBendRadius { get; set; }
      Description: Defines maximum bend radius of rebar
    double StandardBendDiameter { get; set; }
      Description: Defines bar bend diameter for rebar whose style is standard
    double StandardHookBendDiameter { get; set; }
      Description: Defines hook bend diameter for rebar whose style is standard
    double StirrupTieBendDiameter { get; set; }
      Description: Defines bar and hook bend diameter for rebar whose style is stirrup/tie

  METHODS:
    static RebarBarType Create(Document ADoc)
      Description: Creates a new RebarBarType object
    static ElementId CreateDefaultRebarBarType(Document ADoc)
      Description: Creates a new RebarBarType object with a default name.
      @ADoc: The document.
      Returns: The newly created type id.
    bool GetAutoCalcHookLengths(ElementId hookId)
      Description: Identifies if the hook lengths of a hook type are automatically calculated for this bar type
      @hookId: id of the hook type
      Returns: True if the hook lengths are automatically calculated, otherwise false
    bool GetAutoCalculatedLapLength(ElementId rebarSpliceTypeId)
      Description: Identifies if the lap length is auto calculated for the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      Returns: Returns true if the lap length is auto calculated for the specified rebar bar type and Rebar Splice Type, false otherwise.
    bool GetAutoCalculatedStaggerLength(ElementId rebarSpliceTypeId)
      Description: Identifies if the stagger length is auto calculated for the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      Returns: Returns true if the stagger length is auto calculated for the specified rebar bar type and Rebar Splice Type, false otherwise.
    double GetHookLength(ElementId hookId)
      Description: Identifies the hook length for a hook type
      @hookId: id of the hook type
      Returns: The hook length for a hook type
    double GetHookOffsetLength(ElementId hookId)
      Description: Identifies the hook offset length for a hook type
      @hookId: id of the hook type
      Returns: The hook offset length for a hook type
    bool GetHookPermission(ElementId hookId)
      Description: Identifies if a hook type is permitted for this bar type
      @hookId: id of the hook type
      Returns: True if the hook type is permitted for this bar type, otherwise false
    double GetHookTangentLength(ElementId hookId)
      Description: Identifies the hook tangent length for a hook type
      @hookId: id of the hook type
      Returns: The hook tangent length for a hook type
    double GetLapLength(ElementId rebarSpliceTypeId)
      Description: Gets the lap length taking into account the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      Returns: Returns the lap length.
    RebarRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    double GetStaggerLength(ElementId rebarSpliceTypeId)
      Description: Gets the stagger length taking into account the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      Returns: Returns the stagger length.
    void SetAutoCalcHookLengths(ElementId hookId, bool autoCalculated)
      Description: Identifies if the hook lengths of a hook type are automatically calculated for this bar type
      @hookId: id of the hook type
      @autoCalculated: True if the hook lengths should be automatically calculated, otherwise false When it is false, default hook length and default hook offset length will be reported
    void SetAutoCalculatedLapLength(ElementId rebarSpliceTypeId, bool autoCalculated)
      Description: Sets if the lap length is auto calculated or not for the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      @autoCalculated: True, if the lap length is auto calculated, false otherwise.
    void SetAutoCalculatedStaggerLength(ElementId rebarSpliceTypeId, bool autoCalculated)
      Description: Sets if the stagger length is auto calculated or not for the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      @autoCalculated: True, if the stagger length is auto calculated, false otherwise.
    void SetBarTypeDiameters(BarTypeDiameterOptions diametersOptions)
      Description: Sets all input diameters from diametersOptions in current RebarBarType.
      @diametersOptions: The input diameters are validated as follows : barModelDiameter and barNominalDiameter are both positive and no more than the smallest value of 1.0 and the input bend diameters. Each bend diameter is smaller than 99.0 and bigger than barDiameter.
    void SetHookLength(ElementId hookId, double hookLength)
      Description: Identifies the hook length for a hook type
      @hookId: id of the hook type
      @hookLength: The hook length for a hook type
    void SetHookOffsetLength(ElementId hookId, double newLength)
      Description: Identifies the hook offset length for a hook type
      @hookId: id of the hook type
      @newLength: The hook offset length for a hook type
    void SetHookPermission(ElementId hookId, bool permission)
      Description: Identifies if a hook type is permitted for this bar type
      @hookId: id of the hook type
      @permission: True if the hook type should be permitted for this bar type, otherwise false
    void SetHookTangentLength(ElementId hookId, double newLength)
      Description: Identifies the hook tangent length for a hook type
      @hookId: id of the hook type
      @newLength: The hook tangent length for a hook type
    void SetLapLength(ElementId rebarSpliceTypeId, double lapLength)
      Description: Sets the lap length for the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      @lapLength: The new value of the lap length.
    void SetStaggerLength(ElementId rebarSpliceTypeId, double staggerLength)
      Description: Sets the stagger length for the specified Rebar Splice Type.
      @rebarSpliceTypeId: The Rebar Splice Type id. Interactions with Rebar Splice Types can be done with the functions in .
      @staggerLength: The new value of the stagger length.

--------------------------------------------------------------------------------

[CLASS] RebarBendData
Full Name: Autodesk.Revit.DB.Structure.RebarBendData

Description: The values in this class provide a summary of information taken from the RebarBarType, RebarHookType, and RebarStyle.
Remarks: The purpose of collecting the values in this class is to allow you to create and analyze an accurate representation of a RebarShape, without creating a Rebar instance, and without referring to RebarBarType, RebarHookType, and RebarStyle. If you do have a Rebar instance, its GetBendData() method will produce a RebarBendData object.
Implements: IDisposable

  CONSTRUCTORS:
    new RebarBendData(RebarBarType barType, RebarHookType hookType0, RebarHookType hookType1, RebarStyle style, RebarHookOrientation hookOrient0, RebarHookOrientation hookOrient1)
    new RebarBendData()

  PROPERTIES:
    double BarModelDiameter { get; set; }
      Description: Defines the model diameter of the bar.
    double BarNominalDiameter { get; set; }
      Description: Defines the nominal diameter of the bar.
    double BendRadius { get; set; }
      Description: The radius of all fillets, except hook fillets, in the Rebar shape.
    int HookAngle0 { get; set; }
      Description: The angle of the hook at the start.
    int HookAngle1 { get; set; }
      Description: The angle of the hook at the end.
    double HookBendRadius { get; set; }
      Description: The radius of the hook fillets in the Rebar shape.
    double HookLength0 { get; set; }
      Description: The extension length of the hook at the start.
    double HookLength1 { get; set; }
      Description: The extension length of the hook at the end.
    RebarHookOrientation HookOrient0 { get; set; }
      Description: The orientation of the hook at the start.
    RebarHookOrientation HookOrient1 { get; set; }
      Description: The orientation of the hook at the end.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] RebarBendingDetail
Full Name: Autodesk.Revit.DB.Structure.RebarBendingDetail

Description: Utility class with methods needed for the bending details in view. The bending detail element has two modes -- the schematic bending detail and realistic bending detail. Some functions are exclusive to one mode.

  METHODS:
    static void AddHosts(Element bendingDetail, IList<Reference> references)
      Description: Adds the reinforcement elements that will be represented by the input bending detail.
      @bendingDetail: The bending detail for which we want to set the host.
      @references: Reference pointing to the reinforcement element that will be represented by the input bending detail.
    static Element Create(Document document, ElementId viewId, ElementId reinforcementElementId, int reinforcementElementSubelementKey, RebarBendingDetailType bendingDetailType, XYZ position, double rotation)
      Description: Creates a new instance of a bending detail.
      @document: Document to which the new element should be added.
      @viewId: The id of the view in which the new element should be added.
      @reinforcementElementId: The reinforcement element Id that this object will represent.
      @reinforcementElementSubelementKey: The index of the sub-element from the reinforcement element that this object will represent.
      @bendingDetailType: The bending details type used with the resulting object.
      @position: The initial position in the view where this object will be created.
      @rotation: The initial rotation in the view for this element.
      Returns: Returns an instance of a bending detail.
    static Reference GetHost(Element bendingDetail)
      Description: Gets a reference to the reinforcement element that this bending detail represents.
      @bendingDetail: The bending detail for which we want to get the host.
      Returns: Returns a reference pointing to the reinforcement element represented by the input bending detail.
    static IList<Reference> GetHosts(Element bendingDetail)
      Description: Gets a reference to the reinforcement elements that this bending detail represents.
      @bendingDetail: The bending detail for which we want to get the host.
      Returns: Returns a reference pointing to the reinforcement elements represented by the input bending detail.
    static XYZ GetPosition(Element bendingDetail)
      Description: Gets the position of the bending detail relative to its view.
      @bendingDetail: The bending detail for which we want to get the position.
      Returns: Returns the position of the bending detail relative to its view.
    static double GetRotation(Element bendingDetail)
      Description: Gets the rotation angle in radians for the bending detail relative to its view.
      @bendingDetail: The bending detail for which we want to get the rotation.
      Returns: Returns the rotation angle in radians for the bending detail relative to its view.
    static XYZ GetTagRelativePosition(Element bendingDetail)
      Description: Gets the embedded tag position w.r.t. the realistic bending detail element in model coordinates.
      @bendingDetail: The bending detail element.
      Returns: The new relative position of the embedded tag w.r.t. the bending detail element.
    static double GetTagRelativeRotation(Element bendingDetail)
      Description: Gets the embedded tag rotation angle w.r.t. the realistic bending detail element.
      @bendingDetail: The bending detail element.
      Returns: The rotation angle of the embedded tag w.r.t. the bending detail element.
    static bool IsBendingDetail(Element bendingDetail)
      Description: Checks if the input element is a bending detail.
      @bendingDetail: The element that will be checked.
      Returns: Returns true if the input element is a bending detail, false otherwise.
    static bool IsRealisticBendingDetail(Element bendingDetail)
      Description: Validate that the element is a realistic bending detail.
      @bendingDetail: The element that will be checked.
    static bool IsSchematicBendingDetail(Element bendingDetail)
      Description: Validate that the element is a schematic bending detail.
      @bendingDetail: The element that will be checked.
    static void RemoveHosts(Element bendingDetail, IList<Reference> references)
      Description: Remove the reinforcement elements from those represented by the input bending detail.
      @bendingDetail: The bending detail for which we want to set the host.
      @references: References pointing to the reinforcement element that will be removed from the input bending detail.
    static void ResetAnnotationPositions(Element bendingDetail)
      Description: Resets the positions of the bending detail annotations to the default position.
      @bendingDetail: The bending detail element.
    static void ResetTagRelativePosition(Element bendingDetail)
      Description: Resets the embedded tag position w.r.t. the realistic bending detail element to the selected tag position.
      @bendingDetail: The bending detail element.
    static void SetHost(Element bendingDetail, Reference reference)
      Description: Sets the reinforcement element that will be represented by the input bending detail.
      @bendingDetail: The bending detail for which we want to set the host.
      @reference: Reference pointing to the reinforcement element that will be represented by the input bending detail.
    static void SetPosition(Element bendingDetail, XYZ position)
      Description: Sets the position for this bending detail relative to its view.
      @bendingDetail: The bending detail for which we want to get the position.
      @position: The new position for this bending detail relative to its view.
    static void SetRotation(Element bendingDetail, double rotation)
      Description: Sets the rotation angle in radians for the bending detail relative to its view.
      @bendingDetail: The bending detail for which we want to get the rotation.
      @rotation: The new rotation angle of the bending detail relative to its view.
    static void SetTagRelativePosition(Element bendingDetail, XYZ relativeOffset)
      Description: Sets the embedded tag position w.r.t. the realistic bending detail element in model coordinates.
      @bendingDetail: The bending detail element.
      @relativeOffset: The new relative position of the embedded tag w.r.t. the bending detail element.
    static void SetTagRelativeRotation(Element bendingDetail, double rotation)
      Description: Sets the embedded tag rotation angle w.r.t. the realistic bending detail element.
      @bendingDetail: The bending detail element.
      @rotation: The new rotation angle of the embedded tag w.r.t. the bending detail element.

--------------------------------------------------------------------------------

[CLASS] RebarBendingDetailType
Full Name: Autodesk.Revit.DB.Structure.RebarBendingDetailType

Description: Type for rebar bending detail elements.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    BendingDetailAngularDimensionsDisplayOptions AngularDimensionsDisplayOption { get; set; }
      Description: Identifies the angular dimensions display options.
    bool AngularDimensionsEnabled { get; set; }
      Description: Identifies if any angular dimensions will be shown or not.
    bool AngularDimensionsForHooksEnabled { get; set; }
      Description: Identifies if the angular dimensions which has a reference set on a hook will be shown or not.
    BendingDetailAngularDimensionsMeasurementOptions AngularDimensionsMeasurementOptions { get; set; }
      Description: Identifies the measurement option for angular dimensions.
    double AngularDimensionsOffset { get; set; }
      Description: Identifies the offset of the angular dimensions.
    BendingDetailDimensionTextPosition AngularDimensionTextPosition { get; set; }
      Description: Identifies the text position with respect to dimension line.
    ElementId AngularDimensionTypeId { get; set; }
      Description: Identifies the Id of the angular dimension type which is used to show dimensions.
    bool BendDiameterDimensionsEnabled { get; set; }
      Description: Identifies if any radial or diameter dimensions will be shown or not.
    bool BendDiameterDimensionsForHooksEnabled { get; set; }
      Description: Identifies if radial or diameter dimensions will be shown for hook fillets. This property has a meaning only if is set to true.
    bool BendDiameterDimensionsForSegmentsEnabled { get; set; }
      Description: Identifies if radial or diameter dimensions will be shown for the bends between segments. Radial or diameter dimesions for arc segments will be shown by default. This property has a menaning only if is set to true.
    BendingDetailBendDiameterDimensionType BendDiameterDimensionType { get; set; }
      Description: Identifies what type of bend diameter dimensions will be shown (radial or diameter).
    BendingDetailLevelOfDetail DetailLevel { get; set; }
      Description: Identifies the level of detail in which the Bending Detail will be represented.
    ElementId DiameterDimensionTypeId { get; set; }
      Description: Identifies the Id of the diameter dimension type which is used to show dimensions.
    BendingDetailDisplayMode DisplayMode { get; }
      Description: The display mode for the bending detail.
    BendingDetailTypeMultipleValuesIndicatorOptions MultipleValuesIndicatorOption { get; set; }
      Description: Identifies the option of how multiple values will be represented.
    bool OrthogonalAndOverallDimesionsEnabled { get; set; }
      Description: Identifies if orthogonal and overall dimensions are displayed.
    ElementId RadialDimensionTypeId { get; set; }
      Description: Identifies the Id of the radial dimension type which is used to show dimensions.
    BendingDetailFor3DShapesOptions RepresentaionOf3DShapes { get; set; }
      Description: Identifies how the Bending Detail will represent the 3D shapes.
    double SchematicHeight { get; set; }
      Description: Determine the height of the box where the schematic Bending Detail will be represented.
    double SchematicWidth { get; set; }
      Description: Determine the width of the box where the schematic Bending Detail will be represented.
    bool SegmentLengthDimensionsEnabled { get; set; }
      Description: Identifies if any segment length dimensions will be shown or not.
    bool SegmentLengthDimensionsForHooksEnabled { get; set; }
      Description: Identifies if segment length dimensions for hooks will be shown or not. If this property is true, the should also be true to see segment length dimensions for hooks.
    double SegmentLengthDimensionsOffset { get; set; }
      Description: Identifies the offset of the segment length dimensions.
    BendingDetailDimensionTextPosition SegmentLengthDimensionTextPosition { get; set; }
      Description: Identifies the text position with respect to dimension line.
    ElementId SegmentLengthDimensionTypeId { get; set; }
      Description: Identifies the Id of the linear dimension type which is used to show segments length.
    BendingDetailSegmentLengthsDisplayOptions SegmentLengthsDisplayOption { get; set; }
      Description: Identifies if the segment lengths are represented using dimensions or just as text.
    BendingDetailSegmentLengthsDisplayOptions SegmentLengthsForArcsDisplayOption { get; set; }
      Description: Identifies if the arc segment lengths are represented using dimensions or just as text. Only RebarShapes whose definition is RebarShapeDefinitionByArc are considered that have arc segments.
    BendingDetailSegmentsRepresentation SegmentsRepresentation { get; set; }
      Description: Identifies how the bending detail will represent the segments of the bar.
    ElementId TagTypeId { get; set; }
      Description: Identifies the Id of the tag type which is used in the Bending Detail representation.

  METHODS:
    static RebarBendingDetailType Create(Document Document)
      Description: Creates a new RebarBendingDetailType object.
      @Document: Document to which the new element should be added.
      Returns: The new RebarBendingDetailType object.
    static RebarBendingDetailType CreateRealistic(Document Document)
      Description: Creates a new RebarBendingDetailType object for full representations.
      @Document: Document to which the new element should be added.
      Returns: The new RebarBendingDetailType object.
    static RebarBendingDetailType CreateSchematic(Document Document)
      Description: Creates a new RebarBendingDetailType object for schematic representations.
      @Document: Document to which the new element should be added.
      Returns: The new RebarBendingDetailType object.

--------------------------------------------------------------------------------

[CLASS] RebarConstrainedHandle
Full Name: Autodesk.Revit.DB.Structure.RebarConstrainedHandle

Description: A class representing a handle on a Rebar that can be joined to a reference, such as a host Element's surface or cover, another Rebar's handle or to a generic surface.
Remarks: A rebar element's flexible geometry is controlled by several handles. The shape of the bar is controlled by a handle at each end of the bar and a handle each edge. Another handle is used to control the location of the plane in which the rebar lies. An additional handle controls the length of a set of rebar.RebarConstrainedHandles can only be constructed internally by Revit. They are available to the API by querying a Rebar element's RebarConstraintsManager.
Implements: IDisposable

  PROPERTIES:
    RebarHandleBehavior HandleBehavior { get; set; }
      Description: Identifies the handle behavior.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool CanSetBehavior(RebarHandleBehavior handleBehavior)
      Description: Checks if the input behavior can be set for this RebarConstrainedHandle.
      @handleBehavior: The behavior to be checked.
      Returns: Returns true if the input behavior can be set for this RebarConstrainedHandle, false otherwise.
    void Dispose()
    int GetCustomHandleTag()
      Description: Returns the tag of the handle. The type of the handle should be 'CustomHandle'.
      Returns: Returns the tag of custom handle.
    int GetEdgeNumber()
      Description: If the RebarConstrainedHandle's RebarHandleType is 'Edge', then this function will return the number of the edge that is driven by the handle.
    string GetHandleName()
      Description: Gets the name of the handle.
      Returns: Returns the name of the handle. In case of handles of CustomHandle type it can return null if the server that defined them is not registered.
    Surface GetHandleSurface()
      Description: Gets the surface of this handle.
      Returns: Returns the surface of this handle.
    RebarHandleType GetHandleType()
      Description: Returns the RebarHandleType of a RebarConstrainedHandle.
      Returns: The RebarHandleType of the specified RebarConstrainedHandle.
    IList<RebarHandleBehavior> GetPossibleHandleBehaviors()
      Description: Gets a list of possible handle behaviors for the current handle.
      Returns: Returns a list of possible handle behaviors for the current handle.
    bool IsCustomHandle()
      Description: Returns true if the RebarHandleType of the RebarConstrainedHandle is 'CustomHandle'.
    bool IsEdgeHandle()
      Description: Returns true if the RebarHandleType of the RebarConstrainedHandle is 'Edge'.
    bool IsEqual(RebarConstrainedHandle other)
      Description: Checks if the specified RebarConstrainedHandle is the same as 'this'.
      @other: RebarConstrainedHandle to compare with.
      Returns: Returns true if the specified RebarConstrainedHandle has the same type as 'this' both are for are for the same rebar. This doesn't take into account the handle behavior.
    bool IsValid()
      Description: Checks that the RebarConstrainedHandle still has access to valid Rebar handle data and that its RebarConstraintsManager is still valid.
      Returns: Returns true if the RebarConstrainedHandle still has access to valid Rebar handle data and that its RebarConstraintsManager is still valid, false otherwise.
    void Move(XYZ translataion)
      Description: Moves the handle with the specified vector. This function applies only for shape driven rebar.
      @translataion: The translation vector that will be applied.

--------------------------------------------------------------------------------

[CLASS] RebarConstraint
Full Name: Autodesk.Revit.DB.Structure.RebarConstraint

Description: A class representing a constraint on a handle of a rebar element.
Remarks: For Shape Driven Rebar Constraints:Each handle on a rebar is defined by a plane, and can be constrained along the direction perpendicular to a surface. Rebar constraints work by locking the handle planes to targets. These targets can be: surfaces of host elements (faces or cover), the handle planes of other Rebar element or any generic surface.A special case is for of a straight, standard style bar, running perpendicular to the plane of the stirrup bar. This bar can constrain itself to distinct locations along bends in stirrup bars - points located at 0 degrees, 45 degrees, 90 degrees, etc. around each bend. This is done by simultaneously locking both the straight bar's edge handle and its planar position handle to one or both of the stirrup edges adjacent to the bend in the stirrup.Usually, to form a constraint, the handle plane and the reference plane must be parallel. However, bar end or segment handles can be constrained to planes at angles up to 84 degrees. Arc-shaped rebar is a special case, and can form constraints to concentric host surfaces.For Free Form Rebar Constraints:Each handle of the Rebar can be constrained to multiple host faces or to the face cover.In order to create a Free Form Rebar Constraint you will need: RebarConstraintsManager which will manage the constraint. The rebar handle you want to constraint. A list of target references which must be element faces to which this handle is constrained. A Boolean value specifying that the constraint is to cover or directly to face. It will be the same value for all target references A double value that represent the offset distance from the rebar handle to target references. RebarConstraints for Free Form Rebar should be created using the Create method and then added to the RebarConstraintsManager using the method SetPreferredConstraintForHandle.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfTargets { get; }
      Description: Identifies the number of references associated to the rebar handle.

  METHODS:
    bool ConstrainsRebarEnds()
      Description: Returns true if this constraint constrains two rebar ends.
    static RebarConstraint Create(RebarConstrainedHandle handle, IList<Reference> targetReferences, bool isConstraintToCover, double offsetValue)
      Description: This method creates a constraint for a given RebarConstrainedHandle. Will throw exception if used for Shape Driven Rebar.
      @handle: The handle of the rebar that will be constrained.
      @targetReferences: The references to which the rebar handle will be constrained. This collection must contain one or more references to faces of elements that can host rebar.
      @isConstraintToCover: If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.
      @offsetValue: The distance from references to the rebar handle.
      Returns: Returns the newly created RebarConstraint.
    static RebarConstraint CreateConstraintToSurface(RebarConstrainedHandle handle, Surface surface)
      Description: This method creates a constraint of 'To Surface' type for a given RebarConstrainedHandle.The RebarConstrainedHandle should belong to a shape driven rebar, otherwise it will throw exception.
      @handle: The handle of the rebar that will be constrained.
      @surface: The surface that will be used by the constraint.
      Returns: Returns the newly created RebarConstraint.
    void Dispose()
    void FlipHandleOverTarget()
      Description: Flips the RebarConstrainedHandle to the other side of the target bar handle, maintaining the distance in absolute value.
    void FlipSideForClearBarSpacingZeroDistanceConstraint()
      Description: Flips the side on which a RebarConstrainedHandle constrained using clear bar distance with zero offset connects to another Rebar target handle.
    RebarConstraintType GetConstraintType()
      Description: Returns the RebarConstraintType of a RebarConstraint.
      Returns: The RebarConstraintType of the specified RebarConstraint.
    int GetCustomHandleTag()
      Description: Returns the handle tag of the RebarConstrainedHandle. This is valid only for Free Form Rebar.
      Returns: Returns the handle tag of the RebarConstrainedHandle.
    double GetDistanceToTargetCover()
      Description: Returns the distance from the RebarConstrainedHandle to the target Host Cover Element surface. The RebarConstraintType of the RebarConstraint must be 'ToCover'.
    double GetDistanceToTargetHostFace()
      Description: Returns the distance from the RebarConstrainedHandle to the target Host Element surface. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace'.
    double GetDistanceToTargetRebar()
      Description: Gets the distance from the RebarConstrainedHandle to the target Rebar handle surface. The RebarConstraintType of the RebarConstraint must be 'ToOtherRebar'.
      Returns: Returns the distance from the RebarConstrainedHandle to the target Rebar handle surface.
    XYZ GetPositiveOffsetDirectionForToOtherRebarConstraint()
      Description: Returns the positive offset direction vector.
      Returns: The positive offset direction vector.
    RebarConstrainedHandle GetRebarConstrainedHandle()
      Description: Gets the RebarConstrainedHandle for which this constraint is.
      Returns: Returns the RebarConstrainedHandle for which this constraint is.
    RebarConstraintTargetHostFaceType GetRebarConstraintTargetHostFaceType()
      Description: Returns the RebarConstraintTargetHostFaceType of the host Element face to which the RebarConstraint is attached. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover'. Will throw exception if it's a multi target constraint.
      Returns: Returns the RebarConstraintTargetHostFaceType of the host Element face to which the RebarConstraint is attached.
    RebarConstraintTargetHostFaceType GetRebarConstraintTargetHostFaceType(int targetIndex)
      Description: Returns the RebarConstraintTargetHostFaceType of the host Element face to which the RebarConstraint is attached. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover'.
      @targetIndex: The index of the target. Should be between 0 and NumberOfTargets().
      Returns: Returns the RebarConstraintTargetHostFaceType of the host Element face to which the RebarConstraint is attached.
    Surface GetSurfaceForConstraintToSurface()
      Description: This method retrieves the surface for a constraint of 'To Surface' type.
      Returns: Returns the surface that the RebarConstraint of 'To Surface' type is using.
    RebarCoverType GetTargetCoverType(int targetIndex)
      Description: Returns the RebarCoverType for the face specified by targetIndex. Returns null if no RebarHostData is present for target element.
      @targetIndex: The index of the target. Should be between 0 and NumberOfTargets().
    Element GetTargetElement()
      Description: Gets the Element object (either Host or Rebar) which provides the constraint. Will throw exception if it's a multi target constraint.
      Returns: Returns the Element object (either Host or Rebar) which provides the constraint.
    Element GetTargetElement(int targetIndex)
      Description: Gets the Element object (either Host or Rebar) which provides the constraint. Will return the Element which contains the face at targetIndex.
      @targetIndex: The index of the target. Should be between 0 and NumberOfTargets().
      Returns: Returns the Element object (either Host or Rebar) which provides the constraint. Will return the Element which contains the face at targetIndex.
    Face GetTargetHostFaceAndTransform(int targetIndex, Transform faceTransform)
      Description: Returns the face to which the RebarConstraint is attached associated to the given target index. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover'.
      @targetIndex: The index of the target. Should be between 0 and NumberOfTargets().
      @faceTransform: Returns the transform that is associated to the face's element geometry.
      Returns: Requested Face.
    Reference GetTargetHostFaceReference()
      Description: Returns a reference to the host Element face to which the RebarConstraint is attached. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover'. Will throw exception if it's a multi target constraint.
      Returns: Requested reference.
    Reference GetTargetHostFaceReference(int targetIndex)
      Description: Returns a reference that corresponds to the face to which the RebarConstraint is attached specified by the targetIndex. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace' or 'ToCover'.
      @targetIndex: The index of the target. Should be between 0 and NumberOfTargets().
      Returns: Requested reference.
    int GetTargetRebarAngleOnBarOrHookBend()
      Description: Returns the angular increment along a bar or hook bend to which the RebarConstraint is attached.
      Returns: The angular increment relative to the reference bar edge.
    int GetTargetRebarBendNumber()
      Description: Returns the number of the bend on the other Rebar Element to which this RebarConstraint is attached. The RebarConstraint must be of RebarConstraintType 'ToOtherRebar,' and the TargetRebarConstraintType must be 'BarBend'. Rebar must be Shape Driven Rebar element.
    TargetRebarConstraintType GetTargetRebarConstraintType()
      Description: Returns the TargetRebarConstraintType of the handle on the other Rebar Element to which this RebarConstraint is attached. The RebarConstraintType of the RebarConstraint must be 'ToOtherRebar'. Rebar must be Shape Driven Rebar element.
    int GetTargetRebarEdgeNumber()
      Description: Returns the number of the edge on the other Rebar Element to which this RebarConstraint is attached. The RebarConstraint must be of RebarConstraintType 'ToOtherRebar,' and the TargetRebarConstraintType must be 'Edge'. Rebar must be Shape Driven Rebar element.
    int GetTargetRebarHookBarEnd()
      Description: Returns 0 or 1 to indicate which end hook on the other Rebar Element to which this RebarConstraint is attached. The RebarConstraint must be of RebarConstraintType 'ToOtherRebar,' and the TargetRebarConstraintType must be 'HookBend'. Rebar must be Shape Driven Rebar element.
    bool HasAnEdgeNumber()
      Description: Checks if the getTargetRebarEdgeNumber method can be called for the RebarConstraint.
    bool IsBindingHandleWithTarget()
      Description: Gets the relationship between two RebarConstrainedHandles.
      Returns: Returns False if only the constrained RebarConstrainedHandle follows the target. Returns True if the constrained RebarConstrainedHandle and the target bar handle are bound and move together.
    bool IsEqual(RebarConstraint other)
      Description: Checks if the specified RebarConstraint is the same as 'this'. The method can be used to determine which of the RebarConstraint candidates offered by the RebarConstraintsManager is currently active.
      @other: RebarConstraint to compare with.
      Returns: Returns true if the specified RebarConstraint is the same as 'this', false otherwise
    bool IsFixedDistanceToHostFace()
      Description: Checks if the RebarConstraintType of the RebarConstraint is 'FixedDistanceToHostFace'.
      Returns: Returns true if the RebarConstraintType of the RebarConstraint is 'FixedDistanceToHostFace', false otherwise.
    bool IsReferenceValidForConstraint(Reference targetReference)
      Description: Checks if the reference provided can be used in creating Rebar constraints
      @targetReference: The reference to be checked
      Returns: returns true if reference can be used in a constraint, false otherwise
    bool IsToCover()
      Description: Checks if the RebarConstraintType of the RebarConstraint is 'ToCover'. Returns true if the RebarConstraintType of the RebarConstraint is 'ToCover', false otherwise.
    bool IsToHostFaceOrCover()
      Description: Returns true if the RebarConstraintType of the RebarConstraint is either 'FixedDistanceToHostFace' or 'ToCover'.
    bool IsToOtherRebar()
      Description: Checks if the RebarConstraintType of the RebarConstraint is 'ToOtherRebar'.
      Returns: Returns true if the RebarConstraintType of the RebarConstraint is 'ToOtherRebar', false otherwise.
    bool IsToSurface()
      Description: Checks if the RebarConstraintType of the RebarConstraint is 'ToSurface'.
      Returns: Returns true if the RebarConstraintType of the RebarConstraint is 'ToSurface', false otherwise.
    bool IsUsingClearBarSpacing()
      Description: Returns true if the RebarConstrainedHandle to target offset is the clear bar distance, false if the offset is measured between bar centers.
      Returns: Returns true if the RebarConstrainedHandle to target offset is the clear bar distance, false if the offset is measured between bar centers.
    bool IsValid()
      Description: Checks that the RebarConstraint still has access to valid Rebar constraint data and that its RebarConstraintsManager is still valid.
    static bool IsValidSurfaceToConstraintHandleTo(RebarConstrainedHandle handle, Surface surface)
      Description: Checks if the surface can be used to create a constraint to it for the input handle.
      @handle: The handle of the rebar that will be constrained.
      @surface: The surface that will be tested.
      Returns: Returns true if the surface can be used to create a constraint to it for the input handle.
    void ReplaceReferenceTargets(RebarConstrainedHandle handle, IList<Reference> targetReferences, bool isConstraintToCover, double offsetValue)
      Description: Replaces the current set of references, the type of constraint and the offset value, with the newly provided ones. Will throw exception if this is a constraint for Shape Driven Rebar.
      @handle: The RebarConstrainedHandle that has this constraint.
      @targetReferences: The references to which the rebar handle will be constrained. This collection must contain one or more references to faces of elements that can host rebar.
      @isConstraintToCover: If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.
      @offsetValue: The distance from references to the rebar handle.
    void SetDistanceToTargetCover(double distanceToTargetCover)
      Description: Sets the distance from the RebarConstrainedHandle to the target Host Cover Element surface. The RebarConstraintType of the RebarConstraint must be 'ToCover'.
      @distanceToTargetCover: The distance is given as an offset value, the sign of which depends on Host Cover direction.
    void SetDistanceToTargetHostFace(double offset)
      Description: Sets the distance from the RebarConstrainedHandle to the target Host Element surface. The RebarConstraintType of the RebarConstraint must be 'FixedDistanceToHostFace'.
      @offset: The distance is given as an offset value, the sign of which depends on Host Face direction.
    void SetDistanceToTargetRebar(double distanceToTargetRebar)
      Description: Sets the offset distance between the constrained RebarConstrainedHandle and its target Rebar handle surface.
      @distanceToTargetRebar: The distance is given as an offset value, the sign of which depends on the target bar handle direction.
    void SetToBindHandleWithTarget(bool bindsHandleWithTarget)
      Description: Sets the relationship between two RebarConstrainedHandles.
      @bindsHandleWithTarget: False if only the constrained RebarConstrainedHandle follows the target. True if the constrained RebarConstrainedHandle and the target bar handle will be bound and move together.
    void SetToUseClearBarSpacing(bool useClearBarSpacing)
      Description: Sets whether the RebarConstrainedHandle to target offset is the clear bar distance, or is measured between bar centers.
      @useClearBarSpacing: True if the RebarConstrainedHandle to target offset is the clear bar distance, false if the offset is measured between bar centers.
    bool TargetIsBarBend()
      Description: Returns true if the RebarTargetConstraintType of the RebarConstraint is 'BarBend'.
    bool TargetIsHookBend()
      Description: Returns true if the RebarTargetConstraintType of the RebarConstraint is 'HookBend'.
    bool TargetRebarConstraintTypeIsEdge()
      Description: Returns true if the RebarConstraintType of the RebarConstraint is 'ToOtherRebar,' and the RebarConstraint is attached to an edge of the other Rebar Element.

--------------------------------------------------------------------------------

[CLASS] RebarConstraintsManager
Full Name: Autodesk.Revit.DB.Structure.RebarConstraintsManager

Description: A class used to obtain information about the constraints (RebarConstraint) acting on the shape handles (RebarConstrainedHandle) of a Rebar element, and modify the constraints.
Remarks: A RebarConstraintsManager is created by calling Rebar.GetRebarConstraintsManager(), and can only be used to query or change constraints on the rebar element that created it.The constraint manager has different behavior, depending on the type of Rebar that created it: Shape Driven or FreeForm -----ShapeDriven-----If the Rebar is Shape Driven, Revit uses the following logic to choose automatic constraints for each handle on a rebar element. First, a search is performed to find all suitable target planes, including surfaces of the rebar's host, as well as surfaces on other concrete host elements that are attached to the rebar's host. In the case of standard style rebar, any host surface occupied by a stirrup will be ignored, and instead, the handles on the stirrup itself will be treated as candidates to form a constraint.Once all the constraint target candidates have been determined, the following sequence is used to select a constraint target: If the rebar is a straight standard bar, it will search the list of candidates for stirrup bends to lock its RebarPlane and Edge handles. If a bend is found within tolerance distance, then the bar will be snapped and constrained to that bend.The bar will snap and constrain its handle to any host cover or stirrup handle that lies within tolerance distance.If no candidate is found within tolerance, then the bar will choose nearest host surface target, with or without cover, and create an automatic constant distance constraint to that surface.Snapping tolerances are 0.5 * bar diameter for host surface cover constraints and 0.5 * (bar diameter + stirrup bar diameter) for stirrup handle constraints.The RebarConstraintsManager allows the API developer to obtain the constraint candidates for each constrained handle on a rebar, and to override the default target selection logic by setting a particular constraint as preferred. The API developer will be able to choose an automatic constraint, or can get constraint candidates to any host in the model or to any Rebar in the model no matter what style it is (Standard or Stirrup). There can be set constraints to generic surfaces as well. This can be useful in a number of ways. First, it can be used to snap a handle to a particular host surface or stirrup rebar handle, or to position a handle at a precise distance from a host surface. Second, it can force a rebar handle to constrain itself to a particular target surface, even if other targets are closer (or will become closer in subsequent updates of the Revit model). For example, a bar can be constrained to maintain a constant offset distance from a face of an opening in a slab, even if the opening is placed close to the edge of the slab and the bar would normally constrain itself to the slab edge. Lastly, the override can be used to cancel the default standard bar preference for stirrup bar handle planes, and to allow standard bars to be constrained to host cover surfaces, even when a stirrup is present.----- FreeForm ----- If the rebar is FreeForm, then it requires input constraints that will be consumed to obtain the actual shape of the bar. The calculation method of the constraints passed to the rebar is custom made by an API application - . The RebarConstraintsManager can return all the possible "shape" handles and can set constraints created only with one of those handles. There are only active constraints on a FreeForm bar, the current and preferred notions represent the same thing.
Implements: IDisposable

  PROPERTIES:
    static bool IsRebarConstrainedPlacementEnabled { get; set; }
      Description: A static property defining if the 'Rebar Constrained Placement' setting is on or off in current Revit Application Session.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool AllowConstraintTargets(RebarConstrainedHandle handle, IList<Reference> targetsToConstrain)
      Description: Returns true if references are valid targets for handle, false otherwise.
      @handle: Represents the constrainable rebar handle.
      @targetsToConstrain: Represent the refernces to be checked as valid targets for handle.
    bool ApplyRebarConstraints(IList<RebarConstraint> constraintsToApply, IList<Reference> oldTargets, IList<Reference> newTargets)
      Description: Returns true if constraints were applied to rebar with success.
      @constraintsToApply: Represent the new constraints to be applied to rebar.
      @oldTargets: Represent the old target references.
      @newTargets: Represent the new target references.
      Returns: Returns true if the constraints were applied succesfully, false otherwise
    void ClearHandleConstraintPairHighlighting(Document aDoc)
      Description: Clears all highlighting in all views.
    void Dispose()
    IList<RebarConstrainedHandle> GetAllConstrainedHandles()
      Description: Retrieves all handles on the Rebar that are constrained to external references.
      Returns: A collection of RebarConstrainedHandles
    IList<RebarConstrainedHandle> GetAllHandles()
      Description: Gets all RebarConstrainedHandles of this bar.
      Returns: All RebarConstrainedHandle objects will be returned, regardless of whether there are constraints associated to them.
    IList<RebarConstraint> GetConstraintCandidatesForHandle(RebarConstrainedHandle handle, Reference reference)
      Description: For shape driven rebar returns all possible RebarConstraints that will constrain RebarConstrainedHandle to the provided reference.For free form rebar will return an empty list.
      @handle: The RebarConstrainedHandle for which constraint candidates are sought.
      @reference: The reference you want to constrain to. It can be a reference to any host in the model or any bar from any host.
      Returns: A collection of RebarConstraints
    IList<RebarConstraint> GetConstraintCandidatesForHandle(RebarConstrainedHandle handle, ElementId elementId)
      Description: For shape driven rebar returns all possible RebarConstraints belonging to references from the provided element that could be used for a specified RebarConstrainedHandle.For free form rebar will return an empty list.
      @handle: The RebarConstrainedHandle for which constraint candidates are sought.
      @elementId: The elementId ( host or rebar ) of the element in which the candidates are searched for. It can be any host in the model or any bar from any host.
      Returns: A collection of RebarConstraints
    IList<RebarConstraint> GetConstraintCandidatesForHandle(RebarConstrainedHandle handle)
      Description: For shape driven rebar returns all possible automatic RebarConstraints that could be used for a specified RebarConstrainedHandle.For free form rebar will return an empty list.
      @handle: The RebarConstrainedHandle for which constraint candidates are sought.
      Returns: A collection of RebarConstraints
    RebarConstraint GetCurrentConstraintOnHandle(RebarConstrainedHandle handle)
      Description: Retrieves the RebarConstraint that acts on the specified RebarConstraintHandle.
    RebarConstraint GetPreferredConstraintOnHandle(RebarConstrainedHandle handle)
      Description: For ShapeDriven: Returns the RebarConstraint that has been set as preferred for the specified RebarConstrainedHandle.For FreeForm: Returns the RebarConstraint that acts on the specified RebarConstraintHandle.
      @handle: The RebarConstrainedHandle for which the RebarConstraint is to be returned.
      Returns: The user preferred RebarConstraint applied to the RebarConstrainedHandle.
    bool HasValidRebar()
      Description: Checks whether the Manager's Rebar is still valid.
    void HighlightHandleConstraintPairInAllViews(Document aDoc, RebarConstrainedHandle handle, RebarConstraint constraint)
      Description: Highlights the specified RebarConstrainedHandle and RebarConstraint in all views.
      @handle: The RebarConstrainedHandle to be highlighted in all views.
      @constraint: The RebarConstraint to be highlighted in all views.
    void RemovePreferredConstraintFromHandle(RebarConstrainedHandle handle)
      Description: For ShapeDriven: Clears the user-preferred RebarConstraint from the specified RebarConstrainedHandle.For FreeForm: Removes the RebarConstraint that is associated to the specified RebarConstrainedHandle.
      @handle: The RebarConstrainedHandle for which the user RebarConstraint is to be deleted.
    void SetPreferredConstraint(RebarConstraint constraint)
      Description: Sets the RebarConstraint as preferred constraint for its RebarConstrainedHandle.
      @constraint: The new RebarConstraint to be applied.
    void SetPreferredConstraintForHandle(RebarConstrainedHandle handle, RebarConstraint constraint)
      Description: For ShapeDriven Rebar: Sets the RebarConstraint as preferred constraint target for the specified RebarConstrainedHandle.For FreeForm Rebar: Sets the RebarConstraint as the target for the specified RebarConstraintHandle.
      @handle: The RebarConstrainedHandle to which the new RebarConstraint is to be applied.
      @constraint: The new RebarConstraint to be applied to the RebarConstrainedHandle.
    void SetPreferredConstraintsToSurfaceForHandles(IList<RebarConstrainedHandle> handles)
      Description: For ShapeDriven Rebar it will set a preferred 'ToSurface' RebarConstraint for each input handle. The surface that will be used by the constraint is the current surface that is used to compute the position of the handle.This function applies only for shape driven Rebar, and will throw exception for free form rebar.
      @handles: The RebarConstrainedHandles for which the 'ToSurface' RebarConstraint will be applied.

--------------------------------------------------------------------------------

[ENUM] RebarConstraintsStatus
Full Name: Autodesk.Revit.DB.Structure.RebarConstraintsStatus

Description: Describes the status of the constraints
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Enabled = 0
    - AllDisabled = 1
    - SomeDisabled = 2

[ENUM] RebarConstraintTargetHostFaceType
Full Name: Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType

Description: A type to help identify the individual face on a host element to which a Rebar handle is constrained.
Remarks: For some types of host, it is possible to describe the face in terms of recognizable topology (i.e. Top, Bottom, etc.). However, for most elements, the face can only be identified by integer tag. In all cases, a Pick to the host face can be obtained by calling RebarConstraint.GetTargetHostFaceReference().
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FaceWithTagId = 0
    - Top = 1
    - Bottom = 2
    - End0 = 3
    - End1 = 4
    - Side0 = 5
    - Side1 = 6

[ENUM] RebarConstraintType
Full Name: Autodesk.Revit.DB.Structure.RebarConstraintType

Description: The various types of constraints that can be applied to a RebarConstrainedHandle.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FixedDistanceToHostFace = 0
    - ToCover = 1
    - ToOtherRebar = 2
    - ToSurface = 3

[CLASS] RebarContainer
Full Name: Autodesk.Revit.DB.Structure.RebarContainer

Description: An object that represents an Rebar Container Element within the Autodesk Revit project.
Remarks: This object is derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object. The Rebar Container element is available only in the Autodesk Revit Structure product. It is a collection of rebar sets. Every rebar set can be modified separately.
Inherits: Element
Implements: IDisposable, IEnumerable`1, IEnumerable

  PROPERTIES:
    int ItemsCount { get; }
      Description: The count of Items in this Rebar Container.
    bool PresentItemsAsSubelements { get; set; }
      Description: Identifies if Items should be presented in schedules and tags as separate subelements.
    string ScheduleMark { get; set; }
      Description: The Schedule Mark parameter. On creation, the Schedule Mark is set to a value that is unique to the host, but it can be set to any value.

  METHODS:
    RebarContainerItem AppendItemFromCurves(RebarStyle style, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, XYZ normal, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, bool useExistingShapeIfPossible, bool createNewShape)
      Description: Appends an Item to the RebarContainer. Fills its data on base of the Rebar.
      @style: The usage of the bar, "standard" or "stirrup/tie".
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @normal: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @useExistingShapeIfPossible: Attempts to assign a RebarShape from those existing in the document. If no shape matches, NewRebar returns or creates a new shape, according to the parameter createNewShape. When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true". If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks, then this method will perform a second search, ignoring hook information.
      @createNewShape: Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance. Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes have enough shape parameters to define a shape for these curves.
      Returns: The Rebar Container Item.
    RebarContainerItem AppendItemFromCurvesAndShape(RebarShape rebarShape, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, XYZ normal, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient)
      Description: Appends an Item to the RebarContainer. Fills its data on base of the Rebar.
      @rebarShape: A RebarShape element that defines the shape of the rebar. A RebarShape element matches curves and hooks. A RebarShape element provides RebarStyle of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @normal: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      Returns: The Rebar Container Item.
    RebarContainerItem AppendItemFromRebar(Rebar rebar)
      Description: Appends an Item to the RebarContainer. Fills its data on base of the Rebar. Will throw exception if given rebar is not shape driven. Will throw exception if given rebar has moved bars in set.
      @rebar: The Rebar.
      Returns: The Rebar Container Item.
    RebarContainerItem AppendItemFromRebarShape(RebarShape rebarShape, RebarBarType barType, XYZ origin, XYZ xVector, XYZ yVector)
      Description: Appends an Item to the RebarContainer. Fills its data on base of the Rebar.
      @rebarShape: A RebarShape element that defines the shape of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @origin: The lower-left corner of the shape's bounding box will be placed at this point in the project.
      @xVector: The x-axis in the shape definition will be mapped to this direction in the project.
      @yVector: The y-axis in the shape definition will be mapped to this direction in the project.
      Returns: The Rebar Container Item.
    bool CanApplyPresentationMode(View dBView)
      Description: Checks if a presentation mode can be applied for this RebarContainer in the given view.
      @dBView: The view in which presentation mode will be applied.
      Returns: True if presentation mode can be applied for this view, false otherwise.
    void ClearItems()
      Description: Clears all the Items stored in this Rebar Container element.
    bool Contains(RebarContainerItem pItem)
      Description: Checks if the RebarContainer has this item as one of its members.
      @pItem: The item to be checked if RebarContainer has it as one of its members
      Returns: True if RebarContainer has this item as one of its members, false otherwise.
    static RebarContainer Create(Document aDoc, Element hostElement, ElementId rebarContainerTypeId)
      Description: Creates a new instance of a Rebar Container element within the project.
      @aDoc: A document.
      @hostElement: The element that will host the RebarContainer.
      @rebarContainerTypeId: The id of the RebarContainerType.
      Returns: The newly created Rebar Container instance.
    IEnumerator<RebarContainerItem> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    ElementId GetHostId()
      Description: The element that contains the rebar.
      Returns: The element that the rebar object belongs to, such as a structural wall, floor, foundation, beam, brace or column.
    RebarContainerItem GetItem(int itemIndex)
      Description: Gets the item stored in the RebarContainer at the associated index.
      @itemIndex: Item index in the Rebar Container
      Returns: Rebar Container Item
    RebarContainerParameterManager GetParametersManager()
      Description: Returns an object used to manage parameters of the Rebar Container.
      Returns: The parameters manager.
    RebarContainerIterator GetRebarContainerIterator()
      Description: Returns a Rebar Container Iterator that iterates through the Rebar Container Items.
      Returns: A Rebar Container Iterator object that can be used to iterate through Rebar Container Items in the collection.
    RebarRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    bool HasPresentationOverrides(View dBView)
      Description: Identifies if any RebarContainerItem of this RebarContainer has overridden default presentation settings for the given view.
      @dBView: The view.
      Returns: True if if any RebarContainerItem of this RebarContainer has overridden default presentation settings, false otherwise.
    bool IsItemHidden(View view, int itemIndex)
      Description: Identifies if a given RebarContainerItem is hidden in this view.
      @view: The view.
      @itemIndex: Item index in the Rebar Container.
      Returns: True if the RebarContainerItem is hidden in this view, false otherwise.
    bool IsUnobscuredInView(View view)
      Description: Checks if this rebar container element is shown unobscured in a view.
      @view: The view element
      Returns: True if rebar is shown unobscured, false otherwise.
    void RemoveItem(RebarContainerItem pItem)
      Description: Removes Item from the Rebar Container.
      @pItem: Item to be removed from this Rebar Container
    void SetHostId(Document doc, ElementId hostId)
      Description: The element that contains the rebar.
      @doc: The document containing both this element and the host element.
      @hostId: The element that the rebar object belongs to, such as a structural wall, floor, foundation, beam, brace or column. The rebar does not need to be strictly inside the host, but it must be assigned to one host element.
    void SetItemHiddenStatus(View view, int itemIndex, bool hide)
      Description: Sets the RebarContainerItem to be hidden or unhidden in the given view.
      @view: The view.
      @itemIndex: Item index in the Rebar Container.
      @hide: True to hide this RebarContainerItem in the view, false to unhide the item.
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets this rebar container element to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if rebar is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[CLASS] RebarContainerItem
Full Name: Autodesk.Revit.DB.Structure.RebarContainerItem

Description: Provides implementation for Rebar stored in RebarContainer.
Implements: IDisposable

  PROPERTIES:
    double ArrayLength { get; set; }
      Description: Identifies the distribution path length of rebar set.
    bool BarsOnNormalSide { get; set; }
      Description: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal.
    ElementId BarTypeId { get; }
      Description: The identifier of the rebar bar type.
    int BaseFinishingTurns { get; set; }
      Description: For a spiral, the number of finishing turns at the lower end of the spiral.
    double Height { get; set; }
      Description: For a spiral, the overall height.
    bool IncludeFirstBar { get; set; }
      Description: Identifies if the first bar in rebar set is shown.
    bool IncludeLastBar { get; set; }
      Description: Identifies if the last bar in rebar set is shown.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int ItemIndex { get; }
      Description: The index of this item in its associated RebarContainer.
    RebarLayoutRule LayoutRule { get; }
      Description: Identifies the layout rule of rebar set.
    double MaxSpacing { get; set; }
      Description: Identifies the maximum spacing between rebar in rebar set.
    double MultiplanarDepth { get; set; }
      Description: For a multiplanar rebar, the depth of the instance.
    XYZ Normal { get; }
      Description: A unit-length vector normal to the plane of the rebar
    int NumberOfBarPositions { get; set; }
      Description: The number of potential bars in the set.
    double Pitch { get; set; }
      Description: For a spiral, the pitch, or vertical distance traveled in one rotation.
    int Quantity { get; }
      Description: Identifies the number of bars in rebar set.
    ElementId RebarShapeId { get; set; }
      Description: The RebarShape element that defines the shape of the rebar.
    int TopFinishingTurns { get; set; }
      Description: For a spiral, the number of finishing turns at the upper end of the spiral.
    double TotalLength { get; }
      Description: The length of an individual bar multiplied by Quantity.
    double Volume { get; }
      Description: The volume of an individual bar multiplied by Quantity.

  METHODS:
    bool CanApplyPresentationMode(View dBView)
      Description: Checks if a presentation mode can be applied for this rebar in the given view.
      @dBView: The view in which presentation mode will be applied.
      Returns: True if presentation mode can be applied for this view, false otherwise.
    bool CanUseHookType(ElementId proposedHookId)
      Description: Checks if the specified RebarHookType id is of a valid RebarHookType for the Rebar's RebarBarType
      @proposedHookId: The Id of the RebarHookType
      Returns: Returns true if the id is of a valid RebarHookType for the Rebar element.
    void ClearPresentationMode(View dBView)
      Description: Sets the presentation mode for this rebar set to the default (either for a single view, or for all views).
      @dBView: The view where the presentation mode will be cleared. NULL for all views
    IList<Curve> ComputeDrivingCurves()
      Description: Compute the driving curves.
      Returns: Returns an empty array if an error is encountered.
    void Dispose()
    bool DoesBarExistAtPosition(int barPosition)
      Description: Checks whether a bar exists at the specified position.
      @barPosition: A bar position index between 0 and NumberOfBarPositions-1.
    RebarPresentationMode FindMatchingPredefinedPresentationMode(View dBView)
      Description: Determines if there is a matching RebarPresentationMode for the current set of selected hidden and unhidden bars assigned to the given view.
      @dBView: The view.
      Returns: The presentation mode that matches the current set of selected hidden and unhidden bars. If there is no better match, this returns RebarPresentationMode.Select.
    Transform GetBarPositionTransform(int barPositionIndex)
      Description: Return a transform representing the relative position of any individual bar in the set.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      Returns: The position of a bar in the set relative to the first position.
    RebarBendData GetBendData()
      Description: Gets the RebarBendData, containing bar and hook information, of the instance.
    IList<Curve> GetCenterlineCurves(bool adjustForSelfIntersection, bool suppressHooks, bool suppressBendRadius, MultiplanarOption multiplanarOption)
      Description: A chain of curves representing the centerline of the rebar.
      @adjustForSelfIntersection: If the curves overlap, as in a planar stirrup, this parameter controls whether they should be adjusted to avoid intersection (as in fine views), or kept in a single plane for simplicity (as in coarse views).
      @suppressHooks: Identifies if the chain will include hooks curves.
      @suppressBendRadius: Identifies if the connected chain will include unfilleted curves.
      @multiplanarOption: If the Rebar is a multi-planar shape, this parameter controls whether to generate only the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves, (IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as multi-planar copies of the primary plane curves. This argument is ignored for planar shapes.
      Returns: The centerline curves or empty array if the curves cannot be computed because the parameters values are inconsistent with the constraints of the RebarShape definition.
    IList<Curve> GetCenterlineCurves(bool adjustForSelfIntersection, bool suppressHooks, bool suppressBendRadius)
      Description: A chain of curves representing the centerline of the rebar.
      @adjustForSelfIntersection: If the curves overlap, as in a planar stirrup, this parameter controls whether they should be adjusted to avoid intersection (as in fine views), or kept in a single plane for simplicity (as in coarse views).
      @suppressHooks: Identifies if the chain will include hooks curves.
      @suppressBendRadius: Identifies if the connected chain will include unfilleted curves.
      Returns: The centerline curves or empty array if the curves cannot be computed because the parameters values are inconsistent with the constraints of the RebarShape definition.
    Line GetDistributionPath()
      Description: The distribution path of a rebar set.
      Returns: A line beginning at (0, 0, 0) and representing the direction and length of the set.
    RebarHookOrientation GetHookOrientation(int iEnd)
      Description: Returns the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.
      @iEnd: 0 for the start hook, 1 for the end hook.
      Returns: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
    ElementId GetHookTypeId(int end)
      Description: Get the id of the RebarHookType to be applied to the rebar.
      @end: 0 for the start hook, 1 for the end hook.
      Returns: The id of a RebarHookType, or invalidElementId if the rebar has no hook at the specified end.
    RebarPresentationMode GetPresentationMode(View dBView)
      Description: Gets the presentaion mode for this rebar set when displayed in the given view.
      @dBView: The view.
      Returns: The presentation mode.
    bool HasPresentationOverrides(View dBView)
      Description: Identifies if this rebar set has overridden default presentation settings for the given view.
      @dBView: The view.
      Returns: True if this rebar set has overriden default presentation settings, false otherwise.
    bool IsBarHidden(View view, int barIndex)
      Description: Identifies if a given bar in this rebar set is hidden in this view.
      @view: The view.
      @barIndex: The index of the bar from this rebar set.
      Returns: True if the bar is hidden in this view, false otherwise.
    bool IsRebarInSection(View dBView)
      Description: Identifies if this rebar set is shown as a cross-section in the given view.
      @dBView: The view.
      Returns: True if this rebar set is shown as a cross-section, false otherwise.
    void SetBarHiddenStatus(View view, int barIndex, bool hide)
      Description: Sets the bar in this rebar set to be hidden or unhidden in the given view.
      @view: The view.
      @barIndex: The index of the bar from this set.
      @hide: True to hide this bar in the view, false to unhide the bar.
    void SetFromCurves(RebarStyle style, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, XYZ norm, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, bool useExistingShapeIfPossible, bool createNewShape)
      Description: Set an instance of a RebarContainerItem element according to the parameters list.
      @style: The usage of the bar, "standard" or "stirrup/tie".
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @useExistingShapeIfPossible: Attempts to assign a RebarShape from those existing in the document. If no shape matches, NewRebar returns or creates a new shape, according to the parameter createNewShape. When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true". If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks, then this method will perform a second search, ignoring hook information.
      @createNewShape: Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance. Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes have enough shape parameters to define a shape for these curves.
    void SetFromCurvesAndShape(RebarShape rebarShape, RebarBarType barType, RebarHookType startHook, RebarHookType endHook, XYZ norm, IList<Curve> curves, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient)
      Description: Set an instance of a RebarContainerItem element according to the parameters list. The instance will have the default shape parameters from the RebarShape. If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to true, then both the curves and hooks must match the RebarShape definition. Otherwise, the hooks can be different than the defaults specified in the RebarShape
      @rebarShape: A RebarShape element that defines the shape of the rebar. A RebarShape element matches curves and hooks. A RebarShape element provides RebarStyle of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @startHook: A RebarHookType element that defines the hook for the start of the bar. If this parameter is , it means to create a rebar with no hook.
      @endHook: A RebarHookType element that defines the hook for the end of the bar. If this parameter is , it means to create a rebar with no hook.
      @norm: The normal to the plane that the rebar curves lie on.
      @curves: An array of curves that define the shape of the rebar curves. They must belong to the plane defined by the normal and origin. Bends and hooks should not be included in the array of curves.
      @startHookOrient: Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
      @endHookOrient: Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal. Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
    void SetFromRebar(Rebar rebar)
      Description: Set an instance of a RebarContainerItem element according to a Rebar parameters. Will throw exception if given rebar is not shape driven. Will throw exception if given rebar has moved bars in set.
      @rebar: The Rebar.
    void SetFromRebarShape(RebarShape rebarShape, RebarBarType barType, XYZ origin, XYZ xVec, XYZ yVec)
      Description: Set an instance of a RebarContainerItem element, as an instance of a RebarShape. The instance will have the default shape parameters from the RebarShape, and its location is based on the bounding box of the shape in the shape definition. Hooks are removed from the shape before computing its bounding box. If appropriate hooks can be found in the document, they will be assigned arbitrarily.
      @rebarShape: A RebarShape element that defines the shape of the rebar.
      @barType: A RebarBarType element that defines bar diameter, bend radius and material of the rebar.
      @origin: The lower-left corner of the shape's bounding box will be placed at this point in the project.
      @xVec: The x-axis in the shape definition will be mapped to this direction in the project.
      @yVec: The y-axis in the shape definition will be mapped to this direction in the project.
    void SetHookOrientation(int iEnd, RebarHookOrientation hookOrientation)
      Description: Defines the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.
      @iEnd: 0 for the start hook, 1 for the end hook.
      @hookOrientation: Only two values are permitted: Value = Right: The hook is on your right as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up." Value = Left: The hook is on your left as you stand at the end of the bar, with the bar behind you, taking the bar's normal as "up."
    void SetHookTypeId(int end, ElementId hookTypeId)
      Description: Set the id of the RebarHookType to be applied to the rebar.
      @end: 0 for the start hook, 1 for the end hook.
      @hookTypeId: The id of a RebarHookType element, or invalidElementId if the rebar should have no hook at the specified end.
    void SetLayoutAsFixedNumber(int numberOfBarPositions, double arrayLength, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to FixedNumber.
      @numberOfBarPositions: The number of bar positions in rebar set
      @arrayLength: The distribution length of rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsMaximumSpacing(double spacing, double arrayLength, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to MaximumSpacing
      @spacing: The maximum spacing between rebar in rebar set
      @arrayLength: The distribution length of rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsMinimumClearSpacing(double spacing, double arrayLength, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to MinimumClearSpacing
      @spacing: The maximum spacing between rebar in rebar set
      @arrayLength: The distribution length of rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsNumberWithSpacing(int numberOfBarPositions, double spacing, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to NumberWithSpacing
      @numberOfBarPositions: The number of bar positions in rebar set
      @spacing: The maximum spacing between rebar in rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsSingle()
      Description: Sets the Layout Rule property of rebar set to Single.
    void SetPresentationMode(View dBView, RebarPresentationMode presentationMode)
      Description: Sets the presentation mode for this rebar set when displayed in the given view.
      @dBView: The view.
      @presentationMode: The presentation mode.

--------------------------------------------------------------------------------

[CLASS] RebarContainerIterator
Full Name: Autodesk.Revit.DB.Structure.RebarContainerIterator

Description: An iterator to a Rebar Container.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    RebarContainerItem Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] RebarContainerParameterManager
Full Name: Autodesk.Revit.DB.Structure.RebarContainerParameterManager

Description: Provides implementation of RebarContainer parameters overrides.
Remarks: When a new override is created, by default, the parameter will show the overridden value as read-only. You can control whether or not the parameter is modifiable using and .a
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddOverride(ElementId paramId, ElementId value)
      Description: Adds an override for the given parameter as its value will be displayed for the Rebar Container element.
      @paramId: The id of the parameter
      @value: The override value of the parameter.
    void AddOverride(ElementId paramId, string value)
      Description: Adds an override for the given parameter as its value will be displayed for the Rebar Container element.
      @paramId: The id of the parameter
      @value: The override value of the parameter.
    void AddOverride(ElementId paramId, int value)
      Description: Adds an override for the given parameter as its value will be displayed for the Rebar Container element.
      @paramId: The id of the parameter
      @value: The override value of the parameter.
    void AddOverride(ElementId paramId, double value)
      Description: Adds an override for the given parameter as its value will be displayed for the Rebar Container element.
      @paramId: The id of the parameter
      @value: The override value of the parameter.
    void AddSharedParameterAsOverride(ElementId paramId)
      Description: Adds a shared parameter as one of the parameter overrides stored by this Rebar Container element.
      @paramId: The id of the shared parameter element
    void ClearOverrides()
      Description: Clears any overridden values from all parameters of the associated RebarContainer element.
    void Dispose()
    double GetDoubleOverrideValue(ElementId paramId)
      Description: Get the double value for an overriden parameter.
      @paramId: The id of the parameter
      Returns: The override value of the parameter.
    ElementId GetElementIdOverrideValue(ElementId paramId)
      Description: Get the ElementId value for an overriden parameter.
      @paramId: The id of the parameter
      Returns: The override value of the parameter.
    int GetIntOverrideValue(ElementId paramId)
      Description: Get the integer value for an overriden parameter.
      @paramId: The id of the parameter
      Returns: The override value of the parameter.
    string GetStringOverrideValue(ElementId paramId)
      Description: Get the string value for an overriden parameter.
      @paramId: The id of the parameter
      Returns: The override value of the parameter.
    bool IsOverriddenParameterModifiable(ElementId paramId)
      Description: Checks if overridden parameter is modifiable.
      @paramId: Overridden parameter id
      Returns: True if the parameter is modifiable, false if the parameter is readonly.
    bool IsParameterOverridden(ElementId paramId)
      Description: Checks if the parameter has an override
      @paramId: The id of the parameter element
      Returns: True if the parameter has an override
    bool IsRebarContainerParameter(ElementId paramId)
      Description: Checks if the parameter is a Rebar Container parameter
      @paramId: The id of the parameter element
      Returns: True if the parameter is a Rebar Container parameter
    void RemoveOverride(ElementId paramId)
      Description: Removes an overridden value from the given parameter.
      @paramId: The id of the parameter
    void SetOverriddenParameterModifiable(ElementId paramId)
      Description: Sets this overridden parameter to be modifiable.
      @paramId: Overridden parameter id
    void SetOverriddenParameterReadonly(ElementId paramId)
      Description: Sets this overridden parameter to be readonly.
      @paramId: Overridden parameter id

--------------------------------------------------------------------------------

[CLASS] RebarContainerType
Full Name: Autodesk.Revit.DB.Structure.RebarContainerType

Description: Represents a Rebar Container Type, used in the generation of Rebar Container.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static ElementId CreateDefaultRebarContainerType(Document aDoc)
      Description: Creates a new RebarContainerType object with a default name.
      @aDoc: The document.
      Returns: The newly created type id.
    static ElementId GetOrCreateRebarContainerType(Document aDoc, string name)
      Description: Creates or returns a RebarContainerType object with a given name.
      @aDoc: The document.
      @name: Name of the type.
      Returns: The type id.

--------------------------------------------------------------------------------

[CLASS] RebarCoupler
Full Name: Autodesk.Revit.DB.Structure.RebarCoupler

Description: Represents a rebar coupler element in Autodesk Revit.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string CouplerMark { get; set; }
      Description: gets and sets the coupler mark
    double RotationAngle { get; set; }
      Description: Indetifies the rotation angle of the coupler around its axis.

  METHODS:
    bool CouplerLinkTwoBars()
      Description: returns true if the coupler sits on two rebar and false otherwise
    static RebarCoupler Create(Document doc, ElementId typeId, ReinforcementData pFirstData, ReinforcementData pSecondData, out RebarCouplerError error)
    IList<ReinforcementData> GetCoupledReinforcementData()
      Description: gets the reinforcement data. The returned list will have size = 2. If coupler stays on only one bar one element in this list will be null.
    Transform GetCouplerPositionTransform(int couplerPositionIndex)
      Description: Return a transform representing the relative position of the coupler at index couplerPositionIndex in the set.
      @couplerPositionIndex: An index between 0 and (CouplerQuantity-1).
      Returns: Returns a transformation that is composed from : - a translation from (0, 0, 0) to coupler origin - a rotation that will align the coupler with the bar segment on which it stays.
    int GetCouplerQuantity()
      Description: Identifies the number of couplers in a set.
      Returns: Returns the number of couplers in a set.
    IList<XYZ> GetPointsForPlacement()
      Description: gets the point (or points in case of rebar set) where the coupler is placed
    bool IsUnobscuredInView(View view)
      Description: Checks if this rebar coupler element is shown unobscured in a view.
      @view: The view element
      Returns: True if rebar coupler is shown unobscured, false otherwise.
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets this rebar coupler element to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if rebar coupler is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[ENUM] RebarCouplerError
Full Name: Autodesk.Revit.DB.Structure.RebarCouplerError

Description: Error states for the Rebar Coupler
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ValidationSuccessfuly = 0
    - IncorrectInputData = 1
    - DifferentLayout = 2
    - BarsNotTouching = 3
    - IncorrectEndTreatmentHook = 4
    - IncorrectEndTreatmentCoupler = 5
    - BarSegementsAreNotParallel = 6
    - BarSegmentsAreNotOnSameLine = 7
    - InconsistentShape = 8
    - InvalidDiameter = 9
    - CurvesOtherThanLine = 12
    - BarSegmentSmallerThanEngagement = 13
    - VaryingDistanceBetweenDistributionsBars = 14
    - ArcsHaveDifferentRadii = 15
    - ArcsHaveDifferentCenters = 16
    - ArcToStraightSegment = 17
    - BendingPlanesAreNotParallel = 18

[CLASS] RebarCoverType
Full Name: Autodesk.Revit.DB.Structure.RebarCoverType

Description: A named value for a clear cover distance.
Remarks: In Revit Structure, CoverTypes are the rows in the Rebar Cover Settings dialog.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    double CoverDistance { get; set; }
      Description: A distance that can be used as a concrete cover value in a document.

  METHODS:
    static RebarCoverType Create(Document doc, string name, double coverDistance)
      Description: Creates a new CoverType in the document.

--------------------------------------------------------------------------------

[CLASS] RebarCurvesData
Full Name: Autodesk.Revit.DB.Structure.RebarCurvesData

Description: The class that contains the information needed to calculate and return the result of the external curve generation.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    RebarFreeFormValidationResult AddBarGeometry(CurveLoop curves)
      Description: Adds a new bar to the new rebar geometry. This information is set to the rebar after the API execution is finished successfully.
      @curves: Curves describing one bar in the set.
      Returns: Returns Success if everything is ok, otherwise the failure reason.
    RebarFreeFormValidationResult AddBarGeometry(IList<Curve> curves)
      Description: Adds a new bar to the new rebar geometry. This information is set to the rebar after the API execution is finished successfully.
      @curves: Curves describing one bar in the set.
      Returns: Returns Success if everything is ok, otherwise the failure reason.
    bool CanAddBarGeometry()
      Description: If the layout rule is Singe or FixedNumber or NumberWithSpacing this function will return true if getNumberOfBarGeometry() is less getBarsNumber(), false otherwise.If the layout rule is MaximumSpacing or MinimumClearSpacing this function will return always true.
      Returns: Returns true if we can add more bar geometry for the current layout, false otherwise.
    void ClearAllAddedBarGeometry()
      Description: This function will remove all bars geometry that were added by calling AddBarGeometry().
    void Dispose()
    IList<Curve> GetAddedBarGeometry(int barIndex)
      Description: Gets the added curves that will represent the bar at index barIndex.
      @barIndex: The index of the bar. Should be a number between 0 and GetNumberOfBarGeometry() - 1.
      Returns: Returns the curves that will represent the bar at index barIndex. The hooks plane normals will be applied on these curves.
    IList<Curve> GetDistributionPath()
      Description: Gets the distribution path currently stored in the rebar.
      Returns: Returns array of curves that represent the distribution path.
    int GetNumberOfBarGeometry()
      Description: Gets the number of Bar Geometry that were added.
      Returns: Returns the number of Bar Geometry that were added.
    RebarUpdateCurvesData GetRebarUpdateCurvesData()
      Description: Gets a class that contains information used as input and output for rebar free form calculation.
      Returns: Gets a class that contains information used as input and output for rebar free form calculation.
    void SetDistributionPath(IList<Curve> path)
      Description: Sets a new distribution path to be applied to the rebar. This information is set to the rebar after the API execution is finished successfully.
      @path: Input curves that describe the new path.

--------------------------------------------------------------------------------

[ENUM] RebarDeformationType
Full Name: Autodesk.Revit.DB.Structure.RebarDeformationType

Description: Bar deformation type
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Deformed = 0
    - Plain = 1

[CLASS] RebarFreeFormAccessor
Full Name: Autodesk.Revit.DB.Structure.RebarFreeFormAccessor

Description: A class that is used to access the properties and capabilities of free-form Rebar.
Remarks: Obtain an instance of this class from . The accessor includes a reference to the Rebar element. If the referenced Rebar element is deleted, using the methods form this class will throw exception.
Implements: IDisposable

  PROPERTIES:
    AlignedFreeFormSetOrientationOptions AlignedFreeFormSetOrientationOptions { get; set; }
      Description: Orientation options for an Aligned Free Form Rebar set.
    int CycleCounter { get; set; }
      Description: Identifies the cycle counter. It can be zero or a pozitive number.Its value is changed when the free form Rebar element is selected and the user press Space key -or- through the setter of this property -or- by the server if it considers that the counter reaches the maximum value and reset it (set it to 0). This property can be accessed just for Rebars that are controlled by a server.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    RebarStyle RebarStyle { get; set; }
      Description: Identifies the RebarStyle of the current Rebar element.
    StirrupTieAttachmentType StirrupTieAttachmentType { get; set; }
      Description: Identifies the StirrupTieAttachmentType of the current Rebar element. The RebarStyle of the Rebar element must be StirrupTie.
    RebarWorkInstructions WorkshopInstructions { get; set; }
      Description: Identifies the workshop instructions of the current Rebar element.

  METHODS:
    void AddUpdatingSharedParameter(ElementId parameterId)
      Description: Add existing shared parameter as a dependency for the calculation of the rebar curves.
      @parameterId: ElementId of the shared parameter to be added.
    bool CanBeHookNormal(int barIndex, int end, XYZ normal)
      Description: A vector can be hook normal if for a bar specified by index, the bar direction is not parallel with the vector.
      @barIndex: The index of bar for which it will try to see if hook normal is applicable.
      @end: The end of bar. Should be 0 for start, 1 for end.
      @normal: The hook plane normal that will be tested.
    void DisconnectFromServer()
      Description: Sets the GUID of the API server to invalid value and removes all the server related data from the Rebar (ex. the current constraints and the handle tags are removed). Calling this method will result in a Rebar that will not react to host changes anymore, however it will still have all the properties that it used to have.
    void Dispose()
    ElementId GetCouplerIdAtIndex(int barPositionIndex, int end)
      Description: Gets the id of the Rebar Coupler that is applied to the bar with index barPositionIndex at the specified end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      @end: 0 for the start hook, 1 for the end hook.
      Returns: Returns id of the Rebar Coupler at the specified end.
    IList<Curve> GetCustomDistributionPath()
      Description: Gets the custom distribution path for free form rebar set.
      Returns: Returns an array of curves that represent the distribution path.
    ElementId GetEndTreatmentTypeIdAtIndex(int barPositionIndex, int end)
      Description: Gets the id of the EndTreatmentType that is applied to the bar with index barPositionIndex at the specified end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      @end: 0 for the start hook, 1 for the end hook.
      Returns: Returns the the id of the EndTreatmentType at the specified end.
    double GetHookOrientationAngle(int end)
      Description: Get the hook orientation angle at end.
      @end: The end of bar. Should be 0 for start or 1 for end.
      Returns: The hook orientation angle at end.
    double GetHookOrientationAngleAtIndex(int barPositionIndex, int end)
      Description: Gets the hook orientation angle that is applied to this Rebar at the bar with index barPositionIndex at the specified end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      @end: 0 for the start hook, 1 for the end hook.
      Returns: Returns the hook orientation angle at the specified end.
    RebarHookOrientation GetHookOrientationAtIndex(int barPositionIndex, int end)
      Description: Gets the hook orientation that is applied to this Rebar at the bar with index barPositionIndex at the specified end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      @end: 0 for the start hook, 1 for the end hook.
      Returns: Returns the hook orientation at the specified end.
    XYZ GetHookPlaneNormalForBarIdx(int end, int barPositionIndex)
      Description: Returns the normal of plane in which the hook at end of bar with index barPositionIndex will stay.
      @end: The end of bar. Should be 0 for start or 1 for end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      Returns: The normal of plane in which the hook at end of bar with index barPositionIndex will stay.
    ElementId GetHookTypeIdAtIndex(int barPositionIndex, int end)
      Description: Gets the id of the RebarHookType that is applied to this Rebar at the bar with index barPositionIndex at the specified end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      @end: 0 for the start hook, 1 for the end hook.
      Returns: The id of a RebarHookType, or invalidElementId if the rebar has no hook at the specified end.
    Guid GetServerGUID()
      Description: Returns the GUID of the API server.
      Returns: The GUID of the API server
    ElementId GetShapeIdAtIndex(int barPositionIndex)
      Description: Gets the Rebar Shape id for the bar with index barPositionIndex.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      Returns: Gets the ElementId of the Rebar Shape for the bar with index barPositionIndex.
    IList<ElementId> GetUpdatingSharedParameters()
      Description: Get the shared parameters listed as dependencies in the calculation of the rebar curves
      Returns: Returns the elementIds of the shared parameters
    bool HasValidAlignedServer()
      Description: Returns true if the current rebar is created with the Aligned Free Form rebar server, false otherwise.
      Returns: Returns true if the current rebar is created with the Aligned Free Form rebar server, false otherwise.
    bool HasValidServer()
      Description: Returns true if the current rebar contains a valid server GUID, false otherwise.
      Returns: Returns true if the current rebar contains a valid server GUID, false otherwise.
    bool IsBarMatchedWithShapeInReverseOrder(int barPositionIndex)
      Description: Checks if the bar at index barPositionIndex it's matched in reversed order with its shape.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      Returns: Returns true if the bar is matched in reversed order with its shape, false otherwise.
    bool IsUnconstrained()
      Description: Returns true if the current rebar doesn't contains a valid server GUID, or contains a valid server GUID and no valid constraints.
      Returns: Returns true if the current rebar doesn't contains a valid server GUID, or contains a valid server GUID and no valid constraints. Returns false if the current rebar contains a valid server GUID and has valid constraints.
    void RemoveUpdatingSharedParameter(ElementId parameterId)
      Description: Remove existing shared parameter as a dependency for the calculation of the rebar curves.
      @parameterId: ElementId of the shared parameter to be removed.
    RebarFreeFormValidationResult SetCurves(IList<CurveLoop> curves)
      Description: Set the curves into a free form Rebar. Will throw exception if the rebar has valid constraints.
      @curves: Each curve loop represents a bar in the set.
      Returns: Returns Success if everything is ok, otherwise the failure reason.
    RebarFreeFormValidationResult SetCurves(IList<IList<Curve>> curves)
      Description: Set the curves into a free form Rebar. Will throw exception if the rebar has valid constraints.
      @curves: Each array of curves represent a bar in the set.
      Returns: Returns Success(0) if everything is ok, otherwise the failure reason.
    void SetHookOrientationAngle(int end, double angle)
      Description: Set the hook orientation angle at end. Will throw exception if the rebar has valid constraints.
      @end: The end of bar. Should be 0 for start or 1 for end.
      @angle: The hook orientation angle at end.
    void SetHookPlaneNormalForBarIdx(int end, int barPositionIndex, XYZ hookNormal)
      Description: Set the normal of plane in which the hook at end of bar with index barPositionIndex will stay. Will throw exception if the rebar has valid constraints.
      @end: The end of bar. Should be 0 for start or 1 for end.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      @hookNormal: The normal of plane in which the hook at end of bar with index barPositionIndex will stay. The normal should be perpendicular to the bar direction at the specified end of bar.
    void SetLayoutAsFixedNumber(int numberOfBars)
      Description: Sets the Layout Rule property of rebar set to Fixed Number.
      @numberOfBars: The number of bars in set.
    void SetLayoutAsMaximumSpacing(double spacing)
      Description: Sets the Layout Rule property of rebar set to Maximum Spacing.
      @spacing: The maximum spacing of bars in set.
    void SetLayoutAsMinimumClearSpacing(double spacing)
      Description: Sets the Layout Rule property of rebar set to Minimum Clear Spacing.
      @spacing: The maximum spacing of bars in set.
    void SetLayoutAsNumberWithSpacing(int numberOfBars, double spacing)
      Description: Sets the Layout Rule property of rebar set to Number With Spacing.
      @numberOfBars: The number of bars in set.
      @spacing: The spacing of bars in set.
    void SetLayoutAsSingle()
      Description: Sets the Layout Rule property of rebar set to Single.
    void SetReportedShape(ElementId rebarShapeId)
      Description: This method changes the RebarShape of a Free Form Rebar that is using RebarWorkInstructions.Straight property to the provided RebarShape.

--------------------------------------------------------------------------------

[ENUM] RebarFreeFormValidationResult
Full Name: Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult

Description: Errors for the Free Form Rebar
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Success = 0
    - Undefined = 1
    - NullCurve = 2
    - UnboundCurve = 3
    - InvalidLoop = 4
    - RebarCantBeBent = 5

[ENUM] RebarGeometryType
Full Name: Autodesk.Revit.DB.Structure.RebarGeometryType

Description: Rebar geometry type
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShapeBased = 0
    - FreeForm = 1

[ENUM] RebarHandleBehavior
Full Name: Autodesk.Revit.DB.Structure.RebarHandleBehavior

Description: Different behaviors that can be applied to a RebarConstrainedHandle. Depending on the behavior, the RebarConstrainedHandle plane is situated in a different location All the data in constraints for a RebarConstrainedHandle with a specific behavior are relative to this plane.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - SpliceMainEndOnEnd1Position = 1
    - SpliceMainEndOnMiddlePosition = 2
    - SpliceMainEndOnEnd2Position = 3
    - SpliceConnectedEndOnEnd1Position = 4
    - SpliceConnectedEndOnMiddlePosition = 5
    - SpliceConnectedEndOnEnd2Position = 6
    - SpliceRebarPlaneOnSpliceSetExtent = 7
    - SpliceOutOfPlaneExtentOnSpliceSetExtent = 8
    - SpliceEdge = 9

[CLASS] RebarHandleNameData
Full Name: Autodesk.Revit.DB.Structure.RebarHandleNameData

Description: This class is used to contain the information about the rebar handle name defined by an external application.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    int GetCustomHandleTag()
      Description: Gets the handle tag for which we need to specify the name.
      Returns: Returns the handle tag for which we need to specify the name.
    void SetCustomHandleName(string customHandleName)
      Description: Sets the name of the handle.
      @customHandleName: The name of the handle.

--------------------------------------------------------------------------------

[CLASS] RebarHandlePositionData
Full Name: Autodesk.Revit.DB.Structure.RebarHandlePositionData

Description: The class that contains data for the handle position calculation.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<Curve> GetBarGeometry(int barIndex)
      Description: Returns the geometry for a bar at the specified index currently in the Rebar.
      @barIndex: The index of the bar. Should be a number between 0 and GetNumberOfBars() - 1.
      Returns: Returns an array of curves that defines the bar at the specified index.
    IList<Curve> GetDistributionPath()
      Description: Gets the distribution path currently stored in the rebar.
      Returns: Returns array of curves that represent the distribution path.
    int GetNumberOfBars()
      Description: Gets the number of bars currently in the rebar.
      Returns: Returns the number of bars currently in the rebar.
    void SetPosition(int handleTag, XYZ position)
      Description: Sets the position for a specified handle. This information is set to the rebar after the API execution is finished successfully.
      @handleTag: The tag of the handle.
      @position: Position of the handle.

--------------------------------------------------------------------------------

[CLASS] RebarHandlesData
Full Name: Autodesk.Revit.DB.Structure.RebarHandlesData

Description: This class is used to contain the information about the rebar handles defined by an external application.
Remarks: All handle tags (custom, start, end) should have different values.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddCustomHandle(int customHandleTag)
      Description: Adds a new handle definition to the rebar. This information is set to the rebar after the API execution is finished successfully.
      @customHandleTag: The tag of the handle. The tag should be different from the previous ones that were added.
    void Dispose()
    IList<int> GetCustomHandles()
      Description: Gets the handle definitions for the rebar that were added.
      Returns: Returns all custom handles.
    int GetEndHandle()
      Description: Gets the end handle tag.
      Returns: Returns the end handle tag.
    int GetStartHandle()
      Description: Gets the start handle tag.
      Returns: Returns the start handle tag.
    void SetEndHandle(int endHandleTag)
      Description: Sets the end handle tag. This information is set to the rebar after the API execution is finished successfully.
      @endHandleTag: The tag of the end handle.
    void SetStartHandle(int startHandleTag)
      Description: Sets the start handle tag. This information is set to the rebar after the API execution is finished successfully.
      @startHandleTag: The tag of the start handle.

--------------------------------------------------------------------------------

[ENUM] RebarHandleType
Full Name: Autodesk.Revit.DB.Structure.RebarHandleType

Description: The various types of handles on a Rebar instance that can be joined to References
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - RebarPlane = 0
    - StartOfBar = 1
    - EndOfBar = 2
    - Edge = 3
    - OutOfPlaneExtent = 4
    - CustomHandle = 5
    - Undefined = -1

[ENUM] RebarHookOrientation
Full Name: Autodesk.Revit.DB.Structure.RebarHookOrientation

Description: Orientation of a rebar hook relative to the path of the Rebar Shape.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Left = 1
    - Right = -1

[CLASS] RebarHookType
Full Name: Autodesk.Revit.DB.Structure.RebarHookType

Description: A Rebar Hook type object that is used in the generation of Rebar.
Remarks: This object contains the definition of the hooks that may be created at the ends of the rebar. The specifics of these hooks are angle (range 0-PI) between first/last segment of rebar and the straight segment of the hook, rebar shape style and a multiplier used to compute the length of the straight segment of the hook. The default length is computed as the bar diameter * the multiplier. Length can be overridden by settings in the RebarBarType class.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    double HookAngle { get; set; }
      Description: The hook angle, measured in radians. Must be greater than 0 and no more than pi.
    double StraightLineMultiplier { get; set; }
      Description: Multiplier of bar diameter. Used to compute a default hook length. The default hook length can be overridden by the RebarBarType class.
    RebarStyle Style { get; set; }
      Description: The hook may only be applied to shapes of the specified style.

  METHODS:
    static RebarHookType Create(Document doc, double angle, double multiplier)
      Description: Creates a new RebarHookType in a document.
      @angle: Determine the hook angle of new RebarHookType.
      @multiplier: Determine the straight line multiplier of new RebarHookType.
    static ElementId CreateDefaultRebarHookType(Document ADoc)
      Description: Creates a new RebarHookType object with a default name.
      @ADoc: The document.
      Returns: The newly created type id.
    double GetDefaultHookExtension(double barDiameter)
      Description: Computes the default hook length, which is equal to barDiameter * multiplier.
    double GetHookExtensionLength(RebarBarType barType)
      Description: Computes the hook extension length based on current hook length
    bool IsOffsetLengthRequired()
      Description: Check whether hook offset length is required. remarks: If hook angle is no more than 90 degree, hook offset length is not meaningful. returns: True if hook offset length is required, otherwise false.

--------------------------------------------------------------------------------

[ENUM] RebarHostCategory
Full Name: Autodesk.Revit.DB.Structure.RebarHostCategory

Description: Rebar host category
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Other = 0
    - Part = 1
    - StructuralColumn = 2
    - StructuralFraming = 3
    - Wall = 4
    - Floor = 5
    - StructuralFoundation = 6
    - Stairs = 7
    - SlabEdge = 8

[CLASS] RebarHostData
Full Name: Autodesk.Revit.DB.Structure.RebarHostData

Description: Interface to rebar-specific data stored in each valid rebar host element.
Remarks: Rebar host elements keep track of the "exposed faces," those that are not completely concealed by another rebar host. Faces may be concealed by joins; for instance, the top face of a beam that supports a slab is concealed. Faces can also be concealed by adjacency; for instance, the bottom face of a column that is supported by a foundation. Each exposed face of a rebar host must have a valid CoverType associated with it.Rebar hosts also have cover parameters, providing a limited interface to the GetCoverType and SetCoverType methods. Each parameter simply gets or sets the cover setting associated with one or more particular faces of the host.CLEAR_COVER_EXTERIOR (walls only)CLEAR_COVER_INTERIOR (walls only)CLEAR_COVER_OTHER (all hosts except in-place families and stairs)CLEAR_COVER (in-place families and stairs)CLEAR_COVER_TOP (all hosts except walls, in-place families, and stairs)CLEAR_COVER_BOTTOM (all hosts except walls, in-place families, and stairs)
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<AreaReinforcement> GetAreaReinforcementsInHost()
      Description: Returns all AreaReinforcement elements hosted by the referenced element.
    RebarCoverType GetCommonCoverType()
      Description: If all exposed faces of the host have the same associated CoverType, return that CoverType; otherwise, return .
      Returns: The common CoverType for all exposed faces, or if there are multiple CoverTypes.
    RebarCoverType GetCoverType(Reference face)
      Description: Gets the CoverType associated with a face of the element.
      Returns: The cover associated with the face, if it is an exposed face. If the face is concealed, returns .
    IList<Reference> GetExposedFaces()
      Description: Returns all the exposed faces, that is, those that have an associated CoverType.
    IList<FabricArea> GetFabricAreasInHost()
      Description: Returns all FabricArea elements hosted by the referenced element.
    IList<FabricSheet> GetFabricSheetsInHost()
      Description: Returns all FabricSheet elements hosted by the referenced element.
    IList<PathReinforcement> GetPathReinforcementsInHost()
      Description: Returns all PathReinforcement elements hosted by the referenced element.
    IList<RebarContainer> GetRebarContainersInHost()
      Description: Returns all RebarContainer elements hosted by the referenced element.
    static RebarHostData GetRebarHostData(Element host)
      Description: Gets a RebarHostData object referring to the specified rebar host element.
      @host: An element to host rebar.
      Returns: A RebarHostData object, or .
    static ISet<ElementId> GetRebarHostDirectNeighbors(Element hostElement)
      Description: Returns a set of ElementIds for Elements joined to the provided host element.
      @hostElement: The host element. Must be an element that can host reinforcement.
      Returns: The neighbor ids.
    IList<Rebar> GetRebarsInHost()
      Description: Returns all Rebar elements hosted by the referenced element.
    bool IsFaceExposed(Reference face)
      Description: Checks whether the specified face is considered exposed, and therefore has an associated CoverType.
      Returns: True if %face% is exposed, false otherwise.
    static bool IsReferenceContainedByAValidHost(Document doc, Reference reference)
      Description: Identifies whether an element that contains the given reference can host reinforcement.
      @doc: A document.
      @reference: The reference that is part of the element that will be checked.
      Returns: True if the input Element can host reinforcement elements, false otherwise.
    static bool IsValidHost(Element element)
      Description: Identifies whether a given element can host reinforcement.
      @element: The element to check.
      Returns: True if the input Element can host reinforcement elements, false otherwise.
    bool IsValidHost()
      Description: Reports whether the element is a valid rebar host.
      Returns: True if the referenced Element can currently host Rebar elements, false otherwise.
    void SetCommonCoverType(RebarCoverType coverType)
      Description: Associate a single CoverType with all exposed faces of the host element.
      @coverType: A CoverType object to be applied to all faces.
    void SetCoverType(Reference face, RebarCoverType coverType)
      Description: Associates the specified CoverType with the specified face of the element.

--------------------------------------------------------------------------------

[CLASS] RebarInSystem
Full Name: Autodesk.Revit.DB.Structure.RebarInSystem

Description: Represents a rebar element that is part of a system.
Remarks: A RebarInSystem element is part of another element, the "system", which controls most of its properties. The system elements are AreaReinforcement and PathReinforcement. Only a few properties of RebarInSystem are modifiable. Otherwise, the appearance and behavior of RebarInSystem elements is identical to Rebar elements. RebarInSystem elements may be converted to Rebar elements by removing the system element.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double ArrayLength { get; }
      Description: Identifies the distribution path length of rebar set.
    bool BarsOnNormalSide { get; }
      Description: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal. For the current implementation of RebarInSystem, this property will always return true, but it is included in the RebarInSystem interface for consistency with the Rebar class.
    RebarLayoutRule LayoutRule { get; }
      Description: Identifies the layout rule of rebar set.
    double MaxSpacing { get; }
      Description: Identifies the maximum spacing between rebar in rebar set.
    XYZ Normal { get; }
      Description: A unit-length vector normal to the plane of the rebar
    int NumberOfBarPositions { get; }
      Description: The number of bar positions available in the rebar.
    int Quantity { get; }
      Description: Identifies the number of bars in rebar set.
    ElementId RebarShapeId { get; }
      Description: The RebarShape element that defines the shape of the rebar.
    string ScheduleMark { get; set; }
      Description: The Schedule Mark parameter. On creation, the Schedule Mark is set to a value that is unique to the host, but it can be set to any value.
    ElementId SystemId { get; }
      Description: The Id of an AreaReinforcement or PathReinforcement element that owns this element.
    double TotalLength { get; }
      Description: The length of an individual bar multiplied by Quantity.
    double Volume { get; }
      Description: The volume of an individual bar multiplied by Quantity.

  METHODS:
    bool CanApplyPresentationMode(View dBView)
      Description: Checks if a presentation mode can be applied for this rebar in the given view.
      @dBView: The view in which presentation mode will be applied.
      Returns: True if a presentation mode can be applied for the given view, false otherwise.
    bool CanEditIndividualBars()
      Description: Checks if individual bars can be moved, excluded or included.
      Returns: True if individual bars can be moved, excluded or included, false otherwise.
    void ClearPresentationMode(View dBView)
      Description: Sets the presentation mode for this rebar set to the default (either for a single view, or for all views).
      @dBView: The view where the presentation mode will be cleared. NULL for all views
    bool DoesBarExistAtPosition(int barPosition)
      Description: Checks whether a bar is included at the specified position.
      @barPosition: A bar position index between 0 and NumberOfBarPositions-1.
      Returns: Returns true if the bar at the specified position is included, false otherwise.
    RebarPresentationMode FindMatchingPredefinedPresentationMode(View dBView)
      Description: Determines if there is a matching RebarPresentationMode for the current set of selected hidden and unhidden bars assigned to the given view.
      @dBView: The view.
      Returns: The presentation mode that matches the current set of selected hidden and unhidden bars. If there is no better match, this returns RebarPresentationMode.Select.
    int GetBarIndexFromReference(Reference barReference)
      Description: Given a reference that represents a part of a bar, this method will return the bar index.
      @barReference: The Reference of the RebarInSystem element.
      Returns: The bar index the reference refers to.
    Transform GetBarPositionTransform(int barPositionIndex)
      Description: Return a transform representing the relative position of any individual bar in the set.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      Returns: The position of a bar in the set relative to the first position.
    RebarBendData GetBendData()
      Description: Gets the RebarBendData, containing bar and hook information, of the instance.
    IList<Curve> GetCenterlineCurves(bool adjustForSelfIntersection, bool suppressHooks, bool suppressBendRadius)
      Description: A chain of curves representing the centerline of the rebar.
      @adjustForSelfIntersection: If the curves overlap, as in a planar stirrup, this parameter controls whether they should be adjusted to avoid intersection (as in fine views), or kept in a single plane for simplicity (as in coarse views).
      @suppressHooks: Identifies if the chain will include hooks curves.
      @suppressBendRadius: Identifies if the connected chain will include unfilleted curves.
      Returns: The centerline curves or empty array if the curves cannot be computed because the parameters values are inconsistent with the constraints of the RebarShape definition.
    Line GetDistributionPath()
      Description: The distribution path of a rebar set.
      Returns: A line beginning at (0, 0, 0) and representing the direction and length of the set.
    ElementId GetHookTypeId(int end)
      Description: Get the id of the RebarHookType to be applied to the rebar.
      @end: 0 for the start hook, 1 for the end hook.
      Returns: The id of a RebarHookType, or invalidElementId if the rebar has no hook at the specified end.
    ElementId GetHostId()
      Description: The element that contains the rebar.
      Returns: The element that the rebar object belongs to, such as a structural wall, floor, foundation, beam, brace or column.
    Transform GetMovedBarTransform(int barPositionIndex)
      Description: Returns a transform representing the movement of the bar relative to its default position along the distribution path.
      @barPositionIndex: The bar index.
      Returns: The transform representing the movement of the bar relative to its default position along the distribution path.
    RebarPresentationMode GetPresentationMode(View dBView)
      Description: Gets the presentaion mode for this rebar set when displayed in the given view.
      @dBView: The view.
      Returns: The presentation mode.
    RebarRoundingManager GetReinforcementRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings.
      Returns: The rounding manager.
    IList<Curve> GetTransformedCenterlineCurves(bool adjustForSelfIntersection, bool suppressHooks, bool suppressBendRadius, int barPositionIndex)
      Description: A chain of curves representing the centerline of the rebar.
      @adjustForSelfIntersection: If the curves overlap, as in a planar stirrup, this parameter controls whether they should be adjusted to avoid intersection (as in fine views), or kept in a single plane for simplicity (as in coarse views).
      @suppressHooks: Identifies if the chain will include hooks curves.
      @suppressBendRadius: Identifies if the connected chain will include unfilleted curves.
      @barPositionIndex: The bar index.
      Returns: The centerline curves or empty array if the curves cannot be computed because the parameters values are inconsistent with the constraints of the RebarShape definition.
    bool HasPresentationOverrides(View dBView)
      Description: Identifies if this RebarInSystem has overridden default presentation settings for the given view.
      @dBView: The view.
      Returns: True if this RebarInSystem has overriden default presentation settings, false otherwise.
    bool IsBarHidden(View view, int barIndex)
      Description: Identifies if a given bar in this rebar set is hidden in this view.
      @view: The view.
      @barIndex: The index of the bar from this rebar set.
      Returns: True if the bar is hidden in this view, false otherwise.
    bool IsRebarInSection(View dBView)
      Description: Identifies if this RebarInSystem is cut by the view plane of the given view.
      @dBView: The view.
      Returns: True if this RebarInSystem is cut by the view plane, false otherwise.
    bool IsUnobscuredInView(View view)
      Description: Checks if this rebar element is shown unobscured in a view.
      @view: The view element
      Returns: True if rebar is shown unobscured, false otherwise.
    void MoveBarInSet(int barPositionIndex, Transform moveTransform)
      Description: This method applies the transformation matrix to the rebar bar at the desired position in the rebar set. If the bar was already moved, the method will concatenate the transformation matrix with the existing movement.
      @barPositionIndex: The bar index of the rebar to apply the transformation.
      @moveTransform: The transformation matrix to apply to the specified rebar bar.
    void ResetMovedBarTransform(int barPositionIndex)
      Description: Reset the transformation representing the movement of the bar relative to its default position along the distribution path. The moved bar transform will be set to Identity.
      @barPositionIndex: The bar index.
    void SetBarHiddenStatus(View view, int barIndex, bool hide)
      Description: Sets the bar in this rebar set to be hidden or unhidden in the given view.
      @view: The view.
      @barIndex: The index of the bar from this set.
      @hide: True to hide this bar in the view, false to unhide the bar.
    void SetBarIncluded(bool include, int barPositionIndex)
      Description: Sets if the bar at the desired index is included or not.
      @include: True to include the bar, false to exclude the bar.
      @barPositionIndex: The bar index.
    void SetPresentationMode(View dBView, RebarPresentationMode presentationMode)
      Description: Sets the presentation mode for this rebar set when displayed in the given view.
      @dBView: The view.
      @presentationMode: The presentation mode.
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets RebarInSystem element to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if RebarInSystem element is shown unobscured, false otherwise.

--------------------------------------------------------------------------------

[ENUM] RebarLayoutRule
Full Name: Autodesk.Revit.DB.Structure.RebarLayoutRule

Description: The rule for how the rebars in rebar set are laid out
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Single = 0
    - FixedNumber = 1
    - MaximumSpacing = 2
    - NumberWithSpacing = 3
    - MinimumClearSpacing = 4

[ENUM] RebarPresentationMode
Full Name: Autodesk.Revit.DB.Structure.RebarPresentationMode

Description: Bar presentation mode
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - All = 0
    - FirstLast = 1
    - Middle = 2
    - Select = 3

[ABSTRACT CLASS] RebarPropagation
Full Name: Autodesk.Revit.DB.Structure.RebarPropagation

Description: An utility class containing functions that can be used to propagate rebar elements.

  METHODS:
    static ISet<ElementId> AlignByFace(Document doc, IList<Rebar> sourceRebars, Reference sourceFaceReference, Reference destinationFaceReference)
      Description: It will copy the source rebars, will align them to the destination face based on the source face and adapt them to destination host.
      @doc: A document.
      @sourceRebars: The rebars that will be propagated. All of them must be from the same host as the source face reference.
      @sourceFaceReference: A reference to a face in the source host.
      @destinationFaceReference: A reference to a face in the destions host.
      Returns: The newly created rebars.
    static ISet<ElementId> AlignByHost(Document doc, IList<Rebar> sourceRebars, Element destinationHost)
      Description: It will copy the source rebars, will align them in the same way as how the source host is aligned to destination host and will adapt them to the destinaion host.
      @doc: A document.
      @sourceRebars: The rebars that will be propagated. All of them must be from the same host.
      @destinationHost: The destination host where the new rebar will be created.
      Returns: The newly created rebars.

--------------------------------------------------------------------------------

[CLASS] RebarReinforcementData
Full Name: Autodesk.Revit.DB.Structure.RebarReinforcementData

Description: class containing the id and the end of rebar on which the coupler stays
Inherits: ReinforcementData
Implements: IDisposable

  PROPERTIES:
    int End { get; set; }
      Description: The end of the rebar. The end should be 0 or 1.
    ElementId RebarId { get; set; }
      Description: The id of the Rebar

  METHODS:
    static RebarReinforcementData Create(ElementId rebarId, int iEnd)
      Description: Creates a new instance of RebarReinforcementData, or if the operation fails.
      @rebarId: the Id of the rebar
      @iEnd: The end of rebar where the coupler stays. This should be 0 or 1
      Returns: Creates a new instance of RebarReinforcementData

--------------------------------------------------------------------------------

[CLASS] RebarRoundingManager
Full Name: Autodesk.Revit.DB.Structure.RebarRoundingManager

Description: Provides access to element reinforcement roundings overrides.
Remarks: An instance of this class can be obtained from specific RebarTypes or individual Rebar or RebarInSystem elements to apply overrides different from the global settings for the project.
Inherits: ReinforcementRoundingManager
Implements: IDisposable

  PROPERTIES:
    ReinforcementRoundingSource ApplicableReinforcementRoundingSource { get; }
      Description: Identifies the source of the rounding settings for this element.
    double ApplicableSegmentLengthRounding { get; }
      Description: The applicable rounding for shared parameters used by rebar.
    RoundingMethod ApplicableSegmentLengthRoundingMethod { get; }
      Description: The applicable rounding method for shared parameters used by rebar.
    double ApplicableTotalLengthRounding { get; }
      Description: The applicable rounding for Bar Length and Total Bar Length parameters.
    RoundingMethod ApplicableTotalLengthRoundingMethod { get; }
      Description: The applicable rounding method for Bar Length and Total Bar Length parameters.
    double SegmentLengthRounding { get; set; }
      Description: The rounding for shared parameters used by rebar.
    RoundingMethod SegmentLengthRoundingMethod { get; set; }
      Description: Identifies the segment length rounding method
    double TotalLengthRounding { get; set; }
      Description: The rounding for Bar Length and Total Bar Length parameters.
    RoundingMethod TotalLengthRoundingMethod { get; set; }
      Description: Identifies the total length rounding method

--------------------------------------------------------------------------------

[CLASS] RebarShape
Full Name: Autodesk.Revit.DB.Structure.RebarShape

Description: RebarShape specifies the shape type for a Rebar instance.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    int HigherEnd { get; }
      Description: Defines the higher end of rebar shape.
    RebarStyle RebarStyle { get; }
      Description: Whether the shape represents a standard bar or a stirrup.
    ElementId ShapeFamilyId { get; }
      Description: Get and return the rebar shape family id.
    bool SimpleArc { get; }
      Description: Check whether this shape consists of a single arc, possibly with hooks.
    bool SimpleLine { get; }
      Description: Check whether this shape consists of a single straight segment, possibly with hooks.
    StirrupTieAttachmentType StirrupTieAttachment { get; }
      Description: The attachment type of stirrup ties and rebars.

  METHODS:
    static RebarShape Create(Document doc, RebarShapeDefinition definition, RebarShapeMultiplanarDefinition multiplanarDefinition, RebarStyle style, StirrupTieAttachmentType attachmentType, int startHookAngle, RebarHookOrientation startHookOrientation, int endHookAngle, RebarHookOrientation endHookOrientation, int higherEnd, double hookRotationAngleAtStart, double hookRotationAngleAtEnd, ElementId endTreatmentTypeIdAtStart, ElementId endTreatmentTypeIdAtEnd)
      Description: Create a new instance of a Rebar Shape, which defines the shape of a rebar.
      @doc: A document to contain the RebarShape.
      @definition: The definition of the rebar shape, as a set of curves in a plane driven by parameters.
      @multiplanarDefinition: If not , the created RebarShape will be a 3D shape. The shape is built out of the planar RebarShapeDefinition, with additional out-of-plane segments defined by the RebarShapeMultiplanarDefinition object. Not supported in conjunction with RebarShapeDefinitionByArc of type Spiral or LappedCircle.
      @style: Whether the shape is to be used as a standard bar or a stirrup/tie.
      @attachmentType: When the style is stirrup/tie, specify whether it will attach to the interior of cover (cover is measured to the stirrups), or to the exterior of cover (cover is measured to the standard bars). Ignored when the style is Standard.
      @startHookAngle: The start hook angle, expressed as an integral number of degrees. If 0, the shape will have no start hook. Common values are 0, 90, 135, and 180.
      @startHookOrientation: The orientation of the start hook. Ignored when startHookAngle is 0.
      @endHookAngle: The end hook angle, expressed as an integral number of degrees. If 0, the shape will have no end hook. Common values are 0, 90, 135, and 180.
      @endHookOrientation: The orientation of the end hook. Ignored when endHookAngle is 0.
      @higherEnd: When the rebar crosses itself, one end will be "lifted" to avoid self-intersection. Specify which end should be lifted: 0 for start, 1 for end.
      @hookRotationAngleAtStart: The out of plane hook rotation angle at the start of the bar.
      @hookRotationAngleAtEnd: The out of plane hook rotation angle at the end of the bar.
      @endTreatmentTypeIdAtStart: The end treatment type id at the start of the bar.
      @endTreatmentTypeIdAtEnd: The end treatment type id at the end of the bar.
      Returns: A new RebarShape instance.
    static RebarShape Create(Document doc, RebarShapeDefinition definition, RebarShapeMultiplanarDefinition multiplanarDefinition, RebarStyle style, StirrupTieAttachmentType attachmentType, int startHookAngle, RebarHookOrientation startHookOrientation, int endHookAngle, RebarHookOrientation endHookOrientation, int higherEnd)
      Description: Create a new instance of a Rebar Shape, which defines the shape of a rebar.
      @doc: A document to contain the RebarShape.
      @definition: The definition of the rebar shape, as a set of curves in a plane driven by parameters.
      @multiplanarDefinition: If not null, the created RebarShape will be a 3D shape. The shape is built out of the planar RebarShapeDefinition, with additional out-of-plane segments defined by the RebarShapeMultiplanarDefinition object. Not supported in conjunction with RebarShapeDefinitionByArc of type Spiral or LappedCircle.
      @style: Whether the shape is to be used as a standard bar or a stirrup/tie.
      @attachmentType: When the style is stirrup/tie, specify whether it will attach to the interior of cover (cover is measured to the stirrups), or to the exterior of cover (cover is measured to the standard bars). Ignored when the style is Standard.
      @startHookAngle: The start hook angle, expressed as an integral number of degrees. If 0, the shape will have no start hook. Common values are 0, 90, 135, and 180.
      @startHookOrientation: The orientation of the start hook. Ignored when startHookAngle is 0.
      @endHookAngle: The end hook angle, expressed as an integral number of degrees. If 0, the shape will have no end hook. Common values are 0, 90, 135, and 180.
      @endHookOrientation: The orientation of the end hook. Ignored when endHookAngle is 0.
      @higherEnd: When the rebar crosses itself, one end will be "lifted" to avoid self-intersection. Specify which end should be lifted: 0 for start, 1 for end.
      Returns: A new RebarShape instance.
    bool GetAllowed(RebarBarType barType)
      Description: Check whether a bar type can be used with this RebarShape. Bar types are allowed by default.
      @barType: A bar type in the same document as this shape.
      Returns: True if this shape may be combined with this barType.
    IList<Curve> GetCurvesForBrowser()
      Description: Generate curves for the shape, as used in the shape browser.
      Returns: An array of curves representing the shape with its default parameters.
    int GetDefaultHookAngle(int index)
      Description: Get the hook angle, expressed as an integral number of degrees (common values are 0, 90, 135, and 180).
      @index: 0 for the starting hook, 1 for the ending hook.
    RebarHookOrientation GetDefaultHookOrientation(int index)
      Description: Get the hook orientation.
      @index: 0 for the starting hook, 1 for the ending hook.
    ElementId GetEndTreatmentTypeId(int iEnd)
      Description: Gets the id of the EndTreatmentType at the specified rebar shape end.
      @iEnd: 0 for the start end treatment, 1 for the end end treatment.
      Returns: Returns the id of an EndTreatmentType, or invalidElementId if the rebar shape has no end treatment at the specified end.
    double GetHookRotationAngle(int iEnd)
      Description: Gets the out of plane hook rotation angle at the specified end.
      @iEnd: 0 for the start , 1 for the end.
      Returns: Returns the out of plane hook rotation angle at the specified end.
    RebarShapeMultiplanarDefinition GetMultiplanarDefinition()
      Description: The optional 3D structure of the shape.
      Returns: A copy of the multiplanar definition. Changes will not affect the RebarShape.
    RebarShapeDefinition GetRebarShapeDefinition()
      Description: Return the definition of the RebarShape.
      Returns: A copy of the definition. Changes will not affect the RebarShape.
    bool HasEndTreatment()
      Description: Identifies if the rebar shape has end treatment at at least one end.
      Returns: Returns true if the rebar shape has end treatment for at least one end, false otherwise.
    bool IsSameShapeIgnoringHooks(RebarShape otherShape)
      Description: Test whether two shapes have equivalent definitions by comparing the RebarShapeDefinition and MultiplanarDefinition properties.
      @otherShape: Another shape to be compared to this one.
      Returns: True if the shape definitions match, false otherwise.
    void SetAllowed(RebarBarType barType, bool allowed)
      Description: Specify which bar types can be used with this RebarShape. Bar types are allowed by default.
      @barType: A bar type in the same document as this shape.
      @allowed: Whether this shape may be combined with barType.
    void SetEndTreatmentTypeId(ElementId endTreatmentId, int iEnd)
      Description: Sets the EndTreatmentType id at the specified rebar shape end.
      @endTreatmentId: The id of an EndTreatmentType element, or invalidElementId if the rebar shape should have no end treatment at the specified end.
      @iEnd: 0 for the start end treatment, 1 for the end end treatment.
    void SetHookRotationAngle(double hookRotationAngle, int iEnd)
      Description: Sets the out of plane hook rotation angle at the specified end.
      @hookRotationAngle: The out of plane hook rotation angle at the specified end.
      @iEnd: 0 for the start , 1 for the end.

--------------------------------------------------------------------------------

[ENUM] RebarShapeArcReferenceType
Full Name: Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType

Description: A Rebar Shape Definition constraint that is measured to a bend must take the bar diameter into account by specifying whether it measures to the exterior, centerline, or interior of the bend.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Centerline = 0
    - External = 1
    - Internal = -1

[ENUM] RebarShapeBendAngle
Full Name: Autodesk.Revit.DB.Structure.RebarShapeBendAngle

Description: A bend in a rebar shape has an angular range specified by one of these values. The angles refer to the angle swept out by one segment as it is bent relative to another. That is, an "Obtuse" bend results in two segments that meet at an angle that is less than 90 degrees when measured internally. Put another way, to create an equilateral triangle, you would need two "Obtuse" bends.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Acute = 1
    - Right = 2
    - Obtuse = 3

[CLASS] RebarShapeConstraint
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraint

Description: A dimension or other constraint that takes part in a RebarShapeDefinition.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ElementId GetParamId()
      Description: Return the Id of the parameter associated with this constraint.
      Returns: The Id of the parameter, or InvalidElementId if the constraint does not have one.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraint180DegreeBendArcLength
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendArcLength

Description: A constraint which can be applied to a RebarShapeSegment, and causes the segment to be replaced with a 180-degree arc. The associated parameter drives the arc length.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraint180DegreeBendArcLength(ElementId paramId)

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraint180DegreeBendRadius
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeBendRadius

Description: A constraint which can be applied to a RebarShapeSegment, and causes the segment to be replaced with a 180-degree arc. The associated parameter drives the radius of the arc.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraint180DegreeBendRadius(ElementId paramId, RebarShapeArcReferenceType refType)

  PROPERTIES:
    RebarShapeArcReferenceType ArcReferenceType { get; }
      Description: A choice of rule for measuring the radius.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraint180DegreeDefaultBend
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraint180DegreeDefaultBend

Description: A constraint which can be applied to a RebarShapeSegment, and causes the segment to be replaced with a 180-degree arc. The arc's radius is not specified by the shape; instead it is a "default bend radius," taken from the RebarBarType associated with the Rebar instance.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraint180DegreeDefaultBend()

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintAngleFromFixedDir
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintAngleFromFixedDir

Description: A constraint which can be applied to a RebarShapeSegment and drives the angle of the segment relative to a fixed direction in UV-space.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintAngleFromFixedDir(ElementId paramId, int sign, UV direction)

  PROPERTIES:
    UV Direction { get; set; }
      Description: A fixed direction in UV-space. The parameter will drive the segment's angle relative to this direction.
    int Sign { get; set; }
      Description: When the sign is 1, the Direction is rotated clockwise by the angle's value. When -1, the Direction is rotated counter-clockwise.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintArcLength
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintArcLength

Description: An arc-length constraint associated with an arc in a RebarShapeDefinition.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintArcLength(ElementId paramId)

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintChordLength
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintChordLength

Description: A constraint that can be applied to a RebarShapeDefinitionByArc and drives the straight distance between the arc endpoints.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintChordLength(ElementId paramId)

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintCircumference
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintCircumference

Description: A circumference constraint associated with an arc in a RebarShapeDefinition.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintCircumference(ElementId paramId, RebarShapeArcReferenceType refType)

  PROPERTIES:
    RebarShapeArcReferenceType ArcReferenceType { get; }
      Description: The choice of rule for measuring the diameter.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintDiameter
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintDiameter

Description: A diameter constraint associated with an arc in a RebarShapeDefinition.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintDiameter(ElementId paramId, RebarShapeArcReferenceType refType)

  PROPERTIES:
    RebarShapeArcReferenceType ArcReferenceType { get; }
      Description: The choice of rule for measuring the diameter.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintFixedSegmentDir
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintFixedSegmentDir

Description: A constraint that can be applied to a RebarShapeSegment and fixes the direction of the segment in UV-space.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintFixedSegmentDir(UV dir)

  PROPERTIES:
    UV Direction { get; set; }
      Description: The direction of the RebarShapeSegment in UV-space.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintProjectedSegmentLength
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintProjectedSegmentLength

Description: A constraint that measures the length of a segment as measured by projecting onto a direction that is not parallel to the segment.
Remarks: The constraint has two references, indexed by 0 and 1, that do not have to correspond to the start and end of the segment. The constraint also specifies a direction as a 2D vector, which is not necessarily parallel to the segment, but must point from the segment's start toward its end.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintProjectedSegmentLength(ElementId paramId, UV direction, int tripleProductSign, RebarShapeSegmentEndReferenceType refType0, RebarShapeSegmentEndReferenceType refType1)

  PROPERTIES:
    UV Direction { get; }
      Description: A vector specifying the direction of the constraint. The direction is fixed, and the shape is always constructed so that the segment direction has a positive dot product with this vector.
    int TripleProductSign { get; }
      Description: Sign of the z-coordinate of the cross product of the Direction property with the segment vector. TripleProductSign is 1 if the segment direction is to be on the left of the constraint direction, or -1 if the segment direction is to be on the right.

  METHODS:
    RebarShapeSegmentEndReferenceType GetSegmentEndReferenceType(int index)
      Description: Choice of two possibilities for the start and end references of the length constraint.
      @index: Which reference on the constraint. Either 0 or 1.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintRadius
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintRadius

Description: A radius constraint associated with an arc in a RebarShapeDefinition.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintRadius(ElementId paramId, RebarShapeArcReferenceType refType)

  PROPERTIES:
    RebarShapeArcReferenceType ArcReferenceType { get; }
      Description: The choice of rule for measuring the radius.

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintSagittaLength
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintSagittaLength

Description: A constraint that can be applied to a RebarShapeDefinitionByArc and drives the height of the arc.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintSagittaLength(ElementId paramId)

--------------------------------------------------------------------------------

[CLASS] RebarShapeConstraintSegmentLength
Full Name: Autodesk.Revit.DB.Structure.RebarShapeConstraintSegmentLength

Description: A constraint that controls the length of a segment.
Remarks: The constraint has two references, indexed by 0 and 1, that do not have to correspond to the start and end of the segment.
Inherits: RebarShapeConstraint
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeConstraintSegmentLength(ElementId paramId, RebarShapeSegmentEndReferenceType refType0, RebarShapeSegmentEndReferenceType refType1)

  METHODS:
    RebarShapeSegmentEndReferenceType GetSegmentEndReferenceType(int index)
      Description: Choice of two possibilities for the start and end references of the length constraint.
      @index: Which reference on the constraint. Either 0 or 1.

--------------------------------------------------------------------------------

[CLASS] RebarShapeDefinition
Full Name: Autodesk.Revit.DB.Structure.RebarShapeDefinition

Description: A class to assist in defining rebar shapes. A RebarShape element needs exactly one RebarShapeDefinition.
Remarks: A RebarShapeDefinition stores a set of Rebar Shape parameters. Each parameter may be associated with: One or more RebarShapeConstraints; orA formula; orNeither of the above. Each shape instance (Rebar object) will have its own values for these parameters. The RebarShapeDefinition also stores a default value for each parameter, which is ignored if the parameter is associated with a formula.
Implements: IDisposable

  PROPERTIES:
    bool Complete { get; }
      Description: Report whether the shape definition is fully constrained.
    bool IsPlanar { get; }
      Description: Reports whether the shape definition lies within a plane: false if a spiral, true in all other cases.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddFormulaParameter(ElementId paramId, string formula)
      Description: Add a formula-driven parameter to the shape definition.
      @paramId: The parameter. To obtain the id of a shared parameter, call RebarShapeParameters.GetElementIdForExternalDefinition.
      @formula: The formula expressed as a string. The string is exactly what a user would type into the Family Types dialog, e.g. "Total Length*3.14159*(Bar Diameter/2)*(Bar Diameter/2)"
    void AddParameter(ElementId paramId, double defaultValue)
      Description: Add a parameter to the shape definition.
      @paramId: The parameter. To obtain the id of a shared parameter, call RebarShapeParameters.GetElementIdForExternalDefinition.
      @defaultValue: A default value for this parameter in shapes. The default values should be chosen carefully, because they are required to be consistent as a set of constraints.
    bool CheckDefaultParameterValues(double bendRadius, double barDiameter)
      Description: Check that the shape can be solved with the default parameter values.
      @bendRadius: A value for the Bend Radius parameter. Zero is allowed.
      @barDiameter: A value for the Bar Diameter parameter. Zero is allowed.
      Returns: True if the rebar can be solved with the default parameter values and the given bend radius and bar diameter; false if it cannot.
    void Dispose()
    double GetParameterDefaultValue(ElementId paramId)
      Description: Return the parameter's default value as stored in the definition.
      @paramId: Id of a parameter in the definition.
      Returns: The parameter value.
    string GetParameterFormula(ElementId paramId)
      Description: Return the parameter's formula, if one is associated with it.
      @paramId: Id of a parameter in the definition.
      Returns: The formula, or an empty string if there is no formula for the parameter.
    IList<ElementId> GetParameters()
      Description: Return the Ids of the shared parameters in the Definition.
      Returns: List of parameters as ElementIds.
    bool HasParameter(ElementId paramId)
      Description: Whether the definition stores the parameter.
      @paramId: Id of a parameter.
      Returns: True if the definition stores the parameter, false otherwise.
    void RemoveParameter(ElementId paramId)
      Description: Remove the parameter from the definition.
      @paramId: Id of a parameter in the definition.
    void SetParameterDefaultValue(ElementId paramId, double value)
      Description: Change the parameter's value as stored in the definition.
      @paramId: Id of a parameter in the definition.
      @value: New value for the parameter.
    void SetParameterFormula(ElementId paramId, string formula)
      Description: Associate a formula with the parameter.
      @paramId: Id of a parameter in the definition.
      @formula: The formula expressed as a string. The string is exactly what a user would type into the Family Types dialog, e.g. "Total Length*3.14159*(Bar Diameter/2)*(Bar Diameter/2)"

--------------------------------------------------------------------------------

[CLASS] RebarShapeDefinitionByArc
Full Name: Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArc

Description: Definition of a shape whose size and position can determined by a single arc.
Remarks: In this shape definition, all dimensions are allowed to be driving dimensions.
Inherits: RebarShapeDefinition
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeDefinitionByArc(Document doc, double height, double pitch, int baseFinishingTurns, int topFinishingTurns)
    new RebarShapeDefinitionByArc(Document doc, RebarShapeDefinitionByArcType type)

  PROPERTIES:
    RebarShapeDefinitionByArcType Type { get; set; }
      Description: Among those rebar shapes defined by an arc, specify which kind.

  METHODS:
    void AddConstraintArcLength(ElementId paramId)
      Description: Specify a parameter to drive the arc length of the shape.
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
    void AddConstraintChordLength(ElementId paramId)
      Description: Specify a parameter to drive the chord length (the straight-line distance between the endpoints of the arc).
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
    void AddConstraintCircumference(ElementId paramId, RebarShapeArcReferenceType arcRefType)
      Description: Specify a parameter to drive the circumference of the shape.
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
      @arcRefType: Specify along which circle the circumference is measured--to the interior of the bar, the centerline, or the exterior.
    void AddConstraintDiameter(ElementId paramId, RebarShapeArcReferenceType arcRefType)
      Description: Specify a parameter to drive the diameter of the shape.
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
      @arcRefType: Specify how the diameter should be measured--to the interior of the bend, the centerline of the bar, or the exterior.
    void AddConstraintRadius(ElementId paramId, RebarShapeArcReferenceType arcRefType)
      Description: Specify a parameter to drive the radius of the shape.
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
      @arcRefType: Specify how the radius should be measured--to the interior of the bend, the centerline of the bar, or the exterior.
    void AddConstraintSagittaLength(ElementId paramId)
      Description: Specify a parameter to drive the sagittal length (the height of the circular segment, measured perpendicular to the chord).
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
    IList<RebarShapeConstraint> GetConstraints()
      Description: Retrieve the list of constraints associated with this definition.
      Returns: The list of constraints.
    void SetArcTypeSpiral(double height, double pitch, int baseFinishingTurns, int topFinishingTurns)
      Description: Set the RebarShapeDefinitionByArc.Type property to Spiral.
      @height: The height of the spiral (assuming the spiral is vertical).
      @pitch: The pitch, or vertical distance traveled in one rotation.
      @baseFinishingTurns: The number of finishing turns at the lower end of the spiral.
      @topFinishingTurns: The number of finishing turns at the upper end of the spiral.
    void SetConstraints(IList<RebarShapeConstraint> constraints)
      Description: Assign a new list of constraints to this definition.
      @constraints: A new list of constraints.

--------------------------------------------------------------------------------

[ENUM] RebarShapeDefinitionByArcType
Full Name: Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType

Description: A RebarShapeDefinitionByArc takes one of three forms.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Arc = 0
    - LappedCircle = 1
    - Spiral = 2

[CLASS] RebarShapeDefinitionBySegments
Full Name: Autodesk.Revit.DB.Structure.RebarShapeDefinitionBySegments

Description: Definition of a shape in terms of one or more straight segments of rebar, with arc bends between the segments.
Remarks: The segments are represented by RebarShapeSegment objects. The segments are numbered starting with 0, and they have a direction; so the beginning of the shape is end 0 of segment 0, and the end of the shape is end 1 of segment (NumberOfSegments-1). The ends and junctions are represented by RebarShapeVertex objects. The number of vertices is always one greater than the number of segments. The first vertex represents the start of the shape; the last vertex represents the end of the shape; and the intermediate vertices represent the bends between segments.
Inherits: RebarShapeDefinition
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeDefinitionBySegments(Document doc, int numberOfSegments)

  PROPERTIES:
    int MajorSegmentIndex { get; set; }
      Description: Index of a segment that can be considered the most important. Revit attempts to preserve the orientation of this segment when a Rebar instance changes its RebarShape to one with a different number of segments.
    int NumberOfSegments { get; }
      Description: The number of straight segments in this shape.
    int NumberOfVertices { get; }
      Description: The number of vertices in this shape, always equal to NumberOfSegments + 1.

  METHODS:
    void AddBendDefaultRadius(int vertexIndex, RebarShapeVertexTurn turn, RebarShapeBendAngle angle)
      Description: Specify a default-radius bend.
      @vertexIndex: Index of the vertex (1 to NumberOfVertices - 2).
      @turn: Specify turn direction (RebarShapeVertexTurn::Left or RebarShapeVertexTurn::Right).
      @angle: Specify whether the bend is acute, obtuse, etc.
    void AddBendVariableRadius(int vertexIndex, RebarShapeVertexTurn turn, RebarShapeBendAngle angle, ElementId paramId, bool measureIncludingBarThickness)
      Description: Specify a variable-radius bend.
      @vertexIndex: Index of the vertex (1 to NumberOfVertices - 2).
      @turn: Specify turn direction (RebarShapeVertexTurn::Left or RebarShapeVertexTurn::Right).
      @angle: Specify whether the bend is acute, obtuse, etc.
      @paramId: Id of a parameter driving the radius.
      @measureIncludingBarThickness: If true, the radius is measured to the outside of the bend; if false, it is measured to the inside.
    void AddConstraintParallelToSegment(int iSegment, ElementId paramId, bool measureToOutsideOfBend0, bool measureToOutsideOfBend1)
      Description: Constrain the length of a segment by parameterizing its length.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
      @measureToOutsideOfBend0: Choose between two possibilities for the first reference of the length dimension. If false, the reference is at the point where the bend begins; equivalently, at the projection of the bend centerpoint onto the segment. If true, the reference is moved outward by a distance equal to the bend radius plus the bar diameter; if the bend is a right angle or greater, this is equivalent to putting the reference at the outer face of the bend.
      @measureToOutsideOfBend1: Choose between two possibilities for the second reference of the length dimension.
    void AddConstraintToSegment(int iSegment, ElementId paramId, double constraintDirCoordX, double constraintDirCoordY, int signOfZCoordOfCrossProductOfConstraintDirBySegmentDir, bool measureToOutsideOfBend0, bool measureToOutsideOfBend1)
      Description: Add a constraint that helps determine the length of a segment.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).
      @paramId: Id of a parameter to drive the constraint. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
      @constraintDirCoordX: The x-coordinate of a 2D vector specifying the constraint direction.
      @constraintDirCoordY: The y-coordinate of a 2D vector specifying the constraint direction.
      @signOfZCoordOfCrossProductOfConstraintDirBySegmentDir: Legal values are 1 and -1. For a fixed-direction segment, this value is ignored. For a variable-direction segment, this value is combined with the constraint length (the nonnegative value associated with 'param') to determine the direction of the segment. For example, a segment whose direction vector lies in the upper-right quadrant of the plane, and whose x-axis projected length is A and whose y-axis projected length is B, could be created by calling: AddConstraintToSegment(iSegment, paramA, 1.0, 0.0, 1, ...) AddConstraintToSegment(iSegment, paramB, 0.0, 1.0, -1, ...)
      @measureToOutsideOfBend0: Choose between two possibilities for the first reference of the length dimension. If false, the reference is at the point where the bend begins; equivalently, at the projection of the bend centerpoint onto the segment. If true, the reference is moved outward by a distance equal to the bend radius plus the bar diameter; if the bend is a right angle or greater, this is equivalent to putting the reference at the outer face of the bend.
      @measureToOutsideOfBend1: Choose between two possibilities for the second reference of the length dimension.
    void AddListeningDimensionBendToBend(ElementId paramId, double constraintDirCoordX, double constraintDirCoordY, int iSegment0, int iEnd0, int iSegment1, int iEnd1)
      Description: Specify a dimension between two bends, measured by a read-only parameter.
      @paramId: Id of a parameter to report the length of the dimension. The parameter will be read-only on Rebar instances.
      @constraintDirCoordX: The x-coordinate of a 2D vector specifying the constraint direction.
      @constraintDirCoordY: The y-coordinate of a 2D vector specifying the constraint direction.
      @iSegment0: Index of the first segment (0 to NumberOfSegments - 1).
      @iEnd0: End (0 or 1) of the first segment.
      @iSegment1: Index of the second segment (0 to NumberOfSegments - 1).
      @iEnd1: End (0 or 1) of the second segment.
    void AddListeningDimensionSegmentToBend(ElementId paramId, double constraintDirCoordX, double constraintDirCoordY, int iSegment0, int iSegment1, int iEnd1)
      Description: Specify a dimension perpendicular to one fixed-direction segment, referring to that segment and some other bend in the shape, measured by a read-only parameter.
      @paramId: Id of a parameter to report the length of the dimension. The parameter will be read-only on Rebar instances.
      @constraintDirCoordX: The x-coordinate of a 2D vector specifying the constraint direction.
      @constraintDirCoordY: The y-coordinate of a 2D vector specifying the constraint direction.
      @iSegment0: Index of the first segment (0 to NumberOfSegments - 1).
      @iSegment1: Index of the second segment (0 to NumberOfSegments - 1).
      @iEnd1: End (0 or 1) of the second segment.
    void AddListeningDimensionSegmentToSegment(ElementId paramId, double constraintDirCoordX, double constraintDirCoordY, int iSegment0, int iSegment1)
      Description: Specify a dimension perpendicular to two fixed-direction segments, measured by a read-only parameter.
      @paramId: Id of a parameter to report the length of the dimension. The parameter will be read-only on Rebar instances.
      @constraintDirCoordX: The x-coordinate of a 2D vector specifying the constraint direction.
      @constraintDirCoordY: The y-coordinate of a 2D vector specifying the constraint direction.
      @iSegment0: Index of the first segment (0 to NumberOfSegments - 1).
      @iSegment1: Index of the second segment (0 to NumberOfSegments - 1).
    RebarShapeSegment GetSegment(int segmentIndex)
      Description: Return a reference to one of the segments in the definition.
      @segmentIndex: Index of the segment (0 to NumberOfSegments - 1).
      Returns: The requested segment.
    RebarShapeVertex GetVertex(int vertexIndex)
      Description: Return a reference to one of the vertices in the definition.
      @vertexIndex: Index of the vertex (0 to NumberOfVertices - 1).
      Returns: The requested vertex.
    void RemoveParameterFromSegment(int iSegment, ElementId paramId)
      Description: Remove constraints from a segment.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).
      @paramId: Id of a parameter driving one or more constraints.
    void SetSegmentAs180DegreeBend(int iSegment, ElementId paramId, bool measureToOutsideOfBend)
      Description: Indicate that a segment is a "virtual" segment introduced to describe a 180-degree bend. The radius of the bend will be driven by radiusParam.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).
      @paramId: Id of a parameter to drive the radius. To obtain the id of a shared parameter, call RebarShape.GetElementIdForExternalDefinition().
      @measureToOutsideOfBend: Choose between two possibilities for the references of the radius dimension. If true, measure to the exterior face of the bar. If false, measure to the interior face.
    void SetSegmentAs180DegreeBend(int iSegment)
      Description: Indicates that a segment is a "virtual" segment introduced to describe a 180-degree bend. The radius of the bend will be taken from the Bar Type.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).
    void SetSegmentFixedDirection(int iSegment, double vecCoordX, double vecCoordY)
      Description: Fix the direction of a segment.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).
      @vecCoordX: The x-coordinate of a 2D vector specifying the segment direction.
      @vecCoordY: The y-coordinate of a 2D vector specifying the segment direction.
    void SetSegmentVariableDirection(int iSegment)
      Description: Remove the fixed direction from a segment.
      @iSegment: Index of the segment (0 to NumberOfSegments - 1).

--------------------------------------------------------------------------------

[CLASS] RebarShapeDrivenAccessor
Full Name: Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor

Description: A class that is used to access the properties and capabilities of shape-driven Rebar.
Remarks: Obtain an instance of this class from . The accessor includes a reference to the Rebar element. If the referenced Rebar element is deleted, using the methods form this class will throw exception.
Implements: IDisposable

  PROPERTIES:
    double ArrayLength { get; set; }
      Description: Identifies the distribution path length of rebar set.
    bool BarsOnNormalSide { get; set; }
      Description: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal.
    int BaseFinishingTurns { get; set; }
      Description: For a spiral, the number of finishing turns at the lower end of the spiral.
    double Height { get; set; }
      Description: For a spiral, the overall height.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MultiplanarDepth { get; set; }
      Description: For a multiplanar rebar, the depth of the instance.
    XYZ Normal { get; }
      Description: A unit-length vector normal to the plane of the rebar
    double Pitch { get; set; }
      Description: For a spiral, the pitch, or vertical distance traveled in one rotation.
    int TopFinishingTurns { get; set; }
      Description: For a spiral, the number of finishing turns at the upper end of the spiral.
    bool UseRebarConstraintsToProduceVaryingBars { get; set; }
      Description: Identifies if the rebar constraints should be used to compute each bar in set (which can produce varying length bars).

  METHODS:
    IList<Curve> ComputeDrivingCurves()
      Description: Compute the driving curves.
      Returns: Returns an empty array if an error is encountered.
    void Dispose()
    void FlipRebarSet()
      Description: Flips the rebar set by changing the RebarPlane with the OutOfPlaneExtent and vice versa.
    Transform GetBarPositionTransform(int barPositionIndex)
      Description: Return a transform representing the relative position of any individual bar in the set.
      @barPositionIndex: An index between 0 and (NumberOfBarPositions-1).
      Returns: The position of a bar in the set relative to the first position.
    Line GetDistributionPath()
      Description: The distribution path of a rebar set.
      Returns: A line beginning at (0, 0, 0) and representing the direction and length of the set.
    void ScaleToBox(XYZ origin, XYZ xVec, XYZ yVec)
      Description: Move and resize the bar to fit within a specified box. The arguments are interpreted as an arbitrary rectangle in 3D with vertices: origin, origin+xVec, origin+xVec+yVec, origin+yVec. The algorithm then proceeds as follows. First the bar is given the default values of the shape parameters from the shape definition. Then, if it is possible to do so without violating the shape definition, the parameter values are scaled so that the width and height of the shape (including bar thickness) match the lengths of xVec and yVec. If there is no way to do this within the shape definition due to overconstraining, a compromise is attempted, such as scaling the whole shape until either the width or the height is correct. Finally the shape is rotated to match the coordinate system of the box. The algorithm is the same one used in one-click placement.
      @origin: One corner of the rectangle.
      @xVec: Vector representing the first edge of the rectangle. The length must be positive.
      @yVec: Vector representing the second edge of the rectangle. Must be perpendicular to xVec.
    void ScaleToBoxFor3D(XYZ origin, XYZ xVec, XYZ yVec, double height)
      Description: Move and resize a spiral or multiplanar instance to fit within a specified box. The arguments are interpreted as an arbitrary rectangle in 3D with vertices: origin, origin+xVec, origin+xVec+yVec, origin+yVec. One end of the rebar shape is inscribed in this rectangle following the procedure described for the ScaleToBox method. The other end is placed in the parallel plane at distance (center-to-center) given by the height argument, in the direction of (xVec x yVec). Note that spiral shapes interpret the input arguments using a different convention than multiplanar shapes. For spiral shapes, the spiral start will be placed in the rectangle defined by origin, xVec, yVec, and the end of the spiral will be placed in the parallel plane. For multiplanar shapes, the rebar is placed with its primary shape definition located in the parallel plane defined by the height argument, and its connector segments extending in the direction opposite (xVec x yVec). This method replaces ScaleToBoxForSpiral() from prior releases.
      @origin: One corner of the rectangle.
      @xVec: Vector representing the first edge of the rectangle. The length must be positive.
      @yVec: Vector representing the second edge of the rectangle. Must be perpendicular to xVec.
      @height: New value for the Height or MultiplanarDepth property.
    void SetLayoutAsFixedNumber(int numberOfBarPositions, double arrayLength, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to FixedNumber.
      @numberOfBarPositions: The number of bar positions in rebar set
      @arrayLength: The distribution length of rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsMaximumSpacing(double spacing, double arrayLength, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to MaximumSpacing
      @spacing: The maximum spacing between rebar in rebar set
      @arrayLength: The distribution length of rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsMinimumClearSpacing(double spacing, double arrayLength, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to MinimumClearSpacing
      @spacing: The maximum spacing between rebar in rebar set
      @arrayLength: The distribution length of rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsNumberWithSpacing(int numberOfBarPositions, double spacing, bool barsOnNormalSide, bool includeFirstBar, bool includeLastBar)
      Description: Sets the Layout Rule property of rebar set to NumberWithSpacing
      @numberOfBarPositions: The number of bar positions in rebar set
      @spacing: The maximum spacing between rebar in rebar set
      @barsOnNormalSide: Identifies if the bars of the rebar set are on the same side of the rebar plane indicated by the normal
      @includeFirstBar: Identifies if the first bar in rebar set is shown
      @includeLastBar: Identifies if the last bar in rebar set is shown
    void SetLayoutAsSingle()
      Description: Sets the Layout Rule property of rebar set to Single.
    void SetRebarShapeId(ElementId shapeId)
      Description: Changes the RebarShape element that defines the shape of the rebar. Changing the value of this member causes the Rebar instance to choose values for its shape parameters to preserve its previous shape as closely as possible

--------------------------------------------------------------------------------

[CLASS] RebarShapeMultiplanarDefinition
Full Name: Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition

Description: A specification for a simple 3D rebar shape.
Remarks: Simple 3D rebar shapes are supported by adding segments to a regular 2D shape definition. The added segments consist of three optional parts: a "duplicate shape" and two connectors. A "duplicate shape" is a second copy of the 2D shape, offset in a perpendicular direction, and connected at either the start or the end by a perpendicular connector segment. Also supported is adding one or both connector segments, without the duplicate shape. Fillets are applied to the connector segments with a diameter that is given by the OutOfPlaneBendDiameter property. The length of the connectors is given by the Rebar instance parameter "multiplanar depth." The MultiplanarDepth property of this class is the default value of the parameter.
Implements: IDisposable

  CONSTRUCTORS:
    new RebarShapeMultiplanarDefinition(double outOfPlaneBendDiameter)

  PROPERTIES:
    ElementId DepthParamId { get; set; }
      Description: Id of the parameter driving the multiplanar depth. The depth is measured center-to-center of the bar. A valid shape parameter must be assigned to DepthParamId before the MultiplanarDefinition can be used in RebarShape creation.
    bool IsDuplicateShapePresent { get; }
      Description: Whether the shape definition includes an offset copy of the 2D shape.
    bool IsEndConnectorPresent { get; }
      Description: Whether a perpendicular segment is constructed from the end of the 2D shape.
    bool IsStartConnectorPresent { get; }
      Description: Whether a perpendicular segment is constructed from the start of the 2D shape.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double OutOfPlaneBendDiameter { get; set; }
      Description: Bend diameter to be applied to the connector segments.

  METHODS:
    void Dispose()
    void SetPresenceOfSegments(bool isDuplicateShapePresent, bool isStartConnectorPresent, bool isEndConnectorPresent)
      Description: Simultaneously set the presence of all 3D segments.

--------------------------------------------------------------------------------

[CLASS] RebarShapeParameters
Full Name: Autodesk.Revit.DB.Structure.RebarShapeParameters

Description: Class containing functions that create and retrieve shared parameters for RebarShapes.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static IList<ElementId> GetAllRebarShapeParameters(Document doc)
      Description: List all shape parameters used by all the existing RebarShapes in the specified document.
      @doc: The document.
      Returns: ElementIds corresponding to the external parameters.
    static ElementId GetElementIdForExternalDefinition(Document doc, ExternalDefinition externalDefinition)
      Description: Retrieve the ElementId corresponding to an external rebar shape parameter in the document, if it exists; otherwise, return InvalidElementId.
      @doc: A document.
      @externalDefinition: A shared parameter.
      Returns: An ElementId representing the shared parameter stored in the document, or InvalidElementId if the parameter is not stored in the document.
    static ExternalDefinition GetExternalDefinitionForElementId(Document doc, ElementId paramId, DefinitionFile definitionFile)
      Description: Seach a DefinitionFile for the ExternalDefinition corresponding to a parameter in a document.
      @doc: A document.
      @paramId: The id of a shared parameter in the document.
      @definitionFile: A database of shared parameters.
      Returns: The external parameter corresponding to the parameter's ElementId, or null if the Id does not correspond to an external parameter, or the parameter is not in the definition file.
    static ElementId GetOrCreateElementIdForExternalDefinition(Document doc, ExternalDefinition externalDefinition)
      Description: Retrieve the ElementId corresponding to an external rebar shape parameter in the document, if it exists; otherwise, add the parameter to the document and generate a new ElementId.
      @doc: A document.
      @externalDefinition: A shared parameter.
      Returns: An ElementId representing the shared parameter stored in the document.
    static bool IsValidExternalDefinition(ExternalDefinition param)
      Description: Checks that an ExternalDefinition (shared parameter) may be used as a Rebar Shape parameter.
      @param: Definition of a shared parameter.
      Returns: True if the definition is of type Length, false otherwise.

--------------------------------------------------------------------------------

[CLASS] RebarShapeSegment
Full Name: Autodesk.Revit.DB.Structure.RebarShapeSegment

Description: Part of a RebarShapeDefinitionBySegments, representing one segment of a shape definition. Makes sure constraints of type RebarShapeConstraintFixedSegmentDir are uniquely set. If we try to aquire a second constraint of type RebarShapeConstraintFixedSegmentDir we delete the old one.
Remarks: Each segment must have enough constraints to determine its position. Overconstraining is allowed. The most common combinations are: A fixed direction together with a parallel length constraint; A parallel length constraint plus another length constraint parallel to the x-axis or y-axis; A parallel length constraint plus length constraints parallel to both the x-axis and y-axis. Multiple constraints may be driven by the same parameter, even on the same segment. Length constraints may be measured in two ways. For "measured to the outside of the bend," the reference is a tangent to the exterior face of the bar; the thickness of the bar is included. For "measured to the inside," the reference is the center of the arc of the bend; this is the point where the bend begins, if the constraint is parallel to the segment. A 180-degree bend is described by introducing a short segment in between the two straight segments, tangent to the midpoint of the bend.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<RebarShapeConstraint> GetConstraints()
      Description: Retrieve the list of constraints associated with this segment.
      Returns: The list of constraints.
    void SetConstraints(IList<RebarShapeConstraint> constraints)
      Description: Assign a new list of constraints to this segment.
      @constraints: A new list of constraints.

--------------------------------------------------------------------------------

[ENUM] RebarShapeSegmentEndReferenceType
Full Name: Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType

Description: A choice of two reference points for one end of a constraint driving the length of a RebarShapeSegment.
Remarks: The RebarShapeSegmentEndReferenceType of a constraint is meaningful only when the bend is right or obtuse. If the bend is acute, the reference type is ignored.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Straight = 0
    - Exterior = 1

[CLASS] RebarShapeVertex
Full Name: Autodesk.Revit.DB.Structure.RebarShapeVertex

Description: A bend between segments of a rebar shape definition.
Remarks: A RebarShapeVertex is part of a RebarShapeDefinitionBySegments object. There is one vertex between each pair of adjacent segments, plus one at each end of the overall shape. The end vertices currently are ignored by the shape definition, even if they have constraints. A bend may have the default radius of the bar type referenced by the Rebar element, or it may have a radius defined by a parameter.
Implements: IDisposable

  PROPERTIES:
    RebarShapeBendAngle BendAngle { get; set; }
      Description: The range of permissible angles at this bend.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    RebarShapeVertexTurn Turn { get; set; }
      Description: The sense of the turn. The Turn property must be set to Left or Right on each internal vertex before the RebarShapeDefinitionBySegments is used. Default is permissible for the first and last vertex, since they do not correspond to bends.

  METHODS:
    void Dispose()
    IList<RebarShapeConstraint> GetConstraints()
      Description: Retrieve the list of constraints associated with this vertex.
      Returns: The list of constraints.
    void SetConstraints(IList<RebarShapeConstraint> constraints)
      Description: Assign a new list of constraints to this vertex.
      @constraints: A new list of constraints.

--------------------------------------------------------------------------------

[ENUM] RebarShapeVertexTurn
Full Name: Autodesk.Revit.DB.Structure.RebarShapeVertexTurn

Description: Specify whether a bend at a RebarShapeVertex represents a left or right turn.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - Left = 1
    - Right = -1

[CLASS] RebarSplice
Full Name: Autodesk.Revit.DB.Structure.RebarSplice

Description: A class that can used to access the data between two connected Rebars.
Implements: IDisposable

  PROPERTIES:
    int ConnectedRebarEnd { get; }
      Description: Identifies the end of the connected rebar which is part of this splice - 0 for start, 1 for end.
    ElementId ConnectedRebarId { get; }
      Description: Identifies the connected rebar id of this rebar splice object.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int SourceRebarEnd { get; }
      Description: Identifies the end of the source rebar which is part of this rebar splice - 0 for start, 1 for end. The source rebar is the one from which this rebar splice was obtained.
    ElementId SourceRebarId { get; }
      Description: Identifies the source of the target rebar which is part of this rebar splice. The source rebar is the one from which this rebar splice was obtained.
    RebarSplicePosition SplicePosition { get; set; }
      Description: Identifies the splice position.
    ElementId SpliceTypeId { get; set; }
      Description: Identifies the id of the Rebar Splice Type.

  METHODS:
    void Dispose()
    RebarSpliceGeometry GetRebarSpliceGeometry()
      Description: Gets the RebarSpliceGeometry.
      Returns: Returns the RebarSpliceGeometry.
    void MoveRebarSpliceGeometry(XYZ translation)
      Description: Moves the RebarSpliceGeometry with the specified vector.
      @translation: The translation vector that will be applied.
    void RotateRebarSpliceGeometry(Line axis, double angle)
      Description: Rotates the RebarSpliceGeometry about the given axis and angle.
      @axis: The axis of rotation.
      @angle: The angle of the rotation in radians.

--------------------------------------------------------------------------------

[ENUM] RebarSpliceByRulesError
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceByRulesError

Description: Class that defines states for splicing a Rebar by rules.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Success = 0
    - Unknown = 1
    - InvalidRebar = 2
    - TooBigHook = 3
    - TooSmallRunOut = 4
    - MaximumLengthBiggerThanBarLength = 5
    - TooBigArc = 6
    - CantSpliceAllTheBarsInSet = 7
    - LapLengthBiggerThanMaximumBarLength = 8
    - InvalidCombinationOfMaximumMinimumBarLengthAndLapLength = 9

[CLASS] RebarSpliceByRulesResult
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceByRulesResult

Description: Class that encapsulates the result of the splice by rules operation.
Remarks: This class contains a collection of RebarSpliceGeometry which is the result of the splice and a RebarSpliceByRulesError member. After splice by rules operation check the Error member for RebarSpliceByRulesError.Success value and retrieve the RebarSpliceGeometry collection. If the splice by rules operation fails the Error member will contain a meaninful error.
Implements: IDisposable

  PROPERTIES:
    RebarSpliceByRulesError Error { get; }
      Description: Identifies the error that occured during the splice by rules operation. In case of success the value of this property will be Success.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<RebarSpliceGeometry> GetSpliceGeometries()
      Description: Gets the RebarSpliceGeometry collection which is the result of the splice by rules operation.
      Returns: Returns the RebarSpliceGeometry collection which is the result of the splice by rules operation.

--------------------------------------------------------------------------------

[ENUM] RebarSpliceByRulesRunOutPosition
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceByRulesRunOutPosition

Description: Describes the run-out position.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Start = 0
    - End = 1

[ENUM] RebarSpliceError
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceError

Description: Class that defines states for splicing a Rebar.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Success = 0
    - Unknown = 1
    - InvalidRebar = 2
    - InvalidLineOrLinePlaneNormal = 3
    - LineDoesNotIntersectRebarBoundingBox = 4
    - SpliceGeometryOnHookOrFillet = 5
    - TooSmallSegments = 6
    - SpliceGeometryDoesNotIntersectAllTheBarsInTheSet = 7
    - SpliceGeometryAlmostParallelToBarSegment = 8

[CLASS] RebarSpliceGeometry
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceGeometry

Description: This class consists of a vector and a point which will be projected to the nearest Rebar curve.
Remarks: The splice will be done with a plane that contains this point and has the normal the provided vector. If this plane is intersecting other Rebar curves these intersection will not be taken into account.
Implements: IDisposable

  CONSTRUCTORS:
    new RebarSpliceGeometry(XYZ spliceOrigin, XYZ spliceNormal)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ SpliceNormal { get; set; }
      Description: Identifies the splice face normal.
    XYZ SpliceOrigin { get; set; }
      Description: Identifies the splice face origin.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] RebarSpliceOptions
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceOptions

Description: This class encapsulates the options for the rebar splice operation.
Implements: IDisposable

  CONSTRUCTORS:
    new RebarSpliceOptions(Document document, ElementId spliceTypeId, RebarSplicePosition splicePosition)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    RebarSplicePosition SplicePosition { get; set; }
      Description: Identifies the splice line position.
    ElementId SpliceTypeId { get; set; }
      Description: Identifies the id of the Rebar Splice Type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] RebarSplicePosition
Full Name: Autodesk.Revit.DB.Structure.RebarSplicePosition

Description: Describes the position of the splice.
Remarks: This class describes the position of the splice face with respect to each bar end involved in splice. Middle describes the behavior when both bar ends extends with half of the lap length and the splice plane sits between them. End1 and End2 describes the behavior when one of the bar ends is on the splice plane and the other bar end extends with the lap length. End1 means that the lap is computed towards the start of the splice chain, while End2 means that the lap is computed towards the end of the splice chain. A splice chain represents an array of spliced rebars ordered by constraints (second is constrained to first, third to second and so on).
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - End1 = 0
    - Middle = 1
    - End2 = 2

[CLASS] RebarSpliceRules
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceRules

Description: Describes the rules for splicing Rebar.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MaximumBarLength { get; set; }
      Description: Identifies the maximum bar length. The default value is 12 meters if the document units are in Metric System, or 40 feet if the units are in Imperial System.
    double MinimumBarLength { get; set; }
      Description: Identifies the minimum bar length. The default value is 1 meter if the document units are in Metric System, or 3 feet if the units are in Imperial System.
    RebarSpliceByRulesRunOutPosition RunOutPosition { get; set; }
      Description: Identifies the run-out position. The default value is RebarSpliceByRulesRunOutPosition.End.

  METHODS:
    static RebarSpliceRules Create(Document document)
      Description: Creates a new instance of RebarSpliceRules with the default options.
      @document: A document. The units in this document will be used to initialize default values.
      Returns: Returns an instance of RebarSpliceRules with the default options.
    void Dispose()
    void SetMaximumAndMinimumBarLength(double maximumBarLength, double minimumBarLength)
      Description: Sets the maximum and minimum bar length.
      @maximumBarLength: The maximum bar length.
      @minimumBarLength: The minimum bar length.

--------------------------------------------------------------------------------

[ENUM] RebarSpliceShiftOption
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceShiftOption

Description: Describes the way bars are shifted in the splice relation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BarPlane = 0
    - None = 1

[ABSTRACT CLASS] RebarSpliceTypeUtils
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceTypeUtils

Description: Utility class for dealing with Rebar Splice Type operations. To find all Rebar Splice Types in the document can be done using FilteredElementCollector of category BuiltInCategory.OST_RebarSpliceType.

  METHODS:
    static ElementType CreateRebarSpliceType(Document document, string typeName)
      Description: Creates a Rebar Splice Type element.
      @document: The document.
      @typeName: The Rebar Splice Type name.
      Returns: The Rebar Splice Type.
    static IList<ElementId> GetAllRebarSpliceTypes(Document document)
      Description: Gets all the Rebar Splice Types elements from the document.
      @document: The document.
      Returns: Returns all the Rebar Splice Types elements from the document.
    static double GetLapLengthMultiplier(Document document, ElementId rebarSpliceTypeId)
      Description: Gets the lap length multiplier value.
      @document: The document.
      @rebarSpliceTypeId: The Rebar Splice Type id.
      Returns: Returns the lap length multiplier value.
    static RebarSpliceShiftOption GetShiftOption(Document document, ElementId rebarSpliceTypeId)
      Description: Identifies the way bars are shifted in the splice relation.
      @document: The document.
      @rebarSpliceTypeId: The Rebar Splice Type id.
      Returns: Returns the way bars are shifted in the splice relation.
    static double GetStaggerLengthMultiplier(Document document, ElementId rebarSpliceTypeId)
      Description: Gets the stagger multiplier value.
      @document: The document.
      @rebarSpliceTypeId: The Rebar Splice Type id.
      Returns: Returns the stagger length multiplier value.
    static void SetLapLengthMultiplier(Document document, ElementId rebarSpliceTypeId, double lapLengthMultiplier)
      Description: Sets the lap length multiplier value.
      @document: The document.
      @rebarSpliceTypeId: The Rebar Splice Type id.
      @lapLengthMultiplier: The lap length multiplier value.
    static void SetShiftOption(Document document, ElementId rebarSpliceTypeId, RebarSpliceShiftOption shiftOption)
      Description: Sets the way bars are shifted in the splice relation.
      @document: The document.
      @rebarSpliceTypeId: The Rebar Splice Type id.
      @shiftOption: The way bars are shifted in the splice relation.
    static void SetStaggerLengthMultiplier(Document document, ElementId rebarSpliceTypeId, double staggerLengthMultiplier)
      Description: Sets the lap length multiplier value.
      @document: The document.
      @rebarSpliceTypeId: The Rebar Splice Type id.
      @staggerLengthMultiplier: The stagger multiplier value.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] RebarSpliceUtils
Full Name: Autodesk.Revit.DB.Structure.RebarSpliceUtils

Description: Class with different utilities for Rebar Splice.

  METHODS:
    static RebarSpliceError CanRebarBeSpliced(Rebar rebar, RebarSpliceOptions spliceOptions, Line line, XYZ linePlaneNormal)
      Description: Verifies if the rebar can be spliced with the provided line.
      @rebar: The rebar to be spliced.
      @spliceOptions: The RebarSpliceOptions.
      @line: The line to splice the rebar with.
      @linePlaneNormal: The normal that determines the plane of the line.
      Returns: Will return RebarSpliceError.Success if it's possible to splice with line or other enum value corresponding to the error that occurred.
    static RebarSpliceError CanRebarBeSpliced(Rebar rebar, RebarSpliceOptions spliceOptions, Line line, ElementId viewId)
      Description: Verifies if the rebar can be spliced with the provided line.
      @rebar: The rebar to be spliced.
      @spliceOptions: The RebarSpliceOptions.
      @line: The line to splice the rebar with.
      @viewId: Based on the view it will be determined the plane of the line.
      Returns: Will return RebarSpliceError.Success if it's possible to splice with line or other enum value corresponding to the error that occurred.
    static RebarSpliceError CanRebarBeSpliced(Rebar rebar, RebarSpliceOptions spliceOptions, RebarSpliceGeometry spliceGeometry)
      Description: Verifies if the rebar can be spliced with the RebarSpliceGeometry.
      @rebar: The rebar to be spliced.
      @spliceOptions: The RebarSpliceOptions.
      @spliceGeometry: The RebarSpliceGeometry.
      Returns: Will return RebarSpliceError.Success if it's possible to splice with point or other enum value corresponding to the error that occurred.
    static XYZ GetLapDirectionForSpliceGeometryAndPosition(Rebar rebar, RebarSpliceGeometry spliceGeometry, RebarSplicePosition splicePosition)
      Description: This function calculates the lap direction given a RebarSpliceGeometry and a RebarSplicePosition.
      @rebar: The input rebar.
      @spliceGeometry: The splice geometry.
      @splicePosition: The splice position.
      Returns: The lap direction.
    static IList<ElementId> GetSpliceChain(Rebar rebar)
      Description: Returns all the rebars that are part of a splice chain with the input rebar.
      @rebar: The input rebar.
      Returns: The splice chain.
    static RebarSpliceByRulesResult GetSpliceGeometries(Document document, ElementId rebarIdToSplit, RebarSpliceOptions spliceOptions, RebarSpliceRules spliceRules)
      Description: Computes a list of RebarSpliceGeometry which respects the rules. This list can be used to splice the Rebar.
      @document: The document
      @rebarIdToSplit: Rebar id to split.
      @spliceOptions: The rebar splice options.
      @spliceRules: The splice rules.
      Returns: Returns the result of the operation. If the operation was successful the RebarSpliceByRulesResult.Error member will have "RebarSpliceByRulesError.Success" value.
    static IList<ElementId> SpliceRebar(Document document, ElementId rebarIdToSplit, RebarSpliceOptions spliceOptions, Line line, XYZ linePlaneNormal)
      Description: Splice a rebar with a line.
      @document: The document
      @rebarIdToSplit: Rebar id to split.
      @spliceOptions: The rebar splice options.
      @line: The line used for splice.
      @linePlaneNormal: The normal of the plane of the line.
      Returns: Returns the ids of the rebars that are considered to be spliced.
    static IList<ElementId> SpliceRebar(Document document, ElementId rebarIdToSplit, RebarSpliceOptions spliceOptions, Line line, ElementId viewId)
      Description: Splice a Rebar with a line.
      @document: The document
      @rebarIdToSplit: Rebar id to split.
      @spliceOptions: The rebar splice options.
      @line: The line used for splice.
      @viewId: Based on the view it will be determined the plane of the line.
      Returns: Returns the ids of the rebars that are considered to be spliced.
    static IList<ElementId> SpliceRebar(Document document, ElementId rebarIdToSplit, RebarSpliceOptions spliceOptions, IList<RebarSpliceGeometry> spliceGeometries)
      Description: Splice a rebar with a list of RebarSpliceGeometry.
      @document: The document
      @rebarIdToSplit: Rebar id to split.
      @spliceOptions: The rebar splice options.
      @spliceGeometries: A list of RebarSpliceGeometry that indicates where the rebar will be spliced.
      Returns: Returns the ids of the rebars that are considered to be spliced.
    static ElementId UnifyRebarsIntoOne(Document document, ElementId firstRebarId, ElementId secondRebarId)
      Description: This method will unify the rebars by removing the splice between them. A new rebar will be created because of this operation. The curves of the resulted rebar will be the curves of the first rebar continued by the curves of the second rebar. The resulted rebar will take data from the first rebar. (e.g.. layout, moved/removed bars, etc.).
      @document: The document.
      @firstRebarId: First Rebar id.
      @secondRebarId: Second Rebar id.
      Returns: Returns the id of the new rebar. In case that unify operation fails, it will return invalidElementId

--------------------------------------------------------------------------------

[ENUM] RebarStyle
Full Name: Autodesk.Revit.DB.Structure.RebarStyle

Description: Describes the usage style of a RebarShape. The style affects the bend radius and the set of allowable hooks. It also affects Rebar instance auto-constraining behavior.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Standard = 0
    - StirrupTie = 1

[CLASS] RebarSystemSpanSymbol
Full Name: Autodesk.Revit.DB.Structure.RebarSystemSpanSymbol

Description: Represents a Rebar System Span Symbol element in Autodesk Revit.
Inherits: IndependentTag
Implements: IDisposable

  METHODS:
    static RebarSystemSpanSymbol Create(Document document, ElementId viewId, LinkElementId hostId, XYZ point, ElementId symbolId)
      Description: Creates a new instance of RebarSystemSpanSymbol in the project.
      @document: The document.
      @viewId: The id of the view in which the symbol should appear.
      @hostId: The ElementId of AreaReinforcement (either in the document, or linked from another document).
      @point: The span symbol's head position.
      @symbolId: The id of the family symbol of this symbol.
      Returns: A reference to newly created span symbol.

--------------------------------------------------------------------------------

[CLASS] RebarTrimExtendData
Full Name: Autodesk.Revit.DB.Structure.RebarTrimExtendData

Description: The class that contains the information needed to calculate and return the curves in a trimmed/extended state, and also find the constraints that trim/extend it.
Remarks: If new curves will be added by calling addBarGeometry(), the existing curves in Rebar element will be replaced with these curves. It will not add curves to the existing ones.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    RebarFreeFormValidationResult AddBarGeometry(CurveLoop curves)
      Description: Adds a new rebar geometry. This information is set to the rebar after the API execution is finished successfully.
      @curves: Curves describing one bar in the set.
      Returns: Returns Success if everything is ok, otherwise the failure reason.
    RebarFreeFormValidationResult AddBarGeometry(IList<Curve> curves)
      Description: Adds a new rebar geometry. This information is set to the rebar after the API execution is finished successfully.
      @curves: Curves describing one bar in the set.
      Returns: Returns Success if everything is ok, otherwise the failure reason.
    bool CanAddBarGeometry()
      Description: Returns true if getNumberOfBarGeometry() is less than GetNumberOfBars(), false otherwise.
    void ClearAllAddedBarGeometry()
      Description: This function will remove all bars geometry that were added by calling AddBarGeometry().
    bool CreateEndConstraint(IList<Reference> targetReferences, bool isConstraintToCover, double offsetValue)
      Description: Creates a constraint for the end handle of the rebar. This constraint will be set preferred after the API execution is finished successfully.
      @targetReferences: The references to which the rebar handle will be constrained. Will throw exception if it's empty or if it's anything but Face(s) from a structural that can host rebar.
      @isConstraintToCover: If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.
      @offsetValue: The distance from references to the rebar handle.
      Returns: Returns true if a start constraint can be created with the given references, false otherwise. The reference should be faces from structurals that can host rebar.
    bool CreateStartConstraint(IList<Reference> targetReferences, bool isConstraintToCover, double offsetValue)
      Description: Creates a constraint for the start handle of the rebar. This constraint will be set preferred after the API execution is finished successfully.
      @targetReferences: The references to which the rebar handle will be constrained. Will throw exception if it's empty or if it's anything but Face(s) from a structural that can host rebar.
      @isConstraintToCover: If true the RebarConstraintType will be set to ToCover, otherwise RebarConstraintType will be set to FixedDistanceToHostFace.
      @offsetValue: The distance from references to the rebar handle.
      Returns: Returns true if a start constraint can be created with the given references, false otherwise. The reference should be faces from structurals that can host rebar.
    void Dispose()
    IList<Curve> GetAddedBarGeometry(int barIndex)
      Description: Gets the added curves that will represent the bar at index barIndex.
      @barIndex: The index of the bar. Should be a number between 0 and GetNumberOfBarGeometry() - 1.
      Returns: Returns the curves that will represent the bar at index barIndex. The hooks plane normals will be applied on these curves.
    int GetNumberOfBarGeometry()
      Description: Gets the number of Bar Geometry that were added.
      Returns: Returns the number of Bar Geometry that were added.
    RebarUpdateCurvesData GetRebarUpdateCurvesData()
      Description: Gets a class that contains information used as input and output for rebar free form calculation.
      Returns: Gets a class that contains information used as input and output for rebar free form calculation.

--------------------------------------------------------------------------------

[CLASS] RebarUpdateCurvesData
Full Name: Autodesk.Revit.DB.Structure.RebarUpdateCurvesData

Description: Class holding the information needed to calculate the rebar curves.
Implements: IDisposable

  PROPERTIES:
    AlignedFreeFormSetOrientationOptions AlignedFreeFormSetOrientationOptions { get; }
      Description: Orientation options for an Aligned Free Form Rebar set.
    bool AreOrientationOptionsChanged { get; }
      Description: Indicates if the orientation options have changed since the last regeneration.
    bool AreWorkshopInstructionsChanged { get; }
      Description: Indicates if the workshop instructions have changed since the last regeneration.
    bool CycleCounterChanged { get; }
      Description: True if the cycle counter was changed, false otherwise.The cycle counter value is changed when the free form Rebar element is selected and the user press Space key -or- by through property. -or- by the server if it considers that the counter reaches the maximum value and reset it (set it to 0).
    string ErrorMessage { get; set; }
      Description: The reason for calculation failure. If the calculation fails, this message will be shown in an error, or warning if we are editing the constraints.
    bool HostMirrored { get; set; }
      Description: If true, then host of the rebar was mirrorred (along with the rebar) before this regeneration.
    bool IsAttachmentTypeChanged { get; }
      Description: Indicates if the attachment type has changed since the last regeneration.
    bool IsBarsNumberChanged { get; }
      Description: Indicates if the bar number has changed since the last regeneration.
    bool IsBendingRadiusChanged { get; }
      Description: Indicates if the bending radius has changed since the last regeneration.
    bool IsEndConstraintChanged { get; }
      Description: Indicates if the end handle constraint has changed since the last regeneration.
    bool IsLayoutChanged { get; }
      Description: Indicates if the layout has changed since the last regeneration.
    bool IsReversed { get; set; }
      Description: Used to store the state of the bar refering to the direction of the bars. This is useful when using face intersection to calculate bars. After mirroring, curves created from intersecting faces may be reversed, so we use this to store the state and keep the rebar pointing in the correct direction.
    bool IsSpacingChanged { get; }
      Description: Indicates if the spacing has changed since the last regeneration.
    bool IsStartConstraintChanged { get; }
      Description: Indicates if the start handle constraint has changed since the last regeneration.
    bool IsStyleChanged { get; }
      Description: Indicates if the style has changed since the last regeneration.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Spacing { get; }
      Description: The spacing between the bars, according to the LayoutRule.
    RebarWorkInstructions WorkshopInstructions { get; }
      Description: Identifies the workshop instructions of this rebar.

  METHODS:
    void Dispose()
    StirrupTieAttachmentType GetAttachmentType()
      Description: Returns attachment type for stirrups to be used in cover calculation.
      Returns: InteriorFace : rebar to attach to interior face of cover reference.ExteriorFace : rebar to attach to exterior face of cover reference.
    IList<Curve> GetBarGeometry(int barIndex)
      Description: Returns the geometry for a bar at the specified index currently in the Rebar.
      @barIndex: The index of the bar. Should be a number between 0 and GetNumberOfBars() - 1.
      Returns: Returns an array of curves that defines the bar at the specified index.
    double GetBarModelDiameter()
      Description: Gets the model diameter of the Rebar.
      Returns: Returns the model diameter of the Rebar.
    double GetBarNominalDiameter()
      Description: Gets the nominal diameter of the Rebar.
      Returns: Returns the nominal diameter of the Rebar.
    int GetBarsNumber()
      Description: Gets the number of bars specified in the layout options. This is used to calculate the sets driven by bar number.
      Returns: Returns the number of bars specified in the layout options.
    double GetBendingRadius()
      Description: Gets the current bending radius of the rebar.
      Returns: Returns the current bending radius of the rebar.
    IList<int> GetChangedCustomHandles()
      Description: Returns an array containing custom handles that were changed since the last regeneration. Array is empty if no handles were changed since the last regeneration.
      Returns: Returns an array containing the tags of custom handles that were changed since the last regeneration.
    IList<Guid> GetChangedSharedParameterGUIDs()
      Description: Returns an array containing the shared parameter GUIDs that were changed since the last regeneration. Array is empty if no shared params were changed since the last regeneration.
      Returns: Returns an array containing the elementId of the shared params that were changed since the last regeneration.
    IList<RebarConstraint> GetCustomConstraints()
      Description: Gets all rebar constraints that are attached to custom handles for this rebar.
      Returns: Returns all rebar constraints that are attached to custom handles for this rebar. This array does not contains the start and end constraints.
    int GetCycleCounter()
      Description: Gets the cycle counter that is stored in the rebar.
      Returns: Returns the cycle counter.
    Document GetDocument()
      Description: Gets a reference to the current document.
      Returns: Returns a reference to the current document.
    RebarConstraint GetEndConstraint()
      Description: Gets the current constraint for the end handle of the Rebar.
      Returns: Returns the current constraint for the end handle of the Rebar. Return value is null is no constraint is present.
    double GetHookOrientationAngle(int end)
      Description: Get the hook orientation angle at end that is currently in the rebar.
      @end: The end of bar. Should be 0 for start or 1 for end.
      Returns: The hook orientation angle at end that is currently in the rebar.
    XYZ GetHookPlaneNormalForBarIdx(int end, int barPositionIndex)
      Description: Returns the normal of plane in which the hook at end of bar with index barPositionIndex that is currently in Rebar.
      @end: The end of bar. Should be 0 for start or 1 for end.
      @barPositionIndex: An index between 0 and (GetNumberOfBars()-1).
      Returns: The normal of plane in which the hook at end of bar with index barPositionIndex that is currently in Rebar.
    ElementId GetHostId()
      Description: Gets the id of the host structural for this rebar.
      Returns: Returns the id of the host structural for this rebar.
    RebarLayoutRule GetLayoutRule()
      Description: Gets the layout rule for this bar.
      Returns: Returns the layout rule for this bar.
    int GetNumberOfBars()
      Description: Returns the number of bars currently in the rebar.
      Returns: Returns the number of bars currently in the rebar.
    ElementId GetRebarId()
      Description: Get the id of the Rebar element currently being calculated.
      Returns: returns the id of the Rebar element currently being calculated
    RebarStyle GetRebarStyle()
      Description: Gets the style of the rebar.
      Returns: Gets the style of the rebar (Standard or StirrupTie).
    RebarConstraint GetStartConstraint()
      Description: Gets the current constraint for the start handle of the Rebar.
      Returns: Returns the current constraint for the start handle of the Rebar. Return value is null if no constraint is present.
    void SetCycleCounter(int cycleCounter)
      Description: Sets the cycle counter to a specific value.
    void SetHookOrientationAngle(int end, double angle)
      Description: Set the hook orientation angle at end. This information is set to the rebar after the API execution is finished successfully.
      @end: The end of bar. Should be 0 for start or 1 for end.
      @angle: The hook orientation angle at end.
    void SetHookPlaneNormalForBarIdx(int end, int barPositionIndex, XYZ hookNormal)
      Description: Set the normal of plane in which the hook at end of bar with index barPositionIndex will stay. This information is set to the rebar after the API execution is finished successfully.
      @end: The end of bar. Should be 0 for start or 1 for end.
      @barPositionIndex: Index of the bar for which it will set hook plane normal.
      @hookNormal: The normal of plane in which the hook at end of bar with index barPositionIndex will stay.

--------------------------------------------------------------------------------

[ENUM] RebarWorkInstructions
Full Name: Autodesk.Revit.DB.Structure.RebarWorkInstructions

Description: Describes how a Free Form Rebar will be fabricated.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Bent = 0
    - Straight = 1

[ENUM] ReinforcementAbbreviationObjectType
Full Name: Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType

Description: Defines the type of desired reinforcement object for abbreviation tags.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Area = 0
    - Path = 1

[CLASS] ReinforcementAbbreviationTag
Full Name: Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag

Description: This class is used to access the Area or Path Reinforcement abbreviation tag data. It stores abbreviation tag value and abbreviation type.
Implements: IDisposable

  CONSTRUCTORS:
    new ReinforcementAbbreviationTag(ReinforcementAbbreviationTagType typeTag, string abbreviationTag)

  PROPERTIES:
    string AbbreviationTag { get; }
      Description: The abbreviation tag value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ReinforcementAbbreviationTagType TypeTag { get; }
      Description: The abbreviation tag type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ReinforcementAbbreviationTagType
Full Name: Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType

Description: Defines all types of abbreviation tags for Area and Path Reinforcement objects.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AreaReinforcementTopMajor = 0
    - AreaReinforcementTopMinor = 1
    - AreaReinforcementBottomMajor = 2
    - AreaReinforcementBottomMinor = 3
    - AreaReinforcementInteriorMajor = 4
    - AreaReinforcementInteriorMinor = 5
    - AreaReinforcementExteriorMajor = 6
    - AreaReinforcementExteriorMinor = 7
    - AreaReinforcementLayerEachWay = 8
    - AreaReinforcementLayerEachFace = 9
    - PathReinforcementTop = 10
    - PathReinforcementBottom = 11
    - PathReinforcementInterior = 12
    - PathReinforcementExterior = 13
    - PathReinforcementAlternating = 14
    - PathReinforcementAlternatingBarOffset = 15

[ENUM] ReinforcementBarOrientation
Full Name: Autodesk.Revit.DB.Structure.ReinforcementBarOrientation

Description: Describes the bar orientation at Path Reinforcement.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TopOrExterior = 0
    - NearSide = 1
    - BottomOrInterior = 2
    - FarSide = 3

[CLASS] ReinforcementData
Full Name: Autodesk.Revit.DB.Structure.ReinforcementData

Description: Abstract class for various reinforcement data
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ReinforcementRoundingManager
Full Name: Autodesk.Revit.DB.Structure.ReinforcementRoundingManager

Description: A base class providing access to reinforcement rounding overrides for structural elements.
Remarks: Subclasses of this class are used to access the override settings for Rebar elements and types or Fabric elements and types.
Implements: IDisposable

  PROPERTIES:
    Element Element { get; }
      Description: The owner of the reinforcement rounding overrides.
    bool IsActiveOnElement { get; set; }
      Description: Defines whether reinforcement rounding is activated for the particular element.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ForgeTypeId GetLengthUnitTypeId()
      Description: Gets the identifier of the length unit quantifying the reinforcement rounding values.

--------------------------------------------------------------------------------

[ENUM] ReinforcementRoundingSource
Full Name: Autodesk.Revit.DB.Structure.ReinforcementRoundingSource

Description: An enumerated type listing the possible sources for reinforcement rounding overrides.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - ReinforcementSettings = 1
    - Type = 2
    - Element = 3

[CLASS] ReinforcementSettings
Full Name: Autodesk.Revit.DB.Structure.ReinforcementSettings

Description: Provides access to project-wide reinforcement settings.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool HostStructuralRebar { get; set; }
      Description: Host Structural Rebar within Area and Path Reinforcement with touching AtomHostStructuralRebar.
    bool NumberVaryingLengthRebarsIndividually { get; set; }
      Description: Use this option to modify the way varying length bars are numbered (individually or as a whole).
    RebarPresentationMode RebarPresentationInSection { get; set; }
      Description: The default presentation mode for rebar sets, when: The view direction is perpendicular to the rebar normal and the rebar set is cut.The view direction is not perpendicular to the rebar normal and the view direction is not parallel to the rebar normal.
    RebarPresentationMode RebarPresentationInView { get; set; }
      Description: The default presentation mode for rebar sets, when the view direction is perpendicular to the rebar normal and the rebar set is not cut.
    bool RebarShapeDefinesEndTreatments { get; set; }
      Description: End Treatments are defined by Rebar Shape of Rebar element. Can be changed if document contains no rebars, area reinforcements and path reinforcements.
    bool RebarShapeDefinesHooks { get; set; }
      Description: Hooks are defined by Rebar Shape of Rebar element. Can be changed if document contains no rebars, area reinforcements and path reinforcements.
    string RebarVaryingLengthNumberSuffix { get; set; }
      Description: A unique identifier used for a bar within a variable length rebar set.

  METHODS:
    FabricRoundingManager GetFabricRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings used by FabricSheetType and FabricSheet elements.
      Returns: The rounding manager.
    RebarRoundingManager GetRebarRoundingManager()
      Description: Returns an object for managing reinforcement rounding override settings used by RebarBarTypes, Rebar and RebarInSystem elements.
      Returns: The rounding manager.
    string GetReinforcementAbbreviationTag(ReinforcementAbbreviationTagType tagType)
      Description: Gets one abbreviation tag for desired ReinforcementAbbreviationTagType.
      @tagType: Defines the type of abbreviation tag.
      Returns: Abbreviation tag value
    IList<ReinforcementAbbreviationTag> GetReinforcementAbbreviationTags(ReinforcementAbbreviationObjectType objectType)
      Description: Gets a list of abbreviation tags for desired reinforcement object type.
      @objectType: Defines the type of desired reinforcement object for abbreviation tags.
      Returns: An array of ReinforcementAbbreviationTag that will define all abbreviations for given reinforcement object.
    static ReinforcementSettings GetReinforcementSettings(Document document)
      Description: Obtains the ReinforcementSettings object for the specified project document.
      @document: A project document.
      Returns: The ReinforcementSettings object.
    bool IsEqual(ReinforcementSettings other)
      Description: Checks if Reinforcement Settings is equal to other
    void SetReinforcementAbbreviationTag(ReinforcementAbbreviationTagType tagType, string abbreviationTag)
      Description: Sets one abbreviation tag for desired ReinforcementAbbreviationTagType.
      @tagType: Defines the type of abbreviation tag.
      @abbreviationTag: Abbreviation tag value to set.

--------------------------------------------------------------------------------

[CLASS] ReleaseConditions
Full Name: Autodesk.Revit.DB.Structure.ReleaseConditions

Description: An object that represents a Release Conditions on analytical element.
Implements: IDisposable

  CONSTRUCTORS:
    new ReleaseConditions(bool start, bool fx, bool fy, bool fz, bool mx, bool my, bool mz)
    new ReleaseConditions(bool start)

  PROPERTIES:
    bool Fx { get; set; }
      Description: Gets or Sets the Fx of the release type.
    bool Fy { get; set; }
      Description: Gets or Sets the Fy of the release type.
    bool Fz { get; set; }
      Description: Gets or Sets the Fz of the release type.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Mx { get; set; }
      Description: Gets or Sets the Mx of the release type.
    bool My { get; set; }
      Description: Gets or Sets the My of the release type.
    bool Mz { get; set; }
      Description: Gets or Sets the Mz of the release type.
    bool Start { get; set; }
      Description: Gets or Sets the position of release type. True for start, false for end.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ReleaseType
Full Name: Autodesk.Revit.DB.Structure.ReleaseType

Description: The release type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Fixed = 0
    - Pinned = 1
    - BendingMoment = 2
    - UserDefined = 3

[ENUM] StirrupTieAttachmentType
Full Name: Autodesk.Revit.DB.Structure.StirrupTieAttachmentType

Description: An enumerated tye that represents how the Stirrup/Tie rebar is attached to the cover reference.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - InteriorFace = 0
    - ExteriorFace = 1

[ENUM] StructuralConnectionApplyTo
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo

Description: An enumerated type that represents the type of structural locations to which a connection annotation may be applied.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BeamsAndBraces = 0
    - ColumnTop = 1
    - ColumnBase = 2
    - Connection = 3

[CLASS] StructuralConnectionApprovalType
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType

Description: A type element that represents a connection approval type.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static StructuralConnectionApprovalType Create(Document doc, string name)
      Description: Creates a new StructuralConnectionApprovalType.
      @name: A name for the new approval type. It must be unique within the document.
      Returns: Created connection approval type.
    static void GetAllStructuralConnectionApprovalTypes(Document cda, out ICollection<ElementId> ids)
    static bool IsValidApprovalTypeName(Document doc, string name)
      Description: Verifies if the provided approval name is unique in the document.
      Returns: True if approval type name is unique.

--------------------------------------------------------------------------------

[ENUM] StructuralConnectionCodeCheckingStatus
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus

Description: An enumerated type listing all code checking status of the structural connection element.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotCalculated = 0
    - OkChecked = 1
    - CheckingFailed = 2

[CLASS] StructuralConnectionHandler
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionHandler

Description: An object of Structural Connection Handler.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId ApprovalTypeId { get; set; }
      Description: Retrieves or changes approval type of the Structural Connection Handler.
    StructuralConnectionCodeCheckingStatus CodeCheckingStatus { get; set; }
      Description: Code checking status of the structural connection.
    bool OverrideTypeParams { get; set; }
      Description: Allow or disallow connection's type parameters to be overridden.
    int SingleElementEndIndex { get; set; }
      Description: Element end index for single element connections (0: start, 1: end).

  METHODS:
    void AddElementIds(IList<ElementId> elemIds)
      Description: Adds element ids to the connection. All element ids in an array should be of applicable category.
      @elemIds: The ElementIdArr containing ids of elements to be added.
    void AddReferences(Document document, IList<Reference> picks)
      Description: Adds references to the connection. All references should be of applicable category.
      @document: The document.
      @picks: The array containing picks of input elements to be added.
    static StructuralConnectionHandler Create(Document document, IList<ElementId> idsToConnect, ElementId typeId, IList<ConnectionInputPoint> additionalInputPoints)
      Description: Creates a new instance of a Structural Connection Handler, which is defined by the elements to connect and the additional points.
      @document: The Revit document.
      @idsToConnect: List of element ids of connected elements.
      @typeId: The type of Structural Connection Handler.
      @additionalInputPoints: The array of points that help define the connection.
      Returns: The newly created connection.
    static StructuralConnectionHandler Create(Document document, IList<ElementId> elementIds, string typeName)
      Description: Creates custom StructuralConnectionHandlerType and StructuralConnectionHandler.
      @document: The Document.
      @elementIds: Elements which are to be used to create custom StructuralConnectionHandlerType.
      @typeName: The StructuralConnectionHandlerType name.
      Returns: The created StructuralConnectionHandler which is of just created custom StructuralConnectionHandlerType.
    static StructuralConnectionHandler Create(Document document, IList<ElementId> idsToConnect, ElementId typeId)
      Description: Creates a new instance of a Structural Connection Handler, which defines the connection between given elements.
      @document: The Revit document.
      @idsToConnect: List of element ids of connected elements.
      @typeId: The type of Structural Connection Handler.
      Returns: The newly created connection.
    static StructuralConnectionHandler CreateGenericConnection(Document document, IList<ElementId> idsToConnect)
      Description: Creates a new instance of a Structural Connection Handler with a generic type, which defines the connection between given elements.
      @document: The Revit document.
      @idsToConnect: The list of element ids of connected elements.
      Returns: The newly created generic connection.
    IList<ElementId> GetConnectedElementIds()
      Description: Retrieves list of element ids of connected elements.
      Returns: Returns connected element ids.
    ConnectionInputPoint GetInputPoint(Guid id)
      Description: Returns point with specified id. Returns null if specified point does not exist
    IList<ConnectionInputPoint> GetInputPoints()
      Description: Returns a list of additional points defining certain connections.
    IList<Reference> GetInputReferences()
      Description: Gets references of input elements.
    XYZ GetOrigin()
      Description: Retrieves origin point of Structural Connection Handler element.
      Returns: The origin point of element.
    bool IsCustom()
      Description: Checks if Structural Connection Handler has the custom connection style.
      Returns: True if Structural Connection Handler has the custom connection style.
    bool IsDetailed()
      Description: Checks if Structural Connection Handler has the detailed connection style.
      Returns: True if Structural Connection Handler has the detailed connection style.
    void RemoveElementIds(IList<ElementId> elemIds)
      Description: Removes element ids from the connection. All element ids in an array should belong to the connection.
      @elemIds: The ElementIdArr containing ids of elements to be removed.
    void RemoveReferences(IList<Reference> picks)
      Description: Removes references from the connection. All references in an array should belong to the connection.
      @picks: The array containing picks to be removed.
    void SetDefaultElementOrder()
      Description: Sorts the connected elements connection according to structural categories, element materials and geometries. The steel element is set rather than an element of other material. The priorities of the elements are set according structural categories in following order: columns, framings, walls, foundations, floors. In case of several Structural Framing elements order is determined by cutting - the cutting element is set as the primary one rather than element being cut.

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionHandlerType
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType

Description: A StructuralConnectionHandlerType is used in StructuralConnectionHandler element generation.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    Guid ConnectionGuid { get; }
      Description: The GUID to use for identifying connection geometry generation algorithm.

  METHODS:
    static void AddElementsToCustomConnection(StructuralConnectionHandler structuralConnectionHandler, IList<Reference> references)
      Description: Modifies StructuralConnectionHandlerType of input StructuralConnectionHandler by adding representors of input elements or subelements.
      @structuralConnectionHandler: The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.
      @references: References to elements or subelements which are to be used to modify custom StructuralConnectionHandlerType by adding their representors.
    static StructuralConnectionHandlerType Create(Document pADoc, string name, Guid guid, string familyName, ElementId categoryId, IList<ConnectionInputPointInfo> inputPointsInfo)
      Description: Creates a new StructuralConnectionHandlerType object.
      @pADoc: The document.
      @name: The type name.
      @guid: Connection GUID.
      @familyName: Name of system family which created type will belong to.
      @categoryId: Category identity of connection type.
      @inputPointsInfo: List of description information used for the selection of input points.
      Returns: The newly created instance.
    static StructuralConnectionHandlerType Create(Document pADoc, string name, Guid guid, string familyName, ElementId categoryId)
      Description: Creates a new StructuralConnectionHandlerType object.
      @pADoc: The document.
      @name: The type name.
      @guid: Connection GUID.
      @familyName: Name of system family which created type will belong to.
      @categoryId: Category identity of connection type.
      Returns: The newly created instance.
    static StructuralConnectionHandlerType Create(Document pADoc, string name, Guid guid, string familyName)
      Description: Creates a new StructuralConnectionHandlerType object.
      @pADoc: The document.
      @name: The type name.
      @guid: Connection GUID.
      @familyName: Name of system family which created type will belong to.
      Returns: The newly created instance.
    static ElementId CreateDefaultStructuralConnectionHandlerType(Document pADoc)
      Description: Creates a new StructuralConnectionHandlerType object with a default name.
      @pADoc: The document.
      Returns: The newly created type id.
    static ElementId FindGenericConnectionType(Document doc)
      Description: Finds StructuralConnectionHandlerType which is Generic Connection type.
      Returns: Returns id of StructuralConnectionHandlerType which is Generic Connection type of invalidElementId if not found.
    static ElementId GetDefaultConnectionHandlerType(Document pADoc)
      Description: Gets a default type id for Structural Connection.
      @pADoc: The document.
      Returns: The type id.
    bool IsCustom()
      Description: Checks if StructuralConnectionHandlerType is custom.
      Returns: True if StructuralConnectionHandlerType is custom.
    bool IsDetailed()
      Description: Checks if StructuralConnectionHandlerType is detailed.
      Returns: True if StructuralConnectionHandlerType is detailed.
    bool IsGeneric()
      Description: Checks if StructuralConnectionHandlerType is generic.
      Returns: True if StructuralConnectionHandlerType is generic.
    static bool IsTypeNameValidForCustomConnection(Document document, string typeName)
      Description: Validates if the input name matches the criteria of StructuralConnectionHandlerType name. Name must be unique among other existing StructuralConnectionHandlerTypes and cannot contain any of the following characters: new line, {}[];`~\\/:*?";<>| or any of the non-printable characters.
      @document: The Document.
      @typeName: The StructuralConnectionHandlerType name to validate.
      Returns: True if the input name matches the criteria of StructuralConnectionHandlerType name.
    static void RemoveMainSubelementsFromCustomConnection(StructuralConnectionHandler structuralConnectionHandler, IList<Subelement> subelements)
      Description: Removes one or more subelements from a StructuralConnectionHandlerType. The subelements will be erased.
      @structuralConnectionHandler: The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.
      @subelements: The main Subelements of input StructuralConnectionHandler which are to be used to modify custom StructuralConnectionHandlerType.

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionSettings
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionSettings

Description: Provides access to project-wide structural connections settings.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool IncludeWarningControls { get; set; }
      Description: This property controls how Structural Connection Element is generated. If set to true and warnings are reported for given Element, additional yellow triangle is displayed.

  METHODS:
    static StructuralConnectionSettings GetStructuralConnectionSettings(Document document)
      Description: Obtains the StructuralConnectionSettings object for the specified project document.
      @document: A project document.
      Returns: The StructuralConnectionSettings object.

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionType
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionType

Description: A type element that represents a connection symbol applied to structural members.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    StructuralConnectionApplyTo ApplyTo { get; }
      Description: Choose whether this connection type applies to beams and braces, to tops of columns, or to bases of columns.

  METHODS:
    static StructuralConnectionType Create(Document doc, StructuralConnectionApplyTo applyTo, string name, ElementId familySymbolId)
      Description: Create a new StructuralConnectionType, allowing the specified annotation FamilySymbol to be applied to structural members.
      @applyTo: Specify which type of member this connection type can be applied to.
      @name: A name for the connection type. It must be unique within the document.
      @familySymbolId: The id of an annotation FamilySymbol. InvalidElementId is allowed. Otherwise, the FamilySymbol must be in the category "Connection Symbols" (OST_StructConnectionSymbols) and have its "Apply To" parameter set to match the applyTo argument.
    static void GetAllStructuralConnectionTypeIds(Document cda, out ICollection<ElementId> ids)
    ElementId GetFamilySymbolId()
      Description: FamilySymbol of the annotation to use for this connection type.
    void SetFamilySymbolId(ElementId familySymbolId)
      Description: FamilySymbol of the annotation to use for this connection type.
    static bool ValidFamilySymbolId(Document doc, StructuralConnectionApplyTo applyTo, ElementId familySymbolId)
      Description: Checks whether the family symbol id is allowed for StructuralConnectionTypes with the given value for the applyTo property.
      Returns: True if %familySymbolId% is invalidElementId; or if it is the id of a FamilySymbol of category "Connection Symbols" (OST_StructConnectionSymbols) with its "Apply To" parameter set to match the applyTo property. Returns false otherwise.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] StructuralFramingUtils
Full Name: Autodesk.Revit.DB.Structure.StructuralFramingUtils

Description: A collection of Structural Framing Utilities.

  METHODS:
    static void AllowJoinAtEnd(FamilyInstance familyInstance, int end)
      Description: Sets the indicated end of the framing element to be allowed to join to others.
      @familyInstance: The FamilyInstance, which must be of a structural framing category.
      @end: The index of the end (0 for the start, 1 for the end).
    static bool CanFlipEnds(FamilyInstance familyInstance)
      Description: Determines if the ends of the given framing element can be flipped.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete.
      Returns: True for non-concrete line, arc or ellipse framing element, false otherwise.
    static bool CanSetEndReference(FamilyInstance familyInstance, int end)
      Description: Determines if a reference can be set for the given end of the framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined at the given end.
      @end: The index of the end (0 for the start, 1 for the end).
      Returns: True if reference can be set for the given end of the framing element.
    static void DisallowJoinAtEnd(FamilyInstance familyInstance, int end)
      Description: Sets the indicated end of the framing element to not be allowed to join to others.
      @familyInstance: The FamilyInstance, which must be of a structural framing category.
      @end: The index of the end (0 for the start, 1 for the end).
    static void FlipEnds(FamilyInstance familyInstance)
      Description: Flips the ends of the structural framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete.
    static Reference GetEndReference(FamilyInstance familyInstance, int end)
      Description: Returns a reference to the end of a framing element according to the setback settings.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined.
      @end: The index of the end (0 for the start, 1 for the end).
      Returns: The end reference.
    static bool IsEndReferenceValid(FamilyInstance familyInstance, int end, Reference pick)
      Description: Determines if the given reference can be set for the given end of the framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined at the given end.
      @end: The index of the end (0 for the start, 1 for the end).
      @pick: The reference to be checked against the given end of the framing element.
      Returns: True if the given reference can be set for the given end of the framing element.
    static bool IsJoinAllowedAtEnd(FamilyInstance familyInstance, int end)
      Description: Identifies if the indicated end of the framing element is allowed to join to others.
      @familyInstance: The FamilyInstance, which must be of a structural framing category.
      @end: The index of the end (0 for the start, 1 for the end).
      Returns: True if it is allowed to join. False if it is disallowed.
    static void RemoveEndReference(FamilyInstance familyInstance, int end)
      Description: Resets the end reference of the structural framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined.
      @end: The index of the end (0 for the start, 1 for the end).
    static void SetEndReference(FamilyInstance familyInstance, int end, Reference pick)
      Description: Sets the end reference of a framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined.
      @end: The index of the end (0 for the start, 1 for the end).
      @pick: The reference to set to the given end.

--------------------------------------------------------------------------------

[ENUM] StructuralInstanceUsage
Full Name: Autodesk.Revit.DB.Structure.StructuralInstanceUsage

Description: Represents the structural usage of a family instance.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Wall = 1
    - Column = 2
    - Girder = 3
    - Joist = 4
    - Purlin = 5
    - Other = 6
    - Brace = 7
    - HorizontalBracing = 8
    - KickerBracing = 9
    - Automatic = 10
    - TrussChord = 11
    - TrussWeb = 12

[CLASS] StructuralInstanceUsageFilter
Full Name: Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter

Description: A filter used to find elements that are structural family instances (typically columns, beams or braces) of the given structural usage.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new StructuralInstanceUsageFilter(StructuralInstanceUsage structuralUsage, bool inverted)
    new StructuralInstanceUsageFilter(StructuralInstanceUsage structuralUsage)

  PROPERTIES:
    StructuralInstanceUsage StructuralUsage { get; }
      Description: The family instance structural usage.

--------------------------------------------------------------------------------

[ENUM] StructuralMaterialType
Full Name: Autodesk.Revit.DB.Structure.StructuralMaterialType

Description: Represents the structural material type. This enum value is returned by Autodesk::Revit::DB::FamilyInstance::StructuralMaterialType.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Steel = 1
    - Concrete = 2
    - Wood = 3
    - Other = 4
    - PrecastConcrete = 5
    - Generic = 6
    - Aluminum = 7

[CLASS] StructuralMaterialTypeFilter
Full Name: Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter

Description: A filter used to match family instances that have the given structural material type.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new StructuralMaterialTypeFilter(StructuralMaterialType structuralMaterialType, bool inverted)
    new StructuralMaterialTypeFilter(StructuralMaterialType structuralMaterialType)

  PROPERTIES:
    StructuralMaterialType StructuralMaterialType { get; }
      Description: The structural material type.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionsServiceData
Full Name: Autodesk.Revit.DB.Structure.StructuralSectionsServiceData

Description: The data needed by section type server to perform type definition.
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The current document.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<ElementId> GetCurrentElements()
      Description: Returns the list of Ids of the current elements.
      Returns: Ids of the current elements. Contains the family base element to which the section shape type parameter belongs.

--------------------------------------------------------------------------------

[CLASS] StructuralSettings
Full Name: Autodesk.Revit.DB.Structure.StructuralSettings

Description: Provides access to project-wide structural settings.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double BoundaryConditionAreaAndLineSymbolSpacing { get; set; }
      Description: Symbol spacing for boundary conditions.
    ElementId BoundaryConditionFamilySymbolFixed { get; set; }
      Description: The id of the FamilySymbol to represent a fixed boundary condition.
    ElementId BoundaryConditionFamilySymbolPinned { get; set; }
      Description: The id of the FamilySymbol to represent a pinned boundary condition.
    ElementId BoundaryConditionFamilySymbolRoller { get; set; }
      Description: The id of the FamilySymbol to represent a roller boundary condition.
    ElementId BoundaryConditionFamilySymbolUserDefined { get; set; }
      Description: The id of the FamilySymbol to represent a user-defined boundary condition.
    ElementId BraceAboveSymbol { get; set; }
      Description: The id of the ElementType to represent a brace above a beam in plan view.
    ElementId BraceBelowSymbol { get; set; }
      Description: The id of the ElementType to represent a brace below a beam in plan view.
    double BraceParallelLineOffset { get; set; }
      Description: The distance by which brace symbols in plan views will be offset.
    ElementId KickerBraceSymbol { get; set; }
      Description: The id of the ElementType to represent a kicker brace.
    bool ShowBraceAbove { get; set; }
      Description: Whether to show brace symbols above beams in plan views.
    bool ShowBraceBelow { get; set; }
      Description: Whether to show brace symbols below beams in plan views.
    double SymbolicCutbackForBeamAndTruss { get; set; }
      Description: Symbolic cutback distance to be applied to all beams and trusses.
    double SymbolicCutbackForBrace { get; set; }
      Description: Symbolic cutback distance to be applied to all braces.
    double SymbolicCutbackForColumn { get; set; }
      Description: Symbolic cutback distance to be applied to all columns.
    bool UseLoadsDisplayScaling { get; set; }
      Description: Whether to use loads display scaling. If disabled then loads are displayed according to force scale type parameters.

  METHODS:
    XYZ GetLoadForceVectorReprLine(LoadType loadType, XYZ forceVector)
      Description: Returns the representative line of the load force vector according to loads display scaling.
      @loadType: LoadType::Point, Line, or Area
      @forceVector: The load force vector in internal units.
      Returns: The the representative line in internal units.
    static StructuralSettings GetStructuralSettings(Document doc)
      Description: Obtains the StructuralSettings object for the specified project document.
      @doc: A project document.
      Returns: The StructuralSettings object.
    void SetValuesForLoadsDisplayScaling(double minimumLoadValue, double minimumForceLineLength, double maximumLoadValue, double maximumForceLineLength)
      Description: Sets values for loads display scaling by providing two load forces and their corresponding length of the representative lines in internal units.
      @minimumLoadValue: The minimum force in SpecTypeId.Force units.
      @minimumForceLineLength: The line length for minimum force.
      @maximumLoadValue: The maximum force in SpecTypeId.Force units.
      @maximumForceLineLength: The line length for maximum force.

--------------------------------------------------------------------------------

[ENUM] StructuralType
Full Name: Autodesk.Revit.DB.Structure.StructuralType

Description: Represents the structural type of a family instance.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NonStructural = 0
    - Beam = 1
    - Brace = 2
    - Column = 3
    - Footing = 4
    - UnknownFraming = 5

[ENUM] StructuralWallUsage
Full Name: Autodesk.Revit.DB.Structure.StructuralWallUsage

Description: Represents the structural usage of a wall.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NonBearing = 0
    - Bearing = 1
    - Shear = 2
    - Combined = 3

[CLASS] StructuralWallUsageFilter
Full Name: Autodesk.Revit.DB.Structure.StructuralWallUsageFilter

Description: A filter used to match walls that have the given structural wall usage.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new StructuralWallUsageFilter(StructuralWallUsage structuralWallUsage, bool inverted)
    new StructuralWallUsageFilter(StructuralWallUsage structuralWallUsage)

  PROPERTIES:
    StructuralWallUsage StructuralWallUsage { get; }
      Description: The wall structural usage.

--------------------------------------------------------------------------------

[ENUM] SurfaceElementExtension
Full Name: Autodesk.Revit.DB.Structure.SurfaceElementExtension

Description: Presets for given Analytical Extension.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BottomOrTop = 0
    - Plane = 1

[ENUM] SurfaceElementProjectionZ
Full Name: Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ

Description: Presets for given Analytical Projection Z.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TopOrInterior = 0
    - CenterOfElement = 1
    - BottomOrExterior = 2
    - CenterOfCore = 3
    - Plane = 4

[ENUM] TargetRebarConstraintType
Full Name: Autodesk.Revit.DB.Structure.TargetRebarConstraintType

Description: A type used to identify the particular part of a Stirrup style rebar to which a Standard style rebar's handle is constrained.
Remarks: Most of the range of values for this type are the same as those of RebarHandleType, since it is usually the handles on the Stirrup which constrain the Standard bar. However, two additional values - BarBend and HookBend - are used to identify the special case of a Standard style, straight bar, running perpendicular to the plane of the Stirrup, and constrained to a bend (or hook) arc on the Stirrup.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - RebarPlane = 0
    - StartOfBar = 1
    - EndOfBar = 2
    - Edge = 3
    - OutOfPlaneExtent = 4
    - BarBend = 5
    - HookBend = 6

[ENUM] TranslationRotationValue
Full Name: Autodesk.Revit.DB.Structure.TranslationRotationValue

Description: Specifies the type of condition applied to the translation or rotation parameter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Fixed = 0
    - Release = 1
    - Spring = 2

[CLASS] Truss
Full Name: Autodesk.Revit.DB.Structure.Truss

Description: Represents all kinds of Trusses.
Remarks: The Truss object represents all the kinds of Trusses in Revit. The TrussType property is used to distinguish the type of the Truss.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    CurveArray Curves { get; }
      Description: Get all the truss curves.
    ICollection<ElementId> Members { get; }
      Description: Get all the members of truss.
    TrussType TrussType { get; set; }
      Description: Retrieve/set an object that represents the type of the truss.

  METHODS:
    void AttachChord(Element attachToElement, TrussChordLocation location, bool forceRemoveSketch)
      Description: Attach a truss's specific chord to a specified element, the element should be a roof or floor.
      @attachToElement: The element to which the truss's chord will attach. The element should be a roof or floor.
      @location: The chord need to be attached.
      @forceRemoveSketch: Whether to detach the original sketch if there is one.
    static Truss Create(Document document, ElementId trussTypeId, ElementId sketchPlaneId, Curve curve)
      Description: Creates a new Truss.
      @document: The document in which the new Truss is created.
      @trussTypeId: Element id of the truss type.
      @sketchPlaneId: Element id of a SketchPlane.
      @curve: The curve of the truss element. It must be a line, must not be a vertical line, and must be within the sketch plane.
    void DetachChord(TrussChordLocation location)
      Description: Detach a truss's specific chord from the element to which it is attached.
      @location: The chord.
    static void DropTruss(Truss truss)
      Description: Drop truss Family, it will disassociate all members from the truss and delete the truss.
      @truss: The truss to be dropped.
    TrussMemberInfo GetTrussMemberInfo(ElementId elemId)
      Description: Query if a given element is a member of a truss, its lock status and its usage, etc.
      @elemId: The querying element.
      Returns: A struct TrussMemberInfo that contains the querying element's host truss, whether to lock to the truss, usage type, etc.
    void RemoveProfile()
      Description: Remove the profile of a truss.
    void SetProfile(CurveArray topChords, CurveArray bottomChords)
      Description: Add or modify the profile of a truss.
      @topChords: The curves serving as top chords of the truss.
      @bottomChords: The curves serving as bottom chords of the truss.
    void TogglePinMember(ElementId elemId)
      Description: Pin/Unpin a truss member.
      @elemId: The member element is going to pin/unpin.

--------------------------------------------------------------------------------

[ENUM] TrussChordLocation
Full Name: Autodesk.Revit.DB.Structure.TrussChordLocation

Description: This enumerated type represents the options for the Truss Chord Location.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Bottom = 0
    - Top = 1

[ENUM] TrussCurveType
Full Name: Autodesk.Revit.DB.Structure.TrussCurveType

Description: Types of curves created in truss families.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NonTrussCurve = 0
    - TopChord = 1
    - BottomChord = 2
    - Web = 3

[CLASS] TrussMemberInfo
Full Name: Autodesk.Revit.DB.Structure.TrussMemberInfo

Description: Provides access to the information of a truss member in Autodesk Revit.
Remarks: A struct TrussMemberInfo that contains an element's host truss, whether to lock to the truss, usage type, etc.

  CONSTRUCTORS:
    new TrussMemberInfo()

  PROPERTIES:
    ElementId hostTrussId { get; set; }
      Description: The host truss' ElementId of the member.
    bool lockedToTruss { get; set; }
      Description: Whether the member is locked to the host truss.
    TrussMemberType memberTypeKey { get; set; }
      Description: Kind of the member in the truss.

--------------------------------------------------------------------------------

[ENUM] TrussMemberType
Full Name: Autodesk.Revit.DB.Structure.TrussMemberType

Description: Indicates the "kind" of a truss member.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ETK_Unknown = 0
    - ETK_TrussTopChord = 1
    - ETK_TrussBottomChord = 2
    - ETK_TrussVertWeb = 3
    - ETK_TrussDiagWeb = 4

[CLASS] TrussType
Full Name: Autodesk.Revit.DB.Structure.TrussType

Description: Represents a specific type of truss.
Inherits: FamilySymbol
Implements: IDisposable

--------------------------------------------------------------------------------

[ENUM] WireDistributionDirection
Full Name: Autodesk.Revit.DB.Structure.WireDistributionDirection

Description: Defines the direction of the distribution of wires in a Fabric Sheet.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Major = 0
    - Minor = 1

[ENUM] YJustification
Full Name: Autodesk.Revit.DB.Structure.YJustification

Description: The justification of the framing element in Y.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Left = 0
    - Center = 1
    - Origin = 2
    - Right = 3

[ENUM] YZJustificationOption
Full Name: Autodesk.Revit.DB.Structure.YZJustificationOption

Description: The option for whether a framing element has independent or uniform justification on its ends.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Uniform = 0
    - Independent = 1

[ENUM] ZJustification
Full Name: Autodesk.Revit.DB.Structure.ZJustification

Description: The justification of the framing element in Z.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Top = 0
    - Center = 1
    - Origin = 2
    - Bottom = 3


