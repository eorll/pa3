using System;
using PA___3.Enums;
using PA___3.People;
using PA___3.People.Students;

namespace PA___3
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = School.School.GetInstance(); 
            
            var mentor1 = new Mentor("Ben", DateTime.Today, "100-101-102", 9000);
            mentor1.SetLanguageKnowledge(true, true, false, false);
            
            var mentor2 = new Mentor("Bob", DateTime.Today, "100-101-103", 5000);
            mentor2.SetLanguageKnowledge(false, false, true, true);

            var salesPerson = new SalesPerson("July", DateTime.Today, "100-101-103", 15000);
            
            school.HireMentor(mentor1);
            school.HireMentor(mentor2);
            school.HireSalesPerson(salesPerson);

            var student1 = new Student("Robert", DateTime.Today, "123-123-123", Module.OOP);
            var student2 = new Student("Jack", DateTime.Today, "123-023-123", Module.Basics);
            
            school.AddStudent(student1);
            school.AddStudent(student2);
            
            mentor1.SetTeachingModule(Module.Advanced); // false
            mentor2.SetTeachingModule(Module.Advanced); // true
            Console.WriteLine(mentor1.ToString());
            Console.WriteLine(mentor2.ToString());
            
            student1.AddProgressPoints(100);
            Console.WriteLine(student1.ToString());

            foreach (var student in school.GetStudentsFromModule(Module.Basics))
            {
                Console.WriteLine(student.ToString());
            }

        }

      
    }
}