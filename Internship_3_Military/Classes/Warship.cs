using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Warship : Vehicle, ISwimmable
    {
        public Warship(Guid id, double weight, int averageSpeed, double fuelConsumption, int capacity, double totalFuelUsed) : base(id,
            weight, averageSpeed, fuelConsumption, capacity)
        {
            Capacity = 50;
            TotalFuelUsed = 200;
            TotalFuelUsed = totalFuelUsed;
        }

        public double TotalFuelUsed { get; set; }

        public bool Swim(int distance)
        {
            return true;
        }
    }
}
