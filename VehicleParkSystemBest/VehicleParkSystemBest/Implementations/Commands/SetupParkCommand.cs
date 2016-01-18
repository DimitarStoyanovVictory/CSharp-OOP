using System;
using System.Collections.Generic;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Implementations.Commands
{
    public class SetupParkCommand : ICommand
    {
        private IDictionary<string, string> _parameters;

        public string Name { get; set; }

        public IDictionary<string, string> Parameters
        {
            get
            {
                return _parameters;
            }

            set
            {
                if (!value.ContainsKey("sectors"))
                {
                    throw new ArgumentException("Parameters dictionary does not contain 'sectors'");
                }

                if (!value.ContainsKey("placesPerSector"))
                {
                    throw new ArgumentException("Parameters dictionary does not contain 'placesPerSector'");
                }

                if (Int32.Parse(value["sectors"]) < 1 || Int32.Parse(value["placesPerSector"]) < 1)
                {
                    throw new ArgumentOutOfRangeException("'sectors' or 'placesPerSector' < 1");
                }

                _parameters = value;
            }
        }

        public string[] Execute(VehiclePark vehiclePark)
        {
            var layout = new ParkLayout(Int32.Parse(_parameters["sectors"]), Int32.Parse(_parameters["placesPerSector"]));
            var data = new ParkData(Int32.Parse(_parameters["sectors"]));

            vehiclePark.VehicleParkCreated = true;
            vehiclePark.Layout = layout;
            vehiclePark.Data = data;

            return new[] { "Vehicle park created" };
        }
    }
}
