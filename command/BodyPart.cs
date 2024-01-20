namespace designPatterns.uj_design_patterns_assignments.command;

public class BodyPart : IAutoPartElement
{
    public bool HasFault { get; set; } = false;

    public void Repair()
    {
        HasFault = false;
        Console.WriteLine("BodyPart has been repaired.");
    }

}