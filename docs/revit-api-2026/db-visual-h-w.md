# Autodesk.Revit.DB.Visual

NAMESPACE: Autodesk.Revit.DB.Visual
--------------------------------------------------------------------------------

[ABSTRACT CLASS] Hardwood
Full Name: Autodesk.Revit.DB.Visual.Hardwood
Description: A static class that provides access to the property names that appear in the Hardwood visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "Hardwood" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "Hardwood" schema.
    static string HardwoodApplication { get; }
      Description: The property labeled "Used For" from the "Hardwood" schema.
    static string HardwoodColor { get; }
      Description: The property labeled "Image" from the "Hardwood" schema.
    static string HardwoodFinish { get; }
      Description: The property labeled "Finish" from the "Hardwood" schema.
    static string HardwoodImperfections { get; }
      Description: The property labeled "Relief Pattern" from the "Hardwood" schema.
    static string HardwoodImperfectionsAmount { get; }
      Description: The property labeled "Amount" from the "Hardwood" schema.
    static string HardwoodImperfectionsShader { get; }
      Description: The property labeled "Image" from the "Hardwood" schema.
    static string HardwoodTintColor { get; }
      Description: The property labeled "Stain Color" from the "Hardwood" schema.
    static string HardwoodTintEnabled { get; }
      Description: The property labeled "Stain" from the "Hardwood" schema.

--------------------------------------------------------------------------------

[ENUM] HardwoodApplicationType
Full Name: Autodesk.Revit.DB.Visual.HardwoodApplicationType
Description: The enumerated type representing the permitted values for the asset property "HardwoodApplication" from the "Hardwood" schema.
Inherits: Enum

  Values:
    - looring = 0
    - urniture = 1

--------------------------------------------------------------------------------

[ENUM] HardwoodFinishType
Full Name: Autodesk.Revit.DB.Visual.HardwoodFinishType
Description: The enumerated type representing the permitted values for the asset property "HardwoodFinish" from the "Hardwood" schema.
Inherits: Enum

  Values:
    - Gloss = 0
    - Semigloss = 1
    - Satin = 2
    - Unfinished = 3

--------------------------------------------------------------------------------

[ENUM] HardwoodImperfectionsType
Full Name: Autodesk.Revit.DB.Visual.HardwoodImperfectionsType
Description: The enumerated type representing the permitted values for the asset property "HardwoodImperfections" from the "Hardwood" schema.
Inherits: Enum

  Values:
    - None = 0
    - Automatic = 1
    - Custom = 2

--------------------------------------------------------------------------------

[ENUM] HardwoodTintEnabledType
Full Name: Autodesk.Revit.DB.Visual.HardwoodTintEnabledType
Description: The enumerated type representing the permitted values for the asset property "HardwoodTintEnabled" from the "Hardwood" schema.
Inherits: Enum

  Values:
    - NoColor = 0
    - ColorChoice = 1

--------------------------------------------------------------------------------

[ENUM] LayeredNdfType
Full Name: Autodesk.Revit.DB.Visual.LayeredNdfType
Description: The enumerated type representing the permitted values for the asset property "LayeredNdfType" from the "AdvancedLayered" schema.
Inherits: Enum

  Values:
    - Beckmann = 0
    - Ggx = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Marble
Full Name: Autodesk.Revit.DB.Visual.Marble
Description: A static class that provides access to the property names that appear in the Marble visual asset schema.

  PROPERTIES:
    static string MarbleColor1 { get; }
      Description: The property labeled "Stone Color" from the "Marble" schema.
    static string MarbleColor2 { get; }
      Description: The property labeled "Vein Color" from the "Marble" schema.
    static string MarbleSize { get; }
      Description: The property labeled "Vein Spacing" from the "Marble" schema.
    static string MarbleWidth { get; }
      Description: The property labeled "Vein Width" from the "Marble" schema.
    static string TextureAngle { get; }
      Description: The property labeled "Angle" from the "Marble" schema.
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link Transforms" from the "Marble" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "Marble" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "Marble" schema.
    static string TextureRealWorldOffsetZ { get; }
      Description: The property labeled "Offset Z" from the "Marble" schema.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MasonryCMU
Full Name: Autodesk.Revit.DB.Visual.MasonryCMU
Description: A static class that provides access to the property names that appear in the MasonryCMU visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "MasonryCMU" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "MasonryCMU" schema.
    static string MasonryCMUApplication { get; }
      Description: The property labeled "Finish" from the "MasonryCMU" schema.
    static string MasonryCMUColor { get; }
      Description: The property labeled "Color" from the "MasonryCMU" schema.
    static string MasonryCMUColorByObject { get; }
      Description: The property labeled "Color By Object" from the "MasonryCMU" schema.
    static string MasonryCMUPattern { get; }
      Description: The property labeled "Relief Pattern" from the "MasonryCMU" schema.
    static string MasonryCMUPatternHeight { get; }
      Description: The property labeled "Amount" from the "MasonryCMU" schema.
    static string MasonryCMUPatternMap { get; }
      Description: The property labeled "Image" from the "MasonryCMU" schema.
    static string MasonryCMUType { get; }
      Description: The property labeled "Type" from the "MasonryCMU" schema.

--------------------------------------------------------------------------------

[ENUM] MasonryCMUApplicationType
Full Name: Autodesk.Revit.DB.Visual.MasonryCMUApplicationType
Description: The enumerated type representing the permitted values for the asset property "MasonryCMUApplication" from the "MasonryCMU" schema.
Inherits: Enum

  Values:
    - Glossy = 0
    - Matte = 1
    - Unfinished = 2

--------------------------------------------------------------------------------

[ENUM] MasonryCMUPatternType
Full Name: Autodesk.Revit.DB.Visual.MasonryCMUPatternType
Description: The enumerated type representing the permitted values for the asset property "MasonryCMUPattern" from the "MasonryCMU" schema.
Inherits: Enum

  Values:
    - None = 0
    - Custom = 1

--------------------------------------------------------------------------------

[ENUM] MasonryCMUType
Full Name: Autodesk.Revit.DB.Visual.MasonryCMUType
Description: The enumerated type representing the permitted values for the asset property "MasonryCMUType" from the "MasonryCMU" schema.
Inherits: Enum

  Values:
    - Cmu = 0
    - Masonry = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Metal
Full Name: Autodesk.Revit.DB.Visual.Metal
Description: A static class that provides access to the property names that appear in the Metal visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "Metal" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "Metal" schema.
    static string MetalColor { get; }
      Description: The property labeled "Color" from the "Metal" schema.
    static string MetalFinish { get; }
      Description: The property labeled "Finish" from the "Metal" schema.
    static string MetalPatina { get; }
      Description: The property labeled "Patina" from the "Metal" schema.
    static string MetalPattern { get; }
      Description: The property labeled "Relief Pattern" from the "Metal" schema.
    static string MetalPatternHeight { get; }
      Description: The property labeled "Amount" from the "Metal" schema.
    static string MetalPatternScale { get; }
      Description: The property labeled "Scale" from the "Metal" schema.
    static string MetalPatternShader { get; }
      Description: The property labeled "Image" from the "Metal" schema.
    static string MetalPerforations { get; }
      Description: The property labeled "Cutouts" from the "Metal" schema.
    static string MetalPerforationsCenter { get; }
      Description: The property labeled "Center Spacing" from the "Metal" schema.
    static string MetalPerforationsShader { get; }
      Description: The property labeled "Image" from the "Metal" schema.
    static string MetalPerforationsSize { get; }
      Description: The property labeled "Diameter/Size" from the "Metal" schema.
    static string MetalType { get; }
      Description: The property labeled "Type" from the "Metal" schema.

--------------------------------------------------------------------------------

[ENUM] MetalFinishType
Full Name: Autodesk.Revit.DB.Visual.MetalFinishType
Description: The enumerated type representing the permitted values for the asset property "MetalFinish" from the "Metal" schema.
Inherits: Enum

  Values:
    - Polished = 0
    - SemiPolished = 1
    - Satin = 2
    - Brushed = 3

--------------------------------------------------------------------------------

[ABSTRACT CLASS] MetallicPaint
Full Name: Autodesk.Revit.DB.Visual.MetallicPaint
Description: A static class that provides access to the property names that appear in the MetallicPaint visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "MetallicPaint" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "MetallicPaint" schema.
    static string MetallicpaintBaseColor { get; }
      Description: The property labeled "Color" from the "MetallicPaint" schema.
    static string MetallicpaintBaseColorByObject { get; }
      Description: The property labeled "Color By Object" from the "MetallicPaint" schema.
    static string MetallicpaintBaseHighlightspread { get; }
      Description: The property labeled "Highlight Spread" from the "MetallicPaint" schema.
    static string MetallicpaintFinish { get; }
      Description: The property labeled "Finish" from the "MetallicPaint" schema.
    static string MetallicpaintFinishPeelamount { get; }
      Description: The property labeled "Amount" from the "MetallicPaint" schema.
    static string MetallicpaintFlecks { get; }
      Description: The property labeled "Flecks" from the "MetallicPaint" schema.
    static string MetallicpaintFlecksColor { get; }
      Description: The property labeled "Color" from the "MetallicPaint" schema.
    static string MetallicpaintFlecksColorByObject { get; }
      Description: The property labeled "Color By Object" from the "MetallicPaint" schema.
    static string MetallicpaintFlecksSize { get; }
      Description: The property labeled "Size" from the "MetallicPaint" schema.
    static string MetallicpaintPearl { get; }
      Description: The property labeled "Pearl" from the "MetallicPaint" schema.
    static string MetallicpaintPearlAmount { get; }
      Description: The property labeled "Amount" from the "MetallicPaint" schema.
    static string MetallicpaintPearlColor { get; }
      Description: The property labeled "Color" from the "MetallicPaint" schema.
    static string MetallicpaintPearlColorByObject { get; }
      Description: The property labeled "Color By Object" from the "MetallicPaint" schema.
    static string MetallicpaintPearlIor { get; }
      Description: The property labeled "Blend" from the "MetallicPaint" schema.
    static string MetallicpaintTopcoat { get; }
      Description: The property labeled "Top Coat" from the "MetallicPaint" schema.
    static string MetallicpaintTopcoatFalloff { get; }
      Description: The property labeled "Angle Falloff" from the "MetallicPaint" schema.
    static string MetallicpaintTopcoatGlossy { get; }
      Description: The property labeled "Glossiness" from the "MetallicPaint" schema.

--------------------------------------------------------------------------------

[ENUM] MetallicpaintFinishType
Full Name: Autodesk.Revit.DB.Visual.MetallicpaintFinishType
Description: The enumerated type representing the permitted values for the asset property "MetallicpaintFinish" from the "MetallicPaint" schema.
Inherits: Enum

  Values:
    - Smooth = 0
    - Peeling = 1

--------------------------------------------------------------------------------

[ENUM] MetallicpaintFlecksType
Full Name: Autodesk.Revit.DB.Visual.MetallicpaintFlecksType
Description: The enumerated type representing the permitted values for the asset property "MetallicpaintFlecks" from the "MetallicPaint" schema.
Inherits: Enum

  Values:
    - None = 0
    - Enable = 1

--------------------------------------------------------------------------------

[ENUM] MetallicpaintPearlType
Full Name: Autodesk.Revit.DB.Visual.MetallicpaintPearlType
Description: The enumerated type representing the permitted values for the asset property "MetallicpaintPearl" from the "MetallicPaint" schema.
Inherits: Enum

  Values:
    - None = 0
    - Chromatic = 1
    - Custom = 2

--------------------------------------------------------------------------------

[ENUM] MetallicpaintTopcoatType
Full Name: Autodesk.Revit.DB.Visual.MetallicpaintTopcoatType
Description: The enumerated type representing the permitted values for the asset property "MetallicpaintTopcoat" from the "MetallicPaint" schema.
Inherits: Enum

  Values:
    - Carpaint = 0
    - Chrome = 1
    - Matte = 2
    - Custom = 3

--------------------------------------------------------------------------------

[ENUM] MetalPatternType
Full Name: Autodesk.Revit.DB.Visual.MetalPatternType
Description: The enumerated type representing the permitted values for the asset property "MetalPattern" from the "Metal" schema.
Inherits: Enum

  Values:
    - None = 0
    - Knurl = 1
    - DiamondPlate = 2
    - CheckerPlate = 3
    - Custom = 4

--------------------------------------------------------------------------------

[ENUM] MetalPerforationsType
Full Name: Autodesk.Revit.DB.Visual.MetalPerforationsType
Description: The enumerated type representing the permitted values for the asset property "MetalPerforations" from the "Metal" schema.
Inherits: Enum

  Values:
    - None = 0
    - CirclesStaggered = 1
    - CirclesStraight = 2
    - Squares = 3
    - Grecian = 4
    - Cloverleaf = 5
    - Hexagon = 6
    - Custom = 7

--------------------------------------------------------------------------------

[ENUM] MetalType
Full Name: Autodesk.Revit.DB.Visual.MetalType
Description: The enumerated type representing the permitted values for the asset property "MetalType" from the "Metal" schema.
Inherits: Enum

  Values:
    - Aluminum = 0
    - GalvanizedAlu = 1
    - Chrome = 2
    - Copper = 3
    - Brass = 4
    - Bronze = 5
    - StainlessSteel = 6
    - Zinc = 7

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Mirror
Full Name: Autodesk.Revit.DB.Visual.Mirror
Description: A static class that provides access to the property names that appear in the Mirror visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "Mirror" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "Mirror" schema.
    static string MirrorColorByObject { get; }
      Description: The property labeled "Color By Object" from the "Mirror" schema.
    static string MirrorTintcolor { get; }
      Description: The property labeled "Color" from the "Mirror" schema.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Noise
Full Name: Autodesk.Revit.DB.Visual.Noise
Description: A static class that provides access to the property names that appear in the Noise visual asset schema.

  PROPERTIES:
    static string NoiseColor1 { get; }
      Description: The property labeled "Color 1" from the "Noise" schema.
    static string NoiseColor2 { get; }
      Description: The property labeled "Color 2" from the "Noise" schema.
    static string NoiseLevels { get; }
      Description: The property labeled "Levels" from the "Noise" schema.
    static string NoisePhase { get; }
      Description: The property labeled "Phase" from the "Noise" schema.
    static string NoiseSize { get; }
      Description: The property labeled "Size" from the "Noise" schema.
    static string NoiseThresholdHigh { get; }
      Description: The property labeled "High" from the "Noise" schema.
    static string NoiseThresholdLow { get; }
      Description: The property labeled "Low" from the "Noise" schema.
    static string NoiseType { get; }
      Description: The property labeled "Noise Type" from the "Noise" schema.
    static string TextureAngle { get; }
      Description: The property labeled "Angle" from the "Noise" schema.
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link Transforms" from the "Noise" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "Noise" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "Noise" schema.
    static string TextureRealWorldOffsetZ { get; }
      Description: The property labeled "Offset Z" from the "Noise" schema.

--------------------------------------------------------------------------------

[ENUM] NoiseType
Full Name: Autodesk.Revit.DB.Visual.NoiseType
Description: The enumerated type representing the permitted values for the asset property "NoiseType" from the "Noise" schema.
Inherits: Enum

  Values:
    - Regular = 0
    - Fractal = 1
    - Turbulence = 2

--------------------------------------------------------------------------------

[ABSTRACT CLASS] PlasticVinyl
Full Name: Autodesk.Revit.DB.Visual.PlasticVinyl
Description: A static class that provides access to the property names that appear in the PlasticVinyl visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "PlasticVinyl" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "PlasticVinyl" schema.
    static string PlasticvinylApplication { get; }
      Description: The property labeled "Finish" from the "PlasticVinyl" schema.
    static string PlasticvinylBump { get; }
      Description: The property labeled "Finish Bumps" from the "PlasticVinyl" schema.
    static string PlasticvinylBumpAmount { get; }
      Description: The property labeled "Amount" from the "PlasticVinyl" schema.
    static string PlasticvinylBumpMap { get; }
      Description: The property labeled "Image" from the "PlasticVinyl" schema.
    static string PlasticvinylColor { get; }
      Description: The property labeled "Color" from the "PlasticVinyl" schema.
    static string PlasticvinylColorByObject { get; }
      Description: The property labeled "Color By Object" from the "PlasticVinyl" schema.
    static string PlasticvinylPattern { get; }
      Description: The property labeled "Relief Pattern" from the "PlasticVinyl" schema.
    static string PlasticvinylPatternAmount { get; }
      Description: The property labeled "Amount" from the "PlasticVinyl" schema.
    static string PlasticvinylPatternMap { get; }
      Description: The property labeled "Image" from the "PlasticVinyl" schema.
    static string PlasticvinylType { get; }
      Description: The property labeled "Type" from the "PlasticVinyl" schema.

--------------------------------------------------------------------------------

[ENUM] PlasticvinylApplicationType
Full Name: Autodesk.Revit.DB.Visual.PlasticvinylApplicationType
Description: The enumerated type representing the permitted values for the asset property "PlasticvinylApplication" from the "PlasticVinyl" schema.
Inherits: Enum

  Values:
    - Polished = 0
    - Glossy = 1
    - Matte = 2

--------------------------------------------------------------------------------

[ENUM] PlasticvinylBumpType
Full Name: Autodesk.Revit.DB.Visual.PlasticvinylBumpType
Description: The enumerated type representing the permitted values for the asset property "PlasticvinylBump" from the "PlasticVinyl" schema.
Inherits: Enum

  Values:
    - None = 0
    - Custom = 1

--------------------------------------------------------------------------------

[ENUM] PlasticvinylPatternType
Full Name: Autodesk.Revit.DB.Visual.PlasticvinylPatternType
Description: The enumerated type representing the permitted values for the asset property "PlasticvinylPattern" from the "PlasticVinyl" schema.
Inherits: Enum

  Values:
    - None = 0
    - Custom = 1

--------------------------------------------------------------------------------

[ENUM] PlasticvinylType
Full Name: Autodesk.Revit.DB.Visual.PlasticvinylType
Description: The enumerated type representing the permitted values for the asset property "PlasticvinylType" from the "PlasticVinyl" schema.
Inherits: Enum

  Values:
    - Plasticsolid = 0
    - Plastictransparent = 1
    - Vinyl = 2

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SchemaCommon
Full Name: Autodesk.Revit.DB.Visual.SchemaCommon
Description: A static class that provides access to the property names that appear in all the visual Asset types.

  PROPERTIES:
    static string BaseSchema { get; }
      Description: The property labeled "BaseSchema" common to all visual Asset types.
    static string Category { get; }
      Description: The property labeled "Category" common to all visual Asset types.
    static string Description { get; }
      Description: The property labeled "Description" common to all visual Asset types.
    static string Hidden { get; }
      Description: The property labeled "Hidden" common to all visual Asset types.
    static string Keyword { get; }
      Description: The property labeled "Keyword" common to all visual Asset types.
    static string Thumbnail { get; }
      Description: The property labeled "Thumbnail" common to all visual Asset types.
    static string UIName { get; }
      Description: The property labeled "UIName" common to all visual Asset types.
    static string VersionGUID { get; }
      Description: The property labeled "VersionGUID" common to all visual Asset types.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] SolidGlass
Full Name: Autodesk.Revit.DB.Visual.SolidGlass
Description: A static class that provides access to the property names that appear in the SolidGlass visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "SolidGlass" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "SolidGlass" schema.
    static string SolidglassBumpAmount { get; }
      Description: The property labeled "Amount" from the "SolidGlass" schema.
    static string SolidglassBumpEnable { get; }
      Description: The property labeled "Type" from the "SolidGlass" schema.
    static string SolidglassBumpMap { get; }
      Description: The property labeled "Image" from the "SolidGlass" schema.
    static string SolidglassColorByObject { get; }
      Description: The property labeled "Custom Color" from the "SolidGlass" schema.
    static string SolidglassGlossiness { get; }
      Description: The property labeled "Roughness" from the "SolidGlass" schema.
    static string SolidglassReflectance { get; }
      Description: The property labeled "Reflectance" from the "SolidGlass" schema.
    static string SolidglassRefractionIor { get; }
      Description: The property labeled "Refraction" from the "SolidGlass" schema.
    static string SolidglassTransmittance { get; }
      Description: The property labeled "Color" from the "SolidGlass" schema.
    static string SolidglassTransmittanceCustomColor { get; }
      Description: The property labeled "Custom Color" from the "SolidGlass" schema.

--------------------------------------------------------------------------------

[ENUM] SolidglassBumpEnableType
Full Name: Autodesk.Revit.DB.Visual.SolidglassBumpEnableType
Description: The enumerated type representing the permitted values for the asset property "SolidglassBumpEnable" from the "SolidGlass" schema.
Inherits: Enum

  Values:
    - None = 0
    - Rippled = 1
    - Wavy = 2
    - Custom = 3

--------------------------------------------------------------------------------

[ENUM] SolidglassTransmittanceType
Full Name: Autodesk.Revit.DB.Visual.SolidglassTransmittanceType
Description: The enumerated type representing the permitted values for the asset property "SolidglassTransmittance" from the "SolidGlass" schema.
Inherits: Enum

  Values:
    - Clear = 0
    - Green = 1
    - Gray = 2
    - Blue = 3
    - Bluegreen = 4
    - Bronze = 5
    - CustomColor = 6

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Speckle
Full Name: Autodesk.Revit.DB.Visual.Speckle
Description: A static class that provides access to the property names that appear in the Speckle visual asset schema.

  PROPERTIES:
    static string SpeckleColor1 { get; }
      Description: The property labeled "Color 1" from the "Speckle" schema.
    static string SpeckleColor2 { get; }
      Description: The property labeled "Color 2" from the "Speckle" schema.
    static string SpeckleSize { get; }
      Description: The property labeled "Size" from the "Speckle" schema.
    static string TextureAngle { get; }
      Description: The property labeled "Angle" from the "Speckle" schema.
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link Transforms" from the "Speckle" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "Speckle" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "Speckle" schema.
    static string TextureRealWorldOffsetZ { get; }
      Description: The property labeled "Offset Z" from the "Speckle" schema.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Stone
Full Name: Autodesk.Revit.DB.Visual.Stone
Description: A static class that provides access to the property names that appear in the Stone visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "Stone" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "Stone" schema.
    static string StoneApplication { get; }
      Description: The property labeled "Finish" from the "Stone" schema.
    static string StoneBump { get; }
      Description: The property labeled "Type" from the "Stone" schema.
    static string StoneBumpAmount { get; }
      Description: The property labeled "Amount" from the "Stone" schema.
    static string StoneBumpMap { get; }
      Description: The property labeled "Image" from the "Stone" schema.
    static string StoneColor { get; }
      Description: The property labeled "Image" from the "Stone" schema.
    static string StonePattern { get; }
      Description: The property labeled "Relief Pattern" from the "Stone" schema.
    static string StonePatternAmount { get; }
      Description: The property labeled "Amount" from the "Stone" schema.
    static string StonePatternMap { get; }
      Description: The property labeled "Image" from the "Stone" schema.

--------------------------------------------------------------------------------

[ENUM] StoneApplicationType
Full Name: Autodesk.Revit.DB.Visual.StoneApplicationType
Description: The enumerated type representing the permitted values for the asset property "StoneApplication" from the "Stone" schema.
Inherits: Enum

  Values:
    - Polished = 0
    - Glossy = 1
    - Matte = 2
    - Unfinished = 3

--------------------------------------------------------------------------------

[ENUM] StoneBumpType
Full Name: Autodesk.Revit.DB.Visual.StoneBumpType
Description: The enumerated type representing the permitted values for the asset property "StoneBump" from the "Stone" schema.
Inherits: Enum

  Values:
    - None = 0
    - Polishedgranite = 1
    - Stonewall = 2
    - Glossymarble = 3
    - Custom = 4

--------------------------------------------------------------------------------

[ENUM] StonePatternType
Full Name: Autodesk.Revit.DB.Visual.StonePatternType
Description: The enumerated type representing the permitted values for the asset property "StonePattern" from the "Stone" schema.
Inherits: Enum

  Values:
    - None = 0
    - Custom = 1

--------------------------------------------------------------------------------

[ENUM] SurfaceNdfType
Full Name: Autodesk.Revit.DB.Visual.SurfaceNdfType
Description: The enumerated type representing the permitted values for the asset property "SurfaceNdfType" from the "AdvancedLayered" schema.
Inherits: Enum

  Values:
    - Beckmann = 0
    - Ggx = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Tile
Full Name: Autodesk.Revit.DB.Visual.Tile
Description: A static class that provides access to the property names that appear in the Tile visual asset schema.

  PROPERTIES:
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link Transforms" from the "Tile" schema.
    static string TextureOffsetLock { get; }
      Description: The property labeled "Offset Lock" from the "Tile" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "Tile" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "Tile" schema.
    static string TextureRealWorldScaleX { get; }
      Description: The property labeled "Size X" from the "Tile" schema.
    static string TextureRealWorldScaleY { get; }
      Description: The property labeled "Size Y" from the "Tile" schema.
    static string TextureScaleLock { get; }
      Description: The property labeled "Scale Lock" from the "Tile" schema.
    static string TextureURepeat { get; }
      Description: The property labeled "U Repeat" from the "Tile" schema.
    static string TextureVRepeat { get; }
      Description: The property labeled "V Repeat" from the "Tile" schema.
    static string TextureWAngle { get; }
      Description: The property labeled "Angle" from the "Tile" schema.
    static string TileBrickColor { get; }
      Description: The property labeled "Tile Color" from the "Tile" schema.
    static string TileBrickType { get; }
      Description: The property labeled "Type" from the "Tile" schema.
    static string TileChangeColumn { get; }
      Description: The property labeled "Amount" from the "Tile" schema.
    static string TileChangeRow { get; }
      Description: The property labeled "Amount" from the "Tile" schema.
    static string TileColorVariance { get; }
      Description: The property labeled "Color Variance" from the "Tile" schema.
    static string TileEdgeRoughness { get; }
      Description: The property labeled "Roughness" from the "Tile" schema.
    static string TileFadeVariance { get; }
      Description: The property labeled "Fade Variance" from the "Tile" schema.
    static string TileHorizontalCount { get; }
      Description: The property labeled "Tile Count" from the "Tile" schema.
    static string TileHorizontalGap { get; }
      Description: The property labeled "Gap Width" from the "Tile" schema.
    static string TileLineShift { get; }
      Description: The property labeled "Line Shift" from the "Tile" schema.
    static string TileMortarColor { get; }
      Description: The property labeled "Grout Color" from the "Tile" schema.
    static string TilePerColumn { get; }
      Description: The property labeled "Every" from the "Tile" schema.
    static string TilePerRow { get; }
      Description: The property labeled "Every" from the "Tile" schema.
    static string TileRandomSeed { get; }
      Description: The property labeled "Randomize" from the "Tile" schema.
    static string TileRandomShift { get; }
      Description: The property labeled "Random" from the "Tile" schema.
    static string TileUseColumnEdit { get; }
      Description: The property labeled "Column Modify" from the "Tile" schema.
    static string TileUseRowEdit { get; }
      Description: The property labeled "Row Modify" from the "Tile" schema.
    static string TileVerticalCount { get; }
      Description: The property labeled "tile_VerticalCount" from the "Tile" schema.
    static string TileVerticalGap { get; }
      Description: The property labeled "Vert" from the "Tile" schema.

--------------------------------------------------------------------------------

[ENUM] TileBrickType
Full Name: Autodesk.Revit.DB.Visual.TileBrickType
Description: The enumerated type representing the permitted values for the asset property "TileBrickType" from the "Tile" schema.
Inherits: Enum

  Values:
    - RunningBond = 0
    - CommonFlemishBond = 1
    - EnglishBond = 2
    - HalfRunningBond = 3
    - StackBond = 4
    - FineRunningBond = 5
    - FineStackBond = 6
    - Custom = 7

--------------------------------------------------------------------------------

[ABSTRACT CLASS] UnifiedBitmap
Full Name: Autodesk.Revit.DB.Visual.UnifiedBitmap
Description: A static class that provides access to the property names that appear in the UnifiedBitmap visual asset schema.

  PROPERTIES:
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link texture Transforms" from the "UnifiedBitmap" schema.
    static string TextureOffsetLock { get; }
      Description: The property labeled "Offset Lock" from the "UnifiedBitmap" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "UnifiedBitmap" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "UnifiedBitmap" schema.
    static string TextureRealWorldScaleX { get; }
      Description: The property labeled "Size X" from the "UnifiedBitmap" schema.
    static string TextureRealWorldScaleY { get; }
      Description: The property labeled "Size Y" from the "UnifiedBitmap" schema.
    static string TextureScaleLock { get; }
      Description: The property labeled "Scale Lock" from the "UnifiedBitmap" schema.
    static string TextureURepeat { get; }
      Description: The property labeled "U Repeat" from the "UnifiedBitmap" schema.
    static string TextureVRepeat { get; }
      Description: The property labeled "V Repeat" from the "UnifiedBitmap" schema.
    static string TextureWAngle { get; }
      Description: The property labeled "Angle" from the "UnifiedBitmap" schema.
    static string UnifiedbitmapBitmap { get; }
      Description: The property labeled "Source" from the "UnifiedBitmap" schema.
    static string UnifiedbitmapInvert { get; }
      Description: The property labeled "Invert Image" from the "UnifiedBitmap" schema.
    static string UnifiedbitmapRGBAmount { get; }
      Description: The property labeled "Brightness" from the "UnifiedBitmap" schema.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] WallPaint
Full Name: Autodesk.Revit.DB.Visual.WallPaint
Description: A static class that provides access to the property names that appear in the WallPaint visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "WallPaint" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "WallPaint" schema.
    static string WallpaintApplication { get; }
      Description: The property labeled "Application" from the "WallPaint" schema.
    static string WallpaintColor { get; }
      Description: The property labeled "Color" from the "WallPaint" schema.
    static string WallpaintFinish { get; }
      Description: The property labeled "Finish" from the "WallPaint" schema.

--------------------------------------------------------------------------------

[ENUM] WallpaintApplicationType
Full Name: Autodesk.Revit.DB.Visual.WallpaintApplicationType
Description: The enumerated type representing the permitted values for the asset property "WallpaintApplication" from the "WallPaint" schema.
Inherits: Enum

  Values:
    - Roller = 0
    - Brush = 1
    - Spray = 2

--------------------------------------------------------------------------------

[ENUM] WallpaintFinishType
Full Name: Autodesk.Revit.DB.Visual.WallpaintFinishType
Description: The enumerated type representing the permitted values for the asset property "WallpaintFinish" from the "WallPaint" schema.
Inherits: Enum

  Values:
    - Flat = 0
    - Eggshell = 1
    - Platinum = 2
    - Pearl = 3
    - Semigloss = 4
    - Gloss = 5

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Water
Full Name: Autodesk.Revit.DB.Visual.Water
Description: A static class that provides access to the property names that appear in the Water visual asset schema.

  PROPERTIES:
    static string CommonTintColor { get; }
      Description: The property labeled "Tint Color" from the "Water" schema.
    static string CommonTintToggle { get; }
      Description: The property labeled "Tint" from the "Water" schema.
    static string WaterBumpAmount { get; }
      Description: The property labeled "Wave Height" from the "Water" schema.
    static string WaterColorByObject { get; }
      Description: The property labeled "Custom Color" from the "Water" schema.
    static string WaterTintColor { get; }
      Description: The property labeled "Custom Color" from the "Water" schema.
    static string WaterTintEnable { get; }
      Description: The property labeled "Color" from the "Water" schema.
    static string WaterType { get; }
      Description: The property labeled "Type" from the "Water" schema.

--------------------------------------------------------------------------------

[ENUM] WaterTintEnableType
Full Name: Autodesk.Revit.DB.Visual.WaterTintEnableType
Description: The enumerated type representing the permitted values for the asset property "WaterTintEnable" from the "Water" schema.
Inherits: Enum

  Values:
    - Tropical = 0
    - Algae = 1
    - Murky = 2
    - ReflectingPool = 3
    - River = 4
    - Lake = 5
    - Ocean = 6
    - Custom = 7

--------------------------------------------------------------------------------

[ENUM] WaterType
Full Name: Autodesk.Revit.DB.Visual.WaterType
Description: The enumerated type representing the permitted values for the asset property "WaterType" from the "Water" schema.
Inherits: Enum

  Values:
    - SwimmingPool = 0
    - ReflectingPool = 1
    - River = 2
    - Lake = 3
    - Ocean = 4

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Wave
Full Name: Autodesk.Revit.DB.Visual.Wave
Description: A static class that provides access to the property names that appear in the Wave visual asset schema.

  PROPERTIES:
    static string TextureAngle { get; }
      Description: The property labeled "Angle" from the "Wave" schema.
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link Transforms" from the "Wave" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "Wave" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "Wave" schema.
    static string TextureRealWorldOffsetZ { get; }
      Description: The property labeled "Offset Z" from the "Wave" schema.
    static string WaveAmplitude { get; }
      Description: The property labeled "Amplitude" from the "Wave" schema.
    static string WaveColor1 { get; }
      Description: The property labeled "Color 1" from the "Wave" schema.
    static string WaveColor2 { get; }
      Description: The property labeled "Color 2" from the "Wave" schema.
    static string WaveDistribution { get; }
      Description: The property labeled "Distribution" from the "Wave" schema.
    static string WaveNumWaveSets { get; }
      Description: The property labeled "Number" from the "Wave" schema.
    static string WavePhase { get; }
      Description: The property labeled "Phase" from the "Wave" schema.
    static string WaveRandomSeed { get; }
      Description: The property labeled "Random Seed" from the "Wave" schema.
    static string WaveWaveLenMax { get; }
      Description: The property labeled "Len Max" from the "Wave" schema.
    static string WaveWaveLenMin { get; }
      Description: The property labeled "Len Min" from the "Wave" schema.
    static string WaveWaveRadius { get; }
      Description: The property labeled "Radius" from the "Wave" schema.

--------------------------------------------------------------------------------

[ENUM] WaveDistributionType
Full Name: Autodesk.Revit.DB.Visual.WaveDistributionType
Description: The enumerated type representing the permitted values for the asset property "WaveDistribution" from the "Wave" schema.
Inherits: Enum

  Values:
    - TwoD = 0
    - ThreeD = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] Wood
Full Name: Autodesk.Revit.DB.Visual.Wood
Description: A static class that provides access to the property names that appear in the Wood visual asset schema.

  PROPERTIES:
    static string TextureAngle { get; }
      Description: The property labeled "Angle" from the "Wood" schema.
    static string TextureLinkTextureTransforms { get; }
      Description: The property labeled "Link Transforms" from the "Wood" schema.
    static string TextureRealWorldOffsetX { get; }
      Description: The property labeled "Offset X" from the "Wood" schema.
    static string TextureRealWorldOffsetY { get; }
      Description: The property labeled "Offset Y" from the "Wood" schema.
    static string TextureRealWorldOffsetZ { get; }
      Description: The property labeled "Offset Z" from the "Wood" schema.
    static string WoodAxialNoise { get; }
      Description: The property labeled "Axial Noise" from the "Wood" schema.
    static string WoodColor1 { get; }
      Description: The property labeled "Color 1" from the "Wood" schema.
    static string WoodColor2 { get; }
      Description: The property labeled "Color 2" from the "Wood" schema.
    static string WoodRadialNoise { get; }
      Description: The property labeled "Radial Noise" from the "Wood" schema.
    static string WoodThickness { get; }
      Description: The property labeled "Grain Thickness" from the "Wood" schema.

--------------------------------------------------------------------------------

[ENUM] WoodPoreType
Full Name: Autodesk.Revit.DB.Visual.WoodPoreType
Description: The enumerated type representing the permitted values for the asset property "WoodPoreType" from the "AdvancedLayered" schema.
Inherits: Enum

  Values:
    - InBothWoods = 0
    - EarlywoodOnly = 1
    - LatewoodOnly = 2

--------------------------------------------------------------------------------

