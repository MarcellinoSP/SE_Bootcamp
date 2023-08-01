using System.Diagnostics;
using System.IO;

class Program
{
	static void Main()
	{
		int x = 5;
		int y = 3;
		
		Debug.WriteLine($"X = {x}");
		Debug.WriteLine($"Y = {y}");
		
		Trace.WriteLine($"X = {x}");
		Trace.WriteLine($"Y = {y}");
		
		Trace.Listeners.Clear();
		ConsoleTraceListener consoleTrace = new();
		using(TextWriterTraceListener traceListeners = new("Trace Output.md"))
		{
			Trace.Listeners.Add(traceListeners);
			Trace.Listeners.Add(consoleTrace);
			
			Trace.Assert(false, "Number Invalid from Trace");
			Debug.Assert(false, "Number false from Debug");
			Trace.WriteLine("Trace WriteLine");
			
			traceListeners.Flush();
			traceListeners.Close();
		}
	}
}