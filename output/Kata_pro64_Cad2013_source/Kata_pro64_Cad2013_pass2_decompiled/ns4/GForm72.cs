using System.Windows.Forms;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_2 : Form
{
	private readonly Label labelParam;

	private readonly ProgressBar _progressbar_1;

	private static GetStatic_2 _appform892_2;

	public GetStatic_2(string stringParam)
	{
	}

	public void voidParam(string stringParam)
	{
	}

	static GetStatic_2()
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
						num3 = 0;
						if (AppClass_031.class730_0.int_19 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_3;
							}
							goto case 0;
						}
						return;
					case 0:
						AppClass_960.smethod_15();
						num3 = 4;
						if (AppClass_031.class730_0.int_13 != 0)
						{
							continue;
						}
						break;
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
			AppClass_969.smethod_3();
			num = 7;
			if (AppClass_031.class730_0.int_72 != 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appform892Param()
	{
		return null;
	}
}
