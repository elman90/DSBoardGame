namespace DSBoardGame.Domain.BehaviourModels.Characters
{
    public interface IMovementBehaviour :IBehaviour
    {
        int Range { get; }

    }
}
