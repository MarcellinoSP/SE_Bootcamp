namespace CarDealer;

public class IndentCar : EventArgs
{
	public string carName{get; set;}
	public string carType{get; set;}
	public int carPrice{get; set;}
	
	public IndentCar(string carName, string carType, int carPrice)
	{
		this.carName = carName;
		this.carType = carType;
		this.carPrice = carPrice;
	}
}

public class PurchaseCar : EventArgs
{
	public string carName{get; set;}
	public string carType{get; set;}
	public int carPrice{get; set;}
	
	public PurchaseCar(string carName, string carType, int carPrice)
	{
		this.carName = carName;
		this.carType = carType;
		this.carPrice = carPrice;
	}
}

public class Dealer
{
	public event EventHandler<IndentCar> CarIndent;
	public event EventHandler<PurchaseCar> CarPurchase;
	
	public void Purchase(string purchasedCarName, string purchasedCarType, int carPrice)
	{
		PurchaseCar purchaseCar = new(purchasedCarName, purchasedCarType, carPrice);
		OnPurchase(indentCar);
	}
	
	public void Indent(string purchasedCarName, string purchasedCarType, int carPrice)
	{
		IndentCar indentCar = new(purchasedCarName, purchasedCarType, carPrice);
	}
	protected void OnPurchase(PurchaseCar e)
	{
		CarPurchase.Invoke(this, e);
	}
	protected void OnIndent(IndentCar e)
	{
		CarIndent.Invoke(this, e);
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
		Console.WriteLine($"Purchasing car: {e.CarName} with type: {e.carType}, price: {e.carPrice}");
	}
	public void OnCarIndent(object sender, IndentCar e)
	{
		Console.WriteLine($"Indent car: {e.CarName} with type: {e.carType}, price: {e.carPrice}");
	}
}