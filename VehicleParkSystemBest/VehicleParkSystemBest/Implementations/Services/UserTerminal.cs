using System;
using VehicleParkSystemBest.Interfaces.Services;

namespace VehicleParkSystemBest.Implementations.Services
{
    public class UserTerminal : IUserTerminal
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string format, params string[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}