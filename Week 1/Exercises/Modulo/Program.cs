using FooBarProgram;

class Program 
{
	static void Main()
	{
		int a = 3;
		int b = 5;
		int n = 15;
		string stringA = "Foo ";
		string stringB = "Bar ";
		
		FooBar generatingFooBar = new FooBar(stringA, stringB, a, b, n);
		generatingFooBar.getFooBar();
	}
}