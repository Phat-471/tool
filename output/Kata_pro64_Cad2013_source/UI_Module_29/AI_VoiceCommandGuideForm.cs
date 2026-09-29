using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public sealed class AI_VoiceCommandGuideForm : Form
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct GetStatic_1 : IAsyncStateMachine
	{
		public int _int_2;

		public AsyncVoidMethodBuilder _asyncvoidmethodbuilder_3;

		internal object _object_4;

		internal EventArgs _eventargs_5;

		internal AI_VoiceCommandGuideForm _aiVoicecommandguideform_6;

		internal TaskAwaiter<JObject> _taskawaiterJobject_7;

		internal static object _object_8;

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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_26;
								}
								goto case 2;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_304ef6de120f426182a7983bd4c8621a != 0)
							{
								num3 = 5;
							}
							continue;
						case 0:
							return;
						case 1:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							continue;
						}
						goto _goto_27;
						continue;
						_goto_26:
						break;
					}
					continue;
					_goto_27:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 4;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_eb282d37369b4f6197140b421715178f == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_2()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetObject_3()
		{
			return null;
		}
	}

	private readonly string _string_11;

	private readonly List<AppClass_256> _listAppclass256_12;

	private readonly ComboBox _combobox_13;

	private readonly TextBox _textbox_14;

	private readonly ComboBox _combobox_15;

	private readonly Button _button_16;

	private readonly TextBox _textbox_17;

	private readonly TextBox _textbox_18;

	private readonly Button _button_19;

	private readonly Label _label_20;

	private readonly LinkLabel _linklabel_21;

	private string _string_22;

	private bool _bool_23;

	[CompilerGenerated]
	private string _string_24;

	private static AI_VoiceCommandGuideForm _aiVoicecommandguideform_25;

	public string ChosenCommand
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
	public AI_VoiceCommandGuideForm(string nodeId)
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
	private void HandleEvent_4(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_5(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(GetStatic_1))]
	private void HandleEvent_6(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_7(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AI_VoiceCommandGuideForm()
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
								goto _goto_26;
							}
							goto case 0;
						}
						AppClass_016.QB3DbWPnHbY();
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_70b74b6646ee4941ab98a5b4cd6b0988 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						continue;
					case 2:
						return;
					case 1:
						break;
					}
					goto _goto_27;
					continue;
					_goto_26:
					break;
				}
				continue;
				_goto_27:
				break;
			}
			AppClass_016.TqZDb19vgxf();
			num = 5;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3d856b94665044e6b2ba303819a86373 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_8()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AI_VoiceCommandGuideForm GetAiVoicecommandguideform_9()
	{
		return null;
	}
}
