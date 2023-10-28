namespace WP_zad3_strategy;

public class SelectionSort : SortingStrategy
{
    public SelectionSort(int[] elementArray, int size)
    {
        ElementArray = elementArray;
        Size = size;
    }

    public override void Sort()
    {
        for (var i = 0; i < Size - 1; i++)
        {
            var smallestVal = i;
            for (var j = i + 1; j < Size; j++)
            {
                if (ElementArray[j] < ElementArray[smallestVal])
                    smallestVal = j;
            }
            (ElementArray[smallestVal], ElementArray[i]) = (ElementArray[i], ElementArray[smallestVal]);
        }
    }
}
