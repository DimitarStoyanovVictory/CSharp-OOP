using System;
using VehicleParkSystemBest.Model;
using VehicleParkSystemBest.Vehicles;

namespace VehicleParkSystemBest.Test
{
    public class VehicleParkBuilder
    {
        private VehiclePark _vehiclePark = new VehiclePark(1,1);

        public VehicleParkBuilder WithInitialState(int sectors, int placesPerSector)
        {
            _vehiclePark = new VehiclePark(sectors, placesPerSector);
            return this;
        }

        public VehicleParkBuilder WithCar(Car car = null, int sector = 0, int place = 0, DateTime? time = null)
        {
            car = car == null ? new Car("CA1001HH", "Jay Margareta", 1) : null;

            sector = sector == 0 ? 1 : sector;
            place = place == 0 ? 1 : place;

            if (time == null)
            {
                time = new DateTime(2015, 05, 04, 10, 30, 00);
            }

            CarOutput = _vehiclePark.InsertVehicleInPark(car, sector, place, time.Value);
            
            return this;
        }

        public VehicleParkBuilder WithMotorBike(Motorbike motorBike = null, int sector = 0, int place = 0, DateTime? time = null)
        {
            motorBike = motorBike == null ? new Motorbike("CA5555AH", "Jay Margareta", 1) : null;

            sector = sector == 0 ? 1 : sector;
            place = place == 0 ? 1 : place;

            if (time == null)
            {
                time = DateTime.UtcNow;
            }

            MotorOutput = _vehiclePark.InsertVehicleInPark(motorBike, sector, place, time.Value);

            return this;
        }

        public VehicleParkBuilder WithTruck(Truck truck = null, int sector = 0, int place = 0, DateTime? time = null)
        {
            truck = truck == null ? new Truck("C5842CH", "Jay Margareta", 1) : null;

            sector = sector == 0 ? 1 : sector;
            place = place == 0 ? 1 : place;

            if (time == null)
            {
                time = DateTime.UtcNow;
            }

            TruckOutput = _vehiclePark.InsertVehicleInPark(truck, sector, place, time.Value);

            return this;
        }

        public string[] CarOutput { get; set; }


        public string[] MotorOutput { get; set; }

        public string[] TruckOutput { get; set; }

        public VehiclePark Build()
        {
            return _vehiclePark;
        }
    }
}
