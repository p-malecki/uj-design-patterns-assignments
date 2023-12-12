using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.prototype
{
    internal class Music : Multimedia
    {
        public Music(string name, MultimediaObj obj) : base(name, "music", obj)
        {
        }

        public override object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override object Clone()
        {
            return new Music(Name, new MultimediaObj(Obj.Value));
        }

        public override string ToString()
        {
            return "Music\nname:" + Name + "\nmultimedia object:\n" + Obj + "\n";
        }
    }
}
