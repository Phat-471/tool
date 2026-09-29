using System;
using System.Collections.Generic;
using Kata_Class_Lib_Revit;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

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

	public Info_Slab3D Outline;

	public bool ReadOnlyScan;

	internal static MbkcReadResult iXmPXLThdbtobw5q57wc;

	public void Track(string key, object entity, string ownerFile = "", string instancePath = "", string reason = "")
	{
	}

	public void Dispose()
	{
	}

	static MbkcReadResult()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
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
					case 2:
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						num3 = 1;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_fffa250e23d54447ae24cd613778be2e == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0051;
							}
							goto case 2;
						}
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 8;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3d856b94665044e6b2ba303819a86373 != 0)
						{
							continue;
						}
						return;
					case 1:
						break;
					case 0:
						return;
					}
					goto end_IL_0064;
					continue;
					end_IL_0051:
					break;
				}
				continue;
				end_IL_0064:
				break;
			}
			b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
			num = 9;
			if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_00b3130823b245fab24ede09ecc55ae9 != 0)
			{
				num = 5;
			}
		}
	}

	internal static bool rIB9y6ThgZG0lOQMamsO()
	{
		return true;
	}

	internal static MbkcReadResult RDD4O5ThMyL8wpcY25G5()
	{
		return null;
	}
}
