# Autodesk.Revit.DB.Structure.StructuralSections

NAMESPACE: Autodesk.Revit.DB.Structure.StructuralSections
--------------------------------------------------------------------------------

[CLASS] StructuralElementDefinitionData
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData
Description: Class containing information about section and position of the structural element.
Implements: IDisposable

  CONSTRUCTORS:
    new StructuralElementDefinitionData()
      Description: Creates empty StructuralElementDefinitionData object.

  PROPERTIES:
    Curve CenterCurve { get; }
      Description: The curve lying in the geometrical center of the element.
    Curve Curve { get; }
      Description: The definition curve of the element.
    double EndShortening { get; }
      Description: Cutback or extension at element curve end.
    bool IsMirrored { get; }
      Description: States if the structural section of the element is mirrored.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    XYZ Normal { get; }
      Description: The local Z direction of the element section in the start point of the curve.
    StructuralSection Section { get; }
      Description: Structural section of the element.
    double StartShortening { get; }
      Description: Cutback or extension at element curve start.
    YJustification YJust { get; }
      Description: Y justification (ref axis).
    double YOffset { get; }
      Description: Y offset.
    ZJustification ZJust { get; }
      Description: Z justification (ref axis).
    double ZOffset { get; }
      Description: Z offset.

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] StructuralSection
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection
Description: The base class for StructuralSection specific classes, designed to provide common parameters and ability to differentiate between different structural section shapes.
Implements: IEnumerable, IDisposable

  PROPERTIES:
    StructuralSectionAnalysisParams AnalysisParams { get; }
      Description: Common set of parameters for structural analysis.
    double ElasticModulusStrongAxis { get; set; }
      Description: Elastic section modulus about main strong axis for calculation of bending stresses.
    double ElasticModulusWeakAxis { get; set; }
      Description: Elastic section modulus about main weak axis for calculation of bending stresses.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MomentOfInertiaStrongAxis { get; set; }
      Description: Moment of Inertia about main strong axis (I).
    double MomentOfInertiaWeakAxis { get; set; }
      Description: Moment of Inertia about main weak axis (I).
    double NominalWeight { get; set; }
      Description: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
    double Perimeter { get; set; }
      Description: Painting surface of the unit length.
    double PlasticModulusStrongAxis { get; set; }
      Description: Plastic section modulus in bending about main strong axis (Z, Wpl).
    double PlasticModulusWeakAxis { get; set; }
      Description: Plastic section modulus in bending about main weak axis.
    double PrincipalAxesAngle { get; set; }
      Description: Rotation angle between the principal axes and cross section reference planes.
    double SectionArea { get; set; }
      Description: Cross section area.
    string SectionNameKey { get; set; }
      Description: A parameter in structural families which allows for family type identification. This will be used for data mapping during model exchange with another program, namely Advance Steel.
    double ShearAreaStrongAxis { get; set; }
      Description: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
    double ShearAreaWeakAxis { get; set; }
      Description: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
    StructuralSectionGeneralShape StructuralSectionGeneralShape { get; }
      Description: The general type of structural section shape.
    StructuralSectionShape StructuralSectionShape { get; }
      Description: The type of structural section shape.
    string StructuralSectionShapeName { get; }
      Description: A human readable string representing the structural section shape.
    double TorsionalModulus { get; set; }
      Description: Section modulus for calculations of torsion stresses (Ct).
    double TorsionalMomentOfInertia { get; set; }
      Description: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
    double WarpingConstant { get; set; }
      Description: Warping constant (Cw, Iomega, H).

  METHODS:
    void Dispose()
    UV GetBoundarySize()
      Description: Returns size of the section boundary.
      Returns: Size of the section boundary.
    IEnumerator GetEnumerator()

--------------------------------------------------------------------------------

[CLASS] StructuralSectionAnalysisParams
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams
Description: Defines common set of parameters for structural analysis.
Implements: IDisposable

  CONSTRUCTORS:
    new StructuralSectionAnalysisParams(double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of StructuralSectionAnalysisParams.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of
    new StructuralSectionAnalysisParams()
      Description: Creates a new instance of StructuralSectionAnalysisParams.

  PROPERTIES:
    double ElasticModulusStrongAxis { get; set; }
      Description: Elastic section modulus about main strong axis for calculation of bending stresses.
    double ElasticModulusWeakAxis { get; set; }
      Description: Elastic section modulus about main weak axis for calculation of bending stresses.
    bool IsValidObject { get; }
      Description: Specifies whether the .NET object represents a valid Revit entity.
    double MomentOfInertiaStrongAxis { get; set; }
      Description: Moment of Inertia about main strong axis (I).
    double MomentOfInertiaWeakAxis { get; set; }
      Description: Moment of Inertia about main weak axis (I).
    double NominalWeight { get; set; }
      Description: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
    double Perimeter { get; set; }
      Description: Painting surface of the unit length.
    double PlasticModulusStrongAxis { get; set; }
      Description: Plastic section modulus in bending about main strong axis (Z, Wpl)
    double PlasticModulusWeakAxis { get; set; }
      Description: Plastic section modulus in bending about main weak axis.
    double PrincipalAxesAngle { get; set; }
      Description: Rotation angle between the principal axes and cross section reference planes.
    double SectionArea { get; set; }
      Description: Cross section area.
    double ShearAreaStrongAxis { get; set; }
      Description: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
    double ShearAreaWeakAxis { get; set; }
      Description: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
    double TorsionalModulus { get; set; }
      Description: Section modulus for calculations of torsion stresses (Ct)
    double TorsionalMomentOfInertia { get; set; }
      Description: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
    double WarpingConstant { get; set; }
      Description: Warping constant (Cw, Iomega, H)

  METHODS:
    void Dispose()

--------------------------------------------------------------------------------

[CLASS] StructuralSectionColdFormed
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed
Description: Defines parameters for Hot Formed structural section.
Inherits: StructuralSectionRectangular

  PROPERTIES:
    double InnerFillet { get; set; }
      Description: Inner Fillet - Corner fillet inner radius.
    double WallDesignThickness { get; set; }
      Description: Represents wall design thickness of rectangle.
    double WallNominalThickness { get; set; }
      Description: Represents wall nominal thickness of rectangle.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionConcreteCross
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteCross
Description: Defines parameters for parameterized concrete cross structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionConcreteCross(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double cantileverLength, double cantileverHeight)
      Description: Creates a new instance of Structural Section Concrete Cross shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @cantileverLength: Flange cantilever length.
      @cantileverHeight: Flange cantilever thickness.

  PROPERTIES:
    double CantileverHeight { get; set; }
      Description: Flange cantilever thickness.
    double CantileverLength { get; set; }
      Description: Flange cantilever length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionConcreteRectangle
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangle
Description: Defines parameters for parameterized concrete rectangle structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionConcreteRectangle(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Concrete Rectangle shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionConcreteRectangleCut
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRectangleCut
Description: Defines parameters for parameterized concrete rectangle cut structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionConcreteRectangleCut(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double topCutWidth, double topCutHeight, double bottomCutWidth, double bottomCutHeight)
      Description: Creates a new instance of Structural Section Concrete Rectangle Cut shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @topCutWidth: Section width right Cut.
      @topCutHeight: Section height right Cut.
      @bottomCutWidth: Section width left Cut.
      @bottomCutHeight: Section height left Cut.

  PROPERTIES:
    double BottomCutHeight { get; set; }
      Description: Section height left Cut.
    double BottomCutWidth { get; set; }
      Description: Section width left Cut.
    double TopCutHeight { get; set; }
      Description: Section height right Cut.
    double TopCutWidth { get; set; }
      Description: Section width right Cut.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionConcreteRound
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteRound
Description: Creates a new instance of Structural Section Concrete Round shape with the associated set of parameters, used to attach to structural element.
Inherits: StructuralSectionRound

  CONSTRUCTORS:
    new StructuralSectionConcreteRound(double diameter, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Concrete Round shape with the associated set of parameters, used to attach to structural element.
      @diameter: Pipe Diameter.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl).
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation.
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct).
      @warpingConstant: Warping constant (Cw, Iomega, H).
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionConcreteT
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionConcreteT
Description: Defines parameters for parameterized concrete T structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionConcreteT(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double cantileverLength, double cantileverHeight)
      Description: Creates a new instance of Structural Section Concrete T shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @cantileverLength: Flange cantilever length.
      @cantileverHeight: Flange cantilever thickness.

  PROPERTIES:
    double CantileverHeight { get; set; }
      Description: Flange cantilever thickness.
    double CantileverLength { get; set; }
      Description: Flange cantilever length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionCParallelFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCParallelFlange
Description: Defines parameters for C-channel Parallel Flange structural section.
Inherits: StructuralSectionGeneralU

  CONSTRUCTORS:
    new StructuralSectionCParallelFlange(double width, double height, double flangeThickness, double webThickness, double webFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double flangeToeOfFillet, double webToeOfFillet, double boltSpacing, double boltDiameter)
      Description: Creates a new instance of Structural Section C Parallel Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes of the fillets, in.(mm)
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionCProfile
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfile
Description: Defines parameters for C Profile structural section.
Inherits: StructuralSectionGeneralC

  CONSTRUCTORS:
    new StructuralSectionCProfile(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section C Profile shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionCProfileWithFold
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithFold
Description: Defines parameters for C Profile with fold structural section.
Inherits: StructuralSectionGeneralCEx

  CONSTRUCTORS:
    new StructuralSectionCProfileWithFold(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double lipLength, double foldLength)
      Description: Creates a new instance of Structural Section C Profile With Fold shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @lipLength: Lip segment length.
      @foldLength: Fold segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionCProfileWithLips
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCProfileWithLips
Description: Defines parameters for C Profile with lips structural section.
Inherits: StructuralSectionGeneralC

  CONSTRUCTORS:
    new StructuralSectionCProfileWithLips(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double lipLength)
      Description: Creates a new instance of Structural Section C Profile With Lips shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @lipLength: Lip segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionCSlopedFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionCSlopedFlange
Description: Defines parameters for C-channel Sloped Flange structural section.
Inherits: StructuralSectionGeneralU

  CONSTRUCTORS:
    new StructuralSectionCSlopedFlange(double width, double height, double flangeThickness, double flangeThicknessLocation, double webThickness, double webFillet, double flangeFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double webToeOfFillet, double boltSpacing, double boltDiameter, double slopedFlangeAngle)
      Description: Creates a new instance of Structural Section C Sloped Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes of the fillets, in.(mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)
      @slopedFlangeAngle: Sloped flange angle. (rad)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)

--------------------------------------------------------------------------------

[ENUM] StructuralSectionErrorCode
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionErrorCode
Description: Error codes for StructuralSection related operations.
Inherits: Enum

  Values:
    - Success = 0
    - Failure = 1
    - ShapeNotRecognized = 2
    - IncompleteDefinition = 3
    - ElementNotSupported = 4
    - MediumDetailShapeHasRounding = 5
    - MediumAndFineDetailShapesAreInconsistent = 6
    - ElementHasIndependentJustification = 7

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralC
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC
Description: Defines parameters for Channel Cold Formed shape.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionGeneralC(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double lipLength, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of general Channel Cold Formed shape.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @lipLength: Lip segment length.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double LipLength { get; set; }
      Description: Lip segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralCEx
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx
Description: Defines parameters for Channel With Fold Cold Formed shape.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionGeneralCEx(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double lipLength, double foldLength, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of general Channel Cold Formed shape.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @lipLength: Lip segment length.
      @foldLength: Fold segment length.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double FoldLength { get; set; }
      Description: Fold segment length.
    double LipLength { get; set; }
      Description: Lip segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralF
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralF
Description: Defines parameters for Flat Bar.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionGeneralF(double width, double height, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Structural Section Flat Bar.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralH
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH
Description: Defines parameters for Rectangular Pipe structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionGeneralH(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double outerFillet, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Rectangular Pipe shape.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @outerFillet: Outer Fillet - Corner fillet outer radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double InnerFillet { get; set; }
      Description: Inner Fillet - Corner fillet inner radius.
    double OuterFillet { get; set; }
      Description: Outer Fillet - Corner fillet outer radius.
    double WallDesignThickness { get; set; }
      Description: Represents wall design thickness of rectangle.
    double WallNominalThickness { get; set; }
      Description: Represents wall nominal thickness of rectangle.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralI
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI
Description: Defines parameters for general Double T shape.
Inherits: StructuralSectionHotRolled

  CONSTRUCTORS:
    new StructuralSectionGeneralI(double width, double height, double flangeThickness, double flangeThicknessLocation, double flangeFillet, double flangeToeOfFillet, double slopedFlangeAngle, double webThickness, double webFillet, double webToeOfFillet, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Structural Section I Sloped Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm).
      @slopedFlangeAngle: Sloped flange angle. (rad)
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double FlangeFillet { get; set; }
      Description: Flange Fillet - fillet radius at the flange end.
    double FlangeToeOfFillet { get; set; }
      Description: Detailing distance from center of web to flange toe of fillet, in. (mm)
    double SlopedFlangeAngle { get; set; }
      Description: Sloped flange angle. (rad)
    double WebToeOfFillet { get; set; }
      Description: Detailing distance from outer face of flange to web toe of fillet, in. (mm)

  METHODS:
    double GetFlangeThicknessInFlangeCenter()
      Description: Returns thickness of flange measured in the 0.25 * (width - webThickess), sometimes used for sections with width > 300 mm.
    double GetFlangeThicknessInQuarterWidth()
      Description: Returns thickness of flange measured in the 0.25 * width, sometimes used for sections with width <= 300 mm.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralLA
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA
Description: Defines parameters for Angle Cold Formed structural section.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionGeneralLA(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double lipLength, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Angle Cold Formed shape.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @lipLength: Lip segment length.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double LipLength { get; set; }
      Description: Lip segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralLZ
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ
Description: Defines parameters for Z Cold Formed shape.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionGeneralLZ(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double bottomFlangeLength, double lipLength, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Z Cold Formed shape.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @bottomFlangeLength: Bottom Flange segment length.
      @lipLength: Lip segment length.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double BottomFlangeLength { get; set; }
      Description: Bottom Flange segment length.
    double LipLength { get; set; }
      Description: Lip segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralR
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralR
Description: Defines parameters for pipes.
Inherits: StructuralSectionRound

  CONSTRUCTORS:
    new StructuralSectionGeneralR(double diameter, double wallNominalThickness, double wallDesignThickness, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Structural Section Pipe.
      @diameter: Pipe Diameter.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double WallDesignThickness { get; set; }
      Description: Represents wall design thickness of rectangle.
    double WallNominalThickness { get; set; }
      Description: Represents wall nominal thickness of rectangle.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralS
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralS
Description: Defines parameters for Round Bar structural section.
Inherits: StructuralSectionRound

  CONSTRUCTORS:
    new StructuralSectionGeneralS(double diameter, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Round Bar shape.
      @diameter: Pipe Diameter.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

--------------------------------------------------------------------------------

[ENUM] StructuralSectionGeneralShape
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralShape
Description: General shapes for structural sections.
Inherits: Enum

  Values:
    - NotDefined = 0
    - GeneralI = 1
    - GeneralC = 2
    - GeneralU = 3
    - GeneralLA = 4
    - GeneralW = 5
    - GeneralT = 6
    - GeneralH = 7
    - GeneralS = 8
    - GeneralR = 9
    - GeneralF = 10
    - GeneralCEx = 11
    - GeneralLZ = 12

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralT
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT
Description: Defines parameters for Tees shape.
Inherits: StructuralSectionHotRolled

  CONSTRUCTORS:
    new StructuralSectionGeneralT(double width, double height, double flangeThickness, double flangeThicknessLocation, double flangeFillet, double flangeToeOfFillet, double slopedFlangeAngle, double webThickness, double webThicknessLocation, double webFillet, double topWebFillet, double webToeOfFillet, double slopedWebAngle, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Tees shape.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm)
      @slopedFlangeAngle: Sloped flange angle. (rad)
      @webThickness: Web Thickness.
      @webThicknessLocation: Web Thickness Location.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @topWebFillet: Top Web Fillet - fillet radius at the top of web.
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @slopedWebAngle: Sloped web angle. (rad)
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double FlangeFillet { get; set; }
      Description: Flange Fillet - fillet radius at the flange end.
    double FlangeToeOfFillet { get; set; }
      Description: Detailing distance from center of web to flange toe of fillet, in. (mm)
    double SlopedFlangeAngle { get; set; }
      Description: Sloped flange angle. (rad)
    double SlopedWebAngle { get; set; }
      Description: Sloped web angle. (rad)
    double TopWebFillet { get; set; }
      Description: Top Web Fillet - fillet radius at the top of web.
    double WebToeOfFillet { get; set; }
      Description: Detailing distance from outer face of flange to web toe of fillet, in. (mm)

  METHODS:
    double GetFlangeThicknessInFlangeCenter()
      Description: Returns thickness of flange measured in the 0.25 * (width - webThickess), sometimes used for sections with width > 300 mm.
    double GetFlangeThicknessInQuarterWidth()
      Description: Returns thickness of flange measured in the 0.25 * width, sometimes used for sections with width <= 300 mm.
    double GetWebThicknessInHeightCenter()
      Description: Returns thickness of web measured in the 0.5 * height,

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralU
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU
Description: Defines parameters for general Channel shape.
Inherits: StructuralSectionHotRolled

  CONSTRUCTORS:
    new StructuralSectionGeneralU(double width, double height, double flangeThickness, double flangeThicknessLocation, double flangeFillet, double flangeToeOfFillet, double slopedFlangeAngle, double webThickness, double webFillet, double webToeOfFillet, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of general Channel shape.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm)
      @slopedFlangeAngle: Sloped flange angle. (rad)
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double FlangeFillet { get; set; }
      Description: Flange Fillet - fillet radius at the flange end.
    double FlangeToeOfFillet { get; set; }
      Description: Detailing distance from center of web to flange toe of fillet, in. (mm)
    double SlopedFlangeAngle { get; set; }
      Description: Sloped flange angle. (rad)
    double WebToeOfFillet { get; set; }
      Description: Detailing distance from outer face of flange to web toe of fillet, in. (mm)

  METHODS:
    double GetFlangeThicknessInFlangeCenter()
      Description: Returns thickness of flange measured in the 0.5 * (width - webThickess), sometimes used for sections with width > 300 mm.
    double GetFlangeThicknessInWidthCenter()
      Description: Returns thickness of flange measured in the 0.5 * width, sometimes used for sections with width <= 300 mm.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionGeneralW
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW
Description: Defines parameters for Angle structural section.
Inherits: StructuralSectionHotRolled

  CONSTRUCTORS:
    new StructuralSectionGeneralW(double width, double height, double flangeThickness, double webThickness, double webFillet, double flangeFillet, double topWebFillet, double centroidHorizontal, double centroidVertical, StructuralSectionAnalysisParams analysisParams)
      Description: Creates a new instance of Angle shape.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @topWebFillet: Top Web Fillet - fillet radius at the top of web.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @analysisParams: Common set of parameters for structural analysis.

  PROPERTIES:
    double FlangeFillet { get; set; }
      Description: Flange Fillet - fillet radius at the flange end.
    double TopWebFillet { get; set; }
      Description: Top Web Fillet - fillet radius at the top of web.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionHotRolled
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled
Description: Defines parameters for hot rolled structural sections.
Inherits: StructuralSectionRectangular

  PROPERTIES:
    double FlangeThickness { get; set; }
      Description: Flange Thickness.
    double FlangeThicknessLocation { get; set; }
      Description: Flange Thickness Location.
    double WebFillet { get; set; }
      Description: Web Fillet - fillet radius between web and flange.
    double WebThickness { get; set; }
      Description: Web Thickness.
    double WebThicknessLocation { get; set; }
      Description: Web Thickness Location.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionIParallelFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIParallelFlange
Description: Defines parameters for I-shape Parallel Flange structural section.
Inherits: StructuralSectionGeneralI

  CONSTRUCTORS:
    new StructuralSectionIParallelFlange(double width, double height, double flangeThickness, double webThickness, double webFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double flangeToeOfFillet, double webToeOfFillet, double boltSpacing, double boltDiameter)
      Description: Creates a new instance of Structural Section I Parallel Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes Of the fillets, in.(mm)
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionISlopedFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISlopedFlange
Description: Defines parameters for I-shape Sloped Flange structural section.
Inherits: StructuralSectionGeneralI

  CONSTRUCTORS:
    new StructuralSectionISlopedFlange(double width, double height, double flangeThickness, double flangeThicknessLocation, double webThickness, double webFillet, double flangeFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double webToeOfFillet, double boltSpacing, double boltDiameter, double slopedFlangeAngle)
      Description: Creates a new instance of Structural Section I Sloped Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes of the fillets, in.(mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)
      @slopedFlangeAngle: Sloped flange angle. (rad)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionISplitParallelFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitParallelFlange
Description: Defines parameters for I-split Parallel Flange structural section.
Inherits: StructuralSectionGeneralT

  CONSTRUCTORS:
    new StructuralSectionISplitParallelFlange(double width, double height, double flangeThickness, double webThickness, double webFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double flangeToeOfFillet, double webToeOfFillet, double boltSpacing, double boltDiameter)
      Description: Creates a new instance of Structural Section I Split Parallel Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes of the fillets, in.(mm)
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionISplitSlopedFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionISplitSlopedFlange
Description: Defines parameters for I-split Sloped Flange structural section.
Inherits: StructuralSectionGeneralT

  CONSTRUCTORS:
    new StructuralSectionISplitSlopedFlange(double width, double height, double flangeThickness, double flangeThicknessLocation, double webThickness, double webFillet, double flangeFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double webToeOfFillet, double boltSpacing, double boltDiameter, double slopedFlangeAngle)
      Description: Creates a new instance of Structural Section I Split Sloped Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes of the fillets, in.(mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)
      @slopedFlangeAngle: Sloped flange angle. (rad)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionIWelded
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWelded
Description: Defines parameters for I-shape Welded structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionIWelded(double width, double height, double topFlangeThickness, double topFlangeWidth, double bottomFlangeThickness, double bottomFlangeWidth, double webThickness, double webHeight, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section I Welded shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @topFlangeThickness: Top Flange Thickness.
      @topFlangeWidth: Top Flange Width.
      @bottomFlangeThickness: Bottom Flange Thickness.
      @bottomFlangeWidth: Bottom Flange Width.
      @webThickness: Web Thickness.
      @webHeight: Web Height.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

  PROPERTIES:
    double BottomFlangeThickness { get; set; }
      Description: Bottom Flange Thickness.
    double BottomFlangeWidth { get; set; }
      Description: Bottom Flange Width.
    double TopFlangeThickness { get; set; }
      Description: Top Flange Thickness.
    double TopFlangeWidth { get; set; }
      Description: Top Flange Width.
    double WebHeight { get; set; }
      Description: Web Height.
    double WebThickness { get; set; }
      Description: Web Thickness.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionIWideFlange
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionIWideFlange
Description: Defines parameters for I-shape Wide Flange structural section.
Inherits: StructuralSectionHotRolled

  CONSTRUCTORS:
    new StructuralSectionIWideFlange(double width, double height, double flangeThickness, double webThickness, double webFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double clearWebHeight, double flangeToeOfFillet, double webToeOfFillet, double boltSpacing, double boltSpacingTwoRows, double boltSpacingBetweenRows, double boltDiameter)
      Description: Creates a new instance of Structural Section I Wide Flange shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @clearWebHeight: Detailing depth between the web toes of the fillets, in.(mm)
      @flangeToeOfFillet: Detailing distance from center of web to flange toe of fillet, in. (mm)
      @webToeOfFillet: Detailing distance from outer face of flange to web toe of fillet, in. (mm)
      @boltSpacing: Standard bolt spacing, in. (mm)
      @boltSpacingTwoRows: Standard bolt spacing for two rows , in. (mm)
      @boltSpacingBetweenRows: Standard bolt spacing between rows, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing, in. (mm)
    double BoltSpacingBetweenRows { get; set; }
      Description: Standard bolt spacing between rows, in. (mm)
    double BoltSpacingTwoRows { get; set; }
      Description: Standard bolt spacing for two rows , in. (mm)
    double ClearWebHeight { get; set; }
      Description: Detailing depth between the web toes of the fillets, in.(mm)
    double FlangeToeOfFillet { get; set; }
      Description: Detailing distance from center of web to flange toe of fillet, in. (mm)
    double WebToeOfFillet { get; set; }
      Description: Detailing distance from outer face of flange to web toe of fillet, in. (mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionLAngle
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLAngle
Description: Defines parameters for L-angle Flange structural section.
Inherits: StructuralSectionGeneralW

  CONSTRUCTORS:
    new StructuralSectionLAngle(double width, double height, double flangeThickness, double webThickness, double webFillet, double flangeFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double boltSpacing1LongerFlange, double boltSpacing2LongerFlange, double boltSpacingShorterFlange, double boltDiameterLongerFlange, double boltDiameterShorterFlange, double topWebFillet)
      Description: Creates a new instance of Structural Section L Angle shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @webThickness: Web Thickness.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @boltSpacing1LongerFlange: Standard bolt spacing first row in the longer flange, in. (mm)
      @boltSpacing2LongerFlange: Standard bolt spacing second row in the longer flange, in. (mm)
      @boltSpacingShorterFlange: Standard bolt spacing in the shorter flangI-split Parallel Flangee, in. (mm)
      @boltDiameterLongerFlange: Maximum bolt hole diameter in the longer flange, in. (mm)
      @boltDiameterShorterFlange: Maximum bolt hole diameter in the shorter flange, in. (mm)
      @topWebFillet: Top Web Fillet - fillet radius at the top of web.

  PROPERTIES:
    double BoltDiameterLongerFlange { get; set; }
      Description: Maximum bolt hole diameter in the longer flange, in. (mm)
    double BoltDiameterShorterFlange { get; set; }
      Description: Maximum bolt hole diameter in the shorter flange, in. (mm)
    double BoltSpacing1LongerFlange { get; set; }
      Description: Standard bolt spacing first row in the longer flange, in. (mm)
    double BoltSpacing2LongerFlange { get; set; }
      Description: Standard bolt spacing second row in the longer flange, in. (mm)
    double BoltSpacingShorterFlange { get; set; }
      Description: Standard bolt spacing in the shorter flange, in. (mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionLProfile
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfile
Description: Defines parameters for L profile structural section.
Inherits: StructuralSectionGeneralLA

  CONSTRUCTORS:
    new StructuralSectionLProfile(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section L Profile shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionLProfileWithLips
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionLProfileWithLips
Description: Defines parameters for L Profile with lips structural section.
Inherits: StructuralSectionGeneralLA

  CONSTRUCTORS:
    new StructuralSectionLProfileWithLips(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double lipLength)
      Description: Creates a new instance of Structural Section L Profile With Lips shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @lipLength: Lip segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionPipeStandard
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionPipeStandard
Description: Defines parameters for pipes also known as RoundHSS or HollowStructuralSection (HSS).
Inherits: StructuralSectionGeneralR

  CONSTRUCTORS:
    new StructuralSectionPipeStandard(double diameter, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double wallNominalThickness, double wallDesignThickness, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Pipe Standard shape with the associated set of parameters, used to attach to structural element.
      @diameter: Pipe Diameter.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl).
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation.
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct).
      @warpingConstant: Warping constant (Cw, Iomega, H).
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRectangleHSS
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleHSS
Description: Defines parameters for parameterized rectangle HSS structural section.
Inherits: StructuralSectionGeneralH

  CONSTRUCTORS:
    new StructuralSectionRectangleHSS(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double outerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Rectangle HSS shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @outerFillet: Outer Fillet - Corner fillet outer radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRectangleParameterized
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangleParameterized
Description: Defines parameters for parameterized rectangle structural section.
Inherits: StructuralSectionGeneralF

  CONSTRUCTORS:
    new StructuralSectionRectangleParameterized(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Rectangle Parameterized shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRectangular
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular
Description: Defines common set of parameters for structural section rectangular contour.
Inherits: StructuralSection

  PROPERTIES:
    double CentroidHorizontal { get; set; }
      Description: Distance from centroid to the left extremites along horizontal axis.
    double CentroidVertical { get; set; }
      Description: Distance from centroid to the upper extremites along vertical axis.
    double Height { get; set; }
      Description: Section height, depth.
    string NameKey { get; set; }
      Description: Name Key
    double Width { get; set; }
      Description: Section width.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRectangularBar
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangularBar
Description: Defines parameters for Rectangular Bar structural section.
Inherits: StructuralSectionGeneralF

  CONSTRUCTORS:
    new StructuralSectionRectangularBar(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Rectangular Bar shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRound
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound
Description: Defines common set of parameters for structural section round contour.
Inherits: StructuralSection

  PROPERTIES:
    double CentroidHorizontal { get; set; }
      Description: Distance from centroid to the left extremites along horizontal axis.
    double CentroidVertical { get; set; }
      Description: Distance from centroid to the upper extremites along vertical axis.
    double Diameter { get; set; }
      Description: Pipe Diameter.
    string NameKey { get; set; }
      Description: Name Key

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRoundBar
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundBar
Description: Defines parameters for Round Bar structural section.
Inherits: StructuralSectionGeneralS

  CONSTRUCTORS:
    new StructuralSectionRoundBar(double diameter, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Round Bar shape with the associated set of parameters, used to attach to structural element.
      @diameter: Pipe Diameter.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[CLASS] StructuralSectionRoundHSS
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRoundHSS
Description: Defines parameters for pipes known as Round HSS (HollowStructuralSection).
Inherits: StructuralSectionGeneralR

  CONSTRUCTORS:
    new StructuralSectionRoundHSS(double diameter, double wallNominalThickness, double wallDesignThickness, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section Round HSS shape with the associated set of parameters, used to attach to structural element.
      @diameter: Pipe Diameter.
      @wallNominalThickness: Represents wall nominal thickness of pipe.
      @wallDesignThickness: Represents wall design thickness of pipe.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl).
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation.
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct).
      @warpingConstant: Warping constant (Cw, Iomega, H).
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[ENUM] StructuralSectionShape
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionShape
Description: Shapes for structural sections.
Remarks: Allow safely differentiate between classes inherited from Autodesk::Revit::DB::Structure::StructuralSections::StructuralSection class.
Inherits: Enum

  Values:
    - NotDefined = 0
    - RectangleParameterized = 2
    - PipeStandard = 5
    - IParallelFlange = 6
    - ISlopedFlange = 7
    - IWideFlange = 8
    - CParallelFlange = 9
    - CSlopedFlange = 10
    - LAngle = 11
    - RectangularBar = 12
    - RoundBar = 13
    - RectangleHSS = 14
    - RoundHSS = 15
    - IWelded = 16
    - ISplitParallelFlange = 17
    - ISplitSlopedFlange = 18
    - StructuralTees = 19
    - CProfile = 20
    - CProfileWithLips = 21
    - CProfileWithFold = 22
    - LProfile = 23
    - LProfileWithLips = 24
    - ZProfile = 25
    - ZProfileWithLips = 26
    - SigmaProfile = 27
    - SigmaProfileWithLips = 28
    - SigmaProfileWithFold = 29
    - UserDefined = 30
    - ConcreteRectangle = 31
    - ConcreteRectangleCut = 32
    - ConcreteT = 33
    - ConcreteCross = 34
    - ConcreteRound = 35
    - Invalid = -1

--------------------------------------------------------------------------------

[CLASS] StructuralSectionSigmaProfile
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfile
Description: Defines parameters for Sigma Profile structural section.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionSigmaProfile(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double bendWidth, double middleBendLength, double topBendLength)
      Description: Creates a new instance of Structural Section Sigma Profile shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @bendWidth: Bend segment width.
      @middleBendLength: Middle Bend segment length.
      @topBendLength: Top Bend segment length.

  PROPERTIES:
    double BendWidth { get; set; }
      Description: Bend segment width.
    double MiddleBendLength { get; set; }
      Description: Middle Bend segment length.
    double TopBendLength { get; set; }
      Description: Top Bend segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionSigmaProfileWithFold
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithFold
Description: Defines parameters for structural Sigma profile section with fold.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionSigmaProfileWithFold(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double foldWidth, double lipLength, double bendWidth, double middleBendLength, double topBendLength)
      Description: Creates a new instance of Structural Section Sigma Profile With Fold shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @foldWidth: Fold segment width.
      @lipLength: Lip segment length.
      @bendWidth: Bend segment width.
      @middleBendLength: Middle Bend segment length.
      @topBendLength: Top Bend segment length.

  PROPERTIES:
    double BendWidth { get; set; }
      Description: Bend segment width.
    double FoldWidth { get; set; }
      Description: Fold segment width.
    double LipLength { get; set; }
      Description: Lip segment length.
    double MiddleBendLength { get; set; }
      Description: Middle Bend segment length.
    double TopBendLength { get; set; }
      Description: Top Bend segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionSigmaProfileWithLips
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionSigmaProfileWithLips
Description: Defines parameters for structural Sigma Profile section with lips.
Inherits: StructuralSectionColdFormed

  CONSTRUCTORS:
    new StructuralSectionSigmaProfileWithLips(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double lipLength, double bendWidth, double middleBendLength, double topBendLength)
      Description: Creates a new instance of Structural Section Sigma Profile With Lips shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @lipLength: Lip segment length.
      @bendWidth: Bend segment width.
      @middleBendLength: Middle Bend segment length.
      @topBendLength: Top Bend segment length.

  PROPERTIES:
    double BendWidth { get; set; }
      Description: Bend segment width.
    double LipLength { get; set; }
      Description: Lip segment length.
    double MiddleBendLength { get; set; }
      Description: Middle Bend segment length.
    double TopBendLength { get; set; }
      Description: Top Bend segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionStructuralTees
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionStructuralTees
Description: Defines parameters for Structural Tees structural section.
Inherits: StructuralSectionGeneralT

  CONSTRUCTORS:
    new StructuralSectionStructuralTees(double width, double height, double flangeThickness, double flangeThicknessLocation, double webThickness, double webThicknessLocation, double webFillet, double flangeFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double boltSpacing, double boltSpacingWeb, double boltDiameter, double slopedFlangeAngle, double slopedWebAngle, double topWebFillet)
      Description: Creates a new instance of Structural Section Tees shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @flangeThickness: Flange Thickness.
      @flangeThicknessLocation: Flange Thickness Location.
      @webThickness: Web Thickness.
      @webThicknessLocation: Web Thickness Location.
      @webFillet: Web Fillet - fillet radius between web and flange.
      @flangeFillet: Flange Fillet - fillet radius at the flange end.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @boltSpacing: Standard bolt spacing in the flange, in. (mm)
      @boltSpacingWeb: Standard bolt spacing in the web, in. (mm)
      @boltDiameter: Maximum bolt hole diameter, in. (mm)
      @slopedFlangeAngle: Sloped flange angle. (rad)
      @slopedWebAngle: Sloped web angle. (rad)
      @topWebFillet: Top Web Fillet - fillet radius at the top of web.

  PROPERTIES:
    double BoltDiameter { get; set; }
      Description: Maximum bolt hole diameter, in. (mm)
    double BoltSpacing { get; set; }
      Description: Standard bolt spacing in the flange, in. (mm)
    double BoltSpacingWeb { get; set; }
      Description: Standard bolt spacing in the web, in. (mm)

--------------------------------------------------------------------------------

[CLASS] StructuralSectionUserDefined
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUserDefined
Description: Defines parameters for parameterized user defined structural section.
Inherits: StructuralSectionRectangular

  CONSTRUCTORS:
    new StructuralSectionUserDefined(double width, double height, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis)
      Description: Creates a new instance of Structural Section User Defined shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).

--------------------------------------------------------------------------------

[ABSTRACT CLASS] StructuralSectionUtils
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils
Description: This class provides utilities related to Structural Section Properties.

  METHODS:
    static StructuralSectionErrorCode GetStructuralElementDefinitionData(Document document, ElementId elementId, out StructuralElementDefinitionData data)
      Description: Return structural element definition data.
      @document: The document that owns the beam, brace or structural column.
      @elementId: ID of family instance for beam, brace or structural column.
      @data: Structural element definition data.
      Returns: Success code is returned if StructuralElementDefinitionData was provided successfully, error code otherwise.
      Throws ArgumentNullException: A non-optional argument was null
    static StructuralSection GetStructuralSection(Document document, ElementId elementId)
      Description: Return structural section from element.
      @document: The document that owns the family for beam, brace or structural column.
      @elementId: ID of family symbol or family instance for beam, brace or structural column.
      Returns: Structural section returned if element have one. For elements that do not have structural section or can not have structural section will be returned.
      Throws ArgumentNullException: A non-optional argument was null
    static bool SetStructuralSection(Document document, ElementId familySymbolId, StructuralSection structuralSection)
      Description: Set structural section in element.
      @document: The document that owns the family for beam, brace or structural column.
      @familySymbolId: ID of family symbol for beam, brace or structural column.
      @structuralSection: Structural section with values that will be set.
      Returns: True is returned when requested shape with values was properly set. Return false otherwise.
      Throws ArgumentNullException: A non-optional argument was null

--------------------------------------------------------------------------------

[CLASS] StructuralSectionZProfile
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfile
Description: Defines parameters for Z Profile structural section.
Inherits: StructuralSectionGeneralLZ

  CONSTRUCTORS:
    new StructuralSectionZProfile(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double bottomFlangeLength)
      Description: Creates a new instance of Structural Section Z Profile shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @bottomFlangeLength: Bottom Flange segment length.

--------------------------------------------------------------------------------

[CLASS] StructuralSectionZProfileWithLips
Full Name: Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionZProfileWithLips
Description: Defines parameters for Z Profile with lips structural section.
Inherits: StructuralSectionGeneralLZ

  CONSTRUCTORS:
    new StructuralSectionZProfileWithLips(double width, double height, double wallNominalThickness, double wallDesignThickness, double innerFillet, double centroidHorizontal, double centroidVertical, double principalAxesAngle, double sectionArea, double perimeter, double nominalWeight, double momentOfInertiaStrongAxis, double momentOfInertiaWeakAxis, double elasticModulusStrongAxis, double elasticModulusWeakAxis, double plasticModulusStrongAxis, double plasticModulusWeakAxis, double torsionalMomentOfInertia, double torsionalModulus, double warpingConstant, double shearAreaStrongAxis, double shearAreaWeakAxis, double bottomFlangeLength, double lipLength)
      Description: Creates a new instance of Structural Section Z Profile With Lips shape with the associated set of parameters, used to attach to structural element.
      @width: Section width.
      @height: Section height, depth.
      @wallNominalThickness: Represents wall nominal thickness of rectangle.
      @wallDesignThickness: Represents wall design thickness of rectangle.
      @innerFillet: Inner Fillet - Corner fillet inner radius.
      @centroidHorizontal: Distance from centroid to the left extremites along horizontal axis.
      @centroidVertical: Distance from centroid to the upper extremites along vertical axis.
      @principalAxesAngle: Rotation angle between the principal axes and cross section reference planes.
      @sectionArea: Cross section area.
      @perimeter: Painting surface of the unit length.
      @nominalWeight: Unit weight (not mass) per unit length, for self-weight calculation or quantity survey.
      @momentOfInertiaStrongAxis: Moment of Inertia about main strong axis (I).
      @momentOfInertiaWeakAxis: Moment of Inertia about main weak axis (I).
      @elasticModulusStrongAxis: Elastic section modulus about main strong axis for calculation of bending stresses.
      @elasticModulusWeakAxis: Elastic section modulus about main weak axis for calculation of bending stresses.
      @plasticModulusStrongAxis: Plastic section modulus in bending about main strong axis (Z, Wpl)
      @plasticModulusWeakAxis: Plastic section modulus in bending about main weak axis.
      @torsionalMomentOfInertia: Torsional Moment of inertia (J, IT, K), for calculation of torsional deformation
      @torsionalModulus: Section modulus for calculations of torsion stresses (Ct)
      @warpingConstant: Warping constant (Cw, Iomega, H)
      @shearAreaStrongAxis: Shear area (reduced extreme shear stress coefficient) in the direction of strong axis (Wq).
      @shearAreaWeakAxis: Shear area (reduced extreme shear stress coefficient) in the direction of weak axis (Wq).
      @bottomFlangeLength: Bottom Flange segment length.
      @lipLength: Lip segment length.

--------------------------------------------------------------------------------

