namespace designPatterns.uj_design_patterns_assignments.observer;

public interface ISubject
{
    public void Attach(Observer o);
    public void Detach(Observer o);
    public void Notify(EWeatherParameter p);
}
