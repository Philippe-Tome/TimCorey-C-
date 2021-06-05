using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleshipLite
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");

            PlayerInfoModel winner = null;

            do
	        {
                DiplayShotGrid(activePlayer); // Display grid from activePlayer on where they fired
                
                RecordPlayerShot(activePlayer, opponent); // Ask the activePlayer for a shot. Determine if valid shot. Determine shot results.
                
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);
                
                if (doesGameContinue == true) // If over set activePlayer as the winner. Else, swap positions ( activePlayer to opponent ) // Tuple
                {
                    //// Swap using a temp variable:
                    //PlayerInfoModel tempHolder = opponent;
                    //opponent = activePlayer;
                    //activePlayer = tempHolder;
                    
                    (activePlayer, opponent) = (opponent, activePlayer); // Tuple: New way of swapping the players, only from C# v7.0

                }
                else
                {
                    winner = activePlayer;
                }

	        } while (winner == null);

            IdentifyWinner(winner);


            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to: { winner.UserName } for winning!");
            Console.WriteLine($"{ winner.UserName } took { GameLogic.GetShotCount(winner)} shots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            // Asks for a shot ( we ask for "B2" )
            // Determine what row and column that is - split it apart
            // Determine if that is a valid shot
            // Go back to the beginning if not a valid shot
            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }
            } while (isValidShot == false);

            // Determine shot results
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            // Record results
            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            // Display the result of the shot
            DisplayShotResults(row, column, isAHit);

        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"{ row }{ column } is a Hit!"); 
            }
            else
            {
                Console.WriteLine($"{ row }{ column } is a miss.");
            }

            Console.WriteLine();
        }

        private static string AskForShot(PlayerInfoModel player)
        {
            Console.Write($"{ player.UserName }, please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void DiplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine(); // if it's a new row then print a new line
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" { gridSpot.SpotLetter }{ gridSpot.SpotLetter } ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X  ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }

            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Philippe Tome");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for: { playerTitle }");

            // Ask the user for their name
            output.UserName = AskForUsersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements
            PlaceShips(output);

            // Clear
            Console.Clear();

            return output;

        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number { model.ShipLocations.Count + 1 }: ");
                string location = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }
            } while (model.ShipLocations.Count < 5);

        }
    }
}
