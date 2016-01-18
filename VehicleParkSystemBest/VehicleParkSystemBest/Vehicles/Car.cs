namespace VehicleParkSystemBest.Vehicles
{
    using Utilities;

    public class Car : Vehicle
    {
        public Car(string licensePlate, string owner, int hours)
            : base(licensePlate, owner, Constants.CarRegularRate, Constants.CarOvertimeRate, hours)
        {
        }
    }
}