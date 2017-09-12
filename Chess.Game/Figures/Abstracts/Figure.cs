namespace Chess.Game.Figures.Abstracts
{
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;

    public abstract class Figure : IFigure
    {
        protected Figure(ChessColor color)
        {
            this.Color = color;
        }

        public ChessColor Color { get; private set; }
    }
}
