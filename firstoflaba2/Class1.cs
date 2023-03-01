using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'm' | value == 'f') gender = value; }
        }
        public Person() { }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + DateOfBirth + " " + gender;
        }
        public void Read()
        {
            Console.WriteLine("Enter a name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter a surname");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter date of birth in (yyyy-mm-dd) format: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter sex(m/f): ");
            gender = char.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {FirstName} Фамилия: {LastName} Возраст: {Age(DateOfBirth)} Пол: {gender}");
        }
        public int Age(DateTime BDay)
        {
            int age = DateTime.Now.Year - BDay.Year;
            if (DateTime.Now.Day < BDay.Day)
            {
                if (DateTime.Now.Month < BDay.Month)
                {
                    age--;
                }
            }
            return age;
        }
    }
}