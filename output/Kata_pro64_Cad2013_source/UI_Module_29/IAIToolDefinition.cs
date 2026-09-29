using Newtonsoft.Json.Linq;

namespace _namespace_1;

public interface IAIToolDefinition
{
	string Name { get; }

	string Description { get; }

	bool Strict { get; }

	string[] ExplorerContexts { get; }

	bool IsTruocAI { get; }

	JObject GetJobject_1();

	AIToolExecutionResult Execute(JObject arguments);

	JObject ToToolDefinition();

	string GetString_2();

	string GetUserPromptExamples();

	JObject GetJobject_3(string userText);
}
