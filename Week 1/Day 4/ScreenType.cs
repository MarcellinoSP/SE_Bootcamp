namespace Smartphone;

public class Screen : IScreen
{
	public void showImage()
	{
		Console.WriteLine("Using generic screen");
	}
	public void turnOff()
	{
		Console.WriteLine("Turning off screen");
	}
}

public class Amoled : IScreen
{
	public void showImage()
	{
		Console.WriteLine("Amoled Screen on Display!");
	}
	public void turnOff()
	{
		Console.WriteLine("Turning off amoled screen");
	}
}

public class IPS : IScreen 
{
	public void showImage()
	{
		Console.WriteLine("Using IPS screen");
	}
	public void turnOff()
	{
		Console.WriteLine("Turning off IPS screen");
	}
}

public class RetinaScreen : IScreen
{
	public void showImage()
	{
		Console.WriteLine("Retina Screen On Display!");
	}
	public void turnOff()
	{
		Console.WriteLine("Retina Display sleep");
	}
}