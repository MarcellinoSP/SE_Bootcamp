namespace List;

public class ListTraining
{
	public List<CarModel> MyCar{get; set;}
	
	public ListTraining()			//Constructors
	{
		MyCar = new List<CarModel>();
	}
	
	public void AddList(CarModel item)
	{
		MyCar.Add(item);
	}
}

public class CarModel
{
	public string? brand {get; set;}
	public string? series {get; set;}
	public string? color {get; set;}
	public int price {get; set;}
}