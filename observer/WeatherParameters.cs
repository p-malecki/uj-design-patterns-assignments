namespace WP_zad2_observer;

public struct WeatherParameters
{
    public double Humidity;
    public double Temperature;
    public double Pressure;
    public WeatherParameters (double humidity, double temperature, double pressure)
    {
        Humidity = humidity;
        Temperature = temperature;
        Pressure = pressure;
    }
}