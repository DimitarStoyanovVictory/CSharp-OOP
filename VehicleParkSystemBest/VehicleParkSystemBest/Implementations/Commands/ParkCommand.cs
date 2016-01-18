using System;
using System.Collections.Generic;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;
using VehicleParkSystemBest.Vehicles;

namespace VehicleParkSystemBest.Implementations.Commands
{
    public class ParkCommand : ICommand
    {
        public string Name { get; set; }
        public IDictionary<string, string> Parameters { get; set; }

        public string[] Execute(VehiclePark vehiclePark)
        {
            
            switch (Parameters["type"])
            {
                case "car":
                        return vehiclePark.InsertCar(
                            new Car(Parameters["licensePlate"],
                                    Parameters["owner"],
                                    Convert.ToInt32(Parameters["hours"])),
                                    Convert.ToInt32(Parameters["sector"]),
                                    Convert.ToInt32(Parameters["place"]),
                                    Convert.ToDateTime(Parameters["time"]));
                case "motorbike":
                        return vehiclePark.InsertMotorbike(
                            new Motorbike(Parameters["licensePlate"],
                                          Parameters["owner"],
                                          Convert.ToInt32(Parameters["hours"])),
                                          Convert.ToInt32(Parameters["sector"]),
                                          Convert.ToInt32(Parameters["place"]),
                                          Convert.ToDateTime(Parameters["time"]));
                case "truck":
                        return vehiclePark.InsertTruck(
                            new Truck(Parameters["licensePlate"],
                                      Parameters["owner"],
                                      Convert.ToInt32(Parameters["hours"])),
                                      Convert.ToInt32(Parameters["sector"]),
                                      Convert.ToInt32(Parameters["place"]),
                                      Convert.ToDateTime(Parameters["time"]));
                default:
                    return new [] { "There is no such type vehicle" };
            }
        }
    }
}
