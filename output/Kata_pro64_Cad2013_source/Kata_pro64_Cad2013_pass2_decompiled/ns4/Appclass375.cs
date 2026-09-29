using System.Runtime.CompilerServices;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1 : AppClass_373
{
	[CompilerGenerated]
	private string _string_1;

	internal static GetStatic_1 _appclass375_2;

	public string String_3
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
					case 1:
						AppClass_960.smethod_13();
						num3 = 9;
						if (AppClass_031.class730_0.int_68 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_72 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_3;
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
			while (num2 == 990);
			AppClass_969.appclass375Param();
			num = 7;
			if (AppClass_031.class730_0.int_86 == 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass375Param()
	{
		return null;
	}
}
