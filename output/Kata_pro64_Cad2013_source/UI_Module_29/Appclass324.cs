using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class GetStatic_2 : IDisposable
{
	public Dictionary<string, Info_ColumnWall3D> Columns;

	public Dictionary<string, Info_Beam3D> Beams;

	public Dictionary<string, Info_Slab3D> Slabs;

	public Dictionary<string, Info_Slab3D> Anchors;

	public Dictionary<string, info_CurveGrid> Grids;

	public SortedDictionary<string, info_SecondBeam> SecondBeams;

	public Dictionary<string, AppClass_325> Sources;

	public Dictionary<string, AppClass_325> GridMarkers;

	public Dictionary<string, List<string>> GridMembers;

	public List<string> Warnings;

	public Dictionary<string, object> Documents;

	public Info_Slab3D Outline;

	public bool _bool_2;

	internal static GetStatic_2 _appclass324_3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetStatic_2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Track(string key, object entity, string ownerFile = "", string instancePath = "", string reason = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
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

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_2()
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
								goto _goto_4;
							}
							goto case 2;
						}
						AppClass_054.IveTMUdyS5E();
						num3 = 8;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_3d856b94665044e6b2ba303819a86373 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 1:
						break;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_fffa250e23d54447ae24cd613778be2e != 0)
						{
							num3 = 7;
						}
						continue;
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
			AppClass_016.QB3DbWPnHbY();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_00b3130823b245fab24ede09ecc55ae9 != 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_2 GetAppclass324_4()
	{
		return null;
	}
}
