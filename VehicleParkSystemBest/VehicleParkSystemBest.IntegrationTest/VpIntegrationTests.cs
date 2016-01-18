using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleParkSystemBest.Implementations.Services;
using VehicleParkSystemBest.Interfaces;
using VehicleParkSystemBest.Interfaces.Services;
using VehicleParkSystemBest.Test.Utilites;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace VehicleParkSystemBest.Test
{
    public class VpIntegrationTests
    {
        private ICommandExtractor _commandExtractor;
        private ICommandParameters _commandParameters = null;
        private ICommandExecutor _commandExecutor = null;
        private IVehicleParkProvider _vehicleParkProvider = null;

        public VpIntegrationTests()
        {
            _commandExtractor = new CommandExtractor();
            _commandExecutor = new CommandExecutor(new VehicleParkProvider());
        }

        [Theory]
        [InlineData("SetupPark {\"sectors\": 3, \"placesPerSector\": 5}")]
        public void SetupCommandExecutesWithCorrectParameters(string commandString)
        {
            // arrange

            // act
            var command = _commandExtractor.ExtractFromCommandString(commandString);
            var commandResult = _commandExecutor.Execute(command);

            //assert
            Assert.AreEqual(commandResult[0], "Vehicle park created");
        }

        [Theory]
        [InlineData("SetupPark {\"sectors\": 0, \"placesPerSector\": 1}")]
        [InlineData("SetupPark {\"sectors\": 1, \"placesPerSector\": 0}")]
        public void SetupPark_Throws_Exception_With_Incorrect_Parameter_Values(string commandAsString)
        {
            // arrange
            Exception resultException = null;

            // act
            try
            {
                _commandParameters = _commandExtractor.ExtractFromCommandString(commandAsString);
            }
            catch (Exception exception)
            {
                resultException = exception.InnerException;
            }

            // assert
            Assert.IsInstanceOfType(resultException, typeof(ArgumentOutOfRangeException));
        }

        [Theory]
        [InlineData("SetupPark")]
        [InlineData("SetupPark { \"placesPerSector\": 0}")]
        [InlineData("SetupPark {\"sectors\": 1}")]
        public void SetupPark_Throws_Exception_When_Parameters_Are_Missing(string commandAsString)
        {
            // arrange
            Exception resultException = null;

            // act
            try
            {
                _commandParameters = _commandExtractor.ExtractFromCommandString(commandAsString);
            }
            catch (Exception exception)
            {
                if (exception.InnerException != null && exception.InnerException.GetType() == typeof(ArgumentException))
                {
                    resultException = exception.InnerException;
                }
                else
                {
                    resultException = exception;
                }
            }

            // assert
            Assert.IsInstanceOfType(resultException, typeof(ArgumentException));
        }

        [Theory]
        [InlineData("Status {}")]
        public void SetupParkReturnsNotSetVehiclePark(string commandAsString)
        {
            // arrange 

            ICommand command = _commandExtractor.ExtractFromCommandString(commandAsString);

            // act

            string[] actualResult = _commandExecutor.Execute(command);

            // assert

            Assert.AreEqual(Outputs.NoVehicleParkSet, actualResult[0]);
        }

        [Fact]
        public void VehicleParkFullIntegrationTest()
        {
            for (int inputIndex = 0, outputIndex = 0;
                 inputIndex < Inputs.IntegrationTestParams.Count;
                 inputIndex++, outputIndex++)
            {
                ICommand command = _commandExtractor.ExtractFromCommandString(Inputs.IntegrationTestParams[inputIndex]);
                string[] currentResult = _commandExecutor.Execute(command);
                string[] check = Outputs.IntegrationTestResults[outputIndex];

                CollectionAssert.AreEqual(Outputs.IntegrationTestResults[outputIndex], currentResult);
            }
        }
    }
}
