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
    internal class Chair : Composite
    {
        public Chair(string name, string id) : base(name, id, "Chair")
        {
        }

        public new void Add(IComponent c)
        {
            if (c is Institute)
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
            Console.Write("\t");
            base.PrintName();
        }
    }
}
