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
            //string[] firstNames = new string[5];

            //firstNames[0] = "Tim";
            //firstNames[1] = "Sue";
            //firstNames[2] = "Bob";
            //firstNames[4] = "Carl";

            //Console.WriteLine($"My array has { firstNames[0] }, { firstNames[1] }, { firstNames[2] }, { firstNames[4] }");

            //string data = "Tim,Sue,Bob,Frank,Sandra,Molly";
            //string[] firstNames = data.Split(',');

            //Console.WriteLine($"The third first name is { firstNames[4] }");

            //int[] ages = new int[3];
            //ages[0] = 4;
            //ages[1] = 5;
            //ages[2] = 54;


            //string[] lastNames = new string[] { "Corey", "Smith", "Jones" }; // Allows you to fill in right now.

            //lastNames[1] = "Malcom";

            string[] names = new string[] { "Billy", "Bob", "Mary" };

            Console.WriteLine("Type a number:");
            string numberText = Console.ReadLine();

            bool isValidNumber = int.TryParse(numberText, out int number);

            if (isValidNumber)
            {
                if (number >= 0 && number < 3 )
                {
                    Console.WriteLine($"The name number { numberText } is { names[number] }");
                }
                else
                {
                    Console.WriteLine("Number not matching any elements in the array");
                }
            }
            else
            {
                Console.WriteLine("Invalid number entered!!!");
            }


            Console.ReadLine();
        }
    }
}
