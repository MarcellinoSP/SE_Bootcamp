namespace CarDealer;

public class IndentCar : EventArgs
{
	public string carName{get; set;}
	public string carType{get; set;}
	public int carPrice{get; set;}
	public string timeIndent{get; set;}
	
	public IndentCar(string carName, string carType, int carPrice, string timeIndent)
	{
		this.carName = carName;
		this.carType = carType;
		this.carPrice = carPrice;
		this.timeIndent = timeIndent;
	}
}

public class PurchaseCar : EventArgs
{
	public string carName{get; set;}
	public string carType{get; set;}
	public int carPrice{get; set;}
	public string timePurchased{get; set;}
	
	public PurchaseCar(string carName, string carType, int carPrice, string timePurchased)
	{
		this.carName = carName;
		this.carType = carType;
		this.carPrice = carPrice;
		this.timePurchased = timePurchased;
	}
}

public class Dealer
{
	public event EventHandler<PurchaseCar> CarPurchase;
	public event EventHandler<IndentCar> CarIndent;

	public void Purchase(string purchasedCarName, string purchasedCarType, int carPrice, string timeAction)
	{
		PurchaseCar purchaseCar = new(purchasedCarName, purchasedCarType, carPrice, timeAction);
		Console.WriteLine($"Purchase timestamp: {timeAction}");
		OnPurchase(purchaseCar);
	}
	public void Indent(string purchasedCarName, string purchasedCarType, int carPrice, string timeAction)
	{
		IndentCar indentCar = new(purchasedCarName, purchasedCarType, carPrice, timeAction);
		Console.WriteLine($"Indent timestamp: {timeAction}");
		OnIndent(indentCar);
	}
	protected void OnPurchase(PurchaseCar e)
	{
		CarPurchase?.Invoke(this, e);
	}
	protected void OnIndent(IndentCar e)
	{
		CarIndent?.Invoke(this, e);
	}
}

public class Customer
{
	public string customerName{get; set;}
	
	public Customer(string customerName)
	{
		this.customerName = customerName;
	}
	public void OnCarPurchase(object sender, PurchaseCar e)
	{
		Console.WriteLine($"Customer {customerName} purchasing car");
		Console.WriteLine($"Purchasing car: {e.carName}, with type: {e.carType}, price: {e.carPrice}");
	}
	public void OnCarIndent(object sender, IndentCar e)
	{
		Console.WriteLine($"Customer {customerName} requesting car indent");
		Console.WriteLine($"Indent car: {e.carName}, with type: {e.carType}, price: {e.carPrice}");
	}
}