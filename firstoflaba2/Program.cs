using Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Enter a number of people: ");
            int m = int.Parse(Console.ReadLine());
            Person[] people = new Person[m];
            for (int i = 0; i < m; i++)
            {
                people[i] = new Person();
                people[i].Read();
            }
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(people[i].FirstName);
                Console.WriteLine(people[i].LastName);
                Console.WriteLine(people[i].Age(people[i].DateOfBirth));
                Console.WriteLine(people[i].Gender);
            }

        }
    }
}
