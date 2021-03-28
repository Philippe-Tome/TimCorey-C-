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
            string name = "";
            try
            {
                //DifferentMethod();

                Console.WriteLine("What is your name: ");
                name = Console.ReadLine();

                //ComplexMethod(name);
                //SimpleMethod();

                WorkoutExercise(name);

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling these methods");
                //Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code!!!");
            }
            //catch (Exception) when (name.ToLower() == "tim")
            //{
            //    Console.WriteLine("You used Tim's name, didn't you?");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("I always run");
                // Close out code. Close out stream to databases in case it fails, etc...
            }

            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too tall for this method.");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim.");
            }

            //throw new NotImplementedException();
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod");
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the different method working properly.");
        }

        private static void WorkoutExercise(string name)
        {
            if (name.ToLower() == "tim")
            {
                Console.WriteLine("Your name sucks we are going to throw an exception");
                throw new ApplicationException("Get lost Tim");
            }
            else
            {
                Console.WriteLine("Welcome in bidule.");
                throw new ExecutionEngineException("This is the not Tim exception");
            }
        }
    }
}
