using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Kata_Class_Lib_Revit;
using MMvEygPQ4PdjSIRahVVe;
using Microsoft.VisualBasic.CompilerServices;
using RpVxxCPmaUDhuZVeqwWU;
using whEFpk7cQEwbPbv5ufiN;
using wkkfIuPQq7T3mEZIPsR9;

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

		private static InfoMongCoc h8tWvwendyvp2NtybB2l;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoMongCoc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCotPhuIndex(List<diem> lp)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCotTronIndex(KataCircle3D c)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetSoThanhThepCot(Dlcot dlcot)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoMongCoc()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 2:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 1;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_259044fb2a9b4ed982aeb9fec374b138 == 0)
							{
								num3 = 6;
							}
							continue;
						case 1:
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 9;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_9812e68b998340c8a2a7a2e9064dc0c1 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
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
				cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xsgDYyenZQJoHX04LK7P()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoMongCoc StZHkcenX9JwaCx8JYc8()
		{
			return null;
		}
	}

	public class KataCircle
	{
		public Point2d tam;

		public double radius;

		internal static KataCircle lvkw8Aen4LBvuY4QZovP;

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
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 0:
							break;
						case 1:
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 0;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_7e810419ea5841fe868bb0007399c6c7 != 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 1;
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
				cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
				num = 0;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_447cda57de69491699bff3ac3f4e3b02 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool syI2p4enL1ZUpgPOnXej()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KataCircle xUr9pTenW5PmKQdZYcxI()
		{
			return null;
		}
	}

	public class KataCircle3D
	{
		public diem center;

		public double diameter;

		internal static KataCircle3D kmIQHTenf1FLdHTvdhT8;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KataCircle3D()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KataCircle3D(diem p, double dia)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KataCircle3D()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
							goto end_IL_000e;
						case 2:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 1;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8b89e9e629fe446d94dd0add4f493dbd != 0)
							{
								num3 = 3;
							}
							continue;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 0;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_01dffe3d636c4511a02fbcfa370b935e != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
				num = 9;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_5621b3af91a740fcae814c8744358f38 == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DZlXBYen1Bn2RcKOpvK3()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KataCircle3D wN35HIeniaKJECS7DJv0()
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

		private static LopThepThem sFwhfaenVrKxeqm4mVun;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LopThepThem()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LopThepThem()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
								return;
							}
							goto IL_0031;
						case 0:
							goto end_IL_000e;
						case 2:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 9;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_655771b76bea4dcea4aed7675ff9bf3b != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						goto IL_0078;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0078;
						IL_0078:
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 0;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_a3b95bbf0135491e834a2244db4fa70a == 0)
						{
							num3 = 0;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
				cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oSZMTOenaVVmb578xZB8()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LopThepThem ejFw9SenqqHQLyqjrOAw()
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

		private static InfoUserMongCoc FvT68NenUhTvT6Ztowp8;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoUserMongCoc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoUserMongCoc()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
									goto end_IL_0012;
								}
								goto case 1;
							}
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 2;
							continue;
						case 0:
							break;
						case 2:
							return;
						case 1:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 4;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_94307e2eee5f4d7ba0ddab43f0853a83 == 0)
							{
								num3 = 0;
							}
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
				hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
				num = 9;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_9910a46cb28349cfaeb087eb7d220018 != 0)
				{
					num = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VRNgdyenCeWhI7eXIIFD()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoUserMongCoc FPGJVqenMNGWukVdPRWK()
		{
			return null;
		}
	}

	public class CoversMong
	{
		public double cover_tren;

		public double cover_duoi;

		public double cover_ngang;

		internal static CoversMong v4JP6DenbdHdnNA9NwF0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CoversMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CoversMong()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
									goto end_IL_0012;
								}
								goto case 0;
							}
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 9;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_914645b7abe249fcb3d245d110bf151b == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 2;
							continue;
						case 2:
							return;
						case 1:
							break;
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
				hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
				num = 9;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_439d0a60910f40378b8fb37608276e9f == 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YsqRPhenmA1bjbuQi7wm()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CoversMong uw4gIrenFEVfYcR1dwyW()
		{
			return null;
		}
	}

	public class Infogrid
	{
		public mat_phang_diem mp;

		public string nameGrid;

		public int index;

		private static Infogrid SyadZEenQuQ7dsK0pGVa;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Infogrid()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Infogrid()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
								cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
								num3 = 1;
								if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_e94523c7e6f44c11b8adea217f9f1bd4 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto IL_0031;
						case 0:
							goto end_IL_000e;
						case 2:
							return;
						case 1:
							break;
						}
						goto IL_0078;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0078;
						IL_0078:
						hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
						num3 = 3;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_e27376802bfa4825b28d95ae0ce49636 != 0)
						{
							num3 = 0;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
				hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tiKBh9en0MMNiMxvMIPo()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Infogrid EBilr0envKCZDTw5RgYw()
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

		private static Dlcot dOWjtaenrPPd8oUDoMa1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dlcot()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Dlcot()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
									goto end_IL_0012;
								}
								goto case 2;
							}
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 2;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_1a9362b850bf47309e70efba0a302d4e == 0)
							{
								num3 = 9;
							}
							continue;
						case 0:
							return;
						case 1:
							break;
						case 2:
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 0;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8f3146c4a9a94fa4a9660f4722628ca1 != 0)
							{
								num3 = 2;
							}
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
				hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
				num = 8;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_7c73f7421d6049bb83bc49a04648fc95 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jkCLw7enG2iLEvxrs2c5()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Dlcot Ygu1YrenlDVK7jE3W44b()
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

		internal static InfoMongCocSave hiNE9wenyJKNjH63NV8k;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoMongCocSave()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoMongCocSave()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 1:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 0;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_0589f7b8c5e64467bad67363887d6f6e == 0)
							{
								num3 = 8;
							}
							continue;
						case 0:
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 1;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_cf6135828c524da4a4a188d989d0b046 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							break;
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
				cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qCirHmenzN1jEhFo6JRs()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoMongCocSave ONVKxseRoiURhVqKCG82()
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

	private static double[] BYu7K2cbr6W;

	private static diem qe97KYd2hhk;

	private static info_thep[] noM7KnsOqn1;

	private static diem Err7KRpxwrY;

	private static diem mII7K6I2VmH;

	private static diem pmA7KprafPR;

	private static diem A8q7KhfqAMV;

	private static diem WZb7K7Sd8Rn;

	private static diem cC47KPnrHjw;

	private static diem jpb7KDBZgb6;

	private static diem DkG7KgMDda2;

	private static double Kex7Kkbbjys;

	private static double gV67KeDSCho;

	private static double Sdp7KxA9U2A;

	private static double Bd97KwMqZgN;

	private static List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV> Voa7KHtwKn2;

	private static List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV> ny87KtQ533w;

	private static List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV> MBC7KEZApU1;

	private static List<List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV>> wwR7KTyF6IE;

	private static List<object> kap7KB7OsY4;

	private static double GlR7KSaL2Vq;

	private static diem rxH7KcZxVw4;

	private static List<List<diem>> BPn7K3134J4;

	private static List<diem> cMF7K52MoEW;

	private static List<diem> dw07KumuRI9;

	private static int E067KjBW0Hf;

	internal static Mong_coc YSnEPlk85twjQs3fsLjC;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Mong_coc()
	{
		hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
								goto end_IL_0012;
							}
							goto case 22;
						}
						formThepThemNgang = new Form_Lop_Thep_Them_Ngang();
						num3 = 29;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_5fb6d3a10ea241f5ba7141dacf93fe8c == 0)
						{
							num3 = 25;
						}
						continue;
					case 8:
						A8q7KhfqAMV = new diem();
						num3 = 7;
						continue;
					case 10:
						mII7K6I2VmH = new diem();
						num3 = 9;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_e27376802bfa4825b28d95ae0ce49636 == 0)
						{
							num3 = 38;
						}
						continue;
					case 14:
						cC47KPnrHjw = new diem();
						num3 = 16;
						continue;
					case 12:
						info_mong_coc = new InfoMongCoc();
						num3 = 2;
						continue;
					case 27:
						listlistL = new List<List<double>>();
						num3 = 22;
						continue;
					case 13:
						dw07KumuRI9 = new List<diem>();
						num3 = 18;
						continue;
					case 2:
						formMongCoc = new Form_mong_coc();
						num3 = 32;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_9812e68b998340c8a2a7a2e9064dc0c1 == 0)
						{
							num3 = 28;
						}
						continue;
					case 20:
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 23;
						continue;
					case 1:
						cMF7K52MoEW = new List<diem>();
						num3 = 13;
						continue;
					case 11:
						ny87KtQ533w = new List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV>();
						num3 = 30;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_439d0a60910f40378b8fb37608276e9f != 0)
						{
							num3 = 28;
						}
						continue;
					case 17:
						j2fgy2PQXXu5mcBnICUJ.Cw4e9Yq8dob();
						num3 = 12;
						continue;
					case 3:
						rxH7KcZxVw4 = new diem();
						num3 = 30;
						continue;
					case 19:
						phuongB = false;
						num = 6;
						break;
					case 4:
						BYu7K2cbr6W = new double[3];
						num3 = 25;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_1cd60b4210064e978754b8c9114ca233 != 0)
						{
							num3 = 2;
						}
						continue;
					case 23:
						cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
						num = 17;
						break;
					case 0:
						wwR7KTyF6IE = new List<List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV>>();
						num3 = 26;
						continue;
					case 21:
						hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
						num3 = 20;
						continue;
					case 29:
						formThepThemTren = new Form_Lop_Thep_Them_Tren();
						num3 = 27;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_e94523c7e6f44c11b8adea217f9f1bd4 != 0)
						{
							num3 = 30;
						}
						continue;
					case 30:
						BPn7K3134J4 = new List<List<diem>>();
						num3 = 1;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_52901c01d2fa42ea8d461769c88ece24 != 0)
						{
							num3 = 28;
						}
						continue;
					case 5:
						Voa7KHtwKn2 = new List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV>();
						num3 = 11;
						continue;
					case 16:
						jpb7KDBZgb6 = new diem();
						num3 = 12;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_6a69738950be48d0ab0f2b3642ed71ec == 0)
						{
							num3 = 15;
						}
						continue;
					case 18:
						return;
					case 22:
						LOAIDATAMONGCOC = hbMKCRPmVZCIcxwl8kPE.EsRPFp6BuTd(0x47AFD325 ^ _003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_5d76feafcc744cf19684ae6a05d733bb);
						num3 = 19;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_7c73f7421d6049bb83bc49a04648fc95 == 0)
						{
							num3 = 0;
						}
						continue;
					case 31:
						Err7KRpxwrY = new diem();
						num3 = 10;
						continue;
					case 25:
						qe97KYd2hhk = new diem();
						num3 = 24;
						continue;
					case 7:
						WZb7K7Sd8Rn = new diem();
						num3 = 14;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_118778ba3709426bad02248d4e76b41c != 0)
						{
							num3 = 36;
						}
						continue;
					case 6:
						listLocation = new List<diem>();
						num3 = 4;
						continue;
					case 9:
						pmA7KprafPR = new diem();
						num3 = 8;
						continue;
					case 24:
						noM7KnsOqn1 = new info_thep[1];
						num3 = 1;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_b1c546c159a3410f82c3f162cec92187 != 0)
						{
							num3 = 31;
						}
						continue;
					case 15:
						DkG7KgMDda2 = new diem();
						num3 = 5;
						continue;
					case 28:
						MBC7KEZApU1 = new List<zhOPxh7cFt7ZtWw73tjq.kWva8lPX3DBvnaOwkXZV>();
						num3 = 0;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_f943b8f928cd406bacd7e3fdf605b6db == 0)
						{
							num3 = 18;
						}
						continue;
					case 32:
						formThepThemDuoi = new Form_Lop_Thep_Them();
						num = 39;
						break;
					case 26:
						kap7KB7OsY4 = new List<object>();
						num3 = 3;
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
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getInfoMongCocSaveJsonData()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getInfoMongCocSaveJsonData2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_ca_mong_coc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string block_TD_without_tl(ref diem goc1, ref string ten, ref int tl, string loai = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_bao_MC1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void get_length_spacing_so_thanh_kc2ben(double _length, double _spacing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void getListListL(List<double> listL)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void getLText(List<double> listx, int lPointsCount, double dbmtrai, double dbmphai)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_thep_them_duoi_doc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_thep_them_tren_doc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TinhToanThepDocMongCoc(ref diem pdau, diem listpdim0, PolygonModule.Polygon plDuongBaoTrong, ref List<double> listL, bool test = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TinhToanThepNgangMongCoc(ref diem pdau, diem listpdim0, PolygonModule.Polygon plDuongBaoTrong, ref List<double> listL, bool test = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_cot_mong_coc(diem p_goc, diem diem1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void get_L_a_n_ThepDuoiRaiTheHien(double _space, [Optional][DefaultParameterValue(null)] ref diem point_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void get_L_a_n_ThepTrenRaiTheHien(double _space, [Optional][DefaultParameterValue(null)] ref diem point_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void thay_doi_thu_tu_diem(ref List<diem> listptrong, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem timPGocGiua(diem pgoc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool kiemTraDoiXungTheoPhuongb(diem pGocGiua)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool kiemTraDoiXungTheoPhuongl(diem pGocGiua)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<diem> YRA7Ko6g0PD(object P_0, List<diem> P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepdn(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimtheptn(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepngangB(double spacing_ngang, List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepdd(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimtheptd(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double spa = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> dimthepngang(double spacing_doc, List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsDNMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsDNMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsTNMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsNgangMBB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsTNMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtren = -1.0, double dbmduoi = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsNgangMB2B(double tren, double duoi, List<diem> duongbaotrong, diem pcat, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsDDMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsDDMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointsTDMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> LayTapPointsNgangMB(List<diem> listpphuongb, List<diem> listpphuongl, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> LayTapPointsTDMB2(List<diem> duongbaotrong, diem pcat, ref diem ptag, double dbmtrai = -1.0, double dbmphai = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> LayTapPointsNgangMB2(double trai, double phai, List<diem> duongbaotrong, diem pcat, ref diem ptag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Getl2pointcatmp(diem p, List<diem> listp, diem normal, diem phuong)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TimBvaL(ref double b, ref double l, ref diem PGiua, List<diem> listPCot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void timBvaLMC(ref double b, ref double l, ref diem PGiua, List<diem> listPCot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lay_tap_point_thep_thep_cot_traiMC(Dlcot dl_cot, ref List<diem> list_point, double b, double l, diem PGiua, ref double length, ref diem p2inthepcot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lay_tap_point_thep_thep_cot_phaiMC(Dlcot dl_cot, ref List<diem> list_point, double b, double l, diem PGiua)
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
	public static List<diem> layTapPointTDMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmtrai = -1.0, double dbmphai = -1.0, double z = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointTNMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmduoi = -1.0, double dbmtren = -1.0, double z = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointDNMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmduoi = -1.0, double dbmtren = -1.0, double z = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointDDMatCat([Optional][DefaultParameterValue(null)] ref diem d1, double dbmtrai = -1.0, double dbmphai = -1.0, double z = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void them_moc(ref List<diem> list_point, diem xvecto, diem yvecto, bool nguoc1 = true, bool nguoc2 = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem layDiemThepTraiThepDai()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem layDiemThepPhaiThepDai()
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
	public static List<diem> layTapPointCTTrai()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> layTapPointCTPhai([Optional][DefaultParameterValue(null)] ref diem d1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveCTTrai()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveCTPhai()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveNgang()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> layTapCurveD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem timPGoc(List<diem> listPMatBang)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void tao_dim_tu_tap_diem_phuongY(List<diem> listdiem, diem diem0, diem goc, diem xvecto, diem yvecto, diem location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void tao_dim_tu_tap_diem_phuongX(List<diem> listdiem, diem diem0, diem goc, diem xvecto, diem yvecto, diem location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> get_list_point_coc_in_view_autocad()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool kiemTrapoint_coc_trong_hcn_autocad(diem p, List<diem> hcn, diem normalhcn)
	{
		return true;
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
	public static void ve_giao_thep_dim_update(ref object runlen)
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
	public static List<List<Line_diem>> GetLLCurvesBTL()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListCurvesCoc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListCurvesBLCoc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_thep_cot(PreviewCanvas sConMCoc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<bool, diem, diem> IsListPCotHopLe(List<diem> listpCot)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<List<Line_diem>, List<Line_diem>, diem> GetListCurveCot()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> GetListBLCot()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_mat_cat_coc(PreviewCanvas sConMCoc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_coc_mong_coc(PreviewCanvas sConMCoc, List<diem> list_xyz, double phi, Point gocve, diem goc, diem xvecto, diem yvecto, double tl, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ve_hinh_tron(PreviewCanvas sCon, diem center, double dia, Point gocve, diem goc, diem xvecto, diem yvecto, double tl, Color color, bool visiblee = true, double width = -1.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VeMCMongForm(PreviewCanvas sConMCoc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VeMBMongForm(PreviewCanvas sConMCoc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_mong_coc(List<BlockReference> listBlock, List<BlockReference> listBlockCot, List<Polyline> listPoly, List<Circle> listCircle, List<Line> listLine, List<Line> listLineKhuat)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiThepDai([Optional][DefaultParameterValue(null)] ref List<diem> Ptags)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiThepDuoi()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiThepTren()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> getListCThepDuoiNgangTheHienForm(LopThepThem thepThem, diem p_goc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Line_diem> getListCThepTrenNgangTheHienForm(LopThepThem thepThem, diem p_goc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiThepDuoi(LopThepThem thepThem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiThepTren(LopThepThem thepThem)
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
	public static Tuple<List<diem>, List<Tuple<PolygonModule.CurveXYZ, double>>> getListPRaiCotTronUtil(Dlcot dl_cot, KataCircle3D c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiCotTron(Dlcot dl_cot, KataCircle3D c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Tuple<PolygonModule.CurveXYZ, double>> getListCurveCotTron(Dlcot dl_cot, KataCircle3D c, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<List<diem>, Tuple<PolygonModule.CurveXYZ, double>, Tuple<PolygonModule.CurveXYZ, double>> getListPRaiCotUtil(ref Dlcot dl_cot, List<diem> listpcot, int indexCurveX = 1, int indexCurveY = 1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> getListPRaiCot(ref Dlcot dl_cot, List<diem> listpcot, diem VtorPhuongX, diem VtorPhuongY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<PolygonModule.CurveXYZ, double> GetCurveCPhuongX(Dlcot dl_cot, List<diem> listpcot, int indexCurveX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<PolygonModule.CurveXYZ, double> GetCurveCPhuongY(Dlcot dl_cot, List<diem> listpcot, int indexCurveY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_bao_cot_mat_cat(ref List<Line_diem> list_line_cot, diem diem0, List<List<diem>> listCotMC)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Ve_bao_cot_tron(ref List<Line> list_line_cot, diem diem0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lay_du_lieu_coc_tu_block(List<BlockReference> listblk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EFRligk8uAefiTj5RTpb()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Mong_coc DT1Tnik8jfCfdFBoZM6A()
	{
		return null;
	}
}
