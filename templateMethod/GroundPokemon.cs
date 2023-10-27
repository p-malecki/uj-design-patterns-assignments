namespace WP_zad3_templateMethod;


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