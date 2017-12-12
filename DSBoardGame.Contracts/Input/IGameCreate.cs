using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Input
{
   public interface IGameCreate
    {
        List<IPlayerCreate> Players { get; }
        string MiniBossId { get; }
        string MainBossId { get;  }
    }
}
