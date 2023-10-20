namespace WP_zad2_iterator;

public interface IIterator
{
    public object? First();
    public object? Next();
    public bool HasNext();
}
