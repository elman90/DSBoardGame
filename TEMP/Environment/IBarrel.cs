using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.BehaviourModels.Environment
{
   public interface IBarrel:IBasePawn
    {
        bool IsDestroyed { get; }
        //void Destroy();
    }
}
