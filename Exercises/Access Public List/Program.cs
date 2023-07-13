using List;

class Program
{
	static void Main()
	{
		ListTraining listTraining = new();
		
		CarModel toyotaCar = new CarModel
		{
			brand = "Toyota",
			series = "Celica",
			color = "Red",
			price = 2000
		};
		CarModel hondaCar = new CarModel
		{
			brand = "Honda",
			series = "Civic",
			price = 2000
		};
		
		listTraining.AddList(toyotaCar);
		listTraining.AddList(hondaCar);
		
		string carBrand1 = listTraining.MyCar[0].brand;
        string carPrice2 = listTraining.MyCar[1].price.ToString();
		
		Console.WriteLine(carBrand1);
        Console.WriteLine(carPrice2);
	}
}