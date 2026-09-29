using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class AIToolExecutionResult
{
	[CompilerGenerated]
	private bool _bool_2;

	[CompilerGenerated]
	private string _string_3;

	[CompilerGenerated]
	private JObject _jobject_4;

	internal static AIToolExecutionResult _aitoolexecutionresult_5;

	public bool IsSuccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public JObject Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AIToolExecutionResult()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AIToolExecutionResult Ok(string message, JObject data = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AIToolExecutionResult Fail(string message, JObject data = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToJson()
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
	static AIToolExecutionResult()
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
								goto _goto_6;
							}
							goto case 0;
						}
						return;
					case 2:
						break;
					case 1:
						AppClass_016.TqZDb19vgxf();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_97936e966ecc45c89a24b73522132cba == 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						AppClass_016.QB3DbWPnHbY();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 == 0)
						{
							num3 = 0;
						}
						continue;
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
			AppClass_054.IveTMUdyS5E();
			num = 6;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_9b8a3fa59b0643a9a005e0e055caa087 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_1()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AIToolExecutionResult GetAitoolexecutionresult_2()
	{
		return null;
	}
}
