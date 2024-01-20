namespace designPatterns.uj_design_patterns_assignments.visitor;

public class BodyPart : IAutoPartElement
{
    void IAutoPartElement.Accept(IAutoPartVisitor v)
    {
        v.VisitBodyPart(this);
    }

    public decimal AvgUsageTime()
    {
        return 3.0m;
    }

    public decimal FabricationCost()
    {
        return 3.0m;
    }

    public decimal FabricationTime()
    {
        return 3.0m;
    }

    public decimal YearlyCost()
    {
        return 3.0m;
    }

}