# Autodesk.Revit.DB.Macros


NAMESPACE: Autodesk.Revit.DB.Macros
--------------------------------------------------------------------------------

[CLASS] AddInIdAttribute
Full Name: Autodesk.Revit.DB.Macros.AddInIdAttribute

Description: The custom AddInId attribute for Macros macros use only.
Inherits: Attribute

  CONSTRUCTORS:
    new AddInIdAttribute(string addInIdStr)

  PROPERTIES:
    ValueType Value { get; }
      Description: AddInId guid value.

--------------------------------------------------------------------------------

[ABSTRACT CLASS] ApplicationEntryPoint
Full Name: Autodesk.Revit.DB.Macros.ApplicationEntryPoint

Description: For Revit Macros use only.
Inherits: Application
Implements: IDisposable, IEntryPoint

  CONSTRUCTORS:
    new ApplicationEntryPoint()

  PROPERTIES:
    string AddinFolder { get; }
      Description: The full path to the Revit Macros module.

  METHODS:
    void FinishInitializationEO()
      Description: For Revit Macros internal use only.
    void Initialize(object obj, string addinFolder)
      Description: For Revit Macros internal use only.
    void OnShutdownEO()
      Description: For Revit Macros internal use only.

--------------------------------------------------------------------------------

[INTERFACE] IEntryPoint
Full Name: Autodesk.Revit.DB.Macros.IEntryPoint

Description: The interface supporting Document and Application level entry point classes for macros.

  PROPERTIES:
    string AddinFolder { get; }

  METHODS:
    void FinishInitialization()
    void Initialize(object obj, string addinFolder)
    void OnShutdown()

--------------------------------------------------------------------------------

[CLASS] VendorIdAttribute
Full Name: Autodesk.Revit.DB.Macros.VendorIdAttribute

Description: The custom VendorId attribute for Macros macros use only.
Inherits: Attribute

  CONSTRUCTORS:
    new VendorIdAttribute(string vendorIdStr)

  PROPERTIES:
    string Value { get; }
      Description: AddInId VendorId value.

--------------------------------------------------------------------------------


