namespace designPatterns.uj_design_patterns_assignments.iterator;

public class Iterator : IIterator
{
    BinaryTree? Aggregate;
    List<object> Values;
    int Current;

    public Iterator(BinaryTree aggregate)
    {
        Aggregate = aggregate;
        Values= new();
        Current = 0;
        BFS(aggregate.Root);
    }

    public object? First()
    {
        return Aggregate?.Root;
    }
    public object? Next()
    {
        if (HasNext())
            return Values[Current++];
        return null;
    }
    public bool HasNext()
    {
        return Current < Values.Count;
    }
    private void BFS(Node? n)
    {
        if (n != null)
        {
            Values.Add(n.Value);
            BFS(n.LeftChild);
            BFS(n.RightChild);
        }
    }
}
