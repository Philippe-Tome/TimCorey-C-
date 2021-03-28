using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            Person person1 = new Person();

            Console.WriteLine("Enter a name: ");
            person1.First = Console.ReadLine();
            Console.WriteLine(person1.First);

            Console.WriteLine(Calculation.Add(4, 10));

            Console.ReadLine();
        }
    }
}
