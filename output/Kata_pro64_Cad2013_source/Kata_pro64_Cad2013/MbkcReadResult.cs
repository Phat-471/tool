using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using RpVxxCPmaUDhuZVeqwWU;
using wkkfIuPQq7T3mEZIPsR9;

namespace Kata_pro64_Cad2013;

public class MbkcReadResult : IDisposable
{
	public Dictionary<string, Info_ColumnWall3D> Columns;

	public Dictionary<string, Info_Beam3D> Beams;

	public Dictionary<string, Info_Slab3D> Slabs;

	public Dictionary<string, Info_Slab3D> Anchors;

	public Dictionary<string, info_CurveGrid> Grids;

	public SortedDictionary<string, info_SecondBeam> SecondBeams;

	public Dictionary<string, MbkcReadSource> Sources;

	public Dictionary<string, MbkcReadSource> GridMarkers;

	public Dictionary<string, List<string>> GridMembers;

	public List<string> Warnings;

	public Dictionary<string, object> Documents;

	public bool ReadOnlyScan;

	internal static MbkcReadResult Hvror8kfaUIH1X0pL8I2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MbkcReadResult()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Track(string key, object entity, string ownerFile = "", string instancePath = "", string reason = "")
	{
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
	static MbkcReadResult()
	{
		hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
								goto end_IL_0012;
							}
							goto case 2;
						}
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 2;
						continue;
					case 1:
						break;
					case 2:
						cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
						num3 = 0;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_c426beead99744cc8db89098e366f652 != 0)
						{
							num3 = 8;
						}
						continue;
					case 0:
						return;
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
			hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
			num = 7;
			if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_f5d127517bf54571b63892f43c26cef6 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Wv9BT2kfqqatvtU1eJIF()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MbkcReadResult UtTJpikfUKn22HeDuagH()
	{
		return null;
	}
}
