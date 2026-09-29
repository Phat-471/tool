using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.DatabaseServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns22;

[StandardModule]
internal sealed class GetStatic_2
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_1
	{
		public static readonly GetStatic_1 _appclass196_1;

		public static Func<Polygon, double> doubleParam;

		private static GetStatic_1 _appclass196_2;

		static GetStatic_1()
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
						case 3:
							AppClass_960.smethod_13();
							num3 = 2;
							if (AppClass_031.class730_0.int_26 != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto _goto_3;
								}
								goto case 3;
							}
							AppClass_969.polygonParam();
							num3 = 2;
							if (AppClass_031.class730_0.int_62 != 0)
							{
								continue;
							}
							goto case 1;
						case 1:
							AppClass_967.boolParam();
							num3 = 10;
							if (AppClass_031.class730_0.int_55 != 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							_appclass196_1 = new GetStatic_1();
							num3 = 6;
							if (AppClass_031.class730_0.int_16 != 0)
							{
								continue;
							}
							return;
						case 2:
							break;
						case 4:
							return;
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
				AppClass_960.smethod_15();
				num = 8;
				if (AppClass_031.class730_0.int_7 != 0)
				{
					num = 11;
				}
			}
		}

		[SpecialName]
		internal double doubleParam(Polygon polygonParam)
		{
			return 0.0;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass196Param()
		{
			return null;
		}
	}

	internal static object objectParam;

	private static double boolParam(double doubleParam, double doubleParam, bool boolParam)
	{
		return 0.0;
	}

	public static List<Polygon> appclass196Param(object objectParam)
	{
		return null;
	}

	public static CurveXYZ curvexyzParam(object objectParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, bool boolParam = false)
	{
		return null;
	}

	private static bool boolParam(double doubleParam, double doubleParam, double doubleParam)
	{
		return true;
	}

	public static Polygon polygonParam(object objectParam, double doubleParam)
	{
		return null;
	}

	public static Polygon polygonParam(object objectParam, bool boolParam = false)
	{
		return null;
	}

	public static object objectParam(object objectParam, string stringParam = null, double doubleParam = 0.0)
	{
		return null;
	}

	public static Polyline polylineParam(object objectParam, double doubleParam, double doubleParam, string stringParam = null)
	{
		return null;
	}

	static GetStatic_2()
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
					_goto_5:
					switch (num3)
					{
					case 2:
						AppClass_960.smethod_13();
						num3 = 1;
						if (AppClass_031.class730_0.int_20 == 0)
						{
							continue;
						}
						break;
					default:
						while (num2 == 9)
						{
							AppClass_969.polygonParam();
							num3 = 0;
							if (AppClass_031.class730_0.int_61 == 0)
							{
								continue;
							}
							goto _goto_5;
						}
						if (num2 == 990)
						{
							goto _goto_6;
						}
						goto case 2;
					case 1:
						break;
					case 0:
						return;
					}
					goto _goto_7;
					continue;
					_goto_6:
					break;
				}
				continue;
				_goto_7:
				break;
			}
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_38 == 0)
			{
				num = 2;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass195Param()
	{
		return null;
	}
}
