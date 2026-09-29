using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using FvPr3dDkGF8J09q6AAZX;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

[StandardModule]
public sealed class Op_Gach_Module
{
	public class OpGachJig : DrawJig, IDisposable
	{
		public PolygonModule.Polygon wallTong;

		public diem choosingPoint;

		public double widthGach;

		public double heightGach;

		public List<PolygonModule.CurveXYZ> lCurveX;

		public List<PolygonModule.CurveXYZ> lCurveY;

		private static OpGachJig o9Rb1JTjV6oJuu9C21v3;

		public OpGachJig(PolygonModule.Polygon poly, double width, double height)
		{
		}

		protected override SamplerStatus Sampler(JigPrompts prompts)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		private void YBBDoEXhkgX(WorldDraw worldDraw_0, PolygonModule.CurveXYZ curveXYZ_0, string string_0 = "")
		{
		}

		private void AwBDosuHFCv(WorldDraw worldDraw_0, string string_0, diem diem_0)
		{
		}

		protected override bool WorldDraw(WorldDraw draw)
		{
			return true;
		}

		public void Dispose()
		{
		}

		static OpGachJig()
		{
			b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
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
						case 1:
							b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_3da03e4d215640aab6fa9268d1200d6d == 0)
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
								goto case 1;
							}
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
							num3 = 2;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_81f957ad91a245419918d0a1d8d7e3c4 == 0)
							{
								continue;
							}
							return;
						case 0:
							break;
						case 2:
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
				num = 2;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_919abade73404e77ba08bace63d9b14c == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool nY30hMTjkXtvEbYPA4q1()
		{
			return true;
		}

		internal static OpGachJig nPmcQfTj3ZRRpOtJM97R()
		{
			return null;
		}
	}

	public static Form_Op_Gach formOpGach;

	private static Op_Gach_Module huhlsVTw5AchcBIV0JWQ;

	static Op_Gach_Module()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					IL_0083:
					switch (num3)
					{
					case 3:
						formOpGach = new Form_Op_Gach();
						num3 = 1;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_c16368ee47214a3ea92e8fd02e53deed == 0)
						{
							continue;
						}
						goto default;
					default:
						while (true)
						{
							switch (num2)
							{
							case 11:
								goto IL_002d;
							default:
								return;
							case 992:
								break;
							}
							break;
							IL_002d:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							num3 = 0;
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_0295e339d21b49f5ae3dea1307c6082a == 0)
							{
								continue;
							}
							goto IL_0083;
						}
						goto end_IL_0083;
					case 2:
						iUemXbDkFh2Nnno2jJtT.f8oTg3pM5fk();
						num3 = 3;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_5f1c6be9493d4ea8acdc8e464233d885 != 0)
						{
							continue;
						}
						goto case 3;
					case 0:
						bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						num3 = 2;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_74fd3f679d7f4193893763ebe442ebc5 == 0)
						{
							continue;
						}
						goto default;
					case 4:
						break;
					case 1:
						return;
					}
					goto end_IL_00ab;
					continue;
					end_IL_0083:
					break;
				}
				continue;
				end_IL_00ab:
				break;
			}
			b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
			num = 7;
			if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2fd7730740d245ffb855794cabb17218 != 0)
			{
				num = 11;
			}
		}
	}

	public static void OpGach()
	{
	}

	internal static bool a7uyTITwcP53hR5RdY4J()
	{
		return true;
	}

	internal static Op_Gach_Module xrjmCwTwpGklsYTXkctD()
	{
		return null;
	}
}
