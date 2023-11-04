namespace designPatterns.uj_design_patterns_assignments.facade;

class Librarian : Patron
{
    internal string _name { get; set; } = "";
    internal string _librarianID { get; init; } = "";

    public Librarian(
        string name,
        string address,
        string phoneNo,
        int maxBookLimit = int.MaxValue,
        string librarianID = ""
        ) : base(name, address, phoneNo, maxBookLimit, type: "librarian", patronID: librarianID)
    {
        _name = name;
        _librarianID = librarianID;
    }

    internal bool SearchBook(string bookID, BooksDatabase bDb)
    {
        return bDb._bookID.Contains(bookID);
    }
    internal bool VerifyMember(string patronID, List<Patron> patrons)
    {
        return patrons.Any(item => string.Equals(item._patronID, patronID));
    }
    internal bool IssueStatus(string bookID, BooksDatabase bDb)
    {
        var bookIdx = bDb._bookID.FindIndex(item => string.Equals(item, bookID));
        return bDb._bookIssueStatus[bookIdx];
    }
    internal void IssueBook(string bookID, BooksDatabase bDb)
    {
        var bookIdx = bDb._bookID.FindIndex(item => string.Equals(item, bookID));
        bDb._bookIssueStatus[bookIdx] = true;
    }
    internal void Payment(decimal sumToPay) { /* pay for books */ }
}