# Autodesk.Revit.DB.Electrical


NAMESPACE: Autodesk.Revit.DB.Electrical
--------------------------------------------------------------------------------

[CLASS] AnalyticalBusData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalBusData

Description: Represents the data and parameters of analytical bus node.
Inherits: AnalyticalPowerDistributableNodeData
Implements: IDisposable

  PROPERTIES:
    double CurrentRating { get; set; }
      Description: The current rating value of the analytical bus.
    double TotalConnectedCurrent { get; }
      Description: The total connected current of the analytical bus.
    double Voltage { get; set; }
      Description: The voltage value of the analytical bus.

--------------------------------------------------------------------------------

[CLASS] AnalyticalDistributionNodePropertyData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData

Description: Represents the data and parameters of electrical analytical node.
Implements: IDisposable

  PROPERTIES:
    ElectricalConnectedPhases ConnectedPhases { get; }
      Description: The electrical connected phases of the electrical analytical node to its upstream node.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfPhases { get; }
      Description: The number of electrical phases.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] AnalyticalEquipmentLoadData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData

Description: Represents the data and parameters of point load node.
Inherits: AnalyticalDistributionNodePropertyData
Implements: IDisposable

  PROPERTIES:
    double ApparentLoad { get; set; }
      Description: The electrical apparent load of analytical equipment load.
    double Current { get; }
      Description: The current of the analytical equipment load.
    ElementId LoadClassification { get; set; }
      Description: The load classification of analytical equipment load.
    ElementId LoadSet { get; set; }
      Description: The electrical analytical load set of the analytical equipment load.
    ElectricalLoadType LoadType { get; }
      Description: The load type of analytical equipment load.
    int PhasesNumber { get; set; }
      Description: The number of electrical phases of the analytical equipment load.
    double PowerFactor { get; set; }
      Description: The power factor of analytical equipment load.
    PowerFactorStateType PowerFactorState { get; set; }
      Description: The PowerFactorState type of the analytical equipment load.
    double TrueLoad { get; }
      Description: The electrical true load of analytical equipment load.
    double Voltage { get; set; }
      Description: The voltage of the analytical equipment load.

--------------------------------------------------------------------------------

[CLASS] AnalyticalPowerDistributableNodeData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalPowerDistributableNodeData

Description: Represents the data and parameters of a power distributable node. A power distribution node is an electrical analytical node with a distribution system which defines the connection rules between upstream and downstream electrical analytical nodes.
Inherits: AnalyticalDistributionNodePropertyData
Implements: IDisposable

  PROPERTIES:
    int AssignedPhasesNumber { get; }
      Description: The number of electrical phases assigned through the distribution system of the power distributable node.
    double AssignedVoltage { get; }
      Description: The voltage assigned through the distribution system of the power distributable node.
    ElementId DistributionSystem { get; set; }
      Description: The distribution system of the power distributable node.

  METHODS:
    IList<ElectricalConnectedPhases> GetAllAvailableConnectedPhasesOnDownstream(ElementId id)
      Description: Get all the available electrical connected phases that this power distributable node can provide to the downstream node.
      @id: The downstream node id.
      Returns: All the available electrical connected phases that this power distributable node can provide to the downstream node.
    ElectricalPerPhaseData GetApparentPerPhaseResults()
      Description: Get an ElectricalPerPhaseData which contains each electrical phase's apparent load and apprent current of the power distributable node.
    ElectricalConnectedPhases GetConnectedPhasesOnDownstream(ElementId id)
      Description: Get the electrical connected phases of the downstream node.
      @id: The downstream node id.
      Returns: The electrical connected phases of the downstream node.
    ElectricalPerPhaseData GetDemandPerPhaseResults()
      Description: Get an ElectricalPerPhaseData which contains each electrical phase's demand load and demand current of the power distributable node.
    void SetConnectedPhasesOnDownstream(ElementId id, ElectricalConnectedPhases connectedPhases)
      Description: Set the electrical connected phases of the downstream node.
      @id: The downstream node id.
      @connectedPhases: The electrical connected phases to set to the downstream node.

--------------------------------------------------------------------------------

[CLASS] AnalyticalPowerSourceData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData

Description: Represents the data and parameters of analytical power source node.
Inherits: AnalyticalPowerDistributableNodeData
Implements: IDisposable

  PROPERTIES:
    double ApparentPowerRating { get; set; }
      Description: The apparent power rating value of the analytical power source.
    double TotalConnectedCurrent { get; }
      Description: The total connected current of the analytical power source.
    double Voltage { get; set; }
      Description: The voltage value of the analytical power source.

--------------------------------------------------------------------------------

[CLASS] AnalyticalTransferSwitchData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalTransferSwitchData

Description: Represents the data and parameters of electrical analytical transfer switch.
Inherits: AnalyticalPowerDistributableNodeData
Implements: IDisposable

  PROPERTIES:
    double CurrentRating { get; set; }
      Description: The current rating value of the electrical analytical transfer switch.
    double TotalConnectedCurrent { get; }
      Description: The total connected current of the electrical analytical transfer switch.
    double Voltage { get; set; }
      Description: The voltage value of the electrical analytical transfer switch.

--------------------------------------------------------------------------------

[CLASS] AnalyticalTransformerData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalTransformerData

Description: Represents the data and parameters of analytical transformer node.
Inherits: AnalyticalPowerDistributableNodeData
Implements: IDisposable

  PROPERTIES:
    double ApparentPowerRating { get; set; }
      Description: The apparent power rating value of the analytical transformer.
    ElementId SecondaryDistributionSystem { get; set; }
      Description: The secondary distribution system of the analytical transformer.

--------------------------------------------------------------------------------

[CLASS] AreaBasedLoadBoundaryLineData
Full Name: Autodesk.Revit.DB.Electrical.AreaBasedLoadBoundaryLineData

Description: Wrapper class used to access area based load boundary line related data.
Implements: IDisposable

  PROPERTIES:
    ElementId BottomLevelId { get; set; }
      Description: The bottom level id of the area based load boundary line.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId TopLevelId { get; set; }
      Description: The top level id of the area based load boundary line.

  METHODS:
    void Dispose()
    ISet<ElementId> GetLevelIdsInRange()
      Description: Returns level ids between the top level and the bottom level (including the top level and the bottom level) of the area based load boundary line.
      Returns: The level ids between the top level and the bottom level (including the top level and the bottom level).
    bool IsElevationWithinRange(double elev)
      Description: Checks whether the given elevation is between the bottom level and the top level(including the bottom level and the top level) of the area based load boundary line.
      @elev: The elevation value.
      Returns: True if given elevation is between the bottom level elevation and the top level elevation, false otherwise.
    bool IsLevelWithinRange(ElementId levelId)
      Description: Checks whether the given level is between the bottom level and the top level (including the bottom level and the top level) of the area based load boundary line.
      @levelId: The id of the Level.
      Returns: True if given level is between the bottom level and the top level, false otherwise.

--------------------------------------------------------------------------------

[CLASS] AreaBasedLoadData
Full Name: Autodesk.Revit.DB.Electrical.AreaBasedLoadData

Description: Represents the electrical area based load data.
Inherits: ZoneElementDomainData
Implements: IDisposable

  PROPERTIES:
    double ApparentLoad { get; }
      Description: The electrical apparent load of the area based load.
    double ApparentPowerDensity { get; }
      Description: The apparent power density of the area based load.
    ElementId AreaBasedLoadType { get; set; }
      Description: The electrical area based load type of the area based load.
    ElectricalConnectedPhases ConnectedPhases { get; }
      Description: The electrical connected phases of the area based load to its upstream node.
    double Current { get; }
      Description: The current of the area based load .
    ElementId LoadClassification { get; }
      Description: The load classification of the area based load.
    double LoadDensity { get; }
      Description: The load density of the area based load.
    ElectricalLoadType LoadType { get; }
      Description: The load type of the area based load.
    int PhasesNumber { get; set; }
      Description: The number of electrical phases of the area based load.
    double PowerFactor { get; }
      Description: The power factor of the area based load.
    PowerFactorStateType PowerFactorState { get; }
      Description: The power factor state of the area based load.
    double TrueLoad { get; }
      Description: The electrical true load of the area based load.
    double Voltage { get; set; }
      Description: The voltage of the area based load.

  METHODS:
    void AddElectricalLoadArea(ElementId electricalLoadAreaId)
      Description: Adds electrical load area into the area based load.
      @electricalLoadAreaId: The electrical load area id to add.
    bool CanConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Verifies that the area based load can connect to the upstream electrical analytical node. If the area based load already has an upstream node or the upstream node is full of downstream nodes, the area based load can't connect to the upstream node.
      @upstreamNodeId: The upstream electrical analytical node id.
      Returns: True if the area based load can connect to the upstream electrical analytical node.
    bool CanDisconnectFromUpstreamNode()
      Description: Verifies that the area based load can disconnect from the upstream electrical analytical node. If the area based load hasn't an upstream node, it can't disconnect from the upstream node.
      Returns: True if the area based load can disconnect from the upstream electrical analytical node.
    void ConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Connects to an upstream electrical analytical node.
      @upstreamNodeId: The upstream electrical analytical node id.
    void DisconnectFromUpstreamNode()
      Description: Disconnects from an upstream electrical analytical node.
    ISet<ElementId> GetElectricalLoadAreas()
      Description: Gets electrical load areas which the area based load includes.
    ElementId GetUpstreamNodeId()
      Description: Gets the upstream electrical analytical node id.
      Returns: The upstream node id.
    void RemoveElectricalLoadArea(ElementId electricalLoadAreaId)
      Description: Removes electrical load area from the area based load.
      @electricalLoadAreaId: The electrical load area id to remove.

--------------------------------------------------------------------------------

[CLASS] AreaBasedLoadType
Full Name: Autodesk.Revit.DB.Electrical.AreaBasedLoadType

Description: This class represents an area based load type in Autodesk Revit.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double ApparentPowerDensity { get; set; }
      Description: The apparent power density of area based load type.
    ElementId LoadClassification { get; set; }
      Description: The load classification of area based load type.
    double LoadDensity { get; set; }
      Description: The load density of area based load type.
    double PowerFactor { get; set; }
      Description: The power factor of area based load type.
    PowerFactorStateType PowerFactorState { get; set; }
      Description: The power factor state of the area based load type.

  METHODS:
    static AreaBasedLoadType Create(Document document, string name)
      Description: Creates an area based load type.
      @document: The document in which to create the area based load type.
      @name: The name of new area based load type. The actual name may be post-fixed if already exists.
      Returns: The newly created area based load type.

--------------------------------------------------------------------------------

[CLASS] CableTray
Full Name: Autodesk.Revit.DB.Electrical.CableTray

Description: This class represents a cable tray in Autodesk Revit.
Inherits: CableTrayConduitBase
Implements: IDisposable

  PROPERTIES:
    XYZ CurveNormal { get; set; }
      Description: The up-direction vector of the cable tray.
    double RungSpace { get; set; }
      Description: Distance between two rungs for the ladder cable tray.

  METHODS:
    static CableTray Create(Document document, ElementId cabletrayType, XYZ startPoint, XYZ endPoint, ElementId levelId)
      Description: Creates a new instance of cable tray.
      @document: The document.
      @cabletrayType: The cable tray type. This must be a cable tray type accepted by isValidCableTrayType(). If the input cable tray type is InvalidElementId, the default cable tray type from the document will be used.
      @startPoint: The start point of the cable tray location line.
      @endPoint: The end point of the cable tray location line.
      @levelId: The element id of the level which this cable tray based. If the input level id is invalidElementId = -1, the nearest level will be used.
      Returns: The newly created cable tray.
    CableTrayShape GetShapeType()
      Description: Returns the shape type for the cable tray.
      Returns: The shape type.
    static bool IsValidCableTrayType(Document document, ElementId cabletrayType)
      Description: Identifies if a cable tray type is valid.
      @document: The document.
      @cabletrayType: The cable tray type.
      Returns: True if the cable tray type is valid, false otherwise.
    bool IsValidRungSpace(double rungSpace)
      Description: Identifies if the input rung space is valid.
      @rungSpace: The rung space to check.
      Returns: True if the value is acceptable, false otherwise.

--------------------------------------------------------------------------------

[CLASS] CableTrayConduitBase
Full Name: Autodesk.Revit.DB.Electrical.CableTrayConduitBase

Description: The CableTrayConduitBase class is implemented as the base class for cable tray or conduit
Inherits: MEPCurve
Implements: IDisposable

  PROPERTIES:
    ElementId RunId { get; }
      Description: The id of the run to which this element belongs.

  METHODS:
    static bool IsValidEndPoints(XYZ startPoint, XYZ endPoint)
      Description: Identifies if two end points are valid.
      @startPoint: The start point of the location line.
      @endPoint: The end point of the location line.
      Returns: True if the two end points are valid, false otherwise.
    static bool IsValidLevelId(Document document, ElementId levelId)
      Description: Identifies if a level id is valid.
      @document: The document.
      @levelId: The level id.
      Returns: True if the level id is valid, false otherwise.
    bool IsWithFitting()
      Description: Return whether its cable tray/conduit type is with fitting
      Returns: return true if its type is with fitting type.

--------------------------------------------------------------------------------

[CLASS] CableTrayConduitRunBase
Full Name: Autodesk.Revit.DB.Electrical.CableTrayConduitRunBase

Description: The base class for a cable tray or conduit run in Autodesk Revit.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double Length { get; }
      Description: The length of the whole (cable tray or conduit) run default 0.0

--------------------------------------------------------------------------------

[CLASS] CableTrayRun
Full Name: Autodesk.Revit.DB.Electrical.CableTrayRun

Description: This class represents a cable tray run in Autodesk Revit.
Remarks: This class is mainly for calculating length of a cable tray run. A cable tray run contains connected straight cable tray segments and bends between the straight segments with same type and size.
Inherits: CableTrayConduitRunBase
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] CableTraySettings
Full Name: Autodesk.Revit.DB.Electrical.CableTraySettings

Description: The cable tray settings.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string ConnectorSeparator { get; set; }
      Description: The cable tray connector separator string.
    double FittingAnnotationSize { get; set; }
      Description: The value of fitting annotation size.
    double RiseDropAnnotationSize { get; set; }
      Description: The rise drop annotation size.
    string SizeSeparator { get; set; }
      Description: The cable tray size separator string.
    string SizeSuffix { get; set; }
      Description: The cable tray size suffix string.
    bool UseAnnotationScaleForSingleLineFittings { get; set; }
      Description: Indicates whether use annotation scale for single line fittings or not.

  METHODS:
    static CableTraySettings GetCableTraySettings(Document document)
      Description: Gets the cable tray settings of the project.
      @document: The document.
      Returns: The cable tray settings of the project.

--------------------------------------------------------------------------------

[ENUM] CableTrayShape
Full Name: Autodesk.Revit.DB.Electrical.CableTrayShape

Description: Shape types enum of cable tray
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Invalid = 0
    - Channel = 1
    - Ladder = 2

[CLASS] CableTraySizeIterator
Full Name: Autodesk.Revit.DB.Electrical.CableTraySizeIterator

Description: An iterator to a set of MEP cable tray sizes from CableTraySizes.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    MEPSize Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    MEPSize GetCurrent()
      Description: Returns the current MEPSize.
      Returns: The current MEPSize.
    bool HasCurrent()
      Description: Identifies if the iterator has a current item.
      Returns: True if there is a current item.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] CableTraySizes
Full Name: Autodesk.Revit.DB.Electrical.CableTraySizes

Description: Cable tray sizes.
Inherits: Element
Implements: IDisposable, IEnumerable`1, IEnumerable

  METHODS:
    void AddSize(MEPSize sizeInfo)
      Description: Inserts a new MEPSize into the cable tray sizes. For cable tray, the nominal diameter of MEPSize is used .
      @sizeInfo: The new MEPSize to be added.
    void ClearAll()
      Description: Removes all MEPSizes in the cable tray sizes.
    bool Contains(double nominalDiameter)
      Description: Checks whether a cable tray size with the nominal diameter exists.
      @nominalDiameter: Nominal diameter.
      Returns: True if a cable tray size with the nominal diameter exists.
    static CableTraySizes GetCableTraySizes(Document aDoc)
      Description: Gets the cable tray sizes of the project.
      @aDoc: The document.
      Returns: The cable tray sizes of the project.
    CableTraySizeIterator GetCableTraySizesIterator()
      Description: Returns a CableTraySizeIterator to the MEP cable tray sizes.
    IEnumerator<MEPSize> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    int GetSizeCount()
      Description: Gets the size count of the cable tray size table.
    void RemoveSize(MEPSize sizeInfo)
      Description: Erases the existing MEPSize. For cable tray, the nominal diameter is used in MEPSize.
      @sizeInfo: The MEPSize to be removed..

--------------------------------------------------------------------------------

[CLASS] CableTrayType
Full Name: Autodesk.Revit.DB.Electrical.CableTrayType

Description: This class represents a cable tray type in Autodesk Revit.
Inherits: MEPCurveType
Implements: IDisposable

  PROPERTIES:
    double BendMultiplier { get; set; }
      Description: Bend multiplier.
    bool IsWithFitting { get; }
      Description: Whether this cable tray type is with fitting
    CableTrayShape ShapeType { get; }
      Description: Shape of this cable tray type.

  METHODS:
    bool IsValidBendMultiplier(double bendMultiplier)
      Description: Identifies if the input bend multiplier is valid.
      @bendMultiplier: The bend multiplier to check.
      Returns: True if the value is acceptable, false otherwise.

--------------------------------------------------------------------------------

[ENUM] CapitalizationForLoadNames
Full Name: Autodesk.Revit.DB.Electrical.CapitalizationForLoadNames

Description: Enumerated type listing the options for how electrical load names should be capitalized.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SourceParameters = 0
    - Initial = 1
    - Sentence = 2
    - Upper = 3

[ENUM] CircuitConnectionType
Full Name: Autodesk.Revit.DB.Electrical.CircuitConnectionType

Description: An enumerated type indicates the panel to panel connection type
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotApplicable = 0
    - Breaker = 1
    - FeedThruLugs = 2

[ENUM] CircuitLoadCalculationMethod
Full Name: Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod

Description: Methods to calculate circuit loads
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SumTrueLoadAndReactiveLoad = 0
    - SumApparentLoad = 1

[ENUM] CircuitNaming
Full Name: Autodesk.Revit.DB.Electrical.CircuitNaming

Description: An enumerated type listing all the circuit naming options.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Prefixed = 0
    - Standard = 1
    - PanelName = 2
    - Phase = 3
    - ProjectSetting = 4
    - Customized = 5
    - Undefined = -1

[CLASS] CircuitNamingScheme
Full Name: Autodesk.Revit.DB.Electrical.CircuitNamingScheme

Description: This class represents a circuit naming scheme in Autodesk Revit.
Inherits: Element
Implements: IDisposable

  METHODS:
    static CircuitNamingScheme Create(Document document, string name, IList<TableCellCombinedParameterData> data)
      Description: Creates a new CircuitNamingScheme.
      @document: The document in which to create the CircuitNamingScheme.
      @name: The name of CircuitNamingScheme.
      @data: The array of TableCellCombinedParameterData to be set as combined parameters.
      Returns: The newly created CircuitNamingScheme.
    IList<TableCellCombinedParameterData> GetCombinedParameters()
      Description: Gets the combined parameters.
      Returns: Gets array of TableCellCombinedParameterData with the combined parameters data.
    static bool IsNameUnique(Document aDocument, string name)
      Description: Validates whether the CircuitNamingScheme name is unique in document.
      @aDocument: The document in which the name is being tested for uniqueness.
      @name: The name tested for uniqueness.
      Returns: Returns true if the name is unique, and false otherwise.
    static bool IsValidCombinedParameters(Document aDocument, IList<TableCellCombinedParameterData> data)
      Description: Validates whether the combined parameters is valid.
      @aDocument: The document.
      @data: The array of TableCellCombinedParameterData to be set as combined parameters.
      Returns: Returns true if the combined parameters are valid, and false otherwise.
    void SetCombinedParameters(IList<TableCellCombinedParameterData> data)
      Description: Sets combined parameters array.
      @data: The array of TableCellCombinedParameterData to be set as combined parameters.

--------------------------------------------------------------------------------

[CLASS] CircuitNamingSchemeSettings
Full Name: Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings

Description: This class represents a circuit naming scheme settings in Autodesk Revit.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId CircuitNamingSchemeId { get; set; }
      Description: The circuit naming scheme id set in CircuitNamingSchemeSettings.

  METHODS:
    static CircuitNamingSchemeSettings GetCircuitNamingSchemeSettings(Document cda)
      Description: Gets the circuit naming scheme settings of the project.
      @cda: The document.
      Returns: The circuit naming scheme settings of the project.
    static bool IsValidCircuitNamingSchemeId(Document aDocument, ElementId circuitNamingSchemeId)
      Description: Verifies that the circuit naming scheme id can be used with CircuitNamingSchemeSettings.
      @aDocument: The document.
      @circuitNamingSchemeId: The circuit naming scheme id to be checked.
      Returns: True if the circuit naming scheme id is valid for CircuitNamingSchemeSettings.

--------------------------------------------------------------------------------

[ENUM] CircuitNumberingOption
Full Name: Autodesk.Revit.DB.Electrical.CircuitNumberingOption

Description: An enumerated type listing all the circuit numbering options.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Default = 0
    - Continuous = 1

[ENUM] CircuitSequence
Full Name: Autodesk.Revit.DB.Electrical.CircuitSequence

Description: Options of circuit sequence for assigning circuit to circuits across panel.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Numerical = 0
    - GroupByPhase = 1
    - OddThenEven = 2

[ENUM] CircuitType
Full Name: Autodesk.Revit.DB.Electrical.CircuitType

Description: An enumerated type listing all the possible circuit types.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Circuit = 0
    - Spare = 1
    - Space = 2

[CLASS] Conduit
Full Name: Autodesk.Revit.DB.Electrical.Conduit

Description: This class represents a conduit in Autodesk Revit.
Inherits: CableTrayConduitBase
Implements: IDisposable

  METHODS:
    static Conduit Create(Document document, ElementId conduitType, XYZ startPoint, XYZ endPoint, ElementId levelId)
      Description: Creates a new instance of conduit.
      @document: The document.
      @conduitType: The conduit type. This must be a conduit type accepted by isValidConduitType(). If the input conduit type is InvalidElementId, the default conduit type from the document will be used.
      @startPoint: The start point of the conduit location line.
      @endPoint: The end point of the conduit location line.
      @levelId: The element id of the level which this conduit based. If the input level id is invalidElementId = -1, the nearest level will be used.
      Returns: The newly created conduit.
    static bool IsValidConduitType(Document document, ElementId conduitType)
      Description: Identifies if a conduit type is valid.
      @document: The document.
      @conduitType: The conduit type.
      Returns: True if the conduit type is valid, false otherwise.

--------------------------------------------------------------------------------

[CLASS] ConduitRun
Full Name: Autodesk.Revit.DB.Electrical.ConduitRun

Description: This class represents a conduit run in Autodesk Revit.
Remarks: This class is mainly for calculating length of a conduit run. A conduit run contains connected straight conduit segments and bends between the straight segments with same type and size.
Inherits: CableTrayConduitRunBase
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] ConduitSettings
Full Name: Autodesk.Revit.DB.Electrical.ConduitSettings

Description: The conduit settings.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string ConnectorSeparator { get; set; }
      Description: The conduit connector separator string.
    double FittingAnnotationSize { get; set; }
      Description: The value of fitting annotation size.
    double RiseDropAnnotationSize { get; set; }
      Description: The rise drop annotation size.
    string SizePrefix { get; set; }
      Description: The conduit size prefix string.
    string SizeSuffix { get; set; }
      Description: The conduit size suffix string.
    bool UseAnnotationScaleForSingleLineFittings { get; set; }
      Description: Indicates whether use annotation scale for single line fittings or not.

  METHODS:
    static ConduitSettings GetConduitSettings(Document document)
      Description: Gets the conduit settings of the project.
      @document: The document.
      Returns: The conduit settings of the project.

--------------------------------------------------------------------------------

[CLASS] ConduitSize
Full Name: Autodesk.Revit.DB.Electrical.ConduitSize

Description: Stores the basic size information for a conduit.
Implements: IDisposable

  CONSTRUCTORS:
    new ConduitSize(double nominalDiameter, double innerDiameter, double outerDiameter, double bendRadius, bool usedInSizeLists, bool usedInSizing)

  PROPERTIES:
    double BendRadius { get; }
      Description: Minimum bend radius
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

[CLASS] ConduitSizeIterator
Full Name: Autodesk.Revit.DB.Electrical.ConduitSizeIterator

Description: An iterator to a set of conduit sizes from ConduitSizes.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    ConduitSize Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ConduitSize GetCurrent()
      Description: Returns the current ConduitSize.
      Returns: The current ConduitSize.
    bool HasCurrent()
      Description: Identifies if the iterator has a current item.
      Returns: True if there is a current item.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] ConduitSizes
Full Name: Autodesk.Revit.DB.Electrical.ConduitSizes

Description: Class ConduitSizeSet being used to store the conduit sizes.
Implements: IEnumerable`1, IEnumerable, IDisposable

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool Contains(double nominalDiameter)
      Description: Checks whether a conduit size with the nominal diameter exists.
      @nominalDiameter: Nominal diameter.
      Returns: True if a conduit size with the nominal diameter exists.
    void Dispose()
    ConduitSizeIterator GetConduitSizesIterator()
      Description: Returns a ConduitSizeIterator to the conduit sizes.
    IEnumerator<ConduitSize> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.

--------------------------------------------------------------------------------

[CLASS] ConduitSizeSettingIterator
Full Name: Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator

Description: An iterator to a set of items from ConduitSizeSettings. Each item is a KeyValuePair(System::String^, ConduitSizes). ElementId is the id of the conduit standard type.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<string, ConduitSizes> Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool HasCurrent()
      Description: Identifies whether the iterator has a current item. There is no current item if the iterator has not started yet or has been done.
      Returns: True if there is a current item.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the enumerator to the next item.
      Returns: True if there is a next available item in this enumerator. False if the enumerator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] ConduitSizeSettings
Full Name: Autodesk.Revit.DB.Electrical.ConduitSizeSettings

Description: Conduit sizes settings
Inherits: Element
Implements: IDisposable, IEnumerable`1, IEnumerable

  METHODS:
    void AddSize(string standardName, ConduitSize sizeInfo)
      Description: Inserts a new ConduitSize in to the conduit size settings. The conduit standard name determines the location of the new size in the size table.
      @standardName: The conduit standard name.
      @sizeInfo: The new ConduitSize to be added.
    bool CreateConduitStandardTypeFromExisingStandardType(Document pADoc, string newStandardName, string existingStandardName)
      Description: Creates one conduit standard type with the new name and assign the conduit sizes to it from the existing standard type.
      @pADoc: The document.
      @newStandardName: The new conduit standard name.
      @existingStandardName: The existing conduit standard name.
      Returns: True if creating success; otherwise false.
    bool DoesConduitStandardTypeExist(string standardName)
      Description: Checks if the specified conduit standard exist.
      @standardName: The conduit standard name.
    static ConduitSizeSettings GetConduitSizeSettings(Document aDoc)
      Description: Gets the conduit size settings of the project.
      @aDoc: The document.
      Returns: The conduit size settings of the project.
    ConduitSizeSettingIterator GetConduitSizeSettingsIterator()
      Description: Returns a ConduitSizeSettingIterator to the conduit size settings.
    IEnumerator<KeyValuePair<string, ConduitSizes>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    int GetSizeCount(string standardName)
      Description: Gets the size count of the conduit size table. The conduit standard name the location of the size in the size table.
      @standardName: The conduit standard name.
    bool RemoveConduitStandardType(Document pADoc, string standardName)
      Description: Erases the existing ConduitSizes with this conduit standard name; the consuit standard type can not be removed if it is in use.
      @pADoc: The document.
      @standardName: The conduit standard name.
      Returns: True if removing success; otherwise false.
    void RemoveSize(string standardName, double nominalDiameter)
      Description: Erase the existing ConduitSize with this nominal diameter. The conduit standard name determines the location of the size in the size table.
      @standardName: The conduit standard name.
      @nominalDiameter: Nominal diameter.

--------------------------------------------------------------------------------

[CLASS] ConduitType
Full Name: Autodesk.Revit.DB.Electrical.ConduitType

Description: This class represents a conduit type in Autodesk Revit.
Inherits: MEPCurveType
Implements: IDisposable

  PROPERTIES:
    bool IsWithFitting { get; }
      Description: Whether this conduit type is with fitting

--------------------------------------------------------------------------------

[CLASS] CorrectionFactor
Full Name: Autodesk.Revit.DB.Electrical.CorrectionFactor

Description: Represents electrical correction factor information.
Remarks: Correction factor is defined based on corresponding wire material type and temperature rating type.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    double Factor { get; }
      Description: Get factor value of wire correction factor.

  METHODS:
    double GetTemperature()
      Description: Get temperature which is used for specifying correction factor. The value returned is quantified in the document's selected unit of electrical temperature.

--------------------------------------------------------------------------------

[CLASS] CorrectionFactorSet
Full Name: Autodesk.Revit.DB.Electrical.CorrectionFactorSet

Description: A set that contains correction factors.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new CorrectionFactorSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of correction factors that are in the set.

  METHODS:
    void Clear()
      Description: Removes every correction factor from the set, rendering it empty.
    bool Contains(CorrectionFactor item)
    int Erase(CorrectionFactor item)
    CorrectionFactorSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(CorrectionFactor item)
    CorrectionFactorSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CorrectionFactorSetIterator
Full Name: Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator

Description: An iterator to a correction factor set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new CorrectionFactorSetIterator()

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

[CLASS] DistributionSysType
Full Name: Autodesk.Revit.DB.Electrical.DistributionSysType

Description: Represents a specific type of distribution system.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    ElectricalPhase ElectricalPhase { get; set; }
      Description: Get or set electrical phase (single, triple or undefined) of distribution system.
    ElectricalPhaseConfiguration ElectricalPhaseConfiguration { get; set; }
      Description: Get or set electrical phase configuration (Y, delta or undefined) of distribution system.
    ElectricalPhaseLine HighLegPhase { get; set; }
      Description: The high-leg phase in the 3 phase 4 wires delta distribution system.
    bool IsInUse { get; }
      Description: Get the value which indicates whether this distribution system is in service now.
    int NumWires { get; set; }
      Description: Get or set number of wires of distribution system.
    VoltageType VoltageLineToGround { get; set; }
      Description: Get or set line to ground voltage of distribution system type.
    VoltageType VoltageLineToLine { get; set; }
      Description: Get or set line to line voltage type of distribution system type.

--------------------------------------------------------------------------------

[CLASS] DistributionSysTypeSet
Full Name: Autodesk.Revit.DB.Electrical.DistributionSysTypeSet

Description: A set that contains DistributionSys types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new DistributionSysTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of DistributionSys types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every DistributionSys type from the set, rendering it empty.
    bool Contains(DistributionSysType item)
      Description: Tests for the existence of a DistributionSys type within the set.
      @item: The DistributionSys type to be searched for.
      Returns: The Contains method returns True if the DistributionSys type is within the set, otherwise False.
    int Erase(DistributionSysType item)
      Description: Removes a specified DistributionSys type from the set.
      @item: The DistributionSys type to be erased.
      Returns: The number of DistributionSys types that were erased from the set.
    DistributionSysTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(DistributionSysType item)
      Description: Insert the specified DistributionSys type into the set.
      @item: The DistributionSys type to be inserted into the set.
      Returns: Returns whether the DistributionSys type was inserted into the set.
    DistributionSysTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] DistributionSysTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator

Description: An iterator to a DistributionSys type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new DistributionSysTypeSetIterator()

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

[CLASS] ElectricalAnalyticalLoadSet
Full Name: Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet

Description: Represents the electrical analytical load set, it can contain a set of Electrical Analytical Equipment Loads.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    int QuantityOnStandBy { get; set; }
      Description: The number of Equipment Loads that are not operational at any time.
    int TotalQuantity { get; }
      Description: The total count of the Equipment Loads in the LoadSet.

  METHODS:
    static ElectricalAnalyticalLoadSet Create(Document document, string name)
      Description: Creates an electrical analytical load set.
      @document: The document where the new element will be created.
      @name: The name of new electrical analytical load set. The actual name may be post-fixed if already exists.
      Returns: The newly created electrical analytical loadset.
    ISet<ElementId> GetLoadIds()
      Description: Gets Equipment Load ids in the LoadSet.
      Returns: The Equipment Load ids.

--------------------------------------------------------------------------------

[CLASS] ElectricalAnalyticalNode
Full Name: Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode

Description: Represents an electrical analytical node under the Analytical Power Distribution in the System Browser.
Remarks: This represents one of any number of types, as specified by the ElectricalAnalyticalNodeType. Some of those types will have AnalyticalDistributionNodePropertyData while others will not, and if they do have data they can be downcast to a specific subclass of data to be used.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElectricalAnalyticalNodeType NodeType { get; }
      Description: The type of electrical analytical node.
    double TotalLoad { get; }
      Description: The Total Connected Load.

  METHODS:
    bool CanConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Verifies that the current node can connect to the upstream node.
      @upstreamNodeId: The upstream node id.
      Returns: True if the current node can connect to the upstream node.
    bool CanDisconnectFromUpstreamNode(ElementId upstreamNodeId)
      Description: Verifies that the current node can disconnect from the upstream node.
      @upstreamNodeId: The upstream node id.
      Returns: True if the current node can disconnect from the upstream node.
    void ConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Connects to upstream node.
      @upstreamNodeId: The upstream node id.
    static ElectricalAnalyticalNode Create(Document document, ElectricalAnalyticalNodeType type, string name)
      Description: Creates an electrical analytical node.
      @document: The document where the new element will be created.
      @type: The type of electrical analytical node to be created.
      @name: The name of new electrical analytical node. The actual name may be post-fixed if already exists.
      Returns: The newly created electrical analytical node.
    void DisconnectFromUpstreamNode(ElementId upstreamNodeId)
      Description: Disconnects from upstream node.
      @upstreamNodeId: The upstream node id to disconnect from.
    ISet<ElementId> GetAllDownstreamLoadIds()
      Description: Get all the descendant Electrical Analytical Load ids of the node.
    AnalyticalDistributionNodePropertyData GetAnalyticalPropertyData()
      Description: Gets the electrical analytical node property data, if not available.
      Returns: The electrical analytical node property data.
    IList<ElementId> GetDownstreamNodeIds()
      Description: Gets the downstream node ids.
      Returns: The array of downstream node ids.
    IList<ElementId> GetUpstreamNodeIds()
      Description: Gets upstream node ids.
      Returns: The array of upstream node ids.

--------------------------------------------------------------------------------

[ENUM] ElectricalAnalyticalNodeType
Full Name: Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType

Description: The type of electrical analytical node.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - PowerSource = 0
    - Bus = 1
    - Transformer = 2
    - TransferSwitch = 3
    - EquipmentLoad = 4

[ENUM] ElectricalCircuitPathMode
Full Name: Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode

Description: An enumerated type indicates the circuit path mode
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Custom = 0
    - FarthestDevice = 1
    - AllDevices = 2

[ENUM] ElectricalConnectedPhases
Full Name: Autodesk.Revit.DB.Electrical.ElectricalConnectedPhases

Description: The electrical connected phases of an electrical analytical node.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AN = 0
    - BN = 1
    - CN = 2
    - AB = 3
    - BC = 4
    - CA = 5
    - ABN = 6
    - BCN = 7
    - CAN = 8
    - ABC = 9
    - ABCN = 10
    - Invalid = -1

[CLASS] ElectricalDemandFactorDefinition
Full Name: Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition

Description: The ElectricalDemandFactorDef class represents a serialized version of an instance of demand factor definition. It has a name, rule type, and values for the rules that are serialized.
Inherits: Element
Implements: IDisposable

  CONSTRUCTORS:
    new ElectricalDemandFactorDefinition()

  PROPERTIES:
    double AdditionalLoad { get; set; }
      Description: Additional load to be included during demand load calculation.
    bool IncludeAdditionalLoad { get; set; }
      Description: Should the additional load (if set) be included in demand load calculations.
    ElectricalDemandFactorRule RuleType { get; set; }
      Description: The rule type for this demand factor definition.

  METHODS:
    void AddValue(ElectricalDemandFactorValue dfValue)
      Description: Adds a value to the value set for this demand factor definition
      @dfValue: Value to add to the set
    void ClearValues()
      Description: Clears all the values stored for this demand factor definition.
    static ElectricalDemandFactorDefinition Create(Document ADoc, string strName)
      Description: Creates a new instance of a demand factor definition.
      @ADoc: The document where the element will be created and added.
      @strName: The name of the electrical demand factor definition to be created.
      Returns: The newly created demand factor definition element.
    double GetApplicableDemandFactor(double numberOrLoad)
      Description: This method will return the applicable demand factor for the specified number of devices or load.
      @numberOrLoad: The number of devices or load for which the demand factor should be looked up.
      Returns: The applicable demand factor.
    ICollection<ElectricalDemandFactorValue> GetValues()
      Description: Provides access to the value set stored with this demand factor definition
    int GetValuesCount()
      Description: Returns the number of values in the set.
    void RemoveValue(ElectricalDemandFactorValue dfValue)
      Description: Removes a value to the value set for this demand factor definition
      @dfValue: Value to remove from the set
    void SetValues(ICollection<ElectricalDemandFactorValue> values)
      Description: Sets the value set to the demand factor definition.

--------------------------------------------------------------------------------

[ENUM] ElectricalDemandFactorRule
Full Name: Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule

Description: This enum describes the different demand factor rule types available to the application. Within a demand factor a rule will be referenced and the user will have to enter values corresponding to that rule.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Constant = 0
    - QuantityTable = 1
    - LoadTable = 2
    - QuantityTablePerPortion = 3
    - LoadTablePerPortion = 4

[CLASS] ElectricalDemandFactorValue
Full Name: Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue

Description: This class represents values used by a particular demand factor definition. Each instance corresponds to a row in a table of values. These values are part of the ElectricalDemandFactorDefinition class.
Implements: IDisposable

  CONSTRUCTORS:
    new ElectricalDemandFactorValue(double minRange, double maxRange, double factor)
    new ElectricalDemandFactorValue()

  PROPERTIES:
    double Factor { get; set; }
      Description: The demand factor for this demand factor value. For example, objects 1 to 3 can have 100% demand factor. In the example above, the demand factor will be 1.0.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MaxRange { get; set; }
      Description: The maximum range for this demand factor value. For example, objects 1 to 3 can have 100% demand factor. In the example above, the maximum range will be 3.
    double MinRange { get; set; }
      Description: The minimum range for this demand factor value. For example, objects 1 to 3 can have 100% demand factor. In the example above, the minimum range will be 1.

  METHODS:
    void Dispose()
    void SetMaxRangeToUnlimited()
      Description: Sets the max range on the value to unlimited

--------------------------------------------------------------------------------

[CLASS] ElectricalEquipment
Full Name: Autodesk.Revit.DB.Electrical.ElectricalEquipment

Description: Provides access to the Electrical Equipment in Autodesk Revit.
Inherits: MEPModel
Implements: IDisposable

  PROPERTIES:
    ElementId CircuitNamingSchemeId { get; set; }
      Description: The CircuitNamingSchemeId used in the Electrical Equipment. The CircuitNamingSchemeId is used to retrieve the circuit naming scheme id of the Electrical Equipment.
    DistributionSysType DistributionSystem { get; set; }
      Description: get or set the Distribution System for the Electrical Equipment.
    bool IsSwitchboard { get; }
      Description: The electrical equipment is a switchboard or not. This property returns true if the electrical equipment is a switchboard.
    int MaxNumberOfCircuits { get; set; }
      Description: The maximum number of circuits for switchboard. The quantity of circuits can be assigned to switchboard through breaker.

  METHODS:
    CircuitNaming GetCircuitNamingSchemeType()
      Description: Gets enumerated type of the circuit naming scheme used with Electrical Equipment.
      Returns: The enumerated type of circuit naming scheme.
    static bool IsValidCircuitNamingSchemeId(Document aDocument, ElementId circuitNamingSchemeId)
      Description: Verifies that the circuit naming scheme id can be used with Electrical Equipment.
      @aDocument: The document.
      @circuitNamingSchemeId: The circuit naming scheme id to be checked.
      Returns: True if the circuit naming scheme id is valid for Electrical Equipment.
    bool IsValidDistributionSystem(DistributionSysType distributionSystem)
      Description: Verifies that the Distribution System can be assigned to the Electrical Equipment.
      @distributionSystem: The Distribution System to be checked.
      Returns: True if the Distribution System can be assigned to the Electrical Equipment.
    void SetCircuitNamingSchemeType(CircuitNaming circuitNamingType)
      Description: Sets the circuit naming scheme for Electrical Equipment.
      @circuitNamingType: The enumerated type of circuit naming scheme to be set.

--------------------------------------------------------------------------------

[CLASS] ElectricalLoadAreaData
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData

Description: Represents the electrical load area data.
Inherits: SpatialElementDomainData
Implements: IDisposable

  METHODS:
    static ISet<ElementId> CreateElectricalLoadAreas(Document doc, ElementId levelId, ElementId phaseId)
      Description: Creates electrical load areas on all the empty plan circuits of the given level.
      @doc: The document where the created electrical load areas are.
      @levelId: The base level on which the created electrical load areas exist.
      @phaseId: The associated phase in which the created electrical load areas exist.
      Returns: The created electrical load areas.
    ISet<ElementId> GetAreaBasedLoadIds()
      Description: Gets the area based load ids of the electrical load area to be included.
    static bool HasCircuitsWithoutElectricalLoadAreas(Document doc, ElementId levelId, ElementId phaseId)
      Description: Checks whether there are any empty plan circuits in which there are no electrical load areas.
      @doc: The document to check.
      @levelId: The base level on which the empty plan circuits to check.
      @phaseId: The associated phase in which the empty plan circuits to check.
      Returns: True if there are empty plan circuits in which there are no electrical load areas, false otherwise.

--------------------------------------------------------------------------------

[CLASS] ElectricalLoadClassification
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadClassification

Description: The ElectricalLoadClassification class represents a serialized version of an instance of load classification.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string Abbreviation { get; set; }
      Description: The abbreviation of the load classification name
    string ActualElectricalLoadLabel { get; set; }
      Description: The name template for the actual load parameter on the load classification.
    ElementId DemandFactorId { get; set; }
      Description: The demand factor definition this load classification element uses.
    string LoadSummaryDemandFactorLabel { get; set; }
      Description: The name template for the demand factor parameter of the load classification.
    bool Motor { get; }
      Description: Indicates if this load classification is to be used for motors.
    bool Other { get; }
      Description: Indicates if it is the default load classification, and its name is Other.
    string PanelConnectedCurrentLabel { get; set; }
      Description: The name template for the connected current parameter on the load classification.
    string PanelConnectedLabel { get; set; }
      Description: The name template for the connected load parameter of the load classification.
    string PanelEstimatedCurrentLabel { get; set; }
      Description: The name template for the estimated current parameter on the load classification.
    string PanelEstimatedLabel { get; set; }
      Description: The name template for the estimated demand parameter on the load classification.
    ElectricalLoadClassificationSpace SpaceLoadClass { get; set; }
      Description: The electrical load class associated with a space.
    bool Spare { get; }
      Description: Indicates if this load classification is to be used for spare.

  METHODS:
    static ElectricalLoadClassification Create(Document ADoc, string strName)
      Description: Creates a new instance of load classification and adds it to the document.
      @ADoc: The document where the element will be created and added.
      @strName: The name of the electrical load classification to be created.
      Returns: The newly created load classification element.

--------------------------------------------------------------------------------

[ENUM] ElectricalLoadClassificationData
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationData

Description: This enum is used by the ElectricalLoadClassification class as additional data whenever data members changed. It is used as the additional data when the atom corresponding to each data member is touched.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Name = 0
    - SpaceLoadClass = 1
    - DemandFactor = 2
    - LoadSummaryDemandFactorLabel = 3
    - PanelConnectedLabel = 4
    - PanelEstimatedLabel = 5
    - PanelConnectedCurrentLabel = 6
    - PanelEstimatedCurrentLabel = 7
    - ActualElecLoadNameLabel = 8
    - Abbreviation = 9

[ENUM] ElectricalLoadClassificationSpace
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationSpace

Description: This enum is used by the ElectricalLoadClassification to specify the load class for use with spaces.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Lighting = 1
    - Power = 2

[ENUM] ElectricalLoadType
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadType

Description: Represents the electrical load type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - EquipmentLoad = 0
    - AreaBasedLoad = 1

[CLASS] ElectricalPerPhaseData
Full Name: Autodesk.Revit.DB.Electrical.ElectricalPerPhaseData

Description: This class represents per phase values including current and load.
Implements: IDisposable

  PROPERTIES:
    double CurrentPhaseA { get; }
      Description: The value of current on electrical phase A.
    double CurrentPhaseB { get; }
      Description: The value of current on electrical phase B.
    double CurrentPhaseC { get; }
      Description: The value of current on electrical phase C.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ElectricalPhase
Full Name: Autodesk.Revit.DB.Electrical.ElectricalPhase

Description: An enumerated type to specify whether the electrical system is single phase or three phase.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SinglePhase = 0
    - ThreePhase = 1

[ENUM] ElectricalPhaseConfiguration
Full Name: Autodesk.Revit.DB.Electrical.ElectricalPhaseConfiguration

Description: An enumerated type to specify the electrical phase configuration.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Wye = 1
    - Delta = 2

[ENUM] ElectricalPhaseLine
Full Name: Autodesk.Revit.DB.Electrical.ElectricalPhaseLine

Description: This attribute defines the electrical phase.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - A = 0
    - B = 1
    - C = 2
    - Invalid = -1

[CLASS] ElectricalSetting
Full Name: Autodesk.Revit.DB.Electrical.ElectricalSetting

Description: The ElectricalSetting class represents an instance of element of electrical settings.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    CircuitLoadCalculationMethod CircuitLoadCalculationMethod { get; set; }
      Description: The method to calculate circuit load
    string CircuitNamePhaseA { get; set; }
      Description: Circuit Naming by Phase - Phase A Label.
    string CircuitNamePhaseB { get; set; }
      Description: Circuit Naming by Phase - Phase B Label.
    string CircuitNamePhaseC { get; set; }
      Description: Circuit Naming by Phase - Phase C Label.
    double CircuitPathOffset { get; set; }
      Description: The default circuit path offset for newly created circuit.
    double CircuitRating { get; set; }
      Description: The default circuit rating for newly created circuit.
    CircuitSequence CircuitSequence { get; set; }
      Description: The sequence in which power circuits are created.
    DistributionSysTypeSet DistributionSysTypes { get; }
      Description: Get all distribution system types of the project.
    VoltageTypeSet VoltageTypes { get; }
      Description: Get all voltage type definitions information of the project.
    WireConduitTypeSet WireConduitTypes { get; }
      Description: Get electrical conduit types information of the project.
    WireMaterialTypeSet WireMaterialTypes { get; }
      Description: Get electrical wire material types information of the project.
    WireTypeSet WireTypes { get; }
      Description: Get all wire type definition information of the project.

  METHODS:
    DistributionSysType AddDistributionSysType(string name, ElectricalPhase phase, ElectricalPhaseConfiguration phaseConfig, int numWire, VoltageType volLineToLine, VoltageType volLineToGround)
      Description: Add a new distribution system type to project.
      @name: The name of new added distribution system type
      @phase: Single or three phase this type is
      @phaseConfig: Configuration property of given phase
      @numWire: Wire number of this distribution system
      @volLineToLine: Type of line to line voltage in this system
      @volLineToGround: Type of line to ground voltage in this system
      Returns: New added distribution system type object.
    VoltageType AddVoltageType(string name, double actualValue, double minValue, double maxValue)
      Description: Add a new type definition of voltage into project.
      @name: Specify voltage type name
      @actualValue: Specify actual value of voltage type.
      @minValue: Specify acceptable minimum value of the voltage type.
      @maxValue: Specify acceptable maximum value of the voltage type.
      Returns: New added voltage type object.
    WireMaterialType AddWireMaterialType(string name, WireMaterialType baseMaterial)
      Description: Add a new type of wire material.
      @name: Name of new material type.
      @baseMaterial: Specify an existing material type which New material will be constructed based on.
      Returns: New added wire material type object.
    WireType AddWireType(string name, WireMaterialType materialType, TemperatureRatingType temperatureRating, InsulationType insulation, WireSize maxSize, double neutralMultiplier, bool neutralRequired, NeutralMode neutralMode, WireConduitType conduit)
      Description: Add a new wire type to project.
      @name: Name of the new wire type.
      @materialType: Wire material of new wire type.
      @temperatureRating: Temperature rating type information of new wire type.
      @insulation: Insulation of new wire type.
      @maxSize: Max wire size of new wire type.
      @neutralMultiplier: Neutral multiplier of new wire type.
      @neutralRequired: Specify whether neutral point is required.
      @neutralMode: Specify neutral mode.
      @conduit: Conduit type of new wire type.
      Returns: New added wire type object.
    static CircuitNamingSchemeSettings GetCircuitNamingSchemeSettings(Document cda)
      Description: Gets the circuit naming scheme settings of the project.
      @cda: The document.
      Returns: The circuit naming scheme settings of the project.
    static ElectricalSetting GetElectricalSettings(Document document)
      Description: Get the electrical settings of the project.
      @document: The document.
      Returns: The electrical settings of the project.
    IList<double> GetSpecificFittingAngles()
      Description: Gets the list of specific fitting angles.
      Returns: Angles (in degrees).
    bool GetSpecificFittingAngleStatus(double angle)
      Description: Gets the status of given specific fitting angle.
      @angle: The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.
    bool IsValidSpecificFittingAngle(double angle)
      Description: Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      @angle: The angle value (in degree).
      Returns: True if the given value is a valid specific fitting angle.
    void RemoveDistributionSysType(DistributionSysType distributionSysType)
      Description: Remove an existing distribution system type from the project.
    void RemoveVoltageType(VoltageType voltageType)
      Description: Remove the voltage type from project.
      @voltageType: Specify the voltage type to be removed.
    void RemoveWireMaterialType(WireMaterialType materialType)
      Description: Remove the wire material type from project.
      @materialType: The wire material type to be removed.
    void RemoveWireType(WireType wireType)
      Description: Remove wire type definition from project.
    void SetSpecificFittingAngleStatus(double angle, bool bStatus)
      Description: Sets the status of given specific angle.
      @angle: The specific angle (in degree) that must be 60, 45, 30, 22.5 or 11.25 degrees.
      @bStatus: Status, true - using the given angle during the pipe layout.

--------------------------------------------------------------------------------

[CLASS] ElectricalSystem
Full Name: Autodesk.Revit.DB.Electrical.ElectricalSystem

Description: Provides access to the Electrical System in Autodesk Revit MEP.
Remarks: The Electrical System object can only be queried in Autodesk Revit MEP.
Inherits: MEPSystem
Implements: IDisposable

  PROPERTIES:
    double ApparentCurrent { get; }
      Description: The ApparentCurrent value of the Electrical System.
    double ApparentCurrentPhaseA { get; }
      Description: The ApparentCurrentPhaseA value of the Electrical System.
    double ApparentCurrentPhaseB { get; }
      Description: The ApparentCurrentPhaseB value of the Electrical System.
    double ApparentCurrentPhaseC { get; }
      Description: The ApparentCurrentPhaseC value of the Electrical System.
    double ApparentLoad { get; }
      Description: The ApparentLoad value of the Electrical System.
    double ApparentLoadPhaseA { get; }
      Description: The ApparentLoadPhaseA value of the Electrical System.
    double ApparentLoadPhaseB { get; }
      Description: The ApparentLoadPhaseB value of the Electrical System.
    double ApparentLoadPhaseC { get; }
      Description: The ApparentLoadPhaseC value of the Electrical System.
    bool BalancedLoad { get; }
      Description: Reports whether the BalancedLoad is on or off.
    CircuitConnectionType CircuitConnectionType { get; set; }
      Description: The circuit connection type of the electrical system.
    int CircuitNamingIndex { get; }
      Description: The Circuit Naming Index where the Electrical System is located in its panel. The Circuit Naming Index is used to retrieve the Circuit Naming Index of the Electrical System.
    string CircuitNumber { get; }
      Description: The CircuitNumber of the Electrical System.
    ElectricalCircuitPathMode CircuitPathMode { get; set; }
      Description: The circuit path mode of the electrical system.
    CircuitType CircuitType { get; }
      Description: The circuit type of the Electrical System.
    double Frame { get; set; }
      Description: The Frame value of the Electrical System.
    int GroundConductorsNumber { get; }
      Description: The GroundConductors Number of the Electrical System.
    bool HasCustomCircuitPath { get; }
      Description: Checks whether the electrical system circuit path has been customized. If not, the property CircuitPathMode cannot be set as Custom explicitly.
    bool HasPathOffset { get; }
      Description: Whether the circuit path has a valid offset.
    int HotConductorsNumber { get; }
      Description: The HotConductors Number of the Electrical System.
    bool IsBasePanelFeedThroughLugsOccupied { get; }
      Description: Checks if the feed through lugs of the base panel is already occupied.
    double Length { get; }
      Description: The Length value of the Electrical System.
    string LoadClassificationAbbreviations { get; }
      Description: The LoadClassification Abbreviations used in the Electrical System.
    string LoadClassifications { get; }
      Description: The LoadClassifications used in the Electrical System.
    string LoadName { get; set; }
      Description: The LoadName of the Electrical System.
    int NeutralConductorsNumber { get; set; }
      Description: The NeutralConductors Number of the Electrical System.
    string PanelName { get; }
      Description: The Panel name of the Electrical System.
    double PathOffset { get; set; }
      Description: The offset of the horizontal segments of the circuit path.
    string PhaseLabel { get; }
      Description: The circuit phase label used in the Electrical System.
    int PolesNumber { get; }
      Description: The Poles Number of the Electrical System.
    double PowerFactor { get; }
      Description: The PowerFactor value of the Electrical System.
    PowerFactorStateType PowerFactorState { get; }
      Description: The PowerFactorState type of the Electrical System.
    double Rating { get; set; }
      Description: The Rating value of the Electrical System.
    int RunsNumber { get; }
      Description: The Runs Number of the Electrical System.
    string SlotIndex { get; }
      Description: The Slots where the Electrical System is located in its panel.
    int StartSlot { get; }
      Description: The Start Slot where the Electrical System is located in its panel.
    ElectricalSystemType SystemType { get; }
      Description: The Electrical System Type of the Electrical System.
    double TrueCurrent { get; }
      Description: The TrueCurrent value of the Electrical System.
    double TrueCurrentPhaseA { get; }
      Description: The TrueCurrentPhaseA value of the Electrical System.
    double TrueCurrentPhaseB { get; }
      Description: The TrueCurrentPhaseB value of the Electrical System.
    double TrueCurrentPhaseC { get; }
      Description: The TrueCurrentPhaseC value of the Electrical System.
    double TrueLoad { get; set; }
      Description: The TrueLoad value of the Electrical System.
    double TrueLoadPhaseA { get; }
      Description: The TrueLoadPhaseA value of the Electrical System.
    double TrueLoadPhaseB { get; }
      Description: The TrueLoadPhaseB value of the Electrical System.
    double TrueLoadPhaseC { get; }
      Description: The TrueLoadPhaseC value of the Electrical System.
    double Voltage { get; }
      Description: The Voltage value of the Electrical System.
    double VoltageDrop { get; }
      Description: The VoltageDrop value of the Electrical System.
    int Ways { get; }
      Description: The circuit ways used in the Electrical System.
    string WireSizeString { get; }
      Description: The WireSize as a String of the Electrical System
    WireType WireType { get; set; }
      Description: The wire type of the Electrical System.

  METHODS:
    bool AddToCircuit(ElementSet components)
      Description: Add a set of exist components to the Electrical System.
      @components: The components added to the electrical system.
      Returns: If successful, all the components will add to the system. Otherwise is returned.
    static ElectricalSystem Create(Connector connector, ElectricalSystemType elecSysType)
      Description: Creates a new MEP Electrical System element from an unused Connector.
      @connector: The Connector to create this Electrical System.
      @elecSysType: The System Type of electrical system.
      Returns: If successful a new MEP Electrical System element within the project, otherwise .
    static ElectricalSystem Create(Document document, IList<ElementId> electComponents, ElectricalSystemType elecSysType)
      Description: Creates a new MEP Electrical System element from a set of electrical components.
      @document: The Document.
      @electComponents: The electrical components in this system.
      @elecSysType: The System Type of electrical system.
      Returns: If successful a new MEP Electrical System element within the project, otherwise .
    void DisconnectPanel()
      Description: Disconnect the panel for the Electrical System.
    IList<XYZ> GetCircuitPath()
      Description: Gets the list of the electrical system circuit path node position.
      Returns: The list of the electrical system circuit path node position.
    bool IsCircuitPathValid(IList<XYZ> nodes)
      Description: Checks whether the list of the electrical system circuit path node position is valid.
      @nodes: The list of the electrical system circuit path node position.
    WireSet NewWires(View view, WiringType wiringType)
      Description: Create a bunch of wires for the electrical system.
      @view: The view in which the wire is to be visible.
      @wiringType: Specify the wiring type (Arc or Chamfer) that is to be applied to all newly created wires.
      Returns: New created wires
    void RemoveFromCircuit(ElementSet components)
      Description: remove a set of exist components from the Electrical System.
      @components: The components removed from the electrical system.
    void SelectPanel(FamilyInstance panel)
      Description: Set the panel for the Electrical System.
      @panel: The panel of the electrical system.
    void SetCircuitPath(IList<XYZ> nodes)
      Description: Sets the electrical system circuit path by the list of node position.
      @nodes: The list of the circuit path node position.

--------------------------------------------------------------------------------

[ENUM] ElectricalSystemType
Full Name: Autodesk.Revit.DB.Electrical.ElectricalSystemType

Description: An enumerated type listing all the possible electrical system types for a connector object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UndefinedSystemType = 0
    - Data = 5
    - PowerCircuit = 6
    - Telephone = 9
    - Security = 10
    - FireAlarm = 11
    - NurseCall = 12
    - Controls = 13
    - Communication = 14
    - PowerBalanced = 30
    - PowerUnBalanced = 31

[CLASS] GroundConductorSize
Full Name: Autodesk.Revit.DB.Electrical.GroundConductorSize

Description: Represents electrical ground conductor size definition information.
Remarks: Ground conductor size is defined based on corresponding wire material type.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    long Ampacity { get; }
      Description: Get ampacity which is used for specifying size, the unit is ampere.
    string ConductorSize { get; }
      Description: Get conductor size corresponding to specific ampacity.
    WireMaterialType MaterialBelongTo { get; }
      Description: Get the material type which include this ground conductor size information.

--------------------------------------------------------------------------------

[CLASS] GroundConductorSizeSet
Full Name: Autodesk.Revit.DB.Electrical.GroundConductorSizeSet

Description: A set that contains GroundConductorSizes.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new GroundConductorSizeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of GroundConductorSizes that are in the set.

  METHODS:
    void Clear()
      Description: Removes every GroundConductorSize from the set, rendering it empty.
    bool Contains(GroundConductorSize item)
      Description: Tests for the existence of a GroundConductorSize within the set.
      @item: The GroundConductorSize to be searched for.
      Returns: The Contains method returns True if the GroundConductorSize is within the set, otherwise False.
    int Erase(GroundConductorSize item)
      Description: Removes a specified GroundConductorSize from the set.
      @item: The GroundConductorSize to be erased.
      Returns: The number of GroundConductorSizes that were erased from the set.
    GroundConductorSizeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(GroundConductorSize item)
      Description: Insert the specified GroundConductorSize into the set.
      @item: The GroundConductorSize to be inserted into the set.
      Returns: Returns whether the GroundConductorSize was inserted into the set.
    GroundConductorSizeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GroundConductorSizeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator

Description: An iterator to a GroundConductorSize set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new GroundConductorSizeSetIterator()

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

[CLASS] InsulationType
Full Name: Autodesk.Revit.DB.Electrical.InsulationType

Description: Represents electrical insulation type definition information.
Remarks: Insulation type is defined based on corresponding wire material type and temperature rating type.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    bool IsInUse { get; }
      Description: Indicate whether the insulation type is in use.
    string Name { set; }
      Description: Get name of Insulation type.

--------------------------------------------------------------------------------

[CLASS] InsulationTypeSet
Full Name: Autodesk.Revit.DB.Electrical.InsulationTypeSet

Description: A set that contains insulation types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new InsulationTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of insulation types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every insulation type from the set, rendering it empty.
    bool Contains(InsulationType item)
      Description: Tests for the existence of a insulation type within the set.
      @item: The insulation type to be searched for.
      Returns: The Contains method returns True if the insulation type is within the set, otherwise False.
    int Erase(InsulationType item)
      Description: Removes a specified insulation type from the set.
      @item: The insulation type to be erased.
      Returns: The number of insulation types that were erased from the set.
    InsulationTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(InsulationType item)
      Description: Insert the specified insulation type into the set.
      @item: The insulation type to be inserted into the set.
      Returns: Returns whether the insulation type was inserted into the set.
    InsulationTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] InsulationTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator

Description: An iterator to a insulation type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new InsulationTypeSetIterator()

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

[CLASS] LightingDevice
Full Name: Autodesk.Revit.DB.Electrical.LightingDevice

Description: Provides access to the Lighting Device in Autodesk Revit MEP.
Remarks: The Lighting Device object can only be queried in Autodesk Revit MEP.
Inherits: MEPModel
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] LightingFixture
Full Name: Autodesk.Revit.DB.Electrical.LightingFixture

Description: Provides access to the Lighting Fixture in Autodesk Revit MEP.
Remarks: The Lighting Fixture object can only be queried in Autodesk Revit MEP.
Inherits: MEPModel
Implements: IDisposable

--------------------------------------------------------------------------------

[ENUM] LoadClassification
Full Name: Autodesk.Revit.DB.Electrical.LoadClassification

Description: An enumerated type to list all demand factor classifications.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Power = 1
    - Lighting = 2
    - Hvac = 3

[ENUM] LoadClassificationType
Full Name: Autodesk.Revit.DB.Electrical.LoadClassificationType

Description: An enumerated type listing all the possible load classification types for a connector object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Other = 0
    - Power = 1
    - Lighting = 2
    - HVAC = 3

[ENUM] NeutralMode
Full Name: Autodesk.Revit.DB.Electrical.NeutralMode

Description: An enumerated type to list the neutral mode for wire type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - HotConductorSize = 0
    - UnbalancedCurrent = 1

[ENUM] PanelConfiguration
Full Name: Autodesk.Revit.DB.Electrical.PanelConfiguration

Description: This enum declares the configuration for given panel schedule type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - OneColumn = 0
    - TwoColumnsCircuitsAcross = 1
    - TwoColumnsCircuitsDown = 2

[CLASS] PanelScheduleData
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleData

Description: The PanelScheduleData class holds most of the data that describe the layout, appearance, and style of the rows, columns, and cells of a panel schedule
Inherits: TableData
Implements: IDisposable

  PROPERTIES:
    bool BodyShowsVerticalHeaders { get; }
      Description: Shows text in the Load Summary section's headers vertically instead of horizontally
    ElementId BorderAroundSchedule { get; }
      Description: Places a border (GraphicStyle element) around the entire schedule, visible only on the instance and sheet
    ElementId BorderAroundSections { get; }
      Description: Places a border (GraphicStyle element) around each section, visible only on the instance and sheet
    bool IsAutoShadingForLoadDisplay { get; set; }
      Description: Display shading of load cells automatically or not.
    bool IsFooterSectionHidden { get; }
      Description: True if the user wishes to hide the footer section; setting this value must go through the appropriate update function
    bool IsHeaderSectionHidden { get; }
      Description: True if the user wishes to hide the header section; setting this value must go through the appropriate update function
    bool IsPanelSinglePhase { get; set; }
      Description: Identifies if the panel is single phase.
    bool IsSummarySectionHidden { get; }
      Description: True if the user wishes to hide the summary section; setting this value must go through the appropriate update function
    bool IsUnusedPhaseHidden { get; set; }
      Description: True if the user wishes to hide the unused phase column of a single phase panel, false otherwise.
    int NumberOfSlots { get; }
      Description: The number of slots in the panel schedule; setting this value must go through the appropriate update function
    PanelConfiguration PanelConfiguration { get; }
      Description: The panel configuration of this panel schedule
    PanelSchedulePhaseLoadType PhaseLoadType { get; }
      Description: This property determines the layout of the phase load columns; setting this value must go through the updateCircuitTable function
    bool PhasesAsCurrents { get; }
      Description: If true, the phase columns are currents (A), otherwise they are loads (VA); setting this value must go through the appropriate update function
    PanelScheduleType ScheduleType { get; }
      Description: The panel schedule type of this panel schedule
    bool ShowCircuitNumberOnOneRowForMultiphaseCircuits { get; set; }
      Description: Shows the circuit number broken up on each row of the multiphase circuit rows if true, all on the first row otherwise
    bool ShowMultipleRowsForMultiphaseCircuits { get; set; }
      Description: shows extra rows below multiphase circuits to indicate how many slots they take up if true, all on a single row otherwise
    bool ShowSlotFromDeviceInsteadOfTemplate { get; set; }
      Description: When true, the number of rows in an instance will be the number of poles on the associated device, not a set number
    bool SummaryShowsGroups { get; set; }
      Description: Show groups of load classifications in the load summary section
    bool SummaryShowsOnlyConnectedLoads { get; set; }
      Description: Show only the connected load classifications in the summary section
    bool SummaryShowsVerticalHeaders { get; }
      Description: Shows text in the Load Summary section's headers vertically instead of horizontally

  METHODS:
    bool AddLoadClassification(ElementId loadClassficationId)
      Description: Add a Load Classification Id to the array of Load Classifications.
      @loadClassficationId: The load classification to add
      Returns: True if success; false if the given Id has already existed.
    IList<ElementId> GetLoadClassifications()
      Description: Gets an array of the load classifications associated with this panel schedule
      Returns: The array of the load classifications
    int GetNumberOfCircuitRows()
      Description: Gets the number of rows in the circuit table
      Returns: The number of rows
    bool IsSymmetric()
      Description: Check if this panel schedule is symmetric
      Returns: True if this panel schedule is symmetric, false otherwise.
    void RemoveLoadClassification(int nIndex)
      Description: Remove a Load Classification Id from the array of Load Classifications
      @nIndex: The index at which to remove the load classification
    void SetBorderAroundSchedule(ElementId borderId)
      Description: Adds a border around the schedule
      @borderId: The border to set around the schedule
    void SetBorderAroundSections(ElementId borderId)
      Description: Adds a border around the sections
      @borderId: The border to set around the sections
    void SetLoadClassifications(IList<ElementId> loadClassificaions)
      Description: Sets the Load Classifications associated with this panel schedule
      @loadClassificaions: The load classifications to assign
    void UpdateCircuitTableForInstance(FamilyInstance pPanel)
      Description: Redraw the circuit table for the given panel with the given parameter updates
      @pPanel: The panel that this circuit table is being drawn for
    void UpdateCircuitTableForTemplate(PanelSchedulePhaseLoadType newType, int nNumSlots, bool bPhasesAsCurrents)
      Description: Redraw the circuit table for a template with the given parameter updates
      @newType: The new phase load type of the circuit table
      @nNumSlots: The number of circuit slots
      @bPhasesAsCurrents: True if the phase columns should be currents, false if they should be loads
    void UpdateIsSectionHidden(SectionType sectionType, bool bHide)
      Description: Update if this section is hidden or not
      @sectionType: The Section Type
      @bHide: Whether to hide this section or not
    void UpdateLoadSummary()
      Description: Update the load summary section
    void UpdateVerticalHeadersInSection(SectionType sectionType, bool bVertical)
      Description: Sets if this header should have vertical text
      @sectionType: The section type
      @bVertical: Whether headers are vertical or not

--------------------------------------------------------------------------------

[ENUM] PanelSchedulePhaseLoadType
Full Name: Autodesk.Revit.DB.Electrical.PanelSchedulePhaseLoadType

Description: Declares the panel schedule type. The comments for each enum type show a simple example of how the layout would look when applied to a panel schedule
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoLoadInformation = 0
    - LoadsByPhaseInSplitColumns = 1
    - MirroredPhaseColumns = 2
    - LoadsByPhaseInSharedColumns = 3
    - LoadsByPhase = 4
    - TotalLoadOnlyPerCircuit = 5
    - SeperatePhaseLoadsPerCircuit = 6

[CLASS] PanelScheduleSheetInstance
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleSheetInstance

Description: The class represents an instance of a panel schedule placed on sheet.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    XYZ Origin { get; set; }
      Description: The sheet instance offset in drawing sheet coordinates.
    ElementId ScheduleId { get; set; }
      Description: The panel schedule id.

  METHODS:
    static PanelScheduleSheetInstance Create(Document ADoc, ElementId scheduleId, View DBView)
      Description: Creates a new instance of panel schedule on sheet and adds it to the document.
      Returns: The newly created panel schedule sheet instance element.
    PanelScheduleView GetSchedule()
      Description: Gets the panel schedule view.
      Returns: The panel schedule view element.
    bool SplitSegment(int iSeg)
      Description: Split the panel schedule into Thrown if the index is out of bounds.

--------------------------------------------------------------------------------

[CLASS] PanelScheduleTemplate
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleTemplate

Description: The PanelScheduleTemplate class represents an instance of panel schedule template element. An instance object could be a branch panel, a switchboard or a data panel template.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool IsBranchPanelSchedule { get; }
      Description: Checks to see if this object is branch panel schedule template element.
    bool IsDataPanelSchedule { get; }
      Description: Checks to see if this object is data panel schedule template element.
    bool IsDefault { get; }
      Description: Checks to see if this is default template for the given panel schedule type.
    bool IsSwitchboardSchedule { get; }
      Description: Checks to see if this object is switchboard schedule template element.

  METHODS:
    void CopyFrom(Document OtherADoc, PanelScheduleTemplate otherElem)
      Description: Copies all values from other element to this object.
      @OtherADoc: The Document for the otherElem
      @otherElem: The element being copied from.
    static PanelScheduleTemplate Create(Document document, PanelScheduleType type, PanelConfiguration config, string strName)
      Description: Creates a new instance of a panel schedule template.
      @document: The document where the element will be created and added.
      @type: The panel schedule type.
      @config: The panel configuration type.
      @strName: The name of the panel schedule template to be created.
      Returns: The newly created panel schedule template element.
    PanelScheduleType GetPanelScheduleType()
      Description: Returns the panel schedule type.
    TableSectionData GetSectionData(SectionType sectionType)
      Description: Gets the writable section data object.
      Returns: The table section data object.
    PanelScheduleData GetTableData()
      Description: Gets the writable table data object.
      Returns: The panel schedule data object.
    bool HasSameType(PanelScheduleTemplate otherTemplate)
      Description: Checks if given template has the same panel schedule type with this template.
      @otherTemplate: The given template to check.
      Returns: True if the given template has the same panel schedule type with this template, false otherwise.
    static bool IsValidPanelConfiguration(PanelScheduleType scheduleType, PanelConfiguration configuration)
      Description: Checks if given panel configuration is valid for given panel schedule type.
      @scheduleType: The panel schedule type.
      @configuration: The given configuration to check.
      Returns: True if panel schedule template can have a valid configuration assigned, false otherwise.
    static bool IsValidType(PanelScheduleType panelScheduleType)
      Description: Checks if given type is valid for this panel schedule template element.
      @panelScheduleType: The given type to check.
      Returns: True if panel schedule template can have a type assigned and this type is valid for this element, false otherwise.
    void SetTableData(PanelScheduleData Data)
      Description: Assigns table data to this template
      @Data: The panel schedule data

--------------------------------------------------------------------------------

[ENUM] PanelScheduleType
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleType

Description: This enum declares the panel schedule type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Branch = 0
    - Switchboard = 1
    - Data = 2
    - Unknown = -1

[CLASS] PanelScheduleView
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleView

Description: An instance of a panel schedule view.
Inherits: TableView
Implements: IDisposable

  METHODS:
    void AddSpace(int nRow, int nCol)
      Description: Add a space at specific cell.
      @nRow: Row Number
      @nCol: Column Number
    void AddSpare(int nRow, int nCol)
      Description: Add a spare at specific cell.
      @nRow: Row Number
      @nCol: Column Number
    bool CanMoveSlotTo(int nMovingRow, int nMovingCol, int nToRow, int nToCol)
      Description: Verifies if can circuits in the source slot to the specific slot.
      @nMovingRow: The Row Number of cell to be moved.
      @nMovingCol: Start Column Number of cell to be moved.
      @nToRow: The Row Number of cell to moved to.
      @nToCol: End Column Number of cell to moved to.
      Returns: True if can move circuits in the source slot to the specific slot.
    static PanelScheduleView CreateInstanceView(Document ADoc, ElementId templateId, ElementId panelId)
      Description: Creates a new instance of this view (using specific template)
      @ADoc: The Document
      @templateId: The templateId that this function will use
      @panelId: Element id of the electrical panel element.
      Returns: The PanelScheduleView
    static PanelScheduleView CreateInstanceView(Document ADoc, ElementId panelId)
      Description: Creates a new instance of this view (using default template)
      @ADoc: The Document
      @panelId: Element id of the electrical panel element.
      Returns: The PanelScheduleView
    void GenerateInstanceFromTemplate(ElementId templateId)
      Description: Assigns the data from the template to the instance and performs any tasks specific to the instance (3rd phase, borders, etc)
      @templateId: Element id of the template element.
    double GetApparentPhaseValue(ElementId circuitId, ElementId apparentLoadParam)
      Description: Gets the apparent load for the given phase for the given slotted circuit
      @circuitId: Circuit id for the apparent phase value
      @apparentLoadParam: The requested apparent load phase parameter
      Returns: The value of the apparent phase
    void GetCellsBySlotNumber(int nSlotNumber, out IList<int> RowArr, out IList<int> ColArr)
    ElectricalSystem GetCircuitByCell(int nRow, int nCol)
      Description: Gets the circuit element for the given slot number
      @nRow: Row Number of the Body Section
      @nCol: Column Number of the Body Section
      Returns: The circuit found at the given row and column
    ElementId GetCircuitIdByCell(int nRow, int nCol)
      Description: Gets the circuit id for the given slot number
      @nRow: Row Number
      @nCol: Column Number
      Returns: ElementId of the circuit found at the given row and column
    string GetCombinedParamValue(SectionType sectionType, int nRow, int nCol)
      Description: Returns the combined parameter text for instance view
      @sectionType: Section type
      @nRow: Row Number
      @nCol: Column Number
      Returns: The combined parameter text
    string GetLoadClassificationConnectedCurrent(int nRow, int nCol)
      Description: Gets the Total Current for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Connected Current for the given Load Classification
    string GetLoadClassificationConnectedLoad(int nRow, int nCol)
      Description: Gets the Total Load for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The total load for the given Load Classification
    string GetLoadClassificationDemandCurrent(int nRow, int nCol)
      Description: Gets the Demand Current for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Demand Current for the given Load Classification
    string GetLoadClassificationDemandFactor(int nRow, int nCol)
      Description: Gets the Demand Factor for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Demand Factor for the given Load Classification
    string GetLoadClassificationDemandLoad(int nRow, int nCol)
      Description: Gets the Demand Load for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Demand Load for the Load Classification
    ElementId GetLoadClassificationId(int nRow)
      Description: Gets the id of the associated Load Classification at the given row
      @nRow: Row number of Load Summary Section
      Returns: The element id of the Load Classification
    string GetLoadClassificationName(int nRow, int nCol)
      Description: Gets the name of the Load Classification at the given row/column
      @nRow: Row Number of the Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The name of the Load Classification
    string GetLoadClassificationParamValue(ElementId parameterId, int nRow, int nCol)
      Description: Gets the load classification parameter value.
      @parameterId: Parameter Id of the Load Classification
      @nRow: Row Number of the Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The value of the Load Classification parameter
    ElementId GetPanel()
      Description: Gets the panel for this view
      Returns: The id of the panel for this view
    string GetParamValue(SectionType sectionType, int nRow, int nCol)
      Description: Gets the cell's text based on its type
      @sectionType: Section of the desired parameter value
      @nRow: Row Number of the Section
      @nCol: Column Number of the Section
      Returns: The cell's text
    TableSectionData GetSectionData(SectionType sectionType)
      Description: Gets section data that will be written to
      @sectionType: The section type
      Returns: The
    int GetSlotNumberByCell(int nRow, int nCol)
      Description: Gets the slot number in the circuit table
      @nRow: Column Number
      Returns: Row Number
    double GetSpareCurrentValue(int row, int column, ElementId idCurrentParameter)
      Description: Gets the value of the apparent current parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idCurrentParameter: One of 4 valid current parameters: RBS_ELEC_APPARENT_CURRENT_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEA_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEB_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEC_PARAM
      Returns: The value of the spare's current parameter
    double GetSpareLoadValue(int row, int column, ElementId idLoadParameter)
      Description: Gets the value of the apparent load parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idLoadParameter: One of 4 valid load parameters: RBS_ELEC_APPARENT_LOAD, RBS_ELEC_APPARENT_LOAD_PHASEA, RBS_ELEC_APPARENT_LOAD_PHASEB, RBS_ELEC_APPARENT_LOAD_PHASEC
      Returns: The value of the spare's load parameter
    PanelScheduleData GetTableData()
      Description: Gets table data that can be written to
      Returns: The
    ElementId GetTemplate()
      Description: Gets the template for this view (to set the template, you must go through generateInstanceFromTemplate)
      Returns: The template id for this view
    bool IsCellInPhaseLoads(int nRow, int nCol)
      Description: Check if this cell in the phase loads
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if this cell in the phase loads, false otherwise
    bool IsColumnInLoadSummary(int nCol)
      Description: Check if this column in the load summary
      @nCol: Column Number
      Returns: Check if this column in the load summary
    bool IsPanelScheduleTemplate()
      Description: Check if this is a panel schedule template.
      Returns: Check if this is a panel schedule template.
    bool IsRowInCircuitTable(int nRow)
      Description: Check if this row in the circuit table
      @nRow: Row Number
      Returns: True if this row in the circuit table, false otherwise.
    int IsSlotGrouped(int nRow, int nCol)
      Description: Check if the slot is in a group
      @nRow: Row Number
      @nCol: Column Number
      Returns: It is not in a group if the return value equals to 0. It is in a group if the return value is greater than 0 and the return value is the group number.
    bool IsSlotLocked(int nRow, int nCol)
      Description: Check if the circuit slot in this cell is locked.
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if the circuit slot in this cell is locked, false otherwise False if the circuit slot not found.
    bool IsSpace(int nRow, int nCol)
      Description: Check if the selected cell is a space
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if the selected cell is a space, false otherwise
    bool IsSpare(int nRow, int nCol)
      Description: Check if the circuit is a spare
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if the circuit is a spare, false otherwise
    void MoveSlotTo(int nMovingRow, int nMovingCol, int nToRow, int nToCol)
      Description: Move the circuits in the source slot to the specific slot.
      @nMovingRow: The Row Number of cell to be moved.
      @nMovingCol: Start Column Number of cell to be moved.
      @nToRow: The Row Number of cell to moved to.
      @nToCol: End Column Number of cell to moved to.
    void RemoveSpace(int nRow, int nCol)
      Description: Remove a space at specific cell.
      @nRow: Row Number
      @nCol: Column Number
    void RemoveSpare(int nRow, int nCol)
      Description: Remove a spare at specific cell.
      @nRow: Row Number
      @nCol: Column Number
    void RenumberIndexes()
      Description: Renumbers the Circuit Naming Index for the circuits in the panel.
    void SetLockSlot(int nRow, int nCol, bool bLock)
      Description: Set lock state for a circuit slot at specific cell.
      @nRow: Row Number
      @nCol: Column Number
      @bLock: Lock state to set
    bool SetParamValue(SectionType sectionType, int nRow, int nCol, string sValue)
      Description: Sets the text for the given cell, returns true if successful, false otherwise
      @sectionType: The associated section
      @nRow: Row Number of the Section
      @nCol: Column Number of the Section
      @sValue: String value to set the parameter
      Returns: Returns whether the function succeeded
    void SetSpareCurrentValue(int row, int column, ElementId idCurrentParameter, double value)
      Description: Sets the value of the apparent current parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idCurrentParameter: One of 4 valid current parameters: RBS_ELEC_APPARENT_CURRENT_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEA_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEB_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEC_PARAM
      @value: The value of the spare's current for the given parameter
    void SetSpareLoadValue(int row, int column, ElementId idLoadParameter, double value)
      Description: Sets the value of the apparent load parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idLoadParameter: One of 4 valid load parameters: RBS_ELEC_APPARENT_LOAD, RBS_ELEC_APPARENT_LOAD_PHASEA, RBS_ELEC_APPARENT_LOAD_PHASEB, RBS_ELEC_APPARENT_LOAD_PHASEC
      @value: The value of the spare's load for the given parameter
    void SwitchPhases(int nRow, int nCol)
      Description: Switches the circuit phases at the slot.
      @nRow: Row Number.
      @nCol: Column Number.

--------------------------------------------------------------------------------

[ENUM] PowerFactorStateType
Full Name: Autodesk.Revit.DB.Electrical.PowerFactorStateType

Description: An enumerated type listing all the possible power factor state types for a connector object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Leading = 0
    - Lagging = 1

[CLASS] TemperatureRatingType
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRatingType

Description: Represents temperature rating type definition information.
Remarks: Temperature rating type is defined based on corresponding wire material type. It includes type information such as wire size, insulation type, correction factor, etc. Only the temperature rating types which are retrieved from WireMaterialType can work well, so don't retrieve it from Revit document directly.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    CorrectionFactorSet CorrectionFactors { get; }
      Description: Get all correction factors defined in this temperature rating type and its corresponding material type.
    InsulationTypeSet InsulationTypes { get; }
      Description: Get all insulation types defined in this temperature rating type and its corresponding material type.
    bool IsInUse { get; }
      Description: Indicate whether the temperature rating type is in use.
    WireMaterialType MaterialType { get; }
      Description: Get the material type information which this temperature rating type belongs to.
    string Name { set; }
      Description: Get name of temperature rating type.
    WireSizeSet WireSizes { get; }
      Description: Get all electrical wire sizes defined in this temperature rating type and its corresponding material type.

  METHODS:
    CorrectionFactor AddCorrectionFactor(double temperature, double factor)
      Description: Add a new electrical correction factor type to this temperature rating type. The given temperature value should be quantified in the document's selected unit of electrical temperature.
      @temperature: Temperature of correction factor to be added in the document's selected unit of electrical temperature.
      @factor: Factor of correction factor to be added.
      Returns: New constructed correction factor.
    InsulationType AddInsulationType(string name)
      Description: Add a new kind of insulation type into this temperature rating type.
      @name: Name of insulation type symbol to be constructed and added.
      Returns: Constructed insulation type instance.
    WireSize AddWireSize(string size, long ampacity, double diameter)
      Description: Add a new kind of wire size type into this temperature rating type.
      @size: Size of wire size.
      @ampacity: Ampacity of wire size to be added.
      @diameter: Diameter of wire size to be added.
      Returns: Constructed wire size type.
    void RemoveCorrectionFactor(CorrectionFactor correctionFactor)
      Description: Remove an existing correction factor from this temperature rating type in Revit MEP project.
      @correctionFactor: The correction factor to be removed.
      Returns: New constructed correction factor.
    void RemoveInsulationType(InsulationType insulationType)
      Description: Remove an existing insulation type from this temperature rating type.
      @insulationType: Insulation type to be removed.
    void RemoveWireSize(WireSize wireSize)
      Description: Remove an existing wire size type from this temperature rating type.
      @wireSize: The wire size type to be removed.

--------------------------------------------------------------------------------

[CLASS] TemperatureRatingTypeSet
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet

Description: A set that contains TemperatureRating types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new TemperatureRatingTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of TemperatureRating types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every TemperatureRating type from the set, rendering it empty.
    bool Contains(TemperatureRatingType item)
      Description: Tests for the existence of a TemperatureRating type within the set.
      @item: The TemperatureRating type to be searched for.
      Returns: The Contains method returns True if the TemperatureRating type is within the set, otherwise False.
    int Erase(TemperatureRatingType item)
      Description: Removes a specified TemperatureRating type from the set.
      @item: The TemperatureRating type to be erased.
      Returns: The number of TemperatureRating types that were erased from the set.
    TemperatureRatingTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(TemperatureRatingType item)
      Description: Insert the specified TemperatureRating type into the set.
      @item: The TemperatureRating type to be inserted into the set.
      Returns: Returns whether the TemperatureRating type was inserted into the set.
    TemperatureRatingTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] TemperatureRatingTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator

Description: An iterator to a TemperatureRating type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new TemperatureRatingTypeSetIterator()

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

[CLASS] VoltageType
Full Name: Autodesk.Revit.DB.Electrical.VoltageType

Description: Represents electrical voltage type. An electrical voltage type define a range of voltages, and circuits can be created between components with rated voltages that do not precisely match the voltage definition value.
Remarks: Actual, minimum and maximum value of voltage type can retrieved through properties, but only can be modified through SetVoltageValue method. All the unit of voltage properties in this class is volt.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    double ActualValue { get; }
      Description: Get actual voltage value of this voltage definition, the unit is volt.
    bool IsInUse { get; }
      Description: Indicates whether this voltage type is in service now, such as by other distribution system.
    double MaxValue { get; }
      Description: Get upper boundary of voltage value of this voltage definition, the unit is volt.
    double MinValue { get; }
      Description: Get lower boundary of voltage value of this voltage definition, the unit is volt.

  METHODS:
    void SetVoltageValue(double actualValue, double minValue, double maxValue)
      Description: Assign new values to modify voltage type, all of the unit are volt.

--------------------------------------------------------------------------------

[CLASS] VoltageTypeSet
Full Name: Autodesk.Revit.DB.Electrical.VoltageTypeSet

Description: A set that contains voltage types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new VoltageTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of voltage types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every voltage type from the set, rendering it empty.
    bool Contains(VoltageType item)
      Description: Tests for the existence of a voltage type within the set.
      @item: The voltage type to be searched for.
      Returns: The Contains method returns True if the voltage type is within the set, otherwise False.
    int Erase(VoltageType item)
      Description: Removes a specified voltage type from the set.
      @item: The voltage type to be erased.
      Returns: The number of voltage types that were erased from the set.
    VoltageTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(VoltageType item)
      Description: Insert the specified voltage type into the set.
      @item: The voltage type to be inserted into the set.
      Returns: Returns whether the voltage type was inserted into the set.
    VoltageTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] VoltageTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator

Description: An iterator to a voltage type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new VoltageTypeSetIterator()

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

[CLASS] Wire
Full Name: Autodesk.Revit.DB.Electrical.Wire

Description: Electrical wire element.
Inherits: MEPCurve
Implements: IDisposable

  PROPERTIES:
    int GroundConductorNum { get; set; }
      Description: The ground conductor number. Its default value is zero after created.
    int HotConductorNum { get; set; }
      Description: The hot conductor number. Its default value is zero after created.
    int NeutralConductorNum { get; set; }
      Description: The neutral conductor number. Its default value is zero after created.
    int NumberOfVertices { get; }
      Description: The number of vertices of the wire, including the start and end point.
    WiringType WiringType { get; set; }
      Description: The wiring type(arc or chamfer) for the wire.

  METHODS:
    void AppendVertex(XYZ vertexPoint)
      Description: Appends one vertex to the end of the wire.
      @vertexPoint: The vertex to be appended.
    static bool AreVertexPointsValid(IList<XYZ> vertexPoints, Connector startConnector, Connector endConnector)
      Description: Checks if the given vertex points are valid for the wire.
      @vertexPoints: The vertex points.
      @startConnector: The start connector of the wire.
      @endConnector: The end connector of the wire.
      Returns: True if the given vertex points are valid, false otherwise.
    void ConnectTo(Connector startConnectorTo, Connector endConnectorTo)
      Description: Connects the wire to other elements.
      @startConnectorTo: The connector that the start connector of the wire connects to.
      @endConnectorTo: The connector that the end connector of the wire connects to.
    static Wire Create(Document document, ElementId wireTypeId, ElementId viewId, WiringType wiringType, IList<XYZ> vertexPoints, Connector startConnectorTo, Connector endConnectorTo)
      Description: Creates a new wire.
      @document: The document.
      @wireTypeId: The id of the wire type of the newly created wire.
      @viewId: The view in which the wire is to be visible. This must be the id of a floor plan or reflected ceiling plan view.
      @wiringType: Specifiies the wiring type for the newly created wire. The shape of the wire is determined by this value and the total number of points supplied via the vertexPoints and endpoint connectors. If the wiring type is WiringType.Arc: If there are 2 total points supplied, the wire is a straight-line wire.If there are 3 total points supplied, the wire is a circular arc wire.If there are 4 or more points, the wire is a spline wire. If the wiring type is WiringType.Chamfer, a polyline wire will be created connecting all the points.
      @vertexPoints: The vertex point of the wire. If the startConnectorTo is , the first vertex of the vertexPoints will be the start point, otherwise, the start connector origin will be the start point. If the endConnectorTo is , the last vertex of the vertexPoints will be the end point, otherwise, the end connector origin will be the end point.
      @startConnectorTo: The connector to which the wire start point connects. If , the start point connects to no existing connector. If set with a connector, the connector's origin will be added to the wire's vertices as the start point.
      @endConnectorTo: The connector to which the wire end point connects. If , the end point connects to no existing connector. If set with a connector, the connector's origin will be added to the wire's vertices as the end point.
      Returns: The wire created.
    IList<ElementId> GetMEPSystems()
      Description: Gets the systems to which the wire belongs.
      Returns: The systems to which the wire belongs.
    XYZ GetVertex(int index)
      Description: Gets the position of an existing vertex.
      @index: The index of the existing vertex. Should be between 0 and .
      Returns: The position of the vertex. It is the offset point for the start and end vertex, not the connector point. If the wire connects to one device, it may have offset; otherwise, the start and end vertex is same as the connector point.
    void InsertVertex(int index, XYZ vertexPoint)
      Description: Inserts a new vertex before the specified index.
      @index: The index of the vertex to come after this new vertex. Should be between 0 and .
      @vertexPoint: The point of the new vertex.
    bool IsVertexPointValid(XYZ vertexPoint)
      Description: Checks if the given vertex point can be added to this wire.
      @vertexPoint: The vertex point.
      Returns: True if the vertex point can be added, false if the point cannot be added because there is already a vertex at this position on the view plane (within tolerance).
    void RemoveVertex(int index)
      Description: Removes the vertex corresponding to the specified index. Can not remove the start or end vertex if it already connects to other element.
      @index: The index which should be in [0, NumberOfVertices).
    void SetVertex(int index, XYZ vertexPoint)
      Description: Sets the position of a given vertex. If the vertex is start or end point, and the wire connects to electrical device, the wire end offset will be set according to the given vertex. If the vertex is start or end point, and the wire connects to other wire, user can't set the vertex and exception will be thrown. If the vertex is start or end point, and the wire connects to nothing, the vertex will be set as the given vertex.
      @index: The index of the existing vertex. Should be between 0 and .
      @vertexPoint: The new position for the vertex.

--------------------------------------------------------------------------------

[CLASS] WireConduitType
Full Name: Autodesk.Revit.DB.Electrical.WireConduitType

Description: Represents a specific conduit type of wire type.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    string Name { get; }

--------------------------------------------------------------------------------

[CLASS] WireConduitTypeSet
Full Name: Autodesk.Revit.DB.Electrical.WireConduitTypeSet

Description: A set that contains conduit types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new WireConduitTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of conduit types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every conduit type from the set, rendering it empty.
    bool Contains(WireConduitType item)
      Description: Tests for the existence of a conduit type within the set.
      @item: The conduit type to be searched for.
      Returns: The Contains method returns True if the conduit type is within the set, otherwise False.
    int Erase(WireConduitType item)
      Description: Removes a specified conduit type from the set.
      @item: The conduit type to be erased.
      Returns: The number of conduit types that were erased from the set.
    WireConduitTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireConduitType item)
      Description: Insert the specified conduit type into the set.
      @item: The conduit type to be inserted into the set.
      Returns: Returns whether the conduit type was inserted into the set.
    WireConduitTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireConduitTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator

Description: An iterator to a conduit type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new WireConduitTypeSetIterator()

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

[CLASS] WireMaterialType
Full Name: Autodesk.Revit.DB.Electrical.WireMaterialType

Description: Represents electrical wire material type definition information of wire type.
Remarks: All the other properties of wire type are based on wire material type. Only the wire material types which are retrieved from ElectricalSetting can work well, so don't retrieve it from Revit project directly.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    GroundConductorSizeSet GroundConductorSizes { get; }
      Description: Get all ground conductor size types defined in this wire material type.
    bool IsInUse { get; }
      Description: Indicate whether the wire material type is in use.
    string Name { set; }
      Description: Get name of wire material type.
    TemperatureRatingTypeSet TemperatureRatings { get; }
      Description: Get all temperature rating type definitions defined in this wire material type.

  METHODS:
    GroundConductorSize AddGroundConductorSize(long ampacity, string size)
      Description: Add new electrical ground conductor size type into this material type.
      @ampacity: Ampacity of ground conductor size to be added.
      @size: Size of ground conductor size to be added.
      Returns: New added ground conductor size.
    TemperatureRatingType AddTemperatureRatingType(string name, TemperatureRatingType baseOn)
      Description: Add a new temperature rating type into material type.
      @name: Name of temperature type to be added.
      @baseOn: The new temperature rating will be created base on this existing temperature rating type.
      Returns: New constructed temperature rating type.
    void RemoveGroundConductorSize(GroundConductorSize grdConductorSize)
      Description: Remove an existing ground conductor size from this material type.
      @grdConductorSize: The ground size type to be removed.
    void RemoveTemperatureRatingType(TemperatureRatingType temperatureRating)
      Description: Remove an existing temperature rating type from this material type.
      @temperatureRating: The temperature rating type to be removed.

--------------------------------------------------------------------------------

[CLASS] WireMaterialTypeSet
Full Name: Autodesk.Revit.DB.Electrical.WireMaterialTypeSet

Description: A set that contains wire material types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new WireMaterialTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of wire material types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every wire material type from the set, rendering it empty.
    bool Contains(WireMaterialType item)
      Description: Tests for the existence of a wire material type within the set.
      @item: The wire material type to be searched for.
      Returns: The Contains method returns True if the wire material type is within the set, otherwise False.
    int Erase(WireMaterialType item)
      Description: Removes a specified wire material type from the set.
      @item: The wire material type to be erased.
      Returns: The number of wire material types that were erased from the set.
    WireMaterialTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireMaterialType item)
      Description: Insert the specified wire material type into the set.
      @item: The wire material type to be inserted into the set.
      Returns: Returns whether the wire material type was inserted into the set.
    WireMaterialTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireMaterialTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator

Description: An iterator to a wire material type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new WireMaterialTypeSetIterator()

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

[CLASS] WireSet
Full Name: Autodesk.Revit.DB.Electrical.WireSet

Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new WireSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Wire item)
    int Erase(Wire item)
    WireSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Wire item)
    WireSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireSetIterator

Description: An iterator to a set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new WireSetIterator()

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

[CLASS] WireSize
Full Name: Autodesk.Revit.DB.Electrical.WireSize

Description: Represents specific electrical wire size information.
Remarks: Wire size is defined based on corresponding wire material type and temperature rating type.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    long Ampacity { get; }
      Description: Get ampacity which be used for specifying size, the unit is ampere.
    double Diameter { get; }
      Description: Get diameter of wire.
    bool InUse { get; set; }
      Description: Get or set whether the size can be used in sizing.
    string Size { get; }
      Description: Get size symbol of wire.

--------------------------------------------------------------------------------

[CLASS] WireSizeSet
Full Name: Autodesk.Revit.DB.Electrical.WireSizeSet

Description: A set that contains wire sizes.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new WireSizeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of wire sizes that are in the set.

  METHODS:
    void Clear()
      Description: Removes every wire size from the set, rendering it empty.
    bool Contains(WireSize item)
      Description: Tests for the existence of a wire size within the set.
      @item: The wire size to be searched for.
      Returns: The Contains method returns True if the wire size is within the set, otherwise False.
    int Erase(WireSize item)
      Description: Removes a specified wire size from the set.
      @item: The wire size to be erased.
      Returns: The number of wire sizes that were erased from the set.
    WireSizeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireSize item)
      Description: Insert the specified wire size into the set.
      @item: The wire size to be inserted into the set.
      Returns: Returns whether the wire size was inserted into the set.
    WireSizeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireSizeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireSizeSetIterator

Description: An iterator to a wire size set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new WireSizeSetIterator()

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

[CLASS] WireType
Full Name: Autodesk.Revit.DB.Electrical.WireType

Description: Represents a specific wire type.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    WireConduitType Conduit { get; set; }
      Description: The conduit type of the wire type.
    InsulationType Insulation { get; set; }
      Description: The insulation type.
    bool IsInUse { get; }
      Description: Indicates whether the wire type is in use.
    WireSize MaxSize { get; set; }
      Description: The max size of the wire type.
    double NeutralMultiplier { get; set; }
      Description: The neutral multiplier type of the wire type.
    bool NeutralRequired { get; set; }
      Description: Whether or not the neutral point is required.
    NeutralMode NeutralSize { get; set; }
      Description: The maximum neutral size of the wire type.
    TemperatureRatingType TemperatureRating { get; set; }
      Description: The temperature rating type of the wire type.
    WireMaterialType WireMaterial { get; set; }
      Description: The material type of the wire type.

--------------------------------------------------------------------------------

[CLASS] WireTypeSet
Full Name: Autodesk.Revit.DB.Electrical.WireTypeSet

Description: A set that contains wire types.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new WireTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of wire types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every wire type from the set, rendering it empty.
    bool Contains(WireType item)
      Description: Tests for the existence of a wire type within the set.
      @item: The wire type to be searched for.
      Returns: The Contains method returns True if the wire type is within the set, otherwise False.
    int Erase(WireType item)
      Description: Removes a specified wire type from the set.
      @item: The wire type to be erased.
      Returns: The number of wire types that were erased from the set.
    WireTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireType item)
      Description: Insert the specified wire type into the set.
      @item: The wire type to be inserted into the set.
      Returns: Returns whether the wire type was inserted into the set.
    WireTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireTypeSetIterator

Description: An iterator to a wire type set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new WireTypeSetIterator()

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

[ENUM] WiringType
Full Name: Autodesk.Revit.DB.Electrical.WiringType

Description: An enumerated type to list all wiring types.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Arc = 0
    - Chamfer = 1


