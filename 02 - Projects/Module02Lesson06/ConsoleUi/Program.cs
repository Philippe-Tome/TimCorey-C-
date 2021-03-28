using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueResult = "";

            //do
            //{
            //    Console.Write("What is your name: ");
            //    string firstName = Console.ReadLine();

            //    Console.WriteLine($"Hello { firstName }");

            //    Console.Write("Do you want to continue (yes/no):");
            //    continueResult = Console.ReadLine();


            //} while (continueResult.ToLower() == "yes");

            //Console.WriteLine("What is you age: ");
            //string ageText = Console.ReadLine();

            //bool isValidAge = int.TryParse(ageText, out int ageInput);

            //while (isValidAge == false)
            //{
            //    Console.WriteLine("That was an invalid age, please try again.");

            //    Console.WriteLine("What is you age: ");
            //    ageText = Console.ReadLine();

            //    isValidAge = int.TryParse(ageText, out ageInput);


            //}

            //Console.WriteLine($"Your age in 10 years will be { ageInput + 10 }");

            string firstName = "";

            do
            {
                Console.WriteLine("What is your name (type \"exit\" to exit): ");
                firstName = Console.ReadLine();
                if (firstName.ToLower() == "tim" && firstName.ToLower() != "exit")
                {
                    Console.WriteLine($"Hello Professor { firstName }");

                }
                else if (firstName.ToLower() != "exit")
                {
                    Console.WriteLine($"Hi { firstName }");
                }
            } while (firstName.ToLower() != "exit");


            Console.ReadLine();
        }
    }
}
