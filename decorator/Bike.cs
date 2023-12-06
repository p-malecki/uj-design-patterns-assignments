using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.decorator
{
    public class Bike
    {
        private string _components;

        public Bike() => _components = "";
        public Bike(Bike b) => _components = b._components;
        public void AddComponent(string c) => _components += (string.IsNullOrEmpty(_components) ? c: ", " + c);
        public void Show() => Console.WriteLine(_components);
    }
}
