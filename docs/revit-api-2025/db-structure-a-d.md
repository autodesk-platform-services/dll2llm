# Autodesk.Revit.DB.Structure

NAMESPACE: Autodesk.Revit.DB.Structure
--------------------------------------------------------------------------------

[ENUM] AlignedFreeFormSetOrientationOptions
Full Name: Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions
Description: Orientation options for Aligned Free Form Rebar set.
Inherits: Enum

  Values:
    - AlignedToDistributionPath = 0
    - Vertical = 1
    - ParallelToFace = 2
    - PerpendicularToFace = 3

--------------------------------------------------------------------------------

[ENUM] AnalyticalCurveSelector
Full Name: Autodesk.Revit.DB.Structure.AnalyticalCurveSelector
Description: Specifies which portion of an Analytical Curve is of interest.
Inherits: Enum

  Values:
    - StartPoint = 0
    - EndPoint = 1
    - WholeCurve = 2

--------------------------------------------------------------------------------

[CLASS] AnalyticalElement
Full Name: Autodesk.Revit.DB.Structure.AnalyticalElement
Description: Base class for a structural analytical elements. AnalyticalElement represents the analytical portion of a given Structural Element.
Inherits: Element

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
      Throws InapplicableDataException: This AnalyticalElement contains more than one single curve.
    Reference GetReference(AnalyticalModelSelector selector)
      Description: Returns a reference to a given curve within the Analytical Element.
      @selector: Specifies where in the Analytical Element the reference lies.
      Returns: Requested reference.
      Throws ArgumentException: selector is not valid for this AnalyticalElement.
      Throws ArgumentNullException: A non-optional argument was null
    Transform GetTransform()
      Description: Returns the transform which reflects Analytical Element orientation.
      Returns: The orientation of the Analytical Element.
    bool IsSingleCurve()
      Description: Indicates if the Analytical Element can be expressed as a single curve.
      Returns: True if Analytical Element can be expressed as a single curve, false otherwise.
    bool IsValidAnalyzeAs(AnalyzeAs analyzeAs)
      Description: Checks whether the value set for Analyze As is valid for an Analytical Element.
      @analyzeAs: The value set to be verified.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidSelector(AnalyticalModelSelector selector)
      Description: Indicates if the input selector is valid for the Analytical Element.
      @selector: Portion of the Analytical Element geometry.
      Returns: True if selector is valid for this Analytical Element, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidStructuralRole(AnalyticalStructuralRole structuralRole)
      Description: Checks whether the value set for Analytical Structural Role is valid for an Analytical Element.
      @structuralRole: The value set to be verified.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidTransform(Transform trf)
      Description: Checks whether the value set for Local Coordinate System is valid for an Analytical Element.
      @trf: The value set to be verified.
      Throws ArgumentNullException: A non-optional argument was null
    void SetTransform(Transform trf)
      Description: Sets the transform of Analytical Element Local Coordinate System.
      Throws ArgumentException: The provided Local Coordinate System is not valid
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] AnalyticalElementSelector
Full Name: Autodesk.Revit.DB.Structure.AnalyticalElementSelector
Description: Specifies a portion of an Analytical Element or the whole element.
Inherits: Enum

  Values:
    - StartOrBase = 0
    - EndOrTop = 1
    - Whole = 2

--------------------------------------------------------------------------------

[ENUM] AnalyticalFixityState
Full Name: Autodesk.Revit.DB.Structure.AnalyticalFixityState
Description: Specifies the fixity setting of individual degrees of freedom in analytical release conditions.
Inherits: Enum

  Values:
    - Fixed = 0
    - Released = 1
    - Spring = 2

--------------------------------------------------------------------------------

[CLASS] AnalyticalLink
Full Name: Autodesk.Revit.DB.Structure.AnalyticalLink
Description: An analytical link element that is used to create connections between other Analytical Elements.
Inherits: Element

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
      Throws ArgumentException: startHubId is not a valid Hub ID for an AnalyticalLink element. -or- endHubId is not a valid Hub ID for an AnalyticalLink element. -or- Thrown if startHubId or endHubId do not represent ids of Hubs. -or- Thrown if startHubId == endHubId. -or- Thrown if type does not represent an id of an AnalyticalLinkType.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAutoGenerated()
      Description: Specifies whether or not an AnalyticalLink was created by an Analytical Element.
      Returns: True if AnalyticalLink was created by an Analytical Element, false otherwise.
    static bool IsValidHub(Document doc, ElementId hubId)
      Description: Checks whether input hub is valid for an AnalyticalLink.
      @doc: Hubs's document.
      @hubId: Hub to test for validity.
      Returns: True is returned when provided hubId points hub that is valid for AnalyticalLink, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] AnalyticalLinkType
Full Name: Autodesk.Revit.DB.Structure.AnalyticalLinkType
Description: An object that specifies the analysis properties for an AnalyticalLink element.
Inherits: ElementType

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
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] AnalyticalLoopType
Full Name: Autodesk.Revit.DB.Structure.AnalyticalLoopType
Description: Specifies kind of analytical model loop.
Inherits: Enum

  Values:
    - All = 0
    - External = 1
    - Internal = 2
    - Filled = 3
    - Void = 4

--------------------------------------------------------------------------------

[CLASS] AnalyticalMember
Full Name: Autodesk.Revit.DB.Structure.AnalyticalMember
Description: Represents a linear element in the structural analytical model.
Inherits: AnalyticalElement

  PROPERTIES:
    double CrossSectionRotation { get; set; }
      Description: This represents the cross-section rotation, in radians.
    ElementId SectionTypeId { get; set; }
      Description: The id of the type from the structural Family assigned to the Analytical Member.
    StructuralSectionShape StructuralSectionShape { get; }
      Description: The structural section shape of the Analytical Member.

  METHODS:
    bool CanSplit()
      Description: Identifies whether a particular analytical member can be split at a point on it's defining curve (by Double) ).
      Returns: True if the analytical member can be split, otherwise false.
    static AnalyticalMember Create(Document aDoc, Curve curve)
      Description: Creates a new instance of an Analytical Member within the project.
      @aDoc: A Revit document.
      @curve: Curve of the analytical member.
      Returns: The newly created Analytical Member instance.
      Throws ArgumentException: The input curve is not bound. -or- The provided curve is not supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void FlipCurve()
      Description: Flip the Analytical Member
    IList<MemberForces> GetMemberForces()
      Description: Gets the member forces associated with this Analytical Member.
      Returns: Returns a collection of Member Forces associated with this Analytical Member. Empty collection will be returned if Analytical Member doesn't have any Member Forces. To find out with which end member forces are associated use Autodesk::Revit::DB::Structure::MemberForces::Position property to obtain a position of Member Forces on element.
    IList<ReleaseConditions> GetReleaseConditions()
      Description: Gets the release conditions associated with this Analytical Member.
      Returns: Returns a collection of Release Conditions associated with this Analytical Member. Empty collection will be returned if Analytical Member doesn't have any Release Conditions. End to which release conditions will be added is defined by setting Autodesk::Revit::DB::Structure::ReleaseConditions::Position property in provided release conditions object.
    ReleaseType GetReleaseType(bool start)
      Description: Gets the release type.
      @start: The position on Analytical Member element. True for start, false for end.
      Returns: The type of release.
    static bool IsValidCurve(Curve curve)
      Description: Verifies if the curve is valid for an Analytical Member.
      @curve: The curve to be verified.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidSectionTypeId(ElementId familySymbolId)
      Description: Checks whether the family symbol id is allowed for Analytical Member as Section Type property.
      @familySymbolId: Family symbol id which has to be checked.
      Returns: True if %familySymbolId% is invalidElementId; or if it is the id of a FamilySymbol of category "Structural Framing" (OST_StructuralFraming) or "Structural Columns" (OST_StructuralColumns) Returns false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCurve(Curve curve)
      Description: Sets the curve for the Analytical Member.
      Throws ArgumentException: The input curve is not bound. -or- The provided curve is not supported.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMemberForces(MemberForces memberForces)
      Description: Sets Member Forces to Analytical Member.
      @memberForces: End to which member forces will be added is defined by setting Autodesk::Revit::DB::Structure::MemberForces::Position property in provided Member Forces object.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMemberForces(bool start, XYZ force, XYZ moment)
      Description: Sets Member Forces to Analytical Member.
      @start: Member Forces position on Analytical Member. True for start, false for end.
      @force: The translational forces at specified position of the element. The x value of XYZ object represents force along x-axis of the Analytical Member coordinate system, y along y-axis, z along z-axis respectively.
      @moment: The rotational forces at specified position of the element. The x value of XYZ object represents moment about x-axis of the Analytical Member coordinate system, y about y-axis, z about z-axis respectively.
      Throws ArgumentNullException: A non-optional argument was null
    void SetReleaseConditions(ReleaseConditions releaseConditions)
      Description: Sets Release Conditions to Analytical Member.
      @releaseConditions: End to which release conditions will be added is defined by setting Autodesk::Revit::DB::Structure::ReleaseConditions::Position property in provided release conditions object.
      Throws ArgumentNullException: A non-optional argument was null
    void SetReleaseType(bool start, ReleaseType releaseType)
      Description: Sets the release type.
      @start: The position on Analytical Member element. True for start, false for end.
      @releaseType: The type of release.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    ElementId Split(double parameter)
      Description: Splits the analytical member at a point on its defining curve.
      @parameter: The normalized parameter value along the element (should be greater than 0 and less than 1).
      Returns: The newly created analytical member id.
      Throws InvalidOperationException: Analytical member cannot be split.

--------------------------------------------------------------------------------

[CLASS] AnalyticalModelSelector
Full Name: Autodesk.Revit.DB.Structure.AnalyticalModelSelector
Description: Defines a portion of an Analytical Model for an Element.
Remarks: This is used to identify the portion of an analytical model of interest to a client. To identify the portion of the analytical model, the client must identify the curve in question, by using one of the following: The specific curve within the analytical model.The index of the curve within the analytical model. If a specific part of that curve is of interest, the client needs to identify that by specifying one of the following: The start of the curve.The end of the curve.The entire curve. This is the default behavior, so this does not need specifying.
Implements: IDisposable

  CONSTRUCTORS:
    new AnalyticalModelSelector(Curve curve)
      Description: Creates a selector based on a specific analytical curve.
      @curve: The curve upon which this selector acts.
      Throws ArgumentException: The input curve points to a helical curve and is not supported for this operation.
      Throws ArgumentNullException: A non-optional argument was null
    new AnalyticalModelSelector(Curve curve, AnalyticalCurveSelector inCurveSelector)
      Description: Creates a selector based on one portion of a specific analytical curve.
      @curve: The curve upon which this selector acts.
      @inCurveSelector: Portion of the analytical curve in which the client is interested.
      Throws ArgumentException: The input curve points to a helical curve and is not supported for this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new AnalyticalModelSelector()
      Description: Creates a selector for the analytical model geometry.
    new AnalyticalModelSelector(AnalyticalCurveSelector inCurveSelector)
      Description: Creates a selector for the analytical model geometry.
      @inCurveSelector: Portion of the analytical curve in which the client has interest.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

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

  Values:
    - Unconnected = 0
    - Connected = 1

--------------------------------------------------------------------------------

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
      Throws ArgumentNullException: A non-optional argument was null
    AnalyticalNodeConnectionStatus GetConnectionStatus()
      Description: Returns the Connection Status for this Analytical Node.

--------------------------------------------------------------------------------

[CLASS] AnalyticalOpening
Full Name: Autodesk.Revit.DB.Structure.AnalyticalOpening
Description: An element that represents an Opening in an Analytical Panel element.
Remarks: It can cut only one Analytical Panel at a time.
Inherits: AnalyticalSurfaceBase

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
      Throws ArgumentException: One of the following requirements is not satisfied : - curve loop curveLoop is not planar - curve loop curveLoop is self-intersecting - curve loop curveLoop contains zero length curves - curve loop curveLoop is not inside or does not intersect the AnalyticalPanel on which we want to create the Opening. - panelId is not the ElementId of an AnalyticalPanel - curve loop curveLoop is not in the same plane as the Analytical Panel
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static bool IsCurveLoopValidForAnalyticalOpening(CurveLoop loop, Document aDoc, ElementId panelId)
      Description: Checks if curve loop is valid for Analytical Opening.
      @loop: The curve loop to be checked.
      @aDoc: Revit document.
      @panelId: ElementId of the AnalyticalPanel on which we create the Opening.
      Returns: Returns true if curve loop is ok, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] AnalyticalPanel
Full Name: Autodesk.Revit.DB.Structure.AnalyticalPanel
Description: An element that represents a surface in the Structural Analytical Model.
Inherits: AnalyticalSurfaceBase

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
      Throws ArgumentException: The profile argument is not valid for analytical panel creation. -or- The input profile is not bound. -or- The normal argument is not valid for analytical panel creation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the analytical panel.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static AnalyticalPanel Create(Document aDoc, CurveLoop curveLoop)
      Description: Creates a new instance of an Analytical Panel within the project.
      @aDoc: Revit document.
      @curveLoop: CurveLoop for the Analytical Panel.
      Returns: The newly created AnalyticalPanel instance.
      Throws ArgumentException: One of the following requirements is not satisfied : - curve loop curveLoop is not planar - curve loop curveLoop is self-intersecting - curve loop curveLoop contains zero length curves
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ISet<ElementId> GetAnalyticalOpeningsIds()
      Description: Returns the Analytical Openings ids of the Analytical Panel.
      Returns: Set of ElementId.

--------------------------------------------------------------------------------

[ENUM] AnalyticalRigidLinksOption
Full Name: Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption
Description: Specifies how Rigid Links will be made for the Analytical Model.
Remarks: Rigid Links are curves connecting neighboring Structural Beams and Structural Columns.
Inherits: Enum

  Values:
    - Enabled = 0
    - Disabled = 1
    - FromColumn = 2

--------------------------------------------------------------------------------

[ENUM] AnalyticalStructuralRole
Full Name: Autodesk.Revit.DB.Structure.AnalyticalStructuralRole
Description: Indicates the structural role for the analytical elements.
Inherits: Enum

  Values:
    - StructuralRoleBeam = 0
    - StructuralRoleColumn = 1
    - StructuralRoleMember = 3
    - StructuralRoleGirder = 4
    - StructuralRoleFloor = 5
    - StructuralRoleWall = 6
    - StructuralRolePanel = 7
    - Unset = -1

--------------------------------------------------------------------------------

[ENUM] AnalyticalSupportPriority
Full Name: Autodesk.Revit.DB.Structure.AnalyticalSupportPriority
Description: Defines how "highly" another Element is giving support for one Element.
Remarks: For instance, a Column may be a higher priority for a Beam than another Beam. This is useful to find the best supports for a given Element.
Inherits: Enum

  Values:
    - UnknownPriority = 0
    - HighestPriority = 1
    - SecondHighestPriority = 2
    - ThirdHighestPriority = 3
    - FourthHigestPriority = 4

--------------------------------------------------------------------------------

[ENUM] AnalyticalSupportType
Full Name: Autodesk.Revit.DB.Structure.AnalyticalSupportType
Description: Indicates what kind of support another Element provides -- Point, Surface, or Curve.
Inherits: Enum

  Values:
    - UnknownSupport = 0
    - PointSupport = 1
    - CurveSupport = 2
    - SurfaceSupport = 3

--------------------------------------------------------------------------------

[CLASS] AnalyticalSurfaceBase
Full Name: Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase
Description: This is the base class for analytical surface elements.
Inherits: AnalyticalElement

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
      Throws ArgumentNullException: A non-optional argument was null
    bool IsOuterContourValid(CurveLoop contour)
      Description: Checks if contour is valid for this Analytical Surface.
      @contour: The curve loop to be checked.
      Returns: Returns true if curve loop is ok, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetOuterContour(CurveLoop outerContour)
      Description: Sets the Curve Loop that defines the geometry of the Analytical Surface element.
      @outerContour: New Curve Loop for the Analytical Surface element.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] AnalyticalToPhysicalAssociationManager
Full Name: Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager
Description: Class which manages the associations between analytical elements and physical elements.
Remarks: An element can be part of only one association at a time. Physical elements can have one of these categories: ColumnsCurtain Wall PanelsFloorsGeneric ModelsMassPartsRailingsRampsRoofsStairsStructural ColumnsStructural FoundationStructural FramingStructural TrussesStructural Beam SystemWalls Analytical elements can have one of these categories: Analytical MemberAnalytical Panel
Inherits: Element

  PROPERTIES:
    static bool EnableAssistedAssociation { get; set; }
      Description: Indicates if associations between Analytical and Physical Elements should be created automatically.

  METHODS:
    void AddAssociation(ISet<ElementId> analyticalElementIds, ISet<ElementId> physicalElementIds)
      Description: Adds a new association between a group of analytical elements and a group of physical elements.
      @analyticalElementIds: Ids of the analytical elements.
      @physicalElementIds: Ids of the physical elements.
      Throws ArgumentException: Analytical id is not valid or has already defined another association. -or- Physical id is not valid or has already defined another association.
      Throws ArgumentNullException: A non-optional argument was null
    void AddAssociation(ElementId analyticalElementId, ElementId physicalElementId)
      Description: Adds a new association between an analytical element and a physical element.
      @analyticalElementId: Id of the analytical element.
      @physicalElementId: Id of the physical element.
      Throws ArgumentException: Analytical id is not valid or has already defined another association. -or- Physical id is not valid or has already defined another association.
      Throws ArgumentNullException: A non-optional argument was null
    static AnalyticalToPhysicalAssociationManager GetAnalyticalToPhysicalAssociationManager(Document doc)
      Description: Returns the AnalyticalToPhysicalAssociationManager for this document.
      @doc: Revit document.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId GetAssociatedElementId(ElementId elementId)
      Description: Returns id of the element which is in association with the element with the given ElementId.
      @elementId: Element id for which we want to get the associated element.
      Returns: Id of the associated element.
      Throws ArgumentNullException: A non-optional argument was null
    ISet<ElementId> GetAssociatedElementIds(ElementId elementId)
      Description: Returns ids of the elements which are in association with the element with the given ElementId.
      @elementId: Element id for which we want to get the associated elements.
      Returns: Ids of the associated elements.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasAssociation(ElementId id)
      Description: Verifies if the element has already defined an association.
      @id: Id of the element to check.
      Returns: Returns true if an association has been found, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAnalyticalElement(Document doc, ElementId id)
      Description: Returns true if the element is an analytical element.
      @doc: Revit document.
      @id: The element to be checked.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsPhysicalElement(Document doc, ElementId id)
      Description: Returns true if the element is a physical element.
      @doc: Revit document.
      @id: The element to be checked.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveAssociation(ElementId id)
      Description: This method will remove the association for the element with the given ElementId.
      @id: Id of the element for which we want to remove the association.
      Throws ArgumentException: This element doesn't have an association defined.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] AnalyzeAs
Full Name: Autodesk.Revit.DB.Structure.AnalyzeAs
Description: Analyze As has various functions within the Analytical Model, and is Element-dependent. "Not for Analysis" usually means that there will not be an Analytical Model generated. The others indicate how the Analytical Model behavior will treat the Element in question. For instance "Hanger" columns have different support expectations than "Gravity" columns.
Inherits: Enum

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

--------------------------------------------------------------------------------

[CLASS] AreaLoad
Full Name: Autodesk.Revit.DB.Structure.AreaLoad
Description: An object that represents a force applied across an area.
Inherits: LoadBase

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
      Throws ArgumentNullException: A non-optional argument was null
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
      Throws ArgumentException: hostElemId is not permitted for this type of load. -or- One of the following requirements is not satisfied : - curve loops loops are not planar - curve loops loops are self-intersecting - curve loops loops contains zero length curves -or- Thrown when force vector is equal zero.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: Thrown if the host element id is a Curved Panel.
      Throws InvalidOperationException: Thrown if type could not be set for newly created area load.
    static AreaLoad Create(Document document, ElementId hostElemId, IList<CurveLoop> loops, XYZ forceVector, AreaLoadType symbol)
      Description: Creates a new custom area load within the project.
      @document: Document to which new area load will be added.
      @hostElemId: The analytical surface host element id for the area Load.
      @loops: The loops that define geometry of the area load. The curve loop collection should contains a closed loops consisting of lines.
      @forceVector: The force vector applied to the 1st reference point of the area load.
      @symbol: The symbol of the AreaLoad. Set to use default type.
      Returns: If successful, returns an object of the newly created AreaLoad. is returned if the operation fails.
      Throws ArgumentException: hostElemId is not permitted for this type of load. -or- One of the following requirements is not satisfied : - curve loops loops are not planar - curve loops loops are self-intersecting - curve loops loops contains zero length curves
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: Thrown if the host element id is a Curved Panel.
      Throws InvalidOperationException: Thrown if type could not be set for newly created area load.
    static AreaLoad Create(Document document, ElementId hostElemId, XYZ forceVector, AreaLoadType symbol)
      Description: Creates a new hosted area load within the project.
      @document: Document to which new area load will be added.
      @hostElemId: The analytical surface host element id for the area Load.
      @forceVector: The force vector applied to the 1st reference point of the area load.
      @symbol: The symbol of the AreaLoad. Set to use default type.
      Returns: If successful, returns an object of the newly created AreaLoad. is returned if the operation fails.
      Throws ArgumentException: The element hostElemId does not exist in the document -or- hostElemId is not permitted for this type of load. -or- Thrown when force vector is equal zero.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Thrown if type could not be set for newly created area load.
    IList<CurveLoop> GetLoops()
      Description: Returns curve loops that define geometry of the area load.
    XYZ GetRefPoint(int index)
      Description: Returns the physical location of the reference point.
      @index: The index of the point to return.
      Throws ArgumentException: Thrown when index is out of range.
    static bool IsCurveLoopsInsideHostBoundaries(Document doc, ElementId hostId, IList<CurveLoop> loops)
      Description: Checks if contour loops is inside host boundaries.
      @doc: Document.
      @hostId: The id of the analytical element that is about to host a load
      @loops: CurveLoops to be checked.
      Returns: Returns true if area load is positioned with entire distribution over the host, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidHostId(Document pDoc, ElementId hostId)
      Description: Indicates if the provided host id can host area loads The document containing both the host and the load The id of the analytical element that is about to host an area load True if an area load can be placed on the input host id
      Throws ArgumentNullException: A non-optional argument was null
    bool SetLoops(Document doc, IList<CurveLoop> newLoops)
      Description: Sets curve loops that define geometry of the area load.
      @doc: The document that contains the area load.
      @newLoops: Loops that define new geometry of the area load. The curve loop collection should contains a closed loops consisting of lines.
      Returns: Returns true if successful, false otherwise.
      Throws ArgumentException: One of the following requirements is not satisfied : - curve loops newLoops are not planar - curve loops newLoops are self-intersecting - curve loops newLoops contains zero length curves -or- Thrown when newLoops collection is empty. -or- Thrown when newLoops contains open loop. -or- Thrown when newLoops contains a loop consisting of other elements then lines.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This AreaLoad is not a hosted load. -or- This AreaLoad is a constrained load.

--------------------------------------------------------------------------------

[CLASS] AreaLoadType
Full Name: Autodesk.Revit.DB.Structure.AreaLoadType
Description: AreaLoadType class
Inherits: LoadTypeBase

--------------------------------------------------------------------------------

[CLASS] AreaReinforcement
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcement
Description: An object that represents an Area Reinforcement within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object. The Area Reinforcement element is available only in the Autodesk Revit Structure product.
Inherits: Element

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
      Throws ArgumentException: The element system was not found in the given document. -or- system does not host Rebar.
      Throws ArgumentNullException: A non-optional argument was null
    static AreaReinforcement Create(Document document, Element hostElement, XYZ majorDirection, ElementId areaReinforcementTypeId, ElementId rebarBarTypeId, ElementId rebarHookTypeId)
      Description: Creates a new AreaReinforcement object based on a host boundary.
      @document: The document.
      @hostElement: The element that will host the AreaReinforcement. The host can be a Structural Floor, Structural Wall, Structural Slab, or a Part created from a structural layer belonging to one of those element types.
      @majorDirection: A vector to define the major direction of the AreaReinforcement.
      @areaReinforcementTypeId: The id of the AreaReinforcementType.
      @rebarBarTypeId: The id of the RebarBarType.
      @rebarHookTypeId: The id of the RebarHookType. If this parameter is InvalidElementId, it means to create a rebar with no hooks.
      Returns: The newly created AreaReinforcement.
      Throws ArgumentException: The element hostElement was not found in the given document. -or- the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet. -or- areaReinforcementTypeId should refer to an AreaReinforcementType element. -or- rebarBarTypeId should refer to an RebarBarType element. -or- rebarHookTypeId should be invalid or refer to an RebarHookType element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: majorDirection has zero length.
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
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
      Throws ArgumentException: The input curveArray is empty. -or- The input curveArray contains at least one helical curve and is not supported for this operation. -or- The element hostElement was not found in the given document. -or- the host Element is not a valid host for Area Reinforcement, Path Reinforcement, Fabric Area or Fabric Sheet. -or- Curves in curveArray are not closed and continuous. -or- areaReinforcementTypeId should refer to an AreaReinforcementType element. -or- rebarBarTypeId should refer to an RebarBarType element. -or- rebarHookTypeId should be invalid or refer to an RebarHookType element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: majorDirection has zero length.
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
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
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
    Line GetLineFromLayerAtIndex(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Gets the line from the desired layer at the specified index.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Returns: Returns the line from the desired layer at the specified index.
      Throws ArgumentOutOfRangeException: linePositionIndex is not in the range [ 0, NumberOfLines-1 ]. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
    Transform GetMovedLineTransform(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Returns a transform representing the movement of the line relative to its default position along the direction of the desired layer.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Returns: The transform representing the movement of the line relative to its default position along the direction of the desired layer.
      Throws ArgumentOutOfRangeException: linePositionIndex is not in the range [ 0, NumberOfLines-1 ]. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
      Throws InvalidOperationException: This AreaReinforcement does not host Rebar.
    int GetNumberOfLines(AreaReinforcementLayerType layer)
      Description: Gets the number of lines on the specified layer. It also counts the excluded ones.
      @layer: The layer type for which will return the number of lines.
      Returns: Returns the number of lines on the specified layer.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
    IList<ElementId> GetRebarInSystemIds()
      Description: Returns the ids of the RebarInSystem elements owned by the AreaReinforcement element.
    bool IsLayerActive(AreaReinforcementLayerType layer)
      Description: Identifies if the layer is active or not.
      @layer: The layer that will be tested.
      Returns: Returns true if the input layer is active, false otherwise
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsLineIncluded(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Checks whether the line from the desired layer at the specified position is included or not.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Returns: Returns true if the line from the desired layer at the specified position is included, false otherwise.
      Throws ArgumentOutOfRangeException: linePositionIndex is not in the range [ 0, NumberOfLines-1 ]. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
      Throws InvalidOperationException: This AreaReinforcement does not host Rebar.
    bool IsUnobscuredInView(View view)
      Description: Checks if Area Reinforcement is shown unobscured in a view.
      @view: The view element
      Returns: True if Area Reinforcement is shown unobscured, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InapplicableDataException: This element doesn't have valid visibility data.
    void MoveLine(XYZ translation, AreaReinforcementLayerType layer, int linePositionIndex)
      Description: This method applies the translation to the line from the desired layer, at the specified position. If the line was already moved, the method will concatenate the translation with the existing movement. The line will be translated only along the direction of the specified layer.
      @translation: The translation vector.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: linePositionIndex is not in the range [ 0, NumberOfLines-1 ]. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
      Throws InvalidOperationException: This AreaReinforcement does not host Rebar.
    static IList<ElementId> RemoveAreaReinforcementSystem(Document doc, AreaReinforcement system)
      Description: Deletes the specified AreaReinforcement, and converts its RebarInSystem elements to equivalent Rebar elements.
      @doc: The document.
      @system: An AreaReinforcement element in the document.
      Returns: The ids of the newly created Rebar elements.
      Throws ArgumentException: The element system was not found in the given document. -or- system does not host Rebar.
      Throws ArgumentNullException: A non-optional argument was null
    void ResetMovedLineTransform(AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Reset the transformation representing the movement of the line relative to its default position along the direction of the specified layer. The moved line transform will be set to Identity.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Throws ArgumentOutOfRangeException: linePositionIndex is not in the range [ 0, NumberOfLines-1 ]. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
      Throws InvalidOperationException: This AreaReinforcement does not host Rebar.
    void SetLayerActive(bool active, AreaReinforcementLayerType layer)
      Description: Sets if the desired layer is active or not.
      @active: True to set the layer to be active, false otherwise.
      @layer: The layer type.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetLineIncluded(bool include, AreaReinforcementLayerType layer, int linePositionIndex)
      Description: Sets if the line from desired layer at the specified position is included or not.
      @include: True to include the line, false to exclude the line.
      @layer: The layer on which the line stays.
      @linePositionIndex: The index of the line from the desired layer. It should be an index between 0 and (NumberOfLines-1).
      Throws ArgumentOutOfRangeException: linePositionIndex is not in the range [ 0, NumberOfLines-1 ]. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InapplicableDataException: The layer layer isn't active.
      Throws InvalidOperationException: This AreaReinforcement does not host Rebar.
    void SetUnobscuredInView(View view, bool unobscured)
      Description: Sets Area Reinforcement to be shown unobscured in a view.
      @view: The view element
      @unobscured: True if Area Reinforcement is shown unobscured, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InapplicableDataException: This element doesn't have valid visibility data.

--------------------------------------------------------------------------------

[CLASS] AreaReinforcementCurve
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcementCurve
Description: An object that specifies the type of a floor in Autodesk Revit.
Remarks: The structural layers of the floor can be accessed via this object.
Inherits: CurveElement

  PROPERTIES:
    Curve Curve { get; }
      Description: Returns the 3D curve forming part of the boundary of an Area Reinforcement element.

--------------------------------------------------------------------------------

[ENUM] AreaReinforcementLayerType
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcementLayerType
Description: Describes the layers of an Area Reinforcement
Inherits: Enum

  Values:
    - TopOrFrontMajor = 0
    - TopOrFrontMinor = 1
    - BottomOrBackMajor = 2
    - BottomOrBackMinor = 3

--------------------------------------------------------------------------------

[CLASS] AreaReinforcementType
Full Name: Autodesk.Revit.DB.Structure.AreaReinforcementType
Description: An object that specifies the type of a Structural Area Reinforcement element in Autodesk Revit.
Remarks: The clear cover settings can be accessed via this object.
Inherits: ElementType

  METHODS:
    static ElementId CreateDefaultAreaReinforcementType(Document aDoc)
      Description: Creates a new AreaReinforcementType object with a default name.
      @aDoc: The document.
      Returns: The newly created type id.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] BendingDetailAngularDimensionsDisplayOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsDisplayOptions
Description: Describes the angular dimensions display options.
Inherits: Enum

  Values:
    - AllAngles = 0
    - Exclude90Degrees = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailAngularDimensionsMeasurementOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailAngularDimensionsMeasurementOptions
Description: Describes the angular dimension measurement options.
Inherits: Enum

  Values:
    - Inside = 0
    - Outside = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailBendDiameterDimensionType
Full Name: Autodesk.Revit.DB.Structure.BendingDetailBendDiameterDimensionType
Description: Describes the dimension type for bend diameter.
Inherits: Enum

  Values:
    - Radial = 0
    - Diameter = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailCustomFieldMultipleValuesIndicatorOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailCustomFieldMultipleValuesIndicatorOptions
Description: Describes how the parameters with multiple values will be represented.
Inherits: Enum

  Values:
    - Varying = 0
    - MinimumMaximum = 1

--------------------------------------------------------------------------------

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
      Description: Identifies if radial or diameter dimensions will be shown for hook fillets This property has a meaning only if BendDiameterDimensionsEnabled is set to true.
    bool BendDiameterDimensionsForSegmentsEnabled { get; set; }
      Description: Identifies if radial or diameter dimensions will be shown for the bends between segments. Radial or diameter dimesions for arc segments will be shown by default. This property has a menaning only if BendDiameterDimensionsEnabled is set to true.
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
      Description: Identifies if segment length dimensions for hooks will be shown or not. If this property is true, the SegmentLengthDimensionsEnabled should also be true to see segment length dimensions for hooks.
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

  Values:
    - Default = 0
    - OutsideOfDimensionLine = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailDisplayMode
Full Name: Autodesk.Revit.DB.Structure.BendingDetailDisplayMode
Description: Describes the mode in which the Bending Detail will be represented.
Inherits: Enum

  Values:
    - Realistic = 0
    - Schematic = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailDisplayParametersOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailDisplayParametersOptions
Description: Describes how the parameters will be represented.
Inherits: Enum

  Values:
    - ByValue = 0
    - ByName = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailFor3DShapesOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailFor3DShapesOptions
Description: Describes how the Bending Detail will be represented for 3D shapes.
Inherits: Enum

  Values:
    - IsometricView = 0
    - PlanView = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailLevelOfDetail
Full Name: Autodesk.Revit.DB.Structure.BendingDetailLevelOfDetail
Description: Describes the level of detail in which the Bending Detail will be represented.
Inherits: Enum

  Values:
    - ByView = 0
    - Coarse = 1
    - Fine = 2

--------------------------------------------------------------------------------

[ENUM] BendingDetailSegmentLengthsDisplayOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailSegmentLengthsDisplayOptions
Description: Describes if the segment lengths are represented using dimensions or just as text.
Inherits: Enum

  Values:
    - Text = 0
    - Dimension = 1

--------------------------------------------------------------------------------

[ENUM] BendingDetailSegmentsRepresentation
Full Name: Autodesk.Revit.DB.Structure.BendingDetailSegmentsRepresentation
Description: Describes how the Bending Detail will represent the bar segments.
Inherits: Enum

  Values:
    - Standard = 0
    - Unfold = 1
    - Offset = 2

--------------------------------------------------------------------------------

[ENUM] BendingDetailTypeMultipleValuesIndicatorOptions
Full Name: Autodesk.Revit.DB.Structure.BendingDetailTypeMultipleValuesIndicatorOptions
Description: Describes how the parameters with multiple values will be represented.
Inherits: Enum

  Values:
    - FromOneBar = 0
    - MinimumMaximum = 1

--------------------------------------------------------------------------------

[ENUM] BentFabricBendDirection
Full Name: Autodesk.Revit.DB.Structure.BentFabricBendDirection
Description: Direction in which FabricSheet is bent.
Inherits: Enum

  Values:
    - Major = 0
    - Minor = 1

--------------------------------------------------------------------------------

[ENUM] BentFabricStraightWiresLocation
Full Name: Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation
Description: Bent Fabric straight wires location. The side on wich straight wires will be loacted is determined by the start and end point of the first bent profile segment that specifies the direction of the curve loop on plane.
Inherits: Enum

  Values:
    - Right = 0
    - Left = 1

--------------------------------------------------------------------------------

[CLASS] BoundaryConditions
Full Name: Autodesk.Revit.DB.Structure.BoundaryConditions
Description: An object that represents a force applied across an area.
Inherits: Element

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
      Throws InvalidObjectException: Thrown when BoundaryConditions is not a BoundaryConditionsType::Line type.
    Transform GetDegreesOfFreedomCoordinateSystem()
      Description: Gets the origin and rotation of coordinate system that is used by translation and rotation parameters, like X Translation or Z Rotation.
      Returns: The coordinate system. Origin contains the position of the start of the boundary conditions. BasisX, BasisY and BasisZ contain the directions of the axes in the global coordinate system.
    IList<CurveLoop> GetLoops()
      Description: Returns curve loops that define geometry of the area boundary conditions.
      Returns: The curve loop collection.
      Throws InvalidObjectException: Thrown when BoundaryConditions is not a BoundaryConditionsType::Area type.
    BoundaryConditionsOrientTo GetOrientTo()
      Description: Returns the boundary conditions orientation option.
      Returns: The orientation option.
    void SetOrientTo(BoundaryConditionsOrientTo orientTo)
      Description: Sets the boundary condition orientation option.
      @orientTo: The new orientation option.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] BoundaryConditionsOrientTo
Full Name: Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo
Description: Specifies boundary condition orientation.
Inherits: Enum

  Values:
    - Project = 0
    - HostLocalCoordinateSystem = 1

--------------------------------------------------------------------------------

[ENUM] BoundaryConditionsType
Full Name: Autodesk.Revit.DB.Structure.BoundaryConditionsType
Description: This enum declares type of BoundaryConditions.
Inherits: Enum

  Values:
    - Point = 0
    - Line = 1
    - Area = 2

--------------------------------------------------------------------------------

[ENUM] BracePlanRepresentation
Full Name: Autodesk.Revit.DB.Structure.BracePlanRepresentation
Description: The possible representations for braces in plan views.
Inherits: Enum

  Values:
    - ParallelLine = 1
    - LineWithAngle = 2

--------------------------------------------------------------------------------

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
      Description: Construct an input point from 3d point. A new valid id will be auto-generated.
      Throws ArgumentNullException: A non-optional argument was null
    new ConnectionInputPoint(XYZ pt, Guid uid)
      Description: Construct an input point from 3d point and id.
      Throws ArgumentNullException: A non-optional argument was null
    new ConnectionInputPoint()
      Description: Construct a default input point.

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
      Description: Construct an input point info.
      Throws ArgumentNullException: A non-optional argument was null
    new ConnectionInputPointInfo()
      Description: Construct a default input point.

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

  Values:
    - Uniform = 0
    - VaryingLength = 1

--------------------------------------------------------------------------------

