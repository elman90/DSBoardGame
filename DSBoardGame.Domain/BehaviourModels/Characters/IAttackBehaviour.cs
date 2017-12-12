using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain.BehaviourModels.Characters
{
    public interface IAttackBehaviour
    {
        IEnemyAttack Attack { get; }
    }
}
