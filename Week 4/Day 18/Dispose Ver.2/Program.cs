using System.IO;

class Program
{
	static void Main()
	{
		WriteSomething startWrite = new();
		startWrite.Write();
		startWrite.WriteAnother();
	}
}

class WriteSomething
{
	public WriteSomething()
	{
		Console.WriteLine("Creating instances done");
	}
	public void Write()
	{
		using(StreamWriter sw = new("output.md"))
		{
			sw.WriteLine("Santai dulu ga sih");
		}
	}
	public void WriteAnother()
	{
		using(StreamWriter sw = new("output.md", append: true))
		{
			sw.WriteLine("Pake nanya");
		}
	}
}