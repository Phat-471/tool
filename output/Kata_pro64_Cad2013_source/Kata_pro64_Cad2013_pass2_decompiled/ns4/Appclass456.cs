using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

public class GetStatic_1
{
	private static bool boolParam;

	private static GetStatic_1 _appclass456_1;

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
					case 4:
						boolParam = false;
						num3 = 3;
						if (AppClass_031.class730_0.int_91 != 0)
						{
							continue;
						}
						goto case 2;
					case 2:
						AppClass_969.stringParam();
						num3 = 5;
						if (AppClass_031.class730_0.int_32 != 0)
						{
							continue;
						}
						goto case 0;
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto _goto_2;
							}
							goto case 4;
						}
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_20 != 0)
						{
							continue;
						}
						goto case 0;
					case 1:
						AppClass_960.smethod_13();
						num = 3;
						if (AppClass_031.class730_0.int_12 == 0)
						{
							num = 11;
						}
						break;
					case 0:
						AppClass_967.appclass452Param();
						num = 4;
						break;
					case 3:
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
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool GetExternBool_2(string stringParam);

	public static AppClass_452 appclass452Param(string stringParam)
	{
		return null;
	}

	public static Bitmap bitmapParam(string stringParam, AppClass_450 gclass22_0, float floatParam)
	{
		return null;
	}

	private static void voidParam()
	{
	}

	private static string stringParam()
	{
		return null;
	}

	public static Bitmap bitmapParam(string stringParam, AppClass_450 gclass22_0, AppClass_451 gclass23_0, int intParam, int intParam)
	{
		return null;
	}

	public static void voidParam(string stringParam, IList<AppClass_451> ilistAppclass451Param, string stringParam)
	{
	}

	private static void voidParam(object objectParam, object objectParam, int intParam, float floatParam, float floatParam, float floatParam, float floatParam)
	{
	}

	private static Bitmap bitmapParam(object objectParam, int intParam, int intParam)
	{
		return null;
	}

	private static Rectangle rectangleParam(Rectangle rectangleParam, Size sizeParam)
	{
		return (Rectangle)(object)null;
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass456Param()
	{
		return null;
	}
}
