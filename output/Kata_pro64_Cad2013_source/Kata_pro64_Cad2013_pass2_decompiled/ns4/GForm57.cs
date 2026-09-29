using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

	[AccessedThroughProperty("Tab_bxh")]
	[CompilerGenerated]
	private TabControl _tabcontrol_1;

	[AccessedThroughProperty("TabPage1")]
	[CompilerGenerated]
	private TabPage _tabpage_2;

	[AccessedThroughProperty("OK")]
	[CompilerGenerated]
	private Button _Ok;

	[CompilerGenerated]
	[AccessedThroughProperty("Cancel")]
	private Button _Cancel;

	[CompilerGenerated]
	[AccessedThroughProperty("Giong_dai_ngoai")]
	private RadioButton _radiobutton_3;

	[AccessedThroughProperty("dai_gc_deu")]
	[CompilerGenerated]
	private RadioButton _DaiGcDeu;

	[AccessedThroughProperty("Label25")]
	[CompilerGenerated]
	private Label _label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Thep_gia_sl")]
	private TextBox _ThepGiaSl;

	[CompilerGenerated]
	[AccessedThroughProperty("aDaiNhip")]
	private TextBox _Adainhip;

	[CompilerGenerated]
	[AccessedThroughProperty("cd")]
	private TextBox _Cd;

	[AccessedThroughProperty("Label17")]
	[CompilerGenerated]
	private Label _label_5;

	[AccessedThroughProperty("aDaiGoi")]
	[CompilerGenerated]
	private TextBox _Adaigoi;

	[CompilerGenerated]
	[AccessedThroughProperty("Label19")]
	private Label _label_6;

	[AccessedThroughProperty("Thep_gia_dk")]
	[CompilerGenerated]
	private TextBox _ThepGiaDk;

	[CompilerGenerated]
	[AccessedThroughProperty("Label18")]
	private Label _label_7;

	[AccessedThroughProperty("Label26")]
	[CompilerGenerated]
	private Label _label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("thep_t")]
	private TextBox _textbox_9;

	[CompilerGenerated]
	[AccessedThroughProperty("thep_d")]
	private TextBox _textbox_10;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	private Label _label_11;

	[AccessedThroughProperty("aGiaCuong")]
	[CompilerGenerated]
	private TextBox _Agiacuong;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	private Label _label_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Grid_Thep_gc")]
	private DataGridView _datagridview_13;

	[AccessedThroughProperty("Thep_ke")]
	[CompilerGenerated]
	private TextBox _ThepKe;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	private Label _label_14;

	[AccessedThroughProperty("Group_daigc")]
	[CompilerGenerated]
	private GroupBox _GroupDaigc;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	private Label _label_15;

	[CompilerGenerated]
	[AccessedThroughProperty("Dai_xoan")]
	private CheckBox _DaiXoan;

	[AccessedThroughProperty("Dai_gc_C")]
	[CompilerGenerated]
	private TextBox _DaiGcC;

	[AccessedThroughProperty("Label4")]
	[CompilerGenerated]
	private Label _label_16;

	[CompilerGenerated]
	[AccessedThroughProperty("Dai_gc_U")]
	private TextBox _DaiGcU;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	private Label _label_17;

	[CompilerGenerated]
	[AccessedThroughProperty("Dai_gc_CN")]
	private TextBox _textbox_18;

	[CompilerGenerated]
	[AccessedThroughProperty("Group_dai_ngoai")]
	private GroupBox _groupbox_19;

	[AccessedThroughProperty("cd_gc")]
	[CompilerGenerated]
	private TextBox _textbox_20;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	private Label _label_21;

	[CompilerGenerated]
	[AccessedThroughProperty("Goi_trai")]
	private DataGridViewTextBoxColumn _GoiTrai;

	[AccessedThroughProperty("Giua_nhip")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _GiuaNhip;

	[AccessedThroughProperty("Goi_phai")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _GoiPhai;

	public SortedDictionary<string, List<Info_Beam3D>> sortedDictionary_0;

	private SortedDictionary<string, info_BlockBeam_ThepBoTri> sortedDictionary_1;

	private TabPage[] _tabpagearray_22;

	private int intParam;

	private info_BlockBeam_ThepBoTri _infoBlockbeamThepbotri_23;

	internal static GetStatic_1 _appform882_24;

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

	internal virtual DataGridView DataGridView_0
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_0
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_1
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_2
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

	public info_BlockBeam_ThepBoTri infoBlockbeamThepbotriParam()
	{
		return null;
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	public void voidParam()
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
					case 1:
						AppClass_969.smethod_3();
						num3 = 1;
						if (AppClass_031.class730_0.int_37 != 0)
						{
							continue;
						}
						return;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_25;
							}
						}
						else
						{
							AppClass_960.smethod_15();
							num3 = 4;
							if (AppClass_031.class730_0.int_13 != 0)
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
					goto _goto_26;
					continue;
					_goto_25:
					break;
				}
				continue;
				_goto_26:
				break;
			}
			AppClass_960.smethod_13();
			num = 9;
			if (AppClass_031.class730_0.int_116 != 0)
			{
				num = 6;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appform882Param()
	{
		return null;
	}
}
