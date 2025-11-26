using System;

namespace AbstractVehicleDemo
{
    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine is starting...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine is stopping...");
        }
    }
}