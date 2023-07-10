namespace IdentifyBookIndex;

public enum BookTypes
{
	Fiction = 1,
	NonFiction,
	ShortStories,
	Mystery,
	History
}

public class BookIdentify
{
	// public var maxIndex = Enum.GetValues(typeof(BookTypes)).Cast<BookTypes>().Max(); //How to find maximum index value in enum?
	public BookIdentify()
	{
		Console.WriteLine("Finding Books by Index...");
	}
	public void GetBook(in int indexOfBook)
	{
		if(indexOfBook > 0 && indexOfBook < 6)
		{
			switch(indexOfBook)
			{
				case 1:
					Console.WriteLine("Identified: " + BookTypes.Fiction);
					break;
				case 2:
					Console.WriteLine("Identified: " + BookTypes.NonFiction);
					break;
				case 3:
					Console.WriteLine("Identified: " + BookTypes.ShortStories);
					break;
				case 4:
					Console.WriteLine("Identified: " + BookTypes.Mystery);
					break;
				case 5:
					Console.WriteLine("Identified: " + BookTypes.History);
					break;
			}
		}else
		{
			Console.WriteLine("Insert Valid Book Index");	
		}
	}
}

public class BookDescription
{
	public BookDescription()
	{
		Console.WriteLine("Description: ");
	}
	
	public void DescriptionBook(in int index)
	{
		if(index > 0 && index < 6)
		{
			switch(index)
			{
				case 1: 
					Console.WriteLine("Fiction books contains creative make-up or imaginary stories");
					break;
				case 2:
					Console.WriteLine("Non-Ficition books contains information only in real world rather than imagination");
					break;
				case 3:
					Console.WriteLine("Short stories books contains a short fiction stories");
					break;
				case 4:
					Console.WriteLine("Mystery books contains story about crime or disapearance case");
					break;
				case 5:
					Console.WriteLine("HIstory books contains history about phenomenon happened in the past");
					break;
			}
		}else
		{
			Console.WriteLine("No Description");	
		}
	}
}