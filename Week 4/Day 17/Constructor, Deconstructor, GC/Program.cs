using System.Diagnostics;
public class Program
{
	static void Main()
	{
		Stopwatch myStopwatch = new();
		myStopwatch.Start();
		AnotherMain();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		myStopwatch.Stop();
		Console.WriteLine(myStopwatch.Elapsed);
	}
	static void AnotherMain()
	{
		CreateObject object1 = new("Gamepad");
		CreateObject object2 = new("Pake Nanya");
		object1 = null;
		GC.Collect();
		AnotherMainPart2();
	}
	static void AnotherMainPart2()
	{
		CreateObject object3 = new("Santai dulu ga sih");
	}
}

public class CreateObject
{
	public string myObject;
	public CreateObject(string myObject)
	{
		this.myObject = myObject;
		Console.WriteLine($"Constructing: {myObject}");
	}
	~CreateObject()
	{
		Console.WriteLine($"Deconstructing: {myObject}");
	}
}