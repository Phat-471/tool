using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_1
{
	internal static GetStatic_1 _appclass312_1;

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
					_goto_3:
					switch (num3)
					{
					case 2:
						AppClass_960.smethod_13();
						num3 = 1;
						if (AppClass_031.class730_0.int_20 != 0)
						{
							continue;
						}
						return;
					case 1:
						goto _goto_2;
					case 0:
						return;
						_goto_6:
						while (num2 == 9)
						{
							AppClass_969.smethod_3();
							num3 = 0;
							if (AppClass_031.class730_0.int_91 == 0)
							{
								continue;
							}
							goto _goto_3;
						}
						goto _goto_4;
						_goto_4:
						if (num2 == 990)
						{
							goto _goto_5;
						}
						goto case 2;
					}
					goto _goto_6;
					continue;
					_goto_5:
					break;
				}
				continue;
				_goto_2:
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

	internal static GetStatic_1 appclass312Param()
	{
		return null;
	}
}
