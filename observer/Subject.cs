namespace WP_zad2_observer;

public class Subject : ISubject
{
    protected List<Observer> Observers = new();

    public void Attach(Observer o)
    {
        Observers.Add(o);
    }
    public void Detach(Observer o)
    {
        Observers.Remove(o);
    }
    public void Notify(EWeatherParameter p)
    {
        foreach(var observer in Observers)
        {
            observer.Update(p);
        }
        Console.WriteLine();
    }
}
