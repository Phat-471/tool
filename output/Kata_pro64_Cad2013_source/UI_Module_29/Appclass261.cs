using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_24
{
	public class InfoDamCongMbkcXData
	{
		[CompilerGenerated]
		private string _string_2;

		[CompilerGenerated]
		private string _string_3;

		[CompilerGenerated]
		private string _string_4;

		[CompilerGenerated]
		private string _string_5;

		[CompilerGenerated]
		private string _string_6;

		[CompilerGenerated]
		private string _string_7;

		private static InfoDamCongMbkcXData _infodamcongmbkcxdata_8;

		public string TenDam
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

		public string B
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

		public string H
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

		public string TypeBeam
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

		public string CaoDo
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

		public string Tai
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
		public InfoDamCongMbkcXData()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoDamCongMbkcXData()
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
									goto _goto_9;
								}
								goto case 1;
							}
							AppClass_016.QB3DbWPnHbY();
							num3 = 8;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2d4a32d5aa4341e59cdd7055ceb6be5d == _return_12)
							{
								num3 = 1;
							}
							continue;
						case 2:
							break;
						case _return_12:
							return;
						case 1:
							AppClass_054.IveTMUdyS5E();
							num3 = _return_12;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_b9e2daf7fc654380a6e3cccb053c48a9 == _return_12)
							{
								num3 = 9;
							}
							continue;
						}
						goto _goto_13;
						continue;
						_goto_9:
						break;
					}
					continue;
					_goto_13:
					break;
				}
				AppClass_016.TqZDb19vgxf();
				num = 2;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_304ef6de120f426182a7983bd4c8621a == _return_12)
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
		internal static InfoDamCongMbkcXData GetInfodamcongmbkcxdata_2()
		{
			return null;
		}
	}

	public const string LOAIDATADAMCONGMBKC = "KATA_DAM_CONG_MKBC";

	public const string LOAIDATATHEHIENDAMCONGMBKC = "KATA_DAM_CONG_MKBC_THE_HIEN";

	internal static GetStatic_24 _appclass261_11;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static InfoDamCongMbkcXData GetDamCongMbkcXData(object objent)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDamCongMbkcXData(object objent, InfoDamCongMbkcXData info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Beam3D GetInfoBeam3d_3(object objent)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TypeBeam GetTypebeam_4(string typeBeamText)
	{
		return (TypeBeam)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasDamCong(IEnumerable<Info_Beam3D> beams)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Beam3D PrepareBeamForMbkc(Info_Beam3D source)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetDouble_5(PolygonModule.CurveXYZ axis, diem point)
	{
		return _return_12._return_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValid_6(IEnumerable<Info_Beam3D> beams, ref PolygonModule.CurveXYZ axis)
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
	public static bool IsValid_7(IEnumerable<Info_Beam3D> beams)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double BeamPathSortKey(Info_Beam3D beam)
	{
		return _return_12._return_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PolygonModule.CurveXYZ GetBeamPathCurveAtPoint(Info_Beam3D beam, diem p)
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
	public static double BeamPathAngleAtPoint(Info_Beam3D beam, diem p)
	{
		return _return_12._return_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PolygonModule.Polygon GetExtendedBeamPath(Info_Beam3D beam, double delta)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetListDiem_8(Info_Beam3D beam, PolygonModule.Polygon pl, ref int vt_giao)
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
	public static diem BeamPathNearestPointOnPath(Info_Beam3D beam, diem p)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem BeamPathNearestPointForSupport(Info_Beam3D beam, diem p, [Optional][DefaultParameterValue(_return_12._return_12)] ref double station)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> UniqueBeamPathPoints(List<diem> points, double tolerance = 5._return_12)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PolygonModule.Polygon GetPolygon_9(Info_Beam3D source, diem p1, diem p2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Beam3D GetInfoBeam3d_10(Info_Beam3D source, diem p1, diem p2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_11(ref Info_Beam3D beam, diem p)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_12(ref Info_Beam3D beam, diem p)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_13(Info_Beam3D source, diem p1, diem p2, ref List<Info_Beam3D> spans)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_14(ref Info_Beam3D firstBeam, Info_Beam3D secondBeam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PolygonModule.Polygon BeamPath(Info_Beam3D beam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem BeamPathStart(Info_Beam3D beam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem BeamPathEnd(Info_Beam3D beam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double BeamPathLength(Info_Beam3D beam)
	{
		return _return_12._return_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double BeamPathLengthAtPoint(Info_Beam3D beam, diem p)
	{
		return _return_12._return_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem BeamPathPointAtLength(Info_Beam3D beam, double length)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsCurvedBeamPath(Info_Beam3D beam)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Info_Beam3D CloneBeamWithCenterLine(Info_Beam3D source, PolygonModule.Polygon centerLine)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReverseBeamPath(ref Info_Beam3D beam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<Info_Beam3D, Info_Beam3D> CutBeamPathAtPoint(Info_Beam3D source, diem p)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Tuple<Info_Beam3D, Info_Beam3D, Info_Beam3D> CutBeamPathAtTwoPoints(Info_Beam3D source, diem p1, diem p2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetBeamPathNearestPoint(Info_Beam3D beam, diem p)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<diem> GetBeamPathIntersectionWithPolygon(Info_Beam3D beam, PolygonModule.Polygon pl)
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
	public static List<diem> GetBeamPathIntersectionWithBeam(Info_Beam3D beam, Info_Beam3D beamGiao)
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
	private static void ExecuteAction_15(ref List<diem> P_0, List<diem> P_1, double P_2 = 5._return_12)
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
	private static PolygonModule.Polygon GetPolygon_16(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_17(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_18(object P_0)
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
	private static int GetInt_19(object P_0, object P_1)
	{
		return _return_12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_20(TypeBeam P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_21(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_22(object P_0, object P_1)
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
	private static void ExecuteAction_23(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void update_cong1()
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
					case _return_12:
						return;
					case 2:
						AppClass_054.IveTMUdyS5E();
						num3 = _return_12;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_934fee42d4914438a301122ea3a645b4 == _return_12)
						{
							num3 = 5;
						}
						continue;
					case 1:
						goto _goto_13;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						AppClass_016.QB3DbWPnHbY();
						num3 = _return_12;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3e20b8f0eaaf4c2c858e7c7ca7131a33 != _return_12)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				continue;
				_goto_13:
				break;
			}
			AppClass_016.TqZDb19vgxf();
			num = 3;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1ffce1ae5ca247c08901d03e85fad9fb != _return_12)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_25()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_24 GetAppclass261_26()
	{
		return null;
	}
}
