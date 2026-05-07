# Autodesk.Revit.DB.ExtensibleStorage

NAMESPACE: Autodesk.Revit.DB.ExtensibleStorage
--------------------------------------------------------------------------------

[ENUM] AccessLevel
Full Name: Autodesk.Revit.DB.ExtensibleStorage.AccessLevel
Description: Defines access levels to objects in the Extensible Storage framework.
Inherits: Enum

  Values:
    - Public = 1
    - Vendor = 2
    - Application = 3

--------------------------------------------------------------------------------

[ENUM] ContainerType
Full Name: Autodesk.Revit.DB.ExtensibleStorage.ContainerType
Description: An enumerated type indicating if the field represents a single value or a container of multiple values.
Inherits: Enum

  Values:
    - Simple = 0
    - Array = 1
    - Map = 2

--------------------------------------------------------------------------------

[CLASS] DataStorage
Full Name: Autodesk.Revit.DB.ExtensibleStorage.DataStorage
Description: An element which allows an API applications to organize and store data.
Remarks: Applications can create instances of these elements to logically organize different sets of ExtensibleStorage entities into separate elements. This allows an application to update one set of data in a local workshared project without locking other elements.
Inherits: Element

  METHODS:
    static DataStorage Create(Document doc)
      Description: Creates a new DataStorage element and adds it to the document.
      @doc: Document to which the new element should be added.
      Returns: The newly created DataStorage element.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Entity
Full Name: Autodesk.Revit.DB.ExtensibleStorage.Entity
Description: An object stored in the Extensible Storage framework. An Entity is described by a Schema, which serves both to identify an Entity, and to describe its contents (Fields).
Remarks: An Entity is similar to an object in most object-oriented languages, while a Schema is the class of that object. The Get and Set methods are central - they provide access to the fields of the Entity. Note that an unitialized Entity retrieved from an Element or another Entity (if it has not been created yet) will be represented as an invalid entity, not . If an Element containing an Entity is split (e.g., a wall split), the Entity and its data will exist in both new Elements. If an Element containing an Entity is copied, the Element copy will also contain a copy of the Entity and its data. If an Entity stores an ElementId, and the Element with that ElementId is deleted, the stored ElementId will automatically be set to ElementId.InvalidElementId (-1).
Implements: IDisposable

  CONSTRUCTORS:
    new Entity(Guid schemaGUID)
      Description: Creates a new Entity corresponding to the Schema of the specified GUID.
      Throws ArgumentException: The GUID does not correspond to any Schema in memory.
      Throws InvalidOperationException: Writing of Entities of this Schema is not allowed to the current add-in.
    new Entity(Schema schema)
      Description: Creates a new Entity corresponding to the Schema.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Writing of Entities of this Schema is not allowed to the current add-in.
    new Entity()
      Description: The default-constructed Entity is invalid.
    new Entity(Entity other)
      Description: Constructs a new copy of the input ESEntity object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Schema Schema { get; }
      Description: The Schema describing this Entity.
    Guid SchemaGUID { get; }
      Description: The GUID of the Schema describing this Entity.

  METHODS:
    void Clear(string fieldName)
      Description: Resets the field to its default value.
      @fieldName: The name of the field to clear.
      Throws ArgumentException: The name matches no field in this Entity's Schema. -or- This field's subschema prevents writing.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This Entity is invalid.
    void Clear(Field field)
      Description: Resets the field to its default value.
      @field: The field to clear.
      Throws ArgumentException: The Field belongs to a different Schema from this Entity, or this Entity is invalid. -or- This field's subschema prevents writing.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    FieldType Get<FieldType>(string fieldName, ForgeTypeId unitTypeId)
      Description: Retrieves the value of the field in the entity.
      @fieldName: The name of the field to retrieve.
      @unitTypeId: Identifier of the unit to which the value will be converted before returning. Must be compatible with the spec specified when creating the Schema.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: The name matches no field in this Entity's Schema.
      Throws ArgumentException: The unitTypeId value is not compatible with the field description.
      Throws ArgumentException: This field's subschema prevents reading.
    FieldType Get<FieldType>(Field field, ForgeTypeId unitTypeId)
      Description: Retrieves the value of the field in the entity.
      @field: The field to retrieve.
      @unitTypeId: Identifier of the unit to which the value will be converted before returning. Must be compatible with the spec specified when creating the Schema.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: The unitTypeId value is not compatible with the field description.
      Throws ArgumentException: This field's subschema prevents reading.
    FieldType Get<FieldType>(string fieldName)
      Description: Retrieves the value of the field in the entity.
      @fieldName: The name of the field to retrieve.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: The name matches no field in this Entity's Schema.
      Throws ArgumentException: For floating-point fields, use the overload taking a ForgeTypeId parameter.
      Throws ArgumentException: This field's subschema prevents reading.
    FieldType Get<FieldType>(Field field)
      Description: Retrieves the value of the field in the entity.
      @field: The field to retrieve.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: For floating-point fields, use the overload taking a ForgeTypeId parameter.
      Throws ArgumentException: This field's subschema prevents reading.
    bool IsValid()
      Description: Checks whether this Entity has a live Schema corresponding to it.
      Returns: True if the Entity is valid.
    bool ReadAccessGranted()
      Description: Checks whether this Entity may be retrieved by the current add-in.
      Returns: True if read access is allowed.
    bool RecognizedField(Field field)
      Description: Checks whether a Field belongs to the same Schema as this Entity.
      @field: The Field to check.
      Returns: True if the Field belongs to the same Schema as this Entity.
      Throws ArgumentNullException: A non-optional argument was null
    void Set<FieldType>(string fieldName, FieldType value, ForgeTypeId unitTypeId)
      Description: Stores the value of the field in the entity.
      @fieldName: The name of the field to update.
      @unitTypeId: Identifier of the unit from which the value will be converted before storing. Must be compatible with the spec specified when creating the Schema.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: The name matches no field in this Entity's Schema.
      Throws ArgumentException: The unitTypeId value is not compatible with the field description.
      Throws ArgumentException: This field's subschema prevents writing.
      Throws ArgumentException: Invalid floating-point value.
    void Set<FieldType>(Field field, FieldType value, ForgeTypeId unitTypeId)
      Description: Stores the value of the field in the entity.
      @field: The field to update.
      @unitTypeId: Identifier of the unit from which the value will be converted before storing. Must be compatible with the spec specified when creating the Schema.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: The unitTypeId value is not compatible with the field description.
      Throws ArgumentException: This field's subschema prevents writing.
      Throws ArgumentException: Invalid floating-point value.
    void Set<FieldType>(string fieldName, FieldType value)
      Description: Stores the value of the field in the entity.
      @fieldName: The name of the field to update.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: The name matches no field in this Entity's Schema.
      Throws ArgumentException: For floating-point fields, use the overload taking a ForgeTypeId parameter.
      Throws ArgumentException: This field's subschema prevents writing.
      Throws ArgumentException: Invalid floating-point value.
      Throws ArgumentException: String is too long; exceeds max length of 16mb characters.
    void Set<FieldType>(Field field, FieldType value)
      Description: Stores the value of the field in the entity.
      @field: The field to update.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: The Field belongs to a different Schema from this Entity, or this Entity is invalid.
      Throws ArgumentException: Requested type does not match the field type.
      Throws ArgumentException: For floating-point fields, use the overload taking a ForgeTypeId parameter.
      Throws ArgumentException: This field's subschema prevents writing.
      Throws ArgumentException: Invalid floating-point value.
      Throws ArgumentException: String is too long; exceeds max length of 16mb characters.
    bool WriteAccessGranted()
      Description: Checks whether this Entity may be stored by the current add-in.
      Returns: True if write access is allowed.

--------------------------------------------------------------------------------

[CLASS] ExtensibleStorageFilter
Full Name: Autodesk.Revit.DB.ExtensibleStorage.ExtensibleStorageFilter
Description: A filter used to filter elements with extensible storage data based on specific Schema id.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter

  CONSTRUCTORS:
    new ExtensibleStorageFilter(Guid schemaGuid)
      Description: Constructs a new instance of a filter to match elements with extensible storage data based on specific Schema id.
      @schemaGuid: Schema id used to filter elements with extensible storage data

  PROPERTIES:
    Guid SchemaGuid { get; }
      Description: Schema id used to filter elements with extensible storage data

--------------------------------------------------------------------------------

[CLASS] Field
Full Name: Autodesk.Revit.DB.ExtensibleStorage.Field
Description: The description of a field within a Schema in the Extensible Storage framework. Contains the field's name, type, access control and documentation.
Implements: IDisposable

  PROPERTIES:
    ContainerType ContainerType { get; }
      Description: Reports whether this is a simple field containing one value, or a container of multiple values.
    string Documentation { get; }
      Description: The overall description of the Field.
    string FieldName { get; }
      Description: The name of the field.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Type KeyType { get; }
      Description: The type of the keys stored in the field.
    Schema Schema { get; }
      Description: The Schema to which this Field belongs.
    Schema SubSchema { get; }
      Description: The Schema describing the subentity (or subentities) stored in this Field.
    Guid SubSchemaGUID { get; }
      Description: The GUID of the Schema describing the subentity (or subentities) stored in this Field.
    Type ValueType { get; }
      Description: The type of the values stored in the field.

  METHODS:
    bool CompatibleUnit(ForgeTypeId unitTypeId)
      Description: Checks if the specified unit is compatible with the field description.
      @unitTypeId: The unit to check.
      Returns: True if the unit is compatible, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    ForgeTypeId GetSpecTypeId()
      Description: Gets the spec describing the values stored in this field.
      Returns: Identifier of the spec.
    bool SubEntityReadAccessGranted()
      Description: Checks whether there is read access to subentities storable in this field.
      Returns: True if subentities are readable.
    bool SubEntityWriteAccessGranted()
      Description: Checks whether there is write access to subentities storable in this field.
      Returns: True if subentities are writable.

--------------------------------------------------------------------------------

[CLASS] FieldBuilder
Full Name: Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder
Description: This class is used to create Fields in the Extensible Storage framework.
Implements: IDisposable

  CONSTRUCTORS:
    new FieldBuilder(Field field, SchemaBuilder builder)
      Description: Constructs a new FieldBuilder using the field and associated SchemaBuilder object.
      Throws ArgumentNullException: A non-optional argument was null
    new FieldBuilder(FieldBuilder other)
      Description: Constructs a new copy of the input ESFieldBuilder object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool NeedsSubSchemaGUID()
      Description: Checks whether the SubSchema GUID needs to be explicitly specified for this field type.
      Returns: True if SubSchemaGUID is required.
    bool NeedsUnits()
      Description: Checks whether the field type requires explicit unit conversions.
      Returns: True if units are required.
    bool Ready()
      Description: Checks whether the builder may be used.
      Returns: True if the SchemaBuilder has not yet been finished.
    FieldBuilder SetDocumentation(string documentation)
      Description: Sets the documentation string for the Field.
      @documentation: The documentation string.
      Returns: The FieldBuilder object may be used to add more details to the field.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    FieldBuilder SetSpec(ForgeTypeId specTypeId)
      Description: Sets the spec describing the field's values.
      @specTypeId: Identifier of the spec.
      Returns: The FieldBuilder object may be used to add more details to the field.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema. -or- The field type does not utilize unit conversions.
    FieldBuilder SetSubSchemaGUID(Guid guid)
      Description: Sets the GUID of the Schema of the Entities that are intended to be stored in this field.
      @guid: The GUID of the subschema.
      Returns: The FieldBuilder object may be used to add more details to the field.
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema. -or- The field type does not utilize SubSchemas.

--------------------------------------------------------------------------------

[CLASS] Schema
Full Name: Autodesk.Revit.DB.ExtensibleStorage.Schema
Description: The description of a single object (Entity) in the Extensible Storage framework. Contains identity information, documentation and the list of fields to be stored in the Entity.
Remarks: A Schema is similar to a class in most object-oriented languages, or to a C struct, while an Entity is an object of that class. The Schema object is immutable. To create and populate a Schema, use the SchemaBuilder class. Schemas are stored in the memory of the running instance of Revit and may be retrieved with the Lookup method. When a document containing Entities of a Schema is saved, the Schema is saved with the document too. Opening that document reintroduces the Schema into memory. As you plan to store your data in Revit, please be aware that the data will be stored in Revit elements. Overwhelming the Revit database will impact performance and stability, and will make the user unhappy. Also, remember that multiple add-ins may be storing their data simultaneously. Several kB per element or several MB per file are reasonable maximums for one add-in. If you have larger requirements, consider storing them in a separate database (such as SQLite) and storing keys into that database in Revit.
Implements: IDisposable

  PROPERTIES:
    Guid ApplicationGUID { get; }
      Description: The GUID of the application or add-in that may access entities of this Schema under the Application access level.
    string Documentation { get; }
      Description: The overall description of the Schema.
    Guid GUID { get; }
      Description: The identifier of the Schema. Setter made unavailable, because it would violate set-correctness
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    AccessLevel ReadAccessLevel { get; }
      Description: Read access level of the schema.
    string SchemaName { get; }
      Description: The user-friendly name of the Schema.
    string VendorId { get; }
      Description: The id of the third-party vendor that may access entities of this Schema under the Vendor access level.
    AccessLevel WriteAccessLevel { get; }
      Description: Write access level of the schema.

  METHODS:
    void Dispose()
    Field GetField(string name)
      Description: Gets a Field of a given name from the Schema.
      @name: The Field name
      Returns: The Field
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Reading of Entities of this Schema is not allowed to the current add-in.
    IList<Field> ListFields()
      Description: The complete list of fields in the Schema, sorted by name.
      Throws InvalidOperationException: Reading of Entities of this Schema is not allowed to the current add-in.
    static IList<Schema> ListSchemas()
      Description: Lists all schemas in memory.
    static Schema Lookup(Guid guid)
      Description: Finds the Schema corresponding to the GUID in memory.
    bool ReadAccessGranted()
      Description: Checks whether Entities of this Schema may be retrieved by the current add-in.
      Returns: True if read access is allowed.
    bool WriteAccessGranted()
      Description: Checks whether Entities of this Schema may be stored by the current add-in.
      Returns: True if write access is allowed.

--------------------------------------------------------------------------------

[CLASS] SchemaBuilder
Full Name: Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder
Description: This class is used to create Schemas in the Extensible Storage framework.
Remarks: Named parameter idiom: Methods that set up the Schema return a reference to the builder so you can invoke multiple methods in a chain (e.g., builder.setReadAccessLevel(...).setWriteAccessLevel(...)). Methods that add fields return a FieldBuilder instead.
Implements: IDisposable

  CONSTRUCTORS:
    new SchemaBuilder(Guid guid)
      Description: Constructs a new SchemaBuilder where the resulting Schema will use the input GUID.
      Throws ArgumentException: The guid value is invalid.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool AcceptableName(string name)
      Description: Checks whether a string is an acceptable name for a Schema or a Field.
      @name: The string to check.
      Returns: True if the name is acceptable.
      Throws ArgumentNullException: A non-optional argument was null
    FieldBuilder AddArrayField(string fieldName, Type fieldType)
      Description: Creates a field containing an array of values in the Schema, with given name and type of contained values.
      @fieldName: The name of the new field.
      @fieldType: The type of the contents in the new field.
      Returns: The FieldBuilder object may be used to add more details to the field. Make sure to set the unit type if the field contains floating-point values.
      Throws ArgumentException: The parameter fieldName is not acceptable for naming Extensible Storage objects. -or- The field type is not supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    FieldBuilder AddMapField(string fieldName, Type keyType, Type valueType)
      Description: Creates a field containing an ordered key-value map in the Schema, with given name and type of contained values.
      @fieldName: The name of the new field.
      @keyType: The type of the keys for the new field.
      @valueType: The type of the values for the new field.
      Returns: The FieldBuilder object may be used to add more details to the field. Make sure to set the unit type if the field contains floating-point values.
      Throws ArgumentException: The parameter fieldName is not acceptable for naming Extensible Storage objects. -or- The field type is not supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The combination of key and value types is not supported.
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    FieldBuilder AddSimpleField(string fieldName, Type fieldType)
      Description: Creates a field containing a single value in the Schema, with given name and type.
      @fieldName: The name of the new field.
      @fieldType: The type of the new field.
      Returns: The FieldBuilder object may be used to add more details to the field. Make sure to set the unit type if the field contains floating-point values.
      Throws ArgumentException: The parameter fieldName is not acceptable for naming Extensible Storage objects. -or- The field type is not supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    void Dispose()
    Schema Finish()
      Description: Registers and returns the created Schema object.
      Returns: The newly created Schema.
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema. -or- A different Schema with a matching identity already exists. -or- Two fields with the same name are detected. -or- At least one field has invalid units. -or- SchemaName is not set. -or- VendorId is not set for a restricted access level. -or- ApplicationGUID is not set for an application access level. -or- More than 256 fields were added to the schema.
    static bool GUIDIsValid(Guid guid)
      Description: Checks whether the supplied GUID value is valid.
      @guid: The GUID to check
      Returns: True if the GUID is valid
    bool Ready()
      Description: Checks whether the builder may be used.
      Returns: True if the SchemaBuilder has not yet been finished.
    SchemaBuilder SetApplicationGUID(Guid applicationGUID)
      Description: Sets the GUID of the application or add-in that may access entities of this Schema under the Application acess level.
      @applicationGUID: The application id.
      Returns: The SchemaBuilder object may be used to add more settings.
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    SchemaBuilder SetDocumentation(string documentation)
      Description: Sets the documentation string for the Schema.
      @documentation: The documentation string.
      Returns: The SchemaBuilder object may be used to add more settings.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    SchemaBuilder SetReadAccessLevel(AccessLevel readAccessLevel)
      Description: Sets top level read access (for entities)
      @readAccessLevel: Read access level value to be set
      Returns: The SchemaBuilder object may be used to add more settings.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    SchemaBuilder SetSchemaName(string schemaName)
      Description: Sets the name of the Schema.
      @schemaName: The name for the Schema.
      Returns: The SchemaBuilder object may be used to add more settings.
      Throws ArgumentException: The parameter schemaName is not acceptable for naming Extensible Storage objects.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    SchemaBuilder SetVendorId(string vendorId)
      Description: Sets the ID of the third-party vendor that may access entities of this Schema under the Vendor acess level, and to generally identify the owner of this Schema.
      @vendorId: The vendor id.
      Returns: The SchemaBuilder object may be used to add more settings.
      Throws ArgumentException: The vendorId is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    SchemaBuilder SetWriteAccessLevel(AccessLevel writeAccessLevel)
      Description: Sets top level write access (for entities)
      @writeAccessLevel: Write access level value to be set
      Returns: The SchemaBuilder object may be used to add more settings.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The SchemaBuilder has already finished building the Schema.
    static bool VendorIdIsValid(string vendorId)
      Description: Checks whether the given vendor ID string is valid. A valid vendor ID string: 1. Has a length of at least 4 characters and no more than 253 characters, and 2. Contains only letters, digits, or any of the following special characters: ! " # & \ ( ) + , . - : ; < = > ? _ ` | ~
      @vendorId: The vendor ID to check.
      Returns: True if the vendor ID is valid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

