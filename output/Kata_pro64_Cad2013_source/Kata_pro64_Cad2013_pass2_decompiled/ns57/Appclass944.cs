using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns57;

[StandardModule]
internal sealed class GetStatic_2
{
	private static object objectParam;

	internal static object objectParam;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetExternShort_1(int intParam);

	public static bool boolParam()
	{
		return true;
	}

	static GetStatic_2()
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
						if (AppClass_031.class730_0.int_83 != 0)
						{
							continue;
						}
						goto case 0;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_1;
							}
							goto case 0;
						}
						return;
					case 0:
						AppClass_960.smethod_15();
						num = 2;
						break;
					case 2:
						AppClass_969.smethod_3();
						num = 9;
						if (AppClass_031.class730_0.int_83 == 0)
						{
							num = 2;
						}
						break;
					}
					goto _goto_2;
					continue;
					_goto_1:
					break;
				}
				continue;
				_goto_2:
				break;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass944Param()
	{
		return null;
	}
}
