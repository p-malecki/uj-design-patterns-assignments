namespace designPatterns.uj_design_patterns_assignments.facade;


class LibraryFasade
{
    private Librarian _librarian;
    private Library _library;
    private BooksDatabase _booksDatabase;
    private List<Patron> _patrons;
    private Vendor _vendor;

    public LibraryFasade(Librarian librarian, Library library, Vendor vendor)
    {
        _librarian = librarian;
        _library = library;
        _vendor = vendor;
        _patrons = new();
        _booksDatabase = new BooksDatabase();
    }

    public void AddPatron(string name, string address, string phoneNo, int maxBookLimit=10)
    {
        Patron newPatron = new(name, address, phoneNo, maxBookLimit);
        _patrons.Add(newPatron);
    }

    public void OrderNewBooks(List<string> booksID)
    {
        List<string> idOfAvaibleBooks = new();
        foreach (var id in booksID)
        {
            if(_vendor.Search(id) == true)
                idOfAvaibleBooks.Add(id);
        }
        var sumToPay = _vendor.PaymentDetails(idOfAvaibleBooks.Count);
        _librarian.Payment(sumToPay);

        List<string> booksTitles = new();
        List<string> booksAuthors = new();
        (booksID, booksTitles, booksAuthors) = _vendor.SupplyBooks(idOfAvaibleBooks);

        for (int i = 0; i < booksID.Count; i++)
            _booksDatabase.Update(booksID[i], booksTitles[i], booksAuthors[i]);
    }

    public void BorrowBook(string patronID)
    {
        if (_librarian.VerifyMember(patronID, _patrons) == true)
        {
            Patron? p = _patrons.Find(item => string.Equals(item._patronID, patronID));
            if (p == null) return;
            string bookID = p.Search(_booksDatabase);
            if (_librarian.SearchBook(p.Request(bookID), _booksDatabase) == true)
            {
                if (_librarian.IssueStatus(bookID, _booksDatabase) == false)
                    _librarian.IssueBook(bookID, _booksDatabase);
                else
                    Console.WriteLine("already issued");
            }
            else
                Console.WriteLine("can not find selected book");
        }

    }

    public void PatronPayFine(string patronID)
    {
        if (_librarian.VerifyMember(patronID, _patrons) == true)
        {
            Patron? p = _patrons.Find(item => string.Equals(item._patronID, patronID));
            p?.PayFine();
        }
    }
}