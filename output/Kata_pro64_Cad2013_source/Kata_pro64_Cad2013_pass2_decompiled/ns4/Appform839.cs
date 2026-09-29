using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns20;
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
		public static readonly GetStatic_1 _appclass839_1;

		public static Func<AppClass_162.AppClass_179, int> intParam;

		public static Func<int, bool> boolParam;

		public static Func<AppClass_162.AppClass_179, Polygon> polygonParam;

		public static Func<AppClass_162.AppClass_179, IEnumerable<object>> ienumerableObjectParam;

		public static Func<AppClass_162.AppClass_185, object> objectParam;

		private static GetStatic_1 _appclass839_2;

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
						case 1:
							do
							{
								AppClass_967.boolParam();
								num3 = _return_5;
							}
							while (AppClass_031.class730_0.int_17 == _return_5);
							continue;
						default:
							if (num2 != 11)
							{
								goto _goto_3;
							}
							AppClass_969.smethod_3();
							num3 = 11;
							if (AppClass_031.class730_0.int_57 != _return_5)
							{
								continue;
							}
							goto case 1;
						case 3:
							AppClass_960.smethod_13();
							break;
						case 2:
							break;
						case _return_5:
							_appclass839_1 = new GetStatic_1();
							return;
						case 4:
							return;
						}
						goto _goto_4;
						continue;
						_goto_3:
						break;
					}
					if (num2 != 992)
					{
						return;
					}
					continue;
					_goto_4:
					break;
				}
				AppClass_960.smethod_15();
				num = 9;
				if (AppClass_031.class730_0.int_12 == _return_5)
				{
					num = 11;
				}
			}
		}

		[SpecialName]
		internal int intParam(AppClass_162.AppClass_179 class539_0)
		{
			return _return_5;
		}

		[SpecialName]
		internal bool boolParam(int intParam)
		{
			return true;
		}

		[SpecialName]
		internal Polygon polygonParam(AppClass_162.AppClass_179 class539_0)
		{
			return null;
		}

		[SpecialName]
		internal IEnumerable<object> ienumerableObjectParam(AppClass_162.AppClass_179 class539_0)
		{
			return null;
		}

		[SpecialName]
		internal object objectParam(AppClass_162.AppClass_185 class545_0)
		{
			return null;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass839Param()
		{
			return null;
		}
	}

	private IContainer icontainerParam;

	[CompilerGenerated]
	[AccessedThroughProperty("TaoKhungTuDongBtn")]
	private Button _button_6;

	[CompilerGenerated]
	[AccessedThroughProperty("CancelBtn")]
	private Button _button_7;

	[CompilerGenerated]
	[AccessedThroughProperty("ThongSoBanVeGrb")]
	private GroupBox _groupbox_8;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel _panel_9;

	[CompilerGenerated]
	[AccessedThroughProperty("kichThuocBanVeTb")]
	private TextBox _textbox_10;

	[AccessedThroughProperty("KhungBanVeLb")]
	[CompilerGenerated]
	private Label _Khungbanvelb;

	[CompilerGenerated]
	[AccessedThroughProperty("ChonKhungBanVeBtn")]
	private Button _button_11;

	[AccessedThroughProperty("TaoBanVeBtn")]
	[CompilerGenerated]
	private Button _Taobanvebtn;

	[CompilerGenerated]
	[AccessedThroughProperty("TaoNhomBtn")]
	private Button _button_12;

	[CompilerGenerated]
	[AccessedThroughProperty("TLKhungBanVeLb")]
	private Label _label_13;

	[CompilerGenerated]
	[AccessedThroughProperty("paddingTb")]
	private TextBox _textbox_14;

	[CompilerGenerated]
	[AccessedThroughProperty("PaddingLb")]
	private Label _label_15;

	[AccessedThroughProperty("TienToTb")]
	[CompilerGenerated]
	private TextBox _Tientotb;

	[CompilerGenerated]
	[AccessedThroughProperty("TienToLb")]
	private Label _Tientolb;

	[CompilerGenerated]
	[AccessedThroughProperty("DATETb")]
	private TextBox _Datetb;

	[AccessedThroughProperty("DATELb")]
	[CompilerGenerated]
	private Label _Datelb;

	[CompilerGenerated]
	[AccessedThroughProperty("REVTb")]
	private TextBox _textbox_16;

	[AccessedThroughProperty("REVLb")]
	[CompilerGenerated]
	private Label _label_17;

	[AccessedThroughProperty("SoBatDauTb")]
	[CompilerGenerated]
	private TextBox _Sobatdautb;

	[AccessedThroughProperty("SoBatDauLb")]
	[CompilerGenerated]
	private Label _Sobatdaulb;

	[CompilerGenerated]
	[AccessedThroughProperty("PhuongRaiBanVeLb")]
	private Label _label_18;

	[AccessedThroughProperty("PhuongXRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_19;

	[AccessedThroughProperty("PhuongYRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_20;

	[CompilerGenerated]
	[AccessedThroughProperty("chonChieuRongKhungTitle")]
	private Button _button_21;

	[AccessedThroughProperty("chieuRongKhungTitleTb")]
	[CompilerGenerated]
	private TextBox _textbox_22;

	[AccessedThroughProperty("ChieuRongTitleLb")]
	[CompilerGenerated]
	private Label _label_23;

	[CompilerGenerated]
	[AccessedThroughProperty("themChiTietThuCongBtn")]
	private Button _button_24;

	[AccessedThroughProperty("GomKhungScaleBtn")]
	[CompilerGenerated]
	private Button _button_25;

	[AccessedThroughProperty("BottomRight")]
	[CompilerGenerated]
	private RadioButton _Bottomright;

	[CompilerGenerated]
	[AccessedThroughProperty("TopRight")]
	private RadioButton _Topright;

	[CompilerGenerated]
	[AccessedThroughProperty("BottomLeft")]
	private RadioButton _Bottomleft;

	[CompilerGenerated]
	[AccessedThroughProperty("TopLeft")]
	private RadioButton _Topleft;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel2")]
	private Panel _panel_26;

	[AccessedThroughProperty("PinPositionCb")]
	[CompilerGenerated]
	private CheckBox _checkbox_27;

	[AccessedThroughProperty("Panel3")]
	[CompilerGenerated]
	private Panel _panel_28;

	[AccessedThroughProperty("SortByAreaRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_29;

	[AccessedThroughProperty("SortByGroupIdRb")]
	[CompilerGenerated]
	private RadioButton _radiobutton_30;

	[AccessedThroughProperty("GopKhungBtn")]
	[CompilerGenerated]
	private Button _button_31;

	[CompilerGenerated]
	[AccessedThroughProperty("ExpandNhomCb")]
	private CheckBox _checkbox_32;

	[AccessedThroughProperty("Panel4")]
	[CompilerGenerated]
	private Panel _panel_33;

	[CompilerGenerated]
	[AccessedThroughProperty("CanGiuaCb")]
	private RadioButton _Cangiuacb;

	[CompilerGenerated]
	[AccessedThroughProperty("CanDuoiCb")]
	private RadioButton _Canduoicb;

	[CompilerGenerated]
	[AccessedThroughProperty("TestModeCb")]
	private CheckBox _Testmodecb;

	[CompilerGenerated]
	[AccessedThroughProperty("paddingXChiTietPhuTb")]
	private TextBox _textbox_34;

	[AccessedThroughProperty("Label9")]
	[CompilerGenerated]
	private Label _label_35;

	[AccessedThroughProperty("BangThongKeCb")]
	[CompilerGenerated]
	private CheckBox _checkbox_36;

	[CompilerGenerated]
	[AccessedThroughProperty("ScaleXuongTb")]
	private TextBox _textbox_37;

	[CompilerGenerated]
	[AccessedThroughProperty("NeuChiTietVuotQuaKhungLb")]
	private Label _label_38;

	[AccessedThroughProperty("ChoPhepScaleXuongCb")]
	[CompilerGenerated]
	private CheckBox _checkbox_39;

	[AccessedThroughProperty("TLBV")]
	[CompilerGenerated]
	private TextBox _textbox_40;

	[CompilerGenerated]
	[AccessedThroughProperty("KhoGiayTb")]
	private TextBox _Khogiaytb;

	[AccessedThroughProperty("KhoGiayLb")]
	[CompilerGenerated]
	private Label _Khogiaylb;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	private Label _label_41;

	[AccessedThroughProperty("DrawingNoGrb")]
	[CompilerGenerated]
	private GroupBox _Drawingnogrb;

	[CompilerGenerated]
	[AccessedThroughProperty("SttNhomTb")]
	private TextBox _textbox_42;

	[AccessedThroughProperty("SttNhomLb")]
	[CompilerGenerated]
	private Label _label_43;

	[CompilerGenerated]
	[AccessedThroughProperty("LayoutRb")]
	private RadioButton _Layoutrb;

	[AccessedThroughProperty("ModelRb")]
	[CompilerGenerated]
	private RadioButton _Modelrb;

	public bool boolParam;

	private bool boolParam;

	public Button buttonParam;

	public bool boolParam;

	internal static GetStatic_2 _appform839_44;

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

	internal virtual Button Button_7
	{
		[CompilerGenerated]
		get
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

	internal virtual Button Button_8
	{
		[CompilerGenerated]
		get
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

	internal virtual RadioButton RadioButton_8
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RadioButton RadioButton_9
	{
		[CompilerGenerated]
		get
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

	internal virtual RadioButton RadioButton_10
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RadioButton RadioButton_11
	{
		[CompilerGenerated]
		get
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
	private void intParam()
	{
	}

	private void boolParam(object sender, EventArgs e)
	{
	}

	private void polygonParam(object sender, FormClosingEventArgs e)
	{
	}

	private void ienumerableObjectParam()
	{
	}

	public void objectParam()
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

	static GetStatic_2()
	{
		AppClass_960.smethod_23();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				_goto_47:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						goto _goto_46;
					default:
						switch (num2)
						{
						default:
							goto _goto_46;
						case 990:
							break;
						case 9:
							return;
						}
						goto _goto_47;
					case _return_5:
						AppClass_960.smethod_15();
						num = 2;
						break;
					case 2:
						{
							AppClass_969.smethod_3();
							num = 9;
							if (AppClass_031.class730_0.int_41 == _return_5)
							{
								num = 8;
							}
							break;
						}
						_goto_46:
						AppClass_960.smethod_13();
						num3 = _return_5;
						if (AppClass_031.class730_0.int_72 != _return_5)
						{
							continue;
						}
						goto case 2;
					}
					break;
				}
				break;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass839Param()
	{
		return null;
	}
}
