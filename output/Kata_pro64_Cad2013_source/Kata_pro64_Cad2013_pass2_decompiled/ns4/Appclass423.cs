using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	private static GetStatic_1 _appclass423_1;

	public bool boolParam(ref List<Info_Beam3D> listInfoBeam3dParam, ref List<Info_ColumnWall3D> listInfoColumnwall3dParam, ref List<Info_Slab3D> listInfoSlab3dParam, ref List<info_CurveGrid> listInfoCurvegridParam)
	{
		return true;
	}

	public void voidParam(diem diemParam, diem diemParam, string stringParam)
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
						num3 = 0;
						if (AppClass_031.class730_0.int_31 != 0)
						{
							continue;
						}
						break;
					case 0:
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_47 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto _goto_2;
						_goto_5:
						if (num2 != 9)
						{
							goto _goto_3;
						}
						return;
						_goto_3:
						if (num2 == 990)
						{
							goto _goto_4;
						}
						goto case 1;
					}
					goto _goto_5;
					continue;
					_goto_4:
					break;
				}
				continue;
				_goto_2:
				break;
			}
			AppClass_969.smethod_3();
			num = 9;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass423Param()
	{
		return null;
	}
}
