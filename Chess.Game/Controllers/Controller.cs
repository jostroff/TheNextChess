namespace Chess.Game.Controllers
{
    using Chess.Game.Controllers.Contracts;
    using System;
    using Chess.Game.Commons;
    using Chess.Game.Chessboard.Contracts;
    using Chess.Game.Figures.Contracts;
    using Chess.Game.Players.Contracts;

    public class Controller : IController
    {
        private readonly IChessboard board;

        public Controller(IChessboard board)
        {
            this.board = board;
        }

        public void MakeMove(IPlayer player , Position from, Position to)
        {
            var squareFrom = this.board.GetBoard[from.Row, from.Col];
            var squareTo = this.board.GetBoard[to.Row, to.Col];

            if (squareFrom == null)
            {
                throw new InvalidOperationException($"Empty square");
            }

            if (squareFrom.Color != player.Color)
            {
                throw new InvalidOperationException($"{player.Color} player cannot move this figure");
            }

            if (squareTo == null)
            {
                this.MoveFigure(squareFrom,from, to);
            }
            else if (squareTo.Color != player.Color)
            {
                this.GetFigure(from, to);
            }

        }

        private void GetFigure(Position from, Position to)
        {
            throw new NotImplementedException();
        }

        private void MoveFigure(IFigure figure, Position from, Position to)
        {
            var figureToMove = this.board.RemoveFigure(from);
            this.board.AddFigure(figure, to);
        }
    }
}
