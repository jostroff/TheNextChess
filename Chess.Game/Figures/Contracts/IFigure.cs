using Chess.Game.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Game.Figures.Contracts
{
    public interface IFigure
    {
        ChessColor Color {get;}

        string Name { get; }
    }
}
