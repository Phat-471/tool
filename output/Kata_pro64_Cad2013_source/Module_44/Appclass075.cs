using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
internal sealed class GetStatic_3
{
	public static List<Bien_chung.info_revit_thep> _infoRevitThep_2;

	public static object _object_3;

	public static List<Bien_chung.info_revit_mc_ngang_dam> _infoRevitMcNgangDam_4;

	public static object _object_5;

	public static object _object_6;

	public static List<Bien_chung.info_revit_thep_ngang> _infoRevitThepNgang_7;

	public static object _object_8;

	private static object _object_9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetDouble_1(int P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetInt_2(object P_0)
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
	static GetStatic_3()
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
						goto _goto_10;
					case 0:
						break;
					case 2:
						return;
					case 1:
						AppClass_016.TqZDb19vgxf();
						num3 = 9;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_215ff6740fce4d6085a4965d450b37ab == 0)
						{
							num3 = 0;
						}
						continue;
					}
					goto _goto_11;
					continue;
					_goto_10:
					break;
				}
				continue;
				_goto_11:
				break;
			}
			while (num2 == 990);
			AppClass_016.QB3DbWPnHbY();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f1b1e344da8347d8824965ffc04c0be5 == 0)
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
	internal static GetStatic_3 GetAppclass075_5()
	{
		return null;
	}
}
