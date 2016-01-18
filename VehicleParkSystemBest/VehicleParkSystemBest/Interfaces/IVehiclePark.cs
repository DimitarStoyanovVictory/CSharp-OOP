using System;
using VehicleParkSystemBest.Vehicles;

namespace VehicleParkSystemBest.Interfaces
{
    interface IVehiclePark
    {
        /// <summary>
        /// Insert a car in the Park
        /// </summary>
        /// <param name="car">shows the type of the vehicle</param>
        /// <param name="sector">this parapmeter tells in wihch section the car is suited</param>
        /// <param name="place">this parameter tells in which place in the section the car is putted</param>
        /// <param name="time">this parameter thels what thime car has staied in the park</param>
        /// <returns>the infomation where the car has been places, in which section and in which place </returns>
        string[] InsertCar(Car car, int sector, int place, DateTime time);

        /// <summary>
        /// Insert a motorbike in the Park
        /// </summary>
        /// <param name="motorbike">shows the type of the vehicle</param>
        /// <param name="sector">this parapmeter tells in wihch section the motorbike is suited</param>
        /// <param name="place">this parameter tells in which place in the section the motorbike is putted</param>
        /// <param name="time">this parameter thels what time motorbike has staied in the park</param>
        /// <returns>returns the infomation where the truck has been places, in which section and in which place </returns>
        string[] InsertMotorbike(Motorbike motorbike, int sector, int place, DateTime time);

        /// <summary>
        /// Insert a truck in the Park
        /// </summary>
        /// <param name="truck">shows the type of the vehicle</param>
        /// <param name="sector">this parapmeter tells in wihch section the motorbike is suited</param>
        /// <param name="place">this parameter tells in which place in the section the truck is putted</param>
        /// <param name="time">this parameter thels what time truck has staied in the park</param>
        /// <returns>returns the infomation where the truck has been places, in which section and in which place </returns>
        string[] InsertTruck(Truck truck, int sector, int place, DateTime time);

        /// <summary>
        /// take the car out of the park
        /// </summary>
        /// <param name="licencePlate">this is the id of the vehicle</param>
        /// <param name="endTime">the end time of the vehice in the park</param>
        /// <param name="amountPaid">the money paid for the time spent there</param>
        /// <returns>returns the info of the time, place, section, cost for the time spent in park, rate and over time </returns>
        string[] ExitVehicle(string licencePlate, DateTime endTime, decimal amountPaid);

        /// <summary>
        /// get the status of the park
        /// </summary>
        /// <returns>returns the info of all vechicles</returns>
        string[] GetStatus();

        /// <summary>
        /// find the vechile in the park
        /// </summary>
        /// <param name="licensePlate">this is the id which helps to find the vehicle</param>
        /// <returns>owner, section and place of the current vehicle</returns>
        string[] FindVehicle(string licensePlate);

        /// <summary>
        /// gets the wonder of the car
        /// </summary>
        /// <param name="owner">this is the owners name</param>
        /// <returns>the same as FindVehicle function</returns>
        string[] FindVehiclesByOwner(string owner);
    }
}
