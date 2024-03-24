using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    internal class Tile
    {
        public Marks Mark { get; set; }

        public Tile(Marks mark)
        {
            Mark = mark;
        }
    }
}
