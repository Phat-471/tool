using System.Runtime.CompilerServices;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class AIGeometryReader
{
	internal static AIGeometryReader _aigeometryreader_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static diem GetDiem_1(JToken token, string fieldName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PolygonModule.Polygon GetPolygon_2(JToken token, string fieldName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadOptionalString(JToken token, string defaultValue = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetDouble_3(JToken token, double defaultValue = 0.0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JToken GetJtoken_4(object P_0, params string[] names)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AIGeometryReader()
	{
		AppClass_016.uQ4DbMFRj7Q();
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
								goto _goto_3;
							}
							goto case 0;
						}
						AppClass_016.QB3DbWPnHbY();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e761100d2cf44e67808f34385eabece7 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						AppClass_054.IveTMUdyS5E();
						num3 = 1;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1ffce1ae5ca247c08901d03e85fad9fb == 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
						return;
					case 2:
						break;
					}
					goto _goto_4;
					continue;
					_goto_3:
					break;
				}
				continue;
				_goto_4:
				break;
			}
			AppClass_016.TqZDb19vgxf();
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_5()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AIGeometryReader GetAigeometryreader_6()
	{
		return null;
	}
}
