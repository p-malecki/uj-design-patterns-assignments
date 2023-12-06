using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.factory_method
{
    internal class TriangleCreator : ShapeCreator
    {
        public override IShape Factory()
        {
            return new Triangle();
        }
    }
}
