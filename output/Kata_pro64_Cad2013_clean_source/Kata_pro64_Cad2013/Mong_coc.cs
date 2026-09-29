using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using FvPr3dDkGF8J09q6AAZX;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using dD5nY5BwVplxlGX0cSca;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Mong_coc
{
	public class InfoMongCoc
	{
		public double daiRauCoc;

		public double beMocCauTao;

		public double mocDaiDung;

		public bool co_cot;

		public diem point_mc;

		public diem point_goc;

		public diem gocVeMBDuoi;

		public double d1;

		public double d2;

		public double d3;

		public double e1;

		public double e2;

		public double e3;

		public double l_am;

		public double l_duong;

		public double l;

		public double b_am;

		public double b_duong;

		public double b;

		public diem b_vecto;

		public diem l_vecto;

		public diem h_vecto;

		public InfoUserMongCoc dln;

		public Dlcot dl_cot;

		public List<Dlcot> list_dl_cot;

		public double h1;

		public double h2;

		public double h3;

		public double h4;

		public double hsanTrai;

		public double hsanPhai;

		public double cao_do;

		public List<diem> list_point_duoi_mong;

		public List<diem> list_point_duoi_cot;

		public List<List<diem>> ll_point_cot;

		public List<KataCircle3D> list_pcot_tron;

		public List<diem> list_point_duoi_betonglot;

		public List<diem> list_point_coc;

		public List<Infogrid> list_grid;

		public List<object> transformblk;

		public List<string> blockName;

		public string ten_ck;

		public double diameter;

		public double diameter_X;

		public double diameter_Y;

		public bool la_mong_bien_thien;

		public bool la_coc_chu_nhat;

		public List<diem> viewXRec;

		public List<diem> viewYRec;

		public int TLBV;

		internal static InfoMongCoc PPt71eTcFrOYxtOi5j6Y;

		public int GetCotPhuIndex(List<diem> lp)
		{
			return 0;
		}

		public int GetCotTronIndex(KataCircle3D c)
		{
			return 0;
		}

		public int GetSoThanhThepCot(Dlcot dlcot)
		{
			return 0;
		}

		static InfoMongCoc()
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
							break;
						default:
							goto IL_0024;
						case 0:
							goto end_IL_004f;
						case 2:
							return;
						}
						goto IL_000c;
						IL_0024:
						switch (num2)
						{
						default:
							goto IL_000c;
						case 990:
							break;
						case 9:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							return;
						}
						break;
						IL_000c:
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						num3 = 0;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_78acf557389e4c83804bda1025ad65ea == 0)
						{
							return;
						}
					}
					continue;
					end_IL_004f:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c80ea1ec51aa4cc0bdd285aeb9f11013 == 0)
				{
					num = 5;
				}
			}
		}

		internal static bool nOLaFJTcGKAPeVtZlQhi()
		{
			return true;
		}

		internal static InfoMongCoc QZPPO4TcTxHmqHKVZru9()
		{
			return null;
		}
	}

	public class KataCircle
	{
		public Point2d tam;

		public double radius;

		internal static KataCircle CfxbbfTcxlZUuuio0ELL;

		public KataCircle()
		{
		}

		public KataCircle(Point2d p, double rad)
		{
		}

		static KataCircle()
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
							num3 = 1;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c660b2a9f2294e84996cb208a4355bde != 0)
							{
								continue;
							}
							return;
						case 1:
							goto end_IL_0066;
						case 0:
							return;
							IL_003b:
							while (num2 == 9)
							{
								bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
								num3 = 0;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 == 0)
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

		internal static bool PeiUG2TcoxHgykWEMfsk()
		{
			return true;
		}

		internal static KataCircle f5codVTc66SYRsOHHUjl()
		{
			return null;
		}
	}

	public class KataCircle3D
	{
		public diem center;

		public double diameter;

		private static KataCircle3D IDPZ0eTcuPemRqMyhD44;

		public KataCircle3D()
		{
		}

		public KataCircle3D(diem p, double dia)
		{
		}

		static KataCircle3D()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_0067:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_cf58fd231e5d4ef089c24814da16672b == 0)
							{
								continue;
							}
							goto case 1;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num = 9;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 != 0)
							{
								num = 0;
							}
							goto end_IL_0047;
						case 0:
							return;
						}
						switch (num2)
						{
						case 9:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 9;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 == 0)
							{
								continue;
							}
							return;
						default:
							return;
						case 990:
							break;
						}
						goto IL_0067;
						continue;
						end_IL_0047:
						break;
					}
					break;
				}
			}
		}

		internal static bool Qv9ynVTca7vIxlXPfMRl()
		{
			return true;
		}

		internal static KataCircle3D ab0KKvTcyvmR9uTOU7ju()
		{
			return null;
		}
	}

	public class LopThepThem
	{
		public double fngang;

		public double spacing_ngang;

		public double fdoc;

		public double spacing_doc;

		public double dbm_tren;

		public double dbm_duoi;

		public double dbm_trai;

		public double dbm_phai;

		internal static LopThepThem Ppi37kTcIkZtbFcJWUIg;

		static LopThepThem()
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
						default:
							if (num2 == 9)
							{
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								num3 = 2;
								if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_1a1ae42c9fb647b2ac3ccb55018de5e5 == 0)
								{
									continue;
								}
							}
							else if (num2 == 990)
							{
								goto end_IL_002f;
							}
							goto case 0;
						case 1:
							break;
						case 0:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							return;
						case 2:
							return;
						}
						goto end_IL_004f;
						continue;
						end_IL_002f:
						break;
					}
					continue;
					end_IL_004f:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 6;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool S9pAjjTcNbnCaqLAumEx()
		{
			return true;
		}

		internal static LopThepThem x4esXTTciH4yZBbkSPjP()
		{
			return null;
		}
	}

	public class InfoUserMongCoc
	{
		public double ftd;

		public double ftn;

		public double fdd;

		public double fdn;

		public double fdai;

		public double fdo;

		public double fct;

		public string dangct;

		public double spacing_td;

		public double spacing_tn;

		public double spacing_dd;

		public double spacing_dn;

		public double spacing_dai;

		public double spacing_do;

		public double spacing_ct;

		public double ndai;

		public double dbm_td_trai;

		public double dbm_td_phai;

		public double dbm_tn_tren;

		public double dbm_tn_duoi;

		public double dbm_dd_trai;

		public double dbm_dd_phai;

		public double neoSanThepDuoi;

		public double dbm_dn_tren;

		public double dbm_dn_duoi;

		public double dbm_dai;

		public CoversMong covers;

		public bool co_thep_tren;

		public bool co_thep_cau_tao;

		public bool co_thep_dai;

		public bool co_thep_do;

		public bool co_thep_cot;

		public List<LopThepThem> list_thep_ngang;

		public List<LopThepThem> list_thep_duoi;

		public List<LopThepThem> list_thep_tren;

		public double thepCho1;

		public double thepCho2;

		public double hCho3;

		public int nPhuongLThepDo;

		public int nPhuongBThepDo;

		public bool isDoiViTriThepTren;

		public bool isDoiViTriThepDuoi;

		internal static InfoUserMongCoc UWeje5Tc9bjdLrJ73OWU;

		static InfoUserMongCoc()
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
							goto IL_000c;
						default:
							switch (num2)
							{
							case 9:
								b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
								goto IL_000c;
							default:
								return;
							case 990:
								break;
							}
							goto end_IL_0038;
						case 1:
							break;
						case 0:
							return;
							IL_000c:
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 4;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_fda9dec917b14c45931e0d4eb71de6b8 != 0)
							{
								continue;
							}
							return;
						}
						goto end_IL_0058;
						continue;
						end_IL_0038:
						break;
					}
					continue;
					end_IL_0058:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_9b8a3fa59b0643a9a005e0e055caa087 == 0)
				{
					num = 3;
				}
			}
		}

		internal static bool rfthx0TcbKHmCjNGXpoU()
		{
			return true;
		}

		internal static InfoUserMongCoc LcrlWVTcVRgnJMQu1PVj()
		{
			return null;
		}
	}

	public class CoversMong
	{
		public double cover_tren;

		public double cover_duoi;

		public double cover_ngang;

		internal static CoversMong cbqMq7Tck367qjUSaWhp;

		static CoversMong()
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
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_f09347d075a54e3c9e3affc36c5644b5 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								goto end_IL_0037;
							}
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							goto case 2;
						case 1:
							break;
						case 0:
							return;
						}
						goto end_IL_0057;
						continue;
						end_IL_0037:
						break;
					}
					if (num2 != 990)
					{
						return;
					}
					continue;
					end_IL_0057:
					break;
				}
				b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_068fed8884eb4f759ebb34fd2b6f962b == 0)
				{
					num = 6;
				}
			}
		}

		internal static bool yl1HPwTc3HGRRSqE1vQi()
		{
			return true;
		}

		internal static CoversMong R0GNZhTc56HBqTsSM8QA()
		{
			return null;
		}
	}

	public class Infogrid
	{
		public mat_phang_diem mp;

		public string nameGrid;

		public int index;

		internal static Infogrid x99b93TccfyIaqJgIeXw;

		static Infogrid()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
			int num = 2;
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
						case 2:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_7b47a3ce476644de941f3c07d3c7ccdb == 0)
							{
								continue;
							}
							goto case 1;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 == 9)
							{
								return;
							}
							goto end_IL_0039;
						case 0:
							break;
						}
						goto end_IL_0065;
						continue;
						end_IL_0039:
						break;
					}
					continue;
					end_IL_0065:
					break;
				}
				while (num2 == 990);
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool M0532xTcpJItfTEYoqqb()
		{
			return true;
		}

		internal static Infogrid Wt6PQNTcjUCO8J8Ixqn1()
		{
			return null;
		}
	}

	public class Dlcot
	{
		public double duong_kinh;

		public int x_thanh;

		public int y_thanh;

		public double f_dai;

		public double spacing_dai;

		public int n_dai;

		public double cover_dai;

		public int soThanhCotTron;

		public bool khoaDauCot;

		public double leg;

		public double topleg;

		public string daiCX;

		public string daiCY;

		public string daivuongX;

		public string daivuongY;

		public bool isCotTron;

		public int daiCTron;

		public string daiCotText;

		public double dkDaiGC;

		internal static Dlcot WVJZ9PTcYKFSMM4xEVYN;

		static Dlcot()
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
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_6ce9290b5e1746939442406839df2a66 == 0)
							{
								continue;
							}
							goto default;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 != 0)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 990:
								goto end_IL_003a;
							case 9:
								return;
							}
							goto end_IL_0069;
						case 0:
							goto end_IL_0069;
							end_IL_003a:
							break;
						}
						break;
					}
					continue;
					end_IL_0069:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
			}
		}

		internal static bool dlptVlTcP8l1fG6AXBFY()
		{
			return true;
		}

		internal static Dlcot uyo1NnTc1FTVja4S5uGN()
		{
			return null;
		}
	}

	public class InfoMongCocSave
	{
		public string daiRauCoc;

		public string mocDaiDung;

		public string beMocCauTao;

		public string Cover_cot;

		public string dai_cot;

		public string phi_cot;

		public string tb_cover_duoi;

		public string tb_dbm_thep_ngang_duoi_duoi;

		public string tb_dbm_thep_doc_duoi_trai;

		public string tb_dbm_thep_ngang_duoi_tren;

		public string tb_dbm_thep_doc_duoi_phai;

		public string tb_ten_ck;

		public string Thep_cot_Y;

		public string Thep_cot_X;

		public string sl;

		public string tb_thep_doc_tren;

		public string tb_thep_ngang_tren;

		public string tb_h1;

		public string tb_e1;

		public string tb_h2;

		public string tb_h3;

		public string tb_d3;

		public string tb_e3;

		public string tb_d1;

		public string Ct;

		public string tb_thep_do;

		public bool cb_co_thep_do;

		public bool cb_co_thep_dai;

		public bool cb_co_thep_cau_tao;

		public string tb_dbm_thep_dai;

		public string tb_thep_dai;

		public string tb_dbm_thep_ngang_tren_duoi;

		public string tb_dbm_thep_doc_tren_trai;

		public string tb_dbm_thep_ngang_tren_tren;

		public string tb_dbm_thep_doc_tren_phai;

		public string tb_thep_doc_duoi;

		public string tb_thep_ngang_duoi;

		public string tb_cover_ngang;

		public string tb_cover_tren;

		public bool RadioButton1;

		public bool CheckThepCot;

		public bool RadioButton2;

		public bool cb_co_thep_tren;

		public string tb_day_san_trai;

		public string tb_day_san_phai;

		public string tbcautao;

		public bool notcbdang;

		public bool cbdang;

		public string tb_h4;

		public string Thep_cot_tron;

		public string ThepCho;

		public string hCho3;

		public string hCho1;

		public string hCho2;

		public List<LopThepThem> list_thep_ngang;

		public List<LopThepThem> list_thep_duoi;

		public List<LopThepThem> list_thep_tren;

		public List<Dlcot> list_dl_cot;

		public bool khoaDauCot;

		public string TLBV;

		public bool DoiViTriThepTren;

		public bool DoiViTriThepDuoi;

		internal static InfoMongCocSave DeN7vxTc0d33b0TLU9jX;

		static InfoMongCocSave()
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
							num3 = 8;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_6ce9290b5e1746939442406839df2a66 != 0)
							{
								continue;
							}
							goto case 1;
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988 != 0)
							{
								continue;
							}
							break;
						case 0:
							goto end_IL_0065;
							IL_003a:
							if (num2 == 9)
							{
								return;
							}
							goto IL_0045;
							IL_0045:
							if (num2 == 990)
							{
								goto end_IL_0052;
							}
							goto case 1;
						}
						goto IL_003a;
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
			}
		}

		internal static bool nC2k3xTcmMWF7isZm8YS()
		{
			return true;
		}

		internal static InfoMongCocSave cjo2cXTcKU6ILnR7FneT()
		{
			return null;
		}
	}

	public static InfoMongCoc info_mong_coc;

	public static Form_mong_coc formMongCoc;

	public static Form_Lop_Thep_Them formThepThemDuoi;

	public static Form_Lop_Thep_Them_Ngang formThepThemNgang;

	public static Form_Lop_Thep_Them_Tren formThepThemTren;

	public static List<List<double>> listlistL;

	public static string Ltext;

	public static double hThepCho;

	public static double spacing;

	public static double length;

	public static int so_thanh;

	public static double kc2ben;

	public static string LOAIDATAMONGCOC;

	public static bool phuongB;

	public static diem VectoTheoPhuong;

	public static double tlForm;

	public static Point goc_duoi;

	public static Point goc_tren;

	public static List<diem> listLocation;

	private static double[] rklBh1IBEwP;

	private static diem b1vBh0XWqF1;

	private static info_thep[] XmKBhmyRul2;

	private static diem MTPBhKmuLJL;

	private static diem VbvBhf3N7cq;

	private static diem sUNBhW7rMqB;

	private static diem WQ8BhvuhbJD;

	private static diem KN3Bhr6596x;

	private static diem vHmBhlTZhBy;

	private static diem NBuBhXYDIi5;

	private static diem l15BhS5FwOR;

	private static double MtpBhdslrfb;

	private static double zhUBhg6lH1i;

	private static double wX4BhMDDpib;

	private static double tpuBh7SHoBL;

	private static List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu> KFGBhEcrIOf;

	private static List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu> x9gBhs7nJik;

	private static List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu> mfWBhJCNCi5;

	private static List<List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu>> bKlBhex2gWv;

	private static List<object> p8bBhQb31Yy;

	private static double SGOBhAjcf5l;

	private static diem y99BhHJ2lq9;

	private static List<List<diem>> sIyBhLIJd7d;

	private static List<diem> fVeBh2L6sqD;

	private static List<diem> COaBhqikimn;

	private static int QecBh4FVLem;

	internal static Mong_coc gQ68BITwinu8Jxa1HXD6;

	public static List<diem> list_point_coc_in_view_autocad => null;

	// C# has no syntax for parameterized property 'list_point_nam_trong_cach_1_khoang_d'.
	public static List<diem> get_list_point_nam_trong_cach_1_khoang_d(List<diem> list_diem, double d)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'list_point_nam_ngoai_cach_1_khoang_d'.
	public static List<diem> get_list_point_nam_ngoai_cach_1_khoang_d(List<diem> list_diem, double d)
	{
		return null;
	}

	static Mong_coc()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
		int num = 21;
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
					case 32:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 31;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3d856b94665044e6b2ba303819a86373 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						LOAIDATAMONGCOC = "DataMongCoc";
						num3 = 34;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_a8ebfeac173c4dddb6af45ca0c75e3a2 != 0)
						{
							continue;
						}
						goto case 22;
					case 31:
						iUemXbDkFh2Nnno2jJtT.f8oTg3pM5fk();
						goto case 26;
					case 26:
						info_mong_coc = new InfoMongCoc();
						goto case 29;
					case 29:
						formMongCoc = new Form_mong_coc();
						num3 = 7;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_731c31f89ee84065b40adfdeb4e0e77c == 0)
						{
							continue;
						}
						goto case 5;
					case 5:
						formThepThemDuoi = new Form_Lop_Thep_Them();
						num3 = 0;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3e20b8f0eaaf4c2c858e7c7ca7131a33 != 0)
						{
							continue;
						}
						goto case 21;
					case 21:
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						goto case 20;
					case 20:
						b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
						goto case 32;
					case 28:
						listlistL = new List<List<double>>();
						num3 = 18;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 == 0)
						{
							continue;
						}
						goto case 1;
					case 27:
						NBuBhXYDIi5 = new diem();
						num3 = 13;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 != 0)
						{
							continue;
						}
						goto case 24;
					case 25:
						VbvBhf3N7cq = new diem();
						num3 = 9;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 == 0)
						{
							continue;
						}
						goto case 8;
					case 17:
						XmKBhmyRul2 = new info_thep[1];
						goto case 7;
					case 7:
						MTPBhKmuLJL = new diem();
						goto case 25;
					case 15:
						x9gBhs7nJik = new List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu>();
						num3 = 6;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 39)
						{
							if (num2 == 1020)
							{
								goto end_IL_0231;
							}
							goto case 31;
						}
						WQ8BhvuhbJD = new diem();
						num3 = 10;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_8914b8dde10043a5a310f94275ef0637 == 0)
						{
							continue;
						}
						goto case 19;
					case 14:
						formThepThemTren = new Form_Lop_Thep_Them_Tren();
						goto case 28;
					case 11:
						vHmBhlTZhBy = new diem();
						goto case 27;
					case 10:
						KN3Bhr6596x = new diem();
						num3 = 23;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 == 0)
						{
							continue;
						}
						goto case 11;
					case 6:
						mfWBhJCNCi5 = new List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu>();
						num3 = 14;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_a8ebfeac173c4dddb6af45ca0c75e3a2 != 0)
						{
							continue;
						}
						goto case 12;
					case 4:
						do
						{
							fVeBh2L6sqD = new List<diem>();
							num3 = 9;
						}
						while (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_fa885cb658d447638297a1e47340b8c6 == 0);
						continue;
					case 3:
						KFGBhEcrIOf = new List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu>();
						goto case 15;
					case 2:
						b1vBh0XWqF1 = new diem();
						goto case 17;
					case 0:
						formThepThemNgang = new Form_Lop_Thep_Them_Ngang();
						num = 14;
						break;
					case 12:
						bKlBhex2gWv = new List<List<M2liOIBwbB0E9BLyuoVi.tA5unqDDp6a2EpngNsuu>>();
						goto case 19;
					case 13:
						l15BhS5FwOR = new diem();
						num = 3;
						break;
					case 19:
						p8bBhQb31Yy = new List<object>();
						num = 30;
						break;
					case 8:
						sUNBhW7rMqB = new diem();
						num = 32;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_a771e08388354bdfb62e531f5992b6e4 == 0)
						{
							num = 39;
						}
						break;
					case 30:
						y99BhHJ2lq9 = new diem();
						goto case 24;
					case 24:
						sIyBhLIJd7d = new List<List<diem>>();
						num = 4;
						break;
					case 22:
						phuongB = false;
						goto case 23;
					case 23:
						listLocation = new List<diem>();
						goto case 18;
					case 18:
						rklBh1IBEwP = new double[3];
						num = 2;
						break;
					case 9:
						COaBhqikimn = new List<diem>();
						return;
					case 16:
						return;
					}
					goto end_IL_02bf;
					continue;
					end_IL_0231:
					break;
				}
				continue;
				end_IL_02bf:
				break;
			}
		}
	}

	public static string getInfoMongCocSaveJsonData()
	{
		return null;
	}

	public static string getInfoMongCocSaveJsonData2()
	{
		return null;
	}

	public static void Ve_ca_mong_coc()
	{
	}

	public static string block_TD_without_tl(ref diem goc1, ref string ten, ref int tl, string loai = "")
	{
		return null;
	}

	public static void Ve_bao_MC1()
	{
	}

	public static void get_length_spacing_so_thanh_kc2ben(double _length, double _spacing)
	{
	}

	public static void getListListL(List<double> listL)
	{
	}

	public static void getLText(List<double> listx, int lPointsCount, double dbmtrai, double dbmphai)
	{
	}

	public static void Ve_thep_them_duoi_doc()
	{
	}

	public static void Ve_thep_them_tren_doc()
	{
	}

	public static void TinhToanThepDocMongCoc(ref diem pdau, diem listpdim0, PolygonModule.Polygon plDuongBaoTrong, ref List<double> listL, bool test = false)
	{
	}

	public static void TinhToanThepNgangMongCoc(ref diem pdau, diem listpdim0, PolygonModule.Polygon plDuongBaoTrong, ref List<double> listL, bool test = false)
	{
	}

	public static void ve_cot_mong_coc(diem p_goc, diem diem1)
	{
	}

	public static void get_L_a_n_ThepDuoiRaiTheHien(double _space, [Optional][DefaultParameterValue(null)] ref diem point_2)
	{
	}

	public static void get_L_a_n_ThepTrenRaiTheHien(double _space, [Optional][DefaultParameterValue(null)] ref diem point_2)
	{
	}

	public static void thay_doi_thu_tu_diem(ref List<diem> listptrong, int index)
	{
	}

	public static diem timPGocGiua(diem pgoc)
	{
		return null;
	}

	public static bool kiemTraDoiXungTheoPhuongb(diem pGocGiua)
	{
		return true;
	}

	public static bool kiemTraDoiXungTheoPhuongl(diem pGocGiua)
	{
		return true;
	}

	private static List<diem> aPqBhPkIFQZ(object object_0, List<diem> list_0, object object_1)
	{
		return null;
	}

	public static List<diem> dimthepdn(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	public static List<diem> dimtheptn(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	public static List<diem> dimthepngangB(double spacing_ngang, List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	public static List<diem> dimthepdd(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	public static List<diem> dimtheptd(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	public static List<diem> dimthepngang(double spacing_doc, List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	public static List<diem> layTapPointsDNMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointsDNMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointsTNMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointsNgangMBB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	public static List<diem> layTapPointsTNMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointsNgangMB2B(double tren, double duoi, List<diem> duongbaotrong, diem pcat, ref diem ptag)
	{
		return null;
	}

	public static List<diem> layTapPointsDDMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointsDDMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointsTDMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	public static List<diem> LayTapPointsNgangMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	public static List<diem> LayTapPointsTDMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	public static List<diem> LayTapPointsNgangMB2(double trai, double phai, List<diem> duongbaotrong, diem pcat, ref diem ptag)
	{
		return null;
	}

	public static double Getl2pointcatmp(diem p, List<diem> listp, diem normal, diem phuong)
	{
		return 0.0;
	}

	public static void TimBvaL(ref double b, ref double l, ref diem PGiua, List<diem> listPCot)
	{
	}

	public static void timBvaLMC(ref double b, ref double l, ref diem PGiua, List<diem> listPCot)
	{
	}

	public static void lay_tap_point_thep_thep_cot_traiMC(Dlcot dl_cot, ref List<diem> list_point, double b, double l, diem PGiua, ref double length, ref diem p2inthepcot)
	{
	}

	public static void lay_tap_point_thep_thep_cot_phaiMC(Dlcot dl_cot, ref List<diem> list_point, double b, double l, diem PGiua)
	{
	}

	public static List<diem> lay_tap_point_thep_ngang()
	{
		return null;
	}

	public static List<List<diem>> LayLLPointDo(ref int so_thanh_dob, ref int so_thanh_dol)
	{
		return null;
	}

	public static List<diem> LayListPointRaiThepDo()
	{
		return null;
	}

	public static List<diem> layTapPointTDMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmtrai = -1.0, double dbmphai = -1.0, double z = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointTNMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmduoi = -1.0, double dbmtren = -1.0, double z = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointDNMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmduoi = -1.0, double dbmtren = -1.0, double z = -1.0)
	{
		return null;
	}

	public static List<diem> layTapPointDDMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmtrai = -1.0, double dbmphai = -1.0, double z = -1.0)
	{
		return null;
	}

	public static void them_moc(ref List<diem> list_point, diem xvecto, diem yvecto, bool nguoc1 = true, bool nguoc2 = true)
	{
	}

	public static diem layDiemThepTraiThepDai()
	{
		return null;
	}

	public static diem layDiemThepPhaiThepDai()
	{
		return null;
	}

	public static List<Line_diem> layTapCurveDo()
	{
		return null;
	}

	public static List<Line_diem> layTapCurveT()
	{
		return null;
	}

	public static List<diem> layTapPointCTTrai()
	{
		return null;
	}

	public static List<diem> layTapPointCTPhai([Optional][DefaultParameterValue(null)] ref diem d1)
	{
		return null;
	}

	public static List<Line_diem> layTapCurveCTTrai()
	{
		return null;
	}

	public static List<Line_diem> layTapCurveCTPhai()
	{
		return null;
	}

	public static List<Line_diem> layTapCurveNgang()
	{
		return null;
	}

	public static List<Line_diem> layTapCurveD()
	{
		return null;
	}

	public static diem timPGoc(List<diem> listPMatBang)
	{
		return null;
	}

	public static void tao_dim_tu_tap_diem_phuongY(List<diem> listdiem, diem diem0, diem goc, diem xvecto, diem yvecto, diem location)
	{
	}

	public static void tao_dim_tu_tap_diem_phuongX(List<diem> listdiem, diem diem0, diem goc, diem xvecto, diem yvecto, diem location)
	{
	}

	public static bool kiemTrapoint_coc_trong_hcn_autocad(diem p, List<diem> hcn, diem normalhcn)
	{
		return true;
	}

	public static List<diem> lay_list_point_cot(List<List<diem>> llistP3d)
	{
		return null;
	}

	public static List<diem> lay_list_point_mong(List<List<diem>> llistP3d)
	{
		return null;
	}

	public static void chuyenDuLieuFormSangMongCoc()
	{
	}

	public static void rai_line_thep_va_return_thep(ref object thepp, ref diem goc1, ref int phi, double a, double L, double ang)
	{
	}

	public static List<diem> lay_tap_points_thep_dai_phai_mong_coc()
	{
		return null;
	}

	public static List<diem> lay_tap_points_thep_dai_trai_mong_coc()
	{
		return null;
	}

	public static void ve_giao_thep_dim_update(ref object runlen)
	{
	}

	public static List<Line_diem> GetListCurvesMatCat()
	{
		return null;
	}

	public static Line_diem GetCurveBreakLineTrai()
	{
		return null;
	}

	public static Line_diem GetCurveBreakLinePhai()
	{
		return null;
	}

	public static List<List<Line_diem>> GetLLCurvesBTL()
	{
		return null;
	}

	public static List<Line_diem> GetListCurvesCoc()
	{
		return null;
	}

	public static List<Line_diem> GetListCurvesBLCoc()
	{
		return null;
	}

	public static void ve_thep_cot(PreviewCanvas sConMCoc)
	{
	}

	public static Tuple<bool, diem, diem> IsListPCotHopLe(List<diem> listpCot)
	{
		return null;
	}

	public static Tuple<List<Line_diem>, List<Line_diem>, diem> GetListCurveCot()
	{
		return null;
	}

	public static List<Line_diem> GetListBLCot()
	{
		return null;
	}

	public static void ve_mat_cat_coc(PreviewCanvas sConMCoc)
	{
	}

	public static void ve_coc_mong_coc(PreviewCanvas sConMCoc, List<diem> list_xyz, double phi, Point gocve, diem goc, diem xvecto, diem yvecto, double tl, Color color)
	{
	}

	public static void ve_hinh_tron(PreviewCanvas sCon, diem center, double dia, Point gocve, diem goc, diem xvecto, diem yvecto, double tl, Color color, bool visiblee = true, double width = -1.0)
	{
	}

	public static void VeMCMongForm(PreviewCanvas sConMCoc)
	{
	}

	public static void VeMBMongForm(PreviewCanvas sConMCoc)
	{
	}

	public static void Ve_mong_coc(List<BlockReference> listBlock, List<BlockReference> listBlockCot, List<Polyline> listPoly, List<Circle> listCircle, List<Line> listLine, List<Line> listLineKhuat)
	{
	}

	public static List<diem> getListPRaiThepDai([Optional][DefaultParameterValue(null)] ref List<diem> Ptags)
	{
		return null;
	}

	public static List<diem> getListPRaiThepDuoi()
	{
		return null;
	}

	public static List<diem> getListPRaiThepTren()
	{
		return null;
	}

	public static List<Line_diem> getListCThepDuoiNgangTheHienForm(LopThepThem thepThem, diem p_goc)
	{
		return null;
	}

	public static List<Line_diem> getListCThepTrenNgangTheHienForm(LopThepThem thepThem, diem p_goc)
	{
		return null;
	}

	public static List<diem> getListPRaiThepDuoi(LopThepThem thepThem)
	{
		return null;
	}

	public static List<diem> getListPRaiThepTren(LopThepThem thepThem)
	{
		return null;
	}

	public static List<diem> GetListPThepDuoi(LopThepThem thepThem)
	{
		return null;
	}

	public static List<diem> GetListPThepTren(LopThepThem thepThem)
	{
		return null;
	}

	public static List<diem> GetListPRaiThepNgang(LopThepThem thepThem)
	{
		return null;
	}

	public static List<diem> GetListPThepNgang(LopThepThem thepThem)
	{
		return null;
	}

	public static Tuple<List<diem>, List<Tuple<PolygonModule.CurveXYZ, double>>> getListPRaiCotTronUtil(Dlcot dl_cot, KataCircle3D c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	public static List<diem> getListPRaiCotTron(Dlcot dl_cot, KataCircle3D c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	public static List<Tuple<PolygonModule.CurveXYZ, double>> getListCurveCotTron(Dlcot dl_cot, KataCircle3D c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	public static Tuple<List<diem>, Tuple<PolygonModule.CurveXYZ, double>, Tuple<PolygonModule.CurveXYZ, double>> getListPRaiCotUtil(ref Dlcot dl_cot, List<diem> listpcot, int indexCurveX = 1, int indexCurveY = 1)
	{
		return null;
	}

	public static List<diem> getListPRaiCot(ref Dlcot dl_cot, List<diem> listpcot, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	public static Tuple<PolygonModule.CurveXYZ, double> GetCurveCPhuongX(Dlcot dl_cot, List<diem> listpcot, int indexCurveX)
	{
		return null;
	}

	public static Tuple<PolygonModule.CurveXYZ, double> GetCurveCPhuongY(Dlcot dl_cot, List<diem> listpcot, int indexCurveY)
	{
		return null;
	}

	public static void Ve_bao_cot_mat_cat(ref List<Line_diem> list_line_cot, diem diem0, List<List<diem>> listCotMC)
	{
	}

	public static void Ve_bao_cot_tron(ref List<Line> list_line_cot, diem diem0)
	{
	}

	public static void lay_du_lieu_coc_tu_block(List<BlockReference> listblk)
	{
	}

	internal static bool eNFp3QTw9JkqhiT5S7UX()
	{
		return true;
	}

	internal static Mong_coc thA3pjTwbya9kalXgbWv()
	{
		return null;
	}
}
