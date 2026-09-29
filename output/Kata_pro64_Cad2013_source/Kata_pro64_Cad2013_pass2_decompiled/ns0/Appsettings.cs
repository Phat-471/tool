using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using ns61;
using ns62;
using ns64;

namespace ns0;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.14.0.0")]
internal sealed class AppSettings : ApplicationSettingsBase
{
	private static AppSettings _appsettings_1;

	internal static AppSettings _appsettings_2;

	public static AppSettings Class11_0 => null;

	static AppSettings()
	{
		AppClass_960.smethod_23();
		int num = 3;
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
					case 3:
						AppClass_960.smethod_13();
						num3 = 2;
						if (AppClass_031.class730_0.int_39 == 0)
						{
							continue;
						}
						break;
					case 0:
						AppClass_967.boolParam();
						num3 = 3;
						if (AppClass_031.class730_0.int_86 != 0)
						{
							continue;
						}
						goto _goto_4;
					case 2:
						AppClass_960.smethod_15();
						num3 = 1;
						if (AppClass_031.class730_0.int_54 != 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						AppClass_969.smethod_3();
						num3 = 0;
						if (AppClass_031.class730_0.int_119 != 0)
						{
							continue;
						}
						break;
					case 4:
						goto _goto_4;
						_goto_7:
						if (num2 == 11)
						{
							return;
						}
						goto _goto_5;
						_goto_5:
						if (num2 == 992)
						{
							goto _goto_6;
						}
						goto case 0;
					}
					goto _goto_7;
					continue;
					_goto_6:
					break;
				}
				continue;
				_goto_4:
				break;
			}
			_appsettings_1 = (AppSettings)AppDelegate_1761.boolParam(new AppSettings(), AppDelegate_1761.delegate29_0);
			num = 11;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static AppSettings appsettingsParam()
	{
		return null;
	}
}
