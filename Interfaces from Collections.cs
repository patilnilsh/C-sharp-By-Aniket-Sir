using System;
using System.Collections;
using System.Text;

namespace CSharpByAniketSir.Collection
{
    /*class Interfaces_from_Collections
    {
    IComparable
    IComparer
    IEnumerable
    IEnumerator


    }*/

    public class Player : IComparable
    {
        private int run;
        private string name;
        public Player(int run, string name)
        {
            this.run = run;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Runs {run}  name {name}";
        }
    }
    public class Team : IEnumerable
    {
        Player[] players;
        public Team()
        {
            players = new Player[3];
            players[0] = new Player(10000, "Rohit");
            players[1] = new Player(12000, "Virat");
            players[2] = new Player(24000, "Dhoni");
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            foreach (Player p in team)
            {
                Console.WriteLine(p);
            }

        }

    }


}
