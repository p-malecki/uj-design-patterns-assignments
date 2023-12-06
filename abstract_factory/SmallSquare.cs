using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.uj_design_patterns_assignments.abstract_factory;

namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal class SmallSquare : ISquare
    {
        public Point Pos { get; set; }
        public double Width { get; set; }

        public SmallSquare(Point p, double a) => (Pos, Width) = (p, a);

        public void Draw()
        {
            Console.WriteLine("Small Square");
            Console.WriteLine("X: {0}, Y: {1}", Pos.X, Pos.Y);
            Console.WriteLine("Size: {0}", Width);
        }
    }
}
