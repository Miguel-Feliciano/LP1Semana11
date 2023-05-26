using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class PlayerView
    {
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort by name ascending");
            Console.WriteLine("5. Sort by name descending");
            Console.WriteLine("6. Quit\n");
            Console.Write("Your choice > ");
        }

        public void ShowPlayerList(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        public void ShowErrorMessage(string message)
        {
            Console.Error.WriteLine($"\n>>> Error: {message} <<<\n");
        }

        public string GetPlayerName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }

        public int GetPlayerScore()
        {
            Console.Write("Score: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetMinimumScore()
        {
            Console.Write("\nMinimum score player should have? ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
