using DSBoardGame.Domain.BehaviourModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain.BehaviourModels.Cards
{
    public interface IBehaviourCard
    {
        string Name { get; }
        IEnemyBehaviour Behaviour { get; }
    }
}
