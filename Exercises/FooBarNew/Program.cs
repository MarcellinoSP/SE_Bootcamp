using FooBar;
using System.Text;

class Program
{
	static void Main()
	{
		int size = 10000;
		StringBuilder result = new();
		StringBuilder conditionResult = new();
		FooBarMain fooBar = new();
		fooBar.AddCondition(3, "Foo");
		fooBar.AddCondition(5, "Bar");
		fooBar.AddCondition(9, "Meng");
		
		//fooBar.RemoveCondition(5);		//REMOVE FUNCTION
		// fooBar.AddCondition(5, "Fizz");	//TRIAL ADDING DUPLICATE CONDITION
		
		result.Append(fooBar.GenerateResult(size));
		Console.WriteLine(result.ToString());
		Console.WriteLine("");
		
		conditionResult.Append(fooBar.PrintConditionList());
		Console.WriteLine("Condition lists: ");
		Console.WriteLine(conditionResult.ToString());
	}
}