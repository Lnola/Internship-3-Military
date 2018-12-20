using System;

namespace Internship_3_Military
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi najkracu udaljenost za tenk: ");
            var tankDistance = int.Parse(Console.ReadLine());
            Console.Write("Unesi najkracu udaljenost za ratni brod: ");
            var warshipDistance = int.Parse(Console.ReadLine());
            Console.Write("Unesi kopnenu udaljenost za amfibiju: ");
            var amfibiaLandDistance = int.Parse(Console.ReadLine());
            Console.Write("Unesi vodenu udaljenost za amfibiju: ");
            var amfibiaWaterDistance = int.Parse(Console.ReadLine());

            Console.Write("\nUnesi broj vojnika za transport: ");
            var numberOfSoldiers = int.Parse(Console.ReadLine());

            var myTank = new Tank(200, 20);
            myTank.Move(tankDistance, numberOfSoldiers);
            myTank.VehiclePrint();

            var myWarship = new Warship(200, 20);
            myWarship.Swim(warshipDistance, numberOfSoldiers);
            myWarship.VehiclePrint();

            var myAmfibia = new Amfibia(200, 20);
            myAmfibia.Move(amfibiaLandDistance, numberOfSoldiers);
            myAmfibia.Swim(amfibiaWaterDistance, numberOfSoldiers);
            myAmfibia.VehiclePrint();

            Console.WriteLine("\n");
            var lowestFuelUsed = Math.Min(myTank.TotalFuelUsed, Math.Min(myAmfibia.TotalFuelUsed, myWarship.TotalFuelUsed));
            if (lowestFuelUsed == myTank.TotalFuelUsed)
                Console.WriteLine("Najefikasnije vozilo je Tenk s potrosnjom " + lowestFuelUsed + " L");
            else if (lowestFuelUsed == myWarship.TotalFuelUsed)
                Console.WriteLine("Najefikasnije vozilo je Ratni Brod s potrosnjom " + lowestFuelUsed + " L");
            else
                Console.WriteLine("Najefikasnije vozilo je Amfibija s potrosnjom " + lowestFuelUsed + " L");
        }
    }
}