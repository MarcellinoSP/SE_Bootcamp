using CalculatorWannaBe;

partial class Program
{
	static void Main()
	{
		string numberInBinary = "101";
		NumberHandler binaryNumber = new(numberInBinary);
		int binary = binaryNumber.ConvertToBinary();
		Display(numberInBinary, binary);
		
		Console.WriteLine("===BREAK SECTION===");
		
		string numberInOctal = "767";
		NumberHandler octalNumber = new(numberInOctal);
		int octal = octalNumber.ConvertToOctal();
		Display(numberInOctal, octal);
		
		Console.WriteLine("===BREAK SECTION===");
		
		string numberInHex = "12E";
		NumberHandler hexNumber = new(numberInHex);
		int hexal = hexNumber.ConvertToHex();
		Display(numberInHex, hexal);
		
		Console.WriteLine("===BREAK SECTION===");
		
		string numberToParse = "12";
		NumberHandler tryParse = new(numberToParse);
		bool result = tryParse.TryParse();
		Console.WriteLine($"{numberToParse} is a {result}");
	}
}