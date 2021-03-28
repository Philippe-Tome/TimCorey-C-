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
            //try
            //{
            //    BadCall();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("There was an exception thrown in our app");
            //    Console.WriteLine(ex.Message);   
            //}

            Homework();


            Console.ReadLine();

            //private static void BadCall()
            //{
            //    int[] ages = new int[] { 1, 3, 5 };

            //    for (int i = 0; i <= ages.Length; i++)
            //    {
            //        try
            //        {
            //            Console.WriteLine(ages[i]);
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("We had an error");
            //            Console.WriteLine(ex.Message);
            //            throw new Exception("There was an error handling our array", ex);
            //        }
            //    }
            //}
        }

        private static void Homework()
        {
            string[] names = new string[] { "Romeo", "Amori", "Billy", "Joe" };

            for (int i = 0; i <= names.Length; i++)
            {
                try
                {
                    Console.WriteLine($"The names on the list are: { names[i]} ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error.");
                    Console.WriteLine($"Error message: { ex.Message }");
                    Console.WriteLine($"Error trace: { ex.StackTrace }");
                    //throw;
                }
            }
        }
    }
}

