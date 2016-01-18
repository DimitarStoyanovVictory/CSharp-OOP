using System.Collections.Generic;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Implementations.Commands
{
    public class StatusCommand : ICommand
    {
        public string Name { get; set; }

        public IDictionary<string, string> Parameters { get; set; }

        public string[] Execute(VehiclePark vehiclePark)
        {
            return vehiclePark.GetStatus();
        }
    }
}