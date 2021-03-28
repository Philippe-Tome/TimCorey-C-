using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04Lesson02_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Enter your fist value: ";
            string message2 = "Enter your second value: ";

            double x = Input.GetValues(message1);
            double y = Input.GetValues(message2);

            double resultAdd = Calculate.Add(x, y);
            double resultMultiply   = Calculate.Multiply(x, y);
            double resultDivide = Calculate.Divide(x, y);

            //Console.WriteLine($"Adding { x } to { y } equals to { resultAdd }");
            Console.WriteLine($"Adding { x } to { y } equals to " + Calculate.Add(x, y));
            Console.WriteLine($"Multiplying { x } by { y } equals to " + Calculate.Multiply(x, y));
            Console.WriteLine($"Dividing { x } by { y } equals to " + Calculate.Divide(x, y));


            Console.ReadLine();
        }
    }
}
