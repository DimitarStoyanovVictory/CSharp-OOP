using System;
using System.Collections.Generic;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;
using VehicleParkSystemBest.Utilities;

namespace VehicleParkSystemBest.Implementations.Commands
{
    public class ExitCommand : ICommand
    {
        public string Name { get; private set; }

        public IDictionary<string, string> Parameters { get; private set; }

        public string[] Execute(VehiclePark current)
        {
            return current.ExitVehicle(Parameters["licensePlate"], 
                DataTimeUtilities.ParseISODateTime(Parameters["time"]), 
                Convert.ToDecimal(Parameters["paid"]));
        }
    }
}
