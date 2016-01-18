using System.Collections.Generic;

namespace VehicleParkSystemBest.Test.Utilites
{
    public static class Inputs
    {
        public const string CreateDefaultPark = "SetupPark {\"sectors\": 3, \"placesPerSector\": 5}";

        public const string ParkCar = "Park {\"type\": \"car\"," +
                                              " \"time\": \"2015-05-04T10:30:00.0000000\"," +
                                              " \"sector\": 1, \"place\": 5," +
                                              " \"licensePlate\": \"CA1001HH\"," +
                                              " \"owner\": \"Jay Margareta\"," +
                                              " \"hours\": 1} ";

        public const string ParkMotor = "Park {\"type\": \"motorbike\"," +
                                        " \"time\": \"2015-05-04T10:40:00.0000000\"," +
                                        " \"sector\": 2, \"place\": 3," +
                                        " \"licensePlate\": \"CA5555AH\"," +
                                        " \"owner\": \"Guy Sheard\"," +
                                        " \"hours\": 2}";

        public const string ParkTruck = "Park {\"type\": \"truck\"," +
                                        " \"time\": \"2015-05-04T10:45:00.0000000\"," +
                                        " \"sector\": 1, \"place\": 1," +
                                        " \"licensePlate\": \"C5842CH\"," +
                                        " \"owner\": \"Jessie Raul\"," +
                                        " \"hours\": 1}";

        public const string Status = "Status {}";

        public const string VehicleByLp = "FindVehicle {\"licensePlate\": \"CA1001HH\"}";

        public const string VehicleByOwner = "VehiclesByOwner {\"owner\": \"Jay Margareta\"}";

        public const string ExitCar = "Exit {\"licensePlate\": \"CA1001HH\"," +
                                      " \"time\": \"2015-05-04T13:30:00.0000000\"," +
                                      " \"paid\": 40.00}";

        public static readonly List<string> IntegrationTestParams = new List<string>()
        {
            CreateDefaultPark, ParkCar, Status, VehicleByLp, VehicleByOwner, ExitCar
        };
    }
}
