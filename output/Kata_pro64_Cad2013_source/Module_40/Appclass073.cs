using System;
using System.Runtime.CompilerServices;
using Module_25;

namespace _namespace_1;

internal class GetStatic_4
{
	internal static ModuleHandle _modulehandle_2;

	private static object _object_3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle GetRuntimetypehandle_1(int token)
	{
		return _modulehandle_2.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle GetRuntimefieldhandle_2(int token)
	{
		return _modulehandle_2.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetStatic_4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetStatic_4()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto _goto_4;
				case 2:
					return;
				case 0:
					_modulehandle_2 = typeof(GetStatic_4).Assembly.GetModules()[0].ModuleHandle;
					num2 = 6;
					if (true)
					{
						num2 = 2;
					}
					continue;
				case 1:
					break;
				}
				goto _goto_6;
				_goto_4:
				if (num == 990)
				{
					break;
				}
				goto _goto_6;
				_goto_6:
				AppClass_054.IveTMUdyS5E();
				num2 = 1;
				if (true)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_5()
	{
		return _object_3 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GetStatic_4 GetAppclass073_6()
	{
		return (GetStatic_4)_object_3;
	}
}
