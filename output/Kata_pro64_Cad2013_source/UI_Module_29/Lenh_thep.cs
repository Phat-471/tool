using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.Runtime;
using Module_21;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class Lenh_thep : IExtensionApplication
{
	public static Info_rebar info_rebar;

	public static view_thang_new view_thang_new;

	public static view_mong_don_new view_mong_don;

	public static view_mat_cat_dam view_mat_cat_dam;

	public static view_san view_san;

	public static Input_anchor input_anchor;

	public static _appform342_4 _appform342_4;

	public static Input_slab input_slab;

	public static Info_slab info_slab;

	public static User_kho_thep User_kho_thep;

	public static Danh_ten Danh_ten;

	public static AppForm_349 _appform349_3;

	public static Lanh_to lanh_to;

	public static _appform342_4 _appform342_4;

	public static Setting_atlas setting_atlas;

	public static Main_rebar_Column Main_rebar_Column;

	public static Edit_moc_dai edit_moc_dai;

	public static Grid_plan Grid_plan;

	public static Grid_Data Grid_data;

	public static Rai_dam Revit_rai_dam;

	public static Rai_cot Revit_rai_cot;

	public static Tim_thep Tim_thep;

	public static FormGanTaiTrong FormGanTaiTrong;

	private bool _bool_5;

	internal static Lenh_thep _lenhThep_6;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Lenh_thep()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 18;
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
						if (num2 != 30)
						{
							if (num2 == 1011)
							{
								goto _goto_7;
							}
							goto case 9;
						}
						Main_rebar_Column = new Main_rebar_Column();
						num3 = 8;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_00f0a279ec4b44848c113e5f3a57df39 != 0)
						{
							num3 = 7;
						}
						continue;
					case 18:
						AppClass_016.TqZDb19vgxf();
						num3 = 17;
						continue;
					case 15:
						_appform342_4 = new _appform342_4();
						num3 = 23;
						continue;
					case 12:
						lanh_to = new Lanh_to();
						num3 = 15;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_559789cacd7f46ac973fb693ed94037f == 0)
						{
							num3 = 23;
						}
						continue;
					case 5:
						User_kho_thep = new User_kho_thep();
						num3 = 22;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a14f8f515ea3469fbc1ca3774ed845e8 != 0)
						{
							num3 = 21;
						}
						continue;
					case 8:
						edit_moc_dai = new Edit_moc_dai();
						num3 = 2;
						continue;
					case 22:
						Danh_ten = new Danh_ten();
						num3 = 3;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_78acf557389e4c83804bda1025ad65ea == 0)
						{
							num3 = 7;
						}
						continue;
					case 23:
						setting_atlas = new Setting_atlas();
						num = 30;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b == 0)
						{
							num = 1;
						}
						break;
					case 13:
						info_slab = null;
						num3 = 20;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_dffdc5b0c094467f83b86f40cc324b71 != 0)
						{
							num3 = 5;
						}
						continue;
					case 9:
						view_thang_new = null;
						num3 = 6;
						continue;
					case 16:
						input_slab = null;
						num3 = 13;
						continue;
					case 19:
						view_san = new view_san();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6639d8e551bd44619b5ef505e18c8532 == 0)
						{
							num3 = 25;
						}
						continue;
					case 3:
						_appform349_3 = new AppForm_349();
						num3 = 24;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4a7aa1ebfa9d48cb96217ed16a213684 != 0)
						{
							num3 = 12;
						}
						continue;
					case 17:
						AppClass_016.QB3DbWPnHbY();
						num3 = 24;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e761100d2cf44e67808f34385eabece7 == 0)
						{
							num3 = 7;
						}
						continue;
					case 14:
						AppClass_051.f8oTg3pM5fk();
						num3 = 4;
						continue;
					case 6:
						view_mong_don = null;
						num3 = 21;
						continue;
					case 4:
						info_rebar = new Info_rebar();
						num3 = 21;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1ffce1ae5ca247c08901d03e85fad9fb != 0)
						{
							num3 = 9;
						}
						continue;
					case 2:
						Grid_plan = new Grid_plan();
						num3 = 20;
						continue;
					case 10:
						FormGanTaiTrong = new FormGanTaiTrong();
						num3 = 24;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6bc76ddff42e43b3abef2b1a6c67dc05 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 11:
						_appform342_4 = null;
						num3 = 16;
						continue;
					case 20:
						Tim_thep = new Tim_thep();
						num3 = 10;
						continue;
					case 7:
						AppClass_054.IveTMUdyS5E();
						num = 14;
						break;
					case 1:
						input_anchor = new Input_anchor();
						num3 = 11;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_a50c1cb7e05c492e991b1bdcba875651 != 0)
						{
							num3 = 23;
						}
						continue;
					case 21:
						view_mat_cat_dam = new view_mat_cat_dam();
						num3 = 19;
						continue;
					}
					goto _goto_8;
					continue;
					_goto_7:
					break;
				}
				continue;
				_goto_8:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lenh_thep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bat_dau()
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
	public int Date_create_file(string path)
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
	public void ket_thuc()
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
	[CommandMethod("ve_thep")]
	public void Ve_thep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Tao_thep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Create_link()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void sua_moc_dai()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_5()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Update_link()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Update_mong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Update_cong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Copy_link()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Delete_link()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Find_link()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("xoa_highlight")]
	public void ExecuteAction_9()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("Update_Block_ColumnWall")]
	public void update_Block_ColumnWall()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Ghi_thep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_10()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("cat_tuy_y")]
	public void ExecuteAction_11()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("noi_thep")]
	public void ExecuteAction_12()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("tao_tieu_de")]
	public void ExecuteAction_13()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("doi_mau_thep")]
	public void ExecuteAction_14()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_15()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("dimthep")]
	public void Dimthep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_16()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_17()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Setupthep_cot()
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
	[CommandMethod("to_hop_thep")]
	public void ExecuteAction_18()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Thong_ke()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Suatk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void sosanh_tk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_19()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Tkcoupler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Thong_ke_san()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Cadtoexcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Cadtoexcelqh()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("chuyen")]
	public void ExecuteAction_20()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_21()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void check_lap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_22()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Load_beam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Load_column()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Load_wall()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_23()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Ve_hm_tru()
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
	[CommandMethod("QS")]
	public void Trien_khai_QS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("xuatQS")]
	public void XuatQS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_24()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_25()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public static void cat_doituong1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("taomv")]
	public void Taomv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("taomv1")]
	public void ExecuteAction_26()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_27()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_28()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_29()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_30()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_31()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_32()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_33()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_34()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_35()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("ve_mong_don")]
	public void Ve_mong_new()
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
	[CommandMethod("ve_mong_coc")]
	public void ExecuteAction_36()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vecot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vecot_shop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vevach()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vevach_shop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("ve_loi_vach")]
	public void ExecuteAction_37()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vedam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vedam_shop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vedammong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vegiangmong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_38()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("ve_dam_mc")]
	public void ExecuteAction_39()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("dam_giao")]
	public void ExecuteAction_40()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("ve_dam_xien")]
	public void ExecuteAction_41()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vedamcong()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("ve_san")]
	public void Ve_san()
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
	[CommandMethod("vesanpl")]
	public void Ve_san_polyline()
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
	[CommandMethod("vesan4d")]
	public void ExecuteAction_42()
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
	[CommandMethod("vemc")]
	public static void ExecuteAction_43()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("ve_thang")]
	public void Ve_thang_new()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_44()
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
	[CommandMethod("ve_grid")]
	public void Ve_grid()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_45()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void dim_block_cot1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_46()
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
	[CommandMethod("pick_diem_san")]
	public void ExecuteAction_47()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_48()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_49()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_50()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_51()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_52()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Xu_ly_cat_dam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_53()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_54()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_55()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_56()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_57()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void tim_ten_ck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_58()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_59()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_60()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("chia_san")]
	public void ExecuteAction_61()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_62()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void RM1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void quet_dam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void quet_dam_all()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Save_thep_dam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_63()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_64()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Add_thep_dam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void show_thep_dam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void VedamMC_all()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Vedam_all()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_65()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("Etabs")]
	public void Etabs_Model()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("GanTai")]
	public void Etabs_GanTai()
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
	[CommandMethod("HoatTai")]
	public void Etabs_RaiTai()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("pdfkata")]
	public void ExecuteAction_66()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Onlinekata()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_67()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_68()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("setupatlas")]
	public void goi_setting_atlas()
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
	[CommandMethod("setupkata1")]
	public void Goi_setting()
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
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_69()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_70()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Thong_ke_Uc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_71()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_72()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Danhsothep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_73()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_74()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_75()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Update_leg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_76()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_77()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void Update_dai()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("khthep")]
	public void ExecuteAction_78()
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
	[CommandMethod("openning")]
	public void ExecuteAction_79()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("adappt")]
	public void Adappt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("loadkho")]
	public void Loadkho()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("upkho")]
	public void Upkho()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_80()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_81()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_82()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_83()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_84()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_85()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_86()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_87()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("serikata")]
	public static void Serikata()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_88()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod(/*Could not decode attribute arguments.*/)]
	public void ExecuteAction_89()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_90()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Lenh_thep GetLenhThep_91()
	{
		return null;
	}
}
