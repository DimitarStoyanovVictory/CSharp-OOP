using System;
using System.Collections.Generic;
using VehicleParkSystemBest.Interfaces;
using Wintellect.PowerCollections;

namespace VehicleParkSystemBest.Model
{
    public class ParkData
    {
        public ParkData(int numberOfSectors)
        {
            VechiclePlaceInPark = new Dictionary<IVehicle, string>();
            ParkName = new Dictionary<string, IVehicle>();
            VehiclesByLicencePlate = new Dictionary<string, IVehicle>();
            CarInParkDate = new Dictionary<IVehicle, DateTime>();
            Owner = new MultiDictionary<string, IVehicle>(false);
            FreeSpaceStatus = new Dictionary<int, int>();
            SetFreeSpaceStatusKeysLength(numberOfSectors);
        }

        #region Data of the vehicle
        public Dictionary<IVehicle, string> VechiclePlaceInPark { get; private set; }

        public Dictionary<string, IVehicle> ParkName { get; private set; }

        public Dictionary<string, IVehicle> VehiclesByLicencePlate { get; private set; }

        public Dictionary<IVehicle, DateTime> CarInParkDate { get; private set; }

        public MultiDictionary<string, IVehicle> Owner { get; private set; }

        public Dictionary<int, int> FreeSpaceStatus { get; private set; } 
        #endregion

        private void SetFreeSpaceStatusKeysLength(int numberOfSectors)
        {
            for (int key = 1; key <= numberOfSectors; key++)
            {
                FreeSpaceStatus.Add(key, 0);
            }
        }
    }
}
