using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal class Truck: Vehicle
    {
        internal int LoadCapacity { get; set; }
        internal Truck(string color, bool isPolished, bool hasDent, int loadCapacity) : base(color, isPolished, hasDent, 18)
        {
            LoadCapacity = loadCapacity;
        }

        internal override string GetDescription() => "Truck";
    }
}
