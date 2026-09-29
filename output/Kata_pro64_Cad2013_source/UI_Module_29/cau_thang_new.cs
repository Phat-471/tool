using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class cau_thang_new
{
	public class VeThang
	{
		public int _int_2;

		public double Xbt;

		public double Ybt;

		public int veNumber;

		public info_thep thepDocTren;

		public info_thep _infoThep_3;

		public info_thep thepDocDuoi;

		public info_thep _infoThep_4;

		public bool isCN;

		public double _string_36;

		public double _string_32;

		public double _string_31;

		public double _string_30;

		public double _string_29;

		public double _string_35;

		public double _string_34;

		public double _string_33;

		public double Hb1;

		public double Hb2;

		public double Hb3;

		public double Hd1;

		public double Hd4;

		public double Bd1;

		public double Bd4;

		public double Bd2;

		public double Bd3;

		public double _double_13;

		public double _string_26;

		public bool _bool_37;

		public InfoThep cau_tao;

		public InfoThep chiu_nghi;

		public InfoThep main_steel;

		public InfoThep _infothep_16;

		public bool _bool_17;

		public bool _bool_39;

		public double _string_41;

		public double hLast;

		public double hMid;

		public int _string_43;

		public double rong;

		public int _string_38;

		public double ct1;

		public double ct2;

		public string tenMC;

		private static VeThang _vethang_22;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VeThang()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetH()
		{
			return _return_63._return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetB()
		{
			return _return_63._return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VeThang()
		{
			AppClass_016.uQ4DbMFRj7Q();
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								AppClass_054.IveTMUdyS5E();
								num3 = 2;
								continue;
							}
							goto _goto_69;
						case _return_63:
							break;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_63;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_7b8aeed32af146098fab5f422ce25d24 == _return_63)
							{
								num3 = 3;
							}
							continue;
						case 2:
							return;
						}
						goto _goto_70;
						continue;
						_goto_69:
						break;
					}
					continue;
					_goto_70:
					break;
				}
				while (num2 == 990);
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_72823ff942d347a096f59781d20eb0d2 != _return_63)
				{
					num = 7;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_1()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static VeThang GetVethang_2()
		{
			return null;
		}
	}

	public class InfoThangSave
	{
		public string _string_25;

		public string _string_26;

		public string v3berongban;

		public string v1L3;

		public string v3L1;

		public string ctv2;

		public string ctv3;

		public string v3L2;

		public string v3L3;

		public string v1berongban;

		public string ctv1;

		public string v1L1;

		public string v1L2;

		public string ctv22;

		public string v3bd4;

		public string v3L5;

		public string v3bd3;

		public string v3bd2;

		public string v3L4;

		public string v3bd1;

		public string v1bd1;

		public string v1L4;

		public string v1bd2;

		public string v1bd3;

		public string v1L5;

		public string v1bd4;

		public string _double_50;

		public string _double_51;

		public string bGiuaCn;

		public string berongv2;

		public string _string_29;

		public string _string_30;

		public string _string_31;

		public string _string_32;

		public string _string_33;

		public string _string_34;

		public string _string_35;

		public string Ct1;

		public string Ct2;

		public string _string_36;

		public string Bd1;

		public string Bd4;

		public string Bd2;

		public string Bd3;

		public string Hb2;

		public string Hd4;

		public string Hb3;

		public string Hd1;

		public string Hb1;

		public bool _bool_37;

		public string cau_tao;

		public string chiu_nghi;

		public string main_steel;

		public string cover;

		public string rong;

		public string _string_38;

		public bool cat_thep;

		public bool _bool_39;

		public string _string_40;

		public string hLast;

		public string hMid;

		public string _string_41;

		public string _string_42;

		public string _string_43;

		public string _string_44;

		internal static InfoThangSave _infothangsave_45;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoThangSave()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoThangSave()
		{
			AppClass_016.uQ4DbMFRj7Q();
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								return;
							}
							goto _goto_69;
						case _return_63:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_9b8a3fa59b0643a9a005e0e055caa087 == _return_63)
							{
								num3 = _return_63;
							}
							continue;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_63;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_559789cacd7f46ac973fb693ed94037f == _return_63)
							{
								num3 = 3;
							}
							continue;
						case 2:
							break;
						}
						goto _goto_70;
						continue;
						_goto_69:
						break;
					}
					continue;
					_goto_70:
					break;
				}
				while (num2 == 990);
				AppClass_054.IveTMUdyS5E();
				num = 7;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988 != _return_63)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_3()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoThangSave GetInfothangsave_4()
		{
			return null;
		}
	}

	private struct AppStruct_258
	{
		public double _double_48;

		public double _double_49;
	}

	public enum AppEnum_259
	{
		MotVe = 1,
		HaiVeSongSong,
		BaVe,
		HaiVeThang
	}

	public enum AppEnum_260
	{
		trong = 1,
		ngoai
	}

	public class CauThang
	{
		public int LoaiCauThang;

		public bool isZigZac;

		public VeThang Ve1;

		public VeThang Ve2;

		public VeThang Ve3;

		public double cover;

		public string tenThang;

		public int soCK;

		public double bGiuaCn;

		public double _double_50;

		public double _double_51;

		public double berongv2;

		public diem pGoc;

		public bool shopthang;

		public diem xVecto;

		public diem yVecto;

		public bool NoiThangCu;

		public double _double_52;

		public double _double_53;

		public double _double_54;

		public info_thep _infoThep_55;

		public info_thep _infoThep_56;

		public object _object_57;

		public object _object_58;

		public int _int_59;

		public int _int_60;

		public int _int_61;

		public double kcDim;

		public double kcNetDam;

		internal static CauThang _cauthang_62;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CauThang()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_5(int loai)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetDouble_6()
		{
			return _return_63._return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private double GetDelta()
		{
			return _return_63._return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<diem> GetListDiem_7(List<diem> hcn, int index1, int index2)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> Damv1(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> Damv2(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> Damv3(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_8()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_9()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<diem> GetListDiem_10(diem newPGoc, double b, double h)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_11(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_12(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_13(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> GetListListDiem_14(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_15(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_16(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_17(bool green = false, bool gray = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> GetListListDiem_18()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_19()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> GetListListDiem_20()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> ListBaoThangCyanMB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> ListPathgGrayMB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> ListDamGreenMB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> ListDamGrayMB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_21()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, List<diem>> GetTupleListDiemListDiem_22()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetDouble_23()
		{
			return _return_63._return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double Lv2()
		{
			return _return_63._return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> CNv2()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_24(List<diem> cn)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_25(List<diem> cn)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_26()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimPhaiDocMB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimPhaiNgangMB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimTraiMB(bool forForm = false, bool outSide = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimDuoiMB(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetTupleListDiemDiem_27(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetTupleListDiemDiem_28(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimDuoiMBCad()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimTrenMB(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetTupleListDiemDiem_29(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetTupleListDiemDiem_30(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetListPDimTrenMBCad()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem> GetTupleListDiemDiem_31(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListPCaoTrinh()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> GetListLineThepNoiThangCu()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<diem>> GetListLineThepNoiThangCuGiua()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_32()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiem_33()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetInt_34()
		{
			return _return_63;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> GetListTextCaoTrinh()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_35(bool zz = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_36(bool zz = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_37(bool zz = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_38(bool zz = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_39(bool zz = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_40(bool zz = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VeMatBangAutoCad(diem goc, ref int stt)
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.IndexOutOfRangeException: Index was outside the bounds of the array.
			//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
			//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<List<diem>>, List<Line_diem>> GetTupleListListDiemListLineDiem_41(diem pDau, List<diem> bao, bool isCN, bool isZigZac = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CauThang()
		{
			AppClass_016.uQ4DbMFRj7Q();
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								AppClass_054.IveTMUdyS5E();
								num3 = 6;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4e8e93c04498476f95f43d6dbed4b259 == _return_63)
								{
									num3 = 2;
								}
								continue;
							}
							goto _goto_69;
						case _return_63:
							break;
						case 2:
							return;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_63;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5354e5bae32049e686b15543bf645935 != _return_63)
							{
								num3 = 5;
							}
							continue;
						}
						goto _goto_70;
						continue;
						_goto_69:
						break;
					}
					continue;
					_goto_70:
					break;
				}
				while (num2 == 990);
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0295e339d21b49f5ae3dea1307c6082a == _return_63)
				{
					num = 7;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_42()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CauThang GetCauthang_43()
		{
			return null;
		}
	}

	public static double _double_66;

	public static List<Line_diem> _listLineDiem_67;

	internal static cau_thang_new _cauThangNew_68;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cau_thang_new()
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
					default:
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto _goto_69;
							}
							goto case 4;
						}
						AppClass_051.f8oTg3pM5fk();
						num3 = 5;
						continue;
					case 1:
						AppClass_016.TqZDb19vgxf();
						num3 = 12;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5ab3671b1a5b4ded9b7d5dd14f4fc909 == _return_63)
						{
							num3 = _return_63;
						}
						continue;
					case 2:
						break;
					case 4:
						_listLineDiem_67 = new List<Line_diem>();
						num3 = 10;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 == _return_63)
						{
							num3 = 3;
						}
						continue;
					case 5:
						_double_66 = 200._return_63;
						num3 = 4;
						continue;
					case 3:
						return;
					case _return_63:
						AppClass_016.QB3DbWPnHbY();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 == _return_63)
						{
							num3 = 9;
						}
						continue;
					}
					goto _goto_70;
					continue;
					_goto_69:
					break;
				}
				continue;
				_goto_70:
				break;
			}
			AppClass_054.IveTMUdyS5E();
			num = 7;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_11280a854fde41d3a138fa46847165c7 == _return_63)
			{
				num = 12;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_44()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static cau_thang_new GetCauThangNew_45()
	{
		return null;
	}
}
