using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Morabaraba2.Display;
using static Morabaraba2.Data.GameState;

namespace Morabaraba2.Data
{
    class GameManager
    {
        
        public GameState state;     //holds all the data of the current game state therefore access all player and game state variables through this field 

        /// <summary>
        /// Declare new Game Manager with predefined game state 
        /// </summary>
        /// <param name="state">New Game State to manage</param>
        public GameManager(GameState state)
        {
            this.state = state;
        }

        /// <summary>
        /// Initializes Game and manages the game flow.
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
            /* Important: Clear the console at the beginning of the loop and print the board immediately after (inside while loop, which i explain below)
             * 0. Use a while loop to run the entire placing phase e.g while (!checkPhase(state.phase)) therefore at the end of the loop the method wil check if the phase should move on
             * Inside the while loop:
                 * 1. Prompt user for input and Get Input 
                 * 2.1 Validate input string is in correct format using IsValidInput Method
                 * 2.2 Validate Position is free using IsValidPosition
                 * 3.1 If validation fails print error using printErr method of board class and ask for input again (i recommend making an if statement that just prints the error, 
                 * reads the line so that the user can see it, then 'continue' to restart loop)
                 * 3.2 If input is valid then add position to current players cow list e.g state.current.Cows.Add(GetPosition(inputFromUser));
                 * 3.3 Print changes by calling 
                 * 4. swap players by calling SwapPlayer method of GameState class (note 'using' directive above so you can call method directly)
              * End of loop (it will automatically check if it should move to the next phase)
             */
        }

        /// <summary>
        /// Internal Method to run moving phase
        /// </summary>
        void RunMoving()
        {
            Console.WriteLine(state.current + "");
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
