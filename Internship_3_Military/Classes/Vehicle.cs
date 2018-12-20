using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    abstract class Vehicle
    {
        protected Vehicle(double weight, int averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public Guid Id { get; set; }
        public double Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        public int TotalDistance(int distance, int numberOfSoldiers)
        {
            var numberOfTripsAsDouble = (double)numberOfSoldiers / Capacity;
            var numberOfTrips = (int)Math.Ceiling(numberOfTripsAsDouble);

            var totalDistance = distance * (numberOfTrips * 2 - 1);

            return totalDistance;
        }

        public virtual void VehiclePrint()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Average Speed: " + AverageSpeed);
            Console.WriteLine("Fuel Consumption: " + FuelConsumption);
            Console.WriteLine("Capacity: " + Capacity);
        }
    }
}
