using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        private List<Player> playerList;

        private static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Start();
        }

        private Program()
        {
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        private void Start()
        {
            string option;

            do
            {
                ShowMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers(playerList);
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
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");

            } while (option != "6");
        }

        private void ShowMenu()
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

        private void InsertPlayer()
        {
            string name;
            int score;
            Player newPlayer;

            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
        }

        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore;
            IEnumerable<Player> playersWithScoreGreaterThan;

            Console.Write("\nMinimum score player should have? ");
            minScore = Convert.ToInt32(Console.ReadLine());

            playersWithScoreGreaterThan = GetPlayersWithScoreGreaterThan(minScore);

            ListPlayers(playersWithScoreGreaterThan);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player p in playerList)
            {
                if (p.Score > minScore)
                {
                    yield return p;
                }
            }
        }

        private void SortByNameAscending()
        {
            playerList.Sort(new CompareByName(true));
            Console.WriteLine("\nPlayers sorted by name (ascending):\n");
            ListPlayers(playerList);
        }

        private void SortByNameDescending()
        {
            playerList.Sort(new CompareByName(false));
            Console.WriteLine("\nPlayers sorted by name (descending):\n");
            ListPlayers(playerList);
        }
    }
}

