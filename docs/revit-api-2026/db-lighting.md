# Autodesk.Revit.DB.Lighting

NAMESPACE: Autodesk.Revit.DB.Lighting
--------------------------------------------------------------------------------

[CLASS] AdvancedLossFactor
Full Name: Autodesk.Revit.DB.Lighting.AdvancedLossFactor
Description: This class encapsulates advanced lighting loss factor calculation.
Remarks: Advanced lighting loss factor is a combination of several different factors. Each factor has a value of 0.0 (total loss) to 1.0 (no loss).
Inherits: LossFactor

  CONSTRUCTORS:
    new AdvancedLossFactor(AdvancedLossFactor other)
      Description: Creates a copy of the given advanced loss factor object
      Throws ArgumentNullException: A non-optional argument was null
    new AdvancedLossFactor(double ballastLossFactorIn, double lampLumenDepreciationIn, double lampTiltLossFactorIn, double luminaireDirtDepreciationIn, double surfaceDepreciationLossFactorIn, double temperatureLossFactorIn, double voltageLossFactorIn)
      Description: Creates an advanced loss factor object with the given values.
      @ballastLossFactorIn: The ballast loss factor as a numerical value between 0.0 and 1.0.
      @lampLumenDepreciationIn: The lamp lumen depreciation loss factor as a numerical value between 0.0 and 1.0.
      @lampTiltLossFactorIn: The lamp tilt loss factor as a numerical value between 0.0 and 1.0.
      @luminaireDirtDepreciationIn: The luminaire dirt depreciation loss factor as a numerical value between 0.0 and 1.0.
      @surfaceDepreciationLossFactorIn: The surface depreciation loss factor as a numerical value between 0.0 and 1.0.
      @temperatureLossFactorIn: The temperature loss factor as a numerical value between 0.0 and 2.0.
      @voltageLossFactorIn: The voltage loss factor as a numerical value between 0.0 and 2.0.
      Throws ArgumentOutOfRangeException: The loss factor is not valid because it is not between 0.0 and 1.0. -or- The loss factor is not valid because it is not between 0.0 and 2.0.
    new AdvancedLossFactor()
      Description: Creates an advanced loss factor object with values set to no loss.

  PROPERTIES:
    double BallastLossFactor { get; set; }
      Description: The ballast loss factor.
    double LampLumenDepreciation { get; set; }
      Description: The lamp lumen depreciation loss factor.
    double LampTiltLossFactor { get; set; }
      Description: The lamp tilt loss factor.
    double LuminaireDirtDepreciation { get; set; }
      Description: The luminaire dirt depreciation loss factor.
    double SurfaceDepreciationLossFactor { get; set; }
      Description: The surface depreciation loss factor.
    double TemperatureLossFactor { get; set; }
      Description: The temperature loss factor.
    double VoltageLossFactor { get; set; }
      Description: The voltage loss factor.

--------------------------------------------------------------------------------

[CLASS] BasicLossFactor
Full Name: Autodesk.Revit.DB.Lighting.BasicLossFactor
Description: This class encapsulates basic lighting loss factor calculation.
Inherits: LossFactor

  CONSTRUCTORS:
    new BasicLossFactor(BasicLossFactor other)
      Description: Creates a copy of the given basic loss factor object
      Throws ArgumentNullException: A non-optional argument was null
    new BasicLossFactor(double lossFactorIn)
      Description: Creates a basic loss factor object with the given value.
      @lossFactorIn: The loss factor as a numerical value between 0.0 and 4.0
      Throws ArgumentOutOfRangeException: The loss factor is not valid because it is not between 0.0 and 4.0.
    new BasicLossFactor()
      Description: Creates a basic loss factor object with no loss.

  PROPERTIES:
    double LossFactor { get; set; }
      Description: The loss factor.

--------------------------------------------------------------------------------

[CLASS] CircleLightShape
Full Name: Autodesk.Revit.DB.Lighting.CircleLightShape
Description: This class encapsulates a circle light shape.
Inherits: LightShape

  CONSTRUCTORS:
    new CircleLightShape(CircleLightShape other)
      Description: Creates a copy of the given circle light shape
      Throws ArgumentNullException: A non-optional argument was null
    new CircleLightShape(double emitDiameter)
      Description: Creates a circle light shape object with the given emit diameter.
      @emitDiameter: The emit diameter as a numerical value in feet between 1.0e-9 and 30000.0
      Throws ArgumentOutOfRangeException: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.
    new CircleLightShape()
      Description: Creates a circle light shape object with 2.0' emit diameter.

  PROPERTIES:
    double EmitDiameter { get; set; }
      Description: The emit diameter.

--------------------------------------------------------------------------------

[ENUM] ColorPreset
Full Name: Autodesk.Revit.DB.Lighting.ColorPreset
Description: Preset values of initial colors for specific lighting types
Inherits: Enum

  Values:
    - D65 = 0
    - D50 = 1
    - Halogen = 2
    - Incandescent = 3
    - Xenon = 4
    - Quartz = 5
    - FluorescentWarm = 6
    - FluorescentCool = 7
    - FluorescentWhite = 8
    - FluorescentDayLight = 9
    - FluorescentLightWhite = 10
    - MetalHalide = 11
    - HighPressureSodium = 12
    - LowPressureSodium = 13
    - Mercury = 14
    - PhosphorMercury = 15

--------------------------------------------------------------------------------

[CLASS] CustomInitialColor
Full Name: Autodesk.Revit.DB.Lighting.CustomInitialColor
Description: This class encapsulates a custom initial lighting color.
Remarks: This color is called an initial color because a color filter can also be added to modify the color.
Inherits: InitialColor

  CONSTRUCTORS:
    new CustomInitialColor(CustomInitialColor other)
      Description: Creates a copy of the given custom initial color
      Throws ArgumentNullException: A non-optional argument was null
    new CustomInitialColor(double temperature)
      Description: Creates a custom initial color set to the given color
      @temperature: The color temperature in Kelvin as a numerical value between 1800 and 20000
      Throws ArgumentOutOfRangeException: The color temperature is not valid because it is not in the range of 1800 to 20000.

  PROPERTIES:
    double Temperature { get; set; }
      Description: The custom color temperature value.

--------------------------------------------------------------------------------

[CLASS] HemisphericalLightDistribution
Full Name: Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution
Description: This class encapsulates a hemispherical light distribution.
Inherits: LightDistribution

  CONSTRUCTORS:
    new HemisphericalLightDistribution(HemisphericalLightDistribution other)
      Description: Creates a copy of the given hemispherical light distribution
      Throws ArgumentNullException: A non-optional argument was null
    new HemisphericalLightDistribution()
      Description: Creates a hemispherical light distribution object.

--------------------------------------------------------------------------------

[CLASS] InitialColor
Full Name: Autodesk.Revit.DB.Lighting.InitialColor
Description: This class is the base class for calculating initial light color.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double TemperatureValue { get; }
      Description: The light color temperature value in Kelvins.

  METHODS:
    InitialColor Clone()
      Description: Creates a copy of the InitialColor derived object.
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] InitialFluxIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialFluxIntensity
Description: This class encapsulates initial flux intensity calculation.
Inherits: InitialIntensity

  CONSTRUCTORS:
    new InitialFluxIntensity(InitialFluxIntensity other)
      Description: Creates a copy of the given initial flux intensity object
      Throws ArgumentNullException: A non-optional argument was null
    new InitialFluxIntensity(double flux)
      Description: Creates an initial flux intensity object with the given document and flux values.
      @flux: The flux value in lm as a numerical value between 0 and 1e+30.
      Throws ArgumentOutOfRangeException: The flux intensity value is not valid because it is not between 0 and 1e+30.

  PROPERTIES:
    double Flux { get; set; }
      Description: The flux intensity value.

--------------------------------------------------------------------------------

[CLASS] InitialIlluminanceIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity
Description: This class encapsulates initial illuminance intensity calculation.
Inherits: InitialIntensity

  CONSTRUCTORS:
    new InitialIlluminanceIntensity(InitialIlluminanceIntensity other)
      Description: Creates a copy of the given initial illuminance intensity object
      Throws ArgumentNullException: A non-optional argument was null
    new InitialIlluminanceIntensity(double distance, double illuminance)
      Description: Creates an initial illuminance intensity object with the given document and illuminance values.
      @distance: The illuminance distance value in feet as a numerical value between 0 and 1e+30.
      @illuminance: The illuminance value in lx as a numerical value between 0 and 1e+30.
      Throws ArgumentOutOfRangeException: The distance value is not valid because it is not between 0 and 1e+30. -or- The illuminance value is not valid because it is not between 0 and 1e+30.

  PROPERTIES:
    double Distance { get; set; }
      Description: The illuminance intensity distance value.
    double Illuminance { get; set; }
      Description: The illuminance intensity value.

--------------------------------------------------------------------------------

[CLASS] InitialIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialIntensity
Description: This class is the base class for calculating lighting initial intensity.
Implements: IDisposable

  PROPERTIES:
    double InitialIntensityValue { get; }
      Description: The calculated initial intensity value.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    InitialIntensity Clone()
      Description: Creates a copy of the InitialIntensity derived object.
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] InitialLuminousIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialLuminousIntensity
Description: This class encapsulates initial luminous intensity calculation.
Inherits: InitialIntensity

  CONSTRUCTORS:
    new InitialLuminousIntensity(InitialLuminousIntensity other)
      Description: Creates a copy of the given initial luminous intensity object
      Throws ArgumentNullException: A non-optional argument was null
    new InitialLuminousIntensity(double luminosity)
      Description: Creates an initial luminous intensity object with the given document and luminosity values.
      @luminosity: The luminosity value in cd as a numerical value between 0 and 1e+30.
      Throws ArgumentOutOfRangeException: The luminosity value is not valid because it is not between 0 and 1e+30.

  PROPERTIES:
    double Luminosity { get; set; }
      Description: The luminosity value.

--------------------------------------------------------------------------------

[CLASS] InitialWattageIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialWattageIntensity
Description: This class encapsulates initial wattage intensity calculation.
Inherits: InitialIntensity

  CONSTRUCTORS:
    new InitialWattageIntensity(InitialWattageIntensity other)
      Description: Creates a copy of the given initial wattage intensity object
      Throws ArgumentNullException: A non-optional argument was null
    new InitialWattageIntensity(double efficacy, double wattage)
      Description: Creates an initial wattage intensity object with the given values.
      @efficacy: The universal unit efficacy value as a numerical value between 0 and 1e+30.
      @wattage: The universal unit wattage value as a numerical value between 0 and 1e+30.
      Throws ArgumentOutOfRangeException: The efficacy value is not valid because it is not between 0 and 1e+30. -or- The wattage value is not valid because it is not between 0 and 1e+30.

  PROPERTIES:
    double Efficacy { get; set; }
      Description: The efficacy value.
    double Wattage { get; set; }
      Description: The wattage value.

--------------------------------------------------------------------------------

[ENUM] LightDimmingColor
Full Name: Autodesk.Revit.DB.Lighting.LightDimmingColor
Description: Tags for specific light dimming colors
Inherits: Enum

  Values:
    - None = 0
    - Incandescent = 1

--------------------------------------------------------------------------------

[CLASS] LightDistribution
Full Name: Autodesk.Revit.DB.Lighting.LightDistribution
Description: This class is the base class for specifying light distribution.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    LightDistribution Clone()
      Description: Creates a copy of the LightDistribution derived object.
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] LightDistributionStyle
Full Name: Autodesk.Revit.DB.Lighting.LightDistributionStyle
Description: Tags for specific light distribution styles
Inherits: Enum

  Values:
    - Spherical = 0
    - Hemispherical = 1
    - Spot = 2
    - PhotometricWeb = 3

--------------------------------------------------------------------------------

[CLASS] LightFamily
Full Name: Autodesk.Revit.DB.Lighting.LightFamily
Description: This class encapsulates light family information.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    LightDistributionStyle GetLightDistributionStyle()
      Description: Returns a LightDistributionStyle value for the light distribution
    static LightFamily GetLightFamily(Document document)
      Description: Creates a light family object from the given family document
      @document: The family document
      Returns: The newly created LightFamily object
      Throws ArgumentException: The Document is the argument that is being validated The document is not valid because it is not a light family document.
      Throws ArgumentNullException: A non-optional argument was null
    LightShapeStyle GetLightShapeStyle()
      Description: Returns a LightShapeStyle value for the light shape
    Transform GetLightSourceTransform()
      Description: Returns a Transform value for the transform of light source.
      Returns: The light source transform.
    LightType GetLightType(int index)
      Description: Return a LightType object for the light type at the given index
      @index: The index of the light type
      Returns: A LightType object for the light type at the given index
      Throws ArgumentException: The index is the argument that is being validated The index is not valid because it does not correspond to a valid light type
    string GetLightTypeName(int index)
      Description: Return the name for the light type at the given index
      @index: The index of the light type
      Returns: The name of the light type at the given index
      Throws ArgumentException: The index is the argument that is being validated The index is not valid because it does not correspond to a valid light type
    int GetNumberOfLightTypes()
      Description: Return the number of light types contained in this light family
      Returns: The number of light types contained in this light family
    void SetLightDistributionStyle(LightDistributionStyle lightDistributionStyle)
      Description: Set the light distribution style to the given shape distribution
      @lightDistributionStyle: The light distribution style to set the light distribution type to
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetLightShapeStyle(LightShapeStyle lightShapeStyle)
      Description: Set the light shape style to the given shape style
      @lightShapeStyle: The light shape style value to set the light shape style to
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] LightGroup
Full Name: Autodesk.Revit.DB.Lighting.LightGroup
Description: This class represents a set of lights grouped together for easier management of various lighting scenarios
Implements: IDisposable

  PROPERTIES:
    ElementId Id { get; }
      Description: The ElementId of the LightGroup
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string Name { get; set; }
      Description: The name of the LightGroup

  METHODS:
    void AddLight(ElementId lightId)
      Description: Add a new light instance to the group
      @lightId: The ID of the light instance to add to the group
      Throws ArgumentException: The given element ID does not correspond to a light instance -or- The light instance is in this LightGroup
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    ICollection<ElementId> GetLights()
      Description: Get the set of contained light instances The set of light instances
    void RemoveLight(ElementId lightId)
      Description: Remove the given light instance from the set of light instances in this group
      @lightId: The light instance to remove
      Throws ArgumentException: The light instance is not in this LightGroup
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LightGroupManager
Full Name: Autodesk.Revit.DB.Lighting.LightGroupManager
Description: This class represents a set of light groups that are used for easier management of various lighting scenarios
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    LightGroup CreateGroup(string name)
      Description: Create a new LightGroup object with the given name
      @name: The name to use for the new LightGroup object
      Returns: The new LightGroup object that was created
      Throws ArgumentException: The name is not valid because it is not unique within this LightGroupManager -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
      Throws ArgumentNullException: A non-optional argument was null
    void DeleteGroup(ElementId groupId)
      Description: Remove the given LightGroup object from the set of LightGroup objects
      @groupId: The Id of the LightGroup object to remove
      Throws ArgumentException: The given element Id does not correspond to a light group -or- The LightGroup is not contained by this LightGroupManager
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    IList<LightGroup> GetGroups()
      Description: Get the set of contained LightGroup objects The set of LightGroup objects
    double GetLightDimmer(ElementId viewId, ElementId lightId)
      Description: Gets the dimmer value for the given light for rendering the given view
      @viewId: The Id of the view
      @lightId: The Id of the light to turn on or off
      Throws ArgumentException: The given element Id does not correspond to a 3d view -or- The given element Id does not correspond to a light instance
      Throws ArgumentNullException: A non-optional argument was null
    static LightGroupManager GetLightGroupManager(Document document)
      Description: Creates a light group manager object from the given document
      @document: The document the manager is from
      Returns: The newly created Light group manager object
      Throws ArgumentException: The document is not valid because it is not a project (rvt) document
      Throws ArgumentNullException: A non-optional argument was null
    bool IsLightGroupOn(ElementId viewId, ElementId groupId)
      Description: Returns true if the given light group is on
      @viewId: The Id of the view
      @groupId: The Id of the light group
      Throws ArgumentException: The given element Id does not correspond to a 3d view -or- The given element Id does not correspond to a light group
      Throws ArgumentNullException: A non-optional argument was null
    bool IsLightOn(ElementId viewId, ElementId lightId)
      Description: Returns true if the given light is on for rendering the given view
      @viewId: The Id of the view
      @lightId: The Id of the light
      Throws ArgumentException: The given element Id does not correspond to a 3d view -or- The given element Id does not correspond to a light instance
      Throws ArgumentNullException: A non-optional argument was null
    void SetLightDimmer(ElementId viewId, ElementId lightId, double dimmingValue)
      Description: Sets the dimmer value for the given light for rendering the given view
      @viewId: The Id of the view
      @lightId: The Id of the light to turn on or off
      @dimmingValue: The dimmer value to set int the range of [0.0, 1.0]
      Throws ArgumentException: The given element Id does not correspond to a 3d view -or- The given element Id does not correspond to a light instance -or- The given dimming value is not in the range [0.0, 1.0]
      Throws ArgumentNullException: A non-optional argument was null
    void SetLightGroupOn(ElementId viewId, ElementId groupId, bool turnOn)
      Description: Turns the given light group on or off for rendering the given view depending on the bool argument
      @viewId: The Id of the view
      @groupId: The Id of the light group
      @turnOn: Turns the light group on if true, off if false
      Throws ArgumentException: The given element Id does not correspond to a 3d view -or- The given element Id does not correspond to a light group
      Throws ArgumentNullException: A non-optional argument was null
    void SetLightOn(ElementId viewId, ElementId lightId, bool turnOn)
      Description: Turns the given light on or off for rendering the given view depending on the bool argument
      @viewId: The Id of the view
      @lightId: The Id of the light to turn on or off
      @turnOn: Turns the light on if true, off if false
      Throws ArgumentException: The given element Id does not correspond to a 3d view -or- The given element Id does not correspond to a light instance
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LightShape
Full Name: Autodesk.Revit.DB.Lighting.LightShape
Description: This class is the base class for specifying light shape.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    LightShape Clone()
      Description: Creates a copy of the LightShape derived object.
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] LightShapeStyle
Full Name: Autodesk.Revit.DB.Lighting.LightShapeStyle
Description: Tags for specific light shape styles
Inherits: Enum

  Values:
    - Point = 0
    - Line = 1
    - Rectangle = 2
    - Circle = 3

--------------------------------------------------------------------------------

[CLASS] LightType
Full Name: Autodesk.Revit.DB.Lighting.LightType
Description: This class encapsulates light information.
Implements: IDisposable

  PROPERTIES:
    Color ColorFilter { get; set; }
      Description: The light filter color.
    LightDimmingColor DimmingColor { get; set; }
      Description: The dimming temperature value in Kelvins.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    InitialColor GetInitialColor()
      Description: Return a copy of an object derived from InitialColor
    InitialIntensity GetInitialIntensity()
      Description: Return a copy of an object derived from InitialIntensity
    LightDistribution GetLightDistribution()
      Description: Return a copy of an object derived from LightDistribution
    LightShape GetLightShape()
      Description: Return a copy of an object derived from LightShape
    static LightType GetLightType(Document document, ElementId typeId)
      Description: Creates a light type object from the given document and family type ID
      @document: The document the typeId is from
      @typeId: The ID of the light family type
      Returns: The newly created LightType object
      Throws ArgumentException: The ElementId is the argument that is being validated The ElementId is not valid because it is not for a light element.
      Throws ArgumentNullException: A non-optional argument was null
    static LightType GetLightTypeFromInstance(Document document, ElementId instanceId)
      Description: Creates a light type object from the given document and element ID
      @document: The document the instanceId is from
      @instanceId: The ID of the light fixture instance
      Returns: The newly created LightType object
      Throws ArgumentException: The ElementId is the argument that is being validated The ElementId is not valid because it is not for a light element.
      Throws ArgumentNullException: A non-optional argument was null
    LossFactor GetLossFactor()
      Description: Return a copy of an object derived from LossFactor
    void SetInitialColor(InitialColor initialColor)
      Description: Replace the current initial color object with the given object
      @initialColor: An object derived from an InitialColor object The object pointed to is cloned internally
      Throws ArgumentNullException: A non-optional argument was null
    void SetInitialIntensity(InitialIntensity initialIntensity)
      Description: Replace the current initial intensity object with the given object
      @initialIntensity: An object derived from an InitialIntensity object
      Throws ArgumentNullException: A non-optional argument was null
    void SetLightDistribution(LightDistribution lightDistribution)
      Description: Replace the current LightDistribution object with the given object
      @lightDistribution: An instance of an object derived from LightDistribution
      Throws ArgumentException: The LightDistribution is the argument that is being validated The LightDistribution is not valid because it of a different derived type than the current LightDistribution derived type.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLightShape(LightShape lightShape)
      Description: Replace the current LightShape object with the given object
      @lightShape: An instance of an object derived from LightShape
      Throws ArgumentException: The LightShape is the argument that is being validated The LightShape is not valid because it of a different derived type than the current LightShape derived type.
      Throws ArgumentNullException: A non-optional argument was null
    void SetLossFactor(LossFactor lossFactor)
      Description: Replace the current loss factor object with the given object
      @lossFactor: An object derived from a LossFactor object
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] LineLightShape
Full Name: Autodesk.Revit.DB.Lighting.LineLightShape
Description: This class encapsulates a line light shape.
Inherits: LightShape

  CONSTRUCTORS:
    new LineLightShape(LineLightShape other)
      Description: Creates a copy of the given line light shape
      Throws ArgumentNullException: A non-optional argument was null
    new LineLightShape(double emitLength)
      Description: Creates a line light shape object with the given emit length.
      @emitLength: The emit length as a numerical value in feet between 1.0e-9 and 30000.0
      Throws ArgumentOutOfRangeException: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.
    new LineLightShape()
      Description: Creates a line light shape object with 2.0' emit length.

  PROPERTIES:
    double EmitLength { get; set; }
      Description: The emit length.

--------------------------------------------------------------------------------

[CLASS] LossFactor
Full Name: Autodesk.Revit.DB.Lighting.LossFactor
Description: This class is the base class for calculating lighting loss factor.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LossFactorValue { get; }
      Description: The calculated loss factor value

  METHODS:
    LossFactor Clone()
      Description: Creates a copy of the LossFactor derived object.
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] PhotometricWebLightDistribution
Full Name: Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution
Description: This class encapsulates a photometric web light distribution.
Inherits: LightDistribution

  CONSTRUCTORS:
    new PhotometricWebLightDistribution(PhotometricWebLightDistribution other)
      Description: Creates a copy of the given photometric web light distribution
      Throws ArgumentNullException: A non-optional argument was null
    new PhotometricWebLightDistribution(string photometricWebFile, double tiltAngle)
      Description: Creates a photometric web light distribution object with the given filename and tilt.
      @photometricWebFile: The filename of the IES file to use.
      @tiltAngle: The tilt angle as a numerical value in degrees between -180.0 and 180.0.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: The angle is not valid because it is not between -180.0 and 180.0.

  PROPERTIES:
    string PhotometricWebFile { get; set; }
      Description: The filename of an IES photometric web file.
    double TiltAngle { get; set; }
      Description: The tilt angle.

--------------------------------------------------------------------------------

[CLASS] PointLightShape
Full Name: Autodesk.Revit.DB.Lighting.PointLightShape
Description: This class encapsulates a point light shape.
Inherits: LightShape

  CONSTRUCTORS:
    new PointLightShape(PointLightShape other)
      Description: Creates a copy of the given point light shape
      Throws ArgumentNullException: A non-optional argument was null
    new PointLightShape()
      Description: Creates a point light shape object.

--------------------------------------------------------------------------------

[CLASS] PresetInitialColor
Full Name: Autodesk.Revit.DB.Lighting.PresetInitialColor
Description: This class encapsulates a preset initial lighting color.
Inherits: InitialColor

  CONSTRUCTORS:
    new PresetInitialColor(PresetInitialColor other)
      Description: Creates a copy of the given preset initial color
      Throws ArgumentNullException: A non-optional argument was null
    new PresetInitialColor(ColorPreset presetIn)
      Description: Creates an initial color preset object with the given preset value.
      @presetIn: The enum value which determines the preset value
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    ColorPreset Preset { get; set; }
      Description: The preset value

--------------------------------------------------------------------------------

[CLASS] RectangleLightShape
Full Name: Autodesk.Revit.DB.Lighting.RectangleLightShape
Description: This class encapsulates a rectangle light shape.
Inherits: LightShape

  CONSTRUCTORS:
    new RectangleLightShape(RectangleLightShape other)
      Description: Creates a copy of the given rectangle light shape
      Throws ArgumentNullException: A non-optional argument was null
    new RectangleLightShape(double emitLength, double emitWidth)
      Description: Creates a rectangle light shape object with the given emit length and width.
      @emitLength: The emit length as a numerical value in feet between 1.0e-9 and 30000.0
      @emitWidth: The emit width as a numerical value in feet between 1.0e-9 and 30000.0
      Throws ArgumentOutOfRangeException: The shape dimension is not valid because it is not between 1.0e-9 and 30000.0.
    new RectangleLightShape()
      Description: Creates a rectangle light shape object with 4.0' emit length and a 2.0' emit width.

  PROPERTIES:
    double EmitLength { get; set; }
      Description: The emit length.
    double EmitWidth { get; set; }
      Description: The emit width.

--------------------------------------------------------------------------------

[CLASS] SphericalLightDistribution
Full Name: Autodesk.Revit.DB.Lighting.SphericalLightDistribution
Description: This class encapsulates a spherical light distribution.
Inherits: LightDistribution

  CONSTRUCTORS:
    new SphericalLightDistribution(SphericalLightDistribution other)
      Description: Creates a copy of the given spherical light distribution
      Throws ArgumentNullException: A non-optional argument was null
    new SphericalLightDistribution()
      Description: Creates a spherical light distribution object.

--------------------------------------------------------------------------------

[CLASS] SpotLightDistribution
Full Name: Autodesk.Revit.DB.Lighting.SpotLightDistribution
Description: This class encapsulates a spot light distribution.
Inherits: LightDistribution

  CONSTRUCTORS:
    new SpotLightDistribution(SpotLightDistribution other)
      Description: Creates a copy of the given spotlight distribution
      Throws ArgumentNullException: A non-optional argument was null
    new SpotLightDistribution(double spotBeamAngle, double spotFieldAngle, double tiltAngle)
      Description: Creates a spot light distribution object with the given values.
      @spotBeamAngle: The spot beam angle as a numerical value in radians between 0 and (8/9)*PI.
      @spotFieldAngle: The spot field angle as a numerical value in radians between 0 and (8/9)*PI.
      @tiltAngle: The tilt angle as a numerical value in radians between -PI and PI.
      Throws ArgumentOutOfRangeException: The angle is not valid because it is not between 1.0e-2 and 160.0. -or- The angle is not valid because it is not between -180.0 and 180.0.
    new SpotLightDistribution()
      Description: Creates a spot light distribution object with the following values; PI/6 radians spot beam anglePI/2 radians spot field anglePI/6 radians tilt angle

  PROPERTIES:
    double SpotBeamAngle { get; set; }
      Description: The spot beam angle.
    double SpotFieldAngle { get; set; }
      Description: The spot field angle.
    double TiltAngle { get; set; }
      Description: The tilt angle.

--------------------------------------------------------------------------------

