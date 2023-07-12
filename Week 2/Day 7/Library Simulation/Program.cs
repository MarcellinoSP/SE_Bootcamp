using LibrarySimulation;

class Program
{
	static void Main()
	{
		Library library = new Library();
		Borrower borrower1 = new Borrower("Albedo");
		Borrower borrower2 = new Borrower("Sucrose");
		borrower1.BorrowBook(library);
		library.Borrow("Fiction", "The Alchemist");
		borrower2.ReturnBook(library);
		library.Return("Non Fiction", "Mastering Alchemist");
	}
}