using System;

namespace PA___3.People
{
    public abstract class Human
    {
        public string Name;
        public DateTime BirthDay;
        public string PhoneNumber;

        protected Human(string name, DateTime birthDay, string phoneNumber)
        {
            Name = name;
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;
        }
    }
}