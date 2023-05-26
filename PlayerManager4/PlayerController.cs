using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class PlayerController
    {
        private List<Player> playerList;
        private PlayerView view;

        public PlayerController()
        {
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
            view = new PlayerView();
        }

        public void Start()
        {
            string option;

            do
            {
                view.ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListAllPlayers();
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        SortByNameAscending();
                        break;
                    case "5":
                        SortByNameDescending();
                        break;
                    case "6":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        view.ShowErrorMessage("Unknown option!");
                        break;
                }

                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");

            } while (option != "6");
        }

        private void InsertPlayer()
        {
            string name = view.GetPlayerName();
            int score = view.GetPlayerScore();

            Player newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
        }

        private void ListAllPlayers()
        {
            view.ShowPlayerList(playerList);
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minimumScore = view.GetMinimumScore();
            List<Player> filteredPlayers = playerList.FindAll(p => p.Score > minimumScore);
            view.ShowPlayerList(filteredPlayers);
        }

        private void SortByNameAscending()
        {
            playerList.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            view.ShowPlayerList(playerList);
        }

        private void SortByNameDescending()
        {
            playerList.Sort((p1, p2) => p2.Name.CompareTo(p1.Name));
            view.ShowPlayerList(playerList);
        }
    }
}


