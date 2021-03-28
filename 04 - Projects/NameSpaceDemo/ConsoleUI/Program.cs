using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationInfo;
using FoundationInfo.Calculators.PersonalCalculators.PhilippeCalculator;
using Models.ConsoleUI;
using ConsoleUI.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.
            List<PersonModel> people = new List<PersonModel>();
            //Console.WriteLine();

            PersonModel person = new PersonModel();

            Calculation.Add(4, 3);
            //Calculation.Add(4, 3);
            //double timeStamp = Time.GetTimeStamp();
            //DateTime timeStamp = Time.GetTimeStamp();

            Console.WriteLine(Time.GetTimeStamp());

            Console.ReadLine();
        }
    }
}
