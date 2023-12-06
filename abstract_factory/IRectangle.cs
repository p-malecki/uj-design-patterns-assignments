﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.uj_design_patterns_assignments.abstract_factory;

namespace designPatterns.uj_design_patterns_assignments.abstract_factory
{
    internal interface IRectangle : IShape
    {
        Point Pos { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        public new void Draw();
    }
}
