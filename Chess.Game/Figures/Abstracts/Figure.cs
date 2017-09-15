namespace Chess.Game.Figures.Abstracts
{
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;

    public abstract class Figure : IFigure
    {
        protected readonly string name;
        protected Figure(ChessColor color)
        {
            this.Color = color;
            this.name = this.GetType().Name;
        }

        public ChessColor Color { get; private set; }

        public string Name { get { return this.name; } }
    }
}
