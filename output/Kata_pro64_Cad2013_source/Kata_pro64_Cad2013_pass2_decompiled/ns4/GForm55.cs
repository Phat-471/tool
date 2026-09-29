using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns4;

[DesignerGenerated]
public class GetStatic_2 : Form
{
	[CompilerGenerated]
	internal sealed class GetStatic_1
	{
		public string _string_95;

		public GetStatic_2 _appform881_99;

		internal static GetStatic_1 _appclass881_3;

		[SpecialName]
		internal void voidParam()
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
							num3 = _return_101;
							if (AppClass_031.class730_0.int_72 != _return_101)
							{
								continue;
							}
							goto case _return_101;
						case _return_101:
							AppClass_960.smethod_15();
							num = 5;
							if (AppClass_031.class730_0.int_18 == _return_101)
							{
								num = 9;
							}
							goto _goto_4;
						case 2:
							return;
						}
						break;
					}
					switch (num2)
					{
					default:
						return;
					case 990:
						break;
					case 9:
						AppClass_969.smethod_3();
						return;
					}
					continue;
					_goto_4:
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass881Param()
		{
			return null;
		}
	}

	private IContainer icontainerParam;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _groupbox_5;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_text")]
	private TextBox _LayerText;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_textL")]
	private Label _LayerTextl;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_net_manh")]
	private TextBox _LayerNetManh;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_net_manhL")]
	private Label _LayerNetManhl;

	[AccessedThroughProperty("layer_thep_dai_khuat")]
	[CompilerGenerated]
	private TextBox _LayerThepDaiKhuat;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_thep_dai_khuatL")]
	private Label _LayerThepDaiKhuatl;

	[AccessedThroughProperty("layer_thep_dai")]
	[CompilerGenerated]
	private TextBox _LayerThepDai;

	[AccessedThroughProperty("layer_thep_daiL")]
	[CompilerGenerated]
	private Label _LayerThepDail;

	[AccessedThroughProperty("layer_thep_doc")]
	[CompilerGenerated]
	private TextBox _LayerThepDoc;

	[AccessedThroughProperty("layer_thep_docL")]
	[CompilerGenerated]
	private Label _LayerThepDocl;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_grid")]
	private TextBox _LayerGrid;

	[AccessedThroughProperty("layer_gridL")]
	[CompilerGenerated]
	private Label _LayerGridl;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_hidden")]
	private TextBox _LayerHidden;

	[AccessedThroughProperty("layer_hiddenL")]
	[CompilerGenerated]
	private Label _LayerHiddenl;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_table")]
	private TextBox _LayerTable;

	[AccessedThroughProperty("layer_tableL")]
	[CompilerGenerated]
	private Label _LayerTablel;

	[AccessedThroughProperty("layer_border")]
	[CompilerGenerated]
	private TextBox _LayerBorder;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_borderL")]
	private Label _LayerBorderl;

	[CompilerGenerated]
	[AccessedThroughProperty("layer_dim")]
	private TextBox _LayerDim;

	[AccessedThroughProperty("kata_dimL")]
	[CompilerGenerated]
	private Label _KataDiml;

	[AccessedThroughProperty("Style_Dim")]
	[CompilerGenerated]
	private TextBox _textbox_6;

	[CompilerGenerated]
	[AccessedThroughProperty("Style_DimL")]
	private Label _label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Style_text")]
	private TextBox _textbox_8;

	[AccessedThroughProperty("Style_textL")]
	[CompilerGenerated]
	private Label _label_9;

	[AccessedThroughProperty("OK")]
	[CompilerGenerated]
	private Button _Ok;

	[AccessedThroughProperty("Cancel")]
	[CompilerGenerated]
	private Button _Cancel;

	[AccessedThroughProperty("phi_gai")]
	[CompilerGenerated]
	private TextBox _PhiGai;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_gaiL")]
	private Label _PhiGail;

	[AccessedThroughProperty("phi_tron")]
	[CompilerGenerated]
	private TextBox _PhiTron;

	[AccessedThroughProperty("phi_tronL")]
	[CompilerGenerated]
	private Label _PhiTronl;

	[CompilerGenerated]
	[AccessedThroughProperty("khkc")]
	private TextBox _textbox_10;

	[AccessedThroughProperty("khkcL")]
	[CompilerGenerated]
	private Label _label_11;

	[CompilerGenerated]
	[AccessedThroughProperty("ty_le")]
	private ComboBox _TyLe;

	[CompilerGenerated]
	[AccessedThroughProperty("ty_leL")]
	private Label _TyLel;

	[AccessedThroughProperty("Dai_C")]
	[CompilerGenerated]
	private ComboBox _DaiC;

	[CompilerGenerated]
	[AccessedThroughProperty("Dai_CL")]
	private Label _DaiCl;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_crankL")]
	private Label _PhiCrankl;

	[AccessedThroughProperty("phi_crank")]
	[CompilerGenerated]
	private ComboBox _PhiCrank;

	[AccessedThroughProperty("phi_couplerL")]
	[CompilerGenerated]
	private Label _PhiCouplerl;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_coupler")]
	private ComboBox _PhiCoupler;

	[AccessedThroughProperty("GroupBox_nt_beam")]
	[CompilerGenerated]
	private GroupBox _groupbox_12;

	[AccessedThroughProperty("noi_duoi_goi")]
	[CompilerGenerated]
	private CheckBox _NoiDuoiGoi;

	[CompilerGenerated]
	[AccessedThroughProperty("noi_tren_giua")]
	private CheckBox _NoiTrenGiua;

	[CompilerGenerated]
	[AccessedThroughProperty("Moc_cat")]
	private CheckBox _MocCat;

	[AccessedThroughProperty("dung_neo_cot_duoi")]
	[CompilerGenerated]
	private CheckBox _checkbox_13;

	[AccessedThroughProperty("ko_be_ke_duoi")]
	[CompilerGenerated]
	private CheckBox _KoBeKeDuoi;

	[AccessedThroughProperty("ty_le_uonL")]
	[CompilerGenerated]
	private Label _TyLeUonl;

	[AccessedThroughProperty("ty_le_uon")]
	[CompilerGenerated]
	private ComboBox _TyLeUon;

	[AccessedThroughProperty("giu_lai_stt")]
	[CompilerGenerated]
	private CheckBox _GiuLaiStt;

	[AccessedThroughProperty("noi_duoi_giua")]
	[CompilerGenerated]
	private CheckBox _NoiDuoiGiua;

	[AccessedThroughProperty("noi_tren_goi")]
	[CompilerGenerated]
	private CheckBox _NoiTrenGoi;

	[AccessedThroughProperty("GroupBox_neo_dam")]
	[CompilerGenerated]
	private GroupBox _GroupboxNeoDam;

	[CompilerGenerated]
	[AccessedThroughProperty("TabControl")]
	private TabControl _Tabcontrol;

	[AccessedThroughProperty("General_index")]
	[CompilerGenerated]
	private TabPage _GeneralIndex;

	[AccessedThroughProperty("Short_commands_TabPage")]
	[CompilerGenerated]
	private TabPage _tabpage_14;

	[AccessedThroughProperty("Detail_rebar")]
	[CompilerGenerated]
	private TabPage _DetailRebar;

	[AccessedThroughProperty("phi_10L")]
	[CompilerGenerated]
	private Label _label_15;

	[CompilerGenerated]
	[AccessedThroughProperty("phi_10")]
	private TextBox _textbox_16;

	[AccessedThroughProperty("L_max")]
	[CompilerGenerated]
	private TextBox _LMax;

	[AccessedThroughProperty("L_maxL")]
	[CompilerGenerated]
	private Label _label_17;

	[CompilerGenerated]
	[AccessedThroughProperty("L_min")]
	private TextBox _LMin;

	[CompilerGenerated]
	[AccessedThroughProperty("L_minL")]
	private Label _label_18;

	[AccessedThroughProperty("Ghi_sl_thep_rai")]
	[CompilerGenerated]
	private CheckBox _checkbox_19;

	[AccessedThroughProperty("vung_noi_tu_duoi")]
	[CompilerGenerated]
	private ComboBox _combobox_20;

	[AccessedThroughProperty("Label18")]
	[CompilerGenerated]
	private Label _label_21;

	[AccessedThroughProperty("vung_noi_L_duoi")]
	[CompilerGenerated]
	private TextBox _textbox_22;

	[AccessedThroughProperty("vung_noi_L_duoiL")]
	[CompilerGenerated]
	private Label _label_23;

	[AccessedThroughProperty("rut_gon_mc_dam")]
	[CompilerGenerated]
	private CheckBox _checkbox_24;

	[AccessedThroughProperty("text_dvi_ke")]
	[CompilerGenerated]
	private Label _label_25;

	[CompilerGenerated]
	[AccessedThroughProperty("be_ke")]
	private TextBox _BeKe;

	[AccessedThroughProperty("Check_be_ke")]
	[CompilerGenerated]
	private CheckBox _CheckBeKe;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer_network")]
	private Timer _TimerNetwork;

	[CompilerGenerated]
	[AccessedThroughProperty("thep_thay_doiL")]
	private Label _ThepThayDoil;

	[CompilerGenerated]
	[AccessedThroughProperty("thep_thay_doi")]
	private ComboBox _ThepThayDoi;

	[AccessedThroughProperty("bo_90")]
	[CompilerGenerated]
	private CheckBox _Bo90;

	[AccessedThroughProperty("round_neo_noi")]
	[CompilerGenerated]
	private TextBox _RoundNeoNoi;

	[AccessedThroughProperty("round_neo_noiL")]
	[CompilerGenerated]
	private Label _RoundNeoNoil;

	[CompilerGenerated]
	[AccessedThroughProperty("Grid_dk_mau")]
	private DataGridView _datagridview_26;

	[AccessedThroughProperty("text_dvi_daiC")]
	[CompilerGenerated]
	private Label _label_27;

	[CompilerGenerated]
	[AccessedThroughProperty("L_moc_daiC")]
	private TextBox _LMocDaic;

	[AccessedThroughProperty("round_be_ke")]
	[CompilerGenerated]
	private TextBox _RoundBeKe;

	[AccessedThroughProperty("round_be_keL")]
	[CompilerGenerated]
	private Label _RoundBeKel;

	[AccessedThroughProperty("Stretch_rebar")]
	[CompilerGenerated]
	private TabPage _tabpage_28;

	[AccessedThroughProperty("GroupBox_do_gian")]
	[CompilerGenerated]
	private GroupBox _GroupboxDoGian;

	[AccessedThroughProperty("do_dan_text")]
	[CompilerGenerated]
	private TextBox _DoDanText;

	[AccessedThroughProperty("L_do_dan_d")]
	[CompilerGenerated]
	private Label _label_29;

	[AccessedThroughProperty("do_dan_dang")]
	[CompilerGenerated]
	private ComboBox _DoDanDang;

	[AccessedThroughProperty("do_dan_dangL")]
	[CompilerGenerated]
	private Label _DoDanDangl;

	[CompilerGenerated]
	[AccessedThroughProperty("do_dan_d")]
	private TextBox _DoDanD;

	[AccessedThroughProperty("do_dan_dL")]
	[CompilerGenerated]
	private Label _DoDanDl;

	[CompilerGenerated]
	[AccessedThroughProperty("Hinh_thep")]
	private PictureBox _picturebox_30;

	[AccessedThroughProperty("do_dan_textL")]
	[CompilerGenerated]
	private Label _DoDanTextl;

	[CompilerGenerated]
	[AccessedThroughProperty("vung_noi_tu_tren")]
	private ComboBox _combobox_31;

	[AccessedThroughProperty("Label24")]
	[CompilerGenerated]
	private Label _label_32;

	[AccessedThroughProperty("vung_noi_L_tren")]
	[CompilerGenerated]
	private TextBox _textbox_33;

	[CompilerGenerated]
	[AccessedThroughProperty("vung_noi_L_trenL")]
	private Label _label_34;

	[CompilerGenerated]
	[AccessedThroughProperty("L_min_cat")]
	private TextBox _LMinCat;

	[AccessedThroughProperty("L_min_catL")]
	[CompilerGenerated]
	private Label _LMinCatl;

	[AccessedThroughProperty("dai_damL")]
	[CompilerGenerated]
	private Label _DaiDaml;

	[AccessedThroughProperty("dai_dam")]
	[CompilerGenerated]
	private ComboBox _DaiDam;

	[AccessedThroughProperty("LanguageL")]
	[CompilerGenerated]
	private Label _Languagel;

	[AccessedThroughProperty("Language")]
	[CompilerGenerated]
	private ComboBox _Language;

	[CompilerGenerated]
	[AccessedThroughProperty("Check_L_ke_Rad")]
	private CheckBox _checkbox_35;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _groupbox_36;

	[AccessedThroughProperty("Check_Auto_fix_hook_cog")]
	[CompilerGenerated]
	private CheckBox _checkbox_37;

	[CompilerGenerated]
	[AccessedThroughProperty("Grid_hook_cog")]
	private DataGridView _GridHookCog;

	[CompilerGenerated]
	[AccessedThroughProperty("Round_slL")]
	private Label _label_38;

	[AccessedThroughProperty("Round_sl")]
	[CompilerGenerated]
	private ComboBox _combobox_39;

	[AccessedThroughProperty("Timer_off")]
	[CompilerGenerated]
	private Timer _TimerOff;

	[CompilerGenerated]
	[AccessedThroughProperty("show_ten_tai_mc")]
	private CheckBox _ShowTenTaiMc;

	[AccessedThroughProperty("rut_gon_dim")]
	[CompilerGenerated]
	private CheckBox _RutGonDim;

	[CompilerGenerated]
	[AccessedThroughProperty("style_leader_thanhL")]
	private Label _label_40;

	[AccessedThroughProperty("style_leader_thanh")]
	[CompilerGenerated]
	private ComboBox _combobox_41;

	[AccessedThroughProperty("Specific")]
	[CompilerGenerated]
	private TabPage _Specific;

	[AccessedThroughProperty("Grid_Unit_mass")]
	[CompilerGenerated]
	private DataGridView _GridUnitMass;

	[AccessedThroughProperty("Check_Unit_mass")]
	[CompilerGenerated]
	private CheckBox _checkbox_42;

	[CompilerGenerated]
	[AccessedThroughProperty("Check_lap_len")]
	private CheckBox _CheckLapLen;

	[CompilerGenerated]
	[AccessedThroughProperty("Grid_lap_len")]
	private DataGridView _GridLapLen;

	[AccessedThroughProperty("Check_betong_coppha")]
	[CompilerGenerated]
	private CheckBox _checkbox_43;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox_noi_thep")]
	private GroupBox _GroupboxNoiThep;

	[CompilerGenerated]
	[AccessedThroughProperty("kc_nt")]
	private TextBox _textbox_44;

	[CompilerGenerated]
	[AccessedThroughProperty("kc_ntL")]
	private Label _label_45;

	[CompilerGenerated]
	[AccessedThroughProperty("nt")]
	private TextBox _Nt;

	[CompilerGenerated]
	[AccessedThroughProperty("ntL")]
	private Label _Ntl;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_46;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_47;

	[CompilerGenerated]
	[AccessedThroughProperty("Lnt_han_che")]
	private Label _label_48;

	[CompilerGenerated]
	[AccessedThroughProperty("nt_han_che")]
	private TextBox _NtHanChe;

	[CompilerGenerated]
	[AccessedThroughProperty("check_nt_han_che")]
	private CheckBox _checkbox_49;

	[CompilerGenerated]
	[AccessedThroughProperty("UnitL")]
	private Label _Unitl;

	[CompilerGenerated]
	[AccessedThroughProperty("Unit")]
	private ComboBox _Unit;

	[CompilerGenerated]
	[AccessedThroughProperty("ds")]
	private TextBox _Ds;

	[AccessedThroughProperty("dsL")]
	[CompilerGenerated]
	private Label _Dsl;

	[AccessedThroughProperty("Cat_thep_chay_suot_dam")]
	[CompilerGenerated]
	private CheckBox _checkbox_50;

	[AccessedThroughProperty("Tab_Update_info")]
	[CompilerGenerated]
	private TabPage _tabpage_51;

	[CompilerGenerated]
	[AccessedThroughProperty("Show_d_noi")]
	private CheckBox _checkbox_52;

	[AccessedThroughProperty("Short_commands")]
	[CompilerGenerated]
	private Panel _ShortCommands;

	[AccessedThroughProperty("DefaultRebar")]
	[CompilerGenerated]
	private TabPage _Defaultrebar;

	[AccessedThroughProperty("damGiaoGrb")]
	[CompilerGenerated]
	private GroupBox _Damgiaogrb;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiVaiBoTb")]
	private TextBox _Daivaibotb;

	[AccessedThroughProperty("CoDaiVaiBoCb")]
	[CompilerGenerated]
	private CheckBox _Codaivaibocb;

	[AccessedThroughProperty("DaiVaiBoLb")]
	[CompilerGenerated]
	private Label _Daivaibolb;

	[AccessedThroughProperty("DaiGiaCuongTb")]
	[CompilerGenerated]
	private TextBox _textbox_53;

	[AccessedThroughProperty("DaiGCLb")]
	[CompilerGenerated]
	private Label _label_54;

	[AccessedThroughProperty("Dia")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _Dia;

	[CompilerGenerated]
	[AccessedThroughProperty("R")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_55;

	[CompilerGenerated]
	[AccessedThroughProperty("Cog")]
	private DataGridViewTextBoxColumn _Cog;

	[CompilerGenerated]
	[AccessedThroughProperty("Hook135")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_56;

	[AccessedThroughProperty("Hook")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _Hook;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_57;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_58;

	[AccessedThroughProperty("Column1")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_59;

	[CompilerGenerated]
	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_60;

	[CompilerGenerated]
	[AccessedThroughProperty("Column3")]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_61;

	[AccessedThroughProperty("DuLieuThepGiaCuongGrb")]
	[CompilerGenerated]
	private GroupBox _groupbox_62;

	[CompilerGenerated]
	[AccessedThroughProperty("cotCayGrb")]
	private GroupBox _groupbox_63;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiVaiBoCotCayTb")]
	private TextBox _textbox_64;

	[CompilerGenerated]
	[AccessedThroughProperty("CoDaiVaiBoCotCayCb")]
	private CheckBox _checkbox_65;

	[AccessedThroughProperty("DaiVaiBoCotCayLb")]
	[CompilerGenerated]
	private Label _label_66;

	[CompilerGenerated]
	[AccessedThroughProperty("DaiGiaCuongCotCayTb")]
	private TextBox _textbox_67;

	[AccessedThroughProperty("daiGCCotCayLb")]
	[CompilerGenerated]
	private Label _label_68;

	[CompilerGenerated]
	[AccessedThroughProperty("kc_2mep")]
	private TextBox _textbox_69;

	[AccessedThroughProperty("kc_2mepL")]
	[CompilerGenerated]
	private Label _label_70;

	[AccessedThroughProperty("MocDaiVaiBoCotCayTb")]
	[CompilerGenerated]
	private TextBox _textbox_71;

	[AccessedThroughProperty("MocDaiVaiBoCotCayLb")]
	[CompilerGenerated]
	private Label _label_72;

	[CompilerGenerated]
	[AccessedThroughProperty("MocDaiVaiBoTb")]
	private TextBox _textbox_73;

	[CompilerGenerated]
	[AccessedThroughProperty("MocDaiVaiBoLb")]
	private Label _label_74;

	[AccessedThroughProperty("toi_uu_moi_noi")]
	[CompilerGenerated]
	private CheckBox _ToiUuMoiNoi;

	[AccessedThroughProperty("TB_Update_info")]
	[CompilerGenerated]
	private RichTextBox _TbUpdateInfo;

	[AccessedThroughProperty("Neo_gia")]
	[CompilerGenerated]
	private TextBox _NeoGia;

	[CompilerGenerated]
	[AccessedThroughProperty("Neo_giaL")]
	private Label _NeoGial;

	[AccessedThroughProperty("text_dvi_neo_gia")]
	[CompilerGenerated]
	private Label _label_75;

	[CompilerGenerated]
	[AccessedThroughProperty("GocDaiVaiBoCotCayLb")]
	private Label _label_76;

	[CompilerGenerated]
	[AccessedThroughProperty("GocDaiVaiBoLb")]
	private Label _label_77;

	[CompilerGenerated]
	[AccessedThroughProperty("GocBeDaiVaiBoCotCayCb")]
	private ComboBox _combobox_78;

	[CompilerGenerated]
	[AccessedThroughProperty("GocBeDaiVaiBoCb")]
	private ComboBox _combobox_79;

	[CompilerGenerated]
	[AccessedThroughProperty("DK")]
	private DataGridViewComboBoxColumn _Dk;

	[AccessedThroughProperty("color")]
	[CompilerGenerated]
	private DataGridViewComboBoxColumn _Color;

	[AccessedThroughProperty("tkt_cot_vach_tang")]
	[CompilerGenerated]
	private CheckBox _checkbox_80;

	[CompilerGenerated]
	[AccessedThroughProperty("round_cat_thep_dam")]
	private TextBox _textbox_81;

	[CompilerGenerated]
	[AccessedThroughProperty("round_cat_thep_damL")]
	private Label _label_82;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox_round")]
	private GroupBox _GroupboxRound;

	[AccessedThroughProperty("show_all_dai")]
	[CompilerGenerated]
	private CheckBox _ShowAllDai;

	[AccessedThroughProperty("text_dvi_daiCN")]
	[CompilerGenerated]
	private Label _label_83;

	[AccessedThroughProperty("L_moc_daiCN")]
	[CompilerGenerated]
	private TextBox _LMocDaicn;

	[AccessedThroughProperty("Dai_CN")]
	[CompilerGenerated]
	private ComboBox _DaiCn;

	[CompilerGenerated]
	[AccessedThroughProperty("Dai_CNL")]
	private Label _DaiCnl;

	[AccessedThroughProperty("SpecCotCayLb")]
	[CompilerGenerated]
	private Label _Speccotcaylb;

	[AccessedThroughProperty("SpecCb")]
	[CompilerGenerated]
	private ComboBox _combobox_84;

	[AccessedThroughProperty("SpecLb")]
	[CompilerGenerated]
	private Label _label_85;

	[CompilerGenerated]
	[AccessedThroughProperty("GhiChuSpecLb")]
	private Label _Ghichuspeclb;

	[AccessedThroughProperty("SpecCotCayCb")]
	[CompilerGenerated]
	private ComboBox _Speccotcaycb;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _panel_86;

	[AccessedThroughProperty("ThroughCotCayCb")]
	[CompilerGenerated]
	private CheckBox _checkbox_87;

	[AccessedThroughProperty("ThroughCotCayLb")]
	[CompilerGenerated]
	private Label _label_88;

	[CompilerGenerated]
	[AccessedThroughProperty("ThroughCb")]
	private CheckBox _checkbox_89;

	[CompilerGenerated]
	[AccessedThroughProperty("ThroughLb")]
	private Label _label_90;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel2")]
	private Panel _panel_91;

	[CompilerGenerated]
	[AccessedThroughProperty("daiGCDamGiaoTaiGoiCb")]
	private CheckBox _checkbox_92;

	[CompilerGenerated]
	[AccessedThroughProperty("ThayDoiDKTheoNhipCb")]
	private CheckBox _checkbox_93;

	[AccessedThroughProperty("BoQuaNhanCoChaiKhiTinhDai")]
	[CompilerGenerated]
	private CheckBox _checkbox_94;

	private string _string_95;

	private Timer timerParam;

	private int intParam;

	private string[] _stringarray_96;

	private Dictionary<string, KataRibbonCommand.KataRibbonCommand> kataribboncommandParam;

	private int intParam;

	public TextBox[] _textboxarray_97;

	public Label[] label_65;

	private string[] _stringarray_98;

	private Dictionary<int, LinkLabel> linklabelParam;

	internal static GetStatic_2 _appform881_99;

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

	internal virtual ComboBox ComboBox_4
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_6
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_7
	{
		[CompilerGenerated]
		get
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

	internal virtual TabPage TabPage_2
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_8
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_5
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_9
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_10
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_6
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_11
	{
		[CompilerGenerated]
		get
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

	internal virtual TabPage TabPage_3
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_7
	{
		[CompilerGenerated]
		get
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

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_8
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_9
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_10
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_12
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_13
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridView DataGridView_1
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_11
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_14
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_15
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_40
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_12
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TabPage TabPage_4
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridView DataGridView_2
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_16
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_17
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridView DataGridView_3
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_18
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_41
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_42
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_43
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_19
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_44
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_13
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_45
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_20
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TabPage TabPage_5
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_21
	{
		[CompilerGenerated]
		get
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

	internal virtual TabPage TabPage_6
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_22
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_46
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_47
	{
		[CompilerGenerated]
		get
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_3
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_4
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_5
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_6
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_7
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_8
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_9
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_10
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn_11
	{
		[CompilerGenerated]
		get
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

	internal virtual GroupBox GroupBox_8
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_23
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_48
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_49
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_50
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_51
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_52
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_24
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RichTextBox RichTextBox_0
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_53
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_54
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_55
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_56
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_14
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_15
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn_0
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn_1
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_25
	{
		[CompilerGenerated]
		get
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

	internal virtual Label Label_57
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual GroupBox GroupBox_9
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_26
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_58
	{
		[CompilerGenerated]
		get
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

	internal virtual ComboBox ComboBox_16
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_59
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_60
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_17
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_61
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_62
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox ComboBox_18
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_27
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_63
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_28
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label Label_64
	{
		[CompilerGenerated]
		get
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

	internal virtual CheckBox CheckBox_29
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_30
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox CheckBox_31
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string String_0 => null;

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
	internal virtual Timer timerParam()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void voidParam(Timer timerParam)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer timerParam()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void voidParam(Timer timerParam)
	{
	}

	internal void voidParam()
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

	public void voidParam(object objectParam, double doubleParam, double doubleParam)
	{
	}

	private void voidParam(bool boolParam = true)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private int intParam(List<KataRibbonCommand.KataRibbonCommand> kataribboncommandParam, int intParam)
	{
		return _return_101;
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	private void voidParam(object sender, EventArgs e)
	{
	}

	public void voidParam(string stringParam, StreamReader streamReader_0)
	{
	}

	public void voidParam()
	{
	}

	public string stringParam()
	{
		return null;
	}

	public string stringParam()
	{
		return null;
	}

	public void voidParam()
	{
	}

	public int intParam(string stringParam)
	{
		return _return_101;
	}

	public void voidParam(ref string stringParam, double doubleParam, double doubleParam = 100._return_101)
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

	public string stringParam(string stringParam)
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

	private void voidParam(object sender, LinkClickedEventArgs e)
	{
	}

	private void voidParam(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	public void voidParam(string stringParam = "http://katapro.net/huong-dan/")
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

	[SpecialName]
	[CompilerGenerated]
	private void voidParam(object objectParam)
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
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						AppClass_960.smethod_13();
						num3 = _return_101;
						if (AppClass_031.class730_0.int_106 == _return_101)
						{
							continue;
						}
						goto default;
					default:
						switch (num2)
						{
						default:
							return;
						case 990:
							break;
						case 9:
							AppClass_969.smethod_3();
							return;
						}
						goto _goto_102;
					case _return_101:
						break;
					case 2:
						return;
					}
					goto _goto_103;
					continue;
					_goto_102:
					break;
				}
				continue;
				_goto_103:
				break;
			}
			AppClass_960.smethod_15();
			num = 9;
			if (AppClass_031.class730_0.int_48 == _return_101)
			{
				num = 2;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_2 appclass881Param()
	{
		return null;
	}
}
