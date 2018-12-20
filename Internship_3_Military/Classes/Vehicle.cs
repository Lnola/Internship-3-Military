using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    abstract class Vehicle
    {
        protected Vehicle(Guid id, double weight, int averageSpeed, double fuelConsumption, int capacity)
        {
            Id = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
        }

        public Guid Id { get; set; }
        public double Weight { get; set; }
        public int AverageSpeed { get; set; }
        public double FuelConsumption { get; set; }
        public double Capacity { get; set; }

        public virtual void VehiclePrint()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Weight);
            Console.WriteLine(AverageSpeed);
            Console.WriteLine(FuelConsumption);
            Console.WriteLine(Capacity);
        }
    }
}
