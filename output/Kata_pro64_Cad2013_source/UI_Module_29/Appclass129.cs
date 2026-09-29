using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public sealed class GetStatic_4
{
	private static GetStatic_4 _appclass129_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GetStatic_4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid_2(JObject arguments)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AppClass_128 Resolve(JObject delta, string contextPath)
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
	private static bool IsValid_3(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_4()
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
							goto case 2;
						}
						AppClass_054.IveTMUdyS5E();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_35c268ab9039470abca9ecf2c3740d53 == 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						break;
					case 0:
						return;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_45f32ad850874067906bcaad9130e115 == 0)
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
			AppClass_016.QB3DbWPnHbY();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_d2365fb7fd684b7e8d483432972c9023 != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_5()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_4 GetAppclass129_6()
	{
		return null;
	}
}
