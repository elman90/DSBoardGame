using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels.Characters
{
    public interface IPlayerClass
    {
        string ClassName { get; }
        IEquipment BaseEquipment { get; }
        IPlayerStats BaseStats { get; }
        //TODO: heroic actions
    }
}
