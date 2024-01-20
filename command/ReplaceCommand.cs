namespace designPatterns.uj_design_patterns_assignments.command;

public class ReplaceCommand : ICommand
{
    private readonly SuspensionPart _receiver;
    private readonly string _newPartId;

    public ReplaceCommand(SuspensionPart receiver, string newPartId)
    {
        this._receiver = receiver;
        this._newPartId = newPartId;
    }

    public void Execute()
    {
        this._receiver.Replace(this._newPartId);
        Console.WriteLine("ReplaceCommand has been executed.");
    }
}