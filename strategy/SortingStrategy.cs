using System;

namespace designPatterns.uj_design_patterns_assignments.strategy;

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
