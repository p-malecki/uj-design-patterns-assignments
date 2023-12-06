using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal interface IShapeFactory
    {
        IRectangle CreateRectangle(Point p, double w, double h);
        ISquare CreateSquare(Point p, double a);
        ITriangle CreateTriangle(Point p1, Point p2, Point p3);
    }
}
