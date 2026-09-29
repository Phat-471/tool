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

	[AccessedThroughProperty("GroupView")]
	[CompilerGenerated]
	private GroupBox _Groupview;

	[CompilerGenerated]
	[AccessedThroughProperty("caoTrinhTren")]
	private TextBox _textbox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("caoTrinhDuoi")]
	private TextBox _Caotrinhduoi;

	[AccessedThroughProperty("Panel2")]
	[CompilerGenerated]
	private Panel _panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("tbMau")]
	private TextBox _Tbmau;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	[CompilerGenerated]
	private FlowLayoutPanel _flowlayoutpanel_3;

	[AccessedThroughProperty("ThongSoChungTb")]
	[CompilerGenerated]
	private GroupBox _groupbox_4;

	[AccessedThroughProperty("Panel4")]
	[CompilerGenerated]
	private Panel _panel_5;

	[AccessedThroughProperty("CatThepCb")]
	[CompilerGenerated]
	private CheckBox _Catthepcb;

	[AccessedThroughProperty("TLBVMC")]
	[CompilerGenerated]
	private ComboBox _combobox_6;

	[AccessedThroughProperty("TLBVDam")]
	[CompilerGenerated]
	private ComboBox _combobox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("TenDamLb")]
	private Label _Tendamlb;

	[AccessedThroughProperty("Lop1DuoiLb")]
	[CompilerGenerated]
	private Label _label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD1")]
	private TextBox _textbox_9;

	[AccessedThroughProperty("Lop1TrenLb")]
	[CompilerGenerated]
	private Label _label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT1")]
	private TextBox _textbox_11;

	[AccessedThroughProperty("TLBanVeDamLb")]
	[CompilerGenerated]
	private Label _Tlbanvedamlb;

	[AccessedThroughProperty("tenDam")]
	[CompilerGenerated]
	private TextBox _Tendam;

	[AccessedThroughProperty("ThepGCTLb")]
	[CompilerGenerated]
	private Label _label_12;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepGCDLb")]
	private Label _label_13;

	[CompilerGenerated]
	[AccessedThroughProperty("soCauKien")]
	private TextBox _Socaukien;

	[AccessedThroughProperty("TLBanVeMCLb")]
	[CompilerGenerated]
	private Label _label_14;

	[CompilerGenerated]
	[AccessedThroughProperty("SoCauKienLb")]
	private Label _Socaukienlb;

	[AccessedThroughProperty("hDam")]
	[CompilerGenerated]
	private TextBox _Hdam;

	[CompilerGenerated]
	[AccessedThroughProperty("HDamLb")]
	private Label _label_15;

	[CompilerGenerated]
	[AccessedThroughProperty("bDam")]
	private TextBox _Bdam;

	[CompilerGenerated]
	[AccessedThroughProperty("Lop3DuoiLb")]
	private Label _label_16;

	[CompilerGenerated]
	[AccessedThroughProperty("BDamLb")]
	private Label _label_17;

	[AccessedThroughProperty("Lop2DuoiLb")]
	[CompilerGenerated]
	private Label _label_18;

	[CompilerGenerated]
	[AccessedThroughProperty("thepCLT")]
	private TextBox _textbox_19;

	[AccessedThroughProperty("thepGCD3")]
	[CompilerGenerated]
	private TextBox _textbox_20;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepCLTLb")]
	private Label _label_21;

	[AccessedThroughProperty("thepGCD2")]
	[CompilerGenerated]
	private TextBox _textbox_22;

	[AccessedThroughProperty("thepCLD")]
	[CompilerGenerated]
	private TextBox _textbox_23;

	[AccessedThroughProperty("ThepCLDLb")]
	[CompilerGenerated]
	private Label _label_24;

	[CompilerGenerated]
	[AccessedThroughProperty("Lop2TrenLb")]
	private Label _label_25;

	[AccessedThroughProperty("Lop3TrenLb")]
	[CompilerGenerated]
	private Label _label_26;

	[AccessedThroughProperty("thepGCT3")]
	[CompilerGenerated]
	private TextBox _textbox_27;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT2")]
	private TextBox _textbox_28;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	private Panel _panel_29;

	[AccessedThroughProperty("KCDaiGCLb")]
	[CompilerGenerated]
	private Label _label_30;

	[CompilerGenerated]
	[AccessedThroughProperty("aGiaCuong")]
	private TextBox _Agiacuong;

	[AccessedThroughProperty("GiongDaiNgoaiRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_31;

	[CompilerGenerated]
	[AccessedThroughProperty("BoTriDeuVoiRb")]
	private RadioButton _radiobutton_32;

	[AccessedThroughProperty("NeoThepVungKeoLb")]
	[CompilerGenerated]
	private Label _label_33;

	[CompilerGenerated]
	[AccessedThroughProperty("SoLopCotGiaLb")]
	private Label _label_34;

	[AccessedThroughProperty("neoKeo")]
	[CompilerGenerated]
	private TextBox _Neokeo;

	[AccessedThroughProperty("nCotGia")]
	[CompilerGenerated]
	private TextBox _Ncotgia;

	[CompilerGenerated]
	[AccessedThroughProperty("neoNen")]
	private TextBox _Neonen;

	[CompilerGenerated]
	[AccessedThroughProperty("DKCotGiaLb")]
	private Label _Dkcotgialb;

	[CompilerGenerated]
	[AccessedThroughProperty("NeoThepVungNenLb")]
	private Label _label_35;

	[AccessedThroughProperty("aDaiNhip")]
	[CompilerGenerated]
	private TextBox _Adainhip;

	[CompilerGenerated]
	[AccessedThroughProperty("fDai")]
	private TextBox _Fdai;

	[AccessedThroughProperty("LNhip")]
	[CompilerGenerated]
	private TextBox _textbox_36;

	[AccessedThroughProperty("DKDaiLb")]
	[CompilerGenerated]
	private Label _Dkdailb;

	[AccessedThroughProperty("abv")]
	[CompilerGenerated]
	private TextBox _Abv;

	[AccessedThroughProperty("CatThepGCNhipLb")]
	[CompilerGenerated]
	private Label _label_37;

	[CompilerGenerated]
	[AccessedThroughProperty("ABVThepLb")]
	private Label _label_38;

	[CompilerGenerated]
	[AccessedThroughProperty("aDaiGoi")]
	private TextBox _Adaigoi;

	[AccessedThroughProperty("CatThepGCGoiLb")]
	[CompilerGenerated]
	private Label _label_39;

	[AccessedThroughProperty("GanGoiLb")]
	[CompilerGenerated]
	private Label _Gangoilb;

	[CompilerGenerated]
	[AccessedThroughProperty("LGoi")]
	private TextBox _Lgoi;

	[CompilerGenerated]
	[AccessedThroughProperty("fCotGia")]
	private TextBox _Fcotgia;

	[CompilerGenerated]
	[AccessedThroughProperty("GiuaNhipLb")]
	private Label _Giuanhiplb;

	[CompilerGenerated]
	[AccessedThroughProperty("Label20")]
	private Label _label_40;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_cotL")]
	private Label _PhiCotl;

	[AccessedThroughProperty("VeDamXienBtn")]
	[CompilerGenerated]
	private Button _button_41;

	[AccessedThroughProperty("CancelBtn")]
	[CompilerGenerated]
	private Button _button_42;

	[AccessedThroughProperty("ThongSoKhacLb")]
	[CompilerGenerated]
	private GroupBox _groupbox_43;

	[AccessedThroughProperty("ThepDaiTaiNutLb")]
	[CompilerGenerated]
	private Label _label_44;

	[CompilerGenerated]
	[AccessedThroughProperty("thepDaiNut")]
	private TextBox _Thepdainut;

	[CompilerGenerated]
	[AccessedThroughProperty("BCotPhaiLb")]
	private Label _Bcotphailb;

	[CompilerGenerated]
	[AccessedThroughProperty("LCotPhai")]
	private TextBox _Lcotphai;

	[AccessedThroughProperty("BCotTraiLb")]
	[CompilerGenerated]
	private Label _Bcottrailb;

	[CompilerGenerated]
	[AccessedThroughProperty("LCotTrai")]
	private TextBox _Lcottrai;

	[AccessedThroughProperty("LayDuLieuBtn")]
	[CompilerGenerated]
	private Button _Laydulieubtn;

	[AccessedThroughProperty("VeDamXienShopBtn")]
	[CompilerGenerated]
	private Button _button_45;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _panel_46;

	[AccessedThroughProperty("Panel5")]
	[CompilerGenerated]
	private Panel _panel_47;

	[CompilerGenerated]
	[AccessedThroughProperty("daivuong")]
	private TextBox _Daivuong;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiVuongLb")]
	private Label _label_48;

	[CompilerGenerated]
	[AccessedThroughProperty("daiC")]
	private TextBox _Daic;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiCLb")]
	private Label _Daiclb;

	[AccessedThroughProperty("daiU")]
	[CompilerGenerated]
	private TextBox _Daiu;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiULb")]
	private Label _Daiulb;

	[AccessedThroughProperty("XMPBtn")]
	[CompilerGenerated]
	private Button _button_49;

	private PreviewCanvas _previewcanvas_50;

	private double doubleParam;

	private Point pointParam;

	private Point pointParam;

	public bool boolParam;

	private bool boolParam;

	private string _string_51;

	private string _string_52;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	internal static GetStatic_1 _appform824_53;

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

	private void voidParam(object sender, EventArgs e)
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
						if (AppClass_031.class730_0.int_59 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							goto _goto_54;
						}
						AppClass_960.smethod_15();
						num3 = 6;
						if (AppClass_031.class730_0.int_34 != 0)
						{
							continue;
						}
						goto case 0;
					case 2:
						break;
					case 1:
						return;
					}
					goto _goto_55;
					continue;
					_goto_54:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				_goto_55:
				break;
			}
			AppClass_960.smethod_13();
			num = 9;
			if (AppClass_031.class730_0.int_56 != 0)
			{
				num = 4;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appform824Param()
	{
		return null;
	}
}
