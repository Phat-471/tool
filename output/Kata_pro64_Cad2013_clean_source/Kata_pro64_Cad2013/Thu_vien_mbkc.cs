using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FvPr3dDkGF8J09q6AAZX;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Thu_vien_mbkc
{
	public struct diem_bien_dam
	{
		public diem point;

		public bool cong_xon;
	}

	private struct BG7imUD9fufsFBksg8pe
	{
		public double f8UD9WLXade;

		public double rmQD9vomJta;

		public double Q7sD9rBte5i;

		public double oIvD9l78fsd;

		public double wfoD9XTKLjD;

		public double gI2D9SKMy0P;

		public double hEgD9dbffL8;

		public double WJND9gmJtsU;

		public double P55D9M7iSgF;
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

	internal static Thu_vien_mbkc MFZyI2Th7Trnarc7Ok4W;

	// C# has no syntax for parameterized property 'Second_Beam'.
	public static info_SecondBeam get_Second_Beam(object objent, ref string key)
	{
		return (info_SecondBeam)(object)null;
	}

	// C# has no syntax for parameterized property 'info_Block_Beam_Rebar'.
	public static info_Block_Beam_Rebar get_info_Block_Beam_Rebar(object objent)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'dam1_to_blockbeam'.
	public static info_BlockBeam_ThepBoTri get_dam1_to_blockbeam(object Excelsheet)
	{
		return null;
	}

	static Thu_vien_mbkc()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
		int num = 4;
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
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 != 0)
						{
							continue;
						}
						goto default;
					default:
						do
						{
							switch (num2)
							{
							case 11:
								break;
							case 992:
								goto end_IL_0049;
							default:
								goto end_IL_0071;
							}
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 1;
						}
						while (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2fd7730740d245ffb855794cabb17218 == 0);
						continue;
					case 4:
						goto end_IL_0071;
					case 0:
						iUemXbDkFh2Nnno2jJtT.f8oTg3pM5fk();
						goto case 3;
					case 3:
						tap_dbien = new diem_bien_dam[2];
						return;
					case 2:
						return;
						end_IL_0049:
						break;
					}
					break;
				}
				continue;
				end_IL_0071:
				break;
			}
			b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
			num = 11;
		}
	}

	public static List<object> AddBlockBeamFromBeam3D(Info_Beam3D Beam3D)
	{
		return null;
	}

	public static void AddBlockColumnWallFromColumnWall3D(Info_ColumnWall3D ColumnWall3D)
	{
	}

	public static void AddSlabFromSlab3D(Info_Slab3D Slab3D, double TOC_ngoai = 0.0)
	{
	}

	public static PolygonModule.Polygon GetPolygonFromGocLBAng(ref diem goc, int L, int B, double ang, double XScaleFactor)
	{
		return null;
	}

	public static Info_ColumnWall3D GetPolygonFromBlockColumnWall(object block)
	{
		return null;
	}

	public static double[] ReadMbkcBeamSection(string text)
	{
		return null;
	}

	public static Info_Beam3D GetPolygonFromBlockBeam(object block, bool readOnlyScan = false)
	{
		return null;
	}

	public static Info_Slab3D GetPolygonFromPlineSanCad(object pl)
	{
		return null;
	}

	public static bool Check_BoundingBox_in(object ent, diem Mindiem, diem Maxdiem)
	{
		return true;
	}

	public static bool check_ten_blockxref(string ten)
	{
		return true;
	}

	private static BG7imUD9fufsFBksg8pe zXEBrKWGZsb()
	{
		return (BG7imUD9fufsFBksg8pe)(object)null;
	}

	private static diem naABrfv5RHh(object object_0, BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0)
	{
		return null;
	}

	private static diem QEtBrW349kp(object object_0, BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0)
	{
		return null;
	}

	private static BG7imUD9fufsFBksg8pe VBRBrv2piGO(BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0, object object_0)
	{
		return (BG7imUD9fufsFBksg8pe)(object)null;
	}

	private static void mbsBrrYdAF8(object object_0, BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0, ref Dictionary<string, diem> dictionary_0, ref bool bool_0, diem diem_0 = null, diem diem_1 = null, diem diem_2 = null, MbkcReadResult mbkcReadResult_0 = null, string string_0 = "", string string_1 = "")
	{
	}

	private static Info_ColumnWall3D QMtBrlTJssg(object object_0, BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0)
	{
		return null;
	}

	private static string CWjBrXrhoE4(object object_0, object object_1, string string_0 = "")
	{
		return null;
	}

	private static string hfgBrSStSaG(object object_0, object object_1, object object_2)
	{
		return null;
	}

	private static object u9oBrdtXkpM(object object_0, Dictionary<string, object> dictionary_0)
	{
		return null;
	}

	private static void RuDBrgpH4pY(object object_0, BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0, ref Dictionary<string, diem> dictionary_0, ref bool bool_0, diem diem_0 = null, diem diem_1 = null, diem diem_2 = null, bool bool_1 = true, bool bool_2 = true, object object_1 = null, string string_0 = "", int int_0 = 0, MbkcReadResult mbkcReadResult_0 = null, string string_1 = "")
	{
	}

	private static void VI6BrMUM6An(object object_0, BG7imUD9fufsFBksg8pe bg7imUD9fufsFBksg8pe_0, ref Dictionary<string, diem> dictionary_0, ref bool bool_0, diem diem_0 = null, diem diem_1 = null, diem diem_2 = null, bool bool_1 = true, bool bool_2 = true, object object_1 = null, string string_0 = "", int int_0 = 0, MbkcReadResult mbkcReadResult_0 = null, string string_1 = "")
	{
	}

	public static double MbkcGridLabelDistance(info_CurveGrid grid, diem center, double scale)
	{
		return 0.0;
	}

	private static void ccrBr7rIyhv(object object_0, Dictionary<string, diem> dictionary_0)
	{
	}

	public static void GetAllTap_Mbkc(object ssetObj = null, diem SelectCenter = null, bool lay_Grid = true, bool lay_SecondBeam = true)
	{
	}

	public static MbkcReadResult ReadMbkcObjects(object ssetObj, diem SelectCenter = null, bool lay_Grid = true, bool lay_SecondBeam = true, bool readOnlyScan = true, bool preserveRepeatedGrids = true)
	{
		return null;
	}

	public static List<Bien_chung.info_revit_slab> Get_tap_san_from_Slab3D(List<Info_Slab3D> Tap_Slab3D)
	{
		return null;
	}

	public static List<diem> xd_ListDiem_Beam3DGiaoPolygon(Info_Beam3D Beam3D, PolygonModule.Polygon Polygon, ref int vt_giao)
	{
		return null;
	}

	internal static List<diem> yoRBrE3n6Fg(IEnumerable<diem> ienumerable_0, object object_0)
	{
		return null;
	}

	internal static List<diem> DuKBrsc9rVH(object object_0, object object_1)
	{
		return null;
	}

	private static List<diem> QCeBrJ6DVFE(object object_0, object object_1, double double_0 = -1.0)
	{
		return null;
	}

	internal static List<diem> sdJBreDM67L(object object_0, object object_1, double double_0)
	{
		return null;
	}

	private static bool Eg5BrQEMsfv(object object_0)
	{
		return true;
	}

	private static PolygonModule.Polygon OvaBrAOvkPs(object object_0, object object_1)
	{
		return null;
	}

	private static List<diem> HOjBrHuvEBQ(object object_0, object object_1, ref int int_0)
	{
		return null;
	}

	public static string Ten_kich_thuoc(List<Info_Beam3D> Beams)
	{
		return null;
	}

	public static bool Goc2dam_be45(Info_Beam3D dam1, Info_Beam3D dam2)
	{
		return true;
	}

	private static bool vLOBrLd4EoC(object object_0, object object_1)
	{
		return true;
	}

	public static void xd_kc_goi_2dau_dam(Info_Beam3D Cur_Beam3D, ref Tuple<int[], PolygonModule.Polygon[]> Tuple_giao)
	{
	}

	public static int Giu_1dam_xd_sl(List<Info_Beam3D> Beams, [Optional][DefaultParameterValue(null)] ref List<List<Info_Beam3D>> List_1Beam)
	{
		return 0;
	}

	private static int c3GBr2Avu0t(List<Info_Beam3D> list_0, [Optional][DefaultParameterValue(null)] ref List<List<Info_Beam3D>> list_1)
	{
		return 0;
	}

	private static bool eyPBrqhdUgC(object object_0, object object_1)
	{
		return true;
	}

	public static diem xd_d_connect_goi(diem d, [Optional][DefaultParameterValue(0)] ref int L_cot, [Optional][DefaultParameterValue(null)] ref PolygonModule.CurveXYZ Cot_centerline)
	{
		return null;
	}

	private static void ONjBr4y9gfD(object object_0, ref PolygonModule.CurveXYZ curveXYZ_0)
	{
	}

	public static diem xd_d_connect_nhip(diem d, ref Info_Beam3D Info_Beam3D)
	{
		return null;
	}

	private static diem l87BrUbyi5C(object object_0, ref Info_Beam3D info_Beam3D_0)
	{
		return null;
	}

	public static Info_Beam3D xd_Beam3DFromDiem(diem d)
	{
		return null;
	}

	private static Info_Beam3D FsRBrtTZREP(object object_0)
	{
		return null;
	}

	public static void Add_BlockBeamRebar_AllData1nhip(info_BlockBeam_AllData1nhip dami, bool Add_tap_BlockBeamRebar_Erase = true, byte Type = 0)
	{
	}

	public static Dictionary<string, string> BeamRebarAttributeTexts(info_BlockBeam_ThepBoTri steel, int j, bool singleZone = false)
	{
		return null;
	}

	public static void Add_BlockBeamRebar_ThepBoTri(info_BlockBeam_AllData1nhip dami)
	{
	}

	public static void Erase_Beam_Rebar(diem d_dau, diem d_cuoi, ref List<object> Tap_BlockBeamRebar_Erase)
	{
	}

	public static info_Block_Beam_Rebar ParseBeamRebarAttributes(IDictionary<string, string> values, bool preserveTieRoles = true)
	{
		return null;
	}

	public static void update_dataValue(ref object dataValue, int i, string Value)
	{
	}

	public static void update_thep_dam_mbkc(List<object> tap_Block_Beam_Rebar)
	{
	}

	public static void dua_thep_blockbeam_vao_data_vedam(info_BlockBeam_ThepBoTri dami, int nhip, int L_cot, ref info_vedam data_vedam)
	{
	}

	public static List<info_BlockBeam_ThepBoTri> Get_BlockBeam_ThepBoTri(ref object blockbeam)
	{
		return null;
	}

	public static List<info_BlockBeam_DataEtabs> Get_BlockBeam_DataEtabs(ref object blockbeam)
	{
		return null;
	}

	public static void gan_XRecord_blockbeam(ref object blockbeam, info_BlockBeam_ThepBoTri dami, int nhip = 1)
	{
	}

	public static int gan_XRecord_blockbeam_chi_nhip1(ref object blockbeam, info_BlockBeam_ThepBoTri dami)
	{
		return 0;
	}

	public static void save_thep_to_blockbeam()
	{
	}

	public static bool create_link_Beam(object sset)
	{
		return true;
	}

	public static bool hightlightBlockBeam(object objent, string ten)
	{
		return true;
	}

	internal static bool vbe6DZThEaFx4jFnPwVJ()
	{
		return true;
	}

	internal static Thu_vien_mbkc w9GAeFThsNlLgJRYN5mZ()
	{
		return null;
	}
}
