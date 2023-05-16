using System;

namespace ConsoleApp6
{
    class Client
    {
        static void Main(string[] args)
        {
            DeanOffice deanOffice = new DeanOffice();

            // Create departments
            Department mathDepartment = new Department("Mathematics");
            Department physicsDepartment = new Department("Physics");

            // Register departments as observers
            deanOffice.RegisterObserver(mathDepartment);
            deanOffice.RegisterObserver(physicsDepartment);

            Instructor mathInstructor = new Instructor("John1" , "Mathematics");
            Instructor physicsInstructor = new Instructor("John2", "Physics");
            // Register instructors as observers
            deanOffice.RegisterObserver(mathInstructor);
            deanOffice.RegisterObserver(physicsInstructor);

            // Simulate adding grades
            deanOffice.AddGrade("Mathematics", "A+");
            deanOffice.AddGrade("Physics", "B");

            Console.WriteLine("---------------");

            // Simulate missing grade from an instructor
            deanOffice.RemoveObserver(mathInstructor);
            deanOffice.AddGrade("Physics", "C");

            Console.WriteLine("---------------");

            // Simulate missing grade from a department
            deanOffice.RemoveObserver(physicsDepartment);
            deanOffice.AddGrade("Mathematics", "A");
            Console.WriteLine("Hello World!");
        }
    }
}
