using System.Collections.Generic;

namespace VehicleParkSystemBest.Interfaces
{
    public interface ICommandParameters
    {
        string Name { get; }

        IDictionary<string, string> Parameters { get; }
    }
}