namespace designPatterns.uj_design_patterns_assignments.templateMethod;


public class PoisonPokemon : Pokemon
{
    public override string ToString()
    {
        return $"PoisonPokemon {Name}";
    }

    public override double CalcImpact()
    {
        return Attack * Power * 0.5;
    }

}