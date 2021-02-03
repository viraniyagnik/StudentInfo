using System;
using System.Collections.Generic;

namespace Applied_Activity_1
{
    class Program
    {
        private class Student
        {
            
            public Student( string Name, int ID, string Gender, string Course, DateTime DateOfBirth, double Contact_number) 
            {
                Student_Name = Name;
                Student_ID = ID;
                Student_Gender = Gender;
                Student_DateOfBirth = DateOfBirth;
                Student_Course = Course;
                Student_Contact_number = Contact_number;
            }
            public string Student_Name { get; set; }
            public int Student_ID { get; set; }
            public string Student_Gender { get; set; }
            public string Student_Course { get; set; }
            public DateTime Student_DateOfBirth { get; set; }
            public double Student_Contact_number { get; set; }
            
        }
        static void Main(string[] args)
        {
            //Student list
            var Students = new List<Student>();

            while (true)
            {
                //Application related information
                Console.Clear();
                Console.WriteLine("Student Information database!\n");
                Console.WriteLine("This application is to store all students information in Student class.\nStuden Name(String), Student ID(Integer), Gender(String), Course(String), Date of Birth(Date) and Contact Number(Long)");
                Console.WriteLine("This application is show the menu to what you would like to do:");
                Console.WriteLine("Add new student details, show students list and close the program.\n\n");

                //menu options
                Console.WriteLine("Select the option what you would like to do:");
                Console.WriteLine("1. Add new Student.");
                Console.WriteLine("2. All students list.");
                Console.WriteLine("3. Exit.");

                //take user choice
                int.TryParse(Console.ReadLine(), out var choice);

                //To add new student
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Add a new student:\n");

                    Console.Write("Enter student name :");
                    string Name = Console.ReadLine();

                    Console.Write("Enter student ID :");
                    int ID = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter student Gender :");
                    string Gender = Console.ReadLine();

                    Console.Write("Enter student Birthdate :");
                    DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Enter student Course :");
                    string Course = Console.ReadLine();

                    Console.Write("Enter student contact number :");
                    long Contact_number = Convert.ToInt64(Console.ReadLine());
                    
                    Students.Add(new Student(Name, ID, Gender, Course, DateOfBirth, Contact_number));
                    
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadLine();
                }
                //To show all entered students list
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("All students list:\n");

                    if(Students.Count > 0)
                    {
                        foreach (var Student in Students)
                        {

                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine(value: $"Student name: {Student.Student_Name}");
                            Console.WriteLine(value: $"Student ID: {Student.Student_ID}");
                            Console.WriteLine(value: $"Student gender: {Student.Student_Gender}");
                            Console.WriteLine(value: $"Student course: {Student.Student_Course}");
                            Console.WriteLine(value: $"Student date of birth: {Student.Student_DateOfBirth}");
                            Console.WriteLine(value: $"Student contact number: {Student.Student_Contact_number}");
                        }
                    }

                    Console.WriteLine("Press any key to continue..");
                    Console.ReadLine();
                }
                //To exit program
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n invalid selection please select valid option.\n");
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadLine();
                }
            }
        }
    }
}
