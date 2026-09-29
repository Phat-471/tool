using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[DesignerGenerated]
public class view_dam_cong : Form
{
	private IContainer _icontainer_2;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupView")]
	private GroupBox _Groupview;

	[CompilerGenerated]
	[AccessedThroughProperty("caoTrinhTren")]
	private TextBox _textbox_3;

	[AccessedThroughProperty("caoTrinhDuoi")]
	[CompilerGenerated]
	private TextBox _Caotrinhduoi;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel2")]
	private Panel _panel_4;

	[CompilerGenerated]
	[AccessedThroughProperty("tbMau")]
	private TextBox _Tbmau;

	[CompilerGenerated]
	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _flowlayoutpanel_5;

	[CompilerGenerated]
	[AccessedThroughProperty("ThongSoChungGrb")]
	private GroupBox _groupbox_6;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel4")]
	private Panel _panel_7;

	[CompilerGenerated]
	[AccessedThroughProperty("CatThepCb")]
	private CheckBox _Catthepcb;

	[CompilerGenerated]
	[AccessedThroughProperty("TLBVMC")]
	private ComboBox _combobox_8;

	[AccessedThroughProperty("TLBVDam")]
	[CompilerGenerated]
	private ComboBox _combobox_9;

	[CompilerGenerated]
	[AccessedThroughProperty("TenDamLb")]
	private Label _Tendamlb;

	[CompilerGenerated]
	[AccessedThroughProperty("GCDLop1Lb")]
	private Label _label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD1")]
	private TextBox _textbox_11;

	[CompilerGenerated]
	[AccessedThroughProperty("GCTLop1Lb")]
	private Label _label_12;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCT1")]
	private TextBox _textbox_13;

	[CompilerGenerated]
	[AccessedThroughProperty("TLBanVeDamLb")]
	private Label _Tlbanvedamlb;

	[CompilerGenerated]
	[AccessedThroughProperty("tenDam")]
	private TextBox _Tendam;

	[AccessedThroughProperty("ThepGCTLb")]
	[CompilerGenerated]
	private Label _label_14;

	[AccessedThroughProperty("ThepGCDLb")]
	[CompilerGenerated]
	private Label _label_15;

	[AccessedThroughProperty("soCauKien")]
	[CompilerGenerated]
	private TextBox _Socaukien;

	[CompilerGenerated]
	[AccessedThroughProperty("TLBanVeMCLb")]
	private Label _label_16;

	[CompilerGenerated]
	[AccessedThroughProperty("SoCKLb")]
	private Label _label_17;

	[CompilerGenerated]
	[AccessedThroughProperty("hDam")]
	private TextBox _Hdam;

	[AccessedThroughProperty("HDamLb")]
	[CompilerGenerated]
	private Label _label_18;

	[AccessedThroughProperty("bDam")]
	[CompilerGenerated]
	private TextBox _Bdam;

	[CompilerGenerated]
	[AccessedThroughProperty("GCDLop3Lb")]
	private Label _label_19;

	[CompilerGenerated]
	[AccessedThroughProperty("BDamLb")]
	private Label _label_20;

	[CompilerGenerated]
	[AccessedThroughProperty("GCDLop2Lb")]
	private Label _label_21;

	[AccessedThroughProperty("thepCLT")]
	[CompilerGenerated]
	private TextBox _textbox_22;

	[AccessedThroughProperty("thepGCD3")]
	[CompilerGenerated]
	private TextBox _textbox_23;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepCLTLb")]
	private Label _label_24;

	[CompilerGenerated]
	[AccessedThroughProperty("thepGCD2")]
	private TextBox _textbox_25;

	[CompilerGenerated]
	[AccessedThroughProperty("thepCLD")]
	private TextBox _textbox_26;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepCLDLb")]
	private Label _label_27;

	[AccessedThroughProperty("GCTLop2Lb")]
	[CompilerGenerated]
	private Label _label_28;

	[AccessedThroughProperty("GCTLop3Lb")]
	[CompilerGenerated]
	private Label _label_29;

	[AccessedThroughProperty("thepGCT3")]
	[CompilerGenerated]
	private TextBox _textbox_30;

	[AccessedThroughProperty("thepGCT2")]
	[CompilerGenerated]
	private TextBox _textbox_31;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	private Panel _panel_32;

	[AccessedThroughProperty("KcDGCLb")]
	[CompilerGenerated]
	private Label _label_33;

	[AccessedThroughProperty("aGiaCuong")]
	[CompilerGenerated]
	private TextBox _Agiacuong;

	[AccessedThroughProperty("GiongDaiNgoaiRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_34;

	[AccessedThroughProperty("BoTriDeuVoiRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_35;

	[AccessedThroughProperty("NeoThepVungKeoLb")]
	[CompilerGenerated]
	private Label _label_36;

	[AccessedThroughProperty("SoLopCotGiaLb")]
	[CompilerGenerated]
	private Label _label_37;

	[AccessedThroughProperty("neoKeo")]
	[CompilerGenerated]
	private TextBox _Neokeo;

	[AccessedThroughProperty("nCotGia")]
	[CompilerGenerated]
	private TextBox _Ncotgia;

	[AccessedThroughProperty("neoNen")]
	[CompilerGenerated]
	private TextBox _Neonen;

	[AccessedThroughProperty("DKCotGiaLb")]
	[CompilerGenerated]
	private Label _Dkcotgialb;

	[AccessedThroughProperty("NeoThepVungNenLb")]
	[CompilerGenerated]
	private Label _label_38;

	[AccessedThroughProperty("aDaiNhip")]
	[CompilerGenerated]
	private TextBox _Adainhip;

	[CompilerGenerated]
	[AccessedThroughProperty("fDai")]
	private TextBox _Fdai;

	[CompilerGenerated]
	[AccessedThroughProperty("LNhip")]
	private TextBox _textbox_39;

	[CompilerGenerated]
	[AccessedThroughProperty("DKDaiLb")]
	private Label _Dkdailb;

	[AccessedThroughProperty("abv")]
	[CompilerGenerated]
	private TextBox _Abv;

	[CompilerGenerated]
	[AccessedThroughProperty("CatThepGCNhipLb")]
	private Label _label_40;

	[CompilerGenerated]
	[AccessedThroughProperty("ABVThepLb")]
	private Label _label_41;

	[CompilerGenerated]
	[AccessedThroughProperty("aDaiGoi")]
	private TextBox _Adaigoi;

	[AccessedThroughProperty("CatThepGCGoiLb")]
	[CompilerGenerated]
	private Label _label_42;

	[AccessedThroughProperty("GanGoiLb")]
	[CompilerGenerated]
	private Label _Gangoilb;

	[AccessedThroughProperty("LGoi")]
	[CompilerGenerated]
	private TextBox _Lgoi;

	[AccessedThroughProperty("fCotGia")]
	[CompilerGenerated]
	private TextBox _Fcotgia;

	[CompilerGenerated]
	[AccessedThroughProperty("GiuaNhipLb")]
	private Label _Giuanhiplb;

	[CompilerGenerated]
	[AccessedThroughProperty("Label20")]
	private Label _label_43;

	[AccessedThroughProperty("phi_cotL")]
	[CompilerGenerated]
	private Label _PhiCotl;

	[AccessedThroughProperty("VeDamCongBtn")]
	[CompilerGenerated]
	private Button _button_44;

	[CompilerGenerated]
	[AccessedThroughProperty("CancelBtn")]
	private Button _button_45;

	[CompilerGenerated]
	[AccessedThroughProperty("LayDuLieuBtn")]
	private Button _Laydulieubtn;

	[AccessedThroughProperty("VeDamCongShopBtn")]
	[CompilerGenerated]
	private Button _button_46;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _panel_47;

	[CompilerGenerated]
	[AccessedThroughProperty("ThongSoKhacGrb")]
	private GroupBox _groupbox_48;

	[AccessedThroughProperty("ThepDaiTaiNutLb")]
	[CompilerGenerated]
	private Label _label_49;

	[AccessedThroughProperty("thepDaiNut")]
	[CompilerGenerated]
	private TextBox _Thepdainut;

	[AccessedThroughProperty("BCotPhaiLb")]
	[CompilerGenerated]
	private Label _Bcotphailb;

	[AccessedThroughProperty("LCotPhai")]
	[CompilerGenerated]
	private TextBox _Lcotphai;

	[AccessedThroughProperty("BCotTraiLb")]
	[CompilerGenerated]
	private Label _Bcottrailb;

	[CompilerGenerated]
	[AccessedThroughProperty("LCotTrai")]
	private TextBox _Lcottrai;

	[CompilerGenerated]
	[AccessedThroughProperty("daivuong")]
	private TextBox _Daivuong;

	[AccessedThroughProperty("DaiVuongLb")]
	[CompilerGenerated]
	private Label _label_50;

	[AccessedThroughProperty("daiC")]
	[CompilerGenerated]
	private TextBox _Daic;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiCLb")]
	private Label _Daiclb;

	[CompilerGenerated]
	[AccessedThroughProperty("daiU")]
	private TextBox _Daiu;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiULb")]
	private Label _Daiulb;

	private PreviewCanvas _previewcanvas_51;

	private double _double_52;

	private Point _point_53;

	private Point _point_54;

	private List<diem> _listDiem_55;

	public bool da_hien_form;

	private bool _bool_56;

	private bool _bool_57;

	private bool _bool_58;

	private Point _point_59;

	private Point _point_60;

	private static view_dam_cong _viewDamCong_61;

	internal virtual GroupBox GroupView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox caoTrinhTren
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox caoTrinhDuoi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel Panel2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox tbMau
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual GroupBox ThongSoChungGrb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel Panel4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CatThepCb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox TLBVMC
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox TLBVDam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label TenDamLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GCDLop1Lb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepGCD1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GCTLop1Lb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepGCT1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label TLBanVeDamLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox tenDam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label ThepGCTLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label ThepGCDLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox soCauKien
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label TLBanVeMCLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label SoCKLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox hDam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label HDamLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox bDam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GCDLop3Lb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label BDamLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GCDLop2Lb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepCLT
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepGCD3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label ThepCLTLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepGCD2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepCLD
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label ThepCLDLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GCTLop2Lb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GCTLop3Lb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepGCT3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepGCT2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel Panel3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label KcDGCLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox aGiaCuong
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RadioButton GiongDaiNgoaiRb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RadioButton BoTriDeuVoiRb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label NeoThepVungKeoLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label SoLopCotGiaLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox neoKeo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox nCotGia
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox neoNen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label DKCotGiaLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label NeoThepVungNenLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox aDaiNhip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox fDai
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox LNhip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label DKDaiLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox abv
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label CatThepGCNhipLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label ABVThepLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox aDaiGoi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label CatThepGCGoiLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GanGoiLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox LGoi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox fCotGia
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label GiuaNhipLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label20
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label phi_cotL
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button VeDamCongBtn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button CancelBtn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button LayDuLieuBtn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button VeDamCongShopBtn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel Panel1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual GroupBox ThongSoKhacGrb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label ThepDaiTaiNutLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox thepDaiNut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label BCotPhaiLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox LCotPhai
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label BCotTraiLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox LCotTrai
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox daivuong
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label DaiVuongLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox daiC
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label DaiCLb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox daiU
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label DaiULb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public view_dam_cong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	private void GetDebuggerstepthroughPrivateVoid_1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_2(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_4(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ve_dam_cong()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_5(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_6(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_7(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_8(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_9(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void doi_du_lieu(bool df = false)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_10(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_11(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_12(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_13(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_14(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_15(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_16(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_17(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_18(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_19(object P_0, EventArgs P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static view_dam_cong()
	{
		AppClass_016.uQ4DbMFRj7Q();
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
					case 2:
						return;
					case 1:
						AppClass_016.TqZDb19vgxf();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_340b71ceed4540bc80b6cacfb7d840cf != 0)
						{
							num3 = 2;
						}
						continue;
					case 0:
						goto _goto_62;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						AppClass_054.IveTMUdyS5E();
						num3 = 6;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2fd7730740d245ffb855794cabb17218 != 0)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				continue;
				_goto_62:
				break;
			}
			AppClass_016.QB3DbWPnHbY();
			num = 2;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3d856b94665044e6b2ba303819a86373 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_20()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static view_dam_cong GetViewDamCong_21()
	{
		return null;
	}
}
