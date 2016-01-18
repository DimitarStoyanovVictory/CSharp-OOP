using System;

namespace VehicleParkSystemBest.Model
{
    public class ParkLayout
    {
        private int _sectors;
        private int _placesPerSector;

        public ParkLayout(int numberOfSectors, int placesPerSector)
        {
            Sectors = numberOfSectors;
            PlacesPerSector = placesPerSector;
        }

        public int Sectors
        {
            get
            {
                return _sectors;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of sectors must be positive.");
                }

                _sectors = value;
            }
        }

        public int PlacesPerSector
        {
            get
            {
                return _placesPerSector;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of places per sector must be positive.");
                }

                _placesPerSector = value;
            }
        }
    }
}