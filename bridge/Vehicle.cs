using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal abstract class Vehicle
    {
        protected string Color { get; set; }
        protected bool IsPolished { get; set; }
        protected bool HasDent { get; set; }
        protected int WheelsAmount { get; set; }

        protected Vehicle(string color, bool isPolished, bool hasDent, int wheelsAmt)
        {
            Color = color;
            IsPolished = isPolished;
            HasDent = hasDent;
            WheelsAmount = wheelsAmt;
        }

        internal abstract string GetDescription();
        public override string ToString() => GetDescription();

        internal void Start() => Console.WriteLine("The vehicle is starting.");
        internal void Stop() => Console.WriteLine("The vehicle is stopping.");

        internal void Paint(string color) => Color = color;
        internal void Polish() => IsPolished = true;
        internal void RemoveDent() => HasDent = false;

    }
}
