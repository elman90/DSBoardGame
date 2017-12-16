using System.Collections.Generic;
using DSBoardGame.Domain.Models.Environment;

namespace DSBoardGame.Domain.Models.Entities
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
