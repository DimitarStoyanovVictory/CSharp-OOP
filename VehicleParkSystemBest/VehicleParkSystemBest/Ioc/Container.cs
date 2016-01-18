using System;
using System.Reflection;
using Ninject;

namespace VehicleParkSystemBest.Ioc
{
    public static class Container
    {
        private static IKernel _kernel;
        private static object _padlock = new Object();

        private static void Setup()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static IKernel Instance()
        {
            lock (_padlock)
            {
                if (_kernel == null)
                {
                    Setup();
                }
            }
            return _kernel;
        }
    }
}
