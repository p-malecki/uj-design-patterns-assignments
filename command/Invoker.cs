namespace designPatterns.uj_design_patterns_assignments.command;

public class Invoker
{
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        Console.WriteLine("\nInvoked.");
        _command?.Execute();
    }
}