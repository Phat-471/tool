using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Kata_Class_Lib_Revit;
using Microsoft.VisualBasic.CompilerServices;
using ns61;
using ns64;

namespace ns4;

[StandardModule]
public sealed class GetStatic_5
{
	public class GetStatic_2 : DrawJig, IDisposable
	{
		private List<object> _listObject_14;

		public diem diemParam;

		public diem diemParam;

		internal static GetStatic_2 _appclass433_2;

		public GetStatic_2(diem diemParam)
		{
		}

		protected override SamplerStatus samplerstatusParam(JigPrompts jigPrompts_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		protected override bool boolParam(WorldDraw worldDraw_0)
		{
			return true;
		}

		public void Dispose()
		{
		}

		static GetStatic_2()
		{
			AppClass_960.smethod_23();
			int num = 2;
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
						default:
							if (num2 != 9)
							{
								goto _goto_3;
							}
							goto _goto_4;
						case 2:
							AppClass_960.smethod_13();
							break;
						case 1:
							break;
						case 0:
							return;
						}
						goto _goto_6;
						_goto_4:
						AppClass_969.smethod_3();
						num3 = 0;
						if (AppClass_031.class730_0.int_41 == 0)
						{
							goto _goto_6;
						}
						continue;
						_goto_3:
						break;
					}
					continue;
					_goto_6:
					break;
				}
				while (num2 == 990);
				AppClass_960.smethod_15();
				num = 4;
				if (AppClass_031.class730_0.int_47 == 0)
				{
					num = 9;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_2 appclass433Param()
		{
			return null;
		}
	}

	public class GetStatic_3 : DrawJig, IDisposable
	{
		public diem diemParam;

		public string _string_12;

		public string _string_8;

		private List<object> _listObject_14;

		internal static GetStatic_3 _appclass434_10;

		protected override SamplerStatus samplerstatusParam(JigPrompts jigPrompts_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		protected override bool boolParam(WorldDraw worldDraw_0)
		{
			return true;
		}

		public void Dispose()
		{
		}

		static GetStatic_3()
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
						case 2:
							AppClass_960.smethod_13();
							num3 = 1;
							if (AppClass_031.class730_0.int_67 != 0)
							{
								continue;
							}
							break;
						case 1:
							goto _goto_11;
						case 0:
							return;
						}
						switch (num2)
						{
						case 9:
							AppClass_969.smethod_3();
							num3 = 8;
							if (AppClass_031.class730_0.int_41 == 0)
							{
								continue;
							}
							return;
						default:
							return;
						case 990:
							break;
						}
						break;
					}
					continue;
					_goto_11:
					break;
				}
				AppClass_960.smethod_15();
				num = 9;
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_3 appclass433Param()
		{
			return null;
		}
	}

	public class GetStatic_4 : DrawJig, IDisposable
	{
		public diem diemParam;

		public string _string_12;

		public short _short_13;

		private List<object> _listObject_14;

		internal static GetStatic_4 _appclass435_15;

		protected override SamplerStatus samplerstatusParam(JigPrompts jigPrompts_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return (SamplerStatus)(object)null;
		}

		protected override bool boolParam(WorldDraw worldDraw_0)
		{
			return true;
		}

		public void Dispose()
		{
		}

		static GetStatic_4()
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
						case 2:
							AppClass_960.smethod_13();
							goto _goto_18;
						case 1:
							goto _goto_18;
						default:
							switch (num2)
							{
							default:
								goto _goto_18;
							case 990:
								break;
							case 9:
								return;
							}
							break;
						case 0:
							{
								AppClass_969.smethod_3();
								num = 2;
								if (AppClass_031.class730_0.int_36 == 0)
								{
									num = 9;
								}
								goto _goto_19;
							}
							_goto_18:
							AppClass_960.smethod_15();
							num3 = 3;
							if (AppClass_031.class730_0.int_14 == 0)
							{
								continue;
							}
							goto case 0;
						}
						break;
					}
					continue;
					_goto_19:
					break;
				}
			}
		}

		internal static bool boolParam()
		{
			return true;
		}

		internal static GetStatic_4 appclass433Param()
		{
			return null;
		}
	}

	internal static GetStatic_5 _appclass432_20;

	static GetStatic_5()
	{
		AppClass_960.smethod_23();
		int num = 2;
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
					case 2:
						AppClass_960.smethod_13();
						num3 = 9;
						if (AppClass_031.class730_0.int_75 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						AppClass_960.smethod_15();
						num3 = 0;
						if (AppClass_031.class730_0.int_53 != 0)
						{
							continue;
						}
						goto default;
					default:
						if (num2 == 9)
						{
							return;
						}
						goto _goto_21;
					case 0:
						break;
					}
					goto _goto_22;
					continue;
					_goto_21:
					break;
				}
				continue;
				_goto_22:
				break;
			}
			while (num2 == 990);
			AppClass_969.smethod_3();
			num = 9;
			if (AppClass_031.class730_0.int_31 != 0)
			{
				num = 9;
			}
		}
	}

	internal static bool boolParam()
	{
		return true;
	}

	internal static GetStatic_5 appclass433Param()
	{
		return null;
	}
}
