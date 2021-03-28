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
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine($"The value of i is { i }");
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"The value of j is { j }");
            //    }
            //}

            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i is: { i }");
                Console.WriteLine($"The total is: { total += i * 5 }");
                Console.WriteLine(total);
            }

            Console.ReadLine();
        }
    }
}
