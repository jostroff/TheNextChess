namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Abstracts;

    public class Pawn : Figure, IFigure
    {
        public Pawn(ChessColor color) : base(color)
        {
        }
    }
}
