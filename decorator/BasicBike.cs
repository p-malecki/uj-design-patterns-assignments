using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.decorator
{
    public class BasicBike: BikeBase
    {
        public override Bike Execute()
        {
            Bike bike = new();
            bike.AddComponent("Bike with: wheels");
            return bike;
        }
    }
}
