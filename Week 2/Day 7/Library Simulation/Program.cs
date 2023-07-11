public class LibraryBorrow : EventArgs
{
	public string BorrowedBookType {get; set;}
	public string BorrowedBookTitle {get; set;}
	
	public LibraryBorrow(string borrowedBookType, string borrowedBookTitle)
	{
		BorrowedBookType = borrowedBookType;
		BorrowedBookTitle = borrowedBookTitle;
	}
}

public class LibraryReturn : EventArgs 

{
	public string ReturnedBookType {get; set;}
	public string ReturnedBookTitle {get; set;}
	
	public LibraryReturn(string returnedBookType, string returnedBookTitle)
	{
		ReturnedBookType = returnedBookType;
		ReturnedBookTitle = returnedBookTitle;
	}
}

public class Borrower
{
	public string Name{get; set;}
	public Borrower(string name)
	{
		Name = name;
	}
	private void Library_BookBorrowed(object sender, LibraryBorrow e)
	{
		Console.WriteLine($"{Name} borrowed {e.BorrowedBookType}: {e.BorrowedBookTitle}");
	}
	private void Library_BookReturned(object sender, LibraryReturn e)
	{
		Console.WriteLine($"{Name} returned {e.ReturnedBookType}: {e.ReturnedBookTitle}");
	}
	public void BorrowBook(Library library)
	{
		library.BorrowBooks += Library_BookBorrowed;
	}
	
	public void ReturnBook(Library library)
	{
		library.ReturnBooks += Library_BookReturned;
	}
}

public class Library
{
	public event EventHandler<LibraryBorrow> BorrowBooks;
	public event EventHandler<LibraryReturn> ReturnBooks;
	
	public void Borrow(string borrowedBookType, string borrowedBookTitle)
	{
		Console.WriteLine($"Borrowing {borrowedBookType} books: {borrowedBookTitle}");
	}
	public void Return(string returnedBookType, string returnedBookTitle)
	{
		Console.WriteLine($"Returning {returnedBookType} books: {returnedBookTitle}");
	}
	protected virtual void onBookBorrow(LibraryBorrow e)
	{
		BorrowBooks?.Invoke(this, e);
	}
	protected virtual void onBookReturn(LibraryReturn e)
	{
		ReturnBooks?.Invoke(this, e);
	}
}

class Program
{
	static void Main()
	{
		Library library = new Library();
		Borrower borrower1 = new Borrower("Albedo");
		Borrower borrower2 = new Borrower("Sucrose");
		borrower1.BorrowBook(library);
		library.Borrow("Fiction", "The Alchemist");
		// INVOKE NOT WORKING?
		borrower2.ReturnBook(library);
		library.Return("Non Fiction", "Mastering Alchemist");
	}
}