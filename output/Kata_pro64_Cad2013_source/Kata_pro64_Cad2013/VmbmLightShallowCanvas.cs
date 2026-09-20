using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kata_Class_Lib_Revit;
using RpVxxCPmaUDhuZVeqwWU;
using wkkfIuPQq7T3mEZIPsR9;

namespace Kata_pro64_Cad2013;

public class VmbmLightShallowCanvas : Control
{
	public delegate void PickedEventHandler(string id, bool add);

	public delegate void DimensionEditedEventHandler(string id, string field, double value);

	[CompilerGenerated]
	private VmbmLightShallowSession nGs78hDXTea;

	[CompilerGenerated]
	private HashSet<string> DF3787ZaXk7;

	[CompilerGenerated]
	private PickedEventHandler KpS78PRgL4w;

	[CompilerGenerated]
	private DimensionEditedEventHandler y1d78Dtjw3o;

	private double VAc78gVNdvE;

	private PointF Kdl78kATj51;

	private diem Nq078eGBvsd;

	private Point W2i78xckSET;

	private bool bqL78ww5qK0;

	private readonly List<Tuple<RectangleF, string, string, double>> P5h78HYdlaR;

	private readonly ToolTip LIq78twf0sw;

	internal static VmbmLightShallowCanvas sxXIwGkZWuVl3vlReDPK;

	public VmbmLightShallowSession Session
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

	public HashSet<string> Selected
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

	public event PickedEventHandler Picked
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

	public event DimensionEditedEventHandler DimensionEdited
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
	public VmbmLightShallowCanvas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetView()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PointF m0n782SEUIf(diem P_0)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private diem NMR78YkR18W(Point P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tLh78nQW4o8(Graphics P_0, PolygonModule.Polygon P_1, Color P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fZt78RS6AiR(Graphics P_0, VmbmLightFootingInput P_1, diem P_2, double P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LIJ786wMVgc(Graphics P_0, VmbmLightFootingInput P_1, string P_2, double P_3, diem P_4, diem P_5, diem P_6)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UDk78pAGwas(Tuple<RectangleF, string, string, double> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseDoubleClick(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseDown(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseMove(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseUp(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseWheel(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VmbmLightShallowCanvas()
	{
		hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
								goto end_IL_0012;
							}
							goto case 2;
						}
						cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
						num3 = 0;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_b130b93daabc41daa87a6c05eb55ddea != 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
						break;
					case 0:
						return;
					case 2:
						hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
						num3 = 1;
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
			num = 9;
			if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8322ffda4bbe4861950a34a7fe3c60eb == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smd9hVkZfLT0bFKmB61i()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VmbmLightShallowCanvas FswgtAkZ1tC6Spl8IeyS()
	{
		return null;
	}
}
