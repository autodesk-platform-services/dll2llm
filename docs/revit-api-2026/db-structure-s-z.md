# Autodesk.Revit.DB.Structure

NAMESPACE: Autodesk.Revit.DB.Structure
--------------------------------------------------------------------------------

[ENUM] StirrupTieAttachmentType
Full Name: Autodesk.Revit.DB.Structure.StirrupTieAttachmentType
Description: An enumerated tye that represents how the Stirrup/Tie rebar is attached to the cover reference.
Inherits: Enum

  Values:
    - InteriorFace = 0
    - ExteriorFace = 1

--------------------------------------------------------------------------------

[ENUM] StructuralConnectionApplyTo
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo
Description: An enumerated type that represents the type of structural locations to which a connection annotation may be applied.
Inherits: Enum

  Values:
    - BeamsAndBraces = 0
    - ColumnTop = 1
    - ColumnBase = 2
    - Connection = 3

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionApprovalType
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType
Description: A type element that represents a connection approval type.
Inherits: ElementType

  METHODS:
    static StructuralConnectionApprovalType Create(Document doc, string name)
      Description: Creates a new StructuralConnectionApprovalType.
      @name: A name for the new approval type. It must be unique within the document.
      Returns: Created connection approval type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The input name for approval type is not unique in the document.
    static void GetAllStructuralConnectionApprovalTypes(Document cda, out ICollection<ElementId> ids)
      Description: Collects the ids of all StructuralConnectionApprovalTypes in the document.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidApprovalTypeName(Document doc, string name)
      Description: Verifies if the provided approval name is unique in the document.
      Returns: True if approval type name is unique.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] StructuralConnectionCodeCheckingStatus
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus
Description: An enumerated type listing all code checking status of the structural connection element.
Inherits: Enum

  Values:
    - NotCalculated = 0
    - OkChecked = 1
    - CheckingFailed = 2

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionHandler
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionHandler
Description: An object of Structural Connection Handler.
Inherits: Element

  PROPERTIES:
    ElementId ApprovalTypeId { get; set; }
      Description: Retrieves or changes approval type of the Structural Connection Handler.
    StructuralConnectionCodeCheckingStatus CodeCheckingStatus { get; set; }
      Description: Code checking status of the structural connection.
    bool OverrideTypeParams { get; set; }
      Description: Allow or disallow connection's type parameters to be overridden.
    int SingleElementEndIndex { get; set; }
      Description: Element end index for single element connections (0: start, 1: end).

  METHODS:
    void AddElementIds(IList<ElementId> elemIds)
      Description: Adds element ids to the connection. All element ids in an array should be of applicable category.
      @elemIds: The ElementIdArr containing ids of elements to be added.
      Throws ArgumentException: One or more element ids was not permitted to be add to the connection. Elements should be of applicable category. -or- One or more element ids was not permitted to be added to the connection. Elements should not be duplicated.
      Throws ArgumentNullException: A non-optional argument was null
    void AddReferences(Document document, IList<Reference> picks)
      Description: Adds references to the connection. All references should be of applicable category.
      @document: The document.
      @picks: The array containing picks of input elements to be added.
      Throws ArgumentException: One or more picks was not permitted to be add to the connection. -or- One or more picks was not permitted to be added to the connection. Picks should not be duplicated.
      Throws ArgumentNullException: A non-optional argument was null
    static StructuralConnectionHandler Create(Document document, IList<ElementId> idsToConnect, ElementId typeId, IList<ConnectionInputPoint> additionalInputPoints)
      Description: Creates a new instance of a Structural Connection Handler, which is defined by the elements to connect and the additional points.
      @document: The Revit document.
      @idsToConnect: List of element ids of connected elements.
      @typeId: The type of Structural Connection Handler.
      @additionalInputPoints: The array of points that help define the connection.
      Returns: The newly created connection.
      Throws ArgumentException: It verifies that we have at least one element id in the list. -or- The type typeId is not a valid StructuralConnectionHandlerType. -or- Missing detailed structural connection service implementation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static StructuralConnectionHandler Create(Document document, IList<ElementId> elementIds, string typeName)
      Description: Creates custom StructuralConnectionHandlerType and StructuralConnectionHandler.
      @document: The Document.
      @elementIds: Elements which are to be used to create custom StructuralConnectionHandlerType.
      @typeName: The StructuralConnectionHandlerType name.
      Returns: The created StructuralConnectionHandler which is of just created custom StructuralConnectionHandlerType.
      Throws ArgumentException: All the input Elements should be of the following structural categories: framings, columns, profiles, plates, bolts, anchors, shear studs, welds or structural connections. -or- There must be at least one StructuralConnectionHandler among the input Elements. Total number of different input elements of input StructuralConnectionHandlers must be lower or equal to 3. -or- Name must be unique among other existing StructuralConnectionHandlerTypes and cannot contain invalid characters.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static StructuralConnectionHandler Create(Document document, IList<ElementId> idsToConnect, ElementId typeId)
      Description: Creates a new instance of a Structural Connection Handler, which defines the connection between given elements.
      @document: The Revit document.
      @idsToConnect: List of element ids of connected elements.
      @typeId: The type of Structural Connection Handler.
      Returns: The newly created connection.
      Throws ArgumentException: It verifies that we have at least one element id in the list. -or- The type typeId is not a valid StructuralConnectionHandlerType. -or- Missing detailed structural connection service implementation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static StructuralConnectionHandler CreateGenericConnection(Document document, IList<ElementId> idsToConnect)
      Description: Creates a new instance of a Structural Connection Handler with a generic type, which defines the connection between given elements.
      @document: The Revit document.
      @idsToConnect: The list of element ids of connected elements.
      Returns: The newly created generic connection.
      Throws ArgumentException: It verifies that we have at least one element id in the list.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    IList<ElementId> GetConnectedElementIds()
      Description: Retrieves list of element ids of connected elements.
      Returns: Returns connected element ids.
    ConnectionInputPoint GetInputPoint(Guid id)
      Description: Returns point with specified id. Returns null if specified point does not exist
    IList<ConnectionInputPoint> GetInputPoints()
      Description: Returns a list of additional points defining certain connections.
    IList<Reference> GetInputReferences()
      Description: Gets references of input elements.
    XYZ GetOrigin()
      Description: Retrieves origin point of Structural Connection Handler element.
      Returns: The origin point of element.
    bool IsCustom()
      Description: Checks if Structural Connection Handler has the custom connection style.
      Returns: True if Structural Connection Handler has the custom connection style.
    bool IsDetailed()
      Description: Checks if Structural Connection Handler has the detailed connection style.
      Returns: True if Structural Connection Handler has the detailed connection style.
    void RemoveElementIds(IList<ElementId> elemIds)
      Description: Removes element ids from the connection. All element ids in an array should belong to the connection.
      @elemIds: The ElementIdArr containing ids of elements to be removed.
      Throws ArgumentException: One or more element ids was not permitted to be removed from the connection. Elements should be members of the connection.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveReferences(IList<Reference> picks)
      Description: Removes references from the connection. All references in an array should belong to the connection.
      @picks: The array containing picks to be removed.
      Throws ArgumentException: One or more picks was not permitted to be removed from the connection. Picks should be members of the connection.
      Throws ArgumentNullException: A non-optional argument was null
    void SetDefaultElementOrder()
      Description: Sorts the connected elements connection according to structural categories, element materials and geometries. The steel element is set rather than an element of other material. The priorities of the elements are set according structural categories in following order: columns, framings, walls, foundations, floors. In case of several Structural Framing elements order is determined by cutting - the cutting element is set as the primary one rather than element being cut.

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionHandlerType
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType
Description: A StructuralConnectionHandlerType is used in StructuralConnectionHandler element generation.
Inherits: ElementType

  PROPERTIES:
    Guid ConnectionGuid { get; }
      Description: The GUID to use for identifying connection geometry generation algorithm.

  METHODS:
    static void AddElementsToCustomConnection(StructuralConnectionHandler structuralConnectionHandler, IList<Reference> references)
      Description: Modifies StructuralConnectionHandlerType of input StructuralConnectionHandler by adding representors of input elements or subelements.
      @structuralConnectionHandler: The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.
      @references: References to elements or subelements which are to be used to modify custom StructuralConnectionHandlerType by adding their representors.
      Throws ArgumentException: Input StructuralConnectionHandler must have custom type. -or- All the input Elements should be of the following structural categories: framings, columns, profiles, plates, bolts, anchors, shear studs, welds or structural connections. -or- Total number of different input elements of input StructuralConnectionHandlers must be lower or equal to 3.
      Throws ArgumentNullException: A non-optional argument was null
    static StructuralConnectionHandlerType Create(Document pADoc, string name, Guid guid, string familyName, ElementId categoryId, IList<ConnectionInputPointInfo> inputPointsInfo)
      Description: Creates a new StructuralConnectionHandlerType object.
      @pADoc: The document.
      @name: The type name.
      @guid: Connection GUID.
      @familyName: Name of system family which created type will belong to.
      @categoryId: Category identity of connection type.
      @inputPointsInfo: List of description information used for the selection of input points.
      Returns: The newly created instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static StructuralConnectionHandlerType Create(Document pADoc, string name, Guid guid, string familyName, ElementId categoryId)
      Description: Creates a new StructuralConnectionHandlerType object.
      @pADoc: The document.
      @name: The type name.
      @guid: Connection GUID.
      @familyName: Name of system family which created type will belong to.
      @categoryId: Category identity of connection type.
      Returns: The newly created instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static StructuralConnectionHandlerType Create(Document pADoc, string name, Guid guid, string familyName)
      Description: Creates a new StructuralConnectionHandlerType object.
      @pADoc: The document.
      @name: The type name.
      @guid: Connection GUID.
      @familyName: Name of system family which created type will belong to.
      Returns: The newly created instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ElementId CreateDefaultStructuralConnectionHandlerType(Document pADoc)
      Description: Creates a new StructuralConnectionHandlerType object with a default name.
      @pADoc: The document.
      Returns: The newly created type id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ElementId FindGenericConnectionType(Document doc)
      Description: Finds StructuralConnectionHandlerType which is Generic Connection type.
      Returns: Returns id of StructuralConnectionHandlerType which is Generic Connection type of invalidElementId if not found.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId GetDefaultConnectionHandlerType(Document pADoc)
      Description: Gets a default type id for Structural Connection.
      @pADoc: The document.
      Returns: The type id.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsCustom()
      Description: Checks if StructuralConnectionHandlerType is custom.
      Returns: True if StructuralConnectionHandlerType is custom.
    bool IsDetailed()
      Description: Checks if StructuralConnectionHandlerType is detailed.
      Returns: True if StructuralConnectionHandlerType is detailed.
    bool IsGeneric()
      Description: Checks if StructuralConnectionHandlerType is generic.
      Returns: True if StructuralConnectionHandlerType is generic.
    static bool IsTypeNameValidForCustomConnection(Document document, string typeName)
      Description: Validates if the input name matches the criteria of StructuralConnectionHandlerType name. Name must be unique among other existing StructuralConnectionHandlerTypes and cannot contain any of the following characters: new line, {}[];`~\\/:*?";<>| or any of the non-printable characters.
      @document: The Document.
      @typeName: The StructuralConnectionHandlerType name to validate.
      Returns: True if the input name matches the criteria of StructuralConnectionHandlerType name.
      Throws ArgumentNullException: A non-optional argument was null
    static void RemoveMainSubelementsFromCustomConnection(StructuralConnectionHandler structuralConnectionHandler, IList<Subelement> subelements)
      Description: Removes one or more subelements from a StructuralConnectionHandlerType. The subelements will be erased.
      @structuralConnectionHandler: The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.
      @subelements: The main Subelements of input StructuralConnectionHandler which are to be used to modify custom StructuralConnectionHandlerType.
      Throws ArgumentException: Input StructuralConnectionHandler must have custom type. -or- All the input Subelements must belong to input StructuralConnectionHandler. After modification of StructuralConnectionHandlerType there must remain at least one subelement of structural connections category in StructuralConnectionHandler.
      Throws ArgumentNullException: A non-optional argument was null
    static void UpdateCustomConnectionType(StructuralConnectionHandler structuralConnectionHandler, IList<Reference> addReferences, IList<Reference> removeReferences)
      Description: Modifies StructuralConnectionHandlerType of input StructuralConnectionHandler. Adds input elements or subelements. Removes input subelements.The subelements will be erased. Updates any geometrical, parametrical or location changes of existing subelements, regardless of whether elements or subelements are added or removed.
      @structuralConnectionHandler: The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.
      @addReferences: References to elements or subelements which are to be used to modify custom StructuralConnectionHandlerType by adding them.
      @removeReferences: References to subelements of input StructuralConnectionHandler which are to be used to modify custom StructuralConnectionHandlerType by removing them.
      Throws ArgumentException: Input StructuralConnectionHandler must have custom type. -or- All the input Elements should be of the following structural categories: framings, columns, profiles, plates, bolts, anchors, shear studs, welds or structural connections. -or- Total number of different input elements of input StructuralConnectionHandlers must be lower or equal to 3. -or- All the input references must belong to input StructuralConnectionHandler. After modification of StructuralConnectionHandlerType there must remain at least one subelement of structural connections category in StructuralConnectionHandler.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionSettings
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionSettings
Description: Provides access to project-wide structural connections settings.
Inherits: Element

  PROPERTIES:
    bool IncludeWarningControls { get; set; }
      Description: This property controls how Structural Connection Element is generated. If set to true and warnings are reported for given Element, additional yellow triangle is displayed.

  METHODS:
    static StructuralConnectionSettings GetStructuralConnectionSettings(Document document)
      Description: Obtains the StructuralConnectionSettings object for the specified project document.
      @document: A project document.
      Returns: The StructuralConnectionSettings object.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] StructuralConnectionType
Full Name: Autodesk.Revit.DB.Structure.StructuralConnectionType
Description: A type element that represents a connection symbol applied to structural members.
Inherits: ElementType

  PROPERTIES:
    StructuralConnectionApplyTo ApplyTo { get; }
      Description: Choose whether this connection type applies to beams and braces, to tops of columns, or to bases of columns.

  METHODS:
    static StructuralConnectionType Create(Document doc, StructuralConnectionApplyTo applyTo, string name, ElementId familySymbolId)
      Description: Create a new StructuralConnectionType, allowing the specified annotation FamilySymbol to be applied to structural members.
      @applyTo: Specify which type of member this connection type can be applied to.
      @name: A name for the connection type. It must be unique within the document.
      @familySymbolId: The id of an annotation FamilySymbol. InvalidElementId is allowed. Otherwise, the FamilySymbol must be in the category "Connection Symbols" (OST_StructConnectionSymbols) and have its "Apply To" parameter set to match the applyTo argument.
      Throws ArgumentException: familySymbolId is the id of some element that is not a FamilySymbol, is not of the category "Connection Symbols" (OST_StructConnectionSymbols), or has its "Apply To" parameter not equal to applyTo.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static void GetAllStructuralConnectionTypeIds(Document cda, out ICollection<ElementId> ids)
      Description: Collects the ids of all StructuralConnectionTypes in the document.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId GetFamilySymbolId()
      Description: FamilySymbol of the annotation to use for this connection type.
    void SetFamilySymbolId(ElementId familySymbolId)
      Description: FamilySymbol of the annotation to use for this connection type.
      Throws ArgumentException: Thrown when familySymbolId is the id of some element that is not a FamilySymbol, is not of the category "Connection Symbols" (OST_StructConnectionSymbols), or has its "Apply To" parameter not equal to this type's applyTo property.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ValidFamilySymbolId(Document doc, StructuralConnectionApplyTo applyTo, ElementId familySymbolId)
      Description: Checks whether the family symbol id is allowed for StructuralConnectionTypes with the given value for the applyTo property.
      Returns: True if %familySymbolId% is invalidElementId; or if it is the id of a FamilySymbol of category "Connection Symbols" (OST_StructConnectionSymbols) with its "Apply To" parameter set to match the applyTo property. Returns false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ABSTRACT CLASS] StructuralFramingUtils
Full Name: Autodesk.Revit.DB.Structure.StructuralFramingUtils
Description: A collection of Structural Framing Utilities.

  METHODS:
    static void AllowJoinAtEnd(FamilyInstance familyInstance, int end)
      Description: Sets the indicated end of the framing element to be allowed to join to others.
      @familyInstance: The FamilyInstance, which must be of a structural framing category.
      @end: The index of the end (0 for the start, 1 for the end).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category.
    static bool CanFlipEnds(FamilyInstance familyInstance)
      Description: Determines if the ends of the given framing element can be flipped.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete.
      Returns: True for non-concrete line, arc or ellipse framing element, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool CanSetEndReference(FamilyInstance familyInstance, int end)
      Description: Determines if a reference can be set for the given end of the framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined at the given end.
      @end: The index of the end (0 for the start, 1 for the end).
      Returns: True if reference can be set for the given end of the framing element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
    static void DisallowJoinAtEnd(FamilyInstance familyInstance, int end)
      Description: Sets the indicated end of the framing element to not be allowed to join to others.
      @familyInstance: The FamilyInstance, which must be of a structural framing category.
      @end: The index of the end (0 for the start, 1 for the end).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category.
    static void FlipEnds(FamilyInstance familyInstance)
      Description: Flips the ends of the structural framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete.
      Throws ArgumentException: The input familyInstance is concrete or is not a line, arc or ellipse element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category.
    static Reference GetEndReference(FamilyInstance familyInstance, int end)
      Description: Returns a reference to the end of a framing element according to the setback settings.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined.
      @end: The index of the end (0 for the start, 1 for the end).
      Returns: The end reference.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category or is concrete or is not joined at given end and cannot have an end reference set.
    static bool IsEndReferenceValid(FamilyInstance familyInstance, int end, Reference pick)
      Description: Determines if the given reference can be set for the given end of the framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined at the given end.
      @end: The index of the end (0 for the start, 1 for the end).
      @pick: The reference to be checked against the given end of the framing element.
      Returns: True if the given reference can be set for the given end of the framing element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
    static bool IsJoinAllowedAtEnd(FamilyInstance familyInstance, int end)
      Description: Identifies if the indicated end of the framing element is allowed to join to others.
      @familyInstance: The FamilyInstance, which must be of a structural framing category.
      @end: The index of the end (0 for the start, 1 for the end).
      Returns: True if it is allowed to join. False if it is disallowed.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category.
    static void RemoveEndReference(FamilyInstance familyInstance, int end)
      Description: Resets the end reference of the structural framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined.
      @end: The index of the end (0 for the start, 1 for the end).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category or is concrete or is not joined at given end and cannot have an end reference set.
    static void SetEndReference(FamilyInstance familyInstance, int end, Reference pick)
      Description: Sets the end reference of a framing element.
      @familyInstance: The FamilyInstance, which must be of a structural framing category, non-concrete and joined.
      @end: The index of the end (0 for the start, 1 for the end).
      @pick: The reference to set to the given end.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: end must be 0 or 1.
      Throws ArgumentsInconsistentException: The input familyInstance is not of a structural framing category or is concrete or is not joined at given end and cannot have an end reference set. -or- The input pick cannot be set as the end reference for the given end of the structural framing element.

--------------------------------------------------------------------------------

[ENUM] StructuralInstanceUsage
Full Name: Autodesk.Revit.DB.Structure.StructuralInstanceUsage
Description: Represents the structural usage of a family instance.
Inherits: Enum

  Values:
    - Undefined = 0
    - Wall = 1
    - Column = 2
    - Girder = 3
    - Joist = 4
    - Purlin = 5
    - Other = 6
    - Brace = 7
    - HorizontalBracing = 8
    - KickerBracing = 9
    - Automatic = 10
    - TrussChord = 11
    - TrussWeb = 12

--------------------------------------------------------------------------------

[CLASS] StructuralInstanceUsageFilter
Full Name: Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter
Description: A filter used to find elements that are structural family instances (typically columns, beams or braces) of the given structural usage.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new StructuralInstanceUsageFilter(StructuralInstanceUsage structuralUsage, bool inverted)
      Description: Constructs a new instance of a filter to match family instances by structural usage, with the option to match all family instances which are not of the given structural usage.
      @structuralUsage: The structural usage to match.
      @inverted: True if the filter should match all family instances which are not of the given structural usage.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new StructuralInstanceUsageFilter(StructuralInstanceUsage structuralUsage)
      Description: Constructs a new instance of a filter to match structural family instances (typically columns, beams, or braces) of the given structural usage.
      @structuralUsage: The family instance structural usage.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    StructuralInstanceUsage StructuralUsage { get; }
      Description: The family instance structural usage.

--------------------------------------------------------------------------------

[ENUM] StructuralMaterialType
Full Name: Autodesk.Revit.DB.Structure.StructuralMaterialType
Description: Represents the structural material type. This enum value is returned by Autodesk::Revit::DB::FamilyInstance::StructuralMaterialType.
Inherits: Enum

  Values:
    - Undefined = 0
    - Steel = 1
    - Concrete = 2
    - Wood = 3
    - Other = 4
    - PrecastConcrete = 5
    - Generic = 6
    - Aluminum = 7

--------------------------------------------------------------------------------

[CLASS] StructuralMaterialTypeFilter
Full Name: Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter
Description: A filter used to match family instances that have the given structural material type.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new StructuralMaterialTypeFilter(StructuralMaterialType structuralMaterialType, bool inverted)
      Description: Constructs a new instance of a filter to match family instances by structural material type, with the option to match all families which are not of the given structural material type.
      @structuralMaterialType: The structural material type to match.
      @inverted: True if the filter should match all family instances which are not of the given structural material type.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new StructuralMaterialTypeFilter(StructuralMaterialType structuralMaterialType)
      Description: Constructs a new instance of a filter to match family instances that have the given structural material type.
      @structuralMaterialType: The structural material type to match.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    StructuralMaterialType StructuralMaterialType { get; }
      Description: The structural material type.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionsServiceData
Full Name: Autodesk.Revit.DB.Structure.StructuralSectionsServiceData
Description: The data needed by section type server to perform type definition.
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The current document.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<ElementId> GetCurrentElements()
      Description: Returns the list of Ids of the current elements.
      Returns: Ids of the current elements. Contains the family base element to which the section shape type parameter belongs.

--------------------------------------------------------------------------------

[CLASS] StructuralSettings
Full Name: Autodesk.Revit.DB.Structure.StructuralSettings
Description: Provides access to project-wide structural settings.
Inherits: Element

  PROPERTIES:
    double BoundaryConditionAreaAndLineSymbolSpacing { get; set; }
      Description: Symbol spacing for boundary conditions.
    ElementId BoundaryConditionFamilySymbolFixed { get; set; }
      Description: The id of the FamilySymbol to represent a fixed boundary condition.
    ElementId BoundaryConditionFamilySymbolPinned { get; set; }
      Description: The id of the FamilySymbol to represent a pinned boundary condition.
    ElementId BoundaryConditionFamilySymbolRoller { get; set; }
      Description: The id of the FamilySymbol to represent a roller boundary condition.
    ElementId BoundaryConditionFamilySymbolUserDefined { get; set; }
      Description: The id of the FamilySymbol to represent a user-defined boundary condition.
    bool BoundarySetbackDisabledForSteelElements { get; set; }
      Description: Disallow shortening (setbacks) to joined element boundaries for beams and braces. If enabled, then beams and braces will have the setbacks set to 0 by default. Explicit setbacks to references will still be allowed.
    ElementId BraceAboveSymbol { get; set; }
      Description: The id of the ElementType to represent a brace above a beam in plan view.
    ElementId BraceBelowSymbol { get; set; }
      Description: The id of the ElementType to represent a brace below a beam in plan view.
    double BraceParallelLineOffset { get; set; }
      Description: The distance by which brace symbols in plan views will be offset.
    ElementId KickerBraceSymbol { get; set; }
      Description: The id of the ElementType to represent a kicker brace.
    bool ShowBraceAbove { get; set; }
      Description: Whether to show brace symbols above beams in plan views.
    bool ShowBraceBelow { get; set; }
      Description: Whether to show brace symbols below beams in plan views.
    double SymbolicCutbackForBeamAndTruss { get; set; }
      Description: Symbolic cutback distance to be applied to all beams and trusses.
    double SymbolicCutbackForBrace { get; set; }
      Description: Symbolic cutback distance to be applied to all braces.
    double SymbolicCutbackForColumn { get; set; }
      Description: Symbolic cutback distance to be applied to all columns.
    bool UseLoadsDisplayScaling { get; set; }
      Description: Whether to use loads display scaling. If disabled then loads are displayed according to force scale type parameters.

  METHODS:
    XYZ GetLoadForceVectorReprLine(LoadType loadType, XYZ forceVector)
      Description: Returns the representative line of the load force vector according to loads display scaling.
      @loadType: LoadType::Point, Line, or Area
      @forceVector: The load force vector in internal units.
      Returns: The the representative line in internal units.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static StructuralSettings GetStructuralSettings(Document doc)
      Description: Obtains the StructuralSettings object for the specified project document.
      @doc: A project document.
      Returns: The StructuralSettings object.
      Throws ArgumentNullException: A non-optional argument was null
    void SetValuesForLoadsDisplayScaling(double minimumLoadValue, double minimumForceLineLength, double maximumLoadValue, double maximumForceLineLength)
      Description: Sets values for loads display scaling by providing two load forces and their corresponding length of the representative lines in internal units.
      @minimumLoadValue: The minimum force in SpecTypeId.Force units.
      @minimumForceLineLength: The line length for minimum force.
      @maximumLoadValue: The maximum force in SpecTypeId.Force units.
      @maximumForceLineLength: The line length for maximum force.
      Throws ArgumentsInconsistentException: Thrown when: - forces are negative. - line lengths are negative. - minimum force is greater or equal to the maximum force. - line length for minimum force is greater than line length for maximum force.

--------------------------------------------------------------------------------

[ENUM] StructuralType
Full Name: Autodesk.Revit.DB.Structure.StructuralType
Description: Represents the structural type of a family instance.
Inherits: Enum

  Values:
    - NonStructural = 0
    - Beam = 1
    - Brace = 2
    - Column = 3
    - Footing = 4
    - UnknownFraming = 5

--------------------------------------------------------------------------------

[ENUM] StructuralWallUsage
Full Name: Autodesk.Revit.DB.Structure.StructuralWallUsage
Description: Represents the structural usage of a wall.
Inherits: Enum

  Values:
    - NonBearing = 0
    - Bearing = 1
    - Shear = 2
    - Combined = 3

--------------------------------------------------------------------------------

[CLASS] StructuralWallUsageFilter
Full Name: Autodesk.Revit.DB.Structure.StructuralWallUsageFilter
Description: A filter used to match walls that have the given structural wall usage.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new StructuralWallUsageFilter(StructuralWallUsage structuralWallUsage, bool inverted)
      Description: Constructs a new instance of a filter to match walls that have the given structural wall usage, with the option to match all walls which are not of the given structural wall usage.
      @structuralWallUsage: The structural usage to match.
      @inverted: True if the filter should match all walls which are not of the given structural wall usage.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new StructuralWallUsageFilter(StructuralWallUsage structuralWallUsage)
      Description: Constructs a new instance of a filter to match walls that have the given structural wall usage.
      @structuralWallUsage: The wall structural usage.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    StructuralWallUsage StructuralWallUsage { get; }
      Description: The wall structural usage.

--------------------------------------------------------------------------------

[ENUM] SurfaceDistributionRebarHandles
Full Name: Autodesk.Revit.DB.Structure.SurfaceDistributionRebarHandles
Description: This enum represents the values that custom handles tags of RebarConstrainedHandle of Rebar Free Form Surface Distribution has. The tag of a Autodesk::Revit::DB::Structure::RebarHandleType::CustomHandle RebarConstrainedHandle can be obtained by calling the Autodesk::Revit::DB::Structure::RebarConstrainedHandle::GetCustomHandleTag
Inherits: Enum

  Values:
    - HostSurface = 0
    - StartSurface = 1
    - EndSurface = 2

--------------------------------------------------------------------------------

[ENUM] SurfaceElementExtension
Full Name: Autodesk.Revit.DB.Structure.SurfaceElementExtension
Description: Presets for given Analytical Extension.
Inherits: Enum

  Values:
    - BottomOrTop = 0
    - Plane = 1

--------------------------------------------------------------------------------

[ENUM] SurfaceElementProjectionZ
Full Name: Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ
Description: Presets for given Analytical Projection Z.
Inherits: Enum

  Values:
    - TopOrInterior = 0
    - CenterOfElement = 1
    - BottomOrExterior = 2
    - CenterOfCore = 3
    - Plane = 4

--------------------------------------------------------------------------------

[ENUM] TargetRebarConstraintType
Full Name: Autodesk.Revit.DB.Structure.TargetRebarConstraintType
Description: A type used to identify the particular part of a Stirrup style rebar to which a Standard style rebar's handle is constrained.
Remarks: Most of the range of values for this type are the same as those of RebarHandleType, since it is usually the handles on the Stirrup which constrain the Standard bar. However, two additional values - BarBend and HookBend - are used to identify the special case of a Standard style, straight bar, running perpendicular to the plane of the Stirrup, and constrained to a bend (or hook) arc on the Stirrup.
Inherits: Enum

  Values:
    - RebarPlane = 0
    - StartOfBar = 1
    - EndOfBar = 2
    - Edge = 3
    - OutOfPlaneExtent = 4
    - BarBend = 5
    - HookBend = 6

--------------------------------------------------------------------------------

[ENUM] TranslationRotationValue
Full Name: Autodesk.Revit.DB.Structure.TranslationRotationValue
Description: Specifies the type of condition applied to the translation or rotation parameter.
Inherits: Enum

  Values:
    - Fixed = 0
    - Release = 1
    - Spring = 2

--------------------------------------------------------------------------------

[CLASS] Truss
Full Name: Autodesk.Revit.DB.Structure.Truss
Description: Represents all kinds of Trusses.
Remarks: The Truss object represents all the kinds of Trusses in Revit. The TrussType property is used to distinguish the type of the Truss.
Inherits: Element

  PROPERTIES:
    CurveArray Curves { get; }
      Description: Get all the truss curves.
    ICollection<ElementId> Members { get; }
      Description: Get all the members of truss.
    TrussType TrussType { get; set; }
      Description: Retrieve/set an object that represents the type of the truss.

  METHODS:
    void AttachChord(Element attachToElement, TrussChordLocation location, bool forceRemoveSketch)
      Description: Attach a truss's specific chord to a specified element, the element should be a roof or floor.
      @attachToElement: The element to which the truss's chord will attach. The element should be a roof or floor.
      @location: The chord need to be attached.
      @forceRemoveSketch: Whether to detach the original sketch if there is one.
    static Truss Create(Document document, ElementId trussTypeId, ElementId sketchPlaneId, Curve curve)
      Description: Creates a new Truss.
      @document: The document in which the new Truss is created.
      @trussTypeId: Element id of the truss type.
      @sketchPlaneId: Element id of a SketchPlane.
      @curve: The curve of the truss element. It must be a line, must not be a vertical line, and must be within the sketch plane.
      Throws ArgumentException: The input curve points to a helical curve and is not supported for this operation. -or- The element id should refer to a valid TrussType. -or- The element id should refer to a valid SketchPlane. -or- The curve is invalid to be the base curve of a truss.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This function is only enabled in Revit Structure and Revit Architecture. -or- Failed to create Truss element.
    void DetachChord(TrussChordLocation location)
      Description: Detach a truss's specific chord from the element to which it is attached.
      @location: The chord.
    static void DropTruss(Truss truss)
      Description: Drop truss Family, it will disassociate all members from the truss and delete the truss.
      @truss: The truss to be dropped.
    TrussMemberInfo GetTrussMemberInfo(ElementId elemId)
      Description: Query if a given element is a member of a truss, its lock status and its usage, etc.
      @elemId: The querying element.
      Returns: A struct TrussMemberInfo that contains the querying element's host truss, whether to lock to the truss, usage type, etc.
    void RemoveProfile()
      Description: Remove the profile of a truss.
    void SetProfile(CurveArray topChords, CurveArray bottomChords)
      Description: Add or modify the profile of a truss.
      @topChords: The curves serving as top chords of the truss.
      @bottomChords: The curves serving as bottom chords of the truss.
    void TogglePinMember(ElementId elemId)
      Description: Pin/Unpin a truss member.
      @elemId: The member element is going to pin/unpin.

--------------------------------------------------------------------------------

[ENUM] TrussChordLocation
Full Name: Autodesk.Revit.DB.Structure.TrussChordLocation
Description: This enumerated type represents the options for the Truss Chord Location.
Inherits: Enum

  Values:
    - Bottom = 0
    - Top = 1

--------------------------------------------------------------------------------

[ENUM] TrussCurveType
Full Name: Autodesk.Revit.DB.Structure.TrussCurveType
Description: Types of curves created in truss families.
Inherits: Enum

  Values:
    - NonTrussCurve = 0
    - TopChord = 1
    - BottomChord = 2
    - Web = 3

--------------------------------------------------------------------------------

[CLASS] TrussMemberInfo
Full Name: Autodesk.Revit.DB.Structure.TrussMemberInfo
Description: Provides access to the information of a truss member in Autodesk Revit.
Remarks: A struct TrussMemberInfo that contains an element's host truss, whether to lock to the truss, usage type, etc.

  CONSTRUCTORS:
    new TrussMemberInfo()
      Description: For Internal Use Only.

  PROPERTIES:
    ElementId hostTrussId { get; set; }
      Description: The host truss' ElementId of the member.
    bool lockedToTruss { get; set; }
      Description: Whether the member is locked to the host truss.
    TrussMemberType memberTypeKey { get; set; }
      Description: Kind of the member in the truss.

--------------------------------------------------------------------------------

[ENUM] TrussMemberType
Full Name: Autodesk.Revit.DB.Structure.TrussMemberType
Description: Indicates the "kind" of a truss member.
Inherits: Enum

  Values:
    - ETK_Unknown = 0
    - ETK_TrussTopChord = 1
    - ETK_TrussBottomChord = 2
    - ETK_TrussVertWeb = 3
    - ETK_TrussDiagWeb = 4

--------------------------------------------------------------------------------

[CLASS] TrussType
Full Name: Autodesk.Revit.DB.Structure.TrussType
Description: Represents a specific type of truss.
Inherits: FamilySymbol

--------------------------------------------------------------------------------

[ENUM] WireDistributionDirection
Full Name: Autodesk.Revit.DB.Structure.WireDistributionDirection
Description: Defines the direction of the distribution of wires in a Fabric Sheet.
Inherits: Enum

  Values:
    - Major = 0
    - Minor = 1

--------------------------------------------------------------------------------

[ENUM] YJustification
Full Name: Autodesk.Revit.DB.Structure.YJustification
Description: The justification of the framing element in Y.
Inherits: Enum

  Values:
    - Left = 0
    - Center = 1
    - Origin = 2
    - Right = 3

--------------------------------------------------------------------------------

[ENUM] YZJustificationOption
Full Name: Autodesk.Revit.DB.Structure.YZJustificationOption
Description: The option for whether a framing element has independent or uniform justification on its ends.
Inherits: Enum

  Values:
    - Uniform = 0
    - Independent = 1

--------------------------------------------------------------------------------

[ENUM] ZJustification
Full Name: Autodesk.Revit.DB.Structure.ZJustification
Description: The justification of the framing element in Z.
Inherits: Enum

  Values:
    - Top = 0
    - Center = 1
    - Origin = 2
    - Bottom = 3

--------------------------------------------------------------------------------

