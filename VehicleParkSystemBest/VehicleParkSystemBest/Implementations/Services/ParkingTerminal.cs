using System;
using VehicleParkSystemBest.Interfaces.Services;

namespace VehicleParkSystemBest.Implementations.Services
{
    internal class ParkingTerminal : IParkingTerminal
    {
        private readonly IUserTerminal _userTerminal;
        private readonly ICommandExtractor _commandExtractor;
        private readonly ICommandExecutor _commandExecutor;

        public ParkingTerminal(
                   IUserTerminal userTerminal,
                   ICommandExtractor commandExtractor,
                   ICommandExecutor commandExecutor)
        {
            _userTerminal = userTerminal;
            _commandExtractor = commandExtractor;
            _commandExecutor = commandExecutor;
        }

        public void Run()
        {
            while (true)
            {
                string commandAsString = _userTerminal.ReadLine();

                if (commandAsString == null)
                {
                    throw new InvalidOperationException("Invalid command");
                }

                if (commandAsString == "")
                {
                    continue;
                }

                var command = _commandExtractor.ExtractFromCommandString(commandAsString);

                var commandResult = _commandExecutor.Execute(command);

                foreach (var resultRow in commandResult)
                {
                    _userTerminal.WriteLine(resultRow);   
                }
            }
        }
    }
}