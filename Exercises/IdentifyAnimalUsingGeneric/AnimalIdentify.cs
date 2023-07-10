namespace AnimalIdentify;

public class Animal{
	public string? animalColor;
	public string? animalFood;
	public int animalWeights;
	private string _species;
	
	public Animal(string species){
		Console.WriteLine("Identifying Animal");
		_species = species;
	}
	
	public Animal(){

	}
	
	public void getData(){
		if(_species == "penguin"){
			IdentifyingAnimal<string, string, int> identifiedAnimal = new IdentifyingAnimal<string, string, int>();
			Animal animal = identifiedAnimal.identifyAnimal("white", "fish", 1100);
			Console.WriteLine("Identified Animal: Penguin");
			Console.WriteLine("Animal Color: " + animal.animalColor);
			Console.WriteLine("Animal Food: " + animal.animalFood);
			Console.WriteLine("Animal Weights: " + animal.animalWeights + " grams");
		}else if(_species == "parrot"){
			IdentifyingAnimal<string, string, int> identifiedAnimal = new IdentifyingAnimal<string, string, int>();
			Animal animal = identifiedAnimal.identifyAnimal("red", "seed and nut", 300);
			Console.WriteLine("Identified Animal: Parrot");
			Console.WriteLine("Animal Color: " + animal.animalColor);
			Console.WriteLine("Animal Food: " + animal.animalFood);
			Console.WriteLine("Animal Weights: " + animal.animalWeights + " grams");
		}else{
			Console.WriteLine("Input a valid animal name");
		}
	}
}
public class IdentifyingAnimal<TKey1, TKey2, TKey3>{
	public TKey1 animalColor;
	public TKey2 animalFood;
	public TKey3 animalWeights;
	
	public Animal identifyAnimal(string color, string food, int weights){
		Animal identify = new Animal();
		identify.animalColor = color.ToString();
		identify.animalFood = food.ToString();
		identify.animalWeights = Convert.ToInt32(weights);
		return identify;
	}
}