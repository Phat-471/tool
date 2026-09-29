using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Kata_Class_Lib_Revit;
using Newtonsoft.Json.Linq;
using ns61;
using ns62;
using ns64;

namespace ns4;

public class GetStatic_15 : IDisposable
{
	private sealed class GetStatic_1
	{
		public object objectParam;

		public Point3d point3d_0;

		public Point3d point3d_1;

		public bool boolParam;

		public double doubleParam;

		internal static object objectParam;

		static GetStatic_1()
		{
			AppClass_960.listPointfParam();
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
						case 1:
							AppClass_969.objectidParam();
							num3 = 6;
							if (AppClass_031.class730_0.int_99 == 0)
							{
								continue;
							}
							return;
						default:
							if (num2 != 9)
							{
								goto _goto_42;
							}
							AppClass_960.voidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_25 != 0)
							{
								continue;
							}
							break;
						case 2:
							break;
						case 0:
							return;
						}
						goto _goto_25;
						continue;
						_goto_42:
						break;
					}
					continue;
					_goto_25:
					break;
				}
				while (num2 == 990);
				AppClass_960.jarrayParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_1 appclass698Param()
		{
			return null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class GetStatic_2
	{
		public static readonly GetStatic_2 _appclass699_3;

		public static Func<JObject, bool> boolParam;

		public static Func<AttributeReference, bool> boolParam;

		public static Func<JObject, string> stringParam;

		public static Func<KeyValuePair<string, List<ObjectId>>, string> stringParam;

		public static Func<KeyValuePair<string, List<ObjectId>>, List<ObjectId>> listObjectidParam;

		public static Func<JToken, double> doubleParam;

		public static Func<JObject, bool> boolParam;

		public static Func<JObject, string> stringParam;

		public static Func<JProperty, bool> boolParam;

		public static Func<AttributeReference, bool> boolParam;

		public static Func<Tuple<JObject, List<PointF>>, IEnumerable<PointF>> ienumerablePointfParam;

		public static Func<PointF, float> floatParam;

		public static Func<PointF, float> floatParam;

		public static Func<PointF, float> floatParam;

		public static Func<PointF, float> floatParam;

		public static Func<PointF, float> floatParam;

		public static Func<PointF, float> floatParam;

		private static GetStatic_2 _appclass699_4;

		static GetStatic_2()
		{
			AppClass_960.listPointfParam();
			int num = 4;
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
							AppClass_960.jarrayParam();
							num3 = 3;
							if (AppClass_031.class730_0.int_103 == 0)
							{
								continue;
							}
							goto case 3;
						case 3:
							AppClass_960.voidParam();
							num3 = 9;
							if (AppClass_031.class730_0.int_27 != 0)
							{
								continue;
							}
							goto case 1;
						case 2:
							_appclass699_3 = new GetStatic_2();
							num3 = 0;
							if (AppClass_031.class730_0.int_81 == 0)
							{
								continue;
							}
							goto default;
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto _goto_5;
								}
								goto case 1;
							}
							AppClass_967.boolParam();
							num = 2;
							break;
						case 1:
							AppClass_969.objectidParam();
							num = 11;
							if (AppClass_031.class730_0.int_82 == 0)
							{
								num = 1;
							}
							break;
						case 0:
							return;
						}
						goto _goto_6;
						continue;
						_goto_5:
						break;
					}
					continue;
					_goto_6:
					break;
				}
			}
		}

		[SpecialName]
		internal bool boolParam(JObject jobjectParam)
		{
			return true;
		}

		[SpecialName]
		internal bool boolParam(AttributeReference attributeReference_0)
		{
			return true;
		}

		[SpecialName]
		internal string stringParam(JObject jobjectParam)
		{
			return null;
		}

		[SpecialName]
		internal string stringParam(KeyValuePair<string, List<ObjectId>> keyValuePair_0)
		{
			return null;
		}

		[SpecialName]
		internal List<ObjectId> listObjectidParam(KeyValuePair<string, List<ObjectId>> keyValuePair_0)
		{
			return null;
		}

		[SpecialName]
		internal double doubleParam(JToken jtokenParam)
		{
			return 0.0;
		}

		[SpecialName]
		internal bool boolParam(JObject jobjectParam)
		{
			return true;
		}

		[SpecialName]
		internal string stringParam(JObject jobjectParam)
		{
			return null;
		}

		[SpecialName]
		internal bool boolParam(JProperty jpropertyParam)
		{
			return true;
		}

		[SpecialName]
		internal bool boolParam(AttributeReference attributeReference_0)
		{
			return true;
		}

		[SpecialName]
		internal IEnumerable<PointF> ienumerablePointfParam(Tuple<JObject, List<PointF>> listPointfParam)
		{
			return null;
		}

		[SpecialName]
		internal float floatParam(PointF pointF_0)
		{
			return _return_12;
		}

		[SpecialName]
		internal float floatParam(PointF pointF_0)
		{
			return _return_12;
		}

		[SpecialName]
		internal float floatParam(PointF pointF_0)
		{
			return _return_12;
		}

		[SpecialName]
		internal float floatParam(PointF pointF_0)
		{
			return _return_12;
		}

		[SpecialName]
		internal float floatParam(PointF pointF_0)
		{
			return _return_12;
		}

		[SpecialName]
		internal float floatParam(PointF pointF_0)
		{
			return _return_12;
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_2 appclass698Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_4
	{
		public Dictionary<string, JObject> jobjectParam;

		internal static GetStatic_4 _appclass700_13;

		public GetStatic_4(GetStatic_4 class277_1)
		{
		}

		[SpecialName]
		internal bool boolParam(string _string_34)
		{
			return true;
		}

		static GetStatic_4()
		{
			AppClass_960.listPointfParam();
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
							if (num2 != 9)
							{
								goto _goto_14;
							}
							goto _goto_15;
						case 2:
							AppClass_960.jarrayParam();
							break;
						case 1:
							break;
						case 0:
							return;
						}
						goto _goto_17;
						_goto_15:
						AppClass_969.objectidParam();
						num3 = 0;
						if (AppClass_031.class730_0.int_6 == 0)
						{
							goto _goto_17;
						}
						continue;
						_goto_14:
						break;
					}
					continue;
					_goto_17:
					break;
				}
				while (num2 == 990);
				AppClass_960.voidParam();
				num = 5;
				if (AppClass_031.class730_0.int_27 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_4 appclass698Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_6
	{
		public JObject jobjectParam;

		internal static GetStatic_6 _appclass701_18;

		public GetStatic_6(GetStatic_6 class278_1)
		{
		}

		[SpecialName]
		internal bool boolParam(string _string_34)
		{
			return true;
		}

		static GetStatic_6()
		{
			AppClass_960.listPointfParam();
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
							AppClass_960.jarrayParam();
							num3 = 0;
							if (AppClass_031.class730_0.int_41 != 0)
							{
								continue;
							}
							break;
						case 0:
							AppClass_960.voidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_60 != 0)
							{
								continue;
							}
							goto _goto_20;
						case 2:
							goto _goto_20;
							_goto_23:
							if (num2 == 9)
							{
								return;
							}
							goto _goto_21;
							_goto_21:
							if (num2 == 990)
							{
								goto _goto_22;
							}
							goto case 1;
						}
						goto _goto_23;
						continue;
						_goto_22:
						break;
					}
					continue;
					_goto_20:
					break;
				}
				AppClass_969.objectidParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_6 appclass698Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_8
	{
		public JObject jobjectParam;

		private static GetStatic_8 _appclass702_30;

		public GetStatic_8(GetStatic_8 class279_1)
		{
		}

		[SpecialName]
		internal bool boolParam(string _string_34)
		{
			return true;
		}

		static GetStatic_8()
		{
			AppClass_960.listPointfParam();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						_goto_26:
						switch (num3)
						{
						case 0:
							AppClass_969.objectidParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_65 == 0)
							{
								continue;
							}
							break;
						case 2:
							goto _goto_25;
						case 1:
							return;
							_goto_29:
							while (num2 == 9)
							{
								AppClass_960.voidParam();
								num3 = 0;
								if (AppClass_031.class730_0.int_27 != 0)
								{
									continue;
								}
								goto _goto_26;
							}
							goto _goto_27;
							_goto_27:
							if (num2 == 990)
							{
								goto _goto_40;
							}
							goto case 0;
						}
						goto _goto_29;
						continue;
						_goto_40:
						break;
					}
					continue;
					_goto_25:
					break;
				}
				AppClass_960.jarrayParam();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_8 appclass698Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_10
	{
		public JObject jobjectParam;

		public GetStatic_8 _appclass702_30;

		internal static GetStatic_10 _appclass703_31;

		public GetStatic_10(GetStatic_10 class280_1)
		{
		}

		[SpecialName]
		internal bool boolParam(string _string_34)
		{
			return true;
		}

		static GetStatic_10()
		{
			AppClass_960.listPointfParam();
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
							AppClass_960.jarrayParam();
							num3 = 1;
							if (AppClass_031.class730_0.int_52 == 0)
							{
								continue;
							}
							break;
						case 1:
							AppClass_960.voidParam();
							num3 = 9;
							if (AppClass_031.class730_0.int_38 == 0)
							{
								continue;
							}
							break;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_32;
								}
								goto case 2;
							}
							return;
						case 0:
							break;
						}
						goto _goto_33;
						continue;
						_goto_32:
						break;
					}
					continue;
					_goto_33:
					break;
				}
				AppClass_969.objectidParam();
				num = 0;
				if (AppClass_031.class730_0.int_104 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_10 appclass698Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_12
	{
		public string _string_34;

		private static GetStatic_12 _appclass704_35;

		public GetStatic_12(GetStatic_12 class281_1)
		{
		}

		[SpecialName]
		internal bool boolParam(JObject jobjectParam)
		{
			return true;
		}

		static GetStatic_12()
		{
			AppClass_960.listPointfParam();
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
							AppClass_960.jarrayParam();
							goto _goto_37;
						case 1:
							goto _goto_37;
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto _goto_38;
								}
								goto case 2;
							}
							return;
						case 0:
							break;
						}
						goto _goto_40;
						_goto_37:
						AppClass_960.voidParam();
						num3 = 9;
						if (AppClass_031.class730_0.int_9 != 0)
						{
							goto _goto_40;
						}
						continue;
						_goto_38:
						break;
					}
					continue;
					_goto_40:
					break;
				}
				AppClass_969.objectidParam();
				num = 9;
				if (AppClass_031.class730_0.int_46 != 0)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_12 appclass698Param()
		{
			return null;
		}
	}

	[CompilerGenerated]
	internal sealed class GetStatic_14
	{
		public float floatParam;

		public double doubleParam;

		public float floatParam;

		public Func<PointF, PointF> boolParam;

		internal static GetStatic_14 _appclass705_41;

		public GetStatic_14(GetStatic_14 class282_1)
		{
		}

		[SpecialName]
		internal PointF boolParam(PointF pointF_0)
		{
			return (PointF)(object)null;
		}

		static GetStatic_14()
		{
			AppClass_960.listPointfParam();
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					_goto_43:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							AppClass_960.jarrayParam();
							num3 = 7;
							if (AppClass_031.class730_0.int_77 != 0)
							{
								continue;
							}
							goto case 0;
						case 0:
							AppClass_960.voidParam();
							num = 5;
							if (AppClass_031.class730_0.int_49 == 0)
							{
								num = 9;
							}
							goto _goto_42;
						case 2:
							return;
						}
						switch (num2)
						{
						case 9:
							AppClass_969.objectidParam();
							num3 = 2;
							if (AppClass_031.class730_0.int_81 == 0)
							{
								continue;
							}
							return;
						default:
							return;
						case 990:
							break;
						}
						goto _goto_43;
						continue;
						_goto_42:
						break;
					}
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_14 appclass698Param()
		{
			return null;
		}
	}

	public const string _string_34 = "Hiệu chỉnh bằng giọng nói";

	public const string stringParam = "Chỉnh sửa trục, cột, vách, dầm";

	public const string stringParam = "gpt-5.6-luna";

	private Document documentParam;

	private object objectParam;

	private ObjectId _objectid_44;

	private JArray jarrayParam;

	private JArray jarrayParam;

	private Dictionary<string, List<ObjectId>> jobjectParam;

	private List<ObjectId> _listObjectid_45;

	private long _long_46;

	private long _long_47;

	private string _string_48;

	private JArray jarrayParam;

	private JObject jobjectParam;

	[CompilerGenerated]
	private string _string_49;

	internal static GetStatic_15 _appclass697_50;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public string String_1 => null;

	public bool Boolean_0 => true;

	public string String_2 => null;

	public string String_3 => null;

	public JArray JArray_0 => null;

	public void boolParam()
	{
	}

	public string boolParam()
	{
		return null;
	}

	public string stringParam()
	{
		return null;
	}

	private static JArray boolParam(object objectParam)
	{
		return null;
	}

	private static JObject appclass698Param(IEnumerable<CurveXYZ> ienumerableCurvexyzParam)
	{
		return null;
	}

	private JObject stringParam(string stringParam, string stringParam, string stringParam, AppClass_436 gclass207_0, Database databaseParam, Transaction transactionParam, Dictionary<string, List<ObjectId>> listObjectidParam)
	{
		return null;
	}

	private void listObjectidParam(AppClass_437 gclass208_0, Database databaseParam, Transaction transactionParam, JArray jarrayParam, JArray jarrayParam, Dictionary<string, List<ObjectId>> listObjectidParam)
	{
	}

	private void doubleParam(object sender, ObjectEventArgs e)
	{
	}

	private void boolParam(object sender, ObjectErasedEventArgs e)
	{
	}

	public void Dispose()
	{
	}

	public JObject stringParam(string stringParam, string stringParam)
	{
		return null;
	}

	private void boolParam(JObject jobjectParam, JObject jobjectParam, int intParam, long longParam)
	{
	}

	private static string stringParam()
	{
		return null;
	}

	public string boolParam(string stringParam, JObject jobjectParam, string stringParam)
	{
		return null;
	}

	public string ienumerablePointfParam()
	{
		return null;
	}

	public void floatParam(string stringParam, string stringParam = "")
	{
	}

	public void floatParam(JObject jobjectParam)
	{
	}

	private JObject floatParam()
	{
		return null;
	}

	private void floatParam()
	{
	}

	public void floatParam()
	{
	}

	private static ObjectId objectidParam(object objectParam, object objectParam)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (ObjectId)(object)null;
	}

	private static Point3d point3dParam(object objectParam)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	private static JArray jarrayParam(Point3d point3d_0)
	{
		return null;
	}

	private static List<AttributeReference> listAttributereferenceParam(object objectParam, object objectParam)
	{
		return null;
	}

	private static List<GetStatic_1> listAppclass698Param(object objectParam, object objectParam)
	{
		return null;
	}

	private static void voidParam(IEnumerable<GetStatic_1> ienumerableCurvexyzParam)
	{
	}

	private static void voidParam(IEnumerable<GetStatic_1> ienumerableCurvexyzParam, Matrix3d matrix3d_0, Vector3d vector3d_0)
	{
	}

	private static double doubleParam(object objectParam, object objectParam)
	{
		return 0.0;
	}

	private static void voidParam(object objectParam, object objectParam, double doubleParam)
	{
	}

	private static string stringParam(object objectParam, object objectParam)
	{
		return null;
	}

	private JObject floatParam(Entity entityParam, Transaction transactionParam)
	{
		return null;
	}

	private static JArray jarrayParam(object objectParam)
	{
		return null;
	}

	private static Point3d point3dParam(object objectParam, double doubleParam, double doubleParam)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (Point3d)(object)null;
	}

	private static void voidParam(object objectParam, Matrix3d matrix3d_0, object objectParam)
	{
	}

	public string stringParam(JObject jobjectParam, bool boolParam = false)
	{
		return null;
	}

	private void voidParam()
	{
	}

	private static void voidParam(object objectParam, Dictionary<string, JObject> listObjectidParam, HashSet<string> hashSet_0)
	{
	}

	private static void voidParam(object objectParam, object objectParam, bool boolParam)
	{
	}

	private static double doubleParam(object objectParam, object objectParam, object objectParam)
	{
		return 0.0;
	}

	private void voidParam(JObject jobjectParam, JObject jobjectParam, List<ObjectId> listObjectidParam, Transaction transactionParam)
	{
	}

	private static void voidParam(object objectParam, List<ObjectId> listObjectidParam, object objectParam, object objectParam)
	{
	}

	private static void voidParam(object objectParam, object objectParam, double doubleParam, double doubleParam)
	{
	}

	private static void voidParam(object objectParam, double doubleParam, double doubleParam)
	{
	}

	private static void voidParam(object objectParam, object objectParam)
	{
	}

	private List<ObjectId> listObjectidParam(JObject jobjectParam, Transaction transactionParam)
	{
		return null;
	}

	private List<ObjectId> listObjectidParam(JObject jobjectParam, Transaction transactionParam)
	{
		return null;
	}

	private BlockReference blockreferenceParam(string stringParam, Point3d point3d_0, string stringParam, BlockTableRecord blockTableRecord_0, Transaction transactionParam)
	{
		return null;
	}

	private void voidParam()
	{
	}

	private static List<PointF> listPointfParam(object objectParam)
	{
		return null;
	}

	static GetStatic_15()
	{
		AppClass_960.listPointfParam();
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
					case 2:
						AppClass_969.objectidParam();
						num3 = 4;
						if (AppClass_031.class730_0.int_86 != 0)
						{
							continue;
						}
						return;
					default:
						if (num2 != 9)
						{
							goto _goto_51;
						}
						AppClass_960.voidParam();
						num3 = 2;
						if (AppClass_031.class730_0.int_21 == 0)
						{
							continue;
						}
						goto case 2;
					case 1:
						break;
					case 0:
						return;
					}
					goto _goto_52;
					continue;
					_goto_51:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				_goto_52:
				break;
			}
			AppClass_960.jarrayParam();
			num = 9;
			if (AppClass_031.class730_0.int_66 != 0)
			{
				num = 6;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_15 appclass697Param()
	{
		return null;
	}
}
