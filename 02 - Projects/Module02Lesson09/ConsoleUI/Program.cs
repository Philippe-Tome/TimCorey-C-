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

            //Dictionary<int, string> importantYears = new Dictionary<int, string>();

            //importantYears[1492] = "Columbus discovered the new world";
            //importantYears[1969] = "Man walks on the moon";
            //importantYears[1978] = "Tim is born";

            //importantYears.Add(1932, "test input");

            //Console.WriteLine($"In the year 1978, this happened: { importantYears[1978] }");
            //Console.WriteLine($"In the year 1978, this happened: { importantYears[1932] }");

            Dictionary<int, string> employeeIDs = new Dictionary<int, string>();

            int counter = 0;

            do
            {
                Console.WriteLine("Enter your name: ");
                string nameInput = Console.ReadLine();
                Console.WriteLine("Enter your ID number: ");
                string idText = Console.ReadLine();

                bool isValidIDinput = int.TryParse(idText, out int idInput);

                if (isValidIDinput)
                {
                    employeeIDs.Add(idInput, nameInput);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Your Id number is invalid");
                }
            } while (counter < 2);

            Console.WriteLine("Enter an ID number to check your name: ");
            string idRequestText = Console.ReadLine();
            bool isValidID = int.TryParse(idRequestText, out int idRequest);

            if (isValidID)
            {
                Console.WriteLine($"Your name is: { employeeIDs[idRequest] }");

            }
            else
            {
                Console.WriteLine("ID is invlaid.");
            }

            Console.ReadLine();
        }
    }
}
