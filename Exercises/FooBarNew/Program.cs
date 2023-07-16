using FooBar;

class Program
{
	static void Main()
	{
		int size = 35;
		FooBarMain fooBar = new();
		fooBar.AddCondition(3, "Foo");
		fooBar.AddCondition(5, "Bar");
		fooBar.AddCondition(9, "Meng");
		
		//fooBar.RemoveCondition(5);	//REMOVE FUNCTION
		
		string result = fooBar.GenerateResult(size);
		Console.WriteLine(result);
	}
}