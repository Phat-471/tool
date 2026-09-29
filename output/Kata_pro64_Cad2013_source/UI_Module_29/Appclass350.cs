using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Autodesk.AutoCAD.DatabaseServices;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_80
{
	public enum AppEnum_351
	{
		Normal,
		MongCoc,
		MongBang,
		MongDon
	}

	public class GetStatic_6
	{
		public diem pointGoc;

		public List<GetStatic_61> listCotChiuTai;

		public List<CocChiuTai> listCocInput;

		public PolygonModule.Polygon ranhTamCoc;

		public PolygonModule.Polygon ranhBoTriDai;

		public double _double_2;

		public double _double_3;

		public int soCocToiThieu;

		public string _string_4;

		public string TienTo;

		public int SoBatDau;

		public ViTriDatTen viTriDatTen;

		public diem mainVecto;

		private static GetStatic_6 _appclass352_5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_6()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_6 CloneForUndo()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_65()
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
		public double GetDouble_3(CocChiuTai coc)
		{
			return _return_47._return_47;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PolygonModule.Polygon GetPolygon_66()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReOrder(bool orderTheoTenMong = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_5()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GanId()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GanTenMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_6()
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
									goto _goto_78;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 7;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_940333e31a9544d6808222d9f4b418f3 == _return_47)
							{
								num3 = _return_47;
							}
							continue;
						case _return_47:
							AppClass_016.QB3DbWPnHbY();
							num3 = 8;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_23ef80aa2deb4a7baaac6de0becd9a10 == _return_47)
							{
								num3 = 2;
							}
							continue;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_02eb9f97d81c4e8f82591f5f747031ca != _return_47)
				{
					num = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_7()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_6 GetAppclass352_8()
		{
			return null;
		}
	}

	public enum ViTriCurveDam
	{
		Trai,
		Phai,
		Dau,
		Cuoi
	}

	public class GetStatic_10
	{
		public string _string_8;

		public string _string_9;

		public string _string_10;

		public string _string_11;

		internal static GetStatic_10 _appclass353_12;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_10()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_10()
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
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f09347d075a54e3c9e3affc36c5644b5 == _return_47)
								{
									num3 = 8;
								}
								continue;
							}
							goto _goto_78;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_86bd1bfcffba4d48bfb7f8f798e9fed8 != _return_47)
							{
								num3 = 6;
							}
							continue;
						case _return_47:
							break;
						case 2:
							return;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				while (num2 == 990);
				AppClass_016.QB3DbWPnHbY();
				num = 2;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_d9209192fb5a48db8afe33275173f36c == _return_47)
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
		internal static GetStatic_10 GetAppclass353_12()
		{
			return null;
		}
	}

	public class GetStatic_23
	{
		public diem pointGoc;

		public List<Info_Beam3D> listDamInput;

		public Dictionary<int, Tuple<string, string, string, string>> listLength;

		public List<PolygonModule.Polygon> listBaoNgoai;

		public List<PolygonModule.Polygon> listBaoTrong;

		public List<PolygonModule.Polygon> _polygon_15;

		public PolygonModule.Polygon ranhBoTriDai;

		public GetStatic_35 infoChung;

		public GetStatic_10 areaSpring;

		public List<PolygonModule.Polygon> _polygon_16;

		public List<PolygonModule.CurveXYZ> listLineCheo;

		public List<List<PolygonModule.CurveXYZ>> llDim;

		private static GetStatic_23 _appclass354_17;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_23()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetJsonStringMong()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_14(ref Info_Beam3D P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private double GetDouble_15(diem P_0, diem P_1)
		{
			return _return_47._return_47;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_16(ref PolygonModule.Polygon P_0, double P_1, double P_2, double P_3, double P_4)
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.IndexOutOfRangeException: Index was outside the bounds of the array.
			//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 68
			//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_17(List<PolygonModule.Polygon> P_0)
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
		private void ExecuteAction_18()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private double GetDouble_19(PolygonModule.CurveXYZ P_0)
		{
			return _return_47._return_47;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_20(string txtTrai, string txtPhai, string txtDau, string txtCuoi)
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
		public void ExecuteAction_21()
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
		public void AssignListLengthToListDam()
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
		public PolygonModule.Polygon GetPolygon_66()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_23()
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
									goto _goto_78;
								}
								goto case 1;
							}
							return;
						case _return_47:
							break;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c660b2a9f2294e84996cb208a4355bde == _return_47)
							{
								num3 = 6;
							}
							continue;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e953190ed2f64b37a09a51d9a33874ca == _return_47)
							{
								num3 = 1;
							}
							continue;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b164162b8046492994d14f0299ed7153 == _return_47)
				{
					num = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_24()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_23 GetAppclass354_25()
		{
			return null;
		}
	}

	public enum ViTriDatTen
	{
		Trai,
		Phai,
		Tren,
		Duoi
	}

	public class CocChiuTai
	{
		public object _object_20;

		public double sucChiuTaiCoc;

		public PolygonModule.Polygon plCoc;

		public double diaCoc;

		public double chieuDaiCoc;

		public double giaTienCoc;

		public int soLuong;

		public string tenCoc;

		public diem center;

		public diem newPosition;

		private static CocChiuTai _cocchiutai_21;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CocChiuTai()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CocChiuTai Clone(diem newPos = null)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CocChiuTai CloneForUndo(diem newPos = null)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetJsonString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CocChiuTai()
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
									goto _goto_78;
								}
								goto case 2;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_445fae76259b44779166efa3d5fe6733 != _return_47)
							{
								num3 = 6;
							}
							continue;
						case 1:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_45f32ad850874067906bcaad9130e115 == _return_47)
							{
								num3 = 1;
							}
							continue;
						case _return_47:
							return;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_26()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CocChiuTai GetCocchiutai_27()
		{
			return null;
		}
	}

	public class InfoText
	{
		public object _object_24;

		public string text;

		public diem position;

		private static InfoText _infotext_25;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoText()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoText()
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
						case 1:
							goto _goto_79;
						case _return_47:
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 5;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 != _return_47)
							{
								num3 = 1;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0295e339d21b49f5ae3dea1307c6082a == _return_47)
							{
								num3 = 7;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_28()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoText GetInfotext_29()
		{
			return null;
		}
	}

	public class GetStatic_31
	{
		public string tenMong;

		public string _string_58;

		public bool isCotGop;

		public diem mainVecto;

		public AppClass_290.ThepBoTriMong duoiDoc;

		public AppClass_290.ThepBoTriMong duoiNgang;

		public AppClass_290.ThepBoTriMong trenDoc;

		public AppClass_290.ThepBoTriMong trenNgang;

		public CocChiuTai cocChiuTai;

		public bool isVacMong;

		public string mauMong;

		internal static GetStatic_31 _appclass355_28;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_31()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_31()
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
									goto _goto_78;
								}
								goto case 2;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_00f0a279ec4b44848c113e5f3a57df39 == _return_47)
							{
								num3 = _return_47;
							}
							continue;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							continue;
						case _return_47:
							return;
						case 1:
							break;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 == _return_47)
				{
					num = _return_47;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_32()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_31 GetAppclass355_33()
		{
			return null;
		}
	}

	public class GetStatic_35
	{
		public string btl;

		public string _string_59;

		public string HBatDayMong;

		public string HMong;

		public string Cover;

		private static GetStatic_35 _appclass356_32;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_35()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_35()
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
									goto _goto_78;
								}
								goto case 2;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 != _return_47)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						case _return_47:
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e761100d2cf44e67808f34385eabece7 != _return_47)
							{
								num3 = _return_47;
							}
							continue;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 7;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c16368ee47214a3ea92e8fd02e53deed == _return_47)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_36()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_35 GetAppclass356_37()
		{
			return null;
		}
	}

	public class GetStatic_61
	{
		public bool _bool_35;

		public bool isCotGop;

		public diem mainVecto;

		public bool needAutoGen;

		public bool _bool_36;

		public bool _bool_37;

		public bool _bool_38;

		public bool _bool_39;

		public PolygonModule.Polygon plCot;

		public diem centerGravity;

		public string _string_58;

		public List<InfoText> _listInfotext_41;

		public int soCoc;

		public CocChiuTai cocInput;

		public double chieuCaoMong;

		public bool isVacMong;

		public string mauMong;

		public int _int_42;

		public int id;

		public double angXoay;

		public List<PolygonModule.Polygon> _polygon_43;

		public List<PolygonModule.Polygon> listCotOthers;

		public object obj;

		public PolygonModule.Polygon _polygon_54;

		public List<CocChiuTai> listCoc;

		public bool isDungTam;

		public string tenMong;

		public AppClass_290.ThepBoTriMong duoiDoc;

		public AppClass_290.ThepBoTriMong duoiNgang;

		public AppClass_290.ThepBoTriMong trenDoc;

		public AppClass_290.ThepBoTriMong trenNgang;

		private static GetStatic_61 _appclass357_45;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetObject_38()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_61 CloneForUndo()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetJsonStringMong()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_61()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_61(PolygonModule.Polygon pl, string luc, List<InfoText> listLucDoc)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegenCenter()
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
		public bool IsDifferent(GetStatic_61 cot)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tuple<PolygonModule.Polygon, List<CocChiuTai>> GetPolygonListCocchiutai_41(int P_0, diem P_1, CocChiuTai P_2, string P_3)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PolygonModule.Polygon GetPolygon_42(List<diem> P_0, double P_1)
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
		private List<CocChiuTai> GetListCocchiutai_43(List<diem> P_0)
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
		public List<string> GetListMauMongText(int numcoc)
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
		private string GetString_44(List<int> P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<int> GetListInt_45(string P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tuple<PolygonModule.Polygon, List<diem>> GetPolygonListDiem_46(List<int> P_0, diem P_1, diem P_2, double P_3, double P_4, double P_5)
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
		public List<Tuple<PolygonModule.Polygon, List<diem>>> ListPlMongCanAssign(int numcoc, string kcDenMepDai)
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
		private List<List<int>> GetListListInt_47(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetInt_48(List<int> P_0)
		{
			return _return_47;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<int> GetListInt_49(List<int> P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsValid_50(List<int> P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid_51()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<diem> GetListDiemTatCaCot()
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
		public List<diem> GetListDiemCotNamNgoaiMong()
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
		public void ExecuteAction_52(int numCoc, diem mainVecto, PolygonModule.Polygon ranhBoTriDai, PolygonModule.Polygon ranhTamCoc, string kcDenMepDai)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RaiDeuCoc(List<CocChiuTai> danhSachCocGoc, bool compactChoVuongVuc = false, bool isDoiCocDeCotNamTrong = true)
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
		private Tuple<int, int> GetTupleIntInt_53(HashSet<Tuple<int, int>> P_0, HashSet<Tuple<int, int>> P_1, List<diem> P_2, double P_3, diem P_4)
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
		public void ExecuteAction_54(int soLuongXoa)
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
		public void ExecuteAction_55(int soLuongThem)
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
		private Tuple<int, int> GetTupleIntInt_56(Tuple<int, int> P_0, HashSet<Tuple<int, int>> P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetInt_57(Tuple<int, int> P_0, HashSet<Tuple<int, int>> P_1, Tuple<int, int> P_2 = null)
		{
			return _return_47;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<CocChiuTai> GetListCocchiutai_58(HashSet<Tuple<int, int>> P_0, diem P_1, double P_2, CocChiuTai P_3, diem P_4)
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
		public void ExecuteAction_59(double kcDenMepDai, List<diem> listPAdd = null)
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
		public void ExecuteAction_60(double kcDenMepDai, List<diem> listPAdd = null)
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
		public void Translate(diem v)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate(double angle)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public diem AlignToRanh(PolygonModule.Polygon ranhBoTriDai, PolygonModule.Polygon ranhTamCoc)
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
		static GetStatic_61()
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
									goto _goto_78;
								}
								goto case 1;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 7;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3da03e4d215640aab6fa9268d1200d6d == _return_47)
							{
								num3 = 1;
							}
							continue;
						case _return_47:
							return;
						case 1:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b == _return_47)
							{
								num3 = _return_47;
							}
							continue;
						case 2:
							break;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_705374da7b0748cf8df80d00725571db != _return_47)
				{
					num = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_62()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_61 GetAppclass357_63()
		{
			return null;
		}
	}

	public class GetStatic_67
	{
		public diem pointGoc;

		public List<GetStatic_73> listCotChiuTai;

		public PolygonModule.Polygon ranhBoTriDai;

		public string TienTo;

		public int SoBatDau;

		public ViTriDatTen viTriDatTen;

		public GetStatic_10 areaSpring;

		public List<PolygonModule.Polygon> _polygon_50;

		internal static GetStatic_67 _appclass358_51;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_67()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteAction_65(bool firstTime = false, string traiTxt = "", string phaiTxt = "", string trenTxt = "", string duoiTxt = "")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PolygonModule.Polygon GetPolygon_66()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GanTenMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_67()
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
									goto _goto_78;
								}
								goto case 2;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 6;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6639d8e551bd44619b5ef505e18c8532 != _return_47)
							{
								num3 = _return_47;
							}
							continue;
						case 1:
							break;
						case _return_47:
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							continue;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c57d245498d44fafb6366861203ffcfd == _return_47)
				{
					num = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_68()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_67 GetAppclass358_69()
		{
			return null;
		}
	}

	public class GetStatic_73
	{
		public PolygonModule.Polygon _polygon_54;

		public object _object_55;

		public PolygonModule.Polygon plCot;

		public diem centerGravity;

		public diem xVec;

		public diem yVec;

		public double _double_56;

		public double _double_57;

		public string _string_58;

		public int index;

		public string Trai;

		public string Phai;

		public string Tren;

		public string Duoi;

		public string btl;

		public string _string_59;

		public string HBatDayMong;

		public string HMong;

		public string _string_60;

		public string Cover;

		public string ThepPhuongX;

		public string ThepPhuongY;

		public AppClass_342.AppClass_343 infoMong;

		private static GetStatic_73 _appclass359_61;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_73()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_73(PolygonModule.Polygon pl, string luc)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegenInfoMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetString_72()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsDifferent(GetStatic_73 cot)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_73()
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
							goto _goto_78;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_47;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_503f8440945048439eaf3928584c889a == _return_47)
							{
								num3 = 6;
							}
							continue;
						case _return_47:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							continue;
						case 2:
							break;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				while (num2 == 990);
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 == _return_47)
				{
					num = _return_47;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_74()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_73 GetAppclass359_75()
		{
			return null;
		}
	}

	public enum AppEnum_360
	{
		GiuNguyenBaoMong,
		TaoBaoMongBaoNgoai,
		TaoBaoMongVac
	}

	public class Form_Update_Dai_Mong_Bao_Coc : Form
	{
		private readonly TextBox _textbox_64;

		private readonly TextBox _textbox_65;

		private readonly TextBox _textbox_66;

		private readonly ComboBox _combobox_67;

		private readonly Button _button_68;

		private readonly Button _button_69;

		private readonly List<AppEnum_360> _listAppenum360_70;

		internal static Form_Update_Dai_Mong_Bao_Coc _formUpdateDaiMongBaoCoc_71;

		public string TenMong
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public string HMongText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public string KcDenMepDaiText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public AppEnum_360 KieuTao
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AppEnum_360)(object)null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Form_Update_Dai_Mong_Bao_Coc(string defaultTenMong, string defaultHMong, string defaultKcDenMepDai, bool choPhepGiuNguyenBaoMong)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_76(string P_0, AppEnum_360 P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HandleEvent_77(object P_0, EventArgs P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Form_Update_Dai_Mong_Bao_Coc()
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
									goto _goto_78;
								}
								goto case 2;
							}
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_25e2f9f2e00c4736bd789b594bd2faa3 != _return_47)
							{
								num3 = 5;
							}
							continue;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = 7;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fda9dec917b14c45931e0d4eb71de6b8 == _return_47)
							{
								num3 = _return_47;
							}
							continue;
						case _return_47:
							break;
						}
						goto _goto_79;
						continue;
						_goto_78:
						break;
					}
					continue;
					_goto_79:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988 == _return_47)
				{
					num = 8;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_78()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Form_Update_Dai_Mong_Bao_Coc GetFormUpdateDaiMongBaoCoc_79()
		{
			return null;
		}
	}

	public static Form_Ve_Mat_Bang_Mong formVeMatBangMong;

	public static GetStatic_6 _appclass352_74;

	public static GetStatic_23 _appclass354_75;

	public static GetStatic_67 _appclass358_76;

	public static string LOAIDATACOC;

	public static string LOAIDATAJOINTREACTION;

	public static string LOAIDATAMBMONGCOC;

	public static string LOAIDATAMBMONGBANG;

	public static string LOAIDATALINECHEO;

	internal static GetStatic_80 _appclass350_77;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_80()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 11;
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto _goto_78;
							}
							goto case 6;
						}
						LOAIDATAMBMONGCOC = AppClass_016.QqFDbr6RL7F(--1245881696 ^ 0x19E8AD9D ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9);
						num3 = 5;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bee00e7049644e96b9f0679762a49ac6 == _return_47)
						{
							num3 = 3;
						}
						continue;
					case 10:
						AppClass_016.QB3DbWPnHbY();
						num3 = _return_47;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b164162b8046492994d14f0299ed7153 == _return_47)
						{
							num3 = 13;
						}
						continue;
					case 4:
						LOAIDATACOC = AppClass_016.QqFDbr6RL7F(0x7A0DCFF7 ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944);
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_559789cacd7f46ac973fb693ed94037f == _return_47)
						{
							num3 = 1;
						}
						continue;
					case 3:
						_appclass358_76 = new GetStatic_67();
						num3 = 4;
						continue;
					case 1:
						LOAIDATALINECHEO = AppClass_016.QqFDbr6RL7F(0x117C158C ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_28f7376b2f5c4626b68ba1f8e68d9ff7);
						num3 = 5;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2c174d0d9ac34a6c933e3a665cf63f30 == _return_47)
						{
							num3 = 8;
						}
						continue;
					case 8:
						return;
					case 11:
						AppClass_016.TqZDb19vgxf();
						num3 = 10;
						continue;
					case _return_47:
						AppClass_054.IveTMUdyS5E();
						num3 = 12;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 == _return_47)
						{
							num3 = 5;
						}
						continue;
					case 5:
						LOAIDATAMBMONGBANG = AppClass_016.QqFDbr6RL7F(0x36BE67CE ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_420aff19babf4086bddd3243df310fb2);
						num3 = 17;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 == _return_47)
						{
							num3 = 1;
						}
						continue;
					case 6:
						_appclass354_75 = new GetStatic_23();
						num3 = 3;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_d2365fb7fd684b7e8d483432972c9023 != _return_47)
						{
							num3 = 17;
						}
						continue;
					case 9:
						formVeMatBangMong = new Form_Ve_Mat_Bang_Mong();
						num3 = 2;
						continue;
					case 7:
						LOAIDATAJOINTREACTION = AppClass_016.QqFDbr6RL7F(0x384038AA ^ AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4c55e99b69ce444aab2045602ec049f1);
						num = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bee00e7049644e96b9f0679762a49ac6 != _return_47)
						{
							num = 19;
						}
						break;
					case 2:
						_appclass352_74 = new GetStatic_6();
						num3 = 6;
						continue;
					case 12:
						AppClass_051.f8oTg3pM5fk();
						num = 9;
						break;
					}
					goto _goto_79;
					continue;
					_goto_78:
					break;
				}
				continue;
				_goto_79:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static diem GetDiem_81(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PolygonModule.Polygon GetPolygon_82(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static InfoText GetInfotext_83(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static AppClass_290.ThepBoTriMong GetThepbotrimong_84(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ViTriDatTen GetVitridatten_85(int index)
	{
		return (ViTriDatTen)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<CocChiuTai> Edit_Coc()
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
	private static Polyline GetPolyline_86(object P_0)
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
	private static double GetDouble_87(object P_0)
	{
		return _return_47._return_47;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetString_88(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ObjectId EnsureBlockMongCoc(GetStatic_61 cot, ref diem insertPoint, ref double rotation)
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
	public static object InsertBlockMongCoc(ObjectId blockId, diem insertPoint, double rotation, string layer = null, int color = -1)
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
	public static void PhaMong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<object> PhaBlockMong(object blockMong, bool eraseBlockGoc = true)
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
	public static bool IsValid_89(object sset)
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
	public static void ExecuteAction_90()
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
	internal static bool IsValid_91()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_80 GetAppclass350_92()
	{
		return null;
	}
}
