namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Movements.Contracts;
    using System.Collections.Generic;

    public class Rook : Figure, IFigure
    {
        public Rook(ChessColor color) : base(color)
        {
        }

    }
}
