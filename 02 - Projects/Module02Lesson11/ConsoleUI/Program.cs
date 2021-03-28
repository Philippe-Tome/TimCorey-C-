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
            //List<string> firsNames = new List<string>();

            //firsNames.Add("Tim");
            //firsNames.Add("Sue");
            //firsNames.Add("Bob");
            //firsNames.Add("Dan");

            //foreach (string name in firsNames)
            //{
            //    Console.WriteLine(name);

            //}

            //Dictionary<int, string> importantYears = new Dictionary<int, string>();

            //importantYears.Add(1492, "Columbus arrives in Central America.");
            //importantYears.Add(1969, "Man walks on the moon.");
            //importantYears.Add(1978, "He is born.");

            //foreach (var year in importantYears)
            //{
            //    Console.WriteLine($"{ year.Key }: { year.Value }");
            //}

            string exitInput = "exit";
            List<string> firstNames = new List<string>();
            string nameInput = "";

            do
            {
                Console.WriteLine("Enter your name or type: 'exit'");
                nameInput = Console.ReadLine();
                if (nameInput.ToLower() != exitInput)
                {
                    firstNames.Add(nameInput); 
                }
            } while (nameInput.ToLower() != exitInput);

            foreach (var name in firstNames)
            {
                Console.WriteLine($"Hello { name }.");
            }


            Console.ReadLine();
        }
    }
}
