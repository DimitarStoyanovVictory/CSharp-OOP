using VehicleParkSystemBest.Utilities;

namespace VehicleParkSystemBest.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(string licencePlate, string owner, int hours)
            : base(licencePlate, owner, Constants.TruckRegularRate, Constants.TruckOvertimeRate, hours)
        {
        }
    }
}