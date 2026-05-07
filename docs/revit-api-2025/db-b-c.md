# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[ENUM] BackClippingParam
Full Name: Autodesk.Revit.DB.BackClippingParam
Description: The allowed values for the VIEW_BACK_CLIPPING and VIEWER_BOUND_FAR_CLIPPING parameters.
Inherits: Enum

  Values:
    - NoClip = 0
    - ClipWithLine = 1
    - ClipNoLine = 2

--------------------------------------------------------------------------------

[ENUM] BackgroundImageFit
Full Name: Autodesk.Revit.DB.BackgroundImageFit
Description: Indicates the background image fit type in rendering settings.
Inherits: Enum

  Values:
    - None = 0
    - Vertical = 41
    - Horizontal = 42
    - Stretch = 43

--------------------------------------------------------------------------------

[CLASS] BackgroundSettings
Full Name: Autodesk.Revit.DB.BackgroundSettings
Description: Represents the rendering background settings.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] BackgroundStyle
Full Name: Autodesk.Revit.DB.BackgroundStyle
Description: Indicates the background style in rendering settings.
Inherits: Enum

  Values:
    - SkyNoClouds = 0
    - SkyVeryFewClouds = 1
    - SkyFewClouds = 2
    - SkyCloudy = 3
    - SkyVeryCloudy = 4
    - Color = 5
    - Image = 6
    - Transparent = 7

--------------------------------------------------------------------------------

[CLASS] BarTypeDiameterOptions
Full Name: Autodesk.Revit.DB.BarTypeDiameterOptions
Description: This class stores the diameter information from the RebarBarType.
Remarks: This class can be used to create a whole new set of diameter values for a RebarBarType. It can be used when copying the diameter information as a bulk of data from a RebarBarType to another. The new diameters can be set in the RebarBarType in the following way: 1. Create a BarTypeDiameterOptions object with the new diameters. 2. Set the new diameters in RebarBarType using Autodesk::Revit::DB::Structure::RebarBarType::SetBarTypeDiameters. The method Autodesk::Revit::DB::Structure::RebarBarType::SetBarTypeDiameters is responsible for diameters validation.
Implements: IDisposable

  CONSTRUCTORS:
    new BarTypeDiameterOptions(RebarBarType barType)
      Description: Constructs a new BarTypeDiameterOptions copying the diameter information from the bar type.
      Throws ArgumentNullException: A non-optional argument was null
    new BarTypeDiameterOptions()
      Description: Constructs a new BarTypeDiameterOptions with default settings.

  PROPERTIES:
    double BarModelDiameter { get; set; }
      Description: Represents the bar model diameter of the RebarBarType.
    double BarNominalDiameter { get; set; }
      Description: Represents the bar nominal diameter of the RebarBarType.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double StandardBendDiameter { get; set; }
      Description: Represents the standard bar bend diameter of the RebarBarType.
    double StandardHookBendDiameter { get; set; }
      Description: Represents the standard hook bend diameter of the RebarBarType.
    double StirrupTieBendDiameter { get; set; }
      Description: Represents the stirrup/tie bar and hook bend diameter of the RebarBarType.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] BaseArray
Full Name: Autodesk.Revit.DB.BaseArray
Description: An abstract base class that represents an array within the Revit project.
Inherits: Element

  PROPERTIES:
    FamilyParameter Label { get; set; }
      Description: The family parameter label of the BaseArray.
    string Name { set; }
      Description: Get and Set the Name property
    int NumMembers { get; set; }
      Description: Retrieves or changes the number of the arrayed members.

  METHODS:
    ICollection<ElementId> GetCopiedMemberIds()
      Description: Retrieves the copied member Ids of the Array.
      Returns: The copied member Ids of the Array
    ICollection<ElementId> GetOriginalMemberIds()
      Description: Retrieves the original member Ids of the Array.
      Returns: The original member Ids of the Array

--------------------------------------------------------------------------------

[CLASS] BaseExportOptions
Full Name: Autodesk.Revit.DB.BaseExportOptions
Description: The base class for options used to export DWG, DXF and DGN format files.
Implements: IDisposable

  PROPERTIES:
    ExportColorMode Colors { get; set; }
      Description: Export color mode. Default value is ExportColorMode.IndexColors.
    string HatchPatternsFileName { get; set; }
      Description: Custom hatch patterns (pat) file name.
    bool HideReferencePlane { get; set; }
      Description: Whether or not to hide reference planes. Default value is false.
    bool HideScopeBox { get; set; }
      Description: Whether or not to hide the scope box. Default value is false.
    bool HideUnreferenceViewTags { get; set; }
      Description: Whether or not to hide unreference view tags. Default value is false.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string LayerMapping { get; set; }
      Description: Name of a layer settings standard or filename (with custom layer settings). Valid standards are: DGNV7 (only for DGN), AIA, CP83, BS1192, and ISO13567. default value is "" (empty) which means if no value is set, if no value is set, Revit will use a default value according to the localization.
    bool PreserveCoincidentLines { get; set; }
      Description: Whether or not to preserve coincident lines. Default value is false.
    PropOverrideMode PropOverrides { get; set; }
      Description: How to export overridden object styles. Default value is PropOverrideMode.ByEntity.

  METHODS:
    void Dispose()
    ExportFontTable GetExportFontTable()
      Description: Gets font table.
    ExportLayerTable GetExportLayerTable()
      Description: Gets the layer table.
      Returns: The layer table.
    ExportLinetypeTable GetExportLinetypeTable()
      Description: Gets a copy of the line type table.
      Returns: The line type table.
    ExportPatternTable GetExportPatternTable()
      Description: Gets a copy of the pattern table.
      Returns: The pattern table.
    static IList<string> GetPredefinedSetupNames(Document document)
      Description: Returns a list of names of predefined setups of export options.
      @document: A Revit document to retrieve names from.
      Returns: An array of strings representing names of predefined setups.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    void SetExportFontTable(ExportFontTable fontTable)
      Description: Sets font table to option.
      @fontTable: The font table to be set.
      Throws ArgumentNullException: A non-optional argument was null
    void SetExportLayerTable(ExportLayerTable layerTable)
      Description: Sets layer table back to option
      @layerTable: The layer table to be set
      Throws ArgumentNullException: A non-optional argument was null
    void SetExportLinetypeTable(ExportLinetypeTable linetypeTable)
      Description: Sets the line type table to use during export.
      @linetypeTable: The line type table to be set.
      Throws ArgumentNullException: A non-optional argument was null
    void SetExportPatternTable(ExportPatternTable patternTable)
      Description: Sets the pattern table to use during export.
      @patternTable: The pattern table to be set.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] BaseImportOptions
Full Name: Autodesk.Revit.DB.BaseImportOptions
Description: A base class containing import options used during import of several formats.
Implements: IDisposable

  PROPERTIES:
    bool AutoCorrectAlmostVHLines { get; set; }
      Description: Correct almost-vertical lines and almost-horizontal lines for import model if option is set to true, the almost-vertical lines would be vertical lines and almost-horizontal lines would be horizontal lines.
    ImportColorMode ColorMode { get; set; }
      Description: Color mode for the import. Three modes are supported. Black and White, Preserve Colors, and Invert Colors.
    double CustomScale { get; set; }
      Description: Scaling the import. If this is defined and a valid value (> 0.0), it takes priority over units.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool OrientToView { get; set; }
      Description: Place the import at the same orientation as the view that was passed into the import method. This option can only be used when not importing into a single view.(i.e. ThisViewOnly is set to false)
    ImportPlacement Placement { get; set; }
      Description: Where to place the import. Set this option to place the view at the origin or the center, or a shared coordinates.
    XYZ ReferencePoint { get; set; }
      Description: The 3D point in the document where the imported instance will be inserted. If not explicitly set, the instance will be inserted at the document origin.
    bool ThisViewOnly { get; set; }
      Description: Imports drawings into the view that was passed into the import method. This option is not available in 3D views.
    ImportUnit Unit { get; set; }
      Description: The unit of measure for imported geometry.
    bool VisibleLayersOnly { get; set; }
      Description: Only import the visible layers.

  METHODS:
    void Dispose()
    ForgeTypeId GetDefaultLengthUnit()
      Description: Get the default length unit used for importing unitless files.
    ICollection<string> GetLayerSelection()
      Description: Get all set layers name which user want to import into Revit.
      Returns: The layers' name.
    void SetDefaultLengthUnit(ForgeTypeId specTypeId)
      Description: Set the default length unit used for importing unitless files.
      @specTypeId: The default length unit.
      Throws ArgumentException: The given specTypeId is not a supported unit of length.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLayerSelection(ICollection<string> layerSelection)
      Description: Set the layers name which user want to import into Revit.
      @layerSelection: The layers imported into Revit.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] BaseLoadOn
Full Name: Autodesk.Revit.DB.BaseLoadOn
Description: An enumerated type listing all the possible power load use types for a space object.
Inherits: Enum

  Values:
    - kUseEnteredLoad = 0
    - kUseCalculatedLoad = 1
    - kUseActualLoad = 2
    - kNoOfBaseLoadOnMethods = 3
    - kBySpaceType = -1

--------------------------------------------------------------------------------

[CLASS] BasePoint
Full Name: Autodesk.Revit.DB.BasePoint
Description: A class representing the Project Base Point and Survey Point. Each Revit project contains one project base point and one survey point. The project base point represents the origin of the project coordinate system. The survey point represents the origin of the shared coordinate system.
Inherits: Element

  PROPERTIES:
    bool Clipped { get; set; }
      Description: Clipped state of the survey point (shared BasePoint). Change its state to clipped or unclipped, depending on how you want to move the survey point. To move the survey coordinate system in relation to the model, move the clipped survey point. To change the survey point to another location in the survey coordinate system, move the unclipped survey point. For project base point (non-shared BasePoint), this property will always return false. Trying to set the property will get an InvalidOperationException.
    bool IsShared { get; }
      Description: Indicates whether the BasePoint is shared. The project's survey point is a BasePoint which is shared.
    XYZ Position { get; }
      Description: Position of the BasePoint.
    XYZ SharedPosition { get; set; }
      Description: Shared position of the BasePoint based on the active ProjectLocation of its belonging Document. To get the shared position under other ProjectLocations, please use ProjectLocation.GetProjectPosition(BasePoint.Position).

  METHODS:
    static BasePoint GetProjectBasePoint(Document cda)
      Description: Gets the project base point for the document.
      @cda: The document from which to get the project base point.
      Returns: The project base point of the document.
      Throws ArgumentNullException: A non-optional argument was null
    static BasePoint GetSurveyPoint(Document cda)
      Description: Gets the survey point for the document.
      @cda: The document from which to get the survey point.
      Returns: The survey point of the document.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] BasicFileInfo
Full Name: Autodesk.Revit.DB.BasicFileInfo
Description: Encapsulates basic information about a Revit file, including worksharing status, Revit version, username and central path.
Remarks: This class provides a fast access to get basic information without fully opening a Revit file. The String) method can initialize a new instance of this class by providing a full path for Revit file, including project (.rvt) and family (.rfa) files. This class can extract information from files of older formats. If the structure of the BasicFileInfo storage has not changed, it can also extract information from files of newer formats (making the method IsSavedInLaterVersion relevant). However, if the structure of the storage has changed in a newer file format, String) will not be able to extract the information.
Implements: IDisposable

  PROPERTIES:
    bool AllLocalChangesSavedToCentral { get; }
      Description: Are all local changes saved to the central file?
    string CentralPath { get; }
      Description: Returns the central model path.
    string Format { get; }
      Description: The file format indicator (currently, the major release version such as "2019") used for saving the file.
    bool IsCentral { get; }
      Description: Checks if the file is workshared and Central.
    bool IsCreatedLocal { get; }
      Description: Checks if the file is local and created by RevitServerTool.exe.
    bool IsInProgress { get; }
      Description: Checks if the file is workshared and is in process of becoming Central.
    bool IsLocal { get; }
      Description: Checks if the file is workshared and Local.
    bool IsSavedInCurrentVersion { get; }
      Description: Checks if the file is saved in the current version.
    bool IsSavedInLaterVersion { get; }
      Description: Checks if the file is saved in a later version of Revit than the running Revit.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsWorkshared { get; }
      Description: Checks if the file is workshared.
    LanguageType LanguageWhenSaved { get; }
      Description: Return the language active for the last save
    Guid LatestCentralEpisodeGUID { get; }
      Description: This is the central model's episode GUID corresponding to the last reload latest done for this model.
    int LatestCentralVersion { get; }
      Description: This is the central model's version number corresponding to the last reload latest done for this model.
    string Username { get; }
      Description: Returns the username.

  METHODS:
    void Dispose()
    static BasicFileInfo Extract(string file)
      Description: Returns an instance of BasicFileInfo filled with basic information about a Revit file located at the given file-path
      @file: The full path to the file to be queried, including project (.rvt) and family (.rfa) files.
      Returns: If successful, basic file data.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The file doesn't exist.
      Throws InvalidOperationException: The file is a newer format file where the structure of the BasicFileInfo storage has changed, or the file is saved in very old version of Revit without basic file data.
    DocumentVersion GetDocumentVersion()
      Description: Gets the DocumentVersion for the file.
      Returns: The DocumentVersion for the file.

--------------------------------------------------------------------------------

[CLASS] BeamSystem
Full Name: Autodesk.Revit.DB.BeamSystem
Description: An object that represents a BeamSystem within the Autodesk Revit project.
Remarks: This object is derived from the Element base object. It can be used to access properties of a BeamSystem, such as elevation, level, etc. It also provides access to the beams (FamilyInstances) that are created by this BeamSystem.
Inherits: Element

  PROPERTIES:
    BeamSystemType BeamSystemType { get; set; }
      Description: Retrieves or changes the type of the BeamSystem.
    FamilySymbol BeamType { get; set; }
      Description: Retrieves or changes the Beam Type of the BeamSystem.
    XYZ Direction { get; }
      Description: The Direction of the BeamSystem.
    double Elevation { get; set; }
      Description: Retrieves or changes the Elevation of the BeamSystem.
    LayoutRule LayoutRule { get; set; }
      Description: Retrieves or changes the LayoutRule of the BeamSystem.
    Level Level { get; set; }
      Description: Get or change the level of the BeamSystem. When the level is changed, the elevation is changed to make the the BeamSystem remain the location.
    CurveArray Profile { get; set; }
      Description: Retrieve or set the profile of the BeamSystem.

  METHODS:
    static BeamSystem BeamBelongsTo(FamilyInstance beam)
      Description: Find out the BeamSystem to which the beam belongs.
      @beam: The beam want to ask.
      Returns: The BeamSystem.
    static BeamSystem Create(Document document, IList<Curve> profile, Level level, int curveIndexForDirection, bool is3d)
      Description: Creates a new BeamSystem with specified profile curves.
      @document: The document in which the new BeamSystem is created.
      @profile: The profile of the BeamSystem.
      @level: The level on which the BeamSystem is to be created. The work-plane of the BeamSystem will be the sketch plane associated with the Level. If there is no current sketch plane associated with the level yet, we will create a default one.
      @curveIndexForDirection: Index of the curve in the profile to be used as direction. '0' means the direction to use the first curve in profile. The curve from the profile to be used as direction must be a Line.
      @is3d: Whether the BeamSystem is 3D. If the BeamSystem is 3D, the sketchPlane must be a level, otherwise an exception will be thrown.
      Returns: If successful, a new BeamSystem object will be returned.
      Throws ArgumentException: The input profile contains at least one helical curve and is not supported for this operation. -or- The curve index must be valid and the curve to be used as direction must be a Line. -or- The input level does not have associated plan view. -or- The plan view associated with the input level is not valid. -or- Can not get valid sketch plane from the input level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static BeamSystem Create(Document document, IList<Curve> profile, Level level, XYZ direction, bool is3d)
      Description: Creates a new BeamSystem with specified profile curves.
      @document: The document in which the new BeamSystem is created.
      @profile: The profile of the BeamSystem.
      @level: The level on which the BeamSystem is to be created. The work-plane of the BeamSystem will be the sketch plane associated with the Level. If there is no current sketch plane associated with the level yet, we will create a default one.
      @direction: The direction is the direction of the BeamSystem.
      @is3d: Whether the BeamSystem is 3D. If the BeamSystem is 3D, the sketchPlane must be a level, otherwise an exception will be thrown.
      Returns: If successful, a new BeamSystem object will be returned.
      Throws ArgumentException: The input profile contains at least one helical curve and is not supported for this operation. -or- The input level does not have associated plan view. -or- The plan view associated with the input level is not valid. -or- Can not get valid sketch plane from the input level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static BeamSystem Create(Document document, IList<Curve> profile, SketchPlane sketchPlane, XYZ direction, bool is3d)
      Description: Creates a new BeamSystem with specified profile curves.
      @document: The document in which the new BeamSystem is created.
      @profile: The profile of the BeamSystem.
      @sketchPlane: The work-plane for the BeamSystem.
      @direction: The direction is the direction of the BeamSystem.
      @is3d: Whether the BeamSystem is 3D. If the BeamSystem is 3D, the sketchPlane must be a level, otherwise an exception will be thrown.
      Returns: If successful, a new BeamSystem object will be returned.
      Throws ArgumentException: SketchPlane is not valid for BeamSystem creation. -or- The input profile contains at least one helical curve and is not supported for this operation. -or- The profile curves must be in the sketch plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The BeamSystem is 3D, but the SketchPlane is not a level.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static BeamSystem Create(Document document, IList<Curve> profile, SketchPlane sketchPlane, int curveIndexForDirection)
      Description: Creates a 2D BeamSystem with specified profile curves.
      @document: The document in which the new BeamSystem is created.
      @profile: The profile of the BeamSystem.
      @sketchPlane: The work-plane for the BeamSystem.
      @curveIndexForDirection: Index of the curve in the profile to be used as direction. '0' means the default direction-to use the first curve in profile. The curve from the profile to be used as direction must be a Line.
      Returns: If successful, a new BeamSystem object will be returned.
      Throws ArgumentException: SketchPlane is not valid for BeamSystem creation. -or- The input profile contains at least one helical curve and is not supported for this operation. -or- The profile curves must be in the sketch plane. -or- The curve index must be valid and the curve to be used as direction must be a Line.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void DropBeamSystem(BeamSystem beamSystem)
      Description: Drop beam system, it will disassociate all members from the beam system and delete the beam system.
      @beamSystem: The beam system to be deleted.
    ICollection<ElementId> GetBeamIds()
      Description: Gets all the beams of the BeamSystem.
      Returns: The beam Ids.

--------------------------------------------------------------------------------

[ENUM] BeamSystemJustifyType
Full Name: Autodesk.Revit.DB.BeamSystemJustifyType
Description: Describes the justify method of beamsystem.
Inherits: Enum

  Values:
    - Center = 1
    - End = 2
    - Beginning = 3
    - DirectionLine = 4

--------------------------------------------------------------------------------

[CLASS] BeamSystemType
Full Name: Autodesk.Revit.DB.BeamSystemType
Description: An object that specifies the type of a beam system in Autodesk Revit.
Inherits: ElementType

--------------------------------------------------------------------------------

[ENUM] BehaviorType
Full Name: Autodesk.Revit.DB.BehaviorType
Description: An enumerated type listing all the behavior type for MEP Components.
Inherits: Enum

  Values:
    - Invalid = 0
    - Normal = 1
    - Bend = 2
    - Branch = 4
    - Intersection = 8
    - Inline = 16
    - BreakInto = 32
    - OrientToObject = 64
    - OrientToCenterLine = 128
    - OrientToFace = 256
    - SystemMember = 512
    - BaseObject = 1024
    - EndCap = 2048
    - Valve = 4096
    - Flange = 8192
    - MechanicalCoupling = 16384
    - VerticalBend = 32768
    - ElectricalBaseObject = 65536
    - Straight = 131072
    - Flex = 262144
    - Hanger = 524288
    - Flat_Tap = 1048576
    - Coupling = 2097152
    - Round_CentreLine_Tap = 4194304
    - Oval_CentreLine_Tap = 8388608
    - Damper = 16777216

--------------------------------------------------------------------------------

[ENUM] BendingDetailPositionOptions
Full Name: Autodesk.Revit.DB.BendingDetailPositionOptions
Description: An enumerated type listing the bending detail position options supported by the Bending Detail.
Inherits: Enum

  Values:
    - Right = 0
    - Left = 1
    - Top = 2
    - Bottom = 3

--------------------------------------------------------------------------------

[CLASS] BIMExportOptions
Full Name: Autodesk.Revit.DB.BIMExportOptions
Description: The base class for options used to export using ATF.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId ViewId { get; set; }
      Description: The element id of the 3D view to export. InvalidElementId by default.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Binding
Full Name: Autodesk.Revit.DB.Binding
Description: Binding objects are used to take a parameter definition and bind it to one or more categories.
Remarks: This class is a base class for all types of parameter binding within Autodesk Revit. Once the binding objects are created and added to the document parameters will be added to elements in those categories specified in the binding. There are currently two types of binding available, Instance binding and Type binding. The key difference between the two is that the instance bound parameters appear on all instances of the elements in those categories. Changing the parameter on one does not affect the other instances of the parameter. The Type bound parameters appear only on the type object and is shared by all the instances that use that type. Changing the type bound parameter affects all instances of the elements that use that type. Note, a definition can only be bound to an instance or a type and not both.
Inherits: APIObject

--------------------------------------------------------------------------------

[CLASS] BindingMap
Full Name: Autodesk.Revit.DB.BindingMap
Description: The parameters BindingMap contains all the parameter bindings that exist in the Autodesk Revit project.
Remarks: The ParameterBindingsMap is available from the Document.ParameterBindings property. A parameter binding is the way that a parameter definition is bound to elements within one or more categories. This map can be used to interrogate existing bindings, but it can also be used to generate new parameter bindings by using the Insert method.
Inherits: DefinitionBindingMap

  PROPERTIES:
    Binding Item { get; set; }

  METHODS:
    void Clear()
      Description: This method is used to remove all the items in the map.
    bool Contains(Definition key)
      Description: The Contains method is used to check if the parameter binding exists for one definition.
      @key: A parameter definition which can be an existing definition or one from a shared parameters file.
    int Erase(Definition key)
      Description: This method is used to erase one item in the map.
    bool Insert(Definition key, Binding item, ForgeTypeId groupTypeId)
      Description: Creates a new parameter binding between a parameter and a set of categories in a specified group.
      @key: A parameter definition which can be an existing definition or one from a shared parameters file.
      @item: An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.
      @groupTypeId: The identifier of the parameter definition's parameter group, or empty if the parameter is not to be associated with any predefined group.
    bool Insert(Definition key, Binding item)
      Description: Creates a new parameter binding between a parameter and a set of categories.
      @key: A parameter definition which can be an existing definition or one from a shared parameters file.
      @item: An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.
    bool ReInsert(Definition key, Binding item, ForgeTypeId groupTypeId)
      Description: Removes an existing parameter and creates a new binding for a given parameter in a specified group.
      @key: A parameter definition which can be an existing definition or one from a shared parameters file.
      @item: An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.
      @groupTypeId: The identifier of the parameter definition's parameter group, or empty if the parameter is not to be associated with any predefined group.
    bool ReInsert(Definition key, Binding item)
      Description: Removes an existing parameter and creates a new binding for a given parameter.
      @key: A parameter definition which can be an existing definition or one from a shared parameters file.
      @item: An InstanceBinding or TypeBinding object which contains the set of categories to which the parameter should be bound.
    bool Remove(Definition key)
      Description: The Remove method is used to remove a parameter binding.
      @key: A parameter definition which can be an existing definition or one from a shared parameters file.

--------------------------------------------------------------------------------

[CLASS] Blend
Full Name: Autodesk.Revit.DB.Blend
Description: A blend solid or void form.
Inherits: GenericForm

  PROPERTIES:
    double BottomOffset { get; set; }
      Description: The offset of the bottom end of the blend relative to the sketch plane.
    CurveArrArray BottomProfile { get; }
      Description: The curves which make up the bottom profile of the sketch.
    Sketch BottomSketch { get; }
      Description: Returns the Bottom Sketch of the Blend.
    double TopOffset { get; set; }
      Description: The offset of the top end of the blend relative to the sketch plane.
    CurveArrArray TopProfile { get; }
      Description: The curves which make up the top profile of the sketch.
    Sketch TopSketch { get; }
      Description: Returns the Top Sketch of the Blend.

  METHODS:
    VertexIndexPairArray GetVertexConnectionMap()
      Description: Gets the mapping between the vertices in the top and bottom profiles.
    void SetVertexConnectionMap(VertexIndexPairArray vertexMap)
      Description: Sets the mapping between the vertices in the top and bottom profiles.
      Throws ArgumentNullException: Thrown when the input argument-"vertexMap"-is .
      Throws ArgumentException: Thrown if the input argument-"vertexMap"-is empty.
      Throws InvalidOperationException: Thrown when the document failed to regenerate.

--------------------------------------------------------------------------------

[ENUM] BooleanOperationsType
Full Name: Autodesk.Revit.DB.BooleanOperationsType
Description: An enumerated type listing boolean types that are supported for boolean operation.
Inherits: Enum

  Values:
    - Union = 0
    - Difference = 1
    - Intersect = 2

--------------------------------------------------------------------------------

[CLASS] BooleanOperationsUtils
Full Name: Autodesk.Revit.DB.BooleanOperationsUtils
Description: These utilities are applicable for the geometry created by GeometryCreationUtilities and the geometry of Revit model.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static Solid CutWithHalfSpace(Solid solid, Plane plane)
      Description: Creates a new Solid which is the intersection of the input Solid with the half-space on the positive side of the given Plane. The positive side of the plane is the side to which Plane.Normal points.
      @solid: The input Solid to be cut.
      @plane: The cut plane. The space on the positive side of the normal of the plane will be intersected with the input Solid.
      Returns: The newly created Solid.
      Throws ArgumentNullException: A non-optional argument was null
    static void CutWithHalfSpaceModifyingOriginalSolid(Solid solid, Plane plane)
      Description: Modifies the input Solid preserving only the volume on the positive side of the given Plane. The positive side of the plane is the side to which Plane.Normal points.
      @solid: The input Solid to be cut. This object cannot be obtained directly from a Revit element. This means that IsElementGeometry cannot be true.
      @plane: The cut plane. The space on the positive side of the normal of the plane will be intersected with the input Solid.
      Throws ArgumentException: Thrown when the original solid object is the geometry of the Revit model.
      Throws ArgumentNullException: A non-optional argument was NULL
    void Dispose()
    static Solid ExecuteBooleanOperation(Solid solid0, Solid solid1, BooleanOperationsType booleanType)
      Description: Perform a boolean geometric operation between two solids, and return a new solid to represent the result.
      @solid0: The first solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.
      @solid1: The second solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.
      @booleanType: boolean operation type.
      Returns: The result geometry.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Failed to perform the Boolean operation for the two solids. This may be due to geometric inaccuracies in the solids, such as slightly misaligned faces or edges. If so, eliminating the inaccuracies by making sure the solids are accurately aligned may solve the problem. This also may be due to one or both solids having complexities such as more than two faces geometrically meeting along a single edge, or two coincident edges, etc. Eliminating such conditions, or performing a sequence of Boolean operations in an order that avoids such conditions, may solve the problem.
    static void ExecuteBooleanOperationModifyingOriginalSolid(Solid solid0, Solid solid1, BooleanOperationsType booleanType)
      Description: Perform a boolean geometric operation between two solids, and modify the original solid to represent the result.
      @solid0: The original solid object. This object cannot be obtained directly from a Revit element. This means that IsElementGeometry cannot be true.
      @solid1: The second solid object. A copy will be taken of the input object, so any solid whether obtained from a Revit element or not would be accepted.
      @booleanType: boolean operation type.
      Throws ArgumentException: Thrown when the original solid object is the geometry of the Revit model.
      Throws ArgumentNullException: A non-optional argument was NULL
      Throws InvalidOperationException: Failed to perform the Boolean operation for the two solids. This may be due to geometric inaccuracies in the solids, such as slightly misaligned faces or edges. If so, eliminating the inaccuracies by making sure the solids are accurately aligned may solve the problem. This also may be due to one or both solids having complexities such as more than two faces geometrically meeting along a single edge, or two coincident edges, etc. Eliminating such conditions, or performing a sequence of Boolean operations in an order that avoids such conditions, may solve the problem."

--------------------------------------------------------------------------------

[ENUM] BorderTile
Full Name: Autodesk.Revit.DB.BorderTile
Description: Options for controlling tiles that overlap the face boundary. See DividedSurface.
Inherits: Enum

  Values:
    - Empty = 0
    - Partial = 1
    - Overhanging = 2

--------------------------------------------------------------------------------

[CLASS] BoundarySegment
Full Name: Autodesk.Revit.DB.BoundarySegment
Description: An object that represents a segment of an area boundary.
Remarks: These objects define the exterior boundary of an area. The geometry of the segment can be retrieved along with the id of the element that is responsible for producing that boundary.
Implements: IDisposable

  PROPERTIES:
    ElementId ElementId { get; }
      Description: Retrieve the id of the element that produces this boundary segment. If the segment is created from an element in a link, this is the id of the RevitLinkInstance.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ElementId LinkElementId { get; }
      Description: Retrieve the element id of the element in a link instance that forms this boundary.

  METHODS:
    void Dispose()
    Curve GetCurve()
      Description: Get a copy of the curve that is formed along this boundary.
      Returns: A copy of the curve.

--------------------------------------------------------------------------------

[CLASS] BoundaryValidation
Full Name: Autodesk.Revit.DB.BoundaryValidation
Description: Curve loop validators.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static bool IsValidBoundaryOnSketchPlane(SketchPlane sketchPlane, IList<CurveLoop> curveLoops)
      Description: Indicates if the given curve loops compose a valid boundary on the sketch plane.
      @sketchPlane: The sketch plane.
      @curveLoops: The curve loops to be checked.
      Returns: True if the given curve loops are valid as described above, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidBoundaryOnView(Document document, ElementId viewId, IList<CurveLoop> curveLoops)
      Description: Indicates if the given curve loops compose a valid boundary on the view's detail sketch plane.
      @document: The document.
      @viewId: The view Id.
      @curveLoops: The curve loops to be checked.
      Returns: True if the given curve loops are valid as described above, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidHorizontalBoundary(IList<CurveLoop> curveLoops)
      Description: Identifies whether the given curve loops compose a valid horizontal boundary.
      @curveLoops: The curve loops to be checked.
      Returns: True if the given curve loops are valid as described above, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] BoundingBoxContainsPointFilter
Full Name: Autodesk.Revit.DB.BoundingBoxContainsPointFilter
Description: A filter used to match elements with a bounding box that contains the given point.
Remarks: This filter excludes all objects derived from View and objects derived from ElementType. This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter

  CONSTRUCTORS:
    new BoundingBoxContainsPointFilter(XYZ point, double tolerance, bool inverted)
      Description: Constructs a new instance of a filter to match elements with a bounding box that contains the given point, while specifying the tolerance to be used in deciding if the point matches the criteria. This constructor includes the option to invert the filter and match all elements with a bounding box that do not contain the given point.
      @point: The point used to find elements with a bounding box containing it.
      @tolerance: The tolerance value to use instead of zero. See the tolerance property for details.
      @inverted: True if the filter should be inverted and match all elements with a bounding box that do not contain the given point.
      Throws ArgumentException: The given value for tolerance is not finite -or- The given value for tolerance is not a number
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxContainsPointFilter(XYZ point, double tolerance)
      Description: Constructs a new instance of a filter to match elements with a bounding box that contains the given point, while specifying the tolerance to be used in deciding if the point matches the criteria.
      @point: The point used to find elements with a bounding box that contains it.
      @tolerance: The tolerance value to use instead of zero. See the tolerance property for details.
      Throws ArgumentException: The given value for tolerance is not finite -or- The given value for tolerance is not a number
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxContainsPointFilter(XYZ point, bool inverted)
      Description: Constructs a new instance of a filter to match elements with a bounding box that contains the given point, with the option to invert the filter and match all elements with a bounding box that do not contain the given point.
      @point: The point used to find elements with a bounding box containing it.
      @inverted: True if the filter should be inverted and match all elements with a bounding box that do not contain the given point.
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxContainsPointFilter(XYZ point)
      Description: Constructs a new instance of a filter to match elements with a bounding box that contains the given point.
      @point: The point used to find elements with a bounding box that contains it.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    XYZ Point { get; set; }
      Description: The XYZ point to use when matching element bounding boxes.
    double Tolerance { get; set; }
      Description: Allows control over the match criteria by using a tolerance in the geometry comparison. It is suggested to use this in cases where trivial differences should be considered when matching elements.

--------------------------------------------------------------------------------

[CLASS] BoundingBoxIntersectsFilter
Full Name: Autodesk.Revit.DB.BoundingBoxIntersectsFilter
Description: A filter used to match elements with a bounding box that intersects the given Outline.
Remarks: This filter excludes all objects derived from View and objects derived from ElementType. This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter

  CONSTRUCTORS:
    new BoundingBoxIntersectsFilter(Outline outline, double tolerance, bool inverted)
      Description: Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline, with the option to invert the filter and match all elements with a bounding box that are not intersecting the given Outline.
      @outline: The Outline used to find elements with a bounding box that intersect it.
      @tolerance: The tolerance value to use instead of zero. See the tolerance property for details.
      @inverted: True if the filter should be inverted and match all elements with a bounding box that are not intersecting the given Outline.
      Throws ArgumentException: outline is an empty Outline. -or- The given value for tolerance is not finite -or- The given value for tolerance is not a number
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxIntersectsFilter(Outline outline, double tolerance)
      Description: Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline.
      @outline: The Outline used to find elements with a bounding box that intersect it.
      @tolerance: The tolerance value to use instead of zero. See the tolerance property for details.
      Throws ArgumentException: outline is an empty Outline. -or- The given value for tolerance is not finite -or- The given value for tolerance is not a number
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxIntersectsFilter(Outline outline, bool inverted)
      Description: Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline, with the option to invert the filter and match all elements with a bounding box that are not intersecting the given Outline.
      @outline: The Outline used to find elements with a bounding box that intersect it.
      @inverted: True if the filter should be inverted and match all elements with a bounding box that are not intersecting the given Outline.
      Throws ArgumentException: outline is an empty Outline.
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxIntersectsFilter(Outline outline)
      Description: Constructs a new instance of a filter to match elements with a bounding box that intersects the given Outline.
      @outline: The Outline used to find elements with a bounding box that intersect it.
      Throws ArgumentException: outline is an empty Outline.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    double Tolerance { get; set; }
      Description: Allows control over the match criteria by using a tolerance in the geometry comparison. It is suggested to use this in cases where trivial differences should be considered when matching elements.

  METHODS:
    Outline GetBoundingBox()
      Description: Gets the outline being used for this filter.
      Returns: The outline being used for this filter.

--------------------------------------------------------------------------------

[CLASS] BoundingBoxIsInsideFilter
Full Name: Autodesk.Revit.DB.BoundingBoxIsInsideFilter
Description: A filter used to match elements with a bounding box that is contained by the given Outline.
Remarks: This filter excludes all objects derived from View and objects derived from ElementType. This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory.
Inherits: ElementQuickFilter

  CONSTRUCTORS:
    new BoundingBoxIsInsideFilter(Outline outline, double tolerance, bool inverted)
      Description: Constructs a new instance of a filter to match elements with a bounding box is contained by the given Outline, with the option to invert the filter and match all elements with a bounding box that are not contained by the given Outline.
      @outline: The Outline used to find elements with a bounding box that are contained by it.
      @tolerance: The tolerance value to use instead of zero. See the tolerance property for details.
      @inverted: True if the filter should be inverted and match all elements with a bounding box that are not contained by the given Outline.
      Throws ArgumentException: outline is an empty Outline. -or- The given value for tolerance is not finite -or- The given value for tolerance is not a number
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxIsInsideFilter(Outline outline, double tolerance)
      Description: Constructs a new instance of a filter to match elements with a bounding box that is contained by the given Outline.
      @outline: The Outline used to find elements with a bounding box that are contained by it.
      @tolerance: The tolerance value to use instead of zero. See the tolerance property for details.
      Throws ArgumentException: outline is an empty Outline. -or- The given value for tolerance is not finite -or- The given value for tolerance is not a number
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxIsInsideFilter(Outline outline, bool inverted)
      Description: Constructs a new instance of a filter to match elements with a bounding box is contained by the given Outline, with the option to invert the filter and match all elements with a bounding box that are not contained by the given Outline.
      @outline: The Outline used to find elements with a bounding box that are contained by it.
      @inverted: True if the filter should be inverted and match all elements with a bounding box that are not contained by the given Outline.
      Throws ArgumentException: outline is an empty Outline.
      Throws ArgumentNullException: A non-optional argument was null
    new BoundingBoxIsInsideFilter(Outline outline)
      Description: Constructs a new instance of a filter to match elements with a bounding box that is contained by the given Outline.
      @outline: The Outline used to find elements with a bounding box that are contained by it.
      Throws ArgumentException: outline is an empty Outline.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    double Tolerance { get; set; }
      Description: Allows control over the match criteria by using a tolerance in the geometry comparison. It is suggested to use this in cases where trivial differences should be considered when matching elements.

  METHODS:
    Outline GetBoundingBox()
      Description: Gets the outline being used for this filter.
      Returns: The outline being used for this filter.

--------------------------------------------------------------------------------

[CLASS] BoundingBoxUV
Full Name: Autodesk.Revit.DB.BoundingBoxUV
Description: A two-dimensional rectangle, parallel to the coordinate axes.
Implements: IDisposable

  CONSTRUCTORS:
    new BoundingBoxUV(double min_u, double min_v, double max_u, double max_v)
      Description: Creates object with supplied values.
      @min_u: The first coordinate of min.
      @min_v: The second coordinate of min.
      @max_u: The first coordinate of max.
      @max_v: The second coordinate of max.
    new BoundingBoxUV()
      Description: default constructor

  PROPERTIES:
    UV Bounds { get; }
    bool IsSet { get; }
      Description: Indicates whether the BoundingBoxUV is set or not.
    UV Max { get; set; }
      Description: Maximum coordinates (upper-right corner of the box).
    UV Min { get; set; }
      Description: Minimum coordinates (lower-left corner of the box).

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] BoundingBoxXYZ
Full Name: Autodesk.Revit.DB.BoundingBoxXYZ
Description: A three-dimensional rectangular box at an arbitrary location and orientation within the Revit model.
Remarks: BoundingBoxXYZ objects are used in Revit in several places related to views (for example, the section box of a 3D view or the definition of a section or detail view). BoundingBoxXYZ objects can also be obtained from elements representing the boundary of the element in a given view.The extents of the box are determined by three orthogonal planes extended through the minimum (Min) and maximum (Max) points, but the coordinates of these points and the orientation of the planes in relation to the coordinates of the source model is determined by the box Transform (Transform).This class also has the ability to detect and mark certain extents as disabled. Note that in the current Revit API uses of this class it is not expected that Revit will give objects with disabled extents, and disabled extents in objects sent to Revit will likely be ignored.
Inherits: APIObject

  CONSTRUCTORS:
    new BoundingBoxXYZ()
      Description: Constructs a new BoundingBoxXYZ with a default transform and extents of (-100, -100, -100) to (100, 100, 100).

  PROPERTIES:
    bool BoundEnabled { get; set; }
    XYZ Bounds { get; set; }
    bool Enabled { get; set; }
      Description: Defines whether the entire bounding box is enabled.
    bool IsSet { get; }
      Description: Indicates whether the bounding box is set.
    XYZ Max { get; set; }
      Description: Maximum coordinates (upper-right-front corner of the box).
    bool MaxEnabled { get; set; }
    XYZ Min { get; set; }
      Description: Minimum coordinates (lower-left-rear corner of the box).
    bool MinEnabled { get; set; }
    Transform Transform { get; set; }
      Description: The transform from the coordinate space of the box to the model coordinate space.

--------------------------------------------------------------------------------

[ENUM] BoxPlacement
Full Name: Autodesk.Revit.DB.BoxPlacement
Description: An enumerated type containing possible constraint types for Adaptive Points.
Inherits: Enum

  Values:
    - Center = 0
    - TopLeft = 1
    - TopRight = 2
    - BottomRight = 3
    - BottomLeft = 4

--------------------------------------------------------------------------------

[CLASS] BRepBuilder
Full Name: Autodesk.Revit.DB.BRepBuilder
Description: A class that allows direct construction of geometry objects (solids, open shells, etc.).
Inherits: ShapeBuilder

  CONSTRUCTORS:
    new BRepBuilder(BRepType geomType)
      Description: Construct a BRepBuilder to use in constructing geometry.
      @geomType: Specifies the expected type of the output geometry.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  METHODS:
    BRepBuilderGeometryId AddCoEdge(BRepBuilderGeometryId loopId, BRepBuilderGeometryId edgeId, bool bCoEdgeIsReversed)
      Description: Add a co-edge associated to a previously added edge. A co-edge represents the use of an edge on one of the edge's faces. BrepBuilder allows at most two faces per edge, hence at most two co-edges per edge, and the co-edges must have opposite bCoEdgeIsReversed flags. The co-edges in a loop must be added in the order in which they occur in the loop (i.e., in their topological order).
      @loopId: Id of the loop containing the new co-edge.
      @edgeId: Id of the co-edge's edge, previously created by a call to addEdge().
      @bCoEdgeIsReversed: True if the co-edge's topological direction in its face is opposite to the edge's parametric direction, false otherwise. The topological directions of the co-edges in a loop must be consistent with the direction in which the loop co-edges appear in the loop, and the loop orientations so defined must follow the convention that outer loops are oriented counter-clockwise and inner loops are oriented clockwise, with respect to the face's orientation.
      Returns: Id of the edge, to be used in calls to other BRepBuilder methods such as AddCoEdge().
      Throws ArgumentException: The supplied loop id doesn't correspond to a loop stored in this BRepBuilder object. -or- The supplied edge id doesn't correspond to an edge stored in this BRepBuilder object. -or- FinishLoop() has already been called on loopId. -or- The edge already has two coedges associated to it. -or- Inconsistent use of the edge by co-edges is detected: both co-edges have the same bCoedgeIsReversed parameter. -or- The edge has already been added to this face. -or- There is a gap between this co-edge and the previous co-edge in the loop.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error. Consult the State property of the BRepBuilder object for more details.
    BRepBuilderGeometryId AddEdge(BRepBuilderEdgeGeometry edgeGeom)
      Description: Add a new edge to the geometry being built. The BRepBuilder uses edges only to store edge geometry and to track pairs of co-edges that share an edge.
      @edgeGeom: Information specifying the edge's geometry.
      Returns: Id of the edge, to be used in calls to other BRepBuilder methods such as AddCoEdge().
      Throws ArgumentException: The input edge geometry was invalid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error. Consult the State property of the BRepBuilder object for more details.
    BRepBuilderGeometryId AddFace(BRepBuilderSurfaceGeometry surfaceGeom, bool bFaceIsReversed)
      Description: Creates an empty face in the geometry being built. Other BRepBuilder methods are used to add loops to the face.
      @surfaceGeom: The face's support surface.
      @bFaceIsReversed: True if the face's orientation is opposite to that of the surface, false if the orientations agree. The faces of each shell must be consistently oriented. For a solid (BRepType == Solid), the oriented face normals must point out of the solid; for a void (BRepType == Void), the face normals must point into the void. See the description of the bCoEdgeIsReversed input for AddCoEdge() for a discussion of the loop and co-edge orientation conventions to use with the BRepBuilder.
      Returns: An id that can be used to identify the face while the BRepBuilder is actively building geometry (e.g., to add a loop to a face).
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error. Consult the State property of the BRepBuilder object for more details.
    BRepBuilderGeometryId AddLoop(BRepBuilderGeometryId faceId)
      Description: Creates an empty loop in a given face of the geometry being built. Other BRepBuilder methods are used to add co-edges to the loop.
      @faceId: Id of the face to which the loop should be added. faceId was returned by a call to AddFace().
      Returns: An id that can be used to identify the loop while the BRepBuilder is actively building geometry (e.g., to add co-edges to the loop).
      Throws ArgumentException: The supplied face id doesn't correspond to a face stored in this BRepBuilder object. -or- FinishFace() has already been called on faceId. -or- Please finish the previous loop by calling FinishLoop() before adding a new one.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error. Consult the State property of the BRepBuilder object for more details.
    void AllowRemovalOfProblematicFaces()
      Description: Allow BRepBuilder to remove problematic faces (e.g., due to inaccurate edge geometry). If this option is enabled and BRepBuilder removes some faces, the output geometry's type will be OpenShell regardless of the expected type specified when the BRepBuilder was created.
    bool CanAddGeometry()
      Description: A validator function that checks the state of this BRepBuilder object. Returns true if this BRepBuilder object is accepting b-rep data, false otherwise.
      Returns: True if this BRepBuilder object is accepting b-rep data, false otherwise.
    BRepBuilderOutcome Finish()
      Description: Complete construction of the geometry. The geometry will be validated and, if valid, stored in this BRepBuilder. Otherwise it will be deleted.
      Returns: BRepBuilderOutcome.Success if successful, BRepBuilderOutcome.Failure otherwise.
      Throws InvalidOperationException: This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error. Consult the State property of the BRepBuilder object for more details. -or- BRep doesn't have enough faces. -or- FinishFace() must be called on all the faces of the BRepBuilder.
    void FinishFace(BRepBuilderGeometryId faceId)
      Description: Indicates that the caller has finished defining the given face.
      @faceId: Id of the face.
      Throws ArgumentException: The supplied face id doesn't correspond to a face stored in this BRepBuilder object. -or- FinishFace() has already been called on faceId. -or- The face has no edge loops. -or- FinishLoop() must be called on all the edge loops of faceId.
      Throws ArgumentNullException: A non-optional argument was null
    void FinishLoop(BRepBuilderGeometryId loopId)
      Description: Indicates that the caller has finished defining the given loop.
      @loopId: Id of the loop.
      Throws ArgumentException: The supplied loop id doesn't correspond to a loop stored in this BRepBuilder object. -or- FinishLoop() has already been called on loopId. -or- The edge loop has fewer than two co-edges.
      Throws ArgumentNullException: A non-optional argument was null
    ExternallyTaggedBRep GetResult(ExternalGeometryId externalId, BRepBuilderPersistentIds brepPersistentIds)
      Description: Get the ExternallyTaggedBRep built by this BRepBuilder. This will clear the built geometry stored in the BRepBuilder. This function will throw if this BRepBuilder hasn't completed building the b-rep. Use IsResultAvailable() to verify that this BRepBuilder contains a valid result.
      @externalId: The external Id of the GeometryObject built by this BRepBuilder.
      @brepPersistentIds: An object storing the relationship between ExternalGeometryIds and BRepBuilderGeometryIds.
      Returns: The ExternallyTaggedBRep built by this BRepBuilder.
      Throws ArgumentException: At least one BRepBuilderGeometryId in the supplied BRepBuilderPersistentIds map could not be found in this BRepBuilder object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This BRepBuilder object hasn't completed building data or was unsuccessful building it. Built Geometry is unavailable. In order to access the built Geometry, Finish() must be called first. That will set the state to completed.
    Solid GetResult()
      Description: Get the Solid built by this BRepBuilder. This will clear the built geometry stored in the BRepBuilder. This function will throw if this BRepBuilder hasn't completed building the b-rep. Use IsResultAvailable() to verify that this BRepBuilder contains a valid result.
      Returns: The Solid built by this BRepBuilder.
      Throws InvalidOperationException: This BRepBuilder object hasn't completed building data or was unsuccessful building it. Built Geometry is unavailable. In order to access the built Geometry, Finish() must be called first. That will set the state to completed.
    static bool IsPermittedSurfaceType(Surface surface)
      Description: A validator function that checks whether the surface object is of type supported as face surface by BRepBuilder.
      @surface: Surface object intended to be used as a face surface.
      Returns: True if a surface of this type may be used as a face surface, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsResultAvailable()
      Description: A validator function that checks the state of this BRepBuilder object. Returns true if this BRepBuilder object has successfully built a b-rep.
      Returns: True if this BRepBuilder object has successfully built a b-rep.
    bool IsValidEdgeId(BRepBuilderGeometryId edgeId)
      Description: A validator function that checks whether the edge id corresponds to an edge previously added to this BRepBuilder object.
      @edgeId: Edge id to be validated.
      Returns: True if edgeId corresponds to an edge previously added to this BRepBuilder, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidFaceId(BRepBuilderGeometryId faceId)
      Description: A validator function that checks whether the face id corresponds to a face previously added to this BRepBuilder object.
      @faceId: Face id to be validated.
      Returns: True if faceId corresponds to a face previously added to this BRepBuilder, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidLoopId(BRepBuilderGeometryId loopId)
      Description: A validator function that checks whether the loop id corresponds to a loop previously added to this BRepBuilder object.
      @loopId: Loop id to be validated.
      Returns: True if loopId corresponds to a loop previously added to this BRepBuilder, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidPersistentIdsMap(BRepBuilderPersistentIds brepPersistentIds)
      Description: A validator function that makes sure that all BRepBuilderGeometryIds in the input map can be found in this BRepBuilder object.
      @brepPersistentIds: The map that associates ExternalGeometryIds to BRepBuilderGeometryIds.
      Returns: True if all BRepBuilderGeometryIds in the input map can be found in this BRepBuilder object, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool RemovedSomeFaces()
      Description: Returns 'true' if BRepBuilder removed some problematic faces from the output geometry, 'false' if not. If allowRemovalOfProblematicFaces was not called to enable removal of problematic faces, this function will return 'false'. Note that if some faces were removed, the output geometry's type will be OpenShell regardless of the expected type that was specified when the BRepBuilder was created.
      Returns: True if BRepBuilder removed some faces, false if not.
    void SetAllowShortEdges()
      Description: Make BRepBuilder allow edges that it would normally disallow as being too short for Revit geometry.
      Throws InvalidOperationException: This function was called after the geometry had been defined (e.g. by calls to addFace).
    void SetFaceMaterialId(BRepBuilderGeometryId faceId, ElementId materialId)
      Description: Sets material id to a face.
      @faceId: Id of the face to which material id will be added. faceId was returned by a call to AddFace().
      @materialId: The material id associated with the face, or invalidElementId if none. It is not verified that materialId corresponds to a valid Material element.
      Throws ArgumentException: The supplied face id doesn't correspond to a face stored in this BRepBuilder object.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error. Consult the State property of the BRepBuilder object for more details.

--------------------------------------------------------------------------------

[CLASS] BRepBuilderEdgeGeometry
Full Name: Autodesk.Revit.DB.BRepBuilderEdgeGeometry
Description: An abstract class used by BRepBuilder to represent the geometry of an edge. Specific edge-geometry representations are represented by subclasses.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static BRepBuilderEdgeGeometry Create(XYZ startPoint, XYZ endPoint)
      Description: Constructs a BRepBuilderEdgeGeometry representing a straight line between the two given points.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The vectors startPoint and endPoint are coincident.
    static BRepBuilderEdgeGeometry Create(Curve curve)
      Description: Construct BRepBuilderEdgeGeometry based on any Revit Curve, including Line and Arc. The curve will be simplified if possible.
      @curve: The 3D curve for this edge. This BRepBuilderEdgeGeometry stores a copy of the input curve.
      Throws ArgumentException: The input curve is not bound. -or- The curve is degenerate (its length is too close to zero). -or- The endpoints of the curve are close enough that Revit considers it a closed curve.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] BRepBuilderGeometryId
Full Name: Autodesk.Revit.DB.BRepBuilderGeometryId
Description: This class is used by the BRepBuilder class to identify objects it creates (faces, edges, etc.).
Remarks: The user should use these ids to organize the calls to BRepBuilder methods (e.g., addLoop() takes a face id as input, referring to a face that was previously added by a call to AddFace()). The ids are only valid while the BRepBuilder is in use.
Implements: IDisposable

  CONSTRUCTORS:
    new BRepBuilderGeometryId(BRepBuilderGeometryId other)
      Description: Copy constructor
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    static BRepBuilderGeometryId InvalidGeometryId()
      Description: Returns an invalid BRepBuilderGeometryId, used as a return value to indicate an error.

--------------------------------------------------------------------------------

[ENUM] BRepBuilderOutcome
Full Name: Autodesk.Revit.DB.BRepBuilderOutcome
Description: This class defines possible outcomes returned by BRepBuilder functions that need to report outcome via a return value.
Inherits: Enum

  Values:
    - Success = 0
    - Failure = 1

--------------------------------------------------------------------------------

[CLASS] BRepBuilderPersistentIds
Full Name: Autodesk.Revit.DB.BRepBuilderPersistentIds
Description: This class stores a map from ExternalGeometryIds to BRepBuilderGeometryIds.
Implements: IDisposable

  CONSTRUCTORS:
    new BRepBuilderPersistentIds(BRepBuilder bRepBuilder)
      Description: Constructs a new BRepBuilderPersistentIds and associates the existing BRepBuilder to it.
      @bRepBuilder: The existing BRepBuilder.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void AddSubTag(ExternalGeometryId externalGeometryId, BRepBuilderGeometryId brepBuilderGeometryId)
      Description: Adds a correspondence between an ExternalGeometryId and a BRepBuilderGeometryId. Note that an existing correspondence in the map cannot be updated and that a particular BRepBuilderGeometryId may be related to at most one ExternalGeometryId.
      @externalGeometryId: An external geometry object Id.
      @brepBuilderGeometryId: A BRepBuilder geometry object Id. It must represent the ID of either a Face or an Edge.
      Throws ArgumentException: externalGeometryId cannot be used to create a new correspondence because it is already used. -or- brepBuilderGeometryId cannot be used to create a new correspondence because it is already used. -or- brepBuilderGeometryId cannot be used to create a new correspondence because it doesn't represent the ID of either a Face or an Edge.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The associated BRepBuilder doesn't exist or is not valid (has no Faces and no Edges).
    void Dispose()
    bool IsAssociatedBRepBuilderValid()
      Description: Validates the associated (in the constructor) BRepBuilder for this BRepBuilderPersistentIds.
      Returns: True if the associated BRepBuilder exists, false otherwise.
    bool IsBRepBuilderGeometryIdFaceOrEdge(BRepBuilderGeometryId brepBuilderGeometryId)
      Description: Validates the input BRepBuilderGeometryId that will be used to create a correspondence. In order to be valid, the input BRepBuilderGeometryId must represent the ID of either a Face or an Edge.
      @brepBuilderGeometryId: The BRepBuilderGeometryId to be used in a new correspondence.
      Returns: True if the input BRepBuilderGeometryId represents the ID of either a Face or an Edge, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidBRepBuilderGeometryIdForNewCorrespondence(BRepBuilderGeometryId brepBuilderGeometryId)
      Description: Validates the input BRepBuilderGeometryId that will be used to create a correspondence. In order to be valid, a correspondence for the input BRepBuilderGeometryId must not already exist.
      @brepBuilderGeometryId: The BRepBuilderGeometryId to be used in a new correspondence.
      Returns: True if the input BRepBuilderGeometryId can be used to create a new correspondence.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidExternalGeometryIdForNewCorrespondence(ExternalGeometryId externalGeometryId)
      Description: Validates the input ExternalGeometryId that will be used to create a correspondence. In order to be valid, a correspondence for the input ExternalGeometryId must not already exist.
      @externalGeometryId: The ExternalGeometryId to be used in a new correspondence.
      Returns: True if the input ExternalGeometryId can be used to create a new correspondence.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] BRepBuilderState
Full Name: Autodesk.Revit.DB.BRepBuilderState
Description: This class defines an enumerative type used to specify the state of a BRepBuilder object.
Inherits: Enum

  Values:
    - InvalidState = 0
    - AcceptingData = 1
    - Completed = 2

--------------------------------------------------------------------------------

[CLASS] BRepBuilderSurfaceGeometry
Full Name: Autodesk.Revit.DB.BRepBuilderSurfaceGeometry
Description: An abstract class used by BRepBuilder to represent the geometry of a surface. Specific surface-geometry representations are represented by subclasses.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static BRepBuilderSurfaceGeometry Create(Surface surface, BoundingBoxUV surfaceEnvelope)
      Description: Construct BRepBuilderSurfaceGeometry based on a permitted Revit Surface.
      @surface: The Revit surface defining the geometry. This BRepBuilderSurfaceGeometry stores a copy of the input surface.
      @surfaceEnvelope: Envelope of the surface in the uv parametric domain. Defines the domain of interest for the created surface. This is typically used to identify the domain of the face that references the surface in question. Expected to either be null or define a valid domain.
      Throws ArgumentException: A surface of this type cannot be used as a part of the geometry generated by BRepBuilder.
      Throws ArgumentNullException: A non-optional argument was null
    static BRepBuilderSurfaceGeometry CreateNURBSSurface(int degreeU, int degreeV, IList<double> knotsU, IList<double> knotsV, IList<XYZ> controlPoints, IList<double> weights, bool bReverseOrientation, BoundingBoxUV surfaceEnvelope)
      Description: Construct BRepBuilderSurfaceGeometry based on NURBS surface data, where the weights are supplied. In this case, the NURBS surface will be a piecewise rational polynomial surface.
      @degreeU: The degree of the spline in the u-direction; must be positive.
      @degreeV: The degree of the spline in the v-direction; must be positive.
      @knotsU: Knot values in the u-direction. The number of knots in the u-direction must be at least 2 * (degreeU + 1).
      @knotsV: Knot values in the v-direction. The number of knots in the v-direction must be at least 2 * (degreeV + 1).
      @controlPoints: One dimensional array of points representing the two dimensional net of control points of the NURBS surface in u and v directions. The total number of control points must equal numControlPtsU times numControlPtsV, where numControlPtsU and numControlPtsV are the numbers of control points in u and v directions, and they must satisfy the following conditions: numControlPtsU = number of knots in u - degreeU - 1.numControlPtsV = number of knots in v - degreeV - 1. The convention for 2d (idxU, idxV) to 1d (idx) conversion of array indexes: idxV first. That is, idxU is outer loop and idxV is inner loop. In other words, idx = idxU * numControlPtsV + idxV.
      @weights: Array of weights assigned to the control points. The number of weights must equal the number of control points. All weights should be greater than zero.
      @bReverseOrientation: If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same. The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane. Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.
      @surfaceEnvelope: Envelope of the surface in the uv parametric domain. Defines the domain of interest for the created surface. This is typically used to identify the domain of the face that references the surface in question. Expected to either be null or define a valid domain.
      Throws ArgumentException: The U-degree value must be at least 1. -or- The V-degree value must be at least 1. -or- The number of knots in the U direction must be at least 2 times the U-degree plus 1. -or- The number of knots in the V direction must be at least 2 times the V-degree plus 1. -or- The number of control points must equal (number of U-knots - U-degree - 1) * (number of V-knots - V-degree - 1). -or- The number of weights must be the same as the number of control points and all weights must be positive or all zero. -or- The input data does not define a valid Nurbs surface.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The Nurbs surface could not be converted for use in Revit. It may have C2-discontinuities or be too large.
    static BRepBuilderSurfaceGeometry CreateNURBSSurface(int degreeU, int degreeV, IList<double> knotsU, IList<double> knotsV, IList<XYZ> controlPoints, bool bReverseOrientation, BoundingBoxUV surfaceEnvelope)
      Description: Construct a BRepBuilderSurfaceGeometry based on NURBS surface data, where the weights are not supplied. In this case, the NURBS surface will be a piecewise polynomial surface.
      @degreeU: The degree of the spline in the u-direction; must be positive.
      @degreeV: The degree of the spline in the v-direction; must be positive.
      @knotsU: Knot values in the u-direction. The number of knots in the u-direction must be at least 2 * (degreeU + 1).
      @knotsV: Knot values in the v-direction. The number of knots in the v-direction must be at least 2 * (degreeV + 1).
      @controlPoints: One dimensional array of points representing the two dimensional net of control points of the NURBS surface in u and v directions. The total number of control points must equal numControlPtsU times numControlPtsV, where numControlPtsU and numControlPtsV are the numbers of control points in u and v directions, and they must satisfy the following conditions: numControlPtsU = number of knots in u - degreeU - 1.numControlPtsV = number of knots in v - degreeV - 1. The convention for 2d (idxU, idxV) to 1d (idx) conversion of array indexes: idxV first. That is, idxU is outer loop and idxV is inner loop. In other words, idx = idxU * numControlPtsV + idxV.
      @bReverseOrientation: If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same. The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane. Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.
      @surfaceEnvelope: Envelope of the surface in the uv parametric domain. Defines the domain of interest for the created surface. This is typically used to identify the domain of the face that references the surface in question. Expected to either be null or define a valid domain.
      Throws ArgumentException: The U-degree value must be at least 1. -or- The V-degree value must be at least 1. -or- The number of knots in the U direction must be at least 2 * (U-degree + 1). -or- The number of knots in the V direction must be at least 2 * (V-degree + 1). -or- The number of control points must equal (number of U-knots - U-degree - 1) * (number of V-knots - V-degree - 1). -or- The input data does not define a valid Nurbs surface.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The Nurbs surface could not be converted for use in Revit. It may have C2-discontinuities or be too large.
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] BRepType
Full Name: Autodesk.Revit.DB.BRepType
Description: This class defines an enumerative type used to specify the type of output geometry expected from a BRepBuilder.
Inherits: Enum

  Values:
    - OpenShell = 0
    - Solid = 1
    - Void = 2

--------------------------------------------------------------------------------

[CLASS] BrowserOrganization
Full Name: Autodesk.Revit.DB.BrowserOrganization
Description: The organization settings for grouping, sorting, and filtering of items in the project browser.
Inherits: ElementType

  PROPERTIES:
    SortingOrder SortingOrder { get; }
      Description: The sorting order if sorting of items is applicable in the browser.
    ElementId SortingParameterId { get; }
      Description: The Id of the parameter used to determine the sorting order of items in the browser.
    BrowserOrganizationType Type { get; }
      Description: Get BrowserOrganizationType.

  METHODS:
    bool AreFiltersSatisfied(ElementId elementId)
      Description: Determines if the given element satisfies the filters defined by the browser organization.
      @elementId: The element to check.
      Returns: True if the given element satisfies the filter.
      Throws ArgumentException: elementId is not a valid Element identifier.
      Throws ArgumentNullException: A non-optional argument was null
    static BrowserOrganization GetCurrentBrowserOrganizationForSchedules(Document document)
      Description: Gets the BrowserOrganization that applies to the Schedules section of the project browser.
      @document: Revit document from which to get the organization data.
      Returns: The BrowserOrganization for schedules, or null if no schedules sections exist
      Throws ArgumentNullException: A non-optional argument was null
    static BrowserOrganization GetCurrentBrowserOrganizationForSheets(Document document)
      Description: Gets the BrowserOrganization that applies to the Sheets section of the project browser.
      @document: Revit document from which to get the organization data.
      Returns: The BrowserOrganization for sheets, or null if no sheets exist.
      Throws ArgumentNullException: A non-optional argument was null
    static BrowserOrganization GetCurrentBrowserOrganizationForViews(Document document)
      Description: Gets the BrowserOrganization that applies to the Views section of the project browser.
      @document: Revit document from which to get the organization data.
      Returns: The BrowserOrganization for views, or null if no view sections exist
      Throws ArgumentNullException: A non-optional argument was null
    IList<FolderItemInfo> GetFolderItems(ElementId elementId)
      Description: Returns a collection of leaf FolderItemInfo objects each containing the given element Id.
      @elementId: Element id located at a leaf position in the project browser.
      Returns: An array of FolderItemInfo objects.
      Throws ArgumentException: elementId is not a valid Element identifier.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] BrowserOrganizationType
Full Name: Autodesk.Revit.DB.BrowserOrganizationType
Description: Enumerated type representing the type of browser organization.
Inherits: Enum

  Values:
    - Views = 0
    - Sheets = 1
    - Schedules = 3

--------------------------------------------------------------------------------

[CLASS] BuildingPadType
Full Name: Autodesk.Revit.DB.BuildingPadType
Description: Represents a specific type of Building Pad.
Inherits: HostObjAttributes

  PROPERTIES:
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the BuildingPadType

  METHODS:
    static BuildingPadType CreateDefault(Document document)
      Description: Creates a BuildingPadType element and adds it to the document.
      @document: The document to be modified.
      Returns: The new BuildingPadType element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[ENUM] BuildingType
Full Name: Autodesk.Revit.DB.BuildingType
Description: This enumeration is used for specifying the most predominant building use type.
Remarks: This enumerated list corresponds to the buildingType attribute in the gbXML (Green Building XML) schema and is primarily used for energy analysis.
Inherits: Enum

  Values:
    - kAutomotiveFacility = 0
    - kConventionCenter = 1
    - kCourthouse = 2
    - kDiningBarLoungeOrLeisure = 3
    - kDiningCafeteriaFastFood = 4
    - kDiningFamily = 5
    - kDormitory = 6
    - kExerciseCenter = 7
    - kFireStation = 8
    - kGymnasium = 9
    - kHospitalOrHealthcare = 10
    - kHotel = 11
    - kLibrary = 12
    - kManufacturing = 13
    - kMotel = 14
    - kMotionPictureTheatre = 15
    - kMultiFamily = 16
    - kMuseum = 17
    - kOffice = 18
    - kParkingGarage = 19
    - kPenitentiary = 20
    - kPerformingArtsTheater = 21
    - kPoliceStation = 22
    - kPostOffice = 23
    - kReligiousBuilding = 24
    - kRetail = 25
    - kSchoolOrUniversity = 26
    - kSportsArena = 27
    - kTownHall = 28
    - kTransportation = 29
    - kWarehouse = 30
    - kWorkshop = 31
    - kNoOfBuildingTypes = -1

--------------------------------------------------------------------------------

[ENUM] BuiltInCategory
Full Name: Autodesk.Revit.DB.BuiltInCategory
Description: A list of all the built in categories within Revit.
Inherits: Enum

  Values:
    - OST_StackedWalls_Obsolete_IdInWrongRange = -20034100
    - OST_MassTags_Obsolete_IdInWrongRange = -20034005
    - OST_MassSurface_Obsolete_IdInWrongRange = -20034004
    - OST_MassFloor_Obsolete_IdInWrongRange = -20034003
    - OST_Mass_Obsolete_IdInWrongRange = -20034000
    - OST_WallRefPlanes_Obsolete_IdInWrongRange = -20000896
    - OST_StickSymbols_Obsolete_IdInWrongRange = -20000828
    - OST_RemovedGridSeg_Obsolete_IdInWrongRange = -20000827
    - OST_PointClouds = -2010001
    - OST_AnalyticalPanelLocalCoordSys = -2009667
    - OST_AnalyticalMemberLocalCoordSys = -2009666
    - OST_AnalyticalOpening = -2009665
    - OST_AnalyticalPanel = -2009664
    - OST_AnalyticalMemberTags = -2009663
    - OST_AnalyticalMember = -2009662
    - OST_AssemblyOrigin_Lines = -2009661
    - OST_AssemblyOrigin_Planes = -2009660
    - OST_AssemblyOrigin_Points = -2009659
    - OST_AssemblyOrigin = -2009658
    - OST_LinksAnalytical = -2009657
    - OST_FoundationSlabAnalyticalTags = -2009656
    - OST_WallFoundationAnalyticalTags = -2009655
    - OST_IsolatedFoundationAnalyticalTags = -2009654
    - OST_WallAnalyticalTags = -2009653
    - OST_FloorAnalyticalTags = -2009652
    - OST_ColumnAnalyticalTags = -2009651
    - OST_BraceAnalyticalTags = -2009650
    - OST_BeamAnalyticalTags = -2009649
    - OST_AnalyticalNodes_Lines = -2009648
    - OST_AnalyticalNodes_Planes = -2009647
    - OST_AnalyticalNodes_Points = -2009646
    - OST_AnalyticalNodes = -2009645
    - OST_RigidLinksAnalytical = -2009644
    - OST_FoundationSlabAnalytical = -2009643
    - OST_WallFoundationAnalytical = -2009642
    - OST_IsolatedFoundationAnalytical = -2009641
    - OST_WallAnalytical = -2009640
    - OST_FloorAnalytical = -2009639
    - OST_ColumnEndSegment = -2009638
    - OST_ColumnStartSegment = -2009637
    - OST_ColumnAnalytical = -2009636
    - OST_BraceEndSegment = -2009635
    - OST_BraceStartSegment = -2009634
    - OST_BraceAnalytical = -2009633
    - OST_BeamEndSegment = -2009632
    - OST_BeamStartSegment = -2009631
    - OST_BeamAnalytical = -2009630
    - OST_CompassSecondaryMonth = -2009624
    - OST_CompassPrimaryMonth = -2009623
    - OST_CompassSectionFilled = -2009622
    - OST_LightLine = -2009621
    - OST_MultiSurface = -2009620
    - OST_SunSurface = -2009619
    - OST_Analemma = -2009618
    - OST_SunsetText = -2009617
    - OST_CompassSection = -2009616
    - OST_CompassOuter = -2009615
    - OST_SunriseText = -2009614
    - OST_CompassInner = -2009613
    - OST_SunPath2 = -2009612
    - OST_SunPath1 = -2009611
    - OST_Sun = -2009610
    - OST_SunStudy = -2009609
    - OST_StructuralTrussStickSymbols = -2009608
    - OST_StructuralTrussHiddenLines = -2009607
    - OST_TrussChord = -2009606
    - OST_TrussWeb = -2009605
    - OST_TrussBottomChordCurve = -2009604
    - OST_TrussTopChordCurve = -2009603
    - OST_TrussVertWebCurve = -2009602
    - OST_TrussDiagWebCurve = -2009601
    - OST_Truss = -2009600
    - OST_PlumbingEquipmentHiddenLines = -2009551
    - OST_MechanicalControlDevicesHiddenLines = -2009550
    - OST_RailingSystemTransitionHiddenLines_Deprecated = -2009549
    - OST_RailingSystemTerminationHiddenLines_Deprecated = -2009548
    - OST_RailingSystemRailHiddenLines_Deprecated = -2009547
    - OST_RailingSystemTopRailHiddenLines_Deprecated = -2009546
    - OST_RailingSystemHandRailBracketHiddenLines_Deprecated = -2009545
    - OST_RailingSystemHandRailHiddenLines_Deprecated = -2009544
    - OST_RailingSystemPanelBracketHiddenLines_Deprecated = -2009543
    - OST_RailingSystemPanelHiddenLines_Deprecated = -2009542
    - OST_RailingSystemBalusterHiddenLines_Deprecated = -2009541
    - OST_RailingSystemPostHiddenLines_Deprecated = -2009540
    - OST_RailingSystemSegmentHiddenLines_Deprecated = -2009539
    - OST_RailingSystemHiddenLines_Deprecated = -2009538
    - OST_StairStringer2012HiddenLines_Deprecated = -2009537
    - OST_StairTread2012HiddenLines_Deprecated = -2009536
    - OST_StairLanding2012HiddenLines_Deprecated = -2009535
    - OST_StairRun2012HiddenLines_Deprecated = -2009534
    - OST_Stairs2012HiddenLines_Deprecated = -2009533
    - OST_MassHiddenLines = -2009532
    - OST_CurtaSystemHiddenLines = -2009531
    - OST_OBSOLETE_ElemArrayHiddenLines = -2009530
    - OST_EntourageHiddenLines = -2009529
    - OST_PlantingHiddenLines = -2009528
    - OST_SpecialityEquipmentHiddenLines = -2009527
    - OST_TopographyHiddenLines = -2009526
    - OST_StructuralFramingSystemHiddenLines_Obsolete = -2009525
    - OST_SiteHiddenLines = -2009524
    - OST_RoadsHiddenLines = -2009523
    - OST_ParkingHiddenLines = -2009522
    - OST_PlumbingFixturesHiddenLines = -2009521
    - OST_MechanicalEquipmentHiddenLines = -2009520
    - OST_LightingFixturesHiddenLines = -2009519
    - OST_FurnitureSystemsHiddenLines = -2009518
    - OST_ElectricalFixturesHiddenLines = -2009517
    - OST_ElectricalEquipmentHiddenLines = -2009516
    - OST_CaseworkHiddenLines = -2009515
    - OST_DetailComponentsHiddenLines = -2009514
    - OST_ShaftOpeningHiddenLines = -2009513
    - OST_GenericModelHiddenLines = -2009512
    - OST_CurtainWallMullionsHiddenLines = -2009511
    - OST_CurtainWallPanelsHiddenLines = -2009510
    - OST_RampsHiddenLines = -2009509
    - OST_StairsRailingHiddenLines = -2009508
    - OST_StairsHiddenLines = -2009507
    - OST_ColumnsHiddenLines = -2009506
    - OST_FurnitureHiddenLines = -2009505
    - OST_LinesHiddenLines = -2009504
    - OST_CeilingsHiddenLines = -2009503
    - OST_RoofsHiddenLines = -2009502
    - OST_DoorsHiddenLines = -2009501
    - OST_WindowsHiddenLines = -2009500
    - OST_StructConnectionProfilesTags = -2009064
    - OST_StructConnectionHoleTags = -2009063
    - OST_CouplerHiddenLines = -2009062
    - OST_CouplerTags = -2009061
    - OST_Coupler = -2009060
    - OST_StructConnectionWeldTags = -2009059
    - OST_StructConnectionShearStudTags = -2009058
    - OST_StructConnectionAnchorTags = -2009057
    - OST_StructConnectionBoltTags = -2009056
    - OST_StructConnectionPlateTags = -2009055
    - OST_RebarHiddenLines = -2009050
    - OST_StructSubConnections = -2009049
    - OST_SteelElementStale = -2009048
    - OST_StructConnectionModifiers = -2009047
    - OST_StructConnectionWelds = -2009046
    - OST_StructConnectionHoles = -2009045
    - OST_StructConnectionShearStuds = -2009044
    - OST_StructConnectionNobleWarning = -2009043
    - OST_StructConnectionOthers = -2009042
    - OST_StructConnectionBolts = -2009041
    - OST_StructConnectionTags = -2009040
    - OST_StructConnectionAnchors = -2009039
    - OST_StructConnectionPlates = -2009038
    - OST_StructConnectionProfiles = -2009037
    - OST_StructConnectionReference = -2009036
    - OST_StructConnectionFailed = -2009035
    - OST_StructConnectionStale = -2009034
    - OST_StructConnectionSymbol = -2009033
    - OST_StructConnectionHiddenLines = -2009032
    - OST_StructWeldLines = -2009031
    - OST_StructConnections = -2009030
    - OST_FabricAreaBoundary = -2009029
    - OST_FabricReinSpanSymbol = -2009028
    - OST_FabricReinforcementWire = -2009027
    - OST_FabricReinforcementBoundary = -2009026
    - OST_RebarSetToggle = -2009025
    - OST_FabricAreaTags = -2009023
    - OST_FabricReinforcementTags = -2009022
    - OST_AreaReinTags = -2009021
    - OST_RebarTags = -2009020
    - OST_FabricAreaSketchSheetsLines = -2009019
    - OST_FabricAreaSketchEnvelopeLines = -2009018
    - OST_FabricAreas = -2009017
    - OST_FabricReinforcement = -2009016
    - OST_RebarCover = -2009015
    - OST_CoverType = -2009014
    - OST_RebarShape = -2009013
    - OST_PathReinBoundary = -2009012
    - OST_PathReinTags = -2009011
    - OST_PathReinSpanSymbol = -2009010
    - OST_PathRein = -2009009
    - OST_Cage = -2009008
    - OST_AreaReinXVisibility = -2009007
    - OST_AreaReinBoundary = -2009006
    - OST_AreaReinSpanSymbol = -2009005
    - OST_AreaReinSketchOverride = -2009004
    - OST_AreaRein = -2009003
    - OST_RebarLines = -2009002
    - OST_RebarSketchLines = -2009001
    - OST_Rebar = -2009000
    - OST_MEPAncillaryFramingTags = -2008236
    - OST_PlumbingEquipmentTags = -2008235
    - OST_PlumbingEquipment = -2008234
    - OST_MechanicalControlDeviceTags = -2008233
    - OST_MechanicalControlDevices = -2008232
    - OST_MEPAncillaryFraming = -2008231
    - OST_MEPAncillaries_Obsolete = -2008230
    - OST_FabricationDuctworkStiffenerTags = -2008229
    - OST_FabricationDuctworkStiffeners = -2008228
    - OST_ELECTRICAL_AreaBasedLoads_Reference_Visibility = -2008227
    - OST_ELECTRICAL_AreaBasedLoads_InteriorFill_Visibility = -2008226
    - OST_ELECTRICAL_AreaBasedLoads_ColorFill_Obsolete = -2008225
    - OST_ELECTRICAL_AreaBasedLoads_Reference = -2008224
    - OST_ELECTRICAL_AreaBasedLoads_InteriorFill = -2008223
    - OST_ELECTRICAL_AreaBasedLoads_Boundary = -2008222
    - OST_FabricationPipeworkInsulation = -2008221
    - OST_FabricationDuctworkLining = -2008220
    - OST_FabricationContainmentDrop = -2008219
    - OST_FabricationContainmentRise = -2008218
    - OST_FabricationPipeworkDrop = -2008217
    - OST_FabricationPipeworkRise = -2008216
    - OST_FabricationContainmentSymbology = -2008215
    - OST_FabricationContainmentCenterLine = -2008214
    - OST_FabricationContainmentTags = -2008213
    - OST_FabricationContainment = -2008212
    - OST_FabricationPipeworkSymbology = -2008211
    - OST_FabricationPipeworkCenterLine = -2008210
    - OST_FabricationPipeworkTags = -2008209
    - OST_FabricationPipework = -2008208
    - OST_FabricationDuctworkSymbology = -2008207
    - OST_FabricationDuctworkDrop = -2008206
    - OST_FabricationDuctworkRise = -2008205
    - OST_FabricationHangerTags = -2008204
    - OST_FabricationHangers = -2008203
    - OST_OBSOLETE_FabricationPartsTmpGraphicDropDrag = -2008202
    - OST_FabricationPartsTmpGraphicDrag = -2008201
    - OST_OBSOLETE_FabricationPartsTmpGraphicDrop = -2008200
    - OST_FabricationPartsTmpGraphicEnd = -2008199
    - OST_FabricationDuctworkInsulation = -2008198
    - OST_LayoutNodes = -2008197
    - OST_FabricationDuctworkCenterLine = -2008196
    - OST_FabricationServiceElements = -2008195
    - OST_FabricationDuctworkTags = -2008194
    - OST_FabricationDuctwork = -2008193
    - OST_LayoutPathBase_Pipings = -2008192
    - OST_NumberingSchemas = -2008191
    - OST_DivisionRules = -2008190
    - OST_gbXML_Shade = -2008187
    - OST_AnalyticSurfaces = -2008186
    - OST_AnalyticSpaces = -2008185
    - OST_gbXML_OpeningAir = -2008184
    - OST_gbXML_NonSlidingDoor = -2008183
    - OST_gbXML_SlidingDoor = -2008182
    - OST_gbXML_OperableSkylight = -2008181
    - OST_gbXML_FixedSkylight = -2008180
    - OST_gbXML_OperableWindow = -2008179
    - OST_gbXML_FixedWindow = -2008178
    - OST_gbXML_UndergroundCeiling = -2008177
    - OST_gbXML_UndergroundSlab = -2008176
    - OST_gbXML_UndergroundWall = -2008175
    - OST_gbXML_SurfaceAir = -2008174
    - OST_gbXML_Ceiling = -2008173
    - OST_gbXML_InteriorFloor = -2008172
    - OST_gbXML_InteriorWall = -2008171
    - OST_gbXML_SlabOnGrade = -2008170
    - OST_gbXML_RaisedFloor = -2008169
    - OST_gbXML_Roof = -2008168
    - OST_gbXML_ExteriorWall = -2008167
    - OST_DivisionProfile = -2008165
    - OST_SplitterProfile = -2008164
    - OST_PipeSegments = -2008163
    - OST_GraphicalWarning_OpenConnector = -2008162
    - OST_PlaceHolderPipes = -2008161
    - OST_PlaceHolderDucts = -2008160
    - OST_PipingSystem_Reference_Visibility = -2008159
    - OST_PipingSystem_Reference = -2008158
    - OST_DuctSystem_Reference_Visibility = -2008157
    - OST_DuctSystem_Reference = -2008156
    - OST_PipeInsulationsTags = -2008155
    - OST_DuctLiningsTags = -2008154
    - OST_DuctInsulationsTags = -2008153
    - OST_ElectricalInternalCircuits = -2008152
    - OST_PanelScheduleGraphics = -2008151
    - OST_CableTrayRun = -2008150
    - OST_ConduitRun = -2008149
    - OST_ParamElemElectricalLoadClassification = -2008148
    - OST_DataPanelScheduleTemplates = -2008147
    - OST_SwitchboardScheduleTemplates = -2008146
    - OST_BranchPanelScheduleTemplates = -2008145
    - OST_ConduitStandards = -2008144
    - OST_ElectricalLoadClassifications = -2008143
    - OST_ElectricalDemandFactorDefinitions = -2008142
    - OST_ConduitFittingCenterLine = -2008141
    - OST_CableTrayFittingCenterLine = -2008140
    - OST_ConduitCenterLine = -2008139
    - OST_ConduitDrop = -2008138
    - OST_ConduitRiseDrop = -2008137
    - OST_CableTrayCenterLine = -2008136
    - OST_CableTrayDrop = -2008135
    - OST_CableTrayRiseDrop = -2008134
    - OST_ConduitTags = -2008133
    - OST_Conduit = -2008132
    - OST_CableTrayTags = -2008131
    - OST_CableTray = -2008130
    - OST_ConduitFittingTags = -2008129
    - OST_ConduitFitting = -2008128
    - OST_CableTrayFittingTags = -2008127
    - OST_CableTrayFitting = -2008126
    - OST_RoutingPreferences = -2008125
    - OST_DuctLinings = -2008124
    - OST_DuctInsulations = -2008123
    - OST_PipeInsulations = -2008122
    - OST_HVAC_Load_Schedules = -2008121
    - OST_HVAC_Load_Building_Types = -2008120
    - OST_HVAC_Load_Space_Types = -2008119
    - OST_HVAC_Zones_Reference_Visibility = -2008118
    - OST_HVAC_Zones_InteriorFill_Visibility = -2008117
    - OST_HVAC_Zones_ColorFill = -2008116
    - OST_ZoneTags = -2008115
    - OST_LayoutPath_Bases = -2008114
    - OST_WireTemperatureRatings = -2008113
    - OST_WireInsulations = -2008112
    - OST_WireMaterials = -2008111
    - OST_HVAC_Zones_Reference = -2008110
    - OST_HVAC_Zones_InteriorFill = -2008109
    - OST_HVAC_Zones_Boundary = -2008108
    - OST_HVAC_Zones = -2008107
    - OST_Fluids = -2008106
    - OST_PipeSchedules = -2008105
    - OST_PipeMaterials = -2008104
    - OST_PipeConnections = -2008103
    - OST_EAConstructions = -2008102
    - OST_SwitchSystem = -2008101
    - OST_SprinklerTags = -2008100
    - OST_Sprinklers = -2008099
    - OST_RouteCurveBranch = -2008098
    - OST_RouteCurveMain = -2008097
    - OST_RouteCurve = -2008096
    - OST_GbXML_Opening = -2008095
    - OST_GbXML_SType_Underground = -2008094
    - OST_GbXML_SType_Shade = -2008093
    - OST_GbXML_SType_Exterior = -2008092
    - OST_GbXML_SType_Interior = -2008091
    - OST_GbXMLFaces = -2008090
    - OST_WireHomeRunArrows = -2008089
    - OST_LightingDeviceTags = -2008088
    - OST_LightingDevices = -2008087
    - OST_FireAlarmDeviceTags = -2008086
    - OST_FireAlarmDevices = -2008085
    - OST_DataDeviceTags = -2008084
    - OST_DataDevices = -2008083
    - OST_CommunicationDeviceTags = -2008082
    - OST_CommunicationDevices = -2008081
    - OST_SecurityDeviceTags = -2008080
    - OST_SecurityDevices = -2008079
    - OST_NurseCallDeviceTags = -2008078
    - OST_NurseCallDevices = -2008077
    - OST_TelephoneDeviceTags = -2008076
    - OST_TelephoneDevices = -2008075
    - OST_WireTickMarks = -2008074
    - OST_PipeFittingInsulation = -2008073
    - OST_PipeFittingCenterLine = -2008072
    - OST_FlexPipeCurvesInsulation = -2008071
    - OST_PipeCurvesInsulation = -2008070
    - OST_PipeCurvesDrop = -2008069
    - OST_DuctFittingLining = -2008068
    - OST_DuctFittingInsulation = -2008067
    - OST_DuctFittingCenterLine = -2008066
    - OST_FlexDuctCurvesInsulation = -2008065
    - OST_DuctCurvesLining = -2008064
    - OST_DuctCurvesInsulation = -2008063
    - OST_DuctCurvesDrop = -2008062
    - OST_DuctFittingTags = -2008061
    - OST_PipeFittingTags = -2008060
    - OST_PipeColorFills = -2008059
    - OST_PipeColorFillLegends = -2008058
    - OST_WireTags = -2008057
    - OST_PipeAccessoryTags = -2008056
    - OST_PipeAccessory = -2008055
    - OST_PipeCurvesRiseDrop = -2008054
    - OST_FlexPipeCurvesPattern = -2008053
    - OST_FlexPipeCurvesContour = -2008052
    - OST_FlexPipeCurvesCenterLine = -2008051
    - OST_FlexPipeCurves = -2008050
    - OST_PipeFitting = -2008049
    - OST_FlexPipeTags = -2008048
    - OST_PipeTags = -2008047
    - OST_PipeCurvesContour = -2008046
    - OST_PipeCurvesCenterLine = -2008045
    - OST_PipeCurves = -2008044
    - OST_PipingSystem = -2008043
    - OST_ElectricalDemandFactor = -2008042
    - OST_ElecDistributionSys = -2008041
    - OST_ElectricalVoltage = -2008040
    - OST_Wire = -2008039
    - OST_ElectricalCircuitTags = -2008038
    - OST_ElectricalCircuit = -2008037
    - OST_DuctCurvesRiseDrop = -2008036
    - OST_FlexDuctCurvesPattern = -2008023
    - OST_FlexDuctCurvesContour = -2008022
    - OST_FlexDuctCurvesCenterLine = -2008021
    - OST_FlexDuctCurves = -2008020
    - OST_DuctAccessoryTags = -2008017
    - OST_DuctAccessory = -2008016
    - OST_DuctSystem = -2008015
    - OST_DuctTerminalTags = -2008014
    - OST_DuctTerminal = -2008013
    - OST_DuctFitting = -2008010
    - OST_DuctColorFills = -2008005
    - OST_FlexDuctTags = -2008004
    - OST_DuctTags = -2008003
    - OST_DuctCurvesContour = -2008002
    - OST_DuctCurvesCenterLine = -2008001
    - OST_DuctCurves = -2008000
    - OST_DuctColorFillLegends = -2007004
    - OST_ConnectorElemZAxis = -2007003
    - OST_ConnectorElemYAxis = -2007002
    - OST_ConnectorElemXAxis = -2007001
    - OST_ConnectorElem = -2007000
    - OST_VibrationManagementTags = -2006282
    - OST_BridgeFramingTrussTags = -2006281
    - OST_BridgeFramingDiaphragmTags = -2006279
    - OST_BridgeFramingCrossBracingTags = -2006278
    - OST_StructuralTendonTags = -2006276
    - OST_StructuralTendonHiddenLines = -2006275
    - OST_StructuralTendons = -2006274
    - OST_ExpansionJointTags = -2006273
    - OST_ExpansionJointHiddenLines = -2006272
    - OST_ExpansionJoints = -2006271
    - OST_VibrationIsolatorTags = -2006266
    - OST_VibrationIsolators = -2006265
    - OST_VibrationDamperTags = -2006264
    - OST_VibrationDampers = -2006263
    - OST_VibrationManagementHiddenLines = -2006262
    - OST_VibrationManagement = -2006261
    - OST_BridgeFramingTrusses = -2006248
    - OST_BridgeFramingDiaphragms = -2006246
    - OST_BridgeFramingCrossBracing = -2006245
    - OST_BridgeFramingTags = -2006243
    - OST_BridgeFramingHiddenLines = -2006242
    - OST_BridgeFraming = -2006241
    - OST_PierWallTags = -2006230
    - OST_PierWalls = -2006229
    - OST_PierPileTags = -2006226
    - OST_PierPiles = -2006225
    - OST_PierColumnTags = -2006222
    - OST_PierColumns = -2006221
    - OST_PierCapTags = -2006220
    - OST_PierCaps = -2006219
    - OST_ApproachSlabTags = -2006211
    - OST_AbutmentWallTags = -2006210
    - OST_AbutmentPileTags = -2006209
    - OST_AbutmentFoundationTags = -2006208
    - OST_ApproachSlabs = -2006205
    - OST_AbutmentWalls = -2006204
    - OST_AbutmentPiles = -2006203
    - OST_AbutmentFoundations = -2006202
    - OST_BridgeBearingTags = -2006178
    - OST_BridgeGirderTags = -2006177
    - OST_BridgeFoundationTags = -2006176
    - OST_BridgeDeckTags = -2006175
    - OST_BridgeArchTags = -2006174
    - OST_BridgeCableTags = -2006173
    - OST_BridgeTowerTags = -2006172
    - OST_BridgePierTags = -2006171
    - OST_BridgeAbutmentTags = -2006170
    - OST_BridgeBearingHiddenLines = -2006158
    - OST_BridgeGirderHiddenLines2021_Deprecated = -2006157
    - OST_BridgeFoundationHiddenLines2021_Deprecated = -2006156
    - OST_BridgeDeckHiddenLines = -2006155
    - OST_BridgeArchHiddenLines2021_Deprecated = -2006154
    - OST_BridgeCableHiddenLines2021_Deprecated = -2006153
    - OST_BridgeTowerHiddenLines2021_Deprecated = -2006152
    - OST_BridgePierHiddenLines = -2006151
    - OST_BridgeAbutmentHiddenLines = -2006150
    - OST_BridgeBearings = -2006138
    - OST_BridgeGirders = -2006137
    - OST_BridgeFoundations = -2006136
    - OST_BridgeDecks = -2006135
    - OST_BridgeArches = -2006134
    - OST_BridgeCables = -2006133
    - OST_BridgeTowers = -2006132
    - OST_BridgePiers = -2006131
    - OST_BridgeAbutments = -2006130
    - OST_DesignOptions = -2006114
    - OST_DesignOptionSets = -2006112
    - OST_StructuralBracePlanReps = -2006110
    - OST_StructConnectionSymbols = -2006100
    - OST_StructuralAnnotations = -2006090
    - OST_RevisionCloudTags = -2006080
    - OST_RevisionNumberingSequences = -2006071
    - OST_Revisions = -2006070
    - OST_RevisionClouds = -2006060
    - OST_EditCutProfile = -2006050
    - OST_ElevationMarks = -2006045
    - OST_GridHeads = -2006040
    - OST_LevelHeads = -2006020
    - OST_DecalType = -2006002
    - OST_DecalElement = -2006001
    - OST_VolumeOfInterest = -2006000
    - OST_BoundaryConditions = -2005301
    - OST_InternalAreaLoadTags = -2005255
    - OST_InternalLineLoadTags = -2005254
    - OST_InternalPointLoadTags = -2005253
    - OST_AreaLoadTags = -2005252
    - OST_LineLoadTags = -2005251
    - OST_PointLoadTags = -2005250
    - OST_LoadCasesSeismic = -2005218
    - OST_LoadCasesTemperature = -2005217
    - OST_LoadCasesAccidental = -2005216
    - OST_LoadCasesRoofLive = -2005215
    - OST_LoadCasesSnow = -2005214
    - OST_LoadCasesWind = -2005213
    - OST_LoadCasesLive = -2005212
    - OST_LoadCasesDead = -2005211
    - OST_LoadCases = -2005210
    - OST_InternalAreaLoads = -2005207
    - OST_InternalLineLoads = -2005206
    - OST_InternalPointLoads = -2005205
    - OST_InternalLoads = -2005204
    - OST_AreaLoads = -2005203
    - OST_LineLoads = -2005202
    - OST_PointLoads = -2005201
    - OST_Loads = -2005200
    - OST_BeamSystemTags = -2005130
    - OST_FootingSpanDirectionSymbol = -2005111
    - OST_SpanDirectionSymbol = -2005110
    - OST_SpotSlopesSymbols = -2005102
    - OST_SpotCoordinateSymbols = -2005101
    - OST_SpotElevSymbols = -2005100
    - OST_MultiLeaderTag = -2005033
    - OST_CurtainWallMullionTags = -2005032
    - OST_StructuralConnectionHandlerTags_Deprecated = -2005031
    - OST_TrussTags = -2005030
    - OST_KeynoteTags = -2005029
    - OST_DetailComponentTags = -2005028
    - OST_MaterialTags = -2005027
    - OST_FloorTags = -2005026
    - OST_CurtaSystemTags = -2005025
    - OST_HostFinTags = -2005024
    - OST_StairsTags = -2005023
    - OST_MultiCategoryTags = -2005022
    - OST_PlantingTags = -2005021
    - OST_AreaTags = -2005020
    - OST_StructuralFoundationTags = -2005019
    - OST_StructuralColumnTags = -2005018
    - OST_ParkingTags = -2005017
    - OST_SiteTags = -2005016
    - OST_StructuralFramingTags = -2005015
    - OST_SpecialityEquipmentTags = -2005014
    - OST_GenericModelTags = -2005013
    - OST_CurtainWallPanelTags = -2005012
    - OST_WallTags = -2005011
    - OST_PlumbingFixtureTags = -2005010
    - OST_MechanicalEquipmentTags = -2005009
    - OST_LightingFixtureTags = -2005008
    - OST_FurnitureSystemTags = -2005007
    - OST_FurnitureTags = -2005006
    - OST_ElectricalFixtureTags = -2005004
    - OST_ElectricalEquipmentTags = -2005003
    - OST_CeilingTags = -2005002
    - OST_CaseworkTags = -2005001
    - OST_Tags = -2005000
    - OST_MEPSpaceColorFill = -2003605
    - OST_MEPSpaceReference = -2003604
    - OST_MEPSpaceInteriorFill = -2003603
    - OST_MEPSpaceReferenceVisibility = -2003602
    - OST_MEPSpaceInteriorFillVisibility = -2003601
    - OST_MEPSpaces = -2003600
    - OST_StackedWalls = -2003500
    - OST_MassGlazingAll = -2003423
    - OST_MassFloorsAll = -2003422
    - OST_MassWallsAll = -2003421
    - OST_MassExteriorWallUnderground = -2003420
    - OST_MassSlab = -2003419
    - OST_MassShade = -2003418
    - OST_MassOpening = -2003417
    - OST_MassSkylights = -2003416
    - OST_MassGlazing = -2003415
    - OST_MassRoof = -2003414
    - OST_MassExteriorWall = -2003413
    - OST_MassInteriorWall = -2003412
    - OST_MassZone = -2003411
    - OST_MassAreaFaceTags = -2003410
    - OST_HostTemplate = -2003409
    - OST_MassFaceSplitter = -2003408
    - OST_MassCutter = -2003407
    - OST_ZoningEnvelope = -2003406
    - OST_MassTags = -2003405
    - OST_MassForm = -2003404
    - OST_MassFloor = -2003403
    - OST_Mass = -2003400
    - OST_DividedSurface_DiscardedDivisionLines = -2003333
    - OST_DividedSurfaceBelt = -2003332
    - OST_TilePatterns = -2003331
    - OST_AlwaysExcludedInAllViews = -2003330
    - OST_DividedSurface_TransparentFace = -2003329
    - OST_DividedSurface_PreDividedSurface = -2003328
    - OST_DividedSurface_PatternFill = -2003327
    - OST_DividedSurface_PatternLines = -2003326
    - OST_DividedSurface_Gridlines = -2003325
    - OST_DividedSurface_Nodes = -2003324
    - OST_DividedSurface = -2003323
    - OST_RepeatingDetailLines = -2003321
    - OST_RampsDownArrow = -2003308
    - OST_RampsUpArrow = -2003307
    - OST_RampsDownText = -2003306
    - OST_RampsUpText = -2003305
    - OST_RampsStringerAboveCut = -2003304
    - OST_RampsStringer = -2003303
    - OST_RampsAboveCut = -2003302
    - OST_RampsIncomplete = -2003301
    - OST_TrussDummy = -2003300
    - OST_ZoneSchemes = -2003225
    - OST_AreaSchemes = -2003201
    - OST_Areas = -2003200
    - OST_ProjectInformation = -2003101
    - OST_Sheets = -2003100
    - OST_ProfileFamilies = -2003000
    - OST_DetailComponents = -2002000
    - OST_RoofSoffit = -2001393
    - OST_EdgeSlab = -2001392
    - OST_Gutter = -2001391
    - OST_Fascia = -2001390
    - OST_Entourage = -2001370
    - OST_Planting = -2001360
    - OST_Blocks = -2001359
    - OST_StructuralStiffenerHiddenLines = -2001358
    - OST_StructuralColumnLocationLine = -2001357
    - OST_StructuralFramingLocationLine = -2001356
    - OST_StructuralStiffenerTags = -2001355
    - OST_StructuralStiffener = -2001354
    - OST_FootingAnalyticalGeometry = -2001353
    - OST_RvtLinks = -2001352
    - OST_Automatic = -2001351
    - OST_SpecialityEquipment = -2001350
    - OST_ColumnAnalyticalRigidLinks = -2001344
    - OST_SecondaryTopographyContours = -2001343
    - OST_TopographyContours = -2001342
    - OST_TopographySurface = -2001341
    - OST_Topography = -2001340
    - OST_TopographyLink = -2001339
    - OST_StructuralTruss = -2001336
    - OST_StructuralColumnStickSymbols = -2001335
    - OST_HiddenStructuralColumnLines = -2001334
    - OST_AnalyticalRigidLinks = -2001333
    - OST_ColumnAnalyticalGeometry = -2001332
    - OST_FramingAnalyticalGeometry = -2001331
    - OST_StructuralColumns = -2001330
    - OST_HiddenStructuralFramingLines = -2001329
    - OST_KickerBracing = -2001328
    - OST_StructuralFramingSystem = -2001327
    - OST_VerticalBracing = -2001326
    - OST_HorizontalBracing = -2001325
    - OST_Purlin = -2001324
    - OST_Joist = -2001323
    - OST_Girder = -2001322
    - OST_StructuralFramingOther = -2001321
    - OST_StructuralFraming = -2001320
    - OST_HiddenStructuralFoundationLines = -2001302
    - OST_StructuralFoundation = -2001300
    - OST_LinkBasePoint = -2001276
    - OST_BasePointAxisZ = -2001275
    - OST_BasePointAxisY = -2001274
    - OST_BasePointAxisX = -2001273
    - OST_SharedBasePoint = -2001272
    - OST_ProjectBasePoint = -2001271
    - OST_SiteRegion = -2001270
    - OST_SitePropertyLineSegmentTags = -2001269
    - OST_SitePropertyLineSegment = -2001268
    - OST_SitePropertyTags = -2001267
    - OST_SitePointBoundary = -2001266
    - OST_SiteProperty = -2001265
    - OST_BuildingPad = -2001263
    - OST_SitePoint = -2001262
    - OST_SiteSurface = -2001261
    - OST_Site = -2001260
    - OST_Sewer = -2001240
    - OST_RoadTags = -2001221
    - OST_Roads = -2001220
    - OST_Property = -2001200
    - OST_Parking = -2001180
    - OST_PlumbingFixtures = -2001160
    - OST_MechanicalEquipment = -2001140
    - OST_LightingFixtureSource = -2001121
    - OST_LightingFixtures = -2001120
    - OST_DuctAnalyticalSegmentTags = -2001116
    - OST_DuctAnalyticalSegments = -2001115
    - OST_PipeAnalyticalSegmentTags = -2001114
    - OST_PipeAnalyticalSegments = -2001113
    - OST_SheetCollections = -2001112
    - OST_DuctFlowDirectionSymbols_Obsolete = -2001111
    - OST_PipeFlowDirectionSymbols_Obsolete = -2001110
    - OST_RebarSpliceType = -2001109
    - OST_RebarSpliceLines = -2001108
    - OST_DataExchanges = -2001107
    - OST_FloorLayers = -2001106
    - OST_WallLayers = -2001105
    - OST_RebarBendingDetails = -2001104
    - OST_ToposolidLinkTags = -2001103
    - OST_ElectricalConnectorTags = -2001102
    - OST_ElectricalConnector = -2001101
    - OST_FurnitureSystems = -2001100
    - OST_ElectricalLoadCase = -2001099
    - OST_ElectricalLoadSet = -2001098
    - OST_ToposolidLink = -2001097
    - OST_ElectricalAnalyticalFeeder = -2001096
    - OST_ToposolidOpening = -2001095
    - OST_ToposolidTags = -2001094
    - OST_ToposolidInsulation = -2001093
    - OST_ToposolidSurfacePattern = -2001092
    - OST_ToposolidFinish2 = -2001091
    - OST_ToposolidFinish1 = -2001090
    - OST_ToposolidSubstrate = -2001089
    - OST_ToposolidStructure = -2001088
    - OST_ToposolidMembrane = -2001087
    - OST_ToposolidCutPattern = -2001086
    - OST_ToposolidDefault = -2001085
    - OST_ToposolidSplitLines = -2001084
    - OST_ToposolidFoldingLines = -2001083
    - OST_ToposolidSecondaryContours = -2001082
    - OST_ToposolidContours = -2001081
    - OST_ToposolidHiddenLines = -2001080
    - OST_Toposolid = -2001079
    - OST_ELECTRICAL_AreaBasedLoads_Tags = -2001078
    - OST_ElectricalAnalyticalTransformer = -2001077
    - OST_FloorsSplitLines = -2001076
    - OST_AnalyticalMemberCrossSection = -2001075
    - OST_RvtLinksTags = -2001074
    - OST_ModelGroupTags = -2001073
    - OST_WallSweepTags = -2001072
    - OST_TopRailTags = -2001071
    - OST_SlabEdgeTags = -2001070
    - OST_RoofSoffitTags = -2001069
    - OST_RampTags = -2001068
    - OST_PadTags = -2001067
    - OST_HandrailTags = -2001066
    - OST_GutterTags = -2001065
    - OST_EntourageTags = -2001064
    - OST_ColumnTags = -2001063
    - OST_FasciaTags = -2001062
    - OST_SignageTags = -2001061
    - OST_ElectricalFixtures = -2001060
    - OST_SignageHiddenLines = -2001059
    - OST_Signage = -2001058
    - OST_AudioVisualDeviceTags = -2001057
    - OST_AudioVisualDevicesHiddenLines = -2001056
    - OST_AudioVisualDevices = -2001055
    - OST_VerticalCirculationTags = -2001054
    - OST_VerticalCirculationHiddenLines = -2001053
    - OST_VerticalCirculation = -2001052
    - OST_FireProtectionTags = -2001051
    - OST_FireProtectionHiddenLines = -2001050
    - OST_FireProtection = -2001049
    - OST_MedicalEquipmentTags = -2001048
    - OST_MedicalEquipmentHiddenLines = -2001047
    - OST_MedicalEquipment = -2001046
    - OST_FoodServiceEquipmentTags = -2001045
    - OST_FoodServiceEquipmentHiddenLines = -2001044
    - OST_FoodServiceEquipment = -2001043
    - OST_TemporaryStructureTags = -2001042
    - OST_TemporaryStructureHiddenLines = -2001041
    - OST_ElectricalEquipment = -2001040
    - OST_TemporaryStructure = -2001039
    - OST_HardscapeTags = -2001038
    - OST_HardscapeHiddenLines = -2001037
    - OST_Hardscape = -2001036
    - OST_WallCoreLayer = -2001035
    - OST_WallNonCoreLayer = -2001034
    - OST_MEPLoadAreaSeparationLines = -2001033
    - OST_MEPLoadAreaReferenceVisibility = -2001031
    - OST_MEPLoadAreaInteriorFillVisibility = -2001030
    - OST_MEPLoadAreaReference = -2001029
    - OST_MEPLoadAreaInteriorFill = -2001028
    - OST_MEPLoadAreaColorFill = -2001027
    - OST_ElectricalPowerSource = -2001026
    - OST_MEPLoadAreaTags_OBSOLETE = -2001025
    - OST_MEPLoadAreas = -2001024
    - OST_MEPAnalyticalTransferSwitch = -2001023
    - OST_OBSOLETE_MEPAnalyticalElectricalBranch = -2001022
    - OST_MEPAnalyticalBus = -2001021
    - OST_ElectricalLoadZoneInstance = -2001020
    - OST_ElectricalLoadZoneType = -2001019
    - OST_ElectricalZoneEquipment_Obsolete = -2001018
    - OST_AlignmentStationLabels = -2001017
    - OST_AlignmentStationLabelSets = -2001016
    - OST_AlignmentsTags = -2001015
    - OST_MinorStations_Deprecated = -2001014
    - OST_MajorStations_Deprecated = -2001013
    - OST_Alignments = -2001012
    - OST_ElectricalCircuitNaming = -2001011
    - OST_ZoneEquipment = -2001010
    - OST_MEPAnalyticalWaterLoop = -2001009
    - OST_MEPAnalyticalAirLoop = -2001008
    - OST_MEPSystemZoneTags = -2001007
    - OST_MEPSystemZoneReferenceLinesVisibility = -2001006
    - OST_MEPSystemZoneInteriorFillVisibility = -2001005
    - OST_MEPSystemZoneReferenceLines = -2001004
    - OST_MEPSystemZoneInteriorFill = -2001003
    - OST_MEPSystemZoneBoundary = -2001002
    - OST_MEPSystemZone = -2001001
    - OST_Casework = -2001000
    - OST_ArcWallRectOpening = -2000999
    - OST_DormerOpeningIncomplete = -2000998
    - OST_SWallRectOpening = -2000997
    - OST_ShaftOpening = -2000996
    - OST_StructuralFramingOpening = -2000995
    - OST_ColumnOpening = -2000994
    - OST_RiseDropSymbols = -2000989
    - OST_PipeHydronicSeparationSymbols = -2000988
    - OST_MechanicalEquipmentSetBoundaryLines = -2000987
    - OST_MechanicalEquipmentSetTags = -2000986
    - OST_MechanicalEquipmentSet = -2000985
    - OST_AnalyticalPipeConnectionLineSymbol = -2000984
    - OST_AnalyticalPipeConnections = -2000983
    - OST_Coordination_Model = -2000982
    - OST_MultistoryStairs = -2000980
    - OST_HiddenStructuralConnectionLines_Deprecated = -2000979
    - OST_StructuralConnectionHandler_Deprecated = -2000978
    - OST_CoordinateSystem = -2000977
    - OST_FndSlabLocalCoordSys = -2000976
    - OST_FloorLocalCoordSys = -2000975
    - OST_WallLocalCoordSys = -2000974
    - OST_BraceLocalCoordSys = -2000973
    - OST_ColumnLocalCoordSys = -2000972
    - OST_BeamLocalCoordSys = -2000971
    - OST_MultiReferenceAnnotations = -2000970
    - OST_DSR_LeaderTickMarkStyleId = -2000969
    - OST_DSR_InteriorTickMarkStyleId = -2000968
    - OST_DSR_ArrowHeadStyleId = -2000967
    - OST_DSR_CenterlineTickMarkStyleId = -2000966
    - OST_DSR_CenterlinePatternCatId = -2000965
    - OST_DSR_DimStyleHeavyEndCategoryId = -2000964
    - OST_DSR_DimStyleHeavyEndCatId = -2000963
    - OST_DSR_DimStyleTickCategoryId = -2000962
    - OST_DSR_LineAndTextAttrFontId = -2000961
    - OST_DSR_LineAndTextAttrCategoryId = -2000960
    - OST_AnalyticalOpeningTags = -2000958
    - OST_AnalyticalPanelTags = -2000957
    - OST_NodeAnalyticalTags = -2000956
    - OST_LinkAnalyticalTags = -2000955
    - OST_RailingRailPathExtensionLines = -2000954
    - OST_RailingRailPathLines = -2000953
    - OST_StairsSupports = -2000952
    - OST_RailingHandRailAboveCut = -2000951
    - OST_RailingTopRailAboveCut = -2000950
    - OST_RailingTermination = -2000949
    - OST_RailingSupport = -2000948
    - OST_RailingHandRail = -2000947
    - OST_RailingTopRail = -2000946
    - OST_StairsSketchPathLines = -2000945
    - OST_StairsTriserNumbers = -2000944
    - OST_StairsTriserTags = -2000943
    - OST_StairsSupportTags = -2000942
    - OST_StairsLandingTags = -2000941
    - OST_StairsRunTags = -2000940
    - OST_StairsPathsAboveCut = -2000939
    - OST_StairsPaths = -2000938
    - OST_StairsRiserLinesAboveCut = -2000937
    - OST_StairsRiserLines = -2000936
    - OST_StairsOutlinesAboveCut = -2000935
    - OST_StairsOutlines = -2000934
    - OST_StairsNosingLinesAboveCut = -2000933
    - OST_StairsNosingLines = -2000932
    - OST_StairsCutMarksAboveCut = -2000931
    - OST_StairsCutMarks = -2000930
    - OST_ComponentRepeaterSlot = -2000928
    - OST_ComponentRepeater = -2000927
    - OST_DividedPath = -2000926
    - OST_IOSRoomCalculationPoint = -2000925
    - OST_PropertySet = -2000924
    - OST_AppearanceAsset = -2000923
    - OST_StairStringer2012_Deprecated = -2000922
    - OST_StairsTrisers = -2000921
    - OST_StairsLandings = -2000920
    - OST_StairsRuns = -2000919
    - OST_Stair2012_Deprecated = -2000918
    - OST_RailingSystemTags = -2000917
    - OST_RailingSystemTransition = -2000916
    - OST_RailingSystemTermination = -2000915
    - OST_RailingSystemRail = -2000914
    - OST_RailingSystemTopRail = -2000913
    - OST_RailingSystemHandRailBracket = -2000912
    - OST_RailingSystemHandRail = -2000911
    - OST_RailingSystemHardware = -2000910
    - OST_RailingSystemPanel = -2000909
    - OST_RailingSystemBaluster = -2000908
    - OST_RailingSystemPost = -2000907
    - OST_RailingSystemSegment = -2000906
    - OST_RailingSystem = -2000905
    - OST_AdaptivePoints_HiddenLines = -2000904
    - OST_AdaptivePoints_Lines = -2000903
    - OST_AdaptivePoints_Planes = -2000902
    - OST_AdaptivePoints_Points = -2000901
    - OST_AdaptivePoints = -2000900
    - OST_CeilingOpening = -2000899
    - OST_FloorOpening = -2000898
    - OST_RoofOpening = -2000897
    - OST_WallRefPlanes = -2000896
    - OST_StructLocationLineControl = -2000880
    - OST_PathOfTravelTags = -2000834
    - OST_PathOfTravelLines = -2000833
    - OST_DimLockControlLeader = -2000832
    - OST_MEPSpaceSeparationLines = -2000831
    - OST_AreaPolylines = -2000830
    - OST_RoomPolylines = -2000829
    - OST_InstanceDrivenLineStyle = -2000828
    - OST_RemovedGridSeg = -2000827
    - OST_IOSOpening = -2000810
    - OST_IOSTilePatternGrid = -2000800
    - OST_ControlLocal = -2000774
    - OST_ControlAxisZ = -2000773
    - OST_ControlAxisY = -2000772
    - OST_ControlAxisX = -2000721
    - OST_XRayConstrainedProfileEdge = -2000720
    - OST_XRayImplicitPathCurve = -2000719
    - OST_XRayPathPoint = -2000718
    - OST_XRayPathCurve = -2000717
    - OST_XRaySideEdge = -2000716
    - OST_XRayProfileEdge = -2000715
    - OST_ReferencePoints_HiddenLines = -2000714
    - OST_ReferencePoints_Lines = -2000713
    - OST_ReferencePoints_Planes = -2000712
    - OST_ReferencePoints_Points = -2000711
    - OST_ReferencePoints = -2000710
    - OST_Materials = -2000700
    - OST_CeilingsCutPattern = -2000617
    - OST_CeilingsDefault = -2000616
    - OST_CeilingsFinish2 = -2000615
    - OST_CeilingsFinish1 = -2000614
    - OST_CeilingsSubstrate = -2000613
    - OST_CeilingsInsulation = -2000612
    - OST_CeilingsStructure = -2000611
    - OST_CeilingsMembrane = -2000610
    - OST_FloorsInteriorEdges = -2000609
    - OST_FloorsCutPattern = -2000608
    - OST_HiddenFloorLines = -2000607
    - OST_FloorsDefault = -2000606
    - OST_FloorsFinish2 = -2000605
    - OST_FloorsFinish1 = -2000604
    - OST_FloorsSubstrate = -2000603
    - OST_FloorsInsulation = -2000602
    - OST_FloorsStructure = -2000601
    - OST_FloorsMembrane = -2000600
    - OST_RoofsInteriorEdges = -2000598
    - OST_RoofsCutPattern = -2000597
    - OST_RoofsDefault = -2000596
    - OST_RoofsFinish2 = -2000595
    - OST_RoofsFinish1 = -2000594
    - OST_RoofsSubstrate = -2000593
    - OST_RoofsInsulation = -2000592
    - OST_RoofsStructure = -2000591
    - OST_RoofsMembrane = -2000590
    - OST_WallsCutPattern = -2000588
    - OST_HiddenWallLines = -2000587
    - OST_WallsDefault = -2000586
    - OST_WallsFinish2 = -2000585
    - OST_WallsFinish1 = -2000584
    - OST_WallsSubstrate = -2000583
    - OST_WallsInsulation = -2000582
    - OST_WallsStructure = -2000581
    - OST_WallsMembrane = -2000580
    - OST_PreviewLegendComponents = -2000576
    - OST_LegendComponents = -2000575
    - OST_Schedules = -2000573
    - OST_ScheduleGraphics = -2000570
    - OST_RasterImages = -2000560
    - OST_ColorFillSchema = -2000552
    - OST_RoomColorFill = -2000551
    - OST_ColorFillLegends = -2000550
    - OST_AnnotationCropSpecial = -2000549
    - OST_CropBoundarySpecial = -2000548
    - OST_AnnotationCrop = -2000547
    - OST_FloorsAnalyticalGeometry = -2000546
    - OST_WallsAnalyticalGeometry = -2000545
    - OST_CalloutLeaderLine = -2000544
    - OST_CeilingsSurfacePattern = -2000543
    - OST_RoofsSurfacePattern = -2000542
    - OST_FloorsSurfacePattern = -2000541
    - OST_WallsSurfacePattern = -2000540
    - OST_CalloutBoundary = -2000539
    - OST_CalloutHeads = -2000538
    - OST_Callouts = -2000537
    - OST_CropBoundary = -2000536
    - OST_Elev = -2000535
    - OST_AxisZ = -2000533
    - OST_AxisY = -2000532
    - OST_AxisX = -2000531
    - OST_CLines = -2000530
    - OST_Lights = -2000520
    - OST_ViewportLabel = -2000515
    - OST_Viewports = -2000510
    - OST_Camera_Lines = -2000501
    - OST_Cameras = -2000500
    - OST_MEPSpaceTags = -2000485
    - OST_RoomTags = -2000480
    - OST_DoorTags = -2000460
    - OST_WindowTags = -2000450
    - OST_SectionHeadWideLines = -2000404
    - OST_SectionHeadMediumLines = -2000403
    - OST_SectionHeadThinLines = -2000401
    - OST_SectionHeads = -2000400
    - OST_ContourLabels = -2000350
    - OST_CurtaSystemFaceManager = -2000341
    - OST_CurtaSystem = -2000340
    - OST_AreaReport_Arc_Minus = -2000328
    - OST_AreaReport_Arc_Plus = -2000327
    - OST_AreaReport_Boundary = -2000326
    - OST_AreaReport_Triangle = -2000325
    - OST_CurtainGridsCurtaSystem = -2000323
    - OST_CurtainGridsSystem = -2000322
    - OST_CurtainGridsWall = -2000321
    - OST_CurtainGridsRoof = -2000320
    - OST_HostFinHF = -2000315
    - OST_HostFinWall = -2000314
    - OST_HostFinCeiling = -2000313
    - OST_HostFinRoof = -2000312
    - OST_HostFinFloor = -2000311
    - OST_HostFin = -2000310
    - OST_AnalysisDisplayStyle = -2000304
    - OST_AnalysisResults = -2000303
    - OST_RenderRegions = -2000302
    - OST_SectionBox = -2000301
    - OST_TextNotes = -2000300
    - OST_Divisions = -2000291
    - OST_Catalogs = -2000290
    - OST_DirectionEdgeLines = -2000289
    - OST_CenterLines = -2000288
    - OST_LinesBeyond = -2000287
    - OST_HiddenLines = -2000286
    - OST_DemolishedLines = -2000285
    - OST_OverheadLines = -2000284
    - OST_TitleBlockWideLines = -2000283
    - OST_TitleBlockMediumLines = -2000282
    - OST_TitleBlockThinLines = -2000281
    - OST_TitleBlocks = -2000280
    - OST_Views = -2000279
    - OST_Viewers = -2000278
    - OST_PartHiddenLines = -2000271
    - OST_PartTags = -2000270
    - OST_Parts = -2000269
    - OST_AssemblyTags = -2000268
    - OST_Assemblies = -2000267
    - OST_RoofTags = -2000266
    - OST_SpotSlopes = -2000265
    - OST_SpotCoordinates = -2000264
    - OST_SpotElevations = -2000263
    - OST_Constraints = -2000262
    - OST_WeakDims = -2000261
    - OST_Dimensions = -2000260
    - OST_Levels = -2000240
    - OST_DisplacementPath = -2000223
    - OST_DisplacementElements = -2000222
    - OST_GridChains = -2000221
    - OST_Grids = -2000220
    - OST_BrokenSectionLine = -2000202
    - OST_SectionLine = -2000201
    - OST_Sections = -2000200
    - OST_ReferenceViewer = -2000198
    - OST_ReferenceViewerSymbol = -2000197
    - OST_ImportObjectStyles = -2000196
    - OST_ModelText = -2000195
    - OST_MaskingRegion = -2000194
    - OST_Matchline = -2000193
    - OST_FaceSplitter = -2000192
    - OST_PlanRegion = -2000191
    - OST_FilledRegion = -2000190
    - OST_MassingProjectionOutlines = -2000187
    - OST_MassingCutOutlines = -2000186
    - OST_Massing = -2000185
    - OST_Reveals = -2000182
    - OST_Cornices = -2000181
    - OST_Ramps = -2000180
    - OST_RailingBalusterRailCut = -2000177
    - OST_RailingBalusterRail = -2000176
    - OST_Railings = -2000175
    - OST_CurtainGrids = -2000173
    - OST_CurtainWallMullionsCut = -2000172
    - OST_CurtainWallMullions = -2000171
    - OST_CurtainWallPanels = -2000170
    - OST_AreaReference = -2000169
    - OST_AreaInteriorFill = -2000168
    - OST_RoomReference = -2000167
    - OST_RoomInteriorFill = -2000166
    - OST_AreaColorFill = -2000165
    - OST_AreaReferenceVisibility = -2000164
    - OST_AreaInteriorFillVisibility = -2000163
    - OST_RoomReferenceVisibility = -2000162
    - OST_RoomInteriorFillVisibility = -2000161
    - OST_Rooms = -2000160
    - OST_GenericModel = -2000151
    - OST_GenericAnnotation = -2000150
    - OST_Fixtures = -2000140
    - OST_StairsRailingTags = -2000133
    - OST_StairsRailingAboveCut = -2000132
    - OST_StairsDownArrows = -2000131
    - OST_StairsUpArrows = -2000130
    - OST_StairsDownText = -2000129
    - OST_StairsRailingRail = -2000128
    - OST_StairsRailingBaluster = -2000127
    - OST_StairsRailing = -2000126
    - OST_StairsUpText = -2000125
    - OST_StairsSupportsAboveCut = -2000124
    - OST_StairsStringerCarriage = -2000123
    - OST_StairsAboveCut_ToBeDeprecated = -2000122
    - OST_StairsIncomplete_Deprecated = -2000121
    - OST_Stairs = -2000120
    - OST_IOSNavWheelPivotBall = -2000117
    - OST_IOSRoomComputationHeight = -2000116
    - OST_IOSRoomUpperLowerLines = -2000115
    - OST_IOSDragBoxInverted = -2000114
    - OST_IOSDragBox = -2000113
    - OST_Phases = -2000112
    - OST_IOS_GeoSite = -2000111
    - OST_IOS_GeoLocations = -2000110
    - OST_IOSFabricReinSpanSymbolCtrl = -2000109
    - OST_GuideGrid = -2000107
    - OST_EPS_Future = -2000106
    - OST_EPS_Temporary = -2000105
    - OST_EPS_New = -2000104
    - OST_EPS_Demolished = -2000103
    - OST_EPS_Existing = -2000102
    - OST_IOSMeasureLineScreenSize = -2000101
    - OST_Columns = -2000100
    - OST_IOSRebarSystemSpanSymbolCtrl = -2000099
    - OST_IOSRoomTagToRoomLines = -2000098
    - OST_IOSAttachedDetailGroups = -2000097
    - OST_IOSDetailGroups = -2000096
    - OST_IOSModelGroups = -2000095
    - OST_IOSSuspendedSketch = -2000094
    - OST_IOSWallCoreBoundary = -2000093
    - OST_IOSMeasureLine = -2000092
    - OST_IOSArrays = -2000091
    - OST_Curtain_Systems = -2000090
    - OST_IOSBBoxScreenSize = -2000089
    - OST_IOSSlabShapeEditorPointInterior = -2000088
    - OST_IOSSlabShapeEditorPointBoundary = -2000087
    - OST_IOSSlabShapeEditorBoundary = -2000086
    - OST_IOSSlabShapeEditorAutoCrease = -2000085
    - OST_IOSSlabShapeEditorExplitCrease = -2000084
    - OST_ReferenceLines = -2000083
    - OST_IOSNotSilhouette = -2000082
    - OST_FillPatterns = -2000081
    - OST_Furniture = -2000080
    - OST_AreaSchemeLines = -2000079
    - OST_GenericLines = -2000078
    - OST_InsulationLines = -2000077
    - OST_CloudLines = -2000076
    - OST_IOSRoomPerimeterLines = -2000075
    - OST_IOSCuttingGeometry = -2000074
    - OST_IOSCrashGraphics = -2000073
    - OST_IOSGroups = -2000072
    - OST_IOSGhost = -2000071
    - OST_StairsSketchLandingCenterLines = -2000070
    - OST_StairsSketchRunLines = -2000069
    - OST_StairsSketchRiserLines = -2000068
    - OST_StairsSketchBoundaryLines = -2000067
    - OST_RoomSeparationLines = -2000066
    - OST_AxisOfRotation = -2000065
    - OST_InvisibleLines = -2000064
    - OST_IOSThinPixel_DashDot = -2000063
    - OST_IOSThinPixel_Dash = -2000062
    - OST_IOSThinPixel_Dot = -2000061
    - OST_Extrusions = -2000060
    - OST_IOS = -2000059
    - OST_CutOutlines = -2000058
    - OST_IOSThinPixel = -2000057
    - OST_IOSFlipControl = -2000056
    - OST_IOSSketchGrid = -2000055
    - OST_IOSSuspendedSketch_obsolete = -2000054
    - OST_IOSFreeSnapLine = -2000053
    - OST_IOSDatumPlane = -2000052
    - OST_Lines = -2000051
    - OST_IOSConstructionLine = -2000050
    - OST_IOSAlignmentGraphics = -2000049
    - OST_IOSAligningLine = -2000048
    - OST_IOSBackedUpElements = -2000047
    - OST_IOSRegeneratedElements = -2000046
    - OST_SketchLines = -2000045
    - OST_CurvesWideLines = -2000044
    - OST_CurvesMediumLines = -2000043
    - OST_CurvesThinLines = -2000042
    - OST_Curves = -2000041
    - OST_CeilingsProjection = -2000040
    - OST_CeilingsCut = -2000039
    - OST_Ceilings = -2000038
    - OST_RoofsProjection = -2000037
    - OST_RoofsCut = -2000036
    - OST_Roofs = -2000035
    - OST_FloorsProjection = -2000034
    - OST_FloorsCut = -2000033
    - OST_Floors = -2000032
    - OST_DoorsGlassProjection = -2000031
    - OST_DoorsGlassCut = -2000030
    - OST_DoorsFrameMullionProjection = -2000029
    - OST_DoorsFrameMullionCut = -2000028
    - OST_DoorsOpeningProjection = -2000027
    - OST_DoorsOpeningCut = -2000026
    - OST_DoorsPanelProjection = -2000025
    - OST_DoorsPanelCut = -2000024
    - OST_Doors = -2000023
    - OST_WindowsOpeningProjection = -2000022
    - OST_WindowsOpeningCut = -2000021
    - OST_WindowsSillHeadProjection = -2000020
    - OST_WindowsSillHeadCut = -2000019
    - OST_WindowsFrameMullionProjection = -2000018
    - OST_WindowsFrameMullionCut = -2000017
    - OST_WindowsGlassProjection = -2000016
    - OST_WindowsGlassCut = -2000015
    - OST_Windows = -2000014
    - OST_WallsProjectionOutlines = -2000013
    - OST_WallsCutOutlines = -2000012
    - OST_Walls = -2000011
    - OST_IOSRegenerationFailure = -2000010
    - OST_ScheduleViewParamGroup = -2000008
    - OST_MatchSiteComponent = -2000007
    - OST_MatchProfile = -2000006
    - OST_MatchDetail = -2000005
    - OST_MatchAnnotation = -2000004
    - OST_MatchModel = -2000003
    - OST_MatchAll = -2000002
    - INVALID = -1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] BuiltInFailures
Full Name: Autodesk.Revit.DB.BuiltInFailures
Description: Provides a container of all Revit built-in FailureDefinitionId instances.

--------------------------------------------------------------------------------

[ENUM] BuiltInParameter
Full Name: Autodesk.Revit.DB.BuiltInParameter
Description: An enumerated type listing all of the built-in parameter IDs supported by Autodesk Revit.
Remarks: The ID of the parameter can be used to retrieve property values from an Element by using the Element.Parameter property. The documentation for each ID includes the parameter name, as found in the Element Properties dialog in the English version of Autodesk Revit. Note that multiple distinct parameter ids may map to the same English name; in those case you must examine the parameters associated with a specific element to determine which parameter id to use.
Inherits: Enum

  Values:
    - ALLOW_MULTIPLE_SELECTION = -1612357
    - ELLIPSE_MODIFICATION_KEEPS_RATIO = -1612354
    - ANALYTICAL_NODE_CAN_BE_HOSTED = -1180421
    - ANALYTICAL_NODE_TYPE = -1180420
    - REBAR_STAGGERED_SET = -1180415
    - REBAR_MAXIMUM_NUMBER = -1180414
    - REBAR_MINIMUM_NUMBER = -1180413
    - REBAR_SPLICE_SHIFT_BARS = -1180412
    - REBAR_SPLICE_STAGGER_LENGTH_MULTIPLIER = -1180411
    - REBAR_STAGGER_OFFSET_AT_END = -1180410
    - REBAR_STAGGER_OFFSET_AT_START = -1180409
    - SPLICE_TYPE_AT_END = -1180408
    - SPLICE_TYPE_AT_START = -1180407
    - SPLICE_LAP_LENGTH_AT_END = -1180406
    - SPLICE_LAP_LENGTH_AT_START = -1180405
    - SPLICE_BY_RULES_RUNOUT = -1180404
    - SPLICE_BY_RULES_MIN_LENGTH = -1180403
    - SPLICE_BY_RULES_MAX_LENGTH = -1180402
    - REBAR_SPLICE_SPLICE_LINE_POSITION = -1180401
    - REBAR_SPLICE_LAP_LENGTH_MULTIPLIER = -1180400
    - STEEL_ELEM_SINGLE_PART_MARK = -1180319
    - STEEL_ELEM_MARK = -1180318
    - BENDINGDETAIL_POSITION = -1180317
    - TAG_HEAD_ALIGNMENT = -1180310
    - REBAR_BAR_SPLICE_LENGTHS = -1180309
    - EXCAVATION_VOLUME_ON_TOPOSOLID = -1180308
    - TOTAL_EXCAVATION_VOLUME = -1180307
    - EXCAVATION_VOLUME = -1180306
    - EXCAVATION_ELEMENT_FAMILY_AND_TYPE = -1180305
    - EXCAVATION_ELEMENT_ID = -1180304
    - INDIVIDUAL_EXCAVATION_VOLUME = -1180303
    - TAG_HEAD_POSITION = -1180302
    - REBAR_CONSTRAINTS_STATUS = -1180301
    - TOPOSOLID_FACES_LOCATION = -1180201
    - FAMILY_USING_MULTIPLE = -1180200
    - USING_MULTIPLE = -1180000
    - PLACEMENT_TOP = -1166006
    - PLACEMENT_RIGHT = -1166005
    - PLACEMENT_BOTTOM = -1166004
    - PLACEMENT_LEFT = -1166003
    - PLACEMENT_CENTER_Y = -1166002
    - PLACEMENT_CENTER_X = -1166001
    - PLACEMENT_PARAMS_SHOW = -1166000
    - EXCHANGE_ENTITY_ID = -1155401
    - EXCHANGE_ID = -1155400
    - TAG_ORIENTATION_BEHAVIOR = -1155321
    - FAMILY_NESTING_BEHAVIOR = -1155320
    - BENDING_DETAIL_TYPE_SCHEMATIC_HEIGHT = -1155318
    - BENDING_DETAIL_TYPE_SCHEMATIC_WIDTH = -1155317
    - BENDING_DETAIL_TYPE_TAG_TYPE_ID = -1155315
    - BLEND_DEPTH_PARAM = -1155314
    - BENDING_DETAIL_DETAIL_LEVEL = -1155313
    - BENDING_DETAIL_ANGULAR_DIMENSION_TEXT_POSITION = -1155312
    - BENDING_DETAIL_SEGMENT_LENGTH_DIMENSION_TEXT_POSITION = -1155311
    - BENDING_DETAIL_SEGMENT_REPRESENTATION = -1155310
    - BENDING_DETAIL_VARYING_REBAR_DIMENSION = -1155309
    - BENDING_DETAIL_REPRESENTATION_FOR_3D_BARS = -1155308
    - BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_MEASUREMENT = -1155307
    - BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_FOR_HOOKS_ENABLED = -1155306
    - BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_FOR_HOOKS_ENABLED = -1155305
    - BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_FOR_SEGMENTS_ENABLED = -1155304
    - BENDING_DETAIL_TYPE_SHOW_BAR_BENDING_USING = -1155302
    - BENDING_DETAIL_TYPE_DIAMETER_DIMENSION_TYPE_ID = -1155301
    - BENDING_DETAIL_TYPE_RADIAL_DIMENSION_TYPE_ID = -1155300
    - BENDING_DETAIL_TYPE_BEND_DIAMETER_DIMENSIONS_ENABLED = -1155299
    - BENDING_DETAIL_TYPE_ANGULAR_DIMENSION_OFFSET = -1155298
    - BENDING_DETAIL_TYPE_SHOW_ANGULAR_DIMENSIONS_FOR = -1155297
    - BENDING_DETAIL_TYPE_ANGULAR_DIMENSION_TYPE_ID = -1155296
    - BENDING_DETAIL_TYPE_ANGULAR_DIMENSIONS_ENABLED = -1155295
    - BENDING_DETAIL_TYPE_ORTHOGONAL_AND_OVERALL_DIMESIONS_ENABLED = -1155294
    - BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_FOR_HOOKS_ENABLED = -1155293
    - BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_OFFSET = -1155292
    - BENDING_DETAIL_TYPE_SEGMENT_LENGTHS_DISPLAY_OPTION = -1155291
    - BENDING_DETAIL_TYPE_SEGMENT_LENGTHS_FOR_ARCS_DISPLAY_OPTION = -1155290
    - BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSION_TYPE_ID = -1155289
    - BENDING_DETAIL_TYPE_SEGMENT_LENGTH_DIMENSIONS_ENABLED = -1155288
    - SSE_POINT_OFFSET_FROM_SNAPS = -1155285
    - LOAD_IS_CONSTRAINED_ON_HOST = -1155284
    - REBAR_ALIGNMENT_OPTIONS = -1155283
    - SCHEDULE_ROW_HEIGHT_INPUT = -1155282
    - SCHEDULE_RESIZE_ROWS = -1155281
    - SCHEDULE_ROTATION_ON_SHEET = -1155280
    - LAYER_ELEM_SCHEDULE_FAMILY = -1155279
    - LAYER_ELEM_IS_VARIABLE = -1155278
    - LAYER_ELEM_IS_STRUCTURAL_MATERIAL = -1155277
    - LAYER_ELEM_IS_CORE_LAYER = -1155276
    - LAYER_ELEM_COMPOUND_ELEM_TYPE = -1155275
    - LAYER_ELEM_COMPOUND_ELEM_FAMILY = -1155274
    - SSE_POINT_ELEVATION_BASE_TYPE = -1155273
    - SSE_POINT_ELEVATION = -1155272
    - SSE_POINT_OFFSET_FROM_SURFACE = -1155271
    - SSE_POINT_BASETYPE_ENUM = -1155270
    - TOPOSOLID_CONTOUR_SUBCATEGORY_ID = -1155269
    - TOPOSOLID_CONTOUR_DISPLAY_SETTINGS_ID_PARAM = -1155268
    - TOPOSOLID_SUBDIVIDE_MATERIAL = -1155267
    - TOPOSOLID_SUBDIVIDE_HEIGHT = -1155266
    - TOPOSOLID_INHERIT_CONTOURS = -1155265
    - TOPOSOLID_FUNCTION_PARAM = -1155264
    - PREFER_PATTERN_ALIGN_UI_FILTER = -1155263
    - TOPOSOLID_ELEVATION_AT_TOP = -1155261
    - TOPOSOLID_ELEVATION_AT_BOTTOM = -1155260
    - TOPOSOLID_STRUCTURE_ID_PARAM = -1155259
    - LOWEST_ASSOCIATED_LEVEL = -1155257
    - HIGHEST_ASSOCIATED_LEVEL = -1155256
    - TOPOSOLID_HEIGHTABOVELEVEL_PARAM = -1155255
    - TOPOSOLID_ATTR_THICKNESS_PARAM = -1155254
    - TOPOSOLID_TYPE_DEFAULT_THICKNESS_PARAM = -1155253
    - OFFSET_FROM_REFERENCE_BASE = -1155252
    - REFERENCE_BASE_ON_HOST = -1155251
    - OVAL_FRAMING_HEIGHT = -1155250
    - OVAL_FRAMING_WIDTH = -1155249
    - CIRCULAR_FRAMING_DIAMETER = -1155248
    - LINEAR_FRAMING_LENGTH = -1155247
    - FRAMING_SHAPE_CLASSIFICATION = -1155246
    - STIFFENER_CLASSIFICATION = -1155245
    - FAMILY_SELF_ORIENTING = -1155244
    - COUPLER_ROTATION_ANGLE = -1155243
    - PREFER_DIM_SIDE_UI_FILTER = -1155242
    - MULTIPLE_ALIGNMENT_UI_TOGGLE = -1155241
    - LOCK_ALIGNMENT_UI_TOGGLE = -1155240
    - LAYER_ELEM_BASE_EXTENSION_DIS = -1155239
    - LAYER_ELEM_TOP_EXTENSION_DIS = -1155238
    - LAYER_ELEM_FUNCTION = -1155237
    - LAYER_ELEM_MATERIALS = -1155236
    - LAYER_ELEM_THICKNESS = -1155235
    - LAYER_ELEM_AREA_COMPUTED = -1155234
    - LAYER_ELEM_OFFSET_FROM_HOST = -1155233
    - LAYER_ELEM_VOLUME_COMPUTED = -1155232
    - LAYER_TYPE_MATERIALS = -1155231
    - LAYER_TYPE_THICKNESS = -1155230
    - LAYER_ELEM_BASE_CONSTRAINT = -1155229
    - LAYER_ELEM_TOP_CONSTRAINT = -1155228
    - REBAR_INSTANCE_BAR_MODEL_DIAMETER = -1155224
    - REBAR_MODEL_BAR_DIAMETER = -1155223
    - VIEW_SHOW_GRIDS = -1155222
    - REBAR_MODIFIED_SET = -1155221
    - MOVES_WITH_GRID_PARAM = -1155220
    - DPART_LAYER_INDEX = -1155219
    - VOID_CUTS_GEOMETRY = -1155218
    - REBAR_HOOK_ROTATION_AT_END_SCHEDULES_TAGS_FILTERS = -1155217
    - REBAR_HOOK_ROTATION_AT_START_SCHEDULES_TAGS_FILTERS = -1155216
    - REBAR_HOOK_LENGTH_OVERRIDE = -1155215
    - INFRASTRUCTURE_ALIGNMENT_NAME = -1155214
    - INFRASTRUCTURE_ALIGNMENT_DESCRIPTION = -1155213
    - INFRASTRUCTURE_ALIGNMENT_DISPLAYED_START_STATION = -1155212
    - INFRASTRUCTURE_ALIGNMENT_DISPLAYED_END_STATION = -1155211
    - ASSEMBLY_PRECAST_FREEZE = -1155210
    - REBAR_HOOK_ROTATION_AT_END = -1155206
    - REBAR_HOOK_ROTATION_AT_START = -1155205
    - REBAR_SHAPE_HOOK_ROTATION_AT_END = -1155204
    - REBAR_SHAPE_HOOK_ROTATION_AT_START = -1155203
    - PATH_OF_TRAVEL_FROM_ROOM = -1155202
    - PATH_OF_TRAVEL_TO_ROOM = -1155201
    - RBS_ELEC_MAX_CIRCUITS_DATA_PANEL = -1155152
    - RBS_ELEC_ANALYTICAL_TOTAL_COINCIDENT_LOAD = -1155151
    - RBS_ELEC_NUMBER_OF_CIRCUITS = -1155150
    - STEEL_ELEM_PROFILE_VOLUME = -1155148
    - STEEL_ELEM_PROFILE_LENGTH = -1155147
    - STEEL_ELEM_PROFILE_TYPE = -1155146
    - RBS_ELEC_EDIT_CIRCUIT_NAMING_SETTINGS_PARAM = -1155145
    - STEEL_ELEM_PLATE_JUSTIFICATION = -1155144
    - STEEL_ELEM_PLATE_PAINT_AREA = -1155143
    - STEEL_ELEM_PLATE_EXACT_WEIGHT = -1155142
    - STEEL_ELEM_PLATE_WEIGHT = -1155141
    - STEEL_ELEM_PLATE_VOLUME = -1155140
    - STEEL_ELEM_PLATE_AREA = -1155139
    - STEEL_ELEM_PLATE_WIDTH = -1155138
    - STEEL_ELEM_PLATE_LENGTH = -1155137
    - STEEL_ELEM_PLATE_TYPE = -1155136
    - STEEL_ELEM_BOLT_TOTAL_WEIGHT = -1155135
    - STEEL_ELEM_SHEARSTUD_TOTAL_WEIGHT = -1155134
    - STEEL_ELEM_ANCHOR_TOTAL_WEIGHT = -1155132
    - STEEL_ELEM_ANCHOR_ORIENTATION = -1155130
    - STEEL_ELEM_CUT_LENGTH = -1155128
    - STEEL_ELEM_EXACT_WEIGHT = -1155127
    - STEEL_ELEM_PAINT_AREA = -1155125
    - STEEL_ELEM_WEIGHT = -1155124
    - PATH_OF_TRAVEL_SPEED = -1155123
    - STEEL_ELEM_BOLT_LOCATION = -1155122
    - STEEL_ELEM_BOLT_FINISH_CALCULATION_AT_GAP = -1155121
    - STEEL_ELEM_BOLT_INVERTED = -1155120
    - STEEL_ELEM_BOLT_GRIP_LENGTH_INCREASE = -1155119
    - STEEL_ELEM_BOLT_GRIP_LENGTH = -1155118
    - STEEL_ELEM_BOLT_LENGTH = -1155117
    - GENERIC_ZONE_NAME = -1155116
    - RBS_PIPE_BOTTOM_ELEVATION = -1155115
    - RBS_PIPE_TOP_ELEVATION = -1155114
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEC = -1155113
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEB = -1155112
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEA = -1155111
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEC = -1155110
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEB = -1155109
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEA = -1155108
    - RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEC = -1155107
    - RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEB = -1155106
    - RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEA = -1155105
    - RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEC = -1155104
    - RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEB = -1155103
    - RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEA = -1155102
    - STEEL_ELEM_HOLE_DEFINITION = -1155101
    - RBS_ELEC_PANEL_FEED_THRU_LUGS_PARAM = -1155100
    - RBS_ELEC_CIRCUIT_NUMBERING_TYPE = -1155099
    - TAG_ON_PLACEMENT_UI = -1155096
    - ROUTE_ANALYSIS_SETTINGS_PARAM = -1155095
    - PATH_OF_TRAVEL_VIEW_NAME = -1155094
    - PATH_OF_TRAVEL_LEVEL_NAME = -1155093
    - STRUCTURAL_CONNECTION_OVERRIDE_TYPE = -1155092
    - STRUCTURAL_CONNECTION_EDIT_TYPE = -1155091
    - PATH_OF_TRAVEL_TIME = -1155090
    - STEEL_ELEM_ZCLIP_TYPE = -1155087
    - STEEL_ELEM_COPE_AROUND_AXIS = -1155086
    - STEEL_ELEM_COPE_AXIS_ANGLE = -1155085
    - STEEL_ELEM_COPE_Z_ANGLE = -1155084
    - STEEL_ELEM_COPE_X_ANGLE = -1155083
    - STEEL_ELEM_COPE_DISTANCE_AXIS = -1155082
    - STEEL_ELEM_COPE_WIDTHX = -1155081
    - STEEL_ELEM_Y_DISTANCE = -1155080
    - STEEL_ELEM_X_DISTANCE = -1155079
    - STEEL_ELEM_CUT_TYPE = -1155078
    - STEEL_ELEM_PLATE_SHORTEN_CUTSTRAIGHT = -1155077
    - STEEL_ELEM_PLATE_SHORTEN_SUCTION = -1155076
    - STEEL_ELEM_PLATE_SHORTEN_ANGLE = -1155075
    - STEEL_ELEM_WELD_PREFIX = -1155074
    - STEEL_ELEM_WELD_TEXT_MODULE = -1155073
    - STEEL_ELEM_HOLE_DEPTH_OF_BOLT_HEAD = -1155072
    - STEEL_ELEM_HOLE_TAPPING = -1155071
    - STEEL_ELEM_HOLE_BACK_TAPER_THREAD = -1155070
    - STEEL_ELEM_HOLE_TAPPING_HOLE = -1155069
    - STEEL_ELEM_HOLE_HEAD_DIAMETER = -1155068
    - STEEL_ELEM_HOLE_ANGLE = -1155067
    - STEEL_ELEM_HOLE_ALPHA = -1155066
    - STEEL_ELEM_HOLE_DEPTH = -1155065
    - STEEL_ELEM_HOLE_SLOT_DIRECTION = -1155064
    - STEEL_ELEM_HOLE_SLOT_LENGTH = -1155063
    - STEEL_ELEM_HOLE_TYPE = -1155062
    - STEEL_ELEM_HOLE_DIAMETER = -1155061
    - STEEL_ELEM_PATTERN_NUMBER = -1155060
    - STEEL_ELEM_PATTERN_RADIUS = -1155059
    - STEEL_ELEM_PATTERN_EDGE_DISTANCE_Y = -1155058
    - STEEL_ELEM_PATTERN_EDGE_DISTANCE_X = -1155057
    - STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_Y = -1155056
    - STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_X = -1155055
    - STEEL_ELEM_PATTERN_TOTAL_WIDTH = -1155054
    - STEEL_ELEM_PATTERN_TOTAL_LENGTH = -1155053
    - STEEL_ELEM_PATTERN_NUMBER_Y = -1155052
    - STEEL_ELEM_PATTERN_NUMBER_X = -1155051
    - STEEL_ELEM_WELD_DOUBLE_PREPDEPTH = -1155050
    - STEEL_ELEM_WELD_DOUBLE_EFFECTIVETHROAT = -1155049
    - STEEL_ELEM_WELD_DOUBLE_ROOTOPENING = -1155048
    - STEEL_ELEM_WELD_DOUBLE_WELDPREP = -1155047
    - STEEL_ELEM_WELD_DOUBLE_SURFACESHAPE = -1155046
    - STEEL_ELEM_WELD_DOUBLE_TEXT = -1155045
    - STEEL_ELEM_WELD_DOUBLE_THICKNESS = -1155044
    - STEEL_ELEM_WELD_DOUBLE_TYPE = -1155043
    - STEEL_ELEM_WELD_MAIN_PREPDEPTH = -1155042
    - STEEL_ELEM_WELD_MAIN_EFFECTIVETHROAT = -1155041
    - STEEL_ELEM_WELD_MAIN_ROOTOPENING = -1155040
    - STEEL_ELEM_WELD_MAIN_WELDPREP = -1155039
    - STEEL_ELEM_WELD_MAIN_SURFACESHAPE = -1155038
    - STEEL_ELEM_WELD_MAIN_TEXT = -1155037
    - STEEL_ELEM_WELD_PITCH = -1155036
    - STEEL_ELEM_WELD_CONTINUOUS = -1155035
    - STEEL_ELEM_WELD_LOCATION = -1155034
    - STEEL_ELEM_WELD_LENGTH = -1155033
    - STEEL_ELEM_WELD_MAIN_THICKNESS = -1155032
    - STEEL_ELEM_WELD_MAIN_TYPE = -1155031
    - STEEL_ELEM_PARAM_BORINGOUT = -1155029
    - STEEL_ELEM_PARAM_RADIUS = -1155028
    - STEEL_ELEM_CONTOUR_SIDE2DIST = -1155027
    - STEEL_ELEM_CONTOUR_SIDE1DIST = -1155026
    - STEEL_ELEM_CONTOUR_GAP_WIDTH = -1155023
    - STEEL_ELEM_SHORTEN_ANGLEZ = -1155022
    - STEEL_ELEM_SHORTEN_ANGLEY = -1155021
    - STEEL_ELEM_SHORTEN_REFLENGTH = -1155020
    - STEEL_ELEM_SHEARSTUD_LENGTH = -1155019
    - STEEL_ELEM_BOLT_COATING = -1155018
    - STEEL_ELEM_ANCHOR_LENGTH = -1155017
    - STEEL_ELEM_SHEARSTUD_DIAMETER = -1155016
    - STEEL_ELEM_SHEARSTUD_GRADE = -1155015
    - STEEL_ELEM_SHEARSTUD_STANDARD = -1155014
    - STEEL_ELEM_ANCHOR_DIAMETER = -1155013
    - STEEL_ELEM_ANCHOR_ASSEMBLY = -1155012
    - STEEL_ELEM_ANCHOR_GRADE = -1155011
    - STEEL_ELEM_ANCHOR_STANDARD = -1155010
    - STEEL_ELEM_COATING = -1155009
    - STEEL_ELEM_BOLT_DIAMETER = -1155008
    - STEEL_ELEM_BOLT_ASSEMBLY = -1155007
    - STEEL_ELEM_BOLT_GRADE = -1155006
    - STEEL_ELEM_BOLT_STANDARD = -1155005
    - STEEL_ELEM_PLATE_THICKNESS = -1155003
    - REBAR_WORKSHOP_INSTRUCTIONS = -1154695
    - REBAR_GEOMETRY_TYPE = -1154694
    - BASEPOINT_LATITUDE_PARAM = -1154693
    - BASEPOINT_LONGITUDE_PARAM = -1154692
    - REBAR_FREE_FORM_HOOK_END_PLANE_ANGLE = -1154691
    - REBAR_FREE_FORM_HOOK_START_PLANE_ANGLE = -1154690
    - ROOM_OUTDOOR_AIRFLOW_PARAM = -1154689
    - ROOM_OUTDOOR_AIRFLOW_STANDARD_PARAM = -1154687
    - DIRECTCONTEXT3D_SOURCE_ID = -1154686
    - DIRECTCONTEXT3D_APPLICATION_ID = -1154685
    - DIRECTCONTEXT3D_LOADED = -1154677
    - DIRECTCONTEXT3D_SERVER_ID = -1154676
    - DIRECTCONTEXT3D_NAME = -1154675
    - ROOM_AIR_CHANGES_PER_HOUR_PARAM = -1154671
    - ROOM_OUTDOOR_AIR_PER_AREA_PARAM = -1154668
    - ROOM_OUTDOOR_AIR_PER_PERSON_PARAM = -1154665
    - ROOM_OUTDOOR_AIR_INFO_PARAM = -1154662
    - REBAR_INTERNAL_MULTIPLANAR_ARC_CONNECTOR = -1154659
    - REBAR_SHAPE_ENDTREATMENT_END_TYPE = -1154658
    - REBAR_SHAPE_ENDTREATMENT_START_TYPE = -1154657
    - REBAR_ELEM_ENDTREATMENT_END = -1154656
    - REBAR_ELEM_ENDTREATMENT_START = -1154655
    - END_TREATMENT = -1154654
    - COUPLER_COUPLED_ENDTREATMENT = -1154653
    - COUPLER_MAIN_ENDTREATMENT = -1154652
    - COUPLER_WIDTH = -1154651
    - COUPLER_MARK = -1154649
    - FAMILY_FREEINST_DEFAULT_ELEVATION = -1154647
    - COUPLER_COUPLED_ENGAGEMENT = -1154646
    - COUPLER_MAIN_ENGAGEMENT = -1154645
    - COUPLER_LENGTH = -1154644
    - COUPLER_WEIGHT = -1154643
    - COUPLER_NUMBER = -1154642
    - COUPLER_QUANTITY = -1154641
    - COUPLER_COUPLED_BAR_SIZE = -1154640
    - COUPLER_MAIN_BAR_SIZE = -1154639
    - COUPLER_CODE = -1154638
    - MULTISTORY_STAIRS_ACTUAL_TREAD_DEPTH = -1154634
    - MULTISTORY_STAIRS_REF_LEVEL = -1154630
    - REBAR_ELEM_HOST_MARK = -1154619
    - REBAR_SHAPE_IMAGE = -1154618
    - FABRIC_NUMBER = -1154617
    - REBAR_NUMBER = -1154616
    - GRAPHIC_DISPLAY_OPTIONS_SKETCHY_LINES = -1154615
    - NUMBER_PARTITION_PARAM = -1154614
    - VIEW_SHOW_HIDDEN_LINES = -1154613
    - RBS_ELEC_ANALYTICAL_DOWNSTREAM_CONNECTED_PHASES = -1153556
    - RBS_ELEC_ANALYTICAL_SECONDARY_HIGH_LEG_PHASE = -1153555
    - RBS_ELEC_ANALYTICAL_HIGH_LEG_PHASE = -1153554
    - RBS_ELEC_ANALYTICAL_CONNECTED_PHASE = -1153553
    - RBS_ELEC_ANALYTICAL_NUMPHASES = -1153552
    - RBS_ELEC_ANALYTICAL_AREA = -1153551
    - RBS_ELEC_ANALYTICAL_LOADS_IN_SET = -1153550
    - RBS_ELEC_ANALYTICAL_LOAD_SET_ON_STANDBY = -1153549
    - RBS_ELEC_ANALYTICAL_LOAD_SET_ON_DUTY = -1153548
    - RBS_ELEC_DISTRIBUTION_NODE_LOAD_SET = -1153547
    - RBS_ELEC_DISTRIBUTION_NODE_SUPPLY_TO = -1153546
    - RBS_ELEC_ANALYTICAL_FEEDER_LENGTH = -1153545
    - RBS_ELEC_ANALYTICAL_LEVEL_ID = -1153544
    - RBS_ELEC_APPARENT_POWER_DENSITY = -1153543
    - RBS_ELEC_DISTRIBUTION_NODE_SUPPLY_FROM2 = -1153542
    - RBS_ELEC_DISTRIBUTION_NODE_SUPPLY_FROM = -1153541
    - RBS_ELEC_DISTRIBUTION_NODE_SUPPLY_FROM1 = -1153539
    - RBS_ELEC_ANALYTICAL_LOAD_SET_ON_TOTAL = -1153538
    - RBS_ELEC_ANALYTICAL_LOAD_NAME_PARAM = -1153537
    - RBS_ELEC_ANALYTICAL_LOAD_TYPE_PARAM = -1153535
    - RBS_AREA_BASED_LOAD_TYPE = -1153533
    - RBS_ELEC_ANALYTICAL_LOAD_DENSITY = -1153532
    - MEP_ELEC_ZONE_EQUIPMENT_TYPE = -1153529
    - MEP_ZONE_EQUIPMENT_DRAW_VENTILATION = -1153528
    - MEP_VRF_LOOP = -1153527
    - MEP_REHEAT_HOTWATER_LOOP = -1153526
    - MEP_ZONE_EQUIPMENT = -1153519
    - MEP_ANALYTICAL_EQUIPMENT_NAME = -1153518
    - MEP_ZONE_HOTWATER_LOOP = -1153517
    - MEP_ZONE_AIR_LOOP = -1153516
    - MEP_REHEAT_COIL_TYPE = -1153514
    - MEP_ZONE_EQUIPMENT_BEHAVIOR = -1153513
    - MEP_ZONE_EQUIPMENT_TYPE = -1153512
    - MEP_AIRLOOP_FANTYPE = -1153511
    - MEP_CHILLED_WATER_LOOP = -1153510
    - MEP_COOLING_COIL_TYPE = -1153509
    - MEP_HEATING_HOTWATER_LOOP = -1153508
    - MEP_HEATING_COIL_TYPE = -1153507
    - MEP_PREHEAT_HOTWATER_LOOP = -1153506
    - MEP_AIRLOOP_PREHEAT_COILTYPE = -1153505
    - MEP_AIRLOOP_HEATEXCHANGER_TYPE = -1153504
    - MEP_CONDENSER_WATER_LOOP = -1153503
    - MEP_WATERLOOP_CHILLERTYPE = -1153502
    - MEP_WATERLOOP_TYPE = -1153501
    - MEP_ANALYTICAL_LOOP_NAME = -1153500
    - MEP_SEGMENT_ELEMENT_TYPENAME = -1153127
    - MEP_SEGMENT_FAMILYNAME = -1153126
    - MEP_SEGMENT_SYSTEMORSERVICE = -1153125
    - MEP_SEGMENT_LENGTH = -1153124
    - MEP_ANALYTICAL_ELEC_APPARENT_POWER_RATING = -1153123
    - MEP_ANALYTICAL_HYDRAULICLOOP = -1153122
    - MEP_ANALYTICAL_CRITICALSEQUENCE = -1153121
    - MEP_ANALYTICAL_HEADERSEGMENT = -1153120
    - MEP_ANALYTICAL_NETWORK = -1153119
    - MEP_ANALYTICAL_ELEC_CURRENT = -1153118
    - MEP_ANALYTICAL_ELEC_VOLTAGE = -1153117
    - MEP_ANALYTICAL_ELEC_CURRENT_RATING = -1153116
    - SYSTEM_EQUIPMENT_SETS = -1153115
    - MEP_IGNORE_FLOW_ANALYSIS = -1153114
    - MEP_ANALYTICAL_LOOP_BOUNDARY_PARAM = -1153113
    - MECHANICAL_EQUIPMENT_SET_ID_PARAM = -1153112
    - MECHANICAL_EQUIPMENT_SET_NAME = -1153111
    - MECHANICAL_EQUIPMENT_SET_ON_STANDBY = -1153110
    - MECHANICAL_EQUIPMENT_SET_ON_DUTY = -1153109
    - MEP_ANALYTICAL_CRITICALPATH_PARAM = -1153106
    - MEP_ANALYTICAL_PIPE_DESIGNFLOW = -1153105
    - MEP_EQUIPMENT_CALC_PIPINGPRESSUREDROP_PARAM = -1153104
    - MEP_EQUIPMENT_CALC_PIPINGFLOW_PARAM = -1153103
    - MEP_EQUIPMENT_CLASSIFICATION = -1153100
    - STRUCTURAL_CONNECTION_INPUT_ELEMENTS = -1153004
    - STRUCTURAL_CONNECTION_NOBLE_STATUS = -1153003
    - STRUCTURAL_CONNECTION_CODE_CHECKING_STATUS = -1153002
    - STRUCTURAL_CONNECTION_APPROVAL_STATUS = -1153001
    - STRUCTURAL_CONNECTION_MODIFY_CONNECTION_PARAMETERS = -1153000
    - STRUCTURAL_CONNECTION_SYMBOL = -1152999
    - ALL_MODEL_IMAGE = -1152385
    - ALL_MODEL_TYPE_IMAGE = -1152384
    - STRUCT_FRAM_JOIN_STATUS = -1152383
    - REFERENCED_VIEW = -1152380
    - ENERGY_ANALYSIS_ADVANCED_OPTIONS = -1152379
    - RBS_ENERGY_ANALYSIS_MODE = -1152378
    - RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_ANALYTICAL_SURFACE_IDENTIFICATION_RESOLUTION = -1152377
    - RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_ANALYTICAL_SPACE_IDENTIFICATION_RESOLUTION = -1152376
    - FAMILY_ROUNDCONNECTOR_DIMENSIONTYPE = -1152375
    - FAM_PROFILE_DEFINITION = -1152374
    - END_Z_OFFSET_VALUE = -1152373
    - END_Z_JUSTIFICATION = -1152372
    - END_Y_OFFSET_VALUE = -1152371
    - END_Y_JUSTIFICATION = -1152370
    - START_Z_OFFSET_VALUE = -1152369
    - START_Z_JUSTIFICATION = -1152368
    - START_Y_OFFSET_VALUE = -1152367
    - START_Y_JUSTIFICATION = -1152366
    - Z_OFFSET_VALUE = -1152365
    - Z_JUSTIFICATION = -1152364
    - Y_OFFSET_VALUE = -1152363
    - Y_JUSTIFICATION = -1152362
    - YZ_JUSTIFICATION = -1152361
    - END_JOIN_CUTBACK = -1152360
    - START_JOIN_CUTBACK = -1152359
    - END_EXTENSION = -1152358
    - START_EXTENSION = -1152357
    - DIVISION_SKETCH_CURVE_DIVISION_PARAMS_OVERRIDE_PARAM = -1152356
    - DIVISION_SKETCH_CURVE_EXTENTD_TO_SILH_PARAM = -1152352
    - DIVISION_RULE_PARAM = -1152351
    - PATTERN_MIRROR_FOR_DIVISION_RULE = -1152350
    - ALL_GRID_ROTATION_FOR_DIVISION_RULE = -1152349
    - PATTERN_INDENT_2_FOR_DIVISION_RULE = -1152348
    - PATTERN_INDENT_1_FOR_DIVISION_RULE = -1152347
    - DIVISION_PATTERN = -1152346
    - DPART_SHAPE_MODIFIED = -1152345
    - DPART_EXCLUDED = -1152344
    - ANALYTICAL_MODEL_MANUALLY_ADJUSTED = -1152343
    - PROPERTY_SET_KEYWORDS = -1152342
    - MATERIAL_ASSET_PARAM_SOURCE_URL = -1152341
    - MATERIAL_ASSET_PARAM_SOURCE = -1152340
    - MATERIAL_ASSET_PARAM_EXTERNAL_MATERIAL_ID = -1152339
    - MATERIAL_ASSET_PARAM_COMMON_SHARED_ASSET = -1152338
    - MATERIAL_ASSET_PARAM_ASSET_LIB_ID = -1152337
    - DPART_BASE_LEVEL_BY_ORIGINAL = -1152336
    - DPART_BASE_LEVEL = -1152335
    - POINT_ADAPTIVE_NUM_PARAM = -1152334
    - POINT_ADAPTIVE_SHOW_NUMBER = -1152333
    - POINT_ADAPTIVE_CONSTRAINED = -1152332
    - POINT_ADAPTIVE_ORIENTATION_TYPE = -1152331
    - THERMAL_MATERIAL_PARAM_ELECTRICAL_RESISTIVITY = -1152330
    - THERMAL_MATERIAL_PARAM_REFLECTIVITY = -1152329
    - THERMAL_MATERIAL_PARAM_POROSITY = -1152328
    - THERMAL_MATERIAL_PARAM_PERMEABILITY = -1152327
    - THERMAL_MATERIAL_PARAM_TRANSMITS_LIGHT = -1152326
    - THERMAL_MATERIAL_PARAM_VAPOR_PRESSURE = -1152325
    - THERMAL_MATERIAL_PARAM_SPECIFIC_HEAT_OF_VAPORIZATION = -1152324
    - THERMAL_MATERIAL_PARAM_LIQUID_VISCOSITY = -1152323
    - THERMAL_MATERIAL_PARAM_COMPRESSIBILITY = -1152322
    - THERMAL_MATERIAL_PARAM_GAS_VISCOSITY = -1152321
    - THERMAL_MATERIAL_PARAM_EMISSIVITY = -1152320
    - PHY_MATERIAL_PARAM_WOOD_CONSTRUCTION = -1152319
    - PHY_MATERIAL_PARAM_FIVEPERCENT_MODULUS_OF_ELACTICITY = -1152318
    - PHY_MATERIAL_PARAM_AVERAGE_MODULUS = -1152317
    - PHY_MATERIAL_PARAM_TENSION_PERPENDICULAR = -1152316
    - PHY_MATERIAL_PARAM_TENSION_PARALLEL = -1152315
    - PHY_MATERIAL_PARAM_STRUCTURAL_THERMAL_TREATED = -1152314
    - PHY_MATERIAL_PARAM_STRUCTURAL_DENSITY = -1152313
    - PHY_MATERIAL_PARAM_STRUCTURAL_SPECIFIC_HEAT = -1152312
    - PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY_Z = -1152311
    - PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY_Y = -1152310
    - PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY_X = -1152309
    - PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY = -1152308
    - PHY_MATERIAL_PARAM_EXP_COEFF_2 = -1152307
    - PHY_MATERIAL_PARAM_EXP_COEFF_1 = -1152306
    - PHY_MATERIAL_PARAM_SHEAR_MOD_12 = -1152305
    - PHY_MATERIAL_PARAM_POISSON_MOD_23 = -1152304
    - PHY_MATERIAL_PARAM_POISSON_MOD_12 = -1152303
    - PHY_MATERIAL_PARAM_YOUNG_MOD_2 = -1152302
    - PHY_MATERIAL_PARAM_YOUNG_MOD_1 = -1152301
    - STAIRS_RAILING_PLACEMENT_OFFSET = -1152300
    - STAIRS_TRISERTYPE_RISER_IS_SLANTED = -1152177
    - STAIRS_TRISERTYPE_RISER = -1152176
    - STAIRS_TRISERTYPE_NOSING_PLACEMENT = -1152175
    - STAIRS_TRISERTYPE_RISER_PROFILE = -1152174
    - TERMINATION_EXTENSION_LENGTH = -1152167
    - SUPPORT_HEIGHT = -1152166
    - SUPPORT_HAND_CLEARANCE = -1152165
    - STAIRS_TRISERTYPE_TREAD_PROFILE = -1152164
    - STAIRS_TRISERTYPE_RISER_MATERIAL = -1152163
    - STAIRS_TRISERTYPE_TREAD_MATERIAL = -1152162
    - STAIRS_TRISERTYPE_RISER_TREAD_CONNECTION = -1152161
    - STAIRS_TRISERTYPE_RISER_THICKNESS = -1152160
    - STAIRS_TRISERTYPE_RISER_STYLE = -1152159
    - STAIRS_TRISERTYPE_BACK_NOSING = -1152158
    - STAIRS_TRISERTYPE_LEFT_NOSING = -1152157
    - STAIRS_TRISERTYPE_RIGHT_NOSING = -1152156
    - STAIRS_TRISERTYPE_FRONT_NOSING = -1152155
    - STAIRS_TRISERTYPE_NOSING_LENGTH = -1152154
    - STAIRS_TRISERTYPE_NOSING_PROFILE = -1152153
    - STAIRS_TRISERTYPE_TREAD_THICKNESS = -1152152
    - STAIRS_TRISERTYPE_TREAD = -1152151
    - STAIRS_TRISER_RISER_MARK = -1152105
    - STAIRS_TRISER_TREAD_MARK = -1152104
    - STAIRS_TRISER_RISER_NUMBER = -1152103
    - STAIRS_TRISER_TREAD_NUMBER = -1152102
    - STAIRS_TRISER_IS_TYPE_OVERRIDDEN = -1152101
    - STAIRS_WINDERPATTERN_NUMBER_OF_STRAIGHT_STEPS_AT_END = -1151908
    - STAIRS_WINDERPATTERN_NUMBER_OF_STRAIGHT_STEPS_AT_BEGIN = -1151907
    - STAIRS_WINDERPATTERN_RADIUS_INTERIOR = -1151906
    - STAIRS_WINDERPATTERN_FILLET_INSIDE_CORNER = -1151905
    - STAIRS_WINDERPATTERN_STAIR_PATH_OFFSET = -1151904
    - STAIRS_WINDERPATTERN_MINIMUM_WIDTH_INSIDE_WALKLINE = -1151903
    - STAIRS_WINDERPATTERN_MINIMUM_WIDTH_CORNER = -1151902
    - STAIRS_WINDERPATTERN_WINDER_STYLE = -1151901
    - STAIRS_SUPPORTTYPE_FLIP_SECTION_PROFILE = -1151811
    - STAIRS_SUPPORTTYPE_STRUCTURAL_DEPTH_ON_LANDING = -1151810
    - STAIRS_SUPPORTTYPE_STRUCTURAL_DEPTH_ON_RUN = -1151809
    - STAIRS_SUPPORTTYPE_MATERIAL = -1151808
    - STAIRS_SUPPORTTYPE_WIDTH = -1151807
    - STAIRS_SUPPORTTYPE_TOTAL_DEPTH = -1151806
    - STAIRS_SUPPORTTYPE_STRUCTURAL_DEPTH = -1151805
    - STAIRS_SUPPORTTYPE_UNDERSIDE_SURFACE = -1151804
    - STAIRS_SUPPORTTYPE_TOPSIDE_SURFACE = -1151803
    - STAIRS_SUPPORTTYPE_SECTION_PROFILE = -1151801
    - STAIRS_SUPPORT_LANDINGSUPPORT_TYPE = -1151710
    - STAIRS_SUPPORT_OVERRIDDEN = -1151709
    - STAIRS_SUPPORT_TRIM_SUPPORT_UPPER = -1151708
    - STAIRS_SUPPORT_UPPER_END_CUT = -1151706
    - STAIRS_SUPPORT_LOWER_END_CUT = -1151705
    - STAIRS_SUPPORT_VERTICAL_OFFSET = -1151702
    - STAIRS_SUPPORT_HORIZONTAL_OFFSET = -1151701
    - STAIRS_LANDINGTYPE_LANDING_MATERIAL = -1151606
    - STAIRS_LANDINGTYPE_TREADRISER_TYPE = -1151605
    - STAIRS_LANDINGTYPE_USE_SAME_TRISER_AS_RUN = -1151604
    - STAIRS_LANDINGTYPE_THICKNESS = -1151603
    - STAIRS_LANDINGTYPE_STRUCTURE = -1151602
    - STAIRS_LANDINGTYPE_HAS_MONOLITHIC_SUPPORT = -1151601
    - STAIRS_LANDING_OVERRIDDEN = -1151508
    - STAIRS_LANDING_THICKNESS = -1151507
    - STAIRS_LANDING_STRUCTURAL = -1151502
    - STAIRS_LANDING_BASE_ELEVATION = -1151501
    - STAIRS_RUNTYPE_RUN_MATERIAL = -1151406
    - STAIRS_RUNTYPE_TOTAL_DEPTH = -1151405
    - STAIRS_RUNTYPE_STRUCTURAL_DEPTH = -1151404
    - STAIRS_RUNTYPE_STRUCTURE = -1151403
    - STAIRS_RUNTYPE_UNDERSIDE_SURFACE_TYPE = -1151402
    - STAIRS_RUNTYPE_HAS_MONOLITHIC_SUPPORT = -1151401
    - STAIRS_RUN_EXTEND_BELOW_TREAD_BASE = -1151323
    - STAIRS_RUN_CCW = -1151322
    - STAIRS_RUN_CREATE_AUTO_LANDING = -1151321
    - STAIRS_RUN_WINDER_END_WITH_STRAIGHT = -1151320
    - STAIRS_RUN_WINDER_BEGIN_WITH_STRAIGHT = -1151319
    - STAIRS_RUN_LOCATIONPATH_JUSTFICATION = -1151318
    - STAIRS_RUN_END_WITH_RISER = -1151317
    - STAIRS_RUN_BEGIN_WITH_RISER = -1151316
    - STAIRS_RUN_OVERRIDDEN = -1151315
    - STAIRS_RUN_STRUCTURAL = -1151314
    - STAIRS_RUN_CENTER_MARK_VISIBLE = -1151313
    - STAIRS_RUN_ACTUAL_RUN_WIDTH = -1151309
    - STAIRS_RUN_ACTUAL_TREAD_DEPTH = -1151308
    - STAIRS_RUN_ACTUAL_RISER_HEIGHT = -1151307
    - STAIRS_RUN_ACTUAL_NUMBER_OF_TREADS = -1151306
    - STAIRS_RUN_ACTUAL_NUMBER_OF_RISERS = -1151305
    - STAIRS_RUN_EXTEND_BELOW_RISER_BASE = -1151304
    - STAIRS_RUN_HEIGHT = -1151303
    - STAIRS_RUN_TOP_ELEVATION = -1151302
    - STAIRS_RUN_BOTTOM_ELEVATION = -1151301
    - STAIRSTYPE_HAS_INTERMEDIATE_SUPPORT = -1151237
    - STAIRSTYPE_LEFT_SUPPORT_LATERAL_OFFSET = -1151236
    - STAIRSTYPE_RIGHT_SUPPORT_LATERAL_OFFSET = -1151235
    - STAIRSTYPE_CUTMARK_TYPE = -1151234
    - STAIRSTYPE_CONSTRUCTION_METHOD = -1151233
    - STAIRSTYPE_HAS_RIGHT_SUPPORT = -1151232
    - STAIRSTYPE_HAS_LEFT_SUPPORT = -1151231
    - STAIRSTYPE_NOTCH_WIDTH = -1151230
    - STAIRSTYPE_NOTCH_VERTICAL_GAP = -1151229
    - STAIRSTYPE_NOTCH_HORIZONTAL_GAP = -1151228
    - STAIRSTYPE_NOTCH_CUSTOM_WIDTH = -1151227
    - STAIRSTYPE_NOTCH_THICKNESS = -1151226
    - STAIRSTYPE_NOTCH_EXTENSION = -1151225
    - STAIRSTYPE_GEOMUNJOINED_END_CUT_STYLE = -1151224
    - STAIRSTYPE_CALC_RULE_TARGET_RESULT = -1151223
    - STAIRSTYPE_CALC_RULE_MIN_RESULT = -1151222
    - STAIRSTYPE_CALC_RULE_MAX_RESULT = -1151221
    - STAIRSTYPE_CALC_RULE_TREAD_MULTIPLIER = -1151220
    - STAIRSTYPE_CALC_RULE_RISER_MULTIPLIER = -1151219
    - STAIRSTYPE_IS_ASSEMBLED_STAIRS = -1151218
    - STAIRSTYPE_NUMBER_OF_INTERMEDIATE_SUPPORTS = -1151217
    - STAIRSTYPE_MINIMUM_RUN_WIDTH = -1151216
    - STAIRSTYPE_WINDER_STEP_FRONT_MEASUREMENT = -1151215
    - STAIRSTYPE_SHOW_UPDOWN = -1151214
    - STAIRSTYPE_SHOW_STAIR_PATH = -1151213
    - STAIRSTYPE_SHOW_CUTLINE = -1151212
    - STAIRSTYPE_INTERMEDIATE_SUPPORT_TYPE = -1151211
    - STAIRSTYPE_LEFT_SIDE_SUPPORT_TYPE = -1151210
    - STAIRSTYPE_RIGHT_SIDE_SUPPORT_TYPE = -1151209
    - STAIRSTYPE_LANDING_TYPE = -1151208
    - STAIRSTYPE_RUN_TYPE = -1151207
    - STAIRSTYPE_CALCULATION_RULES = -1151206
    - STAIRSTYPE_MINIMUM_TREAD_WIDTH_INSIDE_BOUNDARY = -1151205
    - STAIRSTYPE_MINIMUM_TREAD_DEPTH = -1151204
    - STAIRSTYPE_MAXIMUM_RISER_HEIGHT = -1151203
    - STAIRS_TRISER_NUMBER_BASE_INDEX = -1151154
    - STAIRS_DBG_SHOW_ANNOTATION_CUT_MARK = -1151153
    - STAIRS_DBG_SHOW_MONOLITHIC_SUPPORT_CORSE_GEOM = -1151152
    - STAIRS_DBG_SHOW_TRISER_CORSE_GEOM = -1151151
    - STAIRS_DBG_SHOW_RUN_CORSE_GEOM = -1151150
    - STAIRS_DBG_SHOW_MONOLITHIC_SUPPORT_GEOM = -1151149
    - STAIRS_DBG_SHOW_TRISER_GEOM = -1151148
    - STAIRS_DBG_SHOW_RUN_GEOM = -1151147
    - STAIRS_DBG_SHOW_SUPPORT_PATH = -1151146
    - STAIRS_DBG_SHOW_BOUNDARY_3D = -1151145
    - STAIRS_DBG_SHOW_BOUNDARY_2D = -1151144
    - STAIRS_DBG_SHOW_LANDING_PATH = -1151143
    - STAIRS_DBG_SHOW_LANDING_BOUNDARY = -1151142
    - STAIRS_DBG_SHOW_RUN_OUTLINE_FOR_PLAN = -1151141
    - STAIRS_DBG_SHOW_RUN_NOSING = -1151140
    - STAIRS_DBG_SHOW_RUN_RISER = -1151139
    - STAIRS_DBG_SHOW_RUN_PATH_3D = -1151138
    - STAIRS_DBG_SHOW_RUN_PATH_2D = -1151137
    - STAIRS_DBG_SHOW_RIGHT_RUN_BOUNDARY_3D = -1151136
    - STAIRS_DBG_SHOW_LEFT_RUN_BOUNDARY_3D = -1151135
    - STAIRS_DBG_SHOW_RIGHT_RUN_BOUNDARY_2D = -1151134
    - STAIRS_DBG_SHOW_LEFT_RUN_BOUNDARY_2D = -1151133
    - STAIRS_DBG_SHOW_LANDING_FACES = -1151132
    - STAIRS_DBG_SHOW_TREAD_FACES = -1151131
    - STAIRS_ENABLE_CALCULATION_RULE_CHECKING = -1151118
    - STAIRS_MIN_AUTOMATIC_LANDING_DEPTH = -1151117
    - STAIRS_RUN_WIDTH_MEASUREMENT = -1151116
    - STAIRS_TOTAL_NUMBER_OF_TREADS = -1151113
    - STAIRS_TOTAL_NUMBER_OF_RISERS = -1151112
    - STAIRS_ACTUAL_NUMBER_OF_RISERS = -1151111
    - STAIRS_DESIRED_NUMBER_OF_RISERS = -1151110
    - STAIRS_MULTISTORY_UP_TO_LEVEL = -1151106
    - STAIRS_STAIRS_HEIGHT = -1151105
    - STAIRS_TOP_LEVEL = -1151103
    - STAIRS_BASE_LEVEL = -1151101
    - PART_MAKER_DIVISION_PROFILE_OFFSET = -1150624
    - DIVISION_PROFILE_WIDTH = -1150623
    - PART_MAKER_SPLITTER_PROFILE_EDGE_MATCH = -1150622
    - PART_MAKER_SPLITTER_PROFILE_FLIP_ALONG = -1150605
    - PART_MAKER_SPLITTER_PROFILE_FLIP_ACROSS = -1150604
    - PART_MAKER_SPLITTER_PROFILE = -1150603
    - FAMILY_KEYWORD_PROTECTED = -1150602
    - PARTMAKER_PARAM_DIVISION_GAP = -1150601
    - POINTCLOUDINSTANCE_NAME = -1150600
    - ANALYTICAL_MODEL_ROTATION = -1150501
    - POINTCLOUDTYPE_SCALE = -1150500
    - PROPERTY_SET_DESCRIPTION = -1150481
    - PROPERTY_SET_MATERIAL_ASPECT = -1150480
    - RBS_DUCT_PIPE_SYSTEM_ABBREVIATION_PARAM = -1150468
    - PHY_MATERIAL_PROPERTIES = -1150467
    - PROPERTY_SET_NAME = -1150466
    - PHY_MATERIAL_PARAM_SUBCLASS = -1150465
    - PHY_MATERIAL_PARAM_CLASS = -1150464
    - ANALYTICAL_MODEL_PERIMETER = -1150463
    - ANALYTICAL_MODEL_AREA = -1150462
    - ANALYTICAL_MODEL_LENGTH = -1150461
    - SHEET_ASSEMBLY_KEYNOTE = -1150460
    - SHEET_ASSEMBLY_ASSEMBLY_DESCRIPTION = -1150459
    - SHEET_ASSEMBLY_COST = -1150458
    - SHEET_ASSEMBLY_TYPE_MARK = -1150457
    - SHEET_ASSEMBLY_ASSEMBLY_CODE = -1150456
    - SHEET_ASSEMBLY_DESCRIPTION = -1150455
    - SHEET_ASSEMBLY_URL = -1150454
    - SHEET_ASSEMBLY_TYPE_COMMENTS = -1150453
    - SHEET_ASSEMBLY_MANUFACTURER = -1150452
    - SHEET_ASSEMBLY_MODEL = -1150451
    - SHEET_ASSEMBLY_NAME = -1150450
    - PIPE_INSULATION_THICKNESS = -1150437
    - DUCT_INSULATION_THICKNESS = -1150436
    - RBS_REFERENCE_FREESIZE = -1150435
    - RBS_REFERENCE_OVERALLSIZE = -1150434
    - RBS_REFERENCE_LINING_THICKNESS = -1150433
    - RBS_REFERENCE_LINING_TYPE = -1150432
    - RBS_REFERENCE_INSULATION_THICKNESS = -1150431
    - RBS_REFERENCE_INSULATION_TYPE = -1150430
    - RBS_PIPE_CALCULATED_SIZE = -1150427
    - RBS_DUCT_CALCULATED_SIZE = -1150426
    - RBS_INSULATION_LINING_VOLUME = -1150425
    - ASSEMBLY_NAME = -1150420
    - RBS_COMPONENT_CLASSIFICATION_PARAM = -1150412
    - RBS_SYSTEM_RISEDROP_PARAM = -1150411
    - RBS_SYSTEM_RISEDROP_2LINEDROPSYMBOL_PARAM = -1150410
    - RBS_SYSTEM_RISEDROP_2LINERISESYMBOL_PARAM = -1150409
    - RBS_SYSTEM_RISEDROP_1LINEDROPSYMBOL_PARAM = -1150408
    - RBS_SYSTEM_RISEDROP_1LINERISESYMBOL_PARAM = -1150407
    - RBS_SYSTEM_RISEDROP_1LINETEEUPSYMBOL_PARAM = -1150406
    - RBS_SYSTEM_RISEDROP_1LINETEEDOWNSYMBOL_PARAM = -1150405
    - ASSEMBLY_NAMING_CATEGORY = -1150403
    - RAILING_SYSTEM_HAS_TOP_RAIL = -1150380
    - CONTINUOUSRAIL_JOIN_TYPE_PARAM = -1150373
    - CONTINUOUSRAIL_PLUS_TREAD_DEPTH_PARAM = -1150361
    - CONTINUOUSRAIL_LENGTH_PARAM = -1150360
    - HANDRAIL_SUPPORTS_JUSTIFICATION_PARAM = -1150355
    - HANDRAIL_SUPPORTS_NUMBER_PARAM = -1150354
    - HANDRAIL_SUPPORTS_SPACING_PARAM = -1150353
    - HANDRAIL_SUPPORTS_LAYOUT_PARAM = -1150352
    - HANDRAIL_SUPPORTS_TYPE_PARAM = -1150351
    - CONTINUOUSRAIL_END_EXTENSION_LENGTH_PARAM = -1150350
    - CONTINUOUSRAIL_END_TERMINATION_ATTACHMENT_PARAM = -1150349
    - CONTINUOUSRAIL_EXTENSION_LENGTH_PARAM = -1150348
    - CONTINUOUSRAIL_BEGINNING_TERMINATION_ATTACHMENT_PARAM = -1150347
    - CONTINUOUSRAIL_END_TERMINATION_TYPE_PARAM = -1150346
    - CONTINUOUSRAIL_BEGINNING_TERMINATION_TYPE_PARAM = -1150345
    - CONTINUOUSRAIL_MATERIALS_PARAM = -1150344
    - CONTINUOUSRAIL_TRANSITION_TYPE_PARAM = -1150343
    - HANDRAIL_HAND_CLEARANCE_PARAM = -1150342
    - HANDRAIL_PROJECTION_PARAM = -1150341
    - HANDRAIL_HEIGHT_PARAM = -1150340
    - CONTINUOUSRAIL_PROFILE_TYPE_PARAM = -1150339
    - CONTINUOUSRAIL_FILLET_RADIUS_PARAM = -1150338
    - CONTINUOUSRAIL_DEFAULT_JOIN_TYPE_PARAM = -1150337
    - RAILING_SYSTEM_SECONDARY_HANDRAILS_LATTERAL_OFFSET = -1150336
    - RAILING_SYSTEM_SECONDARY_HANDRAILS_HEIGHT_PARAM = -1150335
    - RAILING_SYSTEM_SECONDARY_HANDRAILS_POSITION_PARAM = -1150334
    - RAILING_SYSTEM_SECONDARY_HANDRAILS_TYPES_PARAM = -1150333
    - RAILING_SYSTEM_HANDRAILS_LATTERAL_OFFSET = -1150332
    - RAILING_SYSTEM_HANDRAILS_HEIGHT_PARAM = -1150331
    - RAILING_SYSTEM_HANDRAILS_POSITION_PARAM = -1150330
    - RAILING_SYSTEM_HANDRAILS_TYPES_PARAM = -1150329
    - RAILING_SYSTEM_TOP_RAIL_HEIGHT_PARAM = -1150328
    - RAILING_SYSTEM_TOP_RAIL_TYPES_PARAM = -1150327
    - POINT_ELEMENT_ROTATION_ANGLE = -1150322
    - FLEXIBLE_INSTANCE_FLIP = -1150321
    - POINT_FLEXIBLE_ORIENTATION_TYPE = -1150320
    - DEFAULT_CONSTRUCTION_MASS_FLOOR = -1150310
    - DEFAULT_CONSTRUCTION_MASS_OPENING = -1150309
    - DEFAULT_CONSTRUCTION_MASS_SKYLIGHT = -1150307
    - DEFAULT_CONSTRUCTION_MASS_GLAZING = -1150306
    - DEFAULT_CONSTRUCTION_EXT_WALL_UNDERGROUND = -1150305
    - DEFAULT_CONSTRUCTION_MASS_SLAB = -1150304
    - DEFAULT_CONSTRUCTION_MASS_SHADE = -1150303
    - DEFAULT_CONSTRUCTION_MASS_ROOF = -1150302
    - DEFAULT_CONSTRUCTION_MASS_INTERIOR_WALL = -1150301
    - DEFAULT_CONSTRUCTION_MASS_EXTERIOR_WALL = -1150300
    - ENERGY_ANALYSIS_SPACE_BOUNDING_PARAM = -1150236
    - ENERGY_ANALYSIS_HORIZONTAL_VOID_THRESHOLD = -1150235
    - ENERGY_ANALYSIS_VERTICAL_VOID_THRESHOLD = -1150234
    - RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_ANALYTICAL_GRID_CELL_SIZE = -1150233
    - RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_DETERMINATION_PARAM = -1150232
    - LEADER_RIGHT_ATTACHMENT = -1150231
    - LEADER_LEFT_ATTACHMENT = -1150230
    - POINT_ELEMENT_MEASURE_FROM = -1150227
    - POINT_ELEMENT_ANGLE = -1150226
    - POINT_ELEMENT_CHORD_LENGTH = -1150225
    - POINT_ELEMENT_NORMALIZED_SEGMENT_LENGTH = -1150224
    - POINT_ELEMENT_SEGMENT_LENGTH = -1150223
    - POINT_ELEMENT_NORMALIZED_CURVE_PARAMATER = -1150222
    - POINT_ELEMENT_NON_NORMALIZED_CURVE_PARAMATER = -1150221
    - POINT_ELEMENT_MEASUREMENT_TYPE = -1150220
    - STRUCTURAL_BEAM_END_ATTACHMENT_REFCOLUMN_END = -1150219
    - STRUCTURAL_BEAM_START_ATTACHMENT_REFCOLUMN_END = -1150218
    - STRUCTURAL_BEAM_END_ATTACHMENT_DISTANCE = -1150217
    - STRUCTURAL_BEAM_START_ATTACHMENT_DISTANCE = -1150216
    - STRUCTURAL_BEAM_END_ATTACHMENT_TYPE = -1150215
    - STRUCTURAL_BEAM_START_ATTACHMENT_TYPE = -1150214
    - TEXT_BOX_VISIBILITY = -1150213
    - CURVE_BY_POINTS_PROJECTION_TYPE = -1150212
    - FOLLOW_SURFACE = -1150211
    - RBS_ENERGY_ANALYSIS_INCLUDE_THERMAL_PROPERTIES = -1150210
    - POINT_FLEXIBLE_NUM_PARAM = -1150209
    - FRAMING_LENGTH_ROUNDOFF = -1150208
    - SLANTED_COLUMN_BASE_EXTENSION = -1150207
    - SLANTED_COLUMN_TOP_EXTENSION = -1150206
    - SLANTED_COLUMN_BASE_CUT_STYLE = -1150205
    - SLANTED_COLUMN_TOP_CUT_STYLE = -1150204
    - RBS_BUILDING_USELOADCREDITS = -1150203
    - TILE_PATTERN_FAMREF_COMPONENT_EXTENTS = -1150202
    - TILE_PATTERN_GRID_CELLS_Y = -1150201
    - TILE_PATTERN_GRID_CELLS_X = -1150200
    - TILE_PATTERN_GRID_UNIT_Y = -1150199
    - TILE_PATTERN_GRID_UNIT_X = -1150198
    - POINT_ELEMENT_SHOW_NORMAL_PLANE_ONLY = -1150197
    - LEVEL_IS_GROUND_PLANE = -1150195
    - BASEPOINT_ANGLETON_PARAM = -1150194
    - BASEPOINT_ELEVATION_PARAM = -1150193
    - BASEPOINT_EASTWEST_PARAM = -1150192
    - BASEPOINT_NORTHSOUTH_PARAM = -1150191
    - SLANTED_COLUMN_GEOMETRY_TREATMENT_BASE = -1150190
    - SLANTED_COLUMN_GEOMETRY_TREATMENT_TOP = -1150189
    - ROOM_PLENUM_LIGHTING_PARAM = -1150188
    - STRUCTURAL_ATTACHMENT_TOP_REFERENCEDEND = -1150183
    - STRUCTURAL_ATTACHMENT_TOP_RATIO = -1150182
    - STRUCTURAL_ATTACHMENT_TOP_DISTANCE = -1150181
    - STRUCTURAL_ATTACHMENT_TOP_TYPE = -1150180
    - STRUCTURAL_ATTACHMENT_BASE_REFERENCEDEND = -1150179
    - STRUCTURAL_ATTACHMENT_BASE_RATIO = -1150178
    - STRUCTURAL_ATTACHMENT_BASE_DISTANCE = -1150177
    - STRUCTURAL_ATTACHMENT_BASE_TYPE = -1150176
    - INSTANCE_MOVE_BASE_WITH_GRIDS = -1150173
    - INSTANCE_MOVE_TOP_WITH_GRIDS = -1150172
    - SLANTED_COLUMN_TYPE_PARAM = -1150171
    - VIEW_SLANTED_COLUMN_SYMBOL_OFFSET = -1150170
    - POINT_ELEMENT_MIRRORED = -1150169
    - POINT_ELEMENT_ZFLIPPED = -1150168
    - POINT_ELEMENT_HOSTED_ON_FACE_V_PARAM = -1150167
    - POINT_ELEMENT_HOSTED_ON_FACE_U_PARAM = -1150166
    - LOCKED_END_OFFSET = -1150165
    - LOCKED_START_OFFSET = -1150164
    - LOCKED_BASE_OFFSET = -1150163
    - LOCKED_TOP_OFFSET = -1150162
    - RBS_PROJECT_REPORTTYPE_PARAM = -1150161
    - RBS_BUILDING_CONSTRUCTIONCLASS = -1150160
    - CONNECTOR_UTILITY_PARAM = -1150159
    - POINT_FLEXIBLE_SHOW_NUMBER = -1150158
    - POINT_FLEXIBLE_CONSTRAINED = -1150157
    - POINT_NAME_PARAM = -1150156
    - POINT_ADAPTIVE_TYPE_PARAM = -1150155
    - SPOT_DIM_STYLE_SLOPE_UNITS = -1150154
    - POINT_ELEMENT_DRIVING = -1150153
    - SPOT_SLOPE_LEADER_LENGTH = -1150152
    - SPOT_SLOPE_SUFFIX = -1150151
    - SPOT_SLOPE_PREFIX = -1150150
    - POINT_VISIBILITY_PARAM = -1150149
    - POINT_ELEMENT_SHOW_PLANES = -1150148
    - CURVE_IS_REFERENCE_LINE = -1150147
    - POINT_ELEMENT_HOSTED_PARAM = -1150146
    - POINT_ELEMENT_DRIVEN = -1150145
    - POINT_ELEMENT_OFFSET = -1150144
    - SPOT_DIM_STYLE_SLOPE_UNITS_ALT = -1150143
    - FBX_LIGHT_PHOTOMETRIC_FILE_CACHE = -1150142
    - FBX_LIGHT_PHOTOMETRICS_FAM = -1150141
    - FAMILY_CURVE_ATTACHMENT_PROPORTION = -1150140
    - FBX_LIGHT_LOSS_FACTOR_CTRL = -1150139
    - FBX_LIGHT_INITIAL_COLOR_CTRL = -1150138
    - FBX_LIGHT_LOSS_FACTOR_METHOD = -1150137
    - FBX_LIGHT_INITIAL_COLOR_NAME = -1150134
    - FBX_LIGHT_AT_A_DISTANCE = -1150133
    - FBX_LIGHT_INITIAL_INTENSITY_INPUT_METHOD = -1150132
    - FBX_LIGHT_SOURCE_LENGTH = -1150131
    - FBX_LIGHT_SOURCE_DIAMETER = -1150130
    - FBX_LIGHT_EMIT_CIRCLE_DIAMETER = -1150129
    - FBX_LIGHT_EMIT_RECTANGLE_LENGTH = -1150128
    - FBX_LIGHT_EMIT_RECTANGLE_WIDTH = -1150127
    - FBX_LIGHT_EMIT_LINE_LENGTH = -1150126
    - FBX_LIGHT_EMIT_SHAPE_VISIBLE = -1150118
    - FBX_LIGHT_DIMMING_LIGHT_COLOR = -1150117
    - FBX_LIGHT_LUMENAIRE_DIRT = -1150115
    - FBX_LIGHT_LAMP_LUMEN_DEPR = -1150114
    - FBX_LIGHT_SURFACE_LOSS = -1150113
    - FBX_LIGHT_LAMP_TILT_LOSS = -1150112
    - FBX_LIGHT_VOLTAGE_LOSS = -1150110
    - FBX_LIGHT_TEMPERATURE_LOSS = -1150109
    - FBX_LIGHT_COLOR_FILTER = -1150108
    - FBX_LIGHT_INITIAL_COLOR_TEMPERATURE = -1150107
    - FBX_LIGHT_ILLUMINANCE = -1150106
    - FBX_LIGHT_LIMUNOUS_INTENSITY = -1150105
    - FBX_LIGHT_EFFICACY = -1150104
    - FBX_LIGHT_WATTAGE = -1150103
    - FBX_LIGHT_INITIAL_INTENSITY = -1150102
    - FBX_LIGHT_PHOTOMETRICS = -1150101
    - FBX_ASSET_TYPE = -1150100
    - DIVIDED_SURFACE_GRID_OPTION_PARAM_2 = -1150086
    - DIVIDED_SURFACE_GRID_OPTION_PARAM_1 = -1150085
    - DIVIDED_SURFACE_DISPLAY_DISCARDEDDIVISIONLINES = -1150084
    - DIVIDED_SURFACE_COMPONENT_TRIM_TYPE = -1150083
    - DIVIDED_SURFACE_PATTERN_MIRROR = -1150082
    - DIVIDED_SURFACE_RULE_2_SUSPENSION = -1150081
    - DIVIDED_SURFACE_RULE_1_SUSPENSION = -1150080
    - DIVIDED_SURFACE_DISPLAY_COMPONENTS = -1150079
    - DIVIDED_SURFACE_PATTERN_FILL_MATERIAL = -1150078
    - DIVIDED_SURFACE_DISPLAY_PATTERN_FILL = -1150077
    - DIVIDED_SURFACE_PATTERN_LINES_STYLE = -1150076
    - DIVIDED_SURFACE_DISPLAY_PATTERN_LINES = -1150075
    - DIVIDED_SURFACE_GRIDLINES_STYLE = -1150074
    - DIVIDED_SURFACE_DISPLAY_GRIDLINES = -1150073
    - DIVIDED_SURFACE_DISPLAY_NODES = -1150072
    - DIVIDED_SURFACE_ORIGINAL_SURFACE_MATERIAL = -1150071
    - DIVIDED_SURFACE_DISPLAY_ORIGINAL_SURFACE = -1150070
    - DIVIDED_SURFACE_DISPLAY_SURFACE_OPTION = -1150069
    - DIVIDED_SURFACE_ALL_GRID_ROTATION = -1150068
    - DIVIDED_SURFACE_TILE_BORDER = -1150067
    - DIVIDED_SURFACE_ALL_POINTS = -1150062
    - DIVIDED_SURFACE_PATTERN = -1150061
    - DIVIDED_SURFACE_PATTERN_FLIP = -1150060
    - DIVIDED_SURFACE_PATTERN_ROTATION_ANGLE = -1150059
    - DIVIDED_SURFACE_PATTERN_INDENT_2 = -1150058
    - DIVIDED_SURFACE_PATTERN_INDENT_1 = -1150057
    - DIVIDED_SURFACE_COVER_FACE_COMPLETELY = -1150056
    - DIVIDED_SURFACE_OFFSET_FROM_SURFACE = -1150055
    - DIVIDED_SURFACE_TOTAL_EDGE_LENGTH = -1150054
    - DIVIDED_SURFACE_EDGE_NUMBER = -1150053
    - DIVIDED_SURFACE_POINT_NUMBER = -1150052
    - DIVIDED_SURFACE_FACET_NUMBER = -1150051
    - DIVIDED_SURFACE_SURFACE_AREA = -1150050
    - RBS_ELEC_ROOM_LIGHTING_CALC_LUMINAIREPLANE = -1144331
    - LAYOUTNODE_CURVETYPE_PARAM = -1142000
    - RBS_DISTRIBUTIONSYS_HL_PHASE_PARAM = -1141050
    - RBS_PIPE_WALL_THICKNESS = -1141040
    - MEP_PIPE_LOWER_INVERT_ELEVATION = -1141033
    - MEP_PIPE_UPPER_INVERT_ELEVATION = -1141032
    - MEP_PIPE_LOWER_OBVERT_ELEVATION = -1141031
    - MEP_PIPE_UPPER_OBVERT_ELEVATION = -1141030
    - MEP_LOWER_BOTTOM_ELEVATION_INCLUDE_INSULATION = -1141029
    - MEP_LOWER_TOP_ELEVATION_INCLUDE_INSULATION = -1141028
    - MEP_UPPER_BOTTOM_ELEVATION_INCLUDE_INSULATION = -1141027
    - MEP_UPPER_TOP_ELEVATION_INCLUDE_INSULATION = -1141026
    - MEP_LOWER_BOTTOM_ELEVATION = -1141025
    - MEP_LOWER_TOP_ELEVATION = -1141024
    - MEP_UPPER_BOTTOM_ELEVATION = -1141023
    - MEP_UPPER_TOP_ELEVATION = -1141022
    - MEP_LOWER_CENTERLINE_ELEVATION = -1141021
    - MEP_UPPER_CENTERLINE_ELEVATION = -1141020
    - FABRICATION_MATERIAL_GAUGE = -1141018
    - FABRICATION_DUCTWORK_STIFFENER_SPEC = -1141017
    - FABRICATION_PART_PAT_NO = -1141014
    - FABRICATION_END_SIZE = -1141013
    - FABRICATION_BRANCH_SIZE = -1141012
    - FABRICATION_SEC_SIZE = -1141011
    - FABRICATION_SEC_SIZE = -1141011
    - FABRICATION_PRI_SIZE = -1141010
    - FABRICATION_PRI_SIZE = -1141010
    - FABRICATION_CHANGE_SERVICE_PARAM = -1141009
    - FABRICATION_SET_UP_DOWN_TAG_FROM_BOTTOM = -1141008
    - FABRICATION_INSULATION_MATERIAL_FINISH = -1141007
    - DISPLACED_ELEMENT_DISPLACEMENT_Z = -1141006
    - DISPLACED_ELEMENT_DISPLACEMENT_Y = -1141005
    - DISPLACED_ELEMENT_DISPLACEMENT_X = -1141004
    - DISPLACEMENT_PATH_STYLE = -1141003
    - DISPLACEMENT_PATH_DEPTH = -1141002
    - REFERENCE_VIEWER_UI_TARGET_VIEW = -1141001
    - REFERENCE_VIEWER_UI_TARGET_FILTER = -1141000
    - FABRICATION_FITTING_DESCRIPTION = -1140999
    - FABRICATION_DOUBLEWALL_MATERIAL_ABBREVIATION = -1140998
    - FABRICATION_MATERIAL_ABBREVIATION = -1140997
    - FABRICATION_INSULATION_SPECIFICATION_ABBREVIATION = -1140996
    - FABRICATION_INSULATION_ABBREVIATION = -1140995
    - FABRICATION_SPECIFICATION_ABBREVIATION = -1140994
    - FABRICATION_PIPE_INVERT_ELEVATION = -1140993
    - FABRICATION_BOTTOM_ELEVATION_INCLUDE_INSULATION_OF_PART = -1140992
    - FABRICATION_BOTTOM_ELEVATION_OF_PART = -1140991
    - FABRICATION_TOP_ELEVATION_INCLUDE_INSULATION_OF_PART = -1140990
    - FABRICATION_TOP_ELEVATION_OF_PART = -1140989
    - MEP_SPOT_CENTERLINE_ELEVATION = -1140988
    - MEP_SPOT_CENTERLINE_ELEVATION = -1140988
    - MEP_SPOT_BOTTOM_ELEVATION_INCLUDE_INSULATION = -1140987
    - MEP_SPOT_BOTTOM_ELEVATION_INCLUDE_INSULATION = -1140987
    - MEP_SPOT_BOTTOM_ELEVATION = -1140986
    - MEP_SPOT_BOTTOM_ELEVATION = -1140986
    - MEP_SPOT_TOP_ELEVATION_INCLUDE_INSULATION = -1140985
    - MEP_SPOT_TOP_ELEVATION_INCLUDE_INSULATION = -1140985
    - FABRICATION_SPOT_TOP_ELEVATION_OF_PART = -1140984
    - FABRICATION_SPOT_TOP_ELEVATION_OF_PART = -1140984
    - FABRICATION_PART_DOUBLEWALL_MATERIAL_AREA = -1140983
    - FABRICATION_SET_UP_DOWN_TAG = -1140982
    - FABRICATION_PART_SHEETMETAL_AREA = -1140981
    - FABRICATION_SERVICE_ABBREVIATION = -1140979
    - FABRICATION_PART_MATERIAL_THICKNESS = -1140978
    - FABRICATION_PART_NOTES = -1140977
    - FABRICATION_PART_LINING_AREA = -1140976
    - FABRICATION_PART_ITEM_NUMBER = -1140975
    - FABRICATION_PART_INSULATION_AREA = -1140974
    - FABRICATION_SERVICE_NAME = -1140973
    - FABRICATION_PART_DOUBLEWALL_MATERIAL_THICKNESS = -1140972
    - FABRICATION_PART_DOUBLEWALL_MATERIAL = -1140971
    - FABRICATION_PART_CUT_TYPE = -1140970
    - FABRICATION_PART_BOUGHT_OUT = -1140969
    - FABRICATION_PART_ALIAS = -1140968
    - FABRICATION_ROUTING_SOLUTIONS_UI_PARAM = -1140967
    - FABRICATION_PRODUCT_CODE = -1140966
    - FABRICATION_PART_TAKEOFF_DIALOG_PARAM = -1140965
    - FABRICATION_PART_DEPTH_OUT_OPTION = -1140957
    - FABRICATION_PART_WIDTH_OUT_OPTION = -1140956
    - FABRICATION_PART_DIAMETER_OUT_OPTION = -1140955
    - FABRICATION_PART_DIAMETER_IN_OPTION = -1140952
    - FABRICATION_PART_DEPTH_IN_OPTION = -1140951
    - FABRICATION_PART_WIDTH_IN_OPTION = -1140950
    - FABRICATION_PART_ANGLE_OPTION = -1140949
    - FABRICATION_PART_LENGTH_OPTION = -1140948
    - FABRICATION_INSULATION_SPEC = -1140947
    - FABRICATION_PART_LENGTH = -1140944
    - FABRICATION_PRODUCT_ENTRY = -1140943
    - FABRICATION_PART_DEPTH_OUT = -1140935
    - FABRICATION_PART_WIDTH_OUT = -1140934
    - FABRICATION_PART_DIAMETER_OUT = -1140933
    - FABRICATION_PART_DEPTH_IN = -1140930
    - FABRICATION_PART_WIDTH_IN = -1140929
    - FABRICATION_END_OFFSET_PARAM = -1140925
    - FABRICATION_START_OFFSET_PARAM = -1140924
    - FABRICATION_SLOPE_PARAM = -1140923
    - FABRICATION_RELATIVE_FILENAME = -1140921
    - FABRICATION_VENDOR = -1140920
    - FABRICATION_BOTTOM_OF_PART = -1140919
    - FABRICATION_TOP_OF_PART = -1140918
    - FABRICATION_OFFSET_PARAM = -1140917
    - FABRICATION_LEVEL_PARAM = -1140916
    - FABRICATION_SPECIFICATION = -1140915
    - FABRICATION_VENDOR_CODE = -1140914
    - FABRICATION_PART_WEIGHT = -1140913
    - FABRICATION_PART_DIAMETER_IN = -1140912
    - FABRICATION_PART_ANGLE = -1140911
    - FABRICATION_PRODUCT_DATA_INSTALL_TYPE = -1140910
    - FABRICATION_PART_MATERIAL = -1140909
    - FABRICATION_PRODUCT_DATA_OEM = -1140908
    - FABRICATION_PRODUCT_DATA_PRODUCT = -1140907
    - FABRICATION_PRODUCT_DATA_ITEM_DESCRIPTION = -1140906
    - FABRICATION_PRODUCT_DATA_SIZE_DESCRIPTION = -1140905
    - FABRICATION_PRODUCT_DATA_MATERIAL_DESCRIPTION = -1140904
    - FABRICATION_PRODUCT_DATA_SPECIFICATION = -1140903
    - FABRICATION_PRODUCT_DATA_LONG_DESCRIPTION = -1140902
    - FABRICATION_PRODUCT_DATA_RANGE = -1140901
    - FABRICATION_PRODUCT_DATA_FINISH_DESCRIPTION = -1140900
    - TRUSS_FAMILY_BOTTOM_CHORD_STRUCTURAL_TYPES_PARAM = -1140766
    - TRUSS_FAMILY_BOTTOM_CHORD_ANGLE_PARAM = -1140764
    - TRUSS_FAMILY_BOTTOM_CHORD_VERTICAL_PROJECTION_PARAM = -1140763
    - TRUSS_FAMILY_BOTTOM_CHORD_START_RELEASE_TYPE = -1140762
    - TRUSS_FAMILY_BOTTOM_CHORD_END_RELEASE_TYPE = -1140761
    - REFERENCE_OTHER_VIEW_UI_REF_VIEW = -1140759
    - REFERENCE_OTHER_VIEW_UI_TOGGLE = -1140758
    - JOIST_SYSTEM_ELEM_TAG_NEW_MEMBERS_VIEW = -1140757
    - REFERENCE_VIEWER_ATTR_TAG = -1140756
    - REFERENCE_VIEWER_TARGET_VIEW = -1140755
    - MATCHLINE_BOTTOM_PLANE = -1140754
    - MATCHLINE_TOP_PLANE = -1140753
    - MATCHLINE_BOTTOM_OFFSET = -1140752
    - MATCHLINE_TOP_OFFSET = -1140751
    - TRUSS_FAMILY_TOP_CHORD_STRUCTURAL_TYPES_PARAM = -1140746
    - TRUSS_FAMILY_TOP_CHORD_ANGLE_PARAM = -1140744
    - TRUSS_FAMILY_TOP_CHORD_VERTICAL_PROJECTION_PARAM = -1140743
    - TRUSS_FAMILY_TOP_CHORD_START_RELEASE_TYPE = -1140742
    - TRUSS_FAMILY_TOP_CHORD_END_RELEASE_TYPE = -1140741
    - TRUSS_FAMILY_DIAG_WEB_STRUCTURAL_TYPES_PARAM = -1140736
    - TRUSS_FAMILY_DIAG_WEB_ANGLE_PARAM = -1140734
    - TRUSS_FAMILY_DIAG_WEB_START_RELEASE_TYPE = -1140732
    - TRUSS_FAMILY_DIAG_WEB_END_RELEASE_TYPE = -1140731
    - TRUSS_FAMILY_VERT_WEB_STRUCTURAL_TYPES_PARAM = -1140726
    - TRUSS_FAMILY_VERT_WEB_ANGLE_PARAM = -1140724
    - TRUSS_FAMILY_VERT_WEB_START_RELEASE_TYPE = -1140722
    - TRUSS_FAMILY_VERT_WEB_END_RELEASE_TYPE = -1140721
    - TRUSS_ELEMENT_TAG_NEW_MEMBERS_VIEW = -1140718
    - TRUSS_NON_BEARING_OFFSET_PARAM = -1140717
    - TRUSS_BEARING_CHORD_TOP_BOTTOM_PARAM = -1140716
    - TRUSS_ELEMENT_SPAN_PARAM = -1140715
    - TRUSS_ELEMENT_STICK_JUST_PARAM = -1140714
    - TRUSS_FAMILY_WEBS_HAVE_SYMBOLIC_CUTBACK_PARAM = -1140713
    - TRUSS_HEIGHT = -1140712
    - TRUSS_FAMILY_TRANSFORMATION_PARAM = -1140711
    - TRUSS_ELEMENT_ROTATE_CHORDS_WITH_TRUSS = -1140710
    - TRUSS_ELEMENT_REFERENCE_LEVEL_PARAM = -1140709
    - TRUSS_ELEMENT_END1_ELEVATION = -1140708
    - TRUSS_ELEMENT_END0_ELEVATION = -1140707
    - TRUSS_ELEMENT_BEARING_JUST_PARAM = -1140706
    - TRUSS_ELEMENT_CREATE_BOTTOM_PARAM = -1140705
    - TRUSS_ELEMENT_CREATE_TOP_PARAM = -1140704
    - TRUSS_ELEMENT_ANGLE_PARAM = -1140703
    - TRUSS_ELEMENT_CLASS_PARAM = -1140702
    - TRUSS_LENGTH = -1140700
    - BOUNDARY_PARAM_PRESET_AREA = -1140635
    - BOUNDARY_PARAM_PRESET_LINEAR = -1140634
    - BOUNDARY_PARAM_PRESET = -1140633
    - BOUNDARY_Z_TRANSLATION_SPRING = -1140532
    - BOUNDARY_Z_TRANSLATION_FIXED = -1140531
    - BOUNDARY_Z_ROTATION_SPRING = -1140530
    - BOUNDARY_Z_ROTATION_FIXED = -1140529
    - BOUNDARY_Y_TRANSLATION_SPRING = -1140528
    - BOUNDARY_Y_TRANSLATION_FIXED = -1140527
    - BOUNDARY_Y_ROTATION_SPRING = -1140526
    - BOUNDARY_Y_ROTATION_FIXED = -1140525
    - BOUNDARY_X_TRANSLATION_SPRING = -1140524
    - BOUNDARY_X_TRANSLATION_FIXED = -1140523
    - BOUNDARY_X_ROTATION_SPRING = -1140522
    - BOUNDARY_X_ROTATION_FIXED = -1140521
    - BOUNDARY_AREA_RESTRAINT_Z = -1140520
    - BOUNDARY_AREA_RESTRAINT_Y = -1140519
    - BOUNDARY_AREA_RESTRAINT_X = -1140518
    - BOUNDARY_LINEAR_RESTRAINT_ROT_X = -1140517
    - BOUNDARY_LINEAR_RESTRAINT_Z = -1140516
    - BOUNDARY_LINEAR_RESTRAINT_Y = -1140515
    - BOUNDARY_LINEAR_RESTRAINT_X = -1140514
    - BOUNDARY_RESTRAINT_ROT_Z = -1140513
    - BOUNDARY_RESTRAINT_ROT_Y = -1140512
    - BOUNDARY_RESTRAINT_ROT_X = -1140511
    - BOUNDARY_RESTRAINT_Z = -1140510
    - BOUNDARY_RESTRAINT_Y = -1140509
    - BOUNDARY_RESTRAINT_X = -1140508
    - BOUNDARY_DIRECTION_ROT_Z = -1140507
    - BOUNDARY_DIRECTION_ROT_Y = -1140506
    - BOUNDARY_DIRECTION_ROT_X = -1140505
    - BOUNDARY_DIRECTION_Z = -1140504
    - BOUNDARY_DIRECTION_Y = -1140503
    - BOUNDARY_DIRECTION_X = -1140502
    - BOUNDARY_CONDITIONS_IS_EXT = -1140501
    - BOUNDARY_CONDITIONS_TYPE = -1140500
    - KEY_SOURCE_PARAM = -1140423
    - KEYNOTE_PARAM = -1140422
    - KEYNOTE_NUMBER = -1140421
    - SHEET_KEY_NUMBER = -1140420
    - KEYNOTE_TEXT = -1140419
    - KEY_VALUE = -1140418
    - PHY_MATERIAL_PARAM_GRADE = -1140417
    - PHY_MATERIAL_PARAM_SPECIES = -1140416
    - PHY_MATERIAL_PARAM_EXP_COEFF = -1140415
    - PHY_MATERIAL_PARAM_BENDING = -1140414
    - PHY_MATERIAL_PARAM_SHEAR_MOD = -1140413
    - PHY_MATERIAL_PARAM_POISSON_MOD = -1140412
    - PHY_MATERIAL_PARAM_SHEAR_PERPENDICULAR = -1140410
    - PHY_MATERIAL_PARAM_SHEAR_PARALLEL = -1140409
    - PHY_MATERIAL_PARAM_COMPRESSION_PERPENDICULAR = -1140408
    - PHY_MATERIAL_PARAM_COMPRESSION_PARALLEL = -1140407
    - PHY_MATERIAL_PARAM_YOUNG_MOD = -1140401
    - PHY_MATERIAL_PARAM_TYPE = -1140400
    - ELEM_CATEGORY_PARAM_MT = -1140363
    - ELEM_CATEGORY_PARAM = -1140362
    - MATERIAL_VOLUME = -1140361
    - MATERIAL_AREA = -1140360
    - MATERIAL_ASPAINT = -1140359
    - MATERIAL_NAME = -1140355
    - RBS_PIPE_SLOPE_OPTIONS_DEF_PARAM = -1140340
    - FABRICATION_SERVICE_PARAM = -1140339
    - CONNECTOR_ANGLE_OF_DEFLECTION = -1140338
    - CONNECTOR_LENGTH = -1140337
    - RBS_DUCT_SYSTEM_CALCULATION_PARAM = -1140336
    - RBS_PIPE_SYSTEM_CALCULATION_PARAM = -1140335
    - RBS_PIPING_SYSTEM_TYPE_PARAM = -1140334
    - RBS_DUCT_SYSTEM_TYPE_PARAM = -1140333
    - RBS_SYSTEM_ABBREVIATION_PARAM = -1140332
    - MEP_SYSTEM_LINE_GRAPHICS_OVERRIDES_PARAM = -1140331
    - RBS_PIPE_SLOPE_DEF_PARAM = -1140330
    - CONNECTOR_ENGAGEMENT_LENGTH = -1140329
    - RBS_SYSTEM_FLOW_CONVERSION_METHOD_PARAM = -1140328
    - RBS_SYSTEM_NUM_ELEMENTS_PARAM = -1140327
    - RBS_SYSTEM_BASE_ELEMENT_PARAM = -1140326
    - RBS_SYSTEM_CLASSIFICATION_PARAM = -1140325
    - RBS_SYSTEM_NAME_PARAM = -1140324
    - PHY_MATERIAL_PARAM_LIGHT_WEIGHT = -1140323
    - PHY_MATERIAL_PARAM_BEHAVIOR = -1140322
    - PHY_MATERIAL_PARAM_RESISTANCE_CALC_STRENGTH = -1140321
    - PHY_MATERIAL_PARAM_REDUCTION_FACTOR = -1140320
    - PHY_MATERIAL_PARAM_MINIMUM_TENSILE_STRENGTH = -1140319
    - PHY_MATERIAL_PARAM_MINIMUM_YIELD_STRESS = -1140318
    - PHY_MATERIAL_PARAM_SHEAR_STRENGTH_REDUCTION = -1140317
    - PHY_MATERIAL_PARAM_SHEAR_REINFORCEMENT = -1140316
    - PHY_MATERIAL_PARAM_BENDING_REINFORCEMENT = -1140315
    - PHY_MATERIAL_PARAM_CONCRETE_COMPRESSION = -1140314
    - PHY_MATERIAL_PARAM_EXP_COEFF3 = -1140312
    - PHY_MATERIAL_PARAM_EXP_COEFF2 = -1140311
    - PHY_MATERIAL_PARAM_EXP_COEFF1 = -1140310
    - PHY_MATERIAL_PARAM_UNIT_WEIGHT = -1140309
    - PHY_MATERIAL_PARAM_SHEAR_MOD3 = -1140308
    - PHY_MATERIAL_PARAM_SHEAR_MOD2 = -1140307
    - PHY_MATERIAL_PARAM_SHEAR_MOD1 = -1140306
    - PHY_MATERIAL_PARAM_POISSON_MOD3 = -1140305
    - PHY_MATERIAL_PARAM_POISSON_MOD2 = -1140304
    - PHY_MATERIAL_PARAM_POISSON_MOD1 = -1140303
    - PHY_MATERIAL_PARAM_YOUNG_MOD3 = -1140302
    - PHY_MATERIAL_PARAM_YOUNG_MOD2 = -1140301
    - PHY_MATERIAL_PARAM_YOUNG_MOD1 = -1140300
    - PIPE_VELOCITY_PRESSURE = -1140285
    - RBS_PIPE_SIZE_MAXIMUM = -1140284
    - RBS_PIPE_SIZE_MINIMUM = -1140283
    - RBS_DUCT_PRESSURE_DROP = -1140282
    - ROUTING_PREFERENCE_PARAM = -1140281
    - RBS_DUCT_ROUTING_PREFERENCE_PARAM = -1140280
    - RBS_SEGMENT_DESCRIPTION_PARAM = -1140279
    - RBS_PIPE_JOINTTYPE_PARAM = -1140278
    - RBS_PIPE_SEGMENT_PARAM = -1140277
    - RBS_ROUTING_PREFERENCE_PARAM = -1140276
    - RBS_PARALLELPIPES_VERTICAL_OFFSET_VALUE = -1140275
    - RBS_PARALLELPIPES_HORIZONTAL_OFFSET_VALUE = -1140274
    - RBS_PARALLELPIPES_VERTICAL_NUMBER = -1140273
    - RBS_PARALLELPIPES_HORIZONTAL_NUMBER = -1140272
    - RBS_PARALLELCONDUITS_VERTICAL_OFFSET_VALUE = -1140271
    - RBS_PARALLELCONDUITS_HORIZONTAL_OFFSET_VALUE = -1140270
    - RBS_PARALLELCONDUITS_VERTICAL_NUMBER = -1140269
    - RBS_PARALLELCONDUITS_HORIZONTAL_NUMBER = -1140268
    - RBS_FP_SPRINKLER_ORIFICE_SIZE_PARAM = -1140266
    - RBS_FP_SPRINKLER_TEMPERATURE_RATING_PARAM = -1140265
    - RBS_FP_SPRINKLER_K_FACTOR_PARAM = -1140264
    - RBS_FP_SPRINKLER_PRESSURE_CLASS_PARAM = -1140263
    - RBS_FP_SPRINKLER_ORIFICE_PARAM = -1140262
    - RBS_FP_SPRINKLER_COVERAGE_PARAM = -1140261
    - RBS_FP_SPRINKLER_RESPONSE_PARAM = -1140260
    - MEP_PROFILE_TYPE_PARAM = -1140259
    - RBS_SHOW_PROFILE_TYPE = -1140258
    - RBS_PIPE_SYSTEM_FIXTURE_UNIT_PARAM = -1140257
    - RBS_PIPE_SLOPE = -1140256
    - RBS_DUCT_SLOPE = -1140255
    - RBS_CURVE_UTSLOPE = -1140254
    - RBS_PIPE_VOLUME_PARAM = -1140253
    - RBS_PIPE_WFU_PARAM = -1140252
    - RBS_PIPE_HWFU_PARAM = -1140251
    - RBS_PIPE_CWFU_PARAM = -1140250
    - RBS_PIPE_FLOW_CONFIGURATION_PARAM = -1140249
    - RBS_PIPE_FLOW_DIRECTION_PARAM = -1140248
    - RBS_PIPE_FIXTURE_UNITS_PARAM = -1140246
    - RBS_PIPE_STATIC_PRESSURE = -1140242
    - RBS_PIPE_INSULATION_THICKNESS = -1140241
    - RBS_DUCT_BOTTOM_ELEVATION = -1140240
    - RBS_DUCT_TOP_ELEVATION = -1140239
    - RBS_PIPE_OUTER_DIAMETER = -1140238
    - RBS_PIPE_INVERT_ELEVATION = -1140237
    - RBS_PIPE_TYPE_FITTING_LOSS_METHOD_PARAM = -1140234
    - RBS_PIPE_TYPE_FITTING_LOSS_TABLE_PARAM = -1140233
    - RBS_PIPE_TYPE_FITTING_LOSS_KFACTOR_PARAM = -1140232
    - RBS_PIPE_TYPE_VALVE_LOSS_CVFACTOR_PARAM = -1140231
    - RBS_PIPE_FITTING_LOSS_METHOD_PARAM = -1140230
    - RBS_PIPE_FITTING_LOSS_TABLE_PARAM = -1140229
    - RBS_PIPE_FITTING_LOSS_KFACTOR_PARAM = -1140228
    - RBS_PIPE_VALVE_LOSS_CVFACTOR_PARAM = -1140227
    - RBS_PIPE_ADDITIONAL_FLOW_PARAM = -1140226
    - RBS_PIPE_DIAMETER_PARAM = -1140225
    - RBS_CURVE_SLOPE = -1140224
    - RBS_ADJUSTABLE_CONNECTOR = -1140223
    - RBS_FLOW_FACTOR_PARAM = -1140222
    - RBS_DUCT_FLOW_CONFIGURATION_PARAM = -1140221
    - RBS_DUCT_FLOW_DIRECTION_PARAM = -1140219
    - RBS_PIPE_FLUID_TYPE_PARAM = -1140218
    - RBS_PIPE_FLUID_TEMPERATURE_PARAM = -1140217
    - RBS_PIPE_FLUID_VISCOSITY_PARAM = -1140215
    - RBS_PIPE_FLUID_DENSITY_PARAM = -1140214
    - RBS_PIPE_FLOW_PARAM = -1140213
    - RBS_PIPE_INNER_DIAM_PARAM = -1140212
    - RBS_PIPE_REYNOLDS_NUMBER_PARAM = -1140211
    - RELATIVE_ROUGHNESS = -1140210
    - RBS_PIPE_FLOW_STATE_PARAM = -1140209
    - FRICTION_FACTOR = -1140208
    - RBS_PIPE_VELOCITY_PARAM = -1140207
    - RBS_PIPE_FRICTION_PARAM = -1140206
    - RBS_PIPE_PRESSUREDROP_PARAM = -1140205
    - PIPE_ROUGHNESS = -1140204
    - RBS_PIPE_MATERIAL_PARAM = -1140202
    - RBS_PIPE_CONNECTIONTYPE_PARAM = -1140201
    - RBS_PIPE_CLASS_PARAM = -1140200
    - RBS_ELEC_DEMAND_CURRENT_PHASEC = -1140187
    - RBS_ELEC_DEMAND_CURRENT_PHASEB = -1140186
    - RBS_ELEC_DEMAND_CURRENT_PHASEA = -1140185
    - RBS_ELEC_DEMAND_LOAD_PHASEC = -1140184
    - RBS_ELEC_DEMAND_LOAD_PHASEB = -1140183
    - RBS_ELEC_DEMAND_LOAD_PHASEA = -1140182
    - RBS_ELEC_CIRCUIT_SLOT_INDEX = -1140181
    - CIRCUIT_WAYS_PARAM = -1140180
    - CIRCUIT_LOAD_CLASSIFICATION_ABBREVIATION_PARAM = -1140179
    - CIRCUIT_PHASE_PARAM = -1140178
    - RBS_ELEC_CIRCUIT_NAMING_INDEX = -1140177
    - RBS_ELEC_CIRCUIT_CONNECTION_TYPE_PARAM = -1140176
    - RBS_ELEC_CIRCUIT_PATH_OFFSET_PARAM = -1140175
    - RBS_ELEC_CIRCUIT_PATH_MODE_PARAM = -1140174
    - RBS_ELEC_CIRCUIT_START_SLOT = -1140173
    - CONNECTOR_GENDER_TYPE = -1140172
    - CONNECTOR_JOINT_TYPE = -1140171
    - RBS_ELEC_PANEL_CONFIGURATION_PARAM = -1140170
    - RBS_ELEC_PANEL_LOCATION_PARAM = -1140169
    - PANEL_SCHEDULE_NAME = -1140168
    - TEMPLATE_NAME = -1140167
    - RBS_ELEC_PANEL_CURRENT_PHASEC_PARAM = -1140166
    - RBS_ELEC_PANEL_CURRENT_PHASEB_PARAM = -1140165
    - RBS_ELEC_PANEL_CURRENT_PHASEA_PARAM = -1140164
    - RBS_ELEC_LOADSUMMARY_DEMAND_FACTOR_RULE_PARAM = -1140163
    - RBS_ELEC_LOADSUMMARY_DEMAND_CURRENT_PARAM = -1140162
    - RBS_ELEC_LOADSUMMARY_CONNECTED_CURRENT_PARAM = -1140161
    - RBS_ELEC_LOADSUMMARY_DEMAND_LOAD_PARAM = -1140160
    - RBS_ELEC_LOADSUMMARY_DEMAND_FACTOR_PARAM = -1140159
    - RBS_ELEC_LOADSUMMARY_CONNECTED_LOAD_PARAM = -1140158
    - RBS_ELEC_LOADSUMMARY_LOADCLASSIFICATION_PARAM = -1140157
    - RBS_ELEC_CIRCUIT_NOTES_PARAM = -1140156
    - RBS_ELEC_CIRCUIT_NUMBER_OF_ELEMENTS_PARAM = -1140155
    - RBS_ELEC_CIRCUIT_FRAME_PARAM = -1140154
    - RBS_ELEC_PANEL_TOTAL_DEMAND_CURRENT_PARAM = -1140153
    - RBS_ELEC_PANEL_TOTAL_CONNECTED_CURRENT_PARAM = -1140152
    - RBS_ELEC_PANEL_TOTAL_DEMAND_FACTOR_PARAM = -1140151
    - RBS_ELEC_PANEL_SCHEDULE_FOOTER_NOTES_PARAM = -1140150
    - RBS_ELEC_PANEL_SCHEDULE_HEADER_NOTES_PARAM = -1140149
    - RBS_ELEC_PANEL_NUMWIRES_PARAM = -1140148
    - RBS_ELEC_PANEL_NUMPHASES_PARAM = -1140147
    - RBS_ELEC_PANEL_NEUTRAL_RATING_PARAM = -1140146
    - RBS_ELEC_PANEL_NEUTRAL_BUS_PARAM = -1140145
    - RBS_ELEC_PANEL_GROUND_BUS_PARAM = -1140144
    - RBS_ELEC_PANEL_BUSSING_PARAM = -1140143
    - RBS_ELEC_PANEL_SUBFEED_LUGS_PARAM = -1140142
    - RBS_ELEC_PANEL_SUPPLY_FROM_PARAM = -1140141
    - RBS_ELEC_PANEL_MCB_RATING_PARAM = -1140140
    - RBS_ELEC_PANEL_MAINSTYPE_PARAM = -1140139
    - RBS_ELEC_PANEL_FEED_PARAM = -1140138
    - RBS_CONDUITRUN_OUTER_DIAM_PARAM = -1140137
    - RBS_CONDUITRUN_INNER_DIAM_PARAM = -1140136
    - RBS_CONDUITRUN_DIAMETER_PARAM = -1140135
    - RBS_CABLETRAYRUN_WIDTH_PARAM = -1140134
    - RBS_CABLETRAYRUN_HEIGHT_PARAM = -1140133
    - RBS_CABLETRAYCONDUITRUN_LENGTH_PARAM = -1140132
    - RBS_LOAD_SUB_CLASSIFICATION_MOTOR = -1140131
    - RBS_CABLETRAY_SHAPETYPE = -1140130
    - RBS_CABLETRAYCONDUIT_BENDORFITTING = -1140129
    - RBS_CTC_SERVICE_TYPE = -1140128
    - RBS_CONDUIT_OUTER_DIAM_PARAM = -1140127
    - RBS_CONDUIT_INNER_DIAM_PARAM = -1140126
    - RBS_CTC_BOTTOM_ELEVATION = -1140125
    - RBS_CTC_TOP_ELEVATION = -1140124
    - RBS_CONDUIT_DIAMETER_PARAM = -1140123
    - RBS_CABLETRAY_WIDTH_PARAM = -1140122
    - RBS_CABLETRAY_HEIGHT_PARAM = -1140121
    - CIRCUIT_LOAD_CLASSIFICATION_PARAM = -1140120
    - CABLETRAY_MINBENDMULTIPLIER_PARAM = -1140119
    - CONDUIT_STANDARD_TYPE_PARAM = -1140118
    - RBS_CONDUIT_TRADESIZE = -1140117
    - RBS_CONDUIT_BENDRADIUS = -1140116
    - RBS_CABLETRAY_BENDRADIUS = -1140115
    - RBS_CABLETRAY_RUNGHEIGHT = -1140114
    - RBS_CABLETRAY_RUNGWIDTH = -1140113
    - RBS_CABLETRAY_RUNGSPACE = -1140112
    - RBS_CABLETRAY_THICKNESS = -1140111
    - RBS_ELEC_SWITCH_ID_PARAM = -1140110
    - RBS_WIRE_CIRCUIT_DESCRIPTION = -1140109
    - RBS_WIRE_CIRCUIT_LOAD_NAME = -1140108
    - RBS_WIRE_NUM_CONDUCTORS_PARAM = -1140107
    - RBS_ELEC_WIRE_TICKMARK_STATE = -1140106
    - RBS_ELEC_CIRCUIT_PANEL_PARAM = -1140104
    - RBS_ELEC_CIRCUIT_NUMBER = -1140103
    - RBS_ELEC_WIRE_CIRCUITS = -1140102
    - RBS_ELEC_CIRCUIT_WIRE_NUM_RUNS_PARAM = -1140101
    - RBS_ELEC_CIRCUIT_WIRE_NUM_HOTS_PARAM = -1140100
    - RBS_ELEC_CIRCUIT_WIRE_NUM_NEUTRALS_PARAM = -1140099
    - RBS_ELEC_CIRCUIT_WIRE_NUM_GROUNDS_PARAM = -1140098
    - RBS_ELEC_WIRE_TYPE = -1140097
    - RBS_ELEC_WIRE_ELEVATION = -1140096
    - RBS_ELEC_WIRE_HOT_ADJUSTMENT = -1140094
    - RBS_ELEC_WIRE_NEUTRAL_ADJUSTMENT = -1140093
    - RBS_ELEC_WIRE_GROUND_ADJUSTMENT = -1140092
    - RBS_ELEC_WIRE_SHARE_NEUTRAL = -1140091
    - RBS_ELEC_WIRE_SHARE_GROUND = -1140090
    - RBS_ELEC_CIRCUIT_NAME = -1140089
    - RBS_FAMILY_CONTENT_SECONDARY_DISTRIBSYS = -1140088
    - RBS_ELEC_CIRCUIT_NAMING = -1140087
    - RBS_ELEC_CIRCUIT_PREFIX_SEPARATOR = -1140086
    - RBS_ELEC_CIRCUIT_PREFIX = -1140085
    - RBS_ELEC_MODIFICATIONS = -1140084
    - RBS_ELEC_ENCLOSURE = -1140083
    - RBS_ELEC_MAINS = -1140082
    - RBS_ELEC_MOUNTING = -1140081
    - RBS_ELEC_SHORT_CIRCUIT_RATING = -1140080
    - RBS_ELEC_MAX_POLE_BREAKERS = -1140079
    - RBS_ELEC_PANEL_NAME = -1140078
    - RBS_ELEC_PANEL_TOTALESTLOAD_HVAC_PARAM = -1140077
    - RBS_ELEC_PANEL_TOTALLOAD_HVAC_PARAM = -1140076
    - RBS_ELEC_PANEL_TOTALESTLOAD_LIGHT_PARAM = -1140075
    - RBS_ELEC_PANEL_TOTALLOAD_LIGHT_PARAM = -1140074
    - RBS_ELEC_PANEL_TOTALESTLOAD_POWER_PARAM = -1140073
    - RBS_ELEC_PANEL_TOTALLOAD_POWER_PARAM = -1140072
    - RBS_ELEC_PANEL_TOTALESTLOAD_OTHER_PARAM = -1140071
    - RBS_ELEC_PANEL_TOTALLOAD_OTHER_PARAM = -1140070
    - RBS_ELEC_PANEL_TOTALESTLOAD_PARAM = -1140069
    - RBS_ELEC_PANEL_TOTALLOAD_PARAM = -1140068
    - RBS_ELEC_DEMANDFACTOR_LOADCLASSIFICATION_PARAM = -1140067
    - RBS_ELEC_DEMANDFACTOR_LOAD_PARAM = -1140066
    - RBS_ELEC_DEMANDFACTOR_DEMANDLOAD_PARAM = -1140065
    - RBS_FAMILY_CONTENT_DISTRIBUTION_SYSTEM = -1140064
    - RBS_DISTRIBUTIONSYS_VLL_PARAM = -1140063
    - RBS_DISTRIBUTIONSYS_VLG_PARAM = -1140062
    - RBS_DISTRIBUTIONSYS_PHASE_PARAM = -1140061
    - RBS_DISTRIBUTIONSYS_CONFIG_PARAM = -1140060
    - RBS_DISTRIBUTIONSYS_NUMWIRES_PARAM = -1140059
    - RBS_VOLTAGETYPE_VOLTAGE_PARAM = -1140058
    - RBS_VOLTAGETYPE_MINVOLTAGE_PARAM = -1140057
    - RBS_VOLTAGETYPE_MAXVOLTAGE_PARAM = -1140056
    - RBS_ELEC_APPARENT_LOAD_PHASEC = -1140055
    - RBS_ELEC_APPARENT_LOAD_PHASEB = -1140054
    - RBS_ELEC_APPARENT_LOAD_PHASEA = -1140053
    - RBS_ELEC_TRUE_LOAD_PHASEC = -1140052
    - RBS_ELEC_TRUE_LOAD_PHASEB = -1140051
    - RBS_ELEC_TRUE_LOAD_PHASEA = -1140050
    - RBS_ELEC_TRUE_CURRENT_PARAM = -1140049
    - RBS_ELEC_TRUE_CURRENT_PHASEA_PARAM = -1140048
    - RBS_ELEC_TRUE_CURRENT_PHASEB_PARAM = -1140047
    - RBS_ELEC_TRUE_CURRENT_PHASEC_PARAM = -1140046
    - RBS_ELEC_APPARENT_CURRENT_PARAM = -1140045
    - RBS_ELEC_APPARENT_CURRENT_PHASEA_PARAM = -1140044
    - RBS_ELEC_APPARENT_CURRENT_PHASEB_PARAM = -1140043
    - RBS_ELEC_APPARENT_CURRENT_PHASEC_PARAM = -1140042
    - RBS_ELEC_VOLTAGE_DROP_PARAM = -1140041
    - RBS_ELEC_CALC_COEFFICIENT_UTILIZATION = -1140040
    - RBS_ELEC_CIRCUIT_LENGTH_PARAM = -1140039
    - RBS_ELEC_CIRCUIT_RATING_PARAM = -1140038
    - RBS_ELEC_CIRCUIT_WIRE_SIZE_PARAM = -1140037
    - RBS_ELEC_CIRCUIT_WIRE_TYPE_PARAM = -1140036
    - RBS_ELEC_ROOM_CAVITY_RATIO = -1140035
    - FBX_LIGHT_PHOTOMETRIC_FILE = -1140034
    - RBS_ELEC_ROOM_AVERAGE_ILLUMINATION = -1140033
    - RBS_ELEC_ROOM_REFLECTIVITY_FLOOR = -1140032
    - RBS_ELEC_ROOM_REFLECTIVITY_WALLS = -1140031
    - RBS_ELEC_ROOM_REFLECTIVITY_CEILING = -1140030
    - RBS_ELEC_ROOM_LIGHTING_CALC_WORKPLANE = -1140029
    - RBS_WIRE_MATERIAL_PARAM = -1140028
    - RBS_WIRE_TEMPERATURE_RATING_PARAM = -1140027
    - RBS_WIRE_INSULATION_PARAM = -1140026
    - RBS_WIRE_MAX_CONDUCTOR_SIZE_PARAM = -1140025
    - RBS_WIRE_NEUTRAL_MULTIPLIER_PARAM = -1140024
    - RBS_WIRE_NEUTRAL_INCLUDED_IN_BALANCED_LOAD_PARAM = -1140023
    - RBS_WIRE_NEUTRAL_MODE_PARAM = -1140022
    - RBS_WIRE_CONDUIT_TYPE_PARAM = -1140021
    - RBS_ELEC_AMBIENT_TEMPERATURE = -1140020
    - RBS_ELEC_CIRCUIT_TYPE = -1140018
    - RBS_ELEC_LOAD_CLASSIFICATION = -1140014
    - RBS_ELEC_TRUE_LOAD_PHASE3 = -1140013
    - RBS_ELEC_TRUE_LOAD_PHASE2 = -1140012
    - RBS_ELEC_TRUE_LOAD_PHASE1 = -1140011
    - RBS_ELEC_TRUE_LOAD = -1140010
    - RBS_ELEC_POWER_FACTOR_STATE = -1140009
    - RBS_ELEC_POWER_FACTOR = -1140008
    - RBS_ELEC_APPARENT_LOAD_PHASE3 = -1140007
    - RBS_ELEC_APPARENT_LOAD_PHASE2 = -1140006
    - RBS_ELEC_APPARENT_LOAD_PHASE1 = -1140005
    - RBS_ELEC_APPARENT_LOAD = -1140004
    - RBS_ELEC_BALANCED_LOAD = -1140003
    - RBS_ELEC_VOLTAGE = -1140002
    - RBS_ELEC_NUMBER_OF_POLES = -1140001
    - RBS_CONNECTOR_DESCRIPTION = -1140000
    - VIEW_FAMILY_SCHEDULES = -1139999
    - VIEW_FAMILY_AND_TYPE_SCHEDULES = -1139998
    - VIEW_TYPE_SCHEDULES = -1139997
    - MARKUPS_PRIVATE = -1133908
    - MARKUPS_NOTES = -1133907
    - MARKUPS_HISTORY = -1133906
    - MARKUPS_STATUS = -1133905
    - MARKUPS_LABEL = -1133904
    - MARKUPS_CREATOR = -1133903
    - MARKUPS_CREATED = -1133902
    - MARKUPS_MODIFIED = -1133901
    - VIEW_SCHEMA_SETTING_FOR_SYSTEM_TEMPLATE = -1133900
    - LEGEND_COMPONENT_DETAIL_LEVEL = -1133753
    - LEGEND_COMPONENT_LENGTH = -1133752
    - LEGEND_COMPONENT_VIEW = -1133751
    - LEGEND_COMPONENT = -1133750
    - OPTION_SET_ID = -1133603
    - OPTION_NAME = -1133602
    - PRIMARY_OPTION_ID = -1133601
    - OPTION_SET_NAME = -1133600
    - GROUP_ATTACHED_PARENT_NAME = -1133503
    - GROUP_ALLOWED_VIEW_TYPES = -1133502
    - GROUP_OFFSET_FROM_LEVEL = -1133501
    - GROUP_LEVEL = -1133500
    - MEP_SYSTEM_FILL_GRAPHICS_OVERRIDES_PARAM = -1133418
    - DUCT_TERMINAL_ENGAGEMENT_LENGTH = -1133417
    - CONNECTOR_INSIDE_DIAMETER = -1133416
    - CONNECTOR_DIAMETER = -1133415
    - RBS_CABLETRAYCONDUIT_CONNECTORELEM_TYPE = -1133414
    - RBS_CABLETRAYCONDUIT_SYSTEM_TYPE = -1133413
    - RBS_CONNECTOR_ISPRIMARY = -1133412
    - CONNECTOR_REFERENCE_INDEX = -1133411
    - RBS_PIPE_CONNECTOR_SYSTEM_CLASSIFICATION_PARAM = -1133410
    - CONNECTOR_ANGLE = -1133409
    - RBS_DUCT_CONNECTOR_SYSTEM_CLASSIFICATION_PARAM = -1133408
    - CONNECTOR_INDEX = -1133406
    - CONNECTOR_VISIBLE_SIZE = -1133405
    - CONNECTOR_HEIGHT = -1133404
    - CONNECTOR_WIDTH = -1133403
    - CONNECTOR_RADIUS = -1133401
    - CONNECTOR_PROFILE_TYPE = -1133400
    - USE_3D_SNAPPING = -1123513
    - ARC_ELEM_FIX_KEEP_CONCENTRIC = -1123512
    - PIPING_GENDER_TYPE = -1115974
    - PIPING_CONNECTION_TYPE = -1115973
    - RBS_PART_TYPE = -1115958
    - STRUCTURAL_CONNECTION_EDIT_RANGES_OF_APPLICABILITY = -1115520
    - WINDOWTYPE_IS_SCHEMATIC = -1114855
    - THERMAL_MATERIAL_SPECIFIC_HEAT_CAPACITY = -1114854
    - THERMAL_MATERIAL_DENSITY = -1114853
    - THERMAL_MATERIAL_CONDUCTIVITY = -1114852
    - THERMAL_MATERIAL_THICKNESS = -1114851
    - THERMAL_MATERIAL_DESCRIPTION = -1114850
    - THERMAL_MATERIAL_NAME = -1114849
    - SPACE_COMPOSEDNAME_PARAM = -1114848
    - SPACE_NUMBER_PARAM = -1114847
    - CONSTRUCTION_IS_SCHEMATIC = -1114846
    - ANALYTICAL_ZONE_NAME = -1114845
    - ZONE_DESIGN_COOL_TEMPERATURE = -1114844
    - ZONE_DESIGN_HEAT_TEMPERATURE = -1114843
    - ZONE_OUTSIDE_AIR_FLOW_PER_PERSON = -1114842
    - ZONE_OUTSIDE_AIR_FLOW_PER_AREA = -1114841
    - ZONE_AIR_CHANGES_PER_HOUR = -1114840
    - ANALYTICAL_ZONE = -1114839
    - SPACE_NUMBER_OF_PEOPLE = -1114838
    - SPACE_CONDITION_TYPE = -1114837
    - SPACE_TYPE_GBXML = -1114836
    - ANALYTICAL_SURFACE = -1114835
    - SURFACE_NAME = -1114834
    - ORIGINATING_ELEMENT_NAME = -1114833
    - WINDOW_TYPE_NAME = -1114832
    - CONSTRUCTION_NAME = -1114831
    - ANALYTIC_CONSTRUCTION = -1114830
    - TILT = -1114829
    - AZIMUTH = -1114828
    - ANALYTICAL_ADJACENT_SPACE = -1114827
    - ANALYTICAL_SPACE = -1114826
    - SPACE_NAME_PARAM = -1114825
    - SYSTEMS_ANALYSIS_REPORT_FOLDER = -1114824
    - SYSTEMS_ANALYSIS_REPORT_STYLE = -1114823
    - ENERGY_ANALYSIS_PROJECT_PHASE = -1114822
    - SPACE_VOLUME = -1114821
    - SPACE_AREA = -1114820
    - PEAK_LATENT_COOLING_LOAD = -1114819
    - PEAK_AIRFLOW_PARAM = -1114818
    - SPACE_REFERENCE_LEVEL_PARAM = -1114817
    - SPACE_INFILTRATION_AIRFLOW = -1114816
    - SPACE_INFILTRATION_AIRFLOW_PER_AREA = -1114815
    - SPACE_OUTDOOR_AIRFLOW = -1114814
    - SPACE_OUTDOOR_AIRFLOW_PER_PERSON = -1114813
    - SPACE_OUTDOOR_AIRFLOW_PER_AREA = -1114812
    - SPACE_AIR_CHANGES_PER_HOUR = -1114811
    - SPACE_POWER_LOAD_PARAM = -1114810
    - SPACE_LIGHTING_LOAD_PARAM = -1114809
    - SPACE_PEOPLE_LOAD_PARAM = -1114808
    - SPACE_POWER_LOAD_PER_AREA_PARAM = -1114807
    - SPACE_LIGHTING_LOAD_PER_AREA_PARAM = -1114806
    - SPACE_PEOPLE_LATENT_HEAT_GAIN_PER_PERSON_PARAM = -1114805
    - SPACE_PEOPLE_SENSIBLE_HEAT_GAIN_PER_PERSON_PARAM = -1114804
    - SPACE_AREA_PER_PERSON_PARAM = -1114803
    - SPACE_AIRFLOW_PER_AREA_PARAM = -1114802
    - PEAK_COOLING_LOAD_PARAM = -1114801
    - PEAK_HEATING_LOAD_PARAM = -1114800
    - SPACE_DEHUMIDIFICATION_SET_POINT = -1114711
    - SPACE_HUMIDIFICATION_SET_POINT = -1114710
    - SPACE_COOLING_SET_POINT = -1114709
    - SPACE_HEATING_SET_POINT = -1114708
    - ZONE_LEVEL_OFFSET_TOP = -1114707
    - ZONE_LEVEL_OFFSET = -1114706
    - SYSTEM_ZONE_LEVEL_ID = -1114705
    - ZONE_CALCULATED_HYDRONIC_COOLINGFLOW_PARAM = -1114702
    - ZONE_CALCULATED_HYDRONIC_HEATINGFLOW_PARAM = -1114701
    - ZONE_SPACE_OUTDOOR_AIR_OPTION_PARAM = -1114700
    - RBS_GBXML_OPENING_TYPE = -1114400
    - ROOM_CALCULATION_POINT = -1114399
    - GRID_BANK_COL_WIDTH = -1114398
    - GRID_BANK_ROW_HEIGHT = -1114397
    - GRID_BANK_COL_NUM = -1114396
    - GRID_BANK_ROW_NUM = -1114395
    - RBS_CURVETYPE_DEFAULT_BEND_PARAM = -1114394
    - RBS_CURVETYPE_DEFAULT_HORIZONTAL_BEND_PARAM = -1114393
    - RBS_CURVETYPE_MULTISHAPE_TRANSITION_OVALROUND_PARAM = -1114392
    - RBS_CURVETYPE_MULTISHAPE_TRANSITION_RECTOVAL_PARAM = -1114391
    - RBS_CURVETYPE_DEFAULT_TEEDOWN_PARAM = -1114390
    - RBS_CURVETYPE_DEFAULT_TEEUP_PARAM = -1114389
    - RBS_CURVETYPE_DEFAULT_ELBOWDOWN_PARAM = -1114388
    - RBS_CURVETYPE_DEFAULT_ELBOWUP_PARAM = -1114387
    - RBS_ENERGY_ANALYSIS_EXPORT_CATEGORY_PARAM = -1114386
    - RBS_ENERGY_ANALYSIS_EXPORT_COMPLEXITY_PARAM = -1114385
    - SPACE_ZONE_NAME = -1114384
    - RBS_ENERGY_ANALYSIS_EXPORT_GBXML_DEFAULTS_PARAM = -1114383
    - RBS_HVACLOAD_PLENUM_COOLING_LOAD_PARAM = -1114382
    - RBS_HVACLOAD_SKYLIGHT_COOLING_LOAD_PARAM = -1114381
    - RBS_HVACLOAD_PARTITION_COOLING_LOAD_PARAM = -1114380
    - RBS_HVACLOAD_DOOR_COOLING_LOAD_PARAM = -1114379
    - RBS_HVACLOAD_WINDOW_COOLING_LOAD_PARAM = -1114378
    - RBS_HVACLOAD_WALL_COOLING_LOAD_PARAM = -1114377
    - RBS_HVACLOAD_ROOF_COOLING_LOAD_PARAM = -1114376
    - RBS_HVACLOAD_SKYLIGHT_AREA_PARAM = -1114375
    - RBS_HVACLOAD_PARTITION_AREA_PARAM = -1114374
    - RBS_HVACLOAD_FLOOR_AREA_PARAM = -1114373
    - RBS_HVACLOAD_DOOR_AREA_PARAM = -1114372
    - RBS_HVACLOAD_WINDOW_AREA_PARAM = -1114371
    - RBS_HVACLOAD_WALL_AREA_PARAM = -1114370
    - RBS_HVACLOAD_ROOF_AREA_PARAM = -1114369
    - RBS_ENERGY_ANALYSIS_VIEW_COORD_AXIS_MODE = -1114368
    - RBS_ENERGY_ANALYSIS_VIEW_RBE_MODE = -1114367
    - RBS_ENERGY_ANALYSIS_VIEW_SHADING_SURFACES_MODE = -1114366
    - RBS_ENERGY_ANALYSIS_VIEW_TRANSPARENT_MODE = -1114365
    - RBS_ENERGY_ANALYSIS_VIEW_SURFACES_MODE = -1114364
    - RBS_ENERGY_ANALYSIS_VIEW_INNER_SHELL_MODE = -1114363
    - RBS_ENERGY_ANALYSIS_VIEW_OUTER_SHELL_MODE = -1114362
    - RBS_ENERGY_ANALYSIS_VIEW_BUILDING_SHELL_MODE = -1114361
    - RBS_LINING_THICKNESS_FOR_DUCT = -1114360
    - RBS_INSULATION_THICKNESS_FOR_PIPE = -1114359
    - RBS_INSULATION_THICKNESS_FOR_DUCT = -1114358
    - BUILDING_UNOCCUPIED_COOLING_SET_POINT_PARAM = -1114357
    - BUILDING_CLOSING_TIME_PARAM = -1114356
    - BUILDING_OPENING_TIME_PARAM = -1114355
    - SPACE_PEOPLE_ACTIVITY_LEVEL_PARAM = -1114354
    - SPACE_ELEC_EQUIPMENT_RADIANT_PERCENTAGE_PARAM = -1114353
    - SPACE_POWER_SCHEDULE_PARAM = -1114351
    - SPACE_LIGHTING_SCHEDULE_PARAM = -1114350
    - SPACE_OCCUPANCY_SCHEDULE_PARAM = -1114349
    - SPACE_INFILTRATION_PARAM = -1114348
    - SPACE_CARPETING_PARAM = -1114347
    - ZONE_AIR_VOLUME_CALCULATION_TYPE_PARAM = -1114345
    - ZONE_COIL_BYPASS_PERCENTAGE_PARAM = -1114344
    - ZONE_CALCULATED_AREA_PER_COOLING_LOAD_PARAM = -1114343
    - ZONE_CALCULATED_AREA_PER_HEATING_LOAD_PARAM = -1114342
    - ZONE_USE_AIR_CHANGES_PER_HOUR_PARAM = -1114341
    - ZONE_USE_OUTSIDE_AIR_PER_AREA_PARAM = -1114340
    - ZONE_USE_OUTSIDE_AIR_PER_PERSON_PARAM = -1114339
    - ZONE_USE_DEHUMIDIFICATION_SETPOINT_PARAM = -1114338
    - ZONE_USE_HUMIDIFICATION_SETPOINT_PARAM = -1114337
    - ZONE_OUTDOOR_AIR_INFORMATION_PARAM = -1114336
    - ZONE_COOLING_INFORMATION_PARAM = -1114335
    - ZONE_HEATING_INFORMATION_PARAM = -1114334
    - RBS_ENERGY_ANALYSIS_SLIVER_SPACE_TOLERANCE = -1114333
    - ZONE_AREA_GROSS = -1114332
    - ZONE_VOLUME_GROSS = -1114331
    - SPACE_IS_PLENUM = -1114330
    - SPACE_IS_OCCUPIABLE = -1114329
    - SPACE_ASSOC_ROOM_NUMBER = -1114328
    - SPACE_ASSOC_ROOM_NAME = -1114327
    - ZONE_PHASE = -1114326
    - ZONE_PHASE_ID = -1114325
    - RBS_ENERGY_ANALYSIS_PROJECT_PHASE_PARAM = -1114324
    - ROOM_CALCULATED_SUPPLY_AIRFLOW_PER_AREA_PARAM = -1114323
    - ROOM_CALCULATED_COOLING_LOAD_PER_AREA_PARAM = -1114322
    - ROOM_CALCULATED_HEATING_LOAD_PER_AREA_PARAM = -1114321
    - ZONE_CALCULATED_SUPPLY_AIRFLOW_PER_AREA_PARAM = -1114320
    - ZONE_CALCULATED_COOLING_LOAD_PER_AREA_PARAM = -1114319
    - ZONE_CALCULATED_HEATING_LOAD_PER_AREA_PARAM = -1114318
    - ZONE_LEVEL_ID = -1114317
    - ZONE_OA_RATE_PER_ACH_PARAM = -1114316
    - ZONE_OUTSIDE_AIR_PER_AREA_PARAM = -1114315
    - ZONE_OUTSIDE_AIR_PER_PERSON_PARAM = -1114314
    - ZONE_DEHUMIDIFICATION_SET_POINT_PARAM = -1114313
    - ZONE_HUMIDIFICATION_SET_POINT_PARAM = -1114312
    - ZONE_COOLING_AIR_TEMPERATURE_PARAM = -1114311
    - ZONE_HEATING_AIR_TEMPERATURE_PARAM = -1114310
    - ZONE_COOLING_SET_POINT_PARAM = -1114309
    - ZONE_HEATING_SET_POINT_PARAM = -1114308
    - ZONE_CALCULATED_SUPPLY_AIRFLOW_PARAM = -1114307
    - ZONE_CALCULATED_COOLING_LOAD_PARAM = -1114306
    - ZONE_CALCULATED_HEATING_LOAD_PARAM = -1114305
    - ZONE_SERVICE_TYPE_PARAM = -1114304
    - ZONE_VOLUME = -1114303
    - ZONE_PERIMETER = -1114302
    - ZONE_AREA = -1114301
    - ZONE_NAME = -1114300
    - RBS_ENERGY_ANALYSIS_VIEW_UPDATE_SURFACES = -1114299
    - RBS_PROJECT_CONSTRUCTION_TYPE_SHADINGFACTOR_PARAM = -1114296
    - RBS_CONSTRUCTION_TYPE_SHADINGFACTOR_PARAM = -1114295
    - RBS_ENERGY_ANALYSIS_GROUND_PLANE_PARAM = -1114293
    - RBS_ENERGY_ANALYSIS_SURFACE_ORIGIN_Z = -1114292
    - RBS_ENERGY_ANALYSIS_SURFACE_ORIGIN_Y = -1114291
    - RBS_ENERGY_ANALYSIS_SURFACE_ORIGIN_X = -1114290
    - RBS_ENERGY_ANALYSIS_SURFACE_AZIMUTH = -1114289
    - RBS_ENERGY_ANALYSIS_SURFACE_TILT = -1114288
    - RBS_ENERGY_ANALYSIS_SURFACE_CADOBJECTID = -1114287
    - RBS_ENERGY_ANALYSIS_SURFACE_ADJACENT_SPACE_ID2 = -1114286
    - RBS_ENERGY_ANALYSIS_SURFACE_ADJACENT_SPACE_ID1 = -1114285
    - ROOM_EDIT_ELECTRICAL_LOADS_PARAM = -1114284
    - ROOM_EDIT_PEOPLE_LOADS_PARAM = -1114283
    - RBS_PROJECT_LOCATION_PARAM = -1114282
    - ROOM_ACTUAL_LIGHTING_LOAD_PER_AREA_PARAM = -1114261
    - ROOM_ACTUAL_POWER_LOAD_PER_AREA_PARAM = -1114260
    - ROOM_BASE_HEAT_LOAD_ON_PARAM = -1114259
    - ROOM_LIGHTING_LOAD_UNITS_PARAM = -1114258
    - ROOM_POWER_LOAD_UNITS_PARAM = -1114257
    - ROOM_DESIGN_COOLING_LOAD_PARAM = -1114256
    - ROOM_CALCULATED_COOLING_LOAD_PARAM = -1114255
    - ROOM_DESIGN_HEATING_LOAD_PARAM = -1114254
    - ROOM_CALCULATED_HEATING_LOAD_PARAM = -1114253
    - ROOM_BASE_RETURN_AIRFLOW_ON_PARAM = -1114252
    - ROOM_CONSTRUCTION_SET_PARAM = -1114251
    - RBS_CONSTRUCTION_SET_PARAM = -1114249
    - RBS_SERVICE_TYPE_PARAM = -1114248
    - RBS_GBXML_SURFACE_AREA = -1114247
    - RBS_GBXML_SURFACE_TYPE = -1114246
    - RBS_GBXML_SURFACE_NAME = -1114245
    - FAMILY_ELECTRICAL_MAINTAIN_ANNOTATION_ORIENTATION = -1114243
    - RBS_FAMILY_CONTENT_ANNOTATION_DISPLAY = -1114242
    - RBS_ELECTRICAL_DATA = -1114241
    - RBS_CALCULATED_SIZE = -1114240
    - ROOM_PEOPLE_SENSIBLE_HEAT_GAIN_PER_PERSON_PARAM = -1114239
    - RBS_IS_CUSTOM_FITTING = -1114238
    - RBS_CONNECTOR_OFFSET_OBSOLETE = -1114237
    - RBS_LOOKUP_TABLE_NAME = -1114236
    - ROOM_DESIGN_LIGHTING_LOAD_PARAM = -1114230
    - ROOM_DESIGN_POWER_LOAD_PARAM = -1114229
    - ROOM_ACTUAL_LIGHTING_LOAD_PARAM = -1114226
    - ROOM_ACTUAL_POWER_LOAD_PARAM = -1114225
    - ROOM_BASE_LIGHTING_LOAD_ON_PARAM = -1114224
    - ROOM_BASE_POWER_LOAD_ON_PARAM = -1114223
    - ROOM_DESIGN_OTHER_LOAD_PER_AREA_PARAM = -1114222
    - ROOM_DESIGN_MECHANICAL_LOAD_PER_AREA_PARAM = -1114221
    - ROOM_DESIGN_LIGHTING_LOAD_PER_AREA_PARAM = -1114220
    - ROOM_DESIGN_POWER_LOAD_PER_AREA_PARAM = -1114219
    - FBX_LIGHT_BALLAST_LOSS = -1114218
    - FBX_LIGHT_TOTAL_LIGHT_LOSS = -1114217
    - RBS_ROOM_COEFFICIENT_UTILIZATION = -1114216
    - RBS_FAMILY_CONTENT_TAKEOFF_FIXED_LENGTH = -1114215
    - RBS_FAMILY_CONTENT_TAKEOFF_PROJLENGTH = -1114214
    - RBS_FAMILY_CONTENT_TAKEOFF_LENGTH = -1114213
    - RBS_FAMILY_CONTENT_OFFSET_HEIGHT = -1114212
    - RBS_FAMILY_CONTENT_OFFSET_WIDTH = -1114211
    - FAMILY_CONTENT_PART_TYPE = -1114206
    - GBXML_EDIT_DATA_PARAM = -1114197
    - ROOM_ACTUAL_EXHAUST_AIRFLOW_PARAM = -1114196
    - ROOM_ACTUAL_RETURN_AIRFLOW_PARAM = -1114195
    - ROOM_ACTUAL_SUPPLY_AIRFLOW_PARAM = -1114194
    - ROOM_PEOPLE_LATENT_HEAT_GAIN_PER_PERSON_PARAM = -1114189
    - ROOM_PEOPLE_TOTAL_HEAT_GAIN_PER_PERSON_PARAM = -1114188
    - ROOM_CALCULATED_SUPPLY_AIRFLOW_PARAM = -1114180
    - ROOM_DESIGN_EXHAUST_AIRFLOW_PARAM = -1114178
    - ROOM_DESIGN_RETURN_AIRFLOW_PARAM = -1114177
    - ROOM_DESIGN_SUPPLY_AIRFLOW_PARAM = -1114176
    - ROOM_AREA_PER_PERSON_PARAM = -1114175
    - ROOM_NUMBER_OF_PEOPLE_PARAM = -1114174
    - ROOM_OCCUPANCY_UNIT_PARAM = -1114173
    - ROOM_SPACE_TYPE_PARAM = -1114172
    - ROOM_CONDITION_TYPE_PARAM = -1114171
    - PROJECT_POSTAL_CODE = -1114169
    - PROJECT_BUILDING_TYPE = -1114168
    - RBS_SIZE_LOCK = -1114167
    - RBS_ADDITIONAL_FLOW = -1114166
    - RBS_CURVETYPE_MAX_WIDTH_PARAM = -1114165
    - RBS_PIPE_FITTING_LOSS_METHOD_SETTINGS = -1114150
    - RBS_DUCT_FITTING_LOSS_METHOD_SETTINGS = -1114149
    - RBS_CURVETYPE_DEFAULT_CAP_PARAM = -1114148
    - RBS_PIPE_FITTING_LOSS_METHOD_SERVER_PARAM = -1114147
    - RBS_DUCT_FITTING_LOSS_METHOD_SERVER_PARAM = -1114146
    - RBS_CURVETYPE_DEFAULT_MECHJOINT_PARAM = -1114145
    - RBS_PIPE_SIZE_FORMATTED_PARAM = -1114144
    - RBS_DUCT_SIZE_FORMATTED_PARAM = -1114143
    - RBS_DUCT_STATIC_PRESSURE = -1114142
    - RBS_FLEX_PIPE_TYPE_PARAM = -1114141
    - RBS_PIPE_TYPE_PARAM = -1114140
    - RBS_FLEX_DUCT_TYPE_PARAM = -1114139
    - RBS_DUCT_TYPE_PARAM = -1114138
    - RBS_DUCT_FITTING_LOSS_TABLE_PARAM = -1114137
    - RBS_DUCT_FITTING_LOSS_METHOD_PARAM = -1114136
    - RBS_FLEXDUCT_ROUNDTYPE_PARAM = -1114135
    - RBS_CURVETYPE_PREFERRED_BRANCH_PARAM = -1114134
    - RBS_CURVETYPE_DEFAULT_TAKEOFF_PARAM = -1114133
    - RBS_OFFSET_PARAM = -1114132
    - RBS_CURVETYPE_DEFAULT_UNION_PARAM = -1114131
    - RBS_HYDRAULIC_DIAMETER_PARAM = -1114129
    - RBS_REYNOLDSNUMBER_PARAM = -1114128
    - RBS_EQ_DIAMETER_PARAM = -1114127
    - RBS_CURVETYPE_MULTISHAPE_TRANSITION_PARAM = -1114126
    - RBS_SECTION = -1114125
    - RBS_LOSS_COEFFICIENT = -1114124
    - RBS_MAX_FLOW = -1114123
    - RBS_MIN_FLOW = -1114122
    - RBS_VELOCITY_PRESSURE = -1114121
    - RBS_CURVE_SURFACE_AREA = -1114120
    - RBS_CURVETYPE_MAX_HEIGHT_PARAM = -1114119
    - RBS_LINING_THICKNESS = -1114118
    - RBS_INSULATION_THICKNESS = -1114117
    - RBS_FRICTION = -1114116
    - DUCT_ROUGHNESS = -1114114
    - RBS_CURVETYPE_DEFAULT_TRANSITION_PARAM = -1114113
    - RBS_CURVETYPE_DEFAULT_CROSS_PARAM = -1114112
    - RBS_CURVETYPE_DEFAULT_TEE_PARAM = -1114111
    - RBS_CURVETYPE_DEFAULT_ELBOW_PARAM = -1114110
    - RBS_PRESSURE_DROP = -1114108
    - RBS_VELOCITY = -1114107
    - RBS_CURVE_VERT_OFFSET_PARAM = -1114106
    - RBS_CURVE_HOR_OFFSET_PARAM = -1114105
    - RBS_FLOW_OBSOLETE = -1114104
    - RBS_CURVE_DIAMETER_PARAM = -1114103
    - RBS_CURVE_HEIGHT_PARAM = -1114102
    - RBS_CURVE_WIDTH_PARAM = -1114101
    - RBS_FLEX_PATTERN_PARAM = -1114005
    - RBS_END_OFFSET_PARAM = -1114003
    - RBS_START_OFFSET_PARAM = -1114002
    - RBS_END_LEVEL_PARAM = -1114001
    - RBS_START_LEVEL_PARAM = -1114000
    - ANALYTICAL_MEMBER_FORCE_END_ALL_NON_ZERO = -1060014
    - ANALYTICAL_MEMBER_FORCE_START_ALL_NON_ZERO = -1060013
    - STRUCTURAL_MEMBER_FORCES = -1060012
    - ANALYTICAL_MEMBER_FORCE_END_MZ = -1060011
    - ANALYTICAL_MEMBER_FORCE_END_MY = -1060010
    - ANALYTICAL_MEMBER_FORCE_END_MX = -1060009
    - ANALYTICAL_MEMBER_FORCE_END_FZ = -1060008
    - ANALYTICAL_MEMBER_FORCE_END_FY = -1060007
    - ANALYTICAL_MEMBER_FORCE_END_FX = -1060006
    - ANALYTICAL_MEMBER_FORCE_START_MZ = -1060005
    - ANALYTICAL_MEMBER_FORCE_START_MY = -1060004
    - ANALYTICAL_MEMBER_FORCE_START_MX = -1060003
    - ANALYTICAL_MEMBER_FORCE_START_FZ = -1060002
    - ANALYTICAL_MEMBER_FORCE_START_FY = -1060001
    - ANALYTICAL_MEMBER_FORCE_START_FX = -1060000
    - DIVIDEDPATH_TOTAL_PATH_LENGTH = -1050441
    - DIVIDEDPATH_DISPLAY_NODE_NUMBERS = -1050440
    - DIVIDEDPATH_MERGED_POINT_NUM = -1050439
    - DIVIDEDPATH_DISPLAY_NODES = -1050437
    - DIVIDEDPATH_DISPLAY_REFERENCE_CURVES = -1050436
    - DIVIDEDPATH_JUSTIFICATION = -1050435
    - DIVIDEDPATH_LAYOUT_FIXED_NUM_POINT = -1050434
    - DIVIDEDPATH_FLIP_DIRECTION = -1050433
    - DIVIDEDPATH_MEASUREMENT_TYPE = -1050432
    - DIVIDEDPATH_MAX_DISTANCE = -1050431
    - DIVIDEDPATH_MIN_DISTANCE = -1050430
    - DIVIDEDPATH_END_INDENT = -1050429
    - DIVIDEDPATH_BEGINNING_INDENT = -1050428
    - DIVIDEDPATH_DISTANCE = -1050427
    - DIVIDEDPATH_LAYOUT = -1050426
    - ALIGNMENT_STATION_LABEL_SET_END_STATION = -1019203
    - ALIGNMENT_STATION_LABEL_SET_START_STATION = -1019202
    - ALIGNMENT_STATION_LABEL_SET_INTERVAL = -1019201
    - ALIGNMENT_STATION_LABEL_SET_OFFSET = -1019200
    - WALL_TAPERED_WIDTH_AT_BOTTOM = -1019121
    - WALL_TAPERED_WIDTH_AT_TOP = -1019120
    - WALL_TAPERED_USE_INSTANCE_ANGLES = -1019110
    - WALL_TYPE_WIDTH_MEASURED_AT = -1019107
    - WALL_TYPE_DEFAULT_TAPERED_INTERIOR_INWARD_ANGLE = -1019106
    - WALL_TYPE_DEFAULT_TAPERED_EXTERIOR_INWARD_ANGLE = -1019105
    - WALL_TAPERED_INTERIOR_INWARD_ANGLE = -1019103
    - WALL_TAPERED_EXTERIOR_INWARD_ANGLE = -1019102
    - WALL_SINGLE_SLANT_ANGLE_FROM_VERTICAL = -1019101
    - WALL_CROSS_SECTION = -1019100
    - IFC_IMPORT_MATERIAL_NAME = -1019018
    - IFC_EXPORT_PREDEFINEDTYPE_TYPE = -1019017
    - IFC_EXPORT_PREDEFINEDTYPE = -1019016
    - IFC_EXPORT_ELEMENT_TYPE_AS = -1019015
    - IFC_EXPORT_ELEMENT_AS = -1019014
    - IFC_EXPORT_ELEMENT_TYPE = -1019013
    - IFC_EXPORT_ELEMENT = -1019012
    - IFC_ORGANIZATION = -1019011
    - IFC_APPLICATION_VERSION = -1019010
    - IFC_APPLICATION_NAME = -1019009
    - PROJECT_ORGANIZATION_NAME = -1019008
    - PROJECT_ORGANIZATION_DESCRIPTION = -1019007
    - PROJECT_BUILDING_NAME = -1019006
    - PROJECT_AUTHOR = -1019005
    - IFC_SITE_GUID = -1019004
    - IFC_BUILDING_GUID = -1019003
    - IFC_PROJECT_GUID = -1019002
    - IFC_TYPE_GUID = -1019001
    - IFC_GUID = -1019000
    - STRUCT_CONNECTION_TYPE_NAME = -1018850
    - STRUCT_CONNECTION_CUTBACK = -1018805
    - STRUCT_CONNECTION_COLUMN_BASE = -1018804
    - STRUCT_CONNECTION_COLUMN_TOP = -1018803
    - STRUCT_CONNECTION_BEAM_END = -1018802
    - STRUCT_CONNECTION_BEAM_START = -1018801
    - STRUCT_CONNECTION_APPLY_TO = -1018800
    - LEADER_ORIENTATION = -1018707
    - LEADER_ANGLE = -1018706
    - LEADER_LENGTH = -1018705
    - REBAR_CONTAINER_BAR_TYPE = -1018505
    - REINFORCEMENT_VOLUME = -1018503
    - REIN_EST_BAR_VOLUME = -1018502
    - REIN_EST_BAR_LENGTH = -1018501
    - REIN_EST_NUMBER_OF_BARS = -1018500
    - PATH_REIN_SHAPE_2 = -1018362
    - PATH_REIN_SHAPE_1 = -1018361
    - PATH_REIN_SPANLENGTH_ALT_OFFSET = -1018360
    - PATH_REIN_SPANLENGTH_BARLENGTH_ALT = -1018359
    - PATH_REIN_SPANLENGTH_BARLENGTH_PRIM = -1018358
    - PATH_REIN_SPANLENGTH_TOP_ALT = -1018357
    - PATH_REIN_END_SPANHOOK_ALT = -1018356
    - PATH_REIN_END_SPANHOOK_PRIM = -1018355
    - PATH_REIN_SUMMARY = -1018354
    - PATH_REIN_SPANLENGTH_BOTTOM_ALT = -1018353
    - PATH_REIN_SPANLENGTH_BOTTOM_PRIM = -1018352
    - PATH_REIN_SPANHOOK_ALT = -1018351
    - PATH_REIN_SPANHOOK_PRIM = -1018350
    - PATH_REIN_ADDL_OFFSET = -1018322
    - PATH_REIN_ALT_OFFSET = -1018321
    - PATH_REIN_END_HOOK_ORIENT_2_WALL = -1018320
    - PATH_REIN_END_HOOK_ORIENT_1_WALL = -1018319
    - PATH_REIN_END_HOOK_ORIENT_2_SLAB = -1018318
    - PATH_REIN_END_HOOK_ORIENT_1_SLAB = -1018317
    - PATH_REIN_END_HOOK_TYPE_2 = -1018316
    - PATH_REIN_END_HOOK_TYPE_1 = -1018315
    - PATH_REIN_HOOK_ORIENT_2_WALL = -1018314
    - PATH_REIN_HOOK_ORIENT_1_WALL = -1018313
    - PATH_REIN_HOOK_ORIENT_2_SLAB = -1018312
    - PATH_REIN_HOOK_ORIENT_1_SLAB = -1018311
    - PATH_REIN_HOOK_TYPE_2 = -1018310
    - PATH_REIN_HOOK_TYPE_1 = -1018309
    - PATH_REIN_LENGTH_2 = -1018308
    - PATH_REIN_LENGTH_1 = -1018307
    - PATH_REIN_TYPE_2 = -1018306
    - PATH_REIN_TYPE_1 = -1018305
    - PATH_REIN_ALTERNATING = -1018304
    - PATH_REIN_NUMBER_OF_BARS = -1018303
    - PATH_REIN_SPACING = -1018302
    - PATH_REIN_FACE_WALL = -1018301
    - PATH_REIN_FACE_SLAB = -1018300
    - REBAR_BAR_DEFORMATION_TYPE = -1018274
    - REBAR_SYSTEM_SPACING_BOTTOM_DIR_2_GENERIC = -1018273
    - REBAR_SYSTEM_SPACING_BOTTOM_DIR_1_GENERIC = -1018272
    - REBAR_SYSTEM_SPACING_TOP_DIR_2_GENERIC = -1018271
    - REBAR_SYSTEM_SPACING_TOP_DIR_1_GENERIC = -1018270
    - REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_2_GENERIC = -1018269
    - REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_1_GENERIC = -1018268
    - REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_2_GENERIC = -1018267
    - REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_1_GENERIC = -1018266
    - REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_2_GENERIC = -1018257
    - REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_1_GENERIC = -1018256
    - REBAR_SYSTEM_BAR_TYPE_TOP_DIR_2_GENERIC = -1018255
    - REBAR_SYSTEM_BAR_TYPE_TOP_DIR_1_GENERIC = -1018254
    - REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_2_GENERIC = -1018253
    - REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_1_GENERIC = -1018252
    - REBAR_SYSTEM_ACTIVE_TOP_DIR_2_GENERIC = -1018251
    - REBAR_SYSTEM_ACTIVE_TOP_DIR_1_GENERIC = -1018250
    - REBAR_SYSTEM_SPACING_BACK_DIR_2 = -1018225
    - REBAR_SYSTEM_SPACING_BACK_DIR_1 = -1018224
    - REBAR_SYSTEM_SPACING_FRONT_DIR_2 = -1018223
    - REBAR_SYSTEM_SPACING_FRONT_DIR_1 = -1018222
    - REBAR_SYSTEM_NUMBER_OF_LINES_BACK_DIR_2 = -1018221
    - REBAR_SYSTEM_NUMBER_OF_LINES_BACK_DIR_1 = -1018220
    - REBAR_SYSTEM_NUMBER_OF_LINES_FRONT_DIR_2 = -1018219
    - REBAR_SYSTEM_NUMBER_OF_LINES_FRONT_DIR_1 = -1018218
    - REBAR_SYSTEM_HOOK_TYPE_BACK_DIR_2 = -1018217
    - REBAR_SYSTEM_HOOK_TYPE_BACK_DIR_1 = -1018216
    - REBAR_SYSTEM_HOOK_TYPE_FRONT_DIR_2 = -1018215
    - REBAR_SYSTEM_HOOK_TYPE_FRONT_DIR_1 = -1018214
    - REBAR_SYSTEM_HOOK_ORIENT_BACK_DIR_2 = -1018213
    - REBAR_SYSTEM_HOOK_ORIENT_BACK_DIR_1 = -1018212
    - REBAR_SYSTEM_HOOK_ORIENT_FRONT_DIR_2 = -1018211
    - REBAR_SYSTEM_HOOK_ORIENT_FRONT_DIR_1 = -1018210
    - REBAR_SYSTEM_BAR_TYPE_BACK_DIR_2 = -1018209
    - REBAR_SYSTEM_BAR_TYPE_BACK_DIR_1 = -1018208
    - REBAR_SYSTEM_BAR_TYPE_FRONT_DIR_2 = -1018207
    - REBAR_SYSTEM_BAR_TYPE_FRONT_DIR_1 = -1018206
    - REBAR_SYSTEM_ACTIVE_BACK_DIR_2 = -1018205
    - REBAR_SYSTEM_ACTIVE_BACK_DIR_1 = -1018204
    - REBAR_SYSTEM_ACTIVE_FRONT_DIR_2 = -1018203
    - REBAR_SYSTEM_ACTIVE_FRONT_DIR_1 = -1018200
    - REBAR_SYSTEM_SPACING_BOTTOM_DIR_2 = -1018124
    - REBAR_SYSTEM_SPACING_BOTTOM_DIR_1 = -1018123
    - REBAR_SYSTEM_SPACING_TOP_DIR_2 = -1018122
    - REBAR_SYSTEM_SPACING_TOP_DIR_1 = -1018121
    - REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_2 = -1018120
    - REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_1 = -1018119
    - REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_2 = -1018118
    - REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_1 = -1018117
    - REBAR_SYSTEM_HOOK_TYPE_BOTTOM_DIR_2 = -1018116
    - REBAR_SYSTEM_HOOK_TYPE_BOTTOM_DIR_1 = -1018115
    - REBAR_SYSTEM_HOOK_TYPE_TOP_DIR_2 = -1018114
    - REBAR_SYSTEM_HOOK_TYPE_TOP_DIR_1 = -1018113
    - REBAR_SYSTEM_HOOK_ORIENT_BOTTOM_DIR_2 = -1018112
    - REBAR_SYSTEM_HOOK_ORIENT_BOTTOM_DIR_1 = -1018111
    - REBAR_SYSTEM_HOOK_ORIENT_TOP_DIR_2 = -1018110
    - REBAR_SYSTEM_HOOK_ORIENT_TOP_DIR_1 = -1018109
    - REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_2 = -1018108
    - REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_1 = -1018107
    - REBAR_SYSTEM_BAR_TYPE_TOP_DIR_2 = -1018106
    - REBAR_SYSTEM_BAR_TYPE_TOP_DIR_1 = -1018105
    - REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_2 = -1018104
    - REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_1 = -1018103
    - REBAR_SYSTEM_ACTIVE_TOP_DIR_2 = -1018102
    - REBAR_SYSTEM_ACTIVE_TOP_DIR_1 = -1018100
    - REBAR_SYSTEM_SPANHOOK_TOP_DIR_2 = -1018055
    - REBAR_SYSTEM_SPANHOOK_BOTTOM_DIR_2 = -1018054
    - REBAR_SYSTEM_SPANHOOK_RIGHT_DIR_1 = -1018053
    - REBAR_SYSTEM_SPANHOOK_LEFT_DIR_1 = -1018052
    - REBAR_SYSTEM_SPANACTIVE_DIR_2 = -1018051
    - REBAR_SYSTEM_SPANACTIVE_DIR_1 = -1018050
    - REBAR_SYSTEM_ADDL_INTERIOR_OFFSET = -1018027
    - REBAR_SYSTEM_ADDL_EXTERIOR_OFFSET = -1018026
    - REBAR_SYSTEM_ADDL_BOTTOM_OFFSET = -1018025
    - REBAR_SYSTEM_ADDL_TOP_OFFSET = -1018024
    - REBAR_SYSTEM_TOP_MINOR_MATCHES_BOTTOM_MINOR = -1018023
    - REBAR_SYSTEM_TOP_MAJOR_MATCHES_BOTTOM_MAJOR = -1018022
    - REBAR_SYSTEM_BOTTOM_MAJOR_MATCHES_BOTTOM_MINOR = -1018021
    - REBAR_SYSTEM_TOP_MAJOR_MATCHES_TOP_MINOR = -1018020
    - REBAR_SYSTEM_LAYER_SUMMARY_DIR_2_NO_SPACING = -1018019
    - REBAR_SYSTEM_LAYER_SUMMARY_DIR_2_WITH_SPACING = -1018018
    - REBAR_SYSTEM_LAYER_SUMMARY_DIR_1_NO_SPACING = -1018017
    - REBAR_SYSTEM_LAYER_SUMMARY_DIR_1_WITH_SPACING = -1018016
    - REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_2_NO_SPACING = -1018015
    - REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_2_WITH_SPACING = -1018014
    - REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_1_NO_SPACING = -1018013
    - REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_1_WITH_SPACING = -1018012
    - REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_2_NO_SPACING = -1018011
    - REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_2_WITH_SPACING = -1018010
    - REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_1_NO_SPACING = -1018009
    - REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_1_WITH_SPACING = -1018008
    - REBAR_SYSTEM_COVER_BOTTOM = -1018007
    - REBAR_SYSTEM_COVER_TOP = -1018006
    - REBAR_SYSTEM_OVERRIDE = -1018005
    - REBAR_SYSTEM_LAYER_SUMMARY_NO_SPACING = -1018003
    - REBAR_SYSTEM_LAYER_SUMMARY_WITH_SPACING = -1018002
    - REBAR_SYSTEM_LAYOUT_RULE = -1018001
    - REBAR_SYSTEM_COVER_SIDE = -1018000
    - ENERGY_ANALYSIS_CURRENT_VIEW_ONLY = -1017750
    - FABRIC_WIRE_OFFSET = -1017739
    - FABRIC_WIRE_DISTANCE = -1017738
    - FABRIC_WIRE_LENGTH = -1017737
    - FABRIC_WIRE_TYPE = -1017736
    - BENT_FABRIC_PARAM_LONGITUDINAL_CUT_LENGTH = -1017734
    - FABRIC_PARAM_SHARED_FAMILY_KEY = -1017733
    - FABRIC_PARAM_CUT_BY_HOST = -1017732
    - BENT_FABRIC_PARAM_STRAIGHT_WIRES_LOCATION = -1017731
    - BENT_FABRIC_PARAM_BEND_DIRECTION = -1017729
    - FABRIC_PARAM_SPAN_TAG_COMPONENT_REFERENCE = -1017728
    - FABRIC_PARAM_SPAN_SYM_D_RIGHT = -1017727
    - FABRIC_PARAM_SPAN_SYM_D_LEFT = -1017726
    - FABRIC_PARAM_SPAN_SYM_D_BOTTOM = -1017725
    - FABRIC_PARAM_SPAN_SYM_D_TOP = -1017724
    - FABRIC_PARAM_SPAN_SYM_RIGHT = -1017723
    - FABRIC_PARAM_SPAN_SYM_LEFT = -1017722
    - FABRIC_PARAM_SPAN_SYM_BOTTOM = -1017721
    - FABRIC_PARAM_SPAN_SYM_TOP = -1017720
    - FABRIC_PARAM_TAG_VIEW = -1017713
    - FABRIC_PARAM_CUT_SHEET_MASS = -1017712
    - FABRIC_PARAM_TOTAL_SHEET_MASS = -1017711
    - FABRIC_PARAM_CUT_OVERALL_WIDTH = -1017710
    - FABRIC_PARAM_CUT_OVERALL_LENGTH = -1017709
    - FABRIC_PARAM_COVER_OFFSET = -1017708
    - FABRIC_PARAM_MINOR_LAPSPLICE_LENGTH = -1017707
    - FABRIC_PARAM_MAJOR_LAPSPLICE_LENGTH = -1017706
    - FABRIC_PARAM_LOCATION_GENERIC = -1017705
    - FABRIC_PARAM_LAPSPLICE_POSITION = -1017704
    - FABRIC_PARAM_LOCATION_WALL = -1017703
    - FABRIC_PARAM_LOCATION_SLAB = -1017702
    - FABRIC_PARAM_SHEET_TYPE = -1017701
    - FABRIC_BEND_DIAMETER = -1017625
    - FABRIC_SHEET_MASSUNIT = -1017624
    - FABRIC_SHEET_MINOR_REINFORCEMENT_AREA = -1017623
    - FABRIC_SHEET_MAJOR_REINFORCEMENT_AREA = -1017622
    - FABRIC_SHEET_MASS = -1017621
    - FABRIC_SHEET_MINOR_SPACING = -1017620
    - FABRIC_SHEET_MINOR_NUMBER_OF_WIRES = -1017619
    - FABRIC_SHEET_MINOR_LAYOUT_PATTERN = -1017618
    - FABRIC_SHEET_MINOR_END_OVERHANG = -1017617
    - FABRIC_SHEET_MINOR_START_OVERHANG = -1017616
    - FABRIC_SHEET_WIDTH = -1017615
    - FABRIC_SHEET_OVERALL_WIDTH = -1017614
    - FABRIC_SHEET_MAJOR_SPACING = -1017613
    - FABRIC_SHEET_MAJOR_NUMBER_OF_WIRES = -1017612
    - FABRIC_SHEET_MAJOR_LAYOUT_PATTERN = -1017611
    - FABRIC_SHEET_MAJOR_END_OVERHANG = -1017610
    - FABRIC_SHEET_MAJOR_START_OVERHANG = -1017609
    - FABRIC_SHEET_LENGTH = -1017608
    - FABRIC_SHEET_OVERALL_LENGTH = -1017607
    - FABRIC_SHEET_DEFAULT_MINOR_LAPSPLICE_LENGTH = -1017606
    - FABRIC_SHEET_DEFAULT_MAJOR_LAPSPLICE_LENGTH = -1017605
    - FABRIC_SHEET_MINOR_DIRECTION_WIRE_TYPE = -1017604
    - FABRIC_SHEET_MAJOR_DIRECTION_WIRE_TYPE = -1017603
    - FABRIC_SHEET_PHYSICAL_MATERIAL_ASSET = -1017602
    - FABRIC_WIRE_DIAMETER = -1017601
    - REBAR_QUANITY_BY_DISTRIB = -1017065
    - REBAR_MIN_LENGTH = -1017064
    - REBAR_MAX_LENGTH = -1017063
    - REBAR_MAXIM_SUFFIX = -1017062
    - REBAR_MINIM_SUFFIX = -1017061
    - REBAR_NUMBER_SUFFIX = -1017060
    - REBAR_DISTRIBUTION_TYPE = -1017057
    - DPART_CAN_HOST_REBAR = -1017056
    - REBAR_HOST_CATEGORY = -1017055
    - REBAR_SHAPE_PARAM_END_HOOK_TAN_LEN = -1017054
    - REBAR_SHAPE_PARAM_START_HOOK_TAN_LEN = -1017053
    - REBAR_INTERNAL_MULTIPLANAR_END_CONNECTOR = -1017052
    - REBAR_INTERNAL_MULTIPLANAR_START_CONNECTOR = -1017051
    - REBAR_INTERNAL_MULTIPLANAR_DUPLICATE = -1017050
    - REBAR_INTERNAL_MULTIPLANAR = -1017049
    - REBAR_SHAPE_OUT_OF_PLANE_BEND_DIAMETER = -1017048
    - REBAR_INSTANCE_STIRRUP_TIE_ATTACHMENT = -1017047
    - REBAR_SHAPE_STIRRUP_TIE_ATTACHMENT = -1017046
    - REBAR_SHAPE_SPIRAL_BASE_FINISHING_TURNS = -1017045
    - REBAR_SHAPE_SPIRAL_TOP_FINISHING_TURNS = -1017044
    - REBAR_SHAPE_SPIRAL_HEIGHT = -1017043
    - REBAR_SHAPE_SPIRAL_PITCH = -1017042
    - REBAR_STANDARD_HOOK_BEND_DIAMETER = -1017041
    - REBAR_INCLUDE_LAST_BAR = -1017040
    - REBAR_INCLUDE_FIRST_BAR = -1017039
    - REBAR_INSTANCE_BEND_DIAMETER = -1017038
    - REBAR_INSTANCE_BAR_DIAMETER = -1017037
    - REBAR_SHAPE_END_HOOK_OFFSET = -1017036
    - REBAR_SHAPE_END_HOOK_LENGTH = -1017035
    - REBAR_SHAPE_START_HOOK_OFFSET = -1017034
    - REBAR_SHAPE_START_HOOK_LENGTH = -1017033
    - REBAR_ELEM_SCHEDULE_MARK = -1017032
    - FABRIC_PARAM_ROUNDING = -1017028
    - REBAR_ELEMENT_ROUNDING = -1017027
    - REBAR_ELEM_HOOK_STYLE = -1017026
    - REBAR_SHAPE_HOOK_END_TYPE = -1017024
    - REBAR_SHAPE_HOOK_START_TYPE = -1017023
    - REBAR_SHAPE_HOOK_STYLE = -1017022
    - REBAR_SHAPE_ALLOWED_BAR_TYPES = -1017021
    - REBAR_SHAPE_ALLOWED_BAR_TYPES = -1017021
    - REBAR_BAR_MAXIMUM_BEND_RADIUS = -1017020
    - REBAR_BAR_STIRRUP_BEND_DIAMETER = -1017019
    - REBAR_BAR_HOOK_LENGTHS = -1017018
    - REBAR_HOOK_STYLE = -1017017
    - REBAR_ELEM_LENGTH = -1017016
    - REBAR_SHAPE = -1017015
    - REBAR_ELEMENT_VISIBILITY = -1017014
    - REBAR_ELEM_BAR_SPACING = -1017013
    - REBAR_ELEM_QUANTITY_OF_BARS = -1017012
    - REBAR_ELEM_LAYOUT_RULE = -1017011
    - REBAR_STANDARD_BEND_DIAMETER = -1017010
    - REBAR_ELEM_HOOK_END_ORIENT = -1017009
    - REBAR_ELEM_HOOK_END_TYPE = -1017008
    - REBAR_ELEM_HOOK_START_ORIENT = -1017007
    - REBAR_ELEM_HOOK_START_TYPE = -1017006
    - REBAR_ELEM_TOTAL_LENGTH = -1017005
    - REBAR_HOOK_LINE_LEN_FACTOR = -1017004
    - REBAR_HOOK_ANGLE = -1017003
    - REBAR_BAR_STYLE = -1017002
    - REBAR_BAR_DIAMETER = -1017000
    - WALL_ALIGN_KEY_REF_PARAM = -1016021
    - CWP_COPY_ROOF_INSERTS = -1016019
    - CWP_COPY_FLOOR_INSERTS = -1016018
    - CWP_COPY_WALL_INSERTS = -1016017
    - CWP_LINKED_ROOM_PARAMS = -1016016
    - CWP_LINKED_ROOM_PHASES = -1016015
    - CWP_REUSE_GRIDS_SAME_NAME = -1016011
    - CWP_REUSE_LEVELS_SAME_NAME = -1016010
    - CWP_SPLIT_COLUMNS_AT_LEVELS = -1016009
    - CWP_REUSE_EXISTING_GRIDS = -1016008
    - CWP_REUSE_EXISTING_LEVELS = -1016007
    - CWP_LEVEL_OFFSET = -1016006
    - CWP_ADD_LEVEL_SUFFIX = -1016005
    - CWP_ADD_LEVEL_PREFIX = -1016004
    - CWP_ADD_GRID_SUFFIX = -1016003
    - CWP_ADD_GRID_PREFIX = -1016002
    - LOAD_USAGE_NAME = -1015259
    - LOAD_COMBINATION_FACTOR = -1015256
    - LOAD_COMBINATION_NAME = -1015255
    - LOAD_NATURE_NAME = -1015254
    - LOAD_CASE_SUBCATEGORY = -1015253
    - LOAD_CASE_NATURE = -1015252
    - LOAD_CASE_NUMBER = -1015251
    - LOAD_CASE_NAME = -1015250
    - LOAD_ATTR_AREA_FORCE_SCALE_FACTOR = -1015207
    - LOAD_ATTR_LINEAR_FORCE_SCALE_FACTOR = -1015206
    - LOAD_ARROW_SEPARATION = -1015205
    - LOAD_ATTR_MOMENT_SCALE_FACTOR = -1015204
    - LOAD_ATTR_MOMENT_ARROW_LINE = -1015203
    - LOAD_ATTR_MOMENT_ARROW_ARC = -1015202
    - LOAD_ATTR_FORCE_SCALE_FACTOR = -1015201
    - LOAD_ATTR_FORCE_ARROW_TYPE = -1015200
    - LOAD_DESCRIPTION = -1015084
    - LOAD_COMMENTS = -1015083
    - LOAD_CASE_NATURE_TEXT = -1015082
    - LOAD_ALL_NON_0_LOADS = -1015080
    - LOAD_AREA_IS_PROJECTED = -1015070
    - LOAD_AREA_AREA = -1015069
    - LOAD_AREA_FORCE_FZ3 = -1015068
    - LOAD_AREA_FORCE_FY3 = -1015067
    - LOAD_AREA_FORCE_FX3 = -1015066
    - LOAD_AREA_FORCE_FZ2 = -1015065
    - LOAD_AREA_FORCE_FY2 = -1015064
    - LOAD_AREA_FORCE_FX2 = -1015063
    - LOAD_AREA_FORCE_FZ1 = -1015062
    - LOAD_AREA_FORCE_FY1 = -1015061
    - LOAD_AREA_FORCE_FX1 = -1015060
    - LOAD_LINEAR_LENGTH = -1015043
    - LOAD_IS_PROJECTED = -1015042
    - LOAD_MOMENT_MZ2 = -1015041
    - LOAD_MOMENT_MY2 = -1015040
    - LOAD_MOMENT_MX2 = -1015039
    - LOAD_MOMENT_MZ1 = -1015038
    - LOAD_MOMENT_MY1 = -1015037
    - LOAD_MOMENT_MX1 = -1015036
    - LOAD_LINEAR_FORCE_FZ2 = -1015035
    - LOAD_LINEAR_FORCE_FY2 = -1015034
    - LOAD_LINEAR_FORCE_FX2 = -1015033
    - LOAD_LINEAR_FORCE_FZ1 = -1015032
    - LOAD_LINEAR_FORCE_FY1 = -1015031
    - LOAD_LINEAR_FORCE_FX1 = -1015030
    - LOAD_MOMENT_MZ = -1015015
    - LOAD_MOMENT_MY = -1015014
    - LOAD_MOMENT_MX = -1015013
    - LOAD_FORCE_FZ = -1015012
    - LOAD_FORCE_FY = -1015011
    - LOAD_FORCE_FX = -1015010
    - LOAD_IS_HOSTED = -1015006
    - LOAD_IS_REACTION = -1015005
    - LOAD_IS_UNIFORM = -1015003
    - LOAD_USE_LOCAL_COORDINATE_SYSTEM = -1015001
    - LOAD_CASE_ID = -1015000
    - SPAN_DIR_SYM_PARAM_RIGHT = -1014004
    - SPAN_DIR_SYM_PARAM_LEFT = -1014003
    - SPAN_DIR_SYM_PARAM_BOTTOM = -1014002
    - SPAN_DIR_SYM_PARAM_TOP = -1014001
    - SPAN_DIR_INST_PARAM_ANGLE = -1014000
    - ANALYTICAL_NODE_CONNECTION_STATUS = -1013457
    - ANALYTICAL_MEMBER_ROTATION = -1013456
    - ANALYTICAL_PANEL_THICKNESS = -1013455
    - ANALYTICAL_ELEMENT_STRUCTURAL_ROLE = -1013453
    - ANALYTICAL_ELEMENT_PHYSICAL_ASSET = -1013452
    - ANALYTICAL_GEOMETRY_IS_VALID = -1013451
    - STRUCTURAL_ASSET_PARAM = -1013450
    - ANALYTICAL_ELEMENT_HAS_ASSOCIATION = -1013449
    - GRID_NET_LOCATION_MARK = -1013448
    - ANALYTICAL_MODEL_CODE_CHECKING = -1013447
    - ANALYTICAL_MODEL_NODES_MARK = -1013446
    - ANALYTICAL_MODEL_FOUNDATIONS_MARK = -1013445
    - ANALYTICAL_MODEL_SURFACE_ELEMENTS_MARK = -1013444
    - ANALYTICAL_MODEL_STICK_ELEMENTS_MARK = -1013443
    - FAMILY_ENABLE_CUTTING_IN_VIEWS = -1013442
    - FAMILY_CAN_HOST_REBAR = -1013441
    - CLEAR_COVER = -1013440
    - CLEAR_COVER_BOTTOM = -1013439
    - CLEAR_COVER_TOP = -1013438
    - CLEAR_COVER_OTHER = -1013437
    - CLEAR_COVER_INTERIOR = -1013436
    - CLEAR_COVER_EXTERIOR = -1013435
    - COVER_TYPE_LENGTH = -1013434
    - COVER_TYPE_NAME = -1013433
    - JOIST_SYSTEM_CLEAR_SPACING_PARAM = -1013432
    - JOIST_SYSTEM_FIXED_SPACING_PARAM = -1013431
    - JOIST_SYSTEM_MAXIMUM_SPACING_PARAM = -1013430
    - CURVE_EDGE_OFFSET = -1013429
    - BEAM_SYSTEM_3D_PARAM = -1013427
    - JOIST_SYSTEM_NEW_BEAM_TYPE_NO_FAM_NAME_PARAM = -1013419
    - BEAM_SYSTEM_TAG_INST_PARAM_ANGLE = -1013418
    - BEAM_SYSTEM_TAG_PARAM_RIGHT = -1013417
    - BEAM_SYSTEM_TAG_PARAM_LEFT = -1013416
    - JOIST_SYSTEM_NUM_BEAMS_SAME_TYPE = -1013415
    - BEAM_H_JUSTIFICATION = -1013414
    - BEAM_V_JUSTIFICATION = -1013413
    - CURVE_SUPPORT_OFFSET = -1013412
    - JOIST_SYSTEM_NEW_BEAM_TYPE_PARAM = -1013411
    - JOIST_SYSTEM_LAYOUT_RULE_PARAM = -1013410
    - JOIST_SYSTEM_JUSTIFICATION_PARAM = -1013409
    - JOIST_SYSTEM_SPACING_PARAM = -1013408
    - JOIST_SYSTEM_NUMBER_OF_LINES_PARAM = -1013407
    - RBS_DUCT_FLOW_PARAM = -1013405
    - CURTAINGRID_BELT_RATIO_V = -1013391
    - CURTAINGRID_BELT_RATIO_U = -1013390
    - CURTAINGRID_USE_CURVE_DIST_V = -1013389
    - CURTAINGRID_USE_CURVE_DIST_U = -1013388
    - CURTAINGRID_ADJUST_BORDER_V = -1013387
    - CURTAINGRID_ADJUST_BORDER_U = -1013386
    - CURTAINGRID_BELT_V = -1013385
    - CURTAINGRID_BELT_U = -1013384
    - CURTAINGRID_ORIGIN_V = -1013383
    - CURTAINGRID_ORIGIN_U = -1013382
    - CURTAINGRID_ANGLE_V = -1013380
    - CURTAINGRID_ANGLE_U = -1013379
    - SPACING_NUM_DIVISIONS_V = -1013377
    - SPACING_NUM_DIVISIONS_U = -1013376
    - SPACING_JUSTIFICATION_V = -1013375
    - SPACING_JUSTIFICATION_U = -1013374
    - SPACING_LENGTH_V = -1013373
    - SPACING_LENGTH_U = -1013372
    - SPACING_LAYOUT_V = -1013371
    - SPACING_LAYOUT_U = -1013370
    - CURTAINGRID_BELT_RATIO_2 = -1013369
    - CURTAINGRID_BELT_RATIO_1 = -1013368
    - CURTAIN_VERSION_PARAM = -1013367
    - PADDING_LENGTH = -1013366
    - CURTAINGRID_USE_CURVE_DIST = -1013354
    - SPACING_JUSTIFICATION = -1013353
    - SPACING_NUM_DIVISIONS = -1013352
    - SPACING_LENGTH = -1013351
    - SPACING_LAYOUT = -1013350
    - CURTAINGRID_USE_CURVE_DIST_2 = -1013349
    - CURTAINGRID_USE_CURVE_DIST_1 = -1013348
    - CURTAINGRID_ADJUST_BORDER_2 = -1013347
    - CURTAINGRID_ADJUST_BORDER_1 = -1013346
    - CURTAINGRID_BELT_2 = -1013345
    - CURTAINGRID_BELT_1 = -1013344
    - CURTAINGRID_ORIGIN_2 = -1013343
    - CURTAINGRID_ORIGIN_1 = -1013342
    - CURTAINGRID_ANGLE_2 = -1013340
    - CURTAINGRID_ANGLE_1 = -1013339
    - SPACING_NUM_DIVISIONS_2 = -1013337
    - SPACING_NUM_DIVISIONS_1 = -1013336
    - SPACING_JUSTIFICATION_2 = -1013335
    - SPACING_JUSTIFICATION_1 = -1013334
    - SPACING_LENGTH_2 = -1013333
    - SPACING_LENGTH_1 = -1013332
    - SPACING_LAYOUT_2 = -1013331
    - SPACING_LAYOUT_1 = -1013330
    - CURTAINGRID_USE_CURVE_DIST_HORIZ = -1013319
    - CURTAINGRID_USE_CURVE_DIST_VERT = -1013318
    - CURTAINGRID_ADJUST_BORDER_HORIZ = -1013317
    - CURTAINGRID_ADJUST_BORDER_VERT = -1013316
    - CURTAINGRID_BELT_HORIZ = -1013315
    - CURTAINGRID_BELT_VERT = -1013314
    - CURTAINGRID_ORIGIN_HORIZ = -1013313
    - CURTAINGRID_ORIGIN_VERT = -1013312
    - CURTAINGRID_ANGLE_HORIZ = -1013310
    - CURTAINGRID_ANGLE_VERT = -1013309
    - GRIDLINE_SPEC_STATUS = -1013308
    - SPACING_NUM_DIVISIONS_HORIZ = -1013307
    - SPACING_NUM_DIVISIONS_VERT = -1013306
    - SPACING_JUSTIFICATION_HORIZ = -1013305
    - SPACING_JUSTIFICATION_VERT = -1013304
    - SPACING_LENGTH_HORIZ = -1013303
    - SPACING_LENGTH_VERT = -1013302
    - SPACING_LAYOUT_HORIZ = -1013301
    - SPACING_LAYOUT_VERT = -1013300
    - DESIGN_OPTION_ID = -1013201
    - DESIGN_OPTION_PARAM = -1013200
    - PLAN_REGION_VIEW_RANGE = -1013103
    - GUIDE_GRID_NAME_PARAM = -1013002
    - GUIDE_GRID_SPACING_PARAM = -1013001
    - SKETCH_GRID_SPACING_PARAM = -1013000
    - JOIN_STRENGTH_ORDER = -1012870
    - FAMILY_HOSTING_BEHAVIOR = -1012843
    - FAMILY_IS_ELEVATION_MARK_BODY = -1012842
    - FAMILY_USE_PRECUT_SHAPE = -1012841
    - WALL_SWEEP_DEFAULT_SETBACK_PARAM = -1012840
    - WALL_SWEEP_CUTS_WALL_PARAM = -1012839
    - WALL_SWEEP_CUT_BY_INSERTS_PARAM = -1012838
    - SLAB_EDGE_PROFILE_PARAM = -1012837
    - GUTTER_PROFILE_PARAM = -1012836
    - REVEAL_PROFILE_PARAM = -1012835
    - FAMILY_SHARED = -1012834
    - FAMILY_WORK_PLANE_BASED = -1012833
    - FAMILY_AUTOJOIN = -1012832
    - FAMILY_IS_PARAMETRIC = -1012831
    - FAMILY_KEEP_TEXT_READABLE = -1012830
    - WALL_BOTTOM_EXTENSION_DIST_PARAM = -1012829
    - WALL_TOP_EXTENSION_DIST_PARAM = -1012828
    - SWEEP_BASE_VERT_OFFSET = -1012827
    - SWEEP_BASE_OFFSET = -1012825
    - SLAB_EDGE_MATERIAL_PARAM = -1012824
    - GUTTER_MATERIAL_PARAM = -1012823
    - FASCIA_MATERIAL_PARAM = -1012822
    - SWEEP_BASE_FLOOR_SUBCATEGORY_ID = -1012821
    - SWEEP_BASE_ROOF_SUBCATEGORY_ID = -1012820
    - FASCIA_PROFILE_PARAM = -1012819
    - DECAL_SUBCATEGORY_ID = -1012818
    - DECAL_HEIGHT = -1012815
    - DECAL_WIDTH = -1012814
    - DECAL_LOCK_PROPORTIONS = -1012813
    - DECAL_ATTRIBUTES = -1012812
    - FAMILY_ALLOW_CUT_WITH_VOIDS = -1012811
    - FAMILY_KEY_EXT_PARAM = -1012810
    - WALL_SWEEP_WALL_SUBCATEGORY_ID = -1012809
    - FAMILY_ALWAYS_VERTICAL = -1012808
    - FAMILY_ROTATE_WITH_COMPONENT = -1012807
    - HOST_VOLUME_COMPUTED = -1012806
    - HOST_AREA_COMPUTED = -1012805
    - WALL_SWEEP_WALL_OFFSET_PARAM = -1012804
    - WALL_SWEEP_OFFSET_PARAM = -1012802
    - WALL_SWEEP_LEVEL_PARAM = -1012801
    - WALL_SWEEP_PROFILE_PARAM = -1012800
    - FAMILY_ROTATE_TEXT_WITH_COMPONENT = -1012706
    - AREA_SCHEME_NAME = -1012705
    - AREA_SCHEME_ID = -1012704
    - AREA_TYPE_TEXT = -1012703
    - AREA_TYPE = -1012701
    - CONTOUR_LABELS_RELATIVE_BASE = -1012622
    - CONTOUR_LABELS_ELEV_BASE_TYPE = -1012621
    - PROPERTY_SEGMENT_SUBCATEGORY_ID = -1012620
    - PROPERTY_SEGMENT_L_R = -1012619
    - PROPERTY_SEGMENT_RADIUS = -1012618
    - PROPERTY_SEGMENT_E_W = -1012617
    - PROPERTY_SEGMENT_BEARING = -1012616
    - PROPERTY_SEGMENT_N_S = -1012615
    - PROPERTY_SEGMENT_DISTANCE = -1012614
    - PROPERTY_LENGTH_UNITS = -1012613
    - PROPERTY_AREA_UNITS = -1012612
    - VOLUME_NET = -1012611
    - PROJECTED_SURFACE_AREA = -1012610
    - CONTOUR_LABELS_LINEAR_UNITS = -1012609
    - CONTOUR_LABELS_PRIMARY_ONLY = -1012608
    - PROPERTY_SUBCATEGORY_ID = -1012607
    - PROPERTY_AREA_OPEN = -1012606
    - VOLUME_FILL = -1012604
    - VOLUME_CUT = -1012603
    - SURFACE_PERIMETER = -1012602
    - SURFACE_AREA = -1012601
    - PROPERTY_AREA = -1012600
    - BUILDINGPAD_HEIGHTABOVELEVEL_PARAM = -1012502
    - BUILDINGPAD_THICKNESS = -1012501
    - TOPOGRAPHY_LINK_PATH = -1012409
    - TOPOGRAPHY_LINK_NAME = -1012408
    - BOUNDARY_RADIUS = -1012407
    - TOPOSURFACE_CONTOUR_SUBCATEGORY_ID = -1012405
    - BOUNDARY_BEARING = -1012404
    - BOUNDARY_DISTANCE = -1012403
    - CONTOUR_ELEVATION_STEP = -1012402
    - CONTOUR_ELEVATION = -1012401
    - POINT_ELEVATION = -1012400
    - VOLUME_OF_INTEREST_NAME = -1012205
    - VOLUME_OF_INTEREST_VIEWS_VISIBLE = -1012203
    - VIEWER_VOLUME_OF_INTEREST_CROP = -1012202
    - DATUM_VOLUME_OF_INTEREST = -1012201
    - ORIENT_BY_VIEW = -1012200
    - VOLUME_OF_INTEREST_HEIGHT = -1012114
    - ROOM_PHASE = -1012113
    - ROOM_PHASE_ID = -1012112
    - PHASE_SEQUENCE_NUMBER = -1012111
    - PHASE_NAME = -1012110
    - VIEW_FAMILY = -1012109
    - VIEW_TYPE = -1012106
    - VIEW_PHASE_FILTER = -1012103
    - VIEW_PHASE = -1012102
    - PHASE_DEMOLISHED = -1012101
    - PHASE_CREATED = -1012100
    - MASS_DATA_SLAB = -1012098
    - ENERGY_ANALYSIS_HVAC_SYSTEM = -1012062
    - ENERGY_ANALYSIS_OUTDOOR_AIR_INFORMATION_PARAM = -1012061
    - ENERGY_ANALYSIS_MASSZONE_USEENERGYDATASETTINGS = -1012060
    - ENERGY_ANALYSIS_MASSZONE_DIVIDEPERIMETER = -1012059
    - ENERGY_ANALYSIS_MASSZONE_COREOFFSET = -1012058
    - ENERGY_ANALYSIS_SHADE_DEPTH = -1012057
    - ENERGY_ANALYSIS_CONCEPTUAL_CONSTRUCTION = -1012056
    - ENERGY_ANALYSIS_SKYLIGHT_WIDTH = -1012055
    - ENERGY_ANALYSIS_PERCENTAGE_SKYLIGHTS = -1012054
    - ENERGY_ANALYSIS_GLAZING_IS_SHADED = -1012053
    - ENERGY_ANALYSIS_SILL_HEIGHT = -1012052
    - ENERGY_ANALYSIS_PERCENTAGE_GLAZING = -1012051
    - ENERGY_ANALYSIS_MASS_ZONING = -1012050
    - ENERGY_ANALYSIS_BUILDING_OPERATING_SCHEDULE = -1012047
    - ENERGY_ANALYSIS_CREATE_ANALYTICAL_MODEL = -1012046
    - MASS_DATA_SURFACE_DATA_SOURCE = -1012045
    - MASS_DATA_SKYLIGHT_WIDTH = -1012044
    - MASS_DATA_PERCENTAGE_SKYLIGHTS = -1012043
    - MASS_DATA_SILL_HEIGHT = -1012042
    - MASS_DATA_SHADE_DEPTH = -1012041
    - MASS_DATA_GLAZING_IS_SHADED = -1012040
    - MASS_DATA_PERCENTAGE_GLAZING = -1012039
    - MASS_DATA_UNDERGROUND = -1012038
    - MASS_DATA_MASS_OPENING_AREA = -1012037
    - MASS_DATA_MASS_SKYLIGHT_AREA = -1012036
    - MASS_DATA_MASS_WINDOW_AREA = -1012035
    - MASS_DATA_MASS_ROOF_AREA = -1012034
    - MASS_DATA_MASS_INTERIOR_WALL_AREA = -1012033
    - MASS_DATA_MASS_EXTERIOR_WALL_AREA = -1012032
    - MASS_DATA_SUBCATEGORY = -1012031
    - MASS_DATA_CONCEPTUAL_CONSTRUCTION = -1012030
    - MASS_ZONE_CONDITION_TYPE_PARAM = -1012027
    - MASS_ZONE_SPACE_TYPE_PARAM = -1012026
    - MASS_ZONE_FLOOR_AREA = -1012025
    - CONCEPTUAL_CONSTRUCTION_MATERIAL = -1012024
    - MASS_SURFACEDATA_MATERIAL = -1012023
    - MASS_ZONE_MATERIAL = -1012022
    - MASS_ZONE_VOLUME = -1012021
    - LEVEL_DATA_MASS_TYPE_DESCRIPTION = -1012020
    - LEVEL_DATA_MASS_INSTANCE_COMMENTS = -1012019
    - LEVEL_DATA_MASS_TYPE_COMMENTS = -1012018
    - LEVEL_DATA_MASS_FAMILY_AND_TYPE_PARAM = -1012017
    - LEVEL_DATA_MASS_FAMILY_PARAM = -1012016
    - LEVEL_DATA_SPACE_USAGE = -1012015
    - LEVEL_DATA_OWNING_LEVEL = -1012014
    - LEVEL_DATA_MASS_TYPE_PARAM = -1012013
    - LEVEL_DATA_VOLUME = -1012012
    - LEVEL_DATA_SURFACE_AREA = -1012011
    - LEVEL_DATA_FLOOR_AREA = -1012010
    - LEVEL_DATA_FLOOR_PERIMETER = -1012009
    - MASS_GROSS_VOLUME = -1012007
    - MASS_GROSS_SURFACE_AREA = -1012006
    - MASS_FLOOR_AREA_LEVELS = -1012005
    - MASS_GROSS_AREA = -1012004
    - MASSING_INTEGRATION_LEVEL = -1012000
    - PROJECT_REVISION_REVISION_ISSUED = -1011957
    - PROJECT_REVISION_ENUMERATION = -1011956
    - PROJECT_REVISION_REVISION_ISSUED_BY = -1011955
    - PROJECT_REVISION_REVISION_ISSUED_TO = -1011954
    - PROJECT_REVISION_REVISION_DATE = -1011953
    - PROJECT_REVISION_REVISION_DESCRIPTION = -1011952
    - PROJECT_REVISION_REVISION_NUM = -1011951
    - PROJECT_REVISION_SEQUENCE_NUM = -1011950
    - REVISION_CLOUD_REVISION_ISSUED_BY = -1011906
    - REVISION_CLOUD_REVISION_ISSUED_TO = -1011904
    - REVISION_CLOUD_REVISION_DATE = -1011903
    - REVISION_CLOUD_REVISION_DESCRIPTION = -1011902
    - REVISION_CLOUD_REVISION_NUM = -1011901
    - REVISION_CLOUD_REVISION = -1011900
    - REPEATING_DETAIL_ROTATION = -1011109
    - REPEATING_DETAIL_INSIDE = -1011107
    - REPEATING_DETAIL_ELEMENT = -1011106
    - REPEATING_DETAIL_LAYOUT = -1011105
    - REPEATING_DETAIL_SPACING = -1011104
    - REPEATING_DETAIL_NUMBER = -1011103
    - INSULATION_SCALE = -1011101
    - INSULATION_WIDTH = -1011100
    - VIEW_PARTS_VISIBILITY = -1011003
    - VIEW_DETAIL_LEVEL = -1011002
    - PLUMBING_FIXTURES_VENT_CONNECTION = -1010707
    - PLUMBING_FIXTURES_WASTE_CONNECTION = -1010706
    - PLUMBING_FIXTURES_CW_CONNECTION = -1010705
    - PLUMBING_FIXTURES_HW_CONNECTION = -1010704
    - PLUMBING_FIXTURES_TRAP = -1010703
    - PLUMBING_FIXTURES_DRAIN = -1010702
    - PLUMBING_FIXTURES_SUPPLY_PIPE = -1010701
    - PLUMBING_FIXTURES_SUPPLY_FITTING = -1010700
    - LIGHTING_FIXTURE_LIGHT_EMITTER = -1010508
    - FBX_LIGHT_SPOT_FIELD_ANGLE = -1010507
    - FBX_LIGHT_SPOT_BEAM_ANGLE = -1010506
    - FBX_LIGHT_SPOT_TILT_ANGLE = -1010505
    - FBX_LIGHT_LIMUNOUS_FLUX = -1010503
    - LIGHTING_FIXTURE_LAMP = -1010501
    - LIGHTING_FIXTURE_WATTAGE = -1010500
    - ELECTICAL_EQUIP_VOLTAGE = -1010401
    - ELECTICAL_EQUIP_WATTAGE = -1010400
    - CURTAIN_WALL_SYSPANEL_THICKNESS = -1010304
    - CURTAIN_WALL_PANEL_HOST_ID = -1010303
    - CURTAIN_WALL_SYSPANEL_OFFSET = -1010302
    - CURTAIN_WALL_PANELS_WIDTH = -1010301
    - CURTAIN_WALL_PANELS_HEIGHT = -1010300
    - ALL_MODEL_MODEL = -1010109
    - ALL_MODEL_MANUFACTURER = -1010108
    - ALL_MODEL_INSTANCE_COMMENTS = -1010106
    - ALL_MODEL_TYPE_COMMENTS = -1010105
    - ALL_MODEL_URL = -1010104
    - ALL_MODEL_DESCRIPTION = -1010103
    - RGB_B_PARAM = -1010024
    - RGB_G_PARAM = -1010023
    - RGB_R_PARAM = -1010022
    - ELLIPSE_Y_PARAM = -1010021
    - ELLIPSE_X_PARAM = -1010020
    - GROUPNAME_PARAM = -1010018
    - ICON_INDEX_PARAM = -1010017
    - SHOW_ICON_PARAM = -1010016
    - CASEWORK_DEPTH = -1010003
    - CASEWORK_DEPTH = -1010003
    - ANALYTICAL_MEMBER_SECTION_TYPE = -1009533
    - ANALYTICAL_MODEL_END_PROJECTION_ORTHOGONAL = -1009532
    - ANALYTICAL_MODEL_START_PROJECTION_ORTHOGONAL = -1009531
    - ANALYTICAL_LINK_RELEASE_ROTATION_Z = -1009530
    - ANALYTICAL_LINK_RELEASE_ROTATION_Y = -1009529
    - ANALYTICAL_LINK_RELEASE_ROTATION_X = -1009528
    - ANALYTICAL_LINK_RELEASE_TRANSLATION_Z = -1009527
    - ANALYTICAL_LINK_RELEASE_TRANSLATION_Y = -1009526
    - ANALYTICAL_LINK_RELEASE_TRANSLATION_X = -1009525
    - ANALYTICAL_MODEL_PHYSICAL_TYPE = -1009524
    - ANALYTICAL_MODEL_SKETCH_PROJECTION = -1009523
    - ANALYTICAL_MODEL_SKETCH_ALIGNMENT_METHOD = -1009522
    - ANALYTICAL_MODEL_WALL_BASE_PROJECTION = -1009521
    - ANALYTICAL_MODEL_WALL_TOP_PROJECTION = -1009520
    - ANALYTICAL_MODEL_WALL_PROJECTION = -1009519
    - ANALYTICAL_MODEL_WALL_ALIGNMENT_METHOD = -1009518
    - ANALYTICAL_MODEL_FLOOR_PROJECTION = -1009517
    - ANALYTICAL_MODEL_FLOOR_ALIGNMENT_METHOD = -1009516
    - ANALYTICAL_MODEL_COLUMN_BASE_EXTENSION = -1009515
    - ANALYTICAL_MODEL_BASE_EXTENSION_METHOD = -1009514
    - ANALYTICAL_MODEL_COLUMN_TOP_EXTENSION = -1009513
    - ANALYTICAL_MODEL_TOP_EXTENSION_METHOD = -1009512
    - ANALYTICAL_MODEL_TOP_Y_PROJECTION = -1009511
    - ANALYTICAL_MODEL_TOP_Z_PROJECTION = -1009510
    - ANALYTICAL_MODEL_TOP_ALIGNMENT_METHOD = -1009509
    - ANALYTICAL_MODEL_BASE_Y_PROJECTION = -1009508
    - ANALYTICAL_MODEL_BASE_Z_PROJECTION = -1009507
    - ANALYTICAL_MODEL_BASE_ALIGNMENT_METHOD = -1009506
    - ANALYTICAL_MODEL_END_Z_PROJECTION = -1009505
    - ANALYTICAL_MODEL_END_Y_PROJECTION = -1009504
    - ANALYTICAL_MODEL_END_ALIGNMENT_METHOD = -1009503
    - ANALYTICAL_MODEL_START_Z_PROJECTION = -1009502
    - ANALYTICAL_MODEL_START_Y_PROJECTION = -1009501
    - ANALYTICAL_MODEL_START_ALIGNMENT_METHOD = -1009500
    - ELEMENT_LOCKED_PARAM = -1009000
    - STAIRS_RAILING_BALUSTER_IS_POST = -1008633
    - STAIRS_RAILING_CONNECTION = -1008632
    - STAIRS_RAILING_ANGLED_CONNECTION = -1008631
    - STAIRS_RAILING_TANGENT_CONNECTION = -1008630
    - STAIRS_RAILING_HEIGHT_SHIFT_VAL = -1008629
    - STAIRS_RAILING_HEIGHT_SHIFT_TYPE = -1008628
    - STAIRS_RAILING_RAIL_NAME = -1008627
    - STAIRS_RAILING_BALUSTER_PLACEMENT = -1008626
    - STAIRS_RAILING_BALUSTER_SLOPE_ANGLE = -1008625
    - STAIRS_RAILING_BALUSTER_BOTTOM_ANGLE = -1008624
    - STAIRS_RAILING_BALUSTER_TOP_ANGLE = -1008623
    - STAIRS_RAILING_BALUSTER_HEIGHT = -1008622
    - STAIRS_RAILING_HEIGHT_OFFSET = -1008621
    - STAIRS_RAILING_BASE_LEVEL_PARAM = -1008620
    - STAIRS_RAILING_BALUSTER_OFFSET = -1008619
    - STAIRS_RAILING_BALUSTER_FAMILY = -1008618
    - STAIRS_RAILING_RAIL_OFFSET = -1008617
    - STAIRS_RAILING_RAIL_HEIGHT = -1008616
    - STAIRS_RAILING_RAIL_STRUCTURE = -1008615
    - STAIRS_RAILING_SHAPE = -1008614
    - STAIRS_RAILING_BALUSTER_LENGTH = -1008612
    - STAIRS_RAILING_BALUSTER_WIDTH = -1008611
    - STAIRS_RAILING_BALUSTERS_PER_TREAD = -1008610
    - STAIRS_RAILING_BALUSTER_SPACING = -1008609
    - STAIRS_RAILING_BALUSTER_SPACING_TYPE = -1008608
    - STAIRS_RAILING_BALUSTER_SHAPE = -1008605
    - STAIRS_RAILING_THICKNESS = -1008604
    - STAIRS_RAILING_WIDTH = -1008603
    - STAIRS_RAILING_HEIGHT = -1008602
    - RAMP_ATTR_TEXT_SIZE = -1008310
    - RAMP_ATTR_TEXT_FONT = -1008309
    - RAMP_ATTR_MATERIAL = -1008308
    - RAMP_ATTR_RIGHT_BALUSTER_ATTACH_PT = -1008307
    - RAMP_ATTR_LEFT_BALUSTER_ATTACH_PT = -1008306
    - RAMP_ATTR_SHAPE = -1008305
    - RAMP_ATTR_THICKNESS = -1008304
    - RAMP_MAX_RUN_LENGTH = -1008303
    - RAMP_ATTR_MIN_INV_SLOPE = -1008301
    - ASSIGN_TEMPLATE_ON_VIEW_CREATION = -1008211
    - DEFAULT_VIEW_TEMPLATE = -1008210
    - PLAN_VIEW_VIEW_DIR = -1008209
    - POCHE_MAT_ID = -1008208
    - ELEVATN_TAG = -1008207
    - CALLOUT_TAG = -1008206
    - SECTION_TAG = -1008205
    - CALLOUT_SYNCRONIZE_BOUND_OFFSET_FAR = -1008203
    - CALLOUT_CORNER_SHEET_RADIUS = -1008201
    - CALLOUT_ATTR_HEAD_TAG = -1008200
    - GRID_BUBBLE_END_2 = -1008005
    - GRID_BUBBLE_END_1 = -1008004
    - DATUM_BUBBLE_LOCATION_IN_ELEV = -1008003
    - DATUM_BUBBLE_END_1 = -1008002
    - DATUM_BUBBLE_END_2 = -1008001
    - DATUM_TEXT = -1008000
    - CURVE_IS_MULTILEVEL = -1007908
    - CURVE_BOTTOM_LEVEL = -1007907
    - CURVE_BOTTOM_LEVEL = -1007907
    - CURVE_TOP_LEVEL = -1007906
    - ELLIPSE_FOCUS_MRK_VISIBLE = -1007905
    - ARC_CURVE_CNTR_MRK_VISIBLE = -1007900
    - ARC_CURVE_CNTR_MRK_VISIBLE = -1007900
    - REF_TABLE_PARAM_NAME = -1007851
    - REF_TABLE_ELEM_NAME = -1007850
    - RBS_PANEL_SCHEDULE_SHEET_APPEARANCE_INST_PARAM = -1007808
    - RBS_PANEL_SCHEDULE_SHEET_APPEARANCE_PARAM = -1007807
    - SCHEDULE_EMBEDDED_PARAM = -1007806
    - SCHEDULE_SHEET_APPEARANCE_PARAM = -1007805
    - SCHEDULE_FORMAT_PARAM = -1007804
    - SCHEDULE_GROUP_PARAM = -1007803
    - SCHEDULE_FILTER_PARAM = -1007801
    - SCHEDULE_FIELDS_PARAM = -1007800
    - RASTER_SYMBOL_LINKLOAD_STATUS = -1007771
    - RASTER_ENABLE_SNAPS = -1007770
    - RASTER_SYMBOL_PAGENUMBER = -1007769
    - RASTER_HORIZONTAL_SCALE = -1007768
    - RASTER_VERTICAL_SCALE = -1007767
    - RASTER_SYMBOL_HEIGHT = -1007766
    - RASTER_SYMBOL_WIDTH = -1007765
    - RASTER_SYMBOL_RESOLUTION = -1007764
    - RASTER_SYMBOL_FILENAME = -1007763
    - RASTER_SYMBOL_VIEWNAME = -1007762
    - RASTER_SYMBOL_PIXELHEIGHT = -1007761
    - RASTER_SYMBOL_PIXELWIDTH = -1007760
    - RASTER_LOCK_PROPORTIONS = -1007752
    - RASTER_SHEETHEIGHT = -1007751
    - RASTER_SHEETWIDTH = -1007750
    - IMPORT_ADT_ENTITY_ROLL = -1007738
    - IMPORT_ADT_ENTITY_THICKNESS = -1007737
    - IMPORT_ADT_ENTITY_LENGTH = -1007736
    - IMPORT_ADT_ENTITY_WIDTH = -1007735
    - IMPORT_ADT_ENTITY_HEIGHT = -1007734
    - IMPORT_ADT_COMPONENTS_DESC = -1007733
    - IMPORT_ADT_ENTITY_STYLE = -1007732
    - IMPORT_ADT_ENTITY_STRUCT_TYPE = -1007731
    - IMPORT_ADT_ENTITY_TYPE = -1007730
    - RVT_LINK_INSTANCE_PROJECT_INFORMATION = -1007729
    - RVT_LINK_PHASE_MAP = -1007728
    - RVT_LINK_REFERENCE_TYPE = -1007727
    - RVT_LINK_FILE_NAME_WITHOUT_EXT = -1007726
    - RVT_LEVEL_OFFSET = -1007725
    - RVT_HOST_LEVEL = -1007724
    - RVT_SOURCE_LEVEL = -1007723
    - RVT_LINK_INSTANCE_NAME = -1007721
    - GEO_LOCATION = -1007720
    - IMPORT_INSTANCE_CUTTING_IN_VIEW = -1007707
    - IMPORT_INSTANCE_SCALE = -1007706
    - IMPORT_BACKGROUND = -1007705
    - IMPORT_DISPLAY_UNITS = -1007704
    - IMPORT_BASE_LEVEL_OFFSET = -1007703
    - IMPORT_BASE_LEVEL = -1007702
    - IMPORT_SCALE = -1007701
    - IMPORT_SYMBOL_NAME = -1007700
    - ELEV_SYMBOL_ID = -1007610
    - ELEV_REFERENCE_LABEL_POS = -1007609
    - ELEV_ASSOC_DATUM = -1007608
    - ELEV_VIEW_NAME_POS = -1007607
    - ELEV_SHOW_VIEW_NAME = -1007605
    - ELEV_TEXT_POS = -1007604
    - ELEV_ARROW_FILLED = -1007603
    - ELEV_ARROW_ANGLE = -1007602
    - ELEV_SHAPE = -1007601
    - ELEV_WIDTH = -1007600
    - COLOR_FILL_SWATCH_HEIGHT_PARAM = -1007504
    - COLOR_FILL_SWATCH_WIDTH_PARAM = -1007503
    - COLOR_FILL_FILTERED_PARAM = -1007502
    - SHEET_COLLECTION = -1007421
    - SHEET_GUIDE_GRID = -1007419
    - SHEET_CURRENT_REVISION_ISSUED = -1007418
    - SHEET_CURRENT_REVISION_ISSUED_BY = -1007417
    - SHEET_CURRENT_REVISION_ISSUED_TO = -1007416
    - SHEET_CURRENT_REVISION_DATE = -1007415
    - SHEET_CURRENT_REVISION_DESCRIPTION = -1007414
    - SHEET_REVISIONS_ON_SHEET = -1007413
    - SHEET_CURRENT_REVISION = -1007412
    - SHEET_HEIGHT = -1007411
    - SHEET_WIDTH = -1007410
    - SHEET_FILE_PATH = -1007409
    - SHEET_APPROVED_BY = -1007408
    - SHEET_DESIGNED_BY = -1007407
    - SHEET_SCHEDULED = -1007406
    - SHEET_CHECKED_BY = -1007405
    - SHEET_DRAWN_BY = -1007404
    - SHEET_DATE = -1007403
    - SHEET_SCALE = -1007402
    - SHEET_NUMBER = -1007401
    - SHEET_NAME = -1007400
    - SPACING_APPEND = -1007398
    - AUTO_JOIN_CONDITION_WALL = -1007395
    - AUTO_MULLION_BORDER2_HORIZ = -1007394
    - AUTO_MULLION_BORDER1_HORIZ = -1007393
    - AUTO_MULLION_BORDER2_VERT = -1007392
    - AUTO_MULLION_BORDER1_VERT = -1007391
    - AUTO_MULLION_INTERIOR_HORIZ = -1007390
    - AUTO_MULLION_INTERIOR_VERT = -1007389
    - AUTO_PANEL_WALL = -1007388
    - AUTO_JOIN_CONDITION = -1007387
    - AUTO_PANEL = -1007386
    - AUTO_MULLION_BORDER2_GRID2 = -1007385
    - AUTO_MULLION_BORDER1_GRID2 = -1007384
    - AUTO_MULLION_BORDER2_GRID1 = -1007383
    - AUTO_MULLION_BORDER1_GRID1 = -1007382
    - AUTO_MULLION_INTERIOR_GRID2 = -1007381
    - AUTO_MULLION_INTERIOR_GRID1 = -1007380
    - CURTAIN_GRID_BASE_ORIENTATION = -1007364
    - MULLION_ANGLE = -1007363
    - MULLION_POSITION = -1007362
    - MULLION_PROFILE = -1007361
    - TRAP_MULL_WIDTH = -1007359
    - MULLION_DEPTH2 = -1007358
    - MULLION_DEPTH1 = -1007357
    - MULLION_DEPTH = -1007356
    - LV_MULLION_LEG2 = -1007355
    - LV_MULLION_LEG1 = -1007354
    - MULLION_CORNER_TYPE = -1007353
    - MULLION_FAM_TYPE = -1007352
    - MULLION_OFFSET = -1007351
    - CIRC_MULLION_RADIUS = -1007350
    - CUST_MULLION_THICK = -1007322
    - CUST_MULLION_WIDTH2 = -1007321
    - CUST_MULLION_WIDTH1 = -1007320
    - RECT_MULLION_THICK = -1007304
    - RECT_MULLION_WIDTH2 = -1007301
    - RECT_MULLION_WIDTH1 = -1007300
    - STAIRS_INST_ALWAYS_UP = -1007278
    - STAIRS_ATTR_TRIM_TOP = -1007277
    - STAIRS_INST_DOWN_ARROW_ON = -1007276
    - STAIRS_INST_DOWN_LABEL_TEXT = -1007275
    - STAIRS_INST_DOWN_LABEL_ON = -1007274
    - STAIRS_INST_UP_ARROW_ON = -1007273
    - STAIRS_INST_UP_LABEL_TEXT = -1007272
    - STAIRS_INST_UP_LABEL_ON = -1007271
    - STAIRS_ATTR_TEXT_SIZE = -1007270
    - STAIRS_ATTR_TEXT_FONT = -1007269
    - STAIRS_ATTR_BODY_MATERIAL = -1007268
    - STAIRS_ATTR_LANDING_CARRIAGE = -1007267
    - STAIRS_ATTR_LANDINGS_OVERLAPPING = -1007266
    - STAIRS_ATTR_RIGHT_SIDE_STRINGER = -1007265
    - STAIRS_ATTR_LEFT_SIDE_STRINGER = -1007264
    - STAIRS_ATTR_NOSING_PLACEMENT = -1007263
    - STAIRS_ATTR_RISER_TREAD_CONNECT = -1007262
    - STAIRS_ATTR_RISER_THICKNESS = -1007261
    - STAIRS_ATTR_NUM_MID_STRINGERS = -1007260
    - STAIRS_ATTR_STAIRS_CUT_OFFSET = -1007259
    - STAIRS_ATTR_LAST_RISER = -1007258
    - STAIRS_ATTR_FIRST_RISER = -1007257
    - STAIRS_ATTR_STAIRS_BOTTOM = -1007256
    - STAIRS_ATTR_MONOLITHIC_STAIRS = -1007255
    - STAIRS_ATTR_CALC_ENABLED = -1007254
    - STAIRS_ATTR_CALC_MAX = -1007253
    - STAIRS_ATTR_CALC_MIN = -1007252
    - STAIRS_ATTR_EQ_RESULT = -1007251
    - STAIRS_ACTUAL_TREAD_DEPTH = -1007250
    - STAIRS_ATTR_TREAD_MULT = -1007249
    - STAIRS_ATTR_RISER_MULT = -1007248
    - STAIRS_ATTR_STAIR_CALCULATOR = -1007247
    - STAIRS_ACTUAL_NUM_RISERS = -1007246
    - STAIRS_ATTR_BREAK_SYM_IN_CUTLINE = -1007245
    - STAIRS_ATTR_RISER_MATERIAL = -1007244
    - STAIRS_ATTR_RISER_TYPE = -1007243
    - STAIRS_ATTR_TREAD_MATERIAL = -1007242
    - STAIRS_ATTR_NOSING_LENGTH = -1007241
    - STAIRS_ATTR_TREAD_FRONT_PROFILE = -1007240
    - STAIRS_ATTR_STRINGER_MATERIAL = -1007239
    - STAIRS_ATTR_STRINGER_OFFSET = -1007238
    - STAIRS_ATTR_STRINGER_CARRIAGE = -1007237
    - STAIRS_ATTR_SIDE_STRINGER_TYPE_PARAM = -1007236
    - STAIRS_MULTISTORY_TOP_LEVEL_PARAM = -1007235
    - STAIRS_STRINGERS_PRESENT = -1007234
    - STAIRS_TOP_OFFSET = -1007219
    - STAIRS_BASE_OFFSET = -1007218
    - STAIRS_ATTR_RISER_ANGLE = -1007212
    - STAIRS_ATTR_TREAD_THICKNESS = -1007211
    - STAIRS_ATTR_STRINGER_THICKNESS = -1007210
    - STAIRS_ATTR_STRINGER_HEIGHT = -1007209
    - STAIRS_ATTR_RISERS_PRESENT = -1007208
    - STAIRS_ACTUAL_RISER_HEIGHT = -1007206
    - STAIRS_DESIRED_NUM_RISERS = -1007205
    - STAIRS_ATTR_TREAD_WIDTH = -1007204
    - STAIRS_ATTR_MINIMUM_TREAD_DEPTH = -1007203
    - STAIRS_ATTR_MAX_RISER_HEIGHT = -1007202
    - STAIRS_TOP_LEVEL_PARAM = -1007201
    - STAIRS_BASE_LEVEL_PARAM = -1007200
    - LEVEL_IS_STRUCTURAL = -1007112
    - LEVEL_IS_BUILDING_STORY = -1007111
    - LEVEL_UP_TO_LEVEL = -1007110
    - LEVEL_RELATIVE_BASE_TYPE = -1007109
    - LEVEL_ELEV = -1007102
    - LEVEL_NAME = -1007101
    - LEVEL_HEAD_TAG = -1007100
    - SHEET_COLLECTION_NAME = -1007071
    - MULTI_REFERENCE_ANNOTATION_SHOW_DIMENSION_TEXT = -1007054
    - MULTI_REFERENCE_ANNOTATION_DIMENSION_STYLE = -1007053
    - MULTI_REFERENCE_ANNOTATION_GROUP_TAG_HEADS = -1007052
    - MULTI_REFERENCE_ANNOTATION_TAG_TYPE = -1007051
    - MULTI_REFERENCE_ANNOTATION_REFERENCE_CATEGORY = -1007050
    - TAG_ELEVATION_BASE = -1007010
    - TAG_ELEMENT_COUNT = -1007008
    - TAG_ANGLE_PARAM = -1007007
    - TAG_LEADER_TYPE = -1007006
    - TAG_NO_BREAK_PARAM_STRINGS = -1007005
    - ROOM_TAG_ORIENTATION_PARAM = -1007004
    - TAG_ORIENTATION_PARAM = -1007003
    - TAG_SAMPLE_TEXT = -1007001
    - TAG_TAG = -1007000
    - DIAMETER_SYMBOL_TEXT = -1006999
    - DIAMETER_SYMBOL_LOCATION = -1006998
    - RADIUS_SYMBOL_TEXT = -1006997
    - VIS_GRAPHICS_COORDINATION_MODEL = -1006970
    - VIS_GRAPHICS_POINT_CLOUDS = -1006969
    - VIS_GRAPHICS_WORKSETS = -1006968
    - VIS_GRAPHICS_ANALYTICAL_MODEL = -1006967
    - VIS_GRAPHICS_DESIGNOPTIONS = -1006966
    - VIS_GRAPHICS_RVT_LINKS = -1006965
    - VIS_GRAPHICS_FILTERS = -1006964
    - VIS_GRAPHICS_IMPORT = -1006963
    - VIS_GRAPHICS_ANNOTATION = -1006962
    - VIS_GRAPHICS_MODEL = -1006961
    - LEVEL_ATTR_ROOM_COMPUTATION_AUTOMATIC = -1006941
    - LEVEL_ATTR_ROOM_COMPUTATION_HEIGHT = -1006940
    - LEVEL_ROOM_COMPUTATION_HEIGHT = -1006939
    - ROOM_COMPUTATION_HEIGHT = -1006928
    - ALWAYS_ZERO_LENGTH = -1006927
    - ROOM_COMPUTATION_METHOD = -1006926
    - ROOM_LOWER_OFFSET = -1006925
    - ROOM_UPPER_OFFSET = -1006924
    - ROOM_UPPER_LEVEL = -1006922
    - ROOM_VOLUME = -1006921
    - ROOM_HEIGHT = -1006920
    - ROOM_PERIMETER = -1006917
    - ROOM_LEVEL_ID = -1006916
    - ROOM_OCCUPANCY = -1006909
    - ROOM_DEPARTMENT = -1006907
    - ROOM_FINISH_BASE = -1006906
    - ROOM_FINISH_CEILING = -1006905
    - ROOM_FINISH_WALL = -1006904
    - ROOM_FINISH_FLOOR = -1006903
    - ROOM_AREA = -1006902
    - ROOM_NUMBER = -1006901
    - ROOM_NAME = -1006900
    - SPATIAL_FIELD_MGR_LEGEND_HOR_ORIGIN_GAP = -1006861
    - SPATIAL_FIELD_MGR_LEGEND_VERT_ORIGIN_GAP = -1006860
    - SPATIAL_FIELD_MGR_LEGEND_WIDTH = -1006859
    - SPATIAL_FIELD_MGR_LEGEND_HEIGHT = -1006858
    - VIEW_ANALYSIS_RESULTS_VISIBILITY = -1006857
    - SPATIAL_FIELD_MGR_LEGEND_TEXT_TYPE = -1006856
    - SPATIAL_FIELD_MGR_RESULTS_VISIBILITY = -1006855
    - SPATIAL_FIELD_MGR_LEGEND_SHOW_DESCRIPTION = -1006854
    - SPATIAL_FIELD_MGR_LEGEND_SHOW_CONFIG_NAME = -1006853
    - SPATIAL_FIELD_MGR_DESCRIPTION = -1006852
    - SPATIAL_FIELD_MGR_CURRENT_NAME = -1006851
    - SPATIAL_FIELD_MGR_RANGE = -1006850
    - GRID_END_SEGMENTS_LENGTH = -1006711
    - GRID_END_SEGMENT_PATTERN = -1006710
    - GRID_END_SEGMENT_COLOR = -1006709
    - GRID_END_SEGMENT_WEIGHT = -1006708
    - GRID_CENTER_SEGMENT_PATTERN = -1006707
    - GRID_CENTER_SEGMENT_COLOR = -1006706
    - GRID_CENTER_SEGMENT_WEIGHT = -1006705
    - GRID_CENTER_SEGMENT_STYLE = -1006704
    - GRID_BUBBLE_LINE_PEN = -1006703
    - GRID_HEAD_TAG = -1006700
    - STAIRS_PATH_FULL_STEP_ARROW = -1006661
    - STAIRS_PATH_START_EXTENSION = -1006660
    - NUMBER_SYSTEM_TEXT_SIZE = -1006645
    - NUMBER_SYSTEM_TAG_TYPE = -1006644
    - NUMBER_SYSTEM_DISPLAY_RULE = -1006643
    - NUMBER_SYSTEM_REFERENCE = -1006642
    - NUMBER_SYSTEM_JUSTIFY = -1006641
    - NUMBER_SYSTEM_ORIENTATION = -1006639
    - NUMBER_SYSTEM_REFERENCE_OFFSET = -1006638
    - NUMBER_SYSTEM_JUSTIFY_OFFSET = -1006637
    - STAIRS_TEXT_ORIENTATION = -1006636
    - STAIRS_TEXT_TYPE = -1006635
    - STAIRS_DOWN_TEXT = -1006634
    - STAIRS_SHOW_DOWN_TEXT = -1006633
    - STAIRS_UP_TEXT = -1006632
    - STAIRS_SHOW_UP_TEXT = -1006631
    - SHOW_ARROWHEAD_TO_CUT_MARK = -1006630
    - DRAW_FOR_EACH_RUN = -1006628
    - ARROWHEAD_END_AT_RISER = -1006627
    - STAIRS_PATH_START_FROM_RISER = -1006626
    - DISTANCE_TO_CUT_MARK = -1006625
    - LINE_SHAPE_AT_CORNER = -1006624
    - ARROWHEAD_TYPE = -1006623
    - START_SYMBOL_TYPE = -1006622
    - CUT_MARK_SYMBOL_SIZE = -1006621
    - CUT_LINE_TYPE = -1006620
    - CUT_LINE_ANGLE = -1006619
    - CUT_LINE_EXTENSION = -1006618
    - CUT_LINE_DISTANCE = -1006617
    - CUT_MARK_SYMBOL = -1006616
    - SECTION_BROKEN_DISPLAY_STYLE = -1006615
    - SECTION_COARSER_SCALE_PULLDOWN_IMPERIAL = -1006614
    - SECTION_COARSER_SCALE_PULLDOWN_METRIC = -1006613
    - SECTION_PARENT_VIEW_NAME = -1006612
    - SECTION_SHOW_IN_ONE_VIEW_ONLY = -1006609
    - SECTION_ATTR_TAIL_TAG = -1006608
    - SECTION_ATTR_TAIL_WIDTH = -1006604
    - SECTION_ATTR_TAIL_LENGTH = -1006603
    - VIEWER_DETAIL_NUMBER = -1006602
    - VIEWER_SHEET_NUMBER = -1006601
    - SECTION_ATTR_HEAD_TAG = -1006600
    - ALIGNMENT_STATION_LABEL_STATION_VALUE = -1006599
    - ALIGNMENT_STATION_LABEL_IND_STATION = -1006598
    - ALIGNMENT_STATION_LABEL_INCLUDE_STATION = -1006597
    - SPOT_DIM_LEADER_LINE = -1006596
    - ALIGNMENT_STATION_LABEL_DISTANCE = -1006595
    - ALIGNMENT_STATION_SUFFIX = -1006594
    - ALIGNMENT_STATION_PREFIX = -1006593
    - DIM_SUFFIX = -1006526
    - DIM_PREFIX = -1006525
    - ARROW_CENTERED = -1006524
    - INTERIOR_TICK_DISPLAY = -1006523
    - WITNS_LINE_TICK_MARK = -1006522
    - DIM_TOTAL_LENGTH = -1006521
    - DIM_REFERENCE_COUNT = -1006520
    - ALTERNATE_UNITS_SUFFIX = -1006519
    - ALTERNATE_UNITS_PREFIX = -1006518
    - EQUALITY_WITNESS_DISPLAY = -1006517
    - DIM_STYLE_SUPPRESS_SPACES = -1006516
    - EQUALITY_FORMULA = -1006515
    - DIM_STYLE_LEADER_TICK_MARK = -1006514
    - EQUALITY_TEXT_FOR_ANGULAR_DIM = -1006513
    - EQUALITY_TEXT_FOR_CONTINUOUS_LINEAR_DIM = -1006512
    - DIM_TEXT_LOCATION_FOR_LEADER = -1006511
    - DIM_LEADER_DISPLAY_CONDITION = -1006510
    - DIM_LEADER_SHOULDER_LENGTH = -1006509
    - DIM_LEADER_TYPE = -1006508
    - DIM_TO_INTERSECTING_GRIDS = -1006507
    - DIM_TO_INTERSECTING_WALLS = -1006506
    - DIM_TO_INSERT_TYPE = -1006505
    - FIXED_ROTATION = -1006504
    - KEEP_READABLE = -1006503
    - LEADER_LINE = -1006502
    - LEADER_OFFSET_SHEET = -1006501
    - DIM_TO_INSERTS = -1006500
    - SPOT_SLOPE_OFFSET_FROM_REFERENCE = -1006494
    - SPOT_SLOPE_SLOPE_REPRESENTATION = -1006493
    - SPOT_SLOPE_SLOPE_DIRECTION = -1006492
    - SPOT_ELEV_LOWER_VALUE = -1006491
    - SPOT_ELEV_SINGLE_OR_UPPER_VALUE = -1006490
    - SPOT_ELEV_IND_TYPE_ELEVATION = -1006489
    - SPOT_COORDINATE_INCLUDE_ELEVATION = -1006488
    - SPOT_COORDINATE_ELEVATION_SUFFIX = -1006487
    - SPOT_COORDINATE_ELEVATION_PREFIX = -1006486
    - SPOT_COORDINATE_BOTTOM_SUFFIX = -1006485
    - SPOT_COORDINATE_BOTTOM_PREFIX = -1006484
    - SPOT_COORDINATE_TOP_SUFFIX = -1006483
    - SPOT_COORDINATE_TOP_PREFIX = -1006482
    - SPOT_ELEV_LOWER_SUFFIX = -1006481
    - SPOT_ELEV_LOWER_PREFIX = -1006480
    - SPOT_ELEV_SINGLE_OR_UPPER_SUFFIX = -1006479
    - SPOT_ELEV_SINGLE_OR_UPPER_PREFIX = -1006478
    - BASELINE_DIM_OFFSET = -1006477
    - SPOT_ELEV_BEND_LEADER = -1006476
    - SPOT_ELEV_IND_TYPE_BOTTOM = -1006475
    - SPOT_ELEV_IND_TYPE_TOP = -1006474
    - SPOT_ELEV_IND_BOTTOM = -1006473
    - SPOT_ELEV_IND_TOP = -1006472
    - SPOT_ELEV_TEXT_LOCATION = -1006471
    - SPOT_ELEV_ROTATE_WITH_COMPONENT = -1006470
    - SPOT_ELEV_DISPLAY_ELEVATIONS = -1006469
    - ORDINATE_DIM_SETTING = -1006468
    - LINEAR_DIM_TYPE = -1006467
    - SPOT_DIM_LEADER = -1006466
    - DIM_STYLE_FLIPPED_DIM_LINE_EXTENSION = -1006465
    - DIM_STYLE_INTERIOR_TICK_MARK = -1006464
    - SPOT_TEXT_FROM_LEADER = -1006462
    - SPOT_COORDINATE_BASE = -1006461
    - DIM_STYLE_ANGULAR_UNITS_ALT = -1006460
    - SPOT_ELEV_IND_TYPE = -1006458
    - SPOT_ELEV_BOT_VALUE = -1006457
    - ALTERNATE_UNITS = -1006456
    - SPOT_ELEV_TOP_VALUE = -1006455
    - DIM_STYLE_LINEAR_UNITS_ALT = -1006454
    - SPOT_ELEV_TEXT_ORIENTATION = -1006453
    - SPOT_ELEV_IND_ELEVATION = -1006452
    - SPOT_ELEV_IND_EW = -1006451
    - SPOT_ELEV_IND_NS = -1006450
    - ARROW_CLOSED = -1006449
    - DIM_STYLE_READ_CONVENTION = -1006448
    - HEAVY_END_PEN = -1006447
    - DIM_STYLE_DIM_LINE_SNAP_DIST = -1006446
    - DIM_STYLE_CENTERLINE_TICK_MARK = -1006445
    - SPOT_ELEV_LINE_PEN = -1006444
    - SPOT_ELEV_TICK_MARK_PEN = -1006443
    - SPOT_ELEV_LEADER_ARROWHEAD = -1006442
    - SPOT_ELEV_RELATIVE_BASE = -1006441
    - SPOT_ELEV_FLIP_TEXT_VERT = -1006440
    - SPOT_ELEV_TEXT_HORIZ_OFFSET = -1006439
    - SPOT_ELEV_BASE = -1006437
    - SPOT_ELEV_SYMBOL = -1006436
    - DIM_STYLE_SHOW_OPENING_HT = -1006435
    - DIM_STYLE_CENTERLINE_PATTERN = -1006434
    - DIM_WITNS_LINE_EXTENSION_BELOW = -1006433
    - DIM_WITNS_LINE_CNTRL = -1006432
    - DIM_LINE_EXTENSION = -1006431
    - DIM_STYLE_CENTERLINE_SYMBOL = -1006430
    - DIM_TEXT_BACKGROUND = -1006429
    - DIM_STYLE_ANGULAR_UNITS = -1006428
    - DIM_STYLE_LINEAR_UNITS = -1006427
    - LEADER_ARROW_WIDTH = -1006426
    - ARROW_FILLED = -1006425
    - HEAVY_TICK_MARK_PEN = -1006420
    - ARROW_SIZE = -1006414
    - ARROW_TYPE = -1006413
    - TICK_MARK_PEN = -1006412
    - TEXT_POSITION = -1006411
    - RADIUS_SYMBOL_LOCATION = -1006408
    - CENTER_MARK_SIZE = -1006407
    - ARC_CENTER_MARK = -1006406
    - WITNS_LINE_GAP_TO_ELT = -1006405
    - WITNS_LINE_EXTENSION = -1006404
    - TEXT_DIST_TO_LINE = -1006401
    - TEXT_ALIGNMENT = -1006400
    - MODEL_TEXT_SIZE = -1006336
    - TEXT_STYLE_SIZE = -1006335
    - TEXT_STYLE_FONT = -1006334
    - SHOW_TITLE = -1006333
    - TITLE_STYLE_UNDERLINE = -1006332
    - TITLE_STYLE_ITALIC = -1006331
    - TITLE_STYLE_BOLD = -1006330
    - TITLE_SIZE = -1006329
    - TITLE_FONT = -1006328
    - TEXT_WIDTH_SCALE = -1006327
    - TEXT_TAB_SIZE = -1006326
    - ARC_LEADER_PARAM = -1006325
    - DIM_LEADER_ARROWHEAD = -1006323
    - SHEET_ISSUE_DATE = -1006322
    - PROJECT_ISSUE_DATE = -1006321
    - PROJECT_STATUS = -1006320
    - CLIENT_NAME = -1006319
    - PROJECT_ADDRESS = -1006318
    - PROJECT_NAME = -1006317
    - PROJECT_NUMBER = -1006316
    - LEADER_ARROWHEAD = -1006315
    - TEXT_BACKGROUND = -1006314
    - TEXT_STYLE_UNDERLINE = -1006313
    - TEXT_STYLE_ITALIC = -1006312
    - TEXT_STYLE_BOLD = -1006311
    - CURVE_IS_FILLED = -1006310
    - TEXT_ALIGN_VERT = -1006309
    - TEXT_ALIGN_HORZ = -1006308
    - TEXT_TEXT = -1006307
    - LINE_PATTERN = -1006305
    - LINE_COLOR = -1006304
    - LINE_PEN = -1006303
    - TEXT_COLOR = -1006302
    - TEXT_SIZE = -1006301
    - TEXT_FONT = -1006300
    - REFERENCE_LINE_SUBCATEGORY = -1006221
    - CLINE_SUBCATEGORY = -1006220
    - EDGE_LINEWORK = -1006212
    - BUILDING_CURVE_GSTYLE_PLUS_INVISIBLE = -1006211
    - BUILDING_CURVE_GSTYLE = -1006210
    - FAMILY_CURVE_GSTYLE_FOR_2010_MASS = -1006207
    - HEAD_ON_PLACEMENT_METHOD = -1006206
    - IS_VISIBLE_PARAM = -1006205
    - FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE_PLUS_STICK_SYM_MINUS_ANALYTICAL = -1006204
    - FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE_MINUS_ANALYTICAL = -1006203
    - FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE_PLUS_STICK_SYM = -1006202
    - FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE = -1006201
    - FAMILY_ELEM_SUBCATEGORY = -1006200
    - STAIRS_CURVE_TYPE = -1006100
    - ROOF_SLOPE = -1006016
    - CURVE_PARAM_STEEL_CANTILEVER = -1006015
    - CURVE_PARAM_CONCRETE_CANTILEVER = -1006014
    - CURVE_NUMBER_OF_SEGMENTS = -1006013
    - SPECIFY_SLOPE_OR_OFFSET = -1006012
    - SLOPE_ARROW_LEVEL_END = -1006011
    - SLOPE_ARROW_LEVEL_START = -1006010
    - CURVE_LEVEL = -1006009
    - CURVE_HEIGHT_OFFSET = -1006008
    - CURVE_IS_SLOPE_DEFINING = -1006007
    - DEFINES_CONSTANT_HEIGHT = -1006006
    - ROOF_CURVE_HEIGHT_AT_WALL = -1006005
    - ROOF_CURVE_HEIGHT_OFFSET = -1006001
    - ROOF_CURVE_IS_SLOPE_DEFINING = -1006000
    - STRUCTURAL_SECTION_ISHAPE_WEBTHICKNESS_LOCATION = -1005567
    - STRUCTURAL_SECTION_ISHAPE_FLANGETHICKNESS_LOCATION = -1005566
    - STRUCTURAL_SECTION_TOP_WEB_FILLET = -1005565
    - STRUCTURAL_SECTION_SLOPED_WEB_ANGLE = -1005564
    - STRUCTURAL_SECTION_SLOPED_FLANGE_ANGLE = -1005563
    - STRUCTURAL_SECTION_CANTILEVER_HEIGHT = -1005562
    - STRUCTURAL_SECTION_CANTILEVER_LENGTH = -1005561
    - STRUCTURAL_SECTION_BOTTOM_CUT_HEIGHT = -1005560
    - STRUCTURAL_SECTION_BOTTOM_CUT_WIDTH = -1005559
    - STRUCTURAL_SECTION_TOP_CUT_HEIGHT = -1005558
    - STRUCTURAL_SECTION_TOP_CUT_WIDTH = -1005557
    - STRUCTURAL_FAMILY_CODE_NAME = -1005556
    - STRUCTURAL_FAMILY_NAME_KEY = -1005555
    - STRUCTURAL_SECTION_NAME_KEY = -1005554
    - STRUCTURAL_SECTION_SIGMA_PROFILE_TOP_BEND_WIDTH = -1005553
    - STRUCTURAL_SECTION_SIGMA_PROFILE_MIDDLE_BEND_WIDTH = -1005552
    - STRUCTURAL_SECTION_SIGMA_PROFILE_BEND_WIDTH = -1005551
    - STRUCTURAL_SECTION_ZPROFILE_BOTTOM_FLANGE_LENGTH = -1005550
    - STRUCTURAL_SECTION_CPROFILE_FOLD_LENGTH = -1005549
    - STRUCTURAL_SECTION_LPROFILE_LIP_LENGTH = -1005548
    - STRUCTURAL_SECTION_LANGLE_BOLT_DIAMETER_SHORTER_FLANGE = -1005547
    - STRUCTURAL_SECTION_LANGLE_BOLT_DIAMETER_LONGER_FLANGE = -1005546
    - STRUCTURAL_SECTION_LANGLE_BOLT_SPACING_SHORTER_FLANGE = -1005545
    - STRUCTURAL_SECTION_LANGLE_BOLT_SPACING_2_LONGER_FLANGE = -1005544
    - STRUCTURAL_SECTION_LANGLE_BOLT_SPACING_1_LONGER_FLANGE = -1005543
    - STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING_WEB = -1005542
    - STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING_BETWEEN_ROWS = -1005541
    - STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING_TWO_ROWS = -1005540
    - STRUCTURAL_SECTION_ISHAPE_BOLT_DIAMETER = -1005539
    - STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING = -1005538
    - STRUCTURAL_SECTION_ISHAPE_WEB_TOE_OF_FILLET = -1005537
    - STRUCTURAL_SECTION_ISHAPE_FLANGE_TOE_OF_FILLET = -1005536
    - STRUCTURAL_SECTION_ISHAPE_CLEAR_WEB_HEIGHT = -1005535
    - STRUCTURAL_SECTION_IWELDED_BOTTOMFLANGEWIDTH = -1005534
    - STRUCTURAL_SECTION_IWELDED_BOTTOMFLANGETHICKNESS = -1005533
    - STRUCTURAL_SECTION_IWELDED_TOPFLANGEWIDTH = -1005532
    - STRUCTURAL_SECTION_IWELDED_TOPFLANGETHICKNESS = -1005531
    - STRUCTURAL_SECTION_HSS_OUTERFILLET = -1005530
    - STRUCTURAL_SECTION_HSS_INNERFILLET = -1005529
    - STRUCTURAL_SECTION_ISHAPE_WEBFILLET = -1005528
    - STRUCTURAL_SECTION_ISHAPE_FLANGEFILLET = -1005527
    - STRUCTURAL_SECTION_ISHAPE_WEBHEIGHT = -1005526
    - STRUCTURAL_SECTION_ISHAPE_WEBTHICKNESS = -1005525
    - STRUCTURAL_SECTION_ISHAPE_FLANGETHICKNESS = -1005524
    - STRUCTURAL_SECTION_COMMON_SHEAR_AREA_WEAK_AXIS = -1005523
    - STRUCTURAL_SECTION_COMMON_SHEAR_AREA_STRONG_AXIS = -1005522
    - STRUCTURAL_SECTION_COMMON_WARPING_CONSTANT = -1005521
    - STRUCTURAL_SECTION_COMMON_TORSIONAL_MODULUS = -1005520
    - STRUCTURAL_SECTION_COMMON_TORSIONAL_MOMENT_OF_INERTIA = -1005519
    - STRUCTURAL_SECTION_COMMON_PLASTIC_MODULUS_WEAK_AXIS = -1005518
    - STRUCTURAL_SECTION_COMMON_PLASTIC_MODULUS_STRONG_AXIS = -1005517
    - STRUCTURAL_SECTION_COMMON_ELASTIC_MODULUS_WEAK_AXIS = -1005516
    - STRUCTURAL_SECTION_COMMON_ELASTIC_MODULUS_STRONG_AXIS = -1005515
    - STRUCTURAL_SECTION_COMMON_MOMENT_OF_INERTIA_WEAK_AXIS = -1005514
    - STRUCTURAL_SECTION_COMMON_MOMENT_OF_INERTIA_STRONG_AXIS = -1005513
    - STRUCTURAL_SECTION_COMMON_NOMINAL_WEIGHT = -1005512
    - STRUCTURAL_SECTION_COMMON_PERIMETER = -1005511
    - STRUCTURAL_SECTION_COMMON_ALPHA = -1005510
    - STRUCTURAL_SECTION_COMMON_CENTROID_VERTICAL = -1005509
    - STRUCTURAL_SECTION_COMMON_CENTROID_HORIZ = -1005508
    - STRUCTURAL_SECTION_AREA = -1005507
    - STRUCTURAL_SECTION_PIPESTANDARD_WALLDESIGNTHICKNESS = -1005506
    - STRUCTURAL_SECTION_PIPESTANDARD_WALLNOMINALTHICKNESS = -1005505
    - STRUCTURAL_SECTION_COMMON_DIAMETER = -1005504
    - STRUCTURAL_SECTION_COMMON_HEIGHT = -1005503
    - STRUCTURAL_SECTION_COMMON_WIDTH = -1005502
    - STRUCTURAL_SECTION_SHAPE = -1005501
    - STRUCTURAL_MATERIAL_PARAM = -1005500
    - ANALYTICAL_DEFINE_THERMAL_PROPERTIES_BY = -1005439
    - ANALYTIC_CONSTRUCTION_GBXML_TYPEID = -1005438
    - ANALYTIC_CONSTRUCTION_LOOKUP_TABLE = -1005437
    - ANALYTICAL_ROUGHNESS = -1005436
    - ANALYTICAL_ABSORPTANCE = -1005435
    - ANALYTICAL_THERMAL_MASS = -1005434
    - ANALYTICAL_VISUAL_LIGHT_TRANSMITTANCE = -1005433
    - ANALYTICAL_SOLAR_HEAT_GAIN_COEFFICIENT = -1005432
    - ANALYTICAL_THERMAL_RESISTANCE = -1005431
    - ANALYTICAL_HEAT_TRANSFER_COEFFICIENT = -1005430
    - VIEW_DESIGN_OPTIONS_CONFIG = -1005400
    - VIEW_SOLARSTUDY_LIGHTING_ALTITUDE_TEXT = -1005378
    - VIEW_SOLARSTUDY_LIGHTING_ALTITUDE_VALUE = -1005377
    - VIEW_SOLARSTUDY_LIGHTING_AZIMUTH_TEXT = -1005376
    - VIEW_SOLARSTUDY_LIGHTING_AZIMUTH_VALUE = -1005375
    - VIEW_SOLARSTUDY_MULTIDAY_DATETIME_TEXT = -1005374
    - VIEW_SOLARSTUDY_MULTIDAY_FRAME_TEXT = -1005373
    - VIEW_SOLARSTUDY_MULTIDAY_FRAME_VALUE = -1005372
    - VIEW_SOLARSTUDY_SINGLEDAY_DATETIME_TEXT = -1005371
    - VIEW_SOLARSTUDY_SINGLEDAY_FRAME_TEXT = -1005370
    - VIEW_SOLARSTUDY_SINGLEDAY_FRAME_VALUE = -1005369
    - VIEW_SOLARSTUDY_STILL_TIME_TEXT = -1005368
    - VIEW_SOLARSTUDY_STILL_TIME_VALUE = -1005367
    - VIEW_SOLARSTUDY_STILL_DATE_TEXT = -1005366
    - VIEW_SOLARSTUDY_STILL_DATE_VALUE = -1005365
    - VIEW_SOLARSTUDY_LIGHTING_PRESET_INDEX = -1005364
    - VIEW_SOLARSTUDY_MULTIDAY_PRESET_INDEX = -1005363
    - VIEW_SOLARSTUDY_SINGLEDAY_PRESET_INDEX = -1005362
    - VIEW_SOLARSTUDY_STILL_PRESET_INDEX = -1005361
    - VIEW_SOLARSTUDY_SHADOWS_INTENSITY_TEXT = -1005360
    - VIEW_SOLARSTUDY_SHADOWS_INTENSITY_VALUE = -1005359
    - VIEW_SOLARSTUDY_SUN_INTENSITY_TEXT = -1005358
    - VIEW_SOLARSTUDY_SUN_INTENSITY_VALUE = -1005357
    - VIEW_SOLARSTUDY_ANIMATION_SPEED_TEXT = -1005356
    - VIEW_SOLARSTUDY_ANIMATION_SPEED_VALUE = -1005355
    - VIEW_SOLARSTUDY_IS_LIGHTING_STUDY_TYPE = -1005354
    - VIEW_SOLARSTUDY_IS_MULTIDAY_STUDY_TYPE = -1005353
    - VIEW_SOLARSTUDY_IS_SINGLEDAY_STUDY_TYPE = -1005352
    - VIEW_SOLARSTUDY_IS_STILLIMAGE_STUDY_TYPE = -1005351
    - VIEW_SOLARSTUDY_CURRENT_STUDY_TYPE_INDEX = -1005350
    - VIEW_UNDERLAY_TOP_ID = -1005335
    - VIEW_GRAPH_SUN_PATH_SIZE = -1005334
    - VIEW_GRAPH_SUN_PATH = -1005333
    - VIEW_ANALYSIS_DISPLAY_STYLE = -1005332
    - VIEW_GRAPH_SCHED_LEVEL_RELATIVE_BASE_TYPE = -1005331
    - VIEW_GRAPH_SCHED_HIDDEN_LEVELS = -1005330
    - VIEW_GRAPH_SCHED_TOTAL_ROWS = -1005329
    - VIEW_GRAPH_SCHED_ROWS_COUNT = -1005328
    - VIEW_GRAPH_SCHED_GRID_APPEARANCE = -1005327
    - VIEW_GRAPH_SCHED_TEXT_APPEARANCE = -1005326
    - VIEW_GRAPH_SCHED_TITLE = -1005325
    - VIEW_GRAPH_SCHED_ROWS_FROM = -1005319
    - VIEW_GRAPH_SCHED_GROUP_SIMILAR = -1005318
    - VIEW_GRAPH_SCHED_MATERIAL_TYPES = -1005317
    - VIEW_GRAPH_SCHED_LOCATIONS_HIGH = -1005316
    - VIEW_GRAPH_SCHED_LOCATIONS_LOW = -1005315
    - VIEW_GRAPH_SCHED_BOTTOM_LEVEL = -1005314
    - VIEW_GRAPH_SCHED_TOP_LEVEL = -1005313
    - VIEWPORT_ATTR_ORIENTATION_ON_SHEET = -1005254
    - VIEWPORT_ATTR_SHOW_BOX = -1005253
    - VIEWPORT_ATTR_SHOW_EXTENSION_LINE = -1005252
    - VIEWPORT_ATTR_SHOW_LABEL = -1005251
    - VIEWPORT_ATTR_LABEL_TAG = -1005250
    - VIEW_SCALE_HAVENAME = -1005231
    - VIEW_SCALE_CUSTOMNAME = -1005230
    - VIEWER_SHEET_COLLECTION = -1005224
    - VIEWER_SHEET_NAME = -1005223
    - VIEW_REFERENCING_SHEET_COLLECTION = -1005222
    - VIEWPORT_SHEET_COLLECTION = -1005221
    - VIEWPORT_ATTR_PRESERVE_TITLE_POSITION = -1005211
    - VIEWPORT_POSITIONING = -1005210
    - VIEW_GRAPH_SCHED_OFF_GRID = -1005209
    - VIEW_GRAPH_SCHED_UNITS_FORMAT = -1005208
    - VIEWPORT_SHEET_NAME = -1005207
    - VIEWPORT_SHEET_NUMBER = -1005206
    - VIEWPORT_SCALE = -1005204
    - VIEWPORT_VIEW_NAME = -1005203
    - VIEWPORT_VIEW = -1005202
    - VIEWPORT_DETAIL_NUMBER = -1005201
    - VIEW_TEMPLATE_FOR_SCHEDULE = -1005199
    - RENDER_RPC_PROPERTIES = -1005198
    - FAMILY_SYMBOLIC_REP = -1005197
    - FAMILY_RENDERING_TYPE = -1005196
    - RENDER_RPC_FILENAME = -1005195
    - RENDER_PLANT_TRIM_HEIGHT = -1005194
    - RENDER_PLANT_HEIGHT = -1005193
    - RENDER_PLANT_NAME = -1005192
    - VIEW_CAMERA_ORIENTATION = -1005184
    - COLOR_SCHEME_LOCATION = -1005183
    - VIEW_DEPENDENCY = -1005182
    - VIEW_BACK_CLIPPING = -1005181
    - VIEW_ASSOCIATED_ASSEMBLY_INSTANCE_ID = -1005179
    - VIEW_GRAPH_SCHED_TOTAL_COLUMNS = -1005178
    - VIEW_UNDERLAY_ORIENTATION = -1005177
    - VIEW_TEMPLATE = -1005176
    - VIEW_GRAPH_SCHED_NUMBER_COLUMNS = -1005175
    - GRAPHIC_DISPLAY_OPTIONS = -1005173
    - MODEL_GRAPHICS_STYLE_ANON_DRAFT = -1005172
    - VIEW_REFERENCING_DETAIL = -1005171
    - VIEW_REFERENCING_SHEET = -1005170
    - VIEW_CAMERA_POSITION = -1005169
    - PLAN_VIEW_NORTH = -1005168
    - WALKTHROUGH_FRAMES_COUNT = -1005167
    - PLAN_VIEW_LEVEL = -1005166
    - MODEL_GRAPHICS_STYLE = -1005165
    - VIEW_VISIBLE_CATEGORIES = -1005164
    - VIEW_DISCIPLINE = -1005163
    - PLAN_VIEW_RANGE = -1005162
    - VIEW_MODEL_DISPLAY_MODE = -1005161
    - VIEW_SHOW_MASSING = -1005160
    - PLAN_VIEW_TOP_CLIP_HEIGHT = -1005159
    - VIEW_CLEAN_JOINS = -1005158
    - VIEW_SHEET_VIEWPORT_INFO = -1005157
    - PLAN_VIEW_CUT_PLANE_HEIGHT = -1005155
    - VIEW_DEPTH = -1005154
    - VIEW_UNDERLAY_BOTTOM_ID = -1005153
    - VIEW_SCALE_PULLDOWN_IMPERIAL = -1005152
    - VIEW_SCALE_PULLDOWN_METRIC = -1005151
    - VIEW_SCALE = -1005150
    - VIEW_SCHEMA_SETTING_FOR_SYSTEM = -1005149
    - VIEW_SCHEMA_SETTING_FOR_BUILDING = -1005148
    - VIEW_FIXED_SKETCH_PLANE = -1005147
    - GRAPHIC_DISPLAY_OPTIONS_PHOTO_EXPOSURE = -1005137
    - GRAPHIC_DISPLAY_OPTIONS_FOG = -1005136
    - GRAPHIC_DISPLAY_OPTIONS_BACKGROUND = -1005135
    - GRAPHIC_DISPLAY_OPTIONS_SS_INTENSITY = -1005134
    - GRAPHIC_DISPLAY_OPTIONS_LIGHTING = -1005133
    - GRAPHIC_DISPLAY_OPTIONS_SHADOWS = -1005132
    - GRAPHIC_DISPLAY_OPTIONS_MODEL = -1005131
    - VIEWER3D_RENDER_SETTINGS = -1005124
    - VIEWER_BOUND_FAR_CLIPPING = -1005123
    - VIEWER_REFERENCE_LABEL_TEXT = -1005122
    - VIEWER_IS_REFERENCE = -1005121
    - VIEWER_REFERENCE_LABEL = -1005120
    - VIEW_DESCRIPTION = -1005114
    - VIEWER_MODEL_CLIP_BOX_ACTIVE = -1005113
    - VIEW_NAME = -1005112
    - VIEWER_BOUND_ACTIVE_NEAR = -1005111
    - VIEWER_BOUND_ACTIVE_FAR = -1005110
    - VIEWER_BOUND_ACTIVE_BOTTOM = -1005109
    - VIEWER_BOUND_ACTIVE_TOP = -1005108
    - VIEWER_BOUND_ACTIVE_LEFT = -1005107
    - VIEWER_BOUND_ACTIVE_RIGHT = -1005106
    - VIEWER_BOUND_OFFSET_NEAR = -1005105
    - VIEWER_BOUND_OFFSET_FAR = -1005104
    - VIEWER_BOUND_OFFSET_BOTTOM = -1005103
    - VIEWER_BOUND_OFFSET_TOP = -1005102
    - VIEWER_BOUND_OFFSET_LEFT = -1005101
    - VIEWER_BOUND_OFFSET_RIGHT = -1005100
    - VIEWER_ANNOTATION_CROP_ACTIVE = -1005094
    - VIEWER_SHOW_UNCROPPED = -1005093
    - VIEWER_CROP_REGION_DISABLED = -1005092
    - VIEWER_CROP_REGION_VISIBLE = -1005091
    - VIEWER_CROP_REGION = -1005090
    - VIEWER_PERSPECTIVE = -1005050
    - VIEWER_TARGET_ELEVATION = -1005002
    - VIEWER_OPTION_VISIBILITY = -1005001
    - VIEWER_EYE_ELEVATION = -1005000
    - DIM_LABEL_IS_INSTANCE = -1004518
    - DIM_ISREPORTING = -1004516
    - DIM_LEADER = -1004515
    - DIM_DISPLAY_EQ = -1004514
    - DIM_NOT_MODIFIABLE = -1004513
    - DIM_LABEL = -1004510
    - DIM_LABEL_GP_SHOW = -1004502
    - DIM_VALUE_ANGLE = -1004501
    - DIM_VALUE_LENGTH = -1004500
    - ELEM_REFERENCE_NAME_2D_XZ = -1004016
    - CURVE_ELEM_DEFINES_SLOPE = -1004015
    - RADIAL_ARRAY_ARC_RADIUS = -1004014
    - CURVE_DETERMINES_ORIENTATION = -1004013
    - DATUM_PLANE_DEFINES_WALL_CLOSURE = -1004012
    - CURVE_IS_DETAIL = -1004011
    - CURVE_ELEM_ARC_RADIUS = -1004010
    - CURVE_ELEM_ARC_RANGE = -1004009
    - CURVE_ELEM_ARC_END_ANGLE = -1004008
    - CURVE_ELEM_ARC_START_ANGLE = -1004007
    - CURVE_ELEM_LINE_ANGLE = -1004006
    - CURVE_ELEM_LENGTH = -1004005
    - ELEM_DELETABLE_IN_FAMILY = -1004004
    - ELEM_REFERENCE_NAME = -1004003
    - DATUM_PLANE_DEFINES_ORIGIN = -1004002
    - ELEM_IS_REFERENCE = -1004001
    - ASSOCIATED_LEVEL_OFFSET = -1002565
    - ASSOCIATED_LEVEL = -1002564
    - COLUMN_LOCATION_MARK = -1002563
    - COLUMN_TOP_ATTACH_CUT_PARAM = -1002562
    - COLUMN_BASE_ATTACH_CUT_PARAM = -1002561
    - COLUMN_BASE_ATTACHED_PARAM = -1002560
    - COLUMN_TOP_ATTACHED_PARAM = -1002559
    - COLUMN_BASE_ATTACHMENT_OFFSET_PARAM = -1002558
    - COLUMN_TOP_ATTACHMENT_OFFSET_PARAM = -1002557
    - COLUMN_BASE_ATTACH_JUSTIFICATION_PARAM = -1002556
    - COLUMN_TOP_ATTACH_JUSTIFICATION_PARAM = -1002555
    - MATERIAL_PARAM_SHININESS = -1002554
    - MATERIAL_PARAM_SMOOTHNESS = -1002553
    - MATERIAL_PARAM_GLOW = -1002552
    - MATERIAL_PARAM_TRANSPARENCY = -1002551
    - MATERIAL_PARAM_COLOR = -1002550
    - SEEK_ITEM_ID = -1002504
    - OMNICLASS_DESCRIPTION = -1002503
    - OMNICLASS_CODE = -1002502
    - UNIFORMAT_DESCRIPTION = -1002501
    - UNIFORMAT_CODE = -1002500
    - SLOPE_END_HEIGHT = -1002401
    - SLOPE_START_HEIGHT = -1002400
    - CEILING_HAS_THICKNESS_PARAM = -1002302
    - CEILING_THICKNESS_PARAM = -1002301
    - CEILING_HEIGHTABOVELEVEL_PARAM = -1002300
    - CEILING_THICKNESS = -1002206
    - CEILING_ATTR_SYSTEMNAME_PARAM = -1002204
    - CEILING_ATTR_SPACING2_PARAM = -1002203
    - CEILING_ATTR_SPACING1_PARAM = -1002202
    - CEILING_ATTR_PATTERN_PARAM = -1002201
    - CEILING_ATTR_DEFAULT_HEIGHT_PARAM = -1002200
    - FILLED_REGION_MASKING = -1002125
    - BACKGROUND_PATTERN_COLOR_PARAM = -1002124
    - FOREGROUND_PATTERN_COLOR_PARAM = -1002123
    - BACKGROUND_DRAFT_PATTERN_ID_PARAM = -1002122
    - FOREGROUND_ANY_PATTERN_ID_PARAM = -1002121
    - FOREGROUND_DRAFT_PATTERN_ID_PARAM = -1002120
    - BUILIDING_PAD_STRUCTURE_ID_PARAM = -1002119
    - CEILING_STRUCTURE_ID_PARAM = -1002118
    - ROOF_STRUCTURE_ID_PARAM = -1002117
    - FLOOR_STRUCTURE_ID_PARAM = -1002116
    - ANY_PATTERN_ID_PARAM_NO_NO = -1002115
    - FILL_PATTERN_ID_PARAM_NO_NO = -1002114
    - OBJECT_STYLE_MATERIAL_ID_PARAM = -1002113
    - WRAPPING_AT_INSERTS_PARAM = -1002112
    - WRAPPING_AT_ENDS_PARAM = -1002111
    - COARSE_SCALE_FILL_PATTERN_COLOR = -1002110
    - MODEL_CATEGORY_ID_PARAM = -1002109
    - HOST_ID_PARAM = -1002108
    - MATERIAL_ID_PARAM = -1002107
    - COARSE_SCALE_FILL_PATTERN_ID_PARAM = -1002106
    - ANY_PATTERN_ID_PARAM = -1002105
    - WALL_STRUCTURE_ID_PARAM = -1002103
    - SURFACE_PATTERN_ID_PARAM = -1002102
    - FILL_PATTERN_ID_PARAM = -1002101
    - ID_PARAM = -1002100
    - SELECTION_EDITABLE_ONLY = -1002072
    - EDITED_BY = -1002067
    - SCHEDULE_TOP_LEVEL_OFFSET_PARAM = -1002066
    - SCHEDULE_BASE_LEVEL_OFFSET_PARAM = -1002065
    - SCHEDULE_TOP_LEVEL_PARAM = -1002064
    - SCHEDULE_BASE_LEVEL_PARAM = -1002063
    - SCHEDULE_LEVEL_PARAM = -1002062
    - ELEM_ROOM_ID = -1002061
    - ELEM_ROOM_NAME = -1002060
    - ELEM_ROOM_NUMBER = -1002059
    - ELEM_PARTITION_PARAM = -1002053
    - ELEM_FAMILY_AND_TYPE_PARAM = -1002052
    - ELEM_FAMILY_PARAM = -1002051
    - ELEM_TYPE_PARAM = -1002050
    - ELEM_TYPE_LABEL = -1002008
    - BR_ORG_FILTER = -1002007
    - BR_ORG_FOLDERS = -1002006
    - SYMBOL_FAMILY_AND_TYPE_NAMES_PARAM = -1002003
    - SYMBOL_FAMILY_NAME_PARAM = -1002002
    - SYMBOL_FAMILY_NAME_PARAM = -1002002
    - ALL_MODEL_TYPE_NAME = -1002001
    - ALL_MODEL_TYPE_NAME = -1002001
    - SYMBOL_ID_PARAM = -1002000
    - STRUCTURAL_DISPLAY_IN_HIDDEN_VIEWS = -1001956
    - FLOOR_PARAM_SPAN_DIRECTION = -1001955
    - FLOOR_PARAM_IS_STRUCTURAL = -1001954
    - HOST_PERIMETER_COMPUTED = -1001953
    - LEVEL_PARAM = -1001952
    - FLOOR_HEIGHTABOVELEVEL_PARAM = -1001951
    - FLOOR_ATTR_DEFAULT_HEIGHT_PARAM = -1001903
    - FLOOR_ATTR_DEFAULT_THICKNESS_PARAM = -1001902
    - FLOOR_ATTR_THICKNESS_PARAM = -1001900
    - INSERT_ORIENTATION = -1001834
    - PROFILE_PARAM_ALONG_PATH = -1001833
    - PROFILE_FAM_TYPE_PLUS_NONE = -1001832
    - PROFILE2_ANGLE = -1001831
    - PROFILE2_FAM_TYPE = -1001830
    - PROFILE2_FLIPPED_HOR = -1001829
    - PROFILE2_OFFSET_Y = -1001828
    - PROFILE2_OFFSET_X = -1001827
    - PROFILE1_ANGLE = -1001826
    - PROFILE1_FAM_TYPE = -1001825
    - PROFILE1_FLIPPED_HOR = -1001824
    - PROFILE1_OFFSET_Y = -1001823
    - PROFILE1_OFFSET_X = -1001822
    - FAM_PROFILE_USAGE = -1001821
    - SWEEP_TRAJ_SEGMENTED = -1001820
    - SWEEP_MAX_SEG_ANGLE = -1001819
    - MODEL_OR_SYMBOLIC = -1001818
    - PROFILE_ANGLE = -1001817
    - PROFILE_FAM_TYPE = -1001816
    - PROFILE_FLIPPED_HOR = -1001815
    - PROFILE_OFFSET_Y = -1001814
    - PROFILE_OFFSET_X = -1001813
    - EXTRUSION_LENGTH = -1001812
    - CURVE_VISIBILITY_PARAM = -1001809
    - GEOM_VISIBILITY_PARAM = -1001808
    - ELEMENT_IS_CUTTING = -1001807
    - EXTRUSION_AUTO_PARAMS = -1001806
    - BLEND_END_PARAM = -1001805
    - BLEND_START_PARAM = -1001804
    - REVOLUTION_END_ANGLE = -1001803
    - REVOLUTION_START_ANGLE = -1001802
    - EXTRUSION_END_PARAM = -1001801
    - EXTRUSION_START_PARAM = -1001800
    - EXTRUSION_DEPTH_PARAM = -1001799
    - SCHEDULE_TYPE_FOR_BROWSER = -1001718
    - SCHEDULE_CATEGORY = -1001717
    - FACEROOF_OFFSET_PARAM = -1001716
    - FACEROOF_LEVEL_PARAM = -1001715
    - ROOF_FACES_LOCATION = -1001714
    - RELATED_TO_MASS = -1001713
    - FASCIA_DEPTH_PARAM = -1001711
    - ROOF_EAVE_CUT_PARAM = -1001710
    - ROOF_RAFTER_OR_TRUSS_PARAM = -1001709
    - ROOF_BASE_LEVEL_PARAM = -1001708
    - CURVE_WALL_OFFSET_ROOFS = -1001707
    - CURVE_WALL_OFFSET = -1001706
    - ACTUAL_MAX_RIDGE_HEIGHT_PARAM = -1001705
    - ROOF_UPTO_LEVEL_OFFSET_PARAM = -1001703
    - ROOF_UPTO_LEVEL_PARAM = -1001702
    - ROOF_LEVEL_OFFSET_PARAM = -1001701
    - STRUCTURAL_ELEVATION_AT_BOTTOM_SURVEY = -1001658
    - STRUCTURAL_ELEVATION_AT_TOP_SURVEY = -1001657
    - STRUCTURAL_FLOOR_CORE_THICKNESS = -1001656
    - STRUCTURAL_ELEVATION_AT_BOTTOM_CORE = -1001655
    - STRUCTURAL_ELEVATION_AT_TOP_CORE = -1001654
    - STRUCTURAL_REFERENCE_LEVEL_ELEVATION = -1001653
    - ROOF_CONSTRAINT_OFFSET_PARAM = -1001652
    - ROOF_CONSTRAINT_LEVEL_PARAM = -1001651
    - HOST_SSE_CURVED_EDGE_CONDITION_PARAM = -1001603
    - ROOF_ATTR_THICKNESS_PARAM = -1001601
    - ROOF_ATTR_DEFAULT_THICKNESS_PARAM = -1001600
    - STRUCTURAL_ELEVATION_AT_TOP = -1001598
    - NODE_CONNECTION_STATUS = -1001597
    - WALL_STRUCTURAL_SIGNIFICANT = -1001596
    - STRUCTURAL_ANALYTICAL_BEAM_RIGID_LINK = -1001595
    - STRUCTURAL_ANALYTICAL_COLUMN_HORIZONTAL_PROJECTION_PLANE = -1001594
    - STRUCTURAL_ANALYTICAL_BEAM_HORIZONTAL_PROJECTION_PLANE = -1001593
    - CONTINUOUS_FOOTING_BREAK_AT_INSERTS_DISABLE = -1001592
    - CONTINUOUS_FOOTING_DEFAULT_END_EXTENSION_LENGTH = -1001591
    - STRUCTURAL_ANALYTICAL_TESSELLATE = -1001589
    - STRUCTURAL_ANALYTICAL_TESS_DEVIATION = -1001588
    - STRUCTURAL_ANALYTICAL_HARD_POINTS = -1001587
    - STRUCTURAL_BEND_DIR_ANGLE = -1001586
    - STRUCTURAL_DISPLAY_IN_HIDDEN_VIEWS_COLUMN = -1001585
    - STRUCTURAL_DISPLAY_IN_HIDDEN_VIEWS_FRAMING = -1001584
    - STRUCTURAL_FLOOR_ANALYZES_AS = -1001577
    - STRUCTURAL_ANALYZES_AS = -1001576
    - STRUCTURAL_BEAM_CUTBACK_FOR_COLUMN = -1001575
    - BEAM_V_JUSTIFICATION_OTHER_VALUE = -1001574
    - STRUCTURAL_BEAM_ORIENTATION = -1001573
    - STRUCTURAL_BEAM_END1_ELEVATION = -1001572
    - STRUCTURAL_BEAM_END0_ELEVATION = -1001571
    - FAMILY_EXPORT_AS_GEOMETRY = -1001570
    - STRUCTURAL_FOUNDATION_LENGTH = -1001569
    - STRUCTURAL_FOUNDATION_WIDTH = -1001568
    - CONTINUOUS_FOOTING_LENGTH = -1001567
    - CONTINUOUS_FOOTING_ECCENTRICITY = -1001564
    - CONTINUOUS_FOOTING_STRUCTURAL_USAGE = -1001563
    - CONTINUOUS_FOOTING_BEARING_WIDTH = -1001562
    - STRUCTURAL_ELEVATION_AT_BOTTOM = -1001561
    - FAMILY_STRUCT_FOOTING_USE_CAP_TOP = -1001560
    - STRUCTURAL_COPING_DISTANCE = -1001559
    - CONTINUOUS_FOOTING_WIDTH = -1001558
    - STRUCTURAL_FOUNDATION_THICKNESS = -1001557
    - CONTINUOUS_FOOTING_BOTTOM_HEEL = -1001556
    - CONTINUOUS_FOOTING_TOP_HEEL = -1001555
    - CONTINUOUS_FOOTING_BOTTOM_TOE = -1001554
    - CONTINUOUS_FOOTING_TOP_TOE = -1001553
    - STRUCTURAL_ANALYTICAL_MODEL = -1001552
    - STRUCTURAL_ANALYTICAL_COLUMN_RIGID_LINK = -1001551
    - FAMILY_STRUCT_MATERIAL_TYPE = -1001550
    - STRUCTURAL_BOTTOM_RELEASE_MZ = -1001549
    - STRUCTURAL_BOTTOM_RELEASE_MY = -1001548
    - STRUCTURAL_BOTTOM_RELEASE_MX = -1001547
    - STRUCTURAL_BOTTOM_RELEASE_FZ = -1001546
    - STRUCTURAL_BOTTOM_RELEASE_FY = -1001545
    - STRUCTURAL_BOTTOM_RELEASE_FX = -1001544
    - STRUCTURAL_TOP_RELEASE_MZ = -1001543
    - STRUCTURAL_TOP_RELEASE_MY = -1001542
    - STRUCTURAL_TOP_RELEASE_MX = -1001541
    - STRUCTURAL_TOP_RELEASE_FZ = -1001540
    - STRUCTURAL_TOP_RELEASE_FY = -1001539
    - STRUCTURAL_TOP_RELEASE_FX = -1001538
    - STRUCTURAL_BOTTOM_RELEASE_TYPE = -1001537
    - STRUCTURAL_TOP_RELEASE_TYPE = -1001536
    - STRUCTURAL_ANALYTICAL_PROJECT_MEMBER_PLANE_COLUMN_BOTTOM = -1001535
    - STRUCTURAL_ANALYTICAL_PROJECT_MEMBER_PLANE_COLUMN_TOP = -1001534
    - STRUCTURAL_MATERIAL_TYPE = -1001531
    - STRUCTURAL_CAMBER = -1001530
    - STRUCTURAL_NUMBER_OF_STUDS = -1001529
    - STRUCTURAL_END_RELEASE_MZ = -1001528
    - STRUCTURAL_END_RELEASE_MY = -1001527
    - STRUCTURAL_END_RELEASE_MX = -1001526
    - STRUCTURAL_END_RELEASE_FZ = -1001525
    - STRUCTURAL_END_RELEASE_FY = -1001524
    - STRUCTURAL_END_RELEASE_FX = -1001523
    - STRUCTURAL_START_RELEASE_MZ = -1001522
    - STRUCTURAL_START_RELEASE_MY = -1001521
    - STRUCTURAL_START_RELEASE_MX = -1001520
    - STRUCTURAL_START_RELEASE_FZ = -1001519
    - STRUCTURAL_START_RELEASE_FY = -1001518
    - STRUCTURAL_START_RELEASE_FX = -1001517
    - STRUCTURAL_END_RELEASE_TYPE = -1001516
    - STRUCTURAL_START_RELEASE_TYPE = -1001515
    - STRUCTURAL_WALL_BOTTOM_PROJECTION_PLANE = -1001514
    - STRUCTURAL_WALL_TOP_PROJECTION_PLANE = -1001513
    - STRUCTURAL_WALL_PROJECTION_SURFACE = -1001512
    - STRUCTURAL_ANALYTICAL_PROJECT_FLOOR_PLANE = -1001510
    - STRUCTURAL_ANALYTICAL_PROJECT_MEMBER_PLANE = -1001508
    - STRUCTURAL_BRACE_REPRESENTATION = -1001507
    - STRUCTURAL_STICK_SYMBOL_LOCATION = -1001503
    - STRUCTURAL_BEAM_END_SUPPORT = -1001502
    - STRUCTURAL_BEAM_START_SUPPORT = -1001501
    - WINDOW_TYPE_ID = -1001405
    - WINDOW_TYPE_ID = -1001405
    - WALL_SWEEP_ORIENTATION = -1001399
    - STRUCTURAL_ATTACHMENT_END_VALUE_ELEVATION = -1001398
    - STRUCTURAL_ATTACHMENT_START_VALUE_ELEVATION = -1001397
    - STRUCTURAL_ATTACHMENT_END_LEVEL_REFERENCE = -1001396
    - STRUCTURAL_ATTACHMENT_START_LEVEL_REFERENCE = -1001395
    - STRUCTURAL_ATTACHMENT_END_VALUE_RATIO = -1001393
    - STRUCTURAL_ATTACHMENT_START_VALUE_RATIO = -1001392
    - STRUCTURAL_ATTACHMENT_END_REFELEMENT_END = -1001391
    - TYPE_WALL_CLOSURE = -1001390
    - STRUCTURAL_ATTACHMENT_START_REFELEMENT_END = -1001389
    - STRUCTURAL_ATTACHMENT_END_VALUE_DISTANCE = -1001388
    - STRUCTURAL_ATTACHMENT_START_VALUE_DISTANCE = -1001387
    - STRUCTURAL_ATTACHMENT_END_TYPE = -1001386
    - STRUCTURAL_ATTACHMENT_START_TYPE = -1001385
    - STRUCTURAL_FRAME_CUT_LENGTH = -1001384
    - INSTANCE_REFERENCE_LEVEL_PARAM = -1001383
    - INSTANCE_STRUCT_USAGE_PARAM = -1001381
    - SKETCH_PLANE_PARAM = -1001380
    - INSTANCE_LENGTH_PARAM = -1001375
    - INSTANCE_MOVES_WITH_GRID_PARAM = -1001371
    - INSTANCE_OFFSET_POS_PARAM = -1001370
    - INSTANCE_SCHEDULE_ONLY_LEVEL_PARAM = -1001365
    - INSTANCE_FREE_HOST_OFFSET_PARAM = -1001364
    - INSTANCE_FREE_HOST_PARAM = -1001363
    - INSTANCE_HEAD_HEIGHT_PARAM = -1001362
    - INSTANCE_SILL_HEIGHT_PARAM = -1001361
    - INSTANCE_ELEVATION_PARAM = -1001360
    - FAMILY_TOP_LEVEL_OFFSET_PARAM = -1001358
    - FAMILY_BASE_LEVEL_OFFSET_PARAM = -1001357
    - FAMILY_LEVEL_PARAM = -1001352
    - FAMILY_TOP_LEVEL_PARAM = -1001351
    - FAMILY_BASE_LEVEL_PARAM = -1001350
    - FAMILY_RFA_PATH_PSEUDO_PARAM = -1001338
    - FAMILY_CATEGORY_PSEUDO_PARAM = -1001337
    - FAMILY_NAME_PSEUDO_PARAM = -1001336
    - FAMILY_USAGE_PSEUDO_PARAM = -1001335
    - FAMILY_WPB_DEFAULT_ELEVATION = -1001320
    - FAMILY_LINE_LENGTH_PARAM = -1001306
    - FAMILY_ROUGH_WIDTH_PARAM = -1001305
    - FAMILY_ROUGH_HEIGHT_PARAM = -1001304
    - FAMILY_WINDOW_INSET_PARAM = -1001303
    - FAMILY_WINDOW_INSET_PARAM = -1001303
    - GENERIC_THICKNESS = -1001302
    - GENERIC_THICKNESS = -1001302
    - GENERIC_THICKNESS = -1001302
    - GENERIC_THICKNESS = -1001302
    - GENERIC_THICKNESS = -1001302
    - FURNITURE_WIDTH = -1001301
    - FURNITURE_WIDTH = -1001301
    - FURNITURE_WIDTH = -1001301
    - FURNITURE_WIDTH = -1001301
    - FURNITURE_WIDTH = -1001301
    - FURNITURE_WIDTH = -1001301
    - FAMILY_HEIGHT_PARAM = -1001300
    - FAMILY_HEIGHT_PARAM = -1001300
    - FAMILY_HEIGHT_PARAM = -1001300
    - FAMILY_HEIGHT_PARAM = -1001300
    - FAMILY_HEIGHT_PARAM = -1001300
    - FAMILY_HEIGHT_PARAM = -1001300
    - DOOR_EVACUATION_EXIT_TYPE = -1001212
    - DOOR_OPERATION_TYPE = -1001211
    - DOOR_OPERATION_TYPE = -1001211
    - DOOR_FRAME_MATERIAL = -1001210
    - DOOR_FRAME_TYPE = -1001209
    - CURTAIN_WALL_PANELS_FINISH = -1001208
    - CURTAIN_WALL_PANELS_FINISH = -1001208
    - CURTAIN_WALL_PANELS_FINISH = -1001208
    - CURTAIN_WALL_PANELS_FINISH = -1001208
    - DOOR_CONSTRUCTION_TYPE = -1001207
    - DOOR_CONSTRUCTION_TYPE = -1001207
    - DOOR_CONSTRUCTION_TYPE = -1001207
    - DOOR_CONSTRUCTION_TYPE = -1001207
    - DOOR_CONSTRUCTION_TYPE = -1001207
    - DOOR_FIRE_RATING = -1001206
    - DOOR_FIRE_RATING = -1001206
    - DOOR_COST = -1001205
    - DOOR_COST = -1001205
    - ALL_MODEL_MARK = -1001203
    - ALL_MODEL_MARK = -1001203
    - DPART_ORIGINAL_CATEGORY_ID = -1001140
    - DPART_LAYER_CONSTRUCTION = -1001139
    - DPART_PHASE_DEMOLISHED_BY_ORIGINAL = -1001138
    - DPART_PHASE_CREATED_BY_ORIGINAL = -1001137
    - DPART_LENGTH_COMPUTED = -1001136
    - DPART_HEIGHT_COMPUTED = -1001135
    - DPART_LAYER_WIDTH = -1001134
    - DPART_AREA_COMPUTED = -1001133
    - DPART_ORIGINAL_TYPE = -1001132
    - OFFSETFACES_SHOW_SHAPE_HANDLES = -1001131
    - DPART_LAYER_FUNCTION = -1001130
    - DPART_VOLUME_COMPUTED = -1001129
    - DPART_MATERIAL_BY_ORIGINAL = -1001128
    - DPART_MATERIAL_ID_PARAM = -1001127
    - DPART_ORIGINAL_FAMILY = -1001126
    - DPART_ORIGINAL_CATEGORY = -1001125
    - HOST_PANEL_SCHEDULE_AS_PANEL_PARAM = -1001124
    - WALL_LOCATION_LINE_OFFSET_PARAM = -1001123
    - WALL_KEY_REF_PARAM = -1001122
    - MEASURE_FROM_STRUCTURE = -1001120
    - WALL_STRUCTURAL_USAGE_PARAM = -1001119
    - WALL_BOTTOM_IS_ATTACHED = -1001118
    - WALL_TOP_IS_ATTACHED = -1001117
    - WALL_TOP_OFFSET = -1001109
    - WALL_BASE_OFFSET = -1001108
    - WALL_BASE_CONSTRAINT = -1001107
    - WALL_USER_HEIGHT_PARAM = -1001105
    - WALL_HEIGHT_TYPE = -1001103
    - WALL_BASE_HEIGHT_PARAM = -1001102
    - SCALE_FACTOR_PARAM = -1001010
    - ALLOW_AUTO_EMBED = -1001009
    - WALL_ATTR_ROOM_BOUNDING = -1001007
    - FUNCTION_PARAM = -1001006
    - WALL_ATTR_DEFHEIGHT_PARAM = -1001002
    - WALL_ATTR_HEIGHT_PARAM = -1001001
    - WALL_ATTR_WIDTH_PARAM = -1001000
    - INVALID = -1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CADExportOptions
Full Name: Autodesk.Revit.DB.CADExportOptions
Description: Generic CAD Export options.

--------------------------------------------------------------------------------

[CLASS] CADLinkOperations
Full Name: Autodesk.Revit.DB.CADLinkOperations
Description: This class is used to extend the IExternalResourceServer interface with methods to support operations specifically related to DWG links.
Remarks: The class owns single-method interfaces which are used as callbacks to perform specific operations on DWG link external resources.An empty CADLinkOperations instance is passed to an IExternalResourceServer (inside an ExternalResourceServerExtensions object) via the GetTypeSpecificServerOperations method. The server provider can then add their own implemented interface objects to the CADLinkOperations, thus making them available to Revit to use as callbacks.Supporting these additional, type-specific operations is not absolutely required, but is strongly recommended in order for users to be able to perform all the same operations they would with locally-accessed links.
Inherits: LinkOperations

--------------------------------------------------------------------------------

[CLASS] CADLinkOptions
Full Name: Autodesk.Revit.DB.CADLinkOptions
Description: This class contains the options in use when or reloading a CAD link type (DWG, DXF, etc.)
Implements: IDisposable

  CONSTRUCTORS:
    new CADLinkOptions(bool preserveOverrides, ElementId viewId)
      Description: Creates a CADLinkOptions object, specifying whether to preserve graphic overrides, and what view to use if the link's view has been deleted.
      @preserveOverrides: True if Revit should preserve the link's graphic overrides on reload. False otherwise.
      @viewId: The id of the view to use as the link's reference view, if the reference view has been deleted. Revit will ignore this value if the reference view is still in place.The value may be ElementId.InvalidElementId, although Revit will cancel the load if the reference view is deleted.
      Throws ArgumentNullException: A non-optional argument was null
    new CADLinkOptions(CADLinkOptions other)
      Description: Constructs a new copy of the input CADLinkOptions object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool PreserveOverrides { get; set; }
      Description: Whether Revit should preserve the link's graphic overrides on reload.
    ElementId ViewId { get; set; }
      Description: The id of the view to use as the link's reference view, if the reference view has been deleted.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] CADLinkType
Full Name: Autodesk.Revit.DB.CADLinkType
Description: CADLinkType represents both CAD links and CAD imports. The function IsLink can be used to distinguish between the two. CAD imports are not ExternalFileReferences; they are brought completely into the document and maintain no connection to their original file.
Inherits: ElementType

  METHODS:
    LinkLoadResult LoadFrom(ExternalResourceReference resourceReference)
      Description: Loads or reloads the DWG link from the given external resource reference.
      @resourceReference: An ExternalResourceReference giving the location of the link. This method can be used to load the link from a file on disk. See Autodesk::Revit::DB::ExternalResourceReference::CreateLocalResource.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws ArgumentException: The server referenced by the ExternalResourceReference does not exist or does not implement IExternalResourceServer. -or- The server referenced by the ExternalResourceReference cannot support CAD links. -or- The ExternalResourceReference (resourceReference) is not in a format that is supported by its server.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This CADLinkType represents an import and cannot be used as a link. -or- The element "this CADLinkType" is in a read-only document. -or- The link does not represent a DWG.
    LinkLoadResult LoadFrom(string path)
      Description: Loads or reloads the DWG link from the given file path.
      @path: A path on disk giving the location of the linked file. This path must be absolute. The link's path will remain PathType.Absolute or PathType.Relative, whichever it was before. If the link was previously to an external server location, the path type will be relative.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileArgumentNotFoundException: The given path does not exist.
      Throws InvalidOperationException: This CADLinkType represents an import and cannot be used as a link. -or- The element "this CADLinkType" is in a read-only document. -or- The link does not represent a DWG.
    LinkLoadResult Reload(CADLinkOptions options)
      Description: Loads or reloads the link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      @options: Options for reloading the link. Options include the ability to preserve graphic overrides on reload.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This CADLinkType represents an import and cannot be used as a link. -or- The element "this CADLinkType" is in a read-only document.
    LinkLoadResult Reload()
      Description: Loads or reloads the link from its currently-stored location. If the link is an external resource, Revit will contact the IExternalResourceServer to get the latest version of the link.
      Returns: An object containing the ElementId of the link and an enum value indicating any errors which occurred while trying to load.
      Throws InvalidOperationException: This CADLinkType represents an import and cannot be used as a link. -or- The element "this CADLinkType" is in a read-only document.

--------------------------------------------------------------------------------

[CLASS] CameraInfo
Full Name: Autodesk.Revit.DB.CameraInfo
Description: An object holding information about the projection mapping of a 3D view.
Remarks: CameraInfo can be obtained directly from a ViewNode If camera info is not available, an orthographic view should be assumed.See also: Autodesk::Revit::DB::IExportContext::OnViewBegin.
Implements: IDisposable

  PROPERTIES:
    double FarDistance { get; }
      Description: Distance from eye point to far plane of view frustum along the view direction.
    double HorizontalExtent { get; }
      Description: Distance between left and right planes on the target plane.
    bool IsPerspective { get; }
      Description: Identifies whether the projection is orthographic or perspective
    bool IsPespective { get; }
      Description: Identifies whether the projection is orthographic or perspective
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double NearDistance { get; }
      Description: Distance from eye point to near plane of view frustum along the view direction.
    double RightOffset { get; }
      Description: Distance that the target plane is offset towards the right where right is normal to both Up direction and View direction. This offset shifts both left and right planes.
    double TargetDistance { get; }
      Description: Distance from eye point along view direction to target plane.
    double UpOffset { get; }
      Description: Distance that the target plane is offset in the direction of the Up direction. This offset shifts both top and bottom planes.
    double VerticalExtent { get; }
      Description: Distance between top and bottom planes on the target plane.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] CancellationListener
Full Name: Autodesk.Revit.DB.CancellationListener
Description: Allows clients to poll the cancellation status of a background operation. Revit instantiates CancellationListener objects for internal background operation implementations only. As such, third-party developers are not expected to instantiate or handle CancellationListener objects.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool IsCancelled()
      Description: Returns true if the operation associated with this instance has been cancelled.

--------------------------------------------------------------------------------

[CLASS] Categories
Full Name: Autodesk.Revit.DB.Categories
Description: The Categories object is a map that contains all the top-level Category objects within the Document.
Remarks: Use this object to retrieve categories by name or by BuiltInCategory id.
Inherits: CategoryNameMap

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Whether or not the list of top-level categories is empty.
    Category Item { get; set; }
    Category Item { get; }
    int Size { get; }
      Description: The total number of top-level categories in the document.

  METHODS:
    bool Contains(string name)
      Description: Identifies if a category which has the specified name is in the list of top-level categories.
      @name: The name of the category to be retrieved.
    CategoryNameMapIterator ForwardIterator()
      Description: Retrieves a forward moving iterator to the map.
      Returns: A forward moving iterator to the map.
    IEnumerator GetEnumerator()
      Description: Retrieves a forward moving iterator to the map.
      Returns: A forward moving iterator to the map.
    bool Insert(string key, Category item)
      Description: Inserts the specified category with the specified name into the map.
      @key: The name to be used for inserting the category into the map.
      @item: The category to be inserted into the map.
      Returns: Whether or not the category was inserted into the map.
      Throws InvalidOperationException: Always thrown; this list is read only.
    Category NewSubcategory(Category parentCategory, string name)
      Description: Add a new subcategory into the Autodesk Revit document.
      @parentCategory: The parent category.
      @name: The new category name.
      Returns: If successful, the newly created subcategory.
      Throws ArgumentNullException: Thrown when the input argument-"parentCategory" or "name"-is .
      Throws ArgumentException: Thrown when the input argument-"parentCategory"-cannot add subcategory. Thrown when the input argument-"name"-is an illegal name.
      Throws InvalidOperationException: Thrown when subcategory creation failed.
    CategoryNameMapIterator ReverseIterator()
      Description: Retrieves a backward moving iterator to the map.
      Returns: A backward moving iterator to the map.

--------------------------------------------------------------------------------

[CLASS] Category
Full Name: Autodesk.Revit.DB.Category
Description: Represents the category or subcategory to which an element belongs.
Remarks: Categories are an important tool within Revit for identifying the inferred type of an element, such as anything in the Walls category should be considered as a wall. The API exposes access to the built in categories within Revit via the Document.Settings.Categories property.
Inherits: APIObject

  PROPERTIES:
    bool AllowsBoundParameters { get; }
      Description: To check if the category can have project parameters.
    bool AllowsVisibilityControl { get; }
    BuiltInCategory BuiltInCategory { get; }
      Description: Gets the BuiltInCategory value for this category.
    bool CanAddSubcategory { get; }
      Description: Indicates if subcategories can be assigned to the category.
    CategoryType CategoryType { get; }
      Description: Gets the category type of this category.
    bool HasMaterialQuantities { get; }
      Description: Identifies if elements of the category are able to report what materials they contain in what quantities.
    ElementId Id { get; }
      Description: Returns the category id associated with the category object.
    bool IsCuttable { get; }
      Description: Indicates if the category is cuttable or not.
    bool IsTagCategory { get; }
      Description: Identifies if the category is associated with a type of tag for a different category.
    bool IsValid { get; }
      Description: Indicates if the Category is valid or not.
    bool IsVisibleInUI { get; }
      Description: Identifies if the category is visible to the user and should be displayed in UI.
    Color LineColor { get; set; }
      Description: The color of lines shown for elements of this category.
    Material Material { get; set; }
      Description: Retrieves or changes the material of the category.
    string Name { get; }
      Description: The category name.
    Category Parent { get; }
      Description: Returns the parent category of this category.
    CategoryNameMap SubCategories { get; }
      Description: Returns a map containing all of the subcategories of this category.
    bool Visible { get; set; }

  METHODS:
    static BuiltInCategory GetBuiltInCategory(ForgeTypeId categoryTypeId)
      Description: Gets the BuiltInCategory value corresponding to the given built-in category identifier.
      @categoryTypeId: The built-in category identifier.
      Returns: The BuiltInCategory value corresponding to the given built-in category identifier.
      Throws ArgumentException: categoryTypeId is not a built-in category identifier. See Category.IsBuiltInCategory(ForgeTypeId) and Category.GetBuiltInCategoryTypeId(BuiltInCategory).
      Throws ArgumentNullException: A non-optional argument was null
    static ForgeTypeId GetBuiltInCategoryTypeId(BuiltInCategory categoryId)
      Description: Gets the ForgeTypeId identifying the given built-in category.
      @categoryId: The built-in category.
      Returns: The identifier of the given built-in category.
      Throws ArgumentException: categoryId is not a valid built-in category. See Category.IsBuiltInCategoryValid(BuiltInCategory).
    static Category GetCategory(Document document, ElementId categoryId)
      Description: Retrieves a category object corresponding to the category id.
      @document: The document.
      @categoryId: An category id.
      Returns: Returns a category object corresponding to the category id.
    static Category GetCategory(Document document, BuiltInCategory categoryId)
      Description: Retrieves a category object corresponding to a BuiltInCategory id.
      @document: The document.
      @categoryId: A built in category id.
      Returns: Returns a category object corresponding to a BuiltInCategory id.
    GraphicsStyle GetGraphicsStyle(GraphicsStyleType graphicsStyleType)
      Description: Gets the graphics style associated with this category for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
      Throws ArgumentOutOfRangeException: Thrown when the input argument-"graphicsStyleType"-is out of range.
    int GetHashCode()
    ElementId GetLinePatternId(GraphicsStyleType graphicsStyleType)
      Description: Gets the line pattern id associated with this category for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
      Returns: Returns the line pattern id associated with this category for the given graphics style type.
    Nullable<int> GetLineWeight(GraphicsStyleType graphicsStyleType)
      Description: Retrieves the line weight assigned to the category for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
      Throws ArgumentOutOfRangeException: Thrown when the input argument-"graphicsStyleType"-is out of range.
    static bool IsBuiltInCategory(ForgeTypeId categoryTypeId)
      Description: Checks whether a ForgeTypeId identifies a built-in category.
      @categoryTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a built-in category, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsBuiltInCategoryValid(BuiltInCategory builtInCategory)
      Description: Checks if a Category exists for a given BuiltInCategory.
      @builtInCategory: The BuiltInCategory to check.
    void SetLinePatternId(ElementId linePatternId, GraphicsStyleType graphicsStyleType)
      Description: Sets the line pattern id associated with this category for the given graphics style type.
      @linePatternId: The line pattern id for the graphics style.
      @graphicsStyleType: The type of graphics style.
      Throws ArgumentOutOfRangeException: Thrown when the input argument "linePatternId" is an illegal id.
      Throws InvalidOperationException: Thrown when this category does not have stored line pattern id for this graphics style type.
    void SetLineWeight(int lineWeight, GraphicsStyleType graphicsStyleType)
      Description: Sets the line weight for the given graphics style type.
      @graphicsStyleType: The type of graphics style.
      Throws ArgumentOutOfRangeException: Thrown when the input argument-"lineWeight" or "graphicsStyleType"-is out of range.

--------------------------------------------------------------------------------

[CLASS] CategoryNameMap
Full Name: Autodesk.Revit.DB.CategoryNameMap
Description: A map that contains a mapping of category name to its category object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CategoryNameMap()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the map is empty.
    Category Item { get; set; }
    int Size { get; }
      Description: Returns the number of categories that are in the map.

  METHODS:
    void Clear()
      Description: Removes every category from the map, rendering it empty.
    bool Contains(string key)
      Description: Tests for the existence of a category with that name within the map.
      @key: The category name to be searched for.
      Returns: The Contains method returns True if the name is within the map, otherwise False.
    int Erase(string key)
      Description: Removes a category with the specified name from the map.
      @key: The name of the category to be erased.
      Returns: The number of categories that were erased from the map.
    CategoryNameMapIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the map.
      Returns: Returns a forward moving iterator to the map.
    bool Insert(string key, Category item)
      Description: Insert the specified category with the specified name into the map.
      @key: The name to be used for inserting the category into the map.
      @item: The category to be inserted into the map.
      Returns: Returns whether the category was inserted into the map.
    CategoryNameMapIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the map.
      Returns: Returns a backward moving iterator to the map.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CategoryNameMapIterator
Full Name: Autodesk.Revit.DB.CategoryNameMapIterator
Description: An iterator to a category name map.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CategoryNameMapIterator()
      Description: For Internal Use Only.

  PROPERTIES:
    object Current { get; }
      Description: Retrieves the category that is the current focus of the iterator.
    string Key { get; }
      Description: Retrieves the category name that is the current focus of the iterator.

  METHODS:
    bool MoveNext()
      Description: Move the iterator one item forward.
      Returns: Returns True if the iterator was successfully moved forward one item and the Current property will return a valid item. False will be returned it the iterator has reached the end of the map.
    void Reset()
      Description: Bring the iterator back to the start of the map.

--------------------------------------------------------------------------------

[CLASS] CategorySet
Full Name: Autodesk.Revit.DB.CategorySet
Description: A set that can contains Category objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CategorySet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of categories that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Category item)
      Description: Tests for the existence of a category within the set.
      @item: The category to be searched for.
      Returns: The Contains method returns True if the category is within the set, otherwise False.
    int Erase(Category item)
      Description: Removes a specified category from the set.
      @item: The category to be erased.
      Returns: The number of items that were erased from the set.
    CategorySetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Category item)
      Description: Insert the specified category into the set.
      @item: The item to be inserted into the set.
      Returns: Returns whether the item was inserted into the set.
    CategorySetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CategorySetIterator
Full Name: Autodesk.Revit.DB.CategorySetIterator
Description: An iterator to a category set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CategorySetIterator()
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

[ENUM] CategoryType
Full Name: Autodesk.Revit.DB.CategoryType
Description: The type of category.
Inherits: Enum

  Values:
    - Invalid = 0
    - Model = 1
    - Annotation = 2
    - Internal = 4
    - AnalyticalModel = 5

--------------------------------------------------------------------------------

[CLASS] Ceiling
Full Name: Autodesk.Revit.DB.Ceiling
Description: Represents a ceiling in Autodesk Revit.
Inherits: CeilingAndFloor

  PROPERTIES:
    ElementId SketchId { get; }
      Description: Returns id of the sketch.

  METHODS:
    static Ceiling Create(Document document, IList<CurveLoop> curveLoops, ElementId ceilingTypeId, ElementId levelId)
      Description: Creates a new instance of ceiling within the project.
      @document: The document in which the new ceiling is created.
      @curveLoops: An array of planar curve loops that represent the profile of the ceiling.
      @ceilingTypeId: Id of the ceiling type to be used by the new ceiling. If InvalidElementId is passed, the default type will be used.
      @levelId: Id of the level on which the ceiling is to be placed.
      Returns: If successful a new ceiling object within the project.
      Throws ArgumentException: The ElementId levelId is not a Level. -or- The ElementId ceilingTypeId does not correspond to a CeilingType. -or- The input curve loops cannot compose a valid boundary, that means: the "curveLoops" collection is empty; or some curve loops intersect with each other; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane; or input curves contain at least one helical curve. -or- Input curves build invalid sketch. -or- Failed to create curve elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot generate a sketch. -or- Failed to create new element.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static Ceiling Create(Document document, IList<CurveLoop> curveLoops, ElementId ceilingTypeId, ElementId levelId, Line slopeArrow, double slope)
      Description: Creates a new instance of ceiling within the project.
      @document: The document in which the new ceiling is created.
      @curveLoops: An array of planar curve loops that represent the profile of the ceiling.
      @ceilingTypeId: Id of the ceiling type to be used by the new ceiling. If InvalidElementId is passed, the default type will be used.
      @levelId: Id of the level on which the ceiling is to be placed.
      @slopeArrow: A line used to control the slope angle of the Ceiling. It must be horizontal.
      @slope: The slope angle.
      Returns: If successful a new ceiling object within the project.
      Throws ArgumentException: The ElementId levelId is not a Level. -or- The ElementId ceilingTypeId does not correspond to a CeilingType. -or- The input curve loops cannot compose a valid boundary, that means: the "curveLoops" collection is empty; or some curve loops intersect with each other; or each curve loop is not closed individually; or each curve loop is not planar; or each curve loop is not in a plane parallel to the horizontal(XY) plane; or input curves contain at least one helical curve. -or- The slopeArrow must be a horizontal line. -or- Input curves build invalid sketch. -or- Failed to create curve elements.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Cannot generate a sketch. -or- Failed to create new element.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    IList<Curve> GetCeilingGridLines(bool includeBoundary)
      Description: Get the geometric representation of the ceiling grid, optionally including the ceiling boundary.
      @includeBoundary: Include the boundary of the ceiling with the grid lines.
      Returns: The curves representing the ceiling grid, optionally including the ceiling boundary.

--------------------------------------------------------------------------------

[CLASS] CeilingAndFloor
Full Name: Autodesk.Revit.DB.CeilingAndFloor
Description: A base class that provides support for all ceiling and floor objects.
Inherits: HostObject

--------------------------------------------------------------------------------

[CLASS] CeilingType
Full Name: Autodesk.Revit.DB.CeilingType
Description: Represents a ceiling type in Autodesk Revit.
Inherits: HostObjAttributes

  PROPERTIES:
    ThermalProperties ThermalProperties { get; }
      Description: The calculated and settable thermal properties of the CeilingType

--------------------------------------------------------------------------------

[ENUM] CellType
Full Name: Autodesk.Revit.DB.CellType
Description: Declares the cell data type.
Inherits: Enum

  Values:
    - Text = 0
    - Graphic = 1
    - Parameter = 2
    - Inherited = 3
    - CombinedParameter = 4
    - CalculatedValue = 5
    - ParameterText = 6
    - CustomField = 7

--------------------------------------------------------------------------------

[ENUM] ChangePriority
Full Name: Autodesk.Revit.DB.ChangePriority
Description: Enum used to specify the priority of an Updater during execution.
Remarks: The enumeration values are ordered in the order in which updaters associated to each priority will be run. For example, updaters associated to priority GridsLevelsReferencePlanes will run first, while updaters associated to priority Annotations will run last.
Inherits: Enum

  Values:
    - GridsLevelsReferencePlanes = 0
    - Masses = 1
    - FloorsRoofsStructuralWalls = 2
    - Structure = 3
    - InteriorWalls = 4
    - DoorsOpeningsWindows = 5
    - MEPFixtures = 6
    - RoomsSpacesZones = 7
    - MEPCalculations = 8
    - FreeStandingComponents = 9
    - Connections = 10
    - Rebar = 11
    - MEPAccessoriesFittingsSegmentsWires = 12
    - MEPSystems = 13
    - Views = 14
    - DetailComponents = 15
    - Annotations = 16

--------------------------------------------------------------------------------

[CLASS] ChangeType
Full Name: Autodesk.Revit.DB.ChangeType
Description: A class representing a change that can be detected and tracked during Dynamic Update.
Remarks: ChangeTypes for specific changes can be obtained from the static methods available on Element.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static ChangeType ConcatenateChangeTypes(ChangeType changeType1, ChangeType changeType2)
      Description: Creates a ChangeType that is a union of the two input ChangeTypes
      @changeType1: First input ChangeType to be concatenated
      @changeType2: Second input ChangeType to be concatenated
      Returns: A new ChangeType that is a concatenation/union of the input change types
      Throws ArgumentNullException: A non-optional argument was null
    bool Contains(ChangeType changeType)
      Description: Checks whether this ChangeType contains the input ChangeType
      Returns: True if input changeType is contained by this ChangeType
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    bool IsIdentical(ChangeType changeType)
      Description: Compares if two ChangeTypes are identical
      @changeType: Input ChangeType to be compared
      Returns: True if the this ChangeType and input ChangeType are identical
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] CheckoutStatus
Full Name: Autodesk.Revit.DB.CheckoutStatus
Description: Indicates the ownership status of an element
Inherits: Enum

  Values:
    - OwnedByCurrentUser = 0
    - OwnedByOtherUser = 1
    - NotOwned = 2

--------------------------------------------------------------------------------

[CLASS] City
Full Name: Autodesk.Revit.DB.City
Description: An object that contains geographical location information for a known city.
Remarks: This object contains longitude, latitude, time zone information for a city already known by Revit. Currently Revit does not the ability to add cities to the existing list. The list of known cities can be retrieved using the Cities property on the application object.
Inherits: APIObject

  PROPERTIES:
    double Latitude { get; }
      Description: Latitude of the city
    double Longitude { get; }
      Description: Longitude of the city
    string Name { get; }
      Description: The name of the city
    double TimeZone { get; }
      Description: Time-zone in which the city resides
    string WeatherStation { get; }
      Description: An identifier for the nearest weather station

--------------------------------------------------------------------------------

[CLASS] CitySet
Full Name: Autodesk.Revit.DB.CitySet
Description: An set that contains cities.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CitySet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of cities that are in the set.

  METHODS:
    void Clear()
      Description: Removes every city from the set, rendering it empty.
    bool Contains(City item)
      Description: Tests for the existence of a city within the set.
      @item: The city to be searched for.
      Returns: The Contains method returns True if the city is within the set, otherwise False.
    int Erase(City item)
      Description: Removes a specified city from the set.
      @item: The city to be erased.
      Returns: The number of cities that were erased from the set.
    CitySetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(City item)
      Description: Insert the specified city into the set.
      @item: The city to be inserted into the set.
      Returns: Returns whether the city was inserted into the set.
    CitySetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CitySetIterator
Full Name: Autodesk.Revit.DB.CitySetIterator
Description: An iterator to a city set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CitySetIterator()
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

[CLASS] ClassificationEntries
Full Name: Autodesk.Revit.DB.ClassificationEntries
Description: A collection of ClassificationEntry objects that make up the classification table.
Inherits: KeyBasedTreeEntries

  METHODS:
    static bool LoadClassificationEntriesFromFile(string filePath, KeyBasedTreeEntriesLoadContent loadContent)
      Description: Loads the contents of a classification text file into the provided KeyBasedTreeEntriesLoadContent.
      @filePath: The full path of the existing classification file.
      @loadContent: The classification entries read from the filePath will be added to this object. A KeyBasedTreeEntriesLoadContent object will also be updated to contain status information, including information about any errors that occurred while reading the keynote entries from the specified file.
      Returns: True if reading the keynote file succeeds; False if the classification file cannot be read.
      Throws ArgumentException: filePath is an empty string. -or- The KeyBasedTreeEntries object owned by this KeyBasedTreeEntriesLoadContent object is built already. Adding more KeyBasedTreeEntries as well as repeated building, is not supported.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidPathArgumentException: The destination file name includes one or more invalid characters.

--------------------------------------------------------------------------------

[CLASS] ClassificationEntry
Full Name: Autodesk.Revit.DB.ClassificationEntry
Description: Represents an entry in the classification table.
Inherits: KeyBasedTreeEntry

  CONSTRUCTORS:
    new ClassificationEntry(string key, string parentKey, string description, int level, ElementId categoryId)
      Description: Constructs a ClassificationEntry object
      @key: The key of this ClassificationEntry.
      @parentKey: The parent key of this ClassificationEntry.
      @description: The description associated with this ClassificationEntry.
      @level: The level of this ClassficationEntry.
      @categoryId: The category id of this ClassificationEntry. The category can be invalidElementId, otherwise it must represent Revit existing category.
      Throws ArgumentException: key is an empty string. -or- The categoryId is not appropriate category id for classfication entry.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    ElementId CategoryId { get; }
      Description: The id of the category associated with this entry.
    string Description { get; }
      Description: The description associated with this entry.
    int Level { get; }
      Description: The entry level in the classification table. The expected range is between 1 and 5 inclusive.

  METHODS:
    bool HasBadCategoryId()
      Description: Checks if the category id is Revit BuiltInCategory id.
      Returns: True if the category id is not Revit BuiltInCategory id. False otherwise.
    bool HasBadLevel()
      Description: Checks if the level is an integer in range between 1 and 5 inclusive.
      Returns: True if the level is not an integer from 1 to 5 inclusive. False otherwise.
    bool HasInvalidKey()
      Description: Checks if the key matches the level and parent key.
      Returns: True if the key doesn't matach the level and parent key. False otherwise.

--------------------------------------------------------------------------------

[CLASS] ClosestPointsPairBetweenTwoCurves
Full Name: Autodesk.Revit.DB.ClosestPointsPairBetweenTwoCurves
Description: This class captures results of computation of closest points between two generic curves.
Implements: IDisposable

  CONSTRUCTORS:
    new ClosestPointsPairBetweenTwoCurves()
      Description: Obtain a new instance of ClosestPointsPairBetweenTwoCurves class.
    new ClosestPointsPairBetweenTwoCurves(ClosestPointsPairBetweenTwoCurves other)
      Description: Creates a copy of the ClosestPointsPairBetweenTwoCurves.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    double Distance { get; set; }
      Description: Distance from point on first curve to the point on second curve.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double ParameterOnFirstCurve { get; set; }
      Description: 1d raw (not normalized) parameter of the point on the first curve.
    double ParameterOnSecondCurve { get; set; }
      Description: 1d raw (not normalized) parameter of the point on the second curve.
    XYZ XYZPointOnFirstCurve { get; set; }
      Description: Point on the first curve in 3d coordinates.
    XYZ XYZPointOnSecondCurve { get; set; }
      Description: Point on the second curve in 3d coordinates.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] Color
Full Name: Autodesk.Revit.DB.Color
Description: Represents a color in Autodesk Revit.
Remarks: Colors obtained from some API methods may represent an uninitialized/invalid color. You can identify these using the IsValid property.
Inherits: APIObject

  CONSTRUCTORS:
    new Color(byte red, byte green, byte blue)
      Description: Constructor that takes the red, green and blue channels of the color.
      @red: The red channel of the color that ranges from 0 to 255.
      @green: The green channel of the color that ranges from 0 to 255.
      @blue: The blue channel of the color that ranges from 0 to 255.

  PROPERTIES:
    byte Blue { get; set; }
      Description: Get the blue channel of the color. Setting a channel is obsolete in Autodesk Revit 2013. Please create a new color instead.
    byte Green { get; set; }
      Description: Get the green channel of the color. Setting a channel is obsolete in Autodesk Revit 2013. Please create a new color instead.
    static Color InvalidColorValue { get; }
      Description: Get the invalid Color whose IntegerValue is -1.
    bool IsValid { get; }
      Description: Identifies if the color represents a valid color, or an uninitialized/invalid value.
    byte Red { get; set; }
      Description: Get the red channel of the color. Setting a channel is obsolete in Autodesk Revit 2013. Please create a new color instead.

--------------------------------------------------------------------------------

[CLASS] ColorBackgroundSettings
Full Name: Autodesk.Revit.DB.ColorBackgroundSettings
Description: Represents the rendering color background settings.
Inherits: BackgroundSettings

  PROPERTIES:
    Color Color { get; set; }
      Description: The color of the rendering background.

--------------------------------------------------------------------------------

[ENUM] ColorDepthType
Full Name: Autodesk.Revit.DB.ColorDepthType
Description: An enumerated type listing all Color Depth types of Print Setting.
Inherits: Enum

  Values:
    - BlackLine = 0
    - GrayScale = 1
    - Color = 2

--------------------------------------------------------------------------------

[CLASS] ColorFillLegend
Full Name: Autodesk.Revit.DB.ColorFillLegend
Description: Represents color fill legend.
Remarks: Color fill legend is a 2D annotation element, it can be created through XYZ) with specified category of color fill scheme, if there exists a valid color fill scheme activated for the category in the view. After a legend is created, its content and layout will keep consistent with the active color fill scheme of the view. You can adjust its position through Origin property, or manually maintain its layout through Height property andGetColumnWidths/Double}) methods.Notes:ElementId) could be used to retrieve the corresponding color fill scheme of this legend, through the Autodesk::Revit::DB::View::ColorFillCategoryId and OwnerViewId properties. Note that there could only exist one active scheme for all spatial categories (rooms, areas, and zones) in one view.Once the height and column widths are explicitly set, they will be fixed even if the contents of the legend change.To retrieve correct height and column widths, it's better to manually retrieve the geometry of legend for nonvisible views. (Because color fill legend is a view specific element.)The value of Height property does not contain the line that displays "Calculating...".
Inherits: Element

  PROPERTIES:
    ElementId ColorFillCategoryId { get; }
      Description: Returns the id of color fill category that this legend is created for.
    double Height { get; set; }
      Description: The height of the legend.
    XYZ Origin { get; set; }
      Description: The top left corner of the color fill legend.

  METHODS:
    static ColorFillLegend Create(Document document, ElementId viewId, ElementId catetoryId, XYZ origin)
      Description: Creates new instance of ColorFillLegend.
      @document: The document.
      @viewId: The id of the view to place legend in.
      @catetoryId: The id of category that color fill scheme belongs to.
      @origin: The origin point of the legend, must be on the view plane.
      Throws ArgumentException: document is not a project document. -or- There's no valid color fill scheme applied for catetoryId in viewId. -or- The origin is not on the view plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    IList<double> GetColumnWidths()
      Description: Returns array of column widths in the legend.
    void SetColumnWidths(IList<double> widths)
      Description: Sets array of column widths.
      Throws ArgumentException: Array is not valid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ColorFillScheme
Full Name: Autodesk.Revit.DB.ColorFillScheme
Description: Represents a color scheme could be used to colorfy elements in floor plan views and section views.
Remarks: A color scheme is based on element category and one of the category parameter, it contains a set of ColorFillSchemeEntry which stores parameter value, color, fill pattern and other entry data. The entry paramater values may be a range or a single value, based on the IsByRange property. Then elements with the specified category could be colored with the color and fill pattern of matching entry whose parameter value or value range matches the element parameter value.You can retrieve the entries with GetEntries, or modify entries with ColorFillSchemeEntry), ColorFillSchemeEntry), ColorFillSchemeEntry) and ColorFillSchemeEntry}).Unlike most of the other elements, the color scheme works in an "asynchronous" way in UI:If document elements change, the color scheme will not be updated immediately.If color schemes changes, the document elements will not be updated immediately too.API works slightly different with UI:GetEntries will return the entries corresponding to the latest document elements status immediately.The entries modification operation will retrieve the latest entries with GetEntries at first, and then modify those entries by request, but document elements will still not be updated immediately.To modify multiple entries, it's better to use ColorFillSchemeEntry}) but not modify them one by one with other methods for better performance.Notes:To apply a color scheme whose CategoryId property is OST_Areas to an area plan view, the AreaSchemeId property must be the same as the view if it is not used as a template.To generate a new color scheme, you have to use String) method to duplicate form an existing one.There should not exist two entries values that are the same in a color scheme. if the StorageType property is Double, then the value accuracy should be based on FormatOptions property.
Inherits: Element

  PROPERTIES:
    ElementId AreaSchemeId { get; }
      Description: Represents the id of AreaScheme of area plan views that this scheme could be applied to.
    ElementId CategoryId { get; }
      Description: Represents the element category that can be colored by this scheme.
    bool IsByRange { get; set; }
      Description: Represents if the parameter values in entries are treated as value range or not.
    bool IsLinkedFilesIncluded { get; set; }
      Description: Represent if the scheme includes entries whose parameter values are based on elements from linked files.
    ElementId ParameterDefinition { get; set; }
      Description: Represents the parameter of the elements that this scheme could be used to color.
    StorageType StorageType { get; }
      Description: Represents the type of parameter values stored in entries.
    string Title { get; set; }
      Description: Represents the title displayed in ColorFillLegend.

  METHODS:
    void AddEntry(ColorFillSchemeEntry entry)
      Description: Adds new entry to the scheme.
      Throws ArgumentException: There already exists an entry with the same value in the scheme. -or- The entry value is out of range. -or- The scheme and the entry have different parameter storage type. -or- The fill pattern id is not valid for scheme.
      Throws ArgumentNullException: A non-optional argument was null
    EntryAndSchemeConsistency AreEntriesConsistentWithScheme(IList<ColorFillSchemeEntry> entries)
      Description: Checks whether the entries can be set to the scheme or not.
      @entries: The entries to check.
      Returns: The state of the entries and scheme consistency.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanDefineByRange()
      Description: Checks whether the scheme entries can be explained by range.
      Returns: Returns true ifthe scheme entries can be explained by range, false otherwise.
    bool CanRemoveEntry(ColorFillSchemeEntry entry)
      Description: Checks whether entry can be removed from the scheme.
      @entry: The entry to remove.
      Returns: Returns true if entry can be removed from the scheme, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanUpdateEntry(ColorFillSchemeEntry entry)
      Description: Checks whether entry exists in the scheme and not the same as input one.
      @entry: The entry to be updated.
      Returns: Returns true if entry exist in scheme and not the same as input one, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId Duplicate(string name)
      Description: Generates a copy of current scheme.
      @name: The desired name of copied scheme.
      Returns: The id of copied scheme.
      Throws ArgumentException: The name is not valid for new generated scheme.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ColorFillSchemeEntry> GetEntries()
      Description: Retrieves copies of all entries.
    FormatOptions GetFormatOptions()
      Description: Returns the FormatOptions of the scheme.
    IList<ElementId> GetSupportedParameterIds()
      Description: Retrieves collection of all parameters supported by the scheme.
    EntryAndSchemeConsistency IsEntryConsistentWithScheme(ColorFillSchemeEntry entry)
      Description: Checks whether an entry can be added to the scheme or not.
      @entry: The entry to check.
      Returns: The state of entry and scheme consistency.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidParameterDefinitionId(ElementId parameterId)
      Description: Checks whether the input parameter id can be applied to the scheme.
      Returns: Returns true if the input parameter id can be set to this scheme, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidSchemeName(string name)
      Description: Checks whether the name is valid for new generated scheme.
      Returns: Returns true if the name is valid for new generated scheme, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveEntry(ColorFillSchemeEntry entry)
      Description: Removes an entry whose parameter value is the same as the input from the scheme
      @entry: The entry to remove.
      Throws ArgumentException: The entry cannot be removed from the scheme.
      Throws ArgumentNullException: A non-optional argument was null
    void SetEntries(IList<ColorFillSchemeEntry> entries)
      Description: Update scheme entries in batch mode.
      @entries: Collection of new entries.
      Throws ArgumentException: There exists entries whose values are duplicated in the input entries. -or- There exists at lease one entry whose value is invalid for the scheme in the input entries. -or- There exists at least one entry in the input entries whose storage type is different with the scheme. -or- There exists at least one entry in the input entries whose fill pattern is invalid for color fill scheme. -or- There exists some inconsistent in the input entries.
      Throws ArgumentNullException: A non-optional argument was null
    void SetFormatOptions(FormatOptions formatOptions)
      Description: Sets the FormatOptions of the scheme.
      Throws ArgumentNullException: A non-optional argument was null
    void SortEntries()
      Description: Sorts the scheme entries ascending.
    void UpdateEntry(ColorFillSchemeEntry entry)
      Description: Updates the scheme entry with the same parameter value as the input entry.
      @entry: The entry to be updated.
      Throws ArgumentException: The entry does not exist or the same as input one. -or- The entry does not exist or all the updating fields are the same as existing one.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ColorFillSchemeEntry
Full Name: Autodesk.Revit.DB.ColorFillSchemeEntry
Description: Represents an entry of a Autodesk::Revit::DB::ColorFillScheme.
Implements: IDisposable

  CONSTRUCTORS:
    new ColorFillSchemeEntry(StorageType storageType)
      Description: Creates new ColorFillSchemeEntry.
      @storageType: The type of data that could be stored into this entry.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    string Caption { get; set; }
      Description: The text displayed in Autodesk::Revit::DB::ColorFillLegend for this entry.
    Color Color { get; set; }
      Description: The filling color of this entry.
    ElementId FillPatternId { get; set; }
      Description: The id of fill pattern element of this entry.
    bool IsInUse { get; }
      Description: Represents if there exists at least one element colored based on this entry in the document.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVisible { get; set; }
      Description: Represents if the element colored based on this entry is visible in views.
    StorageType StorageType { get; }
      Description: The storage type of the value stored in this entry.

  METHODS:
    bool CanSetValue(ElementId value)
      Description: Checks whether StorageType of entry is ElementId.
      @value: New ElementId value.
      Returns: True if StorageType of the entry is ElementId and the entry, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanSetValue(double value)
      Description: Checks whether StorageType of entry is Double and the value is no less than 0.0.
      @value: New Double value.
      Returns: True if StorageType of the entry is Double and the value is finite, false otherwise.
    bool CanSetValue(int value)
      Description: Checks whether StorageType of entry is Integer.
      @value: New Integer value.
      Returns: True if StorageType of the entry is Integer, false otherwise.
    void Dispose()
    double GetDoubleValue()
      Description: Gets the Double value stored within the entry.
      Returns: The Double value contained in the entry.
    ElementId GetElementIdValue()
      Description: Gets the ElementId value stored within the entry.
      Returns: The ElementId contained in the entry.
    int GetIntegerValue()
      Description: Gets the Integer value stored within the entry.
      Returns: The Integer value contained in the entry.
    string GetStringValue()
      Description: Gets the String value stored within the entry.
      Returns: The String contained in the entry.
    void SetDoubleValue(double value)
      Description: Sets new Double value of entry.
      Throws InvalidOperationException: The entry has different storage type with Double, or value is not finite.
    void SetElementIdValue(ElementId value)
      Description: Sets new ElementId value of entry.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The entry has different storage type with ElementId.
    void SetIntegerValue(int value)
      Description: Sets new Integer value of entry.
      Throws InvalidOperationException: The entry has different storage type with Integer.
    void SetStringValue(string value)
      Description: Sets new String value of entry.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The entry has different storage type with String, or the value is empty, or contains forbidden characters.

--------------------------------------------------------------------------------

[CLASS] ColorOptions
Full Name: Autodesk.Revit.DB.ColorOptions
Description: A class providing access to color settings which affect the colors applied to specific views.
Remarks: ColorOptions are managed and stored along with other global application options and thus impact the application as a whole.
Implements: IDisposable

  PROPERTIES:
    Color AlertColor { get; set; }
      Description: The color of the current canvas theme used to highlight elements when a special alert is required.
    Color BackgroundColor { get; set; }
      Description: The background color of the current canvas theme applied to views.
    Color CalculatingColor { get; set; }
      Description: The color of the current canvas theme used to render elements when some aspect of their properties is currently being recalculated.
    Color EditingColor { get; set; }
      Description: The color of the current canvas theme used to render elements when editing.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color PreselectionColor { get; set; }
      Description: The color of the current canvas theme used to highlight candidates for selection before they are selected.
    Color SelectionColor { get; set; }
      Description: The color of the current canvas theme used to highlight selected elements.
    bool SelectionSemitransparent { get; set; }
      Description: Indicates whether or not selections will be shown in a semi-transparent manner in current canvas theme.

  METHODS:
    void Dispose()
    static ColorOptions GetColorOptions()
      Description: Returns the current Revit instance's ColorOptions.
      Returns: The ColorOptions for the current Revit instance.

--------------------------------------------------------------------------------

[CLASS] ColorWithTransparency
Full Name: Autodesk.Revit.DB.ColorWithTransparency
Description: Color with transparency
Implements: IDisposable

  CONSTRUCTORS:
    new ColorWithTransparency(uint red, uint green, uint blue, uint transparency)
      Description: color
      @red: red
      @green: green
      @blue: blue
      @transparency: transparency
      Throws ArgumentOutOfRangeException: The value is not valid. The valid range is 0 to 255.
    new ColorWithTransparency()
      Description: color

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    uint GetBlue()
      Description: get blue
      Returns: blue
    Color GetColor()
      Description: get color
      Returns: color
    uint GetGreen()
      Description: get green
      Returns: green
    uint GetRed()
      Description: get red
      Returns: red
    uint GetTransparency()
      Description: get transparency
      Returns: transparency
    void SetBlue(uint blue)
      Description: set blue
      @blue: blue
      Throws ArgumentOutOfRangeException: The value is not valid. The valid range is 0 to 255.
    void SetColor(Color color)
      Description: set color
      @color: color
      Throws ArgumentNullException: A non-optional argument was null
    void SetGreen(uint green)
      Description: set green
      @green: green
      Throws ArgumentOutOfRangeException: The value is not valid. The valid range is 0 to 255.
    void SetRed(uint red)
      Description: set red
      @red: red
      Throws ArgumentOutOfRangeException: The value is not valid. The valid range is 0 to 255.
    void SetTransparency(uint transparency)
      Description: set transparency
      @transparency: transparency
      Throws ArgumentOutOfRangeException: The value is not valid. The valid range is 0 to 255.

--------------------------------------------------------------------------------

[CLASS] ColumnAttachment
Full Name: Autodesk.Revit.DB.ColumnAttachment
Description: An object representing the attachment of the top or bottom of a column to some target: a floor, roof, ceiling, beam, or brace.
Remarks: Call IsValidColumn() and IsValidTarget() to verify that specific elements support column attachments. A column has at most one top attachment and one bottom attachment.
Implements: IDisposable

  PROPERTIES:
    double AttachOffset { get; set; }
      Description: The offset of the column attachment.
    int BaseOrTop { get; }
      Description: Identifies if this ColumnAttachment is at the base or top of the column.
    ColumnAttachmentCutStyle CutStyle { get; }
      Description: Identifies whether the column, or the attached element should be cut (or if neither should be cut).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ColumnAttachmentJustification Justification { get; }
      Description: Identifies the type of justification to apply to this ColumnAttachment.
    ElementId TargetId { get; }
      Description: The id of the element that is attached to the column and is described by this ColumnAttachment.

  METHODS:
    static void AddColumnAttachment(Document doc, FamilyInstance column, Element target, int baseOrTop, ColumnAttachmentCutStyle cutColumnStyle, ColumnAttachmentJustification justification, double attachOffset)
      Description: Attaches the column to the target. If an attachment already exists with the same "baseOrTop" value, no attachment is made.
      @doc: The document containing column and target.
      @column: A column.
      @target: A target element.
      @baseOrTop: 0 to attach the column base, 1 to attach the column top.
      @cutColumnStyle: Control the handling of columns that intersect their targets.
      @justification: Control the column extent in cases where the target is not a uniform height.
      @attachOffset: An additional offset for the bottom. If positive, the column base or top will be higher than the attachment point; if negative, lower.
      Throws ArgumentException: column is not a column that supports ColumnAttachments. -or- target is not a valid target for ColumnAttachments. -or- column already has an attachment at its base or top as specified by baseOrTop. -or- column already has an attachment to target.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: baseOrTop must be either 0 or 1. -or- The given value for attachOffset must be no more than 30000 feet in absolute value. -or- A value passed for an enumeration argument is not a member of that enumeration
    void Dispose()
    static ColumnAttachment GetColumnAttachment(FamilyInstance column, ElementId targetId)
      Description: Look up a column attachment by specifying the target id.
      @column: A column.
      @targetId: Id of a target element.
      Returns: The column attachment attaching the column to the target, or if there is no such attachment.
      Throws ArgumentNullException: A non-optional argument was null
    static ColumnAttachment GetColumnAttachment(FamilyInstance column, int baseOrTop)
      Description: Look up a column attachment. There is at most one attachment on the base and one on the top.
      @column: A column.
      @baseOrTop: 0 for base, 1 for top.
      Returns: The column attachment for the base or top of the column, or if that end of the column is unattached.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: baseOrTop must be either 0 or 1.
    static bool IsValidColumn(FamilyInstance familyInstance)
      Description: Says whether a FamilyInstance supports column attachments.
      @familyInstance: A column.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidTarget(bool forSlantedColumn, Element target)
      Description: Says whether the element can be used as a target for a new attachment.
      @forSlantedColumn: If true, check whether the target is valid for a slanted column; if false, check whether the target is valid for a vertical column.
      @target: A proposed target element for a column attachment.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidTarget(FamilyInstance column, Element target)
      Description: Says whether the element can be used as a target for a new attachment.
      @column: The column to attach. If the target is a beam or brace, the column will be checked to see if it is slanted. Otherwise, this argument is not used and may be omitted.
      @target: A proposed target element for a column attachment.
      Throws ArgumentNullException: A non-optional argument was null
    static void RemoveColumnAttachment(FamilyInstance column, ElementId targetId)
      Description: Removes any attachment of the column to the specified target.
      @column: A column.
      @targetId: Id of a target element.
      Throws ArgumentNullException: A non-optional argument was null
    static void RemoveColumnAttachment(FamilyInstance column, int baseOrTop)
      Description: Removes an attachment at the top or base of a column, if there is one.
      @column: A column.
      @baseOrTop: 0 for base, 1 for top.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: baseOrTop must be either 0 or 1.
    void SetJustification(ColumnAttachmentJustification justification)
      Description: Setter of ColumnAttachmentJustification
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] ColumnAttachmentCutStyle
Full Name: Autodesk.Revit.DB.ColumnAttachmentCutStyle
Description: Control the handling of columns that intersect their targets.
Inherits: Enum

  Values:
    - CutColumn = 0
    - CutTarget = 1
    - None = 2

--------------------------------------------------------------------------------

[ENUM] ColumnAttachmentJustification
Full Name: Autodesk.Revit.DB.ColumnAttachmentJustification
Description: Control the column extent in cases where the target is not a uniform height.
Inherits: Enum

  Values:
    - Minimum = 0
    - Midpoint = 1
    - Maximum = 2
    - Tangent = 3

--------------------------------------------------------------------------------

[CLASS] CombinableElement
Full Name: Autodesk.Revit.DB.CombinableElement
Description: An element that can be added to a geometry combination.
Inherits: Element

  PROPERTIES:
    GeomCombinationSet Combinations { get; }
      Description: The geometry combinations that this element belongs to.

--------------------------------------------------------------------------------

[CLASS] CombinableElementArray
Full Name: Autodesk.Revit.DB.CombinableElementArray
Description: An array that contains CombinableElement objects.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CombinableElementArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    CombinableElement Item { get; set; }
    int Size { get; }
      Description: Returns the number of CombinableElements that are in the array.

  METHODS:
    void Append(CombinableElement item)
      Description: Add the element to the end of the array.
      @item: The CombinableElement to be added.
    void Clear()
      Description: Removes every CombinableElement from the array, rendering it empty.
    CombinableElementArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(CombinableElement item, int index)
      Description: Insert the specified element into the array.
      @item: The CombinableElement to be inserted into the array.
      @index: The CombinableElement will be inserted before this index.
    CombinableElementArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CombinableElementArrayIterator
Full Name: Autodesk.Revit.DB.CombinableElementArrayIterator
Description: An iterator to an CombinableElement array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CombinableElementArrayIterator()
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

[CLASS] ComponentRepeater
Full Name: Autodesk.Revit.DB.ComponentRepeater
Description: An element that contains and manages a set of repeated components.
Remarks: Component repeaters can be used to replicate (repeat) elements hosted on repeating references. The result of the repeating operation is a collection of slots. Each slot contains one repeated component. The ComponentRepeater class provides the repeating functionality and access to the slots. Each repeating reference is capable of hosting one point of an adaptive component. An initial pattern can be created by populating one or more repeating references with such points. Component repeaters can then be used to replicate the pattern to fill the rest of the repeating references in the particular repeating reference source. The repeating references in repeating reference source are arranged in one or two dimensional arrays, allowing for different kinds of repeating: One dimensional source allows for repeating along a path.Two dimensional source allows for repeating across a grid.It is also possible to host a point on a zero dimensional reference (a point). This point will be shared by all slots. A zero dimensional source allows for repeating around a single point. It should not be used alone, but together with at least one other repeating reference source (typically one dimensional.) The point hosted on the zero dimensional source serves as a central point around which other points can be repeated on their respective repeating reference sources. Multiple adaptive components may be hosted on one repeating reference source, and different points of one adaptive component may be hosted on different repeating reference sources, effectively allowing different points of an adaptive component to be repeated using different patterns. Following is a typical component repeater creation workflow: Get the default repeating reference source from a point element, divided path or divided surface. (See ElementId) and ElementId).)Query the bounds of the repeating reference source to find a range of valid coordinates. (See DimensionCount and GetBounds.)Create one or more instances of adaptive families that will be repeated.Host the individual points of an adaptive component on one or more repeating references. (See RepeaterCoordinates).)Repeat the set of adaptive components using the RepeatElements() method. Component repeaters can only be used in Massing families (the conceptual design environment).
Inherits: Element
Implements: IEnumerable<ComponentRepeaterSlot>, IEnumerable

  PROPERTIES:
    ElementId DefaultFamilyType { get; set; }
      Description: The default family type for the component repeater.
    int DimensionCount { get; }
      Description: The dimension count of the component repeater.

  METHODS:
    static bool CanElementBeRepeated(Document ADoc, ElementId elementId)
      Description: Determines whether an element can be repeated using the RepeatElements method.
      @ADoc: The document containing the element.
      @elementId: The element to be tested.
      Returns: True if the element can be repeated.
      Throws ArgumentNullException: A non-optional argument was null
    IEnumerator<ComponentRepeaterSlot> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    bool IsTypeValidForRepeater(ElementId typeId)
      Description: Determines whether given family type can be used as the default type for the repeater.
      @typeId: The element id of the type.
      Returns: True if the family type can be used as the default type for the repeater.
      Throws ArgumentNullException: A non-optional argument was null
    static ISet<ElementId> RemoveRepeaters(Document document, ISet<ElementId> elementIds)
      Description: Removes component repeaters from the document, but leaves the individual repeated components in their respective locations and hosted on their original hosts.
      @document: The document that contains the component repeaters to remove.
      @elementIds: The set of component repeaters that should be removed.
      Returns: A collection of components that were previously repeated by the component repeater.
      Throws ArgumentException: The given element id set is empty. -or- One or more elements in elementIds do not exist in the document. -or- Not all given elements are component repeaters.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static IList<ComponentRepeater> RepeatElements(Document document, ICollection<ElementId> elementIds)
      Description: Repeats a set of adaptive component hosted on one or more repeating references.
      @document: The document that contains the elements.
      @elementIds: The set of adaptive components used as an input pattern for the repeating operation.
      Returns: One or more component repeater objects representing the result pattern of the repeating operation.
      Throws ArgumentException: The document does not allow creation of a component repeater. -or- The given element id set is empty. -or- One or more elements in elementIds do not exist in the document. -or- Not all given elements can be repeated. All elements must be adaptive family instances, have no shape handles, and have at least one placement point hosted on a 1D or 2D repeating reference. The remaining placement points must be either unhosted or hosted on another repeating reference.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.

--------------------------------------------------------------------------------

[CLASS] ComponentRepeaterIterator
Full Name: Autodesk.Revit.DB.ComponentRepeaterIterator
Description: A slot iterator for ComponentRepeater.
Implements: IEnumerator<ComponentRepeaterSlot>, IDisposable, IEnumerator

  PROPERTIES:
    ComponentRepeaterSlot Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ComponentRepeaterSlot GetCurrent()
      Description: Returns the current repeater slot.
      Returns: The current slot.
      Throws InvalidOperationException: There is no current item in the iterator.
    bool IsDone()
      Description: Identifies if the iteration has completed.
      Returns: True if the iteration has no more items. False if there are more items to be iterated.
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] ComponentRepeaterSlot
Full Name: Autodesk.Revit.DB.ComponentRepeaterSlot
Description: Represents a slot that holds one repeated component in a component repeater.
Remarks: Each slot can be in one of the following states: Empty.Occupied by an instance of the default family of the repeater that contains the slot.Occupied by an instance of another family. Initially, every occupied slot holds an instance of the default family of the repeater, based on the original element that was repeated.
Inherits: Element

  PROPERTIES:
    ElementId FamilyType { get; set; }
      Description: The id of the family type of the component in the slot, or invalid id if the slot is empty.
    bool IsDefault { get; }
      Description: A flag indicating whether the slot currently holds an instance of the default family type of the component repeater.
    bool IsEmpty { get; }
      Description: A flag indicating whether the slot is currently empty.

  METHODS:
    bool IsTypeValidForSlot(ElementId typeId)
      Description: Determines whether instance of given family type can be used in the component repeater slot.
      @typeId: The element id of the type.
      Returns: True if the family type can be used in the component repeater slot.
      Throws ArgumentNullException: A non-optional argument was null
    void MakeDefault()
      Description: Populates the slot with an instance of the default family type of the component repeater.
    void MakeEmpty()
      Description: Makes the slot empty by removing the instance currently held by the slot.

--------------------------------------------------------------------------------

[ENUM] ComponentRotation
Full Name: Autodesk.Revit.DB.ComponentRotation
Description: ComponentRotation property of DividedSurface. See DividedSurface.
Inherits: Enum

  Values:
    - Angle0 = 0
    - Angle90 = 90
    - Angle180 = 180
    - Angle270 = 270

--------------------------------------------------------------------------------

[CLASS] CompoundStructure
Full Name: Autodesk.Revit.DB.CompoundStructure
Description: Describes the internal structure of a wall, floor, roof or ceiling.
Remarks: A compound structure consists a collection of ordered layers, proceeding from exterior to interior for a wall, or from top to bottom for a floor, roof or ceiling. The properties of these layers determine the thickness, material, and function of the overall structure of the associated wall, floor, roof or ceiling. Layers can be accessed via the GetLayers method and completely replaced using SetLayers. Layers can also be accessed and modified individually using the "layer index", which is a value from in the range [0, LayerCount) identifying the layer in the structure.A structure supports the concept of "core layers" and "shell layers". There are two layer indices which identify where the boundary between core and shell layers occur in the list of layers. The boundaries between shell and core layers are identifiable using GetFirstCoreLayerIndex, GetLastCoreLayerIndex, ShellLayerType) or ShellLayerType). The core layer boundary can be changed with Int32).Compound structures may be vertically compound. If IsVerticallyCompound is false, the CompoundStructure describes a series of parallel layers, each with specified width, function, material and other properties. If IsVerticallyCompound is true (which should apply only for CompoundStructures assigned to walls) then horizontal sections at different elevations may have different layered structures. In this case, the structure describes a vertical section via a rectangle which is divided into polygonal regions whose sides are all vertical or horizontal segments. A map associates each of these regions with the index of a layer in the CompoundStructure which determines the properties of that region.
Implements: IDisposable

  PROPERTIES:
    double CutoffHeight { get; set; }
      Description: Horizontal segments below or at the cutoff height have their distance to the wall bottom fixed, those above have their distance to the wall top fixed.
    EndCapCondition EndCap { get; set; }
      Description: Indicates the end cap condition defining which shell layers will participate in end wrapping.
    bool HasStructuralDeck { get; }
      Description: Checks if the compound structure has a structural deck.
    bool IsEmpty { get; }
      Description: Checks whether this CompoundStructure is empty.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool IsVerticallyCompound { get; }
      Description: Identifies if this CompoundStructure represents a layout that is more complicated than a simple set of parallel layers.
    int LayerCount { get; }
      Description: Returns the number of layers contained in this CompoundStructure.
    double MinimumSampleHeight { get; }
      Description: The minimum sample height determined by the current sample height and the horizontal segments.
    OpeningWrappingCondition OpeningWrapping { get; set; }
      Description: Indicates the opening wrapping condition defining which shell layers of a wall, in plan view, wrap at inserts and openings.
    double SampleHeight { get; set; }
      Description: The sample height is the presumed height of the wall to which the data in this CompoundStructure is applied.
    int StructuralMaterialIndex { get; set; }
      Description: Indicates the layer whose material defines the structural properties of the type for the purposes of analysis.
    int VariableLayerIndex { get; set; }
      Description: Indicates the index of the layer which is designated as variable.

  METHODS:
    void AddWallSweep(WallSweepInfo wallSweepInfo)
      Description: Adds a new wall sweep or reveal to the compound structure.
      @wallSweepInfo: The wall sweep info to create a wall sweep.
      Throws ArgumentException: The wall sweep info does not represent a fixed wall sweep. Only fixed wall sweeps may be assigned to vertical compound structures. -or- The WallSweepInfo has an invalid id for a fixed wall sweep.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    void AssociateRegionWithLayer(int regionId, int layerIdx)
      Description: Associates a region with a layer.
      @regionId: The id of a region.
      @layerIdx: The index of a layer in this CompoundStructure.
      Throws ArgumentException: It is not a valid region id.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    bool CanLayerBeStructuralMaterial(int layerIndex)
      Description: Identifies if the input layer can be designated as defining the structural material for this structure.
      @layerIndex: Index of a layer in the CompoundStructure.
      Returns: True if the input layer may be used to define the structural material and false otherwise.
    bool CanLayerBeVariable(int variableLayerIndex)
      Description: Identifies if the input layer can be designated as a variable thickness layer.
      @variableLayerIndex: Index of a layer in the CompoundStructure.
      Returns: True if the input layer may be a variable thickness layer and false otherwise.
    bool CanLayerWidthBeNonZero(int layerIdx)
      Description: Identifies if changing the width of an existing layer from zero to a positive value will create a rectangular region.
      @layerIdx: The index of a CompoundStructureLayer.
    bool CanSplitAndMergeRegionsBeUsed()
      Description: Checks whether split and merge regions operations can be used for this compound structure.
      Returns: True if split and merge regions operation can be used for this compound structure, false otherwise.
    bool ChangeRegionWidth(int regionId, double newWidth)
      Description: Adjust the width of an existing simple region.
      @regionId: The id of a region.
      @newWidth: The desired width of the specified region.
      Returns: True if newWidth is zero and the region was deleted.
      Throws ArgumentException: It is not a valid region id. -or- It is not a simple region.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    void ClearWallSweeps(WallSweepType wallSweepType)
      Description: Removes all sweeps or reveals from the compound structure.
      @wallSweepType: The type of a wall sweep.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    static CompoundStructure CreateSimpleCompoundStructure(IList<CompoundStructureLayer> layers)
      Description: Creates a non-vertically compound structure comprised of parallel layers.
      @layers: An array which describes the parallel layers of this compound structure.
      Returns: A newly created compound structure.
      Throws ArgumentException: One or more layers is not valid.
      Throws ArgumentNullException: A non-optional argument was null
    static CompoundStructure CreateSingleLayerCompoundStructure(double sampleHeight, MaterialFunctionAssignment layerFunction, double width, ElementId materialId)
      Description: Creates a vertically compound CompoundStructure with one layer.
      @sampleHeight: The sample height of this vertically compound structure.
      @layerFunction: The function of the single layer.
      @width: The width of the single layer.
      @materialId: The ElementId of the material for the single layer.
      Returns: The newly created compound structure.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for sampleHeight must be greater than 0 and no more than 30000 feet. -or- The given value for width must be greater than 0 and no more than 30000 feet. -or- A value passed for an enumeration argument is not a member of that enumeration
    static CompoundStructure CreateSingleLayerCompoundStructure(MaterialFunctionAssignment layerFunction, double width, ElementId materialId)
      Description: Creates a CompoundStructure containing a single layer.
      @layerFunction: The function of the single layer.
      @width: The width of the single layer.
      @materialId: The ElementId of the material for the single layer.
      Returns: The newly created compound structure.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for width must be greater than 0 and no more than 30000 feet. -or- A value passed for an enumeration argument is not a member of that enumeration
    bool DeleteLayer(int layerIdx)
      Description: Deletes the specified layer from this CompoundStructure.
      @layerIdx: The layer index is zero based. It counts from the exterior of wall and from the top of roofs, floors and ceilings.
      Returns: True if the layer was successfully deleted, and false otherwise.
      Throws ArgumentException: The layer cannot be deleted.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    void Dispose()
    int FindEnclosingRegionAndSegments(UV gridUV, RectangularGridSegmentOrientation splitDirection, out int segmentId1, out int segmentId2)
      Description: Given a pair of grid coordinates, and a direction for splitting, returns the enclosing region and the two segments intersected by a line through the grid point.
      @gridUV: Coordinates of a point in the rectangular grid of this compound structure.
      @splitDirection: Specifies the direction of the split.
      @segmentId1: The id of a segment in the boundary of the containing region which is split by a line through gridUV in the specified direction.
      @segmentId2: The id of a segment in the boundary of the containing region which is split by a line through gridUV in the specified direction.
      Returns: Returns the id of the enclosing region, and -1 if no region encloses the point.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    IList<int> GetAdjacentRegions(int segmentId)
      Description: Gets the ids of region bound to a specified segment.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: The ids of the regions that are bounded by the specified segment.
      Throws ArgumentException: The segment id is invalid.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    int GetCoreBoundaryLayerIndex(ShellLayerType shellLayerType)
      Description: Returns the index of the layer just below the core boundary.
      @shellLayerType: If ShellLayerType.Exterior return the index on the exterior side (or top side for a roof, floor, or ceiling type). If ShellLayerType.Interior return the index on the interior side (or bottom side for a roof, floor, or ceiling type).
      Returns: The index of the layer.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    StructDeckEmbeddingType GetDeckEmbeddingType(int layerIdx)
      Description: Retrieves the deck embedding type used for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The embedding type of the structural deck associated to the specified layer. Invalid if it is not a structural deck.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    ElementId GetDeckProfileId(int layerIdx)
      Description: Retrieves the profile loop used for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The element id of a FamilySymbol which contains a profile loop used by a structural deck associated to the specified layer, or invalidElementId if isStructuralDeck(layerIdx) is false.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    IList<int> GetExtendableRegionIds(bool top)
      Description: Gets the extendable region ids for the compound structure.
      @top: If true, retrieve ids of regions which are extendable at the top, otherwise retrieve the ids of regions which are extendable at the bottom.
      Returns: An array of region ids which are marked extendable.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    int GetFirstCoreLayerIndex()
      Description: Gets the index of the first core layer.
      Returns: The index of the first core layer.
    int GetLastCoreLayerIndex()
      Description: Gets the index of the last core layer.
      Returns: The index of the last core layer.
    int GetLayerAssociatedToRegion(int regionId)
      Description: Gets the layer associated to a particular region.
      @regionId: The id of a region.
      Returns: The index of a layer in this CompoundStructure.
      Throws ArgumentsInconsistentException: For a non-vertically compound structure, implicitly each layer is associated to its corresponding simple region.
    MaterialFunctionAssignment GetLayerFunction(int layerIdx)
      Description: Retrieves the function of the specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The function of the layer.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    IList<CompoundStructureLayer> GetLayers()
      Description: A copy of the layers which define this compound structure.
      Returns: The layers, returned in order (Exterior to Interior for walls, top to bottom for roofs, floors or ceilings). The index of each layer in this array can be used in other CompoundStructure methods accepting a layer index.
    double GetLayerWidth(int layerIdx)
      Description: Retrieves the width of a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The width of the specified layer.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    ElementId GetMaterialId(int layerIdx)
      Description: Retrieves the material element id of a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: The material element id.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    static double GetMinimumLayerThickness()
      Description: Get the minimum allowable layer thickness.
      Returns: The minimum allowable width of a layer in feet.
    int GetNumberOfShellLayers(ShellLayerType shellLayerType)
      Description: Retrieves the number of interior or exterior shell layers.
      @shellLayerType: If ShellLayerType.Exterior return the number of exterior shell layers (or top shell layers for a roof, floor, or ceiling type). If ShellLayerType.Interior return the number of interior shell layers (or bottom shell layers for a roof, floor, or ceiling type).
      Returns: The number of shell layers in the interior or exterior shell, as specified by shellLayerType.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    double GetOffsetForLocationLine(WallLocationLine wallLocationLine)
      Description: Returns the offset from the center of the compound structure to the given location line value.
      @wallLocationLine: The alignment type of the wall's location line.
      Returns: The offset.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation is valid only vertically homogeneous compound structures.
    int GetPreviousNonZeroLayerIndex(int thisIdx)
      Description: Returns the index of the nearest non-zero width layer before this layer.
      @thisIdx: The layer from which to look for a non-zero width layer.
      Returns: The index of the layer found.
    BoundingBoxUV GetRegionEnvelope(int regionId)
      Description: Gets the envelope that a specified region spans.
      @regionId: The id of the region.
      Returns: The envelope of the region.
      Throws ArgumentException: It is not a valid region id.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    IList<int> GetRegionIds()
      Description: Gets the region ids of this compound structure.
      Returns: The ids of the regions defining this CompoundStructure.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    IList<int> GetRegionsAlongLevel(double height)
      Description: Returns the ids of the regions encountered as the vertically compound structure is traversed at a constant height above the bottom a wall to which this structure is applied.
      @height: Distance from the bottom of the wall.
      Returns: The ids of the regions intersected by the specified line.
      Throws ArgumentException: The height is outside valid range. It should be in the range of [0, SampleHeight].
    IList<int> GetRegionsAssociatedToLayer(int layerIdx)
      Description: Gets the set of region ids associated to a particular layer.
      @layerIdx: The index of a layer in this CompoundStructure.
      Returns: An array of region ids which are associated to the specified layer.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    double GetSegmentCoordinate(int segmentId)
      Description: Gets the coordinate of a segment.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: The local coordinates of the specified segment.
      Throws ArgumentException: The segment id is invalid.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    void GetSegmentEndPoints(int segmentId, int regionId, out UV end1, out UV end2)
      Description: Gets the end points of a segment.
      @segmentId: The segment id.
      @regionId: The region id.
      @end1: One end point.
      @end2: The other end point.
      Throws ArgumentException: The segment id is invalid.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    IList<int> GetSegmentIds()
      Description: Gets the segment ids of this compound structure.
      Returns: The ids of the segments which form the boundary of the regions of this CompoundStructure.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    RectangularGridSegmentOrientation GetSegmentOrientation(int segmentId)
      Description: Gets the orientation of a segment.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: The orientation of the specified segment.
      Throws ArgumentException: The segment id is invalid.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    CompoundStructure GetSimpleCompoundStructure(double wallHeight, double distAboveBase)
      Description: Takes a horizontal slice through a sample wall to which this CompoundStructure is applied and returns a simple compound structure which describes that slice, i.e. a series of parallel layers.
      @wallHeight: The height of the wall.
      @distAboveBase: The distance from the base of the wall at which to take the section. If distAboveBase < 0, then internally distAboveBase = 0 is used. If distAboveBase > wallHeight, then internally distAboveBase = wallHeight is used.
      Returns: A simple CompoundStructure representing a series of parallel layers.
    IList<WallSweepInfo> GetWallSweepsInfo(WallSweepType wallSweepType)
      Description: Obtains a list of the intrinsic wall sweeps or reveals in this CompoundStructure.
      @wallSweepType: Whether to obtain wall sweeps or reveals.
      Returns: An array which describes the intrinsic wall sweeps or reveals.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    double GetWidth()
      Description: The width implied by this compound structure.
      Returns: The width of a host object with this compound structure.
    double GetWidth(int regionId)
      Description: Computes the width of the envelope (2d bounding box) of the specified region.
      @regionId: The id of a region in this vertically compound structure.
      Returns: The width of the envelope (2d bounding box) of the region.
      Throws ArgumentException: It is not a valid region id.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    bool IsCoreLayer(int layerIdx)
      Description: Checks if the specified layer is a core layer.
      @layerIdx: The index of a layer in this CompoundStructure.
      Returns: Returns true if the layer is within the core layer boundary, false if it is in the interior or exterior shell layers.
    bool IsEqual(CompoundStructure otherStructure)
      Description: Checks whether this CompoundStructure is the same as another CompoundStructure.
      @otherStructure: A CompoundStructure.
      Returns: True if the two CompoundStructures are the same, and false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsLayerValid(int layerIdx, CompoundStructureLayer layer)
      Description: Verifies that the data in this layer is internally consistent.
      @layerIdx: The index of the layer in the compound structure to be set.
      @layer: The layer to be set.
      Returns: True if the layer is internally consistent, false if the layer is not internally consistent.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsRectangularRegion(int regionId)
      Description: Determines whether the specified region is rectangular.
      @regionId: The id of a region.
      Returns: True if the specified region is a rectangle, false otherwise.
      Throws ArgumentException: It is not a valid region id.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    bool IsSimpleRegion(int regionId)
      Description: Determines whether the region is a simple region in this CompoundStructure.
      @regionId: The id of a region in this vertically compound structure.
      Returns: True if the region is simple, false otherwise.
      Throws ArgumentException: It is not a valid region id.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    bool IsStructuralDeck(int layerIdx)
      Description: Determines whether a specified layer is a structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      Returns: True if specified layer is a structural deck, and false otherwise.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    bool IsValid(Document doc, out IDictionary<int, CompoundStructureError> errMap, out IDictionary<int, int> twoLayerErrorsMap)
      Description: Checks for errors or inconsistencies in the data in this CompoundStructure.
      @doc: Access to the document in which the CompoundStructure will be used.
      @errMap: This map will associate each problematic layer index to a value in CompoundStructureError. General structure errors are reported as associated to layer index -1.
      @twoLayerErrorsMap: The map is associated to a check run only for vertically Compound Structures. Essentially the Compound Structure is sliced at representative heights. It looks at the region from exterior to interior, and requires that the assigned layer indices do not decrease. If they do, an entry is generated for this map. The first entry is the last valid layer index encountered. The second entry is a region id whose assigned layer index is too small: it should be at least as large as the first entry.
      Returns: True if the compound structure is valid for the document, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidRegionId(int regionId)
      Description: Determines whether the specified integer is actually the id of a region in this CompoundStructure.
      @regionId: The id of a region in this vertically compound structure.
      Returns: True if the region is valid, false otherwise.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    bool IsValidSampleHeight(double height)
      Description: Is the specified height a valid sample height for this compound structure?
    bool IsValidSegmentId(int segmentId)
      Description: Determines whether the specified integer is actually the id of a segment in this CompoundStructure.
      @segmentId: The id of a segment in this CompoundStructure.
      Returns: True if the specified segment is valid, false otherwise.
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    bool IsVerticallyHomogeneous()
      Description: Indicates whether this CompoundStructure represents a single set of parallel layers.
      Returns: True if this CompoundStructure represents a series of parallel layers that stretch from bottom to top, false otherwise.
    int MergeRegionsAdjacentToSegment(int segmentId, int layerIdxForMergedRegion)
      Description: Merges the two regions which share the specified segment.
      @segmentId: The id of a segment in the underlying grid.
      @layerIdxForMergedRegion: The index of the layer to which the resulting region will be associated.
      Returns: The id of the resulting region. If -1 is returned, then the operation would have produced an invalid region and was not performed.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
      Throws InvalidOperationException: Split and merge regions operations can be used only for vertically compound structures without variable thickness layers. -or- The segment is not shared by adjacent regions.
    bool ParticipatesInWrapping(int layerIdx)
      Description: Identifies if a layer is included in wrapping at inserts and ends.
      @layerIdx: The index of the layer.
      Returns: If true, then the layer participates in wrapping at inserts and openings. If false, the layer will not participate in wrapping.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    void RemoveWallSweep(WallSweepType wallSweepType, int id)
      Description: Removes a single sweep or reveal from the compound structure.
      @wallSweepType: The type of a wall sweep.
      @id: The id of the sweep or reveal to remove.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    void SetDeckEmbeddingType(int layerIdx, StructDeckEmbeddingType embedType)
      Description: Sets the deck embedding type to use for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      @embedType: The embedding type to be used by the specified layer if it is a structural deck.
      Throws ArgumentException: The layer is not a structural deck.
      Throws ArgumentOutOfRangeException: The layer index is out of range. -or- A value passed for an enumeration argument is not a member of that enumeration
    void SetDeckProfileId(int layerIdx, ElementId profileId)
      Description: Sets the profile loop to use for the specified structural deck.
      @layerIdx: Index of a layer in the CompoundStructure.
      @profileId: The element id of a FamilySymbol which contains a profile loop to be used by the specified layer if it is a structural deck.
      Throws ArgumentException: The layer is not a structural deck.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    void SetExtendableRegionIds(bool top, IList<int> regionIds)
      Description: Sets the extendable region ids for the compound structure.
      @top: If true, set ids of regions which are extendable at the top, otherwise set the ids of regions which are extendable at the bottom.
      @regionIds: The ids of regions which will be extendable.
      Throws ArgumentException: The region ids are not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This operation is valid only for vertically compound structures.
    void SetLayer(int layerIdx, CompoundStructureLayer layer)
      Description: Sets a single layer for this CompoundStructure.
      @layerIdx: The index of a layer. This should range from 0 to the number of layers - 1.
      @layer: The layer to be set.
      Throws ArgumentException: The layer is not valid for this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The layer index is out of range.
      Throws InvalidOperationException: This operation is valid only for non-vertically compound structures.
    void SetLayerFunction(int layerIdx, MaterialFunctionAssignment function)
      Description: Sets the function of the specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      @function: The function of the layer.
      Throws ArgumentOutOfRangeException: The layer index is out of range. -or- A value passed for an enumeration argument is not a member of that enumeration
    void SetLayers(IList<CompoundStructureLayer> layers)
      Description: Completely resets this CompoundStructure and applies a new set of layers.
      @layers: The layers to be set.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLayerWidth(int layerIdx, double width)
      Description: Sets the width of a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      @width: The new width of the specified layer.
      Throws ArgumentException: The width of the layer is not valid.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
      Throws InvalidOperationException: If the region of the layer is not a simple region.
    void SetMaterialId(int layerIdx, ElementId materialId)
      Description: Sets a material element for a specified layer.
      @layerIdx: Index of a layer in the CompoundStructure.
      @materialId: The ElementId of a Material element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    void SetNumberOfShellLayers(ShellLayerType shellLayerType, int numLayers)
      Description: Sets the number of interior or exterior shell layers.
      @shellLayerType: If ShellLayerType.Exterior set the number of exterior shell layers (or top shell layers for a roof, floor, or ceiling type). If ShellLayerType.Interior set the number of interior shell layers (or bottom shell layers for a roof, floor, or ceiling type).
      @numLayers: The number of layers to be in the specified shell.
      Throws ArgumentOutOfRangeException: Number of shell layers is negative. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws ArgumentsInconsistentException: Too many shell layers: there must be at least one core layer.
    void SetParticipatesInWrapping(int layerIdx, bool participatesInWrapping)
      Description: Assigns if a layer is included in wrapping at inserts and ends.
      @layerIdx: The index of the layer.
      @participatesInWrapping: True if the specified layer will participate in wrapping at inserts and ends, false otherwise.
      Throws ArgumentException: The wrapping of the layer is not valid.
      Throws ArgumentOutOfRangeException: The layer index is out of range.
    int SplitRegion(UV gridUV, RectangularGridSegmentOrientation splitDirection)
      Description: Splits the region which contains the specified grid point by a line with the specified direction.
      @gridUV: Coordinates of a point in the rectangular grid of this compound structure.
      @splitDirection: Specifies the direction of the split.
      Returns: The id of the region created by this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Split and merge regions operations can be used only for vertically compound structures without variable thickness layers.
    int SplitRegion(UV gridUV, RectangularGridSegmentOrientation splitDirection, out int newSegmentId)
      Description: Splits the region which contains the specified grid point by a line with the specified direction.
      @gridUV: Coordinates of a point in the rectangular grid of this compound structure.
      @splitDirection: Specifies the direction of the split.
      @newSegmentId: The id of segment that bounds both the original region and the new region.
      Returns: The id of the region created by this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Split and merge regions operations can be used only for vertically compound structures without variable thickness layers.

--------------------------------------------------------------------------------

[ENUM] CompoundStructureError
Full Name: Autodesk.Revit.DB.CompoundStructureError
Description: When CompoundStructure::isValid() returns false, it uses these values to indicate precise nature of defect.
Remarks: 'LayerTooThin' enum value was removed in 2016
Inherits: Enum

  Values:
    - BadShellOrder = 0
    - CoreTooThin = 1
    - MembraneTooThick = 3
    - NonmembraneTooThin = 4
    - BadShellsStructure = 5
    - ThinOuterLayer = 6
    - VerticalUnusedLayer = 7
    - VerticalWrongOrderLayer = 8
    - VerticalWrongOrderCoreExterior = 9
    - VerticalWrongOrderCoreInterior = 10
    - VerticalWrongOrderMembrane = 11
    - DeckCantBoundAbove = 12
    - DeckCantBoundBelow = 13
    - VarThickLayerCantBeZero = 14
    - InvalidMaterialId = 15
    - ExtensibleRegionsNotContiguousAlongTop = 16
    - ExtensibleRegionsNotContiguousAlongBottom = 17
    - InvalidProfileId = 18

--------------------------------------------------------------------------------

[CLASS] CompoundStructureLayer
Full Name: Autodesk.Revit.DB.CompoundStructureLayer
Description: Describes a single layer in a CompoundStructure.
Implements: IDisposable

  CONSTRUCTORS:
    new CompoundStructureLayer(double width, MaterialFunctionAssignment function, ElementId materialId)
      Description: Creates a default compound structure layer based on the given width, function and material element id.
      @width: The width of the layer.
      @function: The function of the layer.
      @materialId: The material element id of the layer.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new CompoundStructureLayer(CompoundStructureLayer cs)
      Description: Creates a copy of a compound structure layer.
      @cs: The compound structure to copy.
      Throws ArgumentNullException: A non-optional argument was null
    new CompoundStructureLayer()
      Description: Creates a compound structure layer using default settings.

  PROPERTIES:
    StructDeckEmbeddingType DeckEmbeddingType { get; set; }
      Description: Embedding type for structural deck - only for a layer whose function is StructuralDeck.
    ElementId DeckProfileId { get; set; }
      Description: The ElementId of the structural deck profile - only for a layer whose function is StructuralDeck.
    MaterialFunctionAssignment Function { get; set; }
      Description: The function of the layer.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool LayerCapFlag { get; set; }
      Description: Identifies if the layer participates in wrapping at end caps and/or inserts.
    int LayerId { get; }
      Description: The id of the layer - note that this may be different from the index in the array of layers in a CompoundStructure.
    ElementId MaterialId { get; set; }
      Description: Id of the material assigned to this layer.
    double Width { get; set; }
      Description: Width of the layer.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ConfigurationReloadInfo
Full Name: Autodesk.Revit.DB.ConfigurationReloadInfo
Description: This object contains information returned by a reload of the fabrication configuration.
Implements: IDisposable

  CONSTRUCTORS:
    new ConfigurationReloadInfo()
      Description: Constructor.

  PROPERTIES:
    int Disconnects { get; }
      Description: The number of disconnections caused by the reload.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int OutOfDatePartCount { get; }
      Description: The number of fabrication part instances that had newer versions and were out of date.
    bool ProfileNotAvailable { get; }
      Description: The current profile is not available in the disk configuration.

  METHODS:
    void Dispose()
    ConnectionValidationInfo GetConnectivityValidation()
      Description: Returns information about the post-reload connectivity validation.
      Returns: Information about the post-reload connectivity validation.
    ISet<ElementId> GetCustomDataChangedElements()
      Description: Gets a list of ElementIds of fabrication parts that had custom data updated during the reload.
      Returns: A list identifying changed elements.
    ReloadSwapOutInfo GetOutOfDatePartStatus(int index)
      Description: Access reload information for out of date part.
      @index: The index of the information about the part being reloaded. Must be between 0 and OutOfDatePartCount.
      Returns: Information about the part being reloaded.
      Throws ArgumentException: The index is out of range.

--------------------------------------------------------------------------------

[CLASS] ConicalFace
Full Name: Autodesk.Revit.DB.ConicalFace
Description: A conical face of a 3d solid or open shell.
Remarks: For details on the parameterization, refer to the documentation for ConicalSurface.
Inherits: Face

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the surface.
    double HalfAngle { get; }
      Description: Half angle of the surface.
    XYZ Origin { get; }
      Description: Origin of the surface.
    XYZ Radius { get; }

--------------------------------------------------------------------------------

[CLASS] ConicalSurface
Full Name: Autodesk.Revit.DB.ConicalSurface
Description: A Conical Surface.
Remarks: The parametric equation of the cone is S(u, v) = center + v*[sin(halfAngle)(cos(u)*xVec + sin(u)*yVec) + cos(halfAngle)*zVec]. Only the branch of the cone with v >= 0 should be used.
Inherits: Surface

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the cone. This is the Z axis of the local coordinate system associated with this cone.
    double HalfAngle { get; }
      Description: Cone angle.
    XYZ Origin { get; }
      Description: Apex of the cone. This is the origin of the local coordinate system associated with this cone.
    XYZ XDir { get; }
      Description: X axis of the local coordinate system associated with this cone.
    XYZ YDir { get; }
      Description: X axis of the local coordinate system associated with this cone.

  METHODS:
    static ConicalSurface Create(Frame frameOfReference, double halfAngle)
      Description: Creates a conical surface defined by a local reference frame and a half angle.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the cone. Frame.Origin is a point on the cylinder's axis.Frame.BasisZ points along the axis, while Frame.BasisX and Frame.BasisY are orthogonal to the axis.The frame may be either left-handed or right-handed (see Frame.IsRightHanded). Note that the "handedness" of the frame does not, by itself, determine the surface's orientation.
      @halfAngle: Cone angle. Must be not 0, lesser than PI/2 and greater than -PI/2.
      Returns: The created ConicalSurface.
      Throws ArgumentException: This Frame object may not be used as a local frame of reference. -or- The supplied value must be not 0, lesser than PI/2 and greater than -PI/2.
      Throws ArgumentNullException: A non-optional argument was null
    Frame GetFrameOfReference()
      Description: Returns frame of reference associated with this ConicalSurface.
      Returns: Frame of reference associated with this ConicalSurface.
    static bool IsValidConeAngle(double halfAngle)
      Description: Checks whether the input value lies is not 0, greater than -PI/2 and lesser than PI/2.
      @halfAngle: Cone half-angle parameter.
      Returns: True if input is not 0, lesser than PI/2 and greater than -PI/2, false otherwise.

--------------------------------------------------------------------------------

[ENUM] ConnectionResolution
Full Name: Autodesk.Revit.DB.ConnectionResolution
Description: An enumerated type listing all the possible resolutions for connectivity validation.
Inherits: Enum

  Values:
    - Disconnected = 0

--------------------------------------------------------------------------------

[CLASS] ConnectionValidationInfo
Full Name: Autodesk.Revit.DB.ConnectionValidationInfo
Description: This object contains information about fabrication connection validations.
Implements: IDisposable

  CONSTRUCTORS:
    new ConnectionValidationInfo()
      Description: Constructor.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ConnectionValidationWarning GetWarning(int index)
      Description: Access specific warning number of warnings generated by reload.
      Throws ArgumentException: Invalid index.
    bool IsValidWarningIndex(int index)
      Description: Validate warning index.
    int ManyWarnings()
      Description: Returns number of warnings generated by reload.

--------------------------------------------------------------------------------

[CLASS] ConnectionValidationWarning
Full Name: Autodesk.Revit.DB.ConnectionValidationWarning
Description: Contains information about a specific connection validation problem.
Implements: IDisposable

  CONSTRUCTORS:
    new ConnectionValidationWarning(ConnectionResolution resolution, ConnectionWarning reason, ElementId part1, ElementId part2)
      Description: Constructor.
      @resolution: Resolution type.
      @reason: Warning reason.
      @part1: First element Id.
      @part2: Second element Id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ConnectionWarning Reason { get; }
      Description: Enumeration for reason of warning.
    ConnectionResolution Resolution { get; }
      Description: Enumeration for resolution that was applied.

  METHODS:
    void Dispose()
    ISet<ElementId> GetParts()
      Description: Get ElementIds of affected parts.

--------------------------------------------------------------------------------

[ENUM] ConnectionWarning
Full Name: Autodesk.Revit.DB.ConnectionWarning
Description: An enumerated type listing all the reasons for connectivity failure.
Inherits: Enum

  Values:
    - Unknown = 0
    - Alignment = 1
    - Size = 2
    - Shape = 3
    - Connectivity = 4

--------------------------------------------------------------------------------

[CLASS] Connector
Full Name: Autodesk.Revit.DB.Connector
Description: A connector in an Autodesk Revit MEP project document.
Remarks: This connector is an item that is a part of another element (duct, pipe, fitting, or equipment etc.). This connector does not represent the connector element that can be created inside a family; for that element, refer to ConnectorElement.
Implements: IConnector, IDisposable

  PROPERTIES:
    bool AllowsSlopeAdjustments { get; }
      Description: Indicates if the connector allows the slope adjustment.
    ConnectorSet AllRefs { get; }
      Description: All references of the connector.
    double Angle { get; set; }
      Description: The angle of the Connector.
    DuctFlowConfigurationType AssignedDuctFlowConfiguration { get; }
      Description: The assigned duct flow configuration of the connector.
    DuctLossMethodType AssignedDuctLossMethod { get; }
      Description: The duct loss method of the connector.
    double AssignedFixtureUnits { get; set; }
      Description: The assigned fixture units of the connector.
    double AssignedFlow { get; set; }
      Description: The assigned flow of the connector.
    FlowDirectionType AssignedFlowDirection { get; }
      Description: The assigned flow direction of the connector.
    double AssignedFlowFactor { get; set; }
      Description: The assigned flow factor of this connector.
    double AssignedKCoefficient { get; set; }
      Description: The assigned kCoefficient of the connector.
    double AssignedLossCoefficient { get; set; }
      Description: The assigned loss coefficient of the connector.
    PipeFlowConfigurationType AssignedPipeFlowConfiguration { get; }
      Description: The pipe flow configuration type of the connector.
    PipeLossMethodType AssignedPipeLossMethod { get; }
      Description: The pipe loss method of the connector.
    double AssignedPressureDrop { get; set; }
      Description: The assigned pressure drop of the connector.
    double Coefficient { get; }
      Description: The coefficient of the connector.
    ConnectorManager ConnectorManager { get; }
      Description: The connector manager of the connector.
    ConnectorType ConnectorType { get; }
      Description: The connector type of the connector.
    Transform CoordinateSystem { get; }
      Description: The coordinate system of the connector.
    double Demand { get; }
      Description: The demand of the connector.
    string Description { get; }
      Description: The description.
    FlowDirectionType Direction { get; }
      Description: The direction of the connector.
    Domain Domain { get; }
      Description: The domain of the connector.
    DuctSystemType DuctSystemType { get; }
      Description: The duct system type of the connector.
    ElectricalSystemType ElectricalSystemType { get; }
      Description: The electrical system type of the connector.
    double EngagementLength { get; }
      Description: Connector engagement length. When applicable, it represents the inset distance to the end of the fabrication part from the connection point. Otherwise it returns zero.
    double Flow { get; }
      Description: The flow of the connector.
    double GasketLength { get; }
      Description: Connector gasket length. When applicable, it represents the distance from the end of the fabrication part to the center of the gasket. Otherwise it returns zero.
    double Height { get; set; }
      Description: The height of the connector.
    int Id { get; }
      Description: A unique identifier to identify this connector.
    bool IsConnected { get; }
      Description: Identifies if the connector is physically connected to a connector on another element.
    bool IsMovable { get; }
      Description: whether the connector can be moved.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    MEPSystem MEPSystem { get; }
      Description: The system of the connector belong to.
    XYZ Origin { get; set; }
      Description: The location of the connector.
    Element Owner { get; }
      Description: The host of the connector.
    PipeSystemType PipeSystemType { get; }
      Description: The pipe system type of the connector.
    double PressureDrop { get; }
      Description: The pressure drop of the connector.
    double Radius { get; set; }
      Description: The radius of the connector.
    ConnectorProfileType Shape { get; }
      Description: The shape of the connector.
    bool Utility { get; }
      Description: Indicates if the connector is a utility connector.
    double VelocityPressure { get; }
      Description: The velocity pressure of the connector.
    double Width { get; set; }
      Description: The width of the connector.

  METHODS:
    void ConnectTo(Connector connector)
      Description: Make connection between two connectors.
      @connector: Indicate the connector will be connected to.
      Throws ArgumentNullException: Thrown when argument is .
      Throws ArgumentException: Argument is invalid.
      Throws InvalidOperationException: Thrown when two connectors with different domain types. Thrown when these two connectors fail to connect each other. Thrown when connection already exists.
    void DisconnectFrom(Connector connector)
      Description: Remove connection between two connectors.
      @connector: Indicate the connector, connection will be removed from.
      Throws ArgumentNullException: Thrown when argument is .
      Throws ArgumentException: Argument is invalid.
      Throws InvalidOperationException: Thrown when no connection between these two connector. Thrown on failure to remove the connection between these two connectors.
    void Dispose()
    FabricationConnectorInfo GetFabricationConnectorInfo()
      Description: Gets fabrication connectivity information.
      Returns: Returns if there is no fabrication connector information associated.
    MEPConnectorInfo GetMEPConnectorInfo()
      Description: Gets MEP connector information.
      Returns: Returns if there is no MEP connector information associated.
    bool IsConnectedTo(Connector connector)
      Description: Identifies if the connector is connected to the specified connector.
      Throws ArgumentNullException: Thrown when the argument is .

--------------------------------------------------------------------------------

[ENUM] ConnectorDomainType
Full Name: Autodesk.Revit.DB.ConnectorDomainType
Description: Type of connector domain.
Inherits: Enum

  Values:
    - Undefined = 0
    - Hvac = 1
    - Electrical = 2
    - Piping = 3
    - CableTrayConduit = 4
    - StructuralAnalytical = 5

--------------------------------------------------------------------------------

[CLASS] ConnectorElement
Full Name: Autodesk.Revit.DB.ConnectorElement
Description: A base class that provides support for all connector elements occurring in families.
Inherits: Element
Implements: IConnector

  PROPERTIES:
    Transform CoordinateSystem { get; }
      Description: The coordinate system of the connector.
    XYZ Direction { get; }
      Description: Gets the direction of the connector element.
    Domain Domain { get; }
      Description: The domain of the connector.
    double Height { get; }
      Description: The height of the connector.
    bool IsPrimary { get; }
      Description: Identifies if this is the primary connector in the family.
    XYZ Origin { get; }
      Description: The location of the connector in family document.
    double Radius { get; }
      Description: The radius of the connector.
    ConnectorProfileType Shape { get; }
      Description: The shape of the connector.
    MEPSystemClassification SystemClassification { get; set; }
      Description: The system classification of the connector.
    double Width { get; }
      Description: The width of the connector.

  METHODS:
    void AssignAsPrimary()
      Description: Assign a connector as a primary connector.
      Throws InvalidOperationException: Thrown when fail to assign this connector as primary.
    void ChangeHostReference(Reference planarFace, Edge edge)
      Description: Changes the connector host reference to a new planar face and a new edge loop.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the new connector location on the planar face.
      Throws ArgumentException: The face is not a planar face. -or- The edge is not on the planar face.
      Throws ArgumentNullException: A non-optional argument was null
    void ChangeHostReference(Reference planarFace)
      Description: Changes the connector host reference to a new planar face.
      @planarFace: The planar face to place the connector on.
      Throws ArgumentException: The face is not a planar face.
      Throws ArgumentNullException: A non-optional argument was null
    static ConnectorElement CreateCableTrayConnector(Document document, Reference planarFace, Edge edge)
      Description: Create a new cable tray ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The cable tray ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document. -or- Thrown when the edge does not belong to the face.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateCableTrayConnector(Document document, Reference planarFace)
      Description: Create a new cable tray ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      Returns: The cable tray ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateConduitConnector(Document document, Reference planarFace, Edge edge)
      Description: Create a new conduit ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The conduit ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document. -or- Thrown when the edge does not belong to the face.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateConduitConnector(Document document, Reference planarFace)
      Description: Create a new conduit ConnectorElement.
      @document: The document to add the connector to.
      @planarFace: The planar face to place the connector on.
      Returns: The conduit ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateDuctConnector(Document document, DuctSystemType ductSystemType, ConnectorProfileType profileShape, Reference planarFace, Edge edge)
      Description: Create a new duct ConnectorElement.
      @document: The document to add the connector to.
      @ductSystemType: The DuctSystemType of the connector.
      @profileShape: The profile shape of the duct.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The duct ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document. -or- Thrown when the edge does not belong to the face.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateDuctConnector(Document document, DuctSystemType ductSystemType, ConnectorProfileType profileShape, Reference planarFace)
      Description: Create a new duct ConnectorElement.
      @document: The document to add the connector to.
      @ductSystemType: The DuctSystemType of the connector.
      @profileShape: The profile shape of the duct.
      @planarFace: The planar face to place the connector on.
      Returns: The duct ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateElectricalConnector(Document document, ElectricalSystemType electricalSystemType, Reference planarFace, Edge edge)
      Description: Create a new electrical ConnectorElement.
      @document: The document to add the connector to.
      @electricalSystemType: The ElectricalSystemTYpe of the connector.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The electrical ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document. -or- Thrown when the edge does not belong to the face.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreateElectricalConnector(Document document, ElectricalSystemType electricalSystemType, Reference planarFace)
      Description: Create a new electrical ConnectorElement.
      @document: The document to add the connector to.
      @electricalSystemType: The ElectricalSystemTYpe of the connector.
      @planarFace: The planar face to place the connector on.
      Returns: The electrical ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreatePipeConnector(Document document, PipeSystemType pipeSystemType, Reference planarFace, Edge edge)
      Description: Create a new pipe ConnectorElement with a face and an edge.
      @document: The document to add the connector to.
      @pipeSystemType: The PipeSystemType of the connector.
      @planarFace: The planar face to place the connector on.
      @edge: One of the edges in the edge loop that defines the connector location on the planar face.
      Returns: The pipe ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document. -or- Thrown when the edge does not belong to the face.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    static ConnectorElement CreatePipeConnector(Document document, PipeSystemType pipeSystemType, Reference planarFace)
      Description: Create a new pipe ConnectorElement.
      @document: The document to add the connector to.
      @pipeSystemType: The PipeSystemType of the connector.
      @planarFace: The planar face to place the connector on.
      Returns: The pipe ConnectorElement.
      Throws ArgumentException: The reference is not a planar face. -or- document is not a family document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Connector creation is not allowed in this family.
    void FlipDirection()
      Description: Reverses the direction of the connector element.
    ConnectorElement GetLinkedConnectorElement()
      Description: Get the linked connector element.
      Returns: The linked connector element. If , the connector has no link.
    bool IsSystemClassificationValid(MEPSystemClassification systemClassification)
      Description: Checks that the MEPSystemType is valid for the domain of connector.
      @systemClassification: The MEPSystemType to be validated.
      Returns: True if the MEPSystemType is valid for the domain of the connector, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetLinkedConnectorElement(ConnectorElement otherConnector)
      Description: Set the linked connector element.
      @otherConnector: The connector to link to.
      Throws ArgumentException: The connector being linked to is a different domain than that of the calling connector. -or- The connector being linked to is the same as the calling connector.
      Throws InvalidOperationException: This connector type does not support linked connectors.

--------------------------------------------------------------------------------

[ENUM] ConnectorGenderType
Full Name: Autodesk.Revit.DB.ConnectorGenderType
Description: Connector gender type enum
Inherits: Enum

  Values:
    - Undefined = 0
    - Male = 1
    - Female = 2

--------------------------------------------------------------------------------

[ENUM] ConnectorJointType
Full Name: Autodesk.Revit.DB.ConnectorJointType
Description: Connector joint type enum
Inherits: Enum

  Values:
    - Undefined = 0
    - Flanged = 1
    - Welded = 2
    - Threaded = 3
    - Grooved = 4
    - Glued = 5
    - Soldered = 6

--------------------------------------------------------------------------------

[CLASS] ConnectorManager
Full Name: Autodesk.Revit.DB.ConnectorManager
Description: Provides access to the Connector Manager
Implements: IDisposable

  PROPERTIES:
    ConnectorSet Connectors { get; }
      Description: Return all the Connectors of the Connector Manager.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Element Owner { get; }
      Description: This property is used to retrieve the owner of the Connector Manager.
    ConnectorSet UnusedConnectors { get; }
      Description: Return all the unused Connectors of the Connector Manager.

  METHODS:
    void Dispose()
    Connector Lookup(int index)
      Description: Lookup the connector using the unique index value that identify this connector.
      @index: The unique index value.
      Returns: Returns the connector or null if a connector for the provided unique index value doesn't exist.

--------------------------------------------------------------------------------

[ENUM] ConnectorProfileType
Full Name: Autodesk.Revit.DB.ConnectorProfileType
Description: An enumerated type listing all connector profile types
Inherits: Enum

  Values:
    - Round = 0
    - Rectangular = 1
    - Oval = 2
    - Invalid = -1

--------------------------------------------------------------------------------

[CLASS] ConnectorSet
Full Name: Autodesk.Revit.DB.ConnectorSet
Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ConnectorSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(Connector item)
    int Erase(Connector item)
    ConnectorSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(Connector item)
    ConnectorSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ConnectorSetIterator
Full Name: Autodesk.Revit.DB.ConnectorSetIterator
Description: An iterator to a set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ConnectorSetIterator()
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

[ENUM] ConnectorType
Full Name: Autodesk.Revit.DB.ConnectorType
Description: An enumerated type listing all connector types for a connection
Inherits: Enum

  Values:
    - Invalid = 0
    - End = 1
    - Curve = 2
    - Logical = 4
    - Reference = 8
    - Surface = 16
    - EndSurface = 17
    - Physical = 19
    - NonEnd = 30
    - MasterSurface = 32
    - MasterSurface = 32
    - Family = 49
    - NodeReference = 64
    - BlankEnd = 128
    - AnyEnd = 129
    - Super = 256
    - AllModes = 16777215

--------------------------------------------------------------------------------

[CLASS] Construction
Full Name: Autodesk.Revit.DB.Construction
Description: Construction definition for Project Information.
Remarks: This is used to define the information in Constructions.xml.

  PROPERTIES:
    string Id { get; }
      Description: Get the id of the Construction.
    string Name { get; }
      Description: Get the name of the Construction.

--------------------------------------------------------------------------------

[CLASS] ContentNode
Full Name: Autodesk.Revit.DB.ContentNode
Description: This class represents a generic content node in a model-exporting process.
Remarks: Members of this class implement properties and methods common to all content classes, such as RPC and Light nodes. Attributes of a content note can be accessed via an Asset object.
Inherits: RenderNode

  METHODS:
    Asset GetAsset()
      Description: Returns an an instance of an Asset object, which contains definitions of the content node.
    Transform GetTransform()
      Description: A transformation matrix associated with the node.

--------------------------------------------------------------------------------

[CLASS] ContourSetting
Full Name: Autodesk.Revit.DB.ContourSetting
Description: Contour setting object that handles the contour information used to draw contours on elements.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    ContourSettingItem AddContourRange(double start, double stop, double step, ElementId subcategoryId)
      Description: Add a set of contours as a contour setting item to the current contour setting.
      @start: The contour range start elevation.
      @stop: The contour range stop elevation. Should be greater than start elevation.
      @step: The increment elevation of the contour range. Should be greater than zero.
      @subcategoryId: The contour line style subcategory id.
      Returns: The newly added contour setting item.
      Throws ArgumentException: The given value for start is not finite -or- The given value for stop is not finite -or- The given value for step is not finite -or- The input subcategory id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The input contour spacing information is not valid.
    ContourSettingItem AddSingleContour(double elevation, ElementId subcategoryId)
      Description: Add a single contour as a contour setting item to the current contour setting.
      @elevation: The contour elevation.
      @subcategoryId: The contour line style subcategory id.
      Returns: The newly added contour setting item.
      Throws ArgumentException: The given value for elevation is not finite
      Throws ArgumentNullException: A non-optional argument was null
    void DisableItem(ContourSettingItem item)
      Description: Disable a contour setting item of the current contour setting so that the item will not be used to draw contours.
      @item: The contour setting item to be disabled.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    void EnableItem(ContourSettingItem item)
      Description: Enable a contour setting item of the current contour setting so that the item will be used to draw contours.
      @item: The contour setting item to be enabled.
      Throws ArgumentNullException: A non-optional argument was null
    IList<ContourSettingItem> GetContourSettingItems()
      Description: Get all contour setting items.
      Returns: An array of contour setting items.
    int GetItemIndex(ContourSettingItem item)
      Description: Get the index of a contour setting item of the current contour setting
      @item: The contour setting item.
      Returns: The index of the input contour setting item. -1 if the item is not found.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsItemEnabled(ContourSettingItem item)
      Description: Check if a ContourSettingItem is enabled
      @item: The contour setting item.
      Returns: True if the item is enabled, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveItem(ContourSettingItem item)
      Description: Remove a contour setting item from the current contour setting.
      @item: The contour setting item to be removed.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ContourSettingItem
Full Name: Autodesk.Revit.DB.ContourSettingItem
Description: Contour setting item that stores the information of a single contour or a set of contours.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double Start { get; }
      Description: The contour range start elevation.
    double Step { get; }
      Description: The increment elevation of the contour range.
    double Stop { get; }
      Description: The contour range stop elevation.
    ElementId SubCategoryId { get; }
      Description: The contour line style subcategory id.
    ContourSettingItemType Type { get; }
      Description: The contour setting item type.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ContourSettingItemType
Full Name: Autodesk.Revit.DB.ContourSettingItemType
Description: The type of a ContourSettingItem
Inherits: Enum

  Values:
    - Single = 0
    - UnboundedRange = 1
    - BoundedRange = 2

--------------------------------------------------------------------------------

[CLASS] Control
Full Name: Autodesk.Revit.DB.Control
Description: A control in Autodesk Revit family document.
Remarks: The object represents a variety of different shapes of controls in family document. The different shapes of controls can handle the family instance in different ways. A vertical/horizontal arrow control rotates the instance by 180 degrees.A double vertical arrow control mirrors the instance geometry vertically.A double horizontal arrow control mirrors the instance geometry horizontally.
Inherits: Element

  PROPERTIES:
    XYZ Origin { get; }
      Description: The control origin.
    ControlShape Shape { get; }
      Description: The control shape.
    View View { get; }
      Description: The view.

--------------------------------------------------------------------------------

[ENUM] ControlShape
Full Name: Autodesk.Revit.DB.ControlShape
Description: An enumerated type listing four shapes of control that Autodesk Revit supports.
Inherits: Enum

  Values:
    - VerticalArrow = 0
    - HorizontalArrow = 1
    - DoubleVerticalArrow = 2
    - DoubleHorizontalArrow = 3

--------------------------------------------------------------------------------

[ENUM] CoordinatePlaneVisibility
Full Name: Autodesk.Revit.DB.CoordinatePlaneVisibility
Description: Visibility settings for ReferencePoint element's coordinate reference planes.
Inherits: Enum

  Values:
    - Never = 0
    - WhenSelected = 1
    - Always = 2

--------------------------------------------------------------------------------

[CLASS] CopyPasteOptions
Full Name: Autodesk.Revit.DB.CopyPasteOptions
Description: Settings to control the behavior of a copy-paste operation.
Implements: IDisposable

  CONSTRUCTORS:
    new CopyPasteOptions()
      Description: Creates a new instance of a CopyPasteOptions object.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    IDuplicateTypeNamesHandler GetDuplicateTypeNamesHandler()
      Description: Returns current duplicate type names handler or if none is set.
    void SetDuplicateTypeNamesHandler(IDuplicateTypeNamesHandler handler)
      Description: Sets a custom duplicate type names handler. If this value is not set, the default handler is used. By default, Revit displays a modal dialog with options to either copy new types only, or cancel the operation.
      @handler: The duplicate type names handler.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] CurtainCell
Full Name: Autodesk.Revit.DB.CurtainCell
Description: Represents a CurtainCell within Autodesk Revit.
Inherits: APIObject

  PROPERTIES:
    CurveArrArray CurveLoops { get; }
      Description: The cell boundaries on the reference face. The boundaries can have more than one CurveLoop. Each item in the returned array represents a CurveLoop containing 3 or more than 3 edges.
    CurveArrArray PlanarizedCurveLoops { get; }
      Description: The planarized curve loops for cell boundaries. The boundaries can have more than one CurveLoop. Each item in the returned array represents a CurveLoop containing 3 or more than 3 edges.

--------------------------------------------------------------------------------

[CLASS] CurtainGrid
Full Name: Autodesk.Revit.DB.CurtainGrid
Description: Represents a curtain grid element within Autodesk Revit.
Remarks: This element is obtained from a curtain wall, curtain system, or curtain roof. A curtain wall has only one curtain grid, while a curtain system or curtain roof may have several curtain grids.
Inherits: APIObject

  PROPERTIES:
    double Grid1Angle { get; set; }
      Description: The angle for the U grid line pattern of the curtain grid.
    CurtainGridAlignType Grid1Justification { get; set; }
      Description: The justification for the U grid line pattern of the curtain grid.
    double Grid1Offset { get; set; }
      Description: The offset for the U grid line pattern of the curtain grid.
    double Grid2Angle { get; set; }
      Description: The angle for V grid line pattern of the curtain grid.
    CurtainGridAlignType Grid2Justification { get; set; }
      Description: The justification for the V grid line pattern of the curtain grid.
    double Grid2Offset { get; set; }
      Description: The offset for V grid line pattern of the curtain grid.
    int NumPanels { get; }
      Description: The number of panels.
    int NumULines { get; }
      Description: Get the number of grid lines in the U direction.
    int NumVLines { get; }
      Description: Get the number of grid lines in the V direction.

  METHODS:
    CurtainGridLine AddGridLine(bool isUGridLine, XYZ position, bool oneSegmentOnly)
      Description: Add a grid line to the curtain grid.
      @isUGridLine: If true, a U-direction grid line will be added. Otherwise, a V-direction grid line will be added.
      @position: The position of the grid line.
      @oneSegmentOnly: If it is true, only one segment is added. Otherwise, all segments will be added for the grid line.
      Returns: The created grid line is returned if the operation is successful. Otherwise, is returned.
      Throws InvalidOperationException: Thrown if the position for the grid line is out of range.
    Element ChangePanelType(Element panel, ElementType newSymbol)
      Description: Change the type of a curtain panel.
      @panel: The panel to be changed, it can be a type of Panel or Wall.
      @newSymbol: The new symbol, it may be of PanelType or WallType when the panel is hosted in a curtain wall. The new symbol can only be of type PanelType if the Panel is hosted in a curtain system.
      Returns: If operation succeeds, the modified panel element is returned.
      Throws ArgumentException: Thrown if the input symbol can't be used for the panel.
      Throws InvalidOperationException: Thrown when the type change failed.
    CurtainCell GetCell(ElementId uGridLineId, ElementId vGridLineId)
      Description: Get the specified cell located by the intersection of the grid lines.
      @uGridLineId: The id of a grid line in the U-direction used to locate the cell.
      @vGridLineId: The id of a grid line in the V-direction used to locate the cell.
      Returns: The cell.
      Throws ArgumentException: Thrown if the grid line ids are not part of this curtain grid.
    ICollection<CurtainCell> GetCurtainCells()
      Description: Gets the CurtainCells owned by this curtain grid.
      Returns: The CurtainCells owned by this curtain grid.
    ICollection<ElementId> GetMullionIds()
      Description: Gets all ElementIds of the mullions of the curtain grid.
      Returns: The mullion ElementIds
    Panel GetPanel(ElementId uGridLineId, ElementId vGridLineId)
      Description: Get the specified panel located by the intersection of the grid lines.
      @uGridLineId: The id of a grid line in the U-direction used to locate the panel.
      @vGridLineId: The id of a grid line in the V-direction used to locate the panel.
      Returns: The panel, or if the panel cannot be found at this intersection.
    ICollection<ElementId> GetPanelIds()
      Description: Gets all ElementIds of the panels of the curtain grid.
      Returns: The panel ElementIds
    ICollection<ElementId> GetUGridLineIds()
      Description: Gets all ElementIds of grid lines in the U direction.
      Returns: The U grid line ElementIds
    ICollection<ElementId> GetUnlockedMullionIds()
      Description: Gets all ElementIds of the unlocked mullions of the curtain grid.
      Returns: The unlocked mullion ElementIds
    ICollection<ElementId> GetUnlockedPanelIds()
      Description: Gets all ElementIds of the unlocked panels of the curtain grid.
      Returns: The unlocked panel ElementIds
    ICollection<ElementId> GetVGridLineIds()
      Description: Gets all ElementIds of grid lines in the V direction.
      Returns: The V grid line ElementIds

--------------------------------------------------------------------------------

[ENUM] CurtainGridAlignType
Full Name: Autodesk.Revit.DB.CurtainGridAlignType
Description: An enumerated to list CurtainGrid patterns.
Inherits: Enum

  Values:
    - NoJustify = 0
    - Beginning = 1
    - Center = 2
    - End = 3

--------------------------------------------------------------------------------

[CLASS] CurtainGridLine
Full Name: Autodesk.Revit.DB.CurtainGridLine
Description: Represents a CurtainGridLine within Autodesk Revit.
Inherits: HostObject

  PROPERTIES:
    CurveArray AllSegmentCurves { get; }
      Description: Retrieve the curves of all segments.
    CurveArray ExistingSegmentCurves { get; }
      Description: Retrieve all the existing segment curves of the grid line.
    Curve FullCurve { get; }
      Description: Retrieve the geometry curve of the curtain grid line.
    bool IsUGridLine { get; }
      Description: Retrieve the direction of a grid line.If it is true,we say it is a UGridLine,otherwise it is VGridLine
    bool Lock { get; set; }
      Description: Retrieves or changes the lock state of the curtain grid line.
    CurveArray SkippedSegmentCurves { get; }
      Description: Retrieve all the removed segment curves of the grid line.

  METHODS:
    void AddAllSegments()
      Description: All the segments on this grid line will be added.
    ElementSet AddMullions(Curve segment, MullionType mullionType, bool oneSegmentOnly)
      Description: Add mullions on the specified segments of a grid. If any segment already has a mullion, no change is made to that segment.
      @segment: Curve of the segment.
      @mullionType: The type of the mullion to add.
      @oneSegmentOnly: If true, add one mullion to the specified segment, otherwise add mullions to all the segments of the matching grid line.
      Returns: If operation succeeds, the created mullions will be returned.
      Throws InvalidOperationException: Invalid curtain grid line or invalid mullion type argument.
    void AddSegment(Curve curve)
      Description: Add a segment based on the specified segment curve of the gridline.
      @curve: The curve used to locate the segment to be removed. This function will invoke regeneration.
      Throws InvalidOperationException: Segment may not have been found in location indicated by curve.
    void RemoveSegment(Curve curve)
      Description: Remove the segment specified by the input curve.
      @curve: The curve used to locate the segment to be removed.
      Throws InvalidOperationException: Segment may not have been found in location indicated by curve.

--------------------------------------------------------------------------------

[CLASS] CurtainGridSet
Full Name: Autodesk.Revit.DB.CurtainGridSet
Description: A set that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CurtainGridSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of objects that are in the set.

  METHODS:
    void Clear()
      Description: Removes every item from the set, rendering it empty.
    bool Contains(CurtainGrid item)
    int Erase(CurtainGrid item)
    CurtainGridSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(CurtainGrid item)
    CurtainGridSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CurtainGridSetIterator
Full Name: Autodesk.Revit.DB.CurtainGridSetIterator
Description: An iterator to a set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CurtainGridSetIterator()
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

[CLASS] CurtainSystem
Full Name: Autodesk.Revit.DB.CurtainSystem
Description: Provides access to the CurtainSystem object in Autodesk Revit.
Remarks: The user can create CurtainSystem object and change the internal properties.
Inherits: CurtainSystemBase

  PROPERTIES:
    CurtainGridSet CurtainGrids { get; }
      Description: Get all the CurtainGrid object of this CurtainSystem. Each CurtainGrid corresponds to one face.
    CurtainSystemType CurtainSystemType { get; set; }
      Description: get or set the type of the CurtainSystem.

  METHODS:
    void AddCurtainGrid(Reference face)
      Description: Add CurtainGrid on the specified face for the CurtainSystem.
      @face: The face new CurtainGrid will be created on.
      Throws ArgumentNullException: Thrown when the input argument face is .
      Throws InvalidOperationException: Thrown when creating CurtainGrid on the specified face fails or regenerate fails.
    void RemoveCurtainGrid(Reference face)
      Description: Remove CurtainGrid from the specified face for the CurtainSystem.
      @face: The face CurtainGrid will be removed from.
      Throws ArgumentNullException: Thrown when the input parameter face is .
      Throws InvalidOperationException: Thrown when the CurtainGrid cannot be removed from the specified face or regenerate fails.

--------------------------------------------------------------------------------

[CLASS] CurtainSystemBase
Full Name: Autodesk.Revit.DB.CurtainSystemBase
Description: Provides access to the CurtainSystemBase object in Autodesk Revit.
Remarks: This is the base class of CurtainSystem.
Inherits: HostObject

--------------------------------------------------------------------------------

[CLASS] CurtainSystemType
Full Name: Autodesk.Revit.DB.CurtainSystemType
Description: An object that represents CurtainSystem type.
Inherits: HostObjAttributes

--------------------------------------------------------------------------------

[CLASS] Curve
Full Name: Autodesk.Revit.DB.Curve
Description: A parametric curve.
Remarks: The concrete curves are defined by parametric equations. If the curve is bound, it is only defined for an interval in parameterization. Otherwise, it is defined for all values of the parameter.
Inherits: GeometryObject

  PROPERTIES:
    double ApproximateLength { get; }
      Description: The approximate length of the curve.
    bool IsBound { get; }
      Description: Describes whether the parameter of the curve is restricted to a particular interval.
    bool IsClosed { get; }
      Description: Describes whether the curve is closed.
    bool IsCyclic { get; }
      Description: The boolean value that indicates whether this curve is cyclic.
    double Length { get; }
      Description: The exact length of the curve.
    double Period { get; }
      Description: The period of this curve.
    Reference Reference { get; }
      Description: Returns a stable reference to the curve.

  METHODS:
    Curve Clone()
      Description: Returns a copy of this curve.
      Returns: A copy of this curve.
    void ComputeClosestPoints(Curve otherCurve, bool withinThisCurveBounds, bool withinOtherCurveBounds, bool returnAllCriticalPnts, out IList<ClosestPointsPairBetweenTwoCurves> resultList)
      Description: Find the closest points between two curves. Closest points mean closest pairs of points, each pair consisting of a point on this, say P1, and a point on other curve, say P2. P1 and P2 are closest locally. Each pairs of closest points will be represented by the corresponding parameter values with respect to the two curves and the 3d points. A closest pair is also known as a pair of critical points of the distance function between points of the two curves. If the input parameter returnAllCriticalPoints is set to false, then the function will return only pairs with minimum distance.
      @otherCurve: The specified curve used to compute closest points to this curve.
      @withinThisCurveBounds: If this parameter is true only the solutions that are between this curve bounds will be returned. This curve must be bound if this parameter is true.
      @withinOtherCurveBounds: If this parameter is true only the solutions that are between other curve bounds will be returned. The other curve must be bound if this parameter is true.
      @returnAllCriticalPnts: The input parameter returnAllCriticalPnts is used to tell if all the critical points of the distance function are to be returned.
      @resultList: Output parameter that will contain the results collection.
      Throws ArgumentNullException: Thrown when otherCurve argument is null. Thrown when resultArray is null.
      Throws ArgumentsInconsistentException: Thrown when withinThisCurveBounds is true and this curve is unbounded. Thrown when withinOtherCurveBounds is true and other curve is unbounded.
      Throws InvalidOperationException: Thrown when the method failed. For example the problem has infinitely many solutions such as two parallel lines or two concentric circles, or in other singular cases that the method currently cannot handle, such as evaluating the closest points between a spline and a line, and the spline contains a flat segment (all points on the segment have zero curvature), and the closest points lie within that flat segment.
    Transform ComputeDerivatives(double parameter, bool normalized)
      Description: Returns the vectors describing the curve at the specified parameter.
      @parameter: The parameter to be evaluated.
      @normalized: If false, param is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The transformation containing the point on the curve, the tangent vector, derivative of tangent vector, and bi-normal vector.
      Throws ArgumentException: The given value for parameter is not finite
      Throws ArgumentOutOfRangeException: The curve cannot be evaluated as normalized because it is unbound. -or- The parameter is not a valid value for normalized evaluation.
    double ComputeNormalizedParameter(double rawParameter)
      Description: Computes the normalized curve parameter from the raw parameter.
      @rawParameter: The raw parameter.
      Returns: The real number equal to the normalized curve parameter.
      Throws ArgumentException: Thrown when rawParameter is infinite.
      Throws InvalidOperationException: Thrown when the curve is unbound.
    double ComputeRawParameter(double normalizedParameter)
      Description: Computes the raw parameter from the normalized parameter.
      @normalizedParameter: The normalized parameter.
      Returns: The real number equal to the raw curve parameter.
      Throws ArgumentException: Thrown when normalizedParameter is infinite.
      Throws InvalidOperationException: Thrown when the curve is unbound.
    Curve CreateOffset(double offsetDist, XYZ referenceVector)
      Description: Creates a new curve that is an offset of the existing curve.
      @offsetDist: The signed distance that controls the offset.
      @referenceVector: A reference vector to define the offset direction.
      Returns: The new curve.
      Throws InvalidOperationException: Cannot create the offset of the curve.
    Curve CreateReversed()
      Description: Creates a new curve with the opposite orientation of the existing curve.
      Returns: The new curve.
    Curve CreateTransformed(Transform transform)
      Description: Crates a new instance of a curve as a transformation of this curve.
      @transform: The transform to apply.
      Returns: The new curve.
      Throws ArgumentException: transform is not conformal.
      Throws ArgumentNullException: A non-optional argument was NULL
    double Distance(XYZ point)
      Description: Returns the shortest distance from the specified point to this curve.
      @point: The specified point.
      Returns: The real number equal to the shortest distance.
      Throws InvalidOperationException: Thrown when failed to find the closest point on the curve.
    XYZ Evaluate(double parameter, bool normalized)
      Description: Evaluates and returns the point that matches a parameter along the curve.
      @parameter: The parameter to be evaluated.
      @normalized: If false, param is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The point evaluated along the curve.
      Throws ArgumentException: The given value for parameter is not finite
      Throws ArgumentOutOfRangeException: The curve cannot be evaluated as normalized because it is unbound. -or- The parameter is not a valid value for normalized evaluation.
    double GetEndParameter(int index)
      Description: Returns the raw parameter value at the start or end of this curve.
      @index: 0 for the start or 1 for end of the curve.
      Returns: The parameter.
      Throws ArgumentException: curve is unbound and does not have start and end points. -or- index must be 0 for the start of the curve or 1 for the end.
      Throws ArgumentNullException: A non-optional argument was NULL
    XYZ GetEndPoint(int index)
      Description: Returns the 3D point at the start or end of this curve.
      @index: 0 for the start or 1 for end of the curve.
      Returns: The curve endpoint.
      Throws ArgumentException: curve is unbound and does not have start and end points. -or- index must be 0 for the start of the curve or 1 for the end.
      Throws ArgumentNullException: A non-optional argument was NULL
    Reference GetEndPointReference(int index)
      Description: Returns a stable reference to the start point or the end point of the curve.
      @index: Use 0 for the start point; 1 for the end point.
      Returns: Reference to the point or if reference cannot be obtained.
      Throws ArgumentOutOfRangeException: Thrown when the specified index is not 0 or 1.
      Throws InvalidOperationException: Thrown when the object is internally marked as read-only or this curve is unbound.
    SetComparisonResult Intersect(Curve curve, out IntersectionResultArray resultArray)
      Description: Calculates the intersection of this curve with the specified curve and returns the intersection results.
      @curve: The specified curve to intersect with this curve.
      @resultArray: Provides more information about the intersection.
      Returns: SetComparisonResult.Overlap - One or more intersections were encountered. The output argument has the details.SetComparisonResult.Subset - The inputs are parallel lines with only one common intersection point, or the curve used to invoke the intersection check is a line entirely within the unbound line passed as argument curve. If the former, the output argument has the details of the intersection point.SetComparisonResult.Superset - The input curve is entirely within the unbound line used to invoke the intersection check.SetComparisonResult.Disjoint - There is no intersection found between the two curves.SetComparisonResult.Equal - The two curves are identical.
      Throws ArgumentNullException: Thrown when the specified curve is .
      Throws InvalidOperationException: Thrown when failed to calculate the intersection.
    SetComparisonResult Intersect(Curve curve)
      Description: Calculates the intersection of this curve with the specified curve.
      @curve: The specified curve to intersect with this curve.
      Returns: SetComparisonResult.Overlap - One or more intersections were encountered.SetComparisonResult.Subset - The inputs are parallel lines with only one common intersection point, or the curve used to invoke the intersection check is a line entirely within the unbound line passed as argument curve.SetComparisonResult.Superset - The input curve is entirely within the unbound line used to invoke the intersection check.SetComparisonResult.Disjoint - There is no intersection found between the two curves.SetComparisonResult.Equal - The two curves are identical.
      Throws ArgumentNullException: The specified curve is .
      Throws InvalidOperationException: Failed to calculate the intersection.
    bool IsInside(double parameter, out int end)
      Description: Indicates whether the specified parameter value is within this curve's bounds and outputs the end index.
      @parameter: The raw curve parameter to be evaluated.
      @end: The end index is equal to 0 for the start point, 1 for the end point, or -1 if the parameter is not at the end.
      Returns: True if the parameter is within the curve's bounds, otherwise false.
    bool IsInside(double parameter)
      Description: Indicates whether the specified parameter value is within this curve's bounds.
      @parameter: The raw curve parameter to be evaluated.
      Returns: True if the parameter is within the bounds, otherwise false.
      Throws ArgumentException: Thrown when the specified parameter is infinite.
    void MakeBound(double startParameter, double endParameter)
      Description: Changes the bounds of this curve to the specified values.
      @startParameter: The new parameter of the start point.
      @endParameter: The new parameter of the end point.
      Throws ArgumentException: Thrown when the specified values are infinite.
      Throws InvalidOperationException: Thrown when endParameter is smaller than startParameter.
    void MakeUnbound()
      Description: Makes this curve unbound.
    IntersectionResult Project(XYZ point)
      Description: Projects the specified point on this curve.
      @point: The point to be projected.
      Returns: Geometric information if projection is successful.
      Throws InvalidOperationException: Thrown when the curve is an arc and either its radius is zero or the input point is the center of the arc. Thrown when the curve is an elliptical arc and the input point is one of the foci of the elliptical arc.
    void SetGraphicsStyleId(ElementId id)
      Description: Sets the graphics style id for this curve.
      @id: The id of the GraphicsStyle element from which to apply the curve properties.
    IList<XYZ> Tessellate()
      Description: Valid only if the curve is bound. Returns a polyline approximation to the curve.

--------------------------------------------------------------------------------

[CLASS] CurveArrArray
Full Name: Autodesk.Revit.DB.CurveArrArray
Description: An array that can contain any type of object.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CurveArrArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    CurveArray Item { get; set; }
    int Size { get; }
      Description: Returns the number of objects that are in the array.

  METHODS:
    void Append(CurveArray item)
    void Clear()
      Description: Removes every item from the array, rendering it empty.
    CurveArrArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(CurveArray item, int index)
    CurveArrArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CurveArrArrayIterator
Full Name: Autodesk.Revit.DB.CurveArrArrayIterator
Description: An iterator to a array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CurveArrArrayIterator()
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

[CLASS] CurveArray
Full Name: Autodesk.Revit.DB.CurveArray
Description: An array that can contain curves.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CurveArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    Curve Item { get; set; }
    int Size { get; }
      Description: Returns the number of curves that are in the array.

  METHODS:
    void Append(Curve item)
      Description: Add the curve to the end of the array.
      @item: The curve to be added.
    void Clear()
      Description: Removes every curve from the array, rendering it empty.
    CurveArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(Curve item, int index)
      Description: Insert the specified curve into the array.
      @item: The curve to be inserted into the array.
      @index: The curve will be inserted before this index.
    CurveArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CurveArrayIterator
Full Name: Autodesk.Revit.DB.CurveArrayIterator
Description: An iterator to a curve array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CurveArrayIterator()
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

[CLASS] CurveByPoints
Full Name: Autodesk.Revit.DB.CurveByPoints
Description: A curve interpolating two or more points.
Remarks: The points to be interpolated are represented as ReferencePoints, which must already exist in the document. In terms of appearance and graphics control, CurveByPoints behaves similarly to ModelCurve. The main difference being that a ModelCurve refers to a SketchPlane, while a CurveByPoints does not. For more methods capable of accessing data from CurveByPoints elements, see the static class CurveByPointsUtils.
Inherits: CurveElement

  PROPERTIES:
    bool IsReferenceLine { get; set; }
    ReferenceType ReferenceType { get; set; }
      Description: Indicates the type of reference.
    SketchPlane SketchPlane { get; set; }
      Description: Override the SketchPlane property of CurveElement.
    GraphicsStyle Subcategory { get; set; }
      Description: The subcategory, or graphics style, of the CurveByPoints.
    bool Visible { get; set; }
      Description: Whether the point is visible when the family is loaded into a project.

  METHODS:
    ReferencePointArray GetPoints()
      Description: Get the sequence of points interpolated by this curve.
    FamilyElementVisibility GetVisibility()
      Description: Gets the visibility.
      Returns: A copy of visibility settings for the curve.
    void SetPoints(ReferencePointArray points)
      Description: Change the sequence of points interpolated by this curve.
      @points: An array of 2 or more ReferencePoints.
      Throws ArgumentException: Thrown when the array contains fewer than 2 points, when the array contains duplicates, or when adjacent points are located too close together.
    void SetVisibility(FamilyElementVisibility visibility)
      Description: Sets the visibility.
      Throws ArgumentNullException: Thrown when visibility is .
      Throws InvalidOperationException: Thrown when regeneration failed.
    static bool SortPoints(ReferencePointArray arr)
      Description: Order a set of ReferencePoints in the same way Revit does when creating a curve from points.
      @arr: An array of ReferencePoints. The array is reordered if sortPoints returns true, and is unchanged if sortPoints returns false.
      Returns: False if the least-squares method is unable to find a solution; true otherwise.

--------------------------------------------------------------------------------

[CLASS] CurveByPointsArray
Full Name: Autodesk.Revit.DB.CurveByPointsArray
Description: An array that can contain CurveByPoints elements.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new CurveByPointsArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    CurveByPoints Item { get; set; }
    int Size { get; }
      Description: Returns the number of curves that are in the array.

  METHODS:
    void Append(CurveByPoints item)
    void Clear()
      Description: Removes every curve from the array, rendering it empty.
    CurveByPointsArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(CurveByPoints item, int index)
    CurveByPointsArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] CurveByPointsArrayIterator
Full Name: Autodesk.Revit.DB.CurveByPointsArrayIterator
Description: An iterator to a CurveByPoints array.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new CurveByPointsArrayIterator()
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

[CLASS] CurveByPointsUtils
Full Name: Autodesk.Revit.DB.CurveByPointsUtils
Description: A static class that contains methods for processing curves driven by points.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static void AddCurvesToFaceRegion(Document document, IList<ElementId> curveElemIds)
      Description: Adds The CurveElements to one or more FaceRegions.
      @document: The Document.
      @curveElemIds: The ElementIds of CurveElements which are to define the FaceRegion.
      Throws ArgumentException: All the input CurveElements must be CurveByPoints, with the sketchOnSurface attribute set to True, and for each CurveElement, the defining ReferencePoints must be hosted on References related to a common Face or Edge.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Failed to add curves to FaceRegion.
    static CurveElement CreateArcThroughPoints(Document document, ReferencePoint startPoint, ReferencePoint endPoint, ReferencePoint interiorPoint)
      Description: Creates an arc through the given reference points.
      @document: The Document.
      @startPoint: The start point of the arc.
      @endPoint: The end end of the arc.
      @interiorPoint: The interior point on the arc.
      Returns: The CurveElement to be created.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Can't create an arc from the given points
    static void CreateRectangle(Document document, ReferencePoint startPoint, ReferencePoint endPoint, CurveProjectionType projectionType, bool boundaryReferenceLines, bool boundaryCurvesFollowSurface, out IList<ElementId> createdCurvesIds, out IList<ElementId> createdCornersIds)
      Description: Creates rectangle on face or sketchplane for two given diagonal points.
      @document: The Document.
      @startPoint: First diagonal point of rectangle.
      @endPoint: Second diagonal point of rectangle.
      @projectionType: Projection type of rectangle's boundary curves. If the rectangle input points are Face hosted, and CurveProjectionType::ParallelToLevel is requested, and the Face normal at the location of the start point is at a less than 45 degree angle with the level planes, then the projectionType will be set to FromTopDown, even if ParallelToLevel was requested.
      @boundaryReferenceLines: True if rectangle's boundary curves should be reference lines, false otherwise.
      @boundaryCurvesFollowSurface: True if rectangle's boundary curves should follow surface, false otherwise.
      @createdCurvesIds: Created rectangle's boundary curves ids.
      @createdCornersIds: Ids of two newly created corner points.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: Unexpected projection type. -or- A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Unable to create rectangle.
    void Dispose()
    static IList<Reference> GetFaceRegions(Document cda, Reference referenceOfFace)
      Description: Gets the FaceRegions in the existing face.
      @cda: The Document.
      @referenceOfFace: The Reference of the existing face.
      Returns: The FaceRegions in the existing face, or an empty collection if no FaceRegions are found.
      Throws ArgumentException: The Reference is not a Face Reference.
      Throws ArgumentNullException: A non-optional argument was null
    static Reference GetHostFace(CurveElement curveElem)
      Description: Gets the host face to which the CurveElement is added.
      @curveElem: The CurveElement.
      Returns: The host face to which the CurveElement is added, or an empty Reference if the host is not a face.
      Throws ArgumentException: The input CurveElement is not a CurveByPoints.
      Throws ArgumentNullException: A non-optional argument was null
    static CurveProjectionType GetProjectionType(CurveElement curveElem)
      Description: Gets the projection type of the CurveElement.
      @curveElem: The CurveElement.
      Returns: The projection type.
      Throws ArgumentException: The input CurveElement is not a CurveByPoints.
      Throws ArgumentNullException: A non-optional argument was null
    static bool GetSketchOnSurface(CurveElement curveElem)
      Description: Gets the relationship between the CurveElement and face.
      @curveElem: The CurveElement.
      Returns: Whether or not the CurveElement should lie on the face and be able to be added to the face.
      Throws ArgumentException: The input CurveElement is not a CurveByPoints.
      Throws ArgumentNullException: A non-optional argument was null
    static void SetProjectionType(CurveElement curveElem, CurveProjectionType value)
      Description: Sets the projection type of the CurveElement.
      @curveElem: The CurveElement.
      @value: The input projection type.
      Throws ArgumentException: The input CurveElement is not a CurveByPoints.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static void SetSketchOnSurface(CurveElement curveElem, bool sketchOnSurface)
      Description: Sets the relationship between the CurveElement and face.
      @curveElem: The CurveElement.
      @sketchOnSurface: Whether or not the CurveElement should lie on the face and be able to be added to the face.
      Throws ArgumentException: The input CurveElement is not a CurveByPoints.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ValidateCurveElementIdArrayForFaceRegions(Document document, IList<ElementId> curveElemIds)
      Description: Validates that the input CurveElements can define FaceRegions. The CurveElements must be CurveByPoints. Each curve must be entirely hosted by a single Face or hosts related to a common Face (for example, Edges of a common Face, other CurveElements hosted by a common Face). To be added to the FaceRegion definition, a CurveElement must have the SketchOnSurface attribute set.
      @document: The Document.
      @curveElemIds: The CurveElements.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] CurvedEdgeConditionParam
Full Name: Autodesk.Revit.DB.CurvedEdgeConditionParam
Description: The allowed values for the HOST_SSE_CURVED_EDGE_CONDITION_PARAM parameter.
Inherits: Enum

  Values:
    - NotApplicable = 0
    - ConformToCurve = 1
    - ProjectToSideFace = 2

--------------------------------------------------------------------------------

[CLASS] CurveElement
Full Name: Autodesk.Revit.DB.CurveElement
Description: Class representing curve elements.
Remarks: As a base class of several specialized curved elements (such as ModelCurve, ModelLine, CurveByPoints, etc.) CurveElement exposes methods and properties of general use applicable to most kinds of curves.
Inherits: Element

  PROPERTIES:
    Reference CenterPointReference { get; }
      Description: Centerpoint reference of curve element. Curves such as circles, arcs, ellipses, and partial ellipses support this property.
    CurveElementType CurveElementType { get; }
      Description: Type of the curve element.
    Curve GeometryCurve { get; set; }
      Description: Geometry curve of the curve element.
    Element LineStyle { get; set; }
      Description: The line style of this curve element.
    SketchPlane SketchPlane { get; set; }
      Description: The sketch plane the curve element lies in.
    bool SupportsTangentLocks { get; }
      Description: Indicates whether or not this curve element can have a locked tangent join at either of its end-points shared with another curve element.

  METHODS:
    static CurveElement CreateAreaBasedLoadBoundaryLine(Document document, Curve curve, ElementId levelId)
      Description: Creates an area based load boundary line.
      @document: The document in which to create the area based load boundary line.
      @curve: The curve.
      @levelId: The id of level.
      Returns: The newly created area based load boundary line.
      Throws ArgumentException: document is not a project document. -or- The input curve is not bound. -or- The curve is degenerate (its length is too close to zero). -or- The ElementId levelId is not a Level. -or- The curve doesn't lie in the plane of the level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static IList<CurveElement> CreateAreaBasedLoadBoundaryLines(Document document, IList<Curve> curves, ElementId levelId)
      Description: Creates area based load boundary lines.
      @document: The document in which to create the area based load boundary lines.
      @curves: The curves.
      @levelId: The id of level.
      Returns: The newly created area based load boundary lines.
      Throws ArgumentException: document is not a project document. -or- The input curves contains a null pointer or a curve that is not bounded. -or- The input curves contains at least one curve which is degenerate (its length is too close to zero). -or- The ElementId levelId is not a Level. -or- The input curves contains a curve doesn't lie in the plane of the level.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements).
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ISet<ElementId> GetAdjoinedCurveElements(int end)
      Description: Returns elements that are joining with this curve element at the given end point.
      @end: Id of one the curve's end. Value '0' indicates start and '1' indicates the end of the curve, respectively.
      Returns: Collection of Ids of Curve Elements.
      Throws ArgumentException: The given Id does not represent any of the two end-points of a curve element. A valid value of either '0' or '1' is expected.
    AreaBasedLoadBoundaryLineData GetAreaBasedLoadBoundaryLineData()
      Description: Gets the area based load boundary line data from this curve, if applicable.
      Returns: The area based load boundary line data, if this is an area based load boundary, or otherwise.
    ICollection<ElementId> GetLineStyleIds()
      Description: Ids of all line style Elements that are applicable to this curve element.
      Returns: A collection of Ids of line style elements.
    bool GetTangentLock(int end, ElementId other)
      Description: Returns the state of a tangent join between this and another curve element at the given end-point.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      Returns: Returns True if this curve element has a tangent joint with the other input element and the join is curently locked; returns False otherwise.
      Throws ArgumentException: The given Id does not represent any of the two end-points of a curve element. A valid value of either '0' or '1' is expected. -or- The given ElementId (%elementId) is not of a valid Curve Element. A valid Curve Element must be in the same document and must be diferent than this curve elements self. -or- This element has no tangent join with the input element at the given end-point.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasTangentJoin(int end, ElementId other)
      Description: Tests whether this curve element and the input curve element have common tangent join at the given end-point.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      Returns: Returns True if the two curve elements have a tangent join at the given end-point.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasTangentLocks(int end)
      Description: Tests whether this curve element has any locked tangent joins at the given end-point.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      Returns: Returns True if the curve element is tangentially locked to at least one other curve element at the given end-point; returns False otherwise.
    bool IsAdjoinedCurveElement(int end, ElementId other)
      Description: This method tests whether this and the given curve elements are joined at the given end.
      @end: Index of one of the curve's end. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      Returns: Returns True if the input curve element joins This curve element at the given end-point; returns False otherwise.
      Throws ArgumentException: The given Id does not represent any of the two end-points of a curve element. A valid value of either '0' or '1' is expected. -or- The given ElementId (%elementId) is not of a valid Curve Element. A valid Curve Element must be in the same document and must be diferent than this curve elements self.
      Throws ArgumentNullException: A non-optional argument was null
    void SetGeometryCurve(Curve curve, bool overrideJoins)
      Description: Sets the geometry of the curve element. After the curve geometry is set, other nearby curves may join to the new curve geometry.
      @curve: The new curve.
      @overrideJoins: An option to specify whether or not existing joins will affect setting the geometry of the CurveElement. Setting this parameter to false is essentially the same as directly setting the GeometryCurve property.
      Throws ArgumentNullException: Thrown if the argument is .
      Throws ArgumentException: Thrown if the input curve is of a type different from the current. -- or -- Thrown if the input curve is bound and the current is not or vice versa. -- or -- Thrown if the input curve is helical. -- or -- Thrown if the input curve lies outside of the SketchPlane of the current curve and the CurveElement is not CurveByPoints.
    void SetSketchPlaneAndCurve(SketchPlane sketchPlane, Curve curve)
      Description: Sets the sketch plane and the curve for this CurveElement.
      @sketchPlane: The new sketch plane.
      @curve: The new curve.
      Throws ArgumentNullException: Thrown if the argument is .
      Throws InvalidOperationException: Thrown if the CurveElement is CurveByPoints or belongs to a Path3d element. -- or -- Thrown if the sketch plane is set on a DetailCurve. -- or -- Thrown if the sketch plane is not suitable. -- or -- Thrown if the CurveElement belongs to a sketch-based element. -- or -- Thrown if modifying the sketch plane is not allowed. -- or -- Thrown if the CurveElement cannot be moved out of its sketch plane. -- or -- Thrown if the input curve is of a type different from the current. -- or -- Thrown if the input curve is bound and the current is not or vice versa. -- or -- Thrown if the input curve is helical. -- or -- Thrown if the input curve lies outside of the SketchPlane of the current curve.
    void SetTangentLock(int end, ElementId other, bool state)
      Description: Sets a new status for an existing tangent join with another curve element at the given end-point.
      @end: Index of one of the curve's ends. Values '0' and '1' indicate the start or end point, respectively.
      @other: ElementId of another Curve Element from the same document.
      @state: Requested new state of the lock; True to lock it, False to unlock it.
      Throws ArgumentException: The given Id does not represent any of the two end-points of a curve element. A valid value of either '0' or '1' is expected. -or- The given ElementId (%elementId) is not of a valid Curve Element. A valid Curve Element must be in the same document and must be diferent than this curve elements self. -or- This element has no tangent join with the input element at the given end-point. -or- The element other does not exist in the document containing this CurveElement
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This curve element does not support tangent joins with other elements.
      Throws ModificationForbiddenException: This CurveElement is an internal element, such as a component of a loaded family or a group type. -or- The document containing this CurveElement is in Group Edit Mode, Sketch Edit Mode, or Paste Mode, and the element is not a member of the group, sketch, or clipboard. -or- This CurveElement is a member of a group or sketch, and the document is not currently editing the group or sketch. -or- other is an internal element, such as a component of a loaded family or a group type. -or- The document containing other is in Group Edit Mode, Sketch Edit Mode, or Paste Mode, and the element is not a member of the group, sketch, or clipboard. -or- other is a member of a group or sketch, and the document is not currently editing the group or sketch.

--------------------------------------------------------------------------------

[CLASS] CurveElementFilter
Full Name: Autodesk.Revit.DB.CurveElementFilter
Description: A filter used to pass curve elements which are of a specific type.
Inherits: ElementSlowFilter

  CONSTRUCTORS:
    new CurveElementFilter(CurveElementType curveElementType, bool inverted)
      Description: Constructs a new instance of a filter to match specific types of curve elements, with the option to match all curves which are not of the given curve type.
      @curveElementType: The curve element type to match.
      @inverted: True if the filter should match all curves which are not of the given curve type.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new CurveElementFilter(CurveElementType curveElementType)
      Description: Constructs a new instance of a filter to match specific types of curve elements.
      @curveElementType: The curve element type to match.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    CurveElementType CurveElementType { get; }
      Description: The curve element type.

--------------------------------------------------------------------------------

[ENUM] CurveElementType
Full Name: Autodesk.Revit.DB.CurveElementType
Description: An enumerated type listing the curve element types that can be used when filtering elements (via CurveElementFilter).
Inherits: Enum

  Values:
    - Invalid = 0
    - ModelCurve = 1
    - DetailCurve = 2
    - SymbolicCurve = 3
    - ReferenceLine = 4
    - SpaceSeparation = 5
    - RoomSeparation = 6
    - AreaSeparation = 7
    - CurveByPoints = 8
    - RepeatingDetail = 9
    - Insulation = 10
    - Cloud = 11
    - AreaBasedLoadBoundary = 12

--------------------------------------------------------------------------------

[CLASS] CurveExtents
Full Name: Autodesk.Revit.DB.CurveExtents
Description: Represents the start and end parameters for a curve segment.
Implements: IDisposable

  PROPERTIES:
    double EndParameter { get; }
      Description: The end parameter of the curve extents.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double StartParameter { get; }
      Description: The start parameter of the curve extents.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] CurveLoop
Full Name: Autodesk.Revit.DB.CurveLoop
Description: A class that represents a chain of curves.
Remarks: There are specific requirements for how valid CurveLoops must be formed: The curves should typically be contiguous.The CurveLoop may be either closed (where the start and end points coincide) or open.There should be no self-intersections.A CurveLoop is said to be "continuous" if either: the loop contains at most one curvethe end of each curve coincides with the start of the next one (if there is a next curve). Many geometry utilities require CurveLoops to be continuous, but discontinuous CurveLoops are sometimes used. For example, the curves in a continuous CurveLoop may be offset, resulting in a discontinuous loop if the offset curves overlap or do not meet, and the offset curves might then be extended or trimmed to form a continuous CurveLoop. A CurveLoop is said to be "closed" if it is non-empty, continuous, and if either: the loop contains just one curve, which is unbounded and periodicthe loop's end point coincides with its start point For example, a CurveLoop comprising four lines forming a rectangle, listed in order around the rectangle, with each curve oriented in direction in which the curves are listed is closed. As another example, a CurveLoop consisting of just one unbounded circle is closed. A CurveLoop is said to be "open" if it is not closed. For example, a CurveLoop consisting of a single line is open, as is the "offset CurveLoop" mentioned above. Note that an open CurveLoop may be continuous or discontinuous, and a continuous CurveLoop may be open or closed. The definitions imply that a discontinuous CurveLoop is necessarily open and an empty CurveLoop is open. It should also be noted that these definitions take the order of the curves and the curves' directions into account. For example, a CurveLoop comprising the four edges of a rectangle in the order {bottom, top, left, right} is discontinuous. Similarly, a CurveLoop comprising the four edges of a rectangle in the order {bottom, right, top, left}, with three of the lines oriented in the counter-clockwise direction of the rectangle and the fourth oriented in the clockwise direction, is discontinuous. Finally, note that some routines in Revit may set the CurveLoop to be marked "open" or "closed" in spite of the actual geometry of the curves. In these special cases, the CurveLoop class does not require that the CurveLoop is correctly marked. In the API, the members of the CurveLoop may be directly iterated, as the class implements IEnumerable<Curve>. The iteration provides copies of the curves directly contained in the loop; modification of the curves will not affect the curves that are contained in the loop.
Implements: IEnumerable<Curve>, IEnumerable, IDisposable

  CONSTRUCTORS:
    new CurveLoop()
      Description: Constructs a new empty curve loop.

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Append(Curve curve)
      Description: Append the curve to this loop.
      @curve: The curve.
      Throws ArgumentException: The input curve points to a helical curve and is not supported for this operation. -or- Throws if the input curve makes the loop not contiguous.
      Throws ArgumentNullException: A non-optional argument was null
    static CurveLoop Create(IList<Curve> curves)
      Description: Creates a new curve loop.
      @curves: The curves.
      Returns: The curve loop.
      Throws ArgumentException: The input curves contains at least one helical curve and is not supported for this operation. -or- Throws if the input curves are not contiguous.
      Throws ArgumentNullException: A non-optional argument was null
    static CurveLoop CreateViaCopy(CurveLoop original)
      Description: Creates a new curve loop as a copy of the input.
      @original: The original curve loop.
      Returns: The copied curve loop.
      Throws ArgumentNullException: A non-optional argument was null
    static CurveLoop CreateViaOffset(CurveLoop original, IList<double> offsetDists, XYZ normal)
      Description: Creates a new curve loop that is an offset of the existing curve loop.
      @original: The original curve loop.
      @offsetDists: The signed offset distances for each curve. The size of this array must match the size of the curve loop. Curve at position i will be offset with offsetDists[i].
      @normal: The normal of the offset plane.
      Returns: The offset curve loop.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Thrown if the curve loop could not be offset.
    static CurveLoop CreateViaOffset(CurveLoop original, double offsetDist, XYZ normal)
      Description: Creates a new curve loop that is an offset of the existing curve loop.
      @original: The original curve loop.
      @offsetDist: The signed offset distance.
      @normal: The normal of the offset plane.
      Returns: The offset curve loop.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Thrown if the curve loop could not be offset.
    static CurveLoop CreateViaThicken(CurveLoop curveLoop, double thickness, XYZ normal)
      Description: Creates a new closed curve loop by thickening the input open curve loop with respect to a given plane.
      @curveLoop: The input curve loop.
      @thickness: The distance between the offset curves created on either side of the input curve.
      @normal: The normal vector to the plane used for thickening.
      Returns: The new curve loop.
      Throws ArgumentException: The input thickness is too short for a curve. -or- the curve loop is not marked as open.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Throws if the input curve could not be thickened.
    static CurveLoop CreateViaThicken(Curve pCurve, double thickness, XYZ normal)
      Description: Creates a new closed curve loop by thickening the input curve with respect to a given plane.
      @pCurve: The input curve.
      @thickness: The distance between the offset curves created on either side of the input curve.
      @normal: The normal vector to the plane used for thickening.
      Returns: The new curve loop.
      Throws ArgumentException: The input thickness is too short for a curve. -or- The input pCurve points to a helical curve and is not supported for this operation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Throws if the input curve could not be thickened.
    static CurveLoop CreateViaTransform(CurveLoop curveLoop, Transform transform)
      Description: Creates a new curve loop as a transformed copy of the input curve loop.
      @curveLoop: The input curve loop.
      @transform: The transformation.
      Returns: The new curve loop.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: transform is not conformal. -or- transform has a scale that is negative or zero.
    void Dispose()
    void Flip()
      Description: Reverses the orientation of the curve loop.
    CurveLoopIterator GetCurveLoopIterator()
      Description: Returns a curve that iterates through the curve loop.
      Returns: A curve loop iterator object that can be used to iterate through key-value pairs in the collection.
    IEnumerator<Curve> GetEnumerator()
      Description: Returns an enumerator that iterates through a collection.
      Returns: An IEnumerator object that can be used to iterate through the collection.
    double GetExactLength()
      Description: Returns the sum of exact lengths of all curves in the loop.
      Returns: The total length of the curves in the loop.
    Plane GetPlane()
      Description: Gets the plane of the curve loop, if it is planar.
      Returns: The plane of the curve loop.
      Throws InvalidOperationException: The curve loop does not lie in a single plane.
    double GetRectangularHeight(Plane plane)
      Description: Returns the width of a curve loop if it is rectangular with respect to the projection plane.
      @plane: The plane to which the curves will be projected.
      Returns: The height.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The curve loop is not rectangular when projected to the input plane.
    double GetRectangularWidth(Plane plane)
      Description: Returns the width of a curve loop if it is rectangular with respect to the projection plane.
      @plane: The plane to which the curves will be projected.
      Returns: The width.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The curve loop is not rectangular when projected to the input plane.
    bool HasPlane()
      Description: Identifies if the CurveLoop is planar.
      Returns: True if the curve loop is planar, false otherwise.
    bool IsCounterclockwise(XYZ normal)
      Description: Determines if this CurveLoop is oriented counter-clockwise (CCW) or clockwise (CW) with respect to the specified 3D direction.
      @normal: The normal vector to the plane used for this determination.
      Returns: True if the curve loop is oriented counter-clockwise with respect to the specified 3D direction, false if the loop is oriented clockwise.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The curve loop is open or consists of a single unbound curve; counterclockwise determination has no meaning.
    bool IsOpen()
      Description: Returns whether the curve loop is open or closed, as determined by an internal flag.
      Returns: True if the CurveLoop is marked open, false if marked closed.
    bool IsRectangular(Plane plane)
      Description: Identifies if the curve loop is rectangular with respect to a given projection plane.
      @plane: The plane to which the curves will be projected to determine if they represent a rectangle.
      Returns: True if the curve loop is rectangular, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    int NumberOfCurves()
      Description: Returns the number of curves in the curve loop.
      Returns: The number of curves in the curve loop.
    void Transform(Transform transform)
      Description: Transforms this curve loop and all of its component curves by the supplied transformation.
      @transform: The transformation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: transform is not conformal. -or- transform has a scale that is negative or zero.

--------------------------------------------------------------------------------

[CLASS] CurveLoopIterator
Full Name: Autodesk.Revit.DB.CurveLoopIterator
Description: An iterator to a curve loop.
Implements: IEnumerator<Curve>, IDisposable, IEnumerator

  PROPERTIES:
    Curve Current { get; }
      Description: Gets the item at the current position of the iterator.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    bool MoveNext()
      Description: Increments the iterator to the next item.
      Returns: True if there is a next available item in this iterator. False if the iterator has completed all available items.
    void Reset()
      Description: Resets the iterator to the initial state.

--------------------------------------------------------------------------------

[CLASS] CurveLoopsProfile
Full Name: Autodesk.Revit.DB.CurveLoopsProfile
Description: Represents a curve loop based profile for sweep or swept blend elements.
Remarks: Use objects of this type in methods as NewSweep() and NewSweptBlend() in FamilyItemFactory to create the profile.
Inherits: SweepProfile

  PROPERTIES:
    CurveArrArray Profile { get; set; }
      Description: Returns the curve loops of the profile.

--------------------------------------------------------------------------------

[CLASS] CurveNode
Full Name: Autodesk.Revit.DB.CurveNode
Description: An output node that represents a model curve.
Remarks: See also: Autodesk::Revit::DB::IModelExportContext::OnCurve.
Inherits: ModelCurveNode

  METHODS:
    Curve GetCurve()
      Description: Returns the geometric curve object corresponding to the node.
      Returns: The curve.

--------------------------------------------------------------------------------

[ENUM] CurveProjectionType
Full Name: Autodesk.Revit.DB.CurveProjectionType
Description: This attribute indicates how the curve will be projected to the surface if the curve is sketched on the surface.
Inherits: Enum

  Values:
    - FromTopDown = 0
    - ParallelToLevel = 1
    - FollowSurfaceUV = 2

--------------------------------------------------------------------------------

[CLASS] CurveUV
Full Name: Autodesk.Revit.DB.CurveUV
Description: A class that encapsulates the notion of a curve in the 2D parameter space of a surface in 3D space.
Remarks: Revit does not have a class to represent 2D curves explicitly.
Implements: IDisposable

  PROPERTIES:
    bool IsBound { get; }
      Description: Describes whether the parameter of the curve is restricted to a particular interval.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    Curve As3DCurveInXYPlane()
      Description: Returns a 3D curve lying in the XY plane in XYZ coordinates, representing the 2D curve with its UV coordinates identified with XY coordinates.
      Returns: 3D curve lying in the XY plane in XYZ coordinates, representing the 2D curve with its UV coordinates identified with XY coordinates.
    IList<UV> ComputeDerivatives(double parameter, bool normalized)
      Description: Computes the first derivative, the second derivative and the unit tangent vector at the specified parameter along the curve.
      @parameter: The specified parameter along the curve.
      @normalized: If false, parameter is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The array containing three members: the first derivative (at index [0]), the second derivative (at index [1]) and the unit tangent vector (at index [2]).
      Throws ArgumentException: The given value for parameter is not finite
      Throws ArgumentOutOfRangeException: The curve cannot be evaluated as normalized because it is unbound. -or- The parameter is not a valid value for normalized evaluation.
    static CurveUV Create(Curve curve3D)
      Description: Create a CurveUV from a bounded 3D Curve lying in the XY plane.
      @curve3D: The input bounded 3D Curve lying in the XY plane (i.e., z = 0 everywhere along the curve).
      Returns: The newly created CurveUV.
      Throws ArgumentException: The input Curve is not a bounded 3D Curve lying in the XY plane (i.e., z = 0 everywhere along the curve).
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    UV Evaluate(double parameter, bool normalized)
      Description: Evaluates and returns the point at the specified parameter along the curve.
      @parameter: The specified parameter along the curve.
      @normalized: If false, parameter is interpreted as natural parameterization of the curve. If true, param is expected to be in [0,1] interval mapped to the bounds of the curve. Setting to true is valid only if the curve is bound.
      Returns: The point evaluated along the curve.
      Throws ArgumentException: The given value for parameter is not finite
      Throws ArgumentOutOfRangeException: The curve cannot be evaluated as normalized because it is unbound. -or- The parameter is not a valid value for normalized evaluation.
    double GetEndParameter(int index)
      Description: Gets the raw parameter value at the start or end of this curve.
      @index: Use 0 for the start parameter, 1 for the end parameter of the curve.
      Returns: The raw parameter value at the start or end of this curve.
      Throws ArgumentOutOfRangeException: The given value for index is not 0 or 1.
      Throws InvalidOperationException: This curve is unbound and does not have start and end points.
    CurveUV Transform(Transform2D trfUV)
      Description: Transform this CurveUV by the given 2D affine transform if possible.
      @trfUV: The given 2D affine transform.
      Returns: If successful a transformed CurveUV, otherwise .
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] CustomExporter
Full Name: Autodesk.Revit.DB.CustomExporter
Description: A class that allows exporting 3D or 2D views via an export context.
Remarks: The Export method of this class triggers standard rendering or exporting process in Revit, but instead of displaying the result on screen or printer, the output is channeled through the given custom context that handles processing of the geometric as well as non-geometric information.Revit will process the exporting algorithm depending on the type of given context. If an instance of IPhotoRenderContext is used, then Revit will output the model as if executing the Render command, thus only such entities that would be visible in a rendered view will be sent to the context.Alternatively, if an instance of IModelExportContext is used, Revit will output the model as if exporting it to a CAD format, a process which results outputting also objects that would not appear in a rendered image, such as model curves and text annotations.For 2D views, an instance of IExportContext2D has to be used. Revit will output the contents of the 2D view as it is displayed on the screen. Export can be modified by setting properties pertaining to 2D views: Export2DGeometricObjectsIncludingPatternLines, Export2DIncludingAnnotationObjects. Export2DForceDisplayStyle. See notes for 2D export in IExportContext2D.
Implements: IDisposable

  CONSTRUCTORS:
    new CustomExporter(Document document, IExportContext context)
      Description: Constructs a new instance of a CustomExporter for a given document using the input instance of IExportContext as the output device.
      @document: The document containing the model to be exported
      @context: An instance of a context class that will be consuming the output
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    DisplayStyle Export2DForceDisplayStyle { get; set; }
      Description: This value tells the exporter of 2D views to force the given display mode for the view.
    bool Export2DGeometricObjectsIncludingPatternLines { get; set; }
      Description: This flag sets the exporter of 2D views to either include or exclude output of face pattern lines as part of geometric objects when the model is being processed by the export context.
    bool Export2DIncludingAnnotationObjects { get; set; }
      Description: This flag sets the exporter of 2D views to either include or exclude output of annotation objects when the model is being processed by the export context.
    bool IncludeGeometricObjects { get; set; }
      Description: This flag sets the exporter to either include or exclude output of geometric objects such as faces and curves when the model is being processed by the export context.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    bool ShouldStopOnError { get; set; }
      Description: This flag instructs the exporting process to either stop or continue in case an error occurs during any of the exporting methods.

  METHODS:
    void Dispose()
    void Export(IList<ElementId> viewIds)
      Description: Exports a collection of 3D or 2D views
      @viewIds: An array of views to export
      Throws ArgumentException: One or more elements in viewIds is not a valid exportable view. For example, templates are not considered valid views to export.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The instance of IExportContext is not valid. -or- Rendering is currently not supported in the running instance of Revit. One reason for that to happen is that rendering and material libraries are not currently available.
    void Export(View view)
      Description: Exports one 3D or 2D view
      @view: An instance of the view to export
      Throws ArgumentException: The view is not exportable, such as a template view or wrong type view, for example.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The instance of IExportContext is not valid. -or- Rendering is currently not supported in the running instance of Revit. One reason for that to happen is that rendering and material libraries are not currently available.
    static bool IsRenderingSupported()
      Description: Checks if view rendering is currently supported in the running instance of Revit.
      Returns: Returns True if rendering is currently supported, False otherwise.

--------------------------------------------------------------------------------

[CLASS] CustomFieldData
Full Name: Autodesk.Revit.DB.CustomFieldData
Description: A class that offer access to the information about a custom field.
Implements: IDisposable

  PROPERTIES:
    double DefaultRowHeightOnSheet { get; }
      Description: Identifies the default row height for this field.
    string FieldName { get; }
      Description: The name of this custom field.
    string FieldTooltip { get; }
      Description: The tooltip that will be shown in the schedule properties dialog for this custom field.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    Guid GetCustomFieldId()
      Description: Gets an unique identifier of the custom field.
      Returns: Returns an unique identifier of type of custom field.
    ICustomFieldProperties GetCustomFieldProperties()
      Description: Gets an instance of ICustomFieldProperties which represents the properties of this field.
      Returns: Returns an instance of ICustomFieldProperties.
      Throws InvalidOperationException: Can't obtain the properties from a CustomFieldData of a SchedulableField (which is not added to a schedule).
    void SetCustomFieldProperties(ICustomFieldProperties customFieldProperties)
      Description: Sets an instance of ICustomFieldProperties which represents the properties of this field.
      @customFieldProperties: An instance of ICustomFieldProperties which represents the properties of this field.
      Throws ArgumentException: The input properties are not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Can't set the properties to a CustomFieldData of a SchedulableField (which is not added to a schedule).
    string ValidateCustomFieldProperties(ICustomFieldProperties customFieldProperties)
      Description: Validates the custom field properties.
      @customFieldProperties: An instance of ICustomFieldProperties which represents the properties of this field.
      Returns: If the properties are valid, an empty string will be returned. If the properties are not valid, a non-empty string which describes the error will be returned.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Can't validate the properties of a CustomFieldData of a SchedulableField (which is not added to a schedule).

--------------------------------------------------------------------------------

[ENUM] CustomSubCategoryId
Full Name: Autodesk.Revit.DB.CustomSubCategoryId
Description: An enumerated type listing pseudo sub-categories that can appear in a mapping template. These types do not represent an independent category in Revit, but can be mapped to specific IFC entity.
Inherits: Enum

  Values:
    - InteriorWall = 1
    - ExteriorWall = 2
    - FoundationWall = 3
    - RetainingWall = 4
    - Coreshaft = 5
    - Soffit = 6
    - None = -1

--------------------------------------------------------------------------------

[ENUM] CutFailureReason
Full Name: Autodesk.Revit.DB.CutFailureReason
Description: The reason why a solid-solid cut cannot be created.
Inherits: Enum

  Values:
    - CutAllowed = 0
    - CutAlreadyExists = 1
    - OppositeCutExists = 2
    - CutNotAppropriateForElements = 3

--------------------------------------------------------------------------------

[CLASS] CylindricalFace
Full Name: Autodesk.Revit.DB.CylindricalFace
Description: A cylindrical face of a 3d solid or open shell.
Remarks: For details on the parameterization, refer to the documentation for CylindricalSurface.
Inherits: Face

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the surface.
    XYZ Origin { get; }
      Description: Origin of the surface.
    XYZ Radius { get; }

--------------------------------------------------------------------------------

[CLASS] CylindricalHelix
Full Name: Autodesk.Revit.DB.CylindricalHelix
Description: A cylindrical helix.
Remarks: The helix winds around a cylinder making constant angle with the axis of the cylinder. In this release, CylindricalHelix curves are used only in specific applications in stairs and railings, and should not be used or encountered when accessing curves of other Revit elements and geometry.
Inherits: Curve

  PROPERTIES:
    XYZ BasePoint { get; }
      Description: The base point of the axis of the cylindrical helix.
    double Height { get; }
      Description: Height of the cylindrical helix.
    bool IsRightHanded { get; }
      Description: True if the helix is right handed, false if the helix is left handed.
    double Pitch { get; }
      Description: The pitch of the cylindrical helix.
    double Radius { get; }
      Description: The radius of the cylindrical helix.
    XYZ XVector { get; }
      Description: The X direction vector.
    XYZ YVector { get; }
      Description: The Y direction vector.
    XYZ ZVector { get; }
      Description: The Z direction vector, which is same as the axis direction vector.

  METHODS:
    static CylindricalHelix Create(XYZ basePoint, double radius, XYZ xVector, XYZ zVector, double pitch, double startAngle, double endAngle)
      Description: Create a cylindrical helix.
      @basePoint: Base point of the axis. It can be any point in 3d.
      @radius: Radius. It should be a positive number.
      @xVector: X vector. Should be Non-zero vector.
      @zVector: Z vector = axis direction. Should be non-zero and orthogonal to X Vector.
      @pitch: Pitch. It should be non-zero number, can be positive or negative. Positive means right handed and negative means left handed.
      @startAngle: Start angle. It specifies the start point of the Helix.
      @endAngle: End angle. It specifies the end point of the Helix. End angle should not be equal to start angle.
      Throws ArgumentException: The radius is negative -or- the pitch is zero -or- the xVector or zVector is zero length -or- zVector is not orthogonal to xVector -or- endAngle is equal to startAngle.

--------------------------------------------------------------------------------

[CLASS] CylindricalSurface
Full Name: Autodesk.Revit.DB.CylindricalSurface
Description: A cylindrical surface.
Remarks: The parametric equation of the cylinder is S(u, v) = center + radius*cos(u)*xVec + radius*sin(u)*yVec + v*zVec.
Inherits: Surface

  PROPERTIES:
    XYZ Axis { get; }
      Description: Axis of the cylinder. This is the Z axis of the local coordinate system associated with this cylinder.
    XYZ Origin { get; }
      Description: Center of the circle that defines the base of the cylinder. This is the origin of the local coordinate system associated with this cylinder.
    double Radius { get; }
      Description: Radius of the circle that defines the base of this cylinder.
    XYZ XDir { get; }
      Description: X axis of the local coordinate system associated with this cylinder.
    XYZ YDir { get; }
      Description: Y axis of the local coordinate system associated with this cylinder.

  METHODS:
    static CylindricalSurface Create(Frame frameOfReference, double radius)
      Description: Construct a cylindrical surface defined by a local coordinate system and a radius.
      @frameOfReference: frameOfReference is an orthonormal frame that defines a local coordinate system for the cylinder. Frame.Origin is a point on the cylinder's axis.Frame.BasisZ points along the axis, while Frame.BasisX and Frame.BasisY are orthogonal to the axis.The frame may be either left-handed or right-handed (see Frame.IsRightHanded). Note that the "handedness" of the frame does not, by itself, determine the surface's orientation.
      @radius: Radius of the circle that defines the base of the cylindrical surface.
      Returns: The created CylindricalSurface.
      Throws ArgumentException: This Frame object may not be used as a local frame of reference.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The given value for radius must be greater than 0 and no more than 30000 feet.
    Frame GetFrameOfReference()
      Description: Returns frame of reference associated with this CylindricalSurface.
      Returns: Frame of reference associated with this CylindricalSurface.

--------------------------------------------------------------------------------

