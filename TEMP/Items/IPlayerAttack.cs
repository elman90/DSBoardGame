namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IPlayerAttack
    {
        IItemValue Value { get; }
        AttackTypes AttackType { get; }
        int StaminaCost { get; }
    }
}
