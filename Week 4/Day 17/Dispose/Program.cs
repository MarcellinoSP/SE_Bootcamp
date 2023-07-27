using System.IO;
class Program
{
	static void Main()
	{
		using (Writing writingNew = new())
		{
			writingNew.StartWriting();
			writingNew.WriteAnother();
		}
	}
}

public class Writing : IDisposable
{
	StreamWriter streamWriter;
	public Writing()
	{
		streamWriter = new StreamWriter("output.md");
		Console.WriteLine("Output created");
	}
	
	public void StartWriting()
	{
		streamWriter.WriteLine("Hello!");
	}
	
	public void WriteAnother()
	{
		streamWriter.Write("Newbie here!");
	}
	
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (streamWriter != null)
			{
				streamWriter.Dispose();
				streamWriter = null;
			}
		}
	}
	
	//THIS CODE BELOW LEAD TO UNHANDLED EXCEPTION
	//DUE TO EARLY DISPOSED STREAM WRITER
	
	// public void StartWriting()
	// {
	// 	streamWriter.WriteLine("Hello!");
	// 	streamWriter.Dispose();
	// }
	
	// public void WriteAnother()
	// {
	// 	streamWriter.Write("Another Line");
	// }
}