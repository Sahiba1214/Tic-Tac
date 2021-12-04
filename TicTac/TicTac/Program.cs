using System;

namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTac game = new TicTacGame();
            game.gameBoard();
        }
    }
}
