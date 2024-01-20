namespace designPatterns.uj_design_patterns_assignments.visitor;

class Program
{
    static void Main(string[] args)
    {
        var autoPartElements = new List<IAutoPartElement>()
        {
            new ElectricalPart(),
            new SuspensionPart(),
            new BodyPart()
        };
        
        var autoPartVisitor = new AutoPartVisitor();

        foreach (var autoPartElement in autoPartElements)
        {
            autoPartElement.Accept(autoPartVisitor);
        }

    }
}
