using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public Amfibia(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
        }

        public double TotalFuelUsed { get; set; }

        public override void VehiclePrint()
        {
            Console.WriteLine("---Amfibia---\n");
            base.VehiclePrint();
            Console.WriteLine("Total Fuel Used: " + TotalFuelUsed);
        }

        public void Move(int distance, int numberOfSoldiers)
        {
            distance = TotalDistance(distance, numberOfSoldiers);

            var random = new Random();
            var distanceAfterObstacles = distance;

            for (var i = 10; i < distance; i += 10)
            {
                var randomNumber = random.Next(1, 101);
                if (randomNumber <= 30)
                    distanceAfterObstacles += 10;
            }

            TotalFuelUsed += distanceAfterObstacles * FuelConsumption;

            Console.WriteLine("\nTotal Amfibia land distance after obstacles: " + distanceAfterObstacles);
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

            TotalFuelUsed += distanceAfterObstacles * FuelConsumption;

            Console.WriteLine("\nTotal Amfibia water distance after obstacles: " + distanceAfterObstacles);
            Console.WriteLine();
        }
    }
}
