using System.Runtime.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class GetStatic_3
{
	internal static GetStatic_3 _appclass292_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetStatic_3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetStatic_3()
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
	static GetStatic_3()
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
						return;
					case 0:
						break;
					case 1:
						AppClass_016.QB3DbWPnHbY();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_8914b8dde10043a5a310f94275ef0637 != 0)
						{
							num3 = 7;
						}
						continue;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_663d2796725d4befbd1d1da2287dccb6 != 0)
						{
							num3 = 1;
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
	internal static bool IsValid_4()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_3 GetAppclass292_5()
	{
		return null;
	}
}
