using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {

            GetGuests();

            Print();

            Console.ReadLine();
        }

        private static void Print()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine($"Firstname: { guest.FirstName }, Lastname: { guest.LastName }");
            }
        }

        private static void GetGuests()
        {
            string again = "";

            do
            {
                GuestModel guest = new GuestModel();

                Console.WriteLine("Enter your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.WriteLine("Enter your last name: ");
                guest.LastName = Console.ReadLine();

                Console.WriteLine("Do another guest? (yes/no)");
                again = Console.ReadLine();

                guests.Add(guest);

            } while (again.ToLower() == "yes");
        }
    }
}
