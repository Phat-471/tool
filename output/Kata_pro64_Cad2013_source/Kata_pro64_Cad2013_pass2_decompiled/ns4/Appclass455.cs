using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_1
{
	[CompilerGenerated]
	private int intParam;

	[CompilerGenerated]
	private List<string> _listString_1;

	internal static GetStatic_1 _appclass455_2;

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

	public List<string> List_0
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
					_goto_4:
					switch (num3)
					{
					case _return_3:
						AppClass_969.smethod_3();
						num3 = 8;
						if (AppClass_031.class730_0.int_63 == _return_3)
						{
							continue;
						}
						return;
					default:
						while (num2 == 9)
						{
							AppClass_960.smethod_15();
							num3 = _return_3;
							if (AppClass_031.class730_0.int_76 == _return_3)
							{
								continue;
							}
							goto _goto_4;
						}
						goto _goto_5;
					case 1:
						break;
					case 2:
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
			while (num2 == 990);
			AppClass_960.smethod_13();
			num = 7;
			if (AppClass_031.class730_0.int_111 != _return_3)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass455Param()
	{
		return null;
	}
}
