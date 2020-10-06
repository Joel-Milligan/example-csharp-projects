using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeClassLibrary
{
    public class Board
    {
        public char[,] BoardState { get; set; }
        public char CurrentPlayer { get; set; }

        // Create an empty board
        public Board()
        {
            BoardState = new char[3, 3];
            this.EmptyBoard();
        }

        public void EmptyBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    this.BoardState[row, col] = '\0';
                }
            }
        }

        public void MakeMove(char player, int row, int col)
        {
            if(player == 'x' || player == 'o')
            {
                if(this.BoardState[row, col] == '\0')
                {
                    this.BoardState[row, col] = player;
                }
                else
                {
                    throw new ArgumentException($"Given cell ({row}, {col}) is not empty.");
                }
            }
            else
            {
                throw new ArgumentException($"Given player '{player}' is an invalid character.");
            }
        }
    }
}
    