# Autodesk.Revit.DB (Types: C)

[ABSTRACT CLASS] CADExportOptions
Full Name: Autodesk.Revit.DB.CADExportOptions

Description: Generic CAD Export options.

--------------------------------------------------------------------------------


[CLASS] CADLinkOperations
Full Name: Autodesk.Revit.DB.CADLinkOperations

Description: This class is used to extend the IExternalResourceServer interface with methods to support operations specifically related to DWG links.
Remarks: The class owns single-method interfaces which are used as callbacks to perform specific operations on DWG link external resources.An empty CADLinkOperations instance is passed to an IExternalResourceServer (inside an ExternalResourceServerExtensions object) via the GetTypeSpecificServerOperations method. The server provider can then add their own implemented interface objects to the CADLinkOperations, thus making them available to Revit to use as callbacks.Supporting these additional, type-specific operations is not absolutely required, but is strongly recommended in order for users to be able to perform all the same operations they would with locally-accessed links.
Inherits: LinkOperations
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] CADLinkOptions
Full Name: Autodesk.Revit.DB.CADLinkOptions

Description: This class contains the options in use when or reloading a CAD link type (DWG, DXF, etc.)
Implements: IDisposable

  CONSTRUCTORS:
    new CADLinkOptions(bool preserveOverrides, ElementId viewId)
    new CADLinkOptions(CADLinkOptions other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool PreserveOverrides { get; set; }
      Description: Whether Revit should preserve the link's graphic overrides on reload.
    ElementId ViewId { get; set; }
      Description: The id of the view to use as the link's reference view, if the reference view has been deleted.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] CADLinkType
Full Name: Autodesk.Revit.DB.CADLinkType

Description: CADLinkType represents both CAD links and CAD imports. The function IsLink can be used to distinguish between the two. CAD imports are not ExternalFileReferences; they are brought completely into the document and maintain no connection to their original file.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    LinkLoadResult LoadFrom(ExternalResourceReference resourceReference)
      Description: Loads or reloads the DWG link from the given external resource reference.
      @resourceReference: An ExternalResourceReference giving the location of the link. This method can be used to load the link from a file on disk. See .
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
    LinkLoadResult LoadFrom(string path)
      Description: Loads or reloads the DWG link from the given file path.
      @path: A path on disk giving the location of the linked file. This path must be absolute. The link's path will remain PathType.Absolute or PathType.Relative, whichever it was before. If the link was previously to an external server location, the path type will be relative.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
    LinkLoadResult Reload(CADLinkOptions options)
      Description: Loads or reloads the link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      @options: Options for reloading the link. Options include the ability to preserve graphic overrides on reload.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
    LinkLoadResult Reload()
      Description: Loads or reloads the link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.

--------------------------------------------------------------------------------


[CLASS] CameraInfo
Full Name: Autodesk.Revit.DB.CameraInfo

Description: An object holding information about the projection mapping of a 3D view.
Remarks: CameraInfo can be obtained directly from a If camera info is not available, an orthographic view should be assumed. See also: .
Implements: IDisposable

  PROPERTIES:
    double FarDistance { get; }
      Description: Distance from eye point to far plane of view frustum along the view direction.
    double HorizontalExtent { get; }
      Description: Distance between left and right planes on the target plane.
    bool IsPerspective { get; }
      Description: Identifies whether the projection is orthographic or perspective
    bool IsPespective { get; }
      Description: Identifies whether the projection is orthographic or perspective
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double NearDistance { get; }
      Description: Distance from eye point to near plane of view frustum along the view direction.
    double RightOffset { get; }
      Description: Distance that the target plane is offset towards the right where right is normal to both Up direction and View direction. This offset shifts both left and right planes.
    double TargetDistance { get; }
      Description: Distance from eye point along view direction to target plane.
    double UpOffset { get; }
      Description: Distance that the target plane is offset in the direction of the Up direction. This offset shifts both top and bottom planes.
    double VerticalExtent { get; }
      Description: Distance between top and bottom planes on the target plane.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] CancellationListener
Full Name: Autodesk.Revit.DB.CancellationListener

Description: Allows clients to poll the cancellation status of a background operation. Revit instantiates CancellationListener objects for internal background operation implementations only. As such, third-party developers are not expected to instantiate or handle CancellationListener objects.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsCancelled()
      Description: Returns true if the operation associated with this instance has been cancelled.

--------------------------------------------------------------------------------


[CLASS] Categories
Full Name: Autodesk.Revit.DB.Categories

Description: The Categories object is a map that contains all the top-level Category objects within the Document.
Remarks: Use this object to retrieve categories by name or by BuiltInCategory id.
Inherits: CategoryNameMap
Implements: IDisposable, IEnumerable

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Whether or not the list of top-level categories is empty.
    Category Item { get; set; }
    Category Item { get; }
    int Size { get; }
      Description: The total number of top-level categories in the document.

  METHODS:
    bool Contains(string name)
      Description: Identifies if a category which has the specified name is in the list of top-level categories.
      @name: The name of the category to be retrieved.
    CategoryNameMapIterator ForwardIterator()
      Description: Retrieves a forward moving iterator to the map.
      Returns: A forward moving iterator to the map.
    IEnumerator GetEnumerator()
      Description: Retrieves a forward moving iterator to the map.
      Returns: A forward moving iterator to the map.
    bool Insert(string key, Category item)
      Description: Inserts the specified category with the specified name into the map.
      @key: The name to be used for inserting the category into the map.
      @item: The category to be inserted into the map.
      Returns: Whether or not the category was inserted into the map.
    Category NewSubcategory(Category parentCategory, string name)
      Description: Add a new subcategory into the Autodesk Revit document.
      @parentCategory: The parent category.
      @name: The new category name.
      Returns: If successful, the newly created subcategory.
    CategoryNameMapIterator ReverseIterator()
      Description: Retrieves a backward moving iterator to the map.
      Returns: A backward moving iterator to the map.

--------------------------------------------------------------------------------


[CLASS] Category
Full Name: Autodesk.Revit.DB.Category

Description: Represents the category or subcategory to which an element belongs.
Remarks: Categories are an important tool within Revit for identifying the inferred type of an element, such as anything in the Walls category should be considered as a wall. The API exposes access to the built in categories within Revit via the Document.Settings.Categories property.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    bool AllowsBoundParameters { get; }
      Description: To check if the category can have project parameters.
    bool AllowsVisibilityControl { get; }
    BuiltInCategory BuiltInCategory { get; }
      Description: Gets the BuiltInCategory value for this category.
    bool CanAddSubcategory { get; }
      Description: Indicates if subcategories can be assigned to the category.
    CategoryType CategoryType { get; }
      Description: Gets the category type of this category.
    bool HasMaterialQuantities { get; }
      Description: Identifies if elements of the category are able to report what materials they contain in what quantities.
    ElementId Id { get; }
      Description: Returns the category id associated with the category object.
    bool IsCuttable { get; }
      Description: Indicates if the category is cuttable or not.
    bool IsTagCategory { get; }
      Description: Identifies if the category is associated with a type of tag for a different category.
    bool IsValid { get; }
      Description: Indicates if the Category is valid or not.
    bool IsVisibleInUI { get; }
      Description: Identifies if the category is visible to the user and should be displayed in UI.
    Color LineColor { get; set; }
      Description: The color of lines shown for elements of this category.
    Material Material { get; set; }
      Description: Retrieves or changes the material of the category.
    string Name { get; }
      Description: The category name.
    Category Parent { get; }
      Description: Returns the parent category of this category.
    CategoryNameMap SubCategories { get; }
      Description: Returns a map containing all of the subcategories of this category.
    bool Visible { get; set; }

  METHODS:
    static BuiltInCategory GetBuiltInCategory(ForgeTypeId categoryTypeId)
      Description: Gets the BuiltInCategory value corresponding to the given built-in category identifier.
      @categoryTypeId: The built-in category identifier.
      Returns: The BuiltInCategory value corresponding to the given built-in category identifier.
    static ForgeTypeId GetBuiltInCategoryTypeId(BuiltInCategory categoryId)
      Description: Gets the ForgeTypeId identifying the given built-in category.
      @categoryId: The built-in category.
      Returns: The identifier of the given built-in category.
    static Category GetCategory(Document document, ElementId categoryId)
      Description: Retrieves a category object corresponding to the category id.
      @document: The document.
      @categoryId: An category id.
      Returns: Returns a category object corresponding to the category id.
    static Category GetCategory(Document document, BuiltInCategory categoryId)
      Description: Retrieves a category object corresponding to a BuiltInCategory id.
      @document: The document.
      @categoryId: A built in category id.
      Returns: Returns a category object corresponding to a BuiltInCategory id.
    GraphicsStyle GetGraphicsStyle(GraphicsStyleType graphicsStyleType)
      Description: Gets the graphics style associated with this category for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
    int GetHashCode()
    ElementId GetLinePatternId(GraphicsStyleType graphicsStyleType)
      Description: Gets the line pattern id associated with this category for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
      Returns: Returns the line pattern id associated with this category for the given graphics style type.
    Nullable<int> GetLineWeight(GraphicsStyleType graphicsStyleType)
      Description: Retrieves the line weight assigned to the category for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
    static bool IsBuiltInCategory(ForgeTypeId categoryTypeId)
      Description: Checks whether a ForgeTypeId identifies a built-in category.
      @categoryTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a built-in category, false otherwise.
    static bool IsBuiltInCategoryValid(BuiltInCategory builtInCategory)
      Description: Checks if a Category exists for a given BuiltInCategory.
      @builtInCategory: The BuiltInCategory to check.
    void SetLinePatternId(ElementId linePatternId, GraphicsStyleType graphicsStyleType)
      Description: Sets the line pattern id associated with this category for the given graphics style type.
      @linePatternId: The line pattern id for the graphics style.
      @graphicsStyleType: The type of graphics style.
    void SetLineWeight(int lineWeight, GraphicsStyleType graphicsStyleType)
      Description: Sets the line weight for the given graphics style type.
      @graphicsStyleType: The type of graphics style.

--------------------------------------------------------------------------------


[CLASS] CategoryNameMap
Full Name: Autodesk.Revit.DB.CategoryNameMap

Description: A map that contains a mapping of category name to its category object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CategoryNameMap()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the map is empty.
    Category Item { get; set; }
    int Size { get; }
      Description: Returns the number of categories that are in the map.

  METHODS:
    void Clear()
      Description: Removes every category from the map, rendering it empty.
    bool Contains(string key)
      Description: Tests for the existence of a category with that name within the map.
      @key: The category name to be searched for.
      Returns: The Contains method returns True if the name is within the map, otherwise False.
    int Erase(string key)
      Description: Removes a category with the specified name from the map.
      @key: The name of the category to be erased.
      Returns: The number of categories that were erased from the map.
    CategoryNameMapIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    bool Insert(string key, Category item)
      Description: Insert the specified category with the specified name into the map.
      @key: The name to be used for inserting the category into the map.
      @item: The category to be inserted into the map.
      Returns: Returns whether the category was inserted into the map.
    CategoryNameMapIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the map.
      Returns: Returns a backward moving iterator to the map.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CategoryNameMapIterator
Full Name: Autodesk.Revit.DB.CategoryNameMapIterator

Description: An iterator to a category name map.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CategoryNameMapIterator()

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the category that is the current focus of the iterator.
    string Key { get; }
      Description: Retrieves the category name that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the map.
    void Reset()
      Description: Bring the iterator back to the start of the map.

--------------------------------------------------------------------------------


[CLASS] CategorySet
Full Name: Autodesk.Revit.DB.CategorySet

Description: A set that can contains Category objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CategorySet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of categories that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Category item)
      Description: Tests for the existence of a category within the set.
      @item: The category to be searched for.
      Returns: The Contains method returns True if the category is within the set, otherwise False.
    int Erase(Category item)
      Description: Removes a specified category from the set.
      @item: The category to be erased.
      Returns: The number of items that were erased from the set.
    CategorySetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Category item)
      Description: Insert the specified category into the set.
      @item: The item to be inserted into the set.
      Returns: Returns whether the item was inserted into the set.
    CategorySetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CategorySetIterator
Full Name: Autodesk.Revit.DB.CategorySetIterator

Description: An iterator to a category set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CategorySetIterator()

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


[ENUM] CategoryType
Full Name: Autodesk.Revit.DB.CategoryType

Description: The type of category.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Invalid = 0
    - Model = 1
    - Annotation = 2
    - Internal = 4
    - AnalyticalModel = 5


[CLASS] Ceiling
Full Name: Autodesk.Revit.DB.Ceiling

Description: Represents a ceiling in Autodesk Revit.
Inherits: CeilingAndFloor
Implements: IDisposable

  PROPERTIES:
    ElementId SketchId { get; }
      Description: Returns id of the sketch.

  METHODS:
    static Ceiling Create(Document document, IList<CurveLoop> curveLoops, ElementId ceilingTypeId, ElementId levelId)
      Description: Creates a new instance of ceiling within the project.
      @document: The document in which the new ceiling is created.
      @curveLoops: An array of planar curve loops that represent the profile of the ceiling.
      @ceilingTypeId: Id of the ceiling type to be used by the new ceiling. If InvalidElementId is passed, the default type will be used.
      @levelId: Id of the level on which the ceiling is to be placed.
      Returns: If successful a new ceiling object within the project.
    static Ceiling Create(Document document, IList<CurveLoop> curveLoops, ElementId ceilingTypeId, ElementId levelId, Line slopeArrow, double slope)
      Description: Creates a new instance of ceiling within the project.
      @document: The document in which the new ceiling is created.
      @curveLoops: An array of planar curve loops that represent the profile of the ceiling.
      @ceilingTypeId: Id of the ceiling type to be used by the new ceiling. If InvalidElementId is passed, the default type will be used.
      @levelId: Id of the level on which the ceiling is to be placed.
      @slopeArrow: A line used to control the slope angle of the Ceiling. It must be horizontal.
      @slope: The slope angle.
      Returns: If successful a new ceiling object within the project.
    IList<Curve> GetCeilingGridLines(bool includeBoundary)
      Description: Get the geometric representation of the ceiling grid, optionally including the ceiling boundary.
      @includeBoundary: Include the boundary of the ceiling with the grid lines.
      Returns: The curves representing the ceiling grid, optionally including the ceiling boundary.

--------------------------------------------------------------------------------


[CLASS] CeilingAndFloor
Full Name: Autodesk.Revit.DB.CeilingAndFloor

Description: A base class that provides support for all ceiling and floor objects.
Inherits: HostObject
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] CeilingType
Full Name: Autodesk.Revit.DB.CeilingType

Description: Represents a ceiling type in Autodesk Revit.
Inherits: HostObjAttributes
Implements: IDisposable

  PROPERTIES:
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the CeilingType

--------------------------------------------------------------------------------


[ENUM] CellType
Full Name: Autodesk.Revit.DB.CellType

Description: Declares the cell data type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Text = 0
    - Graphic = 1
    - Parameter = 2
    - Inherited = 3
    - CombinedParameter = 4
    - CalculatedValue = 5
    - ParameterText = 6
    - CustomField = 7


[ENUM] ChangePriority
Full Name: Autodesk.Revit.DB.ChangePriority

Description: Enum used to specify the priority of an Updater during execution.
Remarks: The enumeration values are ordered in the order in which updaters associated to each priority will be run. For example, updaters associated to priority GridsLevelsReferencePlanes will run first, while updaters associated to priority Annotations will run last.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - GridsLevelsReferencePlanes = 0
    - Masses = 1
    - FloorsRoofsStructuralWalls = 2
    - Structure = 3
    - InteriorWalls = 4
    - DoorsOpeningsWindows = 5
    - MEPFixtures = 6
    - RoomsSpacesZones = 7
    - MEPCalculations = 8
    - FreeStandingComponents = 9
    - Connections = 10
    - Rebar = 11
    - MEPAccessoriesFittingsSegmentsWires = 12
    - MEPSystems = 13
    - Views = 14
    - DetailComponents = 15
    - Annotations = 16


[CLASS] ChangeType
Full Name: Autodesk.Revit.DB.ChangeType

Description: A class representing a change that can be detected and tracked during Dynamic Update.
Remarks: ChangeTypes for specific changes can be obtained from the static methods available on .
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static ChangeType ConcatenateChangeTypes(ChangeType changeType1, ChangeType changeType2)
      Description: Creates a ChangeType that is a union of the two input ChangeTypes
      @changeType1: First input ChangeType to be concatenated
      @changeType2: Second input ChangeType to be concatenated
      Returns: A new ChangeType that is a concatenation/union of the input change types
    bool Contains(ChangeType changeType)
      Description: Checks whether this ChangeType contains the input ChangeType
      Returns: True if input changeType is contained by this ChangeType
    void Dispose()
    bool IsIdentical(ChangeType changeType)
      Description: Compares if two ChangeTypes are identical
      @changeType: Input ChangeType to be compared
      Returns: True if the this ChangeType and input ChangeType are identical

--------------------------------------------------------------------------------


[ENUM] CheckoutStatus
Full Name: Autodesk.Revit.DB.CheckoutStatus

Description: Indicates the ownership status of an element
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - OwnedByCurrentUser = 0
    - OwnedByOtherUser = 1
    - NotOwned = 2


[CLASS] City
Full Name: Autodesk.Revit.DB.City

Description: An object that contains geographical location information for a known city.
Remarks: This object contains longitude, latitude, time zone information for a city already known by Revit. Currently Revit does not the ability to add cities to the existing list. The list of known cities can be retrieved using the Cities property on the application object.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    double Latitude { get; }
      Description: Latitude of the city
    double Longitude { get; }
      Description: Longitude of the city
    string Name { get; }
      Description: The name of the city
    double TimeZone { get; }
      Description: Time-zone in which the city resides
    string WeatherStation { get; }
      Description: An identifier for the nearest weather station

--------------------------------------------------------------------------------


[CLASS] CitySet
Full Name: Autodesk.Revit.DB.CitySet

Description: An set that contains cities.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CitySet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of cities that are in the set.

  METHODS:
    void Clear()
      Description: Removes every city from the set, rendering it empty.
    bool Contains(City item)
      Description: Tests for the existence of a city within the set.
      @item: The city to be searched for.
      Returns: The Contains method returns True if the city is within the set, otherwise False.
    int Erase(City item)
      Description: Removes a specified city from the set.
      @item: The city to be erased.
      Returns: The number of cities that were erased from the set.
    CitySetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(City item)
      Description: Insert the specified city into the set.
      @item: The city to be inserted into the set.
      Returns: Returns whether the city was inserted into the set.
    CitySetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CitySetIterator
Full Name: Autodesk.Revit.DB.CitySetIterator

Description: An iterator to a city set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CitySetIterator()

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


[CLASS] ClassificationEntries
Full Name: Autodesk.Revit.DB.ClassificationEntries

Description: A collection of ClassificationEntry objects that make up the classification table.
Inherits: KeyBasedTreeEntries
Implements: IEnumerable`1, IEnumerable, IDisposable

  METHODS:
    static bool LoadClassificationEntriesFromFile(string filePath, KeyBasedTreeEntriesLoadContent loadContent)
      Description: Loads the contents of a classification text file into the provided KeyBasedTreeEntriesLoadContent.
      @filePath: The full path of the existing classification file.
      @loadContent: The classification entries read from the filePath will be added to this object. A KeyBasedTreeEntriesLoadContent object will also be updated to contain status information, including information about any errors that occurred while reading the keynote entries from the specified file.
      Returns: True if reading the keynote file succeeds; False if the classification file cannot be read.

--------------------------------------------------------------------------------


[CLASS] ClassificationEntry
Full Name: Autodesk.Revit.DB.ClassificationEntry

Description: Represents an entry in the classification table.
Inherits: KeyBasedTreeEntry
Implements: IDisposable

  CONSTRUCTORS:
    new ClassificationEntry(string key, string parentKey, string description, int level, ElementId categoryId)

  PROPERTIES:
    ElementId CategoryId { get; }
      Description: The id of the category associated with this entry.
    string Description { get; }
      Description: The description associated with this entry.
    int Level { get; }
      Description: The entry level in the classification table. The expected range is between 1 and 5 inclusive.

  METHODS:
    bool HasBadCategoryId()
      Description: Checks if the category id is Revit BuiltInCategory id.
      Returns: True if the category id is not Revit BuiltInCategory id. False otherwise.
    bool HasBadLevel()
      Description: Checks if the level is an integer in range between 1 and 5 inclusive.
      Returns: True if the level is not an integer from 1 to 5 inclusive. False otherwise.
    bool HasInvalidKey()
      Description: Checks if the key matches the level and parent key.
      Returns: True if the key doesn't matach the level and parent key. False otherwise.

--------------------------------------------------------------------------------


[CLASS] ClosestPointsPairBetweenTwoCurves
Full Name: Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves

Description: This class captures results of computation of closest points between two generic curves.
Implements: IDisposable

  CONSTRUCTORS:
    new ClosestPointsPairBetweenTwoCurves()
    new ClosestPointsPairBetweenTwoCurves(ClosestPointsPairBetweenTwoCurves other)

  PROPERTIES:
    double Distance { get; set; }
      Description: Distance from point on first curve to the point on second curve.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double ParameterOnFirstCurve { get; set; }
      Description: 1d raw (not normalized) parameter of the point on the first curve.
    double ParameterOnSecondCurve { get; set; }
      Description: 1d raw (not normalized) parameter of the point on the second curve.
    XYZ XYZPointOnFirstCurve { get; set; }
      Description: Point on the first curve in 3d coordinates.
    XYZ XYZPointOnSecondCurve { get; set; }
      Description: Point on the second curve in 3d coordinates.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] Color
Full Name: Autodesk.Revit.DB.Color

Description: Represents a color in Autodesk Revit.
Remarks: Colors obtained from some API methods may represent an uninitialized/invalid color. You can identify these using the IsValid property.
Inherits: APIObject
Implements: IDisposable

  CONSTRUCTORS:
    new Color(Byte red, Byte green, Byte blue)

  PROPERTIES:
    Byte Blue { get; set; }
      Description: Get the blue channel of the color. Setting a channel is obsolete in Autodesk Revit 2013. Please create a new color instead.
    Byte Green { get; set; }
      Description: Get the green channel of the color. Setting a channel is obsolete in Autodesk Revit 2013. Please create a new color instead.
    static Color InvalidColorValue { get; }
      Description: Get the invalid Color whose IntegerValue is -1.
    bool IsValid { get; }
      Description: Identifies if the color represents a valid color, or an uninitialized/invalid value.
    Byte Red { get; set; }
      Description: Get the red channel of the color. Setting a channel is obsolete in Autodesk Revit 2013. Please create a new color instead.

--------------------------------------------------------------------------------


[CLASS] ColorBackgroundSettings
Full Name: Autodesk.Revit.DB.ColorBackgroundSettings

Description: Represents the rendering color background settings.
Inherits: BackgroundSettings
Implements: IDisposable

  PROPERTIES:
    Color Color { get; set; }
      Description: The color of the rendering background.

--------------------------------------------------------------------------------


[ENUM] ColorDepthType
Full Name: Autodesk.Revit.DB.ColorDepthType

Description: An enumerated type listing all Color Depth types of Print Setting.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BlackLine = 0
    - GrayScale = 1
    - Color = 2


[CLASS] ColorFillLegend
Full Name: Autodesk.Revit.DB.ColorFillLegend

Description: Represents color fill legend.
Remarks: Color fill legend is a 2D annotation element, it can be created through with specified category of color fill scheme, if there exists a valid color fill scheme activated for the category in the view. After a legend is created, its content and layout will keep consistent with the active color fill scheme of the view. You can adjust its position through property, or manually maintain its layout through property and/ methods.Notes: could be used to retrieve the corresponding color fill scheme of this legend, through the and properties. Note that there could only exist one active scheme for all spatial categories (rooms, areas, and zones) in one view. Once the height and column widths are explicitly set, they will be fixed even if the contents of the legend change. To retrieve correct height and column widths, it's better to manually retrieve the geometry of legend for nonvisible views. (Because color fill legend is a view specific element.) The value of property does not contain the line that displays "Calculating...".
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId ColorFillCategoryId { get; }
      Description: Returns the id of color fill category that this legend is created for.
    double Height { get; set; }
      Description: The height of the legend.
    XYZ Origin { get; set; }
      Description: The top left corner of the color fill legend.

  METHODS:
    static ColorFillLegend Create(Document document, ElementId viewId, ElementId catetoryId, XYZ origin)
      Description: Creates new instance of ColorFillLegend.
      @document: The document.
      @viewId: The id of the view to place legend in.
      @catetoryId: The id of category that color fill scheme belongs to.
      @origin: The origin point of the legend, must be on the view plane.
    IList<double> GetColumnWidths()
      Description: Returns array of column widths in the legend.
    void SetColumnWidths(IList<double> widths)
      Description: Sets array of column widths.

--------------------------------------------------------------------------------


[CLASS] ColorFillScheme
Full Name: Autodesk.Revit.DB.ColorFillScheme

Description: Represents a color scheme could be used to colorfy elements in floor plan views and section views.
Remarks: A color scheme is based on element category and one of the category parameter, it contains a set of which stores parameter value, color, fill pattern and other entry data. The entry paramater values may be a range or a single value, based on the property. Then elements with the specified category could be colored with the color and fill pattern of matching entry whose parameter value or value range matches the element parameter value.You can retrieve the entries with , or modify entries with , , and .Unlike most of the other elements, the color scheme works in an "asynchronous" way in UI:If document elements change, the color scheme will not be updated immediately.If color schemes changes, the document elements will not be updated immediately too.API works slightly different with UI: will return the entries corresponding to the latest document elements status immediately.The entries modification operation will retrieve the latest entries with at first, and then modify those entries by request, but document elements will still not be updated immediately.To modify multiple entries, it's better to use but not modify them one by one with other methods for better performance.Notes:To apply a color scheme whose property is OST_Areas to an area plan view, the property must be the same as the view if it is not used as a template. To generate a new color scheme, you have to use method to duplicate form an existing one.There should not exist two entries values that are the same in a color scheme. if the property is Double, then the value accuracy should be based on property.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId AreaSchemeId { get; }
      Description: Represents the id of AreaScheme of area plan views that this scheme could be applied to.
    ElementId CategoryId { get; }
      Description: Represents the element category that can be colored by this scheme.
    bool IsByRange { get; set; }
      Description: Represents if the parameter values in entries are treated as value range or not.
    bool IsLinkedFilesIncluded { get; set; }
      Description: Represent if the scheme includes entries whose parameter values are based on elements from linked files.
    ElementId ParameterDefinition { get; set; }
      Description: Represents the parameter of the elements that this scheme could be used to color.
    StorageType StorageType { get; }
      Description: Represents the type of parameter values stored in entries.
    string Title { get; set; }
      Description: Represents the title displayed in .

  METHODS:
    void AddEntry(ColorFillSchemeEntry entry)
      Description: Adds new entry to the scheme.
    EntryAndSchemeConsistency AreEntriesConsistentWithScheme(IList<ColorFillSchemeEntry> entries)
      Description: Checks whether the entries can be set to the scheme or not.
      @entries: The entries to check.
      Returns: The state of the entries and scheme consistency.
    bool CanDefineByRange()
      Description: Checks whether the scheme entries can be explained by range.
      Returns: Returns true ifthe scheme entries can be explained by range, false otherwise.
    bool CanRemoveEntry(ColorFillSchemeEntry entry)
      Description: Checks whether entry can be removed from the scheme.
      @entry: The entry to remove.
      Returns: Returns true if entry can be removed from the scheme, false otherwise.
    bool CanUpdateEntry(ColorFillSchemeEntry entry)
      Description: Checks whether entry exists in the scheme and not the same as input one.
      @entry: The entry to be updated.
      Returns: Returns true if entry exist in scheme and not the same as input one, false otherwise.
    ElementId Duplicate(string name)
      Description: Generates a copy of current scheme.
      @name: The desired name of copied scheme.
      Returns: The id of copied scheme.
    IList<ColorFillSchemeEntry> GetEntries()
      Description: Retrieves copies of all entries.
    FormatOptions GetFormatOptions()
      Description: Returns the FormatOptions of the scheme.
    IList<ElementId> GetSupportedParameterIds()
      Description: Retrieves collection of all parameters supported by the scheme.
    EntryAndSchemeConsistency IsEntryConsistentWithScheme(ColorFillSchemeEntry entry)
      Description: Checks whether an entry can be added to the scheme or not.
      @entry: The entry to check.
      Returns: The state of entry and scheme consistency.
    bool IsValidParameterDefinitionId(ElementId parameterId)
      Description: Checks whether the input parameter id can be applied to the scheme.
      Returns: Returns true if the input parameter id can be set to this scheme, false otherwise.
    bool IsValidSchemeName(string name)
      Description: Checks whether the name is valid for new generated scheme.
      Returns: Returns true if the name is valid for new generated scheme, false otherwise.
    void RemoveEntry(ColorFillSchemeEntry entry)
      Description: Removes an entry whose parameter value is the same as the input from the scheme
      @entry: The entry to remove.
    void SetEntries(IList<ColorFillSchemeEntry> entries)
      Description: Update scheme entries in batch mode.
      @entries: Collection of new entries.
    void SetFormatOptions(FormatOptions formatOptions)
      Description: Sets the FormatOptions of the scheme.
    void SortEntries()
      Description: Sorts the scheme entries ascending.
    void UpdateEntry(ColorFillSchemeEntry entry)
      Description: Updates the scheme entry with the same parameter value as the input entry.
      @entry: The entry to be updated.

--------------------------------------------------------------------------------


[CLASS] ColorFillSchemeEntry
Full Name: Autodesk.Revit.DB.ColorFillSchemeEntry

Description: Represents an entry of a .
Implements: IDisposable

  CONSTRUCTORS:
    new ColorFillSchemeEntry(StorageType storageType)

  PROPERTIES:
    string Caption { get; set; }
      Description: The text displayed in for this entry.
    Color Color { get; set; }
      Description: The filling color of this entry.
    ElementId FillPatternId { get; set; }
      Description: The id of fill pattern element of this entry.
    bool IsInUse { get; }
      Description: Represents if there exists at least one element colored based on this entry in the document.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVisible { get; set; }
      Description: Represents if the element colored based on this entry is visible in views.
    StorageType StorageType { get; }
      Description: The storage type of the value stored in this entry.

  METHODS:
    bool CanSetValue(ElementId value)
      Description: Checks whether of entry is ElementId.
      @value: New ElementId value.
      Returns: True if of the entry is ElementId and the entry, false otherwise.
    bool CanSetValue(double value)
      Description: Checks whether of entry is Double and the value is no less than 0.0.
      @value: New Double value.
      Returns: True if of the entry is Double and the value is finite, false otherwise.
    bool CanSetValue(int value)
      Description: Checks whether of entry is Integer.
      @value: New Integer value.
      Returns: True if of the entry is Integer, false otherwise.
    void Dispose()
    double GetDoubleValue()
      Description: Gets the Double value stored within the entry.
      Returns: The Double value contained in the entry.
    ElementId GetElementIdValue()
      Description: Gets the ElementId value stored within the entry.
      Returns: The ElementId contained in the entry.
    int GetIntegerValue()
      Description: Gets the Integer value stored within the entry.
      Returns: The Integer value contained in the entry.
    string GetStringValue()
      Description: Gets the String value stored within the entry.
      Returns: The String contained in the entry.
    void SetDoubleValue(double value)
      Description: Sets new Double value of entry.
    void SetElementIdValue(ElementId value)
      Description: Sets new ElementId value of entry.
    void SetIntegerValue(int value)
      Description: Sets new Integer value of entry.
    void SetStringValue(string value)
      Description: Sets new String value of entry.

--------------------------------------------------------------------------------


[CLASS] ColorOptions
Full Name: Autodesk.Revit.DB.ColorOptions

Description: A class providing access to color settings which affect the colors applied to specific views.
Remarks: ColorOptions are managed and stored along with other global application options and thus impact the application as a whole.
Implements: IDisposable

  PROPERTIES:
    Color AlertColor { get; set; }
      Description: The color of the current canvas theme used to highlight elements when a special alert is required.
    Color BackgroundColor { get; set; }
      Description: The background color of the current canvas theme applied to views.
    Color CalculatingColor { get; set; }
      Description: The color of the current canvas theme used to render elements when some aspect of their properties is currently being recalculated.
    Color EditingColor { get; set; }
      Description: The color of the current canvas theme used to render elements when editing.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color PreselectionColor { get; set; }
      Description: The color of the current canvas theme used to highlight candidates for selection before they are selected.
    Color SelectionColor { get; set; }
      Description: The color of the current canvas theme used to highlight selected elements.
    bool SelectionSemitransparent { get; set; }
      Description: Indicates whether or not selections will be shown in a semi-transparent manner in current canvas theme.

  METHODS:
    void Dispose()
    static ColorOptions GetColorOptions()
      Description: Returns the current Revit instance's ColorOptions.
      Returns: The ColorOptions for the current Revit instance.

--------------------------------------------------------------------------------


[CLASS] ColorWithTransparency
Full Name: Autodesk.Revit.DB.ColorWithTransparency

Description: Color with transparency
Implements: IDisposable

  CONSTRUCTORS:
    new ColorWithTransparency(UInt32 red, UInt32 green, UInt32 blue, UInt32 transparency)
    new ColorWithTransparency()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    UInt32 GetBlue()
      Description: get blue
      Returns: blue
    Color GetColor()
      Description: get color
      Returns: color
    UInt32 GetGreen()
      Description: get green
      Returns: green
    UInt32 GetRed()
      Description: get red
      Returns: red
    UInt32 GetTransparency()
      Description: get transparency
      Returns: transparency
    void SetBlue(UInt32 blue)
      Description: set blue
      @blue: blue
    void SetColor(Color color)
      Description: set color
      @color: color
    void SetGreen(UInt32 green)
      Description: set green
      @green: green
    void SetRed(UInt32 red)
      Description: set red
      @red: red
    void SetTransparency(UInt32 transparency)
      Description: set transparency
      @transparency: transparency

--------------------------------------------------------------------------------


[CLASS] ColumnAttachment
Full Name: Autodesk.Revit.DB.ColumnAttachment

Description: An object representing the attachment of the top or bottom of a column to some target: a floor, roof, ceiling, beam, or brace.
Remarks: Call IsValidColumn() and IsValidTarget() to verify that specific elements support column attachments. A column has at most one top attachment and one bottom attachment.
Implements: IDisposable

  PROPERTIES:
    double AttachOffset { get; set; }
      Description: The offset of the column attachment.
    int BaseOrTop { get; }
      Description: Identifies if this ColumnAttachment is at the base or top of the column.
    ColumnAttachmentCutStyle CutStyle { get; }
      Description: Identifies whether the column, or the attached element should be cut (or if neither should be cut).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ColumnAttachmentJustification Justification { get; }
      Description: Identifies the type of justification to apply to this ColumnAttachment.
    ElementId TargetId { get; }
      Description: The id of the element that is attached to the column and is described by this ColumnAttachment.

  METHODS:
    static void AddColumnAttachment(Document doc, FamilyInstance column, Element target, int baseOrTop, ColumnAttachmentCutStyle cutColumnStyle, ColumnAttachmentJustification justification, double attachOffset)
      Description: Attaches the column to the target. If an attachment already exists with the same "baseOrTop" value, no attachment is made.
      @doc: The document containing column and target.
      @column: A column.
      @target: A target element.
      @baseOrTop: 0 to attach the column base, 1 to attach the column top.
      @cutColumnStyle: Control the handling of columns that intersect their targets.
      @justification: Control the column extent in cases where the target is not a uniform height.
      @attachOffset: An additional offset for the bottom. If positive, the column base or top will be higher than the attachment point; if negative, lower.
    void Dispose()
    static ColumnAttachment GetColumnAttachment(FamilyInstance column, ElementId targetId)
      Description: Look up a column attachment by specifying the target id.
      @column: A column.
      @targetId: Id of a target element.
      Returns: The column attachment attaching the column to the target, or if there is no such attachment.
    static ColumnAttachment GetColumnAttachment(FamilyInstance column, int baseOrTop)
      Description: Look up a column attachment. There is at most one attachment on the base and one on the top.
      @column: A column.
      @baseOrTop: 0 for base, 1 for top.
      Returns: The column attachment for the base or top of the column, or if that end of the column is unattached.
    static bool IsValidColumn(FamilyInstance familyInstance)
      Description: Says whether a FamilyInstance supports column attachments.
      @familyInstance: A column.
    static bool IsValidTarget(bool forSlantedColumn, Element target)
      Description: Says whether the element can be used as a target for a new attachment.
      @forSlantedColumn: If true, check whether the target is valid for a slanted column; if false, check whether the target is valid for a vertical column.
      @target: A proposed target element for a column attachment.
    static bool IsValidTarget(FamilyInstance column, Element target)
      Description: Says whether the element can be used as a target for a new attachment.
      @column: The column to attach. If the target is a beam or brace, the column will be checked to see if it is slanted. Otherwise, this argument is not used and may be omitted.
      @target: A proposed target element for a column attachment.
    static void RemoveColumnAttachment(FamilyInstance column, ElementId targetId)
      Description: Removes any attachment of the column to the specified target.
      @column: A column.
      @targetId: Id of a target element.
    static void RemoveColumnAttachment(FamilyInstance column, int baseOrTop)
      Description: Removes an attachment at the top or base of a column, if there is one.
      @column: A column.
      @baseOrTop: 0 for base, 1 for top.
    void SetJustification(ColumnAttachmentJustification justification)
      Description: Setter of ColumnAttachmentJustification

--------------------------------------------------------------------------------


[ENUM] ColumnAttachmentCutStyle
Full Name: Autodesk.Revit.DB.ColumnAttachmentCutStyle

Description: Control the handling of columns that intersect their targets.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - CutColumn = 0
    - CutTarget = 1
    - None = 2


[ENUM] ColumnAttachmentJustification
Full Name: Autodesk.Revit.DB.ColumnAttachmentJustification

Description: Control the column extent in cases where the target is not a uniform height.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Minimum = 0
    - Midpoint = 1
    - Maximum = 2
    - Tangent = 3


[CLASS] CombinableElement
Full Name: Autodesk.Revit.DB.CombinableElement

Description: An element that can be added to a geometry combination.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    GeomCombinationSet Combinations { get; }
      Description: The geometry combinations that this element belongs to.

--------------------------------------------------------------------------------


[CLASS] CombinableElementArray
Full Name: Autodesk.Revit.DB.CombinableElementArray

Description: An array that contains CombinableElement objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CombinableElementArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    CombinableElement Item { get; set; }
    int Size { get; }
      Description: Returns the number of CombinableElements that are in the array.

  METHODS:
    void Append(CombinableElement item)
      Description: Add the element to the end of the array.
      @item: The CombinableElement to be added.
    void Clear()
      Description: Removes every CombinableElement from the array, rendering it empty.
    CombinableElementArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(CombinableElement item, int index)
      Description: Insert the specified element into the array.
      @item: The CombinableElement to be inserted into the array.
      @index: The CombinableElement will be inserted before this index.
      Returns: Returns whether the CombinableElement was inserted into the array.
    CombinableElementArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CombinableElementArrayIterator
Full Name: Autodesk.Revit.DB.CombinableElementArrayIterator

Description: An iterator to an CombinableElement array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CombinableElementArrayIterator()

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


[CLASS] ComponentRepeater
Full Name: Autodesk.Revit.DB.ComponentRepeater

Description: An element that contains and manages a set of repeated components.
Remarks: Component repeaters can be used to replicate (repeat) elements hosted on repeating references. The result of the repeating operation is a collection of slots. Each slot contains one repeated component. The ComponentRepeater class provides the repeating functionality and access to the slots. Each repeating reference is capable of hosting one point of an adaptive component. An initial pattern can be created by populating one or more repeating references with such points. Component repeaters can then be used to replicate the pattern to fill the rest of the repeating references in the particular repeating reference source. The repeating references in repeating reference source are arranged in one or two dimensional arrays, allowing for different kinds of repeating: One dimensional source allows for repeating along a path. Two dimensional source allows for repeating across a grid. It is also possible to host a point on a zero dimensional reference (a point). This point will be shared by all slots. A zero dimensional source allows for repeating around a single point. It should not be used alone, but together with at least one other repeating reference source (typically one dimensional.) The point hosted on the zero dimensional source serves as a central point around which other points can be repeated on their respective repeating reference sources. Multiple adaptive components may be hosted on one repeating reference source, and different points of one adaptive component may be hosted on different repeating reference sources, effectively allowing different points of an adaptive component to be repeated using different patterns. Following is a typical component repeater creation workflow: Get the default repeating reference source from a point element, divided path or divided surface. (See and .) Query the bounds of the repeating reference source to find a range of valid coordinates. (See and .) Create one or more instances of adaptive families that will be repeated. Host the individual points of an adaptive component on one or more repeating references. (See .) Repeat the set of adaptive components using the RepeatElements() method. Component repeaters can only be used in Massing families (the conceptual design environment).
Inherits: Element
Implements: IDisposable, IEnumerable`1, IEnumerable

  PROPERTIES:
    ElementId DefaultFamilyType { get; set; }
      Description: The default family type for the component repeater.
    int DimensionCount { get; }
      Description: The dimension count of the component repeater.

  METHODS:
    static bool CanElementBeRepeated(Document ADoc, ElementId elementId)
      Description: Determines whether an element can be repeated using the RepeatElements method.
      @ADoc: The document containing the element.
      @elementId: The element to be tested.
      Returns: True if the element can be repeated.
    IEnumerator<ComponentRepeaterSlot> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    bool IsTypeValidForRepeater(ElementId typeId)
      Description: Determines whether given family type can be used as the default type for the repeater.
      @typeId: The element id of the type.
      Returns: True if the family type can be used as the default type for the repeater.
    static ISet<ElementId> RemoveRepeaters(Document document, ISet<ElementId> elementIds)
      Description: Removes component repeaters from the document, but leaves the individual repeated components in their respective locations and hosted on their original hosts.
      @document: The document that contains the component repeaters to remove.
      @elementIds: The set of component repeaters that should be removed.
      Returns: A collection of components that were previously repeated by the component repeater.
    static IList<ComponentRepeater> RepeatElements(Document document, ICollection<ElementId> elementIds)
      Description: Repeats a set of adaptive component hosted on one or more repeating references.
      @document: The document that contains the elements.
      @elementIds: The set of adaptive components used as an input pattern for the repeating operation.
      Returns: One or more component repeater objects representing the result pattern of the repeating operation.

--------------------------------------------------------------------------------


[CLASS] ComponentRepeaterIterator
Full Name: Autodesk.Revit.DB.ComponentRepeaterIterator

Description: A slot iterator for ComponentRepeater.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    ComponentRepeaterSlot Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ComponentRepeaterSlot GetCurrent()
      Description: Returns the current repeater slot.
      Returns: The current slot.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------


[CLASS] ComponentRepeaterSlot
Full Name: Autodesk.Revit.DB.ComponentRepeaterSlot

Description: Represents a slot that holds one repeated component in a component repeater.
Remarks: Each slot can be in one of the following states: Empty. Occupied by an instance of the default family of the repeater that contains the slot. Occupied by an instance of another family. Initially, every occupied slot holds an instance of the default family of the repeater, based on the original element that was repeated.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId FamilyType { get; set; }
      Description: The id of the family type of the component in the slot, or invalid id if the slot is empty.
    bool IsDefault { get; }
      Description: A flag indicating whether the slot currently holds an instance of the default family type of the component repeater.
    bool IsEmpty { get; }
      Description: A flag indicating whether the slot is currently empty.

  METHODS:
    bool IsTypeValidForSlot(ElementId typeId)
      Description: Determines whether instance of given family type can be used in the component repeater slot.
      @typeId: The element id of the type.
      Returns: True if the family type can be used in the component repeater slot.
    void MakeDefault()
      Description: Populates the slot with an instance of the default family type of the component repeater.
    void MakeEmpty()
      Description: Makes the slot empty by removing the instance currently held by the slot.

--------------------------------------------------------------------------------


[ENUM] ComponentRotation
Full Name: Autodesk.Revit.DB.ComponentRotation

Description: ComponentRotation property of DividedSurface. See .
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Angle0 = 0
    - Angle90 = 90
    - Angle180 = 180
    - Angle270 = 270


[CLASS] CompoundStructure
Full Name: Autodesk.Revit.DB.CompoundStructure

Description: Describes the internal structure of a wall, floor, roof or ceiling.
Remarks: A compound structure consists a collection of ordered layers, proceeding from exterior to interior for a wall, or from top to bottom for a floor, roof or ceiling. The properties of these layers determine the thickness, material, and function of the overall structure of the associated wall, floor, roof or ceiling. Layers can be accessed via the method and completely replaced using SetLayers. Layers can also be accessed and modified individually using the "layer index", which is a value from in the range [0, LayerCount) identifying the layer in the structure. A structure supports the concept of "core layers" and "shell layers". There are two layer indices which identify where the boundary between core and shell layers occur in the list of layers. The boundaries between shell and core layers are identifiable using , , or . The core layer boundary can be changed with . Compound structures may be vertically compound. If is false, the CompoundStructure describes a series of parallel layers, each with specified width, function, material and other properties. If is true (which should apply only for CompoundStructures assigned to walls) then horizontal sections at different elevations may have different layered structures. In this case, the structure describes a vertical section via a rectangle which is divided into polygonal regions whose sides are all vertical or horizontal segments. A map associates each of these regions with the index of a layer in the CompoundStructure which determines the properties of that region.
Implements: IDisposable

  PROPERTIES:
    double CutoffHeight { get; set; }
      Description: Horizontal segments below or at the cutoff height have their distance to the wall bottom fixed, those above have their distance to the wall top fixed.
    EndCapCondition EndCap { get; set; }
      Description: Indicates the end cap condition defining which shell layers will participate in end wrapping.
    bool HasStructuralDeck { get; }
      Description: Checks if the compound structure has a structural deck.
    bool IsEmpty { get; }
      Description: Checks whether this CompoundStructure is empty.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVerticallyCompound { get; }
      Description: Identifies if this CompoundStructure represents a layout that is more complicated than a simple set of parallel layers.
    int LayerCount { get; }
      Description: Returns the number of layers contained in this CompoundStructure.
    double MinimumSampleHeight { get; }
      Description: The minimum sample height determined by the current sample height and the horizontal segments.
    OpeningWrappingCondition OpeningWrapping { get; set; }
      Description: Indicates the opening wrapping condition defining which shell layers of a wall, in plan view, wrap at inserts and openings.
    double SampleHeight { get; set; }
      Description: The sample height is the presumed height of the wall to which the data in this CompoundStructure is applied.
    int StructuralMaterialIndex { get; set; }
      Description: Indicates the layer whose material defines the structural properties of the type for the purposes of analysis.
    int VariableLayerIndex { get; set; }
      Description: Indicates the index of the layer which is designated as variable.

  METHODS:
    void AddWallSweep(WallSweepInfo wallSweepInfo)
      Description: Adds a new wall sweep or reveal to the compound structure.
      @wallSweepInfo: The wall sweep info to create a wall sweep.
    void AssociateRegionWithLayer(int regionId, int layerIdx)
      Description: Associates a region with a layer.
      @regionId: The id of a region.
      @layerIdx: The index of a layer in this CompoundStructure.
    bool CanLayerBeStructuralMaterial(int layerIndex)
      Description: Identifies if the input layer can be designated as defining the structural material for this structure.
      @layerIndex: Index of a layer in the CompoundStructure.
      Returns: True if the input layer may be used to define the structural material and false otherwise.
    bool CanLayerBeVariable(int variableLayerIndex)
      Description: Identifies if the input layer can be designated as a variable thickness layer.
      @variableLayerIndex: Index of a layer in the CompoundStructure.
      Returns: True if the input layer may be a variable thickness layer and false otherwise.
    bool CanLayerWidthBeNonZero(int layerIdx)
      Description: Identifies if changing the width of an existing layer from zero to a positive value will create a rectangular region.
      @layerIdx: The index of a CompoundStructureLayer.
    bool CanSplitAndMergeRegionsBeUsed()
      Description: Checks whether split and merge regions operations can be used for this compound structure.
      Returns: True if split and merge regions operation can be used for this compound structure, false otherwise.
    bool ChangeRegionWidth(int regionId, double newWidth)
      Description: Adjust the width of an existing simple region.
      @regionId: The id of a region.
      @newWidth: The desired width of the specified region.
      Returns: True if newWidth is zero and the region was deleted.
    void ClearWallSweeps(WallSweepType wallSweepType)
      Description: Removes all sweeps or reveals from the compound structure.
      @wallSweepType: The type of a wall sweep.
    static CompoundStructure CreateSimpleCompoundStructure(IList<CompoundStructureLayer> layers)
      Description: Creates a non-vertically compound structure comprised of parallel layers.
      @layers: An array which describes the parallel layers of this compound structure.
      Returns: A newly created compound structure.
    static CompoundStructure CreateSingleLayerCompoundStructure(double sampleHeight, MaterialFunctionAssignment layerFunction, double width, ElementId materialId)
      Description: Creates a vertically compound CompoundStructure with one layer.
      @sampleHeight: The sample height of this vertically compound structure.
      @layerFunction: The function of the single layer.
      @width: The width of the single layer.
      @materialId: The ElementId of the material for the single layer.
      Returns: The newly created compound structure.
    static CompoundStructure CreateSingleLayerCompoundStructure(MaterialFunctionAssignment layerFunction, double width, ElementId materialId)
      Description: Creates a CompoundStructure containing a single layer.
      @layerFunction: The function of the single layer.
      @width: The width of the single layer.
      @materialId: The ElementId of the material for the single layer.
      Returns: The newly created compound structure.
    bool DeleteLayer(int layerIdx)
      Description: Deletes the specified layer from this CompoundStructure.
      @layerIdx: The layer index is zero based. It counts from the exterior of wall and from the top of roofs, floors and ceilings.
      Returns: True if the layer was successfully deleted, and false otherwise.
    void Dispose()
    int FindEnclosingRegionAndSegments(UV gridUV, RectangularGridSegmentOrientation splitDirection, out int segmentId1, out int segmentId2)
    IList<int> GetAdjacentRegions(int segmentId)
      Description: Gets the ids of region bound to a specified segment.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: The ids of the regions that are bounded by the specified segment.
    int GetCoreBoundaryLayerIndex(ShellLayerType shellLayerType)
      Description: Returns the index of the layer just below the core boundary.
      @shellLayerType: If ShellLayerType.Exterior return the index on the exterior side (or top side for a roof, floor, or ceiling type). If ShellLayerType.Interior return the index on the interior side (or bottom side for a roof, floor, or ceiling type).
      Returns: The index of the layer.
    StructDeckEmbeddingType GetDeckEmbeddingType(int layerIdx)
      Description: Retrieves the deck embedding type used for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The embedding type of the structural deck associated to the specified layer. Invalid if it is not a structural deck.
    ElementId GetDeckProfileId(int layerIdx)
      Description: Retrieves the profile loop used for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The element id of a FamilySymbol which contains a profile loop used by a structural deck associated to the specified layer, or invalidElementId if isStructuralDeck(layerIdx) is false.
    IList<int> GetExtendableRegionIds(bool top)
      Description: Gets the extendable region ids for the compound structure.
      @top: If true, retrieve ids of regions which are extendable at the top, otherwise retrieve the ids of regions which are extendable at the bottom.
      Returns: An array of region ids which are marked extendable.
    int GetFirstCoreLayerIndex()
      Description: Gets the index of the first core layer.
      Returns: The index of the first core layer.
    int GetLastCoreLayerIndex()
      Description: Gets the index of the last core layer.
      Returns: The index of the last core layer.
    int GetLayerAssociatedToRegion(int regionId)
      Description: Gets the layer associated to a particular region.
      @regionId: The id of a region.
      Returns: The index of a layer in this CompoundStructure.
    MaterialFunctionAssignment GetLayerFunction(int layerIdx)
      Description: Retrieves the function of the specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The function of the layer.
    IList<CompoundStructureLayer> GetLayers()
      Description: A copy of the layers which define this compound structure.
      Returns: The layers, returned in order (Exterior to Interior for walls, top to bottom for roofs, floors or ceilings). The index of each layer in this array can be used in other CompoundStructure methods accepting a layer index.
    double GetLayerWidth(int layerIdx)
      Description: Retrieves the width of a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The width of the specified layer.
    ElementId GetMaterialId(int layerIdx)
      Description: Retrieves the material element id of a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The material element id.
    static double GetMinimumLayerThickness()
      Description: Get the minimum allowable layer thickness.
      Returns: The minimum allowable width of a layer in feet.
    int GetNumberOfShellLayers(ShellLayerType shellLayerType)
      Description: Retrieves the number of interior or exterior shell layers.
      @shellLayerType: If ShellLayerType.Exterior return the number of exterior shell layers (or top shell layers for a roof, floor, or ceiling type). If ShellLayerType.Interior return the number of interior shell layers (or bottom shell layers for a roof, floor, or ceiling type).
      Returns: The number of shell layers in the interior or exterior shell, as specified by shellLayerType.
    double GetOffsetForLocationLine(WallLocationLine wallLocationLine)
      Description: Returns the offset from the center of the compound structure to the given location line value.
      @wallLocationLine: The alignment type of the wall's location line.
      Returns: The offset.
    int GetPreviousNonZeroLayerIndex(int thisIdx)
      Description: Returns the index of the nearest non-zero width layer before this layer.
      @thisIdx: The layer from which to look for a non-zero width layer.
      Returns: The index of the layer found.
    BoundingBoxUV GetRegionEnvelope(int regionId)
      Description: Gets the envelope that a specified region spans.
      @regionId: The id of the region.
      Returns: The envelope of the region.
    IList<int> GetRegionIds()
      Description: Gets the region ids of this compound structure.
      Returns: The ids of the regions defining this CompoundStructure.
    IList<int> GetRegionsAlongLevel(double height)
      Description: Returns the ids of the regions encountered as the vertically compound structure is traversed at a constant height above the bottom a wall to which this structure is applied.
      @height: Distance from the bottom of the wall.
      Returns: The ids of the regions intersected by the specified line.
    IList<int> GetRegionsAssociatedToLayer(int layerIdx)
      Description: Gets the set of region ids associated to a particular layer.
      @layerIdx: The index of a layer in this CompoundStructure.
      Returns: An array of region ids which are associated to the specified layer.
    double GetSegmentCoordinate(int segmentId)
      Description: Gets the coordinate of a segment.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: The local coordinates of the specified segment.
    void GetSegmentEndPoints(int segmentId, int regionId, out UV end1, out UV end2)
    IList<int> GetSegmentIds()
      Description: Gets the segment ids of this compound structure.
      Returns: The ids of the segments which form the boundary of the regions of this CompoundStructure.
    RectangularGridSegmentOrientation GetSegmentOrientation(int segmentId)
      Description: Gets the orientation of a segment.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: The orientation of the specified segment.
    CompoundStructure GetSimpleCompoundStructure(double wallHeight, double distAboveBase)
      Description: Takes a horizontal slice through a sample wall to which this CompoundStructure is applied and returns a simple compound structure which describes that slice, i.e. a series of parallel layers.
      @wallHeight: The height of the wall.
      @distAboveBase: The distance from the base of the wall at which to take the section. If distAboveBase < 0, then internally distAboveBase = 0 is used. If distAboveBase > wallHeight, then internally distAboveBase = wallHeight is used.
      Returns: A simple CompoundStructure representing a series of parallel layers.
    IList<WallSweepInfo> GetWallSweepsInfo(WallSweepType wallSweepType)
      Description: Obtains a list of the intrinsic wall sweeps or reveals in this CompoundStructure.
      @wallSweepType: Whether to obtain wall sweeps or reveals.
      Returns: An array which describes the intrinsic wall sweeps or reveals.
    double GetWidth()
      Description: The width implied by this compound structure.
      Returns: The width of a host object with this compound structure.
    double GetWidth(int regionId)
      Description: Computes the width of the envelope (2d bounding box) of the specified region.
      @regionId: The id of a region in this vertically compound structure.
      Returns: The width of the envelope (2d bounding box) of the region.
    bool IsCoreLayer(int layerIdx)
      Description: Checks if the specified layer is a core layer.
      @layerIdx: The index of a layer in this CompoundStructure.
      Returns: Returns true if the layer is within the core layer boundary, false if it is in the interior or exterior shell layers.
    bool IsEqual(CompoundStructure otherStructure)
      Description: Checks whether this CompoundStructure is the same as another CompoundStructure.
      @otherStructure: A CompoundStructure.
      Returns: True if the two CompoundStructures are the same, and false otherwise.
    bool IsLayerValid(int layerIdx, CompoundStructureLayer layer)
      Description: Verifies that the data in this layer is internally consistent.
      @layerIdx: The index of the layer in the compound structure to be set.
      @layer: The layer to be set.
      Returns: True if the layer is internally consistent, false if the layer is not internally consistent.
    bool IsRectangularRegion(int regionId)
      Description: Determines whether the specified region is rectangular.
      @regionId: The id of a region.
      Returns: True if the specified region is a rectangle, false otherwise.
    bool IsSimpleRegion(int regionId)
      Description: Determines whether the region is a simple region in this CompoundStructure.
      @regionId: The id of a region in this vertically compound structure.
      Returns: True if the region is simple, false otherwise.
    bool IsStructuralDeck(int layerIdx)
      Description: Determines whether a specified layer is a structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: True if specified layer is a structural deck, and false otherwise.
    bool IsValid(Document doc, out IDictionary<int, CompoundStructureError> errMap, out IDictionary<int, int> twoLayerErrorsMap)
    bool IsValidRegionId(int regionId)
      Description: Determines whether the specified integer is actually the id of a region in this CompoundStructure.
      @regionId: The id of a region in this vertically compound structure.
      Returns: True if the region is valid, false otherwise.
    bool IsValidSampleHeight(double height)
      Description: Is the specified height a valid sample height for this compound structure?
    bool IsValidSegmentId(int segmentId)
      Description: Determines whether the specified integer is actually the id of a segment in this CompoundStructure.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: True if the specified segment is valid, false otherwise.
    bool IsVerticallyHomogeneous()
      Description: Indicates whether this CompoundStructure represents a single set of parallel layers.
      Returns: True if this CompoundStructure represents a series of parallel layers that stretch from bottom to top, false otherwise.
    int MergeRegionsAdjacentToSegment(int segmentId, int layerIdxForMergedRegion)
      Description: Merges the two regions which share the specified segment.
      @segmentId: The id of a segment in the underlying grid.
      @layerIdxForMergedRegion: The index of the layer to which the resulting region will be associated.
      Returns: The id of the resulting region. If -1 is returned, then the operation would have produced an invalid region and was not performed.
    bool ParticipatesInWrapping(int layerIdx)
      Description: Identifies if a layer is included in wrapping at inserts and ends.
      @layerIdx: The index of the layer.
      Returns: If true, then the layer participates in wrapping at inserts and openings. If false, the layer will not participate in wrapping.
    void RemoveWallSweep(WallSweepType wallSweepType, int id)
      Description: Removes a single sweep or reveal from the compound structure.
      @wallSweepType: The type of a wall sweep.
      @id: The id of the sweep or reveal to remove.
    void SetDeckEmbeddingType(int layerIdx, StructDeckEmbeddingType embedType)
      Description: Sets the deck embedding type to use for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      @embedType: The embedding type to be used by the specified layer if it is a structural deck.
    void SetDeckProfileId(int layerIdx, ElementId profileId)
      Description: Sets the profile loop to use for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      @profileId: The element id of a FamilySymbol which contains a profile loop to be used by the specified layer if it is a structural deck.
    void SetExtendableRegionIds(bool top, IList<int> regionIds)
      Description: Sets the extendable region ids for the compound structure.
      @top: If true, set ids of regions which are extendable at the top, otherwise set the ids of regions which are extendable at the bottom.
      @regionIds: The ids of regions which will be extendable.
    void SetLayer(int layerIdx, CompoundStructureLayer layer)
      Description: Sets a single layer for this CompoundStructure.
      @layerIdx: The index of a layer. This should range from 0 to the number of layers - 1.
      @layer: The layer to be set.
    void SetLayerFunction(int layerIdx, MaterialFunctionAssignment function)
      Description: Sets the function of the specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      @function: The function of the layer.
    void SetLayers(IList<CompoundStructureLayer> layers)
      Description: Completely resets this CompoundStructure and applies a new set of layers.
      @layers: The layers to be set.
    void SetLayerWidth(int layerIdx, double width)
      Description: Sets the width of a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      @width: The new width of the specified layer.
    void SetMaterialId(int layerIdx, ElementId materialId)
      Description: Sets a material element for a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      @materialId: The ElementId of a Material element.
    void SetNumberOfShellLayers(ShellLayerType shellLayerType, int numLayers)
      Description: Sets the number of interior or exterior shell layers.
      @shellLayerType: If ShellLayerType.Exterior set the number of exterior shell layers (or top shell layers for a roof, floor, or ceiling type). If ShellLayerType.Interior set the number of interior shell layers (or bottom shell layers for a roof, floor, or ceiling type).
      @numLayers: The number of layers to be in the specified shell.
    void SetParticipatesInWrapping(int layerIdx, bool participatesInWrapping)
      Description: Assigns if a layer is included in wrapping at inserts and ends.
      @layerIdx: The index of the layer.
      @participatesInWrapping: True if the specified layer will participate in wrapping at inserts and ends, false otherwise.
    int SplitRegion(UV gridUV, RectangularGridSegmentOrientation splitDirection)
      Description: Splits the region which contains the specified grid point by a line with the specified direction.
      @gridUV: Coordinates of a point in the rectangular grid of this compound structure.
      @splitDirection: Specifies the direction of the split.
      Returns: The id of the region created by this operation.
    int SplitRegion(UV gridUV, RectangularGridSegmentOrientation splitDirection, out int newSegmentId)

--------------------------------------------------------------------------------


[ENUM] CompoundStructureError
Full Name: Autodesk.Revit.DB.CompoundStructureError

Description: When CompoundStructure::isValid() returns false, it uses these values to indicate precise nature of defect.
Remarks: 'LayerTooThin' enum value was removed in 2016
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - BadShellOrder = 0
    - CoreTooThin = 1
    - MembraneTooThick = 3
    - NonmembraneTooThin = 4
    - BadShellsStructure = 5
    - ThinOuterLayer = 6
    - VerticalUnusedLayer = 7
    - VerticalWrongOrderLayer = 8
    - VerticalWrongOrderCoreExterior = 9
    - VerticalWrongOrderCoreInterior = 10
    - VerticalWrongOrderMembrane = 11
    - DeckCantBoundAbove = 12
    - DeckCantBoundBelow = 13
    - VarThickLayerCantBeZero = 14
    - InvalidMaterialId = 15
    - ExtensibleRegionsNotContiguousAlongTop = 16
    - ExtensibleRegionsNotContiguousAlongBottom = 17
    - InvalidProfileId = 18


[CLASS] CompoundStructureLayer
Full Name: Autodesk.Revit.DB.CompoundStructureLayer

Description: Describes a single layer in a CompoundStructure.
Implements: IDisposable

  CONSTRUCTORS:
    new CompoundStructureLayer(double width, MaterialFunctionAssignment function, ElementId materialId)
    new CompoundStructureLayer(CompoundStructureLayer cs)
    new CompoundStructureLayer()

  PROPERTIES:
    StructDeckEmbeddingType DeckEmbeddingType { get; set; }
      Description: Embedding type for structural deck - only for a layer whose function is StructuralDeck.
    ElementId DeckProfileId { get; set; }
      Description: The ElementId of the structural deck profile - only for a layer whose function is StructuralDeck.
    MaterialFunctionAssignment Function { get; set; }
      Description: The function of the layer.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool LayerCapFlag { get; set; }
      Description: Identifies if the layer participates in wrapping at end caps and/or inserts.
    int LayerId { get; }
      Description: The id of the layer - note that this may be different from the index in the array of layers in a CompoundStructure.
    ElementId MaterialId { get; set; }
      Description: Id of the material assigned to this layer.
    double Width { get; set; }
      Description: Width of the layer.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ConfigurationReloadInfo
Full Name: Autodesk.Revit.DB.ConfigurationReloadInfo

Description: This object contains information returned by a reload of the fabrication configuration.
Implements: IDisposable

  CONSTRUCTORS:
    new ConfigurationReloadInfo()

  PROPERTIES:
    int Disconnects { get; }
      Description: The number of disconnections caused by the reload.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int OutOfDatePartCount { get; }
      Description: The number of fabrication part instances that had newer versions and were out of date.
    bool ProfileNotAvailable { get; }
      Description: The current profile is not available in the disk configuration.

  METHODS:
    void Dispose()
    ConnectionValidationInfo GetConnectivityValidation()
      Description: Returns information about the post-reload connectivity validation.
      Returns: Information about the post-reload connectivity validation.
    ISet<ElementId> GetCustomDataChangedElements()
      Description: Gets a list of ElementIds of fabrication parts that had custom data updated during the reload.
      Returns: A list identifying changed elements.
    ReloadSwapOutInfo GetOutOfDatePartStatus(int index)
      Description: Access reload information for out of date part.
      @index: The index of the information about the part being reloaded. Must be between 0 and OutOfDatePartCount.
      Returns: Information about the part being reloaded.

--------------------------------------------------------------------------------


[CLASS] ConicalFace
Full Name: Autodesk.Revit.DB.ConicalFace

Description: A conical face of a 3d solid or open shell.
Remarks: For details on the parameterization, refer to the documentation for .
Inherits: Face
Implements: IDisposable

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the surface.
    double HalfAngle { get; }
      Description: Half angle of the surface.
    XYZ Origin { get; }
      Description: Origin of the surface.
    XYZ Radius { get; }

--------------------------------------------------------------------------------


[CLASS] ConicalSurface
Full Name: Autodesk.Revit.DB.ConicalSurface

Description: A Conical Surface.
Remarks: The parametric equation of the cone is S(u, v) = center + v*[sin(halfAngle)(cos(u)*xVec + sin(u)*yVec) + cos(halfAngle)*zVec]. Only the branch of the cone with v >= 0 should be used.
Inherits: Surface
Implements: IDisposable

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the cone. This is the Z axis of the local coordinate system associated with this cone.
    double HalfAngle { get; }
      Description: Cone angle.
    XYZ Origin { get; }
      Description: Apex of the cone. This is the origin of the local coordinate system associated with this cone.
    XYZ XDir { get; }
      Description: X axis of the local coordinate system associated with this cone.
    XYZ YDir { get; }
      Description: X axis of the local coordinate system associated with this cone.

  METHODS:
    static ConicalSurface Create(Frame frameOfReference, double halfAngle)
      Description: Creates a conical surface defined by a local reference frame and a half angle.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the cone. Frame.Origin is a point on the cylinder's axis.Frame.BasisZ points along the axis, while Frame.BasisX and Frame.BasisY are orthogonal to the axis. The frame may be either left-handed or right-handed (see Frame.IsRightHanded). Note that the "handedness" of the frame does not, by itself, determine the surface's orientation.
      @halfAngle: Cone angle. Must be not 0, lesser than PI/2 and greater than -PI/2.
      Returns: The created ConicalSurface.
    Frame GetFrameOfReference()
      Description: Returns frame of reference associated with this ConicalSurface.
      Returns: Frame of reference associated with this ConicalSurface.
    static bool IsValidConeAngle(double halfAngle)
      Description: Checks whether the input value lies is not 0, greater than -PI/2 and lesser than PI/2.
      @halfAngle: Cone half-angle parameter.
      Returns: True if input is not 0, lesser than PI/2 and greater than -PI/2, false otherwise.

--------------------------------------------------------------------------------


[ENUM] ConnectionResolution
Full Name: Autodesk.Revit.DB.ConnectionResolution

Description: An enumerated type listing all the possible resolutions for connectivity validation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Disconnected = 0


[CLASS] ConnectionValidationInfo
Full Name: Autodesk.Revit.DB.ConnectionValidationInfo

Description: This object contains information about fabrication connection validations.
Implements: IDisposable

  CONSTRUCTORS:
    new ConnectionValidationInfo()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ConnectionValidationWarning GetWarning(int index)
      Description: Access specific warning number of warnings generated by reload.
    bool IsValidWarningIndex(int index)
      Description: Validate warning index.
    int ManyWarnings()
      Description: Returns number of warnings generated by reload.

--------------------------------------------------------------------------------


[CLASS] ConnectionValidationWarning
Full Name: Autodesk.Revit.DB.ConnectionValidationWarning

Description: Contains information about a specific connection validation problem.
Implements: IDisposable

  CONSTRUCTORS:
    new ConnectionValidationWarning(ConnectionResolution resolution, ConnectionWarning reason, ElementId part1, ElementId part2)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ConnectionWarning Reason { get; }
      Description: Enumeration for reason of warning.
    ConnectionResolution Resolution { get; }
      Description: Enumeration for resolution that was applied.

  METHODS:
    void Dispose()
    ISet<ElementId> GetParts()
      Description: Get ElementIds of affected parts.

--------------------------------------------------------------------------------


[ENUM] ConnectionWarning
Full Name: Autodesk.Revit.DB.ConnectionWarning

Description: An enumerated type listing all the reasons for connectivity failure.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Unknown = 0
    - Alignment = 1
    - Size = 2
    - Shape = 3
    - Connectivity = 4


[CLASS] Connector
Full Name: Autodesk.Revit.DB.Connector

Description: A connector in an Autodesk Revit MEP project document.
Remarks: This connector is an item that is a part of another element (duct, pipe, fitting, or equipment etc.). This connector does not represent the connector element that can be created inside a family; for that element, refer to .
Implements: IConnector, IDisposable

  PROPERTIES:
    bool AllowsSlopeAdjustments { get; }
      Description: Indicates if the connector allows the slope adjustment.
    ConnectorSet AllRefs { get; }
      Description: All references of the connector.
    double Angle { get; set; }
      Description: The angle of the Connector.
    DuctFlowConfigurationType AssignedDuctFlowConfiguration { get; }
      Description: The assigned duct flow configuration of the connector.
    DuctLossMethodType AssignedDuctLossMethod { get; }
      Description: The duct loss method of the connector.
    double AssignedFixtureUnits { get; set; }
      Description: The assigned fixture units of the connector.
    double AssignedFlow { get; set; }
      Description: The assigned flow of the connector.
    FlowDirectionType AssignedFlowDirection { get; }
      Description: The assigned flow direction of the connector.
    double AssignedFlowFactor { get; set; }
      Description: The assigned flow factor of this connector.
    double AssignedKCoefficient { get; set; }
      Description: The assigned kCoefficient of the connector.
    double AssignedLossCoefficient { get; set; }
      Description: The assigned loss coefficient of the connector.
    PipeFlowConfigurationType AssignedPipeFlowConfiguration { get; }
      Description: The pipe flow configuration type of the connector.
    PipeLossMethodType AssignedPipeLossMethod { get; }
      Description: The pipe loss method of the connector.
    double AssignedPressureDrop { get; set; }
      Description: The assigned pressure drop of the connector.
    double Coefficient { get; }
      Description: The coefficient of the connector.
    ConnectorManager ConnectorManager { get; }
      Description: The connector manager of the connector.
    ConnectorType ConnectorType { get; }
      Description: The connector type of the connector.
    Transform CoordinateSystem { get; }
      Description: The coordinate system of the connector.
    double Demand { get; }
      Description: The demand of the connector.
    string Description { get; }
      Description: The description.
    FlowDirectionType Direction { get; }
      Description: The direction of the connector.
    Domain Domain { get; }
      Description: The domain of the connector.
    DuctSystemType DuctSystemType { get; }
      Description: The duct system type of the connector.
    ElectricalSystemType ElectricalSystemType { get; }
      Description: The electrical system type of the connector.
    double EngagementLength { get; }
      Description: Connector engagement length. When applicable, it represents the inset distance to the end of the fabrication part from the connection point. Otherwise it returns zero.
    double Flow { get; }
      Description: The flow of the connector.
    double GasketLength { get; }
      Description: Connector gasket length. When applicable, it represents the distance from the end of the fabrication part to the center of the gasket. Otherwise it returns zero.
    double Height { get; set; }
      Description: The height of the connector.
    int Id { get; }
      Description: A unique identifier to identify this connector.
    bool IsConnected { get; }
      Description: Identifies if the connector is physically connected to a connector on another element.
    bool IsMovable { get; }
      Description: whether the connector can be moved.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    MEPSystem MEPSystem { get; }
      Description: The system of the connector belong to.
    XYZ Origin { get; set; }
      Description: The location of the connector.
    Element Owner { get; }
      Description: The host of the connector.
    PipeSystemType PipeSystemType { get; }
      Description: The pipe system type of the connector.
    double PressureDrop { get; }
      Description: The pressure drop of the connector.
    double Radius { get; set; }
      Description: The radius of the connector.
    ConnectorProfileType Shape { get; }
      Description: The shape of the connector.
    bool Utility { get; }
      Description: Indicates if the connector is a utility connector.
    double VelocityPressure { get; }
      Description: The velocity pressure of the connector.
    double Width { get; set; }
      Description: The width of the connector.

  METHODS:
    void ConnectTo(Connector connector)
      Description: Make connection between two connectors.
      @connector: Indicate the connector will be connected to.
    void DisconnectFrom(Connector connector)
      Description: Remove connection between two connectors.
      @connector: Indicate the connector, connection will be removed from.
    void Dispose()
    FabricationConnectorInfo GetFabricationConnectorInfo()
      Description: Gets fabrication connectivity information.
      Returns: Returns if there is no fabrication connector information associated.
    MEPConnectorInfo GetMEPConnectorInfo()
      Description: Gets MEP connector information.
      Returns: Returns if there is no MEP connector information associated.
    bool IsConnectedTo(Connector connector)
      Description: Identifies if the connector is connected to the specified connector.

--------------------------------------------------------------------------------


[ENUM] ConnectorDomainType
Full Name: Autodesk.Revit.DB.ConnectorDomainType

Description: Type of connector domain.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Hvac = 1
    - Electrical = 2
    - Piping = 3
    - CableTrayConduit = 4
    - StructuralAnalytical = 5


[CLASS] ConnectorElement
Full Name: Autodesk.Revit.DB.ConnectorElement

Description: A base class that provides support for all connector elements occurring in families.
Inherits: Element
Implements: IDisposable, IConnector

  PROPERTIES:
    Transform CoordinateSystem { get; }
      Description: The coordinate system of the connector.
    XYZ Direction { get; }
      Description: Gets the direction of the connector element.
    Domain Domain { get; }
      Description: The domain of the connector.
    double Height { get; }
      Description: The height of the connector.
    bool IsPrimary { get; }
      Description: Identifies if this is the primary connector in the family.
    XYZ Origin { get; }
      Description: The location of the connector in family document.
    double Radius { get; }
      Description: The radius of the connector.
    ConnectorProfileType Shape { get; }
      Description: The shape of the connector.
    MEPSystemClassification SystemClassification { get; set; }
      Description: The system classification of the connector.
    double Width { get; }
      Description: The width of the connector.

  METHODS:
    void AssignAsPrimary()
      Description: Assign a connector as a primary connector.
    void ChangeHostReference(Reference planarFace, Edge edge)
      Description: Changes the connector host reference to a new planar face and a new edge loop.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the new connector location on the planar face.
    void ChangeHostReference(Reference planarFace)
      Description: Changes the connector host reference to a new planar face.
      @planarFace: The planar face to place the connector on.
    static ConnectorElement CreateCableTrayConnector(Document document, Reference planarFace, Edge edge)
      Description: Create a new cable tray ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The cable tray ConnectorElement.
    static ConnectorElement CreateCableTrayConnector(Document document, Reference planarFace)
      Description: Create a new cable tray ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      Returns: The cable tray ConnectorElement.
    static ConnectorElement CreateConduitConnector(Document document, Reference planarFace, Edge edge)
      Description: Create a new conduit ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The conduit ConnectorElement.
    static ConnectorElement CreateConduitConnector(Document document, Reference planarFace)
      Description: Create a new conduit ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      Returns: The conduit ConnectorElement.
    static ConnectorElement CreateDuctConnector(Document document, DuctSystemType ductSystemType, ConnectorProfileType profileShape, Reference planarFace, Edge edge)
      Description: Create a new duct ConnectorElement.
      @document: The document to add the connector to.
      @ductSystemType: The DuctSystemType of the connector.
      @profileShape: The profile shape of the duct.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The duct ConnectorElement.
    static ConnectorElement CreateDuctConnector(Document document, DuctSystemType ductSystemType, ConnectorProfileType profileShape, Reference planarFace)
      Description: Create a new duct ConnectorElement.
      @document: The document to add the connector to.
      @ductSystemType: The DuctSystemType of the connector.
      @profileShape: The profile shape of the duct.
      @planarFace: The planar face to place the connector on.
      Returns: The duct ConnectorElement.
    static ConnectorElement CreateElectricalConnector(Document document, ElectricalSystemType electricalSystemType, Reference planarFace, Edge edge)
      Description: Create a new electrical ConnectorElement.
      @document: The document to add the connector to.
      @electricalSystemType: The ElectricalSystemTYpe of the connector.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The electrical ConnectorElement.
    static ConnectorElement CreateElectricalConnector(Document document, ElectricalSystemType electricalSystemType, Reference planarFace)
      Description: Create a new electrical ConnectorElement.
      @document: The document to add the connector to.
      @electricalSystemType: The ElectricalSystemTYpe of the connector.
      @planarFace: The planar face to place the connector on.
      Returns: The electrical ConnectorElement.
    static ConnectorElement CreatePipeConnector(Document document, PipeSystemType pipeSystemType, Reference planarFace, Edge edge)
      Description: Create a new pipe ConnectorElement with a face and an edge.
      @document: The document to add the connector to.
      @pipeSystemType: The PipeSystemType of the connector.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The pipe ConnectorElement.
    static ConnectorElement CreatePipeConnector(Document document, PipeSystemType pipeSystemType, Reference planarFace)
      Description: Create a new pipe ConnectorElement.
      @document: The document to add the connector to.
      @pipeSystemType: The PipeSystemType of the connector.
      @planarFace: The planar face to place the connector on.
      Returns: The pipe ConnectorElement.
    void FlipDirection()
      Description: Reverses the direction of the connector element.
    ConnectorElement GetLinkedConnectorElement()
      Description: Get the linked connector element.
      Returns: The linked connector element. If , the connector has no link.
    bool IsSystemClassificationValid(MEPSystemClassification systemClassification)
      Description: Checks that the MEPSystemType is valid for the domain of connector.
      @systemClassification: The MEPSystemType to be validated.
      Returns: True if the MEPSystemType is valid for the domain of the connector, false otherwise.
    void SetLinkedConnectorElement(ConnectorElement otherConnector)
      Description: Set the linked connector element.
      @otherConnector: The connector to link to.

--------------------------------------------------------------------------------


[ENUM] ConnectorGenderType
Full Name: Autodesk.Revit.DB.ConnectorGenderType

Description: Connector gender type enum
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Male = 1
    - Female = 2


[ENUM] ConnectorJointType
Full Name: Autodesk.Revit.DB.ConnectorJointType

Description: Connector joint type enum
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Flanged = 1
    - Welded = 2
    - Threaded = 3
    - Grooved = 4
    - Glued = 5
    - Soldered = 6


[CLASS] ConnectorManager
Full Name: Autodesk.Revit.DB.ConnectorManager

Description: Provides access to the Connector Manager
Implements: IDisposable

  PROPERTIES:
    ConnectorSet Connectors { get; }
      Description: Return all the Connectors of the Connector Manager.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Element Owner { get; }
      Description: This property is used to retrieve the owner of the Connector Manager.
    ConnectorSet UnusedConnectors { get; }
      Description: Return all the unused Connectors of the Connector Manager.

  METHODS:
    void Dispose()
    Connector Lookup(int index)
      Description: Lookup the connector using the unique index value that identify this connector.
      @index: The unique index value.
      Returns: Returns the connector or null if a connector for the provided unique index value doesn't exist.

--------------------------------------------------------------------------------


[ENUM] ConnectorProfileType
Full Name: Autodesk.Revit.DB.ConnectorProfileType

Description: An enumerated type listing all connector profile types
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Round = 0
    - Rectangular = 1
    - Oval = 2
    - Invalid = -1


[CLASS] ConnectorSet
Full Name: Autodesk.Revit.DB.ConnectorSet

Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ConnectorSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Connector item)
    int Erase(Connector item)
    ConnectorSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Connector item)
    ConnectorSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ConnectorSetIterator
Full Name: Autodesk.Revit.DB.ConnectorSetIterator

Description: An iterator to a set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ConnectorSetIterator()

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


[ENUM] ConnectorType
Full Name: Autodesk.Revit.DB.ConnectorType

Description: An enumerated type listing all connector types for a connection
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Invalid = 0
    - End = 1
    - Curve = 2
    - Logical = 4
    - Reference = 8
    - Surface = 16
    - EndSurface = 17
    - Physical = 19
    - NonEnd = 30
    - MasterSurface = 32
    - MasterSurface = 32
    - Family = 49
    - NodeReference = 64
    - BlankEnd = 128
    - AnyEnd = 129
    - Super = 256
    - AllModes = 16777215


[CLASS] Construction
Full Name: Autodesk.Revit.DB.Construction

Description: Construction definition for Project Information.
Remarks: This is used to define the information in Constructions.xml.

  PROPERTIES:
    string Id { get; }
      Description: Get the id of the Construction.
    string Name { get; }
      Description: Get the name of the Construction.

--------------------------------------------------------------------------------


[CLASS] ContentNode
Full Name: Autodesk.Revit.DB.ContentNode

Description: This class represents a generic content node in a model-exporting process.
Remarks: Members of this class implement properties and methods common to all content classes, such as RPC and Light nodes. Attributes of a content note can be accessed via an Asset object.
Inherits: RenderNode
Implements: IDisposable

  METHODS:
    Asset GetAsset()
      Description: Returns an an instance of an Asset object, which contains definitions of the content node.
    Transform GetTransform()
      Description: A transformation matrix associated with the node.

--------------------------------------------------------------------------------


[CLASS] ContourSetting
Full Name: Autodesk.Revit.DB.ContourSetting

Description: Contour setting object that handles the contour information used to draw contours on elements.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    ContourSettingItem AddContourRange(double start, double stop, double step, ElementId subcategoryId)
      Description: Add a set of contours as a contour setting item to the current contour setting.
      @start: The contour range start elevation.
      @stop: The contour range stop elevation. Should be greater than start elevation.
      @step: The increment elevation of the contour range. Should be greater than zero.
      @subcategoryId: The contour line style subcategory id.
      Returns: The newly added contour setting item.
    ContourSettingItem AddSingleContour(double elevation, ElementId subcategoryId)
      Description: Add a single contour as a contour setting item to the current contour setting.
      @elevation: The contour elevation.
      @subcategoryId: The contour line style subcategory id.
      Returns: The newly added contour setting item.
    void DisableItem(ContourSettingItem item)
      Description: Disable a contour setting item of the current contour setting so that the item will not be used to draw contours.
      @item: The contour setting item to be disabled.
    void Dispose()
    void EnableItem(ContourSettingItem item)
      Description: Enable a contour setting item of the current contour setting so that the item will be used to draw contours.
      @item: The contour setting item to be enabled.
    IList<ContourSettingItem> GetContourSettingItems()
      Description: Get all contour setting items.
      Returns: An array of contour setting items.
    int GetItemIndex(ContourSettingItem item)
      Description: Get the index of a contour setting item of the current contour setting
      @item: The contour setting item.
      Returns: The index of the input contour setting item. -1 if the item is not found.
    bool IsItemEnabled(ContourSettingItem item)
      Description: Check if a ContourSettingItem is enabled
      @item: The contour setting item.
      Returns: True if the item is enabled, false otherwise.
    void RemoveItem(ContourSettingItem item)
      Description: Remove a contour setting item from the current contour setting.
      @item: The contour setting item to be removed.

--------------------------------------------------------------------------------


[CLASS] ContourSettingItem
Full Name: Autodesk.Revit.DB.ContourSettingItem

Description: Contour setting item that stores the information of a single contour or a set of contours.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Start { get; }
      Description: The contour range start elevation.
    double Step { get; }
      Description: The increment elevation of the contour range.
    double Stop { get; }
      Description: The contour range stop elevation.
    ElementId SubCategoryId { get; }
      Description: The contour line style subcategory id.
    ContourSettingItemType Type { get; }
      Description: The contour setting item type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] ContourSettingItemType
Full Name: Autodesk.Revit.DB.ContourSettingItemType

Description: The type of a ContourSettingItem
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Single = 0
    - UnboundedRange = 1
    - BoundedRange = 2


[CLASS] Control
Full Name: Autodesk.Revit.DB.Control

Description: A control in Autodesk Revit family document.
Remarks: The object represents a variety of different shapes of controls in family document. The different shapes of controls can handle the family instance in different ways. A vertical/horizontal arrow control rotates the instance by 180 degrees.A double vertical arrow control mirrors the instance geometry vertically.A double horizontal arrow control mirrors the instance geometry horizontally.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    XYZ Origin { get; }
      Description: The control origin.
    ControlShape Shape { get; }
      Description: The control shape.
    View View { get; }
      Description: The view.

--------------------------------------------------------------------------------


[ENUM] ControlShape
Full Name: Autodesk.Revit.DB.ControlShape

Description: An enumerated type listing four shapes of control that Autodesk Revit supports.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - VerticalArrow = 0
    - HorizontalArrow = 1
    - DoubleVerticalArrow = 2
    - DoubleHorizontalArrow = 3


[ENUM] CoordinatePlaneVisibility
Full Name: Autodesk.Revit.DB.CoordinatePlaneVisibility

Description: Visibility settings for ReferencePoint element's coordinate reference planes.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Never = 0
    - WhenSelected = 1
    - Always = 2


[CLASS] CopyPasteOptions
Full Name: Autodesk.Revit.DB.CopyPasteOptions

Description: Settings to control the behavior of a copy-paste operation.
Implements: IDisposable

  CONSTRUCTORS:
    new CopyPasteOptions()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IDuplicateTypeNamesHandler GetDuplicateTypeNamesHandler()
      Description: Returns current duplicate type names handler or if none is set.
    void SetDuplicateTypeNamesHandler(IDuplicateTypeNamesHandler handler)
      Description: Sets a custom duplicate type names handler. If this value is not set, the default handler is used. By default, Revit displays a modal dialog with options to either copy new types only, or cancel the operation.
      @handler: The duplicate type names handler.

--------------------------------------------------------------------------------


[CLASS] CurtainCell
Full Name: Autodesk.Revit.DB.CurtainCell

Description: Represents a CurtainCell within Autodesk Revit.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    CurveArrArray CurveLoops { get; }
      Description: The cell boundaries on the reference face. The boundaries can have more than one CurveLoop. Each item in the returned array represents a CurveLoop containing 3 or more than 3 edges.
    CurveArrArray PlanarizedCurveLoops { get; }
      Description: The planarized curve loops for cell boundaries. The boundaries can have more than one CurveLoop. Each item in the returned array represents a CurveLoop containing 3 or more than 3 edges.

--------------------------------------------------------------------------------


[CLASS] CurtainGrid
Full Name: Autodesk.Revit.DB.CurtainGrid

Description: Represents a curtain grid element within Autodesk Revit.
Remarks: This element is obtained from a curtain wall, curtain system, or curtain roof. A curtain wall has only one curtain grid, while a curtain system or curtain roof may have several curtain grids.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    double Grid1Angle { get; set; }
      Description: The angle for the U grid line pattern of the curtain grid.
    CurtainGridAlignType Grid1Justification { get; set; }
      Description: The justification for the U grid line pattern of the curtain grid.
    double Grid1Offset { get; set; }
      Description: The offset for the U grid line pattern of the curtain grid.
    double Grid2Angle { get; set; }
      Description: The angle for V grid line pattern of the curtain grid.
    CurtainGridAlignType Grid2Justification { get; set; }
      Description: The justification for the V grid line pattern of the curtain grid.
    double Grid2Offset { get; set; }
      Description: The offset for V grid line pattern of the curtain grid.
    int NumPanels { get; }
      Description: The number of panels.
    int NumULines { get; }
      Description: Get the number of grid lines in the U direction.
    int NumVLines { get; }
      Description: Get the number of grid lines in the V direction.

  METHODS:
    CurtainGridLine AddGridLine(bool isUGridLine, XYZ position, bool oneSegmentOnly)
      Description: Add a grid line to the curtain grid.
      @isUGridLine: If true, a U-direction grid line will be added. Otherwise, a V-direction grid line will be added.
      @position: The position of the grid line.
      @oneSegmentOnly: If it is true, only one segment is added. Otherwise, all segments will be added for the grid line.
      Returns: The created grid line is returned if the operation is successful. Otherwise, is returned.
    Element ChangePanelType(Element panel, ElementType newSymbol)
      Description: Change the type of a curtain panel.
      @panel: The panel to be changed, it can be a type of or .
      @newSymbol: The new symbol, it may be of or when the panel is hosted in a curtain wall. The new symbol can only be of type if the Panel is hosted in a curtain system.
      Returns: If operation succeeds, the modified panel element is returned.
    CurtainCell GetCell(ElementId uGridLineId, ElementId vGridLineId)
      Description: Get the specified cell located by the intersection of the grid lines.
      @uGridLineId: The id of a grid line in the U-direction used to locate the cell.
      @vGridLineId: The id of a grid line in the V-direction used to locate the cell.
      Returns: The cell.
    ICollection<CurtainCell> GetCurtainCells()
      Description: Gets the CurtainCells owned by this curtain grid.
      Returns: The CurtainCells owned by this curtain grid.
    ICollection<ElementId> GetMullionIds()
      Description: Gets all ElementIds of the mullions of the curtain grid.
      Returns: The mullion ElementIds
    Panel GetPanel(ElementId uGridLineId, ElementId vGridLineId)
      Description: Get the specified panel located by the intersection of the grid lines.
      @uGridLineId: The id of a grid line in the U-direction used to locate the panel.
      @vGridLineId: The id of a grid line in the V-direction used to locate the panel.
      Returns: The panel, or if the panel cannot be found at this intersection.
    ICollection<ElementId> GetPanelIds()
      Description: Gets all ElementIds of the panels of the curtain grid.
      Returns: The panel ElementIds
    ICollection<ElementId> GetUGridLineIds()
      Description: Gets all ElementIds of grid lines in the U direction.
      Returns: The U grid line ElementIds
    ICollection<ElementId> GetUnlockedMullionIds()
      Description: Gets all ElementIds of the unlocked mullions of the curtain grid.
      Returns: The unlocked mullion ElementIds
    ICollection<ElementId> GetUnlockedPanelIds()
      Description: Gets all ElementIds of the unlocked panels of the curtain grid.
      Returns: The unlocked panel ElementIds
    ICollection<ElementId> GetVGridLineIds()
      Description: Gets all ElementIds of grid lines in the V direction.
      Returns: The V grid line ElementIds

--------------------------------------------------------------------------------


[ENUM] CurtainGridAlignType
Full Name: Autodesk.Revit.DB.CurtainGridAlignType

Description: An enumerated to list CurtainGrid patterns.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoJustify = 0
    - Beginning = 1
    - Center = 2
    - End = 3


[CLASS] CurtainGridLine
Full Name: Autodesk.Revit.DB.CurtainGridLine

Description: Represents a CurtainGridLine within Autodesk Revit.
Inherits: HostObject
Implements: IDisposable

  PROPERTIES:
    CurveArray AllSegmentCurves { get; }
      Description: Retrieve the curves of all segments.
    CurveArray ExistingSegmentCurves { get; }
      Description: Retrieve all the existing segment curves of the grid line.
    Curve FullCurve { get; }
      Description: Retrieve the geometry curve of the curtain grid line.
    bool IsUGridLine { get; }
      Description: Retrieve the direction of a grid line.If it is true,we say it is a UGridLine,otherwise it is VGridLine
    bool Lock { get; set; }
      Description: Retrieves or changes the lock state of the curtain grid line.
    CurveArray SkippedSegmentCurves { get; }
      Description: Retrieve all the removed segment curves of the grid line.

  METHODS:
    void AddAllSegments()
      Description: All the segments on this grid line will be added.
    ElementSet AddMullions(Curve segment, MullionType mullionType, bool oneSegmentOnly)
      Description: Add mullions on the specified segments of a grid. If any segment already has a mullion, no change is made to that segment.
      @segment: Curve of the segment.
      @mullionType: The type of the mullion to add.
      @oneSegmentOnly: If true, add one mullion to the specified segment, otherwise add mullions to all the segments of the matching grid line.
      Returns: If operation succeeds, the created mullions will be returned.
    void AddSegment(Curve curve)
      Description: Add a segment based on the specified segment curve of the gridline.
      @curve: The curve used to locate the segment to be removed. This function will invoke regeneration.
    void RemoveSegment(Curve curve)
      Description: Remove the segment specified by the input curve.
      @curve: The curve used to locate the segment to be removed.

--------------------------------------------------------------------------------


[CLASS] CurtainGridSet
Full Name: Autodesk.Revit.DB.CurtainGridSet

Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CurtainGridSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(CurtainGrid item)
    int Erase(CurtainGrid item)
    CurtainGridSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(CurtainGrid item)
    CurtainGridSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CurtainGridSetIterator
Full Name: Autodesk.Revit.DB.CurtainGridSetIterator

Description: An iterator to a set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CurtainGridSetIterator()

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


[CLASS] CurtainSystem
Full Name: Autodesk.Revit.DB.CurtainSystem

Description: Provides access to the CurtainSystem object in Autodesk Revit.
Remarks: The user can create CurtainSystem object and change the internal properties.
Inherits: CurtainSystemBase
Implements: IDisposable

  PROPERTIES:
    CurtainGridSet CurtainGrids { get; }
      Description: Get all the CurtainGrid object of this CurtainSystem. Each CurtainGrid corresponds to one face.
    CurtainSystemType CurtainSystemType { get; set; }
      Description: get or set the type of the CurtainSystem.

  METHODS:
    void AddCurtainGrid(Reference face)
      Description: Add CurtainGrid on the specified face for the CurtainSystem.
      @face: The face new CurtainGrid will be created on.
    void RemoveCurtainGrid(Reference face)
      Description: Remove CurtainGrid from the specified face for the CurtainSystem.
      @face: The face CurtainGrid will be removed from.

--------------------------------------------------------------------------------


[CLASS] CurtainSystemBase
Full Name: Autodesk.Revit.DB.CurtainSystemBase

Description: Provides access to the CurtainSystemBase object in Autodesk Revit.
Remarks: This is the base class of CurtainSystem.
Inherits: HostObject
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] CurtainSystemType
Full Name: Autodesk.Revit.DB.CurtainSystemType

Description: An object that represents CurtainSystem type.
Inherits: HostObjAttributes
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] Curve
Full Name: Autodesk.Revit.DB.Curve

Description: A parametric curve.
Remarks: The concrete curves are defined by parametric equations. If the curve is bound, it is only defined for an interval in parameterization. Otherwise, it is defined for all values of the parameter.
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    double ApproximateLength { get; }
      Description: The approximate length of the curve.
    bool IsBound { get; }
      Description: Describes whether the parameter of the curve is restricted to a particular interval.
    bool IsClosed { get; }
      Description: Describes whether the curve is closed.
    bool IsCyclic { get; }
      Description: The boolean value that indicates whether this curve is cyclic.
    double Length { get; }
      Description: The exact length of the curve.
    double Period { get; }
      Description: The period of this curve.
    Reference Reference { get; }
      Description: Returns a stable reference to the curve.

  METHODS:
    Curve Clone()
      Description: Returns a copy of this curve.
      Returns: A copy of this curve.
    void ComputeClosestPoints(Curve otherCurve, bool withinThisCurveBounds, bool withinOtherCurveBounds, bool returnAllCriticalPnts, out IList<ClosestPointsPairBetweenTwoCurves> resultList)
    Transform ComputeDerivatives(double parameter, bool normalized)
      Description: Returns the vectors describing the curve at the specified parameter.
      @parameter: The parameter to be evaluated.
      @normalized: If false, param is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The transformation containing the point on the curve, the tangent vector, derivative of tangent vector, and bi-normal vector.
    double ComputeNormalizedParameter(double rawParameter)
      Description: Computes the normalized curve parameter from the raw parameter.
      @rawParameter: The raw parameter.
      Returns: The real number equal to the normalized curve parameter.
    double ComputeRawParameter(double normalizedParameter)
      Description: Computes the raw parameter from the normalized parameter.
      @normalizedParameter: The normalized parameter.
      Returns: The real number equal to the raw curve parameter.
    Curve CreateOffset(double offsetDist, XYZ referenceVector)
      Description: Creates a new curve that is an offset of the existing curve.
      @offsetDist: The signed distance that controls the offset.
      @referenceVector: A reference vector to define the offset direction.
      Returns: The new curve.
    Curve CreateReversed()
      Description: Creates a new curve with the opposite orientation of the existing curve.
      Returns: The new curve.
    Curve CreateTransformed(Transform transform)
      Description: Crates a new instance of a curve as a transformation of this curve.
      @transform: The transform to apply.
      Returns: The new curve.
    double Distance(XYZ point)
      Description: Returns the shortest distance from the specified point to this curve.
      @point: The specified point.
      Returns: The real number equal to the shortest distance.
    XYZ Evaluate(double parameter, bool normalized)
      Description: Evaluates and returns the point that matches a parameter along the curve.
      @parameter: The parameter to be evaluated.
      @normalized: If false, param is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The point evaluated along the curve.
    double GetEndParameter(int index)
      Description: Returns the raw parameter value at the start or end of this curve.
      @index: 0 for the start or 1 for end of the curve.
      Returns: The parameter.
    XYZ GetEndPoint(int index)
      Description: Returns the 3D point at the start or end of this curve.
      @index: 0 for the start or 1 for end of the curve.
      Returns: The curve endpoint.
    Reference GetEndPointReference(int index)
      Description: Returns a stable reference to the start point or the end point of the curve.
      @index: Use 0 for the start point; 1 for the end point.
      Returns: Reference to the point or if reference cannot be obtained.
    SetComparisonResult Intersect(Curve curve, out IntersectionResultArray resultArray)
    SetComparisonResult Intersect(Curve curve)
      Description: Calculates the intersection of this curve with the specified curve.
      @curve: The specified curve to intersect with this curve.
      Returns: SetComparisonResult.Overlap - One or more intersections were encountered. SetComparisonResult.Subset - The inputs are parallel lines with only one common intersection point, or the curve used to invoke the intersection check is a line entirely within the unbound line passed as argument curve.SetComparisonResult.Superset - The input curve is entirely within the unbound line used to invoke the intersection check.SetComparisonResult.Disjoint - There is no intersection found between the two curves.SetComparisonResult.Equal - The two curves are identical.
    bool IsInside(double parameter, out int end)
    bool IsInside(double parameter)
      Description: Indicates whether the specified parameter value is within this curve's bounds.
      @parameter: The raw curve parameter to be evaluated.
      Returns: True if the parameter is within the bounds, otherwise false.
    void MakeBound(double startParameter, double endParameter)
      Description: Changes the bounds of this curve to the specified values.
      @startParameter: The new parameter of the start point.
      @endParameter: The new parameter of the end point.
    void MakeUnbound()
      Description: Makes this curve unbound.
    IntersectionResult Project(XYZ point)
      Description: Projects the specified point on this curve.
      @point: The point to be projected.
      Returns: Geometric information if projection is successful.
    void SetGraphicsStyleId(ElementId id)
      Description: Sets the graphics style id for this curve.
      @id: The id of the GraphicsStyle element from which to apply the curve properties.
    IList<XYZ> Tessellate()
      Description: Valid only if the curve is bound. Returns a polyline approximation to the curve.

--------------------------------------------------------------------------------


[CLASS] CurveArrArray
Full Name: Autodesk.Revit.DB.CurveArrArray

Description: An array that can contain any type of object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CurveArrArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    CurveArray Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(CurveArray item)
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    CurveArrArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(CurveArray item, int index)
    CurveArrArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CurveArrArrayIterator
Full Name: Autodesk.Revit.DB.CurveArrArrayIterator

Description: An iterator to a array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CurveArrArrayIterator()

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


[CLASS] CurveArray
Full Name: Autodesk.Revit.DB.CurveArray

Description: An array that can contain curves.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CurveArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Curve Item { get; set; }
    int Size { get; }
      Description: Returns the number of curves that are in the array.

  METHODS:
    void Append(Curve item)
      Description: Add the curve to the end of the array.
      @item: The curve to be added.
    void Clear()
      Description: Removes every curve from the array, rendering it empty.
    CurveArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Curve item, int index)
      Description: Insert the specified curve into the array.
      @item: The curve to be inserted into the array.
      @index: The curve will be inserted before this index.
      Returns: Returns whether the curve was inserted into the array.
    CurveArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CurveArrayIterator
Full Name: Autodesk.Revit.DB.CurveArrayIterator

Description: An iterator to a curve array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CurveArrayIterator()

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


[CLASS] CurveByPoints
Full Name: Autodesk.Revit.DB.CurveByPoints

Description: A curve interpolating two or more points.
Remarks: The points to be interpolated are represented as ReferencePoints, which must already exist in the document. In terms of appearance and graphics control, CurveByPoints behaves similarly to ModelCurve. The main difference being that a ModelCurve refers to a SketchPlane, while a CurveByPoints does not. For more methods capable of accessing data from CurveByPoints elements, see the static class CurveByPointsUtils.
Inherits: CurveElement
Implements: IDisposable

  PROPERTIES:
    bool IsReferenceLine { get; set; }
    ReferenceType ReferenceType { get; set; }
      Description: Indicates the type of reference.
    SketchPlane SketchPlane { get; set; }
      Description: Override the SketchPlane property of CurveElement.
    GraphicsStyle Subcategory { get; set; }
      Description: The subcategory, or graphics style, of the CurveByPoints.
    bool Visible { get; set; }
      Description: Whether the point is visible when the family is loaded into a project.

  METHODS:
    ReferencePointArray GetPoints()
      Description: Get the sequence of points interpolated by this curve.
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility.
      Returns: A copy of visibility settings for the curve.
    void SetPoints(ReferencePointArray points)
      Description: Change the sequence of points interpolated by this curve.
      @points: An array of 2 or more ReferencePoints.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility.
    static bool SortPoints(ReferencePointArray arr)
      Description: Order a set of ReferencePoints in the same way Revit does when creating a curve from points.
      @arr: An array of ReferencePoints. The array is reordered if sortPoints returns true, and is unchanged if sortPoints returns false.
      Returns: False if the least-squares method is unable to find a solution; true otherwise.

--------------------------------------------------------------------------------


[CLASS] CurveByPointsArray
Full Name: Autodesk.Revit.DB.CurveByPointsArray

Description: An array that can contain CurveByPoints elements.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CurveByPointsArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    CurveByPoints Item { get; set; }
    int Size { get; }
      Description: Returns the number of curves that are in the array.

  METHODS:
    void Append(CurveByPoints item)
    void Clear()
      Description: Removes every curve from the array, rendering it empty.
    CurveByPointsArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(CurveByPoints item, int index)
    CurveByPointsArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] CurveByPointsArrayIterator
Full Name: Autodesk.Revit.DB.CurveByPointsArrayIterator

Description: An iterator to a CurveByPoints array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CurveByPointsArrayIterator()

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


[CLASS] CurveByPointsUtils
Full Name: Autodesk.Revit.DB.CurveByPointsUtils

Description: A static class that contains methods for processing curves driven by points.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static void AddCurvesToFaceRegion(Document document, IList<ElementId> curveElemIds)
      Description: Adds The CurveElements to one or more FaceRegions.
      @document: The Document.
      @curveElemIds: The ElementIds of CurveElements which are to define the FaceRegion.
    static CurveElement CreateArcThroughPoints(Document document, ReferencePoint startPoint, ReferencePoint endPoint, ReferencePoint interiorPoint)
      Description: Creates an arc through the given reference points.
      @document: The Document.
      @startPoint: The start point of the arc.
      @endPoint: The end end of the arc.
      @interiorPoint: The interior point on the arc.
      Returns: The CurveElement to be created.
    static void CreateRectangle(Document document, ReferencePoint startPoint, ReferencePoint endPoint, CurveProjectionType projectionType, bool boundaryReferenceLines, bool boundaryCurvesFollowSurface, out IList<ElementId> createdCurvesIds, out IList<ElementId> createdCornersIds)
    void Dispose()
    static IList<Reference> GetFaceRegions(Document cda, Reference referenceOfFace)
      Description: Gets the FaceRegions in the existing face.
      @cda: The Document.
      @referenceOfFace: The Reference of the existing face.
      Returns: The FaceRegions in the existing face, or an empty collection if no FaceRegions are found.
    static Reference GetHostFace(CurveElement curveElem)
      Description: Gets the host face to which the CurveElement is added.
      @curveElem: The CurveElement.
      Returns: The host face to which the CurveElement is added, or an empty Reference if the host is not a face.
    static CurveProjectionType GetProjectionType(CurveElement curveElem)
      Description: Gets the projection type of the CurveElement.
      @curveElem: The CurveElement.
      Returns: The projection type.
    static bool GetSketchOnSurface(CurveElement curveElem)
      Description: Gets the relationship between the CurveElement and face.
      @curveElem: The CurveElement.
      Returns: Whether or not the CurveElement should lie on the face and be able to be added to the face.
    static void SetProjectionType(CurveElement curveElem, CurveProjectionType value)
      Description: Sets the projection type of the CurveElement.
      @curveElem: The CurveElement.
      @value: The input projection type.
    static void SetSketchOnSurface(CurveElement curveElem, bool sketchOnSurface)
      Description: Sets the relationship between the CurveElement and face.
      @curveElem: The CurveElement.
      @sketchOnSurface: Whether or not the CurveElement should lie on the face and be able to be added to the face.
    static bool ValidateCurveElementIdArrayForFaceRegions(Document document, IList<ElementId> curveElemIds)
      Description: Validates that the input CurveElements can define FaceRegions. The CurveElements must be CurveByPoints. Each curve must be entirely hosted by a single Face or hosts related to a common Face (for example, Edges of a common Face, other CurveElements hosted by a common Face). To be added to the FaceRegion definition, a CurveElement must have the SketchOnSurface attribute set.
      @document: The Document.
      @curveElemIds: The CurveElements.

--------------------------------------------------------------------------------


[ENUM] CurvedEdgeConditionParam
Full Name: Autodesk.Revit.DB.CurvedEdgeConditionParam

Description: The allowed values for the HOST_SSE_CURVED_EDGE_CONDITION_PARAM parameter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotApplicable = 0
    - ConformToCurve = 1
    - ProjectToSideFace = 2


[CLASS] CurveElement
Full Name: Autodesk.Revit.DB.CurveElement

Description: Class representing curve elements.
Remarks: As a base class of several specialized curved elements (such as ModelCurve, ModelLine, CurveByPoints, etc.) CurveElement exposes methods and properties of general use applicable to most kinds of curves.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    Reference CenterPointReference { get; }
      Description: Centerpoint reference of curve element. Curves such as circles, arcs, ellipses, and partial ellipses support this property.
    CurveElementType CurveElementType { get; }
      Description: Type of the curve element.
    Curve GeometryCurve { get; set; }
      Description: Geometry curve of the curve element.
    Element LineStyle { get; set; }
      Description: The line style of this curve element.
    SketchPlane SketchPlane { get; set; }
      Description: The sketch plane the curve element lies in.
    bool SupportsTangentLocks { get; }
      Description: Indicates whether or not this curve element can have a locked tangent join at either of its end-points shared with another curve element.

  METHODS:
    static CurveElement CreateAreaBasedLoadBoundaryLine(Document document, Curve curve, ElementId levelId)
      Description: Creates an area based load boundary line.
      @document: The document in which to create the area based load boundary line.
      @curve: The curve.
      @levelId: The id of level.
      Returns: The newly created area based load boundary line.
    static IList<CurveElement> CreateAreaBasedLoadBoundaryLines(Document document, IList<Curve> curves, ElementId levelId)
      Description: Creates area based load boundary lines.
      @document: The document in which to create the area based load boundary lines.
      @curves: The curves.
      @levelId: The id of level.
      Returns: The newly created area based load boundary lines.
    ISet<ElementId> GetAdjoinedCurveElements(int end)
      Description: Returns elements that are joining with this curve element at the given end point.
      @end: Id of one the curve's end. Value '0' indicates start and '1' indicates the end of the curve, respectively.
      Returns: Collection of Ids of Curve Elements.
    AreaBasedLoadBoundaryLineData GetAreaBasedLoadBoundaryLineData()
      Description: Gets the area based load boundary line data from this curve, if applicable.
      Returns: The area based load boundary line data, if this is an area based load boundary, or otherwise.
    ICollection<ElementId> GetLineStyleIds()
      Description: Ids of all line style Elements that are applicable to this curve element.
      Returns: A collection of Ids of line style elements.
    bool GetTangentLock(int end, ElementId other)
      Description: Returns the state of a tangent join between this and another curve element at the given end-point.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      Returns: Returns True if this curve element has a tangent joint with the other input element and the join is curently locked; returns False otherwise.
    bool HasTangentJoin(int end, ElementId other)
      Description: Tests whether this curve element and the input curve element have common tangent join at the given end-point.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      Returns: Returns True if the two curve elements have a tangent join at the given end-point.
    bool HasTangentLocks(int end)
      Description: Tests whether this curve element has any locked tangent joins at the given end-point.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      Returns: Returns True if the curve element is tangentially locked to at least one other curve element at the given end-point; returns False otherwise.
    bool IsAdjoinedCurveElement(int end, ElementId other)
      Description: This method tests whether this and the given curve elements are joined at the given end.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      Returns: Returns True if the input curve element joins This curve element at the given end-point; returns False otherwise.
    void SetGeometryCurve(Curve curve, bool overrideJoins)
      Description: Sets the geometry of the curve element. After the curve geometry is set, other nearby curves may join to the new curve geometry.
      @curve: The new curve.
      @overrideJoins: An option to specify whether or not existing joins will affect setting the geometry of the CurveElement. Setting this parameter to false is essentially the same as directly setting the property.
    void SetSketchPlaneAndCurve(SketchPlane sketchPlane, Curve curve)
      Description: Sets the sketch plane and the curve for this CurveElement.
      @sketchPlane: The new sketch plane.
      @curve: The new curve.
    void SetTangentLock(int end, ElementId other, bool state)
      Description: Sets a new status for an existing tangent join with another curve element at the given end-point.
      @end: Index of one of the curve's ends. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      @state: Requested new state of the lock; True to lock it, False to unlock it.

--------------------------------------------------------------------------------


[CLASS] CurveElementFilter
Full Name: Autodesk.Revit.DB.CurveElementFilter

Description: A filter used to pass curve elements which are of a specific type.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new CurveElementFilter(CurveElementType curveElementType, bool inverted)
    new CurveElementFilter(CurveElementType curveElementType)

  PROPERTIES:
    CurveElementType CurveElementType { get; }
      Description: The curve element type.

--------------------------------------------------------------------------------


[ENUM] CurveElementType
Full Name: Autodesk.Revit.DB.CurveElementType

Description: An enumerated type listing the curve element types that can be used when filtering elements (via CurveElementFilter).
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Invalid = 0
    - ModelCurve = 1
    - DetailCurve = 2
    - SymbolicCurve = 3
    - ReferenceLine = 4
    - SpaceSeparation = 5
    - RoomSeparation = 6
    - AreaSeparation = 7
    - CurveByPoints = 8
    - RepeatingDetail = 9
    - Insulation = 10
    - Cloud = 11
    - AreaBasedLoadBoundary = 12


[CLASS] CurveExtents
Full Name: Autodesk.Revit.DB.CurveExtents

Description: Represents the start and end parameters for a curve segment.
Implements: IDisposable

  PROPERTIES:
    double EndParameter { get; }
      Description: The end parameter of the curve extents.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double StartParameter { get; }
      Description: The start parameter of the curve extents.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] CurveLoop
Full Name: Autodesk.Revit.DB.CurveLoop

Description: A class that represents a chain of curves.
Remarks: There are specific requirements for how valid CurveLoops must be formed: The curves should typically be contiguous.The CurveLoop may be either closed (where the start and end points coincide) or open.There should be no self-intersections. A CurveLoop is said to be "continuous" if either: the loop contains at most one curvethe end of each curve coincides with the start of the next one (if there is a next curve). Many geometry utilities require CurveLoops to be continuous, but discontinuous CurveLoops are sometimes used. For example, the curves in a continuous CurveLoop may be offset, resulting in a discontinuous loop if the offset curves overlap or do not meet, and the offset curves might then be extended or trimmed to form a continuous CurveLoop. A CurveLoop is said to be "closed" if it is non-empty, continuous, and if either: the loop contains just one curve, which is unbounded and periodicthe loop's end point coincides with its start point For example, a CurveLoop comprising four lines forming a rectangle, listed in order around the rectangle, with each curve oriented in direction in which the curves are listed is closed. As another example, a CurveLoop consisting of just one unbounded circle is closed. A CurveLoop is said to be "open" if it is not closed. For example, a CurveLoop consisting of a single line is open, as is the "offset CurveLoop" mentioned above. Note that an open CurveLoop may be continuous or discontinuous, and a continuous CurveLoop may be open or closed. The definitions imply that a discontinuous CurveLoop is necessarily open and an empty CurveLoop is open. It should also be noted that these definitions take the order of the curves and the curves' directions into account. For example, a CurveLoop comprising the four edges of a rectangle in the order {bottom, top, left, right} is discontinuous. Similarly, a CurveLoop comprising the four edges of a rectangle in the order {bottom, right, top, left}, with three of the lines oriented in the counter-clockwise direction of the rectangle and the fourth oriented in the clockwise direction, is discontinuous. Finally, note that some routines in Revit may set the CurveLoop to be marked "open" or "closed" in spite of the actual geometry of the curves. In these special cases, the CurveLoop class does not require that the CurveLoop is correctly marked. In the API, the members of the CurveLoop may be directly iterated, as the class implements IEnumerable<Curve>. The iteration provides copies of the curves directly contained in the loop; modification of the curves will not affect the curves that are contained in the loop.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new CurveLoop()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Append(Curve curve)
      Description: Append the curve to this loop.
      @curve: The curve.
    static CurveLoop Create(IList<Curve> curves)
      Description: Creates a new curve loop.
      @curves: The curves.
      Returns: The curve loop.
    static CurveLoop CreateViaCopy(CurveLoop original)
      Description: Creates a new curve loop as a copy of the input.
      @original: The original curve loop.
      Returns: The copied curve loop.
    static CurveLoop CreateViaOffset(CurveLoop original, IList<double> offsetDists, XYZ normal)
      Description: Creates a new curve loop that is an offset of the existing curve loop.
      @original: The original curve loop.
      @offsetDists: The signed offset distances for each curve. The size of this array must match the size of the curve loop. Curve at position i will be offset with offsetDists[i].
      @normal: The normal of the offset plane.
      Returns: The offset curve loop.
    static CurveLoop CreateViaOffset(CurveLoop original, double offsetDist, XYZ normal)
      Description: Creates a new curve loop that is an offset of the existing curve loop.
      @original: The original curve loop.
      @offsetDist: The signed offset distance.
      @normal: The normal of the offset plane.
      Returns: The offset curve loop.
    static CurveLoop CreateViaThicken(CurveLoop curveLoop, double thickness, XYZ normal)
      Description: Creates a new closed curve loop by thickening the input open curve loop with respect to a given plane.
      @curveLoop: The input curve loop.
      @thickness: The distance between the offset curves created on either side of the input curve.
      @normal: The normal vector to the plane used for thickening.
      Returns: The new curve loop.
    static CurveLoop CreateViaThicken(Curve pCurve, double thickness, XYZ normal)
      Description: Creates a new closed curve loop by thickening the input curve with respect to a given plane.
      @pCurve: The input curve.
      @thickness: The distance between the offset curves created on either side of the input curve.
      @normal: The normal vector to the plane used for thickening.
      Returns: The new curve loop.
    static CurveLoop CreateViaTransform(CurveLoop curveLoop, Transform transform)
      Description: Creates a new curve loop as a transformed copy of the input curve loop.
      @curveLoop: The input curve loop.
      @transform: The transformation.
      Returns: The new curve loop.
    void Dispose()
    void Flip()
      Description: Reverses the orientation of the curve loop.
    CurveLoopIterator GetCurveLoopIterator()
      Description: Returns a curve that iterates through the curve loop.
      Returns: A curve loop iterator object that can be used to iterate through key-value pairs in the collection.
    IEnumerator<Curve> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    double GetExactLength()
      Description: Returns the sum of exact lengths of all curves in the loop.
      Returns: The total length of the curves in the loop.
    Plane GetPlane()
      Description: Gets the plane of the curve loop, if it is planar.
      Returns: The plane of the curve loop.
    double GetRectangularHeight(Plane plane)
      Description: Returns the width of a curve loop if it is rectangular with respect to the projection plane.
      @plane: The plane to which the curves will be projected.
      Returns: The height.
    double GetRectangularWidth(Plane plane)
      Description: Returns the width of a curve loop if it is rectangular with respect to the projection plane.
      @plane: The plane to which the curves will be projected.
      Returns: The width.
    bool HasPlane()
      Description: Identifies if the CurveLoop is planar.
      Returns: True if the curve loop is planar, false otherwise.
    bool IsCounterclockwise(XYZ normal)
      Description: Determines if this CurveLoop is oriented counter-clockwise (CCW) or clockwise (CW) with respect to the specified 3D direction.
      @normal: The normal vector to the plane used for this determination.
      Returns: True if the curve loop is oriented counter-clockwise with respect to the specified 3D direction, false if the loop is oriented clockwise.
    bool IsOpen()
      Description: Returns whether the curve loop is open or closed, as determined by an internal flag.
      Returns: True if the CurveLoop is marked open, false if marked closed.
    bool IsRectangular(Plane plane)
      Description: Identifies if the curve loop is rectangular with respect to a given projection plane.
      @plane: The plane to which the curves will be projected to determine if they represent a rectangle.
      Returns: True if the curve loop is rectangular, false otherwise.
    int NumberOfCurves()
      Description: Returns the number of curves in the curve loop.
      Returns: The number of curves in the curve loop.
    void Transform(Transform transform)
      Description: Transforms this curve loop and all of its component curves by the supplied transformation.
      @transform: The transformation.

--------------------------------------------------------------------------------


[CLASS] CurveLoopIterator
Full Name: Autodesk.Revit.DB.CurveLoopIterator

Description: An iterator to a curve loop.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    Curve Current { get; }
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


[CLASS] CurveLoopsProfile
Full Name: Autodesk.Revit.DB.CurveLoopsProfile

Description: Represents a curve loop based profile for sweep or swept blend elements.
Remarks: Use objects of this type in methods as NewSweep() and NewSweptBlend() in to create the profile.
Inherits: SweepProfile
Implements: IDisposable

  PROPERTIES:
    CurveArrArray Profile { get; set; }
      Description: Returns the curve loops of the profile.

--------------------------------------------------------------------------------


[CLASS] CurveNode
Full Name: Autodesk.Revit.DB.CurveNode

Description: An output node that represents a model curve.
Remarks: See also: .
Inherits: ModelCurveNode
Implements: IDisposable

  METHODS:
    Curve GetCurve()
      Description: Returns the geometric curve object corresponding to the node.
      Returns: The curve.

--------------------------------------------------------------------------------


[ENUM] CurveProjectionType
Full Name: Autodesk.Revit.DB.CurveProjectionType

Description: This attribute indicates how the curve will be projected to the surface if the curve is sketched on the surface.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FromTopDown = 0
    - ParallelToLevel = 1
    - FollowSurfaceUV = 2


[CLASS] CurveUV
Full Name: Autodesk.Revit.DB.CurveUV

Description: A class that encapsulates the notion of a curve in the 2D parameter space of a surface in 3D space.
Remarks: Revit does not have a class to represent 2D curves explicitly.
Implements: IDisposable

  PROPERTIES:
    bool IsBound { get; }
      Description: Describes whether the parameter of the curve is restricted to a particular interval.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    Curve As3DCurveInXYPlane()
      Description: Returns a 3D curve lying in the XY plane in XYZ coordinates, representing the 2D curve with its UV coordinates identified with XY coordinates.
      Returns: 3D curve lying in the XY plane in XYZ coordinates, representing the 2D curve with its UV coordinates identified with XY coordinates.
    IList<UV> ComputeDerivatives(double parameter, bool normalized)
      Description: Computes the first derivative, the second derivative and the unit tangent vector at the specified parameter along the curve.
      @parameter: The specified parameter along the curve.
      @normalized: If false, parameter is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The array containing three members: the first derivative (at index [0]), the second derivative (at index [1]) and the unit tangent vector (at index [2]).
    static CurveUV Create(Curve curve3D)
      Description: Create a CurveUV from a bounded 3D Curve lying in the XY plane.
      @curve3D: The input bounded 3D Curve lying in the XY plane (i.e., z = 0 everywhere along the curve).
      Returns: The newly created CurveUV.
    void Dispose()
    UV Evaluate(double parameter, bool normalized)
      Description: Evaluates and returns the point at the specified parameter along the curve.
      @parameter: The specified parameter along the curve.
      @normalized: If false, parameter is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The point evaluated along the curve.
    double GetEndParameter(int index)
      Description: Gets the raw parameter value at the start or end of this curve.
      @index: Use 0 for the start parameter, 1 for the end parameter of the curve.
      Returns: The raw parameter value at the start or end of this curve.
    CurveUV Transform(Transform2D trfUV)
      Description: Transform this CurveUV by the given 2D affine transform if possible.
      @trfUV: The given 2D affine transform.
      Returns: If successful a transformed CurveUV, otherwise .

--------------------------------------------------------------------------------


[CLASS] CustomExporter
Full Name: Autodesk.Revit.DB.CustomExporter

Description: A class that allows exporting 3D or 2D views via an export context.
Remarks: The Export method of this class triggers standard rendering or exporting process in Revit, but instead of displaying the result on screen or printer, the output is channeled through the given custom context that handles processing of the geometric as well as non-geometric information. Revit will process the exporting algorithm depending on the type of given context. If an instance of is used, then Revit will output the model as if executing the Render command, thus only such entities that would be visible in a rendered view will be sent to the context. Alternatively, if an instance of is used, Revit will output the model as if exporting it to a CAD format, a process which results outputting also objects that would not appear in a rendered image, such as model curves and text annotations. For 2D views, an instance of has to be used. Revit will output the contents of the 2D view as it is displayed on the screen. Export can be modified by setting properties pertaining to 2D views: , . . See notes for 2D export in .
Implements: IDisposable

  CONSTRUCTORS:
    new CustomExporter(Document document, IExportContext context)

  PROPERTIES:
    DisplayStyle Export2DForceDisplayStyle { get; set; }
      Description: This value tells the exporter of 2D views to force the given display mode for the view.
    bool Export2DGeometricObjectsIncludingPatternLines { get; set; }
      Description: This flag sets the exporter of 2D views to either include or exclude output of face pattern lines as part of geometric objects when the model is being processed by the export context.
    bool Export2DIncludingAnnotationObjects { get; set; }
      Description: This flag sets the exporter of 2D views to either include or exclude output of annotation objects when the model is being processed by the export context.
    bool IncludeGeometricObjects { get; set; }
      Description: This flag sets the exporter to either include or exclude output of geometric objects such as faces and curves when the model is being processed by the export context.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ShouldStopOnError { get; set; }
      Description: This flag instructs the exporting process to either stop or continue in case an error occurs during any of the exporting methods.

  METHODS:
    void Dispose()
    void Export(IList<ElementId> viewIds)
      Description: Exports a collection of 3D or 2D views
      @viewIds: An array of views to export
    void Export(View view)
      Description: Exports one 3D or 2D view
      @view: An instance of the view to export
    static bool IsRenderingSupported()
      Description: Checks if view rendering is currently supported in the running instance of Revit.
      Returns: Returns True if rendering is currently supported, False otherwise.

--------------------------------------------------------------------------------


[CLASS] CustomFieldData
Full Name: Autodesk.Revit.DB.CustomFieldData

Description: A class that offer access to the information about a custom field.
Implements: IDisposable

  PROPERTIES:
    double DefaultRowHeightOnSheet { get; }
      Description: Identifies the default row height for this field.
    string FieldName { get; }
      Description: The name of this custom field.
    string FieldTooltip { get; }
      Description: The tooltip that will be shown in the schedule properties dialog for this custom field.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Guid GetCustomFieldId()
      Description: Gets an unique identifier of the custom field.
      Returns: Returns an unique identifier of type of custom field.
    ICustomFieldProperties GetCustomFieldProperties()
      Description: Gets an instance of which represents the properties of this field.
      Returns: Returns an instance of .
    void SetCustomFieldProperties(ICustomFieldProperties customFieldProperties)
      Description: Sets an instance of which represents the properties of this field.
      @customFieldProperties: An instance of which represents the properties of this field.
    string ValidateCustomFieldProperties(ICustomFieldProperties customFieldProperties)
      Description: Validates the custom field properties.
      @customFieldProperties: An instance of which represents the properties of this field.
      Returns: If the properties are valid, an empty string will be returned. If the properties are not valid, a non-empty string which describes the error will be returned.

--------------------------------------------------------------------------------


[ENUM] CustomSubCategoryId
Full Name: Autodesk.Revit.DB.CustomSubCategoryId

Description: An enumerated type listing pseudo sub-categories that can appear in a mapping template. These types do not represent an independent category in Revit, but can be mapped to specific IFC entity.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - InteriorWall = 1
    - ExteriorWall = 2
    - FoundationWall = 3
    - RetainingWall = 4
    - Coreshaft = 5
    - Soffit = 6
    - None = -1


[ENUM] CutFailureReason
Full Name: Autodesk.Revit.DB.CutFailureReason

Description: The reason why a solid-solid cut cannot be created.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - CutAllowed = 0
    - CutAlreadyExists = 1
    - OppositeCutExists = 2
    - CutNotAppropriateForElements = 3


[CLASS] CylindricalFace
Full Name: Autodesk.Revit.DB.CylindricalFace

Description: A cylindrical face of a 3d solid or open shell.
Remarks: For details on the parameterization, refer to the documentation for .
Inherits: Face
Implements: IDisposable

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the surface.
    XYZ Origin { get; }
      Description: Origin of the surface.
    XYZ Radius { get; }

--------------------------------------------------------------------------------


[CLASS] CylindricalHelix
Full Name: Autodesk.Revit.DB.CylindricalHelix

Description: A cylindrical helix.
Remarks: The helix winds around a cylinder making constant angle with the axis of the cylinder. In this release, CylindricalHelix curves are used only in specific applications in stairs and railings, and should not be used or encountered when accessing curves of other Revit elements and geometry.
Inherits: Curve
Implements: IDisposable

  PROPERTIES:
    XYZ BasePoint { get; }
      Description: The base point of the axis of the cylindrical helix.
    double Height { get; }
      Description: Height of the cylindrical helix.
    bool IsRightHanded { get; }
      Description: True if the helix is right handed, false if the helix is left handed.
    double Pitch { get; }
      Description: The pitch of the cylindrical helix.
    double Radius { get; }
      Description: The radius of the cylindrical helix.
    XYZ XVector { get; }
      Description: The X direction vector.
    XYZ YVector { get; }
      Description: The Y direction vector.
    XYZ ZVector { get; }
      Description: The Z direction vector, which is same as the axis direction vector.

  METHODS:
    static CylindricalHelix Create(XYZ basePoint, double radius, XYZ xVector, XYZ zVector, double pitch, double startAngle, double endAngle)
      Description: Create a cylindrical helix.
      @basePoint: Base point of the axis. It can be any point in 3d.
      @radius: Radius. It should be a positive number.
      @xVector: X vector. Should be Non-zero vector.
      @zVector: Z vector = axis direction. Should be non-zero and orthogonal to X Vector.
      @pitch: Pitch. It should be non-zero number, can be positive or negative. Positive means right handed and negative means left handed.
      @startAngle: Start angle. It specifies the start point of the Helix.
      @endAngle: End angle. It specifies the end point of the Helix. End angle should not be equal to start angle.

--------------------------------------------------------------------------------


[CLASS] CylindricalSurface
Full Name: Autodesk.Revit.DB.CylindricalSurface

Description: A cylindrical surface.
Remarks: The parametric equation of the cylinder is S(u, v) = center + radius*cos(u)*xVec + radius*sin(u)*yVec + v*zVec.
Inherits: Surface
Implements: IDisposable

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the cylinder. This is the Z axis of the local coordinate system associated with this cylinder.
    XYZ Origin { get; }
      Description: Center of the circle that defines the base of the cylinder. This is the origin of the local coordinate system associated with this cylinder.
    double Radius { get; }
      Description: Radius of the circle that defines the base of this cylinder.
    XYZ XDir { get; }
      Description: X axis of the local coordinate system associated with this cylinder.
    XYZ YDir { get; }
      Description: Y axis of the local coordinate system associated with this cylinder.

  METHODS:
    static CylindricalSurface Create(Frame frameOfReference, double radius)
      Description: Construct a cylindrical surface defined by a local coordinate system and a radius.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the cylinder. Frame.Origin is a point on the cylinder's axis. Frame.BasisZ points along the axis, while Frame.BasisX and Frame.BasisY are orthogonal to the axis. The frame may be either left-handed or right-handed (see Frame.IsRightHanded). Note that the "handedness" of the frame does not, by itself, determine the surface's orientation.
      @radius: Radius of the circle that defines the base of the cylindrical surface.
      Returns: The created CylindricalSurface.
    Frame GetFrameOfReference()
      Description: Returns frame of reference associated with this CylindricalSurface.
      Returns: Frame of reference associated with this CylindricalSurface.

--------------------------------------------------------------------------------

