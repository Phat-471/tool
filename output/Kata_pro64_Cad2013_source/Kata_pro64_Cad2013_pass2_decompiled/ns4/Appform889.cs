using System.Windows.Forms;
using ns61;
using ns64;

namespace ns4;

public class GetStatic_2 : Form
{
	private readonly TextBox _textbox_1;

	private readonly FlowLayoutPanel _flowlayoutpanel_2;

	private readonly Button buttonParam;

	private readonly Button buttonParam;

	internal static GetStatic_2 _appform889_3;

	public GetStatic_2(string stringParam)
	{
	}

	static GetStatic_2()
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
						break;
					default:
						if (num2 == 9)
						{
							AppClass_960.smethod_15();
							num3 = 0;
							if (AppClass_031.class730_0.int_69 == 0)
							{
								continue;
							}
							goto _goto_6;
						}
						goto _goto_5;
					case 2:
						goto _goto_6;
					case 1:
						return;
					}
					goto _goto_8;
					_goto_5:
					if (num2 == 990)
					{
						break;
					}
					goto _goto_8;
					_goto_8:
					AppClass_969.smethod_3();
					num3 = 0;
					if (AppClass_031.class730_0.int_21 == 0)
					{
						return;
					}
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

	internal static GetStatic_2 appform889Param()
	{
		return null;
	}
}
