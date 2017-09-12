namespace Chess.Game.Commons
{
    using System;

    public class Position
    {
        public Position(int row, int col)
        {
            this.Col = col;
            this.Row = row;
        }

        public int Col { get; private set; }

        public int Row { get; private set; }
    }
}
