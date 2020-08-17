using System;

namespace Kata.GameOfLife
{
    public class GameBoard : ICloneable
    {
        public char[,] board;
        public readonly int rows;
        public readonly int columns;

        public GameBoard(char[,] board, int rows, int columns)
        {
            this.board = board;
            this.rows = rows;
            this.columns = columns;
        }

        public object Clone()
        {
            return new GameBoard((char[,])board.Clone(), rows, columns);
        }
    }
}
