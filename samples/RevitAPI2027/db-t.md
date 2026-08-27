# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

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
      Description: Constructs a new copy of the input TableCellStyle object.
      Throws ArgumentNullException: A non-optional argument was null
    new TableCellStyle()
      Description: Constructs a new TableCellStyle with default settings.

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
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] TableCellStyleOverrideOptions
Full Name: Autodesk.Revit.DB.TableCellStyleOverrideOptions
Description: This helper class represents the overridden characteristics of the associated cell.
Remarks: The user can override the text appearance and cell graphic properties by setting the corresponding flag to true. The global base format will control the non-overridden characteristics.
Implements: IDisposable

  CONSTRUCTORS:
    new TableCellStyleOverrideOptions(TableCellStyleOverrideOptions other)
      Description: Creates a new instance by copying an existing instance.
      @other: The instance to copy
      Throws ArgumentNullException: A non-optional argument was null
    new TableCellStyleOverrideOptions()
      Description: Creates a new instance with no style characteristics overridden.

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
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsEqual(TableData OtherElem)
      Description: Checks if this element is equal in value to the other element.
      Throws ArgumentNullException: A non-optional argument was null
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
      Description: Constructor.
      @top: Row index of the top-left of a table grid.
      @left: Column index of the top-left of a table grid.
      @bottom: Row index of the bottom-right of a table grid.
      @right: Column index of the bottom-right of a table grid.
    new TableMergedCell()
      Description: Default constructor.

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
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
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
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void Dispose()
    TableCellCalculatedValueData GetCellCalculatedValue(int nCol)
      Description: Gets the calculated value for the specified column
      Throws ArgumentException: The given column number nCol is invalid.
    TableCellCalculatedValueData GetCellCalculatedValue(int nRow, int nCol)
      Description: Gets the calculated value for the specified cell
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    ElementId GetCellCategoryId(int nCol)
      Description: Returns a column's ParamId Associated with the paramId to find the correct element
      Throws ArgumentException: The given column number nCol is invalid.
    ElementId GetCellCategoryId(int nRow, int nCol)
      Description: Returns a cell's CategoryId and if no CategoryId exists for this cell, it would come from the column. Associated with the paramId to find the correct element.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    IList<TableCellCombinedParameterData> GetCellCombinedParameters(int nCol)
      Description: Returns an array of combined parameter data for the specified column
      Throws ArgumentException: The given column number nCol is invalid.
    IList<TableCellCombinedParameterData> GetCellCombinedParameters(int nRow, int nCol)
      Description: Returns an array of combined parameter data for the specified cell
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    FormatOptions GetCellFormatOptions(int nCol, Document dcument)
      Description: Returns a column's cell FormatOptions and if no FormatOptions exists for this column, it would come from the section.
      Throws ArgumentException: The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
    FormatOptions GetCellFormatOptions(int nRow, int nCol, Document document)
      Description: Returns a cell's FormatOptions and if no FormatOptions exists for this cell, it would come from the column, or the row, or the section.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId GetCellParamId(int nCol)
      Description: Returns a column's ParamId
      Throws ArgumentException: The given column number nCol is invalid.
    ElementId GetCellParamId(int nRow, int nCol)
      Description: Returns a cell's ParamId and if no ParamId exists for this cell, it would come from the column
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    ForgeTypeId GetCellSpec(int nRow, int nCol)
      Description: Gets the spec describing values of a cell, if applicable.
      @nRow: The row index of the cell
      @nCol: The column index of the cell
      Returns: Identifier of the spec, or empty if the cell does not contain a number with units.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    string GetCellText(int nRow, int nCol)
      Description: Returns the text shown by this cell, if the cell's type is CellType.Text or CellType.ParameterText or CellType.CustomField.
      @nRow: The cell row.
      @nCol: The cell column.
      Returns: The text in the cell, or an empty string if the type if not CellType.Text or CellType.ParameterText or CellType.CustomField.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    CellType GetCellType(int nCol)
      Description: Returns a column's cell type and if no type exists for this column, it would come from the section
      Throws ArgumentException: The given column number nCol is invalid.
    CellType GetCellType(int nRow, int nCol)
      Description: Returns a cell's Type and if no Type exists for this cell, it would come from the column, or the row, or the section
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    double GetColumnWidth(int nCol)
      Description: Returns a column's width in feet
      Throws ArgumentException: The given column number nCol is invalid.
    int GetColumnWidthInPixels(int nCol)
      Description: This returns a column's width in logical pixels
      Throws ArgumentException: The given column number nCol is invalid.
    Guid GetCustomFieldId(int row, int col)
      Description: Gets custom field id from the cell.
      @row: The row of the cell.
      @col: The column of the cell.
      Returns: Returns custom field id from the cell. If this cell is not of type CellType.CustomField it will return an empty Guid
      Throws ArgumentException: The given row number row is invalid. -or- The given column number col is invalid.
    TableMergedCell GetMergedCell(int nRow, int nCol)
      Description: Gets the whole merged cell that this cell is a part of.
      @nRow: The cell row.
      @nCol: The cell column.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    double GetRowHeight(int nRow)
      Description: Returns a row's height in feet
      Throws ArgumentException: The given row number nRow is invalid.
    int GetRowHeightInPixels(int nRow)
      Description: This returns a row's height in logical pixels
      Throws ArgumentException: The given row number nRow is invalid.
    TableCellStyle GetTableCellStyle(int nRow, int nCol)
      Description: Returns a cell's style and if no style exists for this cell, it would come from the column, or the section
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    void InsertColumn(int index)
      Description: Inserts a new column at the specified index relative to the current set of columns.
      @index: An integer index.
      Throws ArgumentException: index is invalid index.
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void InsertImage(int nRow, int nColumn, ElementId imageSymbolId)
      Description: Inserts a image in the given cell.
      @nRow: The given row index.
      @nColumn: The given column index.
      @imageSymbolId: The element id of the image symbol.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nColumn is invalid. -or- The image symbol id doesn't represent a valid image symbol element.
      Throws ArgumentNullException: A non-optional argument was null
    void InsertRow(int nIndex)
      Description: Inserts a row data at a specified index.
      @nIndex: An integer index.
      Throws ArgumentException: The row can't be inserted in data section of standard schedule except Key Schedule, Sheet List Schedule or following categories without emdeded schedule: MEP Space, Room, Area. or nIndex is invalid index.
    bool IsAcceptableParamIdAndCategoryId(int nRow, ElementId paramId, ElementId categoryId)
      Description: Identifies if the given parameter id and category id can be assigned to a cell in the given row in this table.
      @nRow: row index
      Returns: True if the ParamId and CategoryId are all valid.
      Throws ArgumentException: The given row number nRow is invalid.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsAcceptableParamIdAndCategoryId(ElementId paramId, ElementId categoryId)
      Description: Identifies if the given parameter id and category id can be assigned to a cell in this table.
      Returns: True if the ParamId and CategoryId are all acceptable.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsCellFormattable(int nRow, int nCol)
      Description: Determines whether the cell is formattable or not
      @nRow: The row index of the cell
      @nCol: The column index of the cell
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
    bool IsCellOverridden(int nCol)
      Description: Indicates if the column is overridden or not.
      Throws ArgumentException: The given column number nCol is invalid.
    bool IsCellOverridden(int nRow, int nCol)
      Description: Indicates if the cell is overridden or not.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
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
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidRowNumber(int nRow)
      Description: Verifies if the row number is valid.
      @nRow: The row number.
      Returns: True if the row number is between FirstRowNumber and LastRowNumber, false otherwise.
    void MergeCells(TableMergedCell mergedCell)
      Description: Merges cells for the given area.
      Throws ArgumentException: The given TableMergedCell mergedCell is outside of acceptable range.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    bool RefreshData()
      Description: Rebuilds the data in this section if it is out of date.
      Returns: True if the data is up to date after the refresh.
    void RemoveColumn(int nIndex)
      Description: Removes a column data at a specified index.
      @nIndex: An integer index
      Throws ArgumentException: nIndex is invalid index.
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void RemoveRow(int nIndex)
      Description: Removes a row data at a specified index.
      @nIndex: An integer index.
      Throws ArgumentException: The row can't be removed because it's an element in linked file, default zone or it's a row in body section of Material Quantity Take Off Schedule or it's the last row in header section of standard schedule or nIndex is invalid index.
    void ResetCellOverride(int nCol)
      Description: Resets the override of the column.
      Throws ArgumentException: The given column number nCol is invalid.
    void ResetCellOverride(int nRow, int nCol)
      Description: Resets the override of the cell.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- Only allow to override cell style for header section or column header in body section.
    void SetCellCalculatedValue(int nCol, TableCellCalculatedValueData pCalcValue)
      Description: Allows the caller to set the calculated value for a specified column
      Throws ArgumentException: The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule header sections. -or- This operation is forbidden for cells in standard schedule body sections.
    void SetCellCalculatedValue(int nRow, int nCol, TableCellCalculatedValueData pCalcValue)
      Description: Allows the caller to set the calculated value for a specified cell
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule header sections. -or- This operation is forbidden for cells in standard schedule body sections.
    void SetCellCombinedParameters(int nCol, IList<TableCellCombinedParameterData> paramData)
      Description: Allows the caller to set combined parameter for a specified column
      Throws ArgumentException: The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellCombinedParameters(int nRow, int nCol, IList<TableCellCombinedParameterData> paramData)
      Description: Allows the caller to set combined parameter for a specified cell
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellFormatOptions(int nRow, int nCol, FormatOptions options)
      Description: Sets a cell's FormatOptions.
      @nRow: The row index of the cell
      @nCol: The column index of the cell
      @options: The format option to assign
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- The display unit in options is not a valid display unit for the unit type of the cell, or the rounding method in options is not set to Nearest. See UnitUtils.IsValidDisplayUnit(UnitType, DisplayUnitType), UnitUtils.GetValidDisplayUnits(UnitType) and FormatOptions.RoundingMethod.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellParamIdAndCategoryId(int nCol, ElementId paramId, ElementId categoryId)
      Description: Sets a column's category and parameter Id
      Throws ArgumentException: The given column number nCol is invalid. -or- The paramId or categoryId is not acceptable.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void SetCellParamIdAndCategoryId(int nRow, int nCol, ElementId paramId, ElementId categoryId)
      Description: Sets a cell's category and parameter Id
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- The paramId or categoryId is not valid.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellStyle(TableCellStyle Style)
      Description: Sets a section's style
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellStyle(int nCol, TableCellStyle Style)
      Description: Sets a column's style.
      Throws ArgumentException: The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellStyle(int nRow, int nCol, TableCellStyle Style)
      Description: Sets a cell's style
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- Only allow to override cell style for header section or column header in body section.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCellText(int nRow, int nCol, string text)
      Description: Sets a cell's to display the specified text.
      @nRow: The cell row.
      @nCol: The cell column.
      @text: The text to show in the cell.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void SetCellType(int nCol, CellType type)
      Description: Sets a column's cell type
      Throws ArgumentException: A CellType.CustomField can't be set. -or- The given column number nCol is invalid.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void SetCellType(int nRow, int nCol, CellType type)
      Description: Sets a cell's Type
      Throws ArgumentException: A CellType.CustomField can't be set. -or- The given row number nRow is invalid. -or- The given column number nCol is invalid.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void SetColumnWidth(int nCol, double width)
      Description: Sets a column's width in feet
      Throws ArgumentException: The given column number nCol is invalid. -or- The column width is outside of acceptable range.
    void SetColumnWidthInPixels(int nCol, int width)
      Description: This sets a column's width in logical pixels
      Throws ArgumentException: The given column number nCol is invalid. -or- The column width is outside of acceptable range.
    void SetMergedCell(int nRow, int nCol, TableMergedCell mergedCell)
      Description: Sets the merged cell that this cell is a part of.
      @nRow: The cell row.
      @nCol: The cell column.
      Throws ArgumentException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- The given TableMergedCell mergedCell is outside of acceptable range.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void SetRowHeight(int nRow, double height)
      Description: Sets a row's height in feet
      Throws ArgumentException: The given row number nRow is invalid. -or- The row height is outside of acceptable range.
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.
    void SetRowHeightInPixels(int nRow, int height)
      Description: This sets a row's height in logical pixels
      Throws ArgumentException: The given row number nRow is invalid. -or- The row height is outside of acceptable range.
      Throws InvalidOperationException: This operation is forbidden for cells in standard schedule body sections.

--------------------------------------------------------------------------------

[CLASS] TableView
Full Name: Autodesk.Revit.DB.TableView
Description: This represents a view that shows a table. Most of the layout data for the table is contained in the TableData class.
Inherits: View

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
      Throws ArgumentException: The sectionType is not a valid type for this view.
      Throws ArgumentOutOfRangeException: The given row number row is invalid. -or- A value passed for an enumeration argument is not a member of that enumeration
    static IList<ElementId> GetAvailableParameters(Document cda, ElementId categoryId)
      Description: Gets a list of valid parameters for the specified category that can be used in the table view.
      @cda: The document.
      @categoryId: The specified element category id.
      Returns: The IDs of all valid parameters.
      Throws ArgumentNullException: A non-optional argument was null
    string GetCalculatedValueName(SectionType sectionType, int row, int column)
      Description: Gets the calculated value name for a cell from the template view.
      @sectionType: The section type.
      @row: The row.
      @column: The column.
      Returns: The name of the calculated value.
      Throws ArgumentException: The sectionType is not a valid type for this view.
      Throws ArgumentOutOfRangeException: The given row number row is invalid. -or- The given column number column is invalid. -or- A value passed for an enumeration argument is not a member of that enumeration
    string GetCalculatedValueText(SectionType sectionType, int row, int column)
      Description: Gets the calculated value text for a cell from the instance view.
      @sectionType: The section type.
      @row: The row.
      @column: The column.
      Returns: The calculated value text.
      Throws ArgumentException: The sectionType is not a valid type for this view.
      Throws ArgumentOutOfRangeException: The given row number row is invalid. -or- The given column number column is invalid. -or- A value passed for an enumeration argument is not a member of that enumeration
    string GetCellText(SectionType sectionType, int row, int column)
      Description: Gets the cell's text based on its type
      @sectionType: The requested section type
      @row: Row Number in the Section
      @column: Column Number in the Section
      Returns: The text for the given cell
      Throws ArgumentException: The sectionType is not a valid type for this view.
      Throws ArgumentOutOfRangeException: The given row number row is invalid. -or- The given column number column is invalid. -or- A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidSectionType(SectionType sectionType)
      Description: Identifies if the section type is valid for this view.
      @sectionType: The section type.
      Returns: True if the Section Type is valid, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ABSTRACT CLASS] TagByExample
Full Name: Autodesk.Revit.DB.TagByExample
Description: Tag By Example creates new tags by using an example tag as a reference and applying it to target hosts.

  METHODS:
    static bool CanTagBeCreatedOnHost(Document document, View view, ElementId exampleTagId, LinkElementId targetHostId)
      Description: Checks that the example tag can be created on the host.
      @document: The document to which the tag will be added.
      @view: The view in which the example tag are visible and the new tag will be created.
      @exampleTagId: The id of the example tag.
      @targetHostId: The host id to tag. The host may be in a rvt link instance.
      Returns: True if the example tag can be created on the host, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static ElementId CreateTagByExample(Document document, View view, ElementId exampleTagId, LinkElementId targetHost, TagByExampleOptions options)
      Description: Create a new tag according to an example tag and a target host.
      @document: The document which owns the example tag and view.
      @view: The view in which the example tag is visible and the new tag will be created.
      @exampleTagId: The id of the example tag to recreate.
      @targetHost: The id of the target host to tag. The host may be in a rvt link instance.
      @options: The creation options which control the placement of the new tag.
      Returns: The id of the new tag.
      Throws ArgumentException: The view is not allowed for Tag By Example. -or- The example tag cannot be created on the host.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAllowedTag(Document document, ElementId tagId)
      Description: Checks if the tag is allowed as an example tag.
      @document: The document what owns the tag.
      @tagId: The id of the tag to check.
      Returns: True if the tag is allowed as an example tag, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsAllowedView(View view)
      Description: Checks if the view is allowed.
      @view: View to check.
      Returns: True if the view is allowed, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] TagByExampleOptions
Full Name: Autodesk.Revit.DB.TagByExampleOptions
Description: Options for Tag by Example
Implements: IDisposable

  CONSTRUCTORS:
    new TagByExampleOptions(bool matchTagOrientation, bool matchHostFlipMirror, bool matchHostRotation)
      Description: Constructor for TagByExampleOptions.
      @matchTagOrientation: The value for MatchTagOrientation.
      @matchHostFlipMirror: The value for MatchHostFlipMirror.
      @matchHostRotation: The value for MatchHostRotation.
    new TagByExampleOptions()
      Description: Constructor for TagByExampleOptions.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool MatchHostFlipMirror { get; set; }
      Description: If true, the new tag is flipped and mirrored to respect the differences in flip and mirror between the example host and target host. If false, the new tag ignores differences in flip and mirror between the example host and target host.
    bool MatchHostRotation { get; set; }
      Description: If true, the new tag is rotated to respect the differences in rotation between the example host and target host. If false, the new tag ignores differences in rotation between the example host and target host.
    bool MatchTagOrientation { get; set; }
      Description: If true, the new tags use the same orientation parameter value as the example tag, even if the example and target hosts are rotated with respect to one another. If false, the tag head keeps the same orientation relative to the target host.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] TagHeadAlignment
Full Name: Autodesk.Revit.DB.TagHeadAlignment
Description: An enumerated type listing the tag-head alignment options supported by the Bending Detail.
Inherits: Enum

  Values:
    - RebarShapeFamily = 0
    - View = 1

--------------------------------------------------------------------------------

[ENUM] TagHeadPositionOptions
Full Name: Autodesk.Revit.DB.TagHeadPositionOptions
Description: An enumerated type listing the tag-head position options supported by the Bending Detail.
Inherits: Enum

  Values:
    - Top = 0
    - Bottom = 1
    - Right = 2
    - Left = 3
    - Center = 4

--------------------------------------------------------------------------------

[ENUM] TagMode
Full Name: Autodesk.Revit.DB.TagMode
Description: The modes of tag creation that are supported for IndependentTags.
Inherits: Enum

  Values:
    - TM_ADDBY_CATEGORY = 0
    - TM_ADDBY_MULTICATEGORY = 1
    - TM_ADDBY_MATERIAL = 2

--------------------------------------------------------------------------------

[ENUM] TagOrientation
Full Name: Autodesk.Revit.DB.TagOrientation
Description: An enumerated type listing tag orientation options that are supported by IndependentTags.
Inherits: Enum

  Values:
    - Horizontal = 0
    - Vertical = 1
    - AnyModelDirection = 2

--------------------------------------------------------------------------------

[ENUM] TagOrientationBehavior
Full Name: Autodesk.Revit.DB.TagOrientationBehavior
Description: This attribute describes the family orientation behavior.
Inherits: Enum

  Values:
    - Fixed = 0
    - RotateWithHost = 1
    - RotateAndStayUpright = 2

--------------------------------------------------------------------------------

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
      Throws ArgumentException: The ownerViewId provided is not an id of a view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to load the image from specified path.
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
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveControl(int index)
      Description: Deletes the existing control identified by the unique index.
      @index: Unique index of the control to be deleted.
      Throws ArgumentException: index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.
    void SetTooltip(int index, string tooltip)
      Description: Sets the tooltip for the temporary graphics object.
      @index: Unique index of the temporary graphics object to be updated.
      @tooltip: Tooltip to be set.
      Throws ArgumentException: index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.
      Throws ArgumentNullException: A non-optional argument was null
    void SetVisibility(int index, bool visible)
      Description: Changes the visibility of temporary graphics object.
      @index: Unique index of the temporary graphics object to be updated.
      @visible: if true, it will make the temporary graphics object visible. if false, it will make the temporary graphics object invisible.
      Throws ArgumentException: index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.
    void UpdateControl(int index, InCanvasControlData data)
      Description: Updates the in-canvas control identified by the unique index.
      @index: Unique index of the control to be updated.
      @data: data to generate in-canvas control appearance.
      Throws ArgumentException: index is out of range of TemporaryGraphicsManager managed objects, or the indexed object has been removed from the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to load the image from specified path.

--------------------------------------------------------------------------------

[ENUM] TemporaryViewMode
Full Name: Autodesk.Revit.DB.TemporaryViewMode
Description: Enumeration to represent the various temporary view modes a view can be in.
Inherits: Enum

  Values:
    - RevealHiddenElements = 1
    - TemporaryHideIsolate = 2
    - WorksharingDisplay = 3
    - TemporaryViewProperties = 4
    - ExplodedView = 6
    - RevealConstraints = 7
    - PreviewFamilyVisibility = 8
    - AcceleratedGraphicsMode = 9

--------------------------------------------------------------------------------

[CLASS] TemporaryViewModes
Full Name: Autodesk.Revit.DB.TemporaryViewModes
Description: A data structure containing data related to temporary view modes.
Remarks: The class contains methods and properties to manipulate states of various temporary view modes that may or may not be avilable in any of visible views of a Revit document. The temporary modes are enumerated in the TemporaryViewMode class.Every view that supports temporary view modes owns an instance of this TemporaryViewModes class, which can be obtained by accessing the TemporaryViewModes property of the View class. Note that views which do not support temporary modes will have that property's value be Null.Multiple temporary view modes can coexist. Also, TemporaryViewProperties mode can be customized to display custom title and custom color. Setting custom title and color affects only TemporaryViewProperties mode for the specific view. CustomTitleCustomColorIsCustomizedRemoveCustomization
Inherits: APIObject

  PROPERTIES:
    bool AcceleratedGraphicsMode { get; set; }
      Description: The current state of the Accelerated Graphics mode in the associated view.
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
      Throws ArgumentException: The temporary mode is not available in the associated view. The view is either of a type that does not support this mode, or is currently in a context that makes the mode presently inapplicable. -or- The temporary mode is presently not enabled in the associated view.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    string GetCaption(TemporaryViewMode mode)
      Description: A text caption to use for the given mode.
      @mode: The mode to get a caption for.
      Returns: Text of the caption. The text is localized.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsCustomized()
      Description: Identifies if a custom temporary view mode is currently active. A custom mode is active if there is a non-empty string set for CustomTitle.
      Returns: Returns true a custom temporary view mode is currently active, false otherwise. A custom mode is active if there is a non-empty string set for CustomTitle.
    bool IsModeActive(TemporaryViewMode mode)
      Description: Tests whether a given mode is currently active or not.
      @mode: The mode being tested
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsModeAvailable(TemporaryViewMode mode)
      Description: Tests whether a temporary view mode is currently available in the associated view.
      @mode: The mode to evaluate
      Returns: True of the temporary mode is currently available in the associated view.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsModeEnabled(TemporaryViewMode mode)
      Description: Tests whether a temporary view mode is currently enabled in the associated view.
      @mode: The mode to evaluate
      Returns: True if the requested mode is available and enabled in the associated view; False otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsValidState(PreviewFamilyVisibilityMode state)
      Description: Tests whether the given state is valid for the associated view and the context the view is currently in.
      @state: A state of the PreviewFamilyVisibilityMode
      Returns: Returns True if the state is applicable for the view; False otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
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

--------------------------------------------------------------------------------

[CLASS] TessellatedFace
Full Name: Autodesk.Revit.DB.TessellatedFace
Description: Defines a planar face bounded by a polyline in 3d space. A face consists of a single connected component and can have holes.
Implements: IDisposable

  CONSTRUCTORS:
    new TessellatedFace(IList<IList<XYZ>> allLoopVertices, ElementId materialId)
      Description: Constructs a tessellated face, which, may be, have holes. Face data is always set, even if the input data are invalid (e.g., describes a wildly non-planar face). A TessellatedShepeBuilder's function is used to check the data and heal them if possible.
      @allLoopVertices: Boundary vertices without duplication of the ends - i.e., a boundary of a triangular face consists of 3 (and NOT 4) vertices. The first array describes the outer loop, the following arrays, if any - inner loops. It is expected that vertices of outer boundary are listed in CCW order with respect to the face normal in the solid, while the vertices of inner loops - in CW order. The vertices listed in the wrong order will still be handled by TessellatedShapeBuilder, but performance may deteriorate. Contents of this parameter will be changed while constructing the face.
      @materialId: Material of the face to be used when the result is a Solid or a Sheet. If the result is a Mesh, a material will be assigned to the entire Mesh.
      Throws ArgumentNullException: A non-optional argument was null
    new TessellatedFace(IList<XYZ> outerLoopVertices, ElementId materialId)
      Description: Constructs a tessellated face without holes. Face data is always set, even if the input data are invalid (e.g., describes a wildly non-planar face). A TessellatedShepeBuilder's function is used to check the data and heal them if possible.
      @outerLoopVertices: Boundary vertices without duplication of the ends - i.e., a boundary of a triangular face consists of 3 (and NOT 4) vertices. It is expected that boundaries are in CCW order with respect to the face normal in the solid. Boundaries in CW order will still be handled by TessellatedShapeBuilder, but performance may deteriorate. Contents of this parameter will be changed while constructing the face.
      @materialId: Material of the face to be used when the result is a Solid or a Sheet. If the result is a Mesh, a material will be assigned to the entire Mesh.
      Throws ArgumentNullException: A non-optional argument was null

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
Remarks: Creates a geometry populated with faces defined by TessellatedFace objects stored in the input connected face sets. The faces defined by each connected face set may form an open shell or the boundary of a solid 3D region. All faces are planar and have polyline boundaries, defined as sequences of 3d coordinates. Faces are added to the builder as a part of connected face sets, representing faces which share edges. Order of faces in the sets is irrelevant. Faces can only be added to the builder when a face set has been opened and is available to take in faces (use Boolean) to open a new face set). Before attempting to build Revit geometry from the builder the current face set should be closed (CloseConnectedFaceSet). The builder allows for the possibility of multiple face sets. The builder will try to create a geometry valid in Revit despite inconsistencies or omissions in the input data. For each connected face set, it will check the face orientations and change them wherever needed so that the orientations of the faces in that set are consistent.If a connected face set is closed, it will check if the face normals point outward. If not, it will reverse the orientations of all faces. That means, each closed connected face set will represent a solid. Limitations in the current implementation: It does not support the definition of a "void", even if the user had set the orientations of the faces to define a "void".If there is more than one connected face set, it does not check if they intersect or overlap each other.
Inherits: ShapeBuilder

  CONSTRUCTORS:
    new TessellatedShapeBuilder()
      Description: Constructs a new instance of a TessellatedShapeBuilder.

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
      Throws ArgumentException: The 'face' does not have enough loops and/or vertices to be valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: A face set is closed and faces cannot be added to it.
    bool AreTargetAndFallbackCompatible(TessellatedShapeBuilderTarget target, TessellatedShapeBuilderFallback fallback)
      Description: Checks whether this combination of fallback and target parameters can be used as a valid combination of inputs.
      @target: What kind of geometrical objects should be built.
      @fallback: What should be done if a geometrical object described by 'target' parameter cannot be built using all data from all stored face sets.
      Returns: True if the combination of fallback and target are a valid combination, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void Build()
      Description: Builds the designated geometrical objects from the stored face sets. Stores the result in this TessellatedShapeBuilder object.
      Throws InvalidOperationException: Throws if data in the stored face sets are so inconsistent, that they cannot be used in their entirety, or if an attempt is made to create unacceptable geometry with too many facets.
    void CancelConnectedFaceSet()
      Description: Cancels the current face set - i.e., all data from it will be lost and the builder will have no open connected face set anymore.
    void Clear()
      Description: Erases all face set and clears the logs, if any.
    void CloseConnectedFaceSet()
      Description: Closes the currently open connected face set.
      Throws InvalidOperationException: A face set is empty and cannot be closed until some faces are added.
    static MeshFromGeometryOperationResult CreateMeshByExtrusion(IList<CurveLoop> profileLoops, XYZ extrusionDirection, double extrusionDistance, ElementId materialId)
      Description: Builds a mesh by extruding curve loop(s) along extrusion distance.
      @profileLoops: The profile loops to be extruded. The loops will not be modified.
      @extrusionDirection: Direction of extrusion. The length of this vector is ignored.
      @extrusionDistance: The positive distance by which the loops are extruded in the direction of the input extrusionDir.
      @materialId: Material which should be used by a constructed mesh.
      Returns: Returns a mesh, which was constructed, and some additional information.
      Throws ArgumentException: The input value cannot be used as thickness for an extrusion, or blend, or wall layer, or similar geometric construct.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: extrusionDirection has zero length.
    bool DoesFaceHaveEnoughLoopsAndVertices(TessellatedFace face)
      Description: Checks whether 'face' has enough loops and vertcies to be valid.
      @face: The face to check.
      Throws ArgumentNullException: A non-optional argument was null
    TessellatedShapeBuilderResult GetBuildResult()
      Description: Get the built geometry, build status and other data stored in TessellatedShapeBuilderResult. Clears the stored data.
    void OpenConnectedFaceSet(bool isSolid)
      Description: Opens a new connected face set.
      @isSolid: Whether the face set, which is being open, should be build as a solid or as a void.
      Throws InvalidOperationException: A face set is open and a geometry cannot be build until it is closed.

--------------------------------------------------------------------------------

[ENUM] TessellatedShapeBuilderFallback
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderFallback
Description: Describes what TessellatedShapeBuilder function should do, if it cannot build a requested TessellatedShapeBuilderTarget.
Inherits: Enum

  Values:
    - Abort = 0
    - Salvage = 1
    - Mesh = 2

--------------------------------------------------------------------------------

[ENUM] TessellatedShapeBuilderOutcome
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderOutcome
Description: Describes the outcome of TessellatedShapeBuilder attempt to build geometrical objects.
Inherits: Enum

  Values:
    - Mesh = 1
    - Mixed = 2
    - Nothing = 3
    - Solid = 4
    - Sheet = 5

--------------------------------------------------------------------------------

[CLASS] TessellatedShapeBuilderResult
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderResult
Description: Describes what TessellatedShapeBuilder has construct.
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
      Throws ArgumentException: 'SetIndex' is a valid face set index for the results stored in 'this'.
    int GetNumberOfFaceSets()
      Description: Gets number of face sets for which 'this' result was obtained.
      Returns: The number of face sets.

--------------------------------------------------------------------------------

[ENUM] TessellatedShapeBuilderTarget
Full Name: Autodesk.Revit.DB.TessellatedShapeBuilderTarget
Description: Describes what TessellatedShapeBuilder should generate, if possible.
Inherits: Enum

  Values:
    - Solid = 0
    - AnyGeometry = 1
    - Mesh = 2

--------------------------------------------------------------------------------

[ENUM] TextAlignFlags
Full Name: Autodesk.Revit.DB.TextAlignFlags
Description: An enumerated type listing all the Text align flags.
Inherits: Enum

  Values:
    - TEF_ALIGN_LEFT = 64
    - TEF_ALIGN_CENTER = 128
    - TEF_ALIGN_RIGHT = 256
    - TEF_ALIGN_TOP = 512
    - TEF_ALIGN_MIDDLE = 1024
    - TEF_ALIGN_BOTTOM = 2048

--------------------------------------------------------------------------------

[ENUM] TextAlignMask
Full Name: Autodesk.Revit.DB.TextAlignMask
Description: An enumerated type listing all the Text align mask.
Inherits: Enum

  Values:
    - horzAlignMask = 448
    - vertAlignMask = 3584

--------------------------------------------------------------------------------

[ENUM] TextBaselineStyle
Full Name: Autodesk.Revit.DB.TextBaselineStyle
Description: Supported styles of text position relative to the normal baseline.
Inherits: Enum

  Values:
    - Normal = 0
    - Subscript = 1
    - Superscript = 2

--------------------------------------------------------------------------------

[CLASS] TextElement
Full Name: Autodesk.Revit.DB.TextElement
Description: Base class representing text elements in Revit.
Remarks: TextElement is a base class for other annotation classes, like TextNote, which have additional, more specific functionality.
Inherits: Element

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
      Description: A flag identifying whether text-wrapping is currently active in this text element or not.If text wrapping is active the width of the text box remains constant and the text will wrap. The height of the text box will automatically adjust to accomodate the height of the text.If text wrapping is not active the text does not wrap and the width of the text box adjusts with the width of the longest line of text. As the text width changes, the position of the text may change depending on the HorizontalAlignment
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
      Throws ArgumentNullException: A non-optional argument was null
    double GetMaximumAllowedWidth()
      Description: Returns the maximum width the text element can be assigned.
      Returns: The maximum allowed width in paper space [ft].
    static double GetMinimumAllowedWidth(Document cdda, ElementId typeId)
      Description: Returns the minimum width a text element can be created with.
      @cdda: A document containing the new text element's type
      @typeId: Id of the text type
      Returns: The minimum allowed width in paper space [ft].
      Throws ArgumentNullException: A non-optional argument was null
    double GetMinimumAllowedWidth()
      Description: Returns the minimum width the text element can be assigned.
      Returns: The minimum allowed width in paper space [ft].

--------------------------------------------------------------------------------

[ENUM] TextElementBackground
Full Name: Autodesk.Revit.DB.TextElementBackground
Description: An enumerated type listing all the background mode for the built-in parameter TEXT_BACKGROUND.
Inherits: Enum

  Values:
    - TBGR_OPAQUE = 0
    - TBGR_TRANSPARENT = 1

--------------------------------------------------------------------------------

[CLASS] TextElementType
Full Name: Autodesk.Revit.DB.TextElementType
Description: An object that represents a text style.
Inherits: LineAndTextAttrSymbol

--------------------------------------------------------------------------------

[ENUM] TextListStyle
Full Name: Autodesk.Revit.DB.TextListStyle
Description: Supported styles of text list paragraphs.
Inherits: Enum

  Values:
    - None = 0
    - Bullet = 1
    - NumberArabic = 2
    - LetterLowercase = 3
    - LetterUppercase = 4
    - NumberRomanLowercase = 5
    - NumberRomanUppercase = 6

--------------------------------------------------------------------------------

[CLASS] TextNode
Full Name: Autodesk.Revit.DB.TextNode
Description: This class represents a text annotation object in a model-exporting process.
Remarks: See also: Autodesk::Revit::DB::IModelExportContext::OnText.
Inherits: RenderNode

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
      Description: Returns an FormattedText object that contains text and associated formatting of this TextNode.
      Returns: The object that contains the text and associated formatting of of the text in this text note.

--------------------------------------------------------------------------------

[CLASS] TextNote
Full Name: Autodesk.Revit.DB.TextNote
Description: A class representing text note annotations in Revit.
Inherits: TextElement

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
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static TextNote Create(Document document, ElementId viewId, XYZ position, double width, string text, TextNoteOptions options)
      Description: Creates a new line-wrapping text note element of the given width and properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. Note that the position's relation to the text's bounding box depends on the requested text alignment (set via the Options argument). It will be the box' top-left corner for a left-aligned text, the top-right corner for a right-aligned text, and middle-top point if the text is to be centered.
      @width: Width [ft] of the text in paper space (i.e. as it is measured when printed.) If a line of text is longer than the given specified Width, the text will be automatically wrapped. If a a zero Width is supplied then this method will create an unwrapped text note element.
      @text: Text to populate the text note with.
      @options: Options to control behavior and appearance of the text note.
      Returns: The newly created text note.
      Throws ArgumentException: The document is a family that cannot contain text notes or annotation labels. -or- The viewId does not represent a valid graphic view element in the given document. -or- The options structure does not contain a valid text type to use for a new text note in the given document. -or- A valid point must not be father then 10 miles (approx. 16 km) from the origin. -or- The given width is not valid. A valid value must be within the range returned by static methods GetMinimumWidthLimit and GetMaximumWidthLimit.
      Throws ArgumentNullException: A non-optional argument was null
    static TextNote Create(Document document, ElementId viewId, XYZ position, double width, string text, ElementId typeId)
      Description: Creates a new line-wrapping text note element of the given width and properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. For a left-aligned text (default), the origin is set at the top-left corner of the note's bounding box.
      @width: Width [ft] of the text in paper space (i.e. as it is measured when printed.) If a line of text is longer than the specified Width, the text will be automatically wrapped. If a a zero Width is supplied then this method will create an unwrapped text note element.
      @text: Text to populate the text note with.
      @typeId: Id of the text type to use for the new text note. The text type allows its font name parameter to be set to a font unavailable on the current system. However, any text note created with or set to this font type will be displayed in a default substituted font (e.g. Arial) and the UI will show a blank value in the text type font name parameter. Once the document is opened on a system which has the font set on the text type, the text note will display with that font and the UI will show that font in the text type font name parameter.
      Returns: The newly created text note.
      Throws ArgumentException: The document is a family that cannot contain text notes or annotation labels. -or- The viewId does not represent a valid graphic view element in the given document. -or- The typeId does not represent a valid text type in the given document. -or- A valid point must not be father then 10 miles (approx. 16 km) from the origin. -or- The given width is not valid. A valid value must be within the range returned by the static methods GetMinimumAllowedWidth and GetMaximumAllowedWidth.
      Throws ArgumentNullException: A non-optional argument was null
    static TextNote Create(Document document, ElementId viewId, XYZ position, string text, TextNoteOptions options)
      Description: Creates a new unwrapped text note element with the given properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. Note that the position's relation to the text's bounding box depends on the requested text alignment (set via the Options argument). It will be the box' top-left corner for a left-aligned text, the top-right corner for a right-aligned text, and middle-top point if the text is to be centered.
      @text: Text to populate the text note with.
      @options: Options to control behavior and appearance of the text note.
      Returns: The newly created text note.
      Throws ArgumentException: The document is a family that cannot contain text notes or annotation labels. -or- The viewId does not represent a valid graphic view element in the given document. -or- The options structure does not contain a valid text type to use for a new text note in the given document. -or- A valid point must not be father then 10 miles (approx. 16 km) from the origin.
      Throws ArgumentNullException: A non-optional argument was null
    static TextNote Create(Document document, ElementId viewId, XYZ position, string text, ElementId typeId)
      Description: Creates a new unwrapped TextNote element with the given properties.
      @document: A valid Revit document that is currently modifiable (i.e. with an open transaction).
      @viewId: Id of the graphic view in which the note is to be created.
      @position: A model position of the new note. For a left-aligned text (default), the origin is set at the top-left corner of the note's bounding box.
      @text: Text to populate the text note with.
      @typeId: Id of the text type to use for the new text note.
      Returns: The newly created text note.
      Throws ArgumentException: The document is a family that cannot contain text notes or annotation labels. -or- The viewId does not represent a valid graphic view element in the given document. -or- The typeId does not represent a valid text type in the given document. -or- A valid point must not be father then 10 miles (approx. 16 km) from the origin.
      Throws ArgumentNullException: A non-optional argument was null
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
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] TextNoteLeaderStyles
Full Name: Autodesk.Revit.DB.TextNoteLeaderStyles
Description: An enumerated type listing all the Leader styles.
Inherits: Enum

  Values:
    - LCS_NONE = 0
    - LCS_ONE_SEG_LINE = 1
    - LCS_ONE_SEG_ARC = 2
    - LCS_TWO_SEG_LINE = 3

--------------------------------------------------------------------------------

[ENUM] TextNoteLeaderTypes
Full Name: Autodesk.Revit.DB.TextNoteLeaderTypes
Description: Types of text-note leaders
Inherits: Enum

  Values:
    - TNLT_STRAIGHT_L = 0
    - TNLT_STRAIGHT_R = 1
    - TNLT_ARC_L = 2
    - TNLT_ARC_R = 3

--------------------------------------------------------------------------------

[CLASS] TextNoteOptions
Full Name: Autodesk.Revit.DB.TextNoteOptions
Description: Options to use when creating a new text note element.
Remarks: Use an instance of this class as an argument in the TextNote.Create methods.
Implements: IDisposable

  CONSTRUCTORS:
    new TextNoteOptions(ElementId typeId)
      Description: Constructs text options to create text of the given type.
      @typeId: Id of a text type that defines the style of a text note.
      Throws ArgumentNullException: A non-optional argument was null
    new TextNoteOptions()
      Description: Default constructor; populates the options with their respective default values.

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

--------------------------------------------------------------------------------

[CLASS] TextRange
Full Name: Autodesk.Revit.DB.TextRange
Description: An object that is used to identify a range of characters in a FormattedText.
Remarks: A TextRange consists of a start, which is a zero-based index into the text, and a length, which is the number of characters in the range. The length can be zero.
Implements: IDisposable

  CONSTRUCTORS:
    new TextRange(int start, int length)
      Description: Constructs a TextRange with input start and length.
      Throws ArgumentOutOfRangeException: The given value for start is negative. -or- The given value for length is negative.
    new TextRange()
      Description: Constructs a TextRange with default values for start and length.
    new TextRange(TextRange other)
      Description: Constructs a copy of the input TextRange object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    int End { get; }
      Description: The index of the first character after the end of the range
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Length { get; set; }
      Description: The length of the range.
    int Start { get; set; }
      Description: The start index of a range within the FormattedText.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] TextTreatment
Full Name: Autodesk.Revit.DB.TextTreatment
Description: An enumerated type listing possible text treatment modes.
Inherits: Enum

  Values:
    - Exact = 0
    - Approximate = 1

--------------------------------------------------------------------------------

[CLASS] ThermalAsset
Full Name: Autodesk.Revit.DB.ThermalAsset
Description: Represents the properties of a material pertinent to energy analysis.
Implements: IDisposable

  CONSTRUCTORS:
    new ThermalAsset(string name, ThermalMaterialType materialType)
      Description: Constructs an instance of ThermalAsset.
      @name: The name of the asset.
      @materialType: The type of thermal material that this asset will describe.
      Throws ArgumentException: name is an empty string. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

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
      Throws ArgumentNullException: A non-optional argument was null
    bool EqualsThermalOnly(ThermalAsset other)
      Description: Determines whether this thermal asset is equal to another, but ignore data from base class.
      @other: The thermal asset to compare with this one.
      Returns: True if the given thermal asset is equal to this one, otherwise false.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ThermalMaterialType
Full Name: Autodesk.Revit.DB.ThermalMaterialType
Description: Represents the thermal material type.
Inherits: Enum

  Values:
    - Undefined = 0
    - Gas = 1
    - Liquid = 2
    - Solid = 3

--------------------------------------------------------------------------------

[CLASS] ThermalProperties
Full Name: Autodesk.Revit.DB.ThermalProperties
Description: Class specific to thermal properties for assembly types, such as Wall, Floor, Ceiling, Roof and Building Pad.
Inherits: APIObject

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
    double ThermalTransmittance { get; }
      Description: The thermal transmittance value (U-Value). The unit is watts per meter-squared kelvin (W/(m^2*K)).

--------------------------------------------------------------------------------

[CLASS] TilePattern
Full Name: Autodesk.Revit.DB.TilePattern
Description: An object representing a tile pattern that may be applied to a DividedSurface.
Remarks: TilePatterns cannot be created. A fixed selection is built into each Conceptual Mass family. TilePatterns can be retrieved by key from the Revit::DB::Document::Settings::TilePatternTable object.
Inherits: ElementType

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

  METHODS:
    TilePattern GetTilePattern(TilePatternsBuiltIn tilePatternBuiltIn)
      Description: Retrieve a TilePattern object from a built-in type.
      Returns: A TilePattern object, or if the document is not a Massing Family.

--------------------------------------------------------------------------------

[ENUM] TilePatternsBuiltIn
Full Name: Autodesk.Revit.DB.TilePatternsBuiltIn
Description: Revit's built-in tile patterns. See TilePattern.
Inherits: Enum

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

--------------------------------------------------------------------------------

[CLASS] Toposolid
Full Name: Autodesk.Revit.DB.Toposolid
Description: An object that represents a Toposolid within the Autodesk Revit project.
Inherits: CeilingAndFloor

  PROPERTIES:
    ElementId HostTopoId { get; }
      Description: The host Toposolid id of the current Toposolid subdivision. If the object is not a Toposolid subdivision, hostTopoId will be InvalidElementId.
    ElementId SketchId { get; }
      Description: Returns id of the sketch.

  METHODS:
    bool CanBeExcavatedBy(ElementId elementId)
      Description: Checks if the given element can be used to excavate the Toposolid.
      @elementId: Id of the element
      Returns: True if the element can be used to excavate the Toposolid.
      Throws ArgumentNullException: A non-optional argument was null
    static Toposolid Create(Document document, IList<CurveLoop> profiles, IList<XYZ> points, ElementId topoTypeId, ElementId levelId)
      Description: Creates a new instance of Toposolid within the project.
      @document: The document in which the new Toposolid is created.
      @profiles: An array of planar curve loops that represent the profiles of the Toposolid.
      @points: An array of points that used to construct the top face of the Toposolid.
      @topoTypeId: Id of the Toposolid type to be used by the new Toposolid.
      @levelId: Id of the level on which the Toposolid is to be placed.
      Returns: A new Toposolid object within the project if successful.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: the "curveLoops" collection is empty; or some curve loops intersect with each other; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane; or input curves contain at least one helical curve. -or- The ElementId levelId is not a Level. -or- Toposolid type is not valid for this Toposolid. -or- Input curves build invalid sketch. -or- Failed to create curve elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot generate a sketch. -or- Failed to create new element.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Toposolid Create(Document document, IList<XYZ> points, ElementId topoTypeId, ElementId levelId)
      Description: Creates a new instance of Toposolid within the project.
      @document: The document in which the new Toposolid is created.
      @points: An array of points that used to construct the top face of the Toposolid.
      @topoTypeId: Id of the Toposolid type to be used by the new Toposolid.
      @levelId: Id of the level on which the Toposolid is to be placed.
      Returns: A new Toposolid object within the project if successful.
      Throws ArgumentException: The input point array size is less than 3. -or- The ElementId levelId is not a Level. -or- Toposolid type is not valid for this Toposolid. -or- Input curves build invalid sketch. -or- Failed to create curve elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot generate a sketch. -or- Failed to create new element.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Toposolid Create(Document document, IList<CurveLoop> profiles, ElementId topoTypeId, ElementId levelId)
      Description: Creates a new instance of Toposolid within the project.
      @document: The document in which the new Toposolid is created.
      @profiles: An array of planar curve loops that represent the profiles of the Toposolid.
      @topoTypeId: Id of the Toposolid type to be used by the new Toposolid.
      @levelId: Id of the level on which the Toposolid is to be placed.
      Returns: A new Toposolid object within the project if successful.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: the "curveLoops" collection is empty; or some curve loops intersect with each other; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane; or input curves contain at least one helical curve. -or- The ElementId levelId is not a Level. -or- Toposolid type is not valid for this Toposolid. -or- Input curves build invalid sketch. -or- Failed to create curve elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot generate a sketch. -or- Failed to create new element.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Toposolid CreateFromTopographySurface(Document document, ElementId hostSurfaceId, ElementId topoTypeId, ElementId levelId)
      Description: Creates a Toposolid element from a host TopographySurface, and Toposolid sub-divisions from its subregions.
      @document: The document in which the new Toposolid is created.
      @hostSurfaceId: Id of the host TopogarphySurface element.
      @topoTypeId: Id of the Toposolid type to be used by the new Toposolid.
      @levelId: Id of the level on which the Toposolid is to be placed.
      Returns: A new Toposolid object within the project if successful.
      Throws ArgumentNullException: A non-optional argument was null
    Toposolid CreateSubDivision(Document document, ElementId topoTypeId, IList<CurveLoop> profiles)
      Description: Creates a Toposolid subdivision element with the current Toposolid as its host.
      @document: The document in which the new Toposolid is created.
      @topoTypeId: Id of the Toposolid type to be used by the new subdivision.
      @profiles: An array of planar curve loops that represent the profiles of the Toposolid.
      Returns: The Toposolid subdivision object.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: the "curveLoops" collection is empty; or some curve loops intersect with each other; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane; or input curves contain at least one helical curve. -or- Toposolid type is not valid for this Toposolid.
      Throws ArgumentNullException: A non-optional argument was null
    Toposolid CreateSubDivision(Document document, IList<CurveLoop> profiles)
      Description: Creates a Toposolid subdivision element with the current Toposolid as its host, using the default Toposolid type as the type of the new subdivision.
      @document: The document in which the new Toposolid is created.
      @profiles: An array of planar curve loops that represent the profiles of the Toposolid.
      Returns: The Toposolid subdivision object.
      Throws ArgumentException: The input curve loops cannot compose a valid boundary, that means: the "curveLoops" collection is empty; or some curve loops intersect with each other; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane; or input curves contain at least one helical curve.
      Throws ArgumentNullException: A non-optional argument was null
    void ExcavateBy(ElementId elementId)
      Description: Excavates the Toposolid by a given element.
      @elementId: Id of the element used to excavate the Toposolid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element is not supported for Toposolid excavation operations.
    IList<IntersectingElementData> GetIntersectingElementData()
      Description: Gets intersection data of all intersecting elements.
      Returns: The array of all intersecting element data.
    SlabShapeEditor GetSlabShapeEditor()
      Description: Gets a SlabShapeEditor that can be used to add or modify points of this Toposolid.
      Returns: The SlabShapeEditor object
    IList<ElementId> GetSubDivisionIds()
      Description: Gets all element ids of Toposolid subdivisions with the current Toposolid as its host.
      Returns: The array of Toposolid subdivision ids.
    static bool IsCutVoidStabilityEnabled(Document document)
      Description: Identifies if the setting for stability of Boolean operations for Toposolid elements is enabled or disabled.
      @document: The document.
      Returns: True means enable cut void stability setting, otherwise disable.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsSmoothedSurfaceEnabled(Document document)
      Description: Gets smoothed surface setting of Toposolid.
      @document: The document.
      Returns: True if smoothed surface is enabled for Toposolid, otherwise return false.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveExcavationBy(ElementId elementId)
      Description: Removes the excavation between the given element and the Toposolid.
      @elementId: Id of the element that already excavates the Toposolid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element is not supported for Toposolid excavation operations.
    static void SetCutVoidStability(Document document, bool enable)
      Description: Enables or disables the setting for stability of Boolean operations for Toposolid elements.
      @document: The document.
      @enable: True means enable cut void stability setting, otherwise disable.
      Throws ArgumentNullException: A non-optional argument was null
    static void SetSmoothedSurface(Document document, bool enable)
      Description: Sets smoothed surface setting of Toposolid.
      @document: The document.
      @enable: True means enable smoothed surface setting, otherwise disable.
      Throws ArgumentNullException: A non-optional argument was null
    void Simplify(double percentage)
      Description: Simplifies the Toposolid by reducing the number of inner vertices to the given percentage.
      @percentage: The ratio of the number of inner vertices after simplify to the original number.
      Throws ArgumentException: The input percentage should be greater than 0 and less than 1.
      Throws InvalidOperationException: this operation failed.
    IList<ElementId> Split(IList<CurveLoop> splitCurveLoops)
      Description: Splits the Toposolid by the given curve loops.
      @splitCurveLoops: An array of planar curve loops that are used to split the Toposolid. All of the curve loops should lie on the sketch plane of the Toposolid.
      Returns: An array of newly created Toposolid ids after split.
      Throws ArgumentException: The split curve loops should all lie on the sketch plane of the Toposolid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ToposolidType
Full Name: Autodesk.Revit.DB.ToposolidType
Description: An object that specifies the type of a Toposolid in Autodesk Revit.
Inherits: HostObjAttributes

  METHODS:
    ContourSetting GetContourSetting()
      Description: Get the contour setting object from the current toposolid type.
      Returns: The contour setting object.
    void SetContourSettting(ContourSetting setting)
      Description: Set the contour setting for the current toposolid type by copying from an existing contour setting object.
      @setting: An existing contour setting object.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Transaction
Full Name: Autodesk.Revit.DB.Transaction
Description: Transactions are context-like objects that guard any changes made to a Revit model
Remarks: Any change to a document can only be made while there is an active transaction open for that document. Changes do not become part of the document until the active transaction is Commit. Consequently, all changes made in a transaction can be RollBack either explicitly or implicitly by the transaction's destructor.A document can have only one transaction open at any given time.Transactions cannot be started when the document is in read-only mode, either permanently or temporarily. See the Document class methods IsReadOnly and IsModifiable for more details.Transactions in linked documents are not permitted, for linked documents are not allowed to be modified.If a transaction was started and not finished yet by the time the Transaction object is about to be disposed, the default destructor will roll it back automatically, thus all changes made to the document while this transaction was open will be discarded. It is not recommended to rely on this default behavior though. Instead, it is advised to always call either Commit or RollBack explicitly before the transaction object gets disposed. Please note that unless invoked explicitly the actual destruction of an object in managed code might not happen until the object is collected by the garbage collector.
Implements: IDisposable

  CONSTRUCTORS:
    new Transaction(Document document, string name)
      Description: Instantiates a transaction object
      @document: The document for which this transaction is going to be used.
      @name: The name of the transaction. This name will appear in the undo menu once the transaction is successfully committed. The name must not be empty. The name can be reset later by either calling String) or by using the name argument in the String) method.
      Throws ArgumentException: The name argument is an empty string. -or- Document is a linked file. Transactions can only be used in primary documents (projects or families.)
      Throws ArgumentNullException: A non-optional argument was null
    new Transaction(Document document)
      Description: Instantiates a transaction object.
      @document: The document for which this transaction is going to be used.
      Throws ArgumentException: Document is a linked file. Transactions can only be used in primary documents (projects or families.)
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    TransactionStatus Commit(FailureHandlingOptions options)
      Description: Commits all changes made to the model during the transaction.
      @options: A set of FailureHandlingOptions to be used for handling eventual failures during this call. The options are only used temporarily during the commitment process. After the transaction is finished, the options will be reset to their default values.
      Returns: If finished successfully, this method returns TransactionStatus.Committed Note it is possible the RolledBack status is returned instead as an outcome of failure handling. If TransactionStatus.Pending is returned it means that failure handling has not been finalized yet and Revit awaits user's actions. Until committing is fully finalized, no changes to the document can be made (including starting of new transactions).Be aware that the returned status does not have to be necessarily the same like the status returned by GetStatus even when the method is called immediately after committing the transaction. Such difference may happen due to actions made by a transaction finalizer, if there was one set. (See FailureHandlingOptions for more details.)
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The current status of the transaction is not 'Started'. Transaction must be started before calling Commit or Rollback. -or- The transaction's document is currently in failure mode. No transaction operations are permitted until failure handling is finished.
    TransactionStatus Commit()
      Description: Commits all changes made to the model during the transaction.
      Returns: If finished successfully, this method returns TransactionStatus.Committed. Note it is possible the RolledBack status is returned instead as an outcome of failure handling. If TransactionStatus::Pending is returned it means that failure handling has not been finalized yet and Revit awaits a user actions. Until committing is fully finalized, no changes to the document can be made (including starting of new transactions).The returned status does not have to be necessarily the same as the status returned by GetStatus even when the method is called immediately after committing the transaction. Such a difference may happen due to actions made by a transaction finalizer, if there was one set. (See FailureHandlingOptions for more details.)
      Throws InvalidOperationException: The current status of the transaction is not 'Started'. Transaction must be started before calling Commit or Rollback. -or- The transaction's document is currently in failure mode. No transaction operations are permitted until failure handling is finished.
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
      @options: A set of FailureHandlingOptions to be used for handling eventual failures during this call. The options are only used temporarily during this rolling back process. After the transaction is finished, the options will be reset to their default values.
      Returns: If finished successfully, this method returns TransactionStatus.RolledBack. Be aware that the returned status does not have to be necessarily the same like the status returned by GetStatus even when the method is called immediately after rolling back the transaction. Such difference may happen due to actions made by a transaction finalizer, if there was one set. (See FailureHandlingOptions for more details.)
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The current status of the transaction is not 'Started'. Transaction must be started before calling Commit or Rollback. -or- The transaction's document is currently in failure mode. No transaction operations are permitted until failure handling is finished.
    TransactionStatus RollBack()
      Description: Rolls back all changes made to the model during the transaction.
      Returns: If finished successfully, this method returns TransactionStatus.RolledBack. Be aware that the returned status does not have to be necessarily the same like the status returned by GetStatus even when the method is called immediately after rolling back the transaction. Such difference may happen due to actions made by a transaction finalizer, if there was one set. (See FailureHandlingOptions for more details.)
      Throws InvalidOperationException: The current status of the transaction is not 'Started'. Transaction must be started before calling Commit or Rollback. -or- The transaction's document is currently in failure mode. No transaction operations are permitted until failure handling is finished.
    void SetFailureHandlingOptions(FailureHandlingOptions options)
      Description: Sets options for handling failures to be used when the transaction is being committed or rolled back.
      @options: An instance of FailureHandlingOptions to be applied to the transaction
      Throws ArgumentNullException: A non-optional argument was null
    void SetName(string name)
      Description: Sets the transaction's name.
      @name: A name for the transaction.
      Throws ArgumentException: The name argument is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
    TransactionStatus Start(string name)
      Description: Starts the transaction with an assigned name.
      @name: Name of the transaction; If the transaction already has name, this new one will preplace it. The name will appear on the Undo menu in Revit if the transaction is successfully committed.
      Returns: If finished successfully, this method returns TransactionStatus.Started. Note that unless starting is successful, changes cannot be made to the document.
      Throws ArgumentException: The name argument is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled. -or- The transaction's document is currently in failure mode. No transaction operations are permitted until failure handling is finished. -or- The transaction started already and has not been completed yet. -or- Starting a new transaction is not permitted. It could be because another transaction already started and has not been completed yet, or the document is in a state in which it cannot start a new transaction (e.g. during failure handling or a read-only mode, which could be either permanent or temporary).
    TransactionStatus Start()
      Description: Starts the transaction.
      Returns: If finished successfully, this method returns TransactionStatus.Started. Note that unless starting is successful, changes cannot be made to the document.
      Throws InvalidOperationException: Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled. -or- The transaction's document is currently in failure mode. No transaction operations are permitted until failure handling is finished. -or- The transaction started already and has not been completed yet. -or- Starting a new transaction is not permitted. It could be because another transaction already started and has not been completed yet, or the document is in a state in which it cannot start a new transaction (e.g. during failure handling or a read-only mode, which could be either permanent or temporary). -or- The transaction does not have a valid name assigned yet.

--------------------------------------------------------------------------------

[CLASS] TransactionGroup
Full Name: Autodesk.Revit.DB.TransactionGroup
Description: Transaction groups aggregate a number of transactions.
Remarks: A transaction group controls whether transactions committed inside the group should stay committed or should be all discarded. If the group is committed, all the transactions remain committed, but if the transaction group is rolled back instead, all the inner, already committed transactions will be undone (and removed).There are two ways of committing a group - Commit and Assimilate. By committing, all transactions committed inside a group stay as they are, while by assimilating, all inner transactions will be merged into a single transaction.A transaction group can only be started when no transaction is active, and must be closed only after the last transaction started inside the group is finished, i.e. after it was either committed or rolled back.Transaction groups may be nested inside each other with the restriction that every nested transaction group is entirely contained (opened and closed) in the parent transaction group.If a transaction group was started and not finished yet by the time the TransactionGroup object is about to be, the default destructor will roll it back automatically, thus all changes made to the document while this transaction group was open will be discarded. It is not recommended to rely on this default behavior though. Instead, it is advised to always call either Commit, RollBack, or Assimilate explicitly before the group object gets destroyed. Please note that unless invoked explicitly the actual destruction of an object in managed code might not happen until the object is collected by the garbage collector.
Implements: IDisposable

  CONSTRUCTORS:
    new TransactionGroup(Document document, string transGroupName)
      Description: It constructs a transaction group object
      @document: The document for which this transaction group is being used.
      @transGroupName: Name of the group. The name will be used only for a group that is Assimilate at the end.
      Throws ArgumentNullException: A non-optional argument was null
    new TransactionGroup(Document document)
      Description: Constructs a transaction group object.
      @document: The document for which this transaction group is being used.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsFailureHandlingForcedModal { get; set; }
      Description: Forces all transactions finished inside this group to use modal failure handling regardless of what failure handling options are set for those transactions.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    TransactionStatus Assimilate()
      Description: Assimilates all inner transactions by merging them into a single undo item.
      Returns: If finished successfully, this method returns TransactionStatus.Committed.
      Throws InvalidOperationException: The Transaction group has not been started (its status is not 'Started').. -or- The transaction's document is currently in failure mode. Transaction groups cannot be closed until failure handling is finished. You may use a transaction finalizer to close a group after the failure handling ends.
    TransactionStatus Commit()
      Description: Commits the transaction group.
      Returns: If finished successfully, this method returns TransactionStatus.Committed.
      Throws InvalidOperationException: The Transaction group has not been started (its status is not 'Started').. -or- The transaction's document is currently in failure mode. Transaction groups cannot be closed until failure handling is finished. You may use a transaction finalizer to close a group after the failure handling ends.
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
      Throws InvalidOperationException: The Transaction group has not been started (its status is not 'Started').. -or- The transaction's document is currently in failure mode. Transaction groups cannot be closed until failure handling is finished. You may use a transaction finalizer to close a group after the failure handling ends.
    void SetName(string name)
      Description: Sets the transaction group's name.
      @name: A name for the transaction group.
      Throws ArgumentNullException: A non-optional argument was null
    TransactionStatus Start(string transGroupName)
      Description: Starts the transaction group with an assigned name.
      @transGroupName: Name of the group. The name will be used only for a group that is Assimilate at the end.
      Returns: If started successfully, this method returns TransactionStatus.Started.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled. -or- Transaction group cannot be started during an active transaction. -or- The Transaction group has already been started.
    TransactionStatus Start()
      Description: Starts the transaction group
      Returns: If started successfully, this method returns TransactionStatus.Started.
      Throws InvalidOperationException: Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled. -or- Transaction group cannot be started during an active transaction. -or- The Transaction group has already been started.

--------------------------------------------------------------------------------

[ENUM] TransactionStatus
Full Name: Autodesk.Revit.DB.TransactionStatus
Description: An enumerated type listing the possible statuses associated with a Transaction, TransactionGroup, or SubTransaction, or the result of a particular method call on one of those objects.
Inherits: Enum

  Values:
    - Uninitialized = 0
    - Started = 1
    - RolledBack = 2
    - Committed = 3
    - Pending = 4
    - Error = 5
    - Proceed = 6

--------------------------------------------------------------------------------

[CLASS] TransactWithCentralOptions
Full Name: Autodesk.Revit.DB.TransactWithCentralOptions
Description: Options to customize Revit behavior when accessing the central model.
Implements: IDisposable

  CONSTRUCTORS:
    new TransactWithCentralOptions()
      Description: Constructs a new TransactWithCentralOptions.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ICentralLockedCallback GetLockCallback()
      Description: Gets the callback object that changes Revit's default behavior of endlessly waiting and repeatedly trying to lock a central model.
    void SetLockCallback(ICentralLockedCallback lockCallback)
      Description: Sets or resets a callback object that would allow an external application to change Revit's default behavior of endlessly waiting and repeatedly trying to lock a central model.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Transform
Full Name: Autodesk.Revit.DB.Transform
Description: A transformation of the affine 3-space.
Inherits: APIObject

  CONSTRUCTORS:
    new Transform(Transform source)
      Description: The copy constructor.

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
      Throws ArgumentNullException: Thrown when the specified transformation is .
    static Transform CreateReflection(Plane plane)
      Description: Creates a transform that represents a reflection across the given plane.
      @plane: The plane.
      Returns: The new transform.
      Throws ArgumentNullException: A non-optional argument was NULL
    static Transform CreateRotation(XYZ axis, double angle)
      Description: Creates a transform that represents a rotation about the given axis at (0, 0, 0).
      @axis: The rotation axis.
      @angle: The angle.
      Returns: The new transform.
      Throws ArgumentException: The given value for angle is not finite
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentOutOfRangeException: axis has zero length.
    static Transform CreateRotationAtPoint(XYZ axis, double angle, XYZ origin)
      Description: Creates a transform that represents a rotation about the given axis at the specified point.
      @axis: The rotation axis.
      @angle: The angle.
      @origin: The origin point.
      Returns: The new transform.
      Throws ArgumentException: The given value for angle is not finite
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws ArgumentOutOfRangeException: axis has zero length.
    static Transform CreateTranslation(XYZ vector)
      Description: Creates a transform that represents a translation via the specified vector.
      @vector: The translation vector.
      Returns: The new transform.
      Throws ArgumentNullException: A non-optional argument was NULL
    Transform Multiply(Transform right)
      Description: Multiplies this transformation by the specified transformation and returns the result.
      @right: The specified transformation.
      Returns: The transformation equal to the composition of the two transformations.
      Throws ArgumentNullException: Thrown when the handle of the specified transformation is .
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
      Throws ArgumentException: Thrown when the specified value is an infinite number.
    Transform ScaleBasisAndOrigin(double scale)
      Description: Scales the basis vectors and the origin of this transformation and returns the result.
      @scale: The scale value.
      Returns: The transformation equal to the composition of the two transformations.
      Throws ArgumentException: Thrown when the specified value is an infinite number.

--------------------------------------------------------------------------------

[CLASS] Transform1D
Full Name: Autodesk.Revit.DB.Transform1D
Description: An affine transform of 1D Euclidean space.
Remarks: An affine transform is a linear transform plus a translation (which may be zero). 1D space is tranformed according to the following formula: t -> A*t + B where A and B are constants. Some functions only accept certain kinds of transform (e.g., rigid motion, conformal, non-singular, etc.).
Implements: IDisposable

  CONSTRUCTORS:
    new Transform1D(double scale)
      Description: Constructs the transformation by specifying the scale only.
      @scale: The scale of the transformation.
    new Transform1D(double scale, double translation)
      Description: Constructs the transformation by specifying the scale and the translation.
      @scale: The scale of the transformation.
      @translation: The translational part of the transformation.
    new Transform1D(Transform1D other)
      Description: The copy constructor.
      @other: The transformation to use as input.
      Throws ArgumentNullException: A non-optional argument was null

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
      Throws ArgumentNullException: A non-optional argument was null
    void Assign(Transform1D from)
      Description: Assigns values from the input transformation to this transformation.
      @from: The transformation to use as input.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    Transform1D GetInverse()
      Description: Gets the inverse transformation of this transformation.
      Throws InvalidOperationException: This transformation is singular.
    Transform1D Multiply(Transform1D right)
      Description: Multiplies this transformation by the specified transformation and returns the result.
      @right: The input transformation.
      Returns: The transformation equal to the composition of the two transformations.
      Throws ArgumentNullException: A non-optional argument was null
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
      Returns: Returns a pointer to "this" Transform1D.
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
      Description: Constructs the transformation by specifying the vectors and the origin.
      @uVec: The image of (1, 0) under UV).
      @vVec: The image of (0, 1) under UV).
      @origin: The image of (0, 0) under UV). This defines the translational part of the transform.
      Throws ArgumentNullException: A non-optional argument was null
    new Transform2D(Transform2D other)
      Description: The copy constructor.
      @other: The transformation to use as input.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    UV BasisU { get; set; }
      Description: The image of (1, 0) under UV).
    UV BasisV { get; set; }
      Description: The image of (0, 1) under UV).
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
      Description: The image of (0, 0) under UV). This defines the translational part of the transform.
    double Scale { get; }
      Description: The real number that represents the scale of the conformal transformation.

  METHODS:
    bool AlmostEqual(Transform2D right)
      Description: Determines whether this transformation and the specified transformation are the same within the tolerance (1.0e-09).
      @right: The transformation to compare with this transformation.
      Returns: True if the two transformations are equal, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void Assign(Transform2D from)
      Description: Assigns values from the input transformation to this transformation.
      @from: The transformation to use as input.
      Throws ArgumentNullException: A non-optional argument was null
    static Transform2D CreateIdentity()
      Description: Creates the identity transformation.
      Returns: The identity transformation.
    void Dispose()
    Transform2D GetInverse()
      Description: Gets the inverse transformation of this transformation.
      Throws InvalidOperationException: This transformation is not conformal or invertible.
    Transform2D Multiply(Transform2D right)
      Description: Multiplies this transformation by the specified transformation and returns the result.
      Returns: The transformation equal to the composition of the two transformations.
      Throws ArgumentNullException: A non-optional argument was null
    UV OfPoint(UV point)
      Description: Applies the transformation to the point and returns the result.
      @point: The point to transform.
      Returns: The transformed point.
      Throws ArgumentNullException: A non-optional argument was null
    UV OfVector(UV vector)
      Description: Applies the transformation to the vector and returns the result.
      @vector: The vector to transform.
      Returns: The transformed vector.
      Throws ArgumentNullException: A non-optional argument was null
    Transform2D PostScale(double scale)
      Description: Scales both the linear and translational parts of this transformation and returns the result.
      @scale: The scale value.
      Returns: Returns a pointer to "this" Transform2D.
    Transform2D PreScale(double scale)
      Description: Scales the linear part of this transformation and returns the result.
      @scale: The scale value.
      Returns: Returns a pointer to "this" Transform2D.
    Transform2D SetToIdentity()
      Description: Set this TrfUV to the identity transform.
      Returns: Returns a pointer to "this" Transform2D.
    BoundingBoxUV TransformUVDomainIfPossible(BoundingBoxUV uvDomain)
      Description: Transforms an envelope (BoundingBoxUV) for one surface to an envelope for a coincident but differently parameterized surface.
      @uvDomain: The original surface envelope.
      Returns: If successful a new BoundingBoxUV transformed surface envelope, otherwise .
      Throws ArgumentException: uvDomain is not set.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] TransformWithBoundary
Full Name: Autodesk.Revit.DB.TransformWithBoundary
Description: This class contains the transform from model space to projection space for a view and the boundary in model space in which the transform is valid.
Remarks: Use the model-to-projection transform returned by GetModelToProjectionTransform to transform model points to the view's projection space. The model-to-projection transform is only valid for points in 3D model space that that can be seen through the 2D boundary returned by GetBoundary, when looking in the direction of ViewDirection.For views that are placed on sheets, you can combine the View's model-to-projection transform and the Viewport's projection-to-sheet transform to transform model points to sheet space:sheetXYZ = projectionToSheetTransform * modelToProjectionTransform * modelXYZModel space is the global 3D coordinate space in which the 3D geometry of the model lives.View projection space is the 3D Euclidean space with a coordinate system such that X and Y are horizontal and vertical directions in the view projection plane and Z is the cross product of X and Y. Distances in the projection space are the same as would be measured on paper if the view is printed without additional scaling.Sheet space is the coordinate space of one sheet. This is the space in which viewports and titleblocks are arranged on the sheet.
Implements: IDisposable

  CONSTRUCTORS:
    new TransformWithBoundary(TransformWithBoundary other)
      Description: Constructs a new copy of the input TransformWithBoundary object.
      Throws ArgumentNullException: A non-optional argument was null

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
Remarks: TransmissionData stores information on both the previous state and requested state of an external file reference. This means that it stores the load state and path of the reference from the most recent time this TransmissionData's document was opened. It also stores load state and path information for what Revit should do the next time the document is opened.As such, TransmissionData can be used to perform operations on external file references without having to open the entire associated Revit document. The methods ReadTransmissionData and WriteTransmissionData can be used to obtain information about external references, or to change that information. For example, calling WriteTransmissionData with a TransmissionData object which has had all references set to LinkedFileStatus.Unloaded would cause no references to be loaded upon next opening the document.TransmissionData cannot add or remove references to external files. If, on file open, Revit discovers information in the TransmissionData which does not correspond to an existing external file reference, the information will be ignored on file load.The TransmissionData for a document does not contain information about references which come from external servers. TransmissionData only contains references to local files or Revit links on Revit Server. TransmissionData cannot be used to change a reference from a local file reference to an external server reference.Note that TransmissionData objects must be set to "transmitted" for the requested reference data to be meaningful. Revit ignores the TransmissionData for non-transmitted files. Marking a file as transmitted has other effects - workshared files are opened as detached from the central model, and creation of new local files is prohibited, until the file is in its final location and the file has been marked as no longer transmitted.
Implements: IDisposable

  CONSTRUCTORS:
    new TransmissionData(TransmissionData other)
      Description: Constructs a TransmissionData from another TransmissionData
      Throws ArgumentNullException: A non-optional argument was null

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
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<ElementId> GetAllExternalFileReferenceIds()
      Description: Gets the ids of all ExternalFileReferences.
      Returns: The ids of all ExternalFileReferences.
    ExternalFileReference GetDesiredReferenceData(ElementId elemId)
      Description: Gets the ExternalFileReference representing path and load status information to be used the next time this TransmissionData's document is loaded.
      @elemId: The ElementId of the Element which the external file reference is a component of.
      Returns: An ExternalFileReference containing the requested path and load status information for an external file
      Throws ArgumentException: elemId does not correspond to an ExternalFileReference contained in this TransmissionData.
      Throws ArgumentNullException: A non-optional argument was null
    ExternalFileReference GetLastSavedReferenceData(ElementId elemId)
      Description: Gets the ExternalFileReference representing path and load status information concerning the most recent time this TransmissionData's document was opened.
      @elemId: The ElementId of the Element which the external file reference is a component of.
      Returns: An ExternalFileReference containing the previous path and load status information for an external file
      Throws ArgumentException: elemId does not correspond to an ExternalFileReference contained in this TransmissionData.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsDocumentTransmitted(ModelPath filePath)
      Description: Determines whether the document at a given file location is transmitted.
      @filePath: The path to the document whose transmitted state will be checked.
      Returns: True if the document is a transmitted file, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static TransmissionData ReadTransmissionData(ModelPath path)
      Description: Reads the TransmissionData associated with the file at the given location.
      @path: A ModelPath indicating the file Revit should read the TransmissionData of. If this ModelPath is a file path, it must be an absolute path.
      Returns: The TransmissionData containing external file information for the file at the given location.
      Throws ArgumentNullException: A non-optional argument was null
      Throws CentralModelAccessDeniedException: Access to the central model was denied. A possible reason is because the model was under maintenance.
      Throws CentralModelContentionException: The central model are locked by another client.
      Throws CentralModelException: The central model is missing. -or- An internal error happened on the central model, please contact the server administrator.
      Throws FileArgumentNotFoundException: There is not a valid Revit file at path's location
      Throws RevitServerCommunicationException: The server-based central model could not be accessed because of a network communication error.
    void SetDesiredReferenceData(ElementId elemId, ModelPath path, PathType pathType, bool shouldLoad)
      Description: Sets the ExternalFileReference information which Revit should use the next time it opens the document which this TransmissionData belongs to.
      @elemId: The id of the element associated with this reference.
      @path: A ModelPath indicating the location to load the external file reference from.
      @pathType: A PathType value indicating what type of path the ModelPath is.
      @shouldLoad: True if the external file should be loaded the next time Revit opens the document. False if it should be unloaded.
      Throws ArgumentException: elemId does not correspond to an ExternalFileReference contained in this TransmissionData. -or- These inputs will not produce a valid ExternalFileReference.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static void WriteTransmissionData(ModelPath path, TransmissionData data)
      Description: Writes the given TransmissionData into the Revit file at the given location.
      @path: A ModelPath indicating the file Revit should write the TransmissionData of. This ModelPath must be a file path and an absolute path.
      @data: The TransmissionData to be written into the document. Note that Revit will not check that the ElementIds in the TransmissionData correspond to real Elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: There is not a valid Revit file at path's location
      Throws InvalidOperationException: Operation is not valid for Revit Server models. -or- This function cannot be called on an opened document.

--------------------------------------------------------------------------------

[ENUM] TransmittedModelOptions
Full Name: Autodesk.Revit.DB.TransmittedModelOptions
Description: Enum giving desired behavior when opening or saving a transmitted workshared model.
Inherits: Enum

  Values:
    - SaveAsNewCentral = 0
    - KeepAsTransmitted = 1
    - CancelOperation = 2

--------------------------------------------------------------------------------

[CLASS] TriangleInShellComponent
Full Name: Autodesk.Revit.DB.TriangleInShellComponent
Description: This class represents a triangle in a TriangulatedShellComponent object. The triangle is defined by its vertices, which are specified by their indices in the TriangulatedShellComponent's array of vertices.
Remarks: A TriangulatedShellComponent stores an array of TriangleInShellComponent objects representing the triangles of the triangulation. An external class is used because the API does not allow the use of a triple of integers. Note that a TriangleInShellComponent must only be used in the context of a single, fixed TriangulatedShellComponent.
Implements: IDisposable

  CONSTRUCTORS:
    new TriangleInShellComponent(TriangleInShellComponent other)
      Description: Creates a copy of the given TriangleInShellComponent
      Throws ArgumentNullException: A non-optional argument was null

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
      Throws ArgumentException: triangleIndex is out of range.
    XYZ GetVertex(int vertexIndex)
      Description: Returns the vertex with a given index.
      @vertexIndex: The index of the vertex (between 0 and getVertexCount()-1, inclusive).
      Returns: A copy of the requested vertex.
      Throws ArgumentException: vertexIndex is out of range.
    IList<XYZ> GetVertices()
      Description: Returns the vertices of the triangulation.
      Returns: The vertices of the triangulation.

--------------------------------------------------------------------------------

[CLASS] TriangulatedSolidOrShell
Full Name: Autodesk.Revit.DB.TriangulatedSolidOrShell
Description: This class represents a triangulated solid or shell.
Remarks: The triangulation consists of a number of TriangulatedShellComponents. For a solid, there will be one TriangulatedShellComponent for each component of the solid's boundary. For example, a solid cube has just one boundary component (containing six faces), so there will be just one TriangulatedShellComponent. A solid consisting of two disjoint cubes has two boundary components (the boundaries of the two cubes), so there will be two TriangulatedShellComponents. A solid consisting of a sphere with a round void (or hole) inside it also has two boundary components (the outer sphere and the inner sphere), so there will be two TriangulatedShellComponents.For a shell, there will be one TriangulatedShellComponent for each component of the shell.Note that this class does not contain information on the containment structure of the boundary components of a solid.Be careful not to confuse the components of a solid with the solid's boundary components. This class deals only with the boundary components.
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
      @componentIndex: The component index, must be between 0 and ShellComponentCount â€“ 1, inclusive.
      Returns: The component.
      Throws ArgumentException: Shell component index componentIndex is out of range.

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

  CONSTRUCTORS:
    new TriangulationInterfaceForTriangulatedShellComponent(TriangulatedShellComponent externalTriangulatedShellComponent)
      Description: Constructs an interface object for a TriangulatedShellComponent.
      @externalTriangulatedShellComponent: The TriangulatedShellComponent that the interface object represents.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] TriangulationInterfaceForTriangulatedSolidOrShell
Full Name: Autodesk.Revit.DB.TriangulationInterfaceForTriangulatedSolidOrShell
Description: This class is used to call FacetingUtils::convertTrianglesToQuads with a triangulation defined by a TriangulatedSolidOrShell.
Remarks: The vertex and triangle indices used by this class treat the triangulated solid or shell as if all the vertices and triangles of the different shell components were collected into single sets of vertices and triangles, respectively. For example, if a solid has two shell components and the first has ten vertices while the second has five vertices, vertexIndex 6 refers to vertex[6] of the first shell component, and vertexIndex 12 refers to vertex[2] of the second shell component. You can use the class TriangulationInterfaceForTriangulatedShellComponent to get a faceting of an individual shell component.
Inherits: TriangulationInterface

  CONSTRUCTORS:
    new TriangulationInterfaceForTriangulatedSolidOrShell(TriangulatedSolidOrShell externalTriangulatedSolidOrShell)
      Description: Construct an interface object for a TriangulatedSolidOrShell.
      @externalTriangulatedSolidOrShell: The TriangulatedSolidOrShell that the interface object represents.
      Throws ArgumentNullException: A non-optional argument was null

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
      Throws ArgumentException: index is out of range..

--------------------------------------------------------------------------------

[CLASS] TypeBinding
Full Name: Autodesk.Revit.DB.TypeBinding
Description: TypeBinding objects are used to bind a property to a Revit type, such as a wall type.
Remarks: This differs from Instance bindings in that the property is then shared by all instances that use that type. Changing the parameter for one type affects all other instances that use that type.
Inherits: ElementBinding

  CONSTRUCTORS:
    new TypeBinding(CategorySet categories)
      Description: Constructs a type binding with the set of categories passed.
    new TypeBinding()
      Description: Constructs an empty type binding.

--------------------------------------------------------------------------------

