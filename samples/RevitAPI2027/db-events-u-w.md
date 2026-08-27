# Autodesk.Revit.DB.Events

NAMESPACE: Autodesk.Revit.DB.Events
--------------------------------------------------------------------------------

[ENUM] UndoOperation
Full Name: Autodesk.Revit.DB.Events.UndoOperation
Description: The operation associated with DocumentChanged event
Inherits: Enum

  Values:
    - TransactionCommitted = 0
    - TransactionRolledBack = 1
    - TransactionGroupRolledBack = 2
    - TransactionUndone = 3
    - TransactionRedone = 4

--------------------------------------------------------------------------------

[CLASS] ViewExportedEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewExportedEventArgs
Description: The event arguments used by the ViewExported event.
Inherits: RevitAPIPostDocEventArgs

  PROPERTIES:
    ElementId ViewId { get; }
      Description: Identifies the view that was exported.

--------------------------------------------------------------------------------

[CLASS] ViewExportingEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewExportingEventArgs
Description: The event arguments used by the ViewExporting event.
Inherits: RevitAPIPreDocEventArgs

  PROPERTIES:
    ElementId ViewId { get; }
      Description: Identifies the view about to be exported.

--------------------------------------------------------------------------------

[CLASS] ViewPrintedEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewPrintedEventArgs
Description: The event arguments used by the ViewPrinted event.
Inherits: RevitAPIPostDocEventArgs

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

  METHODS:
    IList<ElementId> GetViewIds()
      Description: Gets the views that were exported by CustomExporter.
      Returns: The views that were exported by CustomExporter.

--------------------------------------------------------------------------------

[CLASS] ViewsExportingByContextEventArgs
Full Name: Autodesk.Revit.DB.Events.ViewsExportingByContextEventArgs
Description: The event arguments used by the ViewsExportingByContext event.
Inherits: RevitAPIPreDocEventArgs

  METHODS:
    IList<ElementId> GetViewIds()
      Description: Gets the views about to be exported by CustomExporter.
      Returns: The views about to be exported by CustomExporter.

--------------------------------------------------------------------------------

[CLASS] WorksharedOperationProgressChangedEventArgs
Full Name: Autodesk.Revit.DB.Events.WorksharedOperationProgressChangedEventArgs
Description: The event arguments used by the WorksharedOperationProgressChanged event, this event will be raised when executing following workshared operations.
Remarks: For synchronizing with central operation, there are 4 steps. 1) Save to local (before save to central) - Serializes the streams from memory to local disk cache; Autodesk::Revit::DB::Events::DocumentSaveToLocalProgressChangedEventArgs 2) Reload latest - Downloads the streams from central model on server and merge them into local memory; Autodesk::Revit::DB::Events::DocumentReloadLatestProgressChangedEventArgs 3) Save to central - Uploads merged streams from local memory to server central model; Autodesk::Revit::DB::Events::DocumentSaveToCentralProgressChangedEventArgs 4) Save to local (after save to central) - Serializes the merged streams from memory to local disk cache; Autodesk::Revit::DB::Events::DocumentSaveToLocalProgressChangedEventArgsFor document open operation, just download the model from server and then open it; Autodesk::Revit::DB::Events::CreateRelatedFileProgressChangedEventArgsIt is NOT recommended to deal with time-consuming work when handling WorksharedOperationProgressChanged event, otherwise it would increase synchronizing with central or model open time.
Inherits: RevitAPISingleEventArgs

  PROPERTIES:
    string Location { get; }
      Description: Full path of the central model which is to be operated.
    RevitAPIEventStatus Status { get; }
      Description: Gets API event status, reflect current operation execution status.

--------------------------------------------------------------------------------

