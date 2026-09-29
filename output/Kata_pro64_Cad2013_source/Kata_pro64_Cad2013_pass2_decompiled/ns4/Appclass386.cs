using System;
using System.IO;
using System.Security.Cryptography;
using ns61;
using ns62;
using ns64;

namespace ns4;

public sealed class GetPrivate_2
{
	private static readonly string _string_1;

	private static readonly string _string_2;

	private static readonly string _string_3;

	private static readonly string _string_4;

	private static readonly string _string_5;

	private static readonly string _string_6;

	private static readonly byte[] byte_0;

	private static readonly object objectParam;

	private static readonly string _string_7;

	private static AppClass_357 _appclass357_8;

	internal static GetPrivate_2 _appclass386_9;

	static GetPrivate_2()
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
					case 12:
						_string_6 = AppDelegate_902.stringParam(_string_1, AppClass_960.boolParam(0x408A8D4F ^ AppClass_031.class730_0.int_76), AppDelegate_902.delegate182_0);
						num3 = 0;
						if (AppClass_031.class730_0.int_114 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 19)
						{
							AppClass_960.stringParam();
							num3 = 2;
							if (AppClass_031.class730_0.int_37 != 0)
							{
								continue;
							}
							goto case 5;
						}
						if (num2 == 1000)
						{
							goto _goto_10;
						}
						goto case 9;
					case 5:
						AppClass_969.appclass383Param();
						num3 = 8;
						if (AppClass_031.class730_0.int_49 != 0)
						{
							continue;
						}
						goto case 8;
					case 8:
						AppClass_967.stringParam();
						num3 = 4;
						if (AppClass_031.class730_0.int_115 == 0)
						{
							continue;
						}
						goto case 5;
					case 11:
						objectParam = AppDelegate_1431.stringParam(new object(), AppDelegate_1431.delegate23_0);
						num3 = 4;
						if (AppClass_031.class730_0.int_69 != 0)
						{
							continue;
						}
						goto case 10;
					case 4:
						_string_1 = AppDelegate_019.stringParam(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), AppClass_960.boolParam(0x79D8D39A ^ AppClass_031.class730_0.int_54), AppClass_960.boolParam(0x345FF483 ^ AppClass_031.class730_0.int_63), AppDelegate_019.delegate1014_0);
						num3 = 10;
						if (AppClass_031.class730_0.int_69 != 0)
						{
							continue;
						}
						goto case 9;
					case 3:
						_string_5 = AppDelegate_902.stringParam(_string_1, AppClass_960.boolParam(0x15993A24 ^ AppClass_031.class730_0.int_28), AppDelegate_902.delegate182_0);
						goto case 12;
					case 0:
						byte_0 = AppDelegate_475.stringParam(AppDelegate_1100.stringParam(AppDelegate_1100.delegate200_0), AppClass_960.boolParam(0x42C96C7F ^ AppClass_031.class730_0.int_82), AppDelegate_475.delegate1431_0);
						goto case 11;
					case 1:
						AppClass_960.boolParam();
						num = 19;
						if (AppClass_031.class730_0.int_98 == 0)
						{
							num = 18;
						}
						break;
					case 9:
						_string_2 = AppDelegate_902.stringParam(_string_1, AppClass_960.boolParam(0x2A05E72F ^ AppClass_031.class730_0.int_19), AppDelegate_902.delegate182_0);
						goto case 7;
					case 7:
						_string_3 = AppDelegate_902.stringParam(_string_1, AppClass_960.boolParam(0x1E68FEB2 ^ AppClass_031.class730_0.int_51), AppDelegate_902.delegate182_0);
						goto case 2;
					case 2:
						_string_4 = AppDelegate_902.stringParam(_string_1, AppClass_960.boolParam(0x51AD9B6C ^ AppClass_031.class730_0.int_8), AppDelegate_902.delegate182_0);
						num = 3;
						break;
					case 10:
						_string_7 = AppDelegate_902.stringParam(_string_1, AppClass_960.boolParam(0x79D3A872 ^ AppClass_031.class730_0.int_54), AppDelegate_902.delegate182_0);
						return;
					case 6:
						return;
					}
					goto _goto_11;
					continue;
					_goto_10:
					break;
				}
				continue;
				_goto_11:
				break;
			}
		}
	}

	private GetPrivate_2()
	{
	}

	public static string stringParam(string stringParam, string stringParam)
	{
		return null;
	}

	public static void voidParam(string stringParam)
	{
	}

	public static bool boolParam()
	{
		return true;
	}

	public static AppClass_383 appclass383Param()
	{
		return null;
	}

	public static void voidParam(AppClass_383 gclass174_0)
	{
	}

	public static string stringParam()
	{
		return null;
	}

	internal static FileStream filestreamParam()
	{
		return null;
	}

	public static AppClass_372 appclass372Param()
	{
		return null;
	}

	public static void voidParam(AppClass_372 gclass163_0)
	{
	}

	public static RSACryptoServiceProvider rsacryptoserviceproviderParam(bool boolParam)
	{
		return null;
	}

	public static string stringParam(RSACryptoServiceProvider rsacryptoServiceProvider_0)
	{
		return null;
	}

	private static AppClass_357 appclass357Param()
	{
		return null;
	}

	internal static bool boolParam(object objectParam)
	{
		return true;
	}

	internal static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	private static void voidParam()
	{
	}

	private static string stringParam(object objectParam)
	{
		return null;
	}

	private static void voidParam(object objectParam, object objectParam)
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetPrivate_2 appclass386Param()
	{
		return null;
	}
}
