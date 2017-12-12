using DSBoardGame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Domain.BehaviourModels
{
    public interface IEnemyAttack
    {
        int Value { get; }
        //AttackTypes AttackType { get; }
    }
}
