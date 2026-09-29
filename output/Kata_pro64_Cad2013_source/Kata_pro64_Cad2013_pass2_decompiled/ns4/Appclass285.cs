using System;
using System.Runtime.InteropServices;
using System.Text;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	private bool boolParam;

	private string _string_1;

	internal static GetStatic_1 _appclass285_2;

	public bool Boolean_0 => true;

	[DllImport("winmm.dll", CharSet = CharSet.Auto)]
	private static extern int mciSendString(string stringParam, StringBuilder stringBuilder_0, int intParam, IntPtr intptrParam);

	[DllImport("winmm.dll", CharSet = CharSet.Auto)]
	private static extern bool mciGetErrorString(int intParam, StringBuilder stringBuilder_0, int intParam);

	public string stringParam(string stringParam)
	{
		return null;
	}

	public string stringParam()
	{
		return null;
	}

	public void voidParam()
	{
	}

	private static void voidParam(object objectParam)
	{
	}

	private static string stringParam(object objectParam)
	{
		return null;
	}

	private static void voidParam()
	{
	}

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
		int num = 2;
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
					case 2:
						AppClass_960.smethod_13();
						num3 = 1;
						if (AppClass_031.class730_0.int_73 != 0)
						{
							continue;
						}
						goto default;
					case 1:
						AppClass_960.smethod_15();
						num3 = 4;
						if (AppClass_031.class730_0.int_65 != 0)
						{
							continue;
						}
						break;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_3;
					case 0:
						break;
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
			while (num2 == 990);
			AppClass_969.boolParam();
			num = 7;
			if (AppClass_031.class730_0.int_56 == 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass285Param()
	{
		return null;
	}
}
