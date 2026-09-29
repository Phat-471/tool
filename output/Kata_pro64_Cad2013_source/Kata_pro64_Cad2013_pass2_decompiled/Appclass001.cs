using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns61;
using ns64;

[DebuggerDisplay("dk={dk}, Group={Group}")]
[CompilerGenerated]
internal sealed class GetStatic_2<T, U> : IEquatable<GetStatic_2<T, U>>
{
	private readonly T tParam;

	private readonly U uParam;

	private static object objectParam;

	public T Prop_0 => (T)null;

	public U Prop_1 => (U)null;

	public GetStatic_2(T tParam, U uParam)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return _return_1;
	}

	public bool Equals(GetStatic_2<T, U> class0_0)
	{
		return true;
	}

	public override bool Equals(object objectParam)
	{
		return true;
	}

	static GetStatic_2()
	{
		AppClass_960.smethod_23();
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
						if (num2 == 9)
						{
							AppClass_969.smethod_3();
							num3 = _return_1;
							if (AppClass_031.class730_0.int_14 != _return_1)
							{
								continue;
							}
						}
						else if (num2 == 990)
						{
							goto _goto_2;
						}
						goto case 2;
					case 2:
						AppClass_960.smethod_13();
						break;
					case 1:
						break;
					case _return_1:
						return;
					}
					goto _goto_3;
					continue;
					_goto_2:
					break;
				}
				continue;
				_goto_3:
				break;
			}
			AppClass_960.smethod_15();
			num = 7;
			if (AppClass_031.class730_0.int_18 == _return_1)
			{
				num = 9;
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
