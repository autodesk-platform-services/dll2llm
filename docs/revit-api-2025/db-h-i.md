# Autodesk.Revit.DB (Types: H, I)

[CLASS] HasNoValueFilterRule
Full Name: Autodesk.Revit.DB.HasNoValueFilterRule

Description: Tests whether an element's parameter doesn't have a value.
Inherits: ParameterValuePresenceRule
Implements: IDisposable

  CONSTRUCTORS:
    new HasNoValueFilterRule(ElementId parameter)

--------------------------------------------------------------------------------


[CLASS] HasValueFilterRule
Full Name: Autodesk.Revit.DB.HasValueFilterRule

Description: Tests whether an element's parameter has a value.
Inherits: ParameterValuePresenceRule
Implements: IDisposable

  CONSTRUCTORS:
    new HasValueFilterRule(ElementId parameter)

--------------------------------------------------------------------------------


[CLASS] HermiteFace
Full Name: Autodesk.Revit.DB.HermiteFace

Description: A cubic hermite spline face of a 3d solid or open shell.
Remarks: Hermite faces are defined by cubic hermite spline surfaces bounded by edge loops. The surfaces provide natural UV parameterization to the faces.
Inherits: Face
Implements: IDisposable

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
Implements: IDisposable

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
    static HermiteSpline Create(IList<XYZ> controlPoints, bool periodic)
      Description: Creates a Hermite spline with default tangency at its endpoints.
      @controlPoints: The control points of the Hermite spline.
      @periodic: True if the Hermite spline is to be periodic, false otherwise.
      Returns: The new HermiteSpline object.

--------------------------------------------------------------------------------


[CLASS] HermiteSplineTangents
Full Name: Autodesk.Revit.DB.HermiteSplineTangents

Description: This class indicates tangency at the start, the end, or both ends of the curve.
Remarks: Initially, the tangent vectors will not be set, and no tangency condition will be imposed when the curve is created.
Implements: IDisposable

  CONSTRUCTORS:
    new HermiteSplineTangents()

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
Implements: IDisposable

  METHODS:
    static HermiteSurface Create(int nU, int nV, IList<XYZ> points, bool periodicU, bool periodicV)
      Description: Create a Hermite surface using a net of 3D points as input. Specify periodicity in U and V direction.
      @nU: Number of points in U direction.
      @nV: Number of points in V direction.
      @points: Array of points. Must contain nU*nV points.
      @periodicU: Periodicity in U direction
      @periodicV: Periodicity in V direction
      Returns: A Hermite surface object created from input data.
    static HermiteSurface Create(int nU, int nV, IList<XYZ> points)
      Description: Create a non-periodic Hermite surface using a net of 3D points as input.
      @nU: Number of points in U direction.
      @nV: Number of points in V direction.
      @points: Array of points. Must contain nU*nV points.
      Returns: A Hermite surface object created from input data.
    bool IsValid()
      Description: Checks whether this HermiteSurface object is valid.
      Returns: True if this is a valid Hermite Surface, false otherwise.

--------------------------------------------------------------------------------


[ENUM] HiddenLineViewsType
Full Name: Autodesk.Revit.DB.HiddenLineViewsType

Description: An enumerated type listing all Hidden Line Views types of Print Setting.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - VectorProcessing = 0
    - RasterProcessing = 1


[CLASS] HomeCamera
Full Name: Autodesk.Revit.DB.HomeCamera

Description: A structure that contains information about the camera and view for the Home view orientation stored in the model.
Implements: IDisposable

  CONSTRUCTORS:
    new HomeCamera(HomeCamera other)

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Left = 64
    - Center = 128
    - Right = 256


[ENUM] HorizontalAlignmentStyle
Full Name: Autodesk.Revit.DB.HorizontalAlignmentStyle

Description: Declares the horizontal alignment style of font.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Left = 0
    - Center = 1
    - Right = 2


[ENUM] HorizontalTextAlignment
Full Name: Autodesk.Revit.DB.HorizontalTextAlignment

Description: Supported types of horizontal alignment of a text element and text justification within the text containing box.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Left = 0
    - Right = 1
    - Center = 2


[ABSTRACT CLASS] HostedSweep
Full Name: Autodesk.Revit.DB.HostedSweep

Description: An object that represents an object hosted by an edge of a roof or floor within the Autodesk Revit project.
Inherits: HostObject
Implements: IDisposable

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
    void HorizontalFlip()
      Description: Flip the hosted sweep object along horizontal line.
    void RemoveSegment(Reference targetRef)
      Description: Remove segments from the hosted sweep object.
      @targetRef: Segment's reference which want to be removed.
    bool SetEndPointParameter(Reference targetRef, int endIdx, double param)
      Description: Set segment's start point or end point parameter.
      @targetRef: Segment's reference whose parameter want to be set.
      @endIdx: Start point (=0) or end point (=1).
      @param: Value of parameter.
      Returns: true if operation success.
    void VerticalFlip()
      Description: Flip the hosted sweep object along vertical line.

--------------------------------------------------------------------------------


[CLASS] HostedSweepType
Full Name: Autodesk.Revit.DB.HostedSweepType

Description: An object that represents the attributes for sweep host objects in Autodesk Revit.
Inherits: HostObjAttributes
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] HostObjAttributes
Full Name: Autodesk.Revit.DB.HostObjAttributes

Description: An object that represents characteristics of several kinds of type.
Remarks: This object provides access to structural layering components for any object derived from it, such as wall types and floor types.
Inherits: ElementType
Implements: IDisposable

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
Implements: IDisposable

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
    static IList<Reference> GetSideFaces(HostObject hostObject, ShellLayerType side)
      Description: Returns the major side faces for this host object.
      @hostObject: The host object.
      @side: The side of the host object.
      Returns: An array of references to the faces which are on the given side of this element.
    static IList<Reference> GetTopFaces(HostObject hostObject)
      Description: Returns the top faces for this host object.
      @hostObject: The host object.
      Returns: An array of references to the faces which are at the top of this element.

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
Remarks: An instance of a class that implements this interface is passed in as a parameter of the constructor. The methods of the context are then called at times of exporting entities of the model. This is a base class for two other interfaces derived from it: and . This base class contains methods that are common to both the leaf interfaces. Although it is still possible to use classes deriving directly from this base interface (for backward compatibility), future applications should implement the new leaf interfaces only.

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
Remarks: An instance of a class that implements this interface is passed in as a parameter of the constructor. The interface methods are then called at times of drawing entities that are currently visible in the view being exported. With this type of export context used to perform a custom export, Revit will traverse the model and output the model's geometry as if in the process of regular displaying or exporting a 2D View. It means that any geometry which is visible in an open view (taking any current visibility setting applicable to the view) will be processed and output. Optionally, annotation objects are also output. Note 1. Curves passed to calls and may be partially duplicating each other. Note 2. If element E is a FamilyInstance and it contains an imported instance then: between the calls to OnElementBegin2D/OnElementEnd2D for element E there will be calls to OnInstanceBegin/OnInstanceEnd with the "node" argument pointing to the element with its symbol being of category BuiltInCategories.OST_ImportObjectStylesall geometry exported for the element E has to be additionally subject to the transform T=E.GetTotalTransform()
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
Remarks: Certain resources used in a Revit model are stored outside of the .rvt file. For example, the data used for keynotes, images used as decals during rendering, CAD links, and Revit links are all stored outside the model. Creating a new implementation of this server allows the server to supply one or more types of such resources from an arbitrary source. For example, a server could provide the keynote data from a database or from a file format that Revit does not support.If a model references resources supplied by this server, Revit will request the resource from the server when it is required. Most external resources are loaded into memory at the time the model is loaded. The server will also be invoked if the resource is explicitly reloaded.IExternalResourceServer can declare that a resource is already up-to-date via If the resource is up-to-date, Revit will skip loading to improve performance. Each resource load request will be associated with a GUID, so that server implementers can uniquely identify a given load request. This may be useful to, for example, store server-side errors associated with an attempt to load a particular resource.If your server handles Revit or CAD links, you must take special care with link paths. When one of these file types is uploaded to your server, any nested references should be brought to the server along with the main link. Your server will need to repath any nested reference itself; Revit will not handle this automatically.In the case of DWG links, your server will also need to download and possibly repath any xrefs when LoadResource is called for the top-level link. Revit will only request the top-level link directly. In the case of Revit links, the ExternalResourceReferences for any nested links will also need to be modified in the host document. The host document should reference the Revit links at their server locations, not their local file locations. Revit may not be able to find links if the paths are not set up correctly. See to inspect the set of links contained within a Revit model. See to reload a Revit link from a server version.Here is an example which uses nested Revit links: A user has a Revit model containing one link, Link.rvt, which contains one nested link, Nest.rvt. The user uploads Link.rvt to a server, using an add-in provided by that server. The server provider must also take Nest.rvt. Further, the server provider must open Link.rvt and modify the reference to Nest.rvt so that it references the version on the server. Otherwise, Revit will not be able to find Nest.rvt when another user tries to load Link.rvt from the server.The external resource framework has been designed to allow server authors to display UI related to the resource load operation and UI browse operation. No UI should be displayed directly from an IExternalResourceServer. Instead, developers should create an IExternalResourceUIServer which will handle UI tasks on behalf of the IExternalResourceServer. For more information, see the documentation for the and methods.
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
Remarks: If the family is not loaded, or if the family is loaded but unchanged, the situation will never trigger and and will not be called. Only if the family is loaded and changed should the interface methods be called.

  METHODS:
    bool OnFamilyFound(bool familyInUse, out bool overwriteParameterValues)
    bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)

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
Implements: IDisposable

  CONSTRUCTORS:
    new IFCCategoryTemplate(Document document)

  METHODS:
    IFCCategoryTemplate CopyTemplate(Document document, string copyTemplateName)
      Description: Create copy of mapping template with new name.
      @document: A Revit document.
      @copyTemplateName: A name for copied template name.
      Returns: The copied mapping template element.
    static IFCCategoryTemplate Create(Document document, string name)
      Description: Create a IFC category mapping template with default values.
      @document: Document where created mapping template is saved.
      @name: The name specified to this mapping template.
      Returns: The new mapping template instance.
    void ExportToFile(Document document, string fileName)
      Description: Export mapping template to a text file.
      @document: A Revit document.
      @fileName: A full text file name.
    static IFCCategoryTemplate FindByName(Document document, string name)
      Description: Returns mapping template element by name.
      @document: The document to find the mapping template with the specified name.
      @name: Name of the mapping template to find.
      Returns: The mapping template element, or if not found.
    static IFCCategoryTemplate GetActiveTemplate(Document document)
      Description: Gets the active mapping template element in the document.
      @document: The document to find the active mapping template.
      Returns: The active mapping template, or if none.
    IDictionary<ExportIFCCategoryKey, ExportIFCCategoryInfo> GetCategoryMappingTable(Document document)
      Description: Gets the table that contains a mapping from Revit categories to IFC entities.
      @document: The document.
      Returns: The mapping table.
    ExportIFCCategoryInfo GetMappingInfoById(Document document, ElementId categoryId, CustomSubCategoryId customSubCategoryId)
      Description: Gets a copy of ifc mapping info by category id.
      @document: A Revit document.
      @categoryId: The category id.
      @customSubCategoryId: The custom subcategory id.
      Returns: Return the info for this category.
    static IFCCategoryTemplate GetOrCreateInSessionTemplate(Document document)
      Description: Gets the in-session non-serializable template or create new.
      @document: The document to find the in-session mapping template.
      Returns: The mapping template, or if none.
    static IFCCategoryTemplate ImportFromFile(Document document, string fileName, string templateName)
      Description: Import mapping template from a text file.
      @document: A Revit document.
      @fileName: A full text file name.
      @templateName: A mapping template name.
      Returns: The mapping template element.
    static bool IsValidName(Document document, string name)
      Description: Returns result that the proposed name is valid and not exist in the specified document.
      @document: Document to check
      @name: Name to check.
      Returns: Whether or not the name is valid.
    static IList<string> ListNames(Document document)
      Description: Returns a list of names of ifc export mapping templates.
      @document: A Revit document to retrieve names from.
      Returns: An array of strings representing names of predefined setups.
    static void ResetActiveTemplate(Document document)
      Description: Sets the mapping template element to be the active mapping template in the document.
      @document: The document to set.
    ExportIFCCategoryInfo ResetCategoryToDefault(ExportIFCCategoryKey categoryKey)
      Description: Reset one category, sub-category, or special category in the current mapping table to the default values defined in Revit
      @categoryKey: The selected category information.
      Returns: The default information.
    void SetActiveTemplate(Document document)
      Description: Sets the mapping template element to be the active mapping template in the document.
      @document: The document to set.
    void SetMappingInfo(ExportIFCCategoryKey key, ExportIFCCategoryInfo info)
      Description: Set the mapping info for the key.
      @key: The key.
      @info: The info.
    void SetMappingInfo(IDictionary<ExportIFCCategoryKey, ExportIFCCategoryInfo> newMap)
      Description: Set the mapping info for multiple keys.
      @newMap: The updated map.
    void UpdateCategoryList(Document document)
      Description: Updates the mapping table with the categories from the document.
      @document: A Revit document to retrieve names from.

--------------------------------------------------------------------------------


[ENUM] IFCExportElement
Full Name: Autodesk.Revit.DB.IFCExportElement

Description: An enumerated type defining if an element is exported to IFC or not.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ByType = 0
    - Yes = 1
    - No = 2


[ENUM] IFCExportElementType
Full Name: Autodesk.Revit.DB.IFCExportElementType

Description: An enumerated type defining if an element type is exported to IFC or not.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - Yes = 1
    - No = 2


[CLASS] IFCExportOptions
Full Name: Autodesk.Revit.DB.IFCExportOptions

Description: IFC Export options.
Implements: IDisposable

  CONSTRUCTORS:
    new IFCExportOptions(IFCExportOptions from)
    new IFCExportOptions()

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
    void Assign(IFCExportOptions sourceOptions)
      Description: Assigns the values of the IFCExportOptions to this options object.
      @sourceOptions: The source IFCExportOptions.
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] IFCVersion
Full Name: Autodesk.Revit.DB.IFCVersion

Description: An enumerated type listing available IFC file versions into which a file may be exported.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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
Implements: IDisposable

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
    IList<ElementId> GetViewsAndSheets()
      Description: Gets a list of views and sheets to be exported. Used only when ExportRange is SetOfViews.
      Returns: The ids of the views and sheets.
    static bool IsValidFileName(string filePath)
      Description: Verify if File name is valid
      @filePath: File path to be tested for valid file name
      Returns: True if File name is valid; false otherwise
    static bool IsValidForSaveToProjectAsImage(ImageExportOptions options, Document doc)
      Description: Verify if ImageExportOptions object is valid for calling saveToProjectAsImage
      @options: ImageExportOptions object to be validated
      @doc: Document for view name verification
      Returns: True if ImageExportOptions object is valid for calling saveToProjectAsImage; false otherwise
    void SetViewsAndSheets(IList<ElementId> viewsAndSheets)
      Description: Sets a list of views and sheets to be exported. Used only when ExportRange is SetOfViews.
      @viewsAndSheets: The ids of the views and sheets.

--------------------------------------------------------------------------------


[ENUM] ImageFileType
Full Name: Autodesk.Revit.DB.ImageFileType

Description: This enum is used to define exported file type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BMP = 0
    - JPEGLossless = 1
    - JPEGMedium = 2
    - JPEGSmallest = 3
    - PNG = 4
    - TARGA = 5
    - TIFF = 6


[CLASS] ImageInstance
Full Name: Autodesk.Revit.DB.ImageInstance

Description: An element that represents an instance of an image placed in a view
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool CanHaveSnaps { get; }
      Description: When true the ImageInstance has snaps that can be enabled with the property
    DrawLayer DrawLayer { get; set; }
      Description: The layer the ImageInstance will be drawn in.
    bool EnableSnaps { get; set; }
      Description: When true the ImageInstance will have its snaps enabled, but only if is true
    double Height { get; set; }
      Description: The height of the ImageInstance.
    double HeightScale { get; set; }
      Description: The factor applied to the to calculate the of the ImageInstance.
    bool LockProportions { get; set; }
      Description: When true the proportion of to will be maintained
    double Width { get; set; }
      Description: The width of the ImageInstance.
    double WidthScale { get; set; }
      Description: The factor applied to the width of the to calculate the of the ImageInstance.

  METHODS:
    static ImageInstance Create(Document document, View view, ElementId imageTypeId, ImagePlacementOptions placementOptions)
      Description: Creates a new ImageInstance element placed in a view.
      @document: The document.
      @view: The view in which the image will be placed.
      @imageTypeId: The id of the element for this ImageInstance.
      @placementOptions: Options that specify where the ImageInstance should be placed.
      Returns: The new ImageInstance.
    XYZ GetLocation(BoxPlacement placementPoint)
      Description: Returns the location of one of the points of the ImageInstance
      @placementPoint: The placementPoint specifies for which point of the ImageInstance the location should be returned.
      Returns: The location of the specified point
    static bool IsValidView(View view)
      Description: Check that the view is a valid view for ImageInstance elements
      @view: The view to validate
      Returns: True if the view can contain ImageInstance elements. False otherwise.
    void SetLocation(XYZ newLocation, BoxPlacement placementPoint)
      Description: Moves the ImageInstance to the specified location
      @newLocation: The new location of the specified point
      @placementPoint: The placementPoint specifies which point of the ImageInstance should be placed at the given location.

--------------------------------------------------------------------------------


[CLASS] ImagePlacementOptions
Full Name: Autodesk.Revit.DB.ImagePlacementOptions

Description: ImagePlacementOptions are used to describe where an should be placed in a view
Implements: IDisposable

  CONSTRUCTORS:
    new ImagePlacementOptions(XYZ location, BoxPlacement placementPoint)
    new ImagePlacementOptions()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Location { get; set; }
      Description: The location in the model where a point of the , determined by the property, is going to be inserted.
    BoxPlacement PlacementPoint { get; set; }
      Description: Identifies which point of the will be aligned to the

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] ImageResolution
Full Name: Autodesk.Revit.DB.ImageResolution

Description: This enum is used to define image resolution in order to calculate the image size.
Remarks: This is used only if the Zoom option for ZoomType is set.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - DPI_72 = 0
    - DPI_150 = 1
    - DPI_300 = 2
    - DPI_600 = 3


[CLASS] ImageType
Full Name: Autodesk.Revit.DB.ImageType

Description: Represents a type containing a raster based image. ImageInstances of this type can be placed in 2D views, sheets, and schedules.
Remarks: ImageType elements are created with the ImageType.Create(Document, ImageTypeOptions) method.ImageType elements can be loaded from the following file types: *.bmp, *.jpg, *.jpeg, *.png, *.tif.In addition, when PDF support is available, ImageType elements can also be loaded from *.pdf files. See:
Inherits: ElementType
Implements: IDisposable

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
    Bitmap GetImage()
      Description: Get the bitmap image stored in the image symbol.
      Returns: The bitmap image at the original loaded image size.
    void Reload()
      Description: Reloads the ImageType from the file found at the location specified by the property, using the same and resolution.
    void ReloadFrom(ImageTypeOptions options)
      Description: Reloads the image in the ImageType from a new image file, and for a new .
      @options: Options that specify what image to load.
    void Unload()
      Description: Unload the linked image.

--------------------------------------------------------------------------------


[CLASS] ImageTypeOptions
Full Name: Autodesk.Revit.DB.ImageTypeOptions

Description: Represents the options used in ImageType::Create(Document, ImageTypeOptions) and ImageType.ReloadFrom(ImageTypeOptions) methods.
Remarks: ImageTypeOptions are used to describe how an ImageType should be created from an image file.ImageTypeOptions are used to specify the location of the image file to use for the image using either a string path or an .ImageTypeOptions are used to specify if the file path should be stored as an absolute path, or a relative path. A relative path is relative to the location of the project file, unless the file is workshared, in which case the relative path is relative to the location of the central file. Note that the relative path option is only available if the project file has been saved. ImageTypeOptions are used to specify whether the image should be imported or linked. For imported images the image data is added to the Revit project file. For linked images the image data is reloaded everytime the project file is opened. Linked images are only available if they were reloaded successfully, while imported images are always available.For PDF files the ImageTypeOptions can be used to specify which page in the PDF file to use for the image. For raster based image files the page number must be 1 (the default).ImageTypeOptions can be used to specify the resolution (in pixels per inch) to use for the image. For PDF files the resolution is used to determine how many pixels to use when rasterizing the PDF page. Using a higher resolution will increase the number of pixels. This will add more detail, but it will also make rendering the image slower. In addition, it will likely increase the amount of data stored in the project when the image is imported.Raster based images have a fixed number of pixels. As a result, the resolution has no effect on the amount of detail or the amount of data that is stored. The resolution is only used to determine the size of image. Doubling the resolution will make the image appear half the size.When a file is accessed with the help of an external server, it is likely that a local cache of the file will be created temporarily. ImageTypeOptions may refer to the cached copy of the file internally. For this reason, ImageTypeOptions should be treated as a transient object whose purpose is to become an argument to ImageType.Create(Document, ImageTypeOptions) or ImageType.ReloadFrom(ImageTypeOptions). An application should not create an ImageTypeOptions object and hold onto it for a long time.
Implements: IDisposable

  CONSTRUCTORS:
    new ImageTypeOptions(ExternalResourceReference resourceReference, ImageTypeSource sourceType)
    new ImageTypeOptions(string path, bool useRelativePath, ImageTypeSource sourceType)

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
    void SetExternalResourceReference(ExternalResourceReference resourceReference)
      Description: Update the external resource reference to an image.
      @resourceReference: An external resource reference to an image.
    void SetPath(string path, bool useRelativePath)
      Description: Update the path of the file that specifies the image to be used.The provided string path must specify a local file. The path can be absolute or relative to the project's location.Additionally, indicate whether the path used by ImageType should be absolute or relative.
      @path: The file path that specifies the image to be used.
      @useRelativePath: True if ImageType should use a relative path, false otherwise.
    void SetPath(string path)
      Description: Update the path of the file that specifies the image to be used.The provided string path must specify a local file. The path can be absolute or relative to the project's location. ImageType will respectively use an absolute or relative path.
      @path: The file path that specifies the image to be used.

--------------------------------------------------------------------------------


[ENUM] ImageTypeSource
Full Name: Autodesk.Revit.DB.ImageTypeSource

Description: The source of the data used to generate the image.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Link = 0
    - Import = 1
    - Internal = 2


[ENUM] ImageTypeStatus
Full Name: Autodesk.Revit.DB.ImageTypeStatus

Description: Indicates the current state of the contents of the ImageType.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Unknown = 0
    - Loaded = 1
    - FailedToLoad = 2
    - Unloaded = 3
    - Imported = 4
    - Generated = 5


[CLASS] ImageView
Full Name: Autodesk.Revit.DB.ImageView

Description: Class for ImageView views
Inherits: ViewDrafting
Implements: IDisposable

  PROPERTIES:
    ElementId ImageInstanceId { get; }
      Description: Id of the image in the view.

  METHODS:
    static ImageView Create(Document document, ImageTypeOptions options)
      Description: Create an ImageView containing an image imported from disk.
      @document: The document in which to create the view.
      @options: Options that specify what image to load.
      Returns: The newly created view.

--------------------------------------------------------------------------------


[INTERFACE] IModelExportContext
Full Name: Autodesk.Revit.DB.IModelExportContext

Description: An interface that is used in custom export to export 3D views of a Revit model.
Remarks: An instance of a class that implements this interface is passed in as a parameter of the constructor. The interface methods are then called at times of drawing entities that are currently visible in the view being exported. With this type of export context used to perform a custom export, Revit will traverse the model and output the model's geometry as if in the process of regular displaying or exporting a 3D View. It means that any geometry which is visible in an open view (taking any current visibility setting applicable to the view) will be processed and output.
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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Preserved = 0
    - Inverted = 1
    - BlackAndWhite = 2


[ENUM] ImportExportFileFormat
Full Name: Autodesk.Revit.DB.ImportExportFileFormat

Description: Describes formats supported by import / export.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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
Implements: IDisposable

  PROPERTIES:
    bool IsLinked { get; }
      Description: Identifies whether this instance is a linked object rather than imported one.

  METHODS:
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, STEPImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, ImportOptions3DM options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, STLImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, SKPImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, SATImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, OBJImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, DGNImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, ElementId typeId, View DBView)
      Description: Creates a new instance of an existing DWG link type.
      @document: The document in which to create the new instacne of DWG link type.
      @typeId: The element id of the existing DWG link type.
      @DBView: The view into which the new instance of DWG link type will be created.
      Returns: The new instance of the given DWG link type.
    static ImportInstance Create(Document document, View DBView, ExternalResourceReference resourceReference, DWGImportOptions options, out LinkLoadResult linkLoadResult)
    static ImportInstance Create(Document document, View DBView, string path, DWGImportOptions options, out LinkLoadResult linkLoadResult)
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the import instance in a family document.
      Returns: A copy of visibility settings for the import instance in a family document.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the import instance in a family document.

--------------------------------------------------------------------------------


[CLASS] ImportOptions3DM
Full Name: Autodesk.Revit.DB.ImportOptions3DM

Description: The import options used to import 3DM format files.
Inherits: BaseImportOptions
Implements: IDisposable

  CONSTRUCTORS:
    new ImportOptions3DM(ImportOptions3DM option)
    new ImportOptions3DM()

--------------------------------------------------------------------------------


[ENUM] ImportPlacement
Full Name: Autodesk.Revit.DB.ImportPlacement

Description: An enumerated type listing possible placement modes for imported drawings.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Site = 0
    - Origin = 1
    - Centered = 2
    - Shared = 3


[ENUM] ImportUnit
Full Name: Autodesk.Revit.DB.ImportUnit

Description: An enumerated type listing possible target units for CAD Import.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

--------------------------------------------------------------------------------


[CLASS] InCanvasControlData
Full Name: Autodesk.Revit.DB.InCanvasControlData

Description: Represents a collection of data which is used by to create and update an in-canvas control.
Remarks: So far, only bitmap file is supported for . The rendered image is the same size in pixel dimensions as the original one. To get a better result, the caller should prepare the image with proper size, for exmaple: 32x32 or 64x64 in pixels, before use. To achive a "transparent" backgound color effect over the provided bitmap, the bitmap should use color RGB(0, 128, 128) as its background and it will be cleared during rendering by Revit.
Implements: IDisposable

  CONSTRUCTORS:
    new InCanvasControlData(string imagePath, XYZ position)
    new InCanvasControlData(string imagePath)

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
Remarks: IndependentTag represents single-category tags, multi-category tags, material tags, and zone tags. IndependentTag is also the base class for other annotations like keynote tags and span symbols. Room, area and space tags are not derived from IndependentTag. for more information.
Inherits: Element
Implements: IDisposable

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
    bool CanLeaderEndConditionBeAssigned(LeaderEndCondition leaderEndCondition)
      Description: Checks whether the LeaderEndCondition can be changed.
      @leaderEndCondition: The leader end condition to check.
      Returns: True if the leader end condition of the tag can be assigned, or false otherwise.
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
    XYZ GetLeaderElbow(Reference referenceTagged)
      Description: Returns the position of the elbow of the tag's leader that points to specified reference. Position of leader's elbow.
      @referenceTagged: The reference which is tagged.
    XYZ GetLeaderEnd(Reference referenceTagged)
      Description: Returns the end position of the tag's leader that points to specified reference.
      @referenceTagged: The reference which is tagged.
      Returns: Point representing the end position of tag's leader
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
    bool HasTagBehavior()
      Description: Checks if the IndependentTag has a tag behavior.
    bool HasTagText()
      Description: Checks if the IndependentTag has a valid tag text.
      Returns: True if the IndependentTag object has a valid tag text.
    bool IsLeaderVisible(Reference referenceTagged)
      Description: Returns if leader that points to specified reference is visible or not.
      @referenceTagged: The reference which is tagged.
      Returns: Returns true if leader that points to specified reference is visible, false otherwise.
    bool IsTaggedOnSubelement()
      Description: Returns true if the any of the tagged references is a subelement.
    void RemoveReferences(IList<Reference> referencesToRemove)
      Description: Removes the provided list of references from the tag's list of references.
      @referencesToRemove: References to be removed from tag.
    void SetIsLeaderVisible(Reference referenceTagged, bool visible)
      Description: Set tag's leader that points to specified reference to be visible or not. This option can be set only if the LeadersPresentationMode is ShowSpecificLeaders.
      @referenceTagged: The reference which is tagged.
      @visible: True for showing the leader, false to hide it.
    void SetLeaderElbow(Reference referenceTagged, XYZ elbowPosition)
      Description: Set the position of the elbow of the tag's leader that points to specified reference. If this tag is a multileader tag and the elbows are merged, the input position will be set to all leaders.
      @referenceTagged: The reference which is tagged.
      @elbowPosition: The position of the elbow.
    void SetLeaderEnd(Reference referenceTagged, XYZ pointEnd)
      Description: Set the end position of the tag's leader that points to specified reference.
      @referenceTagged: The reference which is tagged.
      @pointEnd: Point representing the end position of tag's leader

--------------------------------------------------------------------------------


[CLASS] InsertableObject
Full Name: Autodesk.Revit.DB.InsertableObject

Description: A base class you all types that are insertable.
Inherits: ElementType
Implements: IDisposable

--------------------------------------------------------------------------------


[ENUM] InsertOrientation
Full Name: Autodesk.Revit.DB.InsertOrientation

Description: The allowed values for the INSERT_ORIENTATION parameter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Vertical = 0
    - Slanted = 1
    - Exterior = 2
    - Interior = 3


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
      Description: to the for sheets.
    ElementId ViewOrganizationId { get; set; }
      Description: to the for non-sheet views.
    ViewSet Views { get; set; }
      Description: The views.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] Instance
Full Name: Autodesk.Revit.DB.Instance

Description: The base class for all instance objects.
Inherits: Element
Implements: IDisposable

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
Implements: IDisposable

  CONSTRUCTORS:
    new InstanceBinding(CategorySet categories)
    new InstanceBinding()

--------------------------------------------------------------------------------


[CLASS] InstanceNode
Full Name: Autodesk.Revit.DB.InstanceNode

Description: An output node that represents an instance of a geometry. It can be an instance of FamilyInstance, or it can be and instance of a part of symbol's geometry.
Remarks: See also: . The . contains the data for comparing if two InstanceNode points to the same geometry.
Inherits: GroupNode
Implements: IDisposable

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
    static bool CanBeCutWithVoid(Element element)
      Description: Indicates if the element can be cut by an instance with unattached voids.
      @element: The element to be cut
      Returns: Returns true if the element can be cut by an instance with unattached voids.
    static ICollection<ElementId> GetCuttingVoidInstances(Element element)
      Description: Return ids of the instances with unattached voids cutting the element.
      @element: The element being cut
      Returns: Ids of instances with unattached voids that cut this element
    static ICollection<ElementId> GetElementsBeingCut(Element cuttingInstance)
      Description: Return ids of the elements being cut by the instance
      @cuttingInstance: The cutting family instance
      Returns: Ids of elements being cut by cuttingInstance
    static bool InstanceVoidCutExists(Element element, Element cuttingInstance)
      Description: Check whether the instance is cutting the element
      @element: The element being cut
      @cuttingInstance: The cutting family instance
      Returns: Returns true if the instance is cutting the element.
    static bool IsVoidInstanceCuttingElement(Element element)
      Description: Indicates if the element is a family instance with unattached voids that can cut other elements.
      @element: The cutting family instance
      Returns: Returns true if the element is a family instance with unattached voids that can cut other elements.
    static void RemoveInstanceVoidCut(Document document, Element element, Element cuttingInstance)
      Description: Remove a cut applied to the element by a cutting instance with unattached voids.
      @document: The document containing the two elements
      @element: The element being cut
      @cuttingInstance: The cutting family instance

--------------------------------------------------------------------------------


[CLASS] InsulationLiningBase
Full Name: Autodesk.Revit.DB.InsulationLiningBase

Description: Acts as the base class for duct insulation, pipe insulation and duct lining elements.
Inherits: MEPCurve
Implements: IDisposable

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
    static ICollection<ElementId> GetLiningIds(Document document, ElementId elemId)
      Description: Returns the ids of the lining elements associated to a given element.
      @document: The document.
      @elemId: The element.
      Returns: A collection of the ids of the lining elements.
    static bool IsValidThickness(double thickness)
      Description: Identifies if the given thickness value is valid for assignment to insulation or lining elements.
      @thickness: Thickness of the insulation and lining elements.
      Returns: True if the thickness is valid, false otherwise.

--------------------------------------------------------------------------------


[CLASS] IntegerParameterValue
Full Name: Autodesk.Revit.DB.IntegerParameterValue

Description: A class that holds an Integer value of a parameter element.
Inherits: ParameterValue
Implements: IDisposable

  CONSTRUCTORS:
    new IntegerParameterValue(int value)
    new IntegerParameterValue()

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
    void SetGroupTypeId(ForgeTypeId groupTypeId)
      Description: Sets the built-in parameter group to which the parameter defined by this definition belongs.
      @groupTypeId: Identifier of the built-in parameter group.

--------------------------------------------------------------------------------


[CLASS] InternalDefinitions
Full Name: Autodesk.Revit.DB.InternalDefinitions

Description: This object blocks attempts to create new internal definitions as they are not permitted.
Inherits: Definitions
Implements: IEnumerable`1, IEnumerable, IDisposable

--------------------------------------------------------------------------------


[CLASS] InternalOrigin
Full Name: Autodesk.Revit.DB.InternalOrigin

Description: A class representing the origin of internal coordinate system. Each Revit project contains one InternalOrigin.
Remarks: The internal origin cannot be selected (e.g. as a reference) nor can it be modified.
Inherits: Element
Implements: IDisposable

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
Implements: IDisposable

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
Implements: IDisposable, IEnumerable

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
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new IntersectionResultArrayIterator()

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Cut = 0
    - Excavate = 1


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
Remarks: An instance of a class that implements this interface is passed in as a parameter of the constructor. The interface methods are then called at times of rendering entities that are currently visible in the view being rendered. With this type of export context used to perform a custom export, Revit will traverse the model and output the model's geometry as if processing the Render command invoked via the UI. It means that only such elements that have actual geometry and are suitable to appear in a rendered view will be processed and output.
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
Remarks: An instance of the implemented interface is passed as an argument to the Document.MakeTransientElements() method, which will call back the Execute method of the interface.During the execution of the method Revit will allow creation of certain elements, such as DirectShape, and will make them automatically transient . See ( for more details about transient elements.)The code within the Execute method is not allowed to modify the model in any other way. An attempt to change the model or create elements of other kinds will result in an exception. This indirectly means that methods using a transaction internally are not allowed either. Such methods include document Save and SaveAs, certain import and export methods, creating links, syncing with central, etc.Regenerating the model is also not allowed for the entire duration of the Execute method.This interface is passed to which does the actual transient element creation.

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
      Description: to the for sheets.
    ElementId ViewOrganizationId { get; set; }
      Description: to the for non-sheet views.
    ViewSet Views { get; set; }
      Description: The views.

--------------------------------------------------------------------------------

