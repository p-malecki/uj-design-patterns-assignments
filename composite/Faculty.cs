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
    internal class Faculty : Composite
    {

        public Faculty(string name, string id) : base(name, id, "Faculty")
        {
        }

        public new void Add(IComponent c)
        {
            if (c is Chair)
            {
                base.Add(c);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
