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
        public List<Position> Cows;
        public string cowState;
        public List<Position[]> MyMills;

        public Player(string name, ConsoleColor playerColor)
        {
            this.name = name;
            this.playerColor = playerColor;
            placedCows = 0;
            deadCows = 0;
            Cows = new List<Position>();
            cowState = "OnBoard";
            MyMills = new List<Position[]>();
        }

        void FlyCows()
        {
            cowState = "Flying";
        }

        public bool IsFlying()
        {
            return cowState == "Flying";
        }
    }
}
