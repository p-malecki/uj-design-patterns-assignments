namespace designPatterns.uj_design_patterns_assignments.adapter;

class Vehicle
{
    public Pos MoveTo(int X2, int Y2)
    {
        return new Pos(X2, Y2);
    }
}