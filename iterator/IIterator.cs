namespace designPatterns.uj_design_patterns_assignments.iterator;

public interface IIterator
{
    public object? First();
    public object? Next();
    public bool HasNext();
}
