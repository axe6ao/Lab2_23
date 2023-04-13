using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо список студентів
        List<Student> students = new List<Student>
        {
            new Student { Name = "Володимир", Grade = 90 },
            new Student { Name = "Євген", Grade = 80 },
            new Student { Name = "Віктор", Grade = 70 },
            new Student { Name = "Вероніка", Grade = 85 }
        };

        // Відфільтровуємо студентів з оцінками більше 80
        var filteredStudents = students.Where(s => s.Grade > 80);

        // Виводимо імена відфільтрованих студентів
        foreach (var student in filteredStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}