using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class Position  //NOTE: COW and POSITION mean the same thing and are interchangable in all contexts!
    {
        public string pos;

        //List of all possible mill combinations represented as an array of Positions
        public static List<Position[]> MillCombos = new List<Position[]>
        {
            new Position[] {A7,D7,G7},
            new Position[] {B6,D6,F6},
            new Position[] {C5,D5,E5},
            new Position[] {A4,B4,C4},
            new Position[] {E4,F4,G4},
            new Position[] {C3,D3,E3},
            new Position[] {B2,D2,F2},
            new Position[] {A1,D1,G1},
            new Position[] {A7,A4,A1},
            new Position[] {B6,B4,B2},
            new Position[] {C5,C4,C3},
            new Position[] {D7,D6,D5},
            new Position[] {D3,D2,D1},
            new Position[] {E5,E4,E3},
            new Position[] {F6,F4,F2},
            new Position[] {G7,G4,G1},
            new Position[] {A7,B6,C5},
            new Position[] {A1,B2,C3},
            new Position[] {E5,F6,G7},
            new Position[] {E3,F2,G1}

        };

        public Position(string pos) //Paramatized constructor --> use to make new positions 
        {
            this.pos = pos;
        }

        public override string ToString()   //This is called when using String.Format to print board positions 
        {
            return pos;
        }

        /// <summary>
        /// Takes in a position and return a list of all the positions on the board adjacent to it 
        /// </summary>
        /// <param name="pos">Position to get adjacent moves for</param>
        /// <returns>List of adjacent positions</returns>
        public List<Position> GetAdjacentPositions(string pos)
        {
            //TODO
            return new List<Position>();
        }

        /// <summary>
        /// Takes in a position and return all possible mill combos involving that position 
        /// </summary>
        /// <param name="pos">Position to get mill combos for</param>
        /// <returns>List of all mill combos with that position as a Position Array</returns>
        public List<Position[]> GetPossibleMills(string pos)
        {
            //TODO
            return new List<Position[]>();
        }

        #region All Possible Positions on the board 
        public static Position A1 = new Position("A1");
        public static Position A4 = new Position("A4");
        public static Position A7 = new Position("A7");

        public static Position B2 = new Position("B2");
        public static Position B4 = new Position("B4");
        public static Position B6 = new Position("B6");

        public static Position C3 = new Position("C3");
        public static Position C4 = new Position("C4");
        public static Position C5 = new Position("C5");

        public static Position D1 = new Position("D1");
        public static Position D2 = new Position("D2");
        public static Position D3 = new Position("D3");
        public static Position D5 = new Position("D5");
        public static Position D6 = new Position("D6");
        public static Position D7 = new Position("D7");

        public static Position E3 = new Position("E3");
        public static Position E4 = new Position("E4");
        public static Position E5 = new Position("E5");

        public static Position F2 = new Position("F2");
        public static Position F4 = new Position("F4");
        public static Position F6 = new Position("F6");

        public static Position G1 = new Position("G1");
        public static Position G4 = new Position("G4");
        public static Position G7 = new Position("G7");

        public static Position XX = new Position("XX"); //denotes invalid position 
        #endregion

    }
}
