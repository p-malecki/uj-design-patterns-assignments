namespace WP_zad1_adapter;

class LegacyCar
{
    Pos p = new(0, 0);
    void Drive(int X1, int Y1)
    {
        p.X += X1;
        p.Y += Y1;
    }
}