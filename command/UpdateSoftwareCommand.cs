namespace designPatterns.uj_design_patterns_assignments.command;

public class UpdateSoftwareCommand : ICommand
{
    private readonly IAutoPartElement _receiver;
    private readonly string _newSoftwareVersion;

    public UpdateSoftwareCommand(IAutoPartElement receiver, string newSoftwareVersion)
    {
        this._receiver = receiver;
        this._newSoftwareVersion = newSoftwareVersion;
    }

    public void Execute()
    {
        this._receiver.UpdateSoftware(this._newSoftwareVersion);
        Console.WriteLine("UpdateSoftwareCommand has been executed.");
    }
}