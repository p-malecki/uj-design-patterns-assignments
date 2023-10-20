namespace WP_zad2_iterator;

public class Node
{
    public object Value { get; set; }
    public Node? LeftChild { get; set; }
    public Node? RightChild { get; set; }
    public Node(object value, Node? leftChild=null, Node? rightChild = null)
    {
        Value = value;
        LeftChild = leftChild;
        RightChild = rightChild;
    }
}
