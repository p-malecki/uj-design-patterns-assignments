namespace designPatterns.uj_design_patterns_assignments.command;

public interface IAutoPartElement
{
    public string PartId { get; set; }
    public bool HasFault { get; set; }
    public string SoftwareVersion { get; set; }

    void Replace(string newPartId);

    void Repair();

    void UpdateSoftware(string newVersion);
}