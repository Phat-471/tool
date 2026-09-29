using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class Column_Kata
{
	internal static Column_Kata _columnKata_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Column_Kata()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetString_1(Bien_chung.info_revit_thep thep)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValid_2(ref List<Bien_chung.info_revit_thep> tap_thep, ref diem goc_cot_revit, ref double ang_cot_revit, ref double kdai_lap)
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
	static Column_Kata()
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
								goto _goto_3;
							}
							goto case 1;
						}
						AppClass_054.IveTMUdyS5E();
						num3 = 9;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a50c1cb7e05c492e991b1bdcba875651 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num = 1;
						break;
					case 1:
						AppClass_016.QB3DbWPnHbY();
						num = 4;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_86bd1bfcffba4d48bfb7f8f798e9fed8 == 0)
						{
							num = 9;
						}
						break;
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
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Column_Kata GetColumnKata_4()
	{
		return null;
	}
}
