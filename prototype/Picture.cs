using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.prototype
{
    internal class Picture : Multimedia
    {
        public Picture(string name, MultimediaObj obj) : base(name, "picture", obj)
        {
        }

        public override object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override object Clone()
        {
            return new Picture(Name, new MultimediaObj(Obj.Value));
        }

        public override string ToString()
        {
            return "Picture\nname:" + Name + "\nmultimedia object:\n" + Obj + "\n";
        }
    }
}
