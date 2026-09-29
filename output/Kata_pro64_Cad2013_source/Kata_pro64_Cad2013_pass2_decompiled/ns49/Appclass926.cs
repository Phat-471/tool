using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns49;

[StandardModule]
internal sealed class GetStatic_1
{
	public static List<info_revit_thep> _listInfoRevitThep_1;

	public static object objectParam;

	public static List<info_revit_mc_ngang_dam> _listInfoRevitMcNgangDam_2;

	public static object objectParam;

	public static object objectParam;

	public static List<info_revit_thep_ngang> _listInfoRevitThepNgang_3;

	public static object objectParam;

	private static object objectParam;

	public static double doubleParam(int intParam, int intParam, int intParam)
	{
		return _return_4._return_4;
	}

	public static int intParam(object objectParam)
	{
		return _return_4;
	}

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
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
						goto _goto_5;
					default:
						if (num2 == 9)
						{
							AppClass_969.appclass926Param();
							return;
						}
						goto _goto_6;
					case _return_4:
						break;
					case 2:
						return;
					}
					goto _goto_8;
					_goto_5:
					AppClass_960.smethod_13();
					num3 = 9;
					if (AppClass_031.class730_0.int_101 == _return_4)
					{
						goto _goto_8;
					}
					continue;
					_goto_6:
					break;
				}
				continue;
				_goto_8:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_71 == _return_4)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass926Param()
	{
		return null;
	}
}
