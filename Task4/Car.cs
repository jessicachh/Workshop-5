using System;

namespace AbstractVehicleDemo
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine is starting...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine is stopping...");
        }
    }
}