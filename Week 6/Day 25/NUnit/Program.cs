namespace NUnitTest;
class Program
{
	static void Main()
	{
		NUnitResources unitTest = new();
		ItemToTest testItem1 = new ItemToTest
		{
			stringTest = "string1",
			intTest = 1
		};
		ItemToTest testItem2 = new ItemToTest
		{
			stringTest = "string2",
			intTest = 2
		};
		unitTest.AddToList(testItem1);
		unitTest.AddToList(testItem2);
		
		int result = unitTest.CheckByString("string1");
		Console.WriteLine(result);
	}
}

public class NUnitResources
{
	public List <ItemToTest> pieceID = new List <ItemToTest>();
	public void AddToList(ItemToTest item)
	{
		pieceID.Add(item);
	}
	
	public int CheckByString(string name)
	{
		foreach(var item in pieceID)
		{
			if(item.stringTest == name)
			{
				return item.intTest;
			}
		}
		return 0;
	}
}

public class ItemToTest
{
	public string stringTest {get; set;}
	public int intTest {get; set;}
}