using System;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Kata_Class_Lib_Revit;
using ns61;
using ns62;
using ns64;

namespace ns4;

public class VeThepCommand : IExtensionApplication
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class VeThepCommand
	{
		public static readonly VeThepCommand _vethepcommand_1;

		public static DocumentCollectionEventHandler _documentcollectioneventhandler_2;

		public static Action<Polygon, bool, double, int> intParam;

		internal static VeThepCommand _vethepcommand_3;

		static VeThepCommand()
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
						case 4:
							AppClass_967.boolParam();
							num3 = 5;
							if (AppClass_031.class730_0.int_37 != _return_32)
							{
								break;
							}
							goto case 3;
						case 3:
							_vethepcommand_1 = new VeThepCommand();
							num3 = _return_32;
							if (AppClass_031.class730_0.int_68 != _return_32)
							{
								break;
							}
							goto default;
						default:
							if (num2 == 11)
							{
								AppClass_969.boolParam();
								goto case 4;
							}
							if (num2 == 992)
							{
								goto _goto_4;
							}
							goto case 2;
						case 2:
							AppClass_960.smethod_13();
							num3 = _return_32;
							if (AppClass_031.class730_0.int_43 != _return_32)
							{
								break;
							}
							goto case 1;
						case 1:
							AppClass_960.smethod_15();
							num = 11;
							goto _goto_5;
						case _return_32:
							return;
						}
						continue;
						_goto_4:
						break;
					}
					continue;
					_goto_5:
					break;
				}
			}
		}

		[SpecialName]
		internal void voidParam(object sender, DocumentCollectionEventArgs e)
		{
		}

		[SpecialName]
		internal void voidParam(Polygon polygonParam, bool boolParam, double doubleParam, int intParam)
		{
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static VeThepCommand vethepcommandParam()
		{
			return null;
		}
	}

	public static AppForm_880 _appform880_6;

	public static AppForm_891 _appform891_7;

	public static AppForm_891 _appform891_8;

	public static AppForm_890 _appform890_9;

	public static AppForm_891 _appform891_10;

	public static AppForm_880 _appform880_11;

	public static AppForm_880 _appform880_12;

	public static AppForm_880 _appform880_13;

	public static AppForm_896 _appform896_14;

	public static AppForm_890 _appform890_15;

	public static AppForm_891 _appform891_16;

	public static AppForm_890 _appform890_17;

	public static AppForm_880 _appform880_18;

	public static AppForm_881 _appform881_19;

	public static AppForm_894 _appform894_20;

	public static AppForm_896 _appform896_21;

	public static AppForm_896 _appform896_22;

	public static AppForm_880 _appform880_23;

	public static AppForm_875 _appform875_24;

	public static AppForm_896 _appform896_25;

	public static AppForm_896 _appform896_26;

	public static AppForm_889 _appform889_27;

	public static AppForm_895 _appform895_28;

	private bool boolParam;

	internal static VeThepCommand _vethepcommand_29;

	static VeThepCommand()
	{
		AppClass_960.smethod_23();
		int num = 18;
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
					case 22:
						_appform891_16 = new AppForm_891();
						num3 = 3;
						if (AppClass_031.class730_0.int_51 != _return_32)
						{
							continue;
						}
						goto case 7;
					case 19:
						_appform891_10 = new AppForm_891();
						num3 = 1;
						if (AppClass_031.class730_0.int_28 != _return_32)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 30)
						{
							if (num2 == 1011)
							{
								goto _goto_30;
							}
							goto case 9;
						}
						_appform896_21 = new AppForm_896();
						num3 = 8;
						if (AppClass_031.class730_0.int_33 == _return_32)
						{
							continue;
						}
						goto case 7;
					case 9:
						_appform891_7 = null;
						goto case 6;
					case 6:
						_appform891_8 = null;
						goto case 21;
					case 21:
						_appform890_9 = new AppForm_890();
						goto case 19;
					case 20:
						_appform889_27 = new AppForm_889();
						goto case 10;
					case 10:
						_appform895_28 = new AppForm_895();
						num3 = 24;
						if (AppClass_031.class730_0.int_6 == _return_32)
						{
							continue;
						}
						return;
					case 18:
						AppClass_960.smethod_13();
						goto case 17;
					case 17:
						AppClass_960.smethod_15();
						num3 = 24;
						if (AppClass_031.class730_0.int_102 != _return_32)
						{
							continue;
						}
						goto case 7;
					case 16:
						_appform880_13 = null;
						goto case 13;
					case 13:
						_appform896_14 = null;
						num3 = 20;
						if (AppClass_031.class730_0.int_82 == _return_32)
						{
							continue;
						}
						goto case 5;
					case 5:
						_appform890_15 = new AppForm_890();
						num3 = 22;
						if (AppClass_031.class730_0.int_1 == _return_32)
						{
							continue;
						}
						goto case 21;
					case 14:
						AppClass_967.boolParam();
						goto case 4;
					case 4:
						_appform880_6 = new AppForm_880();
						num3 = 21;
						if (AppClass_031.class730_0.int_7 == _return_32)
						{
							continue;
						}
						goto case 9;
					case 12:
						_appform880_18 = new AppForm_880();
						num3 = 15;
						if (AppClass_031.class730_0.int_38 != _return_32)
						{
							continue;
						}
						goto case 23;
					case 11:
						_appform880_12 = null;
						goto case 16;
					case 8:
						_appform896_22 = new AppForm_896();
						goto case 2;
					case 2:
						_appform880_23 = new AppForm_880();
						goto case 20;
					case 3:
						_appform890_17 = new AppForm_890();
						num3 = 24;
						if (AppClass_031.class730_0.int_75 == _return_32)
						{
							continue;
						}
						goto case 12;
					case 1:
						_appform880_11 = new AppForm_880();
						num3 = 11;
						if (AppClass_031.class730_0.int_56 == _return_32)
						{
							continue;
						}
						goto case 23;
					case 15:
						_appform881_19 = new AppForm_881();
						goto case 23;
					case 7:
						AppClass_969.boolParam();
						num = 14;
						break;
					case 23:
						_appform894_20 = new AppForm_894();
						num = 30;
						if (AppClass_031.class730_0.int_48 == _return_32)
						{
							num = 1;
						}
						break;
					case _return_32:
						return;
					}
					goto _goto_31;
					continue;
					_goto_30:
					break;
				}
				continue;
				_goto_31:
				break;
			}
		}
	}

	void IExtensionApplication.Initialize()
	{
	}

	public int voidParam(string stringParam)
	{
		return _return_32;
	}

	void IExtensionApplication.Terminate()
	{
	}

	[CommandMethod("ve_thep")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("xoa_highlight")]
	public void voidParam()
	{
	}

	[CommandMethod("Update_Block_ColumnWall")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("cat_tuy_y")]
	public void voidParam()
	{
	}

	[CommandMethod("noi_thep")]
	public void voidParam()
	{
	}

	[CommandMethod("tao_tieu_de")]
	public void voidParam()
	{
	}

	[CommandMethod("doi_mau_thep")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("dimthep")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("to_hop_thep")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("chuyen")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("QS")]
	public void voidParam()
	{
	}

	[CommandMethod("xuatQS")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public static void boolParam()
	{
	}

	[CommandMethod("taomv")]
	public void voidParam()
	{
	}

	[CommandMethod("taomv1")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("ve_mong_don")]
	public void voidParam()
	{
	}

	[CommandMethod("ve_mong_coc")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("ve_loi_vach")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("ve_dam_mc")]
	public void voidParam()
	{
	}

	[CommandMethod("dam_giao")]
	public void voidParam()
	{
	}

	[CommandMethod("ve_dam_xien")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("ve_san")]
	public void voidParam()
	{
	}

	[CommandMethod("vesanpl")]
	public void voidParam()
	{
	}

	[CommandMethod("vesan4d")]
	public void voidParam()
	{
	}

	[CommandMethod("vemc")]
	public static void vethepcommandParam()
	{
	}

	[CommandMethod("ve_thang")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("ve_grid")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("pick_diem_san")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("chia_san")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("Etabs")]
	public void voidParam()
	{
	}

	[CommandMethod("GanTai")]
	public void voidParam()
	{
	}

	[CommandMethod("HoatTai")]
	public void voidParam()
	{
	}

	[CommandMethod("pdfkata")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("setupatlas")]
	public void voidParam()
	{
	}

	[CommandMethod("setupkata1")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("khthep")]
	public void voidParam()
	{
	}

	[CommandMethod("openning")]
	public void voidParam()
	{
	}

	[CommandMethod("adappt")]
	public void voidParam()
	{
	}

	[CommandMethod("loadkho")]
	public void voidParam()
	{
	}

	[CommandMethod("upkho")]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod("serikata")]
	public static void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void voidParam()
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static VeThepCommand vethepcommandParam()
	{
		return null;
	}
}
