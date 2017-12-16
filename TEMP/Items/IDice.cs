namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IDice
    {
        DiceTypes DiceType { get; }

        int[] DiceValues { get; }
    }
}
