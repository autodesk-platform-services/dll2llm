# Autodesk.Revit.DB.Architecture

NAMESPACE: Autodesk.Revit.DB.Architecture
--------------------------------------------------------------------------------

[CLASS] TopographyEditScope
Full Name: Autodesk.Revit.DB.Architecture.TopographyEditScope
Description: A TopographyEditScope allows an application to create and maintain an editing session for a TopographySurface.
Remarks: Start/end of a TopographyEditScope will start/end a transaction group. After a TopographyEditScope is started, an application can start transactions and edit the topography surface. Individual transactions the application creates inside TopographyEditScope will not appear in the undo menu. All transactions committed during the edit mode will be merged into a single one which will bear the given name passed into TopographyEditScope constructor.
Inherits: EditScope

  CONSTRUCTORS:
    new TopographyEditScope(Document document, string transactionName)
      Description: Instantiates a TopographyEditScope object.
      @document: The document for which this TopographyEditScope is going to be used.
      @transactionName: The name that will appear in the Undo menu in Revit after the TopographyEditScope is successfully committed.
      Throws ArgumentException: document is not a primary document, it is a linked document. -or- document is not a project document. -or- transactionName is an empty string.
      Throws ArgumentNullException: A non-optional argument was null

  METHODS:
    ElementId Start(ElementId topoSurfaceId)
      Description: Starts a topography surface edit mode for an existing TopographySurface element.
      @topoSurfaceId: The TopographySurface element to be edited.
      Returns: The Id of the topography Surface being edited.
      Throws ArgumentException: The ElementId topoSurfaceId does not represent a TopographySurface.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This TopographyEditScope is not permitted to start at this moment for one of the following possible reasons: The document is in read-only state, or the document is currently modifiable, or there already is another edit mode active in the document.

--------------------------------------------------------------------------------

[CLASS] TopographyLinkType
Full Name: Autodesk.Revit.DB.Architecture.TopographyLinkType
Description: This class represents the site file brought into the current Revit document.
Inherits: ElementType

  METHODS:
    LinkLoadResult Reload()
      Description: Loads or reloads the link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws InvalidOperationException: The element "this TopographyLinkType" is in a read-only document.

--------------------------------------------------------------------------------

[CLASS] TopographySurface
Full Name: Autodesk.Revit.DB.Architecture.TopographySurface
Description: Represents a TopographySurface element.
Remarks: TopographySurface and related classes have been replaced as of Revit 2024 with Toposolid and related classes. It is recommended that all newly created elements and modifications operate from the new Toposolid class. The TopographySurface element remains in the API for backwards compatibility and upgrade. A TopographySurface element in the Revit API represents: An actual topography surface which can have an arbitrary boundary and collection of points.A SiteSubRegion element bounded by a sketch.A topography surface created automatically by the introduction of a BuildingPad element. Identify a subregion with the IsSiteSubRegion property, and access the object that provides interfaces to manipulate the subregion via AsSiteSubRegion(). Identify a topography surface associated with a building pad with the isAssociatedWithBuildingPad property, and access the associated BuildingPad element via the property AssociatedBuildingPadId. If the element does represent a subregion or a topography surface associated with a building pad, some methods of this class are inapplicable.
Inherits: Element

  PROPERTIES:
    bool ArePointsEditable { get; }
      Description: Identifies whether the points of this topography surface can be edited independently. Topography surfaces created from external data will not allow editing of individual points.
    ElementId AssociatedBuildingPadId { get; }
      Description: The element id of the building pad which causes this topography surface to be formed.
    bool IsAssociatedWithBuildingPad { get; }
      Description: Identifies if this element represents a topography surface associated with a building pad.
    bool IsSiteSubRegion { get; }
      Description: Identifies if this element represents a subregion.
    ElementId MaterialId { get; set; }
      Description: The id of the material applied to this element.

  METHODS:
    void AddPoints(IList<XYZ> points)
      Description: Adds points to a topography surface.
      @points: A collection of points to be added.
      Throws ArgumentException: There are no points in the input points set. -or- One or more points shared the same XY location (even with different elevations). This is not permitted for topography surfaces.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This element is not a TopographySurface. -or- The topography surface is not editable. -or- The points of this topography surface are not editable. -or- The TopographySurface element is not in an active TopographyEditScope. Modification cannot be made on this TopographySurface.
      Throws ModificationForbiddenException: The document containing this TopographySurface is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this TopographySurface is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this TopographySurface has no open transaction.
    static bool ArePointsDistinct(IList<XYZ> points)
      Description: Identify whether the input points are distinct in XY location.
      @points: The points set to be checked.
      Returns: True if all points are distinct after ignoring the elevations, otherwise false.
      Throws ArgumentException: There are no points in the input points set.
      Throws ArgumentNullException: A non-optional argument was null
    SiteSubRegion AsSiteSubRegion()
      Description: Obtains the subregion object represented by this element.
      Returns: The SiteSubRegion element. If this does not represent a SiteSubRegion, this will be .
    void ChangePointElevation(XYZ point, double elevationValue)
      Description: Changes the elevation value for a point.
      @point: The point to be modified.
      @elevationValue: The new elevation value.
      Throws ArgumentException: The input point does not exist in the current topography surface.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for elevationValue must be no more than 30000 feet in absolute value.
      Throws InvalidOperationException: This element is not a TopographySurface. -or- The points of this topography surface are not editable. -or- The TopographySurface element is not in an active TopographyEditScope. Modification cannot be made on this TopographySurface.
      Throws ModificationForbiddenException: The document containing this TopographySurface is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this TopographySurface is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this TopographySurface has no open transaction.
    void ChangePointsElevation(IList<XYZ> points, double elevationValue)
      Description: Changes the elevation value for points
      @points: The points to be modified.
      @elevationValue: The new elevation value.
      Throws ArgumentException: There are no points in the input points set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for elevationValue must be no more than 30000 feet in absolute value.
      Throws InvalidOperationException: This element is not a TopographySurface. -or- The points of this topography surface are not editable. -or- The TopographySurface element is not in an active TopographyEditScope. Modification cannot be made on this TopographySurface. -or- None of the input points exists in the current TopographySurface.
      Throws ModificationForbiddenException: The document containing this TopographySurface is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this TopographySurface is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this TopographySurface has no open transaction.
    bool ContainsPoint(XYZ point)
      Description: Identifies whether the given point exists in the topography surface.
      @point: The point to be checked.
      Returns: True if the input point exists in the topography surface, otherwise false.
      Throws ArgumentNullException: A non-optional argument was null
    static TopographySurface Create(Document document, IList<XYZ> points, IList<PolymeshFacet> facets)
      Description: Creates a new topography surface element from facets and adds it to the document.
      @document: The document to be modified.
      @points: A collection of points. The points represent an enclosed area in the XY plane.
      @facets: Triangle facets composing a polygon mesh. Every facet contains 3 integers representing vertex indices.
      Returns: The new topography surface.
      Throws ArgumentException: document is not a project document. -or- There are invalid facets. Facets with more than two points with same x, y are not allowed. -or- There is(are) reference gap(s) between input arguments: points and facets.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static TopographySurface Create(Document document, IList<XYZ> points)
      Description: Creates a new topography surface element and adds it to the document.
      @document: The document to be modified.
      @points: A collection of points. The points represent an enclosed area in the XY plane. There can be only one point in the same XY location.
      Returns: The new topography surface.
      Throws ArgumentException: document is not a project document. -or- There are no points in the input points set. -or- There were not enough points to form a valid region (at least 3 are required), or the points were collinear ignoring elevation. -or- One or more points shared the same XY location (even with different elevations). This is not permitted for topography surfaces.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void DeletePoints(IList<XYZ> points)
      Description: Deletes points from a Topography surface.
      @points: A collection of points to be deleted.
      Throws ArgumentException: There are no points in the input points set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This element is not a TopographySurface. -or- The topography surface is not editable. -or- The TopographySurface element is not in an active TopographyEditScope. Modification cannot be made on this TopographySurface. -or- The points of this topography surface are not editable. -or- None of the input points exists in the current TopographySurface.
      Throws ModificationForbiddenException: The document containing this TopographySurface is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this TopographySurface is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this TopographySurface has no open transaction.
    IList<XYZ> FindPoints(Outline boundingBox)
      Description: Filters and returns only the points of the topography surface which lie within the input bounding box.
      @boundingBox: The 3D bounding box.
      Returns: The result points within the 3D bounding box
      Throws ArgumentException: boundingBox is an empty Outline.
      Throws ArgumentNullException: A non-optional argument was null
    IList<XYZ> GetBoundaryPoints()
      Description: Gets the points which are on the boundary of the topography surface.
      Returns: The collection of boundary points.
    IList<ElementId> GetHostedSubRegionIds()
      Description: Gets the ids of all subregion elements hosted on this topography surface.
      Returns: The hosted subregion ids.
      Throws InvalidOperationException: This element is not a TopographySurface.
    IList<XYZ> GetInteriorPoints()
      Description: Gets all of the points that are not boundary points for the topography surface.
      Returns: The collection of interior points.
    IList<XYZ> GetPoints()
      Description: Gets the points that define this topography surface.
      Returns: The collection of points.
    bool IsBoundaryPoint(XYZ point)
      Description: Identifies whether the given point is an existing boundary point of the current topography surface.
      @point: The point to be checked.
      Returns: Returns true if a given point is an existing boundary point. For TopographySurface and SiteSubRegion elements, it returns false if the given point is an existing interior point of current topography surface. For the topography surface associated with a BuildingPad element, it always returns true if the point is a part of the element (all points are boundary points for the topography surface associated with a BuildingPad element).
      Throws ArgumentException: The input point does not exist in the current topography surface.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidFaceSet(IList<PolymeshFacet> facets, IList<XYZ> points)
      Description: Identifies whether the facets can construct a valid topography surface.
      @facets: The facets to be checked.
      @points: A collection of points.
      Returns: True if the facets are valid, otherwise false.
      Throws ArgumentException: There are no points in the input points set. -or- There were not enough points to form a valid region (at least 3 are required), or the points were collinear ignoring elevation.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidRegion(IList<XYZ> points)
      Description: Identify whether the points can construct a valid region for a topography surface.
      @points: The points set to be checked.
      Returns: True if the size of points is not less than 3 and the points are not collinear after projecting to XY plane, that is, ignoring the elevation.
      Throws ArgumentException: There are no points in the input points set.
      Throws ArgumentNullException: A non-optional argument was null
    void MovePoint(XYZ movedPoint, XYZ targetPoint)
      Description: Moves a point in a TopographySurface to a new designated location.
      @movedPoint: The point to be moved.
      @targetPoint: The new designated location of this point will move to.
      Throws ArgumentException: The input point does not exist in the current topography surface.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This element is not a TopographySurface. -or- The points of this topography surface are not editable. -or- The TopographySurface element is not in an active TopographyEditScope. Modification cannot be made on this TopographySurface. -or- The input point doesn't exist in the current TopographySurface.
      Throws ModificationForbiddenException: The document containing this TopographySurface is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this TopographySurface is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this TopographySurface has no open transaction.
    void MovePoints(IList<XYZ> movedPoints, XYZ moveVector)
      Description: Moves a collection of points in a topography surface by a designated vector.
      @movedPoints: The points to be moved.
      @moveVector: The vector which describes the distance and direction for the move. Note that the Z value represents a change in elevation, pass Z=0 to move the point without changing the elevation.
      Throws ArgumentException: There are no points in the input points set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This element is not a TopographySurface. -or- The points of this topography surface are not editable. -or- The TopographySurface element is not in an active TopographyEditScope. Modification cannot be made on this TopographySurface. -or- None of the input points exists in the current TopographySurface.
      Throws ModificationForbiddenException: The document containing this TopographySurface is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this TopographySurface is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this TopographySurface has no open transaction.

--------------------------------------------------------------------------------

[CLASS] TopRail
Full Name: Autodesk.Revit.DB.Architecture.TopRail
Description: Represents a top rail element in Autodesk Revit.
Inherits: ContinuousRail

--------------------------------------------------------------------------------

[CLASS] TopRailType
Full Name: Autodesk.Revit.DB.Architecture.TopRailType
Description: A rail type object that is used in the generation of top rail.
Inherits: ContinuousRailType

--------------------------------------------------------------------------------

[ENUM] TreadNosingPosition
Full Name: Autodesk.Revit.DB.Architecture.TreadNosingPosition
Description: Represents on which edges of the nosing to apply the nosing profile.
Inherits: Enum

  Values:
    - FrontOnly = 0
    - FrontAndLeft = 1
    - FrontAndRight = 2
    - FrontLeftAndRight = 3

--------------------------------------------------------------------------------

[ENUM] WinderPathResult
Full Name: Autodesk.Revit.DB.Architecture.WinderPathResult
Description: Flag indicates whether curves are valid to use as base lines for winder path.
Inherits: Enum

  Values:
    - Success = 0
    - NumberOutOfRange = 1
    - Unbound = 2
    - Noncontinuous = 3
    - NotOpenLoop = 4
    - TooShort = 5
    - ColinearOrOverlap = 6
    - SelfIntersect = 7
    - InvalidCurveType = 8
    - NotSupported = 9

--------------------------------------------------------------------------------

