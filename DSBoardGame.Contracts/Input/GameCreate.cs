using System;
using System.Collections.Generic;
using System.Text;

namespace DSBoardGame.Contracts.Input
{
   public class GameCreate
    {
        List<PlayerCreate> Players { get; }
        Guid MiniBossId { get; }
        Guid MainBossId { get;  }
    }

    public class PlayerCreate
    {
        string Name { get; }
        Guid ClassId { get; }

    }
}
