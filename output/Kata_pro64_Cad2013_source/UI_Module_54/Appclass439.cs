using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Module_21;
using Kata_Class_Lib_Revit;
using UI_Module_29;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;
using UI_Module_43;

namespace _namespace_1;

[StandardModule]
internal sealed class GetStatic_29
{
	public enum AppEnum_440
	{

	}

	public enum AppEnum_441
	{

	}

	public enum AppEnum_442
	{

	}

	public enum AppEnum_443
	{

	}

	public enum AppEnum_444
	{

	}

	public enum AppEnum_445
	{

	}

	public class GetStatic_3 : diem
	{
		public AppEnum_445 _appenum445_2;

		private static object _object_3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_3(diem P_0, AppEnum_445 P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AppEnum_445 GetAppenum445_2()
		{
			return (AppEnum_445)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_3()
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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_106;
								}
								goto case 2;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c9fe3f02f7e845bd8d8e0e7e226ffca4 != 0)
							{
								num3 = 2;
							}
							continue;
						case 0:
							return;
						case 2:
							AppClass_054.IveTMUdyS5E();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_919abade73404e77ba08bace63d9b14c != 0)
							{
								num3 = 5;
							}
							continue;
						case 1:
							break;
						}
						goto _goto_107;
						continue;
						_goto_106:
						break;
					}
					continue;
					_goto_107:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 7;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_663d2796725d4befbd1d1da2287dccb6 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_4()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_3 GetAppclass446_5()
		{
			return null;
		}
	}

	public class VachDon
	{
		public double cover;

		public object duongBao;

		public object pointGoc;

		public object xvecto;

		public object yvecto;

		public object dimtagvecto;

		public double scale;

		public object _object_6;

		public double x;

		public double y;

		public object ten;

		public object newten;

		public object vungBienText;

		public object DkTCLBienText;

		public object DkTCLGiuaText;

		public bool coDaiBien;

		public object polyBienTrai;

		public object polyBienPhai;

		public double _double_7;

		public double _double_8;

		public double realx1;

		public double realx3;

		public double _double_9;

		public double a1Day;

		public double _double_10;

		public double a2Day;

		public double _double_11;

		public double a3Day;

		public double _double_12;

		public double _double_13;

		public double _double_14;

		public AppEnum_440 kieuDaiGC;

		public double a1tcl;

		public double a2tcl;

		public double a3tcl;

		public double f1tcl;

		public double f2tcl;

		public double f3tcl;

		public List<diem> _listDiem_15;

		public int _int_16;

		public bool _bool_17;

		public AppEnum_442 kieuRaiDai;

		public List<int> _listInt_18;

		public List<int> _listInt_19;

		public double fDaiC;

		public double aDaiC;

		public bool isGiaoAtPhai;

		public bool isGiaoAtTrai;

		public object _object_20;

		public object _object_21;

		public bool isGopBenPhai;

		public bool isGopBenTrai;

		public object _object_22;

		public object tbx1;

		public object tbx2;

		public object tbx3;

		private static object _object_23;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VachDon()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VachDon Clone()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<double, double, double> GetfaDaiVong(int index)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<double, double> GetfaChiuLuc(int index)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TenKieuRai()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AppEnum_442 GetAppenum442_6(string kieu)
		{
			return (AppEnum_442)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string TenKieuDaiGiaCuong(bool xetkieuKhac = false, AppEnum_440 kieuKhac = (AppEnum_440)0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AppEnum_440 GetAppenum440_7(string kieu)
		{
			return (AppEnum_440)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetNhipDaiBienText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDaiGiaCuongCText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetNhipDaiBaoText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetNhipTLCBienText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetNhipPhaiTLCText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetNhipTLCGiuaText()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<double, double, double, double, double, double> GetTupleDoubleDoubleDoubleDoubleDoubleDouble_8()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetDouble_9(double L13, double realX)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<diem>, diem, diem> GetListPDim(bool forForm = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Tuple<PolygonModule.Polygon, AppEnum_443, List<PolygonModule.CurveXYZ>>> GetListThepDaiVong()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tuple<PolygonModule.Polygon, List<PolygonModule.CurveXYZ>> GetDaiVongVaListCurveCanhDai(double start, double ending)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<PolygonModule.CurveXYZ> GetListCurveCanhDai(double start, double ending)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PolygonModule.Polygon GetBao(double start, double ending)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tuple<List<GetStatic_3>, List<PolygonModule.CurveXYZ>, List<GetStatic_3>, List<GetStatic_3>, List<GetStatic_3>, List<PolygonModule.Polygon>> GetPolygon_10()
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
		public Tuple<List<GetStatic_3>, List<PolygonModule.CurveXYZ>> GetListPointTCLRaiDeu(PolygonModule.Polygon pl, double spacing, double bvDau, double bvCuoi, double bvy, bool boThanhDau = false, bool boThanhCuoi = false, bool checkTrai = false, bool checkPhai = false)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VachDon()
		{
			AppClass_016.uQ4DbMFRj7Q();
			int num = 2;
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
								num3 = 0;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_23ef80aa2deb4a7baaac6de0becd9a10 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto _goto_106;
						case 1:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 5;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0ba42bd2348344eaadcfdc98ba87d4f0 == 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
						}
						goto _goto_107;
						continue;
						_goto_106:
						break;
					}
					continue;
					_goto_107:
					break;
				}
				while (num2 == 990);
				AppClass_016.QB3DbWPnHbY();
				num = 3;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_7b8aeed32af146098fab5f422ce25d24 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_11()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static VachDon GetVachdon_12()
		{
			return null;
		}
	}

	public class InfoLoiVach
	{
		public object tenLoiVach;

		public int _int_26;

		public List<PolygonModule.Polygon> ListMainPolygon;

		public object BoundingBoxBottomLeft;

		public object BoundingBoxTopRight;

		public List<VachDon> ListVachDonOriginal;

		public List<VachDon> ListVachDonFilter;

		public object gocTrenTrai;

		public List<PolygonModule.Polygon> listIntersection;

		public double cover;

		public double _double_27;

		public double _double_28;

		public double limitLength;

		public AppEnum_440 _appenum440_29;

		public AppEnum_441 viTriLapDaiU;

		public double lap;

		public double chieuDaySan;

		public List<Tuple<string, string, string>> dgv2Data;

		public bool Botcheck;

		public bool Topcheck;

		internal static object _object_30;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoLoiVach()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<List<int>> GetListListInt_13()
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
		public void ExecuteAction_14(List<List<int>> listIndex)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VachDon getAllParameterFromTextBoxes(string KCTCLBien, string SlThepVungBienPhuongNgan, bool _bool_17, string DaiGCBien, string KCTCLGiua, string DaiBao, string KRDaiC, string KieuDaiGiaCuong, string DaiGCC, string DkTCLBien, string DkTCLGiua, string vungBien)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<GetStatic_3> GetListPointTCLVungGiao(PolygonModule.Polygon pl)
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
		public List<string> ListTenKieuRai()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> ListTenKieuDaiGiaCuong()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> ListTenViTriLapDaiU()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_15(bool tuDongGopChoMong = false)
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
		public void ExecuteAction_16()
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
		public void FilterListVachDonTheoGiao(bool tuChinhLanDauChoUser = false)
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
		private VachDon GetVachdon_17(VachDon vd)
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
		private double GetDouble_18(VachDon vd, diem vecto, bool isTimDimTagVectoGiao = false)
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
		static InfoLoiVach()
		{
			AppClass_016.uQ4DbMFRj7Q();
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
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_106;
								}
								goto case 2;
							}
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a771e08388354bdfb62e531f5992b6e4 != 0)
							{
								num3 = 9;
							}
							continue;
						case 0:
							break;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto _goto_107;
						continue;
						_goto_106:
						break;
					}
					continue;
					_goto_107:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_19()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoLoiVach GetInfoloivach_20()
		{
			return null;
		}
	}

	public class GetStatic_22
	{
		public double _double_33;

		public object _object_34;

		public object _object_35;

		public object _object_36;

		public object _object_37;

		public object _object_38;

		public bool _bool_39;

		public double _double_40;

		public double _double_41;

		public double _double_42;

		public double _double_43;

		public double _double_44;

		public double _double_45;

		public double _double_46;

		public double _double_47;

		public double _double_48;

		public double _double_49;

		public double _double_50;

		public double _double_51;

		public double _double_52;

		public AppEnum_440 _appenum440_53;

		public double _double_54;

		public double _double_55;

		public double _double_56;

		public double _double_57;

		public double _double_58;

		public double _double_59;

		public List<diem> _listDiem_60;

		public int _int_61;

		public bool _bool_62;

		public AppEnum_442 _appenum442_63;

		public List<int> _listInt_64;

		public List<int> _listInt_65;

		public double _double_66;

		public double _double_67;

		public bool _bool_68;

		public bool _bool_69;

		private static object _object_70;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_22()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VachDon ToNormal()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_22()
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
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_7b47a3ce476644de941f3c07d3c7ccdb == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							return;
						case 0:
							goto _goto_107;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					_goto_107:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_eb61602f220c449987b38149b02fa612 != 0)
				{
					num = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_23()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_22 GetAppclass447_24()
		{
			return null;
		}
	}

	public class GetStatic_26
	{
		public object _object_72;

		public int _int_73;

		public List<GetStatic_22> _listAppclass447_74;

		public List<GetStatic_22> _listAppclass447_75;

		public double _double_76;

		public double _double_77;

		public double _double_78;

		public double _double_79;

		public AppEnum_440 _appenum440_80;

		public AppEnum_441 _appenum441_81;

		public double _double_82;

		public double _double_83;

		public List<Tuple<string, string, string>> lcBnP7qQv8D;

		public bool _bool_84;

		public bool _bool_85;

		internal static object _object_86;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_26()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoLoiVach ToNormal()
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
		static GetStatic_26()
		{
			AppClass_016.uQ4DbMFRj7Q();
			int num = 2;
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
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_eb282d37369b4f6197140b421715178f == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto _goto_106;
						case 0:
							return;
						case 1:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_42524d84b15f453da26a7f97a96dac37 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto _goto_107;
						continue;
						_goto_106:
						break;
					}
					continue;
					_goto_107:
					break;
				}
				while (num2 == 990);
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_45f32ad850874067906bcaad9130e115 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_27()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_26 GetAppclass448_28()
		{
			return null;
		}
	}

	public static object _object_89;

	public static object _object_90;

	public static object _object_91;

	public static object _object_92;

	public static object _object_93;

	public static object _object_94;

	public static object _object_95;

	public static object _object_96;

	public static object _object_97;

	private static object _object_98;

	private static object _object_99;

	private static object _object_100;

	private static object _object_101;

	private static object _object_102;

	private static int _int_103;

	public static object _object_104;

	internal static object _object_105;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_29()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 8;
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
						if (num2 != 22)
						{
							if (num2 == 1003)
							{
								goto _goto_106;
							}
							goto case 15;
						}
						return;
					case 8:
						AppClass_016.TqZDb19vgxf();
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 == 0)
						{
							num3 = 22;
						}
						continue;
					case 9:
						_object_104 = AppClass_016.QqFDbr6RL7F(0x1924F47 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_7efd3e3d79c04b11930475e7b90546d0);
						num = 22;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 != 0)
						{
							num = 20;
						}
						break;
					case 6:
						_object_94 = AppClass_016.QqFDbr6RL7F(0x46959013 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_068fed8884eb4f759ebb34fd2b6f962b);
						num3 = 11;
						continue;
					case 14:
						_object_93 = AppClass_016.QqFDbr6RL7F(-98409037 ^ -465487897 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_78acf557389e4c83804bda1025ad65ea);
						num3 = 6;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 == 0)
						{
							num3 = 12;
						}
						continue;
					case 4:
						_object_97 = AppClass_016.QqFDbr6RL7F(0xB05A16 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b);
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_068fed8884eb4f759ebb34fd2b6f962b != 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						_int_103 = 0;
						num3 = 9;
						continue;
					case 13:
						AppClass_051.f8oTg3pM5fk();
						num3 = 5;
						continue;
					case 5:
						_object_89 = new InfoLoiVach();
						num3 = 12;
						continue;
					case 15:
						_object_91 = AppClass_016.QqFDbr6RL7F(--1092786627 ^ 0x90618CB ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_ab3ed1143116455a9b2cae3133d2e5d3);
						num3 = 10;
						continue;
					case 12:
						_object_90 = new Form_loi_vach();
						num3 = 15;
						continue;
					case 7:
						AppClass_016.QB3DbWPnHbY();
						num3 = 3;
						continue;
					case 3:
						AppClass_054.IveTMUdyS5E();
						num = 13;
						break;
					case 10:
						_object_92 = AppClass_016.QqFDbr6RL7F(0x75C57B88 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1ffce1ae5ca247c08901d03e85fad9fb);
						num3 = 4;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b164162b8046492994d14f0299ed7153 != 0)
						{
							num3 = 14;
						}
						continue;
					case 11:
						_object_95 = AppClass_016.QqFDbr6RL7F(0x2DB220F3 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_97936e966ecc45c89a24b73522132cba);
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e57ad1e8419a431e8d1e6ec991c4f87e == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						_object_98 = new double[3];
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e722010689ee4fbe88edb9e655ec8567 == 0)
						{
							num3 = 19;
						}
						continue;
					case 0:
						_object_96 = AppClass_016.QqFDbr6RL7F(0x1370A3A0 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988);
						num3 = 4;
						continue;
					}
					goto _goto_107;
					continue;
					_goto_106:
					break;
				}
				continue;
				_goto_107:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString_30(AppEnum_441 P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AppEnum_441 GetAppenum441_31(object P_0)
	{
		return (AppEnum_441)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<List<diem>, List<diem>, List<diem>> GetTupleListDiemListDiemListDiem_32(List<GetStatic_3> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static InfoLoiVach GetInfoloivach_33(object P_0)
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
	public static bool IsValid_34(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_35(bool P_0 = false, AppClass_403.AppClass_419 P_1 = null, bool P_2 = false)
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
	public static bool IsValid_36(List<PolygonModule.Polygon> P_0 = null)
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
	public static string GetString_37()
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
	public static List<object> GetListObject_38(List<diem> P_0, object P_1, double P_2, AppEnum_440 P_3, bool P_4 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_39(object P_0, object P_1, List<diem> P_2, object P_3, AppEnum_443 P_4, object P_5, int P_6, double P_7, double P_8, int P_9, bool P_10, AppEnum_440 P_11)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void S8aBh6gHpd0([Optional][DefaultParameterValue(null)] diem P_0, [Optional][DefaultParameterValue(null)] ref AppClass_403.AppClass_419 P_1)
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
	internal static bool IsValid_40()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_29 GetAppclass439_41()
	{
		return null;
	}
}
