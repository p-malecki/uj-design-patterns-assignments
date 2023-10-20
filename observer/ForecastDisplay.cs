namespace WP_zad2_observer;

public class ForecastDisplay : Observer
{
    private const string Header = "ForecastDispay";
    public ForecastDisplay(
        double humidity,
        double temperature,
        double pressure,
        DateTime? observationDate = null
    ) : base(humidity, temperature, pressure, observationDate)
    {
    }
    public override void Update(EWeatherParameter p)
    {
        Console.Write(Header + "\t\t ");
        base.Update(p);
    }

    public void DisplayPredictions()
    {
        Console.WriteLine("Forecast predictions");
        Console.WriteLine(nameof(base.ObservationDate) + ":\t" + base.ObservationDate);
        Console.WriteLine(nameof(base.WeatherParameters.Humidity) + ":\t\t" + base.WeatherParameters.Humidity);
        Console.WriteLine(nameof(base.WeatherParameters.Temperature) + ":\t\t" + base.WeatherParameters.Temperature);
        Console.WriteLine(nameof(base.WeatherParameters.Pressure) + ":\t\t" + base.WeatherParameters.Pressure);
        Console.WriteLine("\n");
    }
}