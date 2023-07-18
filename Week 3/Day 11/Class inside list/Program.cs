class Program
{
	static void Main()
	{
		Shelf fictionArea = new();
		Book book1 = new Book
		{
			bookType = "Fiction",
			bookTitle = "The Alchemist",
			totalPages = 230,
		};
		Book book2 = new Book
		{
			bookType = "Fiction",
			bookTitle = "Merry Adventure of Robin Hood",
			totalPages = 192,
		};
		fictionArea.AddToList(book1);
		fictionArea.AddToList(book2);
	}
}

public class Shelf
{
	public List <Book> bookShelf {get; set;}
	
	public Shelf()						//Tanpa Constructors = unhandled exception
	{
		bookShelf = new List<Book>();
	}
	
	public void AddToList(Book item)
	{
		bookShelf.Add(item);
	}
}

public class Book
{
	public string? bookType {get; set;}
	public string? bookTitle {get; set;}
	public int totalPages {get; set;}
}

