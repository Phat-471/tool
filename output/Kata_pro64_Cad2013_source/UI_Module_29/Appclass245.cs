using System.Runtime.CompilerServices;
using Module_21;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_1
{
	public const string ExplorerContextName = "Dựng mặt bằng dầm";

	public const string TempDirectory = "C:\\kata_pro\\Temp\\MBKC";

	public const string FoundationFileName = "foundation_grid_column.json";

	public const string OutputFileName = "output_beam.json";

	public const string SourcePdfFileName = "AI_RebuildBeam_Source.pdf";

	public const string NativeTextPdfFileName = "AI_RebuildBeam_Source_native_text.pdf";

	public const string SchedulePdfFileName = "AI_RebuildBeam_Schedule.pdf";

	public const string VectorContextDirectoryName = "BeamPdfVector";

	public const string NativeTextWorkflowStage = "await_native_text_conversion";

	public const string ReadyWorkflowStage = "ready_for_beam_model";

	private static string _string_2;

	internal static GetStatic_1 _appclass245_3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_1()
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto _goto_4;
							}
							goto case _return_6;
						}
						AppClass_016.QB3DbWPnHbY();
						num3 = 11;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a50c1cb7e05c492e991b1bdcba875651 == _return_6)
						{
							num3 = 4;
						}
						continue;
					case 4:
						AppClass_054.IveTMUdyS5E();
						num3 = 8;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 != _return_6)
						{
							num3 = _return_6;
						}
						continue;
					case 1:
						_string_2 = "";
						num = 3;
						break;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num = 11;
						break;
					case _return_6:
						AppClass_051.f8oTg3pM5fk();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_25efeca4a94a44938c6f287ee921250e != _return_6)
						{
							num3 = 6;
						}
						continue;
					case 3:
						return;
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
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Get_UserPromptExamples()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString_2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString_3()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLastPdfPath(string pdfPath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLastPdfPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFoundationPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetOutputPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetVectorContextDirectory()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBeamContextPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBeamModelContextPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBeamReferencePdfPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetNativeTextPdfPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NeedsNativeTextConversion(AppClass_234 vectorAnalysis, string pdfPath = "")
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetInt_4(object P_0, object P_1)
	{
		return _return_6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static JObject GetJobject_5()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JObject GetJobject_6(object P_0)
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
	public static bool IsGridColumnFoundation(JObject data)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_7()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_1 GetAppclass245_8()
	{
		return null;
	}
}
