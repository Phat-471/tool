using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Autodesk.AutoCAD.Geometry;
using Kata_Class_Lib_Revit;
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
		public static readonly GetStatic_1 _appclass822_1;

		public static Func<Point3d, diem> diemParam;

		public static Action actionParam;

		private static GetStatic_1 _appclass822_2;

		static GetStatic_1()
		{
			AppClass_960.smethod_23();
			int num = 3;
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
						case 3:
							AppClass_960.smethod_13();
							goto case 2;
						case 2:
							AppClass_960.smethod_15();
							num3 = 7;
							if (AppClass_031.class730_0.int_84 == 0)
							{
								continue;
							}
							break;
						case 0:
							_appclass822_1 = new GetStatic_1();
							num3 = 8;
							if (AppClass_031.class730_0.int_100 != 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto _goto_3;
								}
								goto case 3;
							}
							AppClass_967.boolParam();
							num3 = 0;
							if (AppClass_031.class730_0.int_7 != 0)
							{
								continue;
							}
							goto case 2;
						case 1:
							break;
						case 4:
							return;
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
				num = 2;
				if (AppClass_031.class730_0.int_102 == 0)
				{
					num = 11;
				}
			}
		}

		[SpecialName]
		internal void voidParam()
		{
		}

		[SpecialName]
		internal diem diemParam(Point3d point3d_0)
		{
			return null;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass822Param()
		{
			return null;
		}
	}

	private IContainer icontainerParam;

	[CompilerGenerated]
	[AccessedThroughProperty("BindingSource1")]
	private BindingSource _bindingsource_5;

	[AccessedThroughProperty("ve_goi")]
	[CompilerGenerated]
	private Button _VeGoi;

	[AccessedThroughProperty("ve_nhip")]
	[CompilerGenerated]
	private Button _VeNhip;

	[CompilerGenerated]
	[AccessedThroughProperty("ve_nhip_va_goi")]
	private Button _VeNhipVaGoi;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupView")]
	private GroupBox _Groupview;

	[AccessedThroughProperty("ChieuCaoVungNoiLb")]
	[CompilerGenerated]
	private Label _label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("ChieuCaoVungNoiTb")]
	private TextBox _textbox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PickDiemGoiNhipBtn")]
	private Button _button_8;

	[CompilerGenerated]
	[AccessedThroughProperty("TamGoiRb")]
	private RadioButton _Tamgoirb;

	[AccessedThroughProperty("MepGoiRb")]
	[CompilerGenerated]
	private RadioButton _Mepgoirb;

	[AccessedThroughProperty("LGoiTb")]
	[CompilerGenerated]
	private TextBox _Lgoitb;

	[AccessedThroughProperty("PhanVungGoiLb")]
	[CompilerGenerated]
	private Label _label_9;

	[CompilerGenerated]
	[AccessedThroughProperty("LNhipTb")]
	private TextBox _textbox_10;

	[AccessedThroughProperty("PhanVungNhipLb")]
	[CompilerGenerated]
	private Label _label_11;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	private Label _label_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	private Label _label_13;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	private Label _label_14;

	[CompilerGenerated]
	[AccessedThroughProperty("ThemPhanVungNoiTb")]
	private TextBox _textbox_15;

	[AccessedThroughProperty("ThemPhanVungNoiLb")]
	[CompilerGenerated]
	private Label _label_16;

	[CompilerGenerated]
	[AccessedThroughProperty("ThemPhanVungNoiCb")]
	private CheckBox _checkbox_17;

	[CompilerGenerated]
	[AccessedThroughProperty("TachPhanVungNoiCb")]
	private CheckBox _checkbox_18;

	[AccessedThroughProperty("TachPhanVungNoiTb")]
	[CompilerGenerated]
	private TextBox _textbox_19;

	[AccessedThroughProperty("TachPhanVungNoiLb")]
	[CompilerGenerated]
	private Label _label_20;

	private PreviewCanvas _previewcanvas_21;

	private double doubleParam;

	private bool boolParam;

	private Point pointParam;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	internal static GetStatic_2 _appform822_22;

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

	internal virtual Button Button_1
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

	internal virtual Button Button_2
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

	internal virtual Label Label_0
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

	internal virtual TextBox TextBox_0
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

	internal virtual Button Button_3
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

	internal virtual RadioButton RadioButton_0
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

	internal virtual RadioButton RadioButton_1
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

	internal virtual TextBox TextBox_1
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

	internal virtual Label Label_1
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

	internal virtual TextBox TextBox_2
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

	internal virtual Label Label_2
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

	internal virtual Label Label_3
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

	internal virtual Label Label_4
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

	internal virtual Label Label_5
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

	internal virtual TextBox TextBox_3
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

	internal virtual Label Label_6
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

	internal virtual CheckBox CheckBox_0
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

	internal virtual CheckBox CheckBox_1
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

	internal virtual TextBox TextBox_4
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

	internal virtual Label Label_7
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
	private void voidParam()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual BindingSource bindingsourceParam()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void voidParam(BindingSource bindingSource_1)
	{
	}

	private void diemParam(object sender, MouseEventArgs e)
	{
	}

	private void voidParam(object sender, MouseEventArgs e)
	{
	}

	private void voidParam(object sender, MouseEventArgs e)
	{
	}

	private void voidParam(object sender, MouseEventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam()
	{
	}

	public void voidParam(bool boolParam = false)
	{
	}

	public void voidParam()
	{
	}

	public void voidParam()
	{
	}

	public void voidParam()
	{
	}

	public void voidParam(bool boolParam)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, FormClosingEventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
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
						num3 = 7;
						if (AppClass_031.class730_0.int_106 != 0)
						{
							continue;
						}
						break;
					default:
						if (num2 != 9)
						{
							goto _goto_23;
						}
						AppClass_969.smethod_3();
						num3 = 6;
						if (AppClass_031.class730_0.int_25 == 0)
						{
							continue;
						}
						return;
					case 0:
						break;
					case 2:
						return;
					}
					goto _goto_24;
					continue;
					_goto_23:
					break;
				}
				continue;
				_goto_24:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_102 != 0)
			{
				num = 2;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass822Param()
	{
		return null;
	}
}
