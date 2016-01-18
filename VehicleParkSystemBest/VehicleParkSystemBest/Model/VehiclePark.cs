using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Vehicles;

namespace VehicleParkSystemBest.Model
{
    public class VehiclePark : IVehiclePark
    {
        public VehiclePark(int numberOfSectors, int placesPerSector)
        {
            Layout = new ParkLayout(numberOfSectors, placesPerSector);
            Data = new ParkData(numberOfSectors);
        }

        public bool VehicleParkCreated = false;

        public ParkLayout Layout { get; set; }

        public ParkData Data { get; set; }

        public string[] InsertCar(Car car, int sector, int place, DateTime time)
        {
            return InsertVehicleInPark(car, sector, place, time);
        }

        public string[] InsertMotorbike(Motorbike motorBike, int sector, int place, DateTime time)
        {
            return InsertVehicleInPark(motorBike, sector, place, time);
        }

        public string[] InsertTruck(Truck truck, int sector, int place, DateTime time)
        {
            return InsertVehicleInPark(truck, sector, place, time);
        }

        public string[] ExitVehicle(string licencePlate, DateTime end, decimal money)
        {
            var vehicle = (Data.VehiclesByLicencePlate.ContainsKey(licencePlate)) ? Data.VehiclesByLicencePlate[licencePlate] : null;
            if (vehicle == null)
            {
                return new [] { string.Format("There is no vehicle with license plate {0} in the park", licencePlate) };
            }

            var start = Data.CarInParkDate[vehicle];
            int endd = (int)Math.Round((end - start).TotalHours);
            string[] ticket = new string[10];
            decimal total = endd - vehicle.ReservedHours < 0
                ? vehicle.ReservedHours*vehicle.RegularRate
                : vehicle.ReservedHours*vehicle.RegularRate +
                  ((endd - vehicle.ReservedHours)*vehicle.OvertimeRate);
            

            ticket[0] = new string('*', 20);
            ticket[1] = vehicle.ToString();
            ticket[2] = string.Format("at place {0}", Data.VechiclePlaceInPark[vehicle]);
            ticket[3] = string.Format("Rate: ${0:F2}", vehicle.RegularRate * vehicle.ReservedHours);
            ticket[4] = string.Format("Overtime rate: ${0:F2}",
                endd > vehicle.ReservedHours ? (endd - vehicle.ReservedHours) * vehicle.OvertimeRate : 0);
            ticket[5] = new string('-', 20);
            ticket[6] = string.Format("Total: ${0:F2}", total);
            ticket[7] = string.Format("Paid: ${0:F2}", money);
            ticket[8] = string.Format("Change: ${0:F2}", money - total);
            ticket[9] = string.Format(new string('*', 20));

            //DELETE
            int sector = int.Parse(Data.VechiclePlaceInPark[vehicle].Split(new[] { "(", ",", ")" }, StringSplitOptions.RemoveEmptyEntries)[0]);
            Data.ParkName.Remove(Data.VechiclePlaceInPark[vehicle]);
            Data.VechiclePlaceInPark.Remove(vehicle);
            Data.VehiclesByLicencePlate.Remove(vehicle.LicensePlate);
            Data.CarInParkDate.Remove(vehicle);
            Data.Owner.Remove(vehicle.Owner, vehicle);

            //END OF DELETE
            return ticket;
        }

        public string[] GetStatus()
        {
            return Data.FreeSpaceStatus.Select(x => string.Format("Sector {0}: {1} / {2} ({3:F0}% full)",
                                               x.Key, x.Value, Layout.PlacesPerSector,
                                               ((decimal)x.Value * 100) / Layout.PlacesPerSector)).ToArray();
        }

        public string[] FindVehicle(string licencePlate)
        {
            var vehicle = (Data.VehiclesByLicencePlate.ContainsKey(licencePlate)) ? Data.VehiclesByLicencePlate[licencePlate] : null;

            if (vehicle == null)
            {
                return new [] { string.Format("There is no vehicle with license plate {0} in the park", licencePlate) };
            }

            return Input(new[] { vehicle });
        }

        public string[] FindVehiclesByOwner(string owner)
        {
            if (Data.ParkName.Values.All(v => v.Owner != owner))
            {
                return new []{string.Format("No vehicles by {0}", owner)};
            }

            var vehiclesFound = Data.ParkName.Values.ToList();
            var vehicles = vehiclesFound;

            for (int index = 0; index < vehiclesFound.Count; index++)
            {
                vehicles = vehicles.Where(v => v.Owner == owner).ToList();
            }               

            return Input(vehicles);
        }

        private string[] Input(IEnumerable<IVehicle> vehicles)
        {
            List<string> carSuccessfullyParked = new List<string>();

            foreach(IVehicle vehicle in vehicles)
            {
                carSuccessfullyParked.Add(string.Format("{0} [{1}], owned by {2}", vehicle.GetType().Name, vehicle.LicensePlate, vehicle.Owner));
                carSuccessfullyParked.Add("Parked at " + Data.VechiclePlaceInPark[vehicle]);
            }

            return carSuccessfullyParked.ToArray();
        }

        public string[] InsertVehicleInPark(Vehicle vehicle, int sector, int place, DateTime time)
        {
            if (sector > Layout.Sectors)
            {
                return new[] { string.Format("There is no sector {0} in the park", sector) };
            }
            if (place > Layout.PlacesPerSector)
            {
                return new[] { string.Format("There is no place {0} in sector {1}", place, sector) };
            }
            if (Data.ParkName.ContainsKey(string.Format("({0},{1})", sector, place)))
            {
                return new[] { string.Format("The place ({0},{1}) is occupied", sector, place) };
            }
            if (Data.VehiclesByLicencePlate.ContainsKey(vehicle.LicensePlate))
            {
                return new[] { string.Format("There is already a vehicle with license plate {0} in the park", vehicle.LicensePlate) };
            }

            return InsertDataVehicle(vehicle, sector, place, time);
        }

        public string[] InsertDataVehicle(Vehicle vehicle, int sector, int place, DateTime time)
        {
            Data.VechiclePlaceInPark[vehicle] = string.Format("({0},{1})", sector, place);
            Data.ParkName[string.Format("({0},{1})", sector, place)] = vehicle;
            Data.VehiclesByLicencePlate[vehicle.LicensePlate] = vehicle;
            Data.CarInParkDate[vehicle] = time;
            Data.Owner[vehicle.Owner].Add(vehicle);
            Data.FreeSpaceStatus[sector] += 1;

            return new[] { string.Format("{0} parked successfully at place ({1},{2})", vehicle.GetType().Name, sector, place) };
        }
    }
}