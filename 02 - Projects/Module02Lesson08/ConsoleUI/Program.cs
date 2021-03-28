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

            //List<string> firstNames = new List<string>();

            //firstNames.Add("Tim");
            //firstNames.Add("Sue");
            //firstNames.Add("Bob");
            ////firstNames.Add(1.ToString()); // To pass a number to a string List<T>

            //Console.WriteLine($"The second element is { firstNames[1] }");

            //Console.WriteLine($"Name count before removal { firstNames.Count }");

            //firstNames.Remove("Sue");

            //firstNames[1] = firstNames[1].ToUpper();

            //Console.WriteLine($"The second element is { firstNames[0] }");
            //Console.WriteLine($"The second element is { firstNames[1] }");

            ////Console.WriteLine($"The second element is { firstNames[1] }");

            //Console.WriteLine(firstNames.Count);

            List<string> studentNames = new List<string>();

            int count = 0;
            do
            {
                Console.WriteLine("Enter your student name: ");
                studentNames.Add(Console.ReadLine());
                count++;
            } while (count < 3);

            Console.WriteLine($"There are { count } students.");
            Console.WriteLine($"Second student counter { studentNames.Count }");



            Console.ReadLine();
        }
    }
}
