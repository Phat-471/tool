using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_2
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_1
	{
		public static readonly GetStatic_1 _appclass430_1;

		public static Func<TypedValue, bool> boolParam;

		internal static GetStatic_1 _appclass430_2;

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
						case 1:
							AppClass_967.boolParam();
							num3 = 0;
							if (AppClass_031.class730_0.int_28 != 0)
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
								goto case 4;
							}
							return;
						case 0:
							_appclass430_1 = new GetStatic_1();
							num = 11;
							if (AppClass_031.class730_0.int_85 == 0)
							{
								num = 5;
							}
							break;
						case 3:
							AppClass_960.boolParam();
							goto case 2;
						case 2:
							AppClass_960.appclass429Param();
							goto case 4;
						case 4:
							AppClass_969.point3dParam();
							num = 1;
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
			}
		}

		[SpecialName]
		internal bool boolParam(TypedValue typedValue_0)
		{
			return true;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass430Param()
		{
			return null;
		}
	}

	private static GetStatic_2 _appclass429_5;

	public static void boolParam(string stringParam)
	{
	}

	public static void appclass430Param(ref double[] double_0)
	{
	}

	public static object objectParam(double[] double_0)
	{
		return null;
	}

	public static Point3d point3dParam(Point3d point3d_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	public static Point3d point3dParam(Point3d point3d_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	public static List<object> listObjectParam(object objectParam, bool boolParam = true)
	{
		return null;
	}

	public static bool boolParam(ref object objectParam, ref diem diemParam, bool boolParam = false)
	{
		return true;
	}

	public static bool boolParam(ref object objectParam, ref string stringParam)
	{
		return true;
	}

	public static Entity entityParam(object objectParam)
	{
		return null;
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(Entity entityParam)
	{
	}

	public static void voidParam(object objectParam)
	{
	}

	public static void voidParam(List<object> listObjectParam)
	{
	}

	public static bool boolParam(object objectParam)
	{
		return true;
	}

	static GetStatic_2()
	{
		AppClass_960.smethod_23();
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
						num3 = 0;
						if (AppClass_031.class730_0.int_52 == 0)
						{
							continue;
						}
						goto default;
					case 0:
						AppClass_960.appclass429Param();
						num3 = 2;
						if (AppClass_031.class730_0.int_88 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_6;
					case 2:
						break;
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
			while (num2 == 990);
			AppClass_969.point3dParam();
			num = 9;
			if (AppClass_031.class730_0.int_52 != 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass429Param()
	{
		return null;
	}
}
