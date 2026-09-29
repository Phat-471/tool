using System.Runtime.CompilerServices;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1 : AppClass_373
{
	[CompilerGenerated]
	private string _string_1;

	[CompilerGenerated]
	private long _long_2;

	private static GetStatic_1 _appclass378_3;

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

	public long Int64_1
	{
		[CompilerGenerated]
		get
		{
			return _return_4;
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
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 0:
						AppClass_969.appclass378Param();
						num3 = 1;
						if (AppClass_031.class730_0.int_7 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_5;
							}
						}
						else
						{
							AppClass_960.smethod_15();
							num3 = 3;
							if (AppClass_031.class730_0.int_3 == 0)
							{
								continue;
							}
						}
						goto case 0;
					case 2:
						break;
					case 1:
						return;
					}
					goto _goto_6;
					continue;
					_goto_5:
					break;
				}
				continue;
				_goto_6:
				break;
			}
			AppClass_960.smethod_13();
			num = 9;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass378Param()
	{
		return null;
	}
}
