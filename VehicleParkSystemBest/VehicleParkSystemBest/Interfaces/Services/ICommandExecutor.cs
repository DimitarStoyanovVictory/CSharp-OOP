namespace VehicleParkSystemBest.Interfaces.Services
{
    /// <summary>
    /// Takes command and returns result array
    /// </summary>
    public interface ICommandExecutor
    {
        string[] Execute(ICommand command);
    }
}