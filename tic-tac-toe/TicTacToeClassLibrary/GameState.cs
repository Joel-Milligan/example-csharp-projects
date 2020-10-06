using System;

namespace TicTacToeClassLibrary
{
    public class GameState
    {
        public Board CurrentBoard { get; set; }
        public char CurrentPlayer { get; set; }

        public GameState()
        {
            CurrentBoard = new Board();
            CurrentPlayer = 'x';
        }

        public void MakeMove(int row, int col)
        {
            if (CurrentPlayer == 'x' || CurrentPlayer == 'o')
            {
                if (this.CurrentBoard.BoardState[row, col] == '\0')
                {
                    this.CurrentBoard.BoardState[row, col] = CurrentPlayer;

                    if (this.CurrentPlayer == 'x')
                    {
                        this.CurrentPlayer = 'o';
                    }
                    else
                    {
                        this.CurrentPlayer = 'x';
                    }
                }
                else
                {
                    throw new ArgumentException($"Given cell ({row}, {col}) is not empty.");
                }
            }
            else
            {
                throw new ArgumentException($"Given player '{CurrentPlayer}' is an invalid character.");
            }
        }
        
        public void PrintGame()
        {
            Console.WriteLine($"{this.CurrentBoard.BoardState[0, 0]}|{this.CurrentBoard.BoardState[0, 1]}|{this.CurrentBoard.BoardState[0, 2]}");
            Console.WriteLine($"-+-+-");
            Console.WriteLine($"{this.CurrentBoard.BoardState[1, 0]}|{this.CurrentBoard.BoardState[1, 1]}|{this.CurrentBoard.BoardState[1, 2]}");
            Console.WriteLine($"-+-+-");
            Console.WriteLine($"{this.CurrentBoard.BoardState[2, 0]}|{this.CurrentBoard.BoardState[2, 1]}|{this.CurrentBoard.BoardState[2, 2]}");
        }

        public char CheckWin()
        {
            char player;

            // Check Each Row
            for (int row = 0; row < CurrentBoard.BoardState.GetLength(1); row++)
            {
                player = CurrentBoard.BoardState[row, 0];

                if (player == '\0')
                {
                    continue;
                }

                for (int col = 1; col < CurrentBoard.BoardState.GetLength(0); col++)
                {
                    if (CurrentBoard.BoardState[row, col] != player)
                    {
                        player = '\0';
                    }
                }

                if (player != '\0')
                {
                    return player;
                }
            }

            // Check Each Column
            for (int col = 0; col < CurrentBoard.BoardState.GetLength(0); col++)
            {
                player = CurrentBoard.BoardState[0, col];

                if (player == '\0')
                {
                    continue;
                }

                for (int row = 1; row < CurrentBoard.BoardState.GetLength(1); row++)
                {
                    if (CurrentBoard.BoardState[row, col] != player)
                    {
                        player = '\0';
                    }
                }

                if (player != '\0')
                {
                    return player;
                }
            }

            // Check Each Diagonol
            player = CurrentBoard.BoardState[0, 0];
            for (int i = 1; i < CurrentBoard.BoardState.GetLength(0); i++)
            {
                if (player == '\0')
                {
                    continue;
                }

                if (CurrentBoard.BoardState[i, i] != player)
                {
                    player = '\0';
                }
                

                if (player != '\0')
                {
                    return player;
                }
            }

            player = CurrentBoard.BoardState[0, 2];
            for (int i = 0; i < CurrentBoard.BoardState.GetLength(0); i++)
            {
                if (player == '\0')
                {
                    continue;
                }

                if (CurrentBoard.BoardState[i, (CurrentBoard.BoardState.GetLength(0) - 1) - i] != player)
                {
                    player = '\0';
                }


                if (player != '\0')
                {
                    return player;
                }
            }

            // No Winner
            return '\0';
        }
    }
}
