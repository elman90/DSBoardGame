using System.Collections.Generic;
using TEMP.Characters;
using TEMP.Data;
using TEMP.Items;

namespace TEMP.Game
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

        List<IPlayer> Players { get; }

        ILocation CurrentLocation{ get; }
        IEnumerable<ILocation> PossibleLocations { get; }
        IEnumerable<IItem> TeamInventory { get; }
 

    }
}
