using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uj_design_patterns.uj_design_patterns_assignments.composite
{
    internal class Department : Composite
    {

        public Department(string name, string id) : base(name, id, "Department")
        {
        }

    }
}
