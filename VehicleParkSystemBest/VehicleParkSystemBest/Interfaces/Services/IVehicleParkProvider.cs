using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Interfaces.Services
{
    public interface IVehicleParkProvider
    {
        VehiclePark Current();

        bool VehicleParkCreated { get; set; }
    }
}