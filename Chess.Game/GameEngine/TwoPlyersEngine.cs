namespace Chess.Game.GameEngine
{
    using Chess.Game.GameEngine.Contracts;
    using System;
    using Chess.Game.Players.Contracts;
    using System.Collections.Generic;

    public class TwoPlyersEngine : IEngine
    {
        private readonly ICollection<IPlayer> players;

        public IEnumerable<IPlayer> Players { get { return new List<IPlayer>(this.players); } }

        public void Initialize(IGameInitializationStrategy strategy)
        {
            throw new NotImplementedException();
        }

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
