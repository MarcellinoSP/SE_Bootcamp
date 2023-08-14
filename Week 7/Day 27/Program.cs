internal class Program
{
	static void Main()
	{
		string[] names = {"Bari", "Kalvin", "Adam", "Charlie"};

		var order = from name in names 
				orderby name ascending 
				where name.Length>5 
				select name;

		foreach(var x in order) 
		{
			Console.WriteLine(x);
		}
		
		names = names.OrderBy(n => n).Where(n => n.Length>5).ToArray();
		
		foreach(var y in names)
		{
			Console.WriteLine(y);
		}
	}
}