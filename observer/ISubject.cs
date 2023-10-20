namespace WP_zad2_observer;

public interface ISubject
{
    public void Attach(Observer o);
    public void Detach(Observer o);
    public void Notify(EWeatherParameter p);
}
