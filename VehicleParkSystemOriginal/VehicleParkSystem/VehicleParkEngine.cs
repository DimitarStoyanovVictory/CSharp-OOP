namespace VehicleParkSystem
{
    using System;
    using Execution;
    using Interfaces;
    using UserInterface;

    public class VehicleParkEngine : IEngine
    {
        private CommandExecutor commandExecutor;
        private IUserInterface userInterface;

        public VehicleParkEngine(CommandExecutor commandExecutor, IUserInterface userInterface)
        {
            this.commandExecutor = commandExecutor;
            this.userInterface = userInterface;
        }

        public VehicleParkEngine()
            : this(new CommandExecutor(), new ConsoleInterface())
        {
        }

        public void Run()
        {
            while (true)
            {
                string commandLine = this.userInterface.ReadLine();
                if (commandLine == null)
                {
                    break;
                }

                commandLine = commandLine.Trim();
                if (!string.IsNullOrEmpty(commandLine))
                {
                    try
                    {
                        var command = new Command(commandLine);
                        string commandResult = this.commandExecutor.ExecuteCommand(command);
                        this.userInterface.WriteLine(commandResult);
                    }
                    catch (Exception ex) 
                    {
                        this.userInterface.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
