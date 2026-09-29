using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_3
{
	public class GetStatic_2 : DrawJig, IDisposable
	{
		public Polygon polygonParam;

		public diem diemParam;

		public double doubleParam;

		public double doubleParam;

		public List<CurveXYZ> _listCurvexyz_1;

		public List<CurveXYZ> _listCurvexyz_2;

		private static GetStatic_2 _appclass305_3;

		public GetStatic_2(Polygon polygonParam, double doubleParam, double doubleParam)
		{
		}

		protected override SamplerStatus samplerstatusParam(JigPrompts jigPrompts_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		private void voidParam(WorldDraw worldDraw_0, CurveXYZ curveXYZ_0, string stringParam = "")
		{
		}

		private void voidParam(WorldDraw worldDraw_0, string stringParam, diem diemParam)
		{
		}

		protected override bool boolParam(WorldDraw worldDraw_0)
		{
			return true;
		}

		public void Dispose()
		{
		}

		[SpecialName]
		[CompilerGenerated]
		private double doubleParam(CurveXYZ curveXYZ_0)
		{
			return 0.0;
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
							AppClass_960.smethod_13();
							num3 = 0;
							if (AppClass_031.class730_0.int_35 == 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_4;
								}
								goto case 1;
							}
							AppClass_969.smethod_3();
							num3 = 2;
							if (AppClass_031.class730_0.int_15 == 0)
							{
								continue;
							}
							return;
						case 0:
							break;
						case 2:
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
				AppClass_960.smethod_15();
				num = 2;
				if (AppClass_031.class730_0.int_81 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_2 appclass305Param()
		{
			return null;
		}
	}

	public static AppForm_832 _appform832_6;

	private static GetStatic_3 _appclass304_7;

	static GetStatic_3()
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
					_goto_9:
					switch (num3)
					{
					case 3:
						_appform832_6 = new AppForm_832();
						num3 = 1;
						if (AppClass_031.class730_0.int_92 == 0)
						{
							continue;
						}
						goto default;
					default:
						while (true)
						{
							switch (num2)
							{
							case 11:
								goto _goto_8;
							default:
								return;
							case 992:
								break;
							}
							break;
							_goto_8:
							AppClass_960.smethod_15();
							num3 = 0;
							if (AppClass_031.class730_0.int_46 == 0)
							{
								continue;
							}
							goto _goto_9;
						}
						goto _goto_10;
					case 2:
						AppClass_967.boolParam();
						num3 = 3;
						if (AppClass_031.class730_0.int_99 != 0)
						{
							continue;
						}
						goto case 3;
					case 0:
						AppClass_969.smethod_3();
						num3 = 2;
						if (AppClass_031.class730_0.int_34 == 0)
						{
							continue;
						}
						goto default;
					case 4:
						break;
					case 1:
						return;
					}
					goto _goto_11;
					continue;
					_goto_10:
					break;
				}
				continue;
				_goto_11:
				break;
			}
			AppClass_960.smethod_13();
			num = 7;
			if (AppClass_031.class730_0.int_112 != 0)
			{
				num = 11;
			}
		}
	}

	public static void boolParam()
	{
	}

	internal static bool appclass305Param()
	{
		return true;
	}

	internal static GetStatic_3 appclass304Param()
	{
		return null;
	}
}
