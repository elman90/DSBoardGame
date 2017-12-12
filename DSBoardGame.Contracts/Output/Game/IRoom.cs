using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels.Game
{
    public interface ILocation
    {
        List<IPlayer> Players { get; }
    }
   public interface IRoom:ILocation
    {
        int RoomNo { get; }
        bool IsClear { get; }
        List<ISpawnedEnemy> Enemies { get; }

        List<IPosition> Positions { get; }
    }
}
