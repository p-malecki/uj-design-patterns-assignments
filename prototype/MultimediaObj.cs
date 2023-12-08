using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.uj_design_patterns_assignments.prototype
{
    internal class MultimediaObj
    {
        public void PrintObjectId()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
