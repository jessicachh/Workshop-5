using System;

namespace MethodOverloadingDemo
{
    public class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine("String message: " + message);
        }

        public void Print(int number)
        {
            Console.WriteLine("Integer number: " + number);
        }

        public void Print(string message, int count)
        {
            Console.WriteLine("Repeated message:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}