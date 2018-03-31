using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Morabaraba2.Data;
using Morabaraba2.Display;

//Static using directives so names don't have to be fully qualified 
using static Morabaraba2.Data.Position;
using static Morabaraba2.Display.Board;


namespace Morabaraba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note: following code is just a test 

            GameState state = new GameState();
            state.current.Cows.AddRange(new List<Position> {new Position("A7"), new Position("A4")}); //add cows to player list (testing purposes)
            state.opponent.Cows.AddRange(new List<Position> { new Position("B2"), new Position("B4") });//add cows to player list (testing purposes)
            Board board = new Board();
            PrintBoard(state);
            Console.ReadLine();
        }
    }
}
