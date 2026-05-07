# Autodesk.Revit.DB.ExternalService

NAMESPACE: Autodesk.Revit.DB.ExternalService
--------------------------------------------------------------------------------

[ENUM] DisparityResponse
Full Name: Autodesk.Revit.DB.ExternalService.DisparityResponse
Description: An enumerated value to return from OnServerDiparity indicating what the service wants Revit to do as the post-action of the call.
Inherits: Enum

  Values:
    - DoNothing = 0
    - ApplyDefaults = 1
    - LetUserDecide = 2

--------------------------------------------------------------------------------

[ENUM] ExecutionPolicy
Full Name: Autodesk.Revit.DB.ExternalService.ExecutionPolicy
Description: Controls how servers of multi-server external services are executed.
Inherits: Enum

  Values:
    - FirstApplicableServer = 0
    - AllApplicableServers = 1

--------------------------------------------------------------------------------

[CLASS] ExternalService
Full Name: Autodesk.Revit.DB.ExternalService.ExternalService
Description: This base class represents an external service inside Revit application.
Remarks: This is a base class from which SingleServerService and MultiServerService classes are inherited. It implements all basic methods, but the two inherited classes add more methods specific for that kind of service the class represents. Use this base class to get information about a service and its servers. Use the specific inherited classes to set or get active servers. Summary of common methods: Adding and removing a server to and from a serviceGetting information about a serviceQuerying a number of servers registered for a serviceAccessing servers currently registered for a service Summary of the service-specific methods: Getting and setting active server (or servers) for a service
Implements: IDisposable

  PROPERTIES:
    string Description { get; }
      Description: The description for the service
    bool IsSerializable { get; }
      Description: Indicates whether executions of the service requires serialization in documents or not.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The name of the service
    int NumberOfServers { get; }
      Description: Indicates the number of servers currently registered with the service.
    ExternalServiceId ServiceId { get; }
      Description: The Id of the service
    bool SupportActivation { get; }
      Description: Indicates if the service supports activation/deactivation of the servers.
    string VendorId { get; }
      Description: The vendor who provided the service

  METHODS:
    void AddServer(IExternalServer server)
      Description: Registers a server with its service.
      @server: The instance of the server. The server must implement the interface provided by the service.
      Throws ArgumentException: The Server object is not valid or its service Id does not match the service. -or- A server with the same Id has already been registered with the service. -or- The given server does not return valid values from the interface methods. At least one of the Name, VendorId, Description, and ServerId is empty or invalid. -or- The server does not represent a server of a valid type to be used with the service.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- The service provider is not valid. -or- Only one server can be added for a single-server service.
    void Dispose()
    Guid GetDefaultServerId()
      Description: Returns the Id of the default server if one was assigned to the service.
      Returns: The GUID of the default server, or an invalid GUID if there is none assigned.
    ExternalServiceOptions GetOptions()
      Description: A copy of the options the service was registered with.
      Returns: An instance of the options class.
    Guid GetPublicAccessKey()
      Description: Access key to use to execute a service.
      Returns: GUID representing the access key.
      Throws InvalidOperationException: The service is not public, thus the access key cannot be obtained.
    IList<Guid> GetRegisteredServerIds()
      Description: Returns Ids of all servers registered for the service.
      Returns: An array of Ids of all registered servers. The array may be empty.
    IExternalServer GetServer(Guid serverId)
      Description: Returns the instance that provides implementation for a registered server.
      @serverId: Id of a registered server
      Returns: An instance of the server interface. NULL is returned if the server is invalid (e.g. destroyed)
      Throws ArgumentException: The given Id is not a valid GUID value.
    bool IsRegisteredServerId(Guid serverId)
      Description: Checks if the Id represents a valid server that has been registered for the service.
      @serverId: An Id of a server
      Returns: True if the specified server is currently registed for this service, false otherwise.
    void RemoveServer(Guid serverId)
      Description: Removes/unregisters a server from the service.
      @serverId: Id of the server to be unregistered.
      Throws ArgumentException: A server with this Id has not been registered for this service. -or- A server with this Id has already been used in a currently open document -or- The given serverId belongs to the default server of the service. Default servers may not be removed.
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- The service provider is not valid.

--------------------------------------------------------------------------------

[CLASS] ExternalServiceId
Full Name: Autodesk.Revit.DB.ExternalService.ExternalServiceId
Description: Unique identifier of an external service.
Remarks: Each external service must have a unique ExternalServiceId. The Id can be registered with Revit for servers to easily find it. Unique ExternalServiceId should be created using GUID generation tool. ExternalServiceId can later be used to access registered external services.
Inherits: GuidEnum

  CONSTRUCTORS:
    new ExternalServiceId(Guid guid)
      Description: Creates a new ExternalServiceId instance.
      @guid: The identifier for the ExternalServiceId.

--------------------------------------------------------------------------------

[CLASS] ExternalServiceOptions
Full Name: Autodesk.Revit.DB.ExternalService.ExternalServiceOptions
Description: Various options affecting the behavior of an External Service
Remarks: Options are provided at the time of registering a service. After a service is registered, the options cannot be changed.
Implements: IDisposable

  CONSTRUCTORS:
    new ExternalServiceOptions()
      Description: Constructs a new ExternalServiceOptions with default settings.

  PROPERTIES:
    bool IsPublic { get; set; }
      Description: This property denotes a service as either public or private.
    bool IsRecordable { get; set; }
      Description: Indicates whether executions of the service is recorded in documents or not.
    bool IsSelfsynchronizing { get; set; }
      Description: Indicates whether the service's record of used services (in a particular document) can independently wary between local clients and the corresponding central model. It is then up to the service's owner to assure proper local-central synchronization.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool SupportActivation { get; set; }
      Description: Indicates if the service supports activation/deactivation of the servers.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ExternalServiceRegistry
Full Name: Autodesk.Revit.DB.ExternalService.ExternalServiceRegistry
Description: This class gives access to external services. Use it to register external services with Revit and execute them. Only the application that registers a service is allowed to execute it.

  METHODS:
    static ExternalServiceResult ExecuteService(Guid executionKey, Guid serverId, IExternalData data)
      Description: Execute the service by the given server.
      @executionKey: Access key of the service to be executed. The key is not the same as the service's Id. It is the value that was returned to the caller who registered the service.
      @serverId: the specific server to execute
      @data: The associated data. The type must be of the class defined by the service.
      Returns: The result of executing the external service.
      Throws ArgumentNullException: A non-optional argument was null
    static ExternalServiceResult ExecuteService(Guid executionKey, Document document, IExternalData data)
      Description: Execute the service for the given document.
      @executionKey: Access key of the service to be executed. The key is not the same as the service's Id. It is the value that was returned to the caller who registered the service.
      @document: The document for which the service is going to be executed.
      @data: The associated data. The type must be of the class defined by the service.
      Returns: The result of executing the external service.
      Throws ArgumentException: The execution key is either invalid or of a service that is not registered. To execute a service, the key returned by RegisterService method must be used. -or- The execution key is of a service that is already being executed.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Executing a recordable service in a document that is not modifiable.
    static ExternalServiceResult ExecuteService(Guid executionKey, IExternalData data)
      Description: Execute a service independently of any document.
      @executionKey: Access key of the service to be executed. The key is not the same as the service's Id. It is the value that was returned to the caller who registered the service.
      @data: The associated data. The type is defined by the service.
      Returns: The result of executing the external service.
      Throws ArgumentException: The execution key is either invalid or of a service that is not registered. To execute a service, the key returned by RegisterService method must be used. -or- The execution key is of a service that is already being executed.
      Throws ArgumentNullException: A non-optional argument was null
    static ExternalService GetService(ExternalServiceId serviceId)
      Description: Returns an instance of an object that represents the external service with the given Id.
      @serviceId: Id of the service.
      Returns: The instance of the service or NULL if it cannot be found.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ExternalService> GetServices()
      Description: Returns a collection of all external services currently registered in Revit.
      Returns: Array of ExternalService instances.
    static Guid RegisterService(ISingleServerService service, Guid defaultServerId, ExternalServiceOptions options)
      Description: A method to register a mandatory, single-server service.
      @service: An instance of the external service class that implements ISingleServerService interface.
      @defaultServerId: Id of the server that will become the service's default server (once the server is registered).
      @options: Optional settings to control the service's behavior.
      Returns: An access key to the service. The key is needed to execute the service.
      Throws ArgumentException: The given service is not a valid implementation of ISingleServerService. -or- The given service does not return valid values from the interface methods. At least one of the Name, VendorId, Description, and ServiceId is either empty or invalid. -or- A service with this Id is either invalid or not unique. -or- The given Id is not a valid GUID value. -or- A mandatory service should support activation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Service cannot be registered because the registry of services has been already closed. All external services must be registered before the ApplicationInitialized event is raised.
    static Guid RegisterService(IMultiServerService service, ExternalServiceOptions options, ExecutionPolicy policy)
      Description: A method to register a multi-server service.
      @service: An instance of the external service class that implements IMultiServerService interface.
      @options: Optional settings to control the service's behavior.
      @policy: Specifies how the service handles servers during its execution.
      Returns: An execution key to access the service when executing it.
      Throws ArgumentException: The given service is not a valid implementation of ISingleServerService. -or- The given service does not return valid values from the interface methods. At least one of the Name, VendorId, Description, and ServiceId is either empty or invalid. -or- A service with this Id is either invalid or not unique.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Service cannot be registered because the registry of services has been already closed. All external services must be registered before the ApplicationInitialized event is raised.
    static Guid RegisterService(ISingleServerService service, ExternalServiceOptions options)
      Description: A method to register a single-server service.
      @service: An instance of the external service class that implements ISingleServerService interface.
      @options: Optional settings to control the service's behavior.
      Returns: An access key to the service. The key is needed to execute the service.
      Throws ArgumentException: The given service is not a valid implementation of ISingleServerService. -or- The given service does not return valid values from the interface methods. At least one of the Name, VendorId, Description, and ServiceId is either empty or invalid. -or- A service with this Id is either invalid or not unique.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Service cannot be registered because the registry of services has been already closed. All external services must be registered before the ApplicationInitialized event is raised.

--------------------------------------------------------------------------------

[ENUM] ExternalServiceResult
Full Name: Autodesk.Revit.DB.ExternalService.ExternalServiceResult
Description: An enumerated value representing a result from executing an external service.
Inherits: Enum

  Values:
    - Succeeded = 0
    - Failed = 1
    - Unhandled = 2

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ExternalServices
Full Name: Autodesk.Revit.DB.ExternalService.ExternalServices
Description: Provides a container of all Revit built-in ExternalServiceId instances.

--------------------------------------------------------------------------------

[INTERFACE] IExternalData
Full Name: Autodesk.Revit.DB.ExternalService.IExternalData
Description: The base interface for data classes used when executing servers of external services.
Remarks: Each and every external service defines a concrete class derived from this interface and adds data and methods as it sees fit for executions of such a particular service.

--------------------------------------------------------------------------------

[INTERFACE] IExternalServer
Full Name: Autodesk.Revit.DB.ExternalService.IExternalServer
Description: The base interface for all external servers.
Remarks: Every external service in Revit declares a specific interface for its servers. Each interface must be derived from this IExternalServer. Providers of external servers implement the server interfaces defined by the respective external services to which the servers belong. The whole process of creating a server and registering it with Revit as a server of a concrete external service can be outlined in the following steps: A provider of an external service declares a server interface derived from IExternalServerThe provider of the service will make it known that this interface is for the servers of that serviceAn application wanting to have a server will implement the appropriate interfaceThe server's application obtains the service from Revit using the ExternalServiceRegistry.GetService methodAn instance of the server class can then be registered with Revit by using the ExternalService.AddServer method

  METHODS:
    string GetDescription()
      Description: Implement this method to return a description of the server.
      Returns: Description of the server.
    string GetName()
      Description: Implement this method to return the name of the server.
      Returns: Name of the server.
    Guid GetServerId()
      Description: Implement this method to return the id of the server.
      Returns: The id of the server.
    ExternalServiceId GetServiceId()
      Description: Implement this method to return the id of the service.
      Returns: The id of the service to which the server belongs.
    string GetVendorId()
      Description: Implement this method to return the id of the vendor of the server.
      Returns: Vendor Id of the server.

--------------------------------------------------------------------------------

[INTERFACE] IExternalService
Full Name: Autodesk.Revit.DB.ExternalService.IExternalService
Description: The base interface class for all external services.
Remarks: Both supported kinds of services - single-server and multi-server - will derive their classes from this interface, albeit indirectly through an interface specific to the particular kind. External services never derive directly from this class - they always have to derive from either ISingleServerService or IMultiServerService, respectivelly.

  METHODS:
    bool Execute(IExternalServer server, Document document, IExternalData data)
      Description: Implement this method to execute the given server.
      @server: An instance of a server that is to be executed.
      @document: The associated document. It may be NULL if the service is not being executed in a document.
      @data: The associated service data.
      Returns: True indicates a successful execution of the call. False indicates a failure. If a multi-server service returns false from the call, the service manager will stop the execution loop and marks the service execution as unsuccessful.
    string GetDescription()
      Description: Implement this method to return a description of the service.
      Returns: Description of the service.
    string GetName()
      Description: Implement this method to return the name of the service.
      Returns: Name of the service.
    ExternalServiceId GetServiceId()
      Description: Implement this method to return the unique Id of the service.
      Returns: The extensible enum value representing the Id of the service.
    string GetVendorId()
      Description: Implement this method to return the vendor Id of the service.
      Returns: Vendor Id of the service.
    bool IsValidServer(IExternalServer server)
      Description: Implement this method to check if the given instance represents a valid server of this service.
      @server: An instance of a server that is to be validated.
      Returns: True if the server is valid, False otherwise
    void OnServersChanged(Document document, ServerChangeCause cause, IList<Guid> oldServers)
      Description: Implement this method to handle situations when servers for the service have changed.
      @document: The corresponding document
      @cause: Indicates in what situation the servers are changed. Currently available values indicate whether the change is a result of an explicit user request, or by an implicit change of situation within the service - for example when a document is updated upon opening.
      @oldServers: Ids of servers previously used in the document. Please note that the Ids may belong to servers that are not registered with service anymore.
    DisparityResponse OnServersDisparity(Document document, IList<Guid> oldServers)
      Description: Implements this method to get notified that the servers in a just opened document differ from those currently set as active for the service.
      @document: The coresponding document
      @oldServers: Ids of servers previously used in the document. Please note that the Ids may belong to servers that are currently not registered with the service.
      Returns: Return DoNothing if the situation has been completely handled by your service; If not, reply with either ApplyDefaults (typical case) or LetUserDecide.

--------------------------------------------------------------------------------

[INTERFACE] IMultiServerService
Full Name: Autodesk.Revit.DB.ExternalService.IMultiServerService
Description: The base interface class for all multi-server services.
Remarks: Both a single-server and multi-server service may have more than one server registered for them. The difference between these two kinds is while there can only be one active server at any given time for a single-sever service, there may be a whole set of active servers assigned for a multi-server service. When a multi-server service gets executed, the framework iterates through the set of currently active servers (application-wide or document-specific depending on the situation) and invokes the service's interface with a CanExecute call. If the service replies the current server cannot be executed, the framework skips it and continues with the next one in the queue. When a server is found it can be executed, the framework calls the service's interface again, this time with the Execute method. Whether the execution loop ends after the first executed server or not is controlled by execution policy, which is supplied for the service upon its registration.
Implements: IExternalService

  METHODS:
    bool CanExecute(IExternalServer server, Document document, IExternalData data)
      Description: Implement this to test whether a particular server should be executed.
      @server: An instance of a server that is to be tested.
      @document: The associated document. It may be NULL if not applicable.
      @data: The associated service data. It is the same data the Execute method would receive.

--------------------------------------------------------------------------------

[INTERFACE] ISingleServerService
Full Name: Autodesk.Revit.DB.ExternalService.ISingleServerService
Description: The base interface class for all single-server services.
Remarks: Both single-server and multi-server services may have more than one server registered for them. The difference between these two kinds is while there can only be one active server at any given time for a single-sever service, there may be a set of active servers assigned for a multi-server service. ISingleServerService does not have any specific methods (currently) added to those inherited from the common IExternalService interface.
Implements: IExternalService

--------------------------------------------------------------------------------

[CLASS] MultiServerService
Full Name: Autodesk.Revit.DB.ExternalService.MultiServerService
Description: This class represents a multi-server service inside Revit application. It is created when an instance of IMultiServerService is registered with Revit.
Inherits: ExternalService

  PROPERTIES:
    ExecutionPolicy ExecutionPolicy { get; }
      Description: Specifies how a multi-server service executes servers during its execution.

  METHODS:
    IList<Guid> GetActiveServerIds(Document document)
      Description: Returns Ids of the servers currently applicable to the given document for the service.
      @document: The associated document.
      Returns: A set of GUIDs of the document-applicable active servers; the list may be empty.
      Throws ArgumentNullException: A non-optional argument was null
    IList<Guid> GetActiveServerIds()
      Description: Returns Ids of the currently active application-level servers registered for the service.
      Returns: A set of GUIDs of the application-wide active servers; the list may be empty.
    void SetActiveServers(IList<Guid> serverIds, Document document)
      Description: Changes the active servers and/or their order for the given document.
      @serverIds: A set of Ids of servers that are to be set as active for this service in this document or an empty set if no server should currently be set as active in this particular document.
      @document: The document for which the servers are set as active.
      Throws ArgumentException: Some of the given Ids do not represent valid servers of the service. -or- The list of servers contains duplicates. The SetActiveServers method expects a set of unique servers.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- For a service that doesn't support activation, the servers can't be activated/deactivated.
    void SetActiveServers(IList<Guid> serverIds)
      Description: Changes the active servers and/or their order.
      @serverIds: A set of Ids of servers that are to be set as active for this service or an empty set if no server should currently be set as active.
      Throws ArgumentException: Some of the given Ids do not represent valid servers of the service. -or- The list of servers contains duplicates. The SetActiveServers method expects a set of unique servers.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- For a service that doesn't support activation, the servers can't be activated/deactivated.
    bool SetServerState(Guid serverId, Document document, bool bActive)
      Description: This method will simply switch the active state of a server without affecting in any way the other servers.
      @serverId: Id of the server to switch active state for.
      @document: Document for which to activate this server. If null, server will activate globally.
      @bActive: True to activate server, false to deactivate.
      Returns: True if operation succeeded (even if the server state was not changed), false otherwise (e.g. when serverId is invalid).
      Throws InvalidOperationException: For a service that doesn't support activation, the servers can't be activated/deactivated.

--------------------------------------------------------------------------------

[ENUM] ServerChangeCause
Full Name: Autodesk.Revit.DB.ExternalService.ServerChangeCause
Description: Indicates the cause for the active server to be changed
Inherits: Enum

  Values:
    - ImposedChange = 0
    - UserChange = 1

--------------------------------------------------------------------------------

[CLASS] SingleServerService
Full Name: Autodesk.Revit.DB.ExternalService.SingleServerService
Description: This class represents a single-server service inside Revit application. It is created when an instance of ISingleServerService is registered with Revit.
Inherits: ExternalService

  METHODS:
    Guid GetActiveServerId(Document document)
      Description: Returns the Id of the server currently associated with the given document for the service.
      @document: The document for which the server is being set as active.
      Returns: The Guid of the active server, or an invalid Guid if there is no active server assigned.
      Throws ArgumentNullException: A non-optional argument was null
    Guid GetActiveServerId()
      Description: Returns the Id of the currently active application-level server of the service.
      Returns: The GUID of the active server, or an invalid GUID if there is no active server assigned.
    void SetActiveServer(Guid serverId, Document document)
      Description: Change the active server for a specific document.
      @serverId: Id of the server.
      @document: The document for which the server is being set as active.
      Throws ArgumentException: The given Id is not of a server registered with the service.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- For a service that doesn't support activation, the servers can't be activated/deactivated.
    void SetActiveServer(Guid serverId)
      Description: Set an active server applicable application-wide for the service.
      @serverId: Id of the application server.
      Throws ArgumentException: The given Id is not of a server registered with the service.
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- For a service that doesn't support activation, the servers can't be activated/deactivated.
    void UnsetActiveServer(Document document)
      Description: Unset the active server for the particular document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The operation is not allowed because the service is being executed. -or- For a service that doesn't support activation, the servers can't be activated/deactivated.

--------------------------------------------------------------------------------

