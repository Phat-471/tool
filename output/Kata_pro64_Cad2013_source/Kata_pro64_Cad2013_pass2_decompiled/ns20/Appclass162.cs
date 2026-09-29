using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns61;
using ns62;
using ns64;

namespace ns20;

[StandardModule]
internal sealed class GetStatic_44
{
	public enum AppEnum_163
	{

	}

	public enum AppEnum_164
	{

	}

	public enum AppEnum_165
	{

	}

	public class GetStatic_21
	{
		public class GetStatic_1
		{
			public List<GetStatic_23> _listObject_138;

			public List<GetStatic_23> _listAppclass181_107;

			private static object objectParam;

			static GetStatic_1()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 3;
								if (AppClass_031.class730_0.int_103 != _return_78)
								{
									continue;
								}
								goto case _return_78;
							case _return_78:
								AppClass_960.boolParam();
								num3 = 2;
								if (AppClass_031.class730_0.int_100 == _return_78)
								{
									continue;
								}
								goto default;
							default:
								if (num2 != 9)
								{
									if (num2 == 990)
									{
										goto _goto_72;
									}
									goto case 1;
								}
								return;
							case 2:
								break;
							}
							goto _goto_73;
							continue;
							_goto_72:
							break;
						}
						continue;
						_goto_73:
						break;
					}
					AppClass_969.voidParam();
					num = 7;
					if (AppClass_031.class730_0.int_77 == _return_78)
					{
						num = 9;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_1 appclass167Param()
			{
				return null;
			}
		}

		[Serializable]
		[CompilerGenerated]
		internal sealed class GetStatic_2
		{
			public static readonly GetStatic_2 _appclass168_5;

			public static Func<GetStatic_23, int> intParam;

			public static Func<GetStatic_23, double> doubleParam;

			public static Func<GetStatic_23, Polygon> polygonParam;

			public static Func<GetStatic_23, IEnumerable<object>> ienumerableObjectParam;

			public static Func<GetStatic_23, List<object>> listObjectParam;

			public static Func<List<object>, IEnumerable<object>> ienumerableObjectParam;

			public static Func<GetStatic_23, int> intParam;

			public static Func<GetStatic_23, bool> boolParam;

			public static Func<GetStatic_23, double> doubleParam;

			public static Func<GetStatic_23, double> doubleParam;

			public static Func<List<GetStatic_23>, double> doubleParam;

			public static Func<GetStatic_23, int> intParam;

			public static Predicate<GetStatic_23> predicateAppclass179Param;

			public static Func<GetStatic_23, bool> boolParam;

			public static Func<GetStatic_23, int> intParam;

			public static Comparison<GetStatic_23> comparisonAppclass179Param;

			public static Func<GetStatic_23, double> doubleParam;

			public static Func<Polygon, double> doubleParam;

			public static Comparison<Polygon> comparisonPolygonParam;

			public static Comparison<Tuple<diem, double>> doubleParam;

			public static Func<CurveXYZ, double> doubleParam;

			public static Func<CurveXYZ, double> doubleParam;

			public static Func<diem, double> doubleParam;

			public static Func<diem, double> doubleParam;

			public static Func<diem, double> doubleParam;

			public static Func<diem, double> doubleParam;

			public static Func<GetStatic_34, double> doubleParam;

			internal static GetStatic_2 _appclass168_6;

			static GetStatic_2()
			{
				AppClass_960.objectParam();
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
								AppClass_969.voidParam();
								goto case 3;
							case 3:
								AppClass_967.boolParam();
								num3 = 10;
								if (AppClass_031.class730_0.int_105 != _return_78)
								{
									continue;
								}
								break;
							case 1:
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_22 == _return_78)
								{
									continue;
								}
								goto case _return_78;
							case _return_78:
								AppClass_960.boolParam();
								goto case 4;
							default:
								if (num2 != 11)
								{
									if (num2 == 992)
									{
										goto _goto_44;
									}
									goto case _return_78;
								}
								return;
							case 2:
								break;
							}
							goto _goto_8;
							continue;
							_goto_44:
							break;
						}
						continue;
						_goto_8:
						break;
					}
					_appclass168_5 = new GetStatic_2();
					num = 11;
				}
			}

			[SpecialName]
			internal int intParam(GetStatic_23 _appclass179_70)
			{
				return _return_78;
			}

			[SpecialName]
			internal double doubleParam(GetStatic_23 _appclass179_70)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal Polygon polygonParam(GetStatic_23 _appclass179_70)
			{
				return null;
			}

			[SpecialName]
			internal IEnumerable<object> ienumerableObjectParam(GetStatic_23 _appclass179_70)
			{
				return null;
			}

			[SpecialName]
			internal List<object> listObjectParam(GetStatic_23 _appclass179_70)
			{
				return null;
			}

			[SpecialName]
			internal IEnumerable<object> ienumerableObjectParam(List<object> _listObject_138)
			{
				return null;
			}

			[SpecialName]
			internal int intParam(GetStatic_23 _appclass179_70)
			{
				return _return_78;
			}

			[SpecialName]
			internal bool boolParam(GetStatic_23 _appclass179_70)
			{
				return true;
			}

			[SpecialName]
			internal double doubleParam(GetStatic_23 _appclass179_70)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(List<GetStatic_23> _listObject_138)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(GetStatic_23 _appclass179_70)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal int intParam(GetStatic_23 _appclass179_70)
			{
				return _return_78;
			}

			[SpecialName]
			internal bool boolParam(GetStatic_23 _appclass179_70)
			{
				return true;
			}

			[SpecialName]
			internal bool boolParam(GetStatic_23 _appclass179_70)
			{
				return true;
			}

			[SpecialName]
			internal int intParam(GetStatic_23 _appclass179_70)
			{
				return _return_78;
			}

			[SpecialName]
			internal int intParam(GetStatic_23 _appclass179_70, GetStatic_23 class539_1)
			{
				return _return_78;
			}

			[SpecialName]
			internal double doubleParam(GetStatic_23 _appclass179_70)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(Polygon polygonParam)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal int intParam(Polygon polygonParam, Polygon polygonParam)
			{
				return _return_78;
			}

			[SpecialName]
			internal int intParam(Tuple<diem, double> doubleParam, Tuple<diem, double> doubleParam)
			{
				return _return_78;
			}

			[SpecialName]
			internal double doubleParam(CurveXYZ _curvexyz_55)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(CurveXYZ _curvexyz_55)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(diem diemParam)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(diem diemParam)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(diem diemParam)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(diem diemParam)
			{
				return _return_78._return_78;
			}

			[SpecialName]
			internal double doubleParam(GetStatic_34 class545_0)
			{
				return _return_78._return_78;
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_2 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_3
		{
			public string _string_22;

			private static GetStatic_3 _appclass169_17;

			[SpecialName]
			internal bool intParam(GetStatic_23 _appclass179_70)
			{
				return true;
			}

			[SpecialName]
			internal bool doubleParam(GetStatic_23 _appclass179_70)
			{
				return true;
			}

			static GetStatic_3()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								goto _goto_20;
							case 1:
								goto _goto_20;
							default:
								switch (num2)
								{
								default:
									goto _goto_20;
								case 990:
									break;
								case 9:
									return;
								}
								break;
							case _return_78:
								{
									AppClass_969.voidParam();
									num = 9;
									if (AppClass_031.class730_0.int_54 == _return_78)
									{
										num = 6;
									}
									goto _goto_93;
								}
								_goto_20:
								AppClass_960.boolParam();
								num3 = 9;
								if (AppClass_031.class730_0.int_4 != _return_78)
								{
									continue;
								}
								goto case _return_78;
							}
							break;
						}
						continue;
						_goto_93:
						break;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_3 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_5
		{
			public string _string_22;

			private static GetStatic_5 _appclass170_23;

			public GetStatic_5(GetStatic_5 class530_1)
			{
			}

			[SpecialName]
			internal int intParam(GetStatic_23 _appclass179_70, GetStatic_23 class539_1)
			{
				return _return_78;
			}

			static GetStatic_5()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_68 != _return_78)
								{
									continue;
								}
								goto default;
							case 1:
								AppClass_960.boolParam();
								num3 = _return_78;
								if (AppClass_031.class730_0.int_58 == _return_78)
								{
									continue;
								}
								goto default;
							default:
								if (num2 != 9)
								{
									if (num2 == 990)
									{
										goto _goto_93;
									}
									goto case 1;
								}
								return;
							case _return_78:
								break;
							}
							goto _goto_94;
							continue;
							_goto_93:
							break;
						}
						continue;
						_goto_94:
						break;
					}
					AppClass_969.voidParam();
					num = 3;
					if (AppClass_031.class730_0.int_9 != _return_78)
					{
						num = 9;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_5 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_7
		{
			public double doubleParam;

			private static GetStatic_7 _appclass171_27;

			public GetStatic_7(GetStatic_7 class531_1)
			{
			}

			[SpecialName]
			internal int intParam(GetStatic_25 _appclass181_65, GetStatic_25 class541_1)
			{
				return _return_78;
			}

			static GetStatic_7()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 9;
								if (AppClass_031.class730_0.int_110 != _return_78)
								{
									continue;
								}
								goto case _return_78;
							case _return_78:
								AppClass_960.boolParam();
								num3 = 3;
								if (AppClass_031.class730_0.int_107 != _return_78)
								{
									continue;
								}
								break;
							default:
								if (num2 != 9)
								{
									if (num2 == 990)
									{
										goto _goto_100;
									}
									goto case 1;
								}
								return;
							case 2:
								break;
							}
							goto _goto_34;
							continue;
							_goto_100:
							break;
						}
						continue;
						_goto_34:
						break;
					}
					AppClass_969.voidParam();
					num = 9;
					if (AppClass_031.class730_0.int_26 == _return_78)
					{
						num = _return_78;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_7 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_9
		{
			public bool boolParam;

			public bool boolParam;

			internal static GetStatic_9 _appclass172_31;

			public GetStatic_9(GetStatic_9 class532_1)
			{
			}

			[SpecialName]
			internal int intParam(diem diemParam, diem diemParam)
			{
				return _return_78;
			}

			static GetStatic_9()
			{
				AppClass_960.objectParam();
				int num = 2;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int num3 = num2;
						while (true)
						{
							_goto_35:
							switch (num3)
							{
							case 2:
								AppClass_960.boolParam();
								num3 = 9;
								if (AppClass_031.class730_0.int_45 == _return_78)
								{
									continue;
								}
								goto _goto_34;
							case 1:
								goto _goto_34;
							case _return_78:
								return;
								_goto_38:
								while (num2 == 9)
								{
									AppClass_969.voidParam();
									num3 = _return_78;
									if (AppClass_031.class730_0.int_94 == _return_78)
									{
										continue;
									}
									goto _goto_35;
								}
								goto _goto_36;
								_goto_36:
								if (num2 == 990)
								{
									goto _goto_100;
								}
								goto case 2;
							}
							goto _goto_38;
							continue;
							_goto_100:
							break;
						}
						continue;
						_goto_34:
						break;
					}
					AppClass_960.boolParam();
					num = 9;
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_9 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_11
		{
			public GetStatic_23 _appclass179_70;

			public Polygon polygonParam;

			public GetStatic_21 _appclass166_40;

			internal static GetStatic_11 _appclass173_41;

			public GetStatic_11(GetStatic_11 class533_1)
			{
			}

			[SpecialName]
			internal int intParam(List<diem> _listObject_138, List<diem> _listAppclass181_107)
			{
				return _return_78;
			}

			static GetStatic_11()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 4;
								if (AppClass_031.class730_0.int_93 == _return_78)
								{
									continue;
								}
								goto case 1;
							case 1:
								AppClass_960.boolParam();
								num3 = 8;
								if (AppClass_031.class730_0.int_79 == _return_78)
								{
									continue;
								}
								break;
							default:
								if (num2 == 9)
								{
									return;
								}
								goto _goto_43;
							case _return_78:
								break;
							}
							goto _goto_44;
							continue;
							_goto_43:
							break;
						}
						continue;
						_goto_44:
						break;
					}
					while (num2 == 990);
					AppClass_969.voidParam();
					num = 1;
					if (AppClass_031.class730_0.int_118 == _return_78)
					{
						num = 9;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_11 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_13
		{
			public List<diem> _listObject_138;

			public List<diem> _listAppclass181_107;

			internal static GetStatic_13 _appclass174_47;

			public GetStatic_13(GetStatic_13 class534_1)
			{
			}

			[SpecialName]
			internal int intParam(GetStatic_25 _appclass181_65, GetStatic_25 class541_1)
			{
				return _return_78;
			}

			[SpecialName]
			internal int doubleParam(GetStatic_25 _appclass181_65, GetStatic_25 class541_1)
			{
				return _return_78;
			}

			static GetStatic_13()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_7 != _return_78)
								{
									continue;
								}
								goto _goto_54;
							case 1:
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_48 == _return_78)
								{
									continue;
								}
								goto _goto_54;
							default:
								switch (num2)
								{
								case 990:
									goto _goto_52;
								case 9:
									return;
								}
								goto _goto_54;
							case _return_78:
								goto _goto_54;
								_goto_52:
								break;
							}
							break;
						}
						continue;
						_goto_54:
						break;
					}
					AppClass_969.voidParam();
					num = 9;
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_13 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_15
		{
			public CurveXYZ _curvexyz_55;

			public GetStatic_17 _appclass176_62;

			private static GetStatic_15 _appclass175_57;

			public GetStatic_15(GetStatic_15 class535_1)
			{
			}

			[SpecialName]
			internal bool intParam(CurveXYZ curveXYZ_1)
			{
				return true;
			}

			[SpecialName]
			internal bool doubleParam(CurveXYZ curveXYZ_1)
			{
				return true;
			}

			static GetStatic_15()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 9;
								if (AppClass_031.class730_0.int_60 != _return_78)
								{
									continue;
								}
								goto case 1;
							case 1:
								AppClass_960.boolParam();
								num3 = _return_78;
								if (AppClass_031.class730_0.int_6 != _return_78)
								{
									continue;
								}
								break;
							case _return_78:
								goto _goto_73;
								_goto_61:
								if (num2 == 9)
								{
									return;
								}
								goto _goto_59;
								_goto_59:
								if (num2 == 990)
								{
									goto _goto_72;
								}
								goto case 2;
							}
							goto _goto_61;
							continue;
							_goto_72:
							break;
						}
						continue;
						_goto_73:
						break;
					}
					AppClass_969.voidParam();
					num = 9;
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_15 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_17
		{
			public double doubleParam;

			private static GetStatic_17 _appclass176_62;

			public GetStatic_17(GetStatic_17 class536_1)
			{
			}

			static GetStatic_17()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 4;
								if (AppClass_031.class730_0.int_66 != _return_78)
								{
									continue;
								}
								goto _goto_94;
							case _return_78:
								goto _goto_94;
							case 2:
								return;
							}
							switch (num2)
							{
							case 9:
								AppClass_969.voidParam();
								num3 = 5;
								if (AppClass_031.class730_0.int_48 == _return_78)
								{
									continue;
								}
								return;
							default:
								return;
							case 990:
								break;
							}
							break;
						}
						continue;
						_goto_94:
						break;
					}
					AppClass_960.boolParam();
					num = 9;
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_17 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_18
		{
			public GetStatic_25 _appclass181_65;

			private static GetStatic_18 _appclass177_66;

			[SpecialName]
			internal diem intParam(diem diemParam)
			{
				return null;
			}

			static GetStatic_18()
			{
				AppClass_960.objectParam();
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int num3 = num2;
						while (true)
						{
							_goto_127:
							switch (num3)
							{
							case 1:
								do
								{
									AppClass_960.boolParam();
									num3 = _return_78;
								}
								while (AppClass_031.class730_0.int_14 == _return_78);
								continue;
							case _return_78:
								goto _goto_129;
							case 2:
								return;
							}
							while (true)
							{
								switch (num2)
								{
								case 9:
									goto _goto_80;
								default:
									return;
								case 990:
									break;
								}
								break;
								_goto_80:
								AppClass_969.voidParam();
								num3 = 2;
								if (AppClass_031.class730_0.int_87 != _return_78)
								{
									continue;
								}
								goto _goto_127;
							}
							break;
						}
						continue;
						_goto_129:
						break;
					}
					AppClass_960.boolParam();
					num = 9;
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_18 appclass167Param()
			{
				return null;
			}
		}

		[CompilerGenerated]
		internal sealed class GetStatic_20
		{
			public GetStatic_23 _appclass179_70;

			internal static GetStatic_20 _appclass178_71;

			public GetStatic_20(GetStatic_20 class538_1)
			{
			}

			[SpecialName]
			internal double intParam(Tuple<object, Polygon> doubleParam)
			{
				return _return_78._return_78;
			}

			static GetStatic_20()
			{
				AppClass_960.objectParam();
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
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_98 != _return_78)
								{
									continue;
								}
								return;
							default:
								if (num2 != 9)
								{
									if (num2 == 990)
									{
										goto _goto_72;
									}
									goto case 2;
								}
								AppClass_969.voidParam();
								num3 = _return_78;
								if (AppClass_031.class730_0.int_90 != _return_78)
								{
									continue;
								}
								return;
							case 1:
								break;
							case _return_78:
								return;
							}
							goto _goto_73;
							continue;
							_goto_72:
							break;
						}
						continue;
						_goto_73:
						break;
					}
					AppClass_960.boolParam();
					num = 9;
					if (AppClass_031.class730_0.int_9 == _return_78)
					{
						num = 4;
					}
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_20 appclass167Param()
			{
				return null;
			}
		}

		public bool boolParam;

		public object objectParam;

		public object objectParam;

		public object objectParam;

		public AppEnum_165 enum21_0;

		public object objectParam;

		public object objectParam;

		public bool boolParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public AppEnum_163 enum19_0;

		public AppEnum_164 enum20_0;

		public object objectParam;

		public int intParam;

		public object objectParam;

		public object objectParam;

		public int intParam;

		public List<GetStatic_23> _listObject_138;

		public List<List<GetStatic_23>> _listAppclass181_107;

		public List<GetStatic_31> _listDiem_108;

		public double doubleParam;

		public List<object> _listString_109;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		internal static object objectParam;

		private GetStatic_23 intParam(GetStatic_23 _appclass179_70)
		{
			return null;
		}

		private List<GetStatic_23> doubleParam(List<GetStatic_23> _listAppclass182_110, string _string_22)
		{
			return null;
		}

		public void polygonParam()
		{
		}

		private List<GetStatic_23> ienumerableObjectParam(List<GetStatic_23> _listAppclass182_110)
		{
			return null;
		}

		private Tuple<diem, double, diem> listObjectParam(Polygon polygonParam, Polygon polygonParam)
		{
			return null;
		}

		public void ienumerableObjectParam(bool boolParam = false)
		{
		}

		private bool intParam(List<GetStatic_23> _listAppclass182_110, List<GetStatic_23> listAppclass179Param)
		{
			return true;
		}

		private bool boolParam(string _string_22)
		{
			return true;
		}

		private List<GetStatic_23> doubleParam(List<GetStatic_23> _listAppclass182_110)
		{
			return null;
		}

		public Tuple<bool, GetStatic_31, List<GetStatic_23>, List<GetStatic_23>> doubleParam(List<GetStatic_23> _listAppclass182_110, GetStatic_31 class543_0, bool boolParam = false, bool boolParam = false, int intParam = 6, int intParam = _return_78)
		{
			return null;
		}

		private void doubleParam(GetStatic_31 class543_0, double doubleParam)
		{
		}

		private void intParam(GetStatic_31 class543_0, GetStatic_23 _appclass179_70, double doubleParam, bool boolParam)
		{
		}

		private List<diem> boolParam(GetStatic_23 _appclass179_70, Polygon polygonParam, diem diemParam)
		{
			return null;
		}

		private List<diem> boolParam(List<Polygon> _listAppclass182_110, Polygon polygonParam, GetStatic_23 _appclass179_70)
		{
			return null;
		}

		private void intParam(GetStatic_31 class543_0, List<GetStatic_23> _listAppclass182_110, GetStatic_23 _appclass179_70, double doubleParam, AppEnum_186 enum22_0, double doubleParam, double doubleParam)
		{
		}

		public GetStatic_1 intParam(List<GetStatic_23> _listAppclass182_110, GetStatic_31 class543_0, bool boolParam, double doubleParam, double doubleParam, double doubleParam, double doubleParam, AppEnum_186 enum22_0, int intParam, string _string_22, double doubleParam, double doubleParam, double doubleParam, bool boolParam)
		{
			return null;
		}

		private Polygon doubleParam(Polygon polygonParam, double doubleParam, double doubleParam)
		{
			return null;
		}

		private Polygon doubleParam(Polygon polygonParam, double doubleParam, double doubleParam)
		{
			return null;
		}

		private Polygon intParam(Polygon polygonParam, double doubleParam, List<CurveXYZ> _listAppclass182_110)
		{
			return null;
		}

		private List<diem> intParam(GetStatic_25 _appclass181_65, GetStatic_31 class543_0, bool boolParam)
		{
			return null;
		}

		public List<diem> doubleParam(Polygon polygonParam)
		{
			return null;
		}

		private double doubleParam(Polygon polygonParam, Polygon polygonParam)
		{
			return _return_78._return_78;
		}

		private List<GetStatic_31> doubleParam(List<GetStatic_23> _listAppclass182_110)
		{
			return null;
		}

		private List<GetStatic_23> doubleParam(GetStatic_23 _appclass179_70, bool boolParam, double doubleParam, double doubleParam = -1._return_78)
		{
			return null;
		}

		public void doubleParam()
		{
		}

		[SpecialName]
		[CompilerGenerated]
		private int doubleParam(GetStatic_23 _appclass179_70, GetStatic_23 class539_1)
		{
			return _return_78;
		}

		static GetStatic_21()
		{
			AppClass_960.objectParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						_goto_127:
						switch (num3)
						{
						case 2:
							do
							{
								AppClass_960.boolParam();
								num3 = 1;
							}
							while (AppClass_031.class730_0.int_79 == _return_78);
							continue;
						case 1:
							goto _goto_129;
						case _return_78:
							return;
						}
						while (true)
						{
							switch (num2)
							{
							case 9:
								goto _goto_80;
							default:
								return;
							case 990:
								break;
							}
							break;
							_goto_80:
							AppClass_969.voidParam();
							num3 = _return_78;
							if (AppClass_031.class730_0.int_28 == _return_78)
							{
								continue;
							}
							goto _goto_127;
						}
						break;
					}
					continue;
					_goto_129:
					break;
				}
				AppClass_960.boolParam();
				num = 8;
				if (AppClass_031.class730_0.int_118 == _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_21 appclass167Param()
		{
			return null;
		}
	}

	public class GetStatic_23
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class GetStatic_22
		{
			public static readonly GetStatic_22 _appclass180_82;

			public static Func<GetStatic_23, GetStatic_23> intParam;

			internal static GetStatic_22 _appclass180_83;

			static GetStatic_22()
			{
				AppClass_960.objectParam();
				int num = 2;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int num3 = num2;
						while (true)
						{
							_goto_85:
							switch (num3)
							{
							case 4:
								_appclass180_82 = new GetStatic_22();
								num3 = 9;
								if (AppClass_031.class730_0.int_102 != _return_78)
								{
									continue;
								}
								return;
							case 3:
								AppClass_967.boolParam();
								num3 = 4;
								if (AppClass_031.class730_0.int_48 == _return_78)
								{
									continue;
								}
								goto case 4;
							case 2:
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_28 != _return_78)
								{
									continue;
								}
								return;
							case 1:
								goto _goto_84;
							case _return_78:
								return;
								_goto_88:
								while (num2 == 11)
								{
									AppClass_969.voidParam();
									num3 = 3;
									if (AppClass_031.class730_0.int_12 != _return_78)
									{
										continue;
									}
									goto _goto_85;
								}
								goto _goto_86;
								_goto_86:
								if (num2 == 992)
								{
									goto _goto_87;
								}
								goto case 4;
							}
							goto _goto_88;
							continue;
							_goto_87:
							break;
						}
						continue;
						_goto_84:
						break;
					}
					AppClass_960.boolParam();
					num = 11;
				}
			}

			[SpecialName]
			internal GetStatic_23 intParam(GetStatic_23 _appclass179_70)
			{
				return null;
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_22 appclass167Param()
			{
				return null;
			}
		}

		public List<object> _listObject_138;

		public object objectParam;

		public object objectParam;

		public object objectParam;

		public object objectParam;

		public int intParam;

		public int intParam;

		public double doubleParam;

		public double doubleParam;

		public object objectParam;

		public bool boolParam;

		public object objectParam;

		public int intParam;

		public int intParam;

		public bool boolParam;

		public object objectParam;

		public bool boolParam;

		public List<GetStatic_23> _listAppclass181_107;

		public List<GetStatic_23> _listDiem_108;

		public double doubleParam;

		public object objectParam;

		private static object objectParam;

		public diem intParam(diem diemParam)
		{
			return null;
		}

		public GetStatic_23 doubleParam()
		{
			return null;
		}

		static GetStatic_23()
		{
			AppClass_960.objectParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						_goto_92:
						switch (num3)
						{
						case 2:
							do
							{
								AppClass_960.boolParam();
								num3 = 1;
							}
							while (AppClass_031.class730_0.int_37 != _return_78);
							continue;
						default:
							while (num2 == 9)
							{
								AppClass_969.voidParam();
								num3 = _return_78;
								if (AppClass_031.class730_0.int_43 != _return_78)
								{
									continue;
								}
								goto _goto_92;
							}
							if (num2 == 990)
							{
								goto _goto_93;
							}
							goto case 2;
						case 1:
							break;
						case _return_78:
							return;
						}
						goto _goto_94;
						continue;
						_goto_93:
						break;
					}
					continue;
					_goto_94:
					break;
				}
				AppClass_960.boolParam();
				num = 3;
				if (AppClass_031.class730_0.int_10 == _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_23 appclass167Param()
		{
			return null;
		}
	}

	public class GetStatic_25 : Polygon
	{
		public List<diem> _listObject_138;

		private static object objectParam;

		public GetStatic_25(Polygon polygonParam)
		{
		}

		public GetStatic_25 intParam()
		{
			return null;
		}

		static GetStatic_25()
		{
			AppClass_960.objectParam();
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
							AppClass_960.boolParam();
							num3 = _return_78;
							if (AppClass_031.class730_0.int_91 != _return_78)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 990:
								goto _goto_96;
							case 9:
								AppClass_969.voidParam();
								return;
							}
							goto case 1;
						case _return_78:
							break;
						case 2:
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
				AppClass_960.boolParam();
				num = 9;
				if (AppClass_031.class730_0.int_74 == _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_25 appclass167Param()
		{
			return null;
		}
	}

	public class GetStatic_27 : Polygon
	{
		public List<int> _listObject_138;

		internal static object objectParam;

		public GetStatic_27(Polygon polygonParam, List<int> _listAppclass181_107 = null)
		{
		}

		public GetStatic_27 intParam()
		{
			return null;
		}

		static GetStatic_27()
		{
			AppClass_960.objectParam();
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
							AppClass_960.boolParam();
							goto case 1;
						case 1:
							AppClass_960.boolParam();
							num3 = _return_78;
							if (AppClass_031.class730_0.int_30 == _return_78)
							{
								continue;
							}
							goto default;
						default:
							if (num2 == 9)
							{
								return;
							}
							goto _goto_99;
						case _return_78:
							break;
						}
						goto _goto_100;
						continue;
						_goto_99:
						break;
					}
					continue;
					_goto_100:
					break;
				}
				while (num2 == 990);
				AppClass_969.voidParam();
				num = 9;
				if (AppClass_031.class730_0.int_114 != _return_78)
				{
					num = 2;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_27 appclass167Param()
		{
			return null;
		}
	}

	public class GetStatic_31
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class GetStatic_28
		{
			public static readonly GetStatic_28 _appclass184_101;

			public static Func<GetStatic_27, GetStatic_27> intParam;

			public static Func<string, string> doubleParam;

			public static Func<string, string> polygonParam;

			public static Func<string, string> ienumerableObjectParam;

			public static Func<string, string> listObjectParam;

			private static GetStatic_28 _appclass184_102;

			static GetStatic_28()
			{
				AppClass_960.objectParam();
				int num = 2;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int num3 = num2;
						while (true)
						{
							_goto_103:
							switch (num3)
							{
							case 3:
								AppClass_969.voidParam();
								num3 = _return_78;
								if (AppClass_031.class730_0.int_81 != _return_78)
								{
									continue;
								}
								break;
							case 2:
								AppClass_960.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_108 == _return_78)
								{
									continue;
								}
								return;
							case 1:
								AppClass_960.boolParam();
								goto case 3;
							default:
								while (num2 == 11)
								{
									_appclass184_101 = new GetStatic_28();
									num3 = _return_78;
									if (AppClass_031.class730_0.int_33 != _return_78)
									{
										continue;
									}
									goto _goto_103;
								}
								if (num2 == 992)
								{
									goto _goto_104;
								}
								goto case 1;
							case 4:
								break;
							case _return_78:
								return;
							}
							goto _goto_105;
							continue;
							_goto_104:
							break;
						}
						continue;
						_goto_105:
						break;
					}
					AppClass_967.boolParam();
					num = 11;
					if (AppClass_031.class730_0.int_85 == _return_78)
					{
						num = 8;
					}
				}
			}

			[SpecialName]
			internal GetStatic_27 intParam(GetStatic_27 class542_0)
			{
				return null;
			}

			[SpecialName]
			internal string doubleParam(string _string_22)
			{
				return null;
			}

			[SpecialName]
			internal string polygonParam(string _string_22)
			{
				return null;
			}

			[SpecialName]
			internal string ienumerableObjectParam(string _string_22)
			{
				return null;
			}

			[SpecialName]
			internal string listObjectParam(string _string_22)
			{
				return null;
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_28 appclass167Param()
			{
				return null;
			}
		}

		public List<GetStatic_23> _listObject_138;

		public List<GetStatic_25> _listAppclass181_107;

		public List<diem> _listDiem_108;

		public double doubleParam;

		public List<string> _listString_109;

		public List<GetStatic_27> _listAppclass182_110;

		public int intParam;

		public int intParam;

		internal static object objectParam;

		public GetStatic_31 intParam()
		{
			return null;
		}

		public string doubleParam()
		{
			return null;
		}

		public List<string> polygonParam()
		{
			return null;
		}

		public GetStatic_31()
		{
		}

		public GetStatic_31(Polygon polygonParam, double doubleParam)
		{
		}

		static GetStatic_31()
		{
			AppClass_960.objectParam();
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
							num3 = _return_78;
							if (AppClass_031.class730_0.int_82 != _return_78)
							{
								continue;
							}
							goto default;
						default:
							do
							{
								switch (num2)
								{
								case 9:
									break;
								case 990:
									goto _goto_128;
								default:
									goto _goto_129;
								}
								AppClass_960.boolParam();
								num3 = 1;
							}
							while (AppClass_031.class730_0.int_94 == _return_78);
							continue;
						case 2:
							goto _goto_129;
						case _return_78:
							return;
							_goto_128:
							break;
						}
						break;
					}
					continue;
					_goto_129:
					break;
				}
				AppClass_960.boolParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_31 appclass167Param()
		{
			return null;
		}
	}

	public class GetStatic_34
	{
		public object objectParam;

		public object objectParam;

		public int intParam;

		public object objectParam;

		public bool boolParam;

		internal static object objectParam;

		public GetStatic_34(object objectParam, bool boolParam = false)
		{
		}

		public GetStatic_34()
		{
		}

		static GetStatic_34()
		{
			AppClass_960.objectParam();
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
							do
							{
								AppClass_969.voidParam();
								num3 = _return_78;
							}
							while (AppClass_031.class730_0.int_5 == _return_78);
							continue;
						default:
							if (num2 != 9)
							{
								goto _goto_114;
							}
							AppClass_960.boolParam();
							num3 = 2;
							if (AppClass_031.class730_0.intParam == _return_78)
							{
								continue;
							}
							return;
						case 1:
							break;
						case _return_78:
							return;
						}
						goto _goto_116;
						continue;
						_goto_114:
						break;
					}
					continue;
					_goto_116:
					break;
				}
				while (num2 == 990);
				AppClass_960.boolParam();
				num = 9;
				if (AppClass_031.class730_0.int_6 == _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_34 appclass167Param()
		{
			return null;
		}
	}

	public enum AppEnum_186
	{

	}

	public class GetStatic_36 : DrawJig
	{
		private Point3d point3d_0;

		private Point3d point3d_1;

		private object objectParam;

		internal static object objectParam;

		[SpecialName]
		public Polyline intParam()
		{
			return null;
		}

		public GetStatic_36(Point3d point3d_2)
		{
		}

		protected override SamplerStatus samplerstatusParam(JigPrompts jigPrompts_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		protected override bool boolParam(WorldDraw worldDraw_0)
		{
			return true;
		}

		static GetStatic_36()
		{
			AppClass_960.objectParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						_goto_118:
						switch (num3)
						{
						case _return_78:
							AppClass_969.voidParam();
							num3 = 4;
							if (AppClass_031.class730_0.int_107 != _return_78)
							{
								continue;
							}
							return;
						case 2:
							goto _goto_116;
						case 1:
							return;
						}
						while (true)
						{
							switch (num2)
							{
							case 9:
								goto _goto_117;
							default:
								return;
							case 990:
								break;
							}
							break;
							_goto_117:
							AppClass_960.boolParam();
							num3 = _return_78;
							if (AppClass_031.class730_0.int_63 == _return_78)
							{
								continue;
							}
							goto _goto_118;
						}
						break;
					}
					continue;
					_goto_116:
					break;
				}
				AppClass_960.boolParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_36 appclass167Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_37
	{
		public static readonly GetStatic_37 _appclass188_119;

		public static Func<Polygon, double> intParam;

		public static Func<GetStatic_34, object> doubleParam;

		public static Func<CurveXYZ, double> polygonParam;

		public static Func<CurveXYZ, double> ienumerableObjectParam;

		public static Func<GetStatic_27, double> listObjectParam;

		public static Func<GetStatic_27, double> ienumerableObjectParam;

		private static GetStatic_37 _appclass188_120;

		static GetStatic_37()
		{
			AppClass_960.objectParam();
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
							AppClass_960.boolParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_28 != _return_78)
							{
								continue;
							}
							goto default;
						default:
							if (num2 == 11)
							{
								AppClass_967.boolParam();
								num3 = 1;
								if (AppClass_031.class730_0.int_35 != _return_78)
								{
									continue;
								}
								break;
							}
							goto _goto_121;
						case _return_78:
							break;
						case 1:
							AppClass_960.boolParam();
							goto _goto_123;
						case 4:
							goto _goto_123;
						case 3:
							return;
						}
						goto _goto_125;
						_goto_121:
						if (num2 == 992)
						{
							break;
						}
						goto _goto_125;
						_goto_125:
						_appclass188_119 = new GetStatic_37();
						num3 = 8;
						if (AppClass_031.class730_0.int_36 == _return_78)
						{
							return;
						}
					}
					continue;
					_goto_123:
					break;
				}
				AppClass_969.voidParam();
				num = 11;
			}
		}

		[SpecialName]
		internal double intParam(Polygon polygonParam)
		{
			return _return_78._return_78;
		}

		[SpecialName]
		internal object doubleParam(GetStatic_34 class545_0)
		{
			return null;
		}

		[SpecialName]
		internal double polygonParam(CurveXYZ _curvexyz_55)
		{
			return _return_78._return_78;
		}

		[SpecialName]
		internal double ienumerableObjectParam(CurveXYZ _curvexyz_55)
		{
			return _return_78._return_78;
		}

		[SpecialName]
		internal double listObjectParam(GetStatic_27 class542_0)
		{
			return _return_78._return_78;
		}

		[SpecialName]
		internal double ienumerableObjectParam(GetStatic_27 class542_0)
		{
			return _return_78._return_78;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_37 appclass167Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_39
	{
		public Polygon polygonParam;

		internal static GetStatic_39 _appclass189_126;

		public GetStatic_39(GetStatic_39 class548_1)
		{
		}

		[SpecialName]
		internal bool intParam(GetStatic_27 class542_0)
		{
			return true;
		}

		static GetStatic_39()
		{
			AppClass_960.objectParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						_goto_127:
						switch (num3)
						{
						case 2:
							AppClass_960.boolParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_12 == _return_78)
							{
								continue;
							}
							goto default;
						default:
							while (num2 == 9)
							{
								AppClass_969.voidParam();
								num3 = _return_78;
								if (AppClass_031.class730_0.int_38 == _return_78)
								{
									continue;
								}
								goto _goto_127;
							}
							goto _goto_128;
						case 1:
							break;
						case _return_78:
							return;
						}
						goto _goto_129;
						continue;
						_goto_128:
						break;
					}
					continue;
					_goto_129:
					break;
				}
				while (num2 == 990);
				AppClass_960.boolParam();
				num = 1;
				if (AppClass_031.class730_0.int_84 != _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_39 appclass167Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_41
	{
		public Polygon polygonParam;

		public GetStatic_43 _appclass191_134;

		private static GetStatic_41 _appclass190_131;

		public GetStatic_41(GetStatic_41 class549_1)
		{
		}

		[SpecialName]
		internal bool intParam(Polygon polygonParam)
		{
			return true;
		}

		static GetStatic_41()
		{
			AppClass_960.objectParam();
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
						default:
							if (num2 != 9)
							{
								goto _goto_135;
							}
							AppClass_960.boolParam();
							num3 = _return_78;
							if (AppClass_031.class730_0.int_25 == _return_78)
							{
								continue;
							}
							goto case _return_78;
						case 1:
							break;
						case _return_78:
							AppClass_969.voidParam();
							return;
						case 2:
							return;
						}
						goto _goto_137;
						continue;
						_goto_135:
						break;
					}
					continue;
					_goto_137:
					break;
				}
				while (num2 == 990);
				AppClass_960.boolParam();
				num = 3;
				if (AppClass_031.class730_0.int_64 != _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_41 appclass167Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_43
	{
		public double doubleParam;

		internal static GetStatic_43 _appclass191_134;

		public GetStatic_43(GetStatic_43 class550_1)
		{
		}

		static GetStatic_43()
		{
			AppClass_960.objectParam();
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
						default:
							if (num2 != 9)
							{
								goto _goto_135;
							}
							goto _goto_136;
						case 2:
							AppClass_960.boolParam();
							break;
						case 1:
							break;
						case _return_78:
							return;
						}
						goto _goto_137;
						_goto_136:
						AppClass_969.voidParam();
						num3 = 8;
						if (AppClass_031.class730_0.int_67 != _return_78)
						{
							return;
						}
						continue;
						_goto_135:
						break;
					}
					continue;
					_goto_137:
					break;
				}
				while (num2 == 990);
				AppClass_960.boolParam();
				num = 1;
				if (AppClass_031.class730_0.int_84 != _return_78)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_43 appclass167Param()
		{
			return null;
		}
	}

	public static object objectParam;

	public static object objectParam;

	private static double doubleParam;

	private static object objectParam;

	private static object objectParam;

	private static double doubleParam;

	private static List<object> _listObject_138;

	internal static object objectParam;

	static GetStatic_44()
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		AppClass_960.objectParam();
		int num = 10;
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
						AppClass_960.boolParam();
						goto case 4;
					case 4:
						AppClass_969.voidParam();
						num3 = 2;
						if (AppClass_031.class730_0.int_10 == _return_78)
						{
							continue;
						}
						goto case 10;
					case 10:
						AppClass_960.boolParam();
						goto case 9;
					case 8:
						objectParam = new GetStatic_21();
						goto case 3;
					case 3:
						doubleParam = 50._return_78;
						num3 = 15;
						if (AppClass_031.class730_0.int_100 != _return_78)
						{
							continue;
						}
						goto case 7;
					case 5:
						objectParam = new AppForm_839();
						goto case 8;
					case 2:
						AppClass_967.boolParam();
						goto case 5;
					case 1:
						break;
					default:
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto _goto_139;
							}
							goto case 5;
						}
						doubleParam = 50._return_78;
						num3 = 12;
						if (AppClass_031.class730_0.int_66 != _return_78)
						{
							continue;
						}
						break;
					case 7:
						objectParam = new double[3];
						goto _goto_141;
					case 6:
						goto _goto_141;
					case _return_78:
						return;
					}
					_listObject_138 = new List<object>();
					num3 = 1;
					if (AppClass_031.class730_0.int_53 != _return_78)
					{
						return;
					}
					continue;
					_goto_139:
					break;
				}
				continue;
				_goto_141:
				break;
			}
			objectParam = (object)new diem();
			num = 17;
		}
	}

	public static List<GetStatic_25> boolParam(List<Polygon> _listAppclass181_107)
	{
		return null;
	}

	public static List<GetStatic_27> appclass167Param(List<Polygon> _listAppclass181_107, List<List<int>> _listDiem_108)
	{
		return null;
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

	public static List<object> listObjectParam(object objectParam = null)
	{
		return null;
	}

	public static void voidParam()
	{
	}

	public static object objectParam(object objectParam, int intParam = _return_78)
	{
		return null;
	}

	private static void voidParam(object objectParam, int intParam = _return_78)
	{
	}

	private static void voidParam(object objectParam, object objectParam)
	{
	}

	private static void voidParam(object objectParam, object objectParam)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static bool boolParam(object objectParam, object objectParam, double doubleParam = _return_78.4)
	{
		return true;
	}

	public static Tuple<int, string> stringParam(object objectParam)
	{
		return null;
	}

	public static Tuple<Polygon, bool> boolParam(List<Polygon> _listAppclass181_107)
	{
		return null;
	}

	public static bool boolParam(object objectParam, object objectParam, bool boolParam = true)
	{
		return true;
	}

	public static bool boolParam(object objectParam, object objectParam, bool boolParam = true)
	{
		return true;
	}

	private static void voidParam(ref List<Polygon> _listAppclass181_107, ref List<GetStatic_27> _listDiem_108, object objectParam, object objectParam, bool boolParam, int intParam, object objectParam)
	{
	}

	private static void voidParam(object objectParam, object objectParam, ref GetStatic_31 class543_0)
	{
	}

	private static void voidParam(ref List<Polygon> _listAppclass181_107, List<Polygon> _listDiem_108, object objectParam, ref GetStatic_31 class543_0, bool boolParam, int intParam, object objectParam)
	{
	}

	public static object objectParam(object objectParam)
	{
		return null;
	}

	public static void voidParam()
	{
	}

	public static object objectParam(object objectParam, object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam, object objectParam, double doubleParam)
	{
	}

	public static void voidParam(bool boolParam = false)
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_44 appclass162Param()
	{
		return null;
	}
}
