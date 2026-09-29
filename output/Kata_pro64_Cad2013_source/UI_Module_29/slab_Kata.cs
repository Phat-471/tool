using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class slab_Kata
{
	internal static slab_Kata _slabKata_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public slab_Kata()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_1(ref PolygonModule.Polygon Polygon, int thick = 50)
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
	public void ExecuteAction_2(ref List<Bien_chung.info_revit_thep> tap_thep)
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
	static slab_Kata()
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
						switch (num2)
						{
						case 990:
							break;
						default:
							goto _goto_5;
						case 9:
							goto _goto_4;
						}
						break;
					case 2:
						return;
					case 0:
						goto _goto_5;
					case 1:
						{
							AppClass_016.TqZDb19vgxf();
							num3 = 4;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_420aff19babf4086bddd3243df310fb2 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						_goto_4:
						AppClass_054.IveTMUdyS5E();
						num3 = 8;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6e99e32e591e462b8367847de5debd19 != 0)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				continue;
				_goto_5:
				break;
			}
			AppClass_016.QB3DbWPnHbY();
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static slab_Kata GetSlabKata_4()
	{
		return null;
	}
}
