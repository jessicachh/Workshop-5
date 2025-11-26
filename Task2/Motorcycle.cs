using System;

namespace VehiclesDemo
{
    public class Motorcycle : Vehicle
    {
        public string Type { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Motorcycle Info -----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Type: {Type}");
        }
    }
}