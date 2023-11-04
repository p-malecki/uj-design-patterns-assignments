namespace designPatterns.uj_design_patterns_assignments.facade;


class Patron
{
    internal PatronRecord _details { get; set; }
    internal string _patronID { get; init; }
    static int nextPatronID = 0;

    public Patron(
        string name,
        string address,
        string phoneNo,
        int maxBookLimit,
        string type = "patron",
        string patronID = ""
        )
    {
        _patronID = (string.IsNullOrEmpty(patronID)) ? patronID : nextPatronID++.ToString();
        _details = new(patronID, type, maxBookLimit, name, address, phoneNo);
    }

    internal string Search(BooksDatabase bDb)
    {
        Random rand = new Random();
        int idx = rand.Next(bDb._bookID.Count);
        return bDb._bookID[idx];
    }
    internal string Request(string bookID)
    {
        return bookID;
    }
    internal void PayFine()
    {
        _details.FinesOwed = 0;
    }
}