namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;

    public class Rook : Figure, IFigure
    {
        public Rook(ChessColor color) : base(color)
        {
        }
    }
}
