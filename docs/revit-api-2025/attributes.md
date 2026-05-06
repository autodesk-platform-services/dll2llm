# Autodesk.Revit.Attributes


NAMESPACE: Autodesk.Revit.Attributes
--------------------------------------------------------------------------------

[CLASS] JournalingAttribute
Full Name: Autodesk.Revit.Attributes.JournalingAttribute

Description: The custom journaling attribute to control the journaling behavior of the external command.
Inherits: Attribute

  CONSTRUCTORS:
    new JournalingAttribute(JournalingMode mode)

  PROPERTIES:
    JournalingMode Mode { get; }
      Description: Journaling mode.

--------------------------------------------------------------------------------

[ENUM] JournalingMode
Full Name: Autodesk.Revit.Attributes.JournalingMode

Description: All journaling modes supported by Revit external commands.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - UsingCommandData = 0
    - NoCommandData = 1

[CLASS] RegenerationAttribute
Full Name: Autodesk.Revit.Attributes.RegenerationAttribute

Description: The custom regeneration attribute to control the regeneration behavior of the external command or external application.
Inherits: Attribute

  CONSTRUCTORS:
    new RegenerationAttribute(RegenerationOption option)

  PROPERTIES:
    RegenerationOption Option { get; }
      Description: Regeneration option.

--------------------------------------------------------------------------------

[ENUM] RegenerationOption
Full Name: Autodesk.Revit.Attributes.RegenerationOption

Description: All regeneration options supported by Revit external commands and external applications.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Manual = 0

[CLASS] TransactionAttribute
Full Name: Autodesk.Revit.Attributes.TransactionAttribute

Description: The custom transaction attribute to control the transaction behavior of the external command.
Inherits: Attribute

  CONSTRUCTORS:
    new TransactionAttribute(TransactionMode mode)

  PROPERTIES:
    TransactionMode Mode { get; }
      Description: Transaction mode.

--------------------------------------------------------------------------------

[ENUM] TransactionMode
Full Name: Autodesk.Revit.Attributes.TransactionMode

Description: All transaction modes supported by Revit external commands.
Inherits: Enum
Implements: IComparable, ISpanFormattable, IFormattable, IConvertible

  Values:
    - Manual = 1
    - ReadOnly = 2


