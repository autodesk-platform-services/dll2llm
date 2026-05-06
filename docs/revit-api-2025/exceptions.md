# Autodesk.Revit.Exceptions


NAMESPACE: Autodesk.Revit.Exceptions
--------------------------------------------------------------------------------

[CLASS] AccessDeniedException
Full Name: Autodesk.Revit.Exceptions.AccessDeniedException
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ApplicationException
Full Name: Autodesk.Revit.Exceptions.ApplicationException

Description: The exception that is thrown when a non-fatal application error occurs.
Remarks: This class is the base class of all Revit specified exceptions.
Inherits: Exception
Implements: ISerializable

  PROPERTIES:
    FunctionId FunctionId { get; }
      Description: The information of the function throwing the exception.

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ArgumentException
Full Name: Autodesk.Revit.Exceptions.ArgumentException

Description: The exception that is thrown when one of the arguments provided to a method is not valid.
Remarks: This is the base class for exceptions that are thrown while validating the arguments to a function.
Inherits: ApplicationException
Implements: ISerializable

  PROPERTIES:
    string Message { get; }
      Description: Gets the error message and the parameter name, or only the error message if no parameter name is set.
    string ParamName { get; }
      Description: Gets the name of the parameter that causes this exception.

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ArgumentNullException
Full Name: Autodesk.Revit.Exceptions.ArgumentNullException

Description: The exception that is thrown when is passed to a method that does not accept it as a valid argument.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ArgumentOutOfRangeException
Full Name: Autodesk.Revit.Exceptions.ArgumentOutOfRangeException

Description: The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ArgumentsInconsistentException
Full Name: Autodesk.Revit.Exceptions.ArgumentsInconsistentException

Description: The exception that is thrown when each individual argument is OK, but a joint constraint is violated.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] AutoJoinFailedException
Full Name: Autodesk.Revit.Exceptions.AutoJoinFailedException

Description: The exception that is thrown when an autojoin operation failed.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] BackgroundTaskCancelledException
Full Name: Autodesk.Revit.Exceptions.BackgroundTaskCancelledException

Description: The exception thrown when Revit cancels a background operation. Third-party developers are not expected to catch and handle this exception. Instead, if allowed to propagate back to Revit code, it will be handled by Revit.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CannotOpenBothCentralAndLocalException
Full Name: Autodesk.Revit.Exceptions.CannotOpenBothCentralAndLocalException

Description: The exception thrown when both a central model and also a local file for the same central model are opened in the same session.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CentralFileCommunicationException
Full Name: Autodesk.Revit.Exceptions.CentralFileCommunicationException

Description: The exception thrown when there is a network communication error involving a file-based central model.
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CentralModelAccessDeniedException
Full Name: Autodesk.Revit.Exceptions.CentralModelAccessDeniedException

Description: The exceptions thrown when a central model can be reached but access is denied due to a lack of access privileges.
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CentralModelAlreadyExistsException
Full Name: Autodesk.Revit.Exceptions.CentralModelAlreadyExistsException

Description: Exception is thrown when the central model already exists at the specified location.
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CentralModelContentionException
Full Name: Autodesk.Revit.Exceptions.CentralModelContentionException

Description: The exception thrown when a central model is busy (locked) and the operation is canceled.
Inherits: CentralModelException
Implements: ISerializable

  PROPERTIES:
    string CurrentUser { get; }
      Description: Retrieves current user name.

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CentralModelException
Full Name: Autodesk.Revit.Exceptions.CentralModelException

Description: The base class for exceptions that are common to both file-based and server-based central models or specific to just file-based central models.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CentralModelVersionArchivedException
Full Name: Autodesk.Revit.Exceptions.CentralModelVersionArchivedException

Description: Exception is thrown when last central version merged into the local model has been archived in the central model. Reload Latest or Synchronized with Central needs to be conducted before the current failed operation is retried.
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CheckoutElementsRequestTooLargeException
Full Name: Autodesk.Revit.Exceptions.CheckoutElementsRequestTooLargeException

Description: Exception is thrown when too many elements are requested for checkout
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] CorruptModelException
Full Name: Autodesk.Revit.Exceptions.CorruptModelException

Description: The exception that is thrown when the model is or seems corrupt.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] DefaultValueException
Full Name: Autodesk.Revit.Exceptions.DefaultValueException

Description: The exception thrown when Revit cannot initialize a default value for a family parameter.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] DirectoryNotEmptyException
Full Name: Autodesk.Revit.Exceptions.DirectoryNotEmptyException

Description: The exception that is thrown when a method received a directory as an argument and requires that the directory be empty but the directory is not empty.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] DirectoryNotFoundException
Full Name: Autodesk.Revit.Exceptions.DirectoryNotFoundException

Description: The exception that is thrown when the specified directory could not be found.
Inherits: IOException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] DisabledDisciplineException
Full Name: Autodesk.Revit.Exceptions.DisabledDisciplineException

Description: The exception that is thrown when the function cannot execute because a discipline is disabled. The exception specifies which discipline(s) would let the operation succeed.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ExternalApplicationException
Full Name: Autodesk.Revit.Exceptions.ExternalApplicationException

Description: The exception that is thrown when an issue in the Add-Ins resulted in an unexpected error.
Remarks: Please contact your external application provider with the information about what led to this exception.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] FamilyContextException
Full Name: Autodesk.Revit.Exceptions.FamilyContextException

Description: The exception that is thrown when an operation is invalid in the current family document, because of the type of family.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] FileAccessException
Full Name: Autodesk.Revit.Exceptions.FileAccessException

Description: The exception that is thrown when the specified file could not be accessed, e.g. read-only, locked by the OS etc.
Inherits: IOException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] FileArgumentAlreadyExistsException
Full Name: Autodesk.Revit.Exceptions.FileArgumentAlreadyExistsException

Description: The exception that is thrown when the specified file exists.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] FileArgumentNotFoundException
Full Name: Autodesk.Revit.Exceptions.FileArgumentNotFoundException

Description: The exception that is thrown when a method received a filename as an argument and requires it to exist as a precondition.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] FileNotFoundException
Full Name: Autodesk.Revit.Exceptions.FileNotFoundException

Description: The exception that is thrown when the specified file could not be found.
Inherits: IOException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ForbiddenForDynamicUpdateException
Full Name: Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException

Description: The exception that is thrown when making or attempting to make changes that are forbidden during dynamic updates to the model.
Remarks: Modifications leading to a new mutual relationship between elements that did not depend on each other before are potentially not safe in work-set environment. This exception is thrown when an Updater either makes such modifications or attempts to call a method that will or may modify the model in such unsafe matter.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] FunctionId
Full Name: Autodesk.Revit.Exceptions.FunctionId

Description: The information of a function throwing an exception.
Implements: ISerializable

  PROPERTIES:
    string File { get; }
      Description: The name of the file including the function throwing an exception.
    string Function { get; }
      Description: The name of the function throwing an exception.
    int Line { get; }
      Description: The line number of the function throwing an exception.

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InapplicableDataException
Full Name: Autodesk.Revit.Exceptions.InapplicableDataException

Description: The exception that is thrown when attempting to access a piece of data that is structurally not part of an object at the moment.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InsufficientResourcesException
Full Name: Autodesk.Revit.Exceptions.InsufficientResourcesException

Description: The exception that is thrown when the OS runs out of resources, e.g. memory, disk space, or USER or GDI objects.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InternalException
Full Name: Autodesk.Revit.Exceptions.InternalException

Description: The exception that is thrown when an issue in the Revit code resulted in an unexpected error.
Remarks: Please contact Autodesk Developer Support with the information about what led to this exception.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InvalidDataStreamException
Full Name: Autodesk.Revit.Exceptions.InvalidDataStreamException

Description: The exception that is thrown when the reading or saving operation failed due to parsing error.
Inherits: IOException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InvalidObjectException
Full Name: Autodesk.Revit.Exceptions.InvalidObjectException

Description: The exception that is thrown when referencing an object that is no longer valid.
Remarks: The object may no longer exist for many reasons: The object was explicitly deleted from the database. A change to other database items caused the item to be automatically deleted from the database. The object no longer exists as its creation was undone (by rolling a transaction back).
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InvalidOperationException
Full Name: Autodesk.Revit.Exceptions.InvalidOperationException

Description: The exception that is thrown when a method call is invalid for the object's current state.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] InvalidPathArgumentException
Full Name: Autodesk.Revit.Exceptions.InvalidPathArgumentException

Description: The exception that is thrown when a method received a pathname as an argument, but the pathname is illegal: too long, invalid characters, etc.
Inherits: ArgumentException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] IOException
Full Name: Autodesk.Revit.Exceptions.IOException

Description: The exception that is thrown when an I/O error occurs.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ModificationForbiddenException
Full Name: Autodesk.Revit.Exceptions.ModificationForbiddenException

Description: The exception that is thrown by the undo transaction framework when a modification operation is not allowed.
Remarks: See also: and .
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ModificationOutsideTransactionException
Full Name: Autodesk.Revit.Exceptions.ModificationOutsideTransactionException

Description: The exception that is thrown by the undo transaction framework when the modification operation to the model is outside of a transaction.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] NetworkCommunicationException
Full Name: Autodesk.Revit.Exceptions.NetworkCommunicationException
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] NotTransmittedModelException
Full Name: Autodesk.Revit.Exceptions.NotTransmittedModelException

Description: The exception thrown when OpenOptions were provided to deal with a transmitted model, but the model is not transmitted.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ObjectAccessException
Full Name: Autodesk.Revit.Exceptions.ObjectAccessException

Description: The exception that is thrown when an operation is denied, e.g. an attempt was made to set a read-only property.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] OperationCanceledException
Full Name: Autodesk.Revit.Exceptions.OperationCanceledException

Description: The exception that is thrown when an operation is unexpectedly cancelled.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] OptionalFunctionalityNotAvailableException
Full Name: Autodesk.Revit.Exceptions.OptionalFunctionalityNotAvailableException

Description: The exception that is thrown when the optional functionality is not available in the installed Revit
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] OutdatedDirectlyOpenedCentralException
Full Name: Autodesk.Revit.Exceptions.OutdatedDirectlyOpenedCentralException

Description: The exception thrown when a central model is opened directly and its copy in the session is outdated. If the operation is supported for local files, first resave as local, and try again.
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RegenerationFailedException
Full Name: Autodesk.Revit.Exceptions.RegenerationFailedException

Description: The exception that is thrown when a regeneration operation failed.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ResourceNotFoundException
Full Name: Autodesk.Revit.Exceptions.ResourceNotFoundException
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerCollaborationNotAvailableException
Full Name: Autodesk.Revit.Exceptions.RevitServerCollaborationNotAvailableException

Description: The exception that is thrown when Collaboration fails because of an external resource (e.g., Amazon S3) failure.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerCommunicationException
Full Name: Autodesk.Revit.Exceptions.RevitServerCommunicationException

Description: The exception that is thrown when there is any network communication error happening.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerException
Full Name: Autodesk.Revit.Exceptions.RevitServerException

Description: The exception that is base class for all exceptions originating from the Revit server.
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerInternalException
Full Name: Autodesk.Revit.Exceptions.RevitServerInternalException

Description: The exception that is thrown when there is any server internal error happening.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerModelAlreadyExistsException
Full Name: Autodesk.Revit.Exceptions.RevitServerModelAlreadyExistsException

Description: The exception that is thrown when there is a model with the same name already exist.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerModelNameBreaksConventionException
Full Name: Autodesk.Revit.Exceptions.RevitServerModelNameBreaksConventionException

Description: The exception that is thrown when the model is breaking the project naming convention.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerUnauthenticatedUserException
Full Name: Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException

Description: The exception that is thrown when an unauthenticated user attempts to initiate a call to RevitServer.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] RevitServerUnauthorizedException
Full Name: Autodesk.Revit.Exceptions.RevitServerUnauthorizedException

Description: The exception that is thrown when a call to the server is unauthorized.
Inherits: RevitServerException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] SchemaException
Full Name: Autodesk.Revit.Exceptions.SchemaException

Description: The exception thrown when Revit cannot interpret a data structure described by a schema.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ServerInternalException
Full Name: Autodesk.Revit.Exceptions.ServerInternalException
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ServerModelCorruptedException
Full Name: Autodesk.Revit.Exceptions.ServerModelCorruptedException

Description: The exception thrown when the model is corrupted.
Inherits: CentralModelException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] TransientElementCreationException
Full Name: Autodesk.Revit.Exceptions.TransientElementCreationException

Description: The exception that is thrown when TransientElementCreationScope is used incorrectly.
Remarks: The exception would be thrown in the following cases: An element that does not support TransientElementCreationScope is being created in the Scope. A TransientElementCreationScope is being created while another such scope is already active.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] TransmittedModelException
Full Name: Autodesk.Revit.Exceptions.TransmittedModelException

Description: The exception thrown when model was transmitted (sent by eTransmit) and insufficient OpenOptions were provided to handle its transmitted flag.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] UnauthenticatedException
Full Name: Autodesk.Revit.Exceptions.UnauthenticatedException
Inherits: ApplicationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] WrongUserException
Full Name: Autodesk.Revit.Exceptions.WrongUserException

Description: The exception thrown when a local model is manipulated under a different username than it was created with.
Inherits: InvalidOperationException
Implements: ISerializable

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------


