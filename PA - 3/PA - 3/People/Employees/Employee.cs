using System;

namespace PA___3.People.Employees
{
    public abstract class Employee: Human
    {
        public int Salary;

        protected Employee(string name, DateTime birthDay, string phoneNumber, int salary) : base(name, birthDay, phoneNumber)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee {Name} - Salary: {Salary}";
        }
    }
}