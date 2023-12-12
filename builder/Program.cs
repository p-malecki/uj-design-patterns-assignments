using designPatterns.uj_design_patterns_assignments.builder;
namespace designPatterns.uj_design_patterns_assignments.builder;


class Program
{
    static void Main()
    {
        FormBuilder fBuilder = new FormBuilder();
        StudentsButtonsBuilder bBuilder = new StudentsButtonsBuilder();
        StudentsWMBuilder wmBuilder = new StudentsWMBuilder();

        fBuilder.setButtonsBuilder(bBuilder);
        fBuilder.setWMBuilder(wmBuilder);
        fBuilder.constructForm();
        Form form = fBuilder.getForm();

        form.ShowForm();

        Console.WriteLine();

        AdminButtonsBuilder bBuilder2 = new AdminButtonsBuilder();
        AdminWMBuilder wmBuilder2 = new AdminWMBuilder();
        fBuilder.setButtonsBuilder(bBuilder2);
        fBuilder.setWMBuilder(wmBuilder2);
        fBuilder.constructForm();
        Form form2 = fBuilder.getForm();

        form2.ShowForm();
    }
}

