﻿namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Movements.Contracts;
    using System.Collections.Generic;

    public class King : Figure, IFigure
    {
        public King(ChessColor color) : base(color)
        {
        }
    }
}
