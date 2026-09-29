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

	[AccessedThroughProperty("GroupView")]
	[CompilerGenerated]
	private GroupBox _Groupview;

	[AccessedThroughProperty("caoTrinhTren")]
	[CompilerGenerated]
	private TextBox _textbox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("caoTrinhDuoi")]
	private TextBox _Caotrinhduoi;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel2")]
	private Panel _panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("tbMau")]
	private TextBox _Tbmau;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	[CompilerGenerated]
	private FlowLayoutPanel _flowlayoutpanel_3;

	[CompilerGenerated]
	[AccessedThroughProperty("ThongSoChungGrb")]
	private GroupBox _groupbox_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel4")]
	private Panel _panel_5;

	[CompilerGenerated]
	[AccessedThroughProperty("CatThepCb")]
	private CheckBox _Catthepcb;

	[AccessedThroughProperty("TLBVMC")]
	[CompilerGenerated]
	private ComboBox _combobox_6;

	[AccessedThroughProperty("TLBVDam")]
	[CompilerGenerated]
	private ComboBox _combobox_7;

	[AccessedThroughProperty("TenDamLb")]
	[CompilerGenerated]
	private Label _Tendamlb;

	[AccessedThroughProperty("GCDLop1Lb")]
	[CompilerGenerated]
	private Label _label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD1")]
	private TextBox _textbox_9;

	[AccessedThroughProperty("GCTLop1Lb")]
	[CompilerGenerated]
	private Label _label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT1")]
	private TextBox _textbox_11;

	[CompilerGenerated]
	[AccessedThroughProperty("TLBanVeDamLb")]
	private Label _Tlbanvedamlb;

	[AccessedThroughProperty("tenDam")]
	[CompilerGenerated]
	private TextBox _Tendam;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepGCTLb")]
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

	[AccessedThroughProperty("SoCKLb")]
	[CompilerGenerated]
	private Label _label_15;

	[AccessedThroughProperty("hDam")]
	[CompilerGenerated]
	private TextBox _Hdam;

	[CompilerGenerated]
	[AccessedThroughProperty("HDamLb")]
	private Label _label_16;

	[AccessedThroughProperty("bDam")]
	[CompilerGenerated]
	private TextBox _Bdam;

	[CompilerGenerated]
	[AccessedThroughProperty("GCDLop3Lb")]
	private Label _label_17;

	[AccessedThroughProperty("BDamLb")]
	[CompilerGenerated]
	private Label _label_18;

	[AccessedThroughProperty("GCDLop2Lb")]
	[CompilerGenerated]
	private Label _label_19;

	[CompilerGenerated]
	[AccessedThroughProperty("thepCLT")]
	private TextBox _textbox_20;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD3")]
	private TextBox _textbox_21;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepCLTLb")]
	private Label _label_22;

	[AccessedThroughProperty("thepGCD2")]
	[CompilerGenerated]
	private TextBox _textbox_23;

	[AccessedThroughProperty("thepCLD")]
	[CompilerGenerated]
	private TextBox _textbox_24;

	[AccessedThroughProperty("ThepCLDLb")]
	[CompilerGenerated]
	private Label _label_25;

	[CompilerGenerated]
	[AccessedThroughProperty("GCTLop2Lb")]
	private Label _label_26;

	[CompilerGenerated]
	[AccessedThroughProperty("GCTLop3Lb")]
	private Label _label_27;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT3")]
	private TextBox _textbox_28;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT2")]
	private TextBox _textbox_29;

	[AccessedThroughProperty("Panel3")]
	[CompilerGenerated]
	private Panel _panel_30;

	[AccessedThroughProperty("KcDGCLb")]
	[CompilerGenerated]
	private Label _label_31;

	[CompilerGenerated]
	[AccessedThroughProperty("aGiaCuong")]
	private TextBox _Agiacuong;

	[CompilerGenerated]
	[AccessedThroughProperty("GiongDaiNgoaiRb")]
	private RadioButton _radiobutton_32;

	[CompilerGenerated]
	[AccessedThroughProperty("BoTriDeuVoiRb")]
	private RadioButton _radiobutton_33;

	[CompilerGenerated]
	[AccessedThroughProperty("NeoThepVungKeoLb")]
	private Label _label_34;

	[CompilerGenerated]
	[AccessedThroughProperty("SoLopCotGiaLb")]
	private Label _label_35;

	[AccessedThroughProperty("neoKeo")]
	[CompilerGenerated]
	private TextBox _Neokeo;

	[CompilerGenerated]
	[AccessedThroughProperty("nCotGia")]
	private TextBox _Ncotgia;

	[AccessedThroughProperty("neoNen")]
	[CompilerGenerated]
	private TextBox _Neonen;

	[CompilerGenerated]
	[AccessedThroughProperty("DKCotGiaLb")]
	private Label _Dkcotgialb;

	[CompilerGenerated]
	[AccessedThroughProperty("NeoThepVungNenLb")]
	private Label _label_36;

	[AccessedThroughProperty("aDaiNhip")]
	[CompilerGenerated]
	private TextBox _Adainhip;

	[CompilerGenerated]
	[AccessedThroughProperty("fDai")]
	private TextBox _Fdai;

	[CompilerGenerated]
	[AccessedThroughProperty("LNhip")]
	private TextBox _textbox_37;

	[AccessedThroughProperty("DKDaiLb")]
	[CompilerGenerated]
	private Label _Dkdailb;

	[CompilerGenerated]
	[AccessedThroughProperty("abv")]
	private TextBox _Abv;

	[CompilerGenerated]
	[AccessedThroughProperty("CatThepGCNhipLb")]
	private Label _label_38;

	[AccessedThroughProperty("ABVThepLb")]
	[CompilerGenerated]
	private Label _label_39;

	[AccessedThroughProperty("aDaiGoi")]
	[CompilerGenerated]
	private TextBox _Adaigoi;

	[CompilerGenerated]
	[AccessedThroughProperty("CatThepGCGoiLb")]
	private Label _label_40;

	[CompilerGenerated]
	[AccessedThroughProperty("GanGoiLb")]
	private Label _Gangoilb;

	[CompilerGenerated]
	[AccessedThroughProperty("LGoi")]
	private TextBox _Lgoi;

	[CompilerGenerated]
	[AccessedThroughProperty("fCotGia")]
	private TextBox _Fcotgia;

	[AccessedThroughProperty("GiuaNhipLb")]
	[CompilerGenerated]
	private Label _Giuanhiplb;

	[CompilerGenerated]
	[AccessedThroughProperty("Label20")]
	private Label _label_41;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_cotL")]
	private Label _PhiCotl;

	[AccessedThroughProperty("VeDamCongBtn")]
	[CompilerGenerated]
	private Button _button_42;

	[CompilerGenerated]
	[AccessedThroughProperty("CancelBtn")]
	private Button _button_43;

	[AccessedThroughProperty("LayDuLieuBtn")]
	[CompilerGenerated]
	private Button _Laydulieubtn;

	[CompilerGenerated]
	[AccessedThroughProperty("VeDamCongShopBtn")]
	private Button _button_44;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel _panel_45;

	[CompilerGenerated]
	[AccessedThroughProperty("ThongSoKhacGrb")]
	private GroupBox _groupbox_46;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepDaiTaiNutLb")]
	private Label _label_47;

	[CompilerGenerated]
	[AccessedThroughProperty("thepDaiNut")]
	private TextBox _Thepdainut;

	[AccessedThroughProperty("BCotPhaiLb")]
	[CompilerGenerated]
	private Label _Bcotphailb;

	[CompilerGenerated]
	[AccessedThroughProperty("LCotPhai")]
	private TextBox _Lcotphai;

	[AccessedThroughProperty("BCotTraiLb")]
	[CompilerGenerated]
	private Label _Bcottrailb;

	[AccessedThroughProperty("LCotTrai")]
	[CompilerGenerated]
	private TextBox _Lcottrai;

	[AccessedThroughProperty("daivuong")]
	[CompilerGenerated]
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

	[CompilerGenerated]
	[AccessedThroughProperty("daiU")]
	private TextBox _Daiu;

	[AccessedThroughProperty("DaiULb")]
	[CompilerGenerated]
	private Label _Daiulb;

	private PreviewCanvas _previewcanvas_49;

	private double doubleParam;

	private Point pointParam;

	private Point pointParam;

	private List<diem> _listDiem_50;

	public bool boolParam;

	private bool boolParam;

	private bool boolParam;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	private static GetStatic_1 _appform890_51;

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

	private void voidParam()
	{
	}

	private void voidParam(object sender, FormClosingEventArgs e)
	{
	}

	public void voidParam()
	{
	}

	private void voidParam(object sender, PaintEventArgs e)
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
		int num = 1;
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
						AppClass_960.smethod_13();
						num3 = 0;
						if (AppClass_031.class730_0.int_2 == 0)
						{
							continue;
						}
						return;
					case 0:
						goto _goto_52;
					case 2:
						return;
					}
					switch (num2)
					{
					case 9:
						AppClass_969.smethod_3();
						num3 = 6;
						if (AppClass_031.class730_0.int_112 == 0)
						{
							continue;
						}
						return;
					default:
						return;
					case 990:
						break;
					}
					break;
				}
				continue;
				_goto_52:
				break;
			}
			AppClass_960.smethod_15();
			num = 2;
			if (AppClass_031.class730_0.int_106 == 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appform890Param()
	{
		return null;
	}
}
