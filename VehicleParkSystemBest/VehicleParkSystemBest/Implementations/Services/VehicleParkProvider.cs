using VehicleParkSystemBest.Interfaces.Services;
using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Implementations.Services
{
    public class VehicleParkProvider : IVehicleParkProvider
    {
        private VehiclePark _vehiclePark = new VehiclePark(1, 1);
        private bool _vehicleParkCreated;

        public VehiclePark Current()
        {
            return _vehiclePark;
        }

        public bool VehicleParkCreated
        {
            get
            {
                return _vehicleParkCreated;
            }

            set
            {
                _vehicleParkCreated = value;
            }
        }
    }
}