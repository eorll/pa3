using System;
using PA___3.Enums;

namespace PA___3.People.Students
{
    public class Student: Human
    {
        public Module CurrentModule;
        private int Progress;
        
        public Student(string name, DateTime birthDay, string phoneNumber, Module currentModule) : base(name, birthDay, phoneNumber)
        {
            CurrentModule = currentModule;
            Progress = 0;
        }

        public void AddProgressPoints(int points)
        {
            if (points < 0)
            {
                Console.WriteLine("You can't add minus points!");
                return;
            }
            
            Progress += points;
            if (!IsModuleComplete()) return;
            Progress = 0;
            GetNextModule();
        }

        private bool IsModuleComplete() => Progress >= 100;

        private void GetNextModule()
        {
            switch (CurrentModule)
            {
                case Module.Basics:
                    CurrentModule = Module.Web;
                    break;
                case Module.Web:
                    CurrentModule = Module.OOP;
                    break;
                case Module.OOP:
                    CurrentModule = Module.Advanced;
                    break;
                case Module.Advanced:
                    CurrentModule = Module.OnJobHunt;
                    break;
                case Module.OnJobHunt:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"Student {Name} - Module : {CurrentModule}; Progress : {Progress}";
        }
    }
}