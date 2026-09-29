using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using ns61;
using ns62;
using ns64;

namespace ns4;

public sealed class GetStatic_3
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_1
	{
		public static readonly GetStatic_1 _appclass781_1;

		public static Func<string, string> stringParam;

		private static GetStatic_1 _appclass781_2;

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
						case 1:
							goto _goto_4;
						default:
							if (num2 == 11)
							{
								AppClass_967.boolParam();
								goto _goto_4;
							}
							if (num2 == 992)
							{
								goto _goto_5;
							}
							goto case 2;
						case 3:
							AppClass_960.smethod_15();
							goto case 2;
						case 2:
							AppClass_969.boolParam();
							num = 3;
							if (AppClass_031.class730_0.int_8 != 0)
							{
								num = 11;
							}
							break;
						case 4:
							AppClass_960.smethod_13();
							num = 3;
							break;
						case 0:
							return;
						}
						goto _goto_6;
						_goto_4:
						_appclass781_1 = new GetStatic_1();
						num3 = 10;
						if (AppClass_031.class730_0.int_14 != 0)
						{
							return;
						}
						continue;
						_goto_5:
						break;
					}
					continue;
					_goto_6:
					break;
				}
			}
		}

		[SpecialName]
		internal string stringParam(string stringParam)
		{
			return null;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass781Param()
		{
			return null;
		}
	}

	private static GetStatic_3 _appclass780_7;

	private GetStatic_3()
	{
	}

	public static AppClass_779 boolParam(JArray jarrayParam, string stringParam)
	{
		return null;
	}

	private static JArray appclass781Param(object objectParam, object objectParam, double doubleParam)
	{
		return null;
	}

	private static string stringParam(object objectParam, object objectParam)
	{
		return null;
	}

	private static bool boolParam(object objectParam, ref double[] doubleParam)
	{
		return true;
	}

	private static double doubleParam(object objectParam)
	{
		return 0.0;
	}

	private static double doubleParam(object objectParam)
	{
		return 0.0;
	}

	private static double doubleParam(object objectParam, double doubleParam)
	{
		return 0.0;
	}

	private static bool boolParam(object objectParam, bool boolParam)
	{
		return true;
	}

	static GetStatic_3()
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
					case 2:
						goto _goto_10;
					default:
						switch (num2)
						{
						default:
							goto _goto_10;
						case 9:
							AppClass_960.smethod_15();
							goto _goto_10;
						case 990:
							break;
						}
						goto _goto_11;
					case 1:
						break;
					case 0:
						return;
						_goto_10:
						AppClass_969.boolParam();
						num3 = 0;
						if (AppClass_031.class730_0.int_43 != 0)
						{
							continue;
						}
						return;
					}
					goto _goto_12;
					continue;
					_goto_11:
					break;
				}
				continue;
				_goto_12:
				break;
			}
			AppClass_960.smethod_13();
			num = 9;
			if (AppClass_031.class730_0.int_22 == 0)
			{
				num = 7;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_3 appclass780Param()
	{
		return null;
	}
}
