using DSBoardGame.Contracts.BehaviourModels.Characters;
using DSBoardGame.Contracts.BehaviourModels.Environment;
using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IEncounterCard
    {
        List<ISpawnedEnemy> EnemyList { get; }
       // List<string> EnemyList { get; }
        bool isTrapped { get; }
        ITreasureChest TreasureChest { get; }
        List<string> BarrelLocations { get; }
       // int EncounterLevel { get; }
    }
}
