using System;

namespace AbstractVehicleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Car object
            Car car = new Car();
            Console.WriteLine("Car:");
            car.Display();          // Concrete method from abstract class
            car.StartEngine();      // Overridden abstract method
            car.StopEngine();       // Overridden abstract method

            Console.WriteLine();

            // Create Bike object
            Bike bike = new Bike();
            Console.WriteLine("Bike:");
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();

            Console.ReadLine();
        }
    }
}