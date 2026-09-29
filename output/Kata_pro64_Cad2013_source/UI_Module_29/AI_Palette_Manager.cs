using System.Drawing;
using System.Runtime.CompilerServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;
using Module_21;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class AI_Palette_Manager
{
	public static PaletteSet aiPaletteSet;

	public static Form_AI_Chat aiChatControl;

	private static readonly Size _size_2;

	private static readonly Size _size_3;

	private static AI_Palette_Manager _aiPaletteManager_4;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AI_Palette_Manager()
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto _goto_5;
							}
							goto case 7;
						}
						aiPaletteSet = null;
						num3 = 4;
						continue;
					case 2:
						AppClass_051.f8oTg3pM5fk();
						num = 14;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_e751303fb5f34e63bdc0efa39b75b1a1 == 0)
						{
							num = 11;
						}
						break;
					case 0:
						_size_3 = new Size(380, 720);
						num3 = 3;
						continue;
					case 3:
						return;
					case 4:
						aiChatControl = null;
						num = 5;
						break;
					case 6:
						AppClass_016.QB3DbWPnHbY();
						num3 = 1;
						continue;
					case 1:
						AppClass_054.IveTMUdyS5E();
						num3 = 2;
						continue;
					case 7:
						AppClass_016.TqZDb19vgxf();
						num3 = 6;
						continue;
					case 5:
						_size_2 = new Size(320, 420);
						num3 = 10;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_5c3d0b7b4c8b4e15b99cbd512c859b94 != 0)
						{
							num3 = 0;
						}
						continue;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CommandMethod("KATA_AI")]
	public static void ExecuteAction_1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_2()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AI_Palette_Manager GetAiPaletteManager_3()
	{
		return null;
	}
}
