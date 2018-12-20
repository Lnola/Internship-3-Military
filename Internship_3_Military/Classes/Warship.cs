using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Warship : Vehicle, ISwimmable
    {
        public Warship(double weight, int averageSpeed) : base(
            weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public int TotalFuelUsed { get; set; }

        public override void VehiclePrint()
        {
            base.VehiclePrint();
            Console.WriteLine(TotalFuelUsed);
        }

        public void Swim(int distance,int numberOfSoldiers)
        {
            distance = TotalDistance(distance, numberOfSoldiers);

            var random = new Random();
            var distanceAfterObstacles = distance;


        }
    }
}
