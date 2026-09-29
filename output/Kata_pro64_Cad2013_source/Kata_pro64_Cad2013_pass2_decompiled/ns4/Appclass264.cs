using Newtonsoft.Json.Linq;
using ns61;
using ns64;

namespace ns4;

public abstract class GetStatic_1 : AppInterface_896
{
	private static GetStatic_1 _appclass264_1;

	public abstract string String_0 { get; }

	public abstract string String_1 { get; }

	public virtual bool Boolean_0 => true;

	public virtual string[] String_2 => null;

	public virtual bool Boolean_1 => true;

	public abstract JObject jobjectParam();

	public abstract AppClass_282 appclass282Param(JObject jobjectParam);

	public JObject jobjectParam()
	{
		return null;
	}

	protected AppClass_282 appclass282Param(string stringParam, JObject jobjectParam = null)
	{
		return null;
	}

	protected AppClass_282 appclass282Param(string stringParam, JObject jobjectParam = null)
	{
		return null;
	}

	public virtual string stringParam()
	{
		return null;
	}

	public virtual string stringParam()
	{
		return null;
	}

	public virtual JObject jobjectParam(string stringParam)
	{
		return null;
	}

	static GetStatic_1()
	{
		AppClass_960.smethod_23();
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
						AppClass_960.smethod_13();
						num3 = 0;
						if (AppClass_031.class730_0.int_107 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_58 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto _goto_2;
						_goto_5:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_3;
						_goto_3:
						if (num2 == 990)
						{
							goto _goto_4;
						}
						goto case 0;
					}
					goto _goto_5;
					continue;
					_goto_4:
					break;
				}
				continue;
				_goto_2:
				break;
			}
			AppClass_969.smethod_3();
			num = 9;
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_1 appclass264Param()
	{
		return null;
	}
}
