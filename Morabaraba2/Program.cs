using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Morabaraba2.Data;
using static Morabaraba2.Data.Position;
using Morabaraba2.Display;

namespace Morabaraba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note: following code is just a test 

            GameState state = new GameState();
            state.current.Cows.AddRange(new List<Cow> {new Cow("Moving",A7), new Cow("Moving", A4)}); //add cows to player list (testing purposes)
            state.opponent.Cows.AddRange(new List<Cow> { new Cow("Moving", B2), new Cow("Moving", B4) });//add cows to player list (testing purposes)
            PrintBoard board = new PrintBoard(state);
            Console.ReadLine();
        }
    }
}
