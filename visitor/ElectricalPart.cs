namespace designPatterns.uj_design_patterns_assignments.visitor;

public class ElectricalPart : IAutoPartElement
{
    void IAutoPartElement.Accept(IAutoPartVisitor v)
    {
        v.VisitElectricalPart(this);
    }

    public decimal AvgUsageTime()
    {
        return 1.0m;
    }

    public decimal FabricationCost()
    {
        return 1.0m;
    }

    public decimal FabricationTime()
    {
        return 1.0m;
    }

    public decimal YearlyCost()
    {
        return 1.0m;
    }

}