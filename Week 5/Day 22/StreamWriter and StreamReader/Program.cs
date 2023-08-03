

class Program
{
	static void Main()
	{
		string path = @"BootcampText.md";
		string path1 = @"BootcampText1.md";
		
		//THIS TO APPEND
		using (StreamWriter streamWriter1 = new(path1, true))
		{
			Console.WriteLine("FileCreated");
			streamWriter1.WriteLine("I don't know what to create");
		}
		
		//THIS TO CREATE AND WRITE
		using (StreamWriter streamWriter2 = new(File.Open(path, FileMode.OpenOrCreate)))
		{
			streamWriter2.WriteLine("諦めないでください");
			streamWriter2.WriteLine("화이팅");
			streamWriter2.WriteLine("Test subject");
			streamWriter2.WriteLine("Add new line");
		}
		
		//THIS TO PRINT EACH LINE
		using (StreamReader streamReader1 = new(File.Open(path, FileMode.Open)))
		{
			string line;
			do
			{
				line = streamReader1.ReadLine();
				Console.WriteLine(line);
			}while(line != null);
		}
	}
}