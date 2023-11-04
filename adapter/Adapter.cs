namespace designPatterns.uj_design_patterns_assignments.adapter;

class Adapter : LegacyCar
{
    private Pos p = new(0, 0);
    void Drive(int X1, int Y1)
    {
        p = new Vehicle().MoveTo(X1, Y1);
    }
}