using System;
using System.Linq;
using Xunit;
using TicTacToeClassLibrary;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToeUnitTest
{
    public class UnitTests
    {
        public bool compare2DArrays(char[,] arr1, char[,] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            
            for (int row = 0; row < arr1.GetLength(0); row++)
            {
                for (int col = 0; col < arr1.GetLength(1); col++)
                {
                    if (arr1[row, col] != arr2[row, col])
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        [Fact]
        public void CreateNewBoard()
        {
            Board emptyBoard = new Board();

            char[,] emptyState =
            {
                {'\0', '\0', '\0'},
                {'\0', '\0', '\0'},
                {'\0', '\0', '\0'}
            };

            Assert.True(compare2DArrays(emptyBoard.BoardState, emptyState));
        }

        [Fact]  
        public void InvalidCharMove()
        {
            Board board = new Board();

            Assert.Throws<ArgumentException>(
                () => board.MakeMove('z', 0, 0)
            );

            board.MakeMove('o', 1, 1);
            board.MakeMove('x', 2, 2);
        }

        [Fact]
        public void MoveIntoNonEmptyCell()
        {
            Board board = new Board();
            board.MakeMove('x', 0, 0);

            Assert.Throws<ArgumentException>(
                () => board.MakeMove('o', 0, 0)
            );
        }
    }
}
