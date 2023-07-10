using BirdSpecies;
using DisplayLib;

namespace Program;
class Program
{
	static void Main()
	{
		Bird Parrot = new Bird("Parrot");
		Bird Penguin = new Bird("Penguin");
		
		string penguinWeight = Penguin.GetWeight();
		string penguinColor = Penguin.GetColor();
		string penguinFood = Penguin.GetFood();
		Display.PrintRest("Penguin Weight " + penguinWeight);
		Display.PrintRest("Penguin Color " + penguinColor);
		Display.PrintRest("Penguin Food " + penguinFood);
		// Console.WriteLine(GetData.weight);
		
		Console.WriteLine("\n");

		string parrotWeight = Parrot.GetWeight();
		string parrotColor = Parrot.GetColor();
		string parrotFood = Parrot.GetFood();
		Display.PrintRest("Parrot Weight " + parrotWeight);
		Display.PrintRest("Parrot Color " + parrotColor);
		Display.PrintRest("Parrot Food " + parrotFood);
	}
}