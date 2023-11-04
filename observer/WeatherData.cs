namespace designPatterns.uj_design_patterns_assignments.observer;

public class WeatherData : Subject
{
    public void GetHumidity()
    {
        Console.WriteLine("Humidity:");
        foreach (var observer in base.Observers)
            observer.Update(EWeatherParameter.Humidity);
        Console.WriteLine("\n");
    }
    public void GetTemperature()
    {
        Console.WriteLine("Temperature:");
        foreach (var observer in base.Observers)
            observer.Update(EWeatherParameter.Temperature);
        Console.WriteLine("\n");
    }
    public void GetPressure()
    {
        Console.WriteLine("Pressure:");
        foreach (var observer in base.Observers)
            observer.Update(EWeatherParameter.Pressure);
        Console.WriteLine("\n");
    }
}
