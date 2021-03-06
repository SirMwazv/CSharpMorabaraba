﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class GameState
    {
        #region Data to be used in GameState Class

        public Player current, opponent, winner;
        public enum Phase {Placing , Moving, Won, Draw }
        public Phase phase; 
        public ConsoleColor defaultColor;

        #endregion

        /// <summary>
        /// Declare a default new game state 
        /// </summary>
        public GameState()  //to be used for quickplay feature
        {
            //current = new Player("Player 1", ConsoleColor.Red);
            //opponent = new Player("Player 2", ConsoleColor.Green);

            //#region Test code
            current = new Player("Player 1", ConsoleColor.Red);
            opponent = new Player("Player 2", ConsoleColor.Green);
            //current.placedCows = 11;
            //opponent.placedCows = 11;
            //current.deadCows = 9;
            //opponent.deadCows = 9;
            //
            //current.Cows.Add(Position.A7);
            //current.Cows.Add(Position.A4);
            //
            //opponent.Cows.Add(Position.B2);
            //opponent.Cows.Add(Position.B4);

          //  #endregion

            phase = Phase.Placing;
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
            phase = Phase.Placing;
        }

        /// <summary>
        /// Method to swap players by making 'current' player into 'opponent' and vice versa
        /// </summary>
        /// <param name="state">Current Game State</param>
        public static void SwapPlayers(GameState state)
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
        public static bool IsValidInput(string str, Phase phase)
        {
            if (phase == Phase.Placing)
            {
                if (str.Length == 2 && Char.IsLetter(str[0]) == true && Char.IsDigit(str[1]) == true)
                    if (Position.GetPosition(str) != Position.XX)
                        return true;
            }

            if (phase == Phase.Moving)
            {
                if (str.Length == 4 && Char.IsLetter(str[0]) == true && Char.IsDigit(str[1]) == true && Char.IsLetter(str[2]) == true && Char.IsDigit(str[3]) == true)
                {
                    if (Position.GetPosition(str.Substring(0, 2)) != Position.XX && Position.GetPosition(str.Substring(2, 2)) != Position.XX)
                        return true;
                }                    
            }

            return false;
        }

        /// <summary>
        /// Method that checks if given position is a valid move by checking if position has already been taken by either player
        /// </summary>
        /// <param name="inputPos">Position player want to move to</param>
        /// <returns>True if position is free else returns false</returns>
        public bool IsValidPosition(Position inputPos) 
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
        public static bool CheckPhase(GameState state)
        {                 
            switch (state.phase)
            {
                case Phase.Placing:
                    if (state.current.placedCows == 12 && state.opponent.placedCows == 12)
                    {
                        state.phase = Phase.Moving;
                        return true;
                    }   
                    break;

                case Phase.Moving:

                    if (state.current.Cows.Count == 2)
                    {
                        state.winner = state.opponent;
                        state.phase = Phase.Won;
                        return true;
                    }

                    if (state.opponent.Cows.Count == 2)
                    {
                        state.winner = state.current;
                        state.phase = Phase.Won;
                        return true;
                    }

                    break;

                default:
                    return false;                   
                    
            }
            return false;
        }

    }
}
