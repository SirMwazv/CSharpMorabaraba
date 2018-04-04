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

        public List <string> GetAdjacentPosition (string pos) //This gives all possible moves from a given position
        {
            List<string> ret = new List<string>();
            switch (pos)
            {
                case "A1":
                    List<string> a1 = new List<string>();
                    a1.Add("D1");
                    a1.Add("A4");
                    a1.Add("B2");
                    ret = a1;
                    break;

                case "A4":
                    List<string> a4 = new List<string>();
                    a4.Add("A1");
                    a4.Add("B4");
                    a4.Add("A7");
                    ret = a4;
                    break;

                case "A7":
                    List<string> a7 = new List<string>();
                    a7.Add("A4");
                    a7.Add("B6");
                    a7.Add("D7");
                    ret = a7;
                    break;

                case "B2":
                    List<string> b2 = new List<string>();
                    b2.Add("A1");
                    b2.Add("D2");
                    b2.Add("C3");
                    b2.Add("B4");
                    ret = b2;
                    break;

                case "B4":
                    List<string> b4 = new List<string>();
                    b4.Add("B2");
                    b4.Add("A4");
                    b4.Add("C4");
                    b4.Add("B6");
                    ret = b4;
                    break;

                case "B6":
                    List<string> b6 = new List<string>();
                    b6.Add("B4");
                    b6.Add("C5");
                    b6.Add("D6");
                    b6.Add("A7");
                    ret = b6;
                    break;

                case "C3":
                    List<string> c3 = new List<string>();
                    c3.Add("B2");
                    c3.Add("C4");
                    c3.Add("D3");
                    ret = c3;
                    break;

                case "C4":
                    List<string> c4 = new List<string>();
                    c4.Add("C3");
                    c4.Add("B4");
                    c4.Add("C5");
                    ret = c4;
                    break;

                case "C5":
                    List<string> c5 = new List<string>();
                    c5.Add("C4");
                    c5.Add("D5");
                    c5.Add("B6");
                    ret = c5;
                    break;

                case "D1":
                    List<string> d1 = new List<string>();
                    d1.Add("A1");
                    d1.Add("G1");
                    d1.Add("D2");
                    ret = d1;
                    break;

                case "D2":
                    List<string> d2 = new List<string>();
                    d2.Add("D1");
                    d2.Add("F2");
                    d2.Add("D3");
                    d2.Add("B2");
                    ret = d2;
                    break;

                case "D3":
                    List<string> d3 = new List<string>();
                    d3.Add("D2");
                    d3.Add("E3");
                    d3.Add("C3");
                    ret = d3;
                    break;

                case "D5":
                    List<string> d5 = new List<string>();
                    d5.Add("E5");
                    d5.Add("D6");
                    d5.Add("C5");
                    ret = d5;
                    break;

                case "D6":
                    List<string> d6 = new List<string>();
                    d6.Add("D5");
                    d6.Add("F6");
                    d6.Add("D7");
                    d6.Add("B6");
                    ret = d6;
                    break;

                case "D7":
                    List<string> d7 = new List<string>();
                    d7.Add("D6");
                    d7.Add("G7");
                    d7.Add("A7");
                    ret = d7;
                    break;

                case "E3":
                    List<string> e3 = new List<string>();
                    e3.Add("F2");
                    e3.Add("E4");
                    e3.Add("D3");
                    ret = e3;
                    break;

                case "E4":
                    List<string> e4 = new List<string>();
                    e4.Add("E3");
                    e4.Add("F4");
                    e4.Add("E5");
                    ret = e4;
                    break;

                case "E5":
                    List<string> e5 = new List<string>();
                    e5.Add("E4");
                    e5.Add("F6");
                    e5.Add("D5");
                    ret = e5;
                    break;

                case "F2":
                    List<string> f2 = new List<string>();
                    f2.Add("G1");
                    f2.Add("F4");
                    f2.Add("E3");
                    f2.Add("D2");
                    ret = f2;
                    break;

                case "F4":
                   List<string> f4 = new List<string>();
                   f4.Add("F2");
                   f4.Add("G4");
                   f4.Add("F6");
                   f4.Add("E4");
                   ret = f4;
                    break;

                case "F6":
                    List<string> f6 = new List<string>();
                    f6.Add("F4");
                    f6.Add("G7");
                    f6.Add("D6");
                    f6.Add("E5");
                    ret = f6;
                    break;

                case "G1":
                    List<string> g1 = new List<string>();
                    g1.Add("D1");
                    g1.Add("G4");
                    g1.Add("F2");
                    ret = g1;
                    break;

                case "G4":
                    List<string> g4 = new List<string>();
                    g4.Add("G1");
                    g4.Add("F4");
                    g4.Add("G7");
                    ret = g4;
                    break;

                case "G7":
                    List<string> g7 = new List<string>();
                    g7.Add("G4");
                    g7.Add("F6");
                    g7.Add("D7");
                    ret = g7;
                    break;
            }
             return ret;
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
