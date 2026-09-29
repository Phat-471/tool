using System.Runtime.CompilerServices;
using Module_21;
using Microsoft.VisualBasic.CompilerServices;
using Module_25;
using Licensing_32;

namespace _namespace_1;

[StandardModule]
public sealed class AI_Pricing
{
	public const decimal UsdToVndRate = 26335.62m;

	public const string ExchangeRateSourceLabel = "Ước tính theo 1 USD = 26,335.62 VND";

	private static AI_Pricing _aiPricing_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString_1(string model, int inputTokens, int outputTokens, int totalTokens, int reasoningTokens = 0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BuildEstimatedCostLine(string model, int inputTokens, int outputTokens)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsValid_2(object P_0, ref decimal P_1, ref decimal P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AI_Pricing()
	{
		AppClass_016.uQ4DbMFRj7Q();
		int num = 4;
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto _goto_3;
							}
							goto case 3;
						}
						AppClass_054.IveTMUdyS5E();
						num = 1;
						break;
					case 2:
						UsdToVndRate = 26335.62m;
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_25efeca4a94a44938c6f287ee921250e != 0)
						{
							num3 = 6;
						}
						continue;
					case 1:
						AppClass_051.f8oTg3pM5fk();
						num = 2;
						break;
					case 4:
						AppClass_016.TqZDb19vgxf();
						num3 = 3;
						continue;
					case 3:
						AppClass_016.QB3DbWPnHbY();
						num = 3;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_42524d84b15f453da26a7f97a96dac37 == 0)
						{
							num = 11;
						}
						break;
					case 0:
						return;
					}
					goto _goto_4;
					continue;
					_goto_3:
					break;
				}
				continue;
				_goto_4:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AI_Pricing GetAiPricing_4()
	{
		return null;
	}
}
