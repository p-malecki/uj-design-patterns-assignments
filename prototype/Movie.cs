using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.prototype
{
    internal class Movie : Multimedia
    {
        public Movie(string name, MultimediaObj obj) : base(name, "movie", obj)
        {
        }

        public override object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override object Clone()
        {
            return new Movie(Name, new MultimediaObj(Obj.Value));
        }

        public override string ToString()
        {
            return "Movie\nname:" + Name + "\nmultimedia object:\n" + Obj + "\n";
        }
    }
}
