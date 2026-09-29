using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using UI_Module_12;
using Module_25;
using Licensing_32;

namespace _namespace_1;

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

		public diem _diem_2;

		public double _double_3;

		public double _double_4;

		public double _double_5;

		public double _double_6;

		public double _double_7;

		public double _double_8;

		public double l_am;

		public double l_duong;

		public double _double_9;

		public double b_am;

		public double b_duong;

		public double _double_10;

		public diem b_vecto;

		public diem l_vecto;

		public diem h_vecto;

		public InfoUserMongCoc dln;

		public Dlcot _dlcot_11;

		public List<Dlcot> _listDlcot_99;

		public double _double_13;

		public double _double_14;

		public double _double_15;

		public double _double_16;

		public double hsanTrai;

		public double hsanPhai;

		public double cao_do;

		public List<diem> list_point_duoi_mong;

		public List<diem> list_point_duoi_cot;

		public List<List<diem>> ll_point_cot;

		public List<GetStatic_10> list_pcot_tron;

		public List<diem> list_point_duoi_betonglot;

		public List<diem> list_point_coc;

		public List<Infogrid> list_grid;

		public List<object> _listObject_17;

		public List<string> blockName;

		public string _string_18;

		public double diameter;

		public double diameter_X;

		public double diameter_Y;

		public bool _bool_19;

		public bool _bool_20;

		public List<diem> _listDiem_21;

		public List<diem> _listDiem_22;

		public int _string_100;

		internal static InfoMongCoc _infomongcoc_24;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoMongCoc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetInt_1(List<diem> lp)
		{
			return _return_27;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetInt_2(GetStatic_10 c)
		{
			return _return_27;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetInt_3(Dlcot dlcot)
		{
			return _return_27;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoMongCoc()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_139;
								}
								goto case 1;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						case 2:
							return;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_78acf557389e4c83804bda1025ad65ea == _return_27)
							{
								num3 = 2;
							}
							continue;
						case _return_27:
							break;
						}
						goto _goto_140;
						continue;
						_goto_139:
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c80ea1ec51aa4cc0bdd285aeb9f11013 == _return_27)
				{
					num = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_4()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoMongCoc GetInfomongcoc_5()
		{
			return null;
		}
	}

	public class KataCircle
	{
		public Point2d tam;

		public double radius;

		internal static KataCircle _katacircle_30;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KataCircle()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KataCircle(Point2d p, double rad)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KataCircle()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
								AppClass_054.IveTMUdyS5E();
								num3 = _return_27;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 == _return_27)
								{
									num3 = 5;
								}
								continue;
							}
							goto _goto_31;
						case 1:
							goto _goto_140;
						case _return_27:
							return;
						case 2:
							break;
						}
						goto _goto_34;
						_goto_31:
						if (num2 == 990)
						{
							break;
						}
						goto _goto_34;
						_goto_34:
						AppClass_016.TqZDb19vgxf();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c660b2a9f2294e84996cb208a4355bde == _return_27)
						{
							num3 = _return_27;
						}
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_6()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KataCircle GetKatacircle_7()
		{
			return null;
		}
	}

	public class GetStatic_10
	{
		public diem center;

		public double diameter;

		private static GetStatic_10 _appclass326_35;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_10()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_10(diem p, double dia)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_10()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
							AppClass_016.TqZDb19vgxf();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_cf58fd231e5d4ef089c24814da16672b != _return_27)
							{
								num3 = 1;
							}
							continue;
						case 1:
							goto _goto_140;
						case _return_27:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_054.IveTMUdyS5E();
							num3 = 9;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 != _return_27)
							{
								num3 = _return_27;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 != _return_27)
				{
					num = _return_27;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_11()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_10 GetAppclass326_12()
		{
			return null;
		}
	}

	public class LopThepThem
	{
		public double _double_37;

		public double spacing_ngang;

		public double fdoc;

		public double spacing_doc;

		public double _double_38;

		public double dbm_duoi;

		public double dbm_trai;

		public double dbm_phai;

		internal static LopThepThem _lopthepthem_39;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LopThepThem()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LopThepThem()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_139;
								}
								goto case _return_27;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1a1ae42c9fb647b2ac3ccb55018de5e5 != _return_27)
							{
								num3 = _return_27;
							}
							continue;
						case _return_27:
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						case 1:
							break;
						case 2:
							return;
						}
						goto _goto_140;
						continue;
						_goto_139:
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 6;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 == _return_27)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_13()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LopThepThem GetLopthepthem_14()
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

		public string _string_42;

		public double spacing_td;

		public double spacing_tn;

		public double spacing_dd;

		public double spacing_dn;

		public double spacing_dai;

		public double spacing_do;

		public double spacing_ct;

		public double ndai;

		public double _double_43;

		public double _double_44;

		public double _double_45;

		public double dbm_tn_duoi;

		public double _double_46;

		public double _double_47;

		public double _double_48;

		public double _double_49;

		public double dbm_dn_duoi;

		public double dbm_dai;

		public CoversMong covers;

		public bool co_thep_tren;

		public bool _bool_50;

		public bool co_thep_dai;

		public bool co_thep_do;

		public bool co_thep_cot;

		public List<LopThepThem> list_thep_ngang;

		public List<LopThepThem> list_thep_duoi;

		public List<LopThepThem> list_thep_tren;

		public double _double_51;

		public double _double_52;

		public double hCho3;

		public int _int_53;

		public int _int_54;

		public bool _bool_55;

		public bool _bool_56;

		internal static InfoUserMongCoc _infousermongcoc_57;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoUserMongCoc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoUserMongCoc()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
							AppClass_054.IveTMUdyS5E();
							num3 = 4;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fda9dec917b14c45931e0d4eb71de6b8 == _return_27)
							{
								num3 = _return_27;
							}
							continue;
						case 1:
							goto _goto_140;
						case _return_27:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_9b8a3fa59b0643a9a005e0e055caa087 == _return_27)
				{
					num = 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_15()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoUserMongCoc GetInfousermongcoc_16()
		{
			return null;
		}
	}

	public class CoversMong
	{
		public double cover_tren;

		public double cover_duoi;

		public double cover_ngang;

		internal static CoversMong _coversmong_59;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CoversMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CoversMong()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
						case _return_27:
							return;
						case 1:
							goto _goto_140;
						case 2:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f09347d075a54e3c9e3affc36c5644b5 == _return_27)
							{
								num3 = 4;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_068fed8884eb4f759ebb34fd2b6f962b == _return_27)
				{
					num = 6;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_17()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CoversMong GetCoversmong_18()
		{
			return null;
		}
	}

	public class Infogrid
	{
		public mat_phang_diem _matPhangDiem_61;

		public string nameGrid;

		public int index;

		internal static Infogrid _infogrid_62;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Infogrid()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Infogrid()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
						default:
							if (num2 == 9)
							{
								return;
							}
							goto _goto_139;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 == _return_27)
							{
								num3 = 4;
							}
							continue;
						case _return_27:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_7b47a3ce476644de941f3c07d3c7ccdb != _return_27)
							{
								num3 = 1;
							}
							continue;
						}
						goto _goto_140;
						continue;
						_goto_139:
						break;
					}
					continue;
					_goto_140:
					break;
				}
				while (num2 == 990);
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 == _return_27)
				{
					num = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_19()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Infogrid GetInfogrid_20()
		{
			return null;
		}
	}

	public class Dlcot
	{
		public double duong_kinh;

		public int _int_65;

		public int y_thanh;

		public double f_dai;

		public double spacing_dai;

		public int n_dai;

		public double cover_dai;

		public int _int_66;

		public bool khoaDauCot;

		public double leg;

		public double topleg;

		public string daiCX;

		public string daiCY;

		public string daivuongX;

		public string daivuongY;

		public bool isCotTron;

		public int _int_67;

		public string daiCotText;

		public double dkDaiGC;

		internal static Dlcot _dlcot_68;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dlcot()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Dlcot()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
							switch (num2)
							{
							case 990:
								goto _goto_139;
							case 9:
								return;
							}
							goto _goto_140;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 == _return_27)
							{
								num3 = 5;
							}
							continue;
						case _return_27:
							goto _goto_140;
						case 2:
							{
								AppClass_016.TqZDb19vgxf();
								num3 = 1;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6ce9290b5e1746939442406839df2a66 != _return_27)
								{
									num3 = 8;
								}
								continue;
							}
							_goto_139:
							break;
						}
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_21()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Dlcot GetDlcot_22()
		{
			return null;
		}
	}

	public class GetStatic_24
	{
		public string daiRauCoc;

		public string mocDaiDung;

		public string beMocCauTao;

		public string Cover_cot;

		public string dai_cot;

		public string phi_cot;

		public string tb_cover_duoi;

		public string _string_72;

		public string _string_73;

		public string _string_74;

		public string _string_75;

		public string _string_76;

		public string Thep_cot_Y;

		public string Thep_cot_X;

		public string _string_77;

		public string _string_78;

		public string _string_79;

		public string tb_h1;

		public string tb_e1;

		public string tb_h2;

		public string tb_h3;

		public string tb_d3;

		public string tb_e3;

		public string tb_d1;

		public string _string_80;

		public string tb_thep_do;

		public bool cb_co_thep_do;

		public bool _bool_81;

		public bool _bool_82;

		public string _string_83;

		public string tb_thep_dai;

		public string _string_84;

		public string _string_85;

		public string _string_86;

		public string _string_87;

		public string _string_88;

		public string _string_89;

		public string _string_90;

		public string tb_cover_tren;

		public bool _bool_91;

		public bool _bool_92;

		public bool _bool_93;

		public bool _bool_94;

		public string _string_95;

		public string _string_96;

		public string tbcautao;

		public bool _bool_97;

		public bool _bool_98;

		public string tb_h4;

		public string Thep_cot_tron;

		public string ThepCho;

		public string hCho3;

		public string hCho1;

		public string hCho2;

		public List<LopThepThem> list_thep_ngang;

		public List<LopThepThem> list_thep_duoi;

		public List<LopThepThem> list_thep_tren;

		public List<Dlcot> _listDlcot_99;

		public bool khoaDauCot;

		public string _string_100;

		public bool _bool_101;

		public bool _bool_102;

		internal static GetStatic_24 _appclass327_103;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_24()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_24()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_139;
								}
								goto case 1;
							}
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 8;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6ce9290b5e1746939442406839df2a66 == _return_27)
							{
								num3 = 1;
							}
							continue;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = _return_27;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988 == _return_27)
							{
								num3 = 7;
							}
							continue;
						case _return_27:
							break;
						}
						goto _goto_140;
						continue;
						_goto_139:
						break;
					}
					continue;
					_goto_140:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_25()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_24 GetAppclass327_26()
		{
			return null;
		}
	}

	public static InfoMongCoc info_mong_coc;

	public static Form_mong_coc formMongCoc;

	public static Form_Lop_Thep_Them _formLopThepThem_106;

	public static Form_Lop_Thep_Them_Ngang _formLopThepThemNgang_107;

	public static Form_Lop_Thep_Them_Tren _formLopThepThemTren_108;

	public static List<List<double>> listlistL;

	public static string Ltext;

	public static double hThepCho;

	public static double spacing;

	public static double length;

	public static int so_thanh;

	public static double _double_109;

	public static string LOAIDATAMONGCOC;

	public static bool phuongB;

	public static diem _diem_110;

	public static double _double_111;

	public static Point goc_duoi;

	public static Point goc_tren;

	public static List<diem> listLocation;

	private static double[] _doublearray_112;

	private static diem _diem_113;

	private static info_thep[] _infoTheparray_114;

	private static diem _diem_115;

	private static diem _diem_116;

	private static diem _diem_117;

	private static diem _diem_118;

	private static diem _diem_119;

	private static diem _diem_120;

	private static diem _diem_121;

	private static diem _diem_122;

	private static double _double_123;

	private static double _double_124;

	private static double _double_125;

	private static double _double_126;

	private static List<AppClass_111.AppClass_116> _appclass116_127;

	private static List<AppClass_111.AppClass_116> _appclass116_128;

	private static List<AppClass_111.AppClass_116> _appclass116_129;

	private static List<List<AppClass_111.AppClass_116>> _appclass116_130;

	private static List<object> _listObject_131;

	private static double _double_132;

	private static diem _diem_133;

	private static List<List<diem>> _listListDiem_134;

	private static List<diem> _listDiem_135;

	private static List<diem> _listDiem_136;

	private static int _int_137;

	internal static Mong_coc _mongCoc_138;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Mong_coc()
	{
		AppClass_016.uQ4DbMFRj7Q();
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
					default:
						if (num2 != 39)
						{
							if (num2 == 1020)
							{
								goto _goto_139;
							}
							goto case 31;
						}
						_diem_118 = new diem();
						num3 = 10;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_8914b8dde10043a5a310f94275ef0637 != _return_27)
						{
							num3 = 19;
						}
						continue;
					case 7:
						_diem_115 = new diem();
						num3 = 25;
						continue;
					case 25:
						_diem_116 = new diem();
						num3 = 9;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 != _return_27)
						{
							num3 = 8;
						}
						continue;
					case 29:
						formMongCoc = new Form_mong_coc();
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_731c31f89ee84065b40adfdeb4e0e77c != _return_27)
						{
							num3 = 5;
						}
						continue;
					case 5:
						_formLopThepThem_106 = new Form_Lop_Thep_Them();
						num3 = _return_27;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3e20b8f0eaaf4c2c858e7c7ca7131a33 == _return_27)
						{
							num3 = 21;
						}
						continue;
					case 23:
						listLocation = new List<diem>();
						num3 = 18;
						continue;
					case 28:
						listlistL = new List<List<double>>();
						num3 = 18;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 != _return_27)
						{
							num3 = 1;
						}
						continue;
					case 15:
						_appclass116_128 = new List<AppClass_111.AppClass_116>();
						num3 = 6;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b == _return_27)
						{
							num3 = 39;
						}
						continue;
					case 26:
						info_mong_coc = new InfoMongCoc();
						num3 = 29;
						continue;
					case 27:
						_diem_121 = new diem();
						num3 = 13;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 == _return_27)
						{
							num3 = 24;
						}
						continue;
					case 22:
						phuongB = false;
						num3 = 23;
						continue;
					case 4:
						_listDiem_135 = new List<diem>();
						num3 = 9;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fa885cb658d447638297a1e47340b8c6 == _return_27)
						{
							num3 = 4;
						}
						continue;
					case 20:
						AppClass_016.QB3DbWPnHbY();
						num3 = 32;
						continue;
					case 24:
						_listListDiem_134 = new List<List<diem>>();
						num = 4;
						break;
					case 2:
						_diem_113 = new diem();
						num3 = 17;
						continue;
					case 8:
						_diem_117 = new diem();
						num = 32;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a771e08388354bdfb62e531f5992b6e4 == _return_27)
						{
							num = 39;
						}
						break;
					case 16:
						return;
					case 14:
						_formLopThepThemTren_108 = new Form_Lop_Thep_Them_Tren();
						num3 = 28;
						continue;
					case 30:
						_diem_133 = new diem();
						num3 = 24;
						continue;
					case 9:
						_listDiem_136 = new List<diem>();
						num3 = 16;
						continue;
					case 12:
						_appclass116_130 = new List<List<AppClass_111.AppClass_116>>();
						num3 = 19;
						continue;
					case 10:
						_diem_119 = new diem();
						num3 = 23;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 != _return_27)
						{
							num3 = 11;
						}
						continue;
					case _return_27:
						_formLopThepThemNgang_107 = new Form_Lop_Thep_Them_Ngang();
						num = 14;
						break;
					case 18:
						_doublearray_112 = new double[3];
						num = 2;
						break;
					case 32:
						AppClass_054.IveTMUdyS5E();
						num3 = 31;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3d856b94665044e6b2ba303819a86373 != _return_27)
						{
							num3 = 1;
						}
						continue;
					case 17:
						_infoTheparray_114 = new info_thep[1];
						num3 = 7;
						continue;
					case 3:
						_appclass116_127 = new List<AppClass_111.AppClass_116>();
						num3 = 15;
						continue;
					case 6:
						_appclass116_129 = new List<AppClass_111.AppClass_116>();
						num3 = 14;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a8ebfeac173c4dddb6af45ca0c75e3a2 == _return_27)
						{
							num3 = 12;
						}
						continue;
					case 31:
						AppClass_051.f8oTg3pM5fk();
						num3 = 26;
						continue;
					case 1:
						LOAIDATAMONGCOC = AppClass_016.QqFDbr6RL7F(0x1E697F3C ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_78acf557389e4c83804bda1025ad65ea);
						num3 = 34;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a8ebfeac173c4dddb6af45ca0c75e3a2 == _return_27)
						{
							num3 = 22;
						}
						continue;
					case 11:
						_diem_120 = new diem();
						num3 = 27;
						continue;
					case 19:
						_listObject_131 = new List<object>();
						num = 30;
						break;
					case 13:
						_diem_122 = new diem();
						num = 3;
						break;
					case 21:
						AppClass_016.TqZDb19vgxf();
						num3 = 20;
						continue;
					}
					goto _goto_140;
					continue;
					_goto_139:
					break;
				}
				continue;
				_goto_140:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getInfoMongCocSaveJsonData()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString_27()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_28()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string block_TD_without_tl(ref diem goc1, ref string ten, ref int tl, string loai = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_29()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_30(double _length, double _spacing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void getListListL(List<double> listL)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_31(List<double> listx, int lPointsCount, double dbmtrai, double dbmphai)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_32()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_33()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_34(ref diem pdau, diem listpdim0, PolygonModule.Polygon plDuongBaoTrong, ref List<double> listL, bool test = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_35(ref diem pdau, diem listpdim0, PolygonModule.Polygon plDuongBaoTrong, ref List<double> listL, bool test = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_36(diem p_goc, diem diem1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void get_L_a_n_ThepDuoiRaiTheHien(double _space, [Optional][DefaultParameterValue(null)] ref diem diemParam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void get_L_a_n_ThepTrenRaiTheHien(double _space, [Optional][DefaultParameterValue(null)] ref diem diemParam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_37(ref List<diem> listptrong, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetDiem_38(diem pgoc)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid_39(diem pGocGiua)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid_40(diem pGocGiua)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<diem> GetListDiem_41(object P_0, List<diem> P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepdn(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1._return_27)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimtheptn(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1._return_27)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepngangB(double spacing_ngang, List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepdd(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1._return_27)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimtheptd(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1._return_27)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepngang(double spacing_doc, List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_42(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtren = -1._return_27, double dbmduoi = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_43(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtren = -1._return_27, double dbmduoi = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_44(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtren = -1._return_27, double dbmduoi = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_45(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_46(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtren = -1._return_27, double dbmduoi = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_47(double tren, double duoi, List<diem> duongbaotrong, diem pcat, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_48(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtrai = -1._return_27, double dbmphai = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_49(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtrai = -1._return_27, double dbmphai = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_50(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtrai = -1._return_27, double dbmphai = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> LayTapPointsNgangMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_51(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtrai = -1._return_27, double dbmphai = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_52(double trai, double phai, List<diem> duongbaotrong, diem pcat, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetDouble_53(diem p, List<diem> listp, diem normal, diem phuong)
	{
		return _return_27._return_27;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TimBvaL(ref double _double_10, ref double _double_9, ref diem PGiua, List<diem> listPCot)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void timBvaLMC(ref double _double_10, ref double _double_9, ref diem PGiua, List<diem> listPCot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lay_tap_point_thep_thep_cot_traiMC(Dlcot _dlcot_11, ref List<diem> list_point, double _double_10, double _double_9, diem PGiua, ref double length, ref diem p2inthepcot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lay_tap_point_thep_thep_cot_phaiMC(Dlcot _dlcot_11, ref List<diem> list_point, double _double_10, double _double_9, diem PGiua)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> lay_tap_point_thep_ngang()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<List<diem>> LayLLPointDo(ref int so_thanh_dob, ref int so_thanh_dol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> LayListPointRaiThepDo()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointTDMatCat([Optional][DefaultParameterValue(null)] ref diem _double_3, double dbmtrai = -1._return_27, double dbmphai = -1._return_27, double z = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointTNMatCat([Optional][DefaultParameterValue(null)] ref diem _double_3, double dbmduoi = -1._return_27, double dbmtren = -1._return_27, double z = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointDNMatCat([Optional][DefaultParameterValue(null)] ref diem _double_3, double dbmduoi = -1._return_27, double dbmtren = -1._return_27, double z = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointDDMatCat([Optional][DefaultParameterValue(null)] ref diem _double_3, double dbmtrai = -1._return_27, double dbmphai = -1._return_27, double z = -1._return_27)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void them_moc(ref List<diem> list_point, diem xvecto, diem yvecto, bool nguoc1 = true, bool nguoc2 = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetDiem_54()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetDiem_55()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveDo()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_56()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointCTPhai([Optional][DefaultParameterValue(null)] ref diem _double_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListLineDiem_57()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListLineDiem_58()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListLineDiem_59()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetDiem_60(List<diem> listPMatBang)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_61(List<diem> listdiem, diem diem0, diem goc, diem xvecto, diem yvecto, diem location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_62(List<diem> listdiem, diem diem0, diem goc, diem xvecto, diem yvecto, diem location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> get_list_point_coc_in_view_autocad()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool kiemTrapoint_coc_trong_hcn_autocad(diem p, List<diem> hcn, diem normalhcn)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> lay_list_point_cot(List<List<diem>> llistP3d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> lay_list_point_mong(List<List<diem>> llistP3d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void chuyenDuLieuFormSangMongCoc()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> get_list_point_nam_trong_cach_1_khoang_d(List<diem> list_diem, double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> get_list_point_nam_ngoai_cach_1_khoang_d(List<diem> list_diem, double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void rai_line_thep_va_return_thep(ref object thepp, ref diem goc1, ref int phi, double a, double L, double ang)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> lay_tap_points_thep_dai_phai_mong_coc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> lay_tap_points_thep_dai_trai_mong_coc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_63(ref object runlen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListCurvesMatCat()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Line_diem GetCurveBreakLineTrai()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Line_diem GetCurveBreakLinePhai()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<List<Line_diem>> GetListListLineDiem_64()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListCurvesCoc()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListCurvesBLCoc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_thep_cot(PreviewCanvas sConMCoc)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<bool, diem, diem> IsListPCotHopLe(List<diem> listpCot)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<List<Line_diem>, List<Line_diem>, diem> GetListCurveCot()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListBLCot()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_65(PreviewCanvas sConMCoc)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_66(PreviewCanvas sConMCoc, List<diem> list_xyz, double phi, Point gocve, diem goc, diem xvecto, diem yvecto, double tl, Color color)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_hinh_tron(PreviewCanvas sCon, diem center, double dia, Point gocve, diem goc, diem xvecto, diem yvecto, double tl, Color color, bool visiblee = true, double width = -1._return_27)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VeMCMongForm(PreviewCanvas sConMCoc)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VeMBMongForm(PreviewCanvas sConMCoc)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_mong_coc(List<BlockReference> listBlock, List<BlockReference> listBlockCot, List<Polyline> listPoly, List<Circle> listCircle, List<Line> listLine, List<Line> listLineKhuat)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiThepDai([Optional][DefaultParameterValue(null)] ref List<diem> Ptags)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_71()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_72()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListLineDiem_69(LopThepThem thepThem, diem p_goc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListLineDiem_70(LopThepThem thepThem, diem p_goc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_71(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_72(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListPThepDuoi(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListPThepTren(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListPRaiThepNgang(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListPThepNgang(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<List<diem>, List<Tuple<PolygonModule.CurveXYZ, double>>> GetCurvexyzDouble_73(Dlcot _dlcot_11, GetStatic_10 c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_74(Dlcot _dlcot_11, GetStatic_10 c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Tuple<PolygonModule.CurveXYZ, double>> getListCurveCotTron(Dlcot _dlcot_11, GetStatic_10 c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<List<diem>, Tuple<PolygonModule.CurveXYZ, double>, Tuple<PolygonModule.CurveXYZ, double>> GetCurvexyzDouble_75(ref Dlcot _dlcot_11, List<diem> listpcot, int indexCurveX = 1, int indexCurveY = 1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_76(ref Dlcot _dlcot_11, List<diem> listpcot, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<PolygonModule.CurveXYZ, double> GetCurvexyzDouble_77(Dlcot _dlcot_11, List<diem> listpcot, int indexCurveX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<PolygonModule.CurveXYZ, double> GetCurvexyzDouble_78(Dlcot _dlcot_11, List<diem> listpcot, int indexCurveY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_79(ref List<Line_diem> list_line_cot, diem diem0, List<List<diem>> listCotMC)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_80(ref List<Line> list_line_cot, diem diem0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lay_du_lieu_coc_tu_block(List<BlockReference> listblk)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_81()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Mong_coc GetMongCoc_82()
	{
		return null;
	}
}
