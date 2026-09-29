using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns61;
using ns64;

[CompilerGenerated]
[DebuggerDisplay("Beam={Beam}, Index={Index}")]
internal sealed class GetStatic_2<T, U>
{
	private T tParam;

	private U uParam;

	private static object objectParam;

	public T Prop_0
	{
		get
		{
			return (T)null;
		}
		set
		{
		}
	}

	public U Prop_1
	{
		get
		{
			return (U)null;
		}
		set
		{
		}
	}

	public GetStatic_2(T tParam, U uParam)
	{
	}

	public override string ToString()
	{
		return null;
	}

	static GetStatic_2()
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
					default:
						if (num2 == 9)
						{
							AppClass_960.smethod_15();
							num3 = 6;
							if (AppClass_031.class730_0.int_102 != 0)
							{
								continue;
							}
						}
						else if (num2 == 990)
						{
							goto _goto_1;
						}
						goto case 0;
					case 0:
						AppClass_969.smethod_3();
						num = 2;
						break;
					case 1:
						AppClass_960.smethod_13();
						num = 7;
						if (AppClass_031.class730_0.int_22 != 0)
						{
							num = 9;
						}
						break;
					case 2:
						return;
					}
					goto _goto_2;
					continue;
					_goto_1:
					break;
				}
				continue;
				_goto_2:
				break;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static object objectParam()
	{
		return null;
	}
}
