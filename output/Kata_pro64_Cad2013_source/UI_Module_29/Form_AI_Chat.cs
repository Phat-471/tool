using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[DesignerGenerated]
public class Form_AI_Chat : UserControl
{
	private struct AppStruct_266
	{
		public int _int_2;

		public int _int_3;

		public int _int_4;

		public int _int_5;
	}

	private enum AppEnum_267
	{

	}

	private enum AppEnum_268
	{

	}

	private class GetStatic_6 : AppClass_190
	{
		[CompilerGenerated]
		private bool _bool_6;

		[CompilerGenerated]
		private string _string_7;

		internal static object _object_8;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_6()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public bool GetSpecialnameCompilergeneratedPublicBool_2()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void GetSpecialnameCompilergeneratedPublicVoid_3(bool P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public string GetSpecialnameCompilergeneratedPublicString_4()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void GetSpecialnameCompilergeneratedPublicVoid_5(string P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_6()
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
								AppClass_016.QB3DbWPnHbY();
								num3 = 1;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a50c1cb7e05c492e991b1bdcba875651 == _return_252)
								{
									num3 = _return_252;
								}
								continue;
							}
							goto _goto_148;
						case 2:
							return;
						case _return_252:
							AppClass_054.IveTMUdyS5E();
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 != _return_252)
							{
								num3 = 2;
							}
							continue;
						case 1:
							break;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				while (num2 == 990);
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c57d245498d44fafb6366861203ffcfd == _return_252)
				{
					num = 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_7()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_6 GetAppclass269_8()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_9 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncVoidMethodBuilder _asynctaskmethodbuilder_103;

		internal object _object_44;

		internal EventArgs _mouseeventargs_45;

		internal Form_AI_Chat _formAiChat_146;

		internal Func<string> _funcString_16;

		internal string _string_17;

		internal Task<AIChatResult> _taskAichatresult_18;

		internal GetStatic_51 _appclass281_19;

		internal Task<AIChatResult> _taskAichatresult_20;

		internal GetStatic_56 _appclass282_21;

		internal Task<AIChatResult> _taskAichatresult_22;

		internal GetStatic_42 _appclass279_23;

		internal bool _bool_24;

		internal string _string_25;

		internal string _string_26;

		internal TaskAwaiter _taskawaiterJobject_107;

		internal TaskAwaiter<AIChatResult> _taskawaiterJobject_97;

		internal static object _object_29;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_9()
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
									goto _goto_148;
								}
								goto case _return_252;
							}
							return;
						case 2:
							break;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_25efeca4a94a44938c6f287ee921250e != _return_252)
							{
								num3 = 9;
							}
							continue;
						case _return_252:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 == _return_252)
							{
								num3 = 3;
							}
							continue;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74fd3f679d7f4193893763ebe442ebc5 != _return_252)
				{
					num = 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_10()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_11()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_12 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncVoidMethodBuilder _asynctaskmethodbuilder_103;

		internal object _object_44;

		internal MouseEventArgs _mouseeventargs_45;

		internal Form_AI_Chat _formAiChat_146;

		internal TaskAwaiter _taskawaiterJobject_107;

		internal static object _object_38;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_12()
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
							switch (num2)
							{
							case 990:
								break;
							case 9:
								goto _goto_39;
							default:
								goto _goto_253;
							}
							break;
						case _return_252:
							AppClass_054.IveTMUdyS5E();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 != _return_252)
							{
								num3 = _return_252;
							}
							continue;
						case 1:
							return;
						case 2:
							goto _goto_253;
							_goto_39:
							AppClass_016.QB3DbWPnHbY();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4303c5f248054e83a5686966604b55b3 == _return_252)
							{
								num3 = 4;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_13()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_14()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_15 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncVoidMethodBuilder _asynctaskmethodbuilder_103;

		internal object _object_44;

		internal MouseEventArgs _mouseeventargs_45;

		internal Form_AI_Chat _formAiChat_146;

		internal TaskAwaiter _taskawaiterJobject_107;

		private static object _object_48;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_15()
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
									goto _goto_148;
								}
								goto case 2;
							}
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_57bb817da9f045ada4d7d6d082ce52c4 != _return_252)
							{
								num3 = 1;
							}
							continue;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_02eb9f97d81c4e8f82591f5f747031ca == _return_252)
							{
								num3 = _return_252;
							}
							continue;
						case _return_252:
							break;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_16()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_17()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_18 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncTaskMethodBuilder _asynctaskmethodbuilder_103;

		internal Form_AI_Chat _formAiChat_146;

		internal bool _bool_54;

		internal GetStatic_60 _appclass283_55;

		internal bool _bool_56;

		internal TaskAwaiter<string> _taskawaiterJobject_107;

		internal static object _object_58;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_18()
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
						case _return_252:
							goto _goto_253;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 8;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4c55e99b69ce444aab2045602ec049f1 != _return_252)
							{
								num3 = _return_252;
							}
							continue;
						case 2:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 1;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bb2f0fc0ebaf421a874128d1fc3d5b38 == _return_252)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_19()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_20()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_21 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncVoidMethodBuilder _asynctaskmethodbuilder_103;

		internal string _string_62;

		internal Form_AI_Chat _formAiChat_146;

		internal TaskAwaiter _taskawaiterJobject_107;

		internal static object _object_65;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_21()
		{
			AppClass_016.uQ4DbMFRj7Q();
			int num = 2;
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
								return;
							}
							goto _goto_148;
						case _return_252:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							continue;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_72823ff942d347a096f59781d20eb0d2 == _return_252)
							{
								num3 = _return_252;
							}
							continue;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				while (num2 == 990);
				AppClass_054.IveTMUdyS5E();
				num = 5;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5ab3671b1a5b4ded9b7d5dd14f4fc909 == _return_252)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_22()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_23()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_24 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncTaskMethodBuilder _asynctaskmethodbuilder_103;

		internal string _string_145;

		internal Form_AI_Chat _formAiChat_146;

		internal TaskAwaiter<AIChatResult> _taskawaiterJobject_107;

		private static object _object_73;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_24()
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
									goto _goto_148;
								}
								goto case 1;
							}
							return;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f09347d075a54e3c9e3affc36c5644b5 == _return_252)
							{
								num3 = 9;
							}
							continue;
						case _return_252:
							AppClass_016.QB3DbWPnHbY();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_42524d84b15f453da26a7f97a96dac37 != _return_252)
							{
								num3 = 2;
							}
							continue;
						case 2:
							break;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_f1d3310c23ca49db85cb3ac113b82788 != _return_252)
				{
					num = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_25()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_26()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class GetStatic_28 : IEnumerable<TreeNode>, IEnumerable, IEnumerator<TreeNode>, IDisposable, IEnumerator
	{
		public int _int_102;

		public TreeNode _treenode_77;

		public int _int_78;

		internal TreeNodeCollection _treenodecollection_79;

		internal TreeNodeCollection _treenodecollection_80;

		internal Form_AI_Chat _formAiChat_146;

		internal IEnumerator _ienumerator_82;

		internal TreeNode _treenode_83;

		internal IEnumerator<TreeNode> _ienumeratorTreenode_84;

		private static GetStatic_28 _appclass276_85;

		private TreeNode Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_28(int _int_102)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private bool MoveNext()
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

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator<TreeNode> GetEnumerator()
		{
			return null;
		}

		IEnumerator<TreeNode> IEnumerable<TreeNode>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
			return this.GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Reset
			this.Reset();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_28()
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
						case 2:
							goto _goto_253;
						case _return_252:
							return;
						case 1:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 == _return_252)
							{
								num3 = 2;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_016.QB3DbWPnHbY();
							num3 = 6;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_d9209192fb5a48db8afe33275173f36c == _return_252)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_29()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_28 GetAppclass276_30()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_31 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncTaskMethodBuilder _asynctaskmethodbuilder_103;

		internal string _string_104;

		internal bool _bool_105;

		internal Form_AI_Chat _formAiChat_146;

		internal GetStatic_69 _appclass285_92;

		internal string _string_93;

		internal string _string_94;

		internal JObject _jobject_95;

		internal TaskAwaiter _taskawaiterJobject_107;

		internal TaskAwaiter<JObject> _taskawaiterJobject_97;

		internal TaskAwaiter<AIChatResult> _taskawaiterAichatresult_98;

		internal static object _object_99;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_31()
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
									goto _goto_148;
								}
								goto case _return_252;
							}
							return;
						case _return_252:
							AppClass_016.QB3DbWPnHbY();
							num3 = 9;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2c174d0d9ac34a6c933e3a665cf63f30 == _return_252)
							{
								num3 = 2;
							}
							continue;
						case 2:
							break;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c16368ee47214a3ea92e8fd02e53deed == _return_252)
							{
								num3 = _return_252;
							}
							continue;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 1;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b817d8b77667446197dc2b785b9041c0 != _return_252)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_32()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_33()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_34 : IAsyncStateMachine
	{
		public int _int_102;

		public AsyncTaskMethodBuilder _asynctaskmethodbuilder_103;

		internal string _string_104;

		internal bool _bool_105;

		internal Form_AI_Chat _formAiChat_146;

		internal TaskAwaiter<JObject> _taskawaiterJobject_107;

		internal static object _object_108;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void MoveNext()
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_34()
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
							if (num2 == 9)
							{
								AppClass_016.QB3DbWPnHbY();
								num3 = 1;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 == _return_252)
								{
									num3 = 3;
								}
								continue;
							}
							goto _goto_141;
						case _return_252:
							return;
						case 2:
							goto _goto_253;
						case 1:
							break;
						}
						goto _goto_144;
						_goto_141:
						if (num2 == 990)
						{
							break;
						}
						goto _goto_144;
						_goto_144:
						AppClass_054.IveTMUdyS5E();
						num3 = _return_252;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_215ff6740fce4d6085a4965d450b37ab != _return_252)
						{
							num3 = 2;
						}
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_35()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_36()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_42
	{
		public Stopwatch _stopwatch_113;

		public long _long_114;

		public Stopwatch _stopwatch_115;

		public string _string_116;

		public Action _action_117;

		public Action _action_118;

		public GetStatic_46 _appclass284_151;

		internal static GetStatic_42 _appclass279_120;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_42(GetStatic_42 arg0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal string GetSpecialnameInternalJobject_68()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal void GetSpecialnameInternalVoid_39()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal void GetSpecialnameInternalVoid_40()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal AIChatResult GetSpecialnameInternalAichatresult_41()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_42()
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
									goto _goto_148;
								}
								goto case 1;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1a1ae42c9fb647b2ac3ccb55018de5e5 == _return_252)
							{
								num3 = _return_252;
							}
							continue;
						case 2:
							break;
						case 1:
							AppClass_054.IveTMUdyS5E();
							num3 = 9;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fa885cb658d447638297a1e47340b8c6 != _return_252)
							{
								num3 = _return_252;
							}
							continue;
						case _return_252:
							return;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_43()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_42 GetAppclass279_44()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_46
	{
		public string _string_123;

		public string _string_150;

		public string _string_125;

		public Form_AI_Chat _formAiChat_146;

		internal static GetStatic_46 _appclass280_127;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_46(GetStatic_46 arg0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_46()
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
						case 1:
							goto _goto_253;
						case _return_252:
							return;
						case 2:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bb69b688ab23416fb5187846886dbbdf == _return_252)
							{
								num3 = _return_252;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_016.QB3DbWPnHbY();
							num3 = 9;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_42524d84b15f453da26a7f97a96dac37 == _return_252)
							{
								num3 = 2;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4e8e93c04498476f95f43d6dbed4b259 == _return_252)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_47()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_46 GetAppclass280_48()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_51
	{
		public JObject _jobject_129;

		public GetStatic_42 _appclass279_130;

		private static GetStatic_51 _appclass281_131;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_51(GetStatic_51 arg0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal AIChatResult GetSpecialnameInternalAichatresult_50()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_51()
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
									goto _goto_148;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c9fe3f02f7e845bd8d8e0e7e226ffca4 == _return_252)
							{
								num3 = 2;
							}
							continue;
						case _return_252:
							AppClass_016.QB3DbWPnHbY();
							num3 = 9;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5ab3671b1a5b4ded9b7d5dd14f4fc909 == _return_252)
							{
								num3 = 2;
							}
							continue;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_420aff19babf4086bddd3243df310fb2 == _return_252)
				{
					num = 1;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_52()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_51 GetAppclass281_53()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_56
	{
		public AIToolExecutionResult _aitoolexecutionresult_134;

		public GetStatic_42 _appclass279_135;

		private static GetStatic_56 _appclass282_136;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_56(GetStatic_56 arg0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal AIChatResult GetSpecialnameInternalAichatresult_55()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_56()
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
									goto _goto_148;
								}
								goto case 2;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3e20b8f0eaaf4c2c858e7c7ca7131a33 != _return_252)
							{
								num3 = 2;
							}
							continue;
						case 1:
							break;
						case 2:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2d4a32d5aa4341e59cdd7055ceb6be5d != _return_252)
							{
								num3 = 9;
							}
							continue;
						case _return_252:
							return;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 1;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_559789cacd7f46ac973fb693ed94037f != _return_252)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_57()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_56 GetAppclass282_58()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_60
	{
		public string _string_139;

		internal static GetStatic_60 _appclass283_140;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_60()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_60()
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
							if (num2 == 9)
							{
								AppClass_016.QB3DbWPnHbY();
								num3 = 1;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_934fee42d4914438a301122ea3a645b4 == _return_252)
								{
									num3 = 2;
								}
								continue;
							}
							goto _goto_141;
						case _return_252:
							return;
						case 2:
							goto _goto_253;
						case 1:
							break;
						}
						goto _goto_144;
						_goto_141:
						if (num2 == 990)
						{
							break;
						}
						goto _goto_144;
						_goto_144:
						AppClass_054.IveTMUdyS5E();
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0ba42bd2348344eaadcfdc98ba87d4f0 == _return_252)
						{
							num3 = _return_252;
						}
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_61()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_60 GetAppclass283_62()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_64
	{
		public string _string_145;

		public Form_AI_Chat _formAiChat_146;

		private static GetStatic_64 _appclass284_147;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_64()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_64()
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
									goto _goto_148;
								}
								goto case _return_252;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0ba42bd2348344eaadcfdc98ba87d4f0 == _return_252)
							{
								num3 = _return_252;
							}
							continue;
						case _return_252:
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						case 1:
							break;
						case 2:
							return;
						}
						goto _goto_253;
						continue;
						_goto_148:
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 7;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_eb282d37369b4f6197140b421715178f == _return_252)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_65()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_64 GetAppclass284_66()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_69
	{
		public string _string_150;

		public GetStatic_64 _appclass284_151;

		internal static GetStatic_69 _appclass285_152;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetStatic_69()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal JObject GetSpecialnameInternalJobject_68()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetStatic_69()
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
						case 2:
							return;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = _return_252;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e751303fb5f34e63bdc0efa39b75b1a1 == _return_252)
							{
								num3 = 2;
							}
							continue;
						case _return_252:
							goto _goto_253;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_24719cccbece427b9ca340b0b8914683 == _return_252)
							{
								num3 = 3;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_253:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_70()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GetStatic_69 GetAppclass285_71()
		{
			return null;
		}
	}

	private IContainer _icontainer_154;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlExplorer")]
	private Panel _Pnlexplorer;

	[CompilerGenerated]
	[AccessedThroughProperty("tvScope")]
	private TreeView _treeview_155;

	[CompilerGenerated]
	[AccessedThroughProperty("lblExplorer")]
	private Label _Lblexplorer;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlHeader")]
	private Panel _panel_156;

	[AccessedThroughProperty("btnVoiceCommand")]
	[CompilerGenerated]
	private Button _button_157;

	[CompilerGenerated]
	[AccessedThroughProperty("btnVoiceGuide")]
	private Button _button_158;

	[AccessedThroughProperty("lblSubtitle")]
	[CompilerGenerated]
	private Label _label_159;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTitle")]
	private Label _label_160;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlSettings")]
	private Panel _panel_161;

	[CompilerGenerated]
	[AccessedThroughProperty("btnReset")]
	private Button _button_162;

	[AccessedThroughProperty("cboModel")]
	[CompilerGenerated]
	private ComboBox _Cbomodel;

	[CompilerGenerated]
	[AccessedThroughProperty("lblModel")]
	private Label _label_163;

	[CompilerGenerated]
	[AccessedThroughProperty("txtApiKey")]
	private TextBox _Txtapikey;

	[AccessedThroughProperty("lblApiKey")]
	[CompilerGenerated]
	private Label _Lblapikey;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlChat")]
	private Panel _panel_164;

	[CompilerGenerated]
	[AccessedThroughProperty("txtLog")]
	private RichTextBox _richtextbox_165;

	[CompilerGenerated]
	[AccessedThroughProperty("lblChat")]
	private Label _label_166;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlPrompt")]
	private Panel _panel_167;

	[CompilerGenerated]
	[AccessedThroughProperty("btnVoice")]
	private Button _button_168;

	[CompilerGenerated]
	[AccessedThroughProperty("btnSend")]
	private Button _button_169;

	[CompilerGenerated]
	[AccessedThroughProperty("txtPrompt")]
	private TextBox _textbox_170;

	[AccessedThroughProperty("lblPrompt")]
	[CompilerGenerated]
	private Label _label_171;

	[AccessedThroughProperty("prgAiBusy")]
	[CompilerGenerated]
	private ProgressBar _Prgaibusy;

	[CompilerGenerated]
	[AccessedThroughProperty("_accordionHost")]
	private Panel _panel_172;

	[AccessedThroughProperty("_btnExplorerSection")]
	[CompilerGenerated]
	private Button _button_173;

	[AccessedThroughProperty("_btnChatSection")]
	[CompilerGenerated]
	private Button _button_174;

	[AccessedThroughProperty("_btnSettingsSection")]
	[CompilerGenerated]
	private Button _button_175;

	[AccessedThroughProperty("_btnPromptSection")]
	[CompilerGenerated]
	private Button _button_176;

	[CompilerGenerated]
	[AccessedThroughProperty("_promptExamplesPanel")]
	private Panel _Promptexamplespanel;

	[AccessedThroughProperty("_promptExamplesTitle")]
	[CompilerGenerated]
	private Label _label_177;

	[AccessedThroughProperty("_promptExamplesBox")]
	[CompilerGenerated]
	private TextBox _Promptexamplesbox;

	[AccessedThroughProperty("_chkSelectMBCad")]
	[CompilerGenerated]
	private CheckBox _checkbox_178;

	[AccessedThroughProperty("_headerTitlePanel")]
	[CompilerGenerated]
	private Panel _Headertitlepanel;

	[AccessedThroughProperty("_promptBodyPanel")]
	[CompilerGenerated]
	private Panel _panel_179;

	[AccessedThroughProperty("_promptButtonPanel")]
	[CompilerGenerated]
	private Panel _panel_180;

	[AccessedThroughProperty("_promptButtonGapPanel")]
	[CompilerGenerated]
	private Panel _panel_181;

	[AccessedThroughProperty("_promptStatusPanel")]
	[CompilerGenerated]
	private Panel _panel_182;

	[CompilerGenerated]
	[AccessedThroughProperty("_settingsTable")]
	private TableLayoutPanel _tablelayoutpanel_183;

	private string _string_184;

	private string _string_185;

	private bool _bool_186;

	private readonly AppClass_257 _appclass257_187;

	private readonly AppClass_198 _appclass198_188;

	private readonly AI_EditBeamRebar_ByVoice_Tool _aiEditbeamrebarByvoiceTool_189;

	private bool _bool_190;

	private string _string_191;

	private string _string_192;

	private bool _bool_193;

	private bool _bool_194;

	private string _string_195;

	private AppEnum_267 _appenum267_196;

	private Button _button_197;

	private string _string_198;

	private string _string_199;

	private bool _bool_200;

	[CompilerGenerated]
	[AccessedThroughProperty("_codexTimer")]
	private Timer _Codextimer;

	[CompilerGenerated]
	[AccessedThroughProperty("_codexLogTimer")]
	private Timer _Codexlogtimer;

	[CompilerGenerated]
	[AccessedThroughProperty("_codexApprovalTimer")]
	private Timer _Codexapprovaltimer;

	[CompilerGenerated]
	[AccessedThroughProperty("_layoutStabilizeTimer")]
	private Timer _Layoutstabilizetimer;

	private readonly Queue<string> _queueString_201;

	private readonly object _object_202;

	private string _string_203;

	private string _string_204;

	private string _string_205;

	private JObject _jobject_206;

	private string _string_207;

	private int _int_208;

	private bool _bool_209;

	private bool _bool_210;

	private int _int_211;

	private AppEnum_268 _appenum268_212;

	private string _string_213;

	private bool _bool_214;

	private int _int_215;

	private int _int_216;

	private bool _bool_217;

	private bool _bool_218;

	private int _int_219;

	private bool _bool_220;

	private bool _bool_221;

	private string _string_222;

	private AppClass_187 _appclass187_223;

	private string _string_224;

	private int _int_225;

	private int _int_226;

	private bool _bool_227;

	private List<string> _listString_228;

	private int _int_229;

	private bool _bool_230;

	private bool _bool_231;

	private bool _bool_232;

	private bool _bool_233;

	private bool _bool_234;

	private bool _bool_235;

	private bool _bool_236;

	private bool _bool_237;

	private bool _bool_238;

	private bool _bool_239;

	private bool _bool_240;

	private bool _bool_241;

	private bool _bool_242;

	private int _int_243;

	private readonly Size _size_244;

	internal static Form_AI_Chat _formAiChat_245;

	internal virtual Panel pnlExplorer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TreeView tvScope
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblExplorer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlHeader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnVoiceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnVoiceGuide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblSubtitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnReset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ComboBox cboModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox txtApiKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblApiKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlChat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual RichTextBox txtLog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblChat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel pnlPrompt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnVoice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button btnSend
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox txtPrompt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label lblPrompt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual ProgressBar prgAiBusy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _accordionHost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnExplorerSection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnChatSection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnSettingsSection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Button _btnPromptSection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptExamplesPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Label _promptExamplesTitle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TextBox _promptExamplesBox
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual CheckBox _chkSelectMBCad
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _headerTitlePanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptBodyPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptButtonPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptButtonGapPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual Panel _promptStatusPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	internal virtual TableLayoutPanel _settingsTable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Form_AI_Chat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
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
	[DebuggerStepThrough]
	private void GetDebuggerstepthroughPrivateVoid_72()
	{
	}

	[DllImport("user32.dll", EntryPoint = "GetAncestor")]
	private static extern IntPtr GetExternIntptr_73(IntPtr P_0, uint P_1);

	[DllImport("user32.dll", EntryPoint = "GetWindowRect", SetLastError = true)]
	private static extern bool GetExternBool_74(IntPtr P_0, ref AppStruct_266 P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual Timer GetSpecialnameCompilergeneratedPrivateVirtualTimer_75()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void GetSpecialnameCompilergeneratedPrivateVirtualVoid_76(Timer WithEventsValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual Timer GetSpecialnameCompilergeneratedPrivateVirtualTimer_77()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void GetSpecialnameCompilergeneratedPrivateVirtualVoid_78(Timer WithEventsValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual Timer GetSpecialnameCompilergeneratedPrivateVirtualTimer_79()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void GetSpecialnameCompilergeneratedPrivateVirtualVoid_80(Timer WithEventsValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual Timer GetSpecialnameCompilergeneratedPrivateVirtualTimer_81()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void GetSpecialnameCompilergeneratedPrivateVirtualVoid_82(Timer WithEventsValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_83(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(GetStatic_9))]
	private void HandleEvent_84(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_85(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_86(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_87(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_88()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_89()
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
	private void ExecuteAction_90()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_91()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_92(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_93()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_94(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_95(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_96(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_97(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_98()
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
	private bool IsValid_99(RegistryKey P_0, string P_1, bool P_2)
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
	private void ExecuteAction_100()
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
	private void ExecuteAction_101()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_102(Button P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_103()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_104()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_105()
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
	private int GetInt_106()
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetFloat_107()
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
	private int GetInt_108()
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_109()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_110()
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle GetRectangle_111(Control P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_112(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_113()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_114(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_115()
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
	private void ExecuteAction_116()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_117()
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
	private void ExecuteAction_118()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_119()
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_120(TreeNodeCollection P_0)
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
	private void ExecuteAction_121(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_122()
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_123(Button P_0, Panel P_1, int P_2, int P_3, int P_4, int P_5)
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetInt_124(int P_0)
	{
		return _return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_125(string P_0, string P_1, bool P_2, bool P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_126(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(GetStatic_12))]
	private void HandleEvent_127(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_128(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(GetStatic_15))]
	private void HandleEvent_129(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_130(Button P_0, AppEnum_267 P_1)
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
	[AsyncStateMachine(typeof(GetStatic_18))]
	private Task GetTask_131()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_132(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_133()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_134(object P_0, EventArgs P_1)
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
	[AsyncStateMachine(typeof(GetStatic_21))]
	private void ExecuteAction_135(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_136(object P_0, EventArgs P_1)
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
	private void ExecuteAction_137(string P_0)
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
	private void ExecuteAction_138()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_139(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_140(string P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_141()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_142()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_143(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_144(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_145(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_146()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_147()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_148()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_149()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_150()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_151()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_152()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_153()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_154(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_155(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_156()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_157(string P_0, string P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_158(string P_0, string P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_159(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_160()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_161(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_162(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_163(string P_0)
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
	[AsyncStateMachine(typeof(GetStatic_24))]
	private Task GetTask_164(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_165(AIChatResult P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_166()
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
	private bool IsValid_167(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_168(bool P_0)
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
	private void ExecuteAction_169(Task<AIChatResult> P_0, GetStatic_6 P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_170(Task<AIChatResult> P_0, GetStatic_6 P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_171(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_172(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_173(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AppClass_187 GetAppclass187_174()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_175()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_176()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GetStatic_6 GetAppclass269_177(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_178()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_179(string P_0)
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
	private string GetString_180(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_181(GetStatic_6 P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_182(GetStatic_6 P_0, bool P_1, string P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_183(GetStatic_6 P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_184(GetStatic_6 P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_185(GetStatic_6 P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_186()
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
	private string GetString_187()
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
	private string GetString_188()
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
	private string GetString_189()
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
	private string GetString_190()
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
	private bool IsValid_191()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_192(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_193(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_194(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_195(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JObject GetJobject_196(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_197(bool P_0, bool P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_198(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_199(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_200(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_201(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetListString_202(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_203(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_204(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetListString_205(string P_0)
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
	private string GetString_206(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_207()
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
	private string GetString_208(List<string> P_0)
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
	private JArray GetJarray_209()
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
	private string GetString_210(GetStatic_6 P_0, string P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_211()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_212(string P_0, List<string> P_1)
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
	private string GetString_213(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_214(List<string> P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_215(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_216(string P_0)
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
	private void ExecuteAction_217(string P_0, AIToolExecutionResult P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_218(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_219(AIToolExecutionResult P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_220(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_221()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_222(AIToolExecutionResult P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_223()
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
	private void ExecuteAction_224(List<JArray> P_0, JArray P_1)
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
	private void ExecuteAction_225(List<JArray> P_0, JArray P_1)
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
	private void ExecuteAction_226(List<JArray> P_0, JArray P_1)
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
	private bool IsValid_227(List<JArray> P_0, ref double P_1, ref double P_2, ref double P_3, ref double P_4)
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
	private double GetDouble_228(JArray P_0, int P_1)
	{
		return _return_252._return_252;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_229(Graphics P_0, JArray P_1, Func<JArray, PointF> P_2, Color P_3, Color P_4, float P_5)
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
	private void ExecuteAction_230(Graphics P_0, JArray P_1, Func<JArray, PointF> P_2)
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
	private void ExecuteAction_231(Graphics P_0, JArray P_1, Func<JArray, PointF> P_2)
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
	private void ExecuteAction_232(JObject P_0, ref Color P_1, ref Color P_2, ref Color P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_233(int P_0, JObject P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_234(JObject P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_235(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_236(Graphics P_0, JArray P_1, Func<JArray, PointF> P_2, Color P_3, Color P_4, float P_5)
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
	private void ExecuteAction_237(Graphics P_0, JArray P_1, Func<JArray, PointF> P_2, string P_3, Color P_4)
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
	private RectangleF GetRectanglef_238(List<PointF> P_0)
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
	private PointF GetPointf_239(RectangleF P_0, PointF P_1, SizeF P_2)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PointF GetPointf_240(RectangleF P_0, PointF P_1, PointF P_2)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_241(Graphics P_0, string P_1, Font P_2, PointF P_3, Color P_4)
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
	private void ExecuteAction_242(string P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_243(bool P_0)
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
	private bool IsValid_244(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_245(string P_0, bool P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_246(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_247()
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
	private void ExecuteAction_248()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_249(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_250()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_251(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_252(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_253(object P_0, DataReceivedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_254(object P_0, EventArgs P_1)
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
	private void ExecuteAction_255(string P_0)
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
	private void HandleEvent_256(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_257()
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
	private void HandleEvent_258(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_259(bool P_0)
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
	private void ExecuteAction_260(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_261()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IAIToolDefinition GetIaitooldefinition_262()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_263()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_264()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_265()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_266()
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
	private bool IsValid_267()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_268(int P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_269(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_270(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_271()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_272()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_273(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_274(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_275(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_276()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_277(string P_0)
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
	private string GetString_278(int P_0, string P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_279(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_280(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_281()
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
	private bool IsValid_282()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_283()
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
	private void ExecuteAction_284(ref double P_0, ref bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_285(double P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_286(bool P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_287()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_288()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_289()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_290()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_291(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_292(string P_0)
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
	private string GetString_293(string P_0)
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
	private JObject GetJobject_294(string P_0)
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
	private bool IsValid_295(JObject P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JObject GetJobject_296(JObject P_0, JObject P_1)
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
	private JObject GetJobject_297(JObject P_0, JObject P_1)
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
	private JArray GetJarray_298(JObject P_0, string P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_299(JArray P_0, JArray P_1, JArray P_2, JObject P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JArray GetJarray_300(JArray P_0, JArray P_1, JArray P_2, JObject P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_301(JObject P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_302(JArray P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_303(JArray P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_304(JArray P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_305(JArray P_0, string P_1)
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
	private void ExecuteAction_306(JArray P_0, string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_307(JArray P_0, JObject P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_308(JArray P_0)
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
	private string GetString_309(JObject P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JToken GetJtoken_310(JToken P_0)
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
	private string GetString_311(string P_0)
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
	private void ExecuteAction_312()
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
	private bool IsValid_313()
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
	private void ExecuteAction_314()
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
	[IteratorStateMachine(typeof(GetStatic_28))]
	private IEnumerable<TreeNode> GetIenumerableTreenode_315(TreeNodeCollection P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_316(TreeNode P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_317(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TreeNode GetTreenode_318(string P_0)
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
	private TreeNode GetTreenode_319(string P_0, params string[] children)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TreeNode GetTreenode_320(TreeNode P_0, string P_1, params string[] children)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_321(object P_0, TreeViewCancelEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_322(object P_0, TreeViewEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_323(object P_0, TreeViewEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_324()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_325(string P_0, bool P_1, bool P_2, bool P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_326()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_327()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_328()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AppEnum_268 GetAppenum268_329()
	{
		return (AppEnum_268)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_330(bool? P_0 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_331()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetListString_332()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetListString_333(TreeNode P_0)
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
	private string GetString_334()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString_335(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_336(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_337()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_338(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_339()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsValid_340()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_341()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_342()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_343(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(GetStatic_31))]
	private Task GetTask_344(string P_0 = null, bool P_1 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(GetStatic_34))]
	private Task GetTask_345(string P_0 = null, bool P_1 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Form_AI_Chat()
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
					case 1:
						goto _goto_253;
					case _return_252:
						return;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 5;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e722010689ee4fbe88edb9e655ec8567 != _return_252)
						{
							num3 = 1;
						}
						continue;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						AppClass_054.IveTMUdyS5E();
						num3 = 6;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 != _return_252)
						{
							num3 = _return_252;
						}
						continue;
					}
					break;
				}
				continue;
				_goto_253:
				break;
			}
			AppClass_016.QB3DbWPnHbY();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 != _return_252)
			{
				num = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_346()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Form_AI_Chat GetFormAiChat_347()
	{
		return null;
	}
}
