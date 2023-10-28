namespace WP_zad3_strategy;

class Program
{
    static void Main(string[] args)
    {
        var nums = new int[] { 73, 57, 49, 99, 133, 20, 1 };

        SelectionSort sel = new SelectionSort(nums, 7);
        Console.WriteLine(sel);
        sel.Sort();
        Console.WriteLine(sel);
    }

}
