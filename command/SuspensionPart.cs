namespace designPatterns.uj_design_patterns_assignments.command;

public class SuspensionPart : IAutoPartElement
{
    public string PartId { get; set; } = "";

    public void Replace(string newPartId)
    {
        var prevPartId = PartId;
        PartId = newPartId;
        Console.WriteLine($"SuspensionPart has been replaced.");
        Console.WriteLine($"Previous ID: {prevPartId}\tCurrent ID: {PartId}");
    }

}
