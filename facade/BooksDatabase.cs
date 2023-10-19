namespace WP_zad1_fasada;

class BooksDatabase
{
    internal List<string> _bookID { get; set; } = new();
    internal List<string> _bookTitle { get; set; } = new();
    internal List<string> _bookAuthor { get; set; } = new();
    internal List<bool> _bookIssueStatus { get; set; } = new();
    internal void Update(string bookID, string bookTitle, string bookAuthor)
    {
        _bookID.Add(bookID);
        _bookTitle.Add(bookTitle);
        _bookAuthor.Add(bookAuthor);
        _bookIssueStatus.Add(false);
    }
}