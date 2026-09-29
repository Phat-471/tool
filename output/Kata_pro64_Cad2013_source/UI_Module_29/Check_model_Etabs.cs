using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class Check_model_Etabs
{
	private static Dictionary<string, List<List<Info_Beam3D>>> P68BpWk7r1E;

	private static List<Info_ColumnWall3D> _listInfoColumnwall3d_2;

	private static List<Bien_chung.info_revit_slab> _infoRevitSlab_3;

	private static Dictionary<string, PolygonModule.CurveXYZ> PJeBplnqPPb;

	private static Dictionary<string, PolygonModule.CurveXYZ> f5bBpX1UmvV;

	private static Dictionary<string, string> c80BpSxhNbn;

	private static object _object_4;

	private static Check_model_Etabs _checkModelEtabs_5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Check_model_Etabs()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 5;
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto _goto_6;
							}
							goto case 5;
						}
						_object_4 = null;
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4c55e99b69ce444aab2045602ec049f1 == 0)
						{
							num3 = 5;
						}
						continue;
					case 1:
						PJeBplnqPPb = new Dictionary<string, PolygonModule.CurveXYZ>();
						num3 = 3;
						continue;
					case 5:
						AppClass_016.TqZDb19vgxf();
						num3 = 4;
						continue;
					case 3:
						f5bBpX1UmvV = new Dictionary<string, PolygonModule.CurveXYZ>();
						num3 = 6;
						continue;
					case 2:
						AppClass_051.f8oTg3pM5fk();
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_eb282d37369b4f6197140b421715178f == 0)
						{
							num3 = 1;
						}
						continue;
					case 6:
						break;
					case 4:
						AppClass_016.QB3DbWPnHbY();
						num3 = 12;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_215ff6740fce4d6085a4965d450b37ab == 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4a7aa1ebfa9d48cb96217ed16a213684 == 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						return;
					}
					goto _goto_7;
					continue;
					_goto_6:
					break;
				}
				continue;
				_goto_7:
				break;
			}
			c80BpSxhNbn = new Dictionary<string, string>();
			num = 14;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, PolygonModule.CurveXYZ> Get_TapBeamCheck_Cad()
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
	public static Dictionary<string, PolygonModule.CurveXYZ> GetCurvexyz_1()
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
	public static bool Check_DauBeam_CadEtab(diem d1, diem d2, diem d1_Etabs, diem d2_Etabs, int do_lech = 500)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_2()
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
	public static void ExecuteAction_3(int Index)
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
	public static void Check_Etabs_Model()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_4()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Check_model_Etabs GetCheckModelEtabs_5()
	{
		return null;
	}
}
