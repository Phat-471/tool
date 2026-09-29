using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns4;

[DesignerGenerated]
public class GetStatic_1 : Form
{
	private IContainer icontainerParam;

	[CompilerGenerated]
	[AccessedThroughProperty("DL")]
	private Label _Dl;

	[CompilerGenerated]
	[AccessedThroughProperty("D")]
	private ComboBox _combobox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("OK")]
	private Button _Ok;

	[CompilerGenerated]
	[AccessedThroughProperty("cover")]
	private TextBox _Cover;

	[AccessedThroughProperty("coverL")]
	[CompilerGenerated]
	private Label _Coverl;

	[CompilerGenerated]
	[AccessedThroughProperty("kc")]
	private TextBox _Kc;

	[CompilerGenerated]
	[AccessedThroughProperty("kcL")]
	private Label _Kcl;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _groupbox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("cog1L")]
	private Label _label_3;

	[AccessedThroughProperty("cog1")]
	[CompilerGenerated]
	private TextBox _Cog1;

	[AccessedThroughProperty("cog2L")]
	[CompilerGenerated]
	private Label _label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("cog2")]
	private TextBox _Cog2;

	[AccessedThroughProperty("GroupBox2")]
	[CompilerGenerated]
	private GroupBox _groupbox_5;

	[AccessedThroughProperty("Direct_dung")]
	[CompilerGenerated]
	private CheckBox _DirectDung;

	[AccessedThroughProperty("Direct_ngang")]
	[CompilerGenerated]
	private CheckBox _checkbox_6;

	[AccessedThroughProperty("Cancel")]
	[CompilerGenerated]
	private Button _Cancel;

	[CompilerGenerated]
	[AccessedThroughProperty("goc_beL")]
	private Label _GocBel;

	[CompilerGenerated]
	[AccessedThroughProperty("goc_be")]
	private ComboBox _GocBe;

	[AccessedThroughProperty("neo")]
	[CompilerGenerated]
	private TextBox _Neo;

	[AccessedThroughProperty("neoL")]
	[CompilerGenerated]
	private Label _Neol;

	[AccessedThroughProperty("GroupBox4")]
	[CompilerGenerated]
	private GroupBox _groupbox_7;

	[AccessedThroughProperty("bo_tri_gia_cuong")]
	[CompilerGenerated]
	private RadioButton _radiobutton_8;

	[CompilerGenerated]
	[AccessedThroughProperty("bo_tri_deu")]
	private RadioButton _BoTriDeu;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox5")]
	private GroupBox _groupbox_9;

	[AccessedThroughProperty("Radio_Cach_dau")]
	[CompilerGenerated]
	private RadioButton _RadioCachDau;

	[AccessedThroughProperty("Radio_Cach_mep")]
	[CompilerGenerated]
	private RadioButton _RadioCachMep;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	private Label _label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("Cach_dau")]
	private TextBox _CachDau;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	private Label _label_11;

	[AccessedThroughProperty("Cach_mep")]
	[CompilerGenerated]
	private TextBox _CachMep;

	[CompilerGenerated]
	[AccessedThroughProperty("Z")]
	private TextBox _textbox_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	private Label _label_13;

	[AccessedThroughProperty("Thep_duoi")]
	[CompilerGenerated]
	private RadioButton _ThepDuoi;

	[AccessedThroughProperty("Thep_tren")]
	[CompilerGenerated]
	private RadioButton _ThepTren;

	[AccessedThroughProperty("congxonL")]
	[CompilerGenerated]
	private Label _Congxonl;

	[AccessedThroughProperty("Cat_thep_dv_congxon")]
	[CompilerGenerated]
	private ComboBox _combobox_14;

	[CompilerGenerated]
	[AccessedThroughProperty("NhipL")]
	private Label _label_15;

	[CompilerGenerated]
	[AccessedThroughProperty("Cat_thep_congxon")]
	private TextBox _textbox_16;

	[AccessedThroughProperty("Cat_thep_dv_nhip")]
	[CompilerGenerated]
	private ComboBox _combobox_17;

	[AccessedThroughProperty("Cat_thep_nhip")]
	[CompilerGenerated]
	private TextBox _CatThepNhip;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _groupbox_18;

	[CompilerGenerated]
	[AccessedThroughProperty("CT")]
	private TextBox _Ct;

	[CompilerGenerated]
	[AccessedThroughProperty("CTL")]
	private Label _Ctl;

	[AccessedThroughProperty("Block_ct")]
	[CompilerGenerated]
	private RadioButton _radiobutton_19;

	[AccessedThroughProperty("Block_kht")]
	[CompilerGenerated]
	private RadioButton _radiobutton_20;

	[CompilerGenerated]
	[AccessedThroughProperty("chu_thich")]
	private TextBox _ChuThich;

	[CompilerGenerated]
	[AccessedThroughProperty("chu_thichL")]
	private Label _ChuThichl;

	[AccessedThroughProperty("Keo_min")]
	[CompilerGenerated]
	private TextBox _KeoMin;

	[CompilerGenerated]
	[AccessedThroughProperty("Keo_minL")]
	private Label _KeoMinl;

	[CompilerGenerated]
	[AccessedThroughProperty("cog_const")]
	private CheckBox _CogConst;

	[AccessedThroughProperty("Sole")]
	[CompilerGenerated]
	private CheckBox _Sole;

	[AccessedThroughProperty("Tab_giacuong")]
	[CompilerGenerated]
	private TabControl _TabGiacuong;

	[CompilerGenerated]
	[AccessedThroughProperty("Tab_beam")]
	private TabPage _TabBeam;

	[AccessedThroughProperty("Tab_drop")]
	[CompilerGenerated]
	private TabPage _TabDrop;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	private Label _label_21;

	[AccessedThroughProperty("keo_thep_drop")]
	[CompilerGenerated]
	private TextBox _KeoThepDrop;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	private Label _label_22;

	[CompilerGenerated]
	[AccessedThroughProperty("Chan_thep_drop")]
	private TextBox _ChanThepDrop;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	private Label _label_23;

	[CompilerGenerated]
	[AccessedThroughProperty("keo_dim_drop")]
	private TextBox _KeoDimDrop;

	[CompilerGenerated]
	[AccessedThroughProperty("Cat_thep")]
	private TextBox _CatThep;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	private Label _label_24;

	[CompilerGenerated]
	[AccessedThroughProperty("OK_vung")]
	private Button _OkVung;

	[CompilerGenerated]
	[AccessedThroughProperty("btnRaiThepKeSan")]
	private Button _button_25;

	private static GetStatic_1 _appform891_26;

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

	internal virtual ComboBox ComboBox_1
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

	internal virtual RadioButton RadioButton_2
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

	internal virtual RadioButton RadioButton_3
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

	internal virtual Label Label_9
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

	internal virtual RadioButton RadioButton_4
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

	internal virtual RadioButton RadioButton_5
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

	internal virtual Label Label_10
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

	internal virtual ComboBox ComboBox_2
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

	internal virtual Label Label_11
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

	internal virtual ComboBox ComboBox_3
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

	internal virtual GroupBox GroupBox_4
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

	internal virtual Label Label_12
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

	internal virtual RadioButton RadioButton_6
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

	internal virtual RadioButton RadioButton_7
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

	internal virtual Label Label_13
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

	internal virtual Label Label_14
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

	internal virtual CheckBox CheckBox_2
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

	internal virtual CheckBox CheckBox_3
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

	internal virtual TabControl TabControl_0
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

	internal virtual TabPage TabPage_0
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

	internal virtual TabPage TabPage_1
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

	internal virtual Label Label_15
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

	internal virtual Label Label_16
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

	internal virtual Label Label_17
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

	internal virtual Label Label_18
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool boolParam)
	{
	}

	[DebuggerStepThrough]
	private void voidParam()
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
					case 0:
						AppClass_969.smethod_3();
						num3 = 1;
						if (AppClass_031.class730_0.int_63 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							goto _goto_27;
						}
						AppClass_960.smethod_15();
						num3 = 9;
						if (AppClass_031.class730_0.int_3 == 0)
						{
							continue;
						}
						goto case 0;
					case 2:
						break;
					case 1:
						return;
					}
					goto _goto_28;
					continue;
					_goto_27:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				_goto_28:
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

	internal static GetStatic_1 appform891Param()
	{
		return null;
	}
}
