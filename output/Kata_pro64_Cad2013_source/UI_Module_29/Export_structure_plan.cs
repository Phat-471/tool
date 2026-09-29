using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class Export_structure_plan
{
	private static Export_structure_plan _exportStructurePlan_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Export_structure_plan()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Export_Model_Cad(ref List<Info_Beam3D> tap_Beam3D, ref List<Info_ColumnWall3D> tap_ColumnWall3D, ref List<Info_Slab3D> tap_slab, ref List<info_CurveGrid> tap_grid)
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
	public void create_grid(diem d1, diem d2, string ten)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Export_structure_plan()
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
								goto _goto_3;
							}
							goto case 1;
						}
						return;
					case 1:
						AppClass_016.TqZDb19vgxf();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_57bb817da9f045ada4d7d6d082ce52c4 == 0)
						{
							num3 = 9;
						}
						continue;
					case 2:
						break;
					case 0:
						AppClass_016.QB3DbWPnHbY();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_00b3130823b245fab24ede09ecc55ae9 != 0)
						{
							num3 = 4;
						}
						continue;
					}
					goto _goto_4;
					continue;
					_goto_3:
					break;
				}
				continue;
				_goto_4:
				break;
			}
			AppClass_054.IveTMUdyS5E();
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_1()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Export_structure_plan GetExportStructurePlan_2()
	{
		return null;
	}
}
