using System;
using System.Data;
using TicTacToeClassLibrary;

namespace TicTacToe
{
    class Program
    {
        static bool CheckUserInput(string input, int rows, int cols)
        {
            int row;
            int col;
            string[] move_numbers = input.Split(' ');

            if (move_numbers.Length < 2)
            {
                return false;
            }

            try
            {
                row = Int16.Parse(input.Split(' ')[0]);
                col = Int16.Parse(input.Split(' ')[1]);
            }
            catch (FormatException)
            {
                return false;
            }

            if (row >= rows || col >= cols)
            {
                return false;
            }
            else if (row < 0 || col < 0)
            {
                return false;
            }

            return true;
        }
        
        static void Main()
        {
            GameState game = new GameState();

            bool running = true;
            while (running)
            {
                game.PrintGame();

                Console.WriteLine("Enter a move in the form (row col): ");
                string move = Console.ReadLine();
                

                if (!CheckUserInput(move, game.CurrentBoard.Rows, game.CurrentBoard.Cols))
                {
                    Console.WriteLine("Incorrect format, please try again.");
                    continue;
                }

                int row = Int16.Parse(move.Split(' ')[0]);
                int col = Int16.Parse(move.Split(' ')[1]);

                game.MakeMove(row, col);                

                char winner = game.CheckWin();
                if (winner != '\0')
                {
                    game.PrintGame();

                    Console.WriteLine($"{winner} Won The Game!");
                    running = false;
                } 
            }
        }
    }
}
