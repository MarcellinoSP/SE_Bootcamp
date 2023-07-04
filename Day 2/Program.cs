using BirdSpecies;
using DisplayLib;
class Program
{
	static void Main()
	{
		Bird Parrot = new Bird("Parrot", "300 Grams", "Red");
		Bird Penguin = new Bird("Penguin", "1100 Grams", "White");
		
		string penguinWeight = Penguin.getWeight();
		Display.PrintRest("Penguin Weight " + penguinWeight);
		
		string parrotWeight = Parrot.getWeight();
		Display.PrintRest("Parrot Weight " + parrotWeight);
	}
}