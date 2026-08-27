# Autodesk.Revit.DB.ExternalData

NAMESPACE: Autodesk.Revit.DB.ExternalData
--------------------------------------------------------------------------------

[CLASS] CoordinationModelElementProperty
Full Name: Autodesk.Revit.DB.ExternalData.CoordinationModelElementProperty
Description: A class that defines a property of an element inside a Coordination Model.
Implements: IDisposable

  PROPERTIES:
    string Group { get; }
      Description: The name of the group of properties to which this property belongs to. E.g. Group = Identity Data.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The name of the property.
    string Value { get; }
      Description: The value of the property provided as a string.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] CoordinationModelLinkData
Full Name: Autodesk.Revit.DB.ExternalData.CoordinationModelLinkData
Description: A class containing link data for Coordination Model type element.
Implements: IDisposable

  PROPERTIES:
    string DisplayPath { get; }
      Description: The user visible saved path of the local or Autodesk Docs file referenced by the Coordination Model link. For a Coordination Model from Autodesk Docs, displayPath should be like "Autodesk Docs://AccountName/ProjectName/Project Files/Nested/3DView".For a local Coordination Model, displayPath should be like "c:\Models\local.nwc", when the saved path type is absolute.For a local Coordination Model, displayPath should be like "local.nwc", when the saved path type is relative.
    string FileId { get; }
      Description: The id of the Autodesk Docs item defining this Coordination Model link. For a Coordination Model from Autodesk Docs, FileId is the id of the Autodesk Docs item defining this Coordination Model link.For a local Coordination Model, FileId has an empty value.
    double FileSize { get; }
      Description: The size (in Megabytes) of the local nwc or .nwd file defining the Coordination Model link. For a Coordination Model from Autodesk Docs, size is empty.For a local Coordination Model, fileSize is the size (in Megabytes) of nwc or .nwd file.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string ModelName { get; }
      Description: The name of the model defining this Coordination Model link. For a Coordination Model from Autodesk Docs, ModelName is the name of the model where the 3D view defining this Coordination Model is found.For a local Coordination Model, ModelName is the name of the local .nwc or .nwd file.
    string ProjectId { get; }
      Description: The id in the Data Management API of the Autodesk Docs project where the model view defining this Coordination Model link is found. For a Coordination Model from Autodesk Docs, ProjectId is the id in the Data Management API of the Autodesk Docs project where the model view is found.For a local Coordination Model, ProjectId has an empty value.
    string SourcePath { get; }
      Description: The full source path of the external resource defining this Coordination Model link. For a Coordination Model from Autodesk Docs, sourcePath is the URN of the .svf file and it should look like "https://developer.api.autodesk.com/modelderivative/v2/designdata/dXJuOmFkc2sub2JqZWN0czpvcy5vYmplY3Q6Zm9yZ2UtYmxvZy1wb3N0L1VyYmFuSG91c2UtMjAxNS5ydnQ/manifest/urn:adsk.viewing:fs.file:dXJuOmFkc2sub2JqZWN0czpvcy5vYmplY3Q6Zm9yZ2UtYmxvZy1wb3N0L1VyYmFuSG91c2UtMjAxNS5ydnQ/output/Resource/3D_View/3D_Architectural 144171/3D_Architectural.svf".For a local Coordination Model, sourcePath is the absolute path on disk to the .nwc or .nwd file and it should look like "c:\Models\local.nwc".
    string VersionLabel { get; }
      Description: The label of the last saved version of this Coordination Model Link in Revit document. For a Coordination Model from Autodesk Docs, VersionLabel is the label of the last saved version of this Coordination Model Link in Revit document.For a local Coordination Model, VersionLabel has an empty value.
    string ViewName { get; }
      Description: The name of the Autodesk Docs view defining this Coordination Model. For a Coordination Model from Autodesk Docs, ViewName is the name of the view defining this Coordination Model.For a local Coordination Models, ViewName has an empty value.

  METHODS:
    void Dispose()
    IList<string> GetCategoryNames()
      Description: Return the category names of all elements inside the current Coordination Model Link from Autodesk Docs.
      Returns: Returns an array of category names for elements inside a Coordination Model from Autodesk Docs. Returns an empty array for a local Coordination Model.
    CoordinationModelLinkPathType GetPathType()
      Description: Returns the path type of the Coordination Model link. For a Coordination Model from Autodesk Docs, path type is Cloud.For a local Coordination Model, path type can be Absolute or Relative.

--------------------------------------------------------------------------------

[CLASS] CoordinationModelLinkOptions
Full Name: Autodesk.Revit.DB.ExternalData.CoordinationModelLinkOptions
Description: A class containing link options for Coordination Models.
Implements: IDisposable

  CONSTRUCTORS:
    new CoordinationModelLinkOptions()
      Description: Constructs a default instance of Coordination Model link options with the default CoordinationModelPositioning. The default CoordinationModelPositioning is OriginToInternalOrigin.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    CoordinationModelPositioning Positioning { get; set; }
      Description: Placement option for Coordination Model linking.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] CoordinationModelLinkPathType
Full Name: Autodesk.Revit.DB.ExternalData.CoordinationModelLinkPathType
Description: An enumerated type representing the options for the path type of a Coordination Model.
Inherits: Enum

  Values:
    - Absolute = 0
    - Relative = 1
    - Cloud = 2

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CoordinationModelLinkUtils
Full Name: Autodesk.Revit.DB.ExternalData.CoordinationModelLinkUtils
Description: The methods provided by this utility class support the managing of Coordination Model links in Revit documents and their visibility settings control in Revit views.
Remarks: Coordination Model links can be created from Autodesk Docs 3D views or local .nwc or .nwd files.A Coordination Model type holds the data that defines the link to a Autodesk Docs 3D view or a local .nwc or .nwd file. This data can be retrieved in the CoordinationModelLinkData object.A Coordination Model type can have multiple Coordination Model instances.Coordination Model type is an ElementType of BuiltInCategory.OST_Coordination_Model category. Coordination Model instance is an Element of BuiltInCategory.OST_Coordination_Model category.

  METHODS:
    static bool ContainsCategory(Document document, ElementType coordinationModelType, string categoryName)
      Description: Checks whether a provided string is a element category name in the provided AutodeskDocs Coordination Model type.
      @document: The document.
      @coordinationModelType: The Coordination Model type element.
      @categoryName: The element category name to check.
      Returns: True if the categoryName is a element category name in the provided AutodeskDocs Coordination Model type; false otherwise.
      Throws ArgumentException: categoryName is an empty string. -or- The provided element is not a Autodesk Docs Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
    static ISet<ElementId> GetAllCoordinationModelInstanceIds(Document document)
      Description: Gets all Coordination Model instance ids in the document.
      @document: The document.
      Returns: Returns the set of element ids of all Coordination Model instances in the document.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static ISet<ElementId> GetAllCoordinationModelTypeIds(Document document)
      Description: Gets all Coordination Model type ids in the document.
      @document: The document.
      Returns: Returns the set of element ids of all Coordination Model types in the document.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static IList<CoordinationModelElementProperty> GetAllPropertiesForReferenceInsideCoordinationModel(Document document, Element coordinationModelInstance, Reference reference)
      Description: Gets all the properties for the provided Coordination Model instance reference.
      @document: The document.
      @coordinationModelInstance: The Coordination Model instance element where the provided reference is found.
      @reference: The reference to the element inside the provided Coordination Model instance.
      Returns: Returns a list of properties for the provided Coordination Model instance reference.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelInstance was not found in the given document. -or- The provided Reference is not a valid element inside the provided Coordination Model instance. -or- The provided element is not a Autodesk Docs Coordination Model instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to validate web services environment. -or- Failed to validate authentication. -or- The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static string GetCategoryForReferenceInsideCoordinationModel(Document document, Element coordinationModelInstance, Reference reference)
      Description: Returns the category name for the provided element reference inside the provided Coordination Model instance.
      @document: The document.
      @coordinationModelInstance: The Coordination Model instance element where the provided reference is found.
      @reference: The reference to the element inside the provided Coordination Model instance.
      Returns: Returns the category name for the provided reference inside the Coordination Model instance.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelInstance was not found in the given document. -or- The provided element is not a Autodesk Docs Coordination Model instance. -or- The provided Reference is not a valid element inside the provided Coordination Model instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static Color GetColorOverride(Document document, View view, Element coordinationModelType)
      Description: Gets the color override value for the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element.
      Returns: Returns the color override value of the Coordination Model type. InvalidColorValue means no override is set.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static Color GetColorOverrideForCategory(Document document, View view, ElementType coordinationModelType, string categoryName)
      Description: Returns the color override value for the provided element category name inside the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element where the provided element category name is found.
      @categoryName: The name of the element category inside the provided Coordination Model type.
      Returns: Returns the color override value for the provided element category name inside the provided Coordination Model type. InvalidColorValue means no override is set.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The name categoryName is not a category name in the provided AutodeskDocs Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static CoordinationModelLinkData GetCoordinationModelTypeData(Document document, ElementType coordinationModelType)
      Description: Gets link data for the provided Coordination Model type.
      @document: The document.
      @coordinationModelType: The Coordination Model type element.
      Returns: Returns Coordination Model type data defining the link to the Autodesk Docs 3D view or the .nwc or .nwd file.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static int GetTransparencyOverride(Document document, View view, Element coordinationModelType)
      Description: Gets the transparency override value for the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element.
      Returns: Returns the transparency value (in percentage). A 0-value transparency means no override is set.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static bool GetVisibilityOverride(Document document, View view, Element coordinationModelTypeOrInstance)
      Description: Gets the visibility override for the provided Coordination Model instance or type.
      @document: The document.
      @view: The view.
      @coordinationModelTypeOrInstance: The Coordination Model instance or type element.
      Returns: Returns the visibility override for the provided Coordination Model instance or type.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelTypeOrInstance was not found in the given document. -or- The provided element is not a Coordination Model instance or type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static bool GetVisibilityOverrideForCategory(Document document, View view, ElementType coordinationModelType, string categoryName)
      Description: Gets the visibility override for the provided element category name in the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element where the provided element category name is found.
      @categoryName: The name of the element category inside the provided Coordination Model type.
      Returns: Returns the visibility override for the provided element category name in the provided Coordination Model type. A value of true means that the graphics are visible.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The name categoryName is not a category name in the provided AutodeskDocs Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static bool GetVisibilityOverrideForReferenceInsideCoordinationModel(Document document, View view, Element coordinationModelInstance, Reference reference)
      Description: Gets the visibility for the provided reference inside the Coordination Model from Autodesk Docs.
      @document: The document.
      @view: The view.
      @coordinationModelInstance: The Coordination Model instance element where the provided reference is found.
      @reference: The reference to the element inside the provided Coordination Model instance.
      Returns: Returns the visibility for the provided reference inside the Coordination Model instance.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelInstance was not found in the given document. -or- The provided Reference is not a valid element inside the provided Coordination Model instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static bool IsCoordinationModelInstance(Document document, Element element)
      Description: Checks whether an element is a Coordination Model instance.
      @document: The document.
      @element: The element to check.
      Returns: True if the element is Coordination Model instance; false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsCoordinationModelType(Document document, Element coordinationModelType)
      Description: Checks whether an element is a Coordination Model type.
      @document: The document.
      @coordinationModelType: The element to check.
      Returns: True if the element is Coordination Model type; false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static Element Link3DViewFromAutodeskDocs(Document document, string accountId, string projectId, string fileId, string viewName, CoordinationModelLinkOptions linkOptions)
      Description: Creates a Coordination Model instance based on the information provided by the specified Autodesk Docs data and linking options.
      @document: The document.
      @accountId: The id of the Autodesk Docs account.
      @projectId: The id of the Autodesk Docs project.
      @fileId: The id of the Autodesk Docs file. A valid file id should start with "urn:WIPENVIRONMENT:dm.lineage:", followed by an unique identifier. The WIPENVIRONMENT varies from Region to Region. For example, for an account created in US Region, WIPENVIRONMENT = adsk.wipprod and a valid file id would be urn:adsk.wipprod:dm.lineage:AoV26TGqRjuNs4ANq84ncQ.
      @viewName: View name.
      @linkOptions: Options for linking.
      Returns: Returns the newly added Coordination Model instance of the 3D view from Autodesk Docs.
      Throws ArgumentException: Failed to validate file id. -or- document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to validate web services environment. -or- Failed to validate authentication. -or- The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- Failed to create Coordination Model instance using specified data or an internal error occured.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Element LinkCoordinationModelFromLocalPath(Document document, string filePath, CoordinationModelLinkOptions linkOptions)
      Description: Creates a Coordination Model instance using the absolute path of a .nwc or .nwd file and the linking options.
      @document: The document.
      @filePath: The file's absolute or relative path.
      @linkOptions: Options for linking.
      Returns: Returns the newly added Coordination Model instance of the local .nwc or .nwd file.
      Throws ArgumentException: Failed to validate file type. -or- document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given filePath does not exist.
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- Failed to create Coordination Model instance from specified path.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void Reload(Document document, ElementType coordinationModelType)
      Description: Reloads the provided Coordination Model type element.
      @document: The document.
      @coordinationModelType: The Coordination Model type element to reload.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type. -or- This operation is not supported for scenario-based coordination models. Scenario-based coordination models are read-only and their source is managed by the scenario system.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to validate web services environment. -or- Failed to validate user authentication. -or- The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- Failed to reload Coordination Model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void ReloadAutodeskDocsCoordinationModelFrom(Document document, ElementType coordinationModelType, string accountId, string projectId, string fileId, string viewName)
      Description: Reloads a Autodesk Docs Coordination Model type from the specified Autodesk Docs data.
      @document: The document.
      @coordinationModelType: The Coordination Model type element to reload.
      @accountId: The id of the Autodesk Docs account.
      @projectId: The id of the Autodesk Docs project.
      @fileId: The id of the Autodesk Docs file. A valid file id should start with "urn:WIPENVIRONMENT:dm.lineage:", followed by an unique identifier. The WIPENVIRONMENT varies from Region to Region. For example, for an account created in US Region, WIPENVIRONMENT = adsk.wipprod and a valid file id would be urn:adsk.wipprod:dm.lineage:AoV26TGqRjuNs4ANq84ncQ.
      @viewName: View name.
      Throws ArgumentException: Failed to validate file id. -or- document is not a project document. -or- The provided element is not a Autodesk Docs Coordination Model type. -or- This operation is not supported for scenario-based coordination models. Scenario-based coordination models are read-only and their source is managed by the scenario system.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to validate web services environment. -or- Failed to validate authentication. -or- The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- Failed to reload Coordination Model type from specified Autodesk Docs data.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void ReloadLocalCoordinationModelFrom(Document document, ElementType coordinationModelType, string filePath)
      Description: Reloads a local Coordination Model type from the specified absolute path of a .nwc or .nwd file.
      @document: The document.
      @coordinationModelType: The Coordination Model type element to reload.
      @filePath: The file's absolute or relative path to reload from.
      Throws ArgumentException: Failed to validate file type. -or- document is not a project document. -or- The provided element is not a local Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given filePath does not exist.
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- Failed to reload Coordination Model type from specified path.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void SetColorOverride(Document document, View view, Element coordinationModelType, Color color)
      Description: Sets the color override value for the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element.
      @color: Value of the color for the override. InvalidColorValue means no override is set.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void SetColorOverrideForCategory(Document document, View view, ElementType coordinationModelType, string categoryName, Color color)
      Description: Set the color override value for the provided element category name inside the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element where the provided element category name is found.
      @categoryName: The name of the element category inside the provided Coordination Model type.
      @color: Color override value for the provided element category name inside the provided Coordination Model type. InvalidColorValue means no override is set.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The name categoryName is not a category name in the provided AutodeskDocs Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void SetTransparencyOverride(Document document, View view, Element coordinationModelType, int transparency)
      Description: Sets the transparency override value for the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element.
      @transparency: The transparency value to apply (in percentage). A 0-value transparency means no override is set.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The value is invalid. The valid range is 0 through 100
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void SetVisibilityOverride(Document document, View view, Element coordinationModelTypeOrInstance, bool visible)
      Description: Sets the visibility override for the provided Coordination Model instance or type. A value of true means that the graphics are visible.
      @document: The document.
      @view: The view.
      @coordinationModelTypeOrInstance: The Coordination Model instance or type element.
      @visible: Sets the visibility override for the provided Coordination Model instance or type. A value of true means that the graphics are visible.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelTypeOrInstance was not found in the given document. -or- The provided element is not a Coordination Model instance or type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void SetVisibilityOverrideForCategory(Document document, View view, ElementType coordinationModelType, string categoryName, bool visible)
      Description: Sets the visibility override for the provided element category name inside the provided Coordination Model type.
      @document: The document.
      @view: The view.
      @coordinationModelType: The Coordination Model type element where the provided element category name is found.
      @categoryName: The name of the category inside the provided Coordination Model type.
      @visible: Sets the visibility override for the provided element category name inside the provided Coordination Model type.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The name categoryName is not a category name in the provided AutodeskDocs Coordination Model type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void SetVisibilityOverrideForReferenceInsideCoordinationModel(Document document, View view, Element coordinationModelInstance, Reference reference, bool visible)
      Description: Sets the visibility override for the provided reference inside the Coordination Model instance. A value of true means that the graphics are visible.
      @document: The document.
      @view: The view.
      @coordinationModelInstance: The Coordination Model instance element where the provided reference is found.
      @reference: The reference to the element inside the provided Coordination Model instance.
      @visible: Sets the visibility override for the provided reference inside the Coordination Model instance. A value of true means that the graphics are visible.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelInstance was not found in the given document. -or- The provided Reference is not a valid element inside the provided Coordination Model instance.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void Unload(Document document, ElementType coordinationModelType)
      Description: Unloads the provided Coordination Model type element.
      @document: The document.
      @coordinationModelType: The Coordination Model type element to unload.
      Throws ArgumentException: document is not a project document. -or- The element coordinationModelType was not found in the given document. -or- The provided element is not a Coordination Model type. -or- This operation is not supported for scenario-based coordination models. Scenario-based coordination models are read-only and their source is managed by the scenario system.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- Failed to unload Coordination Model.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[ENUM] CoordinationModelPositioning
Full Name: Autodesk.Revit.DB.ExternalData.CoordinationModelPositioning
Description: An enumerated type listing possible placement modes for linking Coordination Models.
Inherits: Enum

  Values:
    - OriginToInternalOrigin = 0
    - BySharedCoordinates = 1

--------------------------------------------------------------------------------

[CLASS] ExtendedParameterElement
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedParameterElement
Description: An element that stores the definition of an extended property created by an extended properties link.
Inherits: ParameterElement

  PROPERTIES:
    ElementId LinkId { get; }
      Description: The ID of the Autodesk::Revit::DB::ExternalData::ExtendedPropertiesLink to which this extended property belongs.

--------------------------------------------------------------------------------

[CLASS] ExtendedPropertiesBindings
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedPropertiesBindings
Description: Establishes the bindings for a given extended property. Supports the same style of binding as shared/project parameters - category and type vs instance.
Implements: IDisposable

  CONSTRUCTORS:
    new ExtendedPropertiesBindings(ExtendedPropertiesBindingType bindingType, ISet<ForgeTypeId> boundCategories)
      Description: Creates a new ExtendedPropertiesBindings
      @bindingType: Binding type.
      @boundCategories: Identifiers of the categories for this binding.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ExtendedPropertiesBindings()
      Description: Creates a new ExtendedPropertiesBindings

  PROPERTIES:
    ExtendedPropertiesBindingType BindingType { get; set; }
      Description: Indicates type vs instance bindings. Defaults to Instance.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddCategories(ICollection<ForgeTypeId> categories)
      Description: Adds multiple categories to the bindings.
      @categories: Identifiers of the categories.
      Throws ArgumentNullException: A non-optional argument was null
    void AddCategory(ForgeTypeId categoryId)
      Description: Adds a category id to the bindings.
      @categoryId: Identifier of the category.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ExtendedPropertiesBindingType
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedPropertiesBindingType
Description: Enumeration type to indicate whether extended properties should be bound to instances or types.
Inherits: Enum

  Values:
    - Instance = 0
    - Type = 1

--------------------------------------------------------------------------------

[CLASS] ExtendedPropertiesLink
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedPropertiesLink
Description: Represents a collection of extended properties linked to a Revit model.
Inherits: Element

  METHODS:
    static LinkLoadResult Create(Document doc, ExternalResourceReference externalReference)
      Description: Creates the ExtendedPropertiesLink in the given document.
      @doc: Document which will gain an ExtendedPropertiesLink.
      @externalReference: Reference to external information containing extended properties.
      Returns: Information about the ExtendedPropertiesLink.
      Throws ArgumentException: The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The ExternalResourceReference (externalReference) is not in a format that is supported by its server. -or- The given externalReference does not refer to a server that supports extended properties. -or- The document does not support extended properties links.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static LinkLoadResult CreateFromCloudDataset(Document doc, string datasetId)
      Description: Creates the ExtendedPropertiesLink in the given document from a cloud dataset.
      @doc: Document which will gain an ExtendedPropertiesLink. The document must correspond to a cloud model.
      @datasetId: The id of the dataset in Autodesk Construction Cloud; it should be hosted in the same project as the document. A valid dataset id should start with "urn:WIPENVIRONMENT:dm.lineage:", followed by an unique identifier. The WIPENVIRONMENT varies from Region to Region. An example of a valid dataset id for an account created in the US Region would be urn:adsk.wipprod:dm.lineage:AoV26TGqRjuNs4ANq84ncQ.
      Returns: Information about the ExtendedPropertiesLink.
      Throws ArgumentException: doc is a not cloud model, cannot execute this operation. -or- The document must be a cloud model with a valid project id. -or- The document does not support extended properties links.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The extended properties server does not exist.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    IList<ElementId> GetAllAssociatedPropertyIds()
      Description: Retrieves all ids, each corresponding to a Autodesk::Revit::DB::ExternalData::ExtendedParameterElement associated with this link.
    LinkLoadResult LoadFrom(ExternalResourceReference externalReference)
      Description: Reloads the ExtendedPropertiesLink with the latest information from the server using the specified ExternalResourceReference.
      @externalReference: The location of the extended properties.
      Throws ArgumentException: The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The ExternalResourceReference (externalReference) is not in a format that is supported by its server. -or- The given externalReference does not refer to a server that supports extended properties.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This ExtendedPropertiesLink does not contain an external resource reference compatible with the ExternalResourceType. -or- The document does not support extended properties links.
      Throws ModificationForbiddenException: The document containing this ExtendedPropertiesLink is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this ExtendedPropertiesLink is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this ExtendedPropertiesLink has no open transaction.
    LinkLoadResult Reload()
      Description: Reloads the linked extended properties with the latest information.
      Throws ArgumentException: The server referenced by the stored ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The stored ExternalResourceReference is not in a format that is supported by its server. -or- The stored ExternalResourceReference is not supported by the external server associated with this link.
      Throws InvalidOperationException: This ExtendedPropertiesLink does not contain an external resource reference compatible with the ExternalResourceType. -or- The document does not support extended properties links.
      Throws ModificationForbiddenException: The document containing this ExtendedPropertiesLink is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing this ExtendedPropertiesLink is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing this ExtendedPropertiesLink has no open transaction.

--------------------------------------------------------------------------------

[CLASS] ExtendedPropertiesLinkData
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedPropertiesLinkData
Description: Represents the data needed to establish or update an ExtendedPropertiesLink. To be used as part of the result of invoking an external server in order to update or create an ExtendedPropertiesLink.
Implements: IDisposable

  CONSTRUCTORS:
    new ExtendedPropertiesLinkData()
      Description: Constructs an empty object which can be used to add parameter schemas, bindings, and values.

  PROPERTIES:
    string ContainerName { get; set; }
      Description: The extended properties container name used as a custom group in the properties palette.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Region { get; set; }
      Description: The region of the account that contains the parameter definitions.

  METHODS:
    void AddParameterSchemaWithBindings(ForgeTypeId schemaId, ExtendedPropertiesBindings bindings)
      Description: Adds a schema id to the extended properties link.
      @schemaId: Identifier of the schema to add.
      @bindings: The bindings for the schema.
      Throws ArgumentException: The ForgeTypeId represents a malformed schema identifier. -or- Thrown when the schemaId already contains bindings.
      Throws ArgumentNullException: A non-optional argument was null
    bool AddValues(LinkElementId elementId, ExtendedPropertiesLinkValues values)
      Description: Adds the provided parameter values to the Revit Element identified by %elementId%.
      @elementId: The identifier of the Element to add the parameter values.
      @values: The values to be added.
      Returns: True if all of the values were added, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    bool HasSchema(ForgeTypeId schemaId)
      Description: Queries whether the schema already exists in this data.
      @schemaId: Identifier of the schema to check.
      Returns: True if the schema already exists in this data, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidContainerName(string containerName)
      Description: Validates that the given name is valid for use as the container name of an extended properties link.
      Returns: True if the name can be used as the container name of an extended properties link. False otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ExtendedPropertiesLinkLoadContent
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedPropertiesLinkLoadContent
Description: Represents the data needed to establish or update an ExtendedPropertiesLink. To be used as the result of invoking an external server in order to update or create an ExtendedPropertiesLink.
Inherits: ExternalResourceLoadContent

  METHODS:
    void SetExtendedPropertiesLinkData(ExtendedPropertiesLinkData data)
      Description: Sets the extended properties data from the external server.
      @data: The extended properties data to set.
      Throws ArgumentException: The extended properties data does not contain a valid container name.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ExtendedPropertiesLinkValues
Full Name: Autodesk.Revit.DB.ExternalData.ExtendedPropertiesLinkValues
Description: Holds information which can be converted to Revit parameter values
Implements: IDisposable

  CONSTRUCTORS:
    new ExtendedPropertiesLinkValues()
      Description: Creates a new ExtendedPropertiesLinkValues.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool AddValue(ForgeTypeId schemaId, string value)
      Description: Add a string value for a given schema id.
      @schemaId: Identifier of the schema.
      @value: The string value.
      Returns: True if the data was added, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool AddValue(ForgeTypeId schemaId, double value)
      Description: Add a double value for a given schema id.
      @schemaId: Identifier of the schema.
      @value: The double value in the storage unit of schema.
      Returns: True if the data was added, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool AddValue(ForgeTypeId schemaId, int value)
      Description: Add an integer value for a given schema id.
      @schemaId: Identifier of the schema.
      @value: The integer value.
      Returns: True if the data was added, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()

--------------------------------------------------------------------------------

