using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns32;

[StandardModule]
internal sealed class GetStatic_2
{
	public struct AppStruct_240
	{
		public string _string_3;

		public int intParam;

		public int intParam;

		public int intParam;

		public int intParam;

		public string _string_4;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;
	}

	public struct AppStruct_241
	{
		public string _string_3;

		public int intParam;

		public int intParam;

		public int intParam;

		public int intParam;

		public string _string_4;

		public object objectParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_1
	{
		public static readonly GetStatic_1 _appclass242_5;

		public static Comparison<Polygon> comparisonPolygonParam;

		private static GetStatic_1 _appclass242_6;

		static GetStatic_1()
		{
			AppClass_960.smethod_23();
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					_goto_7:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 3:
							AppClass_960.appclass239Param();
							goto case 2;
						case 2:
							AppClass_960.smethod_15();
							num3 = _return_9;
							if (AppClass_031.class730_0.int_44 == _return_9)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							default:
								return;
							case 992:
								break;
							case 11:
								_appclass242_5 = new GetStatic_1();
								return;
							}
							goto _goto_7;
						case _return_9:
							break;
						case 4:
							goto _goto_8;
						case 1:
							return;
						}
						break;
					}
					AppClass_969.boolParam();
					num = 4;
					break;
					_goto_8:
					AppClass_967.boolParam();
					num = 1;
					if (AppClass_031.class730_0.int_106 == _return_9)
					{
						num = 11;
					}
					break;
				}
			}
		}

		[SpecialName]
		internal int intParam(Polygon polygonParam, Polygon polygonParam)
		{
			return _return_9;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass242Param()
		{
			return null;
		}
	}

	private static SortedDictionary<long, diem> sortedDictionary_0;

	private static List<Polygon> _listPolygon_10;

	private static List<AppStruct_240> _listAppstruct240_11;

	private static List<AppStruct_241> _listAppstruct241_12;

	private static SortedDictionary<long, string> sortedDictionary_1;

	private static Dictionary<string, object> objectParam;

	private static object objectParam;

	private static double doubleParam;

	private static double doubleParam;

	private static double doubleParam;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	private static List<int> _listInt_13;

	private static List<int> _listInt_14;

	private static object objectParam;

	private static object objectParam;

	private static object objectParam;

	internal static object objectParam;

	static GetStatic_2()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		AppClass_960.smethod_23();
		int num = 13;
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
					case 13:
						AppClass_960.appclass239Param();
						goto case 12;
					case 12:
						AppClass_960.smethod_15();
						goto case 4;
					case 4:
						AppClass_969.boolParam();
						goto case 11;
					case 11:
						AppClass_967.boolParam();
						goto case 5;
					case 5:
						sortedDictionary_0 = new SortedDictionary<long, diem>();
						num3 = 8;
						if (AppClass_031.class730_0.int_57 == _return_9)
						{
							continue;
						}
						goto case 10;
					case 10:
						objectParam = (object)new diem();
						num3 = _return_9;
						if (AppClass_031.class730_0.int_13 == _return_9)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 20)
						{
							objectParam = (object)new diem();
							goto case 9;
						}
						if (num2 == 1001)
						{
							goto _goto_15;
						}
						goto case 2;
					case 9:
						objectParam = (object)new diem();
						goto case 10;
					case 2:
						do
						{
							sortedDictionary_1 = new SortedDictionary<long, string>();
							num3 = 6;
						}
						while (AppClass_031.class730_0.int_68 == _return_9);
						continue;
					case 8:
						_listPolygon_10 = new List<Polygon>();
						num3 = 3;
						if (AppClass_031.class730_0.int_25 != _return_9)
						{
							continue;
						}
						goto case 13;
					case 6:
						_listInt_13 = new List<int>();
						num3 = 7;
						if (AppClass_031.class730_0.int_113 != _return_9)
						{
							continue;
						}
						goto case 3;
					case 3:
						do
						{
							_listAppstruct240_11 = new List<AppStruct_240>();
							num3 = 1;
						}
						while (AppClass_031.class730_0.int_117 == _return_9);
						continue;
					case 1:
						_listAppstruct241_12 = new List<AppStruct_241>();
						num3 = 11;
						if (AppClass_031.class730_0.int_113 == _return_9)
						{
							continue;
						}
						goto case 2;
					case 7:
						break;
					case _return_9:
						return;
					}
					goto _goto_16;
					continue;
					_goto_15:
					break;
				}
				continue;
				_goto_16:
				break;
			}
			_listInt_14 = new List<int>();
			num = 11;
			if (AppClass_031.class730_0.int_39 == _return_9)
			{
				num = 20;
			}
		}
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static Polygon appclass242Param(object objectParam)
	{
		return null;
	}

	public static double doubleParam(ref double doubleParam, object objectParam, int intParam = _return_9)
	{
		return _return_9._return_9;
	}

	public static bool boolParam()
	{
		return true;
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam, object objectParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(ref diem[] diem_0, ref diem[] diem_1, ref int intParam, ref int intParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass239Param()
	{
		return null;
	}
}
