using System;

namespace VehiclesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Brand = "Toyota",
                Speed = 180,
                Seats = 5
            };

            Motorcycle moto = new Motorcycle
            {
                Brand = "Yamaha",
                Speed = 220,
                Type = "Sport"
            };

            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            moto.Start();
            moto.DisplayInfo();
            moto.Stop();
        }
    }
}