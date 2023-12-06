using designPatterns.uj_design_patterns_assignments.abstract_factory;
namespace designPatterns.uj_design_patterns_assignments.abstract_factory;


class Program
{
    static void Main()
    {
        SmallShapeFactory SSF = new();
        BigShapeFactory BSF = new();

        var smallR = SSF.CreateRectangle(new Point(1, 1), 2, 4);
        smallR.Draw();
        Console.WriteLine("\n");

        var bigS = BSF.CreateSquare(new Point(2, 2), 50);
        bigS.Draw();
        Console.WriteLine("\n");


        var smallT = SSF.CreateTriangle(new Point(1, 1), new Point(2, 2), new Point(3, 3));
        smallT.Draw();
        Console.WriteLine("\n");

        var bigT = BSF.CreateTriangle(new Point(1, 1), new Point(20, 20), new Point(30, 30));
        bigT.Draw();
        Console.WriteLine("\n");
    }
}
