# Autodesk.Revit.DB.Mechanical

NAMESPACE: Autodesk.Revit.DB.Mechanical
--------------------------------------------------------------------------------

[ENUM] AirCoolingCoilType
Full Name: Autodesk.Revit.DB.Mechanical.AirCoolingCoilType
Description: The type of air cooling coil.
Inherits: Enum

  Values:
    - None = 0
    - ChilledWater = 1
    - DirectExpansion = 2

--------------------------------------------------------------------------------

[ENUM] AirFanType
Full Name: Autodesk.Revit.DB.Mechanical.AirFanType
Description: The type of air fan.
Inherits: Enum

  Values:
    - ConstantVolume = 0
    - VariableVolume = 1

--------------------------------------------------------------------------------

[ENUM] AirHeatExchangerType
Full Name: Autodesk.Revit.DB.Mechanical.AirHeatExchangerType
Description: The type of air loop.
Inherits: Enum

  Values:
    - None = 0
    - Enthalpy = 1
    - Sensible = 2

--------------------------------------------------------------------------------

[ENUM] AirHeatingCoilType
Full Name: Autodesk.Revit.DB.Mechanical.AirHeatingCoilType
Description: The type of air heating coil.
Inherits: Enum

  Values:
    - None = 0
    - ElectricResistance = 1
    - Furnace = 2
    - HotWater = 3

--------------------------------------------------------------------------------

[CLASS] AirSystemData
Full Name: Autodesk.Revit.DB.Mechanical.AirSystemData
Description: Represents the data and parameter of analytical air system.
Implements: IDisposable

  PROPERTIES:
    AirFanType AirFanType { get; set; }
      Description: The fan type.
    ElementId ChilledWaterLoopId { get; set; }
      Description: The chilled water loop used for the chilled water option of cooling coil.
    AirCoolingCoilType CoolingCoilType { get; set; }
      Description: The cooling coil type. Note this property change would reset the chilled water loop.
    AirHeatExchangerType HeatExchangerType { get; set; }
      Description: The type of heat exchanger.
    AirHeatingCoilType HeatingCoilType { get; set; }
      Description: The heating coil type. Note this property change would reset the heating water loop.
    ElementId HeatingHotWaterLoopId { get; set; }
      Description: The water loop element id for the hot-water heating coil.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    AirHeatingCoilType PreheatCoilType { get; set; }
      Description: The preheat coil type. Note this property change would reset the preheat water loop.
    ElementId PreheatHotWaterLoopId { get; set; }
      Description: The water loop element id for the hot-water preheat coil.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] AnalyticalSystemDomain
Full Name: Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain
Description: The domain type of analytical system.
Inherits: Enum

  Values:
    - WaterLoop = 0
    - AirSystem = 1
    - ElectricalSystem = 2

--------------------------------------------------------------------------------

[ENUM] ComponentClassification
Full Name: Autodesk.Revit.DB.Mechanical.ComponentClassification
Description: An enumerated type lists all MEP component classification. This attribute describes the general purpose of the MEP part component, that is used for scheduling, tagging, filter, ODBC, and etc. One component classification may include more than one part type.
Inherits: Enum

  Values:
    - Undefined = 0
    - Pipe = 1
    - Duct = 2
    - FlexPipe = 11
    - FlexDuct = 12
    - Elbow = 101
    - Tee = 102
    - Tap = 103
    - Transition = 104
    - Cross = 105
    - Endcap = 106
    - Coupling = 107
    - Union = 108
    - Flange = 109
    - Wye = 110
    - Valve = 111
    - Sensor = 112
    - Hanger = 113
    - Sleeve = 114

--------------------------------------------------------------------------------

[ENUM] ConditionType
Full Name: Autodesk.Revit.DB.Mechanical.ConditionType
Description: An enumerated type listing all the possible condition types for a space object.
Inherits: Enum

  Values:
    - Heated = 0
    - Cooled = 1
    - HeatedAndCooled = 2
    - Unconditioned = 3
    - Vented = 4
    - NaturallyVentedOnly = 5
    - NoOfConditionTypes = 6

--------------------------------------------------------------------------------

[CLASS] Duct
Full Name: Autodesk.Revit.DB.Mechanical.Duct
Description: A duct in the Autodesk Revit MEP product.
Remarks: The duct is only available in the Autodesk Revit MEP product.
Inherits: MEPCurve

  PROPERTIES:
    DuctType DuctType { get; set; }
      Description: The duct type of this duct.
    bool IsPlaceholder { get; }
      Description: Identifies if the duct is a placeholder or not.

  METHODS:
    static Duct Create(Document document, ElementId ductTypeId, ElementId levelId, Connector startConnector, Connector endConnector)
      Description: Creates a new duct that connects to two connectors.
      @document: The document.
      @ductTypeId: The ElementId of the new duct type.
      @levelId: The level ElementId for the new duct.
      @startConnector: The first connector where the new duct starts.
      @endConnector: The second point of the new duct.
      Returns: The created duct.
      Throws ArgumentException: The duct type ductTypeId is not valid duct type. -or- The ElementId levelId is not a Level. -or- The connector's domain is not Domain.â€‹DomainHvac. -or- The points of startConnector and endConnector are too close: for MEPCurve, the minimum length is 1/10 inch.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Thrown when the new duct fails to connect with the connector.
    static Duct Create(Document document, ElementId ductTypeId, ElementId levelId, Connector startConnector, XYZ endPoint)
      Description: Creates a new duct that connects to the connector.
      @document: The document.
      @ductTypeId: The ElementId of the new duct type.
      @levelId: The level id for the new duct.
      @startConnector: The first connector where the new duct starts.
      @endPoint: The second point of the new duct.
      Returns: The created duct.
      Throws ArgumentException: The duct type ductTypeId is not valid duct type. -or- The ElementId levelId is not a Level. -or- The connector's domain is not Domain.â€‹DomainHvac. -or- The points of startConnector and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Thrown when the new duct fails to connect with the connector.
    static Duct Create(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, XYZ startPoint, XYZ endPoint)
      Description: Creates a new duct from two points.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the duct type.
      @levelId: The level ElementId for the duct.
      @startPoint: The start point of the duct.
      @endPoint: The end point of the duct.
      Returns: The created duct.
      Throws ArgumentException: The systemTypeId is not valid HVAC system type. -or- The duct type ductTypeId is not valid duct type. -or- The ElementId levelId is not a Level. -or- The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.
      Throws ArgumentNullException: A non-optional argument was null
    static Duct CreatePlaceholder(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, XYZ startPoint, XYZ endPoint)
      Description: Creates a new placeholder duct.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the duct type.
      @levelId: The level id for the duct.
      @startPoint: The first point of the placeholder line.
      @endPoint: The second point of the placeholder line.
      Returns: The created placeholder duct.
      Throws ArgumentException: The systemTypeId is not valid HVAC system type. -or- The duct type ductTypeId is not valid duct type. -or- The ElementId levelId is not a Level. -or- The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsDuctTypeId(Document document, ElementId ductTypeId)
      Description: Checks if given type is valid duct type.
      @document: The document.
      @ductTypeId: ElementId of the duct type to check.
      Returns: True if duct type can used for this duct, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsHvacSystemTypeId(Document document, ElementId systemTypeId)
      Description: Checks if given type is valid HVAC system type.
      @document: The document.
      @systemTypeId: ElementId of the HVAC system type to check.
      Returns: True if the given systemTypeId is the HVAC system type, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetSystemType(ElementId systemTypeId)
      Description: Updates the associated system type for the duct.
      @systemTypeId: The ElementId of the hvac system type.
      Throws ArgumentException: The systemTypeId is not valid HVAC system type.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DuctFittingAndAccessoryConnectorData
Full Name: Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryConnectorData
Description: The input data used by external servers for calculation of the duct fitting and duct accessory coefficient.
Remarks: width, height, diameter, flow, velocity pressure and connector index are input data for the calculation,
Implements: IDisposable

  PROPERTIES:
    double Angle { get; }
      Description: the angle of the fitting, Units:(rad).
    double Diameter { get; }
      Description: The connector diameter, Units:(ft).
    double Flow { get; }
      Description: The connector flow, Units:(ftÂ³/s)
    FlowDirectionType FlowDirection { get; }
      Description: the flow direction of this connector, In or Out.
    double Height { get; }
      Description: The connector height, Units:(ft).
    int Index { get; }
      Description: return the index of this connector
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int LinkIndex { get; }
      Description: the index of the connector which is linked with this connector
    ConnectorProfileType Profile { get; }
      Description: The connector profile.
    double VelocityPressure { get; }
      Description: The connector velocity pressure. Units: (kg/(ftÂ·sÂ²)).
    double Width { get; }
      Description: The connector width, Units:(ft).

  METHODS:
    void Dispose()
    Transform GetCoordination()
      Description: Gets the coordination of the connector
      Returns: The coordination of the connector

--------------------------------------------------------------------------------

[CLASS] DuctFittingAndAccessoryData
Full Name: Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryData
Description: The input data used by external servers for calculation of the duct fitting and duct accessory coefficient.
Remarks: A FamilyInstance is the input data for the calculation,
Implements: IDisposable

  PROPERTIES:
    double Density { get; }
      Description: The air density for the duct fitting or duct accessory, Units: kg/ft^3.
    double DynamicViscosity { get; }
      Description: The dynamic viscosity of air for the duct fitting or duct accessory, Units: (kg/(ftÂ·s)).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Origin { get; }
      Description: The origin position of the duct fitting or duct accessory.
    PartType PartType { get; }
      Description: The part type of the duct fitting or duct accessory.
    Guid ServerGUID { get; }
      Description: The GUID of the duct fitting or duct accessory.
    MEPSystemClassification SystemClassification { get; }
      Description: The system classification of the duct fitting or duct accessory.

  METHODS:
    void Dispose()
    IList<DuctFittingAndAccessoryConnectorData> GetAllConnectorData()
      Description: Gets the connector data of the pipe fitting or pipe accessory.
      Returns: All connector data.
    Entity GetEntity()
      Description: Returns an Entity of the Schema of the serverGUID. or an invalid entity otherwise.
      Returns: The Entity.
    ElementId GetFamilyInstanceId()
      Description: Gets the Id of the fiting or accessory instance
      Returns: The element Id of the fiting or accessory instance.

--------------------------------------------------------------------------------

[CLASS] DuctFittingAndAccessoryPressureDropData
Full Name: Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData
Description: The input and output data used by external servers for calculation of the duct fitting and duct accessory pressure drop.
Implements: IDisposable

  PROPERTIES:
    int CalculationType { get; }
      Description: The calculation type, a bitmask of FittingAndAccessoryCalculationType.
    bool IsCurrentEntityValid { get; set; }
      Description: True if the current settings stored in the entity is valid.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    DuctFittingAndAccessoryData GetDuctFittingAndAccessoryData()
      Description: Returns the fitting and accessory information.
    IList<DuctFittingAndAccessoryPressureDropItem> GetPresureDropItems()
      Description: Returns the pressure drop items.
    void SetDefaultEntity(Entity defaultEntity)
      Description: Stores the default entity in the data.
      @defaultEntity: The Entity to be stored.
      Throws ArgumentException: Writing of Entities of this Schema is not allowed to the current add-in.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] DuctFittingAndAccessoryPressureDropItem
Full Name: Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem
Description: A flow path of the duct/pipe fitting and accessory. It is defined by the begin connector and end connector.
Implements: IDisposable

  PROPERTIES:
    int BeginConnectorIndex { get; }
      Description: The index of the begin connector of the flow path.
    double Coefficient { get; set; }
      Description: The coefficient between the begin connector and end connector, unitless.
    int EndConnectorIndex { get; }
      Description: The index of the end conector of the flow path.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double VelocityPressure { get; }
      Description: The velocity pressure, for converting between coefficient and pressure drop on this flow path. Units: (kg/(ftÂ·sÂ²)).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] DuctFlowConfigurationType
Full Name: Autodesk.Revit.DB.Mechanical.DuctFlowConfigurationType
Description: An enumerated type listing all duct flow configuration types for a connector.
Inherits: Enum

  Values:
    - Calculated = 0
    - Preset = 1
    - System = 2

--------------------------------------------------------------------------------

[CLASS] DuctInsulation
Full Name: Autodesk.Revit.DB.Mechanical.DuctInsulation
Description: Represents insulation applied to the outside of a given duct , fitting or accessory.
Inherits: InsulationLiningBase

  METHODS:
    static DuctInsulation Create(Document document, ElementId ductOrContentElementId, ElementId ductInsulationTypeId, double Thickness)
      Description: Creates a new instance of duct insulation.
      @document: The document.
      @ductOrContentElementId: The duct , fitting or accessory ElementId to which insulation will be added.
      @ductInsulationTypeId: The duct insulation type. If the input duct insulation type is InvalidElementId, the default insulation type from the document will be used.
      @Thickness: The thickness of the insulation.
      Returns: The newly created duct insulation.
      Throws ArgumentException: This id does not represent a duct, fitting, or accessory element. -or- This duct insulation type is invalid. -or- Thickness is not valid for assignment to insulation or lining elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] DuctInsulationType
Full Name: Autodesk.Revit.DB.Mechanical.DuctInsulationType
Description: This class represents a duct insulation type in Autodesk Revit.
Inherits: ElementType

--------------------------------------------------------------------------------

[CLASS] DuctLining
Full Name: Autodesk.Revit.DB.Mechanical.DuctLining
Description: Represents Lining applied to the inside of a given duct, fitting or accessory.
Inherits: InsulationLiningBase

  METHODS:
    static DuctLining Create(Document document, ElementId ductOrContentElementId, ElementId ductLiningTypeId, double Thickness)
      Description: Creates a new instance of duct lining.
      @document: The document.
      @ductOrContentElementId: The duct, fitting or accessory ElementId to which lining will be added.
      @ductLiningTypeId: The duct lining type. If the input duct lining type is InvalidElementId, the default lining type from the document will be used.
      @Thickness: The thickness of the lining.
      Returns: The newly created duct lining.
      Throws ArgumentException: This id does not represent a duct, fitting, or accessory element. -or- This duct Lining type is invalid. -or- Thickness is not valid for assignment to insulation or lining elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] DuctLiningType
Full Name: Autodesk.Revit.DB.Mechanical.DuctLiningType
Description: This class represents a duct lining type in Autodesk Revit.
Inherits: ElementType

  PROPERTIES:
    double Roughness { get; set; }
      Description: The roughness of Duct Lining.

  METHODS:
    bool IsValidRoughness(double roughness)
      Description: Identifies if the input roughness is valid.
      @roughness: The roughness to check.
      Returns: True if the value is acceptable, false otherwise.

--------------------------------------------------------------------------------

[ENUM] DuctLossMethodType
Full Name: Autodesk.Revit.DB.Mechanical.DuctLossMethodType
Description: An enumerated type listing all duct loss calculation methods for a connector.
Inherits: Enum

  Values:
    - NotDefined = 0
    - SpecificLoss = 4
    - Coefficient = 6

--------------------------------------------------------------------------------

[CLASS] DuctPressureDropData
Full Name: Autodesk.Revit.DB.Mechanical.DuctPressureDropData
Description: The input and output data used by external servers for calculation of the duct pressure drop.
Remarks: Profile type, Height, Diameter for round profile or width for other profiles, Length, Density, Viscosity, Roughness and Flow are input field values for the calculation. HydraulicDiameter, ReynoldsNumber, Velocity, VelocityPressure, Friction, PressureDrop, and Coefficient are output field values for the calculation
Implements: IDisposable

  PROPERTIES:
    ElementId CategoryId { get; }
      Description: The category id of duct curves. It will be OST_DuctCurves, OST_FlexDuctCurves, or OST_PlaceHolderDucts.
    double Coefficient { get; set; }
      Description: The coefficient of the duct.
    double Density { get; }
      Description: The density of the duct. Units: (kg/ftÂ³).
    double DynamicViscosity { get; }
      Description: The dynamic viscosity of the air in the duct. Units: (kg/(ft*s)).
    double Flow { get; }
      Description: The flow of the duct. Units: (ftÂ³/s).
    double Friction { get; set; }
      Description: The friction of the duct. Units: (kg/(ftÂ²Â·sÂ²)).
    double Height { get; }
      Description: The height of the duct. If the duct is round, it will be equal to the diameter of the duct. Units: (ft).
    double HydraulicDiameter { get; set; }
      Description: The hydraulic diameter of the duct. Units: (ft).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Length { get; }
      Description: The length of the duct. Units: (ft).
    SystemCalculationLevel Level { get; }
      Description: The calculation level of the system.
    double PressureDrop { get; set; }
      Description: The pressure drop of the duct. Units: (kg/(ftÂ·sÂ²)).
    double ReynoldsNumber { get; set; }
      Description: The reynolds number of the duct.
    double Roughness { get; }
      Description: The roughness of the duct. Units: (ft).
    ConnectorProfileType Shape { get; }
      Description: The profile type of the duct.
    double Velocity { get; set; }
      Description: The velocity of the duct. Units: (ft/s).
    double VelocityPressure { get; set; }
      Description: The velocity pressure of the duct. Units: (kg/(ftÂ·sÂ²)).
    double WidthOrDiameter { get; }
      Description: The diameter of the duct with round profile, or the width of the duct with other profiles. Units: (ft).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] DuctSettings
Full Name: Autodesk.Revit.DB.Mechanical.DuctSettings
Description: The duct setting class.
Inherits: Element

  PROPERTIES:
    double AirDensity { get; set; }
      Description: The air density in kg/ft^3.
    double AirDynamicViscosity { get; set; }
      Description: The dynamic viscosity of air in kg/(ft*s).
    string Centerline { get; set; }
      Description: The abbreviation of the Centerline (=) string.
    string ConnectorSeparator { get; set; }
      Description: The duct connector separator string.
    FittingAngleUsage FittingAngleUsage { get; set; }
      Description: Determine how to use fitting angle during duct layout or modifying layout.
    double FittingAnnotationSize { get; set; }
      Description: The value of fitting annotation size.
    string FlatOnBottom { get; set; }
      Description: The abbreviation of the Flat On Bottom (FOB) string.
    string FlatOnTop { get; set; }
      Description: The abbreviation of the Flat On Top (FOT) string.
    bool NetworkBasedCalculations { get; set; }
      Description: Indicates whether to enable network based calculations for duct networks.
    string OvalDuctSizeSeparator { get; set; }
      Description: The oval duct size separator string.
    string OvalDuctSizeSuffix { get; set; }
      Description: The oval duct size suffix string.
    string RectangularDuctSizeSeparator { get; set; }
      Description: The rectangular duct size separator string.
    string RectangularDuctSizeSuffix { get; set; }
      Description: The rectangular duct size suffix string.
    double RiseDropAnnotationSize { get; set; }
      Description: The rise drop annotation size.
    string RoundDuctSizePrefix { get; set; }
      Description: The round duct size prefix string.
    string RoundDuctSizeSuffix { get; set; }
      Description: The round duct size suffix string.
    string SetDown { get; set; }
      Description: The abbreviation of the Set Down from top (TD) of fitting string.
    string SetDownFromBottom { get; set; }
      Description: The abbreviation of the Set Down from bottom (BD) of fitting string.
    string SetUp { get; set; }
      Description: The abbreviation of the Set Up from top (TU) of fitting string.
    string SetUpFromBottom { get; set; }
      Description: The abbreviation of the Set Up from bottom (BU) of fitting string.
    bool UseAnnotationScaleForSingleLineFittings { get; set; }
      Description: Indicates whether use annotation scale for single line fittings or not.

  METHODS:
    static DuctSettings GetDuctSettings(Document document)
      Description: Get the duct settings of the project.
      @document: The document.
      Returns: The duct settings of the project.
      Throws ArgumentNullException: A non-optional argument was null
    MEPCalculationServerInfo GetPressLossCalculationServerInfo()
      Description: Get the MEPServerInfo of the current pipe pressure loss calculation server.
      Returns: The MEPServerInfo of the current pipe pressure loss calculation server
    IList<double> GetSpecificFittingAngles()
      Description: Gets the list of specific fitting angles.
      Returns: Angles (in degrees).
    bool GetSpecificFittingAngleStatus(double angle)
      Description: Gets the status of given specific angle.
      @angle: The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      Throws ArgumentOutOfRangeException: The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.
    static bool IsNetworkBasedCalculationsEnabled(Document document)
      Description: Indicates whether network based calculations for duct networks is enabled in the specified document.
      @document: The document.
      Returns: Returns true if network based calculations for duct networks is enabled, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidSpecificFittingAngle(double angle)
      Description: Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      @angle: The angle value (in degree).
      Returns: True if the given value is a valid specific fitting angle.
    void SetPressLossCalculationServerInfo(MEPCalculationServerInfo serverInfo)
      Description: Set the MEPServerInfo of the current pipe pressure loss calculation server.
      Throws ArgumentNullException: A non-optional argument was null
    void SetSpecificFittingAngleStatus(double angle, bool useInLayout)
      Description: Sets the status of given specific angle.
      @angle: The specific angle (in degree) that must be one of 60, 45, 30, 22.5 or 11.25 degrees.
      @useInLayout: Status, true - using the given angle during the duct layout.
      Throws ArgumentOutOfRangeException: The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.
      Throws InvalidOperationException: Can not set an angle status for an invalid angle.

--------------------------------------------------------------------------------

[ENUM] DuctShape
Full Name: Autodesk.Revit.DB.Mechanical.DuctShape
Description: Enumerated type listing possible shapes for ducts.
Inherits: Enum

  Values:
    - Round = 0
    - Rectangular = 1
    - Oval = 2

--------------------------------------------------------------------------------

[CLASS] DuctSizeIterator
Full Name: Autodesk.Revit.DB.Mechanical.DuctSizeIterator
Description: An iterator to a set of MEP duct sizes from DuctSizes.
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

[CLASS] DuctSizes
Full Name: Autodesk.Revit.DB.Mechanical.DuctSizes
Description: Class RbsDuctSizes being used to store the duct sizes
Implements: IEnumerable<MEPSize>, IEnumerable, IDisposable

  PROPERTIES:
    int Count { get; }
      Description: Count of the items contained in the collection.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool Contains(double nominalDiameter)
      Description: Checks whether a duct size with the nominal diameter exists.
      @nominalDiameter: Nominal diameter.
      Returns: True if a duct size with the nominal diameter exists.
    void Dispose()
    DuctSizeIterator GetDuctSizeIterator()
      Description: Returns a DuctSizeIterator that iterates through the collection.
      Returns: A DuctSizeIterator object that can be used to iterate through key-value pairs in the collection.
    IEnumerator<MEPSize> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.

--------------------------------------------------------------------------------

[CLASS] DuctSizeSettingIterator
Full Name: Autodesk.Revit.DB.Mechanical.DuctSizeSettingIterator
Description: An iterator to a set of items from DuctSizeSettings. Each item is a KeyValuePair(DuctShape::Enum, DuctSizes).
Implements: IEnumerator<KeyValuePair<DuctShape, DuctSizes>>, IDisposable, IEnumerator

  PROPERTIES:
    KeyValuePair<DuctShape, DuctSizes> Current { get; }
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

[CLASS] DuctSizeSettings
Full Name: Autodesk.Revit.DB.Mechanical.DuctSizeSettings
Description: Duct sizes settings
Inherits: Element
Implements: IEnumerable<KeyValuePair<DuctShape, DuctSizes>>, IEnumerable

  PROPERTIES:
    DuctSizes Item { get; }

  METHODS:
    void AddSize(DuctShape shape, MEPSize sizeInfo)
      Description: Inserts a new MEPSize in to the duct size settings. The duct shape determines the location of the new size in the size table.
      @shape: The shape of duct.
      @sizeInfo: The new MEPSize to be added.
      Throws ArgumentException: Throws if there is no size set determined by the duct shape or there is already the same size in the size set determined by the duct shape.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Throws if the function is called during iterating the size set.
    DuctSizeSettingIterator GetDuctSizeSettingIterator()
      Description: Returns a DuctSizeSettingIterator object that iterates through the collection.
      Returns: A DuctSizeSettingIterator object that can be used to iterate through key-value pairs in the collection.
    static DuctSizeSettings GetDuctSizeSettings(Document aDoc)
      Description: Get the duct size settings of the project.
      @aDoc: The document.
      Returns: The duct size settings of the project.
      Throws ArgumentNullException: A non-optional argument was null
    IEnumerator<KeyValuePair<DuctShape, DuctSizes>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    int GetSizeCount(DuctShape shape)
      Description: Get the size count of the duct size table. The duct shape determines the location of the size in the size table.
      @shape: The shape of duct.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void RemoveSize(DuctShape shape, double nominalDiameter)
      Description: Erase the existing MEPSize with this nominal diameter. The duct shape determines the location of the size in the size table.
      @shape: The shape of duct.
      @nominalDiameter: Nominal diameter.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Throws if the function is called during iterating the size set.

--------------------------------------------------------------------------------

[ENUM] DuctSystemType
Full Name: Autodesk.Revit.DB.Mechanical.DuctSystemType
Description: An enumerated type listing all the possible duct system types for a connector object.
Inherits: Enum

  Values:
    - UndefinedSystemType = 0
    - SupplyAir = 1
    - ReturnAir = 2
    - ExhaustAir = 3
    - OtherAir = 4
    - Fitting = 28
    - Global = 29

--------------------------------------------------------------------------------

[CLASS] DuctType
Full Name: Autodesk.Revit.DB.Mechanical.DuctType
Description: A duct type element.
Inherits: MEPCurveType

--------------------------------------------------------------------------------

[ENUM] EquipmentClassification
Full Name: Autodesk.Revit.DB.Mechanical.EquipmentClassification
Description: This enumeration is used to classify the mechanical equipment.
Inherits: Enum

  Values:
    - None = 0
    - Pump = 5

--------------------------------------------------------------------------------

[CLASS] FlexDuct
Full Name: Autodesk.Revit.DB.Mechanical.FlexDuct
Description: A flex duct in the Autodesk Revit MEP product.
Inherits: MEPCurve

  PROPERTIES:
    XYZ EndTangent { get; set; }
      Description: Gets or sets the tangent vector at the end of the curve. The invalid or zero vector is ignored when setting the tangent.
    FlexDuctType FlexDuctType { get; set; }
      Description: The flex duct type of this flex duct.
    IList<XYZ> Points { get; set; }
      Description: The points of the flex duct.
    XYZ StartTangent { get; set; }
      Description: Gets or sets the tangent vector at the start of the curve. The invalid or zero vector is ignored when setting the tangent.

  METHODS:
    static FlexDuct Create(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, XYZ startTangent, XYZ endTangent, IList<XYZ> points)
      Description: Creates a new flexible duct into the document, using a point array and flexible duct type.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the flexible duct.
      @levelId: The level id for the flexible duct.
      @startTangent: The tangent vector at the start of the curve. The invalid or zero vector is ignored.
      @endTangent: The tangent vector at the end of the curve. The invalid or zero vector is ignored.
      @points: The point array indicating the path of the flexible duct, including the end point.
      Returns: If creation was successful then a new flexible duct is returned, otherwise an exception with failure information will be thrown.
      Throws ArgumentException: The systemTypeId is not valid HVAC system type. -or- The type ductTypeId is not valid flexible duct type. -or- The ElementId levelId is not a Level. -or- The valid number of points is less than two. In order to create a flex curve, at least two points are required. Note the duplicate points don't take into account.
      Throws ArgumentNullException: A non-optional argument was null
    static FlexDuct Create(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, IList<XYZ> points)
      Description: Creates a new flexible duct into the document, using a point array and flexible duct type.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the flexible duct.
      @levelId: The level id for the flexible duct.
      @points: The point array indicating the path of the flexible duct, including the end point.
      Returns: If creation was successful then a new flexible duct is returned, otherwise an exception with failure information will be thrown.
      Throws ArgumentException: The systemTypeId is not valid HVAC system type. -or- The type ductTypeId is not valid flexible duct type. -or- The ElementId levelId is not a Level. -or- The valid number of points is less than two. In order to create a flex curve, at least two points are required. Note the duplicate points don't take into account.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsFlexDuctTypeId(Document document, ElementId ductTypeId)
      Description: Checks if given type is valid flexible duct type.
      @document: The document.
      @ductTypeId: ElementId of the flexible duct type to check.
      Returns: True if flexible duct type can used for this duct, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsHVACSystemTypeId(Document document, ElementId systemTypeId)
      Description: Checks if given type is valid HVAC system type.
      @document: The document.
      @systemTypeId: ElementId of the HVAC system type to check.
      Returns: True if the given systemTypeId is the HVAC system type, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] FlexDuctType
Full Name: Autodesk.Revit.DB.Mechanical.FlexDuctType
Description: A flex duct type in the Autodesk Revit MEP product.
Remarks: The flex duct type is only available in the Autodesk Revit MEP product.
Inherits: MEPCurveType

--------------------------------------------------------------------------------

[INTERFACE] IDuctFittingAndAccessoryPressureDropServer
Full Name: Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer
Description: Interface class for external servers implementing duct fitting and duct accessory coefficient calculation.
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interfaceCreate a new server object and register it with the service, see ExternalServiceRegistry.Assign server to duct fitting instance.
Implements: IExternalServer

  METHODS:
    bool Calculate(DuctFittingAndAccessoryPressureDropData data)
      Description: Calculate the duct fitting and duct accessory coefficient.
      @data: The input and output data of the calculation.
      Returns: True if calculation succeeds. False if calculation fails.
    Schema GetDataSchema()
      Description: Obtains the schema of the ESEntity.
      Returns: Null if the server has no data.
    bool IsApplicable(DuctFittingAndAccessoryPressureDropData data)
      Description: Check if the server is applicable for the duct fitting or duct accessory.
      @data: The input data of the calculation.

--------------------------------------------------------------------------------

[INTERFACE] IDuctPressureDropServer
Full Name: Autodesk.Revit.DB.Mechanical.IDuctPressureDropServer
Description: Interface for external servers implementing duct pressure drop calculation.
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interfaceCreate a new server object and register it with the service, see ExternalServiceRegistry.Assign server for the duct pressure drop calculation in DuctSettings.
Implements: IExternalServer

  METHODS:
    void Calculate(DuctPressureDropData data)
      Description: Calculate the duct pressure drop.
      @data: The input and output data of the calculation.
    string GetHtmlDescription()
      Description: The method that Revit will invoke to get an HTML formatted description of the server.
      Returns: The HTML format description of the server.
    string GetInformationLink()
      Description: The method that Revit will invoke to obtain a URL address which provides more information about the server.
      Returns: The URL providing server information.

--------------------------------------------------------------------------------

[CLASS] MechanicalEquipment
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalEquipment
Description: Provides access to the Mechanical Equipment in Autodesk Revit MEP.
Remarks: The Mechanical Equipment object can only be queried in Autodesk Revit MEP.
Inherits: MEPModel

--------------------------------------------------------------------------------

[CLASS] MechanicalEquipmentSet
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet
Description: A set of interrelated mechanical equipment in a MEP system that works together.
Inherits: Element

  PROPERTIES:
    EquipmentClassification Classification { get; }
      Description: The classification for the mechanical equipment set.
    int OnDuty { get; set; }
      Description: The number of pieces of mechanical equipment operating in parallel at any given time.
    int OnStandby { get; set; }
      Description: The number of pieces of mechanical equipment that are not operational at any given time.

  METHODS:
    void Add(ISet<ElementId> elemIds)
      Description: Adds member element ids to the mechanical equipment set.
      @elemIds: Element ids to be added to the mechanical equipment set.
      Throws ArgumentException: The valid members must have the same classification and system. They cannot be a member of existing set. -or- These elements are serially connected with each other, or with one of the set members.
      Throws ArgumentNullException: A non-optional argument was null
    static bool AreElementsNotConnectedInSeries(Document document, ISet<ElementId> elemIds)
      Description: Checks if the elements are not serially connected.
      @document: The document of these elements.
      @elemIds: The element ids to be tested.
      Throws ArgumentNullException: A non-optional argument was null
    static bool AreValidMembers(Document document, ISet<ElementId> memberIds)
      Description: Checks if these are valid members for mechanical equipment set.
      @document: The document of the member elements.
      @memberIds: The member element ids.
      Throws ArgumentNullException: A non-optional argument was null
    static MechanicalEquipmentSet Create(Document document, ElementId typeId, ISet<ElementId> memberIds)
      Description: Creates a new instance of a mechanical equipment set and adds it to the document.
      @document: The document where the element will be created and added.
      @typeId: The type of new mechanical equipment set.
      @memberIds: The member elements of this mechanical equipment set.
      Returns: The newly created mechanical equipment set.
      Throws ArgumentException: Invalid mechanical equipment set type. -or- This mechanical equipment set needs at least two members. -or- The valid members must have the same classification and system. A valid member cannot be a member of any other existing set. -or- These elements are serially connected.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ISet<ElementId> GetMembers()
      Description: Gets member element ids for the mechanical equipment set.
      Returns: Element ids for the members in the mechanical equipment set.
    void Remove(ISet<ElementId> elemIds)
      Description: Removes member element ids from the mechanical equipment set.
      @elemIds: Element ids to be removed from the mechanical equipment set.
      Throws ArgumentException: One or more element ids was not permitted to be removed from the mechanical equipment set. All elements should be a member of the mechanical equipment set.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MechanicalEquipmentSetType
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSetType
Description: Represents a type for a set of interrelated mechanical equipment in a MEP system that works together.
Inherits: ElementType

  METHODS:
    static MechanicalEquipmentSetType Create(Document document, string name)
      Description: Creates a new type of a mechanical equipment set and adds it to the document.
      @document: The document where the new type is created.
      @name: The name of new type.
      Returns: The newly created mechanical equipment set type.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string. -or- The given name is not unique
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] MechanicalFitting
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalFitting
Description: A mechanical fitting in the Autodesk Revit MEP product.
Remarks: The mechanical fitting is only available in the Autodesk Revit MEP product.
Inherits: MEPModel

  PROPERTIES:
    PartType PartType { get; }
      Description: The part type of the mechanical fitting.

--------------------------------------------------------------------------------

[CLASS] MechanicalSystem
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalSystem
Description: A mechanical system element.
Inherits: MEPSystem

  PROPERTIES:
    Connector BaseEquipmentConnector { get; set; }
      Description: The connector within the base equipment which is used to connect with the system.
    ElementSet DuctNetwork { get; }
      Description: The ducts and fittings contained within the system.
    bool IsWellConnected { get; }
      Description: Indicates if the system is well connected or not.
    DuctSystemType SystemType { get; }
      Description: The type of this duct system.

  METHODS:
    static MechanicalSystem Create(Document ADocument, ElementId typeId, string name)
      Description: Creates a new instance of a mechanical system and adds it to the document.
      @ADocument: The document where the element will be created and added.
      @typeId: The identifier of this mechanical system element's type.
      @name: The name of the mechanical system to be created.
      Returns: The newly created mechanical system element.
      Throws ArgumentException: The typeId is not an element id for a valid mechanical system type.
      Throws ArgumentNullException: A non-optional argument was null
    static MechanicalSystem Create(Document ADocument, ElementId typeId)
      Description: Creates a new instance of a mechanical system and adds it to the document.
      @ADocument: The document where the element will be created and added.
      @typeId: The identifier of this mechanical system element's type.
      Returns: The newly created mechanical system element.
      Throws ArgumentException: The typeId is not an element id for a valid mechanical system type.
      Throws ArgumentNullException: A non-optional argument was null
    double GetFlow()
      Description: Gets the flow of this mechanical system.
      Throws InvalidOperationException: The flow can not be calculated for this system.
    double GetStaticPressure()
      Description: Gets the static pressure of this mechanical system.
      Throws InvalidOperationException: The static pressure can not be calculated for this system.
    bool IsPressureDropServerMissing()
      Description: Indicates if any pressure drop server which was used in the mechanical system is not available.
      Returns: True if there is any pressure drop server not available, false otherwise.

--------------------------------------------------------------------------------

[CLASS] MechanicalSystemType
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalSystemType
Description: Base class for duct system types
Inherits: MEPSystemType

  PROPERTIES:
    RiseDropSymbol RiseDropSettings { get; set; }
      Description: indicates the rise/drop symbol given the system type

  METHODS:
    static MechanicalSystemType Create(Document ADoc, MEPSystemClassification systemClassification, string name)
      Description: Creates a new instance of a mechanical system type and adds it to the document.
      @ADoc: The document where the element will be created and added.
      @systemClassification: The classification for the mechanical system type to be created
      @name: The name of the mechanical system type to be created.
      Returns: The newly created mechanical system type element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws ArgumentsInconsistentException: The system classification is not valid for the domain of this system type.
    bool ValidateRiseDropSymbolType(RiseDropSymbol risedropType)
      Description: Confirms if the parameter is a valid HVAC rise/drop symbol type.
      @risedropType: The type.
      Returns: True if the input is a valid HVAC rise/drop symbol type, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MechanicalUtils
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalUtils
Description: General utility methods in the Autodesk Revit MEP product.

  METHODS:
    static ElementId BreakCurve(Document document, ElementId ductId, XYZ ptBreak)
      Description: Breaks the duct curve into two parts at the given position.
      @document: The document.
      @ductId: The element id of the duct curve to break.
      @ptBreak: The break point on the duct curve.
      Returns: The new duct curve element id if successful otherwise if a failure occurred an invalidElementId is returned.
      Throws ArgumentException: "The element is neither a duct nor a duct placeholder." -or- "The given point is not on the duct curve."
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectAirTerminalOnDuct(Document document, ElementId airTerminalId, ElementId ductCurveId)
      Description: Connects an air terminal to a duct directly (without the need for a tee or takeoff).
      @document: The document.
      @airTerminalId: The air terminal id.
      @ductCurveId: The duct curve id.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The familyinstance is not air terminal. -or- The element is not duct curve. -or- The air terminal already has physical connection. -or- The air terminal connector origin doesn't project within the center line of the duct.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtCross(Document document, Connector connector1, Connector connector2, Connector connector3, Connector connector4)
      Description: Connects a group of placeholders that can intersect in a Cross connection.
      @document: The document.
      @connector1: The end connector of the first placeholder.
      @connector2: The end connector of the second placeholder.
      @connector3: The end connector of the third placeholder.
      @connector4: The end connector of the fourth placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The owner of connector is not duct placeholder. -or- The owners of connectors belong to different types of system. -or- The curves of connector1 and connector2 are not collinear or either the connecto1 or connector2 is not connector of curve end. -or- The curves of connector3 and connector4 are not collinear or either the connecto1 or connector2 is not connector of curve end.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtCross(Document document, ElementId placeholder1Id, ElementId placeholder2Id, ElementId placeholder3Id)
      Description: Connects a trio of placeholders that can intersect in a Cross connection.
      @document: The document.
      @placeholder1Id: The element id of the first duct placeholder.
      @placeholder2Id: The element id of the second duct placeholder.
      @placeholder3Id: The element id of third duct placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The element id placeholder1Id is not duct placeholder. -or- The element id placeholder2Id is not duct placeholder. -or- The element id placeholder3Id is not duct placeholder. -or- The elements belong to different types of system. -or- The curve placeholder2Id does not connect on the curve placeholder1Id or vice versa. -or- The curve placeholder3Id does not connect on the curve placeholder1Id or vice versa. -or- The curve placeholder2Id and placeholder3Id are not collinear.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtCross(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects a pair of placeholders that can intersect in a Cross connection.
      @document: The document.
      @placeholder1Id: The element id of the first duct placeholder.
      @placeholder2Id: The element id of the second duct placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The element id placeholder1Id is not duct placeholder. -or- The element id placeholder2Id is not duct placeholder. -or- The elements belong to different types of system.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtElbow(Document document, Connector connector1, Connector connector2)
      Description: Connects a pair of placeholders that can intersect in an Elbow connection.
      @document: The document.
      @connector1: The end connector of the first placeholder.
      @connector2: The end connector of the second placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The owner of connector is not duct placeholder. -or- The owners of connectors belong to different types of system.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtElbow(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects a pair of placeholders that can intersect in an Elbow connection.
      @document: The document.
      @placeholder1Id: The element id of the first duct placeholder.
      @placeholder2Id: The element id of the second duct placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The element id placeholder1Id is not duct placeholder. -or- The element id placeholder2Id is not duct placeholder. -or- The elements belong to different types of system. -or- The curve placeholder1Id and placeholder2Id are not physically connected.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtTee(Document document, Connector connector1, Connector connector2, Connector connector3)
      Description: Connects a trio of placeholders that can intersect in a Tee connection.
      @document: The document.
      @connector1: The end connector of the first placeholder.
      @connector2: The end connector of second placeholder.
      @connector3: The end connector of the third placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The owner of connector is not duct placeholder. -or- The owners of connectors belong to different types of system. -or- The curves of connector1 and connector2 are not collinear or either the connecto1 or connector2 is not connector of curve end.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ConnectDuctPlaceholdersAtTee(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects a pair of placeholders that can intersect in a Tee connection.
      @document: The document.
      @placeholder1Id: The element Id of the first duct placeholder.
      @placeholder2Id: The element Id of the second duct placeholder.
      Returns: True if connection succeeds, false otherwise.
      Throws ArgumentException: The element id placeholder1Id is not duct placeholder. -or- The element id placeholder2Id is not duct placeholder. -or- The elements belong to different types of system. -or- The curve placeholder2Id does not connect on the curve placeholder1Id or vice versa.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> ConvertDuctPlaceholders(Document document, ICollection<ElementId> placeholderIds)
      Description: Converts a collection of duct placeholder elements into duct elements.
      @document: The document.
      @placeholderIds: A collection of element IDs of duct placeholders.
      Returns: A collection of element IDs of ducts and fittings.
      Throws ArgumentException: The given element id set is empty. -or- The given element IDs (placeholderIds) are not duct placeholders. -or- The elements belong to different types of system.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalSystem
Full Name: Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem
Description: Represents an analytical system where the air or water is circulated to satisfy building energy requirements.
Inherits: Element

  PROPERTIES:
    AnalyticalSystemDomain AnalyticalSystemDomain { get; }
      Description: The type of analytical system.

  METHODS:
    static MEPAnalyticalSystem Create(Document document, AnalyticalSystemDomain domain, string name)
      Description: Creates a new analytical system
      @document: The document where the new element will be created.
      @domain: The domain of analytical system to be created.
      @name: The name of new analytical system. The actual name may be post-fixed if already exists.
      Returns: The newly created analytical system.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    AirSystemData GetAirSystemData()
      Description: Returns the air system data, null if not available.
    WaterLoopData GetWaterLoopData()
      Description: Returns the water loop data, null if not available.

--------------------------------------------------------------------------------

[CLASS] MEPBuildingConstruction
Full Name: Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction
Description: Construction definition for Project Information.
Remarks: This is used to define the information in Constructions.xml.
Inherits: ElementType

  METHODS:
    Construction GetBuildingConstruction(ConstructionType constructionType)
      Description: Gets the current Building Construction from the project information.
      @constructionType: The Construction Type of Building Construction.
      Returns: The Building Construction of the Project Information.
    bool GetBuildingConstructionOverride(ConstructionType constructionType)
      Description: Gets the Building Construction override for a ConstructionType.
      @constructionType: The ConstructionType override value to get.
      Returns: True if analytical construction properties specified in Constructions.xml are used for the given ConstructionType, false otherwise.
      Throws ArgumentOutOfRangeException: The ConstructionType is invalid.
    ICollection<Construction> GetConstructions(ConstructionType constructionType)
      Description: Gets all the Building Constructions corresponding to the specific Construction type.
      @constructionType: The Construction Type of Building Construction.
      Returns: A collection containing Building constructions matching the construction type.
    void SetBuildingConstruction(ConstructionType constructionType, Construction buildingConstruction)
      Description: Sets the Building Construction of the Project Information.
      @constructionType: The Construction Type of Building Construction.
      @buildingConstruction: The Building Construction to be set.
      Throws ArgumentNullException: buildingConstruction is NULL.
      Throws InvalidOperationException: Sets construction type to an invalid value. - or - Can not set construction type.
    void SetBuildingConstructionOverride(ConstructionType constructionType, bool override)
      Description: Sets the Building Construction override for a ConstructionType.
      @constructionType: The ConstructionType to override.
      @override: True to use analytical construction properties specified in Constructions.xml in the given ConstructionType, false otherwise.
      Throws ArgumentOutOfRangeException: The ConstructionType is invalid.

--------------------------------------------------------------------------------

[CLASS] MEPBuildingConstructionSet
Full Name: Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet
Description: A set that contains MEPBuildingConstructions.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new MEPBuildingConstructionSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of MEPBuildingConstructions that are in the set.

  METHODS:
    void Clear()
      Description: Removes every MEPBuildingConstruction from the set, rendering it empty.
    bool Contains(MEPBuildingConstruction item)
      Description: Tests for the existence of a MEPBuildingConstruction within the set.
      @item: The MEPBuildingConstruction to be searched for.
      Returns: The Contains method returns True if the MEPBuildingConstruction is within the set, otherwise False.
    int Erase(MEPBuildingConstruction item)
      Description: Removes a specified MEPBuildingConstruction from the set.
      @item: The MEPBuildingConstruction to be erased.
      Returns: The number of MEPBuildingConstructions that were erased from the set.
    MEPBuildingConstructionSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(MEPBuildingConstruction item)
      Description: Insert the specified MEPBuildingConstruction into the set.
      @item: The MEPBuildingConstruction to be inserted into the set.
      Returns: Returns whether the MEPBuildingConstruction was inserted into the set.
    MEPBuildingConstructionSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MEPBuildingConstructionSetIterator
Full Name: Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator
Description: An iterator to a MEPBuildingConstruction set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new MEPBuildingConstructionSetIterator()
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

[CLASS] MEPHiddenLineSettings
Full Name: Autodesk.Revit.DB.Mechanical.MEPHiddenLineSettings
Description: Represents the settings contained in the document associated to the MEP hidden line display.
Inherits: Element

  PROPERTIES:
    bool DrawHiddenLine { get; set; }
      Description: Indicates if duct or piping is drawn with the line style and gaps specified for hidden lines.
    double InsideGap { get; set; }
      Description: The gap for the lines that appear within a crossing segment.
    ElementId LineStyle { get; set; }
      Description: The line style that determines how the lines of a hidden segment display at the point where the segments cross.
    double OutsideGap { get; set; }
      Description: The gap for the lines that appear external to the crossing segments.
    double SingleLineGap { get; set; }
      Description: The gap for the single hidden lines where segments cross.

  METHODS:
    static MEPHiddenLineSettings GetMEPHiddenLineSettings(Document doc)
      Description: Gets the MEP hidden line settings in the document.
      @doc: The document where the settings element is found.
      Returns: The element which stores the MEP hidden line settings for the document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPSection
Full Name: Autodesk.Revit.DB.Mechanical.MEPSection
Description: A section in the Autodesk Revit MEP product.
Remarks: This is the base class for duct and pipe section. This class is mainly for pressure loss calculation. It is a series of connected elements (segments - ducts or pipes, fittings, terminals and accessories). All section members should have same flow analysis properties: Flow, Size, Velocity, Friction and Roughness. One section member element which contains more than one connector can belongs to multiple section. e.g.: One Tee which has 3 connectors, usually, it belongs 3 sections. One segment which connect to a tap will be divided into 2 sections.
Implements: IDisposable

  PROPERTIES:
    double FixtureUnit { get; }
      Description: The fixture unit of the section.
    double Flow { get; }
      Description: The flow of the section.
    double Friction { get; }
      Description: The friction of the section.
    double FrictionFactor { get; }
      Description: The friction factor of the section.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Number { get; }
      Description: The Section number.
    double ReynoldsNumber { get; }
      Description: The Reynolds number of the section.
    double Roughness { get; }
      Description: The roughness of the section.
    double TotalCoefficient { get; }
      Description: The loss coefficient of the section.
    double TotalCurveLength { get; }
      Description: The total length of all segments in the section.
    double TotalPressureLoss { get; }
      Description: The total pressure loss of the section.
    double Velocity { get; }
      Description: The velocity of the section.
    double VelocityPressure { get; }
      Description: The velocity pressure of the section.

  METHODS:
    void Dispose()
    double GetCoefficient(ElementId elemId)
      Description: Gets the loss coefficient for the specified element id in this section.
      @elemId: The element id which can be duct segment, duct fitting , pipe segment and pipe fitting.
      Throws ArgumentException: The ElementId elemId does not correspond to a valid section member.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ElementId> GetElementIds()
      Description: Gets all element ids that are contained in the section.
    double GetPressureDrop(ElementId elemId)
      Description: Gets the pressure drop for the specified element id in this section.
      @elemId: The element id which can be duct segment, duct fitting , pipe segment and pipe fitting.
      Throws ArgumentException: The ElementId elemId does not correspond to a valid section member.
      Throws ArgumentNullException: A non-optional argument was null
    double GetSegmentLength(ElementId segmentId)
      Description: Get the length for the specified segment id in this section.
      @segmentId: The element id which can be duct segment and pipe segment.
      Throws ArgumentException: The ElementId segmentId does not correspond to a valid section segment member.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsMain(ElementId fittingId)
      Description: Check whether the type of fitting in this section is main.
      @fittingId: The element id which can be duct fitting and pipe fitting.
      Returns: True if the type of fitting in this section is main False if the type of fitting in this section is branch
      Throws ArgumentException: The ElementId fittingId does not correspond to a valid section fitting member.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPSpaceConstruction
Full Name: Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction
Description: Construction definition for Space.
Remarks: This is used to define the information in Constructions.xml.

  PROPERTIES:
    MEPBuildingConstruction CurrentConstruction { get; set; }
      Description: Get all the Building Constructions according to the specific Construction type.
    MEPBuildingConstructionSet SpaceConstructions { get; }
      Description: Return all the Space constructions of current space.

  METHODS:
    void DeleteConstruction(MEPBuildingConstruction pCurrentConstruction)
      Description: Remove an existing construction from Space constructions.
      @pCurrentConstruction: The Construction will be deleted.
    MEPBuildingConstruction DuplicateConstruction(MEPBuildingConstruction pCurrentConstruction, string pName)
      Description: Create a new construction for Space constructions.
      @pCurrentConstruction: The existing construction to be duplicated.
      @pName: The name of the new construction.
    MEPBuildingConstruction NewConstruction(string pName)
      Description: Create a new construction for Space constructions.
      @pName: The name of the new Construction.

--------------------------------------------------------------------------------

[ENUM] OccupancyUnit
Full Name: Autodesk.Revit.DB.Mechanical.OccupancyUnit
Description: An enumerated type listing the occupancy unit of measure for a space object.
Inherits: Enum

  Values:
    - NumberOfPeople = 0
    - AreaPerPerson = 1
    - BySpaceType = -1

--------------------------------------------------------------------------------

[ENUM] ReturnAirflowType
Full Name: Autodesk.Revit.DB.Mechanical.ReturnAirflowType
Description: An enumerated type listing all the possible return airflow types for a space object.
Inherits: Enum

  Values:
    - Specified = 0
    - SpecifiedSupplyAirflow = 1
    - CalculatedSupplyAirflow = 2
    - ActualSupplyAirflow = 3

--------------------------------------------------------------------------------

[ENUM] RiseDropSymbol
Full Name: Autodesk.Revit.DB.Mechanical.RiseDropSymbol
Description: This enumeration corresponds to the rise/drop symbol used in mechanical systems
Inherits: Enum

  Values:
    - NoSymbol = 0
    - Outline = 1
    - Cross = 2
    - CrossFilled = 3
    - Slash = 4
    - SlashFilled = 5
    - Backslash = 6
    - BackslashFilled = 7
    - Wye = 8
    - ReverseWye = 9
    - OutlineFilled = 10
    - YinYang = 11
    - YinYangFilled = 12
    - BendThreeQuarterCircle = 13
    - BendFullCircle = 14
    - TeeHalfCircle = 15
    - TeeFullCircle = 16
    - CrossNoOutline = 17
    - WyeFilled = 18
    - ReverseWyeFilled = 19
    - CustomSymbol = -1

--------------------------------------------------------------------------------

