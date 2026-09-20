using System;
using System.Threading;

namespace Kata_pro64_Cad2013;

public interface IVmbmLightAnalysis
{
	void Prepare(VmbmLightSession session, Action<string> log, CancellationToken cancel);

	VmbmLightIteration Analyze(VmbmLightSession session, int iteration, Action<string> log, CancellationToken cancel);

	void FinalizeResult(VmbmLightSession session, string path, Action<string> log);

	void OpenResult(string path);
}
