using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal class Limousine: Vehicle
    {
        internal int Passengers { get; set; }
        internal bool HasBar { get; set; }

        internal Limousine(string color, bool isPolished, bool hasDent, int passengers, bool hasBar) : base(color, isPolished, hasDent, 4)
        {
            Passengers = passengers;
            HasBar = hasBar;
        }

        internal override string GetDescription() => "Limousine";

    }

}
