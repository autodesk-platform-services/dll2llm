# Autodesk.Revit.DB (Types: V, W, X, Y, Z)

[CLASS] ValidateCurveLoopsOptions
Full Name: Autodesk.Revit.DB.ValidateCurveLoopsOptions

Description: Options for array of curve loops validation.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ValueAtPointBase
Full Name: Autodesk.Revit.DB.ValueAtPointBase

Description: A base class representing storage of values at a given point.
Remarks: This class stores a set of measurements and corresponding mapped flags. The flags are defined in the enumerated type ValueAtPointFlags.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void ClearAllFlags()
      Description: Sets flags for all measurements to ValueAtPointFlags::None.
    void ClearFlagsAt(int measurement)
      Description: Sets flags for the given measurement to ValueAtPointFlags::None.
      @measurement: Measurement for which to clear flags.
    void Dispose()
    int GetFlags(int measurement)
      Description: Returns flags for the given measurement.
      @measurement: Measurement number for which flags are returned.
      Returns: Flags value for the measurement.
    void SetFlags(int flags, int measurement)
      Description: Sets the flags associated to a given measurement.
      @flags: The value of the flags to set. Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.
      @measurement: Measurement for which to set flags.
    void SetFlags(int flags)
      Description: Sets the flags associated to all measurements to the same value.
      @flags: Value of flags, uniform for all measurements. Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.
    void SetFlags(IList<int> flags)
      Description: Independently sets the flags associated to all measurements.
      @flags: An array of flags values. Each member corresponds to a measurement. Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value. Number of measurements is set at creation of SpatialFieldManager in method createSpatialFieldManager.

--------------------------------------------------------------------------------


[ENUM] ValueAtPointFlags
Full Name: Autodesk.Revit.DB.ValueAtPointFlags

Description: Enumerated type containing flags related to the display on particular points. Enumerated type that stores bit values of flags that can be set at any domain point.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - DisplayText = 1
    - DisplayFence = 2


[CLASS] ValueParsingOptions
Full Name: Autodesk.Revit.DB.ValueParsingOptions

Description: Options for parsing strings into numbers with units.
Implements: IDisposable

  CONSTRUCTORS:
    new ValueParsingOptions()

  PROPERTIES:
    AllowedValues AllowedValues { get; set; }
      Description: The allowable range of values to be parsed.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    FormatOptions GetFormatOptions()
      Description: Gets the FormatOptions to optionally override the default settings in the Units class.
      Returns: A copy of the FormatOptions.
    void SetFormatOptions(FormatOptions formatOptions)
      Description: Sets the FormatOptions to optionally override the default settings in the Units class.
      @formatOptions: The FormatOptions.

--------------------------------------------------------------------------------


[CLASS] VertexIndexPair
Full Name: Autodesk.Revit.DB.VertexIndexPair

Description: Represents a connection between vertices in the top and bottom profile of a blend.
Remarks: Use objects of this type in , , and to get/set the vertex connection map.

  CONSTRUCTORS:
    new VertexIndexPair(int iTop, int iBottom)

  PROPERTIES:
    int Bottom { get; set; }
      Description: The index of the vertex pair from the bottom profile.
    int Top { get; set; }
      Description: The index of the vertex pair from the top profile.

--------------------------------------------------------------------------------


[CLASS] VertexIndexPairArray
Full Name: Autodesk.Revit.DB.VertexIndexPairArray

Description: An array that contains VertexIndex pairs.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new VertexIndexPairArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    VertexIndexPair Item { get; set; }
    int Size { get; }
      Description: Returns the number of VertexIndex pairs that are in the array.

  METHODS:
    void Append(VertexIndexPair item)
    void Clear()
      Description: Removes every VertexIndex pair from the array, rendering it empty.
    VertexIndexPairArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(VertexIndexPair item, int index)
    VertexIndexPairArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] VertexIndexPairArrayIterator
Full Name: Autodesk.Revit.DB.VertexIndexPairArrayIterator

Description: An iterator to an array of VertexIndex pairs.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new VertexIndexPairArrayIterator()

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


[CLASS] VertexPair
Full Name: Autodesk.Revit.DB.VertexPair

Description: Indices of a pair of vertices in two CurveLoops(one vertex in each loop).
Remarks: A vertex is specified by the index in the CurveLoop of the curve having that vertex as its start point. Indexes start at 0.
Implements: IDisposable

  CONSTRUCTORS:
    new VertexPair(int firstVertexIdx, int secondVertexIdx)

  PROPERTIES:
    int First { get; set; }
      Description: Identifies the first index of VertexPair.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Second { get; set; }
      Description: Identifies the second index of VertexPair.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] VerticalAlignmentStyle
Full Name: Autodesk.Revit.DB.VerticalAlignmentStyle

Description: Declares the vertical alignment style of font.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Top = 0
    - Middle = 4
    - Bottom = 8


[ENUM] VerticalTextAlignment
Full Name: Autodesk.Revit.DB.VerticalTextAlignment

Description: Supported types of vertical alignment of a text element.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Top = 0
    - Bottom = 1
    - Middle = 2


[CLASS] View
Full Name: Autodesk.Revit.DB.View

Description: Base class for all types of views in Autodesk Revit.
Remarks: A view can display an image produced from a Revit model. Views can be graphical (e.g. plans, elevations, or 3D views) or textual (e.g. schedules). Views keep track of Elements that can be seen in them.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId AnalysisDisplayStyleId { get; set; }
      Description: Element id of Analysis Display Style associated with the view.
    bool AreAnalyticalModelCategoriesHidden { get; set; }
      Description: Indicates if analytical model categories are currently hidden in the view.
    bool AreAnnotationCategoriesHidden { get; set; }
      Description: Indicates if annotation categories are currently hidden in the view.
    bool AreCoordinationModelHandlesHidden { get; set; }
      Description: Indicates if Coordination Model handles are currently hidden in the view.
    bool AreImportCategoriesHidden { get; set; }
      Description: Indicates if import categories are currently hidden in the view.
    bool AreModelCategoriesHidden { get; set; }
      Description: Indicates if model categories are currently hidden in the view.
    bool ArePointCloudsHidden { get; set; }
      Description: Indicates if point clouds are currently hidden in the view.
    ElementId AssociatedAssemblyInstanceId { get; }
      Description: The Id of the assembly instance that owns the assembly view.
    bool CanBePrinted { get; }
      Description: Test whether the view can be printed.
    BoundingBoxXYZ CropBox { get; set; }
      Description: The Crop Box applied to the view, or an outline encompassing the crop region applied to the view.
    bool CropBoxActive { get; set; }
      Description: Whether or not the Crop Box/Region is active for the view.
    bool CropBoxVisible { get; set; }
      Description: Whether or not the Crop Box/Region is visible for the view.
    ViewDetailLevel DetailLevel { get; set; }
      Description: The detail level of this view.
    ViewDiscipline Discipline { get; set; }
      Description: The Discipline of the view.
    DisplayStyle DisplayStyle { get; set; }
      Description: The DisplayStyle of the view. Returns DisplayStyle.Wireframe if the view has no display style.
    Level GenLevel { get; }
      Description: The level for the view.
    bool IsAssemblyView { get; }
      Description: Indicates if the view is assembly view.
    bool IsCallout { get; }
      Description: Indicates if the view is a callout view.
    bool IsTemplate { get; }
      Description: Test whether the view is a view template.
    XYZ Origin { get; }
      Description: Returns the origin of the screen.
    BoundingBoxUV Outline { get; }
      Description: The bounds of the view in paper space (in feet).
    PartsVisibility PartsVisibility { get; set; }
      Description: The visibility setting for parts in this view.
    bool RevealConstraintsMode { get; set; }
      Description: Indicates whether the Reveal Constraints mode is activated in the view.
    XYZ RightDirection { get; }
      Description: The direction towards the right side of the screen.
    int Scale { get; set; }
      Description: The scale of the view.
    int ShadowIntensity { get; set; }
      Description: The intesity of cast shadows - 0 = no shadows, 100 = black.
    SketchPlane SketchPlane { get; set; }
      Description: The sketch plane assigned to the view for model curve creation.
    SunAndShadowSettings SunAndShadowSettings { get; }
      Description: The sun and shadow settings assigned to the view for shadow calculation and rendering.
    int SunlightIntensity { get; set; }
      Description: The intensity of the simulated (directional) sunlight. 0 = no directional light; maximum value is 100.
    TemporaryViewModes TemporaryViewModes { get; }
      Description: Data of temporary view modes associated with this view.
    string Title { get; }
      Description: The view title. This consists of the view name plus other modifiers, such as the view type, sheet number, area scheme, and/or assembly type, depending on the specifics of the view.
    XYZ UpDirection { get; }
      Description: The direction towards the top of the screen.
    XYZ ViewDirection { get; }
      Description: The direction towards the viewer.
    ElementId ViewTemplateId { get; set; }
      Description: The id of the template view that controls this view's parameters.
    ViewType ViewType { get; }
      Description: The type of the view.

  METHODS:
    void AddFilter(ElementId filterElementId)
      Description: Adds a filter to the view.
      @filterElementId: ElementId of the filter.
    bool AllowsAnalysisDisplay()
      Description: Identifies if this view allows display of Analysis results.
      Returns: True if the view allows display of Analysis results, false otherwise.
    void ApplyViewTemplateParameters(View otherView)
      Description: Applies to this view the parameters of the input view that are not controlled by the current view template.
      @otherView: The view whose parameters are to be applied to this view. It does not have to be a valid template (property IsTemplate can be true or false).
    bool AreGraphicsOverridesAllowed()
      Description: Determines if Visibility/Graphics Overriddes can be applied to the view.
      Returns: True if Overriddes can be applied to the view, false otherwise.
    bool CanApplyColorFillScheme(ElementId categoryId, ElementId schemeId)
      Description: Checks if the id can be applied as the scheme id of specified category to this view.
      @categoryId: The id of category.
      @schemeId: The id of color fill scheme.
      Returns: True if the id can be applied as the scheme id of specified category in this view, false otherwise.
    bool CanCategoryBeHidden(ElementId elementId)
      Description: Checks whether the category can be hidden in the view.
      @elementId: ElementId of the category.
      Returns: True if the category can be hidden, false otherwise.
    bool CanCategoryBeHiddenTemporary(ElementId elementId)
      Description: Check if category can be temporarily hidden in the view.
      @elementId: Id of the category to be checked
    bool CanEnableTemporaryViewPropertiesMode()
      Description: Indicates if Temporary View Properties mode can be applied for view in current state.
      Returns: True if view can use Temporary View Properties mode in current state.
    bool CanModifyDetailLevel()
      Description: Check if Detail Level can be modified.
      Returns: True if Detail Level can be modified.
    bool CanModifyDisplayStyle()
      Description: Indicates if DisplayStyle can be modified.
      Returns: True if DisplayStyle can be modified.
    bool CanModifyViewDiscipline()
      Description: Indicates if the View Discipline can be modified
      Returns: True if View Discipline can be modified
    bool CanUseDepthCueing()
      Description: Indicates if view can use Depth Cueing
      Returns: True if view can use Depth Cueing
    bool CanUseTemporaryVisibilityModes()
      Description: Indicates if view can use temporary visibility modes
      Returns: True if view can use temporary visibility modes
    bool CanViewBeDuplicated(ViewDuplicateOption duplicateOption)
      Description: Identifies if this view can be duplicated.
      @duplicateOption: The option to use when duplicating the view.
      Returns: True if the view can be duplicated, false otherwise.
    void ConvertTemporaryHideIsolateToPermanent()
      Description: Convert all temporary hidden elements or categories to permanently hidden in view.
    void ConvertToIndependent()
      Description: Convert the dependent view to independent.
    View CreateViewTemplate()
      Description: Creates a new view template instance from this view instance.
      Returns: New view template instance
    void DisableTemporaryViewMode(TemporaryViewMode mode)
      Description: Disables the specified temporary view mode.
      @mode: The mode to disable.
    ElementId Duplicate(ViewDuplicateOption duplicateOption)
      Description: Duplicates this view.
      @duplicateOption: The option to use when duplicating the view.
      Returns: The id of the newly created view.
    void EnableRevealHiddenMode()
      Description: Enables Reveal Hidden elements mode.
    bool EnableTemporaryViewPropertiesMode(ElementId viewTemplateId)
      Description: Turns Temporary View Properties mode on or off. In this mode, any changes made to the view are temporary and will be discarded once the mode is disabled.
      @viewTemplateId: If the id of a view template is provided, Temporary View Properties mode is turned on and the settings from the template are applied to the view for the duration of the mode. If the id provided is not that of a template but the id of the view itself, Temporary View Properties mode is turned on without any changes to the view. If ElementId.InvalidElementId is provided, Temporary View Properties mode is turned off.
      Returns: Returns true when the view template provided by viewTemplateId was applied and Temporary View Properties was successfully turned on. Also returns true if ElementId.InvalidElementId was provided as input and Temporary View Properties was successfully turned off.
    ViewDisplayBackground GetBackground()
      Description: Returns the current background set for the view.
      Returns: Current background.
    ElementId GetCalloutParentId()
      Description: Gets ID of the callout parent view.
      Returns: ID of a view in which this callout was created or InvalidElementId if there is no parent.
    bool GetCategoryHidden(ElementId categoryId)
      Description: Checks if elements of the given category are set to be invisible (hidden) in this view.
      @categoryId: The ID of the category.
      Returns: True if the category is invisible (hidden), false otherwise.
    OverrideGraphicSettings GetCategoryOverrides(ElementId categoryId)
      Description: Gets graphic overrides for a category in view.
      @categoryId: Category to be checked.
      Returns: Object representing all graphic overrides of the category categoryId in view. A default OverrideGraphicSettings object will be returned if it not previously been set for this view.
    ElementId GetColorFillSchemeId(ElementId categoryId)
      Description: Returns id of the color fill scheme element applied to the view.
      @categoryId: The id of the category which the color fill scheme element belongs to.
      Returns: The id of the color fill scheme element.
    ViewCropRegionShapeManager GetCropRegionShapeManager()
      Description: Returns an object for managing view crop region shape.
      Returns: The crop region shape manager.
    static ViewCropRegionShapeManager GetCropRegionShapeManagerForReferenceCallout(Document doc, ElementId callout)
      Description: Returns an object for managing view crop region shape for reference callout.
      @doc: Document to which the callout belongs.
      @callout: Element id of reference callout.
      Returns: The crop region shape manager.
    ICollection<ElementId> GetDependentViewIds()
      Description: Get the ids of dependent views.
      Returns: Ids of the dependent views.
    ViewDisplayDepthCueing GetDepthCueing()
      Description: Returns the current depth cueing settings for the view.
      Returns: Current depth cueing settings.
    DirectContext3DHandleOverrides GetDirectContext3DHandleOverrides()
      Description: Returns DirectContext3D handle overrides object for the view.
      Returns: DirectContext3D handle overrides for the view
    OverrideGraphicSettings GetElementOverrides(ElementId elementId)
      Description: Gets graphic overrides for an element in the view.
      @elementId: The element.
      Returns: An object representing all graphic overrides of the element elementId in view.
    OverrideGraphicSettings GetFilterOverrides(ElementId filterElementId)
      Description: Gets graphic overrides that a filter applies to the view.
      @filterElementId: ElementId of the filter.
      Returns: Object representing all graphic overrides of the filter in the view.
    ICollection<ElementId> GetFilters()
      Description: Gets the filters applied to the view.
      Returns: The ElementIds of the Filters.
    bool GetFilterVisibility(ElementId filterElementId)
      Description: Gets the visibility of the elements associated with a filter.
      @filterElementId: The ElementId of the filter.
      Returns: True if the elements associated with the filter are visible in the view, false otherwise.
    bool GetIsFilterEnabled(ElementId filterElementId)
      Description: Identifies if the filter is enabled in this view.
      @filterElementId: The ElementId of the filter.
      Returns: True if the specified filter is enabled in this view, false otherwise.
    RevitLinkGraphicsSettings GetLinkOverrides(ElementId linkId)
      Description: Gets the graphic overrides of a or in view.
      @linkId: The id of the or .
      Returns: Settings representing graphic overrides for the input element id in the view, or if the input id references and it doesn't have overrides in the view.
    IList<TransformWithBoundary> GetModelToProjectionTransforms()
      Description: Gets the transforms from the model space to the view projection space.
      Returns: The transformations from the model space to view projection space.
    ICollection<ElementId> GetNonControlledTemplateParameterIds()
      Description: Returns a list of parameters that are not marked as included when this view is used as a template.
      Returns: The parameter ids that are not marked to be included.
    IList<ElementId> GetOrderedFilters()
      Description: Gets the filters applied to the view in the order they are applied.
      Returns: The ElementIds of the Filters.
    ViewPlacementOnSheetStatus GetPlacementOnSheetStatus()
      Description: Determines if this view placed on a sheet completely or partially.
      Returns: A value indicating whether and how the View is placed on a Sheet.
    PointCloudOverrides GetPointCloudOverrides()
      Description: Returns point cloud overrides object for the view.
      Returns: Point cloud overrides for the view
    ElementId GetPrimaryViewId()
      Description: Get the id of the primary view.
      Returns: The id of the primary view, or InvalidElementId if there is no primary view.
    ICollection<ElementId> GetReferenceCallouts()
      Description: Returns element ids of all reference callouts in the view.
      Returns: Element ids of all reference callouts in the view.
    ICollection<ElementId> GetReferenceElevations()
      Description: Returns element ids of all reference elevations in the view.
      Returns: Element ids of all reference elevations in the view.
    ICollection<ElementId> GetReferenceSections()
      Description: Returns element ids of all reference sections in the view.
      Returns: Element ids of all reference sections in the view.
    ViewDisplaySketchyLines GetSketchyLines()
      Description: Returns the current sketchy lines settings for the view.
      Returns: Current sketchy lines settings.
    IList<ElementId> GetTemplateParameterIds()
      Description: Returns a list of parameter ids that may be controlled when this view is assigned as a template.
      Returns: The parameter ids that may be controlled.
    ElementId GetTemporaryViewPropertiesId()
      Description: When Temporary View Properties mode is in progress it provides view id that overrode settings for current view. Outside Temporary View Properties mode InvalidElementId will be returned.
    string GetTemporaryViewPropertiesName()
      Description: When Temporary View Properties mode is in progress, name of applied template is returned. Outside Temporary View Properties mode, empty string will be returned.
    ViewDisplayModel GetViewDisplayModel()
      Description: Returns the current view display model settings for the view.
      Returns: Current view display model settings.
    WorksetVisibility GetWorksetVisibility(WorksetId worksetId)
      Description: Returns the visibility settings of a workset for this particular view.
      @worksetId: Id of the workset.
      Returns: The visibility of a workset for this particular view.
    WorksharingDisplayMode GetWorksharingDisplayMode()
      Description: Gets the current worksharing display mode for this view.
      Returns: The active worksharing display mode in this view.
    bool HasDetailLevel()
      Description: Check if the view has a Detail Level property
      Returns: True if the view has a Detail Level, false otherwise
    bool HasDisplayStyle()
      Description: Indicates if view has a DisplayStyle property
      Returns: True if view has a DisplayStyle property
    bool HasViewDiscipline()
      Description: Indicates if the view has a Discipline property
      Returns: True if the view has a Discipline property
    bool HasViewTransforms()
      Description: Returns true if the view reports model space to view projection space transforms.
      Returns: True if the view returns transforms, false otherwise.
    void HideActiveWorkPlane()
      Description: Hide the active work plane of the view.
    void HideCategoriesTemporary(ICollection<ElementId> elementIds)
      Description: Set multiple categories to be temporarily hidden in the view.
      @elementIds: Ids of the categories to be hidden
    void HideCategoryTemporary(ElementId elementId)
      Description: Set one category to be temporarily hidden in the view.
      @elementId: Id of the category to be hidden
    void HideElements(ICollection<ElementId> elementIdSet)
      Description: Sets the elements to be hidden in the view.
      @elementIdSet: A set of ElementIds to be hidden.
    void HideElementsTemporary(ICollection<ElementId> elementIdSet)
      Description: Set multiple elements to be temporarily hidden in the view. To hide a group completely, you must also include all members of all groups and nested groups in your input.
      @elementIdSet: Ids of the elements to be temporarily hidden.
    void HideElementTemporary(ElementId elementId)
      Description: Set one element to be temporarily hidden in the view. To hide a group completely, you must also include all members of all groups and nested groups in your input, therefore you should use the version of this method that accepts multiple element ids as input.
      @elementId: The id of the element to be temporarily hidden.
    bool IsCategoryOverridable(ElementId categoryId)
      Description: Checks whether the category can have graphic overrides in this view.
      @categoryId: ElementId of the category.
      Returns: True if category can be overridden, false otherwise.
    bool IsElementVisibleInTemporaryViewMode(TemporaryViewMode mode, ElementId id)
      Description: Identifies if the input element is visible for the temporary view mode for this view.
      @mode: The temporary view mode. Only TemporaryHideIsolate and AnalyticalModel modes are supported by this option. Other modes will result in an exception.
      @id: The element id.
      Returns: True if the element is visible, false if the element is hidden in the view mode.
    bool IsFilterApplied(ElementId filterElementId)
      Description: Indicates if a filter is applied to the view.
      @filterElementId: ElementId of the filter.
      Returns: True if the filter is applied to the view, false otherwise.
    bool IsInTemporaryViewMode(TemporaryViewMode mode)
      Description: Returns true if the view is in a particular temporary view mode.
      @mode: The mode.
      Returns: True if this view is in the temporary view mode indicated, false otherwise.
    void IsolateCategoriesTemporary(ICollection<ElementId> elementIds)
      Description: Set categories to be temporarily isolated in the view.
      @elementIds: Ids of categories to be isolated.
    void IsolateCategoryTemporary(ElementId elementId)
      Description: Set one category to be temporarily isolated in the view.
      @elementId: Id of category to be isolated.
    void IsolateElementsTemporary(ICollection<ElementId> elementIds)
      Description: Set multiple elements to be temporarily isolated in the view. To isolate a group completely, you must also include all members of all groups and nested groups in your input.
      @elementIds: Ids of elements to be isolated.
    void IsolateElementTemporary(ElementId elementId)
      Description: Set one element to be temporarily isolated in the view. To isolate a group completely, you must also include all members of all groups and nested groups in your input, therefore you should use the version of this method that accepts multiple element ids as input.
      @elementId: Id of element to be isolated.
    bool IsTemporaryHideIsolateActive()
      Description: Indicates if the view is temporarily hiding or isolating elements or categories.
      Returns: True if elements/categories are being temporarily hidden or isolated, false otherwise.
    bool IsTemporaryViewPropertiesModeEnabled()
      Description: Returns true when Temporary View Properties mode is in progress, false otherwise.
    static bool IsValidViewScale(int viewScale)
      Description: This validator checks that the view scale is in the allowable range.
      @viewScale: The denominator X in the view scale 1/X.
      Returns: True if the view scale is within the allowable range, false otherwise.
    bool IsValidViewTemplate(ElementId templateId)
      Description: Verifies that the view represented by templateId can be set as the controlling view template for this view.
      @templateId: The id to be validated as a view template for this view.
      Returns: True if the view is valid for us as a view template and compatible with this view, or if it is InvalidElementId, false otherwise.
    bool IsViewValidForTemplateCreation()
      Description: Verifies that the view is valid for template creation.
      Returns: True if the view can be used for view template creation, false otherwise.
    bool IsWorksetVisible(WorksetId worksetId)
      Description: Indicates whether the workset is visible in this view.
      @worksetId: Id of the workset.
      Returns: Whether the workset is visible.
    void Print(View viewTemplate)
      Description: Print this view with the given view template and using the print setting of the current active document.
      @viewTemplate: The view template which apply to the view.
    void Print()
      Description: Print this view with the default view template and using the print setting of the current active document.
    void Print(View viewTemplate, bool useCurrentPrintSettings)
      Description: Print this view with the given view template, and either the view's document's print setting or the print setting of the current active document.
      @viewTemplate: The view template which apply to the view.
      @useCurrentPrintSettings: If true, print the view with the print setting of the current active document; otherwise with the view's document's print setting.
    void Print(bool useCurrentPrintSettings)
      Description: Print this view with the default view template, and either the view's document's print setting or the print setting of the current active document.
      @useCurrentPrintSettings: If true, print the view with the print setting of the current active document; otherwise with the view's document's print setting.
    void RemoveCalloutParent()
      Description: Replaces callout parent ID with InvalidElementId.
    void RemoveFilter(ElementId filterElementId)
      Description: Removes a filter from the view.
      @filterElementId: ElementId of the filter.
    void RemoveLinkOverrides(ElementId linkId)
      Description: Deletes the graphical link overrides in the current view.
      @linkId: The id of the or .
    void RestoreCalloutParent()
      Description: Restores callout parent ID to the original view ID if that view is still available.
    void SetBackground(ViewDisplayBackground background)
      Description: Sets the background for the view. Background can only be set for 3d views and for Sections/Elevations.
      @background: Background to set. See 'ViewDisplayBackground' class and its 'create' methods.
    void SetCategoryHidden(ElementId categoryId, bool hide)
      Description: Sets if elements of the given category will be visible in this view.
      @categoryId: The ID of the category.
      @hide: True to make elements of this category invisible, false to make them visible.
    void SetCategoryOverrides(ElementId categoryId, OverrideGraphicSettings overrideGraphicSettings)
      Description: Sets graphic overrides for a category in view.
      @categoryId: Category to be overridden
      @overrideGraphicSettings: Object representing all graphic overrides of the category categoryId in view.
    void SetColorFillSchemeId(ElementId categoryId, ElementId schemeId)
      Description: Applies color fill scheme to this view.
      @categoryId: The id of category to apply a color fill scheme element.
      @schemeId: The id of the color fill scheme element.
    void SetDepthCueing(ViewDisplayDepthCueing depthCueing)
      Description: Sets the depth cueing settings for the view.
      @depthCueing: Depth cueing settings to set.
    void SetElementOverrides(ElementId elementId, OverrideGraphicSettings overrideGraphicSettings)
      Description: Sets graphic overrides for an element in the view.
      @elementId: Element to override.
      @overrideGraphicSettings: An object representing all graphic overrides of the element in view.
    void SetFilterOverrides(ElementId filterElementId, OverrideGraphicSettings overrideGraphicSettings)
      Description: Sets the overrides associated with a filter.
      @filterElementId: ElementId of the filter.
      @overrideGraphicSettings: The overrides to apply to the filter.
    void SetFilterVisibility(ElementId filterElementId, bool visibility)
      Description: Sets the visibility of the elements associated with a filter.
      @filterElementId: The ElementId of the filter.
      @visibility: True if the elements associated with the filter are visible in the view, false otherwise.
    void SetIsFilterEnabled(ElementId filterElementId, bool enable)
      Description: Sets the filter enabled flag.
      @filterElementId: The ElementId of the filter.
      @enable: True if the specified filter should be enabled in this view, false otherwise.
    void SetLinkOverrides(ElementId linkId, RevitLinkGraphicsSettings linkDisplaySettings)
      Description: Sets the graphic overrides of a or in the view.
      @linkId: The id of the or .
      @linkDisplaySettings: Settings representing all link graphic overrides in the view.
    void SetNonControlledTemplateParameterIds(ICollection<ElementId> newSet)
      Description: Sets the parameters that will not be included when this view is used as a template.
      @newSet: The parameter ids that should not be marked to be included.
    void SetSketchyLines(ViewDisplaySketchyLines sketchyLines)
      Description: Sets the sketchy lines settings for the view.
      @sketchyLines: Sketchy Lines settings to set.
    void SetViewDisplayModel(ViewDisplayModel viewDisplayModel)
      Description: Sets the view display model settings for the view.
      @viewDisplayModel: View display model settings to set.
    void SetWorksetVisibility(WorksetId worksetId, WorksetVisibility visible)
      Description: Sets visibility for a workset in this view.
      @worksetId: Id of the workset.
      @visible: The visibility of the workset.
    void SetWorksharingDisplayMode(WorksharingDisplayMode displayMode)
      Description: Sets the worksharing display mode for this view.
      @displayMode: The desired display mode. "Off" will turn off all worksharing display modes.
    void ShowActiveWorkPlane()
      Description: Show the active work plane of the view.
    ICollection<ElementId> SupportedColorFillCategoryIds()
      Description: Returns collection of all category ids that correspond to elements that can potentially be colored in this view according to a color fill scheme. The set may be different depending on the view type.
    bool SupportsRevealConstraints()
      Description: Checks that the view can have the Reveal Constraints mode activated.
      Returns: True if the view has a view type that allows Reveal Constraints mode to be activated.
    bool SupportsWorksharingDisplayMode(WorksharingDisplayMode mode)
      Description: Checks whether this view supports the given worksharing display mode.
      @mode: The mode of interest.
      Returns: Returns True if this view is a graphical view in a workshared document or if the desired mode is Off. Returns False if this view is a non-graphical view (such as a schedule or the project browser) or if this view is not in a workshared document.
    void UnhideElements(ICollection<ElementId> elementIdSet)
      Description: Sets the elements to be shown in the given view if they are currently hidden.
      @elementIdSet: A set of ElementIds to be unhidden.

--------------------------------------------------------------------------------


[CLASS] View3D
Full Name: Autodesk.Revit.DB.View3D

Description: Class for 3D views
Inherits: View
Implements: IDisposable

  PROPERTIES:
    bool IsLocked { get; }
      Description: Indicates if the view is locked.
    bool IsPerspective { get; }
      Description: Identifies whether this is a perspective view.
    bool IsSectionBoxActive { get; set; }
      Description: Identifies whether or not the section box is active in this 3D view.
    bool ProjectGridsOnSectionBox { get; set; }
      Description: This option projects all grids from the current 3d view on the bottom face of the section box. Only grids that are inside or intersects the section box

  METHODS:
    bool CanResetCameraTarget()
      Description: Checks whether the camera target can be reset for this view.
      Returns: True if camera target can be reset for this view, false otherwise.
    bool CanSaveOrientation()
      Description: Returns true if the View3D's orientation can be saved, false otherwise.
      Returns: True if the View3D's orientation can be saved, false otherwise.
    bool CanToggleBetweenPerspectiveAndIsometric()
      Description: Checks whether this view can toggle between perspective and isometric.
      Returns: True if this view can be toggled, false otherwise.
    static View3D CreateIsometric(Document document, ElementId viewFamilyTypeId)
      Description: Returns a new isometric View3D.
      @document: The document to which the new View3D will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new View3D. The type needs to be a ThreeDimensional ViewType.
      Returns: The new isometric View3D.
    static View3D CreatePerspective(Document document, ElementId viewFamilyTypeId)
      Description: Returns a new perspective View3D.
      @document: The document to which the new View3D will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new View3D. The type needs to be a ThreeDimensional ViewType.
      Returns: The new perspective View3D.
    ISet<ElementId> GetLevelsThatShowGrids()
      Description: Returns the list of levels ids where grids are displayed in this 3D view.
      Returns: The list of levels ids where grids are displayed in 3D views.
    ViewOrientation3D GetOrientation()
      Description: Gets the current non-saved orientation of the View3D.
      Returns: The current non-saved orientation of the View3D.
    RenderingSettings GetRenderingSettings()
      Description: Returns the current rendering settings for this 3d view.
      Returns: The returned object represents the current rendering settings. If you change the returned object, you need to call SetRenderingSettings to apply the new settings back to Revit.
    ViewOrientation3D GetSavedOrientation()
      Description: Gets the saved orientation of the View3D.
      Returns: The saved orientation of the View3D.
    BoundingBoxXYZ GetSectionBox()
      Description: Gets a copy of the section box for this 3D view.
      Returns: The section box. Note that the section box can be rotated and transformed and thus you will need to use to interpret the coordinates of the corners or sides of the box in model coordinates.
    bool HasBeenLocked()
      Description: Identifies if the view has ever been locked.
    void HideGridsOnLevel(ElementId levelId)
      Description: This method hides the grid lines in this 3D view on the given Level.
      @levelId: The id of the Level where grids will not be displayed.
    void OrientTo(XYZ forwardDirection)
      Description: Reorients the view to align with the forward direction.
      @forwardDirection: The forward direction.
    void ResetCameraTarget()
      Description: Resets the camera target to the center of the field of view.
    void RestoreOrientationAndLock()
      Description: Locks the view and restores its orientation.
    void SaveOrientation()
      Description: Converts the temporary orientation of the View3D into its saved orientation.
    void SaveOrientationAndLock()
      Description: Locks the view and saves its orientation
    void ScalePerspectiveCropBox(double multiplier)
      Description: Scale an existing crop box of the perspective view.
      @multiplier: Multiplier to change the view scale and the current crop box size on both X and Y.
    void SetOrientation(ViewOrientation3D newViewOrientation3D)
      Description: Sets the temporary orientation of the View3D. The new orientation is not saved in the document.
      @newViewOrientation3D: The new orientation to set.
    void SetRenderingSettings(RenderingSettings settings)
      Description: Changes the rendering settings for this 3d view.
      @settings: The new rendering settings to be applied to this view.
    void SetSectionBox(BoundingBoxXYZ boundingBoxXYZ)
      Description: Sets the section box for this 3D view.
      @boundingBoxXYZ: The bounding box to use for the section box. To turn off the section box, set to false. Individual bound enabled flags in the input box are ignored.
    void ShowGridsOnLevel(ElementId levelId)
      Description: This method displays the grid lines in this 3DView on the given Level.
      @levelId: The id of the Level where grids should be displayed.
    void ShowGridsOnLevels(ISet<ElementId> levelsIds)
      Description: This method displays the grid lines in this 3D view on the given Levels.
      @levelsIds: Levels ids where grids lines will be displayed.
    void ToggleToIsometric()
      Description: Toggles this view to isometric.
    void ToggleToPerspective()
      Description: Toggles this view to perspective.
    void Unlock()
      Description: Unlocks the view. Has no effect if the view is already unlocked.

--------------------------------------------------------------------------------


[CLASS] ViewCropRegionShapeManager
Full Name: Autodesk.Revit.DB.ViewCropRegionShapeManager

Description: A class that provides access to settings related to the crop assigned to a view or a reference callout.
Remarks: This class manages all the settings that make up the model and annotation crop geometry for a given view or reference callout. You can obtain the settings for a view from . Obtain the settings for a reference callout from . The model crop region crops model elements, detail elements (such as insulation and detail lines), section boxes, and scope boxes at the model crop boundary. Visible crop boundaries of other related views are also cropped at the model crop boundary. The model crop region can be set as a polygonal boundary, a rectangular boundary, or rectangular boundary with one or more splits applied either horizontally or vertically. If a split is applied to the rectangular crop each resulting rectangular region is identified by a region index and occupies a percentage of the original crop rectangle. The regions may possibly be moved relative to one another. The annotation crop region fully crops annotation elements when it touches any portion of the annotation element, so that no partial annotations are drawn. Annotations (such as symbols, tags, keynotes, and dimensions) that reference hidden or cropped model elements do not display in the view, even if they are inside the annotation crop region. The annotation crop region is always rectangular and at minimum occupies the same area as the rectangular model crop (or the corresponding rectangular boundary around the non-rectangular model crop), but can be offset to be bigger than the model crop in order to display more annotations.
Implements: IDisposable

  PROPERTIES:
    double BottomAnnotationCropOffset { get; set; }
      Description: The offset from the bottom of the view crop that determines the location of the annotation crop bottom boundary.
    bool CanBeSplit { get; }
      Description: Verifies that the crop of the associated view is permitted to have multiple regions.
    bool CanHaveAnnotationCrop { get; }
      Description: Verifies that the view is allowed to have an annotation crop.
    bool CanHaveShape { get; }
      Description: Verifies that the crop of the associated view is permitted to have a non-rectangular shape.
    bool IsSplitHorizontally { get; }
      Description: Whether or not the view's crop is split (and the split is horizontal).
    bool IsSplitVertically { get; }
      Description: Whether or not the view's crop is split (and the split is vertical).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LeftAnnotationCropOffset { get; set; }
      Description: The offset from the left of the view crop that determines the location of the annotation crop left boundary.
    int NumberOfSplitRegions { get; }
      Description: The number of split crop regions (1 if the crop is not currently split).
    double RightAnnotationCropOffset { get; set; }
      Description: The offset from the right of the view crop that determines the location of the annotation crop right boundary.
    bool ShapeSet { get; }
      Description: Whether or not the view crop has a non-rectangular shape set.
    bool Split { get; }
      Description: Whether or not the view crop is split.
    double TopAnnotationCropOffset { get; set; }
      Description: The offset from the top of the view crop that determines the location of the annotation crop top boundary.

  METHODS:
    void Dispose()
    CurveLoop GetAnnotationCropShape()
      Description: Gets the annotation crop box assigned to the view.
      Returns: The annotation crop boundary.
    IList<CurveLoop> GetCropShape()
      Description: Gets the crop boundaries that are curently active.
      Returns: The crop boundaries.
    double GetSplitRegionMaximum(int regionIndex)
      Description: Returns the proportional location of the maximum boundary of the specified split crop region.
      @regionIndex: Index of split crop region (numbering starts with 0).
      Returns: A value from 0 to 1 representing the maximum location for the region's split boundary. This number represents the location as a ratio along the non-split rectangular crop.
    double GetSplitRegionMinimum(int regionIndex)
      Description: Returns the proportional location of the minimum boundary of the specified split crop region.
      @regionIndex: Index of split crop region (numbering starts with 0).
      Returns: A value from 0 to 1 representing the minimum location for the region's split boundary. This number represents the location as a ratio along the non-split rectangular crop.
    XYZ GetSplitRegionOffset(int regionIndex)
      Description: Returns the offset for the specified split crop region.
      @regionIndex: Index of the split crop region (numbering starts with 0).
      Returns: A vector in model space representing the offset which is applied to the split crop region's boundary.
    bool IsCropRegionShapeValid(CurveLoop boundary)
      Description: Verifies that boundary represents one closed curve loop without self-intersections, consisting of non-zero length straight lines in a plane parallel to the view plane.
      @boundary: The crop boundary.
      Returns: True if the passed crop boundary represents one closed curve loop without self-intersections, consisting of non-zero length straight lines in a plane parallel to the view plane.
    void RemoveCropRegionShape()
      Description: Removes any non-rectangular boundary of the view's crop.
    void RemoveSplit()
      Description: Removes any split applied to the view's crop.
    void RemoveSplitRegion(int regionIndex)
      Description: Removes one region in split crop.
      @regionIndex: Index of region to be deleted (numbering starts with 0).
    void SetCropShape(CurveLoop boundary)
      Description: Sets the boundary of the view's crop to the specified shape.
      @boundary: The crop boundary.
    void SplitRegionHorizontally(int regionIndex, double leftPart, double rightPart)
      Description: Splits horizontally one region in split crop.
      @regionIndex: Index of region to be split horizontally (numbering starts with 0).
      @leftPart: Relative portion of the original region to become the new left region (0 to 1).
      @rightPart: Relative portion of the original region to become the new right region (0 to 1).
    void SplitRegionVertically(int regionIndex, double topPart, double bottomPart)
      Description: Splits vertically one region in split crop.
      @regionIndex: Index of region to be split vertically (numbering starts with 0).
      @topPart: Relative portion of the original region to become the new top region (0 to 1).
      @bottomPart: Relative portion of the original region to become the new bottom region (0 to 1).

--------------------------------------------------------------------------------


[ENUM] ViewDetailLevel
Full Name: Autodesk.Revit.DB.ViewDetailLevel

Description: Detail level of the view
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Coarse = 1
    - Medium = 2
    - Fine = 3


[ENUM] ViewDiscipline
Full Name: Autodesk.Revit.DB.ViewDiscipline

Description: Discipline of the view
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Architectural = 1
    - Structural = 2
    - Mechanical = 4
    - Electrical = 8
    - Plumbing = 16
    - Coordination = 4095


[CLASS] ViewDisplayBackground
Full Name: Autodesk.Revit.DB.ViewDisplayBackground

Description: Set of values that control how background is drawn in a view. Background can only be set for a 3d view or for a section or elevation view.
Implements: IDisposable

  PROPERTIES:
    Color BackgroundColor { get; }
      Description: The color of the horizon when the type is 'Gradient'.
    Color GroundColor { get; }
      Description: The color of the ground when the type is 'Gradient' or 'SunAndClouds'.
    double HorizontalImageOffset { get; }
      Description: The distance between the left viewport boundary and the left edge of the background image.
    double HorizontalImageScale { get; }
      Description: The horizontal scale of the background image; the scale of 1.0 puts the image pixel-to-pixel.
    ViewDisplayBackgroundImageFlags ImageFlags { get; }
      Description: The image alignment indicators when the type is 'Image'.
    string ImagePath { get; }
      Description: The path to the image file when the type is 'Image'.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color SkyColor { get; }
      Description: The color of the sky when the type is 'Gradient'.
    ViewDisplayBackgroundType Type { get; }
      Description: The type of the background.
    double VerticalImageOffset { get; }
      Description: The distance between the bottom viewport boundary and the bottom edge of the background image.
    double VerticalImageScale { get; }
      Description: The vertical scale of the background image; the scale of 1.0 puts the image pixel-to-pixel.

  METHODS:
    static ViewDisplayBackground CreateGradient(Color skyColor, Color horizonColor, Color groundColor)
      Description: Creates an object that can be passed to View.SetBackground method to set the background of the Gradient type.
      @skyColor: The top of the sky gradient if the sky is visible.
      @horizonColor: The bottom or the sky gradient if the sky is visible, or the top of the ground gradient otherwise.
      @groundColor: The ground color if the sky is visible (ground shown in uniform color), or the bottom of the ground gradient if the sky is not visible.
      Returns: New background object to pass to View.SetBackground.
    static ViewDisplayBackground CreateImage(string imagePath, ViewDisplayBackgroundImageFlags flags, UV imageOffsets, UV imageScales)
      Description: Creates an object that can be passed to View.SetBackground method to set the background of the Image type.
      @imagePath: File path with the image to be used.
      @flags: Combination of flags (binary) that control how image is displayed in relation to the view/crop boundary.
      @imageOffsets: Horizontal (u) and vertical (v) offsets of the image.
      @imageScales: Horizontal (u) and vertical (v) scales of the image (1 == no change).
      Returns: New background object to pass to View.SetBackground.
    static ViewDisplayBackground CreateSky()
      Description: Creates an object that can be passed to View.SetBackground method to set the background of the SunAndClouds type.
      Returns: New background object to pass to View.SetBackground.
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] ViewDisplayBackgroundImageFlags
Full Name: Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags

Description: A collection of bit flags that control how the background image is positioned in relation to the crop region (or the view boundary).
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - FitToScreen = 1
    - FixedAspectRatio = 2
    - UseTiling = 4


[ENUM] ViewDisplayBackgroundType
Full Name: Autodesk.Revit.DB.ViewDisplayBackgroundType

Description: A collection of settings defining the type of the view background
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 256
    - Gradient = 257
    - Image = 258
    - SunAndClouds = 512


[CLASS] ViewDisplayDepthCueing
Full Name: Autodesk.Revit.DB.ViewDisplayDepthCueing

Description: Represents the settings for depth cueing.
Implements: IDisposable

  PROPERTIES:
    bool EnableDepthCueing { get; set; }
      Description: True to enable depth cueing. False to disable it.
    int EndPercentage { get; }
      Description: The end percentage defines where depth cueing ends. Values between 0 and 100.
    int FadeTo { get; set; }
      Description: The fade to defines the maximum fading in per cent. Values between 0 and 100.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int StartPercentage { get; }
      Description: The start percentage defines where depth cueing starts. Values between 0 and 100.

  METHODS:
    void Dispose()
    void SetStartEndPercentages(int startPercentage, int endPercentage)
      Description: Sets start and end percentages.
      @startPercentage: The start percentage defines where depth cueing starts.
      @endPercentage: The end percentage defines where depth cueing ends.

--------------------------------------------------------------------------------


[ENUM] ViewDisplayEdges
Full Name: Autodesk.Revit.DB.ViewDisplayEdges

Description: A collection of settings defining how visible edges are displayed
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Simple = 1


[CLASS] ViewDisplayModel
Full Name: Autodesk.Revit.DB.ViewDisplayModel

Description: Represents the settings for displaying model graphics. version 2: m_showHiddenLines type changed bool -> ShowHiddenLinesValues::Enum
Implements: IDisposable

  PROPERTIES:
    bool EnableSilhouettes { get; set; }
      Description: True to show silhouettes edges. False to disable showing them.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ShowHiddenLinesValues ShowHiddenLines { get; set; }
      Description: True to enable hidden lines. False to disable showing them.
    ElementId SilhouetteEdgesGStyleId { get; set; }
      Description: Style ID for silhouette edges
    bool SmoothEdges { get; set; }
      Description: True to enable "smooth edge" (anti-aliasing) effect. False to disable it.
    int Transparency { get; set; }
      Description: The percentage (0..100) of surface transparency 0 means the surfaces are opaque, 100 means they are fully transparent

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ViewDisplaySketchyLines
Full Name: Autodesk.Revit.DB.ViewDisplaySketchyLines

Description: Represents the settings for sketchy lines.
Implements: IDisposable

  PROPERTIES:
    bool EnableSketchyLines { get; set; }
      Description: True to enable sketchy lines visibility. False to disable it.
    int Extension { get; set; }
      Description: The extension scale value. Controls the magnitude of line's extension. Values between 0 and 10.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Jitter { get; set; }
      Description: The jitter defines jitteriness of the line. Values between 0 and 10.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ViewDrafting
Full Name: Autodesk.Revit.DB.ViewDrafting

Description: ViewDrafting represents a drafting view within the model.
Inherits: View
Implements: IDisposable

  METHODS:
    static ViewDrafting Create(Document document, ElementId viewFamilyTypeId)
      Description: Creates a new ViewDrafting in the model.
      @document: The document in which the new drafting view will be created.
      @viewFamilyTypeId: The id of the ViewFamilyType that should be assigned to the new drafting view.
      Returns: The newly created drafting view.

--------------------------------------------------------------------------------


[ENUM] ViewDuplicateOption
Full Name: Autodesk.Revit.DB.ViewDuplicateOption

Description: Options for duplicating views
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Duplicate = 0
    - AsDependent = 1
    - WithDetailing = 2


[ENUM] ViewFamily
Full Name: Autodesk.Revit.DB.ViewFamily

Description: An enumerated type that corresponds to the type of a Revit view.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Invalid = 101
    - ThreeDimensional = 102
    - Walkthrough = 103
    - ImageView = 104
    - Schedule = 105
    - CostReport = 106
    - Sheet = 107
    - Drafting = 108
    - FloorPlan = 109
    - AreaPlan = 110
    - CeilingPlan = 111
    - Section = 112
    - Detail = 113
    - Elevation = 114
    - LoadsReport = 115
    - PressureLossReport = 116
    - Legend = 117
    - PanelSchedule = 118
    - GraphicalColumnSchedule = 119
    - StructuralPlan = 120
    - SystemsAnalysisReport = 121


[CLASS] ViewFamilyType
Full Name: Autodesk.Revit.DB.ViewFamilyType

Description: Represents a type of a Revit view.
Remarks: ViewFamilyTypes represent possible types for a Revit view and contain view type related properties and options such as the default template associated to views created from this type. They are commonly input to new View creation methods in the Revit API.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    ElementId DefaultTemplateId { get; set; }
      Description: The default template id assigned to this view type.
    PlanViewDirection PlanViewDirection { get; set; }
      Description: The PlanViewDirection of this view.
    ViewFamily ViewFamily { get; }
      Description: The ViewFamily for this view type.

  METHODS:
    bool IsValidDefaultTemplate(ElementId templateId)
      Description: Verifies that the input can be used as a default template for this view type.
      @templateId: Id to be validated as default template.
      Returns: True if %templateId% is valid as default template, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ViewNavigationToolSettings
Full Name: Autodesk.Revit.DB.ViewNavigationToolSettings

Description: Represents the settings contained in the document associated to the View Navigation tools (such as the View Cube).
Inherits: Element
Implements: IDisposable

  METHODS:
    HomeCamera GetHomeCamera()
      Description: Gets a copy of the structure containing information about the store Home view orientation.
      Returns: A copy of the structure containing information about the store Home view orientation, or if there is no home view set for this document.
    static ViewNavigationToolSettings GetViewNavigationToolSettings(Document pADoc)
      Description: Gets the instance of the settings for the given document.
      @pADoc: The document.
      Returns: The instance of the settings for the given document.
    bool IsHomeCameraSet()
      Description: Checks if the home view is set in the settings.
      Returns: Returns true if home view is set, otherwise false.

--------------------------------------------------------------------------------


[CLASS] ViewNode
Full Name: Autodesk.Revit.DB.ViewNode

Description: A render node that represents a view.
Remarks: See also: .
Inherits: RenderNode
Implements: IDisposable

  PROPERTIES:
    int LevelOfDetail { get; set; }
      Description: The level of detail the view is going to be rendered at.
    ElementId ViewId { get; }
      Description: The Id of the view element.

  METHODS:
    CameraInfo GetCameraInfo()
      Description: Information about the observation point (the camera) of the view.
      Returns: An instance of CameraInfo or if there is no info associated with the view

--------------------------------------------------------------------------------


[CLASS] ViewOrientation3D
Full Name: Autodesk.Revit.DB.ViewOrientation3D

Description: Container for the point and vectors which define View3D's orientation.
Implements: IDisposable

  CONSTRUCTORS:
    new ViewOrientation3D(XYZ eyePosition, XYZ upDirection, XYZ forwardDirection)

  PROPERTIES:
    XYZ EyePosition { get; }
      Description: The eye position point
    XYZ ForwardDirection { get; }
      Description: The forward direction vector
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ UpDirection { get; }
      Description: The up direction vector

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] ViewPlacementOnSheetStatus
Full Name: Autodesk.Revit.DB.ViewPlacementOnSheetStatus

Description: Indicates whether the View is placed on a Sheet.
Remarks: Some Views can be placed on one or more Sheets completely or partially. For example, a Schedule divided in segments, and only some of them are placed on Sheets.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NotApplicable = 0
    - NotPlaced = 1
    - PartiallyPlaced = 2
    - CompletelyPlaced = 3


[CLASS] ViewPlan
Full Name: Autodesk.Revit.DB.ViewPlan

Description: Represents floor plan, area plan, ceiling plan, and structural plan views in Revit.
Remarks: In a plan view, the model is viewed as if cut by the cut plane and viewed from above, looking down. In ceiling plan views and structural plan views which look up, the model is viewed as if cut by the cut plane, and viewed as if looking down at a mirror.
Inherits: View
Implements: IDisposable

  PROPERTIES:
    AreaScheme AreaScheme { get; }
      Description: The area scheme.

  METHODS:
    IList<PlanViewRangeError> CheckPlanViewRangeValidity(PlanViewRange planViewRange)
      Description: Checks if the plan view range is valid.
      @planViewRange: The view range to validate.
      Returns: List of enums describing any errors in the plan view range.
    static ViewPlan Create(Document document, ElementId viewFamilyTypeId, ElementId levelId)
      Description: Creates a new ViewPlan.
      @document: The document to which the ViewPlan will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new ViewPlan. The type needs to be a FloorPlan, CeilingPlan, AreaPlan, or StructuralPlan ViewType.
      @levelId: The id of the Level to associate with the new plan view.
      Returns: The new ViewPlan.
    static ViewPlan CreateAreaPlan(Document document, ElementId areaSchemeId, ElementId levelId)
      Description: Creates a new area plan ViewPlan.
      @document: The document to which the area plan will be added.
      @areaSchemeId: The id of the AreaScheme which will be used by the area plan.
      @levelId: The id of the Level to associate with the area plan.
      Returns: The new area plan ViewPlan.
    ElementId GetUnderlayBaseLevel()
      Description: Returns the element id of the level that defines the bottom of the underlay range.
      Returns: If InvalidElementId is returned, then the underlay base level is not set and no elements will be displayed as underlay.
    UnderlayOrientation GetUnderlayOrientation()
      Description: Returns the underlay orientation of this view.
      Returns: The underlay orientation for this view.
    ElementId GetUnderlayTopLevel()
      Description: Returns the element id of the level that defines the top of the underlay range.
      Returns: If the underlay base level is a valid level, and this method returns InvalidElementId, then the underlay range is unbounded, and consists of everything above the underlay base level.
    PlanViewRange GetViewRange()
      Description: Gets the view range.
      Returns: The view range.
    void SetUnderlayBaseLevel(ElementId levelId)
      Description: Sets the level whose elevation will determine the bottom of the underlay range. The elevation of the next highest level will be used to determine the top of the underlay range.
      @levelId: The element id of a level in the project or else InvalidElementId.
    void SetUnderlayOrientation(UnderlayOrientation uo)
      Description: Sets the underlay orientation for this view.
      @uo: The underlay orientation for this view.
    void SetUnderlayRange(ElementId baseLevelId, ElementId topLevelId)
      Description: Sets the underlay base and underlay top to the specified levels.
      @baseLevelId: The element id of a level in the project or InvalidElementId. If InvalidElementId, then the underlay base level is not set and no elements will be displayed as underlay.
      @topLevelId: The element id of a level in the project or InvalidElementId. If InvalidElementId, then the underlay range is unbounded.
    void SetViewRange(PlanViewRange planViewRange)
      Description: Sets the view range.
      @planViewRange: The view range.

--------------------------------------------------------------------------------


[ENUM] ViewPlanType
Full Name: Autodesk.Revit.DB.ViewPlanType

Description: An enumerated type listing plan view types.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FloorPlan = 1
    - CeilingPlan = 2


[CLASS] Viewport
Full Name: Autodesk.Revit.DB.Viewport

Description: An element that establishes the placement of a view on a sheet.
Remarks: Viewports are used in Revit for purposes other than placement of views on sheets. Thus iteration of viewport elements in the model may locate viewports which are not assigned to sheets; you can use the SheetId property to filter these out.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double LabelLineLength { get; set; }
      Description: The length of the viewport label line in sheet space, measured in feet.
    XYZ LabelOffset { get; set; }
      Description: The offset is a two-dimensional vector from left bottom corner of the viewport with Rotation set to None to the left end of the viewport label line. The Z coordinate is ignored.
    ViewportRotation Rotation { get; set; }
      Description: The rotation of the viewport on the sheet.
    ElementId SheetId { get; }
      Description: The element id of the ViewSheet on which the viewport appears, or InvalidElementId if this viewport does not associate a view with placement onto a sheet.
    ElementId ViewId { get; set; }
      Description: The element id of the associated View.
    ViewportPositioning ViewportPositioning { get; set; }
      Description: Specifies the method the viewport will be positioned on the sheet when swapped to another view. Default is set to ViewportPositioning::ViewportCenter.

  METHODS:
    static bool CanAddViewToSheet(Document document, ElementId viewSheetId, ElementId viewId)
      Description: Verifies that the view can be added to the ViewSheet.
      @document: The document in which the views reside.
      @viewSheetId: The ViewSheet on which the view will be placed.
      @viewId: The view which will be checked to see if it can be placed on the sheet.
      Returns: True if the view can be added to the ViewSheet, false otherwise.
    static Viewport Create(Document document, ElementId viewSheetId, ElementId viewId, XYZ point)
      Description: Creates a new Viewport at a given location on a sheet.
      @document: The document to which the new Viewport will be added.
      @viewSheetId: The ViewSheet on which the new Viewport will be placed.
      @viewId: The view shown in the Viewport.
      @point: The new Viewport will be centered on this point.
      Returns: The new Viewport.
    XYZ GetBoxCenter()
      Description: Returns the center of the outline of the viewport on the sheet, excluding the viewport label.
      Returns: The center of the outline of the viewport on the sheet.
    Outline GetBoxOutline()
      Description: Returns the outline of the viewport on the sheet, excluding the viewport label.
      Returns: The outline of the viewport on the sheet.
    Outline GetLabelOutline()
      Description: Gets the outline viewport's label on the sheet.
      Returns: The outline of the viewport's label on the sheet. The outline may be empty if there is no label.
    Transform GetProjectionToSheetTransform()
      Description: Returns the transform from the view's projection space to the sheet space.
      Returns: The transform from the view's projection space to the sheet space.
    bool HasViewportTransforms()
      Description: Indicates if the viewport has transforms.
      Returns: True if the viewport has transforms, false otherwise.
    bool IsViewIdValidForViewport(ElementId viewId)
      Description: Verifies that the Viewport can change it's view id to the input %viewId%.
      @viewId: The view which will be checked to see if it can be applied to Viewport.
      Returns: True if the %viewId% is valid for the viewport, false otherwise.
    void SetBoxCenter(XYZ newCenterPoint)
      Description: Moves this viewport so that the center of the box outline (excluding the viewport label) is at a given point.
      @newCenterPoint: The desired center for the box outline.

--------------------------------------------------------------------------------


[ENUM] ViewportPositioning
Full Name: Autodesk.Revit.DB.ViewportPositioning

Description: An enumerated type listing of viewport positioning options on the sheet when swapped to another view.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ViewportCenter = 0
    - ViewOrigin = 1


[ENUM] ViewportRotation
Full Name: Autodesk.Revit.DB.ViewportRotation

Description: Rotation of the viewport
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Clockwise = 1
    - Counterclockwise = 2


[CLASS] ViewSchedule
Full Name: Autodesk.Revit.DB.ViewSchedule

Description: A schedule view.
Remarks: The ViewSchedule class represents schedules and other schedule-like views, including single-category and multi-category schedules, key schedules, material takeoffs, view lists, sheet lists, keynote legends, revision schedules, and note blocks. The ViewSchedule class is not used for panel schedules (see PanelScheduleView) or graphical column schedules.A schedule is a tabular representation of data. A typical schedule shows all elements of a category (doors, rooms, etc.) with each row representing an element and each column representing a parameter. This basic structure can be modified using filters, sorting, grouping, totals, formulas, and other features.The ScheduleDefinition class contains most settings that determine the contents of a schedule, including category, fields, filters, and sorting.A graphical representation of a schedule can be placed on a sheet using the ScheduleSheetInstance class.
Inherits: TableView
Implements: IDisposable

  PROPERTIES:
    ElementId BodyTextTypeId { get; set; }
      Description: Defines the default text style used for the data section of the schedule.
    ScheduleDefinition Definition { get; }
      Description: The primary ScheduleDefinition.
    ScheduleDefinition EmbeddedDefinition { get; }
      Description: The embedded ScheduleDefinition.
    bool HasStripedRows { get; set; }
      Description: Indicates whether this schedule has striped rows.
    ElementId HeaderTextTypeId { get; set; }
      Description: Defines the default text style used in the column headers in the body section of the schedule.
    static bool IsHeaderFrozen { get; set; }
      Description: A static property defining if the schedule header frozen setting is turned on or off in current Revit Application Session.
    bool IsInternalKeynoteSchedule { get; }
      Description: Identifies if this ViewSchedule is an internal schedule used when keynotes are filtered based on the elements that are shown on a sheet.
    bool IsTitleblockRevisionSchedule { get; }
      Description: Identifies if this ViewSchedule is an internal schedule used to display revision schedules as part of a titleblock.
    string KeyScheduleParameterName { get; set; }
      Description: In a key schedule, the name of the parameter for choosing one of the keys.
    double RowHeight { get; set; }
      Description: Defines the schedule body rows height.
    RowHeightOverrideOptions RowHeightOverride { get; set; }
      Description: Defines the override that is applied to the row height.
    ElementId TitleTextTypeId { get; set; }
      Description: Defines the default text style used in the header section of the schedule.
    bool UseStripedRowsOnSheets { get; set; }
      Description: Indicates whether a property setting of true will also change the display of this schedule to show striped rows on a sheet. If true, setting that property to true will also change the display. If false, striped rows will not display for this schedule on a sheet no matter what value is set for HasStripedRows.

  METHODS:
    bool CanGroupHeaders(int top, int left, int bottom, int right)
      Description: Indicates if selected headers can be grouped for this schedule.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      Returns: True if the selected headers can be grouped, false otherwise.
    bool CanUngroupHeaders(int top, int left, int bottom, int right)
      Description: Indicates if selected headers can be ungrouped.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      Returns: True if the selected headers can be grouped, false otherwise.
    static ViewSchedule CreateKeynoteLegend(Document document)
      Description: Creates a keynote legend.
      @document: The document to which the new schedule will be added.
      Returns: The newly created schedule.
    static ViewSchedule CreateKeySchedule(Document document, ElementId categoryId)
      Description: Create a key schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category of elements that the schedule's keys will be associated with.
      Returns: The newly created schedule.
    static ViewSchedule CreateMaterialTakeoff(Document document, ElementId categoryId)
      Description: Creates a material takeoff.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The newly created schedule.
    static ViewSchedule CreateNoteBlock(Document document, ElementId familyId)
      Description: Creates a note block.
      @document: The document to which the new schedule will be added.
      @familyId: The ID of the family whose elements will be included in the schedule.
      Returns: The newly created schedule.
    static ViewSchedule CreateRevisionSchedule(Document document)
      Description: Creates a revision schedule.
      @document: The titleblock family document to which the new schedule will be added.
      Returns: The newly created schedule.
    static ViewSchedule CreateSchedule(Document document, ElementId categoryId, ElementId areaSchemeId)
      Description: Creates a regular schedule that can relate to a specific area scheme.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      @areaSchemeId: The ID of an area scheme in an area schedule, InvalidElementId otherwise.
      Returns: The newly created schedule.
    static ViewSchedule CreateSchedule(Document document, ElementId categoryId)
      Description: Creates a regular schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The newly created schedule.
    static ViewSchedule CreateSheetList(Document document)
      Description: Creates a sheet list.
      @document: The document to which the new schedule will be added.
      Returns: The newly created schedule.
    static ViewSchedule CreateViewList(Document document)
      Description: Creates a view list.
      @document: The document to which the new schedule will be added.
      Returns: The newly created schedule.
    void DeleteSegment(int segmentIndex)
      Description: Deletes a schedule segment.
      @segmentIndex: Zero-based index of the segment.
    void Export(string folder, string name, ViewScheduleExportOptions options)
      Description: Exports the schedule data to a text file.
      @folder: Path to the location where the file will be saved.
      @name: Name of file.
      @options: Options that relate to schedule export.
    static string GetDefaultNameForKeynoteLegend(Document document)
      Description: Gets the default view name that will be used when creating a keynote legend.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
    static string GetDefaultNameForKeySchedule(Document document, ElementId categoryId)
      Description: Gets the default view name that will be used when creating a key schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category of elements that the schedule's keys will be associated with.
      Returns: The default view name.
    static string GetDefaultNameForMaterialTakeoff(Document document, ElementId categoryId)
      Description: Gets the default view name that will be used when creating a material takeoff.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The default view name.
    static string GetDefaultNameForNoteBlock(Document document)
      Description: Gets the default view name that will be used when creating a note block.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
    static string GetDefaultNameForRevisionSchedule(Document document)
      Description: Gets the default view name that will be used when creating a revision schedule.
      @document: The titleblock family document to which the new schedule will be added.
      Returns: The default view name.
    static string GetDefaultNameForSchedule(Document document, ElementId categoryId, ElementId areaSchemeId)
      Description: Gets the default view name that will be used when creating a schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      @areaSchemeId: The ID of an area scheme in an area schedule, InvalidElementId otherwise.
      Returns: The default view name.
    static string GetDefaultNameForSchedule(Document document, ElementId categoryId)
      Description: Gets the default view name that will be used when creating a regular schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The default view name.
    static string GetDefaultNameForSheetList(Document document)
      Description: Gets the default view name that will be used when creating a sheet list.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
    static string GetDefaultNameForViewList(Document document)
      Description: Gets the default view name that will be used when creating a view list.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
    static string GetDefaultParameterNameForKeySchedule(Document document, ElementId categoryId)
      Description: Gets the default parameter name that will be used when creating a key schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category of elements that the schedule's keys will be associated with.
      Returns: The default parameter name.
    ScheduleHeightsOnSheet GetScheduleHeightsOnSheet()
      Description: Gets the heights of schedule title, column header and each schedule body row.
      Returns: The ScheduleHeightsOnSheet which contains heights information of a schedule on sheet.
    IList<ElementId> GetScheduleInstances(int segmentIndex)
      Description: Gets the instances ids of schedule or schedule segment.
      @segmentIndex: Index of the segment.
      Returns: The array of schedule sheet instance element ids of schedule or schedule segment.
    int GetSegmentCount()
      Description: Gets the total count of schedule segments.
      Returns: The total count of schedule segments. 1 means the schedule is not split yet.
    double GetSegmentHeight(int segmentIndex)
      Description: Gets the segment height.
      @segmentIndex: Zero-based index of the segment.
      Returns: The segment height value.
    Color GetStripedRowsColor(StripedRowPattern index)
      Description: Gets the color applied to part of the pattern for a schedule with striped rows.
      @index: The part of the striped row pattern.
      Returns: The applied color of the pattern part.
    TableData GetTableData()
      Description: Gets the writable table data object.
      Returns: The schedule data object.
    static ICollection<ElementId> GetValidCategoriesForKeySchedule()
      Description: Gets a list of categories that can be used for a key schedule.
      Returns: The IDs of all valid categories.
    static ICollection<ElementId> GetValidCategoriesForMaterialTakeoff()
      Description: Gets a list of categories that can be used for a material takeoff.
      Returns: The IDs of all valid categories.
    static ICollection<ElementId> GetValidCategoriesForSchedule()
      Description: Gets a list of categories that can be used for a regular schedule.
      Returns: The IDs of all valid categories.
    static ICollection<ElementId> GetValidFamiliesForNoteBlock(Document document)
      Description: Gets a list of families that can be used for a note block.
      @document: The document.
      Returns: The IDs of all valid families.
    void GroupHeaders(int top, int left, int bottom, int right, string caption)
      Description: Groups schedule header cells.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      @caption: The header caption.
    bool HasImageField()
      Description: Checks whether the schedule definition includes any image-related fields and if any elements in the schedule actually have images in those fields.
      Returns: True if the schedule has at least one image field showing at least one image, false otherwise
    bool IsDataOutOfDate()
      Description: Indicates whether the schedule data is out of date.
      Returns: True if the schedule data is out of date, false otherwise.
    bool IsSplit()
      Description: Checks if the schedule is split.
      Returns: True if the schedule is split. Otherwise false.
    static bool IsValidCategoryForKeySchedule(ElementId categoryId)
      Description: Checks whether a category can be used for a key schedule.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for a key schedule, false otherwise.
    static bool IsValidCategoryForMaterialTakeoff(ElementId categoryId)
      Description: Checks whether a category can be used for a material takeoff.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for a material takeoff, false otherwise.
    static bool IsValidCategoryForSchedule(ElementId categoryId)
      Description: Checks whether a category can be used for a regular schedule.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for a regular schedule, false otherwise.
    static bool IsValidFamilyForNoteBlock(Document document, ElementId familyId)
      Description: Checks whether a family can be used for a note block.
      @document: The document.
      @familyId: The family ID to check.
      Returns: True if the family can be used for a note block, false otherwise.
    bool IsValidTextTypeId(ElementId textTypeId)
      Description: Identifies if the input id represents a valid text type id for use in the schedule properties.
      @textTypeId: The element id of the text type.
    void MergeSegments(int movedSegmentIndex, int targetSegmentIndex)
      Description: Merges two adjacent segments into one.
      @movedSegmentIndex: The index of the moved segment.
      @targetSegmentIndex: The index of the target segment.
    bool RefreshData()
      Description: Rebuilds the schedule data if it is out of date.
      Returns: True if the data is up to date after the refresh.
    void RestoreImageSize()
      Description: Restores all images to their original sizes.
    void SetSegmentHeight(int segmentIndex, double height)
      Description: Sets the segment height.
      @segmentIndex: Index of the segment.
      @height: New height for the segment.
    void SetStripedRowsColor(StripedRowPattern index, Color color)
      Description: Sets the color applied to part of the pattern for a schedule with striped rows.
      @index: The part of the striped row pattern.
      @color: The color which will be used in striped row pattern.
    void Split(IList<double> segmentHeights)
      Description: Splits the schedule into several segments by given height of each segment.
      @segmentHeights: An array contains the height limit of each segment except the last segment. The height is the value for segment body. The height is Revit's internal units value.
    void Split(int segmentNumber)
      Description: Splits the schedule into several segments by given segment number.
      @segmentNumber: The segment number.
    void SplitSegment(int segmentIndex, IList<double> segmentHeights)
      Description: Splits the schedule segment by the given heights of new segments.
      @segmentIndex: The index of segment, starting with 0.
      @segmentHeights: An array contains the height for each new segment except the last segment. The height of the last segment will be determined by the height of previous new segments and the height of the split segment.
    void UngroupHeaders(int top, int left, int bottom, int right)
      Description: Ungroups selected headers of schedule.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.

--------------------------------------------------------------------------------


[CLASS] ViewScheduleExportOptions
Full Name: Autodesk.Revit.DB.ViewScheduleExportOptions

Description: The export options used to export schedule views.
Implements: IDisposable

  CONSTRUCTORS:
    new ViewScheduleExportOptions()
    new ViewScheduleExportOptions(ViewScheduleExportOptions other)

  PROPERTIES:
    ExportColumnHeaders ColumnHeaders { get; set; }
      Description: How to export column headers. Default is MultipleRows.
    string FieldDelimiter { get; set; }
      Description: How to delimit fields. Default is Tab.
    bool HeadersFootersBlanks { get; set; }
      Description: Whether to export group headers, footers, and blank lines. Default is true.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportTextQualifier TextQualifier { get; set; }
      Description: How to qualify text fields. Default is DoubleQuote.
    bool Title { get; set; }
      Description: Whether or not to export the schedule title. Default is true.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] ViewSection
Full Name: Autodesk.Revit.DB.ViewSection

Description: ViewSection covers sections, details, elevations, and callouts, all in their reference and non-reference variations.
Remarks: The creation functions for elevations can be found in the ElevationMarker class.
Inherits: View
Implements: IDisposable

  METHODS:
    static View CreateCallout(Document document, ElementId parentViewId, ElementId viewFamilyTypeId, XYZ point1, XYZ point2)
      Description: Creates a new callout view.
      @document: The document to which the new callout will be added.
      @parentViewId: The view in which the callout appears. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail views.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new callout ViewSection. Detail ViewFamilyTypes can be used in all parent views except for CeilingPlan and Drafting views. FloorPlan, CeilingPlan, StructuralPlan, Section, and Elevation ViewFamilyTypes may be be used in parent views that also use a type with the same ViewFamily enum value. For example, in StructuralPlan parent views both StructuralPlan and Detail ViewFamilyTypes are allowed.
      @point1: Determines the extents of the callout symbol in the parent view.
      @point2: Determine the extents of the callout symbol in the parent view.
      Returns: The new callout view. The view will be either a ViewSection, ViewPlan or ViewDetail.
    static ViewSection CreateDetail(Document document, ElementId viewFamilyTypeId, BoundingBoxXYZ sectionBox)
      Description: Returns a new detail ViewSection.
      @document: The document to which the new detail ViewSection will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new detail ViewSection. The type needs to be a Detail ViewFamily.
      @sectionBox: The BoundingBoxXYZ which specifies the new ViewSection's view direction and extents.
      Returns: The new detail ViewSection.
    static void CreateReferenceCallout(Document document, ElementId parentViewId, ElementId viewIdToReference, XYZ point1, XYZ point2)
      Description: Creates a new reference callout.
      @document: The document to which the new reference callout will be added.
      @parentViewId: The view in which the callout symbol appears. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, Drafting, and Detail views.
      @viewIdToReference: The view which will be referenced. The ViewFamilyType of the referenced view will be used by the new reference callout. Only cropped views can be referenced, unless the referenced view is a Drafting view. Drafting views can always be referenced regardless of the parent view type. Elevation views can be referenced from Elevation and Drafting parent views. Section views can be referenced from Section and Drafting parent views. Detail views can be referenced from all parent views except for in FloorPlan, CeilingPlan and StructuralPlan parent views where only horizontally-oriented Detail views can be referenced. FloorPlan, CeilingPlan and StructuralPlan views can be referenced from FloorPlan, CeilingPlan and StructuralPlan parent views.
      @point1: One corner of the callout symbol in the parent view.
      @point2: The other diagonally opposed corner of the callout symbol in the parent view.
    static void CreateReferenceSection(Document document, ElementId parentViewId, ElementId viewIdToReference, XYZ headPoint, XYZ tailPoint)
      Description: Creates a new reference section.
      @document: The document to which the reference section will be added.
      @parentViewId: The view in which the new reference section marker will appear. Reference sections can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, Drafting, and Detail views.
      @viewIdToReference: Detail, Drafting and Section views can be referenced. The ViewFamilyType of the referenced view will be used by the new reference section.
      @headPoint: Determines the location of the section marker's head in the parent view.
      @tailPoint: Determines the location of the section marker's tail in the parent view.
    static ViewSection CreateSection(Document document, ElementId viewFamilyTypeId, BoundingBoxXYZ sectionBox)
      Description: Returns a new section ViewSection.
      @document: The document to which the new section ViewSection will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new section ViewSection. The type needs to be a Section ViewFamily.
      @sectionBox: The BoundingBoxXYZ which specifies the new ViewSection's view direction and extents.
      Returns: The new section ViewSection.
    static bool IsParentViewValidForCallout(Document document, ElementId parentViewId)
      Description: This validator checks that the parent view is appropriate for callout views.
      @document: The document which contains the ViewFamilyType and parent view.
      @parentViewId: The view in which the new callout will appear. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail views.
      Returns: True if the ViewFamilyType can be used for callout views in the parent view, false otherwise.
    bool IsSplitSection()
      Description: Sections can be split (jog) so that they cut at >1 plane.
      Returns: True if the section is split.
    static bool IsViewFamilyTypeValidForCallout(Document document, ElementId viewFamilyTypeId, ElementId parentViewId)
      Description: This validator checks that the ViewFamilyType is appropriate for callout views in the input parent view.
      @document: The document which contains the ViewFamilyType and parent view.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new callout ViewSection. Detail ViewFamilyTypes can be used in all parent views except for CeilingPlan and Drafting views. FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail ViewFamilyTypes may be be used in parent views that also use a type with the same ViewFamily enum value. For example, in StructuralPlan views both StructuralPlan and Detail ViewFamilyTypes are allowed.
      @parentViewId: The view in which the new callout will appear. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail views.
      Returns: True if the ViewFamilyType can be used for callout views in the parent view, false otherwise.

--------------------------------------------------------------------------------


[CLASS] ViewSet
Full Name: Autodesk.Revit.DB.ViewSet

Description: A set that contains views.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new ViewSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of views that are in the set.

  METHODS:
    void Clear()
      Description: Removes every view from the set, rendering it empty.
    bool Contains(View item)
      Description: Tests for the existence of a view within the set.
      @item: The view to be searched for.
      Returns: The Contains method returns True if the view is within the set, otherwise False.
    int Erase(View item)
      Description: Removes a specified view from the set.
      @item: The view to be erased.
      Returns: The number of views that were erased from the set.
    ViewSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(View item)
      Description: Insert the specified view into the set.
      @item: The view to be inserted into the set.
      Returns: Returns whether the view was inserted into the set.
    ViewSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] ViewSetIterator
Full Name: Autodesk.Revit.DB.ViewSetIterator

Description: An iterator to a view set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new ViewSetIterator()

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the item that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the set.
    void Reset()
      Description: Bring the iterator back to the start of the set.

--------------------------------------------------------------------------------


[CLASS] ViewShapeBuilder
Full Name: Autodesk.Revit.DB.ViewShapeBuilder

Description: Builds and verifies a view-specific shape representation that would typically be stored in a DirectShape object. Currently limited to curve-based representations for plan and elevation views.
Remarks: The validation functionality is used by DirectShape to validate the incoming shape.
Inherits: ShapeBuilder
Implements: IDisposable

  CONSTRUCTORS:
    new ViewShapeBuilder(DirectShapeTargetViewType targetViewType)
    new ViewShapeBuilder()

  PROPERTIES:
    XYZ ViewNormal { get; set; }
      Description: Normal of the view that will display the shape being built. Must be set explicitly before adding any geometry. Must be a unit vector. This is used to validate incoming geometry - it must be orthogonal to the viewNormal.
    DirectShapeTargetViewType ViewType { get; set; }
      Description: View type where the view-specific shape currently being built will be used

  METHODS:
    void AddCurve(Curve GCurve)
      Description: Add a curve to the GRep associated to this ViewShapeBuilder.
      @GCurve: The curve to be added.
    void Reset()
      Description: Clears the accumulated geometry and resets other ViewShapeBuilder parameters to invalid values.
    static bool ValidateCurve(Curve GCurve, DirectShapeTargetViewType targetViewType)
      Description: Validates curve to be added to the view-specific shape being constructed. Called by AddCurve() to validate input. This function may be used to pre-validate the geometry being added to avoid AddCurve() throwing an InvalidArgumentException
      @GCurve: Curve object to be validated.
      @targetViewType: View type for which this curve is intended.
      Returns: True is %GCurve% is acceptable as a part of view-specific shape representation.
    bool ValidateCurve(Curve GCurve)
      Description: Validates curve to be added to the view-specific shape being constructed. Called by AddCurve() to validate input. Expects a valid view normal to be set prior to the call.
      @GCurve: Curve object to be validated.
      Returns: True is %GCurve% is acceptable as a part of view-specific shape representation being built.
    static bool ValidateShape(IList<GeometryObject> shape, DirectShapeTargetViewType targetViewType)
      Description: Validates a shape represented as a collection of geometry objects for use as a view-specific shape. The objects are expected to be either points, curves or polylines. Curves are expected to be flat and lie in a plane perpendicular to view normal as defined by view type.
      Returns: Returns true if %shape% may be used as a view-specific shape representation, false otherwise.
    static bool ValidateViewType(DirectShapeTargetViewType targetViewType)
      Description: Validates the incoming view type. As of today, the only allowed view type is Plan.
      Returns: True if %targetViewType% is DirectShapeTargetViewType::Plan

--------------------------------------------------------------------------------


[CLASS] ViewSheet
Full Name: Autodesk.Revit.DB.ViewSheet

Description: Class for ViewSheet
Inherits: View
Implements: IDisposable

  PROPERTIES:
    bool IsPlaceholder { get; }
      Description: Identifies whether or not the view sheet represents a placeholder sheet.
    ElementId SheetCollectionId { get; set; }
      Description: The ID of the sheet collection this sheet is associated with.
    string SheetNumber { get; set; }
      Description: The sheet number of the document.

  METHODS:
    bool CanBeDuplicated(SheetDuplicateOption duplicateOption)
      Description: Identifies if this sheet can be duplicated.
      @duplicateOption: The option to use when duplicating the sheet.
      Returns: True if the sheet can be duplicated, false otherwise.
    void ConvertToRealSheet(ElementId titleBlockTypeId)
      Description: Converts a placeholder sheet to a real one with an optional titleblock.
      @titleBlockTypeId: The id of the placeholder sheet, or invalidElementId if no titleblock should be added.
    static ViewSheet Create(Document document, ElementId titleBlockTypeId)
      Description: Creates a new ViewSheet.
      @document: The document to which the ViewSheet will be added.
      @titleBlockTypeId: The type id of the TitleBlock type which will be used by the new ViewSheet. For no TitleBlock, pass invalid element ID.
      Returns: The new ViewSheet.
    static ViewSheet CreatePlaceholder(Document aDoc)
      Description: Creates a placeholder sheet in a document.
      @aDoc: The document.
      Returns: The placeholder sheet.
    void DeleteViewport(Viewport viewport)
      Description: Removes a viewport from the sheet by deleting it from the document.
      @viewport: The viewport that will be deleted and removed from the sheet.
    ElementId Duplicate(SheetDuplicateOption duplicateOption)
      Description: Duplicates this sheet to generate a new one.
      @duplicateOption: The option to use when duplicating the sheet.
      Returns: The id of the newly created sheet.
    ICollection<ElementId> GetAdditionalRevisionIds()
      Description: Gets the Revisions that are additionally included in the sheet's revision schedules.
      Returns: The additionally included Revisions for the sheet's revision schedules.
    ISet<ElementId> GetAllPlacedViews()
      Description: Returns the ElementIds of Views placed on this sheet.
      Returns: The ids of the views on this sheet.
    ISet<ElementId> GetAllRevisionCloudIds()
      Description: Gets the ids of the revision clouds which appear on the sheet's revision schedules.
      Returns: The ids of the revisions clouds which appear on the sheet's revision schedules.
    IList<ElementId> GetAllRevisionIds()
      Description: Gets the ordered array of Revisions which participate in the sheet's revision schedules.
      Returns: The ordered array of ids of Revisions participating in the sheet's revision schedules.
    ICollection<ElementId> GetAllViewports()
      Description: Returns the ElementIds of Viewports on this sheet.
      Returns: The Viewports on this sheet.
    ElementId GetCurrentRevision()
      Description: Returns the most recent numbered Revision shown on this ViewSheet.
      Returns: The Id of the most recent numbered Revision shown on this ViewSheet or InvalidElementId if none are shown.
    string GetRevisionCloudNumberOnSheet(ElementId revisionCloudId)
      Description: Gets the Revision Number for a RevisionCloud on this sheet.
      @revisionCloudId: The id of the RevisionCLoud.
      Returns: Returns the Revision Number as it will appear on this sheet or if there is no Revision Number assigned on this sheet.
    string GetRevisionNumberOnSheet(ElementId revisionId)
      Description: Gets the Revision Number for a particular Revision as it will appear on this sheet.
      @revisionId: The id of the Revision.
      Returns: Returns the Revision Number as it will appear on this sheet or if the Revision does not appear on this sheet.
    void SetAdditionalRevisionIds(ICollection<ElementId> projectRevisionIds)
      Description: Sets the Revisions to additionally include in the sheet's revision schedules.
      @projectRevisionIds: The ids of Revisions to explicitly include in the sheet's revision schedules.

--------------------------------------------------------------------------------


[CLASS] ViewSheetSet
Full Name: Autodesk.Revit.DB.ViewSheetSet

Description: Represents ViewSheetSets stored in a document. ViewSheetSets can be stored so that the same printing task can be executed multiple times.
Remarks: For the in-session ViewSheetSet, see the class . Changes of ViewSheetSet would be effiective after
Inherits: Element
Implements: IDisposable, IViewSheetSet

  PROPERTIES:
    bool IsAutomatic { get; set; }
      Description: Automatic order or manual order.
    string Name { get; set; }
      Description: The view sheet set name.
    IReadOnlyList<View> OrderedViewList { get; set; }
      Description: Ordered views.
    ElementId SheetOrganizationId { get; set; }
      Description: to the for sheets.
    ElementId ViewOrganizationId { get; set; }
      Description: to the for non-sheet views.
    ViewSet Views { get; set; }
      Description: The views.

--------------------------------------------------------------------------------


[CLASS] ViewSheetSetting
Full Name: Autodesk.Revit.DB.ViewSheetSetting

Description: Represents the View/Sheet Set (Application Menu->Print) within Autodesk Revit.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    ViewSet AvailableViews { get; }
      Description: All views that can be printed.
    IViewSheetSet CurrentViewSheetSet { get; set; }
      Description: The current view sheet set of PrintSetup.
    InSessionViewSheetSet InSession { get; }
      Description: The in-session view sheet set of Print Setup.

  METHODS:
    bool Delete()
      Description: Delete the current view sheet set, and make the In-Session set as the current one.
      Returns: False if Delete operation fails, otherwise True.
    bool Rename(string newName)
      Description: Rename the current view sheet set.
      @newName: View sheet set name to be renamed as.
      Returns: False if Rename operation fails, otherwise True.
    void Revert()
      Description: Revert the current view sheet set.
    bool Save()
      Description: Save the changes for the current view sheet set.
      Returns: False if save operation fails, otherwise True.
    bool SaveAs(string newName)
      Description: Save the current view sheet set to another view sheet set with the specified name.
      @newName: View sheet set name to be saved as.
      Returns: False if Save As operation fails, otherwise True.

--------------------------------------------------------------------------------


[ENUM] ViewTemplateApplicationOption
Full Name: Autodesk.Revit.DB.ViewTemplateApplicationOption

Description: Options for applying view templates
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AllParameters = 0
    - UncontrolledParameters = 1
    - AllParametersAndStickIfNone = 2


[ENUM] ViewType
Full Name: Autodesk.Revit.DB.ViewType

Description: An enumerated type listing available view types.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - FloorPlan = 1
    - CeilingPlan = 2
    - Elevation = 3
    - ThreeD = 4
    - Schedule = 5
    - DrawingSheet = 6
    - ProjectBrowser = 7
    - Report = 8
    - DraftingView = 10
    - Legend = 11
    - SystemBrowser = 12
    - EngineeringPlan = 115
    - AreaPlan = 116
    - Section = 117
    - Detail = 118
    - CostReport = 119
    - LoadsReport = 120
    - PresureLossReport = 121
    - ColumnSchedule = 122
    - PanelSchedule = 123
    - Walkthrough = 124
    - Rendering = 125
    - SystemsAnalysisReport = 126
    - Internal = 214


[ENUM] VirtualPrinterType
Full Name: Autodesk.Revit.DB.VirtualPrinterType

Description: An enumerated to list Virtual Printer Types in Revit.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - AdobePDF = 1
    - DWFWriter = 2
    - XPSWriter = 3


[ENUM] Visibility
Full Name: Autodesk.Revit.DB.Visibility

Description: Describes the visibility of a particular geometry object.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Visible = 0
    - Highlight = 1
    - Contextual = 2
    - Invisible = 3


[CLASS] VisibleInViewFilter
Full Name: Autodesk.Revit.DB.VisibleInViewFilter

Description: A quick filter that passes elements that are most likely visible in the given view.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory. In some situations (for example, when the element geometry is not yet calculated for the input view) this filter may return true even though the element may not actually be visible when geometry is calculated.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new VisibleInViewFilter(Document document, ElementId viewId, bool inverted)
    new VisibleInViewFilter(Document document, ElementId viewId)

--------------------------------------------------------------------------------


[CLASS] Wall
Full Name: Autodesk.Revit.DB.Wall

Description: Represents a wall in Autodesk Revit.
Remarks: The wall object represents all the different kinds of walls in Revit.
Inherits: HostObject
Implements: IDisposable

  PROPERTIES:
    WallCrossSection CrossSection { get; set; }
      Description: Gets or sets the Cross-section for this wall.
    CurtainGrid CurtainGrid { get; }
      Description: Get the grid object of a curtain wall
    bool Flipped { get; }
      Description: Property to test whether the wall orientation is flipped.
    bool IsStackedWall { get; }
      Description: Identifies if the wall is a stacked wall.
    bool IsStackedWallMember { get; }
      Description: Identifies if the wall is a member of a stacked wall.
    XYZ Orientation { get; }
      Description: The outward-facing normal vector of the exterior side face at the starting point of the wall.
    ElementId SketchId { get; }
      Description: Returns id of the profile sketch, or invalidElementId if sketch does not exist.
    ElementId StackedWallOwnerId { get; }
      Description: Gets the stacked wall which contains this stacked wall member.
    StructuralWallUsage StructuralUsage { get; set; }
      Description: Retrieves or changes the wall's designated structural usage.
    WallType WallType { get; set; }
      Description: Retrieves or changes the type of the wall.
    double Width { get; }
      Description: Get the overall thickness of the wall.

  METHODS:
    void AddAttachment(ElementId targetId, AttachmentLocation attachmentLocation)
      Description: Attaches the wall to the target. If an attachment already exists with the same "attachmentLocation" value, an exception is thrown. The target should be a roof, floor, ceiling, toposolid, or other wall.
      @targetId: Target element id.
      @attachmentLocation: The attachment location.
    void AllowWrappingAtLocation(int locationIndex)
      Description: Allow end wrapping at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
    bool CanHaveProfileSketch()
      Description: Checks whether this wall has or can have a profile sketch.
      Returns: True if wall supports profile sketch, false otherwise.
    static Wall Create(Document document, IList<Curve> profile, ElementId wallTypeId, ElementId levelId, bool structural, XYZ normal)
      Description: Creates a non rectangular profile wall within the project using the specified wall type and normal vector.
      @document: The document in which the new wall is created.
      @profile: An array of planar curves that represent the vertical profile of the wall.
      @wallTypeId: Id of the wall type to be used by the new wall instead of the default type.
      @levelId: Id of the level on which the wall is to be placed.
      @structural: If set, specifies that the wall is structural in nature.
      @normal: A vector that must be perpendicular to the profile which dictates which side of the wall is considered to be inside and outside.
      Returns: If successful a new wall object within the project.
    static Wall Create(Document document, IList<Curve> profile, ElementId wallTypeId, ElementId levelId, bool structural)
      Description: Creates a non rectangular profile wall within the project using the specified wall type.
      @document: The document in which the new wall is created.
      @profile: An array of planar curves that represent the vertical profile of the wall.
      @wallTypeId: Id of the wall type to be used by the new wall instead of the default type.
      @levelId: Id of the level on which the wall is to be placed.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
    static Wall Create(Document document, IList<Curve> profile, bool structural)
      Description: Creates a non rectangular profile wall within the project using the default wall type.
      @document: The document in which the new wall is created.
      @profile: An array of planar curves that represent the vertical profile of the wall.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
    static Wall Create(Document document, Curve curve, ElementId wallTypeId, ElementId levelId, double height, double offset, bool flip, bool structural)
      Description: Creates a new rectangular profile wall within the project using the specified wall type, height, and offset.
      @document: The document in which the new wall is created.
      @curve: A curve representing the base line of the wall.
      @wallTypeId: Id of the wall type to be used by the new wall instead of the default type.
      @levelId: Id of the level on which the wall is to be placed.
      @height: The height of the wall other than the default height.
      @offset: Modifies the wall's Base Offset parameter to determine its vertical placement.
      @flip: Change which side of the wall is considered to be the inside and outside of the wall.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
    static Wall Create(Document document, Curve curve, ElementId levelId, bool structural)
      Description: Creates a new rectangular profile wall within the project using the default wall style.
      @document: The document in which the new wall is created.
      @curve: A curve representing the base line of the wall.
      @levelId: Id of the level on which the wall is to be placed.
      @structural: If set, specifies that the wall is structural in nature.
      Returns: If successful a new wall object within the project.
    Sketch CreateProfileSketch()
      Description: Creates a new Wall profile Sketch.
      Returns: Created profile Sketch of the Wall.
    void DisallowWrappingAtLocation(int locationIndex)
      Description: Disallow end wrapping at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
    void Flip()
      Description: The wall orientation will be flipped.
    IList<ElementId> GetAttachmentIds(AttachmentLocation attachmentLocation)
      Description: Gets the ids of the target elements that are attached to the Wall.
      @attachmentLocation: The attachment location.
      Returns: Returns the elements ids that are attached to this wall at the specified "attachmentLocation".
    IList<ElementId> GetStackedWallMemberIds()
      Description: Get the sub walls which belongs to the wall.
      Returns: If the wall is a stacked wall, the Ids of the sub will be returned in bottom-top order.
    IList<int> GetValidWrappingLocationIndices()
      Description: Gets all valid locations for end wrapping.
      Returns: The list of valid wrapping locations.
    double GetWrappingLocationAsCurveParameter(int locationIndex)
      Description: Gets the non-normalized (actual) curve parameter of the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Returns: The non-normalized (actual) curve parameter value on the curve.
    IList<Reference> GetWrappingLocationAsReferences(int locationIndex)
      Description: Gets an array of references to faces at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Returns: All faces' references at the location.
    static bool IsValidTargetAttachment(Document doc, ElementId targetId)
      Description: Says whether the element id can be used as a target for a new attachment.
      @doc: Current Revit document.
      @targetId: A proposed target element id for a wall attachment.
      Returns: Returns true if the element id can be used as a target for a new attachment, false otherwise.
    bool IsWallCrossSectionValid(WallCrossSection wallCrossSection)
      Description: Checks whether the desired cross section is valid for the current wall.
      @wallCrossSection: The desired cross section.
      Returns: True if the wall can be set to the desired cross section.
    bool IsWrappingAtLocationAllowed(int locationIndex)
      Description: If end wrapping is allowed at the location.
      @locationIndex: 0 or 1 represents wall's end, other number represents the wrapping locations on vertical faces of openings or profiles.
      Returns: true if it is allowed, false if it is disallowed.
    void RemoveAttachment(ElementId targetId)
      Description: Removes any attachment of the wall to the specified target.
      @targetId: Target element id.
    void RemoveAttachment(ElementId targetId, AttachmentLocation attachmentLocation)
      Description: Removes an attachment at the top or base of a wall, if there is one.
      @targetId: Target element id.
      @attachmentLocation: The attachment location.
    void RemoveProfileSketch()
      Description: Reverts an edited wall to its original shape.

--------------------------------------------------------------------------------


[ENUM] WallCrossSection
Full Name: Autodesk.Revit.DB.WallCrossSection

Description: The allowed values for the WALL_CROSS_SECTION parameter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SingleSlanted = 0
    - Vertical = 1
    - Tapered = 2


[CLASS] WallFoundation
Full Name: Autodesk.Revit.DB.WallFoundation

Description: An object that represents a wall foundation element.
Inherits: HostObject
Implements: IDisposable

  PROPERTIES:
    ElementId WallId { get; }
      Description: Returns the id of the host wall.

  METHODS:
    static WallFoundation Create(Document document, ElementId typeId, ElementId wallId)
      Description: Creates a new wall foundation within the project.
      @document: The document.
      @typeId: The id of the wall foundation type of the newly created wall foundation.
      @wallId: The id of the host wall of the newly created wall foundation.
      Returns: If successful, returns the newly created wall foundation, otherwise.

--------------------------------------------------------------------------------


[CLASS] WallFoundationType
Full Name: Autodesk.Revit.DB.WallFoundationType

Description: An object that represents the type of a wall foundation in Autodesk Revit.
Inherits: HostObjAttributes
Implements: IDisposable

--------------------------------------------------------------------------------


[ENUM] WallFunction
Full Name: Autodesk.Revit.DB.WallFunction

Description: Indicates the function of a specified WallType, as specified in the parameter FUNCTION_PARAM on the WallType.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Interior = 0
    - Exterior = 1
    - Foundation = 2
    - Retaining = 3
    - Soffit = 4
    - Coreshaft = 5


[ENUM] WallKind
Full Name: Autodesk.Revit.DB.WallKind

Description: Describes the fundamental type of wall, such as curtain wall or stacked wall.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Basic = 0
    - Curtain = 1
    - Stacked = 2
    - Unknown = -1


[ENUM] WallLocationLine
Full Name: Autodesk.Revit.DB.WallLocationLine

Description: This enumerated type represents the options for alignment of a wall's location line.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - WallCenterline = 0
    - CoreCenterline = 1
    - FinishFaceExterior = 2
    - FinishFaceInterior = 3
    - CoreExterior = 4
    - CoreInterior = 5


[ENUM] WallSide
Full Name: Autodesk.Revit.DB.WallSide

Description: Represents the possible sides of a wall where a sweep or reveal may be attached.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Exterior = 0
    - Interior = 1


[CLASS] WallSweep
Full Name: Autodesk.Revit.DB.WallSweep

Description: Represents a wall sweep or reveal.
Remarks: This element may represent either a standalone sweep or reveal element created by the Revit user interface or API, or a "fixed" wall sweep or reveal that was created by the contents of a wall's compound structure.
Inherits: HostObject
Implements: IDisposable

  METHODS:
    static WallSweep Create(Wall wall, ElementId wallSweepType, WallSweepInfo wallSweepInfo)
      Description: Creates a new wall sweep or reveal.
      @wall: The wall upon which to create the new sweep or reveal.
      @wallSweepType: The wall sweep or reveal type.
      @wallSweepInfo: The information that describes the new wall sweep or reveal.
      Returns: The new wall sweep.
    IList<ElementId> GetHostIds()
      Description: Gets a list of all host walls on which the sweep resides.
      Returns: The list of wall ids.
    WallSweepInfo GetWallSweepInfo()
      Description: Gets the information of the wall sweep or reveal.
      Returns: The information that describes the wall sweep or reveal.
    static bool WallAllowsWallSweep(Wall wall)
      Description: Validates that the wall is of a type that may be a host for a wall sweep or reveal.
      @wall: The wall.
      Returns: True if the wall may host a wall sweep, false otherwise.

--------------------------------------------------------------------------------


[CLASS] WallSweepInfo
Full Name: Autodesk.Revit.DB.WallSweepInfo

Description: Represents a wall sweep or reveal of a vertically compound structure.
Implements: IDisposable

  CONSTRUCTORS:
    new WallSweepInfo(WallSweepType type, bool vertical)
    new WallSweepInfo(bool fixed, WallSweepType type)

  PROPERTIES:
    bool CutsWall { get; set; }
      Description: Indicates if you want the sweep to cut geometry out of the host wall.
    double DefaultSetback { get; set; }
      Description: The sweep setback distance from inserts, such as windows and doors.
    double Distance { get; set; }
      Description: Represents the distance from either the top or base of the wall for horizontal sweeps, or the parameter along the wall's path curve for vertical ones.
    DistanceMeasuredFrom DistanceMeasuredFrom { get; set; }
      Description: Indicates if Distance is measured from the top or bottom of the wall.
    int Id { get; set; }
      Description: The id of the sweep or reveal.
    bool IsCutByInserts { get; set; }
      Description: Indicates if the sweep is cut by wall inserts.
    bool IsFixed { get; }
      Description: Indicates if the described wall sweep is fixed. A sweep is fixed if it is a part of a vertical compound structure.
    bool IsProfileFlipped { get; set; }
      Description: Indicates if the profile is applied upside-down.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVertical { get; }
      Description: Indicates whether the sweep or reveal is swept vertically or horizontally.
    ElementId MaterialId { get; set; }
      Description: The element id of the material used to create the sweep or reveal.
    ElementId ProfileId { get; set; }
      Description: The element id of the profile family used to create the sweep or reveal.
    double WallOffset { get; set; }
      Description: The offset from the sweep or reveal to the wall.
    WallSide WallSide { get; set; }
      Description: The side of the wall to which the sweep or reveal is attached.
    WallSweepOrientation WallSweepOrientation { get; set; }
      Description: Indicates how the profile of a horiztonal sweep is oriented with repect to the wall side face.
    WallSweepType WallSweepType { get; set; }
      Description: The type (either a wall sweep or a reveal).

  METHODS:
    void Dispose()
    bool IsEqual(WallSweepInfo toCompare)
      Description: Determines if the input object is equivalent to this WallSweepInfo.

--------------------------------------------------------------------------------


[ENUM] WallSweepOrientation
Full Name: Autodesk.Revit.DB.WallSweepOrientation

Description: Represents the orientation of horizonally placed sweep's profile relative to the wall side face.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Horizontal = 0
    - Perpendicular = 1


[ENUM] WallSweepType
Full Name: Autodesk.Revit.DB.WallSweepType

Description: Represents the possible types for methods affecting wall sweeps or reveals.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Sweep = 0
    - Reveal = 1


[CLASS] WallType
Full Name: Autodesk.Revit.DB.WallType

Description: Represents a specific type of wall, such as 'Generic - 8"'.
Remarks: All wall type objects available in the project can be retrieved from the Document object via the WallTypes property. Every Wall object has a WallType property that returns the a WallType object representing the type. This same WallType property can also be used to change the type of the wall by setting it to a different type.
Inherits: HostObjAttributes
Implements: IDisposable

  PROPERTIES:
    WallFunction Function { get; set; }
      Description: The wall function.
    WallKind Kind { get; }
      Description: The nature of the wall.
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the WallType
    double Width { get; }
      Description: The overall thickness of this type of wall.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] WallUtils
Full Name: Autodesk.Revit.DB.WallUtils

Description: General Wall utility methods

  METHODS:
    static void AllowWallJoinAtEnd(Wall wall, int end)
      Description: Allows the wall's end to join to other walls. If that end is near other walls it will become joined as a result.
      @wall: The wall in question
      @end: 0 or 1 for the beginning or end of the wall's curve
    static void DisallowWallJoinAtEnd(Wall wall, int end)
      Description: Sets the wall's end not to join to other walls.
      @wall: The wall in question
      @end: 0 or 1 for the beginning or end of the wall's curve
    static bool IsWallJoinAllowedAtEnd(Wall wall, int end)
      Description: Identifies if the indicated end of the wall allows joins or not.
      @wall: The wall in question
      @end: 0 or 1 for the beginning or end of the wall's curve
      Returns: true if it is allowed to join. false if it is disallowed.

--------------------------------------------------------------------------------


[ENUM] WidthMeasuredAt
Full Name: Autodesk.Revit.DB.WidthMeasuredAt

Description: The allowed values for the WALL_TYPE_WIDTH_MEASURED_AT parameter.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Top = 0
    - Base = 1
    - Bottom = 2


[CLASS] WireframeBuilder
Full Name: Autodesk.Revit.DB.WireframeBuilder

Description: Constructs a shape representation consisting of points and curves. That shape would typically be stored in a DirectShape or a DirectShapeType object.
Inherits: ShapeBuilder
Implements: IDisposable

  CONSTRUCTORS:
    new WireframeBuilder()

  METHODS:
    void AddCurve(Curve GCurve)
      Description: Add a curve to the shape representation stored in this WireframeBuilder.
      @GCurve: The curve to be added.
    void AddPoint(Point GPoint)
      Description: Add a point to the shape representation stored in this WireframeBuilder.
      @GPoint: The point to be added.
    void Reset()
      Description: Clears the accumulated geometry.
    static bool ValidateCurve(Curve GCurve)
      Description: Validates curve to be added to the wireframe shape being constructed. Used by addCurve to validate input. This function may be used to pre-validate the geometry being added to avoid an exception from AddCurve().
      @GCurve: Curve object to be validated.
      Returns: True is %GCurve% is acceptable as a part of a wireframe shape representation being built.
    static bool ValidatePoint(Point GPoint)
      Description: Validates the point object to be added to the wireframe shape being constructed. Used by AddPoint() to validate input.
      @GPoint: Point object to be validated.
      Returns: True is %GPoint% is acceptable as a part of a wireframe shape representation being built.

--------------------------------------------------------------------------------


[CLASS] Workset
Full Name: Autodesk.Revit.DB.Workset

Description: Represents a workset in the document.
Remarks: Worksets are a way to divide a set of elements in the Revit document into subsets for worksharing. There may be one or many worksets in a document. Each element in the document must belong to one and only one workset.
Inherits: WorksetPreview
Implements: IDisposable

  PROPERTIES:
    bool IsEditable { get; }
      Description: Whether the workset is editable.
    bool IsOpen { get; }
      Description: Whether the workset is open (rather than closed).
    bool IsVisibleByDefault { get; }
      Description: Whether the workset is visible by default.
    WorksetKind Kind { get; }
      Description: Kind of the workset.

  METHODS:
    static Workset Create(Document document, string name)
      Description: Creates a new workset.
      @document: The document in which the new instance is created.
      @name: The workset name.
      Returns: Returns the newly created workset.

--------------------------------------------------------------------------------


[CLASS] WorksetConfiguration
Full Name: Autodesk.Revit.DB.WorksetConfiguration

Description: A configuration class that is passed in to methods that open Revit documents to specify which user-created worksets are opened/closed.
Remarks: Once an instance of this class is created, it can be further modified by calling any of the other methods in any order. It is a specification of a setting for model open; the methods of this class just adjust the specification, and do not themselves open or close worksets. Only user-created worksets can be specified to be opened or closed. All system worksets are automatically open. An open workset allows its elements can be expanded and displayed. For a closed workset, Revit tries to not expand its elements, and to that end, does not display them. This is intended to help with performance by reducing Revit's memory footprint.
Implements: IDisposable

  CONSTRUCTORS:
    new WorksetConfiguration(WorksetConfigurationOption option)
    new WorksetConfiguration()
    new WorksetConfiguration(WorksetConfiguration other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Close(IList<WorksetId> worksetsToClose)
      Description: Sets a group of user-created worksets to close.
      @worksetsToClose: The group of user-created worksets to close. Non-user-created worksets and invalid workset ids will be ignored.
    void Dispose()
    void Open(IList<WorksetId> worksetsToOpen)
      Description: Sets a group of user-created worksets to open.
      @worksetsToOpen: The group of user-created worksets to open. Non-user-created worksets and invalid workset ids will be ignored.

--------------------------------------------------------------------------------


[ENUM] WorksetConfigurationOption
Full Name: Autodesk.Revit.DB.WorksetConfigurationOption

Description: A collection of options used to initialize a WorksetConfiguration.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - OpenAllWorksets = 0
    - CloseAllWorksets = 1
    - OpenLastViewed = 2


[CLASS] WorksetDefaultVisibilitySettings
Full Name: Autodesk.Revit.DB.WorksetDefaultVisibilitySettings

Description: An object that manages default visibility of worksets in a document.
Remarks: WorksetDefaultVisibilitySettings does not exist for family documents. In case worksharing is disabled in a document, all elements are moved into a single workset; that workset, and any worksets (re)created if worksharing is re-enabled, is visible by default regardless of any current settings.
Inherits: Element
Implements: IDisposable

  METHODS:
    static WorksetDefaultVisibilitySettings GetWorksetDefaultVisibilitySettings(Document aDoc)
      Description: Get the WorksetDefaultVisibilitySettings of the document.
      @aDoc: The document.
      Returns: The WorksetDefaultVisibilitySettings of the document.
    bool IsWorksetVisible(WorksetId worksetId)
      Description: Indicates whether the workset is visible by default.
      @worksetId: Id of the workset.
      Returns: Whether the workset is visible by default.
    void SetWorksetVisibility(WorksetId worksetId, bool visible)
      Description: Set the default visibility of a workset.
      @worksetId: Id of the workset.
      @visible: Whether the workset should be visible by default or not.

--------------------------------------------------------------------------------


[CLASS] WorksetFilter
Full Name: Autodesk.Revit.DB.WorksetFilter

Description: A base class for a type of filter that accepts or rejects worksets based upon criteria.
Implements: IDisposable

  PROPERTIES:
    bool IncludeStandaloneWorksetsOnly { get; set; }
      Description: True if the results of the filter only match stand-alone worksets; worksets that are not stand-alone will be rejected.
    bool Inverted { get; }
      Description: True if the results of the filter are inverted; worksets that would normally be accepted by this filter will be rejected, and worksets that would normally be rejected will be accepted.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] WorksetId
Full Name: Autodesk.Revit.DB.WorksetId

Description: WorksetId identifies a workset within a single document.
Remarks: WorksetId is not guaranteed to be unique. It is only valid within one model and its value may change when the model is synchronized with central. If unique identification of a workset is needed, the workset's GUID should be used instead.

  CONSTRUCTORS:
    new WorksetId(int id)

  PROPERTIES:
    int IntegerValue { get; }
      Description: Provides the value of the WorksetId as an integer.
    static WorksetId InvalidWorksetId { get; }
      Description: Get the invalid WorksetId whose IntegerValue is -1.

  METHODS:
    int Compare(WorksetId id)
      Description: Compares two WorksetIds.
      @id: The WorksetId to be compared with this WorksetId.
      Returns: -1 if this WorksetId is less than id, 0 if equal, 1 if greater.
    bool Equals(object obj)
      Description: Determines whether the specified is equal to the current .
      @obj: Another object.
    int GetHashCode()
      Description: Gets the integer value of the id as hash code
    string ToString()
      Description: Gets a String representation of the integer value of the id.

--------------------------------------------------------------------------------


[ENUM] WorksetKind
Full Name: Autodesk.Revit.DB.WorksetKind

Description: Indicates one of the standard kinds of workset (as available in the UI).
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - OtherWorkset = 0
    - FamilyWorkset = 1
    - ViewWorkset = 2
    - StandardWorkset = 3
    - UserWorkset = 4


[CLASS] WorksetKindFilter
Full Name: Autodesk.Revit.DB.WorksetKindFilter

Description: A filter used to match worksets of the given WorksetKind.
Remarks: This filter is a quick filter.
Inherits: WorksetFilter
Implements: IDisposable

  CONSTRUCTORS:
    new WorksetKindFilter(WorksetKind worksetKind, bool inverted)
    new WorksetKindFilter(WorksetKind worksetKind)

  PROPERTIES:
    WorksetKind WorksetKind { get; }
      Description: The WorksetKind.

--------------------------------------------------------------------------------


[CLASS] WorksetPreview
Full Name: Autodesk.Revit.DB.WorksetPreview

Description: Represents an accessor for workset data which can be obtained from an unopened document.
Remarks: As a base class of Workset, this class has limited access to data. WorksetPreviews are obtained from WorksharingUtils.GetUserWorksetInfo() from an unopened document.
Implements: IDisposable

  PROPERTIES:
    WorksetId Id { get; }
      Description: Id of the workset.
    bool IsDefaultWorkset { get; }
      Description: Whether the workset is the default one.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: Name of the workset.
    string Owner { get; }
      Description: User name of the workset.
    Guid UniqueId { get; }
      Description: UniqueId of the workset.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] WorksetTable
Full Name: Autodesk.Revit.DB.WorksetTable

Description: A table containing references to all the worksets contained in a document.
Remarks: There is one WorksetTable for each document. There will be at least one default workset in the table, even if worksharing has not been enabled in the document.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static bool CanDeleteWorkset(Document document, WorksetId worksetId, DeleteWorksetSettings deleteWorksetSettings)
      Description: Indicates if a workset can be deleted.
      @document: The document containing the worksets.
      @worksetId: The id of the workset to delete.
      @deleteWorksetSettings: The settings to delete a workset.
      Returns: True if the workset can be deleted, false otherwise.
    static void DeleteWorkset(Document document, WorksetId worksetId, DeleteWorksetSettings deleteWorksetSettings)
      Description: Delete the specific workset.
      @document: The document containing the worksets.
      @worksetId: The id of the workset to delete.
      @deleteWorksetSettings: The settings to delete a workset.
    void Dispose()
    WorksetId GetActiveWorksetId()
      Description: Returns the active workset's WorksetId.
      Returns: WorksetId of the active workset.
    Workset GetWorkset(Guid guid)
      Description: Returns the workset from a input Guid.
      @guid: Guid of the workset.
      Returns: The returned workset. if there is no workset in this table with this Id.
    Workset GetWorkset(WorksetId id)
      Description: Returns the workset from a input WorksetId.
      @id: Id of a workset.
      Returns: The returned workset. if there is no workset in this table with this Id.
    static bool IsWorksetNameUnique(Document aDoc, string name)
      Description: Checks if the given workset name is unique in the document.
      @aDoc: The document in which the workset is accessed.
      @name: The workset name.
      Returns: True if this given workset name is unique in the document, false otherwise.
    static void RenameWorkset(Document aDoc, WorksetId worksetId, string name)
      Description: Renames the workset.
      @aDoc: The document in which the workset is accessed.
      @worksetId: The workset Id.
      @name: The workset name.
    void SetActiveWorksetId(WorksetId worksetId)
      Description: Sets the active workset.
      @worksetId: The workset Id.

--------------------------------------------------------------------------------


[ENUM] WorksetVisibility
Full Name: Autodesk.Revit.DB.WorksetVisibility

Description: Indicates the visibility settings of a workset in a particular view.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Visible = 0
    - Hidden = 1
    - UseGlobalSetting = 2


[CLASS] WorksharingDisplayGraphicSettings
Full Name: Autodesk.Revit.DB.WorksharingDisplayGraphicSettings

Description: Represents the graphical settings that can be assigned to elements in the worksharing display modes.
Implements: IDisposable

  CONSTRUCTORS:
    new WorksharingDisplayGraphicSettings(bool shouldApply, Color lineColor)

  PROPERTIES:
    Color FillColor { get; }
      Description: The fill color that will be applied to elements when these settings are applied. Note that this is automatically set by increasing the luma of the specified line color by 65%.
    bool IsApplied { get; }
      Description: Indicates whether this set of graphic overrides will be applied.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color LineColor { get; }
      Description: The line color that will be applied to elements when these settings are applied.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] WorksharingDisplayMode
Full Name: Autodesk.Revit.DB.WorksharingDisplayMode

Description: Indicates which worksharing display mode a view is in.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Off = 0
    - CheckoutStatus = 1
    - Owners = 2
    - ModelUpdates = 3
    - Worksets = 4


[CLASS] WorksharingDisplaySettings
Full Name: Autodesk.Revit.DB.WorksharingDisplaySettings

Description: WorksharingDisplaySettings controls how elements will appear when they are displayed in any of the worksharing display modes.
Remarks: The colors stored in these settings are a common setting and are shared by all users in the model. Whether a given color is applied or not is specific to the current user and will not be shared by other users.
Inherits: Element
Implements: IDisposable

  METHODS:
    bool CanUserHaveOverrides(string username)
      Description: Checks whether a single username can have customized graphic overrides.
      @username: The username to check.
      Returns: False if the username is on the list of removed users, True otherwise.
    ICollection<string> GetAllUsersWithGraphicOverrides()
      Description: Returns all usernames that have graphic overrides. This list consists of all users included in the user table + all users who have explicitly been assigned overrides.
      Returns: All usernames that have been assigned graphic overrides.
    WorksharingDisplayGraphicSettings GetGraphicOverrides(WorksetId worksetId)
      Description: Returns the graphic overrides assigned to elements in a particular workset.
      @worksetId: The workset id of interest. This must be a user workset.
      Returns: Returns the graphic overrides assigned to the workset.
    WorksharingDisplayGraphicSettings GetGraphicOverrides(string username)
      Description: Returns the graphic overrides assigned for elements owned by a particular user.
      @username: The username of a particular user.
      Returns: The graphic overrides assigned to this user.
    WorksharingDisplayGraphicSettings GetGraphicOverrides(ModelUpdatesStatus statusInCentral)
      Description: Returns the graphic overrides assigned to a particular model update status.
      @statusInCentral: The model update status of interest.
      Returns: Returns the graphic overrides assigned to the model update status.
    WorksharingDisplayGraphicSettings GetGraphicOverrides(CheckoutStatus ownershipStatus)
      Description: Returns the graphic overrides associated with a particular ownership status.
      @ownershipStatus: The ownership status of interest.
      Returns: Returns the graphic overrides assigned to a particular ownership status.
    static WorksharingDisplaySettings GetOrCreateWorksharingDisplaySettings(Document doc)
      Description: Returns the worksharing display settings for the document, creating new settings for the current user if necessary.
      @doc: The document of interest.
      Returns: The worksharing display settings for the document.
    ICollection<string> GetRemovedUsers()
      Description: Returns the set of users who have been explicitly removed from the settings.
      Returns: Users who have been explicitly removed from the list.
    void RemoveUsers(Document document, ICollection<string> usersToRemove, out ICollection<string> usersActuallyRemoved)
    int RestoreUsers(ICollection<string> usersToRestore)
      Description: Adds users back to the list of displayed users and permits customization of the graphics. Any usernames that are not currently removed will be ignored. Returns the number of users who were actually restored.
      @usersToRestore: The usernames of the users to restore. Any usernames that are not currently removed will be ignored.
      Returns: The number of usernames that were actually restored.
    void SetGraphicOverrides(WorksetId worksetId, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements in a particular user workset.
      @worksetId: The workset of interest, which must be a user workset.
      @overrides: The desired graphic overrides for this workset.
    void SetGraphicOverrides(CheckoutStatus status, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements with a particular ownership status.
      @status: The ownership status of interest.
      @overrides: The desired graphic overrides for this ownership status.
    void SetGraphicOverrides(ModelUpdatesStatus status, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements with a particular status in the central model.
      @status: The status in the central model.
      @overrides: The desired graphic overrides for this status.
    void SetGraphicOverrides(string username, WorksharingDisplayGraphicSettings overrides)
      Description: Sets the graphic overrides assigned to elements owned by a particular user. The username cannot be on the list of removed usernames.
      @username: The username of the desired user.
      @overrides: The desired graphic overrides for this user.
    bool UserHasGraphicOverrides(string username)
      Description: Checks whether there are graphic overrides that would apply to elements owned by the given user in the "Individual Owners" display mode.
      @username: The username to check
      Returns: True if there are graphic overrides assigned to the username, false otherwise.

--------------------------------------------------------------------------------


[CLASS] WorksharingSaveAsOptions
Full Name: Autodesk.Revit.DB.WorksharingSaveAsOptions

Description: This class contains options specific to worksharing SaveAs.
Implements: IDisposable

  CONSTRUCTORS:
    new WorksharingSaveAsOptions()

  PROPERTIES:
    bool ClearTransmitted { get; set; }
      Description: For a transmitted model opened with DetachAndPreserveWorksets, clear its transmitted flag in the Save/SaveAs operation.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    SimpleWorksetConfiguration OpenWorksetsDefault { get; set; }
      Description: The default set of user-worksets to open when opening the model in the UI. Default is AskUserToSpecify.
    bool SaveAsCentral { get; set; }
      Description: Whether to save the new model as a central instead of local model. True: save as a central model. Default is false: save as a local model.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] WorksharingTooltipInfo
Full Name: Autodesk.Revit.DB.WorksharingTooltipInfo

Description: Worksharing information about a single element suitable for display in an in-canvas tooltip.
Remarks: Some or all of the strings may be empty.
Implements: IDisposable

  PROPERTIES:
    string Creator { get; }
      Description: The user name of the user who created the element.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string LastChangedBy { get; }
      Description: The user name of the most recent user who saved a user change of this element to the central model.
    string Owner { get; }
      Description: The current owner of the element or empty string if no one owns the element.

  METHODS:
    void Dispose()
    IList<string> GetRequesters()
      Description: The ordered list of unique user names of users who have outstanding editing requests for the specified element.
      Returns: The ordered list of unique user names.

--------------------------------------------------------------------------------


[CLASS] WorksharingUtils
Full Name: Autodesk.Revit.DB.WorksharingUtils

Description: A static class that contains utility functions related to worksharing.
Remarks: Return values from inquiries about the worksharing status of elements or worksets rely on local caching of information from the central model so it is possible that the information is out of date. Because of this, the return value is suitable for reporting to an interactive user (e.g. via a mechanism similar to Worksharing display mode), but cannot be considered a reliable indication of whether the element can be immediately edited by the application. To make an immediate attempt to edit elements, use and check the return status, then confirm if the elements are up to date. In addition, information about the current user may not be reliable while Revit is in the middle of an editing transaction. For example, if you move an unowned wall from an unowned workset to a workset you own, then before you explicitly or Revit automatically checks out the wall for you, GetCheckoutStatus() might erroneously tell you CheckoutStatus.OwnedByCurrentUser because although the official (as seen in central and by other users) owner is no one, locally it looks like you already own it since it belongs to a workset you own. For operations that interact with central (as opposed to use only cached values), Revit might opportunistically refresh some editing permissions or check the status of editing requests. Some useful definitions to keep in mind follow: The owner of a workset: the user who has the Workset checked out; this could be nobody (the empty string). The borrower of an element: the user who has explicitly checked out ("borrowed") the Element; this could be nobody. The owner of an element: If element is borrowed (i.e. explicitly checked out), then the element's owner is the borrower, otherwise it is the owner or the workset containing the element.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static ISet<ElementId> CheckoutElements(Document document, ISet<ElementId> elementsToCheckout, TransactWithCentralOptions options)
      Description: Obtains ownership for the current user of as many specified elements as possible.
      @document: The document containing the elements.
      @elementsToCheckout: The ids of the elements to attempt to check out.
      @options: Options to customize access to the central model. is allowed and means no customization.
      Returns: The ids of all specified elements that are now owned (but possibly out of date), including all that were owned prior to the function call.
    static ICollection<ElementId> CheckoutElements(Document document, ICollection<ElementId> elementsToCheckout)
      Description: Obtains ownership for the current user of as many specified elements as possible.
      @document: The document containing the elements.
      @elementsToCheckout: The ids of the elements to attempt to check out.
      Returns: The ids of all specified elements that are now owned (but possibly out of date), including all that were owned prior to the function call.
    static ISet<WorksetId> CheckoutWorksets(Document document, ISet<WorksetId> worksetsToCheckout, TransactWithCentralOptions options)
      Description: Obtains ownership for the current user of as many specified worksets as possible.
      @document: The document containing the worksets.
      @worksetsToCheckout: The ids of the worksets to attempt to check out.
      @options: Options to customize access to the central model. is allowed and means no customization.
      Returns: The ids of all specified worksets that are now owned, including all that were owned prior to the function call.
    static ICollection<WorksetId> CheckoutWorksets(Document document, ICollection<WorksetId> worksetsToCheckout)
      Description: Obtains ownership for the current user of as many specified worksets as possible.
      @document: The document containing the worksets.
      @worksetsToCheckout: The ids of the worksets to attempt to check out.
      Returns: The ids of all specified worksets that are now owned, including all that were owned prior to the function call.
    static void CreateNewLocal(ModelPath sourcePath, ModelPath targetPath)
      Description: Takes a path to a central model and copies the model into a new local file for the current user.
      @sourcePath: The path to the central model.
      @targetPath: The path to put the new local file.
    void Dispose()
    static CheckoutStatus GetCheckoutStatus(Document document, ElementId elementId)
      Description: Gets the ownership status of an element.
      @document: The document containing the element.
      @elementId: The id of the element.
      Returns: A summary of whether the element is unowned, owned by the current user, or owned by another user.
    static CheckoutStatus GetCheckoutStatus(Document document, ElementId elementId, out string owner)
    static ModelUpdatesStatus GetModelUpdatesStatus(Document document, ElementId elementId)
      Description: Gets the status of a single element in the central model.
      @document: The document containing the element.
      @elementId: The id of the element.
      Returns: The status of the element in the local session versus the central model.
    static IList<WorksetPreview> GetUserWorksetInfo(ModelPath path)
      Description: Gets information about user worksets in a workshared model file, without fully opening the file.
      @path: The path to the workshared model.
      Returns: Information about all the user worksets in the model. The list is sorted by workset id.
    static WorksharingTooltipInfo GetWorksharingTooltipInfo(Document document, ElementId elementId)
      Description: Gets worksharing information about an element to display in an in-canvas tooltip.
      @document: The document containing the element
      @elementId: The id of the element in question
      Returns: Worksharing information about the specified element.
    static RelinquishedItems RelinquishOwnership(Document document, RelinquishOptions generalCategories, TransactWithCentralOptions options)
      Description: Relinquishes ownership by the current user of as many specified elements and worksets as possible, and grants element ownership requested by other users on a first-come, first-served basis.
      @document: The document containing the elements and worksets.
      @generalCategories: General categories of items to relinquish. See RelinquishOptions for details.
      @options: Options to customize access to the central model. is allowed and means no customization.
      Returns: The elements and worksets that were relinquished.

--------------------------------------------------------------------------------


[CLASS] XYZ
Full Name: Autodesk.Revit.DB.XYZ

Description: Object representing coordinates in 3-dimensional space.
Remarks: Usually this means a point or a vector in 3-dimensional space, depending on the actual use.

  CONSTRUCTORS:
    new XYZ(double x, double y, double z)
    new XYZ()

  PROPERTIES:
    static XYZ BasisX { get; }
      Description: The basis of the X axis.
    static XYZ BasisY { get; }
      Description: The basis of the Y axis.
    static XYZ BasisZ { get; }
      Description: The basis of the Z axis.
    double Item { get; }
    double X { get; }
      Description: Gets the first coordinate.
    double Y { get; }
      Description: Gets the second coordinate.
    double Z { get; }
      Description: Gets the third coordinate.
    static XYZ Zero { get; }
      Description: The coordinate origin or zero vector.

  METHODS:
    XYZ Add(XYZ source)
      Description: Adds the specified vector to this vector and returns the result.
      @source: The vector to add to this vector.
      Returns: The vector equal to the sum of the two vectors.
    double AngleOnPlaneTo(XYZ right, XYZ normal)
      Description: Returns the angle between this vector and the specified vector projected to the specified plane.
      @right: The specified vector.
      @normal: The normal vector that defines the plane.
      Returns: The real number between 0 and 2*PI equal to the projected angle between the two vectors.
    double AngleTo(XYZ source)
      Description: Returns the angle between this vector and the specified vector.
      @source: The specified vector.
      Returns: The real number between 0 and PI equal to the angle between the two vectors in radians..
    XYZ CrossProduct(XYZ source)
      Description: The cross product of this vector and the specified vector.
      @source: The vector to multiply with this vector.
      Returns: The vector equal to the cross product.
    double DistanceTo(XYZ source)
      Description: Returns the distance from this point to the specified point.
      @source: The specified point.
      Returns: The real number equal to the distance between the two points.
    XYZ Divide(double value)
      Description: Divides this vector by the specified value and returns the result.
      @value: The value to divide this vector by.
      Returns: The divided vector.
    double DotProduct(XYZ source)
      Description: The dot product of this vector and the specified vector.
      @source: The vector to multiply with this vector.
      Returns: The real number equal to the dot product.
    double GetLength()
      Description: Gets the length of this vector.
    bool IsAlmostEqualTo(XYZ source, double tolerance)
      Description: Determines whether 2 vectors are the same within the given tolerance.
      @source: The vector to compare with this vector.
      @tolerance: The tolerance for equality check.
      Returns: True if the vectors are the same; otherwise, false.
    bool IsAlmostEqualTo(XYZ source)
      Description: Determines whether this vector and the specified vector are the same within the tolerance (1.0e-09).
      @source: The vector to compare with this vector.
      Returns: True if the vectors are the same; otherwise, false.
    bool IsUnitLength()
      Description: The boolean value that indicates whether this vector is of unit length.
    static bool IsWithinLengthLimits(XYZ point)
      Description: Validates that the input point is within Revit design limits.
      @point: The point to test.
      Returns: True if the input point is within Revit design limits, false otherwise.
    bool IsZeroLength()
      Description: The boolean value that indicates whether this vector is a zero vector.
    XYZ Multiply(double value)
      Description: Multiplies this vector by the specified value and returns the result.
      @value: The value to multiply with this vector.
      Returns: The multiplied vector.
    XYZ Negate()
      Description: Negates this vector.
      Returns: The vector opposite to this vector.
    XYZ Normalize()
      Description: Returns a new XYZ whose coordinates are the normalized values from this vector.
      Returns: The normalized XYZ or zero if the vector is almost Zero.
    XYZ Subtract(XYZ source)
      Description: Subtracts the specified vector from this vector and returns the result.
      @source: The vector to subtract from this vector.
      Returns: The vector equal to the difference between the two vectors.
    string ToString()
      Description: Gets formatted string showing (X, Y, Z) with values formatted to 9 decimal places.
    double TripleProduct(XYZ middle, XYZ right)
      Description: The triple product of this vector and the two specified vectors.
      @middle: The second vector.
      @right: The third vector.
      Returns: The real number equal to the triple product.

--------------------------------------------------------------------------------


[ENUM] ZoomFitType
Full Name: Autodesk.Revit.DB.ZoomFitType

Description: This enum is used to define type of zoom.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FitToPage = 0
    - Zoom = 1


[ENUM] ZoomType
Full Name: Autodesk.Revit.DB.ZoomType

Description: An enumerated type listing all Zoom types of Print Setting.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FitToPage = 0
    - Zoom = 1


