using DSBoardGame.Contracts.BehaviourModels.Characters;
using DSBoardGame.Contracts.BehaviourModels.Game;
using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public enum AttackTypes
    {
        Physical = 1,
        Magical = 2
    }
    public enum DiceTypes
    {
        Black = 1,
        Blue = 2,
        Orange = 3,
        Green = 4
    }

    public enum WeaponHandleType
    {
        OneHanded = 1,
        TwoHanded = 2
    }
    public interface IGame
    {
        string Id { get;  }

        string Name { get;  }

        //List<IPlayer> Players { get; }

        ILocation CurrentLocation{ get; }
        IEnumerable<ILocation> PossibleLocations { get; }
        IEnumerable<IItem> TeamInventory { get; }
        IBoss MiniBoss { get; }

        IBoss MainBoss { get; }

    }
}
