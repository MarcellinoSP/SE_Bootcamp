namespace Program;
using Bird;
class Program
{
	static void Main()
	{
		//Initializing Penguin
		Bird penguin = new Bird("Penguin");
		Penguin penguin1 = new Penguin();
		AbstractSpecies abstractSpecies1 = penguin1;
		//Get Penguin Data
		string penguinWeights = penguin.getWeight();
		string penguinColor = penguin.getColor();
		string penguinSpecies = penguin.getSpecies();
		string penguinFood = penguin.getFood();
		Console.WriteLine("Species: " + penguinSpecies);
		Console.WriteLine("Weights: " + penguinWeights);
		Console.WriteLine("Color: " + penguinColor);
		Console.WriteLine("Food: " + penguinFood);
		
		abstractSpecies1.fly();//override -> This species cannot fly
		
		penguin1.eat();
		penguin1.walk();
		penguin1.fly();
		
		Console.WriteLine("\n");
		
		//Initializing Parrot
		Bird parrot = new Bird("Parrot");
		Parrot parrot1 = new Parrot();
		AbstractSpecies abstractSpecies2 = parrot1;
		//Get Parrot Data
		string parrotWeights = parrot.getWeight();
		string parrotColor = parrot.getColor();
		string parrotSpecies = parrot.getSpecies();
		string parrotFood = parrot.getFood();
		Console.WriteLine("Species: " + parrotSpecies);
		Console.WriteLine("Weights: " + parrotWeights);
		Console.WriteLine("Color: " + parrotColor);
		Console.WriteLine("Food: " + parrotFood);
		
		abstractSpecies2.fly();//new -> Abstract Species - Can Fly
		
		parrot1.eat();
		parrot1.walk();
		parrot1.fly();
	}
}