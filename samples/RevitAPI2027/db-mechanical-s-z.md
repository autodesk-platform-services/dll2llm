# Autodesk.Revit.DB.Mechanical

NAMESPACE: Autodesk.Revit.DB.Mechanical
--------------------------------------------------------------------------------

[CLASS] Space
Full Name: Autodesk.Revit.DB.Mechanical.Space
Description: Provides access to the space topology in Autodesk Revit.
Remarks: The space object can be queried for its boundary for use in space planning tools.
Inherits: SpatialElement

  PROPERTIES:
    double ActualExhaustAirflow { get; }
      Description: Get the Actual Exhaust Airflow of the Space.
    double ActualHVACLoad { get; }
      Description: Get the Actual HVAC Load of the Space.
    double ActualLightingLoad { get; }
      Description: Get the Actual Lighting Load of the Space.
    double ActualOtherLoad { get; }
      Description: Get the Actual Other Load of the Space.
    double ActualPowerLoad { get; }
      Description: Get the Actual Power Load of the Space.
    double ActualReturnAirflow { get; }
      Description: Get the Actual Return Airflow of the Space.
    double ActualSupplyAirflow { get; }
      Description: Get the Actual Supply Airflow of the Space.
    double AirChangesPerHour { get; }
      Description: Get the Specified AirChangesPerHour of the Space.
    double AreaperPerson { get; set; }
      Description: Get or set the Area per Person of the Space.
    double AverageEstimatedIllumination { get; }
      Description: Get the Average Estimated Illumination of the Space.
    BaseLoadOn BaseHeatLoadOn { get; set; }
      Description: The heat load-on.
    double BaseOffset { get; set; }
      Description: Get or set the Base Offset of the Space.
    double CalculatedCoolingLoad { get; }
      Description: Get the Calculated Cooling Load of the Space.
    double CalculatedHeatingLoad { get; }
      Description: Get the Calculated Heating Load of the Space.
    double CalculatedSupplyAirflow { get; }
      Description: Get the Calculated Supply Airflow of the Space.
    double CeilingReflectance { get; set; }
      Description: Get or set the Ceiling Reflectance of the Space.
    GeometryElement ClosedShell { get; }
      Description: Return the closedShell of the space.
    ConditionType ConditionType { get; set; }
      Description: Get or set the Condition type of the Space.
    double DesignCoolingLoad { get; set; }
      Description: Get or set the Design Cooling Load of the Space.
    double DesignExhaustAirflow { get; set; }
      Description: Get or set the Specified Exhaust Airflow of the Space.
    double DesignHeatingLoad { get; set; }
      Description: Get or set the Design Heating Load of the Space.
    double DesignHVACLoadperArea { get; set; }
      Description: Get or set the Design HVAC Load per Area of the Space.
    double DesignLightingLoad { get; set; }
      Description: Get or set the Design Lighting Load of the Space.
    double DesignOtherLoadperArea { get; set; }
      Description: Get or set the Design Other Load per Area of the Space.
    double DesignPowerLoad { get; set; }
      Description: Get or set the Design Power Load of the Space.
    double DesignReturnAirflow { get; set; }
      Description: Get or set the Specified Return Airflow of the Space.
    double DesignSupplyAirflow { get; set; }
      Description: Get or set the Specified Supply Airflow of the Space.
    double FloorReflectance { get; set; }
      Description: Get or set the Floor Reflectance of the Space.
    double LatentHeatGainperPerson { get; set; }
      Description: Get or set the Latent Heat Gain per Person of the Space.
    double LightingCalculationWorkplane { get; set; }
      Description: Get or set the Lighting Calculation Workplane of the Space.
    BaseLoadOn LightingLoadUnit { get; set; }
      Description: Get or set the Lighting Load Unit of the Space.
    double LimitOffset { get; set; }
      Description: Get or set the Limit Offset of the Space.
    double NumberofPeople { get; set; }
      Description: Get or set the Number of People of the Space.
    OccupancyUnit OccupancyUnit { get; set; }
      Description: Get or set the Occupancy Unit of the Space.
    bool Occupiable { get; }
      Description: Reports whether this zone is Occupiable or not.
    double OutdoorAirflow { get; }
      Description: Get the Outdoor Airflow of the Space.
    OutdoorAirFlowStandard OutdoorAirFlowStandard { get; }
      Description: Get the OutdoorAirFlowStandard of the Space.
    double OutdoorAirPerArea { get; }
      Description: Get the Specified OutdoorAirPerArea of the Space.
    double OutdoorAirPerPerson { get; }
      Description: Get the Specified OutdoorAirPerPerson of the Space.
    bool Plenum { get; }
      Description: Reports whether this zone is Plenum or not.
    BaseLoadOn PowerLoadUnit { get; set; }
      Description: Get or set the Power Load Unit of the Space.
    ReturnAirflowType ReturnAirflow { get; set; }
      Description: Get or set the Return type of Supply Airflow of the Space.
    Room Room { get; }
      Description: Return the Room of the space.
    double SensibleHeatGainperPerson { get; set; }
      Description: Get or set the Sensible Heat Gain per Person of the Space.
    double SpaceCavityRatio { get; }
      Description: Get the Space Cavity Ratio of the Space.
    MEPSpaceConstruction SpaceConstruction { get; }
      Description: Get the Space Construction of the Space.
    SpaceType SpaceType { get; set; }
      Description: Get or set the Space type of the Space.
    ElementId SpaceTypeId { get; set; }
      Description: Get or set the Space type element of the Space.
    double UnboundedHeight { get; }
      Description: Get the Unbounded Height of the Space.
    Level UpperLimit { get; set; }
      Description: Get or set the Upper Limit of the Space.
    double Volume { get; }
      Description: Get the Volume of the Space.
    double WallReflectance { get; set; }
      Description: Get or set the Wall Reflectance of the Space.
    Zone Zone { get; }
      Description: Reports this space belong to which Zone.

  METHODS:
    bool IsPointInSpace(XYZ point)
      Description: Determines if a point lies within the volume of the Space.
      @point: Point to be checked.
      Throws ArgumentNullException: Thrown when the point is .
      Throws ArgumentException: The coordinates of the point is not a number.

--------------------------------------------------------------------------------

[CLASS] SpaceFilter
Full Name: Autodesk.Revit.DB.Mechanical.SpaceFilter
Description: A filter used to match spaces.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new SpaceFilter()
      Description: Constructs a filter which matches only spaces.

--------------------------------------------------------------------------------

[CLASS] SpaceSet
Full Name: Autodesk.Revit.DB.Mechanical.SpaceSet
Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new SpaceSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Space item)
    int Erase(Space item)
    SpaceSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Space item)
    SpaceSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SpaceSetIterator
Full Name: Autodesk.Revit.DB.Mechanical.SpaceSetIterator
Description: An iterator to a set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new SpaceSetIterator()
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

[CLASS] SpaceTag
Full Name: Autodesk.Revit.DB.Mechanical.SpaceTag
Description: Provides access to the space tag in Autodesk Revit.
Remarks: The space Tag object can be queried for space information.
Inherits: SpatialElementTag

  PROPERTIES:
    Space Space { get; }
      Description: The space that the tag is associated with.
    SpaceTagType SpaceTagType { get; set; }
      Description: The tag type.

--------------------------------------------------------------------------------

[CLASS] SpaceTagFilter
Full Name: Autodesk.Revit.DB.Mechanical.SpaceTagFilter
Description: A filter used to match space tags.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new SpaceTagFilter()
      Description: Constructs a filter which matches only spaces.

--------------------------------------------------------------------------------

[CLASS] SpaceTagType
Full Name: Autodesk.Revit.DB.Mechanical.SpaceTagType
Description: An object that represents a Space Tag style.
Inherits: FamilySymbol

--------------------------------------------------------------------------------

[ENUM] SpaceType
Full Name: Autodesk.Revit.DB.Mechanical.SpaceType
Description: An enumerated type listing all the possible space types for a space object.
Inherits: Enum

  Values:
    - kActiveStorage = 0
    - kActiveStorageHospitalOrHealthcare = 1
    - kAirOrTrainOrBusBaggageArea = 2
    - kAirportConcourse = 3
    - kAtriumEachAdditionalFloor = 4
    - kAtriumFirstThreeFloors = 5
    - kAudienceOrSeatingAreaPenitentiary = 6
    - kAudienceOrSeatingAreaExerciseCenter = 7
    - kAudienceOrSeatingAreaGymnasium = 8
    - kAudienceOrSeatingAreaSportsArena = 9
    - kAudienceOrSeatingAreaConventionCenter = 10
    - kAudienceOrSeatingAreaMotionPictureTheatre = 11
    - kAudienceOrSeatingAreaPerformingArtsTheatre = 12
    - kAudienceOrSeatingAreaReligious = 13
    - kAudienceOrSeatingAreaPoliceOrFireStations = 14
    - kAudienceOrSeatingAreaCourtHouse = 15
    - kAudienceOrSeatingAreaAuditorium = 16
    - kBankCustomerArea = 17
    - kBankingActivityAreaOffice = 18
    - kBarberAndBeautyParlor = 19
    - kCardFileAndCataloguingLibrary = 20
    - kClassroomOrLectureOrTrainingPenitentiary = 21
    - kClassroomOrLectureOrTraining = 22
    - kConfinementCellsPenitentiary = 23
    - kConfinementCellsCourtHouse = 24
    - kConferenceMeetingOrMultipurpose = 25
    - kCorridorOrTransition = 26
    - kCorridorOrTransitionManufacturingFacility = 27
    - kCorridorsWithPatientWaitingExamHospitalOrHealthcare = 28
    - kCourtSportsAreaSportsArena = 29
    - kCourtroomCourtHouse = 30
    - kDepartmentStoreSalesAreaRetail = 31
    - kDetailedManufacturingFacility = 32
    - kDiningArea = 33
    - kDiningAreaHotel = 34
    - kDiningAreaFamilyDining = 35
    - kDiningAreaLoungeOrLeisureDining = 36
    - kDiningAreaMotel = 37
    - kDiningAreaTransportation = 38
    - kDiningAreaPenitentiary = 39
    - kDiningAreaCivilServices = 40
    - kDormitoryBedroom = 41
    - kDormitoryStudyHall = 42
    - kDressingOrLockerOrFittingRoomGymnasium = 43
    - kDressingOrLockerOrFittingRoomCourtHouse = 44
    - kDressingOrLockerOrFittingRoomPerformingArtsTheatre = 45
    - kDressingOrLockerOrFittingRoomAuditorium = 46
    - kDressingOrLockerOrFittingRoomExerciseCenter = 47
    - kElectricalOrMechanical = 48
    - kElevatorLobbies = 49
    - kEmergencyHospitalOrHealthcare = 50
    - kEquipmentRoomManufacturingFacility = 51
    - kExamOrTreatmentHospitalOrHealthcare = 52
    - kExerciseAreaExerciseCenter = 53
    - kExerciseAreaGymnasium = 54
    - kExhibitSpaceConventionCenter = 55
    - kFellowshipHallReligiousBuildings = 56
    - kFineMaterialWarehouse = 57
    - kFineMerchandiseSalesAreaRetail = 58
    - kFireStationEngineRoomPoliceOrFireStation = 59
    - kFoodPreparation = 60
    - kGarageServiceOrRepairAutomotiveFacility = 61
    - kGeneralHighBayManufacturingFacility = 62
    - kGeneralLowBayManufacturingFacility = 63
    - kGeneralExhibitionMuseum = 64
    - kHospitalNurseryHospitalOrHealthcare = 65
    - kHospitalOrMedicalSuppliesHospitalOrHealthcare = 66
    - kHospitalOrRadiologyHospitalOrHealthcare = 67
    - kHotelOrConferenceCenterConferenceOrMeeting = 68
    - kInactiveStorage = 69
    - kJudgesChambersCourtHouse = 70
    - kLaboratoryOffice = 71
    - kLaundryIroningAndSorting = 72
    - kLaundryWashingHospitalOrHealthcare = 73
    - kLibraryAudioVisualLibraryAudioVisual = 74
    - kLivingQuartersDormitory = 75
    - kLivingQuartersMotel = 76
    - kLivingQuartersHotel = 77
    - kLobby = 78
    - kLobbyReligiousBuildings = 79
    - kLobbyMotionPictureTheatre = 80
    - kLobbyAuditorium = 81
    - kLobbyPerformingArtsTheatre = 82
    - kLobbyPostOffice = 83
    - kLobbyHotel = 84
    - kLoungeOrRecreation = 85
    - kMallConcourseSalesAreaRetail = 86
    - kMassMerchandisingSalesAreaRetail = 87
    - kMediumOrBulkyMaterialWarehouse = 88
    - kMerchandisingSalesAreaRetail = 89
    - kMuseumAndGalleryStorage = 90
    - kNurseStationHospitalOrHealthcare = 91
    - kOfficeEnclosed = 92
    - kOfficeOpenPlan = 93
    - kOfficeCommonActivityAreasInactiveStorage = 94
    - kOperatingRoomHospitalOrHealthcare = 95
    - kOtherTelevisedPlayingAreaSportsArena = 96
    - kParkingAreaAttendantOnlyParkingGarage = 97
    - kParkingAreaPedestrianParkingGarage = 98
    - kPatientRoomHospitalOrHealthcare = 99
    - kPersonalServicesSalesAreaRetail = 100
    - kPharmacyHospitalOrHealthcare = 101
    - kPhysicalTherapyHospitalOrHealthcare = 102
    - kPlayingAreaGymnasium = 103
    - kPlenum = 104
    - kPoliceStationLaboratoryPoliceOrFireStations = 105
    - kPublicAndStaffLoungeHospitalOrHealthcare = 106
    - kReadingAreaLibrary = 107
    - kReceptionOrWaitingTransportation = 108
    - kReceptionOrWaitingMotel = 109
    - kReceptionOrWaitingHotel = 110
    - kRecoveryHospitalOrHealthcare = 111
    - kRestorationMuseum = 112
    - kRestrooms = 113
    - kRingSportsAreaSportsArena = 114
    - kSleepingQuartersPoliceOrFireStation = 116
    - kSortingAreaPostOffice = 117
    - kSpecialtyStoreSalesAreaRetail = 118
    - kStacksLibrary = 119
    - kStairsInactive = 120
    - kStairway = 121
    - kSupermarketSalesAreaRetail = 122
    - kTerminalTicketCounterTransportation = 123
    - kWorkshopWorkshop = 124
    - kWorshipPulpitChoirReligious = 125
    - kNoOfSpaceTypes = 126
    - NoSpaceType = -1

--------------------------------------------------------------------------------

[ENUM] SystemCalculationLevel
Full Name: Autodesk.Revit.DB.Mechanical.SystemCalculationLevel
Description: Enumerated type listing flags that can toggle on or off certain calculations related to MEP systems.
Inherits: Enum

  Values:
    - None = 0
    - Flow = 1
    - Volume = 2
    - Performance = 4
    - All = -1

--------------------------------------------------------------------------------

[CLASS] SystemZoneData
Full Name: Autodesk.Revit.DB.Mechanical.SystemZoneData
Description: Represents the specific domain requirements for a system-zone used in MEP design.
Remarks: A system-zone is used to specify what parts of a building are served by specific equipment, air systems and water loops without having to physically model them. A system-zone is represented as a GenericZone element with a domain data of type SystemZoneData, which contains specific domain requirements for the purpose of analysis.
Inherits: GenericZoneDomainData

  PROPERTIES:
    ElementId ZoneEquipmentId { get; set; }
      Description: The id of the zone equipment related to the zone.

  METHODS:
    static SystemZoneData Create()
      Description: Creates a new instance of a system-zone data domain class.
      Returns: The newly created data domain instance.

--------------------------------------------------------------------------------

[CLASS] SystemZoneElementType
Full Name: Autodesk.Revit.DB.Mechanical.SystemZoneElementType
Description: Represents an element type for a system-zone element.
Inherits: ElementType

  PROPERTIES:
    double AirChangesPerHour { get; set; }
      Description: The air changes per hour.
    double CoolingAirTemperature { get; set; }
      Description: The cooling air temperature in unit Kelvin (K).
    double CoolingSetPoint { get; set; }
      Description: The cooling temperature set point in unit Kelvin (K).
    double DehumidificationSetPoint { get; set; }
      Description: The humidification set point as a number between 0 and 1.
    ZoneGeometricDefinition GeometricDefinition { get; }
      Description: The geometric definition for this element type.
    double HeatingAirTemperature { get; set; }
      Description: The heating air temperature in unit Kelvin (K).
    double HeatingSetPoint { get; set; }
      Description: The heating temperature set point in unit Kelvin (K).
    double HumidificationSetPoint { get; set; }
      Description: The humidification set point as a number between 0 and 1.
    double OutdoorAirPerArea { get; set; }
      Description: The outdoor air per area in unit feet per second.
    double OutdoorAirPerPerson { get; set; }
      Description: The outdoor air in unit cubic feet per second per person.
    bool UseDehumidificationSetPoint { get; set; }
      Description: Use the dehumidification set point.
    bool UseHumidificationSetPoint { get; set; }
      Description: Use the humidification set point.

  METHODS:
    static SystemZoneElementType CreateSketchBased(Document doc, string name)
      Description: Creates a new element type for sketch-based system-zone elements and adds it to the document.
      @doc: The document where the new type is created.
      @name: The name of new type.
      Returns: The newly created system-zone element type.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string. -or- This name is already used by an existing system-zone element type in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static SystemZoneElementType CreateSpaceBased(Document doc, string name)
      Description: Creates a new element type for space-based system-zone elements and adds it to the document.
      @doc: The document where the new type is created.
      @name: The name of new type.
      Returns: The newly created system-zone element type.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string. -or- This name is already used by an existing system-zone element type in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[ENUM] WaterChillerType
Full Name: Autodesk.Revit.DB.Mechanical.WaterChillerType
Description: The type of water chiller.
Inherits: Enum

  Values:
    - AirCooled = 0
    - WaterCooled = 1

--------------------------------------------------------------------------------

[CLASS] WaterLoopData
Full Name: Autodesk.Revit.DB.Mechanical.WaterLoopData
Description: Represents the data and parameters of analytical water loop.
Implements: IDisposable

  PROPERTIES:
    WaterChillerType ChillerType { get; set; }
      Description: The type of water chiller. Note this property change would reset the condenser water loop.
    ElementId CondenserWaterLoopId { get; set; }
      Description: The water loop element id for the water cooled chiller.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    WaterLoopType WaterLoopType { get; set; }
      Description: The type of water loop. Note this property change would reset other properties.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] WaterLoopType
Full Name: Autodesk.Revit.DB.Mechanical.WaterLoopType
Description: The type of water loop.
Inherits: Enum

  Values:
    - Undefined = 0
    - ChilledWater = 1
    - CondenserWater = 2
    - HotWater = 3
    - VRF = 4

--------------------------------------------------------------------------------

[CLASS] Zone
Full Name: Autodesk.Revit.DB.Mechanical.Zone
Description: A zone is a collection of one or more spaces.
Remarks: The concept of zones is central to the way in which engineers design HVAC systems. When you are designing HVAC systems, you relate to zones as spaces that are under the same thermostatic control. Conceptually, zones are an arbitrary set of areas or volumes within a building that is controlled by one thermostat. An area based load is a collection of one or more electrical load areas. When it has the AreaBasedLoadData, it is an area based load, otherwise, it is a zone.
Inherits: Element

  PROPERTIES:
    double Area { get; }
      Description: Get the Area of the Zone.
    CurveArray Boundary { get; }
      Description: Returns the boundary of the Zone.
    string Name { set; }
      Description: Get or Set the Name of the Zone.
    Phase Phase { get; }
      Description: Get the Phase of the Zone.
    SpaceSet Spaces { get; }
      Description: Get the Spaces of the Zone.

  METHODS:
    static Zone CreateAreaBasedLoad(Document doc, string name, ElementId levelId, ElementId phaseId)
      Description: Creates a new instance of an area based load and adds it to the document.
      @doc: The document where the element will be created and added.
      @name: The name of the area based load to be created.
      @levelId: The base level on which the area based load will be created.
      @phaseId: The associative phase on which the area based load is to exist.
      Returns: The newly created area based load.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string. -or- The ElementId levelId is not a Level. -or- The id does not represent a valid phase.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ZoneElementDomainData GetDomainData()
      Description: Gets the domain data for the zone.
      Returns: Returns a pointer to the base class for specific domain requirements for the zone.

--------------------------------------------------------------------------------

[CLASS] ZoneElementDomainData
Full Name: Autodesk.Revit.DB.Mechanical.ZoneElementDomainData
Description: A base class for specific domain requirements for a zone.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ZoneEquipment
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipment
Description: Represents an early-stage equipment placeholder that provides heating or cooling to part of air system or water loop.
Remarks: A zone equipment is different from physical equipment. Depending on its behavior type, it may be mapped to multiple physical equipment later.
Inherits: Element

  METHODS:
    static ZoneEquipment Create(Document document, string name)
      Description: Creates a new zone equipment
      @document: The document where the new element will be created.
      @name: The name of new zone equipment. The actual name may be post-fixed if already exists.
      Returns: The newly created zone equipment.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ISet<ElementId> GetAssociatedZoneEquipment(Document document, ISet<ElementId> spaces)
      Description: Gets the associated zone equipment of all specified analytical spaces.
      @document: The document where the analytical spaces and zone equipment exist.
      @spaces: The specified analytical spaces.
      Returns: All associated zone equipment, either explicitly assigned or implicitly assigned via system-zone.
      Throws ArgumentNullException: A non-optional argument was null
    static ISet<ElementId> GetAssociatedZoneEquipment(Document document, ElementId spaceElementId)
      Description: Gets the associated zone equipment of the specified analytical space.
      @document: The document where the analytical spaces and zone equipment exist.
      @spaceElementId: The specified analytical spaces.
      Returns: All associated zone equipment, either explicitly assigned or implicitly assigned via system-zone.
      Throws ArgumentNullException: A non-optional argument was null
    ZoneEquipmentData GetZoneEquipmentData()
      Description: Gets the zone equipment data.
    static void MoveSpaceToEquipment(Document document, ISet<ElementId> analyticalSpaceSet, ElementId originalZoneEquipmentId, ElementId targetZoneEquipmentId)
      Description: Moves the selected analytical spaces from the identified zone equipment to another target zone equipment.
      @document: The document where the zone equipment and the analytical spaces exist.
      @analyticalSpaceSet: The specified analytical spaces to move.
      @originalZoneEquipmentId: The original equipment where the analytical spaces will be removed. If passing invalidElementId, the existing zone equipment is not removed.
      @targetZoneEquipmentId: The target zone equipment where the analytical spaces will be associated. If passing invalidElementId, the analytical spaces will not be assigned to any new zone equipment.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ZoneEquipmentBehavior
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipmentBehavior
Description: The behavior of zone equipment associated with spaces.
Inherits: Enum

  Values:
    - OnePerSpace = 0
    - GroupSpaces = 1

--------------------------------------------------------------------------------

[CLASS] ZoneEquipmentData
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipmentData
Description: Represents the data and parameters of analytical zone equipment.
Implements: IDisposable

  PROPERTIES:
    ElementId AirSystemId { get; set; }
      Description: The air system used for this zone equipment, if applicable.
    ElementId ChilledWaterLoopId { get; set; }
      Description: The chilled water loop used for the chilled water option of cooling coil.
    ElementId CondenserWaterLoopId { get; set; }
      Description: The condenser water loop used for the direction expansion water cooled option of cooling coil.
    AirCoolingCoilType CoolingCoilType { get; set; }
      Description: The type of cooling coil. Note this property change would reset the chilled water loop.
    ZoneEquipmentBehavior EquipmentBehavior { get; set; }
      Description: The behavior of how zone equipment is allocated with assigned spaces.
    ZoneEquipmentHvacType EquipmentType { get; set; }
      Description: The type of zone equipment. Note this property would reset other properties.
    AirHeatingCoilType HeatingCoilType { get; set; }
      Description: The type of heating coil. Note this property change would reset the hot water loop.
    ElementId HotWaterLoopId { get; set; }
      Description: The water loop element id for the hot-water heating coil.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId VRFLoopId { get; set; }
      Description: The Varible Refrigerant Flow loop for the VRF fan coil equipment type.

  METHODS:
    void Dispose()
    bool IsDataCompleted()
      Description: Is the required data completed for this zone equipment?

--------------------------------------------------------------------------------

[ENUM] ZoneEquipmentHvacType
Full Name: Autodesk.Revit.DB.Mechanical.ZoneEquipmentHvacType
Description: The type of zone equipment.
Inherits: Enum

  Values:
    - Undefined = 0
    - ChilledBeamActive = 1
    - FourPipeFanCoil = 2
    - PackagedTerminalAirConditioner = 3
    - PackagedTerminalHeatPump = 4
    - ParallelFanPoweredBox = 5
    - VAVBox = 6
    - CAVBox = 9
    - RadiantPanel = 10
    - SeriesFanPoweredBox = 11
    - UnitHeater = 12
    - UnitVentilator = 13
    - WaterSourceHeatPump = 14
    - ChilledBeamPassive = 15
    - Unconditioned = 16
    - VRFFanCoil = 17

--------------------------------------------------------------------------------

