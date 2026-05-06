# Autodesk.Revit.DB.PointClouds


NAMESPACE: Autodesk.Revit.DB.PointClouds
--------------------------------------------------------------------------------

[STRUCT] CloudPoint
Full Name: Autodesk.Revit.DB.PointClouds.CloudPoint

Description: Represents a point obtained from a Point cloud.

  CONSTRUCTORS:
    new CloudPoint(float x, float y, float z, int color)

--------------------------------------------------------------------------------

[INTERFACE] IPointCloudAccess
Full Name: Autodesk.Revit.DB.PointClouds.IPointCloudAccess

Description: An interface that provides functionality for working with an individual Point Cloud.
Remarks: An instance of this interface is obtained from the associated point cloud engine when the engine's CreatePointCloudAccess method is called.An instance of this class will be requested by Revit when drawing the point cloud in the view. For performance reasons, when rendering every frame Revit asks the engine to fetch the necessary points split into multiple batches. The number of batches requested depends on the view: the smaller the projection of the cloud bounding box on the screen the fewer batches Revit requests. Revit assumes that each batch contains points uniformly distributed over the visible part of the cloud ("visible" as defined by the filter). Thus, the points supplied by the engine should not be geometrically distinct (e.g. divided into multiple independent volumes, because at distant zoom levels Revit will only request a few batches and only part of the cloud will be displayed.

  METHODS:
    IPointSetIterator CreatePointSetIterator(PointCloudFilter rFilter, double density, ElementId viewId)
      Description: Implement this method to return an iterator for iterating over blocks of this point cloud.
      @rFilter: The filter used to process cloud points and determine which ones lie with the target volume.
      @density: Desired number of points per unit area. Area is computed in native units of the point cloud. Another iterator, created with the same density and a more restrictive filter, should return a subset of the points returned by this iterator.
      @viewId: The view id for the current view passed as auxiliary information to allow the engine to optimize retrieval of points. If viewId == InvalidElementId, the query is not for a view display operation.
      Returns: The newly created iterator.
    IPointSetIterator CreatePointSetIterator(PointCloudFilter rFilter, ElementId viewId)
      Description: Implement this method to return an iterator for iterating over blocks of this point cloud.
      @rFilter: The filter used to process cloud points and determine which ones lie with the target volume.
      @viewId: The view id for the current view passed as auxiliary information to allow the engine to optimize retrieval of points. If viewId == InvalidElementId, the query is not for a view display operation.
      Returns: The newly created iterator.
    void Free()
      Description: Completes the lifetime of the object providing this interface.
    PointCloudColorEncoding GetColorEncoding()
      Description: Returns the encoding used by points in this point cloud.
      Returns: The encoding.
    Outline GetExtent()
      Description: Implement this method to returns an object that contains the bounding box of the entire point cloud, aligned to the point cloud coordinate system.
      Returns: The bounding box of the point cloud.
    string GetName()
      Description: Implement this method to return the name of the point cloud that will be used when Revit needs to refer to the point cloud type, e.g. in the Manage Links dialog or in the Type Properties dialog.
      Returns: The name of the point cloud for Revit's user interface.
    XYZ GetOffset()
      Description: Implement this method to return the offset stored in the point cloud.
      Returns: The offset vector of this point cloud's coordinate system.
    double GetUnitsToFeetConversionFactor()
      Description: Implement this method to return the conversion factor from the units of the point cloud to feet.
      Returns: The multiplication factor to convert coordinates of points in this cloud to feet.
    int ReadPoints(PointCloudFilter rFilter, ElementId viewId, IntPtr buffer, int nBufferSize)
      Description: Implement this method so that on successive invocations it will return distinct subsets of points which meet the criterion.
      @rFilter: The filter used to process cloud points and determine which ones lie with the target volume.
      @viewId: The view id for the current view passed as auxiliary information to allow the engine to optimize retrieval of points. If viewId == InvalidElementId, the query is not for a view display operation.
      @buffer: Memory buffer into which the points should be written. The buffer was allocated by Revit and it is guaranteed to be valid for the duration of the call.
      @nBufferSize: The maximum number of CloudPoint objects that may be copied into the buffer.
      Returns: The actual number of CloudPoint objects placed in the buffer (can be less than the length of the buffer). If there are no points available that match the filter criteria, return 0.

--------------------------------------------------------------------------------

[INTERFACE] IPointCloudEngine
Full Name: Autodesk.Revit.DB.PointClouds.IPointCloudEngine

Description: An interface that controls the behavior of the link from Revit to a custom Point Cloud Engine.
Remarks: An instance of this interface should be created by the engine provider and registered with the PointCloudEnginesRegistry. The engine may associated with a particular file name extension during registration (for example, Revit supplies a built-in engine for working with files with the extension "rcs" or "rcp"). Alternatively, the engine may be associated with an identifier which is not expected to the be the extension of a particular file.

  METHODS:
    IPointCloudAccess CreatePointCloudAccess(string identifier)
      Description: Implement this method to construct the IPointCloudAccess interface for the point cloud designated by the identifier. This method is called once during the creation of a PointCloudType.
      @identifier: An identifier unique to the point cloud. This will be a file name if the engine was registered as file-based, or an arbitrary identifier if the engine is not file-based.
      Returns: The object that can be used to create iterators and interrogate the point cloud for its features.
    void Free()
      Description: Revit will call this method when done using the engine.

--------------------------------------------------------------------------------

[INTERFACE] IPointSetIterator
Full Name: Autodesk.Revit.DB.PointClouds.IPointSetIterator

Description: An interface that Revit will call when iterating through sets of points on the engine.
Remarks: An instance of this interface is obtained from the Point Cloud engine when the engine's CreatePointSetIterator method is called.

  METHODS:
    void Free()
      Description: Use this method to discard any resources consumed by the iterator. Revit will call it when done using the iterator.
    int ReadPoints(IntPtr buffer, int bufferSize)
      Description: Implement this method to fill the provided buffer with points up to the number of maximum points for which the buffer was allocated.
      @buffer: Memory buffer into which the points should be written. The buffer was allocated by Revit and it is guaranteed to be valid for the duration of the call.
      @bufferSize: The maximum number of CloudPoint objects that may be copied into the buffer.
      Returns: The actual number of CloudPoint objects placed in the buffer (can be less than the length of the buffer). If there are no more points available, return 0.

--------------------------------------------------------------------------------

[ENUM] PointCloudColorEncoding
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding

Description: The color encodings supported by Revit point clouds.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ARGB = 0
    - ABGR = 1

[CLASS] PointCloudColorSettings
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudColorSettings

Description: The color settings which are applied to a PointCloudInstance element, or one of its scans.
Remarks: For different color modes (PointCloudColorMode), the color settings mean different things: for single color, color1 means the display colorfor other modes (intensity, elevation), color1 and color2 form a gradient from min to maxfor no overrides and normals, color1 and color2 are not used
Implements: IDisposable

  CONSTRUCTORS:
    new PointCloudColorSettings(PointCloudColorSettings other)
    new PointCloudColorSettings(Color color1, Color color2)
    new PointCloudColorSettings(PointCloudColorMode mode)
    new PointCloudColorSettings()

  PROPERTIES:
    Color Color1 { get; }
      Description: Color 1
    Color Color2 { get; }
      Description: Color 2
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Assign(PointCloudColorSettings other)
      Description: Assigns values of the source settings to this object.
      @other: The source settings.
    void Dispose()
    bool IsEqual(PointCloudColorSettings other)
      Description: Check if the contents of two settings are equal.
      @other: The settings to be compared.
      Returns: True for equal, false otherwise.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PointCloudEngineRegistry
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudEngineRegistry

Description: This class supports registration of custom Point Cloud Engines in a Revit session.
Remarks: This class is the start point for engine providers. A custom engine implementation consists of the following: An implementation of IPointCloudEngine registered to Revit via the PointCloudEngineRegistry.An implementation of IPointCloudAccess coded to respond to inquiries from Revit regarding the properties of a single point cloud.An implementation of IPointSetIterator code to return sets of points to Revit when requested. Engine implementations may be file-based or non-file-based: File-based implementations require that each point cloud be mapped to a single file on disk. Revit will allow users to create new point cloud instances in a document directly by selecting point cloud files whose extension matches the engine identifier. These files are treated as external links in Revit and may be reloaded and remapped when necessary from the Manage Links dialog. Non-file-based engine implementations may obtain point clouds from anywhere (e.g. from a database, from a server, or from one part of a larger aggregate file). Because there is no file that the user may select, Revit's user interface will not allow a user to create a point cloud of this type. The engine provider should supply a custom command using PointCloudType.Create() and PointCloudInstance.Create() to create and place point clouds of this type. The Manage Links dialog will show the point clouds of this type, but since there is no file associated to the point cloud, the user cannot manage, reload or remap point clouds of this type.Regardless of the type of engine used, the implementation must supply enough information to Revit to display the contents of the point cloud. There are two ReadPoints methods which must be implemented: IPointCloudAccess.ReadPoints() - this provides a single set of points in a one-time call from Revit. Revit uses this during some display activities including selection prehighlighting. It is also possible for API clients to call this method directly (via PointCloudInstance.GetPoints()).IPointSetIterator.ReadPoints() - this provides a subset of points as a part of a larger iteration of points in the cloud. Revit uses this method during normal display of the point cloud; quantities of points will be requested repeatedly until it obtains enough points or until something in the display changes. The engine implementation must keep track of which points have been returned to Revit during any given point set iteration.

  METHODS:
    static IList<string> GetSupportedEngines()
      Description: Returns a list of the identifiers supported by point cloud engines registered to Revit.
      Returns: The list of identifiers.
    static bool IsEngineFileBased(string identifier)
      Description: Identifies if a given engine is file-based.
      @identifier: The engine identifier.
      Returns: True if the engine is file-based, false otherwise.
    static void RegisterPointCloudEngine(string identifier, IPointCloudEngine engine, bool isFileBased)
      Description: Registers a new point cloud engine and associates it to a particular file extension.
      @identifier: A string that distinguishes the engine being registered. If isFileBased is true, this should be the file extension (e.g. "rcs" or "rcp"). If isFileBased is false, this identifier is used only by API calls and should be unique.
      @engine: The point cloud engine that governs point clouds matching the input identifier.
      @isFileBased: Indicates to Revit if a single Point Cloud corresponds to a single file on disk.
    static void UnregisterPointCloudEngine(string identifier)
      Description: Unregisters the point cloud engine associated to a particular identifier.
      @identifier: The identifier of the engine to be unregistered.

--------------------------------------------------------------------------------

[CLASS] PointCloudFilter
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudFilter

Description: A class used to describe the criteria an application desires when obtaining members of a point cloud.
Remarks: Client applications which wish to obtain points from a point cloud will have to create a PointCloudFilter to define the volume of interest (see PointCloudFilterFactory). Engine implementations will need to use the methods contained within the point cloud to determine which points to return to Revit.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    PointCloudFilter Clone()
      Description: Returns a copy of the filter. The engine is permitted to copy the filter multiple times e.g. to parallelize filtering.
      Returns: A copy of the original filter.
    void Dispose()
    void PrepareForCell(XYZ min, XYZ max, int numTests)
      Description: Informs the filter that a series of points within a given cell is about to be checked.
      @min: The lower corner of the cell.
      @max: The upper corner of the cell.
      @numTests: The engine's estimate of the number of TestPoint() calls it is going to make for this cell.
    int TestCell(XYZ min, XYZ max)
      Description: Checks whether a given cell, i.e. a box aligned with the XYZ axes, is inside, outside or on the border of the volume of interest.
      @min: The lower corner of the cell.
      @max: The upper corner of the cell.
      Returns: -1 -- The cell is entirely rejected. 0 -- The cell partially belongs to the volume of interest. Use PrepareForCell() and TestPoint() to evaluate individual points. 1 -- The cell is fully accepted.
    bool TestPoint(CloudPoint point)
      Description: Checks if a point is inside the volume of interest.
      @point: The point to be tested.
      Returns: If true, the point is accepted, if false, the point is not accepted.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PointCloudFilterFactory
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory

Description: A factory class for creating point cloud filters.

  METHODS:
    static PointCloudFilter CreateMultiPlaneFilter(IList<Plane> planes)
      Description: Creates a new point cloud filter based upon planar boundaries.
      @planes: All planes used for filtering; positive direction of the normal should point inside the volume of interest. Only points on the "positive" side of all planes will pass the filter.
      Returns: Filter object; can be used to get representative set of cloud points passing through the filter.
    static PointCloudFilter CreateMultiPlaneFilter(IList<Plane> planes, int exactPlaneCount)
      Description: Creates a new point cloud filter based upon planar boundaries.
      @planes: All planes used for filtering; positive direction of the normal should point inside the volume of interest.
      @exactPlaneCount: This value represents the number of planes (taken in order of their addition) which will be used for exact filtering of individual points. Other planes in the filter will be used for faster, but inexact filtering based on cells.
      Returns: Filter object; can be used to get representative set of cloud points passing through the filter.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PointCloudFilterUtils
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudFilterUtils

Description: Utilities specific to point cloud filters.

  METHODS:
    static Outline GetFilteredOutline(PointCloudFilter filter, Outline box)
      Description: Computes outline of a part of a box that satisfies given PointCloudFilter.
      @filter: Point cloud filter.
      @box: A box aligned with coordinate axes.
      Returns: The bounding box of the set of all points within the original box that satisfy the filter. Not every point within the resulting outline satisfies the filter, but any point that is contained in the original box and satisfies the filter is guaranteed to be within the resulting outline.

--------------------------------------------------------------------------------

[CLASS] PointCloudOverrides
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudOverrides

Description: Graphic overrides that are stored by a view to be applied to a PointCloudInstance element, or a scan within the element.
Implements: IDisposable

  CONSTRUCTORS:
    new PointCloudOverrides()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static bool ArePointCloudOverrideSettingsValid(string tag, PointCloudOverrideSettings settings)
      Description: Checks if PointCloudOverrideSettings are valid
      @tag: The tag identifying the particular scan/region within the PointCloudInstance element. Tags can be obtained from PointCloudInstance via method getScans/getRegions.
      @settings: Override settings to be checked.
    void Assign(PointCloudOverrides other)
      Description: Assigns values of the source overrides to this object.
      @other: The source overrides.
    void Dispose()
    PointCloudOverrideSettings GetPointCloudRegionOverrideSettings(ElementId elementId, string regionTag, Document doc)
      Description: Gets override settings assigned to a particular region within a PointCloudInstance element.
      @elementId: Id of the overridden element.
      @regionTag: The tag identifying the particular region within the PointCloudInstance element. Tags can be obtained from PointCloudInstance via method getRegions.
      @doc: Document containing the overridden element.
      Returns: The override settings assigned to the region, if present, or a default override settings if nothing was found.
    PointCloudOverrideSettings GetPointCloudRegionOverrideSettings(ElementId elementId)
      Description: Gets region override settings assigned to the whole PointCloudInstance element.
      @elementId: Id of the overridden element.
      Returns: The override settings assigned to the element, if present, or a default override settings if nothing was found.
    PointCloudOverrideSettings GetPointCloudScanOverrideSettings(ElementId elementId, string scanTag, Document doc)
      Description: Gets override settings assigned to a particular scan within a PointCloudInstance element.
      @elementId: Id of the overridden element.
      @scanTag: The tag identifying the particular scan within the PointCloudInstance element. Tags can be obtained from PointCloudInstance via method getScans.
      @doc: Document containing the overridden element.
      Returns: The override settings assigned to the scan, if present, or a default override settings if nothing was found.
    PointCloudOverrideSettings GetPointCloudScanOverrideSettings(ElementId elementId)
      Description: Gets scan override settings assigned to the whole PointCloudInstance element.
      @elementId: Id of the overridden element.
      Returns: The override settings assigned to the element, if present, or a default override settings if nothing was found.
    bool IsEqual(PointCloudOverrides other)
      Description: Check if the contents of two overrides are equal.
      @other: The overrides to be compared.
      Returns: True for equal, false otherwise.
    void SetPointCloudRegionOverrideSettings(ElementId elementId, PointCloudOverrideSettings newSettings, string regionTag, Document doc)
      Description: Assigns override settings to a particular region within a PointCloudInstance element.
      @elementId: Id of the element to be overridden.
      @newSettings: Override settings to be assigned.
      @regionTag: The tag identifying the particular region within the PointCloudInstance element. Tags can be obtained from PointCloudInstance via method getRegions.
      @doc: Document containing the element to be overridden.
    void SetPointCloudRegionOverrideSettings(ElementId elementId, PointCloudOverrideSettings newSettings)
      Description: Assigns region override settings to the whole PointCloudInstance element.
      @elementId: Id of the element to be overridden.
      @newSettings: Override settings to be assigned.
    void SetPointCloudScanOverrideSettings(ElementId elementId, PointCloudOverrideSettings newSettings, string scanTag, Document doc)
      Description: Assigns scan override settings to a particular scan within a PointCloudInstance element.
      @elementId: Id of the element to be overridden.
      @newSettings: Override settings to be assigned.
      @scanTag: The tag identifying the particular scan within the PointCloudInstance element. Tags can be obtained from PointCloudInstance via method getScans.
      @doc: Document containing the element to be overridden.
    void SetPointCloudScanOverrideSettings(ElementId elementId, PointCloudOverrideSettings newSettings)
      Description: Assigns scan override settings to the whole PointCloudInstance element.
      @elementId: Id of the element to be overridden.
      @newSettings: Override settings to be assigned.

--------------------------------------------------------------------------------

[CLASS] PointCloudOverrideSettings
Full Name: Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings

Description: The graphic override settings for one PointCloudInstance element or one of its scans.
Implements: IDisposable

  CONSTRUCTORS:
    new PointCloudOverrideSettings(PointCloudOverrideSettings other)
    new PointCloudOverrideSettings()

  PROPERTIES:
    PointCloudColorMode ColorMode { get; set; }
      Description: The current color mode for the PointCloudInstance element or its scan.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Visible { get; set; }
      Description: Visibility flag for point cloud scans.

  METHODS:
    void Assign(PointCloudOverrideSettings other)
      Description: Assigns values of the source settings to this object.
      @other: The source settings.
    void Dispose()
    PointCloudColorSettings GetModeOverride(PointCloudColorMode mode)
      Description: Lookup color settings for the given color mode.
      @mode: Color mode for which to lookup the color settings.
      Returns: Color settings stored for the given color mode or default color settings if nothing is stored for the given color mode.
    bool IsEqual(PointCloudOverrideSettings other)
      Description: Checks if the contents of two settings are equal.
      @other: The settings to be compared.
      Returns: True for equal, false otherwise.
    void SetModeOverride(PointCloudColorMode mode, PointCloudColorSettings colorSettings)
      Description: Sets color settings for the given color mode.
      @mode: Color mode for which color settings are set.
      @colorSettings: Color settings to be set for the given color mode.

--------------------------------------------------------------------------------

[CLASS] PointCollection
Full Name: Autodesk.Revit.DB.PointClouds.PointCollection

Description: A class that represents a set of points created and returned by Revit in response to a query.
Implements: IEnumerable`1, IEnumerable, IDisposable

  PROPERTIES:
    int Count { get; }
      Description: The number of points in this collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IEnumerator<CloudPoint> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    IntPtr GetPointBufferPointer()
      Description: Returns an unsafe pointer to the buffer in which this collection stores the points.
      Returns: The pointer to the collection's storage.
    PointIterator GetPointIterator()
      Description: Creates and returns an iterator for the points contained in this collection.
      Returns: New iterator created, make sure to call 'free' on it when finished using it.

--------------------------------------------------------------------------------

[CLASS] PointIterator
Full Name: Autodesk.Revit.DB.PointClouds.PointIterator

Description: A class used to iterate individual points in a PointCollection.
Remarks: Points may be iterated in two different ways: In the traditional IEnumerable interface, you can iterate the resulting points directly from the PointCollection.In an unsafe interface usable only from C# and C++/CLI, you can get a pointer to the point storage of the collection and access the points directly in memory. Although you must deal with pointers directly, there may be performance improvements when traversing large buffers of points. Regardless of the approach used to obtain the points, the points are reported in the coordinate system of the point cloud. If you need the points in the coordinate system of the model, you will need to transform the point in those coordinates. The most direct way to do this is to obtain the transformation matrix from the PointCloudInstance (GetTransform()), convert the CloudPoint to an XYZ using the implicit conversion operator, and use Transform.OfPoint(XYZ).
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    CloudPoint Current { get; }
    object CurrentObject { get; }
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    void Free()
      Description: Completes lifetime of the iterator. Call it when done using the iterator.
    bool IsDone()
      Description: Identifies if the iteration has reached the end of the collection.
      Returns: True if the iteration has reached the end, false otherwise.
    bool MoveNext()
      Description: Increments the iterator to the next point in the collection.
      Returns: True if there is another available point in this iterator. False if the iterator has completed all available points.
    void Reset()
      Description: Resets the iterator to the beginning of the collection.

--------------------------------------------------------------------------------


