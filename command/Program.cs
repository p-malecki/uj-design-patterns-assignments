namespace designPatterns.uj_design_patterns_assignments.command;

class Program
{
    static void Main(string[] args)
    {
        var selectedElectricalPart = new ElectricalPart();
        var selectedSuspensionPart = new SuspensionPart();
        var selectedBodyPart = new BodyPart();

        var invoker1 = new Invoker();
        var invoker2 = new Invoker();
        var invoker3 = new Invoker();
        invoker1.SetCommand(new UpdateSoftwareCommand(selectedElectricalPart, "2.0"));
        invoker2.SetCommand(new RepairCommand(selectedBodyPart));
        invoker3.SetCommand(new ReplaceCommand(selectedSuspensionPart, "1234"));

        invoker1.ExecuteCommand();
        invoker2.ExecuteCommand();
        invoker3.ExecuteCommand();
    }
}
