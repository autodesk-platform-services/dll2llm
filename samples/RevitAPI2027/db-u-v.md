# Autodesk.Revit.DB

NAMESPACE: Autodesk.Revit.DB
--------------------------------------------------------------------------------

[ENUM] UnderlayOrientation
Full Name: Autodesk.Revit.DB.UnderlayOrientation
Description: Indicates how elements in the underlay are viewed.
Inherits: Enum

  Values:
    - LookingDown = 0
    - LookingUp = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] UnitFormatUtils
Full Name: Autodesk.Revit.DB.UnitFormatUtils
Description: A utility class for formatting and parsing numbers with units.

  METHODS:
    static string Format(Units units, ForgeTypeId specTypeId, double value, bool forEditing)
      Description: Formats a number with units into a string.
      @units: The units formatting settings, typically obtained from GetUnits.
      @specTypeId: Identifier of the spec of the value to format.
      @value: The value to format, in Revit's internal units.
      @forEditing: True if the formatting should be modified as necessary so that the formatted string can be successfully parsed, for example by suppressing digit grouping. False if unmodified settings should be used, suitable for display only.
      Returns: The formatted string.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId). -or- The given value for value is not finite
      Throws ArgumentNullException: A non-optional argument was null
    static string Format(Units units, ForgeTypeId specTypeId, double value, bool forEditing, FormatValueOptions formatValueOptions)
      Description: Formats a number with units into a string.
      @units: The units formatting settings, typically obtained from GetUnits.
      @specTypeId: Identifier of the spec of the value to format.
      @value: The value to format, in Revit's internal units.
      @forEditing: True if the formatting should be modified as necessary so that the formatted string can be successfully parsed, for example by suppressing digit grouping. False if unmodified settings should be used, suitable for display only.
      @formatValueOptions: Additional formatting options.
      Returns: The formatted string.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId). -or- The given value for value is not finite -or- The unit in the FormatOptions in formatValueOptions is not a valid unit for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, out double value, out string message)
      Description: Parses a formatted string into a number with units if possible.
      @units: The units formatting settings, typically obtained from GetUnits.
      @specTypeId: Identifier of the target spec for the value.
      @stringToParse: The string to parse.
      @value: The parsed value. Ignore this value if the function returns false.
      @message: A localized message that, if the parsing fails, explains the reason for failure.
      Returns: True if the string can be parsed, false otherwise.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, out double value)
      Description: Parses a formatted string into a number with units if possible.
      @units: The units formatting settings, typically obtained from GetUnits.
      @specTypeId: Identifier of the target spec for the value.
      @stringToParse: The string to parse.
      @value: The parsed value. Ignore this value if the function returns false.
      Returns: True if the string can be parsed, false otherwise.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, ValueParsingOptions valueParsingOptions, out double value, out string message)
      Description: Parses a formatted string into a number with units if possible.
      @units: The units formatting settings, typically obtained from GetUnits.
      @specTypeId: Identifier of the target spec for the value.
      @stringToParse: The string to parse.
      @valueParsingOptions: Additional parsing options.
      @value: The parsed value. Ignore this value if the function returns false.
      @message: A localized message that, if the parsing fails, explains the reason for failure.
      Returns: True if the string can be parsed, false otherwise.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId). -or- The unit in the FormatOptions in valueParsingOptions is not a valid unit for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static bool TryParse(Units units, ForgeTypeId specTypeId, string stringToParse, ValueParsingOptions valueParsingOptions, out double value)
      Description: Parses a formatted string into a number with units if possible.
      @units: The units formatting settings, typically obtained from GetUnits.
      @specTypeId: Identifier of the target spec for the value.
      @stringToParse: The string to parse.
      @valueParsingOptions: Additional parsing options.
      @value: The parsed value. Ignore this value if the function returns false.
      Returns: True if the string can be parsed, false otherwise.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId). -or- The unit in the FormatOptions in valueParsingOptions is not a valid unit for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] Units
Full Name: Autodesk.Revit.DB.Units
Description: A document's default settings for formatting numbers with units.
Remarks: The Units class represents a document's default settings for formatting numbers with units as strings. It contains a FormatOptions object for each unit type as well as settings related to decimal symbol and digit grouping. The Units class stores a FormatOptions object for every valid unit type, but not all of them can be directly modified. Some, like UT_Number and UT_SiteAngle, have fixed definitions. Others have definitions which are automatically derived from other unit types. For example, UT_SheetLength is derived from UT_Length and UT_ForceScale is derived from UT_Force. See IsModifiableUnitType and GetModifiableUnitTypes.
Implements: IDisposable

  CONSTRUCTORS:
    new Units(UnitSystem unitSystem)
      Description: Creates a new Units object with default settings for Metric or Imperial units.
      @unitSystem: Indicates whether the Units object should be initialized with default settings for Metric or Imperial units.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

  PROPERTIES:
    DecimalSymbol DecimalSymbol { get; set; }
      Description: The symbol used to separate the integer and fractional parts of a number.
    DigitGroupingAmount DigitGroupingAmount { get; set; }
      Description: The number of digits in each group when numbers are formatted with digit grouping.
    DigitGroupingSymbol DigitGroupingSymbol { get; set; }
      Description: The symbol used to separate groups of digits when numbers are formatted with digit grouping.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    FormatOptions GetFormatOptions(ForgeTypeId specTypeId)
      Description: Gets the default FormatOptions for a spec.
      @specTypeId: Identifier of the spec.
      Returns: A copy of the FormatOptions.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ForgeTypeId> GetModifiableSpecs()
      Description: Gets all specs for which the default FormatOptions can be modified.
      Returns: Identifiers of the specs for which the FormatOptions can be modified.
    static bool IsModifiableSpec(ForgeTypeId specTypeId)
      Description: Checks whether the default FormatOptions can be modified for a given spec.
      @specTypeId: Identifier of the spec to check.
      Returns: True if the FormatOptions can be modified, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetFormatOptions(ForgeTypeId specTypeId, FormatOptions options)
      Description: Sets the default FormatOptions for a spec.
      @specTypeId: Identifier of the spec.
      @options: The FormatOptions.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId). -or- FormatOptions cannot be modified for specTypeId. See Units.IsModifiableSpec(ForgeTypeId) and Units.GetModifiableSpecs(). -or- UseDefault is true in options. -or- The unit in options is not valid for specTypeId. See UnitUtils.IsValidUnit(ForgeTypeId, ForgeTypeId) and UnitUtils.GetValidUnits(ForgeTypeId). -or- The rounding method in options is not set to Nearest.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] UnitSystem
Full Name: Autodesk.Revit.DB.UnitSystem
Description: A system of measurement: Metric or Imperial units.
Inherits: Enum

  Values:
    - Metric = 0
    - Imperial = 1

--------------------------------------------------------------------------------

[ABSTRACT CLASS] UnitTypeId
Full Name: Autodesk.Revit.DB.UnitTypeId
Description: This class contains constants identifying units of measurement.

  PROPERTIES:
    static ForgeTypeId Acres { get; }
      Description: Acres.
    static ForgeTypeId Amperes { get; }
      Description: Amperes.
    static ForgeTypeId Atmospheres { get; }
      Description: Atmospheres.
    static ForgeTypeId Bars { get; }
      Description: Bars.
    static ForgeTypeId BritishThermalUnits { get; }
      Description: British thermal units.
    static ForgeTypeId BritishThermalUnitsPerDegreeFahrenheit { get; }
      Description: British thermal units per degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerHour { get; }
      Description: British thermal units per hour.
    static ForgeTypeId BritishThermalUnitsPerHourCubicFoot { get; }
      Description: British thermal units per hour cubic foot.
    static ForgeTypeId BritishThermalUnitsPerHourFootDegreeFahrenheit { get; }
      Description: British thermal units per hour foot degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerHourSquareFoot { get; }
      Description: British thermal units per hour square foot.
    static ForgeTypeId BritishThermalUnitsPerHourSquareFootDegreeFahrenheit { get; }
      Description: British thermal units per hour square foot degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerPound { get; }
      Description: British thermal units per pound.
    static ForgeTypeId BritishThermalUnitsPerPoundDegreeFahrenheit { get; }
      Description: British thermal units per pound degree Fahrenheit.
    static ForgeTypeId BritishThermalUnitsPerSecond { get; }
      Description: British thermal units per second.
    static ForgeTypeId BritishThermalUnitsPerSquareFootDegreeFahrenheit { get; }
      Description: British thermal units per square foot degree Fahrenheit.
    static ForgeTypeId Calories { get; }
      Description: Calories.
    static ForgeTypeId CaloriesPerSecond { get; }
      Description: Calories per second.
    static ForgeTypeId Candelas { get; }
      Description: Candelas.
    static ForgeTypeId CandelasPerSquareFoot { get; }
      Description: Candelas per square foot.
    static ForgeTypeId CandelasPerSquareMeter { get; }
      Description: Candelas per square meter.
    static ForgeTypeId Celsius { get; }
      Description: Celsius.
    static ForgeTypeId CelsiusInterval { get; }
      Description: Celsius interval.
    static ForgeTypeId Centimeters { get; }
      Description: Centimeters.
    static ForgeTypeId CentimetersPerMinute { get; }
      Description: Centimeters per minute.
    static ForgeTypeId CentimetersToTheFourthPower { get; }
      Description: Centimeters to the fourth power.
    static ForgeTypeId CentimetersToTheSixthPower { get; }
      Description: Centimeters to the sixth power.
    static ForgeTypeId Centipoises { get; }
      Description: Centipoises.
    static ForgeTypeId CubicCentimeters { get; }
      Description: Cubic centimeters.
    static ForgeTypeId CubicFeet { get; }
      Description: Cubic feet.
    static ForgeTypeId CubicFeetPerHour { get; }
      Description: Cubic feet per hour.
    static ForgeTypeId CubicFeetPerKip { get; }
      Description: Cubic feet per kip.
    static ForgeTypeId CubicFeetPerMinute { get; }
      Description: Cubic feet per minute.
    static ForgeTypeId CubicFeetPerMinuteCubicFoot { get; }
      Description: Cubic feet per minute cubic foot.
    static ForgeTypeId CubicFeetPerMinutePerBritishThermalUnitPerHour { get; }
      Description: Cubic feet per minute per British thermal unit per hour.
    static ForgeTypeId CubicFeetPerMinuteSquareFoot { get; }
      Description: Cubic feet per minute square foot.
    static ForgeTypeId CubicFeetPerMinuteTonOfRefrigeration { get; }
      Description: Cubic feet per minute ton of refrigeration.
    static ForgeTypeId CubicFeetPerPoundMass { get; }
      Description: Cubic feet per pound mass.
    static ForgeTypeId CubicInches { get; }
      Description: Cubic inches.
    static ForgeTypeId CubicMeters { get; }
      Description: Cubic meters.
    static ForgeTypeId CubicMetersPerHour { get; }
      Description: Cubic meters per hour.
    static ForgeTypeId CubicMetersPerHourCubicMeter { get; }
      Description: Cubic meters per hour cubic meter.
    static ForgeTypeId CubicMetersPerHourSquareMeter { get; }
      Description: Cubic meters per hour square meter.
    static ForgeTypeId CubicMetersPerKilogram { get; }
      Description: Cubic meters per kilogram.
    static ForgeTypeId CubicMetersPerKilonewton { get; }
      Description: Cubic meters per kilonewton.
    static ForgeTypeId CubicMetersPerSecond { get; }
      Description: Cubic meters per second.
    static ForgeTypeId CubicMetersPerWattSecond { get; }
      Description: Cubic meters per watt second.
    static ForgeTypeId CubicMillimeters { get; }
      Description: Cubic millimeters.
    static ForgeTypeId CubicYards { get; }
      Description: Cubic yards.
    static ForgeTypeId Currency { get; }
      Description: Currency.
    static ForgeTypeId CurrencyPerBritishThermalUnit { get; }
      Description: Cost per British thermal unit.
    static ForgeTypeId CurrencyPerBritishThermalUnitPerHour { get; }
      Description: Cost per British thermal unit per hour.
    static ForgeTypeId CurrencyPerSquareFoot { get; }
      Description: Cost per square foot.
    static ForgeTypeId CurrencyPerSquareMeter { get; }
      Description: Cost per square meter.
    static ForgeTypeId CurrencyPerWatt { get; }
      Description: Cost per watt.
    static ForgeTypeId CurrencyPerWattHour { get; }
      Description: Cost per watt hour.
    static ForgeTypeId Custom { get; }
      Description: Unrecognized custom unit.
    static ForgeTypeId CyclesPerSecond { get; }
      Description: Cycles per second.
    static ForgeTypeId Decimeters { get; }
      Description: Decimeters.
    static ForgeTypeId Degrees { get; }
      Description: Degrees.
    static ForgeTypeId DegreesMinutes { get; }
      Description: Degrees minutes seconds.
    static ForgeTypeId DekanewtonMeters { get; }
      Description: Dekanewton meters.
    static ForgeTypeId DekanewtonMetersPerMeter { get; }
      Description: Dekanewton meters per meter.
    static ForgeTypeId Dekanewtons { get; }
      Description: Dekanewtons.
    static ForgeTypeId DekanewtonsPerMeter { get; }
      Description: Dekanewtons per meter.
    static ForgeTypeId DekanewtonsPerSquareMeter { get; }
      Description: Dekanewtons per square meter.
    static ForgeTypeId Fahrenheit { get; }
      Description: Fahrenheit.
    static ForgeTypeId FahrenheitInterval { get; }
      Description: Fahrenheit interval.
    static ForgeTypeId Feet { get; }
      Description: Feet.
    static ForgeTypeId FeetFractionalInches { get; }
      Description: Feet and fractional inches.
    static ForgeTypeId FeetOfWater39_2DegreesFahrenheit { get; }
      Description: Feet of water (39.2 Â°F).
    static ForgeTypeId FeetOfWater39_2DegreesFahrenheitPer100Feet { get; }
      Description: Feet of water (39.2 Â°F) per 100 feet.
    static ForgeTypeId FeetPerKip { get; }
      Description: Feet per kip.
    static ForgeTypeId FeetPerMinute { get; }
      Description: Feet per minute.
    static ForgeTypeId FeetPerSecond { get; }
      Description: Feet per second.
    static ForgeTypeId FeetPerSecondSquared { get; }
      Description: Feet per second squared.
    static ForgeTypeId FeetToTheFourthPower { get; }
      Description: Feet to the fourth power.
    static ForgeTypeId FeetToTheSixthPower { get; }
      Description: Feet to the sixth power.
    static ForgeTypeId Fixed { get; }
      Description: Fixed.
    static ForgeTypeId Footcandles { get; }
      Description: Footcandles.
    static ForgeTypeId Footlamberts { get; }
      Description: Footlamberts.
    static ForgeTypeId FractionalInches { get; }
      Description: Fractional inches.
    static ForgeTypeId General { get; }
      Description: General.
    static ForgeTypeId Gigajoules { get; }
      Description: Gigajoules.
    static ForgeTypeId Gradians { get; }
      Description: Gradians.
    static ForgeTypeId GrainsPerHourSquareFootInchMercury { get; }
      Description: Grains per hour square foot inch mercury.
    static ForgeTypeId Hectares { get; }
      Description: Hectares.
    static ForgeTypeId Hertz { get; }
      Description: Hertz.
    static ForgeTypeId Horsepower { get; }
      Description: Horsepower.
    static ForgeTypeId Hours { get; }
      Description: Hours.
    static ForgeTypeId HourSquareFootDegreesFahrenheitPerBritishThermalUnit { get; }
      Description: Hour square foot degrees Fahrenheit per British thermal unit.
    static ForgeTypeId Inches { get; }
      Description: Inches.
    static ForgeTypeId InchesOfMercury32DegreesFahrenheit { get; }
      Description: Inches of mercury (32 Â°F).
    static ForgeTypeId InchesOfWater60DegreesFahrenheit { get; }
      Description: Inches of water (60 Â°F).
    static ForgeTypeId InchesOfWater60DegreesFahrenheitPer100Feet { get; }
      Description: Inches of water (60 Â°F) per 100 feet.
    static ForgeTypeId InchesPerSecondSquared { get; }
      Description: Inches per second squared.
    static ForgeTypeId InchesToTheFourthPower { get; }
      Description: Inches to the fourth power.
    static ForgeTypeId InchesToTheSixthPower { get; }
      Description: Inches to the sixth power.
    static ForgeTypeId InverseDegreesCelsius { get; }
      Description: Inverse degrees Celsius.
    static ForgeTypeId InverseDegreesFahrenheit { get; }
      Description: Inverse degrees Fahrenheit.
    static ForgeTypeId InverseKilonewtons { get; }
      Description: Inverse kilonewtons.
    static ForgeTypeId InverseKips { get; }
      Description: Inverse kips.
    static ForgeTypeId Joules { get; }
      Description: Joules.
    static ForgeTypeId JoulesPerGram { get; }
      Description: Joules per gram.
    static ForgeTypeId JoulesPerGramDegreeCelsius { get; }
      Description: Joules per gram degree Celsius.
    static ForgeTypeId JoulesPerKelvin { get; }
      Description: Joules per Kelvin.
    static ForgeTypeId JoulesPerKilogramDegreeCelsius { get; }
      Description: Joules per kilogram degree Celsius.
    static ForgeTypeId JoulesPerSquareMeterKelvin { get; }
      Description: Joules per square meter Kelvin.
    static ForgeTypeId Kelvin { get; }
      Description: Kelvin.
    static ForgeTypeId KelvinInterval { get; }
      Description: Kelvin interval.
    static ForgeTypeId Kiloamperes { get; }
      Description: Kiloamperes.
    static ForgeTypeId Kilocalories { get; }
      Description: Kilocalories.
    static ForgeTypeId KilocaloriesPerSecond { get; }
      Description: Kilocalories per second.
    static ForgeTypeId KilogramForceMeters { get; }
      Description: Kilogram force meters.
    static ForgeTypeId KilogramForceMetersPerMeter { get; }
      Description: Kilogram force meters per meter.
    static ForgeTypeId Kilograms { get; }
      Description: Kilograms.
    static ForgeTypeId KilogramsCarbonDioxidePerBritishThermalUnit { get; }
      Description: kilograms of carbon dioxide per Btu.
    static ForgeTypeId KilogramsCarbonDioxidePerCubicFoot { get; }
      Description: kilograms carbon dioxide per cubic foot.
    static ForgeTypeId KilogramsCarbonDioxidePerCubicMeter { get; }
      Description: kilograms carbon dioxide per cubic meter.
    static ForgeTypeId KilogramsCarbonDioxidePerFoot { get; }
      Description: kilograms carbon dioxide per foot.
    static ForgeTypeId KilogramsCarbonDioxidePerItem { get; }
      Description: kilograms carbon dioxide per item.
    static ForgeTypeId KilogramsCarbonDioxidePerKilogram { get; }
      Description: kilograms carbon dioxide per kilogram.
    static ForgeTypeId KilogramsCarbonDioxidePerKilowattHour { get; }
      Description: kilograms carbon dioxide per kilowatt hour.
    static ForgeTypeId KilogramsCarbonDioxidePerMegawattHour { get; }
      Description: kilograms carbon dioxide per megawatt hour.
    static ForgeTypeId KilogramsCarbonDioxidePerMeter { get; }
      Description: kilograms carbon dioxide per meter.
    static ForgeTypeId KilogramsCarbonDioxidePerMillionBritishThermalUnits { get; }
      Description: kilograms carbon dioxide per cubic foot MBtu.
    static ForgeTypeId KilogramsCarbonDioxidePerPound { get; }
      Description: kilograms carbon dioxide per pound.
    static ForgeTypeId KilogramsCarbonDioxidePerSquareFoot { get; }
      Description: kilograms carbon dioxide per square foot.
    static ForgeTypeId KilogramsCarbonDioxidePerSquareMeter { get; }
      Description: kilograms carbon dioxide per square meter.
    static ForgeTypeId KilogramsCarbonDioxidePerThousandBritishThermalUnits { get; }
      Description: kilograms carbon dioxide per kBtu.
    static ForgeTypeId KilogramsForce { get; }
      Description: Kilograms force.
    static ForgeTypeId KilogramsForcePerMeter { get; }
      Description: Kilograms force per meter.
    static ForgeTypeId KilogramsForcePerSquareMeter { get; }
      Description: Kilograms force per square meter.
    static ForgeTypeId KilogramsPerCubicMeter { get; }
      Description: Kilograms per cubic meter.
    static ForgeTypeId KilogramsPerHour { get; }
      Description: Kilograms per hour.
    static ForgeTypeId KilogramsPerKilogramKelvin { get; }
      Description: Kilograms per kilogram kelvin.
    static ForgeTypeId KilogramsPerMeter { get; }
      Description: Kilograms per meter.
    static ForgeTypeId KilogramsPerMeterHour { get; }
      Description: Kilograms per meter hour.
    static ForgeTypeId KilogramsPerMeterSecond { get; }
      Description: Kilograms per meter second.
    static ForgeTypeId KilogramsPerMinute { get; }
      Description: Kilograms per minute.
    static ForgeTypeId KilogramsPerSecond { get; }
      Description: Kilograms per second.
    static ForgeTypeId KilogramsPerSquareMeter { get; }
      Description: Kilograms per square meter.
    static ForgeTypeId Kilojoules { get; }
      Description: Kilojoules.
    static ForgeTypeId KilojoulesPerKelvin { get; }
      Description: Kilojoules per Kelvin.
    static ForgeTypeId KilojoulesPerSquareMeterKelvin { get; }
      Description: Kilojoules per square meter Kelvin.
    static ForgeTypeId KilometersPerHour { get; }
      Description: Kilometers per hour.
    static ForgeTypeId KilometersPerSecondSquared { get; }
      Description: Kilometers per second squared.
    static ForgeTypeId KilonewtonMeters { get; }
      Description: Kilonewton meters.
    static ForgeTypeId KilonewtonMetersPerDegree { get; }
      Description: Kilonewton meters per degree.
    static ForgeTypeId KilonewtonMetersPerDegreePerMeter { get; }
      Description: Kilonewton meters per degree per meter.
    static ForgeTypeId KilonewtonMetersPerMeter { get; }
      Description: Kilonewton meters per meter.
    static ForgeTypeId Kilonewtons { get; }
      Description: Kilonewtons.
    static ForgeTypeId KilonewtonsPerCubicMeter { get; }
      Description: Kilonewtons per cubic meter.
    static ForgeTypeId KilonewtonsPerMeter { get; }
      Description: Kilonewtons per meter.
    static ForgeTypeId KilonewtonsPerSquareCentimeter { get; }
      Description: Kilonewtons per square centimeter.
    static ForgeTypeId KilonewtonsPerSquareMeter { get; }
      Description: Kilonewtons per square meter.
    static ForgeTypeId KilonewtonsPerSquareMillimeter { get; }
      Description: Kilonewtons per square millimeter.
    static ForgeTypeId Kilopascals { get; }
      Description: Kilopascals.
    static ForgeTypeId KilovoltAmperes { get; }
      Description: Kilovolt amperes.
    static ForgeTypeId Kilovolts { get; }
      Description: Kilovolts.
    static ForgeTypeId KilowattHours { get; }
      Description: Kilowatt hours.
    static ForgeTypeId Kilowatts { get; }
      Description: Kilowatts.
    static ForgeTypeId KipFeet { get; }
      Description: Kip feet.
    static ForgeTypeId KipFeetPerDegree { get; }
      Description: Kip feet per degree.
    static ForgeTypeId KipFeetPerDegreePerFoot { get; }
      Description: Kip feet per degree per foot.
    static ForgeTypeId KipFeetPerFoot { get; }
      Description: Kip feet per foot.
    static ForgeTypeId Kips { get; }
      Description: Kips.
    static ForgeTypeId KipsPerCubicFoot { get; }
      Description: Kips per cubic foot.
    static ForgeTypeId KipsPerCubicInch { get; }
      Description: Kips per cubic inch.
    static ForgeTypeId KipsPerFoot { get; }
      Description: Kips per foot.
    static ForgeTypeId KipsPerInch { get; }
      Description: Kips per inch.
    static ForgeTypeId KipsPerSquareFoot { get; }
      Description: Kips per square foot.
    static ForgeTypeId KipsPerSquareInch { get; }
      Description: Kips per square inch.
    static ForgeTypeId Liters { get; }
      Description: Liters.
    static ForgeTypeId LitersPerHour { get; }
      Description: Liters per hour.
    static ForgeTypeId LitersPerMinute { get; }
      Description: Liters per minute.
    static ForgeTypeId LitersPerSecond { get; }
      Description: Liters per second.
    static ForgeTypeId LitersPerSecondCubicMeter { get; }
      Description: Liters per second cubic meter.
    static ForgeTypeId LitersPerSecondKilowatt { get; }
      Description: Liters per second kilowatt.
    static ForgeTypeId LitersPerSecondSquareMeter { get; }
      Description: Liters per second square meter.
    static ForgeTypeId Lumens { get; }
      Description: Lumens.
    static ForgeTypeId LumensPerWatt { get; }
      Description: Lumens per watt.
    static ForgeTypeId Lux { get; }
      Description: Lux.
    static ForgeTypeId Megajoules { get; }
      Description: Megajoules.
    static ForgeTypeId MeganewtonMeters { get; }
      Description: Meganewton meters.
    static ForgeTypeId MeganewtonMetersPerMeter { get; }
      Description: Meganewton meters per meter.
    static ForgeTypeId Meganewtons { get; }
      Description: Meganewtons.
    static ForgeTypeId MeganewtonsPerMeter { get; }
      Description: Meganewtons per meter.
    static ForgeTypeId MeganewtonsPerSquareMeter { get; }
      Description: Meganewtons per square meter.
    static ForgeTypeId Megapascals { get; }
      Description: Megapascals.
    static ForgeTypeId Megawatts { get; }
      Description: Megawatts.
    static ForgeTypeId Meters { get; }
      Description: Meters.
    static ForgeTypeId MetersCentimeters { get; }
      Description: Meters and centimeters.
    static ForgeTypeId MetersOfWaterColumn { get; }
      Description: Meters of water column.
    static ForgeTypeId MetersOfWaterColumnPerMeter { get; }
      Description: Meters of water column per meter.
    static ForgeTypeId MetersPerKilonewton { get; }
      Description: Meters per kilonewton.
    static ForgeTypeId MetersPerSecond { get; }
      Description: Meters per second.
    static ForgeTypeId MetersPerSecondSquared { get; }
      Description: Meters per second squared.
    static ForgeTypeId MetersToTheFourthPower { get; }
      Description: Meters to the fourth power.
    static ForgeTypeId MetersToTheSixthPower { get; }
      Description: Meters to the sixth power.
    static ForgeTypeId MicroinchesPerInchDegreeFahrenheit { get; }
      Description: Microinches per inch degree Fahrenheit.
    static ForgeTypeId MicrometersPerMeterDegreeCelsius { get; }
      Description: Micrometers per meter degree Celsius.
    static ForgeTypeId MilesPerHour { get; }
      Description: Miles per hour.
    static ForgeTypeId MilesPerSecondSquared { get; }
      Description: Miles per second squared.
    static ForgeTypeId Milliamperes { get; }
      Description: Milliamperes.
    static ForgeTypeId Millimeters { get; }
      Description: Millimeters.
    static ForgeTypeId MillimetersOfMercury { get; }
      Description: Millimeters of mercury.
    static ForgeTypeId MillimetersOfWaterColumn { get; }
      Description: Millimeters of water column.
    static ForgeTypeId MillimetersOfWaterColumnPerMeter { get; }
      Description: Millimeters of water column per meter.
    static ForgeTypeId MillimetersToTheFourthPower { get; }
      Description: Millimeters to the fourth power.
    static ForgeTypeId MillimetersToTheSixthPower { get; }
      Description: Millimeters to the sixth power.
    static ForgeTypeId MillionBritishThermalUnits { get; }
      Description: Million British thermal units.
    static ForgeTypeId Milliseconds { get; }
      Description: Milliseconds.
    static ForgeTypeId Millivolts { get; }
      Description: Millivolts.
    static ForgeTypeId Minutes { get; }
      Description: Minutes.
    static ForgeTypeId NanogramsPerPascalSecondSquareMeter { get; }
      Description: Nanograms per pascal second square meter.
    static ForgeTypeId NewtonMeters { get; }
      Description: Newton meters.
    static ForgeTypeId NewtonMetersPerMeter { get; }
      Description: Newton meters per meter.
    static ForgeTypeId Newtons { get; }
      Description: Newtons.
    static ForgeTypeId NewtonSecondsPerSquareMeter { get; }
      Description: Newton seconds per square meter.
    static ForgeTypeId NewtonsPerMeter { get; }
      Description: Newtons per meter.
    static ForgeTypeId NewtonsPerSquareMeter { get; }
      Description: Newtons per square meter.
    static ForgeTypeId NewtonsPerSquareMillimeter { get; }
      Description: Newtons per square millimeter.
    static ForgeTypeId OhmMeters { get; }
      Description: Ohm meters.
    static ForgeTypeId OneToRatio { get; }
      Description: 1 : Ratio.
    static ForgeTypeId Pascals { get; }
      Description: Pascals.
    static ForgeTypeId PascalSeconds { get; }
      Description: Pascal seconds.
    static ForgeTypeId PascalsPerMeter { get; }
      Description: Pascals per meter.
    static ForgeTypeId Percentage { get; }
      Description: Percentage.
    static ForgeTypeId PerMille { get; }
      Description: Per mille.
    static ForgeTypeId Pi { get; }
      Description: Multiples of Ï€.
    static ForgeTypeId PoundForceFeet { get; }
      Description: Pound force feet.
    static ForgeTypeId PoundForceFeetPerFoot { get; }
      Description: Pound force feet per foot.
    static ForgeTypeId PoundForceSecondsPerSquareFoot { get; }
      Description: Pound force seconds per square foot.
    static ForgeTypeId PoundsForce { get; }
      Description: Pounds force.
    static ForgeTypeId PoundsForcePerCubicFoot { get; }
      Description: Pounds force per cubic foot.
    static ForgeTypeId PoundsForcePerFoot { get; }
      Description: Pounds force per foot.
    static ForgeTypeId PoundsForcePerSquareFoot { get; }
      Description: Pounds force per square foot.
    static ForgeTypeId PoundsForcePerSquareInch { get; }
      Description: Pounds force per square inch.
    static ForgeTypeId PoundsMass { get; }
      Description: Pounds mass.
    static ForgeTypeId PoundsMassPerCubicFoot { get; }
      Description: Pounds mass per cubic foot.
    static ForgeTypeId PoundsMassPerCubicInch { get; }
      Description: Pounds mass per cubic inch.
    static ForgeTypeId PoundsMassPerFoot { get; }
      Description: Pounds mass per foot.
    static ForgeTypeId PoundsMassPerFootHour { get; }
      Description: Pounds mass per foot hour.
    static ForgeTypeId PoundsMassPerFootSecond { get; }
      Description: Pounds mass per foot second.
    static ForgeTypeId PoundsMassPerHour { get; }
      Description: Pounds mass per hour.
    static ForgeTypeId PoundsMassPerMinute { get; }
      Description: Pounds mass per minute.
    static ForgeTypeId PoundsMassPerPoundDegreeFahrenheit { get; }
      Description: Pounds mass per pound degree Fahrenheit.
    static ForgeTypeId PoundsMassPerSecond { get; }
      Description: Pounds mass per second.
    static ForgeTypeId PoundsMassPerSquareFoot { get; }
      Description: Pounds mass per square foot.
    static ForgeTypeId Radians { get; }
      Description: Radians.
    static ForgeTypeId RadiansPerSecond { get; }
      Description: Radians per second.
    static ForgeTypeId Rankine { get; }
      Description: Rankine.
    static ForgeTypeId RankineInterval { get; }
      Description: Rankine interval.
    static ForgeTypeId RatioTo1 { get; }
      Description: Ratio : 1.
    static ForgeTypeId RatioTo10 { get; }
      Description: Ratio : 10.
    static ForgeTypeId RatioTo12 { get; }
      Description: Ratio : 12.
    static ForgeTypeId RevolutionsPerMinute { get; }
      Description: Revolutions per minute.
    static ForgeTypeId RevolutionsPerSecond { get; }
      Description: Revolutions per second.
    static ForgeTypeId RiseDividedBy1000Millimeters { get; }
      Description: Rise / 1000 millimeters.
    static ForgeTypeId RiseDividedBy10Feet { get; }
      Description: Rise / 10 feet.
    static ForgeTypeId RiseDividedBy120Inches { get; }
      Description: Rise / 120 inches.
    static ForgeTypeId RiseDividedBy12Inches { get; }
      Description: Rise / 12 inches.
    static ForgeTypeId RiseDividedBy1Foot { get; }
      Description: Rise / 1 foot.
    static ForgeTypeId Seconds { get; }
      Description: Seconds.
    static ForgeTypeId Shaku { get; }
      Description: Shaku.
    static ForgeTypeId SlopeDegrees { get; }
      Description: Degrees.
    static ForgeTypeId SquareCentimeters { get; }
      Description: Square centimeters.
    static ForgeTypeId SquareCentimetersPerMeter { get; }
      Description: Square centimeters per meter.
    static ForgeTypeId SquareFeet { get; }
      Description: Square feet.
    static ForgeTypeId SquareFeetPer1000BritishThermalUnitsPerHour { get; }
      Description: Square feet per thousand British thermal units per hour.
    static ForgeTypeId SquareFeetPerFoot { get; }
      Description: Square feet per foot.
    static ForgeTypeId SquareFeetPerKip { get; }
      Description: Square feet per kip.
    static ForgeTypeId SquareFeetPerSecond { get; }
      Description: Square feet per second.
    static ForgeTypeId SquareFeetPerTonOfRefrigeration { get; }
      Description: Square feet per ton of refrigeration.
    static ForgeTypeId SquareInches { get; }
      Description: Square inches.
    static ForgeTypeId SquareInchesPerFoot { get; }
      Description: Square inches per foot.
    static ForgeTypeId SquareMeterKelvinsPerWatt { get; }
      Description: Square meter kelvins per watt.
    static ForgeTypeId SquareMeters { get; }
      Description: Square meters.
    static ForgeTypeId SquareMetersPerKilonewton { get; }
      Description: Square meters per kilonewton.
    static ForgeTypeId SquareMetersPerKilowatt { get; }
      Description: Square meters per kilowatt.
    static ForgeTypeId SquareMetersPerMeter { get; }
      Description: Square meters per meter.
    static ForgeTypeId SquareMetersPerSecond { get; }
      Description: Square meters per second.
    static ForgeTypeId SquareMillimeters { get; }
      Description: Square millimeters.
    static ForgeTypeId SquareMillimetersPerMeter { get; }
      Description: Square millimeters per meter.
    static ForgeTypeId StationingFeet { get; }
      Description: Feet.
    static ForgeTypeId StationingMeters { get; }
      Description: Meters.
    static ForgeTypeId StationingSurveyFeet { get; }
      Description: US survey feet.
    static ForgeTypeId Steradians { get; }
      Description: Steradians.
    static ForgeTypeId Therms { get; }
      Description: Therms.
    static ForgeTypeId ThousandBritishThermalUnits { get; }
      Description: Thousand British thermal units.
    static ForgeTypeId ThousandBritishThermalUnitsPerHour { get; }
      Description: Thousand British thermal units per hour.
    static ForgeTypeId TonneForceMeters { get; }
      Description: Tonne force meters.
    static ForgeTypeId TonneForceMetersPerMeter { get; }
      Description: Tonne force meters per meter.
    static ForgeTypeId Tonnes { get; }
      Description: Tonnes.
    static ForgeTypeId TonnesCarbonDioxidePerBritishThermalUnit { get; }
      Description: tonnes of carbon dioxide per Btu.
    static ForgeTypeId TonnesCarbonDioxidePerCubicFoot { get; }
      Description: tonnes of carbon dioxide per cubic foot.
    static ForgeTypeId TonnesCarbonDioxidePerCubicMeter { get; }
      Description: tonnes of carbon dioxide per cubic meter.
    static ForgeTypeId TonnesCarbonDioxidePerFoot { get; }
      Description: tonnes of carbon dioxide per foot.
    static ForgeTypeId TonnesCarbonDioxidePerItem { get; }
      Description: tonnes of carbon dioxide per item.
    static ForgeTypeId TonnesCarbonDioxidePerKilogram { get; }
      Description: tonnes of carbon dioxide per kilogram.
    static ForgeTypeId TonnesCarbonDioxidePerKilowattHour { get; }
      Description: tonnes of carbon dioxide per kWh.
    static ForgeTypeId TonnesCarbonDioxidePerMegawattHour { get; }
      Description: tonnes of carbon dioxide per mWh.
    static ForgeTypeId TonnesCarbonDioxidePerMeter { get; }
      Description: tonnes of carbon dioxide per meter.
    static ForgeTypeId TonnesCarbonDioxidePerMillionBritishThermalUnits { get; }
      Description: tonnes of carbon dioxide per MBtu.
    static ForgeTypeId TonnesCarbonDioxidePerPoundMass { get; }
      Description: tonnes of carbon dioxide per pound.
    static ForgeTypeId TonnesCarbonDioxidePerSquareFoot { get; }
      Description: tonnes of carbon dioxide per square foot.
    static ForgeTypeId TonnesCarbonDioxidePerSquareMeter { get; }
      Description: tonnes of carbon dioxide per square meter.
    static ForgeTypeId TonnesCarbonDioxidePerThousandBritishThermalUnits { get; }
      Description: tonnes carbon dioxide per kBtu.
    static ForgeTypeId TonnesForce { get; }
      Description: Tonnes force.
    static ForgeTypeId TonnesForcePerMeter { get; }
      Description: Tonnes force per meter.
    static ForgeTypeId TonnesForcePerSquareMeter { get; }
      Description: Tonnes force per square meter.
    static ForgeTypeId TonsOfRefrigeration { get; }
      Description: Tons of refrigeration.
    static ForgeTypeId UsGallons { get; }
      Description: US gallons.
    static ForgeTypeId UsGallonsPerHour { get; }
      Description: US gallons per hour.
    static ForgeTypeId UsGallonsPerMinute { get; }
      Description: US gallons per minute.
    static ForgeTypeId UsSurveyFeet { get; }
      Description: US survey feet.
    static ForgeTypeId UsTonnesForce { get; }
      Description: US tonnes force.
    static ForgeTypeId UsTonnesMass { get; }
      Description: US tonnes mass.
    static ForgeTypeId VoltAmperes { get; }
      Description: Volt amperes.
    static ForgeTypeId VoltAmperesPerSquareFoot { get; }
      Description: Volt amperes per square foot.
    static ForgeTypeId VoltAmperesPerSquareMeter { get; }
      Description: Volt amperes per square meter.
    static ForgeTypeId Volts { get; }
      Description: Volts.
    static ForgeTypeId Watts { get; }
      Description: Watts.
    static ForgeTypeId WattsPerCubicFoot { get; }
      Description: Watts per cubic foot.
    static ForgeTypeId WattsPerCubicFootPerMinute { get; }
      Description: Watts per cubic foot per minute.
    static ForgeTypeId WattsPerCubicMeter { get; }
      Description: Watts per cubic meter.
    static ForgeTypeId WattsPerCubicMeterPerSecond { get; }
      Description: Watts per cubic meter per second.
    static ForgeTypeId WattsPerFoot { get; }
      Description: Watts per foot.
    static ForgeTypeId WattsPerMeter { get; }
      Description: Watts per meter.
    static ForgeTypeId WattsPerMeterKelvin { get; }
      Description: Watts per meter kelvin.
    static ForgeTypeId WattsPerSquareFoot { get; }
      Description: Watts per square foot.
    static ForgeTypeId WattsPerSquareMeter { get; }
      Description: Watts per square meter.
    static ForgeTypeId WattsPerSquareMeterKelvin { get; }
      Description: Watts per square meter kelvin.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] UnitUtils
Full Name: Autodesk.Revit.DB.UnitUtils
Description: A utility class of functions related to units.

  METHODS:
    static double Convert(double value, ForgeTypeId currentUnitTypeId, ForgeTypeId desiredUnitTypeId)
      Description: Converts a value from one unit to another, such as square feet to square meters.
      @value: The value to convert.
      @currentUnitTypeId: Identifier of the current unit.
      @desiredUnitTypeId: Identifier of the desired unit.
      Returns: The converted value.
      Throws ArgumentException: The given value for value is not finite -or- currentUnitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType). -or- desiredUnitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: currentUnitTypeId and desiredUnitTypeId have different dimensions.
    static double ConvertFromInternalUnits(double value, ForgeTypeId unitTypeId)
      Description: Converts a value from Revit's internal units to a given unit.
      @value: The value to convert.
      @unitTypeId: Identifier of the desired unit.
      Returns: The converted value.
      Throws ArgumentException: The given value for value is not finite -or- unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).
      Throws ArgumentNullException: A non-optional argument was null
    static double ConvertToInternalUnits(double value, ForgeTypeId unitTypeId)
      Description: Converts a value from a given unit to Revit's internal units.
      @value: The value to convert.
      @unitTypeId: Identifier of the unit quantifying the value.
      Returns: The converted value.
      Throws ArgumentException: The given value for value is not finite -or- unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ForgeTypeId> GetAllDisciplines()
      Description: Gets the identifiers of all available disciplines.
      Returns: The discipline identifiers.
    static IList<ForgeTypeId> GetAllMeasurableSpecs()
      Description: Gets the identifiers of all available measurable specs.
      Returns: The spec identifiers.
    static IList<ForgeTypeId> GetAllUnits()
      Description: Gets the identifiers of all available units.
      Returns: The unit identifiers.
    static ForgeTypeId GetDiscipline(ForgeTypeId specTypeId)
      Description: Gets the discipline for a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      Returns: Identifier of the discipline.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static string GetTypeCatalogStringForSpec(ForgeTypeId specTypeId)
      Description: Gets the string used in type catalogs to identify a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      Returns: The type catalog string, or an empty string if the measurable spec cannot be used in type catalogs.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static string GetTypeCatalogStringForUnit(ForgeTypeId unitTypeId)
      Description: Gets the string used in type catalogs to identify a given unit.
      @unitTypeId: Identifier of the unit.
      Returns: The type catalog string, or an empty string if the unit cannot be used in type catalogs.
      Throws ArgumentException: unitTypeId is not a unit identifier. See UnitUtils.IsUnit(ForgeTypeId) and UnitUtils.GetUnitTypeId(DisplayUnitType).
      Throws ArgumentNullException: A non-optional argument was null
    static IList<ForgeTypeId> GetValidUnits(ForgeTypeId specTypeId)
      Description: Gets the identifiers of all valid units for a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      Returns: Identifiers of the valid units.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsMeasurableSpec(ForgeTypeId specTypeId)
      Description: Checks whether a ForgeTypeId identifies a spec associated with units of measurement.
      @specTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a measurable spec, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsSymbol(ForgeTypeId symbolTypeId)
      Description: Checks whether a ForgeTypeId identifies a symbol.
      @symbolTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a symbol, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsUnit(ForgeTypeId unitTypeId)
      Description: Checks whether a ForgeTypeId identifies a unit.
      @unitTypeId: The identifier to check.
      Returns: True if the ForgeTypeId identifies a unit, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidUnit(ForgeTypeId specTypeId, ForgeTypeId unitTypeId)
      Description: Checks whether a unit is valid for a given measurable spec.
      @specTypeId: Identifier of the measurable spec.
      @unitTypeId: Identifier of the unit to check.
      Returns: True if the unit is valid, false otherwise.
      Throws ArgumentException: specTypeId is not a measurable spec identifier. See UnitUtils.IsMeasurableSpec(ForgeTypeId).
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] UpdaterData
Full Name: Autodesk.Revit.DB.UpdaterData
Description: Service class that is passed to an Updater to prove access to update execution context
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    ICollection<ElementId> GetAddedElementIds()
      Description: Returns set of elements newly added to the document. This set is mutually exclusive of elements returned by getDeletedElementIds() and getModifiedElementIds().
      Returns: Set of elements that were added to the document and triggered the call to execute() Note: This will only return elements if the trigger registered for the associated updater contains the ChangeType returned by Element::getChangeTypeElementAddition()
    ICollection<ElementId> GetDeletedElementIds()
      Description: Returns set of elements that were deleted from the document. This set is mutually exclusive of elements returned by getAddedElementIds() and getModifiedElementIds().
      Returns: Set of elements that were deleted from the document and triggered the call to execute() Note: This will only return elements if the trigger registered for the associated updater contains the ChangeType returned by Element::getChangeTypeElementDeletion()
    Document GetDocument()
      Description: Returns document associated with this UpdaterData
    ICollection<ElementId> GetModifiedElementIds()
      Description: Returns set of elements that were modified. This set is mutually exclusive of elements returned by getAddedElementIds() and getDeletedElementIds().
      Returns: Set of elements that were modified in the document and triggered the call to execute() Note: This set only contains modified elements (i.e. it is mutually exclusive of elements returned by getAddedElementIds() and getDeletedElementIds()). It does not contain any elements that were added to or deleted from the document during the current transaction. Newly added/deleted elements will be reported by getAddedElementIds()/getDeletedElementIds(), even if they were also modified during the same transaction, but only if ChangeTypeElementAddition/Deletion is registered as a trigger for the current Updater. I.e. Element creation and modification in the same transaction is considered to be "creation" only. Newly created elements are not considered to be "modified" and are therefore not returned as part of getModifiedElementIds()
    bool IsChangeTriggered(ElementId id, ChangeType type)
      Description: Allows updater to check if specific change has happened to an element. Compares input type to the types that caused Updater::execute() to be triggered. If input type was not registered as a trigger for the associated Updater, this method will always return false for that ChangeType. For example, if the only trigger registered for UpdaterX is ChangeTypeAny for Element A, then passing in ChangeTypeGeometry will return false even if the geometry of A changed because the registered trigger was ChangeTypeAny. However, passing in ChangeTypeAny will return true.
      @id: Id of element to check
      @type: ChangeType to check
      Returns: True if ChangeType happened to specified element
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] UpdaterId
Full Name: Autodesk.Revit.DB.UpdaterId
Description: A unique identifier of an Updater
Remarks: UpdaterId used as a key to register and unregister Updaters and UpdateTriggers in Revit application UpdaterId needs to be a stable identity for a given updater.
Implements: IDisposable

  CONSTRUCTORS:
    new UpdaterId(AddInId addInId, Guid val)
      Description: creates an instance of UpdaterId for given AddInId and a given GUID value
      @addInId: Id of addin that registers an Updater
      @val: a stable GUID identifying the Updater within addin
      Throws ArgumentException: addInId is not valid.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()
    AddInId GetAddInId()
      Description: AddInId of the UpdaterId
    Guid GetGUID()
      Description: GUID value of the UpdaterId

--------------------------------------------------------------------------------

[CLASS] UpdaterInfo
Full Name: Autodesk.Revit.DB.UpdaterInfo
Description: Information of an updater, such as: Name, AdditionalInformation, name of the application that owns the updater, etc.
Implements: IDisposable

  PROPERTIES:
    string AdditionalInformation { get; }
      Description: Additional information about the updater.
    string ApplicationName { get; }
      Description: Name of the application that owns the updater.
    bool IsOptional { get; }
      Description: Whether the updater is optional or not.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    string UpdaterName { get; }
      Description: Name of the updater.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] UpdaterRegistry
Full Name: Autodesk.Revit.DB.UpdaterRegistry
Description: An object that stores and manages all updaters registered in the current session.
Remarks: The registry is an application-wide singleton. It maintains all dynamic updaters currently registered, and also invokes them per their respective trigger condition during subsequent transactions.Please note that only the application (an add-in, typically) which registered an updater is allowed to modify it later, including unregistering it. Also, an application is not allowed to register an updater with an Id, that is based on another application's Id.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    static void AddTrigger(UpdaterId id, ElementFilter filter, ChangeType change)
      Description: Adds trigger with the specified element filter and ChangeType for all documents associated with this Updater
      @id: Id of updater that trigger should be added to
      @filter: Element filter that defines elements that affect this trigger
      @change: ChangeType associated with this trigger
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The updater's owner's AddIn does not match the currently active AddIn. -or- The id does not correspond to any registered Updaters. -or- AddTrigger called while executing an updater.
    static void AddTrigger(UpdaterId id, Document document, ElementFilter filter, ChangeType change)
      Description: Adds trigger with the specified element filter and ChangeType for the specified document
      @id: Id of updater that trigger should be added to
      @document: Document that elements in 'elements' are contained in
      @filter: Element filter that defines elements that affect this trigger
      @change: ChangeType associated with this trigger
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The updater's owner's AddIn does not match the currently active AddIn. -or- The id does not correspond to any registered Updaters -or- AddTrigger called while executing an updater.
    static void AddTrigger(UpdaterId id, Document document, ICollection<ElementId> elements, ChangeType change)
      Description: Adds a trigger to an updater with specified set of elements and ChangeType
      @id: Id of updater that trigger should be added to
      @document: Document that elements in 'elements' are contained in
      @elements: Set of elements which define this trigger
      @change: ChangeType associated with this trigger
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: updater's owner AddIn does not match the currently active AddIn -or- id does not correspond to any registered Updaters -or- AddTrigger called while executing an updater.
    static void DisableUpdater(UpdaterId id)
      Description: Disables the updater.
      @id: The updater id.
      Throws ArgumentException: Updater with this Id is not currently registered in Revit.
      Throws ArgumentNullException: A non-optional argument was null
    void Dispose()
    static void EnableUpdater(UpdaterId id)
      Description: Enables the updater.
      @id: The updater id.
      Throws ArgumentException: Updater with this Id is not currently registered in Revit.
      Throws ArgumentNullException: A non-optional argument was null
    static bool GetIsUpdaterOptional(UpdaterId id)
      Description: Check if the updater is optional or not.
      @id: Id of the updater to check
      Returns: Returns True if the updater is optional, False otherwise.
      Throws ArgumentException: Updater with this Id is not currently registered in Revit.
      Throws ArgumentNullException: A non-optional argument was null
    static IList<UpdaterInfo> GetRegisteredUpdaterInfos()
      Description: Returns UpdaterInfos for all the application-wide updaters.
      Returns: List of UpdaterInfo structures
    static IList<UpdaterInfo> GetRegisteredUpdaterInfos(Document document)
      Description: Returns information about all updaters applicable to the given document.
      @document: The document to which sought updaters are applicable to.
      Returns: List of UpdaterInfo structures
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsUpdaterEnabled(UpdaterId id)
      Description: Checks if the updater is enabled or not.
      @id: The updater id.
      Returns: Returns true if the updater is enabled, false otherwise.
      Throws ArgumentException: Updater with this Id is not currently registered in Revit.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsUpdaterRegistered(UpdaterId id, Document document)
      Description: Checks whether updater with the given id is registered in a document.
      @id: Id of the updater being tested.
      @document: Document in which this updater is tested whether it's registered or not.
      Returns: Returns True if the updater is registered in the given document.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsUpdaterRegistered(UpdaterId id)
      Description: Checks whether updater with the given id is registered
      @id: Id of the updater being tested.
      Returns: Returns true if the updater is registered.
      Throws ArgumentNullException: A non-optional argument was null
    static void RegisterUpdater(IUpdater updater, Document document, bool isOptional)
      Description: Registers the updater for a specified document, which means the updater can only be triggered by changes made in that document.
      @updater: Updater to be registered.
      @document: Document for which this updater is to be registered.
      @isOptional: This argument controls whether the updater should be required next time a document is open in which the updater had been previously used. If a non-optional updater is not found (i.e. currently not registered), the end user will be presented with a warning and choices to resolve the situation.
      Throws ArgumentException: Updater with the the same Id has already been registered on the application level. -or- Updater with the the same Id has already been registered either in the given document or on the application level. -or- Updater's Id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Method is not allowed during execution of a dynamic update. -or- The updater's owner's AddIn does not match the currently active AddIn, i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field in the manifest file of the currently executing external application.
    static void RegisterUpdater(IUpdater updater, bool isOptional)
      Description: Registers an updater application-wide, which means the updater may get triggered in any open document.
      @updater: Updater to be registered
      @isOptional: This argument controls whether the updater should be required next time a document is open in which the updater had been previously used. If a non-optional updater is not found (i.e. currently not registered), the end user will be presented with a warning and choices to resolve the situation.
      Throws ArgumentException: Updater with the the same Id has already been registered on the application level. -or- Updater's Id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Method is not allowed during execution of a dynamic update. -or- The updater's owner's AddIn does not match the currently active AddIn, i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field in the manifest file of the currently executing external application.
    static void RegisterUpdater(IUpdater updater, Document document)
      Description: Registers the updater for a specified document, which means the updater can only be triggered by changes made in that document.
      @updater: Updater to be registered
      @document: Document for which this updater is to be registered
      Throws ArgumentException: Updater with the the same Id has already been registered on the application level. -or- Updater with the the same Id has already been registered either in the given document or on the application level. -or- Updater's Id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Method is not allowed during execution of a dynamic update. -or- The updater's owner's AddIn does not match the currently active AddIn, i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field in the manifest file of the currently executing external application.
    static void RegisterUpdater(IUpdater updater)
      Description: Registers an updater application-wide, which means the updater may get triggered in any open document.
      @updater: Updater to be registered
      Throws ArgumentException: Updater with the the same Id has already been registered on the application level. -or- Updater's Id is not valid.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Method is not allowed during execution of a dynamic update. -or- The updater's owner's AddIn does not match the currently active AddIn, i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field in the manifest file of the currently executing external application.
    static void RemoveAllTriggers(UpdaterId id)
      Description: Removes all triggers associated with Updater with specified UpdaterId. Does not unregister updater.
      @id: Id of specified updater
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The updater's owner's AddIn does not match the currently active AddIn. -or- RemoveAllTriggers called while executing an updater.
    static void RemoveDocumentTriggers(UpdaterId id, Document document)
      Description: Removes all triggers associated with specified document and Updater Does not unregister updater.
      @id: Id of specified updater
      @document: Document for which to remove triggers
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The updater's owner's AddIn does not match the currently active AddIn. -or- RemoveDocumentTriggers called while executing an updater.
    static void SetExecutionOrder(UpdaterId first, UpdaterId second)
      Description: Forces execution order between two updaters Execution order: first before second
      @first: Id of first Updater
      @second: Id of second Updater
      Throws ArgumentException: One or both inputs are not valid UpdaterIds -or- One or both of the Updaters are not registered -or- first and second are the same id
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentsInconsistentException: The updaters do not report the same ChangePriority
    static void SetIsUpdaterOptional(UpdaterId id, bool isOptional)
      Description: Sets a flag indicating whether an updater is optional or not.
      @id: Id of the updater
      @isOptional: Use True to make the updater optional, false to make it a mandatory updater.
      Throws ArgumentException: Updater with this Id is not currently registered in Revit.
      Throws ArgumentNullException: A non-optional argument was null
    static void UnregisterUpdater(UpdaterId id, Document document)
      Description: Unregisters an updater for the given document.
      @id: Id of updater to be unregistered.
      @document: Document for which this updater is to be unregistered.
      Throws ArgumentException: Updater with this Id is not currently registered in the document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The updater's owner's AddIn does not match the currently active AddIn, i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field in the manifest file of the currently executing external application. -or- Attempting to unregister an updater that is currently being executed.
    static void UnregisterUpdater(UpdaterId id)
      Description: Removes the updater associated with the input id from the UpdaterRegistry. Also removes all triggers associated with the Updater.
      @id: Id of updater to be removed
      Throws ArgumentException: Updater with this Id is not currently registered in Revit.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The updater's owner's AddIn does not match the currently active AddIn, i.e. IUpdater.GetUpdaterId().GetAddInId() differs from the addInId field in the manifest file of the currently executing external application. -or- Attempting to unregister an updater that is currently being executed.

--------------------------------------------------------------------------------

[CLASS] UV
Full Name: Autodesk.Revit.DB.UV
Description: Object representing coordinates in 2-dimensional space.
Remarks: Usually this means parameters on a surface. In actual use, it could be interpreted as either point or vector in 2-dimensional space.

  CONSTRUCTORS:
    new UV(double u, double v)
      Description: Creates a UV with the supplied coordinates.
      @u: The first coordinate.
      @v: The second coordinate.
      Throws ArgumentException: Thrown when setting an infinite number to the U or V property.
    new UV()
      Description: Creates a default UV with the values (0, 0).

  PROPERTIES:
    static UV BasisU { get; }
      Description: The basis of the U axis.
    static UV BasisV { get; }
      Description: The basis of the V axis.
    double Item { get; }
    double U { get; }
      Description: Gets the first coordinate.
    double V { get; }
      Description: Gets the second coordinate.
    static UV Zero { get; }
      Description: The coordinate origin or zero 2-D vector.

  METHODS:
    UV Add(UV source)
      Description: Adds the specified 2-D vector to this 2-D vector and returns the result.
      @source: The vector to add to this vector.
      Returns: The 2-D vector equal to the sum of the two vectors.
      Throws ArgumentNullException: Thrown when source is .
    double AngleTo(UV source)
      Description: Returns the angle between this vector and the specified vector.
      @source: The specified vector.
      Returns: The real number between 0 and 2*PI equal to the angle between the two vectors in radians.
      Throws ArgumentNullException: Thrown when source is .
    double CrossProduct(UV source)
      Description: The cross product of this 2-D vector and the specified 2-D vector.
      @source: The vector to multiply with this vector.
      Returns: The real number equal to the cross product.
      Throws ArgumentNullException: Thrown when source is .
    double DistanceTo(UV source)
      Description: Returns the distance from this 2-D point to the specified 2-D point.
      @source: The specified point.
      Returns: The real number equal to the distance between the two points.
      Throws ArgumentNullException: Thrown when source is .
    UV Divide(double value)
      Description: Divides this 2-D vector by the specified value and returns the result.
      @value: The value to divide this vector by.
      Returns: The divided 2-D vector.
      Throws ArgumentException: Thrown when the specified value is an infinite number.
      Throws ArgumentException: Thrown when the specified value is zero.
    double DotProduct(UV source)
      Description: The dot product of this 2-D vector and the specified 2-D vector.
      @source: The vector to multiply with this vector.
      Returns: The real number equal to the dot product.
      Throws ArgumentNullException: Thrown when source is .
    double GetLength()
      Description: The length of this 2-D vector.
    bool IsAlmostEqualTo(UV source, double tolerance)
      Description: Determines whether this 2-D vector and the specified 2-D vector are the same within a specified tolerance.
      @source: The vector to compare with this vector.
      @tolerance: The tolerance for equality check.
      Returns: True if the vectors are the same; otherwise, false.
      Throws ArgumentNullException: Thrown when source is .
      Throws ArgumentException: Thrown when tolerance is less than 0.
    bool IsAlmostEqualTo(UV source)
      Description: Determines whether this 2-D vector and the specified 2-D vector are the same within the tolerance (1.0e-09).
      @source: The vector to compare with this vector.
      Returns: True if the vectors are the same; otherwise, false.
      Throws ArgumentNullException: Thrown when left is .
    bool IsUnitLength()
      Description: The boolean value indicates whether this 2-D vector is of unit length.
    bool IsZeroLength()
      Description: The boolean value indicates whether this 2-D vector is a zero vector.
    UV Multiply(double value)
      Description: Multiplies this 2-D vector by the specified value and returns the result.
      @value: The value to multiply with this vector.
      Returns: The multiplied 2-D vector.
      Throws ArgumentException: Thrown when the specified value is an infinite number.
    UV Negate()
      Description: Negates this 2-D vector.
      Returns: The 2-D vector opposite to this vector.
    UV Normalize()
      Description: Returns a new UV whose coordinates are the normalized values from this vector.
      Returns: The normalized UV or zero if the vector is almost Zero.
    UV Subtract(UV source)
      Description: Subtracts the specified 2-D vector from this 2-D vector and returns the result.
      @source: The vector to subtract from this vector.
      Returns: The 2-D vector equal to the difference between the two vectors.
      Throws ArgumentNullException: Thrown when left is .
    string ToString()
      Description: Gets formatted string showing (U, V) with values formatted to 9 decimal places.

--------------------------------------------------------------------------------

[ENUM] UVGridlineType
Full Name: Autodesk.Revit.DB.UVGridlineType
Description: A choice between U-gridlines or V-gridlines of a divided surface U Gridlines V Gridlines
Inherits: Enum

  Values:
    - U = 0
    - V = 1

--------------------------------------------------------------------------------

[CLASS] ValidateCurveLoopsOptions
Full Name: Autodesk.Revit.DB.ValidateCurveLoopsOptions
Description: Options for array of curve loops validation.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ValueAtPointBase
Full Name: Autodesk.Revit.DB.ValueAtPointBase
Description: A base class representing storage of values at a given point.
Remarks: This class stores a set of measurements and corresponding mapped flags. The flags are defined in the enumerated type ValueAtPointFlags.
Implements: IDisposable

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.

  METHODS:
    void ClearAllFlags()
      Description: Sets flags for all measurements to ValueAtPointFlags::None.
    void ClearFlagsAt(int measurement)
      Description: Sets flags for the given measurement to ValueAtPointFlags::None.
      @measurement: Measurement for which to clear flags.
      Throws ArgumentOutOfRangeException: The given value for measurement is negative.
    void Dispose()
    int GetFlags(int measurement)
      Description: Returns flags for the given measurement.
      @measurement: Measurement number for which flags are returned.
      Returns: Flags value for the measurement.
      Throws ArgumentOutOfRangeException: The given value for measurement is negative.
    void SetFlags(int flags, int measurement)
      Description: Sets the flags associated to a given measurement.
      @flags: The value of the flags to set. Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.
      @measurement: Measurement for which to set flags.
      Throws ArgumentOutOfRangeException: The given value for measurement is negative.
    void SetFlags(int flags)
      Description: Sets the flags associated to all measurements to the same value.
      @flags: Value of flags, uniform for all measurements. Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value.
    void SetFlags(IList<int> flags)
      Description: Independently sets the flags associated to all measurements.
      @flags: An array of flags values. Each member corresponds to a measurement. Flags values are defined in the enumerated class ValueAtPointFlags and are combined into the int value. Number of measurements is set at creation of SpatialFieldManager in method createSpatialFieldManager.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ValueAtPointFlags
Full Name: Autodesk.Revit.DB.ValueAtPointFlags
Description: Enumerated type containing flags related to the display on particular points. Enumerated type that stores bit values of flags that can be set at any domain point.
Inherits: Enum

  Values:
    - None = 0
    - DisplayText = 1
    - DisplayFence = 2

--------------------------------------------------------------------------------

[CLASS] ValueParsingOptions
Full Name: Autodesk.Revit.DB.ValueParsingOptions
Description: Options for parsing strings into numbers with units.
Implements: IDisposable

  CONSTRUCTORS:
    new ValueParsingOptions()
      Description: Creates a new ValueParsingOptions object with default settings.

  PROPERTIES:
    AllowedValues AllowedValues { get; set; }
      Description: The allowable range of values to be parsed.
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
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] VertexIndexPair
Full Name: Autodesk.Revit.DB.VertexIndexPair
Description: Represents a connection between vertices in the top and bottom profile of a blend.
Remarks: Use objects of this type in GetVertexConnectionMap, VertexIndexPairArray), GetVertexConnectionMap and VertexIndexPairArray) to get/set the vertex connection map.

  CONSTRUCTORS:
    new VertexIndexPair(int iTop, int iBottom)

  PROPERTIES:
    int Bottom { get; set; }
      Description: The index of the vertex pair from the bottom profile.
    int Top { get; set; }
      Description: The index of the vertex pair from the top profile.

--------------------------------------------------------------------------------

[CLASS] VertexIndexPairArray
Full Name: Autodesk.Revit.DB.VertexIndexPairArray
Description: An array that contains VertexIndex pairs.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new VertexIndexPairArray()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the array is empty.
    VertexIndexPair Item { get; set; }
    int Size { get; }
      Description: Returns the number of VertexIndex pairs that are in the array.

  METHODS:
    void Append(VertexIndexPair item)
    void Clear()
      Description: Removes every VertexIndex pair from the array, rendering it empty.
    VertexIndexPairArrayIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the array.
      Returns: Returns a forward moving iterator to the array.
    void Insert(VertexIndexPair item, int index)
    VertexIndexPairArrayIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the array.
      Returns: Returns a backward moving iterator to the array.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] VertexIndexPairArrayIterator
Full Name: Autodesk.Revit.DB.VertexIndexPairArrayIterator
Description: An iterator to an array of VertexIndex pairs.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new VertexIndexPairArrayIterator()
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

[CLASS] VertexPair
Full Name: Autodesk.Revit.DB.VertexPair
Description: Indices of a pair of vertices in two CurveLoops(one vertex in each loop).
Remarks: A vertex is specified by the index in the CurveLoop of the curve having that vertex as its start point. Indexes start at 0.
Implements: IDisposable

  CONSTRUCTORS:
    new VertexPair(int firstVertexIdx, int secondVertexIdx)
      Description: Constructs a new VertexPair from a pair of indices in the curve loops.

  PROPERTIES:
    int First { get; set; }
      Description: Identifies the first index of VertexPair.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Second { get; set; }
      Description: Identifies the second index of VertexPair.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] VerticalAlignmentStyle
Full Name: Autodesk.Revit.DB.VerticalAlignmentStyle
Description: Declares the vertical alignment style of font.
Inherits: Enum

  Values:
    - Top = 0
    - Middle = 4
    - Bottom = 8

--------------------------------------------------------------------------------

[ENUM] VerticalTextAlignment
Full Name: Autodesk.Revit.DB.VerticalTextAlignment
Description: Supported types of vertical alignment of a text element.
Inherits: Enum

  Values:
    - Top = 0
    - Bottom = 1
    - Middle = 2

--------------------------------------------------------------------------------

[CLASS] View
Full Name: Autodesk.Revit.DB.View
Description: Base class for all types of views in Autodesk Revit.
Remarks: A view can display an image produced from a Revit model. Views can be graphical (e.g. plans, elevations, or 3D views) or textual (e.g. schedules). Views keep track of Elements that can be seen in them.
Inherits: Element

  PROPERTIES:
    ElementId AnalysisDisplayStyleId { get; set; }
      Description: Element id of Analysis Display Style associated with the view.
    bool AreAnalyticalModelCategoriesHidden { get; set; }
      Description: Indicates if analytical model categories are currently hidden in the view.
    bool AreAnnotationCategoriesHidden { get; set; }
      Description: Indicates if annotation categories are currently hidden in the view.
    bool AreCoordinationModelHandlesHidden { get; set; }
      Description: Indicates if Coordination Model handles are currently hidden in the view.
    bool AreImportCategoriesHidden { get; set; }
      Description: Indicates if import categories are currently hidden in the view.
    bool AreModelCategoriesHidden { get; set; }
      Description: Indicates if model categories are currently hidden in the view.
    bool ArePointCloudsHidden { get; set; }
      Description: Indicates if point clouds are currently hidden in the view.
    ElementId AssociatedAssemblyInstanceId { get; }
      Description: The Id of the assembly instance that owns the assembly view.
    bool CanBePrinted { get; }
      Description: Test whether the view can be printed.
    BoundingBoxXYZ CropBox { get; set; }
      Description: The Crop Box applied to the view, or an outline encompassing the crop region applied to the view.
    bool CropBoxActive { get; set; }
      Description: Whether or not the Crop Box/Region is active for the view.
    bool CropBoxVisible { get; set; }
      Description: Whether or not the Crop Box/Region is visible for the view.
    ViewDetailLevel DetailLevel { get; set; }
      Description: The detail level of this view.
    ViewDiscipline Discipline { get; set; }
      Description: The Discipline of the view.
    DisplayStyle DisplayStyle { get; set; }
      Description: The DisplayStyle of the view. Returns DisplayStyle.Wireframe if the view has no display style.
    Level GenLevel { get; }
      Description: The level for the view.
    bool IsAssemblyView { get; }
      Description: Indicates if the view is assembly view.
    bool IsCallout { get; }
      Description: Indicates if the view is a callout view.
    bool IsTemplate { get; }
      Description: Test whether the view is a view template.
    XYZ Origin { get; }
      Description: Returns the origin of the screen.
    BoundingBoxUV Outline { get; }
      Description: The bounds of the view in paper space (in feet).
    PartsVisibility PartsVisibility { get; set; }
      Description: The visibility setting for parts in this view.
    bool RevealConstraintsMode { get; set; }
      Description: Indicates whether the Reveal Constraints mode is activated in the view.
    XYZ RightDirection { get; }
      Description: The direction towards the right side of the screen.
    int Scale { get; set; }
      Description: The scale of the view.
    int ShadowIntensity { get; set; }
      Description: The intesity of cast shadows - 0 = no shadows, 100 = black.
    SketchPlane SketchPlane { get; set; }
      Description: The sketch plane assigned to the view for model curve creation.
    SunAndShadowSettings SunAndShadowSettings { get; }
      Description: The sun and shadow settings assigned to the view for shadow calculation and rendering.
    int SunlightIntensity { get; set; }
      Description: The intensity of the simulated (directional) sunlight. 0 = no directional light; maximum value is 100.
    TemporaryViewModes TemporaryViewModes { get; }
      Description: Data of temporary view modes associated with this view.
    string Title { get; }
      Description: The view title. This consists of the view name plus other modifiers, such as the view type, sheet number, area scheme, and/or assembly type, depending on the specifics of the view.
    XYZ UpDirection { get; }
      Description: The direction towards the top of the screen.
    XYZ ViewDirection { get; }
      Description: The direction towards the viewer.
    ElementId ViewPositionId { get; set; }
      Description: The id of the view's saved position. Default is set to ElementId.InvalidElementId.
    ElementId ViewTemplateId { get; set; }
      Description: The id of the template view that controls this view's parameters.
    ViewType ViewType { get; }
      Description: The type of the view.

  METHODS:
    void AddFilter(ElementId filterElementId)
      Description: Adds a filter to the view.
      @filterElementId: ElementId of the filter.
      Throws ArgumentException: ElementId is not associated with a FilterElement. -or- Filter is already applied to the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    bool AllowsAnalysisDisplay()
      Description: Identifies if this view allows display of Analysis results.
      Returns: True if the view allows display of Analysis results, false otherwise.
    void ApplyViewTemplateParameters(View otherView)
      Description: Applies to this view the parameters of the input view that are not controlled by the current view template.
      @otherView: The view whose parameters are to be applied to this view. It does not have to be a valid template (property IsTemplate can be true or false).
      Throws ArgumentNullException: A non-optional argument was null
    bool AreGraphicsOverridesAllowed()
      Description: Determines if Visibility/Graphics Overriddes can be applied to the view.
      Returns: True if Overriddes can be applied to the view, false otherwise.
    bool CanApplyColorFillScheme(ElementId categoryId, ElementId schemeId)
      Description: Checks if the id can be applied as the scheme id of specified category to this view.
      @categoryId: The id of category.
      @schemeId: The id of color fill scheme.
      Returns: True if the id can be applied as the scheme id of specified category in this view, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanCategoryBeHidden(ElementId elementId)
      Description: Checks whether the category can be hidden in the view.
      @elementId: ElementId of the category.
      Returns: True if the category can be hidden, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool CanCategoryBeHiddenTemporary(ElementId elementId)
      Description: Check if category can be temporarily hidden in the view.
      @elementId: Id of the category to be checked
      Throws ArgumentNullException: A non-optional argument was null
    bool CanEnableTemporaryViewPropertiesMode()
      Description: Indicates if Temporary View Properties mode can be applied for view in current state.
      Returns: True if view can use Temporary View Properties mode in current state.
    bool CanModifyDetailLevel()
      Description: Check if Detail Level can be modified.
      Returns: True if Detail Level can be modified.
    bool CanModifyDisplayStyle()
      Description: Indicates if DisplayStyle can be modified.
      Returns: True if DisplayStyle can be modified.
    bool CanModifyViewDiscipline()
      Description: Indicates if the View Discipline can be modified
      Returns: True if View Discipline can be modified
    bool CanUseDepthCueing()
      Description: Indicates if view can use Depth Cueing
      Returns: True if view can use Depth Cueing
    bool CanUseTemporaryVisibilityModes()
      Description: Indicates if view can use temporary visibility modes
      Returns: True if view can use temporary visibility modes
    bool CanViewBeDuplicated(ViewDuplicateOption duplicateOption)
      Description: Identifies if this view can be duplicated.
      @duplicateOption: The option to use when duplicating the view.
      Returns: True if the view can be duplicated, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void ConvertTemporaryHideIsolateToPermanent()
      Description: Convert all temporary hidden elements or categories to permanently hidden in view.
      Throws InvalidOperationException: The element "this View" does not belong to a project document.
      Throws ModificationForbiddenException: This View is an internal element, such as a component of a loaded family or a group type. -or- The document containing this View is in Group Edit Mode, Sketch Edit Mode, or Paste Mode, and the element is not a member of the group, sketch, or clipboard. -or- This View is a member of a group or sketch, and the document is not currently editing the group or sketch.
    void ConvertToIndependent()
      Description: Convert the dependent view to independent.
      Throws InvalidOperationException: This view is not dependent.
    View CreateViewTemplate()
      Description: Creates a new view template instance from this view instance.
      Returns: New view template instance
      Throws InvalidOperationException: The view is not valid for view template creation.
    void DisableTemporaryViewMode(TemporaryViewMode mode)
      Description: Disables the specified temporary view mode.
      @mode: The mode to disable.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: View cannot use temporary visibility modes.
    ElementId Duplicate(ViewDuplicateOption duplicateOption)
      Description: Duplicates this view.
      @duplicateOption: The option to use when duplicating the view.
      Returns: The id of the newly created view.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: View cannot be duplicated
    void EnableRevealHiddenMode()
      Description: Enables Reveal Hidden elements mode.
      Throws InvalidOperationException: View cannot use temporary visibility modes.
    bool EnableTemporaryViewPropertiesMode(ElementId viewTemplateId)
      Description: Turns Temporary View Properties mode on or off. In this mode, any changes made to the view are temporary and will be discarded once the mode is disabled.
      @viewTemplateId: If the id of a view template is provided, Temporary View Properties mode is turned on and the settings from the template are applied to the view for the duration of the mode. If the id provided is not that of a template but the id of the view itself, Temporary View Properties mode is turned on without any changes to the view. If ElementId.InvalidElementId is provided, Temporary View Properties mode is turned off.
      Returns: Returns true when the view template provided by viewTemplateId was applied and Temporary View Properties was successfully turned on. Also returns true if ElementId.InvalidElementId was provided as input and Temporary View Properties was successfully turned off.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: View cannot use Temporary View Properties mode in current state.
    ViewDisplayBackground GetBackground()
      Description: Returns the current background set for the view.
      Returns: Current background.
    ElementId GetCalloutParentId()
      Description: Gets ID of the callout parent view.
      Returns: ID of a view in which this callout was created or InvalidElementId if there is no parent.
      Throws InvalidOperationException: This view is not a callout.
    bool GetCategoryHidden(ElementId categoryId)
      Description: Checks if elements of the given category are set to be invisible (hidden) in this view.
      @categoryId: The ID of the category.
      Returns: True if the category is invisible (hidden), false otherwise.
      Throws ArgumentException: categoryId does not correspond to a Category.
      Throws ArgumentNullException: A non-optional argument was null
    OverrideGraphicSettings GetCategoryOverrides(ElementId categoryId)
      Description: Gets graphic overrides for a category in view.
      @categoryId: Category to be checked.
      Returns: Object representing all graphic overrides of the category categoryId in view. A default OverrideGraphicSettings object will be returned if it not previously been set for this view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The view type does not support Visibility/Graphics Overriddes.
    ElementId GetColorFillSchemeId(ElementId categoryId)
      Description: Returns id of the color fill scheme element applied to the view.
      @categoryId: The id of the category which the color fill scheme element belongs to.
      Returns: The id of the color fill scheme element.
      Throws ArgumentNullException: A non-optional argument was null
    ViewCropRegionShapeManager GetCropRegionShapeManager()
      Description: Returns an object for managing view crop region shape.
      Returns: The crop region shape manager.
    static ViewCropRegionShapeManager GetCropRegionShapeManagerForReferenceCallout(Document doc, ElementId callout)
      Description: Returns an object for managing view crop region shape for reference callout.
      @doc: Document to which the callout belongs.
      @callout: Element id of reference callout.
      Returns: The crop region shape manager.
      Throws ArgumentNullException: A non-optional argument was null
    ICollection<ElementId> GetDependentViewIds()
      Description: Get the ids of dependent views.
      Returns: Ids of the dependent views.
    ViewDisplayDepthCueing GetDepthCueing()
      Description: Returns the current depth cueing settings for the view.
      Returns: Current depth cueing settings.
      Throws InvalidOperationException: This view cannot use Depth Cueing
    DirectContext3DHandleOverrides GetDirectContext3DHandleOverrides()
      Description: Returns DirectContext3D handle overrides object for the view.
      Returns: DirectContext3D handle overrides for the view
    OverrideGraphicSettings GetElementOverrides(ElementId elementId)
      Description: Gets graphic overrides for an element in the view.
      @elementId: The element.
      Returns: An object representing all graphic overrides of the element elementId in view.
      Throws ArgumentException: elementId is not a valid Element identifier.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    OverrideGraphicSettings GetFilterOverrides(ElementId filterElementId)
      Description: Gets graphic overrides that a filter applies to the view.
      @filterElementId: ElementId of the filter.
      Returns: Object representing all graphic overrides of the filter in the view.
      Throws ArgumentException: ElementId is not associated with a FilterElement. -or- Filter is not applied to the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    ICollection<ElementId> GetFilters()
      Description: Gets the filters applied to the view.
      Returns: The ElementIds of the Filters.
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    bool GetFilterVisibility(ElementId filterElementId)
      Description: Gets the visibility of the elements associated with a filter.
      @filterElementId: The ElementId of the filter.
      Returns: True if the elements associated with the filter are visible in the view, false otherwise.
      Throws ArgumentException: Filter is not applied to the view. -or- ElementId is not associated with a FilterElement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    bool GetIsFilterEnabled(ElementId filterElementId)
      Description: Identifies if the filter is enabled in this view.
      @filterElementId: The ElementId of the filter.
      Returns: True if the specified filter is enabled in this view, false otherwise.
      Throws ArgumentException: Filter is not applied to the view. -or- ElementId is not associated with a FilterElement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    RevitLinkGraphicsSettings GetLinkOverrides(ElementId linkId)
      Description: Gets the graphic overrides of a RevitLinkType or RevitLinkInstance in view.
      @linkId: The id of the RevitLinkType or RevitLinkInstance.
      Returns: Settings representing graphic overrides for the input element id in the view, or if the input id references RevitLinkInstance and it doesn't have overrides in the view.
      Throws ArgumentException: The input id is not a valid RevitLinkInstance or RevitLinkType id.
      Throws ArgumentNullException: A non-optional argument was null
    IList<TransformWithBoundary> GetModelToProjectionTransforms()
      Description: Gets the transforms from the model space to the view projection space.
      Returns: The transformations from the model space to view projection space.
      Throws InvalidOperationException: The view does not return transforms. -or- The view is a perspective view.
    ICollection<ElementId> GetNonControlledTemplateParameterIds()
      Description: Returns a list of parameters that are not marked as included when this view is used as a template.
      Returns: The parameter ids that are not marked to be included.
    IList<ElementId> GetOrderedFilters()
      Description: Gets the filters applied to the view in the order they are applied.
      Returns: The ElementIds of the Filters.
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    ViewPlacementOnSheetStatus GetPlacementOnSheetStatus()
      Description: Determines if this view placed on a sheet completely or partially.
      Returns: A value indicating whether and how the View is placed on a Sheet.
    PointCloudOverrides GetPointCloudOverrides()
      Description: Returns point cloud overrides object for the view.
      Returns: Point cloud overrides for the view
    ElementId GetPrimaryViewId()
      Description: Get the id of the primary view.
      Returns: The id of the primary view, or InvalidElementId if there is no primary view.
    ICollection<ElementId> GetReferenceCallouts()
      Description: Returns element ids of all reference callouts in the view.
      Returns: Element ids of all reference callouts in the view.
    ICollection<ElementId> GetReferenceElevations()
      Description: Returns element ids of all reference elevations in the view.
      Returns: Element ids of all reference elevations in the view.
    ICollection<ElementId> GetReferenceSections()
      Description: Returns element ids of all reference sections in the view.
      Returns: Element ids of all reference sections in the view.
    ViewDisplaySketchyLines GetSketchyLines()
      Description: Returns the current sketchy lines settings for the view.
      Returns: Current sketchy lines settings.
    IList<ElementId> GetTemplateParameterIds()
      Description: Returns a list of parameter ids that may be controlled when this view is assigned as a template.
      Returns: The parameter ids that may be controlled.
    ElementId GetTemporaryViewPropertiesId()
      Description: When Temporary View Properties mode is in progress it provides view id that overrode settings for current view. Outside Temporary View Properties mode InvalidElementId will be returned.
    string GetTemporaryViewPropertiesName()
      Description: When Temporary View Properties mode is in progress, name of applied template is returned. Outside Temporary View Properties mode, empty string will be returned.
    ViewDisplayModel GetViewDisplayModel()
      Description: Returns the current view display model settings for the view.
      Returns: Current view display model settings.
    WorksetVisibility GetWorksetVisibility(WorksetId worksetId)
      Description: Returns the visibility settings of a workset for this particular view.
      @worksetId: Id of the workset.
      Returns: The visibility of a workset for this particular view.
      Throws ArgumentException: There is no workset with this Id in the document associated with this view.
      Throws ArgumentNullException: A non-optional argument was null
    WorksharingDisplayMode GetWorksharingDisplayMode()
      Description: Gets the current worksharing display mode for this view.
      Returns: The active worksharing display mode in this view.
    bool HasDetailLevel()
      Description: Check if the view has a Detail Level property
      Returns: True if the view has a Detail Level, false otherwise
    bool HasDisplayStyle()
      Description: Indicates if view has a DisplayStyle property
      Returns: True if view has a DisplayStyle property
    bool HasViewDiscipline()
      Description: Indicates if the view has a Discipline property
      Returns: True if the view has a Discipline property
    bool HasViewTransforms()
      Description: Returns true if the view reports model space to view projection space transforms.
      Returns: True if the view returns transforms, false otherwise.
    void HideActiveWorkPlane()
      Description: Hide the active work plane of the view.
      Throws InvalidOperationException: Thrown when there is no active sketch plane, or when an error occurs during setting the sketch plane visibility.
    void HideCategoriesTemporary(ICollection<ElementId> elementIds)
      Description: Set multiple categories to be temporarily hidden in the view.
      @elementIds: Ids of the categories to be hidden
      Throws ArgumentException: Some elements in elementIds do not correspond to a Category.
      Throws ArgumentNullException: A non-optional argument was null
    void HideCategoryTemporary(ElementId elementId)
      Description: Set one category to be temporarily hidden in the view.
      @elementId: Id of the category to be hidden
      Throws ArgumentException: elementId does not correspond to a Category.
      Throws ArgumentNullException: A non-optional argument was null
    void HideElements(ICollection<ElementId> elementIdSet)
      Description: Sets the elements to be hidden in the view.
      @elementIdSet: A set of ElementIds to be hidden.
      Throws ArgumentNullException: Thrown when argument is .
      Throws ArgumentException: Thrown when the set of elements to be hidden is empty or one of the elements can not be hidden. Also thrown when the set of elements to be hidden includes the view itself.
      Throws InvalidOperationException: Thrown when document regeneration failed.
    void HideElementsTemporary(ICollection<ElementId> elementIdSet)
      Description: Set multiple elements to be temporarily hidden in the view. To hide a group completely, you must also include all members of all groups and nested groups in your input.
      @elementIdSet: Ids of the elements to be temporarily hidden.
      Throws ArgumentNullException: A non-optional argument was null
    void HideElementTemporary(ElementId elementId)
      Description: Set one element to be temporarily hidden in the view. To hide a group completely, you must also include all members of all groups and nested groups in your input, therefore you should use the version of this method that accepts multiple element ids as input.
      @elementId: The id of the element to be temporarily hidden.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsCategoryOverridable(ElementId categoryId)
      Description: Checks whether the category can have graphic overrides in this view.
      @categoryId: ElementId of the category.
      Returns: True if category can be overridden, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsElementVisibleInTemporaryViewMode(TemporaryViewMode mode, ElementId id)
      Description: Identifies if the input element is visible for the temporary view mode for this view.
      @mode: The temporary view mode. Only TemporaryHideIsolate and AnalyticalModel modes are supported by this option. Other modes will result in an exception.
      @id: The element id.
      Returns: True if the element is visible, false if the element is hidden in the view mode.
      Throws ArgumentException: This view mode is not supported for checking element visibility.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool IsFilterApplied(ElementId filterElementId)
      Description: Indicates if a filter is applied to the view.
      @filterElementId: ElementId of the filter.
      Returns: True if the filter is applied to the view, false otherwise.
      Throws ArgumentException: ElementId is not associated with a FilterElement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    bool IsInTemporaryViewMode(TemporaryViewMode mode)
      Description: Returns true if the view is in a particular temporary view mode.
      @mode: The mode.
      Returns: True if this view is in the temporary view mode indicated, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void IsolateCategoriesTemporary(ICollection<ElementId> elementIds)
      Description: Set categories to be temporarily isolated in the view.
      @elementIds: Ids of categories to be isolated.
      Throws ArgumentException: Some elements in elementIds do not correspond to a Category.
      Throws ArgumentNullException: A non-optional argument was null
    void IsolateCategoryTemporary(ElementId elementId)
      Description: Set one category to be temporarily isolated in the view.
      @elementId: Id of category to be isolated.
      Throws ArgumentException: elementId does not correspond to a Category.
      Throws ArgumentNullException: A non-optional argument was null
    void IsolateElementsTemporary(ICollection<ElementId> elementIds)
      Description: Set multiple elements to be temporarily isolated in the view. To isolate a group completely, you must also include all members of all groups and nested groups in your input.
      @elementIds: Ids of elements to be isolated.
      Throws ArgumentNullException: A non-optional argument was null
    void IsolateElementTemporary(ElementId elementId)
      Description: Set one element to be temporarily isolated in the view. To isolate a group completely, you must also include all members of all groups and nested groups in your input, therefore you should use the version of this method that accepts multiple element ids as input.
      @elementId: Id of element to be isolated.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsTemporaryHideIsolateActive()
      Description: Indicates if the view is temporarily hiding or isolating elements or categories.
      Returns: True if elements/categories are being temporarily hidden or isolated, false otherwise.
    bool IsTemporaryViewPropertiesModeEnabled()
      Description: Returns true when Temporary View Properties mode is in progress, false otherwise.
    static bool IsValidViewScale(int viewScale)
      Description: This validator checks that the view scale is in the allowable range.
      @viewScale: The denominator X in the view scale 1/X.
      Returns: True if the view scale is within the allowable range, false otherwise.
    bool IsValidViewTemplate(ElementId templateId)
      Description: Verifies that the view represented by templateId can be set as the controlling view template for this view.
      @templateId: The id to be validated as a view template for this view.
      Returns: True if the view is valid for us as a view template and compatible with this view, or if it is InvalidElementId, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsViewValidForTemplateCreation()
      Description: Verifies that the view is valid for template creation.
      Returns: True if the view can be used for view template creation, false otherwise.
    bool IsWorksetVisible(WorksetId worksetId)
      Description: Indicates whether the workset is visible in this view.
      @worksetId: Id of the workset.
      Returns: Whether the workset is visible.
      Throws ArgumentException: There is no workset with this Id in the document associated with this view.
      Throws ArgumentNullException: A non-optional argument was null
    void Print(View viewTemplate)
      Description: Print this view with the given view template and using the print setting of the current active document.
      @viewTemplate: The view template which apply to the view.
      Throws InvalidOperationException: Thrown when the view cannot be printed.
    void Print()
      Description: Print this view with the default view template and using the print setting of the current active document.
      Throws InvalidOperationException: Thrown when the view cannot be printed.
    void Print(View viewTemplate, bool useCurrentPrintSettings)
      Description: Print this view with the given view template, and either the view's document's print setting or the print setting of the current active document.
      @viewTemplate: The view template which apply to the view.
      @useCurrentPrintSettings: If true, print the view with the print setting of the current active document; otherwise with the view's document's print setting.
      Throws InvalidOperationException: Thrown when the view cannot be printed.
    void Print(bool useCurrentPrintSettings)
      Description: Print this view with the default view template, and either the view's document's print setting or the print setting of the current active document.
      @useCurrentPrintSettings: If true, print the view with the print setting of the current active document; otherwise with the view's document's print setting.
      Throws InvalidOperationException: Thrown when the view cannot be printed.
    void RemoveCalloutParent()
      Description: Replaces callout parent ID with InvalidElementId.
      Throws InvalidOperationException: This view is not a callout.
    void RemoveFilter(ElementId filterElementId)
      Description: Removes a filter from the view.
      @filterElementId: ElementId of the filter.
      Throws ArgumentException: Filter is not applied to the view. -or- ElementId is not associated with a FilterElement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    void RemoveLinkOverrides(ElementId linkId)
      Description: Deletes the graphical link overrides in the current view.
      @linkId: The id of the RevitLinkType or RevitLinkInstance.
      Throws ArgumentException: The input id is not a valid RevitLinkInstance or RevitLinkType id.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The view type does not support Visibility/Graphics Overriddes. -or- The view does not support link graphical overrides.
    void RestoreCalloutParent()
      Description: Restores callout parent ID to the original view ID if that view is still available.
      Throws InvalidOperationException: This view is not a callout.
    void SetBackground(ViewDisplayBackground background)
      Description: Sets the background for the view. Background can only be set for 3d views and for Sections/Elevations.
      @background: Background to set. See 'ViewDisplayBackground' class and its 'create' methods.
      Throws ArgumentException: The background object is invalid, or view has 'Rendering' style.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This view does not contain display-related properties.
    void SetCategoryHidden(ElementId categoryId, bool hide)
      Description: Sets if elements of the given category will be visible in this view.
      @categoryId: The ID of the category.
      @hide: True to make elements of this category invisible, false to make them visible.
      Throws ArgumentException: categoryId does not correspond to a Category. -or- Category cannot be hidden.
      Throws ArgumentNullException: A non-optional argument was null
    void SetCategoryOverrides(ElementId categoryId, OverrideGraphicSettings overrideGraphicSettings)
      Description: Sets graphic overrides for a category in view.
      @categoryId: Category to be overridden
      @overrideGraphicSettings: Object representing all graphic overrides of the category categoryId in view.
      Throws ArgumentException: Category cannot be overridden. -or- Fill pattern must be a drafting pattern. -or- Fill pattern Id must be invalidElementId or point to a LinePattern element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The view type does not support Visibility/Graphics Overriddes.
    void SetColorFillSchemeId(ElementId categoryId, ElementId schemeId)
      Description: Applies color fill scheme to this view.
      @categoryId: The id of category to apply a color fill scheme element.
      @schemeId: The id of the color fill scheme element.
      Throws ArgumentException: The schemeId can not be applied as the scheme id of categoryId in this view.
      Throws ArgumentNullException: A non-optional argument was null
    void SetDepthCueing(ViewDisplayDepthCueing depthCueing)
      Description: Sets the depth cueing settings for the view.
      @depthCueing: Depth cueing settings to set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This view does not contain display-related properties. -or- This view cannot use Depth Cueing
    void SetElementOverrides(ElementId elementId, OverrideGraphicSettings overrideGraphicSettings)
      Description: Sets graphic overrides for an element in the view.
      @elementId: Element to override.
      @overrideGraphicSettings: An object representing all graphic overrides of the element in view.
      Throws ArgumentException: elementId is not a valid Element identifier. -or- Fill pattern must be a drafting pattern. -or- Fill pattern Id must be invalidElementId or point to a LinePattern element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    void SetFilterOverrides(ElementId filterElementId, OverrideGraphicSettings overrideGraphicSettings)
      Description: Sets the overrides associated with a filter.
      @filterElementId: ElementId of the filter.
      @overrideGraphicSettings: The overrides to apply to the filter.
      Throws ArgumentException: ElementId is not associated with a FilterElement. -or- Fill pattern must be a drafting pattern. -or- Fill pattern Id must be invalidElementId or point to a LinePattern element.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    void SetFilterVisibility(ElementId filterElementId, bool visibility)
      Description: Sets the visibility of the elements associated with a filter.
      @filterElementId: The ElementId of the filter.
      @visibility: True if the elements associated with the filter are visible in the view, false otherwise.
      Throws ArgumentException: ElementId is not associated with a FilterElement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    void SetIsFilterEnabled(ElementId filterElementId, bool enable)
      Description: Sets the filter enabled flag.
      @filterElementId: The ElementId of the filter.
      @enable: True if the specified filter should be enabled in this view, false otherwise.
      Throws ArgumentException: Filter is not applied to the view. -or- ElementId is not associated with a FilterElement.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The element "this View" does not belong to a project document. -or- The view type does not support Visibility/Graphics Overriddes.
    void SetLinkOverrides(ElementId linkId, RevitLinkGraphicsSettings linkDisplaySettings)
      Description: Sets the graphic overrides of a RevitLinkType or RevitLinkInstance in the view.
      @linkId: The id of the RevitLinkType or RevitLinkInstance.
      @linkDisplaySettings: Settings representing all link graphic overrides in the view.
      Throws ArgumentException: The input id is not a valid RevitLinkInstance or RevitLinkType id. -or- The LinkedViewId of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The ViewFilterType of linkDisplaySettings has incorrect value. -or- The ViewRange of linkDisplaySettings has unsupported value. -or- The phase or pahse type of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The phase filter or phase filter type of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The view detail level or the type of view detail level of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The discipline or the discipline type of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The ColorFill of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The ObjectStyles of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The NestedLinks of linkDisplaySettings has incorrect value for the specified LinkVisibilityType. -or- The LineWeights of linkDisplaySettings has incorrect value for the specified LinkVisibilityType.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The view type does not support Visibility/Graphics Overriddes. -or- The view does not support link graphical overrides.
    void SetNonControlledTemplateParameterIds(ICollection<ElementId> newSet)
      Description: Sets the parameters that will not be included when this view is used as a template.
      @newSet: The parameter ids that should not be marked to be included.
      Throws ArgumentNullException: A non-optional argument was null
    void SetSketchyLines(ViewDisplaySketchyLines sketchyLines)
      Description: Sets the sketchy lines settings for the view.
      @sketchyLines: Sketchy Lines settings to set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This view does not contain display-related properties.
    void SetViewDisplayModel(ViewDisplayModel viewDisplayModel)
      Description: Sets the view display model settings for the view.
      @viewDisplayModel: View display model settings to set.
      Throws ArgumentException: The silhouette line style id is not a valid line style to apply to the view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This view does not contain display-related properties.
    void SetWorksetVisibility(WorksetId worksetId, WorksetVisibility visible)
      Description: Sets visibility for a workset in this view.
      @worksetId: Id of the workset.
      @visible: The visibility of the workset.
      Throws ArgumentException: There is no workset with this Id in the document associated with this view.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetWorksharingDisplayMode(WorksharingDisplayMode displayMode)
      Description: Sets the worksharing display mode for this view.
      @displayMode: The desired display mode. "Off" will turn off all worksharing display modes.
      Throws ArgumentException: This View does not support the requested worksharing display mode.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void ShowActiveWorkPlane()
      Description: Show the active work plane of the view.
      Throws InvalidOperationException: Thrown when there is no active sketch plane, or when an error occurs during setting the sketch plane visibility.
    ICollection<ElementId> SupportedColorFillCategoryIds()
      Description: Returns collection of all category ids that correspond to elements that can potentially be colored in this view according to a color fill scheme. The set may be different depending on the view type.
    bool SupportsRevealConstraints()
      Description: Checks that the view can have the Reveal Constraints mode activated.
      Returns: True if the view has a view type that allows Reveal Constraints mode to be activated.
    bool SupportsWorksharingDisplayMode(WorksharingDisplayMode mode)
      Description: Checks whether this view supports the given worksharing display mode.
      @mode: The mode of interest.
      Returns: Returns True if this view is a graphical view in a workshared document or if the desired mode is Off. Returns False if this view is a non-graphical view (such as a schedule or the project browser) or if this view is not in a workshared document.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void UnhideElements(ICollection<ElementId> elementIdSet)
      Description: Sets the elements to be shown in the given view if they are currently hidden.
      @elementIdSet: A set of ElementIds to be unhidden.
      Throws ArgumentNullException: Thrown when argument is .
      Throws ArgumentException: Thrown when the set of elements to be unhidden is empty or one of the elements can not be unhidden.
      Throws InvalidOperationException: Thrown when document regeneration failed.

--------------------------------------------------------------------------------

[CLASS] View3D
Full Name: Autodesk.Revit.DB.View3D
Description: Class for 3D views
Inherits: View

  PROPERTIES:
    bool IsLocked { get; }
      Description: Indicates if the view is locked.
    bool IsPerspective { get; }
      Description: Identifies whether this is a perspective view.
    bool IsSectionBoxActive { get; set; }
      Description: Identifies whether or not the section box is active in this 3D view.
    bool ProjectGridsOnSectionBox { get; set; }
      Description: This option projects all grids from the current 3d view on the bottom face of the section box. Only grids that are inside or intersects the section box

  METHODS:
    bool CanResetCameraTarget()
      Description: Checks whether the camera target can be reset for this view.
      Returns: True if camera target can be reset for this view, false otherwise.
    bool CanSaveOrientation()
      Description: Returns true if the View3D's orientation can be saved, false otherwise.
      Returns: True if the View3D's orientation can be saved, false otherwise.
    bool CanToggleBetweenPerspectiveAndIsometric()
      Description: Checks whether this view can toggle between perspective and isometric.
      Returns: True if this view can be toggled, false otherwise.
    static View3D CreateIsometric(Document document, ElementId viewFamilyTypeId)
      Description: Returns a new isometric View3D.
      @document: The document to which the new View3D will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new View3D. The type needs to be a ThreeDimensional ViewType.
      Returns: The new isometric View3D.
      Throws ArgumentException: This View Family Type is not a ThreeDimensional view type. -or- 3D view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static View3D CreatePerspective(Document document, ElementId viewFamilyTypeId)
      Description: Returns a new perspective View3D.
      @document: The document to which the new View3D will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new View3D. The type needs to be a ThreeDimensional ViewType.
      Returns: The new perspective View3D.
      Throws ArgumentException: This View Family Type is not a ThreeDimensional view type. -or- 3D view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ISet<ElementId> GetLevelsThatShowGrids()
      Description: Returns the list of levels ids where grids are displayed in this 3D view.
      Returns: The list of levels ids where grids are displayed in 3D views.
    ViewOrientation3D GetOrientation()
      Description: Gets the current non-saved orientation of the View3D.
      Returns: The current non-saved orientation of the View3D.
    RenderingSettings GetRenderingSettings()
      Description: Returns the current rendering settings for this 3d view.
      Returns: The returned object represents the current rendering settings. If you change the returned object, you need to call SetRenderingSettings to apply the new settings back to Revit.
    ViewOrientation3D GetSavedOrientation()
      Description: Gets the saved orientation of the View3D.
      Returns: The saved orientation of the View3D.
    BoundingBoxXYZ GetSectionBox()
      Description: Gets a copy of the section box for this 3D view.
      Returns: The section box. Note that the section box can be rotated and transformed and thus you will need to use Autodesk::Revit::DB::BoundingBoxXYZ::Transform to interpret the coordinates of the corners or sides of the box in model coordinates.
      Throws InvalidOperationException: Returns true if the view is not a view template.
    bool HasBeenLocked()
      Description: Identifies if the view has ever been locked.
    void HideGridsOnLevel(ElementId levelId)
      Description: This method hides the grid lines in this 3D view on the given Level.
      @levelId: The id of the Level where grids will not be displayed.
      Throws ArgumentNullException: A non-optional argument was null
    void OrientTo(XYZ forwardDirection)
      Description: Reorients the view to align with the forward direction.
      @forwardDirection: The forward direction.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: forwardDirection has zero length.
      Throws InvalidOperationException: View is locked and cannot be reoriented.
    void ResetCameraTarget()
      Description: Resets the camera target to the center of the field of view.
      Throws InvalidOperationException: The camera target cannot be reset for the view.
    void RestoreOrientationAndLock()
      Description: Locks the view and restores its orientation.
      Throws InvalidOperationException: View has never been locked.
    void SaveOrientation()
      Description: Converts the temporary orientation of the View3D into its saved orientation.
      Throws InvalidOperationException: The orientation of the View3D cannot be saved.
    void SaveOrientationAndLock()
      Description: Locks the view and saves its orientation
      Throws InvalidOperationException: Returns true if the view is not a view template. -or- The orientation of the View3D cannot be saved.
    void ScalePerspectiveCropBox(double multiplier)
      Description: Scale an existing crop box of the perspective view.
      @multiplier: Multiplier to change the view scale and the current crop box size on both X and Y.
      Throws InvalidOperationException: Returns true if the view is not a view template.
    void SetOrientation(ViewOrientation3D newViewOrientation3D)
      Description: Sets the temporary orientation of the View3D. The new orientation is not saved in the document.
      @newViewOrientation3D: The new orientation to set.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: View is locked and cannot be reoriented.
    void SetRenderingSettings(RenderingSettings settings)
      Description: Changes the rendering settings for this 3d view.
      @settings: The new rendering settings to be applied to this view.
      Throws ArgumentNullException: A non-optional argument was null
    void SetSectionBox(BoundingBoxXYZ boundingBoxXYZ)
      Description: Sets the section box for this 3D view.
      @boundingBoxXYZ: The bounding box to use for the section box. To turn off the section box, set IsSectionBoxActive to false. Individual bound enabled flags in the input box are ignored.
      Throws ArgumentException: Bounding box cannot be empty.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Returns true if the view is not a view template.
    void ShowGridsOnLevel(ElementId levelId)
      Description: This method displays the grid lines in this 3DView on the given Level.
      @levelId: The id of the Level where grids should be displayed.
      Throws ArgumentNullException: A non-optional argument was null
    void ShowGridsOnLevels(ISet<ElementId> levelsIds)
      Description: This method displays the grid lines in this 3D view on the given Levels.
      @levelsIds: Levels ids where grids lines will be displayed.
      Throws ArgumentNullException: A non-optional argument was null
    void ToggleToIsometric()
      Description: Toggles this view to isometric.
      Throws InvalidOperationException: This view cannot be toggled.
    void ToggleToPerspective()
      Description: Toggles this view to perspective.
      Throws InvalidOperationException: This view cannot be toggled.
    void Unlock()
      Description: Unlocks the view. Has no effect if the view is already unlocked.

--------------------------------------------------------------------------------

[ENUM] ViewAnchor
Full Name: Autodesk.Revit.DB.ViewAnchor
Description: An enumerated type listing options for the anchor point used by the placed view. The anchor point determines how the view position is updated if assigned to a saved position or swapped to another view.
Inherits: Enum

  Values:
    - ViewOrigin = 0
    - Center = 1
    - TopLeft = 2
    - TopRight = 3
    - BottomRight = 4
    - BottomLeft = 5

--------------------------------------------------------------------------------

[CLASS] ViewCropRegionShapeManager
Full Name: Autodesk.Revit.DB.ViewCropRegionShapeManager
Description: A class that provides access to settings related to the crop assigned to a view or a reference callout.
Remarks: This class manages all the settings that make up the model and annotation crop geometry for a given view or reference callout. You can obtain the settings for a view from GetCropRegionShapeManager. Obtain the settings for a reference callout from ElementId).The model crop region crops model elements, detail elements (such as insulation and detail lines), section boxes, and scope boxes at the model crop boundary. Visible crop boundaries of other related views are also cropped at the model crop boundary. The model crop region can be set as a polygonal boundary, a rectangular boundary, or rectangular boundary with one or more splits applied either horizontally or vertically. If a split is applied to the rectangular crop each resulting rectangular region is identified by a region index and occupies a percentage of the original crop rectangle. The regions may possibly be moved relative to one another.The annotation crop region fully crops annotation elements when it touches any portion of the annotation element, so that no partial annotations are drawn. Annotations (such as symbols, tags, keynotes, and dimensions) that reference hidden or cropped model elements do not display in the view, even if they are inside the annotation crop region. The annotation crop region is always rectangular and at minimum occupies the same area as the rectangular model crop (or the corresponding rectangular boundary around the non-rectangular model crop), but can be offset to be bigger than the model crop in order to display more annotations.
Implements: IDisposable

  PROPERTIES:
    double BottomAnnotationCropOffset { get; set; }
      Description: The offset from the bottom of the view crop that determines the location of the annotation crop bottom boundary.
    bool CanBeSplit { get; }
      Description: Verifies that the crop of the associated view is permitted to have multiple regions.
    bool CanHaveAnnotationCrop { get; }
      Description: Verifies that the view is allowed to have an annotation crop.
    bool CanHaveShape { get; }
      Description: Verifies that the crop of the associated view is permitted to have a non-rectangular shape.
    bool IsSplitHorizontally { get; }
      Description: Whether or not the view's crop is split (and the split is horizontal).
    bool IsSplitVertically { get; }
      Description: Whether or not the view's crop is split (and the split is vertical).
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double LeftAnnotationCropOffset { get; set; }
      Description: The offset from the left of the view crop that determines the location of the annotation crop left boundary.
    int NumberOfSplitRegions { get; }
      Description: The number of split crop regions (1 if the crop is not currently split).
    double RightAnnotationCropOffset { get; set; }
      Description: The offset from the right of the view crop that determines the location of the annotation crop right boundary.
    bool ShapeSet { get; }
      Description: Whether or not the view crop has a non-rectangular shape set.
    bool Split { get; }
      Description: Whether or not the view crop is split.
    double TopAnnotationCropOffset { get; set; }
      Description: The offset from the top of the view crop that determines the location of the annotation crop top boundary.

  METHODS:
    void Dispose()
    CurveLoop GetAnnotationCropShape()
      Description: Gets the annotation crop box assigned to the view.
      Returns: The annotation crop boundary.
      Throws InvalidOperationException: View is not allowed to have an annotation crop.
    IList<CurveLoop> GetCropShape()
      Description: Gets the crop boundaries that are curently active.
      Returns: The crop boundaries.
    double GetSplitRegionMaximum(int regionIndex)
      Description: Returns the proportional location of the maximum boundary of the specified split crop region.
      @regionIndex: Index of split crop region (numbering starts with 0).
      Returns: A value from 0 to 1 representing the maximum location for the region's split boundary. This number represents the location as a ratio along the non-split rectangular crop.
      Throws ArgumentException: The provided region index is invalid.
    double GetSplitRegionMinimum(int regionIndex)
      Description: Returns the proportional location of the minimum boundary of the specified split crop region.
      @regionIndex: Index of split crop region (numbering starts with 0).
      Returns: A value from 0 to 1 representing the minimum location for the region's split boundary. This number represents the location as a ratio along the non-split rectangular crop.
      Throws ArgumentException: The provided region index is invalid.
    XYZ GetSplitRegionOffset(int regionIndex)
      Description: Returns the offset for the specified split crop region.
      @regionIndex: Index of the split crop region (numbering starts with 0).
      Returns: A vector in model space representing the offset which is applied to the split crop region's boundary.
      Throws ArgumentException: The provided region index is invalid.
    bool IsCropRegionShapeValid(CurveLoop boundary)
      Description: Verifies that boundary represents one closed curve loop without self-intersections, consisting of non-zero length straight lines in a plane parallel to the view plane.
      @boundary: The crop boundary.
      Returns: True if the passed crop boundary represents one closed curve loop without self-intersections, consisting of non-zero length straight lines in a plane parallel to the view plane.
      Throws ArgumentNullException: A non-optional argument was null
    void RemoveCropRegionShape()
      Description: Removes any non-rectangular boundary of the view's crop.
      Throws InvalidOperationException: The crop of the associated view is not permitted to have a non-rectangular shape.
    void RemoveSplit()
      Description: Removes any split applied to the view's crop.
      Throws InvalidOperationException: The crop of the associated view is not permitted to have multiple regions.
    void RemoveSplitRegion(int regionIndex)
      Description: Removes one region in split crop.
      @regionIndex: Index of region to be deleted (numbering starts with 0).
      Throws ArgumentException: The provided region index cannot be deleted.
      Throws InvalidOperationException: The crop of the associated view is not permitted to have multiple regions. -or- The view has non-rectangular crop shape set.
    void SetCropShape(CurveLoop boundary)
      Description: Sets the boundary of the view's crop to the specified shape.
      @boundary: The crop boundary.
      Throws ArgumentException: Boundary in boundary should represent one closed curve loop without self-intersections, consisting of non-zero length straight lines in a plane parallel to the view plane.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The crop of the associated view is not permitted to have a non-rectangular shape.
    void SplitRegionHorizontally(int regionIndex, double leftPart, double rightPart)
      Description: Splits horizontally one region in split crop.
      @regionIndex: Index of region to be split horizontally (numbering starts with 0).
      @leftPart: Relative portion of the original region to become the new left region (0 to 1).
      @rightPart: Relative portion of the original region to become the new right region (0 to 1).
      Throws ArgumentException: The provided view region proportions are not valid. -or- The provided region index is invalid.
      Throws InvalidOperationException: The crop of the associated view is not permitted to have multiple regions. -or- The view has non-rectangular crop shape set. -or- The view crop is already split vertically.
    void SplitRegionVertically(int regionIndex, double topPart, double bottomPart)
      Description: Splits vertically one region in split crop.
      @regionIndex: Index of region to be split vertically (numbering starts with 0).
      @topPart: Relative portion of the original region to become the new top region (0 to 1).
      @bottomPart: Relative portion of the original region to become the new bottom region (0 to 1).
      Throws ArgumentException: The provided view region proportions are not valid. -or- The provided region index is invalid.
      Throws InvalidOperationException: The crop of the associated view is not permitted to have multiple regions. -or- The view has non-rectangular crop shape set. -or- The view crop is already split horizontally.

--------------------------------------------------------------------------------

[ENUM] ViewDetailLevel
Full Name: Autodesk.Revit.DB.ViewDetailLevel
Description: Detail level of the view
Inherits: Enum

  Values:
    - Undefined = 0
    - Coarse = 1
    - Medium = 2
    - Fine = 3

--------------------------------------------------------------------------------

[ENUM] ViewDiscipline
Full Name: Autodesk.Revit.DB.ViewDiscipline
Description: Discipline of the view
Inherits: Enum

  Values:
    - Architectural = 1
    - Structural = 2
    - Mechanical = 4
    - Electrical = 8
    - Plumbing = 16
    - Coordination = 4095

--------------------------------------------------------------------------------

[CLASS] ViewDisplayBackground
Full Name: Autodesk.Revit.DB.ViewDisplayBackground
Description: Set of values that control how background is drawn in a view. Background can only be set for a 3d view or for a section or elevation view.
Implements: IDisposable

  PROPERTIES:
    Color BackgroundColor { get; }
      Description: The color of the horizon when the type is 'Gradient'.
    Color GroundColor { get; }
      Description: The color of the ground when the type is 'Gradient' or 'SunAndClouds'.
    double HorizontalImageOffset { get; }
      Description: The distance between the left viewport boundary and the left edge of the background image.
    double HorizontalImageScale { get; }
      Description: The horizontal scale of the background image; the scale of 1.0 puts the image pixel-to-pixel.
    ViewDisplayBackgroundImageFlags ImageFlags { get; }
      Description: The image alignment indicators when the type is 'Image'.
    string ImagePath { get; }
      Description: The path to the image file when the type is 'Image'.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Color SkyColor { get; }
      Description: The color of the sky when the type is 'Gradient'.
    ViewDisplayBackgroundType Type { get; }
      Description: The type of the background.
    double VerticalImageOffset { get; }
      Description: The distance between the bottom viewport boundary and the bottom edge of the background image.
    double VerticalImageScale { get; }
      Description: The vertical scale of the background image; the scale of 1.0 puts the image pixel-to-pixel.

  METHODS:
    static ViewDisplayBackground CreateGradient(Color skyColor, Color horizonColor, Color groundColor)
      Description: Creates an object that can be passed to ViewDisplayBackground) method to set the background of the Gradient type.
      @skyColor: The top of the sky gradient if the sky is visible.
      @horizonColor: The bottom or the sky gradient if the sky is visible, or the top of the ground gradient otherwise.
      @groundColor: The ground color if the sky is visible (ground shown in uniform color), or the bottom of the ground gradient if the sky is not visible.
      Returns: New background object to pass to ViewDisplayBackground).
      Throws ArgumentNullException: A non-optional argument was null
    static ViewDisplayBackground CreateImage(string imagePath, ViewDisplayBackgroundImageFlags flags, UV imageOffsets, UV imageScales)
      Description: Creates an object that can be passed to ViewDisplayBackground) method to set the background of the Image type.
      @imagePath: File path with the image to be used.
      @flags: Combination of flags (binary) that control how image is displayed in relation to the view/crop boundary.
      @imageOffsets: Horizontal (u) and vertical (v) offsets of the image.
      @imageScales: Horizontal (u) and vertical (v) scales of the image (1 == no change).
      Returns: New background object to pass to ViewDisplayBackground).
      Throws ArgumentException: The file specified by imagePath is not an image file. A valid image file should be in one of the following formats: bmp, jpg, jpeg, png, tif.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws FileArgumentNotFoundException: The file specified by imagePath doesn't exist.
    static ViewDisplayBackground CreateSky()
      Description: Creates an object that can be passed to ViewDisplayBackground) method to set the background of the SunAndClouds type.
      Returns: New background object to pass to ViewDisplayBackground).
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ViewDisplayBackgroundImageFlags
Full Name: Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags
Description: A collection of bit flags that control how the background image is positioned in relation to the crop region (or the view boundary).
Inherits: Enum

  Values:
    - None = 0
    - FitToScreen = 1
    - FixedAspectRatio = 2
    - UseTiling = 4

--------------------------------------------------------------------------------

[ENUM] ViewDisplayBackgroundType
Full Name: Autodesk.Revit.DB.ViewDisplayBackgroundType
Description: A collection of settings defining the type of the view background
Inherits: Enum

  Values:
    - None = 256
    - Gradient = 257
    - Image = 258
    - SunAndClouds = 512

--------------------------------------------------------------------------------

[CLASS] ViewDisplayDepthCueing
Full Name: Autodesk.Revit.DB.ViewDisplayDepthCueing
Description: Represents the settings for depth cueing.
Implements: IDisposable

  PROPERTIES:
    bool EnableDepthCueing { get; set; }
      Description: True to enable depth cueing. False to disable it.
    int EndPercentage { get; }
      Description: The end percentage defines where depth cueing ends. Values between 0 and 100.
    int FadeTo { get; set; }
      Description: The fade to defines the maximum fading in per cent. Values between 0 and 100.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int StartPercentage { get; }
      Description: The start percentage defines where depth cueing starts. Values between 0 and 100.

  METHODS:
    void Dispose()
    void SetStartEndPercentages(int startPercentage, int endPercentage)
      Description: Sets start and end percentages.
      @startPercentage: The start percentage defines where depth cueing starts.
      @endPercentage: The end percentage defines where depth cueing ends.
      Throws ArgumentOutOfRangeException: The start and end percentages values are not valid. The valid range is 0 to 100 and start is smaller than end.

--------------------------------------------------------------------------------

[ENUM] ViewDisplayEdges
Full Name: Autodesk.Revit.DB.ViewDisplayEdges
Description: A collection of settings defining how visible edges are displayed
Inherits: Enum

  Values:
    - None = 0
    - Simple = 1

--------------------------------------------------------------------------------

[CLASS] ViewDisplayModel
Full Name: Autodesk.Revit.DB.ViewDisplayModel
Description: Represents the settings for displaying model graphics. version 2: m_showHiddenLines type changed bool -> ShowHiddenLinesValues::Enum
Implements: IDisposable

  PROPERTIES:
    bool EnableSilhouettes { get; set; }
      Description: True to show silhouettes edges. False to disable showing them.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ShowHiddenLinesValues ShowHiddenLines { get; set; }
      Description: True to enable hidden lines. False to disable showing them.
    ElementId SilhouetteEdgesGStyleId { get; set; }
      Description: Style ID for silhouette edges
    bool SmoothEdges { get; set; }
      Description: True to enable "smooth edge" (anti-aliasing) effect. False to disable it.
    int Transparency { get; set; }
      Description: The percentage (0..100) of surface transparency 0 means the surfaces are opaque, 100 means they are fully transparent

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ViewDisplaySketchyLines
Full Name: Autodesk.Revit.DB.ViewDisplaySketchyLines
Description: Represents the settings for sketchy lines.
Implements: IDisposable

  PROPERTIES:
    bool EnableSketchyLines { get; set; }
      Description: True to enable sketchy lines visibility. False to disable it.
    int Extension { get; set; }
      Description: The extension scale value. Controls the magnitude of line's extension. Values between 0 and 10.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    int Jitter { get; set; }
      Description: The jitter defines jitteriness of the line. Values between 0 and 10.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ViewDrafting
Full Name: Autodesk.Revit.DB.ViewDrafting
Description: ViewDrafting represents a drafting view within the model.
Inherits: View

  METHODS:
    static ViewDrafting Create(Document document, ElementId viewFamilyTypeId)
      Description: Creates a new ViewDrafting in the model.
      @document: The document in which the new drafting view will be created.
      @viewFamilyTypeId: The id of the ViewFamilyType that should be assigned to the new drafting view.
      Returns: The newly created drafting view.
      Throws ArgumentException: viewFamilyTypeId is not a valid ViewFamilyType for a drafting view.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ViewDuplicateOption
Full Name: Autodesk.Revit.DB.ViewDuplicateOption
Description: Options for duplicating views
Inherits: Enum

  Values:
    - Duplicate = 0
    - AsDependent = 1
    - WithDetailing = 2

--------------------------------------------------------------------------------

[ENUM] ViewFamily
Full Name: Autodesk.Revit.DB.ViewFamily
Description: An enumerated type that corresponds to the type of a Revit view.
Inherits: Enum

  Values:
    - Invalid = 101
    - ThreeDimensional = 102
    - Walkthrough = 103
    - ImageView = 104
    - Schedule = 105
    - CostReport = 106
    - Sheet = 107
    - Drafting = 108
    - FloorPlan = 109
    - AreaPlan = 110
    - CeilingPlan = 111
    - Section = 112
    - Detail = 113
    - Elevation = 114
    - LoadsReport = 115
    - PressureLossReport = 116
    - Legend = 117
    - PanelSchedule = 118
    - GraphicalColumnSchedule = 119
    - StructuralPlan = 120
    - SystemsAnalysisReport = 121

--------------------------------------------------------------------------------

[CLASS] ViewFamilyType
Full Name: Autodesk.Revit.DB.ViewFamilyType
Description: Represents a type of a Revit view.
Remarks: ViewFamilyTypes represent possible types for a Revit view and contain view type related properties and options such as the default template associated to views created from this type. They are commonly input to new View creation methods in the Revit API.
Inherits: ElementType

  PROPERTIES:
    ElementId DefaultTemplateId { get; set; }
      Description: The default template id assigned to this view type.
    PlanViewDirection PlanViewDirection { get; set; }
      Description: The PlanViewDirection of this view.
    ViewFamily ViewFamily { get; }
      Description: The ViewFamily for this view type.

  METHODS:
    bool IsValidDefaultTemplate(ElementId templateId)
      Description: Verifies that the input can be used as a default template for this view type.
      @templateId: Id to be validated as default template.
      Returns: True if %templateId% is valid as default template, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ViewNavigationToolSettings
Full Name: Autodesk.Revit.DB.ViewNavigationToolSettings
Description: Represents the settings contained in the document associated to the View Navigation tools (such as the View Cube).
Inherits: Element

  METHODS:
    HomeCamera GetHomeCamera()
      Description: Gets a copy of the structure containing information about the store Home view orientation.
      Returns: A copy of the structure containing information about the store Home view orientation, or if there is no home view set for this document.
    static ViewNavigationToolSettings GetViewNavigationToolSettings(Document pADoc)
      Description: Gets the instance of the settings for the given document.
      @pADoc: The document.
      Returns: The instance of the settings for the given document.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsHomeCameraSet()
      Description: Checks if the home view is set in the settings.
      Returns: Returns true if home view is set, otherwise false.

--------------------------------------------------------------------------------

[CLASS] ViewNode
Full Name: Autodesk.Revit.DB.ViewNode
Description: A render node that represents a view.
Remarks: See also: Autodesk::Revit::DB::IExportContext::OnViewBegin.
Inherits: RenderNode

  PROPERTIES:
    int LevelOfDetail { get; set; }
      Description: The level of detail the view is going to be rendered at.
    ElementId ViewId { get; }
      Description: The Id of the view element.

  METHODS:
    CameraInfo GetCameraInfo()
      Description: Information about the observation point (the camera) of the view.
      Returns: An instance of CameraInfo or if there is no info associated with the view

--------------------------------------------------------------------------------

[CLASS] ViewOrientation3D
Full Name: Autodesk.Revit.DB.ViewOrientation3D
Description: Container for the point and vectors which define View3D's orientation.
Implements: IDisposable

  CONSTRUCTORS:
    new ViewOrientation3D(XYZ eyePosition, XYZ upDirection, XYZ forwardDirection)
      Description: Constructs a new ViewOrientation3D using the input eye position, up and forward directions.
      @eyePosition: The eye position
      @upDirection: The up direction. This vector will be normalized. Up direction must be perpendicular to the forward direction.
      @forwardDirection: The forward direction. This vector will be normalized. Forward direction must be perpendicular to the up direction.
      Throws ArgumentException: One or both of the input vectors cannot be normalized.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: upDirection has zero length. -or- forwardDirection has zero length.
      Throws ArgumentsInconsistentException: The vectors upDirection and forwardDirection are not perpendicular.

  PROPERTIES:
    XYZ EyePosition { get; }
      Description: The eye position point
    XYZ ForwardDirection { get; }
      Description: The forward direction vector
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ UpDirection { get; }
      Description: The up direction vector

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[ENUM] ViewPlacementOnSheetStatus
Full Name: Autodesk.Revit.DB.ViewPlacementOnSheetStatus
Description: Indicates whether the View is placed on a Sheet.
Remarks: Some Views can be placed on one or more Sheets completely or partially. For example, a Schedule divided in segments, and only some of them are placed on Sheets.
Inherits: Enum

  Values:
    - NotApplicable = 0
    - NotPlaced = 1
    - PartiallyPlaced = 2
    - CompletelyPlaced = 3

--------------------------------------------------------------------------------

[CLASS] ViewPlan
Full Name: Autodesk.Revit.DB.ViewPlan
Description: Represents floor plan, area plan, ceiling plan, and structural plan views in Revit.
Remarks: In a plan view, the model is viewed as if cut by the cut plane and viewed from above, looking down. In ceiling plan views and structural plan views which look up, the model is viewed as if cut by the cut plane, and viewed as if looking down at a mirror.
Inherits: View

  PROPERTIES:
    AreaScheme AreaScheme { get; }
      Description: The area scheme.

  METHODS:
    IList<PlanViewRangeError> CheckPlanViewRangeValidity(PlanViewRange planViewRange)
      Description: Checks if the plan view range is valid.
      @planViewRange: The view range to validate.
      Returns: List of enums describing any errors in the plan view range.
      Throws ArgumentNullException: A non-optional argument was null
    static ViewPlan Create(Document document, ElementId viewFamilyTypeId, ElementId levelId)
      Description: Creates a new ViewPlan.
      @document: The document to which the ViewPlan will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new ViewPlan. The type needs to be a FloorPlan, CeilingPlan, AreaPlan, or StructuralPlan ViewType.
      @levelId: The id of the Level to associate with the new plan view.
      Returns: The new ViewPlan.
      Throws ArgumentException: This view family type is not a plan view type. -or- The ElementId levelId does not correspond to a Level. -or- StructuralPlans can only be created when the structural discipline is enabled whereas FloorPlans and CeilingPlans can only be created when architecture or MEP disciplines are enabled. -or- Plan view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewPlan CreateAreaPlan(Document document, ElementId areaSchemeId, ElementId levelId)
      Description: Creates a new area plan ViewPlan.
      @document: The document to which the area plan will be added.
      @areaSchemeId: The id of the AreaScheme which will be used by the area plan.
      @levelId: The id of the Level to associate with the area plan.
      Returns: The new area plan ViewPlan.
      Throws ArgumentException: The AreaScheme id is not valid and cannot be used for area plan views. -or- The ElementId levelId does not correspond to a Level. -or- Plan view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    ElementId GetUnderlayBaseLevel()
      Description: Returns the element id of the level that defines the bottom of the underlay range.
      Returns: If InvalidElementId is returned, then the underlay base level is not set and no elements will be displayed as underlay.
    UnderlayOrientation GetUnderlayOrientation()
      Description: Returns the underlay orientation of this view.
      Returns: The underlay orientation for this view.
    ElementId GetUnderlayTopLevel()
      Description: Returns the element id of the level that defines the top of the underlay range.
      Returns: If the underlay base level is a valid level, and this method returns InvalidElementId, then the underlay range is unbounded, and consists of everything above the underlay base level.
    PlanViewRange GetViewRange()
      Description: Gets the view range.
      Returns: The view range.
    void SetUnderlayBaseLevel(ElementId levelId)
      Description: Sets the level whose elevation will determine the bottom of the underlay range. The elevation of the next highest level will be used to determine the top of the underlay range.
      @levelId: The element id of a level in the project or else InvalidElementId.
      Throws ArgumentException: The ElementId levelId does not correspond to a Level in the project.
      Throws ArgumentNullException: A non-optional argument was null
    void SetUnderlayOrientation(UnderlayOrientation uo)
      Description: Sets the underlay orientation for this view.
      @uo: The underlay orientation for this view.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void SetUnderlayRange(ElementId baseLevelId, ElementId topLevelId)
      Description: Sets the underlay base and underlay top to the specified levels.
      @baseLevelId: The element id of a level in the project or InvalidElementId. If InvalidElementId, then the underlay base level is not set and no elements will be displayed as underlay.
      @topLevelId: The element id of a level in the project or InvalidElementId. If InvalidElementId, then the underlay range is unbounded.
      Throws ArgumentException: The ElementId baseLevelId does not correspond to a Level in the project. -or- The ElementId topLevelId does not correspond to a Level in the project. -or- The elevation of level topLevelId must be greater than the elevation of level baseLevelId.
      Throws ArgumentNullException: A non-optional argument was null
    void SetViewRange(PlanViewRange planViewRange)
      Description: Sets the view range.
      @planViewRange: The view range.
      Throws ArgumentException: Plan view range is not valid.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[ENUM] ViewPlanType
Full Name: Autodesk.Revit.DB.ViewPlanType
Description: An enumerated type listing plan view types.
Inherits: Enum

  Values:
    - FloorPlan = 1
    - CeilingPlan = 2

--------------------------------------------------------------------------------

[CLASS] Viewport
Full Name: Autodesk.Revit.DB.Viewport
Description: An element that establishes the placement of a view on a sheet.
Remarks: Viewports are used in Revit for purposes other than placement of views on sheets. Thus iteration of viewport elements in the model may locate viewports which are not assigned to sheets; you can use the SheetId property to filter these out.
Inherits: Element

  PROPERTIES:
    double LabelLineLength { get; set; }
      Description: The length of the viewport label line in sheet space, measured in feet.
    XYZ LabelOffset { get; set; }
      Description: The offset is a two-dimensional vector from left bottom corner of the viewport with Rotation set to None to the left end of the viewport label line. The Z coordinate is ignored.
    ViewportRotation Rotation { get; set; }
      Description: The rotation of the viewport on the sheet.
    ElementId SheetId { get; }
      Description: The element id of the ViewSheet on which the viewport appears, or InvalidElementId if this viewport does not associate a view with placement onto a sheet.
    ViewAnchor ViewAnchor { get; }
      Description: Specifies the method by which the view will be positioned on the sheet and for the case when it is swapped to another view. Default is set to ViewAnchor.ViewOrigin.
    ElementId ViewId { get; set; }
      Description: The element id of the associated View.
    XYZ ViewPosition { get; }
      Description: Specifies view's position. Default is set to XYZ.Zero.

  METHODS:
    static bool CanAddViewToSheet(Document document, ElementId viewSheetId, ElementId viewId)
      Description: Verifies that the view can be added to the ViewSheet.
      @document: The document in which the views reside.
      @viewSheetId: The ViewSheet on which the view will be placed.
      @viewId: The view which will be checked to see if it can be placed on the sheet.
      Returns: True if the view can be added to the ViewSheet, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static Viewport Create(Document document, ElementId viewSheetId, ElementId viewId, XYZ point)
      Description: Creates a new Viewport at a given location on a sheet.
      @document: The document to which the new Viewport will be added.
      @viewSheetId: The ViewSheet on which the new Viewport will be placed.
      @viewId: The view shown in the Viewport.
      @point: The new Viewport will be centered on this point.
      Returns: The new Viewport.
      Throws ArgumentException: viewSheetId is not a ViewSheet. -or- viewId cannot be added to the ViewSheet. -or- Plan view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ForbiddenForDynamicUpdateException: This method may not be called during dynamic update.
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    XYZ GetBoxCenter()
      Description: Returns the center of the outline of the viewport on the sheet, excluding the viewport label.
      Returns: The center of the outline of the viewport on the sheet.
      Throws InvalidOperationException: The viewport is not on a sheet.
    Outline GetBoxOutline()
      Description: Returns the outline of the viewport on the sheet, excluding the viewport label.
      Returns: The outline of the viewport on the sheet.
      Throws InvalidOperationException: The viewport is not on a sheet.
    Outline GetLabelOutline()
      Description: Gets the outline viewport's label on the sheet.
      Returns: The outline of the viewport's label on the sheet. The outline may be empty if there is no label.
      Throws InvalidOperationException: The viewport is not on a sheet.
    XYZ GetPositionAtViewAnchor(ViewAnchor viewAnchor)
      Description: Gets the position coordinates at the ViewAnchor.
      @viewAnchor: The viewAnchor at which the position is requested.
      Returns: The position at the ViewAnchor.
      Throws ArgumentException: The given value of viewAnchor cannot be applied to this Viewport.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    Transform GetProjectionToSheetTransform()
      Description: Returns the transform from the view's projection space to the sheet space.
      Returns: The transform from the view's projection space to the sheet space.
      Throws InvalidOperationException: The viewport is not on a sheet. -or- The viewport does not have transforms.
    bool HasViewportTransforms()
      Description: Indicates if the viewport has transforms.
      Returns: True if the viewport has transforms, false otherwise.
    bool IsViewIdValidForViewport(ElementId viewId)
      Description: Verifies that the Viewport can change it's view id to the input %viewId%.
      @viewId: The view which will be checked to see if it can be applied to Viewport.
      Returns: True if the %viewId% is valid for the viewport, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    void SetBoxCenter(XYZ newCenterPoint)
      Description: Moves this viewport so that the center of the box outline (excluding the viewport label) is at a given point.
      @newCenterPoint: The desired center for the box outline.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: The viewport is not on a sheet.
    void SetViewAnchorAndPosition(ViewAnchor viewAnchor, XYZ position)
      Description: Sets the ViewAnchor and position to Viewport.
      @viewAnchor: The viewAnchor to be assigned.
      @position: The position to be assigned.
      Throws ArgumentException: The given value of viewAnchor cannot be applied to this Viewport.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[ENUM] ViewportRotation
Full Name: Autodesk.Revit.DB.ViewportRotation
Description: Rotation of the viewport
Inherits: Enum

  Values:
    - None = 0
    - Clockwise = 1
    - Counterclockwise = 2

--------------------------------------------------------------------------------

[CLASS] ViewPosition
Full Name: Autodesk.Revit.DB.ViewPosition
Description: This class represents the view position element.
Inherits: Element

  PROPERTIES:
    XYZ Position { get; set; }
      Description: Specifies view's position.
    ViewAnchor ViewAnchor { get; set; }
      Description: Specifies the method by which the view will be positioned on the sheet. Default is set to ViewAnchor.ViewOrigin.

  METHODS:
    static ViewPosition Create(Document document, string name, XYZ position, ViewAnchor viewAnchor)
      Description: Creates a new view position element.
      @document: The document to which the ViewPosition will be added.
      @name: The name of the view position element.
      @position: The position of the view.
      @viewAnchor: The method the view will be positioned on the sheet.
      Returns: The newly created view position element.
      Throws ArgumentException: document is not a project document. -or- name is an empty string or contains only whitespace. -or- name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~". -or- The given value for name is already in use as a view position name.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    IList<ElementId> GetPlacedViewportIdsForViewPosition()
      Description: Gets the placed viewport ids for the view position.
      Returns: The placed viewport ids for the view position.

--------------------------------------------------------------------------------

[CLASS] ViewSchedule
Full Name: Autodesk.Revit.DB.ViewSchedule
Description: A schedule view.
Remarks: The ViewSchedule class represents schedules and other schedule-like views, including single-category and multi-category schedules, key schedules, material takeoffs, view lists, sheet lists, keynote legends, revision schedules, and note blocks. The ViewSchedule class is not used for panel schedules (see PanelScheduleView) or graphical column schedules. A schedule is a tabular representation of data. A typical schedule shows all elements of a category (doors, rooms, etc.) with each row representing an element and each column representing a parameter. This basic structure can be modified using filters, sorting, grouping, totals, formulas, and other features. The ScheduleDefinition class contains most settings that determine the contents of a schedule, including category, fields, filters, and sorting. A graphical representation of a schedule can be placed on a sheet using the ScheduleSheetInstance class.
Inherits: TableView

  PROPERTIES:
    ElementId BodyTextTypeId { get; set; }
      Description: Defines the default text style used for the data section of the schedule.
    ScheduleDefinition Definition { get; }
      Description: The primary ScheduleDefinition.
    ScheduleDefinition EmbeddedDefinition { get; }
      Description: The embedded ScheduleDefinition.
    bool HasStripedRows { get; set; }
      Description: Indicates whether this schedule has striped rows.
    ElementId HeaderTextTypeId { get; set; }
      Description: Defines the default text style used in the column headers in the body section of the schedule.
    static bool IsHeaderFrozen { get; set; }
      Description: A static property defining if the schedule header frozen setting is turned on or off in current Revit Application Session.
    bool IsInternalKeynoteSchedule { get; }
      Description: Identifies if this ViewSchedule is an internal schedule used when keynotes are filtered based on the elements that are shown on a sheet.
    bool IsTitleblockRevisionSchedule { get; }
      Description: Identifies if this ViewSchedule is an internal schedule used to display revision schedules as part of a titleblock.
    string KeyScheduleParameterName { get; set; }
      Description: In a key schedule, the name of the parameter for choosing one of the keys.
    double RowHeight { get; set; }
      Description: Defines the schedule body rows height.
    RowHeightOverrideOptions RowHeightOverride { get; set; }
      Description: Defines the override that is applied to the row height.
    ElementId TitleTextTypeId { get; set; }
      Description: Defines the default text style used in the header section of the schedule.
    bool UseStripedRowsOnSheets { get; set; }
      Description: Indicates whether a property setting of true will also change the display of this schedule to show striped rows on a sheet. If true, setting that property to true will also change the display. If false, striped rows will not display for this schedule on a sheet no matter what value is set for HasStripedRows.

  METHODS:
    bool CanGroupHeaders(int top, int left, int bottom, int right)
      Description: Indicates if selected headers can be grouped for this schedule.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      Returns: True if the selected headers can be grouped, false otherwise.
    bool CanUngroupHeaders(int top, int left, int bottom, int right)
      Description: Indicates if selected headers can be ungrouped.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      Returns: True if the selected headers can be grouped, false otherwise.
    static ViewSchedule CreateKeynoteLegend(Document document)
      Description: Creates a keynote legend.
      @document: The document to which the new schedule will be added.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateKeySchedule(Document document, ElementId categoryId)
      Description: Create a key schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category of elements that the schedule's keys will be associated with.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a key schedule.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateMaterialTakeoff(Document document, ElementId categoryId)
      Description: Creates a material takeoff.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a material takeoff.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateNoteBlock(Document document, ElementId familyId)
      Description: Creates a note block.
      @document: The document to which the new schedule will be added.
      @familyId: The ID of the family whose elements will be included in the schedule.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document. -or- familyId is not a valid family for a note block.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateRevisionSchedule(Document document)
      Description: Creates a revision schedule.
      @document: The titleblock family document to which the new schedule will be added.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a titleblock family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateSchedule(Document document, ElementId categoryId, ElementId areaSchemeId)
      Description: Creates a regular schedule that can relate to a specific area scheme.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      @areaSchemeId: The ID of an area scheme in an area schedule, InvalidElementId otherwise.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a regular schedule. -or- In a non-area schedule, areaSchemeId is not InvalidElementId. -or- In an area schedule, areaSchemeId is not the ID of an area scheme.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateSchedule(Document document, ElementId categoryId)
      Description: Creates a regular schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a regular schedule. -or- The Areas category was specified but an area scheme ID was not provided.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateSheetList(Document document)
      Description: Creates a sheet list.
      @document: The document to which the new schedule will be added.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSchedule CreateViewList(Document document)
      Description: Creates a view list.
      @document: The document to which the new schedule will be added.
      Returns: The newly created schedule.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    void DeleteSegment(int segmentIndex)
      Description: Deletes a schedule segment.
      @segmentIndex: Zero-based index of the segment.
      Throws ArgumentException: The segment index should start from 0 and be less than the total segment count.
      Throws InvalidOperationException: This ViewSchedule is not split yet.
    void Export(string folder, string name, ViewScheduleExportOptions options)
      Description: Exports the schedule data to a text file.
      @folder: Path to the location where the file will be saved.
      @name: Name of file.
      @options: Options that relate to schedule export.
      Throws ArgumentException: NullOrEmpty -or- Contains invalid characters.
      Throws ArgumentNullException: A non-optional argument was null
      Throws FileAccessException: The path indicated could not be accessed.
      Throws InvalidPathArgumentException: The folder does not exist.
    static string GetDefaultNameForKeynoteLegend(Document document)
      Description: Gets the default view name that will be used when creating a keynote legend.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForKeySchedule(Document document, ElementId categoryId)
      Description: Gets the default view name that will be used when creating a key schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category of elements that the schedule's keys will be associated with.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a key schedule.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForMaterialTakeoff(Document document, ElementId categoryId)
      Description: Gets the default view name that will be used when creating a material takeoff.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a material takeoff.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForNoteBlock(Document document)
      Description: Gets the default view name that will be used when creating a note block.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForRevisionSchedule(Document document)
      Description: Gets the default view name that will be used when creating a revision schedule.
      @document: The titleblock family document to which the new schedule will be added.
      Returns: The default view name.
      Throws ArgumentException: document is not a titleblock family.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForSchedule(Document document, ElementId categoryId, ElementId areaSchemeId)
      Description: Gets the default view name that will be used when creating a schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      @areaSchemeId: The ID of an area scheme in an area schedule, InvalidElementId otherwise.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a regular schedule. -or- In a non-area schedule, areaSchemeId is not InvalidElementId. -or- In an area schedule, areaSchemeId is not the ID of an area scheme.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForSchedule(Document document, ElementId categoryId)
      Description: Gets the default view name that will be used when creating a regular schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category whose elements will be included in the schedule, or InvalidElementId for a multi-category schedule.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a regular schedule. -or- The Areas category was specified but an area scheme ID was not provided.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForSheetList(Document document)
      Description: Gets the default view name that will be used when creating a sheet list.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultNameForViewList(Document document)
      Description: Gets the default view name that will be used when creating a view list.
      @document: The document to which the new schedule will be added.
      Returns: The default view name.
      Throws ArgumentException: document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
    static string GetDefaultParameterNameForKeySchedule(Document document, ElementId categoryId)
      Description: Gets the default parameter name that will be used when creating a key schedule.
      @document: The document to which the new schedule will be added.
      @categoryId: The ID of the category of elements that the schedule's keys will be associated with.
      Returns: The default parameter name.
      Throws ArgumentException: document is not a project document. -or- categoryId is not a valid category for a key schedule.
      Throws ArgumentNullException: A non-optional argument was null
    ScheduleHeightsOnSheet GetScheduleHeightsOnSheet()
      Description: Gets the heights of schedule title, column header and each schedule body row.
      Returns: The ScheduleHeightsOnSheet which contains heights information of a schedule on sheet.
    IList<ElementId> GetScheduleInstances(int segmentIndex)
      Description: Gets the instances ids of schedule or schedule segment.
      @segmentIndex: Index of the segment.
      Returns: The array of schedule sheet instance element ids of schedule or schedule segment.
      Throws ArgumentException: The segment index should start from -1 and be less than the total segment count.
    int GetSegmentCount()
      Description: Gets the total count of schedule segments.
      Returns: The total count of schedule segments. 1 means the schedule is not split yet.
    double GetSegmentHeight(int segmentIndex)
      Description: Gets the segment height.
      @segmentIndex: Zero-based index of the segment.
      Returns: The segment height value.
      Throws ArgumentException: The segment index should start from 0 and be less than the total segment count.
    Color GetStripedRowsColor(StripedRowPattern index)
      Description: Gets the color applied to part of the pattern for a schedule with striped rows.
      @index: The part of the striped row pattern.
      Returns: The applied color of the pattern part.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    TableData GetTableData()
      Description: Gets the writable table data object.
      Returns: The schedule data object.
    static ICollection<ElementId> GetValidCategoriesForKeySchedule()
      Description: Gets a list of categories that can be used for a key schedule.
      Returns: The IDs of all valid categories.
    static ICollection<ElementId> GetValidCategoriesForMaterialTakeoff()
      Description: Gets a list of categories that can be used for a material takeoff.
      Returns: The IDs of all valid categories.
    static ICollection<ElementId> GetValidCategoriesForSchedule()
      Description: Gets a list of categories that can be used for a regular schedule.
      Returns: The IDs of all valid categories.
    static ICollection<ElementId> GetValidFamiliesForNoteBlock(Document document)
      Description: Gets a list of families that can be used for a note block.
      @document: The document.
      Returns: The IDs of all valid families.
      Throws ArgumentNullException: A non-optional argument was null
    void GroupHeaders(int top, int left, int bottom, int right, string caption)
      Description: Groups schedule header cells.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      @caption: The header caption.
      Throws ArgumentException: Headers could not be grouped.
      Throws ArgumentNullException: A non-optional argument was null
    bool HasImageField()
      Description: Checks whether the schedule definition includes any image-related fields and if any elements in the schedule actually have images in those fields.
      Returns: True if the schedule has at least one image field showing at least one image, false otherwise
    bool IsDataOutOfDate()
      Description: Indicates whether the schedule data is out of date.
      Returns: True if the schedule data is out of date, false otherwise.
    bool IsSplit()
      Description: Checks if the schedule is split.
      Returns: True if the schedule is split. Otherwise false.
    static bool IsValidCategoryForKeySchedule(ElementId categoryId)
      Description: Checks whether a category can be used for a key schedule.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for a key schedule, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidCategoryForMaterialTakeoff(ElementId categoryId)
      Description: Checks whether a category can be used for a material takeoff.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for a material takeoff, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidCategoryForSchedule(ElementId categoryId)
      Description: Checks whether a category can be used for a regular schedule.
      @categoryId: The category ID to check.
      Returns: True if the category can be used for a regular schedule, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static bool IsValidFamilyForNoteBlock(Document document, ElementId familyId)
      Description: Checks whether a family can be used for a note block.
      @document: The document.
      @familyId: The family ID to check.
      Returns: True if the family can be used for a note block, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsValidTextTypeId(ElementId textTypeId)
      Description: Identifies if the input id represents a valid text type id for use in the schedule properties.
      @textTypeId: The element id of the text type.
      Throws ArgumentNullException: A non-optional argument was null
    void MergeSegments(int movedSegmentIndex, int targetSegmentIndex)
      Description: Merges two adjacent segments into one.
      @movedSegmentIndex: The index of the moved segment.
      @targetSegmentIndex: The index of the target segment.
      Throws ArgumentException: Only two adjacent segments can be merged. -or- The segment index should start from 0 and be less than the total segment count.
    bool RefreshData()
      Description: Rebuilds the schedule data if it is out of date.
      Returns: True if the data is up to date after the refresh.
    void RestoreImageSize()
      Description: Restores all images to their original sizes.
    void SetSegmentHeight(int segmentIndex, double height)
      Description: Sets the segment height.
      @segmentIndex: Index of the segment.
      @height: New height for the segment.
      Throws ArgumentException: segmentIndex must be between 0 and the last second of all segments.
      Throws ArgumentOutOfRangeException: The given value for height must be greater than 0 and no more than 30000 feet.
    void SetStripedRowsColor(StripedRowPattern index, Color color)
      Description: Sets the color applied to part of the pattern for a schedule with striped rows.
      @index: The part of the striped row pattern.
      @color: The color which will be used in striped row pattern.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void Split(IList<double> segmentHeights)
      Description: Splits the schedule into several segments by given height of each segment.
      @segmentHeights: An array contains the height limit of each segment except the last segment. The height is the value for segment body. The height is Revit's internal units value.
      Throws ArgumentException: The height of a schedule segment must be greater than 0 and no more than 30000 feet. The total segment count must be greater than 0 and less than 10000.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: Revision schedules cannot be split. -or- A schedule filtered by sheet can't be split. -or- This ViewSchedule is split.
    void Split(int segmentNumber)
      Description: Splits the schedule into several segments by given segment number.
      @segmentNumber: The segment number.
      Throws ArgumentException: The segment number must be greater than 1.
      Throws InvalidOperationException: Revision schedules cannot be split. -or- A schedule filtered by sheet can't be split. -or- This ViewSchedule is split.
    void SplitSegment(int segmentIndex, IList<double> segmentHeights)
      Description: Splits the schedule segment by the given heights of new segments.
      @segmentIndex: The index of segment, starting with 0.
      @segmentHeights: An array contains the height for each new segment except the last segment. The height of the last segment will be determined by the height of previous new segments and the height of the split segment.
      Throws ArgumentException: The height of a schedule segment must be greater than 0. The total height must be less than the split segment height. The total segment count must be greater than 0 and less than 10000. -or- The segment index should start from 0 and be less than the total segment count.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This ViewSchedule is not split yet.
    void UngroupHeaders(int top, int left, int bottom, int right)
      Description: Ungroups selected headers of schedule.
      @top: The index of the top row of the selected headers.
      @left: The index of the left column of the selected headers.
      @bottom: The index of the bottom row of the selected headers.
      @right: The index of the right column of the selected headers.
      Throws ArgumentException: Headers could not be ungrouped.

--------------------------------------------------------------------------------

[CLASS] ViewScheduleExportOptions
Full Name: Autodesk.Revit.DB.ViewScheduleExportOptions
Description: The export options used to export schedule views.
Implements: IDisposable

  CONSTRUCTORS:
    new ViewScheduleExportOptions()
      Description: Constructs a new instance of the ViewScheduleExportOptions class
    new ViewScheduleExportOptions(ViewScheduleExportOptions other)
      Description: Constructs a new copy of the input ViewScheduleExportOptions object.
      Throws ArgumentNullException: A non-optional argument was null

  PROPERTIES:
    ExportColumnHeaders ColumnHeaders { get; set; }
      Description: How to export column headers. Default is MultipleRows.
    string FieldDelimiter { get; set; }
      Description: How to delimit fields. Default is Tab.
    bool HeadersFootersBlanks { get; set; }
      Description: Whether to export group headers, footers, and blank lines. Default is true.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    ExportTextQualifier TextQualifier { get; set; }
      Description: How to qualify text fields. Default is DoubleQuote.
    bool Title { get; set; }
      Description: Whether or not to export the schedule title. Default is true.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] ViewSection
Full Name: Autodesk.Revit.DB.ViewSection
Description: ViewSection covers sections, details, elevations, and callouts, all in their reference and non-reference variations.
Remarks: The creation functions for elevations can be found in the ElevationMarker class.
Inherits: View

  METHODS:
    static View CreateCallout(Document document, ElementId parentViewId, ElementId viewFamilyTypeId, XYZ point1, XYZ point2)
      Description: Creates a new callout view.
      @document: The document to which the new callout will be added.
      @parentViewId: The view in which the callout appears. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail views.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new callout ViewSection. Detail ViewFamilyTypes can be used in all parent views except for CeilingPlan and Drafting views. FloorPlan, CeilingPlan, StructuralPlan, Section, and Elevation ViewFamilyTypes may be be used in parent views that also use a type with the same ViewFamily enum value. For example, in StructuralPlan parent views both StructuralPlan and Detail ViewFamilyTypes are allowed.
      @point1: Determines the extents of the callout symbol in the parent view.
      @point2: Determine the extents of the callout symbol in the parent view.
      Returns: The new callout view. The view will be either a ViewSection, ViewPlan or ViewDetail.
      Throws ArgumentException: Non-reference callouts are not allowed in parent views of this type. -or- Callouts of the supplied ViewFamilyType are not allowed in the parent view. -or- point1 and point2 do not differ when projected onto a plane perpendicular to the view direction. -or- Callout view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSection CreateDetail(Document document, ElementId viewFamilyTypeId, BoundingBoxXYZ sectionBox)
      Description: Returns a new detail ViewSection.
      @document: The document to which the new detail ViewSection will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new detail ViewSection. The type needs to be a Detail ViewFamily.
      @sectionBox: The BoundingBoxXYZ which specifies the new ViewSection's view direction and extents.
      Returns: The new detail ViewSection.
      Throws ArgumentException: The ViewFamilyType must be a Detail ViewFamily. -or- The BoundingBoxXYZ is not appropriate for detail views. The basis vectors of must be unit length and orthonormal. The near and far bound offsets cannot be reversed or too close to each other. MinEnabled and MaxEnabled must be set to true for all three directions. -or- Detail section view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void CreateReferenceCallout(Document document, ElementId parentViewId, ElementId viewIdToReference, XYZ point1, XYZ point2)
      Description: Creates a new reference callout.
      @document: The document to which the new reference callout will be added.
      @parentViewId: The view in which the callout symbol appears. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, Drafting, and Detail views.
      @viewIdToReference: The view which will be referenced. The ViewFamilyType of the referenced view will be used by the new reference callout. Only cropped views can be referenced, unless the referenced view is a Drafting view. Drafting views can always be referenced regardless of the parent view type. Elevation views can be referenced from Elevation and Drafting parent views. Section views can be referenced from Section and Drafting parent views. Detail views can be referenced from all parent views except for in FloorPlan, CeilingPlan and StructuralPlan parent views where only horizontally-oriented Detail views can be referenced. FloorPlan, CeilingPlan and StructuralPlan views can be referenced from FloorPlan, CeilingPlan and StructuralPlan parent views.
      @point1: One corner of the callout symbol in the parent view.
      @point2: The other diagonally opposed corner of the callout symbol in the parent view.
      Throws ArgumentException: The ElementId viewIdToReference does not correspond to a View. -or- The ElementId parentViewId does not correspond to a View. -or- The parent view and the referenced view must be different views. -or- The parent view does not support reference callouts to views of the ViewFamily used by viewIdToReference. -or- point1 and point2 do not differ when projected onto a plane perpendicular to the view direction. -or- Callout view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static void CreateReferenceSection(Document document, ElementId parentViewId, ElementId viewIdToReference, XYZ headPoint, XYZ tailPoint)
      Description: Creates a new reference section.
      @document: The document to which the reference section will be added.
      @parentViewId: The view in which the new reference section marker will appear. Reference sections can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, Drafting, and Detail views.
      @viewIdToReference: Detail, Drafting and Section views can be referenced. The ViewFamilyType of the referenced view will be used by the new reference section.
      @headPoint: Determines the location of the section marker's head in the parent view.
      @tailPoint: Determines the location of the section marker's tail in the parent view.
      Throws ArgumentException: The ElementId viewIdToReference does not correspond to a View. -or- The ElementId parentViewId does not correspond to a View. -or- The parent view and the referenced view must be different views. -or- Can't create a new reference sections in parentViewId. Parent views must be FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, Drafting, or Detail views. -or- The viewIdToReference cannot be referenced by reference sections. Only Detail, Drafting and Section views can be referenced. -or- headPoint and tailPoint do not differ when projected onto a plane perpendicular to the view direction. -or- Reference section view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSection CreateSection(Document document, ElementId viewFamilyTypeId, BoundingBoxXYZ sectionBox)
      Description: Returns a new section ViewSection.
      @document: The document to which the new section ViewSection will be added.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new section ViewSection. The type needs to be a Section ViewFamily.
      @sectionBox: The BoundingBoxXYZ which specifies the new ViewSection's view direction and extents.
      Returns: The new section ViewSection.
      Throws ArgumentException: The ViewFamilyType must be a Section ViewFamily. -or- The BoundingBoxXYZ is not appropriate for detail views. The basis vectors of must be unit length and orthonormal. The near and far bound offsets cannot be reversed or too close to each other. MinEnabled and MaxEnabled must be set to true for all three directions. -or- Section view creation is not allowed in this family.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static bool IsParentViewValidForCallout(Document document, ElementId parentViewId)
      Description: This validator checks that the parent view is appropriate for callout views.
      @document: The document which contains the ViewFamilyType and parent view.
      @parentViewId: The view in which the new callout will appear. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail views.
      Returns: True if the ViewFamilyType can be used for callout views in the parent view, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    bool IsSplitSection()
      Description: Sections can be split (jog) so that they cut at >1 plane.
      Returns: True if the section is split.
    static bool IsViewFamilyTypeValidForCallout(Document document, ElementId viewFamilyTypeId, ElementId parentViewId)
      Description: This validator checks that the ViewFamilyType is appropriate for callout views in the input parent view.
      @document: The document which contains the ViewFamilyType and parent view.
      @viewFamilyTypeId: The id of the ViewFamilyType which will be used by the new callout ViewSection. Detail ViewFamilyTypes can be used in all parent views except for CeilingPlan and Drafting views. FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail ViewFamilyTypes may be be used in parent views that also use a type with the same ViewFamily enum value. For example, in StructuralPlan views both StructuralPlan and Detail ViewFamilyTypes are allowed.
      @parentViewId: The view in which the new callout will appear. Callouts can be created in FloorPlan, CeilingPlan, StructuralPlan, Section, Elevation, and Detail views.
      Returns: True if the ViewFamilyType can be used for callout views in the parent view, false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ViewSet
Full Name: Autodesk.Revit.DB.ViewSet
Description: A set that contains views.
Inherits: APIObject
Implements: IEnumerable

  CONSTRUCTORS:
    new ViewSet()

  PROPERTIES:
    bool IsEmpty { get; }
      Description: Test to see if the set is empty.
    int Size { get; }
      Description: Returns the number of views that are in the set.

  METHODS:
    void Clear()
      Description: Removes every view from the set, rendering it empty.
    bool Contains(View item)
      Description: Tests for the existence of a view within the set.
      @item: The view to be searched for.
      Returns: The Contains method returns True if the view is within the set, otherwise False.
    int Erase(View item)
      Description: Removes a specified view from the set.
      @item: The view to be erased.
      Returns: The number of views that were erased from the set.
    ViewSetIterator ForwardIterator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    IEnumerator GetEnumerator()
      Description: Retrieve a forward moving iterator to the set.
      Returns: Returns a forward moving iterator to the set.
    bool Insert(View item)
      Description: Insert the specified view into the set.
      @item: The view to be inserted into the set.
      Returns: Returns whether the view was inserted into the set.
    ViewSetIterator ReverseIterator()
      Description: Retrieve a backward moving iterator to the set.
      Returns: Returns a backward moving iterator to the set.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ViewSetIterator
Full Name: Autodesk.Revit.DB.ViewSetIterator
Description: An iterator to a view set.
Inherits: APIObject
Implements: IEnumerator

  CONSTRUCTORS:
    new ViewSetIterator()
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

[CLASS] ViewShapeBuilder
Full Name: Autodesk.Revit.DB.ViewShapeBuilder
Description: Builds and verifies a view-specific shape representation that would typically be stored in a DirectShape object. Currently limited to curve-based representations for plan and elevation views.
Remarks: The validation functionality is used by DirectShape to validate the incoming shape.
Inherits: ShapeBuilder

  CONSTRUCTORS:
    new ViewShapeBuilder(DirectShapeTargetViewType targetViewType)
      Description: A constructor for an ViewShapeBuilder object that takes a view type. It will infer the view normal from view type. View normal and view type are used to validate the geometry to be stored as a view-specific shape representation of a DirectShape object.
      @targetViewType: View type for which this shape representation is intended. Currently limited to Plan Views.
      Throws ArgumentException: targetViewType is not DirectShapeTargetViewType::Plan
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    new ViewShapeBuilder()
      Description: Default constructor for an ViewShapeBuilder object.

  PROPERTIES:
    XYZ ViewNormal { get; set; }
      Description: Normal of the view that will display the shape being built. Must be set explicitly before adding any geometry. Must be a unit vector. This is used to validate incoming geometry - it must be orthogonal to the viewNormal.
    DirectShapeTargetViewType ViewType { get; set; }
      Description: View type where the view-specific shape currently being built will be used

  METHODS:
    void AddCurve(Curve GCurve)
      Description: Add a curve to the GRep associated to this ViewShapeBuilder.
      @GCurve: The curve to be added.
      Throws ArgumentException: GCurve is not acceptable for view-specific shape representation that is currently being built.
      Throws ArgumentNullException: A non-optional argument was null
    void Reset()
      Description: Clears the accumulated geometry and resets other ViewShapeBuilder parameters to invalid values.
    static bool ValidateCurve(Curve GCurve, DirectShapeTargetViewType targetViewType)
      Description: Validates curve to be added to the view-specific shape being constructed. Called by AddCurve() to validate input. This function may be used to pre-validate the geometry being added to avoid AddCurve() throwing an InvalidArgumentException
      @GCurve: Curve object to be validated.
      @targetViewType: View type for which this curve is intended.
      Returns: True is %GCurve% is acceptable as a part of view-specific shape representation.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    bool ValidateCurve(Curve GCurve)
      Description: Validates curve to be added to the view-specific shape being constructed. Called by AddCurve() to validate input. Expects a valid view normal to be set prior to the call.
      @GCurve: Curve object to be validated.
      Returns: True is %GCurve% is acceptable as a part of view-specific shape representation being built.
      Throws ArgumentNullException: A non-optional argument was null
    static bool ValidateShape(IList<GeometryObject> shape, DirectShapeTargetViewType targetViewType)
      Description: Validates a shape represented as a collection of geometry objects for use as a view-specific shape. The objects are expected to be either points, curves or polylines. Curves are expected to be flat and lie in a plane perpendicular to view normal as defined by view type.
      Returns: Returns true if %shape% may be used as a view-specific shape representation, false otherwise.
      Throws ArgumentException: targetViewType is not DirectShapeTargetViewType::Plan
      Throws ArgumentNullException: A non-optional argument was null
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    static bool ValidateViewType(DirectShapeTargetViewType targetViewType)
      Description: Validates the incoming view type. As of today, the only allowed view type is Plan.
      Returns: True if %targetViewType% is DirectShapeTargetViewType::Plan
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration

--------------------------------------------------------------------------------

[CLASS] ViewSheet
Full Name: Autodesk.Revit.DB.ViewSheet
Description: Class for ViewSheet
Inherits: View

  PROPERTIES:
    bool IsPlaceholder { get; }
      Description: Identifies whether or not the view sheet represents a placeholder sheet.
    ElementId SheetCollectionId { get; set; }
      Description: The ID of the sheet collection this sheet is associated with.
    string SheetNumber { get; set; }
      Description: The sheet number of the document.
    ElementId SheetTitleBlockId { get; set; }
      Description: The Id of the title block this sheet is associated with.

  METHODS:
    bool CanBeDuplicated(SheetDuplicateOption duplicateOption)
      Description: Identifies if this sheet can be duplicated.
      @duplicateOption: The option to use when duplicating the sheet.
      Returns: True if the sheet can be duplicated, false otherwise.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
    void ConvertToRealSheet(ElementId titleBlockTypeId)
      Description: Converts a placeholder sheet to a real one with an optional titleblock.
      @titleBlockTypeId: The id of the placeholder sheet, or invalidElementId if no titleblock should be added.
      Throws ArgumentException: titleBlockTypeId does not correspond to a TitleBlock type.
      Throws ArgumentNullException: A non-optional argument was null
      Throws InvalidOperationException: This method may only be called on a placeholder sheet. -or- Failed to convert the sheet because the input titleblock could not be applied.
    static ViewSheet Create(Document document, ElementId titleBlockTypeId)
      Description: Creates a new ViewSheet.
      @document: The document to which the ViewSheet will be added.
      @titleBlockTypeId: The type id of the TitleBlock type which will be used by the new ViewSheet. For no TitleBlock, pass invalid element ID.
      Returns: The new ViewSheet.
      Throws ArgumentException: The ElementId titleBlockTypeId does not correspond to a TitleBlock type. -or- document is not a project document.
      Throws ArgumentNullException: A non-optional argument was null
      Throws ModificationForbiddenException: The document is in failure mode: an operation has failed, and Revit requires the user to either cancel the operation or fix the problem (usually by deleting certain elements). -or- The document is being loaded, or is in the midst of another sensitive process.
      Throws ModificationOutsideTransactionException: The document has no open transaction.
    static ViewSheet CreatePlaceholder(Document aDoc)
      Description: Creates a placeholder sheet in a document.
      @aDoc: The document.
      Returns: The placeholder sheet.
      Throws ArgumentNullException: A non-optional argument was null
    void DeleteViewport(Viewport viewport)
      Description: Removes a viewport from the sheet by deleting it from the document.
      @viewport: The viewport that will be deleted and removed from the sheet.
      Throws ArgumentNullException: A non-optional argument was null
    ElementId Duplicate(SheetDuplicateOption duplicateOption)
      Description: Duplicates this sheet to generate a new one.
      @duplicateOption: The option to use when duplicating the sheet.
      Returns: The id of the newly created sheet.
      Throws ArgumentOutOfRangeException: A value passed for an enumeration argument is not a member of that enumeration
      Throws InvalidOperationException: Sheet cannot be duplicated
    ICollection<ElementId> GetAdditionalRevisionIds()
      Description: Gets the Revisions that are additionally included in the sheet's revision schedules.
      Returns: The additionally included Revisions for the sheet's revision schedules.
    ISet<ElementId> GetAllPlacedViews()
      Description: Returns the ElementIds of Views placed on this sheet.
      Returns: The ids of the views on this sheet.
    ISet<ElementId> GetAllRevisionCloudIds()
      Description: Gets the ids of the revision clouds which appear on the sheet's revision schedules.
      Returns: The ids of the revisions clouds which appear on the sheet's revision schedules.
    IList<ElementId> GetAllRevisionIds()
      Description: Gets the ordered array of Revisions which participate in the sheet's revision schedules.
      Returns: The ordered array of ids of Revisions participating in the sheet's revision schedules.
    ICollection<ElementId> GetAllViewports()
      Description: Returns the ElementIds of Viewports on this sheet.
      Returns: The Viewports on this sheet.
    ElementId GetCurrentRevision()
      Description: Returns the most recent numbered Revision shown on this ViewSheet.
      Returns: The Id of the most recent numbered Revision shown on this ViewSheet or InvalidElementId if none are shown.
    string GetRevisionCloudNumberOnSheet(ElementId revisionCloudId)
      Description: Gets the Revision Number for a RevisionCloud on this sheet.
      @revisionCloudId: The id of the RevisionCLoud.
      Returns: Returns the Revision Number as it will appear on this sheet or if there is no Revision Number assigned on this sheet.
      Throws ArgumentException: revisionCloudId is not the Id of a RevisionCloud.
      Throws ArgumentNullException: A non-optional argument was null
    string GetRevisionNumberOnSheet(ElementId revisionId)
      Description: Gets the Revision Number for a particular Revision as it will appear on this sheet.
      @revisionId: The id of the Revision.
      Returns: Returns the Revision Number as it will appear on this sheet or if the Revision does not appear on this sheet.
      Throws ArgumentException: revisionId is not a valid Revision.
      Throws ArgumentNullException: A non-optional argument was null
    void SetAdditionalRevisionIds(ICollection<ElementId> projectRevisionIds)
      Description: Sets the Revisions to additionally include in the sheet's revision schedules.
      @projectRevisionIds: The ids of Revisions to explicitly include in the sheet's revision schedules.
      Throws ArgumentException: One or more ElementIds in projectRevisionIds do not correspond to a Revision element.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] ViewSheetSet
Full Name: Autodesk.Revit.DB.ViewSheetSet
Description: Represents ViewSheetSets stored in a document. ViewSheetSets can be stored so that the same printing task can be executed multiple times.
Remarks: For the in-session ViewSheetSet, see the class InSessionViewSheetSet. Changes of ViewSheetSet would be effiective after Autodesk::Revit::DB::ViewSheetSetting::Save
Inherits: Element
Implements: IViewSheetSet

  PROPERTIES:
    bool IsAutomatic { get; set; }
      Description: Automatic order or manual order.
    string Name { get; set; }
      Description: The view sheet set name.
    IReadOnlyList<View> OrderedViewList { get; set; }
      Description: Ordered views.
    ElementId SheetOrganizationId { get; set; }
      Description: ElementId to the BrowserOrganization for sheets.
    ElementId ViewOrganizationId { get; set; }
      Description: ElementId to the BrowserOrganization for non-sheet views.
    ViewSet Views { get; set; }
      Description: The views.

--------------------------------------------------------------------------------

[CLASS] ViewSheetSetting
Full Name: Autodesk.Revit.DB.ViewSheetSetting
Description: Represents the View/Sheet Set (Application Menu->Print) within Autodesk Revit.
Inherits: APIObject

  PROPERTIES:
    ViewSet AvailableViews { get; }
      Description: All views that can be printed.
    IViewSheetSet CurrentViewSheetSet { get; set; }
      Description: The current view sheet set of PrintSetup.
    InSessionViewSheetSet InSession { get; }
      Description: The in-session view sheet set of Print Setup.

  METHODS:
    bool Delete()
      Description: Delete the current view sheet set, and make the In-Session set as the current one.
      Returns: False if Delete operation fails, otherwise True.
      Throws InvalidOperationException: Thrown when the current view sheet set is In-Session.
    bool Rename(string newName)
      Description: Rename the current view sheet set.
      @newName: View sheet set name to be renamed as.
      Returns: False if Rename operation fails, otherwise True.
      Throws InvalidOperationException: Thrown when the input name is already existed in current view sheet set list.
    void Revert()
      Description: Revert the current view sheet set.
      Throws InvalidOperationException: Thrown when the current view sheet set is In-Session.
    bool Save()
      Description: Save the changes for the current view sheet set.
      Returns: False if save operation fails, otherwise True.
      Throws InvalidOperationException: Thrown when the current view sheet set is In-Session or the current view sheet set is unchanged.
    bool SaveAs(string newName)
      Description: Save the current view sheet set to another view sheet set with the specified name.
      @newName: View sheet set name to be saved as.
      Returns: False if Save As operation fails, otherwise True.
      Throws InvalidOperationException: Thrown when the input name is already existed in current view sheet set list.

--------------------------------------------------------------------------------

[ENUM] ViewTemplateApplicationOption
Full Name: Autodesk.Revit.DB.ViewTemplateApplicationOption
Description: Options for applying view templates
Inherits: Enum

  Values:
    - AllParameters = 0
    - UncontrolledParameters = 1
    - AllParametersAndStickIfNone = 2

--------------------------------------------------------------------------------

[ENUM] ViewType
Full Name: Autodesk.Revit.DB.ViewType
Description: An enumerated type listing available view types.
Inherits: Enum

  Values:
    - Undefined = 0
    - FloorPlan = 1
    - CeilingPlan = 2
    - Elevation = 3
    - ThreeD = 4
    - Schedule = 5
    - DrawingSheet = 6
    - ProjectBrowser = 7
    - Report = 8
    - DraftingView = 10
    - Legend = 11
    - SystemBrowser = 12
    - EngineeringPlan = 115
    - AreaPlan = 116
    - Section = 117
    - Detail = 118
    - CostReport = 119
    - LoadsReport = 120
    - PressureLossReport = 121
    - ColumnSchedule = 122
    - PanelSchedule = 123
    - Walkthrough = 124
    - Rendering = 125
    - SystemsAnalysisReport = 126
    - Internal = 214

--------------------------------------------------------------------------------

[ENUM] VirtualPrinterType
Full Name: Autodesk.Revit.DB.VirtualPrinterType
Description: An enumerated to list Virtual Printer Types in Revit.
Inherits: Enum

  Values:
    - None = 0
    - AdobePDF = 1
    - DWFWriter = 2
    - XPSWriter = 3

--------------------------------------------------------------------------------

[ENUM] Visibility
Full Name: Autodesk.Revit.DB.Visibility
Description: Describes the visibility of a particular geometry object.
Inherits: Enum

  Values:
    - Visible = 0
    - Highlight = 1
    - Contextual = 2
    - Invisible = 3

--------------------------------------------------------------------------------

[CLASS] VisibleInViewFilter
Full Name: Autodesk.Revit.DB.VisibleInViewFilter
Description: A quick filter that passes elements that are most likely visible in the given view.
Remarks: This filter is a quick filter. Quick filters operate only on the ElementRecord, a low-memory class which has a limited interface to read element properties. Elements which are rejected by a quick filter will not be expanded in memory. In some situations (for example, when the element geometry is not yet calculated for the input view) this filter may return true even though the element may not actually be visible when geometry is calculated.
Inherits: ElementQuickFilter

  CONSTRUCTORS:
    new VisibleInViewFilter(Document document, ElementId viewId, bool inverted)
      Description: Constructs a new instance of a VisibleInViewFilter, with the option to pass all non-visible elements.
      @document: The document that owns the view.
      @viewId: The view id.
      @inverted: True if the filter should match all elements not visible in the given view.
      Throws ArgumentException: viewId is not a view. -or- viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates will fail this check.
      Throws ArgumentNullException: A non-optional argument was null
    new VisibleInViewFilter(Document document, ElementId viewId)
      Description: Constructs a new instance of a VisibleInViewFilter.
      @document: The document that owns the view.
      @viewId: The view id.
      Throws ArgumentException: viewId is not a view. -or- viewId is not valid for element iteration, because it has no way of representing drawn elements. Many view templates will fail this check.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

