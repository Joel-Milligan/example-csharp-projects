using System;
using TicTacToeClassLibrary;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();

            game.MakeMove(0, 0);
            game.MakeMove(0, 1);
            game.MakeMove(1, 0);
            game.MakeMove(2, 2);
            game.MakeMove(2, 0);

            Console.WriteLine("Winner = " + game.CheckWin());
            Console.WriteLine();

            game.PrintGame();
        }
    }
}
