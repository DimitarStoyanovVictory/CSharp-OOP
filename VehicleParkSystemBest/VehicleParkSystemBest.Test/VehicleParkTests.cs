namespace VehicleParkSystemBest.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Model;
    using Utilites;
    using Vehicles;
    using Xunit;
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    public class VehicleParkTests
    {
        [Fact]
        public void GetStatusWithVehicles()
        {
            // arange

            VehiclePark parkWithVehicles = new VehicleParkBuilder().WithInitialState(3, 5)
                .WithCar(null, 2, 5).WithMotorBike(null, 3, 4).WithTruck(null, 2, 3).Build();

            // act

            string[] resultWithVehicles = parkWithVehicles.GetStatus();


            //assert

            CollectionAssert.AreEqual(Outputs.GetStatusWithVehicles, resultWithVehicles);
        }

        [Fact]
        public void GetStatusWithNoVehicles()
        {
            // arrange 

            VehiclePark parkWithNoVehicles = new VehicleParkBuilder().WithInitialState(3, 5).Build();

            // act

            string[] resultWithNoVehicles = parkWithNoVehicles.GetStatus();
            
            // assert 

            CollectionAssert.AreEqual(Outputs.GetStatusWithNoVehicles, resultWithNoVehicles);


        }

        [Fact]
        public void InsertVehicleReturnsCorrectOutput()
        {
            // arrange

            VehiclePark park = new VehicleParkBuilder().WithInitialState(3, 5).Build();

            // act 

            string[] actualResult = park.InsertCar(new Car("CA1001HH", "Jay Margareta", 1), 1, 5,
                new DateTime(2015, 5, 4, 10, 30, 0));

            // assert
            CollectionAssert.AreEqual(Outputs.ParkCar, actualResult);
        }

        [Fact]
        public void InsertVehicleReturnsInvalidData()
        {
            // arrange

            VehicleParkBuilder park = new VehicleParkBuilder().WithInitialState(3, 5);

            // act

            string testSector = park.WithCar(null, 4).CarOutput[0];
            string testPlacesPerSector = park.WithMotorBike(null, 3, 6).MotorOutput[0];
            string testOcupiedPlace = park.WithTruck(null, 2, 3).WithCar(null, 2, 3).CarOutput[0];
            string testContainsLicensePlate = park.WithMotorBike(null, 1, 3).WithMotorBike(null, 3, 3).MotorOutput[0];
 
            // assert

            Assert.AreEqual("There is no sector 4 in the park", testSector);
            Assert.AreEqual("There is no place 6 in sector 3", testPlacesPerSector);
            Assert.AreEqual("The place (2,3) is occupied", testOcupiedPlace);
            Assert.AreEqual("There is already a vehicle with license plate CA5555AH in the park", testContainsLicensePlate);
        }

        [Fact]
        public void FindVehicleByLPReturnsCorrectOutput()
        {
            // arange

            VehiclePark park = new VehicleParkBuilder().WithInitialState(3, 5).WithCar(null, 1, 5).Build();

            // act

            string[] actualResult = park.FindVehicle("CA1001HH");

            // assert
            CollectionAssert.AreEqual(Outputs.FindVehicleByLP, actualResult);
        }

        [Fact]
        public void FindVehicleByLPRetunsInvalidData()
        {
            // arange

            VehiclePark park = new VehicleParkBuilder().WithInitialState(3, 5).WithCar(null, 1, 5).Build();

            // act

            string[] actualResult = park.FindVehicle("CA1011HH");

            // assert
            Assert.AreEqual(Outputs.InvalidLicensePlate, actualResult[0]);
        }

        [Fact]
        public void FindVehicleByOwnerReturnsCorrectOutput()
        {
            // arrange

            VehiclePark park = new VehicleParkBuilder().WithInitialState(3, 5)
                .WithCar(null, 1, 5).WithMotorBike(null, 2, 3).WithTruck(null, 3, 2).Build();

            // act

            string[] actualResult = park.FindVehiclesByOwner("Jay Margareta");

            // assert

            CollectionAssert.AreEqual(Outputs.FindVehicleByOwner, actualResult);
        }

        [Fact]
        public void FindVehicleByOwnerReturnsWrongOutput()
        {
            // arrange

            VehiclePark park = new VehicleParkBuilder().WithInitialState(3 , 5).Build();

            // act

            string[] actualResult = park.FindVehiclesByOwner("Jay Margareta");

            // assert

            Assert.AreEqual(Outputs.NoVehicleByOwner, actualResult[0]);
        }

        [Fact]
        public void ExitVehicleReturnsCorrectOutput()
        {
            // arrange 

            VehiclePark park = new VehicleParkBuilder().WithInitialState(3, 5).WithCar(null, 1, 5).Build();

            // act

            string[] actualResult = park.ExitVehicle("CA1001HH", new DateTime(2015, 05, 04, 13, 30, 0), 40);

            // assert

            CollectionAssert.AreEqual(Outputs.ExitCar, actualResult);
        }

        [Fact]
        public void ExitVehicleRturnsWrongOutput()
        {
            VehiclePark park = new VehicleParkBuilder().WithInitialState(3, 5).WithCar(null, 1, 5).Build();

            // act

            string[] actualResult = park.ExitVehicle("CA1011HH", new DateTime(2015, 05, 04, 13, 30, 0), 40);

            // assert

            Assert.AreEqual(Outputs.InvalidLicensePlate, actualResult[0]);
        }
    }
}
