using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns61;
using ns62;
using ns64;

namespace ns44;

[StandardModule]
internal sealed class GetStatic_15
{
	public struct AppStruct_905
	{
		public string _string_30;

		public double doubleParam;

		public double doubleParam;

		public int intParam;

		public bool boolParam;

		public string _string_2;
	}

	public class GetStatic_2
	{
		[CompilerGenerated]
		private string _string_30;

		[CompilerGenerated]
		private diem diemParam;

		private static object objectParam;

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public diem diemParam()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void voidParam(diem diemParam)
		{
		}

		public GetStatic_2(string _string_2, diem diemParam)
		{
		}

		static GetStatic_2()
		{
			AppClass_960.voidParam();
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					_goto_4:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							AppClass_960.voidParam();
							num3 = _return_57;
							if (AppClass_031.class730_0.int_62 == _return_57)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 990:
								goto _goto_4;
							case 9:
								return;
							}
							goto case 1;
						case _return_57:
							AppClass_960.voidParam();
							goto case 2;
						case 2:
							AppClass_969.voidParam();
							num = 3;
							if (AppClass_031.class730_0.int_7 != _return_57)
							{
								num = 9;
							}
							break;
						}
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

		internal static GetStatic_2 appclass906Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_3
	{
		public static readonly GetStatic_3 _appclass907_5;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, string> stringParam;

		public static Func<AppClass_318.AppClass_334, Polygon> polygonParam;

		public static Func<CurveXYZ, double> doubleParam;

		public static Func<CurveXYZ, bool> boolParam;

		public static Func<CurveXYZ, bool> boolParam;

		public static Func<Tuple<CurveXYZ, double>, double> doubleParam;

		public static Func<Tuple<CurveXYZ, double>, CurveXYZ> curvexyzParam;

		public static Func<Tuple<CurveXYZ, double>, double> doubleParam;

		public static Func<Tuple<CurveXYZ, double>, CurveXYZ> curvexyzParam;

		public static Comparison<Polygon> comparisonPolygonParam;

		public static Comparison<Polygon> comparisonPolygonParam;

		public static Comparison<Info_Slab3D> comparisonInfoSlab3dParam;

		public static Func<info_revit_slab, Info_Slab3D> infoSlab3dParam;

		public static Func<AppStruct_905, int> intParam;

		private static GetStatic_3 _appclass907_6;

		static GetStatic_3()
		{
			AppClass_960.voidParam();
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
						case 4:
							AppClass_967.boolParam();
							num3 = 3;
							if (AppClass_031.class730_0.int_78 == _return_57)
							{
								continue;
							}
							goto case _return_57;
						default:
							if (num2 != 11)
							{
								goto _goto_7;
							}
							AppClass_969.voidParam();
							goto case 4;
						case 2:
							AppClass_960.voidParam();
							break;
						case 1:
							break;
						case _return_57:
							_appclass907_5 = new GetStatic_3();
							return;
						case 3:
							return;
						}
						goto _goto_8;
						continue;
						_goto_7:
						break;
					}
					continue;
					_goto_8:
					break;
				}
				while (num2 == 992);
				AppClass_960.voidParam();
				num = 11;
				if (AppClass_031.class730_0.int_12 != _return_57)
				{
					num = 2;
				}
			}
		}

		[SpecialName]
		internal string diemParam(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return null;
		}

		[SpecialName]
		internal Polygon voidParam(AppClass_318.AppClass_334 gclass148_0)
		{
			return null;
		}

		[SpecialName]
		internal double doubleParam(CurveXYZ _curvexyz_19)
		{
			return _return_57._return_57;
		}

		[SpecialName]
		internal bool boolParam(CurveXYZ _curvexyz_19)
		{
			return true;
		}

		[SpecialName]
		internal bool boolParam(CurveXYZ _curvexyz_19)
		{
			return true;
		}

		[SpecialName]
		internal double doubleParam(Tuple<CurveXYZ, double> doubleParam)
		{
			return _return_57._return_57;
		}

		[SpecialName]
		internal CurveXYZ curvexyzParam(Tuple<CurveXYZ, double> doubleParam)
		{
			return null;
		}

		[SpecialName]
		internal double doubleParam(Tuple<CurveXYZ, double> doubleParam)
		{
			return _return_57._return_57;
		}

		[SpecialName]
		internal CurveXYZ curvexyzParam(Tuple<CurveXYZ, double> doubleParam)
		{
			return null;
		}

		[SpecialName]
		internal int intParam(Polygon polygonParam, Polygon polygonParam)
		{
			return _return_57;
		}

		[SpecialName]
		internal int intParam(Polygon polygonParam, Polygon polygonParam)
		{
			return _return_57;
		}

		[SpecialName]
		internal int intParam(Info_Slab3D info_Slab3D_0, Info_Slab3D info_Slab3D_1)
		{
			return _return_57;
		}

		[SpecialName]
		internal Info_Slab3D infoSlab3dParam(info_revit_slab info_revit_slab_0)
		{
			return null;
		}

		[SpecialName]
		internal int intParam(AppStruct_905 _appstruct905_40)
		{
			return _return_57;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_3 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_4
	{
		public diem diemParam;

		public diem diemParam;

		internal static GetStatic_4 _appclass908_13;

		[SpecialName]
		internal double diemParam(diem diemParam)
		{
			return _return_57._return_57;
		}

		[SpecialName]
		internal double voidParam(diem diemParam)
		{
			return _return_57._return_57;
		}

		static GetStatic_4()
		{
			AppClass_960.voidParam();
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
							AppClass_960.voidParam();
							num3 = 9;
							if (AppClass_031.class730_0.int_97 != _return_57)
							{
								continue;
							}
							goto case _return_57;
						case _return_57:
							AppClass_960.voidParam();
							num3 = 9;
							if (AppClass_031.class730_0.int_15 != _return_57)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_14;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						}
						goto _goto_15;
						continue;
						_goto_14:
						break;
					}
					continue;
					_goto_15:
					break;
				}
				AppClass_969.voidParam();
				num = 9;
				if (AppClass_031.class730_0.int_39 != _return_57)
				{
					num = 2;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_4 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_6
	{
		public diem diemParam;

		private static GetStatic_6 _appclass909_16;

		public GetStatic_6(GetStatic_6 class642_1)
		{
		}

		[SpecialName]
		internal bool diemParam(Info_ColumnWall3D info_ColumnWall3D_0)
		{
			return true;
		}

		static GetStatic_6()
		{
			AppClass_960.voidParam();
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
						case _return_57:
							AppClass_969.voidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_99 != _return_57)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_17;
								}
							}
							else
							{
								AppClass_960.voidParam();
								num3 = 6;
								if (AppClass_031.class730_0.int_82 == _return_57)
								{
									continue;
								}
							}
							goto case _return_57;
						case 2:
							break;
						case 1:
							return;
						}
						goto _goto_18;
						continue;
						_goto_17:
						break;
					}
					continue;
					_goto_18:
					break;
				}
				AppClass_960.voidParam();
				num = 7;
				if (AppClass_031.class730_0.int_8 != _return_57)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_6 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_8
	{
		public CurveXYZ _curvexyz_19;

		public diem diemParam;

		internal static GetStatic_8 _appclass910_20;

		public GetStatic_8(GetStatic_8 class643_1)
		{
		}

		[SpecialName]
		internal bool diemParam(Polygon polygonParam)
		{
			return true;
		}

		[SpecialName]
		internal bool voidParam(Polygon polygonParam)
		{
			return true;
		}

		static GetStatic_8()
		{
			AppClass_960.voidParam();
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
							AppClass_969.voidParam();
							num3 = _return_57;
							if (AppClass_031.class730_0.int_64 != _return_57)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_21;
								}
							}
							else
							{
								AppClass_960.voidParam();
								num3 = 4;
								if (AppClass_031.class730_0.int_113 == _return_57)
								{
									continue;
								}
							}
							goto case 1;
						case 2:
							break;
						case _return_57:
							return;
						}
						goto _goto_22;
						continue;
						_goto_21:
						break;
					}
					continue;
					_goto_22:
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

		internal static GetStatic_8 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_10
	{
		public string _string_30;

		internal static GetStatic_10 _appclass911_24;

		public GetStatic_10(GetStatic_10 class644_1)
		{
		}

		[SpecialName]
		internal bool diemParam(AppClass_404.AppClass_405 gclass185_0)
		{
			return true;
		}

		[SpecialName]
		internal bool voidParam(AppClass_404.AppClass_405 gclass185_0)
		{
			return true;
		}

		static GetStatic_10()
		{
			AppClass_960.voidParam();
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
							num3 = _return_57;
							if (AppClass_031.class730_0.int_74 == _return_57)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_28;
								}
								goto case _return_57;
							}
							return;
						case _return_57:
							AppClass_969.voidParam();
							num = 5;
							if (AppClass_031.class730_0.int_54 != _return_57)
							{
								num = 9;
							}
							break;
						case 2:
							AppClass_960.voidParam();
							num = 1;
							break;
						}
						goto _goto_26;
						continue;
						_goto_28:
						break;
					}
					continue;
					_goto_26:
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_10 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_12
	{
		public Tuple<string, diem> doubleParam;

		internal static GetStatic_12 _appclass912_27;

		public GetStatic_12(GetStatic_12 class645_1)
		{
		}

		[SpecialName]
		internal bool diemParam(AppClass_318.AppClass_331 gclass145_0)
		{
			return true;
		}

		static GetStatic_12()
		{
			AppClass_960.voidParam();
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
							AppClass_960.voidParam();
							num3 = 7;
							if (AppClass_031.class730_0.int_33 != _return_57)
							{
								continue;
							}
							goto case _return_57;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_28;
								}
								goto case 2;
							}
							return;
						case _return_57:
							AppClass_960.voidParam();
							num = 2;
							break;
						case 2:
							AppClass_969.voidParam();
							num = 2;
							if (AppClass_031.class730_0.int_108 == _return_57)
							{
								num = 9;
							}
							break;
						}
						goto _goto_29;
						continue;
						_goto_28:
						break;
					}
					continue;
					_goto_29:
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_12 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_13
	{
		public string _string_30;

		internal static GetStatic_13 _appclass913_31;

		[SpecialName]
		internal void diemParam()
		{
		}

		static GetStatic_13()
		{
			AppClass_960.voidParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						_goto_32:
						switch (num3)
						{
						case 2:
							AppClass_960.voidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_79 != _return_57)
							{
								continue;
							}
							goto default;
						default:
							while (num2 == 9)
							{
								AppClass_969.voidParam();
								num3 = _return_57;
								if (AppClass_031.class730_0.int_18 != _return_57)
								{
									continue;
								}
								goto _goto_32;
							}
							goto _goto_33;
						case 1:
							break;
						case _return_57:
							return;
						}
						goto _goto_34;
						continue;
						_goto_33:
						break;
					}
					continue;
					_goto_34:
					break;
				}
				while (num2 == 990);
				AppClass_960.voidParam();
				num = 9;
				if (AppClass_031.class730_0.int_75 == _return_57)
				{
					num = 6;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_13 appclass906Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_14
	{
		public List<info_CurveGrid> _listAppstruct905_41;

		public List<AppClass_318.AppClass_331> _listPolygon_42;

		internal static GetStatic_14 _appclass914_37;

		[SpecialName]
		internal void diemParam()
		{
		}

		static GetStatic_14()
		{
			AppClass_960.voidParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					_goto_39:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 2:
							AppClass_960.voidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_7 == _return_57)
							{
								continue;
							}
							goto case 1;
						case 1:
							AppClass_960.voidParam();
							num = 9;
							if (AppClass_031.class730_0.int_100 != _return_57)
							{
								num = 4;
							}
							goto _goto_38;
						case _return_57:
							return;
						}
						switch (num2)
						{
						case 9:
							AppClass_969.voidParam();
							num3 = 5;
							if (AppClass_031.class730_0.int_68 == _return_57)
							{
								continue;
							}
							return;
						default:
							return;
						case 990:
							break;
						}
						goto _goto_39;
						continue;
						_goto_38:
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

		internal static GetStatic_14 appclass906Param()
		{
			return null;
		}
	}

	public static object objectParam;

	public static object objectParam;

	public static object objectParam;

	public static AppStruct_905 _appstruct905_40;

	public static List<AppStruct_905> _listAppstruct905_41;

	public static Dictionary<string, AppStruct_905> appstruct905Param;

	public static List<Polygon> _listPolygon_42;

	public static Dictionary<int, List<string>> listStringParam;

	public static int intParam;

	private static List<string> _listString_43;

	private static List<string> _listString_44;

	private static List<string> _listString_45;

	private static List<string> _listString_46;

	private static List<string> _listString_47;

	private static Dictionary<string, List<List<Info_Beam3D>>> listListInfoBeam3dParam;

	private static List<Info_ColumnWall3D> _listInfoColumnwall3d_48;

	private static List<Info_Beam3D> _listInfoBeam3d_49;

	private static List<info_revit_slab> _listInfoRevitSlab_50;

	private static List<diem> _listDiem_51;

	private static List<CurveXYZ> _listCurvexyz_52;

	internal static object objectParam;

	static GetStatic_15()
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		AppClass_960.voidParam();
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					_goto_53:
					switch (num3)
					{
					case 9:
						AppClass_960.voidParam();
						num3 = 10;
						if (AppClass_031.class730_0.int_52 != _return_57)
						{
							continue;
						}
						goto case 8;
					case 8:
						AppClass_960.voidParam();
						num3 = 5;
						if (AppClass_031.class730_0.int_86 == _return_57)
						{
							continue;
						}
						goto default;
					default:
						while (num2 == 16)
						{
							_listCurvexyz_52 = new List<CurveXYZ>();
							num3 = _return_57;
							if (AppClass_031.class730_0.int_109 == _return_57)
							{
								continue;
							}
							goto _goto_53;
						}
						if (num2 == 997)
						{
							goto _goto_54;
						}
						goto case 9;
					case 7:
						objectParam = new AppForm_894();
						num3 = 1;
						if (AppClass_031.class730_0.int_46 != _return_57)
						{
							continue;
						}
						goto case 9;
					case 6:
						AppClass_967.boolParam();
						goto case 7;
					case 5:
						AppClass_969.voidParam();
						num3 = 6;
						if (AppClass_031.class730_0.int_113 != _return_57)
						{
							continue;
						}
						goto default;
					case 3:
						_listAppstruct905_41 = new List<AppStruct_905>();
						num3 = 4;
						if (AppClass_031.class730_0.int_28 != _return_57)
						{
							continue;
						}
						goto case 7;
					case 1:
						objectParam = (object)new diem();
						num3 = 3;
						if (AppClass_031.class730_0.intParam != _return_57)
						{
							continue;
						}
						goto default;
					case 4:
						intParam = _return_57;
						break;
					case 2:
						break;
					case _return_57:
						return;
					}
					goto _goto_55;
					continue;
					_goto_54:
					break;
				}
				continue;
				_goto_55:
				break;
			}
			_listDiem_51 = new List<diem>();
			num = 16;
			if (AppClass_031.class730_0.int_111 == _return_57)
			{
				num = 16;
			}
		}
	}

	public static bool boolParam()
	{
		return true;
	}

	public static int appclass906Param()
	{
		return _return_57;
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam, int intParam = 1)
	{
	}

	public static double doubleParam(ref double doubleParam)
	{
		return _return_57._return_57;
	}

	public static void voidParam(ref diem diemParam, double doubleParam = _return_57._return_57)
	{
	}

	public static void voidParam(ref diem diemParam)
	{
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(List<info_CurveGrid> listInfoCurvegridParam)
	{
		return true;
	}

	public static bool boolParam(List<info_CurveGrid> listInfoCurvegridParam)
	{
		return true;
	}

	public static void voidParam(object objectParam, TypeBeam typeBeam_0)
	{
	}

	public static void voidParam(ref Info_Beam3D info_Beam3D_0, ref CurveXYZ _curvexyz_19, double doubleParam, object objectParam, ref diem diemParam, ref diem diemParam)
	{
	}

	public static void voidParam(object objectParam, object objectParam, int intParam, ref diem diemParam, ref diem diemParam, int intParam)
	{
	}

	public static void voidParam(object objectParam, object objectParam, ref diem diemParam, ref diem diemParam)
	{
	}

	public static void voidParam(ref Info_Beam3D info_Beam3D_0, ref Info_Beam3D info_Beam3D_1)
	{
	}

	public static void voidParam(bool boolParam = false, List<AppClass_318.AppClass_334> listInfoCurvegridParam = null)
	{
	}

	public static CurveXYZ curvexyzParam(object objectParam, List<AppClass_318.AppClass_334> listInfoCurvegridParam)
	{
		return null;
	}

	public static List<GetStatic_2> listAppclass906Param()
	{
		return null;
	}

	public static List<GetStatic_2> listAppclass906Param()
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam)
	{
		return null;
	}

	private static Tuple<string, string> stringParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, double doubleParam)
	{
	}

	public static void voidParam(object objectParam, object objectParam)
	{
	}

	public static List<Polygon> listPolygonParam(object objectParam)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(List<AppClass_318.AppClass_344> listInfoCurvegridParam)
	{
		return null;
	}

	public static void voidParam(List<AppClass_318.AppClass_330> listInfoCurvegridParam)
	{
	}

	public static void voidParam(object objectParam)
	{
	}

	private static void voidParam(List<AppClass_404.AppClass_405> listInfoCurvegridParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
	}

	private static Tuple<CurveXYZ, CurveXYZ> curvexyzParam(object objectParam, object objectParam)
	{
		return null;
	}

	private static void voidParam(List<AppClass_404.AppClass_405> listInfoCurvegridParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, object objectParam, double doubleParam, object objectParam)
	{
	}

	private static Tuple<double, double> doubleParam(object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	private static string stringParam(double doubleParam)
	{
		return null;
	}

	public static void voidParam(List<AppClass_318.AppClass_344> listInfoCurvegridParam)
	{
	}

	public static void voidParam(List<AppClass_318.AppClass_334> listInfoCurvegridParam, List<Info_ColumnWall3D> listInfoColumnwall3dParam)
	{
	}

	private static void voidParam(List<AppClass_404.AppClass_405> listInfoCurvegridParam, string _string_30 = "", int intParam = 1)
	{
	}

	public static void voidParam(object objectParam, object objectParam)
	{
	}

	public static List<AppClass_404.AppClass_405> appclass405Param(ref string[] _string_30, ref string[] _string_2, ref int intParam, object objectParam)
	{
		return null;
	}

	public static List<diem> listDiemParam()
	{
		return null;
	}

	public static void voidParam()
	{
	}

	public static void voidParam(List<diem> listInfoCurvegridParam)
	{
	}

	public static List<Polygon> listPolygonParam(object objectParam)
	{
		return null;
	}

	public static List<Polygon> listPolygonParam(object objectParam, List<diem> listInfoCurvegridParam)
	{
		return null;
	}

	public static void voidParam(bool boolParam = false, List<Polygon> listInfoCurvegridParam = null, AppClass_318.AppClass_324 gclass142_0 = null)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(List<info_revit_slab> listInfoCurvegridParam, List<AppClass_318.AppClass_331> listInfoColumnwall3dParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(object objectParam, object objectParam, object objectParam, int intParam, object objectParam, bool boolParam = false)
	{
	}

	public static void voidParam(object objectParam, int intParam, object objectParam, bool boolParam = false)
	{
	}

	private static List<Tuple<CurveXYZ, double, double>> doubleParam(object objectParam)
	{
		return null;
	}

	internal static double doubleParam(double doubleParam, double doubleParam, double doubleParam)
	{
		return _return_57._return_57;
	}

	private static bool boolParam(object objectParam, object objectParam, double doubleParam, double doubleParam)
	{
		return true;
	}

	private static string stringParam(object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	private static bool boolParam(object objectParam, int intParam, object objectParam, object objectParam, double doubleParam, int intParam, object objectParam, List<string> listInfoCurvegridParam)
	{
		return true;
	}

	private static void voidParam(List<int> listInfoCurvegridParam, int intParam)
	{
	}

	private static void voidParam(object objectParam, List<string> listInfoCurvegridParam)
	{
	}

	private static int intParam(object objectParam)
	{
		return _return_57;
	}

	public static List<GetStatic_2> listAppclass906Param(object objectParam, double doubleParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static List<GetStatic_2> listAppclass906Param(object objectParam, object objectParam, object objectParam, object objectParam)
	{
		return null;
	}

	public static List<string> listStringParam(object objectParam, object objectParam, object objectParam, bool boolParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, int intParam)
	{
	}

	private static string stringParam(object objectParam, object objectParam, object objectParam, AppStruct_905 struct21_1, bool boolParam = false)
	{
		return null;
	}

	public static List<AppStruct_905> listAppstruct905Param(AppStruct_905 struct21_1)
	{
		return null;
	}

	public static List<string[]> smethod_65(object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(object objectParam)
	{
	}

	public static bool boolParam(bool boolParam, object objectParam)
	{
		return true;
	}

	public static bool boolParam()
	{
		return true;
	}

	private static void voidParam(List<AppClass_318.AppClass_331> listInfoCurvegridParam)
	{
	}

	public static AppStruct_905 appstruct905Param(int intParam)
	{
		return (AppStruct_905)(object)null;
	}

	public static void voidParam(AppClass_318.AppEnum_319 genum5_0 = AppClass_318.AppEnum_319.const_0, bool boolParam = false, AppClass_318.AppClass_324 gclass142_0 = null)
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_15 appclass904Param()
	{
		return null;
	}
}
