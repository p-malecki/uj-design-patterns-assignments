using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.prototype
{
    internal class MultimediaObj
    {
        public string Value { get; }
        public MultimediaObj(string val) => Value = val;
        public override string ToString()
        {
            return "\tid:" + GetHashCode().ToString() + "\n\tvalue:" + Value;
        }
    }
}
