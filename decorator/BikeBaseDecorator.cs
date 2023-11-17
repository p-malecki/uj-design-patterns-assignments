using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.decorator
{
     public abstract class BikeBaseDecorator: BikeBase
    {
        protected BikeBase Wrappee;

        public BikeBaseDecorator(BikeBase baseBike) => Wrappee = baseBike;
        public void SetComponent(BikeBase baseBike) => Wrappee = baseBike;

        public override Bike Execute()
        {
            if (this.Wrappee != null)
            {
                return Wrappee.Execute();
            }
            else
            {
                return new Bike();
            }
        }


    }
}
