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

            var myTank=new Tank(200,20);
            myTank.Move(tankDistance,numberOfSoldiers);
            myTank.VehiclePrint();

            var myWarship=new Warship(200,20);
            myWarship.Swim(warshipDistance,numberOfSoldiers);
            myWarship.VehiclePrint();
        }
    }
}
