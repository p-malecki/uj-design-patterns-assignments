namespace WP_zad2_observer;

public class StatisticsDisplay : Observer
{
    private const string Header = "StatisticsDisplay";
    public StatisticsDisplay(
        double humidity,
        double temperature,
        double pressure,
        DateTime? observationDate=null
        ) : base(humidity, temperature, pressure, observationDate)
    {
    }
    public override void Update(EWeatherParameter p)
    {
        Console.Write(Header + "\t ");
        base.Update(p);
    }

    public void DisplayStats()
    {
        Console.WriteLine("Statistics");
        Console.WriteLine(nameof(base.ObservationDate) + ":\t" + base.ObservationDate);
        Console.WriteLine(nameof(base.WeatherParameters.Humidity) + ":\t\t" + base.WeatherParameters.Humidity);
        Console.WriteLine(nameof(base.WeatherParameters.Temperature) + ":\t\t" + base.WeatherParameters.Temperature);
        Console.WriteLine(nameof(base.WeatherParameters.Pressure) + ":\t\t" + base.WeatherParameters.Pressure);
        Console.WriteLine("\n");
    }
}