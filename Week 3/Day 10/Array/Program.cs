class Program
{
	static void Main()
	{
		Number number1 = new(20);
		Number number2 = new(40);
		Number number3 = new(23);
		Number number4 = new(18);
		Number number5 = new(49);
		Number number6 = new(39);
		
		Number[] arrayNumber = {number1, number2, number3, number4, number5, number6};
		
		Array.Sort(arrayNumber, (x,y) => x.number.CompareTo(y.number));
		
		Console.Write("Array members: ");
		
		foreach(Number numberList in arrayNumber)
		{
			Console.Write($"{numberList.number} ");
		}
	}
}

class Number
{
	public int number{get; set;}
	public Number(int number)
	{
		this.number = number;
	}
}