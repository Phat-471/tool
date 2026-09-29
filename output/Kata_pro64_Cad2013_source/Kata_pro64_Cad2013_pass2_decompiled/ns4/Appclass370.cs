using System.Runtime.CompilerServices;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	[CompilerGenerated]
	private string _string_1;

	[CompilerGenerated]
	private int intParam;

	private static GetStatic_1 _appclass370_2;

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

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return _return_3;
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
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						AppClass_960.smethod_13();
						num3 = _return_3;
						if (AppClass_031.class730_0.int_119 != _return_3)
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
						return;
					case _return_3:
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_25 != _return_3)
						{
							continue;
						}
						goto default;
					case 2:
						break;
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
			AppClass_969.smethod_3();
			num = 8;
			if (AppClass_031.class730_0.int_61 != _return_3)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass370Param()
	{
		return null;
	}
}
