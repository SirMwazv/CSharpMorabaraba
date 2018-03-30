using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba2.Data
{
    class Cow
    {
        public string state;
        public Position pos;

        public Cow(string state, Position pos)
        {
            this.state = state;
            this.pos = pos;
        }
    }
}
