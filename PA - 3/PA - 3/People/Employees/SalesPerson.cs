using System;
using PA___3.People.Employees;

namespace PA___3.People
{
    public class SalesPerson: Employee
    {
        public SalesPerson(string name, DateTime birthDay, string phoneNumber, int salary) : base(name, birthDay, phoneNumber, salary)
        {
        }
    }
}