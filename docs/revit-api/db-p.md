# Autodesk.Revit.DB (Types: P)

[ENUM] PageOrientationType
Full Name: Autodesk.Revit.DB.PageOrientationType

Description: An enumerated type listing all Page Orientation types of Print Setting
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Portrait = 0
    - Landscape = 1
    - Auto = 2


[CLASS] Panel
Full Name: Autodesk.Revit.DB.Panel

Description: This object represents a curtain panel.
Inherits: FamilyInstance
Implements: IDisposable

  PROPERTIES:
    bool Lockable { get; }
      Description: This property is used to know whether a panel can be locked.
    PanelType PanelType { get; set; }
      Description: The Panel style of this Panel.
    Transform Transform { get; }
      Description: This property is used to find the transform of a curtain panel within project.

  METHODS:
    ElementId FindHostPanel()
      Description: Finds the id of the host panel (i.e., wall) associated with this panel. If a host panel is present, then it is displayed instead of the curtain panel.
      Returns: Element id of the host panel associated with this panel. Otherwise, InvalidElementId is returned
    void GetRefGridLines(ref ElementId uGridLineId, ref ElementId vGridLineId)

--------------------------------------------------------------------------------


[CLASS] PanelType
Full Name: Autodesk.Revit.DB.PanelType

Description: An object that represents a curtain panel type.
Inherits: FamilySymbol
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] PanelTypeSet
Full Name: Autodesk.Revit.DB.PanelTypeSet

Description: A set that contains panel types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new PanelTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of panel types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every panel type from the set, rendering it empty.
    bool Contains(PanelType item)
      Description: Tests for the existence of a panel type within the set.
      @item: The panel type to be searched for.
      Returns: The Contains method returns True if the panel type is within the set, otherwise False.
    int Erase(PanelType item)
      Description: Removes a specified panel type from the set.
      @item: The panel type to be erased.
      Returns: The number of panel types that were erased from the set.
    PanelTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(PanelType item)
      Description: Insert the specified panel type into the set.
      @item: The panel type to be inserted into the set.
      Returns: Returns whether the panel type was inserted into the set.
    PanelTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PanelTypeSetIterator
Full Name: Autodesk.Revit.DB.PanelTypeSetIterator

Description: An iterator to a panel type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new PanelTypeSetIterator()

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


[ENUM] PaperPlacementType
Full Name: Autodesk.Revit.DB.PaperPlacementType

Description: An enumerated type listing all Paper Placement types of Print Setting.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Center = 0
    - LowerLeft = 1
    - LowerLeft = 1


[CLASS] PaperSize
Full Name: Autodesk.Revit.DB.PaperSize

Description: An object that represents a Paper Size of Print Setup within the Autodesk Revit project.
Remarks: This object derived from the APIObject base object.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    string Name { get; }
      Description: Retrieve the paper size name of current project.

--------------------------------------------------------------------------------


[CLASS] PaperSizeSet
Full Name: Autodesk.Revit.DB.PaperSizeSet

Description: A set that can contain any number of paper size objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new PaperSizeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(PaperSize item)
      Description: Tests for the existence of an item within the set.
      @item: The item to be searched for.
      Returns: The Contains method returns True if the item is within the set, otherwise False.
    int Erase(PaperSize item)
      Description: Removes a specified object from the set.
      @item: The item to be erased.
      Returns: The number of items that were erased from the set.
    PaperSizeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(PaperSize item)
      Description: Insert the specified item into the set.
      @item: The item to be inserted into the set.
      Returns: Returns whether the item was inserted into the set.
    PaperSizeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PaperSizeSetIterator
Full Name: Autodesk.Revit.DB.PaperSizeSetIterator

Description: An iterator to a set of paper size objects.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new PaperSizeSetIterator()

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


[CLASS] PaperSource
Full Name: Autodesk.Revit.DB.PaperSource

Description: An object that represents a Paper Source of Print Setup within the Autodesk Revit project.
Remarks: This object derived from the APIObject base object.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    string Name { get; }
      Description: Retrieve the paper source name of current project.

--------------------------------------------------------------------------------


[CLASS] PaperSourceSet
Full Name: Autodesk.Revit.DB.PaperSourceSet

Description: A set that can contain any number of paper source objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new PaperSourceSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(PaperSource item)
      Description: Tests for the existence of an item within the set.
      @item: The item to be searched for.
      Returns: The Contains method returns True if the item is within the set, otherwise False.
    int Erase(PaperSource item)
      Description: Removes a specified object from the set.
      @item: The item to be erased.
      Returns: The number of items that were erased from the set.
    PaperSourceSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(PaperSource item)
    PaperSourceSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PaperSourceSetIterator
Full Name: Autodesk.Revit.DB.PaperSourceSetIterator

Description: An iterator to a set of paper source objects.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new PaperSourceSetIterator()

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


[CLASS] Parameter
Full Name: Autodesk.Revit.DB.Parameter

Description: The parameter object contains the value data assigned to that parameter.
Remarks: The piece of data contained within the parameter can be either a Double, Integer, String or ElementId. The parameter object can be retrieved from any Element object using either a built in id, definition object or shared parameter guid. All Elements within Autodesk Revit contain Parameters. These are options that can be accessed in a generic fashion. Revit contains many built in parameter types but users and now developers, via the API, can add their own parameters in the form of shared parameters. The developer should become familiar with the Revit user interface for added and managing parameters and shared parameters before using this API. The user interface components can be found in the following locations: Element Properties dialog, Shared Parameters dialog (available from the File menu), Project Parameters dialog (available from the Settings menu), Family Types dialog (available from the Settings menu when editing a family). There are several relationships between the objects that make up the APIs exposure of parameters. The parameter object contains the data value. Parameter objects can be retrieved from Elements if you know its built-in id, its definition or its shared parameter guid. Each parameter has a definition. New parameters can be added to Elements by adding a ParameterBinding object to the Document object.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    Definition Definition { get; }
      Description: Returns the Definition object that describes the data type, name and other details of the parameter.
    Element Element { get; }
      Description: The element to which this parameter belongs.
    Guid GUID { get; }
      Description: The Guid for a shared parameter.
    bool HasValue { get; }
      Description: Identifies if the parameter has an assigned value.
    ElementId Id { get; }
      Description: The id of the parameter.
    bool IsReadOnly { get; }
      Description: Get the readonly property of the parameter.
    bool IsShared { get; }
      Description: Identifies if the parameter is a shared parameter.
    StorageType StorageType { get; }
      Description: Describes the type that is used internally within the parameter to store its value.
    bool UserModifiable { get; }
      Description: Indicates whether the interactive user can modify the value of this parameter.

  METHODS:
    double AsDouble()
      Description: Provides access to the double precision number within the parameter.
      Returns: The double value contained in the parameter.
    ElementId AsElementId()
      Description: Provides access to the Autodesk::Revit::DB::ElementId^ stored within the parameter.
      Returns: The Autodesk::Revit::DB::ElementId^ contained in the parameter.
    int AsInteger()
      Description: Provides access to the integer number within the parameter.
      Returns: The integer value contained in the parameter.
    void AssociateWithGlobalParameter(ElementId gpId)
      Description: Associates this parameter with a global parameter in the same document.
      @gpId: Id of a global parameter contained in this parameter's document
    string AsString()
      Description: Provides access to the string contents of the parameter.
      Returns: The string contained in the parameter.
    string AsValueString(FormatOptions formatOptions)
      Description: Get the parameter value as a string with units.
      @formatOptions: Options for formatting the string.
      Returns: The string that represents the parameter value.
    string AsValueString()
      Description: Get the parameter value as a string with units.
      Returns: The string that represents the parameter value.
    bool CanBeAssociatedWithGlobalParameter(ElementId gpId)
      Description: Tests whether this parameter can be associated with the given global parameter.
      @gpId: Id of a global parameter contained in this parameter's document
      Returns: True if this parameter can be associated with the given global parameter; False otherwise.
    bool CanBeAssociatedWithGlobalParameters()
      Description: Tests whether this parameter can be associated with any global parameter.
      Returns: True if the given parameter can be associated (is parametrizable); False otherwise.
    bool ClearValue()
      Description: Clears the parameter to its initial value.
      Returns: The ClearValue method will return True if the parameter was successfully cleared to its initial value, otherwise false.
    void DissociateFromGlobalParameter()
      Description: Dissociates this parameter from a global parameter.
    ElementId GetAssociatedGlobalParameter()
      Description: Returns a global parameter, if any, currently associated with this parameter.
      Returns: Id of a global parameter or InvalidElemetnId.
    ForgeTypeId GetTypeId()
      Description: Gets the identifier of the parameter.
    ForgeTypeId GetUnitTypeId()
      Description: Gets the identifier of the unit quantifying the parameter value.
      Returns: Identifier of the unit of the parameter.
    bool Set(ElementId value)
      Description: Sets the parameter to a new element id.
      @value: The new element id to which the parameter is to be set.
      Returns: The Set method will return True if the parameter was successfully set to the new value, otherwise false.
    bool Set(double value)
      Description: Sets the parameter to a new real number value.
      @value: The new double value to which the parameter is to be set.
      Returns: The Set method will return True if the parameter was successfully set to the new value, otherwise false.
    bool Set(int value)
      Description: Sets the parameter to a new integer value.
      @value: The new integer value to which the parameter is to be set.
      Returns: The Set method will return True if the parameter was successfully set to the new value, otherwise false.
    bool Set(string value)
      Description: Sets the parameter to a new string of text.
      @value: The new text value to which the parameter is to be set.
      Returns: The Set method will return True if the parameter was successfully set to the new value, otherwise false.
    static List<Parameter> SetMultiple(IList<Tuple<Parameter, ParameterValue>> values)
      Description: Sets multiple parameters to new values.
      @values: A list of pairs of parameters and their corresponding values.
      Returns: The list of parameters that were not set successfully, if any.
    bool SetValueString(string valueString)
      Description: Set the parameter value according to the input string.
      @valueString: The string that represents the parameter value.
      Returns: Indicates whether the parameter value is successfully set.

--------------------------------------------------------------------------------


[CLASS] ParameterDownloadOptions
Full Name: Autodesk.Revit.DB.ParameterDownloadOptions

Description: An option class used for downloading parameters from the Parameters Service.
Implements: IDisposable

  CONSTRUCTORS:
    new ParameterDownloadOptions(ISet<ElementId> categories, bool isInstance, bool visible, ForgeTypeId groupTypeId)
    new ParameterDownloadOptions()

  PROPERTIES:
    bool IsInstance { get; set; }
      Description: True if binding to Element instances, false if binding to Element types.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Visible { get; set; }
      Description: True if the parameter is visible to the user, false if it is hidden and accessible only via the API.

  METHODS:
    void Dispose()
    ISet<ElementId> GetCategories()
      Description: Get categories for binding.
    ForgeTypeId GetGroupTypeId()
      Description: Get properties palette group identifier.
    void SetCategories(ISet<ElementId> categories)
      Description: Set categories for binding.
    void SetGroupTypeId(ForgeTypeId groupTypeId)
      Description: Set properties palette group identifier.

--------------------------------------------------------------------------------


[CLASS] ParameterElement
Full Name: Autodesk.Revit.DB.ParameterElement

Description: An Element that stores a user-defined parameter.
Remarks: Revit supports both built-in and user-defined parameters. Built-in parameters ship with the application, and they are not stored in Revit documents. User-defined parameters are dynamically created, and they are stored in the documents that use them, wrapped in ParameterElement objects. Different subclasses of ParemeterElement represent different kinds of user-defined parameters.
Inherits: Element
Implements: IDisposable

  METHODS:
    InternalDefinition GetDefinition()
      Description: Get the definition representing this parameter element.
      Returns: The parameter.

--------------------------------------------------------------------------------


[CLASS] ParameterFilterElement
Full Name: Autodesk.Revit.DB.ParameterFilterElement

Description: Admits elements that satisfy two conditions: The element's category must be one of a certain set of allowed categories.The element must pass a series of filter rules.
Inherits: FilterElement
Implements: IDisposable

  METHODS:
    bool AllRuleParametersApplicable(ElementFilter elementFilter)
      Description: Checks that the parameters of the rules used by the given ElementFilter are valid for this filter's categories.
      @elementFilter: The ElementFilter containing the rules to check.
      Returns: True if all the parameters of the given rules are valid for this filter, otherwise false.
    static bool AllRuleParametersApplicable(Document aDocument, ICollection<ElementId> categories, ElementFilter elementFilter)
      Description: Checks that the parameters of the given ElementFilter (representing a combination of rules) are valid for the given set of categories.
      @aDocument: The document containing the filter, categories, and parameters involved in this validation.
      @categories: The set of categories against which to check the rule parameters.
      @elementFilter: The ElementFilter representing the combination of rules to check.
      Returns: True if all the parameters of the given rules are valid for this filter, otherwise false.
    void ClearRules()
      Description: Removes all rules from this filter.
    static ParameterFilterElement Create(Document aDocument, string name, ICollection<ElementId> categories, ElementFilter elementFilter)
      Description: Creates a new ParameterFilterElement in the given document.
      @aDocument: The document in which to create the ParameterFilterElement.
      @name: The user-visible name for the new ParameterFilterElement.
      @categories: The categories for the new ParameterFilterElement.
      @elementFilter: The rules for the new ParameterFilterElement, represented as an ElementFilter. ElementFilter is either an ElementParameterFilter or an ElementLogicalFilter representing a Boolean combination of ElementParameterFilters. In addition, we check that each ElementParameterFilter satisfies the following conditions: Its array of FilterRules is not empty and contains: Any number of FilterRules of type FilterValueRule, FilterInverseRule, and SharedParameterApplicableRule or Exactly one FilterCategoryRule containing only one category from categories stored by this ParameterFilterElement or Exactly two rules: the first one is a FilterCategoryRule containing only one category from categories stored by this ParameterFilterElement and the second one is a FilterRule of type FilterValueRule, FilterInverseRule, or SharedParameterApplicableRule. Note that cases in the second and third bullet are currently allowed only if the parent node of ElementParameterFilter is LogicalOrFilter.
      Returns: A pointer to the new ParameterFilterElement.
    static ParameterFilterElement Create(Document aDocument, string name, ICollection<ElementId> categories)
      Description: Creates a new ParameterFilterElement in the given document.
      @aDocument: The document in which to create the ParameterFilterElement.
      @name: The user-visible name for the new ParameterFilterElement.
      @categories: The categories for the new ParameterFilterElement.
      Returns: A pointer to the new ParameterFilterElement.
    static bool ElementFilterIsAcceptableForParameterFilterElement(Document aDocument, ISet<ElementId> categories, ElementFilter elementFilter)
      Description: Checks that an ElementFilter is acceptable for use in defining the filtering rules for a given list of categories (i.e., for view filtering).
      @aDocument: The document in which to create the ParameterFilterElement.
      @categories: The categories for the new ParameterFilterElement.
      @elementFilter: The ElementFilter to validate.
    bool ElementFilterIsAcceptableForParameterFilterElement(ElementFilter elementFilter)
      Description: Checks that an ElementFilter is acceptable for use in defining the filtering rules for a ParameterFilterElement (i.e., for view filtering).
      @elementFilter: The ElementFilter to validate.
      Returns: True if the ElementFilter is acceptable for use by an ParameterFilterElement, false if not.
    ICollection<ElementId> GetCategories()
      Description: Gets the categories admitted by this filter.
    ElementFilter GetElementFilter()
      Description: Returns an ElementFilter representing the combination of rules used by this filter.
      Returns: An ElementFilter representing the rules. It may be an ElementParameterFilter representing a conjunction of one or more FilterRules, or an ElementLogicalFilter (of type LogicalAndFilter or LogicalOrFilter) representing a logical combination of FilterRules, using AND/OR operations.
    ISet<ElementId> GetElementFilterParameters()
      Description: Retrieves a list of the parameters associated with each rule in the filter.
      Returns: A set of parameter identifiers.
    ISet<ElementId> GetElementFilterParametersForCategory(ElementId categoryId)
      Description: Retrieves a list of the parameters associated with all rules in the filter that are combined (using logical AND) with a FilterCategoryRule corresponding to single %categoryId%.
      @categoryId: The category for which parameters should be found.
      Returns: A set of parameter identifiers.
    void SetCategories(ICollection<ElementId> categories)
      Description: Sets the categories admitted by this filter.
    bool SetElementFilter(ElementFilter elementFilter)
      Description: Sets the rules that must be satisfied for a given element to pass this filter.
      @elementFilter: An ElementFilter representing the rules. It may be an ElementParameterFilter representing a conjunction of one or more FilterRules, or an ElementLogicalFilter (of type LogicalAndFilter or LogicalOrFilter) representing a logical combination of FilterRules, using AND/OR operations.
      Returns: Returns true if this ParameterFilterElement was changed, false if not. It will not be changed if the input rules are equivalent to the ParameterFilterElement's existing rules.

--------------------------------------------------------------------------------


[CLASS] ParameterFilterRuleFactory
Full Name: Autodesk.Revit.DB.ParameterFilterRuleFactory

Description: Contains functions that create appropriate FilterRule objects based on the parameters given.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static FilterRule CreateBeginsWithRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document begin with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      Returns: Created filter rule object.
    static FilterRule CreateBeginsWithRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document begin with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateContainsRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document contain a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      Returns: Created filter rule object.
    static FilterRule CreateContainsRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document contain a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateEndsWithRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document end with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      Returns: Created filter rule object.
    static FilterRule CreateEndsWithRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document end with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateEqualsRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether ElementId values from the document equal a certain value.
      @parameter: An ElementId-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateEqualsRule(ElementId parameter, int value)
      Description: Creates a filter rule that determines whether integer values from the document equal a certain value.
      @parameter: An integer-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateEqualsRule(ElementId parameter, double value, double epsilon)
      Description: Creates a filter rule that determines whether double-precision values from the document equal a certain value.
      @parameter: A double-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
      @epsilon: Defines the tolerance within which two values may be considered equal.
    static FilterRule CreateEqualsRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document equal a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      Returns: Created filter rule object.
    static FilterRule CreateEqualsRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document equal a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateGreaterOrEqualRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether ElementId values from the document are greater than or equal to a certain value.
      @parameter: An ElementId-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateGreaterOrEqualRule(ElementId parameter, int value)
      Description: Creates a filter rule that determines whether integer values from the document are greater than or equal to a certain value.
      @parameter: An integer-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateGreaterOrEqualRule(ElementId parameter, double value, double epsilon)
      Description: Creates a filter rule that determines whether double-precision values from the document are greater than or equal to a certain value.
      @parameter: A double-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
      @epsilon: Defines the tolerance within which two values may be considered equal.
    static FilterRule CreateGreaterOrEqualRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document are greater than or equal to a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      Returns: Created filter rule object.
    static FilterRule CreateGreaterOrEqualRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document are greater than or equal to a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateGreaterRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether ElementId values from the document are greater than a certain value.
      @parameter: An ElementId-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateGreaterRule(ElementId parameter, int value)
      Description: Creates a filter rule that determines whether integer values from the document are greater than a certain value.
      @parameter: An integer-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateGreaterRule(ElementId parameter, double value, double epsilon)
      Description: Creates a filter rule that determines whether double-precision values from the document are greater than a certain value.
      @parameter: A double-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
      @epsilon: Defines the tolerance within which two values may be considered equal.
    static FilterRule CreateGreaterRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document are greater than a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      Returns: Created filter rule object.
    static FilterRule CreateGreaterRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document are greater than a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateHasNoValueParameterRule(ElementId parameter)
      Description: Creates a filter rule that determines whether an element's parameter does not have a value.
      @parameter: The parameter to be evaluated by the filter.
    static FilterRule CreateHasValueParameterRule(ElementId parameter)
      Description: Creates a filter rule that determines whether an element's parameter has a value.
      @parameter: The parameter to be evaluated by the filter.
    static FilterRule CreateIsAssociatedWithGlobalParameterRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether a parameter is associated with a certain global parameter.
      @parameter: A parameter that can be associated with an existing global parameter of a compatible type.
      @value: The global parameter used to test the association.
    static FilterRule CreateIsNotAssociatedWithGlobalParameterRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether a parameter is not associated with a certain global parameter.
      @parameter: A parameter that can be associated with an existing global parameter of a compatible type.
      @value: The global parameter used to test the association.
    static FilterRule CreateLessOrEqualRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether ElementId values from the document are less than or equal to a certain value.
      @parameter: An ElementId-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateLessOrEqualRule(ElementId parameter, int value)
      Description: Creates a filter rule that determines whether integer values from the document are less than or equal to a certain value.
      @parameter: An integer-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateLessOrEqualRule(ElementId parameter, double value, double epsilon)
      Description: Creates a filter rule that determines whether double-precision values from the document are less than or equal to a certain value.
      @parameter: A double-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
      @epsilon: Defines the tolerance within which two values may be considered equal.
    static FilterRule CreateLessOrEqualRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document are less than or equal to a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      Returns: Created filter rule object.
    static FilterRule CreateLessOrEqualRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document are less than or equal to a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateLessRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether ElementId values from the document are less than a certain value.
      @parameter: An ElementId-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateLessRule(ElementId parameter, int value)
      Description: Creates a filter rule that determines whether integer values from the document are less than a certain value.
      @parameter: An integer-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateLessRule(ElementId parameter, double value, double epsilon)
      Description: Creates a filter rule that determines whether double-precision values from the document are less than a certain value.
      @parameter: A double-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
      @epsilon: Defines the tolerance within which two values may be considered equal.
    static FilterRule CreateLessRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document are less than a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      Returns: Created filter rule object.
    static FilterRule CreateLessRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document are less than a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateNotBeginsWithRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document do not begin with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      Returns: Created filter rule object.
    static FilterRule CreateNotBeginsWithRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document do not begin with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateNotContainsRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document do not contain a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      Returns: Created filter rule object.
    static FilterRule CreateNotContainsRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document do not contain a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateNotEndsWithRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document do not end with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      Returns: Created filter rule object.
    static FilterRule CreateNotEndsWithRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document do not end with a certain string value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value for which values from the document will be searched.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateNotEqualsRule(ElementId parameter, ElementId value)
      Description: Creates a filter rule that determines whether ElementId values from the document do not equal a certain value.
      @parameter: An ElementId-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateNotEqualsRule(ElementId parameter, int value)
      Description: Creates a filter rule that determines whether integer values from the document do not equal a certain value.
      @parameter: An integer-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
    static FilterRule CreateNotEqualsRule(ElementId parameter, double value, double epsilon)
      Description: Creates a filter rule that determines whether double-precision values from the document do not equal a certain value.
      @parameter: A double-typed parameter used to get values from the document for a given element.
      @value: The user-supplied value against which values from the document will be compared.
      @epsilon: Defines the tolerance within which two values may be considered equal.
    static FilterRule CreateNotEqualsRule(ElementId parameter, string value)
      Description: Creates a filter rule that determines whether strings from the document do not equal a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      Returns: Created filter rule object.
    static FilterRule CreateNotEqualsRule(ElementId parameter, string value, bool caseSensitive)
      Description: Creates a filter rule that determines whether strings from the document do not equal a certain value.
      @parameter: A string-typed parameter used to get values from the document for a given element.
      @value: The user-supplied string value against which values from the document will be compared.
      @caseSensitive: If true, the string comparison will be case-sensitive.
    static FilterRule CreateSharedParameterApplicableRule(string parameterName)
      Description: Creates a filter rule that tests elements for support of a shared parameter.
      @parameterName: The name of the parameter that elements must support to satisfy this rule.
    void Dispose()

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ParameterFilterUtilities
Full Name: Autodesk.Revit.DB.ParameterFilterUtilities

Description: Contains static utility functions for enumerating the categories and parameters that are available for use by ParameterFilterElement objects.

  METHODS:
    static ICollection<ElementId> GetAllFilterableCategories()
      Description: Returns the set of categories that may be used in a ParameterFilterElement.
      Returns: The set of all filterable categories.
    static ICollection<ElementId> GetFilterableParametersInCommon(Document aDoc, ICollection<ElementId> categories)
      Description: Returns the filterable parameters common to the given categories.
      @aDoc: The document containing the categories and parameters to query.
      @categories: The categories for which to determine the common parameters.
      Returns: The set of filterable parameters common to the given categories.
    static IList<ElementId> GetInapplicableParameters(Document aDoc, ICollection<ElementId> categories, IList<ElementId> parameters)
      Description: Returns the parameters that are not among the set of filterable parameters common to the given categories.
      @aDoc: The document containing the categories and parameters to query.
      @categories: The categories that define the set of possibly filterable parameters.
      @parameters: The parameters desired for use in a parameter filter.
      Returns: A list of parameters from the given array that are not valid for use in a parameter filter with the given categories.
    static bool IsParameterApplicable(Element element, ElementId parameter)
      Description: Used to determine whether the element supports the given parameter.
      @element: The element to query for support of the given parameter.
      @parameter: The parameter for which to query support.
      Returns: True if the element supports the given parameter, false otherwise.
    static ICollection<ElementId> RemoveUnfilterableCategories(ICollection<ElementId> categories)
      Description: Removes from the given set the categories that are not filterable.
      @categories: The set of categories to check.

--------------------------------------------------------------------------------


[CLASS] ParameterMap
Full Name: Autodesk.Revit.DB.ParameterMap

Description: A map that can contain a mapping of a parameter name (a String) to a parameter.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ParameterMap()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the map is empty.
    Parameter Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the map.

  METHODS:
    void Clear()
      Description: Removes every item from the map, rendering it empty.
    bool Contains(string key)
      Description: Tests for the existence of a key within the map.
      @key: The key to be searched for.
      Returns: The Contains method returns True if the key is within the map, otherwise False.
    int Erase(string key)
      Description: Removes a object with the specified key from the map.
      @key: The key of the item to be erased.
      Returns: The number of items that were erased from the map.
    ParameterMapIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    bool Insert(string key, Parameter item)
      Description: Insert the specified item with the specified key into the map.
      @key: The key to be used for inserting the item into the map.
      @item: The item to be inserted into the map.
      Returns: Returns whether the item was inserted into the map.
    ParameterMapIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the map.
      Returns: Returns a backward moving iterator to the map.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ParameterMapIterator
Full Name: Autodesk.Revit.DB.ParameterMapIterator

Description: An iterator to a map relating a parameter name (the key, a String) to a parameter.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ParameterMapIterator()

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.
    string Key { get; }
      Description: Retrieves the key that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the map.
    void Reset()
      Description: Bring the iterator back to the start of the map.

--------------------------------------------------------------------------------


[CLASS] ParameterSet
Full Name: Autodesk.Revit.DB.ParameterSet

Description: A set that contains parameters.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ParameterSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of parameters that are in the set.

  METHODS:
    void Clear()
      Description: Removes every parameter from the set, rendering it empty.
    bool Contains(Parameter item)
      Description: Tests for the existence of a parameter within the set.
      @item: The parameter to be searched for.
      Returns: The Contains method returns True if the parameter is within the set, otherwise False.
    int Erase(Parameter item)
      Description: Removes a specified parameter from the set.
      @item: The parameter to be erased.
      Returns: The number of parameters that were erased from the set.
    ParameterSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Parameter item)
      Description: Insert the specified parameter into the set.
      @item: The parameter to be inserted into the set.
      Returns: Returns whether the parameter was inserted into the set.
    ParameterSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ParameterSetIterator
Full Name: Autodesk.Revit.DB.ParameterSetIterator

Description: An iterator to a parameter set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ParameterSetIterator()

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


[ENUM] ParametersOrder
Full Name: Autodesk.Revit.DB.ParametersOrder

Description: The order of the parameters.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Ascending = 0
    - Descending = 1


[ABSTRACT CLASS] ParameterTypeId
Full Name: Autodesk.Revit.DB.ParameterTypeId

  PROPERTIES:
    static ForgeTypeId ActualMaxRidgeHeightParam { get; }
      Description: "Maximum Ridge Height"
    static ForgeTypeId AlignmentStationLabelDistance { get; }
      Description: "Distance": Currently not in use
    static ForgeTypeId AlignmentStationLabelIncludeStation { get; }
      Description: "Include Station"
    static ForgeTypeId AlignmentStationLabelIndStation { get; }
      Description: "Station Indicator"
    static ForgeTypeId AlignmentStationLabelSetEndStation { get; }
      Description: "Alignment Label Set End Station"
    static ForgeTypeId AlignmentStationLabelSetInterval { get; }
      Description: "Alignment Station Label Set Interval": The text is not used directly anywhere in the UI, instead the XAML specifies its own string for the value's label.
    static ForgeTypeId AlignmentStationLabelSetOffset { get; }
      Description: "Alignment Station Label Set Offset": The text is not used directly anywhere in the UI, instead the XAML specifies its own string for the value's label.
    static ForgeTypeId AlignmentStationLabelSetStartStation { get; }
      Description: "Alignment Label Set Start Station"
    static ForgeTypeId AlignmentStationLabelStationValue { get; }
      Description: "Station Value"
    static ForgeTypeId AlignmentStationPrefix { get; }
      Description: "Station Prefix"
    static ForgeTypeId AlignmentStationSuffix { get; }
      Description: "Station Suffix"
    static ForgeTypeId AllGridRotationForDivisionRule { get; }
      Description: "All Grid Rotation"
    static ForgeTypeId AllModelDescription { get; }
      Description: "Description"
    static ForgeTypeId AllModelImage { get; }
      Description: "Image"
    static ForgeTypeId AllModelInstanceComments { get; }
      Description: "Comments"
    static ForgeTypeId AllModelManufacturer { get; }
      Description: "Manufacturer"
    static ForgeTypeId AllModelModel { get; }
      Description: "Model"
    static ForgeTypeId AllModelTypeComments { get; }
      Description: "Type Comments"
    static ForgeTypeId AllModelTypeImage { get; }
      Description: "Type Image"
    static ForgeTypeId AllModelUrl { get; }
      Description: "URL"
    static ForgeTypeId AllowAutoEmbed { get; }
      Description: "Automatically Embed"
    static ForgeTypeId AllowMultipleSelection { get; }
      Description: "Allow Multiple Selection": This is used by the UI to allow selection of multiple elements.
    static ForgeTypeId AlternateUnits { get; }
      Description: "Alternate Units"
    static ForgeTypeId AlternateUnitsPrefix { get; }
      Description: "Alternate Units Prefix"
    static ForgeTypeId AlternateUnitsSuffix { get; }
      Description: "Alternate Units Suffix"
    static ForgeTypeId AlwaysZeroLength { get; }
      Description: "Base Offset"
    static ForgeTypeId AnalyticalAbsorptance { get; }
      Description: "Absorptance"
    static ForgeTypeId AnalyticalAdjacentSpace { get; }
      Description: "Adjacent Analytical Space"
    static ForgeTypeId AnalyticalDefineThermalPropertiesBy { get; }
      Description: "Define Thermal Properties by"
    static ForgeTypeId AnalyticalElementHasAssociation { get; }
      Description: "Has Association": Used for Analytical Member, Analytical Panel, Structural Columns, Structural Framing, Floors, Walls, Structural Foundation
    static ForgeTypeId AnalyticalElementPhysicalAsset { get; }
      Description: "Physical Material Asset": Used for Analytical Elements.
    static ForgeTypeId AnalyticalElementStructuralRole { get; }
      Description: "Structural Role": Used for Analytical Elements
    static ForgeTypeId AnalyticalGeometryIsValid { get; }
      Description: "Analytical Model Correct"
    static ForgeTypeId AnalyticalHeatTransferCoefficient { get; }
      Description: "Heat Transfer Coefficient (U)"
    static ForgeTypeId AnalyticalLinkReleaseRotationX { get; }
      Description: "X Rotation"
    static ForgeTypeId AnalyticalLinkReleaseRotationY { get; }
      Description: "Y Rotation"
    static ForgeTypeId AnalyticalLinkReleaseRotationZ { get; }
      Description: "Z Rotation"
    static ForgeTypeId AnalyticalLinkReleaseTranslationX { get; }
      Description: "X Translation"
    static ForgeTypeId AnalyticalLinkReleaseTranslationY { get; }
      Description: "Y Translation"
    static ForgeTypeId AnalyticalLinkReleaseTranslationZ { get; }
      Description: "Z Translation"
    static ForgeTypeId AnalyticalMemberForceEndAllNonZero { get; }
      Description: "All non 0 forces at end"
    static ForgeTypeId AnalyticalMemberForceEndFx { get; }
      Description: "End Fx"
    static ForgeTypeId AnalyticalMemberForceEndFy { get; }
      Description: "End Fy"
    static ForgeTypeId AnalyticalMemberForceEndFz { get; }
      Description: "End Fz"
    static ForgeTypeId AnalyticalMemberForceEndMx { get; }
      Description: "End Mx"
    static ForgeTypeId AnalyticalMemberForceEndMy { get; }
      Description: "End My"
    static ForgeTypeId AnalyticalMemberForceEndMz { get; }
      Description: "End Mz"
    static ForgeTypeId AnalyticalMemberForceStartAllNonZero { get; }
      Description: "All non 0 forces at start"
    static ForgeTypeId AnalyticalMemberForceStartFx { get; }
      Description: "Start Fx"
    static ForgeTypeId AnalyticalMemberForceStartFy { get; }
      Description: "Start Fy"
    static ForgeTypeId AnalyticalMemberForceStartFz { get; }
      Description: "Start Fz"
    static ForgeTypeId AnalyticalMemberForceStartMx { get; }
      Description: "Start Mx"
    static ForgeTypeId AnalyticalMemberForceStartMy { get; }
      Description: "Start My"
    static ForgeTypeId AnalyticalMemberForceStartMz { get; }
      Description: "Start Mz"
    static ForgeTypeId AnalyticalMemberRotation { get; }
      Description: "Cross-Section Rotation": Used for Analytical Member
    static ForgeTypeId AnalyticalMemberSectionType { get; }
      Description: "Section Type": The id of the type from the structural Family assigned to the analytical member.
    static ForgeTypeId AnalyticalModelArea { get; }
      Description: "Area": The Area of Analytical Model
    static ForgeTypeId AnalyticalModelBaseAlignmentMethod { get; }
      Description: "Base Alignment Method"
    static ForgeTypeId AnalyticalModelBaseExtensionMethod { get; }
      Description: "Base Extension Method"
    static ForgeTypeId AnalyticalModelBaseYProjection { get; }
      Description: "Base y Projection"
    static ForgeTypeId AnalyticalModelBaseZProjection { get; }
      Description: "Base z Projection"
    static ForgeTypeId AnalyticalModelCodeChecking { get; }
      Description: "Code Checking": Used for Analytical wall, Analytical beam, Analytical column, Analytical floor, Analytical wall foundations, Analytical isolated foundations, Analytical foundations slab, Anaytical brace
    static ForgeTypeId AnalyticalModelColumnBaseExtension { get; }
      Description: "Base x Projection"
    static ForgeTypeId AnalyticalModelColumnTopExtension { get; }
      Description: "Top x Projection"
    static ForgeTypeId AnalyticalModelEndAlignmentMethod { get; }
      Description: "End Alignment Method"
    static ForgeTypeId AnalyticalModelEndProjectionOrthogonal { get; }
      Description: "End Projection Orthogonal"
    static ForgeTypeId AnalyticalModelEndYProjection { get; }
      Description: "End y Projection"
    static ForgeTypeId AnalyticalModelEndZProjection { get; }
      Description: "End z Projection"
    static ForgeTypeId AnalyticalModelFloorAlignmentMethod { get; }
      Description: "Alignment Method"
    static ForgeTypeId AnalyticalModelFloorProjection { get; }
      Description: "z Projection"
    static ForgeTypeId AnalyticalModelFoundationsMark { get; }
      Description: "Foundation Number": Used for isolated, wall foundations
    static ForgeTypeId AnalyticalModelLength { get; }
      Description: "Length": The length of Analytical Model
    static ForgeTypeId AnalyticalModelManuallyAdjusted { get; }
      Description: "Manually Adjusted"
    static ForgeTypeId AnalyticalModelNodesMark { get; }
      Description: "Node Number": Used for nodes
    static ForgeTypeId AnalyticalModelPerimeter { get; }
      Description: "Perimeter": The Perimeter of Analytical Model
    static ForgeTypeId AnalyticalModelPhysicalType { get; }
      Description: "Family Type": the Family Type of the physical element associated with the Analytical Model
    static ForgeTypeId AnalyticalModelRotation { get; }
      Description: "Cross-Section Rotation": The rotation of Analytical Model
    static ForgeTypeId AnalyticalModelSketchAlignmentMethod { get; }
      Description: "Alignment Method"
    static ForgeTypeId AnalyticalModelSketchProjection { get; }
      Description: "In-Plane Projection"
    static ForgeTypeId AnalyticalModelStartAlignmentMethod { get; }
      Description: "Start Alignment Method"
    static ForgeTypeId AnalyticalModelStartProjectionOrthogonal { get; }
      Description: "Start Projection Orthogonal"
    static ForgeTypeId AnalyticalModelStartYProjection { get; }
      Description: "Start y Projection"
    static ForgeTypeId AnalyticalModelStartZProjection { get; }
      Description: "Start z Projection"
    static ForgeTypeId AnalyticalModelStickElementsMark { get; }
      Description: "Member Number": Used for beams, braces, columns
    static ForgeTypeId AnalyticalModelSurfaceElementsMark { get; }
      Description: "Surface Number": Used for floors, slabs, walls
    static ForgeTypeId AnalyticalModelTopAlignmentMethod { get; }
      Description: "Top Alignment Method"
    static ForgeTypeId AnalyticalModelTopExtensionMethod { get; }
      Description: "Top Extension Method"
    static ForgeTypeId AnalyticalModelTopYProjection { get; }
      Description: "Top y Projection"
    static ForgeTypeId AnalyticalModelTopZProjection { get; }
      Description: "Top z Projection"
    static ForgeTypeId AnalyticalModelWallAlignmentMethod { get; }
      Description: "Alignment Method"
    static ForgeTypeId AnalyticalModelWallBaseProjection { get; }
      Description: "Base y Projection"
    static ForgeTypeId AnalyticalModelWallProjection { get; }
      Description: "z Projection"
    static ForgeTypeId AnalyticalModelWallTopProjection { get; }
      Description: "Top y Projection"
    static ForgeTypeId AnalyticalNodeCanBeHosted { get; }
      Description: "Can Be Hosted": Specifies of the Analytical Node can be hosted or not.
    static ForgeTypeId AnalyticalNodeConnectionStatus { get; }
      Description: "Connection Status"
    static ForgeTypeId AnalyticalNodeType { get; }
      Description: "Node Type": Specifies the type of the Analytical Node: hosted or not.
    static ForgeTypeId AnalyticalPanelThickness { get; }
      Description: "Thickness": Used for Analytical Panel
    static ForgeTypeId AnalyticalRoughness { get; }
      Description: "Roughness"
    static ForgeTypeId AnalyticalSolarHeatGainCoefficient { get; }
      Description: "Solar Heat Gain Coefficient"
    static ForgeTypeId AnalyticalSpace { get; }
      Description: "Analytical Space"
    static ForgeTypeId AnalyticalSurface { get; }
      Description: "Analytical Surface"
    static ForgeTypeId AnalyticalThermalMass { get; }
      Description: "Thermal Mass"
    static ForgeTypeId AnalyticalThermalResistance { get; }
      Description: "Thermal Resistance (R)"
    static ForgeTypeId AnalyticalVisualLightTransmittance { get; }
      Description: "Visual Light Transmittance"
    static ForgeTypeId AnalyticalZone { get; }
      Description: "Analytical Zone"
    static ForgeTypeId AnalyticalZoneName { get; }
      Description: "Name"
    static ForgeTypeId AnalyticConstruction { get; }
      Description: "Analytic Construction"
    static ForgeTypeId AnalyticConstructionGbxmlTypeid { get; }
      Description: "Construction Type Id"
    static ForgeTypeId AnalyticConstructionLookupTable { get; }
      Description: "Analytic Construction"
    static ForgeTypeId AnyPatternIdParam { get; }
      Description: "Fill Pattern"
    static ForgeTypeId AnyPatternIdParamNoNo { get; }
      Description: "Fill Pattern"
    static ForgeTypeId ArcCenterMark { get; }
      Description: "Center Marks"
    static ForgeTypeId ArcElemFixKeepConcentric { get; }
      Description: "Keep Concentric"
    static ForgeTypeId ArcLeaderParam { get; }
      Description: "Arc Leaders"
    static ForgeTypeId ArcWallCntrMrkVisible { get; }
      Description: "Center Mark Visible"
    static ForgeTypeId AreaSchemeId { get; }
      Description: "Area Scheme Id"
    static ForgeTypeId AreaSchemeName { get; }
      Description: "Name"
    static ForgeTypeId AreaType { get; }
      Description: "Area Type"
    static ForgeTypeId AreaTypeText { get; }
      Description: "Area Type"
    static ForgeTypeId ArrowCentered { get; }
      Description: "Tick Mark Centered"
    static ForgeTypeId ArrowClosed { get; }
      Description: "Arrow Closed"
    static ForgeTypeId ArrowFilled { get; }
      Description: "Fill Tick"
    static ForgeTypeId ArrowheadEndAtRiser { get; }
      Description: "End at Riser"
    static ForgeTypeId ArrowheadType { get; }
      Description: "Arrowhead Type"
    static ForgeTypeId ArrowSize { get; }
      Description: "Tick Size"
    static ForgeTypeId ArrowType { get; }
      Description: "Arrow Style"
    static ForgeTypeId AssemblyName { get; }
      Description: "Assembly Name"
    static ForgeTypeId AssemblyNamingCategory { get; }
      Description: "Naming Category"
    static ForgeTypeId AssemblyPrecastFreeze { get; }
      Description: "Disable Precast Updates"
    static ForgeTypeId AssignTemplateOnViewCreation { get; }
      Description: "New views are dependent on template"
    static ForgeTypeId AssociatedLevel { get; }
      Description: "Associated Level": The level associated with this cell.
    static ForgeTypeId AssociatedLevelOffset { get; }
      Description: "Associated Level Offset": The offset from the associated level.
    static ForgeTypeId AutoJoinCondition { get; }
      Description: "Join Condition"
    static ForgeTypeId AutoJoinConditionWall { get; }
      Description: "Join Condition"
    static ForgeTypeId AutoMullionBorder1Grid1 { get; }
      Description: "Border 1 Type"
    static ForgeTypeId AutoMullionBorder1Grid2 { get; }
      Description: "Border 1 Type"
    static ForgeTypeId AutoMullionBorder1Horiz { get; }
      Description: "Border 1 Type"
    static ForgeTypeId AutoMullionBorder1Vert { get; }
      Description: "Border 1 Type"
    static ForgeTypeId AutoMullionBorder2Grid1 { get; }
      Description: "Border 2 Type"
    static ForgeTypeId AutoMullionBorder2Grid2 { get; }
      Description: "Border 2 Type"
    static ForgeTypeId AutoMullionBorder2Horiz { get; }
      Description: "Border 2 Type"
    static ForgeTypeId AutoMullionBorder2Vert { get; }
      Description: "Border 2 Type"
    static ForgeTypeId AutoMullionInteriorGrid1 { get; }
      Description: "Interior Type"
    static ForgeTypeId AutoMullionInteriorGrid2 { get; }
      Description: "Interior Type"
    static ForgeTypeId AutoMullionInteriorHoriz { get; }
      Description: "Interior Type"
    static ForgeTypeId AutoMullionInteriorVert { get; }
      Description: "Interior Type"
    static ForgeTypeId AutoPanel { get; }
      Description: "Curtain Panel"
    static ForgeTypeId AutoPanelWall { get; }
      Description: "Curtain Panel"
    static ForgeTypeId Azimuth { get; }
      Description: "Azimuth"
    static ForgeTypeId BackgroundDraftPatternIdParam { get; }
      Description: "Background Fill Pattern"
    static ForgeTypeId BackgroundPatternColorParam { get; }
      Description: "Background Pattern Color"
    static ForgeTypeId BaselineDimOffset { get; }
      Description: "Baseline Offset"
    static ForgeTypeId BasepointAngletonParam { get; }
      Description: "Angle to True North"
    static ForgeTypeId BasepointEastwestParam { get; }
      Description: "E/W"
    static ForgeTypeId BasepointElevationParam { get; }
      Description: "Elev"
    static ForgeTypeId BasepointLatitudeParam { get; }
      Description: "Lat"
    static ForgeTypeId BasepointLongitudeParam { get; }
      Description: "Lon"
    static ForgeTypeId BasepointNorthsouthParam { get; }
      Description: "N/S"
    static ForgeTypeId BeamHJustification { get; }
      Description: "Lateral Justification"
    static ForgeTypeId BeamSystem3dParam { get; }
      Description: "3D"
    static ForgeTypeId BeamSystemTagInstParamAngle { get; }
      Description: "Beam System Tag Direction"
    static ForgeTypeId BeamSystemTagParamLeft { get; }
      Description: "Left"
    static ForgeTypeId BeamSystemTagParamRight { get; }
      Description: "Right"
    static ForgeTypeId BeamVJustification { get; }
      Description: "z-Direction Justification"
    static ForgeTypeId BeamVJustificationOtherValue { get; }
      Description: "z-Direction Offset Value"
    static ForgeTypeId BendingDetailAngularDimensionTextPosition { get; }
      Description: "Angle Text Position"
    static ForgeTypeId BendingDetailDetailLevel { get; }
      Description: "Detail Level"
    static ForgeTypeId BendingdetailPosition { get; }
      Description: "Bending Detail Position"
    static ForgeTypeId BendingDetailRepresentationFor3dBars { get; }
      Description: "View for 3D Shape"
    static ForgeTypeId BendingDetailSegmentLengthDimensionTextPosition { get; }
      Description: "Dimension Text Position"
    static ForgeTypeId BendingDetailSegmentRepresentation { get; }
      Description: "Representation"
    static ForgeTypeId BendingDetailTypeAngularDimensionOffset { get; }
      Description: "Angular Dimension Offset"
    static ForgeTypeId BendingDetailTypeAngularDimensionsEnabled { get; }
      Description: "Angular Dimensions"
    static ForgeTypeId BendingDetailTypeAngularDimensionsForHooksEnabled { get; }
      Description: "Hook Angles"
    static ForgeTypeId BendingDetailTypeAngularDimensionsMeasurement { get; }
      Description: "Angle Measurement"
    static ForgeTypeId BendingDetailTypeAngularDimensionTypeId { get; }
      Description: "Angular Dimension Style"
    static ForgeTypeId BendingDetailTypeBendDiameterDimensionsEnabled { get; }
      Description: "Bend Diameter Dimensions"
    static ForgeTypeId BendingDetailTypeBendDiameterDimensionsForHooksEnabled { get; }
      Description: "Hook Bends"
    static ForgeTypeId BendingDetailTypeBendDiameterDimensionsForSegmentsEnabled { get; }
      Description: "Segment Bends"
    static ForgeTypeId BendingDetailTypeDiameterDimensionTypeId { get; }
      Description: "Diameter Dimension Style"
    static ForgeTypeId BendingDetailTypeOrthogonalAndOverallDimesionsEnabled { get; }
      Description: "Other Dimensions"
    static ForgeTypeId BendingDetailTypeRadialDimensionTypeId { get; }
      Description: "Radial Dimension Style"
    static ForgeTypeId BendingDetailTypeSchematicHeight { get; }
      Description: "Height"
    static ForgeTypeId BendingDetailTypeSchematicWidth { get; }
      Description: "Width"
    static ForgeTypeId BendingDetailTypeSegmentLengthDimensionsEnabled { get; }
      Description: "Segment Length Dimensions"
    static ForgeTypeId BendingDetailTypeSegmentLengthDimensionsForHooksEnabled { get; }
      Description: "Hook Lengths"
    static ForgeTypeId BendingDetailTypeSegmentLengthDimensionsOffset { get; }
      Description: "Dimension Offset"
    static ForgeTypeId BendingDetailTypeSegmentLengthDimensionTypeId { get; }
      Description: "Linear Dimension Style"
    static ForgeTypeId BendingDetailTypeSegmentLengthsDisplayOption { get; }
      Description: "Straight Segment Lengths"
    static ForgeTypeId BendingDetailTypeSegmentLengthsForArcsDisplayOption { get; }
      Description: "Arc Segment Lengths"
    static ForgeTypeId BendingDetailTypeShowAngularDimensionsFor { get; }
      Description: "Show for Angles"
    static ForgeTypeId BendingDetailTypeShowBarBendingUsing { get; }
      Description: "Dimension Type"
    static ForgeTypeId BendingDetailTypeTagTypeId { get; }
      Description: "Tag Type"
    static ForgeTypeId BendingDetailVaryingRebarDimension { get; }
      Description: "Varying Rebar Set Dimensions"
    static ForgeTypeId BentFabricParamBendDirection { get; }
      Description: "Bend Direction": Direction in which FabricSheet is bent.
    static ForgeTypeId BentFabricParamLongitudinalCutLength { get; }
      Description: "Longitudinal Cut Length": Bent fabric longitudinal cut length.
    static ForgeTypeId BentFabricParamStraightWiresLocation { get; }
      Description: "Straight Wires Location": Location of straight wires in a bent fabric.
    static ForgeTypeId BlendDepthParam { get; }
      Description: "Depth"
    static ForgeTypeId BlendEndParam { get; }
      Description: "Second End"
    static ForgeTypeId BlendStartParam { get; }
      Description: "First End"
    static ForgeTypeId BoundaryAreaRestraintX { get; }
      Description: "X Spring Modulus"
    static ForgeTypeId BoundaryAreaRestraintY { get; }
      Description: "Y Spring Modulus"
    static ForgeTypeId BoundaryAreaRestraintZ { get; }
      Description: "Z Spring Modulus"
    static ForgeTypeId BoundaryBearing { get; }
      Description: "Bearing"
    static ForgeTypeId BoundaryConditionsIsExt { get; }
      Description: "Is Boundary Conditions External?"
    static ForgeTypeId BoundaryConditionsType { get; }
      Description: "Boundary Conditions Type"
    static ForgeTypeId BoundaryDirectionRotX { get; }
      Description: "X Rotation"
    static ForgeTypeId BoundaryDirectionRotY { get; }
      Description: "Y Rotation"
    static ForgeTypeId BoundaryDirectionRotZ { get; }
      Description: "Z Rotation"
    static ForgeTypeId BoundaryDirectionX { get; }
      Description: "X Translation"
    static ForgeTypeId BoundaryDirectionY { get; }
      Description: "Y Translation"
    static ForgeTypeId BoundaryDirectionZ { get; }
      Description: "Z Translation"
    static ForgeTypeId BoundaryDistance { get; }
      Description: "Distance"
    static ForgeTypeId BoundaryLinearRestraintRotX { get; }
      Description: "X Spring Modulus"
    static ForgeTypeId BoundaryLinearRestraintX { get; }
      Description: "X Spring Modulus"
    static ForgeTypeId BoundaryLinearRestraintY { get; }
      Description: "Y Spring Modulus"
    static ForgeTypeId BoundaryLinearRestraintZ { get; }
      Description: "Z Spring Modulus"
    static ForgeTypeId BoundaryParamPreset { get; }
      Description: "State"
    static ForgeTypeId BoundaryParamPresetArea { get; }
      Description: "State"
    static ForgeTypeId BoundaryParamPresetLinear { get; }
      Description: "State"
    static ForgeTypeId BoundaryRadius { get; }
      Description: "Radius"
    static ForgeTypeId BoundaryRestraintRotX { get; }
      Description: "X Spring Modulus"
    static ForgeTypeId BoundaryRestraintRotY { get; }
      Description: "Y Spring Modulus"
    static ForgeTypeId BoundaryRestraintRotZ { get; }
      Description: "Z Spring Modulus"
    static ForgeTypeId BoundaryRestraintX { get; }
      Description: "X Spring Modulus"
    static ForgeTypeId BoundaryRestraintY { get; }
      Description: "Y Spring Modulus"
    static ForgeTypeId BoundaryRestraintZ { get; }
      Description: "Z Spring Modulus"
    static ForgeTypeId BoundaryXRotationFixed { get; }
      Description: "X Rotation - Fixed"
    static ForgeTypeId BoundaryXRotationSpring { get; }
      Description: "X Rotation - Spring"
    static ForgeTypeId BoundaryXTranslationFixed { get; }
      Description: "X Translation - Fixed"
    static ForgeTypeId BoundaryXTranslationSpring { get; }
      Description: "X Translation - Spring"
    static ForgeTypeId BoundaryYRotationFixed { get; }
      Description: "Y Rotation - Fixed"
    static ForgeTypeId BoundaryYRotationSpring { get; }
      Description: "Y Rotation - Spring"
    static ForgeTypeId BoundaryYTranslationFixed { get; }
      Description: "Y Translation - Fixed"
    static ForgeTypeId BoundaryYTranslationSpring { get; }
      Description: "Y Translation - Spring"
    static ForgeTypeId BoundaryZRotationFixed { get; }
      Description: "Z Rotation - Fixed"
    static ForgeTypeId BoundaryZRotationSpring { get; }
      Description: "Z Rotation - Spring"
    static ForgeTypeId BoundaryZTranslationFixed { get; }
      Description: "Z Translation - Fixed"
    static ForgeTypeId BoundaryZTranslationSpring { get; }
      Description: "Z Translation - Spring"
    static ForgeTypeId BrOrgFilter { get; }
      Description: "Filter"
    static ForgeTypeId BrOrgFolders { get; }
      Description: "Folders"
    static ForgeTypeId BuildingClosingTimeParam { get; }
      Description: "Closing Time"
    static ForgeTypeId BuildingCurveGstyle { get; }
      Description: "Line Style"
    static ForgeTypeId BuildingCurveGstylePlusInvisible { get; }
      Description: "Subcategory"
    static ForgeTypeId BuildingOpeningTimeParam { get; }
      Description: "Opening Time"
    static ForgeTypeId BuildingpadHeightabovelevelParam { get; }
      Description: "Height Offset From Level"
    static ForgeTypeId BuildingpadThickness { get; }
      Description: "Thickness"
    static ForgeTypeId BuildingUnoccupiedCoolingSetPointParam { get; }
      Description: "Unoccupied Cooling Set Point"
    static ForgeTypeId BuilidingPadStructureIdParam { get; }
      Description: "Structure"
    static ForgeTypeId CabletrayMinbendmultiplierParam { get; }
      Description: "Bend Radius Multiplier"
    static ForgeTypeId CalloutAttrHeadTag { get; }
      Description: "Callout Head"
    static ForgeTypeId CalloutCornerSheetRadius { get; }
      Description: "Corner Radius"
    static ForgeTypeId CalloutSyncronizeBoundOffsetFar { get; }
      Description: "Far Clip Settings"
    static ForgeTypeId CalloutTag { get; }
      Description: "Callout Tag"
    static ForgeTypeId CeilingAttrDefaultHeightParam { get; }
      Description: "Default Height above level"
    static ForgeTypeId CeilingAttrPatternParam { get; }
      Description: "Pattern"
    static ForgeTypeId CeilingAttrSpacing1Param { get; }
      Description: "Spacing Axis 1"
    static ForgeTypeId CeilingAttrSpacing2Param { get; }
      Description: "Spacing Axis 2"
    static ForgeTypeId CeilingAttrSystemnameParam { get; }
      Description: "System"
    static ForgeTypeId CeilingHasThicknessParam { get; }
      Description: "Has Thickness"
    static ForgeTypeId CeilingHeightabovelevelParam { get; }
      Description: "Height Offset From Level"
    static ForgeTypeId CeilingStructureIdParam { get; }
      Description: "Structure"
    static ForgeTypeId CeilingThickness { get; }
      Description: "Thickness"
    static ForgeTypeId CeilingThicknessParam { get; }
      Description: "Thickness"
    static ForgeTypeId CenterMarkSize { get; }
      Description: "Center Mark Size"
    static ForgeTypeId CircMullionRadius { get; }
      Description: "Radius"
    static ForgeTypeId CircuitLoadClassificationAbbreviationParam { get; }
      Description: "Load Classification Abbreviation"
    static ForgeTypeId CircuitLoadClassificationParam { get; }
      Description: "Load Classification"
    static ForgeTypeId CircuitPhaseParam { get; }
      Description: "Phase Label"
    static ForgeTypeId CircuitWaysParam { get; }
      Description: "Ways"
    static ForgeTypeId CircularFramingDiameter { get; }
      Description: "Circular Diameter"
    static ForgeTypeId ClearCover { get; }
      Description: "Rebar Cover"
    static ForgeTypeId ClearCoverBottom { get; }
      Description: "Rebar Cover - Bottom Face"
    static ForgeTypeId ClearCoverExterior { get; }
      Description: "Rebar Cover - Exterior Face"
    static ForgeTypeId ClearCoverInterior { get; }
      Description: "Rebar Cover - Interior Face"
    static ForgeTypeId ClearCoverOther { get; }
      Description: "Rebar Cover - Other Faces"
    static ForgeTypeId ClearCoverTop { get; }
      Description: "Rebar Cover - Top Face"
    static ForgeTypeId ClientName { get; }
      Description: "Client Name"
    static ForgeTypeId ClineSubcategory { get; }
      Description: "Subcategory"
    static ForgeTypeId CoarseScaleFillPatternColor { get; }
      Description: "Coarse Scale Fill Color"
    static ForgeTypeId CoarseScaleFillPatternIdParam { get; }
      Description: "Coarse Scale Fill Pattern"
    static ForgeTypeId ColorFillFilteredParam { get; }
      Description: "Values Displayed"
    static ForgeTypeId ColorFillSwatchHeightParam { get; }
      Description: "Swatch Height"
    static ForgeTypeId ColorFillSwatchWidthParam { get; }
      Description: "Swatch Width"
    static ForgeTypeId ColorSchemeLocation { get; }
      Description: "Color Scheme Location"
    static ForgeTypeId ColumnBaseAttachCutParam { get; }
      Description: "Base Attachment Cut"
    static ForgeTypeId ColumnBaseAttachedParam { get; }
      Description: "Base is Attached"
    static ForgeTypeId ColumnBaseAttachJustificationParam { get; }
      Description: "Attachment Justification At Base"
    static ForgeTypeId ColumnBaseAttachmentOffsetParam { get; }
      Description: "Offset From Attachment At Base"
    static ForgeTypeId ColumnLocationMark { get; }
      Description: "Column Location Mark"
    static ForgeTypeId ColumnTopAttachCutParam { get; }
      Description: "Top Attachment Cut"
    static ForgeTypeId ColumnTopAttachedParam { get; }
      Description: "Top is Attached"
    static ForgeTypeId ColumnTopAttachJustificationParam { get; }
      Description: "Attachment Justification At Top"
    static ForgeTypeId ColumnTopAttachmentOffsetParam { get; }
      Description: "Offset From Attachment At Top"
    static ForgeTypeId ConceptualConstructionMaterial { get; }
      Description: "Graphical Appearance"
    static ForgeTypeId ConduitStandardTypeParam { get; }
      Description: "Standard"
    static ForgeTypeId ConnectorAngle { get; }
      Description: "Angle"
    static ForgeTypeId ConnectorAngleOfDeflection { get; }
      Description: "Angle of Deflection"
    static ForgeTypeId ConnectorDiameter { get; }
      Description: "Diameter"
    static ForgeTypeId ConnectorEngagementLength { get; }
      Description: "Engagement Length"
    static ForgeTypeId ConnectorGenderType { get; }
      Description: "Connector Gender Type"
    static ForgeTypeId ConnectorHeight { get; }
      Description: "Height"
    static ForgeTypeId ConnectorIndex { get; }
      Description: "Index"
    static ForgeTypeId ConnectorInsideDiameter { get; }
      Description: "Inside Diameter"
    static ForgeTypeId ConnectorJointType { get; }
      Description: "Connector Joint Type"
    static ForgeTypeId ConnectorLength { get; }
      Description: "Length"
    static ForgeTypeId ConnectorProfileType { get; }
      Description: "Shape"
    static ForgeTypeId ConnectorRadius { get; }
      Description: "Radius"
    static ForgeTypeId ConnectorReferenceIndex { get; }
      Description: "Link Connector Index"
    static ForgeTypeId ConnectorUtilityParam { get; }
      Description: "Utility"
    static ForgeTypeId ConnectorVisibleSize { get; }
      Description: "Size on screen"
    static ForgeTypeId ConnectorWidth { get; }
      Description: "Width"
    static ForgeTypeId ConstructionIsSchematic { get; }
      Description: "Schematic"
    static ForgeTypeId ConstructionName { get; }
      Description: "Name"
    static ForgeTypeId ContinuousFootingBearingWidth { get; }
      Description: "Width"
    static ForgeTypeId ContinuousFootingBottomHeel { get; }
      Description: "Bottom Heel Length"
    static ForgeTypeId ContinuousFootingBottomToe { get; }
      Description: "Bottom Toe Length"
    static ForgeTypeId ContinuousFootingBreakAtInsertsDisable { get; }
      Description: "Do Not Break At Inserts"
    static ForgeTypeId ContinuousFootingDefaultEndExtensionLength { get; }
      Description: "Default End Extension Length"
    static ForgeTypeId ContinuousFootingEccentricity { get; }
      Description: "Eccentricity"
    static ForgeTypeId ContinuousFootingLength { get; }
      Description: "Length"
    static ForgeTypeId ContinuousFootingStructuralUsage { get; }
      Description: "Structural Usage"
    static ForgeTypeId ContinuousFootingTopHeel { get; }
      Description: "Heel Length"
    static ForgeTypeId ContinuousFootingTopToe { get; }
      Description: "Toe Length"
    static ForgeTypeId ContinuousFootingWidth { get; }
      Description: "Width"
    static ForgeTypeId ContinuousrailBeginningTerminationAttachmentParam { get; }
      Description: "Extension Style"
    static ForgeTypeId ContinuousrailBeginningTerminationTypeParam { get; }
      Description: "Beginning/Bottom Termination"
    static ForgeTypeId ContinuousrailDefaultJoinTypeParam { get; }
      Description: "Default Join"
    static ForgeTypeId ContinuousrailEndExtensionLengthParam { get; }
      Description: "Length"
    static ForgeTypeId ContinuousrailEndTerminationAttachmentParam { get; }
      Description: "Extension Style"
    static ForgeTypeId ContinuousrailEndTerminationTypeParam { get; }
      Description: "End/Top Termination"
    static ForgeTypeId ContinuousrailExtensionLengthParam { get; }
      Description: "Length"
    static ForgeTypeId ContinuousrailFilletRadiusParam { get; }
      Description: "Fillet Radius"
    static ForgeTypeId ContinuousrailJoinTypeParam { get; }
      Description: "Rail Path Join"
    static ForgeTypeId ContinuousrailLengthParam { get; }
      Description: "Length"
    static ForgeTypeId ContinuousrailMaterialsParam { get; }
      Description: "Material"
    static ForgeTypeId ContinuousrailPlusTreadDepthParam { get; }
      Description: "Plus Tread Depth"
    static ForgeTypeId ContinuousrailProfileTypeParam { get; }
      Description: "Profile"
    static ForgeTypeId ContinuousrailTransitionTypeParam { get; }
      Description: "Transitions"
    static ForgeTypeId ContourElevation { get; }
      Description: "Elevation"
    static ForgeTypeId ContourElevationStep { get; }
      Description: "Increment"
    static ForgeTypeId ContourLabelsElevBaseType { get; }
      Description: "Elevation Base"
    static ForgeTypeId ContourLabelsLinearUnits { get; }
      Description: "Units Format"
    static ForgeTypeId ContourLabelsPrimaryOnly { get; }
      Description: "Label primary contours only"
    static ForgeTypeId ContourLabelsRelativeBase { get; }
      Description: "Relative Base"
    static ForgeTypeId CouplerCode { get; }
      Description: "Part Number"
    static ForgeTypeId CouplerCoupledBarSize { get; }
      Description: "Bar Size 2"
    static ForgeTypeId CouplerCoupledEndtreatment { get; }
      Description: "End Treatment 2"
    static ForgeTypeId CouplerCoupledEngagement { get; }
      Description: "Bar Engagement 2"
    static ForgeTypeId CouplerLength { get; }
      Description: "Total Length"
    static ForgeTypeId CouplerMainBarSize { get; }
      Description: "Bar Size 1"
    static ForgeTypeId CouplerMainEndtreatment { get; }
      Description: "End Treatment 1"
    static ForgeTypeId CouplerMainEngagement { get; }
      Description: "Bar Engagement 1"
    static ForgeTypeId CouplerMark { get; }
      Description: "Schedule Mark"
    static ForgeTypeId CouplerNumber { get; }
      Description: "Coupler Number"
    static ForgeTypeId CouplerQuantity { get; }
      Description: "Quantity"
    static ForgeTypeId CouplerRotationAngle { get; }
      Description: "Coupler Rotation"
    static ForgeTypeId CouplerWeight { get; }
      Description: "Mass"
    static ForgeTypeId CouplerWidth { get; }
      Description: "External Diameter"
    static ForgeTypeId CoverTypeLength { get; }
      Description: "Length"
    static ForgeTypeId CoverTypeName { get; }
      Description: "Name"
    static ForgeTypeId CurtaingridAdjustBorderHoriz { get; }
      Description: "Adjust for Mullion Size"
    static ForgeTypeId CurtaingridAdjustBordern1 { get; }
      Description: "Adjust for Mullion Size"
    static ForgeTypeId CurtaingridAdjustBordern2 { get; }
      Description: "Adjust for Mullion Size"
    static ForgeTypeId CurtaingridAdjustBorderU { get; }
      Description: "Adjust for Mullion Size"
    static ForgeTypeId CurtaingridAdjustBorderV { get; }
      Description: "Adjust for Mullion Size"
    static ForgeTypeId CurtaingridAdjustBorderVert { get; }
      Description: "Adjust for Mullion Size"
    static ForgeTypeId CurtaingridAngleHoriz { get; }
      Description: "Angle"
    static ForgeTypeId CurtaingridAnglen1 { get; }
      Description: "Angle"
    static ForgeTypeId CurtaingridAnglen2 { get; }
      Description: "Angle"
    static ForgeTypeId CurtaingridAngleU { get; }
      Description: "Grid Rotation"
    static ForgeTypeId CurtaingridAngleV { get; }
      Description: "Grid Rotation"
    static ForgeTypeId CurtaingridAngleVert { get; }
      Description: "Angle"
    static ForgeTypeId CurtainGridBaseOrientation { get; }
      Description: "Grid Base Orientation"
    static ForgeTypeId CurtaingridBeltHoriz { get; }
      Description: "Measurement Line"
    static ForgeTypeId CurtaingridBeltn1 { get; }
      Description: "Measurement Line"
    static ForgeTypeId CurtaingridBeltn2 { get; }
      Description: "Measurement Line"
    static ForgeTypeId CurtaingridBeltRation1 { get; }
      Description: "Measurement Line"
    static ForgeTypeId CurtaingridBeltRation2 { get; }
      Description: "Measurement Line"
    static ForgeTypeId CurtaingridBeltRatioU { get; }
      Description: "Belt Measurement"
    static ForgeTypeId CurtaingridBeltRatioV { get; }
      Description: "Belt Measurement"
    static ForgeTypeId CurtaingridBeltU { get; }
      Description: "Belt Measurement"
    static ForgeTypeId CurtaingridBeltV { get; }
      Description: "Belt Measurement"
    static ForgeTypeId CurtaingridBeltVert { get; }
      Description: "Measurement Line"
    static ForgeTypeId CurtaingridOriginHoriz { get; }
      Description: "Offset"
    static ForgeTypeId CurtaingridOriginn1 { get; }
      Description: "Offset"
    static ForgeTypeId CurtaingridOriginn2 { get; }
      Description: "Offset"
    static ForgeTypeId CurtaingridOriginU { get; }
      Description: "Offset"
    static ForgeTypeId CurtaingridOriginV { get; }
      Description: "Offset"
    static ForgeTypeId CurtaingridOriginVert { get; }
      Description: "Offset"
    static ForgeTypeId CurtaingridUseCurveDist { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtaingridUseCurveDistHoriz { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtaingridUseCurveDistn1 { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtaingridUseCurveDistn2 { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtaingridUseCurveDistU { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtaingridUseCurveDistV { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtaingridUseCurveDistVert { get; }
      Description: "Use Curve Distance"
    static ForgeTypeId CurtainVersionParam { get; }
      Description: "Curtain version"
    static ForgeTypeId CurtainWallPanelHostId { get; }
      Description: "Host Id"
    static ForgeTypeId CurtainWallPanelsHeight { get; }
      Description: "Height"
    static ForgeTypeId CurtainWallPanelsWidth { get; }
      Description: "Width"
    static ForgeTypeId CurtainWallSyspanelOffset { get; }
      Description: "Offset"
    static ForgeTypeId CurtainWallSyspanelThickness { get; }
      Description: "Thickness"
    static ForgeTypeId CurveBottomLevel { get; }
      Description: "Bottom Level"
    static ForgeTypeId CurveByPointsProjectionType { get; }
      Description: "Projection Type"
    static ForgeTypeId CurveDeterminesOrientation { get; }
      Description: "Determines Orientation"
    static ForgeTypeId CurveEdgeOffset { get; }
      Description: "Wall offset"
    static ForgeTypeId CurveElemArcEndAngle { get; }
      Description: "Angle 2"
    static ForgeTypeId CurveElemArcRadius { get; }
      Description: "Radius"
    static ForgeTypeId CurveElemArcRange { get; }
      Description: "Range"
    static ForgeTypeId CurveElemArcStartAngle { get; }
      Description: "Angle 1"
    static ForgeTypeId CurveElemDefinesSlope { get; }
      Description: "Defines Beam System Slope"
    static ForgeTypeId CurveElemLength { get; }
      Description: "Length"
    static ForgeTypeId CurveElemLineAngle { get; }
      Description: "Angle"
    static ForgeTypeId CurveHeightOffset { get; }
      Description: "Offset From Base"
    static ForgeTypeId CurveIsDetail { get; }
      Description: "Detail Line"
    static ForgeTypeId CurveIsFilled { get; }
      Description: "Filled"
    static ForgeTypeId CurveIsMultilevel { get; }
      Description: "Multilevel Boundary"
    static ForgeTypeId CurveIsReferenceLine { get; }
      Description: "Is Reference Line"
    static ForgeTypeId CurveIsSlopeDefining { get; }
      Description: "Defines Slope"
    static ForgeTypeId CurveLevel { get; }
      Description: "Level"
    static ForgeTypeId CurveNumberOfSegments { get; }
      Description: "Number of Full Segments"
    static ForgeTypeId CurveParamConcreteCantilever { get; }
      Description: "Concrete Cantilever"
    static ForgeTypeId CurveParamSteelCantilever { get; }
      Description: "Steel Cantilever"
    static ForgeTypeId CurveSupportOffset { get; }
      Description: "Wall offset"
    static ForgeTypeId CurveTopLevel { get; }
      Description: "Top Level"
    static ForgeTypeId CurveVisibilityParam { get; }
      Description: "Visibility/Graphics Overrides"
    static ForgeTypeId CurveWallOffset { get; }
      Description: "Wall offset"
    static ForgeTypeId CurveWallOffsetRoofs { get; }
      Description: "Overhang"
    static ForgeTypeId CustMullionThick { get; }
      Description: "Thickness"
    static ForgeTypeId CustMullionWidth1 { get; }
      Description: "Width on side 1"
    static ForgeTypeId CustMullionWidth2 { get; }
      Description: "Width on side 2"
    static ForgeTypeId CutLineAngle { get; }
      Description: "Cut Line Angle"
    static ForgeTypeId CutLineDistance { get; }
      Description: "Cut Line Distance"
    static ForgeTypeId CutLineExtension { get; }
      Description: "Cut Line Extension"
    static ForgeTypeId CutLineType { get; }
      Description: "Cut Line Type"
    static ForgeTypeId CutMarkSymbol { get; }
      Description: "Cut Mark Symbol"
    static ForgeTypeId CutMarkSymbolSize { get; }
      Description: "Cut Mark Symbol Size"
    static ForgeTypeId CwpAddGridPrefix { get; }
      Description: "Add prefix to Grid Name"
    static ForgeTypeId CwpAddGridSuffix { get; }
      Description: "Add suffix to Grid Name"
    static ForgeTypeId CwpAddLevelPrefix { get; }
      Description: "Add prefix to Level Name"
    static ForgeTypeId CwpAddLevelSuffix { get; }
      Description: "Add suffix to Level Name"
    static ForgeTypeId CwpCopyFloorInserts { get; }
      Description: "Copy openings/inserts"
    static ForgeTypeId CwpCopyRoofInserts { get; }
      Description: "Copy openings"
    static ForgeTypeId CwpCopyWallInserts { get; }
      Description: "Copy windows/doors/openings"
    static ForgeTypeId CwpLevelOffset { get; }
      Description: "Offset Level"
    static ForgeTypeId CwpLinkedRoomParams { get; }
      Description: "Parameters"
    static ForgeTypeId CwpLinkedRoomPhases { get; }
      Description: "Phases"
    static ForgeTypeId CwpReuseExistingGrids { get; }
      Description: "Reuse matching Grids"
    static ForgeTypeId CwpReuseExistingLevels { get; }
      Description: "Reuse matching Levels"
    static ForgeTypeId CwpReuseGridsSameName { get; }
      Description: "Reuse Grids with the same name"
    static ForgeTypeId CwpReuseLevelsSameName { get; }
      Description: "Reuse Levels with the same name"
    static ForgeTypeId CwpSplitColumnsAtLevels { get; }
      Description: "Split Columns by Levels"
    static ForgeTypeId DatumBubbleEndn1 { get; }
      Description: "Symbol at End 1 Default"
    static ForgeTypeId DatumBubbleEndn2 { get; }
      Description: "Symbol at End 2 Default"
    static ForgeTypeId DatumBubbleLocationInElev { get; }
      Description: "Non-Plan View Symbols (Default)"
    static ForgeTypeId DatumPlaneDefinesOrigin { get; }
      Description: "Defines Origin"
    static ForgeTypeId DatumPlaneDefinesWallClosure { get; }
      Description: "Wall Closure"
    static ForgeTypeId DatumText { get; }
      Description: "Name"
    static ForgeTypeId DatumVolumeOfInterest { get; }
      Description: "Scope Box"
    static ForgeTypeId DecalAttributes { get; }
      Description: "Decal Attributes"
    static ForgeTypeId DecalHeight { get; }
      Description: "Height"
    static ForgeTypeId DecalLockProportions { get; }
      Description: "Lock Proportions"
    static ForgeTypeId DecalSubcategoryId { get; }
      Description: "Subcategory"
    static ForgeTypeId DecalWidth { get; }
      Description: "Width"
    static ForgeTypeId DefaultConstructionExtWallUnderground { get; }
      Description: "Mass Exterior Wall - Underground"
    static ForgeTypeId DefaultConstructionMassExteriorWall { get; }
      Description: "Mass Exterior Wall"
    static ForgeTypeId DefaultConstructionMassFloor { get; }
      Description: "Mass Floor"
    static ForgeTypeId DefaultConstructionMassGlazing { get; }
      Description: "Mass Glazing"
    static ForgeTypeId DefaultConstructionMassInteriorWall { get; }
      Description: "Mass Interior Wall"
    static ForgeTypeId DefaultConstructionMassOpening { get; }
      Description: "Mass Opening"
    static ForgeTypeId DefaultConstructionMassRoof { get; }
      Description: "Mass Roof"
    static ForgeTypeId DefaultConstructionMassShade { get; }
      Description: "Mass Shade"
    static ForgeTypeId DefaultConstructionMassSkylight { get; }
      Description: "Mass Skylight"
    static ForgeTypeId DefaultConstructionMassSlab { get; }
      Description: "Mass Slab"
    static ForgeTypeId DefaultViewTemplate { get; }
      Description: "View Template applied to new views"
    static ForgeTypeId DefinesConstantHeight { get; }
      Description: "Defines Constant Height"
    static ForgeTypeId DesignOptionId { get; }
      Description: "Design Option"
    static ForgeTypeId DesignOptionParam { get; }
      Description: "Design Option"
    static ForgeTypeId DiameterSymbolLocation { get; }
      Description: "Diameter Symbol Location"
    static ForgeTypeId DiameterSymbolText { get; }
      Description: "Diameter Symbol Text"
    static ForgeTypeId DimDisplayEq { get; }
      Description: "Equality Display"
    static ForgeTypeId DimIsreporting { get; }
      Description: "Is Reporting"
    static ForgeTypeId DimLabel { get; }
      Description: "Label"
    static ForgeTypeId DimLabelGpShow { get; }
      Description: "Show Label in View"
    static ForgeTypeId DimLabelIsInstance { get; }
      Description: "Is Instance Parameter"
    static ForgeTypeId DimLeader { get; }
      Description: "Leader"
    static ForgeTypeId DimLeaderArrowhead { get; }
      Description: "Tick Mark"
    static ForgeTypeId DimLeaderDisplayCondition { get; }
      Description: "Show Leader When Text Moves"
    static ForgeTypeId DimLeaderShoulderLength { get; }
      Description: "Shoulder Length"
    static ForgeTypeId DimLeaderType { get; }
      Description: "Leader Type"
    static ForgeTypeId DimLineExtension { get; }
      Description: "Dimension Line Extension"
    static ForgeTypeId DimNotModifiable { get; }
      Description: "Non-modifiable"
    static ForgeTypeId DimPrefix { get; }
      Description: "Dimension Prefix"
    static ForgeTypeId DimReferenceCount { get; }
      Description: "Count"
    static ForgeTypeId DimStyleAngularUnits { get; }
      Description: "Units Format"
    static ForgeTypeId DimStyleAngularUnitsAlt { get; }
      Description: "Alternate Units Format"
    static ForgeTypeId DimStyleCenterlinePattern { get; }
      Description: "Centerline Pattern"
    static ForgeTypeId DimStyleCenterlineSymbol { get; }
      Description: "Centerline Symbol"
    static ForgeTypeId DimStyleCenterlineTickMark { get; }
      Description: "Centerline Tick Mark"
    static ForgeTypeId DimStyleDimLineSnapDist { get; }
      Description: "Dimension Line Snap Distance"
    static ForgeTypeId DimStyleFlippedDimLineExtension { get; }
      Description: "Flipped Dimension Line Extension"
    static ForgeTypeId DimStyleInteriorTickMark { get; }
      Description: "Interior Tick Mark"
    static ForgeTypeId DimStyleLeaderTickMark { get; }
      Description: "Leader Tick Mark"
    static ForgeTypeId DimStyleLinearUnits { get; }
      Description: "Units Format"
    static ForgeTypeId DimStyleLinearUnitsAlt { get; }
      Description: "Alternate Units Format"
    static ForgeTypeId DimStyleReadConvention { get; }
      Description: "Read Convention"
    static ForgeTypeId DimStyleShowOpeningHt { get; }
      Description: "Show Opening Height"
    static ForgeTypeId DimStyleSuppressSpaces { get; }
      Description: "Suppress Spaces"
    static ForgeTypeId DimSuffix { get; }
      Description: "Dimension Suffix"
    static ForgeTypeId DimTextBackground { get; }
      Description: "Text Background"
    static ForgeTypeId DimTextLocationForLeader { get; }
      Description: "Text Location"
    static ForgeTypeId DimToInserts { get; }
      Description: "Dimension To Openings"
    static ForgeTypeId DimToInsertType { get; }
      Description: "Dimension To Opening Type"
    static ForgeTypeId DimToIntersectingGrids { get; }
      Description: "Dimension To Intersecting Grids"
    static ForgeTypeId DimToIntersectingWalls { get; }
      Description: "Dimension To Intersecting Walls"
    static ForgeTypeId DimTotalLength { get; }
      Description: "Total Length"
    static ForgeTypeId DimValueAngle { get; }
      Description: "Value"
    static ForgeTypeId DimValueLength { get; }
      Description: "Value"
    static ForgeTypeId DimWitnsLineCntrl { get; }
      Description: "Witness Line Control"
    static ForgeTypeId DimWitnsLineExtensionBelow { get; }
      Description: "Witness Line Length"
    static ForgeTypeId Directcontext3dApplicationId { get; }
      Description: "ApplicationId"
    static ForgeTypeId Directcontext3dLoaded { get; }
      Description: "Loaded"
    static ForgeTypeId Directcontext3dName { get; }
      Description: "Name"
    static ForgeTypeId Directcontext3dServerId { get; }
      Description: "ServerId"
    static ForgeTypeId Directcontext3dSourceId { get; }
      Description: "Path"
    static ForgeTypeId DisplacedElementDisplacementX { get; }
      Description: "X Displacement"
    static ForgeTypeId DisplacedElementDisplacementY { get; }
      Description: "Y Displacement"
    static ForgeTypeId DisplacedElementDisplacementZ { get; }
      Description: "Z Displacement"
    static ForgeTypeId DisplacementPathDepth { get; }
      Description: "Depth"
    static ForgeTypeId DisplacementPathStyle { get; }
      Description: "Style"
    static ForgeTypeId DistanceToCutMark { get; }
      Description: "Distance to Cut Mark"
    static ForgeTypeId DividedpathBeginningIndent { get; }
      Description: "Beginning Indent"
    static ForgeTypeId DividedpathDisplayNodeNumbers { get; }
      Description: "Show Node Numbers"
    static ForgeTypeId DividedpathDisplayNodes { get; }
      Description: "Display Nodes"
    static ForgeTypeId DividedpathDisplayReferenceCurves { get; }
      Description: "Display Path"
    static ForgeTypeId DividedpathDistance { get; }
      Description: "Distance"
    static ForgeTypeId DividedpathEndIndent { get; }
      Description: "End Indent"
    static ForgeTypeId DividedpathFlipDirection { get; }
      Description: "Flip Direction"
    static ForgeTypeId DividedpathJustification { get; }
      Description: "Justification"
    static ForgeTypeId DividedpathLayout { get; }
      Description: "Layout"
    static ForgeTypeId DividedpathLayoutFixedNumPoint { get; }
      Description: "Number"
    static ForgeTypeId DividedpathMaxDistance { get; }
      Description: "Maximum Distance"
    static ForgeTypeId DividedpathMeasurementType { get; }
      Description: "Measurement Type"
    static ForgeTypeId DividedpathMergedPointNum { get; }
      Description: "Total Number of Nodes"
    static ForgeTypeId DividedpathMinDistance { get; }
      Description: "Minimum Distance"
    static ForgeTypeId DividedpathTotalPathLength { get; }
      Description: "Path Length"
    static ForgeTypeId DividedSurfaceAllGridRotation { get; }
      Description: "All Grid Rotation"
    static ForgeTypeId DividedSurfaceAllPoints { get; }
      Description: "Show all points"
    static ForgeTypeId DividedSurfaceComponentTrimType { get; }
      Description: "Component Trim"
    static ForgeTypeId DividedSurfaceCoverFaceCompletely { get; }
      Description: "Cover face completely"
    static ForgeTypeId DividedSurfaceDisplayComponents { get; }
      Description: "Components"
    static ForgeTypeId DividedSurfaceDisplayDiscardeddivisionlines { get; }
      Description: "Discarded Division Lines"
    static ForgeTypeId DividedSurfaceDisplayGridlines { get; }
      Description: "Gridlines"
    static ForgeTypeId DividedSurfaceDisplayNodes { get; }
      Description: "Nodes"
    static ForgeTypeId DividedSurfaceDisplayOriginalSurface { get; }
      Description: "Surface"
    static ForgeTypeId DividedSurfaceDisplayPatternFill { get; }
      Description: "Pattern Fill"
    static ForgeTypeId DividedSurfaceDisplayPatternLines { get; }
      Description: "Pattern Lines"
    static ForgeTypeId DividedSurfaceDisplaySurfaceOption { get; }
      Description: "Display Surface Option"
    static ForgeTypeId DividedSurfaceEdgeNumber { get; }
      Description: "Edge number"
    static ForgeTypeId DividedSurfaceFacetNumber { get; }
      Description: "Facet number"
    static ForgeTypeId DividedSurfaceGridlinesStyle { get; }
      Description: "Gridlines Style"
    static ForgeTypeId DividedSurfaceGridOptionParamn1 { get; }
      Description: "Option 1"
    static ForgeTypeId DividedSurfaceGridOptionParamn2 { get; }
      Description: "Option 2"
    static ForgeTypeId DividedSurfaceOffsetFromSurface { get; }
      Description: "Offset from surface"
    static ForgeTypeId DividedSurfaceOriginalSurfaceMaterial { get; }
      Description: "Surface Material"
    static ForgeTypeId DividedSurfacePattern { get; }
      Description: "Tile Pattern"
    static ForgeTypeId DividedSurfacePatternFillMaterial { get; }
      Description: "Pattern Fill Material"
    static ForgeTypeId DividedSurfacePatternFlip { get; }
      Description: "Component Flip"
    static ForgeTypeId DividedSurfacePatternIndentn1 { get; }
      Description: "Indent 1"
    static ForgeTypeId DividedSurfacePatternIndentn2 { get; }
      Description: "Indent 2"
    static ForgeTypeId DividedSurfacePatternLinesStyle { get; }
      Description: "Pattern Lines Style"
    static ForgeTypeId DividedSurfacePatternMirror { get; }
      Description: "Component Mirror"
    static ForgeTypeId DividedSurfacePatternRotationAngle { get; }
      Description: "Component Rotation"
    static ForgeTypeId DividedSurfacePointNumber { get; }
      Description: "Point number"
    static ForgeTypeId DividedSurfaceRule1Suspension { get; }
      Description: "Is grid 1 suspended?"
    static ForgeTypeId DividedSurfaceRule2Suspension { get; }
      Description: "Is grid 2 suspended?"
    static ForgeTypeId DividedSurfaceSurfaceArea { get; }
      Description: "Divided Surface Area"
    static ForgeTypeId DividedSurfaceTileBorder { get; }
      Description: "Border Tile"
    static ForgeTypeId DividedSurfaceTotalEdgeLength { get; }
      Description: "Total edge length"
    static ForgeTypeId DivisionPattern { get; }
      Description: "Division Pattern"
    static ForgeTypeId DivisionProfileWidth { get; }
      Description: "Width": Width
    static ForgeTypeId DivisionRuleParam { get; }
      Description: "Division Rule"
    static ForgeTypeId DivisionSketchCurveDivisionParamsOverrideParam { get; }
      Description: "Profile Override"
    static ForgeTypeId DivisionSketchCurveExtentdToSilhParam { get; }
      Description: "Extend to Silhouette"
    static ForgeTypeId DoorConstructionType { get; }
      Description: "Construction Type"
    static ForgeTypeId DoorCost { get; }
      Description: "Cost"
    static ForgeTypeId DoorEvacuationExitType { get; }
      Description: "Exit Access"
    static ForgeTypeId DoorFinish { get; }
      Description: "Finish"
    static ForgeTypeId DoorFrameMaterial { get; }
      Description: "Frame Material"
    static ForgeTypeId DoorFrameType { get; }
      Description: "Frame Type"
    static ForgeTypeId DoorNumber { get; }
      Description: "Mark"
    static ForgeTypeId DoorOperationType { get; }
      Description: "Operation"
    static ForgeTypeId DpartAreaComputed { get; }
      Description: "Area"
    static ForgeTypeId DpartBaseLevel { get; }
      Description: "Base Level"
    static ForgeTypeId DpartBaseLevelByOriginal { get; }
      Description: "Base Level By Original"
    static ForgeTypeId DpartCanHostRebar { get; }
      Description: "Can host rebar"
    static ForgeTypeId DpartExcluded { get; }
      Description: "Excluded"
    static ForgeTypeId DpartHeightComputed { get; }
      Description: "Height"
    static ForgeTypeId DpartLayerConstruction { get; }
      Description: "Construction"
    static ForgeTypeId DpartLayerFunction { get; }
      Description: "Layer Function"
    static ForgeTypeId DpartLayerIndex { get; }
      Description: "Layer Index"
    static ForgeTypeId DpartLayerWidth { get; }
      Description: "Thickness"
    static ForgeTypeId DpartLengthComputed { get; }
      Description: "Length"
    static ForgeTypeId DpartMaterialByOriginal { get; }
      Description: "Material By Original"
    static ForgeTypeId DpartMaterialIdParam { get; }
      Description: "Material"
    static ForgeTypeId DpartOriginalCategory { get; }
      Description: "Original Category"
    static ForgeTypeId DpartOriginalCategoryId { get; }
      Description: "Original Category"
    static ForgeTypeId DpartOriginalFamily { get; }
      Description: "Original Family"
    static ForgeTypeId DpartOriginalType { get; }
      Description: "Original Type"
    static ForgeTypeId DpartPhaseCreatedByOriginal { get; }
      Description: "Phase Created By Original"
    static ForgeTypeId DpartPhaseDemolishedByOriginal { get; }
      Description: "Phase Demolished By Original"
    static ForgeTypeId DpartShapeModified { get; }
      Description: "Shape is modified"
    static ForgeTypeId DpartVolumeComputed { get; }
      Description: "Volume"
    static ForgeTypeId DrawForEachRun { get; }
      Description: "Draw for Each Run"
    static ForgeTypeId DuctInsulationThickness { get; }
      Description: "Insulation Thickness"
    static ForgeTypeId DuctRoughness { get; }
      Description: "Roughness"
    static ForgeTypeId DuctTerminalEngagementLength { get; }
      Description: "Engagement Length"
    static ForgeTypeId EdgeLinework { get; }
      Description: "Line Style"
    static ForgeTypeId EditedBy { get; }
      Description: "Edited by"
    static ForgeTypeId ElecticalEquipVoltage { get; }
      Description: "Voltage Comments"
    static ForgeTypeId ElecticalEquipWattage { get; }
      Description: "Wattage Comments"
    static ForgeTypeId ElemCategoryParam { get; }
      Description: "Category"
    static ForgeTypeId ElemCategoryParamMt { get; }
      Description: "Category"
    static ForgeTypeId ElemDeletableInFamily { get; }
      Description: "Deletable"
    static ForgeTypeId ElementIsCutting { get; }
      Description: "Solid/Void"
    static ForgeTypeId ElementLockedParam { get; }
      Description: "Locked"
    static ForgeTypeId ElemFamilyAndTypeParam { get; }
      Description: "Family and Type"
    static ForgeTypeId ElemFamilyParam { get; }
      Description: "Family"
    static ForgeTypeId ElemIsReference { get; }
      Description: "Reference"
    static ForgeTypeId ElemPartitionParam { get; }
      Description: "Workset"
    static ForgeTypeId ElemReferenceName { get; }
      Description: "Is Reference"
    static ForgeTypeId ElemReferenceName2dXz { get; }
      Description: "Is Reference"
    static ForgeTypeId ElemRoomId { get; }
      Description: "Room Id"
    static ForgeTypeId ElemRoomName { get; }
      Description: "Room Name"
    static ForgeTypeId ElemRoomNumber { get; }
      Description: "Room Number"
    static ForgeTypeId ElemTypeLabel { get; }
      Description: "Label"
    static ForgeTypeId ElemTypeParam { get; }
      Description: "Type"
    static ForgeTypeId ElevArrowAngle { get; }
      Description: "Arrow Angle"
    static ForgeTypeId ElevArrowFilled { get; }
      Description: "Filled"
    static ForgeTypeId ElevAssocDatum { get; }
      Description: "Associated Datum"
    static ForgeTypeId ElevatnTag { get; }
      Description: "Elevation Tag"
    static ForgeTypeId ElevReferenceLabelPos { get; }
      Description: "Reference Label Position"
    static ForgeTypeId ElevShape { get; }
      Description: "Shape"
    static ForgeTypeId ElevShowViewName { get; }
      Description: "Show View Name"
    static ForgeTypeId ElevSymbolId { get; }
      Description: "Elevation Mark"
    static ForgeTypeId ElevTextPos { get; }
      Description: "Text Position"
    static ForgeTypeId ElevViewNamePos { get; }
      Description: "View Name Position"
    static ForgeTypeId ElevWidth { get; }
      Description: "Width"
    static ForgeTypeId EllipseFocusMrkVisible { get; }
      Description: "Focus Marks Visible"
    static ForgeTypeId EllipseModificationKeepsRatio { get; }
      Description: "Keep Ratio"
    static ForgeTypeId EllipseXParam { get; }
      Description: "X-Radius Value for Ellipse (for Use with XAML Data Template example)"
    static ForgeTypeId EllipseYParam { get; }
      Description: "Y-Radius Value for Ellipse (for Use with XAML Data Template example)"
    static ForgeTypeId EndExtension { get; }
      Description: "End Extension"
    static ForgeTypeId EndJoinCutback { get; }
      Description: "End Join Cutback"
    static ForgeTypeId EndTreatment { get; }
      Description: "End Treatment"
    static ForgeTypeId EndYJustification { get; }
      Description: "End y Justification"
    static ForgeTypeId EndYOffsetValue { get; }
      Description: "End y Offset Value"
    static ForgeTypeId EndZJustification { get; }
      Description: "End z Justification"
    static ForgeTypeId EndZOffsetValue { get; }
      Description: "End z Offset Value"
    static ForgeTypeId EnergyAnalysisAdvancedOptions { get; }
      Description: "Other Options"
    static ForgeTypeId EnergyAnalysisBuildingOperatingSchedule { get; }
      Description: "Building Operating Schedule"
    static ForgeTypeId EnergyAnalysisConceptualConstruction { get; }
      Description: "Conceptual Types"
    static ForgeTypeId EnergyAnalysisCreateAnalyticalModel { get; }
      Description: "Create Energy Model"
    static ForgeTypeId EnergyAnalysisCurrentViewOnly { get; }
      Description: "Use Only Elements Visible In Current View"
    static ForgeTypeId EnergyAnalysisGlazingIsShaded { get; }
      Description: "Glazing is Shaded"
    static ForgeTypeId EnergyAnalysisHorizontalVoidThreshold { get; }
      Description: "Horizontal Void/Chase Area Threshold"
    static ForgeTypeId EnergyAnalysisHvacSystem { get; }
      Description: "HVAC System"
    static ForgeTypeId EnergyAnalysisMasszoneCoreoffset { get; }
      Description: "Perimeter Zone Depth"
    static ForgeTypeId EnergyAnalysisMasszoneDivideperimeter { get; }
      Description: "Perimeter Zone Division"
    static ForgeTypeId EnergyAnalysisMasszoneUseenergydatasettings { get; }
      Description: "Use Energy Data"
    static ForgeTypeId EnergyAnalysisMassZoning { get; }
      Description: "Mass Zoning"
    static ForgeTypeId EnergyAnalysisOutdoorAirInformationParam { get; }
      Description: "Outdoor Air Information"
    static ForgeTypeId EnergyAnalysisPercentageGlazing { get; }
      Description: "Target Percentage Glazing"
    static ForgeTypeId EnergyAnalysisPercentageSkylights { get; }
      Description: "Target Percentage Skylights"
    static ForgeTypeId EnergyAnalysisProjectPhase { get; }
      Description: "Phase"
    static ForgeTypeId EnergyAnalysisShadeDepth { get; }
      Description: "Shade Depth"
    static ForgeTypeId EnergyAnalysisSillHeight { get; }
      Description: "Target Sill Height"
    static ForgeTypeId EnergyAnalysisSkylightWidth { get; }
      Description: "Skylight Width & Depth"
    static ForgeTypeId EnergyAnalysisSpaceBoundingParam { get; }
      Description: "Analytical Space Bounding"
    static ForgeTypeId EnergyAnalysisVerticalVoidThreshold { get; }
      Description: "Average Vertical Void Height Threshold"
    static ForgeTypeId EqualityFormula { get; }
      Description: "Equality Formula"
    static ForgeTypeId EqualityTextForAngularDim { get; }
      Description: "Equality Text"
    static ForgeTypeId EqualityTextForContinuousLinearDim { get; }
      Description: "Equality Text"
    static ForgeTypeId EqualityWitnessDisplay { get; }
      Description: "Equality Witness Display"
    static ForgeTypeId ExcavationElementFamilyAndType { get; }
      Description: "Element Family and Type"
    static ForgeTypeId ExcavationElementId { get; }
      Description: "Element Id"
    static ForgeTypeId ExcavationVolume { get; }
      Description: "Excavation Volume"
    static ForgeTypeId ExcavationVolumeOnToposolid { get; }
      Description: "Excavation Volume on Toposolid"
    static ForgeTypeId ExchangeEntityId { get; }
      Description: "Exchange Entity ID"
    static ForgeTypeId ExchangeId { get; }
      Description: "Exchange ID"
    static ForgeTypeId ExtrusionAutoParams { get; }
      Description: "Auto ends"
    static ForgeTypeId ExtrusionDepthParam { get; }
      Description: "Depth"
    static ForgeTypeId ExtrusionEndParam { get; }
      Description: "Extrusion End"
    static ForgeTypeId ExtrusionLength { get; }
      Description: "Depth"
    static ForgeTypeId ExtrusionStartParam { get; }
      Description: "Extrusion Start"
    static ForgeTypeId FabricationBottomElevationIncludeInsulationOfPart { get; }
      Description: "Bottom Elevation with Insulation"
    static ForgeTypeId FabricationBottomElevationOfPart { get; }
      Description: "Bottom Elevation"
    static ForgeTypeId FabricationBottomOfPart { get; }
      Description: "Lower End Bottom of Insulation Elevation"
    static ForgeTypeId FabricationBranchSize { get; }
      Description: "Size of Primary Branch End"
    static ForgeTypeId FabricationChangeServiceParam { get; }
      Description: "Change Service"
    static ForgeTypeId FabricationDoublewallMaterialAbbreviation { get; }
      Description: "Double Wall Material Abbreviation"
    static ForgeTypeId FabricationDuctworkStiffenerSpec { get; }
      Description: "Stiffener Specification"
    static ForgeTypeId FabricationEndOffsetParam { get; }
      Description: "End Middle Elevation"
    static ForgeTypeId FabricationEndSize { get; }
      Description: "Size of Connector End"
    static ForgeTypeId FabricationFittingDescription { get; }
      Description: "Fabrication Fitting Description"
    static ForgeTypeId FabricationInsulationAbbreviation { get; }
      Description: "Insulation Abbreviation"
    static ForgeTypeId FabricationInsulationMaterialFinish { get; }
      Description: "Insulation Material"
    static ForgeTypeId FabricationInsulationSpec { get; }
      Description: "Insulation Specification"
    static ForgeTypeId FabricationInsulationSpecificationAbbreviation { get; }
      Description: "Insulation Specification Abbreviation"
    static ForgeTypeId FabricationLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId FabricationMaterialAbbreviation { get; }
      Description: "Material Abbreviation"
    static ForgeTypeId FabricationMaterialGauge { get; }
      Description: "Material Gauge"
    static ForgeTypeId FabricationOffsetParam { get; }
      Description: "Middle Elevation"
    static ForgeTypeId FabricationPartAlias { get; }
      Description: "Alias"
    static ForgeTypeId FabricationPartAngle { get; }
      Description: "Angle"
    static ForgeTypeId FabricationPartAngleOption { get; }
      Description: "Angle Option"
    static ForgeTypeId FabricationPartBoughtOut { get; }
      Description: "Bought Out"
    static ForgeTypeId FabricationPartCutType { get; }
      Description: "Cut Type"
    static ForgeTypeId FabricationPartDepthIn { get; }
      Description: "Main Primary Depth"
    static ForgeTypeId FabricationPartDepthInOption { get; }
      Description: "Main Primary Depth Option"
    static ForgeTypeId FabricationPartDepthOut { get; }
      Description: "Main Secondary Depth"
    static ForgeTypeId FabricationPartDepthOutOption { get; }
      Description: "Main Secondary Depth Option"
    static ForgeTypeId FabricationPartDiameterIn { get; }
      Description: "Main Primary Diameter"
    static ForgeTypeId FabricationPartDiameterInOption { get; }
      Description: "Main Primary Diameter Option"
    static ForgeTypeId FabricationPartDiameterOut { get; }
      Description: "Main Secondary Diameter"
    static ForgeTypeId FabricationPartDiameterOutOption { get; }
      Description: "Main Secondary Diameter Option"
    static ForgeTypeId FabricationPartDoublewallMaterial { get; }
      Description: "Double Wall Material"
    static ForgeTypeId FabricationPartDoublewallMaterialArea { get; }
      Description: "Double Wall Material Area"
    static ForgeTypeId FabricationPartDoublewallMaterialThickness { get; }
      Description: "Double Wall Material Thickness"
    static ForgeTypeId FabricationPartInsulationArea { get; }
      Description: "Insulation Area"
    static ForgeTypeId FabricationPartItemNumber { get; }
      Description: "Item Number"
    static ForgeTypeId FabricationPartLength { get; }
      Description: "Length"
    static ForgeTypeId FabricationPartLengthOption { get; }
      Description: "Length Option"
    static ForgeTypeId FabricationPartLiningArea { get; }
      Description: "Lining Area"
    static ForgeTypeId FabricationPartMaterial { get; }
      Description: "Part Material"
    static ForgeTypeId FabricationPartMaterialThickness { get; }
      Description: "Part Material Thickness"
    static ForgeTypeId FabricationPartNotes { get; }
      Description: "Fabrication Notes"
    static ForgeTypeId FabricationPartPatNo { get; }
      Description: "Part Pattern Number"
    static ForgeTypeId FabricationPartSheetmetalArea { get; }
      Description: "Part Sheet Metal Area"
    static ForgeTypeId FabricationPartTakeoffDialogParam { get; }
      Description: "More Parameters"
    static ForgeTypeId FabricationPartWeight { get; }
      Description: "Weight"
    static ForgeTypeId FabricationPartWidthIn { get; }
      Description: "Main Primary Width"
    static ForgeTypeId FabricationPartWidthInOption { get; }
      Description: "Main Primary Width Option"
    static ForgeTypeId FabricationPartWidthOut { get; }
      Description: "Main Secondary Width"
    static ForgeTypeId FabricationPartWidthOutOption { get; }
      Description: "Main Secondary Width Option"
    static ForgeTypeId FabricationPipeInvertElevation { get; }
      Description: "Pipe Invert Elevation": This parameter is obsolete. It exists only for compatibility.
    static ForgeTypeId FabricationPrimarySize { get; }
      Description: "Size of Primary End"
    static ForgeTypeId FabricationProductCode { get; }
      Description: "Product Code"
    static ForgeTypeId FabricationProductDataFinishDescription { get; }
      Description: "Product Finish Description"
    static ForgeTypeId FabricationProductDataInstallType { get; }
      Description: "Install Type"
    static ForgeTypeId FabricationProductDataItemDescription { get; }
      Description: "Product Short Description"
    static ForgeTypeId FabricationProductDataLongDescription { get; }
      Description: "Product Long Description"
    static ForgeTypeId FabricationProductDataMaterialDescription { get; }
      Description: "Product Material Description"
    static ForgeTypeId FabricationProductDataOem { get; }
      Description: "OEM"
    static ForgeTypeId FabricationProductDataProduct { get; }
      Description: "Product Name"
    static ForgeTypeId FabricationProductDataRange { get; }
      Description: "Product Range"
    static ForgeTypeId FabricationProductDataSizeDescription { get; }
      Description: "Product Size Description"
    static ForgeTypeId FabricationProductDataSpecification { get; }
      Description: "Product Specification Description"
    static ForgeTypeId FabricationProductEntry { get; }
      Description: "Product Entry"
    static ForgeTypeId FabricationRelativeFilename { get; }
      Description: "Relative File Name"
    static ForgeTypeId FabricationRoutingSolutionsUiParam { get; }
      Description: "x of XX"
    static ForgeTypeId FabricationSecondarySize { get; }
      Description: "Size of Secondary End"
    static ForgeTypeId FabricationServiceAbbreviation { get; }
      Description: "Fabrication Service Abbreviation"
    static ForgeTypeId FabricationServiceName { get; }
      Description: "Fabrication Service Name"
    static ForgeTypeId FabricationServiceParam { get; }
      Description: "Fabrication Service"
    static ForgeTypeId FabricationSetUpDownTag { get; }
      Description: "SU/SD from Top"
    static ForgeTypeId FabricationSetUpDownTagFromBottom { get; }
      Description: "SU/SD from Bottom"
    static ForgeTypeId FabricationSlopeParam { get; }
      Description: "Slope"
    static ForgeTypeId FabricationSpecification { get; }
      Description: "Specification"
    static ForgeTypeId FabricationSpecificationAbbreviation { get; }
      Description: "Specification Abbreviation"
    static ForgeTypeId FabricationStartOffsetParam { get; }
      Description: "Start Middle Elevation"
    static ForgeTypeId FabricationTopElevationIncludeInsulationOfPart { get; }
      Description: "Top Elevation with Insulation"
    static ForgeTypeId FabricationTopElevationOfPart { get; }
      Description: "Top Elevation"
    static ForgeTypeId FabricationTopOfPart { get; }
      Description: "Upper End Top of Insulation Elevation"
    static ForgeTypeId FabricationVendor { get; }
      Description: "Vendor"
    static ForgeTypeId FabricationVendorCode { get; }
      Description: "Vendor Code"
    static ForgeTypeId FabricBendDiameter { get; }
      Description: "Bend Diameter": Standard Bend Diameter of Fabric Wire.
    static ForgeTypeId FabricNumber { get; }
      Description: "Fabric Number"
    static ForgeTypeId FabricParamCoverOffset { get; }
      Description: "Additional Cover Offset": Additional cover offset of the fabric distribution.
    static ForgeTypeId FabricParamCutByHost { get; }
      Description: "Cut by Host Cover": Single Fabric Sheet is cut or not cut by the Host Cover.
    static ForgeTypeId FabricParamCutOverallLength { get; }
      Description: "Cut Overall Length": Provides a real sheet Length after definition
    static ForgeTypeId FabricParamCutOverallWidth { get; }
      Description: "Cut Overall Width": Provides a real sheet Width after definition
    static ForgeTypeId FabricParamCutSheetMass { get; }
      Description: "Cut Sheet Mass": Calculated cut sheet mass [Sheet Mass per Unit Area * (Cut Overall Length * Cut Overall Width)]
    static ForgeTypeId FabricParamLapsplicePosition { get; }
      Description: "Lap Splice Position": Fabric lap splice position in the fabric distribution
    static ForgeTypeId FabricParamLocationGeneric { get; }
      Description: "Location": Fabric location in the host.
    static ForgeTypeId FabricParamLocationSlab { get; }
      Description: "Location": Fabric location in the slab
    static ForgeTypeId FabricParamLocationWall { get; }
      Description: "Location": Fabric location in the wall
    static ForgeTypeId FabricParamMajorLapspliceLength { get; }
      Description: "Major Lap Splice Length": Fabric lap splice length in major direction in the fabric distribution.
    static ForgeTypeId FabricParamMinorLapspliceLength { get; }
      Description: "Minor Lap Splice Length": Fabric lap splice length in minor direction in the fabric distribution.
    static ForgeTypeId FabricParamRounding { get; }
      Description: "Rounding Overrides"
    static ForgeTypeId FabricParamSharedFamilyKey { get; }
      Description: "Shared family key"
    static ForgeTypeId FabricParamSheetType { get; }
      Description: "Fabric Sheet": List all Fabric Sheet types
    static ForgeTypeId FabricParamSpanSymBottom { get; }
      Description: "Bottom"
    static ForgeTypeId FabricParamSpanSymDBottom { get; }
      Description: "D_Bottom"
    static ForgeTypeId FabricParamSpanSymDLeft { get; }
      Description: "D_Left"
    static ForgeTypeId FabricParamSpanSymDRight { get; }
      Description: "D_Right"
    static ForgeTypeId FabricParamSpanSymDTop { get; }
      Description: "D_Top"
    static ForgeTypeId FabricParamSpanSymLeft { get; }
      Description: "Left"
    static ForgeTypeId FabricParamSpanSymRight { get; }
      Description: "Right"
    static ForgeTypeId FabricParamSpanSymTop { get; }
      Description: "Top"
    static ForgeTypeId FabricParamSpanTagComponentReference { get; }
      Description: "Tag Component Reference"
    static ForgeTypeId FabricParamTagView { get; }
      Description: "Tag new members in view": List of all Plan Views and None.
    static ForgeTypeId FabricParamTotalSheetMass { get; }
      Description: "Total Sheet Mass": Calculated all sheet mass: Volume of Wire * Unit Weight.
    static ForgeTypeId FabricSheetDefaultMajorLapspliceLength { get; }
      Description: "Default Major Lap Splice Length": Default Major Lap Splice Length
    static ForgeTypeId FabricSheetDefaultMinorLapspliceLength { get; }
      Description: "Default Minor Lap Splice Length": Default Minor Lap Splice Length
    static ForgeTypeId FabricSheetLength { get; }
      Description: "Length": Length
    static ForgeTypeId FabricSheetMajorDirectionWireType { get; }
      Description: "Major Direction Wire Type": Major Direction Wire Type
    static ForgeTypeId FabricSheetMajorEndOverhang { get; }
      Description: "Major End Overhang": Major End Overhang
    static ForgeTypeId FabricSheetMajorLayoutPattern { get; }
      Description: "Major Layout Pattern": Major Layout Pattern
    static ForgeTypeId FabricSheetMajorNumberOfWires { get; }
      Description: "Major Number of Wires": Major Number of Wires
    static ForgeTypeId FabricSheetMajorReinforcementArea { get; }
      Description: "Major Reinforcement Area": Major Reinforcement Area
    static ForgeTypeId FabricSheetMajorSpacing { get; }
      Description: "Major Spacing": Major Spacing
    static ForgeTypeId FabricSheetMajorStartOverhang { get; }
      Description: "Major Start Overhang": Major Start Overhang
    static ForgeTypeId FabricSheetMass { get; }
      Description: "Sheet Mass": Sheet Mass
    static ForgeTypeId FabricSheetMassunit { get; }
      Description: "Sheet Mass per Unit Area": Structural Sheet Mass per Unit Area [Sheet Mass / (Overall Length * Overall Width)]
    static ForgeTypeId FabricSheetMinorDirectionWireType { get; }
      Description: "Minor Direction Wire Type": Minor Direction Wire Type
    static ForgeTypeId FabricSheetMinorEndOverhang { get; }
      Description: "Minor End Overhang": Minor End Overhang
    static ForgeTypeId FabricSheetMinorLayoutPattern { get; }
      Description: "Minor Layout Pattern": Minor Layout Pattern
    static ForgeTypeId FabricSheetMinorNumberOfWires { get; }
      Description: "Minor Number of Wires": Minor Number of Wires
    static ForgeTypeId FabricSheetMinorReinforcementArea { get; }
      Description: "Minor Reinforcement Area": Minor Reinforcement Area
    static ForgeTypeId FabricSheetMinorSpacing { get; }
      Description: "Minor Spacing": Minor Spacing
    static ForgeTypeId FabricSheetMinorStartOverhang { get; }
      Description: "Minor Start Overhang": Minor Start Overhang
    static ForgeTypeId FabricSheetOverallLength { get; }
      Description: "Overall Length": Overall Length
    static ForgeTypeId FabricSheetOverallWidth { get; }
      Description: "Overall Width": Overall Width
    static ForgeTypeId FabricSheetPhysicalMaterialAsset { get; }
      Description: "Physical Material Asset": Physical Material Asset
    static ForgeTypeId FabricSheetWidth { get; }
      Description: "Width": Width
    static ForgeTypeId FabricWireDiameter { get; }
      Description: "Nominal Diameter": Nominal Diameter of Fabric Wire.
    static ForgeTypeId FabricWireDistance { get; }
      Description: "Wire distance": The distance between wires
    static ForgeTypeId FabricWireLength { get; }
      Description: "Wire length": The wire length
    static ForgeTypeId FabricWireOffset { get; }
      Description: "Offset along wire direction": Offset along wire direction
    static ForgeTypeId FabricWireType { get; }
      Description: "Wire type": The wire type assigned
    static ForgeTypeId FaceroofLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId FaceroofOffsetParam { get; }
      Description: "Level Offset"
    static ForgeTypeId FamilyAllowCutWithVoids { get; }
      Description: "Cut with Voids When Loaded"
    static ForgeTypeId FamilyAlwaysVertical { get; }
      Description: "Always vertical"
    static ForgeTypeId FamilyAutojoin { get; }
      Description: "Automatically joins geometry to walls"
    static ForgeTypeId FamilyBaseLevelOffsetParam { get; }
      Description: "Base Offset"
    static ForgeTypeId FamilyBaseLevelParam { get; }
      Description: "Base Level"
    static ForgeTypeId FamilyCanHostRebar { get; }
      Description: "Can host rebar"
    static ForgeTypeId FamilyCategoryPseudoParam { get; }
      Description: "Category"
    static ForgeTypeId FamilyContentPartType { get; }
      Description: "Part Type"
    static ForgeTypeId FamilyCurveAttachmentProportion { get; }
      Description: "Attachment Point"
    static ForgeTypeId FamilyCurveGstyleFor2010Mass { get; }
      Description: "Subcategory"
    static ForgeTypeId FamilyCurveGstylePlusInvisible { get; }
      Description: "Subcategory"
    static ForgeTypeId FamilyCurveGstylePlusInvisibleMinusAnalytical { get; }
      Description: "Subcategory"
    static ForgeTypeId FamilyCurveGstylePlusInvisiblePlusStickSym { get; }
      Description: "Subcategory"
    static ForgeTypeId FamilyCurveGstylePlusInvisiblePlusStickSymMinusAnalytical { get; }
      Description: "Subcategory"
    static ForgeTypeId FamilyElectricalMaintainAnnotationOrientation { get; }
      Description: "Maintain Annotation Orientation"
    static ForgeTypeId FamilyElemSubcategory { get; }
      Description: "Subcategory"
    static ForgeTypeId FamilyEnableCuttingInViews { get; }
      Description: "Enable Cutting in Views"
    static ForgeTypeId FamilyExportAsGeometry { get; }
      Description: "Always export as geometry"
    static ForgeTypeId FamilyFreeinstDefaultElevation { get; }
      Description: "Default Elevation"
    static ForgeTypeId FamilyHeightParam { get; }
      Description: "Height"
    static ForgeTypeId FamilyHostingBehavior { get; }
      Description: "Host"
    static ForgeTypeId FamilyIsElevationMarkBody { get; }
      Description: "Elevation Mark Use"
    static ForgeTypeId FamilyIsParametric { get; }
      Description: "Is parametric"
    static ForgeTypeId FamilyKeepTextReadable { get; }
      Description: "Keep text readable"
    static ForgeTypeId FamilyKeyExtParam { get; }
      Description: "Filter Parameter"
    static ForgeTypeId FamilyKeywordProtected { get; }
      Description: "Content protection enabled"
    static ForgeTypeId FamilyLevelParam { get; }
      Description: "Level"
    static ForgeTypeId FamilyLineLengthParam { get; }
      Description: "Length"
    static ForgeTypeId FamilyNamePseudoParam { get; }
      Description: "Family"
    static ForgeTypeId FamilyNestingBehavior { get; }
      Description: "Family Nesting Behavior"
    static ForgeTypeId FamilyRenderingType { get; }
      Description: "Render Appearance Source"
    static ForgeTypeId FamilyRfaPathPseudoParam { get; }
      Description: "File Path"
    static ForgeTypeId FamilyRotateTextWithComponent { get; }
      Description: "Rotate text with component"
    static ForgeTypeId FamilyRotateWithComponent { get; }
      Description: "Rotate with component"
    static ForgeTypeId FamilyRoughHeightParam { get; }
      Description: "Rough Height"
    static ForgeTypeId FamilyRoughWidthParam { get; }
      Description: "Rough Width"
    static ForgeTypeId FamilyRoundconnectorDimensiontype { get; }
      Description: "Round Connector Dimension"
    static ForgeTypeId FamilySelfOrienting { get; }
      Description: "Align to View"
    static ForgeTypeId FamilyShared { get; }
      Description: "Shared"
    static ForgeTypeId FamilyStructFootingUseCapTop { get; }
      Description: "Cap"
    static ForgeTypeId FamilyStructMaterialType { get; }
      Description: "Material for Model Behavior"
    static ForgeTypeId FamilySymbolicRep { get; }
      Description: "Symbolic Representation"
    static ForgeTypeId FamilyThicknessParam { get; }
      Description: "Thickness"
    static ForgeTypeId FamilyTopLevelOffsetParam { get; }
      Description: "Top Offset"
    static ForgeTypeId FamilyTopLevelParam { get; }
      Description: "Top Level"
    static ForgeTypeId FamilyUsagePseudoParam { get; }
      Description: "Usage"
    static ForgeTypeId FamilyUsePrecutShape { get; }
      Description: "Show family pre-cut in plan views"
    static ForgeTypeId FamilyUsingMultiple { get; }
      Description: "Multiple Join"
    static ForgeTypeId FamilyWidthParam { get; }
      Description: "Width"
    static ForgeTypeId FamilyWindowInsetParam { get; }
      Description: "Inset"
    static ForgeTypeId FamilyWorkPlaneBased { get; }
      Description: "Work Plane-Based"
    static ForgeTypeId FamilyWpbDefaultElevation { get; }
      Description: "Default Elevation"
    static ForgeTypeId FamProfileDefinition { get; }
      Description: "Profile Definition"
    static ForgeTypeId FamProfileUsage { get; }
      Description: "Profile Usage"
    static ForgeTypeId FasciaDepthParam { get; }
      Description: "Fascia Depth"
    static ForgeTypeId FasciaMaterialParam { get; }
      Description: "Material"
    static ForgeTypeId FasciaProfileParam { get; }
      Description: "Profile"
    static ForgeTypeId FbxAssetType { get; }
      Description: "Light Source"
    static ForgeTypeId FbxLightAtADistance { get; }
      Description: "At a distance"
    static ForgeTypeId FbxLightBallastLoss { get; }
      Description: "Ballast Loss"
    static ForgeTypeId FbxLightColorFilter { get; }
      Description: "Color Filter"
    static ForgeTypeId FbxLightDimmingLightColor { get; }
      Description: "Dimming Lamp Color Temperature Shift"
    static ForgeTypeId FbxLightEfficacy { get; }
      Description: "Efficacy"
    static ForgeTypeId FbxLightEmitCircleDiameter { get; }
      Description: "Emit from Circle Diameter"
    static ForgeTypeId FbxLightEmitLineLength { get; }
      Description: "Emit from Line Length"
    static ForgeTypeId FbxLightEmitRectangleLength { get; }
      Description: "Emit from Rectangle Length"
    static ForgeTypeId FbxLightEmitRectangleWidth { get; }
      Description: "Emit from Rectangle Width"
    static ForgeTypeId FbxLightEmitShapeVisible { get; }
      Description: "Emit Shape Visible in Rendering"
    static ForgeTypeId FbxLightIlluminance { get; }
      Description: "Illuminance"
    static ForgeTypeId FbxLightInitialColorCtrl { get; }
      Description: "Initial Color"
    static ForgeTypeId FbxLightInitialColorName { get; }
      Description: "Temperature Color"
    static ForgeTypeId FbxLightInitialColorTemperature { get; }
      Description: "Initial Color Temperature"
    static ForgeTypeId FbxLightInitialIntensity { get; }
      Description: "Initial Intensity"
    static ForgeTypeId FbxLightInitialIntensityInputMethod { get; }
      Description: "Initial Light Intensity Input Method"
    static ForgeTypeId FbxLightLampLumenDepr { get; }
      Description: "Lamp Lumen Depreciation"
    static ForgeTypeId FbxLightLampTiltLoss { get; }
      Description: "Lamp Tilt Loss"
    static ForgeTypeId FbxLightLimunousFlux { get; }
      Description: "Luminous Flux"
    static ForgeTypeId FbxLightLimunousIntensity { get; }
      Description: "Luminous Intensity"
    static ForgeTypeId FbxLightLossFactorCtrl { get; }
      Description: "Light Loss Factor"
    static ForgeTypeId FbxLightLossFactorMethod { get; }
      Description: "Light Loss Input Method"
    static ForgeTypeId FbxLightLumenaireDirt { get; }
      Description: "Luminaire Dirt Depreciation"
    static ForgeTypeId FbxLightPhotometricFile { get; }
      Description: "Photometric Web File"
    static ForgeTypeId FbxLightPhotometricFileCache { get; }
      Description: "None"
    static ForgeTypeId FbxLightPhotometrics { get; }
      Description: "Light Source Definition"
    static ForgeTypeId FbxLightPhotometricsFam { get; }
      Description: "Light Source Definition (family)"
    static ForgeTypeId FbxLightSourceDiameter { get; }
      Description: "Light Source Symbol Size"
    static ForgeTypeId FbxLightSourceLength { get; }
      Description: "Light Source Symbol Length"
    static ForgeTypeId FbxLightSpotBeamAngle { get; }
      Description: "Spot Beam Angle"
    static ForgeTypeId FbxLightSpotFieldAngle { get; }
      Description: "Spot Field Angle"
    static ForgeTypeId FbxLightSpotTiltAngle { get; }
      Description: "Tilt Angle"
    static ForgeTypeId FbxLightSurfaceLoss { get; }
      Description: "Surface Depreciation Loss"
    static ForgeTypeId FbxLightTemperatureLoss { get; }
      Description: "Temperature Loss"
    static ForgeTypeId FbxLightTotalLightLoss { get; }
      Description: "Total Light Loss Factor"
    static ForgeTypeId FbxLightVoltageLoss { get; }
      Description: "Voltage Loss"
    static ForgeTypeId FbxLightWattage { get; }
      Description: "Wattage"
    static ForgeTypeId FilledRegionMasking { get; }
      Description: "Masking"
    static ForgeTypeId FillPatternIdParam { get; }
      Description: "Cut fill pattern"
    static ForgeTypeId FillPatternIdParamNoNo { get; }
      Description: "Fill Pattern"
    static ForgeTypeId FireRating { get; }
      Description: "Fire Rating"
    static ForgeTypeId FixedRotation { get; }
      Description: "Fixed Rotation"
    static ForgeTypeId FlexibleInstanceFlip { get; }
      Description: "Flip"
    static ForgeTypeId FloorAttrDefaultHeightParam { get; }
      Description: "Default Height above level"
    static ForgeTypeId FloorAttrDefaultThicknessParam { get; }
      Description: "Default Thickness"
    static ForgeTypeId FloorAttrThicknessParam { get; }
      Description: "Thickness"
    static ForgeTypeId FloorHeightabovelevelParam { get; }
      Description: "Height Offset From Level"
    static ForgeTypeId FloorParamIsStructural { get; }
      Description: "Structural"
    static ForgeTypeId FloorParamSpanDirection { get; }
      Description: "Span Direction"
    static ForgeTypeId FloorStructureIdParam { get; }
      Description: "Structure"
    static ForgeTypeId FollowSurface { get; }
      Description: "Follow Surface"
    static ForgeTypeId ForegroundAnyPatternIdParam { get; }
      Description: "Foreground Fill Pattern"
    static ForgeTypeId ForegroundDraftPatternIdParam { get; }
      Description: "Foreground Fill Pattern"
    static ForgeTypeId ForegroundPatternColorParam { get; }
      Description: "Foreground Pattern Color"
    static ForgeTypeId FramingLengthRoundoff { get; }
      Description: "Structural Framing Length Roundoff"
    static ForgeTypeId FramingShapeClassification { get; }
      Description: "Framing Shape"
    static ForgeTypeId FrictionFactor { get; }
      Description: "Friction Factor"
    static ForgeTypeId FunctionParam { get; }
      Description: "Function"
    static ForgeTypeId GbxmlEditDataParam { get; }
      Description: "Energy Settings"
    static ForgeTypeId GenericDepth { get; }
      Description: "Depth"
    static ForgeTypeId GenericZoneName { get; }
      Description: "Name"
    static ForgeTypeId GeoLocation { get; }
      Description: "Shared Site"
    static ForgeTypeId GeomVisibilityParam { get; }
      Description: "Visibility/Graphics Overrides"
    static ForgeTypeId GraphicDisplayOptions { get; }
      Description: "Graphic Display Options"
    static ForgeTypeId GraphicDisplayOptionsBackground { get; }
      Description: "Background"
    static ForgeTypeId GraphicDisplayOptionsFog { get; }
      Description: "Depth Cueing"
    static ForgeTypeId GraphicDisplayOptionsLighting { get; }
      Description: "Lighting"
    static ForgeTypeId GraphicDisplayOptionsModel { get; }
      Description: "Model Display"
    static ForgeTypeId GraphicDisplayOptionsPhotoExposure { get; }
      Description: "Photographic Exposure"
    static ForgeTypeId GraphicDisplayOptionsShadows { get; }
      Description: "Shadows"
    static ForgeTypeId GraphicDisplayOptionsSketchyLines { get; }
      Description: "Sketchy Lines"
    static ForgeTypeId GraphicDisplayOptionsSsIntensity { get; }
      Description: "Sun and Shadow Intensity"
    static ForgeTypeId GridBankColNum { get; }
      Description: "Column"
    static ForgeTypeId GridBankColWidth { get; }
      Description: "Column Distance"
    static ForgeTypeId GridBankRowHeight { get; }
      Description: "Row Distance"
    static ForgeTypeId GridBankRowNum { get; }
      Description: "Row"
    static ForgeTypeId GridBubbleEndn1 { get; }
      Description: "Plan View Symbols End 1 (Default)"
    static ForgeTypeId GridBubbleEndn2 { get; }
      Description: "Plan View Symbols End 2 (Default)"
    static ForgeTypeId GridBubbleLinePen { get; }
      Description: "Bubble Weight Number\n"
    static ForgeTypeId GridCenterSegmentColor { get; }
      Description: "Center Segment Color"
    static ForgeTypeId GridCenterSegmentPattern { get; }
      Description: "Center Segment Pattern"
    static ForgeTypeId GridCenterSegmentStyle { get; }
      Description: "Center Segment"
    static ForgeTypeId GridCenterSegmentWeight { get; }
      Description: "Center Segment Weight"
    static ForgeTypeId GridEndSegmentColor { get; }
      Description: "End Segment Color"
    static ForgeTypeId GridEndSegmentPattern { get; }
      Description: "End Segment Pattern"
    static ForgeTypeId GridEndSegmentsLength { get; }
      Description: "End Segments Length"
    static ForgeTypeId GridEndSegmentWeight { get; }
      Description: "End Segment Weight"
    static ForgeTypeId GridHeadTag { get; }
      Description: "Symbol"
    static ForgeTypeId GridlineSpecStatus { get; }
      Description: "Type Association"
    static ForgeTypeId GridNetLocationMark { get; }
      Description: "Location Mark": Provides grid system association information
    static ForgeTypeId GroupAllowedViewTypes { get; }
      Description: "Allowed View Types"
    static ForgeTypeId GroupAttachedParentName { get; }
      Description: "Attached to"
    static ForgeTypeId GroupLevel { get; }
      Description: "Reference Level"
    static ForgeTypeId GroupnameParam { get; }
      Description: "Group Name for Ribbon Combo Items (for Use with XAML)"
    static ForgeTypeId GroupOffsetFromLevel { get; }
      Description: "Origin Level Offset"
    static ForgeTypeId GuideGridNameParam { get; }
      Description: "Name"
    static ForgeTypeId GuideGridSpacingParam { get; }
      Description: "Guide Spacing"
    static ForgeTypeId GutterMaterialParam { get; }
      Description: "Material"
    static ForgeTypeId GutterProfileParam { get; }
      Description: "Profile"
    static ForgeTypeId HandrailHandClearanceParam { get; }
      Description: "Hand Clearance"
    static ForgeTypeId HandrailHeightParam { get; }
      Description: "Height"
    static ForgeTypeId HandrailProjectionParam { get; }
      Description: "Projection"
    static ForgeTypeId HandrailSupportsJustificationParam { get; }
      Description: "Justification"
    static ForgeTypeId HandrailSupportsLayoutParam { get; }
      Description: "Layout"
    static ForgeTypeId HandrailSupportsNumberParam { get; }
      Description: "Number"
    static ForgeTypeId HandrailSupportsSpacingParam { get; }
      Description: "Spacing"
    static ForgeTypeId HandrailSupportsTypeParam { get; }
      Description: "Family"
    static ForgeTypeId HeadOnPlacementMethod { get; }
      Description: "Draw in Foreground"
    static ForgeTypeId HeavyEndPen { get; }
      Description: "Heavy End Pen Weight"
    static ForgeTypeId HeavyTickMarkPen { get; }
      Description: "Heavy End Pen Weight"
    static ForgeTypeId HighestAssociatedLevel { get; }
      Description: "Highest Associated Level": The highest level associated with this Analytical Element.
    static ForgeTypeId HostAreaComputed { get; }
      Description: "Area"
    static ForgeTypeId HostIdParam { get; }
      Description: "Host Id"
    static ForgeTypeId HostPanelScheduleAsPanelParam { get; }
      Description: "Categorize as"
    static ForgeTypeId HostPerimeterComputed { get; }
      Description: "Perimeter"
    static ForgeTypeId HostSseCurvedEdgeConditionParam { get; }
      Description: "Curved Edge Condition"
    static ForgeTypeId HostVolumeComputed { get; }
      Description: "Volume"
    static ForgeTypeId IconIndexParam { get; }
      Description: "Index Into Image File Name Array (for Use with XAML)"
    static ForgeTypeId IdParam { get; }
      Description: "Id"
    static ForgeTypeId IfcApplicationName { get; }
      Description: "IfcApplicationName"
    static ForgeTypeId IfcApplicationVersion { get; }
      Description: "IfcApplicationVersion"
    static ForgeTypeId IfcBuildingGuid { get; }
      Description: "IfcBuilding GUID"
    static ForgeTypeId IfcExportElement { get; }
      Description: "Export to IFC"
    static ForgeTypeId IfcExportElementAs { get; }
      Description: "Export to IFC As"
    static ForgeTypeId IfcExportElementType { get; }
      Description: "Export Type to IFC"
    static ForgeTypeId IfcExportElementTypeAs { get; }
      Description: "Export Type to IFC As"
    static ForgeTypeId IfcExportPredefinedtype { get; }
      Description: "IFC Predefined Type"
    static ForgeTypeId IfcExportPredefinedtypeType { get; }
      Description: "Type IFC Predefined Type"
    static ForgeTypeId IfcGuid { get; }
      Description: "IfcGUID"
    static ForgeTypeId IfcImportMaterialName { get; }
      Description: "IFC Material Name"
    static ForgeTypeId IfcOrganization { get; }
      Description: "IfcOrganization"
    static ForgeTypeId IfcProjectGuid { get; }
      Description: "IfcProject GUID"
    static ForgeTypeId IfcSiteGuid { get; }
      Description: "IfcSite GUID"
    static ForgeTypeId IfcTypeGuid { get; }
      Description: "Type IfcGUID"
    static ForgeTypeId ImportAdtComponentsDesc { get; }
      Description: "Component Description"
    static ForgeTypeId ImportAdtEntityHeight { get; }
      Description: "Height"
    static ForgeTypeId ImportAdtEntityLength { get; }
      Description: "Length"
    static ForgeTypeId ImportAdtEntityRoll { get; }
      Description: "Roll"
    static ForgeTypeId ImportAdtEntityStructType { get; }
      Description: "Structural Type Name"
    static ForgeTypeId ImportAdtEntityStyle { get; }
      Description: "Style Name"
    static ForgeTypeId ImportAdtEntityThickness { get; }
      Description: "Thickness"
    static ForgeTypeId ImportAdtEntityType { get; }
      Description: "Type Name"
    static ForgeTypeId ImportAdtEntityWidth { get; }
      Description: "Width"
    static ForgeTypeId ImportBackground { get; }
      Description: "Draw Layer"
    static ForgeTypeId ImportBaseLevel { get; }
      Description: "Work Plane"
    static ForgeTypeId ImportBaseLevelOffset { get; }
      Description: "Offset from Work Plane"
    static ForgeTypeId ImportDisplayUnits { get; }
      Description: "Import Units"
    static ForgeTypeId ImportInstanceCuttingInView { get; }
      Description: "Enable Cutting in Views"
    static ForgeTypeId ImportInstanceScale { get; }
      Description: "Instance Scale"
    static ForgeTypeId ImportScale { get; }
      Description: "Scale Factor"
    static ForgeTypeId ImportSymbolName { get; }
      Description: "Name"
    static ForgeTypeId IndividualExcavationVolume { get; }
      Description: "Individual Excavation Volume"
    static ForgeTypeId InfrastructureAlignmentDescription { get; }
      Description: "Description"
    static ForgeTypeId InfrastructureAlignmentDisplayedEndStation { get; }
      Description: "Displayed End Station"
    static ForgeTypeId InfrastructureAlignmentDisplayedStartStation { get; }
      Description: "Displayed Start Station"
    static ForgeTypeId InfrastructureAlignmentName { get; }
      Description: "Name"
    static ForgeTypeId InsertOrientation { get; }
      Description: "Orientation"
    static ForgeTypeId InstanceElevationParam { get; }
      Description: "Elevation from Level"
    static ForgeTypeId InstanceFreeHostOffsetParam { get; }
      Description: "Offset from Host"
    static ForgeTypeId InstanceFreeHostParam { get; }
      Description: "Host"
    static ForgeTypeId InstanceHeadHeightParam { get; }
      Description: "Head Height"
    static ForgeTypeId InstanceLengthParam { get; }
      Description: "Length"
    static ForgeTypeId InstanceMoveBaseWithGrids { get; }
      Description: "Move Base With Grids"
    static ForgeTypeId InstanceMovesWithGridParam { get; }
      Description: "Moves With Grids"
    static ForgeTypeId InstanceMoveTopWithGrids { get; }
      Description: "Move Top With Grids"
    static ForgeTypeId InstanceOffsetPosParam { get; }
      Description: "Moves With Nearby Elements"
    static ForgeTypeId InstanceReferenceLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId InstanceScheduleOnlyLevelParam { get; }
      Description: "Schedule Level"
    static ForgeTypeId InstanceSillHeightParam { get; }
      Description: "Sill Height"
    static ForgeTypeId InstanceStructUsageParam { get; }
      Description: "Structural Usage"
    static ForgeTypeId InsulationScale { get; }
      Description: "Insulation Bulge to Width Ratio (1/x)"
    static ForgeTypeId InsulationWidth { get; }
      Description: "Insulation Width"
    static ForgeTypeId InteriorTickDisplay { get; }
      Description: "Interior Tick Mark Display"
    static ForgeTypeId IsVisibleParam { get; }
      Description: "Visible"
    static ForgeTypeId JoinStrengthOrder { get; }
      Description: "Abstract Join Strength Order"
    static ForgeTypeId JoistSystemClearSpacingParam { get; }
      Description: "Clear Spacing"
    static ForgeTypeId JoistSystemElemTagNewMembersView { get; }
      Description: "Tag new members in view"
    static ForgeTypeId JoistSystemFixedSpacingParam { get; }
      Description: "Fixed Spacing"
    static ForgeTypeId JoistSystemJustificationParam { get; }
      Description: "Justification"
    static ForgeTypeId JoistSystemLayoutRuleParam { get; }
      Description: "Layout Rule"
    static ForgeTypeId JoistSystemMaximumSpacingParam { get; }
      Description: "Maximum Spacing"
    static ForgeTypeId JoistSystemNewBeamTypeNoFamNameParam { get; }
      Description: "Beam Type (No Family Name)"
    static ForgeTypeId JoistSystemNewBeamTypeParam { get; }
      Description: "Beam Type"
    static ForgeTypeId JoistSystemNumBeamsSameType { get; }
      Description: "Num. of Beams With Same Type"
    static ForgeTypeId JoistSystemNumberOfLinesParam { get; }
      Description: "Number of Lines"
    static ForgeTypeId JoistSystemSpacingParam { get; }
      Description: "Centerline Spacing"
    static ForgeTypeId KeepReadable { get; }
      Description: "Keep Readable"
    static ForgeTypeId KeynoteNumber { get; }
      Description: "Key Value"
    static ForgeTypeId KeynoteParam { get; }
      Description: "Keynote"
    static ForgeTypeId KeynoteText { get; }
      Description: "Keynote Text"
    static ForgeTypeId KeySourceParam { get; }
      Description: "Key Source"
    static ForgeTypeId KeyValue { get; }
      Description: "Key Value"
    static ForgeTypeId LayerElemAreaComputed { get; }
      Description: "Area"
    static ForgeTypeId LayerElemBaseConstraint { get; }
      Description: "Base Constraint"
    static ForgeTypeId LayerElemBaseExtensionDis { get; }
      Description: "Base Extension Distance"
    static ForgeTypeId LayerElemCompoundElemFamily { get; }
      Description: "Compound Element Family"
    static ForgeTypeId LayerElemCompoundElemType { get; }
      Description: "Compound Element Type"
    static ForgeTypeId LayerElemFunction { get; }
      Description: "Function": Function
    static ForgeTypeId LayerElemIsCoreLayer { get; }
      Description: "Is Core Layer"
    static ForgeTypeId LayerElemIsStructuralMaterial { get; }
      Description: "Is Structural Material"
    static ForgeTypeId LayerElemIsVariable { get; }
      Description: "Is Variable"
    static ForgeTypeId LayerElemMaterials { get; }
      Description: "Material": Material
    static ForgeTypeId LayerElemOffsetFromHost { get; }
      Description: "Offset From Host"
    static ForgeTypeId LayerElemScheduleFamily { get; }
      Description: "Family"
    static ForgeTypeId LayerElemThickness { get; }
      Description: "Thickness": Thickness
    static ForgeTypeId LayerElemTopConstraint { get; }
      Description: "Top Constraint"
    static ForgeTypeId LayerElemTopExtensionDis { get; }
      Description: "Top Extension Distance"
    static ForgeTypeId LayerElemVolumeComputed { get; }
      Description: "Volume"
    static ForgeTypeId LayerTypeMaterials { get; }
      Description: "Material": Material
    static ForgeTypeId LayerTypeThickness { get; }
      Description: "Thickness": Thickness
    static ForgeTypeId LayoutnodeCurvetypeParam { get; }
      Description: "Curve Type Reference"
    static ForgeTypeId LeaderAngle { get; }
      Description: "Angle"
    static ForgeTypeId LeaderArrowhead { get; }
      Description: "Leader Arrowhead"
    static ForgeTypeId LeaderArrowWidth { get; }
      Description: "Arrow Width Angle"
    static ForgeTypeId LeaderLeftAttachment { get; }
      Description: "Left Attachment"
    static ForgeTypeId LeaderLength { get; }
      Description: "Leader Length"
    static ForgeTypeId LeaderLine { get; }
      Description: "Leader Line"
    static ForgeTypeId LeaderOffsetSheet { get; }
      Description: "Leader/Border Offset"
    static ForgeTypeId LeaderOrientation { get; }
      Description: "Orientation"
    static ForgeTypeId LeaderRightAttachment { get; }
      Description: "Right Attachment"
    static ForgeTypeId LegendComponent { get; }
      Description: "Component Type"
    static ForgeTypeId LegendComponentDetailLevel { get; }
      Description: "Detail Level"
    static ForgeTypeId LegendComponentLength { get; }
      Description: "Host Length"
    static ForgeTypeId LegendComponentView { get; }
      Description: "View Direction"
    static ForgeTypeId LevelAttrRoomComputationAutomatic { get; }
      Description: "Automatic Room Computation Height"
    static ForgeTypeId LevelAttrRoomComputationHeight { get; }
      Description: "Computation Height"
    static ForgeTypeId LevelDataFloorArea { get; }
      Description: "Floor Area"
    static ForgeTypeId LevelDataFloorPerimeter { get; }
      Description: "Floor Perimeter"
    static ForgeTypeId LevelDataMassFamilyAndTypeParam { get; }
      Description: "Mass: Family and Type"
    static ForgeTypeId LevelDataMassFamilyParam { get; }
      Description: "Mass: Family"
    static ForgeTypeId LevelDataMassInstanceComments { get; }
      Description: "Mass: Comments"
    static ForgeTypeId LevelDataMassTypeComments { get; }
      Description: "Mass: Type Comments"
    static ForgeTypeId LevelDataMassTypeDescription { get; }
      Description: "Mass: Description"
    static ForgeTypeId LevelDataMassTypeParam { get; }
      Description: "Mass: Type"
    static ForgeTypeId LevelDataOwningLevel { get; }
      Description: "Level"
    static ForgeTypeId LevelDataSpaceUsage { get; }
      Description: "Usage"
    static ForgeTypeId LevelDataSurfaceArea { get; }
      Description: "Exterior Surface Area"
    static ForgeTypeId LevelDataVolume { get; }
      Description: "Floor Volume"
    static ForgeTypeId LevelElev { get; }
      Description: "Elevation"
    static ForgeTypeId LevelHeadTag { get; }
      Description: "Symbol"
    static ForgeTypeId LevelIsBuildingStory { get; }
      Description: "Building Story"
    static ForgeTypeId LevelIsGroundPlane { get; }
      Description: "Is ground plane"
    static ForgeTypeId LevelIsStructural { get; }
      Description: "Structural"
    static ForgeTypeId LevelName { get; }
      Description: "Level"
    static ForgeTypeId LevelParam { get; }
      Description: "Level"
    static ForgeTypeId LevelRelativeBaseType { get; }
      Description: "Elevation Base"
    static ForgeTypeId LevelRoomComputationHeight { get; }
      Description: "Computation Height"
    static ForgeTypeId LevelUpToLevel { get; }
      Description: "Story Above"
    static ForgeTypeId LightingFixtureLamp { get; }
      Description: "Lamp"
    static ForgeTypeId LightingFixtureLightEmitter { get; }
      Description: "Light Emitter"
    static ForgeTypeId LightingFixtureWattage { get; }
      Description: "Wattage Comments"
    static ForgeTypeId LinearDimType { get; }
      Description: "Dimension String Type"
    static ForgeTypeId LinearFramingLength { get; }
      Description: "Length"
    static ForgeTypeId LineColor { get; }
      Description: "Color"
    static ForgeTypeId LinePattern { get; }
      Description: "Line Pattern"
    static ForgeTypeId LinePen { get; }
      Description: "Line Weight"
    static ForgeTypeId LineShapeAtCorner { get; }
      Description: "Line Shape at Landing Corner"
    static ForgeTypeId LoadAllNon0Loads { get; }
      Description: "All non 0 loads"
    static ForgeTypeId LoadAreaArea { get; }
      Description: "Area"
    static ForgeTypeId LoadAreaForceFx1 { get; }
      Description: "Fx 1"
    static ForgeTypeId LoadAreaForceFx2 { get; }
      Description: "Fx 2"
    static ForgeTypeId LoadAreaForceFx3 { get; }
      Description: "Fx 3"
    static ForgeTypeId LoadAreaForceFy1 { get; }
      Description: "Fy 1"
    static ForgeTypeId LoadAreaForceFy2 { get; }
      Description: "Fy 2"
    static ForgeTypeId LoadAreaForceFy3 { get; }
      Description: "Fy 3"
    static ForgeTypeId LoadAreaForceFz1 { get; }
      Description: "Fz 1"
    static ForgeTypeId LoadAreaForceFz2 { get; }
      Description: "Fz 2"
    static ForgeTypeId LoadAreaForceFz3 { get; }
      Description: "Fz 3"
    static ForgeTypeId LoadAreaIsProjected { get; }
      Description: "Projected Load"
    static ForgeTypeId LoadArrowSeparation { get; }
      Description: "Distance between arrows"
    static ForgeTypeId LoadAttrAreaForceScaleFactor { get; }
      Description: "Area force scale"
    static ForgeTypeId LoadAttrForceArrowType { get; }
      Description: "Force arrowhead"
    static ForgeTypeId LoadAttrForceScaleFactor { get; }
      Description: "Force scale"
    static ForgeTypeId LoadAttrLinearForceScaleFactor { get; }
      Description: "Linear force scale"
    static ForgeTypeId LoadAttrMomentArrowArc { get; }
      Description: "Moment arrowhead"
    static ForgeTypeId LoadAttrMomentArrowLine { get; }
      Description: "Moment arrowhead (alternate)"
    static ForgeTypeId LoadAttrMomentScaleFactor { get; }
      Description: "Moment scale"
    static ForgeTypeId LoadCaseId { get; }
      Description: "Load Case"
    static ForgeTypeId LoadCaseName { get; }
      Description: "Name"
    static ForgeTypeId LoadCaseNature { get; }
      Description: "Nature"
    static ForgeTypeId LoadCaseNatureText { get; }
      Description: "Nature"
    static ForgeTypeId LoadCaseNumber { get; }
      Description: "Case Number"
    static ForgeTypeId LoadCaseSubcategory { get; }
      Description: "Category"
    static ForgeTypeId LoadCombinationFactor { get; }
      Description: "Factor"
    static ForgeTypeId LoadCombinationName { get; }
      Description: "Name"
    static ForgeTypeId LoadComments { get; }
      Description: "Comments"
    static ForgeTypeId LoadDescription { get; }
      Description: "Description"
    static ForgeTypeId LoadForceFx { get; }
      Description: "Fx"
    static ForgeTypeId LoadForceFy { get; }
      Description: "Fy"
    static ForgeTypeId LoadForceFz { get; }
      Description: "Fz"
    static ForgeTypeId LoadIsConstrainedOnHost { get; }
      Description: "Is constrained on host"
    static ForgeTypeId LoadIsHosted { get; }
      Description: "Is Hosted"
    static ForgeTypeId LoadIsProjected { get; }
      Description: "Projected Load"
    static ForgeTypeId LoadIsReaction { get; }
      Description: "Is Reaction"
    static ForgeTypeId LoadIsUniform { get; }
      Description: "Uniform Load"
    static ForgeTypeId LoadLinearForceFx1 { get; }
      Description: "Fx 1"
    static ForgeTypeId LoadLinearForceFx2 { get; }
      Description: "Fx 2"
    static ForgeTypeId LoadLinearForceFy1 { get; }
      Description: "Fy 1"
    static ForgeTypeId LoadLinearForceFy2 { get; }
      Description: "Fy 2"
    static ForgeTypeId LoadLinearForceFz1 { get; }
      Description: "Fz 1"
    static ForgeTypeId LoadLinearForceFz2 { get; }
      Description: "Fz 2"
    static ForgeTypeId LoadLinearLength { get; }
      Description: "Length"
    static ForgeTypeId LoadMomentMx { get; }
      Description: "Mx"
    static ForgeTypeId LoadMomentMx1 { get; }
      Description: "Mx 1"
    static ForgeTypeId LoadMomentMx2 { get; }
      Description: "Mx 2"
    static ForgeTypeId LoadMomentMy { get; }
      Description: "My"
    static ForgeTypeId LoadMomentMy1 { get; }
      Description: "My 1"
    static ForgeTypeId LoadMomentMy2 { get; }
      Description: "My 2"
    static ForgeTypeId LoadMomentMz { get; }
      Description: "Mz"
    static ForgeTypeId LoadMomentMz1 { get; }
      Description: "Mz 1"
    static ForgeTypeId LoadMomentMz2 { get; }
      Description: "Mz 2"
    static ForgeTypeId LoadNatureName { get; }
      Description: "Name"
    static ForgeTypeId LoadUsageName { get; }
      Description: "Name"
    static ForgeTypeId LoadUseLocalCoordinateSystem { get; }
      Description: "Orient to"
    static ForgeTypeId LockAlignmentUiToggle { get; }
      Description: "Lock": This is used by the UI to allow selection of lock alignment.
    static ForgeTypeId LockedBaseOffset { get; }
      Description: "Negative Offset"
    static ForgeTypeId LockedEndOffset { get; }
      Description: "Positive Offset"
    static ForgeTypeId LockedStartOffset { get; }
      Description: "Negative Offset"
    static ForgeTypeId LockedTopOffset { get; }
      Description: "Positive Offset"
    static ForgeTypeId LowestAssociatedLevel { get; }
      Description: "Lowest Associated Level": The lowest level associated with this Analytical Element.
    static ForgeTypeId LvMullionLeg1 { get; }
      Description: "Leg 1"
    static ForgeTypeId LvMullionLeg2 { get; }
      Description: "Leg 2"
    static ForgeTypeId MarkupsCreated { get; }
      Description: "Created"
    static ForgeTypeId MarkupsCreator { get; }
      Description: "Creator"
    static ForgeTypeId MarkupsHistory { get; }
      Description: "History"
    static ForgeTypeId MarkupsLabel { get; }
      Description: "Label"
    static ForgeTypeId MarkupsModified { get; }
      Description: "Modified"
    static ForgeTypeId MarkupsNotes { get; }
      Description: "Notes"
    static ForgeTypeId MarkupsPrivate { get; }
      Description: "Private"
    static ForgeTypeId MarkupsStatus { get; }
      Description: "Status"
    static ForgeTypeId MassDataConceptualConstruction { get; }
      Description: "Conceptual Types"
    static ForgeTypeId MassDataGlazingIsShaded { get; }
      Description: "Glazing is Shaded"
    static ForgeTypeId MassDataMassExteriorWallArea { get; }
      Description: "Mass Exterior Wall Area"
    static ForgeTypeId MassDataMassInteriorWallArea { get; }
      Description: "Mass Interior Wall Area"
    static ForgeTypeId MassDataMassOpeningArea { get; }
      Description: "Mass Opening Area"
    static ForgeTypeId MassDataMassRoofArea { get; }
      Description: "Mass Roof Area"
    static ForgeTypeId MassDataMassSkylightArea { get; }
      Description: "Mass Skylight Area"
    static ForgeTypeId MassDataMassWindowArea { get; }
      Description: "Mass Window Area"
    static ForgeTypeId MassDataPercentageGlazing { get; }
      Description: "Target Percentage Glazing"
    static ForgeTypeId MassDataPercentageSkylights { get; }
      Description: "Target Percentage Skylights"
    static ForgeTypeId MassDataShadeDepth { get; }
      Description: "Shade Depth"
    static ForgeTypeId MassDataSillHeight { get; }
      Description: "Target Sill Height"
    static ForgeTypeId MassDataSkylightWidth { get; }
      Description: "Skylight Width & Depth"
    static ForgeTypeId MassDataSlab { get; }
      Description: "Slab"
    static ForgeTypeId MassDataSubcategory { get; }
      Description: "Subcategory"
    static ForgeTypeId MassDataSurfaceDataSource { get; }
      Description: "Values"
    static ForgeTypeId MassDataUnderground { get; }
      Description: "Underground"
    static ForgeTypeId MassFloorAreaLevels { get; }
      Description: "Mass Floors"
    static ForgeTypeId MassGrossArea { get; }
      Description: "Gross Floor Area"
    static ForgeTypeId MassGrossSurfaceArea { get; }
      Description: "Gross Surface Area"
    static ForgeTypeId MassGrossVolume { get; }
      Description: "Gross Volume"
    static ForgeTypeId MassingIntegrationLevel { get; }
      Description: "Constrain to Massing"
    static ForgeTypeId MassSurfacedataMaterial { get; }
      Description: "Graphical Appearance"
    static ForgeTypeId MassZoneConditionTypeParam { get; }
      Description: "Condition Type"
    static ForgeTypeId MassZoneFloorArea { get; }
      Description: "Mass Floor Area"
    static ForgeTypeId MassZoneMaterial { get; }
      Description: "Graphical Appearance"
    static ForgeTypeId MassZoneSpaceTypeParam { get; }
      Description: "Space Type"
    static ForgeTypeId MassZoneVolume { get; }
      Description: "Mass Zone Volume"
    static ForgeTypeId MatchlineBottomOffset { get; }
      Description: "Bottom Offset"
    static ForgeTypeId MatchlineBottomPlane { get; }
      Description: "Bottom Constraint"
    static ForgeTypeId MatchlineTopOffset { get; }
      Description: "Top Offset"
    static ForgeTypeId MatchlineTopPlane { get; }
      Description: "Top Constraint"
    static ForgeTypeId MaterialArea { get; }
      Description: "Area"
    static ForgeTypeId MaterialAspaint { get; }
      Description: "As Paint"
    static ForgeTypeId MaterialAssetParamAssetLibId { get; }
      Description: "Asset library id"
    static ForgeTypeId MaterialAssetParamCommonSharedAsset { get; }
      Description: "Sharing"
    static ForgeTypeId MaterialAssetParamExternalMaterialId { get; }
      Description: "External Material ID"
    static ForgeTypeId MaterialAssetParamSource { get; }
      Description: "Source"
    static ForgeTypeId MaterialAssetParamSourceUrl { get; }
      Description: "Source URL"
    static ForgeTypeId MaterialIdParam { get; }
      Description: "Material"
    static ForgeTypeId MaterialName { get; }
      Description: "Name"
    static ForgeTypeId MaterialParamColor { get; }
      Description: "Color"
    static ForgeTypeId MaterialParamGlow { get; }
      Description: "Glow"
    static ForgeTypeId MaterialParamShininess { get; }
      Description: "Shininess"
    static ForgeTypeId MaterialParamSmoothness { get; }
      Description: "Smoothness"
    static ForgeTypeId MaterialParamTransparency { get; }
      Description: "Transparency"
    static ForgeTypeId MaterialVolume { get; }
      Description: "Volume"
    static ForgeTypeId MeasureFromStructure { get; }
      Description: "Extend into wall (to core)"
    static ForgeTypeId MechanicalEquipmentSetIdParam { get; }
      Description: "Mechanical Equipment Set"
    static ForgeTypeId MechanicalEquipmentSetName { get; }
      Description: "Name"
    static ForgeTypeId MechanicalEquipmentSetOnDuty { get; }
      Description: "On Duty"
    static ForgeTypeId MechanicalEquipmentSetOnStandby { get; }
      Description: "On Standby"
    static ForgeTypeId MepAirloopFantype { get; }
      Description: "Fan"
    static ForgeTypeId MepAirloopHeatexchangerType { get; }
      Description: "Heat Exchanger"
    static ForgeTypeId MepAirloopPreheatCoiltype { get; }
      Description: "Preheat Coil"
    static ForgeTypeId MepAnalyticalCriticalpathParam { get; }
      Description: "Critical Path"
    static ForgeTypeId MepAnalyticalCriticalsequence { get; }
      Description: "Critical Sequence"
    static ForgeTypeId MepAnalyticalElecApparentPowerRating { get; }
      Description: "Apparent Power Rating"
    static ForgeTypeId MepAnalyticalElecCurrent { get; }
      Description: "Current"
    static ForgeTypeId MepAnalyticalElecCurrentRating { get; }
      Description: "Current Rating"
    static ForgeTypeId MepAnalyticalElecVoltage { get; }
      Description: "Voltage"
    static ForgeTypeId MepAnalyticalEquipmentName { get; }
      Description: "Name"
    static ForgeTypeId MepAnalyticalHeadersegment { get; }
      Description: "Header"
    static ForgeTypeId MepAnalyticalHydraulicloop { get; }
      Description: "Hydraulic Loop"
    static ForgeTypeId MepAnalyticalLoopBoundaryParam { get; }
      Description: "Loop Boundary"
    static ForgeTypeId MepAnalyticalLoopName { get; }
      Description: "Name"
    static ForgeTypeId MepAnalyticalNetwork { get; }
      Description: "Network Id"
    static ForgeTypeId MepAnalyticalPipeDesignflow { get; }
      Description: "Design Flow"
    static ForgeTypeId MepChilledWaterLoop { get; }
      Description: "Chilled Water Loop"
    static ForgeTypeId MepCondenserWaterLoop { get; }
      Description: "Condenser Water Loop"
    static ForgeTypeId MepCoolingCoilType { get; }
      Description: "Cooling Coil"
    static ForgeTypeId MepElecZoneEquipmentType { get; }
      Description: "Equipment Type"
    static ForgeTypeId MepEquipmentCalcPipingflowParam { get; }
      Description: "Calculated Flow"
    static ForgeTypeId MepEquipmentCalcPipingpressuredropParam { get; }
      Description: "Calculated Pressure Drop"
    static ForgeTypeId MepEquipmentClassification { get; }
      Description: "Classification"
    static ForgeTypeId MepHeatingCoilType { get; }
      Description: "Heating Coil"
    static ForgeTypeId MepHeatingHotwaterLoop { get; }
      Description: "Heating Hot Water Loop"
    static ForgeTypeId MepIgnoreFlowAnalysis { get; }
      Description: "Ignore Flow Analysis"
    static ForgeTypeId MepLowerBottomElevation { get; }
      Description: "Lower End Bottom Elevation"
    static ForgeTypeId MepLowerBottomElevationIncludeInsulation { get; }
      Description: "Lower End Bottom of Insulation Elevation"
    static ForgeTypeId MepLowerCenterlineElevation { get; }
      Description: "Lower End Centerline Elevation"
    static ForgeTypeId MepLowerTopElevation { get; }
      Description: "Lower End Top Elevation"
    static ForgeTypeId MepLowerTopElevationIncludeInsulation { get; }
      Description: "Lower End Top of Insulation Elevation"
    static ForgeTypeId MepPipeLowerInvertElevation { get; }
      Description: "Lower End Invert Elevation"
    static ForgeTypeId MepPipeLowerObvertElevation { get; }
      Description: "Lower End Obvert Elevation"
    static ForgeTypeId MepPipeUpperInvertElevation { get; }
      Description: "Upper End Invert Elevation"
    static ForgeTypeId MepPipeUpperObvertElevation { get; }
      Description: "Upper End Obvert Elevation"
    static ForgeTypeId MepPreheatHotwaterLoop { get; }
      Description: "Preheat Hot Water Loop"
    static ForgeTypeId MepProfileTypeParam { get; }
      Description: "Shape"
    static ForgeTypeId MepReheatCoilType { get; }
      Description: "Reheat Coil"
    static ForgeTypeId MepReheatHotwaterLoop { get; }
      Description: "Reheat Hot Water Loop"
    static ForgeTypeId MepSegmentElementTypename { get; }
      Description: "Type Name"
    static ForgeTypeId MepSegmentFamilyname { get; }
      Description: "Family Name"
    static ForgeTypeId MepSegmentLength { get; }
      Description: "Analytical Length"
    static ForgeTypeId MepSegmentSystemorservice { get; }
      Description: "System Type/Service Name"
    static ForgeTypeId MepSpotBottomElevation { get; }
      Description: "Spot Bottom Elevation": used for both design and fabrication components
    static ForgeTypeId MepSpotBottomElevationIncludeInsulation { get; }
      Description: "Spot Bottom of Insulation Elevation"
    static ForgeTypeId MepSpotCenterlineElevation { get; }
      Description: "Spot Centerline Elevation": used for both design and fabrication components
    static ForgeTypeId MepSpotTopElevation { get; }
      Description: "Spot Top Elevation": used for both design and fabrication components
    static ForgeTypeId MepSpotTopElevationIncludeInsulation { get; }
      Description: "Spot Top of Insulation Elevation"
    static ForgeTypeId MepSystemFillGraphicsOverridesParam { get; }
      Description: "Fill Pattern Graphics Overrides"
    static ForgeTypeId MepSystemLineGraphicsOverridesParam { get; }
      Description: "Graphic Overrides"
    static ForgeTypeId MepUpperBottomElevation { get; }
      Description: "Upper End Bottom Elevation"
    static ForgeTypeId MepUpperBottomElevationIncludeInsulation { get; }
      Description: "Upper End Bottom of Insulation Elevation"
    static ForgeTypeId MepUpperCenterlineElevation { get; }
      Description: "Upper End Centerline Elevation"
    static ForgeTypeId MepUpperTopElevation { get; }
      Description: "Upper End Top Elevation"
    static ForgeTypeId MepUpperTopElevationIncludeInsulation { get; }
      Description: "Upper End Top of Insulation Elevation"
    static ForgeTypeId MepVrfLoop { get; }
      Description: "Variable Refrigerant Flow Loop"
    static ForgeTypeId MepWaterloopChillertype { get; }
      Description: "Chiller Type"
    static ForgeTypeId MepWaterloopType { get; }
      Description: "Loop Type"
    static ForgeTypeId MepZoneAirLoop { get; }
      Description: "Air System"
    static ForgeTypeId MepZoneEquipment { get; }
      Description: "Zone Equipment"
    static ForgeTypeId MepZoneEquipmentBehavior { get; }
      Description: "Behavior"
    static ForgeTypeId MepZoneEquipmentDrawVentilation { get; }
      Description: "Draw Ventilation"
    static ForgeTypeId MepZoneEquipmentType { get; }
      Description: "Equipment Type"
    static ForgeTypeId MepZoneHotwaterLoop { get; }
      Description: "Heating Hot Water Loop"
    static ForgeTypeId ModelCategoryIdParam { get; }
      Description: "Subcategory"
    static ForgeTypeId ModelGraphicsStyle { get; }
      Description: "Visual Style"
    static ForgeTypeId ModelGraphicsStyleAnonDraft { get; }
      Description: "Visual Style"
    static ForgeTypeId ModelOrSymbolic { get; }
      Description: "Model or Symbolic"
    static ForgeTypeId ModelTextSize { get; }
      Description: "Text Size"
    static ForgeTypeId MovesWithGridParam { get; }
      Description: "Moves With Grids": Disable attachment from grids.
    static ForgeTypeId MullionAngle { get; }
      Description: "Angle"
    static ForgeTypeId MullionCornerType { get; }
      Description: "Corner Mullion"
    static ForgeTypeId MullionDepth { get; }
      Description: "Depth"
    static ForgeTypeId MullionDepth1 { get; }
      Description: "Depth 1"
    static ForgeTypeId MullionDepth2 { get; }
      Description: "Depth 2"
    static ForgeTypeId MullionFamType { get; }
      Description: "Mullion Family General Shape"
    static ForgeTypeId MullionOffset { get; }
      Description: "Offset"
    static ForgeTypeId MullionPosition { get; }
      Description: "Position"
    static ForgeTypeId MullionProfile { get; }
      Description: "Profile"
    static ForgeTypeId MultipleAlignmentUiToggle { get; }
      Description: "Multiple Alignment": This is used by the UI to allow selection of multiple elements.
    static ForgeTypeId MultiReferenceAnnotationDimensionStyle { get; }
      Description: "Dimension Style"
    static ForgeTypeId MultiReferenceAnnotationGroupTagHeads { get; }
      Description: "Group Matching Tag Heads"
    static ForgeTypeId MultiReferenceAnnotationReferenceCategory { get; }
      Description: "Reference Category"
    static ForgeTypeId MultiReferenceAnnotationShowDimensionText { get; }
      Description: "Show Dimension Text"
    static ForgeTypeId MultiReferenceAnnotationTagType { get; }
      Description: "Tag Family"
    static ForgeTypeId MultistoryStairsActualTreadDepth { get; }
      Description: "Actual Tread Depth"
    static ForgeTypeId MultistoryStairsRefLevel { get; }
      Description: "Reference Level": The reference level of stairs
    static ForgeTypeId NodeConnectionStatus { get; }
      Description: "Connection Status"
    static ForgeTypeId NumberPartitionParam { get; }
      Description: "Partition"
    static ForgeTypeId NumberSystemDisplayRule { get; }
      Description: "Display Rule"
    static ForgeTypeId NumberSystemJustify { get; }
      Description: "Justify"
    static ForgeTypeId NumberSystemJustifyOffset { get; }
      Description: "Justify Offset"
    static ForgeTypeId NumberSystemOrientation { get; }
      Description: "Orientation"
    static ForgeTypeId NumberSystemReference { get; }
      Description: "Reference"
    static ForgeTypeId NumberSystemReferenceOffset { get; }
      Description: "Offset from Reference"
    static ForgeTypeId NumberSystemTagType { get; }
      Description: "Tag Type"
    static ForgeTypeId NumberSystemTextSize { get; }
      Description: "Number Size"
    static ForgeTypeId ObjectStyleMaterialIdParam { get; }
      Description: "Object Style Material"
    static ForgeTypeId OffsetfacesShowShapeHandles { get; }
      Description: "Show Shape Handles"
    static ForgeTypeId OffsetFromReferenceBase { get; }
      Description: "Offset from Reference Base"
    static ForgeTypeId OmniclassCode { get; }
      Description: "OmniClass Number"
    static ForgeTypeId OmniclassDescription { get; }
      Description: "OmniClass Title"
    static ForgeTypeId OptionName { get; }
      Description: "Name"
    static ForgeTypeId OptionSetId { get; }
      Description: "Design Option Set Id"
    static ForgeTypeId OptionSetName { get; }
      Description: "Name"
    static ForgeTypeId OrdinateDimSetting { get; }
      Description: "Ordinate Dimension Settings"
    static ForgeTypeId OrientByView { get; }
      Description: "Rotate With Text"
    static ForgeTypeId OriginatingElementName { get; }
      Description: "Originating Element"
    static ForgeTypeId OvalFramingHeight { get; }
      Description: "Oval Height"
    static ForgeTypeId OvalFramingWidth { get; }
      Description: "Oval Width"
    static ForgeTypeId PaddingLength { get; }
      Description: "Padding"
    static ForgeTypeId PanelScheduleName { get; }
      Description: "Panel Schedule Name"
    static ForgeTypeId PartMakerDivisionProfileOffset { get; }
      Description: "Profile Offset"
    static ForgeTypeId PartmakerParamDivisionGap { get; }
      Description: "Gap"
    static ForgeTypeId PartMakerSplitterProfile { get; }
      Description: "Division Profile"
    static ForgeTypeId PartMakerSplitterProfileEdgeMatch { get; }
      Description: "Edge Match"
    static ForgeTypeId PartMakerSplitterProfileFlipAcross { get; }
      Description: "Profile Across Flip"
    static ForgeTypeId PartMakerSplitterProfileFlipAlong { get; }
      Description: "Profile Along Flip"
    static ForgeTypeId PathOfTravelFromRoom { get; }
      Description: "From Room"
    static ForgeTypeId PathOfTravelLevelName { get; }
      Description: "Level"
    static ForgeTypeId PathOfTravelSpeed { get; }
      Description: "Speed"
    static ForgeTypeId PathOfTravelTime { get; }
      Description: "Time"
    static ForgeTypeId PathOfTravelToRoom { get; }
      Description: "To Room"
    static ForgeTypeId PathOfTravelViewName { get; }
      Description: "View Name"
    static ForgeTypeId PathReinAddlOffset { get; }
      Description: "Additional Offset"
    static ForgeTypeId PathReinAlternating { get; }
      Description: "Alternating Bars"
    static ForgeTypeId PathReinAltOffset { get; }
      Description: "Alternating Bar - Offset"
    static ForgeTypeId PathReinEndHookOrient1Slab { get; }
      Description: "Primary Bar - End Hook Orientation"
    static ForgeTypeId PathReinEndHookOrient1Wall { get; }
      Description: "Primary Bar - End Hook Orientation"
    static ForgeTypeId PathReinEndHookOrient2Slab { get; }
      Description: "Alternating Bar - End Hook Orientation"
    static ForgeTypeId PathReinEndHookOrient2Wall { get; }
      Description: "Alternating Bar - End Hook Orientation"
    static ForgeTypeId PathReinEndHookTypen1 { get; }
      Description: "Primary Bar - End Hook Type"
    static ForgeTypeId PathReinEndHookTypen2 { get; }
      Description: "Alternating Bar - End Hook Type"
    static ForgeTypeId PathReinEndSpanhookAlt { get; }
      Description: "End Hook Angle Alternating"
    static ForgeTypeId PathReinEndSpanhookPrim { get; }
      Description: "End Hook Angle Primary"
    static ForgeTypeId PathReinFaceSlab { get; }
      Description: "Face"
    static ForgeTypeId PathReinFaceWall { get; }
      Description: "Face"
    static ForgeTypeId PathReinHookOrient1Slab { get; }
      Description: "Primary Bar - Hook Orientation"
    static ForgeTypeId PathReinHookOrient1Wall { get; }
      Description: "Primary Bar - Hook Orientation"
    static ForgeTypeId PathReinHookOrient2Slab { get; }
      Description: "Alternating Bar - Hook Orientation"
    static ForgeTypeId PathReinHookOrient2Wall { get; }
      Description: "Alternating Bar - Hook Orientation"
    static ForgeTypeId PathReinHookTypen1 { get; }
      Description: "Primary Bar - Start Hook Type"
    static ForgeTypeId PathReinHookTypen2 { get; }
      Description: "Alternating Bar - Start Hook Type"
    static ForgeTypeId PathReinLengthn1 { get; }
      Description: "Primary Bar - Length"
    static ForgeTypeId PathReinLengthn2 { get; }
      Description: "Alternating Bar - Length"
    static ForgeTypeId PathReinNumberOfBars { get; }
      Description: "Number Of Bars"
    static ForgeTypeId PathReinShapen1 { get; }
      Description: "Primary Bar - Shape"
    static ForgeTypeId PathReinShapen2 { get; }
      Description: "Alternating Bar - Shape"
    static ForgeTypeId PathReinSpacing { get; }
      Description: "Bar Spacing"
    static ForgeTypeId PathReinSpanhookAlt { get; }
      Description: "Start Hook Angle Alternating"
    static ForgeTypeId PathReinSpanhookPrim { get; }
      Description: "Start Hook Angle Primary"
    static ForgeTypeId PathReinSpanlengthAltOffset { get; }
      Description: "Offset"
    static ForgeTypeId PathReinSpanlengthBarlengthAlt { get; }
      Description: "Length (Alternating Bar)"
    static ForgeTypeId PathReinSpanlengthBarlengthPrim { get; }
      Description: "Length (Primary Bar)"
    static ForgeTypeId PathReinSpanlengthBottomAlt { get; }
      Description: "Bottom (Alternating Bar)"
    static ForgeTypeId PathReinSpanlengthBottomPrim { get; }
      Description: "Bottom (Primary Bar)"
    static ForgeTypeId PathReinSpanlengthTopAlt { get; }
      Description: "Top (Alternating Bar)"
    static ForgeTypeId PathReinSummary { get; }
      Description: "Summary"
    static ForgeTypeId PathReinTypen1 { get; }
      Description: "Primary Bar - Type"
    static ForgeTypeId PathReinTypen2 { get; }
      Description: "Alternating Bar - Type"
    static ForgeTypeId PatternIndent1ForDivisionRule { get; }
      Description: "Indent 1"
    static ForgeTypeId PatternIndent2ForDivisionRule { get; }
      Description: "Indent 2"
    static ForgeTypeId PatternMirrorForDivisionRule { get; }
      Description: "Mirror"
    static ForgeTypeId PeakAirflowParam { get; }
      Description: "Peak Airflow"
    static ForgeTypeId PeakCoolingLoadParam { get; }
      Description: "Peak Cooling Load"
    static ForgeTypeId PeakHeatingLoadParam { get; }
      Description: "Peak Heating Load"
    static ForgeTypeId PeakLatentCoolingLoad { get; }
      Description: "Peak Latent Cooling Load"
    static ForgeTypeId PhaseCreated { get; }
      Description: "Phase Created"
    static ForgeTypeId PhaseDemolished { get; }
      Description: "Phase Demolished"
    static ForgeTypeId PhaseName { get; }
      Description: "Name"
    static ForgeTypeId PhaseSequenceNumber { get; }
      Description: "Sequence Number"
    static ForgeTypeId PhyMaterialParamAverageModulus { get; }
      Description: "Average Modulus"
    static ForgeTypeId PhyMaterialParamBehavior { get; }
      Description: "Behavior"
    static ForgeTypeId PhyMaterialParamBending { get; }
      Description: "Bending"
    static ForgeTypeId PhyMaterialParamBendingReinforcement { get; }
      Description: "Bending reinforcement"
    static ForgeTypeId PhyMaterialParamClass { get; }
      Description: "Class"
    static ForgeTypeId PhyMaterialParamCompressionParallel { get; }
      Description: "Compression parallel to grain"
    static ForgeTypeId PhyMaterialParamCompressionPerpendicular { get; }
      Description: "Compression perpendicular to grain"
    static ForgeTypeId PhyMaterialParamConcreteCompression { get; }
      Description: "Concrete compression"
    static ForgeTypeId PhyMaterialParamExpCoeff { get; }
      Description: "Thermal expansion coefficient"
    static ForgeTypeId PhyMaterialParamExpCoeff1 { get; }
      Description: "Thermal expansion coefficient X"
    static ForgeTypeId PhyMaterialParamExpCoeff2 { get; }
      Description: "Thermal expansion coefficient Y"
    static ForgeTypeId PhyMaterialParamExpCoeff3 { get; }
      Description: "Thermal expansion coefficient Z"
    static ForgeTypeId PhyMaterialParamExpCoeffn1 { get; }
      Description: "Thermal Expansion Coefficient 1"
    static ForgeTypeId PhyMaterialParamExpCoeffn2 { get; }
      Description: "Thermal Expansion Coefficient 2"
    static ForgeTypeId PhyMaterialParamFivepercentModulusOfElacticity { get; }
      Description: "5% Modulus of Elasticity"
    static ForgeTypeId PhyMaterialParamGrade { get; }
      Description: "Grade"
    static ForgeTypeId PhyMaterialParamLightWeight { get; }
      Description: "Lightweight"
    static ForgeTypeId PhyMaterialParamMinimumTensileStrength { get; }
      Description: "Minimum tensile strength"
    static ForgeTypeId PhyMaterialParamMinimumYieldStress { get; }
      Description: "Minimum yield stress"
    static ForgeTypeId PhyMaterialParamPoissonMod { get; }
      Description: "Poisson ratio"
    static ForgeTypeId PhyMaterialParamPoissonMod1 { get; }
      Description: "Poisson ratio X"
    static ForgeTypeId PhyMaterialParamPoissonMod12 { get; }
      Description: "Poisson Ratio 12"
    static ForgeTypeId PhyMaterialParamPoissonMod2 { get; }
      Description: "Poisson ratio Y"
    static ForgeTypeId PhyMaterialParamPoissonMod23 { get; }
      Description: "Poisson Ratio 23"
    static ForgeTypeId PhyMaterialParamPoissonMod3 { get; }
      Description: "Poisson ratio Z"
    static ForgeTypeId PhyMaterialParamReductionFactor { get; }
      Description: "Reduction factor for shear"
    static ForgeTypeId PhyMaterialParamResistanceCalcStrength { get; }
      Description: "Resistance calculation strength"
    static ForgeTypeId PhyMaterialParamShearMod { get; }
      Description: "Shear modulus"
    static ForgeTypeId PhyMaterialParamShearMod1 { get; }
      Description: "Shear modulus X"
    static ForgeTypeId PhyMaterialParamShearMod12 { get; }
      Description: "Shear Modulus 12"
    static ForgeTypeId PhyMaterialParamShearMod2 { get; }
      Description: "Shear modulus Y"
    static ForgeTypeId PhyMaterialParamShearMod3 { get; }
      Description: "Shear modulus Z"
    static ForgeTypeId PhyMaterialParamShearParallel { get; }
      Description: "Shear parallel to grain"
    static ForgeTypeId PhyMaterialParamShearPerpendicular { get; }
      Description: "Shear perpendicular to grain"
    static ForgeTypeId PhyMaterialParamShearReinforcement { get; }
      Description: "Shear reinforcement yield stress"
    static ForgeTypeId PhyMaterialParamShearStrengthReduction { get; }
      Description: "Shear strength modification"
    static ForgeTypeId PhyMaterialParamSpecies { get; }
      Description: "Species"
    static ForgeTypeId PhyMaterialParamStructuralDensity { get; }
      Description: "Density"
    static ForgeTypeId PhyMaterialParamStructuralSpecificHeat { get; }
      Description: "Specific Heat"
    static ForgeTypeId PhyMaterialParamStructuralThermalTreated { get; }
      Description: "Thermally Treated"
    static ForgeTypeId PhyMaterialParamSubclass { get; }
      Description: "Subclass"
    static ForgeTypeId PhyMaterialParamTensionParallel { get; }
      Description: "Tension Parallel to Grain"
    static ForgeTypeId PhyMaterialParamTensionPerpendicular { get; }
      Description: "Tension Perpendicular to Grain"
    static ForgeTypeId PhyMaterialParamThermalConductivity { get; }
      Description: "Thermal Conductivity"
    static ForgeTypeId PhyMaterialParamThermalConductivityX { get; }
      Description: "Thermal Conductivity X"
    static ForgeTypeId PhyMaterialParamThermalConductivityY { get; }
      Description: "Thermal Conductivity Y"
    static ForgeTypeId PhyMaterialParamThermalConductivityZ { get; }
      Description: "Thermal Conductivity Z"
    static ForgeTypeId PhyMaterialParamType { get; }
      Description: "Material Type"
    static ForgeTypeId PhyMaterialParamUnitWeight { get; }
      Description: "Unit weight"
    static ForgeTypeId PhyMaterialParamWoodConstruction { get; }
      Description: "Construction"
    static ForgeTypeId PhyMaterialParamYoungMod { get; }
      Description: "Young modulus"
    static ForgeTypeId PhyMaterialParamYoungMod1 { get; }
      Description: "Young modulus X"
    static ForgeTypeId PhyMaterialParamYoungMod2 { get; }
      Description: "Young modulus Y"
    static ForgeTypeId PhyMaterialParamYoungMod3 { get; }
      Description: "Young modulus Z"
    static ForgeTypeId PhyMaterialParamYoungModn1 { get; }
      Description: "Young's Modulus 1"
    static ForgeTypeId PhyMaterialParamYoungModn2 { get; }
      Description: "Young's Modulus 2"
    static ForgeTypeId PhyMaterialProperties { get; }
      Description: "Properties"
    static ForgeTypeId PipeInsulationThickness { get; }
      Description: "Insulation Thickness"
    static ForgeTypeId PipeRoughness { get; }
      Description: "Roughness"
    static ForgeTypeId PipeVelocityPressure { get; }
      Description: "Velocity Pressure"
    static ForgeTypeId PipingConnectionType { get; }
      Description: "Connection Type"
    static ForgeTypeId PipingGenderType { get; }
      Description: "Gender Type"
    static ForgeTypeId PlacementBottom { get; }
      Description: "Bottom"
    static ForgeTypeId PlacementCenterX { get; }
      Description: "Center X"
    static ForgeTypeId PlacementCenterY { get; }
      Description: "Center Y"
    static ForgeTypeId PlacementLeft { get; }
      Description: "Left"
    static ForgeTypeId PlacementParamsShow { get; }
      Description: "Enable Position Parameters"
    static ForgeTypeId PlacementRight { get; }
      Description: "Right"
    static ForgeTypeId PlacementTop { get; }
      Description: "Top"
    static ForgeTypeId PlanRegionViewRange { get; }
      Description: "View Range"
    static ForgeTypeId PlanViewCutPlaneHeight { get; }
      Description: "Cut Plane Height"
    static ForgeTypeId PlanViewLevel { get; }
      Description: "Associated Level"
    static ForgeTypeId PlanViewNorth { get; }
      Description: "Orientation"
    static ForgeTypeId PlanViewRange { get; }
      Description: "View Range"
    static ForgeTypeId PlanViewTopClipHeight { get; }
      Description: "Top Clip Height"
    static ForgeTypeId PlanViewViewDir { get; }
      Description: "View Direction"
    static ForgeTypeId PlumbingFixturesCwConnection { get; }
      Description: "CW Connection"
    static ForgeTypeId PlumbingFixturesDrain { get; }
      Description: "Drain"
    static ForgeTypeId PlumbingFixturesHwConnection { get; }
      Description: "HW Connection"
    static ForgeTypeId PlumbingFixturesSupplyFitting { get; }
      Description: "Supply Fitting"
    static ForgeTypeId PlumbingFixturesSupplyPipe { get; }
      Description: "Supply Pipe"
    static ForgeTypeId PlumbingFixturesTrap { get; }
      Description: "Trap"
    static ForgeTypeId PlumbingFixturesVentConnection { get; }
      Description: "Vent Connection"
    static ForgeTypeId PlumbingFixturesWasteConnection { get; }
      Description: "Waste Connection"
    static ForgeTypeId PocheMatId { get; }
      Description: "Coarse Poche Material"
    static ForgeTypeId PointAdaptiveConstrained { get; }
      Description: "Constrained"
    static ForgeTypeId PointAdaptiveNumParam { get; }
      Description: "Number"
    static ForgeTypeId PointAdaptiveOrientationType { get; }
      Description: "Orients to"
    static ForgeTypeId PointAdaptiveShowNumber { get; }
      Description: "Show Placement Number"
    static ForgeTypeId PointAdaptiveTypeParam { get; }
      Description: "Point"
    static ForgeTypeId PointcloudinstanceName { get; }
      Description: "Name": The name of the instance as it will show in the Property Palette
    static ForgeTypeId PointcloudtypeScale { get; }
      Description: "Scale": The scale for this instance
    static ForgeTypeId PointElementAngle { get; }
      Description: "Angle"
    static ForgeTypeId PointElementChordLength { get; }
      Description: "Chord Length"
    static ForgeTypeId PointElementDriven { get; }
      Description: "Driven by Host"
    static ForgeTypeId PointElementDriving { get; }
      Description: "Driving Curve(s)"
    static ForgeTypeId PointElementHostedOnFaceUParam { get; }
      Description: "Hosted U Parameter"
    static ForgeTypeId PointElementHostedOnFaceVParam { get; }
      Description: "Hosted V Parameter"
    static ForgeTypeId PointElementHostedParam { get; }
      Description: "Hosted Parameter"
    static ForgeTypeId PointElementMeasureFrom { get; }
      Description: "Measure From"
    static ForgeTypeId PointElementMeasurementType { get; }
      Description: "Measurement Type"
    static ForgeTypeId PointElementMirrored { get; }
      Description: "Mirrored"
    static ForgeTypeId PointElementNonNormalizedCurveParamater { get; }
      Description: "Non-Normalized Curve Parameter"
    static ForgeTypeId PointElementNormalizedCurveParamater { get; }
      Description: "Normalized Curve Parameter"
    static ForgeTypeId PointElementNormalizedSegmentLength { get; }
      Description: "Normalized Segment Length"
    static ForgeTypeId PointElementOffset { get; }
      Description: "Offset"
    static ForgeTypeId PointElementRotationAngle { get; }
      Description: "Rotation Angle"
    static ForgeTypeId PointElementSegmentLength { get; }
      Description: "Segment Length"
    static ForgeTypeId PointElementShowNormalPlaneOnly { get; }
      Description: "Show Normal Reference Plane Only"
    static ForgeTypeId PointElementShowPlanes { get; }
      Description: "Show Reference Planes"
    static ForgeTypeId PointElementZflipped { get; }
      Description: "Flipped"
    static ForgeTypeId PointElevation { get; }
      Description: "Elevation"
    static ForgeTypeId PointFlexibleConstrained { get; }
      Description: "Constrained"
    static ForgeTypeId PointFlexibleNumParam { get; }
      Description: "Number"
    static ForgeTypeId PointFlexibleOrientationType { get; }
      Description: "Orientation"
    static ForgeTypeId PointFlexibleShowNumber { get; }
      Description: "Show Placement Number"
    static ForgeTypeId PointNameParam { get; }
      Description: "Name"
    static ForgeTypeId PointVisibilityParam { get; }
      Description: "Visibility/Graphics Overrides"
    static ForgeTypeId PreferDimSideUiFilter { get; }
      Description: "Prefer:": This is used by the UI to allow select prefer dimension side.
    static ForgeTypeId PreferPatternAlignUiFilter { get; }
      Description: "Pattern:": This is used by the UI to allow to select the preferred preference of aligning pattern.
    static ForgeTypeId PrimaryOptionId { get; }
      Description: "Primary Option Id"
    static ForgeTypeId Profile1Angle { get; }
      Description: "Angle"
    static ForgeTypeId Profile1FamType { get; }
      Description: "Profile"
    static ForgeTypeId Profile1FlippedHor { get; }
      Description: "Profile Is Flipped"
    static ForgeTypeId Profile1OffsetX { get; }
      Description: "Horizontal Profile Offset"
    static ForgeTypeId Profile1OffsetY { get; }
      Description: "Vertical Profile Offset"
    static ForgeTypeId Profile2Angle { get; }
      Description: "Angle"
    static ForgeTypeId Profile2FamType { get; }
      Description: "Profile"
    static ForgeTypeId Profile2FlippedHor { get; }
      Description: "Profile Is Flipped"
    static ForgeTypeId Profile2OffsetX { get; }
      Description: "Horizontal Profile Offset"
    static ForgeTypeId Profile2OffsetY { get; }
      Description: "Vertical Profile Offset"
    static ForgeTypeId ProfileAngle { get; }
      Description: "Angle"
    static ForgeTypeId ProfileFamType { get; }
      Description: "Profile"
    static ForgeTypeId ProfileFamTypePlusNone { get; }
      Description: "Profile"
    static ForgeTypeId ProfileFlippedHor { get; }
      Description: "Profile Is Flipped"
    static ForgeTypeId ProfileOffsetX { get; }
      Description: "Horizontal Profile Offset"
    static ForgeTypeId ProfileOffsetY { get; }
      Description: "Vertical Profile Offset"
    static ForgeTypeId ProfileParamAlongPath { get; }
      Description: "Parameter along path"
    static ForgeTypeId ProjectAddress { get; }
      Description: "Project Address"
    static ForgeTypeId ProjectAuthor { get; }
      Description: "Author"
    static ForgeTypeId ProjectBuildingName { get; }
      Description: "Building Name"
    static ForgeTypeId ProjectBuildingType { get; }
      Description: "Building Type"
    static ForgeTypeId ProjectedSurfaceArea { get; }
      Description: "Projected Area"
    static ForgeTypeId ProjectIssueDate { get; }
      Description: "Project Issue Date"
    static ForgeTypeId ProjectName { get; }
      Description: "Project Name"
    static ForgeTypeId ProjectNumber { get; }
      Description: "Project Number"
    static ForgeTypeId ProjectOrganizationDescription { get; }
      Description: "Organization Description"
    static ForgeTypeId ProjectOrganizationName { get; }
      Description: "Organization Name"
    static ForgeTypeId ProjectPostalCode { get; }
      Description: "Postal Code"
    static ForgeTypeId ProjectRevisionEnumeration { get; }
      Description: "Numbering"
    static ForgeTypeId ProjectRevisionRevisionDate { get; }
      Description: "Revision Date"
    static ForgeTypeId ProjectRevisionRevisionDescription { get; }
      Description: "Revision Description"
    static ForgeTypeId ProjectRevisionRevisionIssued { get; }
      Description: "Issued"
    static ForgeTypeId ProjectRevisionRevisionIssuedBy { get; }
      Description: "Issued by"
    static ForgeTypeId ProjectRevisionRevisionIssuedTo { get; }
      Description: "Issued to"
    static ForgeTypeId ProjectRevisionRevisionNum { get; }
      Description: "Revision Number"
    static ForgeTypeId ProjectRevisionSequenceNum { get; }
      Description: "Revision Sequence": read_only Make this read-only again when NewSchedules_DisplayTags is cleaned up
    static ForgeTypeId ProjectStatus { get; }
      Description: "Project Status"
    static ForgeTypeId PropertyArea { get; }
      Description: "Area"
    static ForgeTypeId PropertyAreaOpen { get; }
      Description: "Area"
    static ForgeTypeId PropertyAreaUnits { get; }
      Description: "Area Units, Format"
    static ForgeTypeId PropertyLengthUnits { get; }
      Description: "Units Format"
    static ForgeTypeId PropertySegmentBearing { get; }
      Description: "Bearing"
    static ForgeTypeId PropertySegmentDistance { get; }
      Description: "Distance"
    static ForgeTypeId PropertySegmentEW { get; }
      Description: "E/W"
    static ForgeTypeId PropertySegmentLR { get; }
      Description: "L/R"
    static ForgeTypeId PropertySegmentNS { get; }
      Description: "N/S"
    static ForgeTypeId PropertySegmentRadius { get; }
      Description: "Radius"
    static ForgeTypeId PropertySegmentSubcategoryId { get; }
      Description: "Subcategory"
    static ForgeTypeId PropertySetDescription { get; }
      Description: "Description"
    static ForgeTypeId PropertySetKeywords { get; }
      Description: "Keywords"
    static ForgeTypeId PropertySetMaterialAspect { get; }
      Description: "Material aspect"
    static ForgeTypeId PropertySetName { get; }
      Description: "Property Set Name"
    static ForgeTypeId PropertySubcategoryId { get; }
      Description: "Subcategory"
    static ForgeTypeId RadialArrayArcRadius { get; }
      Description: "Radius"
    static ForgeTypeId RadiusSymbolLocation { get; }
      Description: "Radius Symbol Location"
    static ForgeTypeId RadiusSymbolText { get; }
      Description: "Radius Symbol Text"
    static ForgeTypeId RailingSystemHandrailsHeightParam { get; }
      Description: "Height"
    static ForgeTypeId RailingSystemHandrailsLatteralOffset { get; }
      Description: "Lateral Offset"
    static ForgeTypeId RailingSystemHandrailsPositionParam { get; }
      Description: "Position"
    static ForgeTypeId RailingSystemHandrailsTypesParam { get; }
      Description: "Type"
    static ForgeTypeId RailingSystemHasTopRail { get; }
      Description: "Use Top Rail": Whether railing has top rail
    static ForgeTypeId RailingSystemSecondaryHandrailsHeightParam { get; }
      Description: "Height"
    static ForgeTypeId RailingSystemSecondaryHandrailsLatteralOffset { get; }
      Description: "Lateral Offset"
    static ForgeTypeId RailingSystemSecondaryHandrailsPositionParam { get; }
      Description: "Position"
    static ForgeTypeId RailingSystemSecondaryHandrailsTypesParam { get; }
      Description: "Type"
    static ForgeTypeId RailingSystemTopRailHeightParam { get; }
      Description: "Height"
    static ForgeTypeId RailingSystemTopRailTypesParam { get; }
      Description: "Type"
    static ForgeTypeId RampAttrLeftBalusterAttachPt { get; }
      Description: "Left Baluster Location"
    static ForgeTypeId RampAttrMaterial { get; }
      Description: "Ramp Material"
    static ForgeTypeId RampAttrMinInvSlope { get; }
      Description: "Ramp Max Slope (1/x)"
    static ForgeTypeId RampAttrRightBalusterAttachPt { get; }
      Description: "Right Baluster Location"
    static ForgeTypeId RampAttrShape { get; }
      Description: "Shape"
    static ForgeTypeId RampAttrTextFont { get; }
      Description: "Text Font"
    static ForgeTypeId RampAttrTextSize { get; }
      Description: "Text Size"
    static ForgeTypeId RampAttrThickness { get; }
      Description: "Thickness"
    static ForgeTypeId RampMaxRunLength { get; }
      Description: "Maximum Incline Length"
    static ForgeTypeId RasterEnableSnaps { get; }
      Description: "Enable Snaps"
    static ForgeTypeId RasterHorizontalScale { get; }
      Description: "Horizontal Scale"
    static ForgeTypeId RasterLockProportions { get; }
      Description: "Lock Proportions"
    static ForgeTypeId RasterSheetheight { get; }
      Description: "Height"
    static ForgeTypeId RasterSheetwidth { get; }
      Description: "Width"
    static ForgeTypeId RasterSymbolFilename { get; }
      Description: "Loaded from file"
    static ForgeTypeId RasterSymbolHeight { get; }
      Description: "Height"
    static ForgeTypeId RasterSymbolLinkloadStatus { get; }
      Description: "Link Status"
    static ForgeTypeId RasterSymbolPagenumber { get; }
      Description: "Page Number"
    static ForgeTypeId RasterSymbolPixelheight { get; }
      Description: "Height (pixels)"
    static ForgeTypeId RasterSymbolPixelwidth { get; }
      Description: "Width (pixels)"
    static ForgeTypeId RasterSymbolResolution { get; }
      Description: "Resolution (dpi)"
    static ForgeTypeId RasterSymbolViewname { get; }
      Description: "View Name"
    static ForgeTypeId RasterSymbolWidth { get; }
      Description: "Width"
    static ForgeTypeId RasterVerticalScale { get; }
      Description: "Vertical Scale"
    static ForgeTypeId RbsAdditionalFlow { get; }
      Description: "Additional Flow"
    static ForgeTypeId RbsAdjustableConnector { get; }
      Description: "Allow Slope Adjustments"
    static ForgeTypeId RbsAreaBasedLoadType { get; }
      Description: "Area Based Load Type"
    static ForgeTypeId RbsBuildingConstructionclass { get; }
      Description: "Building Infiltration Class"
    static ForgeTypeId RbsBuildingUseloadcredits { get; }
      Description: "Use Load Credits"
    static ForgeTypeId RbsCabletrayBendradius { get; }
      Description: "Bend Radius"
    static ForgeTypeId RbsCabletrayconduitBendorfitting { get; }
      Description: "Bend or Fitting"
    static ForgeTypeId RbsCabletrayconduitConnectorelemType { get; }
      Description: "Connector Type"
    static ForgeTypeId RbsCabletrayconduitrunLengthParam { get; }
      Description: "Length"
    static ForgeTypeId RbsCabletrayconduitSystemType { get; }
      Description: "System Type"
    static ForgeTypeId RbsCabletrayHeightParam { get; }
      Description: "Height"
    static ForgeTypeId RbsCabletrayRungheight { get; }
      Description: "Rung Height"
    static ForgeTypeId RbsCabletrayRungspace { get; }
      Description: "Rung Space"
    static ForgeTypeId RbsCabletrayRungwidth { get; }
      Description: "Rung Width"
    static ForgeTypeId RbsCabletrayrunHeightParam { get; }
      Description: "Height"
    static ForgeTypeId RbsCabletrayrunWidthParam { get; }
      Description: "Width"
    static ForgeTypeId RbsCabletrayShapetype { get; }
      Description: "Shape"
    static ForgeTypeId RbsCabletrayThickness { get; }
      Description: "Thickness"
    static ForgeTypeId RbsCabletrayWidthParam { get; }
      Description: "Width"
    static ForgeTypeId RbsCalculatedSize { get; }
      Description: "Size"
    static ForgeTypeId RbsComponentClassificationParam { get; }
      Description: "Component Classification"
    static ForgeTypeId RbsConduitBendradius { get; }
      Description: "Bend Radius"
    static ForgeTypeId RbsConduitDiameterParam { get; }
      Description: "Diameter(Trade Size)"
    static ForgeTypeId RbsConduitInnerDiamParam { get; }
      Description: "Inside Diameter"
    static ForgeTypeId RbsConduitOuterDiamParam { get; }
      Description: "Outside Diameter"
    static ForgeTypeId RbsConduitrunDiameterParam { get; }
      Description: "Diameter(Trade Size)"
    static ForgeTypeId RbsConduitrunInnerDiamParam { get; }
      Description: "Inside Diameter"
    static ForgeTypeId RbsConduitrunOuterDiamParam { get; }
      Description: "Outside Diameter"
    static ForgeTypeId RbsConduitTradesize { get; }
      Description: "Conduit Size Lookup"
    static ForgeTypeId RbsConnectorDescription { get; }
      Description: "Connector Description"
    static ForgeTypeId RbsConnectorIsprimary { get; }
      Description: "Primary Connector"
    static ForgeTypeId RbsConnectorOffsetObsolete { get; }
      Description: "Connector Offset"
    static ForgeTypeId RbsConstructionSetParam { get; }
      Description: "Schematic Types"
    static ForgeTypeId RbsConstructionTypeShadingfactorParam { get; }
      Description: "Internal Shading Factor"
    static ForgeTypeId RbsCtcBottomElevation { get; }
      Description: "Lower End Bottom Elevation"
    static ForgeTypeId RbsCtcServiceType { get; }
      Description: "Service Type"
    static ForgeTypeId RbsCtcTopElevation { get; }
      Description: "Upper End Top Elevation"
    static ForgeTypeId RbsCurveDiameterParam { get; }
      Description: "Diameter"
    static ForgeTypeId RbsCurveHeightParam { get; }
      Description: "Height"
    static ForgeTypeId RbsCurveHorOffsetParam { get; }
      Description: "Horizontal Justification"
    static ForgeTypeId RbsCurveSlope { get; }
      Description: "Slope Percentage (%)"
    static ForgeTypeId RbsCurveSurfaceArea { get; }
      Description: "Area"
    static ForgeTypeId RbsCurvetypeDefaultBendParam { get; }
      Description: "Bend"
    static ForgeTypeId RbsCurvetypeDefaultCapParam { get; }
      Description: "Cap"
    static ForgeTypeId RbsCurvetypeDefaultCrossParam { get; }
      Description: "Cross"
    static ForgeTypeId RbsCurvetypeDefaultElbowdownParam { get; }
      Description: "Vertical Outside Bend"
    static ForgeTypeId RbsCurvetypeDefaultElbowParam { get; }
      Description: "Elbow"
    static ForgeTypeId RbsCurvetypeDefaultElbowupParam { get; }
      Description: "Vertical Inside Bend"
    static ForgeTypeId RbsCurvetypeDefaultHorizontalBendParam { get; }
      Description: "Horizontal Bend"
    static ForgeTypeId RbsCurvetypeDefaultMechjointParam { get; }
      Description: "Flange"
    static ForgeTypeId RbsCurvetypeDefaultTakeoffParam { get; }
      Description: "Tap"
    static ForgeTypeId RbsCurvetypeDefaultTeedownParam { get; }
      Description: "Tee Down"
    static ForgeTypeId RbsCurvetypeDefaultTeeParam { get; }
      Description: "Tee"
    static ForgeTypeId RbsCurvetypeDefaultTeeupParam { get; }
      Description: "Tee Up"
    static ForgeTypeId RbsCurvetypeDefaultTransitionParam { get; }
      Description: "Transition"
    static ForgeTypeId RbsCurvetypeDefaultUnionParam { get; }
      Description: "Union"
    static ForgeTypeId RbsCurvetypeMaxHeightParam { get; }
      Description: "Max Height"
    static ForgeTypeId RbsCurvetypeMaxWidthParam { get; }
      Description: "Max Width"
    static ForgeTypeId RbsCurvetypeMultishapeTransitionOvalroundParam { get; }
      Description: "Multi Shape Transition Oval to Round"
    static ForgeTypeId RbsCurvetypeMultishapeTransitionParam { get; }
      Description: "Multi Shape Transition Rect to Round"
    static ForgeTypeId RbsCurvetypeMultishapeTransitionRectovalParam { get; }
      Description: "Multi Shape Transition Rect to Oval"
    static ForgeTypeId RbsCurvetypePreferredBranchParam { get; }
      Description: "Preferred Junction Type"
    static ForgeTypeId RbsCurveUtslope { get; }
      Description: "Slope"
    static ForgeTypeId RbsCurveVertOffsetParam { get; }
      Description: "Vertical Justification"
    static ForgeTypeId RbsCurveWidthParam { get; }
      Description: "Width"
    static ForgeTypeId RbsDistributionsysConfigParam { get; }
      Description: "Configuration"
    static ForgeTypeId RbsDistributionsysHlPhaseParam { get; }
      Description: "High-leg Phase"
    static ForgeTypeId RbsDistributionsysNumwiresParam { get; }
      Description: "Wires"
    static ForgeTypeId RbsDistributionsysPhaseParam { get; }
      Description: "Phase"
    static ForgeTypeId RbsDistributionsysVlgParam { get; }
      Description: "Line to Ground Voltage"
    static ForgeTypeId RbsDistributionsysVllParam { get; }
      Description: "Line to Line Voltage"
    static ForgeTypeId RbsDuctBottomElevation { get; }
      Description: "Lower End Bottom Elevation"
    static ForgeTypeId RbsDuctCalculatedSize { get; }
      Description: "Duct Size"
    static ForgeTypeId RbsDuctConnectorSystemClassificationParam { get; }
      Description: "System Classification"
    static ForgeTypeId RbsDuctFittingLossMethodParam { get; }
      Description: "Loss Method"
    static ForgeTypeId RbsDuctFittingLossMethodServerParam { get; }
      Description: "Loss Method"
    static ForgeTypeId RbsDuctFittingLossMethodSettings { get; }
      Description: "Loss Method Settings"
    static ForgeTypeId RbsDuctFittingLossTableParam { get; }
      Description: "ASHRAE Table"
    static ForgeTypeId RbsDuctFlowConfigurationParam { get; }
      Description: "Flow Configuration"
    static ForgeTypeId RbsDuctFlowDirectionParam { get; }
      Description: "Flow Direction"
    static ForgeTypeId RbsDuctFlowParam { get; }
      Description: "Flow"
    static ForgeTypeId RbsDuctPipeSystemAbbreviationParam { get; }
      Description: "System Abbreviation"
    static ForgeTypeId RbsDuctPressureDrop { get; }
      Description: "Pressure Drop"
    static ForgeTypeId RbsDuctRoutingPreferenceParam { get; }
      Description: "Routing Preferences"
    static ForgeTypeId RbsDuctSizeFormattedParam { get; }
      Description: "Size"
    static ForgeTypeId RbsDuctSlope { get; }
      Description: "Slope"
    static ForgeTypeId RbsDuctStaticPressure { get; }
      Description: "Static Pressure"
    static ForgeTypeId RbsDuctSystemCalculationParam { get; }
      Description: "Calculations"
    static ForgeTypeId RbsDuctSystemTypeParam { get; }
      Description: "System Type"
    static ForgeTypeId RbsDuctTopElevation { get; }
      Description: "Upper End Top Elevation"
    static ForgeTypeId RbsDuctTypeParam { get; }
      Description: "Duct Type"
    static ForgeTypeId RbsElecAmbientTemperature { get; }
      Description: "Ambient Temperature"
    static ForgeTypeId RbsElecAnalyticalArea { get; }
      Description: "Area"
    static ForgeTypeId RbsElecAnalyticalConnectedPhase { get; }
      Description: "Connected Phases"
    static ForgeTypeId RbsElecAnalyticalDownstreamConnectedPhases { get; }
      Description: "Downstream Connected Phases"
    static ForgeTypeId RbsElecAnalyticalFeederLength { get; }
      Description: "Length"
    static ForgeTypeId RbsElecAnalyticalHighLegPhase { get; }
      Description: "High-leg Phase"
    static ForgeTypeId RbsElecAnalyticalLevelId { get; }
      Description: "Level"
    static ForgeTypeId RbsElecAnalyticalLoadDensity { get; }
      Description: "Power Density"
    static ForgeTypeId RbsElecAnalyticalLoadNameParam { get; }
      Description: "Name"
    static ForgeTypeId RbsElecAnalyticalLoadSetOnDuty { get; }
      Description: "Quantity of Prime"
    static ForgeTypeId RbsElecAnalyticalLoadSetOnStandby { get; }
      Description: "Quantity on Standby"
    static ForgeTypeId RbsElecAnalyticalLoadSetOnTotal { get; }
      Description: "Total Quantity"
    static ForgeTypeId RbsElecAnalyticalLoadsInSet { get; }
      Description: "Loads in Set"
    static ForgeTypeId RbsElecAnalyticalLoadTypeParam { get; }
      Description: "Load Type"
    static ForgeTypeId RbsElecAnalyticalNumphases { get; }
      Description: "Number of Phases"
    static ForgeTypeId RbsElecAnalyticalSecondaryHighLegPhase { get; }
      Description: "Secondary High-leg Phase"
    static ForgeTypeId RbsElecAnalyticalTotalCoincidentLoad { get; }
      Description: "Total Coincident Loads"
    static ForgeTypeId RbsElecApparentCurrentParam { get; }
      Description: "Apparent Current"
    static ForgeTypeId RbsElecApparentCurrentPhaseaParam { get; }
      Description: "Apparent Current Phase A"
    static ForgeTypeId RbsElecApparentCurrentPhasebParam { get; }
      Description: "Apparent Current Phase B"
    static ForgeTypeId RbsElecApparentCurrentPhasecParam { get; }
      Description: "Apparent Current Phase C"
    static ForgeTypeId RbsElecApparentLoad { get; }
      Description: "Apparent Power"
    static ForgeTypeId RbsElecApparentLoadPhase1 { get; }
      Description: "Apparent Power Phase 1"
    static ForgeTypeId RbsElecApparentLoadPhase2 { get; }
      Description: "Apparent Power Phase 2"
    static ForgeTypeId RbsElecApparentLoadPhase3 { get; }
      Description: "Apparent Power Phase 3"
    static ForgeTypeId RbsElecApparentLoadPhasea { get; }
      Description: "Apparent Power Phase A"
    static ForgeTypeId RbsElecApparentLoadPhaseb { get; }
      Description: "Apparent Power Phase B"
    static ForgeTypeId RbsElecApparentLoadPhasec { get; }
      Description: "Apparent Power Phase C"
    static ForgeTypeId RbsElecApparentPowerDensity { get; }
      Description: "Apparent Power Density"
    static ForgeTypeId RbsElecBalancedLoad { get; }
      Description: "Balanced Load"
    static ForgeTypeId RbsElecCalcCoefficientUtilization { get; }
      Description: "Calculate Coefficient of Utilization"
    static ForgeTypeId RbsElecCircuitConnectionTypeParam { get; }
      Description: "Connection Type"
    static ForgeTypeId RbsElecCircuitFrameParam { get; }
      Description: "Frame"
    static ForgeTypeId RbsElecCircuitLengthParam { get; }
      Description: "Length"
    static ForgeTypeId RbsElecCircuitName { get; }
      Description: "Load Name"
    static ForgeTypeId RbsElecCircuitNaming { get; }
      Description: "Circuit Naming"
    static ForgeTypeId RbsElecCircuitNamingIndex { get; }
      Description: "Circuit Naming Index"
    static ForgeTypeId RbsElecCircuitNotesParam { get; }
      Description: "Schedule Circuit Notes"
    static ForgeTypeId RbsElecCircuitNumber { get; }
      Description: "Circuit Number"
    static ForgeTypeId RbsElecCircuitNumberingType { get; }
      Description: "Circuit Numbering Option"
    static ForgeTypeId RbsElecCircuitNumberOfElementsParam { get; }
      Description: "Number of Elements"
    static ForgeTypeId RbsElecCircuitPanelParam { get; }
      Description: "Panel"
    static ForgeTypeId RbsElecCircuitPathModeParam { get; }
      Description: "Path Mode"
    static ForgeTypeId RbsElecCircuitPathOffsetParam { get; }
      Description: "Offset"
    static ForgeTypeId RbsElecCircuitPrefix { get; }
      Description: "Circuit Prefix"
    static ForgeTypeId RbsElecCircuitPrefixSeparator { get; }
      Description: "Circuit Prefix Separator"
    static ForgeTypeId RbsElecCircuitRatingParam { get; }
      Description: "Rating"
    static ForgeTypeId RbsElecCircuitSlotIndex { get; }
      Description: "Slot Index"
    static ForgeTypeId RbsElecCircuitStartSlot { get; }
      Description: "Start Slot"
    static ForgeTypeId RbsElecCircuitType { get; }
      Description: "System Type"
    static ForgeTypeId RbsElecCircuitWireNumGroundsParam { get; }
      Description: "# of Ground Conductors"
    static ForgeTypeId RbsElecCircuitWireNumHotsParam { get; }
      Description: "# of Hot Conductors"
    static ForgeTypeId RbsElecCircuitWireNumNeutralsParam { get; }
      Description: "# of Neutral Conductors"
    static ForgeTypeId RbsElecCircuitWireNumRunsParam { get; }
      Description: "# of Runs"
    static ForgeTypeId RbsElecCircuitWireSizeParam { get; }
      Description: "Wire Size"
    static ForgeTypeId RbsElecCircuitWireTypeParam { get; }
      Description: "Wire Type"
    static ForgeTypeId RbsElecDemandCurrentPhasea { get; }
      Description: "Demand Current Phase A"
    static ForgeTypeId RbsElecDemandCurrentPhaseb { get; }
      Description: "Demand Current Phase B"
    static ForgeTypeId RbsElecDemandCurrentPhasec { get; }
      Description: "Demand Current Phase C"
    static ForgeTypeId RbsElecDemandfactorDemandloadParam { get; }
      Description: "Demand Apparent Power"
    static ForgeTypeId RbsElecDemandfactorLoadclassificationParam { get; }
      Description: "Load Classification"
    static ForgeTypeId RbsElecDemandfactorLoadParam { get; }
      Description: "Connected Apparent Power"
    static ForgeTypeId RbsElecDemandLoadPhasea { get; }
      Description: "Demand Apparent Power Phase A"
    static ForgeTypeId RbsElecDemandLoadPhaseb { get; }
      Description: "Demand Apparent Power Phase B"
    static ForgeTypeId RbsElecDemandLoadPhasec { get; }
      Description: "Demand Apparent Power Phase C"
    static ForgeTypeId RbsElecDistributionNodeLoadSet { get; }
      Description: "Load Set"
    static ForgeTypeId RbsElecDistributionNodeSupplyFrom { get; }
      Description: "Supply From"
    static ForgeTypeId RbsElecDistributionNodeSupplyFrom1 { get; }
      Description: "Supply From 1"
    static ForgeTypeId RbsElecDistributionNodeSupplyFrom2 { get; }
      Description: "Supply From 2"
    static ForgeTypeId RbsElecDistributionNodeSupplyTo { get; }
      Description: "Supply To"
    static ForgeTypeId RbsElecEditCircuitNamingSettingsParam { get; }
      Description: "Circuit Naming Settings"
    static ForgeTypeId RbsElecEnclosure { get; }
      Description: "Enclosure"
    static ForgeTypeId RbsElecLoadClassification { get; }
      Description: "Load Classification"
    static ForgeTypeId RbsElecLoadsummaryConnectedCurrentParam { get; }
      Description: "Connected Current"
    static ForgeTypeId RbsElecLoadsummaryConnectedLoadParam { get; }
      Description: "Connected Apparent Power"
    static ForgeTypeId RbsElecLoadsummaryDemandCurrentParam { get; }
      Description: "Estimated Demand Current"
    static ForgeTypeId RbsElecLoadsummaryDemandFactorParam { get; }
      Description: "Demand Factor"
    static ForgeTypeId RbsElecLoadsummaryDemandFactorRuleParam { get; }
      Description: "Description"
    static ForgeTypeId RbsElecLoadsummaryDemandLoadParam { get; }
      Description: "Demand Apparent Power"
    static ForgeTypeId RbsElecLoadsummaryLoadclassificationParam { get; }
      Description: "Load Classification"
    static ForgeTypeId RbsElecMains { get; }
      Description: "Mains"
    static ForgeTypeId RbsElecMaxCircuitsDataPanel { get; }
      Description: "Maximum Amount of Circuits"
    static ForgeTypeId RbsElecMaxPoleBreakers { get; }
      Description: "Max Number of Single Pole Breakers"
    static ForgeTypeId RbsElecModifications { get; }
      Description: "Modifications"
    static ForgeTypeId RbsElecMounting { get; }
      Description: "Mounting"
    static ForgeTypeId RbsElecNumberOfCircuits { get; }
      Description: "Max Number of Circuits"
    static ForgeTypeId RbsElecNumberOfPoles { get; }
      Description: "Number of Poles"
    static ForgeTypeId RbsElecPanelBranchCircuitApparentLoadPhasea { get; }
      Description: "Branch Circuit Apparent Power Phase A"
    static ForgeTypeId RbsElecPanelBranchCircuitApparentLoadPhaseb { get; }
      Description: "Branch Circuit Apparent Power Phase B"
    static ForgeTypeId RbsElecPanelBranchCircuitApparentLoadPhasec { get; }
      Description: "Branch Circuit Apparent Power Phase C"
    static ForgeTypeId RbsElecPanelBranchCircuitCurrentPhasea { get; }
      Description: "Branch Circuit Current Phase A"
    static ForgeTypeId RbsElecPanelBranchCircuitCurrentPhaseb { get; }
      Description: "Branch Circuit Current Phase B"
    static ForgeTypeId RbsElecPanelBranchCircuitCurrentPhasec { get; }
      Description: "Branch Circuit Current Phase C"
    static ForgeTypeId RbsElecPanelBussingParam { get; }
      Description: "Bussing"
    static ForgeTypeId RbsElecPanelConfigurationParam { get; }
      Description: "Panel Configuration"
    static ForgeTypeId RbsElecPanelCurrentPhaseaParam { get; }
      Description: "Current Phase A"
    static ForgeTypeId RbsElecPanelCurrentPhasebParam { get; }
      Description: "Current Phase B"
    static ForgeTypeId RbsElecPanelCurrentPhasecParam { get; }
      Description: "Current Phase C"
    static ForgeTypeId RbsElecPanelFeedParam { get; }
      Description: "Feed"
    static ForgeTypeId RbsElecPanelFeedThruLugsApparentLoadPhasea { get; }
      Description: "Feed Through Lugs Apparent Power Phase A"
    static ForgeTypeId RbsElecPanelFeedThruLugsApparentLoadPhaseb { get; }
      Description: "Feed Through Lugs Apparent Power Phase B"
    static ForgeTypeId RbsElecPanelFeedThruLugsApparentLoadPhasec { get; }
      Description: "Feed Through Lugs Apparent Power Phase C"
    static ForgeTypeId RbsElecPanelFeedThruLugsCurrentPhasea { get; }
      Description: "Feed Through Lugs Current Phase A"
    static ForgeTypeId RbsElecPanelFeedThruLugsCurrentPhaseb { get; }
      Description: "Feed Through Lugs Current Phase B"
    static ForgeTypeId RbsElecPanelFeedThruLugsCurrentPhasec { get; }
      Description: "Feed Through Lugs Current Phase C"
    static ForgeTypeId RbsElecPanelFeedThruLugsParam { get; }
      Description: "Feed Through Lugs"
    static ForgeTypeId RbsElecPanelGroundBusParam { get; }
      Description: "Ground Bus"
    static ForgeTypeId RbsElecPanelLocationParam { get; }
      Description: "Location"
    static ForgeTypeId RbsElecPanelMainstypeParam { get; }
      Description: "Mains Type"
    static ForgeTypeId RbsElecPanelMcbRatingParam { get; }
      Description: "MCB Rating"
    static ForgeTypeId RbsElecPanelName { get; }
      Description: "Panel Name"
    static ForgeTypeId RbsElecPanelNeutralBusParam { get; }
      Description: "Neutral Bus"
    static ForgeTypeId RbsElecPanelNeutralRatingParam { get; }
      Description: "Neutral Rating"
    static ForgeTypeId RbsElecPanelNumphasesParam { get; }
      Description: "Number of Phases"
    static ForgeTypeId RbsElecPanelNumwiresParam { get; }
      Description: "Number of Wires"
    static ForgeTypeId RbsElecPanelScheduleFooterNotesParam { get; }
      Description: "Schedule Footer Notes"
    static ForgeTypeId RbsElecPanelScheduleHeaderNotesParam { get; }
      Description: "Schedule Header Notes"
    static ForgeTypeId RbsElecPanelSubfeedLugsParam { get; }
      Description: "SubFeed Lugs"
    static ForgeTypeId RbsElecPanelSupplyFromParam { get; }
      Description: "Supply From"
    static ForgeTypeId RbsElecPanelTotalConnectedCurrentParam { get; }
      Description: "Total Connected Current"
    static ForgeTypeId RbsElecPanelTotalDemandCurrentParam { get; }
      Description: "Total Estimated Demand Current"
    static ForgeTypeId RbsElecPanelTotalDemandFactorParam { get; }
      Description: "Total Demand Factor"
    static ForgeTypeId RbsElecPanelTotalestloadHvacParam { get; }
      Description: "HVAC Total Demand Apparent Power"
    static ForgeTypeId RbsElecPanelTotalestloadLightParam { get; }
      Description: "Lighting Total Demand Apparent Power"
    static ForgeTypeId RbsElecPanelTotalestloadOtherParam { get; }
      Description: "Other Total Demand Apparent Power"
    static ForgeTypeId RbsElecPanelTotalestloadParam { get; }
      Description: "Total Demand Apparent Power"
    static ForgeTypeId RbsElecPanelTotalestloadPowerParam { get; }
      Description: "Power Total Demand Apparent Power"
    static ForgeTypeId RbsElecPanelTotalloadHvacParam { get; }
      Description: "HVAC Total Connected Apparent Power"
    static ForgeTypeId RbsElecPanelTotalloadLightParam { get; }
      Description: "Lighting Total Connected Apparent Power"
    static ForgeTypeId RbsElecPanelTotalloadOtherParam { get; }
      Description: "Other Total Connected Apparent Power"
    static ForgeTypeId RbsElecPanelTotalloadParam { get; }
      Description: "Total Connected Apparent Power"
    static ForgeTypeId RbsElecPanelTotalloadPowerParam { get; }
      Description: "Power Total Connected Apparent Power"
    static ForgeTypeId RbsElecPowerFactor { get; }
      Description: "Power Factor"
    static ForgeTypeId RbsElecPowerFactorState { get; }
      Description: "Power Factor State"
    static ForgeTypeId RbsElecRoomAverageIllumination { get; }
      Description: "Average Estimated Illumination"
    static ForgeTypeId RbsElecRoomCavityRatio { get; }
      Description: "Room Cavity Ratio"
    static ForgeTypeId RbsElecRoomLightingCalcLuminaireplane { get; }
      Description: "Lighting Calculation Luminaire Plane"
    static ForgeTypeId RbsElecRoomLightingCalcWorkplane { get; }
      Description: "Lighting Calculation Workplane"
    static ForgeTypeId RbsElecRoomReflectivityCeiling { get; }
      Description: "Ceiling Reflectance"
    static ForgeTypeId RbsElecRoomReflectivityFloor { get; }
      Description: "Floor Reflectance"
    static ForgeTypeId RbsElecRoomReflectivityWalls { get; }
      Description: "Wall Reflectance"
    static ForgeTypeId RbsElecShortCircuitRating { get; }
      Description: "Short Circuit Rating Comments"
    static ForgeTypeId RbsElecSwitchIdParam { get; }
      Description: "Switch ID"
    static ForgeTypeId RbsElectricalData { get; }
      Description: "Electrical Data"
    static ForgeTypeId RbsElecTrueCurrentParam { get; }
      Description: "True Current"
    static ForgeTypeId RbsElecTrueCurrentPhaseaParam { get; }
      Description: "True Current Phase A"
    static ForgeTypeId RbsElecTrueCurrentPhasebParam { get; }
      Description: "True Current Phase B"
    static ForgeTypeId RbsElecTrueCurrentPhasecParam { get; }
      Description: "True Current Phase C"
    static ForgeTypeId RbsElecTrueLoad { get; }
      Description: "True Power"
    static ForgeTypeId RbsElecTrueLoadPhase1 { get; }
      Description: "True Power Phase 1"
    static ForgeTypeId RbsElecTrueLoadPhase2 { get; }
      Description: "True Power Phase 2"
    static ForgeTypeId RbsElecTrueLoadPhase3 { get; }
      Description: "True Power Phase 3"
    static ForgeTypeId RbsElecTrueLoadPhasea { get; }
      Description: "True Power Phase A"
    static ForgeTypeId RbsElecTrueLoadPhaseb { get; }
      Description: "True Power Phase B"
    static ForgeTypeId RbsElecTrueLoadPhasec { get; }
      Description: "True Power Phase C"
    static ForgeTypeId RbsElecVoltage { get; }
      Description: "Voltage"
    static ForgeTypeId RbsElecVoltageDropParam { get; }
      Description: "Voltage Drop"
    static ForgeTypeId RbsElecWireCircuits { get; }
      Description: "Circuits"
    static ForgeTypeId RbsElecWireElevation { get; }
      Description: "Elevation"
    static ForgeTypeId RbsElecWireGroundAdjustment { get; }
      Description: "Ground Conductors"
    static ForgeTypeId RbsElecWireHotAdjustment { get; }
      Description: "Hot Conductors"
    static ForgeTypeId RbsElecWireNeutralAdjustment { get; }
      Description: "Neutral Conductors"
    static ForgeTypeId RbsElecWireShareGround { get; }
      Description: "Share Ground Conductor"
    static ForgeTypeId RbsElecWireShareNeutral { get; }
      Description: "Share Neutral Conductor"
    static ForgeTypeId RbsElecWireTickmarkState { get; }
      Description: "Tick Marks"
    static ForgeTypeId RbsElecWireType { get; }
      Description: "Type"
    static ForgeTypeId RbsEndLevelParam { get; }
      Description: "End Level"
    static ForgeTypeId RbsEndOffsetParam { get; }
      Description: "End Middle Elevation"
    static ForgeTypeId RbsEnergyAnalysisBuildingEnvelopeAnalyticalGridCellSize { get; }
      Description: "Analytical Grid Cell Size"
    static ForgeTypeId RbsEnergyAnalysisBuildingEnvelopeAnalyticalSpaceIdentificationResolution { get; }
      Description: "Analytical Space Resolution"
    static ForgeTypeId RbsEnergyAnalysisBuildingEnvelopeAnalyticalSurfaceIdentificationResolution { get; }
      Description: "Analytical Surface Resolution"
    static ForgeTypeId RbsEnergyAnalysisBuildingEnvelopeDeterminationParam { get; }
      Description: "Building Envelope"
    static ForgeTypeId RbsEnergyAnalysisExportCategoryParam { get; }
      Description: "Export Category"
    static ForgeTypeId RbsEnergyAnalysisExportComplexityParam { get; }
      Description: "Export Complexity"
    static ForgeTypeId RbsEnergyAnalysisExportGbxmlDefaultsParam { get; }
      Description: "Export Default Values"
    static ForgeTypeId RbsEnergyAnalysisGroundPlaneParam { get; }
      Description: "Ground Plane"
    static ForgeTypeId RbsEnergyAnalysisIncludeThermalProperties { get; }
      Description: "Detailed Elements"
    static ForgeTypeId RbsEnergyAnalysisMode { get; }
      Description: "Mode"
    static ForgeTypeId RbsEnergyAnalysisProjectPhaseParam { get; }
      Description: "Project Phase"
    static ForgeTypeId RbsEnergyAnalysisSliverSpaceTolerance { get; }
      Description: "Sliver Space Tolerance"
    static ForgeTypeId RbsEnergyAnalysisSurfaceAdjacentSpaceId1 { get; }
      Description: "Adjacent Space Id (1)"
    static ForgeTypeId RbsEnergyAnalysisSurfaceAdjacentSpaceId2 { get; }
      Description: "Adjacent Space Id (2)"
    static ForgeTypeId RbsEnergyAnalysisSurfaceAzimuth { get; }
      Description: "Azimuth"
    static ForgeTypeId RbsEnergyAnalysisSurfaceCadobjectid { get; }
      Description: "CADObjectID"
    static ForgeTypeId RbsEnergyAnalysisSurfaceOriginX { get; }
      Description: "Origin (X)"
    static ForgeTypeId RbsEnergyAnalysisSurfaceOriginY { get; }
      Description: "Origin (Y)"
    static ForgeTypeId RbsEnergyAnalysisSurfaceOriginZ { get; }
      Description: "Origin (Z)"
    static ForgeTypeId RbsEnergyAnalysisSurfaceTilt { get; }
      Description: "Tilt"
    static ForgeTypeId RbsEnergyAnalysisViewBuildingShellMode { get; }
      Description: "Show Analytical Building Shell"
    static ForgeTypeId RbsEnergyAnalysisViewCoordAxisMode { get; }
      Description: "Show a Coordinate System Symbol for each Surface"
    static ForgeTypeId RbsEnergyAnalysisViewInnerShellMode { get; }
      Description: "Show Inner Space Shells"
    static ForgeTypeId RbsEnergyAnalysisViewOuterShellMode { get; }
      Description: "Show Analytical Space Shells"
    static ForgeTypeId RbsEnergyAnalysisViewRbeMode { get; }
      Description: "Show Room Bounding Elements Dimmed and Underlay"
    static ForgeTypeId RbsEnergyAnalysisViewShadingSurfacesMode { get; }
      Description: "Show Shading Surfaces"
    static ForgeTypeId RbsEnergyAnalysisViewSurfacesMode { get; }
      Description: "Show Surfaces"
    static ForgeTypeId RbsEnergyAnalysisViewTransparentMode { get; }
      Description: "Show Surfaces Transparent"
    static ForgeTypeId RbsEnergyAnalysisViewUpdateSurfaces { get; }
      Description: "Update Surfaces"
    static ForgeTypeId RbsEqDiameterParam { get; }
      Description: "Equivalent Diameter"
    static ForgeTypeId RbsFamilyContentAnnotationDisplay { get; }
      Description: "Use Annotation Scale"
    static ForgeTypeId RbsFamilyContentDistributionSystem { get; }
      Description: "Distribution System"
    static ForgeTypeId RbsFamilyContentOffsetHeight { get; }
      Description: "OffsetHeight"
    static ForgeTypeId RbsFamilyContentOffsetWidth { get; }
      Description: "OffsetWidth"
    static ForgeTypeId RbsFamilyContentSecondaryDistribsys { get; }
      Description: "Secondary Distribution System"
    static ForgeTypeId RbsFamilyContentTakeoffFixedLength { get; }
      Description: "Takeoff Fixed Length"
    static ForgeTypeId RbsFamilyContentTakeoffLength { get; }
      Description: "Takeoff Length"
    static ForgeTypeId RbsFamilyContentTakeoffProjlength { get; }
      Description: "Takeoff Length Projection"
    static ForgeTypeId RbsFlexductRoundtypeParam { get; }
      Description: "Flex Duct Type"
    static ForgeTypeId RbsFlexDuctTypeParam { get; }
      Description: "Flex Duct Type"
    static ForgeTypeId RbsFlexPatternParam { get; }
      Description: "Flex Pattern"
    static ForgeTypeId RbsFlexPipeTypeParam { get; }
      Description: "Flex Pipe"
    static ForgeTypeId RbsFlowFactorParam { get; }
      Description: "Flow Factor"
    static ForgeTypeId RbsFlowObsolete { get; }
      Description: "Flow"
    static ForgeTypeId RbsFpSprinklerCoverageParam { get; }
      Description: "Coverage"
    static ForgeTypeId RbsFpSprinklerKFactorParam { get; }
      Description: "K-Factor"
    static ForgeTypeId RbsFpSprinklerOrificeParam { get; }
      Description: "Orifice"
    static ForgeTypeId RbsFpSprinklerOrificeSizeParam { get; }
      Description: "Orifice Size"
    static ForgeTypeId RbsFpSprinklerPressureClassParam { get; }
      Description: "Pressure Class"
    static ForgeTypeId RbsFpSprinklerResponseParam { get; }
      Description: "Response"
    static ForgeTypeId RbsFpSprinklerTemperatureRatingParam { get; }
      Description: "Temperature Rating"
    static ForgeTypeId RbsFriction { get; }
      Description: "Friction"
    static ForgeTypeId RbsGbxmlOpeningType { get; }
      Description: "Opening Type"
    static ForgeTypeId RbsGbxmlSurfaceArea { get; }
      Description: "Area"
    static ForgeTypeId RbsGbxmlSurfaceName { get; }
      Description: "Surface Name"
    static ForgeTypeId RbsGbxmlSurfaceType { get; }
      Description: "Surface Type"
    static ForgeTypeId RbsHvacloadDoorAreaParam { get; }
      Description: "Door Area"
    static ForgeTypeId RbsHvacloadDoorCoolingLoadParam { get; }
      Description: "Door Cooling Load"
    static ForgeTypeId RbsHvacloadFloorAreaParam { get; }
      Description: "Floor Area"
    static ForgeTypeId RbsHvacloadPartitionAreaParam { get; }
      Description: "Partition Area"
    static ForgeTypeId RbsHvacloadPartitionCoolingLoadParam { get; }
      Description: "Partition Cooling Load"
    static ForgeTypeId RbsHvacloadPlenumCoolingLoadParam { get; }
      Description: "Plenum Cooling Load"
    static ForgeTypeId RbsHvacloadRoofAreaParam { get; }
      Description: "Roof Area"
    static ForgeTypeId RbsHvacloadRoofCoolingLoadParam { get; }
      Description: "Roof Cooling Load"
    static ForgeTypeId RbsHvacloadSkylightAreaParam { get; }
      Description: "Skylight Area"
    static ForgeTypeId RbsHvacloadSkylightCoolingLoadParam { get; }
      Description: "Skylight Cooling Load"
    static ForgeTypeId RbsHvacloadWallAreaParam { get; }
      Description: "Wall Area"
    static ForgeTypeId RbsHvacloadWallCoolingLoadParam { get; }
      Description: "Wall Cooling Load"
    static ForgeTypeId RbsHvacloadWindowAreaParam { get; }
      Description: "Window Area"
    static ForgeTypeId RbsHvacloadWindowCoolingLoadParam { get; }
      Description: "Window Cooling Load"
    static ForgeTypeId RbsHydraulicDiameterParam { get; }
      Description: "Hydraulic Diameter"
    static ForgeTypeId RbsInsulationLiningVolume { get; }
      Description: "Volume"
    static ForgeTypeId RbsInsulationThickness { get; }
      Description: "Insulation Thickness"
    static ForgeTypeId RbsInsulationThicknessForDuct { get; }
      Description: "Insulation Thickness"
    static ForgeTypeId RbsInsulationThicknessForPipe { get; }
      Description: "Insulation Thickness"
    static ForgeTypeId RbsIsCustomFitting { get; }
      Description: "IsCustom"
    static ForgeTypeId RbsLiningThickness { get; }
      Description: "Lining Thickness"
    static ForgeTypeId RbsLiningThicknessForDuct { get; }
      Description: "Lining Thickness"
    static ForgeTypeId RbsLoadSubClassificationMotor { get; }
      Description: "Load Sub-Classification Motor"
    static ForgeTypeId RbsLookupTableName { get; }
      Description: "Lookup Table Name"
    static ForgeTypeId RbsLossCoefficient { get; }
      Description: "Loss Coefficient"
    static ForgeTypeId RbsMaxFlow { get; }
      Description: "Max Flow"
    static ForgeTypeId RbsMinFlow { get; }
      Description: "Min Flow"
    static ForgeTypeId RbsOffsetParam { get; }
      Description: "Middle Elevation"
    static ForgeTypeId RbsPanelScheduleSheetAppearanceInstParam { get; }
      Description: "Appearance"
    static ForgeTypeId RbsPanelScheduleSheetAppearanceParam { get; }
      Description: "Appearance On Sheet"
    static ForgeTypeId RbsParallelconduitsHorizontalNumber { get; }
      Description: "Horizontal Number for parallel conduits"
    static ForgeTypeId RbsParallelconduitsHorizontalOffsetValue { get; }
      Description: "Horizontal Offset value for parallel conduits"
    static ForgeTypeId RbsParallelconduitsVerticalNumber { get; }
      Description: "Vertical Number for parallel conduits"
    static ForgeTypeId RbsParallelconduitsVerticalOffsetValue { get; }
      Description: "Vertical Offset value for parallel conduits"
    static ForgeTypeId RbsParallelpipesHorizontalNumber { get; }
      Description: "Horizontal Number for parallel pipes"
    static ForgeTypeId RbsParallelpipesHorizontalOffsetValue { get; }
      Description: "Horizontal Offset value for parallel pipes"
    static ForgeTypeId RbsParallelpipesVerticalNumber { get; }
      Description: "Vertical Number for parallel pipes"
    static ForgeTypeId RbsParallelpipesVerticalOffsetValue { get; }
      Description: "Vertical Offset value for parallel pipes"
    static ForgeTypeId RbsPartType { get; }
      Description: "Part Type"
    static ForgeTypeId RbsPipeAdditionalFlowParam { get; }
      Description: "Additional Flow"
    static ForgeTypeId RbsPipeBottomElevation { get; }
      Description: "Lower End Bottom Elevation"
    static ForgeTypeId RbsPipeCalculatedSize { get; }
      Description: "Pipe Size"
    static ForgeTypeId RbsPipeClassParam { get; }
      Description: "Schedule/Type"
    static ForgeTypeId RbsPipeConnectiontypeParam { get; }
      Description: "Connection Type"
    static ForgeTypeId RbsPipeConnectorSystemClassificationParam { get; }
      Description: "System Classification"
    static ForgeTypeId RbsPipeCwfuParam { get; }
      Description: "CWFU"
    static ForgeTypeId RbsPipeDiameterParam { get; }
      Description: "Diameter"
    static ForgeTypeId RbsPipeFittingLossKfactorParam { get; }
      Description: "K Coefficient"
    static ForgeTypeId RbsPipeFittingLossMethodParam { get; }
      Description: "Loss Method"
    static ForgeTypeId RbsPipeFittingLossMethodServerParam { get; }
      Description: "Loss Method"
    static ForgeTypeId RbsPipeFittingLossMethodSettings { get; }
      Description: "Loss Method Settings"
    static ForgeTypeId RbsPipeFittingLossTableParam { get; }
      Description: "K Coefficient Table"
    static ForgeTypeId RbsPipeFixtureUnitsParam { get; }
      Description: "Fixture Units"
    static ForgeTypeId RbsPipeFlowConfigurationParam { get; }
      Description: "Flow Configuration"
    static ForgeTypeId RbsPipeFlowDirectionParam { get; }
      Description: "Flow Direction"
    static ForgeTypeId RbsPipeFlowParam { get; }
      Description: "Flow"
    static ForgeTypeId RbsPipeFlowStateParam { get; }
      Description: "Flow State"
    static ForgeTypeId RbsPipeFluidDensityParam { get; }
      Description: "Fluid Density"
    static ForgeTypeId RbsPipeFluidTemperatureParam { get; }
      Description: "Fluid Temperature"
    static ForgeTypeId RbsPipeFluidTypeParam { get; }
      Description: "Fluid Type"
    static ForgeTypeId RbsPipeFluidViscosityParam { get; }
      Description: "Fluid Dynamic Viscosity"
    static ForgeTypeId RbsPipeFrictionParam { get; }
      Description: "Friction"
    static ForgeTypeId RbsPipeHwfuParam { get; }
      Description: "HWFU"
    static ForgeTypeId RbsPipeInnerDiamParam { get; }
      Description: "Inside Diameter"
    static ForgeTypeId RbsPipeInsulationThickness { get; }
      Description: "Insulation Thickness"
    static ForgeTypeId RbsPipeInvertElevation { get; }
      Description: "Invert Elevation": This parameter is obsolete. It exists only for compatibility.
    static ForgeTypeId RbsPipeJointtypeParam { get; }
      Description: "Connection Type"
    static ForgeTypeId RbsPipeMaterialParam { get; }
      Description: "Material"
    static ForgeTypeId RbsPipeOuterDiameter { get; }
      Description: "Outside Diameter"
    static ForgeTypeId RbsPipePressuredropParam { get; }
      Description: "Pressure Drop"
    static ForgeTypeId RbsPipeReynoldsNumberParam { get; }
      Description: "Reynolds Number"
    static ForgeTypeId RbsPipeSegmentParam { get; }
      Description: "Pipe Segment"
    static ForgeTypeId RbsPipeSizeFormattedParam { get; }
      Description: "Size"
    static ForgeTypeId RbsPipeSizeMaximum { get; }
      Description: "Maximum Size"
    static ForgeTypeId RbsPipeSizeMinimum { get; }
      Description: "Minimum Size"
    static ForgeTypeId RbsPipeSlope { get; }
      Description: "Slope"
    static ForgeTypeId RbsPipeSlopeDefParam { get; }
      Description: "Pipe Slope Definitions"
    static ForgeTypeId RbsPipeSlopeOptionsDefParam { get; }
      Description: "Pipe Slope Options"
    static ForgeTypeId RbsPipeStaticPressure { get; }
      Description: "Static Pressure"
    static ForgeTypeId RbsPipeSystemCalculationParam { get; }
      Description: "Calculations"
    static ForgeTypeId RbsPipeSystemFixtureUnitParam { get; }
      Description: "Fixture Units"
    static ForgeTypeId RbsPipeTopElevation { get; }
      Description: "Upper End Top Elevation"
    static ForgeTypeId RbsPipeTypeFittingLossKfactorParam { get; }
      Description: "K Coefficient"
    static ForgeTypeId RbsPipeTypeFittingLossMethodParam { get; }
      Description: "Loss Method"
    static ForgeTypeId RbsPipeTypeFittingLossTableParam { get; }
      Description: "K Coefficient Table"
    static ForgeTypeId RbsPipeTypeParam { get; }
      Description: "Pipe Type"
    static ForgeTypeId RbsPipeTypeValveLossCvfactorParam { get; }
      Description: "Cv Coefficient"
    static ForgeTypeId RbsPipeValveLossCvfactorParam { get; }
      Description: "Cv Coefficient"
    static ForgeTypeId RbsPipeVelocityParam { get; }
      Description: "Velocity"
    static ForgeTypeId RbsPipeVolumeParam { get; }
      Description: "Volume"
    static ForgeTypeId RbsPipeWallThickness { get; }
      Description: "Wall Thickness"
    static ForgeTypeId RbsPipeWfuParam { get; }
      Description: "WFU"
    static ForgeTypeId RbsPipingSystemTypeParam { get; }
      Description: "System Type"
    static ForgeTypeId RbsPressureDrop { get; }
      Description: "Pressure Drop"
    static ForgeTypeId RbsProjectConstructionTypeShadingfactorParam { get; }
      Description: "Internal Shading Factor"
    static ForgeTypeId RbsProjectLocationParam { get; }
      Description: "Location"
    static ForgeTypeId RbsProjectReporttypeParam { get; }
      Description: "Report Type"
    static ForgeTypeId RbsReferenceFreesize { get; }
      Description: "Free Size"
    static ForgeTypeId RbsReferenceInsulationThickness { get; }
      Description: "Insulation Thickness": This parameter is obsolete. Use DUCT_INSULATION_THICKNESS and PIPE_INSULATION_THICKNESS.
    static ForgeTypeId RbsReferenceInsulationType { get; }
      Description: "Insulation Type"
    static ForgeTypeId RbsReferenceLiningThickness { get; }
      Description: "Lining Thickness"
    static ForgeTypeId RbsReferenceLiningType { get; }
      Description: "Lining Type"
    static ForgeTypeId RbsReferenceOverallsize { get; }
      Description: "Overall Size"
    static ForgeTypeId RbsReynoldsnumberParam { get; }
      Description: "Reynolds number"
    static ForgeTypeId RbsRoomCoefficientUtilization { get; }
      Description: "Coefficient of Utilization"
    static ForgeTypeId RbsRoutingPreferenceParam { get; }
      Description: "Routing Preferences"
    static ForgeTypeId RbsSection { get; }
      Description: "Section"
    static ForgeTypeId RbsSegmentDescriptionParam { get; }
      Description: "Segment Description"
    static ForgeTypeId RbsServiceTypeParam { get; }
      Description: "Building Service"
    static ForgeTypeId RbsShowProfileType { get; }
      Description: "Show Round"
    static ForgeTypeId RbsSizeLock { get; }
      Description: "Size Lock"
    static ForgeTypeId RbsStartLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId RbsStartOffsetParam { get; }
      Description: "Start Middle Elevation"
    static ForgeTypeId RbsSystemAbbreviationParam { get; }
      Description: "Abbreviation"
    static ForgeTypeId RbsSystemBaseElementParam { get; }
      Description: "System Equipment"
    static ForgeTypeId RbsSystemClassificationParam { get; }
      Description: "System Classification"
    static ForgeTypeId RbsSystemFlowConversionMethodParam { get; }
      Description: "Flow Conversion Method"
    static ForgeTypeId RbsSystemNameParam { get; }
      Description: "System Name"
    static ForgeTypeId RbsSystemNumElementsParam { get; }
      Description: "Number of Elements"
    static ForgeTypeId RbsSystemRisedrop1linedropsymbolParam { get; }
      Description: "Single Line Drop Symbol"
    static ForgeTypeId RbsSystemRisedrop1linerisesymbolParam { get; }
      Description: "Single Line Rise Symbol"
    static ForgeTypeId RbsSystemRisedrop1lineteedownsymbolParam { get; }
      Description: "Single Line Tee Down Symbol"
    static ForgeTypeId RbsSystemRisedrop1lineteeupsymbolParam { get; }
      Description: "Single Line Tee Up Symbol"
    static ForgeTypeId RbsSystemRisedrop2linedropsymbolParam { get; }
      Description: "Two Line Drop Symbol"
    static ForgeTypeId RbsSystemRisedrop2linerisesymbolParam { get; }
      Description: "Two Line Rise Symbol"
    static ForgeTypeId RbsSystemRisedropParam { get; }
      Description: "Rise / Drop Symbol"
    static ForgeTypeId RbsVelocity { get; }
      Description: "Velocity"
    static ForgeTypeId RbsVelocityPressure { get; }
      Description: "Velocity Pressure"
    static ForgeTypeId RbsVoltagetypeMaxvoltageParam { get; }
      Description: "Maximum Voltage"
    static ForgeTypeId RbsVoltagetypeMinvoltageParam { get; }
      Description: "Minimum Voltage"
    static ForgeTypeId RbsVoltagetypeVoltageParam { get; }
      Description: "Actual Voltage"
    static ForgeTypeId RbsWireCircuitDescription { get; }
      Description: "Circuit Description"
    static ForgeTypeId RbsWireCircuitLoadName { get; }
      Description: "Circuit Load Name"
    static ForgeTypeId RbsWireConduitTypeParam { get; }
      Description: "Conduit Type"
    static ForgeTypeId RbsWireInsulationParam { get; }
      Description: "Insulation"
    static ForgeTypeId RbsWireMaterialParam { get; }
      Description: "Material"
    static ForgeTypeId RbsWireMaxConductorSizeParam { get; }
      Description: "Max Size"
    static ForgeTypeId RbsWireNeutralIncludedInBalancedLoadParam { get; }
      Description: "Neutral Included in Balanced Load"
    static ForgeTypeId RbsWireNeutralModeParam { get; }
      Description: "Neutral Size"
    static ForgeTypeId RbsWireNeutralMultiplierParam { get; }
      Description: "Neutral Multiplier"
    static ForgeTypeId RbsWireNumConductorsParam { get; }
      Description: "Number of Conductors"
    static ForgeTypeId RbsWireTemperatureRatingParam { get; }
      Description: "Temperature Rating"
    static ForgeTypeId RebarAlignmentOptions { get; }
      Description: "Bar Alignment"
    static ForgeTypeId RebarBarDeformationType { get; }
      Description: "Deformation"
    static ForgeTypeId RebarBarDiameter { get; }
      Description: "Bar Diameter"
    static ForgeTypeId RebarBarHookLengths { get; }
      Description: "Hook Lengths"
    static ForgeTypeId RebarBarMaximumBendRadius { get; }
      Description: "Maximum Bend Radius"
    static ForgeTypeId RebarBarSpliceLengths { get; }
      Description: "Splice Lengths"
    static ForgeTypeId RebarBarStirrupBendDiameter { get; }
      Description: "Stirrup/Tie Bend Diameter"
    static ForgeTypeId RebarBarStyle { get; }
      Description: "Subcategory"
    static ForgeTypeId RebarConstraintsStatus { get; }
      Description: "Rebar Constraint Status"
    static ForgeTypeId RebarContainerBarType { get; }
      Description: "Bar Type"
    static ForgeTypeId RebarDistributionType { get; }
      Description: "Distribution Type"
    static ForgeTypeId RebarElemBarSpacing { get; }
      Description: "Spacing"
    static ForgeTypeId RebarElemEndtreatmentEnd { get; }
      Description: "End Treatment At End"
    static ForgeTypeId RebarElemEndtreatmentStart { get; }
      Description: "End Treatment At Start"
    static ForgeTypeId RebarElementRounding { get; }
      Description: "Rounding Overrides"
    static ForgeTypeId RebarElementVisibility { get; }
      Description: "View Visibility States"
    static ForgeTypeId RebarElemHookEndOrient { get; }
      Description: "Hook Orientation At End"
    static ForgeTypeId RebarElemHookEndType { get; }
      Description: "Hook At End"
    static ForgeTypeId RebarElemHookStartOrient { get; }
      Description: "Hook Orientation At Start"
    static ForgeTypeId RebarElemHookStartType { get; }
      Description: "Hook At Start"
    static ForgeTypeId RebarElemHookStyle { get; }
      Description: "Style"
    static ForgeTypeId RebarElemHostMark { get; }
      Description: "Host Mark"
    static ForgeTypeId RebarElemLayoutRule { get; }
      Description: "Layout Rule"
    static ForgeTypeId RebarElemLength { get; }
      Description: "Bar Length"
    static ForgeTypeId RebarElemQuantityOfBars { get; }
      Description: "Quantity"
    static ForgeTypeId RebarElemScheduleMark { get; }
      Description: "Schedule Mark"
    static ForgeTypeId RebarElemTotalLength { get; }
      Description: "Total Bar Length"
    static ForgeTypeId RebarFreeFormHookEndPlaneAngle { get; }
      Description: "Hook Orientation At End"
    static ForgeTypeId RebarFreeFormHookStartPlaneAngle { get; }
      Description: "Hook Orientation At Start"
    static ForgeTypeId RebarGeometryType { get; }
      Description: "Geometry"
    static ForgeTypeId RebarHookAngle { get; }
      Description: "Hook Angle"
    static ForgeTypeId RebarHookLengthOverride { get; }
      Description: "Override Hook Lengths"
    static ForgeTypeId RebarHookLineLenFactor { get; }
      Description: "Extension Multiplier"
    static ForgeTypeId RebarHookRotationAtEnd { get; }
      Description: "Hook Rotation At End"
    static ForgeTypeId RebarHookRotationAtEndSchedulesTagsFilters { get; }
      Description: "Hook Rotation At End"
    static ForgeTypeId RebarHookRotationAtStart { get; }
      Description: "Hook Rotation At Start"
    static ForgeTypeId RebarHookRotationAtStartSchedulesTagsFilters { get; }
      Description: "Hook Rotation At Start"
    static ForgeTypeId RebarHookStyle { get; }
      Description: "Style"
    static ForgeTypeId RebarHostCategory { get; }
      Description: "Host Category"
    static ForgeTypeId RebarIncludeFirstBar { get; }
      Description: "Include First Bar"
    static ForgeTypeId RebarIncludeLastBar { get; }
      Description: "Include Last Bar"
    static ForgeTypeId RebarInstanceBarDiameter { get; }
      Description: "Bar Diameter"
    static ForgeTypeId RebarInstanceBarModelDiameter { get; }
      Description: "Model Bar Diameter"
    static ForgeTypeId RebarInstanceBendDiameter { get; }
      Description: "Bend Diameter"
    static ForgeTypeId RebarInstanceStirrupTieAttachment { get; }
      Description: "Stirrup/Tie Attachment"
    static ForgeTypeId RebarInternalMultiplanar { get; }
      Description: "INTERNAL: Multiplanar"
    static ForgeTypeId RebarInternalMultiplanarArcConnector { get; }
      Description: "INTERNAL: Multiplanar Arc Connector"
    static ForgeTypeId RebarInternalMultiplanarDuplicate { get; }
      Description: "INTERNAL: Multiplanar Duplicate"
    static ForgeTypeId RebarInternalMultiplanarEndConnector { get; }
      Description: "INTERNAL: Multiplanar End Connector"
    static ForgeTypeId RebarInternalMultiplanarStartConnector { get; }
      Description: "INTERNAL: Multiplanar Start Connector"
    static ForgeTypeId RebarMaximSuffix { get; }
      Description: "Maximum Suffix"
    static ForgeTypeId RebarMaximumNumber { get; }
      Description: "Maximum Rebar Number"
    static ForgeTypeId RebarMaxLength { get; }
      Description: "Maximum Bar Length"
    static ForgeTypeId RebarMinimSuffix { get; }
      Description: "Minimum Suffix"
    static ForgeTypeId RebarMinimumNumber { get; }
      Description: "Minimum Rebar Number"
    static ForgeTypeId RebarMinLength { get; }
      Description: "Minimum Bar Length"
    static ForgeTypeId RebarModelBarDiameter { get; }
      Description: "Model Bar Diameter"
    static ForgeTypeId RebarModifiedSet { get; }
      Description: "Modified Rebar Set"
    static ForgeTypeId RebarNumber { get; }
      Description: "Rebar Number"
    static ForgeTypeId RebarNumberSuffix { get; }
      Description: "Rebar Number Suffix"
    static ForgeTypeId RebarQuanityByDistrib { get; }
      Description: "Quantity By Rebar Set"
    static ForgeTypeId RebarShape { get; }
      Description: "Shape"
    static ForgeTypeId RebarShapeAllowedBarTypes { get; }
      Description: "Allowable Rebar Bar Types"
    static ForgeTypeId RebarShapeEndHookLength { get; }
      Description: "End Hook Length"
    static ForgeTypeId RebarShapeEndHookOffset { get; }
      Description: "End Hook Offset Length"
    static ForgeTypeId RebarShapeEndtreatmentEndType { get; }
      Description: "End Treatment At End"
    static ForgeTypeId RebarShapeEndtreatmentStartType { get; }
      Description: "End Treatment At Start"
    static ForgeTypeId RebarShapeHookEndType { get; }
      Description: "Hook At End"
    static ForgeTypeId RebarShapeHookRotationAtEnd { get; }
      Description: "Hook Rotation At End"
    static ForgeTypeId RebarShapeHookRotationAtStart { get; }
      Description: "Hook Rotation At Start"
    static ForgeTypeId RebarShapeHookStartType { get; }
      Description: "Hook At Start"
    static ForgeTypeId RebarShapeHookStyle { get; }
      Description: "Style"
    static ForgeTypeId RebarShapeImage { get; }
      Description: "Shape Image"
    static ForgeTypeId RebarShapeOutOfPlaneBendDiameter { get; }
      Description: "Out of Plane Bend Diameter"
    static ForgeTypeId RebarShapeParamEndHookTanLen { get; }
      Description: "End Tangent Hook Length"
    static ForgeTypeId RebarShapeParamStartHookTanLen { get; }
      Description: "Start Tangent Hook Length"
    static ForgeTypeId RebarShapeSpiralBaseFinishingTurns { get; }
      Description: "Base Finishing Turns"
    static ForgeTypeId RebarShapeSpiralHeight { get; }
      Description: "Height"
    static ForgeTypeId RebarShapeSpiralPitch { get; }
      Description: "Pitch"
    static ForgeTypeId RebarShapeSpiralTopFinishingTurns { get; }
      Description: "Top Finishing Turns"
    static ForgeTypeId RebarShapeStartHookLength { get; }
      Description: "Start Hook Length"
    static ForgeTypeId RebarShapeStartHookOffset { get; }
      Description: "Start Hook Offset Length"
    static ForgeTypeId RebarShapeStirrupTieAttachment { get; }
      Description: "Stirrup/Tie Attachment"
    static ForgeTypeId RebarSpliceLapLengthMultiplier { get; }
      Description: "Lap Length Multiplier"
    static ForgeTypeId RebarSpliceShiftBars { get; }
      Description: "Shift Bars"
    static ForgeTypeId RebarSpliceSpliceLinePosition { get; }
      Description: "Splice Position"
    static ForgeTypeId RebarSpliceStaggerLengthMultiplier { get; }
      Description: "Stagger Length Multiplier"
    static ForgeTypeId RebarStaggeredSet { get; }
      Description: "Staggered Set"
    static ForgeTypeId RebarStaggerOffsetAtEnd { get; }
      Description: "Offset At End"
    static ForgeTypeId RebarStaggerOffsetAtStart { get; }
      Description: "Offset At Start"
    static ForgeTypeId RebarStandardBendDiameter { get; }
      Description: "Standard Bend Diameter"
    static ForgeTypeId RebarStandardHookBendDiameter { get; }
      Description: "Standard Hook Bend Diameter"
    static ForgeTypeId RebarSystemActiveBackDirn1 { get; }
      Description: "Interior Major Direction"
    static ForgeTypeId RebarSystemActiveBackDirn2 { get; }
      Description: "Interior Minor Direction"
    static ForgeTypeId RebarSystemActiveBottomDir1Generic { get; }
      Description: "Bottom/Interior Major Direction"
    static ForgeTypeId RebarSystemActiveBottomDir2Generic { get; }
      Description: "Bottom/Interior Minor Direction"
    static ForgeTypeId RebarSystemActiveBottomDirn1 { get; }
      Description: "Bottom Major Direction"
    static ForgeTypeId RebarSystemActiveBottomDirn2 { get; }
      Description: "Bottom Minor Direction"
    static ForgeTypeId RebarSystemActiveFrontDirn1 { get; }
      Description: "Exterior Major Direction"
    static ForgeTypeId RebarSystemActiveFrontDirn2 { get; }
      Description: "Exterior Minor Direction"
    static ForgeTypeId RebarSystemActiveTopDir1Generic { get; }
      Description: "Top/Exterior Major Direction"
    static ForgeTypeId RebarSystemActiveTopDir2Generic { get; }
      Description: "Top/Exterior Minor Direction"
    static ForgeTypeId RebarSystemActiveTopDirn1 { get; }
      Description: "Top Major Direction"
    static ForgeTypeId RebarSystemActiveTopDirn2 { get; }
      Description: "Top Minor Direction"
    static ForgeTypeId RebarSystemAddlBottomOffset { get; }
      Description: "Additional Bottom Cover Offset"
    static ForgeTypeId RebarSystemAddlExteriorOffset { get; }
      Description: "Additional Exterior Cover Offset"
    static ForgeTypeId RebarSystemAddlInteriorOffset { get; }
      Description: "Additional Interior Cover Offset"
    static ForgeTypeId RebarSystemAddlTopOffset { get; }
      Description: "Additional Top Cover Offset"
    static ForgeTypeId RebarSystemBarTypeBackDirn1 { get; }
      Description: "Interior Major Bar Type"
    static ForgeTypeId RebarSystemBarTypeBackDirn2 { get; }
      Description: "Interior Minor Bar Type"
    static ForgeTypeId RebarSystemBarTypeBottomDir1Generic { get; }
      Description: "Bottom/Interior Major Bar Type"
    static ForgeTypeId RebarSystemBarTypeBottomDir2Generic { get; }
      Description: "Bottom/Interior Minor Bar Type"
    static ForgeTypeId RebarSystemBarTypeBottomDirn1 { get; }
      Description: "Bottom Major Bar Type"
    static ForgeTypeId RebarSystemBarTypeBottomDirn2 { get; }
      Description: "Bottom Minor Bar Type"
    static ForgeTypeId RebarSystemBarTypeFrontDirn1 { get; }
      Description: "Exterior Major Bar Type"
    static ForgeTypeId RebarSystemBarTypeFrontDirn2 { get; }
      Description: "Exterior Minor Bar Type"
    static ForgeTypeId RebarSystemBarTypeTopDir1Generic { get; }
      Description: "Top/Exterior Major Bar Type"
    static ForgeTypeId RebarSystemBarTypeTopDir2Generic { get; }
      Description: "Top/Exterior Minor Bar Type"
    static ForgeTypeId RebarSystemBarTypeTopDirn1 { get; }
      Description: "Top Major Bar Type"
    static ForgeTypeId RebarSystemBarTypeTopDirn2 { get; }
      Description: "Top Minor Bar Type"
    static ForgeTypeId RebarSystemBottomMajorMatchesBottomMinor { get; }
      Description: "Bottom Major and Minor Layers Match"
    static ForgeTypeId RebarSystemCoverBottom { get; }
      Description: "Rebar Cover Bottom/Interior"
    static ForgeTypeId RebarSystemCoverSide { get; }
      Description: "Rebar Cover Side/Edge"
    static ForgeTypeId RebarSystemCoverTop { get; }
      Description: "Rebar Cover Top/Exterior"
    static ForgeTypeId RebarSystemHookOrientBackDirn1 { get; }
      Description: "Interior Major Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientBackDirn2 { get; }
      Description: "Interior Minor Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientBottomDirn1 { get; }
      Description: "Bottom Major Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientBottomDirn2 { get; }
      Description: "Bottom Minor Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientFrontDirn1 { get; }
      Description: "Exterior Major Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientFrontDirn2 { get; }
      Description: "Exterior Minor Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientTopDirn1 { get; }
      Description: "Top Major Hook Orientation"
    static ForgeTypeId RebarSystemHookOrientTopDirn2 { get; }
      Description: "Top Minor Hook Orientation"
    static ForgeTypeId RebarSystemHookTypeBackDirn1 { get; }
      Description: "Interior Major Hook Type"
    static ForgeTypeId RebarSystemHookTypeBackDirn2 { get; }
      Description: "Interior Minor Hook Type"
    static ForgeTypeId RebarSystemHookTypeBottomDirn1 { get; }
      Description: "Bottom Major Hook Type"
    static ForgeTypeId RebarSystemHookTypeBottomDirn2 { get; }
      Description: "Bottom Minor Hook Type"
    static ForgeTypeId RebarSystemHookTypeFrontDirn1 { get; }
      Description: "Exterior Major Hook Type"
    static ForgeTypeId RebarSystemHookTypeFrontDirn2 { get; }
      Description: "Exterior Minor Hook Type"
    static ForgeTypeId RebarSystemHookTypeTopDirn1 { get; }
      Description: "Top Major Hook Type"
    static ForgeTypeId RebarSystemHookTypeTopDirn2 { get; }
      Description: "Top Minor Hook Type"
    static ForgeTypeId RebarSystemLayerSummaryBottomDir1NoSpacing { get; }
      Description: "Bottom/Interior Major (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryBottomDir1WithSpacing { get; }
      Description: "Bottom/Interior Major"
    static ForgeTypeId RebarSystemLayerSummaryBottomDir2NoSpacing { get; }
      Description: "Bottom/Interior Minor (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryBottomDir2WithSpacing { get; }
      Description: "Bottom/Interior Minor"
    static ForgeTypeId RebarSystemLayerSummaryDir1NoSpacing { get; }
      Description: "Major, Both Faces (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryDir1WithSpacing { get; }
      Description: "Major, Both Faces"
    static ForgeTypeId RebarSystemLayerSummaryDir2NoSpacing { get; }
      Description: "Minor, Both Faces (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryDir2WithSpacing { get; }
      Description: "Minor, Both Faces"
    static ForgeTypeId RebarSystemLayerSummaryNoSpacing { get; }
      Description: "Layer Summary (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryTopDir1NoSpacing { get; }
      Description: "Top/Exterior Major (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryTopDir1WithSpacing { get; }
      Description: "Top/Exterior Major"
    static ForgeTypeId RebarSystemLayerSummaryTopDir2NoSpacing { get; }
      Description: "Top/Exterior Minor (Brief)"
    static ForgeTypeId RebarSystemLayerSummaryTopDir2WithSpacing { get; }
      Description: "Top/Exterior Minor"
    static ForgeTypeId RebarSystemLayerSummaryWithSpacing { get; }
      Description: "Layer Summary"
    static ForgeTypeId RebarSystemLayoutRule { get; }
      Description: "Layout Rule"
    static ForgeTypeId RebarSystemNumberOfLinesBackDirn1 { get; }
      Description: "Interior Major Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesBackDirn2 { get; }
      Description: "Interior Minor Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesBottomDir1Generic { get; }
      Description: "Bottom/Interior Major Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesBottomDir2Generic { get; }
      Description: "Bottom/Interior Minor Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesBottomDirn1 { get; }
      Description: "Bottom Major Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesBottomDirn2 { get; }
      Description: "Bottom Minor Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesFrontDirn1 { get; }
      Description: "Exterior Major Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesFrontDirn2 { get; }
      Description: "Exterior Minor Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesTopDir1Generic { get; }
      Description: "Top/Exterior Major Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesTopDir2Generic { get; }
      Description: "Top/Exterior Minor Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesTopDirn1 { get; }
      Description: "Top Major Number Of Lines"
    static ForgeTypeId RebarSystemNumberOfLinesTopDirn2 { get; }
      Description: "Top Minor Number Of Lines"
    static ForgeTypeId RebarSystemOverride { get; }
      Description: "Override Area Reinforcement Settings"
    static ForgeTypeId RebarSystemSpacingBackDirn1 { get; }
      Description: "Interior Major Spacing"
    static ForgeTypeId RebarSystemSpacingBackDirn2 { get; }
      Description: "Interior Minor Spacing"
    static ForgeTypeId RebarSystemSpacingBottomDir1Generic { get; }
      Description: "Bottom/Interior Major Spacing"
    static ForgeTypeId RebarSystemSpacingBottomDir2Generic { get; }
      Description: "Bottom/Interior Minor Spacing"
    static ForgeTypeId RebarSystemSpacingBottomDirn1 { get; }
      Description: "Bottom Major Spacing"
    static ForgeTypeId RebarSystemSpacingBottomDirn2 { get; }
      Description: "Bottom Minor Spacing"
    static ForgeTypeId RebarSystemSpacingFrontDirn1 { get; }
      Description: "Exterior Major Spacing"
    static ForgeTypeId RebarSystemSpacingFrontDirn2 { get; }
      Description: "Exterior Minor Spacing"
    static ForgeTypeId RebarSystemSpacingTopDir1Generic { get; }
      Description: "Top/Exterior Major Spacing"
    static ForgeTypeId RebarSystemSpacingTopDir2Generic { get; }
      Description: "Top/Exterior Minor Spacing"
    static ForgeTypeId RebarSystemSpacingTopDirn1 { get; }
      Description: "Top Major Spacing"
    static ForgeTypeId RebarSystemSpacingTopDirn2 { get; }
      Description: "Top Minor Spacing"
    static ForgeTypeId RebarSystemSpanactiveDirn1 { get; }
      Description: "Bars In Major Direction"
    static ForgeTypeId RebarSystemSpanactiveDirn2 { get; }
      Description: "Bars In Minor Direction"
    static ForgeTypeId RebarSystemSpanhookBottomDirn2 { get; }
      Description: "Hook Angle Bottom"
    static ForgeTypeId RebarSystemSpanhookLeftDirn1 { get; }
      Description: "Hook Angle Left"
    static ForgeTypeId RebarSystemSpanhookRightDirn1 { get; }
      Description: "Hook Angle Right"
    static ForgeTypeId RebarSystemSpanhookTopDirn2 { get; }
      Description: "Hook Angle Top"
    static ForgeTypeId RebarSystemTopMajorMatchesBottomMajor { get; }
      Description: "Top and Bottom Major Layers Match"
    static ForgeTypeId RebarSystemTopMajorMatchesTopMinor { get; }
      Description: "Top Major and Minor Layers Match"
    static ForgeTypeId RebarSystemTopMinorMatchesBottomMinor { get; }
      Description: "Top and Bottom Minor Layers Match"
    static ForgeTypeId RebarWorkshopInstructions { get; }
      Description: "Workshop Instructions"
    static ForgeTypeId RectMullionThick { get; }
      Description: "Thickness"
    static ForgeTypeId RectMullionWidth1 { get; }
      Description: "Width on side 1"
    static ForgeTypeId RectMullionWidth2 { get; }
      Description: "Width on side 2"
    static ForgeTypeId ReferenceBaseOnHost { get; }
      Description: "Reference Base on Host"
    static ForgeTypeId ReferencedView { get; }
      Description: "Referenced View": The view referenced by a section or callout.
    static ForgeTypeId ReferenceLineSubcategory { get; }
      Description: "Subcategory"
    static ForgeTypeId ReferenceOtherViewUiRefView { get; }
      Description: "Reference View": This is used by the UI to allow selection of view reference.
    static ForgeTypeId ReferenceOtherViewUiToggle { get; }
      Description: "Reference Other View": This is used to determine whether reference other view is enable or not.
    static ForgeTypeId ReferenceViewerAttrTag { get; }
      Description: "View Reference Tag"
    static ForgeTypeId ReferenceViewerTargetView { get; }
      Description: "Target view"
    static ForgeTypeId ReferenceViewerUiTargetFilter { get; }
      Description: "Filter": This is used by the UI to filter the list of target views.
    static ForgeTypeId ReferenceViewerUiTargetView { get; }
      Description: "Target view": This is used by the UI to allow selection of target view. It allows the UI to set a filter that is incompatible with the current target view (REFERENCE_VIEWER_TARGET_VIEW).
    static ForgeTypeId RefTableElemName { get; }
      Description: "Key Name"
    static ForgeTypeId RefTableParamName { get; }
      Description: "Parameter Name"
    static ForgeTypeId ReinEstBarLength { get; }
      Description: "Estimated Total Bar Length"
    static ForgeTypeId ReinEstBarVolume { get; }
      Description: "Estimated Reinforcement Volume"
    static ForgeTypeId ReinEstNumberOfBars { get; }
      Description: "Estimated Number of Bars"
    static ForgeTypeId ReinforcementVolume { get; }
      Description: "Reinforcement Volume"
    static ForgeTypeId RelatedToMass { get; }
      Description: "Related to Mass"
    static ForgeTypeId RelativeRoughness { get; }
      Description: "Relative Roughness"
    static ForgeTypeId RenderPlantHeight { get; }
      Description: "Height"
    static ForgeTypeId RenderPlantName { get; }
      Description: "Plant Name"
    static ForgeTypeId RenderPlantTrimHeight { get; }
      Description: "Plant Trim Height"
    static ForgeTypeId RenderRpcFilename { get; }
      Description: "Render Appearance"
    static ForgeTypeId RenderRpcProperties { get; }
      Description: "Render Appearance Properties"
    static ForgeTypeId RepeatingDetailElement { get; }
      Description: "Detail"
    static ForgeTypeId RepeatingDetailInside { get; }
      Description: "Inside"
    static ForgeTypeId RepeatingDetailLayout { get; }
      Description: "Layout"
    static ForgeTypeId RepeatingDetailNumber { get; }
      Description: "Number"
    static ForgeTypeId RepeatingDetailRotation { get; }
      Description: "Detail Rotation"
    static ForgeTypeId RepeatingDetailSpacing { get; }
      Description: "Spacing"
    static ForgeTypeId RevealProfileParam { get; }
      Description: "Profile"
    static ForgeTypeId RevisionCloudRevision { get; }
      Description: "Revision"
    static ForgeTypeId RevisionCloudRevisionDate { get; }
      Description: "Revision Date"
    static ForgeTypeId RevisionCloudRevisionDescription { get; }
      Description: "Revision Description"
    static ForgeTypeId RevisionCloudRevisionIssuedBy { get; }
      Description: "Issued by"
    static ForgeTypeId RevisionCloudRevisionIssuedTo { get; }
      Description: "Issued to"
    static ForgeTypeId RevisionCloudRevisionNum { get; }
      Description: "Revision Number"
    static ForgeTypeId RevolutionEndAngle { get; }
      Description: "End Angle"
    static ForgeTypeId RevolutionStartAngle { get; }
      Description: "Start Angle"
    static ForgeTypeId RgbBParam { get; }
      Description: "Blue value for RGB color spec. (for Use with XAML Data Template example)"
    static ForgeTypeId RgbGParam { get; }
      Description: "Green value for RGB color spec. (for Use with XAML Data Template example)"
    static ForgeTypeId RgbRParam { get; }
      Description: "Red value for RGB color spec. (for Use with XAML Data Template example)"
    static ForgeTypeId RoofAttrDefaultThicknessParam { get; }
      Description: "Default Thickness"
    static ForgeTypeId RoofAttrThicknessParam { get; }
      Description: "Thickness"
    static ForgeTypeId RoofBaseLevelParam { get; }
      Description: "Base Level"
    static ForgeTypeId RoofConstraintLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId RoofConstraintOffsetParam { get; }
      Description: "Level Offset"
    static ForgeTypeId RoofCurveHeightAtWall { get; }
      Description: "Plate Offset From Base"
    static ForgeTypeId RoofCurveHeightOffset { get; }
      Description: "Offset From Roof Base"
    static ForgeTypeId RoofCurveIsSlopeDefining { get; }
      Description: "Defines Roof Slope"
    static ForgeTypeId RoofEaveCutParam { get; }
      Description: "Rafter Cut"
    static ForgeTypeId RoofFacesLocation { get; }
      Description: "Picked Faces Location"
    static ForgeTypeId RoofLevelOffsetParam { get; }
      Description: "Base Offset From Level"
    static ForgeTypeId RoofRafterOrTrussParam { get; }
      Description: "Rafter or Truss"
    static ForgeTypeId RoofSlope { get; }
      Description: "Slope"
    static ForgeTypeId RoofStructureIdParam { get; }
      Description: "Structure"
    static ForgeTypeId RoofUptoLevelOffsetParam { get; }
      Description: "Cutoff Offset"
    static ForgeTypeId RoofUptoLevelParam { get; }
      Description: "Cutoff Level"
    static ForgeTypeId RoomActualExhaustAirflowParam { get; }
      Description: "Actual Exhaust Airflow"
    static ForgeTypeId RoomActualLightingLoadParam { get; }
      Description: "Actual Lighting Load"
    static ForgeTypeId RoomActualLightingLoadPerAreaParam { get; }
      Description: "Actual Lighting Load per area"
    static ForgeTypeId RoomActualPowerLoadParam { get; }
      Description: "Actual Power Load"
    static ForgeTypeId RoomActualPowerLoadPerAreaParam { get; }
      Description: "Actual Power Load per area"
    static ForgeTypeId RoomActualReturnAirflowParam { get; }
      Description: "Actual Return Airflow"
    static ForgeTypeId RoomActualSupplyAirflowParam { get; }
      Description: "Actual Supply Airflow"
    static ForgeTypeId RoomAirChangesPerHourParam { get; }
      Description: "Air Changes per Hour"
    static ForgeTypeId RoomArea { get; }
      Description: "Area"
    static ForgeTypeId RoomAreaPerPersonParam { get; }
      Description: "Area per Person"
    static ForgeTypeId RoomBaseHeatLoadOnParam { get; }
      Description: "Heat Load Values"
    static ForgeTypeId RoomBaseLightingLoadOnParam { get; }
      Description: "Base Lighting Load on"
    static ForgeTypeId RoomBasePowerLoadOnParam { get; }
      Description: "Base Power Load on"
    static ForgeTypeId RoomBaseReturnAirflowOnParam { get; }
      Description: "Return Airflow"
    static ForgeTypeId RoomCalculatedCoolingLoadParam { get; }
      Description: "Calculated Cooling Load"
    static ForgeTypeId RoomCalculatedCoolingLoadPerAreaParam { get; }
      Description: "Calculated Cooling Load per area"
    static ForgeTypeId RoomCalculatedHeatingLoadParam { get; }
      Description: "Calculated Heating Load"
    static ForgeTypeId RoomCalculatedHeatingLoadPerAreaParam { get; }
      Description: "Calculated Heating Load per area"
    static ForgeTypeId RoomCalculatedSupplyAirflowParam { get; }
      Description: "Calculated Supply Airflow"
    static ForgeTypeId RoomCalculatedSupplyAirflowPerAreaParam { get; }
      Description: "Calculated Supply Airflow per area"
    static ForgeTypeId RoomCalculationPoint { get; }
      Description: "Room Calculation Point"
    static ForgeTypeId RoomComputationHeight { get; }
      Description: "Computation Height"
    static ForgeTypeId RoomComputationMethod { get; }
      Description: "Computation"
    static ForgeTypeId RoomConditionTypeParam { get; }
      Description: "Condition Type"
    static ForgeTypeId RoomConstructionSetParam { get; }
      Description: "Construction Type"
    static ForgeTypeId RoomDepartment { get; }
      Description: "Department"
    static ForgeTypeId RoomDesignCoolingLoadParam { get; }
      Description: "Design Cooling Load"
    static ForgeTypeId RoomDesignExhaustAirflowParam { get; }
      Description: "Specified Exhaust Airflow"
    static ForgeTypeId RoomDesignHeatingLoadParam { get; }
      Description: "Design Heating Load"
    static ForgeTypeId RoomDesignLightingLoadParam { get; }
      Description: "Specified Lighting Load"
    static ForgeTypeId RoomDesignLightingLoadPerAreaParam { get; }
      Description: "Specified Lighting Load per area"
    static ForgeTypeId RoomDesignMechanicalLoadPerAreaParam { get; }
      Description: "Design HVAC Load per area"
    static ForgeTypeId RoomDesignOtherLoadPerAreaParam { get; }
      Description: "Design Other Load per area"
    static ForgeTypeId RoomDesignPowerLoadParam { get; }
      Description: "Specified Power Load"
    static ForgeTypeId RoomDesignPowerLoadPerAreaParam { get; }
      Description: "Specified Power Load per area"
    static ForgeTypeId RoomDesignReturnAirflowParam { get; }
      Description: "Specified Return Airflow"
    static ForgeTypeId RoomDesignSupplyAirflowParam { get; }
      Description: "Specified Supply Airflow"
    static ForgeTypeId RoomEditElectricalLoadsParam { get; }
      Description: "Electrical Loads"
    static ForgeTypeId RoomEditPeopleLoadsParam { get; }
      Description: "People"
    static ForgeTypeId RoomFinishBase { get; }
      Description: "Base Finish"
    static ForgeTypeId RoomFinishCeiling { get; }
      Description: "Ceiling Finish"
    static ForgeTypeId RoomFinishFloor { get; }
      Description: "Floor Finish"
    static ForgeTypeId RoomFinishWall { get; }
      Description: "Wall Finish"
    static ForgeTypeId RoomHeight { get; }
      Description: "Unbounded Height"
    static ForgeTypeId RoomLevelId { get; }
      Description: "Level"
    static ForgeTypeId RoomLightingLoadUnitsParam { get; }
      Description: "Lighting Load Units"
    static ForgeTypeId RoomLowerOffset { get; }
      Description: "Base Offset"
    static ForgeTypeId RoomName { get; }
      Description: "Name"
    static ForgeTypeId RoomNumber { get; }
      Description: "Number"
    static ForgeTypeId RoomNumberOfPeopleParam { get; }
      Description: "Number of People"
    static ForgeTypeId RoomOccupancy { get; }
      Description: "Occupancy"
    static ForgeTypeId RoomOccupancyUnitParam { get; }
      Description: "Occupancy Unit"
    static ForgeTypeId RoomOutdoorAirflowParam { get; }
      Description: "Outdoor Airflow"
    static ForgeTypeId RoomOutdoorAirflowStandardParam { get; }
      Description: "Outdoor Air Method"
    static ForgeTypeId RoomOutdoorAirInfoParam { get; }
      Description: "Outdoor Air Information"
    static ForgeTypeId RoomOutdoorAirPerAreaParam { get; }
      Description: "Outdoor Air per Area"
    static ForgeTypeId RoomOutdoorAirPerPersonParam { get; }
      Description: "Outdoor Air per Person"
    static ForgeTypeId RoomPeopleLatentHeatGainPerPersonParam { get; }
      Description: "Latent Heat Gain per person"
    static ForgeTypeId RoomPeopleSensibleHeatGainPerPersonParam { get; }
      Description: "Sensible Heat Gain per person"
    static ForgeTypeId RoomPeopleTotalHeatGainPerPersonParam { get; }
      Description: "Total Heat Gain per person"
    static ForgeTypeId RoomPerimeter { get; }
      Description: "Perimeter"
    static ForgeTypeId RoomPhase { get; }
      Description: "Phase"
    static ForgeTypeId RoomPhaseId { get; }
      Description: "Phase Id"
    static ForgeTypeId RoomPlenumLightingParam { get; }
      Description: "Plenum Lighting Contribution"
    static ForgeTypeId RoomPowerLoadUnitsParam { get; }
      Description: "Power Load Units"
    static ForgeTypeId RoomSpaceTypeParam { get; }
      Description: "Space Type"
    static ForgeTypeId RoomTagOrientationParam { get; }
      Description: "Orientation"
    static ForgeTypeId RoomUpperLevel { get; }
      Description: "Upper Limit"
    static ForgeTypeId RoomUpperOffset { get; }
      Description: "Limit Offset"
    static ForgeTypeId RoomVolume { get; }
      Description: "Volume"
    static ForgeTypeId RouteAnalysisSettingsParam { get; }
      Description: "Route Analysis Settings"
    static ForgeTypeId RoutingPreferenceParam { get; }
      Description: "Routing Preference"
    static ForgeTypeId RvtHostLevel { get; }
      Description: "Map Levels..."
    static ForgeTypeId RvtLevelOffset { get; }
      Description: "Map Levels..."
    static ForgeTypeId RvtLinkFileNameWithoutExt { get; }
      Description: "File Name"
    static ForgeTypeId RvtLinkInstanceName { get; }
      Description: "Name"
    static ForgeTypeId RvtLinkInstanceProjectInformation { get; }
      Description: "Project Information"
    static ForgeTypeId RvtLinkPhaseMap { get; }
      Description: "Phase Mapping"
    static ForgeTypeId RvtLinkReferenceType { get; }
      Description: "Reference Type"
    static ForgeTypeId RvtSourceLevel { get; }
      Description: "Map Levels..."
    static ForgeTypeId ScaleFactorParam { get; }
      Description: "Scale"
    static ForgeTypeId ScheduleBaseLevelOffsetParam { get; }
      Description: "Base Offset"
    static ForgeTypeId ScheduleBaseLevelParam { get; }
      Description: "Base Level"
    static ForgeTypeId ScheduleCategory { get; }
      Description: "Category"
    static ForgeTypeId ScheduleEmbeddedParam { get; }
      Description: "Embedded Schedule"
    static ForgeTypeId ScheduleFieldsParam { get; }
      Description: "Fields"
    static ForgeTypeId ScheduleFilterParam { get; }
      Description: "Filter"
    static ForgeTypeId ScheduleFormatParam { get; }
      Description: "Formatting"
    static ForgeTypeId ScheduleGroupParam { get; }
      Description: "Sorting/Grouping"
    static ForgeTypeId ScheduleLevelParam { get; }
      Description: "Level"
    static ForgeTypeId ScheduleResizeRows { get; }
      Description: "Resize Rows"
    static ForgeTypeId ScheduleRotationOnSheet { get; }
      Description: "Rotation on Sheet"
    static ForgeTypeId ScheduleRowHeightInput { get; }
      Description: "Row Height"
    static ForgeTypeId ScheduleSheetAppearanceParam { get; }
      Description: "Appearance"
    static ForgeTypeId ScheduleTopLevelOffsetParam { get; }
      Description: "Top Offset"
    static ForgeTypeId ScheduleTopLevelParam { get; }
      Description: "Top Level"
    static ForgeTypeId ScheduleTypeForBrowser { get; }
      Description: "Schedule Type"
    static ForgeTypeId SectionAttrHeadTag { get; }
      Description: "Section Head"
    static ForgeTypeId SectionAttrTailLength { get; }
      Description: "Tail length"
    static ForgeTypeId SectionAttrTailTag { get; }
      Description: "Section Tail"
    static ForgeTypeId SectionAttrTailWidth { get; }
      Description: "Tail width"
    static ForgeTypeId SectionBrokenDisplayStyle { get; }
      Description: "Broken Section Display Style"
    static ForgeTypeId SectionCoarserScalePulldownImperial { get; }
      Description: "Hide at scales coarser than"
    static ForgeTypeId SectionCoarserScalePulldownMetric { get; }
      Description: "Hide at scales coarser than"
    static ForgeTypeId SectionParentViewName { get; }
      Description: "Parent View"
    static ForgeTypeId SectionShowInOneViewOnly { get; }
      Description: "Show in"
    static ForgeTypeId SectionTag { get; }
      Description: "Section Tag"
    static ForgeTypeId SeekItemId { get; }
      Description: "Seek Item ID"
    static ForgeTypeId SelectionEditableOnly { get; }
      Description: "Editable only"
    static ForgeTypeId SheetApprovedBy { get; }
      Description: "Approved By"
    static ForgeTypeId SheetAssemblyAssemblyCode { get; }
      Description: "Assembly: Assembly Code"
    static ForgeTypeId SheetAssemblyAssemblyDescription { get; }
      Description: "Assembly: Assembly Description"
    static ForgeTypeId SheetAssemblyCost { get; }
      Description: "Assembly: Cost"
    static ForgeTypeId SheetAssemblyDescription { get; }
      Description: "Assembly: Description"
    static ForgeTypeId SheetAssemblyKeynote { get; }
      Description: "Assembly: Keynote"
    static ForgeTypeId SheetAssemblyManufacturer { get; }
      Description: "Assembly: Manufacturer"
    static ForgeTypeId SheetAssemblyModel { get; }
      Description: "Assembly: Model"
    static ForgeTypeId SheetAssemblyName { get; }
      Description: "Assembly: Name"
    static ForgeTypeId SheetAssemblyTypeComments { get; }
      Description: "Assembly: Type Comments"
    static ForgeTypeId SheetAssemblyTypeMark { get; }
      Description: "Assembly: Type Mark"
    static ForgeTypeId SheetAssemblyUrl { get; }
      Description: "Assembly: URL"
    static ForgeTypeId SheetCheckedBy { get; }
      Description: "Checked By"
    static ForgeTypeId SheetCollection { get; }
      Description: "Sheet Collection"
    static ForgeTypeId SheetCollectionName { get; }
      Description: "Name"
    static ForgeTypeId SheetCurrentRevision { get; }
      Description: "Current Revision"
    static ForgeTypeId SheetCurrentRevisionDate { get; }
      Description: "Current Revision Date"
    static ForgeTypeId SheetCurrentRevisionDescription { get; }
      Description: "Current Revision Description"
    static ForgeTypeId SheetCurrentRevisionIssued { get; }
      Description: "Current Revision Issued"
    static ForgeTypeId SheetCurrentRevisionIssuedBy { get; }
      Description: "Current Revision Issued By"
    static ForgeTypeId SheetCurrentRevisionIssuedTo { get; }
      Description: "Current Revision Issued To"
    static ForgeTypeId SheetDate { get; }
      Description: "Date/Time Stamp"
    static ForgeTypeId SheetDesignedBy { get; }
      Description: "Designed By"
    static ForgeTypeId SheetDrawnBy { get; }
      Description: "Drawn By"
    static ForgeTypeId SheetFilePath { get; }
      Description: "File Path"
    static ForgeTypeId SheetGuideGrid { get; }
      Description: "Guide Grid"
    static ForgeTypeId SheetHeight { get; }
      Description: "Sheet Height"
    static ForgeTypeId SheetIssueDate { get; }
      Description: "Sheet Issue Date"
    static ForgeTypeId SheetKeyNumber { get; }
      Description: "Sheet Key Number"
    static ForgeTypeId SheetName { get; }
      Description: "Sheet Name"
    static ForgeTypeId SheetNumber { get; }
      Description: "Sheet Number"
    static ForgeTypeId SheetRevisionsOnSheet { get; }
      Description: "Revisions on Sheet"
    static ForgeTypeId SheetScale { get; }
      Description: "Scale"
    static ForgeTypeId SheetScheduled { get; }
      Description: "Appears In Sheet List"
    static ForgeTypeId SheetWidth { get; }
      Description: "Sheet Width"
    static ForgeTypeId ShowArrowheadToCutMark { get; }
      Description: "Show Arrowhead to Cut Mark"
    static ForgeTypeId ShowIconParam { get; }
      Description: "Flag to display icon in Ribbon Combo Item"
    static ForgeTypeId ShowTitle { get; }
      Description: "Show Title"
    static ForgeTypeId SketchGridSpacingParam { get; }
      Description: "Work Plane Grid Spacing"
    static ForgeTypeId SketchPlaneParam { get; }
      Description: "Work Plane"
    static ForgeTypeId SlabEdgeMaterialParam { get; }
      Description: "Material"
    static ForgeTypeId SlabEdgeProfileParam { get; }
      Description: "Profile"
    static ForgeTypeId SlantedColumnBaseCutStyle { get; }
      Description: "Base Cut Style"
    static ForgeTypeId SlantedColumnBaseExtension { get; }
      Description: "Base Extension"
    static ForgeTypeId SlantedColumnGeometryTreatmentBase { get; }
      Description: "Base Geometry Alignment"
    static ForgeTypeId SlantedColumnGeometryTreatmentTop { get; }
      Description: "Top Geometry Alignment"
    static ForgeTypeId SlantedColumnTopCutStyle { get; }
      Description: "Top Cut Style"
    static ForgeTypeId SlantedColumnTopExtension { get; }
      Description: "Top Extension"
    static ForgeTypeId SlantedColumnTypeParam { get; }
      Description: "Column Style"
    static ForgeTypeId SlopeArrowLevelEnd { get; }
      Description: "Level at Head"
    static ForgeTypeId SlopeArrowLevelStart { get; }
      Description: "Level at Tail"
    static ForgeTypeId SlopeEndHeight { get; }
      Description: "Height Offset at Head"
    static ForgeTypeId SlopeStartHeight { get; }
      Description: "Height Offset at Tail"
    static ForgeTypeId SpaceAirChangesPerHour { get; }
      Description: "Air Changes per Hour"
    static ForgeTypeId SpaceAirflowPerAreaParam { get; }
      Description: "Airflow per area"
    static ForgeTypeId SpaceArea { get; }
      Description: "Area"
    static ForgeTypeId SpaceAreaPerPersonParam { get; }
      Description: "Area per person"
    static ForgeTypeId SpaceAssocRoomName { get; }
      Description: "Room Name"
    static ForgeTypeId SpaceAssocRoomNumber { get; }
      Description: "Room Number"
    static ForgeTypeId SpaceCarpetingParam { get; }
      Description: "Carpeting"
    static ForgeTypeId SpaceComposednameParam { get; }
      Description: "Composed Name"
    static ForgeTypeId SpaceConditionType { get; }
      Description: "Condition Type"
    static ForgeTypeId SpaceCoolingSetPoint { get; }
      Description: "Cooling Set Point"
    static ForgeTypeId SpaceDehumidificationSetPoint { get; }
      Description: "Dehumidification Set Point"
    static ForgeTypeId SpaceElecEquipmentRadiantPercentageParam { get; }
      Description: "Electrical Equipment Radiant"
    static ForgeTypeId SpaceHeatingSetPoint { get; }
      Description: "Heating Set Point"
    static ForgeTypeId SpaceHumidificationSetPoint { get; }
      Description: "Humidification Set Point"
    static ForgeTypeId SpaceInfiltrationAirflow { get; }
      Description: "Infiltration Airflow"
    static ForgeTypeId SpaceInfiltrationAirflowPerArea { get; }
      Description: "Infiltration Airflow per area"
    static ForgeTypeId SpaceInfiltrationParam { get; }
      Description: "Infiltration Airflow per area"
    static ForgeTypeId SpaceIsOccupiable { get; }
      Description: "Occupiable"
    static ForgeTypeId SpaceIsPlenum { get; }
      Description: "Plenum"
    static ForgeTypeId SpaceLightingLoadParam { get; }
      Description: "Lighting Load"
    static ForgeTypeId SpaceLightingLoadPerAreaParam { get; }
      Description: "Lighting Load per area"
    static ForgeTypeId SpaceLightingScheduleParam { get; }
      Description: "Lighting Schedule"
    static ForgeTypeId SpaceNameParam { get; }
      Description: "Name"
    static ForgeTypeId SpaceNumberOfPeople { get; }
      Description: "Number of People"
    static ForgeTypeId SpaceNumberParam { get; }
      Description: "Number"
    static ForgeTypeId SpaceOccupancyScheduleParam { get; }
      Description: "Occupancy Schedule"
    static ForgeTypeId SpaceOutdoorAirflow { get; }
      Description: "Outdoor Airflow"
    static ForgeTypeId SpaceOutdoorAirflowPerArea { get; }
      Description: "Outdoor Airflow per area"
    static ForgeTypeId SpaceOutdoorAirflowPerPerson { get; }
      Description: "Outdoor Airflow per person"
    static ForgeTypeId SpacePeopleActivityLevelParam { get; }
      Description: "People Activity Level"
    static ForgeTypeId SpacePeopleLatentHeatGainPerPersonParam { get; }
      Description: "Latent Heat Gain per person"
    static ForgeTypeId SpacePeopleLoadParam { get; }
      Description: "Occupancy Load"
    static ForgeTypeId SpacePeopleSensibleHeatGainPerPersonParam { get; }
      Description: "Sensible Heat Gain per person"
    static ForgeTypeId SpacePowerLoadParam { get; }
      Description: "Power Load"
    static ForgeTypeId SpacePowerLoadPerAreaParam { get; }
      Description: "Power Load per area"
    static ForgeTypeId SpacePowerScheduleParam { get; }
      Description: "Power Schedule"
    static ForgeTypeId SpaceReferenceLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId SpaceTypeGbxml { get; }
      Description: "Space Type (gbXML)"
    static ForgeTypeId SpaceVolume { get; }
      Description: "Volume"
    static ForgeTypeId SpaceZoneName { get; }
      Description: "Zone"
    static ForgeTypeId SpacingAppend { get; }
      Description: "Append Position"
    static ForgeTypeId SpacingJustification { get; }
      Description: "Justification"
    static ForgeTypeId SpacingJustificationHoriz { get; }
      Description: "Justification"
    static ForgeTypeId SpacingJustificationn1 { get; }
      Description: "Justification"
    static ForgeTypeId SpacingJustificationn2 { get; }
      Description: "Justification"
    static ForgeTypeId SpacingJustificationU { get; }
      Description: "Justification"
    static ForgeTypeId SpacingJustificationV { get; }
      Description: "Justification"
    static ForgeTypeId SpacingJustificationVert { get; }
      Description: "Justification"
    static ForgeTypeId SpacingLayout { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLayoutHoriz { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLayoutn1 { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLayoutn2 { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLayoutU { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLayoutV { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLayoutVert { get; }
      Description: "Layout"
    static ForgeTypeId SpacingLength { get; }
      Description: "Spacing"
    static ForgeTypeId SpacingLengthHoriz { get; }
      Description: "Spacing"
    static ForgeTypeId SpacingLengthn1 { get; }
      Description: "Spacing"
    static ForgeTypeId SpacingLengthn2 { get; }
      Description: "Spacing"
    static ForgeTypeId SpacingLengthU { get; }
      Description: "Distance"
    static ForgeTypeId SpacingLengthV { get; }
      Description: "Distance"
    static ForgeTypeId SpacingLengthVert { get; }
      Description: "Spacing"
    static ForgeTypeId SpacingNumDivisions { get; }
      Description: "Number"
    static ForgeTypeId SpacingNumDivisionsHoriz { get; }
      Description: "Number"
    static ForgeTypeId SpacingNumDivisionsn1 { get; }
      Description: "Number"
    static ForgeTypeId SpacingNumDivisionsn2 { get; }
      Description: "Number"
    static ForgeTypeId SpacingNumDivisionsU { get; }
      Description: "Number"
    static ForgeTypeId SpacingNumDivisionsV { get; }
      Description: "Number"
    static ForgeTypeId SpacingNumDivisionsVert { get; }
      Description: "Number"
    static ForgeTypeId SpanDirInstParamAngle { get; }
      Description: "Span Direction"
    static ForgeTypeId SpanDirSymParamBottom { get; }
      Description: "Bottom"
    static ForgeTypeId SpanDirSymParamLeft { get; }
      Description: "Left"
    static ForgeTypeId SpanDirSymParamRight { get; }
      Description: "Right"
    static ForgeTypeId SpanDirSymParamTop { get; }
      Description: "Top"
    static ForgeTypeId SpatialFieldMgrCurrentName { get; }
      Description: "Analysis Configuration"
    static ForgeTypeId SpatialFieldMgrDescription { get; }
      Description: "Description"
    static ForgeTypeId SpatialFieldMgrLegendHeight { get; }
      Description: "Legend Height"
    static ForgeTypeId SpatialFieldMgrLegendHorOriginGap { get; }
      Description: "Legend Horizontal Origin Gap"
    static ForgeTypeId SpatialFieldMgrLegendShowConfigName { get; }
      Description: "Show Configuration Name"
    static ForgeTypeId SpatialFieldMgrLegendShowDescription { get; }
      Description: "Show Description"
    static ForgeTypeId SpatialFieldMgrLegendTextType { get; }
      Description: "Overall Legend Text"
    static ForgeTypeId SpatialFieldMgrLegendVertOriginGap { get; }
      Description: "Legend Vertical Origin Gap"
    static ForgeTypeId SpatialFieldMgrLegendWidth { get; }
      Description: "Legend Width"
    static ForgeTypeId SpatialFieldMgrRange { get; }
      Description: "Data Range"
    static ForgeTypeId SpatialFieldMgrResultsVisibility { get; }
      Description: "Results Visibility"
    static ForgeTypeId SpecifySlopeOrOffset { get; }
      Description: "Specify "
    static ForgeTypeId SpliceByRulesMaxLength { get; }
      Description: "Maximum bar length"
    static ForgeTypeId SpliceByRulesMinLength { get; }
      Description: "Minimum bar length"
    static ForgeTypeId SpliceByRulesRunout { get; }
      Description: "Runout"
    static ForgeTypeId SpliceLapLengthAtEnd { get; }
      Description: "Lap Length at End"
    static ForgeTypeId SpliceLapLengthAtStart { get; }
      Description: "Lap Length at Start"
    static ForgeTypeId SpliceTypeAtEnd { get; }
      Description: "Splice at End"
    static ForgeTypeId SpliceTypeAtStart { get; }
      Description: "Splice at Start"
    static ForgeTypeId SpotCoordinateBase { get; }
      Description: "Coordinate Base"
    static ForgeTypeId SpotCoordinateBottomPrefix { get; }
      Description: "Bottom Coordinate Prefix"
    static ForgeTypeId SpotCoordinateBottomSuffix { get; }
      Description: "Bottom Coordinate Suffix"
    static ForgeTypeId SpotCoordinateElevationPrefix { get; }
      Description: "Elevation Prefix"
    static ForgeTypeId SpotCoordinateElevationSuffix { get; }
      Description: "Elevation Suffix"
    static ForgeTypeId SpotCoordinateIncludeElevation { get; }
      Description: "Include Elevation"
    static ForgeTypeId SpotCoordinateTopPrefix { get; }
      Description: "Top Coordinate Prefix"
    static ForgeTypeId SpotCoordinateTopSuffix { get; }
      Description: "Top Coordinate Suffix"
    static ForgeTypeId SpotDimLeader { get; }
      Description: "Leader"
    static ForgeTypeId SpotDimLeaderLine { get; }
      Description: "Leader Line"
    static ForgeTypeId SpotDimStyleSlopeUnits { get; }
      Description: "Units Format"
    static ForgeTypeId SpotDimStyleSlopeUnitsAlt { get; }
      Description: "Alternate Units Format"
    static ForgeTypeId SpotElevBase { get; }
      Description: "Elevation Base"
    static ForgeTypeId SpotElevBendLeader { get; }
      Description: "Leader Shoulder"
    static ForgeTypeId SpotElevBotValue { get; }
      Description: "Bottom Coordinate"
    static ForgeTypeId SpotElevDisplayElevations { get; }
      Description: "Display Elevations"
    static ForgeTypeId SpotElevFlipTextVert { get; }
      Description: "Auto Mirror"
    static ForgeTypeId SpotElevIndBottom { get; }
      Description: "Bottom Indicator"
    static ForgeTypeId SpotElevIndElevation { get; }
      Description: "Elevation Indicator"
    static ForgeTypeId SpotElevIndEw { get; }
      Description: "East / West Indicator"
    static ForgeTypeId SpotElevIndNs { get; }
      Description: "North / South Indicator"
    static ForgeTypeId SpotElevIndTop { get; }
      Description: "Top Indicator"
    static ForgeTypeId SpotElevIndType { get; }
      Description: "Indicator as Prefix / Suffix"
    static ForgeTypeId SpotElevIndTypeBottom { get; }
      Description: "Bottom Indicator as Prefix/Suffix"
    static ForgeTypeId SpotElevIndTypeElevation { get; }
      Description: "Elevation Indicator as Prefix/Suffix"
    static ForgeTypeId SpotElevIndTypeTop { get; }
      Description: "Top Indicator as Prefix/Suffix"
    static ForgeTypeId SpotElevLeaderArrowhead { get; }
      Description: "Leader Arrowhead"
    static ForgeTypeId SpotElevLinePen { get; }
      Description: "Leader Line Weight"
    static ForgeTypeId SpotElevLowerPrefix { get; }
      Description: "Lower Value Prefix"
    static ForgeTypeId SpotElevLowerSuffix { get; }
      Description: "Lower Value Suffix"
    static ForgeTypeId SpotElevLowerValue { get; }
      Description: "Lower Value"
    static ForgeTypeId SpotElevRelativeBase { get; }
      Description: "Relative Base"
    static ForgeTypeId SpotElevRotateWithComponent { get; }
      Description: "Rotate with Component"
    static ForgeTypeId SpotElevSingleOrUpperPrefix { get; }
      Description: "Single/Upper Value Prefix"
    static ForgeTypeId SpotElevSingleOrUpperSuffix { get; }
      Description: "Single/Upper Value Suffix"
    static ForgeTypeId SpotElevSingleOrUpperValue { get; }
      Description: "Single/Upper Value"
    static ForgeTypeId SpotElevSymbol { get; }
      Description: "Symbol"
    static ForgeTypeId SpotElevTextHorizOffset { get; }
      Description: "Text Offset from Symbol"
    static ForgeTypeId SpotElevTextLocation { get; }
      Description: "Text Location"
    static ForgeTypeId SpotElevTextOrientation { get; }
      Description: "Text Orientation"
    static ForgeTypeId SpotElevTickMarkPen { get; }
      Description: "Leader Arrowhead Line Weight"
    static ForgeTypeId SpotElevTopValue { get; }
      Description: "Top Coordinate"
    static ForgeTypeId SpotSlopeLeaderLength { get; }
      Description: "Leader Line Length"
    static ForgeTypeId SpotSlopeOffsetFromReference { get; }
      Description: "Offset from Reference"
    static ForgeTypeId SpotSlopePrefix { get; }
      Description: "Prefix"
    static ForgeTypeId SpotSlopeSlopeDirection { get; }
      Description: "Slope Direction"
    static ForgeTypeId SpotSlopeSlopeRepresentation { get; }
      Description: "Slope Representation"
    static ForgeTypeId SpotSlopeSuffix { get; }
      Description: "Suffix"
    static ForgeTypeId SpotTextFromLeader { get; }
      Description: "Text Offset from Leader"
    static ForgeTypeId SsePointBasetypeEnum { get; }
      Description: "Point Base Type"
    static ForgeTypeId SsePointElevation { get; }
      Description: "Elevation"
    static ForgeTypeId SsePointElevationBaseType { get; }
      Description: "Elevation Base Type"
    static ForgeTypeId SsePointOffsetFromSnaps { get; }
      Description: "Offset from Snaps"
    static ForgeTypeId SsePointOffsetFromSurface { get; }
      Description: "Offset from Surface"
    static ForgeTypeId StairsActualNumberOfRisers { get; }
      Description: "Actual Number of Risers": The total number of actually created risers in model
    static ForgeTypeId StairsActualNumRisers { get; }
      Description: "Actual Number of Risers"
    static ForgeTypeId StairsActualRiserHeight { get; }
      Description: "Actual Riser Height"
    static ForgeTypeId StairsActualTreadDepth { get; }
      Description: "Actual Tread Depth"
    static ForgeTypeId StairsAttrBodyMaterial { get; }
      Description: "Monolithic Material"
    static ForgeTypeId StairsAttrBreakSymInCutline { get; }
      Description: "Break Symbol in Plan"
    static ForgeTypeId StairsAttrCalcEnabled { get; }
      Description: "Calculation Rules"
    static ForgeTypeId StairsAttrCalcMax { get; }
      Description: "Calculation Rules"
    static ForgeTypeId StairsAttrCalcMin { get; }
      Description: "Calculation Rules"
    static ForgeTypeId StairsAttrEqResult { get; }
      Description: "Calculation Rules"
    static ForgeTypeId StairsAttrFirstRiser { get; }
      Description: "Begin with Riser"
    static ForgeTypeId StairsAttrLandingCarriage { get; }
      Description: "Landing Carriage Height"
    static ForgeTypeId StairsAttrLandingsOverlapping { get; }
      Description: "Landing Overlap"
    static ForgeTypeId StairsAttrLastRiser { get; }
      Description: "End with Riser"
    static ForgeTypeId StairsAttrLeftSideStringer { get; }
      Description: "Left Stringer"
    static ForgeTypeId StairsAttrMaxRiserHeight { get; }
      Description: "Maximum Riser Height"
    static ForgeTypeId StairsAttrMinimumTreadDepth { get; }
      Description: "Minimum Tread Depth"
    static ForgeTypeId StairsAttrMonolithicStairs { get; }
      Description: "Monolithic Stairs"
    static ForgeTypeId StairsAttrNosingLength { get; }
      Description: "Nosing Length"
    static ForgeTypeId StairsAttrNosingPlacement { get; }
      Description: "Apply Nosing Profile"
    static ForgeTypeId StairsAttrNumMidStringers { get; }
      Description: "Middle Stringers"
    static ForgeTypeId StairsAttrRightSideStringer { get; }
      Description: "Right Stringer"
    static ForgeTypeId StairsAttrRiserAngle { get; }
      Description: "Riser Angle"
    static ForgeTypeId StairsAttrRiserMaterial { get; }
      Description: "Riser Material"
    static ForgeTypeId StairsAttrRiserMult { get; }
      Description: "Riser Multiplier"
    static ForgeTypeId StairsAttrRisersPresent { get; }
      Description: "Risers Present"
    static ForgeTypeId StairsAttrRiserThickness { get; }
      Description: "Riser Thickness"
    static ForgeTypeId StairsAttrRiserTreadConnect { get; }
      Description: "Riser to Tread Connection"
    static ForgeTypeId StairsAttrRiserType { get; }
      Description: "Riser Type"
    static ForgeTypeId StairsAttrSideStringerTypeParam { get; }
      Description: "Type of Side Stringers"
    static ForgeTypeId StairsAttrStairCalculator { get; }
      Description: "Calculation Rules"
    static ForgeTypeId StairsAttrStairsBottom { get; }
      Description: "Underside of Winder"
    static ForgeTypeId StairsAttrStairsCutOffset { get; }
      Description: "Extend Below Base"
    static ForgeTypeId StairsAttrStringerCarriage { get; }
      Description: "Stringer Carriage Height"
    static ForgeTypeId StairsAttrStringerHeight { get; }
      Description: "Stringer Height"
    static ForgeTypeId StairsAttrStringerMaterial { get; }
      Description: "Stringer Material"
    static ForgeTypeId StairsAttrStringerOffset { get; }
      Description: "Open Stringer Offset"
    static ForgeTypeId StairsAttrStringerThickness { get; }
      Description: "Stringer Thickness"
    static ForgeTypeId StairsAttrTextFont { get; }
      Description: "Text Font"
    static ForgeTypeId StairsAttrTextSize { get; }
      Description: "Text Size"
    static ForgeTypeId StairsAttrTreadFrontProfile { get; }
      Description: "Nosing Profile"
    static ForgeTypeId StairsAttrTreadMaterial { get; }
      Description: "Tread Material"
    static ForgeTypeId StairsAttrTreadMult { get; }
      Description: "Tread Multiplier"
    static ForgeTypeId StairsAttrTreadThickness { get; }
      Description: "Tread Thickness"
    static ForgeTypeId StairsAttrTreadWidth { get; }
      Description: "Width"
    static ForgeTypeId StairsAttrTrimTop { get; }
      Description: "Trim Stringers at Top"
    static ForgeTypeId StairsBaseLevel { get; }
      Description: "Base Level": The base level of stairs
    static ForgeTypeId StairsBaseLevelParam { get; }
      Description: "Base Level"
    static ForgeTypeId StairsBaseOffset { get; }
      Description: "Base Offset"
    static ForgeTypeId StairsCurveType { get; }
      Description: "Stairs Line Type"
    static ForgeTypeId StairsDbgShowAnnotationCutMark { get; }
      Description: "Cut by Cut Plane"
    static ForgeTypeId StairsDbgShowBoundary2d { get; }
      Description: "Show Stairs' Boundary 2D"
    static ForgeTypeId StairsDbgShowBoundary3d { get; }
      Description: "Show Stairs' Boundary 3D"
    static ForgeTypeId StairsDbgShowLandingBoundary { get; }
      Description: "Show Landing Boundary"
    static ForgeTypeId StairsDbgShowLandingFaces { get; }
      Description: "Show Landing Faces"
    static ForgeTypeId StairsDbgShowLandingPath { get; }
      Description: "Show Landing Path"
    static ForgeTypeId StairsDbgShowLeftRunBoundary2d { get; }
      Description: "Show Run's Left Boundary 2D"
    static ForgeTypeId StairsDbgShowLeftRunBoundary3d { get; }
      Description: "Show Run's Left Boundary 3D"
    static ForgeTypeId StairsDbgShowMonolithicSupportCorseGeom { get; }
      Description: "Show Monolithic Support Corse Geometry"
    static ForgeTypeId StairsDbgShowMonolithicSupportGeom { get; }
      Description: "Show Monolithic Support Geometry"
    static ForgeTypeId StairsDbgShowRightRunBoundary2d { get; }
      Description: "Show Run's Right Boundary 2D"
    static ForgeTypeId StairsDbgShowRightRunBoundary3d { get; }
      Description: "Show Run's Right Boundary 3D"
    static ForgeTypeId StairsDbgShowRunCorseGeom { get; }
      Description: "Show Run Corse Geometry"
    static ForgeTypeId StairsDbgShowRunGeom { get; }
      Description: "Show Run Geometry"
    static ForgeTypeId StairsDbgShowRunNosing { get; }
      Description: "Show Run's Nosings"
    static ForgeTypeId StairsDbgShowRunOutlineForPlan { get; }
      Description: "Show Run Outline For Plan"
    static ForgeTypeId StairsDbgShowRunPath2d { get; }
      Description: "Show Run's Path 2D"
    static ForgeTypeId StairsDbgShowRunPath3d { get; }
      Description: "Show Run's Path 3D"
    static ForgeTypeId StairsDbgShowRunRiser { get; }
      Description: "Show Run's Risers"
    static ForgeTypeId StairsDbgShowSupportPath { get; }
      Description: "Show Support Path"
    static ForgeTypeId StairsDbgShowTreadFaces { get; }
      Description: "Show Run's Tread Faces"
    static ForgeTypeId StairsDbgShowTriserCorseGeom { get; }
      Description: "Show Triser Corse Geometry"
    static ForgeTypeId StairsDbgShowTriserGeom { get; }
      Description: "Show Triser Geometry"
    static ForgeTypeId StairsDesiredNumberOfRisers { get; }
      Description: "Desired Number of Risers": The number of risers is calculated based on stairs height
    static ForgeTypeId StairsDesiredNumRisers { get; }
      Description: "Desired Number of Risers"
    static ForgeTypeId StairsDownText { get; }
      Description: "Down Text"
    static ForgeTypeId StairsEnableCalculationRuleChecking { get; }
      Description: "Enable Calculator Rules Check": Enable calculation rule checking
    static ForgeTypeId StairsInstAlwaysUp { get; }
      Description: "Show Up arrow in all views"
    static ForgeTypeId StairsInstDownArrowOn { get; }
      Description: "Down arrow"
    static ForgeTypeId StairsInstDownLabelOn { get; }
      Description: "Down label"
    static ForgeTypeId StairsInstDownLabelText { get; }
      Description: "Down text"
    static ForgeTypeId StairsInstUpArrowOn { get; }
      Description: "Up arrow"
    static ForgeTypeId StairsInstUpLabelOn { get; }
      Description: "Up label"
    static ForgeTypeId StairsInstUpLabelText { get; }
      Description: "Up text"
    static ForgeTypeId StairsLandingBaseElevation { get; }
      Description: "Relative Height": Height
    static ForgeTypeId StairsLandingOverridden { get; }
      Description: "Overridden": Overridden
    static ForgeTypeId StairsLandingStructural { get; }
      Description: "Structural": Structural
    static ForgeTypeId StairsLandingThickness { get; }
      Description: "Total Thickness": Thickness
    static ForgeTypeId StairsLandingtypeHasMonolithicSupport { get; }
      Description: "Monolithic Support": Monolithic Support
    static ForgeTypeId StairsLandingtypeLandingMaterial { get; }
      Description: "Monolithic Material": Landing Material
    static ForgeTypeId StairsLandingtypeStructure { get; }
      Description: "Structure": Structure
    static ForgeTypeId StairsLandingtypeThickness { get; }
      Description: "Monolithic Thickness": Default thickness
    static ForgeTypeId StairsLandingtypeTreadriserType { get; }
      Description: "Type": Tread/Riser Type
    static ForgeTypeId StairsLandingtypeUseSameTriserAsRun { get; }
      Description: "Same as Run": Same as Run
    static ForgeTypeId StairsMinAutomaticLandingDepth { get; }
      Description: "Minimum Automatic Landing Depth": The minimum depth of automatic landing
    static ForgeTypeId StairsMultistoryTopLevelParam { get; }
      Description: "Multistory Top Level"
    static ForgeTypeId StairsMultistoryUpToLevel { get; }
      Description: "Multistory Top Level": The top level of multi-story stairs
    static ForgeTypeId StairsPathFullStepArrow { get; }
      Description: "Full Step Arrow"
    static ForgeTypeId StairsPathStartExtension { get; }
      Description: "Start Extension"
    static ForgeTypeId StairsPathStartFromRiser { get; }
      Description: "Start from Riser"
    static ForgeTypeId StairsRailingAngledConnection { get; }
      Description: "Angled Joins"
    static ForgeTypeId StairsRailingBalusterBottomAngle { get; }
      Description: "Bottom Cut Angle"
    static ForgeTypeId StairsRailingBalusterFamily { get; }
      Description: "Baluster Family"
    static ForgeTypeId StairsRailingBalusterHeight { get; }
      Description: "Baluster Height"
    static ForgeTypeId StairsRailingBalusterIsPost { get; }
      Description: "Post"
    static ForgeTypeId StairsRailingBalusterLength { get; }
      Description: "Baluster Length"
    static ForgeTypeId StairsRailingBalusterOffset { get; }
      Description: "Baluster Offset"
    static ForgeTypeId StairsRailingBalusterPlacement { get; }
      Description: "Baluster Placement"
    static ForgeTypeId StairsRailingBalusterShape { get; }
      Description: "Baluster Shape"
    static ForgeTypeId StairsRailingBalusterSlopeAngle { get; }
      Description: "Slope Angle"
    static ForgeTypeId StairsRailingBalusterSpacing { get; }
      Description: "Baluster Separation"
    static ForgeTypeId StairsRailingBalusterSpacingType { get; }
      Description: "Baluster Spacing Type (Stair Railing Only)"
    static ForgeTypeId StairsRailingBalustersPerTread { get; }
      Description: "Balusters Per Tread (Stair Railing Only)"
    static ForgeTypeId StairsRailingBalusterTopAngle { get; }
      Description: "Top Cut Angle"
    static ForgeTypeId StairsRailingBalusterWidth { get; }
      Description: "Baluster Width"
    static ForgeTypeId StairsRailingBaseLevelParam { get; }
      Description: "Base Level"
    static ForgeTypeId StairsRailingConnection { get; }
      Description: "Rail Connections"
    static ForgeTypeId StairsRailingHeight { get; }
      Description: "Railing Height"
    static ForgeTypeId StairsRailingHeightOffset { get; }
      Description: "Base Offset"
    static ForgeTypeId StairsRailingHeightShiftType { get; }
      Description: "Use Landing Height Adjustment"
    static ForgeTypeId StairsRailingHeightShiftVal { get; }
      Description: "Landing Height Adjustment"
    static ForgeTypeId StairsRailingPlacementOffset { get; }
      Description: "Offset from Path"
    static ForgeTypeId StairsRailingRailHeight { get; }
      Description: "Rail Height"
    static ForgeTypeId StairsRailingRailName { get; }
      Description: "Name"
    static ForgeTypeId StairsRailingRailOffset { get; }
      Description: "Rail Offset"
    static ForgeTypeId StairsRailingRailStructure { get; }
      Description: "Rail Structure (Non-Continuous)"
    static ForgeTypeId StairsRailingShape { get; }
      Description: "Rail Shape"
    static ForgeTypeId StairsRailingTangentConnection { get; }
      Description: "Tangent Joins"
    static ForgeTypeId StairsRailingThickness { get; }
      Description: "Railing Thickness"
    static ForgeTypeId StairsRailingWidth { get; }
      Description: "Railing Width"
    static ForgeTypeId StairsRunActualNumberOfRisers { get; }
      Description: "Actual Number of Risers": Actual Number of Risers
    static ForgeTypeId StairsRunActualNumberOfTreads { get; }
      Description: "Actual Number of Treads": Actual Number of Treads
    static ForgeTypeId StairsRunActualRiserHeight { get; }
      Description: "Actual Riser Height": Actual Riser Height
    static ForgeTypeId StairsRunActualRunWidth { get; }
      Description: "Actual Run Width": Actual Run Width
    static ForgeTypeId StairsRunActualTreadDepth { get; }
      Description: "Actual Tread Depth": Actual Tread Depth
    static ForgeTypeId StairsRunBeginWithRiser { get; }
      Description: "Begin with Riser": Begin with Riser
    static ForgeTypeId StairsRunBottomElevation { get; }
      Description: "Relative Base Height": Relative height to stairs bottom elevation
    static ForgeTypeId StairsRunCcw { get; }
      Description: "CCW": Revert the run preview
    static ForgeTypeId StairsRunCenterMarkVisible { get; }
      Description: "Center Mark Visible": Center Mark Visible
    static ForgeTypeId StairsRunCreateAutoLanding { get; }
      Description: "With Automatic Landing": Create automatic landing
    static ForgeTypeId StairsRunEndWithRiser { get; }
      Description: "End with Riser": End with Riser
    static ForgeTypeId StairsRunExtendBelowRiserBase { get; }
      Description: "Extend Below Riser Base": Extend Below Base
    static ForgeTypeId StairsRunExtendBelowTreadBase { get; }
      Description: "Extend Below Tread Base": Extend Below Tread Base
    static ForgeTypeId StairsRunHeight { get; }
      Description: "Run Height": Run Height
    static ForgeTypeId StairsRunLocationpathJustfication { get; }
      Description: "Location Line": Location Line
    static ForgeTypeId StairsRunOverridden { get; }
      Description: "Overridden": Overridden
    static ForgeTypeId StairsRunStructural { get; }
      Description: "Structural": Structural
    static ForgeTypeId StairsRunTopElevation { get; }
      Description: "Relative Top Height": Top height of run
    static ForgeTypeId StairsRuntypeHasMonolithicSupport { get; }
      Description: "Monolithic Support": Monolithic Support
    static ForgeTypeId StairsRuntypeRunMaterial { get; }
      Description: "Monolithic Material": Material
    static ForgeTypeId StairsRuntypeStructuralDepth { get; }
      Description: "Structural Depth": Structural Depth
    static ForgeTypeId StairsRuntypeStructure { get; }
      Description: "Structure": Structure
    static ForgeTypeId StairsRuntypeTotalDepth { get; }
      Description: "Total Depth": Total Depth
    static ForgeTypeId StairsRuntypeUndersideSurfaceType { get; }
      Description: "Underside Surface": Underside Surface
    static ForgeTypeId StairsRunWidthMeasurement { get; }
      Description: "Run Width Measurement": Run Width Measurement
    static ForgeTypeId StairsRunWinderBeginWithStraight { get; }
      Description: "Begin with Straight Run": Winder begin with straight run
    static ForgeTypeId StairsRunWinderEndWithStraight { get; }
      Description: "End with Straight Run": Winder end with straight run
    static ForgeTypeId StairsShowDownText { get; }
      Description: "Show Down Text"
    static ForgeTypeId StairsShowUpText { get; }
      Description: "Show Up Text"
    static ForgeTypeId StairsStairsHeight { get; }
      Description: "Desired Stair Height": Stairs unconnected height
    static ForgeTypeId StairsStringersPresent { get; }
      Description: "Stringer Position"
    static ForgeTypeId StairsSupportHorizontalOffset { get; }
      Description: "Lateral Offset": Distance from center or edge of boundary
    static ForgeTypeId StairsSupportLandingsupportType { get; }
      Description: "Landing Support Type": Landing Support Type
    static ForgeTypeId StairsSupportLowerEndCut { get; }
      Description: "Lower End Cut": Lower End Cut
    static ForgeTypeId StairsSupportOverridden { get; }
      Description: "Overridden": Overridden
    static ForgeTypeId StairsSupportTrimSupportUpper { get; }
      Description: "Trim Support at Upper": Trim Support at Upper
    static ForgeTypeId StairsSupporttypeFlipSectionProfile { get; }
      Description: "Flip Section Profile": Flip Section Profile
    static ForgeTypeId StairsSupporttypeMaterial { get; }
      Description: "Material": Material
    static ForgeTypeId StairsSupporttypeSectionProfile { get; }
      Description: "Section Profile": Section Profile
    static ForgeTypeId StairsSupporttypeStructuralDepth { get; }
      Description: "Structural Depth": Structural Depth
    static ForgeTypeId StairsSupporttypeStructuralDepthOnLanding { get; }
      Description: "Structural Depth On Landing": Structural Depth
    static ForgeTypeId StairsSupporttypeStructuralDepthOnRun { get; }
      Description: "Structural Depth On Run": Structural Depth
    static ForgeTypeId StairsSupporttypeTopsideSurface { get; }
      Description: "Topside Surface": Topside Surface
    static ForgeTypeId StairsSupporttypeTotalDepth { get; }
      Description: "Total Depth": Total Depth
    static ForgeTypeId StairsSupporttypeUndersideSurface { get; }
      Description: "Underside Surface": Underside Surface
    static ForgeTypeId StairsSupporttypeWidth { get; }
      Description: "Width": Width
    static ForgeTypeId StairsSupportUpperEndCut { get; }
      Description: "Upper End Cut": Upper End Cut
    static ForgeTypeId StairsSupportVerticalOffset { get; }
      Description: "Vertical Offset": Distance of top plane of edge stringer relative to the plane connecting tread nosing
    static ForgeTypeId StairsTextOrientation { get; }
      Description: "Orientation"
    static ForgeTypeId StairsTextType { get; }
      Description: "Text Type"
    static ForgeTypeId StairsTopLevel { get; }
      Description: "Top Level": The top level of stairs
    static ForgeTypeId StairsTopLevelParam { get; }
      Description: "Top Level"
    static ForgeTypeId StairsTopOffset { get; }
      Description: "Top Offset"
    static ForgeTypeId StairsTotalNumberOfRisers { get; }
      Description: "Total Number of Risers": Total number of risers
    static ForgeTypeId StairsTotalNumberOfTreads { get; }
      Description: "Total Number of Treads": Total number of treads
    static ForgeTypeId StairsTriserIsTypeOverridden { get; }
      Description: "Overridden": (OBSOLETE) Indicate whether selected individual step is governed by default type setting.
    static ForgeTypeId StairsTriserNumberBaseIndex { get; }
      Description: "Tread/Riser Start Number":
    static ForgeTypeId StairsTriserRiserMark { get; }
      Description: "Riser Mark": (OBSOLETE)
    static ForgeTypeId StairsTriserRiserNumber { get; }
      Description: "Riser Number": Count the sequential number of riser in the stair.
    static ForgeTypeId StairsTriserTreadMark { get; }
      Description: "Tread Mark": (OBSOLETE)
    static ForgeTypeId StairsTriserTreadNumber { get; }
      Description: "Tread Number": Count the sequential number of tread in the stair.
    static ForgeTypeId StairsTrisertypeBackNosing { get; }
      Description: "Back Nosing": (OBSOLETE)
    static ForgeTypeId StairsTrisertypeFrontNosing { get; }
      Description: "Front Nosing": (OBSOLETE)
    static ForgeTypeId StairsTrisertypeLeftNosing { get; }
      Description: "Left Nosing": (OBSOLETE)
    static ForgeTypeId StairsTrisertypeNosingLength { get; }
      Description: "Nosing Length"
    static ForgeTypeId StairsTrisertypeNosingPlacement { get; }
      Description: "Apply Nosing Profile"
    static ForgeTypeId StairsTrisertypeNosingProfile { get; }
      Description: "Nosing Profile"
    static ForgeTypeId StairsTrisertypeRightNosing { get; }
      Description: "Right Nosing": (OBSOLETE)
    static ForgeTypeId StairsTrisertypeRiser { get; }
      Description: "Riser"
    static ForgeTypeId StairsTrisertypeRiserIsSlanted { get; }
      Description: "Slanted"
    static ForgeTypeId StairsTrisertypeRiserMaterial { get; }
      Description: "Riser Material"
    static ForgeTypeId StairsTrisertypeRiserProfile { get; }
      Description: "Riser Profile"
    static ForgeTypeId StairsTrisertypeRiserStyle { get; }
      Description: "Riser Type": (OBSOLETE)
    static ForgeTypeId StairsTrisertypeRiserThickness { get; }
      Description: "Riser Thickness"
    static ForgeTypeId StairsTrisertypeRiserTreadConnection { get; }
      Description: "Riser To Tread Connection"
    static ForgeTypeId StairsTrisertypeTread { get; }
      Description: "Tread"
    static ForgeTypeId StairsTrisertypeTreadMaterial { get; }
      Description: "Tread Material"
    static ForgeTypeId StairsTrisertypeTreadProfile { get; }
      Description: "Tread Profile"
    static ForgeTypeId StairsTrisertypeTreadThickness { get; }
      Description: "Tread Thickness"
    static ForgeTypeId StairstypeCalcRuleMaxResult { get; }
      Description: "Max. Result": Calculation Rule Max Result
    static ForgeTypeId StairstypeCalcRuleMinResult { get; }
      Description: "Min. Result": Calculation Rule Min Result
    static ForgeTypeId StairstypeCalcRuleRiserMultiplier { get; }
      Description: "Riser Multiplier": Calculation Rule Riser Multiplier
    static ForgeTypeId StairstypeCalcRuleTargetResult { get; }
      Description: "Target Result": Calculation Rule Target Result
    static ForgeTypeId StairstypeCalcRuleTreadMultiplier { get; }
      Description: "Tread Multiplier": Calculation Rule Tread Multiplier
    static ForgeTypeId StairstypeCalculationRules { get; }
      Description: "Calculation Rules": Calculation Rules
    static ForgeTypeId StairstypeConstructionMethod { get; }
      Description: "Construction Method":
    static ForgeTypeId StairstypeCutmarkType { get; }
      Description: "Cut Mark Type": Cut Mark Type
    static ForgeTypeId StairstypeGeomunjoinedEndCutStyle { get; }
      Description: "Connection Method": Cut Style for Geometrically Unjoined End
    static ForgeTypeId StairstypeHasIntermediateSupport { get; }
      Description: "Middle Support": Whether stairs is assembled
    static ForgeTypeId StairstypeHasLeftSupport { get; }
      Description: "Left Support":
    static ForgeTypeId StairstypeHasRightSupport { get; }
      Description: "Right Support":
    static ForgeTypeId StairstypeIntermediateSupportType { get; }
      Description: "Middle Support Type": Intermediate Support Type
    static ForgeTypeId StairstypeIsAssembledStairs { get; }
      Description: "Assembled Stair": Whether stairs is assembled
    static ForgeTypeId StairstypeLandingType { get; }
      Description: "Landing Type": Landing Type
    static ForgeTypeId StairstypeLeftSideSupportType { get; }
      Description: "Left Support Type": Left Side Support Type
    static ForgeTypeId StairstypeLeftSupportLateralOffset { get; }
      Description: "Left Lateral Offset":
    static ForgeTypeId StairstypeMaximumRiserHeight { get; }
      Description: "Max. Riser Height": Maximum Riser Height
    static ForgeTypeId StairstypeMinimumRunWidth { get; }
      Description: "Minimum Run Width": Minimum Run Width
    static ForgeTypeId StairstypeMinimumTreadDepth { get; }
      Description: "Min. Tread Depth": Minimum Tread Depth
    static ForgeTypeId StairstypeMinimumTreadWidthInsideBoundary { get; }
      Description: "Min. Tread Depth on Winder Inner Boundary": Minimum Tread Width on Inside Boundary
    static ForgeTypeId StairstypeNotchCustomWidth { get; }
      Description: "Custom":
    static ForgeTypeId StairstypeNotchExtension { get; }
      Description: "Notch Extension":
    static ForgeTypeId StairstypeNotchHorizontalGap { get; }
      Description: "Horizontal Gap Distance":
    static ForgeTypeId StairstypeNotchThickness { get; }
      Description: "Notch Thickness":
    static ForgeTypeId StairstypeNotchVerticalGap { get; }
      Description: "Vertical Gap Distance":
    static ForgeTypeId StairstypeNotchWidth { get; }
      Description: "Notch Width":
    static ForgeTypeId StairstypeNumberOfIntermediateSupports { get; }
      Description: "Middle Support Number": Number of intermediate supports
    static ForgeTypeId StairstypeRightSideSupportType { get; }
      Description: "Right Support Type": Right Side Support Type
    static ForgeTypeId StairstypeRightSupportLateralOffset { get; }
      Description: "Right Lateral Offset":
    static ForgeTypeId StairstypeRunType { get; }
      Description: "Run Type": Run Type
    static ForgeTypeId StairstypeShowCutline { get; }
      Description: "Show Cut Line in Plan": Show Cut Line in Plan
    static ForgeTypeId StairstypeShowStairPath { get; }
      Description: "Show Stair Path in Plan": Show Stair Path in Plan
    static ForgeTypeId StairstypeShowUpdown { get; }
      Description: "Show Up/Down in Plan": Show Up/Down in Plan
    static ForgeTypeId StairstypeWinderStepFrontMeasurement { get; }
      Description: "Winder Algorithm": Winder Algorithm
    static ForgeTypeId StairsUpText { get; }
      Description: "Up Text"
    static ForgeTypeId StairsWinderpatternFilletInsideCorner { get; }
      Description: "Fillet on Corner": Fillet on inside corner
    static ForgeTypeId StairsWinderpatternMinimumWidthCorner { get; }
      Description: "Minimum Width on Inside Boundary": Minimum Width on Inside Boundary
    static ForgeTypeId StairsWinderpatternMinimumWidthInsideWalkline { get; }
      Description: "Minimum Width on Inside Walk Line": Minimum width on inside walkline
    static ForgeTypeId StairsWinderpatternNumberOfStraightStepsAtBegin { get; }
      Description: "Parallel Treads at Start": Number of straight steps at the begin of winder
    static ForgeTypeId StairsWinderpatternNumberOfStraightStepsAtEnd { get; }
      Description: "Parallel Treads at End": Number of straight steps at the begin of winder
    static ForgeTypeId StairsWinderpatternRadiusInterior { get; }
      Description: "Fillet Radius": The fillet corner radius on the interior boundary
    static ForgeTypeId StairsWinderpatternStairPathOffset { get; }
      Description: "Inside Walk Line Offset": The offset from inside walk line to interior boundary
    static ForgeTypeId StairsWinderpatternWinderStyle { get; }
      Description: "Winder Style": Winder Style
    static ForgeTypeId StartExtension { get; }
      Description: "Start Extension"
    static ForgeTypeId StartJoinCutback { get; }
      Description: "Start Join Cutback"
    static ForgeTypeId StartSymbolType { get; }
      Description: "Start Symbol Type"
    static ForgeTypeId StartYJustification { get; }
      Description: "Start y Justification"
    static ForgeTypeId StartYOffsetValue { get; }
      Description: "Start y Offset Value"
    static ForgeTypeId StartZJustification { get; }
      Description: "Start z Justification"
    static ForgeTypeId StartZOffsetValue { get; }
      Description: "Start z Offset Value"
    static ForgeTypeId SteelElemAnchorAssembly { get; }
      Description: "Assembly"
    static ForgeTypeId SteelElemAnchorDiameter { get; }
      Description: "Diameter"
    static ForgeTypeId SteelElemAnchorGrade { get; }
      Description: "Grade"
    static ForgeTypeId SteelElemAnchorLength { get; }
      Description: "Length"
    static ForgeTypeId SteelElemAnchorOrientation { get; }
      Description: "Anchor Orientation"
    static ForgeTypeId SteelElemAnchorStandard { get; }
      Description: "Standard"
    static ForgeTypeId SteelElemAnchorTotalWeight { get; }
      Description: "Total Weight"
    static ForgeTypeId SteelElemBoltAssembly { get; }
      Description: "Assembly"
    static ForgeTypeId SteelElemBoltCoating { get; }
      Description: "Coating"
    static ForgeTypeId SteelElemBoltDiameter { get; }
      Description: "Diameter"
    static ForgeTypeId SteelElemBoltFinishCalculationAtGap { get; }
      Description: "Finish Calculation At Gap"
    static ForgeTypeId SteelElemBoltGrade { get; }
      Description: "Grade"
    static ForgeTypeId SteelElemBoltGripLength { get; }
      Description: "Grip Length"
    static ForgeTypeId SteelElemBoltGripLengthIncrease { get; }
      Description: "Grip Length Increase"
    static ForgeTypeId SteelElemBoltInverted { get; }
      Description: "Inverted"
    static ForgeTypeId SteelElemBoltLength { get; }
      Description: "Bolt Length"
    static ForgeTypeId SteelElemBoltLocation { get; }
      Description: "Location"
    static ForgeTypeId SteelElemBoltStandard { get; }
      Description: "Standard"
    static ForgeTypeId SteelElemBoltTotalWeight { get; }
      Description: "Total Weight"
    static ForgeTypeId SteelElemCoating { get; }
      Description: "Coating"
    static ForgeTypeId SteelElemContourGapWidth { get; }
      Description: "Gap Width"
    static ForgeTypeId SteelElemContourSide1dist { get; }
      Description: "Boundary distance 1"
    static ForgeTypeId SteelElemContourSide2dist { get; }
      Description: "Boundary distance 2"
    static ForgeTypeId SteelElemCopeAroundAxis { get; }
      Description: "Around beam axis"
    static ForgeTypeId SteelElemCopeAxisAngle { get; }
      Description: "Tilt angle"
    static ForgeTypeId SteelElemCopeDistanceAxis { get; }
      Description: "Distance from axis"
    static ForgeTypeId SteelElemCopeWidthx { get; }
      Description: "Cutback"
    static ForgeTypeId SteelElemCopeXAngle { get; }
      Description: "Cross-section rotation"
    static ForgeTypeId SteelElemCopeZAngle { get; }
      Description: "Plan rotation"
    static ForgeTypeId SteelElemCutLength { get; }
      Description: "Cut Length"
    static ForgeTypeId SteelElemCutType { get; }
      Description: "Type"
    static ForgeTypeId SteelElemExactWeight { get; }
      Description: "Exact Weight"
    static ForgeTypeId SteelElemHoleAlpha { get; }
      Description: "Taper Angle"
    static ForgeTypeId SteelElemHoleAngle { get; }
      Description: "Chamfer angle"
    static ForgeTypeId SteelElemHoleBackTaperThread { get; }
      Description: "Back taper thread"
    static ForgeTypeId SteelElemHoleDefinition { get; }
      Description: "Hole Definition"
    static ForgeTypeId SteelElemHoleDepth { get; }
      Description: "Hole Depth"
    static ForgeTypeId SteelElemHoleDepthOfBoltHead { get; }
      Description: "Depth of bolt head"
    static ForgeTypeId SteelElemHoleDiameter { get; }
      Description: "Diameter"
    static ForgeTypeId SteelElemHoleHeadDiameter { get; }
      Description: "Head diameter"
    static ForgeTypeId SteelElemHoleSlotDirection { get; }
      Description: "Along side 1"
    static ForgeTypeId SteelElemHoleSlotLength { get; }
      Description: "Length of the slot"
    static ForgeTypeId SteelElemHoleTapping { get; }
      Description: "Right-handed thread"
    static ForgeTypeId SteelElemHoleTappingHole { get; }
      Description: "Tapping hole"
    static ForgeTypeId SteelElemHoleType { get; }
      Description: "Type"
    static ForgeTypeId SteelElemMark { get; }
      Description: "Assembly Mark"
    static ForgeTypeId SteelElemPaintArea { get; }
      Description: "Paint Area"
    static ForgeTypeId SteelElemParamBoringout { get; }
      Description: "Boring out"
    static ForgeTypeId SteelElemParamRadius { get; }
      Description: "Radius"
    static ForgeTypeId SteelElemPatternEdgeDistanceX { get; }
      Description: "Edge distance on side 1"
    static ForgeTypeId SteelElemPatternEdgeDistanceY { get; }
      Description: "Edge distance on side 2"
    static ForgeTypeId SteelElemPatternIntermediateDistanceX { get; }
      Description: "Intermediate distance on side 1"
    static ForgeTypeId SteelElemPatternIntermediateDistanceY { get; }
      Description: "Intermediate distance on side 2"
    static ForgeTypeId SteelElemPatternNumber { get; }
      Description: "Number"
    static ForgeTypeId SteelElemPatternNumberX { get; }
      Description: "Number on side 1"
    static ForgeTypeId SteelElemPatternNumberY { get; }
      Description: "Number on side 2"
    static ForgeTypeId SteelElemPatternRadius { get; }
      Description: "Radius"
    static ForgeTypeId SteelElemPatternTotalLength { get; }
      Description: "Length on side 1"
    static ForgeTypeId SteelElemPatternTotalWidth { get; }
      Description: "Length on side 2"
    static ForgeTypeId SteelElemPlateArea { get; }
      Description: "Area"
    static ForgeTypeId SteelElemPlateExactWeight { get; }
      Description: "Exact Weight"
    static ForgeTypeId SteelElemPlateJustification { get; }
      Description: "Justification"
    static ForgeTypeId SteelElemPlateLength { get; }
      Description: "Length"
    static ForgeTypeId SteelElemPlatePaintArea { get; }
      Description: "Paint Area"
    static ForgeTypeId SteelElemPlateShortenAngle { get; }
      Description: "Angle"
    static ForgeTypeId SteelElemPlateShortenCutstraight { get; }
      Description: "Cut straight"
    static ForgeTypeId SteelElemPlateShortenSuction { get; }
      Description: "Suction"
    static ForgeTypeId SteelElemPlateThickness { get; }
      Description: "Thickness"
    static ForgeTypeId SteelElemPlateType { get; }
      Description: "Type"
    static ForgeTypeId SteelElemPlateVolume { get; }
      Description: "Volume"
    static ForgeTypeId SteelElemPlateWeight { get; }
      Description: "Weight"
    static ForgeTypeId SteelElemPlateWidth { get; }
      Description: "Width"
    static ForgeTypeId SteelElemProfileLength { get; }
      Description: "Length"
    static ForgeTypeId SteelElemProfileType { get; }
      Description: "Profile Type"
    static ForgeTypeId SteelElemProfileVolume { get; }
      Description: "Volume"
    static ForgeTypeId SteelElemShearstudDiameter { get; }
      Description: "Diameter"
    static ForgeTypeId SteelElemShearstudGrade { get; }
      Description: "Grade"
    static ForgeTypeId SteelElemShearstudLength { get; }
      Description: "Length"
    static ForgeTypeId SteelElemShearstudStandard { get; }
      Description: "Standard"
    static ForgeTypeId SteelElemShearstudTotalWeight { get; }
      Description: "Total Weight"
    static ForgeTypeId SteelElemShortenAngley { get; }
      Description: "Angle along height"
    static ForgeTypeId SteelElemShortenAnglez { get; }
      Description: "Angle along width"
    static ForgeTypeId SteelElemShortenReflength { get; }
      Description: "Length"
    static ForgeTypeId SteelElemSinglePartMark { get; }
      Description: "Single Part Mark"
    static ForgeTypeId SteelElemWeight { get; }
      Description: "Weight"
    static ForgeTypeId SteelElemWeldContinuous { get; }
      Description: "Continuous"
    static ForgeTypeId SteelElemWeldDoubleEffectivethroat { get; }
      Description: "Double Effective Throat"
    static ForgeTypeId SteelElemWeldDoublePrepdepth { get; }
      Description: "Double Preparation Depth"
    static ForgeTypeId SteelElemWeldDoubleRootopening { get; }
      Description: "Double Root Opening"
    static ForgeTypeId SteelElemWeldDoubleSurfaceshape { get; }
      Description: "Double Surface Shape"
    static ForgeTypeId SteelElemWeldDoubleText { get; }
      Description: "Double Text"
    static ForgeTypeId SteelElemWeldDoubleThickness { get; }
      Description: "Double Thickness"
    static ForgeTypeId SteelElemWeldDoubleType { get; }
      Description: "Double Type"
    static ForgeTypeId SteelElemWeldDoubleWeldprep { get; }
      Description: "Double Weld preparation"
    static ForgeTypeId SteelElemWeldLength { get; }
      Description: "Length"
    static ForgeTypeId SteelElemWeldLocation { get; }
      Description: "Location"
    static ForgeTypeId SteelElemWeldMainEffectivethroat { get; }
      Description: "Main Effective Throat"
    static ForgeTypeId SteelElemWeldMainPrepdepth { get; }
      Description: "Main Preparation Depth"
    static ForgeTypeId SteelElemWeldMainRootopening { get; }
      Description: "Main Root Opening"
    static ForgeTypeId SteelElemWeldMainSurfaceshape { get; }
      Description: "Surface Shape"
    static ForgeTypeId SteelElemWeldMainText { get; }
      Description: "Main Text"
    static ForgeTypeId SteelElemWeldMainThickness { get; }
      Description: "Main Thickness"
    static ForgeTypeId SteelElemWeldMainType { get; }
      Description: "Main Type"
    static ForgeTypeId SteelElemWeldMainWeldprep { get; }
      Description: "Main Weld preparation"
    static ForgeTypeId SteelElemWeldPitch { get; }
      Description: "Pitch"
    static ForgeTypeId SteelElemWeldPrefix { get; }
      Description: "Prefix"
    static ForgeTypeId SteelElemWeldTextModule { get; }
      Description: "Text module"
    static ForgeTypeId SteelElemXDistance { get; }
      Description: "Side 1"
    static ForgeTypeId SteelElemYDistance { get; }
      Description: "Side 2"
    static ForgeTypeId SteelElemZclipType { get; }
      Description: "Boundary"
    static ForgeTypeId StiffenerClassification { get; }
      Description: "Classification"
    static ForgeTypeId StructConnectionApplyTo { get; }
      Description: "Apply to"
    static ForgeTypeId StructConnectionBeamEnd { get; }
      Description: "End Connection"
    static ForgeTypeId StructConnectionBeamStart { get; }
      Description: "Start Connection"
    static ForgeTypeId StructConnectionColumnBase { get; }
      Description: "Base Connection"
    static ForgeTypeId StructConnectionColumnTop { get; }
      Description: "Top Connection"
    static ForgeTypeId StructConnectionCutback { get; }
      Description: "Automatic Cutback for Beams and Braces"
    static ForgeTypeId StructConnectionTypeName { get; }
      Description: "Name"
    static ForgeTypeId StructFramJoinStatus { get; }
      Description: "Join Status"
    static ForgeTypeId StructuralAnalyticalBeamHorizontalProjectionPlane { get; }
      Description: "Horizontal Projection"
    static ForgeTypeId StructuralAnalyticalBeamRigidLink { get; }
      Description: "Analytical Links"
    static ForgeTypeId StructuralAnalyticalColumnHorizontalProjectionPlane { get; }
      Description: "Horizontal Projection"
    static ForgeTypeId StructuralAnalyticalColumnRigidLink { get; }
      Description: "Analytical Links"
    static ForgeTypeId StructuralAnalyticalHardPoints { get; }
      Description: "Use hard-points"
    static ForgeTypeId StructuralAnalyticalModel { get; }
      Description: "Enable Analytical Model"
    static ForgeTypeId StructuralAnalyticalProjectFloorPlane { get; }
      Description: "Vertical Projection"
    static ForgeTypeId StructuralAnalyticalProjectMemberPlane { get; }
      Description: "Vertical Projection"
    static ForgeTypeId StructuralAnalyticalProjectMemberPlaneColumnBottom { get; }
      Description: "Bottom Vertical Projection"
    static ForgeTypeId StructuralAnalyticalProjectMemberPlaneColumnTop { get; }
      Description: "Top Vertical Projection"
    static ForgeTypeId StructuralAnalyticalTessDeviation { get; }
      Description: "Maximum discretized offset"
    static ForgeTypeId StructuralAnalyticalTessellate { get; }
      Description: "Approximate curve"
    static ForgeTypeId StructuralAnalyzesAs { get; }
      Description: "Analyze As"
    static ForgeTypeId StructuralAssetParam { get; }
      Description: "Physical Material Asset"
    static ForgeTypeId StructuralAttachmentBaseDistance { get; }
      Description: "Base Attachment Distance"
    static ForgeTypeId StructuralAttachmentBaseRatio { get; }
      Description: "Base Attachment Ratio"
    static ForgeTypeId StructuralAttachmentBaseReferencedend { get; }
      Description: "Base Attachment Referenced End"
    static ForgeTypeId StructuralAttachmentBaseType { get; }
      Description: "Base Attachment Type"
    static ForgeTypeId StructuralAttachmentEndLevelReference { get; }
      Description: "End Attachment Level Reference"
    static ForgeTypeId StructuralAttachmentEndRefelementEnd { get; }
      Description: "End of Attachment to Reference Element"
    static ForgeTypeId StructuralAttachmentEndType { get; }
      Description: "End Attachment Type"
    static ForgeTypeId StructuralAttachmentEndValueDistance { get; }
      Description: "End Attachment Distance"
    static ForgeTypeId StructuralAttachmentEndValueElevation { get; }
      Description: "End Attachment Elevation"
    static ForgeTypeId StructuralAttachmentEndValueRatio { get; }
      Description: "End attachment ratio"
    static ForgeTypeId StructuralAttachmentStartLevelReference { get; }
      Description: "Start Attachment Level Reference"
    static ForgeTypeId StructuralAttachmentStartRefelementEnd { get; }
      Description: "Start of Attachment to Reference Element"
    static ForgeTypeId StructuralAttachmentStartType { get; }
      Description: "Start Attachment Type"
    static ForgeTypeId StructuralAttachmentStartValueDistance { get; }
      Description: "Start Attachment Distance"
    static ForgeTypeId StructuralAttachmentStartValueElevation { get; }
      Description: "Start Attachment Elevation"
    static ForgeTypeId StructuralAttachmentStartValueRatio { get; }
      Description: "Start Attachment Ratio"
    static ForgeTypeId StructuralAttachmentTopDistance { get; }
      Description: "Top Attachment Distance"
    static ForgeTypeId StructuralAttachmentTopRatio { get; }
      Description: "Top Attachment Ratio"
    static ForgeTypeId StructuralAttachmentTopReferencedend { get; }
      Description: "Top Attachment Referenced End"
    static ForgeTypeId StructuralAttachmentTopType { get; }
      Description: "Top Attachment Type"
    static ForgeTypeId StructuralBeamCutbackForColumn { get; }
      Description: "Beam cutback in plan"
    static ForgeTypeId StructuralBeamEnd0Elevation { get; }
      Description: "Start Level Offset"
    static ForgeTypeId StructuralBeamEnd1Elevation { get; }
      Description: "End Level Offset"
    static ForgeTypeId StructuralBeamEndAttachmentDistance { get; }
      Description: "End Attachment Distance"
    static ForgeTypeId StructuralBeamEndAttachmentRefcolumnEnd { get; }
      Description: "End of Attachment to Reference Column"
    static ForgeTypeId StructuralBeamEndAttachmentType { get; }
      Description: "End Attachment Type"
    static ForgeTypeId StructuralBeamEndSupport { get; }
      Description: "Beam End Pocket Seat"
    static ForgeTypeId StructuralBeamOrientation { get; }
      Description: "Orientation"
    static ForgeTypeId StructuralBeamStartAttachmentDistance { get; }
      Description: "Start Attachment Distance"
    static ForgeTypeId StructuralBeamStartAttachmentRefcolumnEnd { get; }
      Description: "Start of Attachment to Reference Column"
    static ForgeTypeId StructuralBeamStartAttachmentType { get; }
      Description: "Start Attachment Type"
    static ForgeTypeId StructuralBeamStartSupport { get; }
      Description: "Beam Start Pocket Seat"
    static ForgeTypeId StructuralBendDirAngle { get; }
      Description: "Cross-Section Rotation"
    static ForgeTypeId StructuralBottomReleaseFx { get; }
      Description: "Base Fx"
    static ForgeTypeId StructuralBottomReleaseFy { get; }
      Description: "Base Fy"
    static ForgeTypeId StructuralBottomReleaseFz { get; }
      Description: "Base Fz"
    static ForgeTypeId StructuralBottomReleaseMx { get; }
      Description: "Base Mx"
    static ForgeTypeId StructuralBottomReleaseMy { get; }
      Description: "Base My"
    static ForgeTypeId StructuralBottomReleaseMz { get; }
      Description: "Base Mz"
    static ForgeTypeId StructuralBottomReleaseType { get; }
      Description: "Base Release"
    static ForgeTypeId StructuralBraceRepresentation { get; }
      Description: "Representation Type"
    static ForgeTypeId StructuralCamber { get; }
      Description: "Camber Size"
    static ForgeTypeId StructuralConnectionApprovalStatus { get; }
      Description: "Approval Status"
    static ForgeTypeId StructuralConnectionCodeCheckingStatus { get; }
      Description: "Code Checking Status"
    static ForgeTypeId StructuralConnectionEditRangesOfApplicability { get; }
      Description: "Modify Ranges of applicability"
    static ForgeTypeId StructuralConnectionEditType { get; }
      Description: "Modify Parameters"
    static ForgeTypeId StructuralConnectionInputElements { get; }
      Description: "Input Elements"
    static ForgeTypeId StructuralConnectionModifyConnectionParameters { get; }
      Description: "Detailed Parameters"
    static ForgeTypeId StructuralConnectionNobleStatus { get; }
      Description: "Noble Status"
    static ForgeTypeId StructuralConnectionOverrideType { get; }
      Description: "Override by Instance"
    static ForgeTypeId StructuralConnectionSymbol { get; }
      Description: "Connection Symbol"
    static ForgeTypeId StructuralCopingDistance { get; }
      Description: "Coping Distance"
    static ForgeTypeId StructuralDisplayInHiddenViews { get; }
      Description: "Display in Hidden Views"
    static ForgeTypeId StructuralDisplayInHiddenViewsColumn { get; }
      Description: "Display in Hidden Views"
    static ForgeTypeId StructuralDisplayInHiddenViewsFraming { get; }
      Description: "Display in Hidden Views"
    static ForgeTypeId StructuralElevationAtBottom { get; }
      Description: "Elevation at Bottom"
    static ForgeTypeId StructuralElevationAtBottomCore { get; }
      Description: "Elevation at Bottom Core"
    static ForgeTypeId StructuralElevationAtBottomSurvey { get; }
      Description: "Elevation at Bottom Survey"
    static ForgeTypeId StructuralElevationAtTop { get; }
      Description: "Elevation at Top"
    static ForgeTypeId StructuralElevationAtTopCore { get; }
      Description: "Elevation at Top Core"
    static ForgeTypeId StructuralElevationAtTopSurvey { get; }
      Description: "Elevation at Top Survey"
    static ForgeTypeId StructuralEndReleaseFx { get; }
      Description: "End Fx"
    static ForgeTypeId StructuralEndReleaseFy { get; }
      Description: "End Fy"
    static ForgeTypeId StructuralEndReleaseFz { get; }
      Description: "End Fz"
    static ForgeTypeId StructuralEndReleaseMx { get; }
      Description: "End Mx"
    static ForgeTypeId StructuralEndReleaseMy { get; }
      Description: "End My"
    static ForgeTypeId StructuralEndReleaseMz { get; }
      Description: "End Mz"
    static ForgeTypeId StructuralEndReleaseType { get; }
      Description: "End Release"
    static ForgeTypeId StructuralFamilyCodeName { get; }
      Description: "Code Name"
    static ForgeTypeId StructuralFamilyNameKey { get; }
      Description: "Family Name Key"
    static ForgeTypeId StructuralFloorAnalyzesAs { get; }
      Description: "Analyze As"
    static ForgeTypeId StructuralFloorCoreThickness { get; }
      Description: "Core Thickness"
    static ForgeTypeId StructuralFoundationLength { get; }
      Description: "Length"
    static ForgeTypeId StructuralFoundationThickness { get; }
      Description: "Foundation Thickness"
    static ForgeTypeId StructuralFoundationWidth { get; }
      Description: "Width"
    static ForgeTypeId StructuralFrameCutLength { get; }
      Description: "Cut Length"
    static ForgeTypeId StructuralMaterialParam { get; }
      Description: "Structural Material"
    static ForgeTypeId StructuralMaterialType { get; }
      Description: "Structural Material Type"
    static ForgeTypeId StructuralMemberForces { get; }
      Description: "Member Forces"
    static ForgeTypeId StructuralNumberOfStuds { get; }
      Description: "Number of studs"
    static ForgeTypeId StructuralReferenceLevelElevation { get; }
      Description: "Reference Level Elevation"
    static ForgeTypeId StructuralSectionArea { get; }
      Description: "Section Area"
    static ForgeTypeId StructuralSectionBottomCutHeight { get; }
      Description: "Bottom Cut Height"
    static ForgeTypeId StructuralSectionBottomCutWidth { get; }
      Description: "Bottom Cut Width"
    static ForgeTypeId StructuralSectionCantileverHeight { get; }
      Description: "Cantilever Height"
    static ForgeTypeId StructuralSectionCantileverLength { get; }
      Description: "Cantilever Length"
    static ForgeTypeId StructuralSectionCommonAlpha { get; }
      Description: "Principal Axes Angle"
    static ForgeTypeId StructuralSectionCommonCentroidHoriz { get; }
      Description: "Centroid Horizontal"
    static ForgeTypeId StructuralSectionCommonCentroidVertical { get; }
      Description: "Centroid Vertical"
    static ForgeTypeId StructuralSectionCommonDiameter { get; }
      Description: "Diameter"
    static ForgeTypeId StructuralSectionCommonElasticModulusStrongAxis { get; }
      Description: "Elastic Modulus strong axis"
    static ForgeTypeId StructuralSectionCommonElasticModulusWeakAxis { get; }
      Description: "Elastic Modulus weak axis"
    static ForgeTypeId StructuralSectionCommonHeight { get; }
      Description: "Height"
    static ForgeTypeId StructuralSectionCommonMomentOfInertiaStrongAxis { get; }
      Description: "Moment of Inertia strong axis"
    static ForgeTypeId StructuralSectionCommonMomentOfInertiaWeakAxis { get; }
      Description: "Moment of Inertia weak axis"
    static ForgeTypeId StructuralSectionCommonNominalWeight { get; }
      Description: "Nominal Weight"
    static ForgeTypeId StructuralSectionCommonPerimeter { get; }
      Description: "Perimeter"
    static ForgeTypeId StructuralSectionCommonPlasticModulusStrongAxis { get; }
      Description: "Plastic Modulus strong axis"
    static ForgeTypeId StructuralSectionCommonPlasticModulusWeakAxis { get; }
      Description: "Plastic Modulus weak axis"
    static ForgeTypeId StructuralSectionCommonShearAreaStrongAxis { get; }
      Description: "Shear Area strong axis"
    static ForgeTypeId StructuralSectionCommonShearAreaWeakAxis { get; }
      Description: "Shear Area weak axis"
    static ForgeTypeId StructuralSectionCommonTorsionalModulus { get; }
      Description: "Torsional Modulus"
    static ForgeTypeId StructuralSectionCommonTorsionalMomentOfInertia { get; }
      Description: "Torsional Moment of Inertia"
    static ForgeTypeId StructuralSectionCommonWarpingConstant { get; }
      Description: "Warping Constant"
    static ForgeTypeId StructuralSectionCommonWidth { get; }
      Description: "Width"
    static ForgeTypeId StructuralSectionCprofileFoldLength { get; }
      Description: "Fold Length"
    static ForgeTypeId StructuralSectionHssInnerfillet { get; }
      Description: "Inner Fillet"
    static ForgeTypeId StructuralSectionHssOuterfillet { get; }
      Description: "Outer Fillet"
    static ForgeTypeId StructuralSectionIshapeBoltDiameter { get; }
      Description: "Bolt Diameter"
    static ForgeTypeId StructuralSectionIshapeBoltSpacing { get; }
      Description: "Bolt Spacing"
    static ForgeTypeId StructuralSectionIshapeBoltSpacingBetweenRows { get; }
      Description: "Bolt Spacing between Rows"
    static ForgeTypeId StructuralSectionIshapeBoltSpacingTwoRows { get; }
      Description: "Bolt Spacing Two Rows"
    static ForgeTypeId StructuralSectionIshapeBoltSpacingWeb { get; }
      Description: "Bolt Spacing web"
    static ForgeTypeId StructuralSectionIshapeClearWebHeight { get; }
      Description: "Clear Web Height"
    static ForgeTypeId StructuralSectionIshapeFlangefillet { get; }
      Description: "Flange Fillet"
    static ForgeTypeId StructuralSectionIshapeFlangethickness { get; }
      Description: "Flange Thickness"
    static ForgeTypeId StructuralSectionIshapeFlangethicknessLocation { get; }
      Description: "Flange Thickness Location"
    static ForgeTypeId StructuralSectionIshapeFlangeToeOfFillet { get; }
      Description: "Flange Toe of Fillet"
    static ForgeTypeId StructuralSectionIshapeWebfillet { get; }
      Description: "Web Fillet"
    static ForgeTypeId StructuralSectionIshapeWebheight { get; }
      Description: "Web Height"
    static ForgeTypeId StructuralSectionIshapeWebthickness { get; }
      Description: "Web Thickness"
    static ForgeTypeId StructuralSectionIshapeWebthicknessLocation { get; }
      Description: "Web Thickness Location"
    static ForgeTypeId StructuralSectionIshapeWebToeOfFillet { get; }
      Description: "Web Toe of Fillet"
    static ForgeTypeId StructuralSectionIweldedBottomflangethickness { get; }
      Description: "Bottom Flange Thickness"
    static ForgeTypeId StructuralSectionIweldedBottomflangewidth { get; }
      Description: "Bottom Flange Width"
    static ForgeTypeId StructuralSectionIweldedTopflangethickness { get; }
      Description: "Top Flange Thickness"
    static ForgeTypeId StructuralSectionIweldedTopflangewidth { get; }
      Description: "Top Flange Width"
    static ForgeTypeId StructuralSectionLangleBoltDiameterLongerFlange { get; }
      Description: "Bolt Diameter Longer Flange"
    static ForgeTypeId StructuralSectionLangleBoltDiameterShorterFlange { get; }
      Description: "Bolt Diameter Shorter Flange"
    static ForgeTypeId StructuralSectionLangleBoltSpacing1LongerFlange { get; }
      Description: "Bolt Spacing 1 Longer Flange"
    static ForgeTypeId StructuralSectionLangleBoltSpacing2LongerFlange { get; }
      Description: "Bolt Spacing 2 Longer Flange"
    static ForgeTypeId StructuralSectionLangleBoltSpacingShorterFlange { get; }
      Description: "Bolt Spacing Shorter Flange"
    static ForgeTypeId StructuralSectionLprofileLipLength { get; }
      Description: "Lip Length"
    static ForgeTypeId StructuralSectionNameKey { get; }
      Description: "Section Name Key"
    static ForgeTypeId StructuralSectionPipestandardWalldesignthickness { get; }
      Description: "Wall Design Thickness"
    static ForgeTypeId StructuralSectionPipestandardWallnominalthickness { get; }
      Description: "Wall Nominal Thickness"
    static ForgeTypeId StructuralSectionShape { get; }
      Description: "Section Shape"
    static ForgeTypeId StructuralSectionSigmaProfileBendWidth { get; }
      Description: "Bend Width"
    static ForgeTypeId StructuralSectionSigmaProfileMiddleBendWidth { get; }
      Description: "Middle Bend Length"
    static ForgeTypeId StructuralSectionSigmaProfileTopBendWidth { get; }
      Description: "Top Bend Length"
    static ForgeTypeId StructuralSectionSlopedFlangeAngle { get; }
      Description: "Sloped Flange Angle"
    static ForgeTypeId StructuralSectionSlopedWebAngle { get; }
      Description: "Sloped Web Angle"
    static ForgeTypeId StructuralSectionTopCutHeight { get; }
      Description: "Top Cut Height"
    static ForgeTypeId StructuralSectionTopCutWidth { get; }
      Description: "Top Cut Width"
    static ForgeTypeId StructuralSectionTopWebFillet { get; }
      Description: "Top Web Fillet"
    static ForgeTypeId StructuralSectionZprofileBottomFlangeLength { get; }
      Description: "Bottom Flange Length"
    static ForgeTypeId StructuralStartReleaseFx { get; }
      Description: "Start Fx"
    static ForgeTypeId StructuralStartReleaseFy { get; }
      Description: "Start Fy"
    static ForgeTypeId StructuralStartReleaseFz { get; }
      Description: "Start Fz"
    static ForgeTypeId StructuralStartReleaseMx { get; }
      Description: "Start Mx"
    static ForgeTypeId StructuralStartReleaseMy { get; }
      Description: "Start My"
    static ForgeTypeId StructuralStartReleaseMz { get; }
      Description: "Start Mz"
    static ForgeTypeId StructuralStartReleaseType { get; }
      Description: "Start Release"
    static ForgeTypeId StructuralStickSymbolLocation { get; }
      Description: "Stick Symbol Location"
    static ForgeTypeId StructuralTopReleaseFx { get; }
      Description: "Top Fx"
    static ForgeTypeId StructuralTopReleaseFy { get; }
      Description: "Top Fy"
    static ForgeTypeId StructuralTopReleaseFz { get; }
      Description: "Top Fz"
    static ForgeTypeId StructuralTopReleaseMx { get; }
      Description: "Top Mx"
    static ForgeTypeId StructuralTopReleaseMy { get; }
      Description: "Top My"
    static ForgeTypeId StructuralTopReleaseMz { get; }
      Description: "Top Mz"
    static ForgeTypeId StructuralTopReleaseType { get; }
      Description: "Top Release"
    static ForgeTypeId StructuralWallBottomProjectionPlane { get; }
      Description: "Bottom Vertical Projection"
    static ForgeTypeId StructuralWallProjectionSurface { get; }
      Description: "Horizontal Projection"
    static ForgeTypeId StructuralWallTopProjectionPlane { get; }
      Description: "Top Vertical Projection"
    static ForgeTypeId SupportHandClearance { get; }
      Description: "Hand Clearance"
    static ForgeTypeId SupportHeight { get; }
      Description: "Height"
    static ForgeTypeId SurfaceArea { get; }
      Description: "Surface Area"
    static ForgeTypeId SurfaceName { get; }
      Description: "Name"
    static ForgeTypeId SurfacePatternIdParam { get; }
      Description: "Surface fill pattern"
    static ForgeTypeId SurfacePerimeter { get; }
      Description: "Perimeter"
    static ForgeTypeId SweepBaseFloorSubcategoryId { get; }
      Description: "Subcategory of Floors"
    static ForgeTypeId SweepBaseOffset { get; }
      Description: "Horizontal Profile Offset"
    static ForgeTypeId SweepBaseRoofSubcategoryId { get; }
      Description: "Subcategory of Roofs"
    static ForgeTypeId SweepBaseVertOffset { get; }
      Description: "Vertical Profile Offset"
    static ForgeTypeId SweepMaxSegAngle { get; }
      Description: "Maximum Segment Angle"
    static ForgeTypeId SweepTrajSegmented { get; }
      Description: "Trajectory Segmentation"
    static ForgeTypeId SymbolFamilyAndTypeNamesParam { get; }
      Description: "Family and Type"
    static ForgeTypeId SymbolFamilyNameParam { get; }
      Description: "Family Name"
    static ForgeTypeId SymbolIdParam { get; }
      Description: "Type Id"
    static ForgeTypeId SymbolNameParam { get; }
      Description: "Type Name"
    static ForgeTypeId SystemEquipmentSets { get; }
      Description: "Equipment Sets"
    static ForgeTypeId SystemsAnalysisReportFolder { get; }
      Description: "Reports Folder Path"
    static ForgeTypeId SystemsAnalysisReportStyle { get; }
      Description: "Report Style"
    static ForgeTypeId SystemZoneLevelId { get; }
      Description: "Level"
    static ForgeTypeId TagAngleParam { get; }
      Description: "Angle"
    static ForgeTypeId TagElementCount { get; }
      Description: "Host Count"
    static ForgeTypeId TagElevationBase { get; }
      Description: "Elevation Base"
    static ForgeTypeId TagHeadAlignment { get; }
      Description: "Tag Alignment"
    static ForgeTypeId TagHeadPosition { get; }
      Description: "Tag Position"
    static ForgeTypeId TagLeaderType { get; }
      Description: "Leader Type"
    static ForgeTypeId TagNoBreakParamStrings { get; }
      Description: "Wrap between parameters only"
    static ForgeTypeId TagOnPlacementUi { get; }
      Description: "Tag on Placement"
    static ForgeTypeId TagOrientationBehavior { get; }
      Description: "Tag Orientation"
    static ForgeTypeId TagOrientationParam { get; }
      Description: "Orientation"
    static ForgeTypeId TagSampleText { get; }
      Description: "Sample Text"
    static ForgeTypeId TagTag { get; }
      Description: "Label"
    static ForgeTypeId TemplateName { get; }
      Description: "Template"
    static ForgeTypeId TerminationExtensionLength { get; }
      Description: "Extension Length"
    static ForgeTypeId TextAlignHorz { get; }
      Description: "Horizontal Align"
    static ForgeTypeId TextAlignment { get; }
      Description: "Text Alignment"
    static ForgeTypeId TextAlignVert { get; }
      Description: "Vertical Align"
    static ForgeTypeId TextBackground { get; }
      Description: "Background"
    static ForgeTypeId TextBoxVisibility { get; }
      Description: "Show Border"
    static ForgeTypeId TextColor { get; }
      Description: "Color"
    static ForgeTypeId TextDistToLine { get; }
      Description: "Text Offset"
    static ForgeTypeId TextFont { get; }
      Description: "Text Font"
    static ForgeTypeId TextPosition { get; }
      Description: "Text Position"
    static ForgeTypeId TextSize { get; }
      Description: "Text Size"
    static ForgeTypeId TextStyleBold { get; }
      Description: "Bold"
    static ForgeTypeId TextStyleFont { get; }
      Description: "Font"
    static ForgeTypeId TextStyleItalic { get; }
      Description: "Italic"
    static ForgeTypeId TextStyleSize { get; }
      Description: "Size"
    static ForgeTypeId TextStyleUnderline { get; }
      Description: "Underline"
    static ForgeTypeId TextTabSize { get; }
      Description: "Tab Size"
    static ForgeTypeId TextText { get; }
      Description: "Text"
    static ForgeTypeId TextWidthScale { get; }
      Description: "Width Factor"
    static ForgeTypeId ThermalMaterialConductivity { get; }
      Description: "Thermal Conductivity"
    static ForgeTypeId ThermalMaterialDensity { get; }
      Description: "Density"
    static ForgeTypeId ThermalMaterialDescription { get; }
      Description: "Description"
    static ForgeTypeId ThermalMaterialName { get; }
      Description: "Name"
    static ForgeTypeId ThermalMaterialParamCompressibility { get; }
      Description: "Compressibility"
    static ForgeTypeId ThermalMaterialParamElectricalResistivity { get; }
      Description: "Electrical Resistivity"
    static ForgeTypeId ThermalMaterialParamEmissivity { get; }
      Description: "Emissivity"
    static ForgeTypeId ThermalMaterialParamGasViscosity { get; }
      Description: "Gas Viscosity"
    static ForgeTypeId ThermalMaterialParamLiquidViscosity { get; }
      Description: "Liquid Viscosity"
    static ForgeTypeId ThermalMaterialParamPermeability { get; }
      Description: "Permeability"
    static ForgeTypeId ThermalMaterialParamPorosity { get; }
      Description: "Porosity"
    static ForgeTypeId ThermalMaterialParamReflectivity { get; }
      Description: "Reflectivity"
    static ForgeTypeId ThermalMaterialParamSpecificHeatOfVaporization { get; }
      Description: "Specific Heat of Vaporization"
    static ForgeTypeId ThermalMaterialParamTransmitsLight { get; }
      Description: "Transmits Light"
    static ForgeTypeId ThermalMaterialParamVaporPressure { get; }
      Description: "Vapor Pressure"
    static ForgeTypeId ThermalMaterialSpecificHeatCapacity { get; }
      Description: "Specific Heat Capacity"
    static ForgeTypeId ThermalMaterialThickness { get; }
      Description: "Thickness"
    static ForgeTypeId TickMarkPen { get; }
      Description: "Tick Mark Line Weight"
    static ForgeTypeId TilePatternFamrefComponentExtents { get; }
      Description: "Component Extents"
    static ForgeTypeId TilePatternGridCellsX { get; }
      Description: "Number of horizontal cells"
    static ForgeTypeId TilePatternGridCellsY { get; }
      Description: "Number of vertical cells"
    static ForgeTypeId TilePatternGridUnitX { get; }
      Description: "Horizontal spacing"
    static ForgeTypeId TilePatternGridUnitY { get; }
      Description: "Vertical spacing"
    static ForgeTypeId Tilt { get; }
      Description: "Tilt"
    static ForgeTypeId TitleFont { get; }
      Description: "Font"
    static ForgeTypeId TitleSize { get; }
      Description: "Size"
    static ForgeTypeId TitleStyleBold { get; }
      Description: "Bold"
    static ForgeTypeId TitleStyleItalic { get; }
      Description: "Italic"
    static ForgeTypeId TitleStyleUnderline { get; }
      Description: "Underline"
    static ForgeTypeId TopographyLinkName { get; }
      Description: "Link Name"
    static ForgeTypeId TopographyLinkPath { get; }
      Description: "Saved Path"
    static ForgeTypeId ToposolidAttrThicknessParam { get; }
      Description: "Thickness"
    static ForgeTypeId ToposolidContourDisplaySettingsIdParam { get; }
      Description: "Contour Display"
    static ForgeTypeId ToposolidContourSubcategoryId { get; }
      Description: "Subcategory"
    static ForgeTypeId ToposolidElevationAtBottom { get; }
      Description: "Elevation at Bottom"
    static ForgeTypeId ToposolidElevationAtTop { get; }
      Description: "Elevation at Top"
    static ForgeTypeId ToposolidFacesLocation { get; }
      Description: "Picked Faces Location"
    static ForgeTypeId ToposolidFunctionParam { get; }
      Description: "Function"
    static ForgeTypeId ToposolidHeightabovelevelParam { get; }
      Description: "Height Offset From Level"
    static ForgeTypeId ToposolidInheritContours { get; }
      Description: "Inherit Contours"
    static ForgeTypeId ToposolidStructureIdParam { get; }
      Description: "Structure"
    static ForgeTypeId ToposolidSubdivideHeight { get; }
      Description: "Sub-divide Height"
    static ForgeTypeId ToposolidSubdivideMaterial { get; }
      Description: "Material"
    static ForgeTypeId ToposolidTypeDefaultThicknessParam { get; }
      Description: "Default Thickness"
    static ForgeTypeId ToposurfaceContourSubcategoryId { get; }
      Description: "Subcategory"
    static ForgeTypeId TotalExcavationVolume { get; }
      Description: "Total Excavation Volume"
    static ForgeTypeId TrapMullWidth { get; }
      Description: "Center Width"
    static ForgeTypeId TrussBearingChordTopBottomParam { get; }
      Description: "Bearing Chord"
    static ForgeTypeId TrussElementAngleParam { get; }
      Description: "Rotation Angle"
    static ForgeTypeId TrussElementBearingJustParam { get; }
      Description: "Bearing Vertical Justification"
    static ForgeTypeId TrussElementClassParam { get; }
      Description: "Engineering Type"
    static ForgeTypeId TrussElementCreateBottomParam { get; }
      Description: "Create Bottom Chord"
    static ForgeTypeId TrussElementCreateTopParam { get; }
      Description: "Create Top Chord"
    static ForgeTypeId TrussElementEnd0Elevation { get; }
      Description: "Start Level Offset"
    static ForgeTypeId TrussElementEnd1Elevation { get; }
      Description: "End Level Offset"
    static ForgeTypeId TrussElementReferenceLevelParam { get; }
      Description: "Reference Level"
    static ForgeTypeId TrussElementRotateChordsWithTruss { get; }
      Description: "Rotate Chords With Truss"
    static ForgeTypeId TrussElementSpanParam { get; }
      Description: "Span"
    static ForgeTypeId TrussElementStickJustParam { get; }
      Description: "Stick Symbol Location"
    static ForgeTypeId TrussElementTagNewMembersView { get; }
      Description: "Tag new members in view"
    static ForgeTypeId TrussFamilyBottomChordAngleParam { get; }
      Description: "Angle"
    static ForgeTypeId TrussFamilyBottomChordEndReleaseType { get; }
      Description: "End Release"
    static ForgeTypeId TrussFamilyBottomChordStartReleaseType { get; }
      Description: "Start Release"
    static ForgeTypeId TrussFamilyBottomChordStructuralTypesParam { get; }
      Description: "Structural Framing Type"
    static ForgeTypeId TrussFamilyBottomChordVerticalProjectionParam { get; }
      Description: "Analytical Vertical Projection"
    static ForgeTypeId TrussFamilyDiagWebAngleParam { get; }
      Description: "Angle"
    static ForgeTypeId TrussFamilyDiagWebEndReleaseType { get; }
      Description: "End Release"
    static ForgeTypeId TrussFamilyDiagWebStartReleaseType { get; }
      Description: "Start Release"
    static ForgeTypeId TrussFamilyDiagWebStructuralTypesParam { get; }
      Description: "Structural Framing Type"
    static ForgeTypeId TrussFamilyTopChordAngleParam { get; }
      Description: "Angle"
    static ForgeTypeId TrussFamilyTopChordEndReleaseType { get; }
      Description: "End Release"
    static ForgeTypeId TrussFamilyTopChordStartReleaseType { get; }
      Description: "Start Release"
    static ForgeTypeId TrussFamilyTopChordStructuralTypesParam { get; }
      Description: "Structural Framing Type"
    static ForgeTypeId TrussFamilyTopChordVerticalProjectionParam { get; }
      Description: "Analytical Vertical Projection"
    static ForgeTypeId TrussFamilyTransformationParam { get; }
      Description: "Web Orientation"
    static ForgeTypeId TrussFamilyVertWebAngleParam { get; }
      Description: "Angle"
    static ForgeTypeId TrussFamilyVertWebEndReleaseType { get; }
      Description: "End Release"
    static ForgeTypeId TrussFamilyVertWebStartReleaseType { get; }
      Description: "Start Release"
    static ForgeTypeId TrussFamilyVertWebStructuralTypesParam { get; }
      Description: "Structural Framing Type"
    static ForgeTypeId TrussFamilyWebsHaveSymbolicCutbackParam { get; }
      Description: "Webs have symbolic cutback"
    static ForgeTypeId TrussHeight { get; }
      Description: "Truss Height"
    static ForgeTypeId TrussLength { get; }
      Description: "Truss Length"
    static ForgeTypeId TrussNonBearingOffsetParam { get; }
      Description: "Non Bearing Offset"
    static ForgeTypeId TypeWallClosure { get; }
      Description: "Wall Closure"
    static ForgeTypeId UniformatCode { get; }
      Description: "Assembly Code"
    static ForgeTypeId UniformatDescription { get; }
      Description: "Assembly Description"
    static ForgeTypeId Use3dSnapping { get; }
      Description: "3D Snapping"
    static ForgeTypeId UsingMultiple { get; }
      Description: "Multiple Join"
    static ForgeTypeId ViewAnalysisDisplayStyle { get; }
      Description: "Default Analysis Display Style"
    static ForgeTypeId ViewAnalysisResultsVisibility { get; }
      Description: "Analysis Display Settings"
    static ForgeTypeId ViewAssociatedAssemblyInstanceId { get; }
      Description: "Associated Assembly Instance"
    static ForgeTypeId ViewBackClipping { get; }
      Description: "Depth Clipping"
    static ForgeTypeId ViewCameraOrientation { get; }
      Description: "Locked Orientation"
    static ForgeTypeId ViewCameraPosition { get; }
      Description: "Camera Position"
    static ForgeTypeId ViewCleanJoins { get; }
      Description: "Wall Join Display"
    static ForgeTypeId ViewDependency { get; }
      Description: "Dependency"
    static ForgeTypeId ViewDepth { get; }
      Description: "View Depth"
    static ForgeTypeId ViewDescription { get; }
      Description: "Title on Sheet"
    static ForgeTypeId ViewDesignOptionsConfig { get; }
      Description: "Design Option Configuration"
    static ForgeTypeId ViewDetailLevel { get; }
      Description: "Detail Level"
    static ForgeTypeId ViewDiscipline { get; }
      Description: "Discipline"
    static ForgeTypeId Viewer3dRenderSettings { get; }
      Description: "Rendering Settings"
    static ForgeTypeId ViewerAnnotationCropActive { get; }
      Description: "Annotation Crop"
    static ForgeTypeId ViewerBoundActiveBottom { get; }
      Description: "Bottom Clip Active"
    static ForgeTypeId ViewerBoundActiveFar { get; }
      Description: "Far Clip Active"
    static ForgeTypeId ViewerBoundActiveLeft { get; }
      Description: "Left Clip Active"
    static ForgeTypeId ViewerBoundActiveNear { get; }
      Description: "Near Clip Active"
    static ForgeTypeId ViewerBoundActiveRight { get; }
      Description: "Right Clip Active"
    static ForgeTypeId ViewerBoundActiveTop { get; }
      Description: "Top Clip Active"
    static ForgeTypeId ViewerBoundFarClipping { get; }
      Description: "Far Clipping"
    static ForgeTypeId ViewerBoundOffsetBottom { get; }
      Description: "Bottom Clip Offset"
    static ForgeTypeId ViewerBoundOffsetFar { get; }
      Description: "Far Clip Offset"
    static ForgeTypeId ViewerBoundOffsetLeft { get; }
      Description: "Left Clip Offset"
    static ForgeTypeId ViewerBoundOffsetNear { get; }
      Description: "Near Clip Offset"
    static ForgeTypeId ViewerBoundOffsetRight { get; }
      Description: "Right Clip Offset"
    static ForgeTypeId ViewerBoundOffsetTop { get; }
      Description: "Top Clip Offset"
    static ForgeTypeId ViewerCropRegion { get; }
      Description: "Crop View"
    static ForgeTypeId ViewerCropRegionDisabled { get; }
      Description: "Crop View"
    static ForgeTypeId ViewerCropRegionVisible { get; }
      Description: "Crop Region Visible"
    static ForgeTypeId ViewerDetailNumber { get; }
      Description: "Detail Number"
    static ForgeTypeId ViewerEyeElevation { get; }
      Description: "Eye Elevation"
    static ForgeTypeId ViewerIsReference { get; }
      Description: "Is a Reference"
    static ForgeTypeId ViewerModelClipBoxActive { get; }
      Description: "Section Box"
    static ForgeTypeId ViewerOptionVisibility { get; }
      Description: "Visible In Option"
    static ForgeTypeId ViewerPerspective { get; }
      Description: "Projection Mode"
    static ForgeTypeId ViewerReferenceLabel { get; }
      Description: "Reference Label"
    static ForgeTypeId ViewerReferenceLabelText { get; }
      Description: "Reference Label"
    static ForgeTypeId ViewerSheetCollection { get; }
      Description: "Sheet Collection"
    static ForgeTypeId ViewerSheetName { get; }
      Description: "Sheet Name"
    static ForgeTypeId ViewerSheetNumber { get; }
      Description: "Sheet Number"
    static ForgeTypeId ViewerShowUncropped { get; }
      Description: "Show uncropped"
    static ForgeTypeId ViewerTargetElevation { get; }
      Description: "Target Elevation"
    static ForgeTypeId ViewerVolumeOfInterestCrop { get; }
      Description: "Scope Box"
    static ForgeTypeId ViewFamily { get; }
      Description: "Family"
    static ForgeTypeId ViewFamilyAndTypeSchedules { get; }
      Description: "Family and Type"
    static ForgeTypeId ViewFamilySchedules { get; }
      Description: "Family"
    static ForgeTypeId ViewFixedSketchPlane { get; }
      Description: "None"
    static ForgeTypeId ViewGraphSchedBottomLevel { get; }
      Description: "Bottom Level"
    static ForgeTypeId ViewGraphSchedGridAppearance { get; }
      Description: "Grid Appearance"
    static ForgeTypeId ViewGraphSchedGroupSimilar { get; }
      Description: "Group Similar Locations"
    static ForgeTypeId ViewGraphSchedHiddenLevels { get; }
      Description: "Hidden Levels"
    static ForgeTypeId ViewGraphSchedLevelRelativeBaseType { get; }
      Description: "Elevation Base for Levels"
    static ForgeTypeId ViewGraphSchedLocationsHigh { get; }
      Description: "Column Locations End"
    static ForgeTypeId ViewGraphSchedLocationsLow { get; }
      Description: "Column Locations Start"
    static ForgeTypeId ViewGraphSchedMaterialTypes { get; }
      Description: "Material Types"
    static ForgeTypeId ViewGraphSchedNumberColumns { get; }
      Description: "Column Locations per Segment"
    static ForgeTypeId ViewGraphSchedOffGrid { get; }
      Description: "Include Off-Grid Columns"
    static ForgeTypeId ViewGraphSchedRowsCount { get; }
      Description: "Segments in Viewport"
    static ForgeTypeId ViewGraphSchedRowsFrom { get; }
      Description: "Segment Start in Viewport"
    static ForgeTypeId ViewGraphSchedTextAppearance { get; }
      Description: "Text Appearance"
    static ForgeTypeId ViewGraphSchedTitle { get; }
      Description: "Title"
    static ForgeTypeId ViewGraphSchedTopLevel { get; }
      Description: "Top Level"
    static ForgeTypeId ViewGraphSchedTotalColumns { get; }
      Description: "Total Column Locations"
    static ForgeTypeId ViewGraphSchedTotalRows { get; }
      Description: "Total Segments"
    static ForgeTypeId ViewGraphSchedUnitsFormat { get; }
      Description: "Off-Grid Units Format"
    static ForgeTypeId ViewGraphSunPath { get; }
      Description: "Sun Path"
    static ForgeTypeId ViewGraphSunPathSize { get; }
      Description: "Sun path size (%)"
    static ForgeTypeId ViewModelDisplayMode { get; }
      Description: "Display Model"
    static ForgeTypeId ViewName { get; }
      Description: "View Name"
    static ForgeTypeId ViewPartsVisibility { get; }
      Description: "Parts Visibility"
    static ForgeTypeId ViewPhase { get; }
      Description: "Phase"
    static ForgeTypeId ViewPhaseFilter { get; }
      Description: "Phase Filter"
    static ForgeTypeId ViewportAttrLabelTag { get; }
      Description: "Title"
    static ForgeTypeId ViewportAttrOrientationOnSheet { get; }
      Description: "Rotation on Sheet"
    static ForgeTypeId ViewportAttrPreserveTitlePosition { get; }
      Description: "Preserve Title Position"
    static ForgeTypeId ViewportAttrShowBox { get; }
      Description: "Show Box"
    static ForgeTypeId ViewportAttrShowExtensionLine { get; }
      Description: "Show Extension Line"
    static ForgeTypeId ViewportAttrShowLabel { get; }
      Description: "Show Title"
    static ForgeTypeId ViewportDetailNumber { get; }
      Description: "Detail Number"
    static ForgeTypeId ViewportPositioning { get; }
      Description: "Viewport Positioning"
    static ForgeTypeId ViewportScale { get; }
      Description: "View Scale"
    static ForgeTypeId ViewportSheetCollection { get; }
      Description: "Sheet Collection"
    static ForgeTypeId ViewportSheetName { get; }
      Description: "Sheet Name"
    static ForgeTypeId ViewportSheetNumber { get; }
      Description: "Sheet Number"
    static ForgeTypeId ViewportView { get; }
      Description: "View"
    static ForgeTypeId ViewportViewName { get; }
      Description: "View Name"
    static ForgeTypeId ViewReferencingDetail { get; }
      Description: "Referencing Detail"
    static ForgeTypeId ViewReferencingSheet { get; }
      Description: "Referencing Sheet"
    static ForgeTypeId ViewReferencingSheetCollection { get; }
      Description: "Referencing Sheet Collection"
    static ForgeTypeId ViewScale { get; }
      Description: "Scale Value 1:"
    static ForgeTypeId ViewScaleCustomname { get; }
      Description: "Display Name"
    static ForgeTypeId ViewScaleHavename { get; }
      Description: "Display Name"
    static ForgeTypeId ViewScalePulldownImperial { get; }
      Description: "View Scale"
    static ForgeTypeId ViewScalePulldownMetric { get; }
      Description: "View Scale"
    static ForgeTypeId ViewSchemaSettingForBuilding { get; }
      Description: "Color Scheme"
    static ForgeTypeId ViewSchemaSettingForSystem { get; }
      Description: "System Color Schemes"
    static ForgeTypeId ViewSchemaSettingForSystemTemplate { get; }
      Description: "System Color Schemes"
    static ForgeTypeId ViewSheetViewportInfo { get; }
      Description: "Viewport"
    static ForgeTypeId ViewShowGrids { get; }
      Description: "Show Grids"
    static ForgeTypeId ViewShowHiddenLines { get; }
      Description: "Show Hidden Lines"
    static ForgeTypeId ViewShowMassing { get; }
      Description: "Show Mass"
    static ForgeTypeId ViewSlantedColumnSymbolOffset { get; }
      Description: "Column Symbolic Offset"
    static ForgeTypeId ViewSolarstudyAnimationSpeedText { get; }
      Description: "Loop animation speed"
    static ForgeTypeId ViewSolarstudyAnimationSpeedValue { get; }
      Description: "Loop animation speed"
    static ForgeTypeId ViewSolarstudyCurrentStudyTypeIndex { get; }
      Description: "Study type"
    static ForgeTypeId ViewSolarstudyIsLightingStudyType { get; }
      Description: "Lighting study"
    static ForgeTypeId ViewSolarstudyIsMultidayStudyType { get; }
      Description: "Multi-day study"
    static ForgeTypeId ViewSolarstudyIsSingledayStudyType { get; }
      Description: "Single day study"
    static ForgeTypeId ViewSolarstudyIsStillimageStudyType { get; }
      Description: "Still image study"
    static ForgeTypeId ViewSolarstudyLightingAltitudeText { get; }
      Description: "Lighting altitude text"
    static ForgeTypeId ViewSolarstudyLightingAltitudeValue { get; }
      Description: "Lighting altitude"
    static ForgeTypeId ViewSolarstudyLightingAzimuthText { get; }
      Description: "Lighting azimuth text"
    static ForgeTypeId ViewSolarstudyLightingAzimuthValue { get; }
      Description: "Lighting azimuth"
    static ForgeTypeId ViewSolarstudyLightingPresetIndex { get; }
      Description: "Lighting presets combo"
    static ForgeTypeId ViewSolarstudyMultidayDatetimeText { get; }
      Description: "Multi-day date and time text"
    static ForgeTypeId ViewSolarstudyMultidayFrameText { get; }
      Description: "Multi-day frame text"
    static ForgeTypeId ViewSolarstudyMultidayFrameValue { get; }
      Description: "Multi-day frame"
    static ForgeTypeId ViewSolarstudyMultidayPresetIndex { get; }
      Description: "Multi-day presets combo"
    static ForgeTypeId ViewSolarstudyShadowsIntensityText { get; }
      Description: "Shadows intensity text"
    static ForgeTypeId ViewSolarstudyShadowsIntensityValue { get; }
      Description: "Shadows intensity"
    static ForgeTypeId ViewSolarstudySingledayDatetimeText { get; }
      Description: "Single day date and time text"
    static ForgeTypeId ViewSolarstudySingledayFrameText { get; }
      Description: "Single day frame text"
    static ForgeTypeId ViewSolarstudySingledayFrameValue { get; }
      Description: "Single day frame"
    static ForgeTypeId ViewSolarstudySingledayPresetIndex { get; }
      Description: "Single day presets combo"
    static ForgeTypeId ViewSolarstudyStillDateText { get; }
      Description: "Still date text"
    static ForgeTypeId ViewSolarstudyStillDateValue { get; }
      Description: "Still date"
    static ForgeTypeId ViewSolarstudyStillPresetIndex { get; }
      Description: "Still presets combo"
    static ForgeTypeId ViewSolarstudyStillTimeText { get; }
      Description: "Still time text"
    static ForgeTypeId ViewSolarstudyStillTimeValue { get; }
      Description: "Still time"
    static ForgeTypeId ViewSolarstudySunIntensityText { get; }
      Description: "Sun intensity text"
    static ForgeTypeId ViewSolarstudySunIntensityValue { get; }
      Description: "Sun intensity"
    static ForgeTypeId ViewTemplate { get; }
      Description: "View Template"
    static ForgeTypeId ViewTemplateForSchedule { get; }
      Description: "View Template"
    static ForgeTypeId ViewType { get; }
      Description: "Family and Type"
    static ForgeTypeId ViewTypeSchedules { get; }
      Description: "Type"
    static ForgeTypeId ViewUnderlayBottomId { get; }
      Description: "Range: Base Level"
    static ForgeTypeId ViewUnderlayOrientation { get; }
      Description: "Underlay Orientation"
    static ForgeTypeId ViewUnderlayTopId { get; }
      Description: "Range: Top Level"
    static ForgeTypeId ViewVisibleCategories { get; }
      Description: "Visibility/Graphics Overrides"
    static ForgeTypeId VisGraphicsAnalyticalModel { get; }
      Description: "V/G Overrides Analytical Model"
    static ForgeTypeId VisGraphicsAnnotation { get; }
      Description: "V/G Overrides Annotation"
    static ForgeTypeId VisGraphicsCoordinationModel { get; }
      Description: "V/G Overrides Coordination Model"
    static ForgeTypeId VisGraphicsDesignoptions { get; }
      Description: "V/G Overrides Design Options"
    static ForgeTypeId VisGraphicsFilters { get; }
      Description: "V/G Overrides Filters"
    static ForgeTypeId VisGraphicsImport { get; }
      Description: "V/G Overrides Import"
    static ForgeTypeId VisGraphicsModel { get; }
      Description: "V/G Overrides Model"
    static ForgeTypeId VisGraphicsPointClouds { get; }
      Description: "V/G Overrides Point Clouds"
    static ForgeTypeId VisGraphicsRvtLinks { get; }
      Description: "V/G Overrides RVT Links"
    static ForgeTypeId VisGraphicsWorksets { get; }
      Description: "V/G Overrides Worksets"
    static ForgeTypeId VoidCutsGeometry { get; }
      Description: "Cuts Geometry"
    static ForgeTypeId VolumeCut { get; }
      Description: "Cut"
    static ForgeTypeId VolumeFill { get; }
      Description: "Fill"
    static ForgeTypeId VolumeNet { get; }
      Description: "Net cut/fill"
    static ForgeTypeId VolumeOfInterestHeight { get; }
      Description: "Height"
    static ForgeTypeId VolumeOfInterestName { get; }
      Description: "Name"
    static ForgeTypeId VolumeOfInterestViewsVisible { get; }
      Description: "Views Visible"
    static ForgeTypeId WalkthroughFramesCount { get; }
      Description: "Walkthrough Frames"
    static ForgeTypeId WallAlignKeyRefParam { get; }
      Description: "Location line to align"
    static ForgeTypeId WallAttrDefheightParam { get; }
      Description: "Default height"
    static ForgeTypeId WallAttrHeightParam { get; }
      Description: "Height"
    static ForgeTypeId WallAttrRoomBounding { get; }
      Description: "Room Bounding"
    static ForgeTypeId WallAttrWidthParam { get; }
      Description: "Width"
    static ForgeTypeId WallBaseConstraint { get; }
      Description: "Base Constraint"
    static ForgeTypeId WallBaseHeightParam { get; }
      Description: "Base height"
    static ForgeTypeId WallBaseOffset { get; }
      Description: "Base Offset"
    static ForgeTypeId WallBottomExtensionDistParam { get; }
      Description: "Base Extension Distance"
    static ForgeTypeId WallBottomIsAttached { get; }
      Description: "Base is Attached"
    static ForgeTypeId WallCrossSection { get; }
      Description: "Cross-Section"
    static ForgeTypeId WallHeightType { get; }
      Description: "Top Constraint"
    static ForgeTypeId WallKeyRefParam { get; }
      Description: "Location Line"
    static ForgeTypeId WallLocationLineOffsetParam { get; }
      Description: "Location Line Offset"
    static ForgeTypeId WallSingleSlantAngleFromVertical { get; }
      Description: "Angle From Vertical"
    static ForgeTypeId WallStructuralSignificant { get; }
      Description: "Structural"
    static ForgeTypeId WallStructuralUsageParam { get; }
      Description: "Structural Usage"
    static ForgeTypeId WallStructureIdParam { get; }
      Description: "Structure"
    static ForgeTypeId WallSweepCutByInsertsParam { get; }
      Description: "Cut by Inserts"
    static ForgeTypeId WallSweepCutsWallParam { get; }
      Description: "Cuts Wall"
    static ForgeTypeId WallSweepDefaultSetbackParam { get; }
      Description: "Default Setback"
    static ForgeTypeId WallSweepLevelParam { get; }
      Description: "Level"
    static ForgeTypeId WallSweepOffsetParam { get; }
      Description: "Offset From Level"
    static ForgeTypeId WallSweepOrientation { get; }
      Description: "Orientation"
    static ForgeTypeId WallSweepProfileParam { get; }
      Description: "Profile"
    static ForgeTypeId WallSweepWallOffsetParam { get; }
      Description: "Offset From Wall"
    static ForgeTypeId WallSweepWallSubcategoryId { get; }
      Description: "Subcategory of Walls"
    static ForgeTypeId WallTaperedExteriorInwardAngle { get; }
      Description: "Exterior Angle"
    static ForgeTypeId WallTaperedInteriorInwardAngle { get; }
      Description: "Interior Angle"
    static ForgeTypeId WallTaperedUseInstanceAngles { get; }
      Description: "Enable Angle Overrides"
    static ForgeTypeId WallTaperedWidthAtBottom { get; }
      Description: "Bottom Width"
    static ForgeTypeId WallTaperedWidthAtTop { get; }
      Description: "Top Width"
    static ForgeTypeId WallTopExtensionDistParam { get; }
      Description: "Top Extension Distance"
    static ForgeTypeId WallTopIsAttached { get; }
      Description: "Top is Attached"
    static ForgeTypeId WallTopOffset { get; }
      Description: "Top Offset"
    static ForgeTypeId WallTypeDefaultTaperedExteriorInwardAngle { get; }
      Description: "Default Exterior Angle"
    static ForgeTypeId WallTypeDefaultTaperedInteriorInwardAngle { get; }
      Description: "Default Interior Angle"
    static ForgeTypeId WallTypeWidthMeasuredAt { get; }
      Description: "Width Measured At"
    static ForgeTypeId WallUserHeightParam { get; }
      Description: "Unconnected Height"
    static ForgeTypeId WindowTypeId { get; }
      Description: "Type Mark"
    static ForgeTypeId WindowtypeIsSchematic { get; }
      Description: "Schematic"
    static ForgeTypeId WindowTypeName { get; }
      Description: "Name"
    static ForgeTypeId WitnsLineExtension { get; }
      Description: "Witness Line Extension"
    static ForgeTypeId WitnsLineGapToElt { get; }
      Description: "Witness Line Gap to Element"
    static ForgeTypeId WitnsLineTickMark { get; }
      Description: "Witness Line Tick Mark"
    static ForgeTypeId WrappingAtEndsParam { get; }
      Description: "Wrapping at Ends"
    static ForgeTypeId WrappingAtInsertsParam { get; }
      Description: "Wrapping at Inserts"
    static ForgeTypeId YJustification { get; }
      Description: "y Justification"
    static ForgeTypeId YOffsetValue { get; }
      Description: "y Offset Value"
    static ForgeTypeId YzJustification { get; }
      Description: "yz Justification"
    static ForgeTypeId ZJustification { get; }
      Description: "z Justification"
    static ForgeTypeId ZOffsetValue { get; }
      Description: "z Offset Value"
    static ForgeTypeId ZoneAirChangesPerHour { get; }
      Description: "Air Changes per Hour"
    static ForgeTypeId ZoneAirVolumeCalculationTypeParam { get; }
      Description: "Air Volume Calculation Type"
    static ForgeTypeId ZoneArea { get; }
      Description: "Occupied Area"
    static ForgeTypeId ZoneAreaGross { get; }
      Description: "Gross Area"
    static ForgeTypeId ZoneCalculatedAreaPerCoolingLoadParam { get; }
      Description: "Calculated Area per Cooling Load"
    static ForgeTypeId ZoneCalculatedAreaPerHeatingLoadParam { get; }
      Description: "Calculated Area per Heating Load"
    static ForgeTypeId ZoneCalculatedCoolingLoadParam { get; }
      Description: "Calculated Cooling Load"
    static ForgeTypeId ZoneCalculatedCoolingLoadPerAreaParam { get; }
      Description: "Calculated Cooling Load per area"
    static ForgeTypeId ZoneCalculatedHeatingLoadParam { get; }
      Description: "Calculated Heating Load"
    static ForgeTypeId ZoneCalculatedHeatingLoadPerAreaParam { get; }
      Description: "Calculated Heating Load per area"
    static ForgeTypeId ZoneCalculatedHydronicCoolingflowParam { get; }
      Description: "Calculated Hydronic Cooling Flow"
    static ForgeTypeId ZoneCalculatedHydronicHeatingflowParam { get; }
      Description: "Calculated Hydronic Heating Flow"
    static ForgeTypeId ZoneCalculatedSupplyAirflowParam { get; }
      Description: "Calculated Supply Airflow"
    static ForgeTypeId ZoneCalculatedSupplyAirflowPerAreaParam { get; }
      Description: "Calculated Supply Airflow per area"
    static ForgeTypeId ZoneCoilBypassPercentageParam { get; }
      Description: "Coil Bypass"
    static ForgeTypeId ZoneCoolingAirTemperatureParam { get; }
      Description: "Cooling Air Temperature"
    static ForgeTypeId ZoneCoolingInformationParam { get; }
      Description: "Cooling Information"
    static ForgeTypeId ZoneCoolingSetPointParam { get; }
      Description: "Cooling Set Point"
    static ForgeTypeId ZoneDehumidificationSetPointParam { get; }
      Description: "Dehumidification Set Point"
    static ForgeTypeId ZoneDesignCoolTemperature { get; }
      Description: "Design Temperature for Cooling"
    static ForgeTypeId ZoneDesignHeatTemperature { get; }
      Description: "Design Temperature for Heating"
    static ForgeTypeId ZoneHeatingAirTemperatureParam { get; }
      Description: "Heating Air Temperature"
    static ForgeTypeId ZoneHeatingInformationParam { get; }
      Description: "Heating Information"
    static ForgeTypeId ZoneHeatingSetPointParam { get; }
      Description: "Heating Set Point"
    static ForgeTypeId ZoneHumidificationSetPointParam { get; }
      Description: "Humidification Set Point"
    static ForgeTypeId ZoneLevelId { get; }
      Description: "Level"
    static ForgeTypeId ZoneLevelOffset { get; }
      Description: "Level Offset"
    static ForgeTypeId ZoneLevelOffsetTop { get; }
      Description: "Top Offset"
    static ForgeTypeId ZoneName { get; }
      Description: "Name"
    static ForgeTypeId ZoneOaRatePerAchParam { get; }
      Description: "Outdoor Air Rate / Air Changes per Hour"
    static ForgeTypeId ZoneOutdoorAirInformationParam { get; }
      Description: "Outdoor Air Information"
    static ForgeTypeId ZoneOutsideAirFlowPerArea { get; }
      Description: "Outside Air Flow per Area"
    static ForgeTypeId ZoneOutsideAirFlowPerPerson { get; }
      Description: "Outside Air Flow per Person"
    static ForgeTypeId ZoneOutsideAirPerAreaParam { get; }
      Description: "Outdoor Air per Area"
    static ForgeTypeId ZoneOutsideAirPerPersonParam { get; }
      Description: "Outdoor Air per Person"
    static ForgeTypeId ZonePerimeter { get; }
      Description: "Perimeter"
    static ForgeTypeId ZonePhase { get; }
      Description: "Phase"
    static ForgeTypeId ZonePhaseId { get; }
      Description: "Phase Id"
    static ForgeTypeId ZoneServiceTypeParam { get; }
      Description: "Service Type"
    static ForgeTypeId ZoneSpaceOutdoorAirOptionParam { get; }
      Description: "Space Outdoor Air Option"
    static ForgeTypeId ZoneUseAirChangesPerHourParam { get; }
      Description: "Use Air Changes Per Hour"
    static ForgeTypeId ZoneUseDehumidificationSetpointParam { get; }
      Description: "Use Dehumidification Set Point"
    static ForgeTypeId ZoneUseHumidificationSetpointParam { get; }
      Description: "Use Humidification Set Point"
    static ForgeTypeId ZoneUseOutsideAirPerAreaParam { get; }
      Description: "Use Outside Air Per Area"
    static ForgeTypeId ZoneUseOutsideAirPerPersonParam { get; }
      Description: "Use Outside Air Per Person"
    static ForgeTypeId ZoneVolume { get; }
      Description: "Occupied Volume"
    static ForgeTypeId ZoneVolumeGross { get; }
      Description: "Gross Volume"

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ParameterUtils
Full Name: Autodesk.Revit.DB.ParameterUtils

Description: A utility class of functions related to parameters.

  METHODS:
    static string DownloadCompanyName(Document document, ForgeTypeId parameterTypeId)
      Description: Downloads the name of the given parameter's owning account and records it in the given document. If the owning account's name is already recorded in the given document, this method returns the name without downloading it again.
      @document: Document in which to record the name of the parameter's owning account.
      @parameterTypeId: Parameter identifier.
      Returns: Name of the owning account.
    static SharedParameterElement DownloadParameter(Document document, ParameterDownloadOptions options, ForgeTypeId parameterTypeId)
      Description: Create a shared parameter element in the given document according to a parameter definition downloaded from the Parameters Service.
      @document: Document in which to create a shared parameter from a downloaded definition.
      @options: Parameter download options.
      @parameterTypeId: Parameter identifier.
      Returns: The shared parameter instance.
    static ParameterDownloadOptions DownloadParameterOptions(ForgeTypeId parameterTypeId)
      Description: Retrieves settings associated with the given parameter from the Parameters Service.
      @parameterTypeId: Parameter identifier.
      Returns: Settings associated with a parameter.
    static IList<ForgeTypeId> GetAllBuiltInGroups()
      Description: Gets the identifiers of all built-in parameter groups.
      Returns: The built-in group identifiers.
    static IList<ForgeTypeId> GetAllBuiltInParameters()
      Description: Gets the identifiers of all built-in parameters.
      Returns: The built-in parameter identifiers.
    static BuiltInParameter GetBuiltInParameter(ForgeTypeId parameterTypeId)
      Description: Gets the BuiltInParameter value corresponding to built-in parameter identified by the given ForgeTypeId.
      @parameterTypeId: The parameter identifier.
      Returns: The BuiltInParameter value corresponding to the given parameter identifier.
    static ForgeTypeId GetParameterTypeId(BuiltInParameter builtInParam)
      Description: Gets the ForgeTypeId identifying the built-in parameter corresponding to the given BuiltInParameter value.
      @builtInParam: The BuiltInParameter value.
      Returns: Identifier of the parameter corresponding to the given BuiltInParameter value.
    static bool IsBuiltInGroup(ForgeTypeId groupTypeId)
      Description: Checks whether a ForgeTypeId identifies a built-in parameter group.
      @groupTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a built-in parameter group, false otherwise.
    static bool IsBuiltInParameter(ElementId parameterId)
      Description: Checks whether an ElementId identifies a built-in parameter.
      @parameterId: The identifier to check.
      Returns: True if the ElementId identifies a built-in parameter, false otherwise.
    static bool IsBuiltInParameter(ForgeTypeId parameterTypeId)
      Description: Checks whether a ForgeTypeId identifies a built-in parameter.
      @parameterTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a built-in parameter, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ParameterValue
Full Name: Autodesk.Revit.DB.ParameterValue

Description: A class that holds a value of a parameter element.
Remarks: This is a non-instantiable base class. Classes that actually store a value of a certain type are all derived from this base class, once class per each value type.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    ParameterValue Copy()
      Description: Makes an identical copy of the given parameter value.
    void Dispose()
    bool IsEqual(ParameterValue other)
      Description: Tests equality with another instance of the same class.
      @other: The instance to compare with
    bool IsSameType(ParameterValue other)
      Description: Tests another instance is of the same value type.
      @other: The instance to compare with

--------------------------------------------------------------------------------


[CLASS] ParameterValuePresenceRule
Full Name: Autodesk.Revit.DB.ParameterValuePresenceRule

Description: Tests whether an element's parameter has a value or not.
Inherits: FilterRule
Implements: IDisposable

  PROPERTIES:
    ElementId Parameter { get; set; }
      Description: The parameter which will be evaluated to pass this rule.

--------------------------------------------------------------------------------


[CLASS] ParameterValueProvider
Full Name: Autodesk.Revit.DB.ParameterValueProvider

Description: Gets the value of a parameter from any element passed to GetStringValue, GetDoubleValue, GetIntegerValue, or GetElementIdValue.
Remarks: For any parameter, only one of isStringValueSupported, isDoubleValueSupported, isIntegerValueSupported, isElementIdValueSupported will return true. No attempt to convert between types is made. For example, calling GetStringValue, passing the identifier of a numeric-typed parameter will give an empty string. No exception will be thrown, and ParameterValueProvider will not attempt to convert the numeric value to a string.If an element doesn't have the requested parameter or the element's parameter doesn't have a valid value, ParameterValueProvider will attempt to get the parameter value from the element's type - see .
Inherits: FilterableValueProvider
Implements: IDisposable

  CONSTRUCTORS:
    new ParameterValueProvider(ElementId parameter)

  PROPERTIES:
    ElementId Parameter { get; set; }
      Description: The parameter used to provide a string, integer, double-precision, or ElementId value on request for a given element.

--------------------------------------------------------------------------------


[CLASS] Part
Full Name: Autodesk.Revit.DB.Part

Description: This element represents a part of another element.
Remarks: A part is associated with a PartMaker element that creates it.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool Excluded { get; set; }
      Description: True if the part is excluded, false otherwise
    ElementId OriginalCategoryId { get; set; }
      Description: The category Id of the original element corresponding to this Part.
    PartMaker PartMaker { get; }
      Description: The PartMaker that created this Part.

  METHODS:
    bool CanOffsetFace(Face face)
      Description: Checks if it is possible to offset the given face.
      @face: face to be checked.
    double GetFaceOffset(Face face)
      Description: Get face offset of the given part face.
      @face: The face whose offset is required.
      Returns: Returns the value of the offset.
    ICollection<LinkElementId> GetSourceElementIds()
      Description: Gets a collection of elements from which this Part is created by the PartMaker. May return more than one source only if there is merge involved somewhere in the history of this Part.
      Returns: The collection of elements
    ICollection<ElementId> GetSourceElementOriginalCategoryIds()
      Description: Gets the category ids of the source elements which were used to form this part.
      Returns: The category ids.
    void ResetFaceOffset(Face face)
      Description: Resets the offset applied to the given part face.
      @face: The face whose offset needs to be reset.
    void ResetPartShape()
      Description: Resets all face offsets applied to part faces.
    void SetFaceOffset(Face face, double offset)
      Description: Offsets the given part face in the direction that points out of the solid shape with the specified amount. Negative value will offset the face into the solid shape.
      @face: The face to offset.
      @offset: The magnitude of the offset.

--------------------------------------------------------------------------------


[ENUM] PartEdgeConditionOrientation
Full Name: Autodesk.Revit.DB.PartEdgeConditionOrientation

Description: Relative orientation of the right/lower and left/upper edge condition profiles.
Remarks: A family-based profile defines the shape of the left/upper profile and this value defines how a matching right/lower profile is obtained.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Complement = 0
    - Mirrored = 1
    - MirroredAndRotated = 2


[CLASS] PartMaker
Full Name: Autodesk.Revit.DB.PartMaker

Description: PartMaker is an element which takes some source elements (e.g., a wall with all its layers) and creates one or more Parts out of it. The logic according to which these Parts are created is non-trivial and PartMaker uses various PartMakerMethods which represents these logics. This element manages the strategy to make Part elements for one or more original elements.
Inherits: Element
Implements: IDisposable

  METHODS:
    ICollection<LinkElementId> GetSourceElementIds()
      Description: Get the source elements for the PartMaker.
      Returns: Elements that are the sources for this PartMaker.
    bool IsSourceElement(ElementId elemId)
      Description: Is the element a source for this PartMaker
      Returns: Returns true if elemId is among the source elements of this PartMaker
    void SetSourceElementIds(ICollection<ElementId> sourceElementIds)
      Description: Set the source elements for the PartMaker.
      @sourceElementIds: Elements to be the sources for this PartMaker.

--------------------------------------------------------------------------------


[CLASS] PartMakerMethodToDivideVolumes
Full Name: Autodesk.Revit.DB.PartMakerMethodToDivideVolumes

Description: By-References dividing strategy used by PartMaker element. TODO_REFACTOR("LegacyMechanismOfMovingElements") returns true if - the Host Elements are not floors or walls - OR - the Host Elements that are referenced by this PartMaker are floors or walls - transformation has already been applied on those Host Elements
Implements: IDisposable

  PROPERTIES:
    double DivisionGap { get; set; }
      Description: The gap which is created between matching profiles of parts.
    bool DivisionPatternMirror { get; set; }
      Description: Whether pattern defined by the division rule should be mirrored before application Mirroring is similar to changing indices of u-const gridlines.
    double DivisionRotationAngle { get; set; }
      Description: Angle by which both u- and v- gridlines of the division are rotated with respect to the natural u/v-const directions of the sketch plane.
    ElementId DivisionRuleId { get; set; }
      Description: Id of the 'DivisionRule' which is used to augment the cutting sketch.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ProfileFlipAcross { get; set; }
      Description: True if the corresponding left/upper parts profile are mirrored with respect to the division line. False if the profile of left/upper parts are defined directly by the profile family.
    bool ProfileFlipAlong { get; set; }
      Description: True if the corresponding left/upper parts profile are mirrored with respect to the center line of the hosts to be divided. False if the profile of left/upper parts are defined directly by the profile family.
    PartEdgeConditionOrientation ProfileMatch { get; set; }
      Description: Determines how two profiles match.
    double ProfileOffset { get; set; }
      Description: The offset which is applied to a family-defined profile in the direction away from the division line and toward left/upper part to obtain its profile.
    ElementId ProfileType { get; set; }
      Description: The id of the profile family applied to boundaries between parts.
    int UConstDivisionIndent { get; set; }
      Description: Indentation for the application of division rule's pattern across u-const gridlines (i.e., similar to changing indices of u-const gridlines).
    int VConstDivisionIndent { get; set; }
      Description: Indentation for the application of division rule's pattern across v-const gridlines (i.e., similar to changing indices of v-const gridlines).

  METHODS:
    bool AddIntersectingReference(ElementId intersectingReference, double offset)
      Description: Adds intersecting reference with an offset.
      @intersectingReference: Id of the new intersecting reference.
      @offset: The Offste for the new intersecting reference.
      Returns: True if the PartMaker did not already use this intersecting reference and it was added, false if the PartMaker already used this intersecting reference and this call only updated its offset.
    static bool AreElementsValidIntersectingReferences(Document document, ICollection<ElementId> elementIds)
      Description: Identifies if provided members are valid.
      @document: The document.
      @elementIds: Element ids to be tested for validity for intersecting references.
      Returns: True if all references are valid, false otherwise.
    bool AreElementsValidIntersectingReferences(ICollection<ElementId> elementIds)
      Description: Identifies if provided members are valid.
      @elementIds: Element ids to be tested for validity for intersecting references.
      Returns: True if all references are valid, false otherwise.
    bool CanBeDivisionProfile(ElementId familyId)
      Description: Checks whether a family defines a profile which can be used by this method.
      @familyId: Element id of the family.
      Returns: True if the family defines a profile which can be used by a part maker, false otherwise.
    static bool CanBeDivisionProfile(ElementId familyId, Document familyDocument)
      Description: Checks whether a family defines a profile which can be used by this method.
      @familyId: Element id of the family.
      @familyDocument: The document containing the family to be tested.
      Returns: True if the family defines a profile which can be used by a part maker, false otherwise.
    void Dispose()
    double GetOffsetForIntersectingReference(ElementId intersectingReference)
      Description: Gets offset for the intersecting reference.
      @intersectingReference: The intersecting reference to obtain offset value from.
      Returns: The offset for the intersecting reference
    Plane GetPlaneOfSketch()
      Description: Gets the plane of the sketch.
      Returns: The plane of the sketch.
    void GetSketchCurves(out IList<Curve> curveArray)
    IDictionary<ElementId, double> GetSplitRefsOffsets()
      Description: Returns offsets for plane-defining splitters.
    static bool IsElementValidIntersectingReference(Document document, ElementId elementId)
      Description: Identifies if the provided member is valid.
      @document: The document.
      @elementId: Element ids to be tested for validity for intersecting references.
      Returns: True if the reference is valid, false otherwise.
    bool IsElementValidIntersectingReference(ElementId elementId)
      Description: Identifies if the provided member is valid.
      @elementId: Element ids to be tested for validity for intersecting references.
      Returns: True if the reference is valid, false otherwise.
    static bool IsValidSketchPlane(Document document, ElementId sketchPlaneId)
      Description: Identifies if provided sketch plane is valid.
      @document: The document.
      @sketchPlaneId: SketchPlane ids to be tested for validity for PartMaker.
      Returns: True if SketchPlane valid, false otherwise.
    bool RemoveIntersectingReference(ElementId intersectingReference)
      Description: Removed intersecting reference.
      @intersectingReference: Id of the intersecting reference to remove.
      Returns: True if the PartMaker used this intersecting reference and this call removed it, false if the PartMaker did not use this intersecting reference.
    void SetOffsetForIntersectingReference(ElementId intersectingReference, double offset)
      Description: Sets offset for the intersecting reference.
      @intersectingReference: The intersecting reference that will be offset.
      @offset: The new offset.
    bool UsesReference(ElementId intersectingReference)
      Description: Identifies if the PartMaker uses the intersecting reference.
      @intersectingReference: Intersecting reference to be tested.
      Returns: True if the intersecting reference is used by the PartMaker.

--------------------------------------------------------------------------------


[ENUM] PartsVisibility
Full Name: Autodesk.Revit.DB.PartsVisibility

Description: Indicates the visibility of parts for the view.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowPartsOnly = 0
    - ShowOriginalOnly = 1
    - ShowPartsAndOriginal = 2
    - Unset = -1


[ENUM] PartType
Full Name: Autodesk.Revit.DB.PartType

Description: An enumerated type listing all MEP family part types. A part type typically provides one unique set of type parameters that defines this part.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Normal = 0
    - DuctMounted = 1
    - JunctionBox = 2
    - AttachesTo = 3
    - BreaksInto = 4
    - Elbow = 5
    - Tee = 6
    - Transition = 7
    - Cross = 8
    - Cap = 9
    - TapPerpendicular = 10
    - TapAdjustable = 11
    - Offset = 12
    - Union = 13
    - PanelBoard = 14
    - Transformer = 15
    - SwitchBoard = 16
    - OtherPanel = 17
    - EquipmentSwitch = 18
    - Switch = 19
    - ValveBreaksInto = 20
    - SpudPerpendicular = 21
    - SpudAdjustable = 22
    - Damper = 23
    - Wye = 24
    - LateralTee = 25
    - LateralCross = 26
    - Pants = 27
    - MultiPort = 28
    - ValveNormal = 29
    - JunctionBoxTee = 30
    - JunctionBoxCross = 31
    - PipeFlange = 32
    - JunctionBoxElbow = 34
    - ChannelCableTrayElbow = 35
    - ChannelCableTrayVerticalElbow = 36
    - ChannelCableTrayCross = 37
    - ChannelCableTrayTee = 38
    - ChannelCableTrayTransition = 39
    - ChannelCableTrayUnion = 40
    - ChannelCableTrayOffset = 41
    - ChannelCableTrayMultiPort = 42
    - LadderCableTrayElbow = 43
    - LadderCableTrayVerticalElbow = 44
    - LadderCableTrayCross = 45
    - LadderCableTrayTee = 46
    - LadderCableTrayTransition = 47
    - LadderCableTrayUnion = 48
    - LadderCableTrayOffset = 49
    - LadderCableTrayMultiPort = 50
    - InlineSensor = 51
    - Sensor = 52
    - EndCap = 53
    - HandrailBracketHardware = 54
    - PanelBracketHardware = 55
    - TerminationHardware = 56
    - Rails = 57
    - Handrails = 58
    - TopRails = 59
    - PipeMechanicalCoupling = 60
    - Undefined = -1


[ABSTRACT CLASS] PartUtils
Full Name: Autodesk.Revit.DB.PartUtils

Description: General Part utility methods

  METHODS:
    static bool AreElementsValidForCreateParts(Document document, ICollection<ElementId> elementIds)
      Description: Identifies if the given elements can be used to create parts.
      @document: The document.
      @elementIds: Element ids to be tested for validity for creating parts.
      Returns: True if all member ids are valid, false otherwise.
    static bool ArePartsValidForDivide(Document document, ICollection<ElementId> elementIdsToDivide)
      Description: Identifies if provided members are valid for dividing parts.
      @document: The document.
      @elementIdsToDivide: Element ids to be tested for validity for dividing parts.
      Returns: True if all member ids are valid, false otherwise.
    static bool ArePartsValidForMerge(Document document, ICollection<ElementId> partIds)
      Description: Identifies whether Part elements may be merged.
      @document: The document.
      @partIds: Element ids of Parts.
      Returns: True if all element ids correspond to Part elements, none of the parts already has associated parts, the parts have contiguous geometry, all report the same materials, and all have the same creation and demolition phases.
    static PartMaker CreateMergedPart(Document document, ICollection<ElementId> partIds)
      Description: Create a single merged part which represents the Parts specified by partsToMerge.
      @document: The document.
      @partIds: The elements that the merged part will be created from.
      Returns: The newly created PartMaker. if no parts are merged.
    static void CreateParts(Document document, ICollection<ElementId> elementIds)
      Description: Creates a new set of parts out of the original elements.
      @document: The document containing the elements.
      @elementIds: The elements that parts will be created from.
    static void CreateParts(Document document, ICollection<LinkElementId> hostOrLinkElementIds)
      Description: Creates a new set of parts out of the original elements.
      @document: The document containing the elements.
      @hostOrLinkElementIds: The elements that parts will be created from.
    static PartMaker DivideParts(Document document, ICollection<ElementId> elementIdsToDivide, ICollection<ElementId> intersectingReferenceIds, IList<Curve> curveArray, ElementId sketchPlaneId)
      Description: Creates divided parts out of parts.
      @document: The document containing the parts.
      @elementIdsToDivide: The elements that will be divided.
      @intersectingReferenceIds: Intersecting references that will divide the elements.
      @curveArray: Array of curves that will divide the elements.
      @sketchPlaneId: SketchPlane id for the curves that divide the elements.
      Returns: The newly created PartMaker. if no parts are divided.
    static IList<ICollection<ElementId>> FindMergeableClusters(Document doc, ICollection<ElementId> partIds)
      Description: Segregates a set of elements into subsets which are valid for merge.
      @doc: The document.
      @partIds: A set of element ids.
      Returns: An array of clusters such that all the elements in a single cluster are valid for merge. Each cluster will be maximal in that appending any of the other Parts specified as input will result in a collection that is not valid for merge.
    static PartMaker GetAssociatedPartMaker(Document hostDocument, ElementId elementId)
      Description: Gets associated PartMaker for an element.
      @hostDocument: The document
      @elementId: The id for the element to be checked for associated Parts
      Returns: The PartMaker element that is making Parts for this element. if there is no associated PartMaker.
    static PartMaker GetAssociatedPartMaker(Document hostDocument, LinkElementId hostOrLinkElementId)
      Description: Gets associated PartMaker for an element.
      @hostDocument: The document
      @hostOrLinkElementId: The id for the element to be checked for associated Parts
      Returns: The PartMaker element that is making Parts for this element. if there is no associated PartMaker.
    static ICollection<ElementId> GetAssociatedParts(Document hostDocument, ElementId elementId, bool includePartsWithAssociatedParts, bool includeAllChildren)
      Description: Returns all Parts that are associated with the given element.
      @hostDocument: The document of the element.
      @elementId: The element to be checked for associated Parts.
      @includePartsWithAssociatedParts: If true, include parts that have associated parts.
      @includeAllChildren: If true, return all associated Parts recursively for all children. If false, only return immediate children.
      Returns: Parts that are associated to the element.
    static ICollection<ElementId> GetAssociatedParts(Document hostDocument, LinkElementId hostOrLinkElementId, bool includePartsWithAssociatedParts, bool includeAllChildren)
      Description: Returns all Parts that are associated with the given element
      @hostDocument: The document of the element
      @hostOrLinkElementId: The element to be checked for associated Parts.
      @includePartsWithAssociatedParts: If true, include parts that have associated parts
      @includeAllChildren: If true, return all associated Parts recursively for all children If false, only return immediate children
      Returns: Parts that are associated to the element
    static int GetChainLengthToOriginal(Part part)
      Description: Calculates the length of the longest chain of divisions/merges to reach to an original non-Part element that is the source of the tested part.
      @part: The part to be tested
      Returns: The length of the longest chain.
    static ICollection<ElementId> GetMergedParts(Part part)
      Description: Retrieves the element ids of the source elements of a merged part.
      @part: A merged part.
      Returns: The element ids of the parts that were merged to create the specified merged part.
    static PartMakerMethodToDivideVolumes GetPartMakerMethodToDivideVolumeFW(PartMaker partMaker)
      Description: Obtains the object allowing access to the divided volume properties of the PartMaker.
      @partMaker: The PartMaker.
      Returns: The object handle. Returns if the PartMaker does not represent divided volumes.
    static IList<Curve> GetSplittingCurves(Document document, ElementId partId, out Plane sketchPlane)
    static IList<Curve> GetSplittingCurves(Document document, ElementId partId)
      Description: Identifies the curves that were used to create the part.
      @document: The source document of the part.
      @partId: The part id.
      Returns: The curves that created the part. Empty if partId is not a Part or Part is not divided.
    static ISet<ElementId> GetSplittingElements(Document document, ElementId partId)
      Description: Identifies the elements ( reference planes, levels, grids ) that were used to create the part.
      @document: The source document of the part.
      @partId: The part id.
      Returns: The elements that created the part. Empty if partId is not a Part or Part is not divided.
    static bool HasAssociatedParts(Document hostDocument, ElementId elementId)
      Description: Checks if an element has associated parts.
      @hostDocument: The document.
      @elementId: The element to be checked for associated Parts
      Returns: True if the element has associated Parts.
    static bool HasAssociatedParts(Document hostDocument, LinkElementId hostOrLinkElementId)
      Description: Checks if an element has associated parts.
      @hostDocument: The document.
      @hostOrLinkElementId: The element to be checked for associated Parts.
      Returns: True if the element has associated Parts.
    static bool IsMergedPart(Part part)
      Description: Is the Part the result of a merge.
      Returns: True if the Part is the result of a merge operation.
    static bool IsPartDerivedFromLink(Part dPart)
      Description: Is the Part derived from link geometry.
    static bool IsValidForCreateParts(Document document, LinkElementId hostOrLinkElementId)
      Description: Identifies if the given element can be used to create parts.
      @document: The document.
      @hostOrLinkElementId: Id to be tested for validity for creating part.
      Returns: True if this id is valid, false otherwise.

--------------------------------------------------------------------------------


[CLASS] Path3d
Full Name: Autodesk.Revit.DB.Path3d

Description: Provides access to the Generic 3D path object in Autodesk Revit.
Remarks: This object represents a 3D path sketch of Sweep.
Inherits: SketchBase
Implements: IDisposable

  PROPERTIES:
    CurveArrArray AllCurveLoops { get; }
      Description: Get all the Curve Loops of Path3d.
    CurveArray CurveLoop { get; }
    int NumCurveLoops { get; }
      Description: Get the Number of Curve Loops of Path3d.

--------------------------------------------------------------------------------


[ENUM] PathType
Full Name: Autodesk.Revit.DB.PathType

Description: Enum determining what kind of path a given external file reference path is. Paths are valid for all types of external file references unless otherwise specified.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Relative = 0
    - Absolute = 1
    - Server = 2
    - Content = 3


[CLASS] PDFExportOptions
Full Name: Autodesk.Revit.DB.PDFExportOptions

Description: Options for PDF export
Implements: IDisposable

  CONSTRUCTORS:
    new PDFExportOptions()

  PROPERTIES:
    bool AlwaysUseRaster { get; set; }
      Description: If true completely use raster processing for graphics, otherwise use vector processing as much as possible.
    ColorDepthType ColorDepth { get; set; }
      Description: Color depth of either black/white, gray scale or color.
    bool Combine { get; set; }
      Description: Whether export all views and sheets into one PDF file or multiple files.
    PDFExportQualityType ExportQuality { get; set; }
      Description: The preferred export quality (DPI).
    string FileName { get; set; }
      Description: File name of the PDF when is .
    bool HideCropBoundaries { get; set; }
      Description: Whether to hide crop boundaries.
    bool HideReferencePlane { get; set; }
      Description: Whether to hide reference/work planes.
    bool HideScopeBoxes { get; set; }
      Description: Whether to hide scope boxes.
    bool HideUnreferencedViewTags { get; set; }
      Description: Whether to hide unreferenced view tags.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool MaskCoincidentLines { get; set; }
      Description: Whether to mask coincident lines.
    double OriginOffsetX { get; set; }
      Description: Offset between left sides of pdf content and paper. Always stored in unit of Feet.
    double OriginOffsetY { get; set; }
      Description: Offset between bottom sides of pdf content and paper. Always stored in unit of Feet.
    ExportPaperFormat PaperFormat { get; set; }
      Description: Paper format.
    PageOrientationType PaperOrientation { get; set; }
      Description: Paper orientation - Portrait/Landscape/Auto
    PaperPlacementType PaperPlacement { get; set; }
      Description: Paper placement of either center or offset from corner.
    RasterQualityType RasterQuality { get; set; }
      Description: The preferred raster quality (DPI).
    bool ReplaceHalftoneWithThinLines { get; set; }
      Description: Whether to replace halftone with thin lines.
    bool StopOnError { get; set; }
      Description: Whether export process should stop when a view fails to export
    bool ViewLinksInBlue { get; set; }
      Description: Whether set view links blue.
    int ZoomPercentage { get; set; }
      Description: Percentage of the zoom for the view.
    ZoomType ZoomType { get; set; }
      Description: Zoom type of either fit to page or on a specific percentage.

  METHODS:
    void Dispose()
    bool GetExportInBackground()
      Description: Execute PDF export as a background process.
    IList<TableCellCombinedParameterData> GetNamingRule()
      Description: Gets a copy of the naming rule.
      Returns: The naming rule.
    static bool IsValidNamingRule(IList<TableCellCombinedParameterData> namingRule)
      Description: Whether naming rule is valid or not.
      @namingRule: The naming rule to be validated.
      Returns: Whether or not the name is valid.
    void SetExportInBackground(bool exportInBackground)
      Description: Execute PDF export as a background process.
      @exportInBackground: Execute PDF export as a background process.
    void SetNamingRule(IList<TableCellCombinedParameterData> namingRule)
      Description: Sets the naming rule.
      @namingRule: The naming rule.

--------------------------------------------------------------------------------


[ENUM] PDFExportQualityType
Full Name: Autodesk.Revit.DB.PDFExportQualityType

Description: An enumerated type listing the options for PDF export quality.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - DPI72 = 72
    - DPI144 = 144
    - DPI300 = 300
    - DPI600 = 600
    - DPI1200 = 1200
    - DPI2400 = 2400
    - DPI3600 = 3600
    - DPI4000 = 4000


[CLASS] PerformanceAdviser
Full Name: Autodesk.Revit.DB.PerformanceAdviser

Description: The tool to report performance problems in a given document.
Remarks: Class is an application-wide singleton that performs a dual role: it is a repository of rules to run in order to detect potential performance problems as well as an access point to execute checks.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddRule(PerformanceAdviserRuleId id, IPerformanceAdviserRule rule)
      Description: Adds a performance adviser rule to the list of rules.
      @id: An id of the rule to be added to the list of rules.
      @rule: The rule to be added
    void DeleteRule(PerformanceAdviserRuleId id)
      Description: Deletes a performance adviser rule from the list of rules.
      @id: An id of the rule to be deleted from the list of rules.
    void Dispose()
    IList<FailureMessage> ExecuteAllRules(Document document)
      Description: Executes all rules in the list on a given document.
      @document: Document on which the rules will be executed.
      Returns: Failure messages explaining performance problems detected in the document.
    IList<FailureMessage> ExecuteRules(Document document, IList<int> rules)
      Description: Executes selected rules on a given document.
      @document: Document on which the rules will be executed.
      @rules: Indices of rules to be executed.
      Returns: Failure messages explaining performance problems detected in the document.
    IList<FailureMessage> ExecuteRules(Document document, IList<PerformanceAdviserRuleId> rules)
      Description: Executes selected rules on a given document.
      @document: Document on which the rules will be executed.
      @rules: Ids of rules to be executed.
      Returns: Failure messages explaining performance problems detected in the document.
    IList<PerformanceAdviserRuleId> GetAllRuleIds()
      Description: Retrieves an enumeration of rule Ids.
      Returns: A collection of rule Ids
    ElementFilter GetElementFilterFromRule(int index, Document document)
      Description: Retrieves a filter to restrict elements to be checked.
      @index: The rule index to get information for.
      @document: Document for which performance problems are being checked.
      Returns: The filter to restrict elements to be checked.
    ElementFilter GetElementFilterFromRule(PerformanceAdviserRuleId id, Document document)
      Description: Retrieves a filter to restrict elements to be checked.
      @id: The rule id to get information for.
      @document: Document for which performance problems are being checked.
      Returns: The filter to restrict elements to be checked.
    int GetNumberOfRules()
      Description: Retrieves number of performance adviser rules in the list.
      Returns: Number of performance adviser rules in the list.
    static PerformanceAdviser GetPerformanceAdviser()
      Description: Returns the only instance of PerformanceAdviser in the Application.
      Returns: The only instance of PerformanceAdviser in the Application.
    string GetRuleDescription(int index)
      Description: Retrieves the description of the rule.
      @index: The rule index to get information for.
      Returns: The description of the rule.
    string GetRuleDescription(PerformanceAdviserRuleId id)
      Description: Retrieves the description of the rule.
      @id: The rule id to get information for.
      Returns: The description of the rule.
    PerformanceAdviserRuleId GetRuleId(int index)
      Description: Retrieves an id of a rule for a given index in the list.
      @index: The index to retrieve the rule id for.
      Returns: The rule id.
    string GetRuleName(int index)
      Description: Retrieves the name of the rule.
      @index: The rule index to get information for.
      Returns: The name of the rule.
    string GetRuleName(PerformanceAdviserRuleId id)
      Description: Retrieves the name of the rule.
      @id: The rule id to get information for.
      Returns: The name of the rule.
    bool IsRuleEnabled(PerformanceAdviserRuleId id)
      Description: Retrieves an enabled/disabled status for the given rule.
      @id: The rule id to retrieve enabled/disabled status for.
      Returns: True if rule is disabled, false otherwise.
    bool IsRuleEnabled(int index)
      Description: Retrieves an enabled/disabled status for the given rule.
      @index: The rule index to retrieve enabled/disabled status for.
      Returns: True if rule is disabled, false otherwise.
    void PostWarning(FailureMessage message)
      Description: Reports a problem detected during execution of a rule.
      @message: Warning describing the problem detected by a rule.
    void SetRuleEnabled(PerformanceAdviserRuleId id, bool enabled)
      Description: Retrieves an enabled/disabled status for the given rule.
      @id: The rule id to set enabled/disabled status for.
      @enabled: True enables the rule, false disables.
    void SetRuleEnabled(int index, bool enabled)
      Description: Retrieves an enabled/disabled status for the given rule.
      @index: The rule index to set enabled/disabled status for.
      @enabled: True enables the rule, false disables.
    bool WillRuleCheckElements(int index)
      Description: Reports if rule needs to be executed on individual elements.
      @index: The rule index to get information for.
      Returns: True if rule needs to be executed on individual elements.
    bool WillRuleCheckElements(PerformanceAdviserRuleId id)
      Description: Reports if rule needs to be executed on individual elements.
      @id: The rule id to get information for.
      Returns: True if rule needs to be executed on individual elements.

--------------------------------------------------------------------------------


[CLASS] PerformanceAdviserRuleId
Full Name: Autodesk.Revit.DB.PerformanceAdviserRuleId

Description: The unique identifier of a PerformanceAdviserRule
Remarks: Each performance adviser rule registered in application must be given a unique id that can be used to identify and unregister rule later.
Inherits: GuidEnum

  CONSTRUCTORS:
    new PerformanceAdviserRuleId(Guid guid)

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PerformanceAdviserRules
Full Name: Autodesk.Revit.DB.PerformanceAdviserRules

Description: Provides a container of all Revit built-in PerformanceAdviserRuleId instances.

--------------------------------------------------------------------------------


[CLASS] Phase
Full Name: Autodesk.Revit.DB.Phase

Description: Represents a phase in the life of a building.
Remarks: The lifetime of an element within a building can be controlled by using phases. Each element will have a construction phase but only those elements that have a finite lifetime will have a destruction phase. All the phases within a project can be retrieved from the Document object.
Inherits: Element
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] PhaseArray
Full Name: Autodesk.Revit.DB.PhaseArray

Description: An array that contains phase objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new PhaseArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Phase Item { get; set; }
    int Size { get; }
      Description: Returns the number of phases that are in the array.

  METHODS:
    void Append(Phase item)
      Description: Add the phase to the end of the array.
      @item: The phase to be added.
    void Clear()
      Description: Removes every phase from the array, rendering it empty.
    PhaseArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Phase item, int index)
      Description: Insert the specified phase into the array.
      @item: The phase to be inserted into the array.
      @index: The phase will be inserted before this index.
      Returns: Returns whether the phase was inserted into the array.
    PhaseArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PhaseArrayIterator
Full Name: Autodesk.Revit.DB.PhaseArrayIterator

Description: An iterator to a phase array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new PhaseArrayIterator()

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


[CLASS] PhaseFilter
Full Name: Autodesk.Revit.DB.PhaseFilter

Description: Represents an phase filter within Autodesk Revit.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool IsDefault { get; }
      Description: Indicates whether this filter is the default one.

  METHODS:
    static PhaseFilter Create(Document document, string name)
      Description: Creates a new phase filter with default status presentation.
      @document: The document.
      @name: The name.
      Returns: The newly created phase filter.
    PhaseStatusPresentation GetPhaseStatusPresentation(ElementOnPhaseStatus status)
      Description: Gets the phase status presentation.
      @status: The element phase status.
      Returns: The phase status presentation.
    void SetPhaseStatusPresentation(ElementOnPhaseStatus status, PhaseStatusPresentation presentation)
      Description: Sets the phase status presentation.
      @status: The element phase status.
      @presentation: The phase status presentation.

--------------------------------------------------------------------------------


[ENUM] PhaseStatusPresentation
Full Name: Autodesk.Revit.DB.PhaseStatusPresentation

Description: An enumerated type listing the options for element display in a phase filter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - DontShow = 0
    - ShowByCategory = 1
    - ShowOverriden = 2


[CLASS] PlanarFace
Full Name: Autodesk.Revit.DB.PlanarFace

Description: A bounded face of a 3d solid or open shell.
Remarks: Planar faces are defined by planes bounded by edge loops. The planes provide natural UV parameterization to the faces. S(u, v) = Origin + u*Vector[0] + v*Vector[1]
Inherits: Face
Implements: IDisposable

  PROPERTIES:
    XYZ FaceNormal { get; }
      Description: Normal of the planar face.
    XYZ Origin { get; }
      Description: Origin of the surface.
    XYZ XVector { get; }
      Description: The X-vector of the planar face.
    XYZ YVector { get; }
      Description: The Y-vector of the planar face.

--------------------------------------------------------------------------------


[CLASS] PlanCircuit
Full Name: Autodesk.Revit.DB.PlanCircuit

Description: An object that represents an enclosed area in a plan view within the Autodesk Revit project.
Remarks: Plan circuits are enclosed regions as seen on a plan view. They are used to determine the boundary extents of rooms based on the placement of walls. In the Autodesk Revit API, you can use plan circuits to create new rooms.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: The enclosed area of the circuit.
    bool IsRoomLocated { get; }
      Description: Reports whether there is a room located in this circuit.
    int SideNum { get; }
      Description: The number of sides in the circuit.

  METHODS:
    UV GetPointInside()
      Description: Returns a point inside the circuit.

--------------------------------------------------------------------------------


[CLASS] PlanCircuitSet
Full Name: Autodesk.Revit.DB.PlanCircuitSet

Description: A set that can contain any number of plan circuit objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new PlanCircuitSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(PlanCircuit item)
      Description: Tests for the existence of an item within the set.
      @item: The item to be searched for.
      Returns: The Contains method returns True if the item is within the set, otherwise False.
    int Erase(PlanCircuit item)
      Description: Removes a specified object from the set.
      @item: The item to be erased.
      Returns: The number of items that were erased from the set.
    PlanCircuitSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(PlanCircuit item)
      Description: Insert the specified item into the set.
      @item: The item to be inserted into the set.
      Returns: Returns whether the item was inserted into the set.
    PlanCircuitSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PlanCircuitSetIterator
Full Name: Autodesk.Revit.DB.PlanCircuitSetIterator

Description: An iterator to a set of plan circuit objects.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new PlanCircuitSetIterator()

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


[CLASS] Plane
Full Name: Autodesk.Revit.DB.Plane

Description: A Planar surface.
Remarks: The parametric equation of the plane is S(u, v) = origin + u*xVec + v*yVec.
Inherits: Surface
Implements: IDisposable

  PROPERTIES:
    XYZ Normal { get; }
      Description: Plane normal.
    XYZ Origin { get; }
      Description: Plane origin.
    XYZ XVec { get; }
      Description: Axis defining the first parametric direction of the plane.
    XYZ YVec { get; }
      Description: Axis defining the second parametric direction of the plane.

  METHODS:
    static Plane Create(Frame frameOfReference)
      Description: Creates a Plane object defined by a local frame of reference.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the plane being constructed. Frame.Origin is a point on plane. Frame.BasisZ defines the plane's normal, while Frame.BasisX and Frame.BasisY are orthogonal to the normal. The frame may be either left-handed or right-handed (see Frame.IsRightHanded).
    static Plane CreateByNormalAndOrigin(XYZ normal, XYZ origin)
      Description: Constructs a Plane object from a normal and an origin represented as XYZ objects. Follows the standard conventions for a planar surface. The constructed Plane object will pass through origin and be perpendicular to normal. The X and Y axes of the plane will be defined arbitrarily.
      @normal: Plane normal. Expected to be a valid non-zero length vector. Doesn't need to be a unit vector.
      @origin: Plane origin. Expected to lie within the Revit design limits .
    static Plane CreateByOriginAndBasis(XYZ origin, XYZ basisX, XYZ basisY)
      Description: Creates a Plane object defined by the two orthogonal unit vectors and passing through the origin point supplied as arguments.
      @origin: Plane origin. Expected to lie within the Revit design limits .
      @basisX: First of the two unit vectors that define the plane. Must be orthogonal to the second one.
      @basisY: Second of the two unit vectors that define the plane. Must be orthogonal to the first one.
    static Plane CreateByThreePoints(XYZ point1, XYZ point2, XYZ point3)
      Description: Creates a Plane object passing through three points supplied as arguments.
      @point1: First of the three points that define a unique plane. The created Plane object will pass through these points.
      @point2: Second of the three points that define a unique plane.
      @point3: Third of the three points that define a unique plane.

--------------------------------------------------------------------------------


[CLASS] PlanTopology
Full Name: Autodesk.Revit.DB.PlanTopology

Description: An object that represents a Plan Topology within the Autodesk Revit project.
Remarks: This object derived from the APIObject base object. It can be used access the properties of a Plan Topology.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    PlanCircuitSet Circuits { get; }
      Description: The Circuits of the PlanTopology.
    Level Level { get; }
      Description: The Level of the PlanTopology.
    Phase Phase { get; }
      Description: The phase of the PlanTopology.

  METHODS:
    ICollection<ElementId> GetRoomIds()
      Description: Retrieves room ElementIds of the PlanTopology in the last phase.
      Returns: The PlanTopology Room ElementIds of the last phase.

--------------------------------------------------------------------------------


[CLASS] PlanTopologySet
Full Name: Autodesk.Revit.DB.PlanTopologySet

Description: A set that can contain any number of plan topology objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new PlanTopologySet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(PlanTopology item)
      Description: Tests for the existence of an item within the set.
      @item: The item to be searched for.
      Returns: The Contains method returns True if the item is within the set, otherwise False.
    int Erase(PlanTopology item)
      Description: Removes a specified object from the set.
      @item: The item to be erased.
      Returns: The number of items that were erased from the set.
    PlanTopologySetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(PlanTopology item)
      Description: Insert the specified item into the set.
      @item: The item to be inserted into the set.
      Returns: Returns whether the item was inserted into the set.
    PlanTopologySetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PlanTopologySetIterator
Full Name: Autodesk.Revit.DB.PlanTopologySetIterator

Description: An iterator to a set of plan topology objects.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new PlanTopologySetIterator()

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


[ENUM] PlanViewDirection
Full Name: Autodesk.Revit.DB.PlanViewDirection

Description: This enumerated type represents the possible directions for a plan view.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Down = 0
    - Up = 1
    - Undefined = -1


[ENUM] PlanViewPlane
Full Name: Autodesk.Revit.DB.PlanViewPlane

Description: Locations where view range offsets can be specified.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - CutPlane = 0
    - TopClipPlane = 1
    - BottomClipPlane = 2
    - ViewDepthPlane = 3
    - UnderlayBottom = 4


[CLASS] PlanViewRange
Full Name: Autodesk.Revit.DB.PlanViewRange

Description: This class represents the view range of a plan view or a plan region. It records the element ids of the levels which a plane is relative to and the offset of each plane from that level.
Implements: IDisposable

  PROPERTIES:
    static ElementId Current { get; }
      Description: View range for the current plane
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    static ElementId LevelAbove { get; }
      Description: View range for the level above the specified plane
    static ElementId LevelBelow { get; }
      Description: View range for the level below the specified plane
    static ElementId Unlimited { get; }
      Description: View range is unlimited

  METHODS:
    void Dispose()
    ElementId GetLevelId(PlanViewPlane planViewPlane)
      Description: Get the element id of the level for a View Depth plane
      @planViewPlane: The plane whose level will be returned
      Returns: Id of the level
    double GetOffset(PlanViewPlane planViewPlane)
      Description: Get the offset value associated with a View Depth plane
      @planViewPlane: View Depth plane
      Returns: Offset value
    void SetLevelId(PlanViewPlane planViewPlane, ElementId id)
      Description: Set the level for a View Depth plane
      @planViewPlane: The View Depth plane
      @id: Id of the level
    void SetOffset(PlanViewPlane planViewPlane, double offset)
      Description: Set the offset value associated with a View Depth plane
      @planViewPlane: View Depth plane
      @offset: Offset value

--------------------------------------------------------------------------------


[ENUM] PlanViewRangeError
Full Name: Autodesk.Revit.DB.PlanViewRangeError

Description: Describes errors in the location of planes in a PlanViewRange object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TopClipBelowCutPlane = 0
    - BottomClipAboveCutPlane = 1
    - ViewDepthAboveBottomClip = 2
    - ViewDepthBelowTopClip = 3


[ENUM] PlanViewRangeLevel
Full Name: Autodesk.Revit.DB.PlanViewRangeLevel

Description: An enumerated type representing the options for setting the range for a plan view.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Unused = -5
    - Below = -4
    - Current = -3
    - Above = -2
    - Unlimited = -1


[CLASS] Point
Full Name: Autodesk.Revit.DB.Point

Description: A 3D point.
Remarks: The point lies at a given XYZ coordinate location.
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    XYZ Coord { get; }
      Description: Returns the coordinates of the point.
    Reference Reference { get; }
      Description: Returns a stable reference to the point.

  METHODS:
    static Point Create(XYZ coord, ElementId id)
      Description: Creates a point at the given coordinates and assigns it the specified GraphicsStyle.
      @coord: The coordinates where the point will be created.
      @id: The id of the GraphicsStyle element from which to apply the point properties.
      Returns: A Point object.
    static Point Create(XYZ coord)
      Description: Creates a point at the given coordinates.
      @coord: The coordinates where the point will be created.
      Returns: A Point object.

--------------------------------------------------------------------------------


[ENUM] PointCloudColorMode
Full Name: Autodesk.Revit.DB.PointCloudColorMode

Description: Color mode of a point cloud or part of a point cloud
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoOverride = 0
    - FixedColor = 1
    - Elevation = 2
    - Intensity = 3
    - Normals = 4


[ENUM] PointCloudFoundStatus
Full Name: Autodesk.Revit.DB.PointCloudFoundStatus

Description: Enumerated type representing the possible states related to searching for a point cloud file.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Unknown = 0
    - NotFound = 1
    - FoundOK = 2
    - Invalid = 3


[CLASS] PointCloudInstance
Full Name: Autodesk.Revit.DB.PointCloudInstance

Description: Represents a single instance of a point cloud in the Revit document.
Inherits: Instance
Implements: IDisposable

  PROPERTIES:
    SelectionFilterAction FilterAction { get; set; }
      Description: The action taken based on the results of the selection filter applied to this point cloud.
    bool SupportsOverrides { get; }
      Description: Identifies whether the instance can have graphic overrides.

  METHODS:
    bool ContainsScan(string scanName)
      Description: Identifies whether the instance contains a scan.
      @scanName: Name of the scan.
    static PointCloudInstance Create(Document document, ElementId typeId, Transform transform)
      Description: Creates a new instance of a point cloud based on an input point cloud type and transformation.
      @document: The document in which the new instance is created
      @typeId: The element id of the PointCloudType.
      @transform: The transform that defines the placement of the instance in the Revit document coordinate system.
      Returns: The newly created point cloud instance.
    PointCollection GetPoints(PointCloudFilter filter, double averageDistance, int numPoints)
      Description: Extracts a collection of points based on a filter.
      @filter: The filter to control which points are extracted. The filter should be passed in the coordinates of the Revit model.
      @averageDistance: Desired average distance between "adjacent" cloud points (Revit units of length). The smaller the averageDistance the larger number of points will be returned up to the numPoints limit. Specifying this parameter makes actual number of points returned for a given filter independent of the density of coverage produced by the scanner.
      @numPoints: The maximum number of points requested.
      Returns: A collection object containing points that pass the filter, but no more than the maximum number requested.
    IList<string> GetRegions()
      Description: Returns array of region names.
      Returns: Resulting array of region names.
    XYZ GetScanOrigin(string scanName)
      Description: Returns the origin point of a scan in model coordinates.
      @scanName: Name of the scan.
      Returns: Resulting origin point of the scan.
    IList<string> GetScans()
      Description: Returns array of scan names.
      Returns: Resulting array of scan names.
    PointCloudFilter GetSelectionFilter()
      Description: Returns the currently active selection filter for this point cloud.
      Returns: Currently active selection filter or if none is active.
    bool HasColor()
      Description: Returns true if at least one scan of the element have color, false otherwise.
      Returns: True if at least one scan of the element have color, false otherwise.
    void SetSelectionFilter(PointCloudFilter pFilter)
      Description: Sets active selection filter by cloning of the one passed to it.
      @pFilter: The filter object to be made active. If is supplied, the active filter is removed.

--------------------------------------------------------------------------------


[CLASS] PointCloudType
Full Name: Autodesk.Revit.DB.PointCloudType

Description: Represents a type of point cloud loaded into a Revit document. Each PointCloudType maps to a single file or identifier (depending upon the type of Point Cloud Engine which governs it).
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    PointCloudColorEncoding ColorEncoding { get; }
      Description: The color encoding used by points extracted from instances of this point cloud.
    string EngineIdentifier { get; }
      Description: The identifier of the engine responsible for handling of the point cloud.
    PointCloudFoundStatus FoundStatus { get; }
      Description: Shows whether the Point Cloud external file could be found.
    XYZ Offset { get; }
      Description: Returns the offset stored in the point cloud.
    double Scale { get; set; }
      Description: The multiplier applied to the points in all instances of this point cloud.

  METHODS:
    static PointCloudType Create(Document document, string engineIdentifier, string typeIdentifier)
      Description: Creates a new point cloud type for a given point cloud engine.
      @document: The document in which to create the point cloud.
      @engineIdentifier: The string identifying the engine to be invoked. It should be the file extension or engine identifier registered by the third party.
      @typeIdentifier: The file name or the identification string for a non-file based engine.
      Returns: The newly created PointCloudType object to be used to create instances of this point cloud.
    ModelPath GetPath()
      Description: Gets the path of the link source from which the points are loaded.
      Returns: Returns the file path for a file based point cloud or null for the non-file based point cloud.
    RCProject GetReCapProject()
      Description: This method provides a direct entry point to get access to an object from the ReCap SDK (ReCapWrapper.RCProject) from Revit. This object represents the point cloud from the RC file path stored in PointCloudType. The ReCap assembly AdskRcManaged.dll will need to be included into code using this method.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] PointElementReference
Full Name: Autodesk.Revit.DB.PointElementReference

Description: Base class for objects defining a way to constrain a ReferencePoint to one or more other objects in a document.

--------------------------------------------------------------------------------


[CLASS] PointLocationOnCurve
Full Name: Autodesk.Revit.DB.PointLocationOnCurve

Description: Defines the measurement parameters necessary to create a point at a specific location on a curve.
Remarks: The class will store the following and provides functions to deal with them: The user visible Measurement Type (driving parameter type). The corresponding measurement value (driving parameter). MeasureFrom that tells from where the (driving parameter) measurement is calculated.
Implements: IDisposable

  CONSTRUCTORS:
    new PointLocationOnCurve(PointOnCurveMeasurementType measType, double measValue, PointOnCurveMeasureFrom measFrom)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    PointOnCurveMeasureFrom MeasureFrom { get; set; }
      Description: The location on the curve from which the measurement is taken.
    PointOnCurveMeasurementType MeasurementType { get; set; }
      Description: The measurement type.
    double MeasurementValue { get; set; }
      Description: The measurement value.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] PointNode
Full Name: Autodesk.Revit.DB.PointNode

Description: An output node that represents a 3D point.
Remarks: See also: .
Inherits: ModelCurveNode
Implements: IDisposable

  METHODS:
    Point GetPoint()
      Description: Returns the point object corresponding to the node.
      Returns: The point instance.

--------------------------------------------------------------------------------


[ENUM] PointOnCurveMeasureFrom
Full Name: Autodesk.Revit.DB.PointOnCurveMeasureFrom

Description: Point on curve MeasureFrom - It tells from which end of the host curve the point location is measured.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Beginning = 1
    - End = 2


[ENUM] PointOnCurveMeasurementType
Full Name: Autodesk.Revit.DB.PointOnCurveMeasurementType

Description: Point on curve measurement type Defines the types of measurements that may be used when placing a point at a designated distance along a curve.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NonNormalizedCurveParameter = 1
    - NormalizedCurveParameter = 2
    - SegmentLength = 3
    - NormalizedSegmentLength = 4
    - ChordLength = 5
    - Angle = 6


[CLASS] PointOnEdge
Full Name: Autodesk.Revit.DB.PointOnEdge

Description: Define a ReferencePoint relative to a referenceable edge or curve on another element.
Remarks: The ReferencePoint's X basis vector is constrained to the tangent vector to the curve. The Y and Z vectors are free to rotate around the curve.
Inherits: PointElementReference

  PROPERTIES:
    PointLocationOnCurve LocationOnCurve { get; }
      Description: The point location on curve.

  METHODS:
    Reference GetEdgeReference()
      Description: Get a copy of the edge or curve reference.
    void SetEdgeReference(Reference reference)
      Description: Change the edge or curve reference.

--------------------------------------------------------------------------------


[CLASS] PointOnEdgeEdgeIntersection
Full Name: Autodesk.Revit.DB.PointOnEdgeEdgeIntersection

Description: Define a ReferencePoint at the intersection of two referenceable lines.
Remarks: The ReferencePoint is actually placed on the first line (Edge1) at the closest point to the second line (Edge2). Its X basis vector is constrained to be parallel to the first line.
Inherits: PointElementReference

  METHODS:
    Reference GetEdgeReference1()
      Description: Get a copy of the first edge or curve reference.
    Reference GetEdgeReference2()
      Description: Get a copy of the second edge or curve reference.
    void SetEdgeReference1(Reference edgeReference)
      Description: Change the first edge or curve reference.
    void SetEdgeReference2(Reference edgeReference)
      Description: Change the second edge or curve reference.

--------------------------------------------------------------------------------


[CLASS] PointOnEdgeFaceIntersection
Full Name: Autodesk.Revit.DB.PointOnEdgeFaceIntersection

Description: Define a ReferencePoint at the intersection of a referenceable edge or curve and a referenceable face.
Remarks: The ReferencePoint's orientation is partially constrained either to the edge (in the manner of PointOnEdge) or to the face (in the manner of PointOnFace).
Inherits: PointElementReference

  PROPERTIES:
    bool OrientWithEdge { get; set; }
      Description: Whether to orient the ReferencePoint to the edge or the face.

  METHODS:
    Reference GetEdgeReference()
      Description: Get a copy of the edge or curve reference.
    Reference GetFaceReference()
      Description: Get a copy of the face reference.
    void SetEdgeReference(Reference edgeReference)
      Description: Change the edge or curve reference.
    void SetFaceReference(Reference reference)
      Description: Change the face reference.

--------------------------------------------------------------------------------


[CLASS] PointOnFace
Full Name: Autodesk.Revit.DB.PointOnFace

Description: Define a ReferencePoint relative to a Face.
Remarks: A ReferencePoint on a Face has its X and Y basis vectors parallel to the Face, but is free to rotate around its Z basis vector. It must lie on the face (unlike PointOnPlane).
Inherits: PointElementReference

  PROPERTIES:
    UV UV { get; set; }
      Description: The location of the point in the surface's coordinate system.

  METHODS:
    Reference GetFaceReference()
      Description: Get a copy of the face reference.
    void SetFaceReference(Reference reference)
      Description: Change the face reference.

--------------------------------------------------------------------------------


[CLASS] PointOnPlane
Full Name: Autodesk.Revit.DB.PointOnPlane

Description: Define a ReferencePoint relative to a planar reference.
Remarks: A ReferencePoint on a plane has its X and Y basis vectors parallel to the plane, but is free to rotate around its Z basis vector. It can lie on the plane or have an offset.
Inherits: PointElementReference

  PROPERTIES:
    double Offset { get; set; }
      Description: Signed offset from the plane.
    UV Position { get; set; }
      Description: The coordinates of the point (or its projection) on the plane.
    UV XVec { get; set; }
      Description: The X-coordinate vector of the point, in the plane's coordinate system.

  METHODS:
    Reference GetPlaneReference()
      Description: The geometric plane reference.
      Returns: A copy of the reference stored in the PointOnPlane object.
    static bool IsValidPlaneReference(Document doc, Reference planeReference)
      Description: Check whether a geometry reference corresponds to a referenceable plane.
    static PointOnPlane NewPointOnPlane(Document doc, Reference planeReference, XYZ position, XYZ xvec)
      Description: Construct a PointOnPlane given a reference and a location in space.
      @doc: The document containing the plane reference.
      @position: A 3-dimensional position.
      @xvec: The direction of the point's X-coordinate vector in the plane's coordinates. Optional; default value is the X-coordinate vector of the plane.
      Returns: A new PointOnPlane object with 2-dimensional Position, XVec, and Offset properties set to match the given 3-dimensional arguments.
    void SetPlaneReference(Reference planeReference)
      Description: Change the geometric plane reference.
      @planeReference: A reference to some plane in the document. (Note: the reference must satisfy IsValidPlaneReference(), but this is not checked until this PointOnPlane object is assigned to a ReferencePoint.)

--------------------------------------------------------------------------------


[CLASS] PointRelativeToPoint
Full Name: Autodesk.Revit.DB.PointRelativeToPoint

Description: Represents a point placed relative to another point.
Remarks: For this release, the only workflow supported is that the point is placed coincident with the referenced host (a relative transformation of Transform.Identity).
Inherits: PointElementReference

  METHODS:
    Reference GetHostPointReference()
      Description: Get a copy of the host point reference.
    void SetHostPointReference(Reference hostPointReference)
      Description: Change the host point reference.

--------------------------------------------------------------------------------


[CLASS] PolyLine
Full Name: Autodesk.Revit.DB.PolyLine

Description: A polyline.
Remarks: A polyline in space is defined by a set of coordinate points.
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    int NumberOfCoordinates { get; }
      Description: Gets the number of the coordinate points.

  METHODS:
    PolyLine Clone()
      Description: Returns a copy of this polyline.
    static PolyLine Create(IList<XYZ> coordinates)
      Description: Creates a polyline with coordinate points provided.
    XYZ Evaluate(double param)
      Description: Evaluates a parameter on the polyline.
      @param: The parameter to be evaluated. It is expected to be in [0,1] interval mapped to the bounds of the whole polyline.
    XYZ GetCoordinate(int index)
      Description: Gets the coordinate point of the specified index.
      @index: The index of the coordinates.
    IList<XYZ> GetCoordinates()
      Description: Gets the coordinate points of the polyline.
    Outline GetOutline()
      Description: Gets the outline of the polyline.
    PolyLine GetTransformed(Transform transform)
      Description: Gets the copy of the polyline which is applied the specified transformation.

--------------------------------------------------------------------------------


[CLASS] PolylineNode
Full Name: Autodesk.Revit.DB.PolylineNode

Description: An output node that represents a 3D polyline.
Remarks: See also: .
Inherits: ModelCurveNode
Implements: IDisposable

  METHODS:
    PolyLine GetPolyline()
      Description: Returns the polyline object corresponding to the node.
      Returns: The polyline instance.

--------------------------------------------------------------------------------


[CLASS] PolylineSegments
Full Name: Autodesk.Revit.DB.PolylineSegments

Description: An output node that represents a tessellated polyline segments.
Remarks: See also: .
Implements: IDisposable

  PROPERTIES:
    double EndLocalParameter { get; }
      Description: Local parameter associated with the end point.
    double EndParameter { get; }
      Description: Parameter associated with the end point.
    bool IsFilled { get; }
      Description: Indicates whether the area enclosed by the polyline is to be filled or not.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LineProperties LineProperties { get; }
      Description: Access to the line (pen) properties of the polyline
    double StartLocalParameter { get; }
      Description: Local parameter associated with the start point.
    double StartParameter { get; }
      Description: Parameter associated with the start point.

  METHODS:
    void Dispose()
    IList<XYZ> GetVertices()
      Description: Returns an array of vertices of the polyline segments.
      Returns: Array of XYZ points.

--------------------------------------------------------------------------------


[CLASS] PolymeshFacet
Full Name: Autodesk.Revit.DB.PolymeshFacet

Description: A class representing one triangular piece - a facet - in a polymesh topology.
Remarks: It can also be used to create TopographySurface. Each facet is defined by indices of three vertices of the polymesh.

  CONSTRUCTORS:
    new PolymeshFacet(int v1, int v2, int v3)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int V1 { get; }
      Description: The first vertex of the facet
    int V2 { get; }
      Description: The second vertex of the facet
    int V3 { get; }
      Description: The third vertex of the facet

  METHODS:
    IList<int> GetVertices()
      Description: Returns the three vertices that define this facet
    string ToString()
      Description: Returns formatted string showing (V1, V2, V3) with values formatted as regular integers

--------------------------------------------------------------------------------


[CLASS] PolymeshTopology
Full Name: Autodesk.Revit.DB.PolymeshTopology

Description: A class representing topology of a polymesh.
Remarks: Topology of a polymesh consists of a number of points and triangular facets formed by the points. Each facet is determined by three indices to the array of points. A polymesh may have UV coordinates assigned, and always has at least one normal associated. There may be more than one normal available for a non-planar polymesh; there may be as many normals as there are either facets or points in the polymesh. The DistributionOfNormals property indicates how normals are distributed along the polymesh.
Implements: IDisposable

  PROPERTIES:
    DistributionOfNormals DistributionOfNormals { get; }
      Description: Indicates the distribution of normal vectors along the tessellated polymesh surface.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfFacets { get; }
      Description: The number of facet in the polymesh.
    int NumberOfNormals { get; }
      Description: The number of normals associated with the polymesh
    int NumberOfPoints { get; }
      Description: The number of points in the polymesh
    int NumberOfUVs { get; }
      Description: The number of UV coordinates available for the polymesh.

  METHODS:
    void Dispose()
    PolymeshFacet GetFacet(int idx)
      Description: Returns a definition of one facet
      @idx: A zero-based index of the facet
      Returns: An instance of PolymeshFacet that represents one facet defined by 3 vertices of the polymesh.
    IList<PolymeshFacet> GetFacets()
      Description: Returns a definitions of all facets of the polymesh
      Returns: An array of PolymeshFacet instances, each of which represents one facet defined by 3 vertices of the polymesh.
    XYZ GetNormal(int idx)
      Description: Returns a normal vector at the given index
      @idx: A zero-based index
      Returns: XYZ value representing a normal vector
    IList<XYZ> GetNormals()
      Description: Returns all normals assigned to the polymesh
      Returns: An array of XYZ values, each representing a normal vector
    XYZ GetPoint(int idx)
      Description: Returns one point at the given index.
      @idx: A zero-based index of a polymesh point
      Returns: XYZ coordinates of the point
    IList<XYZ> GetPoints()
      Description: Returns all points of the polymesh.
      Returns: An array of XYZ coordinates
    UV GetUV(int idx)
      Description: Returns one UV coordinate at the given index.
      @idx: A zero-based index of a UV coordinate
      Returns: UV coordinates at the given index
    IList<UV> GetUVs()
      Description: Returns all UV coordinates assigned to the polymesh
      Returns: An array of UV coordinates

--------------------------------------------------------------------------------


[ENUM] PreferredJunctionType
Full Name: Autodesk.Revit.DB.PreferredJunctionType

Description: Enumerated type representing the possible options for the preferred junction for a routine preference rule.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Tee = 0
    - Tap = 1


[ENUM] PreviewFamilyVisibilityMode
Full Name: Autodesk.Revit.DB.PreviewFamilyVisibilityMode

Description: Modes that control visibility of family elements depending on the currently applied Element Visibility Settings of a view.
Remarks: Values of this mode can be set or obtained for any view that supports it by accessing the property.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Off = 0
    - On = 1
    - Uncut = 2


[CLASS] PrimaryDesignOptionMemberFilter
Full Name: Autodesk.Revit.DB.PrimaryDesignOptionMemberFilter

Description: A filter used to find elements contained in any primary design option of any design option set.
Remarks: This filter will only pass elements in a primary design option. It will not pass elements in the main model not associated to any design option. This filter is a slow filter. Slow filters require that the Element be obtained and expanded in memory first. Thus it is preferable to couple this filter with at least one ElementQuickFilter, which should minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new PrimaryDesignOptionMemberFilter(bool inverted)
    new PrimaryDesignOptionMemberFilter()

--------------------------------------------------------------------------------


[CLASS] PrimarySizeCriterion
Full Name: Autodesk.Revit.DB.PrimarySizeCriterion

Description: This class contains a size criterion for a RoutingPreferenceRule.
Inherits: RoutingCriterionBase
Implements: IDisposable

  CONSTRUCTORS:
    new PrimarySizeCriterion(double minimumSize, double maximumSize)

  PROPERTIES:
    double MaximumSize { get; set; }
      Description: The maximum size of this criterion.
    double MinimumSize { get; set; }
      Description: The minimum size of this criterion.

  METHODS:
    static PrimarySizeCriterion All()
      Description: Creates a criterion with a range of all sizes.
      Returns: The new criterion.
    static PrimarySizeCriterion None()
      Description: Creates a criterion with a range of no sizes.
      Returns: The new criterion.

--------------------------------------------------------------------------------


[ENUM] PrinterResolution
Full Name: Autodesk.Revit.DB.PrinterResolution

Description: Controls the resolution level in rendering settings.
Remarks: It is applicable only when using printer resolution. The suitable resolution value for each resolution level is decided by default in Revit.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Low = 0
    - Medium = 1
    - High = 2
    - VeryHigh = 3


[CLASS] PrintManager
Full Name: Autodesk.Revit.DB.PrintManager

Description: The PrintManager object is used to configure the global print settings.
Remarks: Global print settings include PrintToFile, CombinedFile, PrintToFileName, PrintRange, CopyNumber, PrintOrderReverse, Collate. Once PrintManager is acquired from a document, changes of its global print setting properties are not automatically applied toward the global print setting. Should the local setting be used, the user needs to call the Apply method. If the user calls SubmitPrint methods, not only that printing will use the current state of properties of the (local) print manager, but the setting will also be applied to the global settings.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    bool Collate { get; set; }
      Description: Indicates whether to collate of the current print.
    bool CombinedFile { get; set; }
      Description: Indicates whether to combine multiple selected views/sheets into a single file.
    int CopyNumber { get; set; }
      Description: The copy number.
    VirtualPrinterType IsVirtual { get; }
      Description: The virtual type in Autodesk Revit.
    PaperSizeSet PaperSizes { get; }
      Description: Get all print sizes of current printer.
    PaperSourceSet PaperSources { get; }
      Description: Get all print sources of current printer.
    string PrinterName { get; }
      Description: The name of the current printer.
    bool PrintOrderReverse { get; set; }
      Description: Indicates whether to reverse the print order of the current print.
    PrintRange PrintRange { get; set; }
      Description: The print range.
    PrintSetup PrintSetup { get; }
      Description: The PrintSetup which manages the print settings of current document.
    bool PrintToFile { get; set; }
      Description: Indicates whether to print to file.
    string PrintToFileName { get; set; }
      Description: The file name when printing to file.
    ViewSheetSetting ViewSheetSetting { get; }
      Description: The ViewSheetSetting which manages the view/sheet set information of current document, and you can change the default view/sheet set for current project.

  METHODS:
    void Apply()
      Description: Apply the local print settings to global for all documents.
    void SelectNewPrintDriver(string strPrinterName)
      Description: Select a new printer.
      @strPrinterName: The name string of new printer.
    bool SubmitPrint(View view)
      Description: Print a view with the current PrintManager settings.
      @view: The User-assigned view.
      Returns: True if successful, otherwise False.
    bool SubmitPrint()
      Description: Print the views and sheets defined in the current local PrintManager settings.
      Returns: True if successful, otherwise False.

--------------------------------------------------------------------------------


[CLASS] PrintParameters
Full Name: Autodesk.Revit.DB.PrintParameters

Description: An object that contains settings used for printing the document.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    ColorDepthType ColorDepth { get; set; }
      Description: The color depth type.
    HiddenLineViewsType HiddenLineViews { get; set; }
      Description: The hidden line views type.
    bool HideCropBoundaries { get; set; }
      Description: Indicates whether to hide crop boundaries when printing.
    bool HideReforWorkPlanes { get; set; }
      Description: Indicates whether to hide reference/work planes when printing.
    bool HideScopeBoxes { get; set; }
      Description: Indicates whether to hide scope boxes when printing.
    bool HideUnreferencedViewTags { get; set; }
      Description: Indicates whether to hide unreferenced view tags when printing.
    MarginType MarginType { get; set; }
      Description: The print margin type.
    bool MaskCoincidentLines { get; set; }
      Description: Indicates whether to mask coincident lines when printing.
    double OriginOffsetX { get; set; }
      Description: The User defined X value of offset from left bottom corner. Unit is feet.
    double OriginOffsetY { get; set; }
      Description: The User defined Y value of offset from left bottom corner. Unit is feet.
    PageOrientationType PageOrientation { get; set; }
      Description: The Page Orientation of the Print Setting.
    PaperPlacementType PaperPlacement { get; set; }
      Description: The paper placement type.
    PaperSize PaperSize { get; set; }
      Description: The page size.
    PaperSource PaperSource { get; set; }
      Description: The page source.
    RasterQualityType RasterQuality { get; set; }
      Description: The raster quality type.
    bool ReplaceHalftoneWithThinLines { get; set; }
      Description: Indicates whether to replace halftone with thin lines when printing.
    double UserDefinedMarginX { get; set; }
      Description: The User defined X value of offset from left bottom corner. Unit is inch.
    double UserDefinedMarginY { get; set; }
      Description: The User defined Y value of offset from left bottom corner. Unit is inch.
    bool ViewLinksinBlue { get; set; }
      Description: Indicates whether to view links in blue when printing.
    int Zoom { get; set; }
      Description: The zoom value to a percentage of the original size.
    ZoomType ZoomType { get; set; }
      Description: The zoom type.

--------------------------------------------------------------------------------


[ENUM] PrintRange
Full Name: Autodesk.Revit.DB.PrintRange

Description: An enumerated type listing all Print Range types of Print.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Current = 0
    - Visible = 1
    - Select = 2


[CLASS] PrintSetting
Full Name: Autodesk.Revit.DB.PrintSetting

Description: Represents the Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.
Inherits: Element
Implements: IDisposable, IPrintSetting

  PROPERTIES:
    string Name { get; set; }
      Description: Returns the Name of Print Setup.
    PrintParameters PrintParameters { get; }
      Description: Returns the Parameters of Print Setup.

--------------------------------------------------------------------------------


[CLASS] PrintSetup
Full Name: Autodesk.Revit.DB.PrintSetup

Description: Represents the Print Setup (Application Menu->Print->Print Setup) within Autodesk Revit.
Remarks: The Print Setup object can only get from PrintManager object.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    IPrintSetting CurrentPrintSetting { get; set; }
      Description: The current Print Setting of Print Setup.
    InSessionPrintSetting InSession { get; }
      Description: The in-session Print Setting of Print Setup.

  METHODS:
    bool Delete()
      Description: Delete the current print setting, and make the In-Session setting as the current one.
      Returns: False if Delete operation fails, otherwise true.
    bool Rename(string newName)
      Description: Rename the current print setting with the specified name.
      @newName: print setting name to be renamed as.
      Returns: False if Rename operation fails, otherwise true.
    void Revert()
      Description: Revert the current print setting.
    bool Save()
      Description: Save the changes for the current print setting.
      Returns: False if save operation fails, otherwise True.
    bool SaveAs(string newName)
      Description: Save the current print setting to another print setting with the specified name.
      @newName: print setting name to be saved as.
      Returns: False if Save As operation fails, otherwise true.

--------------------------------------------------------------------------------


[CLASS] Profile
Full Name: Autodesk.Revit.DB.Profile

Description: A geometric profile consisting of a loop of curves.
Remarks: The profile may be filled.
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    CurveArray Curves { get; }
      Description: Retrieve the curves that make up the boundary of the profile.
    bool Filled { get; set; }
      Description: Get or set whether the profile is filled.
    Profile Transformed { get; }

  METHODS:
    Profile Clone()
      Description: Returns a copy of this profile.

--------------------------------------------------------------------------------


[ENUM] ProfileFamilyUsage
Full Name: Autodesk.Revit.DB.ProfileFamilyUsage

Description: An enumerated type listing all types of profile families.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Any = 0
    - WallSweep = 1
    - Reveal = 2
    - Fascia = 3
    - Gutter = 4
    - SlabEdge = 5
    - Railing = 6
    - StairNosing = 7
    - Mullion = 8
    - SlabMetalDeck = 9
    - ContinuousFooting = 10
    - StairTread = 11
    - StairRiser = 12
    - StairSupport = 13


[ENUM] ProfilePlaneLocation
Full Name: Autodesk.Revit.DB.ProfilePlaneLocation

Description: Indicates the location of Sweep profile plane on the path curve.
Remarks: Use this enum in the NewSweep() method to create generic forms.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Start = 0
    - MidPoint = 1
    - End = 2


[CLASS] ProjectInfo
Full Name: Autodesk.Revit.DB.ProjectInfo

Description: An object that represents a Project Information within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string Address { get; set; }
      Description: Get or Set the Project Address of the Project Information.
    string Author { get; set; }
      Description: Get or Set the Project Author of the Project Information.
    string BuildingName { get; set; }
      Description: Get or Set the Building Name of the Project Information.
    string ClientName { get; set; }
      Description: Get or Set the Client Name of the Project Information.
    string IssueDate { get; set; }
      Description: Get or Set the Project Issue Date of the Project Information.
    string Name { get; set; }
      Description: Get or Set the Project Name of the Project Information.
    string Number { get; set; }
      Description: Get or Set the Project Number of the Project Information.
    string OrganizationDescription { get; set; }
      Description: Get or Set the Organization Description of the Project Information.
    string OrganizationName { get; set; }
      Description: Get or Set the Organization Name of the Project Information.
    string Status { get; set; }
      Description: Get or Set the Project Status of the Project Information.

--------------------------------------------------------------------------------


[CLASS] ProjectLocation
Full Name: Autodesk.Revit.DB.ProjectLocation

Description: A representation of a specific instance and location of the current project.
Remarks: When using shared coordinates, ProjectLocations can be used to specify specific locations for instances of a linked model. A ProjectLocation keeps track of the position of an instance in relationship to the project's SiteLocation.By default, each Revit project contains at least one named location, called Internal. Existing ProjectLocation objects can be found by using the ProjectLocations property on the Document object. New project locations can be created by duplicating an existing project location using the Duplicate method, and modifying the location's project position. See also
Inherits: Instance
Implements: IDisposable

  METHODS:
    static ProjectLocation Create(Document document, ElementId siteLocationId, string name)
      Description: Create an instance of ProjectLocation in the document.
      @document: The document where the new instance of ProjectLocation would be created in.
      @siteLocationId: The ElementId of the SiteLocation to which the new ProjectLocation would be created.
      @name: The name of the instance of ProjectLocation to be created.
      Returns: The newly created instance of ProjectLocation.
    ProjectLocation Duplicate(string name)
      Description: Generate a copy of this project location with the specified name.
      Returns: A new ProjectLocation which is a duplicate of this location, with the input name.
    ProjectPosition GetProjectPosition(XYZ point)
      Description: Gets the coordinates of a point in the ProjectLocation's coordinate system.
    SiteLocation GetSiteLocation()
      Description: Gets the site location to which this project location refers.
    static bool IsProjectLocationNameUnique(Document document, string name, ElementId siteLocationId)
      Description: Verifies that there is no existing ProjectLocation with the given name belonging to the given SiteLocation.
      @document: The document to check.
      @name: The name to check.
      @siteLocationId: The ElementId of the SiteLocation which the ProjectLocation belongs to.
      Returns: True if the name is unused (among ProjectLocations). False otherwise.
    void SetProjectPosition(XYZ point, ProjectPosition position)
      Description: Sets the coordinates of a point in the ProjectLocation's coordinate system.

--------------------------------------------------------------------------------


[CLASS] ProjectLocationSet
Full Name: Autodesk.Revit.DB.ProjectLocationSet

Description: An set that contains project locations.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ProjectLocationSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of project locations that are in the set.

  METHODS:
    void Clear()
      Description: Removes every project location from the set, rendering it empty.
    bool Contains(ProjectLocation item)
      Description: Tests for the existence of a project location within the set.
      @item: The project location to be searched for.
      Returns: The Contains method returns True if the project location is within the set, otherwise False.
    int Erase(ProjectLocation item)
      Description: Removes a specified project location from the set.
      @item: The project location to be erased.
      Returns: The number of project locations that were erased from the set.
    ProjectLocationSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(ProjectLocation item)
      Description: Insert the specified project location into the set.
      @item: The project location to be inserted into the set.
      Returns: Returns whether the project location was inserted into the set.
    ProjectLocationSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ProjectLocationSetIterator
Full Name: Autodesk.Revit.DB.ProjectLocationSetIterator

Description: An iterator to a project location set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ProjectLocationSetIterator()

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


[CLASS] ProjectPosition
Full Name: Autodesk.Revit.DB.ProjectPosition

Description: ProjectPosition is a class used to represent a geographical offset and rotation. It can be used to represent the position of a project.
Implements: IDisposable

  CONSTRUCTORS:
    new ProjectPosition(double ew, double ns, double elevation, double angle)
    new ProjectPosition(ProjectPosition other)

  PROPERTIES:
    double Angle { get; set; }
      Description: Angle from True North.
    double EastWest { get; set; }
      Description: East/West offset.
    double Elevation { get; set; }
      Description: Elevation above ground level.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double NorthSouth { get; set; }
      Description: North/South offset

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] PropertyLine
Full Name: Autodesk.Revit.DB.PropertyLine

Description: Represents kinds of PropertyLines.
Inherits: Element
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] PropertySetElement
Full Name: Autodesk.Revit.DB.PropertySetElement

Description: An element that groups together a set of related parameters.
Inherits: Element
Implements: IDisposable

  METHODS:
    static PropertySetElement Create(Document document, ThermalAsset thermalAsset)
      Description: Creates a new PropertySetElement to contain the given asset.
      @document: The document in which to create the PropertySetElement.
      @thermalAsset: The thermal asset containing the values that will be present in the PropertySetElement.
      Returns: The new PropertySetElement.
    static PropertySetElement Create(Document document, StructuralAsset structuralAsset)
      Description: Creates a new PropertySetElement to contain the given asset.
      @document: The document in which to create the PropertySetElement.
      @structuralAsset: The structural asset containing the values that will be present in the PropertySetElement.
      Returns: The new PropertySetElement.
    PropertySetElement Duplicate(Document document, string name)
      Description: Creates a duplicate of this PropertySetElement.
      @document: The document in which to create the PropertySetElement.
      @name: The name to use for the new PropertySetElement.
      Returns: The new PropertySetElement.
    StructuralAsset GetStructuralAsset()
      Description: Gets a copy of the StructuralAsset.
    ThermalAsset GetThermalAsset()
      Description: Gets a copy of the ThermalAsset.
    void SetStructuralAsset(StructuralAsset structuralAsset)
      Description: Sets a copy of the given StucturalAsset to be used in the PropertySetElement.
    void SetThermalAsset(ThermalAsset thermalAsset)
      Description: Sets a copy of the given ThermalAsset to be used in the PropertySetElement.

--------------------------------------------------------------------------------


[ENUM] PropOverrideMode
Full Name: Autodesk.Revit.DB.PropOverrideMode

Description: An enumerated type listing ways how overridden object styles get exported.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ByEntity = 0
    - ByLayer = 1
    - NewLayer = 2

