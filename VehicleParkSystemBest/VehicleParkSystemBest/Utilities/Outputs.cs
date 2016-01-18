using System.Collections.Generic;

namespace VehicleParkSystemBest.Test.Utilites
{
    public static class Outputs
    {
        public static readonly string[] VehicleParkCreated = {"Vehicle park created"};

        public static string NoVehicleParkSet = "The vehicle park has not been set up";

        public static readonly string[] GetStatusWithNoVehicles =
        {
            "Sector 1: 0 / 5 (0% full)",
            "Sector 2: 0 / 5 (0% full)",
            "Sector 3: 0 / 5 (0% full)"
        };

        public static readonly string[] GetStatusWithVehicles =
        {
            "Sector 1: 0 / 5 (0% full)",
            "Sector 2: 2 / 5 (40% full)",
            "Sector 3: 1 / 5 (20% full)"
        };

        public static readonly string[] GetStatus =
        {
            "Sector 1: 1 / 5 (20% full)",
            "Sector 2: 0 / 5 (0% full)",
            "Sector 3: 0 / 5 (0% full)"
        };

        public static readonly string[] ParkCar = { "Car parked successfully at place (1,5)" };

        public const string InvalidLicensePlate = "There is no vehicle with license plate CA1011HH in the park";

        public static readonly string[] FindVehicleByLP =
        {
            "Car [CA1001HH], owned by Jay Margareta",
            "Parked at (1,5)"
        };

        public const string NoVehicleByOwner = "No vehicles by Jay Margareta";

        public static readonly string[] FindVehicleByOwner =
        {
            "Car [CA1001HH], owned by Jay Margareta",
            "Parked at (1,5)",
            "Motorbike [CA5555AH], owned by Jay Margareta",
            "Parked at (2,3)",
            "Truck [C5842CH], owned by Jay Margareta",
            "Parked at (3,2)"
        };

        public static readonly string[] FindVehicleByOwnerIT =
        {
            "Car [CA1001HH], owned by Jay Margareta",
            "Parked at (1,5)",
        };

        public static readonly string[] ExitCar =
        {
            "********************",
            "Car [CA1001HH], owned by Jay Margareta",
            "at place (1,5)",
            "Rate: $2.00",
            "Overtime rate: $7.00",
            "--------------------",
            "Total: $9.00",
            "Paid: $40.00",
            "Change: $31.00",
            "********************"
        };

        public static readonly List<string[]> IntegrationTestResults = new List<string[]>()
        {
            VehicleParkCreated, ParkCar, GetStatus, FindVehicleByLP, FindVehicleByOwnerIT, ExitCar
        };
    }
}
