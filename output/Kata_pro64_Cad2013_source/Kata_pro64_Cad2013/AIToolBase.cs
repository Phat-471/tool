using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using RpVxxCPmaUDhuZVeqwWU;
using wkkfIuPQq7T3mEZIPsR9;

namespace Kata_pro64_Cad2013;

public abstract class AIToolBase : IAIToolDefinition
{
	private static AIToolBase GSxpkQkIAQh1C6oJ3EyV;

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

	public abstract JObject CreateParametersSchema();

	JObject IAIToolDefinition.CreateParametersSchema()
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreateParametersSchema
		return this.CreateParametersSchema();
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
	public virtual string GetInstructions()
	{
		return null;
	}

	string IAIToolDefinition.GetInstructions()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetInstructions
		return this.GetInstructions();
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
	public virtual JObject BuildInitialArguments(string userText)
	{
		return null;
	}

	JObject IAIToolDefinition.BuildInitialArguments(string userText)
	{
		//ILSpy generated this explicit interface implementation from .override directive in BuildInitialArguments
		return this.BuildInitialArguments(userText);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AIToolBase()
	{
		hbMKCRPmVZCIcxwl8kPE.nEJPFkorkCm();
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
								goto end_IL_0012;
							}
							goto case 0;
						}
						hbMKCRPmVZCIcxwl8kPE.IScPFRVfZhd();
						num3 = 4;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_bb56d9c55163426e85e95509ce185987 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						cGXojZPQaQuTcBbFdU9g.BaaeK8qTrdS();
						num3 = 2;
						if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_b91d6a5c4d8e4bba8f08bacb4c1c2260 != 0)
						{
							num3 = 4;
						}
						continue;
					case 1:
						break;
					case 2:
						return;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			hbMKCRPmVZCIcxwl8kPE.GOTPmzRqIwj();
			num = 1;
			if (_003CModule_003E_007B7e54d077_002De7ae_002D4d2a_002Db252_002Df5215bccdd3d_007D.m_20e66232c1a34463a97657b12eccd573.m_ff72b6fc50da47abbf0209b40f908ee6 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ih60VLkINcA87kjjYiru()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AIToolBase FpJW1ekIIQyG1cQuXOui()
	{
		return null;
	}
}
