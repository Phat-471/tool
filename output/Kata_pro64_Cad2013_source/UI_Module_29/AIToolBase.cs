using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Module_25;
using Licensing_32;

namespace _namespace_1;

public abstract class AIToolBase : IAIToolDefinition
{
	private static AIToolBase _aitoolbase_2;

	public abstract string Name { get; }

	public abstract string Description { get; }

	public virtual bool Strict
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public virtual string[] ExplorerContexts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public virtual bool IsTruocAI
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AIToolBase()
	{
	}

	public abstract JObject GetAbstractJobject_1();

	JObject IAIToolDefinition.GetAbstractJobject_1()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetAbstractJobject_1
		return this.GetAbstractJobject_1();
	}

	public abstract AIToolExecutionResult Execute(JObject arguments);

	AIToolExecutionResult IAIToolDefinition.Execute(JObject arguments)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Execute
		return this.Execute(arguments);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JObject ToToolDefinition()
	{
		return null;
	}

	JObject IAIToolDefinition.ToToolDefinition()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ToToolDefinition
		return this.ToToolDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AIToolExecutionResult Success(string message, JObject data = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AIToolExecutionResult Fail(string message, JObject data = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetString_2()
	{
		return null;
	}

	string IAIToolDefinition.GetString_2()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetString_2
		return this.GetString_2();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetUserPromptExamples()
	{
		return null;
	}

	string IAIToolDefinition.GetUserPromptExamples()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUserPromptExamples
		return this.GetUserPromptExamples();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual JObject GetJobject_3(string userText)
	{
		return null;
	}

	JObject IAIToolDefinition.GetJobject_3(string userText)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetJobject_3
		return this.GetJobject_3(userText);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AIToolBase()
	{
		AppClass_016.uQ4DbMFRj7Q();
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto _goto_3;
							}
							goto case 0;
						}
						return;
					case 2:
						break;
					case 0:
						AppClass_016.QB3DbWPnHbY();
						num3 = 2;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_4460f698163b4a3b8a9b2cec2f4cc3d6 != 0)
						{
							num3 = 6;
						}
						continue;
					case 1:
						AppClass_016.TqZDb19vgxf();
						num3 = 0;
						if (AppClass_002.m_912cff3b240844bd9c28972bf0084a9b.m_45f32ad850874067906bcaad9130e115 != 0)
						{
							num3 = 0;
						}
						continue;
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
			AppClass_054.IveTMUdyS5E();
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsValid_4()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AIToolBase GetAitoolbase_5()
	{
		return null;
	}
}
