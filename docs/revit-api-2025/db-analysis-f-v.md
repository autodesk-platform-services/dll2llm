# Autodesk.Revit.DB.Analysis

NAMESPACE: Autodesk.Revit.DB.Analysis
--------------------------------------------------------------------------------

[CLASS] FieldDomainPoints
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPoints
Description: Abstract base class for various classes of field domain points
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] FieldDomainPointsByParameter
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPointsByParameter
Description: Represents a set of one-dimensional point coordinates (defined usually on curve)
Inherits: FieldDomainPoints

  CONSTRUCTORS:
    new FieldDomainPointsByParameter(IList<double> points)
      Description: Creates object from an array of one-dimensional point coordinates
      @points: Array of one-dimensional point coordinates representing domain points (using raw parameters when on a curve)
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] FieldDomainPointsByUV
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPointsByUV
Description: Represents a set of two-dimensional point coordinates (defined usually on surface)
Inherits: FieldDomainPoints

  CONSTRUCTORS:
    new FieldDomainPointsByUV(IList<UV> points, ICollection<double> uCoordinates, ICollection<double> vCoordinates)
      Description: Creates object from an array of two-dimensional point coordinates
      @points: Array of two-dimensional point coordinates representing domain points (usually on surface)
      @uCoordinates: Set of u coordinates at which to draw grid lines on the surface
      @vCoordinates: Set of v coordinates at which to draw grid lines on the surface
      Throws ArgumentNullException: A non-optional argument was null
    new FieldDomainPointsByUV(IList<UV> points)
      Description: Creates object from an array of two-dimensional point coordinates
      @points: Array of two-dimensional point coordinates representing domain points (usually on surface)
      Throws ArgumentNullException: A non-optional argument was null

  METHODS:
    void SetGridCoordinates(ICollection<double> uCoordinates, ICollection<double> vCoordinates)
      Description: Set u and v coordinates that specify a grid on the surface. The display of the grid is controlled by AnalysisDisplayColoredSurfaceSettings::getShowGridLines(). If AnalysisDisplayColoredSurfaceSettings::getShowGridLines() returns true and both sets are empty then a grid will be displayed using a default spacing; if only one of the sets is non-empty, then only the corresponding set of grid lines will be displayed, i.e. the grid will consist solely of parallel lines at the specified coordinates.
      @uCoordinates: Set of u coordinates at which to draw grid lines
      @vCoordinates: Set of v coordinates at which to draw grid lines
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] FieldDomainPointsByXYZ
Full Name: Autodesk.Revit.DB.Analysis.FieldDomainPointsByXYZ
Description: Represents a set of three-dimensional point coordinates
Inherits: FieldDomainPoints

  CONSTRUCTORS:
    new FieldDomainPointsByXYZ(IList<XYZ> points)
      Description: Creates object from an array of three-dimensional point coordinates
      @points: Array of three-dimensional point coordinates representing domain points
      Throws ArgumentException: Thrown when supplied array points contain too many members (over 1000)
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] FieldValues
Full Name: Autodesk.Revit.DB.Analysis.FieldValues
Description: Contains values corresponding to domain points. Each domain point may have an array of values, each corresponding to a separate "measurement" for which this value was calculated.
Implements: IDisposable

  CONSTRUCTORS:
    new FieldValues(FieldValues otherObject)
      Description: Creates a copy of the given FieldValues instance.
      Throws ArgumentNullException: A non-optional argument was null
    new FieldValues(IList<VectorAtPoint> vectorAtPoint)
      Description: Creates object from an array of domain point vectors
      @vectorAtPoint: Array of vectors, each corresponding to a domain point
      Throws ArgumentException: Members of vectorAtPoint contain different numbers of measurements
      Throws ArgumentNullException: A non-optional argument was null
    new FieldValues(IList<ValueAtPoint> valueAtPoint, XYZ unitDirection)
      Description: Creates object from an array of domain point values
      @valueAtPoint: Array of values, each corresponding to a domain point
      @unitDirection: Unit vector that gives the same direction for values (for diagrams)
      Throws ArgumentException: Members of valueAtPoint contain different numbers of measurements -or- unitDirection is not a unit vector
      Throws ArgumentNullException: A non-optional argument was null
    new FieldValues(IList<ValueAtPoint> valueAtPoint)
      Description: Creates object from an array of domain point values
      @valueAtPoint: Array of values, each corresponding to a domain point
      Throws ArgumentException: valueAtPoint array contains members with different numbers of measurements
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] gbXMLBuildingHVACSystem
Full Name: Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem
Description: Enumerations for gbXML (Green Building XML) format, used for energy analysis, schema version 0.34.
Remarks: This enumeration corresponds to the HVAC System attribute in gbXML and is used to specify the Building HVAC System.
Inherits: Enum

  Values:
    - TwelveSEERSPointNineAFUESplitPackagedGasFiveToElevenTon = 0
    - ElevenPointThreeEERPackagedVAVEightyFourPointFourPercentBoilerHeating = 1
    - CentralVAVHWHeatChillerFivePointNinetySixCOPBoilersEightyFourPoint5Eff = 2
    - FourPipeFanCoilSystemChillerFivePointNinetySixCOPBoilersEightFourPointFiveEff = 3
    - CentralVAVElectricResistanceHeatChillerFivePointNinetySixCOP = 4
    - TwelveSEERSevenPointSevenHSPFSplitPackagedHeatPump = 5
    - TwoPipeFanCoilSystemChillerFivePointNinetySixCOPBoilersEightyFourPointFiveEff = 6
    - TwelveSEEREightPointThreeHSPFPackagedTerminalHeatPumpPTAC = 7
    - ResidentialSeventeenSEERNinePointSixHSPFSplitHPLessThanFivePointFiveTon = 8
    - UnderfloorAirDistribution = 9
    - ResidentialFourteenSEERPointNineAFUESplitPackagedGasLessThanFivePointFiveTon = 10
    - ResidentialFourteenSEEREightPointThreeHSPFSplitPackagedHeatPump = 11
    - NoOfHVACSystemEnums = 12

--------------------------------------------------------------------------------

[ENUM] gbXMLBuildingOperatingSchedule
Full Name: Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule
Description: Enumerations for gbXML (Green Building XML) format, used for energy analysis, schema version 0.34.
Remarks: This enumeration corresponds to the buildingType attribute in gbXML and is used to specify the building operating schedule.
Inherits: Enum

  Values:
    - DefaultOperatingSchedule = 0
    - TwentyFourHourSevenDayFacility = 1
    - TwentyFourHourHourSixDayFacility = 2
    - TwentyFourHourHourFiveDayFacility = 3
    - TwelveHourSevenDayFacility = 4
    - TwelveHourSixDayFacility = 5
    - TwelveHourFiveDayFacility = 6
    - KindergartenThruTwelveGradeSchool = 7
    - YearRoundSchool = 8
    - TheaterPerformingArts = 9
    - Worship = 10
    - NoOfOperatingScheduleEnums = 11

--------------------------------------------------------------------------------

[ENUM] gbXMLBuildingType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLBuildingType
Description: Enumerations for gbXML (Green Building XML) format, used for energy analysis, schema version 0.34.
Inherits: Enum

  Values:
    - AutomotiveFacility = 0
    - ConventionCenter = 1
    - Courthouse = 2
    - DiningBarLoungeOrLeisure = 3
    - DiningCafeteriaFastFood = 4
    - DiningFamily = 5
    - Dormitory = 6
    - ExerciseCenter = 7
    - FireStation = 8
    - Gymnasium = 9
    - HospitalOrHealthcare = 10
    - Hotel = 11
    - Library = 12
    - Manufacturing = 13
    - Motel = 14
    - MotionPictureTheatre = 15
    - MultiFamily = 16
    - Museum = 17
    - Office = 18
    - ParkingGarage = 19
    - Penitentiary = 20
    - PerformingArtsTheater = 21
    - PoliceStation = 22
    - PostOffice = 23
    - ReligiousBuilding = 24
    - Retail = 25
    - SchoolOrUniversity = 26
    - SingleFamily = 27
    - SportsArena = 28
    - TownHall = 29
    - Transportation = 30
    - Warehouse = 31
    - Workshop = 32
    - NoOfBuildingTypes = 33
    - CustomizeBuildingType = -2
    - NoBuildingType = -1

--------------------------------------------------------------------------------

[ENUM] gbXMLConditionType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLConditionType
Description: This enumeration corresponds to the conditionType attribute in gbXML. The enumerated attribute identifies the type of heating, cooling, or ventilation the space has.
Inherits: Enum

  Values:
    - Heated = 0
    - Cooled = 1
    - HeatedAndCooled = 2
    - Unconditioned = 3
    - Vented = 4
    - NaturallyVentedOnly = 5
    - NoOfConditionTypes = 6
    - NoConditionType = -1

--------------------------------------------------------------------------------

[ENUM] gbXMLExportBuildingEnvelope
Full Name: Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope
Description: Indicates the determination method for the building envelope
Inherits: Enum

  Values:
    - UseFunctionParameter = 0
    - IdentifyExteriorElements = 1

--------------------------------------------------------------------------------

[ENUM] gbXMLExportComplexity
Full Name: Autodesk.Revit.DB.Analysis.gbXMLExportComplexity
Description: This enumeration specifies the level of detail of the exported analytical energy model in gbXML. Complex means that Curtain Walls and Curtain Systems are exported as several openings, panel by panel; a curtain wall with 50 panels gets exported as 50 openings. Simple means that one "huge" opening with the total opening area equal to the 50 panels is exported. This is more appropriate for most energy analysis. Mullions mean that Mullions in Curtain Walls and Systems are exported as shading surfaces. A "simplified" analytical shading surface is produced from a mullion based on its centerline, thickness and offset.
Inherits: Enum

  Values:
    - Simple = 0
    - SimpleWithShadingSurfaces = 1
    - Complex = 2
    - ComplexWithShadingSurfaces = 3
    - ComplexWithMullionsAndShadingSurfaces = 4

--------------------------------------------------------------------------------

[ENUM] gbXMLOpeningType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLOpeningType
Description: This enumeration corresponds to the openingType attribute in gbXML and identifies the type of opening defined.
Inherits: Enum

  Values:
    - FixedWindow = 0
    - OperableWindow = 1
    - FixedSkylight = 2
    - OperableSkylight = 3
    - SlidingDoor = 4
    - NonSlidingDoor = 5
    - OpeningAir = 6
    - NoOfOpeningTypes = 7

--------------------------------------------------------------------------------

[ENUM] gbXMLServiceType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLServiceType
Description: This enumeration corresponds to the systemType attribute in gbXML and is used for specifying the service for the building or space.
Inherits: Enum

  Values:
    - CentralHeatingRadiators = 0
    - CentralHeatingConvectors = 1
    - CentralHeatingRadiantFloor = 2
    - CentralHeatingHotAir = 3
    - OtherRoomHeater = 4
    - RadiantHeaterFlue = 5
    - RadiantHeaterNoFlue = 6
    - RadiantHeaterMultiburner = 7
    - ForcedConvectionHeaterFlue = 8
    - ForcedConvectionHeaterNoFlue = 9
    - VAVSingleDuct = 10
    - VAVDualDuct = 11
    - VAVIndoorPackagedCabinet = 12
    - VAVTerminalReheat = 13
    - FanCoilSystem = 14
    - InductionSystem = 15
    - ConstantVolumeFixedOA = 16
    - ConstantVolumeVariableOA = 17
    - ConstantVolumeTerminalReheat = 18
    - MultizoneHotDeckColdDeck = 19
    - ConstantVolumeDualDuct = 20
    - RadiantCooledCeilings = 21
    - ActiveChilledBeams = 22
    - WaterLoopHeatPump = 23
    - VariableRefrigerantFlow = 24
    - SplitSystemsWithNaturalVentilation = 25
    - SplitSystemsWithMechanicalVentilation = 26
    - SplitSystemsWithMechanicalVentilationWithCooling = 27
    - NoOfServiceTypes = 28
    - NoServiceType = -1

--------------------------------------------------------------------------------

[ENUM] gbXMLSpaceType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLSpaceType
Description: This enumeration corresponds to the spaceType attribute in gbXML. The enumerated attribute identifies the type of space defined and allows to better approximate the actual internal loads and schedules associated with the defined space type.
Inherits: Enum

  Values:
    - ActiveStorage = 0
    - ActiveStorageHospitalOrHealthcare = 1
    - AirOrTrainOrBusBaggageArea = 2
    - AirportConcourse = 3
    - AtriumEachAdditionalFloor = 4
    - AtriumFirstThreeFloors = 5
    - AudienceOrSeatingAreaPenitentiary = 6
    - AudienceOrSeatingAreaExerciseCenter = 7
    - AudienceOrSeatingAreaGymnasium = 8
    - AudienceOrSeatingAreaSportsArena = 9
    - AudienceOrSeatingAreaConventionCenter = 10
    - AudienceOrSeatingAreaMotionPictureTheatre = 11
    - AudienceOrSeatingAreaPerformingArtsTheatre = 12
    - AudienceOrSeatingAreaReligious = 13
    - AudienceOrSeatingAreaPoliceOrFireStations = 14
    - AudienceOrSeatingAreaCourtHouse = 15
    - AudienceOrSeatingAreaAuditorium = 16
    - BankCustomerArea = 17
    - BankingActivityAreaOffice = 18
    - BarberAndBeautyParlor = 19
    - CardFileAndCataloguingLibrary = 20
    - ClassroomOrLectureOrTrainingPenitentiary = 21
    - ClassroomOrLectureOrTraining = 22
    - ConfinementCellsPenitentiary = 23
    - ConfinementCellsCourtHouse = 24
    - ConferenceMeetingOrMultipurpose = 25
    - CorridorOrTransition = 26
    - CorridorOrTransitionManufacturingFacility = 27
    - CorridorsWithPatientWaitingExamHospitalOrHealthcare = 28
    - CourtSportsAreaSportsArena = 29
    - CourtroomCourtHouse = 30
    - DepartmentStoreSalesAreaRetail = 31
    - DetailedManufacturingFacility = 32
    - DiningArea = 33
    - DiningAreaHotel = 34
    - DiningAreaFamilyDining = 35
    - DiningAreaLoungeOrLeisureDining = 36
    - DiningAreaMotel = 37
    - DiningAreaTransportation = 38
    - DiningAreaPenitentiary = 39
    - DiningAreaCivilServices = 40
    - DormitoryBedroom = 41
    - DormitoryStudyHall = 42
    - DressingOrLockerOrFittingRoomGymnasium = 43
    - DressingOrLockerOrFittingRoomCourtHouse = 44
    - DressingOrLockerOrFittingRoomPerformingArtsTheatre = 45
    - DressingOrLockerOrFittingRoomAuditorium = 46
    - DressingOrLockerOrFittingRoomExerciseCenter = 47
    - ElectricalOrMechanical = 48
    - ElevatorLobbies = 49
    - EmergencyHospitalOrHealthcare = 50
    - EquipmentRoomManufacturingFacility = 51
    - ExamOrTreatmentHospitalOrHealthcare = 52
    - ExerciseAreaExerciseCenter = 53
    - ExerciseAreaGymnasium = 54
    - ExhibitSpaceConventionCenter = 55
    - FellowshipHallReligiousBuildings = 56
    - FineMaterialWarehouse = 57
    - FineMerchandiseSalesAreaRetail = 58
    - FireStationEngineRoomPoliceOrFireStation = 59
    - FoodPreparation = 60
    - GarageServiceOrRepairAutomotiveFacility = 61
    - GeneralHighBayManufacturingFacility = 62
    - GeneralLowBayManufacturingFacility = 63
    - GeneralExhibitionMuseum = 64
    - HospitalNurseryHospitalOrHealthcare = 65
    - HospitalOrMedicalSuppliesHospitalOrHealthcare = 66
    - HospitalOrRadiologyHospitalOrHealthcare = 67
    - HotelOrConferenceCenterConferenceOrMeeting = 68
    - InactiveStorage = 69
    - JudgesChambersCourtHouse = 70
    - LaboratoryOffice = 71
    - LaundryIroningAndSorting = 72
    - LaundryWashingHospitalOrHealthcare = 73
    - LibraryAudioVisualLibraryAudioVisual = 74
    - LivingQuartersDormitory = 75
    - LivingQuartersMotel = 76
    - LivingQuartersHotel = 77
    - Lobby = 78
    - LobbyReligiousBuildings = 79
    - LobbyMotionPictureTheatre = 80
    - LobbyAuditorium = 81
    - LobbyPerformingArtsTheatre = 82
    - LobbyPostOffice = 83
    - LobbyHotel = 84
    - LoungeOrRecreation = 85
    - MallConcourseSalesAreaRetail = 86
    - MassMerchandisingSalesAreaRetail = 87
    - MediumOrBulkyMaterialWarehouse = 88
    - MerchandisingSalesAreaRetail = 89
    - MuseumAndGalleryStorage = 90
    - NurseStationHospitalOrHealthcare = 91
    - OfficeEnclosed = 92
    - OfficeOpenPlan = 93
    - OfficeCommonActivityAreasInactiveStorage = 94
    - OperatingRoomHospitalOrHealthcare = 95
    - OtherTelevisedPlayingAreaSportsArena = 96
    - ParkingAreaAttendantOnlyParkingGarage = 97
    - ParkingAreaPedestrianParkingGarage = 98
    - PatientRoomHospitalOrHealthcare = 99
    - PersonalServicesSalesAreaRetail = 100
    - PharmacyHospitalOrHealthcare = 101
    - PhysicalTherapyHospitalOrHealthcare = 102
    - PlayingAreaGymnasium = 103
    - Plenum = 104
    - PoliceStationLaboratoryPoliceOrFireStations = 105
    - PublicAndStaffLoungeHospitalOrHealthcare = 106
    - ReadingAreaLibrary = 107
    - ReceptionOrWaitingTransportation = 108
    - ReceptionOrWaitingMotel = 109
    - ReceptionOrWaitingHotel = 110
    - RecoveryHospitalOrHealthcare = 111
    - RestorationMuseum = 112
    - Restrooms = 113
    - RingSportsAreaSportsArena = 114
    - SleepingQuartersPoliceOrFireStation = 115
    - SortingAreaPostOffice = 116
    - SpecialtyStoreSalesAreaRetail = 117
    - StacksLibrary = 118
    - StairsInactive = 119
    - Stairway = 120
    - SupermarketSalesAreaRetail = 121
    - TerminalTicketCounterTransportation = 122
    - WorkshopWorkshop = 123
    - WorshipPulpitChoirReligious = 124
    - NoOfSpaceTypes = 125
    - CustomizeSpaceType = -2
    - NoSpaceType = -1

--------------------------------------------------------------------------------

[ENUM] gbXMLSurfaceType
Full Name: Autodesk.Revit.DB.Analysis.gbXMLSurfaceType
Description: This enumeration corresponds to the surfaceType attribute in gbXML and identifies the type of surface defined.
Inherits: Enum

  Values:
    - InteriorWall = 0
    - ExteriorWall = 1
    - Roof = 2
    - InteriorFloor = 3
    - ExposedFloor = 4
    - Shade = 5
    - UndergroundWall = 6
    - UndergroundSlab = 7
    - Ceiling = 8
    - SurfaceAir = 9
    - UndergroundCeiling = 10
    - RaisedFloor = 11
    - SlabOnGrade = 12
    - NoOfSurfaceTypes = 13

--------------------------------------------------------------------------------

[CLASS] GenericZone
Full Name: Autodesk.Revit.DB.Analysis.GenericZone
Description: Provides access to the GenericZone Element in Autodesk Revit.
Remarks: A generic zone is a tool that provides for a method of selecting elements that somehow come in contact with the zone object. A zone is a non-hierarchical structure of geometric information, area or volume definitions for the purpose of analysis. A generic zone will contain specific domain requirements provided at creation of the element.
Inherits: Element

  PROPERTIES:
    double LevelOffset { get; set; }
      Description: The offset distance from this zone to the associated level.

  METHODS:
    static GenericZone Create(Document doc, string name, GenericZoneDomainData domainData, ElementId levelId, IList<CurveLoop> curveLoops)
      Description: Creates a new instance of a generic zone and adds it to the document.
      @doc: The document where the element will be created and added.
      @name: The name of the generic zone to be created.
      @domainData: The specific domain requirements for the generic zone.
      @levelId: The base level on which the generic zone will be created.
      @curveLoops: The loops that define the lines, curves and areas that overlap or crosses the elements you want to belong to the zone. Multiple loops are allowed, they can be open or closed, but they should be on the same horizontal plane.
      Returns: The newly created generic zone.
      Throws ArgumentException: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- name is an empty string. -or- The ElementId levelId is not a Level. -or- The curve loops in the input array are empty. -or- The input curve loops do not all lie in the same horizontal plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    IList<CurveLoop> GetBoundaries()
      Description: Gets the boundaries for the generic zone.
      Returns: The generic zone boundaries.
    GenericZoneDomainData GetDomainData()
      Description: Gets the domain data for the generic zone.
      Returns: Returns a pointer to the base class for specific domain requirements for the generic zone.

--------------------------------------------------------------------------------

[CLASS] GenericZoneDomainData
Full Name: Autodesk.Revit.DB.Analysis.GenericZoneDomainData
Description: A base class for specific domain requirements for a generic zone.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] HVACLoadBuildingType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadBuildingType
Description: The type element of building.
Inherits: HVACLoadType

  PROPERTIES:
    string BuildingTypeName { get; set; }
      Description: The building type name.
    string ClosingTime { get; set; }
      Description: The closing time of the building type.
    string OpeningTime { get; set; }
      Description: The opening time of the building type.
    double UnoccupiedCoolingSetPoint { get; set; }
      Description: The unoccupied cooling set point of the building type with unit kelvin (K).

  METHODS:
    static HVACLoadBuildingType Create(Document document, string name)
      Description: Creates a building type element.
      @document: The document.
      @name: The building type name.
      Returns: The new building type.
      Throws ArgumentException: name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a building type name.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsNameUnique(string name)
      Description: Determines whether a potential building type name is unique.
      @name: The candidate name.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsNameUnique(Document document, string name)
      Description: Determines whether a potential building type name is unique.
      @document: The document.
      @name: The candidate name.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidTime(string hourMinute)
      Description: Check if the string can be parsed to a valid time for opening time and closing time. A valid string can be "16:30" or "4:30 PM";
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] HVACLoadConstructionClass
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass
Description: Enumerated type listing options for construction class for HVAC analysis.
Inherits: Enum

  Values:
    - LooseConstruction = 0
    - MediumConstruction = 1
    - TightConstruction = 2
    - NoneConstruction = 3

--------------------------------------------------------------------------------

[ENUM] HVACLoadLoadsReportType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType
Description: Enumerated type listing possible types of reports generated for HVAC loads.
Inherits: Enum

  Values:
    - NoReport = 0
    - SimpleReport = 1
    - StandardReport = 2
    - DetailedReport = 3

--------------------------------------------------------------------------------

[CLASS] HVACLoadSpaceType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadSpaceType
Description: The type element of space.
Inherits: HVACLoadType

  PROPERTIES:
    bool IsPlenum { get; }
      Description: True if the space type is plenum.
    string SpaceTypeName { get; set; }
      Description: The space type name.

  METHODS:
    static HVACLoadSpaceType Create(Document document, string name)
      Description: Creates a space type.
      @document: The document.
      @name: The space type name.
      Returns: The new space type.
      Throws ArgumentException: name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a space type name.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsNameUnique(string name)
      Description: Determines whether a potential space type name is unique.
      @name: The candidate name.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsNameUnique(Document document, string name)
      Description: Determines whether a potential space type name is unique.
      @document: The document.
      @name: The candidate name.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] HVACLoadType
Full Name: Autodesk.Revit.DB.Analysis.HVACLoadType
Description: The base class for building type and space type.
Inherits: Element

  PROPERTIES:
    double AirChangesPerHour { get; set; }
      Description: The air changes per hour.
    double AreaPerPerson { get; set; }
      Description: The area per person.
    double CoolingSetPoint { get; set; }
      Description: The cooling temperature set point in unit Kelvin (K).
    double DehumidificationSetPoint { get; set; }
      Description: The dehumidification set point as a number between 0 and 1.
    double HeatingSetPoint { get; set; }
      Description: The heating temperature set point in unit Kelvin (K).
    double HumidificationSetPoint { get; set; }
      Description: The humidification set point as a number between 0 and 1.
    double LatentHeatGainPerPerson { get; set; }
      Description: The latent heat gain per person.
    double LightingLoadDensity { get; set; }
      Description: The lighting load density.
    OutdoorAirFlowStandard OutdoorAirFlowStandard { get; set; }
      Description: The outdoor airflow standard.
    double OutdoorAirPerArea { get; set; }
      Description: The outdoor air per area.
    double OutdoorAirPerPerson { get; set; }
      Description: The outdoor air per person.
    double PlenumLighting { get; set; }
      Description: The percentage of plenum lighting contribution.
    double PowerLoadDensity { get; set; }
      Description: The power load density.
    double SensibleHeatGainPerPerson { get; set; }
      Description: The sensible heat gain per person.

--------------------------------------------------------------------------------

[CLASS] MassLevelData
Full Name: Autodesk.Revit.DB.Analysis.MassLevelData
Description: MassLevelData is a conceptual representation of an occupiable floor (Mass Floor) in a conceptual building model. It is defined by associating a particular level with a particular mass element in a Revit project.
Remarks: MassLevelData reports metrics, such as floor areas, related to conceptual space planning. MassLevelData contains information, such as ConceptualConstructionType, used as part of the Conceptual Energy Analytical model. The MassLevel data geometry is determined by combining all the geometry of a mass into a single geometry, and then taking the area of intersection with the level of the MassLevelData.
Inherits: Element

  PROPERTIES:
    ElementId ConceptualConstructionId { get; set; }
      Description: The ElementId of the conceptual construction associated with the MassLevelData (Mass Floor).
    bool ConceptualConstructionIsByEnergyData { get; set; }
      Description: Indicates if the ConceptualConstructionType of the MassLevelData (Mass Floor) is synchronized with the EnergyDataSettings or if it overrides those settings.
    ElementId MaterialId { get; set; }
      Description: The ElementId of the visualization material used for the MassLevelData (Mass Floor)
    MassSurfaceDataMaterialType MaterialType { get; set; }
      Description: Indicates if the material used for the graphical appearance is by category or a specific material, or if the material to be used should be taken from the ConceptualConstructionType of the MassLevelData.
    double NExteriorSurfaceArea { get; }
      Description: The exterior surface area of the volume of the mass between the level of this MassLevelData (Mass Floor) to the next in the mass.
    double NLevelFafArea { get; }
      Description: The surface area of the intersection of the MassLevelData's level with the mass geometry.
    double NLevelPerimeter { get; }
      Description: The perimeter of the intersection of the MassLevelData's level with the mass geometry.
    double NVolume { get; }
      Description: The volume of from the level of this MassLevelData (Mass Floor) to the next in the mass.
    ElementId OwningMassId { get; }
      Description: The ElementId of the mass that the MassLevelData (Mass Floor) is associated with.
    string StrUsage { get; set; }
      Description: A String which describes the usage or occupancy type of the level of the MassLevelData.

  METHODS:
    bool IsEmpty()
      Description: Indicates if the MassLevelData (Mass Floor) has a geometrical representation. May not if the level does not intersect the mass geometry.
      Returns: Returns True if MassLevelData is dimensionless, False otherwise.
    static bool IsMassFamilyInstance(Document document, ElementId id)
      Description: Checks if the ElementId is a mass family instance.
      @document: The document.
      @id: The ElementId to be checked.
      Returns: True if the ElementId is a mass family instance, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidConceptualConstructionTypeElement(ElementId id)
      Description: Checks if the ElementId is an acceptable conceptual construction type ElementId for the MassLevelData (Mass Floor).
      @id: The ElementId to be checked.
      Returns: True if the ElementId is an acceptable conceptual construction type ElementId, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MassSurfaceData
Full Name: Autodesk.Revit.DB.Analysis.MassSurfaceData
Description: Holds properties and other data about a face in the MassEnergyAnalyticalModel element.
Remarks: Properties stored in the MassSurfaceData can be used in regeneration by the MassEnergyAnalyticalModel. For example, faces of the MassEnergyAnalyticalModel take their material values from the settings in the MassSurfaceData.
Inherits: Element

  PROPERTIES:
    double Area { get; }
      Description: Area of the references that the MassSurfaceData provides properties for.
    ElementId CategoryIdForConceptualSurfaceType { get; }
      Description: Returns the mass subcategory ElementId used for ConceptualSurfaceType for this MassSurfaceData.
    ElementId ConceptualConstructionId { get; set; }
      Description: The id of the conceptual construction associated with the reference surface.
    bool IsConceptualConstructionByEnergyData { get; set; }
      Description: True when the ConceptualConstructionType id is synchronized to the EnergyDataSettings. False when the ConceptualConstructionType id is overridden for this MassSurfaceData.
    bool IsGlazingShaded { get; set; }
      Description: Indicates if shade geometry is auto-generated on the top edge of auto-generated glazing.
    bool IsSlab { get; }
      Description: Indicates if a floor is a slab.
    bool IsUnderground { get; set; }
      Description: Indicates if the roof, floor, slab, or wall surface reference is underground.
    ElementId MassLevelDataId { get; }
      Description: The MassLevelData used when the surface is horizontal, planar, and at the same height as a MassLevelData related to the same mass as the referenced face.
    ElementId MaterialId { get; set; }
      Description: The visualization material used for the surface for displaying the energy analytical model.
    MassSurfaceDataMaterialType MaterialType { get; set; }
      Description: material type of mass zone
    double PercentageGlazing { get; set; }
      Description: The target percentage of the reference wall surface that is to be covered with automatically generated windows. Revit will use this number when determining the size, shape, and location of automatically generated windows.
    double PercentageSkylights { get; set; }
      Description: The target percentage of the reference roof surface that is to be covered with automatically generated skylights. Revit will use this number when determining the size, shape, and location of automatically generated skylights.
    ElementId ReferenceElementId { get; }
      Description: The ElementId of the element whose face the MassSurfaceData primarily refers to.
    double ShadeDepth { get; set; }
      Description: How far any auto-generated shades should extend from the wall surface.
    double SillHeight { get; set; }
      Description: The height above the level where the bottoms of auto-generated windows will be located.
    double SkylightWidth { get; set; }
      Description: The length dimension to be used for the sides of each individual square skylight produced in the grid of auto-generated skylights.
    MassSurfaceDataSource SurfaceDataSource { get; set; }
      Description: Indicates whether the MassSurfaceData properties are driven by the EnergyDataSettings of the Document or are overridden for the surface.

  METHODS:
    IList<Reference> GetFaceReferences()
      Description: Gets References to the faces that the MassSurfaceData provides properties for.
      Returns: Returns an array of References to Faces that the MassSurfaceData provides properties for.

--------------------------------------------------------------------------------

[ENUM] MassSurfaceDataMaterialType
Full Name: Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType
Description: Indicates how the visualization material for the MassSurfaceData is calculated.
Inherits: Enum

  Values:
    - NormalMaterial = 0
    - MaterialByConstruction = -2

--------------------------------------------------------------------------------

[ENUM] MassSurfaceDataSource
Full Name: Autodesk.Revit.DB.Analysis.MassSurfaceDataSource
Description: Indicates whether values for the properties of the MassSurfaceData are synchronized with the EnergyDataSettings of the document or instead, serve as overrides of those settings.
Inherits: Enum

  Values:
    - EnergyData = 0
    - Surface = 1
    - Invalid = -1

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalModelData
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData
Description: Represents the MEP analytical model data attached to individual element.
Remarks: The MEP analytical model is composed of generic analytical segments and nodes. Each Revit element may have one or more analytical segments. Connected together, these data form a network that is used in the flow and pressure drop calculation.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static MEPAnalyticalModelData GetMEPAnalyticalModelData(Element pElement)
      Description: Gets the MEP analytical model data of the specified element.
      @pElement: The element that owns the MEP analytical model data.
      Returns: The MEP analytical model data of this element, null if not available.
      Throws ArgumentNullException: A non-optional argument was null
    MEPAnalyticalNode GetNodeById(int nodeId)
      Description: Gets the analytical node with the specified id.
      @nodeId: The node identifier, be aware that this identifier may not be sequentially ordered for all analytical nodes.
      Returns: The returned analytical node.
      Throws ArgumentException: The input must be a valid node id.
    MEPAnalyticalNode GetNodeByIndex(int index)
      Description: Gets the specified analytical node.
      @index: The node index number by their storing sequence, starting from 0.
      Returns: The returned analytical node.
      Throws ArgumentOutOfRangeException: The index must range from 0 to GetNumberOfNodes()-1.
    int GetNumberOfNodes()
      Description: Returns the number of analytical nodes.
    int GetNumberOfSegments()
      Description: Returns the number of analytical segments.
      Returns: The total number of
    MEPAnalyticalSegment GetSegmentById(int segmentId)
      Description: Gets the analytical segment with the specified id.
      @segmentId: The segment id to be retrieved. This id is not 0 based.
      Returns: The returned analytical segment.
      Throws ArgumentException: The input must be a valid segment id.
    MEPAnalyticalSegment GetSegmentByIndex(int index)
      Description: Gets the analytical segment at the specified position.
      @index: The index where the segment is stored. This index is 0 based.
      Returns: The returned analytical segment.
      Throws ArgumentOutOfRangeException: The index must range from 0 to GetNumberOfSegments()-1.
    MEPNetworkSegmentData GetSegmentData(int segmentId)
      Description: Gets the analysis data on the specified segment.
      @segmentId: The segment id to be retrieved.
      Returns: The calculated data of this segment. Be aware that the segment data may be invalid if the calculation failed.
      Throws ArgumentException: The input must be a valid segment id.
    bool IsValidNodeId(int nodeId)
      Description: Verifies if a valid analytical node id.
      @nodeId: The node id to be verified.
      Returns: True if valid, otherwise false.
    bool IsValidSegmentId(int segmentId)
      Description: Verifies if a valid segment id.
      @segmentId: The segment id to be verified.
      Returns: True if the id is a valid segment id, otherwise false.

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalNode
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalNode
Description: Represents an analytical node of the MEP analytical model.
Implements: IDisposable

  PROPERTIES:
    int Id { get; }
      Description: The identity used in the MEPAnalyticalSegment
    bool IsFlowBlocked { get; }
      Description: Is the flow blocked at this analytical node?
    bool IsFocalNode { get; }
      Description: Is this node a focal point of multiple branches?
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Location { get; }
      Description: The location of this node.

  METHODS:
    void Dispose()
    bool IsSameNode(MEPAnalyticalNode other)
      Description: Verify if this node is connected to the other node and thus represents the same analytical node in the network.
      @other: The other node to be compared.
      Returns: True if two nodes represent the same node of the network. Otherwise false.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] MEPAnalyticalSegment
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment
Description: Represents an analytical segment of the MEP analytical model.
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: The area of the segment profile.
    double DemandFlow { get; }
      Description: The designed flow value, in ft^3/s.
    ConnectorDomainType DomainType { get; }
      Description: The connector domain type of this segment.
    int EndNode { get; }
      Description: The id of the end analytical node.
    int Id { get; }
      Description: The identity of this segment.
    double InnerDiameter { get; }
      Description: The inner diameter of this segment, in ft. For rectangular or oval profile, this may be the hydraulic diameter.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId RevitElementId { get; }
      Description: The id of the owning Revit element.
    double Roughness { get; }
      Description: The roughness of this segment, in ft.
    MEPAnalyticalSegmentType SegmentType { get; }
      Description: The analytical segment type.
    int StartNode { get; }
      Description: The id of the start analytical node.

  METHODS:
    void Dispose()
    MEPNetworkSegmentId GetNetworkSegmentId()
      Description: Gets the NetworkSegmentId.

--------------------------------------------------------------------------------

[ENUM] MEPAnalyticalSegmentType
Full Name: Autodesk.Revit.DB.Analysis.MEPAnalyticalSegmentType
Description: The type of analytical segment.
Inherits: Enum

  Values:
    - Undefined = 0
    - Segment = 1
    - Fitting = 2
    - Pump = 3
    - Loss = 4
    - SourceEquipment = 5

--------------------------------------------------------------------------------

[CLASS] MEPNetworkIterator
Full Name: Autodesk.Revit.DB.Analysis.MEPNetworkIterator
Description: An iterator to traverse the MEP analytical network.
Remarks: The iterator will visit the entire MEP analytical network in the depth-first order. For evert next step, one analytical node and one analytical segment are typically visited. Sometimes an extra node is provided if the iteration reaches the end on one side and restarts at the previous intersect node. Also note that the start step may not contain any segment.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPNetworkIterator(Document pADoc, MEPAnalyticalSegment startSegment)
      Description: Creates an iterator to visit the connected segments on both sides.
      @pADoc: The document of the analytical network.
      @startSegment: The starting analytical segment.
      Throws ArgumentNullException: A non-optional argument was null
    new MEPNetworkIterator(Document pADoc, MEPAnalyticalNode startNode, MEPAnalyticalSegment startSegment)
      Description: Creates an iterator to visit the connected segments on one side of the network.
      @pADoc: The document of the analytical network.
      @startNode: The starting analytical node. It must be one of two nodes of the starting segment.
      @startSegment: The starting analytical segment to specify the traversing direction from the starting node.
      Throws ArgumentNullException: A non-optional argument was null
    new MEPNetworkIterator(Document pADoc, MEPAnalyticalModelData seed, ConnectorDomainType eDomain)
      Description: Creates an iterator by the analytical model data to visit all connected components in the network.
      @pADoc: The document of the analytical network.
      @seed: The analytical model data of the starting element.
      @eDomain: The domain of network that the iteration happens.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    ElementId CurrentElementId { get; }
      Description: The element id at the current iteration step.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    MEPSystemClassification SystemClassification { get; set; }
      Description: The optional MEP system classification where the iterations are restricted.
    ElementId SystemId { get; set; }
      Description: The optional MEP system element id where the iterations are restricted.

  METHODS:
    void Dispose()
    bool End()
      Description: Checks if the network iteration has completed.
      Returns: True if all analytical segments and nodes have been visited, otherwise false.
    MEPAnalyticalModelData GetAnalyticalModelData()
      Description: Gets the analytical model data at the current iteration step.
      Returns: The retrieved model data.
    MEPAnalyticalNode GetAnalyticalNode()
      Description: Gets the analytical node at the current iteration step.
      Returns: The retrieved node.
    MEPAnalyticalSegment GetAnalyticalSegment()
      Description: Gets the analytical segment at the current iteration step.
      Returns: The retrieved segment, may be null for the first step.
    MEPAnalyticalNode GetOtherAnalyticalNode()
      Description: Gets the other analytical node at the current iteration step.
      Returns: The retrieved analytical node, null if the current iteration step does not have additional analytical node.
    void Next()
      Description: Moves this iterator to the next step of network iteration.
    void Start()
      Description: Gets the first step of network iteration.

--------------------------------------------------------------------------------

[CLASS] MEPNetworkSegmentData
Full Name: Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData
Description: Represents the analysis data for one network segment.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPNetworkSegmentData(MEPNetworkSegmentData other)
      Description: Creates a new segment data object based on another object.
      @other: The other segment data that the new object is based on.
      Throws ArgumentNullException: A non-optional argument was null
    new MEPNetworkSegmentData()
      Description: Creates a default segment data object.

  PROPERTIES:
    double Coefficient { get; }
      Description: The calculated coefficient of this segment, dimensionless.
    double Flow { get; }
      Description: The calculated flow of this segment, in ft^3/s. The positive value means the flow is from the start to the end node, the negative value means opposite direction.
    PipeFlowState FlowState { get; }
      Description: The calculated flow state of this segment.
    double FrictionFactor { get; }
      Description: The calculated friction factor of this segment, dimensionless.
    bool IsCriticalPath { get; }
      Description: Verifies if the segment is on the critical path.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double PressureDrop { get; }
      Description: The calculated pressure drop of this segment, in kg/(ft*s^2).
    double RelativeRoughness { get; }
      Description: The relative roughness of this segment, dimensionless.
    double ReynoldsNumber { get; }
      Description: The Reynolds number of this segment, dimensionless.
    int SectionNumber { get; }
      Description: The section this segment belongs to.
    double Velocity { get; }
      Description: The calculated velocity of this segment, in ft/s.
    double VelocityPressure { get; }
      Description: The calculated velocity pressure of this segment, in kg/(ft*s^2).

  METHODS:
    void Dispose()
    IList<MEPNetworkSegmentId> GetDownstreamSegments()
      Description: Gets all downstream network segments.
      Returns: The list of segments that flow out of this segment.
    IList<MEPNetworkSegmentId> GetUpstreamSegments()
      Description: Gets all upstream network segments.
      Returns: The list of segments that flow into this segment.
    bool IsValid()
      Description: Verified if this segment data has been assigned some valid values afer calculation.
      Returns: True if the segment was assigned valid values, otherwise false.

--------------------------------------------------------------------------------

[CLASS] MEPNetworkSegmentId
Full Name: Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId
Description: Represents a unique identifier for one analytical segment in the network.
Implements: IDisposable

  CONSTRUCTORS:
    new MEPNetworkSegmentId(ElementId idElem, int segment)
      Description: Creates a valid segment id on the network.
      Throws ArgumentNullException: A non-optional argument was null
    new MEPNetworkSegmentId()
      Description: Creates a default invalid segment id on the network.

  PROPERTIES:
    ElementId ElementId { get; set; }
      Description: The element id where this analytical segment belongs.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int SegmentId { get; set; }
      Description: The segment identifier.

  METHODS:
    void Dispose()
    bool IsValid()
      Description: Verifies if this is a valid segment id.
      Returns: True if this is a valid segment id, otherwise false.

--------------------------------------------------------------------------------

[ENUM] OutdoorAirFlowStandard
Full Name: Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard
Description: An enumerated type listing all the possible outdoor airflow standard for a space type.
Inherits: Enum

  Values:
    - ByPeopleAndByArea = 0
    - ByACH = 1
    - MaxByPeople_ByArea = 2
    - MaxByACH_ByPeopleByArea = 3
    - MaxByACH_ByArea_ByPeople = 4

--------------------------------------------------------------------------------

[CLASS] PathOfTravel
Full Name: Autodesk.Revit.DB.Analysis.PathOfTravel
Description: An element which holds a graphical representation of the shortest route between two points in the plane of a floor plan view. The shortest route is calculated to go around model geometry visible in the view. Route calculation is affected by properties of the Autodesk::Revit::DB::Analysis::RouteAnalysisSettings element.
Inherits: Element

  PROPERTIES:
    ElementId LineStyle { get; set; }
      Description: The line style of the path.
    XYZ PathEnd { get; set; }
      Description: The end point of the path. The Z coordinate will equal the view's level elevation. To update path calculations, call update.
    XYZ PathMidpoint { get; }
      Description: The midpoint of the path. The Z coordinate will equal the view's level elevation.
    XYZ PathStart { get; set; }
      Description: The start point of the path. The Z coordinate will equal the view's level elevation. To update path calculations, call update.

  METHODS:
    static PathOfTravel Create(View DBView, XYZ pathStart, XYZ pathEnd)
      Description: Creates a new path of travel between two points.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStart: The start point of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnd: The end point of the path. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: The newly created path of travel element, or if no path between the two points is found.
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- This operation cannot be performed while the document is in edit mode. -or- The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    static PathOfTravel Create(View DBView, XYZ pathStart, XYZ pathEnd, out PathOfTravelCalculationStatus resultStatus)
      Description: Creates a new path of travel between two points and provides creation result status.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStart: The start point of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnd: The end point of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @resultStatus: Result status of path of travel creation.
      Returns: The newly created path of travel element, or if no path between the two points is found.
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- This operation cannot be performed while the document is in edit mode. -or- The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    static IList<PathOfTravel> CreateMapped(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds)
      Description: Creates multiple new paths of travel by mapping each of a set of start points to each of a set of end points.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStarts: The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnds: The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: The array of newly created path of travel elements, or if no path between the two points is found. The number of elements is the number of start points multiplied by the number of end points. The order of elements corresponds to the order of end and then start points in the argument arrays: s0->e0, s1->e0, ... , s0->e1, s1->e1... etc. There are some additional conditions that are checked and if any condition is true the value is returned: View has crop box active and start or end point lies outside of the cropStart and end points are too close
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- This operation cannot be performed while the document is in edit mode. -or- The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    static IList<PathOfTravel> CreateMapped(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds, out IList<PathOfTravelCalculationStatus> resultStatus)
      Description: Creates multiple new paths of travel by mapping each of a set of start points to each of a set of end points and provides creation result statuses.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStarts: The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnds: The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @resultStatus: Result statuses of each path of travel creation. The order of statuses corresponds to the order of elements in the array returned by the function.
      Returns: The array of newly created path of travel elements, or if no path between the two points is found. The number of elements is the number of start points multiplied by the number of end points. The order of elements corresponds to the order of end and then start points in the argument arrays: s0->e0, s1->e0, ... , s0->e1, s1->e1... etc. There are some additional conditions that are checked and if any condition is true the value is returned: View has crop box active and start or end point lies outside of the cropStart and end points are too close
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- This operation cannot be performed while the document is in edit mode. -or- The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    static IList<PathOfTravel> CreateMultiple(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds, out IList<PathOfTravelCalculationStatus> resultStatus)
      Description: Creates multiple new paths of travel between same size sets of start and end points and provides creation result statuses.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStarts: The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnds: The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @resultStatus: Result statuses of each path of travel creation. The order of statuses corresponds to the order of elements in the array returned by the function.
      Returns: The array of newly created path of travel elements, or if no path between the two points is found. The order of elements corresponds to the order of start/end points in the argument arrays. There are some additional conditions that are checked and if any condition is true the value is returned: View has crop box active and start or end point lies outside of the cropStart and end points are too close
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- This operation cannot be performed while the document is in edit mode. -or- The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    static IList<PathOfTravel> CreateMultiple(View DBView, IList<XYZ> pathStarts, IList<XYZ> pathEnds)
      Description: Creates multiple new paths of travel between same size sets of start and end points.
      @DBView: The floor plan view to use when computing the shortest distance.
      @pathStarts: The start points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      @pathEnds: The end points of the path. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: The array of newly created path of travel elements, or if no path between the two points is found. The order of elements corresponds to the order of start/end points in the argument arrays. There are some additional conditions that are checked and if any condition is true the value is returned: View has crop box active and start or end point lies outside of the cropStart and end points are too close
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- This operation cannot be performed while the document is in edit mode. -or- The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    static IList<XYZ> FindEndsOfShortestPaths(View DBView, IList<XYZ> destinationPoints, IList<XYZ> startPoints)
      Description: For a floor plan view, calculates the paths from each start point to its closest destination and return the path end points.
      @DBView: The floor plan view to use when computing the points.
      @destinationPoints: Destination points. The input Z coordinates are ignored and set to the view's level elevation.
      @startPoints: Start points for which shortest path end points are calculated.
      Returns: End points of paths calculated from each start point to its corresponding closest destination. If a path cannot be calculated the corresponsing end point is set to the corresponding start point.
      Throws ArgumentException: View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
    static IList<IList<XYZ>> FindShortestPaths(View DBView, IList<XYZ> destinationPoints, IList<XYZ> startPoints)
      Description: For a floor plan view, calculates paths from each start point to its closest destinations. Returns the path, represented by an array of XYZ points.
      @DBView: The floor plan view to use when computing the points.
      @destinationPoints: Destination points. The input Z coordinates are ignored and set to the view's level elevation.
      @startPoints: Start points for which shortest paths are calculated.
      Returns: Array of paths calculated from each start point to its corresponding closest destination. If a path cannot be caculated the corresponsing sub-array is set to an empty array.
      Throws ArgumentException: View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
    static IList<XYZ> FindStartsOfLongestPathsFromRooms(View DBView, IList<XYZ> destinationPoints)
      Description: For a floor plan view, calculates paths from points inside rooms to the closests of the destinations. Returns the start points of the longest path(s). If multiple paths have the same longest length, returns multiple start points.
      @DBView: The floor plan view to use when computing the points.
      @destinationPoints: Destination points. The input Z coordinates are ignored and set to the view's level elevation.
      Returns: Start points of the paths with longest lengths. The array is empty if there are no valid paths from any points in rooms to any of the destination points.
      Throws ArgumentException: View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The Path of Travel calculation service is not available -or- This functionality is not available in Revit LT.
    IList<Curve> GetCurves()
      Description: Gets the array of curves representing the path of travel.
      Returns: The array of curves.
    IList<XYZ> GetWaypoints()
      Description: return the waypoints set for the Path of Travel
    void InsertWaypoint(XYZ waypoint, int index)
      Description: Insert a waypoint at the specified index
      @waypoint: The waypoint to insert.
      @index: The index to insert the waypoint at.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Index is invalid for an existing or new waypoint for this path. -or- This functionality is not available in Revit LT. -or- Cannot perform this operation for a path of travel in a group.
    static bool IsInRevealObstaclesMode(View DBView)
      Description: Returns current state of Reveal Obstacles mode for the given view.
      @DBView: The view to determine current state of Reveal Obstacles mode for.
      Returns: True if Reveal Obstacles mode is ON for the view, false otherwise.
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The Path of Travel calculation service is not available
    void RemoveWaypoint(int index)
      Description: Remove a waypoint.
      @index: The index of the waypoint to remove.
      Throws InvalidOperationException: Index refers to a non-existent waypoint. -or- This functionality is not available in Revit LT. -or- Cannot perform this operation for a path of travel in a group.
    static PathOfTravelCalculationStatus SetRevealObstaclesMode(View DBView, bool newState)
      Description: Sets Reveal Obstacles mode for the given view.
      @DBView: The view to set Reveal Obstacles mode for.
      @newState: New state of Reveal Obstacles mode to be set for the view.
      Returns: Result status of the operation.
      Throws ArgumentException: The element "DBView" is in a family document or a document in in-place edit mode. -or- View is not a floor plan view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The Path of Travel calculation service is not available
      Throws ModificationForbiddenException: The document containing DBView is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document containing DBView is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document containing DBView has no open transaction.
    void SetWaypoint(XYZ waypoint, int index)
      Description: Updates the specified waypoint.
      @waypoint: The new point for the waypoint.
      @index: The index of the waypoint to update.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Index refers to a non-existent waypoint. -or- This functionality is not available in Revit LT. -or- Cannot perform this operation for a path of travel in a group.
    PathOfTravelCalculationStatus Update()
      Description: Updates the path of travel by recalculating the path between the original start and end points.
      Returns: The status result of the recalculation.
      Throws InvalidOperationException: This functionality is not available in Revit LT.
    static int UpdateMultiple(Document adoc, IList<ElementId> elementsToUpdate, out IList<PathOfTravelCalculationStatus> resultStatus)
      Description: Updates the specified paths of travel by recalculating each path using their original start and end points and provides creation result statuses.
      @adoc: Document of elements to be updated.
      @elementsToUpdate: The list of ElementIdof the paths to update.
      @resultStatus: Result statuses of each path of travel creation. The order of statuses corresponds to the order of elements in the array passed to the function.
      Returns: number of successfully updated elements
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This functionality is not available in Revit LT.
    static int UpdateMultiple(Document adoc, IList<ElementId> elementsToUpdate)
      Description: Updates the specified paths of travel by recalculating each path using their original start and end points.
      @adoc: Document of elements to be updated.
      @elementsToUpdate: The list of ElementIdof the paths to update.
      Returns: number of successfully updated elements
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This functionality is not available in Revit LT.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PathOfTravelCalculationServerIds
Full Name: Autodesk.Revit.DB.Analysis.PathOfTravelCalculationServerIds
Description: Ids for external servers implementing path of travel calculations.

  PROPERTIES:
    static Guid DefaultPathOfTravelCalculationGUID { get; }
      Description: GUID to represent the default calculation server id.

--------------------------------------------------------------------------------

[ENUM] PathOfTravelCalculationStatus
Full Name: Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus
Description: An enumerated type containing possible results of the Path of Travel calculation.
Inherits: Enum

  Values:
    - Success = 0
    - NoPathOfTravel = 1
    - AreaTooLarge = 2
    - SplitView = 3
    - ResultAffectedByCrop = 4
    - StartAndEndPointsTooClose = 5
    - PointOutsideActiveCrop = 6
    - TooMuchGeometry = 7
    - RevealObstaclesModeFailureDataExist = 8
    - RevealObstaclesModeFailureWireframe = 9
    - TemporaryModeFailureDataExist = 10
    - TemporaryModeFailureWireframe = 11

--------------------------------------------------------------------------------

[CLASS] Polyloop
Full Name: Autodesk.Revit.DB.Analysis.Polyloop
Description: A Polyloop represent a planar polygon with ordered points.
Remarks: This class is a loop with straight edges bounding a planar region in space. The loop is represented by an ordered coplanar collection of points forming the vertices of the loop. The loop is composed of straight line segments joining a point in the collection to the succeeding point in the collection. The closing segment is from the last to the first point in the collection. The direction of the loop is in the direction of the line segments. All the points in the polygon defining the poly loop shall be coplanar.
Implements: IDisposable

  PROPERTIES:
    XYZ Centroid { get; }
      Description: The polygon centroid.
    XYZ Direction { get; }
      Description: The direction for the outward normal for this polygon.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    double ComputeArea()
      Description: Gets the area for this polygon.
      Returns: The area for this polygon.
    void Dispose()
    IList<XYZ> GetPoints()
      Description: Gets the array of points in the polygon.
      Returns: The array of points in the polygon.

--------------------------------------------------------------------------------

[CLASS] RouteAnalysisSettings
Full Name: Autodesk.Revit.DB.Analysis.RouteAnalysisSettings
Description: RouteAnalysisSettings is an element which contains project-wide settings for route calculations. The Autodesk::Revit::DB::Analysis::PathOfTravel element uses these settings to calculate a route between two points in a plan view.By default, the route will go around the geometry of all visible model elements which have model geometry in the Route Analysis Zone.The Route Analysis Zone, determined per view, is the space between these two horizontal planes: a top plane vertically offset by AnalysisZoneTopOffset above the view's level and a bottom plane vertically offset by AnalysisZoneBottomOffset ft above the view's level. By default, the route will ignore the following elements: elements outside of the crop region of the view;elements without any model geometry (annotations or view-specific elements);model lines (category OST_Lines);demolished elements;elements displayed in the underlay of the view. There are a few ways to customize Route Analysis on a project-wide basis. You can adjust the Route Analysis Zone using AnalysisZoneTopOffset and AnalysisZoneBottomOffset.You can specify a set of model categories you would like ignored during route calculation. To enable ignoring the set of specified categories, set EnableIgnoredCategoryIds to true. To change the set of ignored categories, use ElementId}) method and IgnoreImports and IgnorePointClouds properties. To query the set of ignored categories, use GetIgnoredCategoryIds.
Inherits: Element

  PROPERTIES:
    double AnalysisZoneBottomOffset { get; set; }
      Description: The bottom plane offset, in ft, of the zone used in route calculation. Default value is 8".
    double AnalysisZoneTopOffset { get; set; }
      Description: The top plane offset, in ft, for the zone used in route calculation. Default value is 6'8".
    bool EnableIgnoredCategoryIds { get; set; }
      Description: When this setting is true, elements with category ids returned by GetIgnoredCategoryIds will be ignored in route calculation. default is true as all elements with the Door Category Id are ignored by default.
    bool IgnoreImports { get; set; }
      Description: If true, import instances are ignored by route calculation. For imports to be ignored, also EnableIgnoredCategoryIds must be set to true.
    double MinimumLength { get; }
      Description: The constant storing minimum allowed length of path of travel

  METHODS:
    ICollection<ElementId> GetExcludedCategoryIds()
      Description: Returns ElementIds for Category elements which are excluded (not taken into account) by route calculation. These categories are always excluded, regardless of the EnableIgnoredCategoryIds value. If an excluded category has sub-categories, then the sub-categories will be excluded as well.
      Returns: The ids of Categories which are excluded by route calculation.
    ICollection<ElementId> GetIgnoredCategoryIds()
      Description: Returns ElementIds for Category elements which are ignored (not taken into account) route calculation. To enable ignoring of these categories, EnableIgnoredCategoryIds must be set to true. If an ignored category has sub-categories, then the sub-categories will be ignored as well.
      Returns: The ids of Categories which are ignored by route calculation. By default, the set contains the Doors Category.
    static RouteAnalysisSettings GetRouteAnalysisSettings(Document cda)
      Description: Returns the RouteAnalysisSettings element for a given document.
      @cda: The document for which to get the RouteAnalysisSettings element.
      Returns: Returns the RouteAnalysisSettings element in project documents or for family documents.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsLargeGeometryAllowed()
      Description: Returns if large geometry is allowed for path of travel creation or not.
    void SetIgnoredCategoryIds(ICollection<ElementId> categoryIds)
      Description: Sets the ElementIds for Category elements which are ignored by route calculation.
      @categoryIds: The ids of Categories to be ignored by route calculation.
      Throws ArgumentException: One or more ElementIds in categoryIds are not valid Category element ids.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] SpatialFieldManager
Full Name: Autodesk.Revit.DB.Analysis.SpatialFieldManager
Description: Exposes all API for an external analysis application. Its primary role is creation, deletion and modification of SpatialFieldElement elements.
Inherits: Element

  PROPERTIES:
    bool AllowInteractiveSettings { get; set; }
      Description: If true interactive settings dialog and pick deletion are allowed.
    int CurrentMeasurement { get; set; }
      Description: Stores the currently displayed measurement
    XYZ LegendPosition { get; set; }
      Description: Stores current position of analysis results legend element in view
    bool LegendShowConfigurationName { get; set; }
      Description: If true legend contains analysis configuration name.
    bool LegendShowDescription { get; set; }
      Description: If true legend contains analysis description.
    ElementId LegendTextTypeId { get; set; }
      Description: Stores element id of text associated with common (result-independent) part of legend in view.
    int NumberOfMeasurements { get; }
      Description: Stores the total number of measurements
    bool ResultsVisibleInView { get; set; }
      Description: Enables analysis results visibility in the view.
    bool UseRangeForAllMeasurements { get; set; }
      Description: Governs how minimum and maximum values (the data range) are calculated.

  METHODS:
    int AddSpatialFieldPrimitive(Curve curve, Transform trf)
      Description: Creates empty analysis results primitive associated with a curve and a transform.
      @curve: Curve to be associated with the primitive. %curve% does NOT correspond to actual Revit geometry, i.e. it cannot be associated with reference; otherwise the other overload of the method must be used (taking "reference" as the input)
      @trf: Conformal Transform to be applied to %curve%.
      Returns: Unique index of primitive for future references
      Throws ArgumentException: The input curve points to a helical curve and is not supported for this operation. -or- Argument trf is not a conformal transform (see property Revit::DB::Transform::IsConformal)
      Throws ArgumentNullException: A non-optional argument was null
    int AddSpatialFieldPrimitive(Face face, Transform trf)
      Description: Creates empty analysis results primitive associated with a face and a transform.
      @face: Face to be associated with the primitive
      @trf: Conformal Transform to be applied to %face%
      Returns: Unique index of primitive for future references
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: trf is not conformal.
    int AddSpatialFieldPrimitive(Reference reference, SpatialFieldPrimitiveHideMode hidingMode)
      Description: Creates an empty analysis results primitive associated with a reference, with the option to control how the reference element is hidden.
      @reference: Reference pointing to the curve or face to be associated with the primitive
      @hidingMode: The mode used to hide the original model element
      Returns: Unique index of primitive for future references
      Throws ArgumentException: reference points to neither face nor curve
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    int AddSpatialFieldPrimitive(Reference reference)
      Description: Creates an empty analysis results primitive associated with a reference.
      @reference: Reference pointing to the curve or face to be associated with the primitive
      Returns: Unique index of primitive for future references
      Throws ArgumentException: reference points to neither face nor curve
      Throws ArgumentNullException: A non-optional argument was null
    int AddSpatialFieldPrimitive()
      Description: Creates empty analysis results primitive not associated with any geometry element
      Returns: Unique index of primitive for future references
    void Clear()
      Description: Clear all analysis results managed by this manager object
    static SpatialFieldManager CreateSpatialFieldManager(View view, int numberOfMeasurements)
      Description: Factory method - creates manager object for the given view
      @view: View for which manager object is created or retrieved
      @numberOfMeasurements: Total number of measurements in the calculated results. This number defines the length of value arrays in ValueAtPoint objects
      Returns: Manager object for the view passed in the argument
      Throws ArgumentException: numberOfMeasurements is less than one
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: View is not allowed to display analysis results or a manager object for this view already exists
    AnalysisDisplayLegend GetLegend()
      Description: Returns legend element or NULL
      Returns: The legend element or NULL
    double GetMaximum(int resultIndex, bool rawValue)
      Description: Calculates the maximum value for all primitives
      @resultIndex: Index of result schema
      @rawValue: If true returned value is NOT multiplied by the current result's units multiplier, otherwise it IS
      Returns: Resulting maximum value
      Throws InapplicableDataException: Thrown when current measurement is >= the number of measurements for at least one primitive
    double GetMinimum(int resultIndex, bool rawValue)
      Description: Calculates the minimum value for all primitives
      @resultIndex: Index of result schema
      @rawValue: If true returned value is NOT multiplied by the current result's units multiplier, otherwise it IS
      Returns: Resulting minimum value
      Throws InapplicableDataException: Thrown when current measurement is >= the number of measurements for at least one primitive
    IList<int> GetRegisteredResults()
      Description: Returns an array of indices of all registered results
    AnalysisResultSchema GetResultSchema(int idx)
      Description: Returns result schema by index
      @idx: Index of registered result schema
      Throws ArgumentException: idx refers to non-existent result schema
    static SpatialFieldManager GetSpatialFieldManager(View view)
      Description: Retrieves manager object for the given view or returns NULL
      @view: View for which manager object is retrieved
      Returns: Manager object for the view passed in the argument
    bool IsResultSchemaNameUnique(string name, int resultIndexToSkip)
      Description: Verify the uniqueness of the name among all registered result schemas.
      @name: Name to verify uniqueness of.
      @resultIndexToSkip: Index of result (e.g. to be replaced) which names should not count for uniqueness; negative number means nothing is excluded from comparison.
      Returns: True if name is unique, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsTextTypeIdValid(ElementId textTypeId, Document doc)
      Description: Verify if text type id is valid.
      @textTypeId: Text type id to be validated.
      @doc: Document for which %textTypeId% is validated.
      Returns: True if text type id is valid, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    int RegisterResult(AnalysisResultSchema resultSchema)
      Description: Registers result and assigns it a unique result index
      @resultSchema: Result schema to be registered
      Returns: Unique index assigned to the result
      Throws ArgumentException: name of resultSchema is not unique in view
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveSpatialFieldPrimitive(int idx)
      Description: Removes analysis results primitive identified by the unique index
      @idx: Unique index identifying the primitive
      Throws ArgumentException: idx refers to non-existent primitive
    void SetMeasurementDescriptions(IList<string> measurementDescriptions)
      Description: Sets Descriptions for all measurements
      @measurementDescriptions: Array of measurement descriptions. The lengths of the array must be equal to the number of measurements set during creation of SpatialFieldManager.
      Throws ArgumentException: measurementDescriptions lengths is not equal to the number of measurements set during creation of SpatialFieldManager
      Throws ArgumentNullException: A non-optional argument was null
    void SetMeasurementNames(IList<string> measurementNames)
      Description: Sets Names for all measurements
      @measurementNames: Array of measurement names. All names in the array must be unique. The lengths of the array must be equal to the number of measurements set during creation of SpatialFieldManager.
      Throws ArgumentException: measurementNames contains duplicate names or its lengths is not equal to the number of measurements set during creation of SpatialFieldManager
      Throws ArgumentNullException: A non-optional argument was null
    void SetResultSchema(int idx, AnalysisResultSchema resultSchema)
      Description: Sets a new value for an existing result schema in the result registry
      @idx: Index of registered result schema
      @resultSchema: Result schema replacing the existent one
      Throws ArgumentException: idx refers to non-existent result schema -or- name of resultSchema is not unique in view
      Throws ArgumentNullException: A non-optional argument was null
    void UpdateSpatialFieldPrimitive(int idx, FieldDomainPoints fieldDomainPoints, FieldValues fieldValues, int resultIndex)
      Description: Populates analysis results data (or replaces the existing data) in the existing primitive identified by the unique index
      @idx: Unique index identifying the primitive
      @fieldDomainPoints: Set of domain points. If the new set of domain points is supplied, all previously supplied domain points and field values for all results are removed from the primitive. If %fieldDomainPoints% is only fieldValues are updated
      @fieldValues: Set of data values. Number of values in fieldValues must coincide with the number of points in fieldDomainPoints
      @resultIndex: Unique index identifying the result schema
      Throws ArgumentException: idx refers to non-existent primitive -or- fieldValues has incorrect number of measurements in ValueAtPoint objects -or- fieldDomainPoints has inconsistent type -or- resultIndex refers to non-existent result schema
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: fieldDomainPoints and fieldValues have inconsistent number of points

--------------------------------------------------------------------------------

[ENUM] SpatialFieldPrimitiveHideMode
Full Name: Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode
Description: Defines modes which can be used by a SpatialFieldPrimitive to hide the original referenced element.
Inherits: Enum

  Values:
    - Default = 0
    - HideNone = 1
    - HideOnlyReference = 2
    - HideWholeElement = 3

--------------------------------------------------------------------------------

[CLASS] SystemsAnalysisOptions
Full Name: Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions
Description: Contains the options for systems analysis.
Implements: IDisposable

  CONSTRUCTORS:
    new SystemsAnalysisOptions()
      Description: Constructs a new instance of the options.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string OutputFolder { get; set; }
      Description: The path of the output folder for systems analysis.
    string WeatherFile { get; set; }
      Description: The file name of the EnergyPlus weather (*.epw).
    string WorkflowFile { get; set; }
      Description: The file name of the EnergyPlus workflow script.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] SystemsAnalysisReportStyle
Full Name: Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle
Description: The report style of systems analysis.
Inherits: Enum

  Values:
    - Detailed = 0
    - Loads = 1

--------------------------------------------------------------------------------

[CLASS] ValueAtPoint
Full Name: Autodesk.Revit.DB.Analysis.ValueAtPoint
Description: Stores values at one domain point. Each value corresponds to a "measurement" for which this value was calculated.
Inherits: ValueAtPointBase

  CONSTRUCTORS:
    new ValueAtPoint(ValueAtPoint otherObject)
      Description: Creates a copy of the given ValueAtPoint instance.
      Throws ArgumentNullException: A non-optional argument was null
    new ValueAtPoint(IList<double> values)
      Description: Creates object from an array of values
      @values: Array of values, each corresponding to "measurement"
      Throws ArgumentException: Thrown when supplied values contain invalid (infinite or non-number) doubles
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] VectorAtPoint
Full Name: Autodesk.Revit.DB.Analysis.VectorAtPoint
Description: Stores vectors at one domain point. Each vector corresponds to a "measurement" for which this vector was calculated.
Inherits: ValueAtPointBase

  CONSTRUCTORS:
    new VectorAtPoint(VectorAtPoint otherObject)
      Description: Creates a copy of the given VectorAtPoint instance.
      Throws ArgumentNullException: A non-optional argument was null
    new VectorAtPoint(IList<XYZ> vectors)
      Description: Creates object from an array of vectors
      @vectors: Array of vectors, each corresponding to "measurement"
      Throws ArgumentException: Thrown when supplied vectors contain invalid (infinite or non-number) coordinates
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ViewSystemsAnalysisReport
Full Name: Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport
Description: Represents a report instance of the systems analysis.
Inherits: View

  PROPERTIES:
    DateTime AnalysisDateAndTime { get; }
      Description: Identifies the analysis date and time when it was requested.
    SystemsAnalysisReportStyle ReportStyle { get; set; }
      Description: The report style that specifies the display content.
    string SystemsAnalysisOutputFolder { get; }
      Description: The full path of the output folder for systems analysis
    string SystemsAnalysisWorkflowFile { get; }
      Description: The full path name of the original system analysis workflow file.
    string WeatherFile { get; }
      Description: The full path name of the weather file used for the systems analysis.

  METHODS:
    static void CancelSystemsAnalysis(Document document, ElementId reportElement)
      Description: Cancels the systems analysis based on the report element id.
      @document: The document where the report element existed.
      @reportElement: The report element that identifies the analysis.
      Throws ArgumentNullException: A non-optional argument was null
    static ViewSystemsAnalysisReport Create(Document document, string viewName)
      Description: Creates a new view for the systems analysis report.
      @document: The document where the view is to be created.
      @viewName: The name of the new report view.
      Returns: The newly created view instance, or if the operation fails.
      Throws ArgumentException: viewName cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- viewName is an empty string.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ElementId GetLatestSystemsAnalysisReport(Document document)
      Description: Gets the latest report of systems analysis.
      Throws ArgumentNullException: A non-optional argument was null
    string GetReportContent()
      Description: Gets the report content in this view.
      Returns: The content of the report as displayed in the view, or the referenced file name.
    bool IsAnalysisCompleted()
      Description: Indicates if the background systems analysis has completed or not.
      Returns: True if completed, otherwise false.
    void RequestSystemsAnalysis(SystemsAnalysisOptions options)
      Description: Requests a new systems analysis in the background.
      @options: The additional options to run systems analysis. If empty, use the default value in the view element. The request may download the weather file at current site location if not specified in the options.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: No weather station is within 500 nautical miles of this site location.
      Throws FileNotFoundException: Fail to download the weather file.
      Throws InvalidOperationException: A valid energy model is required for systems analysis. -or- Unable to access the weather service. Try again later.

--------------------------------------------------------------------------------

