using System.Collections.Generic;
using System.Runtime.InteropServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_2
{
	public class GetStatic_1
	{
		public int intParam;

		public double[] doubleParam;

		private static GetStatic_1 _appclass415_8;

		static GetStatic_1()
		{
			AppClass_960.voidParam();
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
							AppClass_960.boolParam();
							num3 = 9;
							if (AppClass_031.class730_0.int_64 == _return_34)
							{
								continue;
							}
							goto case _return_34;
						case _return_34:
							AppClass_960.intParam();
							num3 = 8;
							if (AppClass_031.class730_0.int_117 == _return_34)
							{
								continue;
							}
							break;
						default:
							if (num2 == 9)
							{
								return;
							}
							goto _goto_2;
						case 2:
							break;
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
				AppClass_969.boolParam();
				num = 9;
				if (AppClass_031.class730_0.int_95 == _return_34)
				{
					num = _return_34;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass415Param()
		{
			return null;
		}
	}

	public struct AppStruct_416
	{
		public int intParam;

		public int intParam;

		public string _string_16;
	}

	public struct AppStruct_417
	{
		public string _string_16;

		public int intParam;

		public string _string_17;
	}

	public static List<string> _listString_7;

	public static GetStatic_1 _appclass415_8;

	public static Dictionary<string, List<object>> listObjectParam;

	public static Dictionary<string, List<object>> listObjectParam;

	public static Dictionary<string, object> objectParam;

	public static Dictionary<string, object> objectParam;

	public static List<string> _listString_9;

	public static List<object> _listObject_10;

	public static List<diem> _listDiem_11;

	public static List<diem> _listDiem_12;

	public static List<diem> _listDiem_13;

	public static object objectParam;

	public static AppForm_823 _appform823_14;

	public static object objectParam;

	public static bool boolParam;

	public static AppForm_881 _appform881_15;

	public static Dictionary<string, AppStruct_416> appstruct416Param;

	private static object objectParam;

	private static object objectParam;

	private static int intParam;

	private static int intParam;

	private static int intParam;

	private static int intParam;

	private static string _string_16;

	private static string _string_17;

	private static string _string_18;

	private static string[] _stringarray_19;

	private static short[] _shortarray_20;

	private static object[] object_4;

	private static string _string_21;

	private static string _string_22;

	private static string _string_23;

	private static GetStatic_2 _appclass414_24;

	public static int Int32_0 => _return_34;

	static GetStatic_2()
	{
		AppClass_960.voidParam();
		int num = 11;
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
					case 18:
						AppClass_967.boolParam();
						num3 = _return_34;
						if (AppClass_031.class730_0.int_53 != _return_34)
						{
							continue;
						}
						goto case 9;
					case 14:
						_listDiem_11 = new List<diem>();
						num3 = 1;
						if (AppClass_031.class730_0.int_30 != _return_34)
						{
							continue;
						}
						goto case 5;
					case 5:
						_listDiem_12 = new List<diem>();
						goto case 12;
					case 12:
						_listDiem_13 = new List<diem>();
						goto case 3;
					case 3:
						_appform823_14 = new AppForm_823();
						num3 = 2;
						if (AppClass_031.class730_0.int_81 == _return_34)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 26)
						{
							AppClass_960.intParam();
							goto case 6;
						}
						if (num2 == 1007)
						{
							goto _goto_25;
						}
						goto case 11;
					case 6:
						AppClass_969.boolParam();
						goto case 18;
					case 9:
						_listObject_10 = new List<object>();
						goto case 14;
					case 15:
						_appclass415_8 = new GetStatic_1();
						num3 = 3;
						if (AppClass_031.class730_0.intParam == _return_34)
						{
							continue;
						}
						goto case 1;
					case 8:
						_listString_9 = new List<string>();
						num3 = 21;
						if (AppClass_031.class730_0.int_96 != _return_34)
						{
							continue;
						}
						goto case 9;
					case 7:
						_appform881_15 = new AppForm_881();
						num3 = 13;
						if (AppClass_031.class730_0.int_39 == _return_34)
						{
							continue;
						}
						goto case 16;
					case 2:
						boolParam = false;
						num3 = 7;
						if (AppClass_031.class730_0.int_114 == _return_34)
						{
							continue;
						}
						goto case 12;
					case _return_34:
						_listString_7 = new List<string>();
						goto case 15;
					case 13:
						appstruct416Param = new Dictionary<string, AppStruct_416>();
						num = 16;
						break;
					case 1:
						listObjectParam = new Dictionary<string, List<object>>();
						goto case 19;
					case 11:
						AppClass_960.boolParam();
						num = 26;
						break;
					case 19:
						listObjectParam = new Dictionary<string, List<object>>();
						goto case 4;
					case 4:
						objectParam = new Dictionary<string, object>();
						goto case 10;
					case 10:
						objectParam = new Dictionary<string, object>();
						num = 8;
						break;
					case 16:
						_stringarray_19 = new string[8];
						return;
					case 17:
						return;
					}
					goto _goto_26;
					continue;
					_goto_25:
					break;
				}
				continue;
				_goto_26:
				break;
			}
		}
	}

	public static void boolParam(string stringParam)
	{
	}

	public static bool appclass415Param(string stringParam)
	{
		return true;
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static void voidParam(string stringParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam, ref string stringParam, ref int intParam, ref int intParam)
	{
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static void voidParam(diem diemParam, diem diemParam)
	{
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(string stringParam, string[] stringParam, string[] stringParam)
	{
		return true;
	}

	public static bool boolParam(string stringParam, string stringParam)
	{
		return true;
	}

	public static int intParam(ref string stringParam)
	{
		return _return_34;
	}

	public static int intParam(string stringParam, string stringParam, int intParam, string[] stringParam, int intParam = _return_34, string stringParam = "", string stringParam = "")
	{
		return _return_34;
	}

	public static bool boolParam(string stringParam, ref int intParam, ref int intParam, ref string stringParam, ref string stringParam, ref string stringParam, ref string stringParam, ref string stringParam, diem diemParam, string stringParam = "")
	{
		return true;
	}

	public static int intParam(diem diemParam, List<object> listObjectParam, int intParam)
	{
		return _return_34;
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(string stringParam, int intParam)
	{
		return true;
	}

	public static string stringParam(string stringParam, int intParam, string stringParam)
	{
		return null;
	}

	public static string stringParam(string stringParam, string stringParam, string stringParam, int intParam, string stringParam, int intParam, string stringParam)
	{
		return null;
	}

	public static string stringParam(int intParam, string stringParam, int intParam, int intParam, string stringParam, int intParam, string stringParam, string stringParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam = "", object objectParam = "", object objectParam = "", object objectParam = "")
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static int intParam(double doubleParam, int intParam)
	{
		return _return_34;
	}

	public static int intParam(object objectParam, string stringParam)
	{
		return _return_34;
	}

	public static void voidParam(ref string stringParam, ref int intParam, ref int intParam, ref string stringParam, ref string stringParam, ref string stringParam, ref string[] stringParam, ref int intParam, ref string stringParam, ref string stringParam, [Optional][DefaultParameterValue("")] ref string stringParam, [Optional][DefaultParameterValue("")] ref string stringParam, [Optional][DefaultParameterValue("")] ref string stringParam)
	{
	}

	public static bool boolParam(ref object objectParam)
	{
		return true;
	}

	public static int intParam(object[] objectParam, ref int intParam, ref int intParam)
	{
		return _return_34;
	}

	public static int intParam(ref object objectParam, ref object objectParam)
	{
		return _return_34;
	}

	public static int intParam(diem diemParam, diem diemParam, ref diem[] diem_2, ref int intParam)
	{
		return _return_34;
	}

	public static void voidParam(ref diem[] diemParam, int intParam, int intParam, double doubleParam, double doubleParam)
	{
	}

	public static void voidParam(object objectParam, ref diem diemParam, ref diem diemParam)
	{
	}

	public static string stringParam(int intParam, string stringParam, int intParam, ref string stringParam)
	{
		return null;
	}

	public static void voidParam(ref object objectParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(int intParam = 90)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(object objectParam = null)
	{
		return true;
	}

	public static void voidParam()
	{
	}

	public static void voidParam(diem[] diemParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(int intParam, int intParam, int intParam)
	{
	}

	public static void voidParam()
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass414Param()
	{
		return null;
	}
}
