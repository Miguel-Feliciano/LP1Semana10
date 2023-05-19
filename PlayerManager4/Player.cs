using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class Player : IComparable<Player>
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            return other.Score.CompareTo(Score);
        }
    }

    public class CompareByName : IComparer<Player>
    {
        private bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (ascending)
                return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
            else
                return String.Compare(y.Name, x.Name, StringComparison.Ordinal);
        }
    }
}

