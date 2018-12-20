using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Tank : Vehicle, IDriveable
    {
        public Tank(double weight, int averageSpeed) : base(weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
        }

        public int TotalFuelUsed { get; set; }

        public override void VehiclePrint()
        {
            base.VehiclePrint();
            Console.WriteLine(TotalFuelUsed);
        }

        public void Move(int distance,int numberOfSoldiers)
        {
            distance = TotalDistance(distance, numberOfSoldiers);

            var random = new Random();
            var distanceAfterObstacles = distance;

            for (var i = 10; i < distance; i=i+10)
            {
                var randomNumber = random.Next(1, 101);
                if (randomNumber <= 30)
                    distanceAfterObstacles += 10;
            }

            TotalFuelUsed = distanceAfterObstacles * FuelConsumption;
        }
    }
}
