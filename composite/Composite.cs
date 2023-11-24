using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.composite
{
    internal class Composite : IComponent
    {
        private string _type;
        protected string _name;
        protected string _id;
        protected List<IComponent> Children;

        public Composite(string name, string id, string type)
        {
            _name = name;
            _id = id;
            _type = type;
            Children = new List<IComponent>();
        }

        public void Add(IComponent c)
        {
            Children.Add(c);
        }

        public void Remove(IComponent c)
        {
            Children.Remove(c);
        }

        public List<IComponent> GetChildren(IComponent c)
        {
            return Children;
        }

        public void PrintName()
        {
            Console.WriteLine("{0}: {1}", _type, _name);
            foreach (var component in Children)
            {
                component.PrintName();
            }
        }

        public string GetId()
        {
            return _id;
        }

        public int GetHoursWorked()
        {
            var hoursWorked = Children.Select(c => c.GetHoursWorked()).Sum();
            return hoursWorked;
        }
    }
}
