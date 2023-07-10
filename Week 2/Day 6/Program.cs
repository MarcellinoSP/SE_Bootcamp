using IdentifyBookIndex;

public delegate void Book(in int a);
public class Program
{
	static void Main()
	{
		int indexNumber; 
		Console.Write("Insert Book Index Number: ");
		indexNumber = Convert.ToInt32(Console.ReadLine());
		
		// USING DELEGATE METHOD, UPDATED WITH MINOR BUGS
		BookIdentify books = new BookIdentify();
		BookDescription getDescription = new BookDescription();
		
		Book identify = null; 
		identify += books.GetBook;
		identify += getDescription.DescriptionBook;
		identify(indexNumber);
		// END OF DELEGATE METHOD
		
		// USING SIMPLE METHOD
		// BookIdentify books = new BookIdentify();
		// books.GetBook(in indexNumber);
		
		// BookDescription getDescription = new BookDescription();
		// getDescription.DescriptionBook(in indexNumber);
		// END OF METHOD
		// Console.ReadLine();
	}
}