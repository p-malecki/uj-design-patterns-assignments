using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.factory_method
{
    internal abstract class ShapeCreator
    {
        public abstract IShape Factory();

        public void DrawShape()
        {
            var shape = Factory();
            shape.Draw();
        }
    }
}
