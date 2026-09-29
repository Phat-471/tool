using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public class ToHopData
{
	public List<InfoThepCho> ListThepCho;

	public List<InfoThepCho> ListThepChoPhiNho;

	public List<InfoThepKho> ListThepKhoBefore;

	public List<InfoThepToHop> ListThepToHop;

	public List<InfoThepKho> ListThepKhoAfter;

	public List<AppClass_293> ListTongDu;

	public int _int_2;

	private static ToHopData _tohopdata_3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToHopData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ToHopData()
	{
		AppClass_016.uQ4DbMFRj7Q();
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_4;
							}
							goto case 2;
						}
						AppClass_054.IveTMUdyS5E();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4c55e99b69ce444aab2045602ec049f1 == 0)
						{
							num3 = 8;
						}
						continue;
					case 2:
						AppClass_016.TqZDb19vgxf();
						num3 = 1;
						continue;
					case 0:
						return;
					case 1:
						break;
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
			AppClass_016.QB3DbWPnHbY();
			num = 8;
			if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_7b47a3ce476644de941f3c07d3c7ccdb != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_1()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ToHopData GetTohopdata_2()
	{
		return null;
	}
}
