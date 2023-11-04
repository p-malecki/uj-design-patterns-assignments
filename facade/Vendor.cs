namespace designPatterns.uj_design_patterns_assignments.facade;


class Vendor : Patron
{
    List<string[]> _bookDetails { get; init; } = new();
    const decimal pricePerBook = 10.0M;

    public Vendor(
      string name,
      string address,
      string phoneNo,
      List<string[]> bookDetails,
      int maxBookLimit = int.MaxValue,
      string id = ""
      ) : base(name, address, phoneNo, maxBookLimit, type: "vendor", patronID:id)
    {
        _bookDetails = bookDetails;
    }

    internal bool Search(string bookID)
    {
        return _bookDetails.Any(item => string.Equals(item[0], bookID));
    }
    internal (List<string>, List<string>, List<string>) SupplyBooks(List<string> booksID)
    {
        List<string> booksTitles = new();
        List<string> booksAuthors = new();

        foreach (var id in booksID)
        {
            var selectedBook = _bookDetails.Find(item => string.Equals(item[0], id));
            if (selectedBook != null) 
            {
                booksTitles.Add(selectedBook[1]);
                booksAuthors.Add(selectedBook[2]);
            }
        }
        return (booksID, booksTitles, booksAuthors);
    }
    internal decimal PaymentDetails(int booksNo)
    {
        return pricePerBook * booksNo;
    }
}