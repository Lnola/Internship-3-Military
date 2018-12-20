using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_3_Military
{
    class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public Amfibia(double weight, int averageSpeed) : base(
            weight, averageSpeed)
        {
            Capacity = 20;
            TotalFuelUsed = 70;
        }

        public double TotalFuelUsed { get; set; }

        public override void VehiclePrint()
        {
            base.VehiclePrint();
            Console.WriteLine(TotalFuelUsed);
        }

        public void Move(int distance,int number)
        {
        }

        public void Swim(int distance,int numberOfSoldiers)
        {
        }
    }
}
