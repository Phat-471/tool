using System.Collections.Generic;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	public double doubleParam;

	public int intParam;

	public int intParam;

	public string _string_1;

	public int intParam;

	public bool boolParam;

	public List<AppClass_316> _listAppclass316_2;

	internal static GetStatic_1 _appclass317_3;

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
						if (AppClass_031.class730_0.int_46 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_19 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto _goto_4;
						_goto_7:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_5;
						_goto_5:
						if (num2 == 990)
						{
							goto _goto_6;
						}
						goto case 0;
					}
					goto _goto_7;
					continue;
					_goto_6:
					break;
				}
				continue;
				_goto_4:
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

	internal static GetStatic_1 appclass317Param()
	{
		return null;
	}
}
