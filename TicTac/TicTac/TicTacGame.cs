using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac
{
    class TicTacGame
    {
        public void gameBoard()
        {
            char[] board = new char[10];

            {
                for (int i = 1; i < 10; i++)
                {
                    board[i] = ' ';
                }
            }
        }
    }
}
