using Newtonsoft.Json.Linq;
using iETHvbDkIhx0olnHfDOT;
using kqfxbuDbydgG49beRnPM;

namespace Kata_pro64_Cad2013;

public abstract class AIToolBase : IAIToolDefinition
{
	private static AIToolBase UeBynKGzpxWMryWodIO9;

	public abstract string Name { get; }

	public abstract string Description { get; }

	public virtual bool Strict => true;

	public virtual string[] ExplorerContexts => null;

	public virtual bool IsTruocAI => true;

	public abstract JObject CreateParametersSchema();

	public abstract AIToolExecutionResult Execute(JObject arguments);

	public JObject ToToolDefinition()
	{
		return null;
	}

	protected AIToolExecutionResult Success(string message, JObject data = null)
	{
		return null;
	}

	protected AIToolExecutionResult Fail(string message, JObject data = null)
	{
		return null;
	}

	public virtual string GetInstructions()
	{
		return null;
	}

	public virtual string GetUserPromptExamples()
	{
		return null;
	}

	public virtual JObject BuildInitialArguments(string userText)
	{
		return null;
	}

	static AIToolBase()
	{
		b8ZYB8DbaTOhwfvx6YUN.uQ4DbMFRj7Q();
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
						b8ZYB8DbaTOhwfvx6YUN.TqZDb19vgxf();
						num3 = 0;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_45f32ad850874067906bcaad9130e115 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						b8ZYB8DbaTOhwfvx6YUN.QB3DbWPnHbY();
						num3 = 2;
						if (_003CModule_003E_007Bb635f249_002D3a03_002D4cb4_002D9771_002Dbf68a6b4c6bf_007D.m_912cff3b240844bd9c28972bf0084a9b.m_4460f698163b4a3b8a9b2cec2f4cc3d6 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto end_IL_0065;
						IL_003a:
						if (num2 == 9)
						{
							return;
						}
						goto IL_0045;
						IL_0045:
						if (num2 == 990)
						{
							goto end_IL_0052;
						}
						goto case 0;
					}
					goto IL_003a;
					continue;
					end_IL_0052:
					break;
				}
				continue;
				end_IL_0065:
				break;
			}
			bq9slRDkylSLa9f5sYHe.IveTMUdyS5E();
			num = 9;
		}
	}

	internal static bool uPul4JGzjp2y7qmWpTyH()
	{
		return true;
	}

	internal static AIToolBase esdmSIGzY39BBwklYQ41()
	{
		return null;
	}
}
