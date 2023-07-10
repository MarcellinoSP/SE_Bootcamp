class Program
{
	static void Main()
	{
		int x;
		string myString = "50";
		
		Calculate result = new Calculate();
		result.CalculateResult(out x);
		result.ParseString(myString);
		Console.WriteLine(x);
	}
}

public class Calculate
{
	private bool stringRes;
	private int x;
	
	public void CalculateResult(out int a)
	{
		a = 5;
	}
	
	public void ParseString(string data)
	{
		stringRes = int.TryParse(data, out x);
		Console.WriteLine(stringRes);
	}
}