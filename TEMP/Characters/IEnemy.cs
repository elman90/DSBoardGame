using DSBoardGame.Contracts.BehaviourModels.Environment;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface ISpawnedEnemy :ICharacter,IBasePawn
    {
     
        int PhysicalDefense { get; }
        int MagicalDefense { get; }
    }
}
