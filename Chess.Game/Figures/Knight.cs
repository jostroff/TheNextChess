namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Abstracts;

    public class Knight : Figure, IFigure
    {
        public Knight(ChessColor color) : base(color)
        {
        }
    }
}
