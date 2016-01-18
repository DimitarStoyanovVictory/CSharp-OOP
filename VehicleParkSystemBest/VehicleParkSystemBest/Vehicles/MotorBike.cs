using VehicleParkSystemBest.Utilities;

namespace VehicleParkSystemBest.Vehicles
{
    public class Motorbike : Vehicle
    {
        public Motorbike(string licensePlate, string owner, int hours)
            : base(licensePlate, owner, Constants.MotorRegularRate, Constants.MoterOvertimeRate, hours )
        {
        }
    }
}