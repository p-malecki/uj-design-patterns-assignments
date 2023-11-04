using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal class PaintWork : CarPaintShop
    {
        internal override void ProvideService(string? color = "white")
        {
            if (ClientsVehicle == null) return;

            Console.WriteLine(ClientsVehicle + " is painted.");
            ClientsVehicle.Paint(color!);
        }
    }
}
