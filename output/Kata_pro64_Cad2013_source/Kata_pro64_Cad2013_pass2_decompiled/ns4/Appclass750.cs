using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using ns61;
using ns62;
using ns64;

namespace ns4;

public sealed class GetStatic_1
{
	public static readonly string[] _stringarray_1;

	private static GetStatic_1 _appclass750_2;

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
					case 4:
						_stringarray_1 = new string[7]
						{
							AppClass_960.smethod_17(0x42C28893 ^ AppClass_031.class730_0.int_82),
							AppClass_960.smethod_17(0x5E827BA5 ^ AppClass_031.class730_0.int_38),
							AppClass_960.smethod_17(0x1E908AB ^ AppClass_031.class730_0.int_68),
							AppClass_960.smethod_17(0x2A8B9822 ^ AppClass_031.class730_0.int_26),
							AppClass_960.smethod_17(0x1EF82DB ^ AppClass_031.class730_0.int_68),
							AppClass_960.smethod_17(0xB77F22 ^ AppClass_031.class730_0.int_48),
							AppClass_960.smethod_17(0x4823EE46 ^ AppClass_031.class730_0.int_80)
						};
						num3 = 0;
						if (AppClass_031.class730_0.int_3 == 0)
						{
							continue;
						}
						return;
					case 2:
						AppClass_960.smethod_13();
						num3 = 1;
						if (AppClass_031.class730_0.int_72 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 11)
						{
							goto _goto_3;
						}
						AppClass_967.stringParam();
						goto case 4;
					case 1:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_38 != 0)
						{
							continue;
						}
						goto default;
					case 0:
						break;
					case 3:
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
			while (num2 == 992);
			AppClass_969.jobjectParam();
			num = 11;
			if (AppClass_031.class730_0.int_69 != 0)
			{
				num = 6;
			}
		}
	}

	public static string stringParam(string stringParam, string stringParam)
	{
		return null;
	}

	public static JArray jarrayParam(IDictionary<string, string> stringParam, IDictionary<string, string> stringParam, int intParam, bool boolParam, JObject jobjectParam = null)
	{
		return null;
	}

	private static void voidParam(object objectParam, object objectParam, object objectParam, object objectParam, object objectParam)
	{
	}

	public static JObject jobjectParam(JObject jobjectParam, IEnumerable<JArray> ienumerableJarrayParam)
	{
		return null;
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass750Param()
	{
		return null;
	}
}
