using System.Drawing;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns4;

[StandardModule]
public sealed class KataAiCommand
{
	public static PaletteSet _paletteset_1;

	public static AppForm_783 _appform783_2;

	private static readonly Size sizeParam;

	private static readonly Size sizeParam;

	private static KataAiCommand _kataaicommand_3;

	static KataAiCommand()
	{
		AppClass_960.smethod_23();
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
					case 5:
						sizeParam = new Size(320, 420);
						num3 = 10;
						if (AppClass_031.class730_0.int_29 == 0)
						{
							continue;
						}
						goto case 0;
					default:
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto _goto_4;
							}
							goto case 7;
						}
						_paletteset_1 = null;
						goto case 4;
					case 4:
						_appform783_2 = null;
						num = 5;
						break;
					case 7:
						AppClass_960.smethod_13();
						goto case 6;
					case 6:
						AppClass_960.smethod_15();
						goto case 1;
					case 1:
						AppClass_969.smethod_3();
						goto case 2;
					case 2:
						AppClass_967.voidParam();
						num = 14;
						if (AppClass_031.class730_0.int_45 == 0)
						{
							num = 11;
						}
						break;
					case 0:
						sizeParam = new Size(380, 720);
						return;
					case 3:
						return;
					}
					goto _goto_5;
					continue;
					_goto_4:
					break;
				}
				continue;
				_goto_5:
				break;
			}
		}
	}

	[CommandMethod("KATA_AI")]
	public static void voidParam()
	{
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static KataAiCommand kataaicommandParam()
	{
		return null;
	}
}
