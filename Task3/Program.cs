using System;

namespace MethodOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Print("Hello World");
            printer.Print(1234);
            printer.Print("Printing multiple times!", 3);

            Console.ReadLine();
        }
    }
}