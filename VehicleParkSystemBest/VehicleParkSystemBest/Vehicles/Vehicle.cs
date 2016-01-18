using System;
using System.Text;
using System.Text.RegularExpressions;
using VehicleParkSystemBest.Interfaces;

namespace VehicleParkSystemBest.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private string _licensePlate;
        private string _owner;
        private decimal _regularRate;
        private decimal _overtime;
        private int _hours;

        public Vehicle(string licensePlate, string owner, decimal regularRate, decimal overTime, int hours)
        {
            _licensePlate = licensePlate;
            _owner = owner;
            _regularRate = regularRate;
            _overtime = overTime;
            _hours = hours;
        }

        public string LicensePlate
        {
            get
            {
                return _licensePlate;
            }

            protected set
            {
                if (!Regex.IsMatch(value, @"^[A-Z]{1}\d{3}[A-Z]{2,}$"))
                {
                    throw new ArgumentException("The license plate number is invalid.");
                }

                _licensePlate = value;
            }
        }

        public string Owner
        {
            get
            {
                return _owner;
            }

            protected set
            {
                if (value == null && value == "")
                {
                    throw new InvalidCastException("The owner is required.");
                }

                _owner = value;
            }
        }

        public decimal RegularRate
        {
            get
            {
                return _regularRate;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new InvalidTimeZoneException(string.Format("The regular rate must be non-negative."));
                }

                _regularRate = value;
            }
        }

        public decimal OvertimeRate
        {
            get
            {
                return _overtime;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("The overtime rate must be non-negative."));
                }

                _overtime = value;
            }
        }

        public int ReservedHours
        {
            get
            {
                return _hours;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The reserved hours must be positive.");
                }

                _hours = value;
            }
        }

        public override string ToString()
        {
            var vehicle = new StringBuilder();
            vehicle.AppendFormat("{0} [{1}], owned by {2}", GetType().Name, LicensePlate, Owner);
            return vehicle.ToString();
        }
    }
}
