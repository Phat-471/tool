using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns5;

[StandardModule]
internal sealed class GetStatic_1
{
	internal class Form0 : Form
	{
		private readonly object objectParam;

		private readonly object objectParam;

		private int intParam;

		internal static object objectParam;

		[SpecialName]
		public string stringParam()
		{
			return null;
		}

		[SpecialName]
		public int intParam()
		{
			return _return_1;
		}

		public Form0(int intParam)
		{
		}

		private void voidParam(object sender, EventArgs e)
		{
		}

		static Form0()
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
							num3 = 1;
							if (AppClass_031.class730_0.int_17 != _return_1)
							{
								continue;
							}
							goto default;
						case 1:
							AppClass_960.smethod_15();
							num3 = 2;
							if (AppClass_031.class730_0.int_101 != _return_1)
							{
								continue;
							}
							break;
						default:
							if (num2 == 9)
							{
								return;
							}
							goto _goto_2;
						case _return_1:
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
				if (AppClass_031.class730_0.int_74 != _return_1)
				{
					num = 4;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static Form0 form0Param()
		{
			return null;
		}
	}

	internal static object objectParam;

	public static void boolParam()
	{
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
					case 2:
						AppClass_960.smethod_13();
						num3 = 1;
						if (AppClass_031.class730_0.int_90 != _return_1)
						{
							continue;
						}
						return;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_4;
							}
							goto case 2;
						}
						AppClass_969.smethod_3();
						num3 = 9;
						if (AppClass_031.class730_0.int_22 == _return_1)
						{
							continue;
						}
						return;
					case 1:
						break;
					case _return_1:
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
			AppClass_960.smethod_15();
			num = 9;
		}
	}

	internal static bool form0Param()
	{
		return true;
	}

	internal static GetStatic_1 appclass927Param()
	{
		return null;
	}
}
