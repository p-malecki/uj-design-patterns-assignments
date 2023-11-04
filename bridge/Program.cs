using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Car("blue", true, false, 5);
            var l = new Limousine("black", false, false, 100, true);
            var t = new Truck("red", true, true, 12345);
            var m = new Motorbike("green", false, true);


            var paintWorkshop = new PaintWork();
            var polishWorkshop = new PolishWork();
            var removeDentsWorkshop = new RemoveDentsWork();

            paintWorkshop.VehicleEnter(c);
            paintWorkshop.ProvideService("pink");
            paintWorkshop.VehicleLeave();

            polishWorkshop.VehicleEnter(l);
            polishWorkshop.ProvideService();
            polishWorkshop.VehicleLeave();

            removeDentsWorkshop.VehicleEnter(t);
            removeDentsWorkshop.ProvideService();
            removeDentsWorkshop.VehicleLeave();

            removeDentsWorkshop.VehicleEnter(m);
            removeDentsWorkshop.ProvideService();
            removeDentsWorkshop.VehicleLeave();

            m.MakeMotorbikeSound();
        }
    }
}