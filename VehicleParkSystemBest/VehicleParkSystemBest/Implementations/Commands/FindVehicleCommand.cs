using System.Collections.Generic;
using System.Linq;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Implementations.Commands
{
    public class FindVehicleCommand : ICommand
    {
        public string Name { get; private set; }

        public IDictionary<string, string> Parameters { get; private set; }

        public string[] Execute(VehiclePark vehiclePark)
        {
            return vehiclePark.FindVehicle(Parameters.Values.ToArray()[0]);
        }
    }
}