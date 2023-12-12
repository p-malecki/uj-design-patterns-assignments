using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.prototype
{
    internal abstract class Multimedia : ICloneable
    {
        protected readonly string Name;
        protected readonly string ObjectType;
        protected readonly MultimediaObj Obj;

        protected Multimedia(string name, string objectType, MultimediaObj obj)
        {
            Name = name;
            ObjectType = objectType;
            Obj = obj;
        }

        public abstract object ShallowClone();
        public abstract object Clone();
        public new abstract string ToString();
    }
}
