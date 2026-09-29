using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Kata_Class_Lib_Revit;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class GetStatic_5
{
	private object _object_2;

	private static GetStatic_5 _appclass264_3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetStatic_5()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetMbkcFromCad(ref List<Info_Beam3D> tap_Beam3D, ref List<Info_ColumnWall3D> tap_Column3D, ref List<Bien_chung.info_revit_slab> tap_san, ref List<info_CurveGrid> tap_grid, [Optional][DefaultParameterValue(null)] ref List<AppClass_350.CocChiuTai> tapCoc, [Optional][DefaultParameterValue(null)] ref List<AppClass_350.AppClass_357> tapMongCoc, [Optional][DefaultParameterValue(null)] ref List<AppClass_350.InfoText> tapText, [Optional][DefaultParameterValue(null)] ref PolygonModule.Polygon ranh_coc, [Optional][DefaultParameterValue(null)] ref PolygonModule.Polygon ranh_dai, [Optional][DefaultParameterValue(false)] bool xoaTextLayerTextCu, [Optional][DefaultParameterValue(null)] ref List<Info_Beam3D> tap_wall, [Optional][DefaultParameterValue(false)] bool get_Loads, [Optional][DefaultParameterValue(null)] List<object> tap_Others, [Optional][DefaultParameterValue(false)] bool xoaTextHighlightCu, [Optional][DefaultParameterValue(null)] ref List<AppClass_350.AppClass_359> tapMongDon, [Optional][DefaultParameterValue(null)] ref AppClass_350.AppClass_354 mongBang)
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
	private AppClass_350.AppClass_357 GetAppclass357_2(object P_0)
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
	private AppClass_350.CocChiuTai GetCocchiutai_3(BlockReference P_0, AppClass_350.CocChiuTai P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PolygonModule.Polygon GetPolygon_4(BlockReference P_0)
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
	private void Ny7BKnPgogi(ref List<Info_ColumnWall3D> P_0, ref List<Info_Beam3D> P_1, ref List<Info_Beam3D> P_2, ref SortedDictionary<string, info_SecondBeam> P_3, ref Dictionary<string, Info_Slab3D> P_4, ref Dictionary<PolygonModule.Polygon, (string, string, double)> P_5, ref Dictionary<diem, Dictionary<string, string>> P_6)
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
	static GetStatic_5()
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
								goto _goto_4;
							}
							goto case 0;
						}
						AppClass_016.QB3DbWPnHbY();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bee00e7049644e96b9f0679762a49ac6 == 0)
						{
							num3 = 8;
						}
						continue;
					case 1:
						break;
					case 2:
						return;
					case 0:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_65a7ac1c0bf44e6a8d0c0e4677c3046a != 0)
						{
							num3 = 8;
						}
						continue;
					}
					goto _goto_5;
					continue;
					_goto_4:
					break;
				}
				continue;
				_goto_5:
				break;
			}
			AppClass_016.TqZDb19vgxf();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 != 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_6()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_5 GetAppclass264_7()
	{
		return null;
	}
}
