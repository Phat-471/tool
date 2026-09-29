using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns4;
using ns61;
using ns62;
using ns64;

namespace ns19;

[StandardModule]
internal sealed class GetStatic_10
{
	public class GetStatic_5
	{
		[CompilerGenerated]
		internal sealed class GetStatic_2
		{
			public List<int> _listPoint3d_8;

			internal static GetStatic_2 _appclass156_2;

			public GetStatic_2(GetStatic_2 class521_1)
			{
			}

			[SpecialName]
			internal bool boolParam(Polygon polygonParam, int intParam)
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
					while (true)
					{
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 1:
								do
								{
									AppClass_960.smethod_13();
									num3 = 0;
								}
								while (AppClass_031.class730_0.int_34 != 0);
								continue;
							case 0:
								AppClass_960.smethod_15();
								num3 = 8;
								if (AppClass_031.class730_0.int_47 != 0)
								{
									continue;
								}
								break;
							default:
								if (num2 != 9)
								{
									if (num2 == 990)
									{
										goto _goto_3;
									}
									goto case 0;
								}
								return;
							case 2:
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
					AppClass_969.appclass154Param();
					num = 9;
				}
			}

			internal static bool boolParam()
			{
				return true;
			}

			internal static GetStatic_2 appclass156Param()
			{
				return null;
			}
		}

		public object objectParam;

		public object objectParam;

		public List<GetStatic_7> _listPoint3d_8;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public double doubleParam;

		public bool boolParam;

		public AppClass_063.Enum7 enum7_0;

		public AppClass_063.Enum8 enum8_0;

		public bool boolParam;

		public double doubleParam;

		internal static object objectParam;

		public GetStatic_5(List<diem> listDiemParam)
		{
		}

		public void boolParam()
		{
		}

		public GetStatic_5()
		{
		}

		public Tuple<List<diem>, diem> diemParam(bool boolParam = false)
		{
			return null;
		}

		public List<Tuple<double, double>> doubleParam()
		{
			return null;
		}

		public List<Tuple<double, double>> doubleParam()
		{
			return null;
		}

		public List<Tuple<double, double>> doubleParam()
		{
			return null;
		}

		public List<Polygon> listPolygonParam(List<Tuple<double, double>> listDiemParam)
		{
			return null;
		}

		static GetStatic_5()
		{
			AppClass_960.smethod_23();
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
							AppClass_960.smethod_13();
							num3 = 0;
							if (AppClass_031.class730_0.int_98 != 0)
							{
								continue;
							}
							break;
						case 0:
							goto _goto_6;
						case 2:
							return;
						}
						switch (num2)
						{
						case 9:
							AppClass_969.appclass154Param();
							num3 = 2;
							if (AppClass_031.class730_0.int_15 != 0)
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
					_goto_6:
					break;
				}
				AppClass_960.smethod_15();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_5 appclass156Param()
		{
			return null;
		}
	}

	public class GetStatic_7
	{
		public object objectParam;

		public object objectParam;

		public object objectParam;

		private static object objectParam;

		public GetStatic_7(CurveXYZ curveXYZ_0, CurveXYZ curveXYZ_1, CurveXYZ curveXYZ_2)
		{
		}

		public Polygon boolParam(CurveXYZ curveXYZ_0, double doubleParam, bool boolParam)
		{
			return null;
		}

		public CurveXYZ diemParam(AppClass_063.Enum8 enum8_0)
		{
			return null;
		}

		static GetStatic_7()
		{
			AppClass_960.smethod_23();
			int num = 1;
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
						case 1:
							AppClass_960.smethod_13();
							num3 = 0;
							if (AppClass_031.class730_0.int_33 == 0)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 990:
								goto _goto_7;
							case 9:
								return;
							}
							goto case 1;
						case 0:
							AppClass_960.smethod_15();
							goto case 2;
						case 2:
							AppClass_969.appclass154Param();
							num = 2;
							if (AppClass_031.class730_0.int_43 == 0)
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

		internal static GetStatic_7 appclass156Param()
		{
			return null;
		}
	}

	public class GetStatic_8 : DrawJig
	{
		public readonly List<Point3d> _listPoint3d_8;

		private Point3d point3d_0;

		private bool boolParam;

		private bool boolParam;

		private bool boolParam;

		internal static object objectParam;

		public bool boolParam(Editor editorParam)
		{
			return true;
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

		static GetStatic_8()
		{
			AppClass_960.smethod_23();
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
							AppClass_960.smethod_13();
							num3 = 0;
							if (AppClass_031.class730_0.int_67 != 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							AppClass_960.smethod_15();
							num3 = 2;
							if (AppClass_031.class730_0.int_117 != 0)
							{
								continue;
							}
							goto default;
						default:
							switch (num2)
							{
							case 990:
								goto _goto_9;
							case 9:
								return;
							}
							goto _goto_11;
						case 2:
							goto _goto_11;
							_goto_9:
							break;
						}
						break;
					}
					continue;
					_goto_11:
					break;
				}
				AppClass_969.appclass154Param();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_8 appclass156Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_9
	{
		public static readonly GetStatic_9 _appclass159_12;

		public static Action actionParam;

		private static GetStatic_9 _appclass159_13;

		static GetStatic_9()
		{
			AppClass_960.smethod_23();
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
							AppClass_967.boolParam();
							num3 = 0;
							if (AppClass_031.class730_0.int_115 != 0)
							{
								continue;
							}
							goto case 2;
						case 1:
							AppClass_960.smethod_13();
							num3 = 1;
							if (AppClass_031.class730_0.int_45 == 0)
							{
								continue;
							}
							break;
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto _goto_14;
								}
							}
							else
							{
								AppClass_969.appclass154Param();
							}
							goto case 4;
						case 0:
							break;
						case 2:
							_appclass159_12 = new GetStatic_9();
							return;
						case 3:
							return;
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
				AppClass_960.smethod_15();
				num = 9;
				if (AppClass_031.class730_0.int_97 == 0)
				{
					num = 11;
				}
			}
		}

		[SpecialName]
		internal void boolParam()
		{
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_9 appclass156Param()
		{
			return null;
		}
	}

	public static object objectParam;

	public static object objectParam;

	private static object objectParam;

	static GetStatic_10()
	{
		AppClass_960.smethod_23();
		int num = 5;
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
					case 5:
						AppClass_960.smethod_13();
						goto case 4;
					case 4:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_6 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						AppClass_969.appclass154Param();
						num3 = 9;
						if (AppClass_031.class730_0.int_8 == 0)
						{
							continue;
						}
						break;
					default:
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto _goto_16;
							}
							goto case 5;
						}
						objectParam = new GetStatic_5();
						num3 = 10;
						if (AppClass_031.class730_0.int_23 != 0)
						{
							continue;
						}
						goto case 1;
					case 3:
						break;
					case 1:
						objectParam = new AppForm_822();
						return;
					case 2:
						return;
					}
					goto _goto_17;
					continue;
					_goto_16:
					break;
				}
				continue;
				_goto_17:
				break;
			}
			AppClass_967.boolParam();
			num = 10;
			if (AppClass_031.class730_0.int_10 == 0)
			{
				num = 12;
			}
		}
	}

	public static void boolParam()
	{
	}

	public static void appclass156Param()
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_10 appclass154Param()
	{
		return null;
	}
}
