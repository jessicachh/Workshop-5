using System;

namespace VehiclesDemo
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Car Info -----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}