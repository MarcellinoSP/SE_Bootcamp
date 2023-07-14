using CarDealer;

class Program
{
	static void Main()
	{
		Dealer dealer1 = new();
		Customer customer1 = new("Alvaro");
		dealer1.CarPurchase +=  customer1.OnCarPurchase;
		dealer1.Purchase("Honda", "Civic", 3000);
		
	}
}