using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj_design_patterns.uj_design_patterns_assignments.composite
{
    internal class Employee : IComponent
    {
        private string _name;
        private string _id;
        private int _hoursWorked;

        public Employee(string name, string id, int hoursWorked=0)
        {
            _name = name;
            _id = id;
            _hoursWorked = hoursWorked;
        }

        public void PrintName()
        {
            Console.WriteLine("\t" + _name);
        }

        public string GetId()
        {
            return _id;
        }

        public int GetHoursWorked()
        {
            return _hoursWorked;
        }
    }
}
