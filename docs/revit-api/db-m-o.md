# Autodesk.Revit.DB (Types: M, N, O)

[ENUM] MarginType
Full Name: Autodesk.Revit.DB.MarginType

Description: An enumerated type listing all Margin types of Print Setting.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoMargin = 0
    - PrinterLimit = 1
    - UserDefined = 2


[ENUM] MassDisplayTemporaryOverrideType
Full Name: Autodesk.Revit.DB.MassDisplayTemporaryOverrideType

Description: This enum identifies the mass display overrides.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ShowMassByViewSettings = 0
    - ShowMassFormAndFloors = 1
    - ShowMassSurfaceTypes = 2
    - ShowMassZonesAndShades = 3


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
    void Dispose()
    static double GetGrossFloorArea(Document document, ElementId massInstanceId)
      Description: Get the total occupiable floor area represented by a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The gross floor area in square feet.
    static double GetGrossSurfaceArea(Document document, ElementId massInstanceId)
      Description: Get the total exterior building surface area represented by a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The gross surface area in square feet.
    static double GetGrossVolume(Document document, ElementId massInstanceId)
      Description: Get the total building volume represented by a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The gross volume in cubic feet.
    static IList<ElementId> GetJoinedElementIds(Document document, ElementId massInstanceId)
      Description: Get the ElementIds of Elements that are joined to a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: ElementIds of Elements joined to the mass instance.
    static IList<ElementId> GetMassLevelDataIds(Document document, ElementId massInstanceId)
      Description: Get the ElementIds of the MassLevelDatas (Mass Floors) associated with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The ElementIds of the MassLevelDatas.
    static IList<ElementId> GetMassLevelIds(Document document, ElementId massInstanceId)
      Description: Get the ElementIds of the Levels associated with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      Returns: The ElementIds of the Levels
    static void RemoveMassLevelDataFromMassInstance(Document document, ElementId massInstanceId, ElementId levelId)
      Description: Delete the MassLevelData (Mass Floor) that associates a Level with a mass instance.
      @document: The Document.
      @massInstanceId: The ElementId of the mass instance.
      @levelId: The ElementId of the Level to disassociate from the mass instance.

--------------------------------------------------------------------------------


[CLASS] Material
Full Name: Autodesk.Revit.DB.Material

Description: Represents a material element within an Autodesk Revit project.
Inherits: Element
Implements: IDisposable

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
    static ElementId Create(Document document, string name)
      Description: Creates a new material.
      @document: The document in which to create the material.
      @name: The name of the new material.
      Returns: Identifier of the new material.
    Material Duplicate(string name)
      Description: Duplicates the material
      @name: Name of the new material - this name must be correctly structured for Revit use and not duplicate the name of another material in the document.
      Returns: The new material.
    static bool IsMaterialOrValidDefault(Element pElem, ElementId materialId)
      Description: Validates whether the specified element id is a material element.
      @pElem: An element which will be applied the material
      @materialId: The element id to be checked.
      Returns: True if the element a material element or invalidElementId, which means take material from category, false otherwise.
    static bool IsNameUnique(Document aDocument, string name)
      Description: Validates whether the material name is unique in document.
      @aDocument: The document in which the name is being tested for uniqueness.
      @name: The name tested for uniqueness.
      Returns: Returns true if the name is unique, and false otherwise.
    void SetMaterialAspectByPropertySet(MaterialAspect aspect, ElementId propertySetId)
      Description: Sets an aspect of the material to a shared property set.
      @aspect: The material aspect.
      @propertySetId: Identifier of a shared property set (an instance of PropertySetElement).

--------------------------------------------------------------------------------


[ENUM] MaterialAspect
Full Name: Autodesk.Revit.DB.MaterialAspect

Description: A list of all material aspects that a material can store PropertySetElements for.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Structural = 0
    - Thermal = 1


[ENUM] MaterialFunctionAssignment
Full Name: Autodesk.Revit.DB.MaterialFunctionAssignment

Description: Used in class CompoundStructure to specify the function of a layer.
Remarks: The function is used primarily to determine layer priority which affects how layers of distinct elements interact at a join. Typically, layers penetrate lower priority layers and merge with layers of the same priority.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Structure = 1
    - Substrate = 2
    - Insulation = 3
    - Finish1 = 4
    - Finish2 = 5
    - Membrane = 100
    - StructuralDeck = 200


[CLASS] MaterialNode
Full Name: Autodesk.Revit.DB.MaterialNode

Description: This class represents a change of material during a model-exporting process.
Remarks: Output nodes following this node are to be assumed using the material. The material remains in effect until another material node is sent to the output. See also: .
Inherits: RenderNode
Implements: IDisposable

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - General = 0
    - Transparency = 1
    - Cutouts = 2
    - Bump = 3
    - FinishBumps = 4
    - ReliefPattern = 5
    - Weathering = 6


[ABSTRACT CLASS] MathComparisonUtils
Full Name: Autodesk.Revit.DB.MathComparisonUtils

Description: This class contains a set of mathematical utilities to compare doubles, using the internal tolerance.

  METHODS:
    static bool IsAlmostEqual(double value1, double value2)
      Description: Checks if two doubles are almost equal, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if two doubles are almost equal, false otherwise.
    static bool IsAlmostZero(double value)
      Description: Checks if value is almost zero, using the internal tolerance.
      @value: The value to check.
      Returns: True if value is almost zero, false otherwise.
    static bool IsGreaterThan(double value1, double value2)
      Description: Checks if value1 is strictly greater than value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is strictly greater than value2, false otherwise.
    static bool IsGreaterThanOrAlmostEqual(double value1, double value2)
      Description: Checks if value1 is greater than or almost equal to value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is greater than or almost equal to value2, false otherwise.
    static bool IsLessThan(double value1, double value2)
      Description: Checks if value1 is strictly less than value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is strictly less than value2, false otherwise.
    static bool IsLessThanOrAlmostEqual(double value1, double value2)
      Description: Checks if value1 is less than or almost equal to value2, using the internal tolerance.
      @value1: The first value.
      @value2: The second value.
      Returns: True if value1 is less than or almost equal to value2, false otherwise.

--------------------------------------------------------------------------------


[CLASS] MEPAnalyticalConnection
Full Name: Autodesk.Revit.DB.MEPAnalyticalConnection

Description: Represents an analytical element that connects mechanical equipment to piping network.
Remarks: The analytical connection takes mechanical equipment into account of network flow/pressure analysis. The connection remains the same even if the mechanical equipment moves and rotates. It enables a fast establishment of piping network to analyze the flow and pressure, especially at the early stage of the design process.
Inherits: MEPCurve
Implements: IDisposable

  METHODS:
    static bool CanSupportAnalyticalConnection(Connector connector)
      Description: Checks if the connector can support the analytical connection.
      @connector: The testing connector.
      Returns: True if the connector can support the network flow/pressure analysis, false otherwise.
    static MEPAnalyticalConnection Create(Document doc, ElementId typeId, Connector startConnector, Connector endConnector)
      Description: Creates a new analytical connection between two open connectors.
      @doc: The document where the new element is created.
      @typeId: The type of new analytical connection.
      @startConnector: The open connector on the equipment side, whose level is inherited by the analytical connection.
      @endConnector: The open connector on the network.
      Returns: The newly created analytical connection element.
    static ISet<ElementId> CreateMultipleConnections(Document doc, ElementId typeId, IList<Connector> equipmentOpenConnectors, IList<ElementId> curveIdsToConnect)
      Description: Creates new analytical connections between the equipment connector and the nearest point on the curves.
      @doc: The document where the new elements are created.
      @typeId: The type of new analytical connections.
      @equipmentOpenConnectors: The open equipment connectors to be analytically connected.
      @curveIdsToConnect: The curves which the equipment is connected to.
      Returns: The new analytical connection elements.
    double GetFlow()
      Description: Gets the flow value of this analytical connection.
      Returns: The flow value.

--------------------------------------------------------------------------------


[CLASS] MEPAnalyticalConnectionType
Full Name: Autodesk.Revit.DB.MEPAnalyticalConnectionType

Description: Represents an analytical connection type between mechanical equipment and piping network.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    double PressureLoss { get; set; }
      Description: The pressure loss of this analytical connection type.

  METHODS:
    static MEPAnalyticalConnectionType Create(Document doc, string name)
      Description: Creates an analytical connection type element.
      @doc: The document.
      @name: The name of the analytical type to be created.
      Returns: The created analytical connection type element.
    static ElementId FindTypeByName(Document doc, string name)
      Description: Finds the analytical connection type by its name.
      @doc: The document where the analytical conneciton type is expected.
      @name: The name of the expected analytical connection type.
      Returns: The element id of matched analytical connection type, otherwise invalidElementId.
    static bool IsNameUnused(Document doc, string name)
      Description: Checks if this is an unused name.
      @doc: The document.
      @name: The name to be verified.
      Returns: True if not used by an existing analytical connection type in this document, false if used.

--------------------------------------------------------------------------------


[CLASS] MEPCalculationServerInfo
Full Name: Autodesk.Revit.DB.MEPCalculationServerInfo

Description: a struct to hold the information about a MEP calucation servers
Implements: IDisposable

  CONSTRUCTORS:
    new MEPCalculationServerInfo(MEPCalculationServerInfo other)
    new MEPCalculationServerInfo(IExternalServer server)
    new MEPCalculationServerInfo()

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
Implements: IDisposable

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
Implements: IDisposable

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
Implements: IDisposable

  METHODS:
    ElementId GetAssociateFamilyParameterId(ElementId connectorParameterId)
      Description: Gets the associate family parameter id of the specified connector parameter id.
      @connectorParameterId: connectorParameterId is defined in the family connector element.
      Returns: Returns valid ElementId if the connectorParameterId associates to one family parameter; otherwise returns invalid ElementId.
    ParameterValue GetConnectorParameterValue(ElementId connectorParameterId)
      Description: Gets the parameter value of the specified connector parameter id.
      @connectorParameterId: connectorParameterId is defined in the family connector element.

--------------------------------------------------------------------------------


[CLASS] MEPModel
Full Name: Autodesk.Revit.DB.MEPModel

Description: Supports all MEP models that are persistent within the Autodesk Revit project.
Inherits: APIObject
Implements: IDisposable

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

--------------------------------------------------------------------------------


[CLASS] MEPSystem
Full Name: Autodesk.Revit.DB.MEPSystem

Description: A system in the Autodesk Revit MEP product.
Remarks: This is the base class for electrical, mechanical and piping systems, available only in the Autodesk Revit MEP product.
Inherits: Element
Implements: IDisposable

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
    ICollection<ElementId> DivideSystem(Document ADoc)
      Description: Divide the phyisical networks in the system and create a new system for each network.
      @ADoc: The document.
      Returns: The id of new created systems.
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
    void Remove(ConnectorSet connectors)
      Description: Removes connectors from system.
      @connectors: The connectors to be removed from the system.

--------------------------------------------------------------------------------


[ENUM] MEPSystemClassification
Full Name: Autodesk.Revit.DB.MEPSystemClassification

Description: This enumeration is used to classify MEP connectors and systems and drives certain behavior for a particular system type
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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


[CLASS] MEPSystemType
Full Name: Autodesk.Revit.DB.MEPSystemType

Description: A system type in the Autodesk Revit MEP product.
Remarks: This is the base class for mechanical and piping system types, available only in the Autodesk Revit MEP product.
Inherits: ElementType
Implements: IDisposable

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
Remarks: Meshes are generated during triangulation of faces. They can also be encountered directly in Revit geometry (typically imported geometry). Meshes contain a single array of , and a corresponding array of triangles. Triangles can be accessed by index from , and reference 3 vertices from the array.
Inherits: GeometryObject
Implements: IDisposable

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
    IList<XYZ> GetNormals()
      Description: Returns all normals assigned to the mesh.
      Returns: An array of XYZ values, each representing a normal unit vector.

--------------------------------------------------------------------------------


[ENUM] MeshFromGeometryOperationIssue
Full Name: Autodesk.Revit.DB.MeshFromGeometryOperationIssue

Description: Issues encountered while constructing meshes as fallbacks for geometrical operations.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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


[CLASS] MeshFromGeometryOperationResult
Full Name: Autodesk.Revit.DB.MeshFromGeometryOperationResult

Description: Describes what has built.
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

--------------------------------------------------------------------------------


[CLASS] MeshTriangle
Full Name: Autodesk.Revit.DB.MeshTriangle

Description: One triangle of a mesh.

  PROPERTIES:
    UInt32 Index { get; }
    XYZ Vertex { get; }

--------------------------------------------------------------------------------


[CLASS] ModelArc
Full Name: Autodesk.Revit.DB.ModelArc

Description: Represents a ModelArc within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ModelCurve
Full Name: Autodesk.Revit.DB.ModelCurve

Description: A model element that exists in 3D space and is visible in all views of a Revit project.
Inherits: CurveElement
Implements: IDisposable

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

--------------------------------------------------------------------------------


[CLASS] ModelCurveArrArray
Full Name: Autodesk.Revit.DB.ModelCurveArrArray

Description: An array that can contain any type of object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

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
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ModelCurveArrArrayIterator()

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
Implements: IDisposable, IEnumerable

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
      Returns: Returns whether the model curve was inserted into the array.
    ModelCurveArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ModelCurveArrayIterator
Full Name: Autodesk.Revit.DB.ModelCurveArrayIterator

Description: An iterator to a model curve array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ModelCurveArrayIterator()

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
Implements: IDisposable

  PROPERTIES:
    LineProperties LineProperties { get; }
      Description: Access to the line (pen) properties of the curve being drawn

--------------------------------------------------------------------------------


[CLASS] ModelEllipse
Full Name: Autodesk.Revit.DB.ModelEllipse

Description: Represents a ModelEllipse within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ModelHermiteSpline
Full Name: Autodesk.Revit.DB.ModelHermiteSpline

Description: Represents a ModelHermiteSpline within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ModelLine
Full Name: Autodesk.Revit.DB.ModelLine

Description: Represents a ModelLine within Autodesk Revit.
Remarks: Geometry-related functionality is provided by the geometry curve object from the ModelCurve::geometryCurve property.
Inherits: ModelCurve
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ModelNurbSpline
Full Name: Autodesk.Revit.DB.ModelNurbSpline

Description: Represents a ModelNurbSpline within Autodesk Revit.
Remarks: Currently it's just a place holder for specific type. All the geometry-related functionality is provided by geometry curve object from ModelCurve::geometryCurve property.
Inherits: ModelCurve
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] ModelPath
Full Name: Autodesk.Revit.DB.ModelPath

Description: A path to a file stored on a disk or on a server.
Remarks: ModelPaths are paths to another file. They can refer to Revit models, or to any of Revit's external file references (DWG links, for example.) Paths can be relative or absolute, but they must include an extension indicating what kind of file it is. Relative paths are generally relative to the currently opened document. If the current document is workshared, paths will be treated as relative to the central model. To create a ModelPath, use the derived classes FilePath , ServerPath, or use for a cloud model path. The class ModelPathUtils contains utility functions for converting ModelPaths to and from strings.
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
      @region: The region of the BIM 360 Docs or Autodesk Docs account and project which contains this model. Please see the reference values, like and , and the new regions from release note.
      @projectGuid: The GUID of the cloud project which contains the model.
      @modelGuid: The GUID of the Revit cloud model.
      Returns: The cloud model path.
    static string ConvertModelPathToUserVisiblePath(ModelPath path)
      Description: Gets a string version of the path of a given ModelPath.
      @path: A ModelPath representing a file path or a server path.
      Returns: The path in string form
    static ModelPath ConvertUserVisiblePathToModelPath(string strPath)
      Description: Converts a user-visible path (string) to a ModelPath.
      @strPath: The path in string form, like RSN://{HostNodeName}/school/project.rvt
      Returns: A ModelPath representing either a server or file path.
    static bool IsValidUserVisibleFullServerPath(string strPath)
      Description: Determines whether the given string represents a valid server path.
      @strPath: The path, in string form
      Returns: True if the given path is a valid server path, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ModelText
Full Name: Autodesk.Revit.DB.ModelText

Description: A model text element in an Autodesk Revit family document.
Inherits: Element
Implements: IDisposable

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

--------------------------------------------------------------------------------


[CLASS] ModelTextType
Full Name: Autodesk.Revit.DB.ModelTextType

Description: A model text type symbol in the Autodesk Revit Family document.
Inherits: ElementType
Implements: IDisposable

--------------------------------------------------------------------------------


[ENUM] ModelUpdatesStatus
Full Name: Autodesk.Revit.DB.ModelUpdatesStatus

Description: Indicates whether an element in the current model has additional user changes in the central model.
Remarks: Note that this status only indicates that the element has user changes in the central model. A user change is typically an action specifically taken by a user. Making a user change to an element requires that the user making the change reload all other user changes made to the element in the central model. Making a user change also causes the element to be checked out to the current user so other users will not be able to make user changes to the same element.Elements can also be modified by system changes. A system change is one which is done automatically by Revit to fully update the model after a user change occurs. Users may make changes to an element in their local model even if the element contains additional system changes in the central model.Example: Suppose Alice and Bob are working on the same model. Alice moves a wall which contains windows. Then Alice synchronizes with the central file. The wall was explicitly changed by Alice and so it will report as "UpdatedInCentral" in Bob's model. Bob would have to reload latest before he could make user changes to that wall. In contrast, Revit automatically moved the windows with the wall, so the windows do not contain any user changes. The windows would therefore report "CurrentWithCentral" and Bob would be allowed to modify them in his local model without reloading latest.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - CurrentWithCentral = 0
    - NotYetInCentral = 1
    - DeletedInCentral = 2
    - UpdatedInCentral = 3


[ENUM] ModifierType
Full Name: Autodesk.Revit.DB.ModifierType

Description: An enumerated type listing options to appear in the exported layer name.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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


[CLASS] Mullion
Full Name: Autodesk.Revit.DB.Mullion

Description: Represents a CurtainGrid within Autodesk Revit.
Inherits: FamilyInstance
Implements: IDisposable

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
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] MullionTypeSet
Full Name: Autodesk.Revit.DB.MullionTypeSet

Description: A set that contains mullion types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

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
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new MullionTypeSetIterator()

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
Implements: IDisposable

  PROPERTIES:
    bool Custom { get; set; }
      Description: If true, is used as multiple values indication, otherwise a hardcoded standard value.
    string CustomValue { get; set; }
      Description: Value used as multiple values indication if is set to true.
    string Value { get; }
      Description: Value to be used as multiple values indication in the document. If is true, returns , otherwise returns a hardcoded standard value.

  METHODS:
    static MultipleValuesIndicationSettings GetMultipleValuesIndicationSettings(Document cda)
      Description: Returns the MultipleValuesIndicationSettings element for a given document.
      @cda: The document for which to get the MultipleValuesIndicationSettings element.
      Returns: Returns the MultipleValuesIndicationSettings element in project documents or for family documents.

--------------------------------------------------------------------------------


[CLASS] MultiReferenceAnnotation
Full Name: Autodesk.Revit.DB.MultiReferenceAnnotation

Description: Multi-reference annotations are annotations pointing to more than one reference, consisting of a dimension and associated tag.
Remarks: Multi-reference annotations can be used to label and dimension Rebar elements, and are labeled in the user interface as "Multi-rebar annotations". MultiReferenceAnnotation is the annotation object instance. This class includes a reference to the associated dimension and tag element.
Inherits: Element
Implements: IDisposable

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
    static bool AreReferencesValidForLinearDimension(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyleType is Linear, validates that the references are valid for an aligned multi-reference annotation.
      @document: The document for the multi-reference annotation.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: Options containing the references which the dimension will witness.
      Returns: True DimensionStyleType does not equal Linear or if an aligned multi-reference annotation can be created from the references.
    static bool AreReferencesValidForLinearFixedDimension(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyleType is LinearFixed, validates that the references are valid for an aligned multi-reference annotation.
      @document: The document for the multi-reference annotation.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: Options containing the references which the dimension will witness.
      Returns: True DimensionStyleType does not equal LinearFixed or if an aligned multi-reference annotation can be created from the references.
    static MultiReferenceAnnotation Create(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: Creates a new MultiReferenceAnnotation.
      @document: The document to which the new MultiReferenceAnnotation will be added.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: The creation options for the new MultiReferenceAnnotation.
      Returns: The new MultiReferenceAnnotation.
    static bool Is3DViewValidForDimension(Document document, ElementId ownerViewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyle is LinearFixed, it cannot be created in a 3D View. If the DimensionStyle is Linear, it cannot be created in a 3D View if the view direction is perpendicular to the current work plane normal. Returns true if the ownerViewId is not a 3D view.
      @document: The document for the multi-reference annotation.
      @ownerViewId: The view in which the multi-reference annotation will appear.
      @options: Options containing the references which the dimension will witness.
      Returns: True if the view is suitable for placing the MultiReferenceAnnotation. False otherwise.
    static bool IsLinearFixedDimensionDirectionValid(Document document, ElementId viewId, MultiReferenceAnnotationOptions options)
      Description: If the DimensionStyleType is LinearFixed, this function verifies that the dimension line direction matches either the view's vertical or horizontal direction.
      @document: The document for the view.
      @viewId: The view in which the dimension line direction will be tested.
      @options: Options containing the DimensionStyleType and dimension line direction to test.
      Returns: True if the DimensionStyleType is LinearFixed and the dimension line direction can be used in the view. True if the DimensionStyleType is not LinearFixed.

--------------------------------------------------------------------------------


[CLASS] MultiReferenceAnnotationOptions
Full Name: Autodesk.Revit.DB.MultiReferenceAnnotationOptions

Description: Options which control the creation of MultiReferenceAnnotations.
Remarks: MultiReferenceAnnotationOptions include the specification of the associated elements and options for the dimension and tag placement.
Implements: IDisposable

  CONSTRUCTORS:
    new MultiReferenceAnnotationOptions(MultiReferenceAnnotationType multiReferenceAnnotationType)

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
    bool ReferencesDontMatchReferenceCategory(IList<Reference> references)
      Description: Verifies that all of the references belongs to elements which doesn't match the reference category required by the MultiReferenceAnnotationType.
      @references: The references to test.
      Returns: Returns true if the element categories of all tested references do not match the element category required by the MultiReferenceAnnotationType.
    void SetAdditionalReferencesToDimension(IList<Reference> referencesToDimension)
      Description: Sets the additional references which the dimension will witness.
      @referencesToDimension: The additional references which the dimension will witness.
    void SetElementsToDimension(ICollection<ElementId> elementsToDimension)
      Description: Sets the elements which the dimension will witness.
      @elementsToDimension: The elements which the dimension will witness.

--------------------------------------------------------------------------------


[CLASS] MultiReferenceAnnotationType
Full Name: Autodesk.Revit.DB.MultiReferenceAnnotationType

Description: The type for MultiReferenceAnnotation.
Remarks: Multi-reference annotations can be used to label and dimension Rebar elements, and are labeled in the user interface as "Multi-rebar annotations". The type specifies the tag and dimension types to be used in the multi-reference annotation, as well as associated display settings.
Inherits: ElementType
Implements: IDisposable

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
    ElementId GetAllowedTagCategory()
      Description: Returns the category ID for the tag types which can be used by this multi-reference annotation type.
      Returns: The allowed tag category ID.
    bool IsAllowedDimensionStyle(ElementId dimensionStyleId)
      Description: Checks if the dimension style can be used with multi-reference annotations.
      @dimensionStyleId: The dimension style to check.
      Returns: True if the dimension style can be used by multi-reference annotations.
    bool IsAllowedReferenceCategory(ElementId referenceCategoryId)
      Description: Checks if the reference category can be used with multi-reference annotations.
      @referenceCategoryId: The reference category to check.
      Returns: True when the reference category can be used by multi-reference annotations.
    static bool IsAllowedTagCategory(ElementId tagCategoryId)
      Description: Returns true if tag types belonging to this category can be used with multi-reference annotation types.
      @tagCategoryId: The tag category to test.
    bool IsAllowedTagType(ElementId tagTypeId)
      Description: Checks if the tag type can be assigned to this multi-reference annotation type.
      @tagTypeId: The tag type to test.
      Returns: True if the tag type exclusively tags elements from the multi-reference annotation's reference category.

--------------------------------------------------------------------------------


[CLASS] MultiSegmentGrid
Full Name: Autodesk.Revit.DB.MultiSegmentGrid

Description: This element acts as a multi-segmented Grid. The individual grids associated to the MultiSegmentGrid behave as a single unit and all share the same text. They inherit their type (GridType) from the MultiSegmentGrid.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string Text { get; set; }
      Description: name shared by grids in this MultiSegmentGrid

  METHODS:
    static bool AreGridsInSameMultiSegmentGrid(Grid grid1, Grid grid2)
      Description: Determine whether two Grids are members of the same GridChain.
      @grid1: A Grid.
      @grid2: A Grid.
      Returns: Returns true if both of the specified Grids are associated to the same MultiSegmentGrid, i.e. getMultiSegementGridId returns the same valid element id for both Grids.
    static ElementId Create(Document document, ElementId typeId, CurveLoop curveLoop, ElementId sketchPlaneId)
      Description: Create a MultiSegmentGrid element from the specified curve loop.
      @document: The document in which to create the MultiSegmentGrid.
      @typeId: Element id of a GridType element.
      @curveLoop: An open curve loop consisting of lines and arcs.
      @sketchPlaneId: Element id of a SketchPlane for the curves elements that will be created from the curveLoop.
      Returns: The element id of the new MultiSegmentGrid element.
    ICollection<ElementId> GetGridIds()
      Description: Get the element ids of the Grids that make up this MultiSegmentGrid.
      Returns: Element ids of Grids that make up this MultiSegmentGrid.
    static ElementId GetMultiSegementGridId(Grid grid)
      Description: Retrieve the element id of the MultiSegmentGrid of which the specified Grid is a member.
      @grid: A Grid.
      Returns: The element id of the associated GridChain. If the Grid is not associated to a GridChain, this will return invalidElementId.
    static bool IsValidCurveLoop(CurveLoop curveLoop)
      Description: Identifies whether the specified curve loop is valid for creation of a MultiSegmentGrid.
      @curveLoop: The curve loop.
      Returns: True if the curve loop is an open curve loop consisting of lines and arcs, and false otherwise.
    static bool IsValidSketchPlaneId(Document document, ElementId elemId)
      Description: Identifies whether provided element id corresponds to a SketchPlane that is valid for GridChain creation.
      @document: The document.
      @elemId: Element id.
      Returns: True if elemId is the element id of a horizontal SketchPlane.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] NamingUtils
Full Name: Autodesk.Revit.DB.NamingUtils

Description: A collection of utilities related to element naming.

  METHODS:
    static int CompareNames(string nameA, string nameB)
      Description: Compares two object name strings using Revit's comparison rules.
      @nameA: The first object name to compare.
      @nameB: The second object name to compare.
      Returns: An integer indicating the result of the lexical comparison between the two names. Less than zero if nameA comes before nameB in the ordering, zero if nameA and nameB are equivalent, and greater than zero if nameA is comes after nameB in the ordering.
    static bool IsValidName(string string)
      Description: Identifies if the input string is valid for use as an object name in Revit.
      @string: The name to validate.
      Returns: True if the name is valid for use as a name in Revit, false if it contains prohibited characters and is invalid.

--------------------------------------------------------------------------------


[ENUM] NavisworksCoordinates
Full Name: Autodesk.Revit.DB.NavisworksCoordinates

Description: An enumerated type listing possible Coordinates of Navisworks Exporter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Internal = 0
    - Shared = 1


[CLASS] NavisworksExportOptions
Full Name: Autodesk.Revit.DB.NavisworksExportOptions

Description: Options which controls the Navisworks export.
Implements: IDisposable

  CONSTRUCTORS:
    new NavisworksExportOptions()

  PROPERTIES:
    bool ConvertElementProperties { get; set; }
      Description: True to convert element properties, false otherwise. Default value is false.
    bool ConvertLights { get; set; }
      Description: True to convert lights, false otherwise. Default value is false.
    bool ConvertLinkedCADFormats { get; set; }
      Description: True to convert linked CAD formats, false otherwise. Default value is true.
    NavisworksCoordinates Coordinates { get; set; }
      Description: Options which specifies the coordinates of Navisworks Exporter. Default value is Shared.
    bool DivideFileIntoLevels { get; set; }
      Description: True to divide file into levels, false otherwise. Default value is true.
    bool ExportElementIds { get; set; }
      Description: True to export Revit element ids, false to skip these values. Default value is true.
    bool ExportLinks { get; set; }
      Description: True to export Revit links found in the main model, false to skip links. Default value is false.
    bool ExportParts { get; set; }
      Description: True to export Revit part elements, false to export the original parent elements. Default value is false.
    bool ExportRoomAsAttribute { get; set; }
      Description: True to export data for each room converts into a single shared room attribute, false otherwise. Default value is true.
    bool ExportRoomGeometry { get; set; }
      Description: True to export Revit room geometry, false otherwise. Default value is true.
    NavisworksExportScope ExportScope { get; set; }
      Description: Options which specifies the export scope of Navisworks Exporter. Default value is Model.
    bool ExportUrls { get; set; }
      Description: True to export URL parameters, false otherwise. Default value is true.
    double FacetingFactor { get; set; }
      Description: Faceting factor. Default value is 1.0.
    bool FindMissingMaterials { get; set; }
      Description: True if the file exporter looks for a match for the materials missing from the export, false otherwise. Default value is true.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    NavisworksParameters Parameters { get; set; }
      Description: Options which specifies the parameter conversion of Navisworks Exporter. Default value is All.
    ElementId ViewId { get; set; }
      Description: The element id of the view to export. InvalidElementId by default. Used only when ExportScope = View.

  METHODS:
    void Dispose()
    ICollection<ElementId> GetSelectedElementIds()
      Description: Returns the element ids of the elements to export. Empty by default.
    void SetSelectedElementIds(ICollection<ElementId> ids)
      Description: Sets the element ids of the elements to export. Used only when ExportScope = SelectedElements.

--------------------------------------------------------------------------------


[ENUM] NavisworksExportScope
Full Name: Autodesk.Revit.DB.NavisworksExportScope

Description: An enumerated type listing possible "Element Scopes" of Navisworks Exporter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Model = 0
    - View = 1
    - SelectedElements = 2


[ENUM] NavisworksParameters
Full Name: Autodesk.Revit.DB.NavisworksParameters

Description: An enumerated type listing possible "Parameter conversions" of Navisworks Exporter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Elements = 1
    - All = 2


[CLASS] NestedFamilyTypeReference
Full Name: Autodesk.Revit.DB.NestedFamilyTypeReference

Description: A proxy element representing a nested family type.
Remarks: This element represents a value of a FamilyType Parameter of a Loaded Family. Each such element corresponds to a nested FamilyType Element in the original Family Document where the family was defined.This element stores only basic information about the nested FamilyType, such as the name of the Type, name of the Family, and a Category.These elements are very low-level and thus bypassed by standard element filters. However, it is possible to obtain a set of applicable elements of this class for a FamilyType parameter of a family by calling
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId CategoryId { get; }
      Description: Category Id of the referenced family
    string FamilyName { get; }
      Description: Name of the referenced family
    string TypeName { get; }
      Description: Type of the referenced family

--------------------------------------------------------------------------------


[CLASS] NullParameterValue
Full Name: Autodesk.Revit.DB.NullParameterValue

Description: A class that represent an empty (null) value of a parameter element.
Inherits: ParameterValue
Implements: IDisposable

  CONSTRUCTORS:
    new NullParameterValue()

--------------------------------------------------------------------------------


[CLASS] NumberingSchema
Full Name: Autodesk.Revit.DB.NumberingSchema

Description: A class to support assigning numbers to elements of a particular kind for the purpose of tagging and scheduling them.
Remarks: Each NumberingSchema controls numbering of elements of one particular kind, typically of the same category such as Rebar or Fabric Reinforcement. Instances of NumberingSchema are also elements and there is always only one of each type in every Revit document. Available types of all built-in numbering schemas are enumerated in class. At present, schema elements cannot be manually added, deleted, or copied. Attempts to do so will result in a failure warning and/or exceptions thrown.Elements (e.g. Rebar) belonging to a particular schema (e.g. NumberingSchemaTypes.StructuralNumberingSchemas.Rebar) are organized and numbered in sequences. A sequence is a collection of elements that share the same numbering partition as defined by their respective values of the Partition parameter (NUMBER_PARTITION_PARAM). For a numbering sequence to exist it must contain at least one element. In other words, a sequence is established once there is at least one element of which the partition parameter has a value that differs from other elements (in the same numbering schema). If the last element is removed (deleted or moved to a different sequence) the then empty sequence ceases to exist.Elements get assigned to sequences either upon their creation (based on the then current numbering partition value), or by explicitly modifying the Partition parameter of an element, or by using the AssignElementsToSequence method. It is highly recommended using that method over explicitly changing the Partition parameter, because the methods applies changes to sequences and element numbers immediately, while changed parameters get into effect only after the current transaction is closed.In addition to directly or indirectly changing the Partition parameter of elements, numbering sequences can be reorganized by using methods of the NumberingSchema class. The MoveSequence method moves all elements of an existing sequence to a new sequence that does not exist yet in the schema, thus effectively renaming the Partition parameter on all the affected elements. The AppendSequence method removes all elements from one sequence and appends them to elements of another existing sequence while applying the matching policy. The method MergeSequences takes elements of all specified sequences and moves them all into a newly created sequence. All the merged elements will be renumbered and matched as needed based on the matching algorithm.Elements in different sequences are numbered independently, meaning that there may be elements with the same number in two sequences even though the elements are different. Likewise, there may be perfectly identical elements in two or more sequences bearing different numbers. However, within each one numbering sequence any two identical elements will always have the same number, while different elements will never have the same number within a numbering sequence. Revit refers to this rule as the matching policy.Enumerable elements are always numbered automatically upon their creation. Each new element will get an incrementally higher number. However, thanks to the matching policy, new elements that match existing elements within the same sequence will get the same number assigned. Elements will keep their assigned numbers as long as it is possible. This means, for example, that if some previously created elements (e.g. Rebar) get deleted, all remaining elements (within the same numbering sequence) will keep their numbers, which may result in gaps in the respective numbering sequence. Gaps can be removed by invoking RemoveGaps for sequences in which gaps are not desired.Numbers are stored as values of a numbering parameter on each numbered element. The Id of the parameter is obtained by querying the property. The value of the number can be obtained by querying the parameter for the respective numbered element. The value is read-only and thus cannot be set; it is always computed based on relations of elements across numbering partitions and the matching policy within the numbering sequence of each element.Even though numbers are always assigned automatically to all elements of a schema, the method ChangeNumber gives the programmer a way to explicitly overwrite a specific number as long as the new number is unique in the numbering sequence. The caller specifies a number to be changed and a new value that is to be applied, providing the value does not exist yet in the same numbering sequence. Although this operation may seem rather limited, it provides the programmer with freedom to change practically any number even if it may be achieved in multiple steps.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    static int MaximumStartingNumber { get; }
      Description: A static property defining the maximum number a numbering sequence can use as its starting number (the lowest number in the sequence).
    ElementId NumberingParameterId { get; }
      Description: Id of the parameter that stores values of the numbers on enumerated elements.
    NumberingSchemaType SchemaType { get; }
      Description: Identifies the kind of elements/objects this numbering schema is used for.

  METHODS:
    void AppendSequence(string fromPartition, string toPartition)
      Description: Appends all elements of one numbering sequence to the end of another sequence.
      @fromPartition: Name of the partition that determines which numbering sequence to append. The sequence must exist already, otherwise an exception will be thrown.
      @toPartition: Name of a partition into which the source sequence is going to be appended. The sequence must exist already, otherwise an exception will be thrown.
    void AssignElementsToSequence(ISet<ElementId> elementIds, string partitionName)
      Description: Assigns the input elements to a sequence identified by the given partition name.
      @elementIds: Ids of elements which are to be added to a sequence. All elements must be valid and belonging to this schema.
      @partitionName: Name of the target sequence's partition
    IList<ElementId> ChangeNumber(string partition, int fromNumber, int toNumber)
      Description: Replaces an existing number with a new one (that does not exist yet).
      @partition: Name of the partition that identifies the sequence containing the number to be changed.
      @fromNumber: Number to be changed; there must already be an element with that number in the sequence.
      @toNumber: Number to change to; no element must have this number yet in the sequence.
      Returns: A collection of elements affected by the change of the number
    static int GetMinimumNumberOfDigits(Document document)
      Description: Returns the minimum number of digits to be used for formating the Number parameter of all enumerable elements of the given document.
      @document: The document this value is going to be applied to.
      Returns: The current number of formatting digits
    static NumberingSchema GetNumberingSchema(Document document, NumberingSchemaType schemaType)
      Description: Returns an instance of the specified Numbering Schema in the given document.
      @document: A document to get the numbering schema from.
      @schemaType: The type of a built-in schema to get.
      Returns: Instance of the specified schema.
    IList<string> GetNumberingSequences()
      Description: Returns all numbering sequences within this numbering schema.
      Returns: A collection of partition names of all numbering sequences currently present in this schema.
    IList<IntegerRange> GetNumbers(string partition)
      Description: Returns all numbers currently used in the given numbering sequence
      @partition: Name of the partition that identifies the sequence. The sequence must exist.
      Returns: A collection of integer ranges
    static ISet<ElementId> GetSchemasInDocument(Document document)
      Description: Returns a set of Ids of all Numbering Schema elements for a given document.
      @document: A document to get numbering schema from.
      Returns: Ids of NumberingSchema elements. An empty set if no schemas are found in the given document.
    static bool IsValidPartitionName(string name, out string message)
    void MergeSequences(IList<string> sourcePartitions, string newPartition)
      Description: Merges all elements from given numbering sequences to a new sequence.
      @sourcePartitions: A collection of partition names identifying the sequences to be merged together. There must be at least two names in the list. All the sequences must exist already.
      @newPartition: Name of a new partition into which the source sequences will be merged. Leading and trailing white space is ignored in the given string and will be removed automatically.
    void MoveSequence(string fromPartition, string newPartition)
      Description: Moves all elements of a numbering sequence from one partition to another.
      @fromPartition: Name of the partition that determines which numbering sequence to move. The sequence must exist already, otherwise an exception will be thrown.
      @newPartition: Name of a partition into which the source sequence is going to be moved. The schema must not have a sequence for this partition yet (i.e. the schema does not have an element that was assigned to such a partition.) Leading and trailing white space is ignored in the given string and will be removed automatically.
    void RemoveGaps(string partition)
      Description: Removes gaps, if any, in a numbering sequence
      @partition: Name of the partition that identifies the sequence. The sequence must exist.
    static void SetMinimumNumberOfDigits(Document document, int value)
      Description: Sets a new value for the minimum number of digits to be used for formating the Number parameter of all numbered elements of the given document.
      @document: The document in which the new value will be in applied.
      @value: New value for the minimum number of digits.
    void ShiftNumbers(string partition, int firstNumber)
      Description: Shifts all numbers in the sequence so the starting number has the given value.
      @partition: Name of the partition that identifies the sequence. The sequence must exist.
      @firstNumber: Value for the new first (lowest) number of the sequence.

--------------------------------------------------------------------------------


[CLASS] NumberingSchemaType
Full Name: Autodesk.Revit.DB.NumberingSchemaType

Description: A type for identifying a of a particular kind.
Remarks: Each numbering schema is applicable to a certain category of Revit elements. For example, the Rebar numbering schema (built-in) is used and only applicable to Rebar elements. With that schema present, all Rebar elements automatically will get their respective numbers and those numbers would not correspond in any way to numbers of other enumerable elements that belong to different numbering schemas.There are only built-in schemas available currently.
Inherits: GuidEnum

  CONSTRUCTORS:
    new NumberingSchemaType(Guid guid)

--------------------------------------------------------------------------------


[ABSTRACT CLASS] NumberingSchemaTypes
Full Name: Autodesk.Revit.DB.NumberingSchemaTypes

Description: Provides a container of all Revit built-in NumberingSchemaType instances.

--------------------------------------------------------------------------------


[CLASS] NumberSystem
Full Name: Autodesk.Revit.DB.NumberSystem

Description: An annotation that consists of a series of numeric tags attached to and describing a host element.
Remarks: For a component-based stair, you can display tread/riser numbers for a run in plan, elevation, or section view. Sketch-based stair is not supported.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double JustifyOffset { get; set; }
      Description: The offset to the justification curve.
    NumberSystemJustifyOption JustifyOption { get; set; }
      Description: The number justify option of number system.
    NumberSystemDisplayRule NumberDisplayRule { get; set; }
      Description: The display rule of the number system.
    LinkElementId NumberedElementId { get; }
      Description: The LinkElementId of the numbered host element.
    TagOrientation NumberOrientation { get; set; }
      Description: The number orientation of number system.
    LinkElementId PlacementLevelId { get; }
      Description: The id of the base level of stairs on which the NumberSystem is placed.
    double ReferenceOffset { get; set; }
      Description: The offset to the reference curve.

  METHODS:
    static NumberSystem Create(Document document, ElementId viewId, LinkElementId hostElementId, StairsNumberSystemReferenceOption referenceOption, LinkElementId placementLevelId)
      Description: Creates a new instance of a NumberSystem associated to a host element, a view, and a reference level of stairs if in a multistory stairs.
      @document: The document.
      @viewId: The view in which the NumberSystem will be created.
      @hostElementId: The host id on which the NumberSystem will be created.
      @referenceOption: The reference option of the NumberSystem.
      @placementLevelId: The id of the level on which the NumberSystem will be placed. The placement level must be one of the base levels of a stairs group members. It is suggested to get the level from MultistoryStairs.GetStairsPlacementLevels().
      Returns: The created NumberSystem.
    static NumberSystem Create(Document document, ElementId viewId, LinkElementId numberedElementId, Reference referenceCurve)
      Description: Creates a new instance of a NumberSystem associated to a host element and a view.
      @document: The document.
      @viewId: The view in which the NumberSystem will be created.
      @numberedElementId: The host id on which the NumberSystem will be created.
      @referenceCurve: The reference curve along which the NumberSystem will be created. It is suggested to get the new reference via GetNumberSystemReference() from the host element.
      Returns: The created NumberSystem.
    Reference GetReferencePick()
      Description: Gets the reference curve.
      Returns: The pick of reference curve.
    void SetReferencePick(Reference referencePick)
      Description: Sets the reference pick.
      @referencePick: The pick to set.

--------------------------------------------------------------------------------


[ENUM] NumberSystemDisplayRule
Full Name: Autodesk.Revit.DB.NumberSystemDisplayRule

Description: The available options for display of numeric values in the number system.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - All = 0
    - Odd = 1
    - Even = 2
    - StartAndEnd = 3


[ENUM] NumberSystemJustifyOption
Full Name: Autodesk.Revit.DB.NumberSystemJustifyOption

Description: The available options for justification of the numbers in a number system.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Front = 0
    - Center = 1
    - Back = 2


[CLASS] NumericRevisionSettings
Full Name: Autodesk.Revit.DB.NumericRevisionSettings

Description: Contains settings that apply to Revisions with the Numeric RevisionNumberType.
Implements: IDisposable

  CONSTRUCTORS:
    new NumericRevisionSettings(int startNumber, string prefix, string suffix)
    new NumericRevisionSettings()
    new NumericRevisionSettings(NumericRevisionSettings other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int MinimumDigits { get; set; }
      Description: Controls the minimum number of digits for a revision number.
    string Prefix { get; set; }
      Description: The prefix string that will be prepended to the number of each revision with Numeric RevisionNumberingType.
    int StartNumber { get; set; }
      Description: The start number for the sequence.
    string Suffix { get; set; }
      Description: The suffix string that will be appended to the number of each revision with Numeric RevisionNumberingType.

  METHODS:
    void Dispose()
    bool IsEqual(NumericRevisionSettings other)
      Description: Determines whether a specified NumericRevisionSettings is the same as 'this'.
      @other: The specified NumericRevisionSettings with which to compare.
      Returns: True, if two NumericRevisionSettings are the same.
    bool IsValid()
      Description: Determines whether the NumericRevisionSettings object is in a valid state.
      Returns: True if the NumericRevisionSettings is valid.

--------------------------------------------------------------------------------


[CLASS] NurbSpline
Full Name: Autodesk.Revit.DB.NurbSpline

Description: A nurb spline.
Remarks: The nurb spline lies in the plane defined by control point, weight,knots,degree.
Inherits: Curve
Implements: IDisposable

  PROPERTIES:
    IList<XYZ> CtrlPoints { get; }
      Description: Returns the control points of the nurb spline.
    int Degree { get; }
      Description: Returns the degree of the nurb spline.
    bool isRational { get; }
      Description: Returns whether the nurb spline is rational or not.
    DoubleArray Knots { get; set; }
      Description: Return/set the knots of the nurb spline.
    DoubleArray Weights { get; }
      Description: Returns the weights of the nurb spline.

  METHODS:
    static NurbSpline Create(HermiteSpline hermiteSpline)
      Description: Creates a new geometric NurbSpline object from a HermiteSpline.
      @hermiteSpline: The hermite spline that will be converted to NurbSpline.
      Returns: The new NurbSpline object.
    static Curve CreateCurve(HermiteSpline hermiteSpline)
      Description: Creates a new geometric Curve object by converting the given HermiteSpline. The created curve may be a NURBSpline or a simpler curve such as line or arc.
      @hermiteSpline: The HermiteSpline that will be converted.
      Returns: The new Curve object.
    static Curve CreateCurve(IList<XYZ> controlPoints, IList<double> weights)
      Description: Creates a new geometric Curve object from NURBS curve data containing just control points and weights. The created curve may be a NURBSpline or a simpler curve such as line or arc.
      @controlPoints: The control points of the NURBSpline.
      @weights: The weights of the NURBSpline.
      Returns: The new Curve object.
    static Curve CreateCurve(int degree, IList<double> knots, IList<XYZ> controlPoints, IList<double> weights)
      Description: Creates a new geometric Curve object from NURBS curve data, which includes weights. The created curve may be a NURBSpline or a simpler curve such as line or arc.
      @degree: The degree of the NURBSpline.
      @knots: The knots of the NURBSpline.
      @controlPoints: The control points of the NURBSpline.
      @weights: The weights of the NURBSpline.
      Returns: The new Curve object.
    static Curve CreateCurve(int degree, IList<double> knots, IList<XYZ> controlPoints)
      Description: Creates a new geometric Curve object from NURBS curve data, which does not include weights. The created curve may be a NURBSpline or a simpler curve such as line or arc.
      @degree: The degree of the NURBSpline.
      @knots: The knots of the NURBSpline.
      @controlPoints: The control points of the NURBSpline.
      Returns: The new Curve object.
    void SetControlPointsAndWeights(IList<XYZ> ctrlPoints, DoubleArray weights)
      Description: Set the control points, weights simultaneously.

--------------------------------------------------------------------------------


[CLASS] NurbsSurfaceData
Full Name: Autodesk.Revit.DB.NurbsSurfaceData

Description: A class used to represent the definition of a NURBS surface.
Implements: IDisposable

  CONSTRUCTORS:
    new NurbsSurfaceData(NurbsSurfaceData other)

  PROPERTIES:
    int DegreeU { get; }
      Description: The degree of the spline in the u-direction.
    int DegreeV { get; }
      Description: The degree of the spline in the v-direction.
    bool IsRational { get; }
      Description: Tells if the spline is rational or not. If it is true (rational), then the NURBS is a piecewise rational polynomial function. If it is false (non-rational), then the NURBS is a piecewise polynomial function.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ReverseOrientation { get; }
      Description: If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same. The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane. Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.

  METHODS:
    static NurbsSurfaceData Create(int degreeU, int degreeV, IList<double> knotsU, IList<double> knotsV, IList<XYZ> controlPoints, IList<double> weights, bool bReverseOrientation)
      Description: Construct NurbsSurfaceData based on NURBS surface data, where the weights are supplied. The NURBS surface will be (piecewise) polynomial if all the weights are equal, rational if not. Note: A rational polynomial is a quotient of two polynomials; this includes a polynomial, which can be thought of as a quotient with denominator equal to 1.
      @degreeU: The degree of the spline in the u-direction; must be positive.
      @degreeV: The degree of the spline in the v-direction; must be positive.
      @knotsU: Knot values in the u-direction. The number of knots in the u-direction must be at least 2 * (degreeU + 1).
      @knotsV: Knot values in the v-direction. The number of knots in the v-direction must be at least 2 * (degreeV + 1).
      @controlPoints: One dimensional array of points representing the two dimensional net of control points of the NURBS surface in u and v directions. The total number of control points must equal numControlPtsU times numControlPtsV, where numControlPtsU and numControlPtsV are the numbers of control points in u and v directions, and they must satisfy the following conditions: numControlPtsU = number of knots in u - degreeU - 1. numControlPtsV = number of knots in v - degreeV - 1. The convention for 2d (idxU, idxV) to 1d (idx) conversion of array indexes: idxV first. That is, idxU is outer loop and idxV is inner loop. In other words, idx = idxU * numControlPtsV + idxV.
      @weights: Array of weights assigned to the control points. The number of weights must equal the number of control points. All weights should be greater than zero.
      @bReverseOrientation: If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same. The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane. Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.
    void Dispose()
    IList<XYZ> GetControlPoints()
      Description: Get the list of control points.
    IList<double> GetKnotsU()
      Description: Get the list of knots in the u-direction.
    IList<double> GetKnotsV()
      Description: Get the list of knots in the v-direction.
    IList<double> GetWeights()
      Description: Get the list of weights.
    bool IsValid()
      Description: Check if the object contains a valid NurbsSurfaceData.
      Returns: True if it is a valid NurbsSurfaceData, false otherwise.

--------------------------------------------------------------------------------


[CLASS] OBJExportOptions
Full Name: Autodesk.Revit.DB.OBJExportOptions

Description: The export options used by exporting to OBJ file format.
Inherits: BIMExportOptions
Implements: IDisposable

  CONSTRUCTORS:
    new OBJExportOptions(ExportResolution resolutionType)
    new OBJExportOptions()

  PROPERTIES:
    double GridAspectRatio { get; set; }
      Description: The maximum aspect ratio allowed in the grid placed across the face. The minimum allowed value is 1.0. The maximum allowed value is 10.0. By default this property is ignored.
    double MaxEdgeLength { get; set; }
      Description: The maximum length allowed for any chord on an edge or between any two adjacent grid lines. This is a percentage value. By exporting, the real value of maximum edge length is calculated as a percent from the length of the diameter of the body bounding box. The minimum allowed value is 0.1%. The maximum allowed value is 10.0%. By default this property is ignored.
    double NormalTolerance { get; set; }
      Description: The maximum change in the surface normal between adjacent nodes in the mesh. This property is defined in degrees. The minimum allowed value is 1.0 degrees. The maximum allowed value is 45.0 degrees. Default value is 15.0 degrees.
    double SurfaceTolerance { get; set; }
      Description: The maximum distance between mesh triangles and model geometry. This is a percentage value. By exporting, the real value of surface tolerance is calculated as a percent from the length of the diameter of the body bounding box. The minimum allowed value is 0.001%. The maximum allowed value is 1.0%. Default value is 0.1%.
    ExportUnit TargetUnit { get; set; }
      Description: The unit type of geometry in the resultant OBJ file. Default value is ExportUnit::Default.

  METHODS:
    bool IsGridAspectRatioSet()
      Description: Checks whether the GridAspectRatio tessellation parameter is explicitly set.
      Returns: True if GridAspectRatio tessellation parameter is explicitly set, false otherwise.
    bool IsMaxEdgeLengthSet()
      Description: Checks whether the MaxEdgeLength tessellation parameter is explicitly set.
      Returns: True if MaxEdgeLength tessellation parameter is explicitly set, false otherwise.
    bool IsNormalToleranceSet()
      Description: Checks whether the NormalTolerance tessellation parameter is explicitly set.
      Returns: True if NormalTolerance tessellation parameter is explicitly set, false otherwise.
    bool IsSurfaceToleranceSet()
      Description: Checks whether the SurfaceTolerance tessellation parameter is explicitly set.
      Returns: True if SurfaceTolerance tessellation parameter is explicitly set, false otherwise.
    static bool IsValidForGridAspectRatio(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for GridAspectRatio tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for GridAspectRatio, false otherwise.
    static bool IsValidForMaxEdgeLength(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for MaxEdgeLength tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for MaxEdgeLength, false otherwise.
    static bool IsValidForNormalTolerance(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for NormalTolerance tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for NormalTolerance, false otherwise.
    static bool IsValidForSurfaceTolerance(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for SurfaceTolerance tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for SurfaceTolerance, false otherwise.
    void SetTessellationSettings(ExportResolution resolutionType)
      Description: Sets all the tessellation parameters to its predefined values for the given resolution type.
      @resolutionType: Type of exporting resolution.

--------------------------------------------------------------------------------


[CLASS] OBJImportOptions
Full Name: Autodesk.Revit.DB.OBJImportOptions

Description: The import options used to import OBJ format files.
Inherits: BaseImportOptions
Implements: IDisposable

  CONSTRUCTORS:
    new OBJImportOptions(OBJImportOptions option)
    new OBJImportOptions()

--------------------------------------------------------------------------------


[CLASS] OffsetSurface
Full Name: Autodesk.Revit.DB.OffsetSurface

Description: A mathematical representation of an offset surface. Definition of offset surface, quoted from the STEP manual ISO 10303-42:2000(E): This is a procedural definition of a simple offset surface at a normal distance from the originating surface. Distance may be positive, negative, or zero to indicate the preferred side of the surface. The offset surface takes its parametrization directly from that of its basis surface, corresponding points having identical parameter values. The offset surface is parametrized as O(u, v) = S(u, v) + d*N(u, v), where N(u, v) is the oriented unit normal vector of the basis surface S at parameter value (u, v), and d is the signed offset distance. In Revit, we restrict the types of basis surfaces for which an OffsetSurf can be created for the following reasons: The offsets of Plane, CylindricalSurface, ConicalSurface and RevolvedSurface are of the same type as the original surface and they have closed form solutions. So those surfaces are not taken as basis surfaces of the OffsetSurface class. That leaves HermiteSurface and RuledSurface. As a Revit surface, we require the OffsetSurface to be C2 continuous. That implies that the basis surface should be C3 continuous. That is because the OffsetSurface evaluation involves the normal of the basis surface and the order of continuity of the normal is one less than that of the surface. HermiteSurfaces in general are not C3 continuous, even though some of them can be. A RuledSurface will be C3 continuous if its parametric curves are C3 continuous. So we don't allow a HermiteSurface to be a basis surface and allow only RuledSurfaces whose parametric curves are C3 continuous as basis surfaces of the OffsetSurface class. The OffsetSurface class will own a copy of the basis surface and use it for many of its methods, which may implicitly assume that the OffsetSurface and the basis surface have the same envelope. So we keep the envelopes of the OffsetSurf and its basis surface in sync.
Inherits: Surface
Implements: IDisposable

  METHODS:
    Surface GetBasisSurface()
      Description: Returns a copy of basis surface of this OffsetSurface.
      Returns: Basis surface of this OffsetSurface.
    double GetOffsetDistance()
      Description: Returns offset distance of this OffsetSurface.
      Returns: Offset distance of this OffsetSurface.
    bool IsOrientationSameAsBasisSurface()
      Description: Indicates whether the orientation of the OffsetSurface is same as that of its basis surface, in the sense that their oriented normals at any (u, v) have the same direction.
      Returns: True if the orientation of the OffsetSurface is same as that of its basis surface, false otherwise.

--------------------------------------------------------------------------------


[ENUM] OpenConflictResult
Full Name: Autodesk.Revit.DB.OpenConflictResult

Description: The result of the open conflict.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - KeepLocalChanges = 0
    - DiscardLocalChangesAndOpenLatestVersion = 1
    - Cancel = 2
    - DetachFromCentral = 3


[ENUM] OpenConflictScenario
Full Name: Autodesk.Revit.DB.OpenConflictScenario

Description: The kinds of conflicts happened during open.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Rollback = 0
    - Relinquished = 1
    - OutOfDate = 2
    - VersionArchived = 3


[ENUM] OpenForeignOption
Full Name: Autodesk.Revit.DB.OpenForeignOption

Description: Options for opening files saved by an application that was not developed or licensed by Autodesk.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Open = 0
    - DoNotOpen = 1
    - Prompt = 2


[CLASS] Opening
Full Name: Autodesk.Revit.DB.Opening

Description: An opening in an Autodesk Revit project or family document.
Remarks: The object represents a variety of different types of openings: A rectangular opening in a wall created by two boundary points in a revit project.An opening created by a set of curves applied to a roof, floor, ceiling, beam, brace or column.A vertical shaft opening extending one or more levels.A simple opening created on a wall or ceiling in a family document. Depending upon the type of opening, some of the properties of this class will not be available. This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object. This object also supports access to a structural analytical model but this feature is only available with Autodesk Revit Structure.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    CurveArray BoundaryCurves { get; }
      Description: The geometry information for non-rectangular openings in project documents, or for all openings in family documents.
    IList<XYZ> BoundaryRect { get; }
      Description: Retrieves the geometry information if the opening boundary is a rect.
    Element Host { get; }
      Description: Retrieves the host element of this opening.
    bool IsRectBoundary { get; }
      Description: Retrieves the information whether the opening has a rectangular boundary.
    bool IsTransparentIn3D { get; set; }
      Description: Indicates if the opening is transparent in 3D view when loaded into the project.
    bool IsTransparentInElevation { get; set; }
      Description: Indicates if the opening is transparent in elevation view when loaded into the project.
    ElementId SketchId { get; }
      Description: Returns id of the Sketch or invalidElementId if element deon't own the Sketch.

--------------------------------------------------------------------------------


[ENUM] OpeningWrappingCondition
Full Name: Autodesk.Revit.DB.OpeningWrappingCondition

Description: Used by CompoundStructure to describe which shell layers participate in wrapping at openings.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Exterior = 1
    - Interior = 2
    - ExteriorAndInterior = 3


[CLASS] OpenOptions
Full Name: Autodesk.Revit.DB.OpenOptions

Description: This class contains options available for opening a document from disk.
Implements: IDisposable

  CONSTRUCTORS:
    new OpenOptions()

  PROPERTIES:
    bool AllowOpeningLocalByWrongUser { get; set; }
      Description: Specifies whether a local file is allowed to be opened as read-only by a user other than its owner.
    bool Audit { get; set; }
      Description: Specifies whether to expand all elements in order to check for corruption.
    DetachFromCentralOption DetachFromCentralOption { get; set; }
      Description: An option that specifies whether or not a workset-enabled document is detached from its central document.
    bool IgnoreExtensibleStorageSchemaConflict { get; set; }
      Description: Specifies whether to ignore the error of schema conflict.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    OpenForeignOption OpenForeignOption { get; set; }
      Description: An option that specifies how to open files saved by an application that was not developed or licensed by Autodesk.

  METHODS:
    void Dispose()
    WorksetConfiguration GetOpenWorksetsConfiguration()
      Description: Gets the object used to configure the worksets to open when the model is opened.
      Returns: The options. If , all user-created worksets will be opened.
    void SetOpenWorksetsConfiguration(WorksetConfiguration openConfiguration)
      Description: Sets the object used to configure the worksets to open when the model is opened.
      @openConfiguration: The options. If , all user-created worksets will be opened.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] OptionalFunctionalityUtils
Full Name: Autodesk.Revit.DB.OptionalFunctionalityUtils

Description: A collection of utilities that can be used to determine if a particular set of functionality is installed and available.

  METHODS:
    static bool Is3DMImportLinkAvailable()
      Description: Checks whether the 3DM Import/Link functionality is available in the installed Revit.
      Returns: True if the 3DM Import/Link functionality is available in the installed Revit.
    static bool IsAXMImportLinkAvailable()
      Description: Checks whether the AXM Import/Link functionality is available in the installed Revit.
      Returns: True if the AXM Import/Link functionality is available in the installed Revit.
    static bool IsDGNExportAvailable()
      Description: Checks whether the DGN Export functionality is available in the installed Revit.
      Returns: True if the DGN Export functionality is available in the installed Revit.
    static bool IsDGNImportLinkAvailable()
      Description: Checks whether the DGN Import/Link functionality is available in the installed Revit.
      Returns: True if the DGN Import/Link functionality is available in the installed Revit.
    static bool IsDWFExportAvailable()
      Description: Checks whether the DWF/DWFx Export functionality is available in the installed Revit.
      Returns: True if the DWF/DWFx Export functionality is available in the installed Revit.
    static bool IsDWGExportAvailable()
      Description: Checks whether the DWG Export functionality is available in the installed Revit.
      Returns: True if the DWG Export functionality is available in the installed Revit.
    static bool IsDWGImportLinkAvailable()
      Description: Checks whether the DWG Import/Link functionality is available in the installed Revit.
      Returns: True if the DWG Import/Link functionality is available in the installed Revit.
    static bool IsDXFExportAvailable()
      Description: Checks whether the DXF Export functionality is available in the installed Revit.
      Returns: True if the DXF Export functionality is available in the installed Revit.
    static bool IsFBXExportAvailable()
      Description: Checks whether the FBX Export functionality is available in the installed Revit.
      Returns: True if the FBX Export functionality is available in the installed Revit.
    static bool IsGraphicsAvailable()
      Description: Checks whether the graphics functionality is available to support display, print, and export functionality.
      Returns: True if the Graphics functionality is available in the installed Revit.
    static bool IsIFCAvailable()
      Description: Checks whether IFC functionality is available in the installed Revit.
      Returns: True if the IFC functionality is available in the installed Revit.
    static bool IsNavisworksExporterAvailable()
      Description: Checks whether a Navisworks Exporter is available in the installed Revit.
      Returns: True if a Navisworks Exporter is available in the installed Revit.
    static bool IsOBJImportLinkAvailable()
      Description: Checks whether the OBJ Import/Link functionality is available in the installed Revit.
      Returns: True if the OBJ Import/Link functionality is available in the installed Revit.
    static bool IsPDFImportAvailable()
      Description: Checks whether PDF import is available in the installed Revit.
      Returns: True if a PDF import is available in the installed Revit.
    static bool IsSATImportLinkAvailable()
      Description: Checks whether the SAT Import/Link functionality is available in the installed Revit.
      Returns: True if the SAT Import/Link functionality is available in the installed Revit.
    static bool IsShapeImporterAvailable()
      Description: Checks whether the ShapeImporter functionality is available in the installed Revit.
      Returns: True if the ShapeImporter functionality is available in the installed Revit.
    static bool IsSKPImportLinkAvailable()
      Description: Checks whether the SKP Import/Link functionality is available in the installed Revit.
      Returns: True if the SKP Import/Link functionality is available in the installed Revit.
    static bool IsSTEPImportLinkAvailable()
      Description: Checks whether the STEP Import/Link functionality is available in the installed Revit.
      Returns: True if the STEP Import/Link functionality is available in the installed Revit.
    static bool IsSTLImportLinkAvailable()
      Description: Checks whether the STL Import/Link functionality is available in the installed Revit.
      Returns: True if the STL Import/Link functionality is available in the installed Revit.

--------------------------------------------------------------------------------


[CLASS] Options
Full Name: Autodesk.Revit.DB.Options

Description: User preferences for parsing of geometry.
Remarks: This class determines the output of the Element.Geometry property.
Inherits: APIObject
Implements: IDisposable

  CONSTRUCTORS:
    new Options(Options pOptions)
    new Options()

  PROPERTIES:
    bool ComputeReferences { get; set; }
      Description: Determines whether or not references to geometric objects are computed.
    ViewDetailLevel DetailLevel { get; set; }
      Description: The detail level for the geometry extracted with these options.
    bool IncludeNonVisibleObjects { get; set; }
      Description: Whether to extract element geometry objects not set as Visible. The default is false.
    View View { get; set; }
      Description: The view used for geometry extraction.

--------------------------------------------------------------------------------


[ENUM] OrdinateDimensionLineStyle
Full Name: Autodesk.Revit.DB.OrdinateDimensionLineStyle

Description: The ordinate dimension line style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Continuous = 1
    - Segmented = 2


[CLASS] OrdinateDimensionSetting
Full Name: Autodesk.Revit.DB.OrdinateDimensionSetting

Description: Represents a collection of Ordinate Dimension settings that can be associated to an ordinate DimensionType.
Implements: IDisposable

  CONSTRUCTORS:
    new OrdinateDimensionSetting()

  PROPERTIES:
    double DimensionLineLength { get; set; }
      Description: Specifies the dimension line segment length. This setting is enabled when Dimension Line Style is Segmented.
    OrdinateDimensionLineStyle DimensionLineStyle { get; set; }
      Description: Specifies the dimension line style.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId OriginTickMarkId { get; set; }
      Description: Specifies the id of the tick mark element to use for the dimension origin.
    OrdinateOriginVisibility OriginVisibility { get; set; }
      Description: Specifies thevisibility of the origin witness line for the ordinate dimension (this is the first witness line in the string).
    OrdinateTextOrientation TextOrientation { get; set; }
      Description: Specifies where to align the dimension text.
    OrdinateTextPosition TextPosition { get; set; }
      Description: Specifies the dimension text position.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] OrdinateOriginVisibility
Full Name: Autodesk.Revit.DB.OrdinateOriginVisibility

Description: The ordinate origin visibility.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - WitnessLineWithText = 1
    - WitnessLineOnly = 2


[ENUM] OrdinateTextOrientation
Full Name: Autodesk.Revit.DB.OrdinateTextOrientation

Description: The ordinate dimension text orientation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ParallelToDimensionLine = 0
    - ParallelToWitnessLine = 1


[ENUM] OrdinateTextPosition
Full Name: Autodesk.Revit.DB.OrdinateTextPosition

Description: The ordinate dimension text position.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - EndOfWitnessLine = 0
    - NextToWitnessLine = 1


[CLASS] Outline
Full Name: Autodesk.Revit.DB.Outline

Description: Outline is a generic object that provides a bounding box/bounding outline. It supports operations to scale and transform. It also supports intersections and contains operations.
Implements: IDisposable

  CONSTRUCTORS:
    new Outline(XYZ minimumPoint, XYZ maximumPoint)
    new Outline(Outline other)

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Identifies if the outline represents an empty outline.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ MaximumPoint { get; set; }
      Description: The maximum point of the bounding box.
    XYZ MinimumPoint { get; set; }
      Description: The minimum point of the bounding box.

  METHODS:
    void AddPoint(XYZ point)
      Description: Adds a point to the bounding box, expanding it if the point is outside the existing boundary.
      @point: The point to add.
    bool Contains(XYZ point, double tolerance)
      Description: Determine if this Outline contains the specified point to within a tolerance.
      @point: The point to test for containment.
      @tolerance: The tolerance to use when determining whether the point is contained. Defaults to zero.
      Returns: True if this outline contains the given point, or false otherwise.
    bool ContainsOtherOutline(Outline otherOutline, double tolerance)
      Description: Determine if this Outline contains another Outline to within tolerance.
      @otherOutline: The outline to test for containment.
      @tolerance: The tolerance to use when determining whether the point is contained. Defaults to zero.
      Returns: True if this outline contains the given outline, or false otherwise.
    void Dispose()
    double GetDiagonalLength()
      Description: Get the length of outline's diagonal. If called on empty outline, 0. is returned
      Returns: The length of the diagonal.
    bool Intersects(Outline outline, double tolerance)
      Description: Determine if this Outline intersects the input Outline to within a specified tolerance.
      @outline: The outline to test for intersection with this one.
      @tolerance: The tolerance to use when determining intersection. Defaults to zero.
      Returns: True if the given outline intersects this outline.
    bool IsScaleValid(double scale)
      Description: Checks if given scale is valid. Should be greater than zero.
      @scale: The scale.
      Returns: True if the scale is valid, false otherwise.
    void Scale(double scale)
      Description: Scales the bounding box by given scale.
      @scale: The scale value. It should be greater than zero.

--------------------------------------------------------------------------------


[CLASS] OverrideGraphicSettings
Full Name: Autodesk.Revit.DB.OverrideGraphicSettings

Description: Settings to override display of elements in a view.
Implements: IDisposable

  CONSTRUCTORS:
    new OverrideGraphicSettings(OverrideGraphicSettings overrideGraphicSettings)
    new OverrideGraphicSettings()

  PROPERTIES:
    Color CutBackgroundPatternColor { get; }
      Description: The override color of the background pattern of cut faces.
    ElementId CutBackgroundPatternId { get; }
      Description: The ElementId of the cut face background fill pattern override. A value of InvalidElementId means no override is set.
    Color CutForegroundPatternColor { get; }
      Description: The override color of the foreground pattern of cut faces.
    ElementId CutForegroundPatternId { get; }
      Description: The ElementId of the cut face foreground fill pattern override. A value of InvalidElementId means no override is set.
    Color CutLineColor { get; }
      Description: Cut surface line color.
    ElementId CutLinePatternId { get; }
      Description: ElementId of the cut surface line pattern.
    int CutLineWeight { get; }
      Description: Cut surface line weight.
    ViewDetailLevel DetailLevel { get; }
      Description: The detail level.
    bool Halftone { get; }
      Description: Value of the halftone override.
    static int InvalidPenNumber { get; }
      Description: The invalidPenNumber for clearing line weight overrides.
    bool IsCutBackgroundPatternVisible { get; }
      Description: The visibility of the cut face background fill pattern.
    bool IsCutForegroundPatternVisible { get; }
      Description: The visibility of the cut face foreground fill pattern.
    bool IsSurfaceBackgroundPatternVisible { get; }
      Description: The visibility of the surface background fill pattern.
    bool IsSurfaceForegroundPatternVisible { get; }
      Description: The visibility of the surface foreground fill pattern.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color ProjectionLineColor { get; }
      Description: Projection surface line color.
    ElementId ProjectionLinePatternId { get; }
      Description: Id of the projection surface line pattern.
    int ProjectionLineWeight { get; }
      Description: The projection surface line weight.
    Color SurfaceBackgroundPatternColor { get; }
      Description: The override color of the surface background pattern.
    ElementId SurfaceBackgroundPatternId { get; }
      Description: The ElementId of the surface background fill pattern override. A value of InvalidElementId means no override is set.
    Color SurfaceForegroundPatternColor { get; }
      Description: The override color of the surface foreground pattern.
    ElementId SurfaceForegroundPatternId { get; }
      Description: The ElementId of the surface foreground fill pattern override. A value of InvalidElementId means no override is set.
    int Transparency { get; }
      Description: Transparency of surfaces.

  METHODS:
    void Dispose()
    OverrideGraphicSettings SetCutBackgroundPatternColor(Color color)
      Description: Sets the override color of the background pattern of cut faces.
      @color: Value of the cut face background color for the override. InvalidColorValue means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutBackgroundPatternId(ElementId fillPatternId)
      Description: Sets the ElementId of the cut face background pattern override. The fill pattern must be a drafting pattern. A value of InvalidElementId means no override is set.
      @fillPatternId: Value of the cut face background fill pattern override.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutBackgroundPatternVisible(bool fillPatternVisible)
      Description: Sets the visibility of the cut face background fill pattern.
      @fillPatternVisible: Value of the visibility of the cut face background fill pattern.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutForegroundPatternColor(Color color)
      Description: Sets the override color of the foreground pattern of cut faces.
      @color: Value of the cut face foreground color for the override. InvalidColorValue means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutForegroundPatternId(ElementId fillPatternId)
      Description: Sets the ElementId of the cut face foreground pattern override. The fill pattern must be a drafting pattern. A value of InvalidElementId means no override is set.
      @fillPatternId: Value of the cut face foreground fill pattern override.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutForegroundPatternVisible(bool fillPatternVisible)
      Description: Sets the visibility of the cut face foreground fill pattern.
      @fillPatternVisible: Value of the visibility of the cut face foreground fill pattern.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutLineColor(Color color)
      Description: Sets the cut surface line color.
      @color: Value of the cut surface line color for the override. InvalidColorValue means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutLinePatternId(ElementId linePatternId)
      Description: Sets the ElementId of the cut surface line pattern.
      @linePatternId: ElementId of the cut surface line pattern for the override. InvalidElementId means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetCutLineWeight(int lineWeight)
      Description: Sets the cut surface line weight.
      @lineWeight: Value of the cut surface line weight for the override. InvalidPenNumber means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetDetailLevel(ViewDetailLevel detailLevel)
      Description: Sets the detail level.
      @detailLevel: Value of the detail level. ViewDetailLevel.Undefined means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetHalftone(bool halftone)
      Description: Sets the halftone value.
      @halftone: True if the override displays in halftone, false otherwise.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetProjectionLineColor(Color color)
      Description: Sets the projection surface line color.
      @color: Value of the projection surface line color for the override. InvalidColorValue means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetProjectionLinePatternId(ElementId linePatternId)
      Description: Sets the ElementId of the projection surface line pattern.
      @linePatternId: ElementId of the projection surface line pattern for the override. InvalidElementId means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetProjectionLineWeight(int lineWeight)
      Description: Sets the projection surface line weight.
      @lineWeight: Value of the projection surface line weight for the override. InvalidPenNumber means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceBackgroundPatternColor(Color color)
      Description: Sets the override color of the surface background pattern.
      @color: Value of the surface background color for the override. InvalidColorValue means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceBackgroundPatternId(ElementId fillPatternId)
      Description: Sets the ElementId of the surface background pattern override. The fill pattern must be a drafting pattern. A value of InvalidElementId means no override is set.
      @fillPatternId: Value of the surface background fill pattern override.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceBackgroundPatternVisible(bool fillPatternVisible)
      Description: Sets the visibility of the surface background fill pattern.
      @fillPatternVisible: Value of the visibility of the surface background fill pattern.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceForegroundPatternColor(Color color)
      Description: Sets the override color of the surface foreground pattern.
      @color: Value of the surface foreground color for the override. InvalidColorValue means no override is set.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceForegroundPatternId(ElementId fillPatternId)
      Description: Sets the ElementId of the surface foreground pattern override. The fill pattern must be a drafting pattern. A value of InvalidElementId means no override is set.
      @fillPatternId: Value of the surface foreground fill pattern override.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceForegroundPatternVisible(bool fillPatternVisible)
      Description: Sets the visibility of the surface foreground fill pattern.
      @fillPatternVisible: Value of the visibility of the surface foreground fill pattern.
      Returns: Reference to the changed object.
    OverrideGraphicSettings SetSurfaceTransparency(int transparency)
      Description: Sets the projection surface transparency.
      @transparency: Value of the transparency of the projection surface (0 = opaque, 100 = fully transparent).
      Returns: Reference to the changed object.

--------------------------------------------------------------------------------


[ENUM] OverridePermissions
Full Name: Autodesk.Revit.DB.OverridePermissions

Description: Types of overrides that can be applied to a category.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ViewDetailLevel = 1
    - Halftone = 2
    - CutLines = 3
    - CutFills = 4
    - ProjectionLines = 5
    - ProjectionFills = 6
    - Surfaces = 7

