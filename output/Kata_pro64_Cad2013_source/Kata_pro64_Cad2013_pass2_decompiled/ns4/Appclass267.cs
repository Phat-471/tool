using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Newtonsoft.Json.Linq;
using ns61;
using ns62;
using ns64;

namespace ns4;

public class GetStatic_3 : AppClass_264
{
	private class GetStatic_1
	{
		[CompilerGenerated]
		private string _string_1;

		[CompilerGenerated]
		private Info_Beam3D _infoBeam3d_2;

		internal static object objectParam;

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

		public Info_Beam3D Info_Beam3D_0
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

		static GetStatic_1()
		{
			AppClass_960.smethod_23();
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
							AppClass_960.smethod_13();
							num3 = 1;
							if (AppClass_031.class730_0.int_30 == _return_9)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								goto _goto_3;
							}
							AppClass_969.listStringParam();
							num3 = 9;
							if (AppClass_031.class730_0.int_117 == _return_9)
							{
								continue;
							}
							return;
						case 1:
							break;
						case _return_9:
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
				while (num2 == 990);
				AppClass_960.smethod_15();
				num = 9;
				if (AppClass_031.class730_0.int_84 == _return_9)
				{
					num = 8;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass268Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_2
	{
		public static readonly GetStatic_2 _appclass269_5;

		public static Comparison<CurveXYZ> comparisonCurvexyzParam;

		internal static GetStatic_2 _appclass269_6;

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
						case 4:
							_appclass269_5 = new GetStatic_2();
							num3 = _return_9;
							if (AppClass_031.class730_0.int_98 == _return_9)
							{
								continue;
							}
							return;
						case 1:
							AppClass_960.smethod_13();
							num3 = _return_9;
							if (AppClass_031.class730_0.int_39 == _return_9)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto _goto_7;
								}
								goto case 1;
							}
							AppClass_967.boolParam();
							goto case 4;
						case _return_9:
							AppClass_960.smethod_15();
							break;
						case 3:
							break;
						case 2:
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
				AppClass_969.listStringParam();
				num = 11;
				if (AppClass_031.class730_0.int_48 == _return_9)
				{
					num = 10;
				}
			}
		}

		[SpecialName]
		internal int intParam(CurveXYZ curveXYZ_0, CurveXYZ curveXYZ_1)
		{
			return _return_9;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_2 appclass268Param()
		{
			return null;
		}
	}

	private static GetStatic_3 _appclass267_10;

	public override string String_0 => null;

	public override string String_1 => null;

	public override string[] String_2 => null;

	public override bool Boolean_1 => true;

	public override JObject jobjectParam()
	{
		return null;
	}

	public override AppClass_282 appclass282Param(JObject jobjectParam)
	{
		return null;
	}

	private static bool boolParam(object objectParam)
	{
		return true;
	}

	private AppClass_282 appclass282Param(JObject jobjectParam, diem diemParam)
	{
		return null;
	}

	private static List<string> listStringParam(object objectParam)
	{
		return null;
	}

	private static GetStatic_1 appclass268Param(object objectParam, object objectParam, int intParam)
	{
		return null;
	}

	private static Info_Beam3D infoBeam3dParam(object objectParam, object objectParam)
	{
		return null;
	}

	private static Info_Beam3D infoBeam3dParam(object objectParam)
	{
		return null;
	}

	private static Tuple<CurveXYZ, CurveXYZ> curvexyzParam(object objectParam)
	{
		return null;
	}

	private static CurveXYZ curvexyzParam(object objectParam, object objectParam)
	{
		return null;
	}

	static GetStatic_3()
	{
		AppClass_960.smethod_23();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					_goto_11:
					switch (num3)
					{
					case 1:
						AppClass_969.listStringParam();
						num3 = _return_9;
						if (AppClass_031.class730_0.int_47 == _return_9)
						{
							continue;
						}
						goto default;
					default:
						while (num2 == 9)
						{
							AppClass_960.smethod_15();
							num3 = 1;
							if (AppClass_031.class730_0.int_72 == _return_9)
							{
								continue;
							}
							goto _goto_11;
						}
						goto _goto_12;
					case 2:
						break;
					case _return_9:
						return;
					}
					goto _goto_13;
					continue;
					_goto_12:
					break;
				}
				continue;
				_goto_13:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_13();
			num = 9;
			if (AppClass_031.class730_0.int_36 != _return_9)
			{
				num = 5;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_3 appclass267Param()
	{
		return null;
	}
}
