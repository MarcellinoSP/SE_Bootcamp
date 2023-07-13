using OperatorOverloading;
using Enumerator;

class Program
{
	static void Main()
	{
		string mode = "hangout";
		//FRACTION OPERATION
		FractionOperator fraction1 = new(3, 4);
		FractionOperator fraction2 = new(2, 3);
		FractionOperator fraction3 = new(3, 5);
		FractionOperator multiple = fraction1 * fraction2 * fraction3;					//USING OPERATOR
		FractionOperator division = FractionOperator.Division(fraction1, fraction2);	//CREATE METHOD
		
		Console.WriteLine(multiple);
		Console.WriteLine(division);
		
		Console.WriteLine("");
		//DOT VECTOR OPERATION
		DotVector3x3 vector1 = new(1,2,3);
		DotVector3x3 vector2 = new(4,5,6);
		DotVector3x3 forwardPass = vector1 + vector2;
		
		Console.WriteLine(forwardPass.result);
		
		Console.WriteLine("");
		//FOREACH AND ENUMERATOR
		BagContains whatsInsideMyBag = new(mode);
		Console.WriteLine("What's inside my bag when I go " + mode + ": ");
		whatsInsideMyBag.GetBagContains();
	}
}