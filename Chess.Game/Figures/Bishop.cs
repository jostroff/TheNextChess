﻿namespace Chess.Game.Figures
{
    using Chess.Game.Figures.Abstracts;
    using Chess.Game.Figures.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Movements.Contracts;
    using System.Collections.Generic;

    public class Bishop : Figure, IFigure
    {
        public Bishop(ChessColor color) : base(color)
        {

        }
    }
}
