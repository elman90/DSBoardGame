namespace DSBoardGame.Domain.BehaviourModels.Characters
{
    interface IPushMovementBehaviour
    {
        IEnemyAttack Attack { get; }
        int Range { get; }
    }
}
