// See https://aka.ms/new-console-template for more information
namespace MainProgram;
class Program
{
	static int myInt = 2; //dibuat static supaya tidak error.
	static string myString = "Hello myString!"; //dibuat static supaya tidak error.
	static void Main()
	{
		Console.WriteLine(myInt);
		Message();
	}
	static void Message()
	{
		Console.WriteLine(myString);
	}
}