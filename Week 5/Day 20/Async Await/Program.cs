using System;
using System.Threading.Tasks;

public class Program
{
	public static async Task Main()
	{
		//CODE BELOW WILL BLOCK THE MAIN THREAD
		//  Task t1 = new Task(DoSomethingAsync);
		//  t1.Start();
		//  t1.Wait();
		//CODE ABOVE WILL BLOCK THE MAIN THREAD
		
		//CODE BELOW WILL NOT BLOCK THE MAIN THREAD
		// await DoSomethingAsync();
		//CODE ABOVE WILL NOT BLOCK THE MAIN THREAD
		
		await DoSomething();
		//TRIAL CODE
		Task task1 = SantaiDuluGaSih();
		await Task.WhenAny(task1, Task.Delay(10000));
	}

	public static async Task SantaiDuluGaSih()
	{
		while(true)
		{
			Console.WriteLine("Santai Dulu Ga Sih");
			await Task.Delay(700);
		}
	}
	
	public static async Task DoSomething()
	{
		Console.WriteLine("Do Something Asynchronous");
		await Task.Delay(200);
		Console.WriteLine("Finished");
	}
}
