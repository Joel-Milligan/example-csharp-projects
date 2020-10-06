using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeClassLibrary
{
    public class Board
    {
        public char[,] BoardState { get; set; }
        
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
    }
}
    