# Autodesk.Revit.DB (Types: E)

[ENUM] EaveCutterType
Full Name: Autodesk.Revit.DB.EaveCutterType

Description: An enumerated type to store type of EaveCutter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - PlumbCut = 33615
    - TwoCutSquare = 33618
    - TwoCutPlumb = 33619


[CLASS] Edge
Full Name: Autodesk.Revit.DB.Edge

Description: An edge of a 3d solid.
Remarks: Edges are defined by intersections of surfaces that form faces of the solid. They have arbitrary parameterization that is normalized to [0,1].
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    double ApproximateLength { get; }
      Description: Returns the approximate length of the edge.
    Reference Reference { get; }
      Description: Returns a stable reference to the edge.

  METHODS:
    Curve AsCurve()
      Description: Returns a curve that corresponds to the edge's parametric orientation.
      Returns: It can be an Arc, Line, or HermiteSpline.
    Curve AsCurveFollowingFace(Face faceForDir)
      Description: Returns a curve that corresponds to this edge as oriented in its topological direction on the specified face.
      @faceForDir: Specifies the face, on which the curve will follow the topological direction of the edge.
      Returns: It can be an Arc, Line, or HermiteSpline.
    Transform ComputeDerivatives(double parameter)
      Description: Returns the vectors describing the edge at the specified parameter.
      @parameter: The parameter to be evaluated.
      Returns: The transformation containing a tangent vector, derivative of tangent vector, and bi-normal vector.
    XYZ Evaluate(double param)
      Description: Evaluates a parameter on the edge.
      @param: The parameter to be evaluated, in [0,1].
    UV EvaluateOnFace(double param, Face face)
      Description: Evaluates a parameter on the edge to produce UV coordinates on the face.
      @param: The parameter to be evaluated, in [0,1].
      @face: The face on which to perform the evaluation. Must belong to the edge.
    CurveUV GetCurveUV(int index, Transform2D transform)
      Description: Calculate and transform a 2D curve that represents the edge in the uv-parameter plane of one of the edge's faces. The output curve's direction will follow the parametric direction of the edge, not the topological direction of the edge on the given face.
      @index: The index of the face (0 or 1).
      @transform: Transformation to apply to the curve.
      Returns: If successful, returns the calculated and transformed CurveUV, otherwise.
    CurveUV GetCurveUV(int index)
      Description: Calculate a 2D curve that represents the edge in the uv-parameter plane of one of the edge's faces. The output curve's direction will follow the parametric direction of the edge, not the topological direction of the edge on the given face.
      @index: The index of the face (0 or 1).
      Returns: If successful, returns the calculated CurveUV, otherwise.
    Reference GetEndPointReference(int index)
      Description: Returns a stable reference to the start or the end point of the edge.
      @index: Use 0 for the start point; 1 for the end point.
      Returns: Reference to the point or if reference cannot be obtained.
    Face GetFace(int index)
      Description: Returns one of the two faces that meet at the edge.
      @index: The index of the face (0 or 1).
    bool IsFlippedOnFace(Face face)
      Description: Determines if this edge's topological direction on the Face is opposite to its parametric direction.
      @face: The face with respect to which the direction is considered. Must belong to the edge.
      Returns: true if this edge's topological direction on the Face is opposite to its parametric direction, false if the topological direction agrees with the parametric direction.
    bool IsFlippedOnFace(int index)
      Description: Determines if this edge's topological direction on the Face is opposite to its parametric direction.
      @index: The index of the face (0 or 1).
      Returns: true if this edge's topological direction on the Face is opposite to its parametric direction, false if the topological direction agrees with the parametric direction.
    IList<XYZ> Tessellate()
      Description: Returns a polyline approximation to the edge.
    IList<UV> TessellateOnFace(Face face)
      Description: Returns a polyline approximation to the edge in UV parameters of the face.
      @face: The face on which to perform the tessellation. Must belong to the edge.

--------------------------------------------------------------------------------


[CLASS] EdgeArray
Full Name: Autodesk.Revit.DB.EdgeArray

Description: An array that contains edges.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new EdgeArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Edge Item { get; set; }
    int Size { get; }
      Description: Returns the number of edges that are in the array.

  METHODS:
    void Append(Edge item)
      Description: Add the edge to the end of the array.
      @item: The edge to be added.
    void Clear()
      Description: Removes every edge from the array, rendering it empty.
    EdgeArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Edge item, int index)
      Description: Insert the specified edge into the array.
      @item: The edge to be inserted into the array.
      @index: The edge will be inserted before this index.
      Returns: Returns whether the edge was inserted into the array.
    EdgeArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[CLASS] EdgeArrayArray
Full Name: Autodesk.Revit.DB.EdgeArrayArray

Description: An array of edge arrays.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new EdgeArrayArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    EdgeArray Item { get; set; }
    int Size { get; }
      Description: Returns the number of edge arrays that are in the array.

  METHODS:
    void Append(EdgeArray item)
      Description: Add the edge array to the end of the array.
      @item: The edge array to be added.
    void Clear()
      Description: Removes every edge array from the array, rendering it empty.
    EdgeArrayArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(EdgeArray item, int index)
      Description: Insert the specified edge array into the array.
      @item: The edge array to be inserted into the array.
      @index: The edge array will be inserted before this index.
      Returns: Returns whether the edge array was inserted into the array.
    EdgeArrayArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] EdgeArrayArrayIterator
Full Name: Autodesk.Revit.DB.EdgeArrayArrayIterator

Description: An iterator to an array or edge arrays.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new EdgeArrayArrayIterator()

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


[ABSTRACT CLASS] EdgeArrayIterator
Full Name: Autodesk.Revit.DB.EdgeArrayIterator

Description: An iterator to an edge array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new EdgeArrayIterator()

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


[CLASS] EdgeEndPoint
Full Name: Autodesk.Revit.DB.EdgeEndPoint

Description: Represents the start or the end point of an Edge.
Implements: IDisposable

  CONSTRUCTORS:
    new EdgeEndPoint(Edge edge, int index)

  PROPERTIES:
    Edge Edge { get; }
      Description: The Edge.
    int Index { get; }
      Description: The index of the start or the end point of an Edge: 0 is the start point, 1 is the end point.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool Equals(EdgeEndPoint other)
      Description: Determines whether this EdgeEndPoint is equal to another.
      @other: The EdgeEndPoint with which to compare this EdgeEndPoint.
      Returns: True if the given EdgeEndPoint is equal to this one, otherwise false.
    XYZ Evaluate()
      Description: Evaluate the end point of the edge in 3d coordinates.
      Returns: The end point of the edge in 3d coordinates.

--------------------------------------------------------------------------------


[CLASS] EditScope
Full Name: Autodesk.Revit.DB.EditScope

Description: The base class for a scope object that provides special access and limitations related to editing certain elements.
Remarks: Derivations of this class provide specific functionality to manage edit modes for specific purposes.
Implements: IDisposable

  PROPERTIES:
    bool IsActive { get; }
      Description: Tells if the EditScope is active. In other words, the EditScope has started but not committed/canceled yet.
    bool IsPermitted { get; }
      Description: Tells if the edit scope is permitted to start.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Cancel()
      Description: Cancels the edit scope.
    void Commit(IFailuresPreprocessor failurePreprocessor)
      Description: Finishes the edit scope.
      @failurePreprocessor: Callback to be invoked in the beginning of failure processing.
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] Element
Full Name: Autodesk.Revit.DB.Element

Description: Base class for most persistent data within a Revit document.
Remarks: The data in a Revit document consists primarily of a collection of elements. An element usually corresponds to a single component of a building or drawing, such as a wall, door, or dimension, but it can also be something more abstract, like a wall type or a view. Every element in a document has a unique ID, represented by the ElementId class.
Implements: IDisposable

  PROPERTIES:
    ElementId AssemblyInstanceId { get; }
      Description: The id of the assembly instance to which the element belongs.
    BoundingBoxXYZ BoundingBox { get; }
    Category Category { get; }
      Description: Retrieves a Category object that represents the category or sub category in which the element resides.
    ElementId CreatedPhaseId { get; set; }
      Description: Id of a Phase at which the Element was created.
    ElementId DemolishedPhaseId { get; set; }
      Description: Id of a Phase at which the Element was demolished.
    DesignOption DesignOption { get; }
      Description: Returns the design option to which the element belongs.
    Document Document { get; }
      Description: Returns the Document in which the Element resides.
    GeometryElement Geometry { get; }
    ElementId GroupId { get; }
      Description: The id of the group to which an element belongs.
    ElementId Id { get; }
      Description: A unique identifier for an Element in an Autodesk Revit project.
    bool IsModifiable { get; }
      Description: Identifies if the element is modifiable.
    bool IsTransient { get; }
      Description: Indicates whether an element is transient or permanent.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId LevelId { get; }
      Description: The id of the level associated with the element.
    Location Location { get; }
      Description: This property is used to find the physical location of an element within a project.
    string Name { get; set; }
      Description: A human readable name for the Element.
    ElementId OwnerViewId { get; }
      Description: The id of the view that owns the element.
    Parameter Parameter { get; }
    Parameter Parameter { get; }
    Parameter Parameter { get; }
    ParameterSet Parameters { get; }
      Description: Retrieves a set containing all of the parameters that are contained within the element.
    ParameterMap ParametersMap { get; }
      Description: Retrieves a map containing all of the parameters that are contained within the element.
    bool Pinned { get; set; }
      Description: Identifies if the element has been pinned to prevent changes.
    string UniqueId { get; }
      Description: A stable unique identifier for an element within the document.
    Guid VersionGuid { get; }
      Description: Get the element version Guid.
    bool ViewSpecific { get; }
      Description: Identifies if the element is owned by a view.
    WorksetId WorksetId { get; }
      Description: Get Id of the Workset which owns the element.

  METHODS:
    bool ArePhasesModifiable()
      Description: Returns true if the properties CreatedPhaseId and DemolishedPhaseId can be modified for this Element.
      Returns: True if the properties CreatedPhaseId and DemolishedPhaseId can be modified for this Element, false otherwise.
    bool CanBeHidden(View pView)
      Description: Indicates if the element can be hidden in the view.
      Returns: If the element is not permitted to be hidden, false is returned.
    bool CanBeLocked()
      Description: Identifies if the element can be locked.
      Returns: True if the element can be locked, false otherwise.
    bool CanDeleteSubelement(Subelement subelem)
      Description: Checks if given subelement can be removed from the element.
      @subelem: Subelement to check.
      Returns: True if subelement can be removed, false otherwise.
    static bool CanHaveTypeAssigned(Document document, ICollection<ElementId> elementIds)
      Description: Checks if all elements in the set can have a type assigned.
      @document: The document.
      @elementIds: A collection of element IDs.
      Returns: True if all elements in the set can have a type assigned, false otherwise.
    bool CanHaveTypeAssigned()
      Description: Identifies if the element can have a type assigned.
      Returns: True if element can have a type assigned, false otherwise.
    static IDictionary<ElementId, ElementId> ChangeTypeId(Document document, ICollection<ElementId> elementIds, ElementId typeId)
      Description: Changes the type of all elements in the given set.
      @document: The document.
      @elementIds: A collection of element IDs.
      @typeId: Identifier of the type to assign to this element.
      Returns: The map of original element IDs to the new element IDs if some elements were replaced by new elements (the map is empty if no elements were replaced)
    ElementId ChangeTypeId(ElementId typeId)
      Description: Changes the type of the element.
      @typeId: Identifier of the type to assign to this element.
      Returns: The new element id if new element is created, or InvalidElementId if the element's type changed without creating a new element.
    bool DeleteEntity(Schema schema)
      Description: Deletes the existing entity created by %schema% in the element
      @schema: Schema used for creation of the entity
      Returns: True if entity was deleted, false if entity didn't exist
    bool DeleteSubelement(Subelement subelem)
      Description: Removes a subelement from the element.
      @subelem: The subelement to delete.
      Returns: True if entire element was deleted, false otherwise.
    bool DeleteSubelements(IList<Subelement> subelems)
      Description: Removes the subelements from the element.
      @subelems: Subelements to delete.
      Returns: True if entire element was deleted, false otherwise.
    void Dispose()
    IList<EvaluatedParameter> EvaluateAllParameterValues()
      Description: Evaluates all the parameters' values of the element.
      Returns: List of of the element.
    IList<EvaluatedParameter> EvaluateParameterValues(ISet<ElementId> parameterIds)
      Description: Evaluate the parameters' values of the element on the given parameter ID set.
      @parameterIds: Parameter IDs with which the ParameterValue to be retrieved.
      Returns: List of of the element, which does not include those that cannot be retrieved but are passed in through .
    static ChangeType GetChangeTypeAny()
      Description: Returns ChangeType associated with any change in an element.
      Returns: ChangeType that can be used to define a trigger for an Updater, triggering on any change in an element.
    static ChangeType GetChangeTypeElementAddition()
      Description: Returns ChangeType associated with element addition
      Returns: ChangeType that can be used to define a trigger for an Updater, triggering on element addition.
    static ChangeType GetChangeTypeElementDeletion()
      Description: Returns ChangeType associated with element deletion.
      Returns: ChangeType that can be used to define a trigger for an Updater, triggering on element deletion.
    static ChangeType GetChangeTypeGeometry()
      Description: Returns ChangeType associated with a change in the geometry of an element
      Returns: ChangeType that can be used to define a trigger for an Updater, triggering on a geometry change in an element
    static ChangeType GetChangeTypeParameter(ElementId parameterId)
      Description: Returns ChangeType associated with a change in a parameter's value
      @parameterId: ElementId of parameter for the ChangeType to trigger on.
      Returns: ChangeType that can be used to define a trigger for an Updater, triggering on parameter value change.
    static ChangeType GetChangeTypeParameter(Parameter param)
      Description: Returns ChangeType associated with a change in a parameter's value
      @param: Parameter for the ChangeType to trigger on
      Returns: ChangeType that can be used to define a trigger for an Updater, triggering on parameter value change
    IList<ElementId> GetDependentElements(ElementFilter filter)
      Description: Get all elements that, from a logical point of view, are the children of this Element.
      @filter: What type of elements we are interested of. Can be NULL to return all dependent elements.
      Returns: Logical children of this element
    Entity GetEntity(Schema schema)
      Description: Returns the existing entity corresponding to the Schema if it has been saved in the Element, or an invalid entity otherwise.
      @schema: The Schema describing the Entity.
      Returns: The returned Entity.
    IList<Guid> GetEntitySchemaGuids()
      Description: Returns the Schema guids of any Entities stored in this element.
      Returns: The schema Entity guids.
    ExternalFileReference GetExternalFileReference()
      Description: Gets information pertaining to the external file referenced by the element.
      Returns: An object containing path and type information for the external file referenced by the element.
    ExternalResourceReference GetExternalResourceReference(ExternalResourceType resourceType)
      Description: Gets the ExternalResourceReference associated with a specified external resource type.
      @resourceType: The desired external resource type.
      Returns: The copy of the ExternalResourceReference associated with a specified external resource type.
    IList<ExternalResourceReference> GetExternalResourceReferenceExpanded(ExternalResourceType resourceType)
      Description: Gets the collection of ExternalResourceReference associated with a specified external resource type.
      @resourceType: The desired external resource type.
      Returns: The collection of the ExternalResourceReference associated with a specified external resource type.
    IDictionary<ExternalResourceType, ExternalResourceReference> GetExternalResourceReferences()
      Description: Gets the map of the external resource references referenced by the element.
      Returns: The map of the external resource references referenced by the element.
    IDictionary<ExternalResourceType, IList<ExternalResourceReference>> GetExternalResourceReferencesExpanded()
      Description: Gets the expanded map of the external resource references referenced by the element.
      Returns: The expanded map of the external resource references referenced by the element.
    ICollection<ElementId> GetGeneratingElementIds(GeometryObject geometryObject)
      Description: Returns the ids of the element(s) that generated the input geometry object.
      @geometryObject: The geometry object whose generating element is requested.
      Returns: The id(s) of the element(s) that generated (or may have generated) the given geometry object. Empty if no generating elements are found. If the set contains just one id, it is the id of the element that generated the geometry object.
    GeometryObject GetGeometryObjectFromReference(Reference reference)
      Description: Retrieve one geometric primitive contained in the element given a reference.
      @reference: The geometric object referenced by this instance will be retrieved from the model.
      Returns: The geometric object referenced by the input reference.
    double GetMaterialArea(ElementId materialId, bool usePaintMaterial)
      Description: Gets the area of the material with the given id.
      @materialId: The material id returned from .
      @usePaintMaterial: If true, this material id was returned as a paint material from and the area returned should be calculated from paint applied to the element. If false, this material id was returned as a non-paint element material from and the area is calculated from the element geometry and layers.
      Returns: The area of the material for this element. Returns 0.0 if the material id is not a part of this element.
    ICollection<ElementId> GetMaterialIds(bool returnPaintMaterials)
      Description: Gets the element ids of all materials present in the element.
      @returnPaintMaterials: If true, this returns material ids assigned to element faces by the Paint tools. If false, this returns ids associated to the material through its geometry or compound structure layers.
      Returns: The set of material ids.
    double GetMaterialVolume(ElementId materialId)
      Description: Gets the volume of the material with the given id.
      @materialId: The material id returned from .
      Returns: The volume of the material for this element. Returns 0.0 if the material is not a part of this element.
    IList<ElementId> GetMonitoredLinkElementIds()
      Description: Provides the link instance IDs when the element is monitoring.
      Returns: The IDs of linked instances.
    IList<ElementId> GetMonitoredLocalElementIds()
      Description: Provides the local element IDs when the element is monitoring.
      Returns: The IDs of local element IDs being monitored by this element.
    IList<Parameter> GetOrderedParameters()
      Description: Gets the parameters associated to the element in order.
      Returns: A collection containing all parameters.
    Parameter GetParameter(ForgeTypeId parameterTypeId)
      Description: Retrieves a parameter from the element given identifier.
      @parameterTypeId: Identifier of the built-in parameter.
    FormatOptions GetParameterFormatOptions(ElementId parameterId)
      Description: Returns a FormatOptions override for the element Parameter, or a default FormatOptions if no override exists.
      @parameterId: Id of parameter for which FormatOptions will be returned.
      Returns: Format options of element parameter. If the UseDefault property is true, then no formatting overrides have been defined in the element for the specified parameter, and the FormatOptions for the parameter should be obtained from the Unit object, which can be obtained from the Document.
    IList<Parameter> GetParameters(string name)
      Description: Retrieves the parameters from the element via the given name.
      @name: The name of the parameter to be retrieved.
      Returns: A collection containing the parameters having the same given parameter name.
    ElementOnPhaseStatus GetPhaseStatus(ElementId phaseId)
      Description: Gets the status of a given element in the input phase
      @phaseId: Id of the phase.
      Returns: The status of the element in the phase.
    IList<Subelement> GetSubelements()
      Description: Returns the collection of element subelements.
      Returns: The collection of element subelements.
    ElementId GetTypeId()
      Description: Returns the identifier of this element's type.
      Returns: The id of the element's type, or invalid element id if the element cannot have type assigned.
    static ICollection<ElementId> GetValidTypes(Document document, ICollection<ElementId> elementIds)
      Description: Obtains a set of types that are valid for all given elements.
      @document: The document.
      @elementIds: A collection of element IDs.
      Returns: A set of element IDs of types that are valid for these elements or an empty set if any element cannot have a type assigned.
    ICollection<ElementId> GetValidTypes()
      Description: Obtains a set of types that are valid for this element.
      Returns: A set of element IDs of types that are valid for this element or an empty set if element cannot have type assigned.
    bool HasPhases()
      Description: Returns true if this Element has the properties CreatedPhaseId and DemolishedPhaseId.
      Returns: True if this Element has the properties CreatedPhaseId and DemolishedPhaseId, false otherwise.
    bool IsCreatedPhaseOrderValid(ElementId createdPhaseId)
      Description: Returns true if createdPhaseId and demolishedPhaseId are in order.
      @createdPhaseId: The createdPhaseId.
      Returns: True if createdPhaseId index is less than or equal to demolishedPhaseId, otherwise returns false.
    bool IsDemolishedPhaseOrderValid(ElementId demolishedPhaseId)
      Description: Returns true if createdPhaseId and demolishedPhaseId are in order.
      @demolishedPhaseId: The demolishedPhaseId.
      Returns: True if createdPhaseId index is less than or equal to demolishedPhaseId, otherwise returns false.
    bool IsExternalFileReference()
      Description: Determines whether this Element represents an external file.
      Returns: True if this element contains information about some external file, false if it does not.
    bool IsHidden(View pView)
      Description: Identifies if the element has been permanently hidden in the view.
    bool IsMonitoringLinkElement()
      Description: Indicate whether an element is monitoring any elements in any linked models.
      Returns: True if this element is monitoring elements in a linked models. Otherwise, false will be returned.
    bool IsMonitoringLocalElement()
      Description: Indicate whether an element is monitoring other local elements.
      Returns: True if this element is monitoring other elements in same project. Otherwise, false will be returned.
    bool IsPhaseCreatedValid(ElementId createdPhaseId)
      Description: Returns true if createdPhaseId is an allowed value for the property CreatedPhaseId in this Element.
      @createdPhaseId: The id of a Phase.
      Returns: True if createdPhaseId is an allowed value for the property CreatedPhaseId in this Element, false otherwise.
    bool IsPhaseDemolishedValid(ElementId demolishedPhaseId)
      Description: Returns true if demolishedPhaseId is an allowed value for the property DemolishedPhaseId in this Element.
      @demolishedPhaseId: The id of a Phase or invalidElementId.
      Returns: True if demolishedPhaseId is an allowed value for the property DemolishedPhaseId in this Element, false otherwise.
    static bool IsValidType(Document document, ICollection<ElementId> elementIds, ElementId typeId)
      Description: Checks if given type is valid for the set of elements.
      @document: The document.
      @elementIds: A collection of element IDs.
      @typeId: ElementId of the type to check.
      Returns: True if all elements can have a type assigned and this type is valid for all elements, false otherwise.
    bool IsValidType(ElementId typeId)
      Description: Checks if given type is valid for this element.
      @typeId: ElementId of the type to check.
      Returns: True if element can have a type assigned and this type is valid for this element, false otherwise.
    Parameter LookupParameter(string name)
      Description: Attempts to find a parameter on the element which has the given name.
      @name: The name of the parameter to be retrieved.
      Returns: The matching parameter. This return may be if there is no matching parameter. If there are multiple matching parameters the first one found is returned.
    bool RefersToExternalResourceReference(ExternalResourceType resourceType)
      Description: Determines whether this Element uses external resources associated with a specified external resource type.
      @resourceType: The desired external resource type.
      Returns: Returns true if this Element uses external resources associated with the specified external resource type; otherwise, false.
    bool RefersToExternalResourceReferences()
      Description: Determines whether this Element uses external resources.
      Returns: True if this element uses external resources, false if it does not.
    void SetEntity(Entity entity)
      Description: Stores the entity in the element. If an Entity described by the same Schema already exists, it is overwritten.
      @entity: The Entity to be stored.

--------------------------------------------------------------------------------


[CLASS] ElementArray
Full Name: Autodesk.Revit.DB.ElementArray

Description: An array that contains element objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ElementArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Element Item { get; set; }
    int Size { get; }
      Description: Returns the number of elements that are in the array.

  METHODS:
    void Append(Element item)
      Description: Add the element to the end of the array.
      @item: The element to be added.
    void Clear()
      Description: Removes every element from the array, rendering it empty.
    ElementArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Element item, int index)
      Description: Insert the specified element into the array.
      @item: The element to be inserted into the array.
      @index: The element will be inserted before this index.
      Returns: Returns whether the element was inserted into the array.
    ElementArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ElementArrayIterator
Full Name: Autodesk.Revit.DB.ElementArrayIterator

Description: An iterator to an element array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ElementArrayIterator()

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


[ABSTRACT CLASS] ElementBinding
Full Name: Autodesk.Revit.DB.ElementBinding

Description: A base class for all types of binding that attach to an element.
Remarks: This base class provides methods that are common to all types of binding that work with elements.
Inherits: Binding
Implements: IDisposable

  PROPERTIES:
    CategorySet Categories { get; set; }
      Description: Retrieve or set the categories to which a parameter definition will be bound.

--------------------------------------------------------------------------------


[CLASS] ElementCategoryFilter
Full Name: Autodesk.Revit.DB.ElementCategoryFilter

Description: A filter used to match elements by their category.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementCategoryFilter(BuiltInCategory category, bool inverted)
    new ElementCategoryFilter(BuiltInCategory category)
    new ElementCategoryFilter(ElementId categoryId, bool inverted)
    new ElementCategoryFilter(ElementId categoryId)

  PROPERTIES:
    ElementId CategoryId { get; }
      Description: The category id.

--------------------------------------------------------------------------------


[CLASS] ElementClassFilter
Full Name: Autodesk.Revit.DB.ElementClassFilter

Description: A filter used to match elements by their class.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory. This filter will match elements whose class is an exact match to the input class, or elements whose class is derived from the input class.There is a small subset of Element subclasses in the API which are not supported by this filter. These types exist in the API, but not in Revit's native object model, which means that this filter doesn't support them. In order to use a class filter to find elements of these types, it is necessary to use a higher level class and then process the results further to find elements matching only the subtype. The following types are affected by this restriction: Subclasses of Autodesk.Revit.DB.MaterialSubclasses of Autodesk.Revit.DB.CurveElementSubclasses of Autodesk.Revit.DB.ConnectorElementSubclasses of Autodesk.Revit.DB.HostedSweepAutodesk.Revit.DB.Architecture.RoomAutodesk.Revit.DB.Mechanical.SpaceAutodesk.Revit.DB.AreaAutodesk.Revit.DB.Architecture.RoomTagAutodesk.Revit.DB.Mechanical.SpaceTagAutodesk.Revit.DB.AreaTagAutodesk.Revit.DB.CombinableElementAutodesk.Revit.DB.MullionAutodesk.Revit.DB.PanelAutodesk.Revit.DB.AnnotationSymbolAutodesk.Revit.DB.Structure.AreaReinforcementTypeAutodesk.Revit.DB.Structure.PathReinforcementTypeAutodesk.Revit.DB.AnnotationSymbolTypeAutodesk.Revit.DB.Architecture.RoomTagTypeAutodesk.Revit.DB.Mechanical.SpaceTagTypeAutodesk.Revit.DB.AreaTagTypeAutodesk.Revit.DB.Structure.TrussType
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementClassFilter(Type type, bool inverted)
    new ElementClassFilter(Type type)

  METHODS:
    Type GetElementClass()
      Description: The class for the filter.
      Returns: The class.

--------------------------------------------------------------------------------


[CLASS] ElementDesignOptionFilter
Full Name: Autodesk.Revit.DB.ElementDesignOptionFilter

Description: A filter used to find elements contained within a particular design option.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementDesignOptionFilter(ElementId designOptionId, bool inverted)
    new ElementDesignOptionFilter(ElementId designOptionId)

  PROPERTIES:
    ElementId DesignOptionId { get; }
      Description: The design option id.

--------------------------------------------------------------------------------


[CLASS] ElementFilter
Full Name: Autodesk.Revit.DB.ElementFilter

Description: A base class for a type of filter that accepts or rejects elements based upon criteria.
Implements: IDisposable

  PROPERTIES:
    bool Inverted { get; }
      Description: True if the results of the filter are inverted; elements that would normally be accepted by this filter will be rejected, and elements that would normally be rejected will be accepted.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool PassesFilter(Document document, ElementId id)
      Description: Applies the filter to a given element.
      @document: The document.
      @id: The element id.
      Returns: True if the element is accepted by the filter. False if the element is rejected.
    bool PassesFilter(Element element)
      Description: Applies the filter to a given element.
      @element: The element.
      Returns: True if the element is accepted by the filter. False if the element is rejected.

--------------------------------------------------------------------------------


[CLASS] ElementId
Full Name: Autodesk.Revit.DB.ElementId

Description: The ElementId object is used as a unique identification for an element within a single project.
Remarks: The Value within the ElementId is only unique with a single project. It is not unique across several projects. The Id can be used to retrieve a specific element from the database when needed. However ids are subject to change during an Autodesk Revit session and as such should not be retained and used across repeated calls to external commands. If a manner is needed to uniquely identify an element beyond this limitation then a shared parameter should be added to the element containing a unique identifier managed by the external application.

  CONSTRUCTORS:
    new ElementId(BuiltInParameter parameterId)
    new ElementId(BuiltInCategory categoryId)
    new ElementId(long id)
    new ElementId(int id)

  PROPERTIES:
    int IntegerValue { get; }
      Description: Provides the value of the element id as a 32-bit integer.
    static ElementId InvalidElementId { get; }
      Description: Get the invalid ElementId whose value is -1.
    long Value { get; }
      Description: Provides the value of the element id as a 64-bit integer.

  METHODS:
    int Compare(ElementId id)
      Description: Compares two element ids.
      @id: The ElementId to be compared with this ElementId.
      Returns: -1 if this element id is less than id, 0 if equal, 1 if greater.
    bool Equals(object obj)
      Description: Determines whether the specified is equal to the current .
      @obj: Another object.
    int GetHashCode()
      Description: Gets the value of the id as hash code
    static ElementId Parse(string idStr)
      Description: Parse the string representation of the id into a corresponding ElementId.
      @idStr: The string representation of the id to return.
      Returns: ElementId string represented.
    string ToString()
      Description: Gets a String representation of the value of the id.
    static bool TryParse(string idStr, out ElementId id)

--------------------------------------------------------------------------------


[CLASS] ElementIdParameterValue
Full Name: Autodesk.Revit.DB.ElementIdParameterValue

Description: A class that holds a ElementId value of a parameter element.
Inherits: ParameterValue
Implements: IDisposable

  CONSTRUCTORS:
    new ElementIdParameterValue(ElementId value)
    new ElementIdParameterValue()

  PROPERTIES:
    ElementId Value { get; set; }
      Description: The stored value

--------------------------------------------------------------------------------


[CLASS] ElementIdSetFilter
Full Name: Autodesk.Revit.DB.ElementIdSetFilter

Description: A filter wrapping a set of elements.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementIdSetFilter(ICollection<ElementId> idsToInclude)

  METHODS:
    ICollection<ElementId> GetIdsToInclude()
      Description: Returns the ids of this filter.
      Returns: The collection of ids.

--------------------------------------------------------------------------------


[CLASS] ElementIntersectsElementFilter
Full Name: Autodesk.Revit.DB.ElementIntersectsElementFilter

Description: A filter to find elements that intersect the solid geometry of a given element.
Remarks: The target object is another element. The intersection is determined with the same logic used by Revit to determine if an interference exists during generation of an Interference Report. (This means that some combinations of elements will never be detected as intersecting by this filter, such as concrete members which are automatically joined at their intersections). Also, elements which have no solid geometry, such as Rebar, will never be detected as intersecting by this filter.This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple this filter with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded.
Inherits: ElementIntersectsFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementIntersectsElementFilter(Element element, bool inverted)
    new ElementIntersectsElementFilter(Element element)

  METHODS:
    Element GetElement()
      Description: Gets the target element.
      Returns: The element.

--------------------------------------------------------------------------------


[CLASS] ElementIntersectsFilter
Full Name: Autodesk.Revit.DB.ElementIntersectsFilter

Description: A base class for filters used to match elements which intersect with geometry.
Inherits: ElementSlowFilter
Implements: IDisposable

  METHODS:
    static bool IsCategorySupported(Element element)
      Description: Identifies if the input element is of a category supported by element intersection filters.
      @element: The element.
      Returns: True if the element category is supported, false otherwise.
    static bool IsElementSupported(Element element)
      Description: Identifies if the input element is supported by element intersection filters.
      @element: The element.
      Returns: True if the element is supported, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ElementIntersectsSolidFilter
Full Name: Autodesk.Revit.DB.ElementIntersectsSolidFilter

Description: A filter to find elements that intersect the given solid geometry.
Remarks: The input solid used for this filter can be obtained from an existing element, created from scratch using the routines in GeometryCreationUtilities or builder classes, or the generated from the result of a secondary operation such as a Boolean operation. Similar to the , this filter will not detect as intersecting elements which lack solid geometry, such as Rebar.This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple this filter with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded.
Inherits: ElementIntersectsFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementIntersectsSolidFilter(Solid solid, bool inverted)
    new ElementIntersectsSolidFilter(Solid solid)

  METHODS:
    Solid GetSolid()
      Description: Gets the target solid geometry.
      Returns: The solid geometry.

--------------------------------------------------------------------------------


[CLASS] ElementIsCurveDrivenFilter
Full Name: Autodesk.Revit.DB.ElementIsCurveDrivenFilter

Description: A filter used to match elements which are curve driven.
Remarks: The term "curve driven" indicates that the element's Location property is a LocationCurve. Example elements found by this filter include walls, beams, and curve elements. This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementIsCurveDrivenFilter(bool inverted)
    new ElementIsCurveDrivenFilter()

--------------------------------------------------------------------------------


[CLASS] ElementIsElementTypeFilter
Full Name: Autodesk.Revit.DB.ElementIsElementTypeFilter

Description: A filter used to match elements which are ElementTypes.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementIsElementTypeFilter(bool inverted)
    new ElementIsElementTypeFilter()

--------------------------------------------------------------------------------


[CLASS] ElementLevelFilter
Full Name: Autodesk.Revit.DB.ElementLevelFilter

Description: A filter used to match elements by their associated level.
Remarks: This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple this filter with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementLevelFilter(ElementId levelId, bool inverted)
    new ElementLevelFilter(ElementId levelId)

  PROPERTIES:
    ElementId LevelId { get; }
      Description: The id of the level that will be matched to elements' associated level.

--------------------------------------------------------------------------------


[CLASS] ElementLogicalFilter
Full Name: Autodesk.Revit.DB.ElementLogicalFilter

Description: A filter used to logically combine two or more filters.
Remarks: The component filters may be reordered by Revit to cause the quickest acting filters to be evaluated first.
Inherits: ElementFilter
Implements: IDisposable

  METHODS:
    IList<ElementFilter> GetFilters()
      Description: Returns an array of copies of the filters that are logically combined by this ElementLogicalFilter.
      Returns: Copies of the filters that are logically combined by this ElementLogicalFilter.
    void SetFilters(IList<ElementFilter> filters)
      Description: Replaces current filters in the logical filter with any number of input filters.
      @filters: A collection of input filters.

--------------------------------------------------------------------------------


[CLASS] ElementMulticategoryFilter
Full Name: Autodesk.Revit.DB.ElementMulticategoryFilter

Description: A filter used to find elements whose category matches any of a given set of categories.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementMulticategoryFilter(ICollection<BuiltInCategory> categories, bool inverted)
    new ElementMulticategoryFilter(ICollection<BuiltInCategory> categories)
    new ElementMulticategoryFilter(ICollection<ElementId> categoryIds, bool inverted)
    new ElementMulticategoryFilter(ICollection<ElementId> categoryIds)

  METHODS:
    ICollection<ElementId> GetCategoryIds()
      Description: Gets the category ids assigned to this filter.
      Returns: The category ids.

--------------------------------------------------------------------------------


[CLASS] ElementMulticlassFilter
Full Name: Autodesk.Revit.DB.ElementMulticlassFilter

Description: A filter used to match elements by their class, where more than one class of element may be passed.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory. Only elements whose class is an exact match to one of the input classes, or elements whose type is derived from the input class will pass the collector.There is a small subset of Element subclasses in the API that are not supported by this filter. These classes exist in the API, but not in Revit's native object model, which means that this filter doesn't support them. In order to use a class filter to find elements of these types, it is necessary to use a higher level class and then process the results further to find elements matching only the subclass. For a list of subclasses affected by this restriction, consult the documentation for .
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementMulticlassFilter(IList<Type> typeList, bool inverted)
    new ElementMulticlassFilter(IList<Type> typeList)

--------------------------------------------------------------------------------


[CLASS] ElementNode
Full Name: Autodesk.Revit.DB.ElementNode

Description: A render node that represents an element, including the host document containing the element.
Remarks: See also: . See also: .
Inherits: RenderNode
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: Gets the document associated with the element.
    ElementId ElementId { get; }
      Description: The Id of the element.
    ElementId LinkInstanceId { get; }
      Description: The Id of the link instance for the element.

--------------------------------------------------------------------------------


[ENUM] ElementOnPhaseStatus
Full Name: Autodesk.Revit.DB.ElementOnPhaseStatus

Description: The statuses that an element can have with respect to a given phase.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Past = 1
    - Existing = 2
    - Demolished = 3
    - New = 4
    - Temporary = 5
    - Future = 6


[CLASS] ElementOwnerViewFilter
Full Name: Autodesk.Revit.DB.ElementOwnerViewFilter

Description: A filter used to match elements which are owned by a particular view.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementOwnerViewFilter(ElementId viewId, bool inverted)
    new ElementOwnerViewFilter(ElementId viewId)

  PROPERTIES:
    ElementId ViewId { get; }
      Description: The view id.

--------------------------------------------------------------------------------


[CLASS] ElementParameterFilter
Full Name: Autodesk.Revit.DB.ElementParameterFilter

Description: A filter used to match elements by one or more parameter filter rules.
Remarks: This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple this filter with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementParameterFilter(IList<FilterRule> filterRules, bool inverted)
    new ElementParameterFilter(IList<FilterRule> filterRules)
    new ElementParameterFilter(FilterRule filterRule, bool inverted)
    new ElementParameterFilter(FilterRule filterRule)

  METHODS:
    IList<FilterRule> GetRules()
      Description: Returns the set of rules contained in this filter.
      Returns: A copy of the set of rules.

--------------------------------------------------------------------------------


[CLASS] ElementPhaseStatusFilter
Full Name: Autodesk.Revit.DB.ElementPhaseStatusFilter

Description: A filter used to match elements that have a given phase status on a given phase.
Remarks: This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple this filter with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementPhaseStatusFilter(ElementId phaseId, ICollection<ElementOnPhaseStatus> phaseStatuses, bool inverted)
    new ElementPhaseStatusFilter(ElementId phaseId, ICollection<ElementOnPhaseStatus> phaseStatuses)
    new ElementPhaseStatusFilter(ElementId phaseId, ElementOnPhaseStatus phaseStatus, bool inverted)
    new ElementPhaseStatusFilter(ElementId phaseId, ElementOnPhaseStatus phaseStatus)

  PROPERTIES:
    ElementId PhaseId { get; }
      Description: The phase id.

  METHODS:
    ICollection<ElementOnPhaseStatus> GetPhaseStatuses()
      Description: Returns the phase statuses assigned to this filter.
      Returns: The phase statuses.

--------------------------------------------------------------------------------


[CLASS] ElementQuickFilter
Full Name: Autodesk.Revit.DB.ElementQuickFilter

Description: A base class for a type of filter that operates on element records.
Remarks: Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementFilter
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ElementRecord
Full Name: Autodesk.Revit.DB.ElementRecord

Description: A record in the Revit database representing an element.
Remarks: The record is used to extract basic information about an element before the element is fully expanded in memory.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    WorksetId WorksetId { get; }
      Description: Get Id of the workset which owns the element.

  METHODS:
    void Dispose()
    Outline GetBoundingBox()
      Description: Gets the bounding box of the element record.
      Returns: The bounding box outline. if there is no bounding box for this element.
    ElementId GetCategoryId()
      Description: Gets the category id of the element record.
      Returns: The category id.
    ElementId GetDesignOptionId()
      Description: Gets the design option id of the element record.
      Returns: The design option id.
    ElementId GetId()
      Description: Gets the id of the element record.
      Returns: The element id.
    ElementId GetOwnerViewId()
      Description: Gets the element id of the owner view record.
      Returns: The view record element id.
    bool HasBoundingBox()
      Description: Determines whether this element record has a bounding box.
      Returns: True if the element record has a bounding box or false otherwise.
    bool IsAnElementType()
      Description: Identifies if the element record represents an ElementType.
      Returns: True if the element record represents an ElementType.
    bool IsCurveDriven()
      Description: Identifies if the element is curve driven.
      Returns: True if the element is curve driven.

--------------------------------------------------------------------------------


[ENUM] ElementReferenceType
Full Name: Autodesk.Revit.DB.ElementReferenceType

Description: Element reference types.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - REFERENCE_TYPE_NONE = 0
    - REFERENCE_TYPE_LINEAR = 1
    - REFERENCE_TYPE_SURFACE = 2
    - REFERENCE_TYPE_FOREIGN = 3
    - REFERENCE_TYPE_INSTANCE = 4
    - REFERENCE_TYPE_CUT_EDGE = 5
    - REFERENCE_TYPE_MESH = 6
    - REFERENCE_TYPE_SUBELEMENT = 7


[CLASS] ElementSet
Full Name: Autodesk.Revit.DB.ElementSet

Description: A set that contains element objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ElementSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of elements that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item element the set, rendering it empty.
    bool Contains(Element item)
      Description: Tests for the existence of an element within the set.
      @item: The element to be searched for.
      Returns: The Contains method returns True if the element is within the set, otherwise False.
    int Erase(Element item)
      Description: Removes a specified element from the set.
      @item: The element to be erased.
      Returns: The number of elements that were erased from the set.
    ElementSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Element item)
      Description: Insert the specified element into the set.
      @item: The element to be inserted into the set.
      Returns: Returns whether the element was inserted into the set.
    ElementSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ElementSetIterator
Full Name: Autodesk.Revit.DB.ElementSetIterator

Description: An iterator to an element set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ElementSetIterator()

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


[CLASS] ElementSlowFilter
Full Name: Autodesk.Revit.DB.ElementSlowFilter

Description: A base class for a type of filter that operates on expanded elements.
Remarks: Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple slow filters with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded in order to evaluate against the criteria set by this filter.
Inherits: ElementFilter
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ElementStructuralTypeFilter
Full Name: Autodesk.Revit.DB.ElementStructuralTypeFilter

Description: A filter used to find elements matching a structural type.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementStructuralTypeFilter(StructuralType structuralType, bool inverted)
    new ElementStructuralTypeFilter(StructuralType structuralType)

  PROPERTIES:
    StructuralType StructuralType { get; }
      Description: The structural type.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ElementTransformUtils
Full Name: Autodesk.Revit.DB.ElementTransformUtils

Description: A collection of utilities allowing transformation of elements (e.g. move, rotate, mirror and copy).

  METHODS:
    static bool CanMirrorElement(Document ADoc, ElementId elemId)
      Description: Determines whether element can be mirrored.
      @ADoc: The document where the element reside.
      @elemId: The element identified by id.
      Returns: True if the element can be mirrored.
    static bool CanMirrorElements(Document ADoc, ICollection<ElementId> elemIds)
      Description: Determines whether elements can be mirrored.
      @ADoc: The document where the elements reside.
      @elemIds: The elements identified by id.
      Returns: True if the elements can be mirrored.
    static ICollection<ElementId> CopyElement(Document document, ElementId elementToCopy, XYZ translation)
      Description: Copies an element and places the copy at a location indicated by a given transformation.
      @document: The document that owns the element.
      @elementToCopy: The id of the element to copy.
      @translation: The translation vector for the new element.
      Returns: The ids of the newly created copied elements. More than one element may be created due to dependencies.
    static ICollection<ElementId> CopyElements(View sourceView, ICollection<ElementId> elementsToCopy, View destinationView, Transform additionalTransform, CopyPasteOptions options)
      Description: Copies a set of elements from source view to destination view.
      @sourceView: The view in the source document that contains the elements to copy.
      @elementsToCopy: The set of elements to copy.
      @destinationView: The view in the destination document that the elements will be pasted into.
      @additionalTransform: The transform for the new elements, in addition to the transformation between the source and destination views. Can be if no transform is required. The transformation must be within the plane of the destination view.
      @options: Optional settings. Can be if default settings should be used.
      Returns: The ids of the newly created copied elements.
    static ICollection<ElementId> CopyElements(Document sourceDocument, ICollection<ElementId> elementsToCopy, Document destinationDocument, Transform transform, CopyPasteOptions options)
      Description: Copies a set of elements from source document to destination document.
      @sourceDocument: The document that contains the elements to copy.
      @elementsToCopy: The set of elements to copy.
      @destinationDocument: The destination document to paste the elements into.
      @transform: The transform for the new elements. Can be if no transform is required.
      @options: Optional settings. Can be if default settings should be used.
      Returns: The ids of the newly created copied elements.
    static ICollection<ElementId> CopyElements(Document document, ICollection<ElementId> elementsToCopy, XYZ translation)
      Description: Copies a set of elements and places the copies at a location indicated by a given translation.
      @document: The document that owns the elements.
      @elementsToCopy: The set of elements to copy.
      @translation: The translation vector for the new elements.
      Returns: The ids of the newly created copied elements.
    static Transform GetTransformFromViewToView(View sourceView, View destinationView)
      Description: Returns a transformation that is applied to elements when copying from one view to another view.
      @sourceView: The source view
      @destinationView: The destination view
      Returns: The transformation from source view to destination view.
    static void MirrorElement(Document document, ElementId elementToMirror, Plane plane)
      Description: Creates a mirrored copy of an element about a given plane.
      @document: The document that owns the element.
      @elementToMirror: The element to mirror.
      @plane: The mirror plane.
    static IList<ElementId> MirrorElements(Document document, ICollection<ElementId> elementsToMirror, Plane plane, bool mirrorCopies)
      Description: Mirrors a set of elements about a given plane.
      @document: The document that owns the elements.
      @elementsToMirror: The set of elements to mirror.
      @plane: The mirror plane.
      @mirrorCopies: True if mirroring should be performed on copies of the elements, leaving the original elements intact. False if no copies should be created and the elements should be mirrored directly.
      Returns: A collection of ids of newly created elements - mirrored copies. It is empty if the mirrorCopies arguments is false.
    static void MoveElement(Document document, ElementId elementToMove, XYZ translation)
      Description: Moves one element by a given transformation.
      @document: The document that owns the elements.
      @elementToMove: The id of the element to move.
      @translation: The translation vector for the elements.
    static void MoveElements(Document document, ICollection<ElementId> elementsToMove, XYZ translation)
      Description: Moves a set of elements by a given transformation.
      @document: The document that owns the elements.
      @elementsToMove: The set of elements to move.
      @translation: The translation vector for the elements.
    static void RotateElement(Document document, ElementId elementToRotate, Line axis, double angle)
      Description: Rotates an element about the given axis and angle.
      @document: The document that owns the elements.
      @elementToRotate: The element to rotate.
      @axis: The axis of rotation.
      @angle: The angle of rotation in radians.
    static void RotateElements(Document document, ICollection<ElementId> elementsToRotate, Line axis, double angle)
      Description: Rotates a set of elements about the given axis and angle.
      @document: The document that owns the elements.
      @elementsToRotate: The set of elements to rotate.
      @axis: The axis of rotation.
      @angle: The angle of rotation in radians.

--------------------------------------------------------------------------------


[CLASS] ElementType
Full Name: Autodesk.Revit.DB.ElementType

Description: Base class for all Types within Autodesk Revit.
Remarks: Element types are usually non user visible elements that define instances. For example a wall type is a type that is not visible until an instance of the wall is created.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool CanBeCopied { get; }
      Description: Determine if this ElementType can create a copy
    bool CanBeDeleted { get; }
      Description: Determine if this ElementType can be deleted
    bool CanBeRenamed { get; }
      Description: Determine if this ElementType can be renamed
    string FamilyName { get; }
      Description: Gets the family name of this element type.
    string Name { set; }
      Description: Set the name for the ElementType.

  METHODS:
    ElementType Duplicate(string name)
      Description: Duplicates an existing element type and assigns it a new name.
      @name: The new name of the element type.
      Returns: The duplicated element type.
    Bitmap GetPreviewImage(Size size)
      Description: Get the preview image of an element. This image is similar to what is seen in the Revit UI when selecting the type of an element.
      @size: The width and height of the preview image in pixels.
      Returns: System::Drawing::Bitmap represents the preview image. if there is no preview image.
    ICollection<ElementId> GetSimilarTypes()
      Description: Obtains a set of types that are similar to this type.
      Returns: A set of element IDs of types that are similar to this type.
    bool IsSimilarType(ElementId typeId)
      Description: Checks if given type is similar to this type.
      @typeId: ElementId of the type to check.
      Returns: True if given type is similar to this type, false otherwise.
    bool IsValidDefaultFamilyType(ElementId familyCategoryId)
      Description: Identifies if this type is a valid default family type for the given family category id.
      @familyCategoryId: The family category id.
      Returns: True if this type is a valid default family type for the given family category id.

--------------------------------------------------------------------------------


[ENUM] ElementTypeGroup
Full Name: Autodesk.Revit.DB.ElementTypeGroup

Description: The element type group.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - RailingsTypeForStairs = 0
    - RailingsTypeForRamps = 1
    - WallType = 2
    - RoofType = 3
    - FloorType = 4
    - FootingSlabType = 5
    - CeilingType = 6
    - StairsBySketchType = 7
    - GridType = 8
    - LevelType = 9
    - LinearDimensionType = 10
    - SpotElevationType = 11
    - TextNoteType = 12
    - TagNoteType = 13
    - ModelTextType = 14
    - CorniceType = 16
    - RevealType = 17
    - ViewportType = 19
    - ReferenceViewerType = 21
    - CalloutType = 22
    - RampType = 28
    - StairsRailingType = 30
    - ModelGroupType = 32
    - DetailGroupType = 33
    - AttachedDetailGroupType = 34
    - FilledRegionType = 35
    - RadialDimensionType = 36
    - AngularDimensionType = 37
    - ArcLengthDimensionType = 38
    - BuildingPadType = 43
    - DecalType = 45
    - ContourLabelingType = 46
    - RoofSoffitType = 47
    - FasciaType = 48
    - GutterType = 49
    - EdgeSlabType = 50
    - RepeatingDetailType = 53
    - BeamSystemType = 54
    - CurtainSystemType = 58
    - ViewType3D = 62
    - ViewTypeWalkthrough = 63
    - ViewTypeRendering = 64
    - ViewTypeSchedule = 65
    - ViewTypeLegend = 66
    - ViewTypeCostReport = 67
    - ViewTypeSheet = 68
    - ViewTypeDrafting = 69
    - ViewTypeStructuralPlan = 70
    - ViewTypeFloorPlan = 71
    - ViewTypeCeilingPlan = 72
    - ViewTypeSection = 73
    - ViewTypeDetailView = 74
    - ViewTypeElevation = 75
    - ViewTypeStructuralElevation = 76
    - ViewTypeLoadsReport = 78
    - ViewTypePressureLossReport = 79
    - ViewTypePanelSchedule = 80
    - AreaLoadType = 82
    - LineLoadType = 83
    - PointLoadType = 84
    - RebarBarType = 85
    - AreaReinforcementType = 87
    - PathReinforcementType = 88
    - FabricAreaType = 90
    - FabricSheetType = 91
    - DuctType = 97
    - FlexDuctType = 98
    - PipeType = 100
    - FlexPipeType = 101
    - WireType = 102
    - SpotCoordinateType = 106
    - ViewTypeGraphScheduleColumn = 107
    - SpotSlopeType = 108
    - WallFoundationType = 109
    - PipeInsulationType = 119
    - DuctInsulationType = 120
    - DuctLiningType = 121
    - CableTrayType = 122
    - ConduitType = 123
    - DiameterDimensionType = 126
    - StairsType = 127
    - AnalyticalLinkType = 136
    - MultiReferenceAnnotationType = 140
    - ColorFillType = 143
    - RebarContainerType = 144
    - StructuralConnectionHandlerType = 145
    - EndTreatmentType = 146
    - ViewTypeSystemsAnalysisReport = 150
    - AlignmentStationLabelType = 151
    - BendingDetail = 154
    - SchematicBendingDetail = 155
    - RebarSpliceType = 156


[CLASS] ElementWorksetFilter
Full Name: Autodesk.Revit.DB.ElementWorksetFilter

Description: A filter used to match elements which reside in a given workset.
Remarks: This filter is a quick filter.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ElementWorksetFilter(WorksetId worksetId, bool inverted)
    new ElementWorksetFilter(WorksetId worksetId)

  PROPERTIES:
    WorksetId WorksetId { get; }
      Description: The workset id.

--------------------------------------------------------------------------------


[CLASS] ElevationMarker
Full Name: Autodesk.Revit.DB.ElevationMarker

Description: ElevationMarkers either host elevation ViewSection views or view references.
Remarks: ElevationMarkers store the ViewFamilyType which will be used by all elevations hosted on the ElevationMarker. The orientation of an ElevationMarker is determined by the orientation of the views it hosts. You can check the orientation of any view by getting View.ViewDirection. To reorient the ElevationMarker and all of the views it hosts, call ElementTransformUtils.RotateElement with the ElevationMarker as an argument.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    int CurrentViewCount { get; }
      Description: The current number of views hosted by this ElevationMarker.
    bool IsReference { get; }
      Description: Indicates if this is a reference ElevationMarker. Only reference elevations can be hosted by reference ElevationMarkers.
    int MaximumViewCount { get; }
      Description: The maximum number of views that can be hosted by this ElevationMarker.

  METHODS:
    ViewSection CreateElevation(Document document, ElementId viewPlanId, int index)
      Description: Creates a new elevation ViewSection on the ElevationMarker at the desired index.
      @document: The document to which the new elevation ViewSection will be added.
      @viewPlanId: The id of a ViewPlan in which the ElevationMarker is visible. The new elevation ViewSection will derive its extents and inherit settings from the ViewPlan.
      @index: The index on the ElevationMarker where the new elevation ViewSection will be placed. The index on the ElevationMarker must be valid and unused. View direction is determined by the index.
      Returns: The new elevation ViewSection.
    static ElevationMarker CreateElevationMarker(Document document, ElementId viewFamilyTypeId, XYZ origin, int initialViewScale)
      Description: Creates a new ElevationMarker.
      @document: The document to which the new ElevationMarker will be added.
      @viewFamilyTypeId: This ViewFamilyType will be used by all elevations hosted on the new ElevationMarker.
      @origin: The desired origin for the ElevationMarker.
      @initialViewScale: This view scale will be automatically applied to new elevations created on the ElevationMarker. The scale is the ratio of true model size to paper size.
      Returns: The new ElevationMarker.
    void CreateReferenceElevation(Document document, int index, ElementId viewIdToReference)
      Description: Creates a reference elevation on the ElevationMarker at the desired index.
      @document: The document to which the new reference elevation will be added.
      @index: The index on the ElevationMarker where the reference elevation will be placed.
      @viewIdToReference: The view which will be referenced.
    static ElevationMarker CreateReferenceElevationMarker(Document document, ElementId viewFamilyTypeId, XYZ origin, ElementId viewPlanId)
      Description: Creates a new ElevationMarker.
      @document: The document to which the new ElevationMarker will be added.
      @viewFamilyTypeId: This ViewFamilyType will be used by all elevations hosted on the new ElevationMarker.
      @origin: The desired origin for the ElevationMarker.
      @viewPlanId: The ViewPlan in which the reference ElevationMarker will appear. Reference ElevationMarkers only appear in one view.
      Returns: The new ElevationMarker.
    ElementId GetViewId(int index)
      Description: Returns the ViewSection id for the index of the ElevationMarker.
      @index: The index of the ElevationMarker for which a ViewSection id will be returned.
      Returns: ViewSection id of the view at the ElevationMarker index, invalid element id otherwise.
    bool HasElevations()
      Description: Returns true if the ElevationMarker has at least one elevation view, false otherwise.
      Returns: True if the ElevationMarker has at least one elevation view, false otherwise.
    bool IsAvailableIndex(int index)
      Description: Returns true if a new elevation ViewSection can be placed at %index%, returns false otherwise.
      @index: The index of the ElevationMarker which will be checked.
      Returns: True if an elevation can be created at %index%, false otherwise.

--------------------------------------------------------------------------------


[CLASS] Ellipse
Full Name: Autodesk.Revit.DB.Ellipse

Description: A whole or partial ellipse.
Inherits: Curve
Implements: IDisposable

  PROPERTIES:
    XYZ Center { get; }
      Description: Returns the center of the ellipse.
    XYZ Normal { get; }
      Description: Returns the normal to the plane in which the ellipse is defined.
    double RadiusX { get; }
      Description: Returns the X vector radius of the ellipse.
    double RadiusY { get; }
      Description: Returns the Y vector radius of the ellipse.
    XYZ XDirection { get; }
      Description: The X direction.
    XYZ YDirection { get; }
      Description: The Y direction.

  METHODS:
    static Curve CreateCurve(XYZ center, double xRadius, double yRadius, XYZ xAxis, XYZ yAxis, double startParameter, double endParameter)
      Description: Creates a new geometric ellipse or elliptical arc object.
      @center: The center.
      @xRadius: The x vector radius of the ellipse.
      @yRadius: The y vector radius of the ellipse.
      @xAxis: The x axis to define the ellipse plane. Must be normalized.
      @yAxis: The y axis to define the ellipse plane. Must be normalized.
      @startParameter: The raw parameter value at the start of the ellipse.
      @endParameter: The raw parameter value at the end of the ellipse.
      Returns: The new ellipse or elliptical arc.

--------------------------------------------------------------------------------


[ENUM] EndCapCondition
Full Name: Autodesk.Revit.DB.EndCapCondition

Description: Used by CompoundStructure to describe which shell layers participate in end wrapping.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Exterior = 1
    - Interior = 2
    - NoEndCap = 3


[ENUM] EntryAndSchemeConsistency
Full Name: Autodesk.Revit.DB.EntryAndSchemeConsistency

Description: Enumeration used to specify why an entry is inconsistent with a scheme or another entry.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Consistent = 0
    - InconsistentStorageType = 1
    - ValueOutOfRange = 2
    - ValueDuplicated = 3
    - InvalidFillPatternId = 4


[CLASS] EvaluatedParameter
Full Name: Autodesk.Revit.DB.EvaluatedParameter

Description: Hold the evaluated and of a parameter.
Implements: IDisposable

  PROPERTIES:
    InternalDefinition Definition { get; }
      Description: Definition of the parameter.
    bool HasValue { get; }
      Description: This property is true when the parameter value was successfully obtained, false otherwise.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    StorageType StorageType { get; }
      Description: The storage type describes the type that is used internally within the parameter to store its value.
    ParameterValue Value { get; }
      Description: Evaluated value of the parameter.

  METHODS:
    string AsValueString(Document doc, FormatOptions options)
      Description: Get the parameter value as a string with units.
      @doc: The document to be used to obtain information about the parameter.
      @options: Options for formatting the string.
      Returns: The string that represents the parameter value.
    string AsValueString(Document doc)
      Description: Get the parameter value as a string with units.
      @doc: The document to be used to obtain information about the parameter.
      Returns: The string that represents the parameter value.
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExclusionFilter
Full Name: Autodesk.Revit.DB.ExclusionFilter

Description: A filter used to exclude a set of elements automatically.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new ExclusionFilter(ICollection<ElementId> idsToExclude)

  METHODS:
    ICollection<ElementId> GetIdsToExclude()
      Description: Returns the ids to be excluded by this filter.
      Returns: The collection of ids to exclude.

--------------------------------------------------------------------------------


[ENUM] ExportColorMode
Full Name: Autodesk.Revit.DB.ExportColorMode

Description: An enumerated type listing export color mode.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - IndexColors = 0
    - TrueColor = 1
    - TrueColorPerView = 2


[ENUM] ExportColumnHeaders
Full Name: Autodesk.Revit.DB.ExportColumnHeaders

Description: Options for exporting column headers in schedule view export.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - OneRow = 1
    - MultipleRows = 2


[CLASS] ExportDGNSettings
Full Name: Autodesk.Revit.DB.ExportDGNSettings

Description: This element contains DGN export settings which are saved in a Revit document.
Inherits: Element
Implements: IDisposable

  METHODS:
    static ExportDGNSettings Create(Document document, string name, DGNExportOptions options)
      Description: Create DGN export settings with specified values in DGNExportOptions.
      @document: Document where created settings is saved.
      @name: The name specified to this settings.
      @options: The options which will be stored in these settings.
      Returns: The new DGN export settings instance.
    static ExportDGNSettings Create(Document document, string name)
      Description: Create a DGN export settings with default values.
      @document: Document where created settings is saved.
      @name: The name specified to this settings.
      Returns: The new DGN export settings instance.
    static ExportDGNSettings FindByName(Document aDoc, string name)
      Description: Returns the pre-defined non-in-session exporting settings for DGN in the given document with the specified name.
      @aDoc: A Revit document to retrieve the specified pre-defined exporting settings for DGN.
      @name: The name of the settings to retrieve.
      Returns: The pre-defined DGN exporting settings, or null if nothing found that has the corresponding name.
    static ExportDGNSettings GetActivePredefinedSettings(Document aDoc)
      Description: Returns the active pre-defined non-in-session exporting settings for DGN in the given document.
      @aDoc: A Revit document to retrieve the active pre-defined exporting settings for DGN.
      Returns: The active pre-defined exporting settings for DGN, or null if nothing pre-defined exists or the in-session settings is selected.
    DGNExportOptions GetDGNExportOptions()
      Description: Gets the options stored in the these settings.
      Returns: The options.
    static IList<string> ListNames(Document aDoc)
      Description: Returns a list of names of dgn export settings.
      @aDoc: A Revit document to retrieve names from
      Returns: An array of strings representing names of predefined setups.
    void SetDGNExportOptions(DGNExportOptions options)
      Description: Sets the options stored in these settings.
      @options: The options.

--------------------------------------------------------------------------------


[CLASS] ExportDWGSettings
Full Name: Autodesk.Revit.DB.ExportDWGSettings

Description: This element contains DWG/DXF export settings which are saved in a Revit document.
Inherits: Element
Implements: IDisposable

  METHODS:
    static ExportDWGSettings Create(Document document, string name, DXFExportOptions options)
      Description: Create a DWG export settings with default values.
      @document: Document where created settings is saved.
      @name: The name specified to this settings.
      @options: Initialize settings by using values in DXFExportOptions.
      Returns: The new DWG export settings instance.
    static ExportDWGSettings Create(Document document, string name, DWGExportOptions options)
      Description: Create a DWG export settings with default values.
      @document: Document where created settings is saved.
      @name: The name specified to this settings.
      @options: Initialize settings by using values in DWGExportOptions.
      Returns: The new DWG export settings instance.
    static ExportDWGSettings Create(Document document, string name)
      Description: Create a DWG export settings with default values.
      @document: Document where created settings is saved.
      @name: The name specified to this settings.
      Returns: The new DWG export settings instance.
    static ExportDWGSettings FindByName(Document aDoc, string name)
      Description: Returns the pre-defined non-in-session exporting settings for DWG in the given document with the specified name.
      @aDoc: A Revit document to retrieve the specified pre-defined exporting settings for DWG.
      @name: The name of the settings to retrieve.
      Returns: The pre-defined DWG exporting settings, or null if nothing found that has the corresponding name.
    static ExportDWGSettings GetActivePredefinedSettings(Document aDoc)
      Description: Returns the active pre-defined non-in-session exporting settings for DWG in the given document.
      @aDoc: A Revit document to retrieve the active pre-defined exporting settings for DWG.
      Returns: The active pre-defined exporting settings for DWG, or null if nothing pre-defined exists or the in-session settings is selected.
    DWGExportOptions GetDWGExportOptions()
      Description: Gets the options stored in the these settings.
      Returns: The options.
    DXFExportOptions GetDXFExportOptions()
      Description: Gets the options stored in the these settings.
      Returns: The options
    static IList<string> ListNames(Document aDoc)
      Description: Returns a list of names of dwg/dxf export settings.
      @aDoc: A Revit document to retrieve names from.
      Returns: An array of strings representing names of predefined setups.
    void SetDWGExportOptions(DWGExportOptions options)
      Description: Sets the options stored in these settings.
      @options: The options.
    void SetDXFExportOptions(DXFExportOptions options)
      Description: Sets the options stored in these settings.
      @options: The options.

--------------------------------------------------------------------------------


[ENUM] ExportEnergyModelType
Full Name: Autodesk.Revit.DB.ExportEnergyModelType

Description: This enum is used to define if energy model used for gbXML export should be based on rooms/spaces, building elements or analysis mode in EnergyDataSettings.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SpatialElement = 0
    - BuildingElement = 1
    - AnalysisMode = 2


[CLASS] ExportFontInfo
Full Name: Autodesk.Revit.DB.ExportFontInfo

Description: A value used to represent the info stored in an .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportFontInfo(string destinationFontName)
    new ExportFontInfo()
    new ExportFontInfo(ExportFontInfo other)

  PROPERTIES:
    string DestinationFontName { get; set; }
      Description: The destination font name (the name of the font in the exported format).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportFontKey
Full Name: Autodesk.Revit.DB.ExportFontKey

Description: A key used to represent an item stored in an .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportFontKey(string originalFontName)
    new ExportFontKey()
    new ExportFontKey(ExportFontKey other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string OriginalFontName { get; set; }
      Description: The original font name.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportFontTable
Full Name: Autodesk.Revit.DB.ExportFontTable

Description: A table supporting a mapping of Revit font names to font names that will be set in the target export format.
Remarks: This table is structured as a mapping from to members. The contains the identification information for the font table: the Revit font name. The contains the font name to use in the export format.The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the returned will be a copy of the from the table. In order to make changes to the and use those settings during export, set the modified back into the table using the same key.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new ExportFontTable()

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportFontInfo Item { get; set; }

  METHODS:
    void Add(ExportFontKey exportFontKey, ExportFontInfo exportFontInfo)
      Description: Inserts a (key,info) pair into Export font table.
      @exportFontKey: The export font key to be added.
      @exportFontInfo: The export font info to be added.
    void Clear()
      Description: Removes all contents stored in the table.
    bool ContainsKey(ExportFontKey exportfontKey)
      Description: Checks whether a font key exists in the table.
      @exportfontKey: The export font Key.
      Returns: True if the font key exists in the table.
    void Dispose()
    IEnumerator<KeyValuePair<ExportFontKey, ExportFontInfo>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    ExportFontInfo GetExportFontInfo(ExportFontKey exportFontKey)
      Description: Gets a copy of the font info associated to the input font key.
      @exportFontKey: The export font Key.
      Returns: Returns the fontInfo for this key.
    ExportFontTableIterator GetFontTableIterator()
      Description: Returns a FontTableIterator that iterates through the collection.
      Returns: A FontTableIterator object that can be used to iterate through key-value pairs in the collection.
    IList<ExportFontKey> GetKeys()
      Description: Returns a collection of the keys stored in this table.
      Returns: The collection of keys.
    IList<ExportFontInfo> GetValues()
      Description: Returns a collection of the values stored in this table.
      Returns: The collection of values.
    void Remove(ExportFontKey exportFontKey)
      Description: Removes the pair (key, info) by font key.
      @exportFontKey: The export font key.

--------------------------------------------------------------------------------


[CLASS] ExportFontTableIterator
Full Name: Autodesk.Revit.DB.ExportFontTableIterator

Description: An iterator to a set of font table.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<ExportFontKey, ExportFontInfo> Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------


[CLASS] ExportIFCCategoryInfo
Full Name: Autodesk.Revit.DB.ExportIFCCategoryInfo

Description: Represents the mapped IFC information stored in the template.
Implements: IDisposable

  CONSTRUCTORS:
    new ExportIFCCategoryInfo(bool ifcExportFlag, string ifcEntityName, string ifcPredefinedType, string ifcUserDefinedType, string ifcPresentationLayerName)
    new ExportIFCCategoryInfo()

  PROPERTIES:
    string IFCEntityName { get; set; }
      Description: The name of the IFC entity mapped to a particular Revit category.
    bool IFCExportFlag { get; set; }
      Description: The boolean value that indicates whether the category is exported to ifc.
    string IFCPredefinedType { get; set; }
      Description: The name of the predefined type mapped to a particular Revit category.
    string IFCPresentationLayerName { get; set; }
      Description: The name of the presentation layer mapped to a particular Revit category.
    string IFCUserDefinedType { get; set; }
      Description: The name of the user-defined type mapped to a particular Revit category.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsDefault()
      Description: Determines if a ExportIFCCategoryInfo contains default information.
      Returns: True if the ExportIFCCategoryInfo contains only default information.

--------------------------------------------------------------------------------


[CLASS] ExportIFCCategoryKey
Full Name: Autodesk.Revit.DB.ExportIFCCategoryKey

Description: Represents a Revit category item stored in a template.
Implements: IDisposable

  CONSTRUCTORS:
    new ExportIFCCategoryKey(string categoryName, string subCategoryName, CustomSubCategoryId customSubCategoryId)
    new ExportIFCCategoryKey()

  PROPERTIES:
    string CategoryName { get; set; }
      Description: The Revit category name.
    CustomSubCategoryId CustomSubCategoryId { get; set; }
      Description: The Revit custom subcategory id.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string SubCategoryName { get; set; }
      Description: The Revit subcategrory name.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportLayerInfo
Full Name: Autodesk.Revit.DB.ExportLayerInfo

Description: A value used to represent the info stored in the .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportLayerInfo()

  PROPERTIES:
    LayerCategoryType CategoryType { get; set; }
      Description: The category type which this layer belongs to.
    string ColorName { get; set; }
      Description: The color name stored in value. For IFC export, the naming is to match the "colornumber" setting -- really, this stores a string that generates the colorNumber (for formats that don't use the color but need a second entry.)
    int ColorNumber { get; set; }
      Description: The color number stored in value.
    int CutColorNumber { get; set; }
      Description: The cut color number stored in value.
    string CutLayerName { get; set; }
      Description: The cut layer name stored in value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string LayerName { get; set; }
      Description: The layer name stored in value.

  METHODS:
    void AddCutLayerModifier(LayerModifier layerModifier)
      Description: Adds a cut layer modifier to the layer info.
      @layerModifier: The cut layer modifier.
    void AddLayerModifier(LayerModifier layerModifier)
      Description: Adds a project layer modifier to the layer info.
      @layerModifier: The project layer modifier.
    void ClearCutLayerModifiers()
      Description: Clears all the cut layer modifiers stored in the layer info.
    void ClearLayerModifiers()
      Description: Clears all the project layer modifiers stored in the layer info.
    void Dispose()
    IList<LayerModifier> GetCutLayerModifiers()
      Description: Gets all the cut layer modifiers from the layer info.
      Returns: The cut layer modifier array.
    IList<LayerModifier> GetLayerModifiers()
      Description: Gets all the project layer modifiers from the layer info.
      Returns: The project layer modifier array.
    void RemoveCutLayerModifier(LayerModifier layerModifier)
      Description: Removes a cut layer modifier from the layer info.
      @layerModifier: The cut layer modifier.
    void RemoveLayerModifier(LayerModifier layerModifier)
      Description: Removes a project layer modifier from the layer info.
      @layerModifier: The project layer modifier.
    void SetCutLayerModifiers(IList<LayerModifier> cutLayermodifiers)
      Description: Sets a cut layer modifier array to the layer info.
      @cutLayermodifiers: The cut layer modifier array.
    void SetLayerModifiers(IList<LayerModifier> layermodifiers)
      Description: Sets a project layer modifier array to the layer info.
      @layermodifiers: The project layer modifier array.

--------------------------------------------------------------------------------


[CLASS] ExportLayerKey
Full Name: Autodesk.Revit.DB.ExportLayerKey

Description: A key used to represent an item stored in an .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportLayerKey(string categoryName, string subCategoryName, SpecialType num)
    new ExportLayerKey()

  PROPERTIES:
    string CategoryName { get; set; }
      Description: The category name.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SpecialType SpecialType { get; set; }
      Description: The special type for layer key.
    string SubCategoryName { get; set; }
      Description: The subcategrory Name.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportLayerTable
Full Name: Autodesk.Revit.DB.ExportLayerTable

Description: A table supporting a mapping of category and subcategory to layer name and other layer properties that will be set in the target export format.
Remarks: This table is structured as a mapping from to members. The contains the identification information for the layer table: the Revit category and subcategory names. In addition, the key contains a member used only to represent non-Revit categories that can be assigned specific layer information on export. The contains the exported layer name, color name, and layer modifiers for standard and cut representations.The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the returned will be a copy of the from the table. In order to make changes to the and use those settings during export, set the modified back into the table using the same key.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new ExportLayerTable()

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportLayerInfo Item { get; set; }

  METHODS:
    void Add(ExportLayerKey exportLayerKey, ExportLayerInfo exportLayerInfo)
      Description: Inserts a (key,info) pair into Export layer table.
      @exportLayerKey: The export layer key to be added.
      @exportLayerInfo: The export layer info to be added.
    void Clear()
      Description: Removes all contents stored in the table.
    bool ContainsKey(ExportLayerKey exportlayerKey)
      Description: Checks whether a layer key exists in the table.
      @exportlayerKey: The export layer Key.
      Returns: True if the layer key exists in the table.
    void Dispose()
    static IList<ModifierType> GetAvaliableLayerModifierTypes(Document document, ExportLayerKey exportLayerKey)
      Description: Gets all the avaliable layer modifier types for the layer key.
      @document: A Revit document to retrieve avaliable layer modifier types from.
      @exportLayerKey: The export layer key to specify wich category and subCategory will be used to get the layer modifier types.
      Returns: The layer modifier types.
    IEnumerator<KeyValuePair<ExportLayerKey, ExportLayerInfo>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    ExportLayerInfo GetExportLayerInfo(ExportLayerKey exportLayerKey)
      Description: Gets a copy of the layer info associated to the input pattern key.
      @exportLayerKey: The export layer Key.
      Returns: Return the layerInfo for this key.
    IList<ExportLayerKey> GetKeys()
      Description: Gets all the keys stored in the map.
      Returns: Return the key array.
    ExportLayerTableIterator GetLayerTableIterator()
      Description: Returns a LayerTableIterator that iterates through the collection.
      Returns: A LayerTableIterator object that can be used to iterate through key-value pairs in the collection.
    IList<ExportLayerInfo> GetValues()
      Description: Returns all the values stored in the map.
      Returns: Return the info array.
    void Remove(ExportLayerKey exportLayerKey)
      Description: Removes the pair (key, info) by pattern key.
      @exportLayerKey: The export pattern key.

--------------------------------------------------------------------------------


[CLASS] ExportLayerTableIterator
Full Name: Autodesk.Revit.DB.ExportLayerTableIterator

Description: An iterator to a set of Layer table.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<ExportLayerKey, ExportLayerInfo> Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------


[CLASS] ExportLinetypeInfo
Full Name: Autodesk.Revit.DB.ExportLinetypeInfo

Description: A value used to represent the info stored in the .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportLinetypeInfo(string destinationLinetypeName)
    new ExportLinetypeInfo()
    new ExportLinetypeInfo(ExportLinetypeInfo other)

  PROPERTIES:
    string DestinationLinetypeName { get; set; }
      Description: The destination linetype name (the name of the linetype in the exported format).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportLinetypeKey
Full Name: Autodesk.Revit.DB.ExportLinetypeKey

Description: A key used to represent an item stored in an .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportLinetypeKey(string originalLinetypeName)
    new ExportLinetypeKey()
    new ExportLinetypeKey(ExportLinetypeKey other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string OriginalLinetypeName { get; set; }
      Description: The original linetype name.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportLinetypeTable
Full Name: Autodesk.Revit.DB.ExportLinetypeTable

Description: A table supporting a mapping of linetypes in Revit to linetype names that will be set in the target export format.
Remarks: This table is structured as a mapping from to members. The contains the identification information for the pattern table: the Revit linetype name. The contains the linetype name to use in the export format.The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the returned will be a copy of the from the table. In order to make changes to the and use those settings during export, set the modified back into the table using the same key.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new ExportLinetypeTable()

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportLinetypeInfo Item { get; set; }

  METHODS:
    void Add(ExportLinetypeKey exportLinetypeKey, ExportLinetypeInfo exportLinetypeInfo)
      Description: Inserts a (key, info) pair into Export line type table.
      @exportLinetypeKey: The export line type Key to be added.
      @exportLinetypeInfo: The export line type info to be added.
    void Clear()
      Description: Removes all contents stored in Export line type table.
    bool ContainsKey(ExportLinetypeKey exportLinetypeKey)
      Description: Checks whether a pattern key exists in the table.
      @exportLinetypeKey: The export line type key.
      Returns: True if the line type exists in the table.
    void Dispose()
    IEnumerator<KeyValuePair<ExportLinetypeKey, ExportLinetypeInfo>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    ExportLinetypeInfo GetExportLinetypeInfo(ExportLinetypeKey exportLinetypeKey)
      Description: Gets a copy of the ExportLinetypeInfo corresponding to the given ExportLinetypeKey.
      @exportLinetypeKey: The export line type Key.
      Returns: Returns the line type info for this key.
    IList<ExportLinetypeKey> GetKeys()
      Description: Gets all the keys stored in the map.
      Returns: The keys.
    ExportLinetypeTableIterator GetLinetypeTableIterator()
      Description: Returns a ExportLinetypeTableIterator that iterates through the collection.
      Returns: A ExportLinetypeTableIterator object that can be used to iterate through key-value pairs in the collection.
    IList<ExportLinetypeInfo> GetValues()
      Description: Returns all the values stored in the map.
      Returns: The info.
    void Remove(ExportLinetypeKey exportLinetypeKey)
      Description: Removes the pair (key, info) corresponding to the given ExportLinetypeKey.
      @exportLinetypeKey: The export line type key

--------------------------------------------------------------------------------


[CLASS] ExportLinetypeTableIterator
Full Name: Autodesk.Revit.DB.ExportLinetypeTableIterator

Description: An iterator to a set of line type table.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<ExportLinetypeKey, ExportLinetypeInfo> Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------


[CLASS] ExportLineweightInfo
Full Name: Autodesk.Revit.DB.ExportLineweightInfo

Description: A value used to represent the info stored in the .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportLineweightInfo(string destinationLineweightName)
    new ExportLineweightInfo()
    new ExportLineweightInfo(ExportLineweightInfo other)

  PROPERTIES:
    string DestinationLineweightName { get; set; }
      Description: The destination lineweight name (the name of the line weight in the exported format)
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportLineweightKey
Full Name: Autodesk.Revit.DB.ExportLineweightKey

Description: A key used to represent an item stored in an .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportLineweightKey(int originalLineweight)
    new ExportLineweightKey()
    new ExportLineweightKey(ExportLineweightKey other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int OriginalLineweight { get; set; }
      Description: The original line weight.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportLineweightTable
Full Name: Autodesk.Revit.DB.ExportLineweightTable

Description: A table supporting a mapping of line weights in Revit to line weight names that will be set in the target export format.
Remarks: This table is structured as a mapping from to members. The contains the identification information for the pattern table: the Revit line weight. The contains the line weight to use in the export format.The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the returned will be a copy of the from the table. In order to make changes to the and use those settings during export, set the modified back into the table using the same key.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new ExportLineweightTable()

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportLineweightInfo Item { get; set; }

  METHODS:
    void Add(ExportLineweightKey exportLineweightKey, ExportLineweightInfo exportLineweightInfo)
      Description: Inserts a (key, info) pair into Export line weight table.
      @exportLineweightKey: The export line weight Key to be added.
      @exportLineweightInfo: The export line weight info to be added.
    void Clear()
      Description: Removes all contents stored in Export line weight table.
    bool ContainsKey(ExportLineweightKey exportLineweightKey)
      Description: Checks whether a line weight key exists in the table.
      @exportLineweightKey: The export line weight key.
      Returns: True if the line weight exists in the table.
    void Dispose()
    IEnumerator<KeyValuePair<ExportLineweightKey, ExportLineweightInfo>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    ExportLineweightInfo GetExportLineweightInfo(ExportLineweightKey exportLineweightKey)
      Description: Gets a copy of the ExportLineweightInfo corresponding to the given ExportLineweightKey.
      @exportLineweightKey: The export line weight Key.
      Returns: Returns the line weight info for this key.
    IList<ExportLineweightKey> GetKeys()
      Description: Gets all the keys stored in the map.
      Returns: The keys.
    ExportLineweightTableIterator GetLineweightTableIterator()
      Description: Returns a ExportLineweightTableIterator that iterates through the collection.
      Returns: A ExportLineweightTableIterator object that can be used to iterate through key-value pairs in the collection.
    IList<ExportLineweightInfo> GetValues()
      Description: Returns all the values stored in the map.
      Returns: The info.
    void Remove(ExportLineweightKey exportLineweightKey)
      Description: Removes the pair (key, info) corresponding to the given ExportLineweightKey.
      @exportLineweightKey: The export line weight key

--------------------------------------------------------------------------------


[CLASS] ExportLineweightTableIterator
Full Name: Autodesk.Revit.DB.ExportLineweightTableIterator

Description: An iterator to a set of line weight table.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<ExportLineweightKey, ExportLineweightInfo> Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------


[ENUM] ExportPaperFormat
Full Name: Autodesk.Revit.DB.ExportPaperFormat

Description: Paper formats supported by export
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - ANSI_A = 1
    - ANSI_B = 2
    - ANSI_C = 3
    - ANSI_D = 4
    - ANSI_E = 5
    - ISO_A4 = 6
    - ISO_A3 = 7
    - ISO_A2 = 8
    - ISO_A1 = 9
    - ISO_A0 = 10
    - ISO_B4 = 11
    - ISO_B3 = 12
    - ISO_B2 = 13
    - ISO_B1 = 14
    - ARCH_A = 15
    - ARCH_B = 16
    - ARCH_C = 17
    - ARCH_D = 18
    - ARCH_E = 19
    - ARCH_E1 = 20
    - ARCH_E2 = 21
    - ARCH_E3 = 22


[CLASS] ExportPatternInfo
Full Name: Autodesk.Revit.DB.ExportPatternInfo

Description: A value used to represent the info stored in the .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportPatternInfo(string destinationPatternName)
    new ExportPatternInfo()
    new ExportPatternInfo(ExportPatternInfo other)

  PROPERTIES:
    string DestinationPatternName { get; set; }
      Description: The destination pattern name (the name of the pattern in the exported format).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportPatternKey
Full Name: Autodesk.Revit.DB.ExportPatternKey

Description: A key used to represent an item stored in an .
Implements: IDisposable

  CONSTRUCTORS:
    new ExportPatternKey(FillPatternTarget originalFillPatternType, string originalFillPatternName)
    new ExportPatternKey()
    new ExportPatternKey(ExportPatternKey other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string OriginalFillPatternName { get; set; }
      Description: The original FillPattern name.
    FillPatternTarget OriginalFillPatternType { get; set; }
      Description: The original FillPattern type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExportPatternTable
Full Name: Autodesk.Revit.DB.ExportPatternTable

Description: A table supporting a mapping of FillPatterns in Revit to pattern names that will be set in the target export format.
Remarks: This table is structured as a mapping from to members. The contains the identification information for the pattern table: the Revit fill pattern type and name. The contains the pattern name to use in the export format.The table can be accessed via direct iteration as a collection of KeyValuePairs, or by traversal of the stored keys obtained from GetKeys(), or via specific lookup of a key constructed externally. In all cases, the returned will be a copy of the from the table. In order to make changes to the and use those settings during export, set the modified back into the table using the same key.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new ExportPatternTable()

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportPatternInfo Item { get; set; }

  METHODS:
    void Add(ExportPatternKey exportPatternKey, ExportPatternInfo exportPatternInfo)
      Description: Inserts a (key,info) pair into Export pattern table.
      @exportPatternKey: The export pattern key to be added.
      @exportPatternInfo: The export pattern info to be added.
    void Clear()
      Description: Removes all contents stored in the table.
    bool ContainsKey(ExportPatternKey exportpatternKey)
      Description: Checks whether a pattern key exists in the table.
      @exportpatternKey: The export pattern Key.
      Returns: True if the pattern key exists in the table.
    void Dispose()
    IEnumerator<KeyValuePair<ExportPatternKey, ExportPatternInfo>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    ExportPatternInfo GetExportPatternInfo(ExportPatternKey exportPatternKey)
      Description: Gets a copy of the pattern info associated to the input pattern key.
      @exportPatternKey: The export pattern Key.
      Returns: Return the patternInfo for this key.
    IList<ExportPatternKey> GetKeys()
      Description: Gets all the keys stored in the map.
      Returns: Return the key array.
    ExportPatternTableIterator GetPatternTableIterator()
      Description: Returns a PatternTableIterator that iterates through the collection.
      Returns: A PatternTableIterator object that can be used to iterate through key-value pairs in the collection.
    IList<ExportPatternInfo> GetValues()
      Description: Returns all the values stored in the map.
      Returns: Return the info array.
    void Remove(ExportPatternKey exportPatternKey)
      Description: Removes the pair (key, info) by pattern key.
      @exportPatternKey: The export pattern key.

--------------------------------------------------------------------------------


[CLASS] ExportPatternTableIterator
Full Name: Autodesk.Revit.DB.ExportPatternTableIterator

Description: An iterator to a set of Pattern table.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<ExportPatternKey, ExportPatternInfo> Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------


[CLASS] ExportPDFSettings
Full Name: Autodesk.Revit.DB.ExportPDFSettings

Description: Settings for PDF export
Inherits: Element
Implements: IDisposable

  METHODS:
    static ExportPDFSettings Create(Document document, string name, PDFExportOptions options)
      Description: Returns an new created ExportPDFSettings element in the document with specified settings.
      @document: Document where the settings will be created.
      @name: Name to the settings.
      @options: The options to be set.
      Returns: New instance of ExportPDFSettings just created in the document.
    static ExportPDFSettings FindByName(Document document, string name)
      Description: Returns settings element by name.
      @document: The document to find the settings with the specified name.
      @name: Name of the settings to find.
      Returns: The settings element, or if not found.
    static ExportPDFSettings GetActivePredefinedSettings(Document document)
      Description: Gets the active settings element in the document.
      @document: The document to find the active settings.
      Returns: The active settings, or if none.
    PDFExportOptions GetOptions()
      Description: Gets a copy of options from settings for exporting. Modification on this options would not change the element.
      Returns: The options.
    static bool IsValidName(Document document, string name)
      Description: Returns result that the proposed name is valid and not exist in the specified document.
      @document: Document to check
      @name: Name to check.
      Returns: Whether or not the name is valid.
    static IList<string> ListNames(Document document)
      Description: Returns all the names of the settings instances in the document.
      @document: Document where the settings to be found.
      Returns: List of names.
    void SetOptions(PDFExportOptions options)
      Description: Sets options for exporting.
      @options: Other options.

--------------------------------------------------------------------------------


[ENUM] ExportRange
Full Name: Autodesk.Revit.DB.ExportRange

Description: This enum is used to define what view, part of the view, or list of views will be exported.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - CurrentView = 0
    - VisibleRegionOfCurrentView = 1
    - SetOfViews = 2


[ENUM] ExportResolution
Full Name: Autodesk.Revit.DB.ExportResolution

Description: An enumerated type listing possible options to control the tessellation quality.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Custom = 0
    - Fine = 1
    - Medium = 2
    - Coarse = 3


[ENUM] ExportSheetType
Full Name: Autodesk.Revit.DB.ExportSheetType

Description: An enumerated type listing possible Sheet type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Current = 0
    - Visible = 1
    - Select = 2


[ENUM] ExportTextQualifier
Full Name: Autodesk.Revit.DB.ExportTextQualifier

Description: Options for the text qualifier character in schedule view export.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Quote = 1
    - DoubleQuote = 2


[ENUM] ExportUnit
Full Name: Autodesk.Revit.DB.ExportUnit

Description: An enumerated type listing possible target units for CAD Export.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - Inch = 1
    - Foot = 2
    - Millimeter = 3
    - Centimeter = 4
    - Meter = 5


[ABSTRACT CLASS] ExportUtils
Full Name: Autodesk.Revit.DB.ExportUtils

Description: This class provides utilities related to document export.

  METHODS:
    static Guid GetExportId(Subelement subelement)
      Description: Retrieves the GUID representing the subelement in DWF and IFC export.
      @subelement: The subelement.
      Returns: The value of the GUID representing the subelement in the export context.
    static Guid GetExportId(Document document, ElementId elementId)
      Description: Retrieves the GUID representing this element in DWF and IFC export.
      @document: The document.
      @elementId: The id of the element.
      Returns: The value of the GUID representing the element in the export context.
    static Guid GetGBXMLDocumentId(Document document)
      Description: Retrieves the GUID representing this document in exported gbXML files.
      @document: The document.
      Returns: The value of the GUID representing this document in gbXML export.
    static NurbsSurfaceData GetNurbsSurfaceDataForSurface(Surface surface)
      Description: Returns the necessary information to define a NURBS surface for a given or .
      @surface: The HermiteSurface or RuledSurface to be converted.
      Returns: A class containing the necessary data to define a NURBS surface.

--------------------------------------------------------------------------------


[ENUM] ExternalDBApplicationResult
Full Name: Autodesk.Revit.DB.ExternalDBApplicationResult

Description: Informs Autodesk Revit of the status of your external db application after execution.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Succeeded = 0
    - Failed = -1


[CLASS] ExternalDefinition
Full Name: Autodesk.Revit.DB.ExternalDefinition

Description: The ExternalDefinition object adds properties specific to Autodesk Revit shared parameter definitions.
Remarks: The ExternalDefinition object can be created by a definition Group object from a shared parameters file. External parameter definition must belong to a Group which is nothing more than a collection of shared parameter definitions. The following process should be followed to add a parameter to an element: Open the shared parameters file, via the Application.OpenSharedParameterFile() method. Access an existing or create a new group, via the DefinitionFile.Groups property. Access an existing or create a new external parameter definition, via the DefinitionGroup.Definitions property. Create a new Binding object with the categories to which the parameter will be bound using an InstanceBinding or a TypeBinding object. Finally add the binding and definition to the document using the Document.ParameterBindings object.Shared parameters added to elements are typically visible to interactive users. To add data to elements that is never visible to interactive users, use Extensible Storage to construct and populate the needed structured data.
Inherits: Definition
Implements: IDisposable

  PROPERTIES:
    string Description { get; }
      Description: The description of the parameter. The description will be used as tooltip in the Revit UI including in the properties palette.
    Guid GUID { get; }
      Description: Returns the GUID associated with the shared parameter definition.
    bool HideWhenNoValue { get; set; }
      Description: Indicates whether this parameter should be hidden from the properties palette when it has no value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The user visible name for the parameter.
    DefinitionGroup OwnerGroup { get; set; }
      Description: Returns or change the group ID of the external parameter definition.
    bool UserModifiable { get; }
      Description: Indicates whether the parameter can be modified by the user interface.
    bool Visible { get; }
      Description: Indicates if the parameter is visible in the Autodesk Revit user interface.

  METHODS:
    void Dispose()
    ForgeTypeId GetGroupTypeId()
      Description: Returns the identifier of the parameter definition's parameter group.

--------------------------------------------------------------------------------


[CLASS] ExternalDefinitionCreationOptions
Full Name: Autodesk.Revit.DB.ExternalDefinitionCreationOptions

Description: An option class used for creating a new shared parameter definition, including options such as name, type, visibility, Guid description and modifiable flag.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalDefinitionCreationOptions(string name, ForgeTypeId dataType)

  PROPERTIES:
    string Description { get; set; }
      Description: The description of the parameter definition to be created. The description will be used as tooltip in the Revit UI including in the properties palette. The default is an empty string.
    Guid GUID { get; set; }
      Description: The GUID to use for this parameter definition. If not explicitly set, a random GUID is used.
    bool HideWhenNoValue { get; set; }
      Description: This property indicates whether this parameter should be hidden from the properties palette when it doesn't have a value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: The name of the parameter definition to be created.
    bool UserModifiable { get; set; }
      Description: This property indicates whether this parameter can be modified by UI user or not.
    bool Visible { get; set; }
      Description: True if the parameter is visible to the user, false if it is hidden and accessible only via the API. The default is true.

  METHODS:
    void Dispose()
    ForgeTypeId GetDataType()
      Description: Gets the identifier describing the parameter's data type. The identifier may belong to either a spec or a category. If it is a category, the parameter is a Family Type parameter of that category.
    void SetDataType(ForgeTypeId dataType)
      Description: Sets the parameter's data type.
      @dataType: The identifier of either a spec or a category. A category identifier indicates a Family Type parameter of that category.

--------------------------------------------------------------------------------


[CLASS] ExternalDefinitions
Full Name: Autodesk.Revit.DB.ExternalDefinitions

Description: Supports the creation of new shared parameters definitions.
Inherits: Definitions
Implements: IEnumerable`1, IEnumerable, IDisposable

--------------------------------------------------------------------------------


[CLASS] ExternalFileReference
Full Name: Autodesk.Revit.DB.ExternalFileReference

Description: A class that contains the details of a reference to a file outside of a given document.
Implements: IDisposable

  PROPERTIES:
    ExternalFileReferenceType ExternalFileReferenceType { get; }
      Description: The type of external file which this object references.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    PathType PathType { get; }
      Description: The path type of the link (relative, absolute, or server).

  METHODS:
    void Dispose()
    ModelPath GetAbsolutePath()
      Description: Returns an absolute path to the referenced file, regardless of whether the PathType.Enum is relative or absolute.
      Returns: A full path to the linked model.
    LinkedFileStatus GetLinkedFileStatus()
      Description: Returns a LinkedFileStatus.Enum corresponding to the load status of the referenced file.
    ModelPath GetPath()
      Description: Gets the path of the link, relative or absolute according to the link's settings
      Returns: The path of the link. This path will be relative for relatively-pathed links.
    ElementId GetReferencingId()
      Description: Gets the ElementId corresponding to the element which this ExternalFileReference is associated with.
    static bool IsValidExternalFileReference(ExternalFileReference data)
      Description: Checks an ExternalFileReference to see if it is properly created.
      @data: The ExternalFileReference to be checked
    bool IsValidPathTypeForExternalFileReference(PathType pathType)
      Description: Checks whether a PathType enum value will be valid to use with this ExternalFileReference.

--------------------------------------------------------------------------------


[ENUM] ExternalFileReferenceType
Full Name: Autodesk.Revit.DB.ExternalFileReferenceType

Description: Enum class indicating kinds of external file references
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - RevitLink = 1
    - CADLink = 2
    - DWFMarkup = 3
    - KeynoteTable = 4
    - Decal = 5
    - Material = 6
    - AssemblyCodeTable = 7
    - SystemsAnalysisReport = 12


[ABSTRACT CLASS] ExternalFileUtils
Full Name: Autodesk.Revit.DB.ExternalFileUtils

Description: A utility class containing functions related to external file references.
Remarks: Elements which are external file references refer to files outside of the base .rvt file. Examples include Revit links, CAD links, the element which stores the location of the keynote file, and rendering decals.

  METHODS:
    static ICollection<ElementId> GetAllExternalFileReferences(Document aDoc)
      Description: Gets the ids of all elements which are external file references.
      @aDoc: A Revit Document.
      Returns: The ids of all elements which are external file references.
    static ExternalFileReference GetExternalFileReference(Document aDoc, ElementId elemId)
      Description: Gets the external file referencing data for the given element.
      @aDoc: A Revit Document.
      @elemId: The element whose external file reference we want.
      Returns: An object containing path and type information for the given element's external file.
    static string GetFileBasedTempFolder(string filename)
      Description: Gets a temp folder based on the given file name
    static bool IsExternalFileReference(Document aDoc, ElementId elemId)
      Description: Determines whether the given element represents an external file.
      @aDoc: A Revit Document.
      @elemId: The element to be checked for an external file reference.
      Returns: True if the given element represents an external file; false otherwise.

--------------------------------------------------------------------------------


[CLASS] ExternalGeometryId
Full Name: Autodesk.Revit.DB.ExternalGeometryId

Description: This class represents an identifier for geometry from external sources.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalGeometryId(string externalGeometryId)

  PROPERTIES:
    string Id { get; }
      Description: External geometry identifier.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool Equals(object obj)
      Description: Determines whether the specified is equal to the current .
      @obj: Another object.
    int GetHashCode()
      Description: Gets the hash code.
    static bool IsValidExternalGeometryId(string externalGeometryId)
      Description: Checks whether a given string represents a valid ExternalGeometryId or not.
      @externalGeometryId: A string that represents an identifier for an external geometry.
      Returns: True if the string represents a valid ExternalGeometryId, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ExternallyTaggedBRep
Full Name: Autodesk.Revit.DB.ExternallyTaggedBRep

Description: An ExternallyTaggedSolid can hold any shape created by BRepBuilder.
Inherits: ExternallyTaggedGeometryObject
Implements: IDisposable

  METHODS:
    GeometryObject GetTaggedGeometry(ExternalGeometryId externalId)
      Description: Returns the externally tagged geometry object.
      @externalId: An external tag that may match a geometry object (i.e face/edge) in this Solid.
      Returns: Returns the geometry object that matches the external tag. If no such object is found, this method will return null.

--------------------------------------------------------------------------------


[CLASS] ExternallyTaggedGeometryObject
Full Name: Autodesk.Revit.DB.ExternallyTaggedGeometryObject

Description: Base class for ExternallyTaggedGeometryObject and ExternallyTaggedSolid.
Implements: IDisposable

  PROPERTIES:
    ExternalGeometryId ExternalId { get; }
      Description: The external Id of the geometry object.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ExternallyTaggedGeometryValidation
Full Name: Autodesk.Revit.DB.ExternallyTaggedGeometryValidation

Description: Provides validation for geometry to be stored in an ExternallyTaggedGeometry.

  METHODS:
    static bool IsNonSolid(GeometryObject geometry)
      Description: Makes sure that the input geometry object is not a Solid.
      @geometry: Geometry object to be validated.
      Returns: True if the supplied geometry object is not a Solid.
    static bool IsSolid(GeometryObject geometry)
      Description: Makes sure that the input geometry object is a Solid.
      @geometry: Geometry object to be validated.
      Returns: True if the supplied geometry object is a Solid.
    static bool LacksSubnodes(GeometryObject geometry)
      Description: Makes sure that the input geometry object does not have sub-nodes.
      @geometry: Geometry object to be validated.
      Returns: True if the supplied geometry object does not have sub-nodes.

--------------------------------------------------------------------------------


[CLASS] ExternallyTaggedNonBRep
Full Name: Autodesk.Revit.DB.ExternallyTaggedNonBRep

Description: This class is used to create an externally tagged geometry object.
Inherits: ExternallyTaggedGeometryObject
Implements: IDisposable

  CONSTRUCTORS:
    new ExternallyTaggedNonBRep(ExternalGeometryId externalId, GeometryObject geometry)

  METHODS:
    void SetUsage(ExternallyTaggedNonBRepUsage usage)
      Description: Controls the usage of this ExternallyTaggedNonBRep.

--------------------------------------------------------------------------------


[CLASS] ExternallyTaggedNonBReps
Full Name: Autodesk.Revit.DB.ExternallyTaggedNonBReps

Description: Holds a collection of ExternallyTaggedNonBRep instances.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternallyTaggedNonBReps()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Add(ExternallyTaggedNonBRep geometry)
      Description: Adds a copy of the input ExternallyTaggedNonBRep to this collection.
      @geometry: The ExternallyTaggedNonBRep to be added.
    bool CanAddExternallyTaggedNonBRep(ExternallyTaggedNonBRep geometry)
      Description: Checks if the input geometry could be added to this collection or not.
      Returns: True if we can add the input geometry to this collection, false otherwise.
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] ExternallyTaggedNonBRepUsage
Full Name: Autodesk.Revit.DB.ExternallyTaggedNonBRepUsage

Description: The ways in which an ExternallyTaggedNonBRep can be used in Revit.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Displayable = 0
    - Selectable = 1
    - Snappable = 2
    - Referenceable = 3


[CLASS] ExternalResourceBrowserData
Full Name: Autodesk.Revit.DB.ExternalResourceBrowserData

Description: Represents a collection of external resources and external resource folders to be presented as the content of a folder in the file browser in Revit.
Remarks: This data represents the contents to be shown to the user while they are browsing a specific folder in Revit.The folder path can be obtained from the property. The external resource server is expected to populate all of the available resources and subfolders that should appear in the Revit file browser while the browser is open to this particular folder. If the user navigates to another folder, a different ExternalResourceBrowserData object will be provided to allow the server to populate resources at that location.When adding resource and subfolder, the resource and subfolder should not be added recursively.When adding resource and subfolder, the name should be unique short name(without folder). The name of resource and subfolder should not contain any invalid character of \/:*?"<>|.The length of resource combined path(server name + folder path + resource name) should not exceed 259; The length of subfolder also has same restriction.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalResourceBrowserData(Document document, Guid serverId, string folderPath, ExternalResourceMatchOptions matchOptions)

  PROPERTIES:
    string FolderPath { get; }
      Description: The current folder path to which the new resources and subfolder belong.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Guid ServerId { get; }
      Description: The Id of IExternalResourceServer which handles the external resource load.

  METHODS:
    void AddResource(string resourceName, string version, IDictionary<string, string> referenceInformation)
      Description: Adds an external resource to the folder path by supplying the resource name, version and reference information.
      @resourceName: The unique short name of external resource.
      @version: The version of external resource.
      @referenceInformation: The (String, String) map containing reference or lookup information that will be stored in Revit.
    void AddResource(string resourceName, string version)
      Description: Adds an external resource to the folder path by supplying the resource name and version.
      @resourceName: The unique short name of external resource.
      @version: The version of external resource.
    void AddResource(string resourceName, IDictionary<string, string> referenceInformation)
      Description: Adds an external resource to the folder path by supplying the resource name and reference information.
      @resourceName: The unique short name of external resource.
      @referenceInformation: The (String, String) map containing reference or lookup information that will be stored in Revit.
    void AddResource(string resourceName)
      Description: Adds an external resource to the folder path by supplying the resource name.
      @resourceName: The unique short name of external resource.
    void AddSubFolder(string folderName, string iconPath)
      Description: Adds a subfolder to the folder path with the given name and icon type.
      @folderName: The name of the folder.
      @iconPath: Icon path.
    void AddSubFolder(string folderName)
      Description: Adds a subfolder to the folder path with the given name.
      @folderName: The name of the folder.
    bool CallingDocumentHasModelPath()
      Description: Indicates whether the document requesting the external resource browser data has a defined ModelPath.
      Returns: True if the document has a defined ModelPath.
    void Dispose()
    ModelPath GetCallingDocumentModelPath()
      Description: Returns a copy of the ModelPath of the document that is requesting the external resource browser data.
      Returns: A copy of the ModelPath of the document that is requesting the external resource browser data.
    ExternalResourceMatchOptions GetMatchOptions()
      Description: Gets the match options used to filter external resources.
      Returns: The external resource match options.
    IList<ExternalResourceReference> GetResources()
      Description: Gets the external resources under the folder path of the browser data.
      Returns: The external resources under current folder of the browser data.
    IList<ExternalResourceSubFolder> GetSubFoldersData()
      Description: Gets the subfolders data under the folder path of the browser data.
      Returns: The subfolders data under folder path of the browser data.
    bool IsValidFolderName(string folderName)
      Description: Checks whether the folder name is valid.
      @folderName: The folder name to check.
      Returns: True if the name is a valid folder name, false otherwise.
    bool IsValidResourceName(string resourceName)
      Description: Checks whether the resource name is valid.
      @resourceName: The resource name to check.
      Returns: True if the name is a valid resource name, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ExternalResourceLoadContent
Full Name: Autodesk.Revit.DB.ExternalResourceLoadContent

Description: This class contains the actual content data and other results of an external resource load operation that are returned by an IExternalResourceServer to Revit.
Remarks: When Revit calls the LoadResource method for an IExternalResourceServer, Revit will provide an object that is a sub-class of ExternalResourceLoadContent. The IExternalResourceServer will use this object to return the content Revit should use for the external resource. The server can also add information about any errors that occurred during the load operation. This error information will be stored by Revit and later passed to the associated IExternalResourceUIServer (if any) that designates the IExternalResourceServer as its "DBServer" (see the IExternalResourceUIServer.GetDBServerId() method). The IExternalResourceUIServer can then generate any UI that is required for handling the errors that occurred.Note that since different kinds of external resources are expected to return different kinds of data to Revit, a number of ExternalResourceLoadContent sub-classes have been created to handle the data for specific ExternalResourceTypes. This base class contains only a string to indicate the version of the resource data that is being supplied by the server and a status variable to indicate the outcome of a load operation. Revit will always provide the server with an instance of the appropriate sub-class of ExternalResourceLoadContent, with internal data that are relevant to the particular ExternalResourceType that is being loaded.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExternalResourceLoadStatus LoadStatus { get; set; }
      Description: A value to indicate the status of an external resource load operation. IExternalResourceServers should set this in the LoadResource() method.
    string Version { get; set; }
      Description: The version of the external data that the server is providing in this object.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExternalResourceLoadContext
Full Name: Autodesk.Revit.DB.ExternalResourceLoadContext

Description: This class contains data describing the context related to an external resource load operation.
Remarks: Note that automatic loads can occur in the context of other operations such as opening a file. During automatic loads, it is therefore recommended that the server only display UI that is critical for the user to see (such as error message). The loading operation type is Explicit when the user is specifically trying to reload the resource. During explicit loads, it may be desirable to provide more feedback to the user, such as specific feedback that the load operation succeeded.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LoadOperationType LoadOperationType { get; }
      Description: An enum value indicating whether the resource load was triggered by an automatic event (such as file open) or an explicit user action.

  METHODS:
    bool CallingDocumentHasModelPath()
      Description: Indicates whether the document requesting the external resource has a defined ModelPath.
      Returns: True if the document has a defined ModelPath.
    void Dispose()
    ModelPath GetCallingDocumentModelPath()
      Description: Returns a copy of the ModelPath of the document that is requesting the external resource.
      Returns: A copy of the ModelPath of the document that is requesting the external resource.
    ExternalResourceReference GetCurrentlyLoadedReference()
      Description: Returns a copy of the ExternalResourceReference currently in use by the containing element.
      Returns: A copy of the ExternalResourceReference currently in use by the containing element.

--------------------------------------------------------------------------------


[CLASS] ExternalResourceLoadData
Full Name: Autodesk.Revit.DB.ExternalResourceLoadData

Description: This class contains the input and output data resulting from invoking an IExternalResourceServer's LoadResource method.After the call to LoadResource, the resulting ExternalResourceLoadData will be passed into IExternalResourceServer.HandleLoadResourceResults() so that appropriate UI can be displayed. Server providers can inspect the ExternalResourceLoadData to get an ExternalResourceLoadContent object of the subclass appropriate to the external resource. The class also contains a copy of the ExternalResourceReference, and information about the context of the load operation.
Implements: IDisposable

  PROPERTIES:
    bool ErrorsReported { get; set; }
      Description: Indicates whether the IExternalResourceUIServer has reported errors for this ExternalResourceLoadData. This value can be set by the IExternalResourceUIServer in HandleLoadResourceResults().
    ExternalResourceType ExternalResourceType { get; }
      Description: The ExternalResourceType for which Revit is requesting data from the server.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExternalResourceLoadStatus LoadStatus { get; }
      Description: The success or failure status of the load attempt.

  METHODS:
    void Dispose()
    ExternalResourceReference GetExternalResourceReference()
      Description: Returns the ExternalResourceReference that identifies which resource should be loaded.
    ExternalResourceLoadContent GetLoadContent()
      Description: Returns the ExternalResourceLoadContent resulting from this load operation.
      Returns: A reference to an ExternalResourceLoadContent object.
    ExternalResourceLoadContext GetLoadContext()
      Description: Returns an object containing information about the context of the load operation.
      Returns: An object containing information about the context of the load operation.
    Guid GetLoadRequestId()
      Description: Returns the load operation GUID.
      Returns: The load operation GUID.

--------------------------------------------------------------------------------


[ENUM] ExternalResourceLoadStatus
Full Name: Autodesk.Revit.DB.ExternalResourceLoadStatus

Description: A flag to indicate the status of an ExternalResource load request.
Remarks: This flag is returned by the LoadResource method of the IExternalResourceServer class to inform callers whether the load operation succeeded, or encountered an error.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Success = 0
    - Failure = 1
    - Uninitialized = 2
    - ResourceAlreadyCurrent = 3
    - CannotFindServer = 4
    - ServerThrewException = 5


[CLASS] ExternalResourceMatchOptions
Full Name: Autodesk.Revit.DB.ExternalResourceMatchOptions

Description: Represents match options used to filter external resources when listing them from external resource server.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalResourceMatchOptions(ExternalResourceType resourceType)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExternalResourceType ResourceType { get; }
      Description: The desired resource type which external resources should match.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExternalResourceReference
Full Name: Autodesk.Revit.DB.ExternalResourceReference

Description: This class identifies an external resource provided by an IExternalResourceServer.
Remarks: The class contains:The id of the IExternalResourceServer from which the resource was obtained.A (String, String) map containing information that is meaningful to the server for accessing the desired data. This could be something as simple as "4" to indicate that Revit wants option 4 from a range of several choices, or something more detailed, such as a filename or directory path.A String indicating the version of the resource that was most recently loaded in Revit.A (String, String) map containing "in session" information that is meaningful to the server, but which does not need to be saved permanently in the document on disk.When calling an IExternalResourceServer, Revit will provide an ExternalResourceReference to identify the specific resource that Revit is using from that server. The server can then use the relevant information in the (String, String) maps to retrieve the data from the correct source.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalResourceReference(ExternalResourceReference other)
    new ExternalResourceReference(Guid serverId, IDictionary<string, string> referenceInformation, string version, string inSessionPath)

  PROPERTIES:
    string InSessionPath { get; set; }
      Description: The path stores the full display path which includes the server name plus the path provided by ExternalResourceServer.The path that Revit will present for user recognizing and browsing to this resource during one session of Revit.This property allows ExternalResourceServers to handle cases where the path to a resource may vary between Revit sessions. For example, if this ExternalResourceReference refers to a resource in a folder, this property can be used to store the current path of the resource. If the resource is moved to another folder later, the ExternalResourceServer could calculate the correct path for the resource from resource identification information when it is loaded and store it in this property, so that it will work correctly even if the rvt file is opened in a different location.Do not rely on this path to look up an ExternalResourceReference, as the path is neither unique nor stable. It isn't unique because multiple servers might use the same server name and display name format. It isn't stable because some servers allow renaming, and because a server might change its name at some point.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Guid ServerId { get; }
      Description: The id of the server that Revit is expecting to provide the external resource.
    string Version { get; set; }
      Description: The version of the external data that was most recently loaded in Revit.

  METHODS:
    static ExternalResourceReference CreateLocalResource(Document doc, ExternalResourceType resourceType, ModelPath path, PathType pathType)
      Description: Creates an ExternalResourceReference representing a local file managed by Revit's built-in server.
      @doc: The document containing the reference. If the PathType is relative, the path will be made relative to the location of this Document. (If this Document belongs to a workshared model, the reference will be relative to the central model.)
      @resourceType: The type of the external resource.
      @path: A path to the external file. This path must be absolute. If the PathType is relative, then Revit will relativize the path according to the location of the given Document.
      @pathType: An enum indicating the type of path which the ExternalResourceReference should use. The PathType must be PathType.Server if the reference is to a Revit model on Revit Server. The PathType must be PathType.Absolute if the reference is local but the host model or host's central model are on Revit Server.
      Returns: The newly-created ExternalResourceReference.
    void Dispose()
    IDictionary<string, string> GetReferenceInformation()
      Description: Returns a copy of an object containing previously-stored reference or lookup information about the specific resource provided by the server.
      Returns: A copy of a (String, String) map containing previously-stored reference or lookup information.
    string GetResourceShortDisplayName()
      Description: Gets the short display name of the external resource.
      Returns: The short display name of the external resource.
    ResourceVersionStatus GetResourceVersionStatus()
      Description: Checks whether this ExternalResourceReference corresponds to the current version of the resource.
      Returns: An enum indicating whether this reference represents the most recent version of the resource.
    bool HasValidDisplayPath()
      Description: Checks whether this external Resource has a valid display path.
      Returns: True if the this external Resource has a valid display path. False otherwise.
    bool IsValidReference(ExternalResourceType resourceType)
      Description: Checks whether the reference is in a valid format.
      @resourceType: The type of resource which the ExternalResourceReference should correspond to.
      Returns: True if this is a valid ExternalResourceReference. False otherwise.

--------------------------------------------------------------------------------


[CLASS] ExternalResourceServerExtensions
Full Name: Autodesk.Revit.DB.ExternalResourceServerExtensions

Description: An object that contains overrides for external resource-specific methods.
Remarks: This class permits assignment of some specific operations related to a type of external resource, such as what to do when "Open (and Unload)" happens, or when "Shared Coordinates update" happens for Revit or CAD links. There is no feedback to the UI server for ExternalResourceServerExtensions. Revit will use standard, common message dialogs to handle any error conditions.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    CADLinkOperations GetCADLinkOperations()
      Description: Gets the specific methods supported by external resource CAD Links.
      Returns: The specific methods supported by external resource CAD Links.
    RevitLinkOperations GetRevitLinkOperations()
      Description: Gets the specific methods supported by the external resource of Revit Links.
      Returns: The specific methods supported by the external resource of Revit Links.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ExternalResourceServerUtils
Full Name: Autodesk.Revit.DB.ExternalResourceServerUtils

Description: Contains utilities related to external resource server.

  METHODS:
    static bool IsValidShortName(Guid serverId, string serverName)
      Description: Checks whether the name is a valid short name for the external resource server.
      @serverId: The id of the external resource server.
      @serverName: The short name of the external resource server.
      Returns: True if the name is a valid short name, false otherwise.
    static bool ServerSupportsAssemblyCodeData(ExternalResourceReference extRef)
      Description: Checks that the server referenced by the given ExternalResourceReference supports AssemblyCodeData.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference refers to a server that supports AssemblyCodeData. False otherwise.
    static bool ServerSupportsCADLinks(ExternalResourceReference extRef)
      Description: Checks that the server referenced by the given ExternalResourceReference supports CAD links.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference refers to a server that supports CAD links. False otherwise.
    static bool ServerSupportsIFCLinks(ExternalResourceReference extRef)
      Description: Checks that the server referenced by the given ExternalResourceReference supports IFC links.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference refers to a server that supports IFC links. False otherwise.
    static bool ServerSupportsKeynotes(ExternalResourceReference extRef)
      Description: Checks that the server referenced by the given ExternalResourceReference supports KeynoteTable data.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference refers to a server that supports keynotes. False otherwise.
    static bool ServerSupportsRevitLinks(ExternalResourceReference extRef)
      Description: Checks that the server referenced by the given ExternalResourceReference supports Revit links.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference refers to a server that supports Revit links. False otherwise.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ExternalResourceServiceUtils
Full Name: Autodesk.Revit.DB.ExternalResourceServiceUtils

Description: Contains utilities related to external resource service.

  METHODS:
    static IList<IExternalResourceServer> GetServersByType(ExternalResourceType type)
      Description: Gets registered external resource servers which support the external resource type.
      @type: The external resource type for the servers to match
      Returns: A list of matched external resource servers

--------------------------------------------------------------------------------


[CLASS] ExternalResourceSubFolder
Full Name: Autodesk.Revit.DB.ExternalResourceSubFolder

Description: Data that describes a remote folder to be shown in the file browser dialog
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalResourceSubFolder(string folderName, string iconPath)
    new ExternalResourceSubFolder()

  PROPERTIES:
    string FolderName { get; set; }
      Description: Folder displayed name.
    string IconPath { get; set; }
      Description: The path of the resource icon.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ExternalResourceType
Full Name: Autodesk.Revit.DB.ExternalResourceType

Description: A type class used to distinguish between different kinds of external resource.
Remarks: Revit elements can consume multiple types of external resource data, provided by one or more external servers. Conversely, external servers can support one, or more than one, type of external resource.
Inherits: GuidEnum

  CONSTRUCTORS:
    new ExternalResourceType(Guid guid)

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ExternalResourceTypes
Full Name: Autodesk.Revit.DB.ExternalResourceTypes

Description: Provides a container of all Revit built-in ExternalResourceType instances.

--------------------------------------------------------------------------------


[ENUM] ExternalResourceUIBrowseResultType
Full Name: Autodesk.Revit.DB.ExternalResourceUIBrowseResultType

Description: Describes the type of external resource browsing result.
Remarks: This enum is used to describe the type of external resources browsing operation result ( the browsing operation include list folders and resources of an external server or a folder, or open an external resource in browsing dialog.) The meaning of each enum value: There is no predefined error happened during this browse operation. The DB server can store any errors itself in this case. FolderNotFound means the external resource folder want to browse could not be founded in external server. ResourceNotFound means the external resource want to open could not be founded in external server.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Success = 0
    - FolderNotFound = 1
    - ResourceNotFound = 2


[ABSTRACT CLASS] ExternalResourceUtils
Full Name: Autodesk.Revit.DB.ExternalResourceUtils

Description: A utility class containing functions related to external resource references.
Remarks: Elements which are external resource references refer to data outside of the base .rvt file. Examples include Revit links and the keynote table data.

  METHODS:
    static ISet<ElementId> GetAllExternalResourceReferences(Document document, ExternalResourceType resourceType)
      Description: Gets the ids of all elements which refer to a specific type of external resource.
      @document: The Revit Document containing the external resource references.
      @resourceType: The type of external resource.
      Returns: The ids of all elements which refer to external resources of the specified type.
    static ISet<ElementId> GetAllExternalResourceReferences(Document document)
      Description: Gets the ids of all elements which refer to external resources.
      @document: The Revit Document containing the external resource references.
      Returns: The ids of all elements which refer to external resources.

--------------------------------------------------------------------------------


[CLASS] Extrusion
Full Name: Autodesk.Revit.DB.Extrusion

Description: A extrusion solid or void form.
Inherits: GenericForm
Implements: IDisposable

  PROPERTIES:
    double EndOffset { get; set; }
      Description: The offset of the end of the extrusion relative to the sketch plane.
    Sketch Sketch { get; }
      Description: Returns the Sketch of the Extrusion.
    double StartOffset { get; set; }
      Description: The offset of the start of the extrusion relative to the sketch plane.

--------------------------------------------------------------------------------


[CLASS] ExtrusionAnalyzer
Full Name: Autodesk.Revit.DB.ExtrusionAnalyzer

Description: This geometry utility allows you to attempt to "fit" a given piece of geometry into the shape of an extrusion.
Remarks: An instance of this class is a single-time use class which should be supplied a solid geometry, a plane, and a direction. The utility will calculate a base boundary parallel to the input plane which is the outer boundary of the shadow cast by the solid onto the input plane and along the extrusion direction. After the extrusion has been calculated, the class permits a second step analysis to identify all faces from the original geometry which do not align with the faces of the calculated extrusion.This utility works best for geometry which are at least somewhat "extrusion-like", for example, the geometry of a wall which may or may not be affected by end joins, floor joins, roof joins, openings cut by windows and doors, or other modifications.The ExtrusionAnalyzer expects only one single extrusion-like solid geometry. The ExtrusionAnalyzer does not support a Geometry containing multiple solids.
Implements: IDisposable

  PROPERTIES:
    double EndParameter { get; }
      Description: The end parameter (distance along the extrusion direction from the input plane) calculated by the extrusion analysis.
    XYZ ExtrusionDirection { get; }
      Description: The direction of extrusion specified for the extrusion analysis.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double StartParameter { get; }
      Description: The start parameter (distance along the extrusion direction from the input plane) calculated by the extrusion analysis.

  METHODS:
    IDictionary<Face, ExtrusionAnalyzerFaceAlignment> CalculateFaceAlignment()
      Description: Calculates the alignment status of each face of the solid.
      Returns: Maps each face of the solid to its alignment status.
    static ExtrusionAnalyzer Create(Solid solidGeometry, Plane plane, XYZ direction)
      Description: Creates an ExtrusionAnalyzer and computes and stores the solid's shadow.
      @solidGeometry: The geometry to analyze.
      @plane: The plane to use for the base plane for the extrusion.
      @direction: The direction to use for the calculation for the extrusion. The direction must be transverse to the base plane.
      Returns: The newly created ExtrusionAnalyzer object.
    void Dispose()
    Face GetExtrusionBase()
      Description: Obtains the face that represents the base contour of the extrusion analysis.
      Returns: The face that represents the base contour.

--------------------------------------------------------------------------------


[ENUM] ExtrusionAnalyzerFaceAlignment
Full Name: Autodesk.Revit.DB.ExtrusionAnalyzerFaceAlignment

Description: Indicates whether a face of the solid analyzed by ExtrusionAnalyzer is fully aligned, partially aligned, or unaligned with faces of the extrusion.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FullyAligned = 0
    - PartiallyAligned = 1
    - Unaligned = 2


[CLASS] ExtrusionRoof
Full Name: Autodesk.Revit.DB.ExtrusionRoof

Description: Represents some kinds of Extrusion Roofs.
Remarks: The ExtrusionRoof object represents some kinds of extruded roofs in Revit.
Inherits: RoofBase
Implements: IDisposable

  PROPERTIES:
    CurtainGridSet CurtainGrids { get; }
      Description: Retrieve all the CurtainGrid objects of a curtain Roof.

  METHODS:
    ModelCurveArray GetProfile()
      Description: Retrieve the Profile of ExtrusionRoof.

--------------------------------------------------------------------------------

