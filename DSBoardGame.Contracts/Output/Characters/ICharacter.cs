using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{

    public interface ICharacter
    {

        string Name { get; }
        int MaxHp { get; }
        int CurrentHp { get; }
        List<IAction> PossibleActions { get; }
    }
}
