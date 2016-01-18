using System.Collections.Generic;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Implementations.Commands
{
    public class VehiclesByOwnerCommand : ICommand
    {
        public string Name { get; private set; }

        public IDictionary<string, string> Parameters { get; private set; }

        public string[] Execute(VehiclePark vehiclePark)
        {
            return vehiclePark.FindVehiclesByOwner(Parameters["owner"]);
        }
    }
}