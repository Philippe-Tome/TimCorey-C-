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

            int checkAge = 21;
            string checkName1 = "Bob";
            string checkName2 = "Sue";

            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();


            if (nameInput.ToLower() == checkName1.ToLower() || nameInput.ToLower() == checkName2.ToLower())
            {
                Console.WriteLine($"Hi Professor { nameInput }.");
            }
            else
            {
                Console.Write("Enter your age: ");
                string ageTextInput = Console.ReadLine();
                bool isValidAgeInput = int.TryParse(ageTextInput, out int ageInput);

                if (!isValidAgeInput)
                {
                    Console.WriteLine("That was not a valid age.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    if (ageInput > 21)
                    {
                        Console.WriteLine($"Welcome in { nameInput }");
                    }
                    else
                    {
                        Console.WriteLine($"Come back in { checkAge - ageInput } years.");
                    }
                }
                //else
                //{
                //    Console.WriteLine("Invalid age entry.");
                //}
            }

            Console.ReadLine();
        }
    }
}
