using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Interfaces.Services;

namespace VehicleParkSystemBest.Implementations.Services
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly IVehicleParkProvider _vehicleParkProvider;
        
        public CommandExecutor(IVehicleParkProvider vehicleParkProvider)
        {
            _vehicleParkProvider = vehicleParkProvider;
        }

        public string[] Execute(ICommand command)
        {
            if (command.Name != "SetupPark" && !_vehicleParkProvider.VehicleParkCreated)
            {
                return new[] { "The vehicle park has not been set up" };
            }

            if (command.Name == "SetupPark")
            {
                _vehicleParkProvider.VehicleParkCreated = true;
            }

            var currentVehiclePark = _vehicleParkProvider.Current();
            var result = command.Execute(currentVehiclePark);
            return result;
        }
    }
}
