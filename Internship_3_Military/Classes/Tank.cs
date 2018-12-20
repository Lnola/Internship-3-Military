using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Tank : Vehicle, IDriveable
    {
        public Tank(Guid id, double weight, int averageSpeed, double fuelConsumption, int capacity, double totalFuelUsed) : base(id,
            weight, averageSpeed, fuelConsumption, capacity)
        {
            Capacity = 6;
            TotalFuelUsed = 30;
            TotalFuelUsed = totalFuelUsed;
        }

        public double TotalFuelUsed { get; set; }

        public bool Move(int distance)
        {
            return true;
        }
    }
}
