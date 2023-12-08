using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.uj_design_patterns_assignments.prototype
{
    internal abstract class Multimedia
    {
        private string _name;
        private string _objectType;
        private MultimediaObj _obj;

        public Multimedia(string name, string objectType) {}

        public Multimedia clone() {}
        public string ToString() {}
    }
}
