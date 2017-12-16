using DSBoardGame.Contracts.BehaviourModels.Environment;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface ITrap : IBasePawn
    {
        int Damage { get; }

        bool IsEnabled { get; }

    
    }
}
