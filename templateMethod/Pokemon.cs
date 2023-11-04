namespace designPatterns.uj_design_patterns_assignments.templateMethod;


public abstract class Pokemon
{
    protected string Name { get; set; }
    protected double Power { get; set; }
    protected double Attack { get; set; }
    protected double Defense { get; set; }

    public abstract override string ToString();

    public abstract double CalcImpact();

    public double CalcDamage()
    {
        return CalcImpact() - Defense * Power;
    }
}
