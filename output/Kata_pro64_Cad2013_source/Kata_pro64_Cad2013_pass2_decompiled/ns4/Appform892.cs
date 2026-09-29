using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns4;

[DesignerGenerated]
public class GetStatic_1 : Form
{
	private IContainer icontainerParam;

	[CompilerGenerated]
	[AccessedThroughProperty("Undo")]
	private Button _Undo;

	[AccessedThroughProperty("Cancel")]
	[CompilerGenerated]
	private Button _Cancel;

	[AccessedThroughProperty("rong")]
	[CompilerGenerated]
	private TextBox _Rong;

	[CompilerGenerated]
	[AccessedThroughProperty("rongL")]
	private Label _label_1;

	[AccessedThroughProperty("cover")]
	[CompilerGenerated]
	private TextBox _Cover;

	[AccessedThroughProperty("NumSbt")]
	[CompilerGenerated]
	private NumericUpDown _numericupdown_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	private Label _label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Y")]
	private TextBox _textbox_4;

	[CompilerGenerated]
	[AccessedThroughProperty("X")]
	private TextBox _textbox_5;

	[AccessedThroughProperty("H3")]
	[CompilerGenerated]
	private TextBox _H3;

	[CompilerGenerated]
	[AccessedThroughProperty("Hb2")]
	private TextBox _Hb2;

	[CompilerGenerated]
	[AccessedThroughProperty("H2")]
	private TextBox _H2;

	[CompilerGenerated]
	[AccessedThroughProperty("Hb3")]
	private TextBox _Hb3;

	[CompilerGenerated]
	[AccessedThroughProperty("Hb1")]
	private TextBox _Hb1;

	[CompilerGenerated]
	[AccessedThroughProperty("L1")]
	private TextBox _L1;

	[CompilerGenerated]
	[AccessedThroughProperty("Ct2")]
	private TextBox _Ct2;

	[AccessedThroughProperty("vtri_cn")]
	[CompilerGenerated]
	private ComboBox _combobox_6;

	[CompilerGenerated]
	[AccessedThroughProperty("coverL")]
	private Label _Coverl;

	[CompilerGenerated]
	[AccessedThroughProperty("Mi")]
	private CheckBox _Mi;

	[CompilerGenerated]
	[AccessedThroughProperty("ve_thang")]
	private Button _VeThang;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _groupbox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("cau_tao")]
	private TextBox _CauTao;

	[CompilerGenerated]
	[AccessedThroughProperty("cau_taoL")]
	private Label _CauTaol;

	[AccessedThroughProperty("chiu_nghi")]
	[CompilerGenerated]
	private TextBox _ChiuNghi;

	[CompilerGenerated]
	[AccessedThroughProperty("chiu_nghiL")]
	private Label _ChiuNghil;

	[CompilerGenerated]
	[AccessedThroughProperty("main_steel")]
	private TextBox _MainSteel;

	[CompilerGenerated]
	[AccessedThroughProperty("main_steelL")]
	private Label _MainSteell;

	[CompilerGenerated]
	[AccessedThroughProperty("Ct1")]
	private TextBox _Ct1;

	[AccessedThroughProperty("vtri_cnL")]
	[CompilerGenerated]
	private Label _label_8;

	[AccessedThroughProperty("L2")]
	[CompilerGenerated]
	private TextBox _L2;

	[AccessedThroughProperty("L3")]
	[CompilerGenerated]
	private TextBox _L3;

	[CompilerGenerated]
	[AccessedThroughProperty("Redo")]
	private Button _Redo;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupView")]
	private GroupBox _Groupview;

	[CompilerGenerated]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _backgroundworker_9;

	[CompilerGenerated]
	[AccessedThroughProperty("btnLayDuLieu")]
	private Button _button_10;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel _panel_11;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _groupbox_12;

	[AccessedThroughProperty("tb_so_cau_kien")]
	[CompilerGenerated]
	private TextBox _TbSoCauKien;

	[CompilerGenerated]
	[AccessedThroughProperty("so_cau_kienL")]
	private Label _SoCauKienl;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_ten_cau_thang")]
	private TextBox _textbox_13;

	[CompilerGenerated]
	[AccessedThroughProperty("ten_cau_thangL")]
	private Label _TenCauThangl;

	[AccessedThroughProperty("GroupBox3")]
	[CompilerGenerated]
	private GroupBox _groupbox_14;

	[CompilerGenerated]
	[AccessedThroughProperty("ve_thang_shop")]
	private Button _button_15;

	[CompilerGenerated]
	[AccessedThroughProperty("Bd2")]
	private TextBox _Bd2;

	[CompilerGenerated]
	[AccessedThroughProperty("Bd3")]
	private TextBox _Bd3;

	[CompilerGenerated]
	[AccessedThroughProperty("L5")]
	private TextBox _L5;

	[AccessedThroughProperty("Bd4")]
	[CompilerGenerated]
	private TextBox _Bd4;

	[CompilerGenerated]
	[AccessedThroughProperty("L4")]
	private TextBox _L4;

	[CompilerGenerated]
	[AccessedThroughProperty("Bd1")]
	private TextBox _Bd1;

	[AccessedThroughProperty("Hd4")]
	[CompilerGenerated]
	private TextBox _Hd4;

	[CompilerGenerated]
	[AccessedThroughProperty("Hd1")]
	private TextBox _Hd1;

	private List<LineShape> _listLineshape_16;

	private LineShape[,] _lineshape_17;

	private PreviewCanvas _previewcanvas_18;

	private int intParam;

	private double doubleParam;

	private bool boolParam;

	private diem diemParam;

	private Point pointParam;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	internal static GetStatic_1 _appform892_19;

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

	internal virtual NumericUpDown NumericUpDown_0
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

	internal virtual TextBox TextBox_5
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

	internal virtual TextBox TextBox_6
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

	internal virtual TextBox TextBox_7
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

	internal virtual TextBox TextBox_8
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

	internal virtual TextBox TextBox_9
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

	internal virtual TextBox TextBox_10
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

	internal virtual ComboBox ComboBox_0
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

	internal virtual TextBox TextBox_11
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

	internal virtual TextBox TextBox_12
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

	internal virtual TextBox TextBox_13
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

	internal virtual TextBox TextBox_14
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

	internal virtual TextBox TextBox_15
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

	internal virtual TextBox TextBox_16
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

	internal virtual GroupBox GroupBox_1
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

	internal virtual Button Button_4
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

	internal virtual Panel Panel_0
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

	internal virtual GroupBox GroupBox_2
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

	internal virtual TextBox TextBox_17
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

	internal virtual TextBox TextBox_18
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

	internal virtual Label Label_8
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

	internal virtual GroupBox GroupBox_3
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

	internal virtual Button Button_5
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

	internal virtual TextBox TextBox_19
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

	internal virtual TextBox TextBox_20
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

	internal virtual TextBox TextBox_21
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

	internal virtual TextBox TextBox_22
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

	internal virtual TextBox TextBox_23
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

	internal virtual TextBox TextBox_24
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

	internal virtual TextBox TextBox_25
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

	internal virtual TextBox TextBox_26
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
	internal virtual BackgroundWorker backgroundworkerParam()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void voidParam(BackgroundWorker backgroundWorker_1)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	public void voidParam(bool boolParam = true)
	{
	}

	private void voidParam(GroupBox groupBox_4, bool boolParam)
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

	private void voidParam(object sender, MouseEventArgs e)
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

	public void voidParam(int intParam, TextBox textBox_27, diem diemParam, diem diemParam)
	{
	}

	public void voidParam(diem diemParam, diem diemParam, LineShape lineShape_1)
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

	private void voidParam(bool boolParam)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	public void voidParam()
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
						num3 = 1;
						if (AppClass_031.class730_0.int_73 != 0)
						{
							continue;
						}
						goto default;
					case 1:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_34 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_20;
					case 0:
						break;
					}
					goto _goto_21;
					continue;
					_goto_20:
					break;
				}
				continue;
				_goto_21:
				break;
			}
			while (num2 == 990);
			AppClass_969.smethod_3();
			num = 9;
			if (AppClass_031.class730_0.int_26 == 0)
			{
				num = 3;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appform892Param()
	{
		return null;
	}
}
