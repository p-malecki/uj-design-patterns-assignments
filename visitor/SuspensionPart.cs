namespace designPatterns.uj_design_patterns_assignments.visitor;

public class SuspensionPart : IAutoPartElement
{
    void IAutoPartElement.Accept(IAutoPartVisitor v)
    {
        v.VisitSuspensionPart(this);
    }

    public decimal AvgUsageTime()
    {
        return 2.0m;
    }

    public decimal FabricationCost()
    {
        return 2.0m;
    }

    public decimal FabricationTime()
    {
        return 2.0m;
    }

    public decimal YearlyCost()
    {
        return 2.0m;
    }

}