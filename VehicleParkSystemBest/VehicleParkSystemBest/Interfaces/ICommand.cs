using VehicleParkSystemBest.Model;

namespace VehicleParkSystemBest.Interfaces
{
    public interface ICommand : ICommandParameters
    {
        string[] Execute(VehiclePark vehiclePark);
    }
}
