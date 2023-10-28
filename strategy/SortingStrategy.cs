using System;

namespace WP_zad3_strategy;

public abstract class SortingStrategy
{
    protected int[] ElementArray;
    protected int Size;

    public abstract void Sort();

    public override string ToString()
    {
        var result = string.Empty;
        foreach (var elem in ElementArray)
            result += elem + " ";

        return result;
    }

}
