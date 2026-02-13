# Autodesk.Revit.DB (Types: T, U)

[CLASS] TableCellCalculatedValueData
Full Name: Autodesk.Revit.DB.TableCellCalculatedValueData

Description: The TableCellCalculatedValueData stores the data for calculated value
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    string GetName()
      Description: Gets the name of the calculated value.

--------------------------------------------------------------------------------


[CLASS] TableCellCombinedParameterData
Full Name: Autodesk.Revit.DB.TableCellCombinedParameterData

Description: The TableCellCombinedParameterData stores the data for combined parameters
Implements: IDisposable

  PROPERTIES:
    ElementId CategoryId { get; set; }
      Description: Category id for this parameter
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId ParamId { get; set; }
      Description: The parameter id
    string Prefix { get; set; }
      Description: The prefix for this parameter
    string SampleValue { get; set; }
      Description: The sample/example value for the parameter in text form
    string Separator { get; set; }
      Description: The separator for this parameter
    string Suffix { get; set; }
      Description: The suffix for this parameter

  METHODS:
    static TableCellCombinedParameterData Create()
      Description: construct a TableCellCombinedParameterData
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] TableCellStyle
Full Name: Autodesk.Revit.DB.TableCellStyle

Description: The TableCellStyle class contains the appearance settings for a given table cell, column, or table.
Implements: IDisposable

  CONSTRUCTORS:
    new TableCellStyle(TableCellStyle other)
    new TableCellStyle()

  PROPERTIES:
    Color BackgroundColor { get; set; }
      Description: The background color of this cell in the grid view.
    ElementId BorderBottomLineStyle { get; set; }
      Description: The element id (GraphicsStyle element) for the bottom line of the cell border.
    ElementId BorderLeftLineStyle { get; set; }
      Description: The element id (GraphicsStyle element) for the left line of the cell border.
    ElementId BorderRightLineStyle { get; set; }
      Description: The element id (GraphicsStyle element) for the right line of the cell border.
    ElementId BorderTopLineStyle { get; set; }
      Description: The element id (GraphicsStyle element) for the top line of the cell border.
    HorizontalAlignmentStyle FontHorizontalAlignment { get; set; }
      Description: The horizontal alignment style of text font.
    string FontName { get; set; }
      Description: The font used for this style
    VerticalAlignmentStyle FontVerticalAlignment { get; set; }
      Description: The vertical alignment style of text font.
    bool IsEnabled { get; set; }
      Description: Gets or sets the status whether this cell is enabled.
    bool IsFontBold { get; set; }
      Description: Gets or sets whether the text font is set to bold of this cell.
    bool IsFontItalic { get; set; }
      Description: Gets or sets whether the text font is set to italic of this cell.
    bool IsFontUnderline { get; set; }
      Description: Gets or sets whether the text font is set to Underline of this cell.
    bool IsInactivePhaseload { get; set; }
      Description: Gets or sets whether this is an inactive phase load cell.
    bool IsOverridden { get; }
      Description: Indicates if the cell is overridden or not.
    bool IsReadOnly { get; set; }
      Description: Gets or sets whether this cell is read only.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color SheetBackgroundColor { get; }
      Description: The background color of this cell in the sheet view.
    Color TextColor { get; set; }
      Description: The text color of this cell.
    int TextOrientation { get; set; }
      Description: The orientation of the cell (for vertical/horizontal text) with input in degrees multiplied by 10
    double TextSize { get; set; }
      Description: The text size.

  METHODS:
    void Dispose()
    TableCellStyleOverrideOptions GetCellStyleOverrideOptions()
      Description: Gets cell style override options of this cell.
    void ResetOverride()
      Description: Resets any overrides applied to this cell.
    void SetCellStyleOverrideOptions(TableCellStyleOverrideOptions helper)
      Description: Sets cell style override options of this cell.

--------------------------------------------------------------------------------


[CLASS] TableCellStyleOverrideOptions
Full Name: Autodesk.Revit.DB.TableCellStyleOverrideOptions

Description: This helper class represents the overridden characteristics of the associated cell.
Remarks: The user can override the text appearance and cell graphic properties by setting the corresponding flag to true. The global base format will control the non-overridden characteristics.
Implements: IDisposable

  CONSTRUCTORS:
    new TableCellStyleOverrideOptions(TableCellStyleOverrideOptions other)
    new TableCellStyleOverrideOptions()

  PROPERTIES:
    bool BackgroundColor { get; set; }
      Description: Indicates if the background color characteristic is overridden.
    bool Bold { get; set; }
      Description: Indicates if the bold characteristic is overridden.
    bool BorderBottomLineStyle { get; set; }
      Description: Indicates if the border bottom line style characteristic is overridden.
    bool BorderLeftLineStyle { get; set; }
      Description: Indicates if the border left line style characteristic is overridden.
    bool BorderLineStyle { get; set; }
      Description: Indicates if the border line style characteristic is overridden.
    bool BorderRightLineStyle { get; set; }
      Description: Indicates if the border right line style characteristic is overridden.
    bool BorderTopLineStyle { get; set; }
      Description: Indicates if the border top line style characteristic is overridden.
    bool Font { get; set; }
      Description: Indicates if the font name characteristic is overridden.
    bool FontColor { get; set; }
      Description: Indicates if the font color characteristic is overridden.
    bool FontSize { get; set; }
      Description: Indicates if the font size characteristic is overridden.
    bool HorizontalAlignment { get; set; }
      Description: Indicates if the horizontal alignment characteristic is overridden.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool Italics { get; set; }
      Description: Indicates if the italics characteristic is overridden.
    bool TextOrientation { get; set; }
      Description: Indicates if the text orientation characteristic is overridden.
    bool Underline { get; set; }
      Description: Indicates if the underline characteristic is overridden.
    bool VerticalAlignment { get; set; }
      Description: Indicates if the vertical alignment characteristic is overridden.

  METHODS:
    void Dispose()
    void SetAllOverrides(bool bOverride)
      Description: Sets all overrides to a specific value.
      @bOverride: The value that will be assigned to all the overrides.

--------------------------------------------------------------------------------


[CLASS] TableData
Full Name: Autodesk.Revit.DB.TableData

Description: The TableData class is implemented to hold most of the data that describe the style of the rows, columns, and cells in a table.
Implements: IDisposable

  PROPERTIES:
    bool FreezeColumnsAndRows { get; set; }
      Description: set to true if the columns and rows should be unmovable by the slider grips
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfSections { get; }
      Description: Gets the number of items in section data array.
    double Width { get; set; }
      Description: Gets or sets the table width in feet
    int WidthInPixels { get; }
      Description: Gets the width of the panel schedule in logical pixels
    int ZoomLevel { get; set; }
      Description: The value of zoom level for corresponding TableView.

  METHODS:
    void Dispose()
    TableSectionData GetSectionData(int nIndex)
      Description: Returns the section data array element at the specified index.
      @nIndex: The index of section data array. If the index is out of the boundary of section data array, is returned.
    TableSectionData GetSectionData(SectionType sectionType)
      Description: Returns the pointer to the section data array element at the specified section type.
      @sectionType: The section type of section data array. If the integral value of the section type is out of the boundary of section data array, null is returned.
    bool IsEqual(TableData OtherElem)
      Description: Checks if this element is equal in value to the other element.
    bool IsValidZoomLevel(int zoomLevel)
      Description: Verifies if the value of zoom level is valid.
      @zoomLevel: The value of zoom level.
      Returns: True if the value of zoom level is inside of the acceptable range, false otherwise.

--------------------------------------------------------------------------------


[CLASS] TableMergedCell
Full Name: Autodesk.Revit.DB.TableMergedCell

Description: The TableMergedCell class defines a merged area of the upper-left and lower-right of a table grid.
Remarks: A TableMergedCell contains member variables that define the top-left and bottom-right row and column indexes of a table grid. A TableMergedCell object can be passed as a function parameter wherever a TableMergedCell can be passed.
Implements: IDisposable

  CONSTRUCTORS:
    new TableMergedCell(int top, int left, int bottom, int right)
    new TableMergedCell()

  PROPERTIES:
    int Bottom { get; set; }
      Description: Specifies the row index of the bottom-right corner of a table grid.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Left { get; set; }
      Description: Specifies the column index of the top-left corner of a table grid.
    int Right { get; set; }
      Description: Specifies the column index of the bottom-right corner of a table grid.
    int Top { get; set; }
      Description: Specifies the row index of the top-left corner of a table grid.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] TableSectionData
Full Name: Autodesk.Revit.DB.TableSectionData

Description: The TableSectionData class represents a serialized version of an instance of section table data. The class holds row, column and cell data.
Implements: IDisposable

  PROPERTIES:
    int FirstColumnNumber { get; }
      Description: The first column in this section of the table.
    int FirstRowNumber { get; }
      Description: The first row in this section of the table.
    bool HideSection { get; set; }
      Description: Whether or not the section is hidden.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int LastColumnNumber { get; }
      Description: The last column in this section of the table.
    int LastRowNumber { get; }
      Description: The last row in this section of the table.
    bool NeedsRefresh { get; set; }
      Description: Indicates if the table data need to refresh.
    int NumberOfColumns { get; set; }
      Description: Gets or sets the number of items in column data array.
    int NumberOfRows { get; set; }
      Description: Gets or sets the number of items in row data array.

  METHODS:
    bool AllowOverrideCellStyle(int nRow, int nCol)
      Description: Identifies if the style can be overridden in the given cell.
      Returns: True if allow to override cell style.
    bool CanInsertColumn(int nIndex)
      Description: Verifies if a new column can be inserted at the given index.
      @nIndex: An integer index.
      Returns: True if the column can be inserted, false otherwise.
    bool CanInsertRow(int nIndex)
      Description: Verifies if a new row can be inserted at the given index.
      Returns: True if the row can be inserted, false otherwise.
    bool CanRemoveColumn(int nIndex)
      Description: Verifies that if the column at the given index can be removed.
      @nIndex: An integer index.
      Returns: True if the column can be removed, false otherwise.
    bool CanRemoveRow(int nIndex)
      Description: Verifies that if the row at the given index can be removed..
      @nIndex: An integer index.
      Returns: True if the row can be removed, false otherwise
    void ClearCell(int nRow, int nCol)
      Description: Deletes text or image, or removes parameter of this cell.
    void Dispose()
    TableCellCalculatedValueData GetCellCalculatedValue(int nCol)
      Description: Gets the calculated value for the specified column
    TableCellCalculatedValueData GetCellCalculatedValue(int nRow, int nCol)
      Description: Gets the calculated value for the specified cell
    ElementId GetCellCategoryId(int nCol)
      Description: Returns a column's ParamId Associated with the paramId to find the correct element
    ElementId GetCellCategoryId(int nRow, int nCol)
      Description: Returns a cell's CategoryId and if no CategoryId exists for this cell, it would come from the column. Associated with the paramId to find the correct element.
    IList<TableCellCombinedParameterData> GetCellCombinedParameters(int nCol)
      Description: Returns an array of combined parameter data for the specified column
    IList<TableCellCombinedParameterData> GetCellCombinedParameters(int nRow, int nCol)
      Description: Returns an array of combined parameter data for the specified cell
    FormatOptions GetCellFormatOptions(int nCol, Document dcument)
      Description: Returns a column's cell FormatOptions and if no FormatOptions exists for this column, it would come from the section.
    FormatOptions GetCellFormatOptions(int nRow, int nCol, Document document)
      Description: Returns a cell's FormatOptions and if no FormatOptions exists for this cell, it would come from the column, or the row, or the section.
    ElementId GetCellParamId(int nCol)
      Description: Returns a column's ParamId
    ElementId GetCellParamId(int nRow, int nCol)
      Description: Returns a cell's ParamId and if no ParamId exists for this cell, it would come from the column
    ForgeTypeId GetCellSpec(int nRow, int nCol)
      Description: Gets the spec describing values of a cell, if applicable.
      @nRow: The row index of the cell
      @nCol: The column index of the cell
      Returns: Identifier of the spec, or empty if the cell does not contain a number with units.
    string GetCellText(int nRow, int nCol)
      Description: Returns the text shown by this cell, if the cell's type is CellType.Text or CellType.ParameterText or CellType.CustomField.
      @nRow: The cell row.
      @nCol: The cell column.
      Returns: The text in the cell, or an empty string if the type if not CellType.Text or CellType.ParameterText or CellType.CustomField.
    CellType GetCellType(int nCol)
      Description: Returns a column's cell type and if no type exists for this column, it would come from the section
    CellType GetCellType(int nRow, int nCol)
      Description: Returns a cell's Type and if no Type exists for this cell, it would come from the column, or the row, or the section
    double GetColumnWidth(int nCol)
      Description: Returns a column's width in feet
    int GetColumnWidthInPixels(int nCol)
      Description: This returns a column's width in logical pixels
    Guid GetCustomFieldId(int row, int col)
      Description: Gets custom field id from the cell.
      @row: The row of the cell.
      @col: The column of the cell.
      Returns: Returns custom field id from the cell. If this cell is not of type CellType.CustomField it will return an empty Guid
    TableMergedCell GetMergedCell(int nRow, int nCol)
      Description: Gets the whole merged cell that this cell is a part of.
      @nRow: The cell row.
      @nCol: The cell column.
    double GetRowHeight(int nRow)
      Description: Returns a row's height in feet
    int GetRowHeightInPixels(int nRow)
      Description: This returns a row's height in logical pixels
    TableCellStyle GetTableCellStyle(int nRow, int nCol)
      Description: Returns a cell's style and if no style exists for this cell, it would come from the column, or the section
    void InsertColumn(int index)
      Description: Inserts a new column at the specified index relative to the current set of columns.
      @index: An integer index.
    void InsertImage(int nRow, int nColumn, ElementId imageSymbolId)
      Description: Inserts a image in the given cell.
      @nRow: The given row index.
      @nColumn: The given column index.
      @imageSymbolId: The element id of the image symbol.
    void InsertRow(int nIndex)
      Description: Inserts a row data at a specified index.
      @nIndex: An integer index.
    bool IsAcceptableParamIdAndCategoryId(int nRow, ElementId paramId, ElementId categoryId)
      Description: Identifies if the given parameter id and category id can be assigned to a cell in the given row in this table.
      @nRow: row index
      Returns: True if the ParamId and CategoryId are all valid.
    bool IsAcceptableParamIdAndCategoryId(ElementId paramId, ElementId categoryId)
      Description: Identifies if the given parameter id and category id can be assigned to a cell in this table.
      Returns: True if the ParamId and CategoryId are all acceptable.
    bool IsCellFormattable(int nRow, int nCol)
      Description: Determines whether the cell is formattable or not
      @nRow: The row index of the cell
      @nCol: The column index of the cell
    bool IsCellOverridden(int nCol)
      Description: Indicates if the column is overridden or not.
    bool IsCellOverridden(int nRow, int nCol)
      Description: Indicates if the cell is overridden or not.
    bool IsDataOutOfDate()
      Description: Indicates whether the data in this section is out of date.
      Returns: True if the data in this section is out of date, false otherwise.
    bool IsValidColumnNumber(int nCol)
      Description: Verifies if the column number is valid.
      @nCol: The column number.
      Returns: True if the column number is between FirstColumnNumber and LastColumnNumber, false otherwise.
    bool IsValidImageSymbolId(ElementId imageSymbolId)
      Description: Identifies if the element id represents a valid ImageSymbol element.
      @imageSymbolId: The element id of the image symbol.
    bool IsValidRowNumber(int nRow)
      Description: Verifies if the row number is valid.
      @nRow: The row number.
      Returns: True if the row number is between FirstRowNumber and LastRowNumber, false otherwise.
    void MergeCells(TableMergedCell mergedCell)
      Description: Merges cells for the given area.
    bool RefreshData()
      Description: Rebuilds the data in this section if it is out of date.
      Returns: True if the data is up to date after the refresh.
    void RemoveColumn(int nIndex)
      Description: Removes a column data at a specified index.
      @nIndex: An integer index
    void RemoveRow(int nIndex)
      Description: Removes a row data at a specified index.
      @nIndex: An integer index.
    void ResetCellOverride(int nCol)
      Description: Resets the override of the column.
    void ResetCellOverride(int nRow, int nCol)
      Description: Resets the override of the cell.
    void SetCellCalculatedValue(int nCol, TableCellCalculatedValueData pCalcValue)
      Description: Allows the caller to set the calculated value for a specified column
    void SetCellCalculatedValue(int nRow, int nCol, TableCellCalculatedValueData pCalcValue)
      Description: Allows the caller to set the calculated value for a specified cell
    void SetCellCombinedParameters(int nCol, IList<TableCellCombinedParameterData> paramData)
      Description: Allows the caller to set combined parameter for a specified column
    void SetCellCombinedParameters(int nRow, int nCol, IList<TableCellCombinedParameterData> paramData)
      Description: Allows the caller to set combined parameter for a specified cell
    void SetCellFormatOptions(int nRow, int nCol, FormatOptions options)
      Description: Sets a cell's FormatOptions.
      @nRow: The row index of the cell
      @nCol: The column index of the cell
      @options: The format option to assign
    void SetCellParamIdAndCategoryId(int nCol, ElementId paramId, ElementId categoryId)
      Description: Sets a column's category and parameter Id
    void SetCellParamIdAndCategoryId(int nRow, int nCol, ElementId paramId, ElementId categoryId)
      Description: Sets a cell's category and parameter Id
    void SetCellStyle(TableCellStyle Style)
      Description: Sets a section's style
    void SetCellStyle(int nCol, TableCellStyle Style)
      Description: Sets a column's style.
    void SetCellStyle(int nRow, int nCol, TableCellStyle Style)
      Description: Sets a cell's style
    void SetCellText(int nRow, int nCol, string text)
      Description: Sets a cell's to display the specified text.
      @nRow: The cell row.
      @nCol: The cell column.
      @text: The text to show in the cell.
    void SetCellType(int nCol, CellType type)
      Description: Sets a column's cell type
    void SetCellType(int nRow, int nCol, CellType type)
      Description: Sets a cell's Type
    void SetColumnWidth(int nCol, double width)
      Description: Sets a column's width in feet
    void SetColumnWidthInPixels(int nCol, int width)
      Description: This sets a column's width in logical pixels
    void SetMergedCell(int nRow, int nCol, TableMergedCell mergedCell)
      Description: Sets the merged cell that this cell is a part of.
      @nRow: The cell row.
      @nCol: The cell column.
    void SetRowHeight(int nRow, double height)
      Description: Sets a row's height in feet
    void SetRowHeightInPixels(int nRow, int height)
      Description: This sets a row's height in logical pixels

--------------------------------------------------------------------------------


[CLASS] TableView
Full Name: Autodesk.Revit.DB.TableView

Description: This represents a view that shows a table. Most of the layout data for the table is contained in the TableData class.
Inherits: View
Implements: IDisposable

  PROPERTIES:
    int MaximumColumnWidth { get; }
      Description: Gets the maximum column width
    int MaximumGridWidth { get; }
      Description: Gets the allowed maximum grid width
    int MaximumRowHeight { get; }
      Description: Gets the maximum row height
    int MinimumColumnWidth { get; }
      Description: Gets the minimum column width
    int MinimumRowHeight { get; }
      Description: Gets the minimum row height
    ElementId TargetId { get; set; }
      Description: the element id of the element that is being viewed

  METHODS:
    IList<ElementId> GetAvailableParameterCategories(SectionType sectionType, int row)
      Description: Get all available parameter categories.
      @sectionType: The section the row lies in.
      @row: The row.
      Returns: The available parameter categories.
    static IList<ElementId> GetAvailableParameters(Document cda, ElementId categoryId)
      Description: Gets a list of valid parameters for the specified category that can be used in the table view.
      @cda: The document.
      @categoryId: The specified element category id.
      Returns: The IDs of all valid parameters.
    string GetCalculatedValueName(SectionType sectionType, int row, int column)
      Description: Gets the calculated value name for a cell from the template view.
      @sectionType: The section type.
      @row: The row.
      @column: The column.
      Returns: The name of the calculated value.
    string GetCalculatedValueText(SectionType sectionType, int row, int column)
      Description: Gets the calculated value text for a cell from the instance view.
      @sectionType: The section type.
      @row: The row.
      @column: The column.
      Returns: The calculated value text.
    string GetCellText(SectionType sectionType, int row, int column)
      Description: Gets the cell's text based on its type
      @sectionType: The requested section type
      @row: Row Number in the Section
      @column: Column Number in the Section
      Returns: The text for the given cell
    bool IsValidSectionType(SectionType sectionType)
      Description: Identifies if the section type is valid for this view.
      @sectionType: The section type.
      Returns: True if the Section Type is valid, false otherwise.

--------------------------------------------------------------------------------


[ENUM] TagHeadAlignment
Full Name: Autodesk.Revit.DB.TagHeadAlignment

Description: An enumerated type listing the tag-head alignment options supported by the Bending Detail.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - RebarShapeFamily = 0
    - View = 1


[ENUM] TagHeadPositionOptions
Full Name: Autodesk.Revit.DB.TagHeadPositionOptions

Description: An enumerated type listing the tag-head position options supported by the Bending Detail.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Top = 0
    - Bottom = 1
    - Right = 2
    - Left = 3
    - Center = 4


[ENUM] TagMode
Full Name: Autodesk.Revit.DB.TagMode

Description: The modes of tag creation that are supported for IndependentTags.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TM_ADDBY_CATEGORY = 0
    - TM_ADDBY_MULTICATEGORY = 1
    - TM_ADDBY_MATERIAL = 2


[ENUM] TagOrientation
Full Name: Autodesk.Revit.DB.TagOrientation

Description: An enumerated type listing tag orientation options that are supported by IndependentTags.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Horizontal = 0
    - Vertical = 1
    - AnyModelDirection = 2


[ENUM] TagOrientationBehavior
Full Name: Autodesk.Revit.DB.TagOrientationBehavior

Description: This attribute describes the family orientation behavior.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Fixed = 0
    - RotateWithHost = 1
    - RotateAndStayUpright = 2


[CLASS] TemporaryGraphicsManager
Full Name: Autodesk.Revit.DB.TemporaryGraphicsManager

Description: A class that provides functionality to create temporary graphics in a Revit model.
Remarks: The graphics created by this class are temporary or transient. They are not subject to undo and are not saved. It's caller's responsiblity to manage their lifetime, creation and destruction, though Revit will destroy all of them when closing the model.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    int AddControl(InCanvasControlData data, ElementId ownerViewId)
      Description: Creates an in-canvas control.
      @data: Data to generate in-canvas control appearance.
      @ownerViewId: The view in which the control appears. It will show in all views if the id is invalidElementId.
      Returns: Unique index of control for future references.
    void Clear()
      Description: Clear all temporary graphics objects managed by this manager.
    void Dispose()
    ICollection<int> GetAll()
      Description: Returns all temporary graphics object indexes managed by this manager.
      Returns: Collection of temporary graphics object indexes managed by this manager.
    static TemporaryGraphicsManager GetTemporaryGraphicsManager(Document document)
      Description: Gets a TemporaryGraphicsManager reference of the document.
      @document: The document.
      Returns: Instance of TemporaryGraphicsManager.
    void RemoveControl(int index)
      Description: Deletes the existing control identified by the unique index.
      @index: Unique index of the control to be deleted.
    void SetVisibility(int index, bool visible)
      Description: Changes the visibility of temporary graphics object.
      @index: Unique index of the temporary graphics object to be updated.
      @visible: if true, it will make the temporary graphics object visible. if false, it will make the temporary graphics object invisible.
    void UpdateControl(int index, InCanvasControlData data)
      Description: Updates the in-canvas control identified by the unique index.
      @index: Unique index of the control to be updated.
      @data: data to generate in-canvas control appearance.

--------------------------------------------------------------------------------


[ENUM] TemporaryViewMode
Full Name: Autodesk.Revit.DB.TemporaryViewMode

Description: Enumeration to represent the various temporary view modes a view can be in.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - RevealHiddenElements = 1
    - TemporaryHideIsolate = 2
    - WorksharingDisplay = 3
    - TemporaryViewProperties = 4
    - ExplodedView = 6
    - RevealConstraints = 7
    - PreviewFamilyVisibility = 8


[CLASS] TemporaryViewModes
Full Name: Autodesk.Revit.DB.TemporaryViewModes

Description: A data structure containing data related to temporary view modes.
Remarks: The class contains methods and properties to manipulate states of various temporary view modes that may or may not be avilable in any of visible views of a Revit document. The temporary modes are enumerated in the class.Every view that supports temporary view modes owns an instance of this TemporaryViewModes class, which can be obtained by accessing the property of the class. Note that views which do not support temporary modes will have that property's value be Null. Multiple temporary view modes can coexist. Also, TemporaryViewProperties mode can be customized to display custom title and custom color. Setting custom title and color affects only TemporaryViewProperties mode for the specific view.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    Color CustomColor { get; set; }
      Description: Custom color for the TemporaryViewProperties mode.
    string CustomTitle { get; set; }
      Description: Custom title for the TemporaryViewProperties mode.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    PreviewFamilyVisibilityMode PreviewFamilyVisibility { get; set; }
      Description: The current state of the PreviewFamilyVisibility mode in the associated view.
    static bool PreviewFamilyVisibilityDefaultOnState { get; set; }
      Description: Controls the default state of the PreviewFamilyVisibility mode in all views.
    static bool PreviewFamilyVisibilityDefaultUncutState { get; set; }
      Description: Controls the default type of the On state of the PreviewFamilyVisibility mode in cut-able views.
    bool RevealConstraints { get; set; }
      Description: The current state of the RevealConstraints mode in the associated view.
    bool RevealHiddenElements { get; set; }
      Description: The current state of the RevealHiddenElements mode in the associated view.
    WorksharingDisplayMode WorksharingDisplay { get; set; }
      Description: The current state of the WorksharingDisplay mode in the associated view.

  METHODS:
    void DeactivateAllModes()
      Description: Deactivates all temporary modes that are currently active.
    void DeactivateMode(TemporaryViewMode mode)
      Description: Deactivates the given temporary mode.
      @mode: The mode to deactivate
    string GetCaption(TemporaryViewMode mode)
      Description: A text caption to use for the given mode.
      @mode: The mode to get a caption for.
      Returns: Text of the caption. The text is localized.
    bool IsCustomized()
      Description: Identifies if a custom temporary view mode is currently active. A custom mode is active if there is a non-empty string set for .
      Returns: Returns true a custom temporary view mode is currently active, false otherwise. A custom mode is active if there is a non-empty string set for .
    bool IsModeActive(TemporaryViewMode mode)
      Description: Tests whether a given mode is currently active or not.
      @mode: The mode being tested
    bool IsModeAvailable(TemporaryViewMode mode)
      Description: Tests whether a temporary view mode is currently available in the associated view.
      @mode: The mode to evaluate
      Returns: True of the temporary mode is currently available in the associated view.
    bool IsModeEnabled(TemporaryViewMode mode)
      Description: Tests whether a temporary view mode is currently enabled in the associated view.
      @mode: The mode to evaluate
      Returns: True if the requested mode is available and enabled in the associated view; False otherwise.
    bool IsValidState(PreviewFamilyVisibilityMode state)
      Description: Tests whether the given state is valid for the associated view and the context the view is currently in.
      @state: A state of the PreviewFamilyVisibilityMode
      Returns: Returns True if the state is applicable for the view; False otherwise.
    void RemoveCustomization()
      Description: Removes all customized values for the TemporaryViewProperties mode.

--------------------------------------------------------------------------------


[CLASS] TessellatedBuildIssue
Full Name: Autodesk.Revit.DB.TessellatedBuildIssue

Description: Types of issues encountered while constructing geometrical objects from the tessellated face sets.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberEncountered { get; }
      Description: How many times this issue was encountered in its face set during the face set processing. This number can be less than the total number of such issues in the face set, as the face set processing could be aborted due to the presence of the issues which could not be handled.

  METHODS:
    void Dispose()
    string GetIssueDescription()
      Description: Gets a string describing the issue. If the issue does not present a problem, then an empty string is returned.
      Returns: Description of the issue.
    bool IsValidIssue()
      Description: Reports whether the issue is well-formed, valid and does describe a real problem.
      Returns: Whether the issue is well formed and does describe a real problem.
    bool MakesDataUnusable()
      Description: Reports whether this issue makes some data unusable ('true') or is only shows that data format conventions were broken, but the data are still usable (false).
    bool ReportIssueToDataSource()
      Description: Reports whether this issue should be reported to the company which wrote the software which produced the face set data (true), or to Autodesk (false).

--------------------------------------------------------------------------------


[ENUM] TessellatedBuildIssueType
Full Name: Autodesk.Revit.DB.TessellatedBuildIssueType

Description: Types of issues encountered while constructing geometrical objects from the tessellatted face sets.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - AllFine = 0
    - EmptyFace = 1
    - EmptyLoop = 2
    - TooFewOriginalVertices = 3
    - TooShortOriginalLoopMeshSegment = 4
    - TooShortOriginalLoopGeomSegment = 5
    - LostTooManyLoopVertices = 6
    - OriginalLoopGeomAcuteAngle = 7
    - OriginalLoopMeshAcuteAngle = 8
    - LostAllLoops = 9
    - NonPlanarFace = 10
    - OriginalPointsTooFarFromTheirPlane = 11
    - TooSmallVertexSegementDistInOriginalLoop = 12
    - LoopOnBestFitSelfIntersects = 13
    - IntersectingOriginalLoops = 14
    - FaceWithIslands = 15
    - OriginalLoopsProximity = 16
    - OuterLoopIsNotFirst = 17
    - DegenOriginalLoop = 18
    - InconsistentInnerOuterOriginalLoopCCW = 19
    - EdgeTwiceUsedByFace = 20
    - NonManifoldEdge = 21
    - OverlappingAdjacentFaces = 22
    - PartitionPointsTooFarFromTrueEdge = 23
    - EdgeTraversalForFlip = 24
    - InconsitentMultiEdgeTraversalForFlip = 25
    - TooSmallVertexSegementDistInFinalLoop = 26
    - InternalUtilityError = 27
    - InternalError = 28
    - InternalLightError = 29
    - InternalMissingError = 30
    - UnarticulatedNonManifoldEdge = 31
    - NotSetYet = 32
    - NumberOfIssueTypes = 33


[CLASS] TessellatedFace
Full Name: Autodesk.Revit.DB.TessellatedFace

Description: Defines a planar face bounded by a polyline in 3d space. A face consists of a single connected component and can have holes.
Implements: IDisposable

  CONSTRUCTORS:
    new TessellatedFace(IList<IList<XYZ>> allLoopVertices, ElementId materialId)
    new TessellatedFace(IList<XYZ> outerLoopVertices, ElementId materialId)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId MaterialId { get; set; }
      Description: Material of the face.

  METHODS:
    void Dispose()
    IList<IList<XYZ>> GetBoundaryLoops()
      Description: Get loops bounding the face.

--------------------------------------------------------------------------------


[CLASS] TessellatedShapeBuilder
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilder

Description: A class that permits structured building of geometry or a mesh from a collection of connected faces. Contains all closed face sets and custom precisions.
Remarks: Creates a geometry populated with faces defined by TessellatedFace objects stored in the input connected face sets. The faces defined by each connected face set may form an open shell or the boundary of a solid 3D region. All faces are planar and have polyline boundaries, defined as sequences of 3d coordinates. Faces are added to the builder as a part of connected face sets, representing faces which share edges. Order of faces in the sets is irrelevant. Faces can only be added to the builder when a face set has been opened and is available to take in faces (use to open a new face set). Before attempting to build Revit geometry from the builder the current face set should be closed (). The builder allows for the possibility of multiple face sets. The builder will try to create a geometry valid in Revit despite inconsistencies or omissions in the input data. For each connected face set, it will check the face orientations and change them wherever needed so that the orientations of the faces in that set are consistent. If a connected face set is closed, it will check if the face normals point outward. If not, it will reverse the orientations of all faces. That means, each closed connected face set will represent a solid. Limitations in the current implementation: It does not support the definition of a "void", even if the user had set the orientations of the faces to define a "void". If there is more than one connected face set, it does not check if they intersect or overlap each other.
Inherits: ShapeBuilder
Implements: IDisposable

  CONSTRUCTORS:
    new TessellatedShapeBuilder()

  PROPERTIES:
    TessellatedShapeBuilderFallback Fallback { get; set; }
      Description: Defines acceptable fallback if the desired type of geometry can't be built.
    ElementId GraphicsStyleId { get; set; }
      Description: Optional - if set, the built geometry will use that graphics style.
    bool IsFaceSetOpen { get; }
      Description: Flag whether the current set of connected faces is open and additional tessellation faces can be added to it.
    int LogInteger { get; set; }
      Description: Integer value used for logging, if it is performed. Usually the number of the face set(s) in the IFC file, from which they are imported. Any value is acceptable.
    string LogString { get; set; }
      Description: String used for logging, if any. Usually the name of the file from which face sets were imported.
    int NumberOfCompletedFaceSets { get; }
      Description: Number of completed face sets.
    string OwnerInfo { get; set; }
      Description: String used for logging, if any. Usually describes the element or object, which either defined or will own the geoemtrical objects to be built.
    TessellatedShapeBuilderTarget Target { get; set; }
      Description: Requests the type of geometry to be built.

  METHODS:
    void AddFace(TessellatedFace face)
      Description: Adds a face to the currently open connected face set.
      @face: Face to add. The 'face' parameter can be added only once, as its boundary loops will be cleared while adding and 'face' will become unusable.
    bool AreTargetAndFallbackCompatible(TessellatedShapeBuilderTarget target, TessellatedShapeBuilderFallback fallback)
      Description: Checks whether this combination of fallback and target parameters can be used as a valid combination of inputs.
      @target: What kind of geometrical objects should be built.
      @fallback: What should be done if a geometrical object described by 'target' parameter cannot be built using all data from all stored face sets.
      Returns: True if the combination of fallback and target are a valid combination, false otherwise.
    void Build()
      Description: Builds the designated geometrical objects from the stored face sets. Stores the result in this TessellatedShapeBuilder object.
    void CancelConnectedFaceSet()
      Description: Cancels the current face set - i.e., all data from it will be lost and the builder will have no open connected face set anymore.
    void Clear()
      Description: Erases all face set and clears the logs, if any.
    void CloseConnectedFaceSet()
      Description: Closes the currently open connected face set.
    static MeshFromGeometryOperationResult CreateMeshByExtrusion(IList<CurveLoop> profileLoops, XYZ extrusionDirection, double extrusionDistance, ElementId materialId)
      Description: Builds a mesh by extruding curve loop(s) along extrusion distance.
      @profileLoops: The profile loops to be extruded. The loops will not be modified.
      @extrusionDirection: Direction of extrusion. The length of this vector is ignored.
      @extrusionDistance: The positive distance by which the loops are extruded in the direction of the input extrusionDir.
      @materialId: Material which should be used by a constructed mesh.
      Returns: Returns a mesh, which was constructed, and some additional information.
    bool DoesFaceHaveEnoughLoopsAndVertices(TessellatedFace face)
      Description: Checks whether 'face' has enough loops and vertcies to be valid.
      @face: The face to check.
    TessellatedShapeBuilderResult GetBuildResult()
      Description: Get the built geometry, build status and other data stored in TessellatedShapeBuilderResult. Clears the stored data.
    void OpenConnectedFaceSet(bool isSolid)
      Description: Opens a new connected face set.
      @isSolid: Whether the face set, which is being open, should be build as a solid or as a void.

--------------------------------------------------------------------------------


[ENUM] TessellatedShapeBuilderFallback
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderFallback

Description: Describes what function should do, if it cannot build a requested .
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Abort = 0
    - Salvage = 1
    - Mesh = 2


[ENUM] TessellatedShapeBuilderOutcome
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderOutcome

Description: Describes the outcome of attempt to build geometrical objects.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Mesh = 1
    - Mixed = 2
    - Nothing = 3
    - Solid = 4
    - Sheet = 5


[CLASS] TessellatedShapeBuilderResult
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderResult

Description: Describes what has construct.
Implements: IDisposable

  PROPERTIES:
    bool AreObjectsAvailable { get; }
      Description: Shows whether 'issues' still contains the original data or whether these data have already been relinquished by 'getGeometricalObjects'. The former is true, the later is false.
    bool HasInvalidData { get; }
      Description: Whether there were any inconsistencies in the face sets, stored in the tessellated shape builder while building geometrical objects.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    TessellatedShapeBuilderOutcome Outcome { get; }
      Description: What kinds of geometrical objects were built.

  METHODS:
    void Dispose()
    IList<GeometryObject> GetGeometricalObjects()
      Description: When called the first time, returns geometrical objects which were built. Later calls will throw exceptions.
      Returns: Geometrical object which were built.
    IList<TessellatedBuildIssue> GetIssuesForFaceSet(int setIndex)
      Description: Returns the array of issues encountered while processing a face set with index 'setIndex'.
      @setIndex: Index of the face set.
      Returns: Array of issues encountered while processing a face set with index 'setIndex'.
    int GetNumberOfFaceSets()
      Description: Gets number of face sets for which 'this' result was obtained.
      Returns: The number of face sets.

--------------------------------------------------------------------------------


[ENUM] TessellatedShapeBuilderTarget
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderTarget

Description: Describes what should generate, if possible.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Solid = 0
    - AnyGeometry = 1
    - Mesh = 2


[ENUM] TextAlignFlags
Full Name: Autodesk.Revit.DB.TextAlignFlags

Description: An enumerated type listing all the Text align flags.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TEF_ALIGN_LEFT = 64
    - TEF_ALIGN_CENTER = 128
    - TEF_ALIGN_RIGHT = 256
    - TEF_ALIGN_TOP = 512
    - TEF_ALIGN_MIDDLE = 1024
    - TEF_ALIGN_BOTTOM = 2048


[ENUM] TextAlignMask
Full Name: Autodesk.Revit.DB.TextAlignMask

Description: An enumerated type listing all the Text align mask.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - horzAlignMask = 448
    - vertAlignMask = 3584


[ENUM] TextBaselineStyle
Full Name: Autodesk.Revit.DB.TextBaselineStyle

Description: Supported styles of text position relative to the normal baseline.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Normal = 0
    - Subscript = 1
    - Superscript = 2


[CLASS] TextElement
Full Name: Autodesk.Revit.DB.TextElement

Description: Base class representing text elements in Revit.
Remarks: TextElement is a base class for other annotation classes, like TextNote, which have additional, more specific functionality.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    XYZ BaseDirection { get; }
      Description: Direction of the base line of the text element.
    XYZ Coord { get; set; }
      Description: Position of the text (in model coordinates.)
    double Height { get; }
      Description: Height of the area of the text content.
    HorizontalTextAlignment HorizontalAlignment { get; set; }
      Description: Horizontal alignment of the text content within the text area of the element.
    bool IsTextWrappingActive { get; }
      Description: A flag identifying whether text-wrapping is currently active in this text element or not. If text wrapping is active the width of the text box remains constant and the text will wrap. The height of the text box will automatically adjust to accomodate the height of the text. If text wrapping is not active the text does not wrap and the width of the text box adjusts with the width of the longest line of text. As the text width changes, the position of the text may change depending on the
    bool KeepRotatedTextReadable { get; set; }
      Description: A flag to control how text behaves inside a rotated text element.
    TextElementType Symbol { get; }
      Description: Get the type of the TextElement object.
    string Text { get; set; }
      Description: The content of the element as a plain string stripped of all formating.
    XYZ UpDirection { get; }
      Description: Direction along the vertical axis of letters of the text note.
    VerticalTextAlignment VerticalAlignment { get; set; }
      Description: Vertical alignment of the text.
    double Width { get; set; }
      Description: Width of the area of the text content.

  METHODS:
    static double GetMaximumAllowedWidth(Document cdda, ElementId typeId)
      Description: Returns the maximum width the text element can be created with.
      @cdda: A document containing the new text element's type
      @typeId: Id of the text type
      Returns: The maximum allowed width in paper space [ft].
    double GetMaximumAllowedWidth()
      Description: Returns the maximum width the text element can be assigned.
      Returns: The maximum allowed width in paper space [ft].
    static double GetMinimumAllowedWidth(Document cdda, ElementId typeId)
      Description: Returns the minimum width a text element can be created with.
      @cdda: A document containing the new text element's type
      @typeId: Id of the text type
      Returns: The minimum allowed width in paper space [ft].
    double GetMinimumAllowedWidth()
      Description: Returns the minimum width the text element can be assigned.
      Returns: The minimum allowed width in paper space [ft].

--------------------------------------------------------------------------------


[ENUM] TextElementBackground
Full Name: Autodesk.Revit.DB.TextElementBackground

Description: An enumerated type listing all the background mode for the built-in parameter TEXT_BACKGROUND.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TBGR_OPAQUE = 0
    - TBGR_TRANSPARENT = 1


[CLASS] TextElementType
Full Name: Autodesk.Revit.DB.TextElementType

Description: An object that represents a text style.
Inherits: LineAndTextAttrSymbol
Implements: IDisposable

--------------------------------------------------------------------------------


[ENUM] TextListStyle
Full Name: Autodesk.Revit.DB.TextListStyle

Description: Supported styles of text list paragraphs.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Bullet = 1
    - NumberArabic = 2
    - LetterLowercase = 3
    - LetterUppercase = 4
    - NumberRomanLowercase = 5
    - NumberRomanUppercase = 6


[CLASS] TextNode
Full Name: Autodesk.Revit.DB.TextNode

Description: This class represents a text annotation object in a model-exporting process.
Remarks: See also: .
Inherits: RenderNode
Implements: IDisposable

  PROPERTIES:
    XYZ BaseDirection { get; }
      Description: Direction of the base line of the text object in model space.
    Color Color { get; }
      Description: The color of the text.
    double FontHeight { get; }
      Description: Height [ft] of the text font, in model space.
    string FontName { get; }
      Description: The name of the text font.
    double Height { get; }
      Description: Height [ft] of the area of the text content in model space.
    HorizontalTextAlignment HorizontalAlignment { get; }
      Description: Indicates default horizontal alignment of the text.
    bool IsBold { get; }
      Description: Indicates whether the default formatting is set to bold text.
    bool IsItalic { get; }
      Description: Indicates whether the default formatting is set to italic text.
    bool IsKeptReadable { get; }
      Description: Indicates text behavior inside a rotated text object.
    bool IsTransparent { get; }
      Description: Indicates whether the text background is transparent or opaque.
    bool IsUnderlined { get; }
      Description: Indicates whether the default formatting is set to underlined text.
    XYZ Position { get; }
      Description: Position of the text in model coordinates.
    double TabSize { get; }
      Description: The size [ft] of the interval between tab stops, in model space.
    string Text { get; }
      Description: The content of the text annotation as a plain string stripped of all formatting.
    XYZ UpDirection { get; }
      Description: Direction along the vertical axis of letters of the text object in model space.
    VerticalTextAlignment VerticalAlignment { get; }
      Description: Indicates default vertical alignment of the text.
    double Width { get; }
      Description: Width [ft] of the area of the text content in model space.
    double WidthScale { get; }
      Description: Scale applied to the width of the text.

  METHODS:
    FormattedText GetFormattedText()
      Description: Returns an object that contains text and associated formatting of this TextNode.
      Returns: The object that contains the text and associated formatting of of the text in this text note.

--------------------------------------------------------------------------------


[CLASS] TextNote
Full Name: Autodesk.Revit.DB.TextNote

Description: A class representing text note annotations in Revit.
Inherits: TextElement
Implements: IDisposable

  PROPERTIES:
    int LeaderCount { get; }
      Description: Number of leader objects currently attached to the text note.
    LeaderAtachement LeaderLeftAttachment { get; set; }
      Description: Attachment position of leaders on the left side of the text note.
    LeaderAtachement LeaderRightAttachment { get; set; }
      Description: Attachment position of leaders on the right side of the text note.
    TextNoteType TextNoteType { get; set; }
      Description: Access the type of the TextNote object.

  METHODS:
    Leader AddLeader(TextNoteLeaderTypes leaderType)
      Description: Adds a leader to the text note.
      @leaderType: Type of the leader being added.
      Returns: The newly added leader.
    static TextNote Create(Document document, ElementId viewId, XYZ position, double width, string text, TextNoteOptions options)
      Description: Creates a new line-wrapping text note element of the given width and properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. Note that the position's relation to the text's bounding box depends on the requested text alignment (set via the Options argument). It will be the box' top-left corner for a left-aligned text, the top-right corner for a right-aligned text, and middle-top point if the text is to be centered.
      @width: Width [ft] of the text in paper space (i.e. as it is measured when printed.) If a line of text is longer than the given specified Width, the text will be automatically wrapped. If a a zero Width is supplied then this method will create an unwrapped text note element.
      @text: Text to populate the text note with.
      @options: Options to control behavior and appearance of the text note.
      Returns: The newly created text note.
    static TextNote Create(Document document, ElementId viewId, XYZ position, double width, string text, ElementId typeId)
      Description: Creates a new line-wrapping text note element of the given width and properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. For a left-aligned text (default), the origin is set at the top-left corner of the note's bounding box.
      @width: Width [ft] of the text in paper space (i.e. as it is measured when printed.) If a line of text is longer than the specified Width, the text will be automatically wrapped. If a a zero Width is supplied then this method will create an unwrapped text note element.
      @text: Text to populate the text note with.
      @typeId: Id of the text type to use for the new text note. The text type allows its font name parameter to be set to a font unavailable on the current system. However, any text note created with or set to this font type will be displayed in a default substituted font (e.g. Arial) and the UI will show a blank value in the text type font name parameter. Once the document is opened on a system which has the font set on the text type, the text note will display with that font and the UI will show that font in the text type font name parameter.
      Returns: The newly created text note.
    static TextNote Create(Document document, ElementId viewId, XYZ position, string text, TextNoteOptions options)
      Description: Creates a new unwrapped text note element with the given properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. Note that the position's relation to the text's bounding box depends on the requested text alignment (set via the Options argument). It will be the box' top-left corner for a left-aligned text, the top-right corner for a right-aligned text, and middle-top point if the text is to be centered.
      @text: Text to populate the text note with.
      @options: Options to control behavior and appearance of the text note.
      Returns: The newly created text note.
    static TextNote Create(Document document, ElementId viewId, XYZ position, string text, ElementId typeId)
      Description: Creates a new unwrapped TextNote element with the given properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. For a left-aligned text (default), the origin is set at the top-left corner of the note's bounding box.
      @text: Text to populate the text note with.
      @typeId: Id of the text type to use for the new text note.
      Returns: The newly created text note.
    FormattedText GetFormattedText()
      Description: Returns an object that contains text and associated formatting of this note.
      Returns: The object that contains the text and associated formatting of of the text in this text note.
    IList<Leader> GetLeaders()
      Description: Returns a collection of leaders currently attached to the text note.
    void RemoveLeaders()
      Description: Removes all leaders currently attached to the text note.
    void SetFormattedText(FormattedText formattedText)
      Description: Sets the text and associated formatting of the text of in this text note with a given FormattedText object.
      @formattedText: The FormattedText object containing the text and associated formatting of the text.

--------------------------------------------------------------------------------


[ENUM] TextNoteLeaderStyles
Full Name: Autodesk.Revit.DB.TextNoteLeaderStyles

Description: An enumerated type listing all the Leader styles.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - LCS_NONE = 0
    - LCS_ONE_SEG_LINE = 1
    - LCS_ONE_SEG_ARC = 2
    - LCS_TWO_SEG_LINE = 3


[ENUM] TextNoteLeaderTypes
Full Name: Autodesk.Revit.DB.TextNoteLeaderTypes

Description: Types of text-note leaders
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - TNLT_STRAIGHT_L = 0
    - TNLT_STRAIGHT_R = 1
    - TNLT_ARC_L = 2
    - TNLT_ARC_R = 3


[CLASS] TextNoteOptions
Full Name: Autodesk.Revit.DB.TextNoteOptions

Description: Options to use when creating a new text note element.
Remarks: Use an instance of this class as an argument in the TextNote.Create methods.
Implements: IDisposable

  CONSTRUCTORS:
    new TextNoteOptions(ElementId typeId)
    new TextNoteOptions()

  PROPERTIES:
    HorizontalTextAlignment HorizontalAlignment { get; set; }
      Description: Horizontal alignment of the text.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool KeepRotatedTextReadable { get; set; }
      Description: Flag controling whether a rotate text is to stay oriented to be always readable.
    double Rotation { get; set; }
      Description: Base line angle of a text note, in radians.
    ElementId TypeId { get; set; }
      Description: Id of a text type that defines the style of a text note.
    VerticalTextAlignment VerticalAlignment { get; set; }
      Description: Vertical alignment of the text.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] TextNoteType
Full Name: Autodesk.Revit.DB.TextNoteType

Description: An object that represents a text note style.
Inherits: TextElementType
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] TextRange
Full Name: Autodesk.Revit.DB.TextRange

Description: An object that is used to identify a range of characters in a .
Remarks: A TextRange consists of a start, which is a zero-based index into the text, and a length, which is the number of characters in the range. The length can be zero.
Implements: IDisposable

  CONSTRUCTORS:
    new TextRange(int start, int length)
    new TextRange()
    new TextRange(TextRange other)

  PROPERTIES:
    int End { get; }
      Description: The index of the first character after the end of the range
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Length { get; set; }
      Description: The length of the range.
    int Start { get; set; }
      Description: The start index of a range within the .

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] TextTreatment
Full Name: Autodesk.Revit.DB.TextTreatment

Description: An enumerated type listing possible text treatment modes.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Exact = 0
    - Approximate = 1


[CLASS] ThermalAsset
Full Name: Autodesk.Revit.DB.ThermalAsset

Description: Represents the properties of a material pertinent to energy analysis.
Implements: IDisposable

  CONSTRUCTORS:
    new ThermalAsset(string name, ThermalMaterialType materialType)

  PROPERTIES:
    StructuralBehavior Behavior { get; set; }
      Description: Flag indicating whether elements of this material behave isotropically or orthotropically.
    double Compressibility { get; set; }
      Description: The compressibility of the asset.
    double Density { get; set; }
      Description: The density of the asset.
    double ElectricalResistivity { get; set; }
      Description: The electrical resistivity of the asset.
    double Emissivity { get; set; }
      Description: The emissivity of the asset.
    double GasViscosity { get; set; }
      Description: The gas viscosity of the asset.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LiquidViscosity { get; set; }
      Description: The liquid viscosity of the asset.
    string Name { get; set; }
      Description: The name of the thermal asset.
    double Permeability { get; set; }
      Description: The permeability of the asset.
    double Porosity { get; set; }
      Description: The porosity of the asset.
    double Reflectivity { get; set; }
      Description: The reflectivity of the asset.
    double SpecificHeat { get; set; }
      Description: The specific heat of the asset.
    double SpecificHeatOfVaporization { get; set; }
      Description: The specific heat of vaporization of the asset.
    double ThermalConductivity { get; set; }
      Description: The thermal conductivity of the asset.
    ThermalMaterialType ThermalMaterialType { get; }
      Description: The type of material that this thermal asset describes (e.g. solid, liquid, gas.)
    bool TransmitsLight { get; set; }
      Description: A boolean flag that indicates whether or not the asset transmits light.
    double VaporPressure { get; set; }
      Description: The vapor pressure of the asset.

  METHODS:
    ThermalAsset Copy()
      Description: Produces a copy of the asset.
      Returns: A copy of the asset.
    void Dispose()
    bool Equals(ThermalAsset other)
      Description: Determines whether this thermal asset is equal to another.
      @other: The thermal asset to compare with this one.
      Returns: True if the given thermal asset is equal to this one, otherwise false.
    bool EqualsThermalOnly(ThermalAsset other)
      Description: Determines whether this thermal asset is equal to another, but ignore data from base class.
      @other: The thermal asset to compare with this one.
      Returns: True if the given thermal asset is equal to this one, otherwise false.

--------------------------------------------------------------------------------


[ENUM] ThermalMaterialType
Full Name: Autodesk.Revit.DB.ThermalMaterialType

Description: Represents the thermal material type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - Gas = 1
    - Liquid = 2
    - Solid = 3


[CLASS] ThermalProperties
Full Name: Autodesk.Revit.DB.ThermalProperties

Description: Class specific to thermal properties for assembly types, such as Wall, Floor, Ceiling, Roof and Building Pad.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    double Absorptance { get; set; }
      Description: Value of absorptance.
    double HeatTransferCoefficient { get; }
      Description: The heat transfer coefficient value (U-Value). The unit is watts per meter-squared kelvin (W/(m^2*K)).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Roughness { get; set; }
      Description: Value of roughness.
    double ThermalMass { get; }
      Description: The calculated thermal mass value. The unit is kilogram feet-squared per second squared kelvin (kg ft^2/(s^2 K)).
    double ThermalResistance { get; }
      Description: The calculated thermal resistance value (R-Value). The unit is meter-squared kelvin per watt ((m^2*K)/Watt).

--------------------------------------------------------------------------------


[CLASS] TilePattern
Full Name: Autodesk.Revit.DB.TilePattern

Description: An object representing a tile pattern that may be applied to a DividedSurface.
Remarks: TilePatterns cannot be created. A fixed selection is built into each Conceptual Mass family. TilePatterns can be retrieved by key from the Revit::DB::Document::Settings::TilePatternTable object.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    TilePatternsBuiltIn TilePatternType { get; }
      Description: The built-in system tile pattern specified by this object.
    int TilesPerSeedNode { get; }
      Description: Get the number of tiles located at each seed node.

--------------------------------------------------------------------------------


[CLASS] TilePatterns
Full Name: Autodesk.Revit.DB.TilePatterns

Description: The TilePatterns object is an interface for retrieving the TilePattern objects within the Document.
Inherits: APIObject
Implements: IDisposable

  METHODS:
    TilePattern GetTilePattern(TilePatternsBuiltIn tilePatternBuiltIn)
      Description: Retrieve a TilePattern object from a built-in type.
      Returns: A TilePattern object, or if the document is not a Massing Family.

--------------------------------------------------------------------------------


[ENUM] TilePatternsBuiltIn
Full Name: Autodesk.Revit.DB.TilePatternsBuiltIn

Description: Revit's built-in tile patterns. See .
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Rectangle = 1
    - Triangle_Bent = 2
    - Rhomboid = 3
    - Hexagon = 4
    - HalfStep = 5
    - ThirdStep = 6
    - TriangleCheckerboard_Bent = 7
    - RectangleCheckerboard = 8
    - RhomboidCheckerboard = 9
    - TriangleStep_Bent = 10
    - Arrows = 11
    - ZigZag = 12
    - Octagon = 13
    - OctagonRotate = 14
    - Triangle_Flat = 15
    - TriangleCheckerboard_Flat = 16


[CLASS] Toposolid
Full Name: Autodesk.Revit.DB.Toposolid

Description: An object that represents a Toposolid within the Autodesk Revit project.
Inherits: CeilingAndFloor
Implements: IDisposable

  PROPERTIES:
    ElementId HostTopoId { get; }
      Description: The host toposolid id of the current toposolid subdivision. If the object is not a toposolid subdivision, hostTopoId will be InvalidElementId.
    ElementId SketchId { get; }
      Description: Returns id of the sketch.

  METHODS:
    bool CanBeExcavatedBy(ElementId elementId)
      Description: Checks if the given element can be used to excavate the toposolid.
      @elementId: Id of the element
      Returns: True if the element can be used to excavate the toposolid.
    static Toposolid Create(Document document, IList<CurveLoop> profiles, IList<XYZ> points, ElementId topoTypeId, ElementId levelId)
      Description: Creates a new instance of toposolid within the project.
      @document: The document in which the new toposolid is created.
      @profiles: An array of planar curve loops that represent the profiles of the toposolid.
      @points: An array of points that used to construct the top face of the toposolid.
      @topoTypeId: Id of the toposolid type to be used by the new toposolid.
      @levelId: Id of the level on which the toposolid is to be placed.
      Returns: A new toposolid object within the project if successful.
    static Toposolid Create(Document document, IList<XYZ> points, ElementId topoTypeId, ElementId levelId)
      Description: Creates a new instance of toposolid within the project.
      @document: The document in which the new toposolid is created.
      @points: An array of points that used to construct the top face of the toposolid.
      @topoTypeId: Id of the toposolid type to be used by the new toposolid.
      @levelId: Id of the level on which the toposolid is to be placed.
      Returns: A new toposolid object within the project if successful.
    static Toposolid Create(Document document, IList<CurveLoop> profiles, ElementId topoTypeId, ElementId levelId)
      Description: Creates a new instance of toposolid within the project.
      @document: The document in which the new toposolid is created.
      @profiles: An array of planar curve loops that represent the profiles of the toposolid.
      @topoTypeId: Id of the toposolid type to be used by the new toposolid.
      @levelId: Id of the level on which the toposolid is to be placed.
      Returns: A new toposolid object within the project if successful.
    static Toposolid CreateFromTopographySurface(Document document, ElementId hostSurfaceId, ElementId topoTypeId, ElementId levelId)
      Description: Creates a toposolid element from a host TopographySurface, and toposolid sub-divisions from its subregions.
      @document: The document in which the new toposolid is created.
      @hostSurfaceId: Id of the host TopogarphySurface element.
      @topoTypeId: Id of the toposolid type to be used by the new toposolid.
      @levelId: Id of the level on which the toposolid is to be placed.
      Returns: A new toposolid object within the project if successful.
    Toposolid CreateSubDivision(Document document, IList<CurveLoop> profiles)
      Description: Create a toposolid subdivision element with the current toposolid as its host.
      @document: The document in which the new toposolid is created.
      @profiles: An array of planar curve loops that represent the profiles of the toposolid.
      Returns: The toposolid subdivision object.
    void ExcavateBy(ElementId elementId)
      Description: Excavates the toposolid by a given element.
      @elementId: Id of the element used to excavate the toposolid.
    IList<IntersectingElementData> GetIntersectingElementData()
      Description: Gets intersection data of all intersecting elements.
      Returns: The array of all intersecting element data.
    SlabShapeEditor GetSlabShapeEditor()
      Description: Gets a SlabShapeEditor that can be used to add or modify points of this Toposolid.
      Returns: The SlabShapeEditor object
    IList<ElementId> GetSubDivisionIds()
      Description: Get all element ids of toposolid subdivisions with the current toposolid as its host.
      Returns: The array of toposolid subdivision ids.
    static bool IsSmoothedSurfaceEnabled(Document document)
      Description: Get smoothed surface setting of Toposolid.
      @document: The document.
      Returns: True if smoothed surface is enabled for Toposolid, otherwise return false.
    void RemoveExcavationBy(ElementId elementId)
      Description: Remove the excavation between the given element and the toposolid.
      @elementId: Id of the element that already excavates the toposolid.
    static void SetSmoothedSurface(Document document, bool enable)
      Description: Set smoothed surface setting of Toposolid.
      @document: The document.
      @enable: True means enable smoothed surface setting, otherwise disable.
    void Simplify(double percentage)
      Description: Simplifies the toposolid by reducing the number of inner vertices to the given percentage.
      @percentage: The ratio of the number of inner vertices after simplify to the original number.
    IList<ElementId> Split(IList<CurveLoop> splitCurveLoops)
      Description: Split the toposolid by the given curve loops.
      @splitCurveLoops: An array of planar curve loops that are used to split the toposolid. All of the curve loops should lie on the sketch plane of the toposolid.
      Returns: An array of newly created toposolid ids after split.

--------------------------------------------------------------------------------


[CLASS] ToposolidType
Full Name: Autodesk.Revit.DB.ToposolidType

Description: An object that specifies the type of a Toposolid in Autodesk Revit.
Inherits: HostObjAttributes
Implements: IDisposable

  METHODS:
    ContourSetting GetContourSetting()
      Description: Get the contour setting object from the current toposolid type.
      Returns: The contour setting object.
    void SetContourSettting(ContourSetting setting)
      Description: Set the contour setting for the current toposolid type by copying from an existing contour setting object.
      @setting: An existing contour setting object.

--------------------------------------------------------------------------------


[CLASS] Transaction
Full Name: Autodesk.Revit.DB.Transaction

Description: Transactions are context-like objects that guard any changes made to a Revit model
Remarks: Any change to a document can only be made while there is an active transaction open for that document. Changes do not become part of the document until the active transaction is committed. Consequently, all changes made in a transaction can be rolled back either explicitly or implicitly by the transaction's destructor.A document can have only one transaction open at any given time.Transactions cannot be started when the document is in read-only mode, either permanently or temporarily. See the Document class methods IsReadOnly and IsModifiable for more details.Transactions in linked documents are not permitted, for linked documents are not allowed to be modified.If a transaction was started and not finished yet by the time the Transaction object is about to be disposed, the default destructor will roll it back automatically, thus all changes made to the document while this transaction was open will be discarded. It is not recommended to rely on this default behavior though. Instead, it is advised to always call either Commit or RollBack explicitly before the transaction object gets disposed. Please note that unless invoked explicitly the actual destruction of an object in managed code might not happen until the object is collected by the garbage collector.
Implements: IDisposable

  CONSTRUCTORS:
    new Transaction(Document document, string name)
    new Transaction(Document document)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    TransactionStatus Commit(FailureHandlingOptions options)
      Description: Commits all changes made to the model during the transaction.
      @options: A set of options to be used for handling eventual failures during this call. The options are only used temporarily during the commitment process. After the transaction is finished, the options will be reset to their default values.
      Returns: If finished successfully, this method returns TransactionStatus.Committed Note it is possible the RolledBack status is returned instead as an outcome of failure handling. If TransactionStatus.Pending is returned it means that failure handling has not been finalized yet and Revit awaits user's actions. Until committing is fully finalized, no changes to the document can be made (including starting of new transactions).Be aware that the returned status does not have to be necessarily the same like the status returned by even when the method is called immediately after committing the transaction. Such difference may happen due to actions made by a transaction finalizer, if there was one set. (See for more details.)
    TransactionStatus Commit()
      Description: Commits all changes made to the model during the transaction.
      Returns: If finished successfully, this method returns TransactionStatus.Committed. Note it is possible the RolledBack status is returned instead as an outcome of failure handling. If TransactionStatus::Pending is returned it means that failure handling has not been finalized yet and Revit awaits a user actions. Until committing is fully finalized, no changes to the document can be made (including starting of new transactions).The returned status does not have to be necessarily the same as the status returned by even when the method is called immediately after committing the transaction. Such a difference may happen due to actions made by a transaction finalizer, if there was one set. (See for more details.)
    void Dispose()
    FailureHandlingOptions GetFailureHandlingOptions()
      Description: Returns the current failure handling options.
      Returns: An instance of FailureHandlingOptions
    string GetName()
      Description: Returns the transaction's name.
      Returns: The transaction's current name.
    TransactionStatus GetStatus()
      Description: Returns the current status of the transaction.
      Returns: The current status of the transaction.
    bool HasEnded()
      Description: Determines whether the transaction has ended already.
      Returns: True if the transaction has already been committed or rolled back, False otherwise.
    bool HasStarted()
      Description: Determines whether the transaction has been started yet.
      Returns: True if the transaction has already started, False otherwise.
    TransactionStatus RollBack(FailureHandlingOptions options)
      Description: Rolls back all changes made to the model during the transaction.
      @options: A set of options to be used for handling eventual failures during this call. The options are only used temporarily during this rolling back process. After the transaction is finished, the options will be reset to their default values.
      Returns: If finished successfully, this method returns TransactionStatus.RolledBack. Be aware that the returned status does not have to be necessarily the same like the status returned by even when the method is called immediately after rolling back the transaction. Such difference may happen due to actions made by a transaction finalizer, if there was one set. (See for more details.)
    TransactionStatus RollBack()
      Description: Rolls back all changes made to the model during the transaction.
      Returns: If finished successfully, this method returns TransactionStatus.RolledBack. Be aware that the returned status does not have to be necessarily the same like the status returned by even when the method is called immediately after rolling back the transaction. Such difference may happen due to actions made by a transaction finalizer, if there was one set. (See for more details.)
    void SetFailureHandlingOptions(FailureHandlingOptions options)
      Description: Sets options for handling failures to be used when the transaction is being committed or rolled back.
      @options: An instance of FailureHandlingOptions to be applied to the transaction
    void SetName(string name)
      Description: Sets the transaction's name.
      @name: A name for the transaction.
    TransactionStatus Start(string name)
      Description: Starts the transaction with an assigned name.
      @name: Name of the transaction; If the transaction already has name, this new one will preplace it. The name will appear on the Undo menu in Revit if the transaction is successfully committed.
      Returns: If finished successfully, this method returns TransactionStatus.Started. Note that unless starting is successful, changes cannot be made to the document.
    TransactionStatus Start()
      Description: Starts the transaction.
      Returns: If finished successfully, this method returns TransactionStatus.Started. Note that unless starting is successful, changes cannot be made to the document.

--------------------------------------------------------------------------------


[CLASS] TransactionGroup
Full Name: Autodesk.Revit.DB.TransactionGroup

Description: Transaction groups aggregate a number of transactions.
Remarks: A transaction group controls whether transactions committed inside the group should stay committed or should be all discarded. If the group is committed, all the transactions remain committed, but if the transaction group is rolled back instead, all the inner, already committed transactions will be undone (and removed).There are two ways of committing a group - Commit and Assimilate. By committing, all transactions committed inside a group stay as they are, while by assimilating, all inner transactions will be merged into a single transaction.A transaction group can only be started when no transaction is active, and must be closed only after the last transaction started inside the group is finished, i.e. after it was either committed or rolled back.Transaction groups may be nested inside each other with the restriction that every nested transaction group is entirely contained (opened and closed) in the parent transaction group.If a transaction group was started and not finished yet by the time the TransactionGroup object is about to be, the default destructor will roll it back automatically, thus all changes made to the document while this transaction group was open will be discarded. It is not recommended to rely on this default behavior though. Instead, it is advised to always call either , , or explicitly before the group object gets destroyed. Please note that unless invoked explicitly the actual destruction of an object in managed code might not happen until the object is collected by the garbage collector.
Implements: IDisposable

  CONSTRUCTORS:
    new TransactionGroup(Document document, string transGroupName)
    new TransactionGroup(Document document)

  PROPERTIES:
    bool IsFailureHandlingForcedModal { get; set; }
      Description: Forces all transactions finished inside this group to use modal failure handling regardless of what failure handling options are set for those transactions.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    TransactionStatus Assimilate()
      Description: Assimilates all inner transactions by merging them into a single undo item.
      Returns: If finished successfully, this method returns TransactionStatus.Committed.
    TransactionStatus Commit()
      Description: Commits the transaction group.
      Returns: If finished successfully, this method returns TransactionStatus.Committed.
    void Dispose()
    string GetName()
      Description: Returns the transaction group's name. It could be an empty string.
      Returns: The transaction group's current name.
    TransactionStatus GetStatus()
      Description: Gets the current status of the transaction group.
      Returns: The current status of the transaction group.
    bool HasEnded()
      Description: Determines whether the transaction group has ended already.
      Returns: True if the transaction group has already been committed or rolled back, False otherwise.
    bool HasStarted()
      Description: Determines whether the transaction has been started yet.
      Returns: True if the transaction group has already started, False otherwise.
    TransactionStatus RollBack()
      Description: Rolls back the transaction group, which effectively undoes all transactions committed inside the group.
      Returns: If finished successfully, this method returns TransactionStatus.RolledBack.
    void SetName(string name)
      Description: Sets the transaction group's name.
      @name: A name for the transaction group.
    TransactionStatus Start(string transGroupName)
      Description: Starts the transaction group with an assigned name.
      @transGroupName: Name of the group. The name will be used only for a group that is assimilated at the end.
      Returns: If started successfully, this method returns TransactionStatus.Started.
    TransactionStatus Start()
      Description: Starts the transaction group
      Returns: If started successfully, this method returns TransactionStatus.Started.

--------------------------------------------------------------------------------


[ENUM] TransactionStatus
Full Name: Autodesk.Revit.DB.TransactionStatus

Description: An enumerated type listing the possible statuses associated with a Transaction, TransactionGroup, or SubTransaction, or the result of a particular method call on one of those objects.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Uninitialized = 0
    - Started = 1
    - RolledBack = 2
    - Committed = 3
    - Pending = 4
    - Error = 5
    - Proceed = 6


[CLASS] TransactWithCentralOptions
Full Name: Autodesk.Revit.DB.TransactWithCentralOptions

Description: Options to customize Revit behavior when accessing the central model.
Implements: IDisposable

  CONSTRUCTORS:
    new TransactWithCentralOptions()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ICentralLockedCallback GetLockCallback()
      Description: Gets the callback object that changes Revit's default behavior of endlessly waiting and repeatedly trying to lock a central model.
    void SetLockCallback(ICentralLockedCallback lockCallback)
      Description: Sets or resets a callback object that would allow an external application to change Revit's default behavior of endlessly waiting and repeatedly trying to lock a central model.

--------------------------------------------------------------------------------


[CLASS] Transform
Full Name: Autodesk.Revit.DB.Transform

Description: A transformation of the affine 3-space.
Inherits: APIObject
Implements: IDisposable

  CONSTRUCTORS:
    new Transform(Transform source)

  PROPERTIES:
    XYZ Basis { get; set; }
    XYZ BasisX { get; set; }
      Description: The basis of the X axis of this transformation.
    XYZ BasisY { get; set; }
      Description: The basis of the Y axis of this transformation.
    XYZ BasisZ { get; set; }
      Description: The basis of the Z axis of this transformation.
    double Determinant { get; }
      Description: The determinant of this transformation.
    bool HasReflection { get; }
      Description: The boolean value that indicates whether this transformation produces reflection.
    static Transform Identity { get; }
      Description: The identity transformation.
    Transform Inverse { get; }
      Description: The inverse transformation of this transformation.
    bool IsConformal { get; }
      Description: The boolean value that indicates whether this transformation is conformal.
    bool IsIdentity { get; }
      Description: The boolean value that indicates whether this transformation is an identity.
    bool IsTranslation { get; }
      Description: The boolean value that indicates whether this transformation is a translation.
    XYZ Origin { get; set; }
      Description: Defines the origin of the old coordinate system in the new coordinate system.
    double Scale { get; }
      Description: The real number that represents the scale of the transformation.

  METHODS:
    bool AlmostEqual(Transform right)
      Description: Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).
      @right: The transformation to compare with this transformation.
      Returns: True if the two transformations are equal; otherwise, false.
    static Transform CreateReflection(Plane plane)
      Description: Creates a transform that represents a reflection across the given plane.
      @plane: The plane.
      Returns: The new transform.
    static Transform CreateRotation(XYZ axis, double angle)
      Description: Creates a transform that represents a rotation about the given axis at (0, 0, 0).
      @axis: The rotation axis.
      @angle: The angle.
      Returns: The new transform.
    static Transform CreateRotationAtPoint(XYZ axis, double angle, XYZ origin)
      Description: Creates a transform that represents a rotation about the given axis at the specified point.
      @axis: The rotation axis.
      @angle: The angle.
      @origin: The origin point.
      Returns: The new transform.
    static Transform CreateTranslation(XYZ vector)
      Description: Creates a transform that represents a translation via the specified vector.
      @vector: The translation vector.
      Returns: The new transform.
    Transform Multiply(Transform right)
      Description: Multiplies this transformation by the specified transformation and returns the result.
      @right: The specified transformation.
      Returns: The transformation equal to the composition of the two transformations.
    XYZ OfPoint(XYZ point)
      Description: Applies the transformation to the point and returns the result.
      @point: The point to transform.
      Returns: The transformed point.
    XYZ OfVector(XYZ vec)
      Description: Applies the transform to the vector
      @vec: The vector to be transformed
      Returns: The new vector after transform
    Transform ScaleBasis(double scale)
      Description: Scales the basis vectors of this transformation and returns the result.
      @scale: The scale value.
      Returns: The transformation equal to the composition of the two transformations.
    Transform ScaleBasisAndOrigin(double scale)
      Description: Scales the basis vectors and the origin of this transformation and returns the result.
      @scale: The scale value.
      Returns: The transformation equal to the composition of the two transformations.

--------------------------------------------------------------------------------


[CLASS] Transform1D
Full Name: Autodesk.Revit.DB.Transform1D

Description: An affine transform of 1D Euclidean space.
Remarks: An affine transform is a linear transform plus a translation (which may be zero). 1D space is tranformed according to the following formula: t -> A*t + B where A and B are constants. Some functions only accept certain kinds of transform (e.g., rigid motion, conformal, non-singular, etc.).
Implements: IDisposable

  CONSTRUCTORS:
    new Transform1D(double scale)
    new Transform1D(double scale, double translation)
    new Transform1D(Transform1D other)

  PROPERTIES:
    double Determinant { get; }
      Description: The determinant of this transformation.
    bool IsIdentity { get; }
      Description: The boolean value that indicates whether this transformation is an identity.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Scale { get; set; }
      Description: The real number that represents the scale of this transformation.
    double Translation { get; set; }
      Description: The translational part of this transformation.

  METHODS:
    bool AlmostEqual(Transform1D right)
      Description: Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).
      @right: The transformation to compare with this transformation.
      Returns: True if the two transformations are equal, false otherwise.
    void Assign(Transform1D from)
      Description: Assigns values from the input transformation to this transformation.
      @from: The transformation to use as input.
    void Dispose()
    Transform1D GetInverse()
      Description: Gets the inverse transformation of this transformation.
    Transform1D Multiply(Transform1D right)
      Description: Multiplies this transformation by the specified transformation and returns the result.
      @right: The input transformation.
      Returns: The transformation equal to the composition of the two transformations.
    double OfPoint(double point)
      Description: Applies the transformation to the 1-dimensional point and returns the result.
      @point: The point to transform.
      Returns: The transformed point.
    double OfVector(double vector)
      Description: Applies the transformation to the 1-dimensional vector (a "tangent vector" on the real line) and returns the result.
      @vector: The vector to transform.
      Returns: The transformed vector.
    Transform1D SetToIdentity()
      Description: Set this TrfUV to the identity transform
      Returns: Returns a pointer to "this" .
    IList<double> TransformParameterDomain(double domainStart, double domainEnd)
      Description: Performs a transform of the parameter range defined by domain, and ensures that the domain is ordered correctly.
      @domainStart: The original parameter domain start.
      @domainEnd: The original parameter domain end.

--------------------------------------------------------------------------------


[CLASS] Transform2D
Full Name: Autodesk.Revit.DB.Transform2D

Description: An affine transform of 2D Euclidean space.
Remarks: An affine transform is a linear transform plus a translation (which may be zero). Some functions only accept certain kinds of transform (e.g., rigid motion, conformal, non-singular, etc.).
Implements: IDisposable

  CONSTRUCTORS:
    new Transform2D(UV uVec, UV vVec, UV origin)
    new Transform2D(Transform2D other)

  PROPERTIES:
    UV BasisU { get; set; }
      Description: The image of (1, 0) under .
    UV BasisV { get; set; }
      Description: The image of (0, 1) under .
    double Determinant { get; }
      Description: The determinant of this transformation.
    bool HasReflection { get; }
      Description: The boolean value that indicates whether this transformation produces reflection (i.e., is orientation-reversing).
    bool IsConformal { get; }
      Description: The boolean value that indicates whether this transformation is conformal.
    bool IsIdentity { get; }
      Description: The boolean value that indicates whether this transformation is an identity.
    bool IsTranslation { get; }
      Description: The boolean value that indicates whether this transformation is a translation.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    UV Origin { get; set; }
      Description: The image of (0, 0) under . This defines the translational part of the transform.
    double Scale { get; }
      Description: The real number that represents the scale of the conformal transformation.

  METHODS:
    bool AlmostEqual(Transform2D right)
      Description: Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).
      @right: The transformation to compare with this transformation.
      Returns: True if the two transformations are equal, false otherwise.
    void Assign(Transform2D from)
      Description: Assigns values from the input transformation to this transformation.
      @from: The transformation to use as input.
    static Transform2D CreateIdentity()
      Description: Creates the identity transformation.
      Returns: The identity transformation.
    void Dispose()
    Transform2D GetInverse()
      Description: Gets the inverse transformation of this transformation.
    Transform2D Multiply(Transform2D right)
      Description: Multiplies this transformation by the specified transformation and returns the result.
      Returns: The transformation equal to the composition of the two transformations.
    UV OfPoint(UV point)
      Description: Applies the transformation to the point and returns the result.
      @point: The point to transform.
      Returns: The transformed point.
    UV OfVector(UV vector)
      Description: Applies the transformation to the vector and returns the result.
      @vector: The vector to transform.
      Returns: The transformed vector.
    Transform2D PostScale(double scale)
      Description: Scales both the linear and translational parts of this transformation and returns the result.
      @scale: The scale value.
      Returns: Returns a pointer to "this" .
    Transform2D PreScale(double scale)
      Description: Scales the linear part of this transformation and returns the result.
      @scale: The scale value.
      Returns: Returns a pointer to "this" .
    Transform2D SetToIdentity()
      Description: Set this TrfUV to the identity transform.
      Returns: Returns a pointer to "this" .
    BoundingBoxUV TransformUVDomainIfPossible(BoundingBoxUV uvDomain)
      Description: Transforms an envelope () for one surface to an envelope for a coincident but differently parameterized surface.
      @uvDomain: The original surface envelope.
      Returns: If successful a new transformed surface envelope, otherwise .

--------------------------------------------------------------------------------


[CLASS] TransformWithBoundary
Full Name: Autodesk.Revit.DB.TransformWithBoundary

Description: This class contains the transform from model space to projection space for a view and the boundary in model space in which the transform is valid.
Remarks: Use the model-to-projection transform returned by to transform model points to the view's projection space. The model-to-projection transform is only valid for points in 3D model space that that can be seen through the 2D boundary returned by , when looking in the direction of . For views that are placed on sheets, you can combine the View's model-to-projection transform and the Viewport's projection-to-sheet transform to transform model points to sheet space:sheetXYZ = projectionToSheetTransform * modelToProjectionTransform * modelXYZ Model space is the global 3D coordinate space in which the 3D geometry of the model lives. View projection space is the 3D Euclidean space with a coordinate system such that X and Y are horizontal and vertical directions in the view projection plane and Z is the cross product of X and Y. Distances in the projection space are the same as would be measured on paper if the view is printed without additional scaling. Sheet space is the coordinate space of one sheet. This is the space in which viewports and titleblocks are arranged on the sheet.
Implements: IDisposable

  CONSTRUCTORS:
    new TransformWithBoundary(TransformWithBoundary other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    CurveLoop GetBoundary()
      Description: Returns the boundary for the model space to view projection space transform.
      Returns: A closed loop in model space representing the region of model space to which the model space to view projection space transform applies.
    Transform GetModelToProjectionTransform()
      Description: Gets the model space to view projection space transform.
      Returns: The model space to view projection space transformation.

--------------------------------------------------------------------------------


[CLASS] TransmissionData
Full Name: Autodesk.Revit.DB.TransmissionData

Description: A class representing information on all external file references in a document.
Remarks: TransmissionData stores information on both the previous state and requested state of an external file reference. This means that it stores the load state and path of the reference from the most recent time this TransmissionData's document was opened. It also stores load state and path information for what Revit should do the next time the document is opened. As such, TransmissionData can be used to perform operations on external file references without having to open the entire associated Revit document. The methods ReadTransmissionData and WriteTransmissionData can be used to obtain information about external references, or to change that information. For example, calling WriteTransmissionData with a TransmissionData object which has had all references set to LinkedFileStatus.Unloaded would cause no references to be loaded upon next opening the document.TransmissionData cannot add or remove references to external files. If, on file open, Revit discovers information in the TransmissionData which does not correspond to an existing external file reference, the information will be ignored on file load.The TransmissionData for a document does not contain information about references which come from external servers. TransmissionData only contains references to local files or Revit links on Revit Server. TransmissionData cannot be used to change a reference from a local file reference to an external server reference.Note that TransmissionData objects must be set to "transmitted" for the requested reference data to be meaningful. Revit ignores the TransmissionData for non-transmitted files. Marking a file as transmitted has other effects - workshared files are opened as detached from the central model, and creation of new local files is prohibited, until the file is in its final location and the file has been marked as no longer transmitted.
Implements: IDisposable

  CONSTRUCTORS:
    new TransmissionData(TransmissionData other)

  PROPERTIES:
    bool IsTransmitted { get; set; }
      Description: Determines whether this file has been transmitted or not.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string UserData { get; set; }
      Description: A string which users can store notes in.
    int Version { get; }
      Description: The format version for TransmissionData

  METHODS:
    void Dispose()
    static bool DocumentIsNotTransmitted(ModelPath filePath)
      Description: Determines whether the document at a given file location is not transmitted.
      @filePath: The path to the document whose transmitted state will be checked.
      Returns: False if the document is a transmitted file, true otherwise.
    ICollection<ElementId> GetAllExternalFileReferenceIds()
      Description: Gets the ids of all ExternalFileReferences.
      Returns: The ids of all ExternalFileReferences.
    ExternalFileReference GetDesiredReferenceData(ElementId elemId)
      Description: Gets the ExternalFileReference representing path and load status information to be used the next time this TransmissionData's document is loaded.
      @elemId: The ElementId of the Element which the external file reference is a component of.
      Returns: An ExternalFileReference containing the requested path and load status information for an external file
    ExternalFileReference GetLastSavedReferenceData(ElementId elemId)
      Description: Gets the ExternalFileReference representing path and load status information concerning the most recent time this TransmissionData's document was opened.
      @elemId: The ElementId of the Element which the external file reference is a component of.
      Returns: An ExternalFileReference containing the previous path and load status information for an external file
    static bool IsDocumentTransmitted(ModelPath filePath)
      Description: Determines whether the document at a given file location is transmitted.
      @filePath: The path to the document whose transmitted state will be checked.
      Returns: True if the document is a transmitted file, false otherwise.
    static TransmissionData ReadTransmissionData(ModelPath path)
      Description: Reads the TransmissionData associated with the file at the given location.
      @path: A ModelPath indicating the file Revit should read the TransmissionData of. If this ModelPath is a file path, it must be an absolute path.
      Returns: The TransmissionData containing external file information for the file at the given location.
    void SetDesiredReferenceData(ElementId elemId, ModelPath path, PathType pathType, bool shouldLoad)
      Description: Sets the ExternalFileReference information which Revit should use the next time it opens the document which this TransmissionData belongs to.
      @elemId: The id of the element associated with this reference.
      @path: A ModelPath indicating the location to load the external file reference from.
      @pathType: A PathType value indicating what type of path the ModelPath is.
      @shouldLoad: True if the external file should be loaded the next time Revit opens the document. False if it should be unloaded.
    static void WriteTransmissionData(ModelPath path, TransmissionData data)
      Description: Writes the given TransmissionData into the Revit file at the given location.
      @path: A ModelPath indicating the file Revit should write the TransmissionData of. This ModelPath must be a file path and an absolute path.
      @data: The TransmissionData to be written into the document. Note that Revit will not check that the ElementIds in the TransmissionData correspond to real Elements.

--------------------------------------------------------------------------------


[ENUM] TransmittedModelOptions
Full Name: Autodesk.Revit.DB.TransmittedModelOptions

Description: Enum giving desired behavior when opening or saving a transmitted workshared model.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - SaveAsNewCentral = 0
    - KeepAsTransmitted = 1
    - CancelOperation = 2


[CLASS] TriangleInShellComponent
Full Name: Autodesk.Revit.DB.TriangleInShellComponent

Description: This class represents a triangle in a TriangulatedShellComponent object. The triangle is defined by its vertices, which are specified by their indices in the TriangulatedShellComponent's array of vertices.
Remarks: A TriangulatedShellComponent stores an array of TriangleInShellComponent objects representing the triangles of the triangulation. An external class is used because the API does not allow the use of a triple of integers. Note that a TriangleInShellComponent must only be used in the context of a single, fixed TriangulatedShellComponent.
Implements: IDisposable

  CONSTRUCTORS:
    new TriangleInShellComponent(TriangleInShellComponent other)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int VertexIndex0 { get; }
      Description: Index of the triangle's first vertex in the TriangulatedShellComponent's array of vertices.
    int VertexIndex1 { get; }
      Description: Index of the triangle's second vertex in the TriangulatedShellComponent's array of vertices.
    int VertexIndex2 { get; }
      Description: Index of the triangle's third vertex in the TriangulatedShellComponent's array of vertices.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] TriangulatedShellComponent
Full Name: Autodesk.Revit.DB.TriangulatedShellComponent

Description: This class represents a triangulated boundary component of a solid or a triangulated connected component of a shell.
Remarks: The triangulation is "topologically connected" in the following sense: if two triangles share an edge geometrically, then they share a single edge topologically (i.e., they share two vertices defining the geometrically shared edge).
Implements: IDisposable

  PROPERTIES:
    bool IsClosed { get; }
      Description: True if and only if the triangulation represents a topologically closed shell (i.e., each edge is shared by two triangles).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int TriangleCount { get; }
      Description: The number of triangles in the triangulation.
    int VertexCount { get; }
      Description: The number of vertices in the triangulation.

  METHODS:
    void Clear()
      Description: Empties the contents of this TriangulatedShellComponent.
    void Dispose()
    TriangleInShellComponent GetTriangle(int triangleIndex)
      Description: Returns the triangle corresponding to the given index.
      @triangleIndex: The index of the triangle (between 0 and TriangleCount-1, inclusive).
      Returns: The triangle.
    XYZ GetVertex(int vertexIndex)
      Description: Returns the vertex with a given index.
      @vertexIndex: The index of the vertex (between 0 and getVertexCount()-1, inclusive).
      Returns: A copy of the requested vertex.
    IList<XYZ> GetVertices()
      Description: Returns the vertices of the triangulation.
      Returns: The vertices of the triangulation.

--------------------------------------------------------------------------------


[CLASS] TriangulatedSolidOrShell
Full Name: Autodesk.Revit.DB.TriangulatedSolidOrShell

Description: This class represents a triangulated solid or shell.
Remarks: The triangulation consists of a number of TriangulatedShellComponents. For a solid, there will be one TriangulatedShellComponent for each component of the solid's boundary. For example, a solid cube has just one boundary component (containing six faces), so there will be just one TriangulatedShellComponent. A solid consisting of two disjoint cubes has two boundary components (the boundaries of the two cubes), so there will be two TriangulatedShellComponents. A solid consisting of a sphere with a round void (or hole) inside it also has two boundary components (the outer sphere and the inner sphere), so there will be two TriangulatedShellComponents. For a shell, there will be one TriangulatedShellComponent for each component of the shell. Note that this class does not contain information on the containment structure of the boundary components of a solid. Be careful not to confuse the components of a solid with the solid's boundary components. This class deals only with the boundary components.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int ShellComponentCount { get; }
      Description: The number of TriangulatedShellComponents that this TriangulatedSolidOrShell contains.

  METHODS:
    void Dispose()
    TriangulatedShellComponent GetShellComponent(int componentIndex)
      Description: Returns the specified shell component of a solid or shell. Input componentIndex must lie between 0 and ShellComponentCount-1, inclusive. The returned TriangulatedShellComponent should not be modified by the caller.
      @componentIndex: The component index, must be between 0 and ShellComponentCount Ã¢â‚¬â€œ 1, inclusive.
      Returns: The component.

--------------------------------------------------------------------------------


[CLASS] TriangulationInterface
Full Name: Autodesk.Revit.DB.TriangulationInterface

Description: This abstract class provides an interface for querying a triangulation structure (vertices and triangles).
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] TriangulationInterfaceForTriangulatedShellComponent
Full Name: Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedShellComponent

Description: This class is used to call FacetingUtils::convertTrianglesToQuads with a triangulation defined by a TriangulatedShellComponent.
Remarks: Compare to TriangulationInterfaceForTriangulatedSolidOrShell, which treats with the entire solid or shell as a single triangulated structure.
Inherits: TriangulationInterface
Implements: IDisposable

  CONSTRUCTORS:
    new TriangulationInterfaceForTriangulatedShellComponent(TriangulatedShellComponent externalTriangulatedShellComponent)

--------------------------------------------------------------------------------


[CLASS] TriangulationInterfaceForTriangulatedSolidOrShell
Full Name: Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedSolidOrShell

Description: This class is used to call FacetingUtils::convertTrianglesToQuads with a triangulation defined by a TriangulatedSolidOrShell.
Remarks: The vertex and triangle indices used by this class treat the triangulated solid or shell as if all the vertices and triangles of the different shell components were collected into single sets of vertices and triangles, respectively. For example, if a solid has two shell components and the first has ten vertices while the second has five vertices, vertexIndex 6 refers to vertex[6] of the first shell component, and vertexIndex 12 refers to vertex[2] of the second shell component. You can use the class TriangulationInterfaceForTriangulatedShellComponent to get a faceting of an individual shell component.
Inherits: TriangulationInterface
Implements: IDisposable

  CONSTRUCTORS:
    new TriangulationInterfaceForTriangulatedSolidOrShell(TriangulatedSolidOrShell externalTriangulatedSolidOrShell)

--------------------------------------------------------------------------------


[CLASS] TriOrQuadFacet
Full Name: Autodesk.Revit.DB.TriOrQuadFacet

Description: This class represents a triangle or quadrilateral in a faceted structure.
Remarks: This class defines a triangle or quadrilateral with reference to an external triangulation structure. The vertices of this TriOrQuadFacet are indices into the triangulation structure's array of vertices.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Normal { get; }
      Description: A unit normal vector for this facet.
    int NumberOfVertices { get; }
      Description: The number of vertices (3 for a triangle, 4 for a quadrilateral, 0 for an unset TriOrQuadFacet).

  METHODS:
    void Dispose()
    int GetVertexIndex(int index)
      Description: Returns the index of the specified vertex of this facet (as an index into the external array of vertices in the TriangulationInterface that was used to create the list of TriOrQuadFacets).
      @index: Index of the desired vertex in this TriOrQuadFacet (between 0 and NumberOfVertices-1, inclusive).
      Returns: The index of the specified vertex in the external array of vertices (only valid if NumberOfVertices >= 3).

--------------------------------------------------------------------------------


[CLASS] TypeBinding
Full Name: Autodesk.Revit.DB.TypeBinding

Description: TypeBinding objects are used to bind a property to a Revit type, such as a wall type.
Remarks: This differs from Instance bindings in that the property is then shared by all instances that use that type. Changing the parameter for one type affects all other instances that use that type.
Inherits: ElementBinding
Implements: IDisposable

  CONSTRUCTORS:
    new TypeBinding(CategorySet categories)
    new TypeBinding()

--------------------------------------------------------------------------------


[ENUM] UnderlayOrientation
Full Name: Autodesk.Revit.DB.UnderlayOrientation

Description: Indicates how elements in the underlay are viewed.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - LookingDown = 0
    - LookingUp = 1


[ABSTRACT CLASS] UnitFormatUtils
Full Name: Autodesk.Revit.DB.UnitFormatUtils

Description: A utility class for formatting and parsing numbers with units.

  METHODS:
    static string Format(Units units, ForgeTypeId specTypeId, double value, bool forEditing)
      Description: Formats a number with units into a string.
      @units: The units formatting settings, typically obtained from Document.GetUnits().
      @specTypeId: Identifier of the spec of the value to format.
      @value: The value to format, in Revit's internal units.
      @forEditing: True if the formatting should be modified as necessary so that the formatted string can be successfully parsed, for example by suppressing digit grouping. False if unmodified settings should be used, suitable for display only.
      Returns: The formatted string.
    static string Format(Units units, ForgeTypeId specTypeId, double value, bool forEditing, FormatValueOptions formatValueOptions)
      Description: Formats a number with units into a string.
      @units: The units formatting settings, typically obtained from Document.GetUnits().
      @specTypeId: Identifier of the spec of the value to format.
      @value: The value to format, in Revit's internal units.
      @forEditing: True if the formatting should be modified as necessary so that the formatted string can be successfully parsed, for example by suppressing digit grouping. False if unmodified settings should be used, suitable for display only.
      @formatValueOptions: Additional formatting options.
      Returns: The formatted string.
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, out double value, out string message)
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, out double value)
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, ValueParsingOptions valueParsingOptions, out double value, out string message)
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, ValueParsingOptions valueParsingOptions, out double value)

--------------------------------------------------------------------------------


[CLASS] Units
Full Name: Autodesk.Revit.DB.Units

Description: A document's default settings for formatting numbers with units.
Remarks: The Units class represents a document's default settings for formatting numbers with units as strings. It contains a FormatOptions object for each unit type as well as settings related to decimal symbol and digit grouping.The Units class stores a FormatOptions object for every valid unit type, but not all of them can be directly modified. Some, like UT_Number and UT_SiteAngle, have fixed definitions. Others have definitions which are automatically derived from other unit types. For example, UT_SheetLength is derived from UT_Length and UT_ForceScale is derived from UT_Force. See IsModifiableUnitType() and GetModifiableUnitTypes().
Implements: IDisposable

  CONSTRUCTORS:
    new Units(UnitSystem unitSystem)

  PROPERTIES:
    DecimalSymbol DecimalSymbol { get; set; }
      Description: The symbol used to separate the integer and fractional parts of a number.
    DigitGroupingAmount DigitGroupingAmount { get; set; }
      Description: The number of digits in each group when numbers are formatted with digit grouping.
    DigitGroupingSymbol DigitGroupingSymbol { get; set; }
      Description: The symbol used to separate groups of digits when numbers are formatted with digit grouping.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    FormatOptions GetFormatOptions(ForgeTypeId specTypeId)
      Description: Gets the default FormatOptions for a spec.
      @specTypeId: Identifier of the spec.
      Returns: A copy of the FormatOptions.
    static IList<ForgeTypeId> GetModifiableSpecs()
      Description: Gets all specs for which the default FormatOptions can be modified.
      Returns: Identifiers of the specs for which the FormatOptions can be modified.
    static bool IsModifiableSpec(ForgeTypeId specTypeId)
      Description: Checks whether the default FormatOptions can be modified for a given spec.
      @specTypeId: Identifier of the spec to check.
      Returns: True if the FormatOptions can be modified, false otherwise.
    void SetFormatOptions(ForgeTypeId specTypeId, FormatOptions options)
      Description: Sets the default FormatOptions for a spec.
      @specTypeId: Identifier of the spec.
      @options: The FormatOptions.

--------------------------------------------------------------------------------


[ENUM] UnitSystem
Full Name: Autodesk.Revit.DB.UnitSystem

Description: A system of measurement: Metric or Imperial units.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Metric = 0
    - Imperial = 1


[ABSTRACT CLASS] UnitTypeId
Full Name: Autodesk.Revit.DB.UnitTypeId

Description: This class contains constants identifying units of measurement.

  PROPERTIES:
    static ForgeTypeId Acres { get; }
      Description: Acres.
    static ForgeTypeId Amperes { get; }
      Description: Amperes.
    static ForgeTypeId Atmospheres { get; }
      Description: Atmospheres.
    static ForgeTypeId Bars { get; }
      Description: Bars.
    static ForgeTypeId BritishThermalUnits { get; }
      Description: British thermal units.
    static ForgeTypeId BritishThermalUnitsPerDegreeFahrenheit { get; }
      Description: British thermal units per degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerHour { get; }
      Description: British thermal units per hour.
    static ForgeTypeId BritishThermalUnitsPerHourCubicFoot { get; }
      Description: British thermal units per hour cubic foot.
    static ForgeTypeId BritishThermalUnitsPerHourFootDegreeFahrenheit { get; }
      Description: British thermal units per hour foot degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerHourSquareFoot { get; }
      Description: British thermal units per hour square foot.
    static ForgeTypeId BritishThermalUnitsPerHourSquareFootDegreeFahrenheit { get; }
      Description: British thermal units per hour square foot degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerPound { get; }
      Description: British thermal units per pound.
    static ForgeTypeId BritishThermalUnitsPerPoundDegreeFahrenheit { get; }
      Description: British thermal units per pound degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerSecond { get; }
      Description: British thermal units per second.
    static ForgeTypeId BritishThermalUnitsPerSquareFootDegreeFahrenheit { get; }
      Description: British thermal units per square foot degree Fahrenheit.
    static ForgeTypeId Calories { get; }
      Description: Calories.
    static ForgeTypeId CaloriesPerSecond { get; }
      Description: Calories per second.
    static ForgeTypeId Candelas { get; }
      Description: Candelas.
    static ForgeTypeId CandelasPerSquareFoot { get; }
      Description: Candelas per square foot.
    static ForgeTypeId CandelasPerSquareMeter { get; }
      Description: Candelas per square meter.
    static ForgeTypeId Celsius { get; }
      Description: Celsius.
    static ForgeTypeId CelsiusInterval { get; }
      Description: Celsius interval.
    static ForgeTypeId Centimeters { get; }
      Description: Centimeters.
    static ForgeTypeId CentimetersPerMinute { get; }
      Description: Centimeters per minute.
    static ForgeTypeId CentimetersToTheFourthPower { get; }
      Description: Centimeters to the fourth power.
    static ForgeTypeId CentimetersToTheSixthPower { get; }
      Description: Centimeters to the sixth power.
    static ForgeTypeId Centipoises { get; }
      Description: Centipoises.
    static ForgeTypeId CubicCentimeters { get; }
      Description: Cubic centimeters.
    static ForgeTypeId CubicFeet { get; }
      Description: Cubic feet.
    static ForgeTypeId CubicFeetPerHour { get; }
      Description: Cubic feet per hour.
    static ForgeTypeId CubicFeetPerKip { get; }
      Description: Cubic feet per kip.
    static ForgeTypeId CubicFeetPerMinute { get; }
      Description: Cubic feet per minute.
    static ForgeTypeId CubicFeetPerMinuteCubicFoot { get; }
      Description: Cubic feet per minute cubic foot.
    static ForgeTypeId CubicFeetPerMinutePerBritishThermalUnitPerHour { get; }
      Description: Cubic feet per minute per British thermal unit per hour.
    static ForgeTypeId CubicFeetPerMinuteSquareFoot { get; }
      Description: Cubic feet per minute square foot.
    static ForgeTypeId CubicFeetPerMinuteTonOfRefrigeration { get; }
      Description: Cubic feet per minute ton of refrigeration.
    static ForgeTypeId CubicFeetPerPoundMass { get; }
      Description: Cubic feet per pound mass.
    static ForgeTypeId CubicInches { get; }
      Description: Cubic inches.
    static ForgeTypeId CubicMeters { get; }
      Description: Cubic meters.
    static ForgeTypeId CubicMetersPerHour { get; }
      Description: Cubic meters per hour.
    static ForgeTypeId CubicMetersPerHourCubicMeter { get; }
      Description: Cubic meters per hour cubic meter.
    static ForgeTypeId CubicMetersPerHourSquareMeter { get; }
      Description: Cubic meters per hour square meter.
    static ForgeTypeId CubicMetersPerKilogram { get; }
      Description: Cubic meters per kilogram.
    static ForgeTypeId CubicMetersPerKilonewton { get; }
      Description: Cubic meters per kilonewton.
    static ForgeTypeId CubicMetersPerSecond { get; }
      Description: Cubic meters per second.
    static ForgeTypeId CubicMetersPerWattSecond { get; }
      Description: Cubic meters per watt second.
    static ForgeTypeId CubicMillimeters { get; }
      Description: Cubic millimeters.
    static ForgeTypeId CubicYards { get; }
      Description: Cubic yards.
    static ForgeTypeId Currency { get; }
      Description: Currency.
    static ForgeTypeId CurrencyPerBritishThermalUnit { get; }
      Description: Cost per British thermal unit.
    static ForgeTypeId CurrencyPerBritishThermalUnitPerHour { get; }
      Description: Cost per British thermal unit per hour.
    static ForgeTypeId CurrencyPerSquareFoot { get; }
      Description: Cost per square foot.
    static ForgeTypeId CurrencyPerSquareMeter { get; }
      Description: Cost per square meter.
    static ForgeTypeId CurrencyPerWatt { get; }
      Description: Cost per watt.
    static ForgeTypeId CurrencyPerWattHour { get; }
      Description: Cost per watt hour.
    static ForgeTypeId Custom { get; }
      Description: Unrecognized custom unit.
    static ForgeTypeId CyclesPerSecond { get; }
      Description: Cycles per second.
    static ForgeTypeId Decimeters { get; }
      Description: Decimeters.
    static ForgeTypeId Degrees { get; }
      Description: Degrees.
    static ForgeTypeId DegreesMinutes { get; }
      Description: Degrees minutes seconds.
    static ForgeTypeId DekanewtonMeters { get; }
      Description: Dekanewton meters.
    static ForgeTypeId DekanewtonMetersPerMeter { get; }
      Description: Dekanewton meters per meter.
    static ForgeTypeId Dekanewtons { get; }
      Description: Dekanewtons.
    static ForgeTypeId DekanewtonsPerMeter { get; }
      Description: Dekanewtons per meter.
    static ForgeTypeId DekanewtonsPerSquareMeter { get; }
      Description: Dekanewtons per square meter.
    static ForgeTypeId Fahrenheit { get; }
      Description: Fahrenheit.
    static ForgeTypeId FahrenheitInterval { get; }
      Description: Fahrenheit interval.
    static ForgeTypeId Feet { get; }
      Description: Feet.
    static ForgeTypeId FeetFractionalInches { get; }
      Description: Feet and fractional inches.
    static ForgeTypeId FeetOfWater39_2DegreesFahrenheit { get; }
      Description: Feet of water (39.2 Ã‚Â°F).
    static ForgeTypeId FeetOfWater39_2DegreesFahrenheitPer100Feet { get; }
      Description: Feet of water (39.2 Ã‚Â°F) per 100 feet.
    static ForgeTypeId FeetPerKip { get; }
      Description: Feet per kip.
    static ForgeTypeId FeetPerMinute { get; }
      Description: Feet per minute.
    static ForgeTypeId FeetPerSecond { get; }
      Description: Feet per second.
    static ForgeTypeId FeetPerSecondSquared { get; }
      Description: Feet per second squared.
    static ForgeTypeId FeetToTheFourthPower { get; }
      Description: Feet to the fourth power.
    static ForgeTypeId FeetToTheSixthPower { get; }
      Description: Feet to the sixth power.
    static ForgeTypeId Fixed { get; }
      Description: Fixed.
    static ForgeTypeId Footcandles { get; }
      Description: Footcandles.
    static ForgeTypeId Footlamberts { get; }
      Description: Footlamberts.
    static ForgeTypeId FractionalInches { get; }
      Description: Fractional inches.
    static ForgeTypeId General { get; }
      Description: General.
    static ForgeTypeId Gigajoules { get; }
      Description: Gigajoules.
    static ForgeTypeId Gradians { get; }
      Description: Gradians.
    static ForgeTypeId GrainsPerHourSquareFootInchMercury { get; }
      Description: Grains per hour square foot inch mercury.
    static ForgeTypeId Hectares { get; }
      Description: Hectares.
    static ForgeTypeId Hertz { get; }
      Description: Hertz.
    static ForgeTypeId Horsepower { get; }
      Description: Horsepower.
    static ForgeTypeId Hours { get; }
      Description: Hours.
    static ForgeTypeId HourSquareFootDegreesFahrenheitPerBritishThermalUnit { get; }
      Description: Hour square foot degrees Fahrenheit per British thermal unit.
    static ForgeTypeId Inches { get; }
      Description: Inches.
    static ForgeTypeId InchesOfMercury32DegreesFahrenheit { get; }
      Description: Inches of mercury (32 Ã‚Â°F).
    static ForgeTypeId InchesOfWater60DegreesFahrenheit { get; }
      Description: Inches of water (60 Ã‚Â°F).
    static ForgeTypeId InchesOfWater60DegreesFahrenheitPer100Feet { get; }
      Description: Inches of water (60 Ã‚Â°F) per 100 feet.
    static ForgeTypeId InchesPerSecondSquared { get; }
      Description: Inches per second squared.
    static ForgeTypeId InchesToTheFourthPower { get; }
      Description: Inches to the fourth power.
    static ForgeTypeId InchesToTheSixthPower { get; }
      Description: Inches to the sixth power.
    static ForgeTypeId InverseDegreesCelsius { get; }
      Description: Inverse degrees Celsius.
    static ForgeTypeId InverseDegreesFahrenheit { get; }
      Description: Inverse degrees Fahrenheit.
    static ForgeTypeId InverseKilonewtons { get; }
      Description: Inverse kilonewtons.
    static ForgeTypeId InverseKips { get; }
      Description: Inverse kips.
    static ForgeTypeId Joules { get; }
      Description: Joules.
    static ForgeTypeId JoulesPerGram { get; }
      Description: Joules per gram.
    static ForgeTypeId JoulesPerGramDegreeCelsius { get; }
      Description: Joules per gram degree Celsius.
    static ForgeTypeId JoulesPerKelvin { get; }
      Description: Joules per Kelvin.
    static ForgeTypeId JoulesPerKilogramDegreeCelsius { get; }
      Description: Joules per kilogram degree Celsius.
    static ForgeTypeId JoulesPerSquareMeterKelvin { get; }
      Description: Joules per square meter Kelvin.
    static ForgeTypeId Kelvin { get; }
      Description: Kelvin.
    static ForgeTypeId KelvinInterval { get; }
      Description: Kelvin interval.
    static ForgeTypeId Kiloamperes { get; }
      Description: Kiloamperes.
    static ForgeTypeId Kilocalories { get; }
      Description: Kilocalories.
    static ForgeTypeId KilocaloriesPerSecond { get; }
      Description: Kilocalories per second.
    static ForgeTypeId KilogramForceMeters { get; }
      Description: Kilogram force meters.
    static ForgeTypeId KilogramForceMetersPerMeter { get; }
      Description: Kilogram force meters per meter.
    static ForgeTypeId Kilograms { get; }
      Description: Kilograms.
    static ForgeTypeId KilogramsForce { get; }
      Description: Kilograms force.
    static ForgeTypeId KilogramsForcePerMeter { get; }
      Description: Kilograms force per meter.
    static ForgeTypeId KilogramsForcePerSquareMeter { get; }
      Description: Kilograms force per square meter.
    static ForgeTypeId KilogramsPerCubicMeter { get; }
      Description: Kilograms per cubic meter.
    static ForgeTypeId KilogramsPerHour { get; }
      Description: Kilograms per hour.
    static ForgeTypeId KilogramsPerKilogramKelvin { get; }
      Description: Kilograms per kilogram kelvin.
    static ForgeTypeId KilogramsPerMeter { get; }
      Description: Kilograms per meter.
    static ForgeTypeId KilogramsPerMeterHour { get; }
      Description: Kilograms per meter hour.
    static ForgeTypeId KilogramsPerMeterSecond { get; }
      Description: Kilograms per meter second.
    static ForgeTypeId KilogramsPerMinute { get; }
      Description: Kilograms per minute.
    static ForgeTypeId KilogramsPerSecond { get; }
      Description: Kilograms per second.
    static ForgeTypeId KilogramsPerSquareMeter { get; }
      Description: Kilograms per square meter.
    static ForgeTypeId Kilojoules { get; }
      Description: Kilojoules.
    static ForgeTypeId KilojoulesPerKelvin { get; }
      Description: Kilojoules per Kelvin.
    static ForgeTypeId KilojoulesPerSquareMeterKelvin { get; }
      Description: Kilojoules per square meter Kelvin.
    static ForgeTypeId KilometersPerHour { get; }
      Description: Kilometers per hour.
    static ForgeTypeId KilometersPerSecondSquared { get; }
      Description: Kilometers per second squared.
    static ForgeTypeId KilonewtonMeters { get; }
      Description: Kilonewton meters.
    static ForgeTypeId KilonewtonMetersPerDegree { get; }
      Description: Kilonewton meters per degree.
    static ForgeTypeId KilonewtonMetersPerDegreePerMeter { get; }
      Description: Kilonewton meters per degree per meter.
    static ForgeTypeId KilonewtonMetersPerMeter { get; }
      Description: Kilonewton meters per meter.
    static ForgeTypeId Kilonewtons { get; }
      Description: Kilonewtons.
    static ForgeTypeId KilonewtonsPerCubicMeter { get; }
      Description: Kilonewtons per cubic meter.
    static ForgeTypeId KilonewtonsPerMeter { get; }
      Description: Kilonewtons per meter.
    static ForgeTypeId KilonewtonsPerSquareCentimeter { get; }
      Description: Kilonewtons per square centimeter.
    static ForgeTypeId KilonewtonsPerSquareMeter { get; }
      Description: Kilonewtons per square meter.
    static ForgeTypeId KilonewtonsPerSquareMillimeter { get; }
      Description: Kilonewtons per square millimeter.
    static ForgeTypeId Kilopascals { get; }
      Description: Kilopascals.
    static ForgeTypeId KilovoltAmperes { get; }
      Description: Kilovolt amperes.
    static ForgeTypeId Kilovolts { get; }
      Description: Kilovolts.
    static ForgeTypeId KilowattHours { get; }
      Description: Kilowatt hours.
    static ForgeTypeId Kilowatts { get; }
      Description: Kilowatts.
    static ForgeTypeId KipFeet { get; }
      Description: Kip feet.
    static ForgeTypeId KipFeetPerDegree { get; }
      Description: Kip feet per degree.
    static ForgeTypeId KipFeetPerDegreePerFoot { get; }
      Description: Kip feet per degree per foot.
    static ForgeTypeId KipFeetPerFoot { get; }
      Description: Kip feet per foot.
    static ForgeTypeId Kips { get; }
      Description: Kips.
    static ForgeTypeId KipsPerCubicFoot { get; }
      Description: Kips per cubic foot.
    static ForgeTypeId KipsPerCubicInch { get; }
      Description: Kips per cubic inch.
    static ForgeTypeId KipsPerFoot { get; }
      Description: Kips per foot.
    static ForgeTypeId KipsPerInch { get; }
      Description: Kips per inch.
    static ForgeTypeId KipsPerSquareFoot { get; }
      Description: Kips per square foot.
    static ForgeTypeId KipsPerSquareInch { get; }
      Description: Kips per square inch.
    static ForgeTypeId Liters { get; }
      Description: Liters.
    static ForgeTypeId LitersPerHour { get; }
      Description: Liters per hour.
    static ForgeTypeId LitersPerMinute { get; }
      Description: Liters per minute.
    static ForgeTypeId LitersPerSecond { get; }
      Description: Liters per second.
    static ForgeTypeId LitersPerSecondCubicMeter { get; }
      Description: Liters per second cubic meter.
    static ForgeTypeId LitersPerSecondKilowatt { get; }
      Description: Liters per second kilowatt.
    static ForgeTypeId LitersPerSecondSquareMeter { get; }
      Description: Liters per second square meter.
    static ForgeTypeId Lumens { get; }
      Description: Lumens.
    static ForgeTypeId LumensPerWatt { get; }
      Description: Lumens per watt.
    static ForgeTypeId Lux { get; }
      Description: Lux.
    static ForgeTypeId Megajoules { get; }
      Description: Megajoules.
    static ForgeTypeId MeganewtonMeters { get; }
      Description: Meganewton meters.
    static ForgeTypeId MeganewtonMetersPerMeter { get; }
      Description: Meganewton meters per meter.
    static ForgeTypeId Meganewtons { get; }
      Description: Meganewtons.
    static ForgeTypeId MeganewtonsPerMeter { get; }
      Description: Meganewtons per meter.
    static ForgeTypeId MeganewtonsPerSquareMeter { get; }
      Description: Meganewtons per square meter.
    static ForgeTypeId Megapascals { get; }
      Description: Megapascals.
    static ForgeTypeId Megawatts { get; }
      Description: Megawatts.
    static ForgeTypeId Meters { get; }
      Description: Meters.
    static ForgeTypeId MetersCentimeters { get; }
      Description: Meters and centimeters.
    static ForgeTypeId MetersOfWaterColumn { get; }
      Description: Meters of water column.
    static ForgeTypeId MetersOfWaterColumnPerMeter { get; }
      Description: Meters of water column per meter.
    static ForgeTypeId MetersPerKilonewton { get; }
      Description: Meters per kilonewton.
    static ForgeTypeId MetersPerSecond { get; }
      Description: Meters per second.
    static ForgeTypeId MetersPerSecondSquared { get; }
      Description: Meters per second squared.
    static ForgeTypeId MetersToTheFourthPower { get; }
      Description: Meters to the fourth power.
    static ForgeTypeId MetersToTheSixthPower { get; }
      Description: Meters to the sixth power.
    static ForgeTypeId MicroinchesPerInchDegreeFahrenheit { get; }
      Description: Microinches per inch degree Fahrenheit.
    static ForgeTypeId MicrometersPerMeterDegreeCelsius { get; }
      Description: Micrometers per meter degree Celsius.
    static ForgeTypeId MilesPerHour { get; }
      Description: Miles per hour.
    static ForgeTypeId MilesPerSecondSquared { get; }
      Description: Miles per second squared.
    static ForgeTypeId Milliamperes { get; }
      Description: Milliamperes.
    static ForgeTypeId Millimeters { get; }
      Description: Millimeters.
    static ForgeTypeId MillimetersOfMercury { get; }
      Description: Millimeters of mercury.
    static ForgeTypeId MillimetersOfWaterColumn { get; }
      Description: Millimeters of water column.
    static ForgeTypeId MillimetersOfWaterColumnPerMeter { get; }
      Description: Millimeters of water column per meter.
    static ForgeTypeId MillimetersToTheFourthPower { get; }
      Description: Millimeters to the fourth power.
    static ForgeTypeId MillimetersToTheSixthPower { get; }
      Description: Millimeters to the sixth power.
    static ForgeTypeId Milliseconds { get; }
      Description: Milliseconds.
    static ForgeTypeId Millivolts { get; }
      Description: Millivolts.
    static ForgeTypeId Minutes { get; }
      Description: Minutes.
    static ForgeTypeId NanogramsPerPascalSecondSquareMeter { get; }
      Description: Nanograms per pascal second square meter.
    static ForgeTypeId NewtonMeters { get; }
      Description: Newton meters.
    static ForgeTypeId NewtonMetersPerMeter { get; }
      Description: Newton meters per meter.
    static ForgeTypeId Newtons { get; }
      Description: Newtons.
    static ForgeTypeId NewtonSecondsPerSquareMeter { get; }
      Description: Newton seconds per square meter.
    static ForgeTypeId NewtonsPerMeter { get; }
      Description: Newtons per meter.
    static ForgeTypeId NewtonsPerSquareMeter { get; }
      Description: Newtons per square meter.
    static ForgeTypeId NewtonsPerSquareMillimeter { get; }
      Description: Newtons per square millimeter.
    static ForgeTypeId OhmMeters { get; }
      Description: Ohm meters.
    static ForgeTypeId OneToRatio { get; }
      Description: 1 : Ratio.
    static ForgeTypeId Pascals { get; }
      Description: Pascals.
    static ForgeTypeId PascalSeconds { get; }
      Description: Pascal seconds.
    static ForgeTypeId PascalsPerMeter { get; }
      Description: Pascals per meter.
    static ForgeTypeId Percentage { get; }
      Description: Percentage.
    static ForgeTypeId PerMille { get; }
      Description: Per mille.
    static ForgeTypeId Pi { get; }
      Description: Multiples of Ãâ‚¬.
    static ForgeTypeId PoundForceFeet { get; }
      Description: Pound force feet.
    static ForgeTypeId PoundForceFeetPerFoot { get; }
      Description: Pound force feet per foot.
    static ForgeTypeId PoundForceSecondsPerSquareFoot { get; }
      Description: Pound force seconds per square foot.
    static ForgeTypeId PoundsForce { get; }
      Description: Pounds force.
    static ForgeTypeId PoundsForcePerCubicFoot { get; }
      Description: Pounds force per cubic foot.
    static ForgeTypeId PoundsForcePerFoot { get; }
      Description: Pounds force per foot.
    static ForgeTypeId PoundsForcePerSquareFoot { get; }
      Description: Pounds force per square foot.
    static ForgeTypeId PoundsForcePerSquareInch { get; }
      Description: Pounds force per square inch.
    static ForgeTypeId PoundsMass { get; }
      Description: Pounds mass.
    static ForgeTypeId PoundsMassPerCubicFoot { get; }
      Description: Pounds mass per cubic foot.
    static ForgeTypeId PoundsMassPerCubicInch { get; }
      Description: Pounds mass per cubic inch.
    static ForgeTypeId PoundsMassPerFoot { get; }
      Description: Pounds mass per foot.
    static ForgeTypeId PoundsMassPerFootHour { get; }
      Description: Pounds mass per foot hour.
    static ForgeTypeId PoundsMassPerFootSecond { get; }
      Description: Pounds mass per foot second.
    static ForgeTypeId PoundsMassPerHour { get; }
      Description: Pounds mass per hour.
    static ForgeTypeId PoundsMassPerMinute { get; }
      Description: Pounds mass per minute.
    static ForgeTypeId PoundsMassPerPoundDegreeFahrenheit { get; }
      Description: Pounds mass per pound degree Fahrenheit.
    static ForgeTypeId PoundsMassPerSecond { get; }
      Description: Pounds mass per second.
    static ForgeTypeId PoundsMassPerSquareFoot { get; }
      Description: Pounds mass per square foot.
    static ForgeTypeId Radians { get; }
      Description: Radians.
    static ForgeTypeId RadiansPerSecond { get; }
      Description: Radians per second.
    static ForgeTypeId Rankine { get; }
      Description: Rankine.
    static ForgeTypeId RankineInterval { get; }
      Description: Rankine interval.
    static ForgeTypeId RatioTo1 { get; }
      Description: Ratio : 1.
    static ForgeTypeId RatioTo10 { get; }
      Description: Ratio : 10.
    static ForgeTypeId RatioTo12 { get; }
      Description: Ratio : 12.
    static ForgeTypeId RevolutionsPerMinute { get; }
      Description: Revolutions per minute.
    static ForgeTypeId RevolutionsPerSecond { get; }
      Description: Revolutions per second.
    static ForgeTypeId RiseDividedBy1000Millimeters { get; }
      Description: Rise / 1000 millimeters.
    static ForgeTypeId RiseDividedBy10Feet { get; }
      Description: Rise / 10 feet.
    static ForgeTypeId RiseDividedBy120Inches { get; }
      Description: Rise / 120 inches.
    static ForgeTypeId RiseDividedBy12Inches { get; }
      Description: Rise / 12 inches.
    static ForgeTypeId RiseDividedBy1Foot { get; }
      Description: Rise / 1 foot.
    static ForgeTypeId Seconds { get; }
      Description: Seconds.
    static ForgeTypeId Shaku { get; }
      Description: Shaku.
    static ForgeTypeId SlopeDegrees { get; }
      Description: Degrees.
    static ForgeTypeId SquareCentimeters { get; }
      Description: Square centimeters.
    static ForgeTypeId SquareCentimetersPerMeter { get; }
      Description: Square centimeters per meter.
    static ForgeTypeId SquareFeet { get; }
      Description: Square feet.
    static ForgeTypeId SquareFeetPer1000BritishThermalUnitsPerHour { get; }
      Description: Square feet per thousand British thermal units per hour.
    static ForgeTypeId SquareFeetPerFoot { get; }
      Description: Square feet per foot.
    static ForgeTypeId SquareFeetPerKip { get; }
      Description: Square feet per kip.
    static ForgeTypeId SquareFeetPerSecond { get; }
      Description: Square feet per second.
    static ForgeTypeId SquareFeetPerTonOfRefrigeration { get; }
      Description: Square feet per ton of refrigeration.
    static ForgeTypeId SquareInches { get; }
      Description: Square inches.
    static ForgeTypeId SquareInchesPerFoot { get; }
      Description: Square inches per foot.
    static ForgeTypeId SquareMeterKelvinsPerWatt { get; }
      Description: Square meter kelvins per watt.
    static ForgeTypeId SquareMeters { get; }
      Description: Square meters.
    static ForgeTypeId SquareMetersPerKilonewton { get; }
      Description: Square meters per kilonewton.
    static ForgeTypeId SquareMetersPerKilowatt { get; }
      Description: Square meters per kilowatt.
    static ForgeTypeId SquareMetersPerMeter { get; }
      Description: Square meters per meter.
    static ForgeTypeId SquareMetersPerSecond { get; }
      Description: Square meters per second.
    static ForgeTypeId SquareMillimeters { get; }
      Description: Square millimeters.
    static ForgeTypeId SquareMillimetersPerMeter { get; }
      Description: Square millimeters per meter.
    static ForgeTypeId StationingFeet { get; }
      Description: Feet.
    static ForgeTypeId StationingMeters { get; }
      Description: Meters.
    static ForgeTypeId StationingSurveyFeet { get; }
      Description: US survey feet.
    static ForgeTypeId Therms { get; }
      Description: Therms.
    static ForgeTypeId ThousandBritishThermalUnitsPerHour { get; }
      Description: Thousand British thermal units per hour.
    static ForgeTypeId TonneForceMeters { get; }
      Description: Tonne force meters.
    static ForgeTypeId TonneForceMetersPerMeter { get; }
      Description: Tonne force meters per meter.
    static ForgeTypeId Tonnes { get; }
      Description: Tonnes.
    static ForgeTypeId TonnesForce { get; }
      Description: Tonnes force.
    static ForgeTypeId TonnesForcePerMeter { get; }
      Description: Tonnes force per meter.
    static ForgeTypeId TonnesForcePerSquareMeter { get; }
      Description: Tonnes force per square meter.
    static ForgeTypeId TonsOfRefrigeration { get; }
      Description: Tons of refrigeration.
    static ForgeTypeId UsGallons { get; }
      Description: US gallons.
    static ForgeTypeId UsGallonsPerHour { get; }
      Description: US gallons per hour.
    static ForgeTypeId UsGallonsPerMinute { get; }
      Description: US gallons per minute.
    static ForgeTypeId UsSurveyFeet { get; }
      Description: US survey feet.
    static ForgeTypeId UsTonnesForce { get; }
      Description: US tonnes force.
    static ForgeTypeId UsTonnesMass { get; }
      Description: US tonnes mass.
    static ForgeTypeId VoltAmperes { get; }
      Description: Volt amperes.
    static ForgeTypeId VoltAmperesPerSquareFoot { get; }
      Description: Volt amperes per square foot.
    static ForgeTypeId VoltAmperesPerSquareMeter { get; }
      Description: Volt amperes per square meter.
    static ForgeTypeId Volts { get; }
      Description: Volts.
    static ForgeTypeId Watts { get; }
      Description: Watts.
    static ForgeTypeId WattsPerCubicFoot { get; }
      Description: Watts per cubic foot.
    static ForgeTypeId WattsPerCubicFootPerMinute { get; }
      Description: Watts per cubic foot per minute.
    static ForgeTypeId WattsPerCubicMeter { get; }
      Description: Watts per cubic meter.
    static ForgeTypeId WattsPerCubicMeterPerSecond { get; }
      Description: Watts per cubic meter per second.
    static ForgeTypeId WattsPerFoot { get; }
      Description: Watts per foot.
    static ForgeTypeId WattsPerMeter { get; }
      Description: Watts per meter.
    static ForgeTypeId WattsPerMeterKelvin { get; }
      Description: Watts per meter kelvin.
    static ForgeTypeId WattsPerSquareFoot { get; }
      Description: Watts per square foot.
    static ForgeTypeId WattsPerSquareMeter { get; }
      Description: Watts per square meter.
    static ForgeTypeId WattsPerSquareMeterKelvin { get; }
      Description: Watts per square meter kelvin.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] UnitUtils
Full Name: Autodesk.Revit.DB.UnitUtils

Description: A utility class of functions related to units.

  METHODS:
    static double Convert(double value, ForgeTypeId currentUnitTypeId, ForgeTypeId desiredUnitTypeId)
      Description: Converts a value from one unit to another, such as square feet to square meters.
      @value: The value to convert.
      @currentUnitTypeId: Identifier of the current unit.
      @desiredUnitTypeId: Identifier of the desired unit.
      Returns: The converted value.
    static double ConvertFromInternalUnits(double value, ForgeTypeId unitTypeId)
      Description: Converts a value from Revit's internal units to a given unit.
      @value: The value to convert.
      @unitTypeId: Identifier of the desired unit.
      Returns: The converted value.
    static double ConvertToInternalUnits(double value, ForgeTypeId unitTypeId)
      Description: Converts a value from a given unit to Revit's internal units.
      @value: The value to convert.
      @unitTypeId: Identifier of the unit quantifying the value.
      Returns: The converted value.
    static IList<ForgeTypeId> GetAllDisciplines()
      Description: Gets the identifiers of all available disciplines.
      Returns: The discipline identifiers.
    static IList<ForgeTypeId> GetAllMeasurableSpecs()
      Description: Gets the identifiers of all available measurable specs.
      Returns: The spec identifiers.
    static IList<ForgeTypeId> GetAllUnits()
      Description: Gets the identifiers of all available units.
      Returns: The unit identifiers.
    static ForgeTypeId GetDiscipline(ForgeTypeId specTypeId)
      Description: Gets the discipline for a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      Returns: Identifier of the discipline.
    static string GetTypeCatalogStringForSpec(ForgeTypeId specTypeId)
      Description: Gets the string used in type catalogs to identify a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      Returns: The type catalog string, or an empty string if the measurable spec cannot be used in type catalogs.
    static string GetTypeCatalogStringForUnit(ForgeTypeId unitTypeId)
      Description: Gets the string used in type catalogs to identify a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: The type catalog string, or an empty string if the unit cannot be used in type catalogs.
    static IList<ForgeTypeId> GetValidUnits(ForgeTypeId specTypeId)
      Description: Gets the identifiers of all valid units for a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      Returns: Identifiers of the valid units.
    static bool IsMeasurableSpec(ForgeTypeId specTypeId)
      Description: Checks whether a ForgeTypeId identifies a spec associated with units of measurement.
      @specTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a measurable spec, false otherwise.
    static bool IsSymbol(ForgeTypeId symbolTypeId)
      Description: Checks whether a ForgeTypeId identifies a symbol.
      @symbolTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a symbol, false otherwise.
    static bool IsUnit(ForgeTypeId unitTypeId)
      Description: Checks whether a ForgeTypeId identifies a unit.
      @unitTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a unit, false otherwise.
    static bool IsValidUnit(ForgeTypeId specTypeId, ForgeTypeId unitTypeId)
      Description: Checks whether a unit is valid for a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      @unitTypeId: Identifier of the unit to check.
      Returns: True if the unit is valid, false otherwise.

--------------------------------------------------------------------------------


[CLASS] UpdaterData
Full Name: Autodesk.Revit.DB.UpdaterData

Description: Service class that is passed to an Updater to prove access to update execution context
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ICollection<ElementId> GetAddedElementIds()
      Description: Returns set of elements newly added to the document. This set is mutually exclusive of elements returned by getDeletedElementIds() and getModifiedElementIds().
      Returns: Set of elements that were added to the document and triggered the call to execute() Note: This will only return elements if the trigger registered for the associated updater contains the ChangeType returned by Element::getChangeTypeElementAddition()
    ICollection<ElementId> GetDeletedElementIds()
      Description: Returns set of elements that were deleted from the document. This set is mutually exclusive of elements returned by getAddedElementIds() and getModifiedElementIds().
      Returns: Set of elements that were deleted from the document and triggered the call to execute() Note: This will only return elements if the trigger registered for the associated updater contains the ChangeType returned by Element::getChangeTypeElementDeletion()
    Document GetDocument()
      Description: Returns document associated with this UpdaterData
    ICollection<ElementId> GetModifiedElementIds()
      Description: Returns set of elements that were modified. This set is mutually exclusive of elements returned by getAddedElementIds() and getDeletedElementIds().
      Returns: Set of elements that were modified in the document and triggered the call to execute() Note: This set only contains modified elements (i.e. it is mutually exclusive of elements returned by getAddedElementIds() and getDeletedElementIds()). It does not contain any elements that were added to or deleted from the document during the current transaction. Newly added/deleted elements will be reported by getAddedElementIds()/getDeletedElementIds(), even if they were also modified during the same transaction, but only if ChangeTypeElementAddition/Deletion is registered as a trigger for the current Updater. I.e. Element creation and modification in the same transaction is considered to be "creation" only. Newly created elements are not considered to be "modified" and are therefore not returned as part of getModifiedElementIds()
    bool IsChangeTriggered(ElementId id, ChangeType type)
      Description: Allows updater to check if specific change has happened to an element. Compares input type to the types that caused Updater::execute() to be triggered. If input type was not registered as a trigger for the associated Updater, this method will always return false for that ChangeType. For example, if the only trigger registered for UpdaterX is ChangeTypeAny for Element A, then passing in ChangeTypeGeometry will return false even if the geometry of A changed because the registered trigger was ChangeTypeAny. However, passing in ChangeTypeAny will return true.
      @id: Id of element to check
      @type: ChangeType to check
      Returns: True if ChangeType happened to specified element

--------------------------------------------------------------------------------


[CLASS] UpdaterId
Full Name: Autodesk.Revit.DB.UpdaterId

Description: A unique identifier of an Updater
Remarks: UpdaterID used as a key to register and unregister Updaters and UpdateTriggers in Revit application
Implements: IDisposable

  CONSTRUCTORS:
    new UpdaterId(AddInId addInId, Guid val)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    AddInId GetAddInId()
      Description: AddInId of the UpdaterId
    Guid GetGUID()
      Description: GUID value of the UpdaterId

--------------------------------------------------------------------------------


[CLASS] UpdaterInfo
Full Name: Autodesk.Revit.DB.UpdaterInfo

Description: Information of an updater, such as: Name, AdditionalInformation, name of the application that owns the updater, etc.
Implements: IDisposable

  PROPERTIES:
    string AdditionalInformation { get; }
      Description: Additional information about the updater.
    string ApplicationName { get; }
      Description: Name of the application that owns the updater.
    bool IsOptional { get; }
      Description: Whether the updater is optional or not.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string UpdaterName { get; }
      Description: Name of the updater.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] UpdaterRegistry
Full Name: Autodesk.Revit.DB.UpdaterRegistry

Description: An object that stores and manages all updaters registered in the current session.
Remarks: The registry is an application-wide singleton. It maintains all dynamic updaters currently registered, and also invokes them per their respective trigger condition during subsequent transactions. Please note that only the application (an add-in, typically) which registered an updater is allowed to modify it later, including unregistering it. Also, an application is not allowed to register an updater with an Id, that is based on another application's Id.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static void AddTrigger(UpdaterId id, ElementFilter filter, ChangeType change)
      Description: Adds trigger with the specified element filter and ChangeType for all documents associated with this Updater
      @id: Id of updater that trigger should be added to
      @filter: Element filter that defines elements that affect this trigger
      @change: ChangeType associated with this trigger
    static void AddTrigger(UpdaterId id, Document document, ElementFilter filter, ChangeType change)
      Description: Adds trigger with the specified element filter and ChangeType for the specified document
      @id: Id of updater that trigger should be added to
      @document: Document that elements in 'elements' are contained in
      @filter: Element filter that defines elements that affect this trigger
      @change: ChangeType associated with this trigger
    static void AddTrigger(UpdaterId id, Document document, ICollection<ElementId> elements, ChangeType change)
      Description: Adds a trigger to an updater with specified set of elements and ChangeType
      @id: Id of updater that trigger should be added to
      @document: Document that elements in 'elements' are contained in
      @elements: Set of elements which define this trigger
      @change: ChangeType associated with this trigger
    static void DisableUpdater(UpdaterId id)
      Description: Disables the updater.
      @id: The updater id.
    void Dispose()
    static void EnableUpdater(UpdaterId id)
      Description: Enables the updater.
      @id: The updater id.
    static bool GetIsUpdaterOptional(UpdaterId id)
      Description: Check if the updater is optional or not.
      @id: Id of the updater to check
      Returns: Returns True if the updater is optional, False otherwise.
    static IList<UpdaterInfo> GetRegisteredUpdaterInfos()
      Description: Returns UpdaterInfos for all the application-wide updaters.
      Returns: List of UpdaterInfo structures
    static IList<UpdaterInfo> GetRegisteredUpdaterInfos(Document document)
      Description: Returns information about all updaters applicable to the given document.
      @document: The document to which sought updaters are applicable to.
      Returns: List of UpdaterInfo structures
    static bool IsUpdaterEnabled(UpdaterId id)
      Description: Checks if the updater is enabled or not.
      @id: The updater id.
      Returns: Returns true if the updater is enabled, false otherwise.
    static bool IsUpdaterRegistered(UpdaterId id, Document document)
      Description: Checks whether updater with the given id is registered in a document.
      @id: Id of the updater being tested.
      @document: Document in which this updater is tested whether it's registered or not.
      Returns: Returns True if the updater is registered in the given document.
    static bool IsUpdaterRegistered(UpdaterId id)
      Description: Checks whether updater with the given id is registered
      @id: Id of the updater being tested.
      Returns: Returns true if the updater is registered.
    static void RegisterUpdater(IUpdater updater, Document document, bool isOptional)
      Description: Registers the updater for a specified document, which means the updater can only be triggered by changes made in that document.
      @updater: Updater to be registered.
      @document: Document for which this updater is to be registered.
      @isOptional: This argument controls whether the updater should be required next time a document is open in which the updater had been previously used. If a non-optional updater is not found (i.e. currently not registered), the end user will be presented with a warning and choices to resolve the situation.
    static void RegisterUpdater(IUpdater updater, bool isOptional)
      Description: Registers an updater application-wide, which means the updater may get triggered in any open document.
      @updater: Updater to be registered
      @isOptional: This argument controls whether the updater should be required next time a document is open in which the updater had been previously used. If a non-optional updater is not found (i.e. currently not registered), the end user will be presented with a warning and choices to resolve the situation.
    static void RegisterUpdater(IUpdater updater, Document document)
      Description: Registers the updater for a specified document, which means the updater can only be triggered by changes made in that document.
      @updater: Updater to be registered
      @document: Document for which this updater is to be registered
    static void RegisterUpdater(IUpdater updater)
      Description: Registers an updater application-wide, which means the updater may get triggered in any open document.
      @updater: Updater to be registered
    static void RemoveAllTriggers(UpdaterId id)
      Description: Removes all triggers associated with Updater with specified UpdaterId. Does not unregister updater.
      @id: Id of specified updater
    static void RemoveDocumentTriggers(UpdaterId id, Document document)
      Description: Removes all triggers associated with specified document and Updater Does not unregister updater.
      @id: Id of specified updater
      @document: Document for which to remove triggers
    static void SetExecutionOrder(UpdaterId first, UpdaterId second)
      Description: Forces execution order between two updaters Execution order: first before second
      @first: Id of first Updater
      @second: Id of second Updater
    static void SetIsUpdaterOptional(UpdaterId id, bool isOptional)
      Description: Sets a flag indicating whether an updater is optional or not.
      @id: Id of the updater
      @isOptional: Use True to make the updater optional, false to make it a mandatory updater.
    static void UnregisterUpdater(UpdaterId id, Document document)
      Description: Unregisters an updater for the given document.
      @id: Id of updater to be unregistered.
      @document: Document for which this updater is to be unregistered.
    static void UnregisterUpdater(UpdaterId id)
      Description: Removes the updater associated with the input id from the UpdaterRegistry. Also removes all triggers associated with the Updater.
      @id: Id of updater to be removed

--------------------------------------------------------------------------------


[CLASS] UV
Full Name: Autodesk.Revit.DB.UV

Description: Object representing coordinates in 2-dimensional space.
Remarks: Usually this means parameters on a surface. In actual use, it could be interpreted as either point or vector in 2-dimensional space.

  CONSTRUCTORS:
    new UV(double u, double v)
    new UV()

  PROPERTIES:
    static UV BasisU { get; }
      Description: The basis of the U axis.
    static UV BasisV { get; }
      Description: The basis of the V axis.
    double Item { get; }
    double U { get; }
      Description: Gets the first coordinate.
    double V { get; }
      Description: Gets the second coordinate.
    static UV Zero { get; }
      Description: The coordinate origin or zero 2-D vector.

  METHODS:
    UV Add(UV source)
      Description: Adds the specified 2-D vector to this 2-D vector and returns the result.
      @source: The vector to add to this vector.
      Returns: The 2-D vector equal to the sum of the two vectors.
    double AngleTo(UV source)
      Description: Returns the angle between this vector and the specified vector.
      @source: The specified vector.
      Returns: The real number between 0 and 2*PI equal to the angle between the two vectors in radians.
    double CrossProduct(UV source)
      Description: The cross product of this 2-D vector and the specified 2-D vector.
      @source: The vector to multiply with this vector.
      Returns: The real number equal to the cross product.
    double DistanceTo(UV source)
      Description: Returns the distance from this 2-D point to the specified 2-D point.
      @source: The specified point.
      Returns: The real number equal to the distance between the two points.
    UV Divide(double value)
      Description: Divides this 2-D vector by the specified value and returns the result.
      @value: The value to divide this vector by.
      Returns: The divided 2-D vector.
    double DotProduct(UV source)
      Description: The dot product of this 2-D vector and the specified 2-D vector.
      @source: The vector to multiply with this vector.
      Returns: The real number equal to the dot product.
    double GetLength()
      Description: The length of this 2-D vector.
    bool IsAlmostEqualTo(UV source, double tolerance)
      Description: Determines whether this 2-D vector and the specified 2-D vector are the same within a specified tolerance.
      @source: The vector to compare with this vector.
      @tolerance: The tolerance for equality check.
      Returns: True if the vectors are the same; otherwise, false.
    bool IsAlmostEqualTo(UV source)
      Description: Determines whether this 2-D vector and the specified 2-D vector are the same within the tolerance (1.0e-09).
      @source: The vector to compare with this vector.
      Returns: True if the vectors are the same; otherwise, false.
    bool IsUnitLength()
      Description: The boolean value indicates whether this 2-D vector is of unit length.
    bool IsZeroLength()
      Description: The boolean value indicates whether this 2-D vector is a zero vector.
    UV Multiply(double value)
      Description: Multiplies this 2-D vector by the specified value and returns the result.
      @value: The value to multiply with this vector.
      Returns: The multiplied 2-D vector.
    UV Negate()
      Description: Negates this 2-D vector.
      Returns: The 2-D vector opposite to this vector.
    UV Normalize()
      Description: Returns a new UV whose coordinates are the normalized values from this vector.
      Returns: The normalized UV or zero if the vector is almost Zero.
    UV Subtract(UV source)
      Description: Subtracts the specified 2-D vector from this 2-D vector and returns the result.
      @source: The vector to subtract from this vector.
      Returns: The 2-D vector equal to the difference between the two vectors.
    string ToString()
      Description: Gets formatted string showing (U, V) with values formatted to 9 decimal places.

--------------------------------------------------------------------------------


[ENUM] UVGridlineType
Full Name: Autodesk.Revit.DB.UVGridlineType

Description: A choice between U-gridlines or V-gridlines of a divided surface U Gridlines V Gridlines
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - U = 0
    - V = 1

