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
            PersonModel person = new PersonModel();

            person.FirstName = "Billy";
            //person.LastName = "Joe";
            person.Age = 34;
            person.SSN = "123-45-6789";

            AddressModel address = new AddressModel();
            address.Number = 82;
            address.Street = "Montlhery";
            address.Postcode = 91400;
            address.City = "Orsay";
            address.Country = "France";

            Console.WriteLine(address.FullAddress);

            //Console.WriteLine(person.FullName);
            //Console.WriteLine(person.SSN);


            Console.ReadLine();
        }
    }
}
