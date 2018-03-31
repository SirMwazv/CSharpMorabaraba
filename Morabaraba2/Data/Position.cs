using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class Position
    {
        public string pos;

        public Position(string pos)
        {
            this.pos = pos;
        }

        public override string ToString()   //This is called when using String.Format to print board positions 
        {
            return pos;
        }

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

    }
}
