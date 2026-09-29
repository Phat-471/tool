using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns16;
using ns17;
using ns4;
using ns61;
using ns62;
using ns64;

namespace ns14;

[StandardModule]
internal sealed class GetStatic_32
{
	public enum Enum7
	{

	}

	public enum Enum8
	{

	}

	public class GetStatic_1 : IComparer<string>
	{
		private static readonly object objectParam;

		private static object objectParam;

		static GetStatic_1()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = 4;
							if (AppClass_031.class730_0.int_31 == _return_103)
							{
								continue;
							}
							goto case _return_103;
						default:
							if (num2 != 11)
							{
								goto _goto_66;
							}
							AppClass_967.boolParam();
							goto case 2;
						case _return_103:
							AppClass_960.voidParam();
							break;
						case 3:
							break;
						case 2:
							objectParam = new Regex(AppClass_960.voidParam(0x3846380C ^ AppClass_031.class730_0.int_91), RegexOptions.Compiled);
							return;
						case 4:
							return;
						}
						goto _goto_20;
						continue;
						_goto_66:
						break;
					}
					continue;
					_goto_20:
					break;
				}
				while (num2 == 992);
				AppClass_969.intParam();
				num = 1;
				if (AppClass_031.class730_0.int_78 != _return_103)
				{
					num = 11;
				}
			}
		}

		public int Compare(string _string_33, string stringParam)
		{
			return _return_103;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass064Param()
		{
			return null;
		}
	}

	private class GetStatic_2
	{
		public object objectParam;

		public List<string> _listPolygon_91;

		private static object objectParam;

		static GetStatic_2()
		{
			AppClass_960.polygonParam();
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						_goto_7:
						switch (num3)
						{
						case 1:
							goto _goto_5;
						case _return_103:
							AppClass_969.intParam();
							return;
						case 2:
							return;
						}
						while (true)
						{
							switch (num2)
							{
							case 9:
								goto _goto_53;
							default:
								return;
							case 990:
								break;
							}
							break;
							_goto_53:
							AppClass_960.voidParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_27 != _return_103)
							{
								continue;
							}
							goto _goto_7;
						}
						break;
					}
					continue;
					_goto_5:
					break;
				}
				AppClass_960.doubleParam();
				num = 9;
				if (AppClass_031.class730_0.int_15 != _return_103)
				{
					num = 6;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_2 appclass064Param()
		{
			return null;
		}
	}

	public class GetStatic_3
	{
		public object objectParam;

		public object objectParam;

		public object objectParam;

		public object objectParam;

		public bool boolParam;

		public bool boolParam;

		public int intParam;

		public object objectParam;

		public object objectParam;

		public double doubleParam;

		public object objectParam;

		public bool boolParam;

		public bool boolParam;

		public int intParam;

		public int intParam;

		public List<object> _listPolygon_91;

		public int intParam;

		public bool boolParam;

		public bool boolParam;

		public object objectParam;

		public int intParam;

		public object objectParam;

		public object objectParam;

		public object objectParam;

		internal static object objectParam;

		static GetStatic_3()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_65 != _return_103)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_9;
								}
								goto case 1;
							}
							AppClass_969.intParam();
							num3 = 8;
							if (AppClass_031.class730_0.int_118 != _return_103)
							{
								continue;
							}
							return;
						case _return_103:
							break;
						case 2:
							return;
						}
						goto _goto_10;
						continue;
						_goto_9:
						break;
					}
					continue;
					_goto_10:
					break;
				}
				AppClass_960.voidParam();
				num = 8;
				if (AppClass_031.class730_0.int_62 == _return_103)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_3 appclass064Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_4
	{
		public static readonly GetStatic_4 _appclass067_11;

		public static Func<Polygon, double> doubleParam;

		public static Func<List<mat_phang_diem>, double> doubleParam;

		public static Predicate<List<mat_phang_diem>> predicateListMatPhangDiemParam;

		public static Func<Tuple<Polygon, string, diem, diem>, double> doubleParam;

		public static Func<Tuple<Polygon, string, diem, diem>, double> doubleParam;

		public static Func<Tuple<Polygon, string, diem, diem>, double> doubleParam;

		public static Func<Tuple<Polygon, string, diem, diem>, Polygon> polygonParam;

		public static Action actionParam;

		public static Func<Polygon, double> doubleParam;

		public static Func<Tuple<double, diem>, double> doubleParam;

		public static Func<Tuple<double, diem>, double> doubleParam;

		public static Func<Polygon, double> doubleParam;

		public static Func<Polygon, double> doubleParam;

		public static Func<Polygon, bool> boolParam;

		public static Func<diem, bool> boolParam;

		public static Func<CurveXYZ, bool> boolParam;

		public static Func<diem, long> longParam;

		public static Func<diem, long> longParam;

		public static Func<CurveXYZ, double> doubleParam;

		public static Func<CurveXYZ, double> doubleParam;

		public static Predicate<CurveXYZ> predicateCurvexyzParam;

		public static Predicate<CurveXYZ> predicateCurvexyzParam;

		public static Func<Tuple<Polygon, diem, diem, diem, double>, double> doubleParam;

		public static Func<Tuple<Polygon, diem, diem, diem, double, double>, double> doubleParam;

		public static Func<Tuple<diem, double, double, double>, double> doubleParam;

		public static Func<Tuple<diem, diem, double, double, double>, double> doubleParam;

		public static Func<string, bool> boolParam;

		public static Func<Polygon, diem> diemParam;

		public static Func<GetStatic_3, bool> boolParam;

		public static Comparison<GetStatic_3> comparisonAppclass066Param;

		public static Func<KeyValuePair<string, List<object>>, bool> boolParam;

		public static Func<KeyValuePair<string, List<object>>, IEnumerable<object>> ienumerableObjectParam;

		public static Func<char, bool> boolParam;

		internal static GetStatic_4 _appclass067_12;

		static GetStatic_4()
		{
			AppClass_960.polygonParam();
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
						case 2:
							break;
						case 1:
							AppClass_960.doubleParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_17 != _return_103)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 11)
							{
								goto _goto_13;
							}
							AppClass_967.boolParam();
							num3 = 6;
							if (AppClass_031.class730_0.int_60 != _return_103)
							{
								continue;
							}
							break;
						case _return_103:
							AppClass_960.voidParam();
							num3 = 3;
							if (AppClass_031.class730_0.int_95 == _return_103)
							{
								continue;
							}
							goto _goto_15;
						case 3:
							goto _goto_15;
						case 4:
							return;
						}
						_appclass067_11 = new GetStatic_4();
						num3 = 3;
						if (AppClass_031.class730_0.int_45 != _return_103)
						{
							return;
						}
						continue;
						_goto_13:
						break;
					}
					continue;
					_goto_15:
					break;
				}
				while (num2 == 992);
				AppClass_969.intParam();
				num = 11;
			}
		}

		[SpecialName]
		internal double doubleParam(Polygon polygonParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(List<mat_phang_diem> _listPolygon_91)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal bool boolParam(List<mat_phang_diem> _listPolygon_91)
		{
			return true;
		}

		[SpecialName]
		internal double doubleParam(Tuple<Polygon, string, diem, diem> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<Polygon, string, diem, diem> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<Polygon, string, diem, diem> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal Polygon polygonParam(Tuple<Polygon, string, diem, diem> diemParam)
		{
			return null;
		}

		[SpecialName]
		internal void voidParam()
		{
		}

		[SpecialName]
		internal double doubleParam(Polygon polygonParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<double, diem> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<double, diem> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Polygon polygonParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Polygon polygonParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal bool boolParam(Polygon polygonParam)
		{
			return true;
		}

		[SpecialName]
		internal bool boolParam(diem diemParam)
		{
			return true;
		}

		[SpecialName]
		internal bool boolParam(CurveXYZ _curvexyz_76)
		{
			return true;
		}

		[SpecialName]
		internal long longParam(diem diemParam)
		{
			return _return_17;
		}

		[SpecialName]
		internal long longParam(diem diemParam)
		{
			return _return_17;
		}

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal bool boolParam(CurveXYZ _curvexyz_76)
		{
			return true;
		}

		[SpecialName]
		internal bool boolParam(CurveXYZ _curvexyz_76)
		{
			return true;
		}

		[SpecialName]
		internal double doubleParam(Tuple<Polygon, diem, diem, diem, double> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<Polygon, diem, diem, diem, double, double> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<diem, double, double, double> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(Tuple<diem, diem, double, double, double> diemParam)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal bool boolParam(string _string_33)
		{
			return true;
		}

		[SpecialName]
		internal diem diemParam(Polygon polygonParam)
		{
			return null;
		}

		[SpecialName]
		internal bool boolParam(GetStatic_3 class435_0)
		{
			return true;
		}

		[SpecialName]
		internal int intParam(GetStatic_3 class435_0, GetStatic_3 class435_1)
		{
			return _return_103;
		}

		[SpecialName]
		internal bool boolParam(KeyValuePair<string, List<object>> keyValuePair_0)
		{
			return true;
		}

		[SpecialName]
		internal IEnumerable<object> ienumerableObjectParam(KeyValuePair<string, List<object>> keyValuePair_0)
		{
			return null;
		}

		[SpecialName]
		internal bool boolParam(char charParam)
		{
			return true;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_4 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_5
	{
		public Polygon polygonParam;

		private static GetStatic_5 _appclass068_19;

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		static GetStatic_5()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = 6;
							if (AppClass_031.class730_0.int_36 != _return_103)
							{
								continue;
							}
							goto case _return_103;
						case _return_103:
							AppClass_960.voidParam();
							num3 = 5;
							if (AppClass_031.class730_0.int_69 != _return_103)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_20;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						}
						goto _goto_32;
						continue;
						_goto_20:
						break;
					}
					continue;
					_goto_32:
					break;
				}
				AppClass_969.intParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_5 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_7
	{
		public string _string_33;

		internal static GetStatic_7 _appclass069_23;

		public GetStatic_7(GetStatic_7 class438_1)
		{
		}

		[SpecialName]
		internal bool doubleParam(GetStatic_2 class434_0)
		{
			return true;
		}

		static GetStatic_7()
		{
			AppClass_960.polygonParam();
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
						case 2:
							AppClass_960.doubleParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_84 != _return_103)
							{
								continue;
							}
							break;
						case 1:
							goto _goto_44;
						case _return_103:
							return;
							_goto_28:
							if (num2 == 9)
							{
								goto _goto_25;
							}
							goto _goto_26;
							_goto_26:
							if (num2 == 990)
							{
								goto _goto_27;
							}
							goto case 2;
						}
						goto _goto_28;
						_goto_25:
						AppClass_969.intParam();
						num3 = 3;
						if (AppClass_031.class730_0.int_44 == _return_103)
						{
							return;
						}
						continue;
						_goto_27:
						break;
					}
					continue;
					_goto_44:
					break;
				}
				AppClass_960.voidParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_7 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_8
	{
		public string _string_33;

		internal static GetStatic_8 _appclass070_30;

		[SpecialName]
		internal bool doubleParam(Button buttonParam)
		{
			return true;
		}

		static GetStatic_8()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_50 != _return_103)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 9:
								AppClass_969.intParam();
								num3 = 8;
								if (AppClass_031.class730_0.int_25 == _return_103)
								{
									continue;
								}
								return;
							default:
								return;
							case 990:
								break;
							}
							goto _goto_31;
						case _return_103:
							break;
						case 2:
							return;
						}
						goto _goto_32;
						continue;
						_goto_31:
						break;
					}
					continue;
					_goto_32:
					break;
				}
				AppClass_960.voidParam();
				num = 2;
				if (AppClass_031.class730_0.int_108 == _return_103)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_8 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_9
	{
		public string _string_33;

		internal static GetStatic_9 _appclass071_34;

		[SpecialName]
		internal bool doubleParam(RadioButton radioButton_0)
		{
			return true;
		}

		static GetStatic_9()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = 8;
							if (AppClass_031.class730_0.int_46 == _return_103)
							{
								continue;
							}
							goto case _return_103;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									break;
								}
							}
							else
							{
								AppClass_969.intParam();
								num3 = 2;
								if (AppClass_031.class730_0.int_79 != _return_103)
								{
									continue;
								}
							}
							goto case 1;
						case _return_103:
							AppClass_960.voidParam();
							num = 9;
							goto _goto_48;
						case 2:
							return;
						}
						break;
					}
					continue;
					_goto_48:
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_9 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_11
	{
		public Func<Polygon, diem> doubleParam;

		public diem diemParam;

		private static GetStatic_11 _appclass072_36;

		public GetStatic_11(GetStatic_11 class441_1)
		{
		}

		[SpecialName]
		internal double doubleParam(Polygon polygonParam)
		{
			return _return_103._return_103;
		}

		static GetStatic_11()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_35 == _return_103)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 990:
								goto _goto_42;
							case 9:
								AppClass_969.intParam();
								return;
							}
							goto case 1;
						case _return_103:
							break;
						case 2:
							return;
						}
						goto _goto_67;
						continue;
						_goto_42:
						break;
					}
					continue;
					_goto_67:
					break;
				}
				AppClass_960.voidParam();
				num = 9;
				if (AppClass_031.class730_0.int_56 != _return_103)
				{
					num = 2;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_11 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_13
	{
		public List<diem> _listPolygon_91;

		private static GetStatic_13 _appclass073_40;

		public GetStatic_13(GetStatic_13 class442_1)
		{
		}

		[SpecialName]
		internal double doubleParam(List<diem> _listPolygon_92)
		{
			return _return_103._return_103;
		}

		static GetStatic_13()
		{
			AppClass_960.polygonParam();
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
						case 2:
							do
							{
								AppClass_960.doubleParam();
								num3 = 1;
							}
							while (AppClass_031.class730_0.int_50 == _return_103);
							continue;
						case 1:
							AppClass_960.voidParam();
							num3 = 5;
							if (AppClass_031.class730_0.int_87 != _return_103)
							{
								continue;
							}
							goto _goto_44;
						default:
							switch (num2)
							{
							case 990:
								goto _goto_42;
							case 9:
								return;
							}
							goto _goto_44;
						case _return_103:
							goto _goto_44;
							_goto_42:
							break;
						}
						break;
					}
					continue;
					_goto_44:
					break;
				}
				AppClass_969.intParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_13 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_15
	{
		public diem diemParam;

		private static GetStatic_15 _appclass074_45;

		public GetStatic_15(GetStatic_15 class443_1)
		{
		}

		[SpecialName]
		internal double doubleParam(Tuple<object, diem> diemParam)
		{
			return _return_103._return_103;
		}

		static GetStatic_15()
		{
			AppClass_960.polygonParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						_goto_46:
						switch (num3)
						{
						case 2:
							AppClass_960.doubleParam();
							num3 = 4;
							if (AppClass_031.class730_0.int_112 == _return_103)
							{
								continue;
							}
							break;
						default:
							while (num2 == 9)
							{
								AppClass_969.intParam();
								num3 = _return_103;
								if (AppClass_031.class730_0.int_71 != _return_103)
								{
									continue;
								}
								goto _goto_46;
							}
							goto _goto_47;
						case 1:
							break;
						case _return_103:
							return;
						}
						goto _goto_48;
						continue;
						_goto_47:
						break;
					}
					continue;
					_goto_48:
					break;
				}
				while (num2 == 990);
				AppClass_960.voidParam();
				num = 4;
				if (AppClass_031.class730_0.intParam == _return_103)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_15 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_16
	{
		public Polygon polygonParam;

		private static GetStatic_16 _appclass075_49;

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double boolParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_76)
		{
			return _return_103._return_103;
		}

		static GetStatic_16()
		{
			AppClass_960.polygonParam();
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
							break;
						default:
							goto _goto_50;
						case _return_103:
							goto _goto_51;
						case 2:
							return;
						}
						goto _goto_53;
						_goto_50:
						switch (num2)
						{
						default:
							goto _goto_53;
						case 990:
							break;
						case 9:
							AppClass_969.intParam();
							return;
						}
						break;
						_goto_53:
						AppClass_960.doubleParam();
						num3 = _return_103;
						if (AppClass_031.class730_0.int_32 != _return_103)
						{
							return;
						}
					}
					continue;
					_goto_51:
					break;
				}
				AppClass_960.voidParam();
				num = 9;
				if (AppClass_031.class730_0.int_98 == _return_103)
				{
					num = 2;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_16 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_18
	{
		public Polygon polygonParam;

		public Func<diem, double> doubleParam;

		internal static GetStatic_18 _appclass076_54;

		public GetStatic_18(GetStatic_18 class445_1)
		{
		}

		[SpecialName]
		internal double doubleParam(diem diemParam)
		{
			return _return_103._return_103;
		}

		static GetStatic_18()
		{
			AppClass_960.polygonParam();
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
						case 2:
							AppClass_960.doubleParam();
							goto _goto_56;
						case 1:
							goto _goto_56;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_57;
								}
								goto case 2;
							}
							return;
						case _return_103:
							break;
						}
						goto _goto_81;
						_goto_56:
						AppClass_960.voidParam();
						num3 = 1;
						if (AppClass_031.class730_0.int_23 == _return_103)
						{
							goto _goto_81;
						}
						continue;
						_goto_57:
						break;
					}
					continue;
					_goto_81:
					break;
				}
				AppClass_969.intParam();
				num = 9;
				if (AppClass_031.class730_0.int_61 == _return_103)
				{
					num = 7;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_18 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_20
	{
		public CurveXYZ _curvexyz_76;

		private static GetStatic_20 _appclass077_61;

		public GetStatic_20(GetStatic_20 class446_1)
		{
		}

		[SpecialName]
		internal bool doubleParam(diem diemParam)
		{
			return true;
		}

		static GetStatic_20()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.doubleParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_96 == _return_103)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_66;
								}
								goto case _return_103;
							}
							return;
						case _return_103:
							AppClass_960.voidParam();
							break;
						case 2:
							break;
						}
						goto _goto_67;
						continue;
						_goto_66:
						break;
					}
					continue;
					_goto_67:
					break;
				}
				AppClass_969.intParam();
				num = 9;
				if (AppClass_031.class730_0.int_49 == _return_103)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_20 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_22
	{
		public CurveXYZ _curvexyz_76;

		internal static GetStatic_22 _appclass078_65;

		public GetStatic_22(GetStatic_22 class447_1)
		{
		}

		[SpecialName]
		internal bool doubleParam(diem diemParam)
		{
			return true;
		}

		static GetStatic_22()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.voidParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_32 == _return_103)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_66;
								}
								goto case _return_103;
							}
							return;
						case _return_103:
							AppClass_969.intParam();
							num = 9;
							if (AppClass_031.class730_0.int_67 == _return_103)
							{
								num = 3;
							}
							break;
						case 2:
							AppClass_960.doubleParam();
							num = 1;
							break;
						}
						goto _goto_67;
						continue;
						_goto_66:
						break;
					}
					continue;
					_goto_67:
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_22 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_23
	{
		public diem diemParam;

		private static GetStatic_23 _appclass079_68;

		[SpecialName]
		internal bool doubleParam(CurveXYZ _curvexyz_76)
		{
			return true;
		}

		[SpecialName]
		internal bool doubleParam(CurveXYZ _curvexyz_76)
		{
			return true;
		}

		static GetStatic_23()
		{
			AppClass_960.polygonParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					_goto_71:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 2:
							AppClass_960.doubleParam();
							goto case 1;
						case 1:
							AppClass_960.voidParam();
							num = 9;
							if (AppClass_031.class730_0.int_72 == _return_103)
							{
								num = 5;
							}
							goto _goto_69;
						case _return_103:
							return;
						}
						switch (num2)
						{
						case 9:
							goto _goto_70;
						default:
							return;
						case 990:
							break;
						}
						goto _goto_71;
						_goto_70:
						AppClass_969.intParam();
						num3 = 1;
						if (AppClass_031.class730_0.int_114 == _return_103)
						{
							return;
						}
						continue;
						_goto_69:
						break;
					}
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_23 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_25
	{
		public diem diemParam;

		public Comparison<mat_phang_diem> comparisonAppclass066Param;

		internal static GetStatic_25 _appclass080_72;

		public GetStatic_25(GetStatic_25 class449_1)
		{
		}

		[SpecialName]
		internal int doubleParam(mat_phang_diem mat_phang_diem_0, mat_phang_diem mat_phang_diem_1)
		{
			return _return_103;
		}

		static GetStatic_25()
		{
			AppClass_960.polygonParam();
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
							AppClass_960.voidParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_64 != _return_103)
							{
								continue;
							}
							goto case 2;
						case 2:
							AppClass_960.doubleParam();
							goto case 1;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_74;
								}
								goto case 2;
							}
							return;
						case _return_103:
							break;
						}
						goto _goto_75;
						continue;
						_goto_74:
						break;
					}
					continue;
					_goto_75:
					break;
				}
				AppClass_969.intParam();
				num = _return_103;
				if (AppClass_031.class730_0.int_15 == _return_103)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_25 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_27
	{
		public CurveXYZ _curvexyz_76;

		internal static GetStatic_27 _appclass081_77;

		public GetStatic_27(GetStatic_27 class450_1)
		{
		}

		[SpecialName]
		internal bool doubleParam(Polygon polygonParam)
		{
			return true;
		}

		static GetStatic_27()
		{
			AppClass_960.polygonParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						_goto_79:
						switch (num3)
						{
						case 1:
							AppClass_969.intParam();
							num3 = _return_103;
							if (AppClass_031.class730_0.int_21 == _return_103)
							{
								continue;
							}
							break;
						case 2:
							goto _goto_87;
						case _return_103:
							return;
							_goto_82:
							while (num2 == 9)
							{
								AppClass_960.voidParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_89 != _return_103)
								{
									continue;
								}
								goto _goto_79;
							}
							goto _goto_80;
							_goto_80:
							if (num2 == 990)
							{
								goto _goto_81;
							}
							goto case 1;
						}
						goto _goto_82;
						continue;
						_goto_81:
						break;
					}
					continue;
					_goto_87:
					break;
				}
				AppClass_960.doubleParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_27 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_29
	{
		public Polygon polygonParam;

		internal static GetStatic_29 _appclass082_83;

		public GetStatic_29(GetStatic_29 class451_1)
		{
		}

		[SpecialName]
		internal double doubleParam(mat_phang_diem mat_phang_diem_0)
		{
			return _return_103._return_103;
		}

		static GetStatic_29()
		{
			AppClass_960.polygonParam();
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
						case 2:
							AppClass_960.doubleParam();
							num3 = 8;
							if (AppClass_031.class730_0.int_60 != _return_103)
							{
								continue;
							}
							goto _goto_87;
						default:
							switch (num2)
							{
							case 9:
								break;
							case 990:
								goto _goto_85;
							default:
								goto _goto_87;
							}
							AppClass_969.intParam();
							num3 = 7;
							if (AppClass_031.class730_0.int_101 != _return_103)
							{
								continue;
							}
							return;
						case 1:
							goto _goto_87;
						case _return_103:
							return;
							_goto_85:
							break;
						}
						break;
					}
					continue;
					_goto_87:
					break;
				}
				AppClass_960.voidParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_29 appclass064Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_31
	{
		public Polygon polygonParam;

		internal static GetStatic_31 _appclass083_88;

		public GetStatic_31(GetStatic_31 class452_1)
		{
		}

		[SpecialName]
		internal double doubleParam(mat_phang_diem mat_phang_diem_0)
		{
			return _return_103._return_103;
		}

		static GetStatic_31()
		{
			AppClass_960.polygonParam();
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
						case _return_103:
							break;
						default:
							if (num2 != 9)
							{
								goto _goto_89;
							}
							AppClass_960.voidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_44 != _return_103)
							{
								continue;
							}
							break;
						case 2:
							goto _goto_90;
						case 1:
							return;
						}
						AppClass_969.intParam();
						num3 = 8;
						if (AppClass_031.class730_0.int_62 == _return_103)
						{
							return;
						}
						continue;
						_goto_89:
						break;
					}
					continue;
					_goto_90:
					break;
				}
				while (num2 == 990);
				AppClass_960.doubleParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_31 appclass064Param()
		{
			return null;
		}
	}

	public static object objectParam;

	public static object objectParam;

	public static List<Polygon> _listPolygon_91;

	public static List<Polygon> _listPolygon_92;

	public static object objectParam;

	public static object objectParam;

	private static readonly List<GetStatic_2> _listAppclass065_93;

	public static List<object> _listObject_94;

	public static List<object> _listObject_95;

	public static List<Tuple<object, string>> stringParam;

	private static object objectParam;

	static GetStatic_32()
	{
		AppClass_960.polygonParam();
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
					case 9:
						_listObject_94 = new List<object>();
						goto case 5;
					case 5:
						_listObject_95 = new List<object>();
						num3 = 7;
						if (AppClass_031.class730_0.int_106 != _return_103)
						{
							continue;
						}
						goto case 3;
					case 4:
						_listAppclass065_93 = new List<GetStatic_2>
						{
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0x3463194F ^ AppClass_031.class730_0.int_111),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x75CFB872 ^ AppClass_031.class730_0.int_7),
									AppClass_960.voidParam(0x15985F6C ^ AppClass_031.class730_0.int_28),
									AppClass_960.voidParam(0xC67F2C3 ^ AppClass_031.class730_0.int_64)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0xC670F13 ^ AppClass_031.class730_0.int_64),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x51ACFE7E ^ AppClass_031.class730_0.int_8),
									AppClass_960.voidParam(0x544398EE ^ AppClass_031.class730_0.int_9),
									AppClass_960.voidParam(0xE0403C ^ AppClass_031.class730_0.int_45)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0x62AA43FD ^ AppClass_031.class730_0.int_119),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x64DF4F9 ^ AppClass_031.class730_0.int_46),
									AppClass_960.voidParam(0x482E429C ^ AppClass_031.class730_0.int_80)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0xBA98F0 ^ AppClass_031.class730_0.int_48),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x1E4E963 ^ AppClass_031.class730_0.int_68),
									AppClass_960.voidParam(0x6BD1ABD8 ^ AppClass_031.class730_0.int_40)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0xC67054B ^ AppClass_031.class730_0.int_64),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x15985F6C ^ AppClass_031.class730_0.int_28),
									AppClass_960.voidParam(0x482E429C ^ AppClass_031.class730_0.int_80),
									AppClass_960.voidParam(0x24F543FA ^ AppClass_031.class730_0.int_75)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0xE0B7B0 ^ AppClass_031.class730_0.int_45),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x192AC99 ^ AppClass_031.class730_0.int_84),
									AppClass_960.voidParam(0xF94A1D5 ^ AppClass_031.class730_0.int_53),
									AppClass_960.voidParam(0x616E1180 ^ AppClass_031.class730_0.int_22)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0x7CD02FF4 ^ AppClass_031.class730_0.int_99),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x7A0D195B ^ AppClass_031.class730_0.int_14),
									AppClass_960.voidParam(0x2A811888 ^ AppClass_031.class730_0.int_26)
								}
							},
							new GetStatic_2
							{
								objectParam = AppClass_960.voidParam(0x408B1223 ^ AppClass_031.class730_0.int_76),
								_listPolygon_91 = new List<string>
								{
									AppClass_960.voidParam(0x725937C6 ^ AppClass_031.class730_0.int_73),
									AppClass_960.voidParam(0x339B133B ^ AppClass_031.class730_0.int_29)
								}
							}
						};
						num3 = 9;
						if (AppClass_031.class730_0.int_14 == _return_103)
						{
							continue;
						}
						goto case 9;
					case 2:
						AppClass_960.doubleParam();
						num3 = 10;
						if (AppClass_031.class730_0.int_87 != _return_103)
						{
							continue;
						}
						goto case 1;
					case 1:
						AppClass_960.voidParam();
						num3 = _return_103;
						if (AppClass_031.class730_0.int_70 != _return_103)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto _goto_96;
							}
							goto case 5;
						}
						_listPolygon_92 = new List<Polygon>();
						num = 4;
						break;
					case _return_103:
						AppClass_969.intParam();
						goto case 10;
					case 10:
						AppClass_967.boolParam();
						goto case 6;
					case 6:
						objectParam = new AppForm_821();
						goto case 7;
					case 7:
						_listPolygon_91 = new List<Polygon>();
						num = 17;
						if (AppClass_031.class730_0.int_67 == _return_103)
						{
							num = 8;
						}
						break;
					case 3:
						stringParam = new List<Tuple<object, string>>();
						return;
					case 8:
						return;
					}
					goto _goto_97;
					continue;
					_goto_96:
					break;
				}
				continue;
				_goto_97:
				break;
			}
		}
	}

	public static Polygon boolParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static Polygon appclass064Param(object objectParam, object objectParam)
	{
		return null;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static int intParam(object objectParam)
	{
		return _return_103;
	}

	public static Tuple<List<AppClass_087.AppClass_093>, List<Polygon>, List<CurveXYZ>> listCurvexyzParam(object objectParam, bool boolParam = true)
	{
		return null;
	}

	public static List<AppClass_087.AppClass_093> appclass093Param(List<AppClass_087.AppClass_093> appclass093Param, double doubleParam = _return_103.001)
	{
		return null;
	}

	public static diem diemParam(List<diem> appclass093Param)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<Polygon> appclass093Param)
	{
		return null;
	}

	public static List<mat_phang_diem> listMatPhangDiemParam(List<mat_phang_diem> appclass093Param)
	{
		return null;
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(object objectParam, object objectParam, bool boolParam = true)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, List<object> appclass093Param, List<object> listObjectParam = null, double doubleParam = 5._return_103, int intParam = 2, float floatParam = 300f, bool boolParam = true)
	{
	}

	private static void voidParam(object objectParam, object objectParam, object objectParam, double doubleParam, int intParam, int intParam, double doubleParam, double doubleParam, double doubleParam)
	{
	}

	private static void voidParam(object objectParam, object objectParam, object objectParam, double doubleParam, int intParam, int intParam, double doubleParam, double doubleParam, double doubleParam, float floatParam = 1f, int intParam = 48)
	{
	}

	private static void voidParam(object objectParam, object objectParam, object objectParam, double doubleParam, int intParam, double doubleParam, object objectParam, double doubleParam, int intParam, int intParam, double doubleParam, double doubleParam, double doubleParam, bool boolParam = false)
	{
	}

	public static Tuple<diem, int, int> intParam(object objectParam, AppClass_318.AppEnum_329 genum7_0)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, List<diem> appclass093Param, bool boolParam = false, double doubleParam = -1._return_103)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<Polygon> appclass093Param)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<Polygon> appclass093Param)
	{
		return null;
	}

	public static void voidParam(ref Dictionary<string, Info_Slab3D> infoSlab3dParam, ref List<Info_Beam3D> appclass093Param)
	{
	}

	public static Dictionary<string, Info_Slab3D> infoSlab3dParam(Dictionary<string, Info_Slab3D> infoSlab3dParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, List<Polygon> appclass093Param)
	{
		return null;
	}

	public static Info_Beam3D infoBeam3dParam(object objectParam, List<Polygon> appclass093Param)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static List<CurveXYZ> listCurvexyzParam(object objectParam)
	{
		return null;
	}

	public static diem diemParam(object objectParam, List<CurveXYZ> appclass093Param, double doubleParam = -1._return_103)
	{
		return null;
	}

	public static diem diemParam(object objectParam, List<Polygon> appclass093Param, double doubleParam = -1._return_103)
	{
		return null;
	}

	public static diem diemParam(object objectParam, List<diem> appclass093Param, double doubleParam = -1._return_103)
	{
		return null;
	}

	public static CurveXYZ curvexyzParam(object objectParam, List<CurveXYZ> appclass093Param, double doubleParam = -1._return_103)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<CurveXYZ> appclass093Param, bool boolParam = false, bool boolParam = true)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<Polygon> appclass093Param, bool boolParam = true)
	{
		return null;
	}

	public static List<CurveXYZ> listCurvexyzParam(object objectParam, List<Polygon> appclass093Param)
	{
		return null;
	}

	private static bool boolParam(object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return true;
	}

	private static int intParam(object objectParam, object objectParam, object objectParam)
	{
		return _return_103;
	}

	public static List<CurveXYZ> listCurvexyzParam(object objectParam)
	{
		return null;
	}

	public static Polygon polygonParam(List<CurveXYZ> appclass093Param)
	{
		return null;
	}

	private static List<List<CurveXYZ>> listListCurvexyzParam(List<CurveXYZ> appclass093Param)
	{
		return null;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static Polygon polygonParam(List<diem> appclass093Param)
	{
		return null;
	}

	private static bool boolParam(object objectParam, object objectParam, object objectParam, double doubleParam)
	{
		return true;
	}

	public static Polygon polygonParam(List<diem> appclass093Param)
	{
		return null;
	}

	public static Polygon polygonParam(List<Polygon> appclass093Param)
	{
		return null;
	}

	private static bool boolParam(List<CurveXYZ> appclass093Param, object objectParam, object objectParam, object objectParam)
	{
		return true;
	}

	private static bool boolParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam, object objectParam, double doubleParam)
	{
		return true;
	}

	public static object objectParam()
	{
		return null;
	}

	public static List<object> listObjectParam()
	{
		return null;
	}

	public static string stringParam(object objectParam, object objectParam, int intParam = 1)
	{
		return null;
	}

	public static void voidParam(ref Point pointParam, ref double doubleParam, object objectParam, object objectParam, double doubleParam = 50._return_103)
	{
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam)
	{
	}

	public static AppClass_106.AppClass_136 appclass136Param(object objectParam)
	{
		return null;
	}

	public static AppClass_318.AppClass_334 appclass334Param(object objectParam)
	{
		return null;
	}

	public static double doubleParam(double doubleParam, object objectParam)
	{
		return _return_103._return_103;
	}

	public static AppClass_318.AppClass_330 appclass330Param(object objectParam, bool boolParam = false)
	{
		return null;
	}

	public static string stringParam(object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static diem diemParam(object objectParam, diem diemParam = null)
	{
		return null;
	}

	public static CurveXYZ curvexyzParam(object objectParam, diem diemParam = null)
	{
		return null;
	}

	public static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static CurveXYZ curvexyzParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, double doubleParam, object objectParam, [Optional][DefaultParameterValue(null)] ref object objectParam)
	{
		return null;
	}

	public static string stringParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam = null)
	{
	}

	public static diem diemParam(List<diem> appclass093Param)
	{
		return null;
	}

	public static Bitmap bitmapParam(object objectParam, int intParam = 6)
	{
		return null;
	}

	public static double[] smethod_75(List<diem> appclass093Param)
	{
		return null;
	}

	public static string stringParam()
	{
		return null;
	}

	public static string stringParam()
	{
		return null;
	}

	public static double doubleParam(object objectParam, List<Polygon> appclass093Param)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(double doubleParam, double doubleParam, double doubleParam = _return_103.01)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(double doubleParam, double doubleParam, double doubleParam = _return_103.01)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(double doubleParam, double doubleParam, double doubleParam = _return_103.01)
	{
		return _return_103._return_103;
	}

	public static void voidParam()
	{
	}

	public static Polyline polylineParam(object objectParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam = 40._return_103)
	{
		return null;
	}

	public static Tuple<diem, diem, diem> diemParam(List<diem> appclass093Param, object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam)
	{
		return null;
	}

	public static Tuple<diem, diem, diem, double> doubleParam(List<Tuple<diem, double>> appclass093Param, object objectParam, object objectParam, double doubleParam, double doubleParam)
	{
		return null;
	}

	public static Tuple<diem, double, double> doubleParam(object objectParam, object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, bool boolParam = false)
	{
		return null;
	}

	public static Tuple<diem, diem, double, double> doubleParam(List<diem> appclass093Param, object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, bool boolParam = false, int intParam = 2, bool boolParam = false, TranslateSystem translateSystem_0 = null, string _string_33 = "T12")
	{
		return null;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(List<Polygon> appclass093Param)
	{
		return _return_103._return_103;
	}

	public static void voidParam(object objectParam)
	{
	}

	public static DBObject dbobjectParam(object objectParam, ObjectId objectId_0, bool boolParam = false)
	{
		return null;
	}

	public static diem diemParam(Point3d point3d_0)
	{
		return null;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, string _string_33 = null, bool boolParam = false)
	{
	}

	public static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static string stringParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, double doubleParam, int intParam, double doubleParam, double doubleParam = _return_103._return_103, int intParam = -1)
	{
		return null;
	}

	public static Tuple<diem, diem, diem, double, double> doubleParam(List<diem> appclass093Param, bool boolParam = false)
	{
		return null;
	}

	public static string stringParam(List<string> appclass093Param, bool boolParam = true)
	{
		return null;
	}

	public static bool boolParam(int intParam, List<AppClass_047.AppClass_055> appclass093Param)
	{
		return true;
	}

	public static AppClass_047.AppClass_055 appclass055Param(int intParam, List<AppClass_047.AppClass_055> appclass093Param)
	{
		return null;
	}

	public static bool boolParam(ref List<diem> appclass093Param, ref List<List<diem>> listObjectParam)
	{
		return true;
	}

	public static bool boolParam(ref Polygon polygonParam, ref List<Polygon> appclass093Param)
	{
		return true;
	}

	public static List<int> listIntParam(ref List<Polygon> appclass093Param)
	{
		return null;
	}

	public static double doubleParam(int intParam = 1)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(int intParam = 1)
	{
		return _return_103._return_103;
	}

	public static List<diem> listDiemParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static bool boolParam(List<info_thep> appclass093Param, List<info_thep> listObjectParam)
	{
		return true;
	}

	public static List<int> listIntParam(ref List<List<diem>> appclass093Param)
	{
		return null;
	}

	public static AppClass_318.AppClass_331 appclass331Param(object objectParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam = _return_103._return_103)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam = _return_103._return_103)
	{
		return null;
	}

	public static void voidParam(object objectParam)
	{
	}

	public static Polygon polygonParam(object objectParam, double doubleParam = _return_103._return_103, bool boolParam = false)
	{
		return null;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	private static Extents3d extents3dParam(object objectParam)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Extents3d)(object)null;
	}

	private static Extents3d extents3dParam(object objectParam)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Extents3d)(object)null;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam = _return_103._return_103, double doubleParam = _return_103._return_103)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, object objectParam, object objectParam, double doubleParam, bool boolParam = false, bool boolParam = false)
	{
		return null;
	}

	public static Polygon polygonParam(List<diem> appclass093Param, object objectParam, double doubleParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam, diem diemParam = null)
	{
		return null;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam)
	{
	}

	public static void voidParam(object objectParam, object objectParam)
	{
	}

	public static Button buttonParam(object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static RadioButton radiobuttonParam(object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<Polygon> appclass093Param, object objectParam, Func<Polygon, diem> doubleParam = null)
	{
		return null;
	}

	public static List<List<diem>> listListDiemParam(List<List<diem>> appclass093Param, object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, double doubleParam, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, bool boolParam = true)
	{
	}

	public static void voidParam(object objectParam, object objectParam, double doubleParam, double doubleParam, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, bool boolParam = true)
	{
	}

	public static void voidParam(object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, bool boolParam = true)
	{
	}

	public static void voidParam(object objectParam, List<CurveXYZ> appclass093Param, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, bool boolParam = true, double doubleParam = -1._return_103)
	{
	}

	private static void voidParam(object objectParam, object objectParam, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, double doubleParam = -1._return_103)
	{
	}

	private static double doubleParam(double doubleParam)
	{
		return _return_103._return_103;
	}

	private static double doubleParam(double doubleParam, double doubleParam)
	{
		return _return_103._return_103;
	}

	private static bool boolParam(double doubleParam, double doubleParam, double doubleParam)
	{
		return true;
	}

	public static void voidParam(object objectParam, List<CurveXYZ> appclass093Param, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, bool boolParam = true)
	{
	}

	public static List<CurveXYZ> listCurvexyzParam(List<CurveXYZ> appclass093Param, double doubleParam = _return_103.033)
	{
		return null;
	}

	public static void voidParam(object objectParam, List<CurveXYZ> appclass093Param, Point pointParam, object objectParam, object objectParam, object objectParam, double doubleParam, Color colorParam, bool boolParam = true, double doubleParam = _return_103.033)
	{
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam = 25._return_103)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, double doubleParam = 25._return_103)
	{
		return null;
	}

	public static Point3d point3dParam(object objectParam)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	public static List<diem> listDiemParam(object objectParam, object objectParam, double doubleParam, bool boolParam = false, bool boolParam = false)
	{
		return null;
	}

	public static string stringParam(List<info_thep> appclass093Param)
	{
		return null;
	}

	public static string stringParam(List<diem> appclass093Param)
	{
		return null;
	}

	public static string stringParam(object objectParam = null)
	{
		return null;
	}

	public static void voidParam()
	{
	}

	public static string stringParam(object objectParam, bool boolParam = false)
	{
		return null;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static int intParam(object objectParam)
	{
		return _return_103;
	}

	public static string[] smethod_158(object objectParam)
	{
		return null;
	}

	public static object objectParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, object objectParam, double doubleParam, int intParam = _return_103, bool boolParam = false)
	{
		return null;
	}

	public static List<object> listObjectParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, object objectParam, AppClass_087.AppEnum_088 enum10_0, double doubleParam)
	{
		return null;
	}

	public static diem[] smethod_161(List<diem> appclass093Param)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, double doubleParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
	}

	public static void voidParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, bool boolParam = true, string _string_33 = null, int intParam = -1)
	{
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, double doubleParam, ref string _string_33)
	{
		return null;
	}

	public static int intParam(int intParam)
	{
		return _return_103;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static List<diem> listDiemParam(object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	private static void voidParam(ref object objectParam, int intParam = _return_103, bool boolParam = false)
	{
	}

	public static void voidParam(string _string_33 = "")
	{
	}

	public static object objectParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(ref List<GetStatic_3> appclass093Param, object objectParam, string _string_33 = "sldk L=Lt", bool boolParam = false, bool boolParam = true, int intParam = -1, diem diemParam = null, double doubleParam = _return_103._return_103, bool boolParam = false, bool boolParam = true, int intParam = _return_103, string stringParam = "", int intParam = 1, int intParam = -1, bool boolParam = false, bool boolParam = true, string stringParam = "", InfoThep infoThep_0 = null)
	{
	}

	private static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static double[] smethod_176(object objectParam)
	{
		return null;
	}

	private static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static GetStatic_3 appclass066Param(object objectParam)
	{
		return null;
	}

	public static void voidParam(List<GetStatic_3> appclass093Param, bool boolParam = false, diem diemParam = null)
	{
	}

	private static diem diemParam(object objectParam, object objectParam)
	{
		return null;
	}

	private static double doubleParam(object objectParam, object objectParam, object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static void voidParam(object objectParam, object objectParam, List<object> appclass093Param = null)
	{
	}

	public static string stringParam(List<string> appclass093Param)
	{
		return null;
	}

	public static void voidParam(object objectParam, IList<Action<string>> ilistActionStringParam, char charParam = '/')
	{
	}

	public static double doubleParam(object objectParam, double doubleParam)
	{
		return _return_103._return_103;
	}

	public static string stringParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(ref string _string_33, ref int intParam, ref int intParam, ref string stringParam, ref string stringParam, ref string stringParam, ref string[] string_4, ref int intParam, ref string stringParam, ref string stringParam, [Optional][DefaultParameterValue("")] ref string stringParam, [Optional][DefaultParameterValue("")] ref string stringParam, [Optional][DefaultParameterValue("")] ref string stringParam)
	{
	}

	public static void voidParam(object objectParam, ref double doubleParam, ref double doubleParam)
	{
	}

	public static bool boolParam(object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return true;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, double doubleParam, double doubleParam)
	{
		return null;
	}

	public static List<object> listObjectParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam = 25._return_103)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, double doubleParam = 25._return_103)
	{
		return null;
	}

	public static object objectParam(object objectParam, double doubleParam, double doubleParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true, bool boolParam = true, string _string_33 = "", double doubleParam = 1.5, bool boolParam = false)
	{
		return null;
	}

	public static Tuple<object, object> objectParam(object objectParam, double doubleParam, double doubleParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true, bool boolParam = true, string _string_33 = "", double doubleParam = 1.5, bool boolParam = false, double doubleParam = _return_103._return_103, object objectParam = null)
	{
		return null;
	}

	public static Tuple<object, object> objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true, bool boolParam = true, string _string_33 = "", double doubleParam = 1.5, bool boolParam = false, double doubleParam = _return_103._return_103, object objectParam = null)
	{
		return null;
	}

	public static object objectParam(object objectParam, double doubleParam, double doubleParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam, string _string_33 = "", double doubleParam = -1._return_103)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam, string _string_33 = "", double doubleParam = -1._return_103)
	{
		return null;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static void voidParam(object objectParam, object objectParam)
	{
	}

	public static InfoThep infothepParam(object objectParam, double doubleParam = _return_103._return_103, double doubleParam = _return_103._return_103, int intParam = _return_103)
	{
		return null;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static double doubleParam(object objectParam, double doubleParam = _return_103._return_103)
	{
		return _return_103._return_103;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static Tuple<double, double> doubleParam(object objectParam)
	{
		return null;
	}

	public static int intParam(object objectParam, double doubleParam = _return_103._return_103)
	{
		return _return_103;
	}

	public static int intParam(object objectParam)
	{
		return _return_103;
	}

	public static double doubleParam(object objectParam, double doubleParam = _return_103._return_103, double doubleParam = 20._return_103)
	{
		return _return_103._return_103;
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	public static double doubleParam(object objectParam, double doubleParam = _return_103._return_103, double doubleParam = 20._return_103)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam, double doubleParam = _return_103._return_103, double doubleParam = 20._return_103)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static Tuple<double, double> doubleParam(object objectParam)
	{
		return null;
	}

	public static Tuple<double, double, double, double> doubleParam(object objectParam)
	{
		return null;
	}

	public static Tuple<double, double> doubleParam(object objectParam)
	{
		return null;
	}

	public static List<Tuple<int, int>> intParam(object objectParam)
	{
		return null;
	}

	public static List<int> listIntParam(object objectParam)
	{
		return null;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(object objectParam)
	{
		return _return_103._return_103;
	}

	public static string stringParam(int intParam)
	{
		return null;
	}

	public static List<diem> listDiemParam(List<diem> appclass093Param)
	{
		return null;
	}

	public static void voidParam(ref object objectParam, List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true, bool boolParam = false, double doubleParam = 20._return_103)
	{
	}

	public static void voidParam(ref object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
	}

	public static object objectParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true)
	{
		return null;
	}

	public static object objectParam(List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = true)
	{
		return null;
	}

	public static object objectParam(List<diem> appclass093Param, object objectParam, bool boolParam = false, double doubleParam = 1._return_103)
	{
		return null;
	}

	public static void voidParam(List<Line_diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam = 1._return_103)
	{
	}

	public static object objectParam(double doubleParam, double doubleParam, double doubleParam, double doubleParam, object objectParam, bool boolParam = false, double doubleParam = 1._return_103)
	{
		return null;
	}

	public static string stringParam(string _string_33 = "")
	{
		return null;
	}

	public static object objectParam(object objectParam, double doubleParam, double doubleParam, bool boolParam = false)
	{
		return null;
	}

	public static List<diem> listDiemParam(object objectParam, Matrix3d matrix3d_0)
	{
		return null;
	}

	public static List<diem> listDiemParam(List<Point2d> appclass093Param, double doubleParam)
	{
		return null;
	}

	public static void voidParam(ref List<Point2d> appclass093Param, Matrix3d matrix3d_0)
	{
	}

	public static Polygon polygonParam(object objectParam, Matrix3d matrix3d_0)
	{
		return null;
	}

	public static void voidParam(ref AppClass_289.AppClass_291 gclass119_0, Matrix3d matrix3d_0, ref double doubleParam)
	{
	}

	public static List<diem> listDiemParam(object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, double doubleParam, object objectParam)
	{
	}

	public static bool boolParam(object objectParam, object objectParam)
	{
		return true;
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, int intParam)
	{
	}

	public static List<BlockReference> listBlockreferenceParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static List<Line_diem> listLineDiemParam(object objectParam, List<diem> appclass093Param, object objectParam, object objectParam)
	{
		return null;
	}

	public static double doubleParam(double doubleParam)
	{
		return _return_103._return_103;
	}

	public static double doubleParam(double doubleParam)
	{
		return _return_103._return_103;
	}

	public static void voidParam(object objectParam, List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = false, double doubleParam = _return_103._return_103)
	{
	}

	public static void voidParam(object objectParam, List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, bool boolParam = false, double doubleParam = _return_103._return_103)
	{
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, double doubleParam, CurveXYZ _curvexyz_76 = null)
	{
	}

	public static void voidParam(ref diem diemParam, ref int intParam, ref object objectParam, double doubleParam)
	{
	}

	public static string stringParam(object objectParam, object objectParam, List<BlockReference> appclass093Param)
	{
		return null;
	}

	public static string stringParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, int intParam, string _string_33 = "", bool boolParam = true)
	{
	}

	public static List<object> listObjectParam(object objectParam, List<diem> appclass093Param, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, int intParam, string _string_33 = "")
	{
		return null;
	}

	public static diem diemParam(List<diem> appclass093Param)
	{
		return null;
	}

	public static List<diem> listDiemParam(object objectParam, object objectParam, double doubleParam, double doubleParam, object objectParam, double doubleParam, double doubleParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, Matrix3d matrix3d_0, object objectParam, object objectParam, double doubleParam, double doubleParam, double doubleParam)
	{
	}

	public static void voidParam(object objectParam, [Optional][DefaultParameterValue(_return_103._return_103)] ref double doubleParam, [Optional][DefaultParameterValue(_return_103._return_103)] ref double doubleParam, [Optional][DefaultParameterValue(_return_103._return_103)] ref double doubleParam, [Optional][DefaultParameterValue(_return_103._return_103)] ref double doubleParam, [Optional][DefaultParameterValue(null)] ref Point2d point2d_0)
	{
	}

	public static double doubleParam(List<diem> appclass093Param, object objectParam)
	{
		return _return_103._return_103;
	}

	public static List<Point2d> listPoint2dParam(object objectParam)
	{
		return null;
	}

	public static Point2d point2dParam(Point3d point3d_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Point2d)(object)null;
	}

	public static List<Point2d> listPoint2dParam(List<Point2d> appclass093Param, Matrix3d matrix3d_0)
	{
		return null;
	}

	public static List<List<Point2d>> listListPoint2dParam(List<Line> appclass093Param)
	{
		return null;
	}

	public static AppClass_289.AppClass_291 appclass291Param(object objectParam, double doubleParam = _return_103._return_103)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static object objectParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_32 appclass063Param()
	{
		return null;
	}
}
