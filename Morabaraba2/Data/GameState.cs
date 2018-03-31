using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class GameState
    {
        public Player current, opponent;
        public enum Phase {Placing , Moving, Won, Draw }
        public ConsoleColor defaultColor;
        
        public GameState()
        {
            current = new Player("1", ConsoleColor.DarkMagenta);
            opponent = new Player("2", ConsoleColor.DarkGreen);
            defaultColor = ConsoleColor.Gray;
        }
    }
}
