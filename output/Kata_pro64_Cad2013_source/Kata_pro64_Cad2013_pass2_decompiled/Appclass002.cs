using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns61;
using ns64;

[CompilerGenerated]
[DebuggerDisplay("dk={dk}, soHieu={soHieu}, tenCK={tenCK}")]
internal sealed class GetStatic_2<T, U, V> : IEquatable<GetStatic_2<T, U, V>>
{
	private readonly T tParam;

	private readonly U uParam;

	private readonly V vParam;

	internal static object objectParam;

	public T Prop_0 => (T)null;

	public U Prop_1 => (U)null;

	public V Prop_2 => (V)null;

	public GetStatic_2(T tParam, U uParam, V vParam)
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

	public bool Equals(GetStatic_2<T, U, V> class1_0)
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
					case 1:
						AppClass_969.smethod_3();
						num3 = _return_1;
						if (AppClass_031.class730_0.int_84 != _return_1)
						{
							continue;
						}
						goto default;
					default:
						do
						{
							switch (num2)
							{
							case 9:
								break;
							case 990:
								goto _goto_2;
							default:
								goto _goto_4;
							}
							AppClass_960.smethod_15();
							num3 = 1;
						}
						while (AppClass_031.class730_0.int_46 == _return_1);
						continue;
					case 2:
						goto _goto_4;
					case _return_1:
						return;
						_goto_2:
						break;
					}
					break;
				}
				continue;
				_goto_4:
				break;
			}
			AppClass_960.smethod_13();
			num = 9;
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
