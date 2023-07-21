class Program
{
	static void Main()
	{
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
		
		string word = c.PrintString();
	}
}
class Parrent2
{
	public int x;
	public double y = 0.1;
	public double z = 0.2;
	public string string1 = "Hello!";
	public Parrent2(int x)
	{
		this.x = x;
	}
	
	public string PrintString()
	{
		return string1;
	}
}
struct Parrent1
{
	public int a;
	public double b = 0.2;
	public double c = 0.3;
	
	public string string2 = "Hello!";
	public Parrent1(int a)
	{
		this.a = a;
	}
}
//Conclusion= struct using stack method, while class using address method.