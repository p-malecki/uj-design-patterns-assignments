using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal class RemoveDentsWork : CarPaintShop
    {
        internal override void ProvideService(string? optionalData = null)
        {
            if (ClientsVehicle == null) return;

            Console.WriteLine(ClientsVehicle + "'s dents have been removed.");
            ClientsVehicle.RemoveDent();
        }
    }
}
