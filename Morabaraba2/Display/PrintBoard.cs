using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Morabaraba2.Data;

namespace Morabaraba2.Display
{
    class PrintBoard
    {
        List<Cow> CowList;

        public PrintBoard(GameState state)
        {
            CowList.Clear();
            CowList.AddRange(state.current.Cows);
            CowList.AddRange(state.current.Cows);
            

            //TODO: Rest of Print Board Function. Figure out way of efficiently printing the board 

        }
    }
}
