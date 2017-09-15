namespace Chess.Game.GameEngine
{
    using Chess.Game.GameEngine.Contracts;
    using System;
    using Chess.Game.Players.Contracts;
    using System.Collections.Generic;
    using Chess.Game.InputProviders.Contracts;
    using Chess.Game.Chessboard;
    using Chess.Game.Chessboard.Contracts;

    public class TwoPlyersEngine : IEngine
    {
        private readonly ICollection<IPlayer> players;
        private readonly IInputProvider input;
        private readonly IChessboard board;

        public IEnumerable<IPlayer> Players { get { return new List<IPlayer>(this.players); } }

        public TwoPlyersEngine(IInputProvider input)
        {
            this.input = input;
            this.board = new Chessboard();
        }

        public void Initialize(IGameInitializationStrategy strategy, string firstPlayerName, string secontPlayerName)
        {
            var players = this.input.GetPlayers(firstPlayerName, secontPlayerName);
            strategy.Initialize(players, this.board);
        }

        public IChessboard GetBoard { get { return this.board; } }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void WinningCondition()
        {
            throw new NotImplementedException();
        }
    }
}
