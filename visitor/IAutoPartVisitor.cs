namespace designPatterns.uj_design_patterns_assignments.visitor;

public interface IAutoPartVisitor
{
    void VisitElectricalPart(ElectricalPart ep);
    void VisitSuspensionPart(SuspensionPart sp);
    void VisitBodyPart(BodyPart bp);
}