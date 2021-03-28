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
            //Console.Write("What is your age: ");
            //string ageText = Console.ReadLine();

            //ageText += 10;

            //Console.WriteLine($"You are going to be { ageText } years old in 10 years.");

            // Other TryParse possibility
            //bool.TryParse();
            //decimal.TryParse();
            //double.TryParse();


            //bool isValidAge = int.TryParse(ageText, out int age);


            //if (isValidAge)
            //{
            //    age += 10;
            //    Console.WriteLine($"You are going to be { age } years old in 10 years."); 
            //}
            //else
            //{
            //    Console.WriteLine("That was not a valid age.");
            //}


            // Exercice: Capture user's age from the console and then identify how old they were in the year 2000. If they were not born yet, tell them that instead.

            int currentYear = 2020;
            int inWhatYear = 2000;
            int howManyYearsAgo = currentYear - inWhatYear;
            
            Console.WriteLine("What is your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            if (isValidAge)
            {
                if (age > howManyYearsAgo)
                {
                    Console.WriteLine($"You were { age - howManyYearsAgo } years old in { inWhatYear }.");
                }
                else
                {
                    Console.WriteLine($"You were not even born yet in { inWhatYear }.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age entry!!!");
            }


            Console.ReadLine();
        }
    }
}
