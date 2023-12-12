﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.builder
{
    internal class StudentsButtonsBuilder : ButtonsBuilder
    {
        public Button addButtons() => new("Students Buttons");
    }
}
