namespace designPatterns.uj_design_patterns_assignments.command;

public class RepairCommand : ICommand
{
    private readonly IAutoPartElement _receiver;


    public RepairCommand(IAutoPartElement receiver)
    {
        this._receiver = receiver;
    }

    public void Execute()
    {
        this._receiver.Repair();
        Console.WriteLine("RepairCommand has been executed.");
    }
}