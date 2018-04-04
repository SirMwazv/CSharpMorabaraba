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
            current = new Player("Player 1", ConsoleColor.DarkMagenta);
            opponent = new Player("Player 2", ConsoleColor.DarkGreen);
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
            //TODO
        }

        /// <summary>
        /// Method that takes in input form console and gamestate phase and determines if input is in correct format
        /// </summary>
        /// <param name="str">Input from console</param>
        /// <param name="phase">Current phase of the game state</param>
        /// <returns>True if input in correct format, otherwise false</returns>
        public bool IsValidInput(string str, Phase phase)
        {
            //TODO
            return false;
        }

        /// <summary>
        /// Method that checks if given position is a valid move by checking if position has already been taken by either player
        /// </summary>
        /// <param name="inputPos">Position player want to move to</param>
        /// <returns>True if position is free else returns false</returns>
        public bool IsValidMove(string inputPos)
        {
            //TODO
            return false;
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
