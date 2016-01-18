using Ninject.Modules;
using VehicleParkSystemBest.Implementations.Services;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Interfaces.Services;
using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Ioc
{
    public class VehicleParkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommandExecutor>().To<CommandExecutor>();
            Bind<ICommandExtractor>().To<CommandExtractor>();
            Bind<IUserTerminal>().To<UserTerminal>();
            Bind<IVehiclePark>().To<VehiclePark>();
            Bind<IParkingTerminal>().To<ParkingTerminal>();
            Bind<IVehicleParkProvider>().To<VehicleParkProvider>();
        }
    }
}
