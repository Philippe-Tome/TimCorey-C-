using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04Lesson02_Homework
{
    public static class Input
    {
        public static double GetValues(string message)
        {
            Console.WriteLine(message);
            string textInput = Console.ReadLine();
            double numberInput;
            bool isDouble = double.TryParse(textInput, out numberInput);

            while ( isDouble == false )
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.WriteLine(message);
                textInput = Console.ReadLine();
                isDouble = double.TryParse(textInput, out numberInput);
            }

            return numberInput;
        }

    }
}
