using System;
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
	[AccessedThroughProperty("GroupView")]
	private GroupBox _Groupview;

	[AccessedThroughProperty("caoTrinhTren")]
	[CompilerGenerated]
	private TextBox _textbox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("caoTrinhDuoi")]
	private TextBox _Caotrinhduoi;

	[AccessedThroughProperty("Panel2")]
	[CompilerGenerated]
	private Panel _panel_2;

	[AccessedThroughProperty("tbMau")]
	[CompilerGenerated]
	private TextBox _Tbmau;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	[CompilerGenerated]
	private FlowLayoutPanel _flowlayoutpanel_3;

	[AccessedThroughProperty("ThongSoChungGrB")]
	[CompilerGenerated]
	private GroupBox _groupbox_4;

	[AccessedThroughProperty("Panel4")]
	[CompilerGenerated]
	private Panel _panel_5;

	[AccessedThroughProperty("CatThepCb")]
	[CompilerGenerated]
	private CheckBox _Catthepcb;

	[AccessedThroughProperty("GCDLop1Lb")]
	[CompilerGenerated]
	private Label _label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD1")]
	private TextBox _textbox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("GCTLop1Lb")]
	private Label _label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT1")]
	private TextBox _textbox_9;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepGiaCuongTrenLb")]
	private Label _label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepGiaCuongDuoiLb")]
	private Label _label_11;

	[AccessedThroughProperty("GCDLop3Lb")]
	[CompilerGenerated]
	private Label _label_12;

	[CompilerGenerated]
	[AccessedThroughProperty("GCDLop2Lb")]
	private Label _label_13;

	[AccessedThroughProperty("thepCLT")]
	[CompilerGenerated]
	private TextBox _textbox_14;

	[AccessedThroughProperty("thepGCD3")]
	[CompilerGenerated]
	private TextBox _textbox_15;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepChiuLucTrenLb")]
	private Label _label_16;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD2")]
	private TextBox _textbox_17;

	[AccessedThroughProperty("thepCLD")]
	[CompilerGenerated]
	private TextBox _textbox_18;

	[AccessedThroughProperty("ThepChiuLucDuoiLb")]
	[CompilerGenerated]
	private Label _label_19;

	[AccessedThroughProperty("GCTLop2Lb")]
	[CompilerGenerated]
	private Label _label_20;

	[AccessedThroughProperty("GCTLop3Lb")]
	[CompilerGenerated]
	private Label _label_21;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT3")]
	private TextBox _textbox_22;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT2")]
	private TextBox _textbox_23;

	[AccessedThroughProperty("Panel3")]
	[CompilerGenerated]
	private Panel _panel_24;

	[AccessedThroughProperty("KcDaiGCLb")]
	[CompilerGenerated]
	private Label _label_25;

	[CompilerGenerated]
	[AccessedThroughProperty("aGiaCuong")]
	private TextBox _Agiacuong;

	[AccessedThroughProperty("GiongDaiNgoaiRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_26;

	[CompilerGenerated]
	[AccessedThroughProperty("BoTriDeuRb")]
	private RadioButton _Botrideurb;

	[CompilerGenerated]
	[AccessedThroughProperty("SoLopCotGiaLb")]
	private Label _label_27;

	[AccessedThroughProperty("nCotGia")]
	[CompilerGenerated]
	private TextBox _Ncotgia;

	[AccessedThroughProperty("DKCotGiaLb")]
	[CompilerGenerated]
	private Label _Dkcotgialb;

	[CompilerGenerated]
	[AccessedThroughProperty("aDaiNhip")]
	private TextBox _Adainhip;

	[AccessedThroughProperty("fDai")]
	[CompilerGenerated]
	private TextBox _Fdai;

	[CompilerGenerated]
	[AccessedThroughProperty("LNhip")]
	private TextBox _textbox_28;

	[CompilerGenerated]
	[AccessedThroughProperty("DKDaiLb")]
	private Label _Dkdailb;

	[AccessedThroughProperty("abv")]
	[CompilerGenerated]
	private TextBox _Abv;

	[AccessedThroughProperty("CatThepGCNhipLb")]
	[CompilerGenerated]
	private Label _label_29;

	[CompilerGenerated]
	[AccessedThroughProperty("ABvThepLb")]
	private Label _label_30;

	[AccessedThroughProperty("aDaiGoi")]
	[CompilerGenerated]
	private TextBox _Adaigoi;

	[CompilerGenerated]
	[AccessedThroughProperty("CatThepGCGoiLb")]
	private Label _label_31;

	[CompilerGenerated]
	[AccessedThroughProperty("GanGoiLb")]
	private Label _Gangoilb;

	[AccessedThroughProperty("LGoi")]
	[CompilerGenerated]
	private TextBox _Lgoi;

	[AccessedThroughProperty("fCotGia")]
	[CompilerGenerated]
	private TextBox _Fcotgia;

	[AccessedThroughProperty("GiuaNhipLb")]
	[CompilerGenerated]
	private Label _Giuanhiplb;

	[CompilerGenerated]
	[AccessedThroughProperty("Label20")]
	private Label _label_32;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_cotL")]
	private Label _PhiCotl;

	[CompilerGenerated]
	[AccessedThroughProperty("VeMatCatBtn")]
	private Button _button_33;

	[AccessedThroughProperty("CancelBtn")]
	[CompilerGenerated]
	private Button _button_34;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _panel_35;

	[AccessedThroughProperty("Panel5")]
	[CompilerGenerated]
	private Panel _panel_36;

	[AccessedThroughProperty("mc_Grid")]
	[CompilerGenerated]
	private DataGridView _datagridview_37;

	[AccessedThroughProperty("leg2")]
	[CompilerGenerated]
	private TextBox _Leg2;

	[CompilerGenerated]
	[AccessedThroughProperty("DbkTLDLb")]
	private Label _label_38;

	[AccessedThroughProperty("leg1")]
	[CompilerGenerated]
	private TextBox _Leg1;

	[AccessedThroughProperty("DbkTLTLb")]
	[CompilerGenerated]
	private Label _label_39;

	[AccessedThroughProperty("hDam")]
	[CompilerGenerated]
	private TextBox _Hdam;

	[AccessedThroughProperty("HDamLb")]
	[CompilerGenerated]
	private Label _label_40;

	[AccessedThroughProperty("bDam")]
	[CompilerGenerated]
	private TextBox _Bdam;

	[AccessedThroughProperty("BDamLb")]
	[CompilerGenerated]
	private Label _label_41;

	[CompilerGenerated]
	[AccessedThroughProperty("TLBVMC")]
	private ComboBox _combobox_42;

	[AccessedThroughProperty("TlVeMCLb")]
	[CompilerGenerated]
	private Label _label_43;

	[CompilerGenerated]
	[AccessedThroughProperty("hduoisan1")]
	private TextBox _textbox_44;

	[AccessedThroughProperty("hsan2")]
	[CompilerGenerated]
	private TextBox _textbox_45;

	[CompilerGenerated]
	[AccessedThroughProperty("hsan1")]
	private TextBox _textbox_46;

	[CompilerGenerated]
	[AccessedThroughProperty("h1")]
	private TextBox _H1;

	[AccessedThroughProperty("hduoisan2")]
	[CompilerGenerated]
	private TextBox _textbox_47;

	[AccessedThroughProperty("b2")]
	[CompilerGenerated]
	private TextBox _B2;

	[CompilerGenerated]
	[AccessedThroughProperty("b1")]
	private TextBox _B1;

	[AccessedThroughProperty("h2")]
	[CompilerGenerated]
	private TextBox _H2;

	[CompilerGenerated]
	[AccessedThroughProperty("hduoisanphai2")]
	private TextBox _textbox_48;

	[AccessedThroughProperty("hsanphai2")]
	[CompilerGenerated]
	private TextBox _textbox_49;

	[AccessedThroughProperty("hduoisanphai1")]
	[CompilerGenerated]
	private TextBox _textbox_50;

	[AccessedThroughProperty("hsanphai1")]
	[CompilerGenerated]
	private TextBox _textbox_51;

	[AccessedThroughProperty("daiC")]
	[CompilerGenerated]
	private TextBox _Daic;

	[AccessedThroughProperty("DaiCLb")]
	[CompilerGenerated]
	private Label _Daiclb;

	[CompilerGenerated]
	[AccessedThroughProperty("daiU")]
	private TextBox _Daiu;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiULb")]
	private Label _Daiulb;

	[CompilerGenerated]
	[AccessedThroughProperty("daivuong")]
	private TextBox _Daivuong;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiVuongLb")]
	private Label _label_52;

	[CompilerGenerated]
	[AccessedThroughProperty("BCotPhaiLb")]
	private Label _Bcotphailb;

	[CompilerGenerated]
	[AccessedThroughProperty("LCotPhai")]
	private TextBox _Lcotphai;

	[CompilerGenerated]
	[AccessedThroughProperty("BCotTraiLb")]
	private Label _Bcottrailb;

	[CompilerGenerated]
	[AccessedThroughProperty("LCotTrai")]
	private TextBox _Lcottrai;

	[AccessedThroughProperty("LayDuLieubtn")]
	[CompilerGenerated]
	private Button _Laydulieubtn;

	[CompilerGenerated]
	[AccessedThroughProperty("ResetBtn")]
	private Button _button_53;

	[CompilerGenerated]
	[AccessedThroughProperty("HienSoLuongDaiCb")]
	private CheckBox _checkbox_54;

	[CompilerGenerated]
	[AccessedThroughProperty("Ten_ck")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_55;

	[CompilerGenerated]
	[AccessedThroughProperty("L_dam")]
	private DataGridViewTextBoxColumn _LDam;

	[CompilerGenerated]
	[AccessedThroughProperty("so_luong")]
	private DataGridViewTextBoxColumn _SoLuong;

	private PreviewCanvas _previewcanvas_56;

	private double doubleParam;

	private Point pointParam;

	private Point pointParam;

	public bool boolParam;

	private bool boolParam;

	private int intParam;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	private static GetStatic_1 _appform862_57;

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

	internal virtual FlowLayoutPanel FlowLayoutPanel_0
	{
		[CompilerGenerated]
		get
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

	internal virtual Panel Panel_2
	{
		[CompilerGenerated]
		get
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

	internal virtual Panel Panel_3
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel Panel_4
	{
		[CompilerGenerated]
		get
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

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, FormClosingEventArgs e)
	{
	}

	private void voidParam()
	{
	}

	public void voidParam()
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

	public void voidParam(bool boolParam = false)
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
					_goto_58:
					switch (num3)
					{
					default:
						while (num2 == 9)
						{
							AppClass_969.smethod_3();
							num3 = 0;
							if (AppClass_031.class730_0.int_98 == 0)
							{
								continue;
							}
							goto _goto_58;
						}
						goto _goto_59;
					case 2:
						AppClass_960.smethod_13();
						break;
					case 1:
						break;
					case 0:
						return;
					}
					goto _goto_60;
					continue;
					_goto_59:
					break;
				}
				continue;
				_goto_60:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_3 == 0)
			{
				num = 2;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appform862Param()
	{
		return null;
	}
}
