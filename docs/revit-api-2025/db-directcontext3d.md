# Autodesk.Revit.DB.DirectContext3D


NAMESPACE: Autodesk.Revit.DB.DirectContext3D
--------------------------------------------------------------------------------

[CLASS] Camera
Full Name: Autodesk.Revit.DB.DirectContext3D.Camera

Description: A collection of camera settings for the current view.
Remarks: The current Camera can be obtained from
Implements: IDisposable

  CONSTRUCTORS:
    new Camera(Camera other)

  PROPERTIES:
    XYZ EyePosition { get; set; }
      Description: Camera's position in the world
    double FarDistance { get; set; }
      Description: Distance to far clipping plane
    double HorizontalExtent { get; set; }
      Description: Horizontal extent of the camera's view, measured at target distance.
    double HorizontalOffset { get; set; }
      Description: Horizontal offset of the camera's view center from target, measured at target distance.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double NearDistance { get; set; }
      Description: Distance to near clipping plane
    ProjectionMethod ProjectionMethod { get; set; }
      Description: Projection method
    double TargetDistance { get; set; }
      Description: Distance from camera to its target
    XYZ UpDirection { get; set; }
      Description: Up direction of the camera
    double VerticalExtent { get; set; }
      Description: Vertical extent of the camera's view, measured at target distance.
    double VerticalOffset { get; set; }
      Description: Vertical offset of the camera's view center from target, measured at target distance.
    XYZ ViewDirection { get; set; }
      Description: Direction that the camera is facing

  METHODS:
    void Dispose()
    void Transform(Transform trf)
      Description: Transforms the camera

--------------------------------------------------------------------------------

[CLASS] ClipPlane
Full Name: Autodesk.Revit.DB.DirectContext3D.ClipPlane

Description: A set of parameters representing a clip plane in DirectContext3D.
Implements: IDisposable

  CONSTRUCTORS:
    new ClipPlane(ClipPlane other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Normal { get; set; }
      Description: The plane's normal vector.
    XYZ Origin { get; set; }
      Description: The plane's origin.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DirectContext3DDocumentUtils
Full Name: Autodesk.Revit.DB.DirectContext3D.DirectContext3DDocumentUtils

Description: The methods provided by this utility class support the use of DirectContext3D and storage of DirectContext3D handle elements in Revit documents.
Remarks: DirectContext3D graphics can be displayed without storing the graphics in elements. However, the reference to the externally generated graphics will not persist beyond the current session, and there will be no capabilities for the user to select and interact with the graphics. The utility methods in this class support creation and updating of DirectContext3D handle and handle instance elements (which for this release are and instances, however this may not always be the case). The capabilities provided by these handle elements include: A special geometry object remembers the existence and source location of the external graphics.A generated 3D bounding box surrounds the provided graphics. This box is set to be selectable but its properties are mostly not modifiable. However, the user can reposition the box and the associated external graphics with it.The type and instance relationship between DirectContext3D handles and handle instances allows one DirectContext3D server to act as the provider of one set of graphics (the type) that the API displays in multiple locations, as determined by the handle instances.The handle element will be associated to a specified category. The only currently valid category is OST_Coordination_Model.The application is required to update the handle type element using whenever the source data changes. It also is required that the application update the handle during initial load of the document containing this element.

  METHODS:
    static ISet<ElementId> GetDirectContext3DHandleInstances(Document aDocument, ElementId handleCategory)
      Description: Returns all DirectContext3D handle instances of the given category in the document.
      @aDocument: The document.
      @handleCategory: A category of DirectContext3D handles.
      Returns: The set of DirectContext3D handle instances of the given category.
    static ISet<ElementId> GetDirectContext3DHandleTypes(Document aDocument, ElementId handleCategory)
      Description: Returns all DirectContext3D handle types of the given category in the document.
      @aDocument: The document.
      @handleCategory: A category of DirectContext3D handles.
      Returns: The set of DirectContext3D handle types of the given category.
    static bool IsADirectContext3DHandleCategory(ElementId categoryId)
      Description: Checks whether the provided category ID is one of the categories used by DirectContext3D handle elements.
      @categoryId: The category ID to check.
      Returns: True, if the category is valid for DirectContext3D handle elements, false otherwise.
    static bool IsADirectContext3DHandleInstance(Document aDocument, ElementId elementId)
      Description: Checks whether the provided Element ID corresponds to a DirectContext3D handle instance element.
      @aDocument: The document.
      @elementId: The ID of the element to check.
      Returns: True, if the element is a valid DirectContext3D handle instance, false otherwise.
    static bool IsADirectContext3DHandleType(Document aDocument, ElementId elementId)
      Description: Checks whether the provided Element ID corresponds to a DirectContext3D handle type element.
      @aDocument: The document.
      @elementId: The ID of the element to check.
      Returns: True, if the element is a valid DirectContext3D handle type, false otherwise.

--------------------------------------------------------------------------------

[CLASS] DirectContext3DHandleOverrides
Full Name: Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleOverrides

Description: A set of DirectContext3DHandleSettings that are stored by a view.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Assign(DirectContext3DHandleOverrides other)
      Description: Assigns values of the source overrides to this object.
      @other: The source overrides.
    void Dispose()
    DirectContext3DHandleSettings GetDirectContext3DHandleSettings(Document aDoc, ElementId elementId)
      Description: Gets override settings associated with a DirectContext3D handle instance or type.
      @aDoc: Document where elementId resides.
      @elementId: Id of the overridden element.
      Returns: The override settings assigned to the handle element, if present, or a default override settings if nothing was found.
    bool IsEqual(DirectContext3DHandleOverrides other)
      Description: Check if the contents of two overrides are equal.
      @other: The overrides to be compared.
      Returns: True for equal, false otherwise.
    void SetDirectContext3DHandleSettings(Document aDoc, ElementId elementId, DirectContext3DHandleSettings newSettings)
      Description: Assigns override settings associated with a DirectContext3D handle instance or type.
      @aDoc: Document where elementId resides.
      @elementId: Id of the element to be overridden.
      @newSettings: The override settings to be assigned to the handle element.

--------------------------------------------------------------------------------

[CLASS] DirectContext3DHandleSettings
Full Name: Autodesk.Revit.DB.DirectContext3D.DirectContext3DHandleSettings

Description: Overriding settings applied to DirectContext3DHandles through the Visibility dialog.
Remarks: DirectContext3D graphics can be displayed with or without an associated DirectContext3D handle element. For DirectContext3D graphics that utilize the handle element, the visibility and appearance of the graphics can be adjusted through the Visibility/Graphics dialog.
Implements: IDisposable

  CONSTRUCTORS:
    new DirectContext3DHandleSettings(DirectContext3DHandleSettings other)
    new DirectContext3DHandleSettings(bool visibility, int transparency)
    new DirectContext3DHandleSettings()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Visibility { get; set; }
      Description: Visibility of the handle and the associated DirectContext3D graphics. A value of true means that the graphics are visible.

  METHODS:
    void Assign(DirectContext3DHandleSettings other)
      Description: Assigns values of the source settings to this object.
      @other: The source settings.
    void Dispose()
    int GetTransparency()
      Description: Gets the transparency value of the handle and the associated DirectContext3D graphics.
      Returns: The transparency value (in percentage)
    bool IsEqual(DirectContext3DHandleSettings other)
      Description: Check if the contents of two instances of settings are equal.
      @other: The settings to be compared.
      Returns: True for equal, false otherwise.
    void SetTransparency(int transparency)
      Description: Sets the transparency value of the handle and the associated DirectContext3D graphics.
      @transparency: The transparency value to apply (in percentage)

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DrawContext
Full Name: Autodesk.Revit.DB.DirectContext3D.DrawContext

Description: A class that provides drawing functionality for use by servers
Remarks: The drawing facility of this class is conceptually similar to a low-level graphics API. The functionality operates on a set of geometry primitives such as triangles, lines, and points, which are encoded into a set of vertex and index buffers. Aside from submission of geometry in buffers, a major part of the drawing process is responding to certain changes in graphics state. For example, users of this class can implement progressive rendering of geometry by testing whether there have been interruptions that should prevent the drawing from being completed.

  METHODS:
    static void FlushBuffer(VertexBuffer vertexBuffer, int vertexCount, IndexBuffer indexBuffer, int indexCount, VertexFormat vertexFormat, EffectInstance effectInstance, PrimitiveType primitiveType, int start, int primitiveCount)
      Description: Submits geometry for rendering.
      @vertexBuffer: The vertex buffer that contains vertex data.
      @vertexCount: The number of vertices in the vertex buffer.
      @indexBuffer: The index buffer that contains indices into the vertex buffer.
      @indexCount: The number of indices in the index buffer.
      @vertexFormat: The format of the vertices in the vertex buffer.
      @effectInstance: The effect instance to be used for drawing this piece of geometry.
      @primitiveType: The type of geometry primitive used in the index buffer.
      @start: The first index to use for drawing.
      @primitiveCount: The number of primitives to draw.
    static Camera GetCamera()
      Description: Gets the camera corresponding to the Revit view where rendering takes place.
      Returns: The camera.
    static IList<ClipPlane> GetClipPlanes()
      Description: Gets the clipping planes for the Revit view where rendering takes place. Clipping planes control the 3D extent of a view and can be set using Section Box in Revit.
      Returns: The array of clipping planes, which is empty if none are set.
    static Rectangle GetClipRectangle()
      Description: Gets the clip rectangle for the Revit view where rendering takes place. The clip rectangle is the area currently being redrawn, which may be smaller than the view rectangle.
      Returns: The clip rectangle.
    static bool GetOverrideColor(out Color color)
    static bool GetOverrideTransparency(out double transparency)
    static Rectangle GetViewRectangle()
      Description: Gets the rectangle that represents the extent (in 2D) of the Revit view where rendering takes place.
      Returns: The view rectangle.
    static bool IsAvailable()
      Description: Checks whether the facilities of this class are available for use in the current scope.
      Returns: True if the DrawContext is available for rendering, false otherwise.
    static bool IsInterrupted()
      Description: Checks whether the current rendering pass has been interrupted.
      Returns: True if the current rendering pass has been interrupted before its completion, false otherwise.
    static bool IsTransparentPass()
      Description: Determines whether the current rendering pass is for transparent objects.
      Returns: True when the server should be submitting transparent objects for rendering, false otherwise.
    static void SetWorldTransform(Transform trf)
      Description: Sets the world transformation that will be applied to geometry during rendering.
      @trf: The transformation matrix.

--------------------------------------------------------------------------------

[CLASS] EffectInstance
Full Name: Autodesk.Revit.DB.DirectContext3D.EffectInstance

Description: An effect instance that controls the appearance of geometry.
Remarks: Each effect instance should be used with geometry of a matching vertex format. Only a subset of effect instance parameters is relevant to geometry of a particular vertex format. If the vertex format does not specify vertex color ( or ) the following parameters should be set: ColorTransparency If the vertex format specifies vertex normals ( or ) the following parameters should be set: Ambient ColorDiffuse ColorSpecular ColorGlossiness (specular exponent)EmissiveColorTransparency If the vertex format specifies a color, then the geometry will be colored according to the color of each vertex. Otherwise, the geometry's color will come from the effect instance parameters. Similarly, the transparency parameter affects all of the geometry associated with the effect, while the transparency of the individual vertices can also be controlled via the transparency component of their colors.
Implements: IDisposable

  CONSTRUCTORS:
    new EffectInstance(VertexFormatBits vertexFormatBits)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsValid()
      Description: Tests whether the effect instance is valid for rendering.
      Returns: True if the effect instance is valid for rendering, false otherwise.
    bool MatchesFormat(VertexFormat vertexFormat)
      Description: Tests whether the effect instance is appropriate for the given vertex format.
      @vertexFormat: A vertex format.
      Returns: True if the effect instance is valid for use with the specified vertex format.
    void SetAmbientColor(Color color)
      Description: Sets the ambient color parameter of the effect instance.
      @color: The ambient color value.
    void SetColor(Color color)
      Description: Sets the color parameter of the effect instance.
      @color: The color value.
    void SetDiffuseColor(Color color)
      Description: Sets the diffuse color parameter of the effect instance.
      @color: The diffuse color value.
    void SetEmissiveColor(Color color)
      Description: Sets the emissive color parameter of the effect instance.
      @color: The emissive color value.
    void SetGlossiness(double glossiness)
      Description: Sets the glossiness parameter of the effect instance.
      @glossiness: The glossiness value.
    void SetSpecularColor(Color color)
      Description: Sets the specular color parameter of the effect instance.
      @color: The specular color value.
    void SetTransparency(double transparency)
      Description: Sets the transparency parameter of the effect instance.
      @transparency: The transparency value.

--------------------------------------------------------------------------------

[INTERFACE] IDirectContext3DServer
Full Name: Autodesk.Revit.DB.DirectContext3D.IDirectContext3DServer

Description: The interface to be implemented by a server of the DirectContext3D external service.
Implements: IExternalServer

  METHODS:
    bool CanExecute(View dBView)
      Description: Can be used to allow the server to execute only in certain views.
      @dBView: The view where rendering will occur.
      Returns: True if the server can be executed in the provided view, false otherwise.
    string GetApplicationId()
      Description: Reports this server's application ID.
      Returns: The application ID.
    Outline GetBoundingBox(View dBView)
      Description: Reports a bounding box of the geometry that this server submits for drawing.
      @dBView: The view where rendering will occur. If this argument is , a view-independent bounding box should be reported.
      Returns: The bounding box as an Outline.
    string GetSourceId()
      Description: Reports this server's source ID.
      Returns: The source ID.
    void RenderScene(View dBView, DisplayStyle displayStyle)
      Description: Performs rendering of the scene that the server creates.
      @dBView: The view where rendering will occur.
      @displayStyle: The display style of the view in which the submitted geometry will be drawn.
    bool UseInTransparentPass(View dBView)
      Description: Indicates whether this server will submit geometry during the rendering pass for transparent geometry.
      @dBView: The view where rendering will occur.
      Returns: True if the server needs to render transparent geometry, false otherwise.
    bool UsesHandles()
      Description: Tests whether this server uses DirectContext3D handle elements.
      Returns: True if the server needs to use DirectContext3D handle elements, false otherwise.

--------------------------------------------------------------------------------

[CLASS] IndexBuffer
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexBuffer

Description: A buffer that stores vertex indices for rendering.
Implements: IDisposable

  CONSTRUCTORS:
    new IndexBuffer(int sizeInShortInts)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IndexStreamLine GetIndexStreamLine()
      Description: Gets a stream that can be used to write segment primitives into the buffer.
      Returns: The stream that can be used to write into this buffer.
    IndexStreamPoint GetIndexStreamPoint()
      Description: Gets a stream that can be used to write primitives into the buffer.
      Returns: The stream that can be used to write into this buffer.
    IndexStreamTriangle GetIndexStreamTriangle()
      Description: Gets a stream that can be used to write primitives into the buffer.
      Returns: The stream that can be used to write into this buffer.
    IntPtr GetMappedHandle()
      Description: Gets a handle to the buffer's memory that has been mapped. Writing data to the buffer using the handle is an alternative to using stream objects.
      Returns: The handle to the mapped memory or nullptr when the buffer is not mapped.
    bool IsValid()
      Description: Tests whether the buffer is valid for rendering.
      Returns: True if the buffer is valid for rendering, false otherwise.
    void Map(int sizeInShortInts)
      Description: Maps a portion of the index buffer into memory, so that indices can be written into it. see .
      @sizeInShortInts: The size of the part of the buffer to be mapped, measured in short integers. Must be less than or equal to the size of the
    void Unmap()
      Description: Unmaps the buffer so that it can be used for rendering.

--------------------------------------------------------------------------------

[CLASS] IndexLine
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexLine

Description: A line segment primitive consisting of two indices.
Inherits: IndexPrimitive
Implements: IDisposable

  CONSTRUCTORS:
    new IndexLine(int index0, int index1)

  PROPERTIES:
    int Index0 { get; set; }
      Description: The index of the line segment's first vertex.
    int Index1 { get; set; }
      Description: The index of the line segment's second vertex.

  METHODS:
    static int GetSizeInShortInts()
      Description: Gets the amount of storage that the primitive takes up in a buffer, measured in short integers.
      Returns: The number of short integers occupied by the primitive.

--------------------------------------------------------------------------------

[CLASS] IndexPoint
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexPoint

Description: A point primitive consisting of one index.
Inherits: IndexPrimitive
Implements: IDisposable

  CONSTRUCTORS:
    new IndexPoint(int index)

  PROPERTIES:
    int Index { get; set; }
      Description: The index of the point's vertex.

  METHODS:
    static int GetSizeInShortInts()
      Description: Gets the amount of storage that the primitive takes up in a buffer, measured in short integers.
      Returns: The number of short integers occupied by the primitive.

--------------------------------------------------------------------------------

[CLASS] IndexPrimitive
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexPrimitive

Description: The base class for index buffer primitives.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] IndexStream
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexStream

Description: The base class for DirectContext3D index streams, which are used to write vertex indices into buffers.
Remarks: This base class cannot be used directly. Instead, a steam that is specific for each type of primitive (point, line, or triangle) must be used. Use to insert instances.Use to insert instances.Use to insert instances. The process of putting vertex indices into a buffer involves using a stream-buffer pair as follows: Map the index buffer (see ).Get a stream for the appropriate primitive type from the buffer.Add sequences of indices corresponding to primitives of the same type to the stream. The indices will be written into the buffer that was used to create the stream.Unmap the buffer. As an alternative to using streams, it is possible to write data into a buffer using a handle to its mapped memory.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] IndexStreamLine
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexStreamLine

Description: A stream that can be used to write primitives into an
Inherits: IndexStream
Implements: IDisposable

  METHODS:
    void AddLine(IndexLine line)
      Description: Inserts a segment into the stream and associated buffer.
      @line: The line segment to be inserted.
    void AddLines(IList<IndexLine> lines)
      Description: Inserts multiple segments into the stream and associated buffer.
      @lines: The line segments to be inserted.

--------------------------------------------------------------------------------

[CLASS] IndexStreamPoint
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexStreamPoint

Description: A stream that can be used to write primitives into an
Inherits: IndexStream
Implements: IDisposable

  METHODS:
    void AddPoint(IndexPoint point)
      Description: Inserts a into the stream and associated buffer.
      @point: The point to be inserted.
    void AddPoints(IList<IndexPoint> points)
      Description: Inserts multiple instances into the stream and associated buffer.
      @points: The points to be inserted.

--------------------------------------------------------------------------------

[CLASS] IndexStreamTriangle
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexStreamTriangle

Description: A stream that can be used to write primitives into an
Inherits: IndexStream
Implements: IDisposable

  METHODS:
    void AddTriangle(IndexTriangle triangle)
      Description: Inserts a into the stream and associated buffer.
      @triangle: The triangle to be inserted.
    void AddTriangles(IList<IndexTriangle> triangles)
      Description: Inserts multiple instances into the stream and associated buffer.
      @triangles: The triangles to be inserted.

--------------------------------------------------------------------------------

[CLASS] IndexTriangle
Full Name: Autodesk.Revit.DB.DirectContext3D.IndexTriangle

Description: A triangle primitive consisting of three indices.
Remarks: Indices of a triangle's vertices can be listed in either the clockwise or counterclockwise winding order, according to the triangle's orientation in space. A DirectContext3D triangle faces the viewer if its vertices are in counterclockwise order from the viewer's point of view.
Inherits: IndexPrimitive
Implements: IDisposable

  CONSTRUCTORS:
    new IndexTriangle(int index0, int index1, int index2)

  PROPERTIES:
    int Index0 { get; set; }
      Description: The index of the triangle's first vertex.
    int Index1 { get; set; }
      Description: The index of the triangle's second vertex.
    int Index2 { get; set; }
      Description: The index of the triangle's third vertex.

  METHODS:
    static int GetSizeInShortInts()
      Description: Gets the amount of storage that the primitive takes up in a buffer, measured in short integers.
      Returns: The number of short integers occupied by the primitive.

--------------------------------------------------------------------------------

[ENUM] PrimitiveType
Full Name: Autodesk.Revit.DB.DirectContext3D.PrimitiveType

Description: Type of geometry primitive represented as a number.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TriangleList = 0
    - LineList = 1
    - PointList = 2

[ENUM] ProjectionMethod
Full Name: Autodesk.Revit.DB.DirectContext3D.ProjectionMethod

Description: Projection method
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Orthographic = 0
    - Perspective = 1

[CLASS] Vertex
Full Name: Autodesk.Revit.DB.DirectContext3D.Vertex

Description: The base class for DirectContext3D vertices.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] VertexBuffer
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexBuffer

Description: A buffer that stores vertex data for rendering.
Implements: IDisposable

  CONSTRUCTORS:
    new VertexBuffer(int sizeInFloats)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IntPtr GetMappedHandle()
      Description: Gets a handle to the buffer's memory that has been mapped. Writing data to the buffer using the handle is an alternative to using stream objects.
      Returns: The handle to the mapped memory or nullptr when the buffer is not mapped.
    VertexStreamPosition GetVertexStreamPosition()
      Description: Gets a stream that can be used to write vertices of type into the buffer.
      Returns: The stream that can be used to write into this buffer.
    VertexStreamPositionColored GetVertexStreamPositionColored()
      Description: Gets a stream that can be used to write vertices of type into the buffer.
      Returns: The stream that can be used to write into this buffer.
    VertexStreamPositionNormal GetVertexStreamPositionNormal()
      Description: Gets a stream that can be used to write vertices of type into the buffer.
      Returns: The stream that can be used to write into this buffer.
    VertexStreamPositionNormalColored GetVertexStreamPositionNormalColored()
      Description: Gets a stream that can be used to write vertices of type into the buffer.
      Returns: The stream that can be used to write into this buffer.
    bool IsValid()
      Description: Tests whether the buffer is valid for rendering.
      Returns: True if the buffer is valid for rendering, false otherwise.
    void Map(int sizeInFloats)
      Description: Maps a portion of the buffer into memory, so that vertex data can be written into it. (see ).
      @sizeInFloats: The size of the part of the buffer to be mapped, measured in floats. Must be less than or equal to the size of the
    void Unmap()
      Description: Unmaps the buffer, so that it can be used for rendering.

--------------------------------------------------------------------------------

[CLASS] VertexFormat
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexFormat

Description: A specification of the format of vertex data contained in a piece of geometry.
Implements: IDisposable

  CONSTRUCTORS:
    new VertexFormat(VertexFormatBits vertexFormatBits)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsValid()
      Description: Tests whether the vertex format specification is valid for rendering.
      Returns: True if the vertex format specification is valid for rendering, false otherwise.

--------------------------------------------------------------------------------

[ENUM] VertexFormatBits
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexFormatBits

Description: Vertex format (i.e., the type of data associated with a vertex) represented as a number.
Remarks: VertexFormatBits can be used to specify the vertex format in the creation of the following objects: VertexFormatBits is not to be confused with VertexFormat. The latter type of object is associated with low-level graphics functionality and may become invalid. VertexFormat is needed to submit a set of vertex and index buffers for rendering (see ).
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Position = 1
    - PositionNormal = 3
    - PositionColored = 5
    - PositionNormalColored = 7

[CLASS] VertexPosition
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexPosition

Description: A geometry vertex specified as a position in space.
Remarks: Since these vertices do not have a color their color is obtained from the
Inherits: Vertex
Implements: IDisposable

  CONSTRUCTORS:
    new VertexPosition(XYZ position)

  PROPERTIES:
    XYZ Position { get; set; }
      Description: The vertex's position.

  METHODS:
    static int GetSizeInFloats()
      Description: Gets the amount of storage that the vertex takes up in a buffer, measured in floats.
      Returns: The number of floats occupied by one vertex of this type.

--------------------------------------------------------------------------------

[CLASS] VertexPositionColored
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexPositionColored

Description: A geometry vertex specified as a position in space with a color.
Remarks: The color of these vertices includes a transparency component In order to render them as transparent they must be rendered in the transparent pass See the 'IsTransparentPass' method of
Inherits: Vertex
Implements: IDisposable

  CONSTRUCTORS:
    new VertexPositionColored(XYZ position, ColorWithTransparency color)

  PROPERTIES:
    XYZ Position { get; set; }
      Description: The vertex's position.

  METHODS:
    ColorWithTransparency GetColor()
      Description: Gets the vertex's color.
      Returns: The vertex's color.
    static int GetSizeInFloats()
      Description: Gets the amount of storage that the vertex takes up in a buffer, measured in floats.
      Returns: The number of floats occupied by one vertex of this type.
    void SetColor(ColorWithTransparency color)
      Description: Sets the vertex's color.
      @color: The vertex's color.

--------------------------------------------------------------------------------

[CLASS] VertexPositionNormal
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexPositionNormal

Description: A geometry vertex specified as a position in space with a normal vector.
Remarks: Since these vertices do not have a color their color is obtained from the
Inherits: Vertex
Implements: IDisposable

  CONSTRUCTORS:
    new VertexPositionNormal(XYZ position, XYZ normal)

  PROPERTIES:
    XYZ Normal { get; set; }
      Description: The vertex's normal vector.
    XYZ Position { get; set; }
      Description: The vertex's position.

  METHODS:
    static int GetSizeInFloats()
      Description: Gets the amount of storage that the vertex takes up in a buffer, measured in floats.
      Returns: The number of floats occupied by one vertex of this type.

--------------------------------------------------------------------------------

[CLASS] VertexPositionNormalColored
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexPositionNormalColored

Description: A geometry vertex specified as a position in space with a normal vector and a color.
Remarks: The color of these vertices includes a transparency component In order to render them as transparent they must be rendered in the transparent pass See the 'IsTransparentPass' method of
Inherits: Vertex
Implements: IDisposable

  CONSTRUCTORS:
    new VertexPositionNormalColored(XYZ position, XYZ normal, ColorWithTransparency color)

  PROPERTIES:
    XYZ Normal { get; set; }
      Description: The vertex's normal vector.
    XYZ Position { get; set; }
      Description: The vertex's position.

  METHODS:
    ColorWithTransparency GetColor()
      Description: Gets the vertex's color.
      Returns: The vertex's color.
    static int GetSizeInFloats()
      Description: Gets the amount of storage that the vertex takes up in a buffer, measured in floats.
      Returns: The number of floats occupied by one vertex of this type.
    void SetColor(ColorWithTransparency color)
      Description: Sets the vertex's color.
      @color: The vertex's color.

--------------------------------------------------------------------------------

[CLASS] VertexStream
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexStream

Description: The base class for DirectContext3D vertex streams, which are used to write vertex data into buffers.
Remarks: This base class cannot be used directly. Instead, a steam that is specific for each type of vertex must be used. Use to insert instances.Use to insert instances.Use to insert instances.Use to insert instances. The process of putting vertex data into a buffer involves using a stream-buffer pair as follows: Map the vertex buffer.Get a stream of the appropriate type from the buffer.Add vertices of the same type to the stream. They will be written into the buffer that was used to create the stream.Unmap the buffer. As an alternative to using streams, it is possible to write data into a buffer using a handle to its mapped memory.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] VertexStreamPosition
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexStreamPosition

Description: A stream that can be used to write vertices of type into a buffer (see ).
Inherits: VertexStream
Implements: IDisposable

  METHODS:
    void AddVertex(VertexPosition vertex)
      Description: Inserts a into the stream and associated buffer.
      @vertex: The vertex to be inserted.
    void AddVertices(IList<VertexPosition> vertices)
      Description: Inserts multiple instances into the stream and associated buffer.
      @vertices: The vertices to be inserted.

--------------------------------------------------------------------------------

[CLASS] VertexStreamPositionColored
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionColored

Description: A stream that can be used to write vertices of type into a buffer (see ).
Inherits: VertexStream
Implements: IDisposable

  METHODS:
    void AddVertex(VertexPositionColored vertex)
      Description: Inserts a into the stream and associated buffer.
      @vertex: The vertex to be inserted.
    void AddVertices(IList<VertexPositionColored> vertices)
      Description: Inserts multiple instances into the stream and associated buffer.
      @vertices: The vertices to be inserted.

--------------------------------------------------------------------------------

[CLASS] VertexStreamPositionNormal
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormal

Description: A stream that can be used to write vertices of type into a buffer (see ).
Inherits: VertexStream
Implements: IDisposable

  METHODS:
    void AddVertex(VertexPositionNormal vertex)
      Description: Inserts a into the stream and associated buffer.
      @vertex: The vertex to be inserted.
    void AddVertices(IList<VertexPositionNormal> vertices)
      Description: Inserts multiple instances into the stream and associated buffer.
      @vertices: The vertices to be inserted.

--------------------------------------------------------------------------------

[CLASS] VertexStreamPositionNormalColored
Full Name: Autodesk.Revit.DB.DirectContext3D.VertexStreamPositionNormalColored

Description: A stream that can be used to write vertices of type into a buffer (see ).
Inherits: VertexStream
Implements: IDisposable

  METHODS:
    void AddVertex(VertexPositionNormalColored vertex)
      Description: Inserts a into the stream and associated buffer.
      @vertex: The vertex to be inserted.
    void AddVertices(IList<VertexPositionNormalColored> vertices)
      Description: Inserts multiple instances into the stream and associated buffer.
      @vertices: The vertices to be inserted.

--------------------------------------------------------------------------------


