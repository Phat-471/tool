using System.Runtime.CompilerServices;
using Module_21;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class GetStatic_1
{
	public static AppClass_160 _appclass160_2;

	public static AppClass_174 LastReviewSnapshot;

	public static AppClass_181 LastVisionRequest;

	public static AppClass_182 _appclass182_3;

	public static string LastCapturedImagePath;

	public static string _string_4;

	private static GetStatic_1 _appclass177_5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_1()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 7;
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto _goto_6;
							}
							goto case 9;
						}
						LastCapturedImagePath = "";
						num3 = 5;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_731c31f89ee84065b40adfdeb4e0e77c != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						continue;
					case 2:
						AppClass_051.f8oTg3pM5fk();
						num3 = 5;
						continue;
					case 6:
						AppClass_016.QB3DbWPnHbY();
						num3 = 3;
						continue;
					case 7:
						AppClass_016.TqZDb19vgxf();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_1bb5ff26f66e45b88c875a1813f40f77 != 0)
						{
							num3 = 6;
						}
						continue;
					case 9:
						LastReviewSnapshot = null;
						num3 = 8;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_ea2c693adaae4aa18af017c6a164943e != 0)
						{
							num3 = 1;
						}
						continue;
					case 8:
						return;
					case 5:
						_appclass160_2 = null;
						num3 = 9;
						continue;
					case 4:
						_appclass182_3 = null;
						num = 16;
						break;
					case 1:
						LastVisionRequest = null;
						num3 = 4;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_9b8a3fa59b0643a9a005e0e055caa087 == 0)
						{
							num3 = 14;
						}
						continue;
					case 0:
						_string_4 = "";
						num = 8;
						break;
					}
					goto _goto_7;
					continue;
					_goto_6:
					break;
				}
				continue;
				_goto_7:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_2()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_1 GetAppclass177_3()
	{
		return null;
	}
}
