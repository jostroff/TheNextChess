namespace Chess.Game.Chessboard
{
    using Chess.Game.Chessboard.Contracts;
    using Chess.Game.Commons;
    using Chess.Game.Figures.Contracts;
    using Chess.Game.Globals.Validators;
    using System;
    using static Chess.Game.Globals.Constants;

    public class Chessboard : IChessboard
    {
        private readonly IFigure[,] chessboard;

        public Chessboard(int rows = DefaultGameRows, int cols = DefaultGameCols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.chessboard = new IFigure[rows, cols];
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public IFigure[,] GetBoard { get { return this.chessboard; } }

        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.CheckIfObjectIsValid(figure, NullFigureMessage);
            ObjectValidator.CheckIfPositionIsValid(position, InvalidPositionMessage);
            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);
            this.chessboard[arrRow, arrCol] = figure;

        }

        public void RemoveFigure(Position position)
        {
            ObjectValidator.CheckIfPositionIsValid(position, InvalidPositionMessage);

            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);
            this.chessboard[arrRow, arrCol] = null;

        }

        private int GetArrayRow(int row)
        {
            return this.Rows - row;
        }

        private int GetArrayCol(int col)
        {
            return col - 'a';
        }
    }
}
