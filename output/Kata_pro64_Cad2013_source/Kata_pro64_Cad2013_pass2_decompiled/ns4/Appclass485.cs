using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Kata_Class_Lib_Revit;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	private struct AppStruct_486
	{
		public int intParam;

		public int intParam;

		public int intParam;

		public int intParam;
	}

	private struct AppStruct_487
	{
		public int intParam;

		public int intParam;
	}

	private static GetStatic_1 _appclass485_1;

	public string stringParam(string stringParam, diem diemParam, diem diemParam)
	{
		return null;
	}

	private void voidParam()
	{
	}

	private void voidParam(string stringParam)
	{
	}

	private void voidParam()
	{
	}

	private void voidParam(string stringParam, diem diemParam, diem diemParam)
	{
	}

	private Bitmap bitmapParam(Bitmap bitmapParam, diem diemParam, diem diemParam)
	{
		return null;
	}

	private int intParam(double doubleParam, double doubleParam, double doubleParam, int intParam)
	{
		return _return_3;
	}

	private int intParam(double doubleParam, double doubleParam, double doubleParam, int intParam)
	{
		return _return_3;
	}

	private Rectangle rectangleParam(int intParam, int intParam, int intParam, int intParam, int intParam, int intParam)
	{
		return (Rectangle)(object)null;
	}

	private IntPtr intptrParam()
	{
		return (IntPtr)(object)null;
	}

	private string stringParam(string stringParam)
	{
		return null;
	}

	private string stringParam(string stringParam)
	{
		return null;
	}

	[DllImport("user32.dll")]
	private static extern bool GetClientRect(IntPtr intptrParam, ref AppStruct_486 struct1_0);

	[DllImport("user32.dll")]
	private static extern bool ClientToScreen(IntPtr intptrParam, ref AppStruct_487 struct2_0);

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
					case 1:
						AppClass_969.smethod_3();
						num3 = _return_3;
						if (AppClass_031.class730_0.int_51 != _return_3)
						{
							continue;
						}
						goto _goto_7;
					default:
						do
						{
							switch (num2)
							{
							case 9:
								break;
							case 990:
								goto _goto_5;
							default:
								goto _goto_7;
							}
							AppClass_960.smethod_15();
							num3 = 1;
						}
						while (AppClass_031.class730_0.int_13 != _return_3);
						continue;
					case 2:
						goto _goto_7;
					case _return_3:
						return;
						_goto_5:
						break;
					}
					break;
				}
				continue;
				_goto_7:
				break;
			}
			AppClass_960.smethod_13();
			num = 9;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass485Param()
	{
		return null;
	}
}
