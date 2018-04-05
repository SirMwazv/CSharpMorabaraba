using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class GameManager
    {
        
        public GameState state;

        /// <summary>
        /// Declare new Game Manager with predefined game state 
        /// </summary>
        /// <param name="state">New Game State to manage</param>
        public GameManager(GameState state) //to be used for quickplay feature
        {
            this.state = state;
        }

        /// <summary>
        /// Initializes Game if necesarry then runs the game.
        /// </summary>
        public void RunGame()
        {
            //TODO
        }

        /// <summary>
        /// Internal Method to run placing phase
        /// </summary>
        void RunPlacing()
        {
          /* Must have a list with all unused positions
           * 1. Validate Placing:
           * IF (UnusedPositionsList is empty) THEN 
           *    Change State to Moving
           *    ELSE
           *        IF(Input is in the UnusedPositionsList) THEN 
           *            Add Input to PlayerCowsList
           *            Remove InputPosition from UnusedPositionsList
           */
            //TODO
        
        }

        /// <summary>
        /// Internal Method to run moving phase
        /// </summary>
        void RunMoving()
        {
            /*1. Validate the input:
             * (Must be adjacent)
             * IF (CurrentPosition is in 'Ret'[Ret is list containing all of the adjacent positions] THEN
             *  CONTINUE;
             * ELSE return INVALID MOVE
             * IF (EnteredMove is in Player1CowList or is in Player2CowList) THEN 
             *  return INVALID MOVE
             * ELSE 
             *  CONTINUE;
             * 
             * 2. Remove CurrentPosition from CurrentPlayerCowList 
             *    Add InputedPosition into CurrentPlayerCowList
             */
            //TODO
        }

        /// <summary>
        /// Internal Method to call when game is won 
        /// </summary>
        void Won(Player winner)
        {
            /*
             * IF Player1State is Flying THEN 
             *  IF (NumberofCows in Player1CowList is 3 or Less) 
             *      then Player2 wins
             * IF Player2State is Flying THEN 
             *  IF (NumberofCows in Player2CowList is 3 or Less) 
             *      then Player1 wins
             */
            //TODO
        }
    }
}
