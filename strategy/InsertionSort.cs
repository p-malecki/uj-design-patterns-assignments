namespace WP_zad3_strategy;

public class InsertionSort : SortingStrategy
{
    public InsertionSort(int[] elementArray, int size)
    {
        ElementArray = elementArray;
        Size = size;
    }

    public override void Sort()
    {
        for (var i = 1; i < Size; i++)
        {
            var key = ElementArray[i];
            var flag = 0;
            for (var j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < ElementArray[j])
                {
                    ElementArray[j + 1] = ElementArray[j];
                    j--;
                    ElementArray[j + 1] = key;
                }
                else flag = 1;
            }
        }
    }
}
