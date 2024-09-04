using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.Ulesanded.OOPStudent
{
    internal class MainClass
    {
        public static void Main()
        {
            var university = new University();

            // Ввод информации о студентах
            Console.WriteLine("Sisestage õpilaste arv:");
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Sisestage andmed õpilase kohta { i + 1}:");
                Console.Write("Nimi: ");
                string name = Console.ReadLine();
                Console.Write("Student ID: ");
                string studentID = Console.ReadLine();
                var student = new Student { Name = name, StudentID = studentID };
                university.AddStudent(student);
            }

            // Ввод информации о курсах
            Console.WriteLine("Sisestage kursuste arv:");
            int courseCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine($"Sisestage kursuse andmed {i + 1}:");
                Console.Write("Kursuse nimi: ");
                string courseName = Console.ReadLine();
                Console.Write("Course ID: ");
                string courseID = Console.ReadLine();
                var course = new Course { CourseName = courseName, CourseID = courseID };
                university.AddCourse(course);
            }

            // Запись студентов на курсы
            Console.WriteLine("Sisestage registreerimiste arv:");
            int enrollmentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enrollmentCount; i++)
            {
                Console.WriteLine($"Sisestage andmed registreerimiseks { i + 1}:");
                Console.Write("Student ID: ");
                string studentID = Console.ReadLine();
                Console.Write("Course ID: ");
                string courseID = Console.ReadLine();
                university.EnrollStudentInCourse(studentID, courseID);
            }

            // Вывод информации о студентах и курсах
            university.PrintStudentInfo();
            university.PrintCourseInfo();

            // Исключение студента из курса
            Console.WriteLine("Sisestage registreerimata jäänud isikute arv:");
            int unenrollmentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < unenrollmentCount; i++)
            {
                Console.WriteLine($"Sisestage andmed registreeringu tühistamiseks { i + 1}:");
                Console.Write("Student ID: ");
                string studentID = Console.ReadLine();
                Console.Write("Course ID: ");
                string courseID = Console.ReadLine();
                university.UnenrollStudentFromCourse(studentID, courseID);
            }

            // Вывод информации о студентах и курсах после исключения
            university.PrintStudentInfo();
            university.PrintCourseInfo();
        }
    }
}
