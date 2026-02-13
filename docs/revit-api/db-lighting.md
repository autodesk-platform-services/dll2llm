# Autodesk.Revit.DB.Lighting


NAMESPACE: Autodesk.Revit.DB.Lighting
--------------------------------------------------------------------------------

[CLASS] AdvancedLossFactor
Full Name: Autodesk.Revit.DB.Lighting.AdvancedLossFactor

Description: This class encapsulates advanced lighting loss factor calculation.
Remarks: Advanced lighting loss factor is a combination of several different factors. Each factor has a value of 0.0 (total loss) to 1.0 (no loss).
Inherits: LossFactor
Implements: IDisposable

  CONSTRUCTORS:
    new AdvancedLossFactor(AdvancedLossFactor other)
    new AdvancedLossFactor(double ballastLossFactorIn, double lampLumenDepreciationIn, double lampTiltLossFactorIn, double luminaireDirtDepreciationIn, double surfaceDepreciationLossFactorIn, double temperatureLossFactorIn, double voltageLossFactorIn)
    new AdvancedLossFactor()

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
Implements: IDisposable

  CONSTRUCTORS:
    new BasicLossFactor(BasicLossFactor other)
    new BasicLossFactor(double lossFactorIn)
    new BasicLossFactor()

  PROPERTIES:
    double LossFactor { get; set; }
      Description: The loss factor.

--------------------------------------------------------------------------------

[CLASS] CircleLightShape
Full Name: Autodesk.Revit.DB.Lighting.CircleLightShape

Description: This class encapsulates a circle light shape.
Inherits: LightShape
Implements: IDisposable

  CONSTRUCTORS:
    new CircleLightShape(CircleLightShape other)
    new CircleLightShape(double emitDiameter)
    new CircleLightShape()

  PROPERTIES:
    double EmitDiameter { get; set; }
      Description: The emit diameter.

--------------------------------------------------------------------------------

[ENUM] ColorPreset
Full Name: Autodesk.Revit.DB.Lighting.ColorPreset

Description: Preset values of initial colors for specific lighting types
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

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

[CLASS] CustomInitialColor
Full Name: Autodesk.Revit.DB.Lighting.CustomInitialColor

Description: This class encapsulates a custom initial lighting color.
Remarks: This color is called an initial color because a color filter can also be added to modify the color.
Inherits: InitialColor
Implements: IDisposable

  CONSTRUCTORS:
    new CustomInitialColor(CustomInitialColor other)
    new CustomInitialColor(double temperature)

  PROPERTIES:
    double Temperature { get; set; }
      Description: The custom color temperature value.

--------------------------------------------------------------------------------

[CLASS] HemisphericalLightDistribution
Full Name: Autodesk.Revit.DB.Lighting.HemisphericalLightDistribution

Description: This class encapsulates a hemispherical light distribution.
Inherits: LightDistribution
Implements: IDisposable

  CONSTRUCTORS:
    new HemisphericalLightDistribution(HemisphericalLightDistribution other)
    new HemisphericalLightDistribution()

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
Implements: IDisposable

  CONSTRUCTORS:
    new InitialFluxIntensity(InitialFluxIntensity other)
    new InitialFluxIntensity(double flux)

  PROPERTIES:
    double Flux { get; set; }
      Description: The flux intensity value.

--------------------------------------------------------------------------------

[CLASS] InitialIlluminanceIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialIlluminanceIntensity

Description: This class encapsulates initial illuminance intensity calculation.
Inherits: InitialIntensity
Implements: IDisposable

  CONSTRUCTORS:
    new InitialIlluminanceIntensity(InitialIlluminanceIntensity other)
    new InitialIlluminanceIntensity(double distance, double illuminance)

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
Implements: IDisposable

  CONSTRUCTORS:
    new InitialLuminousIntensity(InitialLuminousIntensity other)
    new InitialLuminousIntensity(double luminosity)

  PROPERTIES:
    double Luminosity { get; set; }
      Description: The luminosity value.

--------------------------------------------------------------------------------

[CLASS] InitialWattageIntensity
Full Name: Autodesk.Revit.DB.Lighting.InitialWattageIntensity

Description: This class encapsulates initial wattage intensity calculation.
Inherits: InitialIntensity
Implements: IDisposable

  CONSTRUCTORS:
    new InitialWattageIntensity(InitialWattageIntensity other)
    new InitialWattageIntensity(double efficacy, double wattage)

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - None = 0
    - Incandescent = 1

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Spherical = 0
    - Hemispherical = 1
    - Spot = 2
    - PhotometricWeb = 3

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
    LightShapeStyle GetLightShapeStyle()
      Description: Returns a LightShapeStyle value for the light shape
    Transform GetLightSourceTransform()
      Description: Returns a Transform value for the transform of light source.
      Returns: The light source transform.
    LightType GetLightType(int index)
      Description: Return a LightType object for the light type at the given index
      @index: The index of the light type
      Returns: A LightType object for the light type at the given index
    string GetLightTypeName(int index)
      Description: Return the name for the light type at the given index
      @index: The index of the light type
      Returns: The name of the light type at the given index
    int GetNumberOfLightTypes()
      Description: Return the number of light types contained in this light family
      Returns: The number of light types contained in this light family
    void SetLightDistributionStyle(LightDistributionStyle lightDistributionStyle)
      Description: Set the light distribution style to the given shape distribution
      @lightDistributionStyle: The light distribution style to set the light distribution type to
    void SetLightShapeStyle(LightShapeStyle lightShapeStyle)
      Description: Set the light shape style to the given shape style
      @lightShapeStyle: The light shape style value to set the light shape style to

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
    void Dispose()
    ICollection<ElementId> GetLights()
      Description: Get the set of contained light instances The set of light instances
    void RemoveLight(ElementId lightId)
      Description: Remove the given light instance from the set of light instances in this group
      @lightId: The light instance to remove

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
    void DeleteGroup(ElementId groupId)
      Description: Remove the given LightGroup object from the set of LightGroup objects
      @groupId: The Id of the LightGroup object to remove
    void Dispose()
    IList<LightGroup> GetGroups()
      Description: Get the set of contained LightGroup objects The set of LightGroup objects
    double GetLightDimmer(ElementId viewId, ElementId lightId)
      Description: Gets the dimmer value for the given light for rendering the given view
      @viewId: The Id of the view
      @lightId: The Id of the light to turn on or off
    static LightGroupManager GetLightGroupManager(Document document)
      Description: Creates a light group manager object from the given document
      @document: The document the manager is from
      Returns: The newly created Light group manager object
    bool IsLightGroupOn(ElementId viewId, ElementId groupId)
      Description: Returns true if the given light group is on
      @viewId: The Id of the view
      @groupId: The Id of the light group
    bool IsLightOn(ElementId viewId, ElementId lightId)
      Description: Returns true if the given light is on for rendering the given view
      @viewId: The Id of the view
      @lightId: The Id of the light
    void SetLightDimmer(ElementId viewId, ElementId lightId, double dimmingValue)
      Description: Sets the dimmer value for the given light for rendering the given view
      @viewId: The Id of the view
      @lightId: The Id of the light to turn on or off
      @dimmingValue: The dimmer value to set int the range of [0.0, 1.0]
    void SetLightGroupOn(ElementId viewId, ElementId groupId, bool turnOn)
      Description: Turns the given light group on or off for rendering the given view depending on the bool argument
      @viewId: The Id of the view
      @groupId: The Id of the light group
      @turnOn: Turns the light group on if true, off if false
    void SetLightOn(ElementId viewId, ElementId lightId, bool turnOn)
      Description: Turns the given light on or off for rendering the given view depending on the bool argument
      @viewId: The Id of the view
      @lightId: The Id of the light to turn on or off
      @turnOn: Turns the light on if true, off if false

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
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Point = 0
    - Line = 1
    - Rectangle = 2
    - Circle = 3

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
    static LightType GetLightTypeFromInstance(Document document, ElementId instanceId)
      Description: Creates a light type object from the given document and element ID
      @document: The document the instanceId is from
      @instanceId: The ID of the light fixture instance
      Returns: The newly created LightType object
    LossFactor GetLossFactor()
      Description: Return a copy of an object derived from LossFactor
    void SetInitialColor(InitialColor initialColor)
      Description: Replace the current initial color object with the given object
      @initialColor: An object derived from an InitialColor object The object pointed to is cloned internally
    void SetInitialIntensity(InitialIntensity initialIntensity)
      Description: Replace the current initial intensity object with the given object
      @initialIntensity: An object derived from an InitialIntensity object
    void SetLightDistribution(LightDistribution lightDistribution)
      Description: Replace the current LightDistribution object with the given object
      @lightDistribution: An instance of an object derived from LightDistribution
    void SetLightShape(LightShape lightShape)
      Description: Replace the current LightShape object with the given object
      @lightShape: An instance of an object derived from LightShape
    void SetLossFactor(LossFactor lossFactor)
      Description: Replace the current loss factor object with the given object
      @lossFactor: An object derived from a LossFactor object

--------------------------------------------------------------------------------

[CLASS] LineLightShape
Full Name: Autodesk.Revit.DB.Lighting.LineLightShape

Description: This class encapsulates a line light shape.
Inherits: LightShape
Implements: IDisposable

  CONSTRUCTORS:
    new LineLightShape(LineLightShape other)
    new LineLightShape(double emitLength)
    new LineLightShape()

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
Implements: IDisposable

  CONSTRUCTORS:
    new PhotometricWebLightDistribution(PhotometricWebLightDistribution other)
    new PhotometricWebLightDistribution(string photometricWebFile, double tiltAngle)

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
Implements: IDisposable

  CONSTRUCTORS:
    new PointLightShape(PointLightShape other)
    new PointLightShape()

--------------------------------------------------------------------------------

[CLASS] PresetInitialColor
Full Name: Autodesk.Revit.DB.Lighting.PresetInitialColor

Description: This class encapsulates a preset initial lighting color.
Inherits: InitialColor
Implements: IDisposable

  CONSTRUCTORS:
    new PresetInitialColor(PresetInitialColor other)
    new PresetInitialColor(ColorPreset presetIn)

  PROPERTIES:
    ColorPreset Preset { get; set; }
      Description: The preset value

--------------------------------------------------------------------------------

[CLASS] RectangleLightShape
Full Name: Autodesk.Revit.DB.Lighting.RectangleLightShape

Description: This class encapsulates a rectangle light shape.
Inherits: LightShape
Implements: IDisposable

  CONSTRUCTORS:
    new RectangleLightShape(RectangleLightShape other)
    new RectangleLightShape(double emitLength, double emitWidth)
    new RectangleLightShape()

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
Implements: IDisposable

  CONSTRUCTORS:
    new SphericalLightDistribution(SphericalLightDistribution other)
    new SphericalLightDistribution()

--------------------------------------------------------------------------------

[CLASS] SpotLightDistribution
Full Name: Autodesk.Revit.DB.Lighting.SpotLightDistribution

Description: This class encapsulates a spot light distribution.
Inherits: LightDistribution
Implements: IDisposable

  CONSTRUCTORS:
    new SpotLightDistribution(SpotLightDistribution other)
    new SpotLightDistribution(double spotBeamAngle, double spotFieldAngle, double tiltAngle)
    new SpotLightDistribution()

  PROPERTIES:
    double SpotBeamAngle { get; set; }
      Description: The spot beam angle.
    double SpotFieldAngle { get; set; }
      Description: The spot field angle.
    double TiltAngle { get; set; }
      Description: The tilt angle.

--------------------------------------------------------------------------------


