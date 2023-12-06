using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace designPatterns.uj_design_patterns_assignments.composite
{
    internal class Institute : Composite
    {
        public Institute(string name, string id) : base(name, id, "Institute")
        {
        }
        public new void Add(IComponent c)
        {
            if (c is Department)
            {
                base.Add(c);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public override void PrintName()
        {
            Console.Write("\t\t");
            base.PrintName();
        }
    }
}
