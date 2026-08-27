# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[CLASS] DataConversionMonitorScope
Full Name: Autodesk.Revit.DB.DataConversionMonitorScope
Description: This class is used to regsiter an application-supplied object that implements IDataConversionMonitor. Creating the object registers an implementation of IDataConversionMonitor supplied as constructor argument. When the scope object is destroyed, that object is unregistered.
Implements: IDisposable

  CONSTRUCTORS:
    new DataConversionMonitorScope(IDataConversionMonitor IDCM)
      Description: The only constructor. Expects a valid pointer to IDataConversionMonitor.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] DataExchangeMessageId
Full Name: Autodesk.Revit.DB.DataExchangeMessageId
Description: Predefined message ids for DataExchangeLog.
Inherits: Enum

  Values:
    - None = 0
    - UnitOfProgressCompleted = 1
    - ObjectCreated = 2
    - UnexpectedResult = 3
    - InvalidSourceObject = 4
    - InvalidDataSet = 5
    - GenericError = 6
    - ObjectNotSupported = 7
    - ObjectNotConverted = 8
    - InvalidRenderingStyle = 9
    - EmptyObject = 10

--------------------------------------------------------------------------------

[ENUM] DataExchangeMessageSeverity
Full Name: Autodesk.Revit.DB.DataExchangeMessageSeverity
Description: Error levels for DataExchangeLog
Inherits: Enum

  Values:
    - Info = 0
    - Warning = 1
    - Error = 2
    - FatalError = 3

--------------------------------------------------------------------------------

[ENUM] DataExchangeMessageVerbosity
Full Name: Autodesk.Revit.DB.DataExchangeMessageVerbosity
Description: Predefined verbosity levels for DataExchangeLog
Inherits: Enum

  Values:
    - Minimal = 0
    - Default = 1
    - Verbose = 2

--------------------------------------------------------------------------------

[ENUM] DatumEnds
Full Name: Autodesk.Revit.DB.DatumEnds
Description: An enumerated type representing ends of a datum plane.
Inherits: Enum

  Values:
    - End0 = 0
    - End1 = 1

--------------------------------------------------------------------------------

[ENUM] DatumExtentType
Full Name: Autodesk.Revit.DB.DatumExtentType
Description: Represents the type of datum extent that is displayed in a particular view.
Inherits: Enum

  Values:
    - Model = 0
    - ViewSpecific = 1

--------------------------------------------------------------------------------

[CLASS] DatumPlane
Full Name: Autodesk.Revit.DB.DatumPlane
Description: A base class representing a datum surface (level, grid or reference plane) in Autodesk Revit.
Remarks: A DatumPlane represents a 3d surface with finite extents. It can be either a rectangle with arbitrary orientation, or a cylinder whose axis is parallel to the project z-axis. If a datum is visible in a plan or section view, it will be displayed as one or more curves. These curves are determined by the intersection of the datum surface with the cut plane of the view. By default, the extents of these curves reflect the 3d extents of the datum surface. If the surface is a plane, then the extents represent the projection of the surface onto the cut plane. This matters, for example, when viewing a datum plane, really a 3d rectangle, along one of its diagonals. The extents of the curve do not vary with the location of the view, because we use the projection of the rectangle and not the actual intersection. If the surface is a cylinder, then the extents reflect the actual intersection of the surface with the cut plane. In addition, the curves that represent a DatumPlane can be modified on a view specific basis. In this case, the ends of the curve no longer reflect the 3d extents of the datum.
Inherits: Element

  METHODS:
    Leader AddLeader(DatumEnds datumEnd, View view)
      Description: Adds a default Leader for the indicated end of the datum plane. This method does not apply to Reference planes (which do not support leaders).
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      Returns: The Leader of the datum plane. Null will return if the view is null.
      Throws ArgumentException: The datum plane cannot be visible in the view. -or- The bubble is not visible at the datumEnd of the datum plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane has no leaders. -or- The DatumPlane already has a leader applied.
    bool CanBeVisibleInView(View view)
      Description: Checks if the datum plane can be visible in the view.
      @view: The view.
      Returns: True if visible, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    IList<Curve> GetCurvesInView(DatumExtentType extentMode, View view)
      Description: Gets a collection of curves representing the DatumPlane element in the given view.
      @extentMode: The extent type.
      @view: The view.
      Returns: The curves.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    DatumExtentType GetDatumExtentTypeInView(DatumEnds datumEnd, View view)
      Description: Identifies whether the curve representing the datum plane is displayed according to its actual 3d extents, or else according to a view specific setting.
      @datumEnd: Specifies one end of the curve representing the datum plane in the view.
      @view: The view in which to evaluate the datum extent settings.
      Returns: The extent type.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    Leader GetLeader(DatumEnds datumEnd, View view)
      Description: Gets a copy of the leader applied to the indicated end of the datum plane. This method does not apply to Reference planes (which do not support leaders).
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      Returns: The Leader of the datum plane. Null will return if no leader applied.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane has no leaders.
    ISet<ElementId> GetPropagationViews(View view)
      Description: Gets a list of candidate views which are parallel to the current view and to which the extents of the datum may be propagated.
      @view: The view on which the DatumPlane shows.
      Returns: A set of ElementIds of the parallel views for extent propagation.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasBubbleInView(DatumEnds datumEnd, View view)
      Description: Identifies if the DatumPlane has bubble or not.
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      Returns: True if the DatumPlane has bubble, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane doesn't support bubble operations.
    void HideBubbleInView(DatumEnds datumEnd, View view)
      Description: Hides the bubble in a view. This method does not apply to Reference planes.
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane doesn't support bubble operations.
    bool IsBubbleVisibleInView(DatumEnds datumEnd, View view)
      Description: Identifies if the bubble is visible or not in a view.
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      Returns: True if the bubble is visible, false otherwise.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane doesn't support bubble operations.
    bool IsCurveValidInView(DatumExtentType extentMode, View view, Curve curve)
      Description: Checks if the curve is valid to be as the extents for the datum plane in a view. The curve must be bound and coincident with the original one of the datum plane.
      @extentMode: The extent type.
      @view: The view.
      @curve: The curve.
      Returns: True if it is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsLeaderValid(DatumEnds datumEnd, View view, Leader leader)
      Description: Identifies if the leader valid or not for this DatumPlane. This method does not apply to Reference planes (which do not support leaders).
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      @leader: The Leader for setting the datum plane.
      Returns: True if the leader is valid for set leader, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane has no leaders. -or- The DatumPlane should not have a leader.
    void Maximize3DExtents()
      Description: Computes the 3d extents of all model geometry and levels, and extends the 3d extents of this datum surface to include the model extents.
    void PropagateToViews(View view, ISet<ElementId> parallelViews)
      Description: Propagates the extents applied to this datum in the view to the specified parallel views.
      @view: The view on which the DatumPlane shows.
      @parallelViews: The ids of the specified parallel views.
      Throws ArgumentException: The datum plane cannot be visible in the view. -or- One ElementId in parallelViews is not valid for extent propagation.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCurveInView(DatumExtentType extentMode, View view, Curve curve)
      Description: Sets the extents to match the curve.
      @extentMode: The extent type.
      @view: The view.
      @curve: The curve.
      Throws ArgumentException: The datum plane cannot be visible in the view. -or- The curve is unbound or not coincident with the original one of the datum plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetDatumExtentType(DatumEnds datumEnd, View view, DatumExtentType extentMode)
      Description: Sets whether the curve representing the datum plane is displayed according to its 3d extents, or else according to a view specific setting.
      @datumEnd: Specifies one end of the curve representing the datum plane in the view.
      @view: The view in which to set the datum extent settings.
      @extentMode: The DatumExtentType.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetLeader(DatumEnds datumEnd, View view, Leader pLeader)
      Description: Sets the leader to the indicated end of the datum plane. This method does not apply to Reference planes (which do not support leaders).
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      @pLeader: The Leader for setting the datum plane.
      Throws ArgumentException: One of the conditions is not valid: the input leader and view is not null; The leader End, Elbow, Anchor should be in the view; the End of leader should be in the datum plane curves; Elbow is between End and Anchor. -or- The datum plane cannot be visible in the view. -or- The bubble is not visible at the datumEnd of the datum plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void ShowBubbleInView(DatumEnds datumEnd, View view)
      Description: Shows the bubble in a view. This method does not apply to Reference planes.
      @datumEnd: The end of the datum plane.
      @view: The view on which the DatumPlane shows.
      Throws ArgumentException: The datum plane cannot be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This datum plane doesn't support bubble operations. -or- This DatumPlane doesn't have bubbles shown the view.

--------------------------------------------------------------------------------

[ENUM] DecimalSymbol
Full Name: Autodesk.Revit.DB.DecimalSymbol
Description: The symbol used to separate the integer and fractional parts of a number.
Inherits: Enum

  Values:
    - Dot = 0
    - Comma = 1

--------------------------------------------------------------------------------

[CLASS] DefaultDivideSettings
Full Name: Autodesk.Revit.DB.DefaultDivideSettings
Description: Provides access to project-wide divide settings.
Inherits: Element

  PROPERTIES:
    double PathDistance { get; set; }
      Description: A default Divided Path distance for a fixed, minimum, or maximum distance layout.
    SpacingRuleLayout PathLayout { get; set; }
      Description: A default Divided Path layout.
    DividedPathMeasurementType PathMeasurementType { get; set; }
      Description: A default Divided Path measurement type for distance layouts.
    int PathNumber { get; set; }
      Description: A default Divided Path number for a fixed number layout.

  METHODS:
    static DefaultDivideSettings GetDefaultDivideSettings(Document cda)
      Description: Obtains the DefaultDivideSettings object for the specified document.
      @cda: A document.
      Returns: The DefaultDivideSettings object.
      Throws ArgumentNullException: A non-optional argument was null
    double GetSurfaceDistance(UVGridlineType gridlines)
      Description: Gets the default Divided Surface distance for a fixed, minimum, or maximum distance layout for U or V gridlines.
      @gridlines: U-gridlines or V-gridlines.
      Returns: The default distance for the layout.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    SpacingRuleLayout GetSurfaceLayout(UVGridlineType gridlines)
      Description: Gets the default Divided Surface layout for U or V gridlines.
      @gridlines: U-gridlines or V-gridlines.
      Returns: The layout spacing rule.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    int GetSurfaceNumber(UVGridlineType gridlines)
      Description: Gets the default Divided Surface number for a fixed number layout for U or V gridlines.
      @gridlines: U-gridlines or V-gridlines.
      Returns: The default number for a fixed number layout.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetSurfaceDistance(UVGridlineType gridlines, double distance)
      Description: Sets the default Divided Surface distance for a fixed, minimum, or maximum distance layout for U or V gridlines.
      @gridlines: U-gridlines or V-gridlines.
      @distance: A default distance for a layout.
      Throws ArgumentOutOfRangeException: The given value for distance must be positive. -or- A value passed for an enumeration argument is not a member of that enumeration
    void SetSurfaceLayout(UVGridlineType gridlines, SpacingRuleLayout layout)
      Description: Sets the default Divided Surface layout for U or V gridlines.
      @gridlines: U-gridlines or V-gridlines.
      @layout: A layout spacing rule.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetSurfaceNumber(UVGridlineType gridlines, int number)
      Description: Sets the default Divided Surface number for a fixed number layout for U or V gridlines.
      @gridlines: U-gridlines or V-gridlines.
      @number: A default number for a fixed number layout.
      Throws ArgumentOutOfRangeException: The given value for number is not positive. -or- A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] DefaultOpenFromCloudCallback
Full Name: Autodesk.Revit.DB.DefaultOpenFromCloudCallback
Description: A default callback that may be used to control Revit's behavior when opening a model.
Implements: IOpenFromCloudCallback, IDisposable

  CONSTRUCTORS:
    new DefaultOpenFromCloudCallback()
      Description: Create a default open callback. Open latest by default for all scenarios.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    OpenConflictResult OnOpenConflict(OpenConflictScenario scenario)
      Description: A method called when the conflict is happen during the model opening.
      @scenario: The scenario of the conflict.
      Returns: Returns the result to indicate whether to keep the unsynchronized change, or open the latest version or cancel the open action.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Definition
Full Name: Autodesk.Revit.DB.Definition
Description: The Definition object is a base object for all type of parameter definitions within the Autodesk Revit API.
Remarks: This object supports properties and methods that report the name and type of a particular parameter. There are two kinds of definition object derived from this: InternalDefinition which represents all kinds of definitions existing entirely within the Autodesk Revit database. ExternalDefinitions represent definitions stored on disk in a shared parameters file. Most of the time code should be written to utilize this Definition base class as then the code will be applicable to both internal and external parameter definitions.

  PROPERTIES:
    string Name { get; }
      Description: The user visible name for the parameter.

  METHODS:
    ForgeTypeId GetDataType()
      Description: Gets a ForgeTypeId identifying the data type describing values of the parameter.
      Returns: A ForgeTypeId identifying the data type of the parameter or an empty ForgeTypeId.
    ForgeTypeId GetGroupTypeId()
      Description: Returns the identifier of the parameter definition's parameter group.

--------------------------------------------------------------------------------

[CLASS] DefinitionBindingMap
Full Name: Autodesk.Revit.DB.DefinitionBindingMap
Description: A map that contains mappings of parameter definitions to parameter bindings.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new DefinitionBindingMap()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the map is empty.
    Binding Item { get; set; }
    int Size { get; }
      Description: Returns the number of bindings that are in the map.

  METHODS:
    void Clear()
      Description: Removes every binding from the map, rendering it empty.
    bool Contains(Definition key)
    int Erase(Definition key)
    DefinitionBindingMapIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    bool Insert(Definition key, Binding item)
    DefinitionBindingMapIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the map.
      Returns: Returns a backward moving iterator to the map.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DefinitionBindingMapIterator
Full Name: Autodesk.Revit.DB.DefinitionBindingMapIterator
Description: An iterator to a parameter definition to parameter bindings map.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new DefinitionBindingMapIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the binding that is the current focus of the iterator.
    Definition Key { get; }
      Description: Retrieves the definition that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the map.
    void Reset()
      Description: Bring the iterator back to the start of the map.

--------------------------------------------------------------------------------

[CLASS] DefinitionFile
Full Name: Autodesk.Revit.DB.DefinitionFile
Description: The DefinitionFile object represents a shared parameters file on disk.
Remarks: Shared Parameters are parameter definitions that are stored in a text file external to the Autodesk Revit project. These definitions can be used in multiple projects and are identifiable by a unique identifier generated when they are created. API access to shared parameters consist of a number of objects, the first of which is an object that represents the shared parameters file on disk. That object then contains a number of Group objects. Shared parameters are grouped for easier management. These groups then contain the shared parameter definitions. The groups support the ability to create new shared parameter definitions. The DefinitionFile object can be retrieved by the Application.OpenSharedParameterFile method.
Inherits: APIObject

  PROPERTIES:
    string Filename { get; }
      Description: This property returns the physical filename of the shared parameters file on disk.
    DefinitionGroups Groups { get; }
      Description: Return a map of shared parameter definition groups contained within the file.

--------------------------------------------------------------------------------

[CLASS] DefinitionGroup
Full Name: Autodesk.Revit.DB.DefinitionGroup
Description: The DefinitionGroup is a container that is used to hold shared parameter definitions on disk.
Remarks: Groups are used for logical arrangement of the shared parameters into meaningful sets. Through the DefinitionGroup object new shared parameter definitions can be made.
Inherits: APIObject

  PROPERTIES:
    Definitions Definitions { get; }
      Description: The Definitions property returns an object that contains all the shared parameter definitions within the group.
    string Name { get; }
      Description: Returns the name of the parameter group.

--------------------------------------------------------------------------------

[CLASS] DefinitionGroups
Full Name: Autodesk.Revit.DB.DefinitionGroups
Description: A specialized set of definition groups that allows creation of new groups.
Implements: IEnumerable<DefinitionGroup>, IEnumerable, IDisposable

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Identifies if the definition groups collection is empty.
    DefinitionGroup Item { get; }
    int Size { get; }
      Description: The number of definition groups in the collection.

  METHODS:
    bool Contains(DefinitionGroup definitionGroup)
      Description: Tests for the existence of a definition group within the collection.
      @definitionGroup: The definition group to look for.
      Returns: True if the definition group was found, false otherwise.
    DefinitionGroup Create(string name)
      Description: Create a new parameter definition group using the name provided.
      @name: The name of the group to be created.
      Returns: If successful a reference to the new parameter group is returned, otherwise .
    void Dispose()
    IEnumerator<DefinitionGroup> GetEnumerator()
      Description: Retrieves an enumerator to the collection.
      Returns: The enumerator.

--------------------------------------------------------------------------------

[CLASS] Definitions
Full Name: Autodesk.Revit.DB.Definitions
Description: A base class that supports the addition of new parameter definitions.
Remarks: There are two derivations of this class, one of which handles external parameters and another which handles internal parameters.
Implements: IEnumerable<Definition>, IEnumerable, IDisposable

  CONSTRUCTORS:
    new Definitions()
      Description: Constructs an empty set of parameter definitions.

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Identifies if the definitions collection is empty.
    Definition Item { get; }
    int Size { get; }
      Description: The number of definitions in the collection.

  METHODS:
    bool Contains(Definition definition)
      Description: Tests for the existence of a definition within the set.
      @definition: The definition to look for.
      Returns: True if the definition was found, false otherwise.
    Definition Create(ExternalDefinitionCreationOptions option)
      Description: Creates a new parameter definition using specified options.
      @option: The options used to create the new parameter definition.
      Returns: If successful a reference to the new parameter definition is returned, otherwise .
    void Dispose()
    IEnumerator<Definition> GetEnumerator()
      Description: Retrieves an enumerator to the collection.
      Returns: The enumerator.

--------------------------------------------------------------------------------

[CLASS] DeleteElements
Full Name: Autodesk.Revit.DB.DeleteElements
Description: Deletes element(s) related to the failure.
Inherits: FailureResolution

  METHODS:
    static FailureResolution Create(Document document, ElementId id)
      Description: Creates an instance of the DeleteElements resolution.
      @document: The document which owns the element to delete.
      @id: The id of the element that will be deleted when this resolution is chosen.
      Returns: The instance of the DeletedElements resolution.
      Throws ArgumentException: The input id is not valid for deletion.
      Throws ArgumentNullException: A non-optional argument was null
    static FailureResolution Create(Document document, IList<ElementId> ids)
      Description: Creates an instance of the DeleteElements resolution.
      @document: The document which owns the elements to delete.
      @ids: The ids of the elements that will be deleted when this resolution is chosen.
      Returns: The instance of the DeleteElements resolution.
      Throws ArgumentException: The input ids is empty or contains an invalid element id.
      Throws ArgumentNullException: A non-optional argument was null
    static FailureResolution Create(Document document, ISet<ElementId> ids)
      Description: Creates an instance of the DeleteElements resolution.
      @document: The document which owns the elements to delete.
      @ids: The ids of the elements that will be deleted when this resolution is chosen.
      Returns: The instance of the DeleteElements resolution.
      Throws ArgumentException: The input ids is empty or contains an invalid element id.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DeleteWorksetOption
Full Name: Autodesk.Revit.DB.DeleteWorksetOption
Description: This class defines an enumerative type used to specify the option to delete a workset.
Inherits: Enum

  Values:
    - MoveElementsToWorkset = 0
    - DeleteAllElements = 1

--------------------------------------------------------------------------------

[CLASS] DeleteWorksetSettings
Full Name: Autodesk.Revit.DB.DeleteWorksetSettings
Description: This class represents the settings used to delete a workset.
Implements: IDisposable

  CONSTRUCTORS:
    new DeleteWorksetSettings(DeleteWorksetOption deleteWorksetOption, WorksetId elementsMoveInto)
      Description: Constructs a DeleteWorksetSettings object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new DeleteWorksetSettings()
      Description: Constructs a DeleteWorksetSettings object with DeleteWorksetOption::DeleteAllElements option.

  PROPERTIES:
    DeleteWorksetOption DeleteWorksetOption { get; set; }
      Description: The current delete workset option.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    WorksetId WorksetId { get; set; }
      Description: The target worksetId for those elements under the deleted workset, which is used for DeleteWorksetOption::MoveElementsToWorkset.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] DesignOption
Full Name: Autodesk.Revit.DB.DesignOption
Description: An element that represents a design alternative.
Remarks: Design options enable the user to add alternative designs within the same project. Each element can either be in a design option or not at all, in which case it is considered to be part of the main model and have no design alternatives.
Inherits: Element

  PROPERTIES:
    bool IsPrimary { get; }
      Description: Determines whether this is a primary design option.

  METHODS:
    static ElementId GetActiveDesignOptionId(Document document)
      Description: Gets the active design option id for the document.
      @document: The document.
      Returns: The active design option id. It can be invalid id if there is no active design option in the document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DetachFromCentralOption
Full Name: Autodesk.Revit.DB.DetachFromCentralOption
Description: Options for workset detachment behavior.
Inherits: Enum

  Values:
    - DoNotDetach = 0
    - DetachAndPreserveWorksets = 1
    - DetachAndDiscardWorksets = 2
    - ClearTransmittedSaveAsNewCentral = 3

--------------------------------------------------------------------------------

[CLASS] DetailArc
Full Name: Autodesk.Revit.DB.DetailArc
Description: Represents a DetailArc within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from DetailCurve::geometryCurve property.
Inherits: DetailCurve

--------------------------------------------------------------------------------

[CLASS] DetailCurve
Full Name: Autodesk.Revit.DB.DetailCurve
Description: A curve that is used to create a detail drawing. A detail curve is visible only in the view in which it is drawn.
Inherits: CurveElement

--------------------------------------------------------------------------------

[CLASS] DetailCurveArray
Full Name: Autodesk.Revit.DB.DetailCurveArray
Description: An array that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new DetailCurveArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    DetailCurve Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(DetailCurve item)
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    DetailCurveArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(DetailCurve item, int index)
    DetailCurveArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DetailCurveArrayIterator
Full Name: Autodesk.Revit.DB.DetailCurveArrayIterator
Description: An iterator to a array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new DetailCurveArrayIterator()
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

[ABSTRACT CLASS] DetailElementOrderUtils
Full Name: Autodesk.Revit.DB.DetailElementOrderUtils
Description: A utility class that arranges the draw order of the detail elements.

  METHODS:
    static bool AreDetailElements(Document document, View view, ICollection<ElementId> detailElementIds)
      Description: Indicates if the elements are all detail elements that participate in detail draw ordering in the view.
      @document: The document.
      @view: The view in which the details appear.
      @detailElementIds: The details to check.
      Returns: True if the detail elements are orderable in the view, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static void BringForward(Document document, View view, ICollection<ElementId> detailElementIds)
      Description: Moves the given detail instances one step closer to the front of all other detail instances in the view, while keeping the order of the given ones.
      @document: The document.
      @view: The view in which the details appear.
      @detailElementIds: The details to bring forward.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static void BringForward(Document document, View view, ElementId detailElementId)
      Description: Moves the given detail instance one step closer to the front of all other detail instances in the view.
      @document: The document.
      @view: The view in which the detail appears.
      @detailElementId: The detail to bring forward.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static void BringToFront(Document document, View view, ICollection<ElementId> detailElementIds)
      Description: Places the given detail instances in the front of all other detail instances in the view, while keeping the order of the given ones.
      @document: The document.
      @view: The view in which the details appear.
      @detailElementIds: The details to bring to front.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static void BringToFront(Document document, View view, ElementId detailElementId)
      Description: Places the given detail instance in the front of all other detail instances in the view.
      @document: The document.
      @view: The view in which the detail appears.
      @detailElementId: The detail element.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> GetDrawOrderForDetails(View view, ISet<ElementId> detailIdsToSort)
      Description: Returns the given detail elements according to the currently specified draw order for the detail elements in a given view.
      @view: The view in which the details appear.
      @detailIdsToSort: The detail to be sorted by draw order.
      Returns: The detail ids sorted from back to front, with earlier elements drawing first and appearing under later elements.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- detailIdsToSort is empty or it contains elements are not visible in the view. -or- detailIdsToSort is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsDetailElement(Document document, View view, ElementId detailElementId)
      Description: Indicates if the element is a detail element that participates in detail draw ordering in the view.
      @document: The document.
      @view: The view in which the detail appears.
      @detailElementId: The detail element.
      Returns: True if the detail element is orderable in the view, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static void SendBackward(Document document, View view, ICollection<ElementId> detailElementIds)
      Description: Moves the given detail instances one step closer to the back with relation to all other detail instances in the view, while keeping the order of the given ones.
      @document: The document.
      @view: The view in which the details appear.
      @detailElementIds: The details to move backward.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static void SendBackward(Document document, View view, ElementId detailElementId)
      Description: Moves the given detail instance one step closer to the back of all other detail instances in the view.
      @document: The document.
      @view: The view in which the detail appears.
      @detailElementId: The detail to move backward.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static void SendToBack(Document document, View view, ICollection<ElementId> detailElementIds)
      Description: Places the given detail instances behind all other detail instances in the view, while keeping the order of the given ones.
      @document: The document.
      @view: The view in which the details appear.
      @detailElementIds: The details to send to back.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- detailElementIds is empty or it contains elements that do not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null
    static void SendToBack(Document document, View view, ElementId detailElementId)
      Description: Places the given detail instance behind all detail instances in the view.
      @document: The document.
      @view: The view in which the detail appears.
      @detailElementId: The detail to send to back.
      Throws ArgumentException: The document does not support detail draw order. Only projects and 3d families support draw order. 2d families and in-place families do not support draw order. -or- The element detailElementId is not a detail or it does not participate in detail draw ordering. Details must be visible in the view. -or- In 3d families, detail draw order can only be adjusted in views that are parallel to the document's X, Y or Z axes.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DetailEllipse
Full Name: Autodesk.Revit.DB.DetailEllipse
Description: Represents a DetailEllipse within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from DetailCurve::geometryCurve property.
Inherits: DetailCurve

--------------------------------------------------------------------------------

[CLASS] DetailLine
Full Name: Autodesk.Revit.DB.DetailLine
Description: Represents a DetailLine within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from DetailCurve::geometryCurve property.
Inherits: DetailCurve

--------------------------------------------------------------------------------

[CLASS] DetailNurbSpline
Full Name: Autodesk.Revit.DB.DetailNurbSpline
Description: Represents a DetailNurbSpline within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from DetailCurve::geometryCurve property.
Inherits: DetailCurve

--------------------------------------------------------------------------------

[CLASS] DGNExportOptions
Full Name: Autodesk.Revit.DB.DGNExportOptions
Description: The export options used by exporting DGN format file.
Inherits: BaseExportOptions

  CONSTRUCTORS:
    new DGNExportOptions(DGNExportOptions option)
      Description: Constructs a new instance of DGNExportOptions as a copy of the export options.
      @option: The options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new DGNExportOptions()
      Description: Constructs a new instance of DGNExportOptions with default values of all properties.

  PROPERTIES:
    DGNFileFormat FileVersion { get; set; }
      Description: The DGN file version. Default value of fileVersion is DGNFileFormat.Default.
    bool MergedViews { get; set; }
      Description: Whether to merge all views in one file (via XRefs). Default value of mergedViews is false.
    string SeedName { get; set; }
      Description: The name of the DGN seed. Default value of seedName is empty.
    bool WorkingUnits { get; set; }
      Description: If true, Main Units will be used. If false, Sub Units will be used. Default value of WorkingUnits is true.

  METHODS:
    ExportLineweightTable GetExportLineweightTable()
      Description: Gets a copy of the line weight table.
      Returns: The line weight table.
    static DGNExportOptions GetPredefinedOptions(Document document, string setup)
      Description: Returns an instance DGNExportOptions containing settings from a predefined export setup.
      @document: A Revit project document to retrieve the setup from.
      @setup: The name of a predefined export setup from the specified document.
      Returns: An instance of predefined DGNExportOptions, or if the name was not found.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<string> GetPredefinedSetupNames(Document document)
      Description: Returns a list of names of predefined setups of DGN export options.
      @document: A Revit document to retrieve names from.
      Returns: An array of strings representing names of predefined setups.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    void SetExportLineweightTable(ExportLineweightTable lineweightTable)
      Description: Sets the line weight table to use during export.
      @lineweightTable: The line weight table to be set.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DGNFileFormat
Full Name: Autodesk.Revit.DB.DGNFileFormat
Description: An enumerated type listing available Microstation versions into which a file may be exported.
Inherits: Enum

  Values:
    - DGNVersion7 = 19
    - Default = 20
    - Default = 20

--------------------------------------------------------------------------------

[CLASS] DGNImportOptions
Full Name: Autodesk.Revit.DB.DGNImportOptions
Description: The import options used to import DGN format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new DGNImportOptions(DGNImportOptions option)
      Description: Constructs a new instance of DGNImportOptions as a copy of the import options.
      Throws ArgumentNullException: A non-optional argument was null
    new DGNImportOptions()
      Description: Constructs a new instance of DGNImportOptions with default values of all properties.

  PROPERTIES:
    string DGNModelViewName { get; set; }
      Description: The model view name to be imported. Need user give a model view name to specify which model view need to be imported into Revit
    bool IgnoreUnsupportedElementWarning { get; set; }
      Description: If true, ignore warning messages about unsupported elements in the DGN file. If false, the import process is aborted if imported dgn files have unsupported elements.

--------------------------------------------------------------------------------

[ENUM] DigitGroupingAmount
Full Name: Autodesk.Revit.DB.DigitGroupingAmount
Description: The number of digits in each group when numbers are formatted with digit grouping.
Inherits: Enum

  Values:
    - Two = 0
    - Three = 1

--------------------------------------------------------------------------------

[ENUM] DigitGroupingSymbol
Full Name: Autodesk.Revit.DB.DigitGroupingSymbol
Description: The symbol used to separate groups of digits when numbers are formatted with digit grouping.
Inherits: Enum

  Values:
    - Dot = 0
    - Comma = 1
    - Space = 2
    - Apostrophe = 3
    - Apostrophe = 3

--------------------------------------------------------------------------------

[CLASS] Dimension
Full Name: Autodesk.Revit.DB.Dimension
Description: An object that represents a dimension within the Revit project.
Inherits: Element

  PROPERTIES:
    string Above { get; set; }
      Description: The text shown above the segment's value.
    bool AreReferencesAvailable { get; }
      Description: Indicates if this dimension's references can be resolved.
    bool AreSegmentsEqual { get; set; }
      Description: Indicates if all segments are forced to be equal.
    string Below { get; set; }
      Description: The text shown below the segment's value.
    Curve Curve { get; }
      Description: A curve that represents the dimension line.
    DimensionShape DimensionShape { get; }
      Description: The shape of this dimension.
    DimensionType DimensionType { get; set; }
      Description: The dimension style of this dimension.
    FamilyParameter FamilyLabel { get; set; }
      Description: The family parameter label of the dimension.
    bool HasLeader { get; set; }
      Description: True if dimension has leader, false otherwise.
    bool IsLocked { get; set; }
      Description: Indicates if this dimension is locked.
    bool IsValid { get; }
      Description: Indicates if this dimension is valid.
    XYZ LeaderEndPosition { get; set; }
      Description: The position of the dimension's leader end point.
    string Name { get; set; }
      Description: Retrieves or changes the name associated with the Dimension.
    int NumberOfSegments { get; }
      Description: The number of segments for the dimension.
    XYZ Origin { get; }
      Description: The dimension origin.
    string Prefix { get; set; }
      Description: The text shown before the segment's value.
    ReferenceArray References { get; }
      Description: Returns an array of geometric references to which the dimension is attached.
    DimensionSegmentArray Segments { get; }
      Description: The segments in the dimension.
    string Suffix { get; set; }
      Description: The text shown after the segment's value.
    XYZ TextPosition { get; set; }
      Description: The position of the dimension text's drag point.
    Nullable<double> Value { get; }
      Description: The value of the dimension.
    string ValueOverride { get; set; }
      Description: The text that replaces the segment's value.
    string ValueString { get; }
      Description: The dimension value as a user visible string.
    View View { get; }
      Description: Supplies the view that contains the dimension if the dimension is view specific.

  METHODS:
    bool HasOneSegment()
      Description: Determines whether a dimension has one segment.
    bool IsTextPositionAdjustable()
      Description: Indicates if this dimension is supported to set/get TextPosition/LeaderEndPosition.
    void ResetTextPosition()
      Description: Resets the text position of the dimension to the initial position determined by its type and parameters.
      Throws InvalidOperationException: Thrown when: SpotDimension has more than one segments.

--------------------------------------------------------------------------------

[CLASS] DimensionEqualityLabelFormatting
Full Name: Autodesk.Revit.DB.DimensionEqualityLabelFormatting
Description: Instances of this class represent individual parameters used to make up a dimension equality formula for continuous linear or angular dimensions.
Implements: IDisposable

  CONSTRUCTORS:
    new DimensionEqualityLabelFormatting(int leadingSpaces, string prefix, LabelType labelType, string suffix, FormatOptions formatOptions)
      Description: Constructs a new instance of a DimensionEqualityLabelFormatting object with specified settings.
      @leadingSpaces: The number of spaces to include before the parameter value.
      @prefix: The prefix to include before the parameter value.
      @labelType: The parameter value to be shown.
      @suffix: The suffix to include after the parameter value.
      @formatOptions: The format options to use for the parameter value.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LabelType LabelType { get; }
      Description: The parameter value to be shown.
    int LeadingSpaces { get; set; }
      Description: The number of spaces to include before the parameter value.
    string Prefix { get; set; }
      Description: The prefix to include before the parameter value.
    string Suffix { get; set; }
      Description: The suffix to include after the parameter value.

  METHODS:
    void Dispose()
    FormatOptions GetFormatOptions()
      Description: Gets the format options used to show the parameter value.
      Returns: A copy of the format options.
    bool IsValidFormatOptions()
      Description: Checks whether a FormatOptions object is valid for the LabelType.
      Returns: True if the FormatOptions object is valid, false otherwise.
    void SetFormatOptions(FormatOptions formatOptions)
      Description: Sets the format options used to show the parameter value.
      @formatOptions: The format options to be set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This DimensionEqualityLabelFormatting uses a LabelType which does not support assignment of FormatOptions.

--------------------------------------------------------------------------------

[CLASS] DimensionSegment
Full Name: Autodesk.Revit.DB.DimensionSegment
Description: A segment of a dimension within the Autodesk Revit project.
Inherits: APIObject

  PROPERTIES:
    string Above { get; set; }
      Description: The text shown above the segment's value.
    string Below { get; set; }
      Description: The text shown below the segment's value.
    bool IsLocked { get; set; }
      Description: Indicates if this segment is locked.
    XYZ LeaderEndPosition { get; set; }
      Description: The position of the dimension leader end point.
    XYZ Origin { get; }
      Description: The segment origin.
    string Prefix { get; set; }
      Description: The text shown before the segment's value.
    string Suffix { get; set; }
      Description: The text shown after the segment's value.
    XYZ TextPosition { get; set; }
      Description: The position of the dimension text's drag point.
    Nullable<double> Value { get; }
      Description: The length of the segment.
    string ValueOverride { get; set; }
      Description: The text that replaces the segment's value.
    string ValueString { get; }
      Description: The displayed value shown for the dimension segment.

  METHODS:
    bool IsTextPositionAdjustable()
      Description: Indicates if this dimension is supported to set/get TextPosition/LeaderPosition.
      Returns: True if this dimension is supported to set/get TextPosition/LeaderPosition, false otherwise.
    void ResetTextPosition()
      Description: Resets the text position of the segment to the initial position determined by its type and parameters.

--------------------------------------------------------------------------------

[CLASS] DimensionSegmentArray
Full Name: Autodesk.Revit.DB.DimensionSegmentArray
Description: An array that can contain any number of DimensionSegment objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new DimensionSegmentArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    DimensionSegment Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(DimensionSegment item)
      Description: Add the item to the end of the array.
      @item: The item to be added.
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    DimensionSegmentArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(DimensionSegment item, int index)
      Description: Insert the specified item into the array.
      @item: The item to be inserted into the array.
      @index: The item will be inserted before this index.
    DimensionSegmentArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DimensionSegmentArrayIterator
Full Name: Autodesk.Revit.DB.DimensionSegmentArrayIterator
Description: An iterator to an array of DimensionSegment objects..
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new DimensionSegmentArrayIterator()
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

[ENUM] DimensionShape
Full Name: Autodesk.Revit.DB.DimensionShape
Description: An enumerated type to list dimension type.
Inherits: Enum

  Values:
    - Linear = 0
    - Angular = 1
    - Radial = 2
    - ArcLength = 3
    - Spot = 4
    - Diameter = 5
    - Unknown = 6

--------------------------------------------------------------------------------

[ENUM] DimensionStyleType
Full Name: Autodesk.Revit.DB.DimensionStyleType
Description: An enumerated type containing possible style types of dimensions.
Inherits: Enum

  Values:
    - Linear = 0
    - Angular = 1
    - Radial = 2
    - ArcLength = 3
    - SpotElevation = 4
    - SpotCoordinate = 5
    - LinearFixed = 7
    - SpotSlope = 8
    - Diameter = 9
    - AlignmentStationLabel = 10

--------------------------------------------------------------------------------

[CLASS] DimensionType
Full Name: Autodesk.Revit.DB.DimensionType
Description: An object that represents a dimension style.
Inherits: ElementType

  PROPERTIES:
    AlternateUnits AlternateUnits { get; set; }
      Description: The alternate units display mode for this DimensionType.
    string AlternateUnitsPrefix { get; set; }
      Description: The prefix text for the alternate units value.
    string AlternateUnitsSuffix { get; set; }
      Description: The suffix text for the alternate units value.
    string Prefix { get; set; }
      Description: The prefix text for the dimension value.
    DimensionStyleType StyleType { get; }
      Description: The dimension style type of this DimensionType.
    string Suffix { get; set; }
      Description: The suffix text for the dimension value.

  METHODS:
    bool CanHaveEqualityFormula()
      Description: Checks whether this DimensionType can have an equality formula.
      Returns: True when the DimensionType is continuous linear or angular, false otherwise
    bool CanHaveOrdinateDimensionSetting()
      Description: Checks whether this DimensionType can have an ordinate dimension settings.
      Returns: True when the DimensionType is linear and the Dimension String Type parameter is ordinate, false otherwise.
    FormatOptions GetAlternateUnitsFormatOptions()
      Description: Gets the FormatOptions to optionally override the default settings in the Units class for the alternate units value.
      Returns: A copy of the FormatOptions.
    IList<DimensionEqualityLabelFormatting> GetEqualityFormula()
      Description: Gets an ordered list of the entries in the equality formula definition.
      Returns: An ordered list of the entries in the equality formula definition.
      Throws InvalidOperationException: The given DimensionType cannot be assigned an equality formula as it is not continuous linear or angular.
    OrdinateDimensionSetting GetOrdinateDimensionSetting()
      Description: Gets the ordinate dimension settings for this DimensionType.
      Returns: The ordinate dimension settings.
    ForgeTypeId GetSpecTypeId()
      Description: Gets the spec of this dimension style.
      Returns: Identifier of the spec.
    FormatOptions GetUnitsFormatOptions()
      Description: Gets the FormatOptions to optionally override the default settings in the Units class for the units value.
      Returns: A copy of the FormatOptions.
    void SetAlternateUnitsFormatOptions(FormatOptions formatOptions)
      Description: Sets the FormatOptions to optionally override the default settings in the Units class for the alternate units value.
      @formatOptions: The FormatOptions.
      Throws ArgumentException: The display unit in formatOptions is not a valid display unit for the unit type of this DimensionType, or the rounding method in formatOptions is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.
      Throws ArgumentNullException: A non-optional argument was null
    void SetEqualityFormula(IList<DimensionEqualityLabelFormatting> formattingArr)
      Description: Sets an ordered list of the entries to use in the equality formula definition.
      @formattingArr: An ordered list of the entries to use in the equality formula definition.
      Throws ArgumentException: The input equality formula entries are not valid for use in the given DimensionType.
      Throws ArgumentNullException: A non-optional argument was null
    void SetOrdinateDimensionSetting(OrdinateDimensionSetting ordinateDimSetting)
      Description: Sets the ordinate dimension settings for this DimensionType.
      @ordinateDimSetting: The new ordinate dimension settings.
      Throws ArgumentException: The origin tick mark id in the Ordinate Dimension Setting is invalid for the dimension style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This DimensionType cannot be assigned ordinate dimension settings, as it is not a linear DimensionType or its Dimension String Type parameter is not set to Ordinate.
    void SetUnitsFormatOptions(FormatOptions formatOptions)
      Description: Sets the FormatOptions to optionally override the default settings in the Units class for the units value.
      @formatOptions: The FormatOptions.
      Throws ArgumentException: The display unit in formatOptions is not a valid display unit for the unit type of this DimensionType, or the rounding method in formatOptions is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DirectShape
Full Name: Autodesk.Revit.DB.DirectShape
Description: This class is used to store externally created geometric shapes. Primary intended use is for importing shapes from other data formats such as IFC or STEP. A DirectShape object may be assigned a category. That will affect how that object is displayed in Revit.
Remarks: DirectShape is not a replacement for "real" Wall, Roof, Window, etc. It would typically be used where there is not enough information to create, e.g., a Wall, or full functionality of a Wall object is not needed. Some category-specific functionality may be available. If you need to modify a shape held by a DirectShape object, use Revit Geometry API, and then store the modified shape back to the DirectShape object.
Inherits: Element

  PROPERTIES:
    string ApplicationDataId { get; set; }
      Description: A text string that identifies the data to the creating application.
    string ApplicationId { get; set; }
      Description: A text string that identifies the creating application.
    ElementId TypeId { get; }
      Description: Element id of a DirectShapeType object that holds properties to be shared by this element. Optional.

  METHODS:
    void AddExternallyTaggedGeometry(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Adds the externally tagged geometry object to the DirectShape.
      @externallyTaggedGeometry: The externally tagged geometry that should be added to the DirectShape.
      Throws ArgumentException: The input shape does not satisfy DirectShape validation criteria. -or- The input geometry does not have a permitted usage. -or- The externallyTaggedGeometry has already been added to this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferenceCurve(Curve refCurve, DirectShapeReferenceOptions options)
      Description: Adds a reference curve to the DirectShape.
      @refCurve: The geometry of the new reference curve.
      @options: The options that are used to configure the new reference curve.
      Throws ArgumentException: refCurve cannot be used for creating a reference curve. -or- options cannot be used to add a reference object to this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferenceCurve(Curve refCurve)
      Description: Adds a reference curve to the DirectShape.
      @refCurve: The geometry of the new reference curve.
      Throws ArgumentException: refCurve cannot be used for creating a reference curve.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane, BoundingBoxUV boundingBoxUV, DirectShapeReferenceOptions options)
      Description: Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      @boundingBoxUV: If boundingBoxUV is set, the resulting reference plane that is added to the DirectShape will be displayed with those bounds. Note that the specified bounds must not be degenerate. If boundingBoxUV is not set, reasonable bounds are automatically calculated and applied to the input plane. The automatic bounds are based on the host direct shape's geometry.
      @options: The options that are used to configure the new reference plane.
      Throws ArgumentException: boundingBoxUV cannot be used as a BoundingBoxUV for the reference plane surface. -or- options cannot be used to add a reference object to this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane, DirectShapeReferenceOptions options)
      Description: Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      @options: The options that are used to configure the new reference plane.
      Throws ArgumentException: options cannot be used to add a reference object to this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane, BoundingBoxUV boundingBoxUV)
      Description: Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      @boundingBoxUV: If boundingBoxUV is set, the resulting reference plane that is added to the DirectShape will be displayed with those bounds. Note that the specified bounds must not be degenerate. If boundingBoxUV is not set, reasonable bounds are automatically calculated and applied to the input plane. The automatic bounds are based on the host direct shape's geometry.
      Throws ArgumentException: boundingBoxUV cannot be used as a BoundingBoxUV for the reference plane surface.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane)
      Description: Adds a reference plane to the DirectShape. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePoint(XYZ refPoint, DirectShapeReferenceOptions options)
      Description: Adds a reference point to the DirectShape.
      @refPoint: The coordinates of the new reference point.
      @options: The options that are used to configure the new reference point.
      Throws ArgumentException: The input point lies outside of Revit design limits. -or- options cannot be used to add a reference object to this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePoint(XYZ refPoint)
      Description: Adds a reference point to the DirectShape.
      @refPoint: The coordinates of the new reference point.
      Throws ArgumentException: The input point lies outside of Revit design limits.
      Throws ArgumentNullException: A non-optional argument was null
    void AppendShape(ShapeBuilder ShapeBuilder)
      Description: Appends shape built by the supplied ShapeBuilderObject to shape representation stored in this DirectShape. The data stored in the supplied ShapeBuilder object will be cleared.
      @ShapeBuilder: The ShapeBuilder object that was used to build the shape to be appended.
      Throws ArgumentNullException: A non-optional argument was null
    void AppendShape(IList<GeometryObject> pGeomArr, DirectShapeTargetViewType viewType)
      Description: Appends the collection of GeometryObjects into the model or view specific shape representation stored in this DirectShape. Passing DirectShapeTargetViewType.Default as view type will cause the model shape to be updated.
      @pGeomArr: Shape expressed as a collection of GeometryObjects. For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve. For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.
      @viewType: Passing DirectShapeTargetViewType.Default as view type will cause the default shape to be appended.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShape validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void AppendShape(IList<GeometryObject> pGeomArr)
      Description: Appends the collection of GeometryObjects into the model shape representation stored in this DirectShape.
      @pGeomArr: Shape expressed as a collection of GeometryObjects. The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShape validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    bool AreOptionsValid(DirectShapeOptions options)
      Description: Validates that the given DirectShapeOptions are allowed for this particular DirectShape.
      @options: The options object.
      Returns: True if the DirectShapeOptions are valid; false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool AreOptionsValidForTransientDirectShape(DirectShapeOptions options)
      Description: Validates that the given DirectShapeOptions are allowed if this DirectShape is transient.
      @options: The options object.
      Returns: True if the DirectShapeOptions are valid; false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool AreValidDirectShapeReferenceOptions(DirectShapeReferenceOptions options)
      Description: Validates that the input DirectShapeReferenceOptions are suitable for creating a direct shape reference object. If the options specify an ExternalGeometryId, it must not correspond to any existing reference object belonging to the DirectShape.
      @options: The options to test.
      Returns: True if the options can be used to add a reference object to this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanCreateParts()
      Description: Indicates if it is possible to create parts from this DirectShape element.
      Returns: True if it is possible to create parts from this DirectShape.
    static DirectShape CreateElement(Document document, ElementId categoryId)
      Description: Creates a DirectShape object and adds it to document.
      @document: Document to which the created element will be added.
      @categoryId: Id of the category assigned to this DirectShape. Must be a valid category id.
      Returns: The created DirectShape object.
      Throws ArgumentException: Document document may not contain DirectShape or DirectShapeType objects. -or- Element id categoryId may not be used as a DirectShape category.
      Throws ArgumentNullException: A non-optional argument was null
    static DirectShape CreateElementInstance(Document document, ElementId typeId, ElementId categoryId, string definitionId, Transform trf)
      Description: Creates a DirectShape object and adds it to document.
      @document: Document to which the created element will be added.
      @typeId: Element id of a DirectShapeType element.
      @categoryId: Id of the category assigned to this DirectShape. Must be a valid category id.
      @definitionId: Id of the shape definition that was created earlier and stored via DirectShapeLibrary.
      @trf: Transform to be applied to the definition.
      Returns: The created DirectShape object.
      Throws ArgumentException: Document document may not contain DirectShape or DirectShapeType objects. -or- Element id categoryId may not be used as a DirectShape category.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<GeometryObject> CreateGeometryInstance(Document document, string definition_id, Transform trf)
      Description: Creates a copy of a definition shape that was created earlier.
      @document: Document to which the created element will be added
      @definition_id: ID of the shape definition that was created earlier and stored via DirectShapeLibrary
      @trf: Transform to be applied to the definition
      Returns: A collection of GeometryObjects representing a placed instance of the pre-defined shape The caller function takes ownership
      Throws ArgumentNullException: A non-optional argument was null
    ExternallyTaggedGeometryObject GetExternallyTaggedGeometry(ExternalGeometryId externalId)
      Description: Gets the externally tagged geometry by its external ID that is stored in this DirectShape.
      @externalId: The external ID of the externally tagged geometry that should be obtained.
      Returns: The externally tagged geometry. Or if there is no such externally tagged geometry in the DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    Reference GetExternallyTaggedReference(ExternalGeometryId externalId)
      Description: Retrieve a Reference to reference geometry of the DirectShape that is associated with a particular ExternalGeometryId.
      @externalId: The ExternalGeometryId of the requested reference object.
      Returns: A Reference to the externally tagged reference GeometryObject having the provided external ID or if there is no reference geometry having the external ID.
      Throws ArgumentNullException: A non-optional argument was null
    DirectShapeOptions GetOptions()
      Description: Gets a copy of the current options for this DirectShape.
      Returns: Options currently set for this DirectShape.
    bool HasExternalGeometry(ExternalGeometryId externalId)
      Description: Checks whether the externally tagged geometry is already present in this DirectShape.
      @externalId: The external ID of the externally tagged geometry to check.
      Returns: True if such an externally tagged geometry is already present in this DirectShape, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasExternallyTaggedReference(ExternalGeometryId externalId)
      Description: Checks if the externally tagged reference is already present in this DirectShape.
      @externalId: The external ID of the tagged reference to check for.
      Returns: True if the DirectShape holds a reference with the specified ExternalGeometryId.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsSupportedDocument(Document document)
      Description: Tests whether a DirectShape or a DirectShapeType may be created in this document.
      @document: Document to be tested.
      Returns: True if a DirectShape or a DirectShapeType object can be created in this document, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidCategoryId(ElementId categoryId, Document doc)
      Description: Test the category id to make sure the category is allowed for a DirectShape or DirectShapeType.
      @categoryId: Category id to be tested.
      @doc: Document to look up the category by id.
      Returns: True if the category is allowed for a DirectShape or DirectShapeType, false if not.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidGeometry(Solid Geom)
      Description: Validates geometry to be stored in a DirectShape. Suitable geometry validation is performed. Additionally, the geometry must make sense as a shape representation for the category assigned to this DirectShape object.
      @Geom: GeometryObject to be validated.
      Returns: True if the supplied GeometryObject passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidReferenceCurve(Curve curve)
      Description: Validates that the input curve is suitable for creating a direct shape reference curve. Bounded and unbounded lines are accepted. Other bounded and unbounded curve types with natural bounds are accepted if they are not closed. Unbounded periodic curves are not allowed.
      @curve: The curve to test.
      Returns: True if the input curve point can be used to create a direct shape reference curve, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidReferencePlaneBoundingBoxUV(BoundingBoxUV boundingBoxUV)
      Description: Validates that the input BoundingBoxUV is suitable for bounding a reference plane surface. The input BoundingBoxUV must be set and not degenerate.
      @boundingBoxUV: The reference plane BoundingBoxUV to test.
      Returns: True if the input BoundingBoxUV is valid for reference plane surfaces, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidShape(IList<GeometryObject> shape, DirectShapeTargetViewType viewType)
      Description: Validates view-specific shape to be stored in a DirectShape. Expects a non-default view type.
      @shape: Shape of this object expressed as a collection of GeometryObjects. For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve. For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.
      @viewType: The view type this shape is intended for.
      Returns: True if the supplied shape passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidShape(IList<GeometryObject> shape)
      Description: Validates shape to be stored in a DirectShape. Supercedes and extends IsValidGeometry().
      @shape: Shape to be validated represented as a collection of GeometryObjects. The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
      Returns: True if the supplied shape passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidShape(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Validates shape to be stored in a DirectShape.
      @externallyTaggedGeometry: The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
      Returns: True if the supplied shape passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidTypeId(ElementId typeId)
      Description: Tests the type id to make sure it satisfies the following conditions It is a valid element id.It corresponds to a valid DirectShapeType.The DirectShapeType has the same category assigned. Additionally, this functions tests that the current type id in this DirectShape is invalid. The type id is initialized to invalidElementId by the create functions. Once it is set, it may no longer be changed.
      @typeId: Type id to be tested.
      Returns: False unless typeId satisfies the conditions listed above and the type id of this object was not set previously.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidUsage(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Validates that the ExternallyTaggedGeometryObject's usage is set to an allowed value for a DirectShape.
      @externallyTaggedGeometry: The geometry to check.
      Returns: True if the usage is permitted.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveAllReferenceObjects()
      Description: Removes all reference objects (if any) from the DirectShape.
    void RemoveExternallyTaggedGeometry(ExternalGeometryId externalId)
      Description: Removes the externally tagged geometry object by its external ID from this DirectShape.
      @externalId: The external ID of the externally tagged geometry that should be removed.
      Throws ArgumentException: The externally tagged geometry with the input externalId is not present in this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveReferenceObject(ExternalGeometryId externalId)
      Description: Removes any reference object associated with the provided ExternalGeometryId from the DirectShape. Nothing is done if no reference object has the given external ID or if the external ID is an empty string.
      @externalId: The ExternalGeometryId of the reference object to be removed.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveReferenceObject(string refName)
      Description: Removes any reference objects with the given name from the DirectShape. Nothing is done if no reference objects have the given name or if the name is the empty string.
      @refName: The name of the reference object(s) to be removed.
      Throws ArgumentNullException: A non-optional argument was null
    void ResetExternallyTaggedGeometry()
      Description: Removes all of the externally tagged geometry in this DirectShape.
    void SetName(string name)
      Description: Sets the name for the DirectShape element.
      @name: The name.
      Throws ArgumentNullException: A non-optional argument was null
    void SetOptions(DirectShapeOptions options)
      Description: Sets the options to use for this DirectShape.
      @options: Options to use for this DirectShape.
      Throws ArgumentException: The DirectShapeOptions provided are not valid for this DirectShape. -or- The DirectShapeOptions provided are not valid for this transient DirectShape.
      Throws ArgumentNullException: A non-optional argument was null
    void SetShape(ShapeBuilder pBuilder)
      Description: Sets the shape of this object to the one accumulated in the supplied Builder object. If the new shape is identical to the old one, the old shape will be kept.
      @pBuilder: A ShapeBuilder object that was used to successfully build geometry to store in this DirectShape. The built shape will be transferred to the DirectShape, and the ShapeBuilder object will be reset.
      Throws ArgumentNullException: A non-optional argument was null
    void SetShape(IList<GeometryObject> pGeomArr, DirectShapeTargetViewType viewType)
      Description: Builds the shape of this object from the supplied collection of GeometryObjects. The objects are copied. If the new shape is identical to the old one, the old shape will be kept.
      @pGeomArr: Shape of this object expressed as a collection of GeometryObjects. For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve. For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.
      @viewType: Optional: set a view-specific shape representation that will be used in views of that type only. Passing DirectShapeTargetViewType::Default as view type will cause the default shape to be set.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShape validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetShape(IList<GeometryObject> pGeomArr)
      Description: Builds the shape of this object from the supplied collection of GeometryObjects. The objects are copied. If the new shape is identical to the old one, the old shape will be kept.
      @pGeomArr: Shape of this object expressed as a collection of GeometryObjects. The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShape validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    void SetTypeId(ElementId typeId)
      Description: Sets the DirectShapeType for the DirectShape element.
      @typeId: The ID of the type corresponding to this DirectShape element. May only be set once.
      Throws ArgumentException: typeId is not a valid Element identifier.
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateExternallyTaggedGeometry(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Updates the externally tagged geometry object in the DirectShape.
      @externallyTaggedGeometry: The externally tagged geometry that should be updated in the DirectShape.
      Throws ArgumentException: The input shape does not satisfy DirectShape validation criteria. -or- A previous version of the externally tagged geometry is not present in this DirectShape.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DirectShapeLibrary
Full Name: Autodesk.Revit.DB.DirectShapeLibrary
Description: DirectShapeLibrary is used to store pre-created geometry for further referencing via the definition/instance mechanism. It is not persistent: the scope of a library object is usually a single data creation session. DirectShape::createGeometryInstance and DirectShape::CreateElementInstance will use the current DirectShapeLibrary to look up the definitions. store a collection of GNodes as definition end class DirectShapeDefinition
Remarks: There are two ways to add a definition to the library. The first is to add the definition as an array of geometry objects. A DirectShape created as an instance of that definition will hold a copy of predefined geometry, transformed as requested. If the definition was added as a DirectShapeType, a DirectShape object created as an instance of that definition will reference the type. Its geometry would be an instance of type geometry.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddDefinition(string id, IList<GeometryObject> GNodes)
      Description: Add a definition to be reused by instances. A definition is a collection of geometry objects.
      @id: ID of the definition to be added. Must be unique.
      @GNodes: Definition as a list of Geometry objects
      Throws ArgumentNullException: A non-optional argument was null
    void AddDefinition(string id, GeometryObject GNode)
      Description: Add a definition to be reused by instances. A definition is a single geometry object.
      @id: ID of the definition to be added. Must be unique.
      @GNode: Definition as a single Geometry object
      Throws ArgumentNullException: A non-optional argument was null
    void AddDefinitionType(string id, ElementId typeId)
      Description: Add a definition to be reused by instances. Adding a definition type will change how the instances are created. When asked to create a definition, the library object will look for a corresponding type object. If one is found, it will create an instance of geometry stored in the type object. If it is not found, the library will look for a list of geometry objects stored as definition, and will copy and transform these to create an instance.
      @id: ID of the definition to be added. Must be unique.
      @typeId: Element id of the DirectShapeType element that will be used as a definition.
      Throws ArgumentNullException: A non-optional argument was null
    bool Contains(string id)
      Description: A quick check whether a definition already exists in the library. Checks for stored geometry objects only.
      @id: Definition id
      Returns: True if a geometry definition exists, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool ContainsType(string name)
      Description: A quick check whether a definition type already exists in the library. Checks for type objects only.
      @name: Definition id
      Returns: True if a geometry definition exists, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    IList<GeometryObject> FindDefinition(string id)
      Description: Find a definition by id
      @id: Definition id. Expecected to be unique
      Returns: List of geometry objects that together define a shape
      Throws ArgumentNullException: A non-optional argument was null
    ElementId FindDefinitionType(string id)
      Description: Find a DirectShapeType element by definition id. The element will be used for creating instances of that definition.
      @id: Definition id. Expected to be unique.
      Returns: Element id of a DirectShapeTypeElement
      Throws ArgumentNullException: A non-optional argument was null
    static DirectShapeLibrary GetDirectShapeLibrary(Document ADoc)
      Description: Get the currently active Library object
      Throws ArgumentNullException: A non-optional argument was null
    void Reset()
      Description: Removes all definitions from library. This is useful when importing several self-contained data sets within one session. Once a data set is imported, keeping the definitions specific to that data set will slow down the searches.

--------------------------------------------------------------------------------

[CLASS] DirectShapeOptions
Full Name: Autodesk.Revit.DB.DirectShapeOptions
Description: This class is used to control behavior of a DirectShape object.
Remarks: Use Enable/Disable functions to change the default behavior. Use DirectShape.SetOptions to modify that object's behavior.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    DirectShapeReferencingOption ReferencingOption { get; set; }
      Description: Whether or not the geometry stored in a DirectShape object may be referenced.
    DirectShapeRoomBoundingOption RoomBoundingOption { get; }
      Description: Identifies whether the DirectShape supports an option for the "Room Bounding" parameter to permit participation in room boundary calculations.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] DirectShapeReferenceOptions
Full Name: Autodesk.Revit.DB.DirectShapeReferenceOptions
Description: This class is used to control the behavior of DirectShape and DirectShapeType reference objects.
Implements: IDisposable

  CONSTRUCTORS:
    new DirectShapeReferenceOptions()
      Description: Constructs a new DirectShapeRefOptions instance with default settings.
    new DirectShapeReferenceOptions(DirectShapeReferenceOptions other)
      Description: Constructs a new copy of the input DirectShapeRefOptions object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: The name associated with the reference object. The name does not need to be unique. The name must not be empty and must contain valid characters.

  METHODS:
    void Dispose()
    ExternalGeometryId GetExternalGeometryId()
      Description: Retrieves the ExternalGeometryId associated with the reference object.
    static bool IsValidExternalGeometryId(ExternalGeometryId externalId)
      Description: Validates that the input ExternalGeometryId can be assigned to a direct shape reference.
      @externalId: The ExternalGeometryId to assign to the reference.
      Returns: True if the provided ExternalGeometryId is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidReferenceName(string name)
      Description: Validates that the input name can be assigned to a direct shape reference.
      @name: The name to assign to the reference.
      Returns: True if the input name is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    DirectShapeReferenceOptions SetExternalGeometryId(ExternalGeometryId externalId)
      Description: Sets the ExternalGeometryId associated with the reference object. The ID must be non-empty.
      Throws ArgumentException: externalId cannot be used as an ExternalGeometryId for a direct shape reference.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DirectShapeReferencingOption
Full Name: Autodesk.Revit.DB.DirectShapeReferencingOption
Description: An enumerated type containing possible referencing options for DirectShapes.
Inherits: Enum

  Values:
    - NotReferenceable = 0
    - Referenceable = 1

--------------------------------------------------------------------------------

[ENUM] DirectShapeRoomBoundingOption
Full Name: Autodesk.Revit.DB.DirectShapeRoomBoundingOption
Description: An enumerated type containing possible room bounding settings for DirectShapes.
Inherits: Enum

  Values:
    - NotApplicable = 0
    - SetByParameter = 1

--------------------------------------------------------------------------------

[ENUM] DirectShapeTargetViewType
Full Name: Autodesk.Revit.DB.DirectShapeTargetViewType
Description: View types for which DirectShape objects are allowed to have alternative shape representations
Inherits: Enum

  Values:
    - Undefined = 0
    - Default = 1
    - Plan = 2

--------------------------------------------------------------------------------

[CLASS] DirectShapeType
Full Name: Autodesk.Revit.DB.DirectShapeType
Description: The type element associated with a DirectShape element. This element includes data reused by DirectShape elements of the same type.
Inherits: ElementType

  PROPERTIES:
    DirectShapeTypeUserAssignability UserAssignability { get; set; }
      Description: An option controlling the ability of DirectShapes to assign this DirectShapeType as its type.

  METHODS:
    void AddExternallyTaggedGeometry(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Adds the externally tagged geometry object to the DirectShapeType.
      @externallyTaggedGeometry: The externally tagged geometry that should be added to the DirectShapeType.
      Throws ArgumentException: The input shape does not satisfy DirectShapeType validation criteria. -or- The input geometry does not have a permitted usage. -or- The externallyTaggedGeometry has already been added to this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferenceCurve(Curve refCurve, DirectShapeReferenceOptions options)
      Description: Adds a reference curve to the DirectShapeType.
      @refCurve: The geometry of the new reference curve.
      @options: The options that are used to configure the new reference curve.
      Throws ArgumentException: refCurve cannot be used for creating a reference curve. -or- options cannot be used to add a reference object to this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferenceCurve(Curve refCurve)
      Description: Adds a reference curve to the DirectShapeType.
      @refCurve: The geometry of the new reference curve.
      Throws ArgumentException: refCurve cannot be used for creating a reference curve.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane, BoundingBoxUV boundingBoxUV, DirectShapeReferenceOptions options)
      Description: Adds a reference plane to the DirectShapeType. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      @boundingBoxUV: If boundingBoxUV is set, the resulting reference plane that is added to the DirectShapeType will be displayed with those bounds. Note that the specified bounds must not be degenerate. If boundingBoxUV is not set, reasonable bounds are automatically calculated and applied to the input plane. The automatic bounds are based on the host direct shape's geometry.
      @options: The options that are used to configure the new reference plane.
      Throws ArgumentException: boundingBoxUV cannot be used as a BoundingBoxUV for the reference plane surface. -or- options cannot be used to add a reference object to this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane, DirectShapeReferenceOptions options)
      Description: Adds a reference plane to the DirectShapeType. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      @options: The options that are used to configure the new reference plane.
      Throws ArgumentException: options cannot be used to add a reference object to this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane, BoundingBoxUV boundingBoxUV)
      Description: Adds a reference plane to the DirectShapeType. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      @boundingBoxUV: If boundingBoxUV is set, the resulting reference plane that is added to the DirectShapeType will be displayed with those bounds. Note that the specified bounds must not be degenerate. If boundingBoxUV is not set, reasonable bounds are automatically calculated and applied to the input plane. The automatic bounds are based on the host direct shape's geometry.
      Throws ArgumentException: boundingBoxUV cannot be used as a BoundingBoxUV for the reference plane surface.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePlane(Plane refPlane)
      Description: Adds a reference plane to the DirectShapeType. The reference plane can either be bounded or unbounded.
      @refPlane: The geometry of the new reference plane.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePoint(XYZ refPoint, DirectShapeReferenceOptions options)
      Description: Adds a reference point to the DirectShapeType.
      @refPoint: The coordinates of the new reference point.
      @options: The options that are used to configure the new reference point.
      Throws ArgumentException: The input point lies outside of Revit design limits. -or- options cannot be used to add a reference object to this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferencePoint(XYZ refPoint)
      Description: Adds a reference point to the DirectShapeType.
      @refPoint: The coordinates of the new reference point.
      Throws ArgumentException: The input point lies outside of Revit design limits.
      Throws ArgumentNullException: A non-optional argument was null
    void AppendShape(ShapeBuilder ShapeBuilder)
      Description: Append shape built by the supplied ShapeBuilderObject to shape representation stored in this DirectShapeType. The data stored in the supplied ShapeBuilder object will be cleared.
      @ShapeBuilder: The ShapeBuilder object that was used to build the shape to be appended.
      Throws ArgumentNullException: A non-optional argument was null
    void AppendShape(IList<GeometryObject> pGeomArr, DirectShapeTargetViewType viewType)
      Description: Appends the collection of GeometryObjects into the model or view specific shape representation stored in this DirectShapeType. Passing DirectShapeTargetViewType.Default as view type will cause the model shape to be updated.
      @pGeomArr: Shape expressed as a collection of GeometryObjects. For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine. For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.
      @viewType: Passing DirectShapeTargetViewType.Default as view type will cause the default shape to be appended.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void AppendShape(IList<GeometryObject> pGeomArr)
      Description: Appends the collection of GeometryObjects into the model shape representation stored in this DirectShape.
      @pGeomArr: Shape expressed as a collection of GeometryObjects. The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    bool AreOptionsValid(DirectShapeTypeOptions options)
      Description: Validates that the given DirectShapeTypeOptions are allowed for this particular DirectShapeType.
      @options: The options object.
      Returns: True if the DirectShapeTypeOptions are valid; false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool AreValidDirectShapeReferenceOptions(DirectShapeReferenceOptions options)
      Description: Validates that the input DirectShapeReferenceOptions are suitable for creating a direct shape reference object. If the options specify an ExternalGeometryId, it must not correspond to any existing reference object belonging to the DirectShapeType.
      @options: The options to test.
      Returns: True if the options can be used to add a reference object to this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanChangeFamilyName()
      Description: Checks whether the DirectShapeType supports a custom family name.
      Returns: True if a custom family name is supported, false otherwise.
    bool CanCreateParts()
      Description: Indicates if it is possible to create parts from this DirectShapeType element.
      Returns: True if it is possible to create parts from this DirectShapeType.
    static DirectShapeType Create(Document document, string name, ElementId categoryId, DirectShapeTypeOptions options)
      Description: Creates a DirectShapeType element.
      @document: Document to which the created element will be added.
      @name: Name of the DirectShapeType.
      @categoryId: Id of the category assigned to this DirectShapeType. Must be a valid category id.
      @options: Options that can be used to control the behavior of DirectShapeType being created.
      Returns: The new DirectShapeType.
      Throws ArgumentException: Document document may not contain DirectShape or DirectShapeType objects. -or- Element id categoryId may not be used as a DirectShape category.
      Throws ArgumentNullException: A non-optional argument was null
    static DirectShapeType Create(Document document, string name, ElementId categoryId)
      Description: Creates a DirectShapeType element.
      @document: Document to which the created element will be added. Must be a project document.
      @name: Name of the DirectShapeType.
      @categoryId: Id of the category assigned to this DirectShapeType. Must be a valid category id.
      Returns: The new DirectShapeType.
      Throws ArgumentException: document is not a project document. -or- Document document may not contain DirectShape or DirectShapeType objects. -or- Element id categoryId may not be used as a DirectShape category.
      Throws ArgumentNullException: A non-optional argument was null
    ExternallyTaggedGeometryObject GetExternallyTaggedGeometry(ExternalGeometryId externalId)
      Description: Gets the externally tagged geometry by its external ID that is stored in this DirectShapeType.
      @externalId: The external ID of the externally tagged geometry that should be obtained.
      Returns: The externally tagged geometry. Or if there is no such externally tagged geometry in the DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    Reference GetExternallyTaggedReference(ExternalGeometryId externalId)
      Description: Retrieve a Reference to reference geometry of the DirectShapeType that is associated with a particular ExternalGeometryId.
      @externalId: The ExternalGeometryId of the requested reference object.
      Returns: A Reference to the externally tagged reference GeometryObject having the provided external ID or if there is no reference geometry having the external ID.
      Throws ArgumentNullException: A non-optional argument was null
    DirectShapeTypeOptions GetOptions()
      Description: Gets a copy of the current options for this DirectShapeType.
      Returns: Options currently set for this DirectShapeType.
    bool HasExternalGeometry(ExternalGeometryId externalId)
      Description: Checks whether the externally tagged geometry is already present in this DirectShapeType.
      @externalId: The external ID of the externally tagged geometry to check.
      Returns: True if such an externally tagged geometry is already present in this DirectShapeType, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasExternallyTaggedReference(ExternalGeometryId externalId)
      Description: Checks if the externally tagged reference is already present in this DirectShapeType.
      @externalId: The external ID of the tagged reference to check for.
      Returns: True if the DirectShapeType holds a reference with the specified ExternalGeometryId.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidReferenceCurve(Curve curve)
      Description: Validates that the input curve is suitable for creating a direct shape type reference curve. Bounded and unbounded lines are accepted. Other bounded and unbounded curve types with natural bounds are accepted if they are not closed. Unbounded periodic curves are not allowed.
      @curve: The curve to test.
      Returns: True if the input curve point can be used to create a direct shape reference curve, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidReferencePlaneBoundingBoxUV(BoundingBoxUV boundingBoxUV)
      Description: Validates that the input BoundingBoxUV is suitable for bounding a reference plane surface. The input BoundingBoxUV must be set and not degenerate.
      @boundingBoxUV: The reference plane BoundingBoxUV to test.
      Returns: True if the input BoundingBoxUV is valid for reference plane surfaces, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidShape(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Validates shape to be stored in a DirectShapeType.
      @externallyTaggedGeometry: The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve.
      Returns: True if the supplied shape passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidShape(IList<GeometryObject> shape, DirectShapeTargetViewType viewType)
      Description: Validates view-specific shape to be stored in a DirectShapeType. Expects a non-default view type.
      @shape: Shape of this object expressed as a collection of GeometryObjects. For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine. For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve.
      @viewType: The view type this shape is intended for.
      Returns: True if the supplied shape passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidShape(IList<GeometryObject> shape)
      Description: Validates shape to be stored in a DirectShapeType.
      @shape: Shape to be validated represented as a collection of GeometryObjects. The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.
      Returns: True if the supplied shape passes the validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidUsage(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Validates that the ExternallyTaggedGeometryObject's usage is set to an allowed value for a DirectShapeType.
      @externallyTaggedGeometry: The geometry to check.
      Returns: True if the usage is permitted.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveAllReferenceObjects()
      Description: Removes all reference objects (if any) from the DirectShapeType.
    void RemoveExternallyTaggedGeometry(ExternalGeometryId externalId)
      Description: Removes the externally tagged geometry object by its external ID from this DirectShapeType.
      @externalId: The external ID of the externally tagged geometry that should be removed.
      Throws ArgumentException: The externally tagged geometry with the input externalId is not present in this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveReferenceObject(ExternalGeometryId externalId)
      Description: Removes any reference object associated with the provided ExternalGeometryId from the DirectShapeType. Nothing is done if no reference object has the given external ID or if the external ID is an empty string.
      @externalId: The ExternalGeometryId of the reference object to be removed.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveReferenceObject(string refName)
      Description: Removes any reference objects with the given name from the DirectShapeType. Nothing is done if no reference objects have the given name or if the name is the empty string.
      @refName: The name of the reference object(s) to be removed.
      Throws ArgumentNullException: A non-optional argument was null
    void ResetExternallyTaggedGeometry()
      Description: Removes all of the externally tagged geometry in this DirectShapeType.
    void SetFamilyName(string name)
      Description: Sets the family name for the DirectShapeType.
      @name: Family name for the DirectShapeType.
      Throws ArgumentException: The element type name was empty, contained invalid characters, or was invalid for the specific element type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The given DirectShapeType has a category which does not support a custom family name.
    void SetOptions(DirectShapeTypeOptions options)
      Description: Sets the options to use for this DirectShapeType.
      @options: Options to use for this DirectShapeType.
      Throws ArgumentException: The DirectShapeTypeOptions provided are not valid for this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null
    void SetShape(ShapeBuilder pBuilder)
      Description: Sets the shape of this object to the one accumulated in the supplied Builder object. If the new shape is identical to the old one, the old shape will be kept.
      @pBuilder: A ShapeBuilder object that was used to successfully build geometry to store in this DirectShapeType. The built shape will be transferred to the DirectShapeType, and the ShapeBuilder object will be reset.
      Throws ArgumentNullException: A non-optional argument was null
    void SetShape(IList<GeometryObject> pGeomArr, DirectShapeTargetViewType viewType)
      Description: Builds the type shape from the supplied collection of GeometryObjects. The objects are copied. If the new shape is identical to the old one, the old shape will be kept.
      @pGeomArr: Shape of this object expressed as a collection of GeometryObjects. These will be copied. Shape and Category should be consistent: geometry supplied as shape should be valid for the Category the type object is associated with. For viewType = DirectShapeTargetViewType::Default, the supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point and Curve. For viewType = DirectShapeTargetViewType::Plan, the supported types of GeometryObjects are: Point and Curve
      @viewType: Specifies which target view type to associate the geometry with. The target view type will decide which views can show this geometry.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetShape(IList<GeometryObject> pGeomArr)
      Description: Builds the type shape from the supplied collection of GeometryObjects. The objects are copied. If the new shape is identical to the old one, the old shape will be kept.
      @pGeomArr: Shape of this object expressed as a collection of GeometryObjects. These will be copied. Shape and Category should be consistent: geometry supplied as shape should be valid for the Category the type object is associated with. The supported types of GeometryObjects are: Solid, Mesh, GeometryInstance, Point, Curve and PolyLine.
      Throws ArgumentException: At least one member of pGeomArr does not satisfy DirectShapeType validation criteria.
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateExternallyTaggedGeometry(ExternallyTaggedGeometryObject externallyTaggedGeometry)
      Description: Updates the externally tagged geometry object in the DirectShapeType.
      @externallyTaggedGeometry: The externally tagged geometry that should be updated in the DirectShapeType.
      Throws ArgumentException: The input shape does not satisfy DirectShapeType validation criteria. -or- A previous version of the externally tagged geometry is not present in this DirectShapeType.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DirectShapeTypeOptions
Full Name: Autodesk.Revit.DB.DirectShapeTypeOptions
Description: This class is used to control behavior of a DirectShapeType object.
Remarks: Use Enable/Disable functions to change the default behavior. Use DirectShapeType.SetOptions to modify that object's behavior.
Implements: IDisposable

  CONSTRUCTORS:
    new DirectShapeTypeOptions()
      Description: Constructs a new DirectShapeTypeOptions instance with default settings.

  PROPERTIES:
    bool AllowDuplicateNames { get; set; }
      Description: Determines whether or not duplicate DirectShapeType names are allowed.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsEqualTo(DirectShapeTypeOptions other)
      Description: Compare this object with the one supplied as argument. Return true if the options specified by both objects are the same.
      @other: the DirectShapeTypeOptions object to be compared.
      Returns: True if both objects specify the same options.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValid()
      Description: Determines whether a DirectShapeTypeOptions is internally consistent (valid).

--------------------------------------------------------------------------------

[ENUM] DirectShapeTypeUserAssignability
Full Name: Autodesk.Revit.DB.DirectShapeTypeUserAssignability
Description: Options for a DirectShapeType which affect whether or not it can be assigned as the type of a DirectShape.
Remarks: Only DirectShapeTypes which permit assignability will be shown in the type selector dialog. A DirectShape which uses a DirectShapeType which is not assignable can be copied.
Inherits: Enum

  Values:
    - Assignable = 0
    - Nonassignable = 1

--------------------------------------------------------------------------------

[CLASS] DisableAnalyticalModelCB
Full Name: Autodesk.Revit.DB.DisableAnalyticalModelCB
Description: Disable the analytical model for a structural wall.
Inherits: FailureResolution

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DisciplineTypeId
Full Name: Autodesk.Revit.DB.DisciplineTypeId
Description: This class contains constants identifying disciplines.

  PROPERTIES:
    static ForgeTypeId Architecture { get; }
      Description: Architecture.
    static ForgeTypeId Common { get; }
      Description: Common.
    static ForgeTypeId Electrical { get; }
      Description: Electrical.
    static ForgeTypeId Energy { get; }
      Description: Energy.
    static ForgeTypeId Hvac { get; }
      Description: HVAC.
    static ForgeTypeId Infrastructure { get; }
      Description: Infrastructure.
    static ForgeTypeId Piping { get; }
      Description: Piping.
    static ForgeTypeId Structural { get; }
      Description: Structural.

--------------------------------------------------------------------------------

[CLASS] DisplacementElement
Full Name: Autodesk.Revit.DB.DisplacementElement
Description: A view-specific element that causes other elements to appear to be displaced from their actual locations.
Remarks: The DisplacementElement does not actually change the location of any model elements; it merely causes them to be displayed in a different location. An element may only be displaced by a single DisplacementElement in any view. Assigning an element to more than one DisplacementElement is an error condition. A DisplacementElement can declare another DisplacementElement as its parent. In that case, its transform will be concatenated with that of the parent, and the displacement of its associated elements will be relative to the parent DisplacementElement.
Inherits: Element

  PROPERTIES:
    ElementId ParentId { get; }
      Description: The element id of the parent DisplacementElement. This DisplacementElement's relative transform will be concatenated with the absolute transform of its parent.

  METHODS:
    static bool CanCategoryBeDisplaced(ElementId categoryId)
      Description: Indicates whether elements of the specified category are eligible as displaced elements.
      @categoryId: Category id of element to be replaced.
      Returns: Returns true if elements of this category can be displaced, and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanElementsBeAddedToDisplacementSet(ICollection<ElementId> toDisplace)
      Description: Indicates if these elements can be displaced by this DisplacementElement.
      @toDisplace: The elements to displace.
      Returns: True if the elements can be displaced by this DisplacementElement.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CanElementsBeDisplaced(View view, ICollection<ElementId> elementIds)
      Description: Indicates if elements can be assigned to a new DisplacementElement.
      @view: The view.
      @elementIds: The element ids.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CanElementsBeDisplaced(View view, ICollection<ElementId> elementIds, out ElementId commonDisplacedElementId)
      Description: Indicates if elements can be assigned to a new DisplacementElement.
      @view: The view.
      @elementIds: The element ids.
      @commonDisplacedElementId: If this method returns true, then this is the element id of a DisplacementElement which lists all of elemIds among its displaced elements.
      Returns: Returns true if the specified element ids can be assigned to a new DisplacementElement.
      Throws ArgumentNullException: A non-optional argument was null
    static DisplacementElement Create(Document document, ICollection<ElementId> elementsToDisplace, XYZ displacement, View ownerDBView, DisplacementElement parentDisplacementElement)
      Description: Creates a new DisplacementElement as a child of the specified parent DisplacementElement.
      @document: The Document
      @elementsToDisplace: The elements to be displaced.
      @displacement: The translation to be applied to the graphics of the displaced elements.
      @ownerDBView: The 3D view which will own the DisplacementElement.
      @parentDisplacementElement: An existing DisplacementElement that will be the parent of the one being created. It must be owned by ownerDBView. The relative transform of new DisplacementElement will be concatenated with the absolute transform of the parent DisplacementElement. If the elements specified by displacedElemIds are already displaced by another DisplacementElement, then this must be that element.
      Returns: The id of the new DisplacementElement.
      Throws ArgumentException: #elementIds# contains no element ids. -or- ownerDBView is not a 3D view. -or- For each individual element in the set elementsToDisplace, isAllowedAsDisplacedElement must return true, and the elements must either not already be displaced in the specified view, or else they must all be displaced by the same displacement element in the view. -or- The DisplacementElement parentDisplacementElement in not owned by the view ownerDBView.
      Throws ArgumentNullException: A non-optional argument was null
    XYZ GetAbsoluteDisplacement()
      Description: The absolute displacement applied to the displaced elements.
      Returns: The absolute displacement.
    static ICollection<ElementId> GetAdditionalElementsToDisplace(Document document, View view, ElementId idToDisplace)
      Description: Identify a set of elements that potentially should be displaced along with a given element.
      @document: the document
      @view: the view
      @idToDisplace: element id of element to displace
      Throws ArgumentNullException: A non-optional argument was null
    IList<DisplacementElement> GetChildren()
      Description: Returns a set of DisplacementElements which have this DisplacementElement as a parent.
      Returns: The returned array is sorted by element id.
    ICollection<ElementId> GetDisplacedElementIds()
      Description: The ids of the elements affected by this DisplacementElement.
      Returns: The element ids.
    static ICollection<ElementId> GetDisplacedElementIds(View view)
      Description: Returns the element ids of all displaced elements in the specified view.
      @view: The view.
      Returns: The element ids.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<ElementId> GetDisplacedElementIdsFromAllChildren()
      Description: The element ids of elements displaced by this DisplacementElement and any DisplacementElement which declare this one as parent.
      Returns: The element ids.
    static ElementId GetDisplacementElementId(View view, ElementId id)
      Description: The element id of the DisplacementElement that includes the specified element.
      @view: The view.
      @id: The element id.
      Returns: The element id of DisplacementElement that includes the specified element id.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetDisplacementElementIds(View view)
      Description: The element ids of all DisplacementElements owned by the specified view.
      @view: The view.
      Returns: The element ids.
      Throws ArgumentNullException: A non-optional argument was null
    XYZ GetRelativeDisplacement()
      Description: The relative displacement applied to the displaced elements by this DisplacementElement.
      Returns: The relative displacement.
    static bool IsAllowedAsDisplacedElement(Element element)
      Description: Indicates if the specified element is allowed to be displaced.
      @element: Any element.
      Returns: Returns true if the element is eligible to be assigned to a DisplacementElement.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsElementDisplacedInView(View view, ElementId id)
      Description: Indicates if the specified element displaced in the specified View.
      @view: The view.
      @id: The element id.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsNotEmpty(ICollection<ElementId> elementIds)
      Description: Validates that the input set of element ids is valid for a DisplacementElement.
      @elementIds: A set of element ids.
      Returns: True if the set of element ids is not empty.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidAsParentInView(View view, DisplacementElement parent)
      Description: Indicates whether the specified DisplacementElement can be used as a parent when creating a DisplacementElement in the specified view.
      @view: A view.
      @parent: A DisplacementElement.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveDisplacedElement(Element ElemToRemove)
      Description: Remove a displaced element from this DisplacementElement.
      @ElemToRemove: The element to remove.
      Throws ArgumentNullException: A non-optional argument was null
    void ResetDisplacedElements()
      Description: Sets the translation of the DisplacementElement to (0, 0, 0). The DisplacementElement continues to exist, but its elements are displayed in their actual location.
    void SetDisplacedElementIds(ICollection<ElementId> displacedElemIds)
      Description: Sets the ids of the elements affected by this DisplacementElement.
      @displacedElemIds: Set of ids of elements to be displaced by this DisplacementElement.
      Throws ArgumentException: For each individual element in the set displacedElemIds, isAllowedAsDisplacedElement must return true, and the elements must not already be displaced in the specified view.
      Throws ArgumentNullException: A non-optional argument was null
    void SetRelativeDisplacement(XYZ displacement)
      Description: Sets the relative displacement applied to the displaced elements by this DisplacementElement.
      @displacement: The relative displacement.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DisplacementPath
Full Name: Autodesk.Revit.DB.DisplacementPath
Description: A view-specific annotation related to a DisplacementElement.
Remarks: The DisplacementPath is anchored to the DisplacementElement by a reference to a point on an edge of a source element of the DisplacementElement. It is represented by a single line, or a series of jogged lines, originating at the specified point on the displaced element. The associated DisplacementElement may have a parent DisplacementElement and this parent may have its own parent DisplacementElement, producing a series of ancestors. The terminal point may be the point's original (un-displaced) location, or the corresponding point on any of the intermediate displaced locations corresponding to these ancestor DisplacementElements.
Inherits: Element

  PROPERTIES:
    int AncestorIdx { get; set; }
      Description: Specifies the end point of the path.
    DisplacementPathStyle PathStyle { get; set; }
      Description: Specifies the style of the path.

  METHODS:
    static ElementId Create(Document aDoc, DisplacementElement displacementElement, Reference reference, double param)
      Description: Creates a new DisplacementPath referencing a DisplacementElement and edge or curve and adds it to the document.
      @aDoc: The document.
      @displacementElement: Element id of a DisplacementElement
      @reference: A reference that refers to an edge or curve of one of the elements displaced by the displacementElement.
      @param: A value in the range [0,1]. It will be interpreted as a parameter for the specified edge.
      Returns: The element id of the newly created DisplacementPath.
      Throws ArgumentException: The value param should lie in the range [0,1]. -or- reference does not represent an edge or curve belonging to an element displaced by displacementElement.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidParam(double param)
      Description: Is the specified value a valid edge or curve parameter.
      @param: proposed edge parameter.
    static bool IsValidReference(DisplacementElement displacementElement, Reference reference)
      Description: Does the specified pick represent an edge or a curve belonging to one of the displaced elements.
      @displacementElement: A DisplacementElement.
      @reference: A pick.
      Throws ArgumentNullException: A non-optional argument was null
    void SetAnchorPoint(DisplacementElement displacementElement, Reference reference, double param)
      Description: Sets the reference that determines the origin of this DisplacementPath.
      @displacementElement: The element id of a DisplacementElement.
      @reference: A reference of an edge or a curve in the GRep of the element corresponding to elemId.
      @param: An parameter used to specify a point on the edge.
      Throws ArgumentException: The value param should lie in the range [0,1]. -or- reference does not represent an edge or curve belonging to an element displaced by displacementElement.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DisplacementPathStyle
Full Name: Autodesk.Revit.DB.DisplacementPathStyle
Description: Used to control the graphical representation of a DisplacementPath element.
Inherits: Enum

  Values:
    - Straight = 0
    - Jogged = 1

--------------------------------------------------------------------------------

[ENUM] DisplayStyle
Full Name: Autodesk.Revit.DB.DisplayStyle
Description: Display type of the view.
Inherits: Enum

  Values:
    - Undefined = 0
    - Wireframe = 1
    - HLR = 2
    - Shading = 3
    - ShadingWithEdges = 4
    - Rendering = 5
    - Realistic = 6
    - FlatColors = 7
    - RealisticWithEdges = 8
    - Textures = 9

--------------------------------------------------------------------------------

[ENUM] DisplayUnit
Full Name: Autodesk.Revit.DB.DisplayUnit
Description: Describes the type of Revit display unit, metric or imperial.
Inherits: Enum

  Values:
    - METRIC = 0
    - IMPERIAL = 1

--------------------------------------------------------------------------------

[ENUM] DistanceMeasuredFrom
Full Name: Autodesk.Revit.DB.DistanceMeasuredFrom
Description: Indicates if the distance is measured from the top or bottom of the wall.
Inherits: Enum

  Values:
    - Base = 0
    - Top = 1

--------------------------------------------------------------------------------

[ENUM] DistributionOfNormals
Full Name: Autodesk.Revit.DB.DistributionOfNormals
Description: An enumeration containing the choices of how normal vectors are assigned and distributed along the surface of a polymesh. Planar faces would typically have only normal vector associated, but curved faces can have a different normal either for each facet (triangle) or each point of the tessellated polymesh.
Inherits: Enum

  Values:
    - AtEachPoint = 0
    - OnePerFace = 1
    - OnEachFacet = 2

--------------------------------------------------------------------------------

[CLASS] DividedPath
Full Name: Autodesk.Revit.DB.DividedPath
Description: An element that consists of a set of points distributed along a path which consists of a connected set of curves and edges.
Remarks: The points can be the result of a uniform distribution along the path. The type of the distribution is determined by a selected 'layout'. The distance between the layout points depends on the path, the layout, and layout specific settings. In addition, points can also be the result of intersecting the path with other elements.
Inherits: Element

  PROPERTIES:
    double BeginningIndent { get; set; }
      Description: The beginningIndent is an offset distance from the beginning of the first curve that determines the beginning of the range over which the layout is applied. The measurement type determines how the distance is measured.
    bool DisplayNodeNumbers { get; set; }
      Description: Controls whether the node numbers are shown when the divided path is selected
    bool DisplayNodes { get; set; }
      Description: Controls whether the points of the divided path are visible
    bool DisplayReferenceCurves { get; set; }
      Description: Controls whether the curves in the path are visible
    double Distance { get; set; }
      Description: The distance between points that are distributed along the path according to the selected layout. When the layout is set to 'FixedDistance' this value can be set to desired distance. The measurement type determines how the distance is measured.
    double EndIndent { get; set; }
      Description: The endIndent is an offset distance from the end of the last curve that determines the end of the range over which the layout is applied. The measurement type determines how the distance is measured.
    int FixedNumberOfPoints { get; set; }
      Description: The number of points used when the layout is set to 'FixedNumber'.
    bool Flipped { get; }
      Description: If the divided path is flipped the nodes are numbered in the reverse order. It also switches the ends from which beginningIndent and endIndent are measured from.
    bool IsClosedLoop { get; }
      Description: Whether or not the path forms a closed loop.
    bool IsCyclical { get; }
      Description: True if the first and last point coincide False otherwise.
    double MaximumDistance { get; set; }
      Description: The maximum distance is used when the layout is set to 'MaximumSpacing'. When that layout rule is used the distance between points will not exceed this value. The measurement type determines how the distance is measured.
    DividedPathMeasurementType MeasurementType { get; set; }
      Description: The measurement type determines how distances are calculated. Either along a straight line between two points ('ChordLength') or along the segment of the path that connects them. ('SegmentLength').
    double MinimumDistance { get; set; }
      Description: The minimum distance is used when the layout is set to 'MinimumSpacing'. When that layout rule is used the distance between points will not fall below this value. The measurement type determines how the distance is measured.
    int NumberOfPoints { get; }
      Description: The total number of points of the divided surface. This combines the layout points and the intersection points.
    SpacingRuleJustification SpacingRuleJustification { get; set; }
      Description: When the layout is set to 'FixedDistance' the points may not cover the entire range of the path. The justification determines whether the points are centered on the range, or shifted towards the start or end of the range.
    SpacingRuleLayout SpacingRuleLayout { get; set; }
      Description: The layout determines how points are distributed along the path.
    double TotalPathLength { get; }
      Description: The sum of the curve lengths.

  METHODS:
    static bool AreCurveReferencesConnected(Document document, IList<Reference> curveReferences)
      Description: This checks if the references represent a connected set of curves as required by the divided path.
      @document: The document.
      @curveReferences: The references.
      Returns: True if the arguments passed the checks, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static DividedPath Create(Document document, IList<Reference> curveReferences, ICollection<ElementId> intersectors)
      Description: Creates a new instance of a divided path whose points are determined by the intersecting elements.
      @document: The document.
      @curveReferences: References that represent a connected set of curves or edges.
      @intersectors: Elements whose intersection with the curve references result in additional divisions.
      Returns: The newly created divided path.
      Throws ArgumentException: The document does not allow creation of a divided path. -or- Not all curve references in curveReferences represent a curve or an edge -or- The references in curveReferences are not connected. -or- Not all intersecting elements in intersectors are valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static DividedPath Create(Document document, IList<Reference> curveReferences)
      Description: Creates a new instance of a divided path with a default layout.
      @document: The document.
      @curveReferences: References that represent a connected set of curves or edges.
      Returns: The newly created divided path.
      Throws ArgumentException: The document does not allow creation of a divided path. -or- Not all curve references in curveReferences represent a curve or an edge -or- The references in curveReferences are not connected.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Flip()
      Description: Toggle the flipped value
    ICollection<ElementId> GetIntersectingElements()
      Description: Get the elements whose intersection with path produces points.
    static bool IsCurveReferenceValid(Document document, Reference curveReference)
      Description: This returns true if the reference represents a curve or edge that can be used to create a divided path.
      @document: The document.
      @curveReference: The reference.
      Returns: True if the reference can be used to create a divided path, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsIntersectorValidForCreation(Document document, ElementId intersector)
      Description: This returns true if the intersector is an element that can be used to intersect with a newly created divided path.
      @document: The document.
      @intersector: The intersector.
      Returns: True if the reference can be used to create a divided path, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsIntersectorValidForDividedPath(ElementId intersector)
      Description: This returns true if the intersector is an element that can be used to intersect with the divided path.
      @intersector: The intersector.
      Returns: True if the reference can be used to create a divided path, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidBeginningIndent(double beginningIndent)
      Description: Checks that the indent value does not cause the beginningIndent and endIndent to overlop
    bool IsValidEndIndent(double endIndent)
      Description: Checks that the indent value does not cause the beginningIndent and endIndent to overlop
    static bool IsValidFixedNumberOfPoints(int fixedNumberOfPoints)
      Description: Identifies if the indicated number of points is valid for assignment to a DividedPath with a layout type 'FixedNumber'.
    bool IsValidMeasurementType(DividedPathMeasurementType measurementType)
      Description: Checks that the measurement type enumeration value is valid
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidSpacingRuleJustification(SpacingRuleJustification justification)
      Description: Checks that the justification enumeration value is valid
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidSpacingRuleLayout(SpacingRuleLayout layout)
      Description: Checks that the spacing rule layout enumeration value is valid
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static IList<IList<Reference>> SeparateReferencesIntoConnectedReferences(Document document, IList<Reference> curveReferences)
      Description: This function separates the input curve references into groups of connected curve references. Each group of connected curve references can be used to create a divided path.
      @document: The document.
      @curveReferences: The references.
      Returns: The grouped references
      Throws ArgumentException: Not all curve references in curveReferences represent a curve or an edge
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: this operation failed.
    void SetIntersectingElements(ICollection<ElementId> intersectors)
      Description: Set the elements whose intersection with path produces points.
      Throws ArgumentException: Not all intersecting elements in intersectors are valid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DividedPathMeasurementType
Full Name: Autodesk.Revit.DB.DividedPathMeasurementType
Description: DividedPath measurement type.
Inherits: Enum

  Values:
    - ChordLength = 0
    - SegmentLength = 1

--------------------------------------------------------------------------------

[CLASS] DividedSurface
Full Name: Autodesk.Revit.DB.DividedSurface
Description: An element that represents a mesh on the surface of another element, a family instance, an import instance or a geometry combination, and a tile pattern built on that mesh.
Remarks: The type of this element may be set to: a TilePattern element, a FamilySymbol element from a Curtain Panel family.
Inherits: Element

  PROPERTIES:
    double AllGridRotation { get; set; }
      Description: Angle of rotation applied to the U- and V- directions together.
    BorderTile BorderTile { get; set; }
      Description: Determines the handling of tiles that overlap the surface's boundary.
    ComponentRotation ComponentRotation { get; set; }
      Description: The rotation of the pattern by a multiple of 90 degrees.
    Element Host { get; }
      Description: The element whose surface has been divided.
    Reference HostReference { get; }
      Description: A reference to the divided face on the host.
    bool IsComponentFlipped { get; set; }
      Description: Whether the pattern is flipped.
    bool IsComponentMirrored { get; set; }
      Description: Whether the pattern is mirror-imaged.
    int NumberOfUGridlines { get; }
      Description: Get the number of U-gridlines used on the surface.
    int NumberOfVGridlines { get; }
      Description: Get the number of V-gridlines used on the surface.
    int UPatternIndent { get; set; }
      Description: The offset applied to the pattern by an integral number of grid nodes in the U-direction.
    SpacingRule USpacingRule { get; }
      Description: Access to the rule for laying out the first series of equidistant parallel lines on the surface.
    int VPatternIndent { get; set; }
      Description: The offset applied to the pattern by an integral number of grid nodes in the V-direction.
    SpacingRule VSpacingRule { get; }
      Description: Access to the rule for laying out the second series of equidistant parallel lines on the surface.

  METHODS:
    void AddIntersectionElement(ElementId newIntersectionElemId)
      Description: Adds an intersection element to the divided surface.
      @newIntersectionElemId: The intersection element to be added.
      Throws ArgumentException: The element newIntersectionElemId is not a level, grid, reference plane, or a curve element whose category is lines and reference lines.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CanBeDivided(Document document, Reference reference)
      Description: This returns true if the reference represents a face that can be used to create a divided surface.
      @document: The document.
      @reference: The reference.
      Returns: True if the reference can be used to create a divided surface, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanBeIntersectionElement(ElementId id)
      Description: Checks if the element can be an intersection reference.
      @id: The element to be checked.
      Returns: True if the element can be an intersection reference., false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static DividedSurface Create(Document document, Reference faceReference)
      Description: Creates a new instance of a divided surface with a default layout.
      @document: The document.
      @faceReference: Reference that represents a face.
      Returns: The newly created divided surface.
      Throws ArgumentException: The document does not allow creation of a divided surface. -or- Reference is unstable import element -or- Reference does not represent a face -or- Reference already hosts a divided surface
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ICollection<ElementId> GetAllIntersectionElements()
      Description: Gets all intersection elements which produce division lines.
      Returns: The intersection elements.
    static DividedSurface GetDividedSurfaceForReference(Document document, Reference faceReference)
      Description: Get a divided surface for a given reference. Returns null if the reference does not host a divided surface.
      @document: The document.
      @faceReference: Reference that represents a face.
      Returns: The newly created divided surface.
      Throws ArgumentNullException: A non-optional argument was null
    GridNodeLocation GetGridNodeLocation(GridNode gridNode)
      Description: Specify whether a particular grid node is interior to the surface, on the boundary, or outside the boundary.
      Throws ArgumentOutOfRangeException: Thrown when the grid node indexes are outside the range [ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].
    Reference GetGridNodeReference(GridNode gridNode)
      Description: Get a reference to the geometric point associated with a grid node.
      Throws ArgumentOutOfRangeException: Thrown when the grid node indexes are outside the range [ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].
    UV GetGridNodeUV(GridNode gridNode)
      Description: Get the position of a grid node in UV coordinates in the surface.
      Throws ArgumentOutOfRangeException: Thrown when the grid node indexes are outside the range [ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].
    Reference GetGridSegmentReference(GridNode gridNode, GridSegmentDirection gridSegmentDirection)
      Description: Get a reference to a line segment connecting two adjacent grid nodes.
      Throws ArgumentOutOfRangeException: Thrown when the grid node indexes are outside the range [ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ], or when the adjacent grid node specified by gridSegmentDirection is out of range.
    static IList<Reference> GetReferencesWithDividedSurfaces(Element host)
      Description: For a given host element get references to all the faces that host a divided surface
      @host: The element that hosts the divided surfaces
      Returns: References that host a divided surface
      Throws ArgumentNullException: A non-optional argument was null
    FamilyInstance GetTileFamilyInstance(GridNode gridNode, int tileIndex)
      Description: Get a reference to a tile element associated with a given seed node.
      Returns: A FamilyInstance object. Returns if the ObjectType property is not a FamilySymbol. Returns if the grid node is not a "seed node", or if the tile is omitted due to boundary conditions.
      Throws ArgumentOutOfRangeException: Thrown if the grid node is outside of the range specified by NumberOfUGridlines and NumberOfVGridlines, or if tileIndex is outside the range [0, TilesPerSeedNode-1].
    Reference GetTileReference(GridNode gridNode, int tileIndex)
      Description: Get a reference to one of the tile surfaces associated with a given seed node.
      @tileIndex: An integer between 0 and T-1, where T is TilesPerSeedNode.
      Returns: A reference to a Face (surface). Returns if the grid node is not a "seed node", or if the tile is omitted due to boundary conditions.
      Throws ArgumentOutOfRangeException: Thrown if the grid node is outside of the range specified by NumberOfUGridlines and NumberOfVGridlines, or if tileIndex is outside the range [0, TilesPerSeedNode-1].
    bool IsSeedNode(GridNode gridNode)
      Description: Reports whether a grid node is a "seed node," a node that is associated with one or more tiles.
      Throws ArgumentOutOfRangeException: Thrown when the grid node indexes are outside the range [ 0, NumberOfUGridlines - 1 ], [ 0, NumberOfVGridlines - 1 ].
    void RemoveAllIntersectionElements()
      Description: Removes all the intersection elements from a divided surface.
    void RemoveIntersectionElement(ElementId referenceElemIdToRemove)
      Description: Removes an intersection element from a divided surface.
      @referenceElemIdToRemove: The intersection element to be removed.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Document
Full Name: Autodesk.Revit.DB.Document
Description: An object that represents an open Autodesk Revit project.
Remarks: The Document object represents an Autodesk Revit project. Revit can have multiple projects open and multiple views to those projects. The active or top most view will be the active project and hence the active document which is available from the Application object.
Implements: IDisposable

  PROPERTIES:
    ProjectLocation ActiveProjectLocation { get; set; }
      Description: Retrieve the active project location.
    View ActiveView { get; }
      Description: The document's active view.
    Application Application { get; }
      Description: Returns the Application in which the Document resides.
    Document Create { get; }
      Description: An object that can be used to create new instances of Autodesk Revit API elements within a project.
    Guid CreationGUID { get; }
      Description: A unique identifier generated when the Document was first created.
    DisplayUnit DisplayUnitSystem { get; }
      Description: Provides access to display unit type with in the document.
    FamilyItemFactory FamilyCreate { get; }
      Description: An object that can be used to create new instances of Autodesk Revit API elements within a family document.
    FamilyManager FamilyManager { get; }
      Description: The family manager object provides access to family types and parameters.
    bool IsDetached { get; }
      Description: Identifies if a workshared document is detached. Also, see IsWorkshared
    bool IsFamilyDocument { get; }
      Description: Identifies if the current document is a family document.
    bool IsLinked { get; }
      Description: Identifies if a document is a linked RVT.
    bool IsModelInCloud { get; }
      Description: Identifies if document is stored on Autodesk cloud services.
    bool IsModifiable { get; }
      Description: Identifies if the document is modifiable.
    bool IsModified { get; }
      Description: The state of changes made to the document.
    bool IsReadOnly { get; }
      Description: Identifies if the document is read-only or can possibly be modified.
    bool IsReadOnlyFile { get; }
      Description: Signals whether the document was opened from a read-only file.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsWorkshared { get; }
      Description: Identifies if worksharing (i.e. editing permissions and multiple worksets) have been enabled in the document. Also, see IsDetached
    MassDisplayTemporaryOverrideType MassDisplayTemporaryOverride { get; set; }
      Description: This setting controls temporary display in views of objects with mass category or subcategories.
    MullionTypeSet MullionTypes { get; }
      Description: This property is used to retrieve all the mullion types in current system.
    Family OwnerFamily { get; }
      Description: Get the Family of this Family Document.
    PanelTypeSet PanelTypes { get; }
      Description: Retrieves a set of PanelType objects that contains all the panel types that are currently loaded into the project.
    BindingMap ParameterBindings { get; }
      Description: Retrieves an object from which mappings between parameter definitions and categories can be found.
    string PathName { get; }
      Description: The fully qualified path of the document's disk file.
    PhaseArray Phases { get; }
      Description: Retrieves all of the phases in the document.
    PlanTopologySet PlanTopologies { get; }
      Description: Get the PlanTopologies of the current project in the last phase.
    PlanTopologySet PlanTopologies { get; }
      Description: Get the PlanTopologies of the current project in the last phase.
    PlanTopology PlanTopology { get; }
    PlanTopology PlanTopology { get; }
    PrintManager PrintManager { get; }
      Description: Retrieve the PrintManager of current project.
    ProjectInfo ProjectInformation { get; }
      Description: Return the Project Information of the current project.
    ProjectLocationSet ProjectLocations { get; }
      Description: Retrieve all the project locations associated with this project
    bool ReactionsAreUpToDate { get; }
      Description: Reports if the analytical model has regenerated in a document with reaction loads.
    Settings Settings { get; }
      Description: Provides access to general application settings, such as Categories.
    SiteLocation SiteLocation { get; }
      Description: Returns the site location information.
    string Title { get; }
      Description: The document's title.
    StorageType TypeOfStorage { get; }
    Guid WorksharingCentralGUID { get; }
      Description: The central GUID of the server-based model.

  METHODS:
    void AcquireCoordinates(ElementId linkInstanceId)
      Description: Acquires coordinates from the specified link instance.
      @linkInstanceId: The ElementId of the link instance (such as RevitLinkInstance or ImportInstance) from which the coordinates would be acquired.
      Throws ArgumentException: The element linkInstanceId does not exist in the document
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This Document is not a project document. -or- This Document is in an edit mode. -or- The coordinate system of the selected model are the same as the host model. -or- Cannot acquire coordinates from a model placed multiple times. -or- Failed to acquire coordinates from the link instance.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void AutoJoinElements()
      Description: Forces the elements in the Revit document to automatically join to their neighbors where appropriate.
      Throws AutoJoinFailedException: Thrown when the operation fails.
    bool CanEnableCloudWorksharing()
      Description: Checks if cloud worksharing can be enabled for the cloud model.
      Returns: True if cloud worksharing can be enabled in the document, which also means the current document is a single user cloud model, False otherwise.
    bool CanEnableWorksharing()
      Description: Checks if worksharing can be enabled in the document.
      Returns: True if worksharing can be enabled in the document, False otherwise.
    bool Close()
      Description: Closes the document, save the changes if there are.
      Returns: False if either closing procedure fails or if saving of a modified document failed. Also returns False if closing is cancelled by an external application during 'DocumentClosing' event. When function succeeds, True is returned.
      Throws InvalidOperationException: Thrown when attempting to close the currently active document. Thrown if there are any transactions, sub-transactions or transaction groups which were opened by the API code, and not closed. All of these items must be handled before attempting to close the document. Thrown if the PathName is not set yet. Thrown if the saving target file is read only.
      Throws InvalidOperationException: Thrown if this a linked file.
    bool Close(bool saveModified)
      Description: Closes the document with the option to save.
      @saveModified: Indicates if the current document should be saved before close operation.
      Returns: False if closing procedure fails or if saving of a modified document was requested (saveModified = True) but failed. Also returns False if closing is cancelled by an external application during 'DocumentClosing' event. When function succeeds, True is returned.
      Throws InvalidOperationException: Thrown when attempting to close the currently active document. Thrown if there are any transactions, sub-transactions or transaction groups which were opened by the API code, and not closed. All of these items must be handled before attempting to close the document. Thrown if saveModified is 'true' and the PathName is not set yet. Thrown if saveModified is 'true' and the saving target file is read only.
      Throws InvalidOperationException: Thrown if this a linked file.
    GeomCombination CombineElements(CombinableElementArray members)
      Description: Combine a set of combinable elements into a geometry combination.
      @members: A list of combinable elements to be combined.
      Returns: If successful, the newly created geometry combination is returned, otherwise an exception with error information will be thrown.
      Throws ArgumentNullException: Thrown when the input argument is .
      Throws ArgumentException: Thrown when members contains less than two elements. Thrown when members contains elements.
      Throws InvalidOperationException: Thrown when creation of the combination failed.
    ModelCurveArray ConvertDetailToModelCurves(View view, DetailCurveArray detailCurves)
      Description: Converts a group of DetailCurves to equivalent ModelCurves.
      @view: The view where the new lines will be created. The lines are projected on the view workplane. The view workplane must be parallel to the view plane.
      @detailCurves: The detail curve array to be converted.
      Throws ArgumentNullException: Thrown when the input argument is .
      Throws ArgumentException: Thrown when the given detail lines are not visible in the given view. Thrown when the detail lines are not in the same view or not parallel to the given view.
      Throws InvalidOperationException: Thrown when one or more curves could not be successfully converted.
    DetailCurveArray ConvertModelToDetailCurves(View view, ModelCurveArray modelCurves)
      Description: Converts a group of ModelCurves to equivalent DetailCurves.
      @view: The view where the new lines will be created. The lines are projected on the view plane. If the lines are not parallel to the view plane, lines are foreshortened and arcs are converted to ellipses. Splines are modified.
      @modelCurves: The model curve array to be converted.
      Throws ArgumentNullException: Thrown when the input argument is .
      Throws ArgumentException: Thrown when view is invalid to create DetailCurves on it.
      Throws InvalidOperationException: Thrown when current document is a family. Thrown when one or more curves could not be successfully converted, perhaps because some of the input curves could not be projected onto the active workplane of the view.
    SymbolicCurveArray ConvertModelToSymbolicCurves(View view, ModelCurveArray modelCurves)
      Description: Converts a group of ModelCurves to equivalent SymbolicCurves.
      @view: The view where the new lines will be created. The lines are projected on the view workplane. The view workplane must be parallel to the view plane. If the lines are not parallel to the view plane, lines are foreshortened and arcs are converted to ellipses. Splines are modified.
      @modelCurves: The model curve array to be converted.
      Throws ArgumentNullException: Thrown when the input argument is .
      Throws ArgumentException: Thrown when view is invalid to create SymbolicCurves on it.
      Throws InvalidOperationException: Thrown when current document is a family. Thrown when one or more curves could not be successfully converted, perhaps because some of the input curves could not be projected onto the active workplane of the view.
    ModelCurveArray ConvertSymbolicToModelCurves(View view, SymbolicCurveArray symbolicCurve)
      Description: Converts a group of SymbolicCurves to equivalent ModelCurves.
      @view: The view where the new lines will be created. The lines are projected on the view workplane. The view workplane must be parallel to the view plane.
      @symbolicCurve: The symbolic curve array to be converted.
      Throws ArgumentNullException: Thrown when the input argument is .
      Throws InvalidOperationException: Thrown when one or more curves could not be successfully converted.
    ICollection<ElementId> Delete(ICollection<ElementId> elementIds)
      Description: Deletes a set of elements from the document.
      @elementIds: The ids of the elements to delete.
      Returns: The deleted element id set.
      Throws ArgumentException: One or more elements in elementIds do not exist in the document. -or- One or more of the elementIds cannot be deleted.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ICollection<ElementId> Delete(ElementId elementId)
      Description: Deletes an element from the document given the id of that element.
      @elementId: Id of the element to delete.
      Returns: The deleted element id set.
      Throws ArgumentException: The element elementId does not exist in the document -or- ElementId cannot be deleted.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Dispose()
    Document EditFamily(Family loadedFamily)
      Description: Gets the document of a loaded family to edit.
      @loadedFamily: The loaded family in current document.
      Returns: Reference of the document of the family.
      Throws ArgumentNullException: Thrown when the input argument-"loadedFamily"-is .
      Throws ArgumentException: Thrown when the input argument-"loadedFamily"-is an in-place family or a non-editable family. (This can be checked with the IsInPlace and IsEditable properties of the Family class.
      Throws InvalidOperationException: Thrown when the family is already being edited.
      Throws ForbiddenForDynamicUpdateException: Thrown if this method is called during dynamic update.
      Throws InvalidOperationException: Thrown if this method is called while the document is modifiable (i.e. it has an unfinished transaction.)
      Throws InvalidOperationException: Thrown if this method is currently in a read-only state.
    void EnableCloudWorksharing()
      Description: Enables cloud worksharing for a cloud model
      Throws CentralModelAccessDeniedException: Access to the cloud model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is locked by another client.
      Throws CentralModelException: The model in cloud is missing. -or- The model in cloud is incompatible. -or- The model in cloud is corrupt or not an RVT file. -or- The model in cloud was rolled back. -or- An internal error happened on the model in cloud , please contact the administrator.
      Throws FileNotFoundException: Cannot access the local cache.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- This Document is read-only: It cannot be modified. -or- This Document has an open editing transaction and is accepting changes. -or- This Document is not a project document. -or- This Document is in an edit mode. -or- Saving is not allowed in the current application mode. -or- This Document does not have a central location: Worksharing needs to be enabled and central model saved. -or- The file is read-only, can not be saved. -or- The cloud model does not allow cloud worksharing to be enabled. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws RevitServerCommunicationException: Could be for any of the reasons related to network.
      Throws RevitServerInternalException: Could be for any of the reasons that conversion fails with RevitServerInternalException.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: You do not have workshared cloud model entitlement to access this resource in cloud -or- User is not authorized to access the specified cloud project.
    void EnableWorksharing(string worksetNameGridLevel, string worksetName)
      Description: Enables worksharing in the document.
      @worksetNameGridLevel: Name of workset for grids and levels.
      @worksetName: Name of workset for all other elements.
      Throws ArgumentException: worksetNameGridLevel is an empty string. -or- worksetName is an empty string. -or- worksetNameGridLevel cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- worksetName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: The document does not allow worksharing to be enabled. -or- This Document is in an edit mode. -or- This Document is a workshared document. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.
      Throws OperationCanceledException: Enabling worksharing was cancelled.
    bool Equals(object obj)
      Description: Determines whether the specified Object equals to this Object.
    void EraseSchemaAndAllEntities(Schema schema)
      Description: Erases Schema and all its Entities from the document.
      @schema: The Schema to erase.
      Throws ArgumentException: No write access to this Schema.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    bool Export(string folder, string name, GBXMLExportOptions options)
      Description: Export the model in gbXML (green-building) format.
      @folder: Indicates the path of a folder where to export the gbXML file.
      @name: Indicates the name of the gbXML file to export. If it doesn't end with ".xml", extension ".xml" will be added automatically. The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.
      @options: Options which control the contents of the export.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: The path is not valid for exporting gbXML files. -or- The name is empty or not valid for exporting gbXML files.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This Document is not a project document. -or- This Document is in an edit mode. -or- Exporting is not allowed in the current application mode. -or- Export is temporarily disabled. -or- There is no EnergyAnalysisDetailModel in the document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    bool Export(string folder, IList<ElementId> viewIds, PDFExportOptions options)
      Description: Exports a selection of views in PDF format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @viewIds: Selection of ordered views to be exported. The list must contain at least one valid view.
      @options: Various options applicable to the PDF format.
      Returns: True if all specified views are exported successfully, False if exporting of any view fails, even if some views might have been exported successfully.
      Throws ArgumentException: non empty list of views must be provided. -or- NullOrEmpty -or- There are duplicate views in viewIds -or- some of the views are not printable (exportable). -or- Thrown when one or more input arguments are invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: Thrown when the target PDF file is inaccessible, e.g. already opened.
      Throws InvalidOperationException: "Running background tasks is disabled when DisableBackgroundProcesses is set in Revit.ini." -or- "A background process is already running in this document." -or- "The maximum number of background processes (3) has been reached." -or- Cannot export PDF in the background while in edit mode. -or- Running background tasks is not allowed in a Family document. -or- Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
    void Export(string folder, string name, NavisworksExportOptions options)
      Description: Exports a Revit project to the Navisworks .nwc format.
      @folder: The name of the folder for the exported file.
      @name: The name of the exported file. If it doesn't end in '.nwc', this extension will be added automatically.
      @options: Options which control the contents of the export.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- The input options were not valid. Check the exception message for specific details.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OperationCanceledException: The export operation is cancelled in event handler.
      Throws OptionalFunctionalityNotAvailableException: A Navisworks Exporter is not available in the installed Revit.
    bool Export(string folder, string name, STLExportOptions options)
      Description: Exports a view specified in the export options to the STL format.
      @folder: Output folder into which the file will be exported. The folder must exist.
      @name: Indicates the name of the STL file to export. If it doesn't end with ".stl", this extension will be added automatically. The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.
      @options: Various options applicable to the STL format.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- The provided options do not specify a printable 3D view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.
    bool Export(string folder, string name, STEPExportOptions options)
      Description: Exports the current view or a selection of views in STEP format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If empty, automatic naming will be used.
      @options: Various options applicable to the STEP format.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- The provided options do not specify a printable 3D view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.
    bool Export(string folder, string name, OBJExportOptions options)
      Description: Exports a view specified in the export options to the OBJ format.
      @folder: Output folder into which the file will be exported. The folder must exist.
      @name: Indicates the name of the OBJ file to export. If it doesn't end with ".obj", this extension will be added automatically. The name cannot contain any of the following characters: \/:*?"<>|. Empty name is not acceptable.
      @options: Various options applicable to the OBJ format.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- The provided options do not specify a printable 3D view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.
    bool Export(string folder, string name, IFCExportOptions options)
      Description: Exports the document to the Industry Standard Classes (IFC) format.
      @folder: Output folder into which the file will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If empty, automatic naming will be used.
      @options: Various options applicable to the IFC format. If , all options will be set to their respective default values.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The IFCExportOptions FamilyMappingFile does not exist.
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode. -or- This Document is in an edit mode. -or- This Document is not a project document.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The IFC module is not available in the installed Revit.
    bool Export(string folder, string name, ICollection<ElementId> views, SATExportOptions options)
      Description: Exports the current view or a selection of views in SAT format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If empty, automatic naming will be used.
      @views: Selection of views to be exported. The set must contain at least one valid view.
      @options: Various options applicable to the SAT format. For now, this option is empty. If , all options will be set to their respective default values.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- non empty list of views must be provided. -or- At least one provided viewId does not correspond to a printable 3D view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws DirectoryNotFoundException: Thrown when the directory does not exist.
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The ShapeExporter functionality is not available in the installed Revit, or the Material Library is missing.
    bool Export(string folder, string name, ICollection<ElementId> views, DGNExportOptions options)
      Description: Exports a selection of views in DGN format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If empty, automatic naming will be used. If , throw ArgumentException.
      @views: Selection of views to be exported. The set must contain at least one valid view.
      @options: Various options applicable to the DGN format. If , all options will be set to their respective default values.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- non empty list of views must be provided. -or- some of the views are not printable (exportable). -or- Thrown when the options in DGNExportOptions is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws DirectoryNotFoundException: Thrown when the directory does not exist.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The DWG module is not available in the installed Revit. -or- The Graphics module is not available in the installed Revit.
    bool Export(string folder, string name, ICollection<ElementId> views, DXFExportOptions options)
      Description: Exports a selection of views in DXF format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If empty, automatic naming will be used.
      @views: Selection of views to be exported. The set must contain at least one valid view.
      @options: Various options applicable to the DXF format. If , all options will be set to their respective default values.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- non empty list of views must be provided. -or- some of the views are not printable (exportable). -or- Thrown when the options in DWGExportOptions is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws DirectoryNotFoundException: Thrown when the directory does not exist.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The DXF module is not available in the installed Revit. -or- The Graphics module is not available in the installed Revit.
    bool Export(string folder, string name, ICollection<ElementId> views, DWGExportOptions options)
      Description: Exports a selection of views in DWG format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If empty, automatic naming will be used. If , throw ArgumentException.
      @views: Selection of views to be exported. The set must contain at least one valid view.
      @options: Various options applicable to the DWG format. If , all options will be set to their respective default values.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters. -or- non empty list of views must be provided. -or- some of the views are not printable (exportable). -or- The modifiers set in layer info must be valid. -or- Thrown when the options in DWGExportOptions is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws DirectoryNotFoundException: Thrown when the directory does not exist.
      Throws InvalidOperationException: Export is temporarily disabled. -or- Exporting is not allowed in the current application mode.
      Throws InvalidPathArgumentException: The folder does not exist.
      Throws OptionalFunctionalityNotAvailableException: The DWG module is not available in the installed Revit. -or- The Graphics module is not available in the installed Revit.
    bool Export(string folder, string name, ViewSet views, FBXExportOptions options)
      Description: Exports the document in 3D-Studio Max (FBX) format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If or empty, automatic naming will be used.
      @views: Selection of views to be exported.Only 3D views are allowed.
      @options: Options applicable to the FBX format.
      Returns: Function returns true only if all specified views are exported successfully. The function returns False if exporting of any view fails, even if some views might have been exported successfully.
      Throws ArgumentNullException: Thrown when the input views is
      Throws ArgumentException: Thrown when the input views is an empty ViewSet. Thrown if any view in the views is not a 3D view.
    bool Export(string folder, string name, ViewSet views, DWFXExportOptions options)
      Description: Exports the current view or a selection of views in DWFX format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If or empty, automatic naming will be used.
      @views: Selection of views to be exported.
      @options: Various options applicable to the DWFX format. If , all options will be set to their respective default values.
      Returns: Function returns true only if all specified views are exported successfully. The function returns False if exporting of any view fails, even if some views might have been exported successfully.
      Throws ArgumentNullException: Thrown when the input views is
      Throws ArgumentException: Thrown when the input views is an empty ViewSet.
      Throws InvalidOperationException: Thrown when the current document is not modifiable.
    bool Export(string folder, string name, ViewSet views, DWFExportOptions options)
      Description: Exports the current view or a selection of views in DWF format.
      @folder: Output folder, into which file(s) will be exported. The folder must exist.
      @name: Either the name of a single file or a prefix for a set of files. If or empty, automatic naming will be used.
      @views: Selection of views to be exported.
      @options: Various options applicable to the DWF format. If , all options will be set to their respective default values.
      Returns: Function returns true only if all specified views are exported successfully. Returns False if exporting of any view fails, even if some views might have been exported successfully.
      Throws ArgumentNullException: Thrown when the input views is
      Throws ArgumentException: Thrown when the input views is an empty ViewSet.
      Throws InvalidOperationException: Thrown when the current document is not modifiable.
    void ExportImage(ImageExportOptions options)
      Description: Exports a view or set of views into an image file.
      @options: The options which govern the image export.
      Throws ArgumentException: The current view cannot be exported as an image
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The path indicated could not be accessed.
      Throws FileNotFoundException: The path indicated could not be found.
      Throws InvalidOperationException: Exporting is not allowed in the current application mode. -or- Failed to export image due to an error with the inputs. -or- Failed to export image due to an issue where the DirectX Device was lost.
      Throws OptionalFunctionalityNotAvailableException: The Graphics module is not available in the installed Revit.
    EditModeType GetActiveEditMode()
      Description: Returns the document's active edit mode. Returns None if no edit mode is currently active.
    ISet<ElementId> GetAllUnusedElements(ISet<ElementId> categories)
      Description: Returns the list of element ids that are not used. The list of unused element ids may include elements that can't be deleted.
      @categories: Collection of categories to check for unused elements.
      Returns: Unused element ids.
      Throws ArgumentNullException: A non-optional argument was null
    DocumentDifference GetChangedElements(Guid baseVersionGUID)
      Description: Extracts a collection containing the ids of elements that have been created, modified or deleted between the input baseVersion and the document's current version.
      @baseVersionGUID: GUID of base version(excluded) to compare. This GUID should be retrieved from property Autodesk::Revit::DB::DocumentVersion::VersoinGUID. Empty GUID is allowed to retrieve changes of each version in the document.
      Returns: An object containing collections of the created, modified and deleted ids between the input version and current version.
      Throws ArgumentException: This GUID is invalid in the given document.
    string GetCloudFolderId(bool forceRefresh)
      Description: Gets ForgeDM folder id where the model locates.
      @forceRefresh: Cached value will be refreshed by sending a service call when forceRefresh is true.
      Throws RevitServerUnauthorizedException: Thrown when cannot get data from ForgeDM for Revit cloud model.
    ModelPath GetCloudModelPath()
      Description: Gets the cloud model path of the cloud model.
      Returns: The cloud model path
      Throws InvalidOperationException: This Document is a not cloud model, cannot execute this operation.
    string GetCloudModelUrn()
      Description: A ForgeDM Urn identifying the model.
      Throws RevitServerUnauthorizedException: Thrown when cannot get data from ForgeDM.
    ElementId GetDefaultElementTypeId(ElementTypeGroup defaultTypeId)
      Description: Gets the default element type id with the given DefaultElementType id.
      @defaultTypeId: The default element type id.
      Returns: The element type id.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    ElementId GetDefaultFamilyTypeId(ElementId familyCategoryId)
      Description: Gets the default family type id with the given family category id.
      @familyCategoryId: The family category id.
      Returns: The default family type id.
      Throws ArgumentException: familyCategoryId is not a built in category or parameter Element ID.
      Throws ArgumentNullException: A non-optional argument was null
    DocumentPreviewSettings GetDocumentPreviewSettings()
      Description: Returns the preview settings for the given document.
      Returns: The preview settings.
    static DocumentVersion GetDocumentVersion(Document doc)
      Description: Gets the DocumentVersion that corresponds to a document.
      @doc: The document whose DocumentVersion will be returned.
      Returns: The DocumentVersion corresponding to the given document.
      Throws ArgumentNullException: A non-optional argument was null
    Element GetElement(ElementId id)
      Description: Gets the Element referenced by the input ElementId.
      @id: The ElementId, whose referenced Element will be retrieved from the model.
      Returns: The element referenced by the input argument.
      Throws ArgumentNullException: A non-optional argument was null
    Element GetElement(string uniqueId)
      Description: Gets the Element referenced by a unique id string.
      @uniqueId: The element unique id, whose referenced Element will be retrieved from the model. UniqueId
      Returns: The element referenced by the input argument.
      Throws ArgumentNullException: A non-optional argument was null
    Element GetElement(Reference reference)
      Description: Gets the Element referenced by the input reference.
      @reference: The reference, whose referenced Element will be retrieved from the model.
      Returns: The element referenced by the input argument.
      Throws ArgumentNullException: A non-optional argument was null
    int GetHashCode()
      Description: Gets the hash code of this document instance.
    string GetHubId()
      Description: Gets ForgeDM hub id where the model locates. It is cached in session.
      Throws RevitServerUnauthorizedException: Thrown when cannot get data from ForgeDM for Revit cloud model.
    ElementId GetPaintedMaterial(ElementId elementId, Face face)
      Description: Get the material painted on the element's face. Returns invalidElementId if the face is not painted.
      @elementId: The element that the face belongs to.
      @face: The painted element's face.
      Returns: The material's Id painted on the element's face.
      Throws ArgumentException: The element elementId does not exist in the document -or- The face doesn't belong to the element
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<ElementId> GetPrintSettingIds()
      Description: Retrieves all Print Settings of current project.
      Returns: The ElementIds of all print setting elements
    string GetProjectId()
      Description: Gets ForgeDM project id where the model locates.
      Throws RevitServerUnauthorizedException: Thrown when cannot get data from ForgeDM for Revit cloud model.
    Room GetRoomAtPoint(XYZ point)
      Description: Gets a room containing the point.
      @point: Point to be checked.
      Returns: The room containing the point.
      Throws ArgumentNullException: Thrown when the point is .
      Throws ArgumentException: Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.
    Room GetRoomAtPoint(XYZ point, Phase phase)
      Description: Gets a room containing the point.
      @point: Point to be checked.
      @phase: Phase in which the room exists.
      Returns: The room containing the point.
      Throws ArgumentNullException: Thrown when the point is .
      Throws ArgumentException: Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.
    Space GetSpaceAtPoint(XYZ point)
      Description: Gets a space containing the point.
      @point: Point to be checked.
      Returns: The space containing the point.
      Throws ArgumentNullException: Thrown when the point is .
      Throws ArgumentException: Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.
    Space GetSpaceAtPoint(XYZ point, Phase phase)
      Description: Gets a space containing the point.
      @point: Point to be checked.
      @phase: Phase in which the space exists.
      Returns: The space containing the point.
      Throws ArgumentNullException: Thrown when the point is .
      Throws ArgumentException: Thrown when the coordinates of the point are not number or are Double::MaxValue or Double::MinValue.
    Subelement GetSubelement(ElementId id, int subId)
      Description: Gets the subelement referenced by a parent id and subelement id.
      @id: Id of the element.
      @subId: Id of the sub element.
      Returns: The subelement referenced by the input argument.
      Throws ArgumentNullException: A non-optional argument was null
    Subelement GetSubelement(string uniqueId)
      Description: Gets the subelement referenced by a unique id string.
      @uniqueId: The unique id that identifies element or subelement. UniqueId
      Returns: The subelement referenced by the input argument.
      Throws ArgumentNullException: A non-optional argument was null
    Subelement GetSubelement(Reference reference)
      Description: Gets the subelement referenced by the input reference.
      @reference: The reference that identifies element or subelement.
      Returns: The subelement referenced by the input argument.
      Throws ArgumentException: reference does not identify a valid element or subelement.
      Throws ArgumentNullException: A non-optional argument was null
    StorageType GetTypeOfStorage(ForgeTypeId parameterTypeId)
      Description: Get the storage type of the identified built-in parameter.
      @parameterTypeId: Identifier of the built-in parameter.
      Returns: Storage type of the built-in parameter.
      Throws ArgumentException: parameterTypeId does not identify a built-in parameter. See Parameter.IsBuiltInParameter(ForgeTypeId) and Parameter.GetParameterTypeId(BuiltInParameter).
      Throws ArgumentNullException: A non-optional argument was NULL
    Units GetUnits()
      Description: Gets the Units object.
      Returns: The Units object.
    ISet<ElementId> GetUnusedElements(ISet<ElementId> categories)
      Description: Returns the list of element ids that are not used and can be deleted from the document.
      @categories: Collection of categories to check for unused elements.
      Returns: Unused elements that can be deleted from the document.
      Throws ArgumentNullException: A non-optional argument was null
    IList<FailureMessage> GetWarnings()
      Description: Returns list of failure messages generated from persistent (reviewable) warnings accumulated in the document.
      Returns: List of failure messages representing warnings accumulated in the document.
    WorksetId GetWorksetId(ElementId id)
      Description: Get Id of the Workset which owns the element.
      @id: Id of the element.
      Returns: Id of the Workset which owns the element.
      Throws ArgumentNullException: A non-optional argument was null
    WorksetTable GetWorksetTable()
      Description: Get the WorksetTable of this document.
      Returns: The WorksetTable of this document.
    ModelPath GetWorksharingCentralModelPath()
      Description: Gets the central model path of the worksharing model.
      Returns: The central model path, or null if the document is not workshared.
      Throws InvalidOperationException: This Document is not a workshared document.
    bool HasAllChangesFromCentral()
      Description: Returns whether the model in the current session is up to date with central.
      Returns: True means up to date; false means out of date. If central is locked but Revit can determine that the model in the current session is out of date without opening central, this method will return false instead of throwing CentralModelContentionException.
      Throws CentralFileCommunicationException: The file-based central model could not be reached, because e.g. the network is down or the file server is down.
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is locked by another client.
      Throws CentralModelException: Username does not match the one used to create the local file. -or- The central model has been replaced by a local model. -or- Local incompatible because it was closed without saving after synchronizing with central. -or- The central model is missing. -or- The central model is incompatible. -or- The central model is corrupt or not an RVT file. -or- The central model was rolled back. -or- The central model's elements have been relinquished -or- The central model is overritten by other user. -or- An internal error happened on the central model, please contact the server administrator.
      Throws FileNotFoundException: Cannot access the local file.
      Throws InvalidOperationException: This Document is not a workshared document. -or- This Document is a local file that is not owned by the current user, who therefore is not allowed to modify it.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified A360 project.
    ElementId Import(string file, AXMImportOptions options, View pDBView)
      Description: Imports an AXM file into the document.
      @file: Full path of the file to import. File must exist and must be a valid AXM file.
      @options: Various import options applicable to the AXM format. If , all options will be set to their respective default values. Import FormIt support Preserve color mode, center-to-center and origin-to-origin placement, other options are not supported. Import FormIt does not support orient to view and this view only option.
      @pDBView: View used to aid placement of the imported file. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for AXM import (.axm files are valid). -or- The provided view is not valid for the options provided. -or- Visible layer only option is not false or layers are specified in SetLayerSelection. -or- Import levels is only supported in project document or conceptual mass document for AXM import. -or- Not all AXM import option settings are valid. For more details, please refer to AXMImportOptions. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The AXM Import/Link module is not available in the installed Revit.
    bool Import(string file, DGNImportOptions options, View pDBView, out ElementId elementId)
      Description: Imports a DGN file to the document.
      @file: Full path of the file to import. File must exist and must be a valid DGN file.
      @options: Various options applicable to the DGN format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      @elementId: The id of imported instance after a successful import.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: Not a valid file for DGN import (.dgn files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable. -or- Empty DGN model view name characters. -or- Visible layer only option must be set to false for DGN import.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DGN Import/Link module is not available in the installed Revit.
    ElementId Import(string file, ImportOptions3DM options, View pDBView)
      Description: Imports a 3DM file into the document.
      @file: Full path of the file to import. File must exist and must be a valid 3DM file.
      @options: Various import options applicable to the 3DM format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for 3DM import (.3dm files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The 3DM Import/Link module is not available in the installed Revit.
    ElementId Import(string file, STLImportOptions options, View pDBView)
      Description: Imports an STL file into the document.
      @file: Full path of the file to import. File must exist and must be a valid STL file.
      @options: Various import options applicable to the STL format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for STL import (.stl files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The STL Import/Link module is not available in the installed Revit.
    ElementId Import(string file, STEPImportOptions options, View pDBView)
      Description: Imports a STEP file into the document.
      @file: Full path of the file to import. File must exist and must be a valid STEP file.
      @options: Various import options applicable to the STEP format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for STEP import (.step, .stp., .stpz files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The STEP Import/Link module is not available in the installed Revit.
    ElementId Import(string file, OBJImportOptions options, View pDBView)
      Description: Imports an OBJ file into the document.
      @file: Full path of the file to import. File must exist and must be a valid OBJ file.
      @options: Various import options applicable to the OBJ format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for OBJ import (.obj files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The OBJ Import/Link module is not available in the installed Revit.
    ElementId Import(string file, SKPImportOptions options, View pDBView)
      Description: Imports a SKP file into the document.
      @file: Full path of the file to import. File must exist and must be a valid SKP file.
      @options: Various import options applicable to the SKP format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for SKP import (.skp files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The SKP Import/Link module is not available in the installed Revit.
    ElementId Import(string file, SATImportOptions options, View pDBView)
      Description: Imports an SAT file into the document.
      @file: Full path of the file to import. File must exist and must be a valid SAT file.
      @options: Various import options applicable to the SAT format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      Returns: Returns the element Id of the imported instance.
      Throws ArgumentException: Not a valid file for SAT import (.sat files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The SAT Import/Link module is not available in the installed Revit.
    bool Import(string file, DWGImportOptions options, View pDBView, out ElementId elementId)
      Description: Imports a DWG or DXF file to the document.
      @file: Full path of the file to import. File must exist and must be a valid DWG or DXF file.
      @options: Various options applicable to the DWG or DXF format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the imported file. If the options specify ThisViewOnly, this argument is required and the imported file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the imported file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the imported file. If not specified, an existing view will be chosen instead and may open a view or associate the imported file to an arbitrary level.
      @elementId: The id of imported instance after a successful import.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: Not a valid file for DWG import (.dwg and .dxf files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DWG Import/Link module is not available in the installed Revit.
    bool Import(string file, GBXMLImportOptions options)
      Description: Imports a Green-Building XML file into the document.
      @file: Full path of the file to import. File must exist.
      @options: Various options applicable to GBXml import. If , all options will be set to their respective default values.
      Returns: True if successful, otherwise False.
      Throws ArgumentNullException: Thrown when file argument is or empty.
      Throws FileNotFoundException: Thrown when the file specified does not exist.
      Throws ArgumentException: Thrown when no file is specified or if the file is not a valid gbXML file or does not contain any result elements.
    bool IsBackgroundCalculationInProgress()
      Description: Indicates whether there are any background calculations in progress for this document.
      Returns: Returns true if the document has any data calculation in progress and false otherwise.
    bool IsDefaultElementTypeIdValid(ElementTypeGroup defaultTypeId, ElementId typeId)
      Description: Checks whether the element type id is valid for the give DefaultElmentType id.
      @defaultTypeId: The default element type id.
      @typeId: The element type id.
      Returns: True if the element type id is valid for the give DefaultElmentType id, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsDefaultFamilyTypeIdValid(ElementId familyCategoryId, ElementId familyTypeId)
      Description: Checks whether the family type id is valid for the give family category.
      @familyCategoryId: The family category id.
      @familyTypeId: The default family type id.
      Returns: True if the family type id is valid for the give family category, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsInEditMode()
      Description: Indicates if the document is in an edit mode.
      Returns: Returns true if the document is in an edit mode, false otherwise.
    bool IsPainted(ElementId elementId, Face face)
      Description: Checks if the element's face is painted with a material.
      @elementId: The element that the face belongs to.
      @face: The painted element's face.
      Returns: True if the element's face is painted.
      Throws ArgumentException: The element elementId does not exist in the document -or- The face doesn't belong to the element
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidVersionGUID(Document document, Guid versionGUID)
      Description: Checks whether the GUID is valid for the given document. Empty GUID is allowed.
      @document: Target document.
      @versionGUID: The GUID to check.
      Returns: True if the GUID is valid.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ElementId> Link(string file, DWFImportOptions options)
      Description: Links Markups in a DWF file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid DWF file.
      @options: Various link options applicable to the DWF format.
      Returns: A collection of link instance element ids created by the markup link.
      Throws ArgumentException: Not a valid file for DWF import (.dwf or.dwfx files are valid). -or- Some of the views are not importable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    bool Link(string file, DGNImportOptions options, View pDBView, out ElementId elementId)
      Description: Links a DGN file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid DGN file.
      @options: Various import options applicable to the DGN format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      @elementId: The id of linked instance after a successful link.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: Not a valid file for DGN import (.dgn files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable. -or- Empty DGN model view name characters. -or- Visible layer only option must be set to false for DGN import.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DGN Import/Link module is not available in the installed Revit.
    ElementId Link(string file, ImportOptions3DM options, View pDBView)
      Description: Links a 3DM file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid 3DM file.
      @options: Various import options applicable to the 3DM format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      Returns: Returns the element Id of the linked instance.
      Throws ArgumentException: Not a valid file for 3DM import (.3dm files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The 3DM Import/Link module is not available in the installed Revit.
    ElementId Link(string file, STLImportOptions options, View pDBView)
      Description: Links an STL file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid STL file.
      @options: Various import options applicable to the STL format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      Returns: Returns the element Id of the linked instance.
      Throws ArgumentException: Not a valid file for STL import (.stl files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The STL Import/Link module is not available in the installed Revit.
    ElementId Link(string file, STEPImportOptions options, View pDBView)
      Description: Links an STEP file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid STEP file.
      @options: Various import options applicable to the STEP format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      Returns: Returns the element Id of the linked instance.
      Throws ArgumentException: Not a valid file for STEP import (.step, .stp., .stpz files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The STEP Import/Link module is not available in the installed Revit.
    ElementId Link(string file, OBJImportOptions options, View pDBView)
      Description: Links an OBJ file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid OBJ file.
      @options: Various import options applicable to the OBJ format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      Returns: Returns the element Id of the linked instance.
      Throws ArgumentException: Not a valid file for OBJ import (.obj files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The OBJ Import/Link module is not available in the installed Revit.
    ElementId Link(string file, SKPImportOptions options, View pDBView)
      Description: Links a SKP file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid SKP file.
      @options: Various import options applicable to the SKP format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      Returns: Returns the element Id of the linked instance.
      Throws ArgumentException: Not a valid file for SKP import (.skp files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The SKP Import/Link module is not available in the installed Revit.
    ElementId Link(string file, SATImportOptions options, View pDBView)
      Description: Links an SAT file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid SAT file.
      @options: Various import options applicable to the SAT format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      Returns: Returns the element Id of the linked instance.
      Throws ArgumentException: Not a valid file for SAT import (.sat files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The SAT Import/Link module is not available in the installed Revit.
    bool Link(string file, DWGImportOptions options, View pDBView, out ElementId elementId)
      Description: Links a DWG or DXF file into the project document.
      @file: Full path of the file to link. File must exist and must be a valid DWG or DXF file.
      @options: Various import options applicable to the DWG or DXF format. If , all options will be set to their respective default values.
      @pDBView: View used to aid placement of the linked file. If the options specify ThisViewOnly, this argument is required and the linked file will only be visible in the specified view. If the options specify center-to-center placement, this argument is required and the linked file will be placed in the center of the specified view. Otherwise, this view is used to obtain a base level to associate with the linked file. If not specified, an existing view will be chosen instead and may open a view or associate the linked file to an arbitrary level.
      @elementId: The id of linked instance after a successful link.
      Returns: True if successful, otherwise False.
      Throws ArgumentException: Not a valid file for DWG import (.dwg and .dxf files are valid). -or- ThisViewOnly cannot be true when importing a DWG|DGN drawing into a 3D view. -or- The provided view is not valid for the options provided. -or- One or more strings describing layer selection is invalid or empty. -or- The line weights are not valid; either it contains an invalid number of line weights, or a line weight outside the valid range. -or- The scale is not valid as a CustomScale for use during import. -or- NullOrEmpty -or- The view is not printable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given file does not exist.
      Throws InvalidOperationException: Import is temporarily disabled. -or- This Document is not a project document.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws OptionalFunctionalityNotAvailableException: The Material Library is missing in the installed Revit. -or- The DWG Import/Link module is not available in the installed Revit.
    Family LoadFamily(Document targetDocument, IFamilyLoadOptions familyLoadOptions)
      Description: Loads the contents of this family document into another document.
      @targetDocument: The target document which the family will be loaded into.
      @familyLoadOptions: The interface implementation to use when responding to conflicts during the load operation.
      Returns: Reference of the family in the target document.
      Throws ArgumentNullException: Thrown when the input argument-"targetDocument" or "familyLoadOptions"-is .
      Throws InvalidOperationException: Thrown when the current document is not a family document, or when the target document is modifiable (e.g. there is an uncommitted transaction) or doesn't support load of this kind of families (e.g. loading a model family to detail family is disallowed), or the load was cancelled due to a conflict and a False return from one of the interface methods, or this document is currently in a read-only state.
      Throws ForbiddenForDynamicUpdateException: Thrown if this method is called during dynamic update.
    Family LoadFamily(Document targetDocument)
      Description: Loads the contents of this family document into another document.
      @targetDocument: The target document where the family will be loaded.
      Returns: Reference of the family in the target document.
      Throws ArgumentNullException: Thrown when the input argument-"targetDocument"-is .
      Throws InvalidOperationException: Thrown when the current document is not a family document, or when the target document is modifiable (e.g. there is an uncommitted transaction) or doesn't support load of this kind of families (e.g. loading a model family to detail family is disallowed), or when this family was found in the target document already and the conflict caused an automatic abort of the load operation, or when a shared family in this family was found in the target document already and the conflict caused an automatic abort of the load operation, or this document is currently in a read-only state.
      Throws ForbiddenForDynamicUpdateException: Thrown if this method is called during dynamic update.
    bool LoadFamily(string filename, IFamilyLoadOptions familyLoadOptions, out Family family)
      Description: Loads an entire family and all its types/symbols into the document and provides a reference to the loaded family.
      @filename: The fully qualified filename of the Family file, usually ending in .rfa.
      @familyLoadOptions: The interface implementation to use when loading a family into the document.
      @family: A reference to the family that was loaded if successful, otherwise Nothing.
      Returns: True if the entire family was loaded successfully into the project, otherwise False.
      Throws ArgumentException: Thrown when filename is or empty.
      Throws ArgumentNullException: Thrown when the input argument "familyLoadOptions" is .
    bool LoadFamily(string filename, out Family family)
      Description: Loads an entire family and all its types/symbols into the document and provides a reference to the loaded family.
      @filename: The fully qualified filename of the Family file, usually ending in .rfa.
      @family: A reference to the family that was loaded if successful, otherwise .
      Returns: True if the entire family was loaded successfully into the project, otherwise False.
      Throws ArgumentException: Thrown when filename is or empty.
    bool LoadFamily(string filename)
      Description: Loads an entire family and all its types/symbols into the document.
      @filename: The fully qualified filename of the Family file, usually ending in .rfa.
      Returns: True if the entire family was loaded successfully into the project, otherwise False.
      Throws ArgumentException: Thrown when filename is or empty.
    bool LoadFamilySymbol(string filename, string name, IFamilyLoadOptions familyLoadOptions, out FamilySymbol symbol)
      Description: Loads only the specified family type/symbol from a family file into the document and provides a reference to the loaded family symbol.
      @filename: The fully qualified filename of the Family file, usually ending in .rfa.
      @name: The name of the type/symbol to be loaded, such as "W11x14".
      @familyLoadOptions: The interface implementation to use when loading a family into the document.
      @symbol: A reference to the family symbol that was loaded if successful, otherwise Nothing.
      Returns: True if the family type/symbol was loaded successfully into the project, otherwise False.
      Throws ArgumentException: Thrown when filename or name is or empty.
    bool LoadFamilySymbol(string filename, string name, out FamilySymbol symbol)
      Description: Loads only the specified family type/symbol from a family file into the document and provides a reference to the loaded family symbol.
      @filename: The fully qualified filename of the Family file, usually ending in .rfa.
      @name: The name of the type/symbol to be loaded, such as "W11x14".
      @symbol: A reference to the family symbol that was loaded if successful, otherwise .
      Returns: True if the family type/symbol was loaded successfully into the project, otherwise False.
      Throws ArgumentException: Thrown when filename or name is or empty.
    bool LoadFamilySymbol(string filename, string name)
      Description: Loads only a specified family type/symbol from a family file into the document.
      @filename: The fully qualified filename of the Family file, usually ending in .rfa.
      @name: The name of the type/symbol to be loaded, such as "W11x14".
      Returns: True if the family type/symbol was loaded successfully into the project, otherwise False.
      Throws ArgumentException: Thrown when filename or name is or empty.
    void MakeTransientElements(ITransientElementMaker maker)
      Description: This method encapsulates the process of creating transient elements in the document.
      @maker: An instance of a class that implements the ITransientElementMaker interface. The maker will be called to create element(s) which would become transient.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This Document has an open editing transaction and is accepting changes. -or- This Document is read-only: It cannot be modified.
    void Paint(ElementId elementId, Face face, ElementId materialId)
      Description: Paint the element's face with specified material.
      @elementId: The element that the face belongs to.
      @face: The painted element's face.
      @materialId: The material to be painted on the face
      Throws ArgumentException: The element elementId does not exist in the document -or- The element materialId does not exist in the document -or- The face doesn't belong to the element -or- The materialId doesn't specify a material element. -or- The element's face cannot be painted.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Paint(ElementId elementId, Face face, FamilyParameter familyParameter)
      Description: Paint the element's face with specified material.
      @elementId: The element that the face belongs to.
      @face: The painted element's face.
      @familyParameter: The family parameter associated with a material.
      Throws ArgumentException: The element elementId does not exist in the document. -or- The element materialId does not exist in the document. -or- The face doesn't belongs to the element. -or- The family parameter doesn't specify a material element. -or- The element's face cannot be painted.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: This document is not modifiable. -or- This operation is valid only in family.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    FailureMessageKey PostFailure(FailureMessage failure)
      Description: Posts a failure to be displayed to the user at the end of transaction.
      @failure: The failure to be posted.
      Returns: A unique key that identifies posted failure message in a document. If exactly the same error is posted more than once, and not removed between the postings, returned key will be the same every time.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Document must be in state of accepting posted failures and the failures must be appropriate for that current state.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Print(ViewSet views, View viewTemplate, bool useCurrentPrintSettings)
      Description: Prints a set of views with a specified view template and default print settings.
      @views: The set of views which need to be printed.
      @viewTemplate: The view template which apply to the set of views.
      @useCurrentPrintSettings: If true, print the view with the current print setting, otherwise with the print setting of the document of the view.
      Throws InvalidOperationException: Thrown when printing is not allowed in the current application mode. Or when at least one view from the view set is not a printable view.
      Throws ArgumentNullException: Thrown when the view set to be printed is .
      Throws ArgumentException: Thrown when the view set contains a element.
      Throws ApplicationException: Thrown when at least one view from the view set could not be printed.
      Throws OperationCanceledException: Thrown when print is cancelled by event handler.
    void Print(ViewSet views, View viewTemplate)
      Description: Prints a set of views with a specified view template and default print settings.
      @views: The set of views which need to be printed.
      @viewTemplate: The view template which apply to the set of views.
      Throws InvalidOperationException: Thrown when printing is not allowed in the current application mode. Or when at least one view from the view set is not a printable view.
      Throws ArgumentNullException: Thrown when the view set to be printed is .
      Throws ArgumentException: Thrown when the view set contains a element.
      Throws ApplicationException: Thrown when at least one view from the view set could not be printed.
      Throws OperationCanceledException: Thrown when print is cancelled by event handler.
    void Print(ViewSet views, bool useCurrentPrintSettings)
      Description: Prints a set of views with default view template and default print settings.
      @views: The set of views which need to be printed.
      @useCurrentPrintSettings: If true, print the view with the current print setting, otherwise with the print setting of the document of the view.
      Throws InvalidOperationException: Thrown when printing is not allowed in the current application mode. Or when at least one view from the view set is not a printable view.
      Throws ArgumentNullException: Thrown when the view set to be printed is .
      Throws ArgumentException: Thrown when the view set contains a element.
      Throws ApplicationException: Thrown when at least one view from the view set could not be printed.
      Throws OperationCanceledException: Thrown when print is cancelled by event handler.
    void Print(ViewSet views)
      Description: Prints a set of views with default view template and default print settings.
      @views: The set of views which need to be printed.
      Throws InvalidOperationException: Thrown when printing is not allowed in the current application mode. Or when at least one view from the view set is not a printable view.
      Throws ArgumentNullException: Thrown when the view set to be printed is .
      Throws ArgumentException: Thrown when the view set contains a element.
      Throws InvalidOperationException: Thrown when at least one view from the view set could not be printed.
      Throws OperationCanceledException: Thrown when print is cancelled by event handler.
    void PublishCoordinates(LinkElementId locationId)
      Description: Publish coordinates to the specified ProjectLocation of the link instance.
      @locationId: The ElementId of the ProjectLocation in the linked document, to which the transform would be published to.
      Throws ArgumentException: locationId does not contain a valid linkInstanceId. -or- Only RevitLinkInstance is supported through API for publish coordinates.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This Document is not a project document. -or- This Document is in an edit mode. -or- Attempting to publish shared coordinates to a cloud based link which is treated as read-only. -or- Failed to publish coordinates to the specified ProjectLocation of the link instance.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Regenerate()
      Description: Updates the elements in the Revit document to reflect all changes.
      Throws RegenerationFailedException: Thrown when the operation fails. If regeneration fails, there is posted error of severity DocumentCorruption that will be delivered to the end user at the end of transaction explaining what specifically has happened.If regeneration has failed, document is corrupted and even reading from it is illegal.Code that called regeneration and got this exception should not catch and ignore it - instead, it should do nothing but internal cleanup and return control to the owner of currently active transaction/subtransaction, which must be aborted.
      Throws InvalidOperationException: Modification of the document is forbidden. Typically, this is because there is no open transaction; consult documentation for Document.IsModified for other possible causes.
    void ReloadLatest(ReloadLatestOptions reloadOptions)
      Description: Fetches changes from central (due to one or more synchronizations with central) and merges them into the current session.
      @reloadOptions: Various options to control behavior of reloadLatest.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: The file-based central model could not be reached, because e.g. the network is down or the file server is down.
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is locked by another client.
      Throws CentralModelException: Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again. -or- The central model has been replaced by a local model. -or- Local incompatible because it was closed without saving after synchronizing with central. -or- The central model is missing. -or- The central model is incompatible. -or- The central model is corrupt or not an RVT file. -or- The central model was rolled back. -or- The central model's elements have been relinquished -or- The central model is overritten by other user. -or- An internal error happened on the central model, please contact the server administrator.
      Throws FileNotFoundException: Cannot access the local file.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- This Document is not a local model: it is not workshared or is central. -or- This Document is read-only: It cannot be modified. -or- This Document has an open editing transaction and is accepting changes. -or- This Document is not a project document. -or- This Document is in an edit mode. -or- This Document is a local file that is not owned by the current user, who therefore is not allowed to modify it. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws OperationCanceledException: Reload Latest was canceled by the user or by an API event callback.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified A360 project.
    void RemovePaint(ElementId elementId, Face face)
      Description: Remove the material painted on the element's face. If the face is currently not painted,it will do nothing.
      @elementId: The element that the painted face belongs to.
      @face: The painted element's face.
      Throws ArgumentException: The element elementId does not exist in the document -or- The face doesn't belong to the element
      Throws ArgumentNullException: A non-optional argument was null
    void ResetSharedCoordinates()
      Description: Reset shared coordinates for the host model/file.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- This Document is not a project document. -or- This Document is in an edit mode.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Save(SaveOptions options)
      Description: Saves the document.
      @options: Options to control the Save operation.
      Throws ArgumentException: options.PreviewViewId is not valid for generation of a preview.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelException: Central model is missing. -or- Central model is incompatible. -or- The central model was saved in a different version of Revit. -or- Revit encountered errors while saving to the new central model. Resave again as a new central model. -or- Incompatible servers for external services. -or- Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again.
      Throws ForbiddenForDynamicUpdateException: Save may not be called during dynamic update.
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to save the model.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- Save is temporarily disabled. -or- Saving is not allowed in the current application mode. -or- File path must be already set to be able to save the document.It needs to be first saved using the SaveAs method instead. -or- The file is read-only, can not be saved. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group. -or- Saving failed.
      Throws OperationCanceledException: Saving was canceled by the user or by an API event callback.
      Throws OutdatedDirectlyOpenedCentralException: Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.
    void Save()
      Description: Saves the document.
      Throws CentralModelException: Central model is missing. -or- Central model is incompatible. -or- The central model was saved in a different version of Revit. -or- Revit encountered errors while saving to the new central model. Resave again as a new central model. -or- Incompatible servers for external services. -or- Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again.
      Throws ForbiddenForDynamicUpdateException: Save may not be called during dynamic update.
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to save the model.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- Save is temporarily disabled. -or- Saving is not allowed in the current application mode. -or- File path must be already set to be able to save the document.It needs to be first saved using the SaveAs method instead. -or- The file is read-only, can not be saved. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group. -or- Saving failed.
      Throws OperationCanceledException: Saving was canceled by the user or by an API event callback.
      Throws OutdatedDirectlyOpenedCentralException: Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.
    void SaveAs(ModelPath path, SaveAsOptions options)
      Description: Saves the document to a given path.
      @path: Name and path to be saved as. For a file path, either a relative or absolute path can be provided.
      @options: Options to govern the SaveAs operation.
      Throws ArgumentException: The path is empty. -or- The specified filepath is invalid. -or- options.PreviewViewId is not valid for generation of a preview. -or- The document is not workshared, so no WorksharingSaveAsOptions are allowed to be set for SaveAs. -or- The document just had worksharing enabled or was opened detached, so WorksharingSaveAsOptions.SaveAsCentral must be set to true for SaveAs. -or- Revit cannot clear the transmitted flag. This is not a transmitted document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is being accessed by another client.
      Throws CentralModelException: The central model is overwritten by other user. -or- The central model is missing. -or- The central model is incompatible. -or- Your data or permissions saving is aborted by another user. -or- The central model was saved in a different version of Revit. -or- Revit encountered errors while saving to the new central model. Resave again as a new central model. -or- Incompatible servers for external services. -or- Overwrite old-version model is not supported for server-based. -or- An internal error happened on the central model, please contact the server administrator. -or- Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again.
      Throws FileAccessException: The file at the given path location could not be accessed or saved.
      Throws FileNotFoundException: The given file, path or network location could not be found during save.
      Throws ForbiddenForDynamicUpdateException: SaveAs may not be called during dynamic update.
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to save the model.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- SaveAs is temporarily disabled. -or- options.overwriteExistingFile is 'false' but there is an existing file at path. -or- options.overwriteExistingFile is 'true' but the target file at path is read only. -or- There is already a central at path; Revit Server does not allow overwrite. -or- Revit Server only supports RVT model. -or- Saving is not allowed in the current application mode. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group. -or- Saving failed. -or- The file path is invalid.
      Throws OperationCanceledException: Saving was canceled by the user or by an API event callback.
      Throws OutdatedDirectlyOpenedCentralException: Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: The disk space is running low on server, please contact the server administrator. -or- An internal error happened on the server, please contact the server administrator.
    void SaveAs(string filepath, SaveAsOptions options)
      Description: Saves the document to a given file path.
      @filepath: File name and path to be saved as. Either a relative or absolute path can be provided.
      @options: Options to govern the SaveAs operation.
      Throws ArgumentException: filepath is an empty string. -or- The specified filepath is invalid. -or- options.PreviewViewId is not valid for generation of a preview. -or- The document is not workshared, so no WorksharingSaveAsOptions are allowed to be set for SaveAs. -or- The document just had worksharing enabled or was opened detached, so WorksharingSaveAsOptions.SaveAsCentral must be set to true for SaveAs. -or- Revit cannot clear the transmitted flag. This is not a transmitted document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelException: Central model is missing. -or- Central model is incompatible. -or- The central model was saved in a different version of Revit. -or- Revit encountered errors while saving to the new central model. Resave again as a new central model. -or- Incompatible servers for external services. -or- Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again.
      Throws FileAccessException: The file at the given path location could not be accessed or saved.
      Throws FileNotFoundException: The given file, path or network location could not be found during save.
      Throws ForbiddenForDynamicUpdateException: SaveAs may not be called during dynamic update.
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to save the model.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- SaveAs is temporarily disabled. -or- options.overwriteExistingFile is 'false' but there is an existing file at filepath. -or- options.overwriteExistingFile is 'true' but the target file at filepath is read only. -or- Saving is not allowed in the current application mode. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group. -or- Revit cannot clear the transmitted flag. This is not a transmitted document. -or- Saving failed.
      Throws OperationCanceledException: Saving was canceled by the user or by an API event callback.
      Throws OutdatedDirectlyOpenedCentralException: Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.
    void SaveAs(string filepath)
      Description: Saves the document to a given file path.
      @filepath: File name and path to be saved as. Either a relative or absolute path can be provided.
      Throws ArgumentException: filepath is an empty string. -or- The filepath is not a valid file path.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelException: Central model is missing. -or- Central model is incompatible. -or- The central model was saved in a different version of Revit. -or- Revit encountered errors while saving to the new central model. Resave again as a new central model. -or- Incompatible servers for external services. -or- Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again.
      Throws FileAccessException: The file at the given path location could not be accessed or saved.
      Throws FileNotFoundException: The given file, path or network location could not be found during save.
      Throws ForbiddenForDynamicUpdateException: SaveAs may not be called during dynamic update.
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to save the model.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- SaveAs is temporarily disabled. -or- There is an existing file at filepath. -or- Saving is not allowed in the current application mode. -or- The document just had worksharing enabled or was opened detached, so SaveAsOptions must be passed in SaveAs with WorksharingSaveAsOptions.SaveAsCentral set to true. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group. -or- Saving failed.
      Throws OperationCanceledException: Saving was canceled by the user or by an API event callback.
      Throws OutdatedDirectlyOpenedCentralException: Other users have modified the central model while you had it opened. Resave your document as a local file and then synchronize with central again.
    void SaveAsCloudModel(Guid accountId, Guid projectId, string folderId, string modelName)
      Description: Saves current non-workshared or workshared model as a cloud model or workshared cloud model.
      @accountId: Cloud Model account Id. You can use one of the following methods to get this Id: If you get the hub Id with Forge Data Management API, remove the prefix "b." of the Id string and convert the rest to a Guid.
      @projectId: Cloud Model project Id in Autodesk Project. You can use one of the following methods to get this Id: If you get the project Id with Forge Data Management API, remove the prefix "b." of the Id string and convert the rest to a Guid.
      @folderId: Folder identity to save the model in Autodesk Project. You can use one of the following methods to get this Id: The folder Id string from Forge Data Management API.
      @modelName: Specify the model name in Autodesk Project to save the model.
      Throws ArgumentException: folderId is an empty string. -or- modelName is an empty string. -or- The input file name "modelName" does not represent a valid file name. -or- Thrown when the input account Id or project Id is invalid or unmatched.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: SaveAs may not be called during dynamic update.
      Throws InvalidOperationException: Saving is not allowed in the current application mode. -or- This Document is not a project document. -or- This Document is in an edit mode. -or- This Document is not a primary document, it is a linked document. -or- SaveAs is temporarily disabled. -or- This Document is a cloud model, cannot be saved as a cloud model. -or- There is a transaction phase left open (such as a transaction, sub-transaction of transaction group) at the time of invoking this method.
      Throws RevitServerCommunicationException: Could be for any of the reasons related to network.
      Throws RevitServerInternalException: Could be for any of the reasons that saveAs fails with RevitServerInternalException.
      Throws RevitServerModelAlreadyExistsException: Failed due to there is a model with the same name already exists at the specified location.
      Throws RevitServerModelNameBreaksConventionException: Failed due to the model name is breaking project naming convention.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: You don't have the entitlement to perform the operation to this this Document. -or- User is not authorized to access the specified cloud project.
    void SaveCloudModel()
      Description: Saves cloud model.
      Throws CentralModelAccessDeniedException: Could be for any of the reasons that related to access to the cloud model.
      Throws CentralModelContentionException: The central model is locked by another client.
      Throws CentralModelException: Could be for any of the reasons that fails with CentralModelException, for example, a central model with that name is already associated to the specified cloud project.
      Throws FileNotFoundException: Cannot access the local file.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- This Document is read-only: It cannot be modified. -or- This Document has an open editing transaction and is accepting changes. -or- This Document is not a project document. -or- This Document is in an edit mode. -or- Saving is not allowed in the current application mode. -or- This Document does not have a central location: Worksharing needs to be enabled and central model saved. -or- The file is read-only, can not be saved. -or- This Document is a not cloud model, cannot execute this operation. -or- This Document is a workshared document. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws OperationCanceledException: Synchronize With Central was canceled by the user or by an API event callback.
      Throws RevitServerCommunicationException: Could be for any of the reasons related to network.
      Throws RevitServerInternalException: Could be for any of the reasons that save fails with RevitServerInternalException.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified cloud project.
    ElementId SaveToProjectAsImage(ImageExportOptions options)
      Description: Creates an image view from the currently active view.
      @options: The options which govern the image creation.
      Returns: Id of the newly created view if the operation succeeded, invalid element id otherwise.
      Throws ArgumentException: options object is invalid: the ExportRange is invalid, must be CurrentView or VisibleRegionOfCurrentView, or the ViewName is invalid, must be non-empty, unique and should not contain prohibited characters. -or- The current view cannot be exported as an image
      Throws ArgumentNullException: A non-optional argument was null
    void SeparateElements(CombinableElementArray members)
      Description: Separate a set of combinable elements out of combinations they currently belong to.
      @members: A list of combinable elements to be separated.
      Throws ArgumentNullException: Thrown when the input argument is .
      Throws ArgumentException: Thrown when members is empty. Thrown when members contains elements.
      Throws InvalidOperationException: Thrown when separation failed.
    void SetDefaultElementTypeId(ElementTypeGroup defaultTypeId, ElementId typeId)
      Description: Sets the default element type id of the given DefaultElementType id.
      @defaultTypeId: The default element type id.
      @typeId: The element type id.
      Throws ArgumentException: The element type id typeId is invalid for the give DefaultElementType id defaultTypeId.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetDefaultFamilyTypeId(ElementId familyCategoryId, ElementId familyTypeId)
      Description: Sets the default family type id for the given family category.
      @familyCategoryId: The family category id.
      @familyTypeId: The default family type id.
      Throws ArgumentException: The family type id familyTypeId is invalid for the give family category familyCategoryId. -or- familyCategoryId is not a built in category or parameter Element ID.
      Throws ArgumentNullException: A non-optional argument was null
    void SetUnits(Units units)
      Description: Sets the units.
      @units: The units.
      Throws ArgumentNullException: A non-optional argument was null
    void SynchronizeWithCentral(TransactWithCentralOptions transactOptions, SynchronizeWithCentralOptions syncOptions)
      Description: Performs reload latest until the model in the current session is up to date and then saves changes back to central. A save to central is performed even if no changes were made.
      @transactOptions: Options to customize behavior accessing the central model.
      @syncOptions: Options to customize behavior of SynchronizeWithCentral.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralFileCommunicationException: The file-based central model could not be reached, because e.g. the network is down or the file server is down.
      Throws CentralModelAccessDeniedException: Access to the central model was denied due to lack of access privileges. -or- Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model is locked by another client.
      Throws CentralModelException: Username does not match the one used to create the local file. -or- Revit could not save all of the worksets that have been changed. Try again. -or- Some of the elements you changed in this model are now editable by someone else, or you checked out worksets that were at risk or relinquished in the central model but not this file. You cannot synchronize with the central model until the other user relinquishes these elements without making changes. -or- The central model has been replaced by a local model. -or- Local incompatible because it was closed without saving after synchronizing with central. -or- The central model is missing. -or- The central model is incompatible. -or- The central model is corrupt or not an RVT file. -or- The central model was rolled back. -or- The central model's elements have been relinquished -or- Your data or permissions saving is aborted by another user. -or- The central model is overritten by other user. -or- An internal error happened on the central model, please contact the server administrator.
      Throws FileNotFoundException: Cannot access the local file.
      Throws InvalidOperationException: This Document is not a primary document, it is a linked document. -or- This Document is read-only: It cannot be modified. -or- This Document has an open editing transaction and is accepting changes. -or- This Document is not a project document. -or- This Document is in an edit mode. -or- Saving is not allowed in the current application mode. -or- This Document does not have a central location: Worksharing needs to be enabled and central model saved. -or- This Document is a local file that is not owned by the current user, who therefore is not allowed to modify it. -or- The local file is read-only. It can not be saved before or after synchronizing with central. -or- This Document is not a workshared document. -or- Saving local before first reload latest and after saving changes to central in Synchronize with Central is mandatory for server-based local models. -or- Operation is not permitted when there is any open sub-transaction, transaction, or transaction group.
      Throws OperationCanceledException: Synchronize With Central was canceled by the user or by an API event callback.
      Throws RevitServerCommunicationException: The server-based central model could not be reached because of a network communication error.
      Throws RevitServerInternalException: The disk space is running low on server, please contact the server administrator. -or- An internal error happened on the server, please contact the server administrator.
      Throws RevitServerUnauthenticatedUserException: User is not signed in with Autodesk id.
      Throws RevitServerUnauthorizedException: User is not authorized to access the specified A360 project.
    void UnpostFailure(FailureMessageKey messageKey)
      Description: Deletes the posted failure message associated with a given FailureMessageKey.
      @messageKey: The key of the FailureMessage to be deleted.
      Throws ArgumentException: messageKey is invalid
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

  EVENTS:
    event EventHandler<DocumentClosingEventArgs> DocumentClosing
      Description: Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.
    event EventHandler<ViewPrintedEventArgs> ViewPrinted
      Description: Subscribe to the ViewPrinted event to be notified immediately after Revit has finished printing a view of the document.
    event EventHandler<ViewPrintingEventArgs> ViewPrinting
      Description: Subscribe to the ViewPrinting event to be notified when Revit is just about to print a view of the document.
    event EventHandler<DocumentPrintedEventArgs> DocumentPrinted
      Description: Subscribe to the DocumentPrinted event to be notified immediately after Revit has finished printing a view or ViewSet of the document.
    event EventHandler<DocumentPrintingEventArgs> DocumentPrinting
      Description: Subscribe to the DocumentPrinting event to be notified when Revit is just about to print a view or ViewSet of the document.
    event EventHandler<DocumentSavedAsEventArgs> DocumentSavedAs
      Description: Subscribe to the DocumentSavedAs event to be notified immediately after Revit has finished saving document with a new file name.
    event EventHandler<DocumentSavingAsEventArgs> DocumentSavingAs
      Description: Subscribe to the DocumentSavingAs event to be notified when Revit is just about to save the document with a new file name.
    event EventHandler<DocumentSavedEventArgs> DocumentSaved
      Description: Subscribe to the DocumentSaved event to be notified immediately after Revit has finished saving a document.
    event EventHandler<DocumentSavingEventArgs> DocumentSaving
      Description: Subscribe to the DocumentSaving event to be notified when Revit is just about to save a document.

--------------------------------------------------------------------------------

[CLASS] DocumentDifference
Full Name: Autodesk.Revit.DB.DocumentDifference
Description: DocumentDifference represents the difference (including added elements, modified elements and deleted elements) of a Revit model between different DocumentVersion of the model.
Remarks: For workshared models, DocumentDifference may contain all the added elements, modified elements and deleted elements. For non-workshared models, deleted elements are not tracked, so this object may only contain added elements and modified elements.
Implements: IDisposable

  PROPERTIES:
    bool AreDeletedElementIdsAvailable { get; }
      Description: Whether or the deleted elements were retrieved.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ISet<ElementId> GetCreatedElementIds()
      Description: Created element id collection.
    ISet<ElementId> GetDeletedElementIds()
      Description: Deleted element id collection. For non-worksharing models, this will always be an empty collection.
    ISet<ElementId> GetModifiedElementIds()
      Description: Modified element id collection.

--------------------------------------------------------------------------------

[CLASS] DocumentPreviewSettings
Full Name: Autodesk.Revit.DB.DocumentPreviewSettings
Description: Contains the settings related to the saving of preview images for a given document.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsViewUpdateForced { get; }
      Description: Identifies if Revit will update the preview view if necessary.
    ElementId PreviewViewId { get; set; }
      Description: The view id that will be used to generate the preview.

  METHODS:
    void Dispose()
    void ForceViewUpdate(bool forceViewUpdate)
      Description: Sets Revit to update the preview view if necessary.
      @forceViewUpdate: True to force update of the preview view. False to skip update if necessary (the default).
    bool IsViewIdValidForPreview(ElementId viewId)
      Description: Identifies if the view id is valid as a preview view id.
      @viewId: The view id.
      Returns: True if the view id is valid for preview, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DocumentSet
Full Name: Autodesk.Revit.DB.DocumentSet
Description: A set that can contain any documents.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new DocumentSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Document item)
      Description: Tests for the existence of an item within the set.
      @item: The item to be searched for.
      Returns: The Contains method returns True if the item is within the set, otherwise False.
    int Erase(Document item)
      Description: Removes a specified object from the set.
      @item: The item to be erased.
      Returns: The number of items that were erased from the set.
    DocumentSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Document item)
      Description: Insert the specified item into the set.
      @item: The item to be inserted into the set.
      Returns: Returns whether the item was inserted into the set.
    DocumentSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DocumentSetIterator
Full Name: Autodesk.Revit.DB.DocumentSetIterator
Description: An iterator to a set of documents.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new DocumentSetIterator()
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

[ENUM] DocumentType
Full Name: Autodesk.Revit.DB.DocumentType
Description: Types of Revit documents.
Inherits: Enum

  Values:
    - Project = 0
    - Family = 1
    - Template = 2
    - IFC = 3
    - BuildingComponent = 4
    - Other = 100

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DocumentValidation
Full Name: Autodesk.Revit.DB.DocumentValidation
Description: Utility functions with document validation

  METHODS:
    static bool CanDeleteElement(Document document, ElementId elementId)
      Description: Indicates if an element can be deleted.
      @document: The document.
      @elementId: The id of the element to check.
      Returns: True if the element can be deleted, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DocumentVersion
Full Name: Autodesk.Revit.DB.DocumentVersion
Description: This class uniquely identifies an edition of a given document.
Remarks: DocumentVersion consists of two parts - a GUID and an integer. The GUID is updated as new elements are created in the document, but it is not necessarily changed whenever any individual change is made to the document. The integer is updated when the document is saved.The GUID will change as changes are made to a model, so it should not be treated as a static value.This class does not contain any time information - you cannot compare two DocumentVersions and know which document is newer. It can be used to tell whether a document has changed since it was last inspected. See Autodesk::Revit::DB::BasicFileInfo::GetDocumentVersion
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfSaves { get; }
      Description: The number of times the document has been saved. The save number and GUID are both necessary to uniquely identify a document version.
    Guid VersionGUID { get; }
      Description: The GUID portion of the DocumentVersion. The GUID is updated when changes are made to the document, but may not update with every change to the document. The GUID and save number are both necessary to uniquely identify a document version.

  METHODS:
    void Dispose()
    bool IsEqual(DocumentVersion other)
      Description: Checks whether two DocumentVersions are identical. They are identical if both the GUID and number of saves are equal. If two DocumentVersions are identical, they come from the same document, with the same set of changes.
      @other: The DocumentVersion to compare to this DocumentVersion.
      Returns: True if the two DocumentVersions are equal. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] Domain
Full Name: Autodesk.Revit.DB.Domain
Description: Type of connector domain.
Inherits: Enum

  Values:
    - DomainUndefined = 0
    - DomainHvac = 1
    - DomainElectrical = 2
    - DomainPiping = 3
    - DomainCableTrayConduit = 4
    - DomainStructuralAnalytical = 5

--------------------------------------------------------------------------------

[ENUM] DoorEvacuationExitType
Full Name: Autodesk.Revit.DB.DoorEvacuationExitType
Description: An enumerated type listing the possible door evacuation types
Inherits: Enum

  Values:
    - ExteriorExit = 0
    - InteriorExit = 1
    - InteriorPassage = 2
    - None = 3

--------------------------------------------------------------------------------

[CLASS] DoubleArray
Full Name: Autodesk.Revit.DB.DoubleArray
Description: An array that contains doubles.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new DoubleArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    double Item { get; set; }
    int Size { get; }
      Description: Returns the number of doubles that are in the array.

  METHODS:
    void Append(ref double item)
    void Clear()
      Description: Removes every double from the array, rendering it empty.
    DoubleArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(ref double item, int index)
    DoubleArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DoubleArrayIterator
Full Name: Autodesk.Revit.DB.DoubleArrayIterator
Description: An iterator to an array of doubles.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new DoubleArrayIterator()
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

[CLASS] DoubleParameterValue
Full Name: Autodesk.Revit.DB.DoubleParameterValue
Description: A class that holds a Double value of a parameter element.
Inherits: ParameterValue

  CONSTRUCTORS:
    new DoubleParameterValue(double value)
      Description: Value constructor
    new DoubleParameterValue()
      Description: Default constructor

  PROPERTIES:
    double Value { get; set; }
      Description: The stored value

--------------------------------------------------------------------------------

[ENUM] DrawLayer
Full Name: Autodesk.Revit.DB.DrawLayer
Description: An enumerated type containing possible DrawLayer options.
Inherits: Enum

  Values:
    - Foreground = 0
    - Background = 1

--------------------------------------------------------------------------------

[ENUM] DuplicateTypeAction
Full Name: Autodesk.Revit.DB.DuplicateTypeAction
Description: This enumerated type defines the action to be taken when there are types with the same name being pasted.
Inherits: Enum

  Values:
    - UseDestinationTypes = 1
    - Abort = 2

--------------------------------------------------------------------------------

[CLASS] DuplicateTypeNamesHandlerArgs
Full Name: Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs
Description: A structure that provides information about an attempt to copy types with names that already exist in the destination document.
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The document that contains the types with duplicate names.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ICollection<ElementId> GetTypeIds()
      Description: Returns ids of the types with duplicate names.

--------------------------------------------------------------------------------

[CLASS] DWFExportOptions
Full Name: Autodesk.Revit.DB.DWFExportOptions
Description: DWF Export options.
Inherits: CADExportOptions

  CONSTRUCTORS:
    new DWFExportOptions()
      Description: Default constructor. Sets all options to their default values.

  PROPERTIES:
    bool CropBoxVisible { get; set; }
      Description: Whether to export crop box.
    bool ExportingAreas { get; set; }
      Description: Whether to also export areas and rooms' geometry.
    bool ExportObjectData { get; set; }
      Description: Whether to include properties associated with elements.
    ElementId ExportOnlyViewId { get; set; }
      Description: Only export the specified view.
    bool ExportTexture { get; set; }
      Description: Whether to export texture.
    DWFImageFormat ImageFormat { get; set; }
      Description: Controls the compression level of images embedded.
    DWFImageQuality ImageQuality { get; set; }
      Description: Image quality level when compressed raster format(JPEG) is used.
    bool MergedViews { get; set; }
      Description: Whether to merge all views in one file.
    ExportPaperFormat PaperFormat { get; set; }
      Description: Standard paper format.
    bool PortraitLayout { get; set; }
      Description: Paper orientation - Portrait/Landscape.
    bool StopOnError { get; set; }
      Description: Whether export process should stop when a view fails to export.

--------------------------------------------------------------------------------

[ENUM] DWFImageFormat
Full Name: Autodesk.Revit.DB.DWFImageFormat
Description: An enumerated type listing possible image format for DWF Export.
Inherits: Enum

  Values:
    - Lossless = 0
    - Lossy = 1

--------------------------------------------------------------------------------

[ENUM] DWFImageQuality
Full Name: Autodesk.Revit.DB.DWFImageQuality
Description: An enumerated type listing possible image quality for DWF Export.
Inherits: Enum

  Values:
    - Default = 10
    - Low = 11
    - Medium = 12
    - High = 13

--------------------------------------------------------------------------------

[CLASS] DWFImportOptions
Full Name: Autodesk.Revit.DB.DWFImportOptions
Description: The import options used by importing DWF or DWFx format file.
Implements: IDisposable

  CONSTRUCTORS:
    new DWFImportOptions(DWFImportOptions option)
      Description: Constructs a new instance of DWFImportOptions as a copy of the import options.
      @option: The options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new DWFImportOptions(IList<ElementId> views)
      Description: Constructs a new instance of DWFImportOptions with an array of imported sheet views.
      @views: These sheet views where DWF markups are imported.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<ElementId> GetSheetViews()
      Description: Get sheet views where DWF markups are imported.
      Returns: An array of sheet views
    void SetSheetViews(IList<ElementId> sheetViews)
      Description: Set sheet views where DWF markups are imported.
      @sheetViews: An array of imported sheet views.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DWFXExportOptions
Full Name: Autodesk.Revit.DB.DWFXExportOptions
Description: DWFX Export options.
Inherits: DWFExportOptions

  CONSTRUCTORS:
    new DWFXExportOptions()
      Description: Default constructor. Sets all options to their default values.

--------------------------------------------------------------------------------

[CLASS] DWGExportOptions
Full Name: Autodesk.Revit.DB.DWGExportOptions
Description: The export options used by exporting DWG format file.
Inherits: ACADExportOptions

  CONSTRUCTORS:
    new DWGExportOptions(DWGExportOptions option)
      Description: Constructs a new instance of DWGExportOptions as a copy of the export options.
      @option: The options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new DWGExportOptions()
      Description: Constructs a new instance of DWGExportOptions with default values of all properties.

  PROPERTIES:
    bool MergedViews { get; set; }
      Description: Whether to merge all views in one file (via XRefs). Default value is false for mergedViews.

  METHODS:
    static DWGExportOptions GetPredefinedOptions(Document document, string setup)
      Description: Returns an instance DWGExportOptions containing settings from a predefined export setup.
      @document: A Revit project document to retrieve the setup from.
      @setup: The name of a predefined export setup from the specified document.
      Returns: An instance of predefined DWGExportOptions, or if the name was not found.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DWGImportOptions
Full Name: Autodesk.Revit.DB.DWGImportOptions
Description: The import options used by importing DWG or DXF format file.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new DWGImportOptions(DWGImportOptions option)
      Description: Constructs a new instance of DWGImportOptions as a copy of the import options.
      @option: The options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new DWGImportOptions()
      Description: Constructs a new instance of DWGImportOptions with default values of all properties.

  METHODS:
    IList<int> GetLineWeights()
      Description: Gets array of line weights.
    void SetLineWeights(IList<int> lineWeight)
      Description: Set array of line weights.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DXFExportOptions
Full Name: Autodesk.Revit.DB.DXFExportOptions
Description: The export options used by exporting DXF format file.
Inherits: ACADExportOptions

  CONSTRUCTORS:
    new DXFExportOptions(DXFExportOptions option)
      Description: Constructs a new instance of DXFImportOptions as a copy of the export options.
      @option: The options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new DXFExportOptions()
      Description: Constructs a new instance of DXFImportOptions with default values of all properties.

  METHODS:
    static DXFExportOptions GetPredefinedOptions(Document document, string setup)
      Description: Returns an instance DXFExportOptions containing settings from a predefined export setup.
      @document: A Revit project document to retrieve the setup from.
      @setup: The name of a predefined export setup from the specified document.
      Returns: An instance of predefined DXFExportOptions, or if the name was not found.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

