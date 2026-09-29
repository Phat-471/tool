using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_14
{
	public class InfoRaiMong
	{
		public diem pointGoc;

		public object _object_2;

		public PolygonModule.Polygon plCoc;

		public int soCoc;

		public string _string_3;

		public AppClass_350.AppClass_357 cotChiuTai;

		public double angXoay;

		public string TenMong;

		public AppClass_350.ViTriDatTen viTriDatTen;

		private static InfoRaiMong _inforaimong_4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoRaiMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TinhToanMong()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Tuple<diem, string>> GetListPSelect()
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
		public diem GetDiem_10(string name)
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
		static InfoRaiMong()
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
									goto _goto_35;
								}
								goto case 1;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 9;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						case 2:
							return;
						}
						goto _goto_36;
						continue;
						_goto_35:
						break;
					}
					continue;
					_goto_36:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_420aff19babf4086bddd3243df310fb2 == 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_2()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InfoRaiMong GetInforaimong_3()
		{
			return null;
		}
	}

	public class RaiMongJig : DrawJig, IDisposable
	{
		public PolygonModule.Polygon polyMong;

		public List<PolygonModule.Polygon> _polygon_7;

		public PolygonModule.Polygon _polygon_8;

		public List<diem> lpCoc;

		public PolygonModule.Polygon plCoc;

		public diem _diem_9;

		public diem choosingPoint;

		internal static RaiMongJig _raimongjig_10;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RaiMongJig(PolygonModule.Polygon poly, diem _diem_9, List<diem> lpCoc = null, PolygonModule.Polygon plCoc = null, List<PolygonModule.Polygon> _polygon_7 = null, PolygonModule.Polygon _polygon_8 = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_4(IsValid_6 P_0, PolygonModule.Polygon P_1, string P_2 = "")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_5(IsValid_6 P_0, PolygonModule.Polygon P_1, diem P_2, diem P_3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsValid_6(IsValid_6 draw)
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
		public void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RaiMongJig()
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
									goto _goto_35;
								}
								goto case 2;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							continue;
						case 0:
							return;
						case 1:
							break;
						case 2:
							AppClass_054.IveTMUdyS5E();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_9b8a3fa59b0643a9a005e0e055caa087 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto _goto_36;
						continue;
						_goto_35:
						break;
					}
					continue;
					_goto_36:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_934fee42d4914438a301122ea3a645b4 == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_7()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RaiMongJig GetRaimongjig_8()
		{
			return null;
		}
	}

	public class GetStatic_11
	{
		public diem pointGoc;

		public PolygonModule.Polygon plBeTongLot;

		public PolygonModule.Polygon _polygon_13;

		public PolygonModule.Polygon plDinhMong;

		public PolygonModule.Polygon plCot;

		public List<PolygonModule.CurveXYZ> _curvexyz_14;

		public string TenMong;

		public AppClass_350.ViTriDatTen viTriDatTen;

		public double _double_15;

		public double _double_16;

		public double _double_17;

		public double _double_18;

		public double _double_19;

		public double _double_20;

		public double _double_21;

		public double _double_22;

		public double _double_23;

		public double _double_24;

		public double _double_25;

		public double _double_26;

		public double _double_27;

		public double _double_28;

		public string CT1;

		public string _string_29;

		public string H12;

		public string Cover;

		public string ThepPhuongX;

		public string ThepPhuongY;

		internal static GetStatic_11 _appclass343_30;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_11()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TinhToanMong(diem gocCot = null, diem mainVecto = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Translate(diem tranVec)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate(diem center, double angle)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PolygonModule.CurveXYZ> GetListCurveDim()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Tuple<diem, string>> GetListPSelect()
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
		public diem GetDiem_10(string name)
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
		static GetStatic_11()
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
									goto _goto_35;
								}
								goto case 1;
							}
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f3ac95ce65f94a83a1cd47135b4f417c == 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_24719cccbece427b9ca340b0b8914683 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						}
						goto _goto_36;
						continue;
						_goto_35:
						break;
					}
					continue;
					_goto_36:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 != 0)
				{
					num = 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_12()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_11 GetAppclass343_13()
		{
			return null;
		}
	}

	public static Form_Rai_Mong formRaiMong;

	public static InfoRaiMong info_rai_mong;

	public static GetStatic_11 _appclass343_33;

	internal static GetStatic_14 _appclass342_34;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_14()
	{
		AppClass_016.uQ4DbMFRj7Q();
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
					default:
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto _goto_35;
							}
							goto case 1;
						}
						AppClass_054.IveTMUdyS5E();
						num3 = 6;
						continue;
					case 4:
						return;
					case 6:
						AppClass_051.f8oTg3pM5fk();
						num3 = 13;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e761100d2cf44e67808f34385eabece7 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						formRaiMong = new Form_Rai_Mong();
						num3 = 5;
						continue;
					case 1:
						_appclass343_33 = new GetStatic_11();
						num3 = 11;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 == 0)
						{
							num3 = 4;
						}
						continue;
					case 5:
						info_rai_mong = new InfoRaiMong();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bb69b688ab23416fb5187846886dbbdf == 0)
						{
							num3 = 3;
						}
						continue;
					case 2:
						break;
					case 3:
						AppClass_016.TqZDb19vgxf();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1bb5ff26f66e45b88c875a1813f40f77 != 0)
						{
							num3 = 2;
						}
						continue;
					}
					goto _goto_36;
					continue;
					_goto_35:
					break;
				}
				continue;
				_goto_36:
				break;
			}
			AppClass_016.QB3DbWPnHbY();
			num = 13;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3da03e4d215640aab6fa9268d1200d6d != 0)
			{
				num = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_15()
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
	internal static bool IsValid_16()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_14 GetAppclass342_17()
	{
		return null;
	}
}
