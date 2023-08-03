using System;
using System.IO;
using System.Text;

class Program
{
	static void Main()
	{
		string filePath = @".\text.md";
		
		using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
		{
			Console.WriteLine("File Openned");
			stream.Close();
		}
		
		using (FileStream stream1 = new FileStream(filePath, FileMode.Append))
		{
			byte[] bytedata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");
			
			stream1.Write(bytedata, 0, bytedata.Length);
			stream1.Close();
		}
	}
}