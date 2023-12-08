using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.builder
{
    internal class AdminButtonsBuilder : ButtonsBuilder
    {
        public Button addButtons() => new("Admin Buttons");
    }
}
