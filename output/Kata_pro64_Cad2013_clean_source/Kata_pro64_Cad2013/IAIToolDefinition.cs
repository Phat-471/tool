using Newtonsoft.Json.Linq;

namespace Kata_pro64_Cad2013;

public interface IAIToolDefinition
{
	string Name { get; }

	string Description { get; }

	bool Strict { get; }

	string[] ExplorerContexts { get; }

	bool IsTruocAI { get; }

	JObject CreateParametersSchema();

	AIToolExecutionResult Execute(JObject arguments);

	JObject ToToolDefinition();

	string GetInstructions();

	string GetUserPromptExamples();

	JObject BuildInitialArguments(string userText);
}
