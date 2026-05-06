# Autodesk.Revit.DB.Electrical

NAMESPACE: Autodesk.Revit.DB.Electrical
--------------------------------------------------------------------------------

[CLASS] GroundConductorSize
Full Name: Autodesk.Revit.DB.Electrical.GroundConductorSize
Description: Represents electrical ground conductor size definition information.
Remarks: Ground conductor size is defined based on corresponding wire material type.
Inherits: APIObject

  PROPERTIES:
    long Ampacity { get; }
      Description: Get ampacity which is used for specifying size, the unit is ampere.
    string ConductorSize { get; }
      Description: Get conductor size corresponding to specific ampacity.
    WireMaterialType MaterialBelongTo { get; }
      Description: Get the material type which include this ground conductor size information.

--------------------------------------------------------------------------------

[CLASS] GroundConductorSizeSet
Full Name: Autodesk.Revit.DB.Electrical.GroundConductorSizeSet
Description: A set that contains GroundConductorSizes.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new GroundConductorSizeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of GroundConductorSizes that are in the set.

  METHODS:
    void Clear()
      Description: Removes every GroundConductorSize from the set, rendering it empty.
    bool Contains(GroundConductorSize item)
      Description: Tests for the existence of a GroundConductorSize within the set.
      @item: The GroundConductorSize to be searched for.
      Returns: The Contains method returns True if the GroundConductorSize is within the set, otherwise False.
    int Erase(GroundConductorSize item)
      Description: Removes a specified GroundConductorSize from the set.
      @item: The GroundConductorSize to be erased.
      Returns: The number of GroundConductorSizes that were erased from the set.
    GroundConductorSizeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(GroundConductorSize item)
      Description: Insert the specified GroundConductorSize into the set.
      @item: The GroundConductorSize to be inserted into the set.
      Returns: Returns whether the GroundConductorSize was inserted into the set.
    GroundConductorSizeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] GroundConductorSizeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator
Description: An iterator to a GroundConductorSize set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new GroundConductorSizeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] InsulationMaterial
Full Name: Autodesk.Revit.DB.Electrical.InsulationMaterial
Description: This class represents the definition of Conductor Insulation Material data.
Implements: IDisposable

  PROPERTIES:
    ElementId Id { get; }
      Description: The Conductor Insulation Material id.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: The Conductor Insulation Material name.

  METHODS:
    static InsulationMaterial Create(Document document)
      Description: Creates a Conductor Insulation Material.
      @document: The document.
      Returns: The newly created Conductor Insulation Material data.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Dispose()
    static InsulationMaterial GetInsulationMaterial(Document document, ElementId insulationMaterialId)
      Description: Gets the Conductor Insulation Material data by given Conductor Insulation Material id.
      @document: The document.
      @insulationMaterialId: The Conductor Insulation Material id.
      Returns: The Conductor Insulation Material data.
      Throws ArgumentException: document is not a project document. -or- The id is not a Conductor Insulation Material id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static ElementId GetInsulationMaterialIdByName(Document document, string name)
      Description: Gets the Conductor Insulation Material id by given Conductor Insulation Material name.
      @document: The document.
      @name: The Conductor Insulation Material name.
      Returns: The Conductor Insulation Material id.
      Throws ArgumentException: document is not a project document. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static IList<ElementId> GetInsulationMaterialIds(Document document)
      Description: Gets all the Conductor Insulation Material ids in the given document, sorted by name.
      @document: The document.
      Returns: All the Conductor Insulation Material ids in this document.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).

--------------------------------------------------------------------------------

[CLASS] InsulationType
Full Name: Autodesk.Revit.DB.Electrical.InsulationType
Description: Represents electrical insulation type definition information.
Remarks: Insulation type is defined based on corresponding wire material type and temperature rating type.
Inherits: ElementType

  PROPERTIES:
    bool IsInUse { get; }
      Description: Indicate whether the insulation type is in use.
    string Name { set; }
      Description: Get name of Insulation type.

--------------------------------------------------------------------------------

[CLASS] InsulationTypeSet
Full Name: Autodesk.Revit.DB.Electrical.InsulationTypeSet
Description: A set that contains insulation types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new InsulationTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of insulation types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every insulation type from the set, rendering it empty.
    bool Contains(InsulationType item)
      Description: Tests for the existence of a insulation type within the set.
      @item: The insulation type to be searched for.
      Returns: The Contains method returns True if the insulation type is within the set, otherwise False.
    int Erase(InsulationType item)
      Description: Removes a specified insulation type from the set.
      @item: The insulation type to be erased.
      Returns: The number of insulation types that were erased from the set.
    InsulationTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(InsulationType item)
      Description: Insert the specified insulation type into the set.
      @item: The insulation type to be inserted into the set.
      Returns: Returns whether the insulation type was inserted into the set.
    InsulationTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] InsulationTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator
Description: An iterator to a insulation type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new InsulationTypeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] LightingDevice
Full Name: Autodesk.Revit.DB.Electrical.LightingDevice
Description: Provides access to the Lighting Device in Autodesk Revit MEP.
Remarks: The Lighting Device object can only be queried in Autodesk Revit MEP.
Inherits: MEPModel

--------------------------------------------------------------------------------

[CLASS] LightingFixture
Full Name: Autodesk.Revit.DB.Electrical.LightingFixture
Description: Provides access to the Lighting Fixture in Autodesk Revit MEP.
Remarks: The Lighting Fixture object can only be queried in Autodesk Revit MEP.
Inherits: MEPModel

--------------------------------------------------------------------------------

[ENUM] LoadClassification
Full Name: Autodesk.Revit.DB.Electrical.LoadClassification
Description: An enumerated type to list all demand factor classifications.
Inherits: Enum

  Values:
    - Undefined = 0
    - Power = 1
    - Lighting = 2
    - Hvac = 3

--------------------------------------------------------------------------------

[ENUM] LoadClassificationType
Full Name: Autodesk.Revit.DB.Electrical.LoadClassificationType
Description: An enumerated type listing all the possible load classification types for a connector object.
Inherits: Enum

  Values:
    - Other = 0
    - Power = 1
    - Lighting = 2
    - HVAC = 3

--------------------------------------------------------------------------------

[ENUM] NeutralMode
Full Name: Autodesk.Revit.DB.Electrical.NeutralMode
Description: An enumerated type to list the neutral mode for wire type.
Inherits: Enum

  Values:
    - HotConductorSize = 0
    - UnbalancedCurrent = 1

--------------------------------------------------------------------------------

[ENUM] PanelConfiguration
Full Name: Autodesk.Revit.DB.Electrical.PanelConfiguration
Description: This enum declares the configuration for given panel schedule type.
Inherits: Enum

  Values:
    - OneColumn = 0
    - TwoColumnsCircuitsAcross = 1
    - TwoColumnsCircuitsDown = 2

--------------------------------------------------------------------------------

[CLASS] PanelScheduleData
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleData
Description: The PanelScheduleData class holds most of the data that describe the layout, appearance, and style of the rows, columns, and cells of a panel schedule
Inherits: TableData

  PROPERTIES:
    bool BodyShowsVerticalHeaders { get; }
      Description: Shows text in the Load Summary section's headers vertically instead of horizontally
    ElementId BorderAroundSchedule { get; }
      Description: Places a border (GraphicStyle element) around the entire schedule, visible only on the instance and sheet
    ElementId BorderAroundSections { get; }
      Description: Places a border (GraphicStyle element) around each section, visible only on the instance and sheet
    bool IsAutoShadingForLoadDisplay { get; set; }
      Description: Display shading of load cells automatically or not.
    bool IsFooterSectionHidden { get; }
      Description: True if the user wishes to hide the footer section; setting this value must go through the appropriate update function
    bool IsHeaderSectionHidden { get; }
      Description: True if the user wishes to hide the header section; setting this value must go through the appropriate update function
    bool IsPanelSinglePhase { get; set; }
      Description: Identifies if the panel is single phase.
    bool IsSummarySectionHidden { get; }
      Description: True if the user wishes to hide the summary section; setting this value must go through the appropriate update function
    bool IsUnusedPhaseHidden { get; set; }
      Description: True if the user wishes to hide the unused phase column of a single phase panel, false otherwise.
    int NumberOfSlots { get; }
      Description: The number of slots in the panel schedule; setting this value must go through the appropriate update function
    PanelConfiguration PanelConfiguration { get; }
      Description: The panel configuration of this panel schedule
    PanelSchedulePhaseLoadType PhaseLoadType { get; }
      Description: This property determines the layout of the phase load columns; setting this value must go through the updateCircuitTable function
    bool PhasesAsCurrents { get; }
      Description: If true, the phase columns are currents (A), otherwise they are loads (VA); setting this value must go through the appropriate update function
    PanelScheduleType ScheduleType { get; }
      Description: The panel schedule type of this panel schedule
    bool ShowCircuitNumberOnOneRowForMultiphaseCircuits { get; set; }
      Description: Shows the circuit number broken up on each row of the multiphase circuit rows if true, all on the first row otherwise
    bool ShowMultipleRowsForMultiphaseCircuits { get; set; }
      Description: shows extra rows below multiphase circuits to indicate how many slots they take up if true, all on a single row otherwise
    bool ShowSlotFromDeviceInsteadOfTemplate { get; set; }
      Description: When true, the number of rows in an instance will be the number of poles on the associated device, not a set number
    bool SummaryShowsGroups { get; set; }
      Description: Show groups of load classifications in the load summary section
    bool SummaryShowsOnlyConnectedLoads { get; set; }
      Description: Show only the connected load classifications in the summary section
    bool SummaryShowsVerticalHeaders { get; }
      Description: Shows text in the Load Summary section's headers vertically instead of horizontally

  METHODS:
    bool AddLoadClassification(ElementId loadClassficationId)
      Description: Add a Load Classification Id to the array of Load Classifications.
      @loadClassficationId: The load classification to add
      Returns: True if success; false if the given Id has already existed.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ElementId> GetLoadClassifications()
      Description: Gets an array of the load classifications associated with this panel schedule
      Returns: The array of the load classifications
    int GetNumberOfCircuitRows()
      Description: Gets the number of rows in the circuit table
      Returns: The number of rows
    bool IsSymmetric()
      Description: Check if this panel schedule is symmetric
      Returns: True if this panel schedule is symmetric, false otherwise.
    void RemoveLoadClassification(int nIndex)
      Description: Remove a Load Classification Id from the array of Load Classifications
      @nIndex: The index at which to remove the load classification
    void SetBorderAroundSchedule(ElementId borderId)
      Description: Adds a border around the schedule
      @borderId: The border to set around the schedule
      Throws ArgumentNullException: A non-optional argument was null
    void SetBorderAroundSections(ElementId borderId)
      Description: Adds a border around the sections
      @borderId: The border to set around the sections
      Throws ArgumentNullException: A non-optional argument was null
    void SetLoadClassifications(IList<ElementId> loadClassificaions)
      Description: Sets the Load Classifications associated with this panel schedule
      @loadClassificaions: The load classifications to assign
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateCircuitTableForInstance(FamilyInstance pPanel)
      Description: Redraw the circuit table for the given panel with the given parameter updates
      @pPanel: The panel that this circuit table is being drawn for
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateCircuitTableForTemplate(PanelSchedulePhaseLoadType newType, int nNumSlots, bool bPhasesAsCurrents)
      Description: Redraw the circuit table for a template with the given parameter updates
      @newType: The new phase load type of the circuit table
      @nNumSlots: The number of circuit slots
      @bPhasesAsCurrents: True if the phase columns should be currents, false if they should be loads
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void UpdateIsSectionHidden(SectionType sectionType, bool bHide)
      Description: Update if this section is hidden or not
      @sectionType: The Section Type
      @bHide: Whether to hide this section or not
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void UpdateLoadSummary()
      Description: Update the load summary section
    void UpdateVerticalHeadersInSection(SectionType sectionType, bool bVertical)
      Description: Sets if this header should have vertical text
      @sectionType: The section type
      @bVertical: Whether headers are vertical or not
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] PanelSchedulePhaseLoadType
Full Name: Autodesk.Revit.DB.Electrical.PanelSchedulePhaseLoadType
Description: Declares the panel schedule type. The comments for each enum type show a simple example of how the layout would look when applied to a panel schedule
Inherits: Enum

  Values:
    - NoLoadInformation = 0
    - LoadsByPhaseInSplitColumns = 1
    - MirroredPhaseColumns = 2
    - LoadsByPhaseInSharedColumns = 3
    - LoadsByPhase = 4
    - TotalLoadOnlyPerCircuit = 5
    - SeperatePhaseLoadsPerCircuit = 6

--------------------------------------------------------------------------------

[CLASS] PanelScheduleSheetInstance
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleSheetInstance
Description: The class represents an instance of a panel schedule placed on sheet.
Inherits: Element

  PROPERTIES:
    XYZ Origin { get; set; }
      Description: The sheet instance offset in drawing sheet coordinates.
    ElementId ScheduleId { get; set; }
      Description: The panel schedule id.

  METHODS:
    static PanelScheduleSheetInstance Create(Document ADoc, ElementId scheduleId, View DBView)
      Description: Creates a new instance of panel schedule on sheet and adds it to the document.
      Returns: The newly created panel schedule sheet instance element.
      Throws ArgumentNullException: A non-optional argument was null
    PanelScheduleView GetSchedule()
      Description: Gets the panel schedule view.
      Returns: The panel schedule view element.
    bool SplitSegment(int iSeg)
      Description: Split the panel schedule into Thrown if the index is out of bounds.
      Throws ArgumentException: The iSeg is not a valid segment index. -or-

--------------------------------------------------------------------------------

[CLASS] PanelScheduleTemplate
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleTemplate
Description: The PanelScheduleTemplate class represents an instance of panel schedule template element. An instance object could be a branch panel, a switchboard or a data panel template.
Inherits: Element

  PROPERTIES:
    bool IsBranchPanelSchedule { get; }
      Description: Checks to see if this object is branch panel schedule template element.
    bool IsDataPanelSchedule { get; }
      Description: Checks to see if this object is data panel schedule template element.
    bool IsDefault { get; }
      Description: Checks to see if this is default template for the given panel schedule type.
    bool IsSwitchboardSchedule { get; }
      Description: Checks to see if this object is switchboard schedule template element.

  METHODS:
    void CopyFrom(Document OtherADoc, PanelScheduleTemplate otherElem)
      Description: Copies all values from other element to this object.
      @OtherADoc: The Document for the otherElem
      @otherElem: The element being copied from.
      Throws ArgumentException: The given template otherElem has different type of this element.
      Throws ArgumentNullException: A non-optional argument was null
    static PanelScheduleTemplate Create(Document document, PanelScheduleType type, PanelConfiguration config, string strName)
      Description: Creates a new instance of a panel schedule template.
      @document: The document where the element will be created and added.
      @type: The panel schedule type.
      @config: The panel configuration type.
      @strName: The name of the panel schedule template to be created.
      Returns: The newly created panel schedule template element.
      Throws ArgumentException: The type is not valid for this element. -or- The config is not valid for panel schedule type type of this template.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    PanelScheduleType GetPanelScheduleType()
      Description: Returns the panel schedule type.
    TableSectionData GetSectionData(SectionType sectionType)
      Description: Gets the writable section data object.
      Returns: The table section data object.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    PanelScheduleData GetTableData()
      Description: Gets the writable table data object.
      Returns: The panel schedule data object.
    bool HasSameType(PanelScheduleTemplate otherTemplate)
      Description: Checks if given template has the same panel schedule type with this template.
      @otherTemplate: The given template to check.
      Returns: True if the given template has the same panel schedule type with this template, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidPanelConfiguration(PanelScheduleType scheduleType, PanelConfiguration configuration)
      Description: Checks if given panel configuration is valid for given panel schedule type.
      @scheduleType: The panel schedule type.
      @configuration: The given configuration to check.
      Returns: True if panel schedule template can have a valid configuration assigned, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool IsValidType(PanelScheduleType panelScheduleType)
      Description: Checks if given type is valid for this panel schedule template element.
      @panelScheduleType: The given type to check.
      Returns: True if panel schedule template can have a type assigned and this type is valid for this element, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetTableData(PanelScheduleData Data)
      Description: Assigns table data to this template
      @Data: The panel schedule data
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] PanelScheduleType
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleType
Description: This enum declares the panel schedule type.
Inherits: Enum

  Values:
    - Branch = 0
    - Switchboard = 1
    - Data = 2
    - Unknown = -1

--------------------------------------------------------------------------------

[CLASS] PanelScheduleView
Full Name: Autodesk.Revit.DB.Electrical.PanelScheduleView
Description: An instance of a panel schedule view.
Inherits: TableView

  METHODS:
    void AddSpace(int nRow, int nCol)
      Description: Add a space at specific cell.
      @nRow: Row Number
      @nCol: Column Number
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Body. -or- The given column number nCol is invalid in Body. -or- There is a circuit at given cell (nRow, nCol) already.
    void AddSpare(int nRow, int nCol)
      Description: Add a spare at specific cell.
      @nRow: Row Number
      @nCol: Column Number
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Body. -or- The given column number nCol is invalid in Body. -or- There is a circuit at given cell (nRow, nCol) already.
    bool CanMoveSlotTo(int nMovingRow, int nMovingCol, int nToRow, int nToCol)
      Description: Verifies if can circuits in the source slot to the specific slot.
      @nMovingRow: The Row Number of cell to be moved.
      @nMovingCol: Start Column Number of cell to be moved.
      @nToRow: The Row Number of cell to moved to.
      @nToCol: End Column Number of cell to moved to.
      Returns: True if can move circuits in the source slot to the specific slot.
    static PanelScheduleView CreateInstanceView(Document ADoc, ElementId templateId, ElementId panelId)
      Description: Creates a new instance of this view (using specific template)
      @ADoc: The Document
      @templateId: The templateId that this function will use
      @panelId: Element id of the electrical panel element.
      Returns: The PanelScheduleView
      Throws ArgumentNullException: A non-optional argument was null
    static PanelScheduleView CreateInstanceView(Document ADoc, ElementId panelId)
      Description: Creates a new instance of this view (using default template)
      @ADoc: The Document
      @panelId: Element id of the electrical panel element.
      Returns: The PanelScheduleView
      Throws ArgumentNullException: A non-optional argument was null
    void GenerateInstanceFromTemplate(ElementId templateId)
      Description: Assigns the data from the template to the instance and performs any tasks specific to the instance (3rd phase, borders, etc)
      @templateId: Element id of the template element.
      Throws ArgumentNullException: A non-optional argument was null
    double GetApparentPhaseValue(ElementId circuitId, ElementId apparentLoadParam)
      Description: Gets the apparent load for the given phase for the given slotted circuit
      @circuitId: Circuit id for the apparent phase value
      @apparentLoadParam: The requested apparent load phase parameter
      Returns: The value of the apparent phase
      Throws ArgumentNullException: A non-optional argument was null
    void GetCellsBySlotNumber(int nSlotNumber, out IList<int> RowArr, out IList<int> ColArr)
      Description: Gets cells for the given slot number
      @nSlotNumber: Slot Number
      @RowArr: The array of Row Number
      @ColArr: The array of Col Number
    ElectricalSystem GetCircuitByCell(int nRow, int nCol)
      Description: Gets the circuit element for the given slot number
      @nRow: Row Number of the Body Section
      @nCol: Column Number of the Body Section
      Returns: The circuit found at the given row and column
    ElementId GetCircuitIdByCell(int nRow, int nCol)
      Description: Gets the circuit id for the given slot number
      @nRow: Row Number
      @nCol: Column Number
      Returns: ElementId of the circuit found at the given row and column
    string GetCombinedParamValue(SectionType sectionType, int nRow, int nCol)
      Description: Returns the combined parameter text for instance view
      @sectionType: Section type
      @nRow: Row Number
      @nCol: Column Number
      Returns: The combined parameter text
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- A value passed for an enumeration argument is not a member of that enumeration
    string GetLoadClassificationConnectedCurrent(int nRow, int nCol)
      Description: Gets the Total Current for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Connected Current for the given Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    string GetLoadClassificationConnectedLoad(int nRow, int nCol)
      Description: Gets the Total Load for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The total load for the given Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    string GetLoadClassificationDemandCurrent(int nRow, int nCol)
      Description: Gets the Demand Current for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Demand Current for the given Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    string GetLoadClassificationDemandFactor(int nRow, int nCol)
      Description: Gets the Demand Factor for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Demand Factor for the given Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    string GetLoadClassificationDemandLoad(int nRow, int nCol)
      Description: Gets the Demand Load for given Load Classification
      @nRow: Row number of Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The Demand Load for the Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    ElementId GetLoadClassificationId(int nRow)
      Description: Gets the id of the associated Load Classification at the given row
      @nRow: Row number of Load Summary Section
      Returns: The element id of the Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary.
    string GetLoadClassificationName(int nRow, int nCol)
      Description: Gets the name of the Load Classification at the given row/column
      @nRow: Row Number of the Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The name of the Load Classification
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    string GetLoadClassificationParamValue(ElementId parameterId, int nRow, int nCol)
      Description: Gets the load classification parameter value.
      @parameterId: Parameter Id of the Load Classification
      @nRow: Row Number of the Load Summary Section
      @nCol: Column number of Load Summary Section
      Returns: The value of the Load Classification parameter
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Summary. -or- The given column number nCol is invalid in Summary.
    ElementId GetPanel()
      Description: Gets the panel for this view
      Returns: The id of the panel for this view
    string GetParamValue(SectionType sectionType, int nRow, int nCol)
      Description: Gets the cell's text based on its type
      @sectionType: Section of the desired parameter value
      @nRow: Row Number of the Section
      @nCol: Column Number of the Section
      Returns: The cell's text
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- Thrown if there is no parameter at this cell -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Thrown if attempt to call on a template
    TableSectionData GetSectionData(SectionType sectionType)
      Description: Gets section data that will be written to
      @sectionType: The section type
      Returns: The TableSectionData
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    int GetSlotNumberByCell(int nRow, int nCol)
      Description: Gets the slot number in the circuit table
      @nRow: Column Number
      Returns: Row Number
    double GetSpareCurrentValue(int row, int column, ElementId idCurrentParameter)
      Description: Gets the value of the apparent current parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idCurrentParameter: One of 4 valid current parameters: RBS_ELEC_APPARENT_CURRENT_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEA_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEB_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEC_PARAM
      Returns: The value of the spare's current parameter
      Throws ArgumentException: The current parameter id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The row column combination does not represent a valid spare.
    double GetSpareLoadValue(int row, int column, ElementId idLoadParameter)
      Description: Gets the value of the apparent load parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idLoadParameter: One of 4 valid load parameters: RBS_ELEC_APPARENT_LOAD, RBS_ELEC_APPARENT_LOAD_PHASEA, RBS_ELEC_APPARENT_LOAD_PHASEB, RBS_ELEC_APPARENT_LOAD_PHASEC
      Returns: The value of the spare's load parameter
      Throws ArgumentException: The load parameter id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The row column combination does not represent a valid spare.
    PanelScheduleData GetTableData()
      Description: Gets table data that can be written to
      Returns: The PanelScheduleData
    ElementId GetTemplate()
      Description: Gets the template for this view (to set the template, you must go through generateInstanceFromTemplate)
      Returns: The template id for this view
    bool IsCellInPhaseLoads(int nRow, int nCol)
      Description: Check if this cell in the phase loads
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if this cell in the phase loads, false otherwise
    bool IsColumnInLoadSummary(int nCol)
      Description: Check if this column in the load summary
      @nCol: Column Number
      Returns: Check if this column in the load summary
    bool IsPanelScheduleTemplate()
      Description: Check if this is a panel schedule template.
      Returns: Check if this is a panel schedule template.
    bool IsRowInCircuitTable(int nRow)
      Description: Check if this row in the circuit table
      @nRow: Row Number
      Returns: True if this row in the circuit table, false otherwise.
    int IsSlotGrouped(int nRow, int nCol)
      Description: Check if the slot is in a group
      @nRow: Row Number
      @nCol: Column Number
      Returns: It is not in a group if the return value equals to 0. It is in a group if the return value is greater than 0 and the return value is the group number.
    bool IsSlotLocked(int nRow, int nCol)
      Description: Check if the circuit slot in this cell is locked.
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if the circuit slot in this cell is locked, false otherwise False if the circuit slot not found.
    bool IsSpace(int nRow, int nCol)
      Description: Check if the selected cell is a space
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if the selected cell is a space, false otherwise
    bool IsSpare(int nRow, int nCol)
      Description: Check if the circuit is a spare
      @nRow: Row Number
      @nCol: Column Number
      Returns: True if the circuit is a spare, false otherwise
    void MoveSlotTo(int nMovingRow, int nMovingCol, int nToRow, int nToCol)
      Description: Move the circuits in the source slot to the specific slot.
      @nMovingRow: The Row Number of cell to be moved.
      @nMovingCol: Start Column Number of cell to be moved.
      @nToRow: The Row Number of cell to moved to.
      @nToCol: End Column Number of cell to moved to.
      Throws ArgumentOutOfRangeException: The given row number nMovingRow is invalid in Body. -or- The given column number nMovingCol is invalid in Body. -or- The given row number nToRow is invalid in Body. -or- The given column number nToCol is invalid in Body. -or- There is no circuit at given cell (nMovingRow, nMovingCol). -or- Cannot move the circuits at slot (nMovingRow, nMovingCol) to given slot (nToRow, nToCol).
    void RemoveSpace(int nRow, int nCol)
      Description: Remove a space at specific cell.
      @nRow: Row Number
      @nCol: Column Number
      Throws ArgumentsInconsistentException: The row column combination does not represent a valid space.
    void RemoveSpare(int nRow, int nCol)
      Description: Remove a spare at specific cell.
      @nRow: Row Number
      @nCol: Column Number
      Throws ArgumentsInconsistentException: The row column combination does not represent a valid spare.
    void RenumberIndexes()
      Description: Renumbers the Circuit Naming Index for the circuits in the panel.
    void SetLockSlot(int nRow, int nCol, bool bLock)
      Description: Set lock state for a circuit slot at specific cell.
      @nRow: Row Number
      @nCol: Column Number
      @bLock: Lock state to set
    bool SetParamValue(SectionType sectionType, int nRow, int nCol, string sValue)
      Description: Sets the text for the given cell, returns true if successful, false otherwise
      @sectionType: The associated section
      @nRow: Row Number of the Section
      @nCol: Column Number of the Section
      @sValue: String value to set the parameter
      Returns: Returns whether the function succeeded
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid. -or- The given column number nCol is invalid. -or- Thrown if there is no parameter at this cell -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Thrown if attempt to call on a template
    void SetSpareCurrentValue(int row, int column, ElementId idCurrentParameter, double value)
      Description: Sets the value of the apparent current parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idCurrentParameter: One of 4 valid current parameters: RBS_ELEC_APPARENT_CURRENT_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEA_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEB_PARAM, RBS_ELEC_APPARENT_CURRENT_PHASEC_PARAM
      @value: The value of the spare's current for the given parameter
      Throws ArgumentException: The current parameter id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for value must be non-negative.
      Throws ArgumentsInconsistentException: The row column combination does not represent a valid spare.
    void SetSpareLoadValue(int row, int column, ElementId idLoadParameter, double value)
      Description: Sets the value of the apparent load parameter for a spare
      @row: A row where the valid spare is
      @column: A column where the valid spare is
      @idLoadParameter: One of 4 valid load parameters: RBS_ELEC_APPARENT_LOAD, RBS_ELEC_APPARENT_LOAD_PHASEA, RBS_ELEC_APPARENT_LOAD_PHASEB, RBS_ELEC_APPARENT_LOAD_PHASEC
      @value: The value of the spare's load for the given parameter
      Throws ArgumentException: The load parameter id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for value must be non-negative.
      Throws ArgumentsInconsistentException: The row column combination does not represent a valid spare.
    void SwitchPhases(int nRow, int nCol)
      Description: Switches the circuit phases at the slot.
      @nRow: Row Number.
      @nCol: Column Number.
      Throws ArgumentException: The circuit at given cell (nRow, nCol) is not one or two poles circuit.
      Throws ArgumentOutOfRangeException: The given row number nRow is invalid in Body. -or- The given column number nCol is invalid in Body. -or- There is no circuit at given cell (nRow, nCol).
      Throws InvalidOperationException: This is not a switchboard panel schedule.

--------------------------------------------------------------------------------

[ENUM] PowerFactorStateType
Full Name: Autodesk.Revit.DB.Electrical.PowerFactorStateType
Description: An enumerated type listing all the possible power factor state types for a connector object.
Inherits: Enum

  Values:
    - Leading = 0
    - Lagging = 1

--------------------------------------------------------------------------------

[CLASS] TemperatureRating
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRating
Description: This class represents the definition of Conductor Temperature Rating data.
Implements: IDisposable

  PROPERTIES:
    ElementId Id { get; }
      Description: The Conductor Temperature Rating id.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: The Conductor Temperature Rating name.

  METHODS:
    static TemperatureRating Create(Document document)
      Description: Creates a Conductor Temperature Rating.
      @document: The document.
      Returns: The newly created Conductor Temperature Rating data.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void Dispose()
    static TemperatureRating GetTemperatureRating(Document document, ElementId temperatureRatingId)
      Description: Gets the Conductor Temperature Rating data by given Conductor Temperature Rating id.
      @document: The document.
      @temperatureRatingId: The Conductor Temperature Rating id.
      Returns: The Conductor Temperature Rating data.
      Throws ArgumentException: document is not a project document. -or- The id is not a Conductor Temperature Rating id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static ElementId GetTemperatureRatingIdByName(Document document, string name)
      Description: Gets the Conductor Temperature Rating id by given Conductor Temperature Rating name.
      @document: The document.
      @name: The Conductor Temperature Rating name.
      Returns: The Conductor Temperature Rating id.
      Throws ArgumentException: document is not a project document. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
    static IList<ElementId> GetTemperatureRatingIds(Document document)
      Description: Gets all the Conductor Temperature Rating ids in the given document, sorted by name.
      @document: The document.
      Returns: All the Conductor Temperature Rating ids in this document.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).

--------------------------------------------------------------------------------

[CLASS] TemperatureRatingType
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRatingType
Description: Represents temperature rating type definition information.
Remarks: Temperature rating type is defined based on corresponding wire material type. It includes type information such as wire size, insulation type, correction factor, etc. Only the temperature rating types which are retrieved from WireMaterialType can work well, so don't retrieve it from Revit document directly.
Inherits: ElementType

  PROPERTIES:
    CorrectionFactorSet CorrectionFactors { get; }
      Description: Get all correction factors defined in this temperature rating type and its corresponding material type.
    InsulationTypeSet InsulationTypes { get; }
      Description: Get all insulation types defined in this temperature rating type and its corresponding material type.
    bool IsInUse { get; }
      Description: Indicate whether the temperature rating type is in use.
    WireMaterialType MaterialType { get; }
      Description: Get the material type information which this temperature rating type belongs to.
    string Name { set; }
      Description: Get name of temperature rating type.
    WireSizeSet WireSizes { get; }
      Description: Get all electrical wire sizes defined in this temperature rating type and its corresponding material type.

  METHODS:
    CorrectionFactor AddCorrectionFactor(double temperature, double factor)
      Description: Add a new electrical correction factor type to this temperature rating type. The given temperature value should be quantified in the document's selected unit of electrical temperature.
      @temperature: Temperature of correction factor to be added in the document's selected unit of electrical temperature.
      @factor: Factor of correction factor to be added.
      Returns: New constructed correction factor.
    InsulationType AddInsulationType(string name)
      Description: Add a new kind of insulation type into this temperature rating type.
      @name: Name of insulation type symbol to be constructed and added.
      Returns: Constructed insulation type instance.
    WireSize AddWireSize(string size, long ampacity, double diameter)
      Description: Add a new kind of wire size type into this temperature rating type.
      @size: Size of wire size.
      @ampacity: Ampacity of wire size to be added.
      @diameter: Diameter of wire size to be added.
      Returns: Constructed wire size type.
    void RemoveCorrectionFactor(CorrectionFactor correctionFactor)
      Description: Remove an existing correction factor from this temperature rating type in Revit MEP project.
      @correctionFactor: The correction factor to be removed.
    void RemoveInsulationType(InsulationType insulationType)
      Description: Remove an existing insulation type from this temperature rating type.
      @insulationType: Insulation type to be removed.
      Throws InvalidOperationException: The last one insulation type of project and any one which is in use by a wire type can't be removed.
    void RemoveWireSize(WireSize wireSize)
      Description: Remove an existing wire size type from this temperature rating type.
      @wireSize: The wire size type to be removed.

--------------------------------------------------------------------------------

[CLASS] TemperatureRatingTypeSet
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet
Description: A set that contains TemperatureRating types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new TemperatureRatingTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of TemperatureRating types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every TemperatureRating type from the set, rendering it empty.
    bool Contains(TemperatureRatingType item)
      Description: Tests for the existence of a TemperatureRating type within the set.
      @item: The TemperatureRating type to be searched for.
      Returns: The Contains method returns True if the TemperatureRating type is within the set, otherwise False.
    int Erase(TemperatureRatingType item)
      Description: Removes a specified TemperatureRating type from the set.
      @item: The TemperatureRating type to be erased.
      Returns: The number of TemperatureRating types that were erased from the set.
    TemperatureRatingTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(TemperatureRatingType item)
      Description: Insert the specified TemperatureRating type into the set.
      @item: The TemperatureRating type to be inserted into the set.
      Returns: Returns whether the TemperatureRating type was inserted into the set.
    TemperatureRatingTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] TemperatureRatingTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator
Description: An iterator to a TemperatureRating type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new TemperatureRatingTypeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] VoltageType
Full Name: Autodesk.Revit.DB.Electrical.VoltageType
Description: Represents electrical voltage type. An electrical voltage type define a range of voltages, and circuits can be created between components with rated voltages that do not precisely match the voltage definition value.
Remarks: Actual, minimum and maximum value of voltage type can retrieved through properties, but only can be modified through SetVoltageValue method. All the unit of voltage properties in this class is volt.
Inherits: ElementType

  PROPERTIES:
    double ActualValue { get; }
      Description: Get actual voltage value of this voltage definition, the unit is volt.
    bool IsInUse { get; }
      Description: Indicates whether this voltage type is in service now, such as by other distribution system.
    double MaxValue { get; }
      Description: Get upper boundary of voltage value of this voltage definition, the unit is volt.
    double MinValue { get; }
      Description: Get lower boundary of voltage value of this voltage definition, the unit is volt.

  METHODS:
    void SetVoltageValue(double actualValue, double minValue, double maxValue)
      Description: Assign new values to modify voltage type, all of the unit are volt.
      Throws ArgumentException: Actual value can't be more than minValue or less than maxValue, and all of them can't be negative, otherwise the exception will be thrown.

--------------------------------------------------------------------------------

[CLASS] VoltageTypeSet
Full Name: Autodesk.Revit.DB.Electrical.VoltageTypeSet
Description: A set that contains voltage types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new VoltageTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of voltage types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every voltage type from the set, rendering it empty.
    bool Contains(VoltageType item)
      Description: Tests for the existence of a voltage type within the set.
      @item: The voltage type to be searched for.
      Returns: The Contains method returns True if the voltage type is within the set, otherwise False.
    int Erase(VoltageType item)
      Description: Removes a specified voltage type from the set.
      @item: The voltage type to be erased.
      Returns: The number of voltage types that were erased from the set.
    VoltageTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(VoltageType item)
      Description: Insert the specified voltage type into the set.
      @item: The voltage type to be inserted into the set.
      Returns: Returns whether the voltage type was inserted into the set.
    VoltageTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] VoltageTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator
Description: An iterator to a voltage type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new VoltageTypeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] Wire
Full Name: Autodesk.Revit.DB.Electrical.Wire
Description: Electrical wire element.
Inherits: MEPCurve

  PROPERTIES:
    int GroundConductorNum { get; set; }
      Description: The ground conductor number. Its default value is zero after created.
    int HotConductorNum { get; set; }
      Description: The hot conductor number. Its default value is zero after created.
    int NeutralConductorNum { get; set; }
      Description: The neutral conductor number. Its default value is zero after created.
    int NumberOfVertices { get; }
      Description: The number of vertices of the wire, including the start and end point.
    WiringType WiringType { get; set; }
      Description: The wiring type(arc or chamfer) for the wire.

  METHODS:
    void AppendVertex(XYZ vertexPoint)
      Description: Appends one vertex to the end of the wire.
      @vertexPoint: The vertex to be appended.
      Throws ArgumentException: The vertex point cannot be added to the wire because there is already a vertex at this position on the view plane (within tolerance).
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The end point is already connected to an element, so a new endpoint vertex cannot be appended.
    static bool AreVertexPointsValid(IList<XYZ> vertexPoints, Connector startConnector, Connector endConnector)
      Description: Checks if the given vertex points are valid for the wire.
      @vertexPoints: The vertex points.
      @startConnector: The start connector of the wire.
      @endConnector: The end connector of the wire.
      Returns: True if the given vertex points are valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void ConnectTo(Connector startConnectorTo, Connector endConnectorTo)
      Description: Connects the wire to other elements.
      @startConnectorTo: The connector that the start connector of the wire connects to.
      @endConnectorTo: The connector that the end connector of the wire connects to.
      Throws ArgumentException: startConnectorTo cannot be connected to a wire, as it is not an electrical connector. -or- endConnectorTo cannot be connected to a wire, as it is not an electrical connector. -or- startConnectorTo or/and endConnectorTo cannot be connected to a wire, as wire can't connect both connectors to same wire or same connector.
      Throws InvalidOperationException: Cannot connect the wire to the start connector or the end connector.
    static Wire Create(Document document, ElementId wireTypeId, ElementId viewId, WiringType wiringType, IList<XYZ> vertexPoints, Connector startConnectorTo, Connector endConnectorTo)
      Description: Creates a new wire.
      @document: The document.
      @wireTypeId: The id of the wire type of the newly created wire.
      @viewId: The view in which the wire is to be visible. This must be the id of a floor plan or reflected ceiling plan view.
      @wiringType: Specifiies the wiring type for the newly created wire. The shape of the wire is determined by this value and the total number of points supplied via the vertexPoints and endpoint connectors. If the wiring type is WiringType.Arc: If there are 2 total points supplied, the wire is a straight-line wire.If there are 3 total points supplied, the wire is a circular arc wire.If there are 4 or more points, the wire is a spline wire. If the wiring type is WiringType.Chamfer, a polyline wire will be created connecting all the points.
      @vertexPoints: The vertex point of the wire. If the startConnectorTo is , the first vertex of the vertexPoints will be the start point, otherwise, the start connector origin will be the start point. If the endConnectorTo is , the last vertex of the vertexPoints will be the end point, otherwise, the end connector origin will be the end point.
      @startConnectorTo: The connector to which the wire start point connects. If , the start point connects to no existing connector. If set with a connector, the connector's origin will be added to the wire's vertices as the start point.
      @endConnectorTo: The connector to which the wire end point connects. If , the end point connects to no existing connector. If set with a connector, the connector's origin will be added to the wire's vertices as the end point.
      Returns: The wire created.
      Throws ArgumentException: wireTypeId is not a valid WireType id. -or- viewId does not represent a view valid for a Wire element. Either a floor plan or reflected ceiling plan is expected. -or- vertexPoints is not valid, because one or more points are coincident by comparing the X and Y of the points, or there are not at least two points including the connectors. -or- startConnectorTo cannot be connected to a wire, as it is not an electrical connector. -or- endConnectorTo cannot be connected to a wire, as it is not an electrical connector.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<ElementId> GetMEPSystems()
      Description: Gets the systems to which the wire belongs.
      Returns: The systems to which the wire belongs.
    XYZ GetVertex(int index)
      Description: Gets the position of an existing vertex.
      @index: The index of the existing vertex. Should be between 0 and NumberOfVertices.
      Returns: The position of the vertex. It is the offset point for the start and end vertex, not the connector point. If the wire connects to one device, it may have offset; otherwise, the start and end vertex is same as the connector point.
      Throws ArgumentException: The index should be between 0 and the number of vertices of the wire.
    void InsertVertex(int index, XYZ vertexPoint)
      Description: Inserts a new vertex before the specified index.
      @index: The index of the vertex to come after this new vertex. Should be between 0 and NumberOfVertices.
      @vertexPoint: The point of the new vertex.
      Throws ArgumentException: The index should be between 0 and the number of vertices of the wire. -or- The vertex point cannot be added to the wire because there is already a vertex at this position on the view plane (within tolerance).
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Can't insert the vertex before the start vertex if the start point connects to one element.
    bool IsVertexPointValid(XYZ vertexPoint)
      Description: Checks if the given vertex point can be added to this wire.
      @vertexPoint: The vertex point.
      Returns: True if the vertex point can be added, false if the point cannot be added because there is already a vertex at this position on the view plane (within tolerance).
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveVertex(int index)
      Description: Removes the vertex corresponding to the specified index. Can not remove the start or end vertex if it already connects to other element.
      @index: The index which should be in [0, NumberOfVertices).
      Throws ArgumentException: The index should be between 0 and the number of vertices of the wire.
      Throws InvalidOperationException: The wire has only 2 vertices, so one cannot be removed. -or- Can't remove the vertex when the vertex is start or end point and the wire connects to one element.
    void SetVertex(int index, XYZ vertexPoint)
      Description: Sets the position of a given vertex. If the vertex is start or end point, and the wire connects to electrical device, the wire end offset will be set according to the given vertex. If the vertex is start or end point, and the wire connects to other wire, user can't set the vertex and exception will be thrown. If the vertex is start or end point, and the wire connects to nothing, the vertex will be set as the given vertex.
      @index: The index of the existing vertex. Should be between 0 and NumberOfVertices.
      @vertexPoint: The new position for the vertex.
      Throws ArgumentException: The index should be between 0 and the number of vertices of the wire. -or- The vertex point cannot be added to the wire because there is already a vertex at this position on the view plane (within tolerance).
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Can't set the vertex when the vertex is start or end point and the wire connects to other wire.

--------------------------------------------------------------------------------

[CLASS] WireConduitType
Full Name: Autodesk.Revit.DB.Electrical.WireConduitType
Description: Represents a specific conduit type of wire type.
Inherits: APIObject

  PROPERTIES:
    string Name { get; }

--------------------------------------------------------------------------------

[CLASS] WireConduitTypeSet
Full Name: Autodesk.Revit.DB.Electrical.WireConduitTypeSet
Description: A set that contains conduit types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new WireConduitTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of conduit types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every conduit type from the set, rendering it empty.
    bool Contains(WireConduitType item)
      Description: Tests for the existence of a conduit type within the set.
      @item: The conduit type to be searched for.
      Returns: The Contains method returns True if the conduit type is within the set, otherwise False.
    int Erase(WireConduitType item)
      Description: Removes a specified conduit type from the set.
      @item: The conduit type to be erased.
      Returns: The number of conduit types that were erased from the set.
    WireConduitTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireConduitType item)
      Description: Insert the specified conduit type into the set.
      @item: The conduit type to be inserted into the set.
      Returns: Returns whether the conduit type was inserted into the set.
    WireConduitTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireConduitTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator
Description: An iterator to a conduit type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new WireConduitTypeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] WireMaterialType
Full Name: Autodesk.Revit.DB.Electrical.WireMaterialType
Description: Represents electrical wire material type definition information of wire type.
Remarks: All the other properties of wire type are based on wire material type. Only the wire material types which are retrieved from ElectricalSetting can work well, so don't retrieve it from Revit project directly.
Inherits: ElementType

  PROPERTIES:
    GroundConductorSizeSet GroundConductorSizes { get; }
      Description: Get all ground conductor size types defined in this wire material type.
    bool IsInUse { get; }
      Description: Indicate whether the wire material type is in use.
    string Name { set; }
      Description: Get name of wire material type.
    TemperatureRatingTypeSet TemperatureRatings { get; }
      Description: Get all temperature rating type definitions defined in this wire material type.

  METHODS:
    GroundConductorSize AddGroundConductorSize(long ampacity, string size)
      Description: Add new electrical ground conductor size type into this material type.
      @ampacity: Ampacity of ground conductor size to be added.
      @size: Size of ground conductor size to be added.
      Returns: New added ground conductor size.
    TemperatureRatingType AddTemperatureRatingType(string name, TemperatureRatingType baseOn)
      Description: Add a new temperature rating type into material type.
      @name: Name of temperature type to be added.
      @baseOn: The new temperature rating will be created base on this existing temperature rating type.
      Returns: New constructed temperature rating type.
    void RemoveGroundConductorSize(GroundConductorSize grdConductorSize)
      Description: Remove an existing ground conductor size from this material type.
      @grdConductorSize: The ground size type to be removed.
    void RemoveTemperatureRatingType(TemperatureRatingType temperatureRating)
      Description: Remove an existing temperature rating type from this material type.
      @temperatureRating: The temperature rating type to be removed.
      Throws InvalidOperationException: The last temperature rating type of project and any one used by a wire type can't be removed.

--------------------------------------------------------------------------------

[CLASS] WireMaterialTypeSet
Full Name: Autodesk.Revit.DB.Electrical.WireMaterialTypeSet
Description: A set that contains wire material types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new WireMaterialTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of wire material types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every wire material type from the set, rendering it empty.
    bool Contains(WireMaterialType item)
      Description: Tests for the existence of a wire material type within the set.
      @item: The wire material type to be searched for.
      Returns: The Contains method returns True if the wire material type is within the set, otherwise False.
    int Erase(WireMaterialType item)
      Description: Removes a specified wire material type from the set.
      @item: The wire material type to be erased.
      Returns: The number of wire material types that were erased from the set.
    WireMaterialTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireMaterialType item)
      Description: Insert the specified wire material type into the set.
      @item: The wire material type to be inserted into the set.
      Returns: Returns whether the wire material type was inserted into the set.
    WireMaterialTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireMaterialTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator
Description: An iterator to a wire material type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new WireMaterialTypeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] WireSet
Full Name: Autodesk.Revit.DB.Electrical.WireSet
Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new WireSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Wire item)
    int Erase(Wire item)
    WireSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Wire item)
    WireSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireSetIterator
Description: An iterator to a set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new WireSetIterator()
      Description: For Internal Use Only.

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

[CLASS] WireSize
Full Name: Autodesk.Revit.DB.Electrical.WireSize
Description: Represents specific electrical wire size information.
Remarks: Wire size is defined based on corresponding wire material type and temperature rating type.
Inherits: APIObject

  PROPERTIES:
    long Ampacity { get; }
      Description: Get ampacity which be used for specifying size, the unit is ampere.
    double Diameter { get; }
      Description: Get diameter of wire.
    bool InUse { get; set; }
      Description: Get or set whether the size can be used in sizing.
    string Size { get; }
      Description: Get size symbol of wire.

--------------------------------------------------------------------------------

[CLASS] WireSizeSet
Full Name: Autodesk.Revit.DB.Electrical.WireSizeSet
Description: A set that contains wire sizes.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new WireSizeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of wire sizes that are in the set.

  METHODS:
    void Clear()
      Description: Removes every wire size from the set, rendering it empty.
    bool Contains(WireSize item)
      Description: Tests for the existence of a wire size within the set.
      @item: The wire size to be searched for.
      Returns: The Contains method returns True if the wire size is within the set, otherwise False.
    int Erase(WireSize item)
      Description: Removes a specified wire size from the set.
      @item: The wire size to be erased.
      Returns: The number of wire sizes that were erased from the set.
    WireSizeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireSize item)
      Description: Insert the specified wire size into the set.
      @item: The wire size to be inserted into the set.
      Returns: Returns whether the wire size was inserted into the set.
    WireSizeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireSizeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireSizeSetIterator
Description: An iterator to a wire size set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new WireSizeSetIterator()
      Description: For Internal Use Only.

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

[CLASS] WireType
Full Name: Autodesk.Revit.DB.Electrical.WireType
Description: Represents a specific wire type.
Inherits: ElementType

  PROPERTIES:
    WireConduitType Conduit { get; set; }
      Description: The conduit type of the wire type.
    ElementId Insulation { get; set; }
      Description: The conductor insulation material of the wire type.
    bool IsInUse { get; }
      Description: Indicates whether the wire type is in use.
    string MaxSize { get; set; }
      Description: The max conductor size name of the wire type.
    double NeutralMultiplier { get; set; }
      Description: The neutral multiplier type of the wire type.
    bool NeutralRequired { get; set; }
      Description: Whether or not the neutral point is required.
    NeutralMode NeutralSize { get; set; }
      Description: The maximum neutral size of the wire type.
    ElementId TemperatureRating { get; set; }
      Description: The conductor temperature rating of the wire type.
    ElementId WireMaterial { get; set; }
      Description: The conductor material of the wire type.

--------------------------------------------------------------------------------

[CLASS] WireTypeSet
Full Name: Autodesk.Revit.DB.Electrical.WireTypeSet
Description: A set that contains wire types.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new WireTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of wire types that are in the set.

  METHODS:
    void Clear()
      Description: Removes every wire type from the set, rendering it empty.
    bool Contains(WireType item)
      Description: Tests for the existence of a wire type within the set.
      @item: The wire type to be searched for.
      Returns: The Contains method returns True if the wire type is within the set, otherwise False.
    int Erase(WireType item)
      Description: Removes a specified wire type from the set.
      @item: The wire type to be erased.
      Returns: The number of wire types that were erased from the set.
    WireTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(WireType item)
      Description: Insert the specified wire type into the set.
      @item: The wire type to be inserted into the set.
      Returns: Returns whether the wire type was inserted into the set.
    WireTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WireTypeSetIterator
Full Name: Autodesk.Revit.DB.Electrical.WireTypeSetIterator
Description: An iterator to a wire type set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new WireTypeSetIterator()
      Description: For Internal Use Only.

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

[ENUM] WiringType
Full Name: Autodesk.Revit.DB.Electrical.WiringType
Description: An enumerated type to list all wiring types.
Inherits: Enum

  Values:
    - Arc = 0
    - Chamfer = 1

--------------------------------------------------------------------------------

