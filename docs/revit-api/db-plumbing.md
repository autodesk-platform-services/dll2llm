# Autodesk.Revit.DB.Plumbing


NAMESPACE: Autodesk.Revit.DB.Plumbing
--------------------------------------------------------------------------------

[CLASS] FlexPipe
Full Name: Autodesk.Revit.DB.Plumbing.FlexPipe

Description: A flex pipe in the Autodesk Revit MEP product.
Remarks: The flex pipe is only available in the Autodesk Revit MEP product.
Inherits: MEPCurve
Implements: IDisposable

  PROPERTIES:
    XYZ EndTangent { get; set; }
      Description: Gets or sets the tangent vector at the end of the curve. The invalid or zero vector is ignored when setting the tangent.
    FlexPipeType FlexPipeType { get; set; }
      Description: The flex pipe type of this flex pipe.
    PipeFlowState FlowState { get; }
      Description: The flow state of the pipe.
    IList<XYZ> Points { get; set; }
      Description: The points of the flex pipe.
    XYZ StartTangent { get; set; }
      Description: Gets or sets the tangent vector at the start of the curve. The invalid or zero vector is ignored when setting the tangent.

  METHODS:
    static FlexPipe Create(Document document, ElementId systemTypeId, ElementId pipeTypeId, ElementId levelId, XYZ startTangent, XYZ endTangent, IList<XYZ> points)
      Description: Creates a new flexible pipe into the document, using a point array and flex pipe type.
      @document: The document.
      @systemTypeId: The id of the piping system type.
      @pipeTypeId: The id of the flexible pipe.
      @levelId: The level id for the flexible pipe.
      @startTangent: The tangent vector at the start of the curve. The invalid or zero vector is ignored.
      @endTangent: The tangent vector at the end of the curve. The invalid or zero vector is ignored.
      @points: The point array indicating the path of the flexible pipe, including the end point.
      Returns: If creation was successful then a new flexible pipe is returned, otherwise an exception with failure information will be thrown.
    static FlexPipe Create(Document document, ElementId systemTypeId, ElementId pipeTypeId, ElementId levelId, IList<XYZ> points)
      Description: Creates a new flexible pipe into the document, using a point array and flex pipe type.
      @document: The document.
      @systemTypeId: The id of the piping system type.
      @pipeTypeId: The id of the flexible pipe.
      @levelId: The level id for the flexible pipe.
      @points: The point array indicating the path of the flexible pipe, including the end point.
      Returns: If creation was successful then a new flexible pipe is returned, otherwise an exception with failure information will be thrown.
    static bool IsFlexPipeTypeId(Document document, ElementId pipeTypeId)
      Description: Checks if given type is valid flexible pipe type.
      @document: The document.
      @pipeTypeId: ElementId of the flexible pipe type to check.
      Returns: True if flexible pipe type can used for this pipe, false otherwise.
    static bool IsPipingSystemTypeId(Document document, ElementId systemTypeId)
      Description: Checks if given type is valid piping system type.
      @document: The document.
      @systemTypeId: ElementId of the piping system type to check.
      Returns: True if the given systemTypeId is the piping system type, false otherwise.

--------------------------------------------------------------------------------

[CLASS] FlexPipeType
Full Name: Autodesk.Revit.DB.Plumbing.FlexPipeType

Description: A flex pipe type in the Autodesk Revit MEP product.
Remarks: The flex pipe type is only available in the Autodesk Revit MEP product.
Inherits: MEPCurveType
Implements: IDisposable

--------------------------------------------------------------------------------

[ENUM] FlowConversionMode
Full Name: Autodesk.Revit.DB.Plumbing.FlowConversionMode

Description: Enumerated type listing possible flow conversion modes for piping calculations.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Valves = 0
    - Tanks = 1
    - Invalid = -1

[CLASS] FluidTemperature
Full Name: Autodesk.Revit.DB.Plumbing.FluidTemperature

Description: Represents the dynamic viscosity and density properties as defined at a certain temperature.
Implements: IDisposable

  CONSTRUCTORS:
    new FluidTemperature(double temperature, double viscosity, double density)

  PROPERTIES:
    double Density { get; set; }
      Description: The density value
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Temperature { get; set; }
      Description: The temperature value
    double Viscosity { get; set; }
      Description: The dynamic viscosity value

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] FluidTemperatureSetIterator
Full Name: Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator

Description: An iterator to a set of FluidTemperature from FluidType.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    FluidTemperature Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    FluidTemperature GetCurrent()
      Description: Returns the current FluidTemperature.
      Returns: The current FluidTemperature.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] FluidType
Full Name: Autodesk.Revit.DB.Plumbing.FluidType

Description: Has been extended to provide read and write access to a collection of FluidTemperature objects which represent the fluid's properties at various temperatures.
Inherits: ElementType
Implements: IDisposable, IEnumerable`1, IEnumerable

  METHODS:
    void AddTemperature(FluidTemperature fluidTemperature)
      Description: Adds a fluid temperature to the set.
      @fluidTemperature: The fluid temperature being inserted.
    void ClearAllTemperatures()
      Description: Clears all fluid temperatures in the set.
    static FluidType Create(Document document, string fluidTypeName, FluidType basedOnFluidType)
      Description: Creates a new fluid type and adds it to the document.
      @document: The document.
      @fluidTypeName: The name of new created fluid type.
      @basedOnFluidType: The existing fluid type which is based on.
      Returns: The newly created fluid type.
    static FluidType Create(Document document, string fluidTypeName)
      Description: Creates a new empty fluid type and adds it to the document.
      @document: The document.
      @fluidTypeName: The name of fluid type.
      Returns: The newly created fluid type.
    IEnumerator<FluidTemperature> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    FluidTemperatureSetIterator GetFluidTemperatureSetIterator()
      Description: Returns a FluidTemperatureSetIterator that iterates through the collection.
      Returns: A FluidTemperatureSetIterator object that can be used to iterate through key-value pairs in the collection.
    static FluidType GetFluidType(Document document, string fluidTypeName)
      Description: Gets a fluid type by name.
      @document: The document.
      @fluidTypeName: The name of fluid type.
      Returns: The fluid type. if the fluid type was not found.
    FluidTemperature GetTemperature(double temperature)
      Description: Gets a copy of the FluidTemperature object matching a given temperature value.
      @temperature: The temperature value.
      Returns: The fluid temperature. if not found.
    static bool IsFluidInUse(Document document, ElementId fluidId)
      Description: Identifies if the fluid type is in use.
      @document: The document.
      @fluidId: The id of the fluid type.
      Returns: True if the fluid type is in use. False if the fluid type is not in use.
    void RemoveTemperature(double temperature)
      Description: Removes a fluid temperature via the temperature value from the set.
      @temperature: The temperature value.

--------------------------------------------------------------------------------

[INTERFACE] IPipeFittingAndAccessoryPressureDropServer
Full Name: Autodesk.Revit.DB.Plumbing.IPipeFittingAndAccessoryPressureDropServer

Description: Interface class for external servers implementing pipe fitting and pipe accessory coefficient calculation.
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interface Create a new server object and register it with the service, see ExternalServiceRegistry.Assign server to pipe fitting instance.
Implements: IExternalServer

  METHODS:
    bool Calculate(PipeFittingAndAccessoryPressureDropData data)
      Description: Calculate the pipe fitting and pipe accessory coefficient.
      @data: The input and output data of the calculation.
      Returns: True if calculation succeeds. False if calculation fails.
    Schema GetDataSchema()
      Description: Obtains the schema of the ESEntity.
      Returns: Null if the server has no data.
    bool IsApplicable(PipeFittingAndAccessoryPressureDropData data)
      Description: Check if the server is applicable for the pipe fitting or pipe accessory.
      @data: The input data of the calculation.

--------------------------------------------------------------------------------

[INTERFACE] IPipePlumbingFixtureFlowServer
Full Name: Autodesk.Revit.DB.Plumbing.IPipePlumbingFixtureFlowServer

Description: Interface class for external servers implementing Pipe plumbing fixture flow calculation.
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interface Create a new server object and register it with the service, see ExternalServiceRegistry.Assign server for the plumbing flow conversion in PipeSettings.
Implements: IExternalServer

  METHODS:
    void Calculate(PipePlumbingFixtureFlowData data)
      Description: Calculate the pipe plumbing fixture flow.
      @data: The input and output data of the calculation.
    string GetHtmlDescription()
      Description: The method that Revit will invoke to get an HTML formatted description of the server.
      Returns: The HTML format description of the server.
    string GetInformationLink()
      Description: The method that Revit will invoke to obtain a URL address which provides more information about the server.
      Returns: The URL providing server information.

--------------------------------------------------------------------------------

[INTERFACE] IPipePressureDropServer
Full Name: Autodesk.Revit.DB.Plumbing.IPipePressureDropServer

Description: Interface for external servers implementing pipe pressure drop calculation.
Remarks: A typical way to use the external server can be: Implement a server class that derives from this interface Create a new server object and register it with the service, see ExternalServiceRegistry.Assign server for the pipe pressure drop calculation in PipeSettings.
Implements: IExternalServer

  METHODS:
    void Calculate(PipePressureDropData data)
      Description: Calculate the pipe pressure drop.
      @data: The input and output data of the calculation.
    string GetHtmlDescription()
      Description: The method that Revit will invoke to get an HTML formatted description of the server.
      Returns: The HTML format description of the server.
    string GetInformationLink()
      Description: The method that Revit will invoke to obtain a URL address which provides more information about the server.
      Returns: The URL providing server information.

--------------------------------------------------------------------------------

[CLASS] Pipe
Full Name: Autodesk.Revit.DB.Plumbing.Pipe

Description: A pipe in the Autodesk Revit MEP product.
Remarks: The pipe is only available in the Autodesk Revit MEP product.
Inherits: MEPCurve
Implements: IDisposable

  PROPERTIES:
    PipeFlowState FlowState { get; }
      Description: The flow state of the pipe.
    bool IsPlaceholder { get; }
      Description: Identifies if the pipe is a placeholder or not.
    PipeSegment PipeSegment { get; }
      Description: The pipe segment that was assigned to this pipe according to the routing preference.
    PipeType PipeType { get; set; }
      Description: The pipe type of this pipe.

  METHODS:
    static Pipe Create(Document document, ElementId pipeTypeId, ElementId levelId, Connector startConnector, Connector endConnector)
      Description: Creates a new pipe that connects to two connectors.
      @document: The document.
      @pipeTypeId: The ElementId of the new pipe type.
      @levelId: The level ElementId for the new pipe.
      @startConnector: The first connector where the new pipe starts.
      @endConnector: The second point of the new pipe.
      Returns: The pipe.
    static Pipe Create(Document document, ElementId pipeTypeId, ElementId levelId, Connector startConnector, XYZ endPoint)
      Description: Creates a new pipe that connects to the connector.
      @document: The document.
      @pipeTypeId: The ElementId of the new pipe type.
      @levelId: The level id for the new pipe.
      @startConnector: The first connector where the new pipe starts.
      @endPoint: The second point of the new pipe.
      Returns: The pipe.
    static Pipe Create(Document document, ElementId systemTypeId, ElementId pipeTypeId, ElementId levelId, XYZ startPoint, XYZ endPoint)
      Description: Creates a new pipe from two points.
      @document: The document.
      @systemTypeId: The ElementId of the piping system type.
      @pipeTypeId: The ElementId of the pipe type.
      @levelId: The level ElementId for the pipe.
      @startPoint: The start point of the pipe.
      @endPoint: The end point of the pipe.
      Returns: The pipe.
    static Pipe CreatePlaceholder(Document document, ElementId systemTypeId, ElementId pipeTypeId, ElementId levelId, XYZ startPoint, XYZ endPoint)
      Description: Creates a new placeholder pipe.
      @document: The document.
      @systemTypeId: The ElementId of the piping system type.
      @pipeTypeId: The ElementId of the pipe type.
      @levelId: The level id for the pipe.
      @startPoint: The first point of the placeholder line.
      @endPoint: The second point of the placeholder line.
      Returns: The placeholder pipe.
    static bool IsPipeTypeId(Document document, ElementId pipeTypeId)
      Description: Checks if given type is valid pipe type.
      @document: The document.
      @pipeTypeId: ElementId of the pipe type to check.
      Returns: True if pipe type can used for this pipe, false otherwise.
    static bool IsPipingConnector(Connector connector)
      Description: Checks if the given connector is a valid piping connector.
      @connector: Connector to check
      Returns: True if the connector has the Piping domain type.
    static bool IsPipingSystemTypeId(Document document, ElementId systemTypeId)
      Description: Checks if given type is valid piping system type.
      @document: The document.
      @systemTypeId: ElementId of the piping system type to check.
      Returns: True if the given systemTypeId is the piping system type, false otherwise.
    void SetSystemType(ElementId systemTypeId)
      Description: Updates the associated system type for the pipe.
      @systemTypeId: The ElementId of the piping system type.

--------------------------------------------------------------------------------

[CLASS] PipeFittingAndAccessoryConnectorData
Full Name: Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData

Description: The input data used by external servers for calculation of the pipe fitting and pipe accessory coefficient.
Remarks: width, height, diameter, flow, velocity pressure and connector index are input data for the calculation,
Implements: IDisposable

  PROPERTIES:
    double Angle { get; }
      Description: The angle of the fitting, Units:(rad).
    double Diameter { get; }
      Description: The connector diameter, Units:(ft).
    double Flow { get; }
      Description: The connector flow, Units:(ftÃ‚Â³/s)
    FlowDirectionType FlowDirection { get; }
      Description: The flow direction of this connector, In or Out.
    double Height { get; }
      Description: The connector height, Units:(ft).
    int Index { get; }
      Description: Return the index of this connector
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int LinkIndex { get; }
      Description: The index of the connector which is linked with this connector
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

[CLASS] PipeFittingAndAccessoryData
Full Name: Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData

Description: The input data used by external servers for calculation of the pipe fitting and pipe accessory coefficient.
Remarks: A FamilyInstance is the input data for the calculation, and the result is coefficient for each connector.
Implements: IDisposable

  PROPERTIES:
    int BehaviorType { get; }
      Description: The behavior type of the pipe fitting or pipe accessory.
    double FluidDensity { get; }
      Description: The fluid density of the pipe fitting or pipe accessory, Units: (kg/ftÃ‚Â³).
    double FluidViscosity { get; }
      Description: The fluid dynamic viscosity of the pipe fitting or pipe accessory, Units: (kg/(ftÃ‚Â·s)).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Origin { get; }
      Description: The origin position of the pipe fitting or pipe accessory.
    PartType PartType { get; }
      Description: The part type of the pipe fitting or pipe accessory.
    Guid ServerGUID { get; }
      Description: The GUID of the pipe fitting or pipe accessory.
    MEPSystemClassification SystemClassification { get; }
      Description: The system classification of the pipe fitting or pipe accessory.

  METHODS:
    void Dispose()
    IList<PipeFittingAndAccessoryConnectorData> GetAllConnectorData()
      Description: Gets the connector data of the pipe fitting or pipe accessory.
      Returns: All connector data.
    Entity GetEntity()
      Description: Returns an Entity of the Schema of the serverGUID.
      Returns: The Entity.
    ElementId GetFamilyInstanceId()
      Description: Gets the Id of the fiting or accessory instance
      Returns: The element Id of the fiting or accessory instance.

--------------------------------------------------------------------------------

[CLASS] PipeFittingAndAccessoryPressureDropData
Full Name: Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData

Description: The input and output data used by external servers for calculation of the pipe fitting and pipe accessory pressure drop.
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
    PipeFittingAndAccessoryData GetPipeFittingAndAccessoryData()
      Description: Returns the fitting and accessory information
    IList<PipeFittingAndAccessoryPressureDropItem> GetPresureDropItems()
      Description: Returns the pressure drop items
    void SetDefaultEntity(Entity defaultEntity)
      Description: Stores the default entity in the data.
      @defaultEntity: The Entity to be stored.

--------------------------------------------------------------------------------

[CLASS] PipeFittingAndAccessoryPressureDropItem
Full Name: Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropItem

Description: A flow path of the pipe/pipe fitting and accessory. It is defined by the begin connector and end connector
Implements: IDisposable

  PROPERTIES:
    int BeginConnectorIndex { get; }
      Description: The index of the begin connector of the flow path
    double Coefficient { get; set; }
      Description: The coefficient between the begin connector and end connector, Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
    int EndConnectorIndex { get; }
      Description: The index of the end conector of the flow path
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double VelocityPressure { get; }
      Description: The velocity pressure, for converting between coefficient and pressure drop on this flow path. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] PipeFlowConfigurationType
Full Name: Autodesk.Revit.DB.Plumbing.PipeFlowConfigurationType

Description: An enumerated type listing all connector flow configuration
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Calculated = 0
    - Preset = 1
    - System = 2
    - Demand = 3

[ENUM] PipeFlowState
Full Name: Autodesk.Revit.DB.Plumbing.PipeFlowState

Description: An enumerated type listing all the pipe flow states for a pipe
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - LaminarState = 0
    - TransitionState = 1
    - TurbulentState = 2
    - MultiValues = -1

[CLASS] PipeInsulation
Full Name: Autodesk.Revit.DB.Plumbing.PipeInsulation

Description: Represents insulation applied to the outside of a given pipe, fitting or content.
Inherits: InsulationLiningBase
Implements: IDisposable

  METHODS:
    static PipeInsulation Create(Document document, ElementId pipeOrContentElementId, ElementId pipeInsulationTypeId, double Thickness)
      Description: Creates a new instance of pipe insulation.
      @document: The document.
      @pipeOrContentElementId: The pipe, fitting, accessory ElementId to which insulation will be added.
      @pipeInsulationTypeId: The pipe insulation type. If the input pipe insulation type is InvalidElementId, the default insulation type from the document will be used.
      @Thickness: The thickness of the insulation.
      Returns: The newly created pipe insulation.

--------------------------------------------------------------------------------

[CLASS] PipeInsulationType
Full Name: Autodesk.Revit.DB.Plumbing.PipeInsulationType

Description: This class represents a pipe insulation type in Autodesk Revit.
Inherits: ElementType
Implements: IDisposable

--------------------------------------------------------------------------------

[ENUM] PipeLossMethodType
Full Name: Autodesk.Revit.DB.Plumbing.PipeLossMethodType

Description: An enumerated type listing all pipe loss method types for a connector
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotDefined = 0
    - Table = 1
    - SpecificLoss = 4
    - Coefficient = 6

[CLASS] PipePlumbingFixtureFlowData
Full Name: Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData

Description: The input and output data used by external servers for calculation of the pipe plumbing fixture flow.
Remarks: FlowConfiguration, FixtureUnits, FlowConversionMode, and DimensionFlow are input field values for the calculation. Flow is output field value for the calculation.
Implements: IDisposable

  PROPERTIES:
    double DimensionFlow { get; }
      Description: The dimension flow which is used to calculate flow of the pipe. Units: (gal/min).
    double FixtureUnits { get; }
      Description: The fixture units of the pipe.
    double Flow { get; set; }
      Description: The actual flow of the plumbing fixture converted from dimension flow or fixture unit. Units: (gal/min).
    PipeFlowConfigurationType FlowConfiguration { get; }
      Description: The flow configuration mode of the pipe.
    FlowConversionMode FlowConversionMode { get; }
      Description: The flow conversion mode of the pipe.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] PipePressureDropData
Full Name: Autodesk.Revit.DB.Plumbing.PipePressureDropData

Description: The input and output data used by external servers for calculation of the pipe pressure drop.
Remarks: Roughness, Length, Flow, Diameter, Density, and Viscosity field values are input data for the calculation. ReynoldsNumber, FlowStatus, Friction, FrictionFactor, Velocity, Coefficient, and PressureDrop are output values.
Implements: IDisposable

  PROPERTIES:
    ElementId CategoryId { get; }
      Description: The category id of pipe curves. It will be OST_PipeCurves, OST_FlexPipeCurves, or OST_PlaceHolderPipes.
    double Coefficient { get; set; }
      Description: The coefficient of the pipe.
    double Density { get; }
      Description: The density of the pipe. Units: (kg/ftÃ‚Â³).
    double Flow { get; }
      Description: The flow of the pipe. Units: (ftÃ‚Â³/s).
    PipeFlowState FlowState { get; set; }
      Description: The flowState of the pipe.
    double Friction { get; set; }
      Description: The friction of the pipe. Units: (kg/(ftÃ‚Â²Ã‚Â·sÃ‚Â²)).
    double FrictionFactor { get; set; }
      Description: The friction factor of the pipe.
    double InsideDiameter { get; }
      Description: The inside diameter of the pipe. Units: (ft).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SystemCalculationLevel KLevel { get; }
      Description: The system calculation level.
    double Length { get; }
      Description: The length of the pipe. Units: (ft).
    double NominalDiameter { get; }
      Description: The nominal diameter of the pipe. Units: (ft).
    double OutsideDiameter { get; }
      Description: The outside diameter of the pipe. Units: (ft).
    double PressureDrop { get; set; }
      Description: The pressure drop of the pipe. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
    double RelativeRoughness { get; set; }
      Description: The relative roughness of the pipe.
    double ReynoldsNumber { get; set; }
      Description: The reynolds number of the pipe.
    double Roughness { get; }
      Description: The roughness of the pipe. Units: (ft).
    double Velocity { get; set; }
      Description: The velocity of the pipe. Units: (ft/s).
    double VelocityPressure { get; set; }
      Description: The velocity pressure of the pipe. Units: (kg/(ftÃ‚Â·sÃ‚Â²)).
    double Viscosity { get; }
      Description: The dynamic viscosity of the pipe. Units: (kg/(ftÃ‚Â·s)).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] PipeScheduleType
Full Name: Autodesk.Revit.DB.Plumbing.PipeScheduleType

Description: Represents a pipe schedule type in the Autodesk Revit MEP product.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static PipeScheduleType Create(Document doc, string name)
      Description: Creates a new pipe schedule type with the given name.
      @doc: The document
      @name: The name of requested schedule type.
      Returns: Returns the newly created schedule type.
    static ElementId GetPipeScheduleId(Document doc, string name)
      Description: Returns an existing pipe schedule type with the same name.
      @doc: The document
      @name: The name of requested schedule type.
      Returns: Returns the element id of request schedule type, or invalidElementId if the name is not found.

--------------------------------------------------------------------------------

[CLASS] PipeSegment
Full Name: Autodesk.Revit.DB.Plumbing.PipeSegment

Description: The PipeSegment class represents an instance of pipe segment which has the design data for routing preference.
Inherits: Segment
Implements: IDisposable

  PROPERTIES:
    ElementId ScheduleTypeId { get; }
      Description: The ElementId of the PipeScheduleType.

  METHODS:
    static PipeSegment Create(Document ADocument, ElementId MaterialId, ElementId ScheduleId, ICollection<MEPSize> sizeSet)
      Description: Creates a new instance of a PipeSegment and adds it to the document.
      @ADocument: The document where the PipeSegment will be created and added.
      @MaterialId: The ElementId of the MaterialElem of the pipe segment.
      @ScheduleId: The ElementId of the PipeScheduleType of the pipe segment.
      @sizeSet: A set of one or more sizes.
      Returns: The newly created pipe segment element.

--------------------------------------------------------------------------------

[CLASS] PipeSettings
Full Name: Autodesk.Revit.DB.Plumbing.PipeSettings

Description: The pipe setting class.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool AnalysisForClosedLoopHydronicPipingNetworks { get; set; }
      Description: Indicates whether to enable analysis for closed loop hydronic piping networks.
    string Centerline { get; set; }
      Description: The abbreviation of the Centerline (=) string.
    string ConnectorSeparator { get; set; }
      Description: The connector separator string.
    double ConnectorTolerance { get; set; }
      Description: The connector tolerance value.
    FittingAngleUsage FittingAngleUsage { get; set; }
      Description: Determine how to use fitting angle during pipe layout or modifying layout.
    double FittingAnnotationSize { get; set; }
      Description: The value of fitting annotation size.
    string FlatOnBottom { get; set; }
      Description: The abbreviation of the Flat On Bottom (FOB) string.
    string FlatOnTop { get; set; }
      Description: The abbreviation of the Flat On Top (FOT) string.
    string SetDown { get; set; }
      Description: The abbreviation of the Set Down (SD) string.
    string SetDownFromBottom { get; set; }
      Description: The abbreviation of the Set Down from bottom of fitting (SDB) string.
    string SetUp { get; set; }
      Description: The abbreviation of the Set Up (SU) string.
    string SetUpFromBottom { get; set; }
      Description: The abbreviation of the Set Up from bottom of fitting(SUB) string.
    string SizePrefix { get; set; }
      Description: The size prefix string.
    string SizeSuffix { get; set; }
      Description: The size suffix string.
    bool UseAnnotationScaleForSingleLineFittings { get; set; }
      Description: Indicates whether use annotation scale for single line fittings or not.

  METHODS:
    void AddPipeSlope(double slope)
      Description: Add a pipe slope value.
      @slope: The pipe slope value. Revit stores the slope value as a percentage (0-100).
    MEPCalculationServerInfo GetFlowConvertionServerInfo()
      Description: Get the MEPServerInfo of the current plumbing flow convertion server.
      Returns: The MEPServerInfo of the current plumbing flow convertion server.
    static PipeSettings GetPipeSettings(Document document)
      Description: Get the pipe settings of the project.
      @document: The document.
      Returns: The pipe settings of the project.
    IList<double> GetPipeSlopes()
      Description: Get pipe slopes.
      Returns: Pipe slope values. Revit stores the slope value as a percentage (0-100).
    IList<double> GetSpecificFittingAngles()
      Description: Gets the list of specific fitting angles.
      Returns: Angles (in degrees).
    bool GetSpecificFittingAngleStatus(double angle)
      Description: Gets the status of given specific angle.
      @angle: The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.
    static bool IsAnalysisForClosedLoopHydronicPipingNetworksEnabled(Document ccda)
      Description: Indicates whether analysis for closed loop hydronic piping networks is enabled in the specified document.
      @ccda: The document.
      Returns: Returns true if analysis for closed loop hydronic piping networks is enabled, false otherwise.
    bool IsValidSpecificFittingAngle(double angle)
      Description: Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.
      @angle: The angle value (in degree).
      Returns: True if the given value is a valid specific fitting angle.
    void SetFlowConvertionServerInfo(MEPCalculationServerInfo serverInfo)
      Description: Set the MEPServerInfo of the current plumbing flow convertion server.
    void SetPipeSlopes(IList<double> slopes)
      Description: Set pipe slope values.
      @slopes: Pipe slope values. Revit stores the slope value as a percentage (0-100).
    void SetSpecificFittingAngleStatus(double angle, bool bStatus)
      Description: Sets the status of given specific angle.
      @angle: The specific angle (in degree) that must be one of 60, 45, 30, 22.5 or 11.25 degrees.
      @bStatus: Status, true - using the given angle during the pipe layout.

--------------------------------------------------------------------------------

[ENUM] PipeSystemType
Full Name: Autodesk.Revit.DB.Plumbing.PipeSystemType

Description: An enumerated type listing all the possible pipe system types for a connector object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UndefinedSystemType = 0
    - SupplyHydronic = 7
    - ReturnHydronic = 8
    - Sanitary = 16
    - Vent = 17
    - DomesticHotWater = 19
    - DomesticColdWater = 20
    - OtherPipe = 22
    - FireProtectWet = 23
    - FireProtectDry = 24
    - FireProtectPreaction = 25
    - FireProtectOther = 26
    - Fitting = 28
    - Global = 29

[CLASS] PipeType
Full Name: Autodesk.Revit.DB.Plumbing.PipeType

Description: A pipe type element.
Inherits: MEPCurveType
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] PipingSystem
Full Name: Autodesk.Revit.DB.Plumbing.PipingSystem

Description: A piping system element.
Inherits: MEPSystem
Implements: IDisposable

  PROPERTIES:
    Connector BaseEquipmentConnector { get; set; }
      Description: The connector within base equipment which is used to connect with system.
    bool IsWellConnected { get; }
      Description: Indicates if the system is well connected or not.
    ElementSet PipingNetwork { get; }
      Description: Pipes and fittings which are contained in this system.
    PipeSystemType SystemType { get; }
      Description: The type of this piping system.

  METHODS:
    static bool CanBeHydraulicLoopBoundary(Element element)
      Description: Checks if the element can be used as a hydraulic loop boundary.
      @element: The element to be checked.
    static PipingSystem Create(Document ADocument, ElementId typeId, string name)
      Description: Creates a new instance of a piping system and adds it to the document.
      @ADocument: The document where the element will be created and added.
      @typeId: The identifier of this piping system element's type.
      @name: The name of the piping system to be created.
      Returns: The newly created piping system element.
    static PipingSystem Create(Document ADocument, ElementId typeId)
      Description: Creates a new instance of a piping system and adds it to the document.
      @ADocument: The document where the element will be created and added.
      @typeId: The identifier of this piping system element's type.
      Returns: The newly created piping system element.
    static ISet<ElementId> CreateHydraulicSeparation(Document document, ISet<ElementId> pipeElementIds)
      Description: Creates new system which is hydraulically separated from the existing system.
      @document: The document where the new system is created.
      @pipeElementIds: The boundary pipe that defines a new system. Multiple pipes are allowed to create more than one separated systems.
      Returns: The newly created piping system elements.
    static void DeleteHydraulicSeparation(Document document, ISet<ElementId> pipeElementIds)
      Description: Deletes hydraulically separated systems and merges the system components into the connected system.
      @document: The document where the system is deleted.
      @pipeElementIds: The boundary pipe that separates the system. Multiple pipes are allowed to delete more than one separated systems.
    double GetFixtureUnits()
      Description: Gets the fixture units of this piping system.
    double GetFlow()
      Description: Gets the flow of this piping system.
    ISet<ElementId> GetPumpSets()
      Description: Gets the set of element Id's for all pump sets in the system, if any.
      Returns: The set of all the pump sets in the system.
    double GetStaticPressure()
      Description: Gets the static pressure of this piping system.
    double GetVolume()
      Description: Gets the volume of this piping system.
    bool IsFlowServerMissing()
      Description: Indicates if any flow server which was used in the piping system is not available.
      Returns: True if there is any flow server not available, false otherwise.
    static bool IsHydraulicLoopBoundary(Element element)
      Description: Checks if the element is a valid hydraulic loop boundary.
      @element: The element to be checked.
    bool IsPressureDropServerMissing()
      Description: Indicates if any pressure drop server which was used in the piping system is not available.
      Returns: True if there is any pressure drop server not available, false otherwise.

--------------------------------------------------------------------------------

[CLASS] PipingSystemType
Full Name: Autodesk.Revit.DB.Plumbing.PipingSystemType

Description: Base class for piping system types
Inherits: MEPSystemType
Implements: IDisposable

  PROPERTIES:
    FlowConversionMode FlowConversionMethod { get; set; }
      Description: The flow conversion method for the piping system type.
    double FluidTemperature { get; set; }
      Description: Fluid Temperature, in Kelvin.
    ElementId FluidType { get; set; }
      Description: Fluid Type
    RiseDropSymbol SingleLineBendDropType { get; set; }
      Description: Symbol for a 1 line drop
    RiseDropSymbol SingleLineBendRiseType { get; set; }
      Description: Symbol for a 1 line rise
    RiseDropSymbol SingleLineJunctionDropType { get; set; }
      Description: Symbol for a 1 line junction drop
    RiseDropSymbol SingleLineJunctionRiseType { get; set; }
      Description: Symbol for a 1 line junction rise
    RiseDropSymbol TwoLineDropType { get; set; }
      Description: Symbol for a 2 line drop
    RiseDropSymbol TwoLineRiseType { get; set; }
      Description: Symbol for a 2 line rise

  METHODS:
    static PipingSystemType Create(Document ADoc, MEPSystemClassification systemClassification, string name)
      Description: Creates a new instance of a piping system type and adds it to the document.
      @ADoc: The document where the element will be created and added.
      @systemClassification: The classification for the piping system type to be created
      @name: The name of the piping system type to be created.
      Returns: The newly created piping system type element.
    bool ValidateRiseDropSymbolType(RiseDropSymbol risedropType)
      Description: Confirms if the parameter is a valid piping rise/drop symbol type.
      @risedropType: The type.
      Returns: True if the input is a valid piping rise/drop symbol type, false otherwise.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PlumbingUtils
Full Name: Autodesk.Revit.DB.Plumbing.PlumbingUtils

Description: General utility methods in the Autodesk Revit MEP product.

  METHODS:
    static ElementId BreakCurve(Document document, ElementId pipeId, XYZ ptBreak)
      Description: Breaks the pipe curve into two parts at the given position.
      @document: The document.
      @pipeId: The element id of the pipe curve to break.
      @ptBreak: The break point on the pipe curve.
      Returns: The new pipe curve element id if successful otherwise if a failure occurred an invalidElementId is returned.
    static bool ConnectPipePlaceholdersAtCross(Document document, Connector connector1, Connector connector2, Connector connector3, Connector connector4)
      Description: Connects placeholders that looks like Cross connection.
      @document: The document.
      @connector1: The first end connector of placeholder to be connected to the second.
      @connector2: The second end connector of placeholder to be connected to the first.
      @connector3: The third end connector of placeholder to be connected to the forth.
      @connector4: The fourth end connector of placeholder to be connected to the third.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectPipePlaceholdersAtCross(Document document, ElementId placeholder1Id, ElementId placeholder2Id, ElementId placeholder3Id)
      Description: Connects placeholders that looks like Cross connection.
      @document: The document.
      @placeholder1Id: The first element Id of pipe placeholder.
      @placeholder2Id: The second element Id of pipe placeholder that intersects with first one.
      @placeholder3Id: The third element Id of pipe placeholder that intersects with first one.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectPipePlaceholdersAtCross(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects placeholders that looks like Cross connection.
      @document: The document.
      @placeholder1Id: The first element Id of pipe placeholder.
      @placeholder2Id: The second element Id of pipe placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectPipePlaceholdersAtElbow(Document document, Connector connector1, Connector connector2)
      Description: Connects placeholders that looks like elbow connection.
      @document: The document.
      @connector1: The first end connector of placeholder to be connected to.
      @connector2: The second end connector of placeholder to be connected to.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectPipePlaceholdersAtElbow(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects placeholders that looks like elbow connection.
      @document: The document.
      @placeholder1Id: The element Id of pipe placeholder.
      @placeholder2Id: The element Id of pipe placeholder.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectPipePlaceholdersAtTee(Document document, Connector connector1, Connector connector2, Connector connector3)
      Description: Connects three placeholders that looks like Tee connection.
      @document: The document.
      @connector1: The first end connector of placeholder to be connected to the second.
      @connector2: The second end connector of placeholder to be connected to the first.
      @connector3: The third end connector of placeholder to be connected to the first or second.
      Returns: True if connection succeeds, false otherwise.
    static bool ConnectPipePlaceholdersAtTee(Document document, ElementId placeholder1Id, ElementId placeholder2Id)
      Description: Connects two placeholders that looks like Tee connection.
      @document: The document.
      @placeholder1Id: The first element Id of pipe placeholder.
      @placeholder2Id: The second element Id of pipe placeholder which connects to first.
      Returns: True if connection succeeds, false otherwise.
    static ICollection<ElementId> ConvertPipePlaceholders(Document document, ICollection<ElementId> placeholderIds)
      Description: Converts a collection of pipe placeholder elements into pipe elements.
      @document: The document.
      @placeholderIds: A collection of element IDs of pipe placeholders.
      Returns: A collection of element IDs of pipe and fitting.
    static bool HasOpenConnector(Document document, ElementId elemId)
      Description: Checks if there is open piping connector for the given element - object of pipe curve, pipe fitting or pipe accessory.
      @document: The document.
      @elemId: Element id to check.
      Returns: True if given element has open piping connector, false otherwise.
    static void PlaceCapOnOpenEnds(Document document, ElementId elemId, ElementId typeId)
      Description: Places caps on the open connectors of the pipe curve, pipe fitting or pipe accessory.
      @document: The document.
      @elemId: Element id of pipe curve, pipe fitting or pipe accessory.
      @typeId: Pipe type element id. Default is invalidElementId.

--------------------------------------------------------------------------------


