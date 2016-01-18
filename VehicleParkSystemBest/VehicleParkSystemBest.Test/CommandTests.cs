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
    public class CommandTests
    {
        private ICommandExtractor _extractor;
        private ICommandParameters _result = null;
        private ICommandExecutor _execute;
        private IVehicleParkProvider _vehicleParkProvider;

        public CommandTests()
        {
            _extractor = new CommandExtractor();
            _execute = new CommandExecutor(new VehicleParkProvider());
        }

        [Theory]
        [InlineData("")]
        public void NullOrEmptyInputThrowsException(string commandAsString)
        {
            // Arrange
            Exception expectedResult = null;

            // Act 
            try
            {
                _result = _extractor.ExtractFromCommandString(commandAsString);
            }
            catch (ArgumentException exception)
            {
                expectedResult = exception;
            }

            // Assert
            Assert.IsInstanceOfType(expectedResult, typeof(ArgumentException));
        }

        [Fact]
        public void SetupParkReturnsParkComand()
        {
            // arrange

            // act
            _result = _extractor.ExtractFromCommandString(Inputs.CreateDefaultPark);

            // assert
            Assert.IsInstanceOfType(_result, typeof(ICommand));
            Assert.AreEqual("SetupPark", _result.Name);
            Assert.AreEqual(3.ToString(), _result.Parameters["sectors"]);
            Assert.AreEqual(5.ToString(), _result.Parameters["placesPerSector"]);
        }

        [Theory]
        [InlineData("Status")]
        public void StatusThrowsArgumentExeption(string commandAsString)
        {
            // arrange
            Exception expectedExeption = null;

            // act
            try
            {
                _result = _extractor.ExtractFromCommandString(commandAsString);
            }
            catch (ArgumentException exeption)
            {
                expectedExeption = exeption;
            }
            
            // assert
            Assert.IsInstanceOfType(expectedExeption, typeof(ArgumentException));
        }

        [Theory]
        [InlineData("Status {}")]
        public void StatusReturnStatusCommand(string commandAsString)
        {
            //arange

            //act 

            _result = _extractor.ExtractFromCommandString(commandAsString);
            //assert

            Assert.IsInstanceOfType(_result, typeof(ICommand));
            Assert.AreEqual("Status", _result.Name);
            Assert.AreEqual(0, _result.Parameters.Count);
        }
    }
}
