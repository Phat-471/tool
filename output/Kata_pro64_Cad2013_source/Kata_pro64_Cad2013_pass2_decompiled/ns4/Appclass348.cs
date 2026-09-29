using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_1
{
	public static List<ObjectId> _listObjectid_1;

	private static List<string> _listString_2;

	private static Document documentParam;

	private static bool boolParam;

	private static bool boolParam;

	internal static GetStatic_1 _appclass348_3;

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
		int num = 4;
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
					case 7:
						AppClass_969.voidParam();
						goto case 2;
					case 2:
						AppClass_967.voidParam();
						num3 = 13;
						if (AppClass_031.class730_0.int_118 != 0)
						{
							continue;
						}
						break;
					case 6:
						boolParam = false;
						num3 = 0;
						if (AppClass_031.class730_0.int_51 != 0)
						{
							continue;
						}
						goto default;
					case 1:
						documentParam = null;
						goto case 6;
					default:
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto _goto_4;
							}
							goto case 6;
						}
						_listString_2 = new List<string>();
						num3 = 4;
						if (AppClass_031.class730_0.int_23 != 0)
						{
							continue;
						}
						goto case 1;
					case 4:
						AppClass_960.appclass348Param();
						num3 = 12;
						if (AppClass_031.class730_0.int_99 == 0)
						{
							continue;
						}
						goto case 3;
					case 3:
						AppClass_960.smethod_15();
						num3 = 7;
						if (AppClass_031.class730_0.int_58 == 0)
						{
							continue;
						}
						goto default;
					case 0:
						boolParam = false;
						num3 = 7;
						if (AppClass_031.class730_0.int_11 != 0)
						{
							continue;
						}
						return;
					case 5:
						break;
					case 8:
						return;
					}
					goto _goto_5;
					continue;
					_goto_4:
					break;
				}
				continue;
				_goto_5:
				break;
			}
			_listObjectid_1 = new List<ObjectId>();
			num = 15;
		}
	}

	public static void voidParam()
	{
	}

	public static void voidParam(object sender, PointMonitorEventArgs e)
	{
	}

	public static void voidParam(object sender, ObjectEventArgs e)
	{
	}

	private static void voidParam()
	{
	}

	private static void voidParam()
	{
	}

	private static void voidParam()
	{
	}

	private static void voidParam(object objectParam, object objectParam)
	{
	}

	public static void voidParam(object sender, CommandEventArgs e)
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam()
	{
	}

	public static void voidParam(IEnumerable<ObjectId> ienumerableObjectidParam)
	{
	}

	public static void voidParam(object sender, EventArgs e)
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass348Param()
	{
		return null;
	}
}
