using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Model;
using VehicleParkSystemBest.Vehicles;

namespace VehicleParkSystemBest
{
    public class _CommandParameters : ICommandParameters
    {
        public _CommandParameters(string str)
        {
            Name = str.Substring(0, str.IndexOf(' '));
            Parameters = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(str.Substring(str.IndexOf(' ') + 1));
        }

        public VehiclePark VehicleInPark { get; set; }

        public string Name { get; set; }

        public IDictionary<string, string> Parameters { get; private set; }

        public string Execution(ICommandParameters command)
        {
            if (command.Name != "SetupPark" && VehicleInPark == null)
            {
                return "The vehicle park has not been set up";
            }

            switch (command.Name)
            {
                case "SetupPark":
                    return "Vehicle park created";
                case "Рark":
                    switch (command.Parameters["type"])
                    {
                        case "car":
                            return VehicleInPark.InsertCar(
                                    new Car(command.Parameters["licensePlate"], command.Parameters["owner"],
                                        int.Parse(command.Parameters["hours"])), int.Parse(command.Parameters["sector"]),
                                    int.Parse(command.Parameters["place"]),
                                    DateTime.Parse(command.Parameters["time"], null,
                                        System.Globalization.DateTimeStyles.RoundtripKind)); //why round trip kind??
                        case "motorbike":
                            return VehicleInPark.InsertMotorbike(
                                    new MotorBike(command.Parameters["licensePlate"], command.Parameters["owner"],
                                        int.Parse(command.Parameters["hours"])), int.Parse(command.Parameters["sector"]),
                                    int.Parse(command.Parameters["place"]),
                                    DateTime.Parse(command.Parameters["time"], null,
                                        System.Globalization.DateTimeStyles.RoundtripKind)); //stack overflow says this
                        case "truck":
                            return VehicleInPark.InsertTruck(
                                    new Truck(command.Parameters["licensePlate"], command.Parameters["owner"],
                                        int.Parse(command.Parameters["hours"])), int.Parse(command.Parameters["sector"]),
                                    int.Parse(command.Parameters["place"]),
                                    DateTime.Parse(command.Parameters["time"], null,
                                        System.Globalization.DateTimeStyles.RoundtripKind)); //I wanna know
                    }
                    break;

                case "Exit": return VehicleInPark.ExitVehicle(command.Parameters["licensePlate"],
                    DateTime.Parse(command.Parameters["time"], null,
                    System.Globalization.DateTimeStyles.RoundtripKind),
                    decimal.Parse(command.Parameters["money"]));
                case "Status": return VehicleInPark.GetStatus();
                case "FindVehicle": return VehicleInPark.FindVehicle(command.Parameters["licensePlate"]);
                case "VehiclesByOwner": return VehicleInPark.FindVehiclesByOwner(command.Parameters["owner"]);
                default: throw new IndexOutOfRangeException("Invalid command.");
            }

            return "";
        }
    }
}















