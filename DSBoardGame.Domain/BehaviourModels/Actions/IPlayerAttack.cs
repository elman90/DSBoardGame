using DSBoardGame.Contracts.BehaviourModels;
using DSBoardGame.Domain.Models;

namespace DSBoardGame.Domain.BehaviourModels
{
    public interface IPlayerAttack
    {
        IItemValue Value { get; }
        AttackTypes AttackType { get; }
        int StaminaCost { get; }
    }
}
