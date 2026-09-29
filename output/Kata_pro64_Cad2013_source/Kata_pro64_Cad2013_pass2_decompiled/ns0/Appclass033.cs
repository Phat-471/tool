using System.CodeDom.Compiler;
using System.ComponentModel;
using Microsoft.VisualBasic.ApplicationServices;
using ns61;
using ns64;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class GetStatic_1 : ApplicationBase
{
	private static object objectParam;

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
					case 1:
						AppClass_969.smethod_3();
						num3 = 0;
						if (AppClass_031.class730_0.int_110 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_1;
							}
						}
						else
						{
							AppClass_960.smethod_15();
							num3 = 1;
							if (AppClass_031.class730_0.int_5 != 0)
							{
								continue;
							}
						}
						goto case 1;
					case 2:
						break;
					case 0:
						return;
					}
					goto _goto_2;
					continue;
					_goto_1:
					break;
				}
				continue;
				_goto_2:
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

	internal static GetStatic_1 appclass033Param()
	{
		return null;
	}
}
