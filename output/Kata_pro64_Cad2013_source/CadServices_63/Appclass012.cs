using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.GraphicsInterface;
using Module_21;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
internal sealed class GetStatic_4
{
	public class PolyLineJig : DrawJig, IDisposable
	{
		private bool reverse;

		private Point3d choosingPoint;

		private Point3d _point3d_2;

		public object poly;

		public Point3d choosingPointReturn;

		public List<Point3d> _listPoint3d_3;

		internal static object _object_4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PolyLineJig(Polyline poly, bool _reverse)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Tuple<Point3d, List<Point3d>> GetClosestPoint(Point3d choosingPoint)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsValid_1(IsValid_1 draw)
		{
			return true;
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
		static PolyLineJig()
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
								num3 = 0;
								if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2b1fe59a05ae4c9dae18bd56ce63ed12 != 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto _goto_36;
						case 1:
							break;
						case 2:
							return;
						case 0:
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							continue;
						}
						goto _goto_37;
						continue;
						_goto_36:
						break;
					}
					continue;
					_goto_37:
					break;
				}
				while (num2 == 990);
				AppClass_016.TqZDb19vgxf();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a50c1cb7e05c492e991b1bdcba875651 != 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_2()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PolyLineJig GetPolylinejig_3()
		{
			return null;
		}
	}

	private static double _double_7;

	private static double _double_8;

	private static double _double_9;

	private static double _double_10;

	private static bool _bool_11;

	private static object _object_12;

	private static int _int_13;

	private static int _int_14;

	private static int _int_15;

	private static object _object_16;

	private static object UJCCUkhwACR;

	private static object _object_17;

	private static object _object_18;

	private static object _object_19;

	private static object _object_20;

	private static object _object_21;

	private static object _object_22;

	private static object _object_23;

	private static object _object_24;

	private static object _object_25;

	private static object _object_26;

	private static List<string> _listString_27;

	private static object _object_28;

	private static object _object_29;

	private static bool _bool_30;

	private static List<PolygonModule.Polygon> _polygon_31;

	private static object _object_32;

	private static List<double> _listDouble_33;

	private static bool _bool_34;

	internal static object _object_35;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_4()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 3;
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
						if (num2 != 29)
						{
							if (num2 == 1010)
							{
								goto _goto_36;
							}
							goto case 8;
						}
						_double_7 = 100.0;
						num3 = 27;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_eb61602f220c449987b38149b02fa612 == 0)
						{
							num3 = 8;
						}
						continue;
					case 0:
						_bool_34 = false;
						num = 20;
						break;
					case 5:
						_listString_27 = new List<string>();
						num3 = 9;
						continue;
					case 8:
						_double_8 = 150.0;
						num3 = 13;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_58783c6b9b814700822d1019a7acc9a4 != 0)
						{
							num3 = 17;
						}
						continue;
					case 19:
						_object_17 = "";
						num3 = 4;
						continue;
					case 13:
						_double_10 = 30.0;
						num3 = 6;
						continue;
					case 16:
						_object_32 = null;
						num3 = 15;
						continue;
					case 7:
						AppClass_054.IveTMUdyS5E();
						num3 = 12;
						continue;
					case 17:
						_double_9 = 25.0;
						num3 = 21;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6e99e32e591e462b8367847de5debd19 != 0)
						{
							num3 = 13;
						}
						continue;
					case 20:
						return;
					case 3:
						AppClass_016.TqZDb19vgxf();
						num3 = 2;
						continue;
					case 11:
						_object_21 = "";
						num3 = 10;
						continue;
					case 18:
						UJCCUkhwACR = "";
						num3 = 19;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_ea2c693adaae4aa18af017c6a164943e == 0)
						{
							num3 = 12;
						}
						continue;
					case 9:
						_bool_30 = true;
						num3 = 21;
						continue;
					case 10:
						_object_22 = new string[8];
						num3 = 13;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_0295e339d21b49f5ae3dea1307c6082a != 0)
						{
							num3 = 22;
						}
						continue;
					case 14:
						_object_20 = "";
						num3 = 11;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_bad34da0baf04846aad31d764d589a90 != 0)
						{
							num3 = 1;
						}
						continue;
					case 15:
						_listDouble_33 = new List<double>();
						num3 = 7;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2d4a32d5aa4341e59cdd7055ceb6be5d == 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						_object_18 = "";
						num3 = 21;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_2c5ed65e184444198b3daa27c33768a3 != 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						AppClass_016.QB3DbWPnHbY();
						num3 = 7;
						continue;
					case 6:
						_object_16 = "";
						num3 = 18;
						continue;
					case 21:
						_polygon_31 = new List<PolygonModule.Polygon>();
						num3 = 16;
						continue;
					case 1:
						_object_19 = "";
						num3 = 14;
						continue;
					case 22:
						_object_25 = new Collection();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_28f7376b2f5c4626b68ba1f8e68d9ff7 != 0)
						{
							num3 = 5;
						}
						continue;
					case 12:
						AppClass_051.f8oTg3pM5fk();
						num = 29;
						break;
					}
					goto _goto_37;
					continue;
					_goto_36:
					break;
				}
				continue;
				_goto_37:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<Point3d> GetListPoint3d_5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Tuple<Point3d, List<Point3d>> GetTuplePoint3dListPoint3d_6(object P_0, double P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Polyline GetPolyline_7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Tuple<Polyline, Point3d> GetTuplePolylinePoint3d_8(object P_0, List<Point3d> P_1, int P_2, object P_3, bool P_4 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_9(Point3d P_0, Point3d P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_10(ref Polyline P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Arc uWXC4qvYPg0(object P_0, int P_1, int P_2 = 0, Point3d P_3 = default(Point3d))
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Tuple<Polyline, bool, Point3d, double, Point3d> GetTuplePolylineBoolPoint3dDoublePoint3d_11(object P_0, List<Point3d> P_1, int P_2, object P_3, bool P_4, object P_5)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteAction_12()
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
	public static void ExecuteAction_13(object P_0)
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
	public static void ExecuteAction_14(object P_0, double P_1, object P_2)
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
	private static bool I59CUwR4GPL(object P_0, double P_1, [Optional][DefaultParameterValue(0.0)] ref double P_2)
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
	private static double GetDouble_15(object P_0, double P_1, double P_2, double P_3)
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
	private static List<double> GetListDouble_16(List<double> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<double> GetListDouble_17(double P_0 = -1.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_18(object P_0, double P_1)
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
	private static void ExecuteAction_19(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Polyline GetPolyline_20(object P_0, double P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_21(object P_0, List<double> P_1)
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
	private static Polyline GetPolyline_22(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Polyline GetPolyline_23(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExecuteAction_24(object P_0, bool P_1)
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
	public static void ExecuteAction_25()
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
	public static void ExecuteAction_26(bool P_0 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Tuple<Polyline, Polyline> GetTuplePolylinePolyline_27(object P_0, List<Point3d> P_1, int P_2, double P_3 = 0.0)
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
	private static void ExecuteAction_28(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_29()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_4 GetAppclass012_30()
	{
		return null;
	}
}
