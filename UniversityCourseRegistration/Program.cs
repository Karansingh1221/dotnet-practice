using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            // UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch(choice){
                        case 1:
                            Console.WriteLine("Enter Code: ");
                            string c=Console.ReadLine();
                            Console.WriteLine("Enter Name: ");
                            string n=Console.ReadLine();
                            Console.WriteLine("Enter Credits: ");
                            int cre=int.Parse(Console.ReadLine());
                            UniversitySystemClass.AddCourse(c,n,cre);
                            break;
                        case 2:
                            Console.WriteLine("Enter Id: ");
                            string id=Console.ReadLine();
                            Console.WriteLine("Enter Name: ");
                            string name=Console.ReadLine();
                            Console.WriteLine("Enter Major: ");
                            string major=Console.ReadLine();
                            UniversitySystemClass.AddStudent(id,name,major);
                            break;
                        case 3:
                            Console.WriteLine("Enter Student Id: ");
                            string sid=Console.ReadLine();
                            Console.WriteLine("Enter Course Id: ");
                            string cid=Console.ReadLine();
                            UniversitySystemClass.RegisterStudentForCourse(sid,cid);
                            break;
                        case 4:
                            Console.WriteLine("Enter Student Id: ");
                            string stid=Console.ReadLine();
                            Console.WriteLine("Enter Course Id: ");
                            string coid=Console.ReadLine();
                            UniversitySystemClass.DropStudentFromCourse(stid,coid);
                            break;
                        case 5:
                            UniversitySystemClass.DisplayAllCourses();
                            break;
                        case 6:
                            Console.WriteLine("Enter Course Id: ");
                            string couid=Console.ReadLine();
                            UniversitySystemClass.DisplayStudentSchedule(couid);
                            break;
                        case 7:
                            UniversitySystemClass.DisplaySystemSummary();
                            break;
                        case 8:
                            exit=true;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

