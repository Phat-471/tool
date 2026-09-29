using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	[CompilerGenerated]
	private string _string_1;

	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private string _string_2;

	internal static GetStatic_1 _appclass620_3;

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

	[JsonProperty(/*Could not decode attribute arguments.*/)]
	public int? Nullable_0
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

	public string String_1
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
							goto _goto_4;
						}
						AppClass_960.smethod_15();
						num3 = 5;
						if (AppClass_031.class730_0.int_7 == 0)
						{
							continue;
						}
						goto case 0;
					case 1:
						break;
					case 0:
						AppClass_969.smethod_3();
						return;
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
			while (num2 == 990);
			AppClass_960.smethod_13();
			num = 1;
			if (AppClass_031.class730_0.int_119 != 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass620Param()
	{
		return null;
	}
}
