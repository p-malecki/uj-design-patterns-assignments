using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal class Car : Vehicle
    {
        internal int NumberOfDoors { get; set; }
        internal Car(string color, bool isPolished, bool hasDent, int numOfDoors) : base(color, isPolished, hasDent, 4)
        {
            NumberOfDoors = numOfDoors;
        }
        internal override string GetDescription() => "Car";

    }
}
