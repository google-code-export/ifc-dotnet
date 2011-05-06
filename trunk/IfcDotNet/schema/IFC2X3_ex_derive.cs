﻿#region License
/*

Copyright 2011, Iain Sproat
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are
met:

 * Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above
copyright notice, this list of conditions and the following disclaimer
in the documentation and/or other materials provided with the
distribution.
 * The names of the contributors may not be used to endorse or promote products derived from
this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 */

#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#pragma warning disable 1591
namespace IfcDotNet.Schema
{
	public partial class IfcAxis1Placement{
		[XmlIgnore()]
		public IfcDirection Z{
			get{
				return Functions.NVL<IfcDirection>(Functions.IfcNormalise(this.Axis.Item), new IfcDirection(0, 0, 1));
			}
		}
		
	}
	
	public partial class IfcAxis2Placement2D{
		[XmlIgnore()]
		public IList<IfcDirection> P{
			get{ return Functions.IfcBuild2Axes(this.RefDirection.Item); }
		}
	}
	
	public partial class IfcAxis2Placement3D{
		[XmlIgnore()]
		public IList<IfcDirection> P{
			get{ return Functions.IfcBuild2Axes(this.RefDirection.Item); }
		}
	}
	
	public partial class IfcBooleanResult : IfcBooleanOperand{
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return this.FirstOperand.Item.Dim; }
		}
	}
	
	public partial class IfcBoundingBox{
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return new IfcDimensionCount1(3); }
		}
	}
	
	public partial class IfcBSplineCurve{
		[XmlIgnore()]
		public int UpperIndexOnControlPoints{
			get{ return this.ControlPointsList.IfcCartesianPoint.Length -1; }
		}
		
		[XmlIgnore()]
		public IfcCartesianPoint[] ControlPoints{
			get{ return this.ControlPointsList.IfcCartesianPoint; }
		}
	}
	
	//FIXME new release for IFC2X4
	/*public partial class IfcBSplineCurveWithKnots{
		[XmlIgnore()]
		public int UpperIndexOnKnots{
			get{ return this.Knots.Length; }
		}
		//UpperIndexOnKnots	: INTEGER := SIZEOF(Knots);
	}
	 */
	
	public partial class IfcBSplineSurface{
		//TODO new release for IFC2X4
	}
	
	public partial class IfcBSplineSurfaceWithKnots{
		//TODO new release for IFC2X4
	}
	
	public partial class IfcCartesianPoint{
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return this.Coordinates.IfcLengthMeasure.Length; }
		}
	}
	
	public partial class IfcCartesianTransformationOperator{
		[XmlIgnore()]
		public double Scl{
			get{
				if(this.Scale.HasValue)
					return this.Scale.Value;
				return 1.0;
			}
		}
		
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return this.LocalOrigin.Item.Dim; }
		}
		//Scl	: REAL := NVL(Scale, 1.0);
		//Dim	: IfcDimensionCount := LocalOrigin.Dim;
	}
	
	public partial class IfcCartesianTransformationOperator2D{
		[XmlIgnore()]
		public IList<IfcDirection> U{
			get{
				return Functions.IfcBaseAxis(2, this.Axis1.Item, this.Axis2.Item, null);
			}
		}
		//U	: LIST [2:2] OF IfcDirection := IfcBaseAxis(2,SELF\IfcCartesianTransformationOperator.Axis1, SELF\IfcCartesianTransformationOperator.Axis2,?);
	}
	
	public partial class IfcCartesianTransformationOperator2DnonUniform{
		//TODO
	}
	
	public partial class IfcCartesianTransformationOperator3D{
		//TODO
	}
	
	public partial class IfcCartesianTransformationOperator3DnonUniform{
		//TODO
	}
	
	public partial class IfcCompositeCurve{
		//TODO
	}
	
	public partial class IfcCompositeCurveOnSurface{
		//TODO
	}
	
	public partial class IfcCompositeCurveSegment{
		//TODO
	}
	
	public partial class IfcCsgPrimitive3D : IfcBooleanOperand{
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return new IfcDimensionCount1(3); }
		}
	}
	
	public partial class IfcCurve{
		//TODO
	}
	
	public partial class IfcDerivedUnit{
		//TODO
	}
	
	public partial class IfcDirection{
		//TODO
	}
	
	public partial class IfcEdgeLoop{
		//TODO
	}
	
	public partial class IfcFaceBasedSurfaceModel{
		//TODO
	}
	
	public partial class IfcGeometricRepresentationSubContext{
		//TODO
	}
	
	public partial class IfcGeometricSet{
		//TODO
	}
	
	public partial class IfcHalfSpaceSolid : IfcBooleanOperand{
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return new IfcDimensionCount1(3); }
		}
	}
	
	public partial class IfcMaterialLayerSet{
		//TODO
	}
	
	public partial class IfcMirroredProfileDef{
		//TODO
	}
	
	public partial class IfcOrientedEdge{
		//TODO
	}
	
	public partial class IfcPlacement{
		//TODO
	}
	
	public partial class IfcPointOnCurve{
		//TODO
	}
	
	public partial class IfcPointOnSurface{
		//TODO
	}
	
	public partial class IfcRationalBSplineCurveWithKnots{
		//TODO
	}
	
	public partial class IfcRationalBSplineSurfaceWithKnots{
		//TODO
	}
	
	public partial class IfcReinforcingBar{
		//TODO
	}
	
	public partial class IfcReinforcingBarType{
		//TODO
	}
	
	public partial class IfcReinforcingMesh{
		//TODO
	}
	
	public partial class IfcReinforcingMeshType{
		//TODO
	}
	
	public partial class IfcRevolvedAreaSolid{
		//TODO
	}
	
	public partial class IfcSectionedSpine{
		//TODO
	}
	
	public partial class IfcShellBasedSurfaceModel{
		//TODO
	}
	
	public partial class IfcSIUnit{
		
		/// <summary>
		/// The dimensional exponents of SI units are derived by function IfcDimensionsForSiUnit.
		/// </summary>
		[StepProperty(Order=0,Overridden=true)]
		public override IfcNamedUnitDimensions Dimensions{
			get{ return null; }
			set{ //do nothing
			}
		}
	}
	
	public partial class IfcSolidModel : IfcBooleanOperand{
		[XmlIgnore()]
		public IfcDimensionCount1 Dim{
			get{ return new IfcDimensionCount1(3); }
		}
	}
	
	public partial class IfcStructuralLinearAction{
		//TODO
	}
	
	public partial class IfcStructuralLoadCase{
		//TODO
	}
	
	public partial class IfcStructuralPlanarAction{
		//TODO
	}
	
	public partial class IfcSurface{
		//TODO
	}
	
	public partial class IfcSurfaceOfLinearExtrusion{
		//TODO
	}
	
	public partial class IfcSurfaceOfRevolution{
		//TODO
	}
	
	public partial class IfcTable{
		//TODO
	}
	
	public partial class IfcVector{
		public IfcDimensionCount1 Dim{
			get{ return this.Orientation.Item.Dim;}
		}
	}
	
}