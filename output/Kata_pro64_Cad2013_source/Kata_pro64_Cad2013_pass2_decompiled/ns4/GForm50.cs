using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[DesignerGenerated]
public class GetStatic_2 : Form
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_1
	{
		public static readonly GetStatic_1 _appclass880_1;

		public static Comparison<string> comparisonStringParam;

		private static GetStatic_1 _appclass880_2;

		static GetStatic_1()
		{
			AppClass_960.smethod_23();
			int num = 4;
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
						case 4:
							AppClass_960.smethod_13();
							goto case 3;
						case 3:
							do
							{
								AppClass_960.smethod_15();
								num3 = 1;
							}
							while (AppClass_031.class730_0.int_9 == _return_7);
							continue;
						case 2:
							AppClass_967.boolParam();
							num3 = _return_7;
							if (AppClass_031.class730_0.int_20 != _return_7)
							{
								continue;
							}
							break;
						case 1:
							AppClass_969.smethod_3();
							num3 = 6;
							if (AppClass_031.class730_0.int_74 != _return_7)
							{
								continue;
							}
							goto case 2;
						case _return_7:
							goto _goto_3;
							_goto_6:
							if (num2 == 11)
							{
								return;
							}
							goto _goto_4;
							_goto_4:
							if (num2 == 992)
							{
								goto _goto_5;
							}
							goto case 1;
						}
						goto _goto_6;
						continue;
						_goto_5:
						break;
					}
					continue;
					_goto_3:
					break;
				}
				_appclass880_1 = new GetStatic_1();
				num = 11;
			}
		}

		[SpecialName]
		internal int intParam(string _string_9, string stringParam)
		{
			return _return_7;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass880Param()
		{
			return null;
		}
	}

	private IContainer icontainerParam;

	[AccessedThroughProperty("OK")]
	[CompilerGenerated]
	private Button _Ok;

	[AccessedThroughProperty("GroupBox1")]
	[CompilerGenerated]
	private GroupBox _groupbox_8;

	public string _string_9;

	private int intParam;

	private CheckBox[] _checkboxarray_10;

	private List<string> _listString_11;

	private static GetStatic_2 _appform880_12;

	internal virtual Button Button_0
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual GroupBox GroupBox_0
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool boolParam)
	{
	}

	[DebuggerStepThrough]
	private void intParam()
	{
	}

	public void voidParam()
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	static GetStatic_2()
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
						num3 = _return_7;
						if (AppClass_031.class730_0.int_62 == _return_7)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							AppClass_969.smethod_3();
							return;
						}
						goto _goto_13;
					case _return_7:
						break;
					case 2:
						return;
					}
					goto _goto_14;
					continue;
					_goto_13:
					break;
				}
				continue;
				_goto_14:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_15();
			num = 4;
			if (AppClass_031.class730_0.int_94 != _return_7)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass880Param()
	{
		return null;
	}
}
