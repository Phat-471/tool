using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	internal static GetStatic_1 _appclass426_1;

	public void voidParam(ref Polygon polygonParam, int intParam = 50)
	{
	}

	public void voidParam(ref List<info_revit_thep> listInfoRevitThepParam)
	{
	}

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
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
						AppClass_960.smethod_13();
						num3 = 4;
						if (AppClass_031.class730_0.int_83 == 0)
						{
							continue;
						}
						goto _goto_5;
					default:
						switch (num2)
						{
						case 9:
							break;
						case 990:
							goto _goto_3;
						default:
							goto _goto_5;
						}
						AppClass_969.smethod_3();
						num3 = 8;
						if (AppClass_031.class730_0.int_113 == 0)
						{
							continue;
						}
						return;
					case 0:
						goto _goto_5;
					case 2:
						return;
						_goto_3:
						break;
					}
					break;
				}
				continue;
				_goto_5:
				break;
			}
			AppClass_960.smethod_15();
			num = 9;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass426Param()
	{
		return null;
	}
}
