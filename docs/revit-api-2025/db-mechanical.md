# Autodesk.Revit.DB.Mechanical


NAMESPACE: Autodesk.Revit.DB.Mechanical
--------------------------------------------------------------------------------

[ENUM] AirCoolingCoilType
Full Name: Autodesk.Revit.DB.Mechanical.AirCoolingCoilType

Description: The type of air cooling coil.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - ChilledWater = 1
    - DirectExpansion = 2

[ENUM] AirFanType
Full Name: Autodesk.Revit.DB.Mechanical.AirFanType

Description: The type of air fan.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ConstantVolume = 0
    - VariableVolume = 1

[ENUM] AirHeatExchangerType
Full Name: Autodesk.Revit.DB.Mechanical.AirHeatExchangerType

Description: The type of air loop.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Enthalpy = 1
    - Sensible = 2

[ENUM] AirHeatingCoilType
Full Name: Autodesk.Revit.DB.Mechanical.AirHeatingCoilType

Description: The type of air heating coil.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - ElectricResistance = 1
    - Furnace = 2
    - HotWater = 3

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - WaterLoop = 0
    - AirSystem = 1
    - ElectricalSystem = 2

[ENUM] ComponentClassification
Full Name: Autodesk.Revit.DB.Mechanical.ComponentClassification

Description: An enumerated type lists all MEP component classification. This attribute describes the general purpose of the MEP part component, that is used for scheduling, tagging, filter, ODBC, and etc. One component classification may include more than one part type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[ENUM] ConditionType
Full Name: Autodesk.Revit.DB.Mechanical.ConditionType

Description: An enumerated type listing all the possible condition types for a space object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Heated = 0
    - Cooled = 1
    - HeatedAndCooled = 2
    - Unconditioned = 3
    - Vented = 4
    - NaturallyVentedOnly = 5
    - NoOfConditionTypes = 6

[CLASS] Duct
Full Name: Autodesk.Revit.DB.Mechanical.Duct

Description: A duct in the Autodesk Revit MEP product.
Remarks: The duct is only available in the Autodesk Revit MEP product.
Inherits: MEPCurve
Implements: IDisposable

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
    static Duct Create(Document document, ElementId ductTypeId, ElementId levelId, Connector startConnector, XYZ endPoint)
      Description: Creates a new duct that connects to the connector.
      @document: The document.
      @ductTypeId: The ElementId of the new duct type.
      @levelId: The level id for the new duct.
      @startConnector: The first connector where the new duct starts.
      @endPoint: The second point of the new duct.
      Returns: The created duct.
    static Duct Create(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, XYZ startPoint, XYZ endPoint)
      Description: Creates a new duct from two points.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the duct type.
      @levelId: The level ElementId for the duct.
      @startPoint: The start point of the duct.
      @endPoint: The end point of the duct.
      Returns: The created duct.
    static Duct CreatePlaceholder(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, XYZ startPoint, XYZ endPoint)
      Description: Creates a new placeholder duct.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the duct type.
      @levelId: The level id for the duct.
      @startPoint: The first point of the placeholder line.
      @endPoint: The second point of the placeholder line.
      Returns: The created placeholder duct.
    static bool IsDuctTypeId(Document document, ElementId ductTypeId)
      Description: Checks if given type is valid duct type.
      @document: The document.
      @ductTypeId: ElementId of the duct type to check.
      Returns: True if duct type can used for this duct, false otherwise.
    static bool IsHvacSystemTypeId(Document document, ElementId systemTypeId)
      Description: Checks if given type is valid HVAC system type.
      @document: The document.
      @systemTypeId: ElementId of the HVAC system type to check.
      Returns: True if the given systemTypeId is the HVAC system type, false otherwise.
    void SetSystemType(ElementId systemTypeId)
      Description: Updates the associated system type for the duct.
      @systemTypeId: The ElementId of the hvac system type.

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
      Description: The connector flow, Units:(ftÃ‚Â³/s)
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
      Description: The connector velocity pressure. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
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
    double AirViscosity { get; }
      Description: The kinematic viscosity of air for the duct fitting or duct accessory, Units: (ft^2/s).
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

--------------------------------------------------------------------------------

[CLASS] DuctFittingAndAccessoryPressureDropItem
Full Name: Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropItem

Description: A flow path of the duct/pipe fitting and accessory. It is defined by the begin connector and end connector.
Implements: IDisposable

  PROPERTIES:
    int BeginConnectorIndex { get; }
      Description: The index of the begin connector of the flow path.
    double Coefficient { get; set; }
      Description: The coefficient between the begin connector and end connector, Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
    int EndConnectorIndex { get; }
      Description: The index of the end conector of the flow path.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double VelocityPressure { get; }
      Description: The velocity pressure, for converting between coefficient and pressure drop on this flow path. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] DuctFlowConfigurationType
Full Name: Autodesk.Revit.DB.Mechanical.DuctFlowConfigurationType

Description: An enumerated type listing all duct flow configuration types for a connector.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Calculated = 0
    - Preset = 1
    - System = 2

[CLASS] DuctInsulation
Full Name: Autodesk.Revit.DB.Mechanical.DuctInsulation

Description: Represents insulation applied to the outside of a given duct , fitting or accessory.
Inherits: InsulationLiningBase
Implements: IDisposable

  METHODS:
    static DuctInsulation Create(Document document, ElementId ductOrContentElementId, ElementId ductInsulationTypeId, double Thickness)
      Description: Creates a new instance of duct insulation.
      @document: The document.
      @ductOrContentElementId: The duct , fitting or accessory ElementId to which insulation will be added.
      @ductInsulationTypeId: The duct insulation type. If the input duct insulation type is InvalidElementId, the default insulation type from the document will be used.
      @Thickness: The thickness of the insulation.
      Returns: The newly created duct insulation.

--------------------------------------------------------------------------------

[CLASS] DuctInsulationType
Full Name: Autodesk.Revit.DB.Mechanical.DuctInsulationType

Description: This class represents a duct insulation type in Autodesk Revit.
Inherits: ElementType
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DuctLining
Full Name: Autodesk.Revit.DB.Mechanical.DuctLining

Description: Represents Lining applied to the inside of a given duct, fitting or accessory.
Inherits: InsulationLiningBase
Implements: IDisposable

  METHODS:
    static DuctLining Create(Document document, ElementId ductOrContentElementId, ElementId ductLiningTypeId, double Thickness)
      Description: Creates a new instance of duct lining.
      @document: The document.
      @ductOrContentElementId: The duct, fitting or accessory ElementId to which lining will be added.
      @ductLiningTypeId: The duct lining type. If the input duct lining type is InvalidElementId, the default lining type from the document will be used.
      @Thickness: The thickness of the lining.
      Returns: The newly created duct lining.

--------------------------------------------------------------------------------

[CLASS] DuctLiningType
Full Name: Autodesk.Revit.DB.Mechanical.DuctLiningType

Description: This class represents a duct lining type in Autodesk Revit.
Inherits: ElementType
Implements: IDisposable

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotDefined = 0
    - SpecificLoss = 4
    - Coefficient = 6

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
      Description: The density of the duct. Units: (kg/ftÃ‚Â³).
    double DynamicViscosity { get; }
      Description: The dynamic viscosity of the air in the duct. Units: (kg/(ft*s)).
    double Flow { get; }
      Description: The flow of the duct. Units: (ftÃ‚Â³/s).
    double Friction { get; set; }
      Description: The friction of the duct. Units: (kg/(ftÃ‚Â²Ã‚Â·sÃ‚Â²)).
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
      Description: The pressure drop of the duct. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
    double ReynoldsNumber { get; set; }
      Description: The reynolds number of the duct.
    double Roughness { get; }
      Description: The roughness of the duct. Units: (ft).
    ConnectorProfileType Shape { get; }
      Description: The profile type of the duct.
    double Velocity { get; set; }
      Description: The velocity of the duct. Units: (ft/s).
    double VelocityPressure { get; set; }
      Description: The velocity pressure of the duct. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
    double Viscosity { get; }
      Description: The kinematic viscosity of the air in the duct. Units: (ft^2/s).
    double WidthOrDiameter { get; }
      Description: The diameter of the duct with round profile, or the width of the duct with other profiles. Units: (ft).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] DuctSettings
Full Name: Autodesk.Revit.DB.Mechanical.DuctSettings

Description: The duct setting class.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double AirDensity { get; set; }
      Description: The air density in kg/ft^3.
    double AirDynamicViscosity { get; set; }
      Description: The dynamic viscosity of air in kg/(ft*s).
    double AirViscosity { get; set; }
      Description: The kinematic viscosity of air in ft^2/s.
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
    MEPCalculationServerInfo GetPressLossCalculationServerInfo()
      Description: Get the MEPServerInfo of the current pipe pressure loss calculation server.
      Returns: The MEPServerInfo of the current pipe pressure loss calculation server
    IList<double> GetSpecificFittingAngles()
      Description: Gets the list of specific fitting angles.
      Returns: Angles (in degrees).
    bool GetSpecificFittingAngleStatus(double angle)
      Description: Gets the status of given specific angle.
      @angle: The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.
    static bool IsNetworkBasedCalculationsEnabled(Document document)
      Description: Indicates whether network based calculations for duct networks is enabled in the specified document.
      @document: The document.
      Returns: Returns true if network based calculations for duct networks is enabled, false otherwise.
    bool IsValidSpecificFittingAngle(double angle)
      Description: Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      @angle: The angle value (in degree).
      Returns: True if the given value is a valid specific fitting angle.
    void SetPressLossCalculationServerInfo(MEPCalculationServerInfo serverInfo)
      Description: Set the MEPServerInfo of the current pipe pressure loss calculation server.
    void SetSpecificFittingAngleStatus(double angle, bool useInLayout)
      Description: Sets the status of given specific angle.
      @angle: The specific angle (in degree) that must be one of 60, 45, 30, 22.5 or 11.25 degrees.
      @useInLayout: Status, true - using the given angle during the duct layout.

--------------------------------------------------------------------------------

[ENUM] DuctShape
Full Name: Autodesk.Revit.DB.Mechanical.DuctShape

Description: Enumerated type listing possible shapes for ducts.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Round = 0
    - Rectangular = 1
    - Oval = 2

[CLASS] DuctSizeIterator
Full Name: Autodesk.Revit.DB.Mechanical.DuctSizeIterator

Description: An iterator to a set of MEP duct sizes from DuctSizes.
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

[CLASS] DuctSizes
Full Name: Autodesk.Revit.DB.Mechanical.DuctSizes

Description: Class RbsDuctSizes being used to store the duct sizes
Implements: IEnumerable`1, IEnumerable, IDisposable

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
Implements: IEnumerator`1, IDisposable, IEnumerator

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
Implements: IDisposable, IEnumerable`1, IEnumerable

  PROPERTIES:
    DuctSizes Item { get; }

  METHODS:
    void AddSize(DuctShape shape, MEPSize sizeInfo)
      Description: Inserts a new MEPSize in to the duct size settings. The duct shape determines the location of the new size in the size table.
      @shape: The shape of duct.
      @sizeInfo: The new MEPSize to be added.
    DuctSizeSettingIterator GetDuctSizeSettingIterator()
      Description: Returns a DuctSizeSettingIterator object that iterates through the collection.
      Returns: A DuctSizeSettingIterator object that can be used to iterate through key-value pairs in the collection.
    static DuctSizeSettings GetDuctSizeSettings(Document aDoc)
      Description: Get the duct size settings of the project.
      @aDoc: The document.
      Returns: The duct size settings of the project.
    IEnumerator<KeyValuePair<DuctShape, DuctSizes>> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    int GetSizeCount(DuctShape shape)
      Description: Get the size count of the duct size table. The duct shape determines the location of the size in the size table.
      @shape: The shape of duct.
    void RemoveSize(DuctShape shape, double nominalDiameter)
      Description: Erase the existing MEPSize with this nominal diameter. The duct shape determines the location of the size in the size table.
      @shape: The shape of duct.
      @nominalDiameter: Nominal diameter.

--------------------------------------------------------------------------------

[ENUM] DuctSystemType
Full Name: Autodesk.Revit.DB.Mechanical.DuctSystemType

Description: An enumerated type listing all the possible duct system types for a connector object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UndefinedSystemType = 0
    - SupplyAir = 1
    - ReturnAir = 2
    - ExhaustAir = 3
    - OtherAir = 4
    - Fitting = 28
    - Global = 29

[CLASS] DuctType
Full Name: Autodesk.Revit.DB.Mechanical.DuctType

Description: A duct type element.
Inherits: MEPCurveType
Implements: IDisposable

--------------------------------------------------------------------------------

[ENUM] EquipmentClassification
Full Name: Autodesk.Revit.DB.Mechanical.EquipmentClassification

Description: This enumeration is used to classify the mechanical equipment.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Pump = 5

[CLASS] FlexDuct
Full Name: Autodesk.Revit.DB.Mechanical.FlexDuct

Description: A flex duct in the Autodesk Revit MEP product.
Inherits: MEPCurve
Implements: IDisposable

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
    static FlexDuct Create(Document document, ElementId systemTypeId, ElementId ductTypeId, ElementId levelId, IList<XYZ> points)
      Description: Creates a new flexible duct into the document, using a point array and flexible duct type.
      @document: The document.
      @systemTypeId: The id of the HVAC system type.
      @ductTypeId: The id of the flexible duct.
      @levelId: The level id for the flexible duct.
      @points: The point array indicating the path of the flexible duct, including the end point.
      Returns: If creation was successful then a new flexible duct is returned, otherwise an exception with failure information will be thrown.
    static bool IsFlexDuctTypeId(Document document, ElementId ductTypeId)
      Description: Checks if given type is valid flexible duct type.
      @document: The document.
      @ductTypeId: ElementId of the flexible duct type to check.
      Returns: True if flexible duct type can used for this duct, false otherwise.
    static bool IsHVACSystemTypeId(Document document, ElementId systemTypeId)
      Description: Checks if given type is valid HVAC system type.
      @document: The document.
      @systemTypeId: ElementId of the HVAC system type to check.
      Returns: True if the given systemTypeId is the HVAC system type, false otherwise.

--------------------------------------------------------------------------------

[CLASS] FlexDuctType
Full Name: Autodesk.Revit.DB.Mechanical.FlexDuctType

Description: A flex duct type in the Autodesk Revit MEP product.
Remarks: The flex duct type is only available in the Autodesk Revit MEP product.
Inherits: MEPCurveType
Implements: IDisposable

--------------------------------------------------------------------------------

[INTERFACE] IDuctFittingAndAccessoryPressureDropServer
Full Name: Autodesk.Revit.DB.Mechanical.IDuctFittingAndAccessoryPressureDropServer

Description: Interface class for external servers implementing duct fitting and duct accessory coefficient calculation.
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interface Create a new server object and register it with the service, see ExternalServiceRegistry.Assign server to duct fitting instance.
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
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interface Create a new server object and register it with the service, see ExternalServiceRegistry.Assign server for the duct pressure drop calculation in DuctSettings.
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
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] MechanicalEquipmentSet
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet

Description: A set of interrelated mechanical equipment in a MEP system that works together.
Inherits: Element
Implements: IDisposable

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
    static bool AreElementsNotConnectedInSeries(Document document, ISet<ElementId> elemIds)
      Description: Checks if the elements are not serially connected.
      @document: The document of these elements.
      @elemIds: The element ids to be tested.
    static bool AreValidMembers(Document document, ISet<ElementId> memberIds)
      Description: Checks if these are valid members for mechanical equipment set.
      @document: The document of the member elements.
      @memberIds: The member element ids.
    static MechanicalEquipmentSet Create(Document document, ElementId typeId, ISet<ElementId> memberIds)
      Description: Creates a new instance of a mechanical equipment set and adds it to the document.
      @document: The document where the element will be created and added.
      @typeId: The type of new mechanical equipment set.
      @memberIds: The member elements of this mechanical equipment set.
      Returns: The newly created mechanical equipment set.
    ISet<ElementId> GetMembers()
      Description: Gets member element ids for the mechanical equipment set.
      Returns: Element ids for the members in the mechanical equipment set.
    void Remove(ISet<ElementId> elemIds)
      Description: Removes member element ids from the mechanical equipment set.
      @elemIds: Element ids to be removed from the mechanical equipment set.

--------------------------------------------------------------------------------

[CLASS] MechanicalEquipmentSetType
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSetType

Description: Represents a type for a set of interrelated mechanical equipment in a MEP system that works together.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static MechanicalEquipmentSetType Create(Document document, string name)
      Description: Creates a new type of a mechanical equipment set and adds it to the document.
      @document: The document where the new type is created.
      @name: The name of new type.
      Returns: The newly created mechanical equipment set type.

--------------------------------------------------------------------------------

[CLASS] MechanicalFitting
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalFitting

Description: A mechanical fitting in the Autodesk Revit MEP product.
Remarks: The mechanical fitting is only available in the Autodesk Revit MEP product.
Inherits: MEPModel
Implements: IDisposable

  PROPERTIES:
    PartType PartType { get; }
      Description: The part type of the mechanical fitting.

--------------------------------------------------------------------------------

[CLASS] MechanicalSystem
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalSystem

Description: A mechanical system element.
Inherits: MEPSystem
Implements: IDisposable

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
    static MechanicalSystem Create(Document ADocument, ElementId typeId)
      Description: Creates a new instance of a mechanical system and adds it to the document.
      @ADocument: The document where the element will be created and added.
      @typeId: The identifier of this mechanical system element's type.
      Returns: The newly created mechanical system element.
    double GetFlow()
      Description: Gets the flow of this mechanical system.
    double GetStaticPressure()
      Description: Gets the static pressure of this mechanical system.
    bool IsPressureDropServerMissing()
      Description: Indicates if any pressure drop server which was used in the mechanical system is not available.
      Returns: True if there is any pressure drop server not available, false otherwise.

--------------------------------------------------------------------------------

[CLASS] MechanicalSystemType
Full Name: Autodesk.Revit.DB.Mechanical.MechanicalSystemType

Description: Base class for duct system types
Inherits: MEPSystemType
Implements: IDisposable

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
    bool ValidateRiseDropSymbolType(RiseDropSymbol risedropType)
      Description: Confirms if the parameter is a valid HVAC rise/drop symbol type.
      @risedropType: The type.
      Returns: True if the input is a valid HVAC rise/drop symbol type, false otherwise.

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
    static bool ConnectAirTerminalOnDuct(Document document, ElementId airTerminalId, ElementId ductCurveId)
      Description: Connects an air terminal to a duct directly (without the need for a tee or takeoff).
      @document: The document.
      @airTerminalId: The air terminal id.
      @ductCurveId: The duct curve id.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtCross(Document document, Connector connector1, Connector connector2, Connector connector3, Connector connector4)
      Description: Connects a group of placeholders that can intersect in a Cross connection.
      @document: The document.
      @connector1: The end connector of the first placeholder.
      @connector2: The end connector of the second placeholder.
      @connector3: The end connector of the third placeholder.
      @connector4: The end connector of the fourth placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtCross(Document document, ElementId placeholder1Id, ElementId placeholder2Id, ElementId placeholder3Id)
      Description: Connects a trio of placeholders that can intersect in a Cross connection.
      @document: The document.
      @placeholder1Id: The element id of the first duct placeholder.
      @placeholder2Id: The element id of the second duct placeholder.
      @placeholder3Id: The element id of third duct placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtCross(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects a pair of placeholders that can intersect in a Cross connection.
      @document: The document.
      @placeholder1Id: The element id of the first duct placeholder.
      @placeholder2Id: The element id of the second duct placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtElbow(Document document, Connector connector1, Connector connector2)
      Description: Connects a pair of placeholders that can intersect in an Elbow connection.
      @document: The document.
      @connector1: The end connector of the first placeholder.
      @connector2: The end connector of the second placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtElbow(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects a pair of placeholders that can intersect in an Elbow connection.
      @document: The document.
      @placeholder1Id: The element id of the first duct placeholder.
      @placeholder2Id: The element id of the second duct placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtTee(Document document, Connector connector1, Connector connector2, Connector connector3)
      Description: Connects a trio of placeholders that can intersect in a Tee connection.
      @document: The document.
      @connector1: The end connector of the first placeholder.
      @connector2: The end connector of second placeholder.
      @connector3: The end connector of the third placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectDuctPlaceholdersAtTee(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects a pair of placeholders that can intersect in a Tee connection.
      @document: The document.
      @placeholder1Id: The element Id of the first duct placeholder.
      @placeholder2Id: The element Id of the second duct placeholder.
      Returns: True if connection succeeds, false otherwise.
    static ICollection<ElementId> ConvertDuctPlaceholders(Document document, ICollection<ElementId> placeholderIds)
      Description: Converts a collection of duct placeholder elements into duct elements.
      @document: The document.
      @placeholderIds: A collection of element IDs of duct placeholders.
      Returns: A collection of element IDs of ducts and fittings.

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalSystem
Full Name: Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem

Description: Represents an analytical system where the air or water is circulated to satisfy building energy requirements.
Inherits: Element
Implements: IDisposable

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
Implements: IDisposable

  METHODS:
    Construction GetBuildingConstruction(ConstructionType constructionType)
      Description: Gets the current Building Construction from the project information.
      @constructionType: The Construction Type of Building Construction.
      Returns: The Building Construction of the Project Information.
    bool GetBuildingConstructionOverride(ConstructionType constructionType)
      Description: Gets the Building Construction override for a ConstructionType.
      @constructionType: The ConstructionType override value to get.
      Returns: True if analytical construction properties specified in Constructions.xml are used for the given ConstructionType, false otherwise.
    ICollection<Construction> GetConstructions(ConstructionType constructionType)
      Description: Gets all the Building Constructions corresponding to the specific Construction type.
      @constructionType: The Construction Type of Building Construction.
      Returns: A collection containing Building constructions matching the construction type.
    void SetBuildingConstruction(ConstructionType constructionType, Construction buildingConstruction)
      Description: Sets the Building Construction of the Project Information.
      @constructionType: The Construction Type of Building Construction.
      @buildingConstruction: The Building Construction to be set.
    void SetBuildingConstructionOverride(ConstructionType constructionType, bool override)
      Description: Sets the Building Construction override for a ConstructionType.
      @constructionType: The ConstructionType to override.
      @override: True to use analytical construction properties specified in Constructions.xml in the given ConstructionType, false otherwise.

--------------------------------------------------------------------------------

[CLASS] MEPBuildingConstructionSet
Full Name: Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet

Description: A set that contains MEPBuildingConstructions.
Inherits: APIObject
Implements: IDisposable, IEnumerable

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
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new MEPBuildingConstructionSetIterator()

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
Implements: IDisposable

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
    IList<ElementId> GetElementIds()
      Description: Gets all element ids that are contained in the section.
    double GetPressureDrop(ElementId elemId)
      Description: Gets the pressure drop for the specified element id in this section.
      @elemId: The element id which can be duct segment, duct fitting , pipe segment and pipe fitting.
    double GetSegmentLength(ElementId segmentId)
      Description: Get the length for the specified segment id in this section.
      @segmentId: The element id which can be duct segment and pipe segment.
    bool IsMain(ElementId fittingId)
      Description: Check whether the type of fitting in this section is main.
      @fittingId: The element id which can be duct fitting and pipe fitting.
      Returns: True if the type of fitting in this section is main False if the type of fitting in this section is branch

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NumberOfPeople = 0
    - AreaPerPerson = 1
    - BySpaceType = -1

[ENUM] ReturnAirflowType
Full Name: Autodesk.Revit.DB.Mechanical.ReturnAirflowType

Description: An enumerated type listing all the possible return airflow types for a space object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Specified = 0
    - SpecifiedSupplyAirflow = 1
    - CalculatedSupplyAirflow = 2
    - ActualSupplyAirflow = 3

[ENUM] RiseDropSymbol
Full Name: Autodesk.Revit.DB.Mechanical.RiseDropSymbol

Description: This enumeration corresponds to the rise/drop symbol used in mechanical systems
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[CLASS] Space
Full Name: Autodesk.Revit.DB.Mechanical.Space

Description: Provides access to the space topology in Autodesk Revit.
Remarks: The space object can be queried for its boundary for use in space planning tools.
Inherits: SpatialElement
Implements: IDisposable

  PROPERTIES:
    double ActualExhaustAirflow { get; }
      Description: Get the Actual Exhaust Airflow of the Space.
    double ActualHVACLoad { get; }
      Description: Get the Actual HVAC Load of the Space.
    double ActualLightingLoad { get; }
      Description: Get the Actual Lighting Load of the Space.
    double ActualOtherLoad { get; }
      Description: Get the Actual Other Load of the Space.
    double ActualPowerLoad { get; }
      Description: Get the Actual Power Load of the Space.
    double ActualReturnAirflow { get; }
      Description: Get the Actual Return Airflow of the Space.
    double ActualSupplyAirflow { get; }
      Description: Get the Actual Supply Airflow of the Space.
    double AirChangesPerHour { get; }
      Description: Get the Specified AirChangesPerHour of the Space.
    double AreaperPerson { get; set; }
      Description: Get or set the Area per Person of the Space.
    double AverageEstimatedIllumination { get; }
      Description: Get the Average Estimated Illumination of the Space.
    BaseLoadOn BaseHeatLoadOn { get; set; }
      Description: The heat load-on.
    double BaseOffset { get; set; }
      Description: Get or set the Base Offset of the Space.
    double CalculatedCoolingLoad { get; }
      Description: Get the Calculated Cooling Load of the Space.
    double CalculatedHeatingLoad { get; }
      Description: Get the Calculated Heating Load of the Space.
    double CalculatedSupplyAirflow { get; }
      Description: Get the Calculated Supply Airflow of the Space.
    double CeilingReflectance { get; set; }
      Description: Get or set the Ceiling Reflectance of the Space.
    GeometryElement ClosedShell { get; }
      Description: Return the closedShell of the space.
    ConditionType ConditionType { get; set; }
      Description: Get or set the Condition type of the Space.
    double DesignCoolingLoad { get; set; }
      Description: Get or set the Design Cooling Load of the Space.
    double DesignExhaustAirflow { get; set; }
      Description: Get or set the Specified Exhaust Airflow of the Space.
    double DesignHeatingLoad { get; set; }
      Description: Get or set the Design Heating Load of the Space.
    double DesignHVACLoadperArea { get; set; }
      Description: Get or set the Design HVAC Load per Area of the Space.
    double DesignLightingLoad { get; set; }
      Description: Get or set the Design Lighting Load of the Space.
    double DesignOtherLoadperArea { get; set; }
      Description: Get or set the Design Other Load per Area of the Space.
    double DesignPowerLoad { get; set; }
      Description: Get or set the Design Power Load of the Space.
    double DesignReturnAirflow { get; set; }
      Description: Get or set the Specified Return Airflow of the Space.
    double DesignSupplyAirflow { get; set; }
      Description: Get or set the Specified Supply Airflow of the Space.
    double FloorReflectance { get; set; }
      Description: Get or set the Floor Reflectance of the Space.
    double LatentHeatGainperPerson { get; set; }
      Description: Get or set the Latent Heat Gain per Person of the Space.
    double LightingCalculationWorkplane { get; set; }
      Description: Get or set the Lighting Calculation Workplane of the Space.
    BaseLoadOn LightingLoadUnit { get; set; }
      Description: Get or set the Lighting Load Unit of the Space.
    double LimitOffset { get; set; }
      Description: Get or set the Limit Offset of the Space.
    double NumberofPeople { get; set; }
      Description: Get or set the Number of People of the Space.
    OccupancyUnit OccupancyUnit { get; set; }
      Description: Get or set the Occupancy Unit of the Space.
    bool Occupiable { get; }
      Description: Reports whether this zone is Occupiable or not.
    double OutdoorAirflow { get; }
      Description: Get the Outdoor Airflow of the Space.
    OutdoorAirFlowStandard OutdoorAirFlowStandard { get; }
      Description: Get the OutdoorAirFlowStandard of the Space.
    double OutdoorAirPerArea { get; }
      Description: Get the Specified OutdoorAirPerArea of the Space.
    double OutdoorAirPerPerson { get; }
      Description: Get the Specified OutdoorAirPerPerson of the Space.
    bool Plenum { get; }
      Description: Reports whether this zone is Plenum or not.
    BaseLoadOn PowerLoadUnit { get; set; }
      Description: Get or set the Power Load Unit of the Space.
    ReturnAirflowType ReturnAirflow { get; set; }
      Description: Get or set the Return type of Supply Airflow of the Space.
    Room Room { get; }
      Description: Return the Room of the space.
    double SensibleHeatGainperPerson { get; set; }
      Description: Get or set the Sensible Heat Gain per Person of the Space.
    double SpaceCavityRatio { get; }
      Description: Get the Space Cavity Ratio of the Space.
    MEPSpaceConstruction SpaceConstruction { get; }
      Description: Get the Space Construction of the Space.
    SpaceType SpaceType { get; set; }
      Description: Get or set the Space type of the Space.
    ElementId SpaceTypeId { get; set; }
      Description: Get or set the Space type element of the Space.
    double UnboundedHeight { get; }
      Description: Get the Unbounded Height of the Space.
    Level UpperLimit { get; set; }
      Description: Get or set the Upper Limit of the Space.
    double Volume { get; }
      Description: Get the Volume of the Space.
    double WallReflectance { get; set; }
      Description: Get or set the Wall Reflectance of the Space.
    Zone Zone { get; }
      Description: Reports this space belong to which Zone.

  METHODS:
    bool IsPointInSpace(XYZ point)
      Description: Determines if a point lies within the volume of the Space.
      @point: Point to be checked.

--------------------------------------------------------------------------------

[CLASS] SpaceFilter
Full Name: Autodesk.Revit.DB.Mechanical.SpaceFilter

Description: A filter used to match spaces.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new SpaceFilter()

--------------------------------------------------------------------------------

[CLASS] SpaceSet
Full Name: Autodesk.Revit.DB.Mechanical.SpaceSet

Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new SpaceSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Space item)
    int Erase(Space item)
    SpaceSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Space item)
    SpaceSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SpaceSetIterator
Full Name: Autodesk.Revit.DB.Mechanical.SpaceSetIterator

Description: An iterator to a set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new SpaceSetIterator()

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

[CLASS] SpaceTag
Full Name: Autodesk.Revit.DB.Mechanical.SpaceTag

Description: Provides access to the space tag in Autodesk Revit.
Remarks: The space Tag object can be queried for space information.
Inherits: SpatialElementTag
Implements: IDisposable

  PROPERTIES:
    Space Space { get; }
      Description: The space that the tag is associated with.
    SpaceTagType SpaceTagType { get; set; }
      Description: The tag type.

--------------------------------------------------------------------------------

[CLASS] SpaceTagFilter
Full Name: Autodesk.Revit.DB.Mechanical.SpaceTagFilter

Description: A filter used to match space tags.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new SpaceTagFilter()

--------------------------------------------------------------------------------

[CLASS] SpaceTagType
Full Name: Autodesk.Revit.DB.Mechanical.SpaceTagType

Description: An object that represents a Space Tag style.
Inherits: FamilySymbol
Implements: IDisposable

--------------------------------------------------------------------------------

[ENUM] SpaceType
Full Name: Autodesk.Revit.DB.Mechanical.SpaceType

Description: An enumerated type listing all the possible space types for a space object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - kActiveStorage = 0
    - kActiveStorageHospitalOrHealthcare = 1
    - kAirOrTrainOrBusBaggageArea = 2
    - kAirportConcourse = 3
    - kAtriumEachAdditionalFloor = 4
    - kAtriumFirstThreeFloors = 5
    - kAudienceOrSeatingAreaPenitentiary = 6
    - kAudienceOrSeatingAreaExerciseCenter = 7
    - kAudienceOrSeatingAreaGymnasium = 8
    - kAudienceOrSeatingAreaSportsArena = 9
    - kAudienceOrSeatingAreaConventionCenter = 10
    - kAudienceOrSeatingAreaMotionPictureTheatre = 11
    - kAudienceOrSeatingAreaPerformingArtsTheatre = 12
    - kAudienceOrSeatingAreaReligious = 13
    - kAudienceOrSeatingAreaPoliceOrFireStations = 14
    - kAudienceOrSeatingAreaCourtHouse = 15
    - kAudienceOrSeatingAreaAuditorium = 16
    - kBankCustomerArea = 17
    - kBankingActivityAreaOffice = 18
    - kBarberAndBeautyParlor = 19
    - kCardFileAndCataloguingLibrary = 20
    - kClassroomOrLectureOrTrainingPenitentiary = 21
    - kClassroomOrLectureOrTraining = 22
    - kConfinementCellsPenitentiary = 23
    - kConfinementCellsCourtHouse = 24
    - kConferenceMeetingOrMultipurpose = 25
    - kCorridorOrTransition = 26
    - kCorridorOrTransitionManufacturingFacility = 27
    - kCorridorsWithPatientWaitingExamHospitalOrHealthcare = 28
    - kCourtSportsAreaSportsArena = 29
    - kCourtroomCourtHouse = 30
    - kDepartmentStoreSalesAreaRetail = 31
    - kDetailedManufacturingFacility = 32
    - kDiningArea = 33
    - kDiningAreaHotel = 34
    - kDiningAreaFamilyDining = 35
    - kDiningAreaLoungeOrLeisureDining = 36
    - kDiningAreaMotel = 37
    - kDiningAreaTransportation = 38
    - kDiningAreaPenitentiary = 39
    - kDiningAreaCivilServices = 40
    - kDormitoryBedroom = 41
    - kDormitoryStudyHall = 42
    - kDressingOrLockerOrFittingRoomGymnasium = 43
    - kDressingOrLockerOrFittingRoomCourtHouse = 44
    - kDressingOrLockerOrFittingRoomPerformingArtsTheatre = 45
    - kDressingOrLockerOrFittingRoomAuditorium = 46
    - kDressingOrLockerOrFittingRoomExerciseCenter = 47
    - kElectricalOrMechanical = 48
    - kElevatorLobbies = 49
    - kEmergencyHospitalOrHealthcare = 50
    - kEquipmentRoomManufacturingFacility = 51
    - kExamOrTreatmentHospitalOrHealthcare = 52
    - kExerciseAreaExerciseCenter = 53
    - kExerciseAreaGymnasium = 54
    - kExhibitSpaceConventionCenter = 55
    - kFellowshipHallReligiousBuildings = 56
    - kFineMaterialWarehouse = 57
    - kFineMerchandiseSalesAreaRetail = 58
    - kFireStationEngineRoomPoliceOrFireStation = 59
    - kFoodPreparation = 60
    - kGarageServiceOrRepairAutomotiveFacility = 61
    - kGeneralHighBayManufacturingFacility = 62
    - kGeneralLowBayManufacturingFacility = 63
    - kGeneralExhibitionMuseum = 64
    - kHospitalNurseryHospitalOrHealthcare = 65
    - kHospitalOrMedicalSuppliesHospitalOrHealthcare = 66
    - kHospitalOrRadiologyHospitalOrHealthcare = 67
    - kHotelOrConferenceCenterConferenceOrMeeting = 68
    - kInactiveStorage = 69
    - kJudgesChambersCourtHouse = 70
    - kLaboratoryOffice = 71
    - kLaundryIroningAndSorting = 72
    - kLaundryWashingHospitalOrHealthcare = 73
    - kLibraryAudioVisualLibraryAudioVisual = 74
    - kLivingQuartersDormitory = 75
    - kLivingQuartersMotel = 76
    - kLivingQuartersHotel = 77
    - kLobby = 78
    - kLobbyReligiousBuildings = 79
    - kLobbyMotionPictureTheatre = 80
    - kLobbyAuditorium = 81
    - kLobbyPerformingArtsTheatre = 82
    - kLobbyPostOffice = 83
    - kLobbyHotel = 84
    - kLoungeOrRecreation = 85
    - kMallConcourseSalesAreaRetail = 86
    - kMassMerchandisingSalesAreaRetail = 87
    - kMediumOrBulkyMaterialWarehouse = 88
    - kMerchandisingSalesAreaRetail = 89
    - kMuseumAndGalleryStorage = 90
    - kNurseStationHospitalOrHealthcare = 91
    - kOfficeEnclosed = 92
    - kOfficeOpenPlan = 93
    - kOfficeCommonActivityAreasInactiveStorage = 94
    - kOperatingRoomHospitalOrHealthcare = 95
    - kOtherTelevisedPlayingAreaSportsArena = 96
    - kParkingAreaAttendantOnlyParkingGarage = 97
    - kParkingAreaPedestrianParkingGarage = 98
    - kPatientRoomHospitalOrHealthcare = 99
    - kPersonalServicesSalesAreaRetail = 100
    - kPharmacyHospitalOrHealthcare = 101
    - kPhysicalTherapyHospitalOrHealthcare = 102
    - kPlayingAreaGymnasium = 103
    - kPlenum = 104
    - kPoliceStationLaboratoryPoliceOrFireStations = 105
    - kPublicAndStaffLoungeHospitalOrHealthcare = 106
    - kReadingAreaLibrary = 107
    - kReceptionOrWaitingTransportation = 108
    - kReceptionOrWaitingMotel = 109
    - kReceptionOrWaitingHotel = 110
    - kRecoveryHospitalOrHealthcare = 111
    - kRestorationMuseum = 112
    - kRestrooms = 113
    - kRingSportsAreaSportsArena = 114
    - kSleepingQuartersPoliceOrFireStation = 115
    - kSortingAreaPostOffice = 116
    - kSpecialtyStoreSalesAreaRetail = 117
    - kStacksLibrary = 118
    - kStairsInactive = 119
    - kStairway = 120
    - kSupermarketSalesAreaRetail = 121
    - kTerminalTicketCounterTransportation = 122
    - kWorkshopWorkshop = 123
    - kWorshipPulpitChoirReligious = 124
    - kNoOfSpaceTypes = 125
    - NoSpaceType = -1

[ENUM] SystemCalculationLevel
Full Name: Autodesk.Revit.DB.Mechanical.SystemCalculationLevel

Description: Enumerated type listing flags that can toggle on or off certain calculations related to MEP systems.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Flow = 1
    - Volume = 2
    - Performance = 4
    - All = -1

[CLASS] SystemZoneData
Full Name: Autodesk.Revit.DB.Mechanical.SystemZoneData

Description: Represents the specific domain requirements for a system-zone used in MEP design.
Remarks: A system-zone is used to specify what parts of a building are served by specific equipment, air systems and water loops without having to physically model them. A system-zone is represented as a GenericZone element with a domain data of type SystemZoneData, which contains specific domain requirements for the purpose of analysis.
Inherits: GenericZoneDomainData
Implements: IDisposable

  PROPERTIES:
    ElementId ZoneEquipmentId { get; set; }
      Description: The id of the zone equipment related to the zone.

  METHODS:
    static SystemZoneData Create()
      Description: Creates a new instance of a system-zone data domain class.
      Returns: The newly created data domain instance.

--------------------------------------------------------------------------------

[ENUM] WaterChillerType
Full Name: Autodesk.Revit.DB.Mechanical.WaterChillerType

Description: The type of water chiller.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AirCooled = 0
    - WaterCooled = 1

[CLASS] WaterLoopData
Full Name: Autodesk.Revit.DB.Mechanical.WaterLoopData

Description: Represents the data and parameters of analytical water loop.
Implements: IDisposable

  PROPERTIES:
    WaterChillerType ChillerType { get; set; }
      Description: The type of water chiller. Note this property change would reset the condenser water loop.
    ElementId CondenserWaterLoopId { get; set; }
      Description: The water loop element id for the water cooled chiller.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    WaterLoopType WaterLoopType { get; set; }
      Description: The type of water loop. Note this property change would reset other properties.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] WaterLoopType
Full Name: Autodesk.Revit.DB.Mechanical.WaterLoopType

Description: The type of water loop.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - ChilledWater = 1
    - CondenserWater = 2
    - HotWater = 3
    - VRF = 4

[CLASS] Zone
Full Name: Autodesk.Revit.DB.Mechanical.Zone

Description: A zone is a collection of one or more spaces.
Remarks: The concept of zones is central to the way in which engineers design HVAC systems. When you are designing HVAC systems, you relate to zones as spaces that are under the same thermostatic control. Conceptually, zones are an arbitrary set of areas or volumes within a building that is controlled by one thermostat. An area based load is a collection of one or more electrical load areas. When it has the AreaBasedLoadData, it is an area based load, otherwise, it is a zone.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: Get the Area of the Zone.
    CurveArray Boundary { get; }
      Description: Returns the boundary of the Zone.
    double CalculatedCoolingLoad { get; }
      Description: Get the Calculated Cooling Load of the Zone.
    double CalculatedHeatingLoad { get; }
      Description: Get the Calculated Heating Load of the Zone.
    double CalculatedSupplyAirflow { get; }
      Description: Get the Calculated Supply Airflow of the Zone.
    double CoolingAirTemperature { get; set; }
      Description: Get or set the Cooling Air Temperature of the Zone.
    double CoolingSetPoint { get; set; }
      Description: Get or set the Cooling Set Point of the Zone.
    double DehumidificationSetPoint { get; set; }
      Description: Get or set the DeHumidification Set Point of the Zone.
    double GrossArea { get; }
      Description: Get the Gross Area of the Zone.
    double GrossVolume { get; }
      Description: Get the Gross Volume of the Zone.
    double HeatingAirTemperature { get; set; }
      Description: Get or set the Heating Air Temperature of the Zone.
    double HeatingSetPoint { get; set; }
      Description: Get or set the Heating Set Point of the Zone.
    double HumidificationSetPoint { get; set; }
      Description: Get or set the Humidification Set Point of the Zone.
    bool IsDefaultZone { get; set; }
      Description: Reports whether this zone is default or not.
    string Name { set; }
      Description: Get or Set the Name of the Zone.
    double Perimeter { get; }
      Description: Get the Perimeter of the Zone.
    Phase Phase { get; }
      Description: Get the Phase of the Zone.
    ServiceType ServiceType { get; set; }
      Description: Get or set the Service Type of the Zone.
    SpaceSet Spaces { get; }
      Description: Get the Spaces of the Zone.
    double Volume { get; }
      Description: Get the Volume of the Zone.

  METHODS:
    bool AddSpaces(SpaceSet spaces)
      Description: Add a set of existing spaces to Zone element.
      @spaces: The spaces which want to add to zone element.
      Returns: If successful the current zone element will add a set of input spaces, otherwise .
    static Zone CreateAreaBasedLoad(Document doc, string name, ElementId levelId, ElementId phaseId)
      Description: Creates a new instance of an area based load and adds it to the document.
      @doc: The document where the element will be created and added.
      @name: The name of the area based load to be created.
      @levelId: The base level on which the area based load will be created.
      @phaseId: The associative phase on which the area based load is to exist.
      Returns: The newly created area based load.
    ZoneElementDomainData GetDomainData()
      Description: Gets the domain data for the zone.
      Returns: Returns a pointer to the base class for specific domain requirements for the zone.
    bool RemoveSpaces(SpaceSet spaces)
      Description: Remove a set of existing spaces to the current Zone element.
      @spaces: The spaces which want to delete from the current zone element.
      Returns: If successful the current zone element will remove a set of input spaces, otherwise .

--------------------------------------------------------------------------------

[CLASS] ZoneElementDomainData
Full Name: Autodesk.Revit.DB.Mechanical.ZoneElementDomainData

Description: A base class for specific domain requirements for a zone.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ZoneEquipment
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipment

Description: Represents an early-stage equipment placeholder that provides heating or cooling to part of air system or water loop.
Remarks: A zone equipment is different from physical equipment. Depending on its behavior type, it may be mapped to multiple physical equipment later.
Inherits: Element
Implements: IDisposable

  METHODS:
    static ZoneEquipment Create(Document document, string name)
      Description: Creates a new zone equipment
      @document: The document where the new element will be created.
      @name: The name of new zone equipment. The actual name may be post-fixed if already exists.
      Returns: The newly created zone equipment.
    static ISet<ElementId> GetAssociatedZoneEquipment(Document document, ISet<ElementId> spaces)
      Description: Gets the associated zone equipment of all specified analytical spaces.
      @document: The document where the analytical spaces and zone equipment exist.
      @spaces: The specified analytical spaces.
      Returns: All associated zone equipment, either explicitly assigned or implicitly assigned via system-zone.
    static ISet<ElementId> GetAssociatedZoneEquipment(Document document, ElementId spaceElementId)
      Description: Gets the associated zone equipment of the specified analytical space.
      @document: The document where the analytical spaces and zone equipment exist.
      @spaceElementId: The specified analytical spaces.
      Returns: All associated zone equipment, either explicitly assigned or implicitly assigned via system-zone.
    ZoneEquipmentData GetZoneEquipmentData()
      Description: Gets the zone equipment data.
    static void MoveSpaceToEquipment(Document document, ISet<ElementId> analyticalSpaceSet, ElementId originalZoneEquipmentId, ElementId targetZoneEquipmentId)
      Description: Moves the selected analytical spaces from the identified zone equipment to another target zone equipment.
      @document: The document where the zone equipment and the analytical spaces exist.
      @analyticalSpaceSet: The specified analytical spaces to move.
      @originalZoneEquipmentId: The original equipment where the analytical spaces will be removed. If passing invalidElementId, the existing zone equipment is not removed.
      @targetZoneEquipmentId: The target zone equipment where the analytical spaces will be associated. If passing invalidElementId, the analytical spaces will not be assigned to any new zone equipment.

--------------------------------------------------------------------------------

[ENUM] ZoneEquipmentBehavior
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipmentBehavior

Description: The behavior of zone equipment associated with spaces.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - OnePerSpace = 0
    - GroupSpaces = 1

[CLASS] ZoneEquipmentData
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipmentData

Description: Represents the data and parameters of analytical zone equipment.
Implements: IDisposable

  PROPERTIES:
    ElementId AirSystemId { get; set; }
      Description: The air system used for this zone equipment, if applicable.
    ElementId ChilledWaterLoopId { get; set; }
      Description: The chilled water loop used for the chilled water option of cooling coil.
    ElementId CondenserWaterLoopId { get; set; }
      Description: The condenser water loop used for the direction expansion water cooled option of cooling coil.
    AirCoolingCoilType CoolingCoilType { get; set; }
      Description: The type of cooling coil. Note this property change would reset the chilled water loop.
    ZoneEquipmentBehavior EquipmentBehavior { get; set; }
      Description: The behavior of how zone equipment is allocated with assigned spaces.
    ZoneEquipmentHvacType EquipmentType { get; set; }
      Description: The type of zone equipment. Note this property would reset other properties.
    AirHeatingCoilType HeatingCoilType { get; set; }
      Description: The type of heating coil. Note this property change would reset the hot water loop.
    ElementId HotWaterLoopId { get; set; }
      Description: The water loop element id for the hot-water heating coil.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId VRFLoopId { get; set; }
      Description: The Varible Refrigerant Flow loop for the VRF fan coil equipment type.

  METHODS:
    void Dispose()
    bool IsDataCompleted()
      Description: Is the required data completed for this zone equipment?

--------------------------------------------------------------------------------

[ENUM] ZoneEquipmentHvacType
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipmentHvacType

Description: The type of zone equipment.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - ChilledBeamActive = 1
    - FourPipeFanCoil = 2
    - PackagedTerminalAirConditioner = 3
    - PackagedTerminalHeatPump = 4
    - ParallelFanPoweredBox = 5
    - VAVBox = 6
    - CAVBox = 9
    - RadiantPanel = 10
    - SeriesFanPoweredBox = 11
    - UnitHeater = 12
    - UnitVentilator = 13
    - WaterSourceHeatPump = 14
    - ChilledBeamPassive = 15
    - Unconditioned = 16
    - VRFFanCoil = 17


