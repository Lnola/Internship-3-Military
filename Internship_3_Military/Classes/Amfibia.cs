using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public Amfibia(Guid id, double weight, int averageSpeed, double fuelConsumption, int capacity, double totalFuelUsed) : base(id,
            weight, averageSpeed, fuelConsumption, capacity)
        {
            Capacity = 20;
            TotalFuelUsed = 70;
            TotalFuelUsed = totalFuelUsed;
        }

        public double TotalFuelUsed { get; set; }

        public bool Move(int distance)
        {
            return true;
        }

        public bool Swim(int distance)
        {
            return true;
        }
    }
}
