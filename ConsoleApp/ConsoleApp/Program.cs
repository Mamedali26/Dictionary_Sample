using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(1, new Student("Gasimov", "Mathematics", 4219));
            students.Add(2, new Student("Alizade", "Physics", 4005));
            students.Add(3, new Student("Huseynov", "History", 2683));

            students[4] = new Student("Balayev", "Chemistry", 1901);
            students[5] = new Student("Azizov", "Literature", 3654);
            students[6] = new Student("Maharramov", "Computer Science", 4219);            

            foreach(KeyValuePair<int, Student> p in students)
            {
                Console.Write($"{p.Key} - ");
                p.Value.Print();
            }

            Console.WriteLine($"Количество студентов: {students.Count}.");
            Console.WriteLine("----------------------------------------\n");
            students.Remove(6);
            students.Remove(5);
            foreach (KeyValuePair<int, Student> p in students)
            {
                Console.Write($"{p.Key} - ");
                p.Value.Print();
            }

            Console.WriteLine($"Количество студентов после удаления нескольких студентов: {students.Count}.");
            Console.WriteLine("----------------------------------------\n");

            if (students.ContainsKey(4))
                students[4].Print();
            else Console.WriteLine("Список не содержит студента с номером 4!");
            Console.WriteLine("----------------------------------------\n");

            students.Clear();
            Console.WriteLine($"Количество студентов после очистки списка: {students.Count}. Список пуст...");
            Console.WriteLine("----------------------------------------\n");
            Console.ReadKey();
        }
    }
}
