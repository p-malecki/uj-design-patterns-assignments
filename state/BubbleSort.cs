namespace WP_zad3_templateMethod;

public class BubbleSort : SortingState
{
    public BubbleSort(int[] elementArray, int size)
    {
        ElementArray = elementArray;
        Size = size;
    }

    public override void Sort()
    {
        for (var i = 0; i < Size - 1; i++)
        for (var j = 0; j < Size - i - 1; j++)
        {
            if (ElementArray[j] > ElementArray[j + 1])
                (ElementArray[i], ElementArray[j]) = (ElementArray[j], ElementArray[i]);
            }
    }
}
