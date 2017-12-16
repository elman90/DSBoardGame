using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels.Environment
{
   public interface IBasePawn
    {
        string Id { get; }
        IPosition CurrentPosition { get; }
    }
}
