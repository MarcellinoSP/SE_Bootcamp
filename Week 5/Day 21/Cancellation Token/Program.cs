using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		CancellationTokenSource source = new CancellationTokenSource();
		CancellationToken token = source.Token;
		
		Task task = Task.Run(() => Constructing(token));
		Task task1 = Task.Run(() => Cancelling(source));
		
		await task;
		
		Console.WriteLine("Constructing finished");
	}
	
	static async Task Constructing(CancellationToken cancelToken)
	{
		//Versi 1, bakal kena delay ketika di cancel
		// for(int i = 0; i <= 100; i++)
		// {
		// 	if(cancelToken.IsCancellationRequested)
		// 	{
		// 		return;
		// 	}
		// 	Console.WriteLine($"Constructing unit: {i}%");
		// 	await Task.Delay(1000);
		// }
		
		//Versi 2, sekali pencet langsung return
		for(int i = 0; i <= 100; i++)
		{
			Console.WriteLine($"Constructing: {i}%");
			try
			{
				await Task.Delay(5000, cancelToken);
			}
			catch(Exception message)
			{
				return;
			}
		}
	}
	
	static async Task Cancelling(CancellationTokenSource sourceToken)
	{
		if(Console.ReadKey().KeyChar == ' ')
		{
			Console.WriteLine("token cancelled");
			sourceToken.Cancel();
		}
	}
}