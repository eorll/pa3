using System;
using PA___3.Enums;
using PA___3.People.Employees;

namespace PA___3.People
{
    public class Mentor: Employee
    {
        public bool KnowPython;
        public bool KnowWeb;
        public bool KnowJavaSE;
        public bool KnowJavaEE;

        public Module TeachingModule;
        
        public Mentor(string name, DateTime birthDay, string phoneNumber, int salary) : base(name, birthDay, phoneNumber, salary)
        {
        }

        public void SetLanguageKnowledge(bool python, bool web, bool javaSE, bool javaEE)
        {
            KnowPython = python;
            KnowWeb = web;
            KnowJavaSE = javaSE;
            KnowJavaEE = javaEE;
        }

        public void SetTeachingModule(Module module)
        {
            if (CheckIfMentorKnowLang(module))
            {
                TeachingModule = module;   
            }
            else
            {
                Console.WriteLine($"Mentor {Name} can't teach module {module.ToString()}!");
            }
        }

        private bool CheckIfMentorKnowLang(Module module)
        {
            return module switch
            {
                Module.Basics => KnowPython,
                Module.Web => KnowWeb,
                Module.OOP => KnowJavaSE,
                Module.Advanced => KnowJavaEE,
                _ => throw new ArgumentOutOfRangeException(nameof(module), module, "Out of range!")
            };
        }

        public override string ToString()
        {
            return $"Mentor {Name} - Teaching Module : {TeachingModule}";
        }
    }
}