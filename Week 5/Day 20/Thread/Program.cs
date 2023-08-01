class Program
{
	static void Main()
	{
		Thread thread1 = new(AddNumber);
		thread1.Start();
		Console.WriteLine("Main Finished");
	}
	
	static void AddNumber()
	{
		for(int i = 0; i < 100; i++)
		{
			Console.WriteLine($"Thread {i} Running");
			Thread.Sleep(100);
		}
	}
}