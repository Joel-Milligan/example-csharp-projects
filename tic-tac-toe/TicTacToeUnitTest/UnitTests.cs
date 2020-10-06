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
            GameState emptyGame = new GameState();

            char[,] emptyState =
            {
                {'\0', '\0', '\0'},
                {'\0', '\0', '\0'},
                {'\0', '\0', '\0'}
            };

            Assert.True(compare2DArrays(emptyGame.CurrentBoard.BoardState, emptyState));
        }

        [Fact]
        public void MoveIntoNonEmptyCell()
        {
            GameState game = new GameState();

            game.MakeMove(0, 0);

            Assert.Throws<ArgumentException>(
                () => game.MakeMove(0, 0)
            );
        }

        [Fact]
        public void CheckWinCol()
        {
            GameState game = new GameState();

            game.MakeMove(0, 0);
            game.MakeMove(0, 1);
            game.MakeMove(1, 0);
            game.MakeMove(2, 2);
            game.MakeMove(2, 0);

            Assert.True(game.CheckWin() == 'x');
        }

        [Fact]
        public void CheckWinRow()
        {
            GameState game = new GameState();

            game.MakeMove(0, 0);
            game.MakeMove(1, 0);
            game.MakeMove(2, 2);
            game.MakeMove(1, 1);
            game.MakeMove(2, 0);
            game.MakeMove(1, 2);

            Assert.True(game.CheckWin() == 'o');
        }

        [Fact]
        public void CheckWinDiagonol()
        {
            GameState game = new GameState();

            game.MakeMove(0, 0);
            game.MakeMove(1, 0);
            game.MakeMove(2, 2);
            game.MakeMove(0, 1);
            game.MakeMove(1, 1);

            Assert.True(game.CheckWin() == 'x');
        }
    }
}
