using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns50;

[StandardModule]
internal sealed class GetStatic_1
{
	public struct AppStruct_929
	{
		public string _string_1;

		public int intParam;

		public string _string_2;

		public string _string_3;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;
	}

	public static object objectParam;

	public static bool boolParam;

	public static Dictionary<object, AppStruct_929> appstruct929Param;

	private static object objectParam;

	public static void voidParam()
	{
	}

	public static void voidParam(ref info_revit_thep info_revit_thep_0, object objectParam, double doubleParam)
	{
	}

	public static info_revit_thep infoRevitThepParam()
	{
		return null;
	}

	public static info_revit_thep infoRevitThepParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(ref object objectParam, AppStruct_929 struct25_0)
	{
	}

	public static AppStruct_929 appstruct929Param(object objectParam)
	{
		return (AppStruct_929)(object)null;
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
					default:
						if (num2 != 9)
						{
							goto _goto_4;
						}
						AppClass_960.smethod_15();
						num3 = 1;
						if (AppClass_031.class730_0.int_18 != 0)
						{
							continue;
						}
						goto case 0;
					case 1:
						break;
					case 0:
						AppClass_969.infoRevitThepParam();
						return;
					case 2:
						return;
					}
					goto _goto_5;
					continue;
					_goto_4:
					break;
				}
				continue;
				_goto_5:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_13();
			num = 9;
			if (AppClass_031.class730_0.int_68 == 0)
			{
				num = 6;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass928Param()
	{
		return null;
	}
}
