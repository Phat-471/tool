using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_1
{
	private static Dictionary<string, List<List<Info_Beam3D>>> listListInfoBeam3dParam;

	private static List<Info_ColumnWall3D> _listInfoColumnwall3d_1;

	private static List<info_revit_slab> _listInfoRevitSlab_2;

	private static Dictionary<string, CurveXYZ> curvexyzParam;

	private static Dictionary<string, CurveXYZ> curvexyzParam;

	private static Dictionary<string, string> stringParam;

	private static object objectParam;

	private static GetStatic_1 _appclass403_3;

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				_goto_4:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 7:
						AppClass_969.voidParam();
						num3 = 2;
						if (AppClass_031.class730_0.int_75 != 0)
						{
							break;
						}
						goto default;
					default:
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto _goto_4;
							}
						}
						else
						{
							objectParam = null;
							num3 = 0;
							if (AppClass_031.class730_0.int_91 != 0)
							{
								break;
							}
						}
						goto case 5;
					case 5:
						AppClass_960.smethod_13();
						goto case 4;
					case 4:
						AppClass_960.smethod_15();
						num3 = 12;
						if (AppClass_031.class730_0.int_101 != 0)
						{
							break;
						}
						goto case 7;
					case 2:
						AppClass_967.curvexyzParam();
						num3 = 7;
						if (AppClass_031.class730_0.int_65 != 0)
						{
							break;
						}
						goto case 1;
					case 1:
						curvexyzParam = new Dictionary<string, CurveXYZ>();
						goto case 3;
					case 3:
						curvexyzParam = new Dictionary<string, CurveXYZ>();
						goto case 6;
					case 6:
						stringParam = new Dictionary<string, string>();
						num = 14;
						goto _goto_5;
					case 0:
						return;
					}
					continue;
					_goto_5:
					break;
				}
				break;
			}
		}
	}

	public static Dictionary<string, CurveXYZ> curvexyzParam()
	{
		return null;
	}

	public static Dictionary<string, CurveXYZ> curvexyzParam()
	{
		return null;
	}

	public static bool boolParam(diem diemParam, diem diemParam, diem diemParam, diem diemParam, int intParam = 500)
	{
		return true;
	}

	public static void voidParam()
	{
	}

	public static void voidParam(int intParam)
	{
	}

	public static void voidParam()
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass403Param()
	{
		return null;
	}
}
