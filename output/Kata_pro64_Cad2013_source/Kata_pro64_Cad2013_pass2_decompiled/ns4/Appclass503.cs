using System.Collections.Generic;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	public int intParam;

	public List<string> _listString_1;

	private static GetStatic_1 _appclass503_2;

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
					case 2:
						AppClass_969.smethod_3();
						num3 = 0;
						if (AppClass_031.class730_0.int_104 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_3;
							}
							goto case 1;
						}
						AppClass_960.smethod_15();
						num = 2;
						break;
					case 1:
						AppClass_960.smethod_13();
						num = 9;
						if (AppClass_031.class730_0.int_112 == 0)
						{
							num = 7;
						}
						break;
					case 0:
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
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass503Param()
	{
		return null;
	}
}
