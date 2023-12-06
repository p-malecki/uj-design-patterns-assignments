﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.factory_method
{
    internal class RectangleCreator: ShapeCreator
    {
        public override IShape Factory()
        {
            return new Rectangle();
        }
    }
}