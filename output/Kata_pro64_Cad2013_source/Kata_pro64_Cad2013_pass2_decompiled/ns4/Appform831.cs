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

	[AccessedThroughProperty("slL")]
	[CompilerGenerated]
	private Label _Sll;

	[AccessedThroughProperty("GroupBox1")]
	[CompilerGenerated]
	private GroupBox _groupbox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_cover_duoi")]
	private TextBox _TbCoverDuoi;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label _label_2;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_dbm_thep_ngang_duoi_duoi")]
	private TextBox _textbox_3;

	[AccessedThroughProperty("moc_duoiL")]
	[CompilerGenerated]
	private Label _MocDuoil;

	[CompilerGenerated]
	[AccessedThroughProperty("moc_traiL")]
	private Label _MocTrail;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_dbm_thep_doc_duoi_trai")]
	private TextBox _textbox_4;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_dbm_thep_ngang_duoi_tren")]
	private TextBox _textbox_5;

	[CompilerGenerated]
	[AccessedThroughProperty("moc_phaiL")]
	private Label _MocPhail;

	[AccessedThroughProperty("moc_trenL")]
	[CompilerGenerated]
	private Label _MocTrenl;

	[AccessedThroughProperty("tb_dbm_thep_doc_duoi_phai")]
	[CompilerGenerated]
	private TextBox _textbox_6;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_ten_ck")]
	private TextBox _textbox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Ten_mongL")]
	private Label _TenMongl;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _groupbox_8;

	[CompilerGenerated]
	[AccessedThroughProperty("sl")]
	private TextBox _Sl;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBoxLenh")]
	private TextBox _Textboxlenh;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupView")]
	private GroupBox _Groupview;

	[AccessedThroughProperty("tb_thep_doc_tren")]
	[CompilerGenerated]
	private TextBox _textbox_9;

	[AccessedThroughProperty("tb_thep_ngang_tren")]
	[CompilerGenerated]
	private TextBox _textbox_10;

	[AccessedThroughProperty("tb_h1")]
	[CompilerGenerated]
	private TextBox _TbH1;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_e1")]
	private TextBox _TbE1;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_h2")]
	private TextBox _TbH2;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_h3")]
	private TextBox _TbH3;

	[AccessedThroughProperty("tb_d3")]
	[CompilerGenerated]
	private TextBox _TbD3;

	[AccessedThroughProperty("tb_e2")]
	[CompilerGenerated]
	private TextBox _TbE2;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_e3")]
	private TextBox _TbE3;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_d2")]
	private TextBox _TbD2;

	[AccessedThroughProperty("tb_d1")]
	[CompilerGenerated]
	private TextBox _TbD1;

	[AccessedThroughProperty("Ct")]
	[CompilerGenerated]
	private TextBox _Ct;

	[AccessedThroughProperty("Cancel")]
	[CompilerGenerated]
	private Button _Cancel;

	[AccessedThroughProperty("ve_mong")]
	[CompilerGenerated]
	private Button _VeMong;

	[CompilerGenerated]
	[AccessedThroughProperty("BindingSource1")]
	private BindingSource _bindingsource_11;

	[AccessedThroughProperty("GroupBox3")]
	[CompilerGenerated]
	private GroupBox _groupbox_12;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_thep_do")]
	private TextBox _textbox_13;

	[AccessedThroughProperty("cb_co_thep_do")]
	[CompilerGenerated]
	private CheckBox _CbCoThepDo;

	[CompilerGenerated]
	[AccessedThroughProperty("cb_co_thep_dai")]
	private CheckBox _CbCoThepDai;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	private Label _label_14;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	private Label _label_15;

	[AccessedThroughProperty("tb_dbm_thep_dai")]
	[CompilerGenerated]
	private TextBox _textbox_16;

	[AccessedThroughProperty("tb_thep_dai")]
	[CompilerGenerated]
	private TextBox _textbox_17;

	[AccessedThroughProperty("Label4")]
	[CompilerGenerated]
	private Label _label_18;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	private Label _label_19;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _groupbox_20;

	[AccessedThroughProperty("tb_dbm_thep_ngang_tren_duoi")]
	[CompilerGenerated]
	private TextBox _textbox_21;

	[CompilerGenerated]
	[AccessedThroughProperty("Label9")]
	private Label _label_22;

	[AccessedThroughProperty("Label10")]
	[CompilerGenerated]
	private Label _label_23;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_dbm_thep_doc_tren_trai")]
	private TextBox _textbox_24;

	[AccessedThroughProperty("tb_dbm_thep_ngang_tren_tren")]
	[CompilerGenerated]
	private TextBox _textbox_25;

	[CompilerGenerated]
	[AccessedThroughProperty("Label11")]
	private Label _label_26;

	[AccessedThroughProperty("Label12")]
	[CompilerGenerated]
	private Label _label_27;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_dbm_thep_doc_tren_phai")]
	private TextBox _textbox_28;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_thep_doc_duoi")]
	private TextBox _textbox_29;

	[AccessedThroughProperty("tb_thep_ngang_duoi")]
	[CompilerGenerated]
	private TextBox _textbox_30;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_cover_ngang")]
	private TextBox _TbCoverNgang;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_cover_tren")]
	private TextBox _TbCoverTren;

	[AccessedThroughProperty("Label8")]
	[CompilerGenerated]
	private Label _label_31;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _radiobutton_32;

	[AccessedThroughProperty("CheckThepCot")]
	[CompilerGenerated]
	private RadioButton _radiobutton_33;

	[AccessedThroughProperty("Label14")]
	[CompilerGenerated]
	private Label _label_34;

	[CompilerGenerated]
	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _radiobutton_35;

	[AccessedThroughProperty("cb_co_thep_tren")]
	[CompilerGenerated]
	private RadioButton _CbCoThepTren;

	[AccessedThroughProperty("Label13")]
	[CompilerGenerated]
	private Label _label_36;

	[AccessedThroughProperty("GroupBox5")]
	[CompilerGenerated]
	private GroupBox _groupbox_37;

	[CompilerGenerated]
	[AccessedThroughProperty("Label19")]
	private Label _label_38;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_day_san_trai")]
	private TextBox _TbDaySanTrai;

	[CompilerGenerated]
	[AccessedThroughProperty("Label20")]
	private Label _label_39;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_day_san_phai")]
	private TextBox _TbDaySanPhai;

	[CompilerGenerated]
	[AccessedThroughProperty("tbcautao")]
	private TextBox _Tbcautao;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	private Label _label_40;

	[AccessedThroughProperty("notcbdang")]
	[CompilerGenerated]
	private RadioButton _radiobutton_41;

	[AccessedThroughProperty("cbdang")]
	[CompilerGenerated]
	private RadioButton _radiobutton_42;

	[CompilerGenerated]
	[AccessedThroughProperty("Label16")]
	private Label _label_43;

	[AccessedThroughProperty("GroupBox6")]
	[CompilerGenerated]
	private GroupBox _groupbox_44;

	[AccessedThroughProperty("tb_h4")]
	[CompilerGenerated]
	private TextBox _TbH4;

	[AccessedThroughProperty("Button1")]
	[CompilerGenerated]
	private Button _button_45;

	[AccessedThroughProperty("Button2")]
	[CompilerGenerated]
	private Button _button_46;

	[AccessedThroughProperty("btnLayDuLieu")]
	[CompilerGenerated]
	private Button _button_47;

	[AccessedThroughProperty("cbdangkhong")]
	[CompilerGenerated]
	private RadioButton _radiobutton_48;

	[AccessedThroughProperty("GroupBox7")]
	[CompilerGenerated]
	private GroupBox _groupbox_49;

	[AccessedThroughProperty("Label17")]
	[CompilerGenerated]
	private Label _label_50;

	[CompilerGenerated]
	[AccessedThroughProperty("daiRauCoctb")]
	private TextBox _Dairaucoctb;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel _panel_51;

	[AccessedThroughProperty("ve_mong_shop")]
	[CompilerGenerated]
	private Button _button_52;

	[CompilerGenerated]
	[AccessedThroughProperty("Label18")]
	private Label _label_53;

	[CompilerGenerated]
	[AccessedThroughProperty("beMocCauTaotb")]
	private TextBox _textbox_54;

	[AccessedThroughProperty("Label21")]
	[CompilerGenerated]
	private Label _label_55;

	[CompilerGenerated]
	[AccessedThroughProperty("mocDaiDungtb")]
	private TextBox _textbox_56;

	[CompilerGenerated]
	[AccessedThroughProperty("hCho2")]
	private TextBox _textbox_57;

	[AccessedThroughProperty("hCho3")]
	[CompilerGenerated]
	private TextBox _textbox_58;

	[AccessedThroughProperty("hCho1")]
	[CompilerGenerated]
	private TextBox _textbox_59;

	[AccessedThroughProperty("cb_co_thep_cau_tao")]
	[CompilerGenerated]
	private CheckBox _checkbox_60;

	[CompilerGenerated]
	[AccessedThroughProperty("TLBV")]
	private ComboBox _combobox_61;

	[CompilerGenerated]
	[AccessedThroughProperty("Label15")]
	private Label _label_62;

	[CompilerGenerated]
	[AccessedThroughProperty("Button3")]
	private Button _button_63;

	[AccessedThroughProperty("TabControlCot")]
	[CompilerGenerated]
	private TabControl _Tabcontrolcot;

	[CompilerGenerated]
	[AccessedThroughProperty("TabPage1")]
	private TabPage _tabpage_64;

	[CompilerGenerated]
	[AccessedThroughProperty("PanelCot")]
	private Panel _Panelcot;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_cotL")]
	private Label _PhiCotl;

	[CompilerGenerated]
	[AccessedThroughProperty("daivuongY")]
	private TextBox _Daivuongy;

	[AccessedThroughProperty("Cover_cot")]
	[CompilerGenerated]
	private TextBox _CoverCot;

	[AccessedThroughProperty("Label24")]
	[CompilerGenerated]
	private Label _label_65;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	private Label _label_66;

	[AccessedThroughProperty("daiCY")]
	[CompilerGenerated]
	private TextBox _Daicy;

	[CompilerGenerated]
	[AccessedThroughProperty("dai_cot")]
	private TextBox _DaiCot;

	[CompilerGenerated]
	[AccessedThroughProperty("Label25")]
	private Label _label_67;

	[CompilerGenerated]
	[AccessedThroughProperty("Thep_cot_tronL")]
	private Label _ThepCotTronl;

	[CompilerGenerated]
	[AccessedThroughProperty("daivuongX")]
	private TextBox _Daivuongx;

	[AccessedThroughProperty("dai_cotL")]
	[CompilerGenerated]
	private Label _DaiCotl;

	[AccessedThroughProperty("Label32")]
	[CompilerGenerated]
	private Label _label_68;

	[AccessedThroughProperty("Thep_cot_tron")]
	[CompilerGenerated]
	private TextBox _ThepCotTron;

	[AccessedThroughProperty("daiCX")]
	[CompilerGenerated]
	private TextBox _Daicx;

	[CompilerGenerated]
	[AccessedThroughProperty("khoaDauCot")]
	private CheckBox _Khoadaucot;

	[AccessedThroughProperty("Label33")]
	[CompilerGenerated]
	private Label _label_69;

	[AccessedThroughProperty("Thep_cot_Y")]
	[CompilerGenerated]
	private TextBox _ThepCotY;

	[AccessedThroughProperty("phi_cot")]
	[CompilerGenerated]
	private TextBox _PhiCot;

	[CompilerGenerated]
	[AccessedThroughProperty("Label23")]
	private Label _label_70;

	[CompilerGenerated]
	[AccessedThroughProperty("topleg")]
	private TextBox _Topleg;

	[AccessedThroughProperty("Thep_cot_XL")]
	[CompilerGenerated]
	private Label _ThepCotXl;

	[AccessedThroughProperty("Thep_cot_X")]
	[CompilerGenerated]
	private TextBox _ThepCotX;

	[CompilerGenerated]
	[AccessedThroughProperty("leg")]
	private TextBox _Leg;

	[AccessedThroughProperty("Label22")]
	[CompilerGenerated]
	private Label _label_71;

	[CompilerGenerated]
	[AccessedThroughProperty("Thep_cot_YL")]
	private Label _ThepCotYl;

	[CompilerGenerated]
	[AccessedThroughProperty("Label26")]
	private Label _label_72;

	[AccessedThroughProperty("daiCTron")]
	[CompilerGenerated]
	private TextBox _Daictron;

	[AccessedThroughProperty("NeoSanTb")]
	[CompilerGenerated]
	private TextBox _Neosantb;

	[CompilerGenerated]
	[AccessedThroughProperty("NeoSanLb")]
	private Label _Neosanlb;

	[CompilerGenerated]
	[AccessedThroughProperty("cbdangz")]
	private RadioButton _radiobutton_73;

	[AccessedThroughProperty("DoiViTriThepTrenCb")]
	[CompilerGenerated]
	private CheckBox _checkbox_74;

	[AccessedThroughProperty("DoiViTriThepDuoiCb")]
	[CompilerGenerated]
	private CheckBox _checkbox_75;

	private PreviewCanvas _previewcanvas_76;

	public bool boolParam;

	private bool boolParam;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	private int intParam;

	internal static GetStatic_1 _appform831_77;

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

	internal virtual TextBox TextBox_27
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

	internal virtual TextBox TextBox_28
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

	internal virtual TextBox TextBox_29
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

	internal virtual TextBox TextBox_30
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

	internal virtual GroupBox GroupBox_5
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

	internal virtual TextBox TextBox_31
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

	internal virtual Label Label_19
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

	internal virtual TextBox TextBox_32
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

	internal virtual TextBox TextBox_33
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

	internal virtual Label Label_20
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

	internal virtual Label Label_21
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

	internal virtual GroupBox GroupBox_6
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

	internal virtual TextBox TextBox_34
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

	internal virtual GroupBox GroupBox_7
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

	internal virtual Label Label_22
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

	internal virtual TextBox TextBox_35
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

	internal virtual Label Label_23
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

	internal virtual TextBox TextBox_36
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

	internal virtual Label Label_24
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

	internal virtual TextBox TextBox_37
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

	internal virtual TextBox TextBox_38
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

	internal virtual TextBox TextBox_39
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

	internal virtual TextBox TextBox_40
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

	internal virtual Label Label_25
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

	internal virtual Button Button_6
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

	internal virtual Panel Panel_1
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

	internal virtual Label Label_26
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

	internal virtual TextBox TextBox_41
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

	internal virtual TextBox TextBox_42
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

	internal virtual Label Label_27
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

	internal virtual Label Label_28
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

	internal virtual TextBox TextBox_43
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

	internal virtual TextBox TextBox_44
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

	internal virtual Label Label_29
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

	internal virtual Label Label_30
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

	internal virtual TextBox TextBox_45
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

	internal virtual Label Label_31
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

	internal virtual Label Label_32
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

	internal virtual TextBox TextBox_46
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

	internal virtual TextBox TextBox_47
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

	internal virtual Label Label_33
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

	internal virtual TextBox TextBox_48
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

	internal virtual TextBox TextBox_49
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

	internal virtual Label Label_34
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

	internal virtual TextBox TextBox_50
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

	internal virtual Label Label_35
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

	internal virtual TextBox TextBox_51
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

	internal virtual TextBox TextBox_52
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

	internal virtual Label Label_36
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

	internal virtual Label Label_37
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

	internal virtual Label Label_38
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

	internal virtual TextBox TextBox_53
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

	internal virtual TextBox TextBox_54
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

	internal virtual Label Label_39
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

	internal virtual CheckBox CheckBox_4
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

	internal virtual CheckBox CheckBox_5
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

	private void voidParam(object sender, EventArgs e)
	{
	}

	public void voidParam()
	{
	}

	private void voidParam()
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

	public void voidParam()
	{
	}

	public string stringParam(string stringParam)
	{
		return null;
	}

	public void voidParam(Line_diem line_diem_0, PreviewCanvas previewCanvas_1, GroupBox groupBox_8, Point pointParam, diem diemParam, diem diemParam, diem diemParam, double doubleParam)
	{
	}

	public void voidParam(Point pointParam, diem diemParam, diem diemParam, diem diemParam, double doubleParam)
	{
	}

	public List<Line_diem> listLineDiemParam(diem diemParam)
	{
		return null;
	}

	public List<Line_diem> listLineDiemParam(diem diemParam)
	{
		return null;
	}

	public List<Line_diem> listLineDiemParam(diem diemParam)
	{
		return null;
	}

	public List<Line_diem> listLineDiemParam(diem diemParam)
	{
		return null;
	}

	public void voidParam(List<diem> listDiemParam, Point pointParam, diem diemParam, diem diemParam, diem diemParam, double doubleParam, Color colorParam)
	{
	}

	public void voidParam(List<diem> listDiemParam, Point pointParam, diem diemParam, diem diemParam, diem diemParam, double doubleParam, Color colorParam)
	{
	}

	public void voidParam(List<diem> listDiemParam, Point pointParam, diem diemParam, diem diemParam, diem diemParam, double doubleParam, Color colorParam)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

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

	public void voidParam()
	{
	}

	private AppClass_289.AppClass_297 appclass297Param(List<diem> listDiemParam)
	{
		return null;
	}

	public void voidParam(bool boolParam = false)
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

	private void voidParam(string stringParam, AppClass_289.AppClass_298 gclass126_0)
	{
	}

	private AppClass_289.AppClass_298 appclass298Param(string stringParam)
	{
		return null;
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

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				_goto_82:
				int num3 = num2;
				while (true)
				{
					_goto_81:
					switch (num3)
					{
					case 0:
						goto _goto_78;
					case 1:
						goto _goto_79;
					case 2:
						return;
					}
					while (true)
					{
						switch (num2)
						{
						case 9:
							goto _goto_80;
						default:
							return;
						case 990:
							break;
						}
						break;
						_goto_80:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_111 == 0)
						{
							continue;
						}
						goto _goto_81;
					}
					goto _goto_82;
					continue;
					_goto_78:
					break;
				}
				AppClass_969.smethod_3();
				num = 2;
				break;
				_goto_79:
				AppClass_960.smethod_13();
				num = 9;
				if (AppClass_031.class730_0.int_48 == 0)
				{
					num = 7;
				}
				break;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appform831Param()
	{
		return null;
	}
}
