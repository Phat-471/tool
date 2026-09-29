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

	[AccessedThroughProperty("BindingSource1")]
	[CompilerGenerated]
	private BindingSource _bindingsource_1;

	[AccessedThroughProperty("Y1")]
	[CompilerGenerated]
	private TextBox _Y1;

	[AccessedThroughProperty("X2")]
	[CompilerGenerated]
	private TextBox _X2;

	[AccessedThroughProperty("Z4")]
	[CompilerGenerated]
	private TextBox _Z4;

	[CompilerGenerated]
	[AccessedThroughProperty("VeMongBtn")]
	private Button _button_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Ct")]
	private TextBox _Ct;

	[AccessedThroughProperty("C1")]
	[CompilerGenerated]
	private TextBox _C1;

	[AccessedThroughProperty("X1")]
	[CompilerGenerated]
	private TextBox _X1;

	[AccessedThroughProperty("X3")]
	[CompilerGenerated]
	private TextBox _X3;

	[AccessedThroughProperty("Y2")]
	[CompilerGenerated]
	private TextBox _Y2;

	[AccessedThroughProperty("Y3")]
	[CompilerGenerated]
	private TextBox _Y3;

	[AccessedThroughProperty("Z1")]
	[CompilerGenerated]
	private TextBox _Z1;

	[AccessedThroughProperty("Z2")]
	[CompilerGenerated]
	private TextBox _Z2;

	[CompilerGenerated]
	[AccessedThroughProperty("Thep_cot_X")]
	private TextBox _ThepCotX;

	[CompilerGenerated]
	[AccessedThroughProperty("SoThanhPhuongXLb")]
	private Label _label_3;

	[AccessedThroughProperty("Thep_mong_X")]
	[CompilerGenerated]
	private TextBox _ThepMongX;

	[CompilerGenerated]
	[AccessedThroughProperty("Thep_mong_Y")]
	private TextBox _ThepMongY;

	[AccessedThroughProperty("CanceBtn")]
	[CompilerGenerated]
	private Button _Cancebtn;

	[CompilerGenerated]
	[AccessedThroughProperty("Thep_cot_Y")]
	private TextBox _ThepCotY;

	[AccessedThroughProperty("SoThanhPhuongYLb")]
	[CompilerGenerated]
	private Label _label_4;

	[AccessedThroughProperty("DuLieuThepCotGrb")]
	[CompilerGenerated]
	private GroupBox _groupbox_5;

	[CompilerGenerated]
	[AccessedThroughProperty("DkLb")]
	private Label _label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_cot")]
	private TextBox _PhiCot;

	[CompilerGenerated]
	[AccessedThroughProperty("dai_cot")]
	private TextBox _DaiCot;

	[CompilerGenerated]
	[AccessedThroughProperty("ThepDaiLb")]
	private Label _Thepdailb;

	[AccessedThroughProperty("C2")]
	[CompilerGenerated]
	private TextBox _C2;

	[AccessedThroughProperty("bt_lot")]
	[CompilerGenerated]
	private TextBox _textbox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Z3")]
	private TextBox _Z3;

	[CompilerGenerated]
	[AccessedThroughProperty("Ten_mong")]
	private TextBox _TenMong;

	[AccessedThroughProperty("TenMongLb")]
	[CompilerGenerated]
	private Label _label_8;

	[AccessedThroughProperty("DoanBeMongThepMongGrb")]
	[CompilerGenerated]
	private GroupBox _groupbox_9;

	[AccessedThroughProperty("moc_duoi")]
	[CompilerGenerated]
	private TextBox _MocDuoi;

	[CompilerGenerated]
	[AccessedThroughProperty("BenDuoiLb")]
	private Label _Benduoilb;

	[AccessedThroughProperty("BenTraiLb")]
	[CompilerGenerated]
	private Label _Bentrailb;

	[CompilerGenerated]
	[AccessedThroughProperty("moc_trai")]
	private TextBox _MocTrai;

	[CompilerGenerated]
	[AccessedThroughProperty("moc_tren")]
	private TextBox _MocTren;

	[AccessedThroughProperty("BenPhaiLb")]
	[CompilerGenerated]
	private Label _Benphailb;

	[CompilerGenerated]
	[AccessedThroughProperty("BenTrenLb")]
	private Label _Bentrenlb;

	[AccessedThroughProperty("moc_phai")]
	[CompilerGenerated]
	private TextBox _MocPhai;

	[AccessedThroughProperty("sl")]
	[CompilerGenerated]
	private TextBox _Sl;

	[AccessedThroughProperty("SLLb")]
	[CompilerGenerated]
	private Label _label_10;

	[AccessedThroughProperty("Cover_cot")]
	[CompilerGenerated]
	private TextBox _CoverCot;

	[CompilerGenerated]
	[AccessedThroughProperty("CoverThepDaiLb")]
	private Label _label_11;

	[AccessedThroughProperty("Cover_mong")]
	[CompilerGenerated]
	private TextBox _CoverMong;

	[CompilerGenerated]
	[AccessedThroughProperty("CoverThepMongLb")]
	private Label _label_12;

	[CompilerGenerated]
	[AccessedThroughProperty("LayDuLieubtn")]
	private Button _Laydulieubtn;

	[AccessedThroughProperty("VeMongShopBtn")]
	[CompilerGenerated]
	private Button _button_13;

	[AccessedThroughProperty("DuLieuChungGrb")]
	[CompilerGenerated]
	private GroupBox _groupbox_14;

	[AccessedThroughProperty("khoaDauCotCb")]
	[CompilerGenerated]
	private CheckBox _Khoadaucotcb;

	[AccessedThroughProperty("D2")]
	[CompilerGenerated]
	private TextBox _D2;

	[AccessedThroughProperty("D1")]
	[CompilerGenerated]
	private TextBox _D1;

	[CompilerGenerated]
	[AccessedThroughProperty("daKiengTrai")]
	private CheckBox _checkbox_15;

	[CompilerGenerated]
	[AccessedThroughProperty("daKiengPhai")]
	private CheckBox _checkbox_16;

	[AccessedThroughProperty("NoRb")]
	[CompilerGenerated]
	private RadioButton _Norb;

	[CompilerGenerated]
	[AccessedThroughProperty("YesRb")]
	private RadioButton _Yesrb;

	[AccessedThroughProperty("ThepCotLB")]
	[CompilerGenerated]
	private Label _Thepcotlb;

	[CompilerGenerated]
	[AccessedThroughProperty("PanelThepCot")]
	private Panel _Panelthepcot;

	[CompilerGenerated]
	[AccessedThroughProperty("leg")]
	private TextBox _Leg;

	[AccessedThroughProperty("BeKeChanCotLb")]
	[CompilerGenerated]
	private Label _label_17;

	[AccessedThroughProperty("DaKiengVuongGoc")]
	[CompilerGenerated]
	private Button _button_18;

	[AccessedThroughProperty("DaKiengVuongGocL")]
	[CompilerGenerated]
	private Label _label_19;

	[AccessedThroughProperty("topleg")]
	[CompilerGenerated]
	private TextBox _Topleg;

	[AccessedThroughProperty("BeKeDauCotLb")]
	[CompilerGenerated]
	private Label _Bekedaucotlb;

	[AccessedThroughProperty("hCho2")]
	[CompilerGenerated]
	private TextBox _textbox_20;

	[AccessedThroughProperty("hCho3")]
	[CompilerGenerated]
	private TextBox _textbox_21;

	[AccessedThroughProperty("hCho1")]
	[CompilerGenerated]
	private TextBox _textbox_22;

	[AccessedThroughProperty("TLBV")]
	[CompilerGenerated]
	private ComboBox _combobox_23;

	[AccessedThroughProperty("TyLeLb")]
	[CompilerGenerated]
	private Label _Tylelb;

	[CompilerGenerated]
	[AccessedThroughProperty("daiVuongPhuongYTb")]
	private TextBox _textbox_24;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiVuongPhuongYLb")]
	private Label _label_25;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiCPhuongYTb")]
	private TextBox _textbox_26;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiCPhuongYLb")]
	private Label _label_27;

	[AccessedThroughProperty("daiVuongPhuongXTb")]
	[CompilerGenerated]
	private TextBox _textbox_28;

	[CompilerGenerated]
	[AccessedThroughProperty("daiVuongPhuongXLb")]
	private Label _label_29;

	[CompilerGenerated]
	[AccessedThroughProperty("daiCPhuongXTb")]
	private TextBox _textbox_30;

	[AccessedThroughProperty("daiCPhuongXLb")]
	[CompilerGenerated]
	private Label _label_31;

	private PreviewCanvas _previewcanvas_32;

	private double doubleParam;

	private bool boolParam;

	private Point pointParam;

	private string _string_33;

	private string _string_34;

	private string _string_35;

	private bool boolParam;

	private Point pointParam;

	private Point pointParam;

	internal static GetStatic_1 _appform891_36;

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

	public bool Boolean_0
	{
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

	public void voidParam(Point pointParam, diem diemParam, diem diemParam, diem diemParam, double doubleParam)
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

	private void voidParam()
	{
	}

	private void voidParam(object sender, FormClosingEventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
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

	static GetStatic_1()
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
					_goto_37:
					switch (num3)
					{
					case 2:
						AppClass_969.smethod_3();
						num3 = 0;
						if (AppClass_031.class730_0.int_88 != 0)
						{
							continue;
						}
						goto default;
					default:
						while (num2 == 9)
						{
							AppClass_960.smethod_15();
							num3 = 2;
							if (AppClass_031.class730_0.int_0 == 0)
							{
								continue;
							}
							goto _goto_37;
						}
						goto _goto_38;
					case 1:
						break;
					case 0:
						return;
					}
					goto _goto_39;
					continue;
					_goto_38:
					break;
				}
				continue;
				_goto_39:
				break;
			}
			while (num2 == 990);
			AppClass_960.smethod_13();
			num = 9;
			if (AppClass_031.class730_0.int_38 == 0)
			{
				num = 6;
			}
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
