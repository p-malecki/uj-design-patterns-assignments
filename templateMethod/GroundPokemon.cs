namespace designPatterns.uj_design_patterns_assignments.templateMethod;


public class GroundPokemon : Pokemon
{
    public override string ToString()
    {
        return $"GroundPokemon {Name}";
    }

    public override double CalcImpact()
    {
        return Attack * Power;
    }

}