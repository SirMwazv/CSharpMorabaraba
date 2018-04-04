using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class Player
    {
        #region Data to be used in Player Class

        public string name;
        public ConsoleColor playerColor;
        public int placedCows, deadCows;
        public List<Position> Cows;
        public string cowState;
        public List<Position[]> MyMills;

        #endregion

        /// <summary>
        /// Declare a new player with a name and color 
        /// </summary>
        /// <param name="name">Name of player</param>
        /// <param name="playerColor">Colour of player</param>
        public Player(string name, ConsoleColor playerColor)
        {
            this.name = name;
            this.playerColor = playerColor;
            placedCows = 0;
            deadCows = 0;
            Cows = new List<Position>();
            cowState = "OnBoard";
            MyMills = new List<Position[]>();
        }

        /// <summary>
        /// Method that takes in a position and returns a bool indicating wherether that Cow is in a Mill owned by the player
        /// </summary>
        /// <param name="pos">Cow to determine whether in a mill or not</param>
        /// <returns>Bool: If cow is in a mill then True otherwise return false</returns>
        public bool InMill(string pos)
        {
            //TODO
            return false;
        }

        /// <summary>
        /// Method to check if all players cows are in a mill 
        /// </summary>
        /// <returns>True if all players cows are in a mill otherwise return false</returns>
        public bool AllInAMill()    //to be called to check if shooting a cow in a mill is allowed only if all of players cows are in a mill
        {
            //TODO
            return false;
        }

        /// <summary>
        /// Method to change cow state of players cows to 'Flying'
        /// </summary>
        public void FlyCows()
        {
            cowState = "Flying";
        }

        /// <summary>
        /// Method that return a bool indicating whether players cows are 'Flying' or not
        /// </summary>
        /// <returns>Bool representing state of Cows True = Flying otherwise returns False</returns>
        public bool IsFlying()
        {
            return cowState == "Flying";
        }

        /// <summary>
        /// Method that takes in a position and 'shoots' that cow which belongs to the player 
        /// </summary>
        /// <param name="pos">Cow to shoot</param>
        public void ShootCow(string pos)
        {
            //TODO
        }

        /// <summary>
        /// Method that 'moves cows' by taking in two positions (Old position and New Position) and removes oldPos from players current cows and adds newPos to players current cows
        /// </summary>
        /// <param name="oldPos">Cow to remove </param>
        /// <param name="newPos">Cow to add</param>
        public void MoveCow(string oldPos, string newPos)
        {
            //TODO
        }

        /// <summary>
        /// Method that will return any possible mills that will be made by a player by placing or moving a cow to 'pos' (excluding any mills they already have)
        /// </summary>
        /// <param name="pos">Position that will potentially make a mill</param>
        /// <returns>List of mills made represented as Array of Positions</returns>
        /*
         * NOTE: This method needs to be called before a cow is added to a players cow list so as to check if any mills will be made by the player this makes it so that 
         * there is no need to keep track of the players previous state and next state. 
         */
        public List<Position[]> GetMills(string pos) 
        {
            //TODO
            return new List<Position[]> { };
        }
    }
}
