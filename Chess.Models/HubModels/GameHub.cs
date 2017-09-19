namespace Chess.Models.HubModels
{
    using Chess.Game.GameEngine.Contracts;
    using System;
    using System.Collections.Generic;

    public class GameHub
    {
        public GameHub()
        {
            this.Players = new HashSet<UserHub>();
        }

        public Guid GameId { get; set; }

        public IEngine GameEngine { get; set; }

        public ICollection<UserHub> Players { get; set; }
    }
}
