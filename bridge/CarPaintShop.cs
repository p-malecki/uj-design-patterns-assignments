using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.uj_design_patterns_assignments.bridge
{
    internal abstract class CarPaintShop
    {
        protected Vehicle? ClientsVehicle;

        internal void VehicleEnter(Vehicle vehicle)
        {
            Console.WriteLine(vehicle + " entered the CarPaintShop.");
            ClientsVehicle = vehicle;
        }

        internal void VehicleLeave()
        {
            Console.WriteLine(ClientsVehicle + " left the CarPaintShop.\n");
            ClientsVehicle = null;
        }
        internal abstract void ProvideService(string? optionalData=null);
    }
}
