using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns0;

[CompilerGenerated]
[DebuggerNonUserCode]
[HideModuleName]
[StandardModule]
internal sealed class GetStatic_1
{
	internal static GetStatic_1 _appclass032_1;

	[HelpKeyword("My.Settings")]
	internal static AppSettings Class11_0 => null;

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
						goto case 1;
					case 1:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_8 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_2;
					case 0:
						break;
					}
					goto _goto_3;
					continue;
					_goto_2:
					break;
				}
				continue;
				_goto_3:
				break;
			}
			while (num2 == 990);
			AppClass_969.smethod_3();
			num = 9;
			if (AppClass_031.class730_0.int_84 == 0)
			{
				num = 8;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass032Param()
	{
		return null;
	}
}
