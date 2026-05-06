# Autodesk.Revit.DB (Types: F, G)

[CLASS] FabricationAncillaryUsage
Full Name: Autodesk.Revit.DB.FabricationAncillaryUsage

Description: Structure that holds information about the usage of a fabrication ancillary
Implements: IDisposable

  PROPERTIES:
    double AncillaryDepth { get; }
      Description: Depth of required ancillary if it isn't round.
    int AncillaryId { get; }
      Description: Fabrication ancillary database identifier.
    double AncillaryWidthOrDiameter { get; }
      Description: Width or diameter of required ancillary.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Length { get; }
      Description: Length of required ancillaries.
    string ProductCode { get; }
      Description: A unique string code that idnenifies the ancillary in the fabriction database in order to purchase it.
    double Quantity { get; }
      Description: Quantity of required ancillaries.
    FabricationAncillaryType Type { get; }
      Description: Fabrication ancillary type.
    FabricationAncillaryUsageType UsageType { get; }
      Description: Fabrication ancillary usage type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] FabricationConfiguration
Full Name: Autodesk.Revit.DB.FabricationConfiguration

Description: This element contains the information about the fabrication configuration settings used by the project.
Remarks: The element provides information about the location of the fabrication database, its properties, and settings related to fabrication items.
Inherits: Element
Implements: IDisposable

  METHODS:
    bool AncillaryExists(int ancillaryId)
      Description: Checks to see if the specified ancillary exists.
      @ancillaryId: The ancillary identifier.
      Returns: Returns true if the ancillary exists.
    bool AreItemFilesLoaded(IList<FabricationItemFile> itemFiles)
      Description: Checks if the fabrication item files have been loaded.
      @itemFiles: The fabrication item files.
      Returns: Returns true if the fabrication item files have been loaded, false otherwise.
    bool CanBeSwapped()
      Description: Checks if the fabrication configuration can be swapped.
      Returns: True if the fabrication configuration can be swapped, false otherwise.
    bool CanUnloadItemFiles(IList<FabricationItemFile> itemFiles)
      Description: Checks if the fabrication item files are already in use and should not be unloaded.
      @itemFiles: The fabrication item files to unload.
      Returns: Returns true if the fabrication item files can be unloaded, false otherwise.
    int CheckConnectionsForAllFabricationParts()
      Description: Checks the connections for all fabrication parts in the current project. It will create reviewable warnings for all bad connections found. The checks are looking for bad alignments or gaps, incompatible connection types, mismatches of size, mismatches of shapes.
      Returns: The number of bad connections found.
    bool CustomDataExists(int customDataId)
      Description: Checks to see if the specified custom data exists.
      @customDataId: The custom data identifier.
      Returns: Returns true if the custom data exists.
    bool DamperExists(int damperId)
      Description: Checks to see if the specified damper exists.
      @damperId: The damper identifier to check.
      Returns: Returns true if the damper exists.
    IList<int> GetAllDampers()
      Description: Gets all damper identifiers in the fabrication configuration.
      Returns: An array of specification identifiers.
    IList<int> GetAllFabricationConnectorDefinitions(ConnectorDomainType domain, ConnectorProfileType shape)
      Description: Gets fabrication connector identifiers from the fabrication configuration, filtered by shape and domain.
      @domain: ConnectorDomainType to filter by. Pass ConnectorDomainType.Undefined to get all connector domains.
      @shape: ConnectorProfileType to filter by. Pass ConnectorProfileType.Invalid to get all shapes.
      Returns: All the fabrication connector identifiers, filtered by shape and domain. The return will be empty if no connectors are found.
    IList<int> GetAllInsulationSpecifications(FabricationPart pFabPart)
      Description: Gets all insulation specification identifiers in the fabrication configuration.
      @pFabPart: The fabrication part.
      Returns: An array of insulation specification identifiers.
    IList<FabricationItemFile> GetAllLoadedItemFiles()
      Description: Get list of all loaded fabrication item files.
      Returns: Returns an array of the loaded fabrication item files.
    IList<FabricationService> GetAllLoadedServices()
      Description: Returns all the loaded fabrication services.
      Returns: All the loaded fabrication services.
    IList<int> GetAllMaterials(FabricationPart part)
      Description: Gets all material identifiers in the fabrication configuration.
      @part: The fabrication part.
      Returns: An array of material identifiers.
    IList<int> GetAllPartCustomData()
      Description: Gets all possible fabrication part custom data identifiers.
      Returns: An array of custom data identifiers.
    IList<int> GetAllPartStatuses()
      Description: Gets all possible fabrication part status identifiers.
      Returns: An array of status identifiers.
    IList<FabricationService> GetAllServices()
      Description: Returns all fabrication services in the fabrication configuration.
      Returns: All fabrication services. The return will be empty if no services are found.
    IList<int> GetAllSpecifications(FabricationPart part)
      Description: Gets all specification identifiers in the fabrication configuration.
      @part: The fabrication part.
      Returns: An array of specification identifiers.
    IList<FabricationItemFile> GetAllUsedItemFiles()
      Description: Returns all the used fabrication item files. A fabrication item file is used if any fabrication parts in the model were created from it.
      Returns: All the used fabrication item files.
    IList<FabricationService> GetAllUsedServices()
      Description: Returns all the used fabrication services. A service is used if any fabrication part in the service is created by user.
      Returns: All the used fabrication services.
    IList<int> GetAncillaries(FabricationAncillaryType type, bool includeKits, bool filterKits)
      Description: Gets fabrication ancillaries of the specified type.
      @type: The type of ancillaries to get.
      @includeKits: Whether or not to include ancillary kits as well.
      @filterKits: Whether kits should be filtered to only those that contain the specified ancillary type.
      Returns: An array of ancillary identifiers.
    string GetAncillaryGroup(int ancillaryId)
      Description: Gets the fabrication ancillary group of the specified fabrication ancillary identifier.
      @ancillaryId: The fabrication ancillary database identifier of the ancillary.
      Returns: The group name of the ancillary.
    string GetAncillaryGroupName(int ancillaryId)
      Description: Gets the fabrication ancillary group and name for the specified fabrication ancillary identifier.
      @ancillaryId: The fabrication ancillary database identifier of the ancillary.
      Returns: The group and name of the ancillary.
    string GetAncillaryName(int ancillaryId)
      Description: Gets the fabrication ancillary name for the specified fabrication ancillary identifier.
      @ancillaryId: The fabrication ancillary database identifier of the ancillary.
      Returns: The name of the ancillary.
    string GetDamperName(int damperId)
      Description: Gets the damper name from its identifier.
      @damperId: The damper identifier.
      Returns: The damper name.
    static FabricationConfiguration GetFabricationConfiguration(Document document)
      Description: Gets the fabrication configuration element in the document.
      @document: The document.
      Returns: The fabrication configuration element in the document.
    FabricationConfigurationInfo GetFabricationConfigurationInfo()
      Description: Gets the information about the fabrication configuration of the project.
      Returns: The information about the fabrication configuration of the project.
    ConnectorDomainType GetFabricationConnectorDomain(int fabricationConnectorId)
      Description: Gets the fabrication connector domain from its identifier.
      @fabricationConnectorId: The fabrication connector identifier.
      Returns: The fabrication connector's domain.
    string GetFabricationConnectorGroup(int fabricationConnectorId)
      Description: Gets the fabrication connector group from its identifier.
      @fabricationConnectorId: The fabrication connector identifier.
      Returns: The fabrication connector's group.
    string GetFabricationConnectorName(int fabricationConnectorId)
      Description: Gets the fabrication connector name from its identifier.
      @fabricationConnectorId: The fabrication connector identifier.
      Returns: The fabrication connector's name.
    ConnectorProfileType GetFabricationConnectorShape(int fabricationConnectorId)
      Description: Gets the fabrication connector shape from its identifier.
      @fabricationConnectorId: The fabrication connector identifier.
      Returns: The fabrication connector's shape.
    string GetInsulationSpecificationAbbreviation(int insulationSpecificationId)
      Description: Gets insulation specification abbreviation.
      @insulationSpecificationId: The insulation specification identifier.
    string GetInsulationSpecificationGroup(int specId)
      Description: Gets the insulation specification group from its identifier.
      @specId: The insulation specification identifier.
      Returns: The insulation specification group.
    string GetInsulationSpecificationName(int specId)
      Description: Gets the insulation specification name from its identifier.
      @specId: The insulation specification identifier.
      Returns: The insulation specification name.
    IList<FabricationItemFolder> GetItemFolders()
      Description: Gets a list of fabrication item folders in the fabrication item folder structure.
      Returns: Returns a list of fabrication item folders in the fabrication item folder structure.
    string GetMaterialAbbreviation(int materialId)
      Description: Gets the abreviation of the material or the insulation or the double wall material.
      @materialId: The material identifier.
    int GetMaterialByGUID(Guid materialGUID)
      Description: Gets the material identifier by its GUID.
      @materialGUID: The material GUID.
      Returns: The material identifier. Returns 0 if not found.
    int GetMaterialGaugeByGUID(Guid gaugeGUID, int materialId)
      Description: Gets the material gauge identifier by its GUID and material identifier.
      @gaugeGUID: The material gauge GUID.
      @materialId: The material identifier. The same material gauge GUID could have different material gauge identifiers for different materials.
      Returns: The gauge identifier. Returns 0 if not found.
    Guid GetMaterialGaugeGUID(int materialId, int gaugeId)
      Description: Gets the material gauge GUID by its material/gauge identifiers.
      @materialId: The material identifier. The same material gauge GUID could have different material gauge identifiers for different materials.
      @gaugeId: The material gauge identifier.
      Returns: The material gauge GUID. Returns empty GUID if not found.
    string GetMaterialGroup(int materialId)
      Description: Gets material group from its identifier.
      @materialId: The material identifier.
      Returns: The material group.
    Guid GetMaterialGUID(int materialId)
      Description: Gets the material GUID by its identifier.
      @materialId: The material identifier.
      Returns: The material GUID. Returns empty GUID if not found.
    string GetMaterialName(int materialId)
      Description: Gets material name from its identifier.
      @materialId: The material identifier.
      Returns: The material name without the group.
    string GetPartCustomDataName(int customDataId)
      Description: Gets the custom data name from its identifier.
      @customDataId: The custom data identifier.
      Returns: The custom data name.
    FabricationCustomDataType GetPartCustomDataType(int customDataId)
      Description: Gets the custom data type from its identifier. See FabricationCustomDataType enumerator.
      @customDataId: The custom data identifier.
      Returns: The custom data type.
    string GetPartStatusDescription(int statusId)
      Description: Gets the status description from its identifier.
      @statusId: The status identifier.
      Returns: The status description.
    string GetProfile()
      Description: Return the profile of the loaded fabrication configuration. Return empty string for global profile.
    FabricationService GetService(int serviceId)
      Description: Get the service based on the service identifier from the fabrication configuration in the current document.
      @serviceId: The service identifier.
      Returns: The service based on the service identifier.
    int GetServiceByGUID(Guid serviceGUID)
      Description: Gets the service identifier by its GUID.
      @serviceGUID: The service GUID.
      Returns: The service identifier. Returns 0 if not found.
    Guid GetServiceGUID(int serviceId)
      Description: Gets the service GUID by its identifier.
      @serviceId: The service identifier.
      Returns: The service GUID. Returns empty GUID if not found.
    string GetServiceTypeName(int serviceTypeId)
      Description: Gets the service type name.
      @serviceTypeId: The service type identifier.
    string GetSpecificationAbbreviation(int specificationId)
      Description: Gets specification abbreviation.
      @specificationId: The specification identifier.
    int GetSpecificationByGUID(Guid specificationGUID)
      Description: Gets the specification identifier by its GUID.
      @specificationGUID: The specification GUID.
      Returns: The specification identifier. Returns 0 if not found.
    string GetSpecificationGroup(int specId)
      Description: Gets the specification group from its identifier.
      @specId: The specification identifier.
      Returns: The specification group.
    Guid GetSpecificationGUID(int specificationId)
      Description: Gets the specification GUID by its identifier.
      @specificationId: The specification identifier.
      Returns: The specification GUID. Returns empty GUID if not found.
    string GetSpecificationName(int specId)
      Description: Gets the specification name from its identifier.
      @specId: The specification identifier.
      Returns: The specification name;
    ISet<ElementId> GetUpdatedStraightsFromValidateConnections()
      Description: Get the set of element identifiers of fabrication part straights that were previously updated. If there were no straights were updated it will return an empty set of element identifiers.
      Returns: Returns the set of element identifiers of fabrication part straights that were updated.
    bool HasValidConfiguration()
      Description: Checks whether a valid fabrication configuration has been set for the project.
      Returns: True if a valid fabrication configuration has been set for the project.
    bool IsAncillaryKit(int ancillaryId)
      Description: Gets whether the specified fabrication ancillary identifier is an ancillary kit or not.
      @ancillaryId: The fabrication ancillary database identifier of the ancillary.
      Returns: Returns true if the ancillary is a kit.
    IList<FabricationItemFile> LoadItemFiles(IList<FabricationItemFile> itemFiles)
      Description: Loads the specified fabrication item files into the project.
      @itemFiles: The relative paths of the fabrication item files to load.
      Returns: The relative paths of the fabrication item files which failed to load.
    IList<int> LoadServices(IList<int> serviceIds)
      Description: Loads the specified fabrication services into the project.
      @serviceIds: The identifiers of the fabrication services to load.
      Returns: The identifiers of the fabrication services which failed to load.
    int LocateFabricationConnector(string group, string name, ConnectorDomainType domain, ConnectorProfileType shape)
      Description: Gets the fabrication connector identifiers by group and name, filtered by shape and domain.
      @group: The fabrication connector group.
      @name: The fabrication connector name.
      @domain: ConnectorDomainType to filter by. Pass ConnectorDomainType::Undefined to get all connector domains.
      @shape: ConnectorProfileType to filter by. Pass ConnectorProfileType::Invalid to get all shapes.
      Returns: Return the fabrication connector identifier. Returns -1 if not found.
    int LocateInsulationSpecification(string group, string name)
      Description: Gets the insulation specification by group and name.
      @group: The insulation specification group.
      @name: The insulation specification name.
      Returns: The insulation specification identifier. Returns -1 if not found.
    int LocateMaterial(string group, string name)
      Description: Gets material by group and name.
      @group: The material group.
      @name: The group name.
      Returns: The material identifier. Returns -1 if not found.
    int LocateSpecification(string group, string name)
      Description: Gets the specification identifier by group and name.
      @group: The specification group.
      @name: The specification name.
      Returns: The specification identifier. Returns -1 if not found.
    void PostReviewableWarningsForBadConnections(ConnectionValidationInfo info)
      Description: Reviewable warnings are created for all entries contained in the connection validation information.
      @info: The connection information created from the connection validation check.
    ConfigurationReloadInfo ReloadConfiguration()
      Description: Reloads the fabrication configuration from its source fabrication configuration.
      Returns: The information about the reload of the fabrication configuration.
    void SetConfiguration(FabricationConfigurationInfo fabricationConfigurationInfo, string profile)
      Description: Set the fabrication configuration with specific profile.
      @fabricationConfigurationInfo: The desired fabrication configuration.
      @profile: The desired profile of the fabrication configuration. Use empty string for the global profile.
    void SetConfiguration(FabricationConfigurationInfo fabricationConfigurationInfo)
      Description: Set the fabrication configuration with global profile.
      @fabricationConfigurationInfo: The desired fabrication configuration.
    bool SetServicesToLoad(IList<int> serviceIds)
      Description: Sets the services which are to be loaded or not next time reloadConfiguration is called. If a service is not included but is currently loaded then it will be unloaded then.
      Returns: Returns true if successful. May fail if any service currently loaded is not included and is in use so cannot be unloaded.
    void UnloadItemFiles(IList<FabricationItemFile> itemFiles)
      Description: Unload the specified fabrication item files from the project.
      @itemFiles: The fabrication item files to unload.
    void UnloadServices(IList<int> serviceIds)
      Description: Unload the specified fabrication services from the project.
      @serviceIds: The identifiers of the fabrication services to unload.
    ConnectionValidationInfo ValidateConnectionsForAllFabricationParts(bool updateGapForStraights)
      Description: Validates all fabrication part connections in the current project. Invalid connections found will be added to the connection validation information class. The validation checks for bad alignments or gaps, incompatible connection types, mismatches of size, mismatches of shapes.
      @updateGapForStraights: Attempt to update straights to remove the gap between the connctors.
      Returns: The information about the validation check.

--------------------------------------------------------------------------------


[CLASS] FabricationConfigurationInfo
Full Name: Autodesk.Revit.DB.FabricationConfigurationInfo

Description: Represents an MEP object that holds the properties of an MEP fabrication configuration.
Remarks: To populate the Path property, you may need to call FindSourceFabricationConfiguration first.
Implements: IDisposable

  PROPERTIES:
    string CloudId { get; }
      Description: The identifier of the cloud configuration.
    string Description { get; }
      Description: The description of the fabrication configuration.
    Guid GUID { get; }
      Description: The unique identification of the fabrication configuration.
    bool IsCloudConfiguration { get; }
      Description: Whether the cloud configuration is a remote cloud one.
    bool IsLocked { get; }
      Description: Checks whether the fabrication configuration is locked. If true, the configuration is locked and cannot be removed.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The name of the fabrication configuration.
    string Path { get; }
      Description: The path where the fabrication configuration is located. To populate this property, you may need to call FindSourceFabricationConfiguration first.
    UnitSystem UnitSystem { get; }
      Description: The unit system of the fabrication configuration. Units can be UnitSystem.Metric or UnitSystem.Imperial.
    double Version { get; }
      Description: The version of the fabrication configuration.

  METHODS:
    void Dispose()
    static FabricationConfigurationInfo FindSourceFabricationConfiguration(FabricationConfigurationInfo fabricationConfiguration)
      Description: Finds the source fabrication configuration on disk which matches the input fabrication configuration.
      @fabricationConfiguration: The fabrication configuration to match.
      Returns: The matching source fabrication configuration.
    static IList<FabricationConfigurationInfo> GetAllFabricationConfigurations()
      Description: Gets all added fabrication configurations.
      Returns: All added fabrication configurations.
    IList<string> GetProfiles()
      Description: Return the profiles in the fabrication configuration.
    bool IsValid()
      Description: Checks if the fabrication configuration is valid.
      Returns: True if the fabrication configuration is valid.

--------------------------------------------------------------------------------


[CLASS] FabricationConnectorInfo
Full Name: Autodesk.Revit.DB.FabricationConnectorInfo

Description: Fabrication connector information.
Implements: IDisposable

  PROPERTIES:
    int BodyConnectorId { get; set; }
      Description: Fabrication body connector Id.
    int DoubleWallConnectorId { get; set; }
      Description: Fabrication double wall connector Id.
    int FabricationIndex { get; }
      Description: The index of the connector shown within the fabrication software.
    bool IsBodyConnectorLocked { get; set; }
      Description: Fabrication body connector lock.
    bool IsDoubleWallConnectorLocked { get; set; }
      Description: Fabrication double wall connector lock.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool HasDoubleWallConnector()
      Description: Checks if there are any double wall connectors fabricated.
      Returns: True if there are any double wall connectors fabricated.
    bool IsValid()
      Description: Checks if the connector has fabrication parameters associated with it that can be set.
      Returns: True if the connector has fabrication parameters associated with it that can be set.

--------------------------------------------------------------------------------


[CLASS] FabricationDimensionDefinition
Full Name: Autodesk.Revit.DB.FabricationDimensionDefinition

Description: Represents the definition of a single fabrication pattern dimension. Together all dimensions represent the parametric definition of the fabrication part.
Implements: IDisposable

  PROPERTIES:
    bool IsModifiable { get; }
      Description: If the fabrication dimension is modifiable by user.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: Fabrication dimension name.
    FabricationDimensionType Type { get; }
      Description: Fabrication dimension type.
    FabricationDimensionUnitType UnitType { get; }
      Description: Fabrication dimension unit type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] FabricationDimensionType
Full Name: Autodesk.Revit.DB.FabricationDimensionType

Description: Fabrication dimension type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Internal = 0
    - Width = 1
    - Depth = 2
    - Diameter = 3
    - Angle = 4
    - Length = 5


[ENUM] FabricationDimensionUnitType
Full Name: Autodesk.Revit.DB.FabricationDimensionUnitType

Description: Fabrication dimension unit type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - NoUnits = 0
    - Linear = 1
    - Angular = 2


[CLASS] FabricationHostedInfo
Full Name: Autodesk.Revit.DB.FabricationHostedInfo

Description: The fabrication hosted element information.
Remarks: A fabrication part may have a host, the FabricationHostedInfo stores the host information for the fabrication part.
Implements: IDisposable

  PROPERTIES:
    ElementId HostId { get; }
      Description: Returns the identifier of the host.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void DisconnectFromHost()
      Description: Disconnects the part from the host.
    void Dispose()
    Line GetBearerCenterline()
      Description: Gets the centerline of the bearer. The method is applicable only for bearer hanger.
      Returns: The centerline of the bearer.
    void PlaceOnHost(ElementId hostId, Connector hostConnector, double distance, double axisRotation)
      Description: Places the part on the specified host.
      @hostId: Identifier of the host fabrication part.
      @hostConnector: The connector of the host.
      @distance: The distance from the connector to place the hosted part. Units are in feet (ft).
      @axisRotation: The axis rotation in radians.
    void PlaceOnHost(ElementId hostId, Connector hostConnector, double distance)
      Description: Places the part on the specified host.
      @hostId: Identifier of the host fabrication part.
      @hostConnector: The connector of the host.
      @distance: The distance from the connector to place the hosted part. Units are in feet (ft).

--------------------------------------------------------------------------------


[CLASS] FabricationItemFile
Full Name: Autodesk.Revit.DB.FabricationItemFile

Description: This class holds information about the item file, including whether it is already loaded from disk into Revit.
Remarks: This object is created as a result of loading from disk.
Implements: IDisposable

  PROPERTIES:
    string Identifier { get; }
      Description: The string identifier for the item file. This string is unique and can be used to compare whether fabrication item files are the same file.
    bool IsUsed { get; }
      Description: Checks to see if the item file is already in use in the project.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Bitmap GetImage()
      Description: Gets the image for the fabrication item file.
      Returns: System.Drawing.Bitmap represents the fabrication item file image. if there is no preview image.
    bool IsLoaded()
      Description: Checks to see if the item file has been loaded into the configuration.
      Returns: Returns true if the item file has been loaded into the configuration, false otherwise.
    bool IsValid()
      Description: Checks to see if the item file is valid.
      Returns: Returns true if the item file is valid, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FabricationItemFolder
Full Name: Autodesk.Revit.DB.FabricationItemFolder

Description: A fabrication item folder that can contain sub folders and access to the s contained within.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The item folder's name.

  METHODS:
    void Dispose()
    IList<FabricationItemFile> GetItemFiles()
      Description: Gets the item files in this item folder.
    IList<FabricationItemFolder> GetSubFolders()
      Description: Gets the item folder's sub folders.

--------------------------------------------------------------------------------


[ENUM] FabricationMaterialType
Full Name: Autodesk.Revit.DB.FabricationMaterialType

Description: An enumerated type listing all fabrication material types.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Unknown = 0
    - Ductwork = 1
    - Pipework = 2
    - Containment = 3


[CLASS] FabricationPart
Full Name: Autodesk.Revit.DB.FabricationPart

Description: Represents a fabrication component in the Autodesk Revit MEP product.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    string Alias { get; }
      Description: The alias of the fabrication part.
    double BottomOfPartElevation { get; }
      Description: The associated elevation to the bottom of fabrication part off of the current level.
    double CenterlineLength { get; }
      Description: The centerline length of the fabrication part.
    ConnectorManager ConnectorManager { get; }
      Description: The connector manager of the fabrication part.
    int CutType { get; }
      Description: The cut type of the fabrication part.
    ConnectorDomainType DomainType { get; }
      Description: The domain type for the fabrication part.
    int DoubleWallMaterial { get; }
      Description: The double wall material identifier of the fabrication part.
    double DoubleWallMaterialArea { get; }
      Description: The double wall material area of the fabrication part. If the fabrication part is not double walled, returns zero.
    double DoubleWallMaterialThickness { get; }
      Description: The double wall material thickness of the fabrication part. If the fabrication part is not double walled, returns zero.
    string FreeSize { get; }
      Description: The inner size of the fabrication part.
    AssetPropertyUInt64 GeometryChecksum { get; }
      Description: Gets the geometry checksum of the fabrication part symbol, and it does nothing with the fabrication part instance position.
    int HangerRodKit { get; set; }
      Description: Specifies whether an ancillary kit is being used to override support rods, bolts and clips, if any. A value of 0 indicates no override is being used.
    bool HasDoubleWall { get; }
      Description: True if the fabrication part is double walled.
    bool HasInsulation { get; }
      Description: True if the fabrication part is insulated.
    bool HasLining { get; }
      Description: True if the fabrication part is lined.
    double InsulationArea { get; }
      Description: The insulation area of the fabrication part. If the fabrication part is not insulated, returns zero.
    int InsulationSpecification { get; set; }
      Description: The fabrication part insulation specification identifier.
    double InsulationThickness { get; }
      Description: The insulation thickness of the fabrication part. If the fabrication part is not insulated, returns zero.
    string InsulationType { get; }
      Description: The insulation type of the fabrication part.
    bool IsBoughtOut { get; }
      Description: True if the fabrication part is bought out.
    int ItemCustomId { get; }
      Description: The item custom identifier for the fabrication part.
    string ItemNumber { get; set; }
      Description: The item number that is used for identification, re-ordering from shop.
    double LevelOffset { get; }
      Description: The associated level offset that indicates the distance from the center of the fabrication part to the current level.
    double LiningArea { get; }
      Description: The lining area of the fabrication part. If the fabrication part is not lined, returns zero.
    double LiningThickness { get; }
      Description: The lining thickness of the fabrication part. If the fabrication part is not lined, returns zero.
    string LiningType { get; }
      Description: The lining type of the fabrication part.
    int Material { get; set; }
      Description: The fabrication material identifier.
    int MaterialGauge { get; }
      Description: The fabrication material gauge identifier.
    double MaterialThickness { get; }
      Description: The material thickness of the fabrication part.
    string Notes { get; set; }
      Description: The notes of the fabrication part.
    XYZ Origin { get; }
      Description: The origin of the fabrication part element.
    string OverallSize { get; }
      Description: The overall size of the fabrication part.
    Guid PartGuid { get; }
      Description: The fabrication part's globally unique identifier.
    int PartStatus { get; set; }
      Description: The status identifier for the fabrication part.
    string ProductCode { get; }
      Description: The current database id of the part within the fabrication database.
    string ProductDataRange { get; }
      Description: The product data range of the fabrication part.
    string ProductFinishDescription { get; }
      Description: The product finish description of the fabrication part.
    string ProductInstallType { get; }
      Description: The product install type of the fabrication part.
    int ProductListEntry { get; set; }
      Description: The product entry index of the fabrication part. A value of -1 indicates the fabrication part is not a product list.
    string ProductLongDescription { get; }
      Description: The product long description of the fabrication part.
    string ProductMaterialDescription { get; }
      Description: The product material description of the fabrication part.
    string ProductName { get; }
      Description: The product name of the fabrication part.
    string ProductOriginalEquipmentManufacture { get; }
      Description: The product original equipment manufacture (OEM) of the fabrication part.
    string ProductShortDescription { get; }
      Description: The product short description of the fabrication part.
    string ProductSizeDescription { get; }
      Description: The product size description of the fabrication part.
    string ProductSpecificationDescription { get; }
      Description: The product specification description of the fabrication part.
    string ServiceAbbreviation { get; }
      Description: The associated service abbreviation for the fabrication service.
    int ServiceId { get; set; }
      Description: The fabrication part service identifier. The service can only be changed to compatible services.
    string ServiceName { get; }
      Description: The name of the service associated with the fabrication part.
    int ServiceType { get; }
      Description: The service type identifier of the fabrication part.
    double SheetMetalArea { get; }
      Description: The sheet metal area of the fabrication part.
    string Size { get; }
      Description: The size of the fabrication part.
    double Slope { get; }
      Description: The slope for the straight fabrication part.
    int Specification { get; set; }
      Description: The fabrication part specification identifier.
    string SpoolName { get; set; }
      Description: The spool name of the fabrication part.
    double TopOfPartElevation { get; }
      Description: The associated elevation to the top of fabrication part off of the current level.
    ValidationStatus ValidationStatus { get; }
      Description: The validation status of the fabrication part.
    string Vendor { get; }
      Description: The vendor of the fabrication part.
    string VendorCode { get; }
      Description: The vendor code of the fabrication part.
    double Weight { get; }
      Description: The weight of the fabrication part.

  METHODS:
    bool AddPartCustomData(int customId)
      Description: Add custom data type to the fabrication part. The new data gets the default value defined by the fabrication configuration.
      @customId: The identifier of the custom data field to add.
      Returns: Returns true if the type was not already present.
    double AdjustEndLength(Connector connector, double lengthToAdjust, bool totalLengthOnly)
      Description: Adjusts the length for the specified connector.
      @connector: # The connector of the fabrication part to adjust length.
      @lengthToAdjust: The length to adjust.
      @totalLengthOnly: True if adjust the total length only when adjust length.
      Returns: The adjusted length.
    static bool AlignPartByConnector(Document document, Connector connector, XYZ position, double rotation, double rotationPerpendicular, double slope, FabricationPartJustification justification, Transform trf)
      Description: Align the part by its connector to a point and rotation in free space.
      @document: The document.
      @connector: The connector to align in free space.
      @position: The position to move the connector to.
      @rotation: The rotation in radians.
      @rotationPerpendicular: The perpendicular rotation for free placement around the Y axis direction of connection - angle in radians.
      @slope: The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied to fittings, whilst straights will inherit the slope from the piece it is connecting to.
      @justification: The justification to align eccentric parts.
      @trf: Optional alignment transformation matrix, eg. a Trf that describes plan or side elevation.
      Returns: True if the alignment succeeds, false otherwise.
    static bool AlignPartByConnectors(Document document, Connector connector, Connector toConnector, double axisRotation)
      Description: Moves fabrication part by one of its connectors and aligns it to another connector.
      @document: The document.
      @connector: The connector of the fabrication part to move and align by.
      @toConnector: The connector of the fabrication part or family to align to.
      @axisRotation: Rotation around the direction of connection - angle between width vectors in radians.
      Returns: True if alignment succeeds, false otherwise.
    static bool AlignPartByConnectorToConnector(Document document, Connector connector, Connector fixedConnector, double rotation, double slope, FabricationPartJustification justification)
      Description: Align a part by its connector to another connector. This will replace the FabricationPart::AlignPartByConnectors method.
      @document: The document.
      @connector: The connector of the fabrication part to move by in free space.
      @fixedConnector: The connector for the fabrication part or family connector to align to.
      @rotation: The rotation in radians.
      @slope: The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied to fittings, whilst straights will inherit the slope from the piece it is connecting to.
      @justification: The justification to align eccentric parts.
      Returns: True if the alignment succeeds, false otherwise and the part will not move from the original position.
    static bool AlignPartByInsertionPoint(Document document, ElementId partId, XYZ position, double rotation, double rotationPerpendicular, double slope, FabricationPartJustification justification, Transform trf)
      Description: Align the part by its insertion point to a point and rotation in free space.
      @document: The document.
      @partId: The element identifier of the part to align.
      @position: The position to move the part's insertion point to.
      @rotation: The rotation in radians.
      @rotationPerpendicular: The perpendicular rotation for free placement around the Y axis direction of connection - angle in radians.
      @slope: The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied to fittings, whilst straights will inherit the slope from the piece it is connecting to.
      @justification: The justification to align eccentric parts.
      @trf: Optional alignment transformation matrix, eg. a Trf that describes plan or side elevation.
      Returns: True if the alignment succeeds, false otherwise.
    static bool AlignPartByInsertionPointAndCutInToStraight(Document document, ElementId straightId, ElementId partId, XYZ position, double rotation, double slope, bool flip)
      Description: Align the part by its insertion point to a point and rotation on a straight. This will automatically size and connect the part being cut into, if possible.
      @document: The document.
      @straightId: The element identifier of the straight to be cut in to.
      @partId: The element identifier of the part to align and cut in with.
      @position: The position to move the parts insertion point to.
      @rotation: The rotation in radians.
      @slope: The slope value to flex to match if possible in fractional units (eg.1/50). Positive values are up, negative are down. Slopes can only be applied to fittings, whilst straights will inherit the slope from the piece it is connecting to.
      @flip: Flip the part to allow for flow direction.
      Returns: True if the alignment succeeds, false otherwise.
    bool CanAdjustEndLength(Connector connector)
      Description: Checks if the end of fabrication part can be adjusted.
      @connector: The connector of the fabrication part to adjust length.
      Returns: True if the end of fabrication part can be adjusted.
    bool CanASlopeBeApplied()
      Description: This will test if a slope can be applied to the part and maintain connections with any connected parts.
      Returns: Returns true if the part can be successfully sloped otherwise false.
    bool CanFlipPart()
      Description: Validates if the fabrication part is one of the supported fabrication part types that can be flipped.
      Returns: Returns true if valid otherwise false if the fabrication part cannot be flipped.
    bool CanSplitStraight(XYZ position)
      Description: Validates if the straight can be split into two at the passed in point.
      @position: The position to split in the straight.
      Returns: Returns true if valid otherwise false if the straight cannot be split.
    static bool ConnectAndCouple(Document document, Connector connector, Connector toConnector)
      Description: Makes a connection between the specified connectors and adds coupling if necessary.
      @document: The document.
      @connector: The connector of the fabrication part.
      @toConnector: The connector of the fabrication part or family to connect to.
      Returns: True if connection succeeded, false otherwise.
    static FabricationPart Create(Document document, FabricationItemFile itemFile, ElementId levelId)
      Description: Creates a fabrication part element from a fabrication item file.
      @document: The document.
      @itemFile: The fabrication item file.
      @levelId: The element identifier associated with the the will be created on.
      Returns: The new fabrication part.
    static FabricationPart Create(Document document, FabricationServiceButton button, int condition, ElementId levelId)
      Description: Creates a fabrication part element based on button.
      @document: The document.
      @button: The fabrication service button to use.
      @condition: The condition index.
      @levelId: The element identifier associated with the the will be created on.
      Returns: The new fabrication part.
    static FabricationPart Create(Document document, FabricationServiceButton button, double width, double depth, ElementId levelId)
      Description: Creates a fabrication part element based on button and size.
      @document: The document.
      @button: The fabrication service button to use. Matches button condition based on the specified size.
      @width: The width of the part. Units are in feet (ft).
      @depth: The depth of the part. Units are in feet (ft). It should be equal to width for round part.
      @levelId: The element identifier associated with the the will be created on.
      Returns: The new fabrication part.
    static FabricationPart CreateHanger(Document document, FabricationServiceButton button, int condition, ElementId levelId)
      Description: Creates a free placed hanger.
      @document: The document.
      @button: The fabrication service button to use.
      @condition: The condition index. If the button has multiple conditions.
      @levelId: The level identifier associated with the level.
      Returns: The newly-created fabrication hanger.
    static FabricationPart CreateHanger(Document document, FabricationServiceButton button, int condition, ElementId hostId, Connector hostConnector, double distance, bool attachToStructure)
      Description: Creates a hanger on the fabrication part.
      @document: The document.
      @button: The fabrication service button to use.
      @condition: The condition index. If the button has multiple conditions.
      @hostId: The host part id. The host should be one horizontal straight part.
      @hostConnector: The connector of the host.
      @distance: The distance from the input connector of the host part. Units are in feet (ft).
      @attachToStructure: Attach to the nearest structural element. The structural element might be one of Floor/Roof/Stair/Structural Framing.
      Returns: The newly-created fabrication hanger.
    static FabricationPart CreateHanger(Document document, FabricationServiceButton button, ElementId hostId, Connector hostConnector, double distance, bool attachToStructure)
      Description: Creates a hanger on the fabrication part.
      @document: The document.
      @button: The fabrication service button to use. It finds the matching condition automatically if the button has multiple condition.
      @hostId: The host part id. The host should be one horizontal straight part.
      @hostConnector: The connector of the host.
      @distance: The distance from the input connector of the host part. Units are in feet (ft).
      @attachToStructure: Attach to the nearest structural element. The structural element might be one of Floor/Roof/Stair/Structure Framing.
      Returns: The newly-created fabrication hanger.
    bool Flip()
      Description: Flips the fabrication part that is directionally oriented (tees, crosses, valves, dampers, etc.) to the opposite direction.
      Returns: Returns true if successful otherwise false if the fabrication part cannot be flipped.
    string GetCalculatedDimensionValue(FabricationDimensionDefinition dim)
      Description: Gets the calculated dimension value.
      @dim: The fabrication dimension.
      Returns: The calculated dimension value.
    IList<string> GetDimensionCalculatedOptions(FabricationDimensionDefinition dim)
      Description: Gets the calculated options of the fabrication dimension.
      @dim: The fabrication dimension.
      Returns: The calculated options of the fabrication dimension.
    IList<FabricationDimensionDefinition> GetDimensions()
      Description: Gets all fabrication dimensions.
      Returns: Returns an array of fabrication dimensions.
    double GetDimensionValue(FabricationDimensionDefinition dim)
      Description: Gets the value of the fabrication dimension, returns value in Revit internal units.
      @dim: The fabrication dimension.
      Returns: The dimension value.
    FabricationHostedInfo GetHostedInfo()
      Description: Gets the fabrication hosted element information.
      Returns: The fabrication hosted element information. Returns null if the fabrication part does not have a host.
    GeometryElement GetInsulationLiningGeometry()
      Description: Gets insulation and lining geometry for this fabrication part.
      Returns: Returns any insulation and liner geometry.
    IList<FabricationAncillaryUsage> GetPartAncillaryUsage()
      Description: Gets a list of all ancillary usage information for the part.
      Returns: Returns array of usage information, one per unique type of ancillary used.
    int GetPartCustomDataInteger(int customId)
      Description: Get custom data integer value for the specified custom data.
      @customId: The identifier of the custom data field to get.
      Returns: Returns the integer of the custom data. If the data is not a number it will return 0.
    double GetPartCustomDataReal(int customId)
      Description: Get custom data real value for the specified custom data.
      @customId: The identifier of the custom data field to get.
      Returns: Returns the real number of the custom data. If the data is not a number it will return 0.0.
    string GetPartCustomDataText(int customId)
      Description: Get custom data text for the specified custom data.
      @customId: The identifier of the custom data field to get.
      Returns: Returns the text of the custom data. If the data is a number it will be formatted according to the fabrication configuration's rules.
    int GetProductListEntryCount()
      Description: Gets the number of product entries for this part.
      Returns: Returns the number of product entries.
    string GetProductListEntryName(int index)
      Description: Gets the specified product list entry name.
      @index: The product entry index.
      Returns: Returns the specified product entry name.
    FabricationRodInfo GetRodInfo()
      Description: Gets the fabrication rod information.
      Returns: The fabrication rod information. Returns null if the fabrication part does not have any rod.
    Transform GetTransform()
      Description: Gets the transformation matrix of the fabrication part element.
      Returns: The transformation matrix of the fabrication part element.
    IList<FabricationVersionInfo> GetVersionHistory()
      Description: Gets a history of version change information about the current part.
      Returns: A list of version information about the current part. The list starts with the most recent changes.
    bool HasCustomData(int customId)
      Description: Check if fabrication part contains custom data already.
      @customId: The identifier of the custom data field to look for.
      Returns: Returns true if the fabrication part contains the custom data.
    bool HasNoConnections()
      Description: Checks to see if all the fabrication part's connectors are open.
      Returns: Returns true if the part has zero connections.
    bool IsAHanger()
      Description: Checks whether it is a hanger.
      Returns: True if the part is a hanger. False otherwise.
    bool IsAStraight()
      Description: Checks whether it is a straight part.
      Returns: True if the part is a straight part. False otherwise.
    bool IsATap()
      Description: Checks if it is any sort of tap.
      Returns: True if it is any sort of tap.
    bool IsDimensionCalculated(FabricationDimensionDefinition dim)
      Description: Checks if the fabrication dimension is calculated.
      @dim: The fabrication dimension.
      Returns: True if the fabrication dimension is calculated.
    bool IsProductList()
      Description: Gets whether or not the fabrication part is a product list.
      Returns: Returns true if the fabrication part is a product list.
    bool IsProductListEntryCompatibleSize(int productEntry)
      Description: Checks to see if this part can be changed to the specified product entry without altering any connected dimensions.
      @productEntry: The product entry index.
      Returns: Returns true if the part can be changed to the specified product entry without altering any connected dimensions.
    bool IsSameAs(FabricationPart part, IList<FabricationPartCompareType> ignoreFields)
      Description: Compare this fabrication part with the part passed and checks the pattern dimensions and options. A list of fields that can be ignored in the comparison check can be specified.
      @part: The part to compare this part with.
      @ignoreFields: Array of types of data to ignore from the comparison check.
      Returns: Returns true if the fabrication parts are the same.
    static ISet<ElementId> OptimizeLengths(Document document, ISet<ElementId> partIds)
      Description: Optimizes the length fabrication straight parts.
      @document: The document.
      @partIds: The identifiers of the fabrication parts in a selected fabrication part run.
      Returns: New and modified fabrication part ids in the optimize
    static void PlaceAsTap(Document document, Connector tapPartConnector, Connector hostPartConnector, double distance, double axisRotation, double secondaryAxisRotation)
      Description: Places the part by its connector to a specific position on the straight part at the specified distance from the host part connector.
      @document: The document.
      @tapPartConnector: The connector of the part to place.
      @hostPartConnector: The connector of host part.
      @distance: The distance to host part connector where to place the part.
      @axisRotation: The axis rotation in radians.
      @secondaryAxisRotation: The secondary axis rotation in radians.
    static bool PlaceFittingAsCutIn(Document document, ElementId straightId, ElementId fittingId, XYZ position, Connector fittingConnector, double axisRotation)
      Description: Places the fitting on the straight part by cut in, use the fitting's focal point as the insertion position.
      @document: The document.
      @straightId: Identifier of the straight to be cut in.
      @fittingId: Identifier of the fitting to cut in.
      @position: The position to cut in the straight.
      @fittingConnector: The connector of the fitting to align with the primary connector of the straight part.
      @axisRotation: Rotation around the direction of connection - angle between width vectors in radians.
      Returns: True if cuts in successful.
    bool RemovePartCustomData(int customId)
      Description: Remove custom data from the fabrication part.
      @customId: The identifier of the custom data field to remove.
      Returns: Returns true if the type was found and removed. The type will not be removed if it is not an optional type.
    static void Reposition(Document document, ElementId partId)
      Description: Repositions the fabrication straight part to another end of the run.
      @document: The document.
      @partId: Identifier of the fabrication part to reposition.
    static void RotateConnectedPartByConnector(Document document, Connector connector, double axisRotationBy)
      Description: Rotates a connected fabrication part around the axis of the specified connector.
      @document: The document.
      @connector: The connected connector of the fabrication part to be rotated.
      @axisRotationBy: The angle in radians to rotate by.
    static void RotateConnectedTap(Document document, FabricationPart tap, double primaryAxisRotateBy, double secondaryAxisRotateBy)
      Description: Rotates a connected fabrication tap by the specified angles about the primary and secondary axis.
      @document: The document.
      @tap: The connected fabrication part tap to rotate.
      @primaryAxisRotateBy: The primary axis rotation angle in radians to rotate by.
      @secondaryAxisRotateBy: The secondary axis rotation angle in radians to rotate by.
    static ISet<ElementId> SaveAsFabricationJob(Document document, ISet<ElementId> ids, string filename, FabricationSaveJobOptions saveOptions)
      Description: Save fabrication parts to an MEP job that can be opened in the fabrication software.
      @document: The document.
      @ids: List of element Ids of fabrication parts or assemblies and group elements that contain fabrication parts to save. Non-fabrication part elements will be ignored.
      @filename: The full path and filename of the fabrication job to save.
      @saveOptions: Options for the save operation.
      Returns: Returns a list of fabrication part element Ids that were saved to the fabrication job.
    void SetCalculatedDimensionValue(FabricationDimensionDefinition dim, string value)
      Description: Sets the calculated dimension value.
      @dim: The fabrication dimension.
      @value: The calculated dimension value.
    void SetDimensionValue(FabricationDimensionDefinition dim, double newValue)
      Description: Sets the fabrication dimension value. The value is in Revit internal units.
      @dim: The fabrication dimension.
      @newValue: The dimension value.
    void SetPartCustomDataInteger(int customId, int value)
      Description: Set the custom data integer value for the specified custom data.
      @customId: The identifier of the custom data field to set.
      @value: The integer value of the custom data. If the data is not an integer type the value will be parsed according to the fabrication confifuration rules.
    void SetPartCustomDataReal(int customId, double value)
      Description: Set the custom data real value for the specified custom data.
      @customId: The identifier of the custom data field to set.
      @value: The real value of the custom data. If the data is not a real type the value will be parsed according to the fabrication confifuration rules.
    void SetPartCustomDataText(int customId, string value)
      Description: Set the custom data real value for the specified custom data.
      @customId: The identifier of the custom data field to set.
      @value: The text value of the custom data. If the data is not a text type the value will be parsed according to the fabrication confifuration rules.
    void SetPositionByEnd(Connector connector, XYZ position)
      Description: Positions the connector of the fabrication part element by the passed point.
      @connector: The connector of the fabrication part element.
      @position: The position to move to.
    ElementId SplitStraight(XYZ position)
      Description: Splits the straight into two at the passed in point.
      @position: The position to split in the straight.
      Returns: Returns the element identifier of the new straight.
    ElementId SplitStraight(Document document, ElementId partId, XYZ position)
      Description: Splits the straight into two at the passed in point.
      @document: The document.
      @partId: Identifier of the straight to split.
      @position: The position to split in the straight.
      Returns: Returns the element identifier of the new straight.
    static FabricationPartFitResult StretchAndFit(Document document, Connector stretchConnector, FabricationPartRouteEnd target, out ISet<ElementId> newPartIds)

--------------------------------------------------------------------------------


[CLASS] FabricationPartType
Full Name: Autodesk.Revit.DB.FabricationPartType

Description: Represents a fabrication component type in the Autodesk Revit MEP product.
Remarks: For the product-based MAP parts, every size is a new part type in Revit. For others, one part type can have many sizes.
Inherits: ElementType
Implements: IDisposable

  METHODS:
    static FabricationPartType Create(Document document, FabricationServiceButton button, int condition)
      Description: Creates a fabrication part type element based on a specific fabrication servic button and condition.
      @document: The document.
      @button: The fabrication service button.
      @condition: The condition index.
      Returns: The created fabrication part type element.
    static ElementId Lookup(Document document, FabricationServiceButton button, int condition)
      Description: Looks up an existing fabrication part type based on a specfic fabrication service button and condition.
      @document: The document.
      @button: The fabrication service button.
      @condition: The condition index.
      Returns: Identifier of the fabrication part type element or invalidElementId if no fabrication part type exist for the specific fabrication service button and condition

--------------------------------------------------------------------------------


[CLASS] FabricationRodInfo
Full Name: Autodesk.Revit.DB.FabricationRodInfo

Description: The rod information of the fabrication part.
Remarks: A fabrication part may have one or more rods. The FabricationRodInfo stores the rod information of the fabrication part.
Implements: IDisposable

  PROPERTIES:
    bool CanRodsBeHosted { get; set; }
      Description: Controls whether the hanger's rod's will be automatically hosted by other elements.
    bool IsAttachedToStructure { get; }
      Description: Checks if the hanger is attached to structure.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int RodCount { get; }
      Description: Gets the number of rods.

  METHODS:
    void AttachToHanger(ElementId hangerId, int rodIndex, XYZ position)
      Description: Attaches the hanger rod to another bearer hanger.
      @hangerId: Identifier of the bearer hanger to which the rod attaches.
      @rodIndex: The index of the rod.
      @position: The position of the rod end. It should be on bearer centerline.
    void AttachToStructure()
      Description: Attaches to the nearest structural element.
    void Dispose()
    double GetBearerExtension(int rodIndex)
      Description: Gets the bearer extension. The method is applicable only for bearer hanger.
      @rodIndex: The index of the rod.
    LinkElementId GetRodAttachedElementId(int rodIndex)
      Description: Gets the identifier of the attached component for the specified rod.
      @rodIndex: The index of the specified rod.
    XYZ GetRodEndPosition(int rodIndex)
      Description: Gets the position of the rod end.
      @rodIndex: The index of the rod.
      Returns: The position of the rod end.
    double GetRodLength(int rodIndex)
      Description: Get the current rod length. If the rod is the length will include structural extension.
      @rodIndex: The rod index.
      Returns: Returns rod length of hanger for specified end.
    double GetRodStructureExtension(int rodIndex)
      Description: Gets the length of the rod's top extension into structure.
      @rodIndex: The rod index.
      Returns: Returns the extension length that will be applied if the rod is attached to structure.
    bool IsRodLockedWithHost(int rodIndex)
      Description: Checks if the rod is locked with the host. The method is applicable only for bearer hanger.
      @rodIndex: The index of the rod.
      Returns: True if the rod is locked with its host.
    void SetBearerExtension(int rodIndex, double length)
      Description: Sets the bearer extension. The method is applicable only for bearer hanger.
      @rodIndex: The index of the rod.
      @length: The new length of bearer extension.
    void SetRodEndPosition(int rodIndex, XYZ position)
      Description: Sets the position of the rod end. The method is applicable only for bearer hanger.
      @rodIndex: The index of the rod.
      @position: The position of the rod end.
    bool SetRodLength(int rodIndex, double newLength)
      Description: Set the rod length of the hanger for the specified rod index, excluding top extension. The hanger must not be set to be auto-hosted.
      @rodIndex: The rod index.
      Returns: Returns true if it was successful otherwise false.
    void SetRodLockedWithHost(int rodIndex, bool locked)
      Description: Locks the rod with the host. The method is applicable only for bearer hanger.
      @rodIndex: The index of the rod.
      @locked: Locks the rod with the host.
    bool SetRodStructureExtension(int rodIndex, double extension)
      Description: Set the length of the rod's top extension into structure. The rod must be attached to structure.
      @rodIndex: The rod index.
      @extension: Distance the rod will extend into the structure.
      Returns: Returns true if it was successful otherwise false.

--------------------------------------------------------------------------------


[CLASS] FabricationService
Full Name: Autodesk.Revit.DB.FabricationService

Description: This object contains information about a fabrication service.
Remarks: A fabrication service defines what fabrication service buttons that can be used. Fabrication services are part of the fabrication configuration.
Implements: IDisposable

  PROPERTIES:
    string Abbreviation { get; }
      Description: The short name of service.
    string FabricationSystemName { get; }
      Description: The fabrication system name of the service.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The name of the service.
    int PaletteCount { get; }
      Description: The number of palettes in the service.
    int ServiceId { get; }
      Description: The service identifier of the service.

  METHODS:
    void Dispose()
    FabricationServiceButton GetButton(int paletteIndex, int buttonIndex)
      Description: Gets the service button for a given palette index and button index from the service.
      @paletteIndex: The palette index.
      @buttonIndex: The button index.
      Returns: The service button.
    int GetButtonCount(int palette)
      Description: Gets the number of buttons for a given palette in the service.
      @palette: The index of the palette
      Returns: The number of buttons.
    string GetPaletteName(int palette)
      Description: Gets the name of a palette based on palette index.
      @palette: The index of the palette.
      Returns: The name of the palette.
    bool IsCompatibleWith(FabricationService otherService)
      Description: Check whether the service is broadly interchangable with another one without affecting part geometry. The services must have the same fabrication system template and specification.
      Returns: Returns true if the services are compatible.
    bool IsPaletteExcluded(int paletteIndex)
      Description: Get whether a service palette is excluded from being used by the Route and Fill, Design to Fabrication, or Multi Point Routing commands. The default configuration values may be overridden by SetServicePaletteExclusions.
      @paletteIndex: The index of the palete.
      Returns: Returns true if the palette indexed by paletteIndex is currently to be excluded.
    bool IsValidButtonIndex(int paletteIndex, int buttonIndex)
      Description: Validates the button index.
      @paletteIndex: The palette index.
      @buttonIndex: The button index to check.
      Returns: True if larger or equal to 0 and less than PaletteCount.
    bool IsValidPaletteIndex(int paletteIndex)
      Description: Validates the palette index.
      @paletteIndex: The palette index to check.
      Returns: True if larger or equal to 0 and less than PaletteCount.
    void OverrideServiceButtonExclusion(int paletteIndex, int buttonIndex, bool exclude)
      Description: Overrides the default service button exclusions, used by Route and Fill, Design to Fabrication, or Multi Point Routing for the current user and session only.
      @paletteIndex: The index of the service palette to exclude the service button from.
      @buttonIndex: The index of the service button to exclude.
      @exclude: Pass true to exclude from being used by Route and Fill or Design to Fabrication.
    void ResetServiceExclusionOverrides()
      Description: Resets the overridden service palette and button exclusions back to default, as defined by the configuration.
    bool SetServicePaletteExclusions(IList<int> excludedPalettes)
      Description: Sets the service palette exclusions, used by Route and Fill or Design to Fabrication commands, for the current user and session only. This will alter them from the default configuration exclusions to only exclude those palettes passed.
      @excludedPalettes: A list of service palette indexes to be excluded.
      Returns: Returns true if succeeded to set the exclusions to the specified palette(s).

--------------------------------------------------------------------------------


[CLASS] FabricationServiceButton
Full Name: Autodesk.Revit.DB.FabricationServiceButton

Description: The object contains information about a fabricaton button.
Remarks: A fabrication service button defines what items to use for different conditions. Fabrication service buttons are part of a fabrication service.
Implements: IDisposable

  PROPERTIES:
    int ButtonIndex { get; }
      Description: The button index for this button.
    string Code { get; }
      Description: The code of the button.
    int ConditionCount { get; }
      Description: The number of conditions.
    bool IsAHanger { get; }
      Description: Checks if the fabrication service button is hanger.
    bool IsStraight { get; }
      Description: Checks if all of the fabrication service button conditions are straights.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The name of the button.
    int PaletteIndex { get; }
      Description: The palette index for this button.
    int ServiceId { get; }
      Description: The fabrication service identifier for the fabrication service this button belongs to.

  METHODS:
    bool ContainsFabricationPartType(FabricationPartType partType)
      Description: Checks to see if the fabrication part type exists on one of the button conditions.
      @partType: The fabrication part type to check.
      Returns: Returns true if the fabrication part type exists on the fabrication service button.
    void Dispose()
    string GetConditionDescription(int condition)
      Description: Gets the description for the condition size range.
      @condition: The index of the condition in the service button.
      Returns: A user-defined string that describes the condition range, as defined in the fabrication configuration. For example, this may describe the size of the range or describe the type of fitting.
    Bitmap GetConditionImage(int condition)
    double GetConditionLowerValue(int condition)
      Description: Gets the condition lower value (valid if greater or equal) for a given condition index.
      @condition: The condition index.
      Returns: The condition lower value.
    string GetConditionName(int condition)
      Description: Gets the name of the specified condition on the fabrication service button.
      @condition: The condition index.
      Returns: The name of the specified condition on the fabrication service button.
    double GetConditionUpperValue(int condition)
      Description: Gets the condition upper value (valid if less) for a given condition index.
      @condition: The condition index.
      Returns: The condition upper value.
    Bitmap GetImage()
      Description: Gets the image for fabrication service button.
      Returns: System.Drawing.Bitmap represents the fabrication service button image. if there is no preview image.
    bool IsExcluded()
      Description: Gets if the button's fabrication part content associated with the button is to be excluded from Route and Fill, Design to Fabrication, or Multi-Point Routing commands.
      Returns: Returns true if the button's parts are excluded.
    bool IsUnrestrictedCondition(int condition)
      Description: Checks if the condition is unrestricted.
      @condition: The condition index.
      Returns: True if the condition is unrestricted.
    bool IsValid()
      Description: Checks if the button contains only valid fittings.
      Returns: True if the button contains only valid fittings.
    static bool IsValidConditionIndex(FabricationServiceButton button, int condition)
      Description: Validates if the given condition index is valid or not.
      @button: The button to check.
      @condition: The condition index.
      Returns: True if larger or equal to 0 and less than ConditionCount.

--------------------------------------------------------------------------------


[CLASS] FabricationServiceSettings
Full Name: Autodesk.Revit.DB.FabricationServiceSettings

Description: Represents the settings related to the fabrication services.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    static ElementId AirFluidType { get; }
      Description: A special fluid type for fabrication HVAC services.

  METHODS:
    static FabricationServiceSettings GetFabricationServiceSettings(Document doc)
      Description: Gets the settings element in the document.
      @doc: The document where the settings element is found.
      Returns: The element which stores the fabrication service settings for the document.
    double GetFluidTemperature(FabricationService service)
      Description: Gets the fluid temperature of the specified service.
      @service: The service to lookup.
      Returns: The temperature in Kelvin.
    ElementId GetFluidType(FabricationService service)
      Description: Gets the fluid type of the specified service.
      @service: The service to lookup.
      Returns: The fluid type id.
    bool HasValidFluidSetting(FabricationService service)
      Description: Is the service associated with a fluid type and temperature?
      @service: The service to lookup.
      Returns: True if the service is associated with a fluid type and temperature, otherwise false.
    void RemoveFluidSetting(FabricationService service)
      Description: Clears the fluid setting of the specified service if found.
      @service: The service to clear.
    void SetFluidTypeAndTemperature(FabricationService service, ElementId fluidId, double temperature)
      Description: Sets the fluid type and temperature of the specified service.
      @service: The fabrication service to be set.
      @fluidId: The fluid type id.
      @temperature: The temperature in Kelvin.

--------------------------------------------------------------------------------


[CLASS] FabricationVersionInfo
Full Name: Autodesk.Revit.DB.FabricationVersionInfo

Description: The object contains versioning information about fabrication data.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Reason { get; }
      Description: The user-specified reason for the change.
    int Version { get; }
      Description: The version number of the change.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] Face
Full Name: Autodesk.Revit.DB.Face

Description: A bounded face of a 3d solid or open shell.
Remarks: Faces are defined by surfaces () bounded by edge loops. The surfaces provide natural UV parameterization to the faces.
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    double Area { get; }
      Description: The area of this face.
    EdgeArrayArray EdgeLoops { get; }
      Description: A collection of edge loops. Each edge loop represents one of the closed boundaries of the face.
    bool HasRegions { get; }
      Description: Identifies if the face contains regions (which can be created, for example, by the Split Face command).
    bool IsCyclic { get; }
    bool IsTwoSided { get; }
      Description: Determines if a face is two-sided (degenerate).
    ElementId MaterialElementId { get; }
      Description: The element ID of the material from which this face is composed.
    bool OrientationMatchesSurfaceOrientation { get; }
      Description: Returns true if this face's orientation matches the orientation of the face's surface, false if they have opposite orientations.
    double Period { get; }
    Reference Reference { get; }
      Description: Returns a stable reference to the face.

  METHODS:
    Transform ComputeDerivatives(UV point)
      Description: Returns the first partial derivatives of the underlying surface at the specified point.
      @point: The parameters to be evaluated, in natural parameterization of the face.
      Returns: A transformation containing tangent vectors and a normal vector.
    XYZ ComputeNormal(UV point)
      Description: Returns the normal vector for the face at the given point.
      @point: The parameters to be evaluated, in natural parameterization of the face.
      Returns: The normal vector. This vector will be normalized.
    FaceSecondDerivatives ComputeSecondDerivatives(UV point)
      Description: Returns the second partial derivatives of the face at the specified point.
      @point: The parameters to be evaluated, in natural parameterization of the face.
      Returns: The second partial derivatives of the face at the specified point.
    XYZ Evaluate(UV params)
      Description: Evaluates and returns the XYZ coordinates of a point at the indicated UV parameterization of the face.
      @params: The parameters to be evaluated, in natural parameterization of the face.
      Returns: The XYZ coordinates.
    BoundingBoxUV GetBoundingBox()
      Description: Returns the UV bounding box of the face.
      Returns: A BoundingBoxUV with the extents of the parameterization of the face.
    IList<CurveLoop> GetEdgesAsCurveLoops()
      Description: Returns a list of closed curve loops that correspond to the edge loops of the face. Curves in each curve loop correspond to individual edges.
      Returns: A list of closed curve loops, that correspond edges of face.
    IList<Face> GetRegions()
      Description: Gets the face regions (created, for example, by the Split Face command) of the face.
      Returns: A list of faces, one for the main face of the object hosting the Split Face (such as wall or floor) and one face for each Split Face regions.
    Surface GetSurface()
      Description: Returns a copy of this face's surface.
      Returns: A copy of this face's surface.
    FaceIntersectionFaceResult Intersect(Face face, out Curve result)
    FaceIntersectionFaceResult Intersect(Face face)
      Description: Calculates the intersection of the specified face with this face and returns the intersection results.
      @face: The specified face to intersect with this face.
      Returns: FaceIntersectionFaceResult.Intersecting - One or more intersections were encountered.SetComparisonResult.NonIntersecting - There is no intersection found.
    SetComparisonResult Intersect(Curve curve, out IntersectionResultArray results)
    SetComparisonResult Intersect(Curve curve)
      Description: Calculates the intersection of the specified curve with this face.
      @curve: The specified curve to intersect with this face.
      Returns: SetComparisonResult.Overlap - One or more intersections were encountered. SetComparisonResult.Subset - The curve is coincident with the surface.SetComparisonResult.Disjoint - There is no intersection found.
    bool IsInside(UV point, out IntersectionResult result)
    bool IsInside(UV point)
      Description: Indicates whether the specified point is within this face.
      @point: The parameters to be evaluated, in natural parameterization of the face.
      Returns: True if point is within this face or on its boundary, otherwise false.
    IntersectionResult Project(XYZ point)
      Description: Projects the specified point on the face.
      @point: The point to be projected.
      Returns: Geometric information if projection is successful; if projection fails or the nearest point is outside of this face, returns .
    Mesh Triangulate(double levelOfDetail)
      Description: Returns a triangular mesh approximation to the face.
      @levelOfDetail: The level of detail. Its range is from 0 to 1. 0 is the lowest level of detail and 1 is the highest.
    Mesh Triangulate()
      Description: Returns a triangular mesh approximation to the face.

--------------------------------------------------------------------------------


[CLASS] FaceArray
Full Name: Autodesk.Revit.DB.FaceArray

Description: An array that contains faces.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new FaceArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Face Item { get; set; }
    int Size { get; }
      Description: Returns the number of faces that are in the array.

  METHODS:
    void Append(Face item)
      Description: Add the face to the end of the array.
      @item: The face to be added.
    void Clear()
      Description: Removes every face from the array, rendering it empty.
    FaceArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Face item, int index)
      Description: Insert the specified face into the array.
      @item: The face to be inserted into the array.
      @index: The face will be inserted before this index.
      Returns: Returns whether the face was inserted into the array.
    FaceArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] FaceArrayIterator
Full Name: Autodesk.Revit.DB.FaceArrayIterator

Description: An iterator to a face array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new FaceArrayIterator()

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


[CLASS] FaceDetailNode
Full Name: Autodesk.Revit.DB.FaceDetailNode

Description: A base class of output nodes that represent face edges and face silhouettes.
Inherits: RenderNode
Implements: IDisposable

  PROPERTIES:
    LineProperties LineProperties { get; }
      Description: Access to the line (pen) properties of the curve being drawn.

  METHODS:
    Transform GetInstanceTransform()
      Description: Returns instance transform of the object being drawn.
    Transform GetLinkTransform()
      Description: Returns link transform of the object being drawn.

--------------------------------------------------------------------------------


[CLASS] FaceEdgeNode
Full Name: Autodesk.Revit.DB.FaceEdgeNode

Description: An output node that represents a Face edge.
Remarks: See also: .
Inherits: FaceDetailNode
Implements: IDisposable

  METHODS:
    Edge GetFaceEdge()
      Description: Returns the Face edge object corresponding to the node.
      Returns: The face edge.

--------------------------------------------------------------------------------


[ENUM] FaceIntersectionFaceResult
Full Name: Autodesk.Revit.DB.FaceIntersectionFaceResult

Description: An enumerated type listing the possible results of a face-face intersection calculation.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Intersecting = 0
    - NonIntersecting = 1


[CLASS] FaceNode
Full Name: Autodesk.Revit.DB.FaceNode

Description: An output node that represents a Face.
Remarks: See also: .
Inherits: RenderNode
Implements: IDisposable

  METHODS:
    Face GetFace()
      Description: Returns the Face object corresponding to the node.
      Returns: The face.

--------------------------------------------------------------------------------


[CLASS] FaceSecondDerivatives
Full Name: Autodesk.Revit.DB.FaceSecondDerivatives

Description: Contains second partial derivatives of a face at a specified point.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ MixedDerivative { get; }
      Description: The mixed derivative.
    XYZ UUDerivative { get; }
      Description: The second derivative with respect to U.
    XYZ VVDerivative { get; }
      Description: The second derivative with respect to V.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] FaceSilhouetteNode
Full Name: Autodesk.Revit.DB.FaceSilhouetteNode

Description: An output node that represents a Face edge.
Remarks: See also: .
Inherits: FaceDetailNode
Implements: IDisposable

  METHODS:
    Face GetFace()
      Description: Returns the Face object corresponding to the node.
      Returns: The face.

--------------------------------------------------------------------------------


[CLASS] FaceSplitter
Full Name: Autodesk.Revit.DB.FaceSplitter

Description: Represents an element that splits a face.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId SplitElementId { get; }
      Description: The id of the element whose face is split by this element.

  METHODS:
    IList<CurveLoop> GetBoundaries()
      Description: Gets the boundaries.
      Returns: The face splitter boundaries.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] FacetingUtils
Full Name: Autodesk.Revit.DB.FacetingUtils

Description: This class is used to convertTrianglesToQuads a triangulated structure into a structure in which some of the triangles have been consolidated into quadrilaterals.

  METHODS:
    static IList<TriOrQuadFacet> ConvertTrianglesToQuads(TriangulationInterface triangulation)
      Description: Replaces pairs of adjacent, coplanar triangles by quadrilaterals.
      @triangulation: A triangulated face, shell, or solid.
      Returns: A collection of triangles and quadrilaterals representing the original triangulated object.

--------------------------------------------------------------------------------


[CLASS] FaceToposolid
Full Name: Autodesk.Revit.DB.FaceToposolid

Description: An object that represents a face-based Toposolid within the Autodesk Revit project.
Inherits: HostObject
Implements: IDisposable

  METHODS:
    static FaceToposolid Create(Document document, ElementId toposolidTypeId, ElementId levelId, IList<Reference> faceReferences)
      Description: Creates a new instance of a face toposolid attached to a non-vertical massing face.
      @document: The document.
      @toposolidTypeId: The toposolid type.
      @levelId: The level id.
      @faceReferences: The references from the massing face.
      Returns: The newly created face toposolid.
    IList<Reference> GetReferencedFaces()
      Description: Gets the referenced faces of the face toposolid
      Returns: The referenced faces
    void SetFaceReferences(IList<Reference> faceReferences)
      Description: Sets the referenced faces of the face toposolid
      @faceReferences: The references from the massing face.
    void UpdateToFace()
      Description: Resets the face toposolid to its defining faces.

--------------------------------------------------------------------------------


[CLASS] FaceWall
Full Name: Autodesk.Revit.DB.FaceWall

Description: A wall attached to a non-vertical massing face.
Inherits: HostObject
Implements: IDisposable

  METHODS:
    static FaceWall Create(Document document, ElementId wallType, WallLocationLine locationLine, Reference faceReference)
      Description: Creates a new instance of a wall attached to a non-vertical massing face.
      @document: The document.
      @wallType: The wall type. This must be a wall type accepted by IsWallTypeValidForFaceWall()
      @locationLine: The alignment of the wall location line.
      @faceReference: The reference from the massing face. This must pass IsValidFaceReferenceForFaceWall()
      Returns: The newly created face wall.
    static bool IsValidFaceReferenceForFaceWall(Document document, Reference faceReference)
      Description: Identifies if a reference may be used as the parent of a face wall.
      @document: The document.
      @faceReference: The reference.
      Returns: True if the reference is valid as a parent to a face wall, false otherwise.
    static bool IsWallTypeValidForFaceWall(Document document, ElementId wallType)
      Description: Identifies if a wall type may be applied to a face wall.
      @document: The document.
      @wallType: The wall type.
      Returns: True if the wall type is valid for face wall, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FailureDefinition
Full Name: Autodesk.Revit.DB.FailureDefinition

Description: Defines persistent information about a failure.
Remarks: Each failure that can be potentially posted in Revit must be based on a FailureDefinition object that contains some persistent information about failure such as identity, severity, basic description text, types of resolution and default resolution. Each FailureMessage, which contains variable part of the information for a specific failure when it occurs, is created with a reference to a registered FailureDefinition. In order to be able to post a failure, one must define and register it via FailureDefinition object during Revit Application startup.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    FailureSeverity Severity { get; }
      Description: The severity of the failure.

  METHODS:
    FailureDefinition AddResolutionType(FailureResolutionType type, string caption, Type classOfResolution)
      Description: Adds a type of possible resolution for the failure.
      @type: Type of the resolution to add. The type of resolution can be used only once for the FailureDefinition.
      @caption: A simple description of the resolution.
      @classOfResolution: The runtime class of the resolution. Used to ensure that the actual FailureResoution object added to the instance of FailureMessage belongs to an applicable class.
      Returns: The FailureDefinition.
    static FailureDefinition CreateFailureDefinition(FailureDefinitionId id, FailureSeverity severity, string messageString)
      Description: Creates an instance of a FailureDefinition.
      @id: Unique identifier of the failure.
      @severity: The severity of the failure. Cannot be FailureSeverity::None.
      @messageString: A user-visible string describing the failure.
      Returns: The created FailureDefinition instance.
    void Dispose()
    IList<FailureResolutionType> GetApplicableResolutionTypes()
      Description: Retrieves a list of resolution types applicable to the failure.
      Returns: The list of resolution types applicable to the failure.
    FailureResolutionType GetDefaultResolutionType()
      Description: Retrieves the default resolution type for the failure.
      Returns: The Default resolution type for the failure.
    string GetDescriptionText()
      Description: Retrieves the description text of the failure.
      Returns: The description text.
    string GetResolutionCaption(FailureResolutionType type)
      Description: Retrieves the caption for a specific resolution type.
      @type: The resolution type.
      Returns: The caption of the resolution.
    bool HasResolutions()
      Description: Checks if the FailureDefinition has at least one resolution.
      Returns: True if at least one resolution is defined in the FailureDefinition.
    bool IsResolutionApplicable(FailureResolutionType type)
      Description: Checks if the given resolution type is applicable to the failure.
      @type: The resolution type to check.
      Returns: True if the given resolution type is applicable to the failure, false otherwise.
    FailureDefinition SetDefaultResolutionType(FailureResolutionType type)
      Description: Sets the default resolution type for the failure.
      @type: The type of resolution to be used as default.
      Returns: The FailureDefinition.

--------------------------------------------------------------------------------


[CLASS] FailureDefinitionAccessor
Full Name: Autodesk.Revit.DB.FailureDefinitionAccessor

Description: A class that provides access to the details of a FailureDefinition after the definition has been defined.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<FailureResolutionType> GetApplicableResolutionTypes()
      Description: Retrieves a list of resolution types applicable to the failure.
      Returns: The list of resolution types applicable to the failure.
    FailureResolutionType GetDefaultResolutionType()
      Description: Retrieves the default resolution type for the failure.
      Returns: The default resolution type for the failure.
    string GetDescriptionText()
      Description: Retrieves the description text of the failure.
      Returns: The description text.
    FailureDefinitionId GetId()
      Description: Retrieves the unique identifier of the FailureDefinition.
      Returns: The unique identifier of the FailureDefinition.
    string GetResolutionCaption(FailureResolutionType type)
      Description: Retrieves the caption for a specific resolution type.
      @type: The resolution type.
      Returns: The caption of the resolution.
    FailureSeverity GetSeverity()
      Description: Retrieves severity of the failure.
      Returns: The severity of the failure.
    bool HasResolutions()
      Description: Checks if the FailureDefinition has at least one resolution.
      Returns: True if at least one resolution is defined in the FailureDefinition.
    bool IsResolutionApplicable(FailureResolutionType type)
      Description: Checks if the given resolution type is applicable to the failure.
      @type: The resolution type to check.
      Returns: True if the given resolution type is applicable to the failure, false otherwise.
    void SetDefaultResolutionType(FailureResolutionType type)
      Description: Sets the default resolution type for the failure.
      @type: The type of resolution to be used as default.

--------------------------------------------------------------------------------


[CLASS] FailureDefinitionId
Full Name: Autodesk.Revit.DB.FailureDefinitionId

Description: The unique identifier of a FailureDefinition.
Remarks: Each possible failure in Revit must be defined and registered during Revit application startup by creating a FailureDefinition object. Unique FailureDefinitionId must be used as a key to register FailureDefinition. Those unique FailureDefinitionId should be created using GUID generation tool. Later FailureDefinitionId can be used to lookup FailureDefinition in FailureDefinitionRegistry, and create and post FailureMessages.
Inherits: GuidEnum

  CONSTRUCTORS:
    new FailureDefinitionId(Guid guid)

--------------------------------------------------------------------------------


[CLASS] FailureDefinitionRegistry
Full Name: Autodesk.Revit.DB.FailureDefinitionRegistry

Description: The global registry for all FailureDefinitions in the Revit session.
Remarks: When a FailureDefinition is created, it will be registered in this registry automatically. Registration is allowed only during Revit Application startup - after that FailureDefinitionRegistry is locked and creation of new FailureDefinitions is not allowed. There is only one instance of FailureDefinitionRegistry in session.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    FailureDefinitionAccessor FindFailureDefinition(FailureDefinitionId id)
      Description: Finds a specific FailureDefinition by a given FailureDefinitionId.
      @id: The id of the FailureDefinition.
      Returns: The accessor of the found FailureDefinition, or null, if the FailureDefinition was not found.
    IList<FailureDefinitionAccessor> ListAllFailureDefinitions()
      Description: Retrieves all the registered FailureDefinitions.
      Returns: All the registered FailureDefinitions.

--------------------------------------------------------------------------------


[CLASS] FailureHandlingOptions
Full Name: Autodesk.Revit.DB.FailureHandlingOptions

Description: Options to control how failures (if any occurred during the transaction) should be handled at the time the transaction is being ended.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool GetClearAfterRollback()
      Description: Obtains the flag indicating if all posted failures should be removed silently when transaction is being rolled back.
      Returns: True to clear posted failures silently if the transaction is being rolled back, false to keep these failures in place (they may be displayed to the user).
    bool GetDelayedMiniWarnings()
      Description: Obtains the flag indicating if showing of mini-warning dialog should be delayed until the end of next transaction.
      Returns: True to delay the display of the mini-warning dialog until the end of the next transation, false to display them as this transaction is completed.
    IFailuresPreprocessor GetFailuresPreprocessor()
      Description: Gets the callback to be invoked in the beginning of failure processing.
      Returns: The callback to be invoked in the beginning of failure processing.
    bool GetForcedModalHandling()
      Description: Obtains the flag indicating if the error handling dialog shown at the end of the failing transaction should be modal.
      Returns: True if the options force Revit to use a modal error dialog, false if it allows use of a non-blocking dialog for warnings resulting from this transaction.
    ITransactionFinalizer GetTransactionFinalizer()
      Description: Gets the callback to be executed after transaction is completed.
      Returns: The callback to be executed after transaction is completed.
    FailureHandlingOptions SetClearAfterRollback(bool bFlag)
      Description: Sets a flag indicating that Revit should clear all posted failures silently when the failing transaction is being rolled back intentionally. If not set, the failures may still be displayed to the user during rollback.
      @bFlag: True to clear posted failures silently if the transaction is being rolled back, false to keep these failures in place (they may be displayed to the user).
      Returns: This FailureHandlingOptions object.
    FailureHandlingOptions SetDelayedMiniWarnings(bool bFlag)
      Description: Sets a flag indicating if Revit should delay the display of the mini-warning dialog (if one is to be shown as a result of warnings in the current transaction) until the end of the next transaction.
      @bFlag: True to delay the display of the mini-warning dialog until the end of the next transation, false to display them as this transaction is completed.
      Returns: This FailureHandlingOptions object.
    FailureHandlingOptions SetFailuresPreprocessor(IFailuresPreprocessor preprocessor)
      Description: Sets the callback to be invoked in the beginning of failure processing.
      @preprocessor: The callback to be invoked in the beginning of failure processing.
      Returns: This FailureHandlingOptions object.
    FailureHandlingOptions SetForcedModalHandling(bool bFlag)
      Description: Sets a flag indicating whether Revit will show a modal (blocking) error dialog if the transaction failed to finish.
      @bFlag: True to force Revit to use a modal error dialog, false to allow a non-blocking dialog for warnings resulting from this transaction.
      Returns: This FailureHandlingOptions object.
    FailureHandlingOptions SetTransactionFinalizer(ITransactionFinalizer finalizer)
      Description: Sets the callback to be executed after the transaction is completed.
      @finalizer: The callback to be executed after the transaction is completed.
      Returns: This FailureHandlingOptions object.

--------------------------------------------------------------------------------


[CLASS] FailureMessage
Full Name: Autodesk.Revit.DB.FailureMessage

Description: Represents a message describing a failure of an operation in Revit.
Remarks: Failure messages are typically shown to the user in the Revit error dialog. This class contains the following information about the failures: The basic description of the failure (retrieved from the FailureDefinition)The available resolutions for the failure.The elements related to the failure.
Implements: IDisposable

  CONSTRUCTORS:
    new FailureMessage(FailureDefinitionId id)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    FailureMessage AddResolution(FailureResolutionType type, FailureResolution resolution)
      Description: Adds a resolution for the failure.
      @type: The type of the resolution.
      @resolution: The resolution.
      Returns: The FailureMessage.
    void Dispose()
    ICollection<ElementId> GetAdditionalElements()
      Description: Retrieves list of the additional reference elements for the failure.
      Returns: The additional elements.
    string GetDefaultResolutionCaption()
      Description: Retrieves the caption of the default resolution of the failure.
      Returns: The caption of the default resolution of the failure.
    string GetDescriptionText()
      Description: Retrieves the description text of the failure.
      Returns: The description text.
    ICollection<ElementId> GetFailingElements()
      Description: Retrieves list of the elements that have caused the failure.
      Returns: The elements that have caused the failure.
    FailureDefinitionId GetFailureDefinitionId()
      Description: Retrieves the id of the failure definition for the failure.
      Returns: The id of the FailureDefinition for the failure.
    FailureSeverity GetSeverity()
      Description: Retrieves the severity of the failure.
      Returns: The severity of the failure.
    bool HasResolutionOfType(FailureResolutionType type)
      Description: Checks if failure has a resolution of a given type.
      @type: The type of resolution.
      Returns: True if the failure has a type of resolutions, else false.
    bool HasResolutions()
      Description: Checks if the failure has any resolutions.
      Returns: True if the failure has any resolutions, false otherwise.
    FailureMessage SetAdditionalElement(ElementId additionalElement)
      Description: Sets the additional reference element for the failure.
      @additionalElement: The additional element.
      Returns: The FailureMessage.
    FailureMessage SetAdditionalElements(ICollection<ElementId> additionalElements)
      Description: Sets the additional reference elements for the failure.
      @additionalElements: The additional elements.
      Returns: The FailureMessage.
    FailureMessage SetFailingElement(ElementId id)
      Description: Sets the element that has caused the failure.
      @id: The element that has caused the failure.
      Returns: The FailureMessage.
    FailureMessage SetFailingElements(ICollection<ElementId> idsToShow)
      Description: Sets elements that have caused the failure.
      @idsToShow: The elements that have caused the failure.
      Returns: The FailureMessage.

--------------------------------------------------------------------------------


[CLASS] FailureMessageAccessor
Full Name: Autodesk.Revit.DB.FailureMessageAccessor

Description: Restricted accessor for FailureMessage.
Remarks: Provides access to a FailureMessage stored in a Document. Reading of the information from the FailureMessage is allowed, changing of information is generally not allowed, except setting of the current resolution type.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    FailureMessage CloneFailureMessage()
      Description: Creates a copy of the FailureMessage.
      Returns: Copy of the FailureMesassge.
    void Dispose()
    ICollection<ElementId> GetAdditionalElementIds()
      Description: Retrieves Ids of Elements that have not caused the failure but are related to it Checks if the failure has resolution of a given resolution type.
      Returns: Ids of Elements related to the failure
    FailureResolutionType GetCurrentResolutionType()
      Description: Retrieves the type of resolution to be used to resolve the failure.
      Returns: The type of failure resolution to be used to resolve the failure.
    string GetDefaultResolutionCaption()
      Description: Retrieves the caption of default resolution of the failure.
      Returns: The caption of default resolution of the failure.
    string GetDescriptionText()
      Description: Retrieves the description of the failure.
      Returns: The description text.
    ICollection<ElementId> GetFailingElementIds()
      Description: Retrieves Ids of Elements that have caused the failure.
      Returns: Ids of Elements that have caused the failure.
    FailureDefinitionId GetFailureDefinitionId()
      Description: Retrieves the Id of the FailureDefinition of the failure.
      Returns: The Id of the FailureDefinition of the failure.
    int GetNumberOfResolutions()
      Description: Retrieves number of resolutions that can be used to resolve failure.
      Returns: Number of resolutions that can be used to resolve failure
    FailureSeverity GetSeverity()
      Description: Retrieves the severity of the failure.
      Returns: The severity of the failure.
    bool HasResolutionOfType(FailureResolutionType type)
      Description: Checks if failure has a resolution of a given type.
      @type: The type of resolution.
      Returns: True if failure has a resolution of a given type, false otherwise.
    bool HasResolutions()
      Description: Checks if the failure has any resolutions.
      Returns: True if the failure has any resolutions, false otherwise.
    void SetCurrentResolutionType(FailureResolutionType resolutionType)
      Description: Sets the type of a resolution to be used to resolve the failure.
      @resolutionType: The type of failure resolution to be used to resolve the failure.
    bool ShouldMergeWithMessage(FailureMessageAccessor messageToMergeWith)
      Description: Checks if the FailureMessage should be merged with the other FailureMessage for better user experience.
      Returns: True if messages should be merged

--------------------------------------------------------------------------------


[CLASS] FailureMessageKey
Full Name: Autodesk.Revit.DB.FailureMessageKey

Description: A unique key assigned to each posted failure message
Remarks: When a failure message is posted, it gets a unique key assigned and returned to the caller. The key is guaranteed to be unique in the Revit session. The key can be used to unpost (delete) previously posted failure message if it is no longer valid.
Implements: IDisposable

  CONSTRUCTORS:
    new FailureMessageKey()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool Equals(object obj)
      Description: Determines whether the specified is equal to the current .
      @obj: Another object.
    int GetHashCode()
      Description: Gets the integer value of the id as hash code
    bool IsEqual(FailureMessageKey other)
      Description: Checks it this key is equal to the other.
      @other: The key to compare with.
      Returns: True if keys are equal, false otherwise.
    bool IsValid()
      Description: Checks if the failure message key is valid
      Returns: True if the failure message key is valid

--------------------------------------------------------------------------------


[ENUM] FailureProcessingResult
Full Name: Autodesk.Revit.DB.FailureProcessingResult

Description: An enumerated type representing the result achieved by any of the available types of failure handlers: FailuresPreprocessor, the handler of FailuresProcessing event or a FailuresProcessor.
Remarks: The ability to return certain values may be restricted for certain methods or for certain contexts.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Continue = 0
    - ProceedWithCommit = 1
    - ProceedWithRollBack = 2
    - WaitForUserInput = 3


[CLASS] FailureResolution
Full Name: Autodesk.Revit.DB.FailureResolution

Description: Defines a resolution for a failure.
Remarks: A failure could have several permitted resolutions. List of applicable resolution types for the specific failure is defined by the FailureDefinition, actual FailureResolutions are instantiated with the FailureMessage before it is posted. Multiple resolutions per failure are allowed, although Revit UI only uses default resolution.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] FailureResolutionType
Full Name: Autodesk.Revit.DB.FailureResolutionType

Description: Enumeration to classify FailureResolutions by nature of operation they perform on failing Elements.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Invalid = 0
    - Default = 1
    - CreateElements = 2
    - DeleteElements = 3
    - SkipElements = 4
    - MoveElements = 5
    - FixElements = 6
    - DetachElements = 7
    - QuitEditMode = 8
    - UnlockConstraints = 9
    - SetValue = 10
    - SaveDocument = 11
    - ShowElements = 12
    - Others = 100000


[CLASS] FailuresAccessor
Full Name: Autodesk.Revit.DB.FailuresAccessor

Description: An interface class that provides access to failure information posted in a document and methods to resolve these failures.
Remarks: An instance of this class can be obtained only as an argument passed to interfaces used in the process of failure resolution and is the only available interface to fetch information about failures in a document. While reading from a document during failure processing is allowed, the only way to modify document during failure resolution is via methods provided by this class. After returning from failure processing, the instance of the class is deactivated and cannot be used any longer.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    bool CanCommitPendingTransaction()
      Description: Checks if pending failure processing can be finished by committing a pending transaction.
      Returns: True if there is a pending transaction and this transaction is allowed to be committed.
    bool CanRollBackPendingTransaction()
      Description: Checks if pending failure processing can be finished by rolling back a pending transaction.
      Returns: True if there is a pending transaction and this transaction is allowed to be rolled back
    TransactionStatus CommitPendingTransaction()
      Description: Finishes pending failures processing by committing the pending transaction.
      Returns: Result of attempt to commit the pending transaction.
    void DeleteAllWarnings()
      Description: Deletes all FailureMessages of severity "Warning" currently posted in a document.
    void DeleteElements(IList<ElementId> idsToDelete)
      Description: Resolves failures by deletion of elements related to the failures.
      @idsToDelete: Ids of elements to be deleted.
    void DeleteWarning(FailureMessageAccessor failure)
      Description: Deletes one specific failure message of severity "Warning".
      @failure: The accessor to the warning to be deleted.
    void Dispose()
    IList<FailureResolutionType> GetAttemptedResolutionTypes(FailureMessageAccessor failure)
      Description: Returns list of the failure resolution types attempted for the failure in the current transaction.
      @failure: The failure.
      Returns: The list of the types of failure resolutions attempted for the failure.
    Document GetDocument()
      Description: Provides access to a document for which failures are being processed or preprocessed.
      Returns: The document for which failures preprocessing or processing is being performed.
    FailureHandlingOptions GetFailureHandlingOptions()
      Description: Provides access to the failure handling options for the transaction currently being finished.
      Returns: The failure handling options for transaction currently being finished.
    IList<FailureMessageAccessor> GetFailureMessages(FailureSeverity severity)
      Description: Provides access to the individual failure messages if a given severity currently posted in the document.
      @severity: The failure severity for which failure messages are requested. If the requested severity is None, an empty collection is returned.
      Returns: Accessors to the individual failure messages of a given severity posted in the document.
    IList<FailureMessageAccessor> GetFailureMessages()
      Description: Provides access to the individual failure messages currently posted in the document.
      Returns: The accessors to the individual failure messages posted in the document.
    FailureSeverity GetSeverity()
      Description: Provides access to the current failure severity.
      Returns: The highest severity of a failure message currently posted in the document.
    string GetTransactionName()
      Description: Retrieves the name of the transaction for which failures are being processed.
      Returns: The name of the transaction for which failures are being processed.
    bool IsActive()
      Description: Method allows to check if this instance of the accessor is currently active.
      Returns: True if this instance is currently active and can be used.
    bool IsElementsDeletionPermitted(IList<ElementId> idsToDelete, out string reason)
    bool IsElementsDeletionPermitted(IList<ElementId> idsToDelete)
      Description: Checks if resolution of the failures by deleting given collection of elements is permitted.
      @idsToDelete: The Ids of elements to be deleted.
      Returns: True if resolution of the failures by deleting given elements is permitted.
    bool IsElementsDeletionPermitted()
      Description: Checks if resolution of the failures by deleting failure elements is permitted.
      Returns: True if resolution of the failures by deleting failure elements is permitted.
    bool IsFailureResolutionPermitted(FailureMessageAccessor failure, FailureResolutionType resolutionType)
      Description: Checks if resolution of the failure using given resolution type is permitted.
      @failure: Accessor to the failure to be resolved.
      @resolutionType: Type of the failure resolution to be used.
      Returns: True if resolution of the failure using given resolution type is permitted.
    bool IsFailureResolutionPermitted(FailureMessageAccessor failure)
      Description: Checks if default resolution of the failure is permitted.
      @failure: The accessor to the failure to be resolved.
      Returns: True if default resolution of the failure is permitted
    bool IsFailureResolutionPermitted()
      Description: Checks if resolution of failures is permitted.
      Returns: True if resolutions of failures is permitted.
    bool IsPending()
      Description: Checks if the failure processing is pending.
      Returns: True if the failures processing is in the pending state.
    bool IsTransactionBeingCommitted()
      Description: Checks if the transaction for which failures are processed is being committed or rolled back.
      Returns: True if current transaction is being committed, false if the transaction is being rolled back.
    void JournalFailures(IList<FailureMessageAccessor> failures)
      Description: Allows to record information about failures in the journal.
      @failures: Accessors to the failures to journal.
    void PostFailure(FailureMessage failure)
      Description: Posts an additional failure message to be processed for the current transaction.
      @failure: Failure message to post.
    void ReplaceFailures(FailureMessage failure)
      Description: Deletes all failure messages currently posted in a document and replaces them with one "generic" failure.
      @failure: FailureMessage that should replace all currently posted messages. It must have severity DocumentCorruption.
    void ResolveFailure(FailureMessageAccessor failure)
      Description: Resolves one failure using the failure resolution type last set for it.
      @failure: The accessor to the failure to be resolved.
    void ResolveFailures(IList<FailureMessageAccessor> failures)
      Description: Resolves one or more failures using last set failure resolution type for each of the failures. If failure resolution type was not set for some of failures, default failure resolution type will be used.
      @failures: The accessors to the failures to be resolved.
    TransactionStatus RollBackPendingTransaction()
      Description: Finishes pending failures processing by rolling back the pending transaction.
      Returns: Result of attempt to roll back the pending transaction.
    void SetFailureHandlingOptions(FailureHandlingOptions options)
      Description: Sets failure handling options for the transaction currently being finished.
      @options: The failure handling options to be set for the transaction currently being finished.
    void SetTransactionName(string transactionName)
      Description: Changes the name of the transaction for which failures are being processed.
      @transactionName: The name of the transaction to set.

--------------------------------------------------------------------------------


[ENUM] FailureSeverity
Full Name: Autodesk.Revit.DB.FailureSeverity

Description: Enum represents severity of a failure.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Warning = 1
    - Error = 2
    - DocumentCorruption = 3


[CLASS] Family
Full Name: Autodesk.Revit.DB.Family

Description: An element that represents a custom family (not a system family) in Autodesk Revit.
Remarks: Custom families within the Revit API represented by three objects - Family, and . Each object plays a significant part in the structure of families. The Family element represents the entire family that consists of a collection of types, such as an 'I Beam'. You can think of that object as representing the entire family file. The Family object contains a number of elements. The object represents a specific set of family settings within that Family and represents what is known in the Revit user interface as a Type, such as 'W14x32'. The object represents an actual instance of that type placed the Autodesk Revit project. For example the would be a single instance of a W14x32 column within the project.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    double CurtainPanelHorizontalSpacing { get; set; }
      Description: For Curtain Panel families, the horizontal spacing of the driving mesh.
    TilePatternsBuiltIn CurtainPanelTilePattern { get; }
      Description: For Curtain Panel families, the choice of tile pattern.
    double CurtainPanelVerticalSpacing { get; set; }
      Description: For Curtain Panel families, the vertical spacing of the driving mesh.
    Category FamilyCategory { get; set; }
      Description: Retrieves or sets a Category object that represents the category or sub category in which the elements ( this family could generate ) reside.
    ElementId FamilyCategoryId { get; set; }
      Description: The id of the category or sub category in which the elements that this family could generate reside.
    FamilyPlacementType FamilyPlacementType { get; }
      Description: Identifies the type of placement required by a given family.
    bool IsConceptualMassFamily { get; }
      Description: Whether the Family is a Conceptual Mass family.
    bool IsCurtainPanelFamily { get; }
      Description: Whether the Family is a Curtain Panel family. Curtain Panel family symbols are used as the ObjectTypes of elements.
    bool IsEditable { get; }
      Description: True if the family supports editing, false otherwise.
    bool IsInPlace { get; }
      Description: True if the family is an in-place family, false if the family is a loadable family.
    bool IsOwnerFamily { get; }
      Description: True if the family is the owner family for its own editable document, false otherwise.
    bool IsParametric { get; }
      Description: Identifies whether the family contains parametric relations between some of its elements.
    bool IsUserCreated { get; }
      Description: Determine whether the family has been defined by the user.
    bool ShowSpatialElementCalculationPoint { get; set; }
      Description: For families that can have a calculation point for spatial elements, hide or show the calculation point. elements.
    string StructuralCodeName { get; set; }
      Description: The family's structural code name.
    string StructuralFamilyNameKey { get; set; }
      Description: The family's structural section shape name key.
    StructuralMaterialType StructuralMaterialType { get; }
      Description: The family's structural material type.
    StructuralSectionShape StructuralSectionShape { get; set; }
      Description: The family's structural section shape.

  METHODS:
    bool CanHaveStructuralSection()
      Description: Identifies if this Family can have a structural section.
      Returns: True if the Family can have structural section, false otherwise.
    static bool CanLoadFamilies(Document document)
      Description: Checks whether the document is in a state that allows the loading of families.
      @document: The document to check.
      Returns: True if loading of families is allowed, otherwise False.
    void ExtractPartAtom(string xmlFilePath)
      Description: Writes a PartAtom XML from the contents of a family object.
      @xmlFilePath: The xml file to be saved.
    ISet<ElementId> GetFamilySymbolIds()
      Description: Gets the ids of the FamilySymbols owned by this Family.
      Returns: The ids of the FamilySymbols.
    ISet<ElementId> GetFamilyTypeParameterValues(ElementId parameterId)
      Description: Returns all applicable values for a FamilyType parameter of this family.
      @parameterId: A valid Id of a FamilyType parameter defined for this family.
      Returns: Ids of all applicable and elements.
    bool HasLargeSketches()
      Description: Checks whether the family contains sketches with a large number of elements.
    bool IsAppropriateCategoryId(ElementId categoryId)
      Description: Identifies if the input category id can be assigned as the new category for this family.
      @categoryId: The category id.
      Returns: True if the input category id can be assigned as the new category for this family, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FamilyElementVisibility
Full Name: Autodesk.Revit.DB.FamilyElementVisibility

Description: Provides access to the visibility parameters of family elements in family document.
Inherits: APIObject
Implements: IDisposable

  CONSTRUCTORS:
    new FamilyElementVisibility(FamilyElementVisibilityType visibilityType)

  PROPERTIES:
    bool IsShownInCoarse { get; set; }
      Description: Indicates if the instance is display with Coarse detail level in the view of project document.
    bool IsShownInFine { get; set; }
      Description: Indicates if the instance is display with Fine detail level in the view of project document.
    bool IsShownInFrontBack { get; set; }
      Description: Indicates if the instance is display in Front/Back view of project document.
    bool IsShownInLeftRight { get; set; }
      Description: Indicates if the instance is display in Left/Right view of project document.
    bool IsShownInMedium { get; set; }
      Description: Indicates if the instance is display with Medium detail level in the view of project document.
    bool IsShownInPlanRCPCut { get; set; }
      Description: Indicates if the instance is displayed when cut in Plan/RCP (if the category permits).
    bool IsShownInTopBottom { get; set; }
      Description: Indicates if the instance is display in Plan/RCP view of project document.
    bool IsShownOnlyWhenCut { get; set; }
      Description: Indicates if the instance is displayed only if it has been cut.
    FamilyElementVisibilityType VisibilityType { get; }
      Description: Indicates if the instance is Model or View specific.

--------------------------------------------------------------------------------


[ENUM] FamilyElementVisibilityType
Full Name: Autodesk.Revit.DB.FamilyElementVisibilityType

Description: Indicates the Visibility type of generic forms.
Remarks: Use this enum to indicate the visibility type of new forms.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Model = 0
    - ViewSpecific = 1


[ENUM] FamilyHostingBehavior
Full Name: Autodesk.Revit.DB.FamilyHostingBehavior

Description: Types of hosts into/onto which a family can be hosted. For informative purposes only. Does not affect anything in Revit!
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Wall = 1
    - Floor = 2
    - Ceiling = 3
    - Roof = 4
    - Face = 5


[CLASS] FamilyInstance
Full Name: Autodesk.Revit.DB.FamilyInstance

Description: This object represents a single instance of a family type, such as a single I beam.
Remarks: Examples of FamilyInstance objects within Autodesk Revit are Beams, Columns, Braces and Desks. The FamilyInstance object provides more detailed properties that enable the type of the family instance to be changed, thus changing their appearance within the project.
Inherits: Instance
Implements: IDisposable

  PROPERTIES:
    bool CanFlipFacing { get; }
      Description: Property to test whether the orientation of family instance facing can be flipped.
    bool CanFlipHand { get; }
      Description: Property to test whether the orientation of family instance hand can be flipped.
    bool CanFlipWorkPlane { get; }
      Description: Identifies if the instance can flip its work plane.
    bool CanRotate { get; }
      Description: Property to test whether the family instance can be rotated by 180 degrees.
    bool CanSplit { get; }
      Description: Identifies whether a particular family instance can be split at a point on it's defining curve (by ).
    IExtension ExtensionUtility { get; }
      Description: Property to check whether the instance can be extended and return the interface for extension operation.
    bool FacingFlipped { get; }
      Description: Property to test whether the orientation of family instance facing is flipped.
    XYZ FacingOrientation { get; }
      Description: Property to get the orientation of family instance facing.
    Room FromRoom { get; }
      Description: The "From Room" set for the door or window in the last phase of the project.
    Room FromRoom { get; }
      Description: The "From Room" set for the door or window in the last phase of the project.
    bool HandFlipped { get; }
      Description: Property to test whether the orientation of family instance hand is flipped.
    XYZ HandOrientation { get; }
      Description: Property to get the orientation of family instance hand.
    bool HasSpatialElementCalculationPoint { get; }
      Description: Identifies if this instance has a single SpatialElementCalculationPoint used as the search point for Revit to identify if the instance is inside a room or space.
    bool HasSpatialElementFromToCalculationPoints { get; }
      Description: Identifies if this instance has a pair of SpatialElementCalculationPoints used as the search points for Revit to identify if the instance lies between up to two rooms or spaces.
    Element Host { get; }
      Description: If the instance is contained within another element, this property returns the containing element. An instance that is face hosted will return the element containing the face.
    Reference HostFace { get; }
      Description: Property to get the reference to the host face of family instance.
    double HostParameter { get; }
      Description: If the instance is hosted by a wall, this property returns the parameter value of the insertion point of the instance along the wall's location curve, as long as the family of the instance isn't work plane based.
    bool Invisible { get; }
      Description: Property to test whether the family instance is invisible.
    bool IsSlantedColumn { get; }
      Description: Indicates if the family instance is a slanted column.
    bool IsWorkPlaneFlipped { get; set; }
      Description: Identifies if the instance's work plane is flipped.
    Location Location { get; }
      Description: This property is used to find the physical location of an instance within project.
    MEPModel MEPModel { get; }
      Description: Retrieves the MEP model for the family instance.
    bool Mirrored { get; }
      Description: Property to test whether the family instance is mirrored. (only one axis is flipped)
    Room Room { get; }
      Description: The room in which the instance is located (during the last phase of the project).
    Room Room { get; }
      Description: The room in which the instance is located (during the last phase of the project).
    Space Space { get; }
      Description: The space in which the instance is located (during the last phase of the project).
    Space Space { get; }
      Description: The space in which the instance is located (during the last phase of the project).
    ElementId StructuralMaterialId { get; set; }
      Description: Identifies the material that defines the instance's structural analysis properties.
    StructuralMaterialType StructuralMaterialType { get; }
      Description: This property returns the physical material from which the instance is made.
    StructuralType StructuralType { get; }
      Description: Provides the primary structural type of the instance, such as beam or column etc.
    StructuralInstanceUsage StructuralUsage { get; set; }
      Description: Provides the primary structural usage of the instance, such as brace, girder etc.
    Element SuperComponent { get; }
      Description: Property to get the super component of current family instance.
    FamilySymbol Symbol { get; set; }
      Description: Returns or changes the FamilySymbol object that represents the type of the instance.
    Room ToRoom { get; }
      Description: The "To Room" set for the door or window in the last phase of the project.
    Room ToRoom { get; }
      Description: The "To Room" set for the door or window in the last phase of the project.

  METHODS:
    bool AddCoping(FamilyInstance cutter)
      Description: Adds a coping (cut) to a steel beam.
      @cutter: A steel beam or column. May not be or itself.
    bool flipFacing()
      Description: The orientation of family instance facing will be flipped. If it can not be flipped, return false, otherwise return true.
    void FlipFromToRoom()
      Description: Flips the settings of "From Room" and "To Room" for the door or window instance.
    bool flipHand()
      Description: The orientation of family instance hand will be flipped. If it can not be flipped, return false, otherwise return true.
    ICollection<ElementId> GetCopingIds()
      Description: Lists the elements currently used as coping cutters for this element.
      Returns: The coping ElementIds
    IList<FamilyPointPlacementReference> GetFamilyPointPlacementReferences()
      Description: Returns the Point Placement References for the Family Instance.
    GeometryElement GetOriginalGeometry(Options options)
      Description: Returns the original geometry of the instance, before the instance is modified by joins, cuts, coping, extensions, or other post-processing.
      @options: The options used to obtain the geometry. Note that ComputeReferences may not be set to true.
    Reference GetReferenceByName(string name)
      Description: Gets the family instance reference corresponding to the named reference plane in the instance's family.
      @name: The name of the reference plane in the family.
      Returns: Returns the family instance reference corresponding to the named reference plane in the instance's family. Returns null if there is no reference plane with this name in the family, or if the plane exists but its "Is Reference" property is "Not a Reference", or if the input string is empty.
    string GetReferenceName(Reference reference)
      Description: Gets the name of the reference plane in the family corresponding to the given family instance reference.
      @reference: The family instance reference.
      Returns: Returns the name of the reference plane in the family corresponding to the given family instance reference. If the reference doesn't correspond to a named reference plane, returns an empty string.
    IList<Reference> GetReferences(FamilyInstanceReferenceType referenceType)
      Description: Gets family instance references corresponding to the reference planes or reference lines of the given reference type in the instance's family.
      @referenceType: The family reference type.
      Returns: Returns all the family instance references corresponding to reference planes and reference lines of the given reference type. Returns null if there are no family instance references of the given reference type, or if the input reference type is FamilyInstanceReferenceType.NotAReference.
    FamilyInstanceReferenceType GetReferenceType(Reference reference)
      Description: Gets the type of the reference plane or reference line in the instance's family corresponding to the given family instance reference.
      @reference: The family instance reference.
      Returns: Returns the type of the reference plane or reference line in the instance's family corresponding to the given family instance reference. Returns FamilyInstanceReferenceType.NotAReference if the instance reference doesn't correspond to a reference plane or line in the family.
    XYZ GetSpatialElementCalculationPoint()
      Description: Gets the location of the calculation point for this instance.
      Returns: A 3d point.
    IList<XYZ> GetSpatialElementFromToCalculationPoints()
      Description: Gets the locations for the calculation points for this instance.
      Returns: A list of 3d points.
    ICollection<ElementId> GetSubComponentIds()
      Description: Gets the sub component ElementIds of the current family instance.
      Returns: The subcomponent ElementIDs
    SweptProfile GetSweptProfile()
      Description: Gets the object that describes the profile that is swept along the driving curve for this instance.
      Returns: A swept profile.
    bool HasModifiedGeometry()
      Description: Identifies if the geometry of this FamilyInstance has been modified from the automatically generated default.
    bool HasSweptProfile()
      Description: Indicates if this instance can be represented as a swept profile.
      Returns: True if the instance can be represented as a swept profile, false otherwise.
    bool RemoveCoping(FamilyInstance cutter)
      Description: Removes a coping (cut) from a steel beam.
      @cutter: A steel beam or column for which this beam currently has a coping cut. May not be or itself.
    bool rotate()
      Description: The family instance will be flipped by 180 degrees. If it can not be rotated, return false, otherwise return true.
    bool SetCopingIds(ICollection<ElementId> cutters)
      Description: Specifies the set of coping cutters on this element.
      @cutters: A set of coping cutters (steel beams and steel columns).
    ElementId Split(double param)
      Description: Splits the family instance element at a point on its defining curve.
      @param: The normalized parameter value along the element (should be greater than 0 and less than 1).
      Returns: The newly created family instance id.

--------------------------------------------------------------------------------


[CLASS] FamilyInstanceFilter
Full Name: Autodesk.Revit.DB.FamilyInstanceFilter

Description: A filter used to find elements that are family instances of the given family symbol.
Remarks: This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements before the elements are obtained and expanded. Therefore this filter does not have to be paired with another quick filter to minimize the number of Elements that are expanded.
Inherits: ElementSlowFilter
Implements: IDisposable

  CONSTRUCTORS:
    new FamilyInstanceFilter(Document document, ElementId familySymbolId)

  PROPERTIES:
    ElementId FamilySymbolId { get; }
      Description: The family symbol id.

--------------------------------------------------------------------------------


[ENUM] FamilyInstanceReferenceType
Full Name: Autodesk.Revit.DB.FamilyInstanceReferenceType

Description: Corresponds to the possible values of parameter "Is Reference" of reference planes and parameter "Reference" of reference lines in families. This enum is used to identify references of family instances corresponding to reference planes and reference lines in the family.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Left = 0
    - CenterLeftRight = 1
    - Right = 2
    - Front = 3
    - CenterFrontBack = 4
    - Back = 5
    - Bottom = 6
    - CenterElevation = 7
    - Top = 8
    - StrongReference = 9
    - WeakReference = 10
    - NotAReference = 11


[CLASS] FamilyManager
Full Name: Autodesk.Revit.DB.FamilyManager

Description: The family manager object to manage the family types and parameters in family document.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    FamilyType CurrentType { get; set; }
      Description: The current family type.
    FamilyParameter Parameter { get; }
    FamilyParameter Parameter { get; }
    FamilyParameter Parameter { get; }
    FamilyParameter Parameter { get; }
    FamilyParameterSet Parameters { get; }
      Description: All family parameters in this family.
    FamilyTypeSet Types { get; }
      Description: All family types in the family.

  METHODS:
    FamilyParameter AddParameter(string parameterName, ForgeTypeId groupTypeId, Category familyCategory, bool isInstance)
      Description: Add a new family type parameter to control the type of a nested family within another family.
      @parameterName: The name of the new family parameter.
      @groupTypeId: The identifier of the group to which the family parameter belongs.
      @familyCategory: The category to which the new family parameter binds.
      @isInstance: Indicates if the new family parameter is instance or type.
      Returns: If creation was successful the new parameter is returned, otherwise an exception with failure information will be thrown.
    FamilyParameter AddParameter(string parameterName, ForgeTypeId groupTypeId, ForgeTypeId specTypeId, bool isInstance)
      Description: Add a new family parameter with a given name.
      @parameterName: The name of the new family parameter.
      @groupTypeId: The identifier of the new family parameter's parameter group.
      @specTypeId: The type of new family parameter.
      @isInstance: Indicates if the new family parameter is instance or type.
      Returns: If creation was successful the new parameter is returned, otherwise an exception with failure information will be thrown.
    FamilyParameter AddParameter(ExternalDefinition familyDefinition, ForgeTypeId groupTypeId, bool isInstance)
      Description: Add a new shared parameter to the family.
      @familyDefinition: The definition of the loaded shared parameter.
      @groupTypeId: The identifier of the parameter group to which the family parameter belongs.
      @isInstance: Indicates if the new parameter is instance or type.
      Returns: If creation was successful the new shared parameter is returned, otherwise an exception with failure information will be thrown.
    void AssociateElementParameterToFamilyParameter(Parameter elementParameter, FamilyParameter familyParameter)
      Description: Associates or disassociates the element parameter to an existing family parameter.
      @elementParameter: The parameter of an element in family.
      @familyParameter: The existing family parameter. If the input to this argument is , it will disassociate the element parameter from any family parameters.
    bool CanElementParameterBeAssociated(Parameter elementParameter)
      Description: Indicates if this element parameter can be associated with a family parameter.
    void DeleteCurrentType()
      Description: Remove the current family type.
    FamilyParameter GetAssociatedFamilyParameter(Parameter elementParameter)
      Description: Gets the associated family parameter of an element parameter.
      @elementParameter: The parameter of an element in family.
      Returns: The associated family parameter if there is an association between them, returns if not.
    FamilyParameter GetParameter(ForgeTypeId parameterTypeId)
      Description: Obtains the family parameter with the given built-in parameter identifier.
      @parameterTypeId: Identifier of the built-in parameter.
    IList<FamilyParameter> GetParameters()
      Description: Gets the parameters associated to family types in order.
      Returns: A collection containing all family parameters.
    bool IsParameterLockable(FamilyParameter familyParameter)
      Description: For Conceptual Mass and Curtain Panel families, indicate whether the specified parameter can be locked.
      Returns: True if the family is a Conceptual Mass or Curtain Panel Family and the parameter drives one or more dimensions; false otherwise.
    bool IsParameterLocked(FamilyParameter familyParameter)
      Description: For Conceptual Mass and Curtain Panel families, indicate whether the specified dimension-driving parameter is locked.
      Returns: True if the parameter is lockable and is locked; false otherwise.
    bool IsUserAssignableParameterGroup(ForgeTypeId groupTypeId)
      Description: Checks if the given parameter group can be assigned to new parameters.
      Returns: True if the parameter group can be assigned to new parameters, false otherwise.
    void MakeInstance(FamilyParameter familyParameter)
      Description: Set the family parameter as an instance parameter.
    void MakeNonReporting(FamilyParameter familyParameter)
      Description: Set the reporting family parameter as a regular/driving parameter.
    void MakeReporting(FamilyParameter familyParameter)
      Description: Set the family parameter as a reporting parameter.
    void MakeType(FamilyParameter familyParameter)
      Description: Set the family parameter as a type parameter.
    FamilyType NewType(string typeName)
      Description: Add a new family type with a given name and makes it be the current type.
      @typeName: The name of new family type.
    void RemoveParameter(FamilyParameter familyParameter)
      Description: Remove an existing family parameter from the family.
      @familyParameter: The family parameter.
    void RenameCurrentType(string typeName)
      Description: Rename the current family type.
      @typeName: The new name of the current family type.
    void RenameParameter(FamilyParameter familyParameter, string name)
      Description: Rename a family parameter.
      @familyParameter: The family parameter.
      @name: The new name.
    void ReorderParameters(IList<FamilyParameter> parameters)
      Description: Reorders the family parameters by the specified parameters order.
      @parameters: The new parameters order for the family. The contents of this collection should consist of exactly the same parameters returned by the GetParameters() method. This will include invisible parameters; they can be reordered but this will have no effect when viewing the parameters in the Revit UI.
    FamilyParameter ReplaceParameter(FamilyParameter currentParameter, string parameterName, ForgeTypeId groupTypeId, bool isInstance)
      Description: Replace a shared family parameter with a new non-shared family parameter.
      @currentParameter: The current family parameter.
      @parameterName: The name of the new family parameter.
      @groupTypeId: The identifier of the group to which the new family parameter belongs.
      @isInstance: Indicates if the new parameter is instance or type.
      Returns: If replacement was successful the new family parameter is returned, otherwise an exception with failure information will be thrown.
    FamilyParameter ReplaceParameter(FamilyParameter currentParameter, ExternalDefinition familyDefinition, ForgeTypeId groupTypeId, bool isInstance)
      Description: Replace a family parameter with a shared parameter.
      @currentParameter: The current family parameter.
      @familyDefinition: The definition of the loaded shared parameter.
      @groupTypeId: The identifier of the group to which the new shared parameter belongs.
      @isInstance: Indicates if the new parameter is instance or type.
      Returns: If replacement was successful the new shared parameter is returned, otherwise an exception with failure information will be thrown.
    void Set(FamilyParameter familyParameter, ElementId value)
      Description: Set the ElementId value of a family parameter of the current family type.
      @familyParameter: A family parameter of the current type.
      @value: The new value for family parameter.
    void Set(FamilyParameter familyParameter, double value)
      Description: Set the double value of a family parameter of the current family type.
      @familyParameter: A family parameter of the current type.
      @value: The new value for family parameter.
    void Set(FamilyParameter familyParameter, string value)
      Description: Set the string value of a family parameter of the current family type.
      @familyParameter: A family parameter of the current type.
      @value: The new value for family parameter.
    void Set(FamilyParameter familyParameter, int value)
      Description: Set the integer value of a family parameter of the current family type.
      @familyParameter: A family parameter of the current type.
      @value: The new value for family parameter.
    void SetDescription(FamilyParameter familyParameter, string description)
      Description: Set the description for an existing family parameter. The description will be used as tooltip in the Revit UI including in the properties palette.
      @familyParameter: The family parameter.
      @description: The description of the family parameter.
    void SetFormula(FamilyParameter familyParameter, string formula)
      Description: Set the formula of a family parameter.
      @familyParameter: The family parameter.
      @formula: The formula string, input to clean the formula of the parameter.
    void SetParameterLocked(FamilyParameter familyParameter, bool locked)
      Description: For Conceptual Mass and Curtain Panel families, lock or unlock a dimension-driving parameter.
    void SetValueString(FamilyParameter familyParameter, string value)
      Description: Set the string value of a family parameter of the current family type.
      @familyParameter: The family parameter of current type.
      @value: The new value string for family parameter.
    void SortParameters(ParametersOrder order)
      Description: Sorts the family parameters according to the desired sort order.
      @order: The desired sort order.

--------------------------------------------------------------------------------


[ENUM] FamilyNestingBehavior
Full Name: Autodesk.Revit.DB.FamilyNestingBehavior

Description: This attribute describes the family nesting behavior.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Embedded = 0
    - Shared = 1
    - Subelement = 2


[CLASS] FamilyParameter
Full Name: Autodesk.Revit.DB.FamilyParameter

Description: The family parameter object.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    ParameterSet AssociatedParameters { get; }
      Description: The parameters from elements in the family which are associated to this parameter.
    bool CanAssignFormula { get; }
      Description: Indicates if this parameter can be assigned a formula.
    Definition Definition { get; }
      Description: The definition.
    string Formula { get; }
      Description: The formula.
    Guid GUID { get; }
      Description: The globally unique identifier
    ElementId Id { get; }
      Description: The id of the family parameter.
    bool IsDeterminedByFormula { get; }
      Description: Indicates if the parameter is determined by formula.
    bool IsInstance { get; }
      Description: Indicates if the parameter is instance or type.
    bool IsReadOnly { get; }
      Description: Identifies if the object is read-only or modifiable.
    bool IsReporting { get; }
      Description: Indicates if the parameter is a reporting parameter.
    bool IsShared { get; }
      Description: Identifies if the parameter is a shared parameter.
    StorageType StorageType { get; }
      Description: The storage type describes the type that is used internally within the parameter to store its value.
    bool UserModifiable { get; }
      Description: Indicates whether the interactive user can modify the value of this parameter.

  METHODS:
    ForgeTypeId GetUnitTypeId()
      Description: Gets the identifier of the unit quantifying the parameter value.

--------------------------------------------------------------------------------


[CLASS] FamilyParameterSet
Full Name: Autodesk.Revit.DB.FamilyParameterSet

Description: A set that contains FamilyParameter objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new FamilyParameterSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(FamilyParameter item)
    int Erase(FamilyParameter item)
    FamilyParameterSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(FamilyParameter item)
    FamilyParameterSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] FamilyParameterSetIterator
Full Name: Autodesk.Revit.DB.FamilyParameterSetIterator

Description: An iterator to a FamilyParameter set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new FamilyParameterSetIterator()

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


[ENUM] FamilyPlacementType
Full Name: Autodesk.Revit.DB.FamilyPlacementType

Description: The type of placement required for a given family.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - OneLevelBased = 0
    - OneLevelBasedHosted = 1
    - TwoLevelsBased = 2
    - ViewBased = 3
    - WorkPlaneBased = 4
    - CurveBased = 5
    - CurveBasedDetail = 6
    - CurveDrivenStructural = 7
    - Adaptive = 8
    - Invalid = 9


[CLASS] FamilyPointLocation
Full Name: Autodesk.Revit.DB.FamilyPointLocation

Description: Data corresponding to the point locations in certain types of Family Symbols.
Remarks: Examples of FamilySymbol objects that contain placement references are Panels and Flexible Components.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The name of the corresponding reference point in the Family document.

  METHODS:
    Transform GetLocation()
      Description: Gets the location of the point.
      Returns: The location of the point.

--------------------------------------------------------------------------------


[CLASS] FamilyPointPlacementReference
Full Name: Autodesk.Revit.DB.FamilyPointPlacementReference

Description: This object represents data corresponding to the placement references in a certain types of Family Instances (see examples listed below).
Remarks: Examples of FamilyInstance objects that contain placement references are Panels and Flexible Components.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    Transform Location { get; }
      Description: The location of the point.
    string Name { get; }
      Description: The name of the corresponding reference point in the Family document.
    Reference PointReference { get; }
      Description: The reference on which the point depends on.

--------------------------------------------------------------------------------


[CLASS] FamilySizeTable
Full Name: Autodesk.Revit.DB.FamilySizeTable

Description: Contains size information for a family.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfColumns { get; }
      Description: Number of columns in the table.
    int NumberOfRows { get; }
      Description: Number of rows in the table.

  METHODS:
    string AsValueString(int row, int column)
      Description: Gets the table cell value as a string.
      @row: The table row.
      @column: The table column.
      Returns: The table cell value as a string.
    void Dispose()
    FamilySizeTableColumn GetColumnHeader(int index)
      Description: Gets a column of the table at at given index.
      @index: Index of the column.
      Returns: The column at the given index.
    bool IsValidColumnIndex(int index)
      Description: Checks if the column index is valid.
      @index: The index of the column.
      Returns: True if the column index is valid, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FamilySizeTableColumn
Full Name: Autodesk.Revit.DB.FamilySizeTableColumn

Description: Contains column information for a FamilySizeTable.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The column name.

  METHODS:
    void Dispose()
    ForgeTypeId GetSpecTypeId()
      Description: Gets the identifier of the spec describing values in the column.
      Returns: Identifier of the spec.
    ForgeTypeId GetUnitTypeId()
      Description: Gets the identifier of the unit quantifying values in the column.
      Returns: Identifier of the unit.

--------------------------------------------------------------------------------


[CLASS] FamilySizeTableErrorInfo
Full Name: Autodesk.Revit.DB.FamilySizeTableErrorInfo

Description: Error information generated from the CSV file import of a FamilySizeTable.
Implements: IDisposable

  CONSTRUCTORS:
    new FamilySizeTableErrorInfo()

  PROPERTIES:
    FamilySizeTableErrorType FamilySizeTableErrorType { get; }
      Description: The error type.
    string FilePath { get; }
      Description: The path of the imported CSV file.
    int InvalidColumnIndex { get; }
      Description: The index of the invalid column.
    string InvalidHeaderText { get; }
      Description: The invalid header text.
    int InvalidRowIndex { get; }
      Description: The index of the invalid row.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[ENUM] FamilySizeTableErrorType
Full Name: Autodesk.Revit.DB.FamilySizeTableErrorType

Description: The set of errors that can be returned when importing a FamilySizeTable from a CSV file.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - FileNotFound = 0
    - CannotOpenFile = 1
    - CannotReadFile = 2
    - InvalidHeaderSeparator = 3
    - CannotParseColumnHeader = 4
    - IncorrectNumberOfColumns = 5
    - Undefined = -1


[CLASS] FamilySizeTableManager
Full Name: Autodesk.Revit.DB.FamilySizeTableManager

Description: Manages importing, exporting, and querying size data through the FamilySizeTable class.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int NumberOfSizeTables { get; }
      Description: The number of FamilySizeTables in a family.

  METHODS:
    static bool CreateFamilySizeTableManager(Document document, ElementId familyId)
      Description: Adds FamilySizeTableManager to a Family. A FamilySizeTableManager and FamilySizeTables are only needed when importing, exporting, or removing size data previously stored in CSV files.
      @document: Family owned document or project document.
      @familyId: ElementId of the Family.
      Returns: True if successful, false otherwise.
    void Dispose()
    bool ExportSizeTable(string tableName, string filePath)
      Description: Exports the size table to aCSV file.
      @tableName: The bool name to export.
      @filePath: The CSV file to export to.
      Returns: True if successful, false otherwise..
    IList<string> GetAllSizeTableNames()
      Description: Get the FamilySizeTable names in a family.
      Returns: Array of size table names.
    static FamilySizeTableManager GetFamilySizeTableManager(Document document, ElementId familyId)
      Description: Gets a FamilySizeTableManager from a Family
      @document: Family owned document or a project document
      @familyId: ElementId of the Family.
      Returns: The FamilySizeTableManager of the Family.
    FamilySizeTable GetSizeTable(string tableName)
      Description: Get a FamilySizeTable by name.
      @tableName: The FamilySizeTable name.
      Returns: The FamilySizeTable of a given name.
    bool HasSizeTable(string tableName)
      Description: Checks if a FamilySizeTable of a given name exists.
      @tableName: The name of the FamilySizeTable.
      Returns: True if the FamilySizeTable exists, false otherwise.
    bool ImportSizeTable(Document document, string filePath, FamilySizeTableErrorInfo errorInfo)
      Description: Imports a FamilySizeTable from a CSV file.
      @document: Family owned document or project document.
      @filePath: The CSV file path.
      @errorInfo: An error object to be written to if errors occur.
      Returns: True if successful, false otherwise.
    bool RemoveSizeTable(string tableName)
      Description: Removes the FamilySizeTable of a given name.
      @tableName: The FamilySizeTable name.
      Returns: True if successful, false otherwise.

--------------------------------------------------------------------------------


[ENUM] FamilySource
Full Name: Autodesk.Revit.DB.FamilySource

Description: Describes which version of the family to be loaded.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Project = 0
    - Family = 1


[CLASS] FamilySymbol
Full Name: Autodesk.Revit.DB.FamilySymbol

Description: An element that represents a single type with a Family.
Remarks: Custom families within the Revit API represented by three objects - Family, and . Each object plays a significant part in the structure of families. The Family element represents the entire family that consists of a collection of types, such as an 'I Beam'. You can think of that object as representing the entire family file. The Family object contains a number of elements. The object represents a specific set of family settings within that Family and represents what is known in the Revit user interface as a Type, such as 'W14x32'. The object represents an actual instance of that type placed the Autodesk Revit project. For example the would be a single instance of a W14x32 column within the project.
Inherits: InsertableObject
Implements: IDisposable

  PROPERTIES:
    Family Family { get; }
      Description: The Family object to which the symbol belongs.
    bool IsActive { get; }
      Description: Identifies whether the symbol is active.
    StructuralMaterialType StructuralMaterialType { get; }
      Description: This property returns the physical material from which the type is made.

  METHODS:
    void Activate()
      Description: Activates the symbol to ensure that its geometry is accessible.
    bool CanHaveStructuralSection()
      Description: Identifies if this FamilySymbol can have a structural section.
      Returns: True if the FamilySymbol can have structural section, false otherwise.
    IList<FamilyPointLocation> GetFamilyPointLocations()
      Description: Returns the Point Locations for the Family Symbol.
    StructuralSection GetStructuralSection()
      Description: Gets the structural section from element.
      Returns: The structural section. if the family symbol does not contain a structural section.
    FamilyThermalProperties GetThermalProperties()
      Description: Gets the thermal properties for the given FamilySymbol.
      Returns: The thermal properties. if the family symbol does not contain thermal properties.
    bool HasThermalProperties()
      Description: Identifies if this FamilySymbol can include thermal properties.
      Returns: True if the FamilySymbol can include thermal properties, false otherwise.
    void SetStructuralSection(StructuralSection structuralSection)
      Description: Sets the structural section in element.
      @structuralSection: Structural section with values that will be set.
    void SetThermalProperties(FamilyThermalProperties thermalProperties)
      Description: Sets the thermal properties for the given FamilySymbol.
      @thermalProperties: The new thermal properties. If , this unsets custom thermal properties for this FamilySymbol.

--------------------------------------------------------------------------------


[CLASS] FamilySymbolFilter
Full Name: Autodesk.Revit.DB.FamilySymbolFilter

Description: A filter used to find all family symbols of the given family.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.Note that it may be faster to get a list of symbol ids from rather than to iterate all of the contents of a document with this filter applied.
Inherits: ElementQuickFilter
Implements: IDisposable

  CONSTRUCTORS:
    new FamilySymbolFilter(ElementId familyId)

  PROPERTIES:
    ElementId FamilyId { get; }
      Description: The family id.

--------------------------------------------------------------------------------


[CLASS] FamilySymbolProfile
Full Name: Autodesk.Revit.DB.FamilySymbolProfile

Description: Represents a family symbol based profile for sweep or swept blend elements.
Remarks: Use objects of this type in methods as NewSweep() and NewSweptBlend() in to create the profile.
Inherits: SweepProfile
Implements: IDisposable

  PROPERTIES:
    double Angle { get; set; }
      Description: The angle of the rotation of the profile in radians.
    bool IsFlipped { get; set; }
      Description: Indicates if the symbol profile is flipped or not.
    FamilySymbol Profile { get; set; }
      Description: Returns the family symbol of the profile.
    double XOffset { get; set; }
      Description: The offset of the profile to the origin of the sketch plane in the X direction.
    double YOffset { get; set; }
      Description: The offset of the profile to the origin of the sketch plane in the Y direction.

--------------------------------------------------------------------------------


[CLASS] FamilyThermalProperties
Full Name: Autodesk.Revit.DB.FamilyThermalProperties

Description: A class that contains thermal properties for specific types of families (doors, windows, and curtain wall panels).
Implements: IDisposable

  CONSTRUCTORS:
    new FamilyThermalProperties()

  PROPERTIES:
    string AnalyticConstructionName { get; }
      Description: The construction gbXML name. This value corresponds to the 'Name' property of a constructionType node in Constructions.xml.
    string AnalyticConstructionTypeId { get; }
      Description: The construction gbXML type. This value corresponds to the 'id' property of a constructionType node in Constructions.xml.
    double HeatTransferCoefficient { get; }
      Description: The heat transfer coefficient value (U-Value). The units are watts per meter-squared kelvin (W/(m^2*K)).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double SolarHeatGainCoefficient { get; }
      Description: The solar heat gain coefficient.
    double ThermalResistance { get; }
      Description: The calculated thermal resistance value (R-Value). The units are meter-squared kelvin per watt ((m^2*K)/Watt).
    double VisualLightTransmittance { get; }
      Description: The visual light transmittance.

  METHODS:
    void Dispose()
    static FamilyThermalProperties Find(Document pADoc, string constructionId)
      Description: Finds the thermal properties by the 'id' property of a constructionType node in Constructions.xml.
      @pADoc: The document.
      @constructionId: The 'id' property of a constructionType node in Constructions.xml
      Returns: The thermal properties found, or if no match was found.
    bool IsValid()
      Description: Confirms that the thermal properties are correctly set for assignment to a FamilySymbol.
      Returns: True if the thermal properties are valid, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FamilyType
Full Name: Autodesk.Revit.DB.FamilyType

Description: The family type object provides read access to the values of family parameters for this type.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    string Name { get; }
      Description: The name of the family type.

  METHODS:
    Nullable<double> AsDouble(FamilyParameter familyParameter)
      Description: Provides access to the double precision number of the given family parameter.
      Returns: The double value contained in the parameter. Returns if the storage type of the input argument is not double type or this parameter has no value.
    ElementId AsElementId(FamilyParameter familyParameter)
      Description: Provides access to the Autodesk::Revit::DB::ElementId^ stored in the given family parameter.
      Returns: The Autodesk::Revit::DB::ElementId^ contained in the parameter.Returns an invalid element id if the storage type of the input argument is Autodesk::Revit::DB::ElementId^ type or this parameter has no value.
    Nullable<int> AsInteger(FamilyParameter familyParameter)
      Description: Provides access to the integer number of the given family parameter.
      Returns: The integer value contained in the parameter. Returns if the storage type of the input argument is not integer type or this parameter has no value.
    string AsString(FamilyParameter familyParameter)
      Description: Provides access to the string contents of the given family parameter.
      Returns: The string contained in the parameter. Returns if the storage type of the input argument is not string type or this parameter has no value.
    string AsValueString(FamilyParameter familyParameter)
      Description: Provides access to value as a string with unit in the given family parameter.
      Returns: The string that represents the parameter value with unit.
    bool HasValue(FamilyParameter familyParameter)
      Description: Indicates if this family parameter has an assigned value or not.

--------------------------------------------------------------------------------


[CLASS] FamilyTypeSet
Full Name: Autodesk.Revit.DB.FamilyTypeSet

Description: A set that contains FamilyType objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new FamilyTypeSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(FamilyType item)
    int Erase(FamilyType item)
    FamilyTypeSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(FamilyType item)
    FamilyTypeSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] FamilyTypeSetIterator
Full Name: Autodesk.Revit.DB.FamilyTypeSetIterator

Description: An iterator to a FamilyType set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new FamilyTypeSetIterator()

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


[ABSTRACT CLASS] FamilyUtils
Full Name: Autodesk.Revit.DB.FamilyUtils

Description: Contains utilities related to family operations.

  METHODS:
    static void ConvertFamilyToFaceHostBased(Document document, ElementId familyId)
      Description: Converts a family to be face host based.
      @document: The document containing the family to be converted.
      @familyId: The family id.
    static bool FamilyCanConvertToFaceHostBased(Document document, ElementId familyId)
      Description: Indicates whether the family can be converted to face host based.
      @document: The document.
      @familyId: The element id of the family.
      Returns: True if the family can be converted to face-based. Otherwise false, which will be returned if there any family instances exist in the project, the family is already face-based, or the family does not have a host. Also, false is returned if the family does not belong to one of the following categories: OST_CommunicationDevicesOST_DataDevicesOST_DuctTerminalOST_ElectricalEquipmentOST_ElectricalFixturesOST_FireAlarmDevicesOST_LightingDevicesOST_LightingFixturesOST_MechanicalControlDevicesOST_MechanicalEquipmentOST_NurseCallDevicesOST_PlumbingEquipmentOST_PlumbingFixturesOST_SecurityDevicesOST_SprinklersOST_TelephoneDevices
    static ICollection<ElementId> GetProfileSymbols(Document document, ProfileFamilyUsage profileFamilyUsage, bool oneCurveLoopOnly)
      Description: Gets the profile Family Symbols of the document.
      @document: The document.
      @profileFamilyUsage: The profile family usage.
      @oneCurveLoopOnly: Whether or not to return only profiles with one curve loop.
      Returns: The set of profile Family Symbol element ids.

--------------------------------------------------------------------------------


[CLASS] FBXExportOptions
Full Name: Autodesk.Revit.DB.FBXExportOptions

Description: 3D-Studio Max (FBX) Export options.

  CONSTRUCTORS:
    new FBXExportOptions()

  PROPERTIES:
    int LevelsOfDetailValue { get; set; }
      Description: The value of the levels of detail.
    bool StopOnError { get; set; }
      Description: Whether export process should stop when a view fails to export.
    bool UseLevelsOfDetail { get; set; }
      Description: True to use levels of detail, false otherwise.
    bool WithoutBoundaryEdges { get; set; }
      Description: True to export without boundary edges, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FilePath
Full Name: Autodesk.Revit.DB.FilePath

Description: This class represents a path on a disk or network location, but not a path to a Revit server location.
Inherits: ModelPath
Implements: IDisposable

  CONSTRUCTORS:
    new FilePath(string path)

--------------------------------------------------------------------------------


[CLASS] FilledRegion
Full Name: Autodesk.Revit.DB.FilledRegion

Description: A filled region element.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    bool IsMasking { get; }
      Description: Indicates whether this element is a 'Filled Region or a 'Masking Region'.

  METHODS:
    static FilledRegion Create(Document document, ElementId typeId, SketchPlane sketchPlane, IList<CurveLoop> boundaries)
      Description: Creates a filled region on a sketch plane in a 3d model family.
      @document: The family document in which to create the filled region.
      @typeId: The filled region type Id.
      @sketchPlane: The sketch plane for use with the filled region.
      @boundaries: The filled region boundaries, which will be projected onto the sketch plane.
      Returns: The new filled region.
    static FilledRegion Create(Document document, ElementId typeId, ElementId viewId, IList<CurveLoop> boundaries)
      Description: Creates a view-specific filled region from the given boundaries.
      @document: The document in which to create the filled region.
      @typeId: The filled region type Id.
      @viewId: The view Id.
      @boundaries: The boundaries.
      Returns: The newly created filled region.
    static FilledRegion CreateMaskingRegion(Document document, SketchPlane sketchPlane, IList<CurveLoop> boundaries)
      Description: Creates a masking region on a sketch plane in a 3d model family.
      @document: The family document in which to create the masking region.
      @sketchPlane: The sketch plane for use with the masking region.
      @boundaries: The masking region boundaries, which will be projected onto the sketch plane.
      Returns: The new masking region.
    static FilledRegion CreateMaskingRegion(Document document, ElementId viewId, IList<CurveLoop> boundaries)
      Description: Creates a view-specific masking region from the given boundaries.
      @document: The document in which to create the masking region.
      @viewId: The view Id.
      @boundaries: The boundaries.
      Returns: The newly created masking region.
    IList<CurveLoop> GetBoundaries()
      Description: Gets the boundaries.
      Returns: The filled region boundaries.
    static IList<ElementId> GetValidLineStyleIdsForFilledRegion(Document document)
      Description: Gets the line style Ids which are permitted to be assigned to a filled region.
      @document: The document.
      Returns: The valid line style Ids.
    static bool IsValidFilledRegionTypeId(Document document, ElementId typeId)
      Description: Indicates whether the given Id is a valid filled region type Id.
      @document: The document.
      @typeId: The filled region type Id.
      Returns: True if it is a valid filled region type Id, false otherwise.
    static bool IsValidLineStyleIdForFilledRegion(Document document, ElementId lineStyleId)
      Description: Indicates whether the given Id is a valid line style Id.
      @document: The document.
      @lineStyleId: The line style Id.
      Returns: True if it is a valid line style Id, false otherwise.
    void SetLineStyleId(ElementId lineStyleId)
      Description: Sets the line style Id for all boundaries.
      @lineStyleId: The line style Id.

--------------------------------------------------------------------------------


[CLASS] FilledRegionType
Full Name: Autodesk.Revit.DB.FilledRegionType

Description: A filled region attributes element. Note, the forground pattern color is stored in the parent class
Inherits: LineAndTextAttrSymbol
Implements: IDisposable

  PROPERTIES:
    Color BackgroundPatternColor { get; set; }
      Description: The background fill pattern color.
    ElementId BackgroundPatternId { get; set; }
      Description: The background fill pattern Id.
    Color ForegroundPatternColor { get; set; }
      Description: The foreground fill pattern color.
    ElementId ForegroundPatternId { get; set; }
      Description: The foreground fill pattern Id.
    bool IsMasking { get; set; }
      Description: If true then the FilledRegion will cover the lines and edges of objects behind it. If false then lines and edges will remain visible.
    int LineWeight { get; set; }
      Description: The line weight of the fill pattern.

  METHODS:
    bool IsValidBackgroundPatternId(ElementId patternId)
      Description: Check if the id is valid for a background pattern
      @patternId: Element id of the FillPatternElement
      Returns: False if the FillPatternElement is a model pattern. True otherwise.
    bool IsValidFillPatternId(ElementId patternId)
      Description: Check if the id is a FillPatternElement or an invalidElementId
      @patternId: Element id of the FillPatternElement
      Returns: True if the id is InvalidElementId, or if the element is a FillPatternElement. False otherwise.
    bool IsValidForegroundPatternId(ElementId patternId)
      Description: Check if the id is valid for a foreground pattern
      @patternId: Element id of the FillPatternElement
      Returns: False if in a family, and the id is a FillPatternElement that targets 'Drafting'. True otherwise.
    static bool IsValidLineWeight(int lineWeight)
      Description: Indicates whether the given line weight value is valid.
      @lineWeight: The line weight.
      Returns: True if it is a valid line weight value, false otherwise.
    bool IsValidMasking(bool isMasking)
      Description: Check that in a family the FillRegionType is always masking.
      @isMasking: The isMasking value to check.
      Returns: True if the IsMasking property can be set to the new value.
    bool IsValidSolidFillPatternId(ElementId patternId)
      Description: Checks if the id is valid for a background pattern
      @patternId: Element id of the FillPatternElement
      Returns: False if in a family and the id is a solid fill pattern and 'isMasking' is masking is false. True otherwise.

--------------------------------------------------------------------------------


[CLASS] FillGrid
Full Name: Autodesk.Revit.DB.FillGrid

Description: Represents a grid line in a fill pattern.
Remarks: A grid line is described in the two dimensions of a face as follows: angle, origin, shift, offset, segments Angle specifies the direction, in degrees, of the grid line relative to the x-axis. Parallel lines are drawn as specified by Offset and Shift to fill the entire face. Offset defines the distance between parallel lines. Zero Offset is not allowed. Shift moves the pattern of dashes and spaces along the length of each new parallel line. Shift is ignored if the line is solid.The segments defines a repeating pattern of dashes and spaces for the grid line. If it is omitted, the line is solid. Positive numbers define dashes, negative numbers define spaces, and zero specifies a dot. If you begin a pattern with a space, do not alternate dashes and spaces, or do not end with a space, Revit will introduce tiny dashes or spaces to compensate. Revit expands dots and very short dashes into dashes of a minimum size.
Implements: IDisposable

  CONSTRUCTORS:
    new FillGrid(double angle, double offset)
    new FillGrid()
    new FillGrid(FillGrid other)

  PROPERTIES:
    double Angle { get; set; }
      Description: Gets and sets the angle of the fill grid.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Offset { get; set; }
      Description: Gets and sets the offset of the fill grid.
    UV Origin { get; set; }
      Description: Gets and sets the origin of the fill grid.
    double Shift { get; set; }
      Description: Gets and sets the shift of the fill grid.

  METHODS:
    double CalculateLengthPerArea()
      Description: Calculates length of the pattern per unit area.
      Returns: The length per area.
    double CalculateLinesPerLength()
      Description: Calculates the number of solid lines of the pattern per unit length.
      Returns: The solid lines per length.
    double CalculateStrokesPerArea()
      Description: Calculates the number of the segments of the pattern per unit area.
      Returns: The strokes per area.
    void Dispose()
    UV GetHatchingDirection()
      Description: Provides the hatching propagation. Hatching is inverted.
      Returns: The direction of hatching.
    int GetPointLineZone(UV point, out UV nearestPoint)
    int GetPointLineZone(UV point)
      Description: Gets the index of fill grid line closest to the input 2d point.
      @point: Input point.
      Returns: The index of fill grid line.
    UV GetSegmentDirection()
      Description: Provides the segment direction.
      Returns: The direction of segment.
    IList<double> GetSegments()
      Description: Gets the segments of the fill grid.
      Returns: The segments.
    bool IsEqual(FillGrid other)
      Description: Check if two fill grids are equal.
      @other: The fill grid to be compared.
      Returns: True if the two fill grids are equal, false otherwise.
    void SetSegments(IList<double> segArr)
      Description: Sets the segments to the fill grid.
      @segArr: The segments to be used.

--------------------------------------------------------------------------------


[CLASS] FillPattern
Full Name: Autodesk.Revit.DB.FillPattern

Description: Represents a fill pattern object.
Remarks: Fill patterns control the appearance of surfaces that are cut or shown in projection. A simple fill pattern consists of a series of parallel or orthogonal lines. Note - Dots are coded as zero-length dashes in the fill pattern definition. When the Revit graphic engine encounters a zero-length line it simply ignores it and doesn't draw anything. So call ExpandDots() for the patterns you construct to convert dots to small dashes, so that the rendering of the FillPattern is correct.
Implements: IDisposable

  CONSTRUCTORS:
    new FillPattern(string name, FillPatternTarget target, FillPatternHostOrientation orientation, double angle, double spacing1, double spacing2)
    new FillPattern(string name, FillPatternTarget target, FillPatternHostOrientation orientation, double angle, double spacing1)
    new FillPattern(string name, FillPatternTarget target, FillPatternHostOrientation orientation)
    new FillPattern()
    new FillPattern(FillPattern other)

  PROPERTIES:
    int GridCount { get; }
      Description: Gets the count of the fill grids in this fill pattern.
    FillPatternHostOrientation HostOrientation { get; set; }
      Description: Orientation to host layer.
    bool IsSolidFill { get; }
      Description: Check if the fill pattern is a solid fill pattern.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LengthPerArea { get; }
      Description: Gets length of all lines that placed on unit area.
    double LinesPerLength { get; }
      Description: Gets the number of solid lines that placed in unit length.
    string Name { get; set; }
      Description: The name of the fill pattern.
    double StrokesPerArea { get; }
      Description: Gets the number of strokes that placed on unit area.
    FillPatternTarget Target { get; set; }
      Description: Target of this fill pattern applied to.

  METHODS:
    void Dispose()
    bool ExpandDots()
      Description: Corrects pattern dots to make them be drawn properly for Revit.
      Returns: Indicates whether any dots were in fact expanded.
    static bool ExportToPAT(IList<FillPattern> fillPatterns, string filename)
      Description: Export a list of FillPatterns to an AutoCAD PAT file.
      @fillPatterns: A list of FillPatterns to export.
      @filename: The full path of the file to export to.
      Returns: True if all patterns were exported successfully, False if export of any pattern failed.
    FillGrid GetFillGrid(int gridIdx)
      Description: Gets the specified fill grid.
      @gridIdx: The index of the fill grid.
      Returns: The fill grid.
    IList<FillGrid> GetFillGrids()
      Description: Gets all fill grids in this fill pattern
      Returns: The fill grids.
    bool IsEqual(FillPattern other)
      Description: Check if the contents and the name of the fill pattern is the same as the name and contents of this fill pattern.
      @other: The fill pattern to be compared.
      Returns: True for equal, false otherwise.
    void SetFillGrid(int gridIdx, FillGrid fillGrid)
      Description: Sets the fill grid.
      @gridIdx: The index of the fill grid.
      @fillGrid: The fill grid to be used.
    void SetFillGrids(IList<FillGrid> fillGrids)
      Description: Set the fill grids in this fill pattern.
      @fillGrids: The fill grids to be used.

--------------------------------------------------------------------------------


[CLASS] FillPatternElement
Full Name: Autodesk.Revit.DB.FillPatternElement

Description: An element that represents a fill pattern.
Remarks: The FillPatternElement represents a fill pattern in a project. It enables the user to retrieve, modify or create a fill pattern in a project.
Inherits: Element
Implements: IDisposable

  METHODS:
    static FillPatternElement Create(Document document, FillPattern fillPattern)
      Description: Creates a new FillPatternElement.
      @document: The document in which to create the FillPatternElement.
      @fillPattern: The FillPattern associated to the newly created FillPatternElement.
      Returns: The newly created FillPatternElement.
    FillPattern GetFillPattern()
      Description: Gets the FillPattern associated to this element.
      Returns: A copy of FillPattern object.
    static FillPatternElement GetFillPatternElementByName(Document document, FillPatternTarget target, string name)
      Description: Retrieves the FillPatternElement by its name.
      @document: The document in which to retrieve the FillPatternElement.
      @target: The FillPatternTarget of the FillPatternElement.
      @name: The name of the FillPatternElement.
      Returns: The FillPatternElement.
    void SetFillPattern(FillPattern newFillPattern)
      Description: Sets the FillPattern associated to this element.
      @newFillPattern: The new FillPattern object.

--------------------------------------------------------------------------------


[ENUM] FillPatternHostOrientation
Full Name: Autodesk.Revit.DB.FillPatternHostOrientation

Description: The types of orientations for fill patterns.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - ToView = 0
    - AsText = 1
    - ToHost = 2


[ENUM] FillPatternTarget
Full Name: Autodesk.Revit.DB.FillPatternTarget

Description: The type of the fill pattern.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Drafting = 0
    - Model = 1
    - None = 2


[CLASS] FilterableValueProvider
Full Name: Autodesk.Revit.DB.FilterableValueProvider

Description: Defines the interface for classes that extract values from elements in a Revit project for testing against filter rules.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ElementId GetAssociatedGlobalParameterValue(Element element)
      Description: Gets a global parameter value associated with a parameter from the given element.
      @element: The element to query.
      Returns: The associated global parameter.
    double GetDoubleValue(Element element)
      Description: Gets a double-precision numeric value from the given element.
      @element: The element to query.
      Returns: The double-precision numeric value from the element.
    ElementId GetElementIdValue(Element element)
      Description: Gets an ElementId value from the given element.
      @element: The element to query.
      Returns: The ElementId value from the element.
    int GetIntegerValue(Element element)
      Description: Gets an integer value from the given element.
      @element: The element to query.
      Returns: The integer value from the element.
    string GetStringValue(Element element)
      Description: Gets a string value from the given element.
      @element: The element to query.
      Returns: The string value from the element.
    bool IsDoubleValueSupported(Element element)
      Description: Determines whether the provide can provide a double-precision numeric value for the given element.
      @element: The element to query.
      Returns: True if the provider can return a double-precision numeric value for the given element, false otherwise.
    bool IsElementIdValueSupported(Element element)
      Description: Determines whether the provide can provide an ElementId value for the given element.
      @element: The element to query.
      Returns: True if the provider can return an ElementId value for the given element, false otherwise.
    bool IsIntegerValueSupported(Element element)
      Description: Determines whether the provide can provide an integer value for the given element.
      @element: The element to query.
      Returns: True if the provider can return an integer value for the given element, false otherwise.
    bool IsStringValueSupported(Element element)
      Description: Determines whether the provide can provide a string value for the given element.
      @element: The element to query.
      Returns: True if the provider can return a string value for the given element, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FilterCategoryRule
Full Name: Autodesk.Revit.DB.FilterCategoryRule

Description: A filter rule that matches elements of a set of categories.
Inherits: FilterRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterCategoryRule(ICollection<ElementId> categories)

  METHODS:
    static bool AllCategoriesFilterable(ICollection<ElementId> categories)
      Description: Checks that all of the given categories are filterable.
      @categories: The set of categories to check.
    ICollection<ElementId> GetCategories()
      Description: Gets the rule's categories.
    bool SetCategories(ICollection<ElementId> categories)
      Description: Sets the rule's categories.
      @categories: The categories.
      Returns: True if the set of categories was changed, false if no change was necessary.

--------------------------------------------------------------------------------


[CLASS] FilterDoubleRule
Full Name: Autodesk.Revit.DB.FilterDoubleRule

Description: A filter rule that operates on double-precision numeric values in a Revit project.
Inherits: FilterNumericValueRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterDoubleRule(FilterableValueProvider valueProvider, FilterNumericRuleEvaluator evaluator, double ruleValue, double epsilon)

  PROPERTIES:
    double Epsilon { get; set; }
      Description: The tolerance within which two floating-point values may be considered equal.
    double RuleValue { get; set; }
      Description: The user-supplied value against which values from a Revit document will be tested.

--------------------------------------------------------------------------------


[CLASS] FilteredElementCollector
Full Name: Autodesk.Revit.DB.FilteredElementCollector

Description: This class is used to search, filter and iterate through a set of elements.
Remarks: Developers can assign a variety of conditions to filter the elements that are returned. This class requires that at least one condition be set before making the attempt to access the elements.Revit will attempt to organize the filters in order to minimize expansion of elements regardless of the order in which conditions and filters are applied.There are three groups of methods that you can use on a given collector once you have applied filter(s) to it. One group provides collections of all passing elements, a second finds the first match of the given filter(s), and a third provides an iterator that is evaluated lazily (each element is tested by the filter only when the iterator reaches it). You should only use one of the methods from these group at a time; the collector will reset if you call another method to extract elements. Thus, if you have previously obtained an iterator, it will be stopped and traverse no more elements if you call another method to extract elements.In .NET, this class supports the IEnumerable interface for Elements. You can use this class with LINQ queries and operations to process lists of elements. Note that because the ElementFilters and the shortcut methods offered by this class process elements in native code before their managed wrappers are generated, better performance will be obtained by using as many native filters as possible on the collector before attempting to process the results using LINQ queries.One special consideration when using this class in .NET: the debugger will attempt to traverse the members of the collector because of its implementation of IEnumerable. You may see strange results if you also attempt to extract the first element or all elements from the collector while the debugger is also looking at the contents of the collector.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new FilteredElementCollector(Document hostDocument, ElementId viewId, ElementId linkId)
    new FilteredElementCollector(Document document, ElementId viewId)
    new FilteredElementCollector(Document document, ICollection<ElementId> elementIds)
    new FilteredElementCollector(Document document)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    FilteredElementCollector ContainedInDesignOption(ElementId designOptionId)
      Description: Applies an ElementDesignOptionFilter to the collector.
      @designOptionId: The design option id.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    void Dispose()
    FilteredElementCollector Excluding(ICollection<ElementId> idsToExclude)
      Description: Applies an ExclusionFilter to the collector.
      @idsToExclude: The ids to exclude from the results.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    Element FirstElement()
      Description: Returns the first element to pass the filter(s).
      Returns: The first element.
    ElementId FirstElementId()
      Description: Returns the id of the first element to pass the filter(s).
      Returns: The first element id.
    int GetElementCount()
      Description: Gets the number of elements in your current filter.
      Returns: The number of elements
    FilteredElementIdIterator GetElementIdIterator()
      Description: Returns an element id iterator to the elements passing the filters.
    FilteredElementIterator GetElementIterator()
      Description: Returns an element iterator to the elements passing the filters.
    IEnumerator<Element> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    FilteredElementCollector IntersectWith(FilteredElementCollector other)
      Description: Intersects the set of elements passing the filter in this collector with the set of elements passing the filter in another collector.
      @other: The other collector
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    static bool IsViewValidForElementIteration(Document document, ElementId viewId)
      Description: Identifies if the particular element is valid for iteration of drawn elements.
      @document: The document.
      @viewId: The view id.
      Returns: True if the element is valid for iteration.
    FilteredElementCollector OfCategory(BuiltInCategory category)
      Description: Applies an ElementCategoryFilter to the collector.
      @category: The category.
      Returns: This collector.
    FilteredElementCollector OfCategoryId(ElementId categoryId)
      Description: Applies an ElementCategoryFilter to the collector.
      @categoryId: The category id.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector OfClass(Type type)
      Description: Applies an ElementClassFilter to the collector.
      @type: The element type.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector OwnedByView(ElementId viewId)
      Description: Applies an ElementOwnerViewFilter to the collector.
      @viewId: The view id of the owner view.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    ICollection<ElementId> ToElementIds()
      Description: Returns the complete set of element ids that pass the filter(s).
      Returns: The complete set of element ids.
    IList<Element> ToElements()
      Description: Returns the complete set of elements that pass the filter(s).
      Returns: The complete set of element ids.
    FilteredElementCollector UnionWith(FilteredElementCollector other)
      Description: Unites the set of elements passing the filter in this collector with the set of elements passing the filter in another collector.
      @other: The other collector
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector WhereElementIsCurveDriven()
      Description: Applies an ElementIsCurveDrivenFilter to the collector.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector WhereElementIsElementType()
      Description: Applies an ElementIsElementTypeFilter to the collector.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector WhereElementIsNotElementType()
      Description: Applies an inverted ElementIsElementTypeFilter to the collector.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector WhereElementIsViewIndependent()
      Description: Applies an ElementOwnerViewFilter to the collector.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    FilteredElementCollector WherePasses(ElementFilter filter)
      Description: Applies an element filter to the collector.
      @filter: The element filter.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.

--------------------------------------------------------------------------------


[CLASS] FilteredElementIdIterator
Full Name: Autodesk.Revit.DB.FilteredElementIdIterator

Description: An iterator to a set of element ids filtered by the settings of a FilteredElementCollector.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    ElementId Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ElementId GetCurrent()
      Description: The current element id found by the iterator.
      Returns: The element id.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more matching elements. False if there are more element ids to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next element id passing the filter.
      Returns: True if there is another available element id passing the filter in this iterator. False if the iterator has completed all available element ids.
    void Reset()
      Description: Resets the iterator to the beginning.

--------------------------------------------------------------------------------


[CLASS] FilteredElementIterator
Full Name: Autodesk.Revit.DB.FilteredElementIterator

Description: An iterator to a set of elements filtered by the settings of a FilteredElementCollector.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    Element Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Element GetCurrent()
      Description: The current element found by the iterator.
      Returns: The element.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more matching elements. False if there are more element ids to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next element passing the filter.
      Returns: True if there is another available element passing the filter in this iterator. False if the iterator has completed all available elements.
    void Reset()
      Description: Resets the iterator to the beginning.

--------------------------------------------------------------------------------


[CLASS] FilteredWorksetCollector
Full Name: Autodesk.Revit.DB.FilteredWorksetCollector

Description: This class is used to search, filter and iterate through a set of worksets.
Remarks: Developers can assign a condition to filter the worksets that are returned. If no condition is applied, it attempts to access all the worksets in the document.The collector will reset if you call another method to extract worksets. Thus, if you have previously obtained an iterator, it will be stopped and traverse no more worksets if you call another method to extract worksets.
Implements: IEnumerable`1, IEnumerable, IDisposable

  CONSTRUCTORS:
    new FilteredWorksetCollector(Document document)

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Workset FirstWorkset()
      Description: Returns the first workset to pass the filter(s).
      Returns: The first workset.
    WorksetId FirstWorksetId()
      Description: Returns the id of the first workset to pass the filter(s).
      Returns: The first workset id.
    IEnumerator<Workset> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    FilteredWorksetIdIterator GetWorksetIdIterator()
      Description: Returns a FilteredWorksetIdIterator to the worksets passing the current filter.
    FilteredWorksetIterator GetWorksetIterator()
      Description: Returns a FilteredWorksetIterator to the worksets passing the current filter.
    FilteredWorksetCollector OfKind(WorksetKind worksetKind)
      Description: Applies a WorksetKindFilter to the collector.
      @worksetKind: The WorksetKind of the workset.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.
    ICollection<WorksetId> ToWorksetIds()
      Description: Returns the complete set of workset ids that pass the filter(s).
      Returns: The complete set of workset ids.
    IList<Workset> ToWorksets()
      Description: Returns the complete set of worksets that pass the filter(s).
      Returns: The complete array of worksets.
    FilteredWorksetCollector WherePasses(WorksetFilter filter)
      Description: Applies a workset filter to the collector.
      @filter: The workset filter.
      Returns: A handle to this collector. This is the same collector that has just been modified, returned so you can chain multiple calls together in one line.

--------------------------------------------------------------------------------


[CLASS] FilteredWorksetIdIterator
Full Name: Autodesk.Revit.DB.FilteredWorksetIdIterator

Description: An iterator to a set of workset ids filtered by the settings of a FilteredWorksetCollector.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    WorksetId Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    WorksetId GetCurrent()
      Description: The current workset id found by the iterator.
      Returns: The workset id.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more matching worksets. False if there are more workset ids to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next workset id passing the filter.
      Returns: True if there is another available workset id passing the filter in this iterator. False if the iterator has completed all available workset ids.
    void Reset()
      Description: Resets the iterator to the beginning.

--------------------------------------------------------------------------------


[CLASS] FilteredWorksetIterator
Full Name: Autodesk.Revit.DB.FilteredWorksetIterator

Description: An iterator to a set of worksets filtered by the settings of a FilteredWorksetCollector.
Implements: IEnumerator`1, IDisposable, IEnumerator

  PROPERTIES:
    Workset Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Workset GetCurrent()
      Description: The current workset found by the iterator.
      Returns: The workset.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more matching worksets. False if there are more worksets to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next workset passing the filter.
      Returns: True if there is another available workset passing the filter in this iterator. False if the iterator has completed all available worksets.
    void Reset()
      Description: Resets the iterator to the beginning.

--------------------------------------------------------------------------------


[CLASS] FilterElement
Full Name: Autodesk.Revit.DB.FilterElement

Description: The base class for filter elements in the document.
Inherits: Element
Implements: IDisposable

  METHODS:
    static bool IsNameUnique(Document aDocument, string name)
      Description: Determines whether the given name could be applied to a new FilterElement, or if it could not be applied because the name is already in use.
      @aDocument: The document in which the name is being tested for uniqueness.
      @name: The name tested for uniqueness.
      Returns: Returns true if the name is unique, and false otherwise.
    bool IsNameUnique(string name)
      Description: Determines whether a potential filter element name is unique.
      @name: The candidate name.

--------------------------------------------------------------------------------


[CLASS] FilterElementIdRule
Full Name: Autodesk.Revit.DB.FilterElementIdRule

Description: A filter rule that operates on ElementId values in a Revit project.
Remarks: When returns a parameter that , then the comparisons will first compare the values of the levels' elevations, then compare the levels' names, and finally the levels' element ids to rank and sort the levels.
Inherits: FilterNumericValueRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterElementIdRule(FilterableValueProvider valueProvider, FilterNumericRuleEvaluator evaluator, ElementId ruleValue)

  PROPERTIES:
    ElementId RuleValue { get; set; }
      Description: The user-supplied value against which values from a Revit document will be tested.

  METHODS:
    static bool UsesLevelFiltering(Document doc, ElementId parameterId)
      Description: This function checks if a parameter uses level filtering.
      @doc: The document which owns the parameter.
      @parameterId: The id of the parameter that will be tested to see if it uses level filtering.
      Returns: True if the parameter uses level filtering, false otherwise.

--------------------------------------------------------------------------------


[CLASS] FilterGlobalParameterAssociationRule
Full Name: Autodesk.Revit.DB.FilterGlobalParameterAssociationRule

Description: A filter rule that operates on global parameters ElementId values in a Revit project.
Inherits: FilterNumericValueRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterGlobalParameterAssociationRule(FilterableValueProvider valueProvider, FilterNumericRuleEvaluator evaluator, ElementId ruleValue)

  PROPERTIES:
    ElementId RuleValue { get; set; }
      Description: The user-supplied global parameter value against which values from a Revit document will be tested.

--------------------------------------------------------------------------------


[CLASS] FilterIntegerRule
Full Name: Autodesk.Revit.DB.FilterIntegerRule

Description: A filter rule that operates on integer values in a Revit project.
Inherits: FilterNumericValueRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterIntegerRule(FilterableValueProvider valueProvider, FilterNumericRuleEvaluator evaluator, int ruleValue)

  PROPERTIES:
    int RuleValue { get; set; }
      Description: The user-supplied value against which values from a Revit document will be tested.

--------------------------------------------------------------------------------


[CLASS] FilterInverseRule
Full Name: Autodesk.Revit.DB.FilterInverseRule

Description: A filter rule that inverts the boolean values returned by the rule it contains.
Remarks: FilterInverse rule performs a logical "not" operation on its inner rule's "elementPasses()" method.
Inherits: FilterRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterInverseRule(FilterRule innerRule)

  METHODS:
    FilterRule GetInnerRule()
      Description: Gets the rule being inverted.
    void SetInnerRule(FilterRule innerRule)
      Description: Gets the rule being inverted.
      @innerRule: The rule to invert.

--------------------------------------------------------------------------------


[CLASS] FilterNumericEquals
Full Name: Autodesk.Revit.DB.FilterNumericEquals

Description: Tests whether numeric values from the document are equal to a certain value
Inherits: FilterNumericRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterNumericEquals()

--------------------------------------------------------------------------------


[CLASS] FilterNumericGreater
Full Name: Autodesk.Revit.DB.FilterNumericGreater

Description: Tests whether numeric values from the document are greater than a certain value
Inherits: FilterNumericRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterNumericGreater()

--------------------------------------------------------------------------------


[CLASS] FilterNumericGreaterOrEqual
Full Name: Autodesk.Revit.DB.FilterNumericGreaterOrEqual

Description: Tests whether numeric values from the document are greater than or equal to a certain value
Inherits: FilterNumericRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterNumericGreaterOrEqual()

--------------------------------------------------------------------------------


[CLASS] FilterNumericLess
Full Name: Autodesk.Revit.DB.FilterNumericLess

Description: Tests whether numeric values from the document are less than a certain value
Inherits: FilterNumericRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterNumericLess()

--------------------------------------------------------------------------------


[CLASS] FilterNumericLessOrEqual
Full Name: Autodesk.Revit.DB.FilterNumericLessOrEqual

Description: Tests whether numeric values from the document are less than or equal to a certain value
Inherits: FilterNumericRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterNumericLessOrEqual()

--------------------------------------------------------------------------------


[CLASS] FilterNumericRuleEvaluator
Full Name: Autodesk.Revit.DB.FilterNumericRuleEvaluator

Description: Base for all classes that compare numeric values from Revit to a user-supplied filter value.
Remarks: A class derived from FilterNumericRuleEvaluator must handle both integer and double-precision types. For double-precision comparisons, an epsilon value is given. The evaluator class should use this value in a manner appropriate to the comparison being implemented.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool Evaluate(long lhs, long rhs)
      Description: Derived classes should override this method to implement the desired test.
      @lhs: A value from an element in the document.
      @rhs: The user-supplied value against which values from the document are tested.
      Returns: True if lhs, rhs satisfy the condition implemented by this evaluator.
    bool Evaluate(int lhs, int rhs)
      Description: Derived classes should override this method to implement the desired test.
      @lhs: A value from an element in the document.
      @rhs: The user-supplied value against which values from the document are tested.
      Returns: True if lhs, rhs satisfy the condition implemented by this evaluator.
    bool Evaluate(double lhs, double rhs, double epsilon)
      Description: Derived classes override this method to implement the test that determines whether the two given double-precision values satisfy the desired condition or not.
      @lhs: A value from an element in the document.
      @rhs: The user-supplied value against which values from the document are tested.
      @epsilon: Defines the tolerance within which two values may be considered equal.
      Returns: True if the given arguments satisfy the condition, otherwise false.

--------------------------------------------------------------------------------


[CLASS] FilterNumericValueRule
Full Name: Autodesk.Revit.DB.FilterNumericValueRule

Description: Base for all classes that use a FilterNumericRuleEvaluator to perform their comparisons
Inherits: FilterValueRule
Implements: IDisposable

  METHODS:
    FilterNumericRuleEvaluator GetEvaluator()
      Description: Gets the evaluator that implements the test for this rule.
    void SetEvaluator(FilterNumericRuleEvaluator evaluator)
      Description: Sets the evaluator that implements the test for this rule.

--------------------------------------------------------------------------------


[CLASS] FilterOperatorAndTextString
Full Name: Autodesk.Revit.DB.FilterOperatorAndTextString

Description: An instance of this class holds a filter operator and a text string that denotes the operator in a particular context. For example, the text string for ScheduleFilterType::LessThan may be "is less than" for a filter rule based on a parameter with numerical values or "is below" for a filter rule based on a parameter representing a Level.
Implements: IDisposable

  PROPERTIES:
    string FilterOperatorStr { get; }
      Description: A text string denoting the filter operator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ScheduleFilterType OperatorType { get; }
      Description: The filter operator.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] FilterRule
Full Name: Autodesk.Revit.DB.FilterRule

Description: Defines a boolean operation that can be used to cull elements from a document.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool ElementPasses(Element element)
      Description: Derived classes override this method to implement the test that determines whether the given element passes this rule or not.
      @element: The element to test against the rule.
      Returns: True if the element satisfies the rule, false otherwise.
    ElementId GetRuleParameter()
      Description: Returns the ElementId of the parameter associated to this FilterRule if there is one, or invalidElementId if there is no associated parameter.
      Returns: The parameter id if there is an associated parameter, or invalidElementId if not.

--------------------------------------------------------------------------------


[CLASS] FilterStringBeginsWith
Full Name: Autodesk.Revit.DB.FilterStringBeginsWith

Description: Tests whether string values from the document begin with a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringBeginsWith()

--------------------------------------------------------------------------------


[CLASS] FilterStringContains
Full Name: Autodesk.Revit.DB.FilterStringContains

Description: Tests whether string values from the document contain a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringContains()

--------------------------------------------------------------------------------


[CLASS] FilterStringEndsWith
Full Name: Autodesk.Revit.DB.FilterStringEndsWith

Description: Tests whether string values from the document end with a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringEndsWith()

--------------------------------------------------------------------------------


[CLASS] FilterStringEquals
Full Name: Autodesk.Revit.DB.FilterStringEquals

Description: Tests whether string values from the document match a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringEquals()

--------------------------------------------------------------------------------


[CLASS] FilterStringGreater
Full Name: Autodesk.Revit.DB.FilterStringGreater

Description: Tests whether string values from the document would sort after a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringGreater()

--------------------------------------------------------------------------------


[CLASS] FilterStringGreaterOrEqual
Full Name: Autodesk.Revit.DB.FilterStringGreaterOrEqual

Description: Tests whether string values from the document would sort after or match a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringGreaterOrEqual()

--------------------------------------------------------------------------------


[CLASS] FilterStringLess
Full Name: Autodesk.Revit.DB.FilterStringLess

Description: Tests whether string values from the document would sort before a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringLess()

--------------------------------------------------------------------------------


[CLASS] FilterStringLessOrEqual
Full Name: Autodesk.Revit.DB.FilterStringLessOrEqual

Description: Tests whether string values from the document would sort before or match a certain string.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterStringRuleEvaluator
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringLessOrEqual()

--------------------------------------------------------------------------------


[CLASS] FilterStringRule
Full Name: Autodesk.Revit.DB.FilterStringRule

Description: A filter rule that operates on string values in a Revit project.
Remarks: All string comparisons in this class are performed in the case-insensitive manner.
Inherits: FilterValueRule
Implements: IDisposable

  CONSTRUCTORS:
    new FilterStringRule(FilterableValueProvider valueProvider, FilterStringRuleEvaluator evaluator, string ruleString)

  PROPERTIES:
    string RuleString { get; set; }
      Description: The user-supplied string against which strings from a Revit document will be tested.

  METHODS:
    FilterStringRuleEvaluator GetEvaluator()
      Description: Gets the evaluator that implements the test for this rule.
    void SetEvaluator(FilterStringRuleEvaluator evaluator)
      Description: Sets the evaluator that implements the test for this rule.

--------------------------------------------------------------------------------


[CLASS] FilterStringRuleEvaluator
Full Name: Autodesk.Revit.DB.FilterStringRuleEvaluator

Description: Base for all classes that compare string values from Revit to a user-supplied filter value
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool Evaluate(string lhs, string rhs, bool caseSensitive)
      Description: Derived classes override this method to implement the test that determines whether the two given string values satisfy the desired condition or not.
      @lhs: A value from an element in the document.
      @rhs: The user-supplied value against which values from the document are tested.
      @caseSensitive: If true, string comparisons are done case-sensitively.
      Returns: True if the given arguments satisfy the condition, otherwise false.

--------------------------------------------------------------------------------


[CLASS] FilterValueRule
Full Name: Autodesk.Revit.DB.FilterValueRule

Description: A rule that filters on a particular value of an element.
Inherits: FilterRule
Implements: IDisposable

--------------------------------------------------------------------------------


[ENUM] FindReferenceTarget
Full Name: Autodesk.Revit.DB.FindReferenceTarget

Description: The type of reference to find from a ReferenceIntersector.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Element = 1
    - Mesh = 2
    - Edge = 4
    - Curve = 8
    - Face = 16
    - All = 31


[ENUM] FitDirectionType
Full Name: Autodesk.Revit.DB.FitDirectionType

Description: This enum is used to define the direction to fit the number of pixels defined by PixelSize.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Horizontal = 0
    - Vertical = 1


[ENUM] FittingAndAccessoryCalculationType
Full Name: Autodesk.Revit.DB.FittingAndAccessoryCalculationType

Description: The MEP fitting and accessory pressure drop calculation type.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Undefined = 0
    - CalculatePressureDrop = 1
    - CalculateDefaultSettings = 2
    - ValidateCurrentSettings = 4


[ENUM] FittingAngleUsage
Full Name: Autodesk.Revit.DB.FittingAngleUsage

Description: An enumerated type representing the options for how to limit the angle values applicable to fitting content.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UseAnyAngle = 0
    - UseAnAngleIncrement = 1
    - UseSpecificAngles = 2


[CLASS] Floor
Full Name: Autodesk.Revit.DB.Floor

Description: An object that represents a Floor within the Autodesk Revit project.
Remarks: This object derived from the Element base object and such supports all the methods of that object such as the ability to retrieve the parameters of that object.
Inherits: CeilingAndFloor
Implements: IDisposable

  PROPERTIES:
    FloorType FloorType { get; set; }
      Description: Retrieves/sets an object that represents the type of the floor.
    ElementId SketchId { get; }
      Description: Returns id of the sketch.
    SlabShapeEditor SlabShapeEditor { get; }
      Description: Get the SlabShapeEditor used for slab shape editing.
    double SpanDirectionAngle { get; set; }
      Description: Retrieve the span direction angle of the floor.

  METHODS:
    static Floor Create(Document document, IList<CurveLoop> profile, ElementId floorTypeId, ElementId levelId)
      Description: Creates a new instance of architectural floor within the project.
      @document: The document in which the new floor is created.
      @profile: An array of planar curve loops that represent the profile of the floor.
      @floorTypeId: Id of the floor type to be used by the new Floor.
      @levelId: Id of the level on which the floor is to be placed.
      Returns: If successful a new floor object within the project.
    static Floor Create(Document document, IList<CurveLoop> profile, ElementId floorTypeId, ElementId levelId, bool isStructural, Line slopeArrow, double slope)
      Description: Creates a new instance of floor within the project.
      @document: The document in which the new floor is created.
      @profile: An array of planar curve loops that represent the profile of the floor.
      @floorTypeId: Id of the floor type to be used by the new Floor.
      @levelId: Id of the level on which the floor is to be placed.
      @isStructural: True if new floor should be structural, false if architectural.
      @slopeArrow: A line used to control the slope angle of the Floor. It must be horizontal. If slopeArrow is , the horizontal floor will be created.
      @slope: The slope angle. If slopeArrow is , this parameter will be ignored.
      Returns: If successful a new floor object within the project.
    static ElementId GetDefaultFloorType(Document document, bool isFoundation)
      Description: Returns id of default floor type.
      @document: The document.
      @isFoundation: True to return id of foundation floor type.
    XYZ GetNormalAtVerticalProjectionPoint(XYZ modelLocation, FloorFace floorFace)
      Description: Return a surface normal on either the top or bottom face of a floor slab at a point corresponding to the vertical projection of an arbitrary point in project space.
      @modelLocation: A point in project coordinates whose vertical projection will determine the location at which the normal will be taken.
      @floorFace: A flag determining whether the top or bottom face of the floor should be used.
      Returns: Normal vector on the slab at the projection point.
    SlabShapeEditor GetSlabShapeEditor()
      Description: Gets a SlabShapeEditor that can be used to add or modify points of this Floor.
      Returns: The SlabShapeEditor object
    ICollection<ElementId> GetSpanDirectionSymbolIds()
      Description: Retrieves span direction symbol ElementIds.
      Returns: A collection of Element Ids of span direction symbol elements
    XYZ GetVerticalProjectionPoint(XYZ modelLocation, FloorFace floorFace)
      Description: Return a surface point on either the top or bottom face of a floor slab corresponding to the vertical projection of an arbitrary point in project space.
      @modelLocation: A point in project coordinates that will be projected to the slab top or bottom face.
      @floorFace: A flag determining whether the top or bottom face of the floor should be used.
      Returns: Slab surface point for the vertically projected model point.

--------------------------------------------------------------------------------


[ENUM] FloorFace
Full Name: Autodesk.Revit.DB.FloorFace

Description: An enumerated type listing floor face types (top or bottom)
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Top = 0
    - Bottom = 1


[CLASS] FloorType
Full Name: Autodesk.Revit.DB.FloorType

Description: An object that specifies the type of a floor in Autodesk Revit.
Remarks: The structural layers of the floor can be accessed via this object.
Inherits: HostObjAttributes
Implements: IDisposable

  PROPERTIES:
    bool IsFoundationSlab { get; }
      Description: Returns whether the element FloorAttributes type is FoundationSlab.
    ElementId StructuralMaterialId { get; set; }
      Description: Returns the identifier of the material that defines the element's structural analysis properties.
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the FloorType

--------------------------------------------------------------------------------


[ENUM] FlowDirectionType
Full Name: Autodesk.Revit.DB.FlowDirectionType

Description: An enumerated type listing direction types for a connector.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Bidirectional = 0
    - In = 1
    - Out = 2


[CLASS] FolderItemInfo
Full Name: Autodesk.Revit.DB.FolderItemInfo

Description: Contains data for each folder item in the organization settings of the project browser including folder parameter Id and folder name.
Remarks: FolderItemInfo is the return value of BrowserOrganization.GetFolderItems().
Implements: IDisposable

  PROPERTIES:
    ElementId ElementId { get; }
      Description: The folder parameter Id
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; }
      Description: The folder name

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------


[CLASS] FootPrintRoof
Full Name: Autodesk.Revit.DB.FootPrintRoof

Description: Represents kinds of FootPrintRoofs.
Remarks: The FootPrintRoof object represents some kinds of FootPrintRoof in Revit. The RoofType property is used to distinguish the type of the roof.
Inherits: RoofBase
Implements: IDisposable

  PROPERTIES:
    CurtainGridSet CurtainGrids { get; }
      Description: Retrieve all the CurtainGrid objects of a FootPrintRoof.
    bool DefinesSlope { get; set; }
    bool ExtendIntoWall { get; set; }
    double Offset { get; set; }
    double Overhang { get; set; }
    double SlopeAngle { get; set; }

  METHODS:
    ModelCurveArrArray GetProfiles()
      Description: Retrieve all the curveLoops of FootPrintRoof.

--------------------------------------------------------------------------------


[CLASS] ForgeTypeId
Full Name: Autodesk.Revit.DB.ForgeTypeId

Description: This class holds a string that uniquely identifies a Forge schema.
Implements: IDisposable

  CONSTRUCTORS:
    new ForgeTypeId(string typeId)
    new ForgeTypeId()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string TypeId { get; set; }
      Description: The schema identifier.

  METHODS:
    ForgeTypeId Clear()
      Description: Sets the typeId to an empty string
    void Dispose()
    bool Empty()
      Description: Checks if the typeId is an empty string
    bool Equals(object other)
      Description: Determines whether this ForgeTypeId is equal to another.
      @other: The ForgeTypeId with which to compare this ForgeTypeId.
      Returns: True if the given ForgeTypeId is equal to this one, or false otherwise.
    int GetHashCode()
      Description: Returns the hash code for this ForgeTypeId
      Returns: A 32-bit signed integer hash code.
    bool NameEquals(ForgeTypeId other)
      Description: Returns true if the typeid string held by this ForgeTypeId is equal to that held by the given ForgeTypeId, excluding the version number. The version number of a typeid string follows a hyphen character. This function compares the typeid strings up to the first hyphen. This is the default equality comparison method for the ForgeTypeId class, used by the equality operator (==).
    bool StrictlyEquals(ForgeTypeId other)
      Description: Returns true if the entire typeid string held by this ForgeTypeId is exactly equal to that held by the given ForgeTypeId. For the default equality comparison used by the equality operator (==), see NameEquals(ForgeTypeId).

--------------------------------------------------------------------------------


[CLASS] Form
Full Name: Autodesk.Revit.DB.Form

Description: An object that represents a Form within the Autodesk Revit Massing Family.
Remarks: For any reference returned from a Form method, its GeometryObject will become invalid after a form modification method, e.g. MoveSubElement. Call the method on the Form object to retrieve the new reference if it is needed after the modification.
Inherits: GenericForm
Implements: IDisposable

  PROPERTIES:
    bool AreProfilesConstrained { get; set; }
      Description: Get/set if the form's profiles are constrained.
    double BaseOffset { get; set; }
      Description: Retrieve/set the base offset of the form object. It is only valid for locked form.
    ReferenceArray CurveLoopReferencesOnProfile { get; }
    bool HasOneOrMoreReferenceProfiles { get; }
      Description: Tell if the form has any reference profile.
    bool HasOpenGeometry { get; }
      Description: Tell if the form has an open geometry.
    bool IsInXRayMode { get; set; }
      Description: Get/set if the form is in X-Ray mode.
    int PathCurveCount { get; }
      Description: The number of curves in the form path.
    Reference PathCurveReference { get; }
    int ProfileCount { get; }
      Description: The number of profiles in the form.
    int ProfileCurveLoopCount { get; }
    double TopOffset { get; set; }
      Description: Retrieve/set the top offset of the form object. It is only valid for locked form.

  METHODS:
    void AddEdge(Reference startPointReference, Reference endPointReference)
      Description: Add an edge to the form, connecting two edges on same/different profile, by a pair of specified points.
      @startPointReference: The geometry reference of start point
      @endPointReference: The geometry reference of end point
    void AddEdge(Reference startEdgeReference, double startParam, Reference endEdgeReference, double endParam)
      Description: Add an edge to the form, connecting two edges on same/different profile, by a pair of specified edge/param.
      @startEdgeReference: The geometry reference of start edge
      @startParam: The param on start edge to specify the location.
      @endEdgeReference: The geometry reference of end edge
      @endParam: The param on end edge to specify the location.
    void AddEdge(Reference faceReference, XYZ point)
      Description: Add an edge to the form, connecting two edges on different profiles, by a specified face of the form and a point on face.
      @faceReference: The geometry reference of face
      @point: A point on the face, defining the position of edge to be created.
    int AddProfile(Reference edgeReference, double param)
      Description: Add a profile into the form, by a specified edge/param.
      @edgeReference: The geometry reference of edge.
      @param: The param on edge to specify the location.
      Returns: Index of newly created profile.
    bool CanManipulateProfile(int profileIndex)
      Description: Tell if a profile can be deleted/moved/rotated.
      @profileIndex: Index to specify the profile.
    bool CanManipulateSubElement(Reference subElementReference)
      Description: Tell if a sub element can be deleted/moved/rotated/scaled.
      @subElementReference: The geometry reference of face/edge/curve/vertex
    void ConstrainProfiles(int primaryProfileIndex)
      Description: Constrain form profiles using the specified profile as primary. This is an advanced version of property "AreProfilesConstrained", allowing specify the primary profile.
      @primaryProfileIndex: Index to specify the profile used as primary profile.
    void DeleteProfile(int profileIndex)
      Description: Delete a profile of the form.
      @profileIndex: Index to specify the profile.
    void DeleteSubElement(Reference subElementReference)
      Description: Delete a face/edge/curve/vertex of the form, specified by a reference.
      @subElementReference: The geometry reference of face/edge/curve/vertex
    ReferenceArray GetControlPoints(Reference curveOrEdgeOrFaceReference)
      Description: Given an edge or a curve or a face, return all control points lying on it (in form of geometry references).
      @curveOrEdgeOrFaceReference: The reference of an edge or curve or face.
      Returns: Reference array containing all control points lying on it.
    ReferenceArray GetCurvesAndEdgesReference(Reference pointReference)
      Description: Given a point, return all edges and curves that it is lying on.
      @pointReference: The reference of a point.
      Returns: Reference array containing all edges and curves that the point is lying on.
    int GetPathCurveIndexByCurveReference(Reference curveReference)
      Description: Given a reference to certain curve in the path, return its index.
      @curveReference: Reference to the curve in path
    void GetProfileAndCurveLoopIndexFromReference(Reference curveOrEdgeReference, ref int profileIndex, ref int curveLoopIndex)
    bool IsAutoCreaseEdge(Reference edgeReference)
      Description: Tell if an edge is an auto-crease on a top/bottom cap face.
      @edgeReference: The reference of the edge to be checked.
    bool IsBeginningFace(Reference faceReference)
      Description: Given a face, tell if it is a beginning cap face.
      @faceReference: The reference of the face to be checked.
    bool IsConnectingEdge(Reference edgeReference)
      Description: Tell if an edge is a connecting edge on a side face. Connecting edges connect vertices on different profiles.
      @edgeReference: The reference of the edge to be checked.
    bool IsCurveReference(Reference curveReference)
      Description: Tell if the pick is the reference to a curve of the form.
      @curveReference: Reference to be checked.
    bool IsEdgeReference(Reference edgeReference)
      Description: Tell if the pick is the reference to an edge of the form.
      @edgeReference: Reference to be checked.
    bool IsEndFace(Reference faceReference)
      Description: Given a face, tell if it is an end cap face.
      @faceReference: The reference of the face to be checked.
    bool IsFaceReference(Reference faceReference)
      Description: Tell if the pick is the reference to a face of the form.
      @faceReference: Reference to be checked.
    bool IsProfileEdge(Reference curveOrEdgeReference)
      Description: Tell if an edge or curve is generated from a profile.
      @curveOrEdgeReference: The reference of the edge or curve to be checked.
    bool IsReferenceOnlyProfile(int profileIndex)
      Description: Tell if the profile is made by referencing existing geometry in the Revit model.
      @profileIndex: Index to specify the profile to be checked.
    bool IsSideFace(Reference faceReference)
      Description: Given a face, tell if it is a side face.
      @faceReference: The reference of the face to be checked.
    bool IsVertexReference(Reference vertexReference)
      Description: Tell if the pick is the reference to a vertex of the form.
      @vertexReference: Reference to be checked.
    void MoveProfile(int profileIndex, XYZ offset)
      Description: Move a profile of the form, specified by a reference, and an offset vector.
      @profileIndex: Index to specify the profile.
      @offset: The vector by which the element is to be moved.
    void MoveSubElement(Reference subElementReference, XYZ offset)
      Description: Move a face/edge/curve/vertex of the form, specified by a reference, and an offset vector.
      @subElementReference: The geometry reference of face/edge/curve/vertex
      @offset: The vector by which the element is to be moved.
    void Rehost(SketchPlane sketchPlane, XYZ location)
      Description: Rehost Form to sketch plane
      @sketchPlane: The sketch plane on which to rehost the form.
      @location: The location to which to Rehost the form.
    void Rehost(Reference hostRef, XYZ location)
      Description: Rehost Form to edge, face or curve.
      @hostRef: The geometry reference on which to rehost the form.
      @location: The location to which to Rehost the form.
    void RotateProfile(int profileIndex, Line axis, double angle)
      Description: Rotate a profile of the form, by a specified angle around a given axis.
      @profileIndex: Index to specify the profile.
      @axis: An unbounded line that represents the axis of rotation.
      @angle: The angle, in radians, by which the element is to be rotated around the specified axis.
    void RotateSubElement(Reference subElementReference, Line axis, double angle)
      Description: Rotate a face/edge/curve/vertex of the form, by a specified angle around a given axis.
      @subElementReference: The geometry reference of face/edge/curve/vertex
      @axis: An unbounded line that represents the axis of rotation.
      @angle: The angle, in radians, by which the element is to be rotated around the specified axis.
    void ScaleProfile(int profileIndex, double factor, XYZ origin)
      Description: Scale a profile of the form, by a specified origin and scale factor.
      @profileIndex: Index to specify the profile.
      @factor: The scale factor, it should be large than zero.
      @origin: The origin where scale happens.
    void ScaleSubElement(Reference subElementReference, double factor, XYZ origin)
      Description: Scale a face/edge/curve/vertex of the form, by a specified origin and scale factor.
      @subElementReference: The geometry reference of face/edge/curve/vertex
      @factor: The scale factor, it should be large than zero.
      @origin: The origin where scale happens.

--------------------------------------------------------------------------------


[CLASS] FormArray
Full Name: Autodesk.Revit.DB.FormArray

Description: An array that contains form objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new FormArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Form Item { get; set; }
    int Size { get; }
      Description: Returns the number of forms that are in the array.

  METHODS:
    void Append(Form item)
    void Clear()
      Description: Removes every form from the array, rendering it empty.
    FormArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Form item, int index)
    FormArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] FormArrayIterator
Full Name: Autodesk.Revit.DB.FormArrayIterator

Description: An iterator to a form array.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new FormArrayIterator()

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


[CLASS] FormatOptions
Full Name: Autodesk.Revit.DB.FormatOptions

Description: Options for formatting numbers with units.
Remarks: The FormatOptions class contains settings that control how to format numbers with units as strings. It contains those settings that are typically chosen by an end user in the Format dialog and stored in the document.The FormatOptions class is used in two different ways. A FormatOptions object in the Units class represents the default settings for the document. A FormatOptions object used elsewhere represents settings that may optionally override the default settings.The UseDefault property controls whether a FormatOptions object represents default or custom formatting. If UseDefault is true, formatting will be according to the default settings in the Units class, and none of the other settings in the object are meaningful. If UseDefault is false, the object contains custom settings that override the default settings in the Units class. UseDefault is always false for FormatOptions objects in the Units class.
Implements: IDisposable

  CONSTRUCTORS:
    new FormatOptions(FormatOptions other)
    new FormatOptions(ForgeTypeId unitTypeId, ForgeTypeId symbolTypeId)
    new FormatOptions(ForgeTypeId unitTypeId)
    new FormatOptions()

  PROPERTIES:
    double Accuracy { get; set; }
      Description: The accuracy to which values will be rounded.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    RoundingMethod RoundingMethod { get; set; }
      Description: The method used to round values: round to nearest, round up, or round down.
    bool SuppressLeadingZeros { get; set; }
      Description: Indicates if leading zeros should be suppressed in feet and fractional inches.
    bool SuppressSpaces { get; set; }
      Description: Indicates if spaces around the dash should be suppressed in feet and fractional inches.
    bool SuppressTrailingZeros { get; set; }
      Description: Indicates if trailing zeros after the decimal point should be suppressed.
    bool UseDefault { get; set; }
      Description: Indicates whether default or custom formatting should be used.
    bool UseDigitGrouping { get; set; }
      Description: Indicates if digit grouping symbols should be displayed.
    bool UsePlusPrefix { get; set; }
      Description: Indicates if a plus sign prefix should be displayed for positive and zero values.

  METHODS:
    bool CanHaveSymbol()
      Description: Checks whether a symbol can be specified to display the unit in this FormatOptions.
      Returns: True if a symbol can be specified, false otherwise.
    static bool CanHaveSymbol(ForgeTypeId unitTypeId)
      Description: Checks whether a symbol can be specified to display a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: True if a symbol can be specified, false otherwise.
    bool CanSuppressLeadingZeros()
      Description: Checks whether leading zeros can be suppressed for the display unit in this FormatOptions.
      Returns: True if leading zeros can be suppressed, false otherwise.
    static bool CanSuppressLeadingZeros(ForgeTypeId unitTypeId)
      Description: Checks whether leading zeros can be suppressed for a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: True if leading zeros can be suppressed, false otherwise.
    bool CanSuppressSpaces()
      Description: Checks whether spaces can be suppressed for the display unit in this FormatOptions.
      Returns: True if spaces can be suppressed, false otherwise.
    static bool CanSuppressSpaces(ForgeTypeId unitTypeId)
      Description: Checks whether spaces can be suppressed for a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: True if spaces can be suppressed, false otherwise.
    bool CanSuppressTrailingZeros()
      Description: Checks whether trailing zeros can be suppressed for the display unit in this FormatOptions.
      Returns: True if trailing zeros can be suppressed, false otherwise.
    static bool CanSuppressTrailingZeros(ForgeTypeId unitTypeId)
      Description: Checks whether trailing zeros can be suppressed for a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: True if trailing zeros can be suppressed, false otherwise.
    bool CanUsePlusPrefix()
      Description: Checks whether a plus prefix can be displayed for the display unit in this FormatOptions.
      Returns: True if a plus prefix can be displayed, false otherwise.
    static bool CanUsePlusPrefix(ForgeTypeId unitTypeId)
      Description: Checks whether a plus prefix can be displayed for a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: True if a plus prefix can be displayed, false otherwise.
    void Dispose()
    ForgeTypeId GetSymbolTypeId()
      Description: Gets the identifier of the symbol indicating the unit quantifying the value.
      Returns: The symbol identifier. An empty identifier string indicates no symbol.
    ForgeTypeId GetUnitTypeId()
      Description: Gets the identifier of the unit used to quantify values.
    IList<ForgeTypeId> GetValidSymbols()
      Description: Gets the identifiers of all valid symbols for the unit in this FormatOptions.
      Returns: Identifiers of the valid symbols.
    static IList<ForgeTypeId> GetValidSymbols(ForgeTypeId unitTypeId)
      Description: Gets the identifiers of all valid symbols for a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: Identifiers of the valid symbols.
    bool IsValidAccuracy(double accuracy)
      Description: Checks whether an accuracy is valid for the display unit in this FormatOptions.
      @accuracy: The accuracy to check.
      Returns: True if the accuracy is valid, false otherwise.
    static bool IsValidAccuracy(ForgeTypeId unitTypeId, double accuracy)
      Description: Checks whether an accuracy is valid for a given unit.
      @unitTypeId: Identifier of the unit.
      @accuracy: The accuracy to check.
      Returns: True if the accuracy is valid, false otherwise.
    bool IsValidForSpec(ForgeTypeId specTypeId)
      Description: Checks whether this FormatOptions is valid for a given spec.
      @specTypeId: Identifier of the spec.
      Returns: True if the FormatOptions is valid, false otherwise.
    bool IsValidSymbol(ForgeTypeId symbolTypeId)
      Description: Checks whether a symbol is valid for the unit in this FormatOptions.
      @symbolTypeId: Identifier of the symbol to check.
      Returns: True if the symbol is valid, false otherwise.
    static bool IsValidSymbol(ForgeTypeId unitTypeId, ForgeTypeId symbolTypeId)
      Description: Checks whether a symbol is valid for a given unit.
      @unitTypeId: Identifier of the unit.
      @symbolTypeId: Identifier of the symbol to check.
      Returns: True if the symbol is valid, false otherwise.
    void SetSymbolTypeId(ForgeTypeId symbolTypeId)
      Description: Sets the symbol that should be displayed to indicate the unit quantifying the value.
      @symbolTypeId: The symbol identifier. An empty identifier string indicates no symbol.
    FormatOptions SetUnitTypeId(ForgeTypeId unitTypeId)
      Description: Sets the unit used to quantify values.
      @unitTypeId: The unit identifier.

--------------------------------------------------------------------------------


[ENUM] FormatStatus
Full Name: Autodesk.Revit.DB.FormatStatus

Description: An enumerated type indicating the formatting status of a range of characters in
Remarks: The character formatting includes BoldItalicUnderlineSuperScriptSubscriptAll Caps
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - All = 1
    - Mixed = 2


[CLASS] FormattedText
Full Name: Autodesk.Revit.DB.FormattedText

Description: FormattedText is used to create, edit and format text in a or to query the text and format properties of a
Remarks: An instance of FormattedText can be obtained from a (See TextNote.GetFormattedText()) or from a (See TextNode.GetFormattedText()) It is also possible to create a new instance of FormattedText and assign it to a (See TextNote.SetFormattedText()) This will result in a with text with the specified formatting applied Formatted text can be used to: Create formatted text for a new Edit, Find and Replace text in an existing Modify formatting of text in an existing Or query the text and formatting a or a Formatted text can be populated with plain text by using its constructor that takes a string, or by using the method. In addition, selected ranges of text can be added, removed, or replaced with the method by specifying a . Use the method to find the location of existing text. Formatted text can have up to 30,000 characters. All characters, except the linefeed character ('\n'), are allowed. This means that you should not use the 'Environment.NewLine' property, since that includes a linefeed character. Use the carriage return character ('\r') to terminate a paragraph. And use a vertical tab character ('\v') to create a new line without terminating the paragraph. Formatted text allows for individual characters to be formatted. The following formatting can be applied. Bold Italic Underline Superscript/Subscript All Caps Use ) , ) , ) , ) , ) , or ) to set the character formatting on a range of text. Use ) , ) , ) , ) , ) , or ) to get the character formatting of a range of text. Text can be broken up in paragraphs. Paragraphs are terminated by a carriage return character ('\r'). Each paragraph can be indented several levels deep. For each additional level the indentation increments by one tab size. The total indentation is the product of a tab size and the indent level. Use to set the level of indenting up to a maximum indent level that can be obtained from Use to find the indent level of a given range of text. Note that the tab size is determined by the object that will contain the FormattedText. In the case of a the tab size is a property of the returned from TextNote.TextNoteType. The tab size can be found by calling the with on the obtained from the In the case of a the tab size can be obtained from its TabSize property Formatted text can also be used to create numbered or bulleted paragraphs with the method. The following options are available: Paragraphs with a other than are considered to be 'list' paragraphs. Consecutive list paragraphs with the same indentation level are treated as part of the same list. A list ends when a list paragraph is followed by a paragraph that has or a list paragraph that has a lower indentation level, i.e. is indented less. (See ) Note that a list will continue uninterrupted after list paragraphs that have higher indentation level. These paragraphs form a 'sub-list' of the list they interrupt. Sub-lists can have their own sub-sub-lists. The nesting level is only limited by the maximum indent level. Using it is therefore possible to create multi-level lists. FormattedText will keep lists consistent. That means that list paragraphs will automatically get sequential numbers or letters. It also means that if the list type of one of the paragraphs in a list is changed then that change is propagated to all the paragraphs in that list. Note that this will not affect the list type of any nested sub-lists. Use a vertical tab character ('\v') to insert a line without a bullet or number. Since this does not end the paragraph this will allow the list to continue to the next paragraph.
Implements: IDisposable

  CONSTRUCTORS:
    new FormattedText(string plainText)
    new FormattedText()

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    TextRange AsTextRange()
      Description: Returns a object that represents the entire text.
      Returns: The object that represents the entire text.
    void Dispose()
    TextRange Find(string searchString, int startIndex, bool matchCase, bool matchWholeWord)
      Description: Returns a text range identifying the first occurrence of the given string within the text, starting from a given index.
      @searchString: The text to search for.
      @startIndex: The start index to search within the text.
      @matchCase: True if the case must match when searching the formatted text, false to search in a case-insensitive manner.
      @matchWholeWord: True if the match must be a whole word when searching the formatted text, false otherwise.
      Returns: The text range identified.
    FormatStatus GetAllCapsStatus()
      Description: Returns whether , or a of characters in the entire text are in all caps.
      Returns: The format status of all caps on characters .
    FormatStatus GetAllCapsStatus(TextRange textRange)
      Description: Returns whether , or a set of characters in a given text range are in all caps.
      @textRange: The given text range.
      Returns: The format status of all caps on characters .
    FormatStatus GetBoldStatus()
      Description: Returns whether , or a of characters in the entire text are bold.
      Returns: The format status of bold on characters .
    FormatStatus GetBoldStatus(TextRange textRange)
      Description: Returns whether , or a set of characters in a given text range are bold.
      @textRange: The given text range.
      Returns: The format status of bold on characters .
    int GetIndentLevel(TextRange textRange)
      Description: Returns the indent level of the paragraphs in the text range.
      @textRange: The given text range.
      Returns: The indentation level of the paragraphs in the range.
    FormatStatus GetItalicStatus()
      Description: Returns whether , or a of characters in the entire text are italic.
      Returns: The format status of italic on characters .
    FormatStatus GetItalicStatus(TextRange textRange)
      Description: Returns whether , or a set of characters in a given text range are italic.
      @textRange: The given text range.
      Returns: The format status of italic on characters .
    int GetListStartNumber(TextRange textRange)
      Description: Returns the list start number of the paragraphs in a given text range.
      @textRange: The given text range.
      Returns: The list start number of the text range.
    ListType GetListType(TextRange textRange)
      Description: Returns the of a paragraph.
      @textRange: The given text range.
      Returns: The of the paragraph.
    int GetMaximumIndentLevel()
      Description: Returns the maximum allowed indent level
    int GetMaximumListStartNumber()
      Description: Returns the maximum allowed list start number.
    int GetMinimumListStartNumber()
      Description: Returns the minumum allowed list start number.
    string GetPlainText(TextRange textRange)
      Description: Returns a substring of the text in a plain text form. The start and end of the substring is identified by a given .
      @textRange: The given .
      Returns: The substring of the text in a plain text form.
    string GetPlainText()
      Description: Returns the entire text in a plain text form.
      Returns: The entire text in a plain text form.
    FormatStatus GetSubscriptStatus()
      Description: Returns whether , or a of characters in the entire text are subscripted.
      Returns: The format status of subscript on characters .
    FormatStatus GetSubscriptStatus(TextRange textRange)
      Description: Returns whether , or a set of characters in a given text range are subscripted.
      @textRange: The given text range.
      Returns: The format status of subscript on characters .
    FormatStatus GetSuperscriptStatus()
      Description: Returns whether , or a of characters in the entire text are superscripted.
      Returns: The format status of superscript on characters .
    FormatStatus GetSuperscriptStatus(TextRange textRange)
      Description: Returns whether , or a set of characters in a given text range are superscripted.
      @textRange: The given text range.
      Returns: The format status of superscript on characters .
    FormatStatus GetUnderlineStatus()
      Description: Returns whether , or a of characters in the entire text are underlined.
      Returns: The format status of underline on characters .
    FormatStatus GetUnderlineStatus(TextRange textRange)
      Description: Returns whether , or a set of characters in a given text range are underlined.
      @textRange: The given text range.
      Returns: The format status of underline on characters .
    void SetAllCapsStatus(bool isAllCaps)
      Description: Sets the characters in the entire text to be in all caps or not.
      @isAllCaps: The desired all caps status of characters in the entire text. True to set all capped, false to set not all capped.
    void SetAllCapsStatus(TextRange textRange, bool isAllCaps)
      Description: Sets the characters in a given text range to be in all caps or not.
      @textRange: The given text range.
      @isAllCaps: The desired all caps status of characters in the given text range. True will render all characters in all caps. False will revert the characters back to their original mixed case.
    void SetBoldStatus(bool isBold)
      Description: Sets the characters in the entire text to be bold or not bold.
      @isBold: The desired bold status of characters in the entire text. True to set bold, false to set not bold.
    void SetBoldStatus(TextRange textRange, bool isBold)
      Description: Sets the characters in a given text range to be bold or not bold.
      @textRange: The given text range.
      @isBold: The desired bold status of characters in the given text range. True to set bold, false to set not bold.
    void SetIndentLevel(TextRange textRange, int level)
      Description: Sets the number of tab stops that the paragraph should be indented.
      @textRange: The given text range.
      @level: The level set on the paragraph.
    void SetItalicStatus(bool isItalic)
      Description: Sets the characters in the entire text to be italic or not italic.
      @isItalic: The desired italic status of characters in the entire text. True to set italic, false to set not italic.
    void SetItalicStatus(TextRange textRange, bool isItalic)
      Description: Sets the characters in a given text range to be italic or not italic.
      @textRange: The given text range.
      @isItalic: The desired italic status of characters in the given text range. True to set italic, false to set not italic.
    void SetListStartNumber(TextRange textRange, int value)
      Description: Sets the list start number on the paragraphs in a given text range.
      @textRange: The given text range.
      @value: The list start number to be set on the text range.
    void SetListType(TextRange textRange, ListType listType)
      Description: Sets the of a paragraph.
      @textRange: The given text range.
      @listType: The to set on the paragraph.
    void SetPlainText(TextRange textRange, string plainText)
      Description: Sets the text with the given text in a plain text form in a range.
      @textRange: The given text range.
      @plainText: The given text in a plain text form.
    void SetPlainText(string plainText)
      Description: Sets the entire text with the given text in a plain text form.
      @plainText: The given text in a plain text form.
    void SetSubscriptStatus(bool isSubscript)
      Description: Sets the characters in the entire text to be subscript or not subscript.
      @isSubscript: The desired subscript status of characters in the entire text. True to set subscript, false to set not subscript.
    void SetSubscriptStatus(TextRange textRange, bool isSubscript)
      Description: Sets the characters in a given text range to be subscript or not subscript.
      @textRange: The given text range.
      @isSubscript: The desired subscript status of characters in the given text range. True to set subscript, false to set not subscript.
    void SetSuperscriptStatus(bool isSuperscript)
      Description: Sets the characters in the entire text to be superscript or not superscript.
      @isSuperscript: The desired superscript status of characters in the entire text. True to set superscript, false to set not superscript.
    void SetSuperscriptStatus(TextRange textRange, bool isSuperscript)
      Description: Sets the characters in a given text range to be superscript or not superscript.
      @textRange: The given text range.
      @isSuperscript: The desired superscript status of characters in the given text range. True to set superscript, false to set not superscript.
    void SetUnderlineStatus(bool isUnderlined)
      Description: Sets the characters in the entire text to be underlined or not underlined.
      @isUnderlined: The desired underline status of characters in the entire text. True to set underlined, false to set not underlined.
    void SetUnderlineStatus(TextRange textRange, bool isUnderlined)
      Description: Sets the characters in a given text range to be underlined or not underlined.
      @textRange: The given text range.
      @isUnderlined: The desired underline status of characters in the given text range. True to set underlined, false to set not underlined.

--------------------------------------------------------------------------------


[CLASS] FormatValueOptions
Full Name: Autodesk.Revit.DB.FormatValueOptions

Description: Options for formatting numbers with units into strings.
Implements: IDisposable

  CONSTRUCTORS:
    new FormatValueOptions()

  PROPERTIES:
    bool AppendUnitSymbol { get; set; }
      Description: Indicates if a unit symbol should be appended regardless of the settings in the FormatOptions.
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


[CLASS] FormulaManager
Full Name: Autodesk.Revit.DB.FormulaManager

Description: A class to access and query information about formula engine in Revit models.
Remarks: Formula manager
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static string Evaluate(ElementId parameterId, Document document, string formula)
      Description: Evaluates value of the formula
    static IList<string> GetFunctions()
      Description: Gets list of function names supported by formula engine
    static IList<string> GetOperators()
      Description: Gets list of operator names supported by formula engine
    static string Validate(ElementId parameterId, Document document, string formula)
      Description: Validates the formuls

--------------------------------------------------------------------------------


[ABSTRACT CLASS] FormUtils
Full Name: Autodesk.Revit.DB.FormUtils

Description: Define Form utility functions

  METHODS:
    static bool CanBeDissolved(Document ADoc, ICollection<ElementId> elements)
      Description: Validates that input contains one or more form elements or geom combinations containing form elements.
      @ADoc: The document.
      @elements: A collection of elements.
      Returns: True if inputs contain one or more form elements. Non-form element inputs are ignored. False if none of the inputs are form elements or do not contain form elements.
    static ICollection<ElementId> DissolveForms(Document ADoc, ICollection<ElementId> elements)
      Description: Dissolves a collection of form elements into their defining elements.
      @ADoc: The document
      @elements: A collection of element IDs of Forms and GeomCombinations that contain Forms that will be dissolved.
      Returns: A collection of curve element ids from the profiles and paths of the dissolved forms.
    static ICollection<ElementId> DissolveForms(Document ADoc, ICollection<ElementId> elements, out ICollection<ElementId> ProfileOriginPointSet)

--------------------------------------------------------------------------------


[CLASS] Frame
Full Name: Autodesk.Revit.DB.Frame

Description: A Frame comprises three vectors at a base point in 3D space.
Remarks: A Frame consists of three vectors at a base point in 3D space. The vectors need not be orthogonal, have unit length, or even be linearly independent, although in practice Frames will usually have linearly independent vectors. Frames may be used to represent a coordinate frame of reference, a moving frame field on a curve, or for other purposes.
Implements: IDisposable

  CONSTRUCTORS:
    new Frame(XYZ origin, XYZ vec1, XYZ vec2, XYZ vec3)
    new Frame()

  PROPERTIES:
    XYZ BasisX { get; set; }
      Description: The first basis vector of the frame.
    XYZ BasisY { get; set; }
      Description: The second basis vector of the frame.
    XYZ BasisZ { get; set; }
      Description: The third basis vector of the frame.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Origin { get; set; }
      Description: The frame's base point.

  METHODS:
    static bool CanDefineRevitGeometry(Frame frameOfReference)
      Description: Tests whether the supplied Frame object may be used to define a Revit curve or surface. In order to satisfy the requirements the Frame must be orthonormal and its origin is expected to lie within the Revit design limits .
      @frameOfReference: Frame to be validated.
      Returns: True if this Frame may be used as a local frame of reference, false otherwise.
    void Dispose()
    bool IsOrthogonal()
      Description: Determines if this frame's basis vectors are orthogonal.
      Returns: True if this frame's basis vectors are orthogonal, false if not.
    bool IsOrthonormal()
      Description: Determines if this frame's basis vectors are orthonormal.
      Returns: True if this frame's basis vectors are orthonormal, false if not.
    bool IsRightHanded()
      Description: Determine if this frame's basis is right-handed.
      Returns: True if this frame's basis is right-handed, false if not.
    void Transform(Transform trf)
      Description: Applies the input transform to this frame.
      @trf: The transform to apply to the frame.

--------------------------------------------------------------------------------


[ENUM] FramingShapeClassification
Full Name: Autodesk.Revit.DB.FramingShapeClassification

Description: This enumeration is used to classify MEP Ancillary Framing shape.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Linear = 0
    - Circular = 1
    - Oval = 2
    - Other = 3


[CLASS] FreeFormElement
Full Name: Autodesk.Revit.DB.FreeFormElement

Description: A Free Form Element that contains non-parametric geometry created from an input solid outline.
Remarks: The element can participate in joins and void cuts with other combinable elements.
Inherits: GenericForm
Implements: IDisposable

  METHODS:
    bool CanOffsetFace(Face face)
      Description: Determines if the input face of the FreeFormElement can be offset.
      @face: The face to be checked.
      Returns: True if the face can be offset, false otherwise.
    static FreeFormElement Create(Document document, Solid geometry)
      Description: Creates a new FreeFormElement from a copy of the input geometry.
      @document: The document in which the element is to be created.
      @geometry: The input geometry.
      Returns: returns a new FreeFormElement
    void SetFaceOffset(Face face, double offset)
      Description: Offsets a planar face of the free form element a certain distance in the normal direction.
      @face: The face to offset.
      @offset: The magnitude of the offset. A positive value offsets out of the input solid. A negative value offsets into the solid shape.
    void UpdateSolidGeometry(Solid newGeometry)
      Description: Updates the geometry of the FreeForm element to the given shape preserving References to the existing geometry where possible (see remarks for rules).
      @newGeometry: The new geometry to set in the FreeForm element.

--------------------------------------------------------------------------------


[CLASS] GBXMLExportOptions
Full Name: Autodesk.Revit.DB.GBXMLExportOptions

Description: Green-Building XML Export options.
Implements: IDisposable

  CONSTRUCTORS:
    new GBXMLExportOptions(IList<ElementId> massZoneIds, IList<ElementId> massIds)
    new GBXMLExportOptions()

  PROPERTIES:
    string Encoding { get; }
      Description: The encoding options to go into the processing instruction for the exported gbXML file.
    bool ExportAnalyticalSystems { get; set; }
      Description: Indicates if the gbXML should contain analytical system elements (e.g., Water Loop, Air System, and Zone Equipment).
    ExportEnergyModelType ExportEnergyModelType { get; set; }
      Description: The energy model type from which gbXML will be exported.
    bool IsConceptual { get; }
      Description: Indicates if the exported gbXML is based on a conceptual energy analytical model from a conceptual mass model.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IList<ElementId> GetMassIds()
      Description: Gets a list of masses to use as shading surfaces in the exported gbXML--these masses must not have mass floors or mass zones so as not to end up with duplicate surface information in the gbXML output.
      Returns: The ids of the masses.
    IList<ElementId> GetMassZoneIds()
      Description: Gets a list of mass zones to analyze in the exported gbXML.
      Returns: The ids of the mass zones.

--------------------------------------------------------------------------------


[CLASS] GBXMLImportOptions
Full Name: Autodesk.Revit.DB.GBXMLImportOptions

Description: Import options for Green-Building XML format.
Remarks: Not used currently. Reserved for future use.

  CONSTRUCTORS:
    new GBXMLImportOptions()

--------------------------------------------------------------------------------


[CLASS] GenericForm
Full Name: Autodesk.Revit.DB.GenericForm

Description: Provides access to the Generic Form model in Autodesk Revit.
Remarks: The Generic Form object can be queried for a generic form for use in family modeling and massing. It is the base class of Sweep, Blend, Extrusion, Revolution.
Inherits: CombinableElement
Implements: IDisposable

  PROPERTIES:
    bool IsSolid { get; }
      Description: Identifies if the GenericForm is a solid or a void element.
    string Name { set; }
      Description: Get and Set the Name property
    Category Subcategory { get; set; }
      Description: The subcategory.
    bool Visible { get; }
      Description: The visibility of the GenericForm.

  METHODS:
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility for the generic form.
      Returns: A copy of visibility settings for the generic form.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility for the generic form.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] GenericImportOptions
Full Name: Autodesk.Revit.DB.GenericImportOptions

Description: Generic Import options.

  PROPERTIES:
    XYZ RefPoint { get; set; }
      Description: Reference point (in Revit) to which the image is going to be inserted.

--------------------------------------------------------------------------------


[CLASS] GeomCombination
Full Name: Autodesk.Revit.DB.GeomCombination

Description: An element created by Join and Cut operations applied to combinable elements in an Autodesk Revit family document.
Inherits: CombinableElement
Implements: IDisposable

  PROPERTIES:
    CombinableElementArray AllMembers { get; }
      Description: All elements that are joined in this geometry combination.

--------------------------------------------------------------------------------


[CLASS] GeomCombinationSet
Full Name: Autodesk.Revit.DB.GeomCombinationSet

Description: A set that contains GeomCombination objects.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new GeomCombinationSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of GeomCombinations that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item GeomCombination the set, rendering it empty.
    bool Contains(GeomCombination item)
      Description: Tests for the existence of an GeomCombination within the set.
      @item: The element to be searched for.
      Returns: The Contains method returns True if the GeomCombination is within the set, otherwise False.
    int Erase(GeomCombination item)
      Description: Removes a specified GeomCombination from the set.
      @item: The GeomCombination to be erased.
      Returns: The number of GeomCombinations that were erased from the set.
    GeomCombinationSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(GeomCombination item)
      Description: Insert the specified element into the set.
      @item: The GeomCombination to be inserted into the set.
      Returns: Returns whether the GeomCombination was inserted into the set.
    GeomCombinationSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] GeomCombinationSetIterator
Full Name: Autodesk.Revit.DB.GeomCombinationSetIterator

Description: An iterator to a GeomCombination set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new GeomCombinationSetIterator()

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


[ABSTRACT CLASS] GeometryCreationUtilities
Full Name: Autodesk.Revit.DB.GeometryCreationUtilities

Description: A utility that allows construction of basic solid shapes.
Remarks: The shapes created by these utilities are not a part of any Revit document, but can be used in conjunction with other geometric utilities from within API applications.

  METHODS:
    static Solid CreateBlendGeometry(CurveLoop firstLoop, CurveLoop secondLoop, ICollection<VertexPair> vertexPairs, SolidOptions solidOptions)
      Description: Creates a solid by blending two closed curve loops lying in non-coincident planes.
      @firstLoop: The first curve loop. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop may not contain just one closed curve - split such a loop into two or more curves beforehand.
      @secondLoop: The second curve loop, satisfying the same conditions as the first loop. The planes of the first and second loops must not be coincident, but they need not be parallel.
      @vertexPairs: This input specifies how the two profile loops should be connected. If null, the function chooses vertex connections that will result in a geometrically reasonable blend.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
    static Solid CreateBlendGeometry(CurveLoop firstLoop, CurveLoop secondLoop, ICollection<VertexPair> vertexPairs)
      Description: Creates a solid by blending two closed curve loops lying in non-coincident planes.
      @firstLoop: The first curve loop. The loop must be a closed planar loop without intersections or degeneracies. No orientation conditions are imposed. The loop may not contain just one closed curve - split such a loop into two or more curves beforehand.
      @secondLoop: The second curve loop, satisfying the same conditions as the first loop. The planes of the first and second loops must not be coincident, but they need not be parallel.
      @vertexPairs: This input specifies how the two profile loops should be connected. If null, the function chooses vertex connections that will result in a geometrically reasonable blend.
      Returns: The requested solid.
    static Solid CreateExtrusionGeometry(IList<CurveLoop> profileLoops, XYZ extrusionDir, double extrusionDist, SolidOptions solidOptions)
      Description: Creates a solid by linearly extruding one or more closed coplanar curve loops.
      @profileLoops: The profile loops to be extruded. The loops must be closed, coplanar, and without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
      @extrusionDir: The direction in which to extrude the profile loops. This vector must be non-zero and transverse (i.e., not parallel) to the plane of the profile loops. Its length is irrelevant; only its direction is used.
      @extrusionDist: The positive distance by which the loops are to be extruded in the direction of the input extrusionDir.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
    static Solid CreateExtrusionGeometry(IList<CurveLoop> profileLoops, XYZ extrusionDir, double extrusionDist)
      Description: Creates a solid by linearly extruding one or more closed coplanar curve loops.
      @profileLoops: The profile loops to be extruded. The loops must be closed, coplanar, and without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions.
      @extrusionDir: The direction in which to extrude the profile loops. This vector must be non-zero and transverse (i.e., not parallel) to the plane of the profile loops. Its length is irrelevant; only its direction is used.
      @extrusionDist: The positive distance by which the loops are to be extruded in the direction of the input extrusionDir.
      Returns: The requested solid.
    static Solid CreateFixedReferenceSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops, XYZ fixedReferenceDirection, SolidOptions solidOptions)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path while keeping the profile plane oriented so that a line in the plane that is initially perpendicular to a given fixed direction remains perpendicular as the profile is swept along the path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar. With the exception of path curves that lie in a plane parallel to %fixedReferenceDirection%, the curve's tangent should be nowhere parallel to %fixedReferenceDirection%. If the sweep path has corners, the solid segments that meet at a corner may not meet smoothly.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops; this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above. The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops). The curve loops must be without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @fixedReferenceDirection: A unit vector specifying the fixed direction used to control how the profile plane is swept along the path; see the description and remarks above. The profile CurveLoops do not satisfy the input requirements.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
    static Solid CreateFixedReferenceSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops, XYZ fixedReferenceDirection)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path while keeping the profile plane oriented so that a line in the plane that is initially perpendicular to a given fixed direction remains perpendicular as the profile is swept along the path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar. With the exception of path curves that lie in a plane parallel to %fixedReferenceDirection%, the curve's tangent should be nowhere parallel to %fixedReferenceDirection%. If the sweep path has corners, the solid segments that meet at a corner may not meet smoothly.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops; this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above. The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops). The curve loops must be without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @fixedReferenceDirection: A unit vector specifying the fixed direction used to control how the profile plane is swept along the path; see the description and remarks above.
      Returns: The requested solid.
    static Solid CreateLoftGeometry(IList<CurveLoop> profileLoops, SolidOptions solidOptions)
      Description: Creates a solid or open shell geometry by lofting between a sequence of curve loops.
      @profileLoops: The array of curve loops, where the order of the array determines the lofting sequence used.
      @solidOptions: The optional information to control the properties of the solid or open shell.
      Returns: The requested solid or open shell.
    static Solid CreateRevolvedGeometry(Frame coordinateFrame, IList<CurveLoop> profileLoops, double startAngle, double endAngle, SolidOptions solidOptions)
      Description: Creates a solid of revolution by revolving a set of closed curve loops around an axis by a specified angle.
      @coordinateFrame: A right-handed orthonormal frame of vectors. The frame's z-vector is the axis of revolution. The start and end angle inputs refer to this frame.
      @profileLoops: The profile loops to be revolved. No conditions are imposed on the orientations of the loops. This function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the xz coordinate plane of the input coordinate frame. The curve loop(s) must be closed and must define a single planar domain (one outer loop and, optionally, one or more inner loops). The curve loops must be without intersections, self-intersections, or degeneracies. The loops must lie on the "right" side of the z axis (where x >= 0). No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @startAngle: The start angle for the revolution, in radians, measured counter-clockwise from the coordinate frame's x-axis as viewed looking down the frame's z-axis.
      @endAngle: The end angle for the revolution, using the same conventions as the start angle. The end angle may be less than (but not equal to) the start angle. The total angle of revolution, equal to the absolute value of (endAngle Ã¢â‚¬â€œ startAngle), must be at most 2*PI.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid. Note that if less than a full revolution is used, planar end faces will be added as part of the solid.
    static Solid CreateRevolvedGeometry(Frame coordinateFrame, IList<CurveLoop> profileLoops, double startAngle, double endAngle)
      Description: Creates a solid of revolution by revolving a set of closed curve loops around an axis by a specified angle.
      @coordinateFrame: A right-handed orthonormal frame of vectors. The frame's z-vector is the axis of revolution. The start and end angle inputs refer to this frame.
      @profileLoops: The profile loops to be revolved. No conditions are imposed on the orientations of the loops. This function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the xz coordinate plane of the input coordinate frame. The curve loop(s) must be closed and must define a single planar domain (one outer loop and, optionally, one or more inner loops). The curve loops must be without intersections, self-intersections, or degeneracies. The loops must lie on the "right" side of the z axis (where x >= 0). No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @startAngle: The start angle for the revolution, in radians, measured counter-clockwise from the coordinate frame's x-axis as viewed looking down the frame's z-axis.
      @endAngle: The end angle for the revolution, using the same conventions as the start angle. The end angle may be less than (but not equal to) the start angle. The total angle of revolution, equal to the absolute value of (endAngle Ã¢â‚¬â€œ startAngle), must be at most 2*PI.
      Returns: The requested solid. Note that if less than a full revolution is used, planar end faces will be added as part of the solid.
    static Solid CreateSweptBlendGeometry(Curve pathCurve, IList<double> pathParams, IList<CurveLoop> profileLoops, IList<ICollection<VertexPair>> vertexPairs, SolidOptions solidOptions)
      Description: Creates a solid by simultaneously sweeping and blending two or more closed planar curve loops along a single curve.
      @pathCurve: The sweep path, consisting of a single bounded, open curve.
      @pathParams: An increasing sequence of parameters along the path curve (lying within the curve's bounds). These parameters specify the locations of the planes orthogonal to the path that contain the profile loops. This array must have the same size as the input array "profileLoops".
      @profileLoops: Closed, planar curve loops arrayed along the path. No loop may contain just one closed curve - split such loops into two or more curves beforehand. The solid will have these profiles as cross-sections at the points specified by the input pathParams. The solid will blend smoothly between the profiles. This array must have the same size as the input array "pathParams", and each profile loop must lie in the plane orthogonal to the path at the point specified by the corresponding entry in the input array "pathParams". Each profile loop must define a single planar domain and must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.
      @vertexPairs: This input specifies how adjacent profile loops should be connected. It must contain one less element than the "profileLoops" input, and entry vertexPairs[idx] specifies how profileLoops[idx] and profileLoops[idx+1] should be connected (indexing starts at 0).
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
    static Solid CreateSweptBlendGeometry(Curve pathCurve, IList<double> pathParams, IList<CurveLoop> profileLoops, IList<ICollection<VertexPair>> vertexPairs)
      Description: Creates a solid by simultaneously sweeping and blending two or more closed planar curve loops along a single curve.
      @pathCurve: The sweep path, consisting of a single bounded, open curve.
      @pathParams: An increasing sequence of parameters along the path curve (lying within the curve's bounds). These parameters specify the locations of the planes orthogonal to the path that contain the profile loops. This array must have the same size as the input array "profileLoops".
      @profileLoops: Closed, planar curve loops arrayed along the path. No loop may contain just one closed curve - split such loops into two or more curves beforehand. The solid will have these profiles as cross-sections at the points specified by the input pathParams. The solid will blend smoothly between the profiles. This array must have the same size as the input array "pathParams", and each profile loop must lie in the plane orthogonal to the path at the point specified by the corresponding entry in the input array "pathParams". Each profile loop must define a single planar domain and must be free of intersections and degeneracies. No orientation conditions on the loops are imposed.
      @vertexPairs: This input specifies how adjacent profile loops should be connected. It must contain one less element than the "profileLoops" input, and entry vertexPairs[idx] specifies how profileLoops[idx] and profileLoops[idx+1] should be connected (indexing starts at 0).
      Returns: The requested solid.
    static Solid CreateSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops, SolidOptions solidOptions)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above. The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops) The curve loops must be without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      @solidOptions: The optional information to control the properties of the Solid.
      Returns: The requested solid.
    static Solid CreateSweptGeometry(CurveLoop sweepPath, int pathAttachmentCrvIdx, double pathAttachmentParam, IList<CurveLoop> profileLoops)
      Description: Creates a solid by sweeping one or more closed coplanar curve loops along a path.
      @sweepPath: The sweep path, consisting of a set of contiguous curves. The path may be open or closed, but should not otherwise have any self-intersections. The path may be planar or non-planar.
      @pathAttachmentCrvIdx: The index of the curve in the sweep path where the profile loops are situated. Indexing starts at 0. Together with pathAttachmentParam, this specifies the profile's attachment point.
      @pathAttachmentParam: Parameter of the path curve specified by pathAttachmentCrvIdx. The profile curves must lie in the plane orthogonal to the path at this attachment point.
      @profileLoops: The curve loops defining the planar domain to be swept along the path. No conditions are imposed on the orientations of the loops: this function will use copies of the input loops that have been oriented as necessary to conform to Revit's orientation conventions. Restrictions: The loops must lie in the plane orthogonal to the path at the attachment point as defined above. The curve loop(s) must be closed and should define a single planar domain (one outer loop and, optionally, one or more inner loops) The curve loops must be without intersections, self-intersections, or degeneracies. No loop may contain just one closed curve - split such loops into two or more curves beforehand.
      Returns: The requested solid.

--------------------------------------------------------------------------------


[CLASS] GeometryElement
Full Name: Autodesk.Revit.DB.GeometryElement

Description: Geometric representation of an element.
Remarks: This class contains geometric primitives that are generated from the parametric description of the element. The member geometric primitives can be obtained directly from this object using the capabilities of IEnumerable.
Inherits: GeometryObject
Implements: IDisposable, IEnumerable`1, IEnumerable

  PROPERTIES:
    Material MaterialElement { get; }
      Description: Element describing the material from which this element is composed.

  METHODS:
    BoundingBoxXYZ GetBoundingBox()
      Description: Retrieves a box that encloses the geometry element.
      Returns: The bounding box.
    IEnumerator<GeometryObject> GetEnumerator()
      Description: Returns an enumerator that iterates through the collection.
      Returns: An IEnumerator(GeometryObject) object that can be used to iterate through the collection.
    GeometryElement GetTransformed(Transform transform)
      Description: Returns a transformed copy of the geometry in this element.
      @transform: The transformation to apply to the geometry.

--------------------------------------------------------------------------------


[CLASS] GeometryInstance
Full Name: Autodesk.Revit.DB.GeometryInstance

Description: An instance of another element (symbol), specially positioned by this element.
Remarks: A GeometryInstance represents a set of geometry stored by Revit in a default configuration, and then transformed into the proper location as a result of the properties of the element. The most common situation where GeometryInstances are encountered is in Family instances. Revit uses GeometryInstances to allow it to store a single copy of the geometry for a given family and reuse it in multiple instances. Note that not all Family instances will include GeometryInstances. When Revit needs to make a unique copy of the family geometry for a given instance (because of the effect of local joins, intersections, and other factors related to the instance placement) no GeometryInstance will be encountered; instead the Solid geometry will be found at the top level of the hierarchy. Another example of GeometryInstance usage is in Rebar element visible in fine 3D Views. Here, each segement of a rebar is a GeometryInstance. In this case the Symbol Element is contaning all the geometries that are instanced. A GeometryInstance offers the ability to read its geometry through the GetSymbolGeometry() and GetInstanceGeometry() methods. These methods return another Autodesk.Revit.DB.GeometryElement which can be parsed just like the first level return.
Inherits: GeometryObject
Implements: IDisposable

  PROPERTIES:
    GeometryElement SymbolGeometry { get; }
      Description: The geometric representation of the symbol which generates this instance.
    Transform Transform { get; }
      Description: The affine transformation from the local coordinate space of the symbol into the coordinate space of the instance.

  METHODS:
    Document GetDocument()
      Description: Gets the document that contains the symbol of this instance.
      Returns: Returns the document that contains the symbol of this instance.
    GeometryElement GetInstanceGeometry(Transform transform)
      Description: Computes a transformation of the geometric representation of the instance.
      @transform: The transformation to apply to the geometry.
      Returns: An element which contains the computed geometry for the transformed instance.
    GeometryElement GetInstanceGeometry()
      Description: Computes the geometric representation of the instance.
      Returns: An element which contains the computed geometry for the instance.
    GeometryElement GetSymbolGeometry(Transform transform)
      Description: Computes a transformation of the geometric representation of the symbol which generates this instance.
      @transform: The transformation to apply to the geometry.
      Returns: An element which contains the computed geometry for the transformed symbol.
    GeometryElement GetSymbolGeometry()
      Description: Computes the geometric representation of the symbol which generates this instance.
      Returns: An element which contains the computed geometry for the symbol.
    SymbolGeometryId GetSymbolGeometryId()
      Description: Gets the SymbolGeometryId that contains data about the symbol of this instance.
      Returns: Returns the SymbolGeometryId that contains data about the symbol of this instance.

--------------------------------------------------------------------------------


[CLASS] GeometryObject
Full Name: Autodesk.Revit.DB.GeometryObject

Description: The common base class for all geometric primitives.
Inherits: APIObject
Implements: IDisposable

  PROPERTIES:
    ElementId GraphicsStyleId { get; }
      Description: The ElementId of the GeometryObject's GraphicsStyle
    int Id { get; }
      Description: A unique integer identifying the GeometryObject in its associated non view-specific GeometryElement.
    bool IsElementGeometry { get; }
      Description: Indicates whether this geometry is obtained directly from an Element.
    Visibility Visibility { get; set; }
      Description: The visibility.

  METHODS:
    bool Equals(object obj)
      Description: Determines whether the specified is equal to the current .
      @obj: Another object.
    int GetHashCode()
      Description: Gets the integer value of the geometry object as hash code

--------------------------------------------------------------------------------


[CLASS] GlobalParameter
Full Name: Autodesk.Revit.DB.GlobalParameter

Description: This class represents a GlobalParameter element in Revit.
Remarks: Global parameters can be used to drive values of dimensions or other elements' parameters. Also, a global parameter can be driven by a selected dimension, the value of which then determines the value of the global parameter. Such parameters can further be used to drive values of other elements' parameters. See also the class for methods that operate upon global parameters of a document, such as getting all defined global parameters and testing whether a global parameter of certain name already exists or not. Reporting vs. Non-Reporting parametersThere are several ways global parameters can be categorized, but probably the most significant categorization stems from the property which divides global parameters into two groups - Reporting and Non-Reporting. The significance of reporting parameters lays in the fact that their values are driven by the dimension that has been labeled by a reporting parameter. It means that the value of a reporting parameter reflects the value of a dimension (length or angle) and gets updated anytime the dimension changes. Non-Reporting parameters behave in the opposite manner - they drive value of dimensions that have been labeled by them, which results in controlling the model's geometry through global parameters' values.Reporting parameters are limited in several ways. They can be only of Length or Angle type, a requirement due to the fact that a dimension must be able to drive the value. For the same reason reporting parameters may not have formulas.Non-Reporting parameters, on the other way, can be of almost any type (Length, Integer, Area, etc.) with the exception of ElementId type. Also, Non-Reporting parameters may have assigned formulas in which other global parameters may be used as arguments. This way one global parameter's value can be derived from other parameter (or parameters), and the other parameter can be either reporting or non-reporting.Creating Global ParametersGlobal parameters get created via the static method . It is important to note that each new parameter must have a name that is unique within the document. Parameters are created as non-reporting initially, but programmers are free to modify the property once a global parameter is created and is of an eligible type. The programmer can call the when in doubt whether parameters of a certain data type can be made reporting. Note, that a parameter may not be made reporting after more than one dimension has been labeled by it. It is because reporting parameter can label (and be driven) by one dimension only.An alternative way of making a parameter reporting is via the method which labels one dimension by a global parameter and also makes the parameter reporting if it is not reporting yet.Other important properties of global parameters are and , which are mutually exclusive - a parameter that has a formula assigned cannot be driven by a dimension (nor can be reporting) and vice versa. Global Parameters with formulasLike with family parameters, formulas may be assigned to non-reporting global parameters using the method (paired with to query the current formula.) Formulas may include all standard arithmetic operations and logical operations (as functions and, or, not.) Input to logical operations must be Boolean values (parameters of YesNo type). Consequently, arithmetic operations can be applied to numeric values only. While there are no operations supported for string (text) arguments, strings can be used as results of a logical If operation. Depending on their type (and units), parameters of different value types can be combined. However, unit-less values such as Integer and Number (double) may only be combined with each other. Since formulas can get quite complicated, the method is available for the programmer to ensure a formula is valid in order to avoid potential exception due to applying an invalid formula.Labeling dimensionsProbably the most notable feature of global parameters is their ability to "Label" dimensions, a process that establishes dependency of a dimension on a global parameter (or vice versa, depending on the reporting status.) One parameter can label any number of dimensions as long as the parameter is non-reporting. If the parameter labels a multi-segment dimension, values of all segments of this dimension will be equal to the parameter's value. As mentioned above, reporting parameter can label one dimension only, and this dimension can have only one segment. Methods and properties related to labeling include: , , and . Also in this set is the method which indicates whether or not a particular dimension can be labeled. Presently, only single linear dimensions and angles are permitted.Elements affected by a Global ParameterGlobal parameters can be associated with other global parameters as well as regular family instance parameters (which may report global parameters as their values via the assignment formula.) There are two methods available to find relations among parameters: and . The former returns all other global parameters that refer to a particular global parameter in their respective formulas. The other method returns a set of all elements of which some parameters are controlled by the global parameter. These two methods together with the can help the programmer in figuring out how model elements relate to each other via global parameters.Methods for maintaining associations between element properties and global parameters can be found in the class.Getting and setting the value of a Global ParameterAll global parameters, formula-driven, dimension-driven, or independent, have values. A value can be obtained by calling the method. The object returned by that method is an instance of one of the classes derived from class. The concrete instance is determined by the type of the global parameter (specified upon creation.) Parameters that are neither formula-driven nor dimension-driven (reporting) can have a value assigned. The method to use is and it accepts the same type of that is returned by SetValue. However, the type can also be deduced easily: Text parameters accept only . Integer and YesNo parameters accept only . All other parameters accept only .
Inherits: ParameterElement
Implements: IDisposable

  PROPERTIES:
    bool IsDrivenByDimension { get; }
      Description: Indicates whether this parameter is driven by a dimension or not.
    bool IsDrivenByFormula { get; }
      Description: Indicates whether this parameter is driven by a formula or not.
    bool IsReporting { get; set; }
      Description: Indicates whether this is a reporting global parameter or not.

  METHODS:
    bool CanChangeReporting()
      Description: Tests whether the global parameter permits a change of its current value of the IsReporting attribute.
      Returns: Returns True if the change is allowed; False otherwise.
    bool CanLabelDimension(ElementId dimensionId)
      Description: Tests whether a dimension can be labeled by the global parameter.
      @dimensionId: Id of a dimension element.
      Returns: True of the input dimension can be labeled by this global parameter; False oterwise.
    static GlobalParameter Create(Document document, string name, ForgeTypeId specTypeId)
      Description: Creates a new Global Parameter in the given document.
      @document: Document in which the new parameter is to be created
      @name: The name of the new parameter. It must be unique in the document
      @specTypeId: Identifier of the spec describing the parameter's data type.
      Returns: An instance of the new global parameter
    ISet<ElementId> GetAffectedElements()
      Description: Returns all elements of which properties are driven by this global parameter.
      Returns: Collection of Element Ids.
    ISet<ElementId> GetAffectedGlobalParameters()
      Description: Returns all other global parameters which refer to this global parameter in their formulas.
      Returns: Collection of Element Ids.
    string GetFormula()
      Description: Returns the parameter's expression in form of a string.
      Returns: The string representing the expression assigned to the parameter.
    ISet<ElementId> GetLabeledDimensions()
      Description: Returns all dimension elements that are currently labeled by this global parameter.
      Returns: Collection of Element Ids.
    string GetLabelName()
      Description: Returns the name of this parameter's label, which is used to label dimension elements.
      Returns: The name of the parameter's label.
    ParameterValue GetValue()
      Description: Obtains the curent value of the global parameter.
      Returns: An instance of one of the classes derived from the ParameterValue base class.
    bool HasValidTypeForReporting()
      Description: Tests that the global parameter has data of a type that supports reporting.
      Returns: True if the parameter has data of a type that supports reporting; False otherwise.
    bool IsValidFormula(string expression)
      Description: Tests that the given expression is a valid as formula for this parameter.
    void LabelDimension(ElementId dimensionId)
      Description: Labels a dimension with this global parameter.
      @dimensionId: Id of a dimension element.
    void SetDrivingDimension(ElementId dimensionId)
      Description: Set a dimension to drive the value of this parameter.
      @dimensionId: Id of a dimension element.
    void SetFormula(string expression)
      Description: Sets a formula expression for this parameter.
      @expression: Valid formula string.
    void SetValue(ParameterValue value)
      Description: Sets a new value of the global parameter.
      @value: An instance of one of the value classes derived from ParameterValue.
    void UnlabelDimension(ElementId dimensionId)
      Description: Unlabels a dimension that is currently labeled by this global parameter.
      @dimensionId: Id of a dimension element.

--------------------------------------------------------------------------------


[CLASS] GlobalParametersManager
Full Name: Autodesk.Revit.DB.GlobalParametersManager

Description: A class to access and query information about global parameters in Revit models.
Remarks: This class provides access to general information and data of Global Parameter elements in a particular model. First of all, it is important to know that global parameters can be had in main project document; there are not supported in family documents. Availability of global parameters in a document can be tested by calling method.Global Parameter in a document can be obtained by calling either or . The former returns a set of all global parameters in the document, while the latter returns just the requested one, providing it exists.Each global parameters must be created with a valid name that is unique in the scope of the document. To test whether a particular name is unique, programmer can use the method.More details about creating and manipulating global parameters can be found in the description of the class.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static bool AreGlobalParametersAllowed(Document document)
      Description: Tests whether global parameters are allowed in the given document.
      @document: A revit document of interest.
    void Dispose()
    static ElementId FindByName(Document document, string name)
      Description: Finds whether a global parameter with the given name exists in the input document.
      @document: The document expected to contain the global parameter.
      @name: Name of the global parameter
      Returns: ElementId of the parameter element, or InvalidElementId if it was not found.
    static ISet<ElementId> GetAllGlobalParameters(Document document)
      Description: Returns all global parameters available in the given document.
      @document: The document containing the global parameters
      Returns: A collection of Element Ids of global parameter elements.
    static IList<ElementId> GetGlobalParametersOrdered(Document document)
      Description: Returns all global paramters in an ordered array.
      @document: Document containing the requested global parameters
      Returns: An array of Element Ids of all Global Parameters in the document.
    static bool IsUniqueName(Document document, string name)
      Description: Tests whether a name is unique among existing global parameters of a given document.
      @document: Document in which a new parameter is to be added.
      @name: A name of a parameter being added.
      Returns: True if the given %name% does not exist yet among existing global parameters nof the document; False otherwise.
    static bool IsValidGlobalParameter(Document document, ElementId parameterId)
      Description: Tests whether an ElementId is of a global parameter in the given document.
      @document: The document containing the global parameter.
      @parameterId: Id of a global parameter
      Returns: Returns True if the Id is of a valid global parameter; False otherwise.
    static bool MoveParameterDownOrder(Document document, ElementId parameterId)
      Description: Moves given paramerer Down in the current order.
      @document: Document containing the give global parameter
      @parameterId: The parameter to move Down
      Returns: Indicates whether the parameter could be moved Down in order or not.
    static bool MoveParameterUpOrder(Document document, ElementId parameterId)
      Description: Moves given paramerer Up in the current order.
      @document: Document containing the give global parameter
      @parameterId: The parameter to move up
      Returns: Indicates whether the parameter could be moved Up in order or not.
    static void SortParameters(Document document, ParametersOrder order)
      Description: Sorts global parameters in the desired order.
      @document: Document containing the global parameters to be sorted
      @order: Desired sorting order

--------------------------------------------------------------------------------


[CLASS] GradientBackgroundSettings
Full Name: Autodesk.Revit.DB.GradientBackgroundSettings

Description: Represents the view gradient background settings.
Remarks: The colors of the background are interpolated for the pixels corresponding to the sky - from the "sky color" (top) to the "horizon color" (bottom). The ground is represented with a solid color ("ground color").
Inherits: BackgroundSettings
Implements: IDisposable

  PROPERTIES:
    Color GroundColor { get; set; }
      Description: The color of the ground.
    Color HorizonColor { get; set; }
      Description: The color of the horizon.
    Color SkyColor { get; set; }
      Description: The color of the top of the sky.

--------------------------------------------------------------------------------


[CLASS] GraphicsStyle
Full Name: Autodesk.Revit.DB.GraphicsStyle

Description: The graphics style instance in Autodesk Revit document.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    Category GraphicsStyleCategory { get; }
      Description: The graphics style category.
    GraphicsStyleType GraphicsStyleType { get; }
      Description: The graphics style type.

--------------------------------------------------------------------------------


[ENUM] GraphicsStyleType
Full Name: Autodesk.Revit.DB.GraphicsStyleType

Description: Describes the type of graphics style.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Projection = 1
    - Cut = 2


[CLASS] Grid
Full Name: Autodesk.Revit.DB.Grid

Description: Represents a single grid line within Autodesk Revit.
Remarks: A Grid is a DatumPlane, so it is actually a three dimensional surface. It can be either a plane parallel to the project z-axis, or else a cylinder whose axis is parallel to the project z-xis.
Inherits: DatumPlane
Implements: IDisposable

  PROPERTIES:
    Curve Curve { get; }
      Description: Retrieves an object that represents the geometry of the grid line.
    bool IsCurved { get; }
      Description: Identifies if the grid line is curved or straight.

  METHODS:
    static Grid Create(Document document, Arc arc)
      Description: Creates a new radial grid line.
      @document: The document in which the new instance is created.
      @arc: An arc object that represents the location of the new grid line.
      Returns: The newly created grid line.
    static Grid Create(Document document, Line line)
      Description: Creates a new grid line.
      @document: The document in which the new instance is created.
      @line: A line which represents the location of the grid line.
      Returns: The newly created grid line.
    Outline GetExtents()
      Description: Gets the extents of the grid in the model.
      Returns: The extents are the 3D bounding box surrounding the grid. The Z coordinates of the box are used by Revit to determine if the grid should be displayed in a corresponding view plan (if the grid is linear). The extents are not used for arc grids.
    void SetVerticalExtents(double bottom, double top)
      Description: Adjusts the grid to extend through only the vertical range between bottom and top.
      @bottom: The bottom range of the grid extents. It must be a valid number and below the top range.
      @top: The top range of the grid extents. It must be a valid number and above the bottom range.

--------------------------------------------------------------------------------


[STRUCT] GridNode
Full Name: Autodesk.Revit.DB.GridNode

Description: A structure that represents a particular location in (U,V) from a grid.

  CONSTRUCTORS:
    new GridNode(int uIndex, int vIndex)

  PROPERTIES:
    int UIndex { get; set; }
      Description: The node's index along the U axis.
    int VIndex { get; set; }
      Description: The node's index along the V axis.

--------------------------------------------------------------------------------


[ENUM] GridNodeLocation
Full Name: Autodesk.Revit.DB.GridNodeLocation

Description: Location of a grid node relative to the face boundary. See .
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Interior = 0
    - Boundary = 1
    - Exterior = 2


[ENUM] GridSegmentDirection
Full Name: Autodesk.Revit.DB.GridSegmentDirection

Description: Specify one of the four adjacent segments to a GridNode. See .
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - PositiveU = 0
    - NegativeU = 1
    - PositiveV = 2
    - NegativeV = 3


[CLASS] GridType
Full Name: Autodesk.Revit.DB.GridType

Description: An object that represents a grid type.
Inherits: LineAndTextAttrSymbol
Implements: IDisposable

--------------------------------------------------------------------------------


[CLASS] Group
Full Name: Autodesk.Revit.DB.Group

Description: An element representing a single instance of a group of elements that may be placed many times in a project or family.
Remarks: Grouping elements is useful when you need to create entities that represent repeating layouts or are common to many building projects, such as hotel rooms, apartments, or repeating floors.
Inherits: Element
Implements: IDisposable

  PROPERTIES:
    ElementId AttachedParentId { get; }
      Description: Indicates the Id of the parent group this group is attached to.
    GroupType GroupType { get; set; }
      Description: Get or set the type of the group.
    bool IsAttached { get; }
      Description: Indicates wether or not this group is attached to a parent group.
    Location Location { get; }
      Description: This property is used to find the physical location of a group within project.

  METHODS:
    ISet<ElementId> GetAvailableAttachedDetailGroupTypeIds()
      Description: Returns the attached detail groups available for this group type.
      Returns: Returns the collection of attached detail group Ids that match this group's type.
    IList<ElementId> GetMemberIds()
      Description: Retrieves all the member ElementIds of the group.
      Returns: An ordered list of the members within the group. The order of this list can be used to match members between other instances of the group.
    ISet<ElementId> GetShownAttachedDetailGroupTypeIds(View view)
      Description: Returns the attached detail groups which have displayed instances for this group type in the input view.
      @view: The view in which the attached detail groups are displayed.
      Returns: The collection of attached detail group Ids that match this group's type.
    void HideAllAttachedDetailGroups(View view)
      Description: Hides all the available attached detail groups for this element group type that are compatible with the input view type.
      @view: The view that the attached detail groups must be compatible with.
    void HideAttachedDetailGroups(View view, ElementId detailGroupTypeId)
      Description: Hides the element group's attached detail groups of the input group type that are compatible with the input view.
      @view: The view that the attached detail groups must be compatible with.
      @detailGroupTypeId: Only attached detail groups of this type will be hidden.
    bool IsCompatibleAttachedDetailGroupType(View view, ElementId detailGroupTypeId)
      Description: Checks if the orientation of the input attached detail group matches the input view's orientation.
      @view: The view that the input attached detail group must be compatible with.
      @detailGroupTypeId: The attached detail group that will be checked for compatibility with the input view.
      Returns: Returns true if the input attached detail group is compatible with the input view and false otherwise.
    void ShowAllAttachedDetailGroups(View view)
      Description: Shows all the available attached detail groups for this element group type that are compatible with the input view type.
      @view: The view that the attached detail groups must be compatible with.
    void ShowAttachedDetailGroups(View view, ElementId detailGroupTypeId)
      Description: Shows the element group's attached detail groups of the input group type that are compatible with the input view.
      @view: The view that the attached detail groups must be compatible with.
      @detailGroupTypeId: Only attached detail groups of this type will be shown.
    ICollection<ElementId> UngroupMembers()
      Description: Ungroups the group.
      Returns: If successful, the ids of the members of group are returned.

--------------------------------------------------------------------------------


[CLASS] GroupLoadOptions
Full Name: Autodesk.Revit.DB.GroupLoadOptions

Description: A class containing options for loading a group from a file.
Implements: IDisposable

  CONSTRUCTORS:
    new GroupLoadOptions()

  PROPERTIES:
    bool IncludeAttachedDetails { get; set; }
      Description: True if attached detail groups should be included, false otherwise. The default value is .
    bool IncludeGrids { get; set; }
      Description: True if grids should be brought in from the input file, false otherwise. The default value is .
    bool IncludeLevels { get; set; }
      Description: True if levels should be brought in from the input file, false otherwise. The default value is .
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ReplaceDuplicatedGroups { get; set; }
      Description: If there are groups with the same names in source and destination documents set this property to to replace existing groups, otherwise the operation will be canceled. The default value is .

  METHODS:
    void Dispose()
    IDuplicateTypeNamesHandler GetDuplicateTypeNamesHandler()
      Description: Returns current duplicate type names handler or if none is set.
    void SetDuplicateTypeNamesHandler(IDuplicateTypeNamesHandler handler)
      Description: Sets a custom duplicate type names handler. If this value is not set, the default handler is used. By default, Revit displays a modal dialog with options to either copy new types only, or cancel the operation.
      @handler: The duplicate type names handler.

--------------------------------------------------------------------------------


[CLASS] GroupNode
Full Name: Autodesk.Revit.DB.GroupNode

Description: A node that represents set of individual elements grouped together in some form, such as an instance of a family or linked Revit file, or an instance of a part of symbol's geometry.
Inherits: RenderNode
Implements: IDisposable

  METHODS:
    Transform GetTransform()
      Description: A transformation matrix associated with the node.

--------------------------------------------------------------------------------


[CLASS] GroupSet
Full Name: Autodesk.Revit.DB.GroupSet

Description: An set that contains groups.
Inherits: APIObject
Implements: IDisposable, IEnumerable

  CONSTRUCTORS:
    new GroupSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of groups that are in the set.

  METHODS:
    void Clear()
      Description: Removes every group from the set, rendering it empty.
    bool Contains(Group item)
      Description: Tests for the existence of a group within the set.
      @item: The group to be searched for.
      Returns: The Contains method returns True if the group is within the set, otherwise False.
    int Erase(Group item)
      Description: Removes a specified group from the set.
      @item: The group to be erased.
      Returns: The number of groups that were erased from the set.
    GroupSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Group item)
      Description: Insert the specified group into the set.
      @item: The group to be inserted into the set.
      Returns: Returns whether the group was inserted into the set.
    GroupSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] GroupSetIterator
Full Name: Autodesk.Revit.DB.GroupSetIterator

Description: An iterator to a group set.
Inherits: APIObject
Implements: IDisposable, IEnumerator

  CONSTRUCTORS:
    new GroupSetIterator()

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


[CLASS] GroupType
Full Name: Autodesk.Revit.DB.GroupType

Description: An element representing a group of elements that may be placed many times in a project or family.
Remarks: Grouping elements is useful when you need to create entities that represent repeating layouts or are common to many building projects, such as hotel rooms, apartments, or repeating floors.
Inherits: ElementType
Implements: IDisposable

  PROPERTIES:
    GroupSet Groups { get; }
      Description: Retrieve a set of all the groups that have this type.

  METHODS:
    ISet<ElementId> GetAvailableAttachedDetailGroupTypeIds()
      Description: Returns the attached detail groups available for this element group type.
      Returns: Returns the collection of attached detail group Ids that match this group's type.
    void LoadFrom(string fileName, GroupLoadOptions options)
      Description: Replaces the group with the contents of the input file.
      @fileName: The file to be used for the replacment.
      @options: Group load options.

--------------------------------------------------------------------------------


[ABSTRACT CLASS] GroupTypeId
Full Name: Autodesk.Revit.DB.GroupTypeId

Description: This class contains constants identifying parameter groups.

  PROPERTIES:
    static ForgeTypeId AdskModelProperties { get; }
      Description: Model Properties.
    static ForgeTypeId AlternateUnits { get; }
      Description: Alternate Units.
    static ForgeTypeId AnalysisResults { get; }
      Description: Analysis Results.
    static ForgeTypeId AnalyticalAlignment { get; }
      Description: Analytical Alignment.
    static ForgeTypeId AnalyticalModel { get; }
      Description: Analytical Model.
    static ForgeTypeId AnalyticalProperties { get; }
      Description: Analytical Properties.
    static ForgeTypeId Area { get; }
      Description: Area.
    static ForgeTypeId ConceptualEnergyData { get; }
      Description: Conceptual Energy Data.
    static ForgeTypeId ConceptualEnergyDataBuildingServices { get; }
      Description: Energy Model - Building Services.
    static ForgeTypeId Constraints { get; }
      Description: Constraints.
    static ForgeTypeId Construction { get; }
      Description: Construction.
    static ForgeTypeId ContinuousrailBeginBottomExtension { get; }
      Description: Extension (Beginning/Bottom).
    static ForgeTypeId ContinuousrailEndTopExtension { get; }
      Description: Extension (End/Top).
    static ForgeTypeId CouplerArray { get; }
      Description: Set.
    static ForgeTypeId CurtainGrid { get; }
      Description: Grid.
    static ForgeTypeId CurtainGridHoriz { get; }
      Description: Horizontal Grid.
    static ForgeTypeId CurtainGridn1 { get; }
      Description: Grid 1.
    static ForgeTypeId CurtainGridn2 { get; }
      Description: Grid 2.
    static ForgeTypeId CurtainGridU { get; }
      Description: U Grid.
    static ForgeTypeId CurtainGridV { get; }
      Description: V Grid.
    static ForgeTypeId CurtainGridVert { get; }
      Description: Vertical Grid.
    static ForgeTypeId CurtainMullionHoriz { get; }
      Description: Horizontal Mullions.
    static ForgeTypeId CurtainMullionn1 { get; }
      Description: Grid 1 Mullions.
    static ForgeTypeId CurtainMullionn2 { get; }
      Description: Grid 2 Mullions.
    static ForgeTypeId CurtainMullionVert { get; }
      Description: Vertical Mullions.
    static ForgeTypeId Data { get; }
      Description: Data.
    static ForgeTypeId Display { get; }
      Description: Display.
    static ForgeTypeId DivisionGeometry { get; }
      Description: Division Geometry.
    static ForgeTypeId Electrical { get; }
      Description: Electrical.
    static ForgeTypeId ElectricalAnalysis { get; }
      Description: Electrical Analysis.
    static ForgeTypeId ElectricalCircuiting { get; }
      Description: Electrical - Circuiting.
    static ForgeTypeId ElectricalEngineering { get; }
      Description: Electrical Engineering.
    static ForgeTypeId ElectricalLighting { get; }
      Description: Electrical - Lighting.
    static ForgeTypeId ElectricalLoads { get; }
      Description: Electrical - Loads.
    static ForgeTypeId EnergyAnalysis { get; }
      Description: Energy Analysis.
    static ForgeTypeId EnergyAnalysisAdvanced { get; }
      Description: Advanced.
    static ForgeTypeId EnergyAnalysisBldgConsMtlThermalProps { get; }
      Description: Material Thermal Properties.
    static ForgeTypeId EnergyAnalysisBuildingData { get; }
      Description: Building Data.
    static ForgeTypeId EnergyAnalysisConceptualModel { get; }
      Description: Energy Analytical Model.
    static ForgeTypeId EnergyAnalysisDetailedAndConceptualModels { get; }
      Description: Essential.
    static ForgeTypeId EnergyAnalysisDetailedModel { get; }
      Description: Detailed Model.
    static ForgeTypeId EnergyAnalysisRoomSpaceData { get; }
      Description: Room/Space Data.
    static ForgeTypeId FabricationProductData { get; }
      Description: Fabrication Product Data.
    static ForgeTypeId FireProtection { get; }
      Description: Fire Protection.
    static ForgeTypeId Fitting { get; }
      Description: Fittings.
    static ForgeTypeId Flexible { get; }
      Description: Adaptive Component.
    static ForgeTypeId Forces { get; }
      Description: Forces.
    static ForgeTypeId General { get; }
      Description: General.
    static ForgeTypeId GeoLocation { get; }
      Description: Geolocation.
    static ForgeTypeId Geometry { get; }
      Description: Geometry.
    static ForgeTypeId GeometryPositioning { get; }
      Description: Geometric Position.
    static ForgeTypeId Graphics { get; }
      Description: Graphics.
    static ForgeTypeId GreenBuilding { get; }
      Description: Green Building Properties.
    static ForgeTypeId IdentityData { get; }
      Description: Identity Data.
    static ForgeTypeId Ifc { get; }
      Description: IFC Parameters.
    static ForgeTypeId Insulation { get; }
      Description: Insulation.
    static ForgeTypeId Length { get; }
      Description: Length.
    static ForgeTypeId LifeSafety { get; }
      Description: Life Safety.
    static ForgeTypeId LightPhotometrics { get; }
      Description: Photometrics.
    static ForgeTypeId Lining { get; }
      Description: Lining.
    static ForgeTypeId Materials { get; }
      Description: Materials and Finishes.
    static ForgeTypeId Mechanical { get; }
      Description: Mechanical.
    static ForgeTypeId MechanicalAirflow { get; }
      Description: Mechanical - Flow.
    static ForgeTypeId MechanicalLoads { get; }
      Description: Mechanical - Loads.
    static ForgeTypeId Moments { get; }
      Description: Moments.
    static ForgeTypeId Nodes { get; }
      Description: Nodes.
    static ForgeTypeId OverallLegend { get; }
      Description: Overall Legend.
    static ForgeTypeId Pattern { get; }
      Description: Pattern.
    static ForgeTypeId PatternApplication { get; }
      Description: Pattern Application.
    static ForgeTypeId Phasing { get; }
      Description: Phasing.
    static ForgeTypeId Plumbing { get; }
      Description: Plumbing.
    static ForgeTypeId PrimaryEnd { get; }
      Description: Primary End.
    static ForgeTypeId PrimaryUnits { get; }
      Description: Primary Units.
    static ForgeTypeId Profile { get; }
      Description: Profile.
    static ForgeTypeId Profilen1 { get; }
      Description: Profile 1.
    static ForgeTypeId Profilen2 { get; }
      Description: Profile 2.
    static ForgeTypeId RailingSystemFamilyHandrails { get; }
      Description: Handrail 1.
    static ForgeTypeId RailingSystemFamilySegmentPattern { get; }
      Description: Segment Pattern (default).
    static ForgeTypeId RailingSystemFamilyTopRail { get; }
      Description: Top Rail.
    static ForgeTypeId RailingSystemSecondaryFamilyHandrails { get; }
      Description: Handrail 2.
    static ForgeTypeId RailingSystemSegmentPatternRemainder { get; }
      Description: Pattern Remainder.
    static ForgeTypeId RailingSystemSegmentPatternRepeat { get; }
      Description: Pattern Repeat.
    static ForgeTypeId RailingSystemSegmentPosts { get; }
      Description: Posts.
    static ForgeTypeId RailingSystemSegmentUGrid { get; }
      Description: U Grid.
    static ForgeTypeId RailingSystemSegmentVGrid { get; }
      Description: V Grid.
    static ForgeTypeId RebarArray { get; }
      Description: Rebar Set.
    static ForgeTypeId RebarSystemLayers { get; }
      Description: Layers.
    static ForgeTypeId Reference { get; }
      Description: Reference.
    static ForgeTypeId ReleasesMemberForces { get; }
      Description: Releases / Member Forces.
    static ForgeTypeId RotationAbout { get; }
      Description: Rotation about.
    static ForgeTypeId RouteAnalysis { get; }
      Description: Route Analysis.
    static ForgeTypeId SecondaryEnd { get; }
      Description: Secondary End.
    static ForgeTypeId SegmentsFittings { get; }
      Description: Segments and Fittings.
    static ForgeTypeId SlabShapeEdit { get; }
      Description: Slab Shape Edit.
    static ForgeTypeId SplitProfileDimensions { get; }
      Description: Dimensions (linear units or % of thickness).
    static ForgeTypeId StairRisers { get; }
      Description: Risers.
    static ForgeTypeId StairsCalculatorRules { get; }
      Description: Calculation Rules.
    static ForgeTypeId StairsOpenEndConnection { get; }
      Description: End Connection.
    static ForgeTypeId StairsSupports { get; }
      Description: Supports.
    static ForgeTypeId StairsTreadsRisers { get; }
      Description: Threads/Risers.
    static ForgeTypeId StairStringers { get; }
      Description: Stringers.
    static ForgeTypeId StairsWinders { get; }
      Description: Winders.
    static ForgeTypeId StairTreads { get; }
      Description: Treads.
    static ForgeTypeId Structural { get; }
      Description: Structural.
    static ForgeTypeId StructuralAnalysis { get; }
      Description: Structural Analysis.
    static ForgeTypeId StructuralSectionDimensions { get; }
      Description: Structural Section Dimensions.
    static ForgeTypeId StructuralSectionGeometry { get; }
      Description: Structural Section Geometry.
    static ForgeTypeId Support { get; }
      Description: Supports.
    static ForgeTypeId SystemtypeRisedrop { get; }
      Description: Rise / Drop.
    static ForgeTypeId Termination { get; }
      Description: Terminations.
    static ForgeTypeId Text { get; }
      Description: Text.
    static ForgeTypeId Title { get; }
      Description: Title Text.
    static ForgeTypeId ToposolidSubdivision { get; }
      Description: Sub-Division.
    static ForgeTypeId TranslationIn { get; }
      Description: Translation in.
    static ForgeTypeId TrussFamilyBottomChord { get; }
      Description: Bottom Chords.
    static ForgeTypeId TrussFamilyDiagWeb { get; }
      Description: Diagonal Webs.
    static ForgeTypeId TrussFamilyTopChord { get; }
      Description: Top Chords.
    static ForgeTypeId TrussFamilyVertWeb { get; }
      Description: Vertical Webs.
    static ForgeTypeId Underlay { get; }
      Description: Underlay.
    static ForgeTypeId ViewCamera { get; }
      Description: Camera.
    static ForgeTypeId ViewExtents { get; }
      Description: Extents.
    static ForgeTypeId Visibility { get; }
      Description: Visibility.
    static ForgeTypeId Visualization { get; }
      Description: Visualization.
    static ForgeTypeId WallCrossSectionDefinition { get; }
      Description: Cross-Section Definition.

--------------------------------------------------------------------------------


[CLASS] GuidEnum
Full Name: Autodesk.Revit.DB.GuidEnum

Description: Base class of all GUID-based enum classes.

  CONSTRUCTORS:
    new GuidEnum(Guid guid)

  PROPERTIES:
    Guid Guid { get; }
      Description: The Guid of GUID-based enum object.

  METHODS:
    bool Equals(object obj)
      Description: Compares two Guid-based enum object based on their concrete class and GUID value.
    int GetHashCode()
      Description: Generates a hash code for this Guid-based enum object.

--------------------------------------------------------------------------------

