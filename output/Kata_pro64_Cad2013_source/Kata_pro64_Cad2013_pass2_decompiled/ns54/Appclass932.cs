using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns54;

[StandardModule]
internal sealed class GetStatic_1
{
	private static object objectParam;

	public static int intParam(int intParam)
	{
		return _return_1;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam)
	{
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
					case 1:
						AppClass_960.smethod_13();
						num3 = _return_1;
						if (AppClass_031.class730_0.int_17 != _return_1)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							AppClass_969.voidParam();
							return;
						}
						goto _goto_2;
					case _return_1:
						break;
					case 2:
						return;
					}
					goto _goto_3;
					continue;
					_goto_2:
					break;
				}
				continue;
				_goto_3:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_72 == _return_1)
			{
				num = 1;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass932Param()
	{
		return null;
	}
}
