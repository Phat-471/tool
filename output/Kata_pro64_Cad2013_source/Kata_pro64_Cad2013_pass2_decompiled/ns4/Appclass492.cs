using System.Collections.Generic;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	public List<int> _listInt_1;

	public List<int> _listInt_2;

	public bool boolParam;

	private static GetStatic_1 _appclass492_3;

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
						num3 = 6;
						if (AppClass_031.class730_0.int_77 != 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						AppClass_960.smethod_15();
						num3 = 3;
						if (AppClass_031.class730_0.int_70 == 0)
						{
							continue;
						}
						break;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_4;
							}
							goto case 2;
						}
						return;
					case 0:
						break;
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
			AppClass_969.smethod_3();
			num = 9;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass492Param()
	{
		return null;
	}
}
