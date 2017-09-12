namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;

    public class King : Figure, IFigure
    {
        public King(ChessColor color) : base(color)
        {
        }
    }
}
