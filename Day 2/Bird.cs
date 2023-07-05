namespace BirdSpecies;

public class Bird
{
	private string _species;
	private string _weight;
	private string _color;
	private string _food;
	private string _data;
	// private string _walk;
	// private string _fly;
	
	
	public Bird(string species, string weight, string color)
	{
		_species = species;
		_weight = weight;
		_color = color;
		Console.WriteLine(_species + ", " + _weight + ", " + _color);
	}
	
	public Bird(string species)
	{
		if (species == "Penguin")
		{
			_weight = "1100 grams";
			_color = "white";
			_food = "fish";
		}
		else
		{
			_weight = "300 grams";
			_color = "red";
			_food = "seed";
		}
	}
	
	public string GetWeight()
	{	
		return _weight;
	}
	
	public string GetColor()
	{
		return _color;
	}

	public string GetFood()
	{
		return _food;
	}

	// public string GetData()
	// {
	// 	_data = (_color, _weight, _food);
	// 	return _data;
	// }
}
