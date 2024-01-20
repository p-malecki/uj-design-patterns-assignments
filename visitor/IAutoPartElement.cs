namespace designPatterns.uj_design_patterns_assignments.visitor;

public interface IAutoPartElement
{
    void Accept(IAutoPartVisitor v);
    decimal FabricationCost();
    decimal FabricationTime();
    decimal AvgUsageTime();
    decimal YearlyCost();
}