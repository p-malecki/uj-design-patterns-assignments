using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal class Motorbike : Vehicle
    {
        internal Motorbike(string color, bool isPolished, bool hasDent) : base(color, isPolished, hasDent, 2) {}

        internal override string GetDescription() => "Motorbike";

        internal void MakeMotorbikeSound() => Console.WriteLine("Vroom! Vroom!");
    }
}
