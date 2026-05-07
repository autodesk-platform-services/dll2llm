# Autodesk.Revit.Exceptions

NAMESPACE: Autodesk.Revit.Exceptions
--------------------------------------------------------------------------------

[CLASS] SchemaException
Full Name: Autodesk.Revit.Exceptions.SchemaException
Description: The exception thrown when Revit cannot interpret a data structure described by a schema.
Inherits: InvalidOperationException

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] ServerInternalException
Full Name: Autodesk.Revit.Exceptions.ServerInternalException
Inherits: ApplicationException

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

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] TransientElementCreationException
Full Name: Autodesk.Revit.Exceptions.TransientElementCreationException
Description: The exception that is thrown when TransientElementCreationScope is used incorrectly.
Remarks: The exception would be thrown in the following cases: An element that does not support TransientElementCreationScope is being created in the Scope.A TransientElementCreationScope is being created while another such scope is already active.
Inherits: InvalidOperationException

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

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

[CLASS] UnauthenticatedException
Full Name: Autodesk.Revit.Exceptions.UnauthenticatedException
Inherits: ApplicationException

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

  METHODS:
    void GetObjectData(SerializationInfo info, StreamingContext context)
      Description: Retrieves data needed to serialize the target object.
      @info: Data needed to serialize or deserialize the object.
      @context: The destination of the serialized stream.

--------------------------------------------------------------------------------

