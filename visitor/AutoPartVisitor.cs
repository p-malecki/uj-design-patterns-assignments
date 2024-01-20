namespace designPatterns.uj_design_patterns_assignments.visitor;

public class AutoPartVisitor : IAutoPartVisitor
{
    public void VisitElectricalPart(ElectricalPart ep)
    {
        const decimal electricalPartTimeCostFactor = 3.0m;
        var timeCost = electricalPartTimeCostFactor * (ep.AvgUsageTime() + ep.FabricationTime());
        var costs = ep.FabricationCost() + ep.YearlyCost();
        var result = timeCost * costs;
        Console.WriteLine($"ElectricalPart: {result}$");
    }

    public void VisitSuspensionPart(SuspensionPart sp)
    {
        const decimal suspensionPartTimeCostFactor = 3.0m;
        var timeCost = suspensionPartTimeCostFactor * (sp.AvgUsageTime() + sp.FabricationTime());
        var costs = sp.FabricationCost() + sp.YearlyCost();
        var result = timeCost * costs;
        Console.WriteLine($"SuspensionPart: {result}$");
    }

    public void VisitBodyPart(BodyPart bp)
    {
        const decimal bodyPartTimeCostFactor = 3.0m;
        var timeCost = bodyPartTimeCostFactor * (bp.AvgUsageTime() + bp.FabricationTime());
        var costs = bp.FabricationCost() + bp.YearlyCost();
        var result = timeCost * costs;
        Console.WriteLine($"BodyPart: {result}$");
    }
}