namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Movements.Contracts;
    using System.Collections.Generic;

    public class Queen : Figure, IFigure
    {
        public Queen(ChessColor color) : base(color)
        {
        }

    }
}
