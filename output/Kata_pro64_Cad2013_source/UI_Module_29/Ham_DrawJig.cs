using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class Ham_DrawJig
{
	public class BlockBeamJig : DrawJig, IDisposable
	{
		private List<object> _listObject_2;

		public diem diem_dau;

		public diem diem_cuoi;

		internal static BlockBeamJig _blockbeamjig_3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockBeamJig(diem diem_dau)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsValid_7(IsValid_7 draw)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
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

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockBeamJig()
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
								AppClass_054.IveTMUdyS5E();
								num3 = 0;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bb69b688ab23416fb5187846886dbbdf == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto _goto_14;
						case 0:
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							continue;
						case 1:
							break;
						}
						goto _goto_15;
						continue;
						_goto_14:
						break;
					}
					continue;
					_goto_15:
					break;
				}
				while (num2 == 990);
				AppClass_016.QB3DbWPnHbY();
				num = 4;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_00b3130823b245fab24ede09ecc55ae9 == 0)
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
		internal static BlockBeamJig GetBlockbeamjig_3()
		{
			return null;
		}
	}

	public class BlockColumnJig : DrawJig, IDisposable
	{
		public diem goc;

		public string vitri;

		public string ten;

		private List<object> _listObject_6;

		internal static BlockColumnJig _blockcolumnjig_7;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockColumnJig()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsValid_7(IsValid_7 draw)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
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

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockColumnJig()
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
							goto _goto_15;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e57ad1e8419a431e8d1e6ec991c4f87e == 0)
							{
								num3 = 6;
							}
							continue;
						case 0:
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
							num3 = 8;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bb69b688ab23416fb5187846886dbbdf != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					continue;
					_goto_15:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_5()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BlockColumnJig GetBlockcolumnjig_6()
		{
			return null;
		}
	}

	public class BlockTenJig : DrawJig, IDisposable
	{
		public diem goc;

		public string ten;

		public short color;

		private List<object> _listObject_9;

		internal static BlockTenJig _blocktenjig_10;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockTenJig()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsValid_7(IsValid_7 draw)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
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

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockTenJig()
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
									goto _goto_14;
								}
								goto case 1;
							}
							return;
						case 2:
							AppClass_016.TqZDb19vgxf();
							num3 = 1;
							continue;
						case 0:
							break;
						case 1:
							AppClass_016.QB3DbWPnHbY();
							num3 = 3;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto _goto_15;
						continue;
						_goto_14:
						break;
					}
					continue;
					_goto_15:
					break;
				}
				AppClass_054.IveTMUdyS5E();
				num = 2;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fffa250e23d54447ae24cd613778be2e == 0)
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
		internal static BlockTenJig GetBlocktenjig_9()
		{
			return null;
		}
	}

	internal static Ham_DrawJig _hamDrawjig_13;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Ham_DrawJig()
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
						goto _goto_14;
					case 0:
						break;
					case 1:
						AppClass_016.QB3DbWPnHbY();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c660b2a9f2294e84996cb208a4355bde == 0)
						{
							num3 = 6;
						}
						continue;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 9;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4a7aa1ebfa9d48cb96217ed16a213684 != 0)
						{
							num3 = 1;
						}
						continue;
					}
					goto _goto_15;
					continue;
					_goto_14:
					break;
				}
				continue;
				_goto_15:
				break;
			}
			while (num2 == 990);
			AppClass_054.IveTMUdyS5E();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_57bb817da9f045ada4d7d6d082ce52c4 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_10()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Ham_DrawJig GetHamDrawjig_11()
	{
		return null;
	}
}
