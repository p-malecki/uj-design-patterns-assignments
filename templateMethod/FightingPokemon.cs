namespace WP_zad3_templateMethod;


public class FightingPokemon : Pokemon
{
    public override string ToString()
    {
        return $"FightingPokemon {Name}";
    }

    public override double CalcImpact()
    {
        return Attack * Power * 2;
    }

}