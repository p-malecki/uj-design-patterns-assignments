namespace WP_zad1_fasada;

class Library
{
    internal string _location { get; init; }
    internal string _librarianID { get; init; }

    public Library(string location, string librarianID)
    {
        _location = location;
        _librarianID = librarianID;
    }
}