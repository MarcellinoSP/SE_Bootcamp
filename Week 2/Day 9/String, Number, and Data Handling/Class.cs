namespace CalculatorWannaBe;

public class NumberHandler
{
	private string _number;
	public NumberHandler(string number)
	{
		_number = number;
	}
	
	public int ConvertToBinary()
	{
		int binary = Convert.ToInt32(_number, 2);
		return binary;
	}
	
	public int ConvertToOctal()
	{
		int octal = Convert.ToInt32(_number, 8);
		return octal;
	}
	public int ConvertToHex()
	{
		int hex = Convert.ToInt32(_number, 16);
		return hex;
	}
	public bool TryParse()
	{
		bool stringResult = int.TryParse(_number, out int newNumber);
		return stringResult;
	}
}