using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class GameState
    {
        #region Data to be used in GameState Class

        public Player current, opponent;
        public enum Phase {Placing , Moving, Won, Draw }
        public ConsoleColor defaultColor;

        #endregion

        /// <summary>
        /// Declare a default new game state 
        /// </summary>
        public GameState()  //to be used for quickplay feature
        {
            current = new Player("Player 1", ConsoleColor.Red);
            opponent = new Player("Player 2", ConsoleColor.Green);
            defaultColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Declare a paramatized Game State with pre-defined players and an optional console color
        /// </summary>
        /// <param name="x">Player 1 </param>
        /// <param name="y">Player 2</param>
        /// <param name="col">Optional Default Console Color</param>
        public GameState(Player player_x, Player player_y, ConsoleColor col = ConsoleColor.Gray) //NOTE: Default Console Color 'col' is optional 
        {
            current = player_x;
            opponent = player_y;
            defaultColor = col;
        }

        /// <summary>
        /// Method to swap players by making 'current' player into 'opponent' and vice versa
        /// </summary>
        /// <param name="state">Current Game State</param>
        public void SwapPlayers(GameState state)
        {
            Player tmp = state.current;
            state.current = state.opponent;
            state.opponent = tmp;

        }

        /// <summary>
        /// Method that takes in input form console and gamestate phase and determines if input is in correct format
        /// </summary>
        /// <param name="str">Input from console</param>
        /// <param name="phase">Current phase of the game state</param>
        /// <returns>True if input in correct format, otherwise false</returns>
        public bool IsValidInput(string str, Phase phase)
        {
            //TODO:Method done but is there anything we should do to the input if the game has been won or there's a draw?

            if (phase == Phase.Placing)
            {
                if (str.Length == 2 && Char.IsLetter(str[0]) == true && Char.IsDigit(str[1]) == true)
                    return true;
            }

            if (phase == Phase.Moving)// TODO: Here we have two inputs. Where the cow is and where one wishes to place it.
                                      // I am assuming that these will be received as "A1A7" as in from A1 to A7. If incorrect, just show me how the input will be and I'll correct it.

            {
                if (str.Length == 4 && Char.IsLetter(str[0]) == true && Char.IsDigit(str[1]) == true && Char.IsLetter(str[2]) == true && Char.IsDigit(str[3]) == true)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Method that checks if given position is a valid move by checking if position has already been taken by either player
        /// </summary>
        /// <param name="inputPos">Position player want to move to</param>
        /// <returns>True if position is free else returns false</returns>
        public bool IsValidPosition(Position inputPos)//TODO: I changed input to position. I am assuming there is a method which will convert console string input to position type.
        {
            if (current.Cows.Contains(inputPos) || opponent.Cows.Contains(inputPos))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Method that checks if game should move to next phase 
        /// </summary>
        /// <param name="state">Current Game State</param>
        /// <returns>True if game should move to next phase otherwise returns false</returns>
        public bool CheckPhase(GameState state)
        {
            //TODO
            return false;
        }

    }
}
