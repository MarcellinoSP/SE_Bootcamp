class Program
{
	static void Main()
	{
		ListClass newList = new();
		newList.AddToList("Samsung");
		newList.AddToList("Iphone");
		newList.AddToList("Google Pixel");
		
		newList.smartphoneList.Sort();
		
		foreach(var list in newList.smartphoneList)
		{
			Console.WriteLine($"{list}");
		}
	}
}

public class ListClass
{
	public List<string> smartphoneList = new List<string>();
	
	public void AddToList(string name)
	{
		smartphoneList.Add(name);
	}
}