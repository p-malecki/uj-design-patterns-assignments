using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uj_design_patterns.uj_design_patterns_assignments.composite;

namespace designPatterns.uj_design_patterns_assignments.composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee("e1", "001", 20);
            var e2 = new Employee("e2", "002", 10);
            var e3 = new Employee("e3", "003", 30);

            var d1 = new Department("d1", "001");
            var d2 = new Department("d2", "002");
            d1.Add(e1);
            d2.Add(e2);
            d2.Add(e3);

            var i1 = new Institute("i1", "001");
            var i2 = new Institute("i2", "002");
            i1.Add(d1);
            i2.Add(d2);

            var ch1 = new Chair("ch1", "001");
            ch1.Add(i1);
            ch1.Add(i2);

            var f1 = new Faculty("f1", "001");
            f1.Add(ch1);

            Console.WriteLine("Hours Worked at {0}: {1}", f1.GetId(), f1.GetHoursWorked());
            f1.PrintName();
        }
    }
}