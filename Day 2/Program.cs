using BirdSpecies;
using DisplayLib;
class Program
{
	static void Main()
	{
		Bird Parrot = new Bird("Parrot");
		Bird Penguin = new Bird("Penguin");
		
		string penguinWeight = Penguin.GetWeight();
		Display.PrintRest("Penguin Weight " + penguinWeight);
		
		string parrotWeight = Parrot.GetWeight();
		Display.PrintRest("Parrot Weight " + parrotWeight);
	}
}