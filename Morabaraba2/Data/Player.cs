using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class Player
    {
        public string name;
        public ConsoleColor playerColor;
        public int placedCows, deadCows;
        public List<Cow> Cows;
        public List<Position[]> MyMills;

        public Player(string name, ConsoleColor playerColor)
        {
            this.name = name;
            this.playerColor = playerColor;
            placedCows = 0;
            Cows = new List<Cow>();
            MyMills = new List<Position[]>();
        }
    }
}
