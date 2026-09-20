using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Kata_Class_Lib_Revit;
using MMvEygPQ4PdjSIRahVVe;
using Microsoft.VisualBasic.CompilerServices;
using RpVxxCPmaUDhuZVeqwWU;
using wkkfIuPQq7T3mEZIPsR9;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Thu_vien_mbkc
{
	public struct diem_bien_dam
	{
		public diem point;

		public bool cong_xon;
	}

	private struct ADrAUEPmnibOtJF546rJ
	{
		public double qLcPmRPbfXZ;

		public double UKhPm6rwI8o;

		public double F5fPmpDnyUN;

		public double TfUPmhiqVlG;

		public double cQRPm7Dn3rO;

		public double xh1PmPUSExV;

		public double e5mPmDQkvv7;

		public double UyZPmggxqQl;

		public double VUKPmkZFp5N;
	}

	public const int extend = 6;

	public static Dictionary<string, Info_ColumnWall3D> TapAll_ColumnWall3D;

	public static Dictionary<string, Info_Beam3D> TapAll_Beam3D;

	public static Dictionary<string, Info_Slab3D> TapAll_Slab3D;

	public static Info_Slab3D Out_line;

	public static double CT_Out_line;

	public static Dictionary<string, Info_Slab3D> TapAll_Vungneo;

	public static Dictionary<string, info_CurveGrid> TapAll_CurveGrid;

	public static SortedDictionary<string, info_SecondBeam> TapAll_SecondBeam;

	public static List<Info_Beam3D> Beams;

	public static List<Info_Beam3D> Beams_giao_cot;

	public static List<Info_Beam3D> nhip_connect;

	public static List<List<diem>> goi_connect_list;

	public static Dictionary<diem, int> tap_cot_tren;

	public static diem_bien_dam[] tap_dbien;

	public static Dictionary<string, diem> tap_giao_grids;

	public static List<info_giat_WC> List_giat_WC;

	public static List<info_dam_giao_cotcay> tap_dam_giao_cotcay;

	public static Dictionary<string, List<List<info_BlockBeam_AllData1nhip>>> Dic_BlockBeam_AllData1nhip;

	public static List<object> Tap_BlockBeamRebar_Erase;

	internal static Thu_vien_mbkc A2xyv0kfCNsaUuOorwS3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Thu_vien_mbkc()
	{
		hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
		int num = 3;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 11)
						{
							return;
						}
						goto end_IL_0012;
					case 2:
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 4;
						continue;
					case 4:
						cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
						num3 = 0;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_259044fb2a9b4ed982aeb9fec374b138 == 0)
						{
							num3 = 11;
						}
						continue;
					case 0:
						j2fgy2PQXXu5mcBnICUJ.Cw4e9Yq8dob();
						num3 = 8;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_723e8e9fad7c44ad90fe71ad3e14db01 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						break;
					case 3:
						hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
						num3 = 2;
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			while (num2 == 992);
			tap_dbien = new diem_bien_dam[2];
			num = 7;
			if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8c0222917a0146899c36460d84bbdd86 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<object> AddBlockBeamFromBeam3D(Info_Beam3D Beam3D)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddBlockColumnWallFromColumnWall3D(Info_ColumnWall3D ColumnWall3D)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddSlabFromSlab3D(Info_Slab3D Slab3D, double TOC_ngoai = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PolygonModule.Polygon GetPolygonFromGocLBAng(ref diem goc, int L, int B, double ang, double XScaleFactor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_ColumnWall3D GetPolygonFromBlockColumnWall(object block)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double[] ReadMbkcBeamSection(string text)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Beam3D GetPolygonFromBlockBeam(object block, bool readOnlyScan = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Slab3D GetPolygonFromPlineSanCad(object pl)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static info_SecondBeam get_Second_Beam(object objent, ref string key)
	{
		return (info_SecondBeam)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Check_BoundingBox_in(object ent, diem Mindiem, diem Maxdiem)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool check_ten_blockxref(string ten)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ADrAUEPmnibOtJF546rJ y5nPh9OXgB6()
	{
		return (ADrAUEPmnibOtJF546rJ)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static diem Pp1PhKfhJfi(object P_0, ADrAUEPmnibOtJF546rJ P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static diem QjePhJEiRHB(object P_0, ADrAUEPmnibOtJF546rJ P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ADrAUEPmnibOtJF546rJ BT9PhsmBVHJ(ADrAUEPmnibOtJF546rJ P_0, object P_1)
	{
		return (ADrAUEPmnibOtJF546rJ)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void xRdPhOfMCMP(object P_0, ADrAUEPmnibOtJF546rJ P_1, ref Dictionary<string, diem> P_2, ref bool P_3, diem P_4 = null, diem P_5 = null, diem P_6 = null, MbkcReadResult P_7 = null, string P_8 = "", string P_9 = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Info_ColumnWall3D Ll6PhAeAR4V(object P_0, ADrAUEPmnibOtJF546rJ P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string rNbPhNUI114(object P_0, object P_1, string P_2 = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string S0sPhIGSLj6(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object Jw5Ph88oVFT(object P_0, Dictionary<string, object> P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ipGPhdtcCrL(object P_0, ADrAUEPmnibOtJF546rJ P_1, ref Dictionary<string, diem> P_2, ref bool P_3, diem P_4 = null, diem P_5 = null, diem P_6 = null, bool P_7 = true, bool P_8 = true, object P_9 = null, string P_10 = "", int P_11 = 0, MbkcReadResult P_12 = null, string P_13 = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void WfWPhZMCiaO(object P_0, ADrAUEPmnibOtJF546rJ P_1, ref Dictionary<string, diem> P_2, ref bool P_3, diem P_4 = null, diem P_5 = null, diem P_6 = null, bool P_7 = true, bool P_8 = true, object P_9 = null, string P_10 = "", int P_11 = 0, MbkcReadResult P_12 = null, string P_13 = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double MbkcGridLabelDistance(info_CurveGrid grid, diem center, double scale)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void eiLPhXDwWwd(object P_0, Dictionary<string, diem> P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetAllTap_Mbkc(object ssetObj = null, diem SelectCenter = null, bool lay_Grid = true, bool lay_SecondBeam = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MbkcReadResult ReadMbkcObjects(object ssetObj, diem SelectCenter = null, bool lay_Grid = true, bool lay_SecondBeam = true, bool readOnlyScan = true, bool preserveRepeatedGrids = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Bien_chung.info_revit_slab> Get_tap_san_from_Slab3D(List<Info_Slab3D> Tap_Slab3D)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> xd_ListDiem_Beam3DGiaoPolygon(Info_Beam3D Beam3D, PolygonModule.Polygon Polygon, ref int vt_giao)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<diem> r3gPh4hK5T1(IEnumerable<diem> P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<diem> J0CPhLahv2M(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<diem> X1PPhW3I7DI(object P_0, object P_1, double P_2 = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<diem> goKPhfvCnvA(object P_0, object P_1, double P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool AAhPh1qnbWL(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PolygonModule.Polygon UrNPhifjtD3(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<diem> wHpPhVX43fI(object P_0, object P_1, ref int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Ten_kich_thuoc(List<Info_Beam3D> Beams)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Goc2dam_be45(Info_Beam3D dam1, Info_Beam3D dam2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool eLIPhaaImTO(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void xd_kc_goi_2dau_dam(Info_Beam3D Cur_Beam3D, ref Tuple<int[], PolygonModule.Polygon[]> Tuple_giao)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Giu_1dam_xd_sl(List<Info_Beam3D> Beams, [Optional][DefaultParameterValue(null)] ref List<List<Info_Beam3D>> List_1Beam)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int xCpPhqyBS9K(List<Info_Beam3D> P_0, [Optional][DefaultParameterValue(null)] ref List<List<Info_Beam3D>> P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool z6tPhUVD32J(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem xd_d_connect_goi(diem d, [Optional][DefaultParameterValue(0)] ref int L_cot, [Optional][DefaultParameterValue(null)] ref PolygonModule.CurveXYZ Cot_centerline)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void l0SPhCT9hcx(object P_0, ref PolygonModule.CurveXYZ P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem xd_d_connect_nhip(diem d, ref Info_Beam3D Info_Beam3D)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static diem kOBPhMlxgSr(object P_0, ref Info_Beam3D P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Beam3D xd_Beam3DFromDiem(diem d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Info_Beam3D jSFPhbPTtYl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Add_BlockBeamRebar_AllData1nhip(info_BlockBeam_AllData1nhip dami, bool Add_tap_BlockBeamRebar_Erase = true, byte Type = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BeamRebarAttributeTexts(info_BlockBeam_ThepBoTri steel, int j, bool singleZone = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Add_BlockBeamRebar_ThepBoTri(info_BlockBeam_AllData1nhip dami)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Erase_Beam_Rebar(diem d_dau, diem d_cuoi, ref List<object> Tap_BlockBeamRebar_Erase)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static info_Block_Beam_Rebar get_info_Block_Beam_Rebar(object objent)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static info_Block_Beam_Rebar ParseBeamRebarAttributes(IDictionary<string, string> values, bool preserveTieRoles = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void update_dataValue(ref object dataValue, int i, string Value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void update_thep_dam_mbkc(List<object> tap_Block_Beam_Rebar)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void dua_thep_blockbeam_vao_data_vedam(info_BlockBeam_ThepBoTri dami, int nhip, int L_cot, ref info_vedam data_vedam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<info_BlockBeam_ThepBoTri> Get_BlockBeam_ThepBoTri(ref object blockbeam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<info_BlockBeam_DataEtabs> Get_BlockBeam_DataEtabs(ref object blockbeam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void gan_XRecord_blockbeam(ref object blockbeam, info_BlockBeam_ThepBoTri dami, int nhip = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int gan_XRecord_blockbeam_chi_nhip1(ref object blockbeam, info_BlockBeam_ThepBoTri dami)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static info_BlockBeam_ThepBoTri get_dam1_to_blockbeam(object Excelsheet)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void save_thep_to_blockbeam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool create_link_Beam(object sset)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool hightlightBlockBeam(object objent, string ten)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uJEb6GkfM8giTeUOwEGj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Thu_vien_mbkc PaWFt1kfbNpBn9GE0nsE()
	{
		return null;
	}
}
