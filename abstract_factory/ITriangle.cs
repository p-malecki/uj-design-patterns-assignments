using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.uj_design_patterns_assignments.abstract_factory;


namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal interface ITriangle : IShape
    {
        Point Point1 { get; set; }
        Point Point2 { get; set; }
        Point Point3 { get; set; }
        public new void Draw();
    }
}
