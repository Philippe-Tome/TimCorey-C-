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

            //    SayAuthor();

            //    string firstName = GetUserName("What is your first name: ");
            //    string lastName = GetUserName("What is your last name: ");

            //    WelcomeUser(firstName, lastName);

            //    Console.ReadLine();

            Welcome();
            string fullName = GetUserFullName();
            Hello(fullName);

            Console.ReadLine();
        }

        //private static void SayAuthor() // private -> can only be called from this class Program
        //{
        //    Console.WriteLine("************************");
        //    Console.WriteLine("Written by Tim Corey");
        //    Console.WriteLine("for the foundation in C# course.");
        //    Console.WriteLine("************************");
        //}

        //private static void WelcomeUser(string firstName, string lastName)
        //{
        //    Console.WriteLine($"Hello { firstName } { lastName }");
        //}

        //private static string GetUserName(string message)
        //{
        //    Console.WriteLine(message);
        //    string output = Console.ReadLine();

        //    return output;

        //    //if (output.Length > 1)
        //    //{
        //    //    return output;
        //    //}
        //    //else
        //    //{
        //    //    return "<unknown>";
        //    //}
        //}

        // *********************************************
        // Homework

        private static void Welcome()
        {
            Console.WriteLine($"Welcome on board.");
        }

        private static string GetUserFullName()
        {
            Console.WriteLine("Enter you first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter you last name: ");
            string lastName = Console.ReadLine();

            string fullName = ($"{ firstName } { lastName }");

            return fullName;
        }

        private static void Hello(string fullName)
        {
            Console.WriteLine($"Hello { fullName }, and enjoy your stay.");
        }
    }
}
