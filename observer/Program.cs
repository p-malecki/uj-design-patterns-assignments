namespace WP_zad2_observer;

class Program
{
    private static Random _rand = new Random();

    static void Main(string[] args)
    {
        WeatherData s = new();
        for (var i = 0; i < 3; i++)
        {
            s.Attach(new CurrentConditions(RandNum(), RandNum(), RandNum()));
            s.Attach(new StatisticsDisplay(RandNum(), RandNum(), RandNum()));
            s.Attach(new ForecastDisplay(RandNum(), RandNum(), RandNum()));
        }

        s.GetTemperature();
        s.GetHumidity();
        s.GetPressure();

        new CurrentConditions(RandNum(), RandNum(), RandNum()).Display();
        new StatisticsDisplay(RandNum(), RandNum(), RandNum()).DisplayStats();
        new ForecastDisplay(RandNum(), RandNum(), RandNum()).DisplayPredictions();

    }

    private static double RandNum()
    {
        return double.Round(_rand.NextDouble() * 100, 2);
    }

}
