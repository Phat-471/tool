using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_6
{
	public class OpGachJig : DrawJig, IDisposable
	{
		public PolygonModule.Polygon wallTong;

		public diem choosingPoint;

		public double _double_2;

		public double _double_3;

		public List<PolygonModule.CurveXYZ> lCurveX;

		public List<PolygonModule.CurveXYZ> lCurveY;

		private static OpGachJig _opgachjig_4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpGachJig(PolygonModule.Polygon poly, double width, double height)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_1(IsValid_3 P_0, PolygonModule.CurveXYZ P_1, string P_2 = "")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExecuteAction_2(IsValid_3 P_0, string P_1, diem P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsValid_3(IsValid_3 draw)
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
		public void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static OpGachJig()
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
									goto _goto_5;
								}
								goto case 1;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_81f957ad91a245419918d0a1d8d7e3c4 != 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3da03e4d215640aab6fa9268d1200d6d != 0)
							{
								num3 = 6;
							}
							continue;
						case 0:
							break;
						case 2:
							return;
						}
						goto _goto_8;
						continue;
						_goto_5:
						break;
					}
					continue;
					_goto_8:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 2;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_919abade73404e77ba08bace63d9b14c == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_4()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OpGachJig GetOpgachjig_5()
		{
			return null;
		}
	}

	public static Form_Op_Gach formOpGach;

	private static GetStatic_6 _appclass329_7;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_6()
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
					case 0:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74fd3f679d7f4193893763ebe442ebc5 != 0)
						{
							num3 = 5;
						}
						continue;
					case 2:
						AppClass_051.f8oTg3pM5fk();
						num3 = 3;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 == 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						formOpGach = new Form_Op_Gach();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_c16368ee47214a3ea92e8fd02e53deed != 0)
						{
							num3 = 10;
						}
						continue;
					case 4:
						goto _goto_8;
					case 1:
						return;
					}
					switch (num2)
					{
					case 992:
						break;
					default:
						return;
					case 11:
						AppClass_016.QB3DbWPnHbY();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0295e339d21b49f5ae3dea1307c6082a == 0)
						{
							num3 = 9;
						}
						continue;
					}
					break;
				}
				continue;
				_goto_8:
				break;
			}
			AppClass_016.TqZDb19vgxf();
			num = 7;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2fd7730740d245ffb855794cabb17218 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpGach()
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
	internal static bool IsValid_7()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_6 GetAppclass329_8()
	{
		return null;
	}
}
