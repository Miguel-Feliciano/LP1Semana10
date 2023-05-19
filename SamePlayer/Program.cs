using System;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
{
    static void Main()
    {
        HashSet<Player> setOfPlayers = new HashSet<Player>();

        Player player1 = new Player { Type = PlayerType.Slayer, Name = "Kurama" };
        Player player2 = new Player { Type = PlayerType.Mage, Name = "Rod" };
        Player player3 = new Player { Type = PlayerType.Tank, Name = "Flamenzo" };

        setOfPlayers.Add(player1);
        setOfPlayers.Add(player2);
        setOfPlayers.Add(player3);

        foreach (Player p in setOfPlayers)
        {
            Console.WriteLine($"{p.Name} is a {p.Type}");
        }
    }
}
}
