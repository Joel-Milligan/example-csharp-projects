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
    }
}
