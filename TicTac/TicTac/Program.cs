using System;

namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac  Game");
            TicTacGame game = new TicTacGame();
            game.Board();
            game.PlayerChoosing();
            game.Display();
        }
    }
}
