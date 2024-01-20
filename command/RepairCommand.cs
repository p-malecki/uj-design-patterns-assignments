namespace designPatterns.uj_design_patterns_assignments.command;

public class RepairCommand : ICommand
{
    private readonly BodyPart _receiver;


    public RepairCommand(BodyPart receiver)
    {
        this._receiver = receiver;
    }

    public void Execute()
    {
        this._receiver.Repair();
        Console.WriteLine("RepairCommand has been executed.");
    }
}