using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.builder
{
    internal class Button
    {
        private readonly string _text;
        public Button(string t) => _text = t;
        public void Click() => Console.WriteLine(_text);
    }
}
