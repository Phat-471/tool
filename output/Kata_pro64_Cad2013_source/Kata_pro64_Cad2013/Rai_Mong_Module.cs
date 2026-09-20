using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using MMvEygPQ4PdjSIRahVVe;
using Microsoft.VisualBasic.CompilerServices;
using RpVxxCPmaUDhuZVeqwWU;
using wkkfIuPQq7T3mEZIPsR9;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Rai_Mong_Module
{
	public class InfoRaiMong
	{
		public diem pointGoc;

		public object blkCoc;

		public PolygonModule.Polygon plCoc;

		public int soCoc;

		public string kcDenMepDaiTxt;

		public Ve_Mat_Bang_Mong_Module.InfoCotCocGenMong cotChiuTai;

		public double angXoay;

		public string TenMong;

		public Ve_Mat_Bang_Mong_Module.ViTriDatTen viTriDatTen;

		private static InfoRaiMong yVU1UmepnopLWpbtIMvE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoRaiMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TinhToanMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Tuple<diem, string>> GetListPSelect()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public diem GetPSelect(string name)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoRaiMong()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
							goto end_IL_0012;
						case 0:
							break;
						case 1:
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 7;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_d29e583b832447ad8eb3282fc0384f55 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 1;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_e94523c7e6f44c11b8adea217f9f1bd4 == 0)
							{
								num3 = 1;
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
				while (num2 == 990);
				cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
				num = 9;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_0589f7b8c5e64467bad67363887d6f6e == 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tY5Md7epRnoXRp9CC3Cn()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoRaiMong sBXgMMep64JCejLcc4nb()
		{
			return null;
		}
	}

	public class RaiMongJig : DrawJig, IDisposable
	{
		public PolygonModule.Polygon polyMong;

		public List<PolygonModule.Polygon> listPlThem;

		public PolygonModule.Polygon polyBtl;

		public List<diem> lpCoc;

		public PolygonModule.Polygon plCoc;

		public diem p0;

		public diem choosingPoint;

		private static RaiMongJig I3cDoIepp6udNxCTUy3P;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RaiMongJig(PolygonModule.Polygon poly, diem p0, List<diem> lpCoc = null, PolygonModule.Polygon plCoc = null, List<PolygonModule.Polygon> listPlThem = null, PolygonModule.Polygon polyBtl = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FwfPikClmqq(WorldDraw P_0, PolygonModule.Polygon P_1, string P_2 = "")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void c7HPieAKSFf(WorldDraw P_0, PolygonModule.Polygon P_1, diem P_2, diem P_3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool WorldDraw(WorldDraw draw)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RaiMongJig()
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
								goto case 0;
							}
							hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
							num3 = 0;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_14bdfd7a4f7d406daca156330ec42e83 == 0)
							{
								num3 = 7;
							}
							continue;
						case 0:
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 5;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8b89e9e629fe446d94dd0add4f493dbd == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							break;
						case 1:
							return;
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
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GHEoKqephcIZhUfVEcaL()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RaiMongJig QihWP4ep7tUKXNRIVNJH()
		{
			return null;
		}
	}

	public class InfoRaiMongDon
	{
		public diem pointGoc;

		public PolygonModule.Polygon plBeTongLot;

		public PolygonModule.Polygon plMong;

		public PolygonModule.Polygon plDinhMong;

		public PolygonModule.Polygon plCot;

		public List<PolygonModule.CurveXYZ> listCCheo;

		public string TenMong;

		public Ve_Mat_Bang_Mong_Module.ViTriDatTen viTriDatTen;

		public double Y1;

		public double Y2;

		public double Y3;

		public double X1;

		public double X2;

		public double X3;

		public double T1;

		public double N1;

		public double D1;

		public double B1;

		public double T2;

		public double N2;

		public double D2;

		public double B2;

		public string CT1;

		public string H1;

		public string H12;

		public string Cover;

		public string ThepPhuongX;

		public string ThepPhuongY;

		internal static InfoRaiMongDon I69DufepPsSyHtqMDvlx;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoRaiMongDon()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TinhToanMong(diem gocCot = null, diem mainVecto = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Translate(diem tranVec)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate(diem center, double angle)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PolygonModule.CurveXYZ> GetListCurveDim()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Tuple<diem, string>> GetListPSelect()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public diem GetPSelect(string name)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoRaiMongDon()
		{
			hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
						default:
							if (num2 == 9)
							{
								hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
								num3 = 5;
								if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_bde61aa9a2ed4f43a557d1bc8973dd53 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto end_IL_0012;
						case 0:
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 2;
							continue;
						case 1:
							break;
						case 2:
							return;
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
				while (num2 == 990);
				hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
				num = 8;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_d29e583b832447ad8eb3282fc0384f55 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LgZ308epDwQl6CwEgKDS()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoRaiMongDon zMoQUdepgPlyMbUbk1q8()
		{
			return null;
		}
	}

	public static Form_Rai_Mong formRaiMong;

	public static InfoRaiMong info_rai_mong;

	public static InfoRaiMongDon info_rai_mong_don;

	private static Rai_Mong_Module BOU1j3k8VMbXyDQZKWIO;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Rai_Mong_Module()
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0012;
							}
							goto case 5;
						}
						return;
					case 5:
						cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
						num3 = 6;
						continue;
					case 2:
						hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
						num3 = 7;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_87105e6439bf4e24847f4deb5927d14a != 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 5;
						continue;
					case 6:
						j2fgy2PQXXu5mcBnICUJ.Cw4e9Yq8dob();
						num3 = 12;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_db0900291a9448bbb4a44bbd39c4c405 == 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						break;
					case 3:
						info_rai_mong = new InfoRaiMong();
						num3 = 0;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_b3040265340e480085114fff2c1d8645 != 0)
						{
							num3 = 5;
						}
						continue;
					case 4:
						formRaiMong = new Form_Rai_Mong();
						num3 = 9;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_6a54133341134505b5f73f2ad037a122 != 0)
						{
							num3 = 3;
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
			info_rai_mong_don = new InfoRaiMongDon();
			num = 2;
			if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8bf6a2249b4b42df99373387a3211111 == 0)
			{
				num = 13;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UvAgjqk8aovl1qkfkNc3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rai_Mong_Module wTmAF9k8q8SjA10IMuSs()
	{
		return null;
	}
}
