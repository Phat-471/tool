using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Kata_Class_Lib_Revit;
using Newtonsoft.Json.Linq;
using RpVxxCPmaUDhuZVeqwWU;
using wkkfIuPQq7T3mEZIPsR9;

namespace Kata_pro64_Cad2013;

public class AI_EditMBKC_ByVoice_Tool : IDisposable
{
	private sealed class gRC0RwPAAwQrMoF2op0D
	{
		public object VvoPAN0okRn;

		public Point3d r5EPAI50Ffd;

		public Point3d zFVPA8jSX2G;

		public bool vtIPAdyxjU4;

		public double kycPAZ3T51f;

		private static object vJkZm0kv57ByPmFWAciI;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public gRC0RwPAAwQrMoF2op0D()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static gRC0RwPAAwQrMoF2op0D()
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
						case 1:
							hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
							num3 = 1;
							if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_c6b50a099a5b4cedb7faef218cd85509 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						case 0:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
				num = 9;
				if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_8ffb6cd1fade4334829729a1ad7d121e == 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SXsUSukvu24QAoH8PhvD()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static gRC0RwPAAwQrMoF2op0D qpRclmkvjJnU1boV9Tfp()
		{
			return null;
		}
	}

	public const string ExplorerGroupName = "Hiệu chỉnh bằng giọng nói";

	public const string ExplorerContextName = "Chỉnh sửa trục, cột, vách, dầm";

	public const string ModelName = "gpt-5.6-luna";

	private Document n7i7hqqJnGL;

	private object en07hUXY4sF;

	private ObjectId tYx7hCUYdIB;

	private JArray Qjr7hMIav0O;

	private JArray MXs7hbPRYbM;

	private Dictionary<string, List<ObjectId>> uy07hmlp9la;

	private List<ObjectId> G5O7hFtfGKe;

	private long CrT7hQksV7s;

	private long v5Y7h0xpih5;

	private string v1d7hvdCFpf;

	private JArray AR47hrT8nww;

	private JObject yxp7hG0ngye;

	[CompilerGenerated]
	private string cFy7hlIRO1W;

	private static AI_EditMBKC_ByVoice_Tool uIeiJKkNctmJUHb0SZtv;

	public string LastUsageSummary
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

	public string UsageLogPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool HasSelection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public string SnapshotPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public JArray Entities
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AI_EditMBKC_ByVoice_Tool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnsureCurrent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RefreshSelectedSnapshot()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Scan()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JArray yh57hPtmacC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JObject gL27hDjmgB2(IEnumerable<PolygonModule.CurveXYZ> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JObject K0C7hgdlfFO(string P_0, string P_1, string P_2, MbkcReadSource P_3, Database P_4, Transaction P_5, Dictionary<string, List<ObjectId>> P_6)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DU87hkN2y3B(MbkcReadResult P_0, Database P_1, Transaction P_2, JArray P_3, JArray P_4, Dictionary<string, List<ObjectId>> P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void X8l7he4t7cX(object P_0, ObjectEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qU97hxILGWn(object P_0, ObjectErasedEventArgs P_1)
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
	public JObject Interpret(string userText, string apiKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VVw7hwpFHJ0(JObject P_0, JObject P_1, int P_2, long P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string DQ37hHu3twf()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string BuildChatPrompt(string userText, JObject intent, string requestId)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string NewOutputPath()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecordOutcome(string message, string route = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RevisePendingIntent(JObject intent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JObject SXF7ht2Kv6d()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vIP7hEdpENn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExportSnapshot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ObjectId QdK7hTakdnf(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (ObjectId)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Point3d dJZ7hBZT0gI(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JArray Nb57hSmgs7I(Point3d P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<AttributeReference> as97hc8reZp(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<gRC0RwPAAwQrMoF2op0D> q2I7h3GcF2N(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ypa7h5H5Lu5(IEnumerable<gRC0RwPAAwQrMoF2op0D> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void K3K7hufPNy9(IEnumerable<gRC0RwPAAwQrMoF2op0D> P_0, Matrix3d P_1, Vector3d P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double iDn7hjSZniw(object P_0, object P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void nOJ7h9kaLTo(object P_0, object P_1, double P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ooj7hKUumx9(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JObject PNo7hJjC234(Entity P_0, Transaction P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JArray lGP7hsTZa2W(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Point3d T2e7hOufsHV(object P_0, double P_1, double P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void qb47hAhIsN3(object P_0, Matrix3d P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ApplyPatch(JObject patch, bool useDirectAttributeTransforms = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PRX7hNQDuEh()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void syp7hIRy610(object P_0, Dictionary<string, JObject> P_1, HashSet<string> P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RDW7h89BRWE(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double K027hd7nP86(object P_0, object P_1, object P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void beq7hZa9IO8(JObject P_0, JObject P_1, List<ObjectId> P_2, Transaction P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Nw17hXC793g(object P_0, List<ObjectId> P_1, object P_2, object P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void b7s7h48SVpD(object P_0, object P_1, double P_2, double P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void J3h7hLyRi8P(object P_0, double P_1, double P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void JeN7hWYnkJF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<ObjectId> LJv7hfCVAZM(JObject P_0, Transaction P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<ObjectId> RKh7h1Z2s6U(JObject P_0, Transaction P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BlockReference Nt07hiCGJNX(string P_0, Point3d P_1, string P_2, BlockTableRecord P_3, Transaction P_4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AZQ7hVEWLUV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<PointF> rDl7ha2TZ6Q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AI_EditMBKC_ByVoice_Tool()
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
						return;
					case 0:
						break;
					case 1:
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 9;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_c3b0159d20d64e51827271e8840ab05d != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
						num3 = 5;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_7277bb6fa28d40f4a33052ea8a74613a == 0)
						{
							num3 = 1;
						}
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
			cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
			num = 1;
			if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_7e810419ea5841fe868bb0007399c6c7 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vbntSukN3OPbsCkqlXl8()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AI_EditMBKC_ByVoice_Tool wag9WOkN515GOL25t7TT()
	{
		return null;
	}
}
