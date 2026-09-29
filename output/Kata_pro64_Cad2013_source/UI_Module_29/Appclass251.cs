using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_1
{
	public const string ExplorerContextName = "Dựng lưới trục cột vách";

	public const string TempDirectory = "C:\\kata_pro\\Temp\\MBKC";

	public const string OutputFileName = "output_grid_column.json";

	private static readonly Dictionary<string, List<object>> VHRCsPgFJ7W;

	private static diem _diem_2;

	private static string _string_3;

	private static GetStatic_1 _appclass251_4;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_1()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 4;
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto _goto_5;
							}
							goto case 5;
						}
						_string_3 = "";
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_11280a854fde41d3a138fa46847165c7 != 0)
						{
							num3 = 2;
						}
						continue;
					case 0:
						return;
					case 6:
						AppClass_054.IveTMUdyS5E();
						num3 = 5;
						continue;
					case 2:
						break;
					case 3:
						AppClass_016.QB3DbWPnHbY();
						num3 = 6;
						continue;
					case 4:
						AppClass_016.TqZDb19vgxf();
						num3 = 3;
						continue;
					case 1:
						VHRCsPgFJ7W = new Dictionary<string, List<object>>(AppDelegate_1581.wjxFYLRMFLK(AppDelegate_1581.qnuFfmjorkO));
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_24719cccbece427b9ca340b0b8914683 == 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						AppClass_051.f8oTg3pM5fk();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2b1fe59a05ae4c9dae18bd56ce63ed12 != 0)
						{
							num3 = 7;
						}
						continue;
					}
					goto _goto_6;
					continue;
					_goto_5:
					break;
				}
				continue;
				_goto_6:
				break;
			}
			_diem_2 = null;
			num = 13;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_068fed8884eb4f759ebb34fd2b6f962b == 0)
			{
				num = 10;
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
	public static string GetString_4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetString_5(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLastOriginPoint(diem originPoint)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetLastOriginPoint()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetOutputPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddOriginPointToJson(JObject data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid_6(JObject data)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid_7(string filePath)
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
	private static diem GetDiem_8(object P_0)
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
	public static void ExecuteAction_9()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_10()
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
	public static void ExecuteAction_11(string objectId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_12(string objectId, List<object> objects)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_13(List<object> P_0)
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
	internal static bool IsValid_14()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_1 GetAppclass251_15()
	{
		return null;
	}
}
