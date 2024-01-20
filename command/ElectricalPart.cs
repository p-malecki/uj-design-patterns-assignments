namespace designPatterns.uj_design_patterns_assignments.command;

public class ElectricalPart : IAutoPartElement
{
    public string PartId { get; set; } = "";
    public bool HasFault { get; set; } = false;
    public string SoftwareVersion { get; set; } = "";

    public void Replace(string newPartId)
    {
        var prevPartId = PartId;
        PartId = newPartId;
        Console.WriteLine($"ElectricalPart has been replaced.");
        Console.WriteLine($"Previous ID: {prevPartId}\tCurrent ID: {PartId}");
    }

    public void Repair()
    {
        HasFault = false;
        Console.WriteLine("ElectricalPart has been repaired.");
    }

    public void UpdateSoftware(string newVersion)
    {
        SoftwareVersion = newVersion;
        Console.WriteLine($"ElectricalPart's software has been updated to version {SoftwareVersion}.");
    }

}