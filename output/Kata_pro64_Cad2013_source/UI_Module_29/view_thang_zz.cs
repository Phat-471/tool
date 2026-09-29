using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[DesignerGenerated]
public class view_thang_zz : Form
{
	private IContainer _icontainer_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Undo")]
	private Button _Undo;

	[AccessedThroughProperty("Cancel")]
	[CompilerGenerated]
	private Button _Cancel;

	[CompilerGenerated]
	[AccessedThroughProperty("rong")]
	private TextBox _Rong;

	[CompilerGenerated]
	[AccessedThroughProperty("rongL")]
	private Label _label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("cover")]
	private TextBox _Cover;

	[AccessedThroughProperty("NumSbt")]
	[CompilerGenerated]
	private NumericUpDown _numericupdown_4;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	private Label _label_5;

	[AccessedThroughProperty("Y")]
	[CompilerGenerated]
	private TextBox _textbox_6;

	[AccessedThroughProperty("X")]
	[CompilerGenerated]
	private TextBox _textbox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("H3")]
	private TextBox _H3;

	[AccessedThroughProperty("Hb2")]
	[CompilerGenerated]
	private TextBox _Hb2;

	[CompilerGenerated]
	[AccessedThroughProperty("H2")]
	private TextBox _H2;

	[AccessedThroughProperty("Hb3")]
	[CompilerGenerated]
	private TextBox _Hb3;

	[CompilerGenerated]
	[AccessedThroughProperty("Hb1")]
	private TextBox _Hb1;

	[CompilerGenerated]
	[AccessedThroughProperty("L1")]
	private TextBox _L1;

	[CompilerGenerated]
	[AccessedThroughProperty("Ct2")]
	private TextBox _Ct2;

	[AccessedThroughProperty("vtri_cn")]
	[CompilerGenerated]
	private ComboBox _combobox_8;

	[CompilerGenerated]
	[AccessedThroughProperty("coverL")]
	private Label _Coverl;

	[CompilerGenerated]
	[AccessedThroughProperty("Mi")]
	private CheckBox _Mi;

	[CompilerGenerated]
	[AccessedThroughProperty("ve_thang")]
	private Button _VeThang;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _groupbox_9;

	[AccessedThroughProperty("cau_tao")]
	[CompilerGenerated]
	private TextBox _CauTao;

	[AccessedThroughProperty("cau_taoL")]
	[CompilerGenerated]
	private Label _CauTaol;

	[CompilerGenerated]
	[AccessedThroughProperty("chiu_nghi")]
	private TextBox _ChiuNghi;

	[AccessedThroughProperty("chiu_nghiL")]
	[CompilerGenerated]
	private Label _ChiuNghil;

	[AccessedThroughProperty("main_steel")]
	[CompilerGenerated]
	private TextBox _MainSteel;

	[AccessedThroughProperty("main_steelL")]
	[CompilerGenerated]
	private Label _MainSteell;

	[CompilerGenerated]
	[AccessedThroughProperty("Ct1")]
	private TextBox _Ct1;

	[AccessedThroughProperty("vtri_cnL")]
	[CompilerGenerated]
	private Label _label_10;

	[AccessedThroughProperty("L2")]
	[CompilerGenerated]
	private TextBox _L2;

	[AccessedThroughProperty("L3")]
	[CompilerGenerated]
	private TextBox _L3;

	[CompilerGenerated]
	[AccessedThroughProperty("Redo")]
	private Button _Redo;

	[AccessedThroughProperty("GroupView")]
	[CompilerGenerated]
	private GroupBox _Groupview;

	[AccessedThroughProperty("BackgroundWorker1")]
	[CompilerGenerated]
	private BackgroundWorker _backgroundworker_11;

	[AccessedThroughProperty("btnLayDuLieu")]
	[CompilerGenerated]
	private Button _button_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _panel_13;

	[AccessedThroughProperty("GroupBox2")]
	[CompilerGenerated]
	private GroupBox _groupbox_14;

	[CompilerGenerated]
	[AccessedThroughProperty("tb_so_cau_kien")]
	private TextBox _TbSoCauKien;

	[AccessedThroughProperty("so_cau_kienL")]
	[CompilerGenerated]
	private Label _SoCauKienl;

	[AccessedThroughProperty("tb_ten_cau_thang")]
	[CompilerGenerated]
	private TextBox _textbox_15;

	[AccessedThroughProperty("ten_cau_thangL")]
	[CompilerGenerated]
	private Label _TenCauThangl;

	[CompilerGenerated]
	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _groupbox_16;

	[AccessedThroughProperty("ve_thang_shop")]
	[CompilerGenerated]
	private Button _button_17;

	[CompilerGenerated]
	[AccessedThroughProperty("Bd2")]
	private TextBox _Bd2;

	[CompilerGenerated]
	[AccessedThroughProperty("Bd3")]
	private TextBox _Bd3;

	[CompilerGenerated]
	[AccessedThroughProperty("L5")]
	private TextBox _L5;

	[CompilerGenerated]
	[AccessedThroughProperty("Bd4")]
	private TextBox _Bd4;

	[CompilerGenerated]
	[AccessedThroughProperty("L4")]
	private TextBox _L4;

	[AccessedThroughProperty("Bd1")]
	[CompilerGenerated]
	private TextBox _Bd1;

	[CompilerGenerated]
	[AccessedThroughProperty("Hd4")]
	private TextBox _Hd4;

	[AccessedThroughProperty("Hd1")]
	[CompilerGenerated]
	private TextBox _Hd1;

	private List<LineShape> _listLineshape_18;

	private LineShape[,] _lineshape_19;

	private PreviewCanvas _previewcanvas_20;

	private int _int_21;

	private double _double_22;

	private bool _bool_23;

	private diem _diem_24;

	private Point _point_25;

	private bool _bool_26;

	private Point _point_27;

	private Point _point_28;

	internal static view_thang_zz _viewThangZz_29;

	internal virtual Button Undo
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

	internal virtual TextBox rong
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

	internal virtual Label rongL
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

	internal virtual TextBox cover
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

	internal virtual NumericUpDown NumSbt
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

	internal virtual Label Label3
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

	internal virtual TextBox Y
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

	internal virtual TextBox X
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

	internal virtual TextBox H3
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

	internal virtual TextBox Hb2
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

	internal virtual TextBox H2
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

	internal virtual TextBox Hb3
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

	internal virtual TextBox Hb1
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

	internal virtual TextBox L1
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

	internal virtual TextBox Ct2
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

	internal virtual ComboBox vtri_cn
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

	internal virtual Label coverL
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

	internal virtual CheckBox Mi
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

	internal virtual Button ve_thang
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

	internal virtual GroupBox GroupBox1
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

	internal virtual TextBox cau_tao
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

	internal virtual Label cau_taoL
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

	internal virtual TextBox chiu_nghi
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

	internal virtual Label chiu_nghiL
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

	internal virtual TextBox main_steel
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

	internal virtual Label main_steelL
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

	internal virtual TextBox Ct1
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

	internal virtual Label vtri_cnL
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

	internal virtual TextBox L2
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

	internal virtual TextBox L3
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

	internal virtual Button Redo
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

	internal virtual Button btnLayDuLieu
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

	internal virtual Panel Panel1
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

	internal virtual GroupBox GroupBox2
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

	internal virtual TextBox tb_so_cau_kien
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

	internal virtual Label so_cau_kienL
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

	internal virtual TextBox tb_ten_cau_thang
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

	internal virtual Label ten_cau_thangL
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

	internal virtual GroupBox GroupBox3
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

	internal virtual Button ve_thang_shop
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

	internal virtual TextBox Bd2
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

	internal virtual TextBox Bd3
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

	internal virtual TextBox L5
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

	internal virtual TextBox Bd4
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

	internal virtual TextBox L4
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

	internal virtual TextBox Bd1
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

	internal virtual TextBox Hd4
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

	internal virtual TextBox Hd1
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
	public view_thang_zz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
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
	[DebuggerStepThrough]
	private void GetDebuggerstepthroughPrivateVoid_1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual BackgroundWorker GetSpecialnameCompilergeneratedInternalVirtualBackgroundworker_2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void GetSpecialnameCompilergeneratedInternalVirtualVoid_3(BackgroundWorker WithEventsValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_4(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Ve_hinh_thang(bool movingTextBox = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_5(GroupBox P_0, bool P_1)
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
	private void HandleEvent_6(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_7(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_8(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_9(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_10(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_11(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_12(object P_0, EventArgs P_1)
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
	public void cap_nhat_dim(int i, TextBox text, diem d1, diem d2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Cap_nhat_lineshape(diem d1, diem d2, LineShape lineS)
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
	private void HandleEvent_23(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_24(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_25(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_26(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_27(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteAction_28(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_29(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setDefault()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_30(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_31(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_32(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_33(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleEvent_34(object P_0, EventArgs P_1)
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
	static view_thang_zz()
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
						goto _goto_30;
					case 1:
						AppClass_016.QB3DbWPnHbY();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_74fd3f679d7f4193893763ebe442ebc5 != 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						break;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_cf58fd231e5d4ef089c24814da16672b == 0)
						{
							num3 = 9;
						}
						continue;
					}
					goto _goto_31;
					continue;
					_goto_30:
					break;
				}
				continue;
				_goto_31:
				break;
			}
			while (num2 == 990);
			AppClass_054.IveTMUdyS5E();
			num = 9;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1bb5ff26f66e45b88c875a1813f40f77 == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_35()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static view_thang_zz GetViewThangZz_36()
	{
		return null;
	}
}
