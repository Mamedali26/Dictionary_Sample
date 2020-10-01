using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Student
    {
        public string LastName { get; set; }
        public string Course { get; set; }
        public int StudentBook { get; set; }

        public string UpLastName;
        public string UpCourse;

        public Student(string lastName, string course, int id)
        {
            LastName = lastName;
            Course = course;
            StudentBook = id;
            UpLastName = LastName[0].ToString().ToUpper() + LastName.Substring(1);
            UpCourse = Course[0].ToString().ToUpper() + Course.Substring(1);
        }

        public void Print()
        {
            Console.WriteLine($"Студент {UpLastName} изучает {UpCourse} и номер зачетной книжки равен {StudentBook}.");
        }

    }
}
