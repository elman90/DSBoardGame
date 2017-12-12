using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels.Characters
{
    public interface IPlayerStats
    {
        int Dexterity { get; }
        int Strength { get; }
        int Faith { get; }
        int Intelligence { get; }
    }
}
