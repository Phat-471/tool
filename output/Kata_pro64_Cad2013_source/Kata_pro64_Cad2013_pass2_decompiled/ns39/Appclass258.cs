using System;
using System.Runtime.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns39;

internal sealed class GetPrivate_2
{
	private static readonly object objectParam;

	private static long _long_1;

	private static long _long_2;

	private static long _long_3;

	private static long _long_4;

	private static object objectParam;

	static GetPrivate_2()
	{
		AppClass_960.smethod_23();
		int num = 3;
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
					case 4:
						AppClass_967.boolParam();
						num3 = 1;
						if (AppClass_031.class730_0.int_69 != 0)
						{
							continue;
						}
						break;
					case 3:
						AppClass_960.smethod_13();
						goto case 2;
					case 2:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_117 != 0)
						{
							continue;
						}
						goto case 4;
					case 0:
						AppClass_969.datetimeParam();
						goto case 4;
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto _goto_5;
							}
							goto case 4;
						}
						return;
					case 1:
						break;
					}
					goto _goto_6;
					continue;
					_goto_5:
					break;
				}
				continue;
				_goto_6:
				break;
			}
			objectParam = AppDelegate_1431.boolParam(new object(), AppDelegate_1431.delegate23_0);
			num = 11;
		}
	}

	private GetPrivate_2()
	{
	}

	[SpecialName]
	internal static bool boolParam()
	{
		return true;
	}

	[SpecialName]
	internal static long longParam()
	{
		return _return_8;
	}

	internal static long longParam()
	{
		return _return_8;
	}

	[SpecialName]
	internal static DateTime datetimeParam()
	{
		return (DateTime)(object)null;
	}

	internal static bool boolParam(bool boolParam = false)
	{
		return true;
	}

	private static string stringParam(object objectParam)
	{
		return null;
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetPrivate_2 appclass258Param()
	{
		return null;
	}
}
