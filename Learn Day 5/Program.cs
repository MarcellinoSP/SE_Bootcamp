class Program
{
	static void Main()
	{
		DataStorage<string> stringPrint = new DataStorage<string>("Testing Unit");
		string result = stringPrint.ShowData("Hello!");
		
		Parrent2 p = new(5);
		Parrent2 c = p;
		
		Parrent1 y = new(5);
		Parrent1 z = y;
		
		c.x = 2;
		Console.WriteLine(c.x); //Using Class
		Console.WriteLine(p.x); //Using Class
		
		z.a = 2;
		Console.WriteLine(z.a); //Using Struct
		Console.WriteLine(y.a); //Using Struct
	}
}
class Parrent2
{
	public int x;
	public Parrent2(int x)
	{
		this.x = x;
	}
}
struct Parrent1
{
	public int a;
	public Parrent1(int a)
	{
		this.a = a;
	}
}

public class DataStorage <T>
{
	public T Data;
	
	public DataStorage(T value)
	{
		Data = value;
	}
	
	public T ShowData(T parameter)
	{
		Console.WriteLine($"Data: {Data}");
		Console.WriteLine($"Parameter: {parameter}");
		
		return parameter;
	}
}