namespace WP_zad1_adapter;

class Program
{
    static void Main(string[] args)
    {
        var rt = new RaceTrack();
        rt.VehicleList.Add(new Vehicle());
        rt.VehicleList[0].MoveTo(2, 2);
    }
}