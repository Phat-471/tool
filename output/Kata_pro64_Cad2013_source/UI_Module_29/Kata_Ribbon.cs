using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Autodesk.AutoCAD.Runtime;
using Module_21;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class Kata_Ribbon
{
	private class KataRibbonCommand : ICommand
	{
		[CompilerGenerated]
		private EventHandler _eventhandler_2;

		internal static object _object_3;

		public event EventHandler CanExecuteChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KataRibbonCommand()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanExecute(object P_0)
		{
			return true;
		}

		bool ICommand.CanExecute(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CanExecute
			return this.CanExecute(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(object P_0)
		{
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.IndexOutOfRangeException: Index was outside the bounds of the array.
			//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
			//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
			//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
		}

		void ICommand.Execute(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Execute
			this.Execute(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KataRibbonCommand()
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
							num3 = 4;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_89610a4721534aa6974bcdebcd1127e3 != _return_26)
							{
								num3 = _return_26;
							}
							continue;
						case _return_26:
							goto _goto_25;
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
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_705374da7b0748cf8df80d00725571db == _return_26)
							{
								num3 = 2;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_25:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_1()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KataRibbonCommand GetKataribboncommand_2()
		{
			return null;
		}
	}

	public class KataRibbonCommand
	{
		[CompilerGenerated]
		private int _int_5;

		[CompilerGenerated]
		private string _string_6;

		[CompilerGenerated]
		private List<KataRibbonCommandInfo> _listKataribboncommandinfo_7;

		internal static KataRibbonCommand _kataribboncommand_8;

		public int Index
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _return_26;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Title
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

		public List<KataRibbonCommandInfo> Commands
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
		public KataRibbonCommand()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KataRibbonCommand()
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
									goto _goto_24;
								}
								goto case 2;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = _return_26;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fda9dec917b14c45931e0d4eb71de6b8 != _return_26)
							{
								num3 = 7;
							}
							continue;
						case 1:
							break;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bee00e7049644e96b9f0679762a49ac6 == _return_26)
							{
								num3 = 1;
							}
							continue;
						case _return_26:
							return;
						}
						goto _goto_25;
						continue;
						_goto_24:
						break;
					}
					continue;
					_goto_25:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_3()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KataRibbonCommand GetKataribboncommand_4()
		{
			return null;
		}
	}

	public class KataRibbonCommandInfo
	{
		[CompilerGenerated]
		private string _string_12;

		[CompilerGenerated]
		private string _string_13;

		[CompilerGenerated]
		private string _string_14;

		[CompilerGenerated]
		private int _int_15;

		[CompilerGenerated]
		private int _int_16;

		private static KataRibbonCommandInfo _kataribboncommandinfo_17;

		public string CommandName
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

		public string DisplayName
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

		public string Shortcut
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

		public int DefaultOrder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _return_26;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int ClickCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _return_26;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KataRibbonCommandInfo()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KataRibbonCommandInfo()
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
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c9fe3f02f7e845bd8d8e0e7e226ffca4 == _return_26)
							{
								num3 = 7;
							}
							continue;
						case 1:
							goto _goto_25;
						case _return_26:
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
							num3 = _return_26;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1a1ae42c9fb647b2ac3ccb55018de5e5 == _return_26)
							{
								num3 = 8;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_25:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 8;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 != _return_26)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_5()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KataRibbonCommandInfo GetKataribboncommandinfo_6()
		{
			return null;
		}
	}

	private static readonly object _object_21;

	private static Delegate _delegate_22;

	internal static Kata_Ribbon _kataRibbon_23;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Kata_Ribbon()
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
						if (num2 == 11)
						{
							_object_21 = AppDelegate_535.wjxFYLRMFLK(new object(), AppDelegate_535.F6aFYUIUeMW);
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1ffce1ae5ca247c08901d03e85fad9fb == _return_26)
							{
								num3 = 2;
							}
							continue;
						}
						goto _goto_24;
					case 4:
						break;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 8;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_23ef80aa2deb4a7baaac6de0becd9a10 == _return_26)
						{
							num3 = 1;
						}
						continue;
					case 1:
						AppClass_016.QB3DbWPnHbY();
						num3 = _return_26;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_95ebb0ec672545908f1e6a0795e947dd != _return_26)
						{
							num3 = 1;
						}
						continue;
					case 3:
						return;
					case _return_26:
						AppClass_054.IveTMUdyS5E();
						num3 = 4;
						continue;
					}
					goto _goto_25;
					continue;
					_goto_24:
					break;
				}
				continue;
				_goto_25:
				break;
			}
			while (num2 == 992);
			AppClass_051.f8oTg3pM5fk();
			num = 11;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e953190ed2f64b37a09a51d9a33874ca == _return_26)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_7()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_8()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnKataRibbonItemInitialized(object sender, object e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Type GetType_9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Type GetType_10(object P_0, object P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_11(ref string P_0, ref string P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetObject_12(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetObject_13(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_14(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetObject_15()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_16()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_17()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_18(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetObject_19()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_20(object P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_21(object P_0, object P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_22(object P_0, List<KataRibbonCommandInfo> P_1, int P_2, int P_3, int P_4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_23(object P_0, List<object> P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_24(object P_0, List<object> P_1, int P_2, int P_3, int P_4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetInt_25(int P_0)
	{
		return _return_26;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_26(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object GetObject_27(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static BitmapImage GetBitmapimage_28(object P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 644
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetString_29(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetString_30()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_31()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, int> GetDictionaryStringInt_32()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_33(Dictionary<string, int> P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_34(object P_0)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_35(object P_0, Dictionary<string, int> P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, string> GetDictionaryStringString_36()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_37(object P_0, ref string P_1, ref string P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_38(object P_0, Dictionary<string, string> P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("KATA_RIBBON")]
	public static void CreateKataRibbonCommand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KataRibbonCommand> GetListKataribboncommand_39(bool loadFromGoiLenh = true)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.IndexOutOfRangeException: Index was outside the bounds of the array.
		//    at ICSharpCode.Decompiler.Util.BitSet.Set(Int32 index) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 196
		//    at ICSharpCode.Decompiler.Util.BitSet.set_Item(Int32 index, Boolean value) in /_/ICSharpCode.Decompiler/Util/BitSet.cs:line 69
		//    at ICSharpCode.Decompiler.IL.ILReader.PrepareBranchTargetsAndStacksForExceptionHandlers() in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 611
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 497
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in /_/ICSharpCode.Decompiler/IL/ILReader.cs:line 724
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2282
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<KataRibbonCommand> GetListKataribboncommand_40()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static KataRibbonCommand GetKataribboncommand_41(int P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_42(object P_0, object P_1, object P_2, object P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_43()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Kata_Ribbon GetKataRibbon_44()
	{
		return null;
	}
}
