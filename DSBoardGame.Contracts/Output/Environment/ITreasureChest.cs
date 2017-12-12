using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels.Environment
{
    public interface ITreasureChest : IBasePawn
    {
        bool Opened { get; }

    }
}
