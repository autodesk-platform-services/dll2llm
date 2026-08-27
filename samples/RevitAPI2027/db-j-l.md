# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[ABSTRACT CLASS] JoinGeometryUtils
Full Name: Autodesk.Revit.DB.JoinGeometryUtils
Description: Utilities for joining and unjoining elements, and for managing the order in which elements are joined.

  METHODS:
    static bool AreElementsJoined(Document document, Element firstElement, Element secondElement)
      Description: Determines whether two elements are joined.
      @document: The document containing the two elements.
      @firstElement: The first element.
      @secondElement: The second element.
      Returns: True if the two elements are joined.
      Throws ArgumentException: document is not a project document. -or- The element firstElement was not found in the given document. -or- The element secondElement was not found in the given document.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetJoinedElements(Document document, Element element)
      Description: Returns all elements joined to given element.
      @document: The document containing the element.
      @element: The element.
      Returns: The set of elements that are joined to the given element.
      Throws ArgumentException: document is not a project document. -or- The element element was not found in the given document.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsCuttingElementInJoin(Document document, Element firstElement, Element secondElement)
      Description: Determines whether the first of two joined elements is cutting the second element.
      @document: The document containing the two elements.
      @firstElement: The first element.
      @secondElement: The second element.
      Returns: True if the secondElement is cut by the firstElement, false if the secondElement is cut by the firstElement.
      Throws ArgumentException: document is not a project document. -or- The element firstElement was not found in the given document. -or- The element secondElement was not found in the given document. -or- The elements are not joined.
      Throws ArgumentNullException: A non-optional argument was null
    static void JoinGeometry(Document document, Element firstElement, Element secondElement)
      Description: Creates clean joins between two elements that share a common face.
      @document: The document containing the two elements.
      @firstElement: The first element to be joined.
      @secondElement: The second element to be joined. This element must not be joined to the first element.
      Throws ArgumentException: document is not a project document. -or- The element firstElement was not found in the given document. -or- The element secondElement was not found in the given document. -or- The elements are already joined. -or- The elements cannot be joined.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Please remove or add segments on curtain grids instead of joining or unjoining geometry of the panels.
    static void SwitchJoinOrder(Document document, Element firstElement, Element secondElement)
      Description: Reverses the order in which two elements are joined.
      @document: The document containing the two elements.
      @firstElement: The first element.
      @secondElement: The second element. This element must be joined to the first element.
      Throws ArgumentException: document is not a project document. -or- The element firstElement was not found in the given document. -or- The element secondElement was not found in the given document. -or- The elements are not joined. -or- The elements cannot be joined.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Unable to switch the join order of these elements.
    static void UnjoinGeometry(Document document, Element firstElement, Element secondElement)
      Description: Removes a join between two elements.
      @document: The document containing the two elements.
      @firstElement: The first element to be unjoined.
      @secondElement: The second element to be unjoined. This element must be joined to the fist element.
      Throws ArgumentException: document is not a project document. -or- The element firstElement was not found in the given document. -or- The element secondElement was not found in the given document. -or- The elements are not joined. -or- The elements cannot be unjoined.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Please remove or add segments on curtain grids instead of joining or unjoining geometry of the panels.

--------------------------------------------------------------------------------

[ENUM] JoinType
Full Name: Autodesk.Revit.DB.JoinType
Description: The type of join at the end of an element. The join type affects only the graphic treatment, i.e. cleaning of the end, not the physical join behavior.
Inherits: Enum

  Values:
    - Abut = 0
    - Miter = 1
    - SquareOff = 2
    - Extension = 3
    - None = -1

--------------------------------------------------------------------------------

[ENUM] JunctionType
Full Name: Autodesk.Revit.DB.JunctionType
Description: An enumerated type listing all the junction types for MEP curve types.
Inherits: Enum

  Values:
    - Tap = 0
    - Tee = 1

--------------------------------------------------------------------------------

[CLASS] KeyBasedTreeEntries
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntries
Description: A collection of KeyBasedTreeEntry objects that make up the key-based tree.
Implements: IEnumerable<KeyBasedTreeEntry>, IEnumerable, IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    KeyBasedTreeEntry FindEntry(string key)
      Description: Finds the KeyBasedTreeEntry associated with the given key value.
      @key: The specified key value.
      Returns: The KeyBasedTreeEntry corresponds to the given key value.
      Throws ArgumentException: key is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
    IEnumerator<KeyBasedTreeEntry> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    KeyBasedTreeEntriesIterator GetKeyBasedTreeEntriesIterator()
      Description: Returns a KeyBasedTreeEntriesIterator that iterates through the collection.
      Returns: A KeyBasedTreeEntriesIterator object that can be used to iterate through KeyBasedTreeEntry objects in the collection.

--------------------------------------------------------------------------------

[CLASS] KeyBasedTreeEntriesIterator
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntriesIterator
Description: An iterator to a set of KeyBasedTreeEntry objects.
Implements: IEnumerator<KeyBasedTreeEntry>, IDisposable, IEnumerator

  PROPERTIES:
    KeyBasedTreeEntry Current { get; }
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

[CLASS] KeyBasedTreeEntriesLoadContent
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntriesLoadContent
Description: This class is used by IExternalResourceServers to return KeyBasedTreeEntries data to Revit when their LoadResource method is invoked.
Remarks: The class contains a KeyBasedTreeEntries object which should hold the KeyBasedTreeEntries data generated by the IExternalResourceServer.An ExternalResourceServer can create the KeyBasedTreeEntries from an arbitrary data source by using AddEntry to add individual KeyBasedTreeEntries. Once all the desired entries have been added, BuildEntries can be called to construct the KeyBasedTreeEntries object from the individual entries that were added.KeyBasedTreeEntriesLoadContent must have a built KeyBasedTreeEntries before its LoadStatus property can be set to ExternalResourceLoadStatus.Success.
Inherits: ExternalResourceLoadContent

  METHODS:
    bool AddEntry(KeyBasedTreeEntry entry)
      Description: Adds one KeyBasedTreeEntry to this KeyBasedTreeEntriesLoadContent, which is used to build a KeyBasedTreeEntries object by BuildEntries function.
      @entry: The entry to be added.
      Returns: Returns true if an entry is added into the entry data set successfully, returns false if an entry fails to be added because this entry is invalid or a duplicate of one in the entry data set.
      Throws ArgumentException: The KeyBasedTreeEntry object is not appropriate to be added in this KeyBasedTreeEntriesLoadContent.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object is built already. Adding more KeyBasedTreeEntries as well as repeated building, is not supported.
    void BuildEntries()
      Description: Builds a KeyBasedTreeEntries object.
      Throws InvalidOperationException: The KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object is built already. Adding more KeyBasedTreeEntries as well as repeated building, is not supported.
    bool CanAddEntry(KeyBasedTreeEntry entry)
      Description: Verifies if the KeyBasedTreeEntry could be added in this KeyBasedTreeEntriesLoadContent.
      @entry: The KeyBasedTreeEntry object to be checked.
      Returns: True if the KeyBasedTreeEntry could be added in, otherwise false.
      Throws ArgumentNullException: A non-optional argument was null
    KeyBasedTreeEntries GetEntries()
      Description: Gets a copy of KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object.
      Returns: A copy of KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object.
      Throws InvalidOperationException: The KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object is not built yet. The information about this KeyBasedTreeEntries object is not available.
    KeyBasedTreeEntriesLoadResults GetLoadResults()
      Description: Returns a copy of the KeyBasedTreeEntriesLoadResults owned by this KeyBasedTreeEntriesLoadContent object.
      Returns: A copy of a KeyBasedTreeEntriesLoadResults owned by this KeyBasedTreeEntriesLoadContent object.
    static bool IsEntriesBuilt(KeyBasedTreeEntriesLoadContent content)
      Description: Verifies that the KeyBasedTreeEntries object owned by a KeyBasedTreeEntriesLoadContent object is built.
      @content: The KeyBasedTreeEntriesLoadContent object to be checked.
      Returns: True if the KeyBasedTreeEntries object is built already, otherwise false.
      Throws ArgumentNullException: A non-optional argument was null
    void Reset()
      Description: Clears KeyBasedTreeEntriesLoadContent object, including KeyBasedTreeEntries and KeyBasedTreeEntriesLoadResults, owned by this KeyBasedTreeEntriesLoadContent object.

--------------------------------------------------------------------------------

[CLASS] KeyBasedTreeEntriesLoadResults
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntriesLoadResults
Description: This class contains the results and status information regarding an attempt to load the KeyBasedTreeEntries from an External Resource.
Remarks: A KeyBasedTreeEntriesLoadResults object is returned by the KeynoteTable or AssemblyCodeTable API methods LoadFrom() and Reload() so that callers can determine whether the KeynoteTable or AssemblyCodeTable was updated successfully and what, if any, errors occurred.
Implements: IDisposable

  CONSTRUCTORS:
    new KeyBasedTreeEntriesLoadResults()
      Description: Creates an empty KeyBasedTreeEntriesLoadResults.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<FailureMessage> GetFailureMessages()
      Description: Get all error or warnings created while attempting to load KeyBasedTreeEntries.
      Returns: A collection of FailureMessage objects, if any errors or warnings were encountered while loading and building the KeyBasedTreeEntries.
    IList<string> GetFileReadErrors()
      Description: Gets the names of any files which could not be read due to access errors.
      Returns: An array of strings containing the filenames of files which could not be read.
    IList<string> GetFileSyntaxErrors()
      Description: Gets all the records in the key-based tree data text file that could not be parsed into KeyBasedTreeEntries.
      Returns: An array of strings that are copies of the records in the text file that could not be parsed.
    IList<KeyBasedTreeEntryError> GetKeyBasedTreeEntryErrors(KeyBasedTreeEntryErrorType type)
      Description: Gets information about specific KeyBasedTreeEntry objects that could not be included in the KeyBasedTreeEntries object due to errors of a particular type.
      @type: The type of KeyBasedTreeEntryError to be returned.
      Returns: An array of copies of the KeyBasedTreeEntryErrors contained in this object matching the type specified.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<KeyBasedTreeEntryError> GetKeyBasedTreeEntryErrors()
      Description: Gets information about KeyBasedTreeEntry objects that could not be included in the KeyBasedTreeEntries object due to errors.
      Returns: An array of copies of the KeyBasedTreeEntryErrors contained in this object.

--------------------------------------------------------------------------------

[CLASS] KeyBasedTreeEntry
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntry
Description: A key-based tree entry, containing the key, parent key, and children keys (if applicable).
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Key { get; }
      Description: The key of this entry.
    string ParentKey { get; }
      Description: The parent key of this entry.

  METHODS:
    void Dispose()
    IList<string> GetChildrenKeys()
      Description: Gets a collection containing the keys of all children entry objects from this entry.
      Returns: The collection containing the keys of all children entry objects from this entry.

--------------------------------------------------------------------------------

[CLASS] KeyBasedTreeEntryError
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntryError
Description: This class contains information about a problem encountered while creating a KeyBasedTreeEntries object.
Remarks: This problem might be a duplicate entry, or an error in the specified parent-child relationships, or something else. See BuiltInKeyBasedTreeEntryErrorType for details.
Implements: IDisposable

  PROPERTIES:
    KeyBasedTreeEntryErrorType ErrorType { get; }
      Description: Indicates which of possible types of problems with loading and/or building a KeyBasedTreeEntries that this KeyBasedTreeEntryError represents.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    KeyBasedTreeEntry GetEntry()
      Description: Gets the entry for which an error occurred while building the KeyBasedTreeEntries object.
      Returns: A copy of the KeyBasedTreeEntry.

--------------------------------------------------------------------------------

[ENUM] KeyBasedTreeEntryErrorType
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntryErrorType
Description: An Enum indicating the type of error associated with a KeyBasedTreeEntry.
Inherits: Enum

  Values:
    - DuplicateEntry = 0
    - MissingParent = 1
    - CircularParentage = 2
    - InvalidClassificationCode = 3
    - BadClassificationLevel = 4
    - BadClassificationCategoryId = 5

--------------------------------------------------------------------------------

[CLASS] KeyBasedTreeEntryTable
Full Name: Autodesk.Revit.DB.KeyBasedTreeEntryTable
Description: KeyBasedTreeEntryTable represents the collection of key-based tree entries for a document.
Inherits: Element

  METHODS:
    KeyBasedTreeEntries GetKeyBasedTreeEntries()
      Description: Gets the KeyBasedTreeEntries for this table.
      Returns: The KeyBasedTreeEntries for this table.
    ExternalResourceLoadStatus LoadFrom(ExternalResourceReference desiredResourceReference, KeyBasedTreeEntriesLoadResults loadResults)
      Description: Loads KeyBasedTreeEntries from the specified external resource into this KeyBasedTreeEntryTable.
      @desiredResourceReference: An external resource reference describing the source of the desired KeyBasedTreeEntry data.
      @loadResults: If provided, Revit will use this object to store any errors or warnings that were encountered.This argument may be .
      Returns: Returns whether the operation succeeded or failed.
      Throws ArgumentException: The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support the ExternalResourceReferenceType of this KeyBasedTreeEntryTable. -or- The ExternalResourceReference (desiredResourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document containing this KeyBasedTreeEntryTable is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this KeyBasedTreeEntryTable is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this KeyBasedTreeEntryTable has no open transaction.
    ExternalResourceLoadStatus Reload(KeyBasedTreeEntriesLoadResults loadResults)
      Description: Reloads KeyBasedTreeEntries from their currently-stored location into this KeyBasedTreeEntryTable.
      @loadResults: If provided, Revit will use this object to store any errors or warnings that were encountered. Note that if the KeyBasedTreeEntries in the model are already up to date, no errors or warnings will be added to this object.This argument may be .
      Returns: Returns the outcome of the reload operation.
      Throws ModificationForbiddenException: The document containing this KeyBasedTreeEntryTable is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this KeyBasedTreeEntryTable is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this KeyBasedTreeEntryTable has no open transaction.
    bool ServerSupports(ExternalResourceReference extRef)
      Description: Checks if the server referenced by the given ExternalResourceReference supports the ExternalResourceReferenceType of this KeyBasedTreeEntryTable.
      @extRef: The ExternalResourceReference to check.
      Returns: True if the ExternalResourceReference refers to a server that supports the ExternalResourceReferenceType of this KeyBasedTreeEntryTable. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] KeynoteEntries
Full Name: Autodesk.Revit.DB.KeynoteEntries
Description: A collection of KeynoteEntry objects that make up the keynote table.
Inherits: KeyBasedTreeEntries

  METHODS:
    static bool LoadKeynoteEntriesFromFile(string filePath, KeyBasedTreeEntriesLoadContent keynoteContent)
      Description: Loads the contents of a keynote text file into the provided KeyBasedTreeEntriesLoadContent.
      @filePath: The full path of the existing keynotefile.
      @keynoteContent: The keynote entries read from the filePath will be added to this object. A KeyBasedTreeEntriesLoadContent object will also be updated to contain status information, including information about any errors that occurred while reading the keynote entries from the specified file.
      Returns: True if reading the keynote file succeeds; False if the keynote file cannot be read.
      Throws ArgumentException: filePath is an empty string. -or- The KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object is built already. Adding more KeyBasedTreeEntries as well as repeated building, is not supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidPathArgumentException: The destination file name includes one or more invalid characters.

--------------------------------------------------------------------------------

[CLASS] KeynoteEntry
Full Name: Autodesk.Revit.DB.KeynoteEntry
Description: Represents an entry in the keynote table, containing the key value, keynote text, and parent key (if applicable).
Inherits: KeyBasedTreeEntry

  CONSTRUCTORS:
    new KeynoteEntry(string key, string text)
      Description: Constructs a new KeynoteEntry from the given key name and keynote text. KeynoteEntry objects created from this constructor will not have parents.
      @key: The key of this KeynoteEntry
      @text: The text associated with this KeynoteEntry
      Throws ArgumentException: key is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
    new KeynoteEntry(string key, string parentKey, string text)
      Description: Constructs a new KeynoteEntry from the given key name, parent key name, and keynote text.
      @key: The key of this KeynoteEntry.
      @parentKey: The parent key of this KeynoteEntry. Empty string means this KeynoteEntry does not have a parent.
      @text: The text associated with this KeynoteEntry
      Throws ArgumentException: key is an empty string.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    string KeynoteText { get; }
      Description: The text associated with this KeynoteEntry.

--------------------------------------------------------------------------------

[CLASS] KeynoteTable
Full Name: Autodesk.Revit.DB.KeynoteTable
Description: KeynoteTable represents the collection of keynotes (KeynoteEntries) for a document.
Inherits: KeyBasedTreeEntryTable

  METHODS:
    static KeynoteTable GetKeynoteTable(Document aDoc)
      Description: Gets the KeynoteTable from a Revit document.
      @aDoc: The Revit document.
      Returns: The KeynoteTable.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] LabelType
Full Name: Autodesk.Revit.DB.LabelType
Description: The label type in dimension equality formats.
Inherits: Enum

  Values:
    - NumberOfWitnessLines = 0
    - NumberOfSegments = 1
    - LengthOfSegment = 2
    - TotalLength = 3

--------------------------------------------------------------------------------

[CLASS] LabelUtils
Full Name: Autodesk.Revit.DB.LabelUtils
Description: Used to obtain user-visible names for enums.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static string GetFailureSeverityName(FailureSeverity failureSeverity)
      Description: Gets the user-visible name for the Severity of a Warning
      @failureSeverity: The Severity enum value
      Returns: Returns the user-visible name for the Severity of a Warning.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static string GetLabelFor(gbXMLBuildingType buildingType, Document document)
      Description: Gets the user-visible name for a gbXMLBuildingType.
      @buildingType: The gbXMLBuildingType to get the user-visible name.
      @document: The document from which to get the gbXMLBuildingType.
      Returns: Returns the user-visible name for a buildingType in gbXML.
      Throws ArgumentException: The input gXMLBuildingType is not available in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static string GetLabelFor(PipeFlowState pipeFlowState, Document doc)
      Description: Gets the user-visible name for a PipeFlowState.
      @pipeFlowState: The PipeFlowState to get the user-visible name.
      @doc: The document from which to get the PipeFlowState.
      Throws InvalidOperationException: Thrown when information for the input PipeFlowState cannot be found.
    static string GetLabelFor(PipeLossMethodType pipeLossMethodType, Document doc)
      Description: Gets the user-visible name for a PipeLossMethodType.
      @pipeLossMethodType: The PipeLossMethodType to get the user-visible name.
      @doc: The document from which to get the PipeLossMethodType.
      Throws InvalidOperationException: Thrown when information for the input PipeLossMethodType cannot be found.
    static string GetLabelFor(DuctLossMethodType ductLossMethodType, Document doc)
      Description: Gets the user-visible name for a DuctLossMethodType.
      @ductLossMethodType: The DuctLossMethodType to get the user-visible name.
      @doc: The document from which to get the DuctLossMethodType.
      Throws InvalidOperationException: Thrown when information for the input DuctLossMethodType cannot be found.
    static string GetLabelFor(BuiltInCategory builtInCategory)
      Description: Gets the user-visible name for a BuiltInCategory.
      @builtInCategory: The BuiltInCategory to get the user-visible name.
      Throws InvalidOperationException: Thrown when the builtin category is not valid.
    static string GetLabelFor(BuiltInParameter builtInParam, LanguageType language)
      Description: Gets the user-visible name for a BuiltInParameter in a specific LanguageType.
      @builtInParam: The BuiltInParameter to get the user-visible name.
      @language: The desired LanguageType to get the user-visible name in.
      Returns: The BuiltInParameter name in the desired LanguageType.
      Throws InvalidOperationException: Thrown when the BuiltInParameter cannot be found.
      Throws InvalidOperationException: Thrown when the desired LanguageType cannot be found for the BuiltInParameter name.
    static string GetLabelFor(BuiltInParameter builtInParam)
      Description: Gets the user-visible name for a BuiltInParameter.
      @builtInParam: The BuiltInParameter to get the user-visible name.
      Throws InvalidOperationException: Thrown when the BuiltInParameter cannot be found.
    static string GetLabelForBuiltInParameter(ForgeTypeId parameterTypeId, LanguageType language)
      Description: Gets the user-visible name for a built-in parameter in a specific LanguageType.
      @parameterTypeId: Identifier of the built-in parameter to get the user-visible name.
      @language: The desired LanguageType to get the user-visible name in.
      Returns: The built-in parameter name in the desired LanguageType.
      Throws InvalidOperationException: Thrown when the built-in parameter cannot be found.
      Throws InvalidOperationException: Thrown when the desired LanguageType cannot be found for the built-in parameter name.
    static string GetLabelForBuiltInParameter(ForgeTypeId parameterTypeId)
      Description: Gets the user-visible name for a built-in parameter.
      @parameterTypeId: Identifier of the built-in parameter to get the user-visible name.
      Throws InvalidOperationException: Thrown when the built-in parameter cannot be found.
    static string GetLabelForDiscipline(ForgeTypeId disciplineTypeId)
      Description: Gets the user-visible name for a discipline.
      @disciplineTypeId: Identifier of the discipline.
      Returns: Returns the user-visible name for a discipline.
      Throws ArgumentException: Discipline must have a definition.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetLabelForGroup(ForgeTypeId groupTypeId)
      Description: Gets the user-visible name for a built-in parameter group. To get the name of parameter group "Other", pass an empty, default-constructed ForgeTypeId.
      @groupTypeId: The identifier of the parameter group to get the user-visible name, or an empty ForgeTypeId for group "Other".
    static string GetLabelForSpec(ForgeTypeId specTypeId)
      Description: Gets the user-visible name for a spec.
      @specTypeId: Identifier of the spec to get the user-visible name.
      Returns: Returns the user-visible name for a spec.
      Throws ArgumentException: The given identifier is neither a spec nor a category.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetLabelForSymbol(ForgeTypeId symbolTypeId)
      Description: Gets the user-visible name for a symbol.
      @symbolTypeId: Identifier of the symbol to get the user-visible name.
      Returns: Returns the user-visible name for a symbol.
      Throws ArgumentException: Symbol must have a definition.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetLabelForUnit(ForgeTypeId unitTypeId)
      Description: Gets the user-visible name for a unit.
      @unitTypeId: Identifier of the unit to get the user-visible name.
      Returns: Returns the user-visible name for a unit.
      Throws ArgumentException: Cannot find DisplayUnitTypeInfo for the given unit identifier.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetStructuralSectionShapeName(StructuralSectionShape shape)
      Description: Gets the user-visible name for a StructuralSectionShape.
      @shape: The StructuralSectionShape to get the user-visible name.
      Returns: Returns the user-visible name for the StructuralSectionShape.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] LayerCategoryType
Full Name: Autodesk.Revit.DB.LayerCategoryType
Description: An enumerated type listing category types supported in an ExportLayerTable.
Inherits: Enum

  Values:
    - Model = 0
    - Annotation = 1
    - AnalyticalModel = 2
    - Imported = 3
    - Modifier = 4
    - Unsorted = -1

--------------------------------------------------------------------------------

[CLASS] LayerModifier
Full Name: Autodesk.Revit.DB.LayerModifier
Description: A modifier used to designate extra strings to appear in the exported layer name.
Remarks: A modifier consists of a type (from ModifierType and an optional separator. Apply a modifier to one or more ExportLayerInfo objects to modify the layer name that will be assigned when a Revit object is exported.
Implements: IDisposable

  CONSTRUCTORS:
    new LayerModifier(ModifierType modifierType, string separator)
      Description: Constructs a new LayerModifier with modifierType and separator.
      @modifierType: The modifier type.
      @separator: The separator string that will follow this modifier in the export layer name.
      Throws ArgumentException: The provided separator contains invalid characters (most special characters are invalid).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new LayerModifier()
      Description: Constructs a new LayerModifier with default values.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ModifierType ModifierType { get; set; }
      Description: The modifier type of LayerModifier.
    string Separator { get; set; }
      Description: The separator string that will follow this modifier in the export layer name.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] LayoutRule
Full Name: Autodesk.Revit.DB.LayoutRule
Description: The LayoutRule object is a base object for all type of layout rules for Beam System within the Autodesk Revit API.
Remarks: This class just used as the base class of those concrete LayoutRule classes.
Inherits: APIObject

--------------------------------------------------------------------------------

[CLASS] LayoutRuleClearSpacing
Full Name: Autodesk.Revit.DB.LayoutRuleClearSpacing
Description: This class indicate the layout rule of a Beam System is Clear-Spacing.
Remarks: To use this type of LayoutRule, the distance between the beams and the justify-type must be set.
Inherits: LayoutRule

  CONSTRUCTORS:
    new LayoutRuleClearSpacing(double spacing, BeamSystemJustifyType justifyType)
      Description: Constructor of LayoutRuleFixedDistance. Create LayoutRuleFixedDistance with the values passed in.
      @spacing: The value of spacing must be in [0, 30000).
      @justifyType: The type of the justification, it's corresponding to the items in the element properties dialog.

  PROPERTIES:
    BeamSystemJustifyType JustifyType { get; set; }
      Description: Get or set the type of justification.
    double Spacing { get; set; }
      Description: Get or set the spacing of the beam system.

--------------------------------------------------------------------------------

[CLASS] LayoutRuleFixedDistance
Full Name: Autodesk.Revit.DB.LayoutRuleFixedDistance
Description: This class indicate the layout rule of a Beam System is Fixed-Distance.
Remarks: To use this type of LayoutRule, the distance between the beams and the justify-type must be set.
Inherits: LayoutRule

  CONSTRUCTORS:
    new LayoutRuleFixedDistance(double spacing, BeamSystemJustifyType justifyType)
      Description: Constructor of LayoutRuleFixedDistance. Create LayoutRuleFixedDistance with the values passed in.
      @spacing: The value of spacing must be between 0 and 30000.
      @justifyType: The type of the justification, it's corresponding to the items in the element properties dialog.

  PROPERTIES:
    BeamSystemJustifyType JustifyType { get; set; }
      Description: Get or set the type of justification.
    double Spacing { get; set; }
      Description: Get or set spacing of the Beam System.

--------------------------------------------------------------------------------

[CLASS] LayoutRuleFixedNumber
Full Name: Autodesk.Revit.DB.LayoutRuleFixedNumber
Description: This class indicate the layout rule of a Beam System is Fixed-Number.
Remarks: To use this type of LayoutRule, only the number of the beams must be set.
Inherits: LayoutRule

  CONSTRUCTORS:
    new LayoutRuleFixedNumber(int numberOfLines)
      Description: Constructor of LayoutRuleFixedNumber.
      @numberOfLines: The value of numberOfLines must be positive.

  PROPERTIES:
    int NumberOfLines { get; set; }
      Description: Get or set the number of the beams in a beam system.

--------------------------------------------------------------------------------

[CLASS] LayoutRuleMaximumSpacing
Full Name: Autodesk.Revit.DB.LayoutRuleMaximumSpacing
Description: This class indicate the layout rule of a Beam System is Max-Spacing.
Remarks: To use this type of LayoutRule, only the maximum spacing must be set and it must be in (0, 30000).
Inherits: LayoutRule

  CONSTRUCTORS:
    new LayoutRuleMaximumSpacing(double spacing)
      Description: Constructor of LayoutRuleMaximumSpacing.
      @spacing: The value of spacing must be in (0, 30000).

  PROPERTIES:
    double Spacing { get; set; }
      Description: Get or set the spacing of the beam system.

--------------------------------------------------------------------------------

[CLASS] Leader
Full Name: Autodesk.Revit.DB.Leader
Description: A leader object that can be attached to annotation elements such as text notes.
Remarks: For information on how to attach or get leaders to/from a text annotation refer to corresponding methods of Autodesk::Revit::DB::TextNote class.
Inherits: APIObject

  PROPERTIES:
    XYZ Anchor { get; }
      Description: Anchor point of the Leader
    XYZ Elbow { get; set; }
      Description: Elbow point of the Leader.
    XYZ End { get; set; }
      Description: End point of the Leader.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LeaderShape LeaderShape { get; }
      Description: Geometric style of the leader

--------------------------------------------------------------------------------

[CLASS] LeaderArray
Full Name: Autodesk.Revit.DB.LeaderArray
Description: An array that can contain any number of leaders.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new LeaderArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Leader Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(Leader item)
      Description: Add the item to the end of the array.
      @item: The item to be added.
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    LeaderArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Leader item, int index)
      Description: Insert the specified item into the array.
      @item: The item to be inserted into the array.
      @index: The item will be inserted before this index.
    LeaderArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] LeaderArrayIterator
Full Name: Autodesk.Revit.DB.LeaderArrayIterator
Description: An iterator to an array of leaders.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new LeaderArrayIterator()
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

[ENUM] LeaderAtachement
Full Name: Autodesk.Revit.DB.LeaderAtachement
Description: Supported types of vertical attachments of a leader to a text note.
Inherits: Enum

  Values:
    - TopLine = 0
    - Midpoint = 1
    - BottomLine = 2

--------------------------------------------------------------------------------

[ENUM] LeaderEndCondition
Full Name: Autodesk.Revit.DB.LeaderEndCondition
Description: An enumerated type listing leader end conditions that are supported for IndependentTags.
Remarks: The leader end point is the point on the leader which is closest to the tagged element.
Inherits: Enum

  Values:
    - Attached = 0
    - Free = 1

--------------------------------------------------------------------------------

[ENUM] LeaderShape
Full Name: Autodesk.Revit.DB.LeaderShape
Description: Supported geometric shapes of annotation leaders.
Remarks: Although the Leader class supports all available shapes, not all types of leaders may have the option to change its shape. For example, leaders of text annotations can be of any shape, while leaders of level lines are never curved.
Inherits: Enum

  Values:
    - Straight = 0
    - Kinked = 1
    - Arc = 2

--------------------------------------------------------------------------------

[ENUM] LeadersPresentationMode
Full Name: Autodesk.Revit.DB.LeadersPresentationMode
Description: Leaders Presentation Mode.
Inherits: Enum

  Values:
    - ShowAll = 0
    - HideAll = 1
    - ShowOnlyOne = 2
    - ShowSpecificLeaders = 3

--------------------------------------------------------------------------------

[ENUM] LeaderStartCondition
Full Name: Autodesk.Revit.DB.LeaderStartCondition
Description: An enumerated type listing leader start conditions that are supported for tags.
Remarks: The leader start is the point on the leader that is closest to the tag head.
Inherits: Enum

  Values:
    - Attached = 0
    - Free = 1

--------------------------------------------------------------------------------

[CLASS] Level
Full Name: Autodesk.Revit.DB.Level
Description: Represents a Level within Autodesk Revit.
Remarks: A Level is conceptually a horizontal rectangle of finite extents. It appears as a straight line in views that intersect the rectangle. The straight line represents the projection of the rectangle onto the view. The Name property can be used to retrieve the user visible name of the level that appears in the level bubble.
Inherits: DatumPlane

  PROPERTIES:
    double Elevation { get; set; }
      Description: Retrieves or changes the elevation above or below the ground level.
    double ProjectElevation { get; }
      Description: Retrieves the elevation relative to project origin, no matter what values of the Elevation Base parameter is set.

  METHODS:
    static Level Create(Document document, double elevation)
      Description: Creates a new instance of level based on an input elevation.
      @document: The document in which the new instance is created
      @elevation: The elevation of the level to be created.
      Returns: The newly created level instance.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId FindAssociatedPlanViewId()
      Description: Finds the id of the first available associated floor or structural plan view associated with this level.
    static ElementId GetNearestLevelId(Document document, double elevation)
      Description: Returns id of the Level which is closest to the specified elevation.
      @document: The document.
      @elevation: Target Elevation.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetNearestLevelId(Document document, double elevation, out double offset)
      Description: Returns id of the Level which is closest to the specified elevation.
      @document: The document.
      @elevation: Target Elevation.
      @offset: Vertical offset from the level to the target elevation.
      Throws ArgumentNullException: A non-optional argument was null
    Reference GetPlaneReference()
      Description: Returns a reference to this element as a plane.

--------------------------------------------------------------------------------

[CLASS] LevelAssociationData
Full Name: Autodesk.Revit.DB.LevelAssociationData
Description: This class holds information related to Level.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ElementId GetAssociatedLevel()
      Description: Returns the Associated Level id.
    static LevelAssociationData GetLevelAssociationData(Element element)
      Description: Returns LevelAssociationData associated with this element, if it exists.
      @element: The element from which we try to obtain LevelAssociationData.
      Throws ArgumentNullException: A non-optional argument was null
    double GetLevelOffset()
      Description: Returns the offset from the Associated Level.
    void SetAssociatedLevel(ElementId levelId)
      Description: Sets the Associated Level.
      @levelId: The id of the Level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: this operation failed.

--------------------------------------------------------------------------------

[CLASS] LevelType
Full Name: Autodesk.Revit.DB.LevelType
Description: An object that represents a Level type.
Inherits: LineAndTextAttrSymbol

--------------------------------------------------------------------------------

[ENUM] LightAndMaterialAccuracyMode
Full Name: Autodesk.Revit.DB.LightAndMaterialAccuracyMode
Description: An enumerated type containing possible Light and Material Accuracy modes for Raytracer render.
Inherits: Enum

  Values:
    - Simplified = 1
    - Advanced = 2

--------------------------------------------------------------------------------

[ENUM] LightingSource
Full Name: Autodesk.Revit.DB.LightingSource
Description: Indicates the lighting scheme type in rendering settings.
Inherits: Enum

  Values:
    - ExteriorSun = 21
    - ExteriorSunAndArtificial = 22
    - ExteriorArtificial = 23
    - InteriorSun = 24
    - InteriorSunAndArtificial = 25
    - InteriorArtificial = 26

--------------------------------------------------------------------------------

[CLASS] LightNode
Full Name: Autodesk.Revit.DB.LightNode
Description: This class represents a Light element in a model-exporting process.
Remarks: See also: Autodesk::Revit::DB::IExportContext::OnLight.
Inherits: ContentNode

--------------------------------------------------------------------------------

[CLASS] Line
Full Name: Autodesk.Revit.DB.Line
Description: A line in space.
Inherits: Curve

  PROPERTIES:
    XYZ Direction { get; }
      Description: Returns the direction of the line.
    XYZ Origin { get; }
      Description: Returns the origin of the line.

  METHODS:
    static Line CreateBound(XYZ endpoint1, XYZ endpoint2)
      Description: Creates a new instance of a bound linear curve.
      @endpoint1: The first line endpoint.
      @endpoint2: The second line endpoint.
      Returns: The new bound line.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentsInconsistentException: Curve length is too small for Revit's tolerance (as identified by Application.ShortCurveTolerance).
    static Line CreateUnbound(XYZ origin, XYZ direction)
      Description: Creates a new instance of an unbound linear curve.
      @origin: The origin of the unbound line.
      @direction: The direction of the unbound line.
      Returns: The new unbound line.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentOutOfRangeException: direction has zero length.
      Throws ArgumentsInconsistentException: Vector and origin cannot form a proper unbound line.

--------------------------------------------------------------------------------

[CLASS] LineAndTextAttrSymbol
Full Name: Autodesk.Revit.DB.LineAndTextAttrSymbol
Description: An object that represents a dimension style.
Inherits: ElementType

--------------------------------------------------------------------------------

[CLASS] LinearArray
Full Name: Autodesk.Revit.DB.LinearArray
Description: An object that represents an Array created linearly within the Revit project.
Inherits: BaseArray

  PROPERTIES:
    int NumMembers { get; set; }
      Description: Retrieves or changes the number of arrayed members. Array placeholder members in the family environment are not counted.

  METHODS:
    static ICollection<ElementId> ArrayElementsWithoutAssociation(Document aDoc, View dBView, ICollection<ElementId> ids, int count, XYZ translationToAnchorMember, ArrayAnchorMember anchorMember)
      Description: Creates a new linear array from a set of elements.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements. If elements include view-specific elements, they must belong to this view.
      @ids: The elements to array.
      @count: The number of array members to create including the initial element grouping. Must between 2 and 200 in projects, and between 0 and 200 in families.
      @translationToAnchorMember: The translation vector for the array.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The ids of the elements created during the operation.
      Throws ArgumentException: The given element id set is empty. -or- One or more elements in ids do not exist in the document. -or- One or more elements in ids is owned by different views and thus cannot be arrayed together. -or- One or more elements in ids is not arrayable. -or- count must be between 2 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The translation point vector is invalid to array the element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the linear array.
    static ICollection<ElementId> ArrayElementWithoutAssociation(Document aDoc, View dBView, ElementId id, int count, XYZ translationToAnchorMember, ArrayAnchorMember anchorMember)
      Description: Creates a new linear array from a single element.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.
      @id: The element to array.
      @count: The number of array members to create including the initial element grouping. Must between 2 and 200 in projects, and between 0 and 200 in families.
      @translationToAnchorMember: The translation vector for the array.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The ids of the elements created during the operation.
      Throws ArgumentException: The element id does not exist in the document -or- id is not arrayable. -or- count must be between 2 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The translation point vector is invalid to array the element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the linear array.
    static LinearArray Create(Document aDoc, View dBView, ElementId id, int count, XYZ translationToAnchorMember, ArrayAnchorMember anchorMember)
      Description: Creates a new linear array element from a single element.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if the element is a view-specific element.
      @id: The element to array.
      @count: The number of array members to create including the initial element grouping. Must between 2 and 200 in projects, and between 0 and 200 in families.
      @translationToAnchorMember: The translation vector for the array.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The new linear array element.
      Throws ArgumentException: The element id does not exist in the document -or- id is not arrayable. -or- count must be between 2 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The translation point vector is invalid to array the element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the linear array.
    static LinearArray Create(Document aDoc, View dBView, ICollection<ElementId> ids, int count, XYZ translationToAnchorMember, ArrayAnchorMember anchorMember)
      Description: Creates a new linear array element from a set of elements.
      @aDoc: The document.
      @dBView: The view. If it is a 2d view, translation vector must be in the view plane if elements include view-specific elements. If elements include view-specific elements, they must belong to this view.
      @ids: The elements to array.
      @count: The number of array members to create including the initial element grouping. Must between 2 and 200 in projects, and between 0 and 200 in families.
      @translationToAnchorMember: The translation vector for the array.
      @anchorMember: Indicates if the translation vector specifies the location of the second member of the array, or the last member of the array.
      Returns: The new linear array element.
      Throws ArgumentException: The given element id set is empty. -or- One or more elements in ids do not exist in the document. -or- One or more elements in ids is owned by different views and thus cannot be arrayed together. -or- One or more elements in ids is not arrayable. -or- count must be between 2 and 200 in project documents and between 0 and 200 in family documents. -or- The view is invalid for specific view elements array. -or- The translation point vector is invalid to array the element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to create the linear array.
    ICollection<ElementId> GetCopiedMemberIds()
      Description: Retrieves the copied member ids from the array. The first item in an array contains the original elements from which the array was created. All other items in the array are copies.
      Returns: The copied member ids of the Array
    static int GetMinimumSize(Document document)
      Description: Returns the minimum size for a linear array based on the document.
      @document: The document.
      Returns: The minimum size of an array.
      Throws ArgumentNullException: A non-optional argument was null
    int GetNumberOfMembersIncludingPlaceholders()
      Description: Returns the number of items in an array, including placeholder items in families.
      Returns: The number of elements in an array, including placeholder items in families.
    ICollection<ElementId> GetOriginalMemberIds()
      Description: Retrieves the ids for the original elements from which the array was created. These elements form the first item in the array.
      Returns: The original member ids of the Array
    static bool IsElementArrayable(Document aDoc, ElementId id)
      Description: Indicates whether the input element is arrayable.
      @aDoc: The document.
      @id: The element id.
      Returns: True if the input element is arrayable, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidNumberOfMembers(int count, Document pADoc)
      Description: This indicates whether the input count is a valid size for an array based on the document.
      @count: The count.
      @pADoc: The document.
      Returns: True if an array can be set to the specified count in the given document, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LinearDimension
Full Name: Autodesk.Revit.DB.LinearDimension
Description: LinearDimString
Inherits: Dimension

  METHODS:
    static LinearDimension Create(Document document, View dbView, Line line, IList<Reference> references)
      Description: Creates a new instance of an Linear Dimension element within the project.
      @document: The document where new Linear Dimension is created.
      @dbView: The view in which the Linear Dimension will appear.
      @line: The line of the annotation
      @references: references that the Linear Dimension will witness.
      Returns: The newly created Linear Dimension instance, or if the operation fails.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LinePattern
Full Name: Autodesk.Revit.DB.LinePattern
Description: Represents a line pattern definition.
Remarks: A line pattern is a pattern of dashes and dots used to control the way the lines of an object are drawn in Revit. Line patterns are used in the definition of GraphicsStyle objects. A line pattern is defined by a repeating sequence segments. Each segment is a dash, a dot or a space. A line pattern definition must contain an even number of segments, starting with a visible segment (a dash or a dot) and alternating between visible segments and spaces.
Implements: IDisposable

  CONSTRUCTORS:
    new LinePattern(string name)
      Description: Creates a line pattern with given name.
      @name: The name.
      Throws ArgumentNullException: A non-optional argument was null
    new LinePattern()
      Description: Creates a simple line pattern.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: Line pattern name.

  METHODS:
    void Dispose()
    IList<LinePatternSegment> GetSegments()
      Description: Gets the sequence of segments that defines this line pattern.
      Returns: The sequence of segments.
    void SetSegments(IList<LinePatternSegment> lineSegs)
      Description: Sets the sequence of segments that defines this line pattern.
      @lineSegs: The sequence of segments.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LinePatternElement
Full Name: Autodesk.Revit.DB.LinePatternElement
Description: An element that represents a line pattern.
Remarks: The LinePatternElement represents a line pattern in a project. It enables the user to retrieve, modify or create a line pattern in a project.
Inherits: Element

  METHODS:
    static LinePatternElement Create(Document document, LinePattern linePattern)
      Description: Creates a new LinePatternElement.
      @document: The document in which to create the LinePatternElement.
      @linePattern: The LinePattern associated to the newly created LinePatternElement.
      Returns: The newly created LinePatternElement.
      Throws ArgumentException: The Line Pattern is not valid.
      Throws ArgumentNullException: A non-optional argument was null
    static LinePattern GetLinePattern(Document document, ElementId elementId)
      Description: Gets the LinePattern associated to an element or from a built-in line pattern.
      @document: The document in which to retrieve the LinePattern.
      @elementId: The ElementId of the LinePatternElement or the built-in line pattern id.
      Returns: A copy of LinePattern object. if the ElementId doesn't represent a line pattern element or built-in line pattern. for Solid.
      Throws ArgumentNullException: A non-optional argument was null
    LinePattern GetLinePattern()
      Description: Gets the LinePattern associated to this element.
      Returns: A copy of LinePattern object.
    static LinePatternElement GetLinePatternElementByName(Document document, string name)
      Description: Retrieves the LinePatternElement by its name.
      @document: The document in which to retrieve the LinePatternElement.
      @name: The name of the LinePatternElement.
      Returns: The LinePatternElement.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetSolidPatternId()
      Description: Gets the solid line pattern element id.
      Returns: The element id of the solid line pattern.
    void SetLinePattern(LinePattern newLinePattern)
      Description: Sets the LinePattern associated to this element.
      @newLinePattern: The new LinePattern object.
      Throws ArgumentException: The Line Pattern is not valid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LinePatternSegment
Full Name: Autodesk.Revit.DB.LinePatternSegment
Description: Represents a segment in a line pattern.
Implements: IDisposable

  CONSTRUCTORS:
    new LinePatternSegment(LinePatternSegmentType type, double length)
      Description: Creates a line pattern segment with given type and length.
      @type: The segment type.
      @length: The length.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new LinePatternSegment()
      Description: Creates a line pattern segment.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Length { get; set; }
      Description: Gets and sets the length of the segment.
    LinePatternSegmentType Type { get; set; }
      Description: Gets and sets the type of the segment.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] LinePatternSegmentType
Full Name: Autodesk.Revit.DB.LinePatternSegmentType
Description: Represents the type of a line pattern segment.
Inherits: Enum

  Values:
    - Dash = 0
    - Space = 1
    - Dot = 2
    - Invalid = 3

--------------------------------------------------------------------------------

[CLASS] LineProperties
Full Name: Autodesk.Revit.DB.LineProperties
Description: A structure that has access to the pen properties of lines/curves that are currently being drawn/exported via an export context during a custom export process.
Remarks: For more about using properties of this class refer to the interface Autodesk::Revit::DB::IModelExportContext and its methods which handle geometric objects such as Autodesk::Revit::DB::IModelExportContext::OnCurve, Autodesk::Revit::DB::IModelExportContext::OnLineSegment, etc. LineProperties are available as a read-only property on the respective output nodes, i.e. Autodesk::Revit::DB::CurveNode, Autodesk::Revit::DB::LineSegment, etc.
Implements: IDisposable

  PROPERTIES:
    Color Color { get; }
      Description: The current color used when drawing lines/curves.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LineWidth { get; }
      Description: The current width (thickness) of the pen stroke when drawing lines/curves.
    ElementId PatternId { get; }
      Description: Id of the current Line pattern element used when drawing lines/curves.
    int Transparency { get; }
      Description: The current transparency level to be applied to the current color.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] LineScaling
Full Name: Autodesk.Revit.DB.LineScaling
Description: An enumerated type listing possible LineType scaling modes.
Remarks: Whichever option is chosen, line type definitions are created so a dashed line always begins and ends with a dash. Using these options does change the default behavior of exported DWGs. Some lines expected to be dashed may appear solid or in a different scale.
Inherits: Enum

  Values:
    - ViewScale = 0
    - ModelSpace = 1
    - PaperSpace = 2

--------------------------------------------------------------------------------

[CLASS] LineSegment
Full Name: Autodesk.Revit.DB.LineSegment
Description: An output node that represents a tessellated line segment.
Remarks: See also: Autodesk::Revit::DB::IModelExportContext::OnLineSegment.
Implements: IDisposable

  PROPERTIES:
    double EndParameter { get; }
      Description: Parameter associated with the end point.
    XYZ EndPoint { get; }
      Description: End point of the line segment.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LineProperties LineProperties { get; }
      Description: Access to the line (pen) properties of the line
    double StartParameter { get; }
      Description: Parameter associated with the start point.
    XYZ StartPoint { get; }
      Description: Start point of the line segment.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] LinkConversionData
Full Name: Autodesk.Revit.DB.LinkConversionData
Description: This class contains the information necessary to re-create a Revit document from an external source.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Path { get; }
      Description: The path to the source data used to generate the model.
    Guid ServerId { get; }
      Description: The service responsible for converting the data into a Revit file.

  METHODS:
    void Dispose()
    IDictionary<string, string> GetOptions()
      Description: Extra information used during the creation of the Revit document.
      Returns: The extra information used during the creation of the Revit document.

--------------------------------------------------------------------------------

[ENUM] LinkedFileStatus
Full Name: Autodesk.Revit.DB.LinkedFileStatus
Description: Enum displaying the loaded status of a linked file
Inherits: Enum

  Values:
    - Loaded = 0
    - Unloaded = 1
    - Imported = 2
    - NotFound = 3
    - CanBeUpgraded = 4
    - InClosedWorkset = 5
    - LocallyUnloaded = 6
    - Invalid = -1

--------------------------------------------------------------------------------

[CLASS] LinkElementId
Full Name: Autodesk.Revit.DB.LinkElementId
Description: LinkElementId represents an element in a linked document.
Remarks: The id contains two element ids: The id of the linked model element in host document.The id of the element in the linked model document.

  CONSTRUCTORS:
    new LinkElementId(ElementId linkInstanceId, ElementId elementId)
      Description: Creates a new LinkElementId representing an element in a linked document.
      @linkInstanceId: The id of the linked model element in the host document.
      @elementId: The id of the element in the linked model document.
    new LinkElementId(ElementId elementId)
      Description: Creates a new LinkElementId representing an element in the host document.
      @elementId: The id of the element in the host document.

  PROPERTIES:
    ElementId HostElementId { get; }
      Description: The id of the element in the host, or invalidElementId if there is a link.
    ElementId LinkedElementId { get; }
      Description: The id of the element in the link, or invalidElementId if no link.
    ElementId LinkInstanceId { get; }
      Description: The id of the link, or invalidElementId if no link.

  METHODS:
    bool Equals(object obj)
      Description: Determines whether the specified Object is equal to the current Object.
      @obj: Another object.

--------------------------------------------------------------------------------

[CLASS] LinkLoadContent
Full Name: Autodesk.Revit.DB.LinkLoadContent
Description: This class is used by IExternalResourceServers to return Link data to Revit when their LoadResource method is invoked. It also contains additional information used by IExternalResourceUIServers to display link load status results to the user.
Remarks: This class handles Revit links.Revit links must be loaded from a path accessible to Revit. Server implementors should provide Revit with a ModelPath representing a location from which to load the link. Revit will handle the actual file loading.Servers which represent non-local file locations will need to create their own implementation for copying or moving files to a Revit-accessible location.The link data path used for link loading may be different from the path displayed to the user. The link data path represents the literal location of the file, whereas the link's display path represents what the user sees as the name of the link. See Autodesk::Revit::DB::ExternalResourceReference::InSessionPath for more details on display paths.
Inherits: ExternalResourceLoadContent

  METHODS:
    ModelPath GetLinkDataPath()
      Description: Returns the Link data path owned by this LinkLoadContent object.
      Returns: The Links data path owned by this LinkLoadContent object.
    LinkLoadResult GetLinkLoadResult()
      Description: Retrieves the LinkLoadResult of the attempt to load or reload a Revit link.
      Returns: A LinkLoadObject containing the status and other information about an attempt by Revit to load a Revit link.
    void SetLinkDataPath(ModelPath linkPath)
      Description: Sets the Link data path owned by this LinkLoadContent object.
      @linkPath: The Links data path set for this LinkLoadContent object.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LinkLoadResult
Full Name: Autodesk.Revit.DB.LinkLoadResult
Description: This class stores the results of trying to load a single linked model.
Implements: IDisposable

  CONSTRUCTORS:
    new LinkLoadResult(LinkLoadResult other)
      Description: Constructs a new copy of the input LinkLoadResult object.
      Throws ArgumentNullException: A non-optional argument was null
    new LinkLoadResult()
      Description: Constructs a new uninitialized LinkLoadResult object.

  PROPERTIES:
    ElementId ElementId { get; }
      Description: The id of the created or loaded linked model.
    bool IsCircularLink { get; }
      Description: True if these results are part of a link cycle.
    bool IsNested { get; }
      Description: True if these results represent a nested link; false otherwise.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LinkLoadResultType LoadResult { get; }
      Description: Holds the results of creating or loading a link. Results can be LinkLoadResultType.LinkLoaded for success, or a variety of errors. See LinkLoadResultType for the full list.

  METHODS:
    void Dispose()
    ModelPath GetCentralModelName()
      Description: Gets the central model's name. If the link is not workshared, this returns an empty FilePath. If the link is itself a central model, this returns the link's name.
    ExternalResourceReference GetExternalResourceReference()
      Description: Gets a copy of the ExternalResourceReference corresponding to the link.
      Returns: A copy of the ExternalResourceReference corresponding to the link.
    IList<ExternalResourceReference> GetExternalResourceReferencesFromFailedLoads()
      Description: Searches this and all nested LinkLoadResults, and returns a list of ExternalResourceReferences for the links that failed to load.
      Returns: A collection of link ExternalResourceReferences which failed to load.
    LinkLoadResult GetLinkLoadResult(ExternalResourceReference matchExtResRef)
      Description: Searches this LinkLoadResult and all nested LinkLoadResults for the load operation results of a specified ExternalResourceReference.
      @matchExtResRef: An ExternalResourceReference whose LinkLoadResults are contained in this object.
      Returns: A LinkLoadResult object with the load results for the specified ExternalResourceReference.
      Throws ArgumentNullException: A non-optional argument was null
    ModelPath GetModelName()
      Description: Gets the name of the model.
    IDictionary<string, LinkLoadResult> GetNestedLinkLoadResults()
      Description: Gets the results for this link's nested links.
      Returns: A map from nested link paths to the load results for that nested link.For links from external servers, the "path" will be the display name of the link.
    ModelPath GetParentModelName()
      Description: Returns the name of the parent of the linked model, or an empty FilePath if the link is a top-level link.
    static bool IsCodeSuccess(LinkLoadResultType code)
      Description: Check if load result code signifies success.
      @code: Load result code to be verified.
      Returns: True if LinkLoadResultType argument is success, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] LinkLoadResultType
Full Name: Autodesk.Revit.DB.LinkLoadResultType
Description: Enum listing the possible results after loading a linked model.
Remarks: For all values except LinkLoadResultType.LinkLoaded, the linked model is not loaded and no new link is created (if Revit was trying to create a link).
Inherits: Enum

  Values:
    - Uninitialized = 0
    - LinkLoaded = 1
    - LinkNotFound = 2
    - LinkNotOpenable = 3
    - LinkOpenAsHost = 4
    - SameModelAsHost = 5
    - SameCentralModelAsHost = 6
    - LinkNotLoadedOtherError = 7
    - LinkMayBeUpgraded = 8
    - ExternalServerMissing = 9
    - LinkExists = 10
    - CouldNotChangeViewReference = 12
    - UsedExisting = 13

--------------------------------------------------------------------------------

[CLASS] LinkNode
Full Name: Autodesk.Revit.DB.LinkNode
Description: An output node that represents a linked Revit document.
Remarks: See also: Autodesk::Revit::DB::IExportContext::OnLinkBegin.
Inherits: GroupNode

  PROPERTIES:
    ElementId SymbolId { get; }
      Description: Identifies the Id of the symbol associated with the node.

  METHODS:
    Document GetDocument()
      Description: Returns the document associated with the link.
      Returns: Instance of a Document

--------------------------------------------------------------------------------

[CLASS] LinkOperations
Full Name: Autodesk.Revit.DB.LinkOperations
Description: This class is used to extend the IExternalResourceServer interface with methods to support operations for elements that are LinkTypes.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    void SetOnLocalLinkSharedCoordinatesSavedCallback(IOnLocalLinkSharedCoordinatesSavedCallback onLocalLinkSharedCoordinatesSaved)
      Description: Sets the callback that will be called when the Revit user saves new shared coordinate settings to a linked document obtained from an IExternalResourceServer.
      @onLocalLinkSharedCoordinatesSaved: An IOnLocalLinkSharedCoordinatesSavedCallback object that can respond when the user saves new shared coordinates to a Revit link document obtained from IExternalResourceServer.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] LinkOriginFileType
Full Name: Autodesk.Revit.DB.LinkOriginFileType
Description: Enum determining whether the source type of a temporary rvt link is an ifc.
Inherits: Enum

  Values:
    - RVT = 0
    - IFC = 1

--------------------------------------------------------------------------------

[ENUM] LinkVisibility
Full Name: Autodesk.Revit.DB.LinkVisibility
Description: Link visibility types.
Inherits: Enum

  Values:
    - ByHostView = 0
    - ByLinkView = 1
    - Custom = 2

--------------------------------------------------------------------------------

[ENUM] ListType
Full Name: Autodesk.Revit.DB.ListType
Description: An enumerated type indicating the style of list item for paragraphs that are part of ordered or unordered lists in FormattedText.
Inherits: Enum

  Values:
    - Mixed = 0
    - None = 1
    - Bullet = 2
    - ArabicNumbers = 3
    - LowerCaseLetters = 4
    - UpperCaseLetters = 5

--------------------------------------------------------------------------------

[ABSTRACT CLASS] LoadedFamilyIntegrityCheck
Full Name: Autodesk.Revit.DB.LoadedFamilyIntegrityCheck
Description: Functions for checking the integrity of loaded families.

  METHODS:
    static bool CheckAllFamilies(Document ADoc, ISet<ElementId> corruptFamilyIds)
      Description: Check that all families loaded in the host document have their content documents.
      @ADoc: The host document.
      @corruptFamilyIds: Return ids of families that need to be reloaded because their content documents are missing.
      Returns: Returns true if all loaded families have their content documents.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CheckAllFamiliesSlow(Document ADoc, ISet<ElementId> corruptFamilyIds)
      Description: Check integrity of content documents of all families loaded in the host document.
      @ADoc: The host document.
      @corruptFamilyIds: Return ids of families that need to be reloaded because their content documents are missing or corrupt.
      Returns: Returns true if all content documents are usable.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CheckFamily(Document ADoc, ElementId familyId)
      Description: Check that the loaded family has its content document.
      @ADoc: The host document.
      @familyId: The id of the family to check.
      Returns: Returns true if the family has its content document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] LoadOperationType
Full Name: Autodesk.Revit.DB.LoadOperationType
Description: An enum indicating whether a resource load operation was triggered by a user action or an automatic process.
Remarks: This enum is provided so that an external resource server can decide how much feedback it wishes to provide to the user.For example, Revit automatically loads all resources on file open. This may cause many external resources to load at once. The server may wish to provide truncated error messages.Reload() and LoadFrom() operations from the API are considered to be LoadOperationType.Explicit.
Inherits: Enum

  Values:
    - Automatic = 0
    - Explicit = 1

--------------------------------------------------------------------------------

[CLASS] Location
Full Name: Autodesk.Revit.DB.Location
Description: Provides location functionality for all elements.
Remarks: The location object provides the ability to translate and rotate elements. More detailed location information and control can be found by using the derivatives of this object, such as LocationPoint or LocationCurve.
Inherits: APIObject

  METHODS:
    bool Move(XYZ translation)
      Description: Move the element within the project by a specified vector.
      @translation: The vector by which the element is to be moved.
      Returns: If the element is moved successfully then the method return True, otherwise False.
    bool Rotate(Line axis, double angle)
      Description: Rotate the element within the project by a specified angle around a given axis.
      @axis: An unbounded line that represents the axis of rotation.
      @angle: The angle, in radians, by which the element is to be rotated around the specified axis.
      Returns: If the element is rotate successfully then the method returns True, otherwise False.

--------------------------------------------------------------------------------

[CLASS] LocationCurve
Full Name: Autodesk.Revit.DB.LocationCurve
Description: Provides location functionality for all elements that are based upon a curve.
Remarks: The location line objects adds additional functionality to its base location object class. This includes reading and writing the curve contained within the element.
Inherits: Location

  PROPERTIES:
    Curve Curve { get; set; }
      Description: Provides the ability to get and set the curve of a curve based element.
    ElementArray ElementsAtJoin { get; set; }
    JoinType JoinType { get; set; }

--------------------------------------------------------------------------------

[CLASS] LocationPoint
Full Name: Autodesk.Revit.DB.LocationPoint
Description: Provides location functionality for all elements that have a single insertion point.
Remarks: The location point objects adds additional functionality to its base location object class. This includes setting the elements location to a specific point and retrieving its rotation around its insertion point. Inplace families do not have a single insertion point and therefore do not have meaningful LocationPoint data.
Inherits: Location

  PROPERTIES:
    XYZ Point { get; set; }
      Description: The physical location of the element.
    double Rotation { get; }
      Description: The angle of rotation around the insertion point, in radians.

--------------------------------------------------------------------------------

[CLASS] LogicalAndFilter
Full Name: Autodesk.Revit.DB.LogicalAndFilter
Description: A filter that contains a set of filters. The filter passes when all filters in the set pass.
Remarks: The component filters may be reordered by Revit to cause the quickest acting filters to be evaluated first.
Inherits: ElementLogicalFilter

  CONSTRUCTORS:
    new LogicalAndFilter(IList<ElementFilter> filters)
      Description: Constructs a new instance of the logical filter with any number of input filters.
      @filters: A collection of input filters.
      Throws ArgumentException: The filter collection is empty, or contains invalid inputs.
      Throws ArgumentNullException: A non-optional argument was null
    new LogicalAndFilter(ElementFilter filter1, ElementFilter filter2)
      Description: Constructs a new instance of the logical filter with two input filters.
      @filter1: The first filter.
      @filter2: The second filter.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LogicalOrFilter
Full Name: Autodesk.Revit.DB.LogicalOrFilter
Description: A filter that contains a set of filters. The filter passes when any filter in the set passes.
Remarks: The component filters may be reordered by Revit to cause the quickest acting filters to be evaluated first.
Inherits: ElementLogicalFilter

  CONSTRUCTORS:
    new LogicalOrFilter(IList<ElementFilter> filters)
      Description: Constructs a new instance of the logical filter with any number of input filters.
      @filters: A collection of input filters.
      Throws ArgumentException: The filter collection is empty, or contains invalid inputs.
      Throws ArgumentNullException: A non-optional argument was null
    new LogicalOrFilter(ElementFilter filter1, ElementFilter filter2)
      Description: Constructs a new instance of the logical filter with two input filters.
      @filter1: The first filter.
      @filter2: The second filter.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

