using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns61;
using ns62;
using ns64;

namespace ns6;

[StandardModule]
internal sealed class GetStatic_10
{
	public class GetStatic_2 : DrawJig, IDisposable
	{
		private bool boolParam;

		private Point3d point3d_0;

		private Point3d point3d_1;

		public object objectParam;

		public Point3d point3d_2;

		public List<Point3d> _listString_18;

		internal static object objectParam;

		public GetStatic_2(Polyline polylineParam, bool boolParam)
		{
		}

		protected override SamplerStatus samplerstatusParam(JigPrompts jigPrompts_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		private Tuple<Point3d, List<Point3d>> listPoint3dParam(Point3d point3d_3)
		{
			return null;
		}

		protected override bool boolParam(WorldDraw worldDraw_0)
		{
			return true;
		}

		public void Dispose()
		{
		}

		static GetStatic_2()
		{
			AppClass_960.voidParam();
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						_goto_2:
						switch (num3)
						{
						default:
							while (num2 == 9)
							{
								AppClass_960.boolParam();
								num3 = 0;
								if (AppClass_031.class730_0.int_97 != 0)
								{
									continue;
								}
								goto _goto_2;
							}
							goto _goto_3;
						case 1:
							break;
						case 0:
							AppClass_969.point3dParam();
							return;
						case 2:
							return;
						}
						goto _goto_4;
						continue;
						_goto_3:
						break;
					}
					continue;
					_goto_4:
					break;
				}
				while (num2 == 990);
				AppClass_960.listDoubleParam();
				num = 9;
				if (AppClass_031.class730_0.int_56 != 0)
				{
					num = 2;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_2 appclass954Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_3
	{
		public static readonly GetStatic_3 _appclass955_5;

		public static Func<Polygon, double> doubleParam;

		public static Func<AppClass_314, bool> boolParam;

		public static Func<double, double> doubleParam;

		internal static GetStatic_3 _appclass955_6;

		static GetStatic_3()
		{
			AppClass_960.voidParam();
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
							AppClass_967.boolParam();
							num3 = 7;
							if (AppClass_031.class730_0.int_9 == 0)
							{
								continue;
							}
							break;
						case 0:
							AppClass_969.point3dParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_65 == 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto _goto_7;
								}
							}
							else
							{
								AppClass_960.boolParam();
								num3 = 7;
								if (AppClass_031.class730_0.int_21 != 0)
								{
									continue;
								}
							}
							goto case 0;
						case 2:
							goto _goto_8;
						case 4:
							break;
						case 3:
							return;
						}
						_appclass955_5 = new GetStatic_3();
						return;
						continue;
						_goto_7:
						break;
					}
					continue;
					_goto_8:
					break;
				}
				AppClass_960.listDoubleParam();
				num = 11;
			}
		}

		[SpecialName]
		internal double listPoint3dParam(Polygon polygonParam)
		{
			return 0.0;
		}

		[SpecialName]
		internal bool boolParam(AppClass_314 gclass136_0)
		{
			return true;
		}

		[SpecialName]
		internal double doubleParam(double doubleParam)
		{
			return 0.0;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_3 appclass954Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_5
	{
		public diem diemParam;

		private static GetStatic_5 _appclass956_9;

		public GetStatic_5(GetStatic_5 class376_1)
		{
		}

		[SpecialName]
		internal double listPoint3dParam(diem diemParam)
		{
			return 0.0;
		}

		static GetStatic_5()
		{
			AppClass_960.voidParam();
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
						case 0:
							AppClass_969.point3dParam();
							num3 = 2;
							if (AppClass_031.class730_0.int_76 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_10;
								}
							}
							else
							{
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_74 != 0)
								{
									continue;
								}
							}
							goto case 0;
						case 1:
							break;
						case 2:
							return;
						}
						goto _goto_11;
						continue;
						_goto_10:
						break;
					}
					continue;
					_goto_11:
					break;
				}
				AppClass_960.listDoubleParam();
				num = 9;
				if (AppClass_031.class730_0.int_51 == 0)
				{
					num = 4;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_5 appclass954Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_7
	{
		public double doubleParam;

		public double doubleParam;

		internal static GetStatic_7 _appclass957_12;

		public GetStatic_7(GetStatic_7 class377_1)
		{
		}

		[SpecialName]
		internal bool listPoint3dParam(double doubleParam)
		{
			return true;
		}

		static GetStatic_7()
		{
			AppClass_960.voidParam();
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
						case 0:
							AppClass_969.point3dParam();
							num3 = 2;
							if (AppClass_031.class730_0.int_64 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								goto _goto_13;
							}
							AppClass_960.boolParam();
							num3 = 8;
							if (AppClass_031.class730_0.int_73 == 0)
							{
								continue;
							}
							goto case 0;
						case 1:
							break;
						case 2:
							return;
						}
						goto _goto_14;
						continue;
						_goto_13:
						break;
					}
					continue;
					_goto_14:
					break;
				}
				while (num2 == 990);
				AppClass_960.listDoubleParam();
				num = 9;
				if (AppClass_031.class730_0.int_117 == 0)
				{
					num = 4;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_7 appclass954Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_9
	{
		public int intParam;

		internal static GetStatic_9 _appclass958_15;

		public GetStatic_9(GetStatic_9 class378_1)
		{
		}

		[SpecialName]
		internal bool listPoint3dParam(AppClass_314 gclass136_0)
		{
			return true;
		}

		static GetStatic_9()
		{
			AppClass_960.voidParam();
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
							AppClass_960.listDoubleParam();
							num3 = 0;
							if (AppClass_031.class730_0.intParam != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_16;
								}
								goto case 1;
							}
							AppClass_969.point3dParam();
							num3 = 2;
							if (AppClass_031.class730_0.int_67 != 0)
							{
								continue;
							}
							return;
						case 0:
							break;
						case 2:
							return;
						}
						goto _goto_17;
						continue;
						_goto_16:
						break;
					}
					continue;
					_goto_17:
					break;
				}
				AppClass_960.boolParam();
				num = 6;
				if (AppClass_031.class730_0.int_89 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_9 appclass954Param()
		{
			return null;
		}
	}

	private static double doubleParam;

	private static double doubleParam;

	private static double doubleParam;

	private static double doubleParam;

	private static bool boolParam;

	private static object objectParam;

	private static int intParam;

	private static int intParam;

	private static int intParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static List<string> _listString_18;

	private static object objectParam;

	private static object objectParam;

	private static bool boolParam;

	private static List<Polygon> _listPolygon_19;

	private static object objectParam;

	private static List<double> _listDouble_20;

	private static bool boolParam;

	internal static object objectParam;

	static GetStatic_10()
	{
		AppClass_960.voidParam();
		int num = 3;
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
					case 22:
						objectParam = new Collection();
						num3 = 2;
						if (AppClass_031.class730_0.int_90 == 0)
						{
							continue;
						}
						goto case 5;
					case 5:
						_listString_18 = new List<string>();
						goto case 9;
					case 9:
						boolParam = true;
						goto case 21;
					case 21:
						_listPolygon_19 = new List<Polygon>();
						goto case 16;
					case 16:
						objectParam = null;
						goto case 15;
					case 15:
						_listDouble_20 = new List<double>();
						num3 = 7;
						if (AppClass_031.class730_0.int_13 != 0)
						{
							continue;
						}
						goto case 0;
					case 19:
						objectParam = "";
						goto case 4;
					case 4:
						objectParam = "";
						num3 = 21;
						if (AppClass_031.class730_0.int_72 == 0)
						{
							continue;
						}
						goto case 1;
					case 14:
						objectParam = "";
						num3 = 11;
						if (AppClass_031.class730_0.int_21 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						objectParam = "";
						goto case 14;
					case 18:
						objectParam = "";
						num3 = 19;
						if (AppClass_031.class730_0.int_70 != 0)
						{
							continue;
						}
						goto case 12;
					case 17:
						doubleParam = 25.0;
						num3 = 21;
						if (AppClass_031.class730_0.int_113 == 0)
						{
							continue;
						}
						goto case 13;
					case 13:
						doubleParam = 30.0;
						goto case 6;
					case 6:
						objectParam = "";
						goto case 18;
					case 11:
						objectParam = "";
						goto case 10;
					case 10:
						objectParam = new string[8];
						num3 = 13;
						if (AppClass_031.class730_0.int_46 == 0)
						{
							continue;
						}
						goto case 22;
					case 8:
						doubleParam = 150.0;
						num3 = 13;
						if (AppClass_031.class730_0.intParam == 0)
						{
							continue;
						}
						goto case 17;
					default:
						if (num2 != 29)
						{
							if (num2 == 1010)
							{
								goto _goto_21;
							}
						}
						else
						{
							doubleParam = 100.0;
							num3 = 27;
							if (AppClass_031.class730_0.int_37 != 0)
							{
								continue;
							}
						}
						goto case 8;
					case 3:
						AppClass_960.listDoubleParam();
						goto case 2;
					case 2:
						AppClass_960.boolParam();
						goto case 7;
					case 7:
						AppClass_969.point3dParam();
						goto case 12;
					case 12:
						AppClass_967.boolParam();
						num = 29;
						break;
					case 0:
						boolParam = false;
						num = 20;
						break;
					case 20:
						return;
					}
					goto _goto_22;
					continue;
					_goto_21:
					break;
				}
				continue;
				_goto_22:
				break;
			}
		}
	}

	private static List<Point3d> boolParam(object objectParam)
	{
		return null;
	}

	private static Tuple<Point3d, List<Point3d>> appclass954Param(object objectParam, double doubleParam)
	{
		return null;
	}

	private static Polyline polylineParam(object objectParam)
	{
		return null;
	}

	private static Tuple<Polyline, Point3d> point3dParam(object objectParam, List<Point3d> listPoint3dParam, int intParam, object objectParam, bool boolParam = false)
	{
		return null;
	}

	private static bool boolParam(Point3d point3d_0, Point3d point3d_1)
	{
		return true;
	}

	private static void voidParam(ref Polyline polylineParam, object objectParam)
	{
	}

	public static Arc arcParam(object objectParam, int intParam, int intParam = 0, Point3d point3d_0 = default(Point3d))
	{
		return null;
	}

	private static Tuple<Polyline, bool, Point3d, double, Point3d> point3dParam(object objectParam, List<Point3d> listPoint3dParam, int intParam, object objectParam, bool boolParam, object objectParam)
	{
		return null;
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(object objectParam, double doubleParam, object objectParam)
	{
	}

	private static bool boolParam(object objectParam, double doubleParam, [Optional][DefaultParameterValue(0.0)] ref double doubleParam)
	{
		return true;
	}

	private static double doubleParam(object objectParam, double doubleParam, double doubleParam, double doubleParam)
	{
		return 0.0;
	}

	private static List<double> listDoubleParam(List<double> listPoint3dParam)
	{
		return null;
	}

	private static List<double> listDoubleParam(double doubleParam = -1.0)
	{
		return null;
	}

	private static bool boolParam(object objectParam, double doubleParam)
	{
		return true;
	}

	private static void voidParam(object objectParam, double doubleParam)
	{
	}

	private static Polyline polylineParam(object objectParam, double doubleParam)
	{
		return null;
	}

	private static void voidParam(object objectParam, List<double> listPoint3dParam)
	{
	}

	private static Polyline polylineParam(object objectParam)
	{
		return null;
	}

	private static Polyline polylineParam(object objectParam)
	{
		return null;
	}

	private static void voidParam(object objectParam, bool boolParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(bool boolParam = false)
	{
	}

	private static Tuple<Polyline, Polyline> polylineParam(object objectParam, List<Point3d> listPoint3dParam, int intParam, double doubleParam = 0.0)
	{
		return null;
	}

	private static void voidParam(object objectParam)
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_10 appclass953Param()
	{
		return null;
	}
}
