using System;
using System.Collections.Generic;
using System.Linq;
using PA___3.Enums;
using PA___3.People;
using PA___3.People.Employees;
using PA___3.People.Students;

namespace PA___3.School
{
    public class School
    {
        private static School _instance;
        private readonly List<Student> _allStudents = new List<Student>();
        private readonly List<Employee> _allEmployees = new List<Employee>();

        private School()
        {
        }

        public static School GetInstance()
        {
            if (_instance == null)
            {
                _instance = new School();
            }

            return _instance;
        }

        public void HireMentor(Mentor mentor)
        {
            _allEmployees.Add(mentor);
        }

        public void HireSalesPerson(SalesPerson salesPerson)
        {
            _allEmployees.Add(salesPerson);
        }

        public void AddStudent(Student student)
        {
            _allStudents.Add(student);
        }

        public List<Student> GetStudentsFromModule(Module module)
        {
            return _allStudents.Where(student => student.CurrentModule == module).ToList();
        }
        
        
    }
}