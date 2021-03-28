using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static List<string> parties = new List<string>();
        private static int totalGuests = 0;

        static void Main(string[] args)
        {

            // Pseudo code
            // Ask for the user's name
            // Add the name to the list of names
            // Ask the user's party count
            // Add the party count to the total party number
            // Print out all names
            // Print out total party number

            LoadGuests();
            DisplayGuests();
            DisplayGuestCount();

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

        private static void LoadGuests()
        {
            string moreGuestsComing = "";



            do
            {
                parties.Add(GetInfoFromConsole("What is your party/group name: "));

                totalGuests += GetPartySize();

                moreGuestsComing = GetInfoFromConsole("Do you want to add another guest (yes/no): ");

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static void DisplayGuests()
        {
            Console.WriteLine();
            Console.WriteLine("Guest Parties at Event: ");

            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }
        }

        private static void DisplayGuestCount()
        {
            Console.WriteLine();

            Console.WriteLine($"Total Guests: { totalGuests }");

        }
    }
}
