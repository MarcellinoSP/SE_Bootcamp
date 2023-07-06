namespace Smartphone;

public class Processor : IProcie
{
	public void runPhone()
	{
		Console.WriteLine("Run with generic processor");
	}
}

public class Snapdragon : IProcie
{
	public void runPhone()
	{
		Console.WriteLine("Run with snapdragon processor");
	}
}

public class Mediatek : IProcie
{
	public void runPhone()
	{
		Console.WriteLine("Run with mediatek processor");
	}
}

public class Bionic : IProcie
{
	public void runPhone()
	{
		Console.WriteLine("Run with Bionic Processor");
	}
}