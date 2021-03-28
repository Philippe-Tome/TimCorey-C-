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
            // Building a house from the blueprint
            //PersonModel person = new PersonModel();
            //person.fistName = "Tim";

            //PersonModel secondPerson = new PersonModel();
            //secondPerson.fistName = "Sue";

            //Console.WriteLine(person.fistName);
            //Console.WriteLine(secondPerson.fistName);

            //List<PersonModel> people = new List<PersonModel>();

            //// Variable holds the street address
            //PersonModel person = new PersonModel();

            //person.fistName = "Tim";

            //people.Add(person);

            //person = new PersonModel();

            //person.fistName = "Sue";

            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.fistName);
            //}

            //List<PersonModel> people = new List<PersonModel>();
            //string firstName = "";
            //string lastName = "";

            //do
            //{
            //    Console.Write("What is your first name (or type exit to stop): ");
            //    firstName = Console.ReadLine();


            //    if (firstName.ToLower() != "exit")
            //    {
            //        Console.Write("What is your last name: ");
            //        lastName = Console.ReadLine();
            //        PersonModel person = new PersonModel();
            //        person.FirstName = firstName;
            //        person.LastName = lastName;
            //        people.Add(person);
            //    }
            //} while (firstName.ToLower() != "exit");

            //foreach (PersonModel p in people)
            //{
            //    ProcessPerson.GreetPerson(p);
            //}

            List<Person> peopleList = new List<Person>();
            List<Address> addresses = new List<Address>();
            string firstName = "";

            do
            {
                Person person = new Person();
                Address address = new Address();

                Console.WriteLine("Type in your first name or type exit to stop: ");
                firstName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    person.FirstName = firstName;

                    Console.WriteLine("Enter your last name: ");
                    person.LastName = Console.ReadLine();

                    //Console.WriteLine("Enter your gender: ");
                    //person.Gender = Console.ReadLine();

                    //Console.WriteLine("Enter your age");
                    //person.Age = Console.ReadLine();

                    peopleList.Add(person);

                    Console.WriteLine("Enter you street address: ");
                    address.Street = Console.ReadLine();

                    Console.WriteLine("Enter your street number: ");
                    address.StreetNumber = Console.ReadLine();

                    Console.WriteLine("Enter your city: ");
                    address.City = Console.ReadLine();

                    Console.WriteLine("Enter your post code: ");
                    address.PostCode = Console.ReadLine();

                    addresses.Add(address);
                }

            } while (firstName.ToLower() != "exit");

            foreach (Person p in peopleList)
            {
                Console.WriteLine($"First name: { p.FirstName }, Last name: { p.LastName }, Gender: { p.Gender }, Age: { p.Age }");
            }

            foreach (Address a in addresses)
            {
                Console.WriteLine($"{ a.StreetNumber } { a.Street }, { a.PostCode } - { a.City }");
            }

            Console.ReadLine();
        }
    }
}
