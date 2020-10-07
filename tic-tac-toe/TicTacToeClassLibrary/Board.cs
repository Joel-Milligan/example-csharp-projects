using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeClassLibrary
{
    public class Board
    {
        public char[,] BoardState { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }

        public Board()
        {
            this.Rows = 3;
            this.Cols = 3;

            BoardState = new char[this.Rows, this.Cols];
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
    }
}
    