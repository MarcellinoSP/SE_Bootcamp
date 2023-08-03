using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		string path = @".\Text.md";
		
		Task task1 = WriteToFile(path, "괜찮아요");
		Task task2 = WriteToFile1(path, "大丈夫です");
		
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Done Writing");
	}
	
	static async Task WriteToFile(string filePath, string content)
	{
		using (StreamWriter writer = new(filePath, true))
		{
			for(int i = 0; i < 2; i++)
			{
				writer.WriteLine(content);
			}
		}
		await Task.Delay(5000);
	}
	
	static async Task WriteToFile1(string filePath, string content)
	{
		using (StreamWriter writer1 = new(filePath, true))
		{
			for(int i = 0; i < 5; i++)
			{
				writer1.WriteLine(content);
			}
		}
		await Task.Delay(8000);
	}
}