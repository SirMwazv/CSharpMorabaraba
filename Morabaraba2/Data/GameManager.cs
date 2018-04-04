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
            //TODO
        }

        /// <summary>
        /// Internal Method to run moving phase
        /// </summary>
        void RunMoving()
        {
            //TODO
        }

        /// <summary>
        /// Internal Method to call when game is won 
        /// </summary>
        void Won(Player winner)
        {
            //TODO
        }
    }
}
