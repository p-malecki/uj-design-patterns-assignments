namespace designPatterns.uj_design_patterns_assignments.command;

public class ElectricalPart : IAutoPartElement
{
    public string SoftwareVersion { get; set; } = "";

    public void UpdateSoftware(string newVersion)
    {
        SoftwareVersion = newVersion;
        Console.WriteLine($"ElectricalPart's software has been updated to version {SoftwareVersion}.");
    }

}