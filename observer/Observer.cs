namespace designPatterns.uj_design_patterns_assignments.observer;

public class Observer : IObserver
{
    protected DateTime ObservationDate;
    protected WeatherParameters WeatherParameters;

    public Observer(
        double humidity,
        double temperature,
        double pressure,
        DateTime? observationDate = null
        )
    {
        ObservationDate = observationDate ?? DateTime.Now;
        WeatherParameters = new WeatherParameters(humidity, temperature, pressure);
    }

    public virtual void Update(EWeatherParameter p)
    {
        Console.Write(ObservationDate + "\t ");
        switch (p)
        {
            case EWeatherParameter.Humidity:
                Console.WriteLine(WeatherParameters.Humidity);
                break;
            case EWeatherParameter.Temperature:
                Console.WriteLine(WeatherParameters.Temperature);
                break;
            case EWeatherParameter.Pressure:
                Console.WriteLine(WeatherParameters.Pressure);
                break;
            case EWeatherParameter.None:
            default: break;
        }
    }
}
