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
        public bool WinConditionCheck()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_board[i] == _board[i + 3] && _board[i + 3] == _board[i + 6]) return true;
                if (_board[3 * i] == _board[3 * i + 1] && _board[3 * i + 1] == _board[3 * i + 2]) return true;
            }
            if (_board[0] == _board[4] && _board[4] == _board[8]) return true;
            if (_board[2] == _board[4] && _board[4] == _board[6]) return true;
            return false;
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
