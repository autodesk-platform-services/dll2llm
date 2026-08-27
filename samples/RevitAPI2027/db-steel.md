# Autodesk.Revit.DB.Steel

NAMESPACE: Autodesk.Revit.DB.Steel
--------------------------------------------------------------------------------

[CLASS] SteelElementProperties
Full Name: Autodesk.Revit.DB.Steel.SteelElementProperties
Description: This class is used to attach steel fabrication information to various Revit elements. extensions at both element ends
Remarks: Revit elements which can have fabrication information are: FamilyInstance (structural beams and columns).StructuralConnectionHandler elements associated to the connection.Specific steel connection elements (bolts, anchors, plates, etc). These connection elements will be of type element but with categories related to structural connections, for example: OST_StructConnectionWeldsOST_StructConnectionHolesOST_StructConnectionModifiersOST_StructConnectionShearStudsOST_StructConnectionBoltsOST_StructConnectionAnchorsOST_StructConnectionPlatesSome concrete elements (walls, floors, concrete beams, ...) when they are input elements to detailed steel connections. The class also holds the link to the Steel Core elements.
Inherits: APIObject

  PROPERTIES:
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    Guid UniqueID { get; set; }
      Description: This method will return the fabrication id. This represents the link between the Revit and the Steel Core element.

  METHODS:
    static IList<ElementId> AddFabricationInformationForRevitElements(Document aDoc, IList<ElementId> elementIds)
      Description: This method adds fabrication information to the given elements.
      @aDoc: Document containing the given elements ids.
      @elementIds: Ids of the elements to which we want to add fabrication information.
      Returns: Ids of the elements for which we couldn't add fabrication information.
      Throws ArgumentNullException: A non-optional argument was null
    static Guid GetFabricationUniqueID(Document aDoc, Reference reference)
      Description: This method will return the fabrication id for the given reference.
      @aDoc: Document to which the reference belongs.
      @reference: The reference to the element or subelement for which fabrication id is required.
      Returns: The fabrication id of the element or subelement for this reference, if it has fabrication information attached, or an Guid.Empty otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static Reference GetReference(Document aDoc, Guid guid)
      Description: This method will return the reference for the given fabrication id.
      @aDoc: Document in which to search for the reference.
      @guid: The fabrication id for which a reference is required.
      Returns: The reference to the element or subelement corresponding to the given id.
      Throws ArgumentNullException: A non-optional argument was null
    static SteelElementProperties GetSteelElementProperties(Element pElement)
      Description: Get SteelElementProperties for the input element if they exist.
      @pElement: The element from which we try to obtain SteelElementProperties.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

