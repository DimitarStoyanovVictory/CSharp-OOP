using System.Globalization;
using System.Reflection;
using System.Threading;
using Ninject;
using VehicleParkSystemBest.Interfaces.Services;

namespace VehicleParkSystemBest
{
    public class ProgramStart
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var commandTerminal = kernel.Get<IParkingTerminal>();
            commandTerminal.Run();
        }
    }
}