using DSBoardGame.Contracts.BehaviourModels.Characters;
using DSBoardGame.Contracts.BehaviourModels.Environment;
using System.Collections.Generic;

namespace DSBoardGame.Contracts.BehaviourModels
{
    public interface IPlayer :ICharacter,IBasePawn
    {
        IEquipment Equipment { get; }
        List<IItem> Inventory { get; }
        IPlayerClass Class { get; }
        IPlayerStats Stats { get; }
        //void ChangeEquipment(IEquipment equipment);
    }
}
