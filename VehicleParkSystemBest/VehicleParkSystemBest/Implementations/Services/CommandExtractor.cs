using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Interfaces.Services;

namespace VehicleParkSystemBest.Implementations.Services
{
    public class CommandExtractor : ICommandExtractor
    {
        public ICommand ExtractFromCommandString(string commandString)
        {
            if (string.IsNullOrEmpty(commandString) || string.IsNullOrWhiteSpace(commandString))
            {
                throw new ArgumentException("Command was null.");
            }

            var commandName = commandString.Substring(0, commandString.IndexOf(' '));

            var paramsJsonString = commandString.Substring(commandString.IndexOf("{"));
            Dictionary<string, string> commandParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(paramsJsonString);

            // command type
            var commandType = Assembly.GetExecutingAssembly().ExportedTypes.FirstOrDefault(x => x.Name.Contains(commandName + "Command"));
            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            commandType.GetProperty("Name").SetValue(command, commandName);
            commandType.GetProperty("Parameters").SetValue(command, commandParameters);
          
            return command;
        }
    }
}