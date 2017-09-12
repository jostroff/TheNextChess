namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;

    public class Queen : Figure, IFigure
    {
        public Queen(ChessColor color) : base(color)
        {
        }
    }
}
