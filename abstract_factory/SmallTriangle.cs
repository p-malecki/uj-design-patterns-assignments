using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.uj_design_patterns_assignments.abstract_factory;

namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal class SmallTriangle : ITriangle
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }

        public SmallTriangle(Point p1, Point p2, Point p3) => (Point1, Point2, Point3) = (p1, p2, p3);

        public void Draw()
        {
            Console.WriteLine("Small Triangle");
            Console.WriteLine("Point 1: {0}, Y: {1}", Point1.X, Point1.Y);
            Console.WriteLine("Point 2: {0}, Y: {1}", Point2.X, Point2.Y);
            Console.WriteLine("Point 3: {0}, Y: {1}", Point3.X, Point3.Y);
        }
    }
}
