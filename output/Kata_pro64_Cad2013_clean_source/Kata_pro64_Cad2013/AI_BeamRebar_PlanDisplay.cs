using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using FvPr3dDkGF8J09q6AAZX;
using Kata_Class_Lib_Revit;
using Newtonsoft.Json.Linq;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

public sealed class AI_BeamRebar_PlanDisplay : IDisposable
{
	private class qsRRXmDRHNRw9wD98fWv
	{
		public ObjectId lJrDRLaNvMB;

		public object SlaDR2J95lx;

		public int y4mDRqCpk4S;

		public int HfQDR4vNiA2;

		public bool l3dDRUZj5eA;

		public Dictionary<string, string> WSqDRtAPwx6;

		public object r2dDRz3Ef14;

		internal static object v4La95Ti5sGnFBynMsrd;

		static qsRRXmDRHNRw9wD98fWv()
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
							if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_652a8286e93743a0a01abcf6fabbb72b != 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0022;
								}
								goto case 0;
							}
							return;
						case 0:
							b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
							break;
						case 2:
							break;
						}
						goto end_IL_004e;
						continue;
						end_IL_0022:
						break;
					}
					continue;
					end_IL_004e:
					break;
				}
				bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
				num = 9;
				if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_2d4a32d5aa4341e59cdd7055ceb6be5d != 0)
				{
					num = 2;
				}
			}
		}

		internal static bool LyraAxTicZJjOYcoME1w()
		{
			return true;
		}

		internal static qsRRXmDRHNRw9wD98fWv D4Q3ZSTipyh014BOnyQy()
		{
			return null;
		}
	}

	private static readonly List<AI_BeamRebar_PlanDisplay> AjCCsoShh7y;

	private readonly Document WGDCs6BHY2E;

	private readonly ObjectId Ls9Csu8DH7o;

	private readonly HashSet<string> jABCsawwSWP;

	private readonly Func<JArray> I1MCsyk8qcv;

	private List<info_BlockBeam_AllData1nhip> PDQCsIaFax0;

	private bool LXvCsN02r9N;

	private readonly Action QtXCsinsonv;

	private Dictionary<ObjectId, qsRRXmDRHNRw9wD98fWv> KITCs9Tamws;

	private readonly HashSet<ObjectId> lkUCsbWB6i9;

	private bool GGTCsV5G5O5;

	private bool gNMCskienT1;

	private bool Vg7Cs3PvvKG;

	private string e79Cs5MVUNu;

	private bool qOBCscGRavM;

	internal static AI_BeamRebar_PlanDisplay VjhjEaGt08d9W8ZydeAi;

	static AI_BeamRebar_PlanDisplay()
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
					case 4:
						AjCCsoShh7y = new List<AI_BeamRebar_PlanDisplay>();
						num3 = 2;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_1a1ae42c9fb647b2ac3ccb55018de5e5 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0065;
							}
						}
						else
						{
							bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
						}
						goto case 3;
					case 3:
						iUemXbDkFh2Nnno2jJtT.f8oTg3pM5fk();
						goto case 4;
					case 1:
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						num3 = 4;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_04056ac6fec946ffbad8e686fad2a2af != 0)
						{
							continue;
						}
						break;
					case 0:
						break;
					case 2:
						return;
					}
					goto end_IL_0080;
					continue;
					end_IL_0065:
					break;
				}
				continue;
				end_IL_0080:
				break;
			}
			b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
			num = 11;
			if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_74f135d806434715a873b2494ff5b944 == 0)
			{
				num = 11;
			}
		}
	}

	public AI_BeamRebar_PlanDisplay(Document document, HashSet<string> beamHandles, Func<JArray> reader, List<info_BlockBeam_AllData1nhip> layout = null, Action ensureLayoutCurrent = null)
	{
	}

	public static List<info_BlockBeam_AllData1nhip> ReadLayout(Document document, HashSet<string> beamHandles, JArray spanMeasurements = null)
	{
		return null;
	}

	public void UpdateLayout(List<info_BlockBeam_AllData1nhip> layout)
	{
	}

	public void InvalidateLayout()
	{
	}

	private static string CmRCsneqS2F(List<info_BlockBeam_AllData1nhip> list_0)
	{
		return null;
	}

	public static bool OwnsAttribute(AttributeReference att)
	{
		return true;
	}

	public static bool OwnsShowHandle(Database database, string showHandle)
	{
		return true;
	}

	private void MpCCsRcyTmc()
	{
	}

	private Dictionary<string, string> grkCsOt7OjK(BlockReference blockReference_0, Transaction transaction_0)
	{
		return null;
	}

	private qsRRXmDRHNRw9wD98fWv VA6CshElWty(BlockReference blockReference_0, Transaction transaction_0)
	{
		return null;
	}

	private Dictionary<ObjectId, qsRRXmDRHNRw9wD98fWv> YWWCsZqkiMq(Transaction transaction_0)
	{
		return null;
	}

	private BlockReference A6tCsC3yrn7(string string_0, Transaction transaction_0)
	{
		return null;
	}

	private void ahECsBc4DP5(BlockReference blockReference_0, IDictionary<string, string> idictionary_0, Transaction transaction_0)
	{
	}

	private BlockReference gACCsDWhUfE(info_BlockBeam_AllData1nhip info_BlockBeam_AllData1nhip_0, int int_0, diem diem_0, Dictionary<string, string> dictionary_0, Transaction transaction_0)
	{
		return null;
	}

	public void Sync(Transaction tr, JArray snapshot, bool createMissing = false)
	{
	}

	public string AcceptCommitted()
	{
		return null;
	}

	public string ShowSelected()
	{
		return null;
	}

	public void RefreshVisuals(JArray snapshot)
	{
	}

	private void v9mCsFQxsPs(object sender, ObjectEventArgs e)
	{
	}

	private void LrXCsGOddpc(object sender, CommandEventArgs e)
	{
	}

	private void vP1CsTOr0fm(object sender, EventArgs e)
	{
	}

	public void FlushPending()
	{
	}

	public void Dispose()
	{
	}

	private void dtICsxynkkx(object sender, DocumentCollectionEventArgs e)
	{
	}

	internal static bool TccMBnGtmiNxEMWgAK5H()
	{
		return true;
	}

	internal static AI_BeamRebar_PlanDisplay wN8JIWGtKjOjG2QaSvrC()
	{
		return null;
	}
}
