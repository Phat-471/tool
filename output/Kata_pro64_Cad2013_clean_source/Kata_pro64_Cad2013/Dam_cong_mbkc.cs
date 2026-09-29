using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Dam_cong_mbkc
{
	public class InfoDamCongMbkcXData
	{
		[CompilerGenerated]
		private string sklBSrZhwiU;

		[CompilerGenerated]
		private string RUsBSlFDw6p;

		[CompilerGenerated]
		private string OvLBSXNC6jS;

		[CompilerGenerated]
		private string macBSSAQQtq;

		[CompilerGenerated]
		private string uigBSdp8hHo;

		[CompilerGenerated]
		private string qKpBSgjimqU;

		private static InfoDamCongMbkcXData fy84M7TDHQNbZ0ha1ssP;

		public string TenDam
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string B
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string H
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string TypeBeam
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string CaoDo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Tai
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static InfoDamCongMbkcXData()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0054;
								}
							}
							else
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 8;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2d4a32d5aa4341e59cdd7055ceb6be5d != 0)
								{
									continue;
								}
							}
							goto case 1;
						case 2:
							break;
						case 0:
							return;
						}
						goto end_IL_0067;
						continue;
						end_IL_0054:
						break;
					}
					continue;
					end_IL_0067:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 2;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_304ef6de120f426182a7983bd4c8621a == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool hurrcWTDLaqPvdg5RqwV()
		{
			return true;
		}

		internal static InfoDamCongMbkcXData VGBbQFTD2GIBxQkIQhrI()
		{
			return null;
		}
	}

	public const string LOAIDATADAMCONGMBKC = "KATA_DAM_CONG_MKBC";

	public const string LOAIDATATHEHIENDAMCONGMBKC = "KATA_DAM_CONG_MKBC_THE_HIEN";

	internal static Dam_cong_mbkc vqVw2TG2vY0XyKphUHxn;

	public static InfoDamCongMbkcXData GetDamCongMbkcXData(object objent)
	{
		return null;
	}

	public static void SetDamCongMbkcXData(object objent, InfoDamCongMbkcXData info)
	{
	}

	public static Info_Beam3D GetInfoBeam3DFromDamCongPolyline(object objent)
	{
		return null;
	}

	public static TypeBeam GetDamCongMbkcTypeBeam(string typeBeamText)
	{
		return (TypeBeam)(object)null;
	}

	public static bool HasDamCong(IEnumerable<Info_Beam3D> beams)
	{
		return true;
	}

	public static Info_Beam3D PrepareBeamForMbkc(Info_Beam3D source)
	{
		return null;
	}

	public static double BeamSectionStation(PolygonModule.CurveXYZ axis, diem point)
	{
		return 0.0;
	}

	public static bool TryGetStraightSectionAxis(IEnumerable<Info_Beam3D> beams, ref PolygonModule.CurveXYZ axis)
	{
		return true;
	}

	public static bool RequiresPlanBeamLayout(IEnumerable<Info_Beam3D> beams)
	{
		return true;
	}

	public static double BeamPathSortKey(Info_Beam3D beam)
	{
		return 0.0;
	}

	public static PolygonModule.CurveXYZ GetBeamPathCurveAtPoint(Info_Beam3D beam, diem p)
	{
		return null;
	}

	public static double BeamPathAngleAtPoint(Info_Beam3D beam, diem p)
	{
		return 0.0;
	}

	public static PolygonModule.Polygon GetExtendedBeamPath(Info_Beam3D beam, double delta)
	{
		return null;
	}

	public static List<diem> GetBeamCongGiaoPolygon(Info_Beam3D beam, PolygonModule.Polygon pl, ref int vt_giao)
	{
		return null;
	}

	public static diem BeamPathNearestPointOnPath(Info_Beam3D beam, diem p)
	{
		return null;
	}

	public static diem BeamPathNearestPointForSupport(Info_Beam3D beam, diem p, [Optional][DefaultParameterValue(0.0)] ref double station)
	{
		return null;
	}

	public static List<diem> UniqueBeamPathPoints(List<diem> points, double tolerance = 5.0)
	{
		return null;
	}

	public static PolygonModule.Polygon BeamCongSegmentBetween(Info_Beam3D source, diem p1, diem p2)
	{
		return null;
	}

	public static Info_Beam3D CloneBeamCongSegment(Info_Beam3D source, diem p1, diem p2)
	{
		return null;
	}

	public static void SetBeamCongStart(ref Info_Beam3D beam, diem p)
	{
	}

	public static void SetBeamCongEnd(ref Info_Beam3D beam, diem p)
	{
	}

	public static void AddBeamCongSpanIfValid(Info_Beam3D source, diem p1, diem p2, ref List<Info_Beam3D> spans)
	{
	}

	public static void MergeBeamCongToFirst(ref Info_Beam3D firstBeam, Info_Beam3D secondBeam)
	{
	}

	public static PolygonModule.Polygon BeamPath(Info_Beam3D beam)
	{
		return null;
	}

	public static diem BeamPathStart(Info_Beam3D beam)
	{
		return null;
	}

	public static diem BeamPathEnd(Info_Beam3D beam)
	{
		return null;
	}

	public static double BeamPathLength(Info_Beam3D beam)
	{
		return 0.0;
	}

	public static double BeamPathLengthAtPoint(Info_Beam3D beam, diem p)
	{
		return 0.0;
	}

	public static diem BeamPathPointAtLength(Info_Beam3D beam, double length)
	{
		return null;
	}

	public static bool IsCurvedBeamPath(Info_Beam3D beam)
	{
		return true;
	}

	public static Info_Beam3D CloneBeamWithCenterLine(Info_Beam3D source, PolygonModule.Polygon centerLine)
	{
		return null;
	}

	public static void ReverseBeamPath(ref Info_Beam3D beam)
	{
	}

	public static Tuple<Info_Beam3D, Info_Beam3D> CutBeamPathAtPoint(Info_Beam3D source, diem p)
	{
		return null;
	}

	public static Tuple<Info_Beam3D, Info_Beam3D, Info_Beam3D> CutBeamPathAtTwoPoints(Info_Beam3D source, diem p1, diem p2)
	{
		return null;
	}

	public static diem GetBeamPathNearestPoint(Info_Beam3D beam, diem p)
	{
		return null;
	}

	public static List<diem> GetBeamPathIntersectionWithPolygon(Info_Beam3D beam, PolygonModule.Polygon pl)
	{
		return null;
	}

	public static List<diem> GetBeamPathIntersectionWithBeam(Info_Beam3D beam, Info_Beam3D beamGiao)
	{
		return null;
	}

	private static void JmgCjiVLga0(ref List<diem> list_0, List<diem> list_1, double double_0 = 5.0)
	{
	}

	private static PolygonModule.Polygon kUdCj9yXX2v(object object_0)
	{
		return null;
	}

	private static void EHmCjbQmogg(object object_0, object object_1)
	{
	}

	private static bool OSYCjVEoVoc(object object_0)
	{
		return true;
	}

	private static int SrRCjkSB2jG(object object_0, object object_1)
	{
		return 0;
	}

	private static bool AoPCj39BytS(TypeBeam typeBeam_0, int int_0)
	{
		return true;
	}

	private static void PYRCj582krI(object object_0, object object_1, bool bool_0)
	{
	}

	private static void AYNCjc2aMqI(object object_0, object object_1)
	{
	}

	private static void tNACjpypymy(object object_0)
	{
	}

	public static void update_cong1()
	{
	}

	static Dam_cong_mbkc()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 0;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_934fee42d4914438a301122ea3a645b4 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							goto end_IL_0049;
						}
						b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
						num3 = 0;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3e20b8f0eaaf4c2c858e7c7ca7131a33 == 0)
						{
							continue;
						}
						goto case 2;
					case 1:
						break;
					case 0:
						return;
					}
					goto end_IL_0069;
					continue;
					end_IL_0049:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				end_IL_0069:
				break;
			}
			b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
			num = 3;
			if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_1ffce1ae5ca247c08901d03e85fad9fb != 0)
			{
				num = 9;
			}
		}
	}

	internal static bool sGCg3RG2roVg8qg8Sl34()
	{
		return true;
	}

	internal static Dam_cong_mbkc UqW5ucG2lb3pyk5hketJ()
	{
		return null;
	}
}
