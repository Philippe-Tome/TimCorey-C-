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
            string firstName = "";
            string lastName = "";
            string fullName = "";
            
            firstName = "Tim";
            lastName = "Corey";

            // $ is for string interpolation
            fullName = $"{ firstName } { lastName }";

            // @ is for string literals
            string fileName = @"C:\Temp\Temp.txt";

            // Whole number
            int age = 0;

            age = 10;
            age = 20;
            age = 23;

            int numberOfApplesTotal = 450;
            int numberOfApplesIAte = 50;

            Console.WriteLine(numberOfApplesTotal - numberOfApplesIAte);

            string zipCode = "08411";

            Console.WriteLine(zipCode);

            // Use double for all numbers except for money
            double averageWordsPerMinute = 34.24; // double for not whole numbers. Represents about 15 points after the decimal.

            // Use only for money:
            decimal costPerContainer = 43.85M; // Have to put a capital M at the end to make it double. Decimal is much more precise but expensive. If it is not related to money always use double.

            bool isAlie = false;



            Console.WriteLine(fullName);

            Console.ReadLine();

        }
    }
}
