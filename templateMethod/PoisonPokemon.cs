namespace WP_zad3_templateMethod;


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