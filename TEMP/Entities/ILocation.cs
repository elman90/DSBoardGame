using System.Collections.Generic;
using TEMP.Characters;
using TEMP.Environment;

namespace TEMP.Game
{
    public interface ILocation
    {
        List<IPlayer> Players { get; }
        int RoomNo { get; }
        bool IsClear { get; }
        List<IEnemy> Enemies { get; }

        List<IPosition> Positions { get; }
    }
  
}
