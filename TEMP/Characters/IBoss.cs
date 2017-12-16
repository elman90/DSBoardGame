using System;
using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels.Characters
{
    public interface IBoss :ISpawnedEnemy
    {
        //IEnemyBehaviour CurrentBehaviour { get; }
        //void SetBehaviour(IBehaviourCard behaviourCard);
        //List<IBehaviourCard> BehaviourDeck { get; }
        List<Tuple<int,int>> EncounterCards { get; }
        bool Defeated { get; }
    }
}
