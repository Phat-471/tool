using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Autodesk.AutoCAD.DatabaseServices;
using FvPr3dDkGF8J09q6AAZX;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Ve_Mat_Bang_Mong_Module
{
	public enum ModeBuildEtabEnum
	{
		Normal,
		MongCoc,
		MongBang,
		MongDon
	}

	public class InfoVeMatBangMong
	{
		public diem pointGoc;

		public List<InfoCotCocGenMong> listCotChiuTai;

		public List<CocChiuTai> listCocInput;

		public PolygonModule.Polygon ranhTamCoc;

		public PolygonModule.Polygon ranhBoTriDai;

		public double n1;

		public double n2;

		public int soCocToiThieu;

		public string kcDenMepDaiTxt;

		public string TienTo;

		public int SoBatDau;

		public ViTriDatTen viTriDatTen;

		public diem mainVecto;

		private static InfoVeMatBangMong wYcgh1TYM20w5GYgLEXU;

		public InfoVeMatBangMong CloneForUndo()
		{
			return null;
		}

		public void TinhToanMatBangMong()
		{
		}

		public double GetChieuDayMongByChiuTaiCoc(CocChiuTai coc)
		{
			return 0.0;
		}

		public PolygonModule.Polygon GetBBMax()
		{
			return null;
		}

		public void ReOrder(bool orderTheoTenMong = false)
		{
		}

		public void ReAssignListCocByListCocInput()
		{
		}

		public void GanId()
		{
		}

		public void GanTenMong()
		{
		}

		static InfoVeMatBangMong()
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 7;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_940333e31a9544d6808222d9f4b418f3 != 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 8;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_23ef80aa2deb4a7baaac6de0becd9a10 != 0)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0053;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						}
						goto end_IL_0066;
						continue;
						end_IL_0053:
						break;
					}
					continue;
					end_IL_0066:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_02eb9f97d81c4e8f82591f5f747031ca != 0)
				{
					num = 2;
				}
			}
		}

		internal static bool tqo0K6TY7GqdJhLk4hwK()
		{
			return true;
		}

		internal static InfoVeMatBangMong gFsLn5TYEkYGPhOm1K8E()
		{
			return null;
		}
	}

	public enum ViTriCurveDam
	{
		Trai,
		Phai,
		Dau,
		Cuoi
	}

	public class InfoAreaSpring
	{
		public string PropertyName;

		public string Local1;

		public string Local2;

		public string Local3;

		internal static InfoAreaSpring Fd4bUUTYQ32PPZblUucs;

		static InfoAreaSpring()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						IL_0049:
						switch (num3)
						{
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_86bd1bfcffba4d48bfb7f8f798e9fed8 == 0)
							{
								continue;
							}
							goto default;
						default:
							while (num2 == 9)
							{
								bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
								num3 = 2;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_f09347d075a54e3c9e3affc36c5644b5 == 0)
								{
									continue;
								}
								goto IL_0049;
							}
							goto end_IL_0049;
						case 0:
							break;
						case 2:
							return;
						}
						goto end_IL_0069;
						continue;
						end_IL_0049:
						break;
					}
					continue;
					end_IL_0069:
					break;
				}
				while (num2 == 990);
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 2;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_d9209192fb5a48db8afe33275173f36c == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool VqP5vkTYAkGInn75emSR()
		{
			return true;
		}

		internal static InfoAreaSpring Y85p4dTYHcZ3uDhgy5Ex()
		{
			return null;
		}
	}

	public class InfoMBMongBang
	{
		public diem pointGoc;

		public List<Info_Beam3D> listDamInput;

		public Dictionary<int, Tuple<string, string, string, string>> listLength;

		public List<PolygonModule.Polygon> listBaoNgoai;

		public List<PolygonModule.Polygon> listBaoTrong;

		public List<PolygonModule.Polygon> listPlMong;

		public PolygonModule.Polygon ranhBoTriDai;

		public MongBangJsonDto infoChung;

		public InfoAreaSpring areaSpring;

		public List<PolygonModule.Polygon> listPlMepDai;

		public List<PolygonModule.CurveXYZ> listLineCheo;

		public List<List<PolygonModule.CurveXYZ>> llDim;

		private static InfoMBMongBang wT53yFTYL84mheLWtP1s;

		public string GetJsonStringMong()
		{
			return null;
		}

		private void fBHDaWogRVl(ref Info_Beam3D info_Beam3D_0)
		{
		}

		private double IZKDavJCjWh(diem diem_0, diem diem_1)
		{
			return 0.0;
		}

		private void mVRDar6Zmjc(ref PolygonModule.Polygon polygon_0, double double_0, double double_1, double double_2, double double_3)
		{
		}

		private void DUGDalyMB6D(List<PolygonModule.Polygon> list_0)
		{
		}

		private void Ak4DaXHA18y()
		{
		}

		private double sv5DaSRAe4p(PolygonModule.CurveXYZ curveXYZ_0)
		{
			return 0.0;
		}

		public void TinhToanBaoLanDauSauKhiQuet(string txtTrai, string txtPhai, string txtDau, string txtCuoi)
		{
		}

		public void RegenMBMongBang()
		{
		}

		public void AssignListLengthToListDam()
		{
		}

		public PolygonModule.Polygon GetBBMax()
		{
			return null;
		}

		static InfoMBMongBang()
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
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_e953190ed2f64b37a09a51d9a33874ca != 0)
							{
								continue;
							}
							goto case 1;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c660b2a9f2294e84996cb208a4355bde != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0052;
								}
								goto case 1;
							}
							return;
						case 0:
							break;
						}
						goto end_IL_0065;
						continue;
						end_IL_0052:
						break;
					}
					continue;
					end_IL_0065:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_b164162b8046492994d14f0299ed7153 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool vrnU4XTY2BporQJLoPSD()
		{
			return true;
		}

		internal static InfoMBMongBang vqsDMJTYqsK6lWhQYjMy()
		{
			return null;
		}
	}

	public enum ViTriDatTen
	{
		Trai,
		Phai,
		Tren,
		Duoi
	}

	public class CocChiuTai
	{
		public object blkCoc;

		public double sucChiuTaiCoc;

		public PolygonModule.Polygon plCoc;

		public double diaCoc;

		public double chieuDaiCoc;

		public double giaTienCoc;

		public int soLuong;

		public string tenCoc;

		public diem center;

		public diem newPosition;

		private static CocChiuTai vR5JXOTYzkOTminujQ2u;

		public CocChiuTai Clone(diem newPos = null)
		{
			return null;
		}

		public CocChiuTai CloneForUndo(diem newPos = null)
		{
			return null;
		}

		public string GetJsonString()
		{
			return null;
		}

		static CocChiuTai()
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
						IL_0053:
						switch (num3)
						{
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_45f32ad850874067906bcaad9130e115 != 0)
							{
								continue;
							}
							goto end_IL_0066;
						case 1:
							goto end_IL_0066;
						case 0:
							return;
							IL_003b:
							while (num2 == 9)
							{
								bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
								num3 = 0;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_445fae76259b44779166efa3d5fe6733 != 0)
								{
									continue;
								}
								goto IL_0053;
							}
							goto IL_0046;
							IL_0046:
							if (num2 == 990)
							{
								goto end_IL_0053;
							}
							goto case 2;
						}
						goto IL_003b;
						continue;
						end_IL_0053:
						break;
					}
					continue;
					end_IL_0066:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 9;
			}
		}

		internal static bool RKwlUlTPwEN1hGffEJAe()
		{
			return true;
		}

		internal static CocChiuTai fIb3XSTP8M1mi48fpFZr()
		{
			return null;
		}
	}

	public class InfoText
	{
		public object txtObj;

		public string text;

		public diem position;

		private static InfoText Ey1EYnTPnJ6BM90s3v5C;

		static InfoText()
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
						IL_0048:
						switch (num3)
						{
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 5;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 == 0)
							{
								continue;
							}
							goto end_IL_0068;
						case 1:
							goto end_IL_0068;
						case 0:
							return;
						}
						while (true)
						{
							switch (num2)
							{
							case 9:
								goto IL_0024;
							default:
								return;
							case 990:
								break;
							}
							break;
							IL_0024:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_0295e339d21b49f5ae3dea1307c6082a == 0)
							{
								continue;
							}
							goto IL_0048;
						}
						break;
					}
					continue;
					end_IL_0068:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 9;
			}
		}

		internal static bool Gy3EAnTPR4OHqpVJVHfV()
		{
			return true;
		}

		internal static InfoText j9S2wfTPOGewIEqRcZUv()
		{
			return null;
		}
	}

	public class MongJsonDto
	{
		public string tenMong;

		public string txtLucDoc;

		public bool isCotGop;

		public diem mainVecto;

		public Foundation_Etabs.ThepBoTriMong duoiDoc;

		public Foundation_Etabs.ThepBoTriMong duoiNgang;

		public Foundation_Etabs.ThepBoTriMong trenDoc;

		public Foundation_Etabs.ThepBoTriMong trenNgang;

		public CocChiuTai cocChiuTai;

		public bool isVacMong;

		public string mauMong;

		internal static MongJsonDto stEbC1TPhePqZtWSWFWn;

		static MongJsonDto()
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
						default:
							if (num2 == 9)
							{
								goto IL_0019;
							}
							if (num2 == 990)
							{
								goto end_IL_002f;
							}
							goto case 2;
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							break;
						case 1:
							break;
						case 0:
							return;
						}
						goto end_IL_004f;
						IL_0019:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 1;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_00f0a279ec4b44848c113e5f3a57df39 == 0)
						{
							return;
						}
						continue;
						end_IL_002f:
						break;
					}
					continue;
					end_IL_004f:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 == 0)
				{
					num = 0;
				}
			}
		}

		internal static bool jvqT3RTPZpVUWjiHaeCA()
		{
			return true;
		}

		internal static MongJsonDto SnpMHCTPCWk5XfZBh0ht()
		{
			return null;
		}
	}

	public class MongBangJsonDto
	{
		public string btl;

		public string caoTrinhDayMong;

		public string HBatDayMong;

		public string HMong;

		public string Cover;

		private static MongBangJsonDto ShS41mTPBbL8K8hVJ6ad;

		static MongBangJsonDto()
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
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_e761100d2cf44e67808f34385eabece7 == 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0052;
								}
								goto case 2;
							}
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 == 0)
							{
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							return;
						}
						goto end_IL_0065;
						continue;
						end_IL_0052:
						break;
					}
					continue;
					end_IL_0065:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 7;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c16368ee47214a3ea92e8fd02e53deed == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool lxkX73TPDCAMXcfvrLU2()
		{
			return true;
		}

		internal static MongBangJsonDto FkiGNYTPFsXh188l5CmL()
		{
			return null;
		}
	}

	public class InfoCotCocGenMong
	{
		public bool isCotEmpty;

		public bool isCotGop;

		public diem mainVecto;

		public bool needAutoGen;

		public bool regenByNumCocEvent;

		public bool regenByRotateEvent;

		public bool regenByThayDoiLoaiCocEvent;

		public bool regenByHinhDangMongEvent;

		public PolygonModule.Polygon plCot;

		public diem centerGravity;

		public string txtLucDoc;

		public List<InfoText> listTxtLucDoc;

		public int soCoc;

		public CocChiuTai cocInput;

		public double chieuCaoMong;

		public bool isVacMong;

		public string mauMong;

		public int indexInDgv;

		public int id;

		public double angXoay;

		public List<PolygonModule.Polygon> tap_bien_trong;

		public List<PolygonModule.Polygon> listCotOthers;

		public object obj;

		public PolygonModule.Polygon plMong;

		public List<CocChiuTai> listCoc;

		public bool isDungTam;

		public string tenMong;

		public Foundation_Etabs.ThepBoTriMong duoiDoc;

		public Foundation_Etabs.ThepBoTriMong duoiNgang;

		public Foundation_Etabs.ThepBoTriMong trenDoc;

		public Foundation_Etabs.ThepBoTriMong trenNgang;

		private static InfoCotCocGenMong pbJTFrTPGHZFZc3emLVG;

		public object IsCoNhieuHon1LoaiCoc()
		{
			return null;
		}

		public InfoCotCocGenMong CloneForUndo()
		{
			return null;
		}

		public string GetJsonStringMong()
		{
			return null;
		}

		public InfoCotCocGenMong()
		{
		}

		public InfoCotCocGenMong(PolygonModule.Polygon pl, string luc, List<InfoText> listLucDoc)
		{
		}

		public void RegenCenter()
		{
		}

		public bool IsDifferent(InfoCotCocGenMong cot)
		{
			return true;
		}

		private Tuple<PolygonModule.Polygon, List<CocChiuTai>> Rm4Dad3TOGj(int int_0, diem diem_0, CocChiuTai cocChiuTai_0, string string_0)
		{
			return null;
		}

		private PolygonModule.Polygon fHuDagwHt2p(List<diem> list_0, double double_0)
		{
			return null;
		}

		private List<CocChiuTai> I3BDaMrtVmE(List<diem> list_0)
		{
			return null;
		}

		public List<string> GetListMauMongText(int numcoc)
		{
			return null;
		}

		private string E6sDa7OawWG(List<int> list_0)
		{
			return null;
		}

		private List<int> YqqDaEoxIFV(string string_0)
		{
			return null;
		}

		private Tuple<PolygonModule.Polygon, List<diem>> rMrDasByRcv(List<int> list_0, diem diem_0, diem diem_1, double double_0, double double_1, double double_2)
		{
			return null;
		}

		public List<Tuple<PolygonModule.Polygon, List<diem>>> ListPlMongCanAssign(int numcoc, string kcDenMepDai)
		{
			return null;
		}

		private List<List<int>> NZTDaJSFg5m(int int_0)
		{
			return null;
		}

		private int grqDaeaP4Dh(List<int> list_0)
		{
			return 0;
		}

		private List<int> HFSDaQE3wve(List<int> list_0)
		{
			return null;
		}

		private bool BICDaAMT0wi(List<int> list_0)
		{
			return true;
		}

		public bool IsCotNamNgoaiMong()
		{
			return true;
		}

		public List<diem> GetListDiemTatCaCot()
		{
			return null;
		}

		public List<diem> GetListDiemCotNamNgoaiMong()
		{
			return null;
		}

		public void AssignPlMong(int numCoc, diem mainVecto, PolygonModule.Polygon ranhBoTriDai, PolygonModule.Polygon ranhTamCoc, string kcDenMepDai)
		{
		}

		public void RaiDeuCoc(List<CocChiuTai> danhSachCocGoc, bool compactChoVuongVuc = false, bool isDoiCocDeCotNamTrong = true)
		{
		}

		private Tuple<int, int> yHoDaHAGVds(HashSet<Tuple<int, int>> hashSet_0, HashSet<Tuple<int, int>> hashSet_1, List<diem> list_0, double double_0, diem diem_0)
		{
			return null;
		}

		public void XoaCacCocLeLoiNhat(int soLuongXoa)
		{
		}

		public void ThemCacCocThichHop(int soLuongThem)
		{
		}

		private Tuple<int, int> vtyDaLI7S7W(Tuple<int, int> tuple_0, HashSet<Tuple<int, int>> hashSet_0)
		{
			return null;
		}

		private int RY0Da20NN7U(Tuple<int, int> tuple_0, HashSet<Tuple<int, int>> hashSet_0, Tuple<int, int> tuple_1 = null)
		{
			return 0;
		}

		private List<CocChiuTai> FK8DaqWg8EL(HashSet<Tuple<int, int>> hashSet_0, diem diem_0, double double_0, CocChiuTai cocChiuTai_0, diem diem_1)
		{
			return null;
		}

		public void RegenPlMongByConcaveListCoc(double kcDenMepDai, List<diem> listPAdd = null)
		{
		}

		public void RegenPlMongByOuterListCoc(double kcDenMepDai, List<diem> listPAdd = null)
		{
		}

		public void Translate(diem v)
		{
		}

		public void Rotate(double angle)
		{
		}

		public diem AlignToRanh(PolygonModule.Polygon ranhBoTriDai, PolygonModule.Polygon ranhTamCoc)
		{
			return null;
		}

		static InfoCotCocGenMong()
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
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b != 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0055;
								}
							}
							else
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 7;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3da03e4d215640aab6fa9268d1200d6d != 0)
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
						goto end_IL_0068;
						continue;
						end_IL_0055:
						break;
					}
					continue;
					end_IL_0068:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_705374da7b0748cf8df80d00725571db != 0)
				{
					num = 5;
				}
			}
		}

		internal static bool k9hpVLTPTYCFJidhXZSm()
		{
			return true;
		}

		internal static InfoCotCocGenMong niThcmTPxKmURof7yIvV()
		{
			return null;
		}
	}

	public class InfoMBMongDon
	{
		public diem pointGoc;

		public List<CotChiuTaiMongDon> listCotChiuTai;

		public PolygonModule.Polygon ranhBoTriDai;

		public string TienTo;

		public int SoBatDau;

		public ViTriDatTen viTriDatTen;

		public InfoAreaSpring areaSpring;

		public List<PolygonModule.Polygon> listPlTEST;

		internal static InfoMBMongDon A6PqXdTPostYY34psLS8;

		public void TinhToanMatBangMong(bool firstTime = false, string traiTxt = "", string phaiTxt = "", string trenTxt = "", string duoiTxt = "")
		{
		}

		public PolygonModule.Polygon GetBBMax()
		{
			return null;
		}

		public void GanTenMong()
		{
		}

		static InfoMBMongDon()
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
						default:
							if (num2 == 9)
							{
								goto IL_0019;
							}
							if (num2 == 990)
							{
								goto end_IL_002f;
							}
							goto case 2;
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							break;
						case 1:
							break;
						case 0:
							return;
						}
						goto end_IL_004f;
						IL_0019:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 6;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_6639d8e551bd44619b5ef505e18c8532 != 0)
						{
							return;
						}
						continue;
						end_IL_002f:
						break;
					}
					continue;
					end_IL_004f:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c57d245498d44fafb6366861203ffcfd == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool OXdrE6TP6wxTMKaMtYVW()
		{
			return true;
		}

		internal static InfoMBMongDon oTRkZYTPuQ3xXXxapych()
		{
			return null;
		}
	}

	public class CotChiuTaiMongDon
	{
		public PolygonModule.Polygon plMong;

		public object blkObj;

		public PolygonModule.Polygon plCot;

		public diem centerGravity;

		public diem xVec;

		public diem yVec;

		public double lX;

		public double lY;

		public string txtLucDoc;

		public int index;

		public string Trai;

		public string Phai;

		public string Tren;

		public string Duoi;

		public string btl;

		public string caoTrinhDayMong;

		public string HBatDayMong;

		public string HMong;

		public string KcCoMongDinhCot;

		public string Cover;

		public string ThepPhuongX;

		public string ThepPhuongY;

		public Rai_Mong_Module.InfoRaiMongDon infoMong;

		private static CotChiuTaiMongDon VM1KrfTPapfxMjH775K5;

		public CotChiuTaiMongDon()
		{
		}

		public CotChiuTaiMongDon(PolygonModule.Polygon pl, string luc)
		{
		}

		public void RegenInfoMong()
		{
		}

		public string GetDoDaiCanhMongTxt()
		{
			return null;
		}

		public bool IsDifferent(CotChiuTaiMongDon cot)
		{
			return true;
		}

		static CotChiuTaiMongDon()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 1;
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_503f8440945048439eaf3928584c889a != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 == 9)
							{
								return;
							}
							goto end_IL_0022;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							break;
						case 2:
							break;
						}
						goto end_IL_004e;
						continue;
						end_IL_0022:
						break;
					}
					continue;
					end_IL_004e:
					break;
				}
				while (num2 == 990);
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 == 0)
				{
					num = 0;
				}
			}
		}

		internal static bool qVOeYvTPyGB5Q38QtEPQ()
		{
			return true;
		}

		internal static CotChiuTaiMongDon LFvy5iTPIJPDw3TMtRIR()
		{
			return null;
		}
	}

	public enum KieuTaoDaiMongBaoCoc
	{
		GiuNguyenBaoMong,
		TaoBaoMongBaoNgoai,
		TaoBaoMongVac
	}

	public class Form_Update_Dai_Mong_Bao_Coc : Form
	{
		private readonly TextBox n3xDat5QDFV;

		private readonly TextBox xd0DazNqnjy;

		private readonly TextBox M7BDyw3dyWo;

		private readonly ComboBox NimDy846ij0;

		private readonly Button Cj9DynrNAwv;

		private readonly Button i8DDyRyDo0g;

		private readonly List<KieuTaoDaiMongBaoCoc> sWVDyOe4hUv;

		internal static Form_Update_Dai_Mong_Bao_Coc rCdFZPTPbKwqcNvZxQ4v;

		public string TenMong => null;

		public string HMongText => null;

		public string KcDenMepDaiText => null;

		public KieuTaoDaiMongBaoCoc KieuTao => (KieuTaoDaiMongBaoCoc)(object)null;

		public Form_Update_Dai_Mong_Bao_Coc(string defaultTenMong, string defaultHMong, string defaultKcDenMepDai, bool choPhepGiuNguyenBaoMong)
		{
		}

		private void asMDa4JdT9h(string string_0, KieuTaoDaiMongBaoCoc kieuTaoDaiMongBaoCoc_0)
		{
		}

		private void vW9DaUWPgcy(object sender, EventArgs e)
		{
		}

		static Form_Update_Dai_Mong_Bao_Coc()
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
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_25e2f9f2e00c4736bd789b594bd2faa3 == 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0051;
								}
								goto case 2;
							}
							return;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 7;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_fda9dec917b14c45931e0d4eb71de6b8 != 0)
							{
								continue;
							}
							break;
						case 0:
							break;
						}
						goto end_IL_0064;
						continue;
						end_IL_0051:
						break;
					}
					continue;
					end_IL_0064:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988 == 0)
				{
					num = 8;
				}
			}
		}

		internal static bool URr9oNTPVJnWWVDUcLwl()
		{
			return true;
		}

		internal static Form_Update_Dai_Mong_Bao_Coc VMJLglTPk5BmVMnjwD1s()
		{
			return null;
		}
	}

	public static Form_Ve_Mat_Bang_Mong formVeMatBangMong;

	public static InfoVeMatBangMong info_ve_mat_bang_mong;

	public static InfoMBMongBang info_mb_mong_bang;

	public static InfoMBMongDon info_mb_mong_don;

	public static string LOAIDATACOC;

	public static string LOAIDATAJOINTREACTION;

	public static string LOAIDATAMBMONGCOC;

	public static string LOAIDATAMBMONGBANG;

	public static string LOAIDATALINECHEO;

	internal static Ve_Mat_Bang_Mong_Module VcdILLT8uU84cc79bWPb;

	static Ve_Mat_Bang_Mong_Module()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
		int num = 11;
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
					case 11:
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						goto case 10;
					case 10:
						b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
						num3 = 0;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_b164162b8046492994d14f0299ed7153 != 0)
						{
							continue;
						}
						goto default;
					case 6:
						info_mb_mong_bang = new InfoMBMongBang();
						num3 = 3;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_d2365fb7fd684b7e8d483432972c9023 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0162;
							}
							goto case 6;
						}
						LOAIDATAMBMONGCOC = "DataMBMongCoc";
						num3 = 5;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_bee00e7049644e96b9f0679762a49ac6 != 0)
						{
							continue;
						}
						goto case 3;
					case 3:
						info_mb_mong_don = new InfoMBMongDon();
						goto case 4;
					case 4:
						LOAIDATACOC = "DataCoc";
						num3 = 7;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_559789cacd7f46ac973fb693ed94037f != 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						LOAIDATALINECHEO = "DataLineCheo";
						num3 = 5;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2c174d0d9ac34a6c933e3a665cf63f30 != 0)
						{
							continue;
						}
						return;
					case 9:
						formVeMatBangMong = new Form_Ve_Mat_Bang_Mong();
						goto case 2;
					case 2:
						info_ve_mat_bang_mong = new InfoVeMatBangMong();
						goto case 6;
					case 5:
						LOAIDATAMBMONGBANG = "DataMBMongBang";
						num3 = 17;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 != 0)
						{
							continue;
						}
						goto case 1;
					case 0:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 12;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 != 0)
						{
							continue;
						}
						goto case 5;
					case 7:
						LOAIDATAJOINTREACTION = "DataJointReaction";
						num = 7;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_bee00e7049644e96b9f0679762a49ac6 != 0)
						{
							num = 19;
						}
						break;
					case 12:
						iUemXbDkFh2Nnno2jJtT.f8oTg3pM5fk();
						num = 9;
						break;
					case 8:
						return;
					}
					goto end_IL_01a0;
					continue;
					end_IL_0162:
					break;
				}
				continue;
				end_IL_01a0:
				break;
			}
		}
	}

	private static diem bdaBBTWSF40(object object_0)
	{
		return null;
	}

	private static PolygonModule.Polygon YiBBBxghFt4(object object_0)
	{
		return null;
	}

	private static InfoText Pw4BBoBKbjq(object object_0)
	{
		return null;
	}

	private static Foundation_Etabs.ThepBoTriMong xQYBB60GbLO(object object_0)
	{
		return null;
	}

	public static ViTriDatTen GetViTriDatTen(int index)
	{
		return (ViTriDatTen)(object)null;
	}

	public static List<CocChiuTai> Edit_Coc()
	{
		return null;
	}

	private static Polyline gSCBBugpm1S(object object_0)
	{
		return null;
	}

	private static double j2TBBa8SRSQ(object object_0)
	{
		return 0.0;
	}

	private static string pXBBBy9OuCN(object object_0)
	{
		return null;
	}

	public static ObjectId EnsureBlockMongCoc(InfoCotCocGenMong cot, ref diem insertPoint, ref double rotation)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (ObjectId)(object)null;
	}

	public static object InsertBlockMongCoc(ObjectId blockId, diem insertPoint, double rotation, string layer = null, int color = -1)
	{
		return null;
	}

	public static void PhaMong()
	{
	}

	public static List<object> PhaBlockMong(object blockMong, bool eraseBlockGoc = true)
	{
		return null;
	}

	public static bool UpdateDaiMongBaoCoc(object sset)
	{
		return true;
	}

	public static void VMBM()
	{
	}

	internal static bool aNg6fmT8agDAfWh6LHMv()
	{
		return true;
	}

	internal static Ve_Mat_Bang_Mong_Module G4SGD2T8yaVIC52PPaWK()
	{
		return null;
	}
}
