using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Warship : Vehicle, ISwimmable
    {
        public Warship(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
        }

        public int TotalFuelUsed { get; set; }

        public override void VehiclePrint()
        {
            base.VehiclePrint();
            Console.WriteLine("Total Fuel Used: " + TotalFuelUsed);
        }

        public void Swim(int distance, int numberOfSoldiers)
        {
            distance = TotalDistance(distance, numberOfSoldiers);

            var random = new Random();
            var distanceAfterObstacles = distance;

            var time = (distance / AverageSpeed) * 60;

            for (var i = 10; i < time; i += 10)
            {
                var randomNumber = random.Next(1, 101);
                if (randomNumber <= 50)
                    distanceAfterObstacles += 6;
            }

            TotalFuelUsed = distanceAfterObstacles * FuelConsumption;

            Console.WriteLine("\nTotal distance after all obstacles: " + distanceAfterObstacles);
            Console.WriteLine();
        }
    }
}
