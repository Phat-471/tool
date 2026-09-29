using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class AI_ReadBeamLayoutInput_Tool : AIToolBase
{
	private static AI_ReadBeamLayoutInput_Tool _aiReadbeamlayoutinputTool_2;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public override string[] ExplorerContexts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public override bool IsTruocAI
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AI_ReadBeamLayoutInput_Tool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override JObject GetJobject_1(string userText)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetString_2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetUserPromptExamples()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override JObject GetJobject_3()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AIToolExecutionResult Execute(JObject arguments)
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
	static AI_ReadBeamLayoutInput_Tool()
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
							goto case 0;
						}
						AppClass_016.QB3DbWPnHbY();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6bc76ddff42e43b3abef2b1a6c67dc05 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						return;
					case 0:
						AppClass_054.IveTMUdyS5E();
						num3 = 5;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 == 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
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
			AppClass_016.TqZDb19vgxf();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6e99e32e591e462b8367847de5debd19 == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_4()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AI_ReadBeamLayoutInput_Tool GetAiReadbeamlayoutinputTool_5()
	{
		return null;
	}
}
