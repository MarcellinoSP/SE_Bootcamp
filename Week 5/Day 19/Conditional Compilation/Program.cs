#define NOTHING
using List;
class Program
{
	static void Main()
	{
		ListTraining listTraining = new();
		#if TOYOTA
		CarModel toyotaCar = new CarModel
		{
			brand = "Toyota",
			series = "Celica",
			color = "Red",
			price = 2000
		};
		listTraining.AddList(toyotaCar);
		string carBrand1 = listTraining.MyCar[0].brand;
		Console.WriteLine(carBrand1);
		
		#elif HONDA
		CarModel hondaCar = new CarModel
		{
			brand = "Honda",
			series = "Civic",
			price = 2000
		};
		listTraining.AddList(hondaCar);
		string carPrice2 = listTraining.MyCar[0].brand;
		Console.WriteLine(carPrice2);
		#else
		Console.WriteLine("NO CAR IDENTIFIED");
		#endif
	}
}