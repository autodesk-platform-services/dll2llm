# Autodesk.Revit.DB.Events


NAMESPACE: Autodesk.Revit.DB.Events
--------------------------------------------------------------------------------

[CLASS] ApplicationInitializedEventArgs
Full Name: Autodesk.Revit.DB.Events.ApplicationInitializedEventArgs

Description: The event arguments used by the ApplicationLaunched event.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] CreateRelatedFileProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.CreateRelatedFileProgressChangedEventArgs

Description: The event arguments used during creating related file phase of in model open operation.
Inherits: DataTransferProgressChangedEventArgs
Implements: IDisposable

  PROPERTIES:
    bool CreatingCloudSharedLocal { get; }
      Description: Indicates if it is creating cloud shared local model.
    bool DownloadFinished { get; }
      Description: Indicates if all data downloads are finished.
    bool FullDownload { get; }
      Description: Indicates if download the full data of the document, which will take longer than subsequent downloads.

--------------------------------------------------------------------------------

[ENUM] DataTransferMode
Full Name: Autodesk.Revit.DB.Events.DataTransferMode

Description: Describes the data transfer mode.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Download = 0
    - Upload = 1
    - Undefined = -1

[CLASS] DataTransferProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.DataTransferProgressChangedEventArgs

Description: The event arguments used during the data transferring phase of .
Remarks: It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time.
Inherits: WorksharedOperationProgressChangedEventArgs
Implements: IDisposable

  PROPERTIES:
    double FinishedSize { get; }
      Description: The transferred data size, in bytes, since the last time this event was raised.
    double Speed { get; }
      Description: Speed(bytes/second) in this event.
    double TotalSize { get; }
      Description: Total expected data size to transfer, in bytes.
    DataTransferMode TransferMode { get; }
      Description: Data transfer mode in this event.

--------------------------------------------------------------------------------

[CLASS] DocumentChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentChangedEventArgs

Description: The event arguments used by the DocumentChanged event.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

  PROPERTIES:
    UndoOperation Operation { get; }
      Description: The operation associated with this event

  METHODS:
    ICollection<ElementId> GetAddedElementIds(ElementFilter filter)
      Description: Returns set of newly added elements that pass the filter.
      @filter: The element filter to be applied.
      Returns: The set of ElementId for newly added elements that pass the filter. Returns empty set if no elements are found which pass the filter.
    ICollection<ElementId> GetAddedElementIds()
      Description: Returns set of elements newly added to the document.
      Returns: The set of ElementId for elements newly added to the document.
    ICollection<ElementId> GetDeletedElementIds()
      Description: Returns set of elements that were deleted from the document.
      Returns: The set of ElementId for elements that were deleted from the document.
    Document GetDocument()
      Description: Returns document associated with this event
      Returns: The document associated with this event.
    ICollection<ElementId> GetModifiedElementIds(ElementFilter filter)
      Description: Returns set of elements that were modified according to the given element filter.
      @filter: The element filter to be applied.
      Returns: The set of ElementId for modified elements that pass the filter. Returns empty set if no elements are found which pass the filter.
    ICollection<ElementId> GetModifiedElementIds()
      Description: Returns set of elements that were modified.
      Returns: The set of ElementId for elements that were modified.
    IList<string> GetTransactionNames()
      Description: Returns names of the transactions associated with this event
      Returns: The names of the transactions associated with this event

--------------------------------------------------------------------------------

[CLASS] DocumentClosedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentClosedEventArgs

Description: The event arguments used by the DocumentClosed event.
Inherits: RevitAPIPostEventArgs
Implements: IDisposable

  PROPERTIES:
    int DocumentId { get; }
      Description: Id of the document that has just been closed.

--------------------------------------------------------------------------------

[CLASS] DocumentClosingEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentClosingEventArgs

Description: The event arguments used by the DocumentClosing event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    int DocumentId { get; }
      Description: Id of the document that is about to be closed.

--------------------------------------------------------------------------------

[CLASS] DocumentCreatedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentCreatedEventArgs

Description: The event arguments used by the DocumentCreated event.
Remarks: The newly created document is supplied in these arguments.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DocumentCreatingEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentCreatingEventArgs

Description: The event arguments used by the DocumentCreating event.
Inherits: RevitAPIPreEventArgs
Implements: IDisposable

  PROPERTIES:
    DocumentType DocumentType { get; }
      Description: Type of the document which is about to be created, e.g. Project or Template.
    string Template { get; }
      Description: The template file path to be used for creating the new document.

--------------------------------------------------------------------------------

[CLASS] DocumentOpenedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentOpenedEventArgs

Description: The event arguments used by the DocumentOpened event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DocumentOpeningEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentOpeningEventArgs

Description: The event arguments used by the DocumentOpening event.
Inherits: RevitAPIPreEventArgs
Implements: IDisposable

  PROPERTIES:
    DocumentType DocumentType { get; }
      Description: Type of the document, e.g. Project or Template.
    string PathName { get; }
      Description: Path of the document to be opened.

--------------------------------------------------------------------------------

[CLASS] DocumentPrintedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentPrintedEventArgs

Description: The event arguments used by the DocumentPrinted event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  METHODS:
    IList<ElementId> GetFailedViewElementIds()
      Description: Returns ElementIds of the views that that failed to print (if any).
      Returns: ElementIds of the views that that failed to print (if any).
    IList<ElementId> GetPrintedViewElementIds()
      Description: Returns ElementIds of the views that printed successfully.
      Returns: ElementIds of the views that printed successfully.

--------------------------------------------------------------------------------

[CLASS] DocumentPrintingEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentPrintingEventArgs

Description: The event arguments used by the DocumentPrinting event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  METHODS:
    IPrintSetting GetSettings()
      Description: Gets the print settings of the active printing session.
      Returns: The print settings of the active printing session.
    IList<ElementId> GetViewElementIds()
      Description: Returns ElementIds of the views to be printed.
      Returns: ElementIds of the views to be printed.

--------------------------------------------------------------------------------

[CLASS] DocumentReloadedLatestEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentReloadedLatestEventArgs

Description: The event arguments used by the DocumentReloadedLatestEvent event. This event will be raised when executing pull a latest changes from a central model.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string Location { get; set; }
      Description: Full path of the central model which is to be operated.

--------------------------------------------------------------------------------

[CLASS] DocumentReloadingLatestEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentReloadingLatestEventArgs

Description: The event arguments used by the DocumentReloadingLatest event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DocumentReloadLatestProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentReloadLatestProgressChangedEventArgs

Description: The event arguments used during the reload latest phase of .
Remarks: It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time. Name correction - it is renamed from 'DocumentReloadLatestProgessChangedEventArgs' released since 2017 Subscription Update.
Inherits: DataTransferProgressChangedEventArgs
Implements: IDisposable

  PROPERTIES:
    bool IsMerging { get; }
      Description: Indicates if it is merging downloaded data.
    bool ReloadLatestFinished { get; }
      Description: Indicates if current 'reload latest' progress is finished.
    int RetryTimes { get; }
      Description: The number of times Revit has tried to Reload Latest. Its value is '0' at the first time.

--------------------------------------------------------------------------------

[CLASS] DocumentSavedAsEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSavedAsEventArgs

Description: The event arguments used by the DocumentSavedAs event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    bool IsSavingAsCentralFile { get; }
      Description: Indicates whether the document is to be saved as central file.
    string OriginalPath { get; }
      Description: Original path of the document.

--------------------------------------------------------------------------------

[CLASS] DocumentSavedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSavedEventArgs

Description: The event arguments used by the DocumentSaved event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DocumentSaveToCentralProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSaveToCentralProgressChangedEventArgs

Description: The event arguments used during the save to central phase of .
Remarks: It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time. Name correction - it is renamed from 'DocumentSaveToCentralProgessChangedEventArgs' released since 2017 Subscription Update.
Inherits: DataTransferProgressChangedEventArgs
Implements: IDisposable

  PROPERTIES:
    bool FailureDueToConflicts { get; }
      Description: Indicates the 'save to central' failure is caused by submission conflicts, that is because another one finished saving to central first.
    int RetryTimes { get; }
      Description: The number of times Revit has tried to Save to Central." Its value is '0' at the first time.
    bool SaveToCentralFinished { get; }
      Description: Indicates if current 'save to central' is finished.

--------------------------------------------------------------------------------

[CLASS] DocumentSaveToLocalProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSaveToLocalProgressChangedEventArgs

Description: The event arguments used during the save to local phase of .
Remarks: It is NOT recommended to do any time-consuming work when handling WorksharedOperationProgressChanged event. This can increase workshared operation time. Name correction - it is renamed from 'DocumentSaveToLocalProgessChangedEventArgs' released since 2017 Subscription Update.
Inherits: WorksharedOperationProgressChangedEventArgs
Implements: IDisposable

  PROPERTIES:
    bool BeforeSaveToCentral { get; }
      Description: True if the "save to local" operation is occurring before "save to central"; false if after.
    int FinishedStreams { get; }
      Description: The number of streams finished since the last time this event was raised.
    bool SaveToLocalFinished { get; }
      Description: Indicates if the current "save to local" operation has finished.
    int TotalStreams { get; }
      Description: The total expected number of streams to save to local.

--------------------------------------------------------------------------------

[CLASS] DocumentSavingAsEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSavingAsEventArgs

Description: The event arguments used by the DocumentSavingAs event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    bool IsSavingAsCentralFile { get; }
      Description: Indicates whether the document is to be saved as central file.
    string PathName { get; }
      Description: Target path to which the document is to be saved.

--------------------------------------------------------------------------------

[CLASS] DocumentSavingEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSavingEventArgs

Description: The event arguments used by the DocumentSaving event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DocumentSynchronizedWithCentralEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSynchronizedWithCentralEventArgs

Description: The event arguments used by the DocumentSynchronizedWithCentralEventArgs event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] DocumentSynchronizingWithCentralEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentSynchronizingWithCentralEventArgs

Description: The event arguments used by the DocumentSynchronizingWithCentralEventArgs event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string Comments { get; }
      Description: User's comments for synchronization.
    string Location { get; }
      Description: Full path of the central model which is to be synchronized.
    SynchronizeWithCentralOptions Options { get; }
      Description: User's options associated with the synchronization operation.

--------------------------------------------------------------------------------

[CLASS] DocumentWorksharingEnabledEventArgs
Full Name: Autodesk.Revit.DB.Events.DocumentWorksharingEnabledEventArgs

Description: The event arguments used by the DocumentWorksharingEnabled event.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

  METHODS:
    Document GetDocument()
      Description: Returns document associated with this event
      Returns: The document associated with this event.

--------------------------------------------------------------------------------

[CLASS] ElementTypeDuplicatedEventArgs
Full Name: Autodesk.Revit.DB.Events.ElementTypeDuplicatedEventArgs

Description: The event arguments used by the ElementTypeDuplicated event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId NewElementTypeId { get; }
      Description: The id of the newly duplicated ElementType.
    string NewName { get; }
      Description: The name of the newly duplicated ElementType.
    ElementId OriginalElementTypeId { get; }
      Description: The id of the element type that is duplicated.

--------------------------------------------------------------------------------

[CLASS] ElementTypeDuplicatingEventArgs
Full Name: Autodesk.Revit.DB.Events.ElementTypeDuplicatingEventArgs

Description: The event arguments used by the ElementTypeDuplicating event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId ElementTypeId { get; }
      Description: The id of the ElementType to be duplicated.

--------------------------------------------------------------------------------

[ENUM] EventStatus
Full Name: Autodesk.Revit.DB.Events.EventStatus

Description: Describes the status of an action which triggered a post event.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Succeeded = 0
    - Cancelled = 1
    - Failed = -1

[CLASS] ExternalDataInstanceAddedIntoDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataInstanceAddedIntoDocumentEventArgs

Description: The event arguments used by the ExternalDataInstanceAddedInto event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string ItemId { get; }
      Description: The id of the external data item to which a new reference has been added.
    ElementId NewInstanceId { get; }
      Description: The newly added external data instance id.
    string ProjectId { get; }
      Description: The id of the external project of the external data item to which a new reference has been added.
    ElementId TypeId { get; }
      Description: The type id of the newly added external data instance id.

--------------------------------------------------------------------------------

[CLASS] ExternalDataInstanceAddingIntoDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataInstanceAddingIntoDocumentEventArgs

Description: The event arguments used by the ExternalDataInstanceAddingInto event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId TypeId { get; }
      Description: The type id of the newl external data instance that is being added.

--------------------------------------------------------------------------------

[CLASS] ExternalDataInstanceRemovedFromDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataInstanceRemovedFromDocumentEventArgs

Description: The event arguments used by the ExternalDataInstanceRemovedFrom event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId TypeId { get; }
      Description: The type id of the external data instance id that has been removed from Revit document.

--------------------------------------------------------------------------------

[CLASS] ExternalDataInstanceRemovingFromDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataInstanceRemovingFromDocumentEventArgs

Description: The event arguments used by the ExternalDataInstanceRemovingFrom event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId InstanceId { get; }
      Description: The Revit id of the external data instance being removed from Revit document.
    ElementId TypeId { get; }
      Description: The type id of the external data instance id being removed from Revit document.

--------------------------------------------------------------------------------

[CLASS] ExternalDataTypeServerFailureResolutionExecutingEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataTypeServerFailureResolutionExecutingEventArgs

Description: The event arguments used by the ExternalDataTypeServerFailureResolutionExecuting event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] ExternalDataTypeUpdatedDataSourceIntoDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataTypeUpdatedDataSourceIntoDocumentEventArgs

Description: The event arguments used by the ExternalDataTypeUpdatedInto event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string ItemId { get; }
      Description: The id of the external data item to which the external data type is updated.
    string ProjectId { get; }
      Description: The id of the external project of the external data item to which the external data type is updated.
    ElementId TypeId { get; }
      Description: The type id of the external data type that is being updated.

--------------------------------------------------------------------------------

[CLASS] ExternalDataTypeUpdatingDataSourceIntoDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.ExternalDataTypeUpdatingDataSourceIntoDocumentEventArgs

Description: The event arguments used by the ExternalDataTypeUpdatingDataSourceInto event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId TypeId { get; }
      Description: The type id of the external data type that is being updated.

--------------------------------------------------------------------------------

[CLASS] FailuresProcessingEventArgs
Full Name: Autodesk.Revit.DB.Events.FailuresProcessingEventArgs

Description: The event arguments used by the FailuresProcessing event.
Remarks: The event arguments provide access to the FailuresAccessor via which contains the details of the errors and/or warnings that caused the event to trigger. The arguments also allow you to set a processing result via . The processing result determines if Revit will attempt to recommit the currently failing transaction, roll it back, or continue. If you are explicitly dismissing warnings from the event callback, a processing result of Continue is sufficient. But if you are explicitly resolving errors from the event callback, you must change the processing result to ProceedWithCommit to ensure that the user is not shown the dismissed errors. If you wish to cancel the transaction silently without showing the errors to the user, set the processing result to ProceedWithRollback, however you must also call in order to dismiss the errors and silently cancel the transaction.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

  METHODS:
    FailuresAccessor GetFailuresAccessor()
      Description: Provides access to the failure information in the document.
      Returns: The accessor to the failures in the document.
    FailureProcessingResult GetProcessingResult()
      Description: Retrieves current status of the failures processing result.
      Returns: The current failures processing result.
    void SetProcessingResult(FailureProcessingResult result)
      Description: Sets the result of the failures processing accomplished during this event callback.
      @result: The result.

--------------------------------------------------------------------------------

[CLASS] FamilyLoadedIntoDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.FamilyLoadedIntoDocumentEventArgs

Description: The event arguments used by the FamilyLoadedInto event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string FamilyName { get; }
      Description: The file name of the family that is loaded into the document.
    string FamilyPath { get; }
      Description: The file path of the family that is loaded into the document.
    ElementId NewFamilyId { get; }
      Description: The newly loaded family id.
    ElementId OriginalFamilyId { get; }
      Description: The original family id that is overridden by the newly loaded family.

--------------------------------------------------------------------------------

[CLASS] FamilyLoadingIntoDocumentEventArgs
Full Name: Autodesk.Revit.DB.Events.FamilyLoadingIntoDocumentEventArgs

Description: The event arguments used by the FamilyLoadingInto event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string FamilyName { get; }
      Description: The file name of the family that is being loaded into the document.
    string FamilyPath { get; }
      Description: The file path of the family that is being loaded into the document.

--------------------------------------------------------------------------------

[CLASS] FileExportedEventArgs
Full Name: Autodesk.Revit.DB.Events.FileExportedEventArgs

Description: The event arguments used by the FileExported event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    bool BackgroundOperation { get; }
      Description: Identifies whether the event belongs to a background export operation.
    ImportExportFileFormat Format { get; }
      Description: Identifies the export format, e.g. DWG or image.
    string Path { get; }
      Description: Target path for the exported file (or files).

--------------------------------------------------------------------------------

[CLASS] FileExportingEventArgs
Full Name: Autodesk.Revit.DB.Events.FileExportingEventArgs

Description: The event arguments used by the FileExporting event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    bool BackgroundOperation { get; }
      Description: Identifies whether the event belongs to a background export operation.
    ImportExportFileFormat Format { get; }
      Description: Identifies the export format, e.g. DWG or image.
    string Path { get; }
      Description: The target path for the export.

--------------------------------------------------------------------------------

[CLASS] FileImportedEventArgs
Full Name: Autodesk.Revit.DB.Events.FileImportedEventArgs

Description: The event arguments used by the FileImported event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ImportExportFileFormat Format { get; }
      Description: Identifies the import format, e.g. DWG or image.
    ElementId ImportedInstanceId { get; }
      Description: The ElementId of the imported instance that represents the imported object(s) after a successful import. It could be used for further manipulation of that instance.
    string Path { get; }
      Description: Path of the source file that was imported.

--------------------------------------------------------------------------------

[CLASS] FileImportingEventArgs
Full Name: Autodesk.Revit.DB.Events.FileImportingEventArgs

Description: The event arguments used by the FileImporting event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ImportExportFileFormat Format { get; }
      Description: Identifies the import format, e.g. DWG or image.
    string Path { get; }
      Description: Path of the source file which is about to be imported.

--------------------------------------------------------------------------------

[CLASS] LinkedResourceOpenedEventArgs
Full Name: Autodesk.Revit.DB.Events.LinkedResourceOpenedEventArgs

Description: The event arguments used by .
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    string LinkedResourcePathName { get; }
      Description: Path of the linked resource.
    ExternalResourceType ResourceType { get; }
      Description: The desired linked resource type.
    ElementId ResourceTypeId { get; }
      Description: Element id of the linked resource.

--------------------------------------------------------------------------------

[CLASS] LinkedResourceOpeningEventArgs
Full Name: Autodesk.Revit.DB.Events.LinkedResourceOpeningEventArgs

Description: The event arguments used by .
Inherits: RevitAPIPreEventArgs
Implements: IDisposable

  PROPERTIES:
    string LinkedResourcePathName { get; }
      Description: Path of the linked resource.
    ExternalResourceType ResourceType { get; }
      Description: The desired linked resource type.

--------------------------------------------------------------------------------

[CLASS] PostDocEventArgs
Full Name: Autodesk.Revit.DB.Events.PostDocEventArgs

Description: The class is used as base class for arguments of any post-event that is associated to a particular Document.
Inherits: PostEventArgs

  PROPERTIES:
    Document Document { get; }
      Description: The document associated with the event.

--------------------------------------------------------------------------------

[CLASS] PostEventArgs
Full Name: Autodesk.Revit.DB.Events.PostEventArgs

Description: The class is used as a base class for arguments of any post-event.
Inherits: RevitEventArgs

  PROPERTIES:
    EventStatus Status { get; }
      Description: Indicates whether the action associated with this event succeeded, failed, or was cancelled (by an APIevent handler).

--------------------------------------------------------------------------------

[CLASS] PreDocEventArgs
Full Name: Autodesk.Revit.DB.Events.PreDocEventArgs

Description: The class is used as base class for the arguments of any pre-event arguments that is associated to a particular Document.
Inherits: PreEventArgs

  PROPERTIES:
    Document Document { get; }
      Description: The document associated with the event.

--------------------------------------------------------------------------------

[CLASS] PreEventArgs
Full Name: Autodesk.Revit.DB.Events.PreEventArgs

Description: The class is used as a base class for the arguments for any pre-event.
Inherits: RevitEventArgs

--------------------------------------------------------------------------------

[CLASS] ProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.ProgressChangedEventArgs

Description: The event arguments used by the ProgressChanged event.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

  PROPERTIES:
    string Caption { get; }
      Description: The text from the progress bar caption that describes the operation in progress
    int LowerRange { get; }
      Description: Lower part of progress bar range - always zero
    int Position { get; }
      Description: Progress bar position - value is always between zero and upperRange and is incremented by one with each event of stage "PositionChanged"
    ProgressStage Stage { get; }
      Description: The current stage of the progress bar
    int UpperRange { get; }
      Description: Upper part of progress bar range - will be any non-zero number

  METHODS:
    void Cancel()
      Description: Requests to cancel the progress bar's operation.

--------------------------------------------------------------------------------

[ENUM] ProgressStage
Full Name: Autodesk.Revit.DB.Events.ProgressStage

Description: The associated action of a ProgressChanged event
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Started = 0
    - RangeChanged = 1
    - PositionChanged = 2
    - CaptionChanged = 3
    - Unchanged = 4
    - Finished = 5

[CLASS] ProjectBrowserDataChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.ProjectBrowserDataChangedEventArgs

Description: The event arguments used by the ProjectBrowserDataChanged event.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] RevitAPIEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitAPIEventArgs

Description: The class is used as base class for all event argument classes.
Inherits: EventArgs
Implements: IDisposable

  PROPERTIES:
    bool Cancellable { get; }
      Description: Indicates whether an event may be cancelled by an event delegate.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsCancelled()
      Description: Indicates whether the event is being cancelled.

--------------------------------------------------------------------------------

[ENUM] RevitAPIEventStatus
Full Name: Autodesk.Revit.DB.Events.RevitAPIEventStatus

Description: Describes the status of an action which triggered a post event.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Succeeded = 0
    - Cancelled = 1
    - Failed = -1

[CLASS] RevitAPIPostDocEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitAPIPostDocEventArgs

Description: The base class used for post events where the arguments must supply access to the document.
Inherits: RevitAPIPostEventArgs
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The document associated with the event.

--------------------------------------------------------------------------------

[CLASS] RevitAPIPostEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitAPIPostEventArgs

Description: The class is used as a base class for arguments of any post-event.
Remarks: A post-event is the event raised after execution of the process that was related with the event.
Inherits: RevitAPIEventArgs
Implements: IDisposable

  PROPERTIES:
    RevitAPIEventStatus Status { get; }
      Description: Indicates whether the action associated with this event succeeded, failed, or was cancelled (by an API event handler).

--------------------------------------------------------------------------------

[CLASS] RevitAPIPreDocEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitAPIPreDocEventArgs

Description: The base class used for pre events where the arguments must supply access to the document.
Inherits: RevitAPIPreEventArgs
Implements: IDisposable

  PROPERTIES:
    Document Document { get; }
      Description: The document associated with the event.

--------------------------------------------------------------------------------

[CLASS] RevitAPIPreEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitAPIPreEventArgs

Description: The class is used as a base class for the arguments for any pre-event.
Remarks: A pre-event is the event raised before executing the process that was related with the event.
Inherits: RevitAPIEventArgs
Implements: IDisposable

  METHODS:
    void Cancel()
      Description: When the event is cancellable, may call the Cancel() method to cancel it.

--------------------------------------------------------------------------------

[CLASS] RevitAPISingleEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitAPISingleEventArgs

Description: The class is used as a base class for arguments of any single-event.
Remarks: A single event is an event that is not directly related to another event, meaning that there is no corresponding pre-event or post-event surrounding a single event.
Inherits: RevitAPIEventArgs
Implements: IDisposable

--------------------------------------------------------------------------------

[CLASS] RevitEventArgs
Full Name: Autodesk.Revit.DB.Events.RevitEventArgs

Description: The class is used as base class for all event argument classes.
Inherits: EventArgs

  PROPERTIES:
    bool Cancel { get; set; }
      Description: Indicates whether the event is being cancelled. When the event is cancellable, set the property to True to cancel it.
    bool Cancellable { get; }
      Description: Indicates whether an event may be cancelled by an event delegate.

--------------------------------------------------------------------------------

[ENUM] UndoOperation
Full Name: Autodesk.Revit.DB.Events.UndoOperation

Description: The operation associated with DocumentChanged event
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TransactionCommitted = 0
    - TransactionRolledBack = 1
    - TransactionGroupRolledBack = 2
    - TransactionUndone = 3
    - TransactionRedone = 4

[CLASS] ViewExportedEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewExportedEventArgs

Description: The event arguments used by the ViewExported event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId ViewId { get; }
      Description: Identifies the view that was exported.

--------------------------------------------------------------------------------

[CLASS] ViewExportingEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewExportingEventArgs

Description: The event arguments used by the ViewExporting event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    ElementId ViewId { get; }
      Description: Identifies the view about to be exported.

--------------------------------------------------------------------------------

[CLASS] ViewPrintedEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewPrintedEventArgs

Description: The event arguments used by the ViewPrinted event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  PROPERTIES:
    int Index { get; }
      Description: The index of the view being printed out of the set of all views being printed.
    int TotalViews { get; }
      Description: The number of all views being printed.
    View View { get; }
      Description: The view that was printed.

--------------------------------------------------------------------------------

[CLASS] ViewPrintingEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewPrintingEventArgs

Description: The event arguments used by the ViewPrinting event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  PROPERTIES:
    int Index { get; }
      Description: The index of the view being printed out of the set of all views being printed.
    int TotalViews { get; }
      Description: The number of all views being printed.
    View View { get; }
      Description: The view to be printed.

  METHODS:
    IPrintSetting GetSettings()
      Description: Get the print settings of the active printing session.

--------------------------------------------------------------------------------

[CLASS] ViewsExportedByContextEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewsExportedByContextEventArgs

Description: The event arguments used by the ViewsExportedByContext event.
Inherits: RevitAPIPostDocEventArgs
Implements: IDisposable

  METHODS:
    IList<ElementId> GetViewIds()
      Description: Gets the views that were exported by CustomExporter.
      Returns: The views that were exported by CustomExporter.

--------------------------------------------------------------------------------

[CLASS] ViewsExportingByContextEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewsExportingByContextEventArgs

Description: The event arguments used by the ViewsExportingByContext event.
Inherits: RevitAPIPreDocEventArgs
Implements: IDisposable

  METHODS:
    IList<ElementId> GetViewIds()
      Description: Gets the views about to be exported by CustomExporter.
      Returns: The views about to be exported by CustomExporter.

--------------------------------------------------------------------------------

[CLASS] WorksharedOperationProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs

Description: The event arguments used by the WorksharedOperationProgressChanged event, this event will be raised when executing following workshared operations.
Remarks: For synchronizing with central operation, there are 4 steps. 1) Save to local (before save to central) - Serializes the streams from memory to local disk cache; 2) Reload latest - Downloads the streams from central model on server and merge them into local memory; 3) Save to central - Uploads merged streams from local memory to server central model; 4) Save to local (after save to central) - Serializes the merged streams from memory to local disk cache; For document open operation, just download the model from server and then open it; It is NOT recommended to deal with time-consuming work when handling WorksharedOperationProgressChanged event, otherwise it would increase synchronizing with central or model open time.
Inherits: RevitAPISingleEventArgs
Implements: IDisposable

  PROPERTIES:
    string Location { get; }
      Description: Full path of the central model which is to be operated.
    RevitAPIEventStatus Status { get; }
      Description: Gets API event status, reflect current operation execution status.

--------------------------------------------------------------------------------


