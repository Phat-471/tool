using System;
using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1 : IDisposable
{
	public Dictionary<string, Info_ColumnWall3D> infoColumnwall3dParam;

	public Dictionary<string, Info_Beam3D> infoBeam3dParam;

	public Dictionary<string, Info_Slab3D> infoSlab3dParam;

	public Dictionary<string, Info_Slab3D> infoSlab3dParam;

	public Dictionary<string, info_CurveGrid> infoCurvegridParam;

	public SortedDictionary<string, info_SecondBeam> sortedDictionary_0;

	public Dictionary<string, AppClass_436> appclass436Param;

	public Dictionary<string, AppClass_436> appclass436Param;

	public Dictionary<string, List<string>> listStringParam;

	public List<string> _listString_1;

	public Dictionary<string, object> objectParam;

	public Info_Slab3D _infoSlab3d_2;

	public bool boolParam;

	internal static GetStatic_1 _appclass437_3;

	public void voidParam(string stringParam, object objectParam, string stringParam = "", string stringParam = "", string stringParam = "")
	{
	}

	public void Dispose()
	{
	}

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
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
						AppClass_960.smethod_13();
						num3 = 1;
						if (AppClass_031.class730_0.int_36 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_4;
							}
							goto case 2;
						}
						AppClass_969.smethod_3();
						num3 = 8;
						if (AppClass_031.class730_0.int_106 != 0)
						{
							continue;
						}
						return;
					case 1:
						break;
					case 0:
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
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_47 != 0)
			{
				num = 5;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass437Param()
	{
		return null;
	}
}
