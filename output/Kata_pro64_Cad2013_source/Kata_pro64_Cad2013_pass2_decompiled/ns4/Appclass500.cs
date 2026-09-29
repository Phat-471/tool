using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_1
{
	public static AppClass_493 _appclass493_1;

	public static AppClass_494 _appclass494_2;

	public static AppClass_502 _appclass502_3;

	public static AppClass_504 _appclass504_4;

	public static string _string_5;

	public static string _string_6;

	private static GetStatic_1 _appclass500_7;

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
		int num = 7;
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
					case 9:
						_appclass494_2 = null;
						num3 = 8;
						if (AppClass_031.class730_0.int_70 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						_appclass502_3 = null;
						num3 = 4;
						if (AppClass_031.class730_0.int_68 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto _goto_8;
							}
							goto case 9;
						}
						_string_5 = "";
						num3 = 5;
						if (AppClass_031.class730_0.int_63 == 0)
						{
							continue;
						}
						goto case 0;
					case 7:
						AppClass_960.smethod_13();
						num3 = 0;
						if (AppClass_031.class730_0.int_26 == 0)
						{
							continue;
						}
						goto case 6;
					case 6:
						AppClass_960.smethod_15();
						goto case 3;
					case 3:
						AppClass_969.smethod_3();
						goto case 2;
					case 2:
						AppClass_967.boolParam();
						goto case 5;
					case 5:
						_appclass493_1 = null;
						goto case 9;
					case 4:
						_appclass504_4 = null;
						num = 16;
						break;
					case 0:
						_string_6 = "";
						num = 8;
						break;
					case 8:
						return;
					}
					goto _goto_9;
					continue;
					_goto_8:
					break;
				}
				continue;
				_goto_9:
				break;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass500Param()
	{
		return null;
	}
}
