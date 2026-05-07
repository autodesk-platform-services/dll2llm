# Autodesk.Revit.DB.Electrical

NAMESPACE: Autodesk.Revit.DB.Electrical
--------------------------------------------------------------------------------

[CLASS] AnalyticalBusData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalBusData
Description: Represents the data and parameters of analytical bus node.
Inherits: AnalyticalPowerDistributableNodeData

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
      Throws ArgumentException: The id isn't a downstream node id of the power distributable node.
      Throws ArgumentNullException: A non-optional argument was null
    ElectricalPerPhaseData GetApparentPerPhaseResults()
      Description: Get an ElectricalPerPhaseData which contains each electrical phase's apparent load and apprent current of the power distributable node.
    ElectricalConnectedPhases GetConnectedPhasesOnDownstream(ElementId id)
      Description: Get the electrical connected phases of the downstream node.
      @id: The downstream node id.
      Returns: The electrical connected phases of the downstream node.
      Throws ArgumentException: The id isn't a downstream node id of the power distributable node.
      Throws ArgumentNullException: A non-optional argument was null
    ElectricalPerPhaseData GetDemandPerPhaseResults()
      Description: Get an ElectricalPerPhaseData which contains each electrical phase's demand load and demand current of the power distributable node.
    void SetConnectedPhasesOnDownstream(ElementId id, ElectricalConnectedPhases connectedPhases)
      Description: Set the electrical connected phases of the downstream node.
      @id: The downstream node id.
      @connectedPhases: The electrical connected phases to set to the downstream node.
      Throws ArgumentException: The id isn't a downstream node id of the power distributable node. -or- The electrical connected phases can't be used to connect the downstream node to the power distributable node.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] AnalyticalPowerSourceData
Full Name: Autodesk.Revit.DB.Electrical.AnalyticalPowerSourceData
Description: Represents the data and parameters of analytical power source node.
Inherits: AnalyticalPowerDistributableNodeData

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
      Throws ArgumentException: The given value for elev is not a number -or- The given value for elev is not finite
    bool IsLevelWithinRange(ElementId levelId)
      Description: Checks whether the given level is between the bottom level and the top level (including the bottom level and the top level) of the area based load boundary line.
      @levelId: The id of the Level.
      Returns: True if given level is between the bottom level and the top level, false otherwise.
      Throws ArgumentException: The ElementId levelId is not a Level.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] AreaBasedLoadData
Full Name: Autodesk.Revit.DB.Electrical.AreaBasedLoadData
Description: Represents the electrical area based load data.
Inherits: ZoneElementDomainData

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
      Throws ArgumentException: The id isn't a valid electrical load area.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Verifies that the area based load can connect to the upstream electrical analytical node. If the area based load already has an upstream node or the upstream node is full of downstream nodes, the area based load can't connect to the upstream node.
      @upstreamNodeId: The upstream electrical analytical node id.
      Returns: True if the area based load can connect to the upstream electrical analytical node.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanDisconnectFromUpstreamNode()
      Description: Verifies that the area based load can disconnect from the upstream electrical analytical node. If the area based load hasn't an upstream node, it can't disconnect from the upstream node.
      Returns: True if the area based load can disconnect from the upstream electrical analytical node.
    void ConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Connects to an upstream electrical analytical node.
      @upstreamNodeId: The upstream electrical analytical node id.
      Throws ArgumentException: The id is not an electrical analytical node id. -or- The area based load can not connect to the upstream electrical analytical node.
      Throws ArgumentNullException: A non-optional argument was null
    void DisconnectFromUpstreamNode()
      Description: Disconnects from an upstream electrical analytical node.
      Throws InvalidOperationException: The area based load can not disconnect from the upstream electrical analytical node.
    ISet<ElementId> GetElectricalLoadAreas()
      Description: Gets electrical load areas which the area based load includes.
    ElementId GetUpstreamNodeId()
      Description: Gets the upstream electrical analytical node id.
      Returns: The upstream node id.
    void RemoveElectricalLoadArea(ElementId electricalLoadAreaId)
      Description: Removes electrical load area from the area based load.
      @electricalLoadAreaId: The electrical load area id to remove.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] AreaBasedLoadType
Full Name: Autodesk.Revit.DB.Electrical.AreaBasedLoadType
Description: This class represents an area based load type in Autodesk Revit.
Inherits: Element

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
      Throws ArgumentException: document is not a project document. -or- name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] CableTray
Full Name: Autodesk.Revit.DB.Electrical.CableTray
Description: This class represents a cable tray in Autodesk Revit.
Inherits: CableTrayConduitBase

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
      Throws ArgumentException: This cable tray type is invalid. -or- This level id is invalid. -or- The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    CableTrayShape GetShapeType()
      Description: Returns the shape type for the cable tray.
      Returns: The shape type.
    static bool IsValidCableTrayType(Document document, ElementId cabletrayType)
      Description: Identifies if a cable tray type is valid.
      @document: The document.
      @cabletrayType: The cable tray type.
      Returns: True if the cable tray type is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidRungSpace(double rungSpace)
      Description: Identifies if the input rung space is valid.
      @rungSpace: The rung space to check.
      Returns: True if the value is acceptable, false otherwise.

--------------------------------------------------------------------------------

[CLASS] CableTrayConduitBase
Full Name: Autodesk.Revit.DB.Electrical.CableTrayConduitBase
Description: The CableTrayConduitBase class is implemented as the base class for cable tray or conduit
Inherits: MEPCurve

  PROPERTIES:
    ElementId RunId { get; }
      Description: The id of the run to which this element belongs.

  METHODS:
    static bool IsValidEndPoints(XYZ startPoint, XYZ endPoint)
      Description: Identifies if two end points are valid.
      @startPoint: The start point of the location line.
      @endPoint: The end point of the location line.
      Returns: True if the two end points are valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidLevelId(Document document, ElementId levelId)
      Description: Identifies if a level id is valid.
      @document: The document.
      @levelId: The level id.
      Returns: True if the level id is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsWithFitting()
      Description: Return whether its cable tray/conduit type is with fitting
      Returns: return true if its type is with fitting type.

--------------------------------------------------------------------------------

[CLASS] CableTrayConduitRunBase
Full Name: Autodesk.Revit.DB.Electrical.CableTrayConduitRunBase
Description: The base class for a cable tray or conduit run in Autodesk Revit.
Inherits: Element

  PROPERTIES:
    double Length { get; }
      Description: The length of the whole (cable tray or conduit) run default 0.0

--------------------------------------------------------------------------------

[CLASS] CableTrayRun
Full Name: Autodesk.Revit.DB.Electrical.CableTrayRun
Description: This class represents a cable tray run in Autodesk Revit.
Remarks: This class is mainly for calculating length of a cable tray run. A cable tray run contains connected straight cable tray segments and bends between the straight segments with same type and size.
Inherits: CableTrayConduitRunBase

--------------------------------------------------------------------------------

[CLASS] CableTraySettings
Full Name: Autodesk.Revit.DB.Electrical.CableTraySettings
Description: The cable tray settings.
Inherits: Element

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
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] CableTrayShape
Full Name: Autodesk.Revit.DB.Electrical.CableTrayShape
Description: Shape types enum of cable tray
Inherits: Enum

  Values:
    - Invalid = 0
    - Channel = 1
    - Ladder = 2

--------------------------------------------------------------------------------

[CLASS] CableTraySizeIterator
Full Name: Autodesk.Revit.DB.Electrical.CableTraySizeIterator
Description: An iterator to a set of MEP cable tray sizes from CableTraySizes.
Implements: IEnumerator<MEPSize>, IDisposable, IEnumerator

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
      Throws InvalidOperationException: There is no current item in the iterator.
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
Implements: IEnumerable<MEPSize>, IEnumerable

  METHODS:
    void AddSize(MEPSize sizeInfo)
      Description: Inserts a new MEPSize into the cable tray sizes. For cable tray, the nominal diameter of MEPSize is used .
      @sizeInfo: The new MEPSize to be added.
      Throws ArgumentException: There is already the same size in the size set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The function is called during iterating the size set.
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
      Throws ArgumentNullException: A non-optional argument was null
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
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Throws if the function is called during iterating the size set.

--------------------------------------------------------------------------------

[CLASS] CableTrayType
Full Name: Autodesk.Revit.DB.Electrical.CableTrayType
Description: This class represents a cable tray type in Autodesk Revit.
Inherits: MEPCurveType

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

  Values:
    - SourceParameters = 0
    - Initial = 1
    - Sentence = 2
    - Upper = 3

--------------------------------------------------------------------------------

[ENUM] CircuitConnectionType
Full Name: Autodesk.Revit.DB.Electrical.CircuitConnectionType
Description: An enumerated type indicates the panel to panel connection type
Inherits: Enum

  Values:
    - NotApplicable = 0
    - Breaker = 1
    - FeedThruLugs = 2

--------------------------------------------------------------------------------

[ENUM] CircuitLoadCalculationMethod
Full Name: Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod
Description: Methods to calculate circuit loads
Inherits: Enum

  Values:
    - SumTrueLoadAndReactiveLoad = 0
    - SumApparentLoad = 1

--------------------------------------------------------------------------------

[ENUM] CircuitNaming
Full Name: Autodesk.Revit.DB.Electrical.CircuitNaming
Description: An enumerated type listing all the circuit naming options.
Inherits: Enum

  Values:
    - Prefixed = 0
    - Standard = 1
    - PanelName = 2
    - Phase = 3
    - ProjectSetting = 4
    - Customized = 5
    - Undefined = -1

--------------------------------------------------------------------------------

[CLASS] CircuitNamingScheme
Full Name: Autodesk.Revit.DB.Electrical.CircuitNamingScheme
Description: This class represents a circuit naming scheme in Autodesk Revit.
Inherits: Element

  METHODS:
    static CircuitNamingScheme Create(Document document, string name, IList<TableCellCombinedParameterData> data)
      Description: Creates a new CircuitNamingScheme.
      @document: The document in which to create the CircuitNamingScheme.
      @name: The name of CircuitNamingScheme.
      @data: The array of TableCellCombinedParameterData to be set as combined parameters.
      Returns: The newly created CircuitNamingScheme.
      Throws ArgumentException: name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a CircuitNamingScheme name. -or- The data contains invalid parameter id.
      Throws ArgumentNullException: A non-optional argument was null
    IList<TableCellCombinedParameterData> GetCombinedParameters()
      Description: Gets the combined parameters.
      Returns: Gets array of TableCellCombinedParameterData with the combined parameters data.
    static bool IsNameUnique(Document aDocument, string name)
      Description: Validates whether the CircuitNamingScheme name is unique in document.
      @aDocument: The document in which the name is being tested for uniqueness.
      @name: The name tested for uniqueness.
      Returns: Returns true if the name is unique, and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidCombinedParameters(Document aDocument, IList<TableCellCombinedParameterData> data)
      Description: Validates whether the combined parameters is valid.
      @aDocument: The document.
      @data: The array of TableCellCombinedParameterData to be set as combined parameters.
      Returns: Returns true if the combined parameters are valid, and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCombinedParameters(IList<TableCellCombinedParameterData> data)
      Description: Sets combined parameters array.
      @data: The array of TableCellCombinedParameterData to be set as combined parameters.
      Throws ArgumentException: The data contains invalid parameter id.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] CircuitNamingSchemeSettings
Full Name: Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings
Description: This class represents a circuit naming scheme settings in Autodesk Revit.
Inherits: Element

  PROPERTIES:
    ElementId CircuitNamingSchemeId { get; set; }
      Description: The circuit naming scheme id set in CircuitNamingSchemeSettings.

  METHODS:
    static CircuitNamingSchemeSettings GetCircuitNamingSchemeSettings(Document cda)
      Description: Gets the circuit naming scheme settings of the project.
      @cda: The document.
      Returns: The circuit naming scheme settings of the project.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidCircuitNamingSchemeId(Document aDocument, ElementId circuitNamingSchemeId)
      Description: Verifies that the circuit naming scheme id can be used with CircuitNamingSchemeSettings.
      @aDocument: The document.
      @circuitNamingSchemeId: The circuit naming scheme id to be checked.
      Returns: True if the circuit naming scheme id is valid for CircuitNamingSchemeSettings.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] CircuitNumberingOption
Full Name: Autodesk.Revit.DB.Electrical.CircuitNumberingOption
Description: An enumerated type listing all the circuit numbering options.
Inherits: Enum

  Values:
    - Default = 0
    - Continuous = 1

--------------------------------------------------------------------------------

[ENUM] CircuitSequence
Full Name: Autodesk.Revit.DB.Electrical.CircuitSequence
Description: Options of circuit sequence for assigning circuit to circuits across panel.
Inherits: Enum

  Values:
    - Numerical = 0
    - GroupByPhase = 1
    - OddThenEven = 2

--------------------------------------------------------------------------------

[ENUM] CircuitType
Full Name: Autodesk.Revit.DB.Electrical.CircuitType
Description: An enumerated type listing all the possible circuit types.
Inherits: Enum

  Values:
    - Circuit = 0
    - Spare = 1
    - Space = 2

--------------------------------------------------------------------------------

[CLASS] Conduit
Full Name: Autodesk.Revit.DB.Electrical.Conduit
Description: This class represents a conduit in Autodesk Revit.
Inherits: CableTrayConduitBase

  METHODS:
    static Conduit Create(Document document, ElementId conduitType, XYZ startPoint, XYZ endPoint, ElementId levelId)
      Description: Creates a new instance of conduit.
      @document: The document.
      @conduitType: The conduit type. This must be a conduit type accepted by isValidConduitType(). If the input conduit type is InvalidElementId, the default conduit type from the document will be used.
      @startPoint: The start point of the conduit location line.
      @endPoint: The end point of the conduit location line.
      @levelId: The element id of the level which this conduit based. If the input level id is invalidElementId = -1, the nearest level will be used.
      Returns: The newly created conduit.
      Throws ArgumentException: This conduit type is invalid. -or- This level id is invalid. -or- The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static bool IsValidConduitType(Document document, ElementId conduitType)
      Description: Identifies if a conduit type is valid.
      @document: The document.
      @conduitType: The conduit type.
      Returns: True if the conduit type is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ConduitRun
Full Name: Autodesk.Revit.DB.Electrical.ConduitRun
Description: This class represents a conduit run in Autodesk Revit.
Remarks: This class is mainly for calculating length of a conduit run. A conduit run contains connected straight conduit segments and bends between the straight segments with same type and size.
Inherits: CableTrayConduitRunBase

--------------------------------------------------------------------------------

[CLASS] ConduitSettings
Full Name: Autodesk.Revit.DB.Electrical.ConduitSettings
Description: The conduit settings.
Inherits: Element

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
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ConduitSize
Full Name: Autodesk.Revit.DB.Electrical.ConduitSize
Description: Stores the basic size information for a conduit.
Implements: IDisposable

  CONSTRUCTORS:
    new ConduitSize(double nominalDiameter, double innerDiameter, double outerDiameter, double bendRadius, bool usedInSizeLists, bool usedInSizing)
      Description: Constructs an object that stores the basic size information for conduit.
      @nominalDiameter: Nominal diameter. The value should be a valid, positive Revit length.
      @innerDiameter: Inner diameter. The value should be a valid, positive Revit length.
      @outerDiameter: Outer diameter. The value should be a valid, positive Revit length.
      @bendRadius: Minimum bend radius. The value should be a valid, positive Revit length.
      @usedInSizeLists: Whether it is used in size lists.
      @usedInSizing: Whether is used in sizing.
      Throws ArgumentOutOfRangeException: The given value for nominalDiameter must be greater than 0 and no more than 30000 feet. -or- The given value for innerDiameter must be greater than 0 and no more than 30000 feet. -or- The given value for outerDiameter must be greater than 0 and no more than 30000 feet. -or- The given value for bendRadius must be greater than 0 and no more than 30000 feet.

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
Implements: IEnumerator<ConduitSize>, IDisposable, IEnumerator

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
      Throws InvalidOperationException: There is no current item in the iterator.
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
Implements: IEnumerable<ConduitSize>, IEnumerable, IDisposable

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
      Throws ArgumentOutOfRangeException: The given value for nominalDiameter must be greater than 0 and no more than 30000 feet.
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
Implements: IEnumerator<KeyValuePair<string, ConduitSizes>>, IDisposable, IEnumerator

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
Implements: IEnumerable<KeyValuePair<string, ConduitSizes>>, IEnumerable

  METHODS:
    void AddSize(string standardName, ConduitSize sizeInfo)
      Description: Inserts a new ConduitSize in to the conduit size settings. The conduit standard name determines the location of the new size in the size table.
      @standardName: The conduit standard name.
      @sizeInfo: The new ConduitSize to be added.
      Throws ArgumentException: The conduit standard name does not exist. -or- The conduit size already exists.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The function is called during iterating the size set.
    bool CreateConduitStandardTypeFromExisingStandardType(Document pADoc, string newStandardName, string existingStandardName)
      Description: Creates one conduit standard type with the new name and assign the conduit sizes to it from the existing standard type.
      @pADoc: The document.
      @newStandardName: The new conduit standard name.
      @existingStandardName: The existing conduit standard name.
      Returns: True if creating success; otherwise false.
      Throws ArgumentException: The conduit standard name already exists. -or- The conduit standard name does not exist.
      Throws ArgumentNullException: A non-optional argument was null
    bool DoesConduitStandardTypeExist(string standardName)
      Description: Checks if the specified conduit standard exist.
      @standardName: The conduit standard name.
      Throws ArgumentNullException: A non-optional argument was null
    static ConduitSizeSettings GetConduitSizeSettings(Document aDoc)
      Description: Gets the conduit size settings of the project.
      @aDoc: The document.
      Returns: The conduit size settings of the project.
      Throws ArgumentNullException: A non-optional argument was null
    ConduitSizeSettingIterator GetConduitSizeSettingsIterator()
      Description: Returns a ConduitSizeSettingIterator to the conduit size settings.
    IEnumerator<KeyValuePair<string, ConduitSizes>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    int GetSizeCount(string standardName)
      Description: Gets the size count of the conduit size table. The conduit standard name the location of the size in the size table.
      @standardName: The conduit standard name.
      Throws ArgumentNullException: A non-optional argument was null
    bool RemoveConduitStandardType(Document pADoc, string standardName)
      Description: Erases the existing ConduitSizes with this conduit standard name; the consuit standard type can not be removed if it is in use.
      @pADoc: The document.
      @standardName: The conduit standard name.
      Returns: True if removing success; otherwise false.
      Throws ArgumentException: The conduit standard is already in use. -or- The conduit standard is the last one.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveSize(string standardName, double nominalDiameter)
      Description: Erase the existing ConduitSize with this nominal diameter. The conduit standard name determines the location of the size in the size table.
      @standardName: The conduit standard name.
      @nominalDiameter: Nominal diameter.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for nominalDiameter must be greater than 0 and no more than 30000 feet.
      Throws InvalidOperationException: The function is called during iterating the size set.

--------------------------------------------------------------------------------

[CLASS] ConduitType
Full Name: Autodesk.Revit.DB.Electrical.ConduitType
Description: This class represents a conduit type in Autodesk Revit.
Inherits: MEPCurveType

  PROPERTIES:
    bool IsWithFitting { get; }
      Description: Whether this conduit type is with fitting

--------------------------------------------------------------------------------

[CLASS] CorrectionFactor
Full Name: Autodesk.Revit.DB.Electrical.CorrectionFactor
Description: Represents electrical correction factor information.
Remarks: Correction factor is defined based on corresponding wire material type and temperature rating type.
Inherits: APIObject

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
Implements: IEnumerable

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
Implements: IEnumerator

  CONSTRUCTORS:
    new CorrectionFactorSetIterator()
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

[CLASS] DistributionSysType
Full Name: Autodesk.Revit.DB.Electrical.DistributionSysType
Description: Represents a specific type of distribution system.
Inherits: ElementType

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
Implements: IEnumerable

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
Implements: IEnumerator

  CONSTRUCTORS:
    new DistributionSysTypeSetIterator()
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

[CLASS] ElectricalAnalyticalLoadSet
Full Name: Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet
Description: Represents the electrical analytical load set, it can contain a set of Electrical Analytical Equipment Loads.
Inherits: Element

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
      Throws ArgumentException: document is not a project document. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ISet<ElementId> GetLoadIds()
      Description: Gets Equipment Load ids in the LoadSet.
      Returns: The Equipment Load ids.

--------------------------------------------------------------------------------

[CLASS] ElectricalAnalyticalNode
Full Name: Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode
Description: Represents an electrical analytical node under the Analytical Power Distribution in the System Browser.
Remarks: This represents one of any number of types, as specified by the ElectricalAnalyticalNodeType. Some of those types will have AnalyticalDistributionNodePropertyData while others will not, and if they do have data they can be downcast to a specific subclass of data to be used.
Inherits: Element

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
      Throws ArgumentNullException: A non-optional argument was null
    bool CanDisconnectFromUpstreamNode(ElementId upstreamNodeId)
      Description: Verifies that the current node can disconnect from the upstream node.
      @upstreamNodeId: The upstream node id.
      Returns: True if the current node can disconnect from the upstream node.
      Throws ArgumentNullException: A non-optional argument was null
    void ConnectToUpstreamNode(ElementId upstreamNodeId)
      Description: Connects to upstream node.
      @upstreamNodeId: The upstream node id.
      Throws ArgumentException: The id is not an analytical distribution node id. -or- The analytical distribution node is full of downstream nodes. -or- The analytical distribution node can not connect to the upstream node.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The analytical distribution node is full of upstream nodes.
    static ElectricalAnalyticalNode Create(Document document, ElectricalAnalyticalNodeType type, string name)
      Description: Creates an electrical analytical node.
      @document: The document where the new element will be created.
      @type: The type of electrical analytical node to be created.
      @name: The name of new electrical analytical node. The actual name may be post-fixed if already exists.
      Returns: The newly created electrical analytical node.
      Throws ArgumentException: document is not a project document. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void DisconnectFromUpstreamNode(ElementId upstreamNodeId)
      Description: Disconnects from upstream node.
      @upstreamNodeId: The upstream node id to disconnect from.
      Throws ArgumentException: The id is not an analytical distribution node id. -or- The analytical distribution node can not disconnect from the upstream node.
      Throws ArgumentNullException: A non-optional argument was null
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

  Values:
    - PowerSource = 0
    - Bus = 1
    - Transformer = 2
    - TransferSwitch = 3
    - EquipmentLoad = 4

--------------------------------------------------------------------------------

[ENUM] ElectricalCircuitPathMode
Full Name: Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode
Description: An enumerated type indicates the circuit path mode
Inherits: Enum

  Values:
    - Custom = 0
    - FarthestDevice = 1
    - AllDevices = 2

--------------------------------------------------------------------------------

[ENUM] ElectricalConnectedPhases
Full Name: Autodesk.Revit.DB.Electrical.ElectricalConnectedPhases
Description: The electrical connected phases of an electrical analytical node.
Inherits: Enum

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

--------------------------------------------------------------------------------

[CLASS] ElectricalDemandFactorDefinition
Full Name: Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition
Description: The ElectricalDemandFactorDef class represents a serialized version of an instance of demand factor definition. It has a name, rule type, and values for the rules that are serialized.
Inherits: Element

  CONSTRUCTORS:
    new ElectricalDemandFactorDefinition()
      Description: Constructs a new ElectricalDemandFactorDefinition with default settings.

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
      Throws ArgumentNullException: A non-optional argument was null
    void ClearValues()
      Description: Clears all the values stored for this demand factor definition.
    static ElectricalDemandFactorDefinition Create(Document ADoc, string strName)
      Description: Creates a new instance of a demand factor definition.
      @ADoc: The document where the element will be created and added.
      @strName: The name of the electrical demand factor definition to be created.
      Returns: The newly created demand factor definition element.
      Throws ArgumentNullException: A non-optional argument was null
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
      Throws ArgumentNullException: A non-optional argument was null
    void SetValues(ICollection<ElectricalDemandFactorValue> values)
      Description: Sets the value set to the demand factor definition.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ElectricalDemandFactorRule
Full Name: Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule
Description: This enum describes the different demand factor rule types available to the application. Within a demand factor a rule will be referenced and the user will have to enter values corresponding to that rule.
Inherits: Enum

  Values:
    - Constant = 0
    - QuantityTable = 1
    - LoadTable = 2
    - QuantityTablePerPortion = 3
    - LoadTablePerPortion = 4

--------------------------------------------------------------------------------

[CLASS] ElectricalDemandFactorValue
Full Name: Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue
Description: This class represents values used by a particular demand factor definition. Each instance corresponds to a row in a table of values. These values are part of the ElectricalDemandFactorDefinition class.
Implements: IDisposable

  CONSTRUCTORS:
    new ElectricalDemandFactorValue(double minRange, double maxRange, double factor)
      Description: Constructor. Initializes factor, minimum range and maximum range to values passed in.
    new ElectricalDemandFactorValue()
      Description: Default constructor. Initializes factor to 1.0 or 100%. Min and max range are set to 0.0

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
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidDistributionSystem(DistributionSysType distributionSystem)
      Description: Verifies that the Distribution System can be assigned to the Electrical Equipment.
      @distributionSystem: The Distribution System to be checked.
      Returns: True if the Distribution System can be assigned to the Electrical Equipment.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCircuitNamingSchemeType(CircuitNaming circuitNamingType)
      Description: Sets the circuit naming scheme for Electrical Equipment.
      @circuitNamingType: The enumerated type of circuit naming scheme to be set.
      Throws ArgumentException: The circuit naming scheme enumerated type is invalid for the Electrical Equipment.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] ElectricalLoadAreaData
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadAreaData
Description: Represents the electrical load area data.
Inherits: SpatialElementDomainData

  METHODS:
    static ISet<ElementId> CreateElectricalLoadAreas(Document doc, ElementId levelId, ElementId phaseId)
      Description: Creates electrical load areas on all the empty plan circuits of the given level.
      @doc: The document where the created electrical load areas are.
      @levelId: The base level on which the created electrical load areas exist.
      @phaseId: The associated phase in which the created electrical load areas exist.
      Returns: The created electrical load areas.
      Throws ArgumentException: doc is not a project document. -or- The ElementId levelId is not a Level. -or- The id does not represent a valid phase.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ISet<ElementId> GetAreaBasedLoadIds()
      Description: Gets the area based load ids of the electrical load area to be included.
    static bool HasCircuitsWithoutElectricalLoadAreas(Document doc, ElementId levelId, ElementId phaseId)
      Description: Checks whether there are any empty plan circuits in which there are no electrical load areas.
      @doc: The document to check.
      @levelId: The base level on which the empty plan circuits to check.
      @phaseId: The associated phase in which the empty plan circuits to check.
      Returns: True if there are empty plan circuits in which there are no electrical load areas, false otherwise.
      Throws ArgumentException: doc is not a project document. -or- The ElementId levelId is not a Level. -or- The id does not represent a valid phase.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).

--------------------------------------------------------------------------------

[CLASS] ElectricalLoadClassification
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadClassification
Description: The ElectricalLoadClassification class represents a serialized version of an instance of load classification.
Inherits: Element

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
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ElectricalLoadClassificationData
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationData
Description: This enum is used by the ElectricalLoadClassification class as additional data whenever data members changed. It is used as the additional data when the atom corresponding to each data member is touched.
Inherits: Enum

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

--------------------------------------------------------------------------------

[ENUM] ElectricalLoadClassificationSpace
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationSpace
Description: This enum is used by the ElectricalLoadClassification to specify the load class for use with spaces.
Inherits: Enum

  Values:
    - None = 0
    - Lighting = 1
    - Power = 2

--------------------------------------------------------------------------------

[ENUM] ElectricalLoadType
Full Name: Autodesk.Revit.DB.Electrical.ElectricalLoadType
Description: Represents the electrical load type.
Inherits: Enum

  Values:
    - EquipmentLoad = 0
    - AreaBasedLoad = 1

--------------------------------------------------------------------------------

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

  Values:
    - SinglePhase = 0
    - ThreePhase = 1

--------------------------------------------------------------------------------

[ENUM] ElectricalPhaseConfiguration
Full Name: Autodesk.Revit.DB.Electrical.ElectricalPhaseConfiguration
Description: An enumerated type to specify the electrical phase configuration.
Inherits: Enum

  Values:
    - Undefined = 0
    - Wye = 1
    - Delta = 2

--------------------------------------------------------------------------------

[ENUM] ElectricalPhaseLine
Full Name: Autodesk.Revit.DB.Electrical.ElectricalPhaseLine
Description: This attribute defines the electrical phase.
Inherits: Enum

  Values:
    - A = 0
    - B = 1
    - C = 2
    - Invalid = -1

--------------------------------------------------------------------------------

[CLASS] ElectricalSetting
Full Name: Autodesk.Revit.DB.Electrical.ElectricalSetting
Description: The ElectricalSetting class represents an instance of element of electrical settings.
Inherits: Element

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
      Throws ArgumentException: The name can't be , empty string, or equal with any existing one, phaseConfig should be defined and numWire can only be 3 or 4 in case of three phase, numWire can only be 2 or 3 in case of single phase, otherwise exception will be thrown.
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
      Throws ArgumentNullException: A non-optional argument was null
    static ElectricalSetting GetElectricalSettings(Document document)
      Description: Get the electrical settings of the project.
      @document: The document.
      Returns: The electrical settings of the project.
      Throws ArgumentNullException: A non-optional argument was null
    IList<double> GetSpecificFittingAngles()
      Description: Gets the list of specific fitting angles.
      Returns: Angles (in degrees).
    bool GetSpecificFittingAngleStatus(double angle)
      Description: Gets the status of given specific fitting angle.
      @angle: The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      Throws ArgumentOutOfRangeException: The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.
    bool IsValidSpecificFittingAngle(double angle)
      Description: Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      @angle: The angle value (in degree).
      Returns: True if the given value is a valid specific fitting angle.
    void RemoveDistributionSysType(DistributionSysType distributionSysType)
      Description: Remove an existing distribution system type from the project.
      Throws InvalidOperationException: Distribution system type can be removed only if it is not currently assigned to any devices, otherwise an exception will be thrown.
    void RemoveVoltageType(VoltageType voltageType)
      Description: Remove the voltage type from project.
      @voltageType: Specify the voltage type to be removed.
      Throws InvalidOperationException: Voltage type can be removed only if it isn't in service with any distribution systems.
    void RemoveWireMaterialType(WireMaterialType materialType)
      Description: Remove the wire material type from project.
      @materialType: The wire material type to be removed.
      Throws InvalidOperationException: Wire material type can be removed only if it is not currently assigned to any wire type, and the last one wire material type can't be removed, otherwise an exception will be thrown.
    void RemoveWireType(WireType wireType)
      Description: Remove wire type definition from project.
      Throws InvalidOperationException: Wire type can be removed only if it is not used, otherwise an exception will be thrown.
    void SetSpecificFittingAngleStatus(double angle, bool bStatus)
      Description: Sets the status of given specific angle.
      @angle: The specific angle (in degree) that must be 60, 45, 30, 22.5 or 11.25 degrees.
      @bStatus: Status, true - using the given angle during the pipe layout.
      Throws ArgumentOutOfRangeException: The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.
      Throws InvalidOperationException: Can not set an angle status for an invalid angle.

--------------------------------------------------------------------------------

[CLASS] ElectricalSystem
Full Name: Autodesk.Revit.DB.Electrical.ElectricalSystem
Description: Provides access to the Electrical System in Autodesk Revit MEP.
Remarks: The Electrical System object can only be queried in Autodesk Revit MEP.
Inherits: MEPSystem

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
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static ElectricalSystem Create(Document document, IList<ElementId> electComponents, ElectricalSystemType elecSysType)
      Description: Creates a new MEP Electrical System element from a set of electrical components.
      @document: The Document.
      @electComponents: The electrical components in this system.
      @elecSysType: The System Type of electrical system.
      Returns: If successful a new MEP Electrical System element within the project, otherwise .
      Throws ArgumentException: There should be at least one component that can create the specified circuit type
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void DisconnectPanel()
      Description: Disconnect the panel for the Electrical System.
      Throws InvalidOperationException: Thrown when the panel cannot be disconnected for the electrical system.
    IList<XYZ> GetCircuitPath()
      Description: Gets the list of the electrical system circuit path node position.
      Returns: The list of the electrical system circuit path node position.
    bool IsCircuitPathValid(IList<XYZ> nodes)
      Description: Checks whether the list of the electrical system circuit path node position is valid.
      @nodes: The list of the electrical system circuit path node position.
      Throws ArgumentNullException: A non-optional argument was null
    WireSet NewWires(View view, WiringType wiringType)
      Description: Create a bunch of wires for the electrical system.
      @view: The view in which the wire is to be visible.
      @wiringType: Specify the wiring type (Arc or Chamfer) that is to be applied to all newly created wires.
      Returns: New created wires
      Throws ArgumentException: This method can only be used to create a bunch of wires according to specific pairs of elements, so if there exists a element in any pair of familyInstancePairs, the exception will be thrown.
    void RemoveFromCircuit(ElementSet components)
      Description: remove a set of exist components from the Electrical System.
      @components: The components removed from the electrical system.
      Throws ArgumentNullException: Thrown when the components parameter Value is .
      Throws InvalidOperationException: Thrown when the components cannot be removed from the system.
    void SelectPanel(FamilyInstance panel)
      Description: Set the panel for the Electrical System.
      @panel: The panel of the electrical system.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The panel does not have enough slots and Feed Through Lugs is unchecked or already in use. -or- Thrown when the panel cannot be set for the electrical system.
    void SetCircuitPath(IList<XYZ> nodes)
      Description: Sets the electrical system circuit path by the list of node position.
      @nodes: The list of the circuit path node position.
      Throws ArgumentException: The list of the electrical system circuit path node position is not valid. The length of the list should be more than one, the first node should be the position of the panel where the circuit begins at, the adjacent nodes should not be too close, and should be in the same level or on the same vertical line, to keep each segment of the circuit path always horizontal or vertical. Also note that the first node position should be the position of the connector (the one connects to the circuit) of the panel, but not the origin of the panel instance.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ElectricalSystemType
Full Name: Autodesk.Revit.DB.Electrical.ElectricalSystemType
Description: An enumerated type listing all the possible electrical system types for a connector object.
Inherits: Enum

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

--------------------------------------------------------------------------------

