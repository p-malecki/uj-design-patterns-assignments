using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.uj_design_patterns_assignments.abstract_factory;

namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal class BigRectangle : IRectangle
    {
        public Point Pos { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public BigRectangle(Point p, double w, double h) => (Pos, Width, Height) = (p, w, h);

        public void Draw()
        {
            Console.WriteLine("Big Rectangle");
            Console.WriteLine("X: {0}, Y: {1}", Pos.X, Pos.Y);
            Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
        }
    }
}
