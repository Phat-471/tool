using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[DesignerGenerated]
public class view_mat_cat_dam : Form
{
	public class doan_ghi_thep
	{
		public LineShape line;

		public LineShape[] line_dot;

		public OvalShape[] dot;

		internal static doan_ghi_thep _doanGhiThep_2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public doan_ghi_thep()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static doan_ghi_thep()
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
									goto _goto_3;
								}
								goto case 1;
							}
							AppClass_054.IveTMUdyS5E();
							num3 = 2;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_6e99e32e591e462b8367847de5debd19 == 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							return;
						case 1:
							AppClass_016.TqZDb19vgxf();
							num3 = 0;
							if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_304ef6de120f426182a7983bd4c8621a != 0)
							{
								num3 = 4;
							}
							continue;
						case 0:
							break;
						}
						goto _goto_23;
						continue;
						_goto_3:
						break;
					}
					continue;
					_goto_23:
					break;
				}
				AppClass_016.QB3DbWPnHbY();
				num = 9;
				if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_24719cccbece427b9ca340b0b8914683 == 0)
				{
					num = 3;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsValid_1()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static doan_ghi_thep GetDoanGhiThep_2()
		{
			return null;
		}
	}

	private IContainer _icontainer_5;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupView")]
	private GroupBox _Groupview;

	[CompilerGenerated]
	[AccessedThroughProperty("BindingSource1")]
	private BindingSource _bindingsource_6;

	[AccessedThroughProperty("hs2")]
	[CompilerGenerated]
	private TextBox _Hs2;

	[AccessedThroughProperty("ve_mc_dam")]
	[CompilerGenerated]
	private Button _VeMcDam;

	[CompilerGenerated]
	[AccessedThroughProperty("Ct")]
	private TextBox _Ct;

	[CompilerGenerated]
	[AccessedThroughProperty("Z1")]
	private TextBox _Z1;

	[CompilerGenerated]
	[AccessedThroughProperty("hs1")]
	private TextBox _Hs1;

	[AccessedThroughProperty("Thep_duoi")]
	[CompilerGenerated]
	private TextBox _ThepDuoi;

	[AccessedThroughProperty("Thep_tren")]
	[CompilerGenerated]
	private TextBox _ThepTren;

	[AccessedThroughProperty("Cancel")]
	[CompilerGenerated]
	private Button _Cancel;

	[AccessedThroughProperty("b_dam")]
	[CompilerGenerated]
	private TextBox _BDam;

	[CompilerGenerated]
	[AccessedThroughProperty("h_dam")]
	private TextBox _HDam;

	[CompilerGenerated]
	[AccessedThroughProperty("Z2")]
	private TextBox _Z2;

	[AccessedThroughProperty("Thep_dai_mc")]
	[CompilerGenerated]
	private TextBox _ThepDaiMc;

	[AccessedThroughProperty("mc_Grid")]
	[CompilerGenerated]
	private DataGridView _datagridview_7;

	[AccessedThroughProperty("leg1L")]
	[CompilerGenerated]
	private Label _label_8;

	[AccessedThroughProperty("leg1")]
	[CompilerGenerated]
	private TextBox _Leg1;

	[AccessedThroughProperty("leg2")]
	[CompilerGenerated]
	private TextBox _Leg2;

	[AccessedThroughProperty("leg2L")]
	[CompilerGenerated]
	private Label _label_9;

	[AccessedThroughProperty("a_bv")]
	[CompilerGenerated]
	private TextBox _ABv;

	[CompilerGenerated]
	[AccessedThroughProperty("a_bvL")]
	private Label _ABvl;

	[AccessedThroughProperty("Ten_ck")]
	[CompilerGenerated]
	private DataGridViewTextBoxColumn _datagridviewtextboxcolumn_10;

	[CompilerGenerated]
	[AccessedThroughProperty("L_dam")]
	private DataGridViewTextBoxColumn _LDam;

	[CompilerGenerated]
	[AccessedThroughProperty("so_luong")]
	private DataGridViewTextBoxColumn _SoLuong;

	private LineShape[,] _lineshape_11;

	private LineShape[,] _lineshape_12;

	private LineShape[] _lineshapearray_13;

	private LineShape[,] _lineshape_14;

	private LineShape[,] _lineshape_15;

	private LineShape[] _lineshapearray_16;

	private doan_ghi_thep _doanGhiThep_17;

	private doan_ghi_thep _doanGhiThep_18;

	private PreviewCanvas _previewcanvas_19;

	private double _double_20;

	private diem _diem_21;

	private static view_mat_cat_dam _viewMatCatDam_22;

	internal virtual GroupBox GroupView
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

	internal virtual TextBox hs2
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

	internal virtual Button ve_mc_dam
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

	internal virtual TextBox Ct
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

	internal virtual TextBox Z1
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

	internal virtual TextBox hs1
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

	internal virtual TextBox Thep_duoi
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

	internal virtual TextBox Thep_tren
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

	internal virtual Button Cancel
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

	internal virtual TextBox b_dam
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

	internal virtual TextBox h_dam
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

	internal virtual TextBox Z2
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

	internal virtual TextBox Thep_dai_mc
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

	internal virtual DataGridView mc_Grid
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

	internal virtual Label leg1L
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

	internal virtual TextBox leg1
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

	internal virtual TextBox leg2
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

	internal virtual Label leg2L
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

	internal virtual TextBox a_bv
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

	internal virtual Label a_bvL
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

	internal virtual DataGridViewTextBoxColumn Ten_ck
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

	internal virtual DataGridViewTextBoxColumn L_dam
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

	internal virtual DataGridViewTextBoxColumn so_luong
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
	public view_mat_cat_dam()
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
	private void GetDebuggerstepthroughPrivateVoid_3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual BindingSource GetSpecialnameCompilergeneratedInternalVirtualBindingsource_4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void GetSpecialnameCompilergeneratedInternalVirtualVoid_5(BindingSource WithEventsValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_6(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cap_nhat_lineshape(diem d1, diem d2, LineShape lineS)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void move_textbox(TextBox text, double x, double y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_7(TextBox text, diem d1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void cap_nhat_dim(int i, TextBox text, diem d1, diem d2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_8(ref doan_ghi_thep thep, diem goc1, TextBox text, double t, double a = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_9(ref doan_ghi_thep thep, int sl)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_10(ref doan_ghi_thep thep, int sl)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_11(int i, TextBox text, diem d1, diem d2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteAction_12()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_13(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_14(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_15(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_16(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_17(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_18(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_19(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_20(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_21(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_22(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static view_mat_cat_dam()
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
					case 0:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						continue;
					case 1:
						goto _goto_23;
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
						AppClass_016.QB3DbWPnHbY();
						num3 = 9;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_37b0091396744102a21e76ffc34b8972 == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				continue;
				_goto_23:
				break;
			}
			AppClass_016.TqZDb19vgxf();
			num = 3;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_304ef6de120f426182a7983bd4c8621a == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_23()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static view_mat_cat_dam GetViewMatCatDam_24()
	{
		return null;
	}
}
