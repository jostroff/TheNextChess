using Chess.Game.Players;
using Chess.Game.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Game.GameEngine.Contracts
{
    public interface IEngine
    {
        IEnumerable<IPlayer> Players { get; }

        void Initialize(IGameInitializationStrategy strategy);

        void Start();

        void WinningCondition();
    }
}
