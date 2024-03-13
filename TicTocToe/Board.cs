using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    internal class Board
    {
        private string[] _board;
        public Board()
        {
            _board = new string[9];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                _board[i] = "-";
            }
        }

        public void PrintBoard()
        {
            for (int i = 0; i < _board.Length; i++)
            {
                Console.Write($"|  {_board[i]}  ");
                if (i % 3 == 2)
                {
                    Console.WriteLine("|");
                    Console.WriteLine();
                }
            }
        }

    }
}
