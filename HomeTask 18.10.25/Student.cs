using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_18._10._25
{
    public class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public double Grade;

        public static Student[] students = new Student[0];

        public static void CreateNewStudent()
        {
        restart:
            Console.Write("Studentin adını daxil edin: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Ad boş ola bilmez.");
                goto restart;
            }

            Console.Write("Studentin Soyadini daxil edin: ");
            string surname = Console.ReadLine();
            if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Surname boş ola bilmez.");
                goto restart;
            }

            Console.Write("Studentin Age ni daxil edin: ");

            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Yas Menfi Ola bilmez,Duzgun yas daxil edin");
                goto restart;
            }
            Console.Write("Studentin Grade ni daxil edin: ");
            if (!double.TryParse(Console.ReadLine(), out double grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Duzgun bal daxil edin (0-100 araliginda)");
                goto restart;
            }
            Student student = new Student(name, surname, age, grade);
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            Console.WriteLine("Yeni Student yaradildi");

        }
        public static void DeleteStudent()
        {
            if (students.Length != 0)
            {
                Console.WriteLine("Student Cedveli bosdur");
            }

            Console.WriteLine("Mövcud telebeler:");
            foreach (var s in students)
                Console.WriteLine(s);
            Console.WriteLine("Silmek istediyiniz telebenin adini daxil edin");
            string name = Console.ReadLine();
            var findstudent = students.FirstOrDefault(s => s.Name == name);
            students = students.Where(s => s.Name != name).ToArray();
            Console.WriteLine($"Telebe silindi: {findstudent.Name} ");
        }
        public static void PrintAllStudents()
        {
            if (students.Length == 0)
            {
                Console.WriteLine("Heç bir telebe yoxdur.");
                return;
            }

            Console.WriteLine("Bütün telebeler:");
            foreach (var item in students)
                Console.WriteLine($"Name: {item.Name},Surname: {item.Surname},Grade: {item.Grade}, Age: {item.Age}");
            Console.WriteLine();
        }




        public Student(string name, string surname, int age, double grade)
        {
            if (age > 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Age cannot be negative or zero");
            }
            if (grade >= 0 && grade <= 100)
            {
                Grade = grade;
            }
            else
            {
                Console.WriteLine("Duzgun bal daxil edin");
            }
            Name = name;
            if (surname.Length > 3)
            {
                Surname = surname;
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }
            public static void PrintFavStudents()
            {
                Student[] favStudents = new Student[0];
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].Grade >= 91)
                    {
                        Array.Resize(ref favStudents, favStudents.Length + 1);
                        favStudents[favStudents.Length - 1] = students[i];
                    }
                }
                if (favStudents.Length == 0)
                {
                    Console.WriteLine("Heç bir favorit telebe yoxdur.");
                    return;
                }
                Console.WriteLine("Favorit telebeler:");
                foreach (var item in favStudents)
                {
                    Console.WriteLine($"Name: {item.Name},Surname: {item.Surname},Grade: {item.Grade}, Age: {item.Age}");

                }
            }
        }


    }

