using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using ns61;
using ns64;

namespace ns1;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class GetStatic_2 : Computer
{
	internal static object objectParam;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerHidden]
	public GetStatic_2()
	{
	}

	static GetStatic_2()
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
						goto _goto_2;
					case 1:
						goto _goto_2;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_3;
					case 0:
						break;
					}
					goto _goto_5;
					_goto_2:
					AppClass_960.smethod_15();
					num3 = 0;
					if (AppClass_031.class730_0.int_56 == 0)
					{
						goto _goto_5;
					}
					continue;
					_goto_3:
					break;
				}
				continue;
				_goto_5:
				break;
			}
			while (num2 == 990);
			AppClass_969.smethod_3();
			num = 9;
			if (AppClass_031.class730_0.int_94 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass034Param()
	{
		return null;
	}
}
