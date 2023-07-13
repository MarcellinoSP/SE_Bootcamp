using FooBarProgram;

class Program 
{
	static void Main()
	{
		int a;
		int b;
		int n;
		string stringA = "Foo ";
		string stringB = "Bar ";

		Console.WriteLine("Insert maximum number: ");
		n = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"Insert 'Foo' Position (1-{n}): ");
		a = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"Insert 'Bar' Position (1-{n})");
		b = Convert.ToInt32(Console.ReadLine());
		
		FooBar generatingFooBar = new FooBar(stringA, stringB, a, b, n);
		generatingFooBar.getFooBar();
	}
}