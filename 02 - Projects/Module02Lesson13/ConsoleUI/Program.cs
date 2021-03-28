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
            // Console guest book.
            // Ask the user their name and how many they are, ie. Bob, 4
            // Keep track of how many people are at the party
            // At the end print the guest list and the total number of guests.

            Dictionary<string, int> partyList = new Dictionary<string, int>();

            string userNameInput;
            int guestNumberInput;

            do
            {
                userNameInput = GetUserName();

                if (userNameInput.ToLower() != "exit")
                {
                    guestNumberInput = GetUserGuestsNumber();
                    partyList.Add(userNameInput, guestNumberInput);
                }

            } while (userNameInput.ToLower() != "exit");

            int totalGuestsNumber = 0;
            Console.WriteLine("Are at the party the following names: ");

            foreach (KeyValuePair<string, int> item in partyList)
            {
                Console.WriteLine("{0}", item.Key);
                totalGuestsNumber += item.Value;
            }

            PrintTotalGuests(totalGuestsNumber);

            Console.ReadLine();
        }

        private static string GetUserName()
        {
            Console.WriteLine("Enter your name or type 'exit' to exit: ");
            return Console.ReadLine();
        }

        private static int GetUserGuestsNumber()
        {
            Console.WriteLine("Enter the number of guests you bring: ");
            return int.Parse(Console.ReadLine());
        }

        private static void PrintTotalGuests(int total)
        {
            Console.WriteLine($"There are a total of { total } guests at the party.");
        }
       
    }
}
