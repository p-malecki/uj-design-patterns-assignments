﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.uj_design_patterns_assignments.abstract_factory;
using designPatterns.uj_design_patterns_assignments.abstract_factory;


namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal class BigShapeFactory : IShapeFactory
    {
        public IRectangle CreateRectangle(Point p, double w, double h)
        {
            return new BigRectangle(p, w, h);
        }

        public ISquare CreateSquare(Point p, double a)
        {
            return new BigSquare(p, a);
        }

        public ITriangle CreateTriangle(Point p1, Point p2, Point p3)
        {
            return new BigTriangle(p1, p2, p3);
        }
    }
}
