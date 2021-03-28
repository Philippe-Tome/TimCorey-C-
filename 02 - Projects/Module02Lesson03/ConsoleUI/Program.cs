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
            //string firstName = "";

            //Console.Write("What is you first name: ");
            //firstName = Console.ReadLine();

            //Console.Write("What is your last name: ");
            //string lastName = Console.ReadLine();


            //if (firstName.ToLower() == "tom")
            //{
            //    Console.WriteLine("Welcome Mr. Tome");
            //}

            //if (firstName.ToLower() == "tom")
            //{
            //    Console.WriteLine("Hello Mr. Tome");
            //}
            //else
            //{
            //    Console.WriteLine("Hello other person.");
            //}

            //if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello Mr. Corey");
            //}
            //else if (firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine("Hi Mrs. Smith");
            //}
            //else
            //{
            //    Console.WriteLine("I don't know who you are!");
            //}

            //if (firstName.ToLower() == "tim" && lastName.ToLower() == "corey")
            //{
            //    Console.WriteLine("Hello professor");
            //}
            //else if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello other Tim");
            //}

            //if (firstName.ToLower() == "tim" || firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine($"Hello Professor { firstName }");
            //}
            //else
            //{
            //    Console.WriteLine("Hello students");
            //}

            //if ((firstName.ToLower() == "tim" && lastName.ToLower() == "corey") 
            //    || (firstName.ToLower() == "sue" && lastName.ToLower() == "storm"))
            //{
            //    Console.WriteLine($"Hello Professor { lastName }!!!");
            //}

            //if (firstName.ToLower() != "tim")
            //{

            //}

            //int age = 39;

            //if (age > 40)
            //{

            //}

            //if (age < 18)
            //{

            //}

            //if (age >= 21)
            //{

            //}

            //if (age <= 12)
            //{

            //}

            //switch (firstName.ToLower())
            //{
            //    case "tim":
            //        Console.WriteLine("Hello Professor");
            //        break;
            //    case "sue":
            //        Console.WriteLine("Hello Professor Storm");
            //        break;
            //    default:
            //        Console.WriteLine("Hello Student");
            //        break;
            //}

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            if (firstName.ToLower() == "tim")
            {
                Console.WriteLine($"Welcome Professor { firstName } { lastName }");
            }
            else
            {
                Console.WriteLine($"Welcome student { firstName } { lastName }!!!!!!!!!!!!!!!");
            }

            Console.ReadLine();

        }
    }
}
