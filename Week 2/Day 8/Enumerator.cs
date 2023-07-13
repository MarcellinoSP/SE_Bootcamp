namespace Enumerator;

enum WhatsInsideMyBag
{
	Tablet,
	Smartphone,
	Notebook,
	Pen,
	Pencil,
	TWS,
	BottleOfWater,
	Cigarettes,
	Zippo
}

public class BagContains
{
	WhatsInsideMyBag[] bagContainsOf = (WhatsInsideMyBag[])Enum.GetValues(typeof(WhatsInsideMyBag));
	private string _mode;
	public BagContains(string Mode)
	{
		_mode = Mode;
	}
	public void GetBagContains()
	{
		if(_mode == "bootcamp")
		{
			foreach(var x in bagContainsOf)
			{
				Console.WriteLine(x);
			}
		}else if(_mode == "hangout")
		{
			for(int i = 1; i < bagContainsOf.Length - 7; i++)
			{
				for(int j = 7; j < bagContainsOf.Length; j++)
				{
					Console.WriteLine(bagContainsOf[j]);
				}
				Console.WriteLine(bagContainsOf[i]);
			}
		}
	}
}