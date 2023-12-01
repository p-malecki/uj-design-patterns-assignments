using uj_design_patterns.uj_design_patterns_assignments.factory_method;

namespace designPatterns.uj_design_patterns_assignments.factory_method;


class Program
{
    static void Main()
    {
        RectangleCreator rc = new();
        IShape r = rc.Factory();
        r.Draw();

        rc.DrawShape();

        SquareCreator sc = new();
        sc.DrawShape();

        TriangleCreator tc = new();
        tc.DrawShape();

    }
}
