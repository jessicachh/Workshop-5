using System;

namespace DemoProject
{
    public class Teacher
    {
        public string Name { get; set; }

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        public void SalaryInfo()
        {
            Console.WriteLine("Salary information is confidential.");
        }
    }

    public class NepaliTeacher : Teacher
    {
        public override void Teaching()
        {
            Console.WriteLine("Nepali Teacher teaches in Nepali");
        }
    }

    public class EnglishTeacher : Teacher
    {
        // Uses the base Teaching() method
    }
}