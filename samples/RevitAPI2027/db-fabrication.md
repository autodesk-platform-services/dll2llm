# Autodesk.Revit.DB.Fabrication

NAMESPACE: Autodesk.Revit.DB.Fabrication
--------------------------------------------------------------------------------

[CLASS] DesignToFabricationConverter
Full Name: Autodesk.Revit.DB.Fabrication.DesignToFabricationConverter
Description: This class represents the MEP design to fabrication part convert tool.
Remarks: After a new instance of the class is created, call the Convert method to convert the MEP design elements into fabrication parts. Use the method SetMapForFamilySymbolToFabricationPartType to optionally convert family content to fabrication parts prior to calling Convert by providing a mapping of family symbols to fabrication parts types. If not set, then during conversion these families will remain and any connections to other converted elements will be maintained. After the convert method has been invoked, query the class to obtain more information about the conversion: GetConvertedFabricationParts to get a set of element identifiers for the newly created fabrication parts.GetElementsWithOpenConnector to get a set of fabrication part or MEP design element identifiers with open connectors, caused by fittings failing to convert.
Implements: IDisposable

  CONSTRUCTORS:
    new DesignToFabricationConverter(Document document)
      Description: Creates a new instance of the DesignToFabricationConverter class.
      @document: A document in which to convert MEP design elements into fabrication parts.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    DesignToFabricationConverterResult Convert(ISet<ElementId> selection, int serviceId)
      Description: Converts the set of MEP design elements into fabrication parts.
      @selection: The set of element identifiers to convert from MEP design elements to fabrication parts.
      @serviceId: The identifier of the fabrication service.
      Throws ArgumentException: the selection contains invalid elements to convert. -or- the specified fabrication service is not valid for all domains in the selection.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: no fabrication configuration is loaded.
    void Dispose()
    ISet<ElementId> GetConvertedFabricationParts()
      Description: Gets the set of element identifiers for newly created fabrication parts.
    IDictionary<ElementId, ElementId> GetConvertedFabricationPartsWithInvalidConnections()
      Description: Gets the collection of converted fabrication parts with invalid connections.
    IDictionary<ElementId, ISet<ElementId>> GetDesignElementAndFabricationPartsWithDifferentOffsets()
      Description: Gets the collection of design elements that failed to convert and the associated set of fabrication parts with different offsets.
      Returns: A map of design element identifiers that were not converted and the associated set fabrication parts left with different offsets.
    IDictionary<ElementId, ISet<ElementId>> GetDesignElementAndFabricationPartsWithOpenConnectors()
      Description: Gets the collection of design elements that failed to convert and the associated set of fabrication parts with open connectors.
      Returns: A map of design element identifiers that were not converted and the associated set fabrication parts left with open connectors.
    ISet<ElementId> GetElementsWithOpenConnector()
      Description: Gets the set of fabrication part or MEP design element identifiers with open connectors, caused by fittings failing to convert.
    IList<PartialFailureResults> GetPartialConvertFailureResults()
      Description: Gets the partial failure results.
    DesignToFabricationMappingResult SetMapForFamilySymbolToFabricationPartType(IDictionary<ElementId, ElementId> typeMappings)
      Description: Set a map for the conversion of in line family symbols to similar fabrication part types.
      @typeMappings: The map containing the family symbol element identifiers to the fabrication part type element identifiers to convert to.
      Returns: If the mapping is properly structured, DesignToFabricationMappingResult.Success is returned. Otherwise, consult the members of DesignToFabricationMappingResult to understand why this call failed.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] DesignToFabricationConverterResult
Full Name: Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult
Description: Possible results from invoking the DesignToFabricationConverter.
Inherits: Enum

  Values:
    - Success = 0
    - PartialFailure = 1

--------------------------------------------------------------------------------

[ENUM] DesignToFabricationMappingResult
Full Name: Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult
Description: Possible results from setting the mapping from Family symbols to Fabrication part types.
Inherits: Enum

  Values:
    - Success = 0
    - Undefined = 1
    - InvalidFamilySymbol = 2
    - InvalidFabricationPartType = 3
    - UnsupportedFamilySymbol = 4
    - UnsupportedFabricationPartType = 5

--------------------------------------------------------------------------------

[ENUM] FabricationAncillaryType
Full Name: Autodesk.Revit.DB.Fabrication.FabricationAncillaryType
Description: An enumerated type listing all fabrication ancillary types.
Inherits: Enum

  Values:
    - Unknown = 0
    - Fixing = 1
    - Corner = 2
    - Clip = 3
    - TieRod = 4
    - Gasket = 5
    - Sealant = 6
    - SupportRod = 7
    - AncillaryMaterial = 8
    - AirturnTrack = 9
    - AirturnVane = 10
    - Isolator = 11
    - SeamMaterial = 12

--------------------------------------------------------------------------------

[ENUM] FabricationAncillaryUsageType
Full Name: Autodesk.Revit.DB.Fabrication.FabricationAncillaryUsageType
Description: An enumerated type describing where an ancillary is used on a fabrication part.
Inherits: Enum

  Values:
    - Undefined = 0
    - Loose = 1
    - Connector = 2
    - Seam = 3
    - Splitter = 4
    - Airturn = 5
    - Hanger = 6
    - Stiffener = 7

--------------------------------------------------------------------------------

[ENUM] FabricationCustomDataType
Full Name: Autodesk.Revit.DB.Fabrication.FabricationCustomDataType
Description: An enumerated type listing all fabrication custom data value types.
Inherits: Enum

  Values:
    - Text = 1
    - Integer = 2
    - Real = 3

--------------------------------------------------------------------------------

[ENUM] FabricationHandlePosition
Full Name: Autodesk.Revit.DB.Fabrication.FabricationHandlePosition
Description: Position of fabrication part valve handle.
Inherits: Enum

  Values:
    - Closed = 0
    - Open = 1
    - Swept = 2
    - Undefined = -1

--------------------------------------------------------------------------------

[CLASS] FabricationNetworkChangeService
Full Name: Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeService
Description: This class represents the fabrication part change service and change size tools.
Remarks: After a new instance of the class is created, call the ChangeService method to change the service of the fabrication parts or call the ChangeSize method to change the size of the fabrication parts. There is another workflow allowing for more control, call SetSelection to set the selection of fabrication parts to change. To change the service, call SetServiceId and SetPaletteId to set the service identifier and palette identifier. Changing the service there is an optional methods GetInLinePartTypes and SetMapOfSizesForStraights that can be called to replace in-line valves and dampers to the corresponding parts for the new service. The size can also be changed by calling GetMapOfAllSizesForStraights that will return a FabricationPartSizeMapSet containing a map of sizes for all straights found in the selection of fabrication parts. The FabricationPartSizeMapSet can then be modified to set the mapped values for the new size for the fabrication part straights and then call SetMapOfSizesForStraights set the new sizes that are to be applied. Finally call ApplyChange to apply the previously set parameters to the selection of fabrication parts. GetStraightsThatWereNotChanged to get a set of fabrication part straight element identifiers that were not changed.GetElementsThatFailed to get a set of fabrication part element identifiers that had failures.
Implements: IDisposable

  CONSTRUCTORS:
    new FabricationNetworkChangeService(Document document)
      Description: Creates a new instance of the FabricationNetworkChangeService class.
      @document: A document in which to change the service or size of the selected fabrication parts.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    FabricationNetworkChangeServiceResult ApplyChange()
      Description: Applies the previously set changes to the selection of fabrication parts to change the size, change the service, or both.
      Throws ArgumentException: The selection contains invalid elements to change.
      Throws InvalidOperationException: No fabrication configuration is loaded.
    FabricationNetworkChangeServiceResult ChangeService(ISet<ElementId> selection, int serviceId, int paletteId, bool restrictPalette)
      Description: Changes the service of the selection of fabrication parts.
      @selection: The set of element identifiers of fabrication parts to change the service for.
      @serviceId: The identifier of the fabrication service.
      @paletteId: The identifier of the fabrication palette.
      @restrictPalette: Restrict the placement of parts to the passed in palette identifier.
      Throws ArgumentException: The selection contains invalid elements to change.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: No fabrication configuration is loaded.
    FabricationNetworkChangeServiceResult ChangeService(ISet<ElementId> selection, int serviceId, int paletteId)
      Description: Changes the service of the selection of fabrication parts.
      @selection: The set of element identifiers of fabrication parts to change the service for.
      @serviceId: The identifier of the fabrication service.
      @paletteId: The identifier of the fabrication palette.
      Throws ArgumentException: The selection contains invalid elements to change.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: No fabrication configuration is loaded.
    FabricationNetworkChangeServiceResult ChangeSize(ISet<ElementId> selection, ISet<FabricationPartSizeMap> fabricationPartSizeMaps)
      Description: Changes the size of the selection of fabrication parts.
      @selection: The set of element identifiers of fabrication parts to change the size for.
      @fabricationPartSizeMaps: The map containing the original sizes for the straights to the new sizes.
      Throws ArgumentException: The selection contains invalid elements to change. -or- The fabrication size map is empty.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: No fabrication configuration is loaded.
    void Dispose()
    bool GetDeletePartFailureState()
      Description: Get the state if the element will be deleted when change the service encounters an error or not.
      Returns: Returns true if if the element will be deleted otherwise false.
    ISet<ElementId> GetElementsThatFailed()
      Description: Gets the set of fabrication parts that had failures due to either there was no corresponding part in the service, the size was out of range, or a connection could not be made.
    ISet<ElementId> GetInLinePartTypes()
      Description: Get a set of element identifiers of fabrication part types for in-line parts.
      Returns: Returns the set of element identifiers for in-line parts or an empty set if there are none.
    ISet<FabricationPartSizeMap> GetMapOfAllSizesForStraights()
      Description: Get a set of FabricationPartSizeMapSet of all straight sizes for all services.
      Returns: Returns the map of sizes for straights or an empty map if there are none.
    bool GetPartTypeMappingState()
      Description: Get the state for part type mapping.
      Returns: Returns true if part type mapping is enabled otherwise false.
    ISet<ElementId> GetPartTypesforMapping()
      Description: Get a set of element identifiers of fabrication part types that can be mapped.
      Returns: Returns the set of element identifiers for part types or an empty set if there are none.
    ISet<ElementId> GetStraightsThatWereNotChanged()
      Description: Gets the set of fabrication part straights that were not changed due to either there was no corresponding part in the service or the size was out of range.
    void SetDeletePartFailureState(bool state)
      Description: Set the state to delete or keep the element if errors are posted by changing the service. Set to true so the mappings are applied otherwise false.
    void SetMapOfInLinePartTypes(IDictionary<ElementId, ElementId> fabricationPartTypes)
      Description: Set the mapping of fabrication part types for in-line parts for the service and palette to change to.
      @fabricationPartTypes: The map containing the original fabrication part type to the fabrication part type to change to.
      Throws ArgumentNullException: A non-optional argument was null
    void SetMapOfSizesForStraights(ISet<FabricationPartSizeMap> fabricationPartSizeMaps)
      Description: Set the mapping for sizes of fabrication part straights to change the sizes to.
      @fabricationPartSizeMaps: The map containing the original straights size to the mapped sizes.
      Throws ArgumentNullException: A non-optional argument was null
    void SetPaletteId(int paletteId)
      Description: Set the fabrication palette identifier to change the elements to.
    void SetPartTypeMappingState(bool state)
      Description: Set the state to enable or disable part type mappings when changing the service. Set to true so the mappings are applied otherwise false.
    void SetPartTypesforMapping(IDictionary<ElementId, ElementId> fabricationPartTypes)
      Description: Set a map of element identifiers of fabrication part types that will be mapped when the change service is applied. When part types in the map are encountered, they will be updated to the associated map component. This overrides the default parts that can be used by route and fill solutions driven by the fabrication configuration and service. Set the fabrication part types for parts for the service and palette to map too.
      @fabricationPartTypes: The map containing the original fabrication part type to the mapped fabrication part type to change to.
      Throws ArgumentNullException: A non-optional argument was null
    void SetRestrictPalette(bool restrictPalette)
      Description: Restrict the placement of parts to only use parts associated to the passed in fabrication palette identifier.
    FabricationNetworkChangeServiceResult SetSelection(ISet<ElementId> selection)
      Description: Set the element selection to change the service or size for.
      @selection: The set of element identifiers of fabrication parts to change the service or size for.
      Throws ArgumentNullException: A non-optional argument was null
    void SetServiceId(int serviceId)
      Description: Set the fabrication service identifier to change the elements to.

--------------------------------------------------------------------------------

[ENUM] FabricationNetworkChangeServiceResult
Full Name: Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult
Description: Possible results from invoking the FabricationNetworkChangeService.
Inherits: Enum

  Values:
    - Success = 0
    - PartialFailure = 1
    - UserAborted = 2
    - InvalidSelection = 3

--------------------------------------------------------------------------------

[ENUM] FabricationPartCompareType
Full Name: Autodesk.Revit.DB.Fabrication.FabricationPartCompareType
Description: Fabrication Part Comparison Types
Inherits: Enum

  Values:
    - CutType = 1
    - Material = 2
    - Specification = 3
    - InsulationSpecification = 4
    - MaterialGauge = 5
    - DuctFacing = 6
    - Insulation = 7
    - Notes = 8
    - Filename = 9
    - Description = 10
    - CID = 11
    - SkinMaterial = 12
    - SkinGauge = 13
    - Section = 14
    - Status = 15
    - Service = 16
    - Pallet = 17
    - BoxNo = 18
    - OrderNo = 19
    - Drawing = 20
    - Zone = 21
    - ETag = 22
    - Alt = 23
    - Spool = 24
    - Alias = 25
    - PCFKey = 26
    - CustomData = 27
    - ButtonAlias = 28

--------------------------------------------------------------------------------

[ENUM] FabricationPartFitResult
Full Name: Autodesk.Revit.DB.Fabrication.FabricationPartFitResult
Description: Fabrication part stretch/fill result.
Inherits: Enum

  Values:
    - Success = 0
    - IncompatibleGeometry = 1
    - MisalignedEnds = 2
    - DimensionLocked = 3
    - BadDimensions = 4
    - ShapeMismatch = 5
    - SizeMismatch = 6
    - IncompatibleConnection = 7
    - OffsetRequired = 8
    - Unsupported = 255

--------------------------------------------------------------------------------

[ENUM] FabricationPartJustification
Full Name: Autodesk.Revit.DB.Fabrication.FabricationPartJustification
Description: Fabrication part eccentric justifications for alignment for flat edged parts.
Inherits: Enum

  Values:
    - Middle = 0
    - Bottom = 1
    - Top = 2

--------------------------------------------------------------------------------

[ABSTRACT CLASS] FabricationPartPlacementUtils
Full Name: Autodesk.Revit.DB.Fabrication.FabricationPartPlacementUtils
Description: General utility placement methods in the Autodesk Revit MEP product for fabrication.

--------------------------------------------------------------------------------

[CLASS] FabricationPartRouteEnd
Full Name: Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd
Description: Class to hold fabrication part routing start or end information.
Remarks: To create a new instance, use Connector) to specify a connector, or XYZ) to specify the centerline of a straight element, for the fabrication routing end point.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static FabricationPartRouteEnd CreateFromCenterline(Element element, XYZ ptAt)
      Description: Create fabrication routing end from centerline point on straight element.
      @element: The straight element that the centerline is on.
      @ptAt: A point along the straight element where the fitting to be cut in should be positioned.
      Throws ArgumentNullException: A non-optional argument was null
    static FabricationPartRouteEnd CreateFromConnector(Connector connnector)
      Description: Create fabrication routing end from connector end point.
      @connnector: The connector that the route will connect to. The connector cannot have an existing connection.
      Throws ArgumentException: Connector is connected.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] FabricationPartSizeMap
Full Name: Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap
Description: This class represents the fabrication part size map for straights allowing the sizes to be changed from a user interface for multiple straights with diffent sizes.
Remarks: This is used as the data container for the FabricationPartSizeMapSet typeDef for crs:Set or Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap for ISet so a list of sizes can be generated to allow the user to select a size and map it to another.
Implements: IDisposable

  CONSTRUCTORS:
    new FabricationPartSizeMap(string size, double widthDiameter, double depth, bool isProductList, ConnectorProfileType profileType, int serviceId, int paletteId)
      Description: Creates a new instance of the FabricationPartSizeMap class.
      @size: The size display string for the straight that can be used by the user interface.
      @widthDiameter: The width or diameter of the straight.
      @depth: The depth of the straight.
      @isProductList: Set if the straight a product list or not.
      @profileType: Set the shape of the straight.
      @serviceId: Set the service identifier of the straight.
      @paletteId: Set the palette identifier of the straight.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new FabricationPartSizeMap(string size, double widthDiameter, double depth, bool isProductList)
      Description: Creates a new instance of the FabricationPartSizeMap class.
      @size: The size display string for the straight that can be used by the user interface.
      @widthDiameter: The width or diameter of the straight.
      @depth: The depth of the straight.
      @isProductList: Set if the straight a product list or not.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool AllowMultipleServiceSizes { get; set; }
      Description: State flag to allow multiple services to include the same size.
    double Depth { get; set; }
      Description: The depth of the straight.
    bool IsMappedProductList { get; set; }
      Description: Are the mapped sizes for a product listed fabrication part.
    bool IsProductList { get; set; }
      Description: Are the sizes for a product listed fabrication part.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MappedDepth { get; set; }
      Description: The mapped size for the depth of the straight.
    ConnectorProfileType MappedProfileType { get; set; }
      Description: The mapped shape of the straight.
    int MappedServiceId { get; set; }
      Description: The mapped service identifier of the straight.
    double MappedWidthDiameter { get; set; }
      Description: The mapped size for the width or diameter of the straight.
    int PaletteId { get; set; }
      Description: The palette identifier of the straight.
    ConnectorProfileType ProfileType { get; set; }
      Description: The shape of the straight.
    int ServiceId { get; set; }
      Description: The service identifier of the straight.
    string SizeString { get; set; }
      Description: The size display string for the straight that can be used by the user interface.
    double WidthDiameter { get; set; }
      Description: The width or diameter of the straight.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] FabricationSaveJobOptions
Full Name: Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions
Description: Options for FabricationPart.SaveAsFabricationJob() method.
Implements: IDisposable

  CONSTRUCTORS:
    new FabricationSaveJobOptions(bool addHolesForTaps)
      Description: Constructor
      @addHolesForTaps: Set true to have holes for taps on straights added to the created fabrication job.
    new FabricationSaveJobOptions()
      Description: Default Constructor

  PROPERTIES:
    bool AddHolesForTaps { get; set; }
      Description: Set true to have holes for taps on straights added to the created fabrication job.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] FabricationUtils
Full Name: Autodesk.Revit.DB.Fabrication.FabricationUtils
Description: General utility methods in the Autodesk Revit MEP product for fabrication.

  METHODS:
    static void ExportToPCF(Document document, IList<ElementId> ids, string filename)
      Description: Exports a list of fabrication parts into PCF format.
      @document: The document.
      @ids: An array of FabricationPart element identifiers. Non-fabrication parts are ignored.
      @filename: The name given to the output file.
      Throws ArgumentException: Fabrication configuration is missing.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ValidateConnectivity(Document document, Connector connector1, Connector connector2)
      Description: Check if two connectors are valid to connect directly without couplings.
      @document: The document.
      @connector1: First connector to check.
      @connector2: Second connector to check against.
      Returns: True if connection is valid otherwise false.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] PartialFailureResults
Full Name: Autodesk.Revit.DB.Fabrication.PartialFailureResults
Description: Possible results of the partial failure from invoking the DesignToFabricationConverter.
Inherits: Enum

  Values:
    - NotAllPartsConverted = 0
    - InvalidConnections = 1
    - HaveOpenConnectors = 2
    - HaveDifferentOffsets = 3
    - NoMatchingSize = 4

--------------------------------------------------------------------------------

[ENUM] ValidationStatus
Full Name: Autodesk.Revit.DB.Fabrication.ValidationStatus
Description: Lists the validation type of the fabrication part.
Inherits: Enum

  Values:
    - Valid = 0
    - InvalidDimensions = 1
    - NoMaterial = 2

--------------------------------------------------------------------------------

