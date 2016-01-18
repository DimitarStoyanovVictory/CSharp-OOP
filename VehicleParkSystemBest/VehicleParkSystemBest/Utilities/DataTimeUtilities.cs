using System;
using System.Collections.Generic;

namespace VehicleParkSystemBest.Utilities
{
    public static class DataTimeUtilities
    {
        public static DateTime ParseISODateTime(string dateTimeString)
        {
            return DateTime.Parse(dateTimeString, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        public static List<string> ValidCommands = new List<string>() { "SetupPark", "Park", "Exit", "Status", "FindVehicle", "VehicleByOwner" };
    }
}
