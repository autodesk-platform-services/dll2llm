# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[CLASS] SATExportOptions
Full Name: Autodesk.Revit.DB.SATExportOptions
Description: The export options used by exporting SAT format file. So far, there is no option in it.
Implements: IDisposable

  CONSTRUCTORS:
    new SATExportOptions(SATExportOptions option)
      Description: Constructs a new instance of SATImportOptions as a copy of the export options.
      @option: The options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new SATExportOptions()
      Description: Constructs a new instance of SATImportOptions with default values of all properties.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SATImportOptions
Full Name: Autodesk.Revit.DB.SATImportOptions
Description: The import options used to import SAT format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new SATImportOptions(SATImportOptions option)
      Description: Constructs a new instance of SATImportOptions as a copy of the import options.
      @option: The SAT options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new SATImportOptions()
      Description: Constructs a new instance of SATImportOptions with default values of all properties.

--------------------------------------------------------------------------------

[CLASS] SaveAsOptions
Full Name: Autodesk.Revit.DB.SaveAsOptions
Description: This class contains options available for saving a document to disk with a new filename.
Implements: IDisposable

  CONSTRUCTORS:
    new SaveAsOptions()
      Description: Default constructor.

  PROPERTIES:
    bool Compact { get; set; }
      Description: Default is false: let the OS eliminate as much or as little dead data as it wants to. True: force the OS to eliminate all dead data from the file on disk.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int MaximumBackups { get; set; }
      Description: The maximum number of backups to keep on disk.
    bool OverwriteExistingFile { get; set; }
      Description: Identifies if the operation should be able to overwrite an existing file.
    ElementId PreviewViewId { get; set; }
      Description: The view id that will be used to generate the preview; this id is not saved to the document's permanent settings.

  METHODS:
    void Dispose()
    WorksharingSaveAsOptions GetWorksharingOptions()
      Description: Gets Worksharing options for SaveAs.
      Returns: Defaults to . For a workshared model, if default values for WorksharingSaveAsOptions are used.
    void SetWorksharingOptions(WorksharingSaveAsOptions worksharingOptions)
      Description: Sets Worksharing options for SaveAs.
      @worksharingOptions: Must be for a non-workshared model.Allowed to be for a workshared model, in which case default values for WorksharingSaveAsOptions are used.

--------------------------------------------------------------------------------

[ENUM] SaveModifiedLinksOptions
Full Name: Autodesk.Revit.DB.SaveModifiedLinksOptions
Description: Class giving options when saving linked files which have been modified in-memory by shared coordinates operations.
Inherits: Enum

  Values:
    - SaveLinks = 0
    - DoNotSaveLinks = 1
    - DisableSharedPositioning = 2

--------------------------------------------------------------------------------

[ENUM] SaveModifiedLinksOptionsForUnloadLocally
Full Name: Autodesk.Revit.DB.SaveModifiedLinksOptionsForUnloadLocally
Description: Class giving options when saving linked files which are unloaded locally and have been modified in-memory by shared coordinates operations.
Inherits: Enum

  Values:
    - SaveLinks = 0
    - DoNotSaveLinks = 1

--------------------------------------------------------------------------------

[CLASS] SaveOptions
Full Name: Autodesk.Revit.DB.SaveOptions
Description: This class contains options available for saving a document to disk.
Implements: IDisposable

  CONSTRUCTORS:
    new SaveOptions()
      Description: Default constructor.

  PROPERTIES:
    bool Compact { get; set; }
      Description: Default is false: let the OS eliminate as much or as little dead data as it wants to. True: force the OS to eliminate all dead data from the file on disk.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId PreviewViewId { get; set; }
      Description: The view id that will be used to generate the preview; this id is not saved to the document's permanent settings.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SchedulableField
Full Name: Autodesk.Revit.DB.SchedulableField
Description: A non-calculated field eligible to be included in a schedule.
Remarks: The SchedulableField class represents a non-calculated field that is eligible to be included in a schedule. A list of fields that can be included in a schedule can be obtained from ScheduleDefinition.GetSchedulableFields.
Implements: IDisposable

  CONSTRUCTORS:
    new SchedulableField(Guid customFieldId)
      Description: Creates a new SchedulableField.
      @customFieldId: The Guid that identifies the custom field.
      Throws ArgumentException: The provided guid doens't represent a valid custom field.
    new SchedulableField(ScheduleFieldType fieldType, ElementId parameterId)
      Description: Creates a new SchedulableField.
      @fieldType: The type of data displayed by the field.
      @parameterId: The ID of the parameter displayed by the field.
      Throws ArgumentException: fieldType is not a schedulable field type -or- The fieldType can't be CustomField. To create a CustomField, you should use the constructor which receives the custom field server id as a parameter.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new SchedulableField(ScheduleFieldType fieldType)
      Description: Creates a new SchedulableField.
      @fieldType: The type of data displayed by the field.
      Throws ArgumentException: fieldType is not a schedulable field type -or- The fieldType can't be CustomField. To create a CustomField, you should use the constructor which receives the custom field server id as a parameter.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new SchedulableField()
      Description: Creates a new SchedulableField.

  PROPERTIES:
    ScheduleFieldType FieldType { get; set; }
      Description: The type of data displayed by the field.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId ParameterId { get; set; }
      Description: The ID of the parameter displayed by the field.

  METHODS:
    void Dispose()
    bool Equals(object obj)
      Description: Determines whether the specified Object is equal to the current Object.
      @obj: The other object to evaluate.
    CustomFieldData GetCustomFieldData()
      Description: Gets the data associated with this custom field. If this field isn't a CustomField will return .
      Returns: Returns the data associated with this custom field. If this field isn't a CustomField will return .
    int GetHashCode()
      Description: Gets the integer value of the SchedulableField as hash code
    string GetName(Document document)
      Description: Gets the name of the field.
      @document: The document in which the field will be used.
      Returns: The name of the field.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The parameter doesn't exist in document.

--------------------------------------------------------------------------------

[CLASS] ScheduleDefinition
Full Name: Autodesk.Revit.DB.ScheduleDefinition
Description: Settings that define the contents of a schedule.
Remarks: The ScheduleDefinition class contains various settings that define the contents of a schedule view, including: The schedule's category and other basic properties that determine the type of schedule.A set of fields that become the columns of the schedule.Filters that restrict the set of elements visible in the schedule.Sorting and grouping criteria.Most schedules contain a single ScheduleDefinition. In Revit MEP, schedules of certain categories can contain an "embedded schedule" containing elements associated with the elements in the primary schedule, for example a room schedule showing the elements inside each room or a duct system schedule showing the elements associated with each system. An embedded schedule has its own category, fields, filters, etc. Those settings are stored in a second ScheduleDefinition object.
Implements: IDisposable

  PROPERTIES:
    ElementId AreaSchemeId { get; }
      Description: In an area schedule, the ID of the area scheme to display.
    ElementId CategoryId { get; }
      Description: The category ID of elements appearing in the schedule.
    ScheduleDefinition EmbeddedDefinition { get; }
      Description: The embedded ScheduleDefinition.
    ElementId FamilyId { get; }
      Description: In a note block schedule, the ID of the Generic Annotation family displayed by the schedule.
    string GrandTotalTitle { get; set; }
      Description: The title name is used to display at the grand total row. The name is "Grand total", expressed in the Revit session language, by default.
    bool HasEmbeddedSchedule { get; }
      Description: Indicates if this ScheduleDefinition has an embedded ScheduleDefinition.
    bool IncludeLinkedFiles { get; set; }
      Description: Indicates if the schedule includes elements from linked files.
    bool IsEmbedded { get; }
      Description: Indicates if this is an embedded ScheduleDefinition.
    bool IsFilteredBySheet { get; set; }
      Description: Indicates if the schedule is set to filter by sheet.
    bool IsItemized { get; set; }
      Description: Indicates if the schedule displays each element on a separate row or combines multiple grouped elements onto the same row.
    bool IsKeySchedule { get; }
      Description: Indicates if the schedule is a key schedule.
    bool IsMaterialTakeoff { get; }
      Description: Indicates if the schedule is a material takeoff.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ShowGrandTotal { get; set; }
      Description: Indicates if a grand total row should be displayed at the bottom of the schedule.
    bool ShowGrandTotalCount { get; set; }
      Description: Indicates if the grand total row should display a count of elements in the schedule.
    bool ShowGrandTotalTitle { get; set; }
      Description: Indicates if the grand total row should display a title.
    bool ShowGridLines { get; set; }
      Description: Indicates if the schedule grid lines will be visible on a sheet.
    bool ShowHeaders { get; set; }
      Description: Indicates if the headers will be displayed in the schedule.
    bool ShowTitle { get; set; }
      Description: Indicates if the title will be displayed in the schedule.

  METHODS:
    void AddEmbeddedSchedule(ElementId categoryId)
      Description: Adds an embedded ScheduleDefinition.
      @categoryId: The category ID of elements to display in the embedded schedule.
      Throws ArgumentException: categoryId is not the ID of a category that can be used for an embedded ScheduleDefinition in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This ScheduleDefinition is not a kind of schedule that supports adding an embedded ScheduleDefinition. -or- This ScheduleDefinition already has an embedded ScheduleDefinition.
    ScheduleField AddField(ScheduleFieldType fieldType, ElementId parameterId)
      Description: Adds a regular field at the end of the list.
      @fieldType: The type of data displayed by the field.
      @parameterId: The ID of the parameter displayed by the field.
      Returns: The new field.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws ArgumentsInconsistentException: The field specified by fieldType and parameterId may not included in this ScheduleDefinition. -or- The field specified by fieldType and parameterId is already included in this ScheduleDefinition.
    ScheduleField AddField(ScheduleFieldType fieldType)
      Description: Adds a regular field at the end of the list.
      @fieldType: The type of data displayed by the field.
      Returns: The new field.
      Throws ArgumentException: The field specified by fieldType may not included in this ScheduleDefinition. -or- The field specified by fieldType is already included in this ScheduleDefinition. -or- The fieldType can't be CustomField. To add a CustomField, you should create a Schedulable field and add it.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    ScheduleField AddField(SchedulableField schedulableField)
      Description: Adds a regular field at the end of the list.
      @schedulableField: A SchedulableField object representing the field.
      Returns: The new field.
      Throws ArgumentException: The field specified by schedulableField may not included in this ScheduleDefinition. -or- The field specified by schedulableField is already included in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    void AddFilter(ScheduleFilter filter)
      Description: Adds a new filter at the end of the list.
      @filter: The filter to add.
      Throws ArgumentException: The field ID is not the ID of a field in this ScheduleDefinition. -or- The field and filter type cannot be used to filter this ScheduleDefinition. -or- The filter value is not valid for the field and filter type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This ScheduleDefinition does not support filters. -or- The resulting filter count would be greater than 8.
    void AddSortGroupField(ScheduleSortGroupField sortGroupField)
      Description: Adds a new sorting/grouping field at the end of the list.
      @sortGroupField: The sorting/grouping field to add.
      Throws ArgumentException: The field ID is not the ID of a field in this ScheduleDefinition. -or- The field cannot be used for sorting/grouping.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The resulting sorting/grouping field count would be greater than 4.
    bool CanFilter()
      Description: Checks whether filters can be added to this ScheduleDefinition.
      Returns: True if this ScheduleDefinition supports filters, false otherwise.
    bool CanFilterByGlobalParameters(ScheduleFieldId fieldId)
      Description: Checks whether a field can be used with a global parameter-based filter.
      @fieldId: The ID of the field to check.
      Returns: True if the field can be used with a global parameter-based filter, false otherwise.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanFilterByParameterExistence(ScheduleFieldId fieldId)
      Description: Checks whether a field can be used with a HasParameter filter.
      @fieldId: The ID of the field to check.
      Returns: True if the field can be used with a HasParameter filter, false otherwise.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanFilterBySubstring(ScheduleFieldId fieldId)
      Description: Checks whether a field can be used with a substring-based filter.
      @fieldId: The ID of the field to check.
      Returns: True if the field can be used with a substring-based filter, false otherwise.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanFilterByValue(ScheduleFieldId fieldId)
      Description: Checks whether a field can be used with a value-based filter.
      @fieldId: The ID of the field to check.
      Returns: True if the field can be used with a value based filter, false otherwise.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanFilterByValuePresence(ScheduleFieldId fieldId)
      Description: Checks whether a field can be used with a value presence-based filter.
      @fieldId: The ID of the field to check.
      Returns: True if the field can be used with a value presence filter, false otherwise.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanHaveEmbeddedSchedule()
      Description: Indicates if this ScheduleDefinition can have an embedded ScheduleDefinition added.
      Returns: True if this ScheduleDefinition can have an embedded ScheduleDefinition, false otherwise.
    bool CanIncludeLinkedFiles()
      Description: Checks whether the schedule is a type that supports including elements from linked files.
      Returns: True if elements from linked files can be included, false otherwise.
    bool CanSortByField(ScheduleFieldId fieldId)
      Description: Checks whether a field can be used for sorting/grouping.
      @fieldId: The ID of the field to check.
      Returns: True if the field can be used for sorting/grouping, false otherwise.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    void ClearFields()
      Description: Removes all fields.
    void ClearFilters()
      Description: Removes all filters.
      Throws InvalidOperationException: This ScheduleDefinition does not support filters.
    void ClearSortGroupFields()
      Description: Removes all sorting/grouping fields.
    void Dispose()
    ScheduleField GetField(ScheduleFieldId fieldId)
      Description: Gets a field.
      @fieldId: The ID of the field.
      Returns: The field.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    ScheduleField GetField(int index)
      Description: Gets a field.
      @index: The index of the field.
      Returns: The field.
      Throws ArgumentOutOfRangeException: index is not a valid field index in this ScheduleDefinition.
    int GetFieldCount()
      Description: Gets the number of fields in this ScheduleDefinition.
      Returns: The number of fields.
    ScheduleFieldId GetFieldId(int index)
      Description: Converts a field index to the corresponding field ID.
      @index: The field index.
      Returns: The field ID.
      Throws ArgumentOutOfRangeException: index is not a valid field index in this ScheduleDefinition.
    int GetFieldIndex(ScheduleFieldId fieldId)
      Description: Converts a field ID to the corresponding field index.
      @fieldId: The field ID.
      Returns: The field index.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ScheduleFieldId> GetFieldOrder()
      Description: Gets the IDs of the current list of fields in order.
      Returns: The IDs of the current list of fields.
    ScheduleFilter GetFilter(int index)
      Description: Gets a filter.
      @index: The index of the filter.
      Returns: A copy of the filter.
      Throws ArgumentOutOfRangeException: index is not a valid filter index.
    int GetFilterCount()
      Description: Gets the number of filters in this ScheduleDefinition.
      Returns: The number of filters.
    IList<ScheduleFilter> GetFilters()
      Description: Gets all filters in this ScheduleDefinition.
      Returns: A list of all filters.
    IList<SchedulableField> GetSchedulableFields()
      Description: Gets a list of all non-calculated/non-combined fields that are eligible to be included in this schedule.
      Returns: A list of SchedulableField objects representing the non-calculated/non-combined fields that may be included in the schedule.
    ScheduleSortGroupField GetSortGroupField(int index)
      Description: Gets a sorting/grouping field.
      @index: The index of the sorting/grouping field.
      Returns: A copy of the sorting/grouping field.
      Throws ArgumentOutOfRangeException: index is not a valid sorting/grouping field index.
    int GetSortGroupFieldCount()
      Description: Gets the number of sorting/grouping fields in this ScheduleDefinition.
      Returns: The number of sorting/grouping fields.
    IList<ScheduleSortGroupField> GetSortGroupFields()
      Description: Gets all sorting/grouping fields in this ScheduleDefinition.
      Returns: A list of all sorting/grouping fields.
    ICollection<ElementId> GetValidCategoriesForEmbeddedSchedule()
      Description: Get all categories that can be used for an embedded ScheduleDefinition in this ScheduleDefinition.
      Returns: The IDs of all valid categories.
    ScheduleField InsertCombinedParameterField(IList<TableCellCombinedParameterData> data, string fieldName, int index)
      Description: Adds a combined parameter field at the specified position in the list.
      @data: The combined parameters array.
      @fieldName: The field name.
      @index: The index in the list of fields.
      Returns: The new field.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid insert position.
    ScheduleField InsertField(ScheduleFieldType fieldType, ElementId parameterId, int index)
      Description: Adds a regular field at the specified position in the list.
      @fieldType: The type of data displayed by the field.
      @parameterId: The ID of the parameter displayed by the field.
      @index: The index in the list of fields.
      Returns: The new field.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid insert position. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws ArgumentsInconsistentException: The field specified by fieldType and parameterId may not included in this ScheduleDefinition. -or- The field specified by fieldType and parameterId is already included in this ScheduleDefinition.
    ScheduleField InsertField(ScheduleFieldType fieldType, int index)
      Description: Adds a regular field at the specified position in the list.
      @fieldType: The type of data displayed by the field.
      @index: The index in the list of fields.
      Returns: The new field.
      Throws ArgumentException: The field specified by fieldType may not included in this ScheduleDefinition. -or- The field specified by fieldType is already included in this ScheduleDefinition. -or- The fieldType can't be CustomField. To add a CustomField, you should create a Schedulable field and add it.
      Throws ArgumentOutOfRangeException: index is not a valid insert position. -or- A value passed for an enumeration argument is not a member of that enumeration
    ScheduleField InsertField(SchedulableField schedulableField, int index)
      Description: Adds a regular field at the specified position in the list.
      @schedulableField: A SchedulableField object representing the field.
      @index: The index in the list of fields.
      Returns: The new field.
      Throws ArgumentException: The field specified by schedulableField may not included in this ScheduleDefinition. -or- The field specified by schedulableField is already included in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid insert position.
    void InsertFilter(ScheduleFilter filter, int index)
      Description: Adds a new filter at the specified position in the list.
      @filter: The filter to add.
      @index: The index in the list of filters.
      Throws ArgumentException: The field ID is not the ID of a field in this ScheduleDefinition. -or- The field and filter type cannot be used to filter this ScheduleDefinition. -or- The filter value is not valid for the field and filter type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid insert position.
      Throws InvalidOperationException: This ScheduleDefinition does not support filters. -or- The resulting filter count would be greater than 8.
    void InsertSortGroupField(ScheduleSortGroupField sortGroupField, int index)
      Description: Adds a new sorting/grouping field at the specified position in the list.
      @sortGroupField: The sorting/grouping field to add.
      @index: The index in the list of sorting/grouping fields.
      Throws ArgumentException: The field ID is not the ID of a field in this ScheduleDefinition. -or- The field cannot be used for sorting/grouping.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid insert position.
      Throws InvalidOperationException: The resulting sorting/grouping field count would be greater than 4.
    bool IsSchedulableField(SchedulableField schedulableField)
      Description: Checks whether a non-calculated/non-combined field is eligible to be included in this schedule.
      @schedulableField: The field to check.
      Returns: True if the field may be included in the schedule, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidCategoryForEmbeddedSchedule(ElementId categoryId)
      Description: Indicates if a category can be used for an embedded ScheduleDefinition in this ScheduleDefinition.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for an embedded ScheduleDefinition, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidCategoryForFilterBySheet()
      Description: Checks whether a schedule can be filtered by sheet.
      Returns: True if the schedule can be filtered by sheet, false otherwise.
    bool IsValidCombinedParameters(IList<TableCellCombinedParameterData> data)
      Description: Checks if data is valid for combined parameters
      @data: data is array of TableCellCombinedParameterData to be set as combined parameters
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidFieldId(ScheduleFieldId fieldId)
      Description: Checks whether a ScheduleFieldId is the ID of a field in this ScheduleDefinition.
      @fieldId: The field ID to check.
      Returns: True if the field ID is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidFieldIndex(int index)
      Description: Checks whether an integer is a valid zero-based field index in this ScheduleDefinition.
      @index: The field index to check.
      Returns: True if the field index is valid, false otherwise.
    void RemoveEmbeddedSchedule()
      Description: Removes the embedded ScheduleDefinition.
      Throws InvalidOperationException: This ScheduleDefinition does not have an embedded ScheduleDefinition.
    void RemoveField(ScheduleFieldId fieldId)
      Description: Removes a field.
      @fieldId: The ID of the field to remove.
      Throws ArgumentException: fieldId is not the ID of a field in this ScheduleDefinition.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveField(int index)
      Description: Removes a field.
      @index: The index of the field to remove.
      Throws ArgumentOutOfRangeException: index is not a valid field index in this ScheduleDefinition.
    void RemoveFilter(int index)
      Description: Removes a filter.
      @index: The index of the filter to remove.
      Throws ArgumentOutOfRangeException: index is not a valid filter index.
      Throws InvalidOperationException: This ScheduleDefinition does not support filters.
    void RemoveSortGroupField(int index)
      Description: Removes a sorting/grouping field.
      @index: The index of the sorting/grouping field to remove.
      Throws ArgumentOutOfRangeException: index is not a valid sorting/grouping field index.
    void SetFieldOrder(IList<ScheduleFieldId> fieldIds)
      Description: Reorders the fields in the schedule.
      @fieldIds: The field IDs in a new order.
      Throws ArgumentException: fieldIds does not contain exactly the same field IDs as this ScheduleDefinition currently contains.
      Throws ArgumentNullException: A non-optional argument was null
    void SetFilter(int index, ScheduleFilter filter)
      Description: Replaces a filter.
      @index: The index of the filter to replace.
      @filter: The new filter.
      Throws ArgumentException: The field ID is not the ID of a field in this ScheduleDefinition. -or- The field and filter type cannot be used to filter this ScheduleDefinition. -or- The filter value is not valid for the field and filter type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid filter index.
      Throws InvalidOperationException: This ScheduleDefinition does not support filters.
    void SetFilters(IList<ScheduleFilter> filters)
      Description: Replaces all filters in this ScheduleDefinition.
      @filters: The new list of filters.
      Throws ArgumentException: The resulting filter count would be greater than 8. -or- A field ID is not the ID of a field in this ScheduleDefinition. -or- A field and filter type cannot be used to filter this ScheduleDefinition. -or- A filter value is not valid for the field and filter type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This ScheduleDefinition does not support filters.
    void SetSortGroupField(int index, ScheduleSortGroupField sortGroupField)
      Description: Replaces a sorting/grouping field.
      @index: The index of the sorting/grouping field to replace.
      @sortGroupField: The new sorting/grouping field.
      Throws ArgumentException: The field ID is not the ID of a field in this ScheduleDefinition. -or- The field cannot be used for sorting/grouping.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: index is not a valid sorting/grouping field index.
    void SetSortGroupFields(IList<ScheduleSortGroupField> sortGroupFields)
      Description: Replaces all sorting/grouping fields in this ScheduleDefinition.
      @sortGroupFields: The new list of sorting/grouping fields.
      Throws ArgumentException: The resulting sorting/grouping field count would be greater than 4. -or- A field ID is not the ID of a field in this ScheduleDefinition. -or- A field cannot be used for sorting/grouping.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ScheduleField
Full Name: Autodesk.Revit.DB.ScheduleField
Description: A field in a schedule.
Remarks: The ScheduleField class represents a single field in a ScheduleDefinition's list of fields. Each (non-hidden) field becomes a column in the schedule. Most commonly, a field represents an instance or type parameter of elements appearing in the schedule. Some fields represent parameters of other related elements, like the room that a scheduled element belongs to. Fields can also represent data calculated from other fields in the schedule, specifically Formula and Percentage fields. Another type of field is Custom Field. For this one, the value for each row is computed based on the (sub)elements that are grouped on that row and can have a graphic representation when the schedule is placed on a sheet.
Implements: IDisposable

  PROPERTIES:
    string ColumnHeading { get; set; }
      Description: The column heading text.
    ScheduleDefinition Definition { get; }
      Description: The ScheduleDefinition that this field belongs to.
    ScheduleFieldDisplayType DisplayType { get; set; }
      Description: Indicates the chosen display type for the field.
    ScheduleFieldId FieldId { get; }
      Description: The ID of the field in the containing ScheduleDefinition.
    int FieldIndex { get; }
      Description: The index of the field in the containing ScheduleDefinition.
    ScheduleFieldType FieldType { get; }
      Description: The type of data displayed by the field.
    double GridColumnWidth { get; set; }
      Description: The width of the column in the editable grid view, measured in feet.
    bool HasSchedulableField { get; }
      Description: Identifies if this ScheduleField object has access to a SchedulableField. Calculated and combined parameter fields will not have the access.
    ScheduleHeadingOrientation HeadingOrientation { get; set; }
      Description: The orientation of the column heading text.
    ScheduleHorizontalAlignment HorizontalAlignment { get; set; }
      Description: The horizontal alignment of the column's data.
    bool IsCalculatedField { get; }
      Description: Indicates if the field is a calculated field (Formula or Percentage).
    bool IsCombinedParameterField { get; }
      Description: Indicates if the field is a combined parameter field.
    bool IsHidden { get; set; }
      Description: Indicates if the field is hidden in the schedule.
    bool IsOverridden { get; }
      Description: Indicates if the field is overridden or not.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string MultipleValuesCustomText { get; set; }
      Description: The custom multiple values text to be used when the schedule field displays multiple element values, used when MultipleValuesDisplayType is set to Custom.
    ScheduleFieldMultipleValuesDisplayType MultipleValuesDisplayType { get; set; }
      Description: Determines the type of multiple value indication to be used when the schedule field displays multiple element values.
    string MultipleValuesText { get; }
      Description: The multiple values text to be used when the schedule field displays multiple element values, as specified by the display type MultipleValuesDisplayType.
    ElementId ParameterId { get; }
      Description: The ID of the parameter displayed by the field.
    ScheduleFieldId PercentageBy { get; set; }
      Description: The ID of the grouped schedule field used to calculate percentage totals.
    ScheduleFieldId PercentageOf { get; set; }
      Description: The ID of the field to calculate percentages of.
    ViewSchedule Schedule { get; }
      Description: The schedule that this field belongs to.
    double SheetColumnWidth { get; set; }
      Description: The width of the column on a sheet, measured in feet.
    bool TotalByAssemblyType { get; set; }
      Description: In an assembly schedule view, indicates if totals are calculated for all assembly instances of the same type or only for a single instance.
    ScheduleVerticalAlignment VerticalAlignment { get; set; }
      Description: The vertical alignment of the column's data.

  METHODS:
    bool CanDisplayMinMax()
      Description: Indicates if this field can display minimum and maximum values.
      Returns: True if this field can display minimum and maximum values, false otherwise.
    bool CanTotal()
      Description: Indicates if totals can be enabled for this field.
      Returns: True if this field can be totaled, false otherwise.
    bool CanTotalByAssemblyType()
      Description: Indicates if totals by assembly type can be enabled for this field.
      Returns: True if this field can be totaled by assembly type, false otherwise.
    bool CreatesCircularReferences(ScheduleFieldId fieldId)
      Description: Checks whether a field ID would create a circular chain of references when used by the PercentageOf property of this field.
      @fieldId: The field ID to check.
      Returns: True if the field ID would create a circular chain of references, false otherwise.
      Throws ArgumentException: fieldId is not InvalidScheduleFieldId or the ID of a field that can be used to calculated percentages.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    IList<TableCellCombinedParameterData> GetCombinedParameters()
      Description: Gets this field's combine parameter array if applicable
      Returns: Gets array of TableCellCombinedParameterData with the combined parameters data
    CustomFieldData GetCustomFieldData()
      Description: Gets the data associated with this custom field. If this field isn't a CustomField will return .
      Returns: Returns the data associated with this custom field. If this field isn't a CustomField will return .
    FormatOptions GetFormatOptions()
      Description: Gets the FormatOptions to optionally override the default settings in the Units class.
      Returns: A copy of the FormatOptions.
    string GetName()
      Description: Gets the name of the field.
      Returns: The name of the field.
    SchedulableField GetSchedulableField()
      Description: Gets a SchedulableField object representing this field.
      Returns: The SchedulableField object.
      Throws InapplicableDataException: This ScheduleField is not a schedulable field by type(non-calculated/non-combined-parameter).
    ForgeTypeId GetSpecTypeId()
      Description: The spec describing values of this field, if applicable.
      Returns: Identifier of the spec, or empty if the field does not represent a number with units.
    TableCellStyle GetStyle()
      Description: Gets the style of this field.
    bool IsValidCombinedParameters(IList<TableCellCombinedParameterData> data)
      Description: Checks if data is valid for combined parameters
      @data: data is array of TableCellCombinedParameterData to be set as combined parameters
      Throws ArgumentNullException: A non-optional argument was null
    void ResetOverride()
      Description: Resets the override of this field.
    void SetCombinedParameters(IList<TableCellCombinedParameterData> data)
      Description: Sets this field's combine parameter array if applicable
      @data: data is array of TableCellCombinedParameterData to be set as combined parameters
      Throws ArgumentNullException: A non-optional argument was null
    void SetFormatOptions(FormatOptions formatOptions)
      Description: Sets the FormatOptions to optionally override the default settings in the Units class.
      @formatOptions: The FormatOptions.
      Throws ArgumentException: The display unit in formatOptions is not a valid display unit for the unit type of this ScheduleField, or the rounding method in formatOptions is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.
      Throws ArgumentNullException: A non-optional argument was null
    void SetStyle(TableCellStyle style)
      Description: Sets the style of this field.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ScheduleFieldDisplayType
Full Name: Autodesk.Revit.DB.ScheduleFieldDisplayType
Description: Display type of schedule field.
Inherits: Enum

  Values:
    - Standard = 0
    - Totals = 1
    - MinMax = 2
    - Max = 3
    - Min = 4

--------------------------------------------------------------------------------

[CLASS] ScheduleFieldId
Full Name: Autodesk.Revit.DB.ScheduleFieldId
Description: The ScheduleFieldId object is used as a unique identification for a field in a schedule.

  CONSTRUCTORS:
    new ScheduleFieldId(int id)

  PROPERTIES:
    int IntegerValue { get; }
      Description: Provides the value of the ScheduleFieldId as an integer.
    static ScheduleFieldId InvalidScheduleFieldId { get; }
      Description: Get the invalid ScheduleFieldId whose IntegerValue is -1.

  METHODS:
    bool Equals(object obj)
      Description: Determines whether the specified Object is equal to the current Object.
      @obj: The other object to evaluate.
    int GetHashCode()
      Description: Gets the integer value of the id as hash code
    string ToString()
      Description: Gets a String representation of the integer value of the id.

--------------------------------------------------------------------------------

[ENUM] ScheduleFieldMultipleValuesDisplayType
Full Name: Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType
Description: Define how the schedule field's multiple value is displayed.
Inherits: Enum

  Values:
    - Project = 0
    - Varies = 1
    - Custom = 2

--------------------------------------------------------------------------------

[ENUM] ScheduleFieldType
Full Name: Autodesk.Revit.DB.ScheduleFieldType
Description: The type of data displayed in a schedule field.
Inherits: Enum

  Values:
    - Instance = 0
    - ElementType = 1
    - Count = 2
    - ViewBased = 4
    - Formula = 5
    - Percentage = 6
    - Room = 7
    - FromRoom = 8
    - ToRoom = 9
    - ProjectInfo = 10
    - Material = 11
    - MaterialQuantity = 12
    - RevitLinkInstance = 13
    - RevitLinkType = 14
    - StructuralMaterial = 15
    - Space = 16
    - Analytical = 17
    - PhysicalType = 18
    - PhysicalInstance = 19
    - CombinedParameter = 20
    - HostCount = 23
    - CustomField = 24
    - Revision = 25
    - Views = 26
    - Sheets = 27

--------------------------------------------------------------------------------

[CLASS] ScheduleFilter
Full Name: Autodesk.Revit.DB.ScheduleFilter
Description: A filter in a schedule.
Remarks: The ScheduleFilter class represents a single filter in a schedule. A filter is a condition that must be satisfied for an element to appear in the schedule. All filters must be satisfied for an element to appear in the schedule. A schedule can be filtered by data that is not displayed in the schedule by marking the field used for filtering as hidden using the ScheduleField.IsHidden property.
Implements: IDisposable

  CONSTRUCTORS:
    new ScheduleFilter(ScheduleFieldId fieldId, ScheduleFilterType filterType, ElementId value)
      Description: Creates a new ScheduleFilter.
      @fieldId: The ID of the field used to filter the schedule.
      @filterType: The filter type.
      @value: The filter value for a filter using an ElementId value.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ScheduleFilter(ScheduleFieldId fieldId, ScheduleFilterType filterType, string value)
      Description: Creates a new ScheduleFilter.
      @fieldId: The ID of the field used to filter the schedule.
      @filterType: The filter type.
      @value: The filter value for a filter using a string value.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ScheduleFilter(ScheduleFieldId fieldId, ScheduleFilterType filterType, double value)
      Description: Creates a new ScheduleFilter.
      @fieldId: The ID of the field used to filter the schedule.
      @filterType: The filter type.
      @value: The filter value for a filter using a double value.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ScheduleFilter(ScheduleFieldId fieldId, ScheduleFilterType filterType, int value)
      Description: Creates a new ScheduleFilter.
      @fieldId: The ID of the field used to filter the schedule.
      @filterType: The filter type.
      @value: The filter value for a filter using an integer value.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ScheduleFilter(ScheduleFieldId fieldId, ScheduleFilterType filterType)
      Description: Creates a new ScheduleFilter.
      @fieldId: The ID of the field used to filter the schedule.
      @filterType: The filter type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ScheduleFilter()
      Description: Creates a new ScheduleFilter.

  PROPERTIES:
    ScheduleFieldId FieldId { get; set; }
      Description: The ID of the field used to filter the schedule.
    ScheduleFilterType FilterType { get; set; }
      Description: The filter type.
    bool IsDoubleValue { get; }
      Description: Indicates if the filter has a double value.
    bool IsElementIdValue { get; }
      Description: Indicates if the filter has an ElementId value.
    bool IsIntegerValue { get; }
      Description: Indicates if the filter has an integer value.
    bool IsNullValue { get; }
      Description: Indicates if the filter has no specified value.
    bool IsStringValue { get; }
      Description: Indicates if the filter has a string value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    double GetDoubleValue()
      Description: Gets the filter value for a filter using a double value.
      Returns: The filter value.
      Throws InvalidOperationException: The filter value is not a double.
    ElementId GetElementIdValue()
      Description: Gets the filter value for a filter using an ElementId value.
      Returns: The filter value.
      Throws InvalidOperationException: The filter value is not an ElementId.
    int GetIntegerValue()
      Description: Gets the filter value for a filter using an integer value.
      Returns: The filter value.
      Throws InvalidOperationException: The filter value is not an integer.
    string GetStringValue()
      Description: Gets the filter value for a filter using a string value.
      Returns: The filter value.
      Throws InvalidOperationException: The filter value is not a string.
    void SetNullValue()
      Description: Sets the filter to have no specified value (used for HasParameter filters).
    void SetValue(ElementId id)
      Description: Set the filter value to an ElementId.
      @id: The filter value.
      Throws ArgumentNullException: A non-optional argument was null
    void SetValue(string string)
      Description: Set the filter value to a string.
      @string: The filter value.
      Throws ArgumentNullException: A non-optional argument was null
    void SetValue(double value)
      Description: Set the filter value to a double.
      @value: The filter value.
    void SetValue(int value)
      Description: Set the filter value to an integer.
      @value: The filter value.

--------------------------------------------------------------------------------

[ENUM] ScheduleFilterType
Full Name: Autodesk.Revit.DB.ScheduleFilterType
Description: Type of schedule filter.
Inherits: Enum

  Values:
    - Invalid = 0
    - HasParameter = 1
    - Equal = 2
    - NotEqual = 3
    - GreaterThan = 4
    - GreaterThanOrEqual = 5
    - LessThan = 6
    - LessThanOrEqual = 7
    - Contains = 8
    - NotContains = 9
    - BeginsWith = 10
    - NotBeginsWith = 11
    - EndsWith = 12
    - NotEndsWith = 13
    - IsAssociatedWithGlobalParameter = 14
    - IsNotAssociatedWithGlobalParameter = 15
    - HasValue = 16
    - HasNoValue = 17

--------------------------------------------------------------------------------

[ENUM] ScheduleHeadingOrientation
Full Name: Autodesk.Revit.DB.ScheduleHeadingOrientation
Description: Orientation of schedule heading.
Inherits: Enum

  Values:
    - Horizontal = 0
    - Vertical = 1

--------------------------------------------------------------------------------

[CLASS] ScheduleHeightsOnSheet
Full Name: Autodesk.Revit.DB.ScheduleHeightsOnSheet
Description: Heights information of a schedule on sheet.
Remarks: This class returns the heights of schedule title, column header and each body row on sheet view.
Implements: IDisposable

  PROPERTIES:
    double ColumnHeaderHeight { get; }
      Description: The height of all schedule header part, including the gap line between header and body.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double TitleHeight { get; }
      Description: The height of schedule title on sheet view.

  METHODS:
    void Dispose()
    IList<double> GetBodyRowHeights()
      Description: Returns each row's height of schedule body on sheet view.
      Returns: Each row's height of schedule body on sheet view.

--------------------------------------------------------------------------------

[ENUM] ScheduleHorizontalAlignment
Full Name: Autodesk.Revit.DB.ScheduleHorizontalAlignment
Description: Horizontal alignment of data in a schedule.
Inherits: Enum

  Values:
    - Left = 0
    - Center = 1
    - Right = 2

--------------------------------------------------------------------------------

[CLASS] ScheduleSheetInstance
Full Name: Autodesk.Revit.DB.ScheduleSheetInstance
Description: An element that represents a particular placement of a schedule on a sheet.
Remarks: Use ScheduleSheetInstance.OwnerViewId to find the sheet on which a schedule is placed. When a schedule is set to filter by sheet and placed on a sheet, it will create a new schedule with elements visible in the Viewport(s) on that sheet. The instance created belongs to the newly created schedule.
Inherits: Element

  PROPERTIES:
    bool IsTitleblockRevisionSchedule { get; }
      Description: Identifies if this ScheduleSheetInstance is a revision schedule in a titleblock family.
    XYZ Point { get; set; }
      Description: Location on the sheet where the ScheduleInstance is placed (in sheet coordinates).
    ViewportRotation Rotation { get; set; }
      Description: Rotation of the ScheduleInstance.
    ElementId ScheduleId { get; }
      Description: Id of the primary schedule that generates this ScheduleInstance.
    int SegmentIndex { get; set; }
      Description: The schedule segment index of this ScheduleSheetInstance.

  METHODS:
    static ScheduleSheetInstance Create(Document document, ElementId viewSheetId, ElementId scheduleId, XYZ origin, int segmentIndex)
      Description: Creates an instance of a schedule segment on a sheet.
      @document: The document
      @viewSheetId: The id of the sheet where the schedule segment will be placed.
      @scheduleId: The id of the schedule view.
      @origin: Location on the sheet where the schedule segment will be placed.
      @segmentIndex: The schedule segment index of the schedule instance.
      Returns: The new ScheduleInstance.
      Throws ArgumentException: scheduleId is not a ViewSchedule that can be added to sheets. "Internal" schedules are not user-visible but are filtered by sheet or used to manage Revisions, which cannot be added to sheets. -or- viewSheetId is not a ViewSheet. -or- segmentIndex is not a valid segment index.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ScheduleSheetInstance Create(Document document, ElementId viewSheetId, ElementId scheduleId, XYZ origin)
      Description: Create an instance of a schedule on a sheet.
      @document: The document
      @viewSheetId: The id of the sheet where the schedule will be placed.
      @scheduleId: The id of the schedule view.
      @origin: Location on the sheet where the schedule will be placed.
      Returns: The new ScheduleInstance.
      Throws ArgumentException: scheduleId is not a ViewSchedule that can be added to sheets. "Internal" schedules are not user-visible but are filtered by sheet or used to manage Revisions, which cannot be added to sheets. -or- viewSheetId is not a ViewSheet.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] ScheduleSortGroupField
Full Name: Autodesk.Revit.DB.ScheduleSortGroupField
Description: A field that is used for sorting and/or grouping in a schedule.
Remarks: A schedule may be sorted or grouped by one or more of the schedule's fields. The ScheduleSortGroupField class represents one of the fields that the schedule is sorted or grouped by. Sorting and grouping are related operations. In either case, elements appearing in the schedule are sorted based on their values for the field that the schedule is sorted/grouped by, which automatically causes elements with identical values to be grouped together. By enabling extra header, footer, or blank rows, visual separation between groups can be achieved. If ScheduleDefinition.IsItemized is false, elements having the same values for all of the fields used for sorting/grouping will be combined onto the same row. A schedule can be sorted or grouped by data that is not displayed in the schedule by marking the field used for sorting/grouping as hidden using the ScheduleField.IsHidden property.
Implements: IDisposable

  CONSTRUCTORS:
    new ScheduleSortGroupField(ScheduleFieldId fieldId, ScheduleSortOrder sortOrder)
      Description: Creates a new ScheduleSortGroupField.
      @fieldId: The ID of the field that the schedule will be sorted or grouped by.
      @sortOrder: The sort order, ascending or descending.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ScheduleSortGroupField(ScheduleFieldId fieldId)
      Description: Creates a new ScheduleSortGroupField.
      @fieldId: The ID of the field that the schedule will be sorted or grouped by.
      Throws ArgumentNullException: A non-optional argument was null
    new ScheduleSortGroupField()
      Description: Creates a new ScheduleSortGroupField.

  PROPERTIES:
    ScheduleFieldId FieldId { get; set; }
      Description: The ID of the field that the schedule will be sorted or grouped by.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ShowBlankLine { get; set; }
      Description: Indicates if an empty row should be displayed between groups.
    bool ShowFooter { get; set; }
      Description: Indicates if a footer row should be displayed after each group.
    bool ShowFooterCount { get; set; }
      Description: Indicates if the footer row should display a count of elements in the group.
    bool ShowFooterTitle { get; set; }
      Description: Indicates if the footer row should display a title.
    bool ShowHeader { get; set; }
      Description: Indicates if a header row should be displayed before each group.
    ScheduleSortOrder SortOrder { get; set; }
      Description: Indicates if elements in the schedule will be sorted in ascending or descending order.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ScheduleSortOrder
Full Name: Autodesk.Revit.DB.ScheduleSortOrder
Description: Options for sort order of rows in a schedule.
Inherits: Enum

  Values:
    - Ascending = 0
    - Descending = 1

--------------------------------------------------------------------------------

[ENUM] ScheduleVerticalAlignment
Full Name: Autodesk.Revit.DB.ScheduleVerticalAlignment
Description: Vertical alignment of data in a schedule.
Inherits: Enum

  Values:
    - Top = 0
    - Middle = 1
    - Bottom = 2

--------------------------------------------------------------------------------

[ENUM] SectionType
Full Name: Autodesk.Revit.DB.SectionType
Description: Declares the section data type.
Inherits: Enum

  Values:
    - Header = 0
    - Body = 1
    - Summary = 2
    - Footer = 3
    - None = -1

--------------------------------------------------------------------------------

[CLASS] Segment
Full Name: Autodesk.Revit.DB.Segment
Description: This element represents a segment of an MEP curve object.
Remarks: Currently, only pipe curves can be broken into separate segment elements.
Inherits: Element

  PROPERTIES:
    string Description { get; set; }
      Description: The description of the segment.
    ElementId MaterialId { get; }
      Description: The ElementId of the MaterialElem.
    double Roughness { get; set; }
      Description: The roughness value for given material.
    int SizeCount { get; }
      Description: The number of size objects in the segment.

  METHODS:
    void AddSize(MEPSize size)
      Description: Adds a new MEPSize to the segment.
      @size: The new MEPSize to be added.
      Throws ArgumentException: There is already a same size in the settings. -or- The size already exists in the segment.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<MEPSize> GetSizes()
      Description: Gets the defined sizes of the segment.
    void RemoveSize(double nominalDiameter)
      Description: Remove the existing MEPSize with this nominal diameter from the segment.
      @nominalDiameter: The nominal diameter of the size.
      Throws InvalidOperationException: The last size of the segment cannot be removed.

--------------------------------------------------------------------------------

[ENUM] SelectionFilterAction
Full Name: Autodesk.Revit.DB.SelectionFilterAction
Description: An enumerated type containing the type of actions that may be taken with a selection filter applied to a point cloud.
Inherits: Enum

  Values:
    - None = 0
    - Highlight = 1
    - Isolate = 2

--------------------------------------------------------------------------------

[CLASS] SelectionFilterElement
Full Name: Autodesk.Revit.DB.SelectionFilterElement
Description: A filter element that stores an explicit list of ElementIds. Only elements whose ElementIds are in this list will pass the filter.
Inherits: FilterElement

  METHODS:
    void AddSet(ICollection<ElementId> ids)
      Description: Adds a set of ElementIds to the filter's set.
      @ids: The set of ElementIds to add.
      Throws ArgumentNullException: A non-optional argument was null
    void AddSingle(ElementId id)
      Description: Adds a single ElementId to the filter's set.
      @id: The ElementId to add.
      Throws ArgumentException: Invalid ElementId
      Throws ArgumentNullException: A non-optional argument was null
    void Clear()
      Description: Removes all ElementIds from the filter.
    bool Contains(ElementId id)
      Description: Returns true if the given ElementId is a member of this filter's set.
      @id: The ElementId to look for.
      Returns: True if the given ElementId is a member of the filter, otherwise false.
      Throws ArgumentException: Invalid ElementId
      Throws ArgumentNullException: A non-optional argument was null
    static SelectionFilterElement Create(Document document, string name)
      Description: Creates a new SelectionFilterElement in the given document.
      @document: The document in which to create the SelectionFilterElement.
      @name: The name for the new SelectionFilterElement.
      Returns: The new SelectionFilterElement.
      Throws ArgumentException: name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a filter element name.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<ElementId> GetElementIds()
      Description: Returns the set of ElementIds contained by this filter.
      Returns: The set of ElementIds.
    bool IsEmpty()
      Description: Determines whether this filter's set is empty or not.
      Returns: True if the set is empty, otherwise false.
    int RemoveSet(ICollection<ElementId> ids)
      Description: Removes a set of ElementIds from the filter's set.
      @ids: The set of ElementIds to remove.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveSingle(ElementId id)
      Description: Removes a single ElementId from the filter's set.
      @id: The ElementId to remove.
      Throws ArgumentException: Invalid ElementId
      Throws ArgumentNullException: A non-optional argument was null
    void SetElementIds(ICollection<ElementId> ids)
      Description: Replaces the set of ElementIds contained by this filter.
      @ids: The new set of ElementIds.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ServerPath
Full Name: Autodesk.Revit.DB.ServerPath
Description: This class represents a path to a Revit Server location, rather than a location on disk or a network drive.
Remarks: ServerPaths must refer to Revit models. ServerPaths are relative to the central server location, and are of the form "RSN://{HostNodeName}/{model_path}". The {model_path} portion is a relative path to a Revit model. For example, the following are valid server paths: RSN://EXS/hospital.rvtRSN://EXS.autodesk.com/Old Files/hotel2.rvtRSN://EXS.autodesk.com/Old Files/Last Week/Tuesday\hotel2.rvt The following would not be valid server paths: //EXS/Old Files/.rvtEXS/hospital
Inherits: ModelPath

  CONSTRUCTORS:
    new ServerPath(string centralServerLocation, string path)
      Description: Constructs a ServerPath
      @centralServerLocation: The name of the central Revit server
      @path: The path of the model. This path must be relative.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ServiceType
Full Name: Autodesk.Revit.DB.ServiceType
Description: This enumeration is used for specifying the most predominant service for the building or space.
Remarks: This enumerated list corresponds to the serviceType attribute in the gbXML (Green Building XML) schema and is primarily used for energy analysis.
Inherits: Enum

  Values:
    - kCentralHeatingRadiators = 0
    - kCentralHeatingConvectors = 1
    - kCentralHeatingRadiantFloor = 2
    - kCentralHeatingHotAir = 3
    - kOtherRoomHeater = 4
    - kRadiantHeaterFlue = 5
    - kRadiantHeaterNoFlue = 6
    - kRadiantHeaterMultiburner = 7
    - kForcedConvectionHeaterFlue = 8
    - kForcedConvectionHeaterNoFlue = 9
    - kVAVSingleDuct = 10
    - kVAVDualDuct = 11
    - kVAVIndoorPackagedCabinet = 12
    - kVAVTerminalReheat = 13
    - kFanCoilSystem = 14
    - kInductionSystem = 15
    - kConstantVolumeFixedOA = 16
    - kConstantVolumeVariableOA = 17
    - kConstantVolumeTerminalReheat = 18
    - kMultizoneHotDeckColdDeck = 19
    - kConstantVolumeDualDuct = 20
    - kRadiantCooledCeilings = 21
    - kActiveChilledBeams = 22
    - kWaterLoopHeatPump = 23
    - kVariableRefrigerantFlow = 24
    - kSplitSystemsWithNaturalVentilation = 25
    - kSplitSystemsWithMechanicalVentilation = 26
    - kSplitSystemsWithMechanicalVentilationWithCooling = 27
    - kNoServiceType = -1

--------------------------------------------------------------------------------

[ENUM] SetComparisonResult
Full Name: Autodesk.Revit.DB.SetComparisonResult
Description: An enumerated type listing all the relationship types between two sets of arbitrary nature.
Inherits: Enum

  Values:
    - LeftEmpty = 1
    - RightEmpty = 2
    - BothEmpty = 3
    - Disjoint = 4
    - Overlap = 8
    - Subset = 16
    - Superset = 32
    - Equal = 64

--------------------------------------------------------------------------------

[CLASS] Settings
Full Name: Autodesk.Revit.DB.Settings
Description: The settings object provides access to general components of the Autodesk Revit application, such as Categories.
Inherits: APIObject

  PROPERTIES:
    Categories Categories { get; }
      Description: Retrieves an object that provides access to all the categories contained in the Autodesk Revit application and project.
    ElectricalSetting ElectricalSetting { get; }
      Description: Retrieves an object that provides access to all the electrical settings include voltage type, distribution system type, demand factor, wire type in the Autodesk Revit application and project.
    TilePatterns TilePatterns { get; }
      Description: Retrieves an object that provides access to the TilePattern objects in the document.

--------------------------------------------------------------------------------

[CLASS] ShapeBuilder
Full Name: Autodesk.Revit.DB.ShapeBuilder
Description: The base class for geometry builder classes.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ShapeImporter
Full Name: Autodesk.Revit.DB.ShapeImporter
Description: A utility class that supports conversion of geometry stored in an external format into a Revit geometry objects.
Remarks: See ShapeImporterSourceFormat for the list of supported formats.
Implements: IDisposable

  CONSTRUCTORS:
    new ShapeImporter()
      Description: Default constructor. Initializes an instance of ShapeImporter that will automatically recognize the file format from its extension (ShapeImporterSourceFormat.Auto).

  PROPERTIES:
    ImportUnit DefaultLengthUnit { get; }
      Description: The length unit to be used if not specified when the input is a unitless SAT file.
    ShapeImporterSourceFormat InputFormat { get; set; }
      Description: The format of the incoming data.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    IList<GeometryObject> Convert(Document document, string filename)
      Description: Converts the geometry stored in the external format into a collection of Revit geometry objects.
      @document: The Revit document where the resulting Revit geometry objects will be used. This document may need to be modified to store dependent elements such as graphics styles and/or materials.
      @filename: The full path to the input file.
      Returns: A collection of Revit geometry objects created from the incoming data.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given filename does not exist.
      Throws InvalidOperationException: Data conversion service is not available, or the Material Library is missing.
    void Dispose()
    static bool IsServiceAvailable()
      Description: Checks whether the data conversion service and Material Library are available.
      Returns: True if the data conversion service and Material Library are available, false otherwise.
    ShapeImporter SetDefaultLengthUnit(ImportUnit defaultLengthUnit)
      Description: Sets the length unit to be used when the input is a unitless SAT file.
      @defaultLengthUnit: The length unit to be used for when the input is a unitless SAT file.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] ShapeImporterSourceFormat
Full Name: Autodesk.Revit.DB.ShapeImporterSourceFormat
Description: An enumerated type listing the possible formats supported by ShapeImporter.
Inherits: Enum

  Values:
    - Auto = 0
    - SAT = 1
    - Rhino = 2
    - SketchUp = 3
    - OBJ = 4
    - STL = 5
    - STEP = 6

--------------------------------------------------------------------------------

[CLASS] SharedParameterApplicableRule
Full Name: Autodesk.Revit.DB.SharedParameterApplicableRule
Description: Tests whether an element supports a shared parameter.
Inherits: FilterRule

  CONSTRUCTORS:
    new SharedParameterApplicableRule(string parameterName)
      Description: Constructs an instance of SharedParameterApplicableRule.
      @parameterName: The name of the parameter that an element must support to pass this rule.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    string ParameterName { get; set; }
      Description: The name of the parameter that an element must support to pass this rule.

--------------------------------------------------------------------------------

[CLASS] SharedParameterElement
Full Name: Autodesk.Revit.DB.SharedParameterElement
Description: An element that stores the definition of a shared parameter which is loaded into the document.
Remarks: Shared parameters are user-defined parameters that can be shared by multiple Revit documents. A shared parameter is identified by a GUID. Basic information of the shared parameter are accessed through GetDefinition().
Inherits: ParameterElement

  PROPERTIES:
    Guid GuidValue { get; }
      Description: The Guid that identifies this shared parameter.

  METHODS:
    static SharedParameterElement Create(Document document, ExternalDefinition sharedParameterDefinition)
      Description: Creates a new shared parameter element in the document representing the parameter stored in the input ExternalDefinition.
      @document: The document.
      @sharedParameterDefinition: Shared parameter definition.
      Returns: The newly created shared parameter instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: A shared parameter with the assigned GUID is already loaded into the document.
    static SharedParameterElement Lookup(Document document, Guid guidValue)
      Description: Finds the shared parameter element that corresponds to the given Guid.
      @document: The document.
      @guidValue: Shared parameter Guid.
      Returns: The retrieved shared parameter instance, or if the matching element is not found.
      Throws ArgumentNullException: A non-optional argument was null
    bool ShouldHideWhenNoValue()
      Description: Indicates whether the parameter should be hidden from the properties palette if it has no value.

--------------------------------------------------------------------------------

[CLASS] SheetCollection
Full Name: Autodesk.Revit.DB.SheetCollection
Description: This class represents a sheet collection in Autodesk Revit.
Inherits: Element

  METHODS:
    static SheetCollection Create(Document document)
      Description: Creates a new instance of sheet collection with an auto-generated name and adds it to the document.
      @document: The document where the sheet collection element will be created and added.
      Returns: The newly created sheet collection element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static SheetCollection Create(Document document, string name)
      Description: Creates a new instance of sheet collection with a specified name and adds it to the document.
      @document: The document where the sheet collection element will be created and added.
      @name: The name of new sheet collection.
      Returns: The newly created sheet collection element.
      Throws ArgumentException: name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a sheet collection name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[ENUM] SheetDuplicateOption
Full Name: Autodesk.Revit.DB.SheetDuplicateOption
Description: Options for duplicating sheets
Inherits: Enum

  Values:
    - DuplicateEmptySheet = 0
    - DuplicateSheetWithDetailing = 1
    - DuplicateSheetWithViewsOnly = 2
    - DuplicateSheetWithViewsAndDetailing = 3
    - DuplicateSheetWithViewsAsDependent = 4

--------------------------------------------------------------------------------

[ENUM] ShellLayerType
Full Name: Autodesk.Revit.DB.ShellLayerType
Description: Used to distinguish exterior and interior shell layers.
Remarks: Used as an argument to methods of CompoundStructure that deal with shell layers.
Inherits: Enum

  Values:
    - Interior = 0
    - Exterior = 1

--------------------------------------------------------------------------------

[ENUM] ShowHiddenLinesValues
Full Name: Autodesk.Revit.DB.ShowHiddenLinesValues
Description: Provides options for display of hidden lines in a given view.
Inherits: Enum

  Values:
    - None = 0
    - ByDiscipline = 1
    - All = 2

--------------------------------------------------------------------------------

[ENUM] SimpleWorksetConfiguration
Full Name: Autodesk.Revit.DB.SimpleWorksetConfiguration
Description: Indicates the set of user-created worksets to open in memory
Inherits: Enum

  Values:
    - AllWorksets = 0
    - AllEditable = 1
    - LastViewed = 2
    - AskUserToSpecify = 3

--------------------------------------------------------------------------------

[CLASS] SiteLocation
Full Name: Autodesk.Revit.DB.SiteLocation
Description: Contains the geographical location information for the project's site.
Remarks: Each project may have one site which dictates where in the world the project is based. On this site there may be several locations of the same project. These are represented by ProjectLocation objects. The site location object can be found by using the SiteLocation property on the Document object. The properties of this object can be changed such that it represents any location on the planet or to a known city. Cities already programmed into Revit can be found from the Cities property on the Application object.
Inherits: ElementType

  PROPERTIES:
    double Elevation { get; }
      Description: The elevation of the site location.
    string GeoCoordinateSystemDefinition { get; }
      Description: The XML or WKT2 string which describes the geographic coordinate system.
    string GeoCoordinateSystemId { get; }
      Description: The geographic coordinate system ID, such as "AMG-50" and "Beijing1954/a.GK3d-40".
    double Latitude { get; set; }
      Description: The latitude of the site location.
    double Longitude { get; set; }
      Description: The longitude of the site location.
    string PlaceName { get; set; }
      Description: The place name of the site.
    double TimeZone { get; set; }
      Description: The time-zone for the site.
    string WeatherStationName { get; }
      Description: The name of the weather station at the site location.

  METHODS:
    DateTime ConvertFromProjectTime(DateTime projectTime)
      Description: Converts project time to UTC time.
      @projectTime: The project time.
      Throws ArgumentException: Thrown when the projectTime's kind is not Unspecified.
    DateTime ConvertToProjectTime(DateTime inputTime)
      Description: Converts local time or UTC time to project time.
      @inputTime: The input local time or UTC time.
      Throws ArgumentException: Thrown when the inputTime's kind is neither Local nor Utc.
    bool IsCompatibleWith(SiteLocation otherSiteLocation)
      Description: Checks whether the geographic coordinate system of this site is compatible with the given site . True if he geographic coordinate system of this site is compatible with the given site, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetGeoCoordinateSystem(string coordSystem)
      Description: Set the geographic coordinate system for this site. Similar to acquire coordinate system from a link in the UI.
      @coordSystem: The coordinate system to set for the project.
      Throws ArgumentException: coordSystem is an empty string or contains only whitespace. -or- The coordinate system is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InternalException: Fail to update coordinate system.
      Throws InvalidOperationException: The site location does not come from the project.
    void SetLatitudeAndLongitude(double latitude, double longitude, bool updateCityAndTimeZone)
      Description: Sets the latitude and longitude and optionally updates the city and time zone information.
      @latitude: The latitude, in radians between -PI/2 and PI/2.
      @longitude: The longitude, in radians between -PI and PI. If the given value is not between -PI and PI, it will be shifted by multiples of 2PI until it is in range.
      @updateCityAndTimeZone: If true, Revit will attempt to match the coordinates to a city it knows about, and also attempt to automatically adjust the time zone value.
      Throws ArgumentException: The latitude value is out of range. It must be between -PI/2 and PI/2.

--------------------------------------------------------------------------------

[CLASS] Sketch
Full Name: Autodesk.Revit.DB.Sketch
Description: Provides access to the Sketch in Autodesk Revit.
Inherits: SketchBase

  PROPERTIES:
    ElementId OwnerId { get; }
      Description: Returns id of the sketch owner element or invalidElementId if sketch does not build a geometry.
    CurveArrArray Profile { get; }
      Description: Returns the Profile of the Sketch.
    SketchPlane SketchPlane { get; }
      Description: Returns the Sketch Plane of the Sketch.

  METHODS:
    IList<ElementId> GetAllElements()
      Description: Returns all elements which belong to the sketch.
      Returns: Returns ids of elements which belong to that sketch.

--------------------------------------------------------------------------------

[CLASS] SketchBase
Full Name: Autodesk.Revit.DB.SketchBase
Description: Provides access to the SketchBase in Autodesk Revit.
Remarks: SketchBase is the base class of Sketch.
Inherits: Element

--------------------------------------------------------------------------------

[CLASS] SketchEditScope
Full Name: Autodesk.Revit.DB.SketchEditScope
Description: A SketchEditScope allows an application to create and maintain an editing session for a Sketch.
Remarks: Start/end of a SketchEditScope will start/end a transaction group. After a SketchEditScope is started, an application can start transactions and edit the sketch. Individual transactions the application creates inside SketchEditScope will not appear in the undo menu. All transactions committed during the edit mode will be merged into a single one which will bear the given name passed into SketchEditScope constructor.
Inherits: EditScope

  CONSTRUCTORS:
    new SketchEditScope(Document document, string transactionName)
      Description: Instantiates a SketchEditScope object.
      @document: The document for which this SketchEditScope is going to be used.
      @transactionName: The name that will appear in the Undo menu in Revit after the SketchEditScope is successfully committed.
      Throws ArgumentException: document is not a primary document, it is a linked document. -or- document is not a project document. -or- transactionName is an empty string.
      Throws ArgumentNullException: A non-optional argument was null

  METHODS:
    bool IsElementWithoutSketch(ElementId elementId)
      Description: Validates if an element can have a sketch but currently does not.
      @elementId: The element id to be checked.
      Returns: True if the element doesn't have a sketch, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsSketchEditingSupported(ElementId sketchId)
      Description: Checks whether sketch can be edited.
      @sketchId: The element id of sketch.
      Returns: True if sketch can be edited, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsSketchEditingSupportedForSketchBasedElement(ElementId elemId)
      Description: Checks whether the element supports sketch editing.
      @elemId: The element id to be checked.
      Returns: True if element supports sketch editing, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Start(ElementId sketchId)
      Description: Starts a sketch edit mode.
      @sketchId: The Sketch element to be edited.
      Throws ArgumentException: The ElementId sketchId does not represent a Sketch. -or- Sketch does not support editing. -or- Failed to start the sketch edit mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This SketchEditScope is not permitted to start at this moment for one of the following possible reasons: The document is in read-only state, or the document is currently modifiable, or there already is another edit mode active in the document.
    void StartWithNewSketch(ElementId elementId)
      Description: Starts a sketch edit mode for an element which, at this moment, doesn't have a sketch.
      @elementId: The Element without sketch to be edited.
      Throws ArgumentException: The ElementId elementId already has a sketch defined. -or- Element does not support sketch editing. -or- Failed to start the sketch edit mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This SketchEditScope is not permitted to start at this moment for one of the following possible reasons: The document is in read-only state, or the document is currently modifiable, or there already is another edit mode active in the document. -or- Cannot create sketch.

--------------------------------------------------------------------------------

[CLASS] SketchedStairsCurveData
Full Name: Autodesk.Revit.DB.SketchedStairsCurveData
Description: Sketched run/landing curves overrides with height and slope
Implements: IDisposable

  CONSTRUCTORS:
    new SketchedStairsCurveData(Curve boundaryCurve, double height, SketchedCurveSlopeOption slopeType)
      Description: Construct a SketchedStairsCurveData defined by a curve associated with its height and slope type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Curve GetCurve()
      Description: Get a copy of the curve that is formed along this boundary.
      Returns: A copy of the curve.

--------------------------------------------------------------------------------

[CLASS] SketchPlane
Full Name: Autodesk.Revit.DB.SketchPlane
Description: Represents a sketch plane or work plane.
Remarks: A SketchPlane object is used as an input to creation of sketch-referencing elements such as Model Curves or sketch-owning elements such as Generic Forms. The SketchPlane can be obtained from an existing element or created from a geometric plane or planar face. Note that the sketch plane element passed as input to create an element may not be the actual sketch plane assigned to that element; Revit may look for a geometrically equivalent plane to use, or may create a new one if the input plane is already used for other purposes. Some sketch planes (such as those obtained from detail curves) are suitable only for use in creating detail elements; they will be rejected when used for other element types.
Inherits: Element

  PROPERTIES:
    bool IsSuitableForModelElements { get; }
      Description: Identifies if the sketch plane can be assigned to model elements.

  METHODS:
    static SketchPlane Create(Document document, ElementId datumId)
      Description: Creates a sketch plane from a grid, reference plane, or level.
      @document: The document.
      @datumId: The id of the grid, reference plane, or level.
      Returns: The newly created sketch plane.
      Throws ArgumentException: datumId is not a valid Element identifier. -or- ElementId must correspond to a grid, reference plane, or level. -or- ElementId must correspond to a non-curved datum. -or- Sketch plane creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static SketchPlane Create(Document document, Reference planarFaceReference)
      Description: Creates a new sketch plane from a reference to a planar face.
      @document: The document.
      @planarFaceReference: The reference of the planar face where the sketch plane will be created.
      Returns: The newly created sketch plane.
      Throws ArgumentException: Sketch plane creation is not allowed in this family. -or- The reference is not a planar face.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static SketchPlane Create(Document document, Plane plane)
      Description: Creates a new sketch plane from a geometric plane.
      @document: The document.
      @plane: The geometry plane where the sketch plane will be created.
      Returns: The newly created sketch plane.
      Throws ArgumentException: Sketch plane creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    Plane GetPlane()
      Description: Returns the corresponding Plane.
      Returns: The plane upon which elements created with this sketch plane will lie.
    Reference GetPlaneReference()
      Description: Returns a reference to this element as a plane.
      Returns: The reference.

--------------------------------------------------------------------------------

[CLASS] SKPImportOptions
Full Name: Autodesk.Revit.DB.SKPImportOptions
Description: The import options used to import SKP format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new SKPImportOptions(SKPImportOptions option)
      Description: Constructs a new instance of SKPImportOptions as a copy of the import options.
      @option: The SKP options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new SKPImportOptions()
      Description: Constructs a new instance of SKPImportOptions with default values of all properties.

--------------------------------------------------------------------------------

[CLASS] SkyBackgroundSettings
Full Name: Autodesk.Revit.DB.SkyBackgroundSettings
Description: Represents the rendering sky background settings.
Inherits: BackgroundSettings

--------------------------------------------------------------------------------

[CLASS] SlabEdge
Full Name: Autodesk.Revit.DB.SlabEdge
Description: An object that represents a slab edge within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object.
Inherits: HostedSweep

  PROPERTIES:
    SlabEdgeType SlabEdgeType { get; set; }
      Description: Retrieves/set an object that represents the type of the SlabEdge.

  METHODS:
    void AddSegment(Reference targetRef)
      Description: Add segments to the slab edge.
      @targetRef: Segment's reference on which want to be added.
      Throws ArgumentNullException: This exception will be thrown in following cases: 1. Input targetRef is . 2. Input targetRef is not but contains nothing.
      Throws InvalidOperationException: This exception will be thrown in following cases: 1. Input targetRef has already been added into the slab edge. 2. Internal code fails to create the segment object. 3. Regeneration fails.
      Throws ArgumentOutOfRangeException: This exception will be thrown if the reference is suitable for creating a slab edge as required. The reference allowed is : 1. Model Line 2. Floor's horizontal edges 3. Other slab edge's horizontal edges

--------------------------------------------------------------------------------

[CLASS] SlabEdgeType
Full Name: Autodesk.Revit.DB.SlabEdgeType
Description: An object that represents the slab edge type in Autodesk Revit.
Inherits: HostedSweepType

--------------------------------------------------------------------------------

[CLASS] SlabShapeCrease
Full Name: Autodesk.Revit.DB.SlabShapeCrease
Description: Represents a crease of a slab shape edited element.
Implements: IDisposable

  PROPERTIES:
    SlabShapeCreaseType CreaseType { get; }
      Description: The type of the crease.
    Curve Curve { get; }
      Description: The geometry of the crease.
    SlabShapeVertexArray EndPoints { get; }
      Description: The vertices of the crease.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SlabShapeCreaseArray
Full Name: Autodesk.Revit.DB.SlabShapeCreaseArray
Description: An array that can contain any number of creases used in Slab Shape Editing.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new SlabShapeCreaseArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    SlabShapeCrease Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(SlabShapeCrease item)
      Description: Add the item to the end of the array.
      @item: The item to be added.
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    SlabShapeCreaseArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(SlabShapeCrease item, int index)
      Description: Insert the specified item into the array.
      @item: The item to be inserted into the array.
      @index: The item will be inserted before this index.
    SlabShapeCreaseArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SlabShapeCreaseArrayIterator
Full Name: Autodesk.Revit.DB.SlabShapeCreaseArrayIterator
Description: An iterator to an array of creases used for Slab Shape Editing.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new SlabShapeCreaseArrayIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the array.
    void Reset()
      Description: Bring the iterator back to the start of the array.

--------------------------------------------------------------------------------

[ENUM] SlabShapeCreaseType
Full Name: Autodesk.Revit.DB.SlabShapeCreaseType
Description: The type of a SlabShapeCrease
Inherits: Enum

  Values:
    - Invalid = 0
    - Boundary = 1
    - UserDrawn = 2
    - Auto = 3

--------------------------------------------------------------------------------

[CLASS] SlabShapeEditor
Full Name: Autodesk.Revit.DB.SlabShapeEditor
Description: An object used for Slab Shape Editing.
Remarks: The SlabShapeEditor can be obtained from a slab object, such as a roof or floor.
Implements: IDisposable

  PROPERTIES:
    bool IsEnabled { get; }
      Description: Identifies if the slab shape editing functionality is enabled.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SlabShapeCreaseArray SlabShapeCreases { get; }
      Description: All of the creases that can be edited.
    SlabShapeVertexArray SlabShapeVertices { get; }
      Description: All of the vertices that can be edited.

  METHODS:
    SlabShapeVertex AddPoint(XYZ point)
      Description: Add a point to the element.
      Returns: the newly added slab shape vertex.
      Throws ArgumentNullException: A non-optional argument was null
    IList<SlabShapeVertex> AddPoints(IList<XYZ> points)
      Description: Add an array of points to the element.
      @points: The point array.
      Returns: The newly added slab shape vertices.
      Throws ArgumentException: The input points are not valid. Please check if they are distinct on the x-y plane.
      Throws ArgumentNullException: A non-optional argument was null
    IList<SlabShapeCrease> AddSplitLine(SlabShapeVertex startVertex, SlabShapeVertex endVertex)
      Description: Add a split line to the element.
      @startVertex: Start vertex
      @endVertex: End vertex
      Returns: The newly created creases after adding the split line.
      Throws ArgumentNullException: A non-optional argument was null
    void CreateCreasesFromFoldingLines(Element hostObj, IList<Reference> references)
      Description: Convert selected folding lines to split lines
      @hostObj: object that hosts the SlabShapeEditor
      @references: References of selected folding lines.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: this operation failed.
    bool DeletePoint(SlabShapeVertex vertex)
      Description: Delete a SlabShapeVertex from the element.
      @vertex: The SlabShapeVertex to be deleted.
      Returns: True if the vertex is successfully deleted. False if the vertex is not found or could not be deleted.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    void Enable()
      Description: Enables the slab shape editing functionality.
    void ModifySubElement(SlabShapeCrease crease, double offset)
      Description: Manipulates the crease on the corresponding slab, roof or floor.
      @crease: The crease.
      @offset: The new value of the crease offset, which is the average of offsets of its ends.
      Throws ArgumentNullException: Thrown when the crease is .
      Throws ArgumentException: Thrown when the crease is invalid.
    void ModifySubElement(SlabShapeVertex vertex, double offset)
      Description: Manipulates the vertex on the corresponding slab, roof or floor.
      @vertex: The vertex.
      @offset: The new value of the vertex offset.
      Throws ArgumentNullException: Thrown when the vertex is .
      Throws ArgumentException: Thrown when the vertex is invalid.
    void PickSupport(Line gLine)
      Description: Picks an element to support the slab. This method will define split lines and create constant bearing lines for the slab.
      @gLine: A line from a support element such as a beam.
      Throws ArgumentNullException: Thrown when the input line is .
      Throws ArgumentException: Thrown when the input line is invalid.
    void ResetSlabShape()
      Description: Removes the modifications made during editing and resets the element geometry back to the unmodified state.

--------------------------------------------------------------------------------

[CLASS] SlabShapeVertex
Full Name: Autodesk.Revit.DB.SlabShapeVertex
Description: Represents a vertex of a slab shape edited element.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Position { get; }
      Description: The vertex position
    SlabShapeVertexType VertexType { get; }
      Description: The vertex type

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SlabShapeVertexArray
Full Name: Autodesk.Revit.DB.SlabShapeVertexArray
Description: An array that can contain any number of vertices used in Slab Shape Editing.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new SlabShapeVertexArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    SlabShapeVertex Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(SlabShapeVertex item)
      Description: Add the item to the end of the array.
      @item: The item to be added.
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    SlabShapeVertexArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(SlabShapeVertex item, int index)
      Description: Insert the specified item into the array.
      @item: The item to be inserted into the array.
      @index: The item will be inserted before this index.
    SlabShapeVertexArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SlabShapeVertexArrayIterator
Full Name: Autodesk.Revit.DB.SlabShapeVertexArrayIterator
Description: An iterator to an array of vertices used for Slab Shape Editing.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new SlabShapeVertexArrayIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the array.
    void Reset()
      Description: Bring the iterator back to the start of the array.

--------------------------------------------------------------------------------

[ENUM] SlabShapeVertexType
Full Name: Autodesk.Revit.DB.SlabShapeVertexType
Description: The type of a SlabShapeVertex
Inherits: Enum

  Values:
    - Invalid = 0
    - Corner = 1
    - Edge = 2
    - Interior = 3

--------------------------------------------------------------------------------

[ENUM] SlantedOrVerticalColumnType
Full Name: Autodesk.Revit.DB.SlantedOrVerticalColumnType
Description: This enum class is used for the BuiltInParameter SLANTED_COLUMN_TYPE_PARAM.
Inherits: Enum

  Values:
    - CT_Vertical = 0
    - CT_Angle = 1
    - CT_EndPoint = 2

--------------------------------------------------------------------------------

[CLASS] Solid
Full Name: Autodesk.Revit.DB.Solid
Description: A 3d solid.
Remarks: A solid is defined by the faces and edges that form its boundary.
Inherits: GeometryObject

  PROPERTIES:
    EdgeArray Edges { get; }
      Description: The edges that belong to the solid.
    FaceArray Faces { get; }
      Description: The faces that belong to the solid.
    double SurfaceArea { get; }
      Description: Returns the total surface area of this solid.
    double Volume { get; }
      Description: Returns the signed volume of this solid.

  METHODS:
    XYZ ComputeCentroid()
      Description: Returns the Centroid of this solid.
      Returns: The XYZ point of the Centroid of this solid.
    BoundingBoxXYZ GetBoundingBox()
      Description: Retrieves a box that circumscribes the solid geometry.
    SolidCurveIntersection IntersectWithCurve(Curve curve, SolidCurveIntersectionOptions options)
      Description: Calculates and returns the intersection between a curve and this solid.
      @curve: The curve.
      @options: The options. If NULL, the default options will be used.
      Returns: The intersection results.
      Throws ArgumentException: The input curve is not bound. -or- The input solid is not a closed volume.
      Throws ArgumentNullException: A non-optional argument was NULL

--------------------------------------------------------------------------------

[CLASS] SolidCurveIntersection
Full Name: Autodesk.Revit.DB.SolidCurveIntersection
Description: This class represents the results of a calculation of intersection between a solid volume and a curve.
Remarks: The results contain a collection of curves and a collection of curve extents (which are the parameters of intersection from the original input curve). Depending on the SolidCurveIntersectionMode option passed when executing the calculation, the curve segments and curve extents represent either the extents of the curve which exist inside the solid, or the extents of the curve which exist outside the solid. If the curve is entirely inside the solid, and the option is CurveSegmentsOutside, or if the curve is entirely outside the solid, and the option is CurveSegmentsInside, this results object will be empty. Note that curves aligned with the bounding faces of the solid are considered to be inside by this utility.
Implements: IEnumerable<Curve>, IEnumerable, IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SolidCurveIntersectionMode ResultType { get; }
      Description: The result type used to calculate the intersections.
    int SegmentCount { get; }
      Description: The number of segments in the results.

  METHODS:
    void Dispose()
    Curve GetCurveSegment(int index)
      Description: Gets the curve segment generated by intersection.
      @index: The index.
      Returns: The curve.
      Throws ArgumentException: index is out of range.
    CurveExtents GetCurveSegmentExtents(int index)
      Description: Gets the extents for the given curve segment generated by intersection.
      @index: The index.
      Returns: The curve extents.
      Throws ArgumentException: index is out of range.
    IEnumerator<Curve> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.

--------------------------------------------------------------------------------

[ENUM] SolidCurveIntersectionMode
Full Name: Autodesk.Revit.DB.SolidCurveIntersectionMode
Description: Represents the types of results available for calculating the intersection between a solid and a curve.
Inherits: Enum

  Values:
    - CurveSegmentsInside = 0
    - CurveSegmentsOutside = 1

--------------------------------------------------------------------------------

[CLASS] SolidCurveIntersectionOptions
Full Name: Autodesk.Revit.DB.SolidCurveIntersectionOptions
Description: This class contains the options used to calculate the intersection between a solid and a curve.
Implements: IDisposable

  CONSTRUCTORS:
    new SolidCurveIntersectionOptions()
      Description: Constructs a new SolidCurveIntersectionMode with default settings.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SolidCurveIntersectionMode ResultType { get; set; }
      Description: The type of results expected by the calculation. The default is CurveSegmentsInside.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] SolidGeometry
Full Name: Autodesk.Revit.DB.SolidGeometry
Description: An enumerated type listing possible ways of exporting solids in 3D views.
Inherits: Enum

  Values:
    - Polymesh = 0
    - ACIS = 1

--------------------------------------------------------------------------------

[CLASS] SolidGeometryOptions
Full Name: Autodesk.Revit.DB.SolidGeometryOptions
Description: A class containing optional information to control the geometry generation of the Solid by the SolidUtils routines.
Implements: IDisposable

  CONSTRUCTORS:
    new SolidGeometryOptions(int solidTag)
      Description: Creates a new SolidOptions class with solid tag settings.
      @solidTag: The material id for the Solid.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int SolidTag { get; set; }
      Description: Optional solid tag for the Solid.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SolidOptions
Full Name: Autodesk.Revit.DB.SolidOptions
Description: A class containing optional information to control the properties of the Solid generated by the GeometryCreationUtilities routines.
Implements: IDisposable

  CONSTRUCTORS:
    new SolidOptions(ElementId materialId, ElementId graphicsStyleId)
      Description: Creates a new SolidOptions class with material and graphics style settings.
      @materialId: The material id for the Solid.
      @graphicsStyleId: The graphics style id for the Solid.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    int ExtraFaceAndEdgeHistoryKey { get; set; }
      Description: Optional extra key used to create face and edge histories for the Solid. If extraFaceAndEdgeHistoryKey is higher than -1, the Solid's face and edge histories will be created depending on the geometry generation of the Solid.
    ElementId GraphicsStyleId { get; set; }
      Description: Defines the graphics style id for the Solid.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId MaterialId { get; set; }
      Description: Defines the material id for the Solid.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SolidOrShellTessellationControls
Full Name: Autodesk.Revit.DB.SolidOrShellTessellationControls
Description: Controls various aspects of the triangulation produced by SolidUtils::tessellateSolidOrShell method.
Implements: IDisposable

  CONSTRUCTORS:
    new SolidOrShellTessellationControls()
      Description: Default constructor.

  PROPERTIES:
    double Accuracy { get; set; }
      Description: A positive real number specifying how accurately a triangulation should approximate a solid or shell.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LevelOfDetail { get; set; }
      Description: An number between 0 and 1 (inclusive) specifying the level of detail for the triangulation of a solid or shell.
    double MinAngleInTriangle { get; set; }
      Description: A non-negative real number specifying the minimum allowed angle for any triangle in the triangulation, in radians.
    double MinExternalAngleBetweenTriangles { get; set; }
      Description: A positive real number specifying the minimum allowed value for the external angle between two adjacent triangles, in radians.

  METHODS:
    void DisableLevelOfDetail()
      Description: Disables the use of levelOfDetail. The use of levelOfDetail is enabled by calling setLevelOfDetail (with a valid input).
    void Dispose()
    bool UseLevelOfDetail()
      Description: Returns true if the use of levelOfDetail is enabled, false if not. The use of levelOfDetail is enabled by calling setLevelOfDetail (with a valid input).

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SolidSolidCutUtils
Full Name: Autodesk.Revit.DB.SolidSolidCutUtils
Description: Exposes utilities which can cause one solid to cut another.
Remarks: These utilities are applicable for the generic forms, geometry combinations and family instances in conceptual model, pattern based curtain panel, or adaptive component families, and family instances which are permitted to participate in joining in projects. Thus, for example, a beam cannot cut a wall (as the wall is not a family instance) in projects. Nor can a steel beam participate in cutting another family (because steel beams do not participate in joining).

  METHODS:
    static void AddCutBetweenSolids(Document document, Element solidToBeCut, Element cuttingSolid, bool splitFacesOfCuttingSolid)
      Description: Adds a solid-solid cut for the two elements with the option to control splitting of faces of the cutting solid.
      @document: The document containing the two elements.
      @solidToBeCut: The solid to be cut.
      @cuttingSolid: The cutting solid.
      @splitFacesOfCuttingSolid: True to split faces of cutting solid where it intersects the solid to be cut, false otherwise.
      Throws ArgumentException: The element must be in a project document or in a conceptual model, pattern based curtain panel, or adaptive component family. -or- The element does not meet the condition that it must be solid and must be a GenericForm, GeomCombination, or a FamilyInstance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to add solid-solid cut for the two elements.
    static void AddCutBetweenSolids(Document document, Element solidToBeCut, Element cuttingSolid)
      Description: Adds a solid-solid cut for the two elements.
      @document: The document containing the two elements.
      @solidToBeCut: The solid to be cut.
      @cuttingSolid: The cutting solid.
      Throws ArgumentException: The element must be in a project document or in a conceptual model, pattern based curtain panel, or adaptive component family. -or- The element does not meet the condition that it must be solid and must be a GenericForm, GeomCombination, or a FamilyInstance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to add solid-solid cut for the two elements.
    static bool CanElementCutElement(Element cuttingElement, Element cutElement, out CutFailureReason reason)
      Description: Verifies if the cutting element can add a solid cut to the target element.
      @cuttingElement: The cutting element.
      @cutElement: The element to be cut.
      @reason: The reason that the cutting element cannot add a solid cut to the cut element.
      Returns: True if the cutting element can add a solid cut to the target element, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool CutExistsBetweenElements(Element first, Element second, out bool firstCutsSecond)
      Description: Checks that if there is a solid-solid cut between two elements.
      @first: The solid being cut or the cutting solid.
      @second: The solid being cut or the cutting solid.
      @firstCutsSecond: If the return value of this function is true, this indicates which element is the cutting element from the pair. True if the first solid cuts the second one, false if the second solid cuts the first one.
      Returns: True if there is a solid-solid cut between the input elements, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetCuttingSolids(Element element)
      Description: Gets all the solids which cut the input element.
      @element: The input element.
      Returns: The ids of the solids which cut the input element.
      Throws ArgumentNullException: A non-optional argument was null
    static ICollection<ElementId> GetSolidsBeingCut(Element element)
      Description: Get all the solids which are cut by the input element.
      @element: The input element.
      Returns: The ids of the solids which are cut by the input element.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAllowedForSolidCut(Element element)
      Description: Validates that the element is eligible for a solid-solid cut.
      @element: The solid to be cut or the cutting solid.
      Returns: True if the input element can participate in a solid-solid cut. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsElementFromAppropriateContext(Element element)
      Description: Validates that the element is from an appropriate document.
      @element: The solid to be cut or the cutting solid.
      Returns: True if the element is from an appropriate document for solid-solid cuts, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static void RemoveCutBetweenSolids(Document document, Element first, Element second)
      Description: Removes the solid-solid cut between the two elements if it exists.
      @document: The document containing the two elements
      @first: The solid being cut or the cutting solid.
      @second: The solid being cut or the cutting solid.
      Throws ArgumentNullException: A non-optional argument was null
    static void SplitFacesOfCuttingSolid(Element first, Element second, bool split)
      Description: Causes the faces of the cutting element where it intersects the element it is cutting to be split or unsplit.
      @first: The solid being cut or the cutting solid
      @second: The solid being cut or the cutting solid
      @split: True to split the faces of intersection, false to unsplit them.
      Throws ArgumentException: There is no solid-solid cut between the input elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Unable to split or unsplit faces of cutting solid

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SolidUtils
Full Name: Autodesk.Revit.DB.SolidUtils
Description: Contains utility functions for solid operations.

  METHODS:
    static Solid Clone(Solid solid)
      Description: Creates a new Solid which is a copy of the input Solid.
      @solid: The input solid to be copied.
      Returns: The newly created Solid.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ComputeIsGeometricallyClosed(Solid geometry)
      Description: Computes whether the input Solid is geometrically closed to within Revit's tolerances.
      @geometry: The solid or shell geometry to test.
      Returns: True if the geometry is geometrically closed, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to compute whether the geometry is geometrically closed.
    static bool ComputeIsTopologicallyClosed(Solid geometry)
      Description: Compute whether the input Solid is topologically closed.
      @geometry: The solid or shell geometry to test.
      Returns: True if the geometry is topologically closed, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static Solid CreateTransformed(Solid solid, Transform transform)
      Description: Creates a new Solid which is the transformation of the input Solid.
      @solid: The input solid to be transformed.
      @transform: The transform (which must be conformal).
      Returns: The newly created Solid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: transform is not conformal. -or- transform has a scale that is negative or zero.
    static IList<EdgeEndPoint> FindAllEdgeEndPointsAtVertex(EdgeEndPoint edgeEndPoint)
      Description: Find all EdgeEndPoints at a vertex identified by the input EdgeEndPoint.
      @edgeEndPoint: The input EdgeEndPoint that identifies the vertex.
      Returns: All EdgeEndPoints at the vertex. The input EdgeEndPoint is also included.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to find all EdgeEndPoints at a vertex identified by the input EdgeEndPoint.
    static bool IsValidForTessellation(Solid solidOrShell)
      Description: Tests if the input solid or shell is valid for tessellation.
      @solidOrShell: The solid or shell.
      Returns: True if the solid or shell is valid for tessellation, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<Solid> SplitVolumes(Solid solid)
      Description: Splits a solid geometry into several separate solids.
      @solid: The solid.
      Returns: The split solid geometries.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to split the solid geometry.
    static TriangulatedSolidOrShell TessellateSolidOrShell(Solid solidOrShell, SolidOrShellTessellationControls tessellationControls)
      Description: This function facets (i.e., triangulates) a solid or an open shell. Each boundary component of the solid or shell is represented by a single triangulated structure.
      @solidOrShell: The solid or shell to be faceted.
      @tessellationControls: This input controls various aspects of the triangulation.
      Returns: The triangulated structures corresponding to the boundary components of the input solid or the components of the input shell.
      Throws ArgumentException: solidOrShell is not valid for triangulation (for example, it contains no faces).
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Unable to triangulate the solid or shell.

--------------------------------------------------------------------------------

[ENUM] SortingOrder
Full Name: Autodesk.Revit.DB.SortingOrder
Description: Enumerated type representing the sorting order of a collection of objects.
Inherits: Enum

  Values:
    - Ascending = 1
    - Descending = 2

--------------------------------------------------------------------------------

[CLASS] SpacingRule
Full Name: Autodesk.Revit.DB.SpacingRule
Description: A rule for specifying a set of equidistant, parallel gridlines within a region.
Inherits: APIObject

  PROPERTIES:
    double BeltMeasurement { get; set; }
      Description: On a curved surface, BeltMeasurement specifies where the grid's distances are measured.
    double Distance { get; set; }
      Description: The exact distance between layout lines.
    double GridlinesRotation { get; set; }
      Description: An additional rotation to be applied to this set of grid lines.
    bool HasBeltMeasurement { get; }
      Description: True if the gridlines are not parallel due to surface curvature, and the BeltMeasurement property therefore applies.
    SpacingRuleJustification Justification { get; set; }
      Description: The justification of the lines within the region.
    SpacingRuleLayout Layout { get; }
      Description: A choice of several gridline layout rules.
    int Number { get; set; }
      Description: The exact number of lines in the region.
    double Offset { get; set; }
      Description: An additional offset applied to the first gridline.

  METHODS:
    void SetLayoutFixedDistance(double distance, SpacingRuleJustification just, double gridlinesRotation, double offset)
      Description: Set the Layout property to FixedDistance.
    void SetLayoutFixedNumber(int number, SpacingRuleJustification just, double gridlinesRotation, double offset)
      Description: Set the Layout property to FixedNumber.
    void SetLayoutMaximumSpacing(double distance, SpacingRuleJustification just, double gridlinesRotation, double offset)
      Description: Set the Layout property to MaximumSpacing.
    void SetLayoutMinimumSpacing(double distance, SpacingRuleJustification just, double gridlinesRotation, double offset)
      Description: Set the Layout property to MinimumSpacing.
    void SetLayoutNone()
      Description: Set the Layout property to None.

--------------------------------------------------------------------------------

[ENUM] SpacingRuleJustification
Full Name: Autodesk.Revit.DB.SpacingRuleJustification
Description: Justification property of spacing rule
Inherits: Enum

  Values:
    - Center = 2
    - Beginning = 4
    - End = 5

--------------------------------------------------------------------------------

[ENUM] SpacingRuleLayout
Full Name: Autodesk.Revit.DB.SpacingRuleLayout
Description: Rules for laying out a series of equidistant points or parallel lines
Inherits: Enum

  Values:
    - None = 0
    - FixedDistance = 1
    - FixedNumber = 2
    - MaximumSpacing = 3
    - MinimumSpacing = 5

--------------------------------------------------------------------------------

[CLASS] SpanDirectionSymbol
Full Name: Autodesk.Revit.DB.SpanDirectionSymbol
Description: Represents an instance of a Span Direction Symbol in Autodesk Revit.
Inherits: IndependentTag

  METHODS:
    static SpanDirectionSymbol Create(Document document, ElementId viewId, LinkElementId elemIdToTag, XYZ headPosistion, ElementId symbolId)
      Description: Places a new instance of the Span Direction Symbol into the project relative to a particular host element and view.
      @document: The document.
      @viewId: The id of the view in which the symbol should appear.
      @elemIdToTag: The ElementId of a Floor (either in the document or linked from another document).
      @headPosistion: The span symbol's head position.
      @symbolId: The id of the family symbol of this span symbol.
      Returns: Returns the newly created symbol.
      Throws ArgumentException: The specified viewId should represent a Plan View. -or- The specified elemIdToTag should represent a Floor element. -or- The specified symbolId isn't valid. It should be a FamilySymbol of OST_SpanDirectionSymbol category.
      Throws ArgumentNullException: A non-optional argument was null
    static XYZ GetDefaultPlacementPoint(Document document, LinkElementId elemIdToTag)
      Description: Gets the default placement point for the input element. The default position is in the middle of the bounding box of the top face.
      @document: The document.
      @elemIdToTag: The ElementId of a Floor (either in the document or linked from another document).
      Returns: Returns the default placement point for the input element. The default position is in the middle of the bounding box of the top face.
      Throws ArgumentException: The specified elemIdToTag should represent a Floor element.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] SpatialElement
Full Name: Autodesk.Revit.DB.SpatialElement
Description: Represents an enclosed area or volume in the Revit model.
Inherits: Element

  PROPERTIES:
    double Area { get; }
      Description: The area.
    Level Level { get; }
      Description: Gets the level of the room.
    Location Location { get; }
      Description: The location of the element.
    string Name { set; }
      Description: A human readable name for the Element.
    string Number { get; set; }
      Description: The number.
    double Perimeter { get; }
      Description: The perimeter.
    SpatialElementType SpatialElementType { get; }
      Description: The spatial element type.

  METHODS:
    IList<IList<BoundarySegment>> GetBoundarySegments(SpatialElementBoundaryOptions options)
      Description: Returns the boundary segments.
      @options: The SpatialElementBoundaryOptions.
    XYZ GetDefaultLocation()
      Description: Gets the default location of the spatial element.
      Returns: The default location of the spatial element.
      Throws InvalidOperationException: The spatial element does not have a valid default location.
    SpatialElementDomainData GetSpatialElementDomainData()
      Description: Gets the domain data for the spatial element. The domain data contains information of different spatial elements, such as electrical load area. Currently room/space/area don't have domain data.
      Returns: Returns a pointer to the base class for specific domain requirements for the spatial element.
    void Recenter()
      Description: Moves the spatial element to its default location.
      Throws InvalidOperationException: The spatial element does not have a valid default location.

--------------------------------------------------------------------------------

[ENUM] SpatialElementBoundaryLocation
Full Name: Autodesk.Revit.DB.SpatialElementBoundaryLocation
Description: An enumerated type listing boundary options of spatial element geometry calculation.
Inherits: Enum

  Values:
    - Finish = 0
    - Center = 1
    - CoreBoundary = 2
    - CoreCenter = 3

--------------------------------------------------------------------------------

[CLASS] SpatialElementBoundaryOptions
Full Name: Autodesk.Revit.DB.SpatialElementBoundaryOptions
Description: Options that can be passed to a SpatialElementBoundaryCalculator to influence the results of the calculation.
Implements: IDisposable

  CONSTRUCTORS:
    new SpatialElementBoundaryOptions()
      Description: Constructs default options for calculation of the geometry of spatial elements (rooms, spaces).

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SpatialElementBoundaryLocation SpatialElementBoundaryLocation { get; set; }
      Description: The boundary of spatial element for geometry calculation.
    bool StoreFreeBoundaryFaces { get; set; }
      Description: Indicates whether to include the free boundary faces in the result.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SpatialElementBoundarySubface
Full Name: Autodesk.Revit.DB.SpatialElementBoundarySubface
Description: SpatialElementBoundarySubface represents the geometry boundary information of spatial element.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    LinkElementId SpatialBoundaryElement { get; }
      Description: Element that gave rise to this room face.
    bool SubfaceArisesFromElementFace { get; }
      Description: Indicates if the subface is coincident with a portion of a (possibly offset) face of the element.
    SubfaceType SubfaceType { get; }
      Description: Type of the subface.
    bool Valid { get; }
      Description: Indicates if the subface instance is valid and can be used.

  METHODS:
    void Dispose()
    Face GetBoundingElementFace()
      Description: Returns the face of the bounding element.
      Returns: The face of the bounding element.
    Face GetSpatialElementFace()
      Description: Returns the face of the spatial element's 3D geometry.
      Returns: The face of the spatial element's 3D geometry.
    Face GetSubface()
      Description: Returns a face that represents the portion of the room face bounded by the boundary element.
      Returns: The sub-face.

--------------------------------------------------------------------------------

[CLASS] SpatialElementCalculationLocation
Full Name: Autodesk.Revit.DB.SpatialElementCalculationLocation
Description: The Spatial Element Calculation Location is used to specify the room/space where an element should be considered as placed.
Remarks: It currently has two types of calculation location: SpatialElementCalculationPoint and SpatialElementFromToCalculationPoints A user can turn on the Spatial Element Calculation Location in the family editor by setting the family's ROOM_CALCULATION_POINT parameter. A user can move the location of the Spatial Element Calculation Location in the family editor. A user can visually verify the location of the Spatial Element Calculation Point by selecting the fixture in the project.
Inherits: Element

  PROPERTIES:
    XYZ MarkerPosition { get; }
      Description: The position of the spatial element calculation location marker.

--------------------------------------------------------------------------------

[CLASS] SpatialElementCalculationPoint
Full Name: Autodesk.Revit.DB.SpatialElementCalculationPoint
Description: SpatialElementCalculationPoint is used as the search point for family instances placement inside rooms and spaces.
Remarks: The Spatial Element Calculation Point is graphically showed as a location point marker with a "snake" line from the origin of the family. If the Spatial Element Calculation Point is turned on, this point will be used as a search point for room and space relations for all instances of this family.
Inherits: SpatialElementCalculationLocation

  PROPERTIES:
    XYZ Position { get; set; }
      Description: The position of the "in" spatial element calculation point.

--------------------------------------------------------------------------------

[CLASS] SpatialElementDomainData
Full Name: Autodesk.Revit.DB.SpatialElementDomainData
Description: A base class for specific domain requirements for a spatial element.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SpatialElementFromToCalculationPoints
Full Name: Autodesk.Revit.DB.SpatialElementFromToCalculationPoints
Description: SpatialElementFromToCalculationPoints is used to specify the search points for a family instance which connects two rooms or spaces, such as a door or window. The points determine which room or space is considered the "from" and which is considered the "to".
Inherits: SpatialElementCalculationLocation

  PROPERTIES:
    XYZ FromPosition { get; set; }
      Description: The "from" position of spatial element connecting calculation point.
    XYZ ToPosition { get; set; }
      Description: The "to" position of spatial element connecting calculation point.

  METHODS:
    void Flip()
      Description: flip the direction of the "from" and "to" points
    bool IsAcceptableFromPosition(XYZ fromPosition)
      Description: Checks whether a given "from" position is valid.
      Returns: True if the input is an acceptable "from" position and False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAcceptableToPosition(XYZ toPosition)
      Description: Checks whether a given "to" position is valid.
      Returns: True if the input is an acceptable "to" position and False otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    XYZ MakeFromPositionAcceptable(XYZ newFromLocation)
      Description: This function takes a potential "from" point and converts it to be a similar point on the opposite side of the family's host from the "to" point if necessary.
      @newFromLocation: The desired "from" location
      Returns: The valid "from" location.
      Throws ArgumentNullException: A non-optional argument was null
    XYZ MakeToPositionAcceptable(XYZ newToLocation)
      Description: This function takes a potential "to" point and converts it to be a similar point on the opposite side of the family's host from the "from" point if necessary.
      @newToLocation: The desired "to" location
      Returns: The valid "to" location.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] SpatialElementGeometryCalculator
Full Name: Autodesk.Revit.DB.SpatialElementGeometryCalculator
Description: Use this class to calculate the geometry of a spatial element and obtain the relationships between the geometry and the element's boundary elements.
Remarks: This class maintains an internal cache for geometry it has already processed. If you intend to calculate geometry for several elements in the same project you should use a single instance of this class. Note that the cache will be cleared when any change is made to the document.
Implements: IDisposable

  CONSTRUCTORS:
    new SpatialElementGeometryCalculator(Document aDoc, SpatialElementBoundaryOptions options)
      Description: Constructs a new calculator for the geometry of spatial elements.
      @aDoc: The document that contains the spatial elements.
      @options: The options to control the calculation rules.
      Throws ArgumentException: options is not valid. Only Finish and Center of SpatialElementBoundaryLocation are allowed.
      Throws ArgumentNullException: A non-optional argument was null
    new SpatialElementGeometryCalculator(Document aDoc)
      Description: Constructs a new calculator with default options for the geometry of spatial elements.
      @aDoc: The document that contains the spatial elements.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    SpatialElementGeometryResults CalculateSpatialElementGeometry(SpatialElement spatialElement)
      Description: Compute the spatial element geometry and returns the boundary face information.
      @spatialElement: Specifies the spatial element needs to be computed, should be Room or Space.
      Returns: Requested boundary face information.
      Throws ArgumentException: spatialElement is not a room or a space, and thus has no 3D geometry to calculate. -or- spatialElement is not enclosed in 2d or has no location, or the height is too small, and thus has no 3D geometry to calculate.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to compute the given spatial element's geometry.
    static bool CanCalculateGeometry(SpatialElement spatialElement)
      Description: This indicates whether the input spatial element is a valid one.
      @spatialElement: The spatial element to be checked if its geometry can be calculated.
      Returns: It will return false if the room/space is not enclosed in 2d or has no location, or the height is too small.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    SpatialElementBoundaryOptions GetOptions()
      Description: The options that control the calculation.
      Returns: The options.
    static bool IsRoomOrSpace(SpatialElement spatialElement)
      Description: This indicates whether the input spatial element is a room or a space.
      @spatialElement: The spatial element to be checked if it is a room or a space or not.
      Returns: True if the input spatial element is a room or a space, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] SpatialElementGeometryResults
Full Name: Autodesk.Revit.DB.SpatialElementGeometryResults
Description: The results of spatial element geometry calculation.
Remarks: The subfaces of a SpatialElement at the base height and top height are not associated with floors, roofs, and ceilings at the same height.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<SpatialElementBoundarySubface> GetBoundaryFaceInfo(Face face)
      Description: Query the spatial element boundary face information with the given face.
      @face: The face from the spatial element's geometry.
      Returns: Sub-faces related to the room bounding elements that define the spatial element face. Returns if there is no corresponding boundary information with the given face.
      Throws ArgumentNullException: A non-optional argument was null
    Solid GetGeometry()
      Description: The solid from the spatial element.
      Returns: Requested solid.

--------------------------------------------------------------------------------

[CLASS] SpatialElementTag
Full Name: Autodesk.Revit.DB.SpatialElementTag
Description: A tag attached to a SpatialElement (room, space or area) in Autodesk Revit.
Remarks: SpatialElementTag is the base class for RoomTag, SpaceTag and AreaTag. Zone tag is not derived from SpatialElementTag. See IndependentTag for more information.
Inherits: Element

  PROPERTIES:
    bool HasElbow { get; }
      Description: Identifies if the tag's leader has an elbow point or not.
    bool HasLeader { get; set; }
      Description: Identifies if a leader is displayed for the tag or not.
    bool IsOrphaned { get; }
      Description: Identifies if the tag is orphaned or not.
    bool IsTaggingLink { get; }
      Description: Identifies if the tag has reference to a spatial element in a linked document or not.
    XYZ LeaderElbow { get; set; }
      Description: The position of the leader's elbow (middle point).
    XYZ LeaderEnd { get; set; }
      Description: The position of the leader's end.
    XYZ LeaderStart { get; set; }
      Description: The leader start point for tags that use leader start condition Free.
    LeaderStartCondition LeaderStartCondition { get; set; }
      Description: The leader start condition of the tag, such as if the start of the leader is attached to the tag head or free floating.
    Location Location { get; }
      Description: The location of the tag.
    double RotationAngle { get; set; }
      Description: The rotation angle of the tag relative to its view
    XYZ TagHeadPosition { get; set; }
      Description: The position of the tag's head.
    SpatialElementTagOrientation TagOrientation { get; set; }
      Description: The orientation of the tag.
    string TagText { get; }
      Description: The text displayed by the tag.
    View View { get; }
      Description: The view in which the tag was placed.

  METHODS:
    void MoveToReferenceLocation()
      Description: Moves the SpatialElementTag to the location of SpatialElement that the tag is associated with.

--------------------------------------------------------------------------------

[ENUM] SpatialElementTagOrientation
Full Name: Autodesk.Revit.DB.SpatialElementTagOrientation
Description: An enumerated type listing tag orientation options that are supported by SpatialElementTags.
Inherits: Enum

  Values:
    - Horizontal = 0
    - Vertical = 1
    - Model = 2

--------------------------------------------------------------------------------

[ENUM] SpatialElementType
Full Name: Autodesk.Revit.DB.SpatialElementType
Description: An enumerated type listing types of spaces.
Inherits: Enum

  Values:
    - Room = 1
    - Area = 2
    - Space = 3
    - ElectricalLoadArea = 4

--------------------------------------------------------------------------------

[ENUM] SpecialType
Full Name: Autodesk.Revit.DB.SpecialType
Description: An enumerated type listing special types that can appear in an ExportLayerTable. These types do not represent an independent category in Revit, but can be mapped to specific layers on export.
Inherits: Enum

  Values:
    - InteriorWall = 1
    - ExteriorWall = 2
    - FoundationWall = 3
    - RetainingWall = 4
    - Default = -1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SpecTypeId
Full Name: Autodesk.Revit.DB.SpecTypeId
Description: This class contains constants identifying specs.

  PROPERTIES:
    static ForgeTypeId Acceleration { get; }
      Description: Acceleration, in discipline Structural.
    static ForgeTypeId AirFlow { get; }
      Description: Air Flow, in discipline HVAC.
    static ForgeTypeId AirFlowDensity { get; }
      Description: Air Flow Density, in discipline HVAC.
    static ForgeTypeId AirFlowDividedByCoolingLoad { get; }
      Description: Air Flow divided by Cooling Load, in discipline HVAC.
    static ForgeTypeId AirFlowDividedByVolume { get; }
      Description: Air Flow divided by Volume, in discipline HVAC.
    static ForgeTypeId Angle { get; }
      Description: Angle, in discipline Common.
    static ForgeTypeId AngularSpeed { get; }
      Description: Angular Speed, in discipline HVAC.
    static ForgeTypeId ApparentPower { get; }
      Description: Apparent Power, in discipline Electrical.
    static ForgeTypeId ApparentPowerDensity { get; }
      Description: Apparent Power Density, in discipline Electrical.
    static ForgeTypeId Area { get; }
      Description: Area, in discipline Common.
    static ForgeTypeId AreaDividedByCoolingLoad { get; }
      Description: Area divided by Cooling Load, in discipline HVAC.
    static ForgeTypeId AreaDividedByHeatingLoad { get; }
      Description: Area divided by Heating Load, in discipline HVAC.
    static ForgeTypeId AreaForce { get; }
      Description: Area Force, in discipline Structural.
    static ForgeTypeId AreaForceScale { get; }
      Description: Area Force Scale, in discipline Structural.
    static ForgeTypeId AreaSpringCoefficient { get; }
      Description: Area Spring Coefficient, in discipline Structural.
    static ForgeTypeId BarDiameter { get; }
      Description: Bar Diameter, in discipline Structural.
    static ForgeTypeId CableTraySize { get; }
      Description: Cable Tray Size, in discipline Electrical.
    static ForgeTypeId ColorTemperature { get; }
      Description: Color Temperature, in discipline Electrical.
    static ForgeTypeId ConduitSize { get; }
      Description: Conduit Size, in discipline Electrical.
    static ForgeTypeId CoolingLoad { get; }
      Description: Cooling Load, in discipline HVAC.
    static ForgeTypeId CoolingLoadDividedByArea { get; }
      Description: Cooling Load divided by Area, in discipline HVAC.
    static ForgeTypeId CoolingLoadDividedByVolume { get; }
      Description: Cooling Load divided by Volume, in discipline HVAC.
    static ForgeTypeId CostPerArea { get; }
      Description: Cost per Area, in discipline Common.
    static ForgeTypeId CostRateEnergy { get; }
      Description: Cost Rate Energy, in discipline Electrical.
    static ForgeTypeId CostRatePower { get; }
      Description: Cost Rate Power, in discipline Electrical.
    static ForgeTypeId CrackWidth { get; }
      Description: Crack Width, in discipline Structural.
    static ForgeTypeId CrossSection { get; }
      Description: Cross Section, in discipline HVAC.
    static ForgeTypeId Currency { get; }
      Description: Currency, in discipline Common.
    static ForgeTypeId Current { get; }
      Description: Current, in discipline Electrical.
    static ForgeTypeId Custom { get; }
      Description: Unrecognized custom spec.
    static ForgeTypeId DecimalSheetLength { get; }
      Description: Decimal Sheet Length, in discipline Common.
    static ForgeTypeId DemandFactor { get; }
      Description: Demand Factor, in discipline Electrical.
    static ForgeTypeId Diffusivity { get; }
      Description: Diffusivity, in discipline HVAC.
    static ForgeTypeId Displacement { get; }
      Description: Displacement/Deflection, in discipline Structural.
    static ForgeTypeId Distance { get; }
      Description: Distance, in discipline Common.
    static ForgeTypeId DuctInsulationThickness { get; }
      Description: Duct Insulation Thickness, in discipline HVAC.
    static ForgeTypeId DuctLiningThickness { get; }
      Description: Duct Lining Thickness, in discipline HVAC.
    static ForgeTypeId DuctSize { get; }
      Description: Duct Size, in discipline HVAC.
    static ForgeTypeId Efficacy { get; }
      Description: Efficacy, in discipline Electrical.
    static ForgeTypeId ElectricalFrequency { get; }
      Description: Frequency, in discipline Electrical.
    static ForgeTypeId ElectricalPotential { get; }
      Description: Electrical Potential, in discipline Electrical.
    static ForgeTypeId ElectricalPower { get; }
      Description: Power, in discipline Electrical.
    static ForgeTypeId ElectricalPowerDensity { get; }
      Description: Power Density, in discipline Electrical.
    static ForgeTypeId ElectricalResistivity { get; }
      Description: Electrical Resistivity, in discipline Electrical.
    static ForgeTypeId ElectricalTemperature { get; }
      Description: Temperature, in discipline Electrical.
    static ForgeTypeId ElectricalTemperatureDifference { get; }
      Description: Temperature Difference, in discipline Electrical.
    static ForgeTypeId Energy { get; }
      Description: Energy, in discipline Structural.
    static ForgeTypeId Factor { get; }
      Description: Factor, in discipline HVAC.
    static ForgeTypeId Flow { get; }
      Description: Flow, in discipline Piping.
    static ForgeTypeId FlowPerPower { get; }
      Description: Flow per Power, in discipline HVAC.
    static ForgeTypeId Force { get; }
      Description: Force, in discipline Structural.
    static ForgeTypeId ForceScale { get; }
      Description: Force Scale, in discipline Structural.
    static ForgeTypeId HeatCapacityPerArea { get; }
      Description: Heat Capacity per Area, in discipline Energy.
    static ForgeTypeId HeatGain { get; }
      Description: Heat Gain, in discipline HVAC.
    static ForgeTypeId HeatingLoad { get; }
      Description: Heating Load, in discipline HVAC.
    static ForgeTypeId HeatingLoadDividedByArea { get; }
      Description: Heating Load divided by Area, in discipline HVAC.
    static ForgeTypeId HeatingLoadDividedByVolume { get; }
      Description: Heating Load divided by Volume, in discipline HVAC.
    static ForgeTypeId HeatTransferCoefficient { get; }
      Description: Coefficient of Heat Transfer, in discipline Energy.
    static ForgeTypeId HvacDensity { get; }
      Description: Density, in discipline HVAC.
    static ForgeTypeId HvacEnergy { get; }
      Description: Energy, in discipline Energy.
    static ForgeTypeId HvacFriction { get; }
      Description: Friction, in discipline HVAC.
    static ForgeTypeId HvacMassPerTime { get; }
      Description: Mass per Time, in discipline HVAC.
    static ForgeTypeId HvacPower { get; }
      Description: Power, in discipline HVAC.
    static ForgeTypeId HvacPowerDensity { get; }
      Description: Power Density, in discipline HVAC.
    static ForgeTypeId HvacPressure { get; }
      Description: Pressure, in discipline HVAC.
    static ForgeTypeId HvacRoughness { get; }
      Description: Roughness, in discipline HVAC.
    static ForgeTypeId HvacSlope { get; }
      Description: Slope, in discipline HVAC.
    static ForgeTypeId HvacTemperature { get; }
      Description: Temperature, in discipline HVAC.
    static ForgeTypeId HvacTemperatureDifference { get; }
      Description: Temperature Difference, in discipline HVAC.
    static ForgeTypeId HvacVelocity { get; }
      Description: Velocity, in discipline HVAC.
    static ForgeTypeId HvacViscosity { get; }
      Description: Dynamic Viscosity, in discipline HVAC.
    static ForgeTypeId Illuminance { get; }
      Description: Illuminance, in discipline Electrical.
    static ForgeTypeId IsothermalMoistureCapacity { get; }
      Description: Isothermal Moisture Capacity, in discipline Energy.
    static ForgeTypeId Length { get; }
      Description: Length, in discipline Common.
    static ForgeTypeId LinearForce { get; }
      Description: Linear Force, in discipline Structural.
    static ForgeTypeId LinearForceScale { get; }
      Description: Linear Force Scale, in discipline Structural.
    static ForgeTypeId LinearMoment { get; }
      Description: Linear Moment, in discipline Structural.
    static ForgeTypeId LinearMomentScale { get; }
      Description: Linear Moment Scale, in discipline Structural.
    static ForgeTypeId LineSpringCoefficient { get; }
      Description: Line Spring Coefficient, in discipline Structural.
    static ForgeTypeId Luminance { get; }
      Description: Luminance, in discipline Electrical.
    static ForgeTypeId LuminousFlux { get; }
      Description: Luminous Flux, in discipline Electrical.
    static ForgeTypeId LuminousIntensity { get; }
      Description: Luminous Intensity, in discipline Electrical.
    static ForgeTypeId Mass { get; }
      Description: Mass, in discipline Structural.
    static ForgeTypeId MassDensity { get; }
      Description: Mass Density, in discipline Common.
    static ForgeTypeId MassEquivalentPerItem { get; }
      Description: Mass Equivalent per item.
    static ForgeTypeId MassEquivalentPerUnitArea { get; }
      Description: Mass Equivalent per Unit Area.
    static ForgeTypeId MassEquivalentPerUnitEnergy { get; }
      Description: Mass Equivalent per Unit Energy.
    static ForgeTypeId MassEquivalentPerUnitLength { get; }
      Description: Mass Equivalent per Unit Length.
    static ForgeTypeId MassEquivalentPerUnitMass { get; }
      Description: Mass Equivalent per Unit Mass.
    static ForgeTypeId MassEquivalentPerUnitVolume { get; }
      Description: Mass Equivalent per Unit Volume.
    static ForgeTypeId MassPerUnitArea { get; }
      Description: Mass per Unit Area, in discipline Structural.
    static ForgeTypeId MassPerUnitLength { get; }
      Description: Mass per Unit Length, in discipline Structural.
    static ForgeTypeId Moment { get; }
      Description: Moment, in discipline Structural.
    static ForgeTypeId MomentOfInertia { get; }
      Description: Moment of Inertia, in discipline Structural.
    static ForgeTypeId MomentScale { get; }
      Description: Moment Scale, in discipline Structural.
    static ForgeTypeId Number { get; }
      Description: Number, in discipline Common.
    static ForgeTypeId Period { get; }
      Description: Period, in discipline Structural.
    static ForgeTypeId Permeability { get; }
      Description: Permeability, in discipline Energy.
    static ForgeTypeId PipeDimension { get; }
      Description: Pipe Dimension, in discipline Piping.
    static ForgeTypeId PipeInsulationThickness { get; }
      Description: Pipe Insulation Thickness, in discipline Piping.
    static ForgeTypeId PipeMassPerUnitLength { get; }
      Description: Mass per Unit Length, in discipline Piping.
    static ForgeTypeId PipeSize { get; }
      Description: Pipe Size, in discipline Piping.
    static ForgeTypeId PipingDensity { get; }
      Description: Density, in discipline Piping.
    static ForgeTypeId PipingFriction { get; }
      Description: Friction, in discipline Piping.
    static ForgeTypeId PipingMass { get; }
      Description: Mass, in discipline Piping.
    static ForgeTypeId PipingMassPerTime { get; }
      Description: Mass per Time, in discipline Piping.
    static ForgeTypeId PipingPressure { get; }
      Description: Pressure, in discipline Piping.
    static ForgeTypeId PipingRoughness { get; }
      Description: Roughness, in discipline Piping.
    static ForgeTypeId PipingSlope { get; }
      Description: Slope, in discipline Piping.
    static ForgeTypeId PipingTemperature { get; }
      Description: Temperature, in discipline Piping.
    static ForgeTypeId PipingTemperatureDifference { get; }
      Description: Temperature Difference, in discipline Piping.
    static ForgeTypeId PipingVelocity { get; }
      Description: Velocity, in discipline Piping.
    static ForgeTypeId PipingViscosity { get; }
      Description: Dynamic Viscosity, in discipline Piping.
    static ForgeTypeId PipingVolume { get; }
      Description: Volume, in discipline Piping.
    static ForgeTypeId PointSpringCoefficient { get; }
      Description: Point Spring Coefficient, in discipline Structural.
    static ForgeTypeId PowerPerFlow { get; }
      Description: Power per Flow, in discipline HVAC.
    static ForgeTypeId PowerPerLength { get; }
      Description: Power per Length, in discipline Electrical.
    static ForgeTypeId Pulsation { get; }
      Description: Pulsation, in discipline Structural.
    static ForgeTypeId ReinforcementArea { get; }
      Description: Reinforcement Area, in discipline Structural.
    static ForgeTypeId ReinforcementAreaPerUnitLength { get; }
      Description: Reinforcement Area per Unit Length, in discipline Structural.
    static ForgeTypeId ReinforcementCover { get; }
      Description: Reinforcement Cover, in discipline Structural.
    static ForgeTypeId ReinforcementLength { get; }
      Description: Reinforcement Length, in discipline Structural.
    static ForgeTypeId ReinforcementSpacing { get; }
      Description: Reinforcement Spacing, in discipline Structural.
    static ForgeTypeId ReinforcementVolume { get; }
      Description: Reinforcement Volume, in discipline Structural.
    static ForgeTypeId Rotation { get; }
      Description: Rotation, in discipline Structural.
    static ForgeTypeId RotationalLineSpringCoefficient { get; }
      Description: Rotational Line Spring Coefficient, in discipline Structural.
    static ForgeTypeId RotationalPointSpringCoefficient { get; }
      Description: Rotational Point Spring Coefficient, in discipline Structural.
    static ForgeTypeId RotationAngle { get; }
      Description: Rotation Angle, in discipline Common.
    static ForgeTypeId SectionArea { get; }
      Description: Section Area, in discipline Structural.
    static ForgeTypeId SectionDimension { get; }
      Description: Section Dimension, in discipline Structural.
    static ForgeTypeId SectionModulus { get; }
      Description: Section Modulus, in discipline Structural.
    static ForgeTypeId SectionProperty { get; }
      Description: Section Property, in discipline Structural.
    static ForgeTypeId SheetLength { get; }
      Description: Sheet Length, in discipline Common.
    static ForgeTypeId SiteAngle { get; }
      Description: Site Angle, in discipline Common.
    static ForgeTypeId Slope { get; }
      Description: Slope, in discipline Common.
    static ForgeTypeId SpecificHeat { get; }
      Description: Specific Heat, in discipline Energy.
    static ForgeTypeId SpecificHeatOfVaporization { get; }
      Description: Specific Heat of Vaporization, in discipline Energy.
    static ForgeTypeId Speed { get; }
      Description: Speed, in discipline Common.
    static ForgeTypeId Stationing { get; }
      Description: Stationing, in discipline Infrastructure.
    static ForgeTypeId StationingInterval { get; }
      Description: Stationing Interval, in discipline Infrastructure.
    static ForgeTypeId Stress { get; }
      Description: Stress, in discipline Structural.
    static ForgeTypeId StructuralFrequency { get; }
      Description: Frequency, in discipline Structural.
    static ForgeTypeId StructuralVelocity { get; }
      Description: Velocity, in discipline Structural.
    static ForgeTypeId SurfaceAreaPerUnitLength { get; }
      Description: Surface Area per Unit Length, in discipline Structural.
    static ForgeTypeId ThermalConductivity { get; }
      Description: Thermal Conductivity, in discipline Energy.
    static ForgeTypeId ThermalExpansionCoefficient { get; }
      Description: Thermal Expansion Coefficient, in discipline Structural.
    static ForgeTypeId ThermalGradientCoefficientForMoistureCapacity { get; }
      Description: Thermal Gradient Coefficient for Moisture Capacity, in discipline Energy.
    static ForgeTypeId ThermalMass { get; }
      Description: Thermal Mass, in discipline Energy.
    static ForgeTypeId ThermalResistance { get; }
      Description: Thermal Resistance, in discipline Energy.
    static ForgeTypeId Time { get; }
      Description: Time, in discipline Common.
    static ForgeTypeId UnitWeight { get; }
      Description: Unit Weight, in discipline Structural.
    static ForgeTypeId Volume { get; }
      Description: Volume, in discipline Common.
    static ForgeTypeId WarpingConstant { get; }
      Description: Warping Constant, in discipline Structural.
    static ForgeTypeId Wattage { get; }
      Description: Wattage, in discipline Electrical.
    static ForgeTypeId Weight { get; }
      Description: Weight, in discipline Structural.
    static ForgeTypeId WeightPerUnitLength { get; }
      Description: Weight per Unit Length, in discipline Structural.
    static ForgeTypeId WireDiameter { get; }
      Description: Wire Diameter, in discipline Electrical.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SpecUtils
Full Name: Autodesk.Revit.DB.SpecUtils
Description: A utility class of functions related to specs. A spec describes a data type that parameters can hold.

  METHODS:
    static IList<ForgeTypeId> GetAllSpecs()
      Description: Gets the identifiers of all specs.
      Returns: The spec identifiers.
    static bool IsSpec(ForgeTypeId specTypeId)
      Description: Checks whether a ForgeTypeId identifies a spec.
      @specTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a spec, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidDataType(ForgeTypeId dataType)
      Description: Returns true if the given ForgeTypeId identifies a valid parameter data type.
      @dataType: The identifier to check.
      Returns: True if the ForgeTypeId identifies either a spec or a category, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] SpotDimension
Full Name: Autodesk.Revit.DB.SpotDimension
Description: Object representing various types of SpotDimension
Inherits: Dimension

  PROPERTIES:
    bool LeaderHasShoulder { get; set; }
      Description: True is dimension has leader with shoulder, false otherwise.
    XYZ LeaderShoulderPosition { get; set; }
      Description: Position of spot dimension's leader shoulder point.
    SpotDimensionType SpotDimensionType { get; set; }
      Description: The dimension style of this dimension.

  METHODS:
    bool CanFlip()
      Description: Verifies that the direction of the dimension can be flipped.
      Returns: True if the element can be flipped, false otherwise.
    void Flip()
      Description: Flips dimension to the other side of the host.
      Throws InvalidOperationException: SpotDimension cannot be flipped.

--------------------------------------------------------------------------------

[CLASS] SpotDimensionType
Full Name: Autodesk.Revit.DB.SpotDimensionType
Description: A type element containing the properties of a spot elevation.
Inherits: DimensionType

--------------------------------------------------------------------------------

[CLASS] SSEPointVisibilitySettings
Full Name: Autodesk.Revit.DB.SSEPointVisibilitySettings
Description: Represents the settings contained in the document associated to the point display of Floor, Roof and Toposolid. for serialization public api methods
Inherits: Element

  METHODS:
    static bool GetVisibility(Document document, ElementId categoryId)
      Description: Gets the SSE point visibility for the given category.
      @document: The document.
      @categoryId: The category id.
      Returns: The visibility of the given category. True means the SSE points are visible.
      Throws ArgumentException: The category is not valid for SSE.
      Throws ArgumentNullException: A non-optional argument was null
    static void SetVisibility(Document document, ElementId categoryId, bool isVisible)
      Description: Sets the SSE point visibility for the given category.
      @document: The document.
      @categoryId: The category id.
      @isVisible: The visibility of the given category. True means the SSE points are visible.
      Throws ArgumentException: The category is not valid for SSE.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] StairsEditScope
Full Name: Autodesk.Revit.DB.StairsEditScope
Description: StairsEditScope allows user to maintain a stairs-editing session.
Remarks: Start/end of a StairsEditScope will start/end a transaction group. After a StairsEditScope is started, user can start transactions and edit the stairs. Individual transactions the user creates inside StairsEditScope will not appear in the undo menu. All transactions committed during the edit mode will be merged into a single one which will bear the given name passed into StairsEditScope constructor.
Inherits: EditScope

  CONSTRUCTORS:
    new StairsEditScope(Document document, string transactionName)
      Description: Instantiates a StairsEditScope object.
      @document: The document for which this StairsEditScope is going to be used.
      @transactionName: The name that will appear in the Undo menu in Revit after the StairsEditScope is successfully committed.
      Throws ArgumentException: document is not a primary document, it is a linked document. -or- document is not a project document. -or- transactionName is an empty string.
      Throws ArgumentNullException: A non-optional argument was null

  METHODS:
    ElementId Start(ElementId stairsId)
      Description: Starts an stairs edit mode for an existing Stairs element
      @stairsId: The stairs element to be edited.
      Returns: ElementId of the editing stairs. It should be the same as the input stairsId
      Throws ArgumentException: It is not a Stair's id. -or- Stairs is not permitted to edit at this moment for the following reason: The Stairs is in an ElementGroup and it is not in Edit Group Mode.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This StairsEditScope is not permitted to start at this moment for one of the following possible reasons: The document is in read-only state, or the document is currently modifiable, or there already is another edit mode active in the document.
    ElementId Start(ElementId baseLevelId, ElementId topLevelId)
      Description: Creates a new empty stairs element with a default stairs type in the specified levels and then starts stairs edit mode and editing the new stairs.
      @baseLevelId: The base level on which the stairs is to be placed.
      @topLevelId: The top level where the stairs is to reach.
      Returns: ElementId of the new stairs.
      Throws ArgumentException: It is not a Level's id. -or- Top level should be higher than base level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This StairsEditScope is not permitted to start at this moment for one of the following possible reasons: The document is in read-only state, or the document is currently modifiable, or there already is another edit mode active in the document.

--------------------------------------------------------------------------------

[CLASS] StartingViewSettings
Full Name: Autodesk.Revit.DB.StartingViewSettings
Description: The initial view settings for a document dictate which view will initially be open when this model is opened. These settings are available for all Revit project documents.
Remarks: If worksharing is enabled, the same settings will be used by the central model and all local files and the settings will live in the Project Info workset.
Inherits: Element

  PROPERTIES:
    ElementId ViewId { get; set; }
      Description: Indicates the specific view that will be opened when the model is loaded. InvalidElementId indicates that no view has been specified. In that case, Revit will open the last views that were open at the time the file was saved.

  METHODS:
    static StartingViewSettings GetStartingViewSettings(Document doc)
      Description: Returns the starting view settings for the specified document.
      @doc: The document to get the settings from, which must be a project document.
      Returns: The starting view settings for the document.
      Throws ArgumentException: doc is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAcceptableStartingView(ElementId viewId)
      Description: Checks whether the given Id is an acceptable starting view. InvalidElementId corresponds to "Last Viewed" and is therefore also acceptable.
      @viewId: The Id of the element to check.
      Returns: True if the view is acceptable, False if it is not.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] StdPostedWarning
Full Name: Autodesk.Revit.DB.StdPostedWarning
Description: Support for Reviewable Warnings sent from AddOn.
Remarks: Used to create and send Reviewable Warning from AddOn.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] STEPApplicationProtocol
Full Name: Autodesk.Revit.DB.STEPApplicationProtocol
Description: An enumeration for STEP Application Protocols.
Inherits: Enum

  Values:
    - ApplicationProtocol203 = 0
    - ApplicationProtocol214 = 1
    - ApplicationProtocol242 = 2

--------------------------------------------------------------------------------

[CLASS] STEPExportOptions
Full Name: Autodesk.Revit.DB.STEPExportOptions
Description: The export options used by exporting STEP format file.
Inherits: BIMExportOptions

  CONSTRUCTORS:
    new STEPExportOptions()
      Description: Constructs a new instance of STEPExportOptions with default values of all properties.

  PROPERTIES:
    STEPApplicationProtocol ApplicationProtocol { get; set; }
      Description: The Application Protocol of the exported STEP file.
    ExportUnit TargetUnit { get; set; }
      Description: The unit type of geometry in the resultant STEP file. Default value is ExportUnit::Default.

--------------------------------------------------------------------------------

[CLASS] STEPImportOptions
Full Name: Autodesk.Revit.DB.STEPImportOptions
Description: The import options used to import STEP format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new STEPImportOptions(STEPImportOptions option)
      Description: Constructs a new instance of STEPImportOptions as a copy of the import options.
      @option: The STEP options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new STEPImportOptions()
      Description: Constructs a new instance of STEPImportOptions with default values of all properties.

--------------------------------------------------------------------------------

[ENUM] StickSymbolLocation
Full Name: Autodesk.Revit.DB.StickSymbolLocation
Description: Indicates the stick symbol location on the UI, which is used for the BuiltInParameter STRUCTURAL_STICK_SYMBOL_LOCATION.
Inherits: Enum

  Values:
    - StickViewCenter = 0
    - StickViewTop = 1
    - StickViewBottom = 2
    - StickViewLocLine = 3

--------------------------------------------------------------------------------

[ENUM] StiffenerClassification
Full Name: Autodesk.Revit.DB.StiffenerClassification
Description: This enumeration is used to classify the stiffener.
Inherits: Enum

  Values:
    - External = 0
    - Internal = 1

--------------------------------------------------------------------------------

[CLASS] STLExportOptions
Full Name: Autodesk.Revit.DB.STLExportOptions
Description: The export options used by exporting STL format file.
Inherits: BIMExportOptions

  CONSTRUCTORS:
    new STLExportOptions(ExportResolution resolutionType)
      Description: Constructs a new instance of STLExportOptions with all predefined tessellation settings, depending on export resolution type. Note: in case of Custom resolution type, tessellation settings won't be predefined and will have default values.
      @resolutionType: The type of export resolution.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new STLExportOptions()
      Description: Constructs a new instance of STLExportOptions with default values of all properties.

  PROPERTIES:
    bool ExportBinary { get; set; }
      Description: True to export in binary STL format, false to export in ASCII STL format. Default value is true.
    bool ExportColor { get; set; }
      Description: True to export color information, false otherwise. Default value is false.
    double GridAspectRatio { get; set; }
      Description: The maximum aspect ratio allowed in the grid placed across the face. The minimum allowed value is 1.0. The maximum allowed value is 10.0. By default this property is ignored.
    double MaxEdgeLength { get; set; }
      Description: The maximum length allowed for any chord on an edge or between any two adjacent grid lines. This is a percentage value. By exporting, the real value of maximum edge length is calculated as a percent from the length of the diameter of the body bounding box. The minimum allowed value is 0.1%. The maximum allowed value is 10.0%. By default this property is ignored.
    double NormalTolerance { get; set; }
      Description: The maximum change in the surface normal between adjacent nodes in the mesh. This property is defined in degrees. The minimum allowed value is 1.0 degrees. The maximum allowed value is 45.0 degrees. Default value is 15.0 degrees.
    double SurfaceTolerance { get; set; }
      Description: The maximum distance between mesh triangles and model geometry. This is a percentage value. By exporting, the real value of surface tolerance is calculated as a percent from the length of the diameter of the body bounding box. The minimum allowed value is 0.001%. The maximum allowed value is 1.0%. Default value is 0.1%.
    ExportUnit TargetUnit { get; set; }
      Description: The unit type of geometry in the resultant STL file. Default value is ExportUnit::Default.

  METHODS:
    bool IsGridAspectRatioSet()
      Description: Checks whether the GridAspectRatio tessellation parameter is explicitly set.
      Returns: True if GridAspectRatio tessellation parameter is explicitly set, false otherwise.
    bool IsMaxEdgeLengthSet()
      Description: Checks whether the MaxEdgeLength tessellation parameter is explicitly set.
      Returns: True if MaxEdgeLength tessellation parameter is explicitly set, false otherwise.
    bool IsNormalToleranceSet()
      Description: Checks whether the NormalTolerance tessellation parameter is explicitly set.
      Returns: True if NormalTolerance tessellation parameter is explicitly set, false otherwise.
    bool IsSurfaceToleranceSet()
      Description: Checks whether the SurfaceTolerance tessellation parameter is explicitly set.
      Returns: True if SurfaceTolerance tessellation parameter is explicitly set, false otherwise.
    static bool IsValidForGridAspectRatio(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for GridAspectRatio tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for GridAspectRatio, false otherwise.
    static bool IsValidForMaxEdgeLength(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for MaxEdgeLength tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for MaxEdgeLength, false otherwise.
    static bool IsValidForNormalTolerance(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for NormalTolerance tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for NormalTolerance, false otherwise.
    static bool IsValidForSurfaceTolerance(double value)
      Description: Checks whether the value is allowed (is in the allowed range) for SurfaceTolerance tessellation parameter.
      @value: The value to be checked.
      Returns: True if the value is valid for SurfaceTolerance, false otherwise.
    void SetTessellationSettings(ExportResolution resolutionType)
      Description: Sets all the tessellation parameters to its predefined values for the given resolution type.
      @resolutionType: Type of exporting resolution.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] STLImportOptions
Full Name: Autodesk.Revit.DB.STLImportOptions
Description: The import options used to import STL format files.
Inherits: BaseImportOptions

  CONSTRUCTORS:
    new STLImportOptions(STLImportOptions option)
      Description: Constructs a new instance of STLImportOptions as a copy of the import options.
      @option: The STL options to be copied.
      Throws ArgumentNullException: A non-optional argument was null
    new STLImportOptions()
      Description: Constructs a new instance of STLImportOptions with default values of all properties.

--------------------------------------------------------------------------------

[ENUM] StorageType
Full Name: Autodesk.Revit.DB.StorageType
Description: An enumerated type listing all of the internal parameter data storage types that Autodesk Revit supports.
Inherits: Enum

  Values:
    - None = 0
    - Integer = 1
    - Double = 2
    - String = 3
    - ElementId = 4

--------------------------------------------------------------------------------

[CLASS] StringParameterValue
Full Name: Autodesk.Revit.DB.StringParameterValue
Description: A class that holds a String value of a parameter element.
Inherits: ParameterValue

  CONSTRUCTORS:
    new StringParameterValue(string value)
      Description: Value constructor
      Throws ArgumentNullException: A non-optional argument was null
    new StringParameterValue()
      Description: Default constructor

  PROPERTIES:
    string Value { get; set; }
      Description: The stored value

--------------------------------------------------------------------------------

[ENUM] StripedRowPattern
Full Name: Autodesk.Revit.DB.StripedRowPattern
Description: An enumerated type representing the possible sets of rows of a striped row schedule.
Inherits: Enum

  Values:
    - FirstRow = 0
    - SecondRow = 1

--------------------------------------------------------------------------------

[ENUM] StructDeckEmbeddingType
Full Name: Autodesk.Revit.DB.StructDeckEmbeddingType
Description: Used in class CompoundStructure to specify the usage of a layer whose function is StructuralDeck.
Inherits: Enum

  Values:
    - MergeWithLayerAbove = 0
    - Standalone = 1
    - Invalid = -1

--------------------------------------------------------------------------------

[CLASS] StructuralAsset
Full Name: Autodesk.Revit.DB.StructuralAsset
Description: Represents the properties of a material pertinent to structural analysis.
Implements: IDisposable

  CONSTRUCTORS:
    new StructuralAsset(string name, StructuralAssetClass structuralAssetClass)
      Description: Constructs an instance of StructuralAsset.
      @name: The name of the asset.
      @structuralAssetClass: The type of structural material that this asset will describe.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    StructuralBehavior Behavior { get; set; }
      Description: Flag indicating whether elements of this material behave isotropically or orthotropically.
    double ConcreteBendingReinforcement { get; set; }
      Description: The bending reinforcement of the asset.
    double ConcreteCompression { get; set; }
      Description: The compression strength of concrete-based assets.
    double ConcreteShearReinforcement { get; set; }
      Description: The shear reinforcement of the asset.
    double ConcreteShearStrengthReduction { get; set; }
      Description: The shear strength reduction of the asset.
    double Density { get; set; }
      Description: The density of the asset.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Lightweight { get; set; }
      Description: Flag indicating whether the asset describes a material that is light-weight or not.
    double MetalReductionFactor { get; set; }
      Description: The reduction factor of the asset.
    double MetalResistanceCalculationStrength { get; set; }
      Description: The resistance calculation strength of the asset.
    bool MetalThermallyTreated { get; set; }
      Description: Flag indicating whether the asset describes a material that is thermally treated or not.
    double MinimumTensileStrength { get; set; }
      Description: The minimum tensile strength of the asset.
    double MinimumYieldStress { get; set; }
      Description: The minimum yield stress of the asset.
    string Name { get; set; }
      Description: The name of the structural asset.
    XYZ PoissonRatio { get; set; }
      Description: The Poisson ratio of the asset.
    XYZ ShearModulus { get; set; }
      Description: The shear modulus of the asset.
    StructuralAssetClass StructuralAssetClass { get; }
      Description: The type of material that this structural asset describes (e.g. wood, concrete, metal.)
    string SubClass { get; set; }
      Description: The sub-class of the asset.
    XYZ ThermalExpansionCoefficient { get; set; }
      Description: The thermal expansion coefficient of the asset.
    double WoodBendingStrength { get; set; }
      Description: The bending strength of the asset.
    string WoodGrade { get; set; }
      Description: The grade of wood used in a wood-based asset.
    double WoodParallelCompressionStrength { get; set; }
      Description: The parallel compression strength of the asset.
    double WoodParallelShearStrength { get; set; }
      Description: The parallel shear strength of the asset.
    double WoodPerpendicularCompressionStrength { get; set; }
      Description: The perpendicular compression strength of the asset.
    double WoodPerpendicularShearStrength { get; set; }
      Description: The perpendicular shear strength of the asset.
    string WoodSpecies { get; set; }
      Description: The species of wood used in a wood-based asset.
    XYZ YoungModulus { get; set; }
      Description: The Young's modulus of the asset.

  METHODS:
    StructuralAsset Copy()
      Description: Produces a copy of the asset.
      Returns: A copy of the asset.
    void Dispose()
    bool Equals(StructuralAsset other)
      Description: Determines whether this structural asset is equal to another.
      @other: The structural asset with which to compare this structural asset.
      Returns: True if the given structural asset is equal to this one, otherwise false.
      Throws ArgumentNullException: A non-optional argument was null
    void SetPoissonRatio(double poissonRatio)
      Description: Sets the Poisson ratio of the asset.
    void SetShearModulus(double shearModulus)
      Description: Sets the shear modulus of the asset.
    void SetThermalExpansionCoefficient(double thermalExpCoeff)
      Description: Sets the thermal expansion coefficient of the asset.
    void SetYoungModulus(double youngModulus)
      Description: Sets the Young's modulus of the asset.

--------------------------------------------------------------------------------

[ENUM] StructuralAssetClass
Full Name: Autodesk.Revit.DB.StructuralAssetClass
Description: Represents the type of material described by a structural asset. This enum value is returned by Autodesk::Revit::DB::StructuralAsset::StructuralAssetClass.
Inherits: Enum

  Values:
    - Undefined = 0
    - Basic = 1
    - Generic = 2
    - Metal = 3
    - Concrete = 4
    - Wood = 5
    - Liquid = 6
    - Gas = 7
    - Plastic = 8

--------------------------------------------------------------------------------

[ENUM] StructuralBehavior
Full Name: Autodesk.Revit.DB.StructuralBehavior
Description: Specifies whether structural elements behave orthotropically, isotropically, or transverse-isotropically.
Inherits: Enum

  Values:
    - Isotropic = 0
    - Orthotropic = 1
    - TransverseIsotropic = 2

--------------------------------------------------------------------------------

[ENUM] StructuralReleaseType
Full Name: Autodesk.Revit.DB.StructuralReleaseType
Description: Type of structural release, which is used for the BuiltIn parameter STRUCTURAL_END_RELEASE_TYPE.
Inherits: Enum

  Values:
    - kFixed = 0
    - kPinned = 1
    - kBendingMoment = 2
    - kUserDefined = 3

--------------------------------------------------------------------------------

[CLASS] Subelement
Full Name: Autodesk.Revit.DB.Subelement
Description: An object that represents an element or a subelement within the Autodesk Revit project.
Remarks: Subelements provide a way for parts of an element to behave as though they were real elements without incurring the overhead of adding more full elements to the model.Many Revit features (for example parameters, schedules, and tags) were designed to operate on Elements. As a result, the Revit code needs to represent objects as Elements for them to participate in those features. This can lead to scalability problems, because every Element adds overhead and adding many Elements may decrease the performance of the model. An alternative is to use Subelements. An element can expose a set of "Subelements" that it contains, specifying characteristics like their category and parameters, and certain Revit capabilities will treat those Subelements the same as ordinary Elements. For example, a Subelement may contribute geometry to the main element and may be able to be selected independently of its parent Element. It will possibly have its own (settable) type as well as an assigned category which can be different from its parent Element.In the API, the new Subelement class is used to refer to either an Element or a specific subelement of a given Element. It is typically directly related to a Reference to either the Element or the specific subelement. Note that creation of new Subelements for a given element is not done generically. Instead, the given Element may provide the ability to modify it's definition, resulting in the creation of new Subelements.Examples of Elements which may have Subelements in practice include: RebarContainerRebarFabricSheetStairs elements which make up MultistoryStairs elementsRailingAutodesk::Revit::DB::Architecture::ContinuousRailTo get access to a particular Subelement, you may use any of the following: Reference)Reference)Autodesk.Revit.DB.Document.GetSubelement(Autodesk.Revit.DB.Reference) if you have a Reference to a Subelement.Autodesk.Revit.DB.Document.GetSubelement(String) if you have a unique id of a Subelement.GetSubelements
Implements: IDisposable

  PROPERTIES:
    Category Category { get; }
      Description: Retrieves a Category object that represents the category or sub category of the subelement.
    Document Document { get; }
      Description: The document in which the subelement resides.
    Element Element { get; }
      Description: The element in which the subelement resides.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId TypeId { get; }
      Description: The identifier of this subelement's type.
    string UniqueId { get; }
      Description: A stable unique identifier for this subelement within the document.

  METHODS:
    bool CanHaveTypeAssigned()
      Description: Identifies if the subelement can have a type assigned.
      Returns: True if subelement can have a type assigned, false otherwise.
    void ChangeTypeId(ElementId typeId)
      Description: Changes the type of the subelement.
      @typeId: Identifier of the type to assign to this subelement.
      Throws ArgumentException: The type typeId is not valid for this subelement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This Subelement cannot have type assigned.
      Throws ModificationForbiddenException: This Subelement is an internal element, such as a component of a loaded family or a group type. -or- The document containing this Subelement is in Group Edit Mode, Sketch Edit Mode, or Paste Mode, and the element is not a member of the group, sketch, or clipboard. -or- This Subelement is a member of a group or sketch, and the document is not currently editing the group or sketch.
    static Subelement Create(Document aDoc, Reference reference)
      Description: Creates an object representing element or subelement.
      @aDoc: The document.
      @reference: The reference that identifies element or subelement.
      Returns: The newly created subelement.
      Throws ArgumentException: reference does not identify a valid element or subelement.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    IList<ElementId> GetAllParameters()
      Description: Returns all parameters of this subelement.
    BoundingBoxXYZ GetBoundingBox(View dbView)
      Description: Retrieves a box that circumscribes all geometry of the subelement.
      @dbView: The view for view-specific geometry or for model geometry.
      Returns: The bounding box.
    GeometryObject GetGeometryObject(View dbView)
      Description: Retrieve one geometric primitive representing given subelement.
      @dbView: The view for view-specific geometry or for model geometry.
      Returns: The geometric object representing this subelement.
    ParameterValue GetParameterValue(ElementId parameterId)
      Description: Obtains the current parameter value of this subelement given a parameter id.
      @parameterId: Parameter id.
      Returns: Parameter value.
      Throws ArgumentException: parameterId does not identify a valid parameter of this subelement.
      Throws ArgumentNullException: A non-optional argument was null
    Reference GetReference()
      Description: Obtains the reference to this subelement.
      Returns: The reference to this subelement.
    ISet<ElementId> GetValidTypes()
      Description: Obtains a set of types that are valid for this subelement.
      Returns: A set of element IDs of types that are valid for this subelement or an empty set if subelement cannot have type assigned.
    bool HasParameter(ElementId parameterId)
      Description: Checks if this subelement have given parameter.
      @parameterId: Parameter id.
      Returns: True if %parameterId% identifies valid parameter of this subelement, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsParameterModifiable(ElementId parameterId)
      Description: Checks if given parameter of this subelement is modifiable.
      @parameterId: Parameter id.
      Returns: True if given parameter of this subelement is modifiable, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidSubelementReference(Document aDoc, Reference reference)
      Description: Checks if given Reference identifies either a valid element or subelement.
      @aDoc: The document.
      @reference: The reference that identifies an element or subelement.
      Returns: True if %reference% identifies a valid element or subelement, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidType(ElementId typeId)
      Description: Checks if given type is valid for this subelement.
      @typeId: ElementId of the type to check.
      Returns: True if subelement can have a type assigned and this type is valid for this subelement, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetParameterValue(ElementId parameterId, ParameterValue pValue)
      Description: Sets a new parameter value of this subelement given a parameter id.
      @parameterId: Parameter id.
      @pValue: New value for the parameter.
      Throws ArgumentException: parameterId does not identify a valid parameter of this subelement. -or- The parameter parameterId is not modifiable for this subelement.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] SubfaceType
Full Name: Autodesk.Revit.DB.SubfaceType
Description: Meaning of a subface's type.
Inherits: Enum

  Values:
    - Bottom = 0
    - Top = 1
    - Side = 2

--------------------------------------------------------------------------------

[CLASS] SubTransaction
Full Name: Autodesk.Revit.DB.SubTransaction
Description: Sub-transactions are objects that provide control over a subset of changes in a document.
Remarks: A Sub-transaction can only be active as a part of an open transaction. Sub-transactions may be nested inside each other, but with the restriction that every nested sub-transaction is entirely contained (opened and closed) in the parent sub-transaction. If a sub-transaction was started and not committed or rolled back by the time the SubTransaction object is about to be disposed, the destructor will roll back the sub-transaction automatically, thus all changes made to the document during the sub-transaction will be discarded. It is not recommended to rely on this default behavior though. Instead, it is advised to always call either Commit or RollBack explicitly before the sub-transaction object gets disposed. Please note that unless invoked explicitly the actual destruction of an object in managed code might not happen until the object is collected by the garbage collector.
Implements: IDisposable

  CONSTRUCTORS:
    new SubTransaction(Document document)
      Description: Instantiates a sub-transaction object
      @document: The document for which this sub-transaction is going to be used.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    TransactionStatus Commit()
      Description: Commits all changes made to the model made during the sub-transaction.
      Returns: If finished successfully, this method returns TransactionStatus.Committed
      Throws InvalidOperationException: A sub-transaction can only be active inside an open Transaction. -or- The sub-transaction's current status is not TransactionStatus.Started, therefore it may not be committed or rolled back.
    void Dispose()
    TransactionStatus GetStatus()
      Description: Returns the current status of the sub-transaction.
      Returns: The current status of the sub-transaction.
    bool HasEnded()
      Description: Determines whether the sub-transaction has ended already.
      Returns: True if the sub-transaction has already been committed or rolled back, False otherwise.
    bool HasStarted()
      Description: Determines whether the sub-transaction has been started yet.
      Returns: True if the sub-transaction has already started, False otherwise.
    TransactionStatus RollBack()
      Description: Discards all changes made to the model during the sub-transaction.
      Returns: If finished successfully, this method returns TransactionStatus.RolledBack.
      Throws InvalidOperationException: A sub-transaction can only be active inside an open Transaction. -or- The sub-transaction's current status is not TransactionStatus.Started, therefore it may not be committed or rolled back.
    TransactionStatus Start()
      Description: Starts the sub-transaction.
      Returns: If started successfully, this method returns TransactionStatus.Started.
      Throws InvalidOperationException: Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled. -or- A sub-transaction can only be active inside an open Transaction. -or- The sub-transaction was already started and has not finished yet.

--------------------------------------------------------------------------------

[CLASS] SunAndShadowSettings
Full Name: Autodesk.Revit.DB.SunAndShadowSettings
Description: The SunAndShadowSettings class represents the sun control.
Remarks: The SunAndShadowSettings element represents the settings applied to a project or view regarding the position, dates, time intervals and other options for the sun control and solar studies. To differentiate between the project and view settings, test the ViewSpecific or OwnerViewId property. If the element is not view-specific this element represents a project-wide setting. If the element is associated to a view, this element represents a per view SunAndShadowSettings. When you create a new view, a new view-specific SunAndShadowSettings element is automatically created for it.
Inherits: Element

  PROPERTIES:
    double ActiveFrame { get; set; }
      Description: Identifies the active animation frame for a single-day or multi-day study, starting at 1.0 for the first frame and incrementing in intervals of 1.0.
    DateTime ActiveFrameTime { get; }
      Description: Identifies the date and time of the SunAndShadowSettings element for the active frame.
    double Altitude { get; set; }
      Description: Altitude setting (angle in radians). This is only relevant when dealing with a SunAndShadowSettings element that uses lighting mode.
    double Azimuth { get; set; }
      Description: Azimuth setting (angle in radians). This is only relevant when dealing with a SunAndShadowSettings element that uses lighting mode.
    DateTime EndDateAndTime { get; set; }
      Description: Identifies the end date and time.
    double GroundPlaneHeight { get; }
      Description: Identifies the ground plane height.
    ElementId GroundPlaneLevelId { get; set; }
      Description: Identifies the element id of the Ground Plane level for the SunAndShadowSettings element.
    double Latitude { get; }
      Description: Identifies the current latitude used by the SunAndShadowSettings element.
    double Longitude { get; }
      Description: Identifies the current longitude used by the SunAndShadowSettings element.
    double NumberOfFrames { get; }
      Description: Identifies the total number of animation frames for a single-day or multi-day study.
    ElementId ProjectLocationId { get; }
      Description: Identifies the ProjectLocation element used by the SunAndShadowSettings element.
    string ProjectLocationName { get; }
      Description: Identifies the name of the project location used by the SunAndShadowSettings element.
    bool RelativeToView { get; set; }
      Description: Identifies whether the SunAndShadowSettings element is relative to the view direction. This is only relevant for lighting mode.
    bool SharesSettings { get; set; }
      Description: Identifies whether settings are shared globally.
    DateTime StartDateAndTime { get; set; }
      Description: Identifies the start or current date and time.
    SunAndShadowType SunAndShadowType { get; set; }
      Description: Identifies the type of the SunAndShadowSettings element.
    bool SunriseToSunset { get; set; }
      Description: Identifies whether the current single day sun study is set to run from sunrise to sunset.
    SunStudyTimeInterval TimeInterval { get; set; }
      Description: Identifies the time interval between animation frames.
    double TimeZone { get; }
      Description: Identifies the time zone.
    bool UsesDST { get; }
      Description: Identifies whether the SunAndShadowSettings element is using daylight savings time.
    bool UsesGroundPlane { get; set; }
      Description: Identifies whether the SunAndShadowSettings element uses a ground plane.
    bool Visible { get; set; }
      Description: Visibility in current view for a per-view SunAndShadowSettings element.

  METHODS:
    static double CalculateTimeZone(double latitude, double longitude)
      Description: Use Revit's utilities to calculate the time zone for a given longitude and latitude.
      @latitude: The latitude.
      @longitude: The longitude.
      Returns: The time zone, in hours, ranging from +12 hours to -12 hours with 0 being GMT.
    void FitToModel()
      Description: Adjust SunAndShadowSettings to fit around the current model geometry.
      Throws ArgumentException: The SunAndShadowSettings is not view-specific.
    static Element GetActiveSunAndShadowSettings(Document aDocument)
      Description: Returns the current SunAndShadowSettings element assigned to the active view for the supplied document.
      @aDocument: The document.
      Returns: The active SunAndShadowSettings element for the supplied document.
      Throws ArgumentNullException: A non-optional argument was null
    double GetFrameAltitude(double frame)
      Description: Identifies the altitude of the sun (angle in radians) for a specific frame.
      @frame: Frame for which time is requested
      Returns: Altitude angle (radians)
      Throws ArgumentException: the frame value frame is not valid.
    double GetFrameAzimuth(double frame)
      Description: Identifies the azimuth of the sun (angle in radians) for a specific frame.
      @frame: Frame for which time is requested
      Returns: Azimuth angle (radians). This is measured counterclockwise from the X axis (East direction). Note that this is a different frame of reference than is used by Revit for the Lighting Study Azimuth value.
      Throws ArgumentException: the frame value frame is not valid.
    DateTime GetFrameTime(double frame)
      Description: Identifies the date and time of the SunAndShadowSettings element for a given frame.
      @frame: Frame for which time is requested
      Returns: The date and time. The value will be in Coordinated Universal Time (UTC).
      Throws ArgumentException: the frame value frame is not valid.
    string GetMatchingPreset()
      Description: Finds the name of the 'per-document' SunAndShadowSettings that matches the properties of this per-view element.
      Returns: Name of the per-document SunAndShadowSettings that matches the view specific element.
      Throws ArgumentException: The SunAndShadowSettings is not view-specific.
    DateTime GetSunrise(DateTime date)
      Description: Identifies the sunrise time for the SunAndShadowSettings element at its current location and indicated date.
      @date: The date for which to determine sunrise time.
      Returns: The date and time. The value will be in Coordinated Universal Time (UTC).
    DateTime GetSunset(DateTime date)
      Description: Identifies the sunset time for the SunAndShadowSettings element at its current location and indicated date.
      @date: The date for which to determine sunset time.
      Returns: The date and time. The value will be in Coordinated Universal Time (UTC).
    bool IsAfterStartDateAndTime(DateTime time)
      Description: Checks whether the end date and time is valid.
      @time: Date and time value
      Returns: True if the date and time is valid, false otherwise.
    bool IsBeforeEndDateAndTime(DateTime time)
      Description: Checks whether the start date and time is valid.
      @time: Date and time value
      Returns: True if the date and time is valid, false otherwise.
    bool IsFrameValid(double frame)
      Description: Checks whether the frame is valid for the supplied SunAndShadowSettings.
      @frame: Frame value
      Returns: True if the frame is valid for the SunAndShadowSettings, false otherwise.
    bool IsGroundPlaneLevelValid(ElementId levelId)
      Description: Checks whether the element represents a valid Ground Plane level.
      @levelId: Level element id.
      Returns: True if the element is a valid Ground Plane Level, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsTimeIntervalValid(SunStudyTimeInterval interval)
      Description: Checks whether the time interval is valid for the SunAndShadowType.
      @interval: Time interval value.
      Returns: True if the time interval is valid for the current SunAndShadowType, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] SunAndShadowType
Full Name: Autodesk.Revit.DB.SunAndShadowType
Description: Sun study type enum of SunAndShadowSettings.
Inherits: Enum

  Values:
    - StillImage = 0
    - OneDayStudy = 1
    - MultiDayStudy = 2
    - Lighting = 3

--------------------------------------------------------------------------------

[ENUM] SunStudyTimeInterval
Full Name: Autodesk.Revit.DB.SunStudyTimeInterval
Description: Time interval enum for a single or multi-day sun study.
Inherits: Enum

  Values:
    - Minutes15 = 0
    - Minutes30 = 1
    - Minutes45 = 2
    - Hour = 3
    - Day = 4
    - Week = 5
    - Month = 6
    - Seconds15 = -4
    - Seconds30 = -3
    - Seconds45 = -2
    - Minute = -1

--------------------------------------------------------------------------------

[CLASS] Surface
Full Name: Autodesk.Revit.DB.Surface
Description: A mathematical representation of a surface.
Remarks: This geometric object is not bounded by edges or edge loops. A bounded surface obtained from a Revit element will be represented by a Face instead.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool OrientationMatchesParametricOrientation { get; }
      Description: Indicates whether this Surface's orientation is the same as or opposite to its parametric orientation.

  METHODS:
    void Dispose()
    BoundingBoxUV GetBoundingBoxUV()
      Description: Gets the UV bounding box of the surface.
      Returns: The UV bounding box of the surface.
    bool IsCoincidentWith(Surface other)
      Description: Determine if two surfaces are coincident (ignoring Envelopes). For an affirmative answer, the surfaces must have the same type (e.g., two planes).
      @other: The surfaces which this should be compared with
      Returns: True if surfaces are coincident, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Project(XYZ point, out UV uv, out double distance)
      Description: Project a 3D point orthogonally onto a surface (to find the nearest point). Throws InvalidOperationException if the projection fails.
      @point: The point to project.
      @uv: The surface coordinates of the projected point.
      @distance: Holds the distance from input point to its projection.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The projection failed.
    void ProjectWithGuessPoint(XYZ point, UV guessUV, out UV uv, out double distance)
      Description: Project a 3D point orthogonally onto a surface (to find the nearest point). This method is meant to be used when a good approximate solution for the projection is available. Throws InvalidOperationException if the projection fails.
      @point: The point to project.
      @guessUV: The calculation will look for a project near the provided UV.
      @uv: The surface coordinates of the projected point.
      @distance: Holds the distance from input point to its projection.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The projection failed.

--------------------------------------------------------------------------------

[CLASS] Sweep
Full Name: Autodesk.Revit.DB.Sweep
Description: A sweep solid or void form.
Inherits: GenericForm

  PROPERTIES:
    bool IsTrajectorySegmentationEnabled { get; set; }
      Description: The trajectory segmentation option for the sweep.
    double MaxSegmentAngle { get; set; }
      Description: The maximum segment angle of the sweep in radians.
    Path3d Path3d { get; }
      Description: The selected curves used for the sweep path.
    Sketch PathSketch { get; }
      Description: The sketched path for the sweep.
    Sketch ProfileSketch { get; }
      Description: The profile sketch of the sweep.
    FamilySymbolProfile ProfileSymbol { get; }
      Description: The family symbol profile details for the sweep.

--------------------------------------------------------------------------------

[CLASS] SweepProfile
Full Name: Autodesk.Revit.DB.SweepProfile
Description: Represents a profile for sweep or swept blend elements.
Inherits: APIObject

--------------------------------------------------------------------------------

[CLASS] SweptBlend
Full Name: Autodesk.Revit.DB.SweptBlend
Description: A swept blend solid or void form.
Inherits: GenericForm

  PROPERTIES:
    CurveArrArray BottomProfile { get; }
      Description: The curves which make up the bottom profile of the sketch.
    FamilySymbolProfile BottomProfileSymbol { get; }
      Description: The bottom family symbol profile of the swept blend.
    Sketch BottomSketch { get; }
      Description: The bottom profile sketch of the swept blend.
    Sketch PathSketch { get; }
      Description: The sketched path for the swept blend.
    Curve SelectedPath { get; }
      Description: The selected curve used for the swept blend path.
    CurveArrArray TopProfile { get; }
      Description: The curves which make up the top profile of the sketch.
    FamilySymbolProfile TopProfileSymbol { get; }
      Description: The top family symbol profile of the swept blend.
    Sketch TopSketch { get; }
      Description: The top profile sketch of the swept blend.

  METHODS:
    VertexIndexPairArray GetVertexConnectionMap()
      Description: Gets the mapping between the vertices in the top and bottom profiles.
    void SetVertexConnectionMap(VertexIndexPairArray vertexMap)
      Description: Sets the mapping between the vertices in the top and bottom profiles.
      Throws ArgumentNullException: Thrown when the input argument-"vertexMap"-is .
      Throws ArgumentException: Thrown if the input argument-"vertexMap"-is empty.
      Throws InvalidOperationException: Thrown when the document failed to regenerate.

--------------------------------------------------------------------------------

[CLASS] SweptProfile
Full Name: Autodesk.Revit.DB.SweptProfile
Description: Represents an extruded profile swept along a driving curve.
Remarks: Elements such as beams may be formed from a profile that has been swept along a curve. This class represents such a form and is used to access the cross section and the underlying curve that make up the Element.
Implements: IDisposable

  PROPERTIES:
    double EndSetBack { get; }
      Description: The distance from the end of the driving curve to the point where the sweep actually ends.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double StartSetBack { get; }
      Description: The distance from the start of the driving curve to the point where the sweep actually begins.

  METHODS:
    void Dispose()
    Curve GetDrivingCurve()
      Description: Provides access to the curve that dictates the path of the swept profile.
      Returns: A curve that defines the path of the swept profile.
    Profile GetSweptProfile()
      Description: Returns an object that describes the profile that is swept along the driving curve.
      Returns: A geometric profile object.

--------------------------------------------------------------------------------

[CLASS] SymbolGeometryId
Full Name: Autodesk.Revit.DB.SymbolGeometryId
Description: This class is used to identify a piece of geometry managed by a symbol element.
Remarks: This class can be used to compare if two instances points to the same piece of geometry managed by a symbol element. The string returned by AsIdentifier can be used to achieve this.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId SymbolId { get; }
      Description: The id of the symbol which contains the shared geometry.

  METHODS:
    string AsUniqueIdentifier()
      Description: Returns a string suitable to determine if two instances point to the same piece of geometry managed by the same symbol element.
      Returns: A string suitable to determine if two instances point to the same piece of geometry managed by the same symbol element.
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] SymbolicCurve
Full Name: Autodesk.Revit.DB.SymbolicCurve
Description: A curve that provides information but is not intended to represent actual geometry in an element.
Remarks: For example, when creating a door family, you might sketch symbolic lines in an elevation view to represent a door swing. Symbolic curves are visible parallel to the view in which you sketch them.
Inherits: CurveElement

  PROPERTIES:
    bool IsDrawnInForeground { get; set; }
      Description: Indicates if this curve will be drawn in the foreground of the family instance.
    ReferenceType ReferenceType { get; set; }
      Description: Indicates the type of reference.
    GraphicsStyle Subcategory { get; set; }
      Description: The subcategory.

  METHODS:
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the symbolic curve.
      Returns: A copy of visibility settings for the symbolic curve.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the symbolic curve.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws ArgumentException: Thrown when visibility is not valid for symbolic curves.
      Throws InvalidOperationException: Thrown when regeneration failed.

--------------------------------------------------------------------------------

[CLASS] SymbolicCurveArray
Full Name: Autodesk.Revit.DB.SymbolicCurveArray
Description: An array that contains model curves.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new SymbolicCurveArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    SymbolicCurve Item { get; set; }
    int Size { get; }
      Description: Returns the number of model curves that are in the array.

  METHODS:
    void Append(SymbolicCurve item)
      Description: Add the model curve to the end of the array.
      @item: The model curve to be added.
    void Clear()
      Description: Removes every model curve from the array, rendering it empty.
    SymbolicCurveArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(SymbolicCurve item, int index)
      Description: Insert the specified model curve into the array.
      @item: The model curve to be inserted into the array.
      @index: The model curve will be inserted before this index.
    SymbolicCurveArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SymbolicCurveArrayIterator
Full Name: Autodesk.Revit.DB.SymbolicCurveArrayIterator
Description: An iterator to a model curve array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new SymbolicCurveArrayIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the array.
    void Reset()
      Description: Bring the iterator back to the start of the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SymbolTypeId
Full Name: Autodesk.Revit.DB.SymbolTypeId
Description: This class contains constants identifying symbols.

  PROPERTIES:
    static ForgeTypeId Acres { get; }
      Description: Symbol acres, indicating unit Acres.
    static ForgeTypeId Ampere { get; }
      Description: Symbol A, indicating unit Amperes.
    static ForgeTypeId Atm { get; }
      Description: Symbol atm, indicating unit Atmospheres.
    static ForgeTypeId Baht { get; }
      Description: Symbol à¸¿, indicating unit Currency.
    static ForgeTypeId Bar { get; }
      Description: Symbol bar, indicating unit Bars.
    static ForgeTypeId Btu { get; }
      Description: Symbol Btu, indicating unit British thermal units.
    static ForgeTypeId BtuPerDegreeF { get; }
      Description: Symbol BTU/Â°F, indicating unit British thermal units per degree Fahrenheit.
    static ForgeTypeId BtuPerFtSup2DegreeF { get; }
      Description: Symbol BTU/(ftÂ²Â·Â°F), indicating unit British thermal units per square foot degree Fahrenheit.
    static ForgeTypeId BtuPerH { get; }
      Description: Symbol Btu/h, indicating unit British thermal units per hour.
    static ForgeTypeId BtuPerHFtDegreeF { get; }
      Description: Symbol BTU/(hÂ·ftÂ·Â°F), indicating unit British thermal units per hour foot degree Fahrenheit.
    static ForgeTypeId BtuPerHFtSup2 { get; }
      Description: Symbol Btu/(hÂ·ftÂ²), indicating unit British thermal units per hour square foot.
    static ForgeTypeId BtuPerHFtSup2DegreeF { get; }
      Description: Symbol BTU/(hÂ·ftÂ²Â·Â°F), indicating unit British thermal units per hour square foot degree Fahrenheit.
    static ForgeTypeId BtuPerHFtSup3 { get; }
      Description: Symbol Btu/(hÂ·ftÂ³), indicating unit British thermal units per hour cubic foot.
    static ForgeTypeId BtuPerLb { get; }
      Description: Symbol BTU/lb, indicating unit British thermal units per pound.
    static ForgeTypeId BtuPerLbDegreeF { get; }
      Description: Symbol BTU/(lbÂ·Â°F), indicating unit British thermal units per pound degree Fahrenheit.
    static ForgeTypeId BtuPerS { get; }
      Description: Symbol Btu/s, indicating unit British thermal units per second.
    static ForgeTypeId Cal { get; }
      Description: Symbol cal, indicating unit Calories.
    static ForgeTypeId CalPerS { get; }
      Description: Symbol cal/s, indicating unit Calories per second.
    static ForgeTypeId Cd { get; }
      Description: Symbol cd, indicating unit Candelas.
    static ForgeTypeId CdPerFtSup2 { get; }
      Description: Symbol cd/ftÂ², indicating unit Candelas per square foot.
    static ForgeTypeId CdPerMSup2 { get; }
      Description: Symbol cd/mÂ², indicating unit Candelas per square meter.
    static ForgeTypeId Cf { get; }
      Description: Symbol CF, indicating unit Cubic feet.
    static ForgeTypeId Cfh { get; }
      Description: Symbol CFH, indicating unit Cubic feet per hour.
    static ForgeTypeId Cfm { get; }
      Description: Symbol CFM, indicating unit Cubic feet per minute.
    static ForgeTypeId CfmPerCf { get; }
      Description: Symbol CFM/CF, indicating unit Cubic feet per minute cubic foot.
    static ForgeTypeId CfmPerFtSup2 { get; }
      Description: Symbol CFM/ftÂ², indicating unit Cubic feet per minute square foot.
    static ForgeTypeId CfmPerFtSup3 { get; }
      Description: Symbol CFM/ftÂ³, indicating unit Cubic feet per minute cubic foot.
    static ForgeTypeId CfmPerSf { get; }
      Description: Symbol CFM/SF, indicating unit Cubic feet per minute square foot.
    static ForgeTypeId CfmPerTon { get; }
      Description: Symbol CFM/ton, indicating unit Cubic feet per minute ton of refrigeration.
    static ForgeTypeId ChineseHongKongDollar { get; }
      Description: Symbol HK$, indicating unit Currency.
    static ForgeTypeId Cm { get; }
      Description: Symbol cm, indicating unit Centimeters.
    static ForgeTypeId CmCaret2 { get; }
      Description: Symbol cm^2, indicating unit Square centimeters.
    static ForgeTypeId CmCaret3 { get; }
      Description: Symbol cm^3, indicating unit Cubic centimeters.
    static ForgeTypeId Cmh { get; }
      Description: Symbol CMH, indicating unit Cubic meters per hour.
    static ForgeTypeId CmPerMin { get; }
      Description: Symbol cm/min, indicating unit Centimeters per minute.
    static ForgeTypeId Cms { get; }
      Description: Symbol CMS, indicating unit Cubic meters per second.
    static ForgeTypeId CmSup2 { get; }
      Description: Symbol cmÂ², indicating unit Square centimeters.
    static ForgeTypeId CmSup2PerM { get; }
      Description: Symbol cmÂ²/m, indicating unit Square centimeters per meter.
    static ForgeTypeId CmSup3 { get; }
      Description: Symbol cmÂ³, indicating unit Cubic centimeters.
    static ForgeTypeId CmSup4 { get; }
      Description: Symbol cmâ´, indicating unit Centimeters to the fourth power.
    static ForgeTypeId CmSup6 { get; }
      Description: Symbol cmâ¶, indicating unit Centimeters to the sixth power.
    static ForgeTypeId Colon1 { get; }
      Description: Symbol :1, indicating unit Ratio : 1.
    static ForgeTypeId Colon10 { get; }
      Description: Symbol :10, indicating unit Ratio : 10.
    static ForgeTypeId Colon12 { get; }
      Description: Symbol :12, indicating unit Ratio : 12.
    static ForgeTypeId CP { get; }
      Description: Symbol cP, indicating unit Centipoises.
    static ForgeTypeId Cps { get; }
      Description: Symbol cps, indicating unit Cycles per second.
    static ForgeTypeId Custom { get; }
      Description: Unrecognized custom symbol.
    static ForgeTypeId Cy { get; }
      Description: Symbol CY, indicating unit Cubic yards.
    static ForgeTypeId DaN { get; }
      Description: Symbol daN, indicating unit Dekanewtons.
    static ForgeTypeId DaNDashM { get; }
      Description: Symbol daN-m, indicating unit Dekanewton meters.
    static ForgeTypeId DaNDashMPerM { get; }
      Description: Symbol daN-m/m, indicating unit Dekanewton meters per meter.
    static ForgeTypeId DaNPerM { get; }
      Description: Symbol daN/m, indicating unit Dekanewtons per meter.
    static ForgeTypeId DaNPerMSup2 { get; }
      Description: Symbol daN/mÂ², indicating unit Dekanewtons per square meter.
    static ForgeTypeId Degree { get; }
      Description: Symbol Â°, indicating unit Degrees.
    static ForgeTypeId DegreeC { get; }
      Description: Symbol Â°C, indicating unit Celsius.
    static ForgeTypeId DegreeCInterval { get; }
      Description: Symbol Â°C, indicating unit Celsius interval.
    static ForgeTypeId DegreeF { get; }
      Description: Symbol Â°F, indicating unit Fahrenheit.
    static ForgeTypeId DegreeFInterval { get; }
      Description: Symbol Â°F, indicating unit Fahrenheit interval.
    static ForgeTypeId DegreeR { get; }
      Description: Symbol Â°R, indicating unit Rankine.
    static ForgeTypeId DegreeRInterval { get; }
      Description: Symbol Â°R, indicating unit Rankine interval.
    static ForgeTypeId DeltaDegreeC { get; }
      Description: Symbol deltaÂ°C, indicating unit Celsius interval.
    static ForgeTypeId DeltaDegreeF { get; }
      Description: Symbol deltaÂ°F, indicating unit Fahrenheit interval.
    static ForgeTypeId DeltaDegreeR { get; }
      Description: Symbol deltaÂ°R, indicating unit Rankine interval.
    static ForgeTypeId DeltaK { get; }
      Description: Symbol deltaK, indicating unit Kelvin interval.
    static ForgeTypeId Dm { get; }
      Description: Symbol dm, indicating unit Decimeters.
    static ForgeTypeId DollarHPerBtu { get; }
      Description: Symbol $Â·h/Btu, indicating unit Cost per British thermal unit per hour.
    static ForgeTypeId DollarPerBtu { get; }
      Description: Symbol $/Btu, indicating unit Cost per British thermal unit.
    static ForgeTypeId DollarPerFtSup2 { get; }
      Description: Symbol $/ftÂ², indicating unit Cost per square foot.
    static ForgeTypeId DollarPerMSup2 { get; }
      Description: Symbol $/mÂ², indicating unit Cost per square meter.
    static ForgeTypeId DollarPerW { get; }
      Description: Symbol $/W, indicating unit Cost per watt.
    static ForgeTypeId DollarPerWH { get; }
      Description: Symbol $/(WÂ·h), indicating unit Cost per watt hour.
    static ForgeTypeId Dong { get; }
      Description: Symbol â‚«, indicating unit Currency.
    static ForgeTypeId EuroPrefix { get; }
      Description: Symbol â‚¬, indicating unit Currency.
    static ForgeTypeId EuroSuffix { get; }
      Description: Symbol â‚¬, indicating unit Currency.
    static ForgeTypeId Fc { get; }
      Description: Symbol fc, indicating unit Footcandles.
    static ForgeTypeId FeetOfWater { get; }
      Description: Symbol Feet, indicating unit Feet of water (39.2 Â°F).
    static ForgeTypeId FeetOfWaterPer100ft { get; }
      Description: Symbol Feet/100ft, indicating unit Feet of water (39.2 Â°F) per 100 feet.
    static ForgeTypeId FL { get; }
      Description: Symbol fL, indicating unit Footlamberts.
    static ForgeTypeId FlLowercase { get; }
      Description: Symbol fl, indicating unit Footlamberts.
    static ForgeTypeId FootSingleQuote { get; }
      Description: Symbol ', indicating unit Feet.
    static ForgeTypeId Fpm { get; }
      Description: Symbol FPM, indicating unit Feet per minute.
    static ForgeTypeId Fps { get; }
      Description: Symbol FPS, indicating unit Feet per second.
    static ForgeTypeId Ft { get; }
      Description: Symbol ft, indicating unit Feet.
    static ForgeTypeId Ftc { get; }
      Description: Symbol Ftc, indicating unit Footcandles.
    static ForgeTypeId FtCaret2 { get; }
      Description: Symbol ft^2, indicating unit Square feet.
    static ForgeTypeId FtCaret3 { get; }
      Description: Symbol ft^3, indicating unit Cubic feet.
    static ForgeTypeId FtH2O { get; }
      Description: Symbol ftH2O, indicating unit Feet of water (39.2 Â°F).
    static ForgeTypeId FtH2OPer100ft { get; }
      Description: Symbol ftH2O/100ft, indicating unit Feet of water (39.2 Â°F) per 100 feet.
    static ForgeTypeId FtL { get; }
      Description: Symbol ftL, indicating unit Footlamberts.
    static ForgeTypeId FtOfWater { get; }
      Description: Symbol FT, indicating unit Feet of water (39.2 Â°F).
    static ForgeTypeId FtOfWaterPer100ft { get; }
      Description: Symbol FT/100ft, indicating unit Feet of water (39.2 Â°F) per 100 feet.
    static ForgeTypeId FtPerKip { get; }
      Description: Symbol ft/kip, indicating unit Feet per kip.
    static ForgeTypeId FtPerMin { get; }
      Description: Symbol ft/min, indicating unit Feet per minute.
    static ForgeTypeId FtPerS { get; }
      Description: Symbol ft/s, indicating unit Feet per second.
    static ForgeTypeId FtPerSSup2 { get; }
      Description: Symbol ft/sÂ², indicating unit Feet per second squared.
    static ForgeTypeId FtSup2 { get; }
      Description: Symbol ftÂ², indicating unit Square feet.
    static ForgeTypeId FtSup2HPerKbtu { get; }
      Description: Symbol ftÂ²Â·h/kBtu, indicating unit Square feet per thousand British thermal units per hour.
    static ForgeTypeId FtSup2PerFt { get; }
      Description: Symbol ftÂ²/ft, indicating unit Square feet per foot.
    static ForgeTypeId FtSup2PerKip { get; }
      Description: Symbol ftÂ²/kip, indicating unit Square feet per kip.
    static ForgeTypeId FtSup2PerMbh { get; }
      Description: Symbol ftÂ²/MBh, indicating unit Square feet per thousand British thermal units per hour.
    static ForgeTypeId FtSup2PerS { get; }
      Description: Symbol ftÂ²/s, indicating unit Square feet per second.
    static ForgeTypeId FtSup2PerTon { get; }
      Description: Symbol ftÂ²/ton, indicating unit Square feet per ton of refrigeration.
    static ForgeTypeId FtSup3 { get; }
      Description: Symbol ftÂ³, indicating unit Cubic feet.
    static ForgeTypeId FtSup3HPerMinBtu { get; }
      Description: Symbol ftÂ³Â·h/(minÂ·Btu), indicating unit Cubic feet per minute per British thermal unit per hour.
    static ForgeTypeId FtSup3PerH { get; }
      Description: Symbol ftÂ³/h, indicating unit Cubic feet per hour.
    static ForgeTypeId FtSup3PerKip { get; }
      Description: Symbol ftÂ³/kip, indicating unit Cubic feet per kip.
    static ForgeTypeId FtSup3PerLbMass { get; }
      Description: Symbol ftÂ³/lb, indicating unit Cubic feet per pound mass.
    static ForgeTypeId FtSup3PerMin { get; }
      Description: Symbol ftÂ³/min, indicating unit Cubic feet per minute.
    static ForgeTypeId FtSup4 { get; }
      Description: Symbol ftâ´, indicating unit Feet to the fourth power.
    static ForgeTypeId FtSup6 { get; }
      Description: Symbol ftâ¶, indicating unit Feet to the sixth power.
    static ForgeTypeId Gal { get; }
      Description: Symbol gal, indicating unit US gallons.
    static ForgeTypeId GalPerH { get; }
      Description: Symbol gal/h, indicating unit US gallons per hour.
    static ForgeTypeId GalPerMin { get; }
      Description: Symbol gal/min, indicating unit US gallons per minute.
    static ForgeTypeId GJ { get; }
      Description: Symbol GJ, indicating unit Gigajoules.
    static ForgeTypeId Gph { get; }
      Description: Symbol GPH, indicating unit US gallons per hour.
    static ForgeTypeId Gpm { get; }
      Description: Symbol GPM, indicating unit US gallons per minute.
    static ForgeTypeId Grad { get; }
      Description: Symbol grad, indicating unit Gradians.
    static ForgeTypeId GrPerHFtSup2InHg { get; }
      Description: Symbol gr/(hÂ·ftÂ²Â·inHg), indicating unit Grains per hour square foot inch mercury.
    static ForgeTypeId Hectare { get; }
      Description: Symbol hectare, indicating unit Hectares.
    static ForgeTypeId HFtSup2DegreeFPerBtu { get; }
      Description: Symbol (hÂ·ftÂ²Â·Â°F)/BTU, indicating unit Hour square foot degrees Fahrenheit per British thermal unit.
    static ForgeTypeId Hour { get; }
      Description: Symbol h, indicating unit Hours.
    static ForgeTypeId Hp { get; }
      Description: Symbol hp, indicating unit Horsepower.
    static ForgeTypeId Hz { get; }
      Description: Symbol Hz, indicating unit Hertz.
    static ForgeTypeId In { get; }
      Description: Symbol in, indicating unit Inches.
    static ForgeTypeId InCaret2 { get; }
      Description: Symbol in^2, indicating unit Square inches.
    static ForgeTypeId InCaret3 { get; }
      Description: Symbol in^3, indicating unit Cubic inches.
    static ForgeTypeId InchDoubleQuote { get; }
      Description: Symbol ", indicating unit Inches.
    static ForgeTypeId InDashWg { get; }
      Description: Symbol in-wg, indicating unit Inches of water (60 Â°F).
    static ForgeTypeId InDashWgPer100ft { get; }
      Description: Symbol in-wg/100ft, indicating unit Inches of water (60 Â°F) per 100 feet.
    static ForgeTypeId InHg { get; }
      Description: Symbol inHg, indicating unit Inches of mercury (32 Â°F).
    static ForgeTypeId InPerSSup2 { get; }
      Description: Symbol in/sÂ², indicating unit Inches per second squared.
    static ForgeTypeId InSup2 { get; }
      Description: Symbol inÂ², indicating unit Square inches.
    static ForgeTypeId InSup2PerFt { get; }
      Description: Symbol inÂ²/ft, indicating unit Square inches per foot.
    static ForgeTypeId InSup3 { get; }
      Description: Symbol inÂ³, indicating unit Cubic inches.
    static ForgeTypeId InSup4 { get; }
      Description: Symbol inâ´, indicating unit Inches to the fourth power.
    static ForgeTypeId InSup6 { get; }
      Description: Symbol inâ¶, indicating unit Inches to the sixth power.
    static ForgeTypeId InvDegreeC { get; }
      Description: Symbol 1/Â°C, indicating unit Inverse degrees Celsius.
    static ForgeTypeId InvDegreeF { get; }
      Description: Symbol 1/Â°F, indicating unit Inverse degrees Fahrenheit.
    static ForgeTypeId InvKip { get; }
      Description: Symbol 1/kip, indicating unit Inverse kips.
    static ForgeTypeId InvKN { get; }
      Description: Symbol 1/kN, indicating unit Inverse kilonewtons.
    static ForgeTypeId Joule { get; }
      Description: Symbol J, indicating unit Joules.
    static ForgeTypeId JPerG { get; }
      Description: Symbol J/g, indicating unit Joules per gram.
    static ForgeTypeId JPerGDegreeC { get; }
      Description: Symbol J/(gÂ·Â°C), indicating unit Joules per gram degree Celsius.
    static ForgeTypeId JPerK { get; }
      Description: Symbol J/K, indicating unit Joules per Kelvin.
    static ForgeTypeId JPerKgDegreeC { get; }
      Description: Symbol J/(kgÂ·Â°C), indicating unit Joules per kilogram degree Celsius.
    static ForgeTypeId JPerMSup2K { get; }
      Description: Symbol J/(mÂ²Â·K), indicating unit Joules per square meter Kelvin.
    static ForgeTypeId KA { get; }
      Description: Symbol kA, indicating unit Kiloamperes.
    static ForgeTypeId KBtu { get; }
      Description: Symbol kBtu, indicating unit Thousand British thermal units.
    static ForgeTypeId Kcal { get; }
      Description: Symbol kcal, indicating unit Kilocalories.
    static ForgeTypeId KcalPerS { get; }
      Description: Symbol kcal/s, indicating unit Kilocalories per second.
    static ForgeTypeId Kelvin { get; }
      Description: Symbol K, indicating unit Kelvin.
    static ForgeTypeId KelvinInterval { get; }
      Description: Symbol K, indicating unit Kelvin interval.
    static ForgeTypeId Kg { get; }
      Description: Symbol kg, indicating unit Kilograms.
    static ForgeTypeId KgCO2ePerBtu { get; }
      Description: Symbol kgCOâ‚‚e/Btu, indicating kilograms Carbon Dioxide per British thermal unit
    static ForgeTypeId KgCO2ePerFt { get; }
      Description: Symbol kgCOâ‚‚e/ft, indicating kilograms Carbon Dioxide per foot
    static ForgeTypeId KgCO2ePerFtSup2 { get; }
      Description: Symbol kgCOâ‚‚e/ftÂ², indicating kilograms Carbon Dioxide per square foot
    static ForgeTypeId KgCO2ePerFtSup3 { get; }
      Description: Symbol kgCOâ‚‚e/ftÂ³, indicating kilograms Carbon Dioxide per cubic foot
    static ForgeTypeId KgCO2ePerItem { get; }
      Description: Symbol kgCOâ‚‚e/item, indicating kilograms Carbon Dioxide per item
    static ForgeTypeId KgCO2ePerKBtu { get; }
      Description: Symbol kgCOâ‚‚e/kBtu, indicating kilograms Carbon Dioxide per thousand British thermal units
    static ForgeTypeId KgCO2ePerKg { get; }
      Description: Symbol kgCOâ‚‚e/kg, indicating kilograms Carbon Dioxide per kilogram
    static ForgeTypeId KgCO2ePerKWh { get; }
      Description: Symbol kgCOâ‚‚e/KWh, indicating kilograms Carbon Dioxide per kilowatt hour
    static ForgeTypeId KgCO2ePerLb { get; }
      Description: Symbol kgCOâ‚‚e/lb, indicating kilograms Carbon Dioxide per pound
    static ForgeTypeId KgCO2ePerM { get; }
      Description: Symbol kgCOâ‚‚e/m, indicating kilograms Carbon Dioxide per meter
    static ForgeTypeId KgCO2ePerMBtu { get; }
      Description: Symbol kgCOâ‚‚e/MBtu, indicating kilograms Carbon Dioxide per million British thermal units
    static ForgeTypeId KgCO2ePerMSup2 { get; }
      Description: Symbol kgCOâ‚‚e/mÂ², indicating kilograms Carbon Dioxide per square meter
    static ForgeTypeId KgCO2ePerMSup3 { get; }
      Description: Symbol kgCOâ‚‚e/mÂ³, indicating kilograms Carbon Dioxide per cubic meter
    static ForgeTypeId KgCO2ePerMWh { get; }
      Description: Symbol kgCOâ‚‚e/MWh, indicating kilograms Carbon Dioxide per megawatt hour
    static ForgeTypeId Kgf { get; }
      Description: Symbol kgf, indicating unit Kilograms force.
    static ForgeTypeId KgfDashM { get; }
      Description: Symbol kgf-m, indicating unit Kilogram force meters.
    static ForgeTypeId KgfDashMPerM { get; }
      Description: Symbol kgf-m/m, indicating unit Kilogram force meters per meter.
    static ForgeTypeId KgfPerM { get; }
      Description: Symbol kgf/m, indicating unit Kilograms force per meter.
    static ForgeTypeId KgfPerMSup2 { get; }
      Description: Symbol kgf/mÂ², indicating unit Kilograms force per square meter.
    static ForgeTypeId KgPerH { get; }
      Description: Symbol kg/h, indicating unit Kilograms per hour.
    static ForgeTypeId KgPerKgK { get; }
      Description: Symbol kg/(kgÂ·K), indicating unit Kilograms per kilogram kelvin.
    static ForgeTypeId KgPerM { get; }
      Description: Symbol kg/m, indicating unit Kilograms per meter.
    static ForgeTypeId KgPerMH { get; }
      Description: Symbol kg/(mÂ·h), indicating unit Kilograms per meter hour.
    static ForgeTypeId KgPerMin { get; }
      Description: Symbol kg/min, indicating unit Kilograms per minute.
    static ForgeTypeId KgPerMS { get; }
      Description: Symbol kg/(mÂ·s), indicating unit Kilograms per meter second.
    static ForgeTypeId KgPerMSup2 { get; }
      Description: Symbol kg/mÂ², indicating unit Kilograms per square meter.
    static ForgeTypeId KgPerMSup3 { get; }
      Description: Symbol kg/mÂ³, indicating unit Kilograms per cubic meter.
    static ForgeTypeId KgPerS { get; }
      Description: Symbol kg/s, indicating unit Kilograms per second.
    static ForgeTypeId Kip { get; }
      Description: Symbol kip, indicating unit Kips.
    static ForgeTypeId KipDashFt { get; }
      Description: Symbol kip-ft, indicating unit Kip feet.
    static ForgeTypeId KipDashFtPerDegree { get; }
      Description: Symbol kip-ft/Â°, indicating unit Kip feet per degree.
    static ForgeTypeId KipDashFtPerDegreePerFt { get; }
      Description: Symbol kip-ft/Â°/ft, indicating unit Kip feet per degree per foot.
    static ForgeTypeId KipDashFtPerFt { get; }
      Description: Symbol kip-ft/ft, indicating unit Kip feet per foot.
    static ForgeTypeId KipPerFt { get; }
      Description: Symbol kip/ft, indicating unit Kips per foot.
    static ForgeTypeId KipPerFtSup2 { get; }
      Description: Symbol kip/ftÂ², indicating unit Kips per square foot.
    static ForgeTypeId KipPerFtSup3 { get; }
      Description: Symbol kip/ftÂ³, indicating unit Kips per cubic foot.
    static ForgeTypeId KipPerIn { get; }
      Description: Symbol kip/in, indicating unit Kips per inch.
    static ForgeTypeId KipPerInSup2 { get; }
      Description: Symbol kip/inÂ², indicating unit Kips per square inch.
    static ForgeTypeId KipPerInSup3 { get; }
      Description: Symbol kip/inÂ³, indicating unit Kips per cubic inch.
    static ForgeTypeId KJ { get; }
      Description: Symbol kJ, indicating unit Kilojoules.
    static ForgeTypeId KJPerK { get; }
      Description: Symbol kJ/K, indicating unit Kilojoules per Kelvin.
    static ForgeTypeId KJPerMSup2K { get; }
      Description: Symbol kJ/(mÂ²Â·K), indicating unit Kilojoules per square meter Kelvin.
    static ForgeTypeId KmPerH { get; }
      Description: Symbol km/h, indicating unit Kilometers per hour.
    static ForgeTypeId KmPerSSup2 { get; }
      Description: Symbol km/sÂ², indicating unit Kilometers per second squared.
    static ForgeTypeId KN { get; }
      Description: Symbol kN, indicating unit Kilonewtons.
    static ForgeTypeId KNDashM { get; }
      Description: Symbol kN-m, indicating unit Kilonewton meters.
    static ForgeTypeId KNDashMPerDegree { get; }
      Description: Symbol kN-m/Â°, indicating unit Kilonewton meters per degree.
    static ForgeTypeId KNDashMPerDegreePerM { get; }
      Description: Symbol kN-m/Â°/m, indicating unit Kilonewton meters per degree per meter.
    static ForgeTypeId KNDashMPerM { get; }
      Description: Symbol kN-m/m, indicating unit Kilonewton meters per meter.
    static ForgeTypeId KNPerCmSup2 { get; }
      Description: Symbol kN/cmÂ², indicating unit Kilonewtons per square centimeter.
    static ForgeTypeId KNPerM { get; }
      Description: Symbol kN/m, indicating unit Kilonewtons per meter.
    static ForgeTypeId KNPerMmSup2 { get; }
      Description: Symbol kN/mmÂ², indicating unit Kilonewtons per square millimeter.
    static ForgeTypeId KNPerMSup2 { get; }
      Description: Symbol kN/mÂ², indicating unit Kilonewtons per square meter.
    static ForgeTypeId KNPerMSup3 { get; }
      Description: Symbol kN/mÂ³, indicating unit Kilonewtons per cubic meter.
    static ForgeTypeId KPa { get; }
      Description: Symbol kPa, indicating unit Kilopascals.
    static ForgeTypeId Krone { get; }
      Description: Symbol kr, indicating unit Currency.
    static ForgeTypeId Ksf { get; }
      Description: Symbol ksf, indicating unit Kips per square foot.
    static ForgeTypeId Ksi { get; }
      Description: Symbol ksi, indicating unit Kips per square inch.
    static ForgeTypeId KV { get; }
      Description: Symbol kV, indicating unit Kilovolts.
    static ForgeTypeId KVA { get; }
      Description: Symbol kVA, indicating unit Kilovolt amperes.
    static ForgeTypeId KW { get; }
      Description: Symbol kW, indicating unit Kilowatts.
    static ForgeTypeId KWh { get; }
      Description: Symbol kWh, indicating unit Kilowatt hours.
    static ForgeTypeId Lbf { get; }
      Description: Symbol lbf, indicating unit Pounds force.
    static ForgeTypeId LbfDashFt { get; }
      Description: Symbol lbf-ft, indicating unit Pound force feet.
    static ForgeTypeId LbfDashFtPerFt { get; }
      Description: Symbol lbf-ft/ft, indicating unit Pound force feet per foot.
    static ForgeTypeId LbForce { get; }
      Description: Symbol lb, indicating unit Pounds force.
    static ForgeTypeId LbForceDashFt { get; }
      Description: Symbol lb-ft, indicating unit Pound force feet.
    static ForgeTypeId LbForceDashFtPerFt { get; }
      Description: Symbol lb-ft/ft, indicating unit Pound force feet per foot.
    static ForgeTypeId LbForcePerFt { get; }
      Description: Symbol lb/ft, indicating unit Pounds force per foot.
    static ForgeTypeId LbForcePerFtSup2 { get; }
      Description: Symbol lb/ftÂ², indicating unit Pounds force per square foot.
    static ForgeTypeId LbForcePerFtSup3 { get; }
      Description: Symbol lb/ftÂ³, indicating unit Pounds force per cubic foot.
    static ForgeTypeId LbForcePerInSup2 { get; }
      Description: Symbol lb/inÂ², indicating unit Pounds force per square inch.
    static ForgeTypeId LbForceSPerFtSup2 { get; }
      Description: Symbol lbÂ·s/ftÂ², indicating unit Pound force seconds per square foot.
    static ForgeTypeId LbfPerFt { get; }
      Description: Symbol lbf/ft, indicating unit Pounds force per foot.
    static ForgeTypeId LbfPerFtSup2 { get; }
      Description: Symbol lbf/ftÂ², indicating unit Pounds force per square foot.
    static ForgeTypeId LbfPerFtSup3 { get; }
      Description: Symbol lbf/ftÂ³, indicating unit Pounds force per cubic foot.
    static ForgeTypeId LbfPerInSup2 { get; }
      Description: Symbol lbf/inÂ², indicating unit Pounds force per square inch.
    static ForgeTypeId Lbm { get; }
      Description: Symbol lbm, indicating unit Pounds mass.
    static ForgeTypeId LbMass { get; }
      Description: Symbol lb, indicating unit Pounds mass.
    static ForgeTypeId LbMassPerFt { get; }
      Description: Symbol lb/ft, indicating unit Pounds mass per foot.
    static ForgeTypeId LbMassPerFtDashH { get; }
      Description: Symbol lb/ft-h, indicating unit Pounds mass per foot hour.
    static ForgeTypeId LbMassPerFtDashS { get; }
      Description: Symbol lb/ft-s, indicating unit Pounds mass per foot second.
    static ForgeTypeId LbMassPerFtSup2 { get; }
      Description: Symbol lb/ftÂ², indicating unit Pounds mass per square foot.
    static ForgeTypeId LbMassPerFtSup3 { get; }
      Description: Symbol lb/ftÂ³, indicating unit Pounds mass per cubic foot.
    static ForgeTypeId LbMassPerH { get; }
      Description: Symbol lb/h, indicating unit Pounds mass per hour.
    static ForgeTypeId LbMassPerInSup3 { get; }
      Description: Symbol lb/inÂ³, indicating unit Pounds mass per cubic inch.
    static ForgeTypeId LbMassPerLbDegreeF { get; }
      Description: Symbol lb/(lbÂ·Â°F), indicating unit Pounds mass per pound degree Fahrenheit.
    static ForgeTypeId LbMassPerMin { get; }
      Description: Symbol lb/min, indicating unit Pounds mass per minute.
    static ForgeTypeId LbMassPerS { get; }
      Description: Symbol lb/s, indicating unit Pounds mass per second.
    static ForgeTypeId LbmPerFt { get; }
      Description: Symbol lbm/ft, indicating unit Pounds mass per foot.
    static ForgeTypeId LbmPerFtDashH { get; }
      Description: Symbol lbm/ft-h, indicating unit Pounds mass per foot hour.
    static ForgeTypeId LbmPerFtDashS { get; }
      Description: Symbol lbm/ft-s, indicating unit Pounds mass per foot second.
    static ForgeTypeId LbmPerFtSup3 { get; }
      Description: Symbol lbm/ftÂ³, indicating unit Pounds mass per cubic foot.
    static ForgeTypeId LbmPerInSup3 { get; }
      Description: Symbol lbm/inÂ³, indicating unit Pounds mass per cubic inch.
    static ForgeTypeId Lf { get; }
      Description: Symbol LF, indicating unit Feet.
    static ForgeTypeId Liter { get; }
      Description: Symbol L, indicating unit Liters.
    static ForgeTypeId Lm { get; }
      Description: Symbol lm, indicating unit Lumens.
    static ForgeTypeId LmPerW { get; }
      Description: Symbol lm/W, indicating unit Lumens per watt.
    static ForgeTypeId LPerH { get; }
      Description: Symbol L/h, indicating unit Liters per hour.
    static ForgeTypeId LPerMin { get; }
      Description: Symbol L/min, indicating unit Liters per minute.
    static ForgeTypeId LPerS { get; }
      Description: Symbol L/s, indicating unit Liters per second.
    static ForgeTypeId LPerSKw { get; }
      Description: Symbol L/(sÂ·kW), indicating unit Liters per second kilowatt.
    static ForgeTypeId LPerSMSup2 { get; }
      Description: Symbol L/(sÂ·mÂ²), indicating unit Liters per second square meter.
    static ForgeTypeId LPerSMSup3 { get; }
      Description: Symbol L/(sÂ·mÂ³), indicating unit Liters per second cubic meter.
    static ForgeTypeId Lpm { get; }
      Description: Symbol LPM, indicating unit Liters per minute.
    static ForgeTypeId Lps { get; }
      Description: Symbol LPS, indicating unit Liters per second.
    static ForgeTypeId LpsPerMSup2 { get; }
      Description: Symbol LPS/mÂ², indicating unit Liters per second square meter.
    static ForgeTypeId Lx { get; }
      Description: Symbol lx, indicating unit Lux.
    static ForgeTypeId MA { get; }
      Description: Symbol mA, indicating unit Milliamperes.
    static ForgeTypeId Mbh { get; }
      Description: Symbol MBH, indicating unit Thousand British thermal units per hour.
    static ForgeTypeId MBtu { get; }
      Description: Symbol MBtu, indicating unit Million British thermal units.
    static ForgeTypeId MCaret2 { get; }
      Description: Symbol m^2, indicating unit Square meters.
    static ForgeTypeId MCaret3 { get; }
      Description: Symbol m^3, indicating unit Cubic meters.
    static ForgeTypeId Meter { get; }
      Description: Symbol m, indicating unit Meters.
    static ForgeTypeId MH2O { get; }
      Description: Symbol mH2O, indicating unit Meters of water column.
    static ForgeTypeId MH2OPerM { get; }
      Description: Symbol mH2O/m, indicating unit Meters of water column per meter.
    static ForgeTypeId Min { get; }
      Description: Symbol min, indicating unit Minutes.
    static ForgeTypeId MiPerSSup2 { get; }
      Description: Symbol mi/sÂ², indicating unit Miles per second squared.
    static ForgeTypeId MJ { get; }
      Description: Symbol MJ, indicating unit Megajoules.
    static ForgeTypeId Mm { get; }
      Description: Symbol mm, indicating unit Millimeters.
    static ForgeTypeId MmCaret2 { get; }
      Description: Symbol mm^2, indicating unit Square millimeters.
    static ForgeTypeId MmCaret3 { get; }
      Description: Symbol mm^3, indicating unit Cubic millimeters.
    static ForgeTypeId MmH2O { get; }
      Description: Symbol mmH2O, indicating unit Millimeters of water column.
    static ForgeTypeId MmH2OPerM { get; }
      Description: Symbol mmH2O/m, indicating unit Millimeters of water column per meter.
    static ForgeTypeId MmHg { get; }
      Description: Symbol mmHg, indicating unit Millimeters of mercury.
    static ForgeTypeId MmSup2 { get; }
      Description: Symbol mmÂ², indicating unit Square millimeters.
    static ForgeTypeId MmSup2PerM { get; }
      Description: Symbol mmÂ²/m, indicating unit Square millimeters per meter.
    static ForgeTypeId MmSup3 { get; }
      Description: Symbol mmÂ³, indicating unit Cubic millimeters.
    static ForgeTypeId MmSup4 { get; }
      Description: Symbol mmâ´, indicating unit Millimeters to the fourth power.
    static ForgeTypeId MmSup6 { get; }
      Description: Symbol mmâ¶, indicating unit Millimeters to the sixth power.
    static ForgeTypeId MN { get; }
      Description: Symbol MN, indicating unit Meganewtons.
    static ForgeTypeId MNDashM { get; }
      Description: Symbol MN-m, indicating unit Meganewton meters.
    static ForgeTypeId MNDashMPerM { get; }
      Description: Symbol MN-m/m, indicating unit Meganewton meters per meter.
    static ForgeTypeId MNPerM { get; }
      Description: Symbol MN/m, indicating unit Meganewtons per meter.
    static ForgeTypeId MNPerMSup2 { get; }
      Description: Symbol MN/mÂ², indicating unit Meganewtons per square meter.
    static ForgeTypeId MPa { get; }
      Description: Symbol MPa, indicating unit Megapascals.
    static ForgeTypeId MPerKN { get; }
      Description: Symbol m/kN, indicating unit Meters per kilonewton.
    static ForgeTypeId MPerS { get; }
      Description: Symbol m/s, indicating unit Meters per second.
    static ForgeTypeId MPerSSup2 { get; }
      Description: Symbol m/sÂ², indicating unit Meters per second squared.
    static ForgeTypeId Mph { get; }
      Description: Symbol mph, indicating unit Miles per hour.
    static ForgeTypeId Ms { get; }
      Description: Symbol ms, indicating unit Milliseconds.
    static ForgeTypeId MSup2 { get; }
      Description: Symbol mÂ², indicating unit Square meters.
    static ForgeTypeId MSup2KPerW { get; }
      Description: Symbol (mÂ²Â·K)/W, indicating unit Square meter kelvins per watt.
    static ForgeTypeId MSup2PerKN { get; }
      Description: Symbol mÂ²/kN, indicating unit Square meters per kilonewton.
    static ForgeTypeId MSup2PerKw { get; }
      Description: Symbol mÂ²/kW, indicating unit Square meters per kilowatt.
    static ForgeTypeId MSup2PerM { get; }
      Description: Symbol mÂ²/m, indicating unit Square meters per meter.
    static ForgeTypeId MSup2PerS { get; }
      Description: Symbol mÂ²/s, indicating unit Square meters per second.
    static ForgeTypeId MSup3 { get; }
      Description: Symbol mÂ³, indicating unit Cubic meters.
    static ForgeTypeId MSup3PerH { get; }
      Description: Symbol mÂ³/h, indicating unit Cubic meters per hour.
    static ForgeTypeId MSup3PerHMSup2 { get; }
      Description: Symbol mÂ³/(hÂ·mÂ²), indicating unit Cubic meters per hour square meter.
    static ForgeTypeId MSup3PerHMSup3 { get; }
      Description: Symbol mÂ³/(hÂ·mÂ³), indicating unit Cubic meters per hour cubic meter.
    static ForgeTypeId MSup3PerKg { get; }
      Description: Symbol mÂ³/kg, indicating unit Cubic meters per kilogram.
    static ForgeTypeId MSup3PerKN { get; }
      Description: Symbol mÂ³/kN, indicating unit Cubic meters per kilonewton.
    static ForgeTypeId MSup3PerS { get; }
      Description: Symbol mÂ³/s, indicating unit Cubic meters per second.
    static ForgeTypeId MSup3PerWS { get; }
      Description: Symbol mÂ³/(WÂ·s), indicating unit Cubic meters per watt second.
    static ForgeTypeId MSup4 { get; }
      Description: Symbol mâ´, indicating unit Meters to the fourth power.
    static ForgeTypeId MSup6 { get; }
      Description: Symbol mâ¶, indicating unit Meters to the sixth power.
    static ForgeTypeId MV { get; }
      Description: Symbol mV, indicating unit Millivolts.
    static ForgeTypeId MW { get; }
      Description: Symbol MW, indicating unit Megawatts.
    static ForgeTypeId NDashM { get; }
      Description: Symbol N-m, indicating unit Newton meters.
    static ForgeTypeId NDashMPerM { get; }
      Description: Symbol N-m/m, indicating unit Newton meters per meter.
    static ForgeTypeId Newton { get; }
      Description: Symbol N, indicating unit Newtons.
    static ForgeTypeId NgPerPaSMSup2 { get; }
      Description: Symbol ng/(PaÂ·sÂ·mÂ²), indicating unit Nanograms per pascal second square meter.
    static ForgeTypeId NPerM { get; }
      Description: Symbol N/m, indicating unit Newtons per meter.
    static ForgeTypeId NPerMmSup2 { get; }
      Description: Symbol N/mmÂ², indicating unit Newtons per square millimeter.
    static ForgeTypeId NPerMSup2 { get; }
      Description: Symbol N/mÂ², indicating unit Newtons per square meter.
    static ForgeTypeId NSPerMSup2 { get; }
      Description: Symbol NÂ·s/mÂ², indicating unit Newton seconds per square meter.
    static ForgeTypeId OhmM { get; }
      Description: Symbol ohmÂ·m, indicating unit Ohm meters.
    static ForgeTypeId OneColon { get; }
      Description: Symbol 1:, indicating unit 1 : Ratio.
    static ForgeTypeId Pa { get; }
      Description: Symbol Pa, indicating unit Pascals.
    static ForgeTypeId PaDashS { get; }
      Description: Symbol Pa-s, indicating unit Pascal seconds.
    static ForgeTypeId PaPerM { get; }
      Description: Symbol Pa/m, indicating unit Pascals per meter.
    static ForgeTypeId Percent { get; }
      Description: Symbol %, indicating unit Percentage.
    static ForgeTypeId PerMille { get; }
      Description: Symbol â€°, indicating unit Per mille.
    static ForgeTypeId Pi { get; }
      Description: Symbol Ï€, indicating unit Multiples of Ï€.
    static ForgeTypeId Psf { get; }
      Description: Symbol psf, indicating unit Pounds force per square foot.
    static ForgeTypeId Psi { get; }
      Description: Symbol psi, indicating unit Pounds force per square inch.
    static ForgeTypeId Psia { get; }
      Description: Symbol psia, indicating unit Pounds force per square inch.
    static ForgeTypeId Psig { get; }
      Description: Symbol psig, indicating unit Pounds force per square inch.
    static ForgeTypeId Rad { get; }
      Description: Symbol rad, indicating unit Radians.
    static ForgeTypeId RadPerS { get; }
      Description: Symbol rad/s, indicating unit Radians per second.
    static ForgeTypeId Rpm { get; }
      Description: Symbol RPM, indicating unit Revolutions per minute.
    static ForgeTypeId Rps { get; }
      Description: Symbol RPS, indicating unit Revolutions per second.
    static ForgeTypeId Second { get; }
      Description: Symbol s, indicating unit Seconds.
    static ForgeTypeId Sf { get; }
      Description: Symbol SF, indicating unit Square feet.
    static ForgeTypeId SfHPerKbtu { get; }
      Description: Symbol SFÂ·h/kBtu, indicating unit Square feet per thousand British thermal units per hour.
    static ForgeTypeId SfPerMbh { get; }
      Description: Symbol SF/MBh, indicating unit Square feet per thousand British thermal units per hour.
    static ForgeTypeId SfPerTon { get; }
      Description: Symbol SF/ton, indicating unit Square feet per ton of refrigeration.
    static ForgeTypeId Shaku { get; }
      Description: Symbol å°º, indicating unit Shaku.
    static ForgeTypeId Shekel { get; }
      Description: Symbol â‚ª, indicating unit Currency.
    static ForgeTypeId SlopeDegree { get; }
      Description: Symbol Â°, indicating unit Slope degrees.
    static ForgeTypeId Stf { get; }
      Description: Symbol STf, indicating unit US tonnes force.
    static ForgeTypeId TCO2ePerBtu { get; }
      Description: Symbol tCOâ‚‚e/Btu, indicating tonnes Carbon Dioxide per British thermal unit
    static ForgeTypeId TCO2ePerFt { get; }
      Description: Symbol tCOâ‚‚e/ft, indicating tonnes Carbon Dioxide per foot
    static ForgeTypeId TCO2ePerFtSup2 { get; }
      Description: Symbol tCOâ‚‚e/ftÂ², indicating tonnes Carbon Dioxide per square foot
    static ForgeTypeId TCO2ePerFtSup3 { get; }
      Description: Symbol tCOâ‚‚e/ftÂ³, indicating kilograms Carbon Dioxide per cubic foot
    static ForgeTypeId TCO2ePerItem { get; }
      Description: Symbol tCOâ‚‚e/item, indicating tonnes Carbon Dioxide per item
    static ForgeTypeId TCO2ePerKBtu { get; }
      Description: Symbol tCOâ‚‚e/kBtu, indicating tonnes Carbon Dioxide per thousand British thermal units
    static ForgeTypeId TCO2ePerKg { get; }
      Description: Symbol tCOâ‚‚e/kg, indicating tonnes Carbon Dioxide per kilogram
    static ForgeTypeId TCO2ePerKWh { get; }
      Description: Symbol tCOâ‚‚e/KWh, indicating tonnes Carbon Dioxide per kilowatt hour
    static ForgeTypeId TCO2ePerLb { get; }
      Description: Symbol tCOâ‚‚e/lb, indicating tonnes Carbon Dioxide per pound
    static ForgeTypeId TCO2ePerM { get; }
      Description: Symbol tCOâ‚‚e/m, indicating tonnes Carbon Dioxide per meter
    static ForgeTypeId TCO2ePerMBtu { get; }
      Description: Symbol tCOâ‚‚e/MBtu, indicating tonnes Carbon Dioxide per million British thermal units
    static ForgeTypeId TCO2ePerMSup2 { get; }
      Description: Symbol tCOâ‚‚e/mÂ², indicating tonnes Carbon Dioxide per square meter
    static ForgeTypeId TCO2ePerMSup3 { get; }
      Description: Symbol tCOâ‚‚e/mÂ³, indicating tonnes Carbon Dioxide per cubic meter
    static ForgeTypeId TCO2ePerMWh { get; }
      Description: Symbol tCOâ‚‚e/MWh, indicating tonnes Carbon Dioxide per megawatt hour
    static ForgeTypeId Tf { get; }
      Description: Symbol Tf, indicating unit Tonnes force.
    static ForgeTypeId TfDashM { get; }
      Description: Symbol Tf-m, indicating unit Tonne force meters.
    static ForgeTypeId TfDashMPerM { get; }
      Description: Symbol Tf-m/m, indicating unit Tonne force meters per meter.
    static ForgeTypeId TfPerM { get; }
      Description: Symbol Tf/m, indicating unit Tonnes force per meter.
    static ForgeTypeId TfPerMSup2 { get; }
      Description: Symbol Tf/mÂ², indicating unit Tonnes force per square meter.
    static ForgeTypeId Therm { get; }
      Description: Symbol therm, indicating unit Therms.
    static ForgeTypeId Ton { get; }
      Description: Symbol ton, indicating unit Tons of refrigeration.
    static ForgeTypeId Tonne { get; }
      Description: Symbol t, indicating unit Tonnes.
    static ForgeTypeId TonOfRefrigeration { get; }
      Description: Symbol ton of refrigeration, indicating unit Tons of refrigeration.
    static ForgeTypeId Tonsf { get; }
      Description: Symbol Tonsf, indicating unit US tonnes force.
    static ForgeTypeId UinPerInDegreeF { get; }
      Description: Symbol Âµin/(inÂ·Â°F), indicating unit Microinches per inch degree Fahrenheit.
    static ForgeTypeId UkPound { get; }
      Description: Symbol Â£, indicating unit Currency.
    static ForgeTypeId UmPerMDegreeC { get; }
      Description: Symbol Âµm/(mÂ·Â°C), indicating unit Micrometers per meter degree Celsius.
    static ForgeTypeId UsDollar { get; }
      Description: Symbol $, indicating unit Currency.
    static ForgeTypeId Usft { get; }
      Description: Symbol USft, indicating unit US survey feet.
    static ForgeTypeId Usgph { get; }
      Description: Symbol usgph, indicating unit US gallons per hour.
    static ForgeTypeId Usgpm { get; }
      Description: Symbol usgpm, indicating unit US gallons per minute.
    static ForgeTypeId UsTonnesForceSt { get; }
      Description: Symbol ST, indicating unit US tonnes force.
    static ForgeTypeId UsTonnesForceT { get; }
      Description: Symbol T, indicating unit US tonnes force.
    static ForgeTypeId UsTonnesForceTons { get; }
      Description: Symbol Tons, indicating unit US tonnes force.
    static ForgeTypeId UsTonnesMassSt { get; }
      Description: Symbol ST, indicating unit US tonnes mass.
    static ForgeTypeId UsTonnesMassT { get; }
      Description: Symbol T, indicating unit US tonnes mass.
    static ForgeTypeId UsTonnesMassTons { get; }
      Description: Symbol Tons, indicating unit US tonnes mass.
    static ForgeTypeId VA { get; }
      Description: Symbol VA, indicating unit Volt amperes.
    static ForgeTypeId VAPerFtSup2 { get; }
      Description: Symbol VA/ftÂ², indicating unit Volt amperes per square foot.
    static ForgeTypeId VAPerMSup2 { get; }
      Description: Symbol VA/mÂ², indicating unit Volt amperes per square meter.
    static ForgeTypeId Volt { get; }
      Description: Symbol V, indicating unit Volts.
    static ForgeTypeId Watt { get; }
      Description: Symbol W, indicating unit Watts.
    static ForgeTypeId WMinPerFtSup3 { get; }
      Description: Symbol WÂ·min/ftÂ³, indicating unit Watts per cubic foot per minute.
    static ForgeTypeId Won { get; }
      Description: Symbol â‚©, indicating unit Currency.
    static ForgeTypeId WPerFt { get; }
      Description: Symbol W/ft, indicating unit Watts per foot.
    static ForgeTypeId WPerFtSup2 { get; }
      Description: Symbol W/ftÂ², indicating unit Watts per square foot.
    static ForgeTypeId WPerFtSup3 { get; }
      Description: Symbol W/ftÂ³, indicating unit Watts per cubic foot.
    static ForgeTypeId WPerM { get; }
      Description: Symbol W/m, indicating unit Watts per meter.
    static ForgeTypeId WPerMK { get; }
      Description: Symbol W/(mÂ·K), indicating unit Watts per meter kelvin.
    static ForgeTypeId WPerMSup2 { get; }
      Description: Symbol W/mÂ², indicating unit Watts per square meter.
    static ForgeTypeId WPerMSup2K { get; }
      Description: Symbol W/(mÂ²Â·K), indicating unit Watts per square meter kelvin.
    static ForgeTypeId WPerMSup3 { get; }
      Description: Symbol W/mÂ³, indicating unit Watts per cubic meter.
    static ForgeTypeId WSPerMSup3 { get; }
      Description: Symbol WÂ·s/mÂ³, indicating unit Watts per cubic meter per second.
    static ForgeTypeId YdCaret3 { get; }
      Description: Symbol yd^3, indicating unit Cubic yards.
    static ForgeTypeId YdSup3 { get; }
      Description: Symbol ydÂ³, indicating unit Cubic yards.
    static ForgeTypeId Yen { get; }
      Description: Symbol Â¥, indicating unit Currency.

--------------------------------------------------------------------------------

[CLASS] SynchronizeWithCentralOptions
Full Name: Autodesk.Revit.DB.SynchronizeWithCentralOptions
Description: Options to control behavior of synchronization with central.
Implements: IDisposable

  CONSTRUCTORS:
    new SynchronizeWithCentralOptions()
      Description: Constructs a new instance of SynchronizeWithCentralOptions initialized with default options.

  PROPERTIES:
    string Comment { get; set; }
      Description: User description of changes made since the last Sync with Central. Empty by default.
    bool Compact { get; set; }
      Description: Indicates whether Revit should compact the central model while synchronizing with central. This option reduces the size of the central model but many increase the time it takes to perform the save. False by default.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool RelinquishBorrowedElements { get; }
      Description: Indicates whether Revit should relinquish borrowed elements after synchronizing with central.
    bool RelinquishFamilyWorksets { get; }
      Description: Indicates whether Revit should relinquish Family worksets after synchronizing with central.
    bool RelinquishProjectStandardWorksets { get; }
      Description: Indicates whether Revit should relinquish Project Standard worksets after synchronizing with central.
    bool RelinquishUserCreatedWorksets { get; }
      Description: Indicates whether Revit should relinquish user-created Standard worksets after synchronizing with central.
    bool RelinquishViewWorksets { get; }
      Description: Indicates whether Revit should relinquish View worksets after synchronizing with central.
    bool SaveLocalAfter { get; set; }
      Description: True means to save local after saving changes to central. True by default. Silently ignored if the model in the current session is central rather than local.
    bool SaveLocalBefore { get; set; }
      Description: True means to save local before the first reload latest if there are changes not yet saved to local. True by default. Silently ignored if the model in the current session is central rather than local.
    bool SaveLocalFile { get; }
      Description: Indicates whether Revit will save the local file at least once while synchronizing with central.

  METHODS:
    void Dispose()
    RelinquishOptions GetRelinquishOptions()
      Description: Gets the options which govern whether or not to relinquish elements and workset types.
      Returns: The options. If , synchronize with central will relinquish the current user's ownership of all worksets and all elements.
    void SetRelinquishOptions(RelinquishOptions relinquishOptions)
      Description: Sets the options which govern whether or not to relinquish elements and workset types.
      @relinquishOptions: The options. If , synchronize with central will relinquish the current user's ownership of all worksets and all elements.

--------------------------------------------------------------------------------

