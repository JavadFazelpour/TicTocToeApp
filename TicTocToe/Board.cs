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
        private Tile[,] board;
        public Board()
        {
            board = new Tile[3, 3];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = new Tile(Marks.Empty);
                }

            }
        }
        public bool WinConditionCheck()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Mark == board[i, 1].Mark && board[i, 1].Mark == board[i, 2].Mark) return true;
                if (board[0, i].Mark == board[1, i].Mark && board[1, i].Mark == board[2, i].Mark) return true;
            }
            if (board[0, 0].Mark == board[1, 1].Mark && board[1, 1].Mark == board[2, 2].Mark) return true;
            if (board[0, 2].Mark == board[1, 1].Mark && board[1, 1].Mark == board[2, 0].Mark) return true;
            return false;
        }
        //Maybe PrintBoard() is not related to Board class and should be in a View class (MVC)
        public void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j].Mark == Marks.Empty)
                    {
                        Console.Write($"|  -  ");
                    }

                    else
                    {
                        Console.WriteLine($"|  {board[i, j].Mark}  ");
                    }
                }
                Console.WriteLine("|");
            }
        }

    }
}
