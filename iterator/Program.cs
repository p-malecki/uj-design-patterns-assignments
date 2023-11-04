namespace designPatterns.uj_design_patterns_assignments.iterator;

class Program
{
    static void Main(string[] args)
    {
        var n5 = new Node(5);
        var n4 = new Node(4, leftChild: n5);
        var n3 = new Node(3, rightChild: n4);
        var n2 = new Node(2);
        var n1 = new Node(1, leftChild: n2, rightChild: n3);

        BinaryTree bt = new(n1);

        Iterator iter = new(bt);

        while (iter.HasNext())
            Console.WriteLine(iter.Next());

    }
}
