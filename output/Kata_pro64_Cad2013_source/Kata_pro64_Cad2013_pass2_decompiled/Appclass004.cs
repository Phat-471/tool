using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns61;
using ns64;

[CompilerGenerated]
[DebuggerDisplay("Nonce={Nonce}")]
internal sealed class GetStatic_2<T>
{
	private T tParam;

	internal static object objectParam;

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

	public GetStatic_2(T tParam)
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
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						AppClass_960.smethod_13();
						num3 = 7;
						if (AppClass_031.class730_0.int_11 != 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						AppClass_960.smethod_15();
						num3 = 2;
						if (AppClass_031.class730_0.int_77 == 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_1;
					case 2:
						break;
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
			while (num2 == 990);
			AppClass_969.smethod_3();
			num = 9;
			if (AppClass_031.class730_0.int_40 == 0)
			{
				num = 0;
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
