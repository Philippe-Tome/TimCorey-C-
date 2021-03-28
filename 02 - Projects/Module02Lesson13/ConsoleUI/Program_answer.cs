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

            //************
            // Pseudo code
            // Ask for the user's name
            // Add the name to the list of names
            // Ask the user's party count
            // Add the party count to the total party number
            // Print out all names
            // Print out total party number

            List<string> parties = new List<string>();
            int totalGuests = 0;
            string moreGuestsComing = "";



            do
            {
                parties.Add(GetInfoFromConsole("What is your party/group name: "));

                totalGuests += GetPartySize();

                moreGuestsComing = GetInfoFromConsole("Do you want to add another guest (yes/no): ");

            } while (moreGuestsComing.ToLower() == "yes");

            Console.WriteLine();
            Console.WriteLine("Guest Parties at Event: ");

            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine($"Total Guests: { totalGuests }");

            Console.ReadLine();
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();

            return output;
        }

        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;

            do
            {
                string partySizeText = GetInfoFromConsole("How many people are in your party: ");
                
                isValidNumber = int.TryParse(partySizeText, out output);

            } while (isValidNumber == false);

            return output;
        }
       
    }
}
