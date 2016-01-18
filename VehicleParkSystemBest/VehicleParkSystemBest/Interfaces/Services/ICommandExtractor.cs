namespace VehicleParkSystemBest.Interfaces.Services
{
    public interface ICommandExtractor
    {
        ICommand ExtractFromCommandString(string commandString);
    }
}