namespace WP_zad1_fasada;


class Program
{
    static void Main(string[] args)
    {
        Librarian mrLibrarian = new("mr librarian", "addr", "123456789");
        Library theLibrary = new("location", mrLibrarian._librarianID);


        List<string[]> avaibleBooksToTrade = new()
        {
            new[] { "1", "title 1", "author 1"},
            new[] { "2", "title 2", "author 2"}
        };
        Vendor mrVendor = new("mr vendor", "addr", "123456789", avaibleBooksToTrade);


        LibraryFasade fasade = new(mrLibrarian, theLibrary, mrVendor);
        fasade.AddPatron("mr patreon 1", "addr", "123456789");
        fasade.AddPatron("mr patreon 2", "addr", "123456789");

        List<string> booksToOrder = new() { "1", "2", "3" };
        fasade.OrderNewBooks(booksToOrder);

        fasade.BorrowBook("2");

        fasade.PatronPayFine("3");
    }
}
