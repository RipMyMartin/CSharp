using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.Ulesanded.OOPStudent
{
    public class Student
    {
        // Свойства студента
        public string Name { get; set; } // Имя студента
        public string StudentID { get; set; } // Уникальный идентификатор студента
        public List<string> Courses { get; set; } = new List<string>(); // Список идентификаторов курсов, на которые записан студент
    }

    public class Course
    {
        // Свойства курса
        public string CourseName { get; set; } // Название курса
        public string CourseID { get; set; } // Уникальный идентификатор курса
        public List<string> EnrolledStudents { get; set; } = new List<string>(); // Список идентификаторов студентов, записанных на курс
    }

    public class University
    {
        // Списки студентов и курсов
        public List<Student> Students { get; set; } = new List<Student>(); // Список студентов
        public List<Course> Courses { get; set; } = new List<Course>(); // Список курсов

        // Метод для добавления нового студента
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        // Метод для добавления нового курса
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        // Метод для записи студента на курс
        public void EnrollStudentInCourse(string studentID, string courseID)
        {
            // Поиск студента и курса по их идентификаторам
            var student = Students.FirstOrDefault(s => s.StudentID == studentID);
            var course = Courses.FirstOrDefault(c => c.CourseID == courseID);

            // Проверка существования студента и курса
            if (student == null || course == null)
            {
                Console.WriteLine("Student or Course not found.");
                return;
            }

            // Добавление курса студенту, если его там нет
            if (!student.Courses.Contains(courseID))
            {
                student.Courses.Add(courseID);
            }

            // Добавление студента в курс, если он там не зарегистрирован
            if (!course.EnrolledStudents.Contains(studentID))
            {
                course.EnrolledStudents.Add(studentID);
            }
        }

        // Метод для исключения студента из курса
        public void UnenrollStudentFromCourse(string studentID, string courseID)
        {
            // Поиск студента и курса по их идентификаторам
            var student = Students.FirstOrDefault(s => s.StudentID == studentID);
            var course = Courses.FirstOrDefault(c => c.CourseID == courseID);

            // Проверка существования студента и курса
            if (student == null || course == null)
            {
                Console.WriteLine("Student or Course not found.");
                return;
            }

            // Удаление курса из списка курсов студента
            student.Courses.Remove(courseID);

            // Удаление студента из списка студентов курса
            course.EnrolledStudents.Remove(studentID);
        }
        // Метод для вывода информации о студентах
        public void PrintStudentInfo()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Student Name: {student.Name}, ID: {student.StudentID}");
                Console.WriteLine("Courses:");
                foreach (var courseID in student.Courses)
                {
                    // Поиск курса по его идентификатору
                    var course = Courses.FirstOrDefault(c => c.CourseID == courseID);
                    Console.WriteLine($" - {course?.CourseName ?? "Unknown Course"}");
                }
                Console.WriteLine();
            }
        }

        // Метод для вывода информации о курсах
        public void PrintCourseInfo()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine($"Course Name: {course.CourseName}, ID: {course.CourseID}");
                Console.WriteLine("Enrolled Students:");
                foreach (var studentID in course.EnrolledStudents)
                {
                    // Поиск студента по его идентификатору
                    var student = Students.FirstOrDefault(s => s.StudentID == studentID);
                    Console.WriteLine($" - {student?.Name ?? "Unknown Student"}");
                }
                Console.WriteLine();
            }
        }
    }
}

