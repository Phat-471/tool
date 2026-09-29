using System;
using ns64;

namespace ns63;

internal class GetStatic_1
{
	internal static ModuleHandle _modulehandle_1;

	private static object objectParam;

	internal static RuntimeTypeHandle runtimetypehandleParam(int intParam)
	{
		return _modulehandle_1.GetRuntimeTypeHandleFromMetadataToken(intParam);
	}

	internal static RuntimeFieldHandle runtimefieldhandleParam(int intParam)
	{
		return _modulehandle_1.GetRuntimeFieldHandleFromMetadataToken(intParam);
	}

	static GetStatic_1()
	{
		AppClass_969.appclass968Param();
		_modulehandle_1 = typeof(GetStatic_1).Assembly.GetModules()[0].ModuleHandle;
	}

	internal static bool boolParam()
	{
		return objectParam == null;
	}

	internal static GetStatic_1 appclass968Param()
	{
		return (GetStatic_1)objectParam;
	}
}
