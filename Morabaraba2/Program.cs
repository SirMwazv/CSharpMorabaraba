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
    //Main entry Point for Game
    class Program
    {
        static void Main(string[] args)
        {
            //Note: following code is just a test 

            /*
            GameState state = new GameState();
            state.current.Cows.AddRange(new List<Position> {new Position("A7"), new Position("A4")}); //add cows to player list (testing purposes)
            state.opponent.Cows.AddRange(new List<Position> { new Position("B2"), new Position("B4") });//add cows to player list (testing purposes)
            Board board = new Board();
            PrintBoard(state);
            Console.ReadLine();
            */

            var game = new GameManager(new GameState());
            Console.WriteLine("Press 1 for Quickplay \nPress 2 to Setup Game");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    game.RunGame();
                    break;
                case '2':
                    #region Setup Player 1
                    Console.WriteLine("Player 1 please enter your name.");                    
                    var p1Name = Console.ReadLine();
                    ConsoleColor p1Col = new ConsoleColor();
                    bool validCol = false;
                    char p1ColChoice = 'X';
                    while (!validCol)
                    {
                        Console.Clear();
                        Console.WriteLine(p1Name + ", Choose your color:\n 1:Red \n 2:Blue\n 3:Green \n 4:Yellow");
                        p1ColChoice = Console.ReadKey().KeyChar;
                        switch (p1ColChoice)
                        {
                            case '1':
                                p1Col = ConsoleColor.Red;
                                validCol = true;
                                break;
                            case '2':
                                p1Col = ConsoleColor.Blue;
                                validCol = true;
                                break;
                            case '3':
                                p1Col = ConsoleColor.Green;
                                validCol = true;
                                break;
                            case '4':
                                p1Col = ConsoleColor.Yellow;
                                validCol = true;
                                break;
                            default:
                                PrintErr("Invalid Selection! Please pick a valid number.");
                                Console.ReadLine();
                                break;
                        }
                    }
                    Player p1 = new Player(p1Name, p1Col);
                    #endregion

                    #region Setup Player 2
                    Console.WriteLine("Player 2 please enter your name.");
                    var p2Name = Console.ReadLine();
                    ConsoleColor p2Col = new ConsoleColor();
                    validCol = false;
                    char p2ColChoice = 'X';
                    while (!validCol)
                    {
                        Console.Clear();
                        Console.WriteLine(p2Name + ", Choose your color:\n 1:Red \n 2:Blue\n 3:Green \n 4:Yellow");
                        p2ColChoice = Console.ReadKey().KeyChar;
                        if (p1ColChoice == p2ColChoice)
                        {
                            PrintErr("Invalid Selection! NOTE: You can't have the same colour as your opponent!");
                            Console.ReadLine();
                            continue;
                        }
                            
                        switch (p2ColChoice)
                        {
                            case '1':
                                p2Col = ConsoleColor.Red;
                                validCol = true;
                                break;
                            case '2':
                                p2Col = ConsoleColor.Blue;
                                validCol = true;
                                break;
                            case '3':
                                p2Col = ConsoleColor.Green;
                                validCol = true;
                                break;
                            case '4':
                                p2Col = ConsoleColor.Yellow;
                                validCol = true;
                                break;
                            default:
                                PrintErr("Invalid Selection! Please pick a valid number.");
                                Console.ReadLine();
                                break;
                        }
                    }
                    Player p2 = new Player(p2Name, p2Col);
                    #endregion

                    #region Setup Console Color
                    ConsoleColor bg = new ConsoleColor();
                    Console.WriteLine("Please Choose a Deafult Color for the console (background)\n 1:Gray \n 2:White \n 3:Cyan \n 4:DarkCyan");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            bg = ConsoleColor.Gray;
                            validCol = true;
                            break;
                        case '2':
                            bg = ConsoleColor.White;
                            validCol = true;
                            break;
                        case '3':
                            bg = ConsoleColor.Cyan;
                            validCol = true;
                            break;
                        case '4':
                            bg = ConsoleColor.DarkCyan;
                            validCol = true;
                            break;
                        default:
                            PrintErr("Invalid Selection! Please pick a valid number.");
                            break;
                    }
                    #endregion

                    game = new GameManager(new GameState(p1, p2, bg));
                    game.RunGame();
                    

                    break;
            }

            if (game.replay)    //allow replay of game 
                Main(args);




        }
    }
}
