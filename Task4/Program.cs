using System;
using DemoProject;

class Program
{
    static void Main(string[] args)
    {
        // PRINTER DEMO
        Console.WriteLine("=== Printer Demo ===");
        Printer printer = new Printer();
        printer.Print("Hello World");
        printer.Print(123);
        printer.Print("Repeated Message", 3);


        // TEACHER DEMO
        Console.WriteLine("\n=== Teacher Demo ===");

        NepaliTeacher nepTeacher = new NepaliTeacher();
        nepTeacher.Name = "Ram";
        Console.WriteLine("Nepali Teacher Name: " + nepTeacher.Name);
        nepTeacher.Teaching();
        nepTeacher.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher engTeacher = new EnglishTeacher();
        engTeacher.Name = "John";
        Console.WriteLine("English Teacher Name: " + engTeacher.Name);
        engTeacher.Teaching(); // uses base implementation
        engTeacher.SalaryInfo();
    }
}