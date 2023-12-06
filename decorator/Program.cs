using designPatterns.uj_design_patterns_assignments.decorator;

namespace designPatterns.uj_design_patterns_assignments.decorator;


class Program
{
    static void Main()
    {
        // bike configuration
        BasicBike basicBike = new BasicBike();
        Bike b1 = basicBike.Execute();
        b1.Show();

        BikeWithBreaks bikeWithBreaks = new BikeWithBreaks(basicBike);
        Bike b2 = bikeWithBreaks.Execute();
        b2.Show();

        BikeWithSaddle bikeWithBreaksAndSaddle = new BikeWithSaddle(bikeWithBreaks);
        Bike b3 = bikeWithBreaksAndSaddle.Execute();
        b3.Show();

    }
}
