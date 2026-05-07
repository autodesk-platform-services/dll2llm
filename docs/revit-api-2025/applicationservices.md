# Autodesk.Revit.ApplicationServices

NAMESPACE: Autodesk.Revit.ApplicationServices
--------------------------------------------------------------------------------

[CLASS] Application
Full Name: Autodesk.Revit.ApplicationServices.Application
Description: Represents the Autodesk Revit Application, providing access to documents, options and other application wide data and settings.
Implements: IDisposable

  PROPERTIES:
    AddInId ActiveAddInId { get; }
      Description: Retrieves the Id of the currently running external application.
    bool AllowNavigationDuringRedraw { get; set; }
      Description: Checks whether or not the navigation during redraw is enabled, and enable or disable it.
    string AllUsersAddinsLocation { get; }
      Description: The folder location for .addin files for all users.
    double AngleTolerance { get; }
      Description: Angle tolerance.
    Color BackgroundColor { get; set; }
      Description: The background color to use for model views in this session.
    CitySet Cities { get; }
      Description: Returns a set of all the known city locations within Revit.
    Application Create { get; }
      Description: Provides an object that can be used to create new instances of Autodesk Revit API objects.
    string CurrentRevitServerAccelerator { get; set; }
      Description: Current Revit Server accelerator.
    string CurrentUserAddinsLocation { get; }
      Description: The folder location for .addin files for the current user.
    string CurrentUsersAddinsDataFolderPath { get; }
      Description: Path to AddinsData folder for the current user.
    string CurrentUsersDataFolderPath { get; }
      Description: Path to data folder for the current user.
    string DefaultIFCProjectTemplate { get; }
      Description: Full path to the default template file for new IFC project documents. It may be empty, in which case the DefaultProjectTemplate should be used.
    string DefaultProjectTemplate { get; }
      Description: Full path to the default template file for new project documents.
    ViewDiscipline DefaultViewDiscipline { get; set; }
      Description: The view discipline that will be applied to new views by default.
    DocumentSet Documents { get; }
      Description: Returns a set of documents within Revit.
    string ExportIFCCategoryTable { get; }
      Description: Full path to the file that defines Revit category to IFC entity mappings for IFC export.
    string FamilyTemplatePath { get; }
      Description: Default path for family template files.
    string ImportIFCCategoryTable { get; }
      Description: Full path to the file that defines IFC entity to Revit category mappings for IFC import.
    bool IsArchitectureEnabled { get; set; }
      Description: Checks whether or not the architecture discipline is enabled, and enable or disable it.
    bool IsElectricalAnalysisEnabled { get; set; }
      Description: Checks whether or not electrical analysis is enabled, and enable or disable it.
    bool IsElectricalEnabled { get; set; }
      Description: Checks whether or not the electrical discipline is enabled, and enable or disable it.
    bool IsEnergyAnalysisEnabled { get; set; }
      Description: Checks whether or not energy analysis is enabled, and enable or disable it.
    bool IsInfrastructureEnabled { get; set; }
      Description: Checks whether or not infrastructure discipline is enabled, and enable or disable it.
    static bool IsLoggedIn { get; }
      Description: Checks if the user is logged in from this session to their Autodesk account.
    bool IsMassingEnabled { get; set; }
      Description: Checks whether or not the massing and site tools are enabled, and enable or disable them.
    bool IsMechanicalAnalysisEnabled { get; set; }
      Description: Checks whether or not mechanical analysis is enabled, and enable or disable it.
    bool IsMechanicalEnabled { get; set; }
      Description: Checks whether or not the mechanical discipline is enabled, and enable or disable it.
    bool IsPipingAnalysisEnabled { get; set; }
      Description: Checks whether or not piping analysis is enabled, and enable or disable it.
    bool IsPipingEnabled { get; set; }
      Description: Checks whether or not the piping discipline is enabled, and enable or disable it.
    bool IsRouteAnalysisEnabled { get; set; }
      Description: Checks whether or not route analysis is enabled, and enable or disable it.
    bool IsStructuralAnalysisEnabled { get; set; }
      Description: Checks whether or not the structural analysis is enabled, and enable or disable it.
    bool IsStructureEnabled { get; set; }
      Description: Checks whether or not the structure discipline is enabled, and enable or disable it.
    bool IsSystemsEnabled { get; }
      Description: Checks whether or not any systems disciplines (mechanical, electrical, or piping) are enabled.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LanguageType Language { get; }
      Description: The language used in the current session of Revit.
    string LoginUserId { get; }
      Description: The user id of the user currently logged in. The user id will be empty if the user is not logged in.
    static double MinimumThickness { get; }
      Description: The minimum thickness allowed in Revit for a variety of geometric constructs. These include blends, extrusions, and wall layers.
    string PointCloudsRootPath { get; }
      Description: Root path for point cloud files.
    ProductType Product { get; }
      Description: The product type for the current session of Revit.
    string RecordingJournalFilename { get; }
      Description: Retrieve the name of the journal file the Revit is currently recording to.
    string SharedParametersFilename { get; set; }
      Description: Contains the fully qualified path to a shared parameters file.
    double ShortCurveTolerance { get; }
      Description: The enforced minimum length for any curve created by Revit.
    bool ShowGraphicalOpenEndsAreaBasedLoadBoundaryDisconnects { get; set; }
      Description: Whether or not to show the graphical open ends for Area Based Load Boundary disconnects.
    bool ShowGraphicalWarningCableTrayConduitDisconnects { get; set; }
      Description: Whether or not to show the graphical warnings for CTC disconnects.
    bool ShowGraphicalWarningDuctDisconnects { get; set; }
      Description: Whether or not to show the graphical warnings for duct disconnects.
    bool ShowGraphicalWarningElectricalDisconnects { get; set; }
      Description: Whether or not to show the graphical warnings for Electrical disconnects.
    bool ShowGraphicalWarningHangerDisconnects { get; set; }
      Description: Whether or not to show the graphical warnings for Fabrication Hanger disconnects.
    bool ShowGraphicalWarningPipeDisconnects { get; set; }
      Description: Whether or not to show the graphical warnings for Pipe disconnects.
    string SubVersionNumber { get; }
      Description: The minor version number of Revit
    string SystemsAnalysisWorkfilesRootPath { get; }
      Description: Root path for systems analysis workfiles
    string Username { get; }
      Description: Gets the user name for the current Revit session.
    string VersionBuild { get; }
      Description: Returns the internal build number of the Autodesk Revit application.
    string VersionName { get; }
      Description: Returns the name of the Revit application.
    string VersionNumber { get; }
      Description: Return the primary version of the Revit application.
    double VertexTolerance { get; }
      Description: Vertex tolerance.

  METHODS:
    void CopyModel(ModelPath sourceModelPath, string destFilePath, bool overwrite)
      Description: Copies an existing model to a new file. Overwriting a file of the same name is allowed.
      @sourceModelPath: The path of the file-based or server-based source model.
      @destFilePath: The path of the destination file.
      @overwrite: True if the destination file can be overwritten; otherwise, false.
      Throws ArgumentException: The given path sourceModelPath is a cloud path which is not supported in this method.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelException: The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws DirectoryNotFoundException: Thrown when the directory of destination file doesn't exist.
      Throws FileArgumentAlreadyExistsException: The destination file exists and can't be overwritten. -or- destFilePath is pointing to a folder that already exists and cannot be deleted.
      Throws FileArgumentNotFoundException: The Revit model specified by sourceModelPath doesn't exist.
      Throws InvalidPathArgumentException: The destination file name includes one or more invalid characters.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    void Dispose()
    void ExtractPartAtomFromFamilyFile(string familyFilePath, string xmlFilePath)
      Description: Writes a PartAtom XML from the contents of a family file.
      @familyFilePath: The family file to be processed.
      @xmlFilePath: The xml file to be saved.
      Throws ArgumentException: If 'familyFilePath' or 'xmlFilePath' is or an empty string or if the family file doesn't exist on disk.
    IList<Asset> GetAssets(AssetType assetType)
      Description: Gets all the Assets of the specified type.
      @assetType: The asset type.
      Returns: Returns an array of all the Assets within Revit of the specified type.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static FailureDefinitionRegistry GetFailureDefinitionRegistry()
      Description: Returns the instance of FailureDefinitionRegistry.
      Returns: The instance of FailureDefinitionRegistry.
    IDictionary<string, string> GetLibraryPaths()
      Description: Returns path information identifying where Revit searches for content.
      Returns: The map of library paths.
    IList<string> GetRevitServerNetworkHosts()
      Description: Gets the list of all Revit Server Network hosts in current session.
      Returns: An array of names of all Revit Server Network hosts in current session.
    IList<string> GetSystemsAnalysisWorkflowNames()
      Description: Returns names for systems analysis workflows.
      Returns: An array of names of systems analysis workflows.
    IDictionary<string, string> GetSystemsAnalysisWorkflows()
      Description: Returns name and path information identifying systems analysis workflow files.
      Returns: The map of systems analysis workflows.
    Guid GetWorksharingCentralGUID(ServerPath serverModelPath)
      Description: Gets the worksharing central GUID of the given server-based model.
      @serverModelPath: The server-based model path.
      Returns: The worksharing central GUID.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelException: The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws InapplicableDataException: Thrown when the given model is not created in Revit 2013 or later release.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
    bool IsJournalPlaying()
      Description: Determines if the application is currently in journal playback mode.
      Returns: true if a journal is currently playing back, false otherwise.
    static bool IsValidThickness(double thickness)
      Description: Checks if the input value is valid to be supplied as a thickness (for an extrusion, or blend, or wall layer, or similar geometric construct).
      @thickness: The input value.
      Returns: True if the input value is valid for thickness; false otherwise.
    Document NewFamilyDocument(string templateFileName)
      Description: New family document, including family, titleblock, and annotation symbol
      @templateFileName: The template file name.
      Throws ArgumentException: If 'templateFileName' is or an empty string.
      Throws InvalidOperationException: If the new family document cannot be created.
    Document NewProjectDocument(UnitSystem unitSystem)
      Description: Creates a new project document with no template file specified.
      @unitSystem: The unit system used for the new document.
      Returns: The newly created document.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    Document NewProjectDocument(string templateFileName)
      Description: New project document
      @templateFileName: The template file name.
      Throws ArgumentException: If 'templateFileName' is or an empty string.
      Throws InvalidOperationException: If the new project document cannot be created.
    Document NewProjectTemplateDocument(string templateFilename)
      Description: New project template document
      @templateFilename: The template file name.
      Throws ArgumentException: If 'templateFileName' is or an empty string.
      Throws InvalidOperationException: If the project template document cannot be created.
    Document OpenDocumentFile(string fileName)
      Description: Opens a document from disk.
      @fileName: The file to be opened.
      Returns: The opened document.
      Throws ArgumentException: The fileName to be opened is empty.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CannotOpenBothCentralAndLocalException: Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.
      Throws CentralModelException: Revit encountered serious errors while trying to open the central model.
      Throws CorruptModelException: There are too many corrupt elements to open this model.
      Throws FileAccessException: File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1. -or- File has an invalid extension. Try changing the file's extension and opening it again.
      Throws FileNotFoundException: The fileName to be opened doesn't exist. -or- File Not Found
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to open the model.
      Throws InvalidOperationException: Open is temporarily disabled. -or- The document can not be opened.
      Throws OperationCanceledException: Opening was canceled by the user or by an API event callback.
    Document OpenDocumentFile(ModelPath modelPath, OpenOptions openOptions, IOpenFromCloudCallback openFromCloudCallback)
      Description: Opens a document from disk or cloud.
      @modelPath: The file to be opened.
      @openOptions: Options for opening the file.
      @openFromCloudCallback: The interface implementation to use when opening a cloud document. Only used for opening cloud model.
      Returns: The opened document.
      Throws ArgumentException: The modelPath to be opened is empty.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CannotOpenBothCentralAndLocalException: Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The model on the RevitServer is being accessed by other users. -or- The central model is locked by another client.
      Throws CentralModelException: Revit encountered serious errors while trying to open the central model. -or- An internal error happened on the central model, please contact the server administrator.
      Throws CorruptModelException: There are too many corrupt elements to open this model.
      Throws FileAccessException: File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1. -or- File has an invalid extension. Try changing the file's extension and opening it again.
      Throws FileNotFoundException: The modelPath to be opened doesn't exist. -or- File Not Found
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to open the model.
      Throws InvalidOperationException: Open is temporarily disabled. -or- The cloud model is not saved in current release of Revit. -or- The model is not allowed to access. -or- The document can not be opened. -or- Revit cannot save the transmitted model as a new central because it is already opened.
      Throws OperationCanceledException: Opening was canceled by the user or by an API event callback.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
      Throws RevitServerUnauthorizedException: User is not authorized to access the cloud model.
      Throws WrongUserException: The local file is not owned by the current user, who therefore is not allowed to modify it.
    Document OpenDocumentFile(ModelPath modelPath, OpenOptions openOptions)
      Description: Opens a document from disk or cloud.
      @modelPath: The file to be opened.
      @openOptions: Options for opening the file.
      Returns: The opened document.
      Throws ArgumentException: The modelPath to be opened is empty.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CannotOpenBothCentralAndLocalException: Cannot open the local model and the central model in the same Revit session. You can close one to open the other in the same Revit session.
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The model on the RevitServer is being accessed by other users. -or- The central model is locked by another client.
      Throws CentralModelException: Revit encountered serious errors while trying to open the central model. -or- An internal error happened on the central model, please contact the server administrator.
      Throws CorruptModelException: There are too many corrupt elements to open this model.
      Throws FileAccessException: File cannot be opened in Revit LT because it was last saved in a version of Revit prior to 8.1. -or- File has an invalid extension. Try changing the file's extension and opening it again. -or- File was saved by an application that was not developed or licensed by Autodesk.
      Throws FileNotFoundException: The modelPath to be opened doesn't exist. -or- File Not Found
      Throws InsufficientResourcesException: This computer does not have enough memory, disk space, or other necessary resource to open the model.
      Throws InvalidOperationException: Open is temporarily disabled. -or- The cloud model is not saved in current release of Revit. -or- The model is not allowed to access. -or- The document can not be opened. -or- Revit cannot save the transmitted model as a new central because it is already opened.
      Throws OperationCanceledException: Opening was canceled by the user or by an API event callback.
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
      Throws RevitServerInternalException: An internal error happened on the server, please contact the server administrator.
      Throws RevitServerUnauthorizedException: User is not authorized to access the cloud model.
      Throws ServerModelCorruptedException: The central model is corrupted. This exception is treated starting from Revit 2025.2.
      Throws WrongUserException: The local file is not owned by the current user, who therefore is not allowed to modify it.
    Document OpenIFCDocument(string fileName, IFCImportOptions importOptions)
      Description: Opens an IFC document from disk using custom options.
      @fileName: The IFC file to be opened.
      @importOptions: The options for this import.
      Returns: The newly created document containing the IFC file.
      Throws ArgumentException: If 'fileName' is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: If the file specified by 'fileName' cannot be found.
      Throws InvalidOperationException: If Revit is missing document templates or if the file cannot be opened.
    Document OpenIFCDocument(string fileName)
      Description: Opens an IFC document from disk using default options.
      @fileName: The IFC file to be opened.
      Returns: The newly created document containing the IFC file.
      Throws ArgumentException: If 'fileName' is an empty string.
      Throws ArgumentNullException: If is passed as 'fileName' -or- A non-optional argument was null
      Throws FileArgumentNotFoundException: If the file specified by 'fileName' cannot be found.
      Throws InvalidOperationException: If Revit is missing document templates or if the file cannot be opened.
    DefinitionFile OpenSharedParameterFile()
      Description: Enables access to shared parameter groups and definitions that are maintained on disk.
      Returns: An object that represents a shared parameters file that exists on disk. Returns if the file does not exist.
    void PurgeReleasedAPIObjects()
      Description: Explicitly purges all API objects that have been released but are still awaiting to be finalized
    static void RegisterFailuresProcessor(IFailuresProcessor processor)
      Description: Replaces Revit's default user interface (if present) with alternative handling for all warnings and errors (including those not generated by your application) for the rest of the Revit session; if your application is not prepared to respond to all warnings and errors, consider use of IFailuresPreprocessor (in your opened Transaction) or the FailuresProcessing event instead of this interface.
      @processor: Instance of Failures Processor to be used by the Revit Application.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLibraryPaths(IDictionary<string, string> paths)
      Description: Sets path information identifying where Revit searches for content.
      @paths: The map of library paths.
      Throws ArgumentNullException: A non-optional argument was null
    void SetSystemsAnalysisWorkflows(IDictionary<string, string> paths)
      Description: Sets name and path information identifying systems analysis workflow files.
      @paths: The map of systems analysis workflows.
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateRenderAppearanceLibrary()
      Description: Updates the stored render appearance library, giving the Revit session access to any new RPC content.
    void WriteJournalComment(string comment, bool timeStamp)
      Description: Writes a comment to the Revit journal file.
      @comment: Text for journal comment.
      @timeStamp: If a time stamp should be included in the journal comment.
      Throws ArgumentNullException: A non-optional argument was null

  EVENTS:
    event EventHandler<DocumentReloadedLatestEventArgs> DocumentReloadedLatest
      Description: Subscribe to the DocumentReloadedLatestEventArgs event to be notified immediately after Revit has finished reloading a document with central model.
    event EventHandler<DocumentReloadingLatestEventArgs> DocumentReloadingLatest
      Description: Subscribe to the DocumentReloadingLatestEventArgs event to be notified when Revit is just about to reload latest changes from a central model.
    event EventHandler<ElementTypeDuplicatedEventArgs> ElementTypeDuplicated
      Description: Subscribe to the ElementTypeDuplicated event to be notified immediately after Revit has finished duplicating an element type.
    event EventHandler<ElementTypeDuplicatingEventArgs> ElementTypeDuplicating
      Description: Subscribe to the ElementTypeDuplicating event to be notified when Revit is just about to duplicate an element type.
    event EventHandler<FamilyLoadedIntoDocumentEventArgs> FamilyLoadedIntoDocument
      Description: Subscribe to the FamilyLoadedInto event to be notified after Revit loaded a family into a document.
    event EventHandler<FamilyLoadingIntoDocumentEventArgs> FamilyLoadingIntoDocument
      Description: Subscribe to the FamilyLoadingInto event to be notified when Revit is just about to load a family into a document.
    event EventHandler<DocumentWorksharingEnabledEventArgs> DocumentWorksharingEnabled
      Description: Subscribe to the DocumentWorksharingEnabled event to be notified when a document has become workshared.
    event EventHandler<ProgressChangedEventArgs> ProgressChanged
      Description: Subscribe to the ProgressChanged event to be notified when an operation in Revit has progress bar data available.
    event EventHandler<WorksharedOperationProgressChangedEventArgs> WorksharedOperationProgressChanged
      Description: Subscribe to the WorksharedOperationProgressChanged to be notified when progress has changed during Collaboration for Revit's workshared operations: open model and synchronize with central.
    event EventHandler<LinkedResourceOpenedEventArgs> LinkedResourceOpened
      Description: Subscribe to the LinkedResourceOpened event to be notified immediately after Revit has finished opening a linked resource.
    event EventHandler<LinkedResourceOpeningEventArgs> LinkedResourceOpening
      Description: Subscribe to the LinkedResourceOpening event to be notified when Revit is just about to open a linked resource.
    event EventHandler<DocumentSynchronizedWithCentralEventArgs> DocumentSynchronizedWithCentral
      Description: Subscribe to the DocumentSynchronizedWithCentral event to be notified immediately after Revit has finished synchronizing a document with central model.
    event EventHandler<DocumentSynchronizingWithCentralEventArgs> DocumentSynchronizingWithCentral
      Description: Subscribe to the DocumentSynchronizingWithCentral event to be notified when Revit is just about to synchronize a document with central model.
    event EventHandler<DocumentOpenedEventArgs> DocumentOpened
      Description: Subscribe to the DocumentOpened event to be notified immediately after Revit has finished opening a document.
    event EventHandler<DocumentOpeningEventArgs> DocumentOpening
      Description: Subscribe to the DocumentOpening event to be notified when Revit is just about to open a document.
    event EventHandler<ViewsExportedByContextEventArgs> ViewsExportedByContext
      Description: Subscribe to the ViewsExportedByContext event to be notified immediately after Revit has finished exporting one or more views of the document via an export context by CustomExporter.
    event EventHandler<ViewsExportingByContextEventArgs> ViewsExportingByContext
      Description: Subscribe to the ViewsExportingByContext event to be notified when Revit is just about to export one or more views of the document via an export context by CustomExporter.
    event EventHandler<ViewExportedEventArgs> ViewExported
      Description: Subscribe to the ViewExported event to be notified immediately after Revit has finished exporting a view of the document.
    event EventHandler<ViewExportingEventArgs> ViewExporting
      Description: Subscribe to the ViewExporting event to be notified when Revit is just about to export a view of the document.
    event EventHandler<FileExportedEventArgs> FileExported
      Description: Subscribe to the FileExported event to be notified immediately after Revit has finished exporting files of formats supported by the API.
    event EventHandler<FileExportingEventArgs> FileExporting
      Description: Subscribe to the FileExporting event to be notified when Revit is just about to export files of formats supported by the API.
    event EventHandler<FileImportedEventArgs> FileImported
      Description: Subscribe to the FileImported event to be notified immediately after Revit has finished importing a file of format supported by the API.
    event EventHandler<FileImportingEventArgs> FileImporting
      Description: Subscribe to the FileImporting event to be notified when Revit is just about to import a file of format supported by the API.
    event EventHandler<DocumentCreatedEventArgs> DocumentCreated
      Description: Subscribe to the DocumentCreated event to be notified immediately after Revit has finished creating a new document.
    event EventHandler<DocumentCreatingEventArgs> DocumentCreating
      Description: Subscribe to the DocumentCreating event to be notified when Revit is just about to create a new document.
    event EventHandler<DocumentClosedEventArgs> DocumentClosed
      Description: Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.
    event EventHandler<DocumentClosingEventArgs> DocumentClosing
      Description: Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.
    event EventHandler<ViewPrintedEventArgs> ViewPrinted
      Description: Subscribe to the ViewPrinted event to be notified immediately after Revit has finished printing a view of the document.
    event EventHandler<ViewPrintingEventArgs> ViewPrinting
      Description: Subscribe to the ViewPrinting event to be notified when Revit is just about to print a view of the document.
    event EventHandler<DocumentPrintedEventArgs> DocumentPrinted
      Description: Subscribe to the DocumentPrinted event to be notified immediately after Revit has finished printing a view or ViewSet of the document.
    event EventHandler<DocumentPrintingEventArgs> DocumentPrinting
      Description: Subscribe to the DocumentPrinting event to be notified when Revit is just about to print a view or ViewSet of the document.
    event EventHandler<DocumentSavedAsEventArgs> DocumentSavedAs
      Description: Subscribe to the DocumentSavedAs event to be notified immediately after Revit has finished saving document with a new file name.
    event EventHandler<DocumentSavingAsEventArgs> DocumentSavingAs
      Description: Subscribe to the DocumentSavingAs event to be notified when Revit is just about to save the document with a new file name.
    event EventHandler<DocumentSavedEventArgs> DocumentSaved
      Description: Subscribe to the DocumentSaved event to be notified immediately after Revit has finished saving a document.
    event EventHandler<DocumentSavingEventArgs> DocumentSaving
      Description: Subscribe to the DocumentSaving event to be notified when Revit is just about to save a document.
    event EventHandler<FailuresProcessingEventArgs> FailuresProcessing
      Description: Subscribe to the FailuresProcessing event to be notified when failures are being processed at the end of transaction.
    event EventHandler<DocumentChangedEventArgs> DocumentChanged
      Description: Subscribe to the DocumentChanged event to be notified when Revit document has changed.
    event EventHandler<ApplicationInitializedEventArgs> ApplicationInitialized
      Description: Subscribe to this event to get notified after the Revit application has been initialized

--------------------------------------------------------------------------------

[CLASS] ControlledApplication
Full Name: Autodesk.Revit.ApplicationServices.ControlledApplication
Description: Represents the Autodesk Revit Application with no access to documents. It provides options and other application wide data and settings for external applications OnStartup/OnShutdown.

  PROPERTIES:
    AddInId ActiveAddInId { get; }
      Description: Retrieves the Id of the currently running external application.
    string AllUsersAddinsLocation { get; }
      Description: The folder location for .addin files for all users.
    CitySet Cities { get; }
      Description: Returns a set of all the known city locations within Revit.
    Application Create { get; }
      Description: Provides an object that can be used to create new instances of Autodesk Revit API objects.
    string CurrentUserAddinsLocation { get; }
      Description: The folder location for .addin files for the current user.
    string CurrentUsersAddinsDataFolderPath { get; }
      Description: Path to AddinsData folder for the current user.
    string CurrentUsersDataFolderPath { get; }
      Description: Path to data folder for the current user.
    bool IsLateAddinLoading { get; }
      Description: Indicates whether this add-in is loaded on the fly or not. If it is loaded when is Revit starting up, it is false, otherwise it should be true.
    LanguageType Language { get; }
      Description: The language used in the current session of Revit.
    ProductType Product { get; }
      Description: The product type for the current session of Revit.
    string RecordingJournalFilename { get; }
      Description: Retrieve the name of the journal file the Revit is currently recording to.
    string SharedParametersFilename { get; set; }
      Description: Contains the fully qualified path to a shared parameters file.
    string SubVersionNumber { get; }
      Description: The minor version number of Revit
    string VersionBuild { get; }
      Description: Returns the internal build number of the Autodesk Revit application.
    string VersionName { get; }
      Description: Returns the name of the Revit application.
    string VersionNumber { get; }
      Description: Return the primary version of the Revit application.

  METHODS:
    static FailureDefinitionRegistry GetFailureDefinitionRegistry()
      Description: Returns the instance of FailureDefinitionRegistry.
      Returns: The instance of FailureDefinitionRegistry.
    IDictionary<string, string> GetLibraryPaths()
      Description: Returns path information identifying where Revit searches for content.
      Returns: The map of library paths.
    bool IsJournalPlaying()
      Description: Determines if the application is currently in journal playback mode.
      Returns: true if a journal is currently playing back, false otherwise.
    DefinitionFile OpenSharedParameterFile()
      Description: Enables access to shared parameter groups and definitions that are maintained on disk.
      Returns: An object that represents a shared parameters file that exists on disk. Returns if the file does not exist.
    static void RegisterFailuresProcessor(IFailuresProcessor processor)
      Description: Replaces Revit's default user interface (if present) with alternative handling for all warnings and errors (including those not generated by your application) for the rest of the Revit session; if your application is not prepared to respond to all warnings and errors, consider use of IFailuresPreprocessor (in your opened Transaction) or the FailuresProcessing event instead of this interface.
      @processor: Instance of Failures Processor to be used by the Revit Application.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLibraryPaths(IDictionary<string, string> paths)
      Description: Sets path information identifying where Revit searches for content.
      @paths: The map of library paths.
      Throws ArgumentNullException: A non-optional argument was null
    void WriteJournalComment(string comment, bool timeStamp)
      Description: Writes a comment to the Revit journal file.
      @comment: Text for journal comment.
      @timeStamp: If a time stamp should be included in the journal comment.
      Throws ArgumentNullException: A non-optional argument was null

  EVENTS:
    event EventHandler<DocumentReloadedLatestEventArgs> DocumentReloadedLatest
      Description: Subscribe to the DocumentReloadedLatestEventArgs event to be notified immediately after Revit has finished reloading a document with central model.
    event EventHandler<DocumentReloadingLatestEventArgs> DocumentReloadingLatest
      Description: Subscribe to the DocumentReloadingLatestEventArgs event to be notified when Revit is just about to reload latest changes from a central model.
    event EventHandler<ElementTypeDuplicatedEventArgs> ElementTypeDuplicated
      Description: Subscribe to the ElementTypeDuplicated event to be notified immediately after Revit has finished duplicating an element type.
    event EventHandler<ElementTypeDuplicatingEventArgs> ElementTypeDuplicating
      Description: Subscribe to the ElementTypeDuplicating event to be notified when Revit is just about to duplicate an element type.
    event EventHandler<FamilyLoadedIntoDocumentEventArgs> FamilyLoadedIntoDocument
      Description: Subscribe to the FamilyLoadedInto event to be notified after Revit loaded a family into a document.
    event EventHandler<FamilyLoadingIntoDocumentEventArgs> FamilyLoadingIntoDocument
      Description: Subscribe to the FamilyLoadingInto event to be notified when Revit is just about to load a family into a document.
    event EventHandler<ApplicationInitializedEventArgs> ApplicationInitialized
      Description: Subscribe to this event to get notified after the Revit application has been initialized
    event EventHandler<ProgressChangedEventArgs> ProgressChanged
      Description: Subscribe to the ProgressChanged event to be notified when an operation in Revit has progress bar data available.
    event EventHandler<DocumentSynchronizedWithCentralEventArgs> DocumentSynchronizedWithCentral
      Description: Subscribe to the DocumentSynchronizedWithCentral event to be notified immediately after Revit has finished synchronizing a document with central model.
    event EventHandler<DocumentSynchronizingWithCentralEventArgs> DocumentSynchronizingWithCentral
      Description: Subscribe to the DocumentSynchronizingWithCentral event to be notified when Revit is just about to synchronize a document with central model.
    event EventHandler<DocumentOpenedEventArgs> DocumentOpened
      Description: Subscribe to the DocumentOpened event to be notified immediately after Revit has finished opening a document.
    event EventHandler<DocumentOpeningEventArgs> DocumentOpening
      Description: Subscribe to the DocumentOpening event to be notified when Revit is just about to open a document.
    event EventHandler<FileExportedEventArgs> FileExported
      Description: Subscribe to the FileExported event to be notified immediately after Revit has finished exporting files of formats supported by the API.
    event EventHandler<FileExportingEventArgs> FileExporting
      Description: Subscribe to the FileExporting event to be notified when Revit is just about to export files of formats supported by the API.
    event EventHandler<FileImportedEventArgs> FileImported
      Description: Subscribe to the FileImported event to be notified immediately after Revit has finished importing a file of format supported by the API.
    event EventHandler<FileImportingEventArgs> FileImporting
      Description: Subscribe to the FileImporting event to be notified when Revit is just about to import a file of format supported by the API.
    event EventHandler<DocumentCreatedEventArgs> DocumentCreated
      Description: Subscribe to the DocumentCreated event to be notified immediately after Revit has finished creating a new document.
    event EventHandler<DocumentCreatingEventArgs> DocumentCreating
      Description: Subscribe to the DocumentCreating event to be notified when Revit is just about to create a new document.
    event EventHandler<DocumentClosedEventArgs> DocumentClosed
      Description: Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.
    event EventHandler<DocumentClosingEventArgs> DocumentClosing
      Description: Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.
    event EventHandler<ViewPrintedEventArgs> ViewPrinted
      Description: Subscribe to the ViewPrinted event to be notified immediately after Revit has finished printing a view of the document.
    event EventHandler<ViewPrintingEventArgs> ViewPrinting
      Description: Subscribe to the ViewPrinting event to be notified when Revit is just about to print a view of the document.
    event EventHandler<DocumentPrintedEventArgs> DocumentPrinted
      Description: Subscribe to the DocumentPrinted event to be notified immediately after Revit has finished printing a view or ViewSet of the document.
    event EventHandler<DocumentPrintingEventArgs> DocumentPrinting
      Description: Subscribe to the DocumentPrinting event to be notified when Revit is just about to print a view or ViewSet of the document.
    event EventHandler<DocumentSavedAsEventArgs> DocumentSavedAs
      Description: Subscribe to the DocumentSavedAs event to be notified immediately after Revit has finished saving document with a new file name.
    event EventHandler<DocumentSavingAsEventArgs> DocumentSavingAs
      Description: Subscribe to the DocumentSavingAs event to be notified when Revit is just about to save the document with a new file name.
    event EventHandler<DocumentSavedEventArgs> DocumentSaved
      Description: Subscribe to the DocumentSaved event to be notified immediately after Revit has finished saving a document.
    event EventHandler<DocumentSavingEventArgs> DocumentSaving
      Description: Subscribe to the DocumentSaving event to be notified when Revit is just about to save a document.
    event EventHandler<FailuresProcessingEventArgs> FailuresProcessing
      Description: Subscribe to the FailuresProcessing event to be notified when failures are being processed at the end of transaction.
    event EventHandler<WorksharedOperationProgressChangedEventArgs> WorksharedOperationProgressChanged
      Description: Subscribe to the WorksharedOperationProgressChanged to be notified when progress has changed during Collaboration for Revit's workshared operations: open model and synchronize with central.
    event EventHandler<LinkedResourceOpenedEventArgs> LinkedResourceOpened
      Description: Subscribe to the LinkedResourceOpened event to be notified immediately after Revit has finished opening a linked resource.
    event EventHandler<LinkedResourceOpeningEventArgs> LinkedResourceOpening
      Description: Subscribe to the LinkedResourceOpening event to be notified when Revit is just about to open a linked resource.
    event EventHandler<DocumentChangedEventArgs> DocumentChanged
      Description: Subscribe to the DocumentChanged event to be notified when Revit document has changed.

--------------------------------------------------------------------------------

[ENUM] LanguageType
Full Name: Autodesk.Revit.ApplicationServices.LanguageType
Description: An enumerated type containing the supported Revit product languages.
Inherits: Enum

  Values:
    - English_USA = 0
    - German = 1
    - Spanish = 2
    - French = 3
    - Italian = 4
    - Dutch = 5
    - Chinese_Simplified = 6
    - Chinese_Traditional = 7
    - Japanese = 8
    - Korean = 9
    - Russian = 10
    - Czech = 11
    - Polish = 12
    - Hungarian = 13
    - Brazilian_Portuguese = 14
    - English_GB = 15
    - Unknown = -1

--------------------------------------------------------------------------------

[ENUM] ProductType
Full Name: Autodesk.Revit.ApplicationServices.ProductType
Description: An enumerated type containing the possible Revit product types.
Inherits: Enum

  Values:
    - Architecture = 0
    - Structure = 1
    - MEP = 2
    - Revit = 3
    - LT = 4
    - Unknown = 5

--------------------------------------------------------------------------------

