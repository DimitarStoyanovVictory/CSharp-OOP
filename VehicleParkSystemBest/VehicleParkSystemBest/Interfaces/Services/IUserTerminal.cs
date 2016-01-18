namespace VehicleParkSystemBest.Interfaces.Services
{
    interface IUserTerminal
    {
        string ReadLine();

        void WriteLine(string format, params string[] args);
    }
}


