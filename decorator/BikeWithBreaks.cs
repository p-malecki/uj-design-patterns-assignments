using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.decorator
{
    public class BikeWithBreaks: BikeBaseDecorator
    {
        public BikeWithBreaks(BikeBase baseBike) : base(baseBike) { }

        public override Bike Execute()
        {
            Bike bike = base.Execute();
            return ExtraPart(bike);
        }

        public Bike ExtraPart(Bike b)
        {
            b.AddComponent("breaks");
            return b;
        }

    }
}
