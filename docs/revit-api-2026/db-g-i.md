# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[CLASS] GBXMLExportOptions
Full Name: Autodesk.Revit.DB.GBXMLExportOptions
Description: Green Building XML Export options.
Implements: IDisposable

  CONSTRUCTORS:
    new GBXMLExportOptions()
      Description: Constructs a new instance of the options used to export a model in gbXML (Green Building XML) format.

  PROPERTIES:
    string Encoding { get; }
      Description: The encoding options to go into the processing instruction for the exported gbXML file.
    bool ExportAnalyticalSystems { get; set; }
      Description: Indicates if the gbXML should contain analytical system elements (e.g., Water Loop, Air System, and Zone Equipment).
    ExportEnergyModelType ExportEnergyModelType { get; set; }
      Description: The energy model type from which gbXML will be exported.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] GBXMLImportOptions
Full Name: Autodesk.Revit.DB.GBXMLImportOptions
Description: Import options for Green-Building XML format.
Remarks: Not used currently. Reserved for future use.

  CONSTRUCTORS:
    new GBXMLImportOptions()
      Description: Default constructor. Sets all options to their default values.

--------------------------------------------------------------------------------

[CLASS] GenericForm
Full Name: Autodesk.Revit.DB.GenericForm
Description: Provides access to the Generic Form model in Autodesk Revit.
Remarks: The Generic Form object can be queried for a generic form for use in family modeling and massing. It is the base class of Sweep, Blend, Extrusion, Revolution.
Inherits: CombinableElement

  PROPERTIES:
    bool IsSolid { get; }
      Description: Identifies if the GenericForm is a solid or a void element.
    string Name { set; }
      Description: Get and Set the Name property
    Category Subcategory { get; set; }
      Description: The subcategory.
    bool Visible { get; }
      Description: The visibility of the GenericForm.

  METHODS:
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the generic form.
      Returns: A copy of visibility settings for the generic form.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the generic form.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws InvalidOperationException: Thrown when regeneration failed.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GenericImportOptions
Full Name: Autodesk.Revit.DB.GenericImportOptions
Description: Generic Import options.

  PROPERTIES:
    XYZ RefPoint { get; set; }
      Description: Reference point (in Revit) to which the image is going to be inserted.

--------------------------------------------------------------------------------

[CLASS] GeomCombination
Full Name: Autodesk.Revit.DB.GeomCombination
Description: An element created by Join and Cut operations applied to combinable elements in an Autodesk Revit family document.
Inherits: CombinableElement

  PROPERTIES:
    CombinableElementArray AllMembers { get; }
      Description: All elements that are joined in this geometry combination.

--------------------------------------------------------------------------------

[CLASS] GeomCombinationSet
Full Name: Autodesk.Revit.DB.GeomCombinationSet
Description: A set that contains GeomCombination objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new GeomCombinationSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of GeomCombinations that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item GeomCombination the set, rendering it empty.
    bool Contains(GeomCombination item)
      Description: Tests for the existence of an GeomCombination within the set.
      @item: The element to be searched for.
      Returns: The Contains method returns True if the GeomCombination is within the set, otherwise False.
    int Erase(GeomCombination item)
      Description: Removes a specified GeomCombination from the set.
      @item: The GeomCombination to be erased.
      Returns: The number of GeomCombinations that were erased from the set.
    GeomCombinationSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(GeomCombination item)
      Description: Insert the specified element into the set.
      @item: The GeomCombination to be inserted into the set.
      Returns: Returns whether the GeomCombination was inserted into the set.
    GeomCombinationSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GeomCombinationSetIterator
Full Name: Autodesk.Revit.DB.GeomCombinationSetIterator
Description: An iterator to a GeomCombination set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new GeomCombinationSetIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the set.
    void Reset()
      Description: Bring the iterator back to the start of the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GeometryCreationUtilities
Full Name: Autodesk.Revit.DB.GeometryCreationUtilities
Description: A utility that allows construction of basic solid shapes.
Remarks: The shapes created by these utilities are not a part of any Revit document, but can be used in conjunction with other geometric utilities from within API applications.

  METHODS:
    static Solid CreateBlendGeometry(CurveLoop firstLoop, CurveLoop secondLoop, ICollection<VertexPair> vertexPairs, SolidOptions solidOptions)
      Description: Creates a solid by blending two closed curve loops lying in non-coincident planes.
      @firstLoop: The first curve loop. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop may not contain just one closed curve - split such a loop into two or more curves beforehand.
      @secondLoop: The second curve loop, satisfying the same conditions as the first loop. The planes of the first and second loops must not be coincident, but they need not be parallel.
      @vertexPairs: This input specifies how the two profile loops should be connected. If null, the function chooses vertex connections that will result in a geometrically reasonable blend.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
      Throws ArgumentException: The first profile CurveLoop do not satisfy the input requirements. -or- The second profile CurveLoop do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateBlendGeometry(CurveLoop firstLoop, CurveLoop secondLoop, ICollection<VertexPair> vertexPairs)
      Description: Creates a solid by blending two closed curve loops lying in non-coincident planes.
      @firstLoop: The first curve loop. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop may not contain just one closed curve - split such a loop into two or more curves beforehand.
      @secondLoop: The second curve loop, satisfying the same conditions as the first loop. The planes of the first and second loops must not be coincident, but they need not be parallel.
      @vertexPairs: This input specifies how the two profile loops should be connected. If null, the function chooses vertex connections that will result in a geometrically reasonable blend.
      Returns: The requested solid.
      Throws ArgumentException: The first profile CurveLoop do not satisfy the input requirements. -or- The second profile CurveLoop do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateExtrusionGeometry(IList<CurveLoop> profileLoops, XYZ extrusionDir, double extrusionDist, SolidOptions solidOptions)
      Description: Creates a solid by linearly extruding one or more closed coplanar curve loops.
      @profileLoops: The profile loops to be extruded. The loops must be closed, coplanar, and without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
      @extrusionDir: The direction in which to extrude the profile loops. This vector must be non-zero and transverse (i.e., not parallel) to the plane of the profile loops. Its length is irrelevant; only its direction is used.
      @extrusionDist: The positive distance by which the loops are to be extruded in the direction of the input extrusionDir.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
      Throws ArgumentException: The profile CurveLoops do not satisfy the input requirements. -or- The Input extrusionDir must be a non-zero vector. The normal of the loop plane should not be perpendicular to the given extrusionDir. -or- The input argument extrusionDist must be positive.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateExtrusionGeometry(IList<CurveLoop> profileLoops, XYZ extrusionDir, double extrusionDist)
      Description: Creates a solid by linearly extruding one or more closed coplanar curve loops.
      @profileLoops: The profile loops to be extruded. The loops must be closed, coplanar, and without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
      @extrusionDir: The direction in which to extrude the profile loops. This vector must be non-zero and transverse (i.e., not parallel) to the plane of the profile loops. Its length is irrelevant; only its direction is used.
      @extrusionDist: The positive distance by which the loops are to be extruded in the direction of the input extrusionDir.
      Returns: The requested solid.
      Throws ArgumentException: The profile CurveLoops do not satisfy the input requirements. -or- The Input extrusionDir must be a non-zero vector. The normal of the loop plane should not be perpendicular to the given extrusionDir. -or- The input argument extrusionDist must be positive.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateFixedReferenceSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops, XYZ fixedReferenceDirection, SolidOptions solidOptions)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path while keeping the profile plane oriented so that a line in the plane that is initially perpendicular to a given fixed direction remains perpendicular as the profile is swept along the path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar. With the exception of path curves that lie in a plane parallel to %fixedReferenceDirection%, the curve's tangent should be nowhere parallel to %fixedReferenceDirection%. If the sweep path has corners, the solid segments that meet at a corner may not meet smoothly.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops; this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above.The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops).The curve loops must be without intersections, self-intersections, or degeneracies.No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @fixedReferenceDirection: A unit vector specifying the fixed direction used to control how the profile plane is swept along the path; see the description and remarks above. The profile CurveLoops do not satisfy the input requirements.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
      Throws ArgumentException: The input argument sweepPath should at least contain one curve. -or- The input argument pathAttachmentCrvIdx is not valid. -or-
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: fixedReferenceDirection is not length 1.0.
    static Solid CreateFixedReferenceSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops, XYZ fixedReferenceDirection)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path while keeping the profile plane oriented so that a line in the plane that is initially perpendicular to a given fixed direction remains perpendicular as the profile is swept along the path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar. With the exception of path curves that lie in a plane parallel to %fixedReferenceDirection%, the curve's tangent should be nowhere parallel to %fixedReferenceDirection%. If the sweep path has corners, the solid segments that meet at a corner may not meet smoothly.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops; this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above.The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops).The curve loops must be without intersections, self-intersections, or degeneracies.No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @fixedReferenceDirection: A unit vector specifying the fixed direction used to control how the profile plane is swept along the path; see the description and remarks above.
      Returns: The requested solid.
      Throws ArgumentException: The input argument sweepPath should at least contain one curve. -or- The input argument pathAttachmentCrvIdx is not valid. -or- The profile CurveLoops do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: fixedReferenceDirection is not length 1.0.
    static Solid CreateLoftGeometry(IList<CurveLoop> profileLoops, SolidOptions solidOptions)
      Description: Creates a solid or open shell geometry by lofting between a sequence of curve loops.
      @profileLoops: The array of curve loops, where the order of the array determines the lofting sequence used.
      @solidOptions: The optional information to control the properties of the solid or open shell.
      Returns: The requested solid or open shell.
      Throws ArgumentException: The number of profile CurveLoops is less than 2.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateRevolvedGeometry(Frame coordinateFrame, IList<CurveLoop> profileLoops, double startAngle, double endAngle, SolidOptions solidOptions)
      Description: Creates a solid of revolution by revolving a set of closed curve loops around an axis by a specified angle.
      @coordinateFrame: A right-handed orthonormal frame of vectors. The frame's z-vector is the axis of revolution. The start and end angle inputs refer to this frame.
      @profileLoops: The profile loops to be revolved. No conditions are imposed on the orientations of the loops. This function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the xz coordinate plane of the input coordinate frame.The curve loop(s) must be closed and must define a single planar domain (one outer loop and, optionally, one or more inner loops).The curve loops must be without intersections, self-intersections, or degeneracies.The loops must lie on the "right" side of the z axis (where x >= 0).No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @startAngle: The start angle for the revolution, in radians, measured counter-clockwise from the coordinate frame's x-axis as viewed looking down the frame's z-axis.
      @endAngle: The end angle for the revolution, using the same conventions as the start angle. The end angle may be less than (but not equal to) the start angle. The total angle of revolution, equal to the absolute value of (endAngle â€“ startAngle), must be at most 2*PI.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid. Note that if less than a full revolution is used, planar end faces will be added as part of the solid.
      Throws ArgumentException: The input argument coordinateFrame should be a right-handed orthonormal frame of vectors. -or- The profile CurveLoops do not satisfy the input requirements. -or- The absolute value of %(endAngle â€“ startAngle)%, must be at most 2*PI.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateRevolvedGeometry(Frame coordinateFrame, IList<CurveLoop> profileLoops, double startAngle, double endAngle)
      Description: Creates a solid of revolution by revolving a set of closed curve loops around an axis by a specified angle.
      @coordinateFrame: A right-handed orthonormal frame of vectors. The frame's z-vector is the axis of revolution. The start and end angle inputs refer to this frame.
      @profileLoops: The profile loops to be revolved. No conditions are imposed on the orientations of the loops. This function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the xz coordinate plane of the input coordinate frame.The curve loop(s) must be closed and must define a single planar domain (one outer loop and, optionally, one or more inner loops).The curve loops must be without intersections, self-intersections, or degeneracies.The loops must lie on the "right" side of the z axis (where x >= 0).No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @startAngle: The start angle for the revolution, in radians, measured counter-clockwise from the coordinate frame's x-axis as viewed looking down the frame's z-axis.
      @endAngle: The end angle for the revolution, using the same conventions as the start angle. The end angle may be less than (but not equal to) the start angle. The total angle of revolution, equal to the absolute value of (endAngle â€“ startAngle), must be at most 2*PI.
      Returns: The requested solid. Note that if less than a full revolution is used, planar end faces will be added as part of the solid.
      Throws ArgumentException: The input argument coordinateFrame should be a right-handed orthonormal frame of vectors. -or- The profile CurveLoops do not satisfy the input requirements. -or- The absolute value of %(endAngle â€“ startAngle)%, must be at most 2*PI.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateSweptBlendGeometry(Curve pathCurve, IList<double> pathParams, IList<CurveLoop> profileLoops, IList<ICollection<VertexPair>> vertexPairs, SolidOptions solidOptions)
      Description: Creates a solid by simultaneously sweeping and blending two or more closed planar curve loops along a single curve.
      @pathCurve: The sweep path, consisting of a single bounded, open curve.
      @pathParams: An increasing sequence of parameters along the path curve (lying within the curve's bounds). These parameters specify the locations of the planes orthogonal to the path that contain the profile loops. This array must have the same size as the input array "profileLoops".
      @profileLoops: Closed, planar curve loops arrayed along the path. No loop may contain just one closed curve - split such loops into two or more curves beforehand. The solid will have these profiles as cross-sections at the points specified by the input pathParams. The solid will blend smoothly between the profiles. This array must have the same size as the input array "pathParams", and each profile loop must lie in the plane orthogonal to the path at the point specified by the corresponding entry in the input array "pathParams". Each profile loop must define a single planar domain and must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.
      @vertexPairs: This input specifies how adjacent profile loops should be connected. It must contain one less element than the "profileLoops" input, and entry vertexPairs[idx] specifies how profileLoops[idx] and profileLoops[idx+1] should be connected (indexing starts at 0).
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
      Throws ArgumentException: The input pathCurve is a helical curve and is not supported for this operation. -or- The input argument pathCurve should be bounded. The input argument pathCurve should be non-degenerate. -or- The input argument pathParams should be an increasing array. -or- The profile CurveLoops do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateSweptBlendGeometry(Curve pathCurve, IList<double> pathParams, IList<CurveLoop> profileLoops, IList<ICollection<VertexPair>> vertexPairs)
      Description: Creates a solid by simultaneously sweeping and blending two or more closed planar curve loops along a single curve.
      @pathCurve: The sweep path, consisting of a single bounded, open curve.
      @pathParams: An increasing sequence of parameters along the path curve (lying within the curve's bounds). These parameters specify the locations of the planes orthogonal to the path that contain the profile loops. This array must have the same size as the input array "profileLoops".
      @profileLoops: Closed, planar curve loops arrayed along the path. No loop may contain just one closed curve - split such loops into two or more curves beforehand. The solid will have these profiles as cross-sections at the points specified by the input pathParams. The solid will blend smoothly between the profiles. This array must have the same size as the input array "pathParams", and each profile loop must lie in the plane orthogonal to the path at the point specified by the corresponding entry in the input array "pathParams". Each profile loop must define a single planar domain and must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.
      @vertexPairs: This input specifies how adjacent profile loops should be connected. It must contain one less element than the "profileLoops" input, and entry vertexPairs[idx] specifies how profileLoops[idx] and profileLoops[idx+1] should be connected (indexing starts at 0).
      Returns: The requested solid.
      Throws ArgumentException: The input pathCurve is a helical curve and is not supported for this operation. -or- The input argument pathCurve should be bounded. The input argument pathCurve should be non-degenerate. -or- The input argument pathParams should be an increasing array. -or- The profile CurveLoops do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops, SolidOptions solidOptions)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above.The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops)The curve loops must be without intersections, self-intersections, or degeneracies.No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
      Throws ArgumentException: The input argument sweepPath should at least contain one curve. -or- The input argument pathAttachmentCrvIdx is not valid. The given attachment point doesn't lie in the plane of the Curve Loop. -or- The profile CurveLoops do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above.The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops)The curve loops must be without intersections, self-intersections, or degeneracies.No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      Returns: The requested solid.
      Throws ArgumentException: The input argument sweepPath should at least contain one curve. -or- The input argument pathAttachmentCrvIdx is not valid. The given attachment point doesn't lie in the plane of the Curve Loop. -or- The profile CurveLoops do not satisfy the input requirements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create the swept solid.

--------------------------------------------------------------------------------

[CLASS] GeometryElement
Full Name: Autodesk.Revit.DB.GeometryElement
Description: Geometric representation of an element.
Remarks: This class contains geometric primitives that are generated from the parametric description of the element. The member geometric primitives can be obtained directly from this object using the capabilities of IEnumerable.
Inherits: GeometryObject
Implements: IEnumerable<GeometryObject>, IEnumerable

  PROPERTIES:
    Material MaterialElement { get; }
      Description: Element describing the material from which this element is composed.

  METHODS:
    BoundingBoxXYZ GetBoundingBox()
      Description: Retrieves a box that encloses the geometry element.
      Returns: The bounding box.
    IEnumerator<GeometryObject> GetEnumerator()
      Description: Returns an enumerator that iterates through the collection.
      Returns: An IEnumerator(GeometryObject) object that can be used to iterate through the collection.
    GeometryElement GetTransformed(Transform transform)
      Description: Returns a transformed copy of the geometry in this element.
      @transform: The transformation to apply to the geometry.
      Throws ArgumentException: Transform is not conformal

--------------------------------------------------------------------------------

[CLASS] GeometryInstance
Full Name: Autodesk.Revit.DB.GeometryInstance
Description: An instance of another element (symbol), specially positioned by this element.
Remarks: A GeometryInstance represents a set of geometry stored by Revit in a default configuration, and then transformed into the proper location as a result of the properties of the element. The most common situation where GeometryInstances are encountered is in Family instances. Revit uses GeometryInstances to allow it to store a single copy of the geometry for a given family and reuse it in multiple instances. Note that not all Family instances will include GeometryInstances. When Revit needs to make a unique copy of the family geometry for a given instance (because of the effect of local joins, intersections, and other factors related to the instance placement) no GeometryInstance will be encountered; instead the Solid geometry will be found at the top level of the hierarchy. Another example of GeometryInstance usage is in Rebar element visible in fine 3D Views. Here, each segement of a rebar is a GeometryInstance. In this case the Symbol Element is contaning all the geometries that are instanced. A GeometryInstance offers the ability to read its geometry through the GetSymbolGeometry() and GetInstanceGeometry() methods. These methods return another Autodesk.Revit.DB.GeometryElement which can be parsed just like the first level return.
Inherits: GeometryObject

  PROPERTIES:
    GeometryElement SymbolGeometry { get; }
      Description: The geometric representation of the symbol which generates this instance.
    Transform Transform { get; }
      Description: The affine transformation from the local coordinate space of the symbol into the coordinate space of the instance.

  METHODS:
    Document GetDocument()
      Description: Gets the document that contains the symbol of this instance.
      Returns: Returns the document that contains the symbol of this instance.
    GeometryElement GetInstanceGeometry(Transform transform)
      Description: Computes a transformation of the geometric representation of the instance.
      @transform: The transformation to apply to the geometry.
      Returns: An element which contains the computed geometry for the transformed instance.
      Throws ArgumentException: Transform is not conformal
    GeometryElement GetInstanceGeometry()
      Description: Computes the geometric representation of the instance.
      Returns: An element which contains the computed geometry for the instance.
    GeometryElement GetSymbolGeometry(Transform transform)
      Description: Computes a transformation of the geometric representation of the symbol which generates this instance.
      @transform: The transformation to apply to the geometry.
      Returns: An element which contains the computed geometry for the transformed symbol.
      Throws ArgumentException: Transform is not conformal
    GeometryElement GetSymbolGeometry()
      Description: Computes the geometric representation of the symbol which generates this instance.
      Returns: An element which contains the computed geometry for the symbol.
    SymbolGeometryId GetSymbolGeometryId()
      Description: Gets the SymbolGeometryId that contains data about the symbol of this instance.
      Returns: Returns the SymbolGeometryId that contains data about the symbol of this instance.

--------------------------------------------------------------------------------

[CLASS] GeometryObject
Full Name: Autodesk.Revit.DB.GeometryObject
Description: The common base class for all geometric primitives.
Inherits: APIObject

  PROPERTIES:
    ElementId GraphicsStyleId { get; }
      Description: The ElementId of the GeometryObject's GraphicsStyle
    int Id { get; }
      Description: A unique integer identifying the GeometryObject in its associated non view-specific GeometryElement.
    bool IsElementGeometry { get; }
      Description: Indicates whether this geometry is obtained directly from an Element.
    Visibility Visibility { get; set; }
      Description: The visibility.

  METHODS:
    bool Equals(object obj)
      Description: Determines whether the specified Object is equal to the current Object.
      @obj: Another object.
    int GetHashCode()
      Description: Gets the integer value of the geometry object as hash code

--------------------------------------------------------------------------------

[CLASS] GlobalParameter
Full Name: Autodesk.Revit.DB.GlobalParameter
Description: This class represents a GlobalParameter element in Revit.
Remarks: Global parameters can be used to drive values of dimensions or other elements' parameters. Also, a global parameter can be driven by a selected dimension, the value of which then determines the value of the global parameter. Such parameters can further be used to drive values of other elements' parameters. See also the GlobalParametersManager class for methods that operate upon global parameters of a document, such as getting all defined global parameters and testing whether a global parameter of certain name already exists or not. Reporting vs. Non-Reporting parametersThere are several ways global parameters can be categorized, but probably the most significant categorization stems from the IsReporting property which divides global parameters into two groups - Reporting and Non-Reporting. The significance of reporting parameters lays in the fact that their values are driven by the dimension that has been labeled by a reporting parameter. It means that the value of a reporting parameter reflects the value of a dimension (length or angle) and gets updated anytime the dimension changes. Non-Reporting parameters behave in the opposite manner - they drive value of dimensions that have been labeled by them, which results in controlling the model's geometry through global parameters' values.Reporting parameters are limited in several ways. They can be only of Length or Angle type, a requirement due to the fact that a dimension must be able to drive the value. For the same reason reporting parameters may not have formulas.Non-Reporting parameters, on the other way, can be of almost any type (Length, Integer, Area, etc.) with the exception of ElementId type. Also, Non-Reporting parameters may have assigned formulas in which other global parameters may be used as arguments. This way one global parameter's value can be derived from other parameter (or parameters), and the other parameter can be either reporting or non-reporting.Creating Global ParametersGlobal parameters get created via the static method ForgeTypeId). It is important to note that each new parameter must have a name that is unique within the document. Parameters are created as non-reporting initially, but programmers are free to modify the IsReporting property once a global parameter is created and is of an eligible type. The programmer can call the HasValidTypeForReporting when in doubt whether parameters of a certain data type can be made reporting. Note, that a parameter may not be made reporting after more than one dimension has been labeled by it. It is because reporting parameter can label (and be driven) by one dimension only.An alternative way of making a parameter reporting is via the ElementId) method which labels one dimension by a global parameter and also makes the parameter reporting if it is not reporting yet.Other important properties of global parameters are IsDrivenByDimension and IsDrivenByFormula, which are mutually exclusive - a parameter that has a formula assigned cannot be driven by a dimension (nor can be reporting) and vice versa.Global Parameters with formulasLike with family parameters, formulas may be assigned to non-reporting global parameters using the String) method (paired with GetFormula to query the current formula.) Formulas may include all standard arithmetic operations and logical operations (as functions and, or, not.) Input to logical operations must be Boolean values (parameters of YesNo type). Consequently, arithmetic operations can be applied to numeric values only. While there are no operations supported for string (text) arguments, strings can be used as results of a logical If operation. Depending on their type (and units), parameters of different value types can be combined. However, unit-less values such as Integer and Number (double) may only be combined with each other. Since formulas can get quite complicated, the method String) is available for the programmer to ensure a formula is valid in order to avoid potential exception due to applying an invalid formula.Labeling dimensionsProbably the most notable feature of global parameters is their ability to "Label" dimensions, a process that establishes dependency of a dimension on a global parameter (or vice versa, depending on the reporting status.) One parameter can label any number of dimensions as long as the parameter is non-reporting. If the parameter labels a multi-segment dimension, values of all segments of this dimension will be equal to the parameter's value. As mentioned above, reporting parameter can label one dimension only, and this dimension can have only one segment. Methods and properties related to labeling include: ElementId), ElementId), and GetLabeledDimensions. Also in this set is the ElementId) method which indicates whether or not a particular dimension can be labeled. Presently, only single linear dimensions and angles are permitted.Elements affected by a Global ParameterGlobal parameters can be associated with other global parameters as well as regular family instance parameters (which may report global parameters as their values via the assignment formula.) There are two methods available to find relations among parameters: GetAffectedGlobalParameters and GetAffectedElements. The former returns all other global parameters that refer to a particular global parameter in their respective formulas. The other method returns a set of all elements of which some parameters are controlled by the global parameter. These two methods together with the GetLabeledDimensions can help the programmer in figuring out how model elements relate to each other via global parameters.Methods for maintaining associations between element properties and global parameters can be found in the Parameter class.Getting and setting the value of a Global ParameterAll global parameters, formula-driven, dimension-driven, or independent, have values. A value can be obtained by calling the GetValue method. The object returned by that method is an instance of one of the classes derived from ParameterValue class. The concrete instance is determined by the type of the global parameter (specified upon creation.) Parameters that are neither formula-driven nor dimension-driven (reporting) can have a value assigned. The method to use is ParameterValue) and it accepts the same type of ParameterValue that is returned by SetValue. However, the type can also be deduced easily: Text parameters accept only StringParameterValue. Integer and YesNo parameters accept only IntegerParameterValue. All other parameters accept only DoubleParameterValue.
Inherits: ParameterElement

  PROPERTIES:
    bool IsDrivenByDimension { get; }
      Description: Indicates whether this parameter is driven by a dimension or not.
    bool IsDrivenByFormula { get; }
      Description: Indicates whether this parameter is driven by a formula or not.
    bool IsReporting { get; set; }
      Description: Indicates whether this is a reporting global parameter or not.

  METHODS:
    bool CanChangeReporting()
      Description: Tests whether the global parameter permits a change of its current value of the IsReporting attribute.
      Returns: Returns True if the change is allowed; False otherwise.
    bool CanLabelDimension(ElementId dimensionId)
      Description: Tests whether a dimension can be labeled by the global parameter.
      @dimensionId: Id of a dimension element.
      Returns: True of the input dimension can be labeled by this global parameter; False oterwise.
      Throws ArgumentNullException: A non-optional argument was null
    static GlobalParameter Create(Document document, string name, ForgeTypeId specTypeId)
      Description: Creates a new Global Parameter in the given document.
      @document: Document in which the new parameter is to be created
      @name: The name of the new parameter. It must be unique in the document
      @specTypeId: Identifier of the spec describing the parameter's data type.
      Returns: An instance of the new global parameter
      Throws ArgumentException: Global parameters are not supported in the given document. A possible cause is that it is not a project document, for global parameters are not supported in Revit families. -or- name is an empty string. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- A global parameter with the given name already exists in the document. -or- specTypeId is not a spec identifier.
      Throws ArgumentNullException: A non-optional argument was null
    ISet<ElementId> GetAffectedElements()
      Description: Returns all elements of which properties are driven by this global parameter.
      Returns: Collection of Element Ids.
    ISet<ElementId> GetAffectedGlobalParameters()
      Description: Returns all other global parameters which refer to this global parameter in their formulas.
      Returns: Collection of Element Ids.
    string GetFormula()
      Description: Returns the parameter's expression in form of a string.
      Returns: The string representing the expression assigned to the parameter.
    ISet<ElementId> GetLabeledDimensions()
      Description: Returns all dimension elements that are currently labeled by this global parameter.
      Returns: Collection of Element Ids.
    string GetLabelName()
      Description: Returns the name of this parameter's label, which is used to label dimension elements.
      Returns: The name of the parameter's label.
    ParameterValue GetValue()
      Description: Obtains the curent value of the global parameter.
      Returns: An instance of one of the classes derived from the ParameterValue base class.
    bool HasValidTypeForReporting()
      Description: Tests that the global parameter has data of a type that supports reporting.
      Returns: True if the parameter has data of a type that supports reporting; False otherwise.
    bool IsValidFormula(string expression)
      Description: Tests that the given expression is a valid as formula for this parameter.
      Throws ArgumentNullException: A non-optional argument was null
    void LabelDimension(ElementId dimensionId)
      Description: Labels a dimension with this global parameter.
      @dimensionId: Id of a dimension element.
      Throws ArgumentException: Given element Id is not of a valid dimension element. -or- Dimension with the Id of dimensionId cannot be labeled by this global parameter. Possible causes include the dimension cannot be labeled at all, or it is a dimension of other than Linear or Angular type, or the Dimension object does not have the appropriate labeling parameter, or the dimension has more than one segment and the parameter is reporting.
      Throws ArgumentNullException: A non-optional argument was null
    void SetDrivingDimension(ElementId dimensionId)
      Description: Set a dimension to drive the value of this parameter.
      @dimensionId: Id of a dimension element.
      Throws ArgumentException: Given element Id is not of a valid dimension element. -or- Dimension with the Id of dimensionId cannot be labeled by this global parameter. Possible causes include the dimension cannot be labeled at all, or it is a dimension of other than Linear or Angular type, or the Dimension object does not have the appropriate labeling parameter, or the dimension has more than one segment and the parameter is reporting.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This is a formula-driven parameter. As such it does not allow the current operation. -or- This non-reporting global parameter has already labeled other dimension segments (more then 1). It cannot, therefore, be made reporting and dimension-driven before un-labeling all the dependent dimensions first.
    void SetFormula(string expression)
      Description: Sets a formula expression for this parameter.
      @expression: Valid formula string.
      Throws ArgumentException: The given expression argument is not valid as a formula for this parameter.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This is a non-reporting global parameter. As such it does not allow the current operation.
    void SetValue(ParameterValue value)
      Description: Sets a new value of the global parameter.
      @value: An instance of one of the value classes derived from ParameterValue.
      Throws ArgumentException: The given value argument is not a valid instance of ParameterValue! -or- The given parameter value arguments is not of the storage type the global parameter expects.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This is a formula-driven parameter. As such it does not allow the current operation. -or- This is a dimension-driven parameter. As such it does not allow the current operation.
    void UnlabelDimension(ElementId dimensionId)
      Description: Unlabels a dimension that is currently labeled by this global parameter.
      @dimensionId: Id of a dimension element.
      Throws ArgumentException: Given element Id is not of a valid dimension element. -or- The given dimension (dimensionId) is not labeled by this global parameter.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] GlobalParametersManager
Full Name: Autodesk.Revit.DB.GlobalParametersManager
Description: A class to access and query information about global parameters in Revit models.
Remarks: This class provides access to general information and data of Global Parameter elements in a particular model. First of all, it is important to know that global parameters can be had in main project document; there are not supported in family documents. Availability of global parameters in a document can be tested by calling Document) method.Global Parameter in a document can be obtained by calling either Document) or String). The former returns a set of all global parameters in the document, while the latter returns just the requested one, providing it exists.Each global parameters must be created with a valid name that is unique in the scope of the document. To test whether a particular name is unique, programmer can use the String) method.More details about creating and manipulating global parameters can be found in the description of the GlobalParameter class.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static bool AreGlobalParametersAllowed(Document document)
      Description: Tests whether global parameters are allowed in the given document.
      @document: A revit document of interest.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    static ElementId FindByName(Document document, string name)
      Description: Finds whether a global parameter with the given name exists in the input document.
      @document: The document expected to contain the global parameter.
      @name: Name of the global parameter
      Returns: ElementId of the parameter element, or InvalidElementId if it was not found.
      Throws ArgumentNullException: A non-optional argument was null
    static ISet<ElementId> GetAllGlobalParameters(Document document)
      Description: Returns all global parameters available in the given document.
      @document: The document containing the global parameters
      Returns: A collection of Element Ids of global parameter elements.
      Throws ArgumentException: Global parameters are not supported in the given document. A possible cause is that it is not a project document, for global parameters are not supported in Revit families.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> GetGlobalParametersOrdered(Document document)
      Description: Returns all global paramters in an ordered array.
      @document: Document containing the requested global parameters
      Returns: An array of Element Ids of all Global Parameters in the document.
      Throws ArgumentException: Global parameters are not supported in the given document. A possible cause is that it is not a project document, for global parameters are not supported in Revit families.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsUniqueName(Document document, string name)
      Description: Tests whether a name is unique among existing global parameters of a given document.
      @document: Document in which a new parameter is to be added.
      @name: A name of a parameter being added.
      Returns: True if the given %name% does not exist yet among existing global parameters nof the document; False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidGlobalParameter(Document document, ElementId parameterId)
      Description: Tests whether an ElementId is of a global parameter in the given document.
      @document: The document containing the global parameter.
      @parameterId: Id of a global parameter
      Returns: Returns True if the Id is of a valid global parameter; False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool MoveParameterDownOrder(Document document, ElementId parameterId)
      Description: Moves given paramerer Down in the current order.
      @document: Document containing the give global parameter
      @parameterId: The parameter to move Down
      Returns: Indicates whether the parameter could be moved Down in order or not.
      Throws ArgumentException: Global parameters are not supported in the given document. A possible cause is that it is not a project document, for global parameters are not supported in Revit families. -or- The input parameterId is not of a valid global parameter of the given document.
      Throws ArgumentNullException: A non-optional argument was null
    static bool MoveParameterUpOrder(Document document, ElementId parameterId)
      Description: Moves given paramerer Up in the current order.
      @document: Document containing the give global parameter
      @parameterId: The parameter to move up
      Returns: Indicates whether the parameter could be moved Up in order or not.
      Throws ArgumentException: Global parameters are not supported in the given document. A possible cause is that it is not a project document, for global parameters are not supported in Revit families. -or- The input parameterId is not of a valid global parameter of the given document.
      Throws ArgumentNullException: A non-optional argument was null
    static void SortParameters(Document document, ParametersOrder order)
      Description: Sorts global parameters in the desired order.
      @document: Document containing the global parameters to be sorted
      @order: Desired sorting order
      Throws ArgumentException: Global parameters are not supported in the given document. A possible cause is that it is not a project document, for global parameters are not supported in Revit families.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] GradientBackgroundSettings
Full Name: Autodesk.Revit.DB.GradientBackgroundSettings
Description: Represents the view gradient background settings.
Remarks: The colors of the background are interpolated for the pixels corresponding to the sky - from the "sky color" (top) to the "horizon color" (bottom). The ground is represented with a solid color ("ground color").
Inherits: BackgroundSettings

  PROPERTIES:
    Color GroundColor { get; set; }
      Description: The color of the ground.
    Color HorizonColor { get; set; }
      Description: The color of the horizon.
    Color SkyColor { get; set; }
      Description: The color of the top of the sky.

--------------------------------------------------------------------------------

[CLASS] GraphicsStyle
Full Name: Autodesk.Revit.DB.GraphicsStyle
Description: The graphics style instance in Autodesk Revit document.
Inherits: Element

  PROPERTIES:
    Category GraphicsStyleCategory { get; }
      Description: The graphics style category.
    GraphicsStyleType GraphicsStyleType { get; }
      Description: The graphics style type.

--------------------------------------------------------------------------------

[ENUM] GraphicsStyleType
Full Name: Autodesk.Revit.DB.GraphicsStyleType
Description: Describes the type of graphics style.
Inherits: Enum

  Values:
    - Projection = 1
    - Cut = 2

--------------------------------------------------------------------------------

[CLASS] Grid
Full Name: Autodesk.Revit.DB.Grid
Description: Represents a single grid line within Autodesk Revit.
Remarks: A Grid is a DatumPlane, so it is actually a three dimensional surface. It can be either a plane parallel to the project z-axis, or else a cylinder whose axis is parallel to the project z-xis. Autodesk::Revit::DatumPlane
Inherits: DatumPlane

  PROPERTIES:
    Curve Curve { get; }
      Description: Retrieves an object that represents the geometry of the grid line.
    bool IsCurved { get; }
      Description: Identifies if the grid line is curved or straight.

  METHODS:
    static Grid Create(Document document, Arc arc)
      Description: Creates a new radial grid line.
      @document: The document in which the new instance is created.
      @arc: An arc object that represents the location of the new grid curve.
      Returns: The newly created grid.
      Throws ArgumentException: document is not a project document. -or- The input arc is not on a horizontal plane.
      Throws ArgumentNullException: A non-optional argument was null
    static Grid Create(Document document, Line line)
      Description: Creates a new grid line.
      @document: The document in which the new instance is created.
      @line: A line which represents the location of the grid line.
      Returns: The newly created grid.
      Throws ArgumentException: document is not a project document. -or- The input line is not on a horizontal plane.
      Throws ArgumentNullException: A non-optional argument was null
    Outline GetExtents()
      Description: Gets the extents of the grid in the model.
      Returns: The extents are the 3D bounding box surrounding the grid. The Z coordinates of the box are used by Revit to determine if the grid should be displayed in a corresponding view plan (if the grid is linear). The extents are not used for arc grids.
    void SetVerticalExtents(double bottom, double top)
      Description: Adjusts the grid to extend through only the vertical range between bottom and top.
      @bottom: The bottom range of the grid extents. It must be a valid number and below the top range.
      @top: The top range of the grid extents. It must be a valid number and above the bottom range.
      Throws ArgumentException: The bottom and top ranges are reversed for the extents.
      Throws ArgumentOutOfRangeException: The given value for bottom must be no more than 30000 feet in absolute value. -or- The given value for top must be no more than 30000 feet in absolute value.
      Throws InvalidOperationException: Couldn't change the extents of the grid.

--------------------------------------------------------------------------------

[STRUCT] GridNode
Full Name: Autodesk.Revit.DB.GridNode
Description: A structure that represents a particular location in (U,V) from a grid.

  CONSTRUCTORS:
    new GridNode(int uIndex, int vIndex)

  PROPERTIES:
    int UIndex { get; set; }
      Description: The node's index along the U axis.
    int VIndex { get; set; }
      Description: The node's index along the V axis.

--------------------------------------------------------------------------------

[ENUM] GridNodeLocation
Full Name: Autodesk.Revit.DB.GridNodeLocation
Description: Location of a grid node relative to the face boundary. See DividedSurface.
Inherits: Enum

  Values:
    - Interior = 0
    - Boundary = 1
    - Exterior = 2

--------------------------------------------------------------------------------

[ENUM] GridSegmentDirection
Full Name: Autodesk.Revit.DB.GridSegmentDirection
Description: Specify one of the four adjacent segments to a GridNode. See DividedSurface.
Inherits: Enum

  Values:
    - PositiveU = 0
    - NegativeU = 1
    - PositiveV = 2
    - NegativeV = 3

--------------------------------------------------------------------------------

[CLASS] GridType
Full Name: Autodesk.Revit.DB.GridType
Description: An object that represents a grid type.
Inherits: LineAndTextAttrSymbol

--------------------------------------------------------------------------------

[CLASS] Group
Full Name: Autodesk.Revit.DB.Group
Description: An element representing a single instance of a group of elements that may be placed many times in a project or family.
Remarks: Grouping elements is useful when you need to create entities that represent repeating layouts or are common to many building projects, such as hotel rooms, apartments, or repeating floors.
Inherits: Element

  PROPERTIES:
    ElementId AttachedParentId { get; }
      Description: Indicates the Id of the parent group this group is attached to.
    GroupType GroupType { get; set; }
      Description: Get or set the type of the group.
    bool IsAttached { get; }
      Description: Indicates wether or not this group is attached to a parent group.
    Location Location { get; }
      Description: This property is used to find the physical location of a group within project.

  METHODS:
    ISet<ElementId> GetAvailableAttachedDetailGroupTypeIds()
      Description: Returns the attached detail groups available for this group type.
      Returns: Returns the collection of attached detail group Ids that match this group's type.
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups.
    IList<ElementId> GetMemberIds()
      Description: Retrieves all the member ElementIds of the group.
      Returns: An ordered list of the members within the group. The order of this list can be used to match members between other instances of the group.
    ISet<ElementId> GetShownAttachedDetailGroupTypeIds(View view)
      Description: Returns the attached detail groups which have displayed instances for this group type in the input view.
      @view: The view in which the attached detail groups are displayed.
      Returns: The collection of attached detail group Ids that match this group's type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups.
    void HideAllAttachedDetailGroups(View view)
      Description: Hides all the available attached detail groups for this element group type that are compatible with the input view type.
      @view: The view that the attached detail groups must be compatible with.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups.
    void HideAttachedDetailGroups(View view, ElementId detailGroupTypeId)
      Description: Hides the element group's attached detail groups of the input group type that are compatible with the input view.
      @view: The view that the attached detail groups must be compatible with.
      @detailGroupTypeId: Only attached detail groups of this type will be hidden.
      Throws ArgumentException: The attached detail group detailGroupTypeId does not match the input view's orientation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups.
    bool IsCompatibleAttachedDetailGroupType(View view, ElementId detailGroupTypeId)
      Description: Checks if the orientation of the input attached detail group matches the input view's orientation.
      @view: The view that the input attached detail group must be compatible with.
      @detailGroupTypeId: The attached detail group that will be checked for compatibility with the input view.
      Returns: Returns true if the input attached detail group is compatible with the input view and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups.
    void ShowAllAttachedDetailGroups(View view)
      Description: Shows all the available attached detail groups for this element group type that are compatible with the input view type.
      @view: The view that the attached detail groups must be compatible with.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups. -or- This exception is thrown if this group's attached detail groups cannot be found in the current document.
    void ShowAttachedDetailGroups(View view, ElementId detailGroupTypeId)
      Description: Shows the element group's attached detail groups of the input group type that are compatible with the input view.
      @view: The view that the attached detail groups must be compatible with.
      @detailGroupTypeId: Only attached detail groups of this type will be shown.
      Throws ArgumentException: The attached detail group detailGroupTypeId does not match the input view's orientation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input group is not a model group and can therefore not have attached detail groups. -or- This exception is thrown if the input attached detail group cannot be found in the current document.
    ICollection<ElementId> UngroupMembers()
      Description: Ungroups the group.
      Returns: If successful, the ids of the members of group are returned.
      Throws InvalidOperationException: Thrown if the group cannot be ungrouped.

--------------------------------------------------------------------------------

[CLASS] GroupLoadOptions
Full Name: Autodesk.Revit.DB.GroupLoadOptions
Description: A class containing options for loading a group from a file.
Implements: IDisposable

  CONSTRUCTORS:
    new GroupLoadOptions()
      Description: Creates a new instance of a GroupLoadOptions object.

  PROPERTIES:
    bool IncludeAttachedDetails { get; set; }
      Description: True if attached detail groups should be included, false otherwise. The default value is .
    bool IncludeGrids { get; set; }
      Description: True if grids should be brought in from the input file, false otherwise. The default value is .
    bool IncludeLevels { get; set; }
      Description: True if levels should be brought in from the input file, false otherwise. The default value is .
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ReplaceDuplicatedGroups { get; set; }
      Description: If there are groups with the same names in source and destination documents set this property to to replace existing groups, otherwise the operation will be canceled. The default value is .

  METHODS:
    void Dispose()
    IDuplicateTypeNamesHandler GetDuplicateTypeNamesHandler()
      Description: Returns current duplicate type names handler or if none is set.
    void SetDuplicateTypeNamesHandler(IDuplicateTypeNamesHandler handler)
      Description: Sets a custom duplicate type names handler. If this value is not set, the default handler is used. By default, Revit displays a modal dialog with options to either copy new types only, or cancel the operation.
      @handler: The duplicate type names handler.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] GroupNode
Full Name: Autodesk.Revit.DB.GroupNode
Description: A node that represents set of individual elements grouped together in some form, such as an instance of a family or linked Revit file, or an instance of a part of symbol's geometry.
Inherits: RenderNode

  METHODS:
    Transform GetTransform()
      Description: A transformation matrix associated with the node.

--------------------------------------------------------------------------------

[CLASS] GroupSet
Full Name: Autodesk.Revit.DB.GroupSet
Description: An set that contains groups.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new GroupSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of groups that are in the set.

  METHODS:
    void Clear()
      Description: Removes every group from the set, rendering it empty.
    bool Contains(Group item)
      Description: Tests for the existence of a group within the set.
      @item: The group to be searched for.
      Returns: The Contains method returns True if the group is within the set, otherwise False.
    int Erase(Group item)
      Description: Removes a specified group from the set.
      @item: The group to be erased.
      Returns: The number of groups that were erased from the set.
    GroupSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Group item)
      Description: Insert the specified group into the set.
      @item: The group to be inserted into the set.
      Returns: Returns whether the group was inserted into the set.
    GroupSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GroupSetIterator
Full Name: Autodesk.Revit.DB.GroupSetIterator
Description: An iterator to a group set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new GroupSetIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the set.
    void Reset()
      Description: Bring the iterator back to the start of the set.

--------------------------------------------------------------------------------

[CLASS] GroupType
Full Name: Autodesk.Revit.DB.GroupType
Description: An element representing a group of elements that may be placed many times in a project or family.
Remarks: Grouping elements is useful when you need to create entities that represent repeating layouts or are common to many building projects, such as hotel rooms, apartments, or repeating floors.
Inherits: ElementType

  PROPERTIES:
    GroupSet Groups { get; }
      Description: Retrieve a set of all the groups that have this type.

  METHODS:
    ISet<ElementId> GetAvailableAttachedDetailGroupTypeIds()
      Description: Returns the attached detail groups available for this element group type.
      Returns: Returns the collection of attached detail group Ids that match this group's type.
    void LoadFrom(string fileName, GroupLoadOptions options)
      Description: Replaces the group with the contents of the input file.
      @fileName: The file to be used for the replacment.
      @options: Group load options.
      Throws ArgumentException: Not a valid RVT file.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given fileName does not exist.
      Throws InvalidOperationException: The element "this GroupType" is in a document which is in an edit mode or is in family mode. -or- The element "this GroupType" does not belong to a project document. -or- The GroupType is not a Model group type and can't be reloaded.
      Throws ModificationForbiddenException: The document containing this GroupType is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this GroupType is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this GroupType has no open transaction.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GroupTypeId
Full Name: Autodesk.Revit.DB.GroupTypeId
Description: This class contains constants identifying parameter groups.

  PROPERTIES:
    static ForgeTypeId AdskModelProperties { get; }
      Description: Model Properties.
    static ForgeTypeId AlternateUnits { get; }
      Description: Alternate Units.
    static ForgeTypeId AnalysisResults { get; }
      Description: Analysis Results.
    static ForgeTypeId AnalyticalAlignment { get; }
      Description: Analytical Alignment.
    static ForgeTypeId AnalyticalModel { get; }
      Description: Analytical Model.
    static ForgeTypeId AnalyticalProperties { get; }
      Description: Analytical Properties.
    static ForgeTypeId Area { get; }
      Description: Area.
    static ForgeTypeId ConceptualEnergyData { get; }
      Description: Conceptual Energy Data.
    static ForgeTypeId ConceptualEnergyDataBuildingServices { get; }
      Description: Energy Model - Building Services.
    static ForgeTypeId Constraints { get; }
      Description: Constraints.
    static ForgeTypeId Construction { get; }
      Description: Construction.
    static ForgeTypeId ContinuousrailBeginBottomExtension { get; }
      Description: Extension (Beginning/Bottom).
    static ForgeTypeId ContinuousrailEndTopExtension { get; }
      Description: Extension (End/Top).
    static ForgeTypeId CouplerArray { get; }
      Description: Set.
    static ForgeTypeId CurtainGrid { get; }
      Description: Grid.
    static ForgeTypeId CurtainGridHoriz { get; }
      Description: Horizontal Grid.
    static ForgeTypeId CurtainGridn1 { get; }
      Description: Grid 1.
    static ForgeTypeId CurtainGridn2 { get; }
      Description: Grid 2.
    static ForgeTypeId CurtainGridU { get; }
      Description: U Grid.
    static ForgeTypeId CurtainGridV { get; }
      Description: V Grid.
    static ForgeTypeId CurtainGridVert { get; }
      Description: Vertical Grid.
    static ForgeTypeId CurtainMullionHoriz { get; }
      Description: Horizontal Mullions.
    static ForgeTypeId CurtainMullionn1 { get; }
      Description: Grid 1 Mullions.
    static ForgeTypeId CurtainMullionn2 { get; }
      Description: Grid 2 Mullions.
    static ForgeTypeId CurtainMullionVert { get; }
      Description: Vertical Mullions.
    static ForgeTypeId Data { get; }
      Description: Data.
    static ForgeTypeId Display { get; }
      Description: Display.
    static ForgeTypeId DivisionGeometry { get; }
      Description: Division Geometry.
    static ForgeTypeId Electrical { get; }
      Description: Electrical.
    static ForgeTypeId ElectricalAnalysis { get; }
      Description: Electrical Analysis.
    static ForgeTypeId ElectricalCircuiting { get; }
      Description: Electrical - Circuiting.
    static ForgeTypeId ElectricalEngineering { get; }
      Description: Electrical Engineering.
    static ForgeTypeId ElectricalLighting { get; }
      Description: Electrical - Lighting.
    static ForgeTypeId ElectricalLoads { get; }
      Description: Electrical - Loads.
    static ForgeTypeId EnergyAnalysis { get; }
      Description: Energy Analysis.
    static ForgeTypeId EnergyAnalysisAdvanced { get; }
      Description: Advanced.
    static ForgeTypeId EnergyAnalysisBldgConsMtlThermalProps { get; }
      Description: Material Thermal Properties.
    static ForgeTypeId EnergyAnalysisBuildingData { get; }
      Description: Building Data.
    static ForgeTypeId EnergyAnalysisConceptualModel { get; }
      Description: Energy Analytical Model.
    static ForgeTypeId EnergyAnalysisDetailedAndConceptualModels { get; }
      Description: Essential.
    static ForgeTypeId EnergyAnalysisDetailedModel { get; }
      Description: Detailed Model.
    static ForgeTypeId EnergyAnalysisRoomSpaceData { get; }
      Description: Room/Space Data.
    static ForgeTypeId FabricationProductData { get; }
      Description: Fabrication Product Data.
    static ForgeTypeId FireProtection { get; }
      Description: Fire Protection.
    static ForgeTypeId Fitting { get; }
      Description: Fittings.
    static ForgeTypeId Flexible { get; }
      Description: Adaptive Component.
    static ForgeTypeId Forces { get; }
      Description: Forces.
    static ForgeTypeId General { get; }
      Description: General.
    static ForgeTypeId GeoLocation { get; }
      Description: Geolocation.
    static ForgeTypeId Geometry { get; }
      Description: Geometry.
    static ForgeTypeId GeometryPositioning { get; }
      Description: Geometric Position.
    static ForgeTypeId Graphics { get; }
      Description: Graphics.
    static ForgeTypeId GreenBuilding { get; }
      Description: Green Building Properties.
    static ForgeTypeId IdentityData { get; }
      Description: Identity Data.
    static ForgeTypeId Ifc { get; }
      Description: IFC Parameters.
    static ForgeTypeId Insulation { get; }
      Description: Insulation.
    static ForgeTypeId Length { get; }
      Description: Length.
    static ForgeTypeId LifeSafety { get; }
      Description: Life Safety.
    static ForgeTypeId LightPhotometrics { get; }
      Description: Photometrics.
    static ForgeTypeId Lining { get; }
      Description: Lining.
    static ForgeTypeId Materials { get; }
      Description: Materials and Finishes.
    static ForgeTypeId Mechanical { get; }
      Description: Mechanical.
    static ForgeTypeId MechanicalAirflow { get; }
      Description: Mechanical - Flow.
    static ForgeTypeId MechanicalLoads { get; }
      Description: Mechanical - Loads.
    static ForgeTypeId Moments { get; }
      Description: Moments.
    static ForgeTypeId Nodes { get; }
      Description: Nodes.
    static ForgeTypeId OverallLegend { get; }
      Description: Overall Legend.
    static ForgeTypeId Pattern { get; }
      Description: Pattern.
    static ForgeTypeId PatternApplication { get; }
      Description: Pattern Application.
    static ForgeTypeId Phasing { get; }
      Description: Phasing.
    static ForgeTypeId Plumbing { get; }
      Description: Plumbing.
    static ForgeTypeId PrimaryEnd { get; }
      Description: Primary End.
    static ForgeTypeId PrimaryUnits { get; }
      Description: Primary Units.
    static ForgeTypeId Profile { get; }
      Description: Profile.
    static ForgeTypeId Profilen1 { get; }
      Description: Profile 1.
    static ForgeTypeId Profilen2 { get; }
      Description: Profile 2.
    static ForgeTypeId RailingSystemFamilyHandrails { get; }
      Description: Handrail 1.
    static ForgeTypeId RailingSystemFamilySegmentPattern { get; }
      Description: Segment Pattern (default).
    static ForgeTypeId RailingSystemFamilyTopRail { get; }
      Description: Top Rail.
    static ForgeTypeId RailingSystemSecondaryFamilyHandrails { get; }
      Description: Handrail 2.
    static ForgeTypeId RailingSystemSegmentPatternRemainder { get; }
      Description: Pattern Remainder.
    static ForgeTypeId RailingSystemSegmentPatternRepeat { get; }
      Description: Pattern Repeat.
    static ForgeTypeId RailingSystemSegmentPosts { get; }
      Description: Posts.
    static ForgeTypeId RailingSystemSegmentUGrid { get; }
      Description: U Grid.
    static ForgeTypeId RailingSystemSegmentVGrid { get; }
      Description: V Grid.
    static ForgeTypeId RebarArray { get; }
      Description: Rebar Set.
    static ForgeTypeId RebarSystemLayers { get; }
      Description: Layers.
    static ForgeTypeId Reference { get; }
      Description: Reference.
    static ForgeTypeId ReleasesMemberForces { get; }
      Description: Releases / Member Forces.
    static ForgeTypeId RotationAbout { get; }
      Description: Rotation about.
    static ForgeTypeId RouteAnalysis { get; }
      Description: Route Analysis.
    static ForgeTypeId SecondaryEnd { get; }
      Description: Secondary End.
    static ForgeTypeId SegmentsFittings { get; }
      Description: Segments and Fittings.
    static ForgeTypeId SlabShapeEdit { get; }
      Description: Slab Shape Edit.
    static ForgeTypeId SplitProfileDimensions { get; }
      Description: Dimensions (linear units or % of thickness).
    static ForgeTypeId StairRisers { get; }
      Description: Risers.
    static ForgeTypeId StairsCalculatorRules { get; }
      Description: Calculation Rules.
    static ForgeTypeId StairsOpenEndConnection { get; }
      Description: End Connection.
    static ForgeTypeId StairsSupports { get; }
      Description: Supports.
    static ForgeTypeId StairsTreadsRisers { get; }
      Description: Threads/Risers.
    static ForgeTypeId StairStringers { get; }
      Description: Stringers.
    static ForgeTypeId StairsWinders { get; }
      Description: Winders.
    static ForgeTypeId StairTreads { get; }
      Description: Treads.
    static ForgeTypeId Structural { get; }
      Description: Structural.
    static ForgeTypeId StructuralAnalysis { get; }
      Description: Structural Analysis.
    static ForgeTypeId StructuralSectionDimensions { get; }
      Description: Structural Section Dimensions.
    static ForgeTypeId StructuralSectionGeometry { get; }
      Description: Structural Section Geometry.
    static ForgeTypeId Support { get; }
      Description: Supports.
    static ForgeTypeId SystemtypeRisedrop { get; }
      Description: Rise / Drop.
    static ForgeTypeId Termination { get; }
      Description: Terminations.
    static ForgeTypeId Text { get; }
      Description: Text.
    static ForgeTypeId Title { get; }
      Description: Title Text.
    static ForgeTypeId ToposolidSubdivision { get; }
      Description: Sub-division.
    static ForgeTypeId TranslationIn { get; }
      Description: Translation in.
    static ForgeTypeId TrussFamilyBottomChord { get; }
      Description: Bottom Chords.
    static ForgeTypeId TrussFamilyDiagWeb { get; }
      Description: Diagonal Webs.
    static ForgeTypeId TrussFamilyTopChord { get; }
      Description: Top Chords.
    static ForgeTypeId TrussFamilyVertWeb { get; }
      Description: Vertical Webs.
    static ForgeTypeId Underlay { get; }
      Description: Underlay.
    static ForgeTypeId ViewCamera { get; }
      Description: Camera.
    static ForgeTypeId ViewExtents { get; }
      Description: Extents.
    static ForgeTypeId ViewPositioning { get; }
      Description: View to Sheet Positioning.
    static ForgeTypeId Visibility { get; }
      Description: Visibility.
    static ForgeTypeId Visualization { get; }
      Description: Visualization.
    static ForgeTypeId WallCrossSectionDefinition { get; }
      Description: Cross-Section Definition.

--------------------------------------------------------------------------------

[CLASS] GuidEnum
Full Name: Autodesk.Revit.DB.GuidEnum
Description: Base class of all GUID-based enum classes.

  CONSTRUCTORS:
    new GuidEnum(Guid guid)
      Description: Creates an Guid-based enum instance with the supplied name and GUID. GUID-based enum instance can be compared by this guid value.
      @guid: The GUID of this GUID-based enum.

  PROPERTIES:
    Guid Guid { get; }
      Description: The Guid of GUID-based enum object.

  METHODS:
    bool Equals(object obj)
      Description: Compares two Guid-based enum object based on their concrete class and GUID value.
    int GetHashCode()
      Description: Generates a hash code for this Guid-based enum object.

--------------------------------------------------------------------------------

[CLASS] HasNoValueFilterRule
Full Name: Autodesk.Revit.DB.HasNoValueFilterRule
Description: Tests whether an element's parameter doesn't have a value.
Inherits: ParameterValuePresenceRule

  CONSTRUCTORS:
    new HasNoValueFilterRule(ElementId parameter)
      Description: constructs an instance of HasNoValueFilterRule.
      @parameter: The parameter that an element must not have a value for to pass this rule.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] HasValueFilterRule
Full Name: Autodesk.Revit.DB.HasValueFilterRule
Description: Tests whether an element's parameter has a value.
Inherits: ParameterValuePresenceRule

  CONSTRUCTORS:
    new HasValueFilterRule(ElementId parameter)
      Description: constructs an instance of HasValueFilterRule.
      @parameter: The parameter that an element must have a value for to pass this rule.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] HermiteFace
Full Name: Autodesk.Revit.DB.HermiteFace
Description: A cubic hermite spline face of a 3d solid or open shell.
Remarks: Hermite faces are defined by cubic hermite spline surfaces bounded by edge loops. The surfaces provide natural UV parameterization to the faces.
Inherits: Face

  PROPERTIES:
    IList<XYZ> MixedDerivs { get; }
      Description: Mixed derivatives of the surface.
    DoubleArray Params { get; }
    IList<XYZ> Points { get; }
      Description: Interpolation points of the surface.
    IList<XYZ> Tangents { get; }

--------------------------------------------------------------------------------

[CLASS] HermiteSpline
Full Name: Autodesk.Revit.DB.HermiteSpline
Description: A Hermite spline.
Remarks: The Hermite spline lies in the plane defined by control points.
Inherits: Curve

  PROPERTIES:
    IList<XYZ> ControlPoints { get; set; }
      Description: The control points of the Hermite spline.
    bool IsPeriodic { get; }
      Description: Returns whether the Hermite spline is periodic or not.
    DoubleArray Parameters { get; }
      Description: Returns the params of the Hermite spline.
    IList<XYZ> Tangents { get; }
      Description: Returns the tangents of the Hermite spline.

  METHODS:
    static HermiteSpline Create(IList<XYZ> controlPoints, bool periodic, HermiteSplineTangents tangents)
      Description: Creates a Hermite spline with specified tangency at its endpoints.
      @controlPoints: The control points of the Hermite spline.
      @periodic: True if the Hermite spline is to be periodic, false otherwise.
      @tangents: The object which indicates tangency at the start, the end, or both ends of the curve.
      Returns: The new HermiteSpline object.
      Throws ArgumentException: The control points array is invalid, because it doesn't contain the minimum number of points (2).
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentsInconsistentException: Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).
      Throws InvalidOperationException: Unable to construct valid HermiteSpline from given inputs.
    static HermiteSpline Create(IList<XYZ> controlPoints, bool periodic)
      Description: Creates a Hermite spline with default tangency at its endpoints.
      @controlPoints: The control points of the Hermite spline.
      @periodic: True if the Hermite spline is to be periodic, false otherwise.
      Returns: The new HermiteSpline object.
      Throws ArgumentException: The control points array is invalid, because it doesn't contain the minimum number of points (2).
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentsInconsistentException: Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).
      Throws InvalidOperationException: Unable to construct valid HermiteSpline from given inputs.

--------------------------------------------------------------------------------

[CLASS] HermiteSplineTangents
Full Name: Autodesk.Revit.DB.HermiteSplineTangents
Description: This class indicates tangency at the start, the end, or both ends of the curve.
Remarks: Initially, the tangent vectors will not be set, and no tangency condition will be imposed when the curve is created.
Implements: IDisposable

  CONSTRUCTORS:
    new HermiteSplineTangents()
      Description: Constructs a new default instance of the class, with tangent vectors uninitialized.

  PROPERTIES:
    XYZ EndTangent { get; set; }
      Description: The tangent vector at the end of the curve.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ StartTangent { get; set; }
      Description: The tangent vector at the start of the curve.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] HermiteSurface
Full Name: Autodesk.Revit.DB.HermiteSurface
Description: A Hermite Surface.
Inherits: Surface

  METHODS:
    static HermiteSurface Create(int nU, int nV, IList<XYZ> points, bool periodicU, bool periodicV)
      Description: Create a Hermite surface using a net of 3D points as input. Specify periodicity in U and V direction.
      @nU: Number of points in U direction.
      @nV: Number of points in V direction.
      @points: Array of points. Must contain nU*nV points.
      @periodicU: Periodicity in U direction
      @periodicV: Periodicity in V direction
      Returns: A Hermite surface object created from input data.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: Thrown when the input arguments are inconsistent. The most common case is incorrect number of items in one of the lists.
    static HermiteSurface Create(int nU, int nV, IList<XYZ> points)
      Description: Create a non-periodic Hermite surface using a net of 3D points as input.
      @nU: Number of points in U direction.
      @nV: Number of points in V direction.
      @points: Array of points. Must contain nU*nV points.
      Returns: A Hermite surface object created from input data.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: Thrown when the input arguments are inconsistent. The most common case is incorrect number of items in one of the lists.
    bool IsValid()
      Description: Checks whether this HermiteSurface object is valid.
      Returns: True if this is a valid Hermite Surface, false otherwise.

--------------------------------------------------------------------------------

[ENUM] HiddenLineViewsType
Full Name: Autodesk.Revit.DB.HiddenLineViewsType
Description: An enumerated type listing all Hidden Line Views types of Print Setting.
Inherits: Enum

  Values:
    - VectorProcessing = 0
    - RasterProcessing = 1

--------------------------------------------------------------------------------

[CLASS] HomeCamera
Full Name: Autodesk.Revit.DB.HomeCamera
Description: A structure that contains information about the camera and view for the Home view orientation stored in the model.
Implements: IDisposable

  CONSTRUCTORS:
    new HomeCamera(HomeCamera other)
      Description: Constructs a new copy of the input HomeCamera object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    double BottomAngleOfFieldOfView { get; }
      Description: The bottom angle of the field of view.
    XYZ Center { get; }
      Description: The zoom or orbit center.
    XYZ EyePosition { get; }
      Description: The eye position point.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LeftAngleOfFieldOfView { get; }
      Description: The left angle of the field of view.
    double OrthogonalProjectionHeight { get; }
      Description: The height of orthogonal projection view volume.
    double OrthogonalProjectionWidth { get; }
      Description: The width of orthogonal projection view volume.
    XYZ Pivot { get; }
      Description: The pivot point.
    double RightAngleOfFieldOfView { get; }
      Description: The right angle of the field of view.
    double TopAngleOfFieldOfView { get; }
      Description: The top angle of the field of view.
    XYZ UpDirection { get; }
      Description: The up direction vector.
    ElementId ViewId { get; }
      Description: The id of the view which is associated to this document's Home view orientation.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] HorizontalAlign
Full Name: Autodesk.Revit.DB.HorizontalAlign
Description: Horizontal alignment of model text.
Inherits: Enum

  Values:
    - Left = 64
    - Center = 128
    - Right = 256

--------------------------------------------------------------------------------

[ENUM] HorizontalAlignmentStyle
Full Name: Autodesk.Revit.DB.HorizontalAlignmentStyle
Description: Declares the horizontal alignment style of font.
Inherits: Enum

  Values:
    - Left = 0
    - Center = 1
    - Right = 2

--------------------------------------------------------------------------------

[ENUM] HorizontalTextAlignment
Full Name: Autodesk.Revit.DB.HorizontalTextAlignment
Description: Supported types of horizontal alignment of a text element and text justification within the text containing box.
Inherits: Enum

  Values:
    - Left = 0
    - Right = 1
    - Center = 2

--------------------------------------------------------------------------------

[ABSTRACT CLASS] HostedSweep
Full Name: Autodesk.Revit.DB.HostedSweep
Description: An object that represents an object hosted by an edge of a roof or floor within the Autodesk Revit project.
Inherits: HostObject

  PROPERTIES:
    double Angle { get; set; }
      Description: Retrieve/set the angle of the hosted sweep object relative its references (Unit : Radian).
    bool HorizontalFlipped { get; }
      Description: Retrieve the horizontal flip status of the hosted sweep object.
    double HorizontalOffset { get; set; }
      Description: Retrieve/set the horizontal offset of the hosted sweep object.
    double Length { get; }
      Description: Retrieve the length of the hosted sweep object.
    Curve ReferenceCurve { get; }
    bool VerticalFlipped { get; }
      Description: Retrieve the vertical flip status of the hosted sweep object.
    double VerticalOffset { get; set; }
      Description: Retrieve/set the vertical offset of the hosted sweep object.

  METHODS:
    void AddSegment(Reference targetRef)
      Description: Add segments to the hosted sweep object.
    double GetEndPointParameter(Reference targetRef, int endIdx)
      Description: Retrieve segment's start point or end point parameter.
      @targetRef: Segment's reference whose parameter want to be get.
      @endIdx: Start point (=0) or end point (=1).
      Returns: Start point or end point parameter.
      Throws InvalidOperationException: Thrown when regeneration fails.
    void HorizontalFlip()
      Description: Flip the hosted sweep object along horizontal line.
    void RemoveSegment(Reference targetRef)
      Description: Remove segments from the hosted sweep object.
      @targetRef: Segment's reference which want to be removed.
      Throws InvalidOperationException: Thrown when regeneration fails.
    bool SetEndPointParameter(Reference targetRef, int endIdx, double param)
      Description: Set segment's start point or end point parameter.
      @targetRef: Segment's reference whose parameter want to be set.
      @endIdx: Start point (=0) or end point (=1).
      @param: Value of parameter.
      Returns: true if operation success.
      Throws InvalidOperationException: Thrown when regeneration fails.
    void VerticalFlip()
      Description: Flip the hosted sweep object along vertical line.

--------------------------------------------------------------------------------

[CLASS] HostedSweepType
Full Name: Autodesk.Revit.DB.HostedSweepType
Description: An object that represents the attributes for sweep host objects in Autodesk Revit.
Inherits: HostObjAttributes

--------------------------------------------------------------------------------

[CLASS] HostObjAttributes
Full Name: Autodesk.Revit.DB.HostObjAttributes
Description: An object that represents characteristics of several kinds of type.
Remarks: This object provides access to structural layering components for any object derived from it, such as wall types and floor types.
Inherits: ElementType

  METHODS:
    CompoundStructure GetCompoundStructure()
      Description: Returns an object that represents the compound structure of the element.
    void SetCompoundStructure(CompoundStructure compoundStructure)
      Description: Sets the compound structure of the element.

--------------------------------------------------------------------------------

[CLASS] HostObject
Full Name: Autodesk.Revit.DB.HostObject
Description: A base class that provides support for all objects that can host other objects, such as walls roofs, and floors.
Inherits: Element

  METHODS:
    IList<ElementId> FindInserts(bool addRectOpenings, bool includeShadows, bool includeEmbeddedWalls, bool includeSharedEmbeddedInserts)
      Description: Gets the ids of the instances inserted into this host object.
      @addRectOpenings: True if rectangular openings should be included in the return.
      @includeShadows: True if shadows should be included in the return.
      @includeEmbeddedWalls: True if embedded walls should be included in the return.
      @includeSharedEmbeddedInserts: True if shared embedded inserts should be included in the return.
      Returns: All the insertable instances' ids.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] HostObjectUtils
Full Name: Autodesk.Revit.DB.HostObjectUtils
Description: These are generic host object utilities.

  METHODS:
    static IList<Reference> GetBottomFaces(HostObject hostObject)
      Description: Returns the bottom faces for this host object.
      @hostObject: The host object.
      Returns: An array of references to the faces which are at the bottom of this element.
      Throws ArgumentException: This host object does not support access to top or bottom faces.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<Reference> GetSideFaces(HostObject hostObject, ShellLayerType side)
      Description: Returns the major side faces for this host object.
      @hostObject: The host object.
      @side: The side of the host object.
      Returns: An array of references to the faces which are on the given side of this element.
      Throws ArgumentException: This host object does not support access to side faces.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static IList<Reference> GetTopFaces(HostObject hostObject)
      Description: Returns the top faces for this host object.
      @hostObject: The host object.
      Returns: An array of references to the faces which are at the top of this element.
      Throws ArgumentException: This host object does not support access to top or bottom faces.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[INTERFACE] ICentralLockedCallback
Full Name: Autodesk.Revit.DB.ICentralLockedCallback
Description: An interface that may be used to control Revit's behavior when it tries to lock central and is blocked because another user already has locked central.

  METHODS:
    bool ShouldWaitForLockAvailability()
      Description: Returns whether Revit should wait and try again to acquire the lock on central.
      Returns: True means wait and try again later. False means immediately give up.

--------------------------------------------------------------------------------

[INTERFACE] IConnector
Full Name: Autodesk.Revit.DB.IConnector
Description: An interface which provides access to connector in Autodesk Revit MEP document.
Remarks: This interface is shared by Connector, ConnectorElement.

  PROPERTIES:
    Transform CoordinateSystem { get; }
      Description: The coordinate system of the connector.
    Domain Domain { get; }
      Description: The domain of the connector.
    double Height { get; }
      Description: The height of the connector.
    XYZ Origin { get; }
      Description: The location of the connector in family document.
    double Radius { get; }
      Description: The radius of the connector.
    ConnectorProfileType Shape { get; }
      Description: The shape of the connector.
    double Width { get; }
      Description: The width of the connector.

--------------------------------------------------------------------------------

[INTERFACE] ICustomFieldProperties
Full Name: Autodesk.Revit.DB.ICustomFieldProperties
Description: Represents the base class for the properties of a custom field.

  METHODS:
    bool AreEqualTo(ICustomFieldProperties otherProperties)
      Description: Identifies if the custom field properties are equal or not.
      @otherProperties: The other properties.
      Returns: Returns true if the custom field properties are equal, false otherwise.

--------------------------------------------------------------------------------

[INTERFACE] IDataConversionMonitor
Full Name: Autodesk.Revit.DB.IDataConversionMonitor
Description: A base class for an application-specific logger. It should be used to track errors during conversion and/or , track conversion progress, cancel a conversion process if necessary. Implementing a logger class is optional, but highly recommended for all but most basic data converters. The base class is UI- and language-independent. It is up to the using app to implement UI. Language-specifc data may be used to communicate information to application users. English should be used to communicate data of interest to Revit development.

  METHODS:
    DataExchangeMessageVerbosity GetVerbosity()
      Description: Reports requested verbosity level
    bool ProcessMessage(DataExchangeMessageId messageId, DataExchangeMessageSeverity messageSeverity, IList<string> entityIds)
      Description: The default implementation ignores input and always returns true. The using app should override the behavior as necessary. Some examples of overridden behavior are 1. Someone is developing a classic Revit add-on that imports STEP AP 203 solids. She will implement a log object such that a) At each imported face (logMessage() called with LogMessage::FaceCreated as first argument) the log object will update count of imported faces and call an application-specific progress indicator where appropriate b) If the app gets a cancel request between the calls to logMessage(), the next call will return false. The Import API will then cancel the conversion and clean up the intermediate data. 2. Someone is implementing a web service to convert IFC files to RVT. As a part of that service UI, the user would like to cancel the conversion on the first error in order to avoid being charged for storage/processor time. The implementation of logMessage() in that case would be different: the cancellation request would be based on severity of the error. The app would probably want to keep a detailed count of entities converted. 3. Someone is implementing an IFC importer. Each API call is fast enough that cancelation/progress requests are handled by the application. Problems with data should be reported to the user, but the conversion should go on regardless. The app collects its own conversion statistics. The app developer implements logMessage() to accumulate reported errors and appends the formatted results to her conversion report. The overloaded logMessage() always returns true, since all cancellations are handled by the app.
      @messageId: Indicates a specific event during data conversion.
      @messageSeverity: Indicates a severity of the event.
      @entityIds: Input objects affected by the reported event.
      Returns: If the function returns true, the import API will continue conversion. Otherwise, it will be cancelled and all intermediate data reset.

--------------------------------------------------------------------------------

[INTERFACE] IDuplicateTypeNamesHandler
Full Name: Autodesk.Revit.DB.IDuplicateTypeNamesHandler
Description: An interface for custom handlers of duplicate type names encountered during a paste operation. When the destination document contains types that have the same names as the types being copied, but different internals, a decision must be made on how to proceed - whether to cancel the operation or continue, but only copy types with unique names.

  METHODS:
    DuplicateTypeAction OnDuplicateTypeNamesFound(DuplicateTypeNamesHandlerArgs args)
      Description: Called when the destination document contains types with the same names as the types being copied.
      @args: The information about the types with duplicate names.
      Returns: The action to be taken: copy only types with unique names or cancel the operation.

--------------------------------------------------------------------------------

[INTERFACE] IExportContext
Full Name: Autodesk.Revit.DB.IExportContext
Description: An interface that is used in custom export to process a Revit model.
Remarks: An instance of a class that implements this interface is passed in as a parameter of the CustomExporter constructor. The methods of the context are then called at times of exporting entities of the model.This is a base class for two other interfaces derived from it: IPhotoRenderContext and IModelExportContext. This base class contains methods that are common to both the leaf interfaces. Although it is still possible to use classes deriving directly from this base interface (for backward compatibility), future applications should implement the new leaf interfaces only.

  METHODS:
    void Finish()
      Description: This method is called at the very end of the export process, after all entities were processed (or after the process was cancelled).
    bool IsCanceled()
      Description: This method is queried at the beginning of every element.
      Returns: Return True if you wish to cancel the exporting process, or False otherwise.
    RenderNodeAction OnElementBegin(ElementId elementId)
      Description: This method marks the beginning of an element to be exported.
      @elementId: The Id of the element that is about to be processed.
      Returns: Return RenderNodeAction.Skip if you wish to skip exporting this element, or return RenderNodeAction.Proceed otherwise.
    void OnElementEnd(ElementId elementId)
      Description: This method marks the end of an element being exported.
      @elementId: The Id of the element that has just been processed.
    RenderNodeAction OnFaceBegin(FaceNode node)
      Description: This method marks the beginning of a Face to be exported.
      @node: An output node that represents a Face.
      Returns: Return RenderNodeAction. Proceed if you wish to receive geometry (polymesh) for this face, or return RenderNodeAction.Skip otherwise.
    void OnFaceEnd(FaceNode node)
      Description: This method marks the end of the current face being exported.
      @node: An output node that represents a Face.
    RenderNodeAction OnInstanceBegin(InstanceNode node)
      Description: This method marks the start of processing of an instance node (e.g. a family instance).
      Returns: Return RenderNodeAction.Skip if you wish to skip processing this family instance, or return RenderNodeAction.Proceed otherwise.
    void OnInstanceEnd(InstanceNode node)
      Description: This method marks the end of processing of an Instance Node (e.g. a family instance).
      @node: An output node that represents a family instance.
    void OnLight(LightNode node)
      Description: This method marks the beginning of export of a light which is enabled for rendering.
      @node: A node describing the light object.
    RenderNodeAction OnLinkBegin(LinkNode node)
      Description: This method marks the beginning of a link instance to be exported.
      Returns: Return RenderNodeAction.Skip if you wish to skip processing this link instance, or return RenderNodeAction.Proceed otherwise.
    void OnLinkEnd(LinkNode node)
      Description: This method marks the end of a link instance being exported.
      @node: An output node that represents a Revit link.
    void OnMaterial(MaterialNode node)
      Description: This method marks a change of the material.
      @node: A node describing the current material.
    void OnPolymesh(PolymeshTopology node)
      Description: This method is called when a tessellated polymesh of a 3d face is being output.
      @node: A node representing topology of the polymesh
    void OnRPC(RPCNode node)
      Description: This method marks the beginning of export of an RPC object.
      @node: A node with asset information about the RPC object.
    RenderNodeAction OnViewBegin(ViewNode node)
      Description: This method marks the beginning of a 3D view to be exported.
      @node: Geometry node associated with the view.
      Returns: Return RenderNodeAction.Skip if you wish to skip exporting this view, or return RenderNodeAction.Proceed otherwise.
    void OnViewEnd(ElementId elementId)
      Description: This method marks the end of a 3D view being exported.
      @elementId: The Id of the 3D view that has just been processed.
    bool Start()
      Description: This method is called at the very start of the export process, still before the first entity of the model was send out.
      Returns: Return True if you are ready to proceed with processing the export.

--------------------------------------------------------------------------------

[INTERFACE] IExportContext2D
Full Name: Autodesk.Revit.DB.IExportContext2D
Description: An interface that is used in custom export to export 2D views of a Revit model.
Remarks: An instance of a class that implements this interface is passed in as a parameter of the CustomExporter constructor. The interface methods are then called at times of drawing entities that are currently visible in the view being exported.With this type of export context used to perform a custom export, Revit will traverse the model and output the model's geometry as if in the process of regular displaying or exporting a 2D View. It means that any geometry which is visible in an open view (taking any current visibility setting applicable to the view) will be processed and output. Optionally, annotation objects are also output.Note 1. Curves passed to calls FaceEdgeNode) and FaceSilhouetteNode) may be partially duplicating each other.Note 2. If element E is a FamilyInstance and it contains an imported instance then: between the calls to OnElementBegin2D/OnElementEnd2D for element E there will be calls to OnInstanceBegin/OnInstanceEnd with the "node" argument pointing to the element with its symbol being of category BuiltInCategories.OST_ImportObjectStylesall geometry exported for the element E has to be additionally subject to the transform T=E.GetTotalTransform()
Implements: IExportContextBase, IExportContext

  METHODS:
    RenderNodeAction OnElementBegin2D(ElementNode node)
      Description: This method marks the beginning of an element to be exported.
      @node: Node representing the element that is about to start being exported. Contains element ID and document.
      Returns: Return RenderNodeAction.Skip if you wish to skip exporting this element, or return RenderNodeAction.Proceed otherwise.
    void OnElementEnd2D(ElementNode node)
      Description: This method marks the end of an element being exported.
      @node: An output node that represents an element.
    RenderNodeAction OnFaceEdge2D(FaceEdgeNode node)
      Description: This method is called when a Face edge is being output.
      @node: An output node that represents a Face edge.
      Returns: Return RenderNodeAction.Proceed if you wish to receive tessellated geometry (line or polyline segments) for this face edge, or otherwise return RenderNodeAction.Skip. Note: if the export is performed for the view in non-Wireframe display style tesselated geometry will be output regardless of the return value.
    RenderNodeAction OnFaceSilhouette2D(FaceSilhouetteNode node)
      Description: This method is called when a Face silhouette is being output.
      @node: An output node that represents a Face silhouette.
      Returns: Return RenderNodeAction.Proceed if you wish to receive tessellated geometry (line or polyline segments) for this face silhouette, or otherwise return RenderNodeAction.Skip. Note: if the export is performed for the view in non-Wireframe display style tesselated geometry will be output regardless of the return value.

--------------------------------------------------------------------------------

[INTERFACE] IExportContextBase
Full Name: Autodesk.Revit.DB.IExportContextBase
Description: An interface that as common base for IModelExportContext and IExportContext2D.
Implements: IExportContext

  METHODS:
    RenderNodeAction OnCurve(CurveNode node)
      Description: This method is called when a Curve is being output.
      @node: An output node that represents a Curve.
      Returns: Return RenderNodeAction.Proceed if you wish to receive tessellated geometry (line or polyline segments) for this curve, or otherwise return RenderNodeAction.Skip. Note for 2D export: if the export is performed for the view in non-Wireframe display style tesselated geometry will be output regardless of the return value.
    void OnLineSegment(LineSegment segment)
      Description: This method is called after unhandled curve was tessellated to line segments and sent to the output. Note for 2D export: if the export is performed for the view in non-Wireframe display style, then this method is called outside of view, instance and link begin/end calls but still between OnElementBegin2D/OnElementEnd2D callsthis method is never called for annotation elements, i.e. their geometry should be processed in methods OnCurve and OnPolyline
      @segment: A structure describing the line segment.
    RenderNodeAction OnPolyline(PolylineNode node)
      Description: This method is called when a Polyline is being output.
      @node: An output node that represents a Polyline.
      Returns: Return RenderNodeAction.Proceed if you wish to receive tessellated geometry (polyline segments) for this polyline, or otherwise return RenderNodeAction.Skip. Note for 2D export: if the export is performed for the view in non-Wireframe display style tesselated geometry will be output regardless of the return value.
    void OnPolylineSegments(PolylineSegments segments)
      Description: This method is called after unhandled curve was tessellated to polyline segments and sent to the output. Note for 2D export: if the export is performed for the view in non-Wireframe display style, then this method is called outside of view, instance and link begin/end calls but still between OnElementBegin2D/OnElementEnd2D callsthis method is never called for annotation elements, i.e. their geometry should be processed in methods OnCurve and OnPolyline
      @segments: A structure describing the polyline segments.
    void OnText(TextNode node)
      Description: This method is called when a text annotation object is being output.
      @node: An output node that represents a text annotation.

--------------------------------------------------------------------------------

[INTERFACE] IExtension
Full Name: Autodesk.Revit.DB.IExtension
Description: An interface that supports the additional operation for Extension Status

  PROPERTIES:
    bool Extended { get; set; }
    bool HasMiter { get; }
    bool IsMiterLocked { get; set; }
    bool SymbolicExtended { get; set; }

--------------------------------------------------------------------------------

[INTERFACE] IExternalDBApplication
Full Name: Autodesk.Revit.DB.IExternalDBApplication
Description: An interface that supports addition of DB-level external applications to Revit, to subscribe to DB-level events and updaters.
Remarks: DB-level applications are permitted to add DB-level events and updaters to the session. They cannot create or modify UI.

  METHODS:
    ExternalDBApplicationResult OnShutdown(ControlledApplication application)
      Description: Implement this method to execute some tasks when Autodesk Revit shuts down.
      @application: Handle to the Revit Application object.
      Returns: Indicates if the external db application completes its work successfully.
    ExternalDBApplicationResult OnStartup(ControlledApplication application)
      Description: Implement this method to execute some tasks when Autodesk Revit starts.
      @application: Handle to the Revit Application object.
      Returns: Indicates if the external db application completes its work successfully.

--------------------------------------------------------------------------------

[INTERFACE] IExternalResourceServer
Full Name: Autodesk.Revit.DB.IExternalResourceServer
Description: The interface used to provide custom implementation to provide access to external resources (such as linked files) from arbitrary locations.
Remarks: Certain resources used in a Revit model are stored outside of the .rvt file. For example, the data used for keynotes, images used as decals during rendering, CAD links, and Revit links are all stored outside the model. Creating a new implementation of this server allows the server to supply one or more types of such resources from an arbitrary source. For example, a server could provide the keynote data from a database or from a file format that Revit does not support.If a model references resources supplied by this server, Revit will request the resource from the server when it is required. Most external resources are loaded into memory at the time the model is loaded. The server will also be invoked if the resource is explicitly reloaded.IExternalResourceServer can declare that a resource is already up-to-date via ExternalResourceReference) If the resource is up-to-date, Revit will skip loading to improve performance.Each resource load request will be associated with a GUID, so that server implementers can uniquely identify a given load request. This may be useful to, for example, store server-side errors associated with an attempt to load a particular resource.If your server handles Revit or CAD links, you must take special care with link paths. When one of these file types is uploaded to your server, any nested references should be brought to the server along with the main link. Your server will need to repath any nested reference itself; Revit will not handle this automatically.In the case of DWG links, your server will also need to download and possibly repath any xrefs when LoadResource is called for the top-level link. Revit will only request the top-level link directly.In the case of Revit links, the ExternalResourceReferences for any nested links will also need to be modified in the host document. The host document should reference the Revit links at their server locations, not their local file locations. Revit may not be able to find links if the paths are not set up correctly. See Autodesk::Revit::DB::TransmissionData::ReadTransmissionData to inspect the set of links contained within a Revit model. See Autodesk::Revit::DB::RevitLinkType::LoadFrom to reload a Revit link from a server version.Here is an example which uses nested Revit links: A user has a Revit model containing one link, Link.rvt, which contains one nested link, Nest.rvt. The user uploads Link.rvt to a server, using an add-in provided by that server. The server provider must also take Nest.rvt. Further, the server provider must open Link.rvt and modify the reference to Nest.rvt so that it references the version on the server. Otherwise, Revit will not be able to find Nest.rvt when another user tries to load Link.rvt from the server.The external resource framework has been designed to allow server authors to display UI related to the resource load operation and UI browse operation. No UI should be displayed directly from an IExternalResourceServer. Instead, developers should create an IExternalResourceUIServer which will handle UI tasks on behalf of the IExternalResourceServer. For more information, see the documentation for the ExternalResourceLoadContent) and ExternalResourceBrowserData) methods.
Implements: IExternalServer

  METHODS:
    bool AreSameResources(IDictionary<string, string> reference1, IDictionary<string, string> reference2)
      Description: Implement this method to indicate whether two given resources are the same.
      Returns: True if two given resources are the same; otherwise false.
    string GetIconPath()
      Description: Implement this method to return the path to an icon file which will be displayed in Revit user interfaces associated to this server.
      Returns: The image file of the server.
    string GetInformationLink()
      Description: The method that Revit will invoke to obtain a URL address which provides more information about the server.
      Returns: The URL providing server information.
    string GetInSessionPath(ExternalResourceReference reference, string originalDisplayPath)
      Description: Implement this method to provide the path that should be used for display and browsing to a given ExternalResourceReference during this Revit session.
      @reference: The ExternalResourceReference for which Revit is requesting the in session display path.
      @originalDisplayPath: The path that was provided for the resource when the resource was originally loaded into the model.
      Returns: The display path that should be used for this resource for this session of Revit.
    ResourceVersionStatus GetResourceVersionStatus(ExternalResourceReference reference)
      Description: Implement this method to indicate whether the given version of a resource is the most current version of the data.
      @reference: The ExternalResourceReference to check.
      Returns: An enum indicating whether the resource is current, out of date, or of unknown status.
    string GetShortName()
      Description: Implement this method to return the short name of the server.
      Returns: The short name of the server.
    void GetTypeSpecificServerOperations(ExternalResourceServerExtensions extensions)
      Description: Implement this method to get operations supported by the external server for a particular type of external resource.
      @extensions: The class which owns sub-interface classes, each of which has methods related to a particular type of external resource.
    bool IsResourceWellFormed(ExternalResourceReference extRef)
      Description: Implement this method to check whether the given ExternalResourceReference is formatted correctly for this server.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference represents a well-formed resource. False otherwise.
    void LoadResource(Guid loadRequestId, ExternalResourceType resourceType, ExternalResourceReference desiredResource, ExternalResourceLoadContext loadContext, ExternalResourceLoadContent loadResults)
      Description: Implement this method to load the requested resource.
      @loadRequestId: The id uniquely identifying the load request.
      @resourceType: The type of resource requested.
      @desiredResource: The specific resource that should be loaded.
      @loadContext: A class containing info about the context of the load request.
      @loadResults: The data returned by the server as a result of this load operation. Revit will ensure that this argument is the appropriate subclass of ExternalResourceLoadContent for the type of data.
    void SetupBrowserData(ExternalResourceBrowserData browseData)
      Description: Implement this method to setup external resource browser data which will be accessed in Revit external resource browser UI.
      @browseData: The input context to match the external resources and browser results returned by the server.
    bool SupportsExternalResourceType(ExternalResourceType type)
      Description: Implement this method to indicate whether the server can provide data for a specified type of external resource.
      @type: The ExternalResourceType of interest to the caller. For example, KeynoteTable - to determine if the server provides data for Revit's keynote table.
      Returns: True if the server supports the specified type of external resource

--------------------------------------------------------------------------------

[INTERFACE] IFailuresPreprocessor
Full Name: Autodesk.Revit.DB.IFailuresPreprocessor
Description: An interface that may be used to perform a preprocessing step to either filter out anticipated transaction failures or to mark certain failures as non-continuable.
Remarks: This interface, if provided, is invoked when there are failures found at the end of a transaction. An instance of this interface can be set in the failure handling options of transaction object.

  METHODS:
    FailureProcessingResult PreprocessFailures(FailuresAccessor failuresAccessor)
      Description: This method is called when there have been failures found at the end of a transaction and Revit is about to start processing them.
      @failuresAccessor: The Interface class that provides access to the failure information.
      Returns: Notifies end of transaction code about further actions required. Return values are interpreted as follows: Continue - the failure processing will continue. Failures will be shown to the user, even if they were addressed by this method.ProceedWithCommit - end of transaction checks and failure processing will restart from the beginning. If some failures were resolved here, they will be removed and not delivered to the user. ProceedWithCommit cannot be returned if transaction is being rolled back.ProceedWithRollBack - the failure processing will continue. Failures will be shown to the user, but user will have no option to resolve or ignore them - only cancel option will be available. If intent is to roll back transaction without showing failures to the user, it can be achieved by setting failure handling option to remove failures before returning ProceedWithRollBack. Other return values are not allowed.

--------------------------------------------------------------------------------

[INTERFACE] IFailuresProcessor
Full Name: Autodesk.Revit.DB.IFailuresProcessor
Description: To create your own UI or fully automated tool to process Revit Failures, derive a class from this interface.
Remarks: To override Revit default Failures Processing UI, instantiate your own processor derived from this interface and register it in Revit application.

  METHODS:
    void Dismiss(Document document)
      Description: This method is being called in case of exception or document destruction to dismiss any possible pending failure UI that may have left on the screen
      @document: Document for which pending failures processing UI should be dismissed
    FailureProcessingResult ProcessFailures(FailuresAccessor data)
      Description: Method that Revit will invoke to process failures at the end of transaction.
      @data: Provides all necessary data to perform the resolution of failures.
      Returns: The result of the failures processing. Continue - Should be returned if there were no failures or highest failure severity was "Warning" and all warnings were deleted. If some failures are still present and "Continue" is returned, it will be treated as "ProceedWithRollback". Note: If this method has attempted to resolve failures, it should return "ProceedWithCommit" to repeat end of transaction checks and failures processing.ProceedWithCommit - End of transaction checks and failure processing will restart from the beginning. If some failures were resolved, they will be removed and not delivered to the user. ProceedWithCommit cannot be returned if transaction is being rolled back.ProceedWithRollBack - Transaction will be rolled back even if Commit was originally requested.WaitForUserInput - Should be returned if method has activated modeless user interaction and is waiting for an external event (typically user input) to complete failures processing.

--------------------------------------------------------------------------------

[INTERFACE] IFamilyLoadOptions
Full Name: Autodesk.Revit.DB.IFamilyLoadOptions
Description: An interface class which provide the callback for family load options.
Remarks: If the family is not loaded, or if the family is loaded but unchanged, the situation will never trigger and Boolean@) and Boolean@) will not be called. Only if the family is loaded and changed should the interface methods be called.

  METHODS:
    bool OnFamilyFound(bool familyInUse, out bool overwriteParameterValues)
      Description: A method called when the family was found in the target document.
      @familyInUse: Indicates if one or more instances of the family is placed in the project.
      @overwriteParameterValues: This determines whether or not to overwrite the parameter values of existing types. The default value is false.
      Returns: Return true to continue loading the family, false to cancel.
    bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
      Description: A method called when the shared family was found in the target document.
      @sharedFamily: The shared family in the current family document.
      @familyInUse: Indicates if one or more instances of the family is placed in the project.
      @source: This indicates if the family will load from the project or the current family.
      @overwriteParameterValues: This indicates whether or not to overwrite the parameter values of existing types.
      Returns: Return true to continue loading the family, false to cancel.

--------------------------------------------------------------------------------

[CLASS] IFCBuiltInCategoryKey
Full Name: Autodesk.Revit.DB.IFCBuiltInCategoryKey
Description: A key used to represent an item stored in a template.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] IFCCategoryTemplate
Full Name: Autodesk.Revit.DB.IFCCategoryTemplate
Description: Represents an element that contains an IFC category mapping template stored in a Revit document.
Inherits: Element

  CONSTRUCTORS:
    new IFCCategoryTemplate(Document document)
      Description: Custom constructor for this element.
      @document: Document where created template is saved.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidCategoryMappingFile { get; set; }
      Description: Whether or not the category mapping file is valid.

  METHODS:
    IFCCategoryTemplate CopyTemplate(Document document, string copyTemplateName)
      Description: Create copy of mapping template with new name.
      @document: A Revit document to save the copied template.
      @copyTemplateName: A name for copied template name.
      Returns: The copied mapping template element.
      Throws ArgumentException: The name already exists.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create IFCCategoryTemplate element.
    static IFCCategoryTemplate Create(Document document, string name)
      Description: Create a IFC category mapping template with default values.
      @document: Document where created mapping template is saved.
      @name: The name specified to this mapping template.
      Returns: The new mapping template instance.
      Throws ArgumentException: The name already exists.
      Throws ArgumentNullException: A non-optional argument was null
    void ExportToFile(Document document, string fileName)
      Description: Export mapping template to a text file.
      @document: A Revit document.
      @fileName: A full text file name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: Failed to access the text file.
    static IFCCategoryTemplate FindByName(Document document, string name)
      Description: Returns mapping template element by name.
      @document: The document to find the mapping template with the specified name.
      @name: Name of the mapping template to find.
      Returns: The mapping template element, or if not found.
      Throws ArgumentNullException: A non-optional argument was null
    static IFCCategoryTemplate GetActiveTemplate(Document document)
      Description: Gets the active mapping template element in the document.
      @document: The document to find the active mapping template.
      Returns: The active mapping template, or if none.
      Throws ArgumentNullException: A non-optional argument was null
    IDictionary<ExportIFCCategoryKey, ExportIFCCategoryInfo> GetCategoryMappingTable(Document document)
      Description: Gets the table that contains a mapping from Revit categories to IFC entities.
      @document: The document.
      Returns: The mapping table.
      Throws ArgumentNullException: A non-optional argument was null
    ExportIFCCategoryInfo GetMappingInfoById(Document document, ElementId categoryId, CustomSubCategoryId customSubCategoryId)
      Description: Gets a copy of IFC mapping info by category id.
      @document: A Revit document.
      @categoryId: The category id.
      @customSubCategoryId: The custom subcategory id.
      Returns: Return the info for this category.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static IFCCategoryTemplate GetOrCreateInSessionTemplate(Document document)
      Description: Gets the in-session non-serializable template or create new.
      @document: The document to find the in-session mapping template.
      Returns: The mapping template, or if failed to create.
      Throws ArgumentNullException: A non-optional argument was null
    static IFCCategoryTemplate ImportFromFile(Document document, string fileName, string templateName)
      Description: Import mapping template from a text file.
      @document: A Revit document.
      @fileName: A full text file name.
      @templateName: A mapping template name.
      Returns: The mapping template element.
      Throws ArgumentException: The name already exists.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: Failed to access the text file.
      Throws InvalidOperationException: Failed to create IFCCategoryTemplate element.
    static bool IsValidName(Document document, string name)
      Description: Returns result that the proposed name is valid and not exist in the specified document.
      @document: Document to check
      @name: Name to check.
      Returns: Whether or not the name is valid.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<string> ListNames(Document document)
      Description: Returns a list of names of IFC export mapping templates.
      @document: A Revit document to retrieve names from.
      Returns: An array of strings representing names of predefined setups.
      Throws ArgumentNullException: A non-optional argument was null
    static void ResetActiveTemplate(Document document)
      Description: Removes the information about active mapping temple of the document.
      @document: The document to set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ExportIFCCategoryInfo ResetCategoryToDefault(ExportIFCCategoryKey categoryKey)
      Description: Reset one category, sub-category, or special category in the current mapping table to the default values defined in Revit
      @categoryKey: The selected category information.
      Returns: The default information.
      Throws ArgumentNullException: A non-optional argument was null
    void SetActiveTemplate()
      Description: Sets the mapping template element to be the active mapping template for its document.
      Throws InvalidOperationException: Invalid use of in-session template.
    void SetActiveTemplate(Document document)
      Description: Sets the mapping template element to be the active mapping template in the document.
      @document: The document to set.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void SetMappingInfo(ExportIFCCategoryKey key, ExportIFCCategoryInfo info)
      Description: Set the mapping info for the key.
      @key: The key.
      @info: The info.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMappingInfo(IDictionary<ExportIFCCategoryKey, ExportIFCCategoryInfo> newMap)
      Description: Set the mapping info for multiple keys.
      @newMap: The updated map.
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateCategoryList(Document document)
      Description: Updates the mapping table with the categories from the document.
      @document: A Revit document to retrieve names from.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] IFCExportElement
Full Name: Autodesk.Revit.DB.IFCExportElement
Description: An enumerated type defining if an element is exported to IFC or not.
Inherits: Enum

  Values:
    - ByType = 0
    - Yes = 1
    - No = 2

--------------------------------------------------------------------------------

[ENUM] IFCExportElementType
Full Name: Autodesk.Revit.DB.IFCExportElementType
Description: An enumerated type defining if an element type is exported to IFC or not.
Inherits: Enum

  Values:
    - Default = 0
    - Yes = 1
    - No = 2

--------------------------------------------------------------------------------

[CLASS] IFCExportOptions
Full Name: Autodesk.Revit.DB.IFCExportOptions
Description: IFC Export options.
Implements: IDisposable

  CONSTRUCTORS:
    new IFCExportOptions(IFCExportOptions from)
      Description: Creates a copy of an IFCExportOptions.
      Throws ArgumentNullException: A non-optional argument was null
    new IFCExportOptions()
      Description: Default constructor. Initializes FileVersion to Default. WallAndColumnSplitting and ExportBaseQuantities are set to false. FamilyMappingFile is set to empty.

  PROPERTIES:
    bool ExportBaseQuantities { get; set; }
      Description: Option to export IFC standard quantities currently supported by Revit.
    string FamilyMappingFile { get; set; }
      Description: Path to a file containing family mapping.
    IFCVersion FileVersion { get; set; }
      Description: IFC file version.
    ElementId FilterViewId { get; set; }
      Description: Id of the view whose visibility settings will govern the contents in the exported IFC file.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int SpaceBoundaryLevel { get; set; }
      Description: Level of space boundaries exported in IFC file.
    bool WallAndColumnSplitting { get; set; }
      Description: Option to allow division of multi-level walls and columns by levels.

  METHODS:
    void AddOption(string name, string value)
      Description: Adds a new named option to the options structure.
      @name: The option name.
      @value: The option value.
      Throws ArgumentNullException: A non-optional argument was null
    void Assign(IFCExportOptions sourceOptions)
      Description: Assigns the values of the IFCExportOptions to this options object.
      @sourceOptions: The source IFCExportOptions.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] IFCParameterTemplate
Full Name: Autodesk.Revit.DB.IFCParameterTemplate
Description: Represents an element that contains an IFC parameter mapping template stored in a Revit document.
Inherits: Element

  CONSTRUCTORS:
    new IFCParameterTemplate(Document document)
      Description: Custom constructor for this element.
      @document: The document where created template is saved.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool ExportIFCBaseQuantities { get; set; }
      Description: The option to export IFC base quantities for exported Revit elements. If true, then all IFC base quantities not excluded will be exported. If false, then no IFC base quantities will be exported.
    bool ExportIFCCommonPropertySets { get; set; }
      Description: The option to export IFC common property sets for exported Revit elements. If true, then all IFC Common Property Sets not excluded will be exported. If false, then no IFC Common Property Sets will be exported.
    bool ExportRevitElementParameters { get; set; }
      Description: The option to export Revit element parameters to IFC. If true, then all Revit element parameters not excluded will be exported. If false, then no Revit element parameters will be exported.
    bool ExportRevitMaterialParameters { get; set; }
      Description: The option to export Revit material parameters to IFC. If true, then all Revit material parameters not excluded will be exported. If false, then no Revit material parameters will be exported.
    bool ExportRevitSchedules { get; set; }
      Description: The option to export Revit schedules to IFC. If true, then all Revit schedules not excluded will be exported. If false, then no Revit schedules will be exported.
    bool ExportUserDefinedPropertySets { get; set; }
      Description: The option to export user-defined property sets. If true, then all user-defined property sets not excluded will be exported. If false, then no user-defined property sets will be exported.
    bool IsValidParameterMappingFile { get; set; }
      Description: Whether or not the parameter mapping file is valid.

  METHODS:
    void AddPropertyMappingInfo(PropertySetupType propertySetupType, string propertySetName, IFCPropertyMappingInfo propertyMappingInfo)
      Description: Adds a property mapping info to the property set.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @propertyMappingInfo: The property mapping info.
      Throws ArgumentException: The mapping info is invalid. -or- A property set with the given name is not present in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void AddPropertySet(PropertySetupType propertySetupType, bool exportFlag, string propertySetName)
      Description: Adds a property set to the template.
      @propertySetupType: The property setup type.
      @exportFlag: The flag that indicates whether the property set is included in export.
      @propertySetName: The property set name.
      Throws ArgumentException: A property set with the given name already exists in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void ClearPropertySets(PropertySetupType propertySetupType)
      Description: Removes all property sets from the template.
      @propertySetupType: The property setup type.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void CopyPropertySet(PropertySetupType propertySetupType, string propertySetName, string propertySetCopyName)
      Description: Creates a copy of the property set and adds it to the template.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @propertySetCopyName: The name of the copied property set.
      Throws ArgumentException: A property set with the given name is not present in the template. -or- A property set with the given name already exists in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IFCParameterTemplate CopyTemplate(Document document, string copyTemplateName)
      Description: Create copy of mapping template with new name.
      @document: The Revit document to save the copied template.
      @copyTemplateName: The name for copied template name.
      Returns: The copied mapping template element.
      Throws ArgumentException: The name already exists.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to create IFCParameterTemplate element.
    static IFCParameterTemplate Create(Document document, string name)
      Description: Create an IFC parameter mapping template with default values.
      @document: The document where created mapping template is saved.
      @name: The name specified to this mapping template.
      Returns: The new mapping template instance.
      Throws ArgumentException: The name already exists.
      Throws ArgumentNullException: A non-optional argument was null
    void ExportPropertySetupToFile(PropertySetupType propertySetupType, string fileName)
      Description: Exports mapping information of the provided property setup to a text file.
      @propertySetupType: The property setup type.
      @fileName: The full text file name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws FileAccessException: Failed to access the text file.
    void ExportToFile(string fileName)
      Description: Export mapping template to a text file.
      @fileName: The full text file name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: Failed to access the text file.
    static IFCParameterTemplate FindByName(Document document, string name)
      Description: Returns mapping template element by name.
      @document: The document to find the mapping template with the specified name.
      @name: Name of the mapping template to find.
      Returns: The mapping template element, or if not found.
      Throws ArgumentNullException: A non-optional argument was null
    IFCPropertyMappingInfo FindPropertyMappingInfo(PropertySetupType propertySetupType, string propertySetName, ElementId revitPropertyId)
      Description: Finds the property mapping info in the property set by id.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @revitPropertyId: The Revit property id.
      Returns: The property mapping info or if not found.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IFCPropertyMappingInfo FindPropertyMappingInfo(PropertySetupType propertySetupType, string propertySetName, string propertyName)
      Description: Finds the property mapping info in the property set by name.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @propertyName: The property name.
      Returns: The property mapping info or if not found.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static IFCParameterTemplate GetActiveTemplate(Document document)
      Description: Gets the active mapping template element in the document.
      @document: The document to find the active mapping template.
      Returns: The active mapping template, or if none.
      Throws ArgumentNullException: A non-optional argument was null
    static IFCParameterTemplate GetOrCreateInSessionTemplate(Document document)
      Description: Gets the in-session non-serializable template or create new.
      @document: The document where created mapping template is saved.
      Returns: The mapping template.
      Throws ArgumentNullException: A non-optional argument was null
    IList<IFCPropertyMappingInfo> GetPropertyMappingInfos(PropertySetupType propertySetupType, string propertySetName, PropertySelectionType propertySelectionType)
      Description: Creates an array of property mappings contained in the property set according to provided selection type.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @propertySelectionType: The property selection type.
      Returns: The array of the property mappings in the property set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<string> GetPropertySetApplicableEntities(PropertySetupType propertySetupType, string propertySetName)
      Description: Gets the list of IFC entities to which the property set is applicable.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      Returns: The list of IFC entities to which the property set is applicable.
      Throws ArgumentException: A property set with the given name is not present in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<string> GetPropertySetNames(PropertySetupType propertySetupType, PropertySelectionType propertySelectionType)
      Description: Creates an array of property set names contained in the template according to provided selection type.
      @propertySetupType: The property setup type.
      @propertySelectionType: The property selection type.
      Returns: The array of the property set names in the template.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static IFCParameterTemplate ImportFromFile(Document document, string fileName, string templateName)
      Description: Import mapping template from a text file.
      @document: The Revit document.
      @fileName: The full text file name.
      @templateName: The mapping template name.
      Returns: The mapping template element.
      Throws ArgumentException: The name already exists.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: Failed to access the text file.
      Throws InvalidOperationException: Failed to create IFCParameterTemplate.
    void ImportPropertySetupFromFile(string fileName)
      Description: Imports mapping information from a text file.
      @fileName: The full text file name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: Failed to access the text file.
    bool IsExportingPropertySet(PropertySetupType propertySetupType, string propertySetName)
      Description: Determines whether the provided property set is included in export.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      Returns: Whether or not the property set is included in export.
      Throws ArgumentException: A property set with the given name is not present in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsInSessionTemplate()
      Description: Returns true if this is an in-session template.
      Returns: Whether or not the template is in-session.
    bool IsPropertySetAMemberOfTemplate(PropertySetupType propertySetupType, string propertySetName)
      Description: Checks whether a property set exists in the template.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      Returns: True if the property set exists in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool IsValidName(Document document, string name)
      Description: Returns result that the proposed name is valid and not exist in the specified document.
      @document: The document to check
      @name: The name to check.
      Returns: Whether or not the name is valid.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<string> ListNames(Document document)
      Description: Returns a list of names of IFC export parameter mapping templates.
      @document: The Revit document to retrieve names from.
      Returns: The array of strings representing names of predefined setups.
      Throws ArgumentNullException: A non-optional argument was null
    void RemovePropertyMappingInfo(PropertySetupType propertySetupType, string propertySetName, ElementId revitPropertyId)
      Description: Removes the property mapping from the property set by id.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @revitPropertyId: The Revit property id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void RemovePropertyMappingInfo(PropertySetupType propertySetupType, string propertySetName, string propertyName)
      Description: Removes the property mapping from the property set by name.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @propertyName: The property name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void RemovePropertySet(PropertySetupType propertySetupType, string propertySetName)
      Description: Removes provided property set from the template.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      Throws ArgumentException: A property set with the given name is not present in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static void ResetActiveTemplate(Document document)
      Description: Removes the information about active mapping temple of the document.
      @document: The document to set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void SetActiveTemplate()
      Description: Sets the mapping template element to be the active mapping template for its document.
      Throws InvalidOperationException: Invalid use of in-session template.
    void SetInSessionTemplateDocument(Document document)
      Description: Set document for in-session template.
      @document: The Revit document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The template is not an is-session.
    void SetPropertySetApplicableEntities(PropertySetupType propertySetupType, string propertySetName, IList<string> applicableEntities)
      Description: Sets the list of IFC entities to which the property set is applicable.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @applicableEntities: The list of IFC entities to which the property set is applicable.
      Throws ArgumentException: A property set with the given name is not present in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetPropertySetExportingFlag(PropertySetupType propertySetupType, string propertySetName, bool exportFlag)
      Description: Define whether the provided property set must be included in export.
      @propertySetupType: The property setup type.
      @propertySetName: The property set name.
      @exportFlag: The export flag.
      Throws ArgumentException: A property set with the given name is not present in the template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] IFCPropertyMappingInfo
Full Name: Autodesk.Revit.DB.IFCPropertyMappingInfo
Description: Represents the IFC property mapping information stored in the template.
Implements: IDisposable

  CONSTRUCTORS:
    new IFCPropertyMappingInfo(bool exportFlag, string ifcPropertyName, ElementId revitPropertyId, string revitPropertyName)
      Description: Constructs a new IFCPropertyMappingInfo with input values. The flag that indicates whether the property is included in export. The property name. The Revit property id. The Revit property id.
      Throws ArgumentNullException: A non-optional argument was null
    new IFCPropertyMappingInfo()
      Description: Constructs a new IFCPropertyMappingInfo with default values.

  PROPERTIES:
    bool ExportFlag { get; set; }
      Description: Whether or not the property is included in export.
    string IFCPropertyName { get; set; }
      Description: The IFC property name.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId RevitPropertyId { get; set; }
      Description: The Revit property id.
    string RevitPropertyName { get; set; }
      Description: The Revit property name.

  METHODS:
    void Dispose()
    static bool IsValidMappingInfo(IFCPropertyMappingInfo mappingInfo)
      Description: Defines whether the mapping info contains meaningful data.
      @mappingInfo: The mapping info
      Returns: Whether or not the mapping info is valid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] IFCPropertySetMappingInfo
Full Name: Autodesk.Revit.DB.IFCPropertySetMappingInfo
Description: Represents the IFC property set mapping information stored in the template.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] IFCVersion
Full Name: Autodesk.Revit.DB.IFCVersion
Description: An enumerated type listing available IFC file versions into which a file may be exported.
Inherits: Enum

  Values:
    - Default = 0
    - IFCBCA = 8
    - IFC2x2 = 9
    - IFC2x3 = 10
    - IFCCOBIE = 17
    - IFC2x3CV2 = 21
    - IFC4 = 23
    - IFC2x3FM = 24
    - IFC4RV = 25
    - IFC4DTV = 26
    - IFC2x3BFM = 27
    - IFC4x3 = 29
    - IFCSG = 30

--------------------------------------------------------------------------------

[INTERFACE] IGetLocalPathForOpenCallback
Full Name: Autodesk.Revit.DB.IGetLocalPathForOpenCallback
Description: The interface used to provide custom support for the "Open (and Unload)" command for Revit Links obtained as external resources.
Remarks: Revit documents that are linked into host documents are read-only. If the user wishes to edit a linked Revit file they can use the "Open (and Unload)" command to unload the link, and automatically load it directly as a top-level, modifiable document (Revit files cannot be edited while they are being used as links). To support this operation for Revit links obtained as external resources, IExternalResourceServer authors should implement this callback. They should return a local path from where Revit can open the linked document for edit. Ideally, this should be a path that is different than the location from where it has been loaded as a link.Once the user opens a link as a top-level document, they will presumably make changes to it and save it. It is the responsibility of the server to upload whatever changes the user makes so that the version stored on the server remains the most current. Server providers can determine when changes have been made by the user to local file by watching for the DocumentSaved event.

  METHODS:
    string GetLocalPathForOpen(ExternalResourceReference desiredResource)
      Description: Implement this method to specify the local path from where a copy of a Revit link external resource can be opened for modification without interfering with its use as a link in other open documents.
      @desiredResource: The ExternalResourceReference that needs to be opened for modification by Revit.
      Returns: The local path from where Revit can open the linked file as its own top-level document.

--------------------------------------------------------------------------------

[CLASS] ImageBackgroundSettings
Full Name: Autodesk.Revit.DB.ImageBackgroundSettings
Description: Represents the rendering image background settings.
Inherits: BackgroundSettings

  PROPERTIES:
    BackgroundImageFit BackgroundImageFit { get; set; }
      Description: The background image fit type.
    string FilePath { get; set; }
      Description: File path of the image for the rendering background.
    double OffsetHeight { get; set; }
      Description: The vertical offset of the rendering image to the rendering region.
    double OffsetWidth { get; set; }
      Description: The horizontal offset of the rendering image to the rendering region.

--------------------------------------------------------------------------------

[CLASS] ImageExportOptions
Full Name: Autodesk.Revit.DB.ImageExportOptions
Description: This class defines options for exporting views and sheets as an image.
Implements: IDisposable

  CONSTRUCTORS:
    new ImageExportOptions()
      Description: Constructs a new instance of the options class used to produce images.

  PROPERTIES:
    ExportRange ExportRange { get; set; }
      Description: The export range defining which view(s) will be exported.
    string FilePath { get; set; }
      Description: The file name and path for the exported file.
    FitDirectionType FitDirection { get; set; }
      Description: The fit direction. Used only if ZoomType is FitToPage.
    ImageFileType HLRandWFViewsFileType { get; set; }
      Description: File type for exported HLR and wireframe views.
    ImageResolution ImageResolution { get; set; }
      Description: The image resolution in dots per inch.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int PixelSize { get; set; }
      Description: The pixel size of an image in one direction. Used only if ZoomType is FitToPage.
    ImageFileType ShadowViewsFileType { get; set; }
      Description: The file type for exported shadow views.
    bool ShouldCreateWebSite { get; set; }
      Description: Whether or not to create a web site with a page for each export. Used only when ExportRange is SetOfViews.
    string ViewName { get; set; }
      Description: The name of the view to be created.
    int Zoom { get; set; }
      Description: The value for Zoom (as a percentage). Used only when ZoomType is Zoom.
    ZoomFitType ZoomType { get; set; }
      Description: The zoom type, which defines how the image size is determined.

  METHODS:
    void Dispose()
    static string GetFileName(Document aDoc, ElementId dbViewId)
      Description: Gets the file name that will be produced when exporting a view to an image.
      @aDoc: The document that owns the view.
      @dbViewId: View which is to be exported as image.
      Returns: The generated exported image file name.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ElementId> GetViewsAndSheets()
      Description: Gets a list of views and sheets to be exported. Used only when ExportRange is SetOfViews.
      Returns: The ids of the views and sheets.
    static bool IsValidFileName(string filePath)
      Description: Verify if File name is valid
      @filePath: File path to be tested for valid file name
      Returns: True if File name is valid; false otherwise
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidForSaveToProjectAsImage(ImageExportOptions options, Document doc)
      Description: Verify if ImageExportOptions object is valid for calling saveToProjectAsImage
      @options: ImageExportOptions object to be validated
      @doc: Document for view name verification
      Returns: True if ImageExportOptions object is valid for calling saveToProjectAsImage; false otherwise
      Throws ArgumentNullException: A non-optional argument was null
    void SetViewsAndSheets(IList<ElementId> viewsAndSheets)
      Description: Sets a list of views and sheets to be exported. Used only when ExportRange is SetOfViews.
      @viewsAndSheets: The ids of the views and sheets.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ImageFileType
Full Name: Autodesk.Revit.DB.ImageFileType
Description: This enum is used to define exported file type.
Inherits: Enum

  Values:
    - BMP = 0
    - JPEGLossless = 1
    - JPEGMedium = 2
    - JPEGSmallest = 3
    - PNG = 4
    - TARGA = 5
    - TIFF = 6

--------------------------------------------------------------------------------

[CLASS] ImageInstance
Full Name: Autodesk.Revit.DB.ImageInstance
Description: An element that represents an instance of an image placed in a view
Inherits: Element

  PROPERTIES:
    bool CanHaveSnaps { get; }
      Description: When true the ImageInstance has snaps that can be enabled with the EnableSnaps property
    DrawLayer DrawLayer { get; set; }
      Description: The layer the ImageInstance will be drawn in.
    bool EnableSnaps { get; set; }
      Description: When true the ImageInstance will have its snaps enabled, but only if CanHaveSnaps is true
    double Height { get; set; }
      Description: The height of the ImageInstance.
    double HeightScale { get; set; }
      Description: The factor applied to the ImageType to calculate the Height of the ImageInstance.
    bool LockProportions { get; set; }
      Description: When true the proportion of Width to Height will be maintained
    double Width { get; set; }
      Description: The width of the ImageInstance.
    double WidthScale { get; set; }
      Description: The factor applied to the width of the ImageType to calculate the Width of the ImageInstance.

  METHODS:
    static ImageInstance Create(Document document, View view, ElementId imageTypeId, ImagePlacementOptions placementOptions)
      Description: Creates a new ImageInstance element placed in a view.
      @document: The document.
      @view: The view in which the image will be placed.
      @imageTypeId: The id of the ImageType element for this ImageInstance.
      @placementOptions: Options that specify where the ImageInstance should be placed.
      Returns: The new ImageInstance.
      Throws ArgumentException: The given view cannot contain ImageInstance elements -or- The given imageTypeId can not be used as a ImageType for ImageInstance elements -or- The given placementOptions specify a location that is more than 10 miles from the origin of the model.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    XYZ GetLocation(BoxPlacement placementPoint)
      Description: Returns the location of one of the points of the ImageInstance
      @placementPoint: The placementPoint specifies for which point of the ImageInstance the location should be returned.
      Returns: The location of the specified point
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool IsValidView(View view)
      Description: Check that the view is a valid view for ImageInstance elements
      @view: The view to validate
      Returns: True if the view can contain ImageInstance elements. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLocation(XYZ newLocation, BoxPlacement placementPoint)
      Description: Moves the ImageInstance to the specified location
      @newLocation: The new location of the specified point
      @placementPoint: The placementPoint specifies which point of the ImageInstance should be placed at the given location.
      Throws ArgumentException: The given newLocation is more than 10 miles from the origin of the model
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] ImagePlacementOptions
Full Name: Autodesk.Revit.DB.ImagePlacementOptions
Description: ImagePlacementOptions are used to describe where an ImageInstance should be placed in a view
Implements: IDisposable

  CONSTRUCTORS:
    new ImagePlacementOptions(XYZ location, BoxPlacement placementPoint)
      Description: Constructs a new ImagePlacementOptions for placing an ImageInstance
      @location: The location where the image will be placed
      @placementPoint: The point of the image that will be aligned to the location in the view
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ImagePlacementOptions()
      Description: Constructs a new ImagePlacementOptions that will place an ImageInstance with its center at the origin of the model

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Location { get; set; }
      Description: The location in the model where a point of the ImageInstance, determined by the PlacementPoint property, is going to be inserted.
    BoxPlacement PlacementPoint { get; set; }
      Description: Identifies which point of the ImageInstance will be aligned to the Location

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ImageResolution
Full Name: Autodesk.Revit.DB.ImageResolution
Description: This enum is used to define image resolution in order to calculate the image size.
Remarks: This is used only if the Zoom option for ZoomType is set.
Inherits: Enum

  Values:
    - DPI_72 = 0
    - DPI_150 = 1
    - DPI_300 = 2
    - DPI_600 = 3

--------------------------------------------------------------------------------

[CLASS] ImageType
Full Name: Autodesk.Revit.DB.ImageType
Description: Represents a type containing a raster based image. ImageInstance of this type can be placed in 2D views, sheets, and schedules.
Remarks: ImageType elements are created with the ImageType.Create(Document, ImageTypeOptions) method.ImageType elements can be loaded from the following file types: *.bmp, *.jpg, *.jpeg, *.png, *.tif, *.pdf.
Inherits: ElementType

  PROPERTIES:
    static ExternalResourceType ExternalResourceType { get; }
      Description: The type of external resources that represents images.
    double Height { get; }
      Description: The vertical size of the image
    int HeightInPixels { get; }
      Description: Number of pixels in the vertical direction of the image
    int PageNumber { get; }
      Description: The number of the page in a multi-page file, that was used to create the image in the ImageType.
    string Path { get; }
      Description: The path to the file from which the ImageType was loaded.
    PathType PathType { get; }
      Description: The path type that was used to refer to the file from which the ImageType was loaded.
    double Resolution { get; }
      Description: The size of the pixels in the image, expressed in dots-per-inch (dpi)
    ImageTypeSource Source { get; }
      Description: The source of the image in the ImageType.
    ImageTypeStatus Status { get; }
      Description: The status of the image
    double Width { get; }
      Description: The horizontal size of the image
    int WidthInPixels { get; }
      Description: Number of pixels in the horizontal direction of the image

  METHODS:
    bool CanReload()
      Description: Check whether the ImageType can be reloaded from file.
      Returns: True if the ImageType can be reloaded. False, otherwise.
    static ImageType Create(Document document, ImageTypeOptions options)
      Description: Creates a new ImageType element and loads the image into it.
      @document: The document.
      @options: Options that specify what image to load.
      Returns: The new ImageType.
      Throws ArgumentException: The image filename is an empty string. -or- The image file is not a supported image file type. -or- The image file is password protected. -or- The image file does not contain the requested page number. -or- The image file could not be read and may be corrupt. -or- An error occurred while handling the external resource corresponding to the image.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The image file does not exist.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    Bitmap GetImage()
      Description: Get the bitmap image stored in the image symbol.
      Returns: The bitmap image at the original loaded image size.
    void Reload()
      Description: Reloads the ImageType from the file found at the location specified by the Path property, using the same PageNumber and resolution.
      Throws FileNotFoundException: The file represented by Path does not exist.
      Throws InvalidOperationException: This ImageType was not loaded from a file. -or- The file represented by Path is not a supported image file type. -or- The image file represented by Path is a password protected PDF file. -or- The image file represented by Path does not contain the page specified by PageNumber. -or- The image file represented by Path could not be read and may be corrupt. -or- An error occurred while handling the external resource corresponding to the image.
      Throws ModificationForbiddenException: The document containing this ImageType is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this ImageType is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this ImageType has no open transaction.
    void ReloadFrom(ImageTypeOptions options)
      Description: Reloads the image in the ImageType from a new image file, and for a new PageNumber.
      @options: Options that specify what image to load.
      Throws ArgumentException: options.Path is an empty string. -or- The file represented by options.Path is not a supported image file type. -or- The image file represented by options.Path is a password protected PDF file. -or- The image file represented by options.Path does not contain the page specified by options.PageNumber. -or- The image file represented by options.Path could not be read and may be corrupt. -or- An error occurred while handling the external resource corresponding to the image.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The file represented by options.Path does not exist.
      Throws InvalidOperationException: This ImageType was not loaded from a file.
      Throws ModificationForbiddenException: The document containing this ImageType is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this ImageType is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this ImageType has no open transaction.
    void Unload()
      Description: Unload the linked image.
      Throws InvalidOperationException: This ImageType is not a link.
      Throws ModificationForbiddenException: The document containing this ImageType is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this ImageType is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this ImageType has no open transaction.

--------------------------------------------------------------------------------

[CLASS] ImageTypeOptions
Full Name: Autodesk.Revit.DB.ImageTypeOptions
Description: Represents the options used in ImageTypeOptions) and ImageTypeOptions) methods.
Remarks: ImageTypeOptions are used to describe how an ImageType should be created from an image file.ImageTypeOptions are used to specify the location of the image file to use for the image using either a string path or an ExternalResourceReference.ImageTypeOptions are used to specify if the file path should be stored as an absolute path, or a relative path. A relative path is relative to the location of the project file, unless the file is workshared, in which case the relative path is relative to the location of the central file. Note that the relative path option is only available if the project file has been saved.ImageTypeOptions are used to specify whether the image should be imported or linked. For imported images the image data is added to the Revit project file. For linked images the image data is reloaded everytime the project file is opened. Linked images are only available if they were reloaded successfully, while imported images are always available.For PDF files the ImageTypeOptions can be used to specify which page in the PDF file to use for the image. For raster based image files the page number must be 1 (the default).ImageTypeOptions can be used to specify the resolution (in pixels per inch) to use for the image. For PDF files the resolution is used to determine how many pixels to use when rasterizing the PDF page. Using a higher resolution will increase the number of pixels. This will add more detail, but it will also make rendering the image slower. In addition, it will likely increase the amount of data stored in the project when the image is imported.Raster based images have a fixed number of pixels. As a result, the resolution has no effect on the amount of detail or the amount of data that is stored. The resolution is only used to determine the size of image. Doubling the resolution will make the image appear half the size.When a file is accessed with the help of an external server, it is likely that a local cache of the file will be created temporarily. ImageTypeOptions may refer to the cached copy of the file internally. For this reason, ImageTypeOptions should be treated as a transient object whose purpose is to become an argument to ImageTypeOptions) or ImageTypeOptions). An application should not create an ImageTypeOptions object and hold onto it for a long time.
Implements: IDisposable

  CONSTRUCTORS:
    new ImageTypeOptions(ExternalResourceReference resourceReference, ImageTypeSource sourceType)
      Description: Constructs a new instance of the ImageTypeOptions object.
      @resourceReference: An external resource reference to an image.
      @sourceType: Specifies the image type source. Valid values are 'Import' and 'Link'.
      Throws ArgumentException: The ImageType source is not correct. Only Link or Import values are allowed.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ImageTypeOptions(string path, bool useRelativePath, ImageTypeSource sourceType)
      Description: Constructs a new instance of the ImageTypeOptions object.The provided string path must specify a local file. The path can be absolute or relative to the project's location.This constructor saves an additional setting that indicates whether the imagetype will be a link or an import.
      @path: The file path that specifies the image to be used.
      @useRelativePath: True if ImageType should use a relative path, false otherwise.
      @sourceType: Specifies the image type source. Valid values are 'Import' and 'Link'.
      Throws ArgumentException: The ImageType source is not correct. Only Link or Import values are allowed.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int PageNumber { get; set; }
      Description: The page in the file to be used for the image
    string Path { get; }
      Description: The path of the file that specifies the image to be used.
    double Resolution { get; set; }
      Description: The Resolution of the image is expressed in dots-per-inch and hence determines the size of a pixel in the image.
    ImageTypeSource SourceType { get; set; }
      Description: Indicates whether the image type is a link or an import.

  METHODS:
    void Dispose()
    bool IsValid(Document document)
      Description: If true the ImageTypeOptions can be used to create or reload an ImageType.
      @document: The document.
      Returns: Returns True if the options can be used to create or reload an ImageType. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetExternalResourceReference(ExternalResourceReference resourceReference)
      Description: Update the external resource reference to an image.
      @resourceReference: An external resource reference to an image.
      Throws ArgumentNullException: A non-optional argument was null
    void SetPath(string path, bool useRelativePath)
      Description: Update the path of the file that specifies the image to be used.The provided string path must specify a local file. The path can be absolute or relative to the project's location.Additionally, indicate whether the path used by ImageType should be absolute or relative.
      @path: The file path that specifies the image to be used.
      @useRelativePath: True if ImageType should use a relative path, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetPath(string path)
      Description: Update the path of the file that specifies the image to be used.The provided string path must specify a local file. The path can be absolute or relative to the project's location. ImageType will respectively use an absolute or relative path.
      @path: The file path that specifies the image to be used.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ImageTypeSource
Full Name: Autodesk.Revit.DB.ImageTypeSource
Description: The source of the data used to generate the image.
Inherits: Enum

  Values:
    - Link = 0
    - Import = 1
    - Internal = 2

--------------------------------------------------------------------------------

[ENUM] ImageTypeStatus
Full Name: Autodesk.Revit.DB.ImageTypeStatus
Description: Indicates the current state of the contents of the ImageType.
Inherits: Enum

  Values:
    - Unknown = 0
    - Loaded = 1
    - FailedToLoad = 2
    - Unloaded = 3
    - Imported = 4
    - Generated = 5

--------------------------------------------------------------------------------

[CLASS] ImageView
Full Name: Autodesk.Revit.DB.ImageView
Description: Class for ImageView views
Inherits: ViewDrafting

  PROPERTIES:
    ElementId ImageInstanceId { get; }
      Description: Id of the image in the view.

  METHODS:
    static ImageView Create(Document document, ImageTypeOptions options)
      Description: Create an ImageView containing an image imported from disk.
      @document: The document in which to create the view.
      @options: Options that specify what image to load.
      Returns: The newly created view.
      Throws ArgumentException: document is not a project document. -or- The image filename is an empty string. -or- The image file is not a supported image file type. -or- The image file is password protected. -or- The image file does not contain the requested page number. -or- The image file could not be read and may be corrupt. -or- An error occurred while handling the external resource corresponding to the image.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The image file does not exist.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[INTERFACE] IModelExportContext
Full Name: Autodesk.Revit.DB.IModelExportContext
Description: An interface that is used in custom export to export 3D views of a Revit model.
Remarks: An instance of a class that implements this interface is passed in as a parameter of the CustomExporter constructor. The interface methods are then called at times of drawing entities that are currently visible in the view being exported.With this type of export context used to perform a custom export, Revit will traverse the model and output the model's geometry as if in the process of regular displaying or exporting a 3D View. It means that any geometry which is visible in an open view (taking any current visibility setting applicable to the view) will be processed and output.
Implements: IExportContextBase, IExportContext

  METHODS:
    RenderNodeAction OnPoint(PointNode node)
      Description: This method is called when a Point is being output.
      @node: An output node that represents a Point.
      Returns: Return RenderNodeAction.Proceed if you wish to receive low-level geometry (line segments) for this point, or otherwise return RenderNodeAction.Skip.

--------------------------------------------------------------------------------

[ENUM] ImportColorMode
Full Name: Autodesk.Revit.DB.ImportColorMode
Description: An enumerated type listing how colors are handled in an import process.
Inherits: Enum

  Values:
    - Preserved = 0
    - Inverted = 1
    - BlackAndWhite = 2

--------------------------------------------------------------------------------

[ENUM] ImportExportFileFormat
Full Name: Autodesk.Revit.DB.ImportExportFileFormat
Description: Describes formats supported by import / export.
Inherits: Enum

  Values:
    - DWG = 1
    - DWF = 2
    - DWFX = 4
    - GBXML = 6
    - FBX = 7
    - Image = 8
    - DGN = 9
    - Civil3D = 10
    - Inventor = 11
    - DXF = 12
    - SAT = 13
    - IFC = 14
    - NWC = 15
    - PDF = 16
    - STL = 17
    - AXM = 19
    - OBJ = 20
    - STEP = 23
    - SKP = 24
    - Rhino = 25

--------------------------------------------------------------------------------

[CLASS] ImportIFCOptions
Full Name: Autodesk.Revit.DB.ImportIFCOptions
Description: Provides access to settings that control linking and opening IFC files.
Remarks: These settings are stored in the Revit.ini file. All documents in Revit instances which use this Revit.ini will follow these settings.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string LinkProcessor { get; set; }
      Description: Specifies the engine to use while doing a Link IFC operation.

  METHODS:
    void Dispose()
    static ImportIFCOptions GetImportIFCOptions()
      Description: Returns the current Revit instance's ImportIFCOptions.
      Returns: The ImportIFCOptions for the current Revit instance.

--------------------------------------------------------------------------------

[CLASS] ImportInstance
Full Name: Autodesk.Revit.DB.ImportInstance
Description: An element created during either import or link operation. It is an instance of CADLinkType.
Inherits: Instance

  PROPERTIES:
    bool IsLinked { get; }
      Description: Identifies whether this instance is a linked object rather than imported one.

  METHODS:
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, STEPImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of STEP link type from an external resource reference and loads the linked file.
      @document: The document in which to create the STEP link.
      @DBView: The view into which the STEP link will be created.
      @resourceReference: The external resource reference describing the source of the STEP link.
      @options: Various import options applicable to the STEP format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the STEP link. It contains the ElementId of the new created STEP link type.
      Returns: The new instance of STEP link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The STEP Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, ImportOptions3DM options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of 3DM link type from an external resource reference and loads the linked file.
      @document: The document in which to create the 3DM link.
      @DBView: The view into which the 3DM link will be created.
      @resourceReference: The external resource reference describing the source of the 3DM link.
      @options: Various import options applicable to the 3DM format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the 3DM link. It contains the ElementId of the new created 3DM link type.
      Returns: The new instance of 3DM link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The 3DM Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, STLImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of STL link type from an external resource reference and loads the linked file.
      @document: The document in which to create the STL link.
      @DBView: The view into which the STL link will be created.
      @resourceReference: The external resource reference describing the source of the STL link.
      @options: Various import options applicable to the STL format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the STL link. It contains the ElementId of the new created STL link type.
      Returns: The new instance of STL link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The STL Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, SKPImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of SKP link type from an external resource reference and loads the linked file.
      @document: The document in which to create the SKP link.
      @DBView: The view into which the SKP link will be created.
      @resourceReference: The external resource reference describing the source of the SKP link.
      @options: Various import options applicable to the SKP format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the SKP link. It contains the ElementId of the new created SKP link type.
      Returns: The new instance of SKP link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The SKP Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, SATImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of SAT link type from an external resource reference and loads the linked file.
      @document: The document in which to create the SAT link.
      @DBView: The view into which the SAT link will be created.
      @resourceReference: The external resource reference describing the source of the DGN link.
      @options: Various import options applicable to the SAT format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the SAT link. It contains the ElementId of the new created SAT link type.
      Returns: The new instance of SAT link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The SAT Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, OBJImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of OBJ link type from an external resource reference and loads the linked file.
      @document: The document in which to create the OBJ link.
      @DBView: The view into which the OBJ link will be created.
      @resourceReference: The external resource reference describing the source of the OBJ link.
      @options: Various import options applicable to the OBJ format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the OBJ link. It contains the ElementId of the new created OBJ link type.
      Returns: The new instance of OBJ link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The OBJ Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, DGNImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of DGN link type from an external resource reference and loads the linked file.
      @document: The document in which to create the DGN link.
      @DBView: The view into which the DGN link will be created.
      @resourceReference: The external resource reference describing the source of the DGN link.
      @options: Various import options applicable to the DGN format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the DGN link. It contains the ElementId of the new created DGN link type.
      Returns: The new instance of DGN link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DGN Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, ElementId typeId, View DBView)
      Description: Creates a new instance of an existing DWG link type.
      @document: The document in which to create the new instacne of DWG link type.
      @typeId: The element id of the existing DWG link type.
      @DBView: The view into which the new instance of DWG link type will be created.
      Returns: The new instance of the given DWG link type.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- The view is not printable. -or- The element id is not of a valid CADLinkType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, DWGImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of DWG link type from an external resource reference and loads the linked file.
      @document: The document in which to create the DWG link.
      @DBView: The view into which the DWG link will be created.
      @resourceReference: The external resource reference describing the source of the DWG link.
      @options: Various import options applicable to the DWG format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the DWG link. It contains the ElementId of the new created DWG link type.
      Returns: The new instance of DWG link type created.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range. -or- The scale is not valid as a CustomScale for use during import. -or- The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DWG Import/Link module is not available in the installed Revit.
    static ImportInstance Create(Document document, View DBView, string path, DWGImportOptions options, out LinkLoadResult linkLoadResult)
      Description: Creates a new instance of DWG or DXF link type from a file path and loads the linked file.
      @document: The document in which to create the DWG or DXF link.
      @DBView: The view into which the DWG or DXF link will be created.
      @path: The full path of the DWG or DXF file to link. The path must exist and must be a valid DWG or DXF file.
      @options: Various import options applicable to the DWG format. If , all options will be set to their respective default values.
      @linkLoadResult: An object containing the results of creating and loading the DWG or DXF link. It contains the ElementId of the new created DWG or DXF link type.
      Returns: The new instance of DWG or DXF link type.
      Throws ArgumentException: document is not a project document. -or- document is in an edit mode. -or- Import is temporarily disabled. -or- The view is not printable. -or- NullOrEmpty -or- Not a valid file for DWG import (.dwg and .dxf files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- One or more strings describing layer selection is invalid or empty. -or- The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range. -or- The scale is not valid as a CustomScale for use during import.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given path does not exist.
      Throws InvalidOperationException: Place by shared, and the host model and the link do not share the same coordinate system. Or place by shared, and the shared coordinates of the host model do not match the GIS coordinate system of the link.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DWG Import/Link module is not available in the installed Revit.
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the import instance in a family document.
      Returns: A copy of visibility settings for the import instance in a family document.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the import instance in a family document.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws InvalidOperationException: Thrown when regeneration failed, or the import instance is in a project document.

--------------------------------------------------------------------------------

[CLASS] ImportOptions3DM
Full Name: Autodesk.Revit.DB.ImportOptions3DM
Description: The import options used to import 3DM format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new ImportOptions3DM(ImportOptions3DM option)
      Description: Constructs a new instance of ImportOptions3DM as a copy of the provided import options.
      @option: The 3DM import options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new ImportOptions3DM()
      Description: Constructs a new instance of ImportOptions3DM with default values of all properties.

--------------------------------------------------------------------------------

[ENUM] ImportPlacement
Full Name: Autodesk.Revit.DB.ImportPlacement
Description: An enumerated type listing possible placement modes for imported drawings.
Inherits: Enum

  Values:
    - Site = 0
    - Origin = 1
    - Centered = 2
    - Shared = 3

--------------------------------------------------------------------------------

[ENUM] ImportUnit
Full Name: Autodesk.Revit.DB.ImportUnit
Description: An enumerated type listing possible target units for CAD Import.
Inherits: Enum

  Values:
    - Default = 0
    - Foot = 1
    - Inch = 2
    - Meter = 3
    - Decimeter = 4
    - Centimeter = 5
    - Millimeter = 6
    - Custom = 7
    - USSurveyFoot = 8

--------------------------------------------------------------------------------

[INTERFACE] INavisworksExporter
Full Name: Autodesk.Revit.DB.INavisworksExporter
Description: The interface used to implement a Navisworks exporter.
Remarks: Implement this interface and register an instance of the derived class with the Navisworks external service.
Implements: IExternalServer

  METHODS:
    void Export(Document document, string folder, string name, NavisworksExportOptions options)
      Description: The method that Revit will invoke to perform an export to Navisworks.
      @document: The document to export.
      @folder: The folder path.
      @name: The file name.
      @options: The export options.
    bool ValidateExportOptions(Document document, string folder, string name, NavisworksExportOptions options, out string exceptionMessage)
      Description: Determines if the inputs are valid, and returns an error message if not.
      @document: The document to export.
      @folder: The folder path.
      @name: The file name.
      @options: The export options.
      @exceptionMessage: The message to show in the exception thrown. This is not an end-user visible message, it is a developer message, and does not have to be localized. Ignored if the function returns true.
      Returns: True if the options are valid, false otherwise.

--------------------------------------------------------------------------------

[CLASS] InCanvasControlData
Full Name: Autodesk.Revit.DB.InCanvasControlData
Description: Represents a collection of data which is used by TemporaryGraphicsManager to create and update an in-canvas control.
Remarks: So far, only bitmap file is supported for ImagePath. The rendered image is the same size in pixel dimensions as the original one. To get a better result, the caller should prepare the image with proper size, for exmaple: 32x32 or 64x64 in pixels, before use. To achive a "transparent" backgound color effect over the provided bitmap, the bitmap should use color RGB(0, 128, 128) as its background and it will be cleared during rendering by Revit.
Implements: IDisposable

  CONSTRUCTORS:
    new InCanvasControlData(string imagePath, XYZ position)
      Description: Constructs an InCanvasControlData with specific values assigned.
      @imagePath: File path with the image to be used. This must be an absolute path to a location on disk.
      @position: The position to be used.
      Throws ArgumentException: The file format specified by imagePath is an unsupported format - only *.bmp files are supported. -or- The file path specified by imagePath is not absolute.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The file specified by imagePath doesn't exist.
    new InCanvasControlData(string imagePath)
      Description: Constructs an InCanvasControlData with specific values assigned.
      @imagePath: File path with the image to be used. This must be an absolute path to a location on disk.
      Throws ArgumentException: The file format specified by imagePath is an unsupported format - only *.bmp files are supported. -or- The file path specified by imagePath is not absolute.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The file specified by imagePath doesn't exist.

  PROPERTIES:
    string ImagePath { get; set; }
      Description: The path to the image file to be used. This must be an absolute path to a location on disk.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Position { get; set; }
      Description: The position of the in-canvas control in model coordinates.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] IndependentTag
Full Name: Autodesk.Revit.DB.IndependentTag
Description: Represents tag annotations in Revit. getBBoxCorers in MultipleAlignmentHelper needs access to some protected members.
Remarks: IndependentTag represents single-category tags, multi-category tags, material tags, and zone tags. IndependentTag is also the base class for other annotations like keynote tags and span symbols. Room, area and space tags are not derived from IndependentTag. Autodesk::Revit::DB::SpatialElementTag for more information.
Inherits: Element

  PROPERTIES:
    bool HasLeader { get; set; }
      Description: Identifies if a tag has at least one visible leader, or if all leaders are hidden.
    bool IsMaterialTag { get; }
      Description: Identifies if it is a material tag or not.
    bool IsMulticategoryTag { get; }
      Description: Identifies if it is a multi-category tag or not.
    bool IsOrphaned { get; }
      Description: Identifies if the tag is orphaned or not.
    LeaderEndCondition LeaderEndCondition { get; set; }
      Description: The leader end condition of the tag, such as if the end of the leader is attached to the host or free floating.
    LeadersPresentationMode LeadersPresentationMode { get; set; }
      Description: Identifies the Presentation Mode that is applied to tag leaders.
    bool MergeElbows { get; set; }
      Description: Identifies if the leaders' elbows are merged or not. If they are are merged, all elbows are in the same point and they move together.
    bool MultiLeader { get; }
      Description: Returns if the tag if referencing multiple elements and/or sub-elements.
    ElementId MultiReferenceAnnotationId { get; }
      Description: The multi-reference annotation which owns this tag.
    double RotationAngle { get; set; }
      Description: The rotation angle of the tag relative to its view
    XYZ TagHeadPosition { get; set; }
      Description: The position of the head of tag in model coordinates.
    TagOrientation TagOrientation { get; set; }
      Description: The tag orientation of the tag's head, such as horizontal or vertical.
    string TagText { get; }
      Description: The text associated with the tag. If there are several strings assiciated with the tag, the strings will be returned concatenated.

  METHODS:
    void AddReferences(IList<Reference> referencesToTag)
      Description: Adds the provided list of references to the tag's list of references.
      @referencesToTag: References to be tagged.
      Throws ArgumentException: The operation failed. Please verify that the references are all taggable and that they are not already tagged. -or- This type of tag does not support multiple references.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior. -or- Modifying tag references for MRA owned tag from API is not allowed.
    bool CanLeaderEndConditionBeAssigned(LeaderEndCondition leaderEndCondition)
      Description: Checks whether the LeaderEndCondition can be changed.
      @leaderEndCondition: The leader end condition to check.
      Returns: True if the leader end condition of the tag can be assigned, or false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static IndependentTag Create(Document document, ElementId symId, ElementId ownerDBViewId, Reference referenceToTag, bool addLeader, TagOrientation tagOrientation, XYZ pnt)
      Description: Places a tag on an element or subelement.
      @document: The document to which the tag will be added.
      @symId: The id for the FamilySymbol which determines the tag's type.
      @ownerDBViewId: The view in which the tag will be visible.
      @referenceToTag: The host reference of the tag. The reference can be to an element or subelement in a local or linked document.
      @addLeader: When true, the tag will be created with a straight leader with an attached end.
      @tagOrientation: The orientation of the tag's head.
      @pnt: For tags without leaders, this point is the position of the tag head. For tags with leaders, this point is the end point of the leader, and a leader of default length will be created from this point to the tag head.
      Returns: If successful the new tag is returned.
      Throws ArgumentException: The ElementId ownerDBViewId does not correspond to a View. -or- The ElementId ownerDBViewId is a view template. -or- The ElementId ownerDBViewId is a perspective view. -or- The 3D view ownerDBViewId is not locked. -or- The ElementId symId does not correspond to a FamilySymbol. -or- The reference can not be tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InternalException: Tag creation failed.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static IndependentTag Create(Document document, ElementId ownerDBViewId, Reference referenceToTag, bool addLeader, TagMode tagMode, TagOrientation tagOrientation, XYZ pnt)
      Description: Places a tag on an element or subelement.
      @document: The document to which the tag will be added.
      @ownerDBViewId: The view in which the tag will be visible.
      @referenceToTag: The host reference of the tag. The reference can be to an element or subelement in a local or linked document.
      @addLeader: When true, the tag will be created with a straight leader with an attached end.
      @tagMode: This argument determines the type of tag that will be created. Tag by category, multi-category tag, and material tag are allowed.
      @tagOrientation: The orientation of the tag's head.
      @pnt: For tags without leaders, this point is the position of the tag head. For tags with leaders, this point is the end point of the leader, and a leader of default length will be created from this point to the tag head.
      Returns: If successful the new tag is returned.
      Throws ArgumentException: The ElementId ownerDBViewId does not correspond to a View. -or- The ElementId ownerDBViewId is a view template. -or- The ElementId ownerDBViewId is a perspective view. -or- The 3D view ownerDBViewId is not locked. -or- The reference can not be tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InternalException: Tag creation failed.
      Throws InvalidOperationException: There is no loaded tag type that can be used when tagging referenceToTag with tagMode.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    XYZ GetLeaderElbow(Reference referenceTagged)
      Description: Returns the position of the elbow of the tag's leader that points to specified reference. Position of leader's elbow.
      @referenceTagged: The reference which is tagged.
      Throws ArgumentException: The specified reference does not have a leader or its leader is straight. -or- The specified reference is not currently tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior.
    XYZ GetLeaderEnd(Reference referenceTagged)
      Description: Returns the end position of the tag's leader that points to specified reference.
      @referenceTagged: The reference which is tagged.
      Returns: Point representing the end position of tag's leader
      Throws ArgumentException: There is no leader end because the tag does not use a free end leader or the leader is not visible. -or- The specified reference is not currently tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior.
    ICollection<LinkElementId> GetTaggedElementIds()
      Description: Returns a set of LinkElementId for all tagged elements, if any. A LinkElementId will be provided for each subelement that is being referenced by the tag.
      Returns: Set of all the tagged elements ids for both local and linked files.
    ISet<ElementId> GetTaggedLocalElementIds()
      Description: Returns a set of IDs for all tagged local elements, if any. A local element ID will be provided for each subelement that is being referenced by the tag. Set of all the element ids in the local file. For each subelement a local element id will be provided.
    ICollection<Element> GetTaggedLocalElements()
      Description: Get the tagged local elements, if any. An Element will be provided for each subelement that is being referenced by the tag.
      Returns: All tagged elements from the local document, or for orphan tags and tagged elements in linked documents.
    IList<Reference> GetTaggedReferences()
      Description: Get the host references of the tag. An array of all the tagged references.
    bool HasLeaderElbow(Reference referenceTagged)
      Description: Whether the tag's leader that points to the reference has an elbow point or not.
      Returns: True if the reference has a leader with an elbow point, or false otherwise.
      Throws ArgumentException: The specified reference is not currently tagged. -or- The leader for the tagged reference isn't visible.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior.
    bool HasTagBehavior()
      Description: Checks if the IndependentTag has a tag behavior.
    bool HasTagText()
      Description: Checks if the IndependentTag has a valid tag text.
      Returns: True if the IndependentTag object has a valid tag text.
    bool IsLeaderVisible(Reference referenceTagged)
      Description: Returns if leader that points to specified reference is visible or not.
      @referenceTagged: The reference which is tagged.
      Returns: Returns true if leader that points to specified reference is visible, false otherwise.
      Throws ArgumentException: The specified reference is not currently tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior.
    bool IsTaggedOnSubelement()
      Description: Returns true if the any of the tagged references is a subelement.
    void RemoveReferences(IList<Reference> referencesToRemove)
      Description: Removes the provided list of references from the tag's list of references.
      @referencesToRemove: References to be removed from tag.
      Throws ArgumentException: The operation failed. Please verify that the references are all tagged before removing them.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior. -or- Modifying tag references for MRA owned tag from API is not allowed.
    void SetIsLeaderVisible(Reference referenceTagged, bool visible)
      Description: Set tag's leader that points to specified reference to be visible or not. This option can be set only if the LeadersPresentationMode is ShowSpecificLeaders.
      @referenceTagged: The reference which is tagged.
      @visible: True for showing the leader, false to hide it.
      Throws ArgumentException: The specified reference is not currently tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior. -or- For this tag leaders are not allowed. -or- The LeadersPresentationMode should be set to ShowSpecificLeaders.
    void SetLeaderElbow(Reference referenceTagged, XYZ elbowPosition)
      Description: Set the position of the elbow of the tag's leader that points to specified reference. If this tag is a multileader tag and the elbows are merged, the input position will be set to all leaders.
      @referenceTagged: The reference which is tagged.
      @elbowPosition: The position of the elbow.
      Throws ArgumentException: The specified reference is not currently tagged. -or- The leader for the tagged reference isn't visible.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior. -or- For this tag leaders are not allowed.
    void SetLeaderEnd(Reference referenceTagged, XYZ pointEnd)
      Description: Set the end position of the tag's leader that points to specified reference.
      @referenceTagged: The reference which is tagged.
      @pointEnd: Point representing the end position of tag's leader
      Throws ArgumentException: There is no leader end because the tag does not use a free end leader or the leader is not visible. -or- The specified reference is not currently tagged.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The IndependentTag object does not have a tag behavior. -or- For this tag leaders are not allowed.

--------------------------------------------------------------------------------

[CLASS] InsertableObject
Full Name: Autodesk.Revit.DB.InsertableObject
Description: A base class you all types that are insertable.
Inherits: ElementType

--------------------------------------------------------------------------------

[ENUM] InsertOrientation
Full Name: Autodesk.Revit.DB.InsertOrientation
Description: The allowed values for the INSERT_ORIENTATION parameter.
Inherits: Enum

  Values:
    - Vertical = 0
    - Slanted = 1
    - Exterior = 2
    - Interior = 3

--------------------------------------------------------------------------------

[CLASS] InSessionPrintSetting
Full Name: Autodesk.Revit.DB.InSessionPrintSetting
Description: Represents the in-session Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.
Remarks: The in-session PrintSetting can't be stored in document.
Implements: IPrintSetting, IDisposable

  PROPERTIES:
    PrintParameters PrintParameters { get; }
      Description: Returns the Parameters of Print Setup.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] InSessionViewSheetSet
Full Name: Autodesk.Revit.DB.InSessionViewSheetSet
Description: Represents the in-session ViewSheetSet.
Remarks: The in-session ViewSheetSet can't be stored in document.
Implements: IViewSheetSet, IDisposable

  PROPERTIES:
    bool IsAutomatic { get; set; }
      Description: Automatic order or manual order.
    IReadOnlyList<View> OrderedViewList { get; set; }
      Description: Ordered views.
    ElementId SheetOrganizationId { get; set; }
      Description: ElementId to the BrowserOrganization for sheets.
    ElementId ViewOrganizationId { get; set; }
      Description: ElementId to the BrowserOrganization for non-sheet views.
    ViewSet Views { get; set; }
      Description: The views.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] Instance
Full Name: Autodesk.Revit.DB.Instance
Description: The base class for all instance objects.
Inherits: Element

  METHODS:
    Transform GetTotalTransform()
      Description: Gets the total transform, which includes the true north transform for instances like import instances.
      Returns: The calculated total transform.
    Transform GetTransform()
      Description: Gets the transform of the instance.
      Returns: The inherent transform.

--------------------------------------------------------------------------------

[CLASS] InstanceBinding
Full Name: Autodesk.Revit.DB.InstanceBinding
Description: The InstanceBinding object is used to signify a binding between a parameter definition and a parameter on each instance of an element, such as a wall.
Remarks: Once bound the parameter will appear on all instance of the element and changing the parameter on any one single instance will not change the value on any other instance.
Inherits: ElementBinding

  CONSTRUCTORS:
    new InstanceBinding(CategorySet categories)
      Description: Constructs an instance binding with the set of categories passed.
    new InstanceBinding()
      Description: Constructs an empty instance binding.

--------------------------------------------------------------------------------

[CLASS] InstanceNode
Full Name: Autodesk.Revit.DB.InstanceNode
Description: An output node that represents an instance of a geometry. It can be an instance of FamilyInstance, or it can be and instance of a part of symbol's geometry.
Remarks: See also: InstanceNode). The SymbolGeometryId. contains the data for comparing if two InstanceNode points to the same geometry.
Inherits: GroupNode

  METHODS:
    SymbolGeometryId GetSymbolGeometryId()
      Description: Gets the SymbolGeometryId associated with the node.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] InstanceVoidCutUtils
Full Name: Autodesk.Revit.DB.InstanceVoidCutUtils
Description: Utilities for cutting elements by unattached voids in family instances.

  METHODS:
    static void AddInstanceVoidCut(Document document, Element element, Element cuttingInstance)
      Description: Add a cut to an element using the unattached voids inside a cutting instance.
      @document: The document containing the two elements
      @element: The element to be cut
      @cuttingInstance: The cutting family instance
      Throws ArgumentException: The element cannot be cut with a void instance. -or- The element is not a family instance with an unattached void that can cut.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: Failed to cut element with the instances
    static bool CanBeCutWithVoid(Element element)
      Description: Indicates if the element can be cut by an instance with unattached voids.
      @element: The element to be cut
      Returns: Returns true if the element can be cut by an instance with unattached voids.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetCuttingVoidInstances(Element element)
      Description: Return ids of the instances with unattached voids cutting the element.
      @element: The element being cut
      Returns: Ids of instances with unattached voids that cut this element
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetElementsBeingCut(Element cuttingInstance)
      Description: Return ids of the elements being cut by the instance
      @cuttingInstance: The cutting family instance
      Returns: Ids of elements being cut by cuttingInstance
      Throws ArgumentNullException: A non-optional argument was null
    static bool InstanceVoidCutExists(Element element, Element cuttingInstance)
      Description: Check whether the instance is cutting the element
      @element: The element being cut
      @cuttingInstance: The cutting family instance
      Returns: Returns true if the instance is cutting the element.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsVoidInstanceCuttingElement(Element element)
      Description: Indicates if the element is a family instance with unattached voids that can cut other elements.
      @element: The cutting family instance
      Returns: Returns true if the element is a family instance with unattached voids that can cut other elements.
      Throws ArgumentNullException: A non-optional argument was null
    static void RemoveInstanceVoidCut(Document document, Element element, Element cuttingInstance)
      Description: Remove a cut applied to the element by a cutting instance with unattached voids.
      @document: The document containing the two elements
      @element: The element being cut
      @cuttingInstance: The cutting family instance
      Throws ArgumentException: No instance void cut exists between the two elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to remove the instance cut from the element

--------------------------------------------------------------------------------

[CLASS] InsulationLiningBase
Full Name: Autodesk.Revit.DB.InsulationLiningBase
Description: Acts as the base class for duct insulation, pipe insulation and duct lining elements.
Inherits: MEPCurve

  PROPERTIES:
    ElementId HostElementId { get; }
      Description: The id of the host element for the insulation or lining element.
    double Thickness { get; set; }
      Description: Thickness of the insulation or lining element.

  METHODS:
    static ICollection<ElementId> GetInsulationIds(Document document, ElementId elemId)
      Description: Returns the ids of the insulation elements associated to a given element.
      @document: The document.
      @elemId: The element.
      Returns: A collection of the ids of the insulation elements.
      Throws ArgumentException: This id does not represent a valid host for insulation.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetLiningIds(Document document, ElementId elemId)
      Description: Returns the ids of the lining elements associated to a given element.
      @document: The document.
      @elemId: The element.
      Returns: A collection of the ids of the lining elements.
      Throws ArgumentException: This id does not represent a duct, fitting, or accessory element.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidThickness(double thickness)
      Description: Identifies if the given thickness value is valid for assignment to insulation or lining elements.
      @thickness: Thickness of the insulation and lining elements.
      Returns: True if the thickness is valid, false otherwise.

--------------------------------------------------------------------------------

[CLASS] IntegerParameterValue
Full Name: Autodesk.Revit.DB.IntegerParameterValue
Description: A class that holds an Integer value of a parameter element.
Inherits: ParameterValue

  CONSTRUCTORS:
    new IntegerParameterValue(int value)
      Description: Value constructor
    new IntegerParameterValue()
      Description: Default constructor

  PROPERTIES:
    int Value { get; set; }
      Description: The stored value

--------------------------------------------------------------------------------

[CLASS] IntegerRange
Full Name: Autodesk.Revit.DB.IntegerRange
Description: A class to define a range of a sequence of consecutive integer numbers
Implements: IDisposable

  PROPERTIES:
    int High { get; }
      Description: The upper limit of the range
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Low { get; }
      Description: The lower limit of the range

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] InternalDefinition
Full Name: Autodesk.Revit.DB.InternalDefinition
Description: This object represents a parameter definition in an Autodesk Revit model.
Inherits: Definition
Implements: IDisposable

  PROPERTIES:
    BuiltInParameter BuiltInParameter { get; }
      Description: Tests whether this definition identifies a built-in parameter or not.
    ElementId Id { get; }
      Description: The id of the parameter.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The user-visible name for the parameter.
    bool VariesAcrossGroups { get; }
      Description: Whether or not the parameter values can vary across group members.
    bool Visible { get; }
      Description: Indicates if the parameter is visible in the Autodesk Revit user interface.

  METHODS:
    void Dispose()
    ForgeTypeId GetGroupTypeId()
      Description: Gets the identifier of the built-in parameter group to which the parameter defined by this definition belongs.
    ForgeTypeId GetParameterTypeId()
      Description: Tests whether this definition identifies a built-in parameter or not.
    ForgeTypeId GetTypeId()
      Description: Gets the identifier of the parameter.
    ICollection<ElementId> SetAllowVaryBetweenGroups(Document document, bool allowVaryBetweenGroups)
      Description: Whether or not the parameter values can vary across group members.
      @document: The document of this parameter.
      @allowVaryBetweenGroups: Whether this parameter should be allowed to vary between groups.
      Returns: The ids of elements that were updated to align the values between groups.
      Throws ArgumentException: This parameter does not support the specified value of allowVaryBetweenGroups. -or- document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void SetGroupTypeId(ForgeTypeId groupTypeId)
      Description: Sets the built-in parameter group to which the parameter defined by this definition belongs.
      @groupTypeId: Identifier of the built-in parameter group.

--------------------------------------------------------------------------------

[CLASS] InternalDefinitions
Full Name: Autodesk.Revit.DB.InternalDefinitions
Description: This object blocks attempts to create new internal definitions as they are not permitted.
Inherits: Definitions

--------------------------------------------------------------------------------

[CLASS] InternalOrigin
Full Name: Autodesk.Revit.DB.InternalOrigin
Description: A class representing the origin of internal coordinate system. Each Revit project contains one InternalOrigin.
Remarks: The internal origin cannot be selected (e.g. as a reference) nor can it be modified.
Inherits: Element

  PROPERTIES:
    XYZ Position { get; }
      Description: The position of the InternalOrigin.
    XYZ SharedPosition { get; }
      Description: The position of the InternalOrigin relative to the active ProjectLocation set for the document.

  METHODS:
    static InternalOrigin Get(Document document)
      Description: Gets the internal origin for the document.
      @document: Revit document from which to get the internal origin.
      Returns: The internal origin of the document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] IntersectingElementData
Full Name: Autodesk.Revit.DB.IntersectingElementData
Description: Stores information of an element that intersects with another element
Implements: IDisposable

  PROPERTIES:
    ElementId IntersectedElementId { get; }
      Description: Id of the intersected element.
    ElementId IntersectingElementId { get; }
      Description: Id of the intersecting element.
    IntersectionType IntersectionType { get; }
      Description: The intersection type.
    double IntersectionVolume { get; }
      Description: The intersection volume.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] IntersectionResult
Full Name: Autodesk.Revit.DB.IntersectionResult
Description: This class captures results of intersecting geometric entities. "Intersecting" is meant in generalized sense, so the same class will be used for projection, containment, etc. Refer to the documentation of the method providing the result for the precise meaning of properties.
Inherits: APIObject

  CONSTRUCTORS:
    new IntersectionResult()

  PROPERTIES:
    double Distance { get; set; }
      Description: Distance from the original object to located point.
    Edge EdgeObject { get; set; }
      Description: Edge of the face close to the point of intersection.
    double EdgeParameter { get; set; }
      Description: Parameter of a point on the edge closest to the point of intersection.
    double Parameter { get; set; }
      Description: 1d parameter of the point of intersection.
    UV UVPoint { get; set; }
      Description: 2d (or two 1d) parameters of the point of intersection.
    XYZ XYZPoint { get; set; }
      Description: Point of intersection in local 3d coordinates.

--------------------------------------------------------------------------------

[CLASS] IntersectionResultArray
Full Name: Autodesk.Revit.DB.IntersectionResultArray
Description: An array that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new IntersectionResultArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    IntersectionResult Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(IntersectionResult item)
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    IntersectionResultArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(IntersectionResult item, int index)
    IntersectionResultArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] IntersectionResultArrayIterator
Full Name: Autodesk.Revit.DB.IntersectionResultArrayIterator
Description: An iterator to a array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new IntersectionResultArrayIterator()
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

[ENUM] IntersectionType
Full Name: Autodesk.Revit.DB.IntersectionType
Description: Intersection type.
Inherits: Enum

  Values:
    - Cut = 0
    - Excavate = 1

--------------------------------------------------------------------------------

[INTERFACE] IOnLocalLinkSharedCoordinatesSavedCallback
Full Name: Autodesk.Revit.DB.IOnLocalLinkSharedCoordinatesSavedCallback
Description: A callback for notifying an IExternalResourceServer that shared coordinates changes have been saved back to one of the Revit or DWG links provided by that server.
Remarks: Revit will call OnLocalLinkSharedCoordinatesSaved whenever shared coordinates changes are saved to a linked document which is provided by an external server. This is a notification to the server provider so they can copy the updated link back up to their server.

  METHODS:
    void OnLocalLinkSharedCoordinatesSaved(ExternalResourceReference changedResource)
      Description: Revit will call this method whenever shared coordinates changes are saved to a linked document provided by an IExternalResourceServer. This call is a notification to the server provider that one of their Revit or DWG links has changed locally, and they should upload the new version back to their server.
      @changedResource: The ExternalResourceReference whose shared coordinates have been saved.

--------------------------------------------------------------------------------

[INTERFACE] IOpenFromCloudCallback
Full Name: Autodesk.Revit.DB.IOpenFromCloudCallback
Description: An interface that may be used to control Revit's behavior when opening a cloud model.

  METHODS:
    OpenConflictResult OnOpenConflict(OpenConflictScenario scenario)
      Description: A method called when the conflict is happen during the model opening.
      @scenario: The scenario of the conflict.
      Returns: Returns the result to indicate whether to keep the unsynchronized change, or open the latest version or cancel the open action.

--------------------------------------------------------------------------------

[INTERFACE] IPerformanceAdviserRule
Full Name: Autodesk.Revit.DB.IPerformanceAdviserRule
Description: Base class to derive specific performance adviser rules from.

  METHODS:
    void ExecuteElementCheck(Document document, Element element)
      Description: Invoked by performance advisor for each element to be checked.
      @document: Document for which performance problems are being checked.
      @element: The Element being checked for performance problems.
    void FinalizeCheck(Document document)
      Description: Invoked by performance advisor once in the end of the check.
      @document: Document for which performance problems are being checked.
    string GetDescription()
      Description: Retrieves the description of the rule.
      Returns: The description of the rule.
    ElementFilter GetElementFilter(Document document)
      Description: Retrieves a filter to restrict elements to be checked.
      @document: Document for which performance problems are being checked.
      Returns: The filter to restrict elements to be checked.
    string GetName()
      Description: Retrieves the name of the rule.
      Returns: The name of the rule.
    void InitCheck(Document document)
      Description: Invoked by performance advisor once in the beginning of the check. If rule checks document as a whole, the check can be performed in this method.
      @document: Document for which performance problems are being checked.
    bool WillCheckElements()
      Description: Reports if rule needs to be executed on individual elements.
      Returns: True if rule needs to be executed on individual elements.

--------------------------------------------------------------------------------

[INTERFACE] IPhotoRenderContext
Full Name: Autodesk.Revit.DB.IPhotoRenderContext
Description: An interface that is used in custom export to render 3D views of a Revit model.
Remarks: An instance of a class that implements this interface is passed in as a parameter of the CustomExporter constructor. The interface methods are then called at times of rendering entities that are currently visible in the view being rendered.With this type of export context used to perform a custom export, Revit will traverse the model and output the model's geometry as if processing the Render command invoked via the UI. It means that only such elements that have actual geometry and are suitable to appear in a rendered view will be processed and output.
Implements: IExportContext

--------------------------------------------------------------------------------

[INTERFACE] IPrintSetting
Full Name: Autodesk.Revit.DB.IPrintSetting
Description: An interface which represents the Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.

  PROPERTIES:
    PrintParameters PrintParameters { get; }
      Description: Returns the Parameters of Print Setup.

--------------------------------------------------------------------------------

[INTERFACE] ISaveSharedCoordinatesCallback
Full Name: Autodesk.Revit.DB.ISaveSharedCoordinatesCallback
Description: An interface that may be used to control Revit when trying to unload or reload a Revit link with changes in shared coordinates.

  METHODS:
    SaveModifiedLinksOptions GetSaveModifiedLinksOption(RevitLinkType link)
      Description: Determines whether Revit should save the link, not save the link, or discard shared positioning entirely.
      @link: The Revit link which has modified shared coordinates.
      Returns: The options when saving a linked file which has been modified in-memory by shared coordinates operations.

--------------------------------------------------------------------------------

[INTERFACE] ISaveSharedCoordinatesCallbackForUnloadLocally
Full Name: Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally
Description: An interface that is used to control Revit when trying to unload locally a Revit link with changes in shared coordinates.

  METHODS:
    SaveModifiedLinksOptionsForUnloadLocally GetSaveModifiedLinksOptionForUnloadLocally(RevitLinkType link)
      Description: Determines whether Revit should save the link or not prior to unloading the link locally.
      @link: The Revit link which has modified shared coordinates.
      Returns: The saving option when unloading locally a linked file which has been modified in-memory by shared coordinates operations.

--------------------------------------------------------------------------------

[INTERFACE] ITransactionFinalizer
Full Name: Autodesk.Revit.DB.ITransactionFinalizer
Description: An interface that may be used to perform a custom action at the end of a transaction. A method of the interface will be called when a transaction is either committed or rolled back.

  METHODS:
    void OnCommitted(Document document, string strTransactionName)
      Description: This method is called at the end of committing a transaction
      @document: The document associated with the transaction
      @strTransactionName: The transaction's name
    void OnRolledBack(Document document, string strTransactionName)
      Description: This method is called at the end of rolling back a transaction
      @document: The document associated with the transaction
      @strTransactionName: The transaction's name

--------------------------------------------------------------------------------

[INTERFACE] ITransientElementMaker
Full Name: Autodesk.Revit.DB.ITransientElementMaker
Description: The interface to be implemented by an application that creates transient element(s) in Revit.
Remarks: An instance of the implemented interface is passed as an argument to the Document.MakeTransientElements() method, which will call back the Execute method of the interface.During the execution of the method Revit will allow creation of certain elements, such as DirectShape, and will make them automatically transient . See (IsTransient for more details about transient elements.)The code within the Execute method is not allowed to modify the model in any other way. An attempt to change the model or create elements of other kinds will result in an exception. This indirectly means that methods using a transaction internally are not allowed either. Such methods include document Save and SaveAs, certain import and export methods, creating links, syncing with central, etc.Regenerating the model is also not allowed for the entire duration of the Execute method.This interface is passed to ITransientElementMaker) which does the actual transient element creation.

  METHODS:
    void Execute()
      Description: Implement this method to create transient elements.

--------------------------------------------------------------------------------

[INTERFACE] IUpdater
Full Name: Autodesk.Revit.DB.IUpdater
Description: The interface used to create an updater capable of reacting to changes in the Revit model.
Remarks: Implement this interface and register an instance of the derived class with the UpdaterRegistry.

  METHODS:
    void Execute(UpdaterData data)
      Description: The method that Revit will invoke to perform an update.
      @data: Provides all necessary data needed to perform the update, including the document and information about the changes that triggered the update.
    string GetAdditionalInformation()
      Description: Auxiliary text that Revit will use to inform the end user when the Updater is not loaded
    ChangePriority GetChangePriority()
      Description: Identifies the nature of the change the Updater will be performing Used to identify order of execution of updaters Called once during registration of the updater
    UpdaterId GetUpdaterId()
      Description: Returns globally unique updater id - used to identify the Updater Called once during registration of the updater
    string GetUpdaterName()
      Description: Returns a name that the Updater can be identified by to the user

--------------------------------------------------------------------------------

[INTERFACE] IViewSheetSet
Full Name: Autodesk.Revit.DB.IViewSheetSet
Description: This interface represents a selected set of views/sheets which will be used for printing.

  PROPERTIES:
    bool IsAutomatic { get; set; }
      Description: Automatic order or manual order.
    IReadOnlyList<View> OrderedViewList { get; set; }
      Description: Ordered views.
    ElementId SheetOrganizationId { get; set; }
      Description: ElementId to the BrowserOrganization for sheets.
    ElementId ViewOrganizationId { get; set; }
      Description: ElementId to the BrowserOrganization for non-sheet views.
    ViewSet Views { get; set; }
      Description: The views.

--------------------------------------------------------------------------------

