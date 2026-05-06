# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[ENUM] MarginType
Full Name: Autodesk.Revit.DB.MarginType
Description: An enumerated type listing all Margin types of Print Setting.
Inherits: Enum

  Values:
    - NoMargin = 0
    - PrinterLimit = 1
    - UserDefined = 2

--------------------------------------------------------------------------------

[ENUM] MassDisplayTemporaryOverrideType
Full Name: Autodesk.Revit.DB.MassDisplayTemporaryOverrideType
Description: This enum identifies the mass display overrides.
Inherits: Enum

  Values:
    - ShowMassByViewSettings = 0
    - ShowMassFormAndFloors = 1
    - ShowMassSurfaceTypes = 2
    - ShowMassZonesAndShades = 3

--------------------------------------------------------------------------------

[CLASS] MassInstanceUtils
Full Name: Autodesk.Revit.DB.MassInstanceUtils
Description: A static class that contains methods for processing curves driven by points.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static ElementId AddMassLevelDataToMassInstance(Document document, ElementId massInstanceId, ElementId levelId)
      Description: Create a MassLevelData (Mass Floor) to associate a Level with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      @levelId: The ElementId of the Level to associate with the mass instance.
      Returns: The ElementId of the MassLevelData that was created, or the existing ElementId if it was already in added.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance. -or- The ElementId levelId is not a Level.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    static double GetGrossFloorArea(Document document, ElementId massInstanceId)
      Description: Get the total occupiable floor area represented by a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The gross floor area in square feet.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance.
      Throws ArgumentNullException: A non-optional argument was null
    static double GetGrossSurfaceArea(Document document, ElementId massInstanceId)
      Description: Get the total exterior building surface area represented by a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The gross surface area in square feet.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance.
      Throws ArgumentNullException: A non-optional argument was null
    static double GetGrossVolume(Document document, ElementId massInstanceId)
      Description: Get the total building volume represented by a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The gross volume in cubic feet.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> GetJoinedElementIds(Document document, ElementId massInstanceId)
      Description: Get the ElementIds of Elements that are joined to a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: ElementIds of Elements joined to the mass instance.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> GetMassLevelDataIds(Document document, ElementId massInstanceId)
      Description: Get the ElementIds of the MassLevelDatas (Mass Floors) associated with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The ElementIds of the MassLevelDatas.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ElementId> GetMassLevelIds(Document document, ElementId massInstanceId)
      Description: Get the ElementIds of the Levels associated with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The ElementIds of the Levels
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance.
      Throws ArgumentNullException: A non-optional argument was null
    static void RemoveMassLevelDataFromMassInstance(Document document, ElementId massInstanceId, ElementId levelId)
      Description: Delete the MassLevelData (Mass Floor) that associates a Level with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      @levelId: The ElementId of the Level to disassociate from the mass instance.
      Throws ArgumentException: The ElementId massInstanceId is not a mass instance. -or- The ElementId levelId is not a Level.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Material
Full Name: Autodesk.Revit.DB.Material
Description: Represents a material element within an Autodesk Revit project.
Inherits: Element

  PROPERTIES:
    ElementId AppearanceAssetId { get; set; }
      Description: The ElementId of the AppearanceAssetElement.
    Color Color { get; set; }
      Description: The color of the material.
    Color CutBackgroundPatternColor { get; set; }
      Description: The color of the material cut background pattern.
    ElementId CutBackgroundPatternId { get; set; }
      Description: The id of the FillPatternElement used as the background pattern of faces with this material in cut views.
    Color CutForegroundPatternColor { get; set; }
      Description: The color of the material cut foreground pattern.
    ElementId CutForegroundPatternId { get; set; }
      Description: The id of the FillPatternElement used as the foreground pattern of faces with this material in cut views.
    string MaterialCategory { get; set; }
      Description: The name of the material category, e.g. 'Wood'
    string MaterialClass { get; set; }
      Description: The name of the general material type, e.g. 'Wood.'
    int Shininess { get; set; }
      Description: The shininess of the material.
    int Smoothness { get; set; }
      Description: The smoothness of the material.
    ElementId StructuralAssetId { get; set; }
      Description: The ElementId of the structural PropertySetElement.
    Color SurfaceBackgroundPatternColor { get; set; }
      Description: The color of the material surface background pattern.
    ElementId SurfaceBackgroundPatternId { get; set; }
      Description: The id of the FillPatternElement used as the background pattern of faces with this material in normal views.
    Color SurfaceForegroundPatternColor { get; set; }
      Description: The color of the material surface foreground pattern.
    ElementId SurfaceForegroundPatternId { get; set; }
      Description: The id of the FillPatternElement used as the foreground pattern of faces with this material in normal views.
    ElementId ThermalAssetId { get; set; }
      Description: The ElementId of the thermal PropertySetElement.
    int Transparency { get; set; }
      Description: The transparency of the material.
    bool UseRenderAppearanceForShading { get; set; }
      Description: True to use the render appearance settings for shaded view appearance; false to use the material's color and transparency value for shaded view appearance.

  METHODS:
    void ClearMaterialAspect(MaterialAspect aspect)
      Description: Removes an aspect from the material.
      @aspect: The material aspect.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static ElementId Create(Document document, string name)
      Description: Creates a new material.
      @document: The document in which to create the material.
      @name: The name of the new material.
      Returns: Identifier of the new material.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a material element name.
      Throws ArgumentNullException: A non-optional argument was null
    Material Duplicate(string name)
      Description: Duplicates the material
      @name: Name of the new material - this name must be correctly structured for Revit use and not duplicate the name of another material in the document.
      Returns: The new material.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a material element name.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsMaterialOrValidDefault(Element pElem, ElementId materialId)
      Description: Validates whether the specified element id is a material element.
      @pElem: An element which will be applied the material
      @materialId: The element id to be checked.
      Returns: True if the element a material element or invalidElementId, which means take material from category, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsNameUnique(Document aDocument, string name)
      Description: Validates whether the material name is unique in document.
      @aDocument: The document in which the name is being tested for uniqueness.
      @name: The name tested for uniqueness.
      Returns: Returns true if the name is unique, and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMaterialAspectByPropertySet(MaterialAspect aspect, ElementId propertySetId)
      Description: Sets an aspect of the material to a shared property set.
      @aspect: The material aspect.
      @propertySetId: Identifier of a shared property set (an instance of PropertySetElement).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] MaterialAspect
Full Name: Autodesk.Revit.DB.MaterialAspect
Description: A list of all material aspects that a material can store PropertySetElements for.
Inherits: Enum

  Values:
    - Structural = 0
    - Thermal = 1

--------------------------------------------------------------------------------

[ENUM] MaterialFunctionAssignment
Full Name: Autodesk.Revit.DB.MaterialFunctionAssignment
Description: Used in class CompoundStructure to specify the function of a layer.
Remarks: The function is used primarily to determine layer priority which affects how layers of distinct elements interact at a join. Typically, layers penetrate lower priority layers and merge with layers of the same priority.
Inherits: Enum

  Values:
    - None = 0
    - Structure = 1
    - Substrate = 2
    - Insulation = 3
    - Finish1 = 4
    - Finish2 = 5
    - Membrane = 100
    - StructuralDeck = 200

--------------------------------------------------------------------------------

[CLASS] MaterialNode
Full Name: Autodesk.Revit.DB.MaterialNode
Description: This class represents a change of material during a model-exporting process.
Remarks: Output nodes following this node are to be assumed using the material. The material remains in effect until another material node is sent to the output.See also: MaterialNode).
Inherits: RenderNode

  PROPERTIES:
    Color Color { get; }
      Description: The color the material is being rendered at
    int Glossiness { get; }
      Description: The level of glossiness of the material
    bool HasOverriddenAppearance { get; }
      Description: Identifies if the default rendering appearance the material has is being overridden.
    ElementId MaterialId { get; }
      Description: The Id of the element assocated with this material in the model.
    int Smoothness { get; }
      Description: The level of smoothness of the material.
    string ThumbnailFile { get; }
      Description: The path if a file that contains a thumbnail image of the material.
    double Transparency { get; }
      Description: The value of transparency the material is being rendered with

  METHODS:
    Asset GetAppearance()
      Description: Appearance properties associated with the material.
      Returns: An instance of a rendering material asset
    Asset GetAppearanceOverride()
      Description: Returns appearance properties that override the preset appearance of the material.
      Returns: An instance of a rendering material asset, of null if there is no override.

--------------------------------------------------------------------------------

[ENUM] MaterialPropertyPathType
Full Name: Autodesk.Revit.DB.MaterialPropertyPathType
Description: Enum class indicating kinds of paths which ExternalFileReferenceType.Material references can have.
Inherits: Enum

  Values:
    - General = 0
    - Transparency = 1
    - Cutouts = 2
    - Bump = 3
    - FinishBumps = 4
    - ReliefPattern = 5
    - Weathering = 6

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MathComparisonUtils
Full Name: Autodesk.Revit.DB.MathComparisonUtils
Description: This class contains a set of mathematical utilities to compare doubles, using the internal tolerance.

  METHODS:
    static bool IsAlmostEqual(double value1, double value2)
      Description: Checks if two doubles are almost equal, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if two doubles are almost equal, false otherwise.
      Throws ArgumentException: The given value for value1 is not finite -or- The given value for value2 is not finite
    static bool IsAlmostZero(double value)
      Description: Checks if value is almost zero, using the internal tolerance.
      @value: The value to check.
      Returns: True if value is almost zero, false otherwise.
      Throws ArgumentException: The given value for value is not finite
    static bool IsGreaterThan(double value1, double value2)
      Description: Checks if value1 is strictly greater than value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is strictly greater than value2, false otherwise.
      Throws ArgumentException: The given value for value1 is not finite -or- The given value for value2 is not finite
    static bool IsGreaterThanOrAlmostEqual(double value1, double value2)
      Description: Checks if value1 is greater than or almost equal to value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is greater than or almost equal to value2, false otherwise.
      Throws ArgumentException: The given value for value1 is not finite -or- The given value for value2 is not finite
    static bool IsLessThan(double value1, double value2)
      Description: Checks if value1 is strictly less than value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is strictly less than value2, false otherwise.
      Throws ArgumentException: The given value for value1 is not finite -or- The given value for value2 is not finite
    static bool IsLessThanOrAlmostEqual(double value1, double value2)
      Description: Checks if value1 is less than or almost equal to value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is less than or almost equal to value2, false otherwise.
      Throws ArgumentException: The given value for value1 is not finite -or- The given value for value2 is not finite

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalConnection
Full Name: Autodesk.Revit.DB.MEPAnalyticalConnection
Description: Represents an analytical element that connects mechanical equipment to piping network.
Remarks: The analytical connection takes mechanical equipment into account of network flow/pressure analysis. The connection remains the same even if the mechanical equipment moves and rotates. It enables a fast establishment of piping network to analyze the flow and pressure, especially at the early stage of the design process.
Inherits: MEPCurve

  METHODS:
    static bool CanSupportAnalyticalConnection(Connector connector)
      Description: Checks if the connector can support the analytical connection.
      @connector: The testing connector.
      Returns: True if the connector can support the network flow/pressure analysis, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static MEPAnalyticalConnection Create(Document doc, ElementId typeId, Connector startConnector, Connector endConnector)
      Description: Creates a new analytical connection between two open connectors.
      @doc: The document where the new element is created.
      @typeId: The type of new analytical connection.
      @startConnector: The open connector on the equipment side, whose level is inherited by the analytical connection.
      @endConnector: The open connector on the network.
      Returns: The newly created analytical connection element.
      Throws ArgumentException: Invalid connection type. -or- The connector does not support analytical connection.
      Throws ArgumentNullException: A non-optional argument was null
    static ISet<ElementId> CreateMultipleConnections(Document doc, ElementId typeId, IList<Connector> equipmentOpenConnectors, IList<ElementId> curveIdsToConnect)
      Description: Creates new analytical connections between the equipment connector and the nearest point on the curves.
      @doc: The document where the new elements are created.
      @typeId: The type of new analytical connections.
      @equipmentOpenConnectors: The open equipment connectors to be analytically connected.
      @curveIdsToConnect: The curves which the equipment is connected to.
      Returns: The new analytical connection elements.
      Throws ArgumentException: Invalid connection type. -or- Not all connectors support the analytical connection. -or- No connector included. -or- Not all elements are valid curve ids. -or- No curve included.
      Throws ArgumentNullException: A non-optional argument was null
    double GetFlow()
      Description: Gets the flow value of this analytical connection.
      Returns: The flow value.

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalConnectionType
Full Name: Autodesk.Revit.DB.MEPAnalyticalConnectionType
Description: Represents an analytical connection type between mechanical equipment and piping network.
Inherits: ElementType

  PROPERTIES:
    double PressureLoss { get; set; }
      Description: The pressure loss of this analytical connection type.

  METHODS:
    static MEPAnalyticalConnectionType Create(Document doc, string name)
      Description: Creates an analytical connection type element.
      @doc: The document.
      @name: The name of the analytical type to be created.
      Returns: The created analytical connection type element.
      Throws ArgumentException: This name is already used by an existing analytical connection type in the document. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId FindTypeByName(Document doc, string name)
      Description: Finds the analytical connection type by its name.
      @doc: The document where the analytical conneciton type is expected.
      @name: The name of the expected analytical connection type.
      Returns: The element id of matched analytical connection type, otherwise invalidElementId.
      Throws ArgumentException: name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsNameUnused(Document doc, string name)
      Description: Checks if this is an unused name.
      @doc: The document.
      @name: The name to be verified.
      Returns: True if not used by an existing analytical connection type in this document, false if used.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPCalculationServerInfo
Full Name: Autodesk.Revit.DB.MEPCalculationServerInfo
Description: a struct to hold the information about a MEP calucation servers
Implements: IDisposable

  CONSTRUCTORS:
    new MEPCalculationServerInfo(MEPCalculationServerInfo other)
      Description: Constructs a new copy of the input MEPCalculationServerInfo object.
      Throws ArgumentNullException: A non-optional argument was null
    new MEPCalculationServerInfo(IExternalServer server)
      Description: Create a new MEPCalculationServerInfo by an external server.
      @server: The external server.
      Throws ArgumentNullException: A non-optional argument was null
    new MEPCalculationServerInfo()
      Description: Constructs a new MEPCalculationServerInfo with default settings.

  PROPERTIES:
    string Description { get; set; }
      Description: The Description of the server.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    static Guid PipeUseDefinitionOnTypeGUID { get; }
      Description: The guid value ("3BF616F9-6B98-4A21-80FF-DA1120C8F6D6") of Use Definition On Type. It is not a server id, but a guid to tell if the loss method is "Use Definition On Type" or not. If the loss method is "Use Definition On Type", we use the loss method of the family type to calculate.
    Guid ServerId { get; set; }
      Description: The Id of the server.
    string ServerName { get; set; }
      Description: The Name of the server.

  METHODS:
    void Dispose()
    static MEPCalculationServerInfo GetMEPCalculationServerInfo(FamilyInstance famInst)
      Description: Gets a MEPCalculationServerInfo by family instance.
      @famInst: The family instance.
      Returns: The MEPCalculationServerInfo.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPConnectorInfo
Full Name: Autodesk.Revit.DB.MEPConnectorInfo
Description: MEP connector information.
Implements: IDisposable

  PROPERTIES:
    bool IsPrimary { get; }
      Description: True if this is the primary connector.
    bool IsSecondary { get; }
      Description: True if this is the secondary connector.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Connector LinkedConnector { get; }
      Description: The linked connector or if there is no linked connector

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] MEPCurve
Full Name: Autodesk.Revit.DB.MEPCurve
Description: A curve object for duct or pipe blend elements.
Remarks: The curve object is only available in the Autodesk Revit MEP product.
Inherits: HostObject

  PROPERTIES:
    ConnectorManager ConnectorManager { get; }
      Description: The connector manager of this MEP curve.
    double Diameter { get; }
      Description: The diameter of the MEP curve.
    double Height { get; }
      Description: The height of the MEP curve.
    double LevelOffset { get; set; }
      Description: The offset of the MEP curve.
    MEPSystem MEPSystem { get; }
      Description: The system of the MEP curve.
    Level ReferenceLevel { get; set; }
      Description: The reference level of the MEP curve.
    double Width { get; }
      Description: The width of the MEP curve.

--------------------------------------------------------------------------------

[CLASS] MEPCurveType
Full Name: Autodesk.Revit.DB.MEPCurveType
Description: The base type class for MEP curves, such as ducts, pipes, cable trays and conduits.
Inherits: HostObjAttributes

  PROPERTIES:
    FamilySymbol Cross { get; set; }
      Description: The default cross fitting of the MEP curve type.
    FamilySymbol Elbow { get; set; }
      Description: The default elbow fitting of the MEP curve type.
    FamilySymbol MultiShapeTransition { get; set; }
      Description: The default multi shape transition fitting of the MEP curve type.
    JunctionType PreferredJunctionType { get; set; }
      Description: The preferred junction type of the MEP curve type.
    double Roughness { get; set; }
      Description: The roughness of the MEP curve type. For PipeTypes, please use Segment::Roughness
    RoutingPreferenceManager RoutingPreferenceManager { get; }
      Description: The RoutingPreferenceManager for the MEPCurveType
    ConnectorProfileType Shape { get; }
      Description: The shape of the profile.
    FamilySymbol Tap { get; set; }
      Description: The default tap fitting of the MEP curve type.
    FamilySymbol Tee { get; set; }
      Description: The default tee fitting of the MEP curve type.
    FamilySymbol Transition { get; set; }
      Description: The default transition fitting of the MEP curve type.
    FamilySymbol Union { get; set; }
      Description: The default union fitting of the MEP curve type.

--------------------------------------------------------------------------------

[CLASS] MEPFamilyConnectorInfo
Full Name: Autodesk.Revit.DB.MEPFamilyConnectorInfo
Description: MEP family connector information.
Inherits: MEPConnectorInfo

  METHODS:
    ElementId GetAssociateFamilyParameterId(ElementId connectorParameterId)
      Description: Gets the associate family parameter id of the specified connector parameter id.
      @connectorParameterId: connectorParameterId is defined in the family connector element.
      Returns: Returns valid ElementId if the connectorParameterId associates to one family parameter; otherwise returns invalid ElementId.
      Throws ArgumentNullException: A non-optional argument was null
    ParameterValue GetConnectorParameterValue(ElementId connectorParameterId)
      Description: Gets the parameter value of the specified connector parameter id.
      @connectorParameterId: connectorParameterId is defined in the family connector element.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPModel
Full Name: Autodesk.Revit.DB.MEPModel
Description: Supports all MEP models that are persistent within the Autodesk Revit project.
Inherits: APIObject

  PROPERTIES:
    ConnectorManager ConnectorManager { get; }
      Description: Retrieves the Connector Manager from this MEPModel.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    ISet<ElectricalSystem> GetAssignedElectricalSystems()
      Description: Retrieves the electrical systems this electrical panel currently is assigned to.
    ISet<ElectricalSystem> GetElectricalSystems()
      Description: Retrieves the electrical systems that are currently created using this MEPModel.

--------------------------------------------------------------------------------

[CLASS] MEPSize
Full Name: Autodesk.Revit.DB.MEPSize
Description: Stores the basic size information for an MEP duct, pipe, cable tray, or conduit.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPSize(double nominalDiameter, double innerDiameter, double outerDiameter, bool usedInSizeLists, bool usedInSizing)
      Description: Constructs an object that stores the basic size information for MEP duct, pipe, cable tray and conduit.
      @nominalDiameter: Nominal diameter. The value should be a valid, positive Revit length.
      @innerDiameter: Inner diameter. The value should be a valid, positive Revit length.
      @outerDiameter: Outer diameter. The value should be a valid, positive Revit length.
      @usedInSizeLists: Whether it is used in size lists.
      @usedInSizing: Whether is used in sizing.
      Throws ArgumentOutOfRangeException: The given value for nominalDiameter must be greater than 0 and no more than 30000 feet. -or- The given value for innerDiameter must be greater than 0 and no more than 30000 feet. -or- The given value for outerDiameter must be greater than 0 and no more than 30000 feet.

  PROPERTIES:
    double InnerDiameter { get; }
      Description: Inner diameter
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double NominalDiameter { get; }
      Description: Nominal diameter
    double OuterDiameter { get; }
      Description: Outer diameter
    bool UsedInSizeLists { get; }
      Description: Whether it is used in size lists.
    bool UsedInSizing { get; }
      Description: Whether is used in sizing.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MEPSupportUtils
Full Name: Autodesk.Revit.DB.MEPSupportUtils
Description: General utility methods for the Autodesk Revit MEP Supporting components.

  METHODS:
    static FamilyInstance CreateDuctworkStiffener(Document document, ElementId familySymbolId, ElementId hostId, double distanceFromHostEnd)
      Description: Create family based stiffener on the specified fabrication ductwork.
      @document: The document.
      @familySymbolId: The id of a stiffener FamilySymbol.
      @hostId: The id of the host ductwork.
      @distanceFromHostEnd: The distance from the host primary end to place the hosted instance. Units are in feet (ft).
      Returns: The new stiffener family instance.
      Throws ArgumentException: document is not a project document. -or- familySymbolId is not a valid Element identifier. -or- hostId is not a valid Element identifier. -or- Invalid familySymbolId for stiffeners. -or- Host is not a straight ductwork.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The distance from host primary end is out of range.
      Throws InvalidOperationException: The profiles of family symbol and host are mismatch.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
      Throws RegenerationFailedException: Failed to create stiffener due to document regenerate error.

--------------------------------------------------------------------------------

[CLASS] MEPSystem
Full Name: Autodesk.Revit.DB.MEPSystem
Description: A system in the Autodesk Revit MEP product.
Remarks: This is the base class for electrical, mechanical and piping systems, available only in the Autodesk Revit MEP product.
Inherits: Element

  PROPERTIES:
    FamilyInstance BaseEquipment { get; }
      Description: The base panel or equipment of the system.
    Connector BaseEquipmentConnector { get; }
      Description: The connector within base equipment which is used to connect with system.
    ConnectorManager ConnectorManager { get; }
      Description: Connector manager of the system.
    ElementSet Elements { get; }
      Description: Terminal elements in the system.
    bool HasDesignParts { get; }
      Description: Indicates if the system has one or more design parts.
    bool HasFabricationParts { get; }
      Description: Indicates if the system has one or more fabrication parts.
    bool HasPlaceholders { get; }
      Description: Indicates if the system has one or more placeholders.
    bool IsEmpty { get; }
      Description: Indicates if the system is empty or not.
    bool IsMultipleNetwork { get; }
      Description: Indicates if the system is well connected or not. The flag will enable the "Divide System" button.
    bool IsValid { get; }
      Description: Indicates if the system is valid or not. atom AtomValidateSystem default false
    double PressureLossOfCriticalPath { get; }
      Description: The total pressure loss of the sections in critical path.
    int SectionsCount { get; }
      Description: The number of sections.

  METHODS:
    void Add(ConnectorSet connectors)
      Description: Add elements into the system and connect them with the system using given connectors.
      @connectors: Connectors which are used to connect with the system.
      Throws ArgumentNullException: Thrown when the input argument connectors is , or any connector in that collection is .
      Throws ArgumentException: Throw when any of the input connectors have been already used, or when they don't share the same domain or system type as the system.
      Throws InvalidOperationException: Thrown when the operation failed.
      Throws ForbiddenForDynamicUpdateException: Thrown if this method is called during dynamic update.
    ICollection<ElementId> DivideSystem(Document ADoc)
      Description: Divide the phyisical networks in the system and create a new system for each network.
      @ADoc: The document.
      Returns: The id of new created systems.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The system is not dividable.
    IList<int> GetCriticalPathSectionNumbers()
      Description: Obtains a list of the critical path section numbers.
      Returns: The section numbers.
    int GetPhysicalNetworksNumber()
      Description: Get the physical networks number in the system.
      Returns: The number of physical networks.
    MEPSection GetSectionByIndex(int index)
      Description: Get the section from the index.
      @index: The index of the section in the system.
      Returns: The section.
      Throws ArgumentOutOfRangeException: The section index is out of range.
    MEPSection GetSectionByNumber(int sectionNumber)
      Description: Get the Section from section number
      @sectionNumber: The Section number.
      Returns: The section. if the no section exists for the input section number.
    bool IsSystemDividable()
      Description: Checks if the system is dividable. The system is dividable if there is more than one physical network in the system. Currently, only HVAC and piping systems support dividing.
      Returns: True if the system can be divided.
    void Remove(ICollection<ElementId> elementIds)
      Description: Remove elements from system.
      @elementIds: The elements to be removed from the system.
      Throws ArgumentNullException: Thrown when the input argument elements is , or any element in that collection is .
      Throws ArgumentException: Thrown when some of the elements can't be removed, or when trying to remove all elements from the system. The element which connect to the base equipment can't be removed,
      Throws InvalidOperationException: Thrown when the operation failed.
    void Remove(ConnectorSet connectors)
      Description: Removes connectors from system.
      @connectors: The connectors to be removed from the system.
      Throws ArgumentNullException: Thrown when the input argument elements is , or any element in that collection is .
      Throws ArgumentException: Thrown when some of the connectors can't be removed, or when trying to remove all connectors from the system.
      Throws InvalidOperationException: Thrown when the operation failed.

--------------------------------------------------------------------------------

[ENUM] MEPSystemClassification
Full Name: Autodesk.Revit.DB.MEPSystemClassification
Description: This enumeration is used to classify MEP connectors and systems and drives certain behavior for a particular system type
Inherits: Enum

  Values:
    - UndefinedSystemClassification = 0
    - SupplyAir = 1
    - ReturnAir = 2
    - ExhaustAir = 3
    - OtherAir = 4
    - DataCircuit = 5
    - PowerCircuit = 6
    - SupplyHydronic = 7
    - ReturnHydronic = 8
    - Telephone = 9
    - Security = 10
    - FireAlarm = 11
    - NurseCall = 12
    - Controls = 13
    - Communication = 14
    - CondensateDrain = 15
    - Sanitary = 16
    - Vent = 17
    - Storm = 18
    - DomesticHotWater = 19
    - DomesticColdWater = 20
    - Recirculation = 21
    - OtherPipe = 22
    - FireProtectWet = 23
    - FireProtectDry = 24
    - FireProtectPreaction = 25
    - FireProtectOther = 26
    - SwitchTopology = 27
    - Fitting = 28
    - Global = 29
    - PowerBalanced = 30
    - PowerUnBalanced = 31
    - CableTrayConduit = 32

--------------------------------------------------------------------------------

[CLASS] MEPSystemType
Full Name: Autodesk.Revit.DB.MEPSystemType
Description: A system type in the Autodesk Revit MEP product.
Remarks: This is the base class for mechanical and piping system types, available only in the Autodesk Revit MEP product.
Inherits: ElementType

  PROPERTIES:
    string Abbreviation { get; set; }
      Description: Identifies the abbreviation, the short name, for the system type
    SystemCalculationLevel CalculationLevel { get; set; }
      Description: Identifies the calculation level for the system type.
    Color FillColor { get; set; }
      Description: Indicates the color that should override the fill color for all components in the system.
    ElementId FillPatternId { get; set; }
      Description: Indicates the fill pattern id that should override the fill pattern id for all components in the system.
    bool FillVisible { get; set; }
      Description: Indicates the visibility of the fill pattern for all components in the system.
    Color LineColor { get; set; }
      Description: Indicates the color that should override the line color for all components in the system.
    ElementId LinePatternId { get; set; }
      Description: Indicates the line pattern id that should override the line pattern id for all components in the system.
    int LineWeight { get; set; }
      Description: Indicates the weight that should override the line weight for all components in the system.
    ElementId MaterialId { get; set; }
      Description: Indicates the material id that should override the material for all components in the system.
    MEPSystemClassification SystemClassification { get; }
      Description: Identifies the classification for the system type

--------------------------------------------------------------------------------

[CLASS] Mesh
Full Name: Autodesk.Revit.DB.Mesh
Description: A triangular mesh.
Remarks: Meshes are generated during triangulation of faces. They can also be encountered directly in Revit geometry (typically imported geometry). Meshes contain a single array of Vertices, and a corresponding array of triangles. Triangles can be accessed by index from Int32), and reference 3 vertices from the Vertices array.
Inherits: GeometryObject

  PROPERTIES:
    DistributionOfNormals DistributionOfNormals { get; }
      Description: Indicates the distribution of normal vectors along the tessellated mesh surface.
    bool IsClosed { get; }
      Description: Indicates whether the mesh is closed.
    ElementId MaterialElementId { get; }
      Description: Element ID of the material from which this mesh is composed.
    int NumberOfNormals { get; }
      Description: The number of normals associated with the mesh.
    int NumTriangles { get; }
      Description: The number of triangles that the mesh contains.
    Mesh Transformed { get; }
    MeshTriangle Triangle { get; }
    IList<XYZ> Vertices { get; }
      Description: Retrieves all vertices used to define this mesh. Intended for indexed access.

  METHODS:
    double ComputeSurfaceArea()
      Description: Computes and returns the surface area of the mesh. The surface area is the sum of the areas of the constituent facets of the mesh.
      Returns: A double, representing the surface area.
    XYZ GetNormal(int idx)
      Description: Returns a normal unit vector at the given index.
      @idx: A zero-based index. It must be consistent with the DistributionOfNormals.
      Returns: XYZ value representing a normal unit vector.
      Throws ArgumentException: The given value is not a valid index of a normal of the mesh. A valid value is not negative and is smaller than the number of normals in the mesh.
    IList<XYZ> GetNormals()
      Description: Returns all normals assigned to the mesh.
      Returns: An array of XYZ values, each representing a normal unit vector.

--------------------------------------------------------------------------------

[ENUM] MeshFromGeometryOperationIssue
Full Name: Autodesk.Revit.DB.MeshFromGeometryOperationIssue
Description: Issues encountered while constructing meshes as fallbacks for geometrical operations.
Inherits: Enum

  Values:
    - AllFine = 0
    - NoUsableCurveLoopsInInput = 1
    - MissingCurveLoopsInInput = 2
    - EmptyCurveLoopsInInput = 3
    - CurveLoopsWithoutCurvesInInput = 4
    - NonPlanarProfileLoop = 5
    - InputCurveLoopProblemWithFallback = 6
    - InputCurveLoopWrongOpenFlag = 7
    - NonContinuousInputCurveLoop = 8
    - MissingCurvesInInputLoop = 9
    - InternalUtilityError = 10
    - InternalMissingError = 11
    - InternalError = 12
    - NotSetYet = 13
    - NumberOfIssueTypes = 14

--------------------------------------------------------------------------------

[CLASS] MeshFromGeometryOperationResult
Full Name: Autodesk.Revit.DB.MeshFromGeometryOperationResult
Description: Describes what TessellatedShapeBuilder has built.
Implements: IDisposable

  PROPERTIES:
    bool HasInvalidData { get; }
      Description: Whether the provided data for which this result was obtained were internally inconsistent and could not be used in its entirety. For example, for extrusion operation, profile loops were degenerate or improperly oriented with respect to the extrsuion direction.
    bool IsMeshAvailable { get; }
      Description: Shows whether the result still contains the mesh which was constructed, if any, or whether it has been relinquished by 'getMesh'. The former is true, the later is false.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Tessellated { get; }
      Description: Whether while constructing a mesh, it was necessary to extrude polylines instead of non-linear curves from the profile loops.

  METHODS:
    void Dispose()
    IList<MeshFromGeometryOperationIssue> GetIssues()
      Description: Returns the array of issues encountered while building a mesh.
      Returns: Array of issues encountered while building a mesh.
    Mesh GetMesh()
      Description: This returns a valid mesh only for the first call. Later calls will throw an exception as the mesh is no longer valid in this object.
      Returns: Mesh which built.
      Throws InvalidOperationException: The Mesh has already been accessed by a previous GetMesh() call, and is no longer available for use.

--------------------------------------------------------------------------------

[CLASS] MeshTriangle
Full Name: Autodesk.Revit.DB.MeshTriangle
Description: One triangle of a mesh.

  PROPERTIES:
    uint Index { get; }
    XYZ Vertex { get; }

--------------------------------------------------------------------------------

[CLASS] ModelArc
Full Name: Autodesk.Revit.DB.ModelArc
Description: Represents a ModelArc within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve

--------------------------------------------------------------------------------

[CLASS] ModelCurve
Full Name: Autodesk.Revit.DB.ModelCurve
Description: A model element that exists in 3D space and is visible in all views of a Revit project.
Inherits: CurveElement

  PROPERTIES:
    bool IsReferenceLine { get; }
      Description: Indicates if this curve is a reference curve.
    GraphicsStyle Subcategory { get; set; }
      Description: The subcategory.
    TrussCurveType TrussCurveType { get; set; }
      Description: The truss curve type of this model curve.

  METHODS:
    void ChangeToReferenceLine()
      Description: Changes this curve to a reference curve.
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the model curve in a family document.
      Returns: A copy of visibility settings for the model curve in a family document.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the model curve in a family document.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws InvalidOperationException: Thrown when regeneration failed, or the model curve is in a project document.

--------------------------------------------------------------------------------

[CLASS] ModelCurveArrArray
Full Name: Autodesk.Revit.DB.ModelCurveArrArray
Description: An array that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ModelCurveArrArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    ModelCurveArray Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(ModelCurveArray item)
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    ModelCurveArrArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(ModelCurveArray item, int index)
    ModelCurveArrArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ModelCurveArrArrayIterator
Full Name: Autodesk.Revit.DB.ModelCurveArrArrayIterator
Description: An iterator to a array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ModelCurveArrArrayIterator()
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

[CLASS] ModelCurveArray
Full Name: Autodesk.Revit.DB.ModelCurveArray
Description: An array that contains model curves.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ModelCurveArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    ModelCurve Item { get; set; }
    int Size { get; }
      Description: Returns the number of model curves that are in the array.

  METHODS:
    void Append(ModelCurve item)
      Description: Add the model curve to the end of the array.
      @item: The model curve to be added.
    void Clear()
      Description: Removes every model curve from the array, rendering it empty.
    ModelCurveArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(ModelCurve item, int index)
      Description: Insert the specified model curve into the array.
      @item: The model curve to be inserted into the array.
      @index: The model curve will be inserted before this index.
    ModelCurveArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ModelCurveArrayIterator
Full Name: Autodesk.Revit.DB.ModelCurveArrayIterator
Description: An iterator to a model curve array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ModelCurveArrayIterator()
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

[CLASS] ModelCurveNode
Full Name: Autodesk.Revit.DB.ModelCurveNode
Description: A base class of output nodes that represent various model curves.
Inherits: RenderNode

  PROPERTIES:
    LineProperties LineProperties { get; }
      Description: Access to the line (pen) properties of the curve being drawn

--------------------------------------------------------------------------------

[CLASS] ModelEllipse
Full Name: Autodesk.Revit.DB.ModelEllipse
Description: Represents a ModelEllipse within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve

--------------------------------------------------------------------------------

[CLASS] ModelHermiteSpline
Full Name: Autodesk.Revit.DB.ModelHermiteSpline
Description: Represents a ModelHermiteSpline within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve

--------------------------------------------------------------------------------

[CLASS] ModelLine
Full Name: Autodesk.Revit.DB.ModelLine
Description: Represents a ModelLine within Autodesk Revit.
Remarks: Geometry-related functionality is provided by the geometry curve object from the ModelCurve::geometryCurve property.
Inherits: ModelCurve

--------------------------------------------------------------------------------

[CLASS] ModelNurbSpline
Full Name: Autodesk.Revit.DB.ModelNurbSpline
Description: Represents a ModelNurbSpline within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve

--------------------------------------------------------------------------------

[CLASS] ModelPath
Full Name: Autodesk.Revit.DB.ModelPath
Description: A path to a file stored on a disk or on a server.
Remarks: ModelPaths are paths to another file. They can refer to Revit models, or to any of Revit's external file references (DWG links, for example.) Paths can be relative or absolute, but they must include an extension indicating what kind of file it is. Relative paths are generally relative to the currently opened document. If the current document is workshared, paths will be treated as relative to the central model. To create a ModelPath, use the derived classes FilePath , ServerPath, or use Autodesk::Revit::DB::ModelPathUtils::ConvertCloudGUIDsToCloudPath for a cloud model path. The class ModelPathUtils contains utility functions for converting ModelPaths to and from strings.
Implements: IDisposable

  PROPERTIES:
    string CentralServerPath { get; }
      Description: The path to the location of the central Revit server or cloud.
    bool CloudPath { get; }
      Description: Whether this path represents a path on an Autodesk server such as BIM360.
    bool Empty { get; }
      Description: Whether this path is empty
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Region { get; }
      Description: The region of the BIM 360 Docs or Autodesk Docs account and project which contains this model.
    bool ServerPath { get; }
      Description: Whether this path is a server path (as opposed to a file path or cloud path)

  METHODS:
    int Compare(ModelPath otherPath)
      Description: Compares this ModelPath with another
      @otherPath: The path to compare against.
      Returns: A signed integer indicating the lexical relationship between two ModelPaths. Value is less than zero if this path is less than the given path; zero if the two are the same; and more than zero otherwise
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    Guid GetModelGUID()
      Description: A GUID identifying the Revit cloud model.
    Guid GetProjectGUID()
      Description: A GUID identifying the BIM 360 Docs or Autodesk Docs project to which the model is associated.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ModelPathUtils
Full Name: Autodesk.Revit.DB.ModelPathUtils
Description: Utility functions using ModelPaths

  PROPERTIES:
    static string CloudRegionEMEA { get; }
      Description: The name of cloud region EMEA.
    static string CloudRegionUS { get; }
      Description: The name of cloud region US.

  METHODS:
    static ModelPath ConvertCloudGUIDsToCloudPath(string region, Guid projectGuid, Guid modelGuid)
      Description: Converts a pair of cloud project and model GUIDs to a valid cloud path.
      @region: The region of the BIM 360 Docs or Autodesk Docs account and project which contains this model. Please see the reference values, like CloudRegionUS and CloudRegionEMEA, and the new regions from release note.
      @projectGuid: The GUID of the cloud project which contains the model.
      @modelGuid: The GUID of the Revit cloud model.
      Returns: The cloud model path.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelException: The cloud project is missing.
      Throws RevitServerCommunicationException: The central server could not be reached.
      Throws RevitServerUnauthenticatedUserException: You must sign in to Autodesk 360 in order to complete action.
      Throws RevitServerUnauthorizedException: You are unauthorized to access this resource.
    static string ConvertModelPathToUserVisiblePath(ModelPath path)
      Description: Gets a string version of the path of a given ModelPath.
      @path: A ModelPath representing a file path or a server path.
      Returns: The path in string form
      Throws ArgumentNullException: A non-optional argument was null
    static ModelPath ConvertUserVisiblePathToModelPath(string strPath)
      Description: Converts a user-visible path (string) to a ModelPath.
      @strPath: The path in string form, like RSN://{HostNodeName}/school/project.rvt
      Returns: A ModelPath representing either a server or file path.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidUserVisibleFullServerPath(string strPath)
      Description: Determines whether the given string represents a valid server path.
      @strPath: The path, in string form
      Returns: True if the given path is a valid server path, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ModelText
Full Name: Autodesk.Revit.DB.ModelText
Description: A model text element in an Autodesk Revit family document.
Inherits: Element

  PROPERTIES:
    double Depth { get; set; }
      Description: The depth of the model text.
    HorizontalAlign HorizontalAlignment { get; set; }
      Description: The horizontal alignment.
    Location Location { get; }
      Description: This property is used to find the physical location of an instance within project.
    ModelTextType ModelTextType { get; set; }
      Description: The type for the model text.
    Category Subcategory { get; set; }
      Description: The subcategory.
    string Text { get; set; }
      Description: The text string in the model text.

  METHODS:
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the model text in a family document.
      Returns: A copy of visibility settings for the model text in a family document.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the model text in a family document.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws InvalidOperationException: Thrown when regeneration failed, or the model curve is in a project document.

--------------------------------------------------------------------------------

[CLASS] ModelTextType
Full Name: Autodesk.Revit.DB.ModelTextType
Description: A model text type symbol in the Autodesk Revit Family document.
Inherits: ElementType

--------------------------------------------------------------------------------

[ENUM] ModelUpdatesStatus
Full Name: Autodesk.Revit.DB.ModelUpdatesStatus
Description: Indicates whether an element in the current model has additional user changes in the central model.
Remarks: Note that this status only indicates that the element has user changes in the central model. A user change is typically an action specifically taken by a user. Making a user change to an element requires that the user making the change reload all other user changes made to the element in the central model. Making a user change also causes the element to be checked out to the current user so other users will not be able to make user changes to the same element.Elements can also be modified by system changes. A system change is one which is done automatically by Revit to fully update the model after a user change occurs. Users may make changes to an element in their local model even if the element contains additional system changes in the central model.Example: Suppose Alice and Bob are working on the same model. Alice moves a wall which contains windows. Then Alice synchronizes with the central file. The wall was explicitly changed by Alice and so it will report as "UpdatedInCentral" in Bob's model. Bob would have to reload latest before he could make user changes to that wall. In contrast, Revit automatically moved the windows with the wall, so the windows do not contain any user changes. The windows would therefore report "CurrentWithCentral" and Bob would be allowed to modify them in his local model without reloading latest.
Inherits: Enum

  Values:
    - CurrentWithCentral = 0
    - NotYetInCentral = 1
    - DeletedInCentral = 2
    - UpdatedInCentral = 3

--------------------------------------------------------------------------------

[ENUM] ModifierType
Full Name: Autodesk.Revit.DB.ModifierType
Description: An enumerated type listing options to appear in the exported layer name.
Inherits: Enum

  Values:
    - Category = 0
    - Custom1 = 1
    - Custom2 = 2
    - Custom3 = 3
    - FireRating = 4
    - Function = 5
    - Level = 6
    - PhaseCreated = 7
    - PhaseDemolished = 8
    - PhaseStatus = 9
    - StructuralMaterialType = 10
    - StructuralUsage = 11
    - SystemName = 12
    - SystemType = 13
    - Underlay = 14
    - ViewType = 15
    - Workset = 16
    - AnalyzesAs = 17
    - SystemClassification = 18
    - DomainType = 19
    - FabricationService = 20
    - UnknownType = -1

--------------------------------------------------------------------------------

[CLASS] Mullion
Full Name: Autodesk.Revit.DB.Mullion
Description: Represents a CurtainGrid within Autodesk Revit.
Inherits: FamilyInstance

  PROPERTIES:
    Curve LocationCurve { get; }
      Description: This method get the curve location of the current Mullion.
    bool Lock { get; set; }
      Description: Get - to get whether the Mullion line is locked. Set - Lock/unlock the Mullion.
    bool Lockable { get; }
      Description: Get - to get whether the Mullion can be lock or unlock.
    MullionType MullionType { get; set; }
      Description: The MullionType style of this Mullion. Get - to access type of mullion Set - change type of mullion. If the mullion is locked, InvalidOperationException exception will be thrown.

  METHODS:
    void BreakMullion()
      Description: This method is used to break the current Mullion at ends with its neighboring mullions.
    void JoinMullion()
      Description: This method is used to control the join condition the current Mullion with its neighboring mullions.

--------------------------------------------------------------------------------

[CLASS] MullionType
Full Name: Autodesk.Revit.DB.MullionType
Description: An object that represents a mullion type.
Inherits: FamilySymbol

--------------------------------------------------------------------------------

[CLASS] MullionTypeSet
Full Name: Autodesk.Revit.DB.MullionTypeSet
Description: A set that contains mullion types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new MullionTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of mullion types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every mullion type from the set, rendering it empty.
    bool Contains(MullionType item)
      Description: Tests for the existence of a mullion type within the set.
      @item: The mullion type to be searched for.
      Returns: The Contains method returns True if the mullion type is within the set, otherwise False.
    int Erase(MullionType item)
      Description: Removes a specified mullion type from the set.
      @item: The mullion type to be erased.
      Returns: The number of mullion types that were erased from the set.
    MullionTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(MullionType item)
      Description: Insert the specified mullion type into the set.
      @item: The mullion type to be inserted into the set.
      Returns: Returns whether the mullion type was inserted into the set.
    MullionTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MullionTypeSetIterator
Full Name: Autodesk.Revit.DB.MullionTypeSetIterator
Description: An iterator to a mullion type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new MullionTypeSetIterator()
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

[CLASS] MultipleValuesIndicationSettings
Full Name: Autodesk.Revit.DB.MultipleValuesIndicationSettings
Description: MultipleValuesIndicationSettings is an element which contains project-wide settings for multiple values indication in Properties Palette and schedules.
Inherits: Element

  PROPERTIES:
    bool Custom { get; set; }
      Description: If true, CustomValue is used as multiple values indication, otherwise a hardcoded standard value.
    string CustomValue { get; set; }
      Description: Value used as multiple values indication if Custom is set to true.
    string Value { get; }
      Description: Value to be used as multiple values indication in the document. If Custom is true, returns CustomValue, otherwise returns a hardcoded standard value.

  METHODS:
    static MultipleValuesIndicationSettings GetMultipleValuesIndicationSettings(Document cda)
      Description: Returns the MultipleValuesIndicationSettings element for a given document.
      @cda: The document for which to get the MultipleValuesIndicationSettings element.
      Returns: Returns the MultipleValuesIndicationSettings element in project documents or for family documents.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MultiReferenceAnnotation
Full Name: Autodesk.Revit.DB.MultiReferenceAnnotation
Description: Multi-reference annotations are annotations pointing to more than one reference, consisting of a dimension and associated tag.
Remarks: Multi-reference annotations can be used to label and dimension Rebar elements, and are labeled in the user interface as "Multi-rebar annotations". MultiReferenceAnnotation is the annotation object instance. This class includes a reference to the associated dimension and tag element.
Inherits: Element

  PROPERTIES:
    ElementId DimensionId { get; }
      Description: The child dimension owned by this multi-reference annotation.
    ElementId TagId { get; }
      Description: The child IndependentTag owned by this multi-reference annotation.

  METHODS:
    static bool AreElementsValidForMultiReferenceAnnotation(Document document, MultiReferenceAnnotationOptions options)
      Description: The method validates if the input elements match the element category id for the MultiReferenceAnnotationType.
      @document: The document for the multi-reference annotation.
      @options: The creation options for the new MultiReferenceAnnotation.
      Returns: Returns true if the input elements match the element category id for the MultiReferenceAnnotationType, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool AreReferencesValidForLinearDimension(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyleType is Linear, validates that the references are valid for an aligned multi-reference annotation.
      @document: The document for the multi-reference annotation.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: Options containing the references which the dimension will witness.
      Returns: True DimensionStyleType does not equal Linear or if an aligned multi-reference annotation can be created from the references.
      Throws ArgumentNullException: A non-optional argument was null
    static bool AreReferencesValidForLinearFixedDimension(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyleType is LinearFixed, validates that the references are valid for an aligned multi-reference annotation.
      @document: The document for the multi-reference annotation.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: Options containing the references which the dimension will witness.
      Returns: True DimensionStyleType does not equal LinearFixed or if an aligned multi-reference annotation can be created from the references.
      Throws ArgumentNullException: A non-optional argument was null
    static MultiReferenceAnnotation Create(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: Creates a new MultiReferenceAnnotation.
      @document: The document to which the new MultiReferenceAnnotation will be added.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: The creation options for the new MultiReferenceAnnotation.
      Returns: The new MultiReferenceAnnotation.
      Throws ArgumentException: document is not a project document. -or- The ElementId ownerViewId does not correspond to a View. -or- The ElementId ownerViewId is a view template. -or- The ElementId ownerViewId is a perspective view. -or- The 3D view ownerViewId is not locked. -or- The input 3D view cannot be used to place a MultiReferenceAnnotation object. -or- dimension line direction and dimension plane normal are not orthogonal. -or- There is at least one element that doesn't match the reference category of the MultiReferenceAnnotationType, or there are no elements. -or- for DimensionStyleType LinearFixed dimensions the dimension line direction must be parallel to either the view's vertical or horizontal direction. -or- some references can't be used with a DimensionStyleType Linear dimension of this direction. References must either appear as points in the view or be linear references which are perpendicular to the dimension line. -or- some references can't be used with a DimensionStyleType LinearFixed dimension. Only references which appear as points in the view can be used.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static bool Is3DViewValidForDimension(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyle is LinearFixed, it cannot be created in a 3D View. If the DimensionStyle is Linear, it cannot be created in a 3D View if the view direction is perpendicular to the current work plane normal. Returns true if the ownerViewId is not a 3D view.
      @document: The document for the multi-reference annotation.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: Options containing the references which the dimension will witness.
      Returns: True if the view is suitable for placing the MultiReferenceAnnotation. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsLinearFixedDimensionDirectionValid(Document document, ElementId viewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyleType is LinearFixed, this function verifies that the dimension line direction matches either the view's vertical or horizontal direction.
      @document: The document for the view.
      @viewId: The view in which the dimension line direction will be tested.
      @options: Options containing the DimensionStyleType and dimension line direction to test.
      Returns: True if the DimensionStyleType is LinearFixed and the dimension line direction can be used in the view. True if the DimensionStyleType is not LinearFixed.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MultiReferenceAnnotationOptions
Full Name: Autodesk.Revit.DB.MultiReferenceAnnotationOptions
Description: Options which control the creation of MultiReferenceAnnotations.
Remarks: MultiReferenceAnnotationOptions include the specification of the associated elements and options for the dimension and tag placement.
Implements: IDisposable

  CONSTRUCTORS:
    new MultiReferenceAnnotationOptions(MultiReferenceAnnotationType multiReferenceAnnotationType)
      Description: Create an instance of Multi-Reference Annotation Options set with default values.
      @multiReferenceAnnotationType: The MultiReferenceAnnotationType to be used by the new MultiReferenceAnnotation.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    XYZ DimensionLineDirection { get; set; }
      Description: The direction vector of the dimension line.
    XYZ DimensionLineOrigin { get; set; }
      Description: The origin point for the dimension line.
    XYZ DimensionPlaneNormal { get; set; }
      Description: The normal vector to the dimension plane.
    DimensionStyleType DimensionStyleType { get; set; }
      Description: The dimension style type to be used by the new MultiReferenceAnnotation.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    MultiReferenceAnnotationType MultiReferenceAnnotationType { get; }
      Description: The MultiReferenceAnnotationType to be used by the new MultiReferenceAnnotation.
    bool TagHasLeader { get; set; }
      Description: When true the tag will be created with an attached leader. When false the tag will be created without a leader.
    XYZ TagHeadPosition { get; set; }
      Description: The position for the tag's head.

  METHODS:
    void Dispose()
    bool ElementsMatchReferenceCategory(ICollection<ElementId> elements)
      Description: Verifies that all of the elements match the reference category required by the MultiReferenceAnnotationType.
      @elements: The elements to test.
      Returns: True if all the elements match the reference category required by the MultiReferenceAnnotationType.
      Throws ArgumentNullException: A non-optional argument was null
    IList<Reference> GetAdditionalReferencesToDimension()
      Description: Gets the additional references which the dimension will witness.
      Returns: The additional references which the dimension will witness.
    ICollection<ElementId> GetElementsToDimension()
      Description: Gets the elements which the dimension will witness.
      Returns: The elements which the dimension will witness.
    bool IsAllowedDimensionStyleType(DimensionStyleType dimensionStyleType)
      Description: Only Linear and LinearFixed dimension style types are allowed for new MultiReferenceAnnotations.
      @dimensionStyleType: The dimension style type to test.
      Returns: True if the type is allowed.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool ReferencesDontMatchReferenceCategory(IList<Reference> references)
      Description: Verifies that all of the references belongs to elements which doesn't match the reference category required by the MultiReferenceAnnotationType.
      @references: The references to test.
      Returns: Returns true if the element categories of all tested references do not match the element category required by the MultiReferenceAnnotationType.
      Throws ArgumentNullException: A non-optional argument was null
    void SetAdditionalReferencesToDimension(IList<Reference> referencesToDimension)
      Description: Sets the additional references which the dimension will witness.
      @referencesToDimension: The additional references which the dimension will witness.
      Throws ArgumentException: Some references come from elements which directly match the reference category required by the MultiReferenceAnnotationType. For those elements please use SetElementsToDimension.
      Throws ArgumentNullException: A non-optional argument was null
    void SetElementsToDimension(ICollection<ElementId> elementsToDimension)
      Description: Sets the elements which the dimension will witness.
      @elementsToDimension: The elements which the dimension will witness.
      Throws ArgumentException: some elements do not match the reference category required by the MultiReferenceAnnotationType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The MultiReferenceAnnotationType assigned to the options can't create MultiReferenceAnnotations by element.

--------------------------------------------------------------------------------

[CLASS] MultiReferenceAnnotationType
Full Name: Autodesk.Revit.DB.MultiReferenceAnnotationType
Description: The type for MultiReferenceAnnotation.
Remarks: Multi-reference annotations can be used to label and dimension Rebar elements, and are labeled in the user interface as "Multi-rebar annotations". The type specifies the tag and dimension types to be used in the multi-reference annotation, as well as associated display settings.
Inherits: ElementType

  PROPERTIES:
    ElementId DimensionStyleId { get; set; }
      Description: The dimension style which will be used by the child dimension of the multi-reference annotation.
    bool GroupTagHeads { get; set; }
      Description: Controls if parameter values for the annotation's references will be reported in one grouped tag head or if every reference will get its own tag head.
    ElementId ReferenceCategoryId { get; }
      Description: The category of elements to which this annotation applies.
    bool ShowDimensionText { get; set; }
      Description: Controls if text from the multi-reference annotation's dimension will be shown.
    ElementId TagTypeId { get; set; }
      Description: The tag type which will be used by the child tag the multi-reference annotation.

  METHODS:
    static MultiReferenceAnnotationType CreateDefault(Document document)
      Description: Creates the first MultiReferenceAnnotationType element and adds it to the document.
      @document: The document to be modified.
      Returns: The new MultiReferenceAnnotationType element.
      Throws ArgumentException: document is not a project document. -or- There are existing MultiReferenceAnnotationTypes in the document.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId GetAllowedTagCategory()
      Description: Returns the category ID for the tag types which can be used by this multi-reference annotation type.
      Returns: The allowed tag category ID.
    bool IsAllowedDimensionStyle(ElementId dimensionStyleId)
      Description: Checks if the dimension style can be used with multi-reference annotations.
      @dimensionStyleId: The dimension style to check.
      Returns: True if the dimension style can be used by multi-reference annotations.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAllowedReferenceCategory(ElementId referenceCategoryId)
      Description: Checks if the reference category can be used with multi-reference annotations.
      @referenceCategoryId: The reference category to check.
      Returns: True when the reference category can be used by multi-reference annotations.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAllowedTagCategory(ElementId tagCategoryId)
      Description: Returns true if tag types belonging to this category can be used with multi-reference annotation types.
      @tagCategoryId: The tag category to test.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAllowedTagType(ElementId tagTypeId)
      Description: Checks if the tag type can be assigned to this multi-reference annotation type.
      @tagTypeId: The tag type to test.
      Returns: True if the tag type exclusively tags elements from the multi-reference annotation's reference category.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MultiSegmentGrid
Full Name: Autodesk.Revit.DB.MultiSegmentGrid
Description: This element acts as a multi-segmented Grid. The individual grids associated to the MultiSegmentGrid behave as a single unit and all share the same text. They inherit their type (GridType) from the MultiSegmentGrid.
Inherits: Element

  PROPERTIES:
    string Text { get; set; }
      Description: name shared by grids in this MultiSegmentGrid

  METHODS:
    static bool AreGridsInSameMultiSegmentGrid(Grid grid1, Grid grid2)
      Description: Determine whether two Grids are members of the same GridChain.
      @grid1: A Grid.
      @grid2: A Grid.
      Returns: Returns true if both of the specified Grids are associated to the same MultiSegmentGrid, i.e. getMultiSegementGridId returns the same valid element id for both Grids.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId Create(Document document, ElementId typeId, CurveLoop curveLoop, ElementId sketchPlaneId)
      Description: Create a MultiSegmentGrid element from the specified curve loop.
      @document: The document in which to create the MultiSegmentGrid.
      @typeId: Element id of a GridType element.
      @curveLoop: An open curve loop consisting of lines and arcs.
      @sketchPlaneId: Element id of a SketchPlane for the curves elements that will be created from the curveLoop.
      Returns: The element id of the new MultiSegmentGrid element.
      Throws ArgumentException: The element id should refer to a valid horizontal SketchPlane. -or- The element id should refer to a GridType element. -or- The curve loop should be an open loop consisting of lines and arcs.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ICollection<ElementId> GetGridIds()
      Description: Get the element ids of the Grids that make up this MultiSegmentGrid.
      Returns: Element ids of Grids that make up this MultiSegmentGrid.
    static ElementId GetMultiSegementGridId(Grid grid)
      Description: Retrieve the element id of the MultiSegmentGrid of which the specified Grid is a member.
      @grid: A Grid.
      Returns: The element id of the associated GridChain. If the Grid is not associated to a GridChain, this will return invalidElementId.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidCurveLoop(CurveLoop curveLoop)
      Description: Identifies whether the specified curve loop is valid for creation of a MultiSegmentGrid.
      @curveLoop: The curve loop.
      Returns: True if the curve loop is an open curve loop consisting of lines and arcs, and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidSketchPlaneId(Document document, ElementId elemId)
      Description: Identifies whether provided element id corresponds to a SketchPlane that is valid for GridChain creation.
      @document: The document.
      @elemId: Element id.
      Returns: True if elemId is the element id of a horizontal SketchPlane.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

