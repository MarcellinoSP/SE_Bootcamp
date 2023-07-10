namespace Bird;

public class Bird
{
	private string _food;
	private string _color;
	private string _weights;
	private string _species;
	
	public Bird(string species)
	{
		if(species == "Penguin")
		{	
			_species = species;
			_weights = "1100 grams";
			_color = "white";
			_food = "fish";
			// Console.WriteLine("Species: " + _species + ", weights: " + _weights + ", color: " + _color + ", food: " + _food);
		} 
		else
		{
			_species = species;
			_weights = "300 grams";
			_color = "red";
			_food = "nut and seed";
			// Console.WriteLine("Species: " + _species + ", weights: " + _weights + ", color: " + _color + ", food: " + _food);
		}
	}
	public string getSpecies()
	{
		return _species;
	}
	public string getWeight()
	{
		return _weights;
	}
	public string getColor()
	{
		return _color;
	}
	public string getFood()
	{
		return _food;
	}
}
public interface IFly
{
	void fly();
}
public interface IWalk
{
	void walk();
}
public interface IEat
{
	void eat();
}
public abstract class AbstractSpecies
{
	public AbstractSpecies()
	{
		Console.WriteLine("Identifying species");
	}
	public virtual void fly()
	{
		Console.WriteLine("Can Fly");
	}
	public virtual void eat()
	{
		Console.WriteLine("Can Eat");
	}
	public virtual void walk()
	{
		Console.WriteLine("Can Walk");
	}
}
public class Penguin: AbstractSpecies, IWalk, IEat, IFly
{
	public void walk()
	{
		Console.WriteLine("This species can walk");
	}
	public void eat()
	{
		Console.WriteLine("This species can eat");
	}
	public override void fly()
	{
		Console.WriteLine("This species cannot fly");
	}
}
public class Parrot: AbstractSpecies, IWalk, IEat, IFly
{
	public void fly()
	{
		Console.WriteLine("This species can fly");
	}
	public void walk()
	{
		Console.WriteLine("This species can walk");
	}
	public void eat()
	{
		Console.WriteLine("This species can eat");
	}
}