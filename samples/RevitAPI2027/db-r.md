# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[CLASS] RadialArray
Full Name: Autodesk.Revit.DB.RadialArray
Description: An object that represents an Array created along a circle arc within the Revit project.
Inherits: BaseArray

  PROPERTIES:
    int NumMembers { get; set; }
      Description: Retrieves or changes the number of arrayed members. Array placeholder members in the family environment are not counted.

  METHODS:
    static ICollection<ElementId> ArrayElementsWithoutAssociation(Document aDoc, View dBView, ICollection<ElementId> ids, int count, Line axis, double angle, ArrayAnchorMember anchorMember)
      Description: Creates a new radial array from a set of elements based on an input rotation axis.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements. If elements include view-specific elements, they must belong to this view.
      @ids: The set of elements to array. The position of the rotation axis is determined by the cumulative center of the elements' bounding boxes.
      @count: The number of array members to create. The accepted range is from 3 to 200 in a project document, and between 0 and 200 in a family document.
      @axis: The rotation axis.
      @angle: The angle in radians of the rotation.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The elements created by the operation.
      Throws ArgumentException: The given element id set is empty. -or- One or more elements in ids do not exist in the document. -or- One or more elements in ids is owned by different views and thus cannot be arrayed together. -or- One or more elements in ids is not arrayable. -or- count must be between 3 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The rotation axis is invalid to array the elements. -or- Angle value must be not zero.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the radial array.
    static ICollection<ElementId> ArrayElementWithoutAssociation(Document aDoc, View dBView, ElementId id, int count, Line axis, double angle, ArrayAnchorMember anchorMember)
      Description: Creates a new radial array from a single element based on an input rotation axis.
      @aDoc: The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.
      @dBView: The view.
      @id: The element to array. The position of the rotation axis is determined by the center of the element's bounding boxes.
      @count: The number of array members to create. The accepted range is from 3 to 200 in a project document, and between 0 and 200 in a family document.
      @axis: The rotation axis.
      @angle: The angle in radians of the rotation.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The elements created by the operation.
      Throws ArgumentException: The element id does not exist in the document -or- id is not arrayable. -or- count must be between 3 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The rotation axis is invalid to array the element. -or- Angle value must be not zero.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the radial array.
    static RadialArray Create(Document aDoc, View dBView, ElementId id, int count, Line axis, double angle, ArrayAnchorMember anchorMember)
      Description: Creates a new radial array element from a single element based on an input rotation axis.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.
      @id: The element to array. The position of the rotation axis is determined by the center of the element's bounding boxes.
      @count: The number of array members to create. The accepted range is from 3 to 200 in a project document, and between 0 and 200 in a family document.
      @axis: The rotation axis.
      @angle: The angle in radians of the rotation.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The new radial array element.
      Throws ArgumentException: The element id does not exist in the document -or- id is not arrayable. -or- count must be between 3 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The rotation axis is invalid to array the element. -or- Angle value must be not zero.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the radial array.
    static RadialArray Create(Document aDoc, View dBView, ICollection<ElementId> ids, int count, Line axis, double angle, ArrayAnchorMember anchorMember)
      Description: Creates a new radial array element from a set of elements based on an input rotation axis.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements. If elements include view-specific elements, they must belong to this view.
      @ids: The set of elements to array. The position of the rotation axis is determined by the cumulative center of the elements' bounding boxes.
      @count: The number of array members to create. The accepted range is from 3 to 200 in a project document, and between 0 and 200 in a family document.
      @axis: The rotation axis.
      @angle: The angle in radians of the rotation.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The new radial array element.
      Throws ArgumentException: The given element id set is empty. -or- One or more elements in ids do not exist in the document. -or- One or more elements in ids is owned by different views and thus cannot be arrayed together. -or- One or more elements in ids is not arrayable. -or- count must be between 3 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The rotation axis is invalid to array the elements. -or- Angle value must be not zero.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the radial array.
    ICollection<ElementId> GetCopiedMemberIds()
      Description: Retrieves the copied member ids from the array. The first item in an array contains the original elements from which the array was created. All other items in the array are copies.
      Returns: The copied member ids of the Array
    static int GetMinimumSize(Document document)
      Description: Returns the minimum size for a radial array based on the document.
      @document: The document.
      Returns: The minimum size of an array.
      Throws ArgumentNullException: A non-optional argument was null
    int GetNumberOfMembersIncludingPlaceholders()
      Description: Returns the number of items in an array, including placeholder items in families.
      Returns: The number of elements in an array, including placeholder items in families.
    ICollection<ElementId> GetOriginalMemberIds()
      Description: Retrieves the ids for the original elements from which the array was created. These elements form the first item in the array.
      Returns: The original member ids of the Array
    static bool IsRotationAngleValid(double angle)
      Description: This indicates whether the input angle is valid.
      @angle: The angle.
      Returns: True if the value of angle is not zero, false otherwise.
    static bool IsValidNumberOfMembers(int count, Document pADoc)
      Description: This indicates whether the input count is a valid size for an array based on the document.
      @count: The count.
      @pADoc: The document.
      Returns: True if an array can be set to the specified count in the given document, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] RadialDimension
Full Name: Autodesk.Revit.DB.RadialDimension
Description: An object that represents an Radial Dimension within the Revit project.
Inherits: Dimension

  METHODS:
    static RadialDimension Create(Document document, View dbView, Reference arcRef, bool isDiameter)
      Description: Creates a new instance of an Radial Dimension element within the project.
      @document: The document where new Radial Dimension is created.
      @dbView: The view in which the Radial Dimension will appear.
      @arcRef: The reference which the Radial Dimension will witness.
      @isDiameter: Set to true to create a Diameter dimension
      Returns: The newly created Radial Dimension instance, or if the operation fails.
      Throws ArgumentException: Reference should be an Arc reference and the origin should lie within the Arc.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[ENUM] RasterQualityType
Full Name: Autodesk.Revit.DB.RasterQualityType
Description: An enumerated type listing the options for raster quality.
Inherits: Enum

  Values:
    - Low = 72
    - Medium = 150
    - High = 300
    - Presentation = 600

--------------------------------------------------------------------------------

[CLASS] Rectangle
Full Name: Autodesk.Revit.DB.Rectangle
Description: Stores a set of four integers that represent the left, top, right and bottom of a rectangle.
Remarks: It usually represents a rectangle on the screen. Left must be less than right and top must be less than bottom.
Implements: IDisposable

  CONSTRUCTORS:
    new Rectangle(int left, int top, int right, int bottom)
      Description: Creates an Rectangle instance with the specified four integers that represent the left, top, right and bottom of a rectangle.
      @left: The x-coordinate of the top-left corner.
      @top: The y-coordinate of the top-left corner.
      @right: The x-coordinate of the bottom-right corner.
      @bottom: The y-coordinate of the bottom-right corner.
    new Rectangle()
      Description: Create an empty Rectangle instance with values (0,0,0,0).
    new Rectangle(Rectangle other)
      Description: Constructs a new copy of the input ScreenRectangle object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    int Bottom { get; set; }
      Description: The y-coordinate of the bottom-right corner of the rectangle.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Left { get; set; }
      Description: The x-coordinate of the top-left corner of the rectangle.
    int Right { get; set; }
      Description: The x-coordinate of the bottom-right corner of the rectangle.
    int Top { get; set; }
      Description: The y-coordinate of the top-left corner of the rectangle.

  METHODS:
    void Dispose()
    bool IsNormalized()
      Description: Returns true if the rectangle coordinates are normalized to the screen coordinate space; that is, left is less than right and top is less than bottom.

--------------------------------------------------------------------------------

[ENUM] RectangularGridSegmentOrientation
Full Name: Autodesk.Revit.DB.RectangularGridSegmentOrientation
Description: The orientation type of rectangular grid segment.
Inherits: Enum

  Values:
    - Vertical = 0
    - Horizontal = 1

--------------------------------------------------------------------------------

[CLASS] Reference
Full Name: Autodesk.Revit.DB.Reference
Description: A stable reference to a geometric object in a Revit model.
Inherits: APIObject

  CONSTRUCTORS:
    new Reference(Element element)
      Description: Creates a Reference with the supplied element.
      @element: The element to create a reference.
      Throws ArgumentNullException: Thrown when the parameter is .

  PROPERTIES:
    ElementId ElementId { get; }
      Description: The element id for this reference.
    ElementReferenceType ElementReferenceType { get; }
      Description: The type of reference.
    XYZ GlobalPoint { get; }
      Description: The position on which the reference is hit.
    ElementId LinkedElementId { get; }
      Description: The id of the top-level element in the linked document that is referred to by this reference.
    UV UVPoint { get; }
      Description: The UV parameters of the reference, if the reference contains a face.

  METHODS:
    bool Contains(Reference reference)
      Description: Checks if given reference identifies part of object identified by this reference.
      @reference: Another reference.
      Returns: Returns true if given reference identifies part of object identified by this reference, false otherwise.
      Throws ArgumentNullException: Thrown when argument is .
    string ConvertToStableRepresentation(Document document)
      Description: Converts the reference to a stable String representation.
      @document: The document.
      Throws ArgumentNullException: document was .
      Throws InvalidObjectException: Reference contained element ids not found in this document.
    Reference CreateLinkReference(RevitLinkInstance revitLinkInstance)
      Description: Creates a Reference from a Reference in an RVT Link.
      @revitLinkInstance: Id of the RevitLinkInstance that contains the reference.
      Throws ArgumentNullException: Thrown when revitLinkInstance is .
    Reference CreateReferenceInLink()
      Description: Creates a Reference in an RVT Link from a Reference in the RVT host file.
    bool EqualTo(Reference reference)
      Description: Checks if given reference is equal to this reference.
      @reference: Another reference.
      Returns: Returns true if given reference is equal to this reference, false otherwise.
      Throws ArgumentNullException: Thrown when argument is .
    static Reference ParseFromStableRepresentation(Document document, string representation)
      Description: Converts a stable String representation of a reference to a Reference object.
      @document: The document.
      @representation: The reference representation.
      Throws ArgumentNullException: One or more arguments was .
      Throws ArgumentException: Reference representation could not be successfully parsed, or element id obtained from reference representation could not be found in this document.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ReferenceableViewUtils
Full Name: Autodesk.Revit.DB.ReferenceableViewUtils
Description: Utilities related to reference views such as reference sections and reference callouts.

  METHODS:
    static void ChangeReferencedView(Document document, ElementId referenceId, ElementId desiredViewId)
      Description: Changes a particular reference view (such as a reference section or reference callout) to refer to a different View.
      @document: The document containing the elements.
      @referenceId: The reference view that will be changed to refer to a different View.
      @desiredViewId: The id of the View that the reference section or callout will refer to.
      Throws ArgumentException: referenceId is not a valid reference view. -or- desiredViewId is not a view that can be referenced by referenceId.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetReferencedViewId(Document document, ElementId referenceId)
      Description: Gets the id of the view referenced by a reference view (such as a reference section or reference callout).
      @document: The document containing the elements.
      @referenceId: The reference view that will be changed to refer to a different View.
      Returns: The id of the referenced view.
      Throws ArgumentException: referenceId is not a valid reference view.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ReferenceArray
Full Name: Autodesk.Revit.DB.ReferenceArray
Description: An array that contains reference objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ReferenceArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Reference Item { get; set; }
    int Size { get; }
      Description: Returns the number of references that are in the array.

  METHODS:
    void Append(Reference item)
      Description: Add the reference to the end of the array.
      @item: The reference to be added.
    void Clear()
      Description: Removes every reference from the array, rendering it empty.
    ReferenceArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Reference item, int index)
      Description: Insert the specified reference into the array.
      @item: The reference to be inserted into the array.
      @index: The reference will be inserted before this index.
    ReferenceArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[CLASS] ReferenceArrayArray
Full Name: Autodesk.Revit.DB.ReferenceArrayArray
Description: An array that contains ReferenceArray objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ReferenceArrayArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    ReferenceArray Item { get; set; }
    int Size { get; }
      Description: Returns the number of ReferenceArrays that are in the array.

  METHODS:
    void Append(ReferenceArray item)
    void Clear()
      Description: Removes every ReferenceArray from the array, rendering it empty.
    ReferenceArrayArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(ReferenceArray item, int index)
    ReferenceArrayArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ReferenceArrayArrayIterator
Full Name: Autodesk.Revit.DB.ReferenceArrayArrayIterator
Description: An iterator to a ReferenceArray array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ReferenceArrayArrayIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the array.
    void Reset()
      Description: Bring the iterator back to the start of the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ReferenceArrayIterator
Full Name: Autodesk.Revit.DB.ReferenceArrayIterator
Description: An iterator to a reference array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ReferenceArrayIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the array.
    void Reset()
      Description: Bring the iterator back to the start of the array.

--------------------------------------------------------------------------------

[ENUM] ReferenceBaseOnHostType
Full Name: Autodesk.Revit.DB.ReferenceBaseOnHostType
Description: This enumeration is used to classify the Reference Base on Host type .
Inherits: Enum

  Values:
    - PrimaryEnd = 0
    - SecondaryEnd = 1
    - Midpoint = 2

--------------------------------------------------------------------------------

[CLASS] ReferenceIntersector
Full Name: Autodesk.Revit.DB.ReferenceIntersector
Description: A class used to find and return elements that intersect a ray created from an origin point and direction.
Remarks: An instance of this class can be constructed to return any 3D geometric element that intersects the ray created by the origin and direction, or to return a subset of elements based on filtering and flags. The caller can opt to filter the results using an ElementFilter, or by applying a specific list of acceptable elements. The caller can also specify the type of object to be returned, which might be whole elements, geometry objects, or a combination. In all cases the caller is required to supply a 3D view for evaluation; the view and visibility settings on the input view will determine if a particular element is returned (for example, hidden elements will never be returned by this tool, nor will elements whose geometry is outside the section box of the view).The class is configured so that a single instance can be constructed and used for multiple evaluations of different rays. The results of the evaluation are not preserved between invocations on the same ReferenceIntersector.The class also offers an option to return element results encountered in Revit Links. When the FindReferencesInRevitLinks flag is set, the results may include elements in the host document and in any RevitLinkInstance encountered, depending on the other flags set. See the remarks for FindReferencesInRevitLinks for details on how the flags affect the results obtained from links.
Implements: IDisposable

  CONSTRUCTORS:
    new ReferenceIntersector(ElementFilter filter, FindReferenceTarget targetType, View3D view3d)
      Description: Constructs a ReferenceIntersector which is set to return intersections from any element which passes an input filter.
      @filter: The element filter. All references will belong to elements passing this filter.
      @targetType: The target type of references to return.
      @view3d: The view in which to find references.
      Throws ArgumentException: Returns true if the view is not a view template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ReferenceIntersector(ICollection<ElementId> targetElementIds, FindReferenceTarget targetType, View3D view3d)
      Description: Constructs a ReferenceIntersector which is set to return intersections from any of a set of target elements.
      @targetElementIds: The target element ids.
      @targetType: The target type of references to return.
      @view3d: The view in which to find references.
      Throws ArgumentException: Returns true if the view is not a view template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ReferenceIntersector(ElementId targetElementId, FindReferenceTarget targetType, View3D view3d)
      Description: Constructs a ReferenceIntersector which is set to return intersections from a single target element only.
      @targetElementId: The target element id.
      @targetType: The target type of references to return.
      @view3d: The view in which to find references.
      Throws ArgumentException: Returns true if the view is not a view template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ReferenceIntersector(View3D view3d)
      Description: Constructs a ReferenceIntersector which is set to return intersections from all elements and representing all reference target types.
      @view3d: The view in which to find references.
      Throws ArgumentException: Returns true if the view is not a view template.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool FindReferencesInRevitLinks { get; set; }
      Description: Determines if references inside Revit Links should be found.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    FindReferenceTarget TargetType { get; set; }
      Description: The type of reference to find.
    ElementId ViewId { get; set; }
      Description: The id of the 3D view used for evaluation.

  METHODS:
    void Dispose()
    IList<ReferenceWithContext> Find(XYZ origin, XYZ direction)
      Description: Projects a ray from the origin along the given direction, and returns all references from intersected elements which match the ReferenceIntersector's criteria.
      @origin: The origin of the ray.
      @direction: The direction of the ray.
      Returns: A collection containing the intersected references.
      Throws ArgumentNullException: A non-optional argument was null
    ReferenceWithContext FindNearest(XYZ origin, XYZ direction)
      Description: Projects a ray from the origin along the given direction, and returns the nearest reference from intersected elements which match the ReferenceIntersector's criteria.
      @origin: The origin of the ray.
      @direction: The direction of the ray.
      Returns: The intersected reference nearest to the ray origin, if none is found
      Throws ArgumentNullException: A non-optional argument was null
    ElementFilter GetFilter()
      Description: Gets the ElementFilter used in intersection testing.
      Returns: The ElementFilter, or if no filter is set.
    ICollection<ElementId> GetTargetElementIds()
      Description: Gets the set of ElementIds to test from in intersection testing.
      Returns: The target ElementIds.
    void SetFilter(ElementFilter filter)
      Description: Sets the ElementFilter used in intersection testing.
      @filter: The ElementFilter. Pass to remove the existing filter.
    void SetTargetElementIds(ICollection<ElementId> elementIds)
      Description: Sets the set of ElementIds to test from in intersection testing.
      @elementIds: The target ElementIds.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ReferencePlane
Full Name: Autodesk.Revit.DB.ReferencePlane
Description: Represents a reference plane of Autodesk Revit.
Inherits: DatumPlane

  PROPERTIES:
    XYZ BubbleEnd { get; set; }
      Description: The bubble end of the reference plane.
    XYZ Direction { get; set; }
      Description: The direction of the reference plane.
    XYZ FreeEnd { get; set; }
      Description: The free end of the reference plane.
    string Name { get; set; }
      Description: The name property of the reference plane.
    XYZ Normal { get; }
      Description: The normal vector of the reference plane.

  METHODS:
    void Flip()
      Description: Flips the orientation of the reference plane.
    Plane GetPlane()
      Description: Returns the geometry plane to which the reference plane is assigned.
      Returns: The geometry plane to which the reference plane is assigned.
    Reference GetReference()
      Description: Returns the geometry reference of the reference plane.
      Returns: The geometry reference of the reference plane.

--------------------------------------------------------------------------------

[CLASS] ReferencePoint
Full Name: Autodesk.Revit.DB.ReferencePoint
Description: A reference point in an Autodesk Revit family.
Remarks: A ReferencePoint represents a point in space together with a local coordinate system. ReferencePoints can be free, or constrained to other elements in several ways. When the point is constrained, the coordinate system is also constrained in certain ways.
Inherits: Element

  PROPERTIES:
    CoordinatePlaneVisibility CoordinatePlaneVisibility { get; set; }
      Description: Visibility settings for the coordinate reference planes.
    string Name { get; set; }
    XYZ Position { get; set; }
      Description: The position of the ReferencePoint.
    bool ShowNormalReferencePlaneOnly { get; set; }
      Description: Whether all three coordinate planes are shown, or only the normal (XY) plane.
    bool Visible { get; set; }
      Description: Whether the point is visible when the family is loaded into a project.

  METHODS:
    Reference GetCoordinatePlaneReferenceXY()
      Description: A reference for the XY plane of the coordinate system.
    Reference GetCoordinatePlaneReferenceXZ()
      Description: A reference for the XZ plane of the coordinate system.
    Reference GetCoordinatePlaneReferenceYZ()
      Description: A reference for the YZ plane of the coordinate system.
    Transform GetCoordinateSystem()
      Description: The position and orientation of the ReferencePoint.
    ElementId GetHubId()
      Description: Id of associated Hub.
    CurveByPointsArray GetInterpolatingCurves()
      Description: The set of CurveByPoints elements that interpolate a ReferencePoint.
    PointElementReference GetPointElementReference()
      Description: Retrieve a copy of the rule that computes the location of the ReferencePoint relative to other elements in the document.
      Returns: A PointElementReference object, or if the ReferencePoint does not have a reference.
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the point.
      Returns: A copy of visibility settings for the ReferencePoint.
    void SetCoordinateSystem(Transform coordinateSystem)
      Description: The position and orientation of the ReferencePoint.
      Throws ArgumentException: Thrown when coordinateSystem does not specify an orthonormal basis.
      Throws InvalidOperationException: Thrown when CoordinateSystem is set while the Reference property is not , and the ReferencePoint is unable to move to the new location.
    void SetPointElementReference(PointElementReference pointElementReference)
      Description: Change the rule for computing the location of the ReferencePoint relative to other elements in the document.
      @pointElementReference: An object specifying a rule for the location and orientation of a ReferencePoint. (Note: The ReferencePoint object does not store the pointElementReference object after this call.)
      Throws InvalidOperationException: Thrown when Reference is set to a non-null object, and the ReferencePoint is unable to move to the new reference.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the point.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws InvalidOperationException: Thrown when regeneration failed.

--------------------------------------------------------------------------------

[CLASS] ReferencePointArray
Full Name: Autodesk.Revit.DB.ReferencePointArray
Description: An array that contains reference objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ReferencePointArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    ReferencePoint Item { get; set; }
    int Size { get; }
      Description: Returns the number of references that are in the array.

  METHODS:
    void Append(ReferencePoint item)
    void Clear()
      Description: Removes every reference from the array, rendering it empty.
    ReferencePointArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(ReferencePoint item, int index)
    ReferencePointArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ReferencePointArrayIterator
Full Name: Autodesk.Revit.DB.ReferencePointArrayIterator
Description: An iterator to a reference array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ReferencePointArrayIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the array.
    void Reset()
      Description: Bring the iterator back to the start of the array.

--------------------------------------------------------------------------------

[ENUM] ReferenceType
Full Name: Autodesk.Revit.DB.ReferenceType
Description: Reference types of curve element.
Inherits: Enum

  Values:
    - None = 0
    - WeakReference = 1
    - StrongReference = 2

--------------------------------------------------------------------------------

[CLASS] ReferenceUtils
Full Name: Autodesk.Revit.DB.ReferenceUtils
Description: This is an utility class used for helper functions needed to manage references between elements and update geometry tags
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ReferenceWithContext
Full Name: Autodesk.Revit.DB.ReferenceWithContext
Description: An object including a reference to a geometric object and related context, as instance transform etc.
Remarks: The ReferenceWithContext is used as the returned value from the method Autodesk::Revit::DB::Document::FindReferencesWithContextByDirection, ReferenceIntersector.Find(XYZ, XYZ), or ReferenceIntersector.FindNearest(XYZ, XYZ). It includes a reference intersecting a line extended in a certain direction from an origin point and the context of the geometric object, as the transform and proximity.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Proximity { get; }
      Description: The proximity value to the ray's origin when the reference is returned by FindReferencesWithContextByDirection(XYZ, XYZ, View3D) or ReferenceIntersector.Find(XYZ, XYZ).

  METHODS:
    void Dispose()
    Transform GetInstanceTransform()
      Description: Gets the transform of the instance.
      Returns: The transform of an instance when the reference is returned by FindReferencesWithContextByDirection(XYZ, XYZ, View3D) or ReferenceIntersector.Find(XYZ, XYZ).
    Reference GetReference()
      Description: Gets the reference of the geometric object.
      Returns: The reference of a geometric object when it is returned by FindReferencesWithContextByDirection(XYZ, XYZ, View3D) or ReferenceIntersector.Find(XYZ, XYZ).

--------------------------------------------------------------------------------

[CLASS] RelinquishedItems
Full Name: Autodesk.Revit.DB.RelinquishedItems
Description: List of elements and worksets that were relinquished by the current user.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ICollection<ElementId> GetRelinquishedElements()
      Description: The elements that were relinquished by the current user.
    ICollection<WorksetId> GetRelinquishedWorksets()
      Description: The elements that were relinquished by the current user.

--------------------------------------------------------------------------------

[CLASS] RelinquishOptions
Full Name: Autodesk.Revit.DB.RelinquishOptions
Description: Options to control behavior of relinquishing ownership of elements and worksets.
Remarks: The settings correspond to the checkboxes in the Synchronize with Central dialog in the section "After synchronizing, relinquish the following worksets and elements:".An element can be owned (reflected in the "Edited By" parameter) either by being checked out ("borrowed") or by belonging to a checked out workset.Relinquishing a workset will relinquish all its unmodified elements that the current user owns.The subtle interactions between checking out elements and checking out worksets are beyond the scope of the documentation for this class. But as an example, if a wall is borrowed (explicitly checked out) and then its workset is checked out, then the wall is no longer considered borrowed because the workset ownership implicitly grants ownership of all elements in the workset (except elements borrowed by other users).
Implements: IDisposable

  CONSTRUCTORS:
    new RelinquishOptions(bool relinquishEverything)
      Description: Constructs a new instance of RelinquishOptions.
      @relinquishEverything: The value to apply to all of the members.

  PROPERTIES:
    bool CheckedOutElements { get; set; }
      Description: True means all elements checked out by the current user should be relinquished. False means none of these are relinquished.
    bool FamilyWorksets { get; set; }
      Description: True means all family worksets owned by the current user should be relinquished. False means none of these are relinquished.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool StandardWorksets { get; set; }
      Description: True means all project standards worksets owned by the current user should be relinquished. False means none of these are relinquished.
    bool UserWorksets { get; set; }
      Description: True means all user-created worksets owned by the current user should be relinquished. False means none of these are relinquished.
    bool ViewWorksets { get; set; }
      Description: True means all view worksets owned by the current user should be relinquished. False means none of these are relinquished.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ReloadLatestOptions
Full Name: Autodesk.Revit.DB.ReloadLatestOptions
Description: Options to control behavior of pure reload latest (not part of synchronize with central).
Implements: IDisposable

  CONSTRUCTORS:
    new ReloadLatestOptions()
      Description: Constructs a new ReloadLatestOptions object.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ReloadSwapOutInfo
Full Name: Autodesk.Revit.DB.ReloadSwapOutInfo
Description: This object contains information about fabrication parts swapped out during reload.
Implements: IDisposable

  PROPERTIES:
    int CurrentVersion { get; }
      Description: New version.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId Part { get; }
      Description: The ElementId of part being swapped.
    int PreviousVersion { get; }
      Description: Previous version.
    bool WasSwapped { get; }
      Description: Whether the swap out was successful.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] RenderDuration
Full Name: Autodesk.Revit.DB.RenderDuration
Description: An enumerated type containing possible duration types to do Raytracer render.
Inherits: Enum

  Values:
    - ByLevel = 0
    - ByTime = 1
    - UntilSatisfactory = 2

--------------------------------------------------------------------------------

[CLASS] RenderingImageExposureSettings
Full Name: Autodesk.Revit.DB.RenderingImageExposureSettings
Description: Represents the exposure settings of rendering.
Implements: IDisposable

  PROPERTIES:
    double ExposureValue { get; set; }
      Description: The value of rendering image exposure.
    double Highlights { get; set; }
      Description: The highlights value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Saturation { get; set; }
      Description: The value of rendering image saturation.
    double Shadows { get; set; }
      Description: The shadows value.
    double WhitePoint { get; set; }
      Description: The white point value.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] RenderingQuality
Full Name: Autodesk.Revit.DB.RenderingQuality
Description: Indicates the rendering quality in rendering settings.
Inherits: Enum

  Values:
    - Draft = 11
    - Medium = 13
    - High = 14
    - VeryHigh = 15
    - Custom = 16

--------------------------------------------------------------------------------

[CLASS] RenderingQualitySettings
Full Name: Autodesk.Revit.DB.RenderingQualitySettings
Description: Represents the quality settings of rendering.
Remarks: The other properties in this class can only be modified if the RenderingQuality property is currently set to Custom.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LightAndMaterialAccuracyMode LightAndMaterialAccuracyMode { get; set; }
      Description: A value that controls light and material accuracy mode.
    RenderDuration RenderDuration { get; set; }
      Description: A value that controls render duration.
    RenderingQuality RenderingQuality { get; set; }
      Description: The quality applied for rendering.
    int RenderLevel { get; set; }
      Description: The render target level as a numerical value between 1 and 40.
    int RenderTime { get; set; }
      Description: The render target time as a numerical value between 1 and 32768.

  METHODS:
    void Dispose()
    bool IsCustomQuality()
      Description: Checks if the current rendering quality is custom or not.
      Returns: True if the current rendering quality is custom, false otherwise.
    bool IsValidRenderLevel(int value)
      Description: Validate the render level is between 1 and 40
      @value: The render level value to validate.
      Returns: True if the render level value is in the proper range, false otherwise.
    bool IsValidRenderTime(int value)
      Description: Validate the render time is between 1 and 32768.
      @value: The render time value to validate.
      Returns: True if the value is in the proper range, false otherwise.

--------------------------------------------------------------------------------

[CLASS] RenderingSettings
Full Name: Autodesk.Revit.DB.RenderingSettings
Description: Represents the rendering settings for a 3d view.
Implements: IDisposable

  PROPERTIES:
    BackgroundStyle BackgroundStyle { get; set; }
      Description: The enum value that controls the background style for rendering.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LightingSource LightingSource { get; set; }
      Description: The lighting scheme type.
    PrinterResolution PrinterResolution { get; set; }
      Description: The resolution level when using printer.
    ResolutionTarget ResolutionTarget { get; set; }
      Description: The resolution target.
    int ResolutionValue { get; }
      Description: The rendering resolution in dots per inch (DPI).
    bool UsesRegionRendering { get; set; }
      Description: The bool value that indicates whether to use region rendering.

  METHODS:
    void Dispose()
    BackgroundSettings GetBackgroundSettings()
      Description: Returns an object that represents the rendering background settings.
      Returns: The rendering background settings.
    RenderingImageExposureSettings GetRenderingImageExposureSettings()
      Description: Returns an object that represents the rendering image exposure settings.
      Returns: The rendering image exposure settings.
    RenderingQualitySettings GetRenderingQualitySettings()
      Description: Returns an object that represents the rendering quality settings.
      Returns: The rendering quality settings.
    Outline GetRenderingRegionOutline()
      Description: Returns the outline of the rendering region.
      Returns: The outline of the rendering region.
      Throws InvalidOperationException: The RenderingSettings are not currently using region rendering.
    void SetBackgroundSettings(BackgroundSettings background)
      Description: Changes the rendering background settings details for the current background style.
      @background: An instance of the new rendering background settings.
      Throws ArgumentNullException: A non-optional argument was null
    void SetRenderingImageExposureSettings(RenderingImageExposureSettings exposure)
      Description: Changes the rendering image exposure settings.
      @exposure: An instance of the new rendering image exposure settings.
      Throws ArgumentNullException: A non-optional argument was null
    void SetRenderingQualitySettings(RenderingQualitySettings settings)
      Description: Change rendering quality settings.
      @settings: An instance of the new rendering quality settings.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] RenderNode
Full Name: Autodesk.Revit.DB.RenderNode
Description: This is the base class of all render nodes in a model-exporting process.
Remarks: A node can be both geometric (such as an element, light, etc.) or non-geometric (e.g. material). Some types of nodes are container modes, which include other render nodes.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string NodeName { get; }
      Description: A readable name of the output node.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] RenderNodeAction
Full Name: Autodesk.Revit.DB.RenderNodeAction
Description: Enumerated actions for processing a render node during custom export.
Inherits: Enum

  Values:
    - Proceed = 0
    - Skip = 1

--------------------------------------------------------------------------------

[CLASS] RepeaterBounds
Full Name: Autodesk.Revit.DB.RepeaterBounds
Description: Represents bounds of the array of repeating references in 0, 1, or 2 dimensions. (See RepeatingReferenceSource).
Implements: IDisposable

  PROPERTIES:
    int DimensionCount { get; }
      Description: The number of dimensions of the bounds (0, 1 or 2 for zero, one or two dimensional arrays.)
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    RepeaterCoordinates AdjustForCyclicalBounds(RepeaterCoordinates coordinates)
      Description: Shifts the input coordinates in the cyclical dimensions so that they fall in the [lower bounds, upper bounds] range.
      @coordinates: The coordinates.
      Returns: The adjusted coordinates.
      Throws ArgumentException: The coordinates coordinates have incompatible number of dimensions.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The bounds must have at least one dimension.
    bool AreCoordinatesInBounds(RepeaterCoordinates coordinates, bool treatCyclicalBoundsAsInfinite)
      Description: Determines whether given coordinates are within the bounds.
      @coordinates: The coordinates.
      @treatCyclicalBoundsAsInfinite: True if cyclical directions should be treated as unbounded.
      Returns: True if the coordinates are within the bounds.
      Throws ArgumentException: The coordinates coordinates have incompatible number of dimensions.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The bounds must have at least one dimension.
    void Dispose()
    int GetLowerBound(int dimension)
      Description: Returns the smallest index of the array in the given dimension.
      @dimension: The dimension.
      Returns: The smallest index of the array in the given dimension.
      Throws ArgumentException: The dimension is invalid for these bounds.
      Throws InvalidOperationException: The bounds must have at least one dimension.
    int GetUpperBound(int dimension)
      Description: Returns the highest index of the array in the given dimension.
      @dimension: The dimension.
      Returns: The highest index of the array in the given dimension.
      Throws ArgumentException: The dimension is invalid for these bounds.
      Throws InvalidOperationException: The bounds must have at least one dimension.
    bool IsCyclical(int dimension)
      Description: True if the array doesn't have finite bounds in the given dimension. Cyclical bounds indicate that the array forms a closed loop in the given dimension.
      @dimension: The dimension.
      Returns: True if the bounds are cyclical in the given dimension.
      Throws ArgumentException: The dimension is invalid for these bounds.
      Throws InvalidOperationException: The bounds must have at least one dimension.

--------------------------------------------------------------------------------

[CLASS] RepeaterCoordinates
Full Name: Autodesk.Revit.DB.RepeaterCoordinates
Description: Represents coordinates in the array of repeating references in 0, 1, or 2 dimensions.
Implements: IDisposable

  CONSTRUCTORS:
    new RepeaterCoordinates(int x, int y)
      Description: Creates two dimensional coordinates.
      @x: The coordinate in first dimension.
      @y: The coordinate in second dimension.
    new RepeaterCoordinates(int x)
      Description: Creates one dimensional coordinates.
      @x: The coordinate.
    new RepeaterCoordinates()
      Description: Creates zero dimensional coordinates.

  PROPERTIES:
    int DimensionCount { get; }
      Description: The number of dimensions of the coordinates (0, 1 or 2 for zero, one or two dimensional arrays.)
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    int GetCoordinate(int dimension)
      Description: Returns the coordinate in the given dimension.
      @dimension: The dimension.
      Returns: The coordinate.
      Throws ArgumentException: The dimension is invalid for these coordinates.
      Throws InvalidOperationException: The coordinates must have at least one dimension.

--------------------------------------------------------------------------------

[CLASS] RepeatingReferenceSource
Full Name: Autodesk.Revit.DB.RepeatingReferenceSource
Description: Represents a collection of repeating references.
Remarks: The RepeatingReferenceSource class is the building block for setting up component repeaters. Repeating references are arranged in zero, one or two dimensional arrays. The RepeatingReferenceSource class represents this array of references and provides access to individual repeating references. Note that there may be gaps in the array (for example a repeating reference source formed by a divided surface with holes, or is non-rectangular surface.) Repeating reference sources are a property of an element. Only point elements, divided paths and divided surface elements support repeating reference sources. These element respectively have 0, 1 and 2 dimensional repeating references. Use the HasRepeatingReferenceSource() method to query whether an element supports repeating reference sources and the GetDefaultRepeatingReferenceSource() method to obtain a repeating reference source from a given element. See the ComponentRepeater and ComponentRepeaterSlot classes for more information.
Implements: IDisposable

  PROPERTIES:
    int DimensionCount { get; }
      Description: The dimension count of the repeating reference array.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    RepeaterBounds GetBounds()
      Description: Returns information about the boundaries of the repeating reference array.
      Returns: The bounds of the repeating reference source.
      Throws InvalidOperationException: The repeating reference source is no longer valid.
    static RepeatingReferenceSource GetDefaultRepeatingReferenceSource(Document document, ElementId elementId)
      Description: Returns the default repeating reference source for a given element.
      @document: The document that contains the element.
      @elementId: The id of the element.
      Returns: The default repeating reference source of the given element.
      Throws ArgumentException: The element elementId does not exist in the document -or- The element does not have any repeating reference sources.
      Throws ArgumentNullException: A non-optional argument was null
    Reference GetReference(RepeaterCoordinates coordinates)
      Description: Returns an individual repeating reference given by coordinates in the array, or if there is no reference at the coordinates (for example if there is a hole in a divided surface.)
      @coordinates: The coordinates in the array of repeating references.
      Returns: The repeating reference.
      Throws ArgumentException: The coordinates are not valid for the repeating reference source. This could be because of a mismatched dimensionality or because the coordinates are outside the bounds of the repeating reference source.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The repeating reference source is no longer valid.
    static bool HasRepeatingReferenceSource(Document document, ElementId elementId)
      Description: Determines whether an element has any repeating reference sources that can be used when creating component repeaters.
      @document: The document that contains the element.
      @elementId: The id of the element.
      Returns: True if the element has any repeating reference sources.
      Throws ArgumentException: The element elementId does not exist in the document
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ResolutionTarget
Full Name: Autodesk.Revit.DB.ResolutionTarget
Description: Indicates the resolution target(Screen or Printer) used for rendering settings.
Inherits: Enum

  Values:
    - Screen = 0
    - Printer = 1

--------------------------------------------------------------------------------

[ENUM] ResourceVersionStatus
Full Name: Autodesk.Revit.DB.ResourceVersionStatus
Description: An enum indicating whether a resource is current or out of date.
Inherits: Enum

  Values:
    - Current = 0
    - OutOfDate = 1
    - Unknown = 2

--------------------------------------------------------------------------------

[CLASS] Revision
Full Name: Autodesk.Revit.DB.Revision
Description: Represents a single revision in the project.
Remarks: The Revision object represents the data related to a single revision in the project. Revision clouds and tags can be associated with a particular Revision object to display its properties on sheets. The revisions in the project are stored in a specific order called the revision sequence. The revision sequence represents the conceptual sequence in which revisions will be issued.
Inherits: Element

  PROPERTIES:
    string Description { get; set; }
      Description: The description of this Revision.
    bool Issued { get; set; }
      Description: Indicates whether this Revision has been issued.
    string IssuedBy { get; set; }
      Description: Indicates who has issued or will issue this Revision.
    string IssuedTo { get; set; }
      Description: Indicates to whom this Revision was or will be issued.
    string RevisionDate { get; set; }
      Description: The date of this Revision.
    string RevisionNumber { get; }
      Description: The Revision number of this revision.
    ElementId RevisionNumberingSequenceId { get; set; }
      Description: The id of the revision numbering sequence which controls this revision's numbering.
    int SequenceNumber { get; }
      Description: The Sequence Number of this Revision.
    RevisionVisibility Visibility { get; set; }
      Description: Controls the visibility of revision clouds and revision tags related to this Revision.

  METHODS:
    static ISet<ElementId> CombineWithNext(Document document, ElementId revisionId)
      Description: Combines the specified Revision with the next Revision.
      @document: The Document containing the Revisions.
      @revisionId: The Revision that should have its clouds and tags associated with the next Revision.
      Returns: The ids of all RevisionClouds that were reassigned to the next Revision.
      Throws ArgumentException: revisionId is not a valid Revision. -or- This operation cannot be performed because revisionId is an issued Revision. -or- revisionId cannot be combined with the next Revision because either revisionId is the last Revision or the next Revision has already been issued.
      Throws ArgumentNullException: A non-optional argument was null
    static ISet<ElementId> CombineWithPrevious(Document document, ElementId revisionId)
      Description: Combines the specified Revision with the previous Revision.
      @document: The Document containing the Revisions.
      @revisionId: The Revision that should have its clouds and tags associated with the previous Revision.
      Returns: The ids of all RevisionClouds that were reassigned to the previous Revision.
      Throws ArgumentException: revisionId is not a valid Revision. -or- This operation cannot be performed because revisionId is an issued Revision. -or- revisionId cannot be combined with the previous Revision because either revisionId is the first Revision or the previous Revision has already been issued.
      Throws ArgumentNullException: A non-optional argument was null
    static Revision Create(Document document)
      Description: Creates a new Revision in the project.
      @document: The document of the new Revision.
      Returns: The newly created Revision.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> GetAllRevisionIds(Document document)
      Description: Returns the ids of all Revisions in the project ordered by sequence number.
      @document: The document containing the Revisions.
      Returns: The ids of all the Revisions in the document ordered by sequence number.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static void ReorderRevisionSequence(Document document, IList<ElementId> newSequence)
      Description: Reorders the sequence of Revisions in the project.
      @document: The document in which the Revision sequence should be reordered.
      @newSequence: The new sequence of Revisions.
      Throws ArgumentException: newSequence does not contain every Revision exactly once.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] RevisionCloud
Full Name: Autodesk.Revit.DB.RevisionCloud
Description: A RevisionCloud is a graphical "cloud" that can be displayed on a view or sheet to indicate where revisions in the model have occurred.
Remarks: RevisionClouds are view specific and can be created in most graphical views, except 3D. Unlike most Elements, RevisionClouds may be added directly to a ViewSheet. Each RevisionCloud is associated with one Revision. When a RevisionCloud is visible on a ViewSheet (either because it is directly placed on that ViewSheet or because it is visible in a View placed on the ViewSheet), any revision schedules displayed on the ViewSheet will automatically include the Revision associated with the RevisionCloud.Note also that when a RevisionCloud is created in a ViewLegend, it is treated as a legend representation of what a RevisionCloud looks like rather than as an actual indication of a change to the model. As a result, RevisionClouds in ViewLegends will not affect the contents of revision schedules.RevisionClouds are created from a collection of sketched curves. Each curve will have a series of "cloud bumps" drawn along it to form the appearance of a cloud. There is no requirement that the curves form closed loops.
Inherits: Element

  PROPERTIES:
    ElementId RevisionId { get; set; }
      Description: The Revision associated with this RevisionCloud.

  METHODS:
    static RevisionCloud Create(Document document, View view, ElementId revisionId, IList<Curve> curves)
      Description: Creates a new RevisionCloud in the model.
      @document: The document in which the RevisionCloud should be created.
      @view: The View in which the RevisionCloud should appear.
      @revisionId: The Revision to associate with the new RevisionCloud.
      @curves: The curves that will form the RevisionCloud's sketch.
      Returns: The newly created RevisionCloud.
      Throws ArgumentException: document is not a project document. -or- revisionId is not a valid Revision. -or- This operation cannot be performed because revisionId is an issued Revision. -or- view is not a View that can support RevisionClouds. -or- The provided Curves curves cannot be used as the basis for a RevisionCloud. Either the list is empty or one or more of the Curves could not be projected onto the View's plane.
      Throws ArgumentNullException: A non-optional argument was null
    ISet<ElementId> GetSheetIds()
      Description: Returns the ids of the ViewSheets where this RevisionCloud may appear and contribute to the sheet's revision schedule.
      Returns: The ids of the ViewSheets where this RevisionCloud may appear.
    IList<Curve> GetSketchCurves()
      Description: Returns copies of the Curves that form this RevisionCloud.
      Returns: Copies of the sketched curves that form this RevisionCloud.
    bool IsRevisionIssued()
      Description: Indicates whether the Revision associated with this RevisionCloud has been issued.
      Returns: True if the Revision has been issued, False otherwise.

--------------------------------------------------------------------------------

[ENUM] RevisionNumbering
Full Name: Autodesk.Revit.DB.RevisionNumbering
Description: The options for how revision numbers should be displayed on sheets within a project.
Inherits: Enum

  Values:
    - PerProject = 0
    - PerSheet = 1

--------------------------------------------------------------------------------

[CLASS] RevisionNumberingSequence
Full Name: Autodesk.Revit.DB.RevisionNumberingSequence
Description: Defines the sequences by which numbers are assigned to Revisions.
Remarks: Revision numbering is numeric or alphanumeric. Revision numbering is assigned to Revisions to control the numbering scheme of that Revision.
Inherits: Element

  PROPERTIES:
    RevisionNumberType NumberType { get; }
      Description: Indicates the revision number type of the revision numbering sequence.
    string SequenceName { get; set; }
      Description: The name of this revision numbering sequence.

  METHODS:
    static RevisionNumberingSequence CreateAlphanumericSequence(Document document, string name, AlphanumericRevisionSettings settings)
      Description: Creates a new alphanumeric revision numbering sequence in the document.
      @document: The document of the new revision numbering sequence.
      @name: The name for the revision numbering sequence.
      @settings: The alphanumeric settings for the revision numbering sequence.
      Returns: The newly created revision numbering sequence.
      Throws ArgumentException: document is not a project document. -or- name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- settings is not a valid AlphanumericRevisionSettings.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static RevisionNumberingSequence CreateNumericSequence(Document document, string name, NumericRevisionSettings settings)
      Description: Creates a new numeric revision numbering sequence in the document.
      @document: The document of the new revision numbering sequence.
      @name: The name for the revision numbering sequence.
      @settings: The numeric settings for the revision numbering sequence.
      Returns: The newly created revision numbering sequence.
      Throws ArgumentException: document is not a project document. -or- name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- settings is not a valid NumericRevisionSettings.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ISet<ElementId> GetAllRevisionNumberingSequences(Document document)
      Description: Gets all of the revision numbering sequences from the document.
      @document: The document that contains the sequences.
      Returns: The revision numbering sequences from the document.
      Throws ArgumentNullException: A non-optional argument was null
    AlphanumericRevisionSettings GetAlphanumericRevisionSettings()
      Description: Returns a copy of the AlphanumericRevisionSettings owned by this revision numbering sequence.
      Returns: The copy of the AlphaumericRevisionSettings owned by this revision numbering sequence.
      Throws InvalidOperationException: This RevisionNumberingSequence doesn't own a valid alphanumeric revision settings.
    NumericRevisionSettings GetNumericRevisionSettings()
      Description: Returns a copy of the NumericRevisionSettings owned by this revision numbering sequence.
      Returns: The copy of the NumericRevisionSettings owned by this revision numbering sequence.
      Throws InvalidOperationException: This RevisionNumberingSequence doesn't own a valid numeric revision settings.
    bool HasValidAlphanumericRevisionSettings()
      Description: Checks whether the revision numbering sequence owns a valid alphanumeric revision settings.
      Returns: True if the revision numbering sequence owns a valid alphanumeric revision settings.
    bool HasValidNumericRevisionSettings()
      Description: Checks whether the revision numbering sequence owns a valid numeric revision settings.
      Returns: True if the revision numbering sequence owns a valid numeric revision settings.
    bool HasValidRevisionSettingsForNumberType()
      Description: Checks whether the revision numbering sequence owns a valid revision settings for number type.
      Returns: True if the revision numbering sequence owns a valid revision settings for number type.
    void SetAlphanumericRevisionSettings(AlphanumericRevisionSettings settings)
      Description: Replaces the current alphanumeric revision numbering settings with the provided settings.
      @settings: The AlphanumericRevisionSettings to be applied to alphanumeric revision numbering.
      Throws ArgumentException: settings is not a valid AlphanumericRevisionSettings.
      Throws ArgumentNullException: A non-optional argument was null
    void SetNumericRevisionSettings(NumericRevisionSettings settings)
      Description: Replaces the current numeric revision numbering settings with the provided settings.
      @settings: The NumericRevisionSettings to be applied to numeric revision numbering.
      Throws ArgumentException: settings is not a valid NumericRevisionSettings.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] RevisionNumberType
Full Name: Autodesk.Revit.DB.RevisionNumberType
Description: Determines how a particular revision will be numbered.
Inherits: Enum

  Values:
    - Numeric = 0
    - None = 2
    - Alphanumeric = 3

--------------------------------------------------------------------------------

[CLASS] RevisionSettings
Full Name: Autodesk.Revit.DB.RevisionSettings
Description: Provides access to project-wide settings related to revisions.
Remarks: This class provides access to the project-wide settings that affect the appearance and numbering of revisions and revision clouds. The settings are only available in project documents.
Inherits: Element

  PROPERTIES:
    double RevisionCloudSpacing { get; set; }
      Description: Determines the size in paper space of revision clouds drawn in a project.
    RevisionNumbering RevisionNumbering { get; set; }
      Description: Determines how the revision number values will display on sheets.

  METHODS:
    static RevisionSettings GetRevisionSettings(Document ccda)
      Description: Returns the RevisionSettings for the given project document.
      @ccda: The document to get the RevisionSettings from.
      Returns: The RevisionSettings for the document.
      Throws ArgumentException: ccda is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAcceptableRevisionCloudSpacing(double rawValue)
      Description: Rounds the given raw value and checks whether it is an acceptable cloud spacing value after it is rounded.
      @rawValue: The raw value to check. This value need not be rounded prior to calling this function.
      Returns: True if the value will be acceptable after rounding, False otherwise
    static double RoundRevisionCloudSpacing(Document ccda, double rawValue)
      Description: Rounds the given revision cloud spacing value according to the document's settings.
      @ccda: The document to use for rounding.
      @rawValue: The unrounded value.
      Returns: The rounded revision cloud spacing.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] RevisionVisibility
Full Name: Autodesk.Revit.DB.RevisionVisibility
Description: Determines whether Revision Clouds and Revision Tags will be visible in the project.
Inherits: Enum

  Values:
    - Hidden = 0
    - CloudAndTagVisible = 1
    - TagVisible = 2

--------------------------------------------------------------------------------

[CLASS] RevitLinkGraphicsSettings
Full Name: Autodesk.Revit.DB.RevitLinkGraphicsSettings
Description: Settings to override display of Revit link in a view.
Implements: IDisposable

  CONSTRUCTORS:
    new RevitLinkGraphicsSettings()
      Description: Creates a new RevitLinkGraphicsSettings instance.

  PROPERTIES:
    LinkVisibility ColorFill { get; set; }
      Description: The color fill of RevitLinkGraphicsSettings. The color fill can be set to ByHostView or ByLinkView. Only a view that supports color fill can have this property set to ByLinkView. To check if the view supports the color fill use SupportedColorFillCategoryIds to see if there is any supported color fill category for the view. The LinkedViewId parameter must have a value assigned if this property is set to ByLinkView.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LinkVisibility LineWeights { get; set; }
      Description: The line weights of RevitLinkGraphicsSettings. The line weights can be set to ByHostView or ByLinkView.
    ElementId LinkedViewId { get; set; }
      Description: The id of the linked view associated with this RevitLinkGraphicsSettings, or InvalidElementId if no view is selected. If the LinkVisibilityType is set to ByLinkView, then there must be a valid LinkedViewId.
    LinkVisibility LinkVisibilityType { get; set; }
      Description: The visibility type of RevitLinkGraphicsSettings. If the type is set to ByHostView or ByLinkView, then the dependent properties of RevitLinkGraphicsSettings will be reset to their default state. The state of dependent properties can be changed later.
    LinkVisibility NestedLinks { get; set; }
      Description: The nested links of RevitLinkGraphicsSettings. The nested links can be set to ByHostView or ByLinkView.
    LinkVisibility ObjectStyles { get; set; }
      Description: The object styles of RevitLinkGraphicsSettings. The object styles can be set to ByHostView or ByLinkView.
    LinkVisibility ViewFilterType { get; set; }
      Description: The view filter type of RevitLinkGraphicsSettings. If the LinkVisibilityType is set to ByHostView, then the view filter type should be set to ByHostView. If the LinkVisibilityType is set to ByLinkView, then the view filter type should be set to ByLinkView. If the LinkVisibilityType is set to Custom, then the view filter type can be set to any value from LinkVisibility enum. The LinkedViewId parameter must have a value assigned if this property is set to ByLinkView. The Custom value corresponds to None option in the UI.
    LinkVisibility ViewRange { get; set; }
      Description: The view range of RevitLinkGraphicsSettings. The view range can be set to ByHostView or ByLinkView. Only a view that supports view range can have this property set to ByLinkView. To check if the view supports the view range use Autodesk::Revit::DB::LinkVisibility::IsViewRangeSupported. The LinkedViewId parameter must have a value assigned if this property is set to ByLinkView.

  METHODS:
    void Dispose()
    ViewDiscipline GetDiscipline()
      Description: The linked document discipline of RevitLinkGraphicsSettings.
    LinkVisibility GetDisciplineType()
      Description: The discipline type of RevitLinkGraphicsSettings.
    ElementId GetPhaseFilterId()
      Description: The linked document phase filter id of RevitLinkGraphicsSettings, or InvalidElementId if there is no phase filter explicitly assigned.
    LinkVisibility GetPhaseFilterType()
      Description: The phase filter type of RevitLinkGraphicsSettings.
    ElementId GetPhaseId()
      Description: The linked document phase id of RevitLinkGraphicsSettings, or InvalidElementId if there is no phase explicitly assigned.
    LinkVisibility GetPhaseType()
      Description: The phase type of RevitLinkGraphicsSettings.
    ViewDetailLevel GetViewDetailLevel()
      Description: The linked document view detail level of RevitLinkGraphicsSettings.
    LinkVisibility GetViewDetailLevelType()
      Description: The view detail level type of RevitLinkGraphicsSettings.
    static bool IsViewRangeSupported(View view)
      Description: Returns true if the input view supports ViewRange settings of RevitLinkGraphicsSettings, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetDiscipline(LinkVisibility disciplineType, ViewDiscipline discipline)
      Description: Sets discipline and discipline type of RevitLinkGraphicsSettings.
      @disciplineType: The type of the discipline.
      @discipline: The discipline. If disciplineType is set to ByHostView or ByLinkView the discipline must be set to Architectural.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetPhase(LinkVisibility phaseType, ElementId phaseId)
      Description: Sets phase id and phase type of RevitLinkGraphicsSettings.
      @phaseType: The type of the phase.
      @phaseId: The id of the phase from the linked document or InvalidElementId. If phaseType is set to ByHostView or ByLinkView the phaseId must be set to InvalidElementId. If phaseType is set to Custom and phaseId is InvalidElementId the phase will reference to the last phase from the linked document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetPhaseFilter(LinkVisibility phaseFilterType, ElementId phaseFilterId)
      Description: Sets phase filter id and phase filter type of RevitLinkGraphicsSettings.
      @phaseFilterType: The type of the phase filter.
      @phaseFilterId: The id of the phase filter from the linked document or InvalidElementId. If phaseFilterType is set to ByHostView or ByLinkView the phaseFilterId must be set to InvalidElementId. If phaseFilterType is set to Custom and phaseFilterId is InvalidElementId the state of the phase filter will correspond to the None option in the UI.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetViewDetailLevel(LinkVisibility viewDetailLevelType, ViewDetailLevel viewDetailLevel)
      Description: Sets view detail level and detail level type of RevitLinkGraphicsSettings.
      @viewDetailLevelType: The type of the view detail level.
      @viewDetailLevel: The view detail level. If viewDetailLevelType is set to ByHostView or ByLinkView the viewDetailLevel must be set to Undefined.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] RevitLinkInstance
Full Name: Autodesk.Revit.DB.RevitLinkInstance
Description: Represents an instance of a RevitLinkType.
Inherits: Instance

  METHODS:
    static RevitLinkInstance Create(Document document, ElementId revitLinkTypeId, ImportPlacement placement)
      Description: Creates a new instance of a linked Revit project (RevitLinkType).
      @document: The document in which the new instance should be created.
      @revitLinkTypeId: The element id of the RevitLinkType.
      @placement: The mode where to place the RevitLinkInstance. Set this option to place the view at the origin or by shared coordinates.
      Returns: The newly-created RevitLinkInstance.
      Throws ArgumentException: revitLinkTypeId isn't a RevitLinkType. -or- revitLinkTypeId is not a top-level link. -or- revitLinkTypeId is not a loaded RevitLinkType -or- document is not a project document. -or- placement isn't supported.Only Origin or Shared placement is supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The placement is Shared, and the host model and the link do not share the same coordinate system. Or the placement is Shared, and the shared coordinates of the host model do not match the GIS coordinate system of the linked file.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static RevitLinkInstance Create(Document document, ElementId revitLinkTypeId)
      Description: Creates a new instance of a linked Revit project (RevitLinkType).
      @document: The document in which the new instance should be created.
      @revitLinkTypeId: The element id of the RevitLinkType.
      Returns: The newly-created RevitLinkInstance.
      Throws ArgumentException: revitLinkTypeId isn't a RevitLinkType. -or- revitLinkTypeId is not a top-level link. -or- revitLinkTypeId is not a loaded RevitLinkType -or- document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    Document GetLinkDocument()
      Description: The document associated with the Revit link.
    void MoveBasePointToHostBasePoint(bool resetToOriginalRotation)
      Description: Moves this link instance so that the base point in the linked document is aligned to the base point in the host document. This is a one-time movement and does not set up any shared coordinates relationship.If the rotation angle of this link instance was changed after insertion, the rotation angle can be preserved or reset to the original insertion angle.
      @resetToOriginalRotation: Sets to true if:restoring the original insertion angle of the link instance after it is moved if there was a rotation \ mirror transform on the link instance.there was no a rotation \ mirror transform on the link instance.Sets to false to retain the current angle of the link instance after it is moved if there was a rotation \ mirror transform on the link instance.
      Throws InvalidOperationException: This RevitLinkInstance is not an instance of a loaded RevitLinkType. -or- This RevitLinkInstance is not an instance of a top-level RevitLinkType. -or- The operation is not permitted because the element is pinned.
    void MoveOriginToHostOrigin(bool resetToOriginalRotation)
      Description: Moves this link instance so that the internal origin of the linked document is aligned to the internal origin of the host document. This is a one-time movement and does not set up any shared coordinates relationship.If the rotation angle of the link instance was changed after insertion, the rotation angle can be preserved or reset to the original insertion angle.
      @resetToOriginalRotation: Sets to true if:restoring the original insertion angle of the link instance after it is moved if there was a rotation \ mirror transform on the link instance.there was no a rotation \ mirror transform on the link instance.Sets to false to retain the current angle of the link instance after it is moved if there was a rotation \ mirror transform on the link instance.
      Throws InvalidOperationException: This RevitLinkInstance is not an instance of a loaded RevitLinkType. -or- This RevitLinkInstance is not an instance of a top-level RevitLinkType. -or- The operation is not permitted because the element is pinned.

--------------------------------------------------------------------------------

[CLASS] RevitLinkOperations
Full Name: Autodesk.Revit.DB.RevitLinkOperations
Description: This class is used to extend the IExternalResourceServer interface with methods to support operations specifically related to Revit links.
Remarks: The class owns single-method interfaces which are used as callbacks to perform specific operations on Revit link external resources.An empty RevitLinkOperations instance is passed to an IExternalResourceServer (inside an ExternalResourceServerExtensions object) via the GetTypeSpecificServerOperations method. The server provider can then add their own implemented interface objects to the RevitLinkOperations, thus making them available to Revit to use as callbacks.Supporting these additional, type-specific operations is not absolutely required, but is strongly recommended in order for users to be able to perform all the same operations they would with locally-accessed Revit links.
Inherits: LinkOperations

  METHODS:
    void SetGetLocalPathForOpenCallback(IGetLocalPathForOpenCallback makeLocalCopyForOpen)
      Description: Sets the IGetLocalPathForOpenCallback that will support the "Open (and Unload)" command for Revit links obtained from an IExternalResourceServer.
      @makeLocalCopyForOpen: The IGetLocalPathForOpenCallback that will support the "Open (and Unload)" command.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] RevitLinkOptions
Full Name: Autodesk.Revit.DB.RevitLinkOptions
Description: This class contains the options in use when creating or loading a Revit link.
Implements: IDisposable

  CONSTRUCTORS:
    new RevitLinkOptions(bool relative)
      Description: Creates a RevitLinkOptions object, specifying relative or absolute path type. If the link is workshared, all worksets will be opened.
      @relative: True if the link should use a relative path. False if it should use an absolute path.
    new RevitLinkOptions(bool relative, WorksetConfiguration config)
      Description: Creates a RevitLinkOptions object, specifying relative or absolute path type, and the desired workset configuration.
      @relative: True if the link should use a relative path. False if it should use an absolute path.
      @config: A WorksetConfiguration object specifying the worksets to open when creating the link. Leave as if the file is not workshared. Optionally, this may also be for a workshared file, in which case Revit will open all worksets.
      Throws ArgumentNullException: A non-optional argument was null
    new RevitLinkOptions(RevitLinkOptions other)
      Description: Constructs a new copy of the input RevitLinkOptions object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsRelative { get; set; }
      Description: The type of path to use when creating the link. If true, Revit will store a relative path for the link. If false, Revit will store an absolute path. If the link is to a Revit Server location, isRelative must be false.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    WorksetConfiguration GetWorksetConfiguration()
      Description: Gets the set of worksets to open when creating the link.
    void SetWorksetConfiguration(WorksetConfiguration config)
      Description: Sets the set of worksets to open when creating the link.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] RevitLinkType
Full Name: Autodesk.Revit.DB.RevitLinkType
Description: This class represents another Revit Document ("link") brought into the current one ("host").
Remarks: Revit links can be nested - There can exist linked files which themselves contain links. A "top-level" link is one linked directly into the host, while a "nested" link is linked into some parent link. This can go through arbitrarily many layers. Some functions give the example "A -> B -> C". This means that there is a host file, A, which has a top-level link, B, and a nested link C which has been linked into B as an attachment.
Inherits: ElementType

  PROPERTIES:
    AttachmentType AttachmentType { get; set; }
      Description: The attachment/overlay status of this link.
    bool IsNestedLink { get; }
      Description: Indicates whether this link is a nested or top-level link.
    bool LocallyUnloaded { get; }
      Description: Checks whether a Revit link in a local model is unloaded only for the current user.
    PathType PathType { get; set; }
      Description: The type of path the link uses.

  METHODS:
    static LinkLoadResult Create(Document document, ExternalResourceReference resourceReference, RevitLinkOptions options)
      Description: Creates a new Revit link type from an external resource reference and loads the linked document.
      @document: The document in which to create the Revit link.
      @resourceReference: An external resource reference describing the source of the linked Revit document.
      @options: An options class for loading Revit links. The path type information will be ignored.
      Returns: An object containing the results of creating and loading the Revit link type. It contains the ElementId of the new link.
      Throws ArgumentException: document is not a project document. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support Revit links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server. -or- The link type referred to by the ExternalResourceReference "resourceReference" already exists in the document. You cannot create another copy of the link type. You can create instances with RevitLinkInstance.Create(), or reload the link using RevitLinkType.Reload().
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Revit cannot customize worksets for this model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static LinkLoadResult Create(Document document, ModelPath path, RevitLinkOptions options)
      Description: Creates a new Revit link type and loads the linked document.
      @document: The document in which to create the Revit link.
      @path: The path of the link to load. This may be a path of local disk, Revit Server or Cloud. This must be a full path.
      @options: An options class for loading Revit links.
      Returns: An object containing the results of creating and loading the Revit link type. It contains the ElementId of the new link.
      Throws ArgumentException: document is not a project document. -or- Server paths cannot be relative. -or- document already contains a linked model at path path. -or- The path to be linked in is empty. -or- The input path "path" does not represent a Revit model.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws FileNotFoundException: The path to be linked in doesn't exist.
      Throws InvalidOperationException: The model is not allowed to access. -or- Revit cannot customize worksets for this model. -or- Revit cannot link a cloud model to non-cloud model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RevitServerInternalException: Could be for any of the reasons that failed on service side.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified cloud model.
    static LinkLoadResult CreateFromIFC(Document document, ExternalResourceReference resourceReference, string revitLinkedFilePath, bool recreateLink, RevitLinkOptions options)
      Description: Creates a new Revit link type from an existing Revit file created via import by reference of an asscoiated IFC file.
      @document: The document in which to create the Revit link.
      @resourceReference: An external resource reference describing the source of the IFC file used in creation.
      @revitLinkedFilePath: The path of the existing Revit file that contains elements created via an import by reference operation. This must be a full path.
      @recreateLink: If true, the existing Revit file created via an import by reference operation will be updated based on the information in the IFC file. If false, the existing Revit file will be used as-is.
      @options: An options class for loading Revit links.
      Returns: An object containing the results of creating and loading the Revit link type. It contains the ElementId of the new link.
      Throws ArgumentException: document is not a project document. -or- document already contains a linked model at path revitLinkedFilePath. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support IFC links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws FileArgumentNotFoundException: There is not a valid Revit file at revitLinkedFilePath's location
      Throws InvalidOperationException: The file is not allowed to access. -or- Revit cannot customize worksets for this model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static LinkLoadResult CreateFromIFC(Document document, string ifcFilePath, string revitLinkedFilePath, bool recreateLink, RevitLinkOptions options)
      Description: Creates a new Revit link type from an existing Revit file created via import by reference of an asscoiated IFC file.
      @document: The document in which to create the Revit link.
      @ifcFilePath: The path of the associated IFC file. This must be a full path.
      @revitLinkedFilePath: The path of the existing Revit file that contains elements created via an import by reference operation. This must be a full path.
      @recreateLink: If true, the existing Revit file created via an import by reference operation will be updated based on the information in the IFC file. If false, the existing Revit file will be used as-is.
      @options: An options class for loading Revit links.
      Returns: An object containing the results of creating and loading the Revit link type. It contains the ElementId of the new link.
      Throws ArgumentException: document is not a project document. -or- The input path "ifcFilePath" does not represent an IFC file. -or- document already contains a linked model at path revitLinkedFilePath. -or- The document is a cloud model.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws FileArgumentNotFoundException: There is not a valid Revit file at ifcFilePath's location -or- There is not a valid Revit file at revitLinkedFilePath's location
      Throws InvalidOperationException: The file is not allowed to access. -or- Revit cannot customize worksets for this model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ICollection<ElementId> GetChildIds()
      Description: Gets the ids of the immediate children of this link.
      Returns: The element ids of all links which are linked directly into this one (immediate children)
    LinkConversionData GetConversionData()
      Description: Returns the optional data that is necessary to generate the Revit file for this link.
      Returns: The RvtLinkConversionData containing the necessary information.
    LinkedFileStatus GetLinkedFileStatus()
      Description: Returns the LinkedFileStatus of this link.
    ElementId GetParentId()
      Description: Gets the id of this link's immediate parent.
      Returns: The id of the immediate parent of this link, or invalidElementId if this link is a top-level link.
    IDictionary<ElementId, ElementId> GetPhaseMap()
      Description: Returns a mapping between phases in the host document and phases in the linked document.
      Returns: A map from phases in the host document to phases in the linked document. The first value in each pair is the ElementId of a phase in the host document. The second value is the ElementId of the matching phase in the linked document.
      Throws InvalidOperationException: The RvtLinkSymbol is not loaded. -or- This Revit link doesn't have a valid phase map.
    ElementId GetRootId()
      Description: Gets the id of the top-level link which this link is linked into.
      Returns: The id of the top-level link which this link is ultimately linked under, or invalidElementId if this link is a top-level link.
    static ElementId GetTopLevelLink(Document document, ExternalResourceReference reference)
      Description: Returns the ElementId of the (top-level) linked model with the given ExternalResourceReference.
      @document: The document to look for the linked model in.
      @reference: An ExternalResourceReference indicating which linked model to return.
      Returns: The id of the link with the given ExternalResourceReference, or InvalidElementId if there is no top-level link at that location.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetTopLevelLink(Document document, ModelPath path)
      Description: Returns the ElementId of the (top-level) linked model with the given path.
      @document: The document to look for the linked model in.
      @path: A path indicating which linked model to return.
      Returns: The id of the link with the given path, or InvalidElementId if there is no top-level link at that path.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasSaveablePositions()
      Description: Determines whether the link has changes to shared positioning that could be saved.
      Returns: True if the link has shared positioning changes which can be saved. False if there are no changes to shared coordinates, or if the changes cannot be saved.
    bool IsFromLocalPath()
      Description: Checks whether the Revit link uses a local path, such as a hard drive.
      Returns: Returns true if the Revit link is from a local drive.
    bool IsFromRevitServer()
      Description: Checks whether the Revit link is located on Revit Server.
      Returns: Returns true if the Revit link is located on Revit Server.
    static bool IsLoaded(Document document, ElementId typeId)
      Description: Checks whether the link with this id is loaded.
      @document: A document. Revit will see if typeId corresponds to a loaded link in this document.
      @typeId: An element id. Revit will check if typeId corresponds to a loaded link in the given document.
      Returns: True if typeId corresponds to a loaded RevitLinkType. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsNotLoadedIntoMultipleOpenDocuments()
      Description: Checks whether the link is loaded into more than one open document in this session of Revit. If the link is loaded into multiple open documents, reload will be disabled.
      Returns: True if the link is loaded into at most one open document. False if the link is loaded into more than one open document.
    LinkLoadResult Load()
      Description: Loads or reloads the Revit link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load. LinkLoadResultType.LinkLoaded indicates success.
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws ForbiddenForDynamicUpdateException: The element "this RevitLinkType" is in a ducument which is in dynamic update.
      Throws InvalidOperationException: The element "this RevitLinkType" is in a family document or a document in in-place edit mode. -or- The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode. -or- The element "this RevitLinkType" is in a read-only document. -or- This RevitLinkType is not a top-level link. -or- The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded. -or- The element "this RevitLinkType" is in a closed workset. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.
    LinkLoadResult LoadFrom(ModelPath path, WorksetConfiguration config)
      Description: Loads or reloads the Revit link from disk or cloud. The link will be loaded from the input path.
      @path: A ModelPath indicating where to load the link from. This may be a path of local disk, Revit Server or Cloud. This must be an absolute path for local path.
      @config: A WorksetConfiguration object indicating which worksets in the link to open.If you want to load the same set of worksets the link previously had, leave this argument as .
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws ArgumentException: The input path "path" does not represent a Revit model.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws ForbiddenForDynamicUpdateException: The function is not permitted during dynamic update.
      Throws InvalidOperationException: This RevitLinkType is not a top-level link. -or- The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded. -or- The element "this RevitLinkType" is in a closed workset. -or- The model is not allowed to access. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method. -or- The document is read-only. It cannot be modified. -or- The document is in an edit mode or is in family mode. -or- Revit cannot customize worksets for this model. -or- Revit cannot link a cloud model to non-cloud model.
      Throws RevitServerInternalException: Could be for any of the reasons that failed on service side.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified cloud model.
    LinkLoadResult LoadFrom(ExternalResourceReference resourceReference, WorksetConfiguration config)
      Description: Loads or reloads the Revit link. The link will be loaded from the location given in the input ExternalResourceReference.
      @resourceReference: An external resource reference describing the source of the linked Revit document.
      @config: A WorksetConfiguration object indicating which worksets in the link to open.If you want to load the same set of worksets the link previously had, leave this argument as .
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws ArgumentException: The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support Revit links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws ForbiddenForDynamicUpdateException: The function is not permitted during dynamic update.
      Throws InvalidOperationException: This RevitLinkType is not a top-level link. -or- The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded. -or- The element "this RevitLinkType" is in a closed workset. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method. -or- The document is read-only. It cannot be modified. -or- The document is in an edit mode or is in family mode. -or- Revit cannot customize worksets for this model.
    LinkLoadResult Reload()
      Description: Loads or reloads the Revit link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load. LinkLoadResultType.LinkLoaded indicates success.
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws ForbiddenForDynamicUpdateException: The element "this RevitLinkType" is in a ducument which is in dynamic update.
      Throws InvalidOperationException: The element "this RevitLinkType" is in a family document or a document in in-place edit mode. -or- The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode. -or- The element "this RevitLinkType" is in a read-only document. -or- This RevitLinkType is not a top-level link. -or- The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded. -or- The element "this RevitLinkType" is in a closed workset. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.
    LinkedFileStatus RevertLocalUnloadStatus()
      Description: Restores the workshared load status of a link that has been unloaded only for the current user, in a local copy of a workshared model.
      Returns: The link's LinkedFileStatus that has resulted from reverting the local unloaded status.
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws ForbiddenForDynamicUpdateException: The element "this RevitLinkType" is in a ducument which is in dynamic update.
      Throws InvalidOperationException: The element "this RevitLinkType" is in a family document or a document in in-place edit mode. -or- The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode. -or- The element "this RevitLinkType" is in a read-only document. -or- This functionality is not available in Revit LT. -or- The element "this RevitLinkType" is in non-workshared document. -or- The element "this RevitLinkType" is not in a local model: the model is not workshared or it is central. -or- This RevitLinkType is not a top-level link. -or- The link is not locally unloaded. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.
    bool SavePositions(ISaveSharedCoordinatesCallback callback)
      Description: Saves shared coordinates changes back to the linked document.
      @callback: A callback object to resolve situations when Revit encounters modified links.
      Returns: True if we saved the link or if there were no changes to save. False if the operation failed.
      Throws InvalidOperationException: This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- Revit could not save shared coordinates changes to the link or one of its nested links.
    void Unload(ISaveSharedCoordinatesCallback callback)
      Description: Unloads the Revit link.
      @callback: A callback indicating what to do if Revit encounters links which have changes in shared coordinates. If , Revit will not save any shared coordinates changes to the link before unloading.
      Throws ForbiddenForDynamicUpdateException: The function is not permitted during dynamic update.
      Throws InvalidOperationException: This RevitLinkType is not a top-level link. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- Revit could not save shared coordinates changes to the link or one of its nested links. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method. -or- The document is read-only. It cannot be modified. -or- The document is in an edit mode or is in family mode. -or- Revit cannot link a cloud model to non-cloud model
      Throws RevitServerInternalException: Could be for any of the reasons that failed on service side.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified cloud model.
    bool UnloadLocally(ISaveSharedCoordinatesCallbackForUnloadLocally callback)
      Description: Unloads a Revit link for the current user only.
      @callback: A callback indicating what to do if Revit encounters links which have changes in shared coordinates. The saving options for unloading locally only could be: save the link, not save the link. If , Revit will not save any shared coordinates changes to the link before unloading.
      Returns: Returns true if the attempt to unload the link locally was successful.
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws ForbiddenForDynamicUpdateException: The element "this RevitLinkType" is in a ducument which is in dynamic update.
      Throws InvalidOperationException: The element "this RevitLinkType" is in a family document or a document in in-place edit mode. -or- The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode. -or- The element "this RevitLinkType" is in a read-only document. -or- This functionality is not available in Revit LT. -or- The element "this RevitLinkType" is in non-workshared document. -or- The element "this RevitLinkType" is not in a local model: the model is not workshared or it is central. -or- This RevitLinkType is not a top-level link. -or- The link "this RevitLinkType" is locally unloaded for current user already. -or- This operation is not supported for scenario-based Revit links. Scenario-based Revit links are read-only and their source is managed by the scenario system. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.
    bool UpdateFromIFC(Document document, ExternalResourceReference resourceReference, string revitLinkedFilePath, bool recreateLink)
      Description: Updates a Revit link type from an IFC file and loads the linked document.
      @document: The document that contains Revit link.
      @resourceReference: An external resource reference describing the source of the IFC file used in creation.
      @revitLinkedFilePath: The path of the Revit file to create to hold the IFC information. This must be a full path.
      @recreateLink: If true, the Revit file will be updated based on the information in the IFC file. If false, the existing Revit file will be used.
      Returns: Returns true if the update succeeded, false otherwise.
      Throws ArgumentException: document is not a project document. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support IFC links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws InvalidOperationException: The file is not allowed to access. -or- Revit cannot customize worksets for this model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    bool UpdateFromIFC(Document document, string ifcFilePath, string revitLinkedFilePath, bool recreateLink)
      Description: Updates a Revit link type from an IFC file and loads the linked document.
      @document: The document that contains Revit link.
      @ifcFilePath: The path of the IFC link to load. This must be a full path.
      @revitLinkedFilePath: The path of the Revit file to create to hold the IFC information. This must be a full path.
      @recreateLink: If true, the Revit file will be updated based on the information in the IFC file. If false, the existing Revit file will be used.
      Returns: Returns true if the update succeeded, false otherwise.
      Throws ArgumentException: document is not a project document. -or- The input path "ifcFilePath" does not represent an IFC file. -or- The document is a cloud model.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The model cannot be accessed due to lack of access privileges.
      Throws FileArgumentNotFoundException: There is not a valid Revit file at ifcFilePath's location
      Throws InvalidOperationException: The file is not allowed to access. -or- Revit cannot customize worksets for this model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] Revolution
Full Name: Autodesk.Revit.DB.Revolution
Description: A revolution solid or void form.
Inherits: GenericForm

  PROPERTIES:
    ModelLine Axis { get; }
      Description: Returns the Axis of the Revolution.
    double EndAngle { get; set; }
      Description: The end angle of the revolution relative to the sketch plane.
    Sketch Sketch { get; }
      Description: Returns the Sketch of the Revolution.
    double StartAngle { get; set; }
      Description: The start angle of the revolution relative to the sketch plane.

--------------------------------------------------------------------------------

[CLASS] RevolvedFace
Full Name: Autodesk.Revit.DB.RevolvedFace
Description: A revolved face of a 3d solid or open shell.
Remarks: Revolved faces are defined by a profile curve and a local coordinate system. For details on the parameterization, refer to the documentation for RevolvedSurface
Inherits: Face

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the surface.
    Curve Curve { get; }
      Description: Profile curve of the surface.
    XYZ Origin { get; }
      Description: Origin of the surface.
    XYZ Radius { get; }

--------------------------------------------------------------------------------

[CLASS] RevolvedSurface
Full Name: Autodesk.Revit.DB.RevolvedSurface
Description: A surface of revolution defined by a profile curve and a local coordinate system. The surface is obtained by rotating the curve around Z axis of the local coordinate system.
Remarks: The parametric equation of a surface of revolution is S(u, v) = center + C1(v)*cos(u)*xVec + C1(v)*sin(u)*yVec + C2(v)*zVec, where the profile curve in the SurfRev's xz plane has the parametric equation (C1(t), C2(t)). Note that the direction of X axis may agree or disagree with the chosen orientation of the surface.
Inherits: Surface

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the revolved surface. This is the Z axis of the local coordinate system associated with this revolved surface.
    XYZ Origin { get; }
      Description: Center of the circle that defines the base of the revolved surface. This is the origin of the local coordinate system associated with this revolved surface.
    XYZ XDir { get; }
      Description: X axis of the local coordinate system associated with this revolved surface.
    XYZ YDir { get; }
      Description: X axis of the local coordinate system associated with this revolved surface.

  METHODS:
    static Surface Create(Frame frameOfReference, Curve profileCurve, double startAngle, double endAngle)
      Description: Creates a Surface object coincident with the surface of revolution defined by a coordinate frame, a profile curve, and start and end angles of revolution.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the surface of revolution. The frame can be "right-handed" or "left-handed".The origin of the frame is the base of point of the axis of revolution.The BasisZ of the frame is the direction of the axis.
      @profileCurve: The profile curve, which should satisfy the following conditions: It is bounded and non-degenerate.It is co-planar with the axis of revolution.It lies on the xz plane of the frame.It lies on the right side of the axis.Only the end points of the profile curve can touch the axis.
      @startAngle: Start angle of rotation. The angles are measured around the axis of revolution, using the right-hand rule. The profile curve is at the zero angle.
      @endAngle: End angle of rotation. Start angle must be less than end angle and their difference must be less than or equal to two times PI.
      Returns: The created surface. Note that this surface may not be of type RevolvedSurface.
      Throws ArgumentException: This Frame object may not be used as a local frame of reference. -or- The input profile curve is not valid to create a surface revolution in the given frame.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: Start angle must be less than end angle and their difference must be less than or equal to two times PI.
    static Surface Create(Frame frameOfReference, Curve profileCurve)
      Description: Creates a Surface object coincident with the surface of revolution defined by a coordinate frame and a profile curve.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the surface of revolution. The frame can be "right-handed" or "left-handed".The origin of the frame is the base of point of the axis of revolution.The BasisZ of the frame is the direction of the axis.
      @profileCurve: The profile curve, which should satisfy the following conditions: It is bounded and non-degenerate.It is co-planar with the axis of revolution.It lies on the xz plane of the frame.It lies on the right side of the axis.Only the end points of the profile curve can touch the axis.
      Returns: The created surface. Note that this surface may not be of type RevolvedSurface.
      Throws ArgumentException: This Frame object may not be used as a local frame of reference. -or- The input profile curve is not valid to create a surface revolution in the given frame.
      Throws ArgumentNullException: A non-optional argument was null
    static Surface Create(XYZ axisBasePoint, XYZ axisDirection, Curve profileCurve, double startAngle, double endAngle)
      Description: Creates a Surface object coincident with the surface of revolution defined by an axis, a profile curve, and start and end angles of revolution.
      @axisBasePoint: The base point of the axis of revolution. Expected to lie within the Revit design limits XYZ).
      @axisDirection: The direction of the axis.
      @profileCurve: The profile curve, which should satisfy the following conditions: It is bounded and non-degenerate.It is co-planar with the axis of revolution.It lies on only one side of the axis.Only the end points of the profile curve can touch the axis.
      @startAngle: Start angle of rotation. The angles are measured around the axis of revolution, using the right-hand rule. The profile curve is at the zero angle.
      @endAngle: End angle of rotation. Start angle must be less than end angle and their difference must be less than or equal to two times PI.
      Returns: The created surface. Note that this surface may not be of type RevolvedSurface.
      Throws ArgumentException: The input point lies outside of Revit design limits. -or- The input profile curve is not valid to create a surface revolution around the given axis.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: axisDirection has zero length.
      Throws ArgumentsInconsistentException: Start angle must be less than end angle and their difference must be less than or equal to two times PI.
    static Surface Create(XYZ axisBasePoint, XYZ axisDirection, Curve profileCurve)
      Description: Creates a Surface object coincident with the surface of revolution defined by an axis and a profile curve.
      @axisBasePoint: The base point of the axis of revolution. Expected to lie within the Revit design limits XYZ).
      @axisDirection: The direction of the axis.
      @profileCurve: The profile curve, which should satisfy the following conditions: It is bounded and non-degenerate.It is co-planar with the axis of revolution.It lies on only one side of the axis.Only the end points of the profile curve can touch the axis.
      Returns: The created surface. Note that this surface may not be of type RevolvedSurface.
      Throws ArgumentException: The input point lies outside of Revit design limits. -or- The input profile curve is not valid to create a surface revolution around the given axis.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: axisDirection has zero length.
    Curve GetProfileCurve()
      Description: Returns a copy of the profile curve expressed in the surface's coordinate system.
      Returns: A copy of the profile curve.
    Curve GetProfileCurveInWorldCoordinates()
      Description: Returns a copy of the profile curve expressed in the world coordinate system.
      Returns: A copy of the profile curve in the world coordinate system.
    static bool IsValidProfileCurve(Frame frameOfReference, Curve profileCurve)
      Description: Checks if the input profile curve is valid to create a surface of revolution in the given frame of reference.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the surface of revolution. The frame can be "right-handed" or "left-handed".The origin of the frame is the base of point of the axis of revolution.The BasisZ of the frame is the direction of the axis.
      @profileCurve: The profile curve.
      Returns: True if the profile curve is valid; False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidProfileCurve(XYZ axisBasePoint, XYZ axisDirection, Curve profileCurve)
      Description: Checks if the input profile curve is valid to create a surface of revolution around the given axis.
      @axisBasePoint: The base point of the axis of revolution.
      @axisDirection: The direction of the axis.
      @profileCurve: The profile curve.
      Returns: True if the profile curve is valid; False otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] RoofBase
Full Name: Autodesk.Revit.DB.RoofBase
Description: Represents all kinds of Roofs.
Remarks: The RoofBase object represents all kinds of roof in Revit.
Inherits: HostObject

  PROPERTIES:
    EaveCutterType EaveCuts { get; set; }
      Description: Retrieve or set the EaveCutterType.
    double FasciaDepth { get; set; }
      Description: Retrieve or set the FasciaDepth.
    RoofType RoofType { get; set; }
      Description: Retrieve or set the Type.

  METHODS:
    SlabShapeEditor GetSlabShapeEditor()
      Description: Gets a SlabShapeEditor that can used to add or modify points of this RoofBase.
      Returns: The SlabShapeEditor object

--------------------------------------------------------------------------------

[CLASS] RoofType
Full Name: Autodesk.Revit.DB.RoofType
Description: Represents a specific type of roof.
Remarks: All roof type objects available in the project can be retrieved from the Document object via the RoofTypes property. Every Roof object has a RoofType property that returns a RoofType object representing the type. This same RoofType property can also be used to change the type of the roof by setting it to a different type.
Inherits: HostObjAttributes

  PROPERTIES:
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the RoofType

--------------------------------------------------------------------------------

[ENUM] RoundingMethod
Full Name: Autodesk.Revit.DB.RoundingMethod
Description: Rounding methods
Inherits: Enum

  Values:
    - Nearest = 0
    - Up = 1
    - Down = 2

--------------------------------------------------------------------------------

[CLASS] RoutingCondition
Full Name: Autodesk.Revit.DB.RoutingCondition
Description: RoutingCondition represents routing information that is used as input when determining if a routing criterion, such as minimum or maximum diameter, is met.
Implements: IDisposable

  CONSTRUCTORS:
    new RoutingCondition(double diameter)
      Description: Creates a new RoutingCondition.
      @diameter: The diameter of a routing segment.
      Throws ArgumentOutOfRangeException: The given value for diameter must be greater than 0 and no more than 30000 feet.

  PROPERTIES:
    double Diameter { get; }
      Description: The diameter of the segment or fitting specified for the routing condition.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] RoutingConditions
Full Name: Autodesk.Revit.DB.RoutingConditions
Description: RoutingConditions contain routing information that is used as input when determining if a routing criterion, such as minimum or maximum diameter, is met.
Implements: IDisposable

  CONSTRUCTORS:
    new RoutingConditions(RoutingPreferenceErrorLevel errorLevel)
      Description: Constructs a new instance of a RoutingConditions object with an indicated error level for conditions that do not meet any routing preference rule.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    RoutingPreferenceErrorLevel ErrorLevel { get; set; }
      Description: The error level that the routing preference manager should post errors if the routing conditions do not meet any routing preference rule, could be None, Warning, or Error
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    PreferredJunctionType PreferredJunctionType { get; set; }
      Description: The junction type (Tee or Tap) to select if defined fittings of both junction types meet all routing conditions.

  METHODS:
    void AppendCondition(RoutingCondition condition)
      Description: Appends a routing condition to the end of existing routing conditions. Note that the first item (indexed at 0) is the condition for the primary connector.
      Throws ArgumentNullException: A non-optional argument was null
    void Clear()
      Description: Clear all existing conditions
    void Dispose()
    RoutingCondition GetConditionAt(int index)
      Description: Gets the routing condition at the specified index position.
      @index: The 0-based index to access the collection of available conditions. The method throws the exception ArgumentOutOfRangeException if the index is out of range.
      Returns: The found routing condition.
      Throws ArgumentOutOfRangeException: index is not within the valid range of available conditions.
    int GetNumberOfConditions()
      Description: Gets the number of included routing conditions.

--------------------------------------------------------------------------------

[CLASS] RoutingCriterionBase
Full Name: Autodesk.Revit.DB.RoutingCriterionBase
Description: RoutingCriteriaBase is the base class for all routing criteria.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsEqual(RoutingCriterionBase pOther)
      Description: Verify if two criteria are the same.
      Returns: True if the criterion is equal to the other, false otherwise
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] RoutingPreferenceErrorLevel
Full Name: Autodesk.Revit.DB.RoutingPreferenceErrorLevel
Description: An enumerated type listing the options for posting errors or warnings when routing preferences are not satisfied.
Inherits: Enum

  Values:
    - None = 0
    - Warning = 1
    - Error = 2

--------------------------------------------------------------------------------

[CLASS] RoutingPreferenceManager
Full Name: Autodesk.Revit.DB.RoutingPreferenceManager
Description: Manages default pipe segments, fittings, and selection criteria for a given MEPCurveType
Remarks: MEPCurveTypes contain a RoutingPreferenceManager property. The RoutingPreferenceManager contains rules for selecting segment types and sizes as well as fitting types based on user selection criteria.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId OwnerId { get; }
      Description: The Id of the MEPCurveType that owns the RoutingPreferenceManager
    PreferredJunctionType PreferredJunctionType { get; set; }
      Description: The preferred junction type.

  METHODS:
    void AddRule(RoutingPreferenceRuleGroupType groupType, RoutingPreferenceRule rule, int index)
      Description: Adds a new routing preference rule to the specified position in the rule group.
      @groupType: The routing preference group type in which the rule should be added.
      @rule: The new rule to be added.
      @index: The zero-based index position where the new rule will be added.
      Throws ArgumentException: index is not a valid zero-based index within groupType. -or- The rule cannot be added to the groupType. -or- Thrown if the index is out of bounds, or the rule is not valid for this group (e.g. an elbow may not be added to the junction group).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void AddRule(RoutingPreferenceRuleGroupType groupType, RoutingPreferenceRule rule)
      Description: Adds a new routing preference rule to the rule group.
      @groupType: The routing preference group in which the rule should be added.
      @rule: The new rule to be added.
      Throws ArgumentException: The rule cannot be added to the groupType. -or- Thrown if the index is out of bounds, or the rule is not valid for this group (e.g. an elbow may not be added to the junction group).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void Dispose()
    ElementId GetMEPPartId(RoutingPreferenceRuleGroupType groupType, RoutingConditions conditions)
      Description: Gets a fitting or segment id of given routing preference group that meets the specified routing conditions.
      @groupType: The routing preference group
      @conditions: A set of routing conditions
      Returns: The Id of the fitting or segment that met the given routing conditions.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    int GetNumberOfRules(RoutingPreferenceRuleGroupType eGroupType)
      Description: The number of RoutingPreference rules in a group.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    RoutingPreferenceRule GetRule(RoutingPreferenceRuleGroupType groupType, int index)
      Description: Gets the specified rule.
      @groupType: The routing preference group type from which the rule should be returned.
      @index: The zero-based index where the rule should be returned.
      Returns: The rule at the specified group and zero-based index position.
      Throws ArgumentException: index is not a valid zero-based index within groupType. -or- Thrown if the index is out of bounds
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<ElementId> GetSharedSizes(double size, ConnectorProfileType shape)
      Description: Gets a list of all segments of a given profile shape that define a given size.
      @size: The size to search for.
      @shape: The profile shape of segment object.
      Returns: A list of all segments that define a given size.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void RemoveRule(RoutingPreferenceRuleGroupType groupType, int index)
      Description: Removes an existing routing preference rule. Thrown if the index is out of bounds.
      @groupType: The routing preference group type in which the rule should be removed.
      @index: The index position of removed routing preference rule in the group.
      Throws ArgumentException: index is not a valid zero-based index within groupType. -or-
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] RoutingPreferenceRule
Full Name: Autodesk.Revit.DB.RoutingPreferenceRule
Description: A class representing a rule set in MEP routing preferences.
Implements: IDisposable

  CONSTRUCTORS:
    new RoutingPreferenceRule(ElementId MEPPartId, string description)
      Description: Constructs a RoutingPreferenceRule containing a segment or fitting Id (MEPPartId) and description.
      @MEPPartId: The Id of the segment or fitting. InvalidElementId may be specified if no MEPPart will be allowed when the conditions satisfy the criteria in this rule.
      @description: The description of the rule.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    string Description { get; }
      Description: The description of the routing preference rule.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId MEPPartId { get; }
      Description: The referenced MEPPart (segment or fitting) type in this rule. It may be InvalidElementId if no MEPPart will be allowed when the conditions satisfy the criteria in this rule.
    int NumberOfCriteria { get; }
      Description: Gets the number of routing criteria.
    RoutingPreferenceManager RoutingPreferenceManager { get; }
      Description: Gets the routing preference manager that owns this rule.

  METHODS:
    void AddCriterion(RoutingCriterionBase myCriterion)
      Description: Adds a new routing criterion.
      @myCriterion: The criterion to add.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    RoutingCriterionBase GetCriterion(int index)
      Description: Gets the specified criteria.
      Returns: The criterion at the specified zero-based index position.
      Throws ArgumentException: index is not a valid zero-based index. -or- Thrown if the index is out of bounds.
    void RemoveCriteron(int index)
      Description: Removes an existing criterion.
      @index: The index position of removed routing preference rule in the group.
      Throws ArgumentException: index is not a valid zero-based index. -or- Thrown if the index is out of bounds.

--------------------------------------------------------------------------------

[ENUM] RoutingPreferenceRuleGroupType
Full Name: Autodesk.Revit.DB.RoutingPreferenceRuleGroupType
Description: Add more rule group type here.
Inherits: Enum

  Values:
    - Segments = 0
    - Elbows = 1
    - Junctions = 2
    - Crosses = 3
    - Transitions = 4
    - Unions = 5
    - MechanicalJoints = 6
    - TransitionsRectangularToRound = 7
    - TransitionsRectangularToOval = 8
    - TransitionsOvalToRound = 9
    - Caps = 10
    - Undefined = -1

--------------------------------------------------------------------------------

[ENUM] RowHeightOverrideOptions
Full Name: Autodesk.Revit.DB.RowHeightOverrideOptions
Description: Describes the options for overriding schedule body row heights (applied when viewed as a ScheduleSheetInstance on a ViewSheet).
Inherits: Enum

  Values:
    - None = 0
    - All = 1
    - ImageRows = 2

--------------------------------------------------------------------------------

[CLASS] RPCNode
Full Name: Autodesk.Revit.DB.RPCNode
Description: This class represents an RPC content in a model-exporting process.
Remarks: See also: Autodesk::Revit::DB::IExportContext::OnRPC.
Inherits: ContentNode

--------------------------------------------------------------------------------

[CLASS] RuledFace
Full Name: Autodesk.Revit.DB.RuledFace
Description: A ruled face of a 3d solid or open shell.
Remarks: A ruled surface is created by sweeping a line between two profile curves or between a curve and a point (a point and a curve). For details on the parameterization, refer to the documentation for RuledSurface.
Inherits: Face

  PROPERTIES:
    Curve Curve { get; }
    bool IsExtruded { get; }
      Description: Determines if this is an extruded ruled surface.
    XYZ Point { get; }
    bool RulingsAreParallel { get; }
      Description: Determines if the rulings of this ruled surface are parallel.

--------------------------------------------------------------------------------

[CLASS] RuledSurface
Full Name: Autodesk.Revit.DB.RuledSurface
Description: A ruled surface is created by sweeping a line between two profile curves or between a curve and a point (a point and a curve). Input curve(s) must be bounded or have natural bounds.
Remarks: Both curves are evaluated in normalized parameters [0, 1] The parametric equations of a ruled surface are: Curve C1 and curve C2 : S(u, v) = C1(u) + v * (C2(u) - C1(u));Point P1 and curve C2 : S(u, v) = P1 + v * (C2(u) - P1);Curve C1 and point P2 : S(u, v) = C1(u) + v * (P2 - C1(u)); The point/point case is not allowed as that would define a degenerate ruled surface.
Inherits: Surface

  METHODS:
    static Surface Create(Curve profileCurve, XYZ point)
      Description: Creates a Surface object coincident with the ruled surface joining a bounded generating curve to a point.
      @profileCurve: The profile curve; must be bounded and non-degenerate.
      @point: The point. Expected to lie within the Revit design limits XYZ).
      Returns: The created surface. Note that this surface may not be of type RuledSurf.
      Throws ArgumentException: The input profileCurve is not bound. -or- The profileCurve is degenerate (its length is too close to zero). -or- The input point lies outside of Revit design limits.
      Throws ArgumentNullException: A non-optional argument was null
    static Surface Create(Curve profileCurve1, Curve profileCurve2)
      Description: Creates a Surface object coincident with the ruled surface joining two bounded generating curves.
      @profileCurve1: The first profile curve; must be bounded and non-degenerate.
      @profileCurve2: The second profile curve; must be bounded and non-degenerate.
      Returns: The created surface. Note that this surface may not be of type RuledSurf.
      Throws ArgumentException: The input profileCurve1 is not bound. -or- The profileCurve1 is degenerate (its length is too close to zero). -or- The input profileCurve2 is not bound. -or- The profileCurve2 is degenerate (its length is too close to zero).
      Throws ArgumentNullException: A non-optional argument was null
    Curve GetFirstProfileCurve()
      Description: Returns a copy of the first profile curve if it is set.
      Returns: A copy of the first profile curve, if it exists. If a point was used to define the first profile, this function will return .
    XYZ GetFirstProfilePoint()
      Description: If a point was used to define the first profile, returns a copy of that point.
      Returns: The first profile point if it was set.
      Throws InvalidOperationException: This surface element does not use a point to define the first profile.
    Curve GetSecondProfileCurve()
      Description: Returns a copy of the second profile curve if it is set.
      Returns: A copy of the second profile curve, if it exists. If a point was used to define the second profile, this function will return .
    XYZ GetSecondProfilePoint()
      Description: If a point was used to define the second profile, returns a copy of that point.
      Returns: The second profile point if it was set.
      Throws InvalidOperationException: This surface element does not use a point to define the second profile.
    bool HasFirstProfilePoint()
      Description: Checks if a point was used to define the first profile.
      Returns: True if a point was used to define the first profile, false otherwise.
    bool HasSecondProfilePoint()
      Description: Checks if a point was used to define the second profile.
      Returns: True if a point was used to define the second profile, false otherwise.

--------------------------------------------------------------------------------

